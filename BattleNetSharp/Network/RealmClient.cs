using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using D2Packets;
using Framework.Constants;
using Utilities;
using WoW.Packets;

namespace BattleNetSharp.Network
{
	// Token: 0x02000B0F RID: 2831
	public class RealmClient
	{
		// Token: 0x17003950 RID: 14672
		// (get) Token: 0x0600BE27 RID: 48679 RVA: 0x00488313 File Offset: 0x00486513
		// (set) Token: 0x0600BE28 RID: 48680 RVA: 0x0048831B File Offset: 0x0048651B
		public virtual int Port { get; set; }

		// Token: 0x0600BE29 RID: 48681 RVA: 0x00488324 File Offset: 0x00486524
		public bool Connect(IPAddress server, byte[] clientSecret, byte[] joinSecret, byte[] joinTicket, int port = 3724)
		{
			this.ServerHost = server;
			bool flag = this.Port == 0;
			if (flag)
			{
				this.Port = port;
			}
			bool flag2 = this.Port == 0;
			if (flag2)
			{
				throw new Exception("");
			}
			this.ClientSecret = clientSecret;
			this.JoinSecret = joinSecret;
			this.JoinTicket = joinTicket;
			this.TcpClient.Connect(server, this.Port);
			this.Stream = this.TcpClient.GetStream();
			IEnumerable<byte> enumerable = this.ReadBytes();
			bool flag3 = !Encoding.UTF8.GetString(enumerable.ToArray<byte>()).StartsWith("WORLD OF WARCRAFT CONNECTION - SERVER TO CLIENT - V2");
			if (flag3)
			{
				throw new Exception("invalid server hello");
			}
			this.Stream.Write(Encoding.UTF8.GetBytes("WORLD OF WARCRAFT CONNECTION - CLIENT TO SERVER - V2\n"));
			IEnumerable<byte> enumerable2 = this.ReadPacket(false);
			bool flag4 = BitConverter.ToUInt16(enumerable2.ToArray<byte>()) != 12360;
			if (flag4)
			{
				throw new Exception("invalid AuthChallenge");
			}
			AuthChallenge authChallenge = new AuthChallenge
			{
				Bytes = enumerable2.Skip(2)
			};
			Console.WriteLine(string.Concat(new string[]
			{
				"recv AuthChallenge : ",
				BitConverter.ToString(authChallenge.DosChallenge.ToArray()),
				" : ",
				BitConverter.ToString(authChallenge.Challenge.ToArray()),
				" : ",
				authChallenge.DosZeroBits.ToString()
			}));
			this.LocalChallenge = RandomNumberGenerator.GetBytes(16);
			Console.WriteLine("clientSecret : " + BitConverter.ToString(clientSecret).Replace("-", ""));
			Console.WriteLine("joinSecret : " + BitConverter.ToString(joinSecret).Replace("-", ""));
			Console.WriteLine("local challenge : " + BitConverter.ToString(this.LocalChallenge).Replace("-", ""));
			Console.WriteLine("serv challenge : " + BitConverter.ToString(authChallenge.Challenge.ToArray()).Replace("-", ""));
			AuthSession authSession = new AuthSession(clientSecret, joinSecret.ToArray<byte>(), this.LocalChallenge, authChallenge.Challenge.ToArray());
			AuthSession authSession2 = authSession;
			byte[] array = new byte[8];
			array[0] = 1;
			authSession2.DosResponse = array;
			authSession.RegionID = 1U;
			authSession.BattlegroupID = 3U;
			authSession.RealmID = 25U;
			authSession.UseIPv6 = 0;
			authSession.RealmJoinTicketLen = (uint)joinTicket.ToList<byte>().Count;
			authSession.RealmJoinTicket = joinTicket.ToList<byte>();
			AuthSession authSession3 = authSession;
			bool flag5 = RealmClient.Puzzle.SolveDOSChallenge(authChallenge.DosChallenge.ToArray(), (int)authChallenge.DosZeroBits, authSession3.DosResponse);
			Thread.Sleep(200);
			this.SendPacket(authSession3);
			IEnumerable<byte> enumerable3 = this.ReadPacket(false);
			bool flag6 = BitConverter.ToUInt16(enumerable3.ToArray<byte>()) == 9580;
			bool flag7;
			if (flag6)
			{
				AuthResponse.BattlenetRpcErrorCode battlenetRpcErrorCode = (AuthResponse.BattlenetRpcErrorCode)BitConverter.ToUInt32(enumerable3.ToArray<byte>(), 2);
				this.TcpClient.Close();
				Console.WriteLine("fail attempt 1 : " + battlenetRpcErrorCode.ToString());
				flag7 = false;
			}
			else
			{
				new EnterEncryptedMode().Bytes = enumerable3;
				this.SendPacket(new EnterEncryptedModeAck());
				byte[] aesKey = AuthSession.GetAesKey(clientSecret, joinSecret, this.LocalChallenge, authChallenge.Challenge.ToArray(), out this.SessionKey);
				this.Crypto = new AesGcm(aesKey);
				string text = Convert.ToHexString(enumerable3.ToArray<byte>());
				string text2 = Convert.ToHexString(aesKey.ToArray<byte>());
				while (this.HandlePackets)
				{
					Thread.Sleep(200);
					IEnumerable<byte> enumerable4 = this.ReadPacket(false);
					this.HandlePacket(enumerable4);
					bool flag8 = !this.TcpClient.Connected;
					if (flag8)
					{
						break;
					}
				}
				flag7 = true;
			}
			return flag7;
		}

		// Token: 0x0600BE2A RID: 48682 RVA: 0x0048870C File Offset: 0x0048690C
		public bool ContinueConnect(IPAddress server, byte[] key, byte[] sessionKey, int port = 3724)
		{
			this.ServerHost = server;
			bool flag = this.Port == 0;
			if (flag)
			{
				this.Port = port;
			}
			bool flag2 = this.Port == 0;
			if (flag2)
			{
				throw new Exception("");
			}
			this.LocalChallenge = RandomNumberGenerator.GetBytes(16);
			this.TcpClient.Connect(server, this.Port);
			this.Stream = this.TcpClient.GetStream();
			IEnumerable<byte> enumerable = this.ReadBytes();
			bool flag3 = !Encoding.UTF8.GetString(enumerable.ToArray<byte>()).StartsWith("WORLD OF WARCRAFT CONNECTION - SERVER TO CLIENT - V2");
			if (flag3)
			{
				throw new Exception("invalid server hello");
			}
			this.Stream.Write(Encoding.UTF8.GetBytes("WORLD OF WARCRAFT CONNECTION - CLIENT TO SERVER - V2\n"));
			IEnumerable<byte> enumerable2 = this.ReadPacket(false);
			bool flag4 = BitConverter.ToUInt16(enumerable2.ToArray<byte>()) != 12360;
			if (flag4)
			{
				throw new Exception("invalid AuthChallenge");
			}
			AuthChallenge authChallenge = new AuthChallenge
			{
				Bytes = enumerable2.Skip(2)
			};
			Console.WriteLine(string.Concat(new string[]
			{
				"recv AuthChallenge during continued : ",
				(server != null) ? server.ToString() : null,
				" : ",
				BitConverter.ToString(authChallenge.DosChallenge.ToArray()),
				" : ",
				BitConverter.ToString(authChallenge.Challenge.ToArray()),
				" : ",
				authChallenge.DosZeroBits.ToString()
			}));
			AuthContinuedSession authContinuedSession = new AuthContinuedSession(key, sessionKey, this.LocalChallenge, authChallenge.Challenge.ToArray());
			bool flag5 = RealmClient.Puzzle.SolveDOSChallenge(authChallenge.DosChallenge.ToArray(), (int)authChallenge.DosZeroBits, authContinuedSession.DosResponse);
			Thread.Sleep(200);
			this.SendPacket(authContinuedSession);
			IEnumerable<byte> enumerable3 = this.ReadPacket(false);
			bool flag6 = BitConverter.ToUInt16(enumerable3.ToArray<byte>()) == 9580;
			bool flag7;
			if (flag6)
			{
				AuthResponse.BattlenetRpcErrorCode battlenetRpcErrorCode = (AuthResponse.BattlenetRpcErrorCode)BitConverter.ToUInt32(enumerable3.ToArray<byte>(), 2);
				this.TcpClient.Close();
				Console.WriteLine("fail continue : " + battlenetRpcErrorCode.ToString());
				flag7 = false;
			}
			else
			{
				new EnterEncryptedMode().Bytes = enumerable3;
				this.SendPacket(new EnterEncryptedModeAck());
				this.SessionKey = sessionKey.ToList<byte>();
				this.Crypto = new AesGcm(AuthSession.GetAesKey(sessionKey, this.LocalChallenge, authChallenge.Challenge.ToArray()));
				Console.WriteLine("Continue Crypto : " + BitConverter.ToString(AuthSession.GetAesKey(sessionKey, this.LocalChallenge, authChallenge.Challenge.ToArray())).Replace("-", ""));
				while (this.HandlePackets)
				{
					Thread.Sleep(200);
					IEnumerable<byte> enumerable4 = this.ReadPacket(false);
					this.HandlePacket(enumerable4);
					bool flag8 = !this.TcpClient.Connected;
					if (flag8)
					{
						break;
					}
				}
				flag7 = true;
			}
			return flag7;
		}

		// Token: 0x0600BE2B RID: 48683 RVA: 0x00488A18 File Offset: 0x00486C18
		public IEnumerable<byte> ReadBytes()
		{
			List<byte> list = new List<byte>();
			bool flag = this.Stream is NetworkStream;
			if (flag)
			{
				while (((NetworkStream)this.Stream).DataAvailable)
				{
					list.Add((byte)this.Stream.ReadByte());
				}
			}
			else
			{
				int num = 0;
				while ((long)num < this.Stream.Length)
				{
					list.Add((byte)this.Stream.ReadByte());
					num++;
				}
			}
			bool flag2 = list.Count == 0;
			IEnumerable<byte> enumerable;
			if (flag2)
			{
				Thread.Sleep(50);
				enumerable = this.ReadBytes();
			}
			else
			{
				enumerable = list;
			}
			return enumerable;
		}

		// Token: 0x0600BE2C RID: 48684 RVA: 0x00488AC4 File Offset: 0x00486CC4
		public IEnumerable<byte> ReadPacket(bool test = false)
		{
			while (test)
			{
				Console.WriteLine((int)((byte)this.Stream.ReadByte()));
			}
			List<byte> list = new List<byte>();
			for (int i = 0; i < 4; i++)
			{
				list.Add((byte)this.Stream.ReadByte());
			}
			uint num = BitConverter.ToUInt32(list.ToArray());
			bool flag = num == uint.MaxValue;
			IEnumerable<byte> enumerable;
			if (flag)
			{
				Console.WriteLine("server returned ff's");
				enumerable = null;
			}
			else
			{
				List<byte> list2 = new List<byte>();
				List<byte> list3 = new List<byte>();
				for (int j = 0; j < 12; j++)
				{
					list3.Add((byte)this.Stream.ReadByte());
				}
				int num2 = 0;
				while ((long)num2 < (long)((ulong)num))
				{
					list2.Add((byte)this.Stream.ReadByte());
					num2++;
				}
				bool flag2 = this.Crypto != null;
				if (flag2)
				{
					byte[] array = new byte[num];
					this.Crypto.Decrypt(BitConverter.GetBytes(this.serverPacketCount).Concat(this.SRVR).ToArray<byte>(), list2.ToArray(), list3.ToArray(), array, null);
					list2 = array.ToList<byte>();
				}
				ServerOpcodes serverOpcodes = (ServerOpcodes)BitConverter.ToUInt16(list2.ToArray());
				this.serverPacketCount += 1UL;
				enumerable = list2;
			}
			return enumerable;
		}

		// Token: 0x0600BE2D RID: 48685 RVA: 0x00488C2C File Offset: 0x00486E2C
		public void HandlePacket(IEnumerable<byte> packetBytes)
		{
			ServerOpcodes serverOpcodes = (ServerOpcodes)BitConverter.ToUInt16(packetBytes.ToArray<byte>());
			bool flag = serverOpcodes == ServerOpcodes.CompressedPacket;
			if (flag)
			{
				uint num = BitConverter.ToUInt32(packetBytes.Skip(2).ToArray<byte>());
				uint num2 = BitConverter.ToUInt32(packetBytes.Skip(6).ToArray<byte>());
				uint num3 = BitConverter.ToUInt32(packetBytes.Skip(10).ToArray<byte>());
				IEnumerable<byte> enumerable = packetBytes.Skip(14);
				Console.WriteLine("decompressing : " + Convert.ToBase64String(enumerable.ToArray<byte>()));
				packetBytes = Helpers.DecompressStream(enumerable.ToArray<byte>(), num).ToList<byte>();
				bool flag2 = (ulong)num != (ulong)((long)packetBytes.Count<byte>());
				if (flag2)
				{
					Console.WriteLine("fail decompress");
					this.partialPackets = packetBytes.ToList<byte>();
					this.fullPacketSize = num;
				}
				else
				{
					bool flag3 = this.partialPackets.Count<byte>() != 0;
					if (flag3)
					{
						this.partialPackets.AddRange(packetBytes);
						bool flag4 = (long)this.partialPackets.Count<byte>() != (long)((ulong)this.fullPacketSize);
						if (flag4)
						{
							Console.WriteLine("not finished : " + this.partialPackets.Count<byte>().ToString() + " : " + this.fullPacketSize.ToString());
							return;
						}
					}
					this.HandlePacket(packetBytes);
				}
			}
			else
			{
				bool flag5 = serverOpcodes == ServerOpcodes.MultiplePackets;
				if (flag5)
				{
					packetBytes = packetBytes.Skip(2).ToArray<byte>();
					while (packetBytes.Count<byte>() > 0)
					{
						ushort num4 = BitConverter.ToUInt16(packetBytes.ToArray<byte>());
						this.HandlePacket(packetBytes.Skip(2).Take((int)(2 + num4)));
						packetBytes = packetBytes.Skip((int)(4 + num4));
					}
				}
				else
				{
					string text = serverOpcodes.ToString();
					uint num5;
					bool flag6 = uint.TryParse(text, out num5);
					if (flag6)
					{
						text = serverOpcodes.ToString("X");
					}
					string[] array = new string[10];
					array[0] = "s2c : ";
					int num6 = 1;
					IPAddress serverHost = this.ServerHost;
					array[num6] = ((serverHost != null) ? serverHost.ToString() : null);
					array[2] = " : ";
					array[3] = text;
					array[4] = " : ";
					array[5] = packetBytes.Count<byte>().ToString();
					array[6] = " : ";
					array[7] = DateTime.Now.ToString();
					array[8] = " : ";
					array[9] = BitConverter.ToString(packetBytes.ToArray<byte>());
					Console.WriteLine(string.Concat(array));
					packetBytes = packetBytes.Skip(2).ToArray<byte>();
					bool flag7 = packetBytes == null;
					if (flag7)
					{
						Packet packet = (Packet)Activator.CreateInstance(Type.GetType(serverOpcodes.ToString()));
						try
						{
							packet.Bytes = packetBytes;
						}
						catch
						{
							Console.WriteLine(" parse fail 1 :( " + BitConverter.ToString(packetBytes.ToArray<byte>()));
						}
						bool flag8 = this.waitingForPacket != null && this.waitingForPacket(packet);
						if (flag8)
						{
							this.waitingForPacket = null;
						}
						MethodInfo methodInfo = base.GetType().GetMethod(text, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
						bool flag9 = methodInfo == null;
						if (flag9)
						{
							methodInfo = base.GetType().BaseType.GetMethod(text, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
						}
						bool flag10 = methodInfo != null;
						if (flag10)
						{
							methodInfo.Invoke(this, new object[] { packet });
						}
					}
					bool flag11 = text == "UpdateBnetSessionKey";
					if (flag11)
					{
					}
					bool flag12 = text == "AuthResponse";
					if (flag12)
					{
					}
					bool flag13 = text == "SuspendComms";
					if (flag13)
					{
						this.SendPacket(new byte[] { 100, 55, 20, 0, 0, 0, 19, 241, 185, 77 });
						this.SendPacket(new byte[] { 105, 55, 11, 0, 0, 0 });
					}
					bool flag14 = text == "ResumeComms";
					if (flag14)
					{
						this.SendPacket(new EnumCharacters());
					}
					bool flag15 = text == "EnumCharactersResult";
					if (flag15)
					{
						EnumCharactersResult enumCharactersResult = new EnumCharactersResult
						{
							Bytes = packetBytes.ToArray<byte>()
						};
						bool flag16 = this.ConnectType == ConnectTo.ConnectToSerial.None;
						if (flag16)
						{
							this.SendPacket(new PlayerLogin
							{
								Guid = enumCharactersResult.Characters[0].Guid,
								FarClip = 1806f
							});
						}
					}
					bool flag17 = text == "ConnectTo";
					if (flag17)
					{
						ConnectTo connectTo = new ConnectTo
						{
							Bytes = packetBytes.ToArray<byte>()
						};
						Task.Run(delegate
						{
							bool flag18 = new RealmClient
							{
								JoinTicket = this.JoinTicket,
								ClientSecret = this.ClientSecret,
								JoinSecret = this.JoinSecret,
								ConnectType = connectTo.Serial
							}.ContinueConnect(connectTo.IPAddress, connectTo.Key.ToArray(), this.SessionKey.ToArray(), (int)connectTo.Port);
							bool flag19 = !flag18;
							if (flag19)
							{
								bool flag20 = new RealmClient
								{
									JoinTicket = this.JoinTicket,
									ClientSecret = this.ClientSecret,
									JoinSecret = this.JoinSecret,
									ConnectType = connectTo.Serial
								}.ContinueConnect(connectTo.IPAddress, connectTo.Key.ToArray(), this.SessionKey.ToArray(), (int)connectTo.Port);
							}
						});
					}
				}
			}
		}

		// Token: 0x0600BE2E RID: 48686 RVA: 0x004890F8 File Offset: 0x004872F8
		public void WaitForPacket(RealmClient.WaitingForPacketDelegate waitUntilReceivedPacket)
		{
			this.waitingForPacket = waitUntilReceivedPacket;
			while (this.waitingForPacket != null)
			{
				Thread.Sleep(50);
			}
		}

		// Token: 0x0600BE2F RID: 48687 RVA: 0x00489124 File Offset: 0x00487324
		public void SendPacket(Packet packet, ushort minSleep, ushort maxSleep)
		{
			this.SendPacket(packet);
		}

		// Token: 0x0600BE30 RID: 48688 RVA: 0x00489130 File Offset: 0x00487330
		public bool SendPacket(Packet packet, RealmClient.WaitingForPacketDelegate waitUntilReceivedPacket)
		{
			this.waitingForPacket = waitUntilReceivedPacket;
			this.SendPacket(packet);
			int num = 0;
			while (this.waitingForPacket != null)
			{
				Thread.Sleep(50);
				bool flag = num++ > 10;
				if (flag)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600BE31 RID: 48689 RVA: 0x00489180 File Offset: 0x00487380
		public void SendPacket(Packet packet)
		{
			ClientOpcodes clientOpcodes = Enum.Parse<ClientOpcodes>(packet.GetType().Name);
			IEnumerable<byte> enumerable = BitConverter.GetBytes((ushort)clientOpcodes).Concat(packet.ToArray());
			this.SendPacket(enumerable.ToArray<byte>());
		}

		// Token: 0x0600BE32 RID: 48690 RVA: 0x004891C0 File Offset: 0x004873C0
		public virtual void SendPacket(byte[] packetBytes)
		{
			try
			{
				string[] array = new string[6];
				array[0] = "c2s : ";
				int num = 1;
				IPAddress serverHost = this.ServerHost;
				array[num] = ((serverHost != null) ? serverHost.ToString() : null);
				array[2] = " : ";
				array[3] = DateTime.Now.ToString();
				array[4] = " : ";
				array[5] = BitConverter.ToString(packetBytes);
				Console.WriteLine(string.Concat(array));
			}
			catch
			{
			}
			bool flag = !this.TcpClient.Connected;
			if (!flag)
			{
				byte[] array2 = new byte[12];
				bool flag2 = this.Crypto != null;
				if (flag2)
				{
					byte[] array3 = new byte[packetBytes.Length];
					this.Crypto.Encrypt(BitConverter.GetBytes(this.clientPacketCount).Concat(this.CLNT).ToArray<byte>(), packetBytes, array3, array2, null);
					packetBytes = array3;
				}
				IEnumerable<byte> enumerable = BitConverter.GetBytes((uint)packetBytes.Length).Concat(array2).Concat(packetBytes);
				this.clientPacketCount += 1UL;
				this.Stream.Write(enumerable.ToArray<byte>(), 0, enumerable.Count<byte>());
			}
		}

		// Token: 0x0600BE33 RID: 48691 RVA: 0x004892E8 File Offset: 0x004874E8
		private void Undefined(List<byte> data)
		{
		}

		// Token: 0x0600BE34 RID: 48692 RVA: 0x004892EB File Offset: 0x004874EB
		public void Log(string msg)
		{
		}

		// Token: 0x0400917C RID: 37244
		public TcpClient TcpClient = new TcpClient();

		// Token: 0x0400917D RID: 37245
		public Stream Stream;

		// Token: 0x0400917E RID: 37246
		public Thread PacketHandlerThread;

		// Token: 0x04009180 RID: 37248
		public bool HandlePackets = true;

		// Token: 0x04009181 RID: 37249
		public AesGcm Crypto;

		// Token: 0x04009182 RID: 37250
		public byte[] ClientSecret;

		// Token: 0x04009183 RID: 37251
		public byte[] JoinSecret;

		// Token: 0x04009184 RID: 37252
		public byte[] JoinTicket;

		// Token: 0x04009185 RID: 37253
		private IPAddress ServerHost;

		// Token: 0x04009186 RID: 37254
		private byte[] LocalChallenge;

		// Token: 0x04009187 RID: 37255
		public ConnectTo.ConnectToSerial ConnectType = ConnectTo.ConnectToSerial.None;

		// Token: 0x04009188 RID: 37256
		private List<byte> SessionKey;

		// Token: 0x04009189 RID: 37257
		public ulong serverPacketCount = 0UL;

		// Token: 0x0400918A RID: 37258
		public byte[] SRVR = Encoding.UTF8.GetBytes("SRVR");

		// Token: 0x0400918B RID: 37259
		public List<byte> partialPackets = new List<byte>();

		// Token: 0x0400918C RID: 37260
		public uint fullPacketSize = 0U;

		// Token: 0x0400918D RID: 37261
		public RealmClient.WaitingForPacketDelegate waitingForPacket;

		// Token: 0x0400918E RID: 37262
		public ulong clientPacketCount = 0UL;

		// Token: 0x0400918F RID: 37263
		public byte[] CLNT = Encoding.UTF8.GetBytes("CLNT");

		// Token: 0x020013D8 RID: 5080
		public static class Puzzle
		{
			// Token: 0x0600E167 RID: 57703 RVA: 0x004C99E4 File Offset: 0x004C7BE4
			public static bool SolveDOSChallenge(byte[] key, int total_bits, byte[] output)
			{
				bool flag = total_bits > 160;
				bool flag2;
				if (flag)
				{
					flag2 = false;
				}
				else
				{
					ulong num = 1UL;
					byte[] array;
					for (;;)
					{
						SHA1 sha = SHA1.Create();
						sha.Initialize();
						sha.TransformBlock(key, 0, key.Length, key, 0);
						array = BitConverter.GetBytes(num);
						sha.TransformFinalBlock(array, 0, array.Length);
						byte[] hash = sha.Hash;
						int num2 = 0;
						uint num3 = 0U;
						for (int i = 0; i < hash.Length; i++)
						{
							bool flag3 = hash[i] > 0;
							if (flag3)
							{
								break;
							}
							num3 += 8U;
							num2++;
						}
						bool flag4 = num2 < sha.HashSize;
						if (flag4)
						{
							byte b = hash[num2];
							while ((b & 1) == 0)
							{
								b = (byte)(b >> 1);
								num3 += 1U;
							}
						}
						bool flag5 = (ulong)num3 >= (ulong)((long)total_bits);
						if (flag5)
						{
							break;
						}
						ulong num4 = num;
						num = num4 + 1UL;
						bool flag6 = num4 == ulong.MaxValue;
						if (flag6)
						{
							goto Block_5;
						}
					}
					array = BitConverter.GetBytes(num);
					Buffer.BlockCopy(array, 0, output, 0, array.Length);
					return true;
					Block_5:
					flag2 = false;
				}
				return flag2;
			}

			// Token: 0x0600E168 RID: 57704 RVA: 0x004C9B00 File Offset: 0x004C7D00
			public static byte[] GeneratePuzzle(byte[] Key, int bits)
			{
				byte[] array = new byte[8];
				Random random = new Random();
				do
				{
					random.NextBytes(Key);
				}
				while (!RealmClient.Puzzle.SolveDOSChallenge(Key, bits, array));
				return array;
			}
		}

		// Token: 0x020013D9 RID: 5081
		// (Invoke) Token: 0x0600E16A RID: 57706
		public delegate bool WaitingForPacketDelegate(Packet data);
	}
}
