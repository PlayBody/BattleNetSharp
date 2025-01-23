using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BattleNetSharp.D4.Packets;
using D4Packets;
using D4Packets.Game.Client;
using Fenris.ClientMessage;
using Fenris.Hero;
using Fenris.Online;
using Fenris.Router;
using Google.Protobuf;

namespace BattleNetSharp.D4
{
	// Token: 0x02000B12 RID: 2834
	public class Client
	{
		// Token: 0x0600BE3C RID: 48700 RVA: 0x004893CC File Offset: 0x004875CC
		public void Init(D2RBGS bgs, ulong gameAccount, string ipString, int port, ulong token, ulong cryptoToken, byte[] modulus, byte[] exponent)
		{
			this.Bgs = bgs;
			this.LoginToken = token;
			this.GameAccountId = (uint)gameAccount;
			this.Tcp = new TcpClient();
			this.Tcp.Connect(IPAddress.Parse(ipString.Split(':', StringSplitOptions.None)[0]), port);
			this.BaseStream = this.Tcp.GetStream();
			byte[] bytes = RandomNumberGenerator.GetBytes(48);
			byte[] bytes2 = RandomNumberGenerator.GetBytes(32);
			IEnumerable<byte> enumerable = Encoding.UTF8.GetBytes("HELLO FEN CLIENT\0").Concat(BitConverter.GetBytes(cryptoToken).Reverse<byte>()).Concat(bytes2);
			IEnumerable<byte> enumerable2 = Crypto.Encrypt(bytes, modulus, exponent).Reverse<byte>();
			enumerable = enumerable.Concat(enumerable2);
			Console.WriteLine("clientless start: " + ipString);
			this.SendPacket(enumerable.ToArray<byte>());
			List<byte> list = this.ReadPacket();
			byte[] array = list.Skip(17).Take(32).ToArray<byte>();
			IEnumerable<byte> enumerable3 = list.Skip(17).Skip(32).Take(32);
			byte b2 = list.Skip(17).Skip(32).Skip(32)
				.Take(1)
				.First<byte>();
			IEnumerable<byte> enumerable4 = list.Skip(17).Skip(32).Skip(32)
				.Skip(1)
				.Take(12);
			IEnumerable<byte> enumerable5 = list.Take(list.Count - 12).Concat(from b in Enumerable.Range(0, 12)
				select (byte)0);
			byte[] array2;
			ClientHello.ServerHello(enumerable.ToArray<byte>(), enumerable5.ToArray<byte>(), bytes, bytes2, array, out array2);
			byte[] array3;
			ClientHello.SolveDOSChallenge(enumerable3.ToArray<byte>(), (int)b2, out array3);
			ClientHello.GenerateKeys(bytes2, array, bytes, out this.ClientKey, out this.ServerKey);
			byte[] array4 = array3.Concat(array2).ToArray<byte>();
			this.SendPacket(array4);
		}

		// Token: 0x0600BE3D RID: 48701 RVA: 0x004895B8 File Offset: 0x004877B8
		public void Connect(Client.ClientType type)
		{
			bool flag = type == Client.ClientType.Ping;
			if (flag)
			{
				this.SendPacket(new PingConnect
				{
					unk1 = 17425,
					unk2 = 3529857027U,
					Value = 32U
				});
			}
			else
			{
				bool flag2 = type == Client.ClientType.Lobby;
				if (flag2)
				{
					this.SendPacket(new ProxyConnect
					{
						ConnectMessage = new Connect
						{
							GameAccountId = this.GameAccountId,
							Token = this.LoginToken,
							Trace = new Trace()
						}
					});
				}
				else
				{
					bool flag3 = type == Client.ClientType.Game;
					if (flag3)
					{
						this.SendPacket(new JoinExistingGame
						{
							GameID = (int)this.Bgs.GameId,
							ProtocolHash = 1298334262U,
							XLocale = 0,
							GCI = new JoinExistingGame.GameConnectionInfo[]
							{
								new JoinExistingGame.GameConnectionInfo
								{
									GameAccountId = this.GameAccountId,
									AuthToken = this.Bgs.TimeToken,
									field1 = false,
									SessionKey = this.Bgs.SessionKey
								}
							}
						});
					}
				}
			}
			Task.Run(delegate
			{
				this.Listen();
			});
		}

		// Token: 0x0600BE3E RID: 48702 RVA: 0x004896DC File Offset: 0x004878DC
		public void Listen()
		{
			while (this.Tcp.Connected && (!this.Tcp.Client.Poll(1, SelectMode.SelectRead) || this.Tcp.Client.Available != 0))
			{
				try
				{
					this.HandlePacket();
				}
				catch (Exception ex)
				{
					Console.WriteLine("error in gameserver : " + ex.Message);
					Console.WriteLine(ex.StackTrace);
				}
			}
			Console.WriteLine("connection end : ");
		}

		// Token: 0x0600BE3F RID: 48703 RVA: 0x0048977C File Offset: 0x0048797C
		public void HandlePacket()
		{
			List<byte> list = this.ReadPacket();
			while (list.Count > 0)
			{
				int num;
				D4Packet packet = D4Packet.GetPacket(list.ToArray(), this.ServerKey, out num);
				bool flag = num == 1;
				if (flag)
				{
					break;
				}
				bool flag2 = packet != null;
				if (flag2)
				{
					MethodInfo method = base.GetType().GetMethod(packet.GetType().Name, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
					bool flag3 = method != null;
					if (flag3)
					{
						method.Invoke(this, new object[] { packet });
					}
				}
				list = list.Skip(num).ToList<byte>();
			}
		}

		// Token: 0x0600BE40 RID: 48704 RVA: 0x0048981C File Offset: 0x00487A1C
		private void ProxyConnected(ProxyConnected connected)
		{
			Console.WriteLine(connected);
			this.sessionKey = connected.ConnectedMessage.SessionId;
			AuthenticationListener authenticationListener = (AuthenticationListener)this.Bgs.BgsConnection.Listeners.Values.First((IServiceListener a) => a is AuthenticationListener);
			GetInitialDataRequest getInitialDataRequest = new GetInitialDataRequest
			{
				SessionKey = ByteString.CopyFromUtf8(connected.ConnectedMessage.SessionId),
				Battletag = authenticationListener.LogonResult.BattleTag,
				GameServerPool = "us-west",
				MultiplayerAllowed = true
			};
			this.SendPacket(new ProxyLogin
			{
				DataRequest = getInitialDataRequest
			});
		}

		// Token: 0x0600BE41 RID: 48705 RVA: 0x004898D7 File Offset: 0x00487AD7
		private void AccountProfile(AccountProfile profile)
		{
		}

		// Token: 0x0600BE42 RID: 48706 RVA: 0x004898DC File Offset: 0x00487ADC
		private void HeroDigests(HeroDigests heroes)
		{
			AuthenticationListener authenticationListener = (AuthenticationListener)this.Bgs.BgsConnection.Listeners.Values.First((IServiceListener a) => a is AuthenticationListener);
			this.SendPacket(new GetHeroProfile
			{
				Account = new GetHeroProfileRequest
				{
					HeroId = heroes.Heroes.HeroDigests[0].HeroId.ToStringUtf8(),
					TargetGameAccountId = (uint)authenticationListener.LogonResult.GameAccountId[0].Low
				}
			});
		}

		// Token: 0x0600BE43 RID: 48707 RVA: 0x00489980 File Offset: 0x00487B80
		private void HeroProfiles(HeroProfiles hp)
		{
		}

		// Token: 0x0600BE44 RID: 48708 RVA: 0x00489983 File Offset: 0x00487B83
		private void HeroProfile(HeroProfile hp)
		{
		}

		// Token: 0x0600BE45 RID: 48709 RVA: 0x00489988 File Offset: 0x00487B88
		private void LoginData(LoginData login)
		{
			AuthenticationListener authenticationListener = (AuthenticationListener)this.Bgs.BgsConnection.Listeners.Values.First((IServiceListener a) => a is AuthenticationListener);
			bool flag = login.DataRequest.Heroes.Count == 0;
			if (flag)
			{
				this.SendPacket(new CreateHero
				{
					Token = login.Token,
					Hero = new CreateHeroRequest
					{
						HeroName = "testchar",
						SnoClass = 131965,
						ApplyCampaignSkip = true,
						IsFemale = false,
						IsHardcore = false,
						AllowAllCosmetics = false,
						AppearanceCustomization = new AppearanceCustomization
						{
							SkinColorIndex = 0,
							SnoJewelry = -1,
							SnoMarkingShape = -1
						},
						ClientLocale = 2,
						IsSeasonal = false
					}
				});
			}
			else
			{
				this.SendPacket(new SelectHero
				{
					Hero = new SelectHeroRequest
					{
						HeroId = login.DataRequest.Heroes[0].HeroId.ToStringUtf8(),
						WorldTier = 0
					}
				});
			}
		}

		// Token: 0x0600BE46 RID: 48710 RVA: 0x00489AC7 File Offset: 0x00487CC7
		private void HeroCreated(HeroCreated hero)
		{
			this.SendPacket(new SelectHero
			{
				Hero = new SelectHeroRequest
				{
					HeroId = hero.Hero.Hero.HeroId.ToStringUtf8(),
					WorldTier = 0
				}
			});
		}

		// Token: 0x0600BE47 RID: 48711 RVA: 0x00489B08 File Offset: 0x00487D08
		private void HeroSelected(HeroSelected hero)
		{
			this.SendPacket(new FindGameForParty
			{
				Token = hero.Token,
				Find = new PartyFindGameRequest
				{
					IsHardcoreHero = false,
					IsSeasonalHero = false,
					SessionKey = ByteString.CopyFromUtf8(this.sessionKey),
					SnoWorld = -1,
					SnoSubzone = 445427
				}
			});
		}

		// Token: 0x0600BE48 RID: 48712 RVA: 0x00489B70 File Offset: 0x00487D70
		private void FoundGameForParty(FoundGameForParty game)
		{
			this.Bgs.GameId = game.Game.ConnectionInfo.GameId;
			Client client = new Client();
			client.Init(this.Bgs, (ulong)game.Game.ConnectionInfo.Player[0].GameAccountId, game.Game.ConnectionInfo.Address, (int)game.Game.ConnectionInfo.Port, game.Game.ConnectionInfo.Player[0].AuthToken, game.Game.ConnectionInfo.Player[0].EncryptionInfo.Token, game.Game.ConnectionInfo.Player[0].EncryptionInfo.PresharedKey.Modulus.ToByteArray().Reverse<byte>().ToArray<byte>(), game.Game.ConnectionInfo.Player[0].EncryptionInfo.PresharedKey.Exponent.ToByteArray().Reverse<byte>().ToArray<byte>());
			client.Connect(Client.ClientType.Game);
		}

		// Token: 0x0600BE49 RID: 48713 RVA: 0x00489C93 File Offset: 0x00487E93
		private void GameSetup(GameSetup setup)
		{
			this.SendPacket(new FinishedGameSetup());
		}

		// Token: 0x0600BE4A RID: 48714 RVA: 0x00489CA2 File Offset: 0x00487EA2
		private void LimboWarpPrefetchBegin(LimboWarpPrefetchBegin LimboWarpPrefetchBegin)
		{
			Task.Run(delegate
			{
				Thread.Sleep(5000);
				this.SendPacket(new LimboWarpPrefetchComplete());
			});
		}

		// Token: 0x0600BE4B RID: 48715 RVA: 0x00489CB8 File Offset: 0x00487EB8
		public List<byte> ReadPacket()
		{
			List<byte> list = new List<byte>();
			while (this.Tcp.Connected && !this.BaseStream.DataAvailable)
			{
				Thread.Sleep(20);
			}
			bool flag = this.Tcp.Connected && this.BaseStream.DataAvailable;
			if (flag)
			{
				byte[] array = new byte[1024];
				do
				{
					int num = this.BaseStream.Read(array, 0, array.Length);
					list.AddRange(array.Take(num));
				}
				while (this.BaseStream.DataAvailable);
			}
			else
			{
				Thread.Sleep(50);
			}
			return list;
		}

		// Token: 0x0600BE4C RID: 48716 RVA: 0x00489D6C File Offset: 0x00487F6C
		public void SendPacket(D4Packet packet)
		{
			bool flag = this.logging;
			if (flag)
			{
				Opcodes opcode = (packet.GetType().GetCustomAttributes(false).First<object>() as D4Packet.OpcodeAttribute).Opcode;
			}
			byte[] array = packet.ToEncryptedArray(this.ClientKey);
			this.SendPacket(array);
		}

		// Token: 0x0600BE4D RID: 48717 RVA: 0x00489DB8 File Offset: 0x00487FB8
		public void SendPacket(byte[] packetBytes)
		{
			bool flag = this.logging;
			if (flag)
			{
			}
			bool flag2 = !this.Tcp.Connected;
			if (!flag2)
			{
				object net = this.Net;
				lock (net)
				{
					this.BaseStream.Write(packetBytes, 0, packetBytes.Length);
				}
			}
		}

		// Token: 0x04009191 RID: 37265
		public TcpClient Tcp;

		// Token: 0x04009192 RID: 37266
		public NetworkStream BaseStream;

		// Token: 0x04009193 RID: 37267
		public uint Hash;

		// Token: 0x04009194 RID: 37268
		public ushort Token;

		// Token: 0x04009195 RID: 37269
		public bool Compression = false;

		// Token: 0x04009196 RID: 37270
		public bool Resurrected = false;

		// Token: 0x04009197 RID: 37271
		public Thread PacketHandlerThread;

		// Token: 0x04009198 RID: 37272
		public uint playerId = 0U;

		// Token: 0x04009199 RID: 37273
		public bool logging = true;

		// Token: 0x0400919A RID: 37274
		public IPEndPoint Endpoint;

		// Token: 0x0400919B RID: 37275
		public Crypto ClientKey;

		// Token: 0x0400919C RID: 37276
		public Crypto ServerKey;

		// Token: 0x0400919D RID: 37277
		public uint GameAccountId = 0U;

		// Token: 0x0400919E RID: 37278
		public D2RBGS Bgs;

		// Token: 0x0400919F RID: 37279
		public ulong LoginToken;

		// Token: 0x040091A0 RID: 37280
		private string sessionKey;

		// Token: 0x040091A1 RID: 37281
		public object Net = new object();

		// Token: 0x020013DB RID: 5083
		public enum ClientType
		{
			// Token: 0x0400A084 RID: 41092
			Ping,
			// Token: 0x0400A085 RID: 41093
			Lobby,
			// Token: 0x0400A086 RID: 41094
			Game
		}
	}
}
