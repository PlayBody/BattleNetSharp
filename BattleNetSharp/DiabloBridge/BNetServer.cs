using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BattleNetSharp;
using D2Packets;
using D2Packets.BattleNet;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;

namespace DiabloBridge
{
	// Token: 0x0200098D RID: 2445
	public class BNetServer : IDisposable
	{
		// Token: 0x0600B9BF RID: 47551 RVA: 0x0046043C File Offset: 0x0045E63C
		public BNetServer()
		{
		}

		// Token: 0x0600B9C0 RID: 47552 RVA: 0x00460470 File Offset: 0x0045E670
		public BNetServer(TcpClient client)
		{
			this.Client = client;
			this.Endpoint = this.Client.Client.RemoteEndPoint as IPEndPoint;
			bool flag = this.Endpoint.Address.Equals(IPAddress.Loopback);
			if (flag)
			{
				this.ip = BitConverter.ToUInt32(IPAddress.Loopback.GetAddressBytes());
			}
			else
			{
				bool flag2 = Environment.MachineName == "DESKTOP-54INSRD";
				if (flag2)
				{
					this.ip = BitConverter.ToUInt32(Dns.GetHostEntry(Dns.GetHostName()).AddressList.First((IPAddress a) => a.AddressFamily == AddressFamily.InterNetwork).GetAddressBytes());
				}
				else
				{
					this.ip = BitConverter.ToUInt32(IPAddress.Parse("137.66.34.9").GetAddressBytes());
				}
			}
			Task.Run(delegate
			{
				this.Listen();
			});
		}

		// Token: 0x0600B9C1 RID: 47553 RVA: 0x00460594 File Offset: 0x0045E794
		public void Listen()
		{
			this.Stream = this.Client.GetStream();
			this.Stream.ReadTimeout = -1;
			int num = this.Stream.ReadByte();
			while (this.Client.Connected)
			{
				try
				{
					this.HandlePacket();
				}
				catch (Exception ex)
				{
					Console.WriteLine("bnet server list crash : " + ex.Message + " : " + ex.StackTrace);
					this.Client.Close();
					break;
				}
				bool flag = this.BgsClient != null && this.BgsClient.BgsConnection != null && this.BgsClient.BgsConnection.clientWebSocket.State != WebSocketState.Open;
				if (flag)
				{
					this.Client.Close();
					break;
				}
			}
			this.Dispose();
		}

		// Token: 0x0600B9C2 RID: 47554 RVA: 0x00460680 File Offset: 0x0045E880
		public List<byte> ReadPacket()
		{
			List<byte> list = new List<byte>();
			byte[] array = new byte[this.Client.ReceiveBufferSize];
			try
			{
				int num = this.Stream.Read(array, 0, array.Length);
				list.AddRange(array.Take(num));
				bool flag = num == 0;
				if (flag)
				{
					this.Client.Close();
				}
			}
			catch (IOException ex)
			{
				string text = "server closing : " + ex.Message;
				this.Dispose();
				return list;
			}
			catch
			{
				Console.WriteLine("bnet server read packet crash");
			}
			return list;
		}

        // Token: 0x0600B9C3 RID: 47555 RVA: 0x00460734 File Offset: 0x0045E934
        public void HandlePacket()
        {
            List<byte> packetData = this.ReadPacket();
            Type packetType = typeof(BattleNetPacket);

            while (packetData.Count > 0)
            {
                int packetLength = 0;

                if (packetData[0] == 50 || packetData[0] == 47)
                {
                    FtpFileRequest ftpRequest = new FtpFileRequest { Bytes = packetData };
                    string requestString = Encoding.UTF8.GetString(packetData.ToArray());
                    string fileName = "bnserver-D2DV.ini";

                    if (requestString.Contains("CheckRevision.mpq")) fileName = "CheckRevision.mpq";
                    else if (requestString.Contains("ver-IX86-1.mpq")) fileName = "ver-IX86-1.mpq";
                    else if (requestString.Contains("ver-IX86-2.mpq")) fileName = "ver-IX86-2.mpq";

                    FtpFileResponse ftpResponse = new FtpFileResponse(fileName);
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        Assembly.GetExecutingAssembly()
                            .GetManifestResourceStream($"BattleNetSharp.D2.Classic.ProxyToResurrected.{fileName}")
                            .CopyTo(memoryStream);
                        ftpResponse.FileBytes = memoryStream.ToArray().ToList();
                    }

                    if (requestString.Contains("ver-IX86-"))
                        ftpResponse.head -= 3U;

                    ftpResponse.filesize = (uint)ftpResponse.FileBytes.Count;
                    ftpResponse.FileTime = ftpRequest.FileTime;
                    byte[] responseBytes = ftpResponse.ToArray();
                    this.Stream.Write(responseBytes, 0, responseBytes.Length);
                    break;
                }

                string typeName = packetType.AssemblyQualifiedName.Replace(packetType.Name, ((BattleNetPacket)packetData[1]).ToString() + "C2S");
                Type type = Type.GetType(typeName);

                if (type == null)
                {
                    Console.WriteLine($"No packet info for: {packetData[1]:X} : {BitConverter.ToString(packetData.ToArray())}");
                    break;
                }

                if (this.logging)
                {
                    string logMessage = $"{((this.Client.Client.RemoteEndPoint as IPEndPoint)?.Address)} BC ({DateTime.UtcNow:HH:mm:ss.fff}): {type.Name} : {BitConverter.ToString(packetData.ToArray())}";
                    Console.WriteLine(logMessage);
                }

                object packetInstance = Activator.CreateInstance(type);
                try
                {
                    type.GetProperty("Bytes")?.SetValue(packetInstance, packetData);
                }
                catch
                {
                    Console.WriteLine("Failed to parse packet.");
                    break;
                }

                if (packetLength == 0)
                {
                    FieldInfo lengthField = type.GetField("Length");
                    if (lengthField != null)
                    {
                        try
                        {
                            packetLength = (int)(lengthField.GetValue(packetInstance) ?? 0);
                        }
                        catch
                        {
                            Console.WriteLine($"Failed to retrieve length for: {type.Name}");
                        }
                    }
                    else
                    {
                        try
                        {
                            packetLength = (int)(type.GetMethod("ToArray")?.Invoke(packetInstance, null) as byte[])?.Length;
                        }
                        catch
                        {
                            Console.WriteLine($"Failed to retrieve byte array for: {type.Name}");
                        }
                    }
                }

                MethodInfo handlerMethod = GetType().GetMethod(type.Name, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
                if (handlerMethod != null)
                {
                    handlerMethod.Invoke(this, new[] { packetInstance });
                }
                else
                {
                    Console.WriteLine($"No handler for: {type.Name}");
                }

                packetData = packetData.Skip(packetLength).ToList();
            }
        }

        // Token: 0x0600B9C4 RID: 47556 RVA: 0x00460CFC File Offset: 0x0045EEFC
        private void AuthInfoC2S(AuthInfoC2S info)
		{
			this.SendPacket(new AuthInfoS2C
			{
				MpqFileName = "ver-IX86-1.mpq",
				MpqFileTime = 131186808080000000UL,
				LogonType = AuthInfoS2C.LogonTypes.BrokenSha1,
				ServerToken = (uint)new Random().Next(),
				UdpValue = 816U,
				FormulaString = "A=3845581634 B=880823580 C=1363937103 4 A=A-S B=B-C C=C-A A=A-B"
			});
		}

		// Token: 0x0600B9C5 RID: 47557 RVA: 0x00460D5D File Offset: 0x0045EF5D
		private void KeepAliveC2S(KeepAliveC2S info)
		{
			this.SendPacket(new KeepAliveS2C());
		}

		// Token: 0x0600B9C6 RID: 47558 RVA: 0x00460D6C File Offset: 0x0045EF6C
		private void AuthCheckC2S(AuthCheckC2S info)
		{
			this.SendPacket(new AuthCheckS2C
			{
				Result = AuthCheckS2C.CdKeyCheck.PassedChallenge
			});
		}

		// Token: 0x0600B9C7 RID: 47559 RVA: 0x00460D84 File Offset: 0x0045EF84
		private void LogonC2S(LogonC2S info)
		{
			string loggedIn = "";
			this.BgsClient = new D2RBGS();
			bool flag = !File.Exists("accounts/" + info.Account);
			if (flag)
			{
				Console.WriteLine("no acc : " + info.Account);
				this.SendPacket(new LogonS2C
				{
					Status = LogonS2C.LogonStatus.NoAccount
				});
			}
			else
			{
				string text = File.ReadAllText("accounts/" + info.Account);
				this.Account = JsonConvert.DeserializeObject<AccountLink>(text);
				BNetServer.BNetServers.TryAdd(this.Account.BNetEmail, this);
				string region = WebManager.Region;
				object obj = BNetServer.ddosPrev;
				lock (obj)
				{
					Task.Run(delegate
					{
						try
						{
							bool flag5 = this.BgsClient.BGSLoginLocked(region, this.Account.BNetToken, this.Account.BNetEmail, D2RBGS.App.D2R);
							bool flag6 = !flag5;
							if (flag6)
							{
								throw new Exception("login fail");
							}
							loggedIn = "success";
							Console.WriteLine(this.Account.BNetEmail + " : bnet success");
						}
						catch
						{
							Console.WriteLine(this.Account.BNetEmail + " : login fail");
							loggedIn = "fail";
						}
					});
				}
				while (loggedIn == "")
				{
					Thread.Sleep(500);
				}
				bool flag3 = loggedIn == "success";
				if (flag3)
				{
					this.SendPacket(new LogonS2C
					{
						Status = LogonS2C.LogonStatus.Success
					});
				}
				else
				{
					bool flag4 = loggedIn == "exists";
					if (flag4)
					{
						this.SendPacket(new LogonS2C
						{
							Status = LogonS2C.LogonStatus.NoAccount
						});
					}
					else
					{
						this.SendPacket(new LogonS2C
						{
							Status = LogonS2C.LogonStatus.NoAccount
						});
					}
				}
			}
		}

		// Token: 0x0600B9C8 RID: 47560 RVA: 0x00460F20 File Offset: 0x0045F120
		private void QueryRealmsC2S(QueryRealmsC2S info)
		{
			this.SendPacket(new QueryRealmsS2C
			{
				Realms = new List<QueryRealmsS2C.Realm>
				{
					new QueryRealmsS2C.Realm
					{
						Title = "resurrected",
						Description = "resurrected realm",
						One = 1U
					}
				},
				NumRealms = 1U,
				Zero = 0U
			});
		}

		// Token: 0x0600B9C9 RID: 47561 RVA: 0x00460F7C File Offset: 0x0045F17C
		private void RealmLogonC2S(RealmLogonC2S info)
		{
			uint num = 6113U;
			num = (uint)((ushort)((num >> 8) | ((num & 255U) << 8)));
			List<byte> list = Encoding.UTF8.GetBytes(this.Account.D2Account).ToList<byte>();
			for (int i = list.Count; i < 16; i++)
			{
				list.Add(0);
			}
			this.SendPacket(new RealmLogonS2C
			{
				RealmIpAddr = this.ip,
				RealmPort = num,
				HashString = list,
				HashString2 = Encoding.UTF8.GetBytes("b9f9712b6a9d4b82e018ccbab0e9d78d5a395525").ToList<byte>()
			});
		}

		// Token: 0x0600B9CA RID: 47562 RVA: 0x00461019 File Offset: 0x0045F219
		private void EnterChatC2S(EnterChatC2S info)
		{
			this.SendPacket(new EnterChatS2C
			{
				ChatName = "hello",
				RealmCharName = "resurrected,shalzuth",
				Product = 0
			});
		}

		// Token: 0x0600B9CB RID: 47563 RVA: 0x00461045 File Offset: 0x0045F245
		private void AdInfoC2S(AdInfoC2S info)
		{
			this.SendPacket(new AdInfoS2C
			{
				AdId = 1U
			});
		}

		// Token: 0x0600B9CC RID: 47564 RVA: 0x0046105B File Offset: 0x0045F25B
		private void ChannelListC2S(ChannelListC2S info)
		{
			this.SendPacket(new ChannelListS2C
			{
				Channels = new List<string> { "resurrected" }
			});
		}

		// Token: 0x0600B9CD RID: 47565 RVA: 0x00461081 File Offset: 0x0045F281
		private void NotifyJoinC2S(NotifyJoinC2S info)
		{
		}

		// Token: 0x0600B9CE RID: 47566 RVA: 0x00461084 File Offset: 0x0045F284
		private void StartGameC2S(StartGameC2S s)
		{
		}

		// Token: 0x0600B9CF RID: 47567 RVA: 0x00461087 File Offset: 0x0045F287
		private void LeaveChatC2S(LeaveChatC2S s)
		{
		}

		// Token: 0x0600B9D0 RID: 47568 RVA: 0x0046108A File Offset: 0x0045F28A
		private void LeaveGameC2S(LeaveGameC2S s)
		{
		}

		// Token: 0x0600B9D1 RID: 47569 RVA: 0x00461090 File Offset: 0x0045F290
		public void SendPacket(Packet packet)
		{
			byte[] array = packet.ToArray();
			this.SendPacket(array);
		}

		// Token: 0x0600B9D2 RID: 47570 RVA: 0x004610B0 File Offset: 0x0045F2B0
		private void NewsInfoC2S(NewsInfoC2S info)
		{
			string text = "ff4638010196e85b61ce7ad75dce3f115fce3f115f3d2d3d2d3d2d3d2d3d2d20424e4e4f554e43454d454e5453202d3d2d3d2d3d2d3d2d3d2d0a4c41444445522052455345543a203234204a756c792c2037504d20455354200a4e4557204d482052454c454153453a20312e392e392c20676574206974206e6f77210a67733120202d20204e657720596f726b0a67733220202d2020416d7374657264616d0a67733320202d20205379646e65790a67733420202d202053696c69636f6e2056616c6c65790a67733520202d202044616c6c61730a67733620202d20204368696361676f0a67733720202d202053656174746c650a67733820202d20204d69616d690a557365207468652067616d65206465736372697074696f6e20746f2075736520746865206d756c746967732073797374656d2e2000ff4608010196e85b61ce7ad75d4ed2865e4ed2865e3d2d3d2d3d2d3d2d3d2d3d2d204c4144444552205245534554202d3d2d3d2d3d2d3d2d3d2d3d0a536c617368446961626c6f20697320686176696e67206f7572206c616464657220726573657421204a6f696e2075732061742037504d204553542e0a52656d656d62657220746f2075736520746865206d756c7469706c652067616d657365727665727320287573652067616d65206465736372697074696f6e290a6773313a20555320456173740a6773323a2045550a6773333a2041552f4e5a0a6773343a20555320576573740a6773353a20555320536f7574680a476f6f64206c75636b20616e6420656e6a6f792100ff465c010196e85b61ce7ad75dcf7ad75d000000007c63303046463030303057656c636f6d65207c633030464639393333746f207c633030303043434646746865207c633030464636364646536c617368446961626c6f207c63303030304343303056657273696f6e207c633030393939394646507650474e20312e39392e372e322e312d50524f207c6330304646464646460a0a5468657265206172652063757272656e746c79203238207573657228732920696e20372067616d6573206f6620446961626c6f204949204c6f7264206f66204465737472756374696f6e2c20616e64203335207573657228732920706c6179696e6720372067616d657320616e64206368617474696e6720696e203435206368616e6e656c732e0a0a0a0a0a0a0a0a54686973207465787420696e76697369626c652c2062656361757365206f66206c696d69746174696f6e206f66203131206c696e65730a00";
			NewsInfoS2C newsInfoS2C = new NewsInfoS2C();
			NewsInfoS2C newsInfoS2C2 = new NewsInfoS2C
			{
				Bytes = Convert.FromHexString(text)
			};
			newsInfoS2C.NumEntries = 1;
			newsInfoS2C.NewsItems.Add(new NewsInfoS2C.News
			{
				Info = "hello"
			});
			newsInfoS2C2.NewsItems[0].TimeStamp = 1676511749U;
			newsInfoS2C2.NewsItems[0].Info = "Welcome to Diablo 2 Resurrected!";
			this.SendPacket(newsInfoS2C2);
		}

		// Token: 0x0600B9D3 RID: 47571 RVA: 0x00461134 File Offset: 0x0045F334
		private void FileTimeInfoC2S(FileTimeInfoC2S info)
		{
			this.SendPacket(new FileTimeInfoS2C
			{
				Result = info.Request,
				FileName = info.FileName,
				LastUpdate = 132424061940000000UL
			});
		}

		// Token: 0x0600B9D4 RID: 47572 RVA: 0x0046116C File Offset: 0x0045F36C
		public void SendPacket(byte[] packetBytes)
		{
			bool flag = !this.Client.Connected;
			if (!flag)
			{
				bool flag2 = this.logging;
				if (flag2)
				{
					string[] array = new string[8];
					array[0] = "(";
					int num = 1;
					IPAddress address = (this.Client.Client.RemoteEndPoint as IPEndPoint).Address;
					array[num] = ((address != null) ? address.ToString() : null);
					array[2] = ") BS (";
					array[3] = DateTime.UtcNow.ToString("HH:mm:ss.fff");
					array[4] = "): ";
					int num2 = 5;
					BattleNetPacket battleNetPacket = (BattleNetPacket)packetBytes[1];
					array[num2] = battleNetPacket.ToString();
					array[6] = " : ";
					array[7] = BitConverter.ToString(packetBytes);
					Console.WriteLine(string.Concat(array));
				}
				try
				{
					this.Stream.Write(packetBytes, 0, packetBytes.Length);
				}
				catch
				{
					Console.WriteLine("bnet server send fail");
				}
			}
		}

		// Token: 0x0600B9D5 RID: 47573 RVA: 0x00461260 File Offset: 0x0045F460
		public void Dispose()
		{
			BNetServer bnetServer;
			BNetServer.BNetServers.TryRemove(this.Account.BNetEmail, out bnetServer);
			D2RBGS bgsClient = this.BgsClient;
			if (bgsClient != null)
			{
				bgsClient.Close();
			}
			NetworkStream stream = this.Stream;
			if (stream != null)
			{
				stream.Close();
			}
			TcpClient client = this.Client;
			if (client != null)
			{
				client.Close();
			}
		}

		// Token: 0x04008892 RID: 34962
		public TcpClient Client;

		// Token: 0x04008893 RID: 34963
		public NetworkStream Stream;

		// Token: 0x04008894 RID: 34964
		public uint Hash;

		// Token: 0x04008895 RID: 34965
		public ushort Token;

		// Token: 0x04008896 RID: 34966
		public bool Compression = false;

		// Token: 0x04008897 RID: 34967
		public bool Resurrected = false;

		// Token: 0x04008898 RID: 34968
		public Thread PacketHandlerThread;

		// Token: 0x04008899 RID: 34969
		public uint playerId = 0U;

		// Token: 0x0400889A RID: 34970
		public bool logging = false;

		// Token: 0x0400889B RID: 34971
		public IPEndPoint Endpoint;

		// Token: 0x0400889C RID: 34972
		public int LastPing;

		// Token: 0x0400889D RID: 34973
		private AccountLink Account = new AccountLink();

		// Token: 0x0400889E RID: 34974
		public static ConcurrentDictionary<string, BNetServer> BNetServers = new ConcurrentDictionary<string, BNetServer>();

		// Token: 0x0400889F RID: 34975
		public D2RBGS BgsClient;

		// Token: 0x040088A0 RID: 34976
		public uint ip;

		// Token: 0x040088A1 RID: 34977
		private static object ddosPrev = new object();
	}
}
