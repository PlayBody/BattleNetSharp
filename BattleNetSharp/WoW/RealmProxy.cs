using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using D2Packets;
using D2Packets.Game.Client;
using D2Packets.Game.Server;
using Framework.Constants;
using Utilities;
using WoW.Packets;

namespace BattleNetSharp.WoW
{
	// Token: 0x02000AF2 RID: 2802
	public class RealmProxy
	{
		// Token: 0x0600BD72 RID: 48498 RVA: 0x00486020 File Offset: 0x00484220
		public RealmProxy()
		{
			this.logging = true;
		}

		// Token: 0x0600BD73 RID: 48499 RVA: 0x00486050 File Offset: 0x00484250
		public void ConnectToServer(IPAddress server)
		{
			this.LODServer = new TcpClient();
			this.LODServer.Connect(server, 3724);
			this.LODServerStream = this.LODServer.GetStream();
			this.WaitingForServer = false;
			Task.Run(delegate
			{
				while (this.WaitingForServer || this.WaitingForClient)
				{
					Thread.Sleep(100);
				}
				while (this.LODServer.Connected && (!this.LODServer.Client.Poll(1, SelectMode.SelectRead) || this.LODServer.Client.Available != 0))
				{
					try
					{
						this.HandlePacket(false);
					}
					catch (Exception ex)
					{
						Console.WriteLine("error in lod client : " + ex.Message);
						Console.WriteLine(ex.StackTrace);
					}
				}
			});
			Console.WriteLine("connected to LOD");
		}

		// Token: 0x0600BD74 RID: 48500 RVA: 0x004860B0 File Offset: 0x004842B0
		public void OpenProxyServer(TcpClient tcpClient)
		{
			this.D2RClient = tcpClient;
			this.D2RClientStream = this.D2RClient.GetStream();
			this.WaitingForClient = false;
			Task.Run(delegate
			{
				while (this.WaitingForServer || this.WaitingForClient)
				{
					Thread.Sleep(100);
				}
				while (this.D2RClient.Connected && (!this.D2RClient.Client.Poll(1, SelectMode.SelectRead) || this.D2RClient.Client.Available != 0))
				{
					try
					{
						this.HandlePacket(true);
					}
					catch (Exception ex)
					{
						Console.WriteLine("error in d2r client : " + ex.Message);
						Console.WriteLine(ex.StackTrace);
					}
				}
				Console.WriteLine("connection end : ");
				TcpClient lodserver = this.LODServer;
				if (lodserver != null)
				{
					lodserver.Close();
				}
			});
		}

		// Token: 0x0600BD75 RID: 48501 RVA: 0x004860E4 File Offset: 0x004842E4
		public IEnumerable<byte> ReadPacket(bool d2rClient)
		{
			TcpClient tcpClient = (d2rClient ? this.D2RClient : this.LODServer);
			NetworkStream networkStream = (d2rClient ? this.D2RClientStream : this.LODServerStream);
			IEnumerable<byte> enumerable;
			try
			{
				List<byte> list = new List<byte>();
				while (tcpClient.Connected && !networkStream.DataAvailable)
				{
					Thread.Sleep(20);
				}
				bool flag = tcpClient.Connected && networkStream.DataAvailable;
				if (flag)
				{
					byte[] array = new byte[1024];
					do
					{
						int num = networkStream.Read(array, 0, array.Length);
						list.AddRange(array.Take(num));
					}
					while (networkStream.DataAvailable);
				}
				else
				{
					Thread.Sleep(50);
				}
				enumerable = list;
			}
			catch
			{
				enumerable = new List<byte>();
			}
			return enumerable;
		}

		// Token: 0x0600BD76 RID: 48502 RVA: 0x004861C0 File Offset: 0x004843C0
		public void HandlePacket(bool d2rClient)
		{
			byte[] array = this.ReadPacket(d2rClient).ToArray<byte>();
			Console.WriteLine(string.Concat(new string[]
			{
				d2rClient ? "d2r" : "lod",
				" proxy recv (",
				DateTime.UtcNow.ToString("HH:mm:ss.fff"),
				"): ",
				BitConverter.ToString(array)
			}));
			ServerOpcodes serverOpcodes = (ServerOpcodes)BitConverter.ToUInt16(array.ToArray<byte>());
			bool flag = serverOpcodes == ServerOpcodes.CompressedPacket;
			if (flag)
			{
				uint num = BitConverter.ToUInt32(array.Skip(2).ToArray<byte>());
				uint num2 = BitConverter.ToUInt32(array.Skip(6).ToArray<byte>());
				uint num3 = BitConverter.ToUInt32(array.Skip(10).ToArray<byte>());
				IEnumerable<byte> enumerable = array.Skip(14);
				Console.WriteLine("decompressing : " + BitConverter.ToString(array.ToArray<byte>()).Replace("-", ""));
				array = Helpers.DecompressStream(enumerable.ToArray<byte>(), num);
			}
			else
			{
				bool flag2 = serverOpcodes == ServerOpcodes.MultiplePackets;
				if (flag2)
				{
					throw new Exception("todo");
				}
			}
			string text = serverOpcodes.ToString();
			uint num4;
			bool flag3 = uint.TryParse(text, out num4);
			if (flag3)
			{
				text = "0x" + serverOpcodes.ToString("X");
			}
			Console.WriteLine(string.Concat(new string[]
			{
				"s2c : ",
				text,
				" : ",
				DateTime.Now.ToString(),
				" : ",
				BitConverter.ToString(array.ToArray<byte>())
			}));
			bool flag4 = !text.Contains("0x");
			if (flag4)
			{
				Packet packet = (Packet)Activator.CreateInstance(Type.GetType(text.ToString()));
				packet.Bytes = array;
				MethodInfo method = base.GetType().GetMethod(text, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
				bool flag5 = method != null;
				if (flag5)
				{
					array = ((Packet)method.Invoke(this, new object[] { packet })).ToArray();
				}
			}
			if (d2rClient)
			{
				this.LODServerStream.Write(array, 0, array.Length);
			}
			else
			{
				this.D2RClientStream.Write(array, 0, array.Length);
			}
		}

		// Token: 0x0600BD77 RID: 48503 RVA: 0x00486420 File Offset: 0x00484620
		private EnterEncryptedMode EnterEncryptedMode(EnterEncryptedMode e)
		{
			return e;
		}

		// Token: 0x0600BD78 RID: 48504 RVA: 0x00486434 File Offset: 0x00484634
		public virtual void SendPacket(byte[] packetBytes, bool toD2rClient)
		{
			string text;
			if (!toD2rClient)
			{
				GameClientPacketD2R gameClientPacketD2R = (GameClientPacketD2R)packetBytes[0];
				text = gameClientPacketD2R.ToString();
			}
			else
			{
				GameServerPacket gameServerPacket = (GameServerPacket)packetBytes[0];
				text = gameServerPacket.ToString();
			}
			string text2 = text;
			Console.WriteLine(string.Concat(new string[]
			{
				"injected packet to ",
				toD2rClient ? "d2r client" : "lod server",
				" : (",
				DateTime.UtcNow.ToString("HH:mm:ss.fff"),
				"): ",
				text2,
				" : ",
				BitConverter.ToString(packetBytes)
			}));
			try
			{
				if (toD2rClient)
				{
					this.D2RClientStream.Write(packetBytes, 0, packetBytes.Length);
				}
				else
				{
					this.LODServerStream.Write(packetBytes, 0, packetBytes.Length);
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600BD79 RID: 48505 RVA: 0x00486518 File Offset: 0x00484718
		private void Undefined(List<byte> data)
		{
			string[] array = new string[5];
			int num = 0;
			IPAddress address = (this.D2RClient.Client.RemoteEndPoint as IPEndPoint).Address;
			array[num] = ((address != null) ? address.ToString() : null);
			array[1] = " : UNKNOWN GAME PACKET : ";
			int num2 = 2;
			object obj = Enum.Parse(typeof(GameClientPacket), data[0].ToString());
			array[num2] = ((obj != null) ? obj.ToString() : null);
			array[3] = " | ";
			array[4] = BitConverter.ToString(data.ToArray());
			Console.WriteLine(string.Concat(array));
		}

		// Token: 0x04009169 RID: 37225
		public TcpClient D2RClient;

		// Token: 0x0400916A RID: 37226
		public NetworkStream D2RClientStream;

		// Token: 0x0400916B RID: 37227
		public TcpClient LODServer;

		// Token: 0x0400916C RID: 37228
		public NetworkStream LODServerStream;

		// Token: 0x0400916D RID: 37229
		public uint Hash;

		// Token: 0x0400916E RID: 37230
		public ushort Token;

		// Token: 0x0400916F RID: 37231
		public bool Compression = false;

		// Token: 0x04009170 RID: 37232
		public Thread PacketHandlerThread;

		// Token: 0x04009171 RID: 37233
		public bool logging = true;

		// Token: 0x04009172 RID: 37234
		private bool WaitingForServer = true;

		// Token: 0x04009173 RID: 37235
		private bool WaitingForClient = true;

		// Token: 0x04009174 RID: 37236
		public static bool firstCheck;
	}
}
