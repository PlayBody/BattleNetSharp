using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BattleNetSharp.D4.Packets;
using D4Packets;
using D4Packets.Game.Client;
using Fenris.Account;
using Fenris.Client;
using Fenris.ClientMessage;
using Fenris.Hero;
using Fenris.License;
using Fenris.Online;
using Fenris.Router;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Utilities;

namespace BattleNetSharp.D4
{
	// Token: 0x02000B13 RID: 2835
	public class Server
	{
		// Token: 0x0600BE51 RID: 48721 RVA: 0x00489E84 File Offset: 0x00488084
		public Server(TcpClient client)
		{
			this.logging = Environment.MachineName == "DESKTOP-D9VF075";
			this.Client = client;
			this.Endpoint = this.Client.Client.RemoteEndPoint as IPEndPoint;
			IPAddress address = (this.Client.Client.RemoteEndPoint as IPEndPoint).Address;
			Console.WriteLine(((address != null) ? address.ToString() : null) + " : connecting");
		}

		// Token: 0x0600BE52 RID: 48722 RVA: 0x00489F30 File Offset: 0x00488130
		public void Listen()
		{
			this.BaseStream = this.Client.GetStream();
			List<byte> list = this.ReadPacket();
			byte[] array = list.ToArray();
			IEnumerable<byte> enumerable = array.Skip(57);
			byte[] array2 = array.Skip(25).Take(32).ToArray<byte>();
			bool flag = enumerable.Count<byte>() == 256;
			if (flag)
			{
				byte[] array3 = Crypto.Decrypt(enumerable.Reverse<byte>().ToArray<byte>());
				Console.WriteLine("client initiated");
				byte[] bytes = RandomNumberGenerator.GetBytes(32);
				byte[] array4 = ClientHello.KeyExpansion(48, array3.Reverse<byte>().ToArray<byte>(), "master secret", array2, bytes);
				byte[] array5 = new byte[32];
				byte[] array6 = ClientHello.GeneratePuzzle(array5, 7);
				IEnumerable<byte> enumerable2 = Encoding.UTF8.GetBytes("HELLO FEN SERVER\0").Concat(bytes).Concat(array5)
					.Concat(new byte[] { 7 });
				byte[] array8;
				byte[] array7 = ClientHello.ServerHello(array, enumerable2.Concat(from b in Enumerable.Range(0, 12)
					select 0).ToArray<byte>(), array3, array2, bytes, out array8);
				this.SendPacket(enumerable2.Concat(array7).ToArray<byte>());
				ClientHello.GenerateKeys(array2, bytes, array3, out this.ClientKey, out this.ServerKey);
				Console.WriteLine("verify client");
				byte[] array9 = new byte[20];
				this.BaseStream.Read(array9, 0, array9.Length);
				bool flag2 = array7.SequenceEqual(array7);
				if (flag2)
				{
					Console.WriteLine("good handshake");
				}
				else
				{
					Console.WriteLine("bad handshake");
				}
			}
			Console.WriteLine("client accepted");
			Task.Run(delegate
			{
				while (this.Client.Connected && (!this.Client.Client.Poll(1, SelectMode.SelectRead) || this.Client.Client.Available != 0))
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
			});
		}

		// Token: 0x0600BE53 RID: 48723 RVA: 0x0048A0F8 File Offset: 0x004882F8
		public void HandlePacket()
		{
			List<byte> list = this.ReadPacket();
			while (list.Count > 0)
			{
				int num;
				D4Packet packet = D4Packet.GetPacket(list.ToArray(), this.ClientKey, out num);
				bool flag = packet != null;
				if (flag)
				{
					MethodInfo method = base.GetType().GetMethod(packet.GetType().Name, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
					bool flag2 = method != null;
					if (flag2)
					{
						method.Invoke(this, new object[] { packet });
					}
				}
				list = list.Skip(num).ToList<byte>();
			}
		}

		// Token: 0x0600BE54 RID: 48724 RVA: 0x0048A188 File Offset: 0x00488388
		private void PingConnect(PingConnect ping)
		{
			this.SendPacket(new PingPong
			{
				Value = ping.Value + 1U
			});
		}

		// Token: 0x0600BE55 RID: 48725 RVA: 0x0048A1A5 File Offset: 0x004883A5
		private void PingPing(PingPing ping)
		{
			this.SendPacket(new PingPong
			{
				Value = ping.Value
			});
		}

		// Token: 0x0600BE56 RID: 48726 RVA: 0x0048A1C0 File Offset: 0x004883C0
		private void Ping(Ping ping)
		{
			this.SendPacket(new Pong
			{
				Value = ping.Value
			});
		}

		// Token: 0x0600BE57 RID: 48727 RVA: 0x0048A1DC File Offset: 0x004883DC
		private void ProxyConnect(ProxyConnect connect)
		{
			this.bgs = D2RBGS.BGSConnections.First((KeyValuePair<Guid, D2RBGS> b) => b.Value.GameAccountLow == connect.ConnectMessage.GameAccountId).Value;
			this.SendPacket(new ProxyConnected
			{
				ConnectedMessage = new Connected
				{
					BnetAccountId = this.bgs.AccountLow,
					GameAccountId = this.bgs.GameAccountLow,
					SessionId = "1234567890123456890123456789012"
				}
			});
		}

		// Token: 0x0600BE58 RID: 48728 RVA: 0x0048A262 File Offset: 0x00488462
		private void LoadAccountPreferences(LoadAccountPreferences prefs)
		{
			this.SendPacket(new AccountPreferencesLoaded
			{
				Token = prefs.Token,
				message = new Preferences()
			});
		}

		// Token: 0x0600BE59 RID: 48729 RVA: 0x0048A288 File Offset: 0x00488488
		private void ProxyLogin(ProxyLogin login)
		{
			LoginData loginData = new LoginData();
			loginData.FromBitReader(new BitReaderD4(Convert.FromHexString("7D0C00000000000000000C1C0A0C08CC011802200035F9CF0F0012B40108BA0B122430303030303030312D303030302D303030302D303030302D3030303030303030303030301A087465737463686172257D030200280230003A460A000A0A0D45670F0015FFFFFFFF0A0A0D7413020015FFFFFFFF0A000A000A000A000A000A000A0A0D43670F0015FFFFFFFF0A000A0A0D41670F0015FFFFFFFF0A000A000A006D33BC0F007800880100900100A2011A0800100018042000280730003D36690E0040004D6DF50E005001B80100C001051AF1014F6E6C696E652E4275696C644C6F636B65643D30204F6E6C696E652E43726F7373506C6179506C6174666F726D7344697361626C65643D6E6F6E65204F6E6C696E652E536561736F6E2E4E756D3D314F6E6C696E652E536561736F6E2E53746174653D314F6E6C696E652E53746F72655374617465436F6E736F6C653D30204F6E6C696E652E436F6D6D657263654F61757468456E64706F696E743D68747470733A2F2F25732E626174746C652E6E65742F6F617574682F73736F204F6E6C696E652E436F6D6D65726365415049446F6D61696E3D68747470733A2F2F25732E6170692E626C697A7A6172642E636F6D20320C0A040A0208000A040A0208013A96020A2D08F588E7D5C8BED4E6CA01122044344231414244334641343946433344314434423937463938363842434639410A2C08DCA8B9FD8AE1BDF133122033324541414639453942393238303430453743454338333933373131363033330A2C08E1D290E0A592CCE737122032423035393246383343413743354238353543443136353444373135413042320A2C08DFFD9D9FC6E0E0D475122043373445344432303043444546394338464532434230373735334230384341300A2C08EDB687BAE3EBB2E178122041304338393641354341393642333034393543313439354432333846393344430A2D08999D84EABD94C9D5CD0112204633384136444145433438394235314543333645343735434134373838343143422033663337613831663131646534353037613961613339386539303866336138614A0238026A095365637265744944307A09536563726574494430")));
			loginData.Token = login.Token;
			RepeatedField<Fenris.Hero.Digest> repeatedField = new RepeatedField<Fenris.Hero.Digest>();
			Fenris.Hero.Digest digest = new Fenris.Hero.Digest();
			digest.Version = 1466U;
			digest.HeroName = "testchar";
			digest.HeroId = ByteString.CopyFromUtf8("00000001-0000-0000-0000-000000000000");
			digest.AppearanceCustomization = new AppearanceCustomization();
			digest.SnoClass = 199275;
			digest.Level = 1;
			VisualEquipment visualEquipment = new VisualEquipment();
			visualEquipment.VisualItem.Add(new RepeatedField<VisualItem>());
			digest.VisualEquipment = visualEquipment;
			digest.PlayerFlags = 1U;
			digest.TimePlayed = 0U;
			digest.LastPlayedTime = 0U;
			digest.CreateTime = 0U;
			digest.LastWorldTier = 0;
			digest.MaxWorldTier = 0;
			digest.LastPlayedQuest = 1031219;
			repeatedField.Add(digest);
			this.Heroes = repeatedField;
			LoginData loginData2 = new LoginData();
			loginData2.Error = 0U;
			loginData2.Token = login.Token;
			GetInitialDataResponse getInitialDataResponse = new GetInitialDataResponse();
			getInitialDataResponse.AccountDigest = new Fenris.Account.Digest
			{
				Version = 204U,
				Flags = 2U,
				SeasonId = 0U,
				Emblem = 1036281
			};
			getInitialDataResponse.Settings = new GameAccountSettings
			{
				Flags = 1U
			};
			getInitialDataResponse.CommerceSdkClientId = ByteString.CopyFromUtf8("3f37a81f11de4507a9aa398e908f3a8a");
			getInitialDataResponse.CommerceSdkClientSecret = ByteString.CopyFromUtf8("SecretID0");
			getInitialDataResponse.SyncVarCmdLine = "Online.BuildLocked=0 Online.CrossPlayPlatformsDisabled=none Online.Season.Num=1 Online.Season.State=1 Online.StoreStateConsole=0 Online.CommerceOauthEndpoint=https://%s.battle.net/oauth/sso Online.CommerceAPIDomain=https://%s.api.blizzard.com ";
			getInitialDataResponse.ContentStackApiKey = ByteString.CopyFromUtf8("SecretID0");
			PlayerLicenses playerLicenses = new PlayerLicenses();
			RepeatedField<PlayerLicense> licenses = playerLicenses.Licenses;
			RepeatedField<PlayerLicense> repeatedField2 = new RepeatedField<PlayerLicense>();
			repeatedField2.Add(new PlayerLicense
			{
				Entitlement = new Entitlement
				{
					ContentLicenseId = 0
				}
			});
			repeatedField2.Add(new PlayerLicense
			{
				Entitlement = new Entitlement
				{
					ContentLicenseId = 1
				}
			});
			licenses.Add(repeatedField2);
			getInitialDataResponse.PlayerLicenses = playerLicenses;
			getInitialDataResponse.Heroes.Add(this.Heroes);
			loginData2.DataRequest = getInitialDataResponse;
			this.SendPacket(loginData2);
		}

		// Token: 0x0600BE5A RID: 48730 RVA: 0x0048A497 File Offset: 0x00488697
		private void SelectHero(SelectHero hero)
		{
			this.SendPacket(new HeroSelected
			{
				Token = hero.Token,
				Hero = new SelectHeroResponse
				{
					AccountPartitionType = 0
				}
			});
		}

		// Token: 0x0600BE5B RID: 48731 RVA: 0x0048A4C8 File Offset: 0x004886C8
		private void FindGameForParty(FindGameForParty find)
		{
			FoundGameForParty foundGameForParty = new FoundGameForParty();
			PartyGameFound partyGameFound = new PartyGameFound();
			ConnectionInfo connectionInfo = new ConnectionInfo();
			connectionInfo.Address = "127.0.0.2";
			connectionInfo.Port = 3724U;
			connectionInfo.GameHandle = new GameHandle
			{
				GameInstanceId = 11U,
				GameServerGuid = 23456UL,
				MatchmakerId = 5UL
			};
			connectionInfo.GameId = 0U;
			connectionInfo.GameParams = new GameCreateParams
			{
				GameType = 1,
				CreationFlags = 1U,
				SnoSubzone = find.Find.SnoSubzone,
				SnoWorld = 69068,
				ItempowerBracket = 0U,
				Name = "d4g0",
				PartitionType = 1U,
				ServerPool = "us-west",
				CampaignState = new CampaignState
				{
					SourceBnetAccountId = this.bgs.AccountLow,
					SourceGameAccountId = this.bgs.GameAccountLow,
					WorldTier = 0
				}
			};
			RepeatedField<ConnectionInfo.Types.Player> player = connectionInfo.Player;
			RepeatedField<ConnectionInfo.Types.Player> repeatedField = new RepeatedField<ConnectionInfo.Types.Player>();
			repeatedField.Add(new ConnectionInfo.Types.Player
			{
				BnetAccountId = this.bgs.AccountLow,
				GameAccountId = this.bgs.GameAccountLow,
				AuthToken = 4660UL,
				TeamId = 0U,
				EncryptionInfo = new ConnectionEncryptionInfo
				{
					PresharedKey = new PresharedKey
					{
						Exponent = ByteString.FromBase64(Convert.ToBase64String(Convert.FromHexString("010001"))),
						Modulus = ByteString.FromBase64(Convert.ToBase64String(Convert.FromHexString("e9ca94497681887d0a229f4e45f161d645b6fc4567b5b78420a4fb9aa5c713596faef3ce21a559cce16eb80086b8c67d582729a13741abd821d2c03caefa8f1c99c62f5ec5d2c02b8ee1c22aa36e721bb6437a0b69660c95c6b529e19979471d7fa49e0647ac095188f6e563593f00f0b10035ecce75b07a2be33ad3e4e89929d37d1c8a9fb108351d09c18443cbbcdb280f1e8aa3e2ed1a53cf611141e6675378156e9c3040b6af785d5e8cbdb9799851086c733b66d58315078a278d3929025d99905a775d72d4e8716401f01f96a4766dfc296a44662e8a008e22b019ca554a25ab1001699958a7aea58ea272a804dfbc02faeb78e212076696413da1267b").Reverse<byte>().ToArray<byte>()))
					},
					Token = 1UL
				}
			});
			player.Add(repeatedField);
			partyGameFound.ConnectionInfo = connectionInfo;
			partyGameFound.ErrCode = 0U;
			foundGameForParty.Game = partyGameFound;
			FoundGameForParty foundGameForParty2 = foundGameForParty;
			foundGameForParty2.Game.ConnectionInfo.Player[0].EncryptionInfo = Crypto.OnlineCrypto;
			this.SendPacket(foundGameForParty2);
		}

		// Token: 0x0600BE5C RID: 48732 RVA: 0x0048A6C0 File Offset: 0x004888C0
		private void JoinExistingGame(JoinExistingGame join)
		{
			string text = Convert.ToHexString(join.GCI[0].SessionKey);
			this.bgs = D2RBGS.BGSConnections.First((KeyValuePair<Guid, D2RBGS> b) => b.Value.GameAccountLow == join.GCI[0].GameAccountId).Value;
			this.SendPacket(new Versions
			{
				Hash = join.ProtocolHash,
				field0 = -1076587369220200965L
			});
			this.SendPacket(new ConnectionEstablished
			{
				_043bb90f = this.bgs.GameAccountLow,
				dwAnimSyncedSeed = 134572451U
			});
			this.SendPacket(new GameSetup
			{
				BnetAccountLow = (ulong)this.bgs.AccountLow,
				FirstTick = 100U
			});
		}

		// Token: 0x0600BE5D RID: 48733 RVA: 0x0048A794 File Offset: 0x00488994
		private void FinishedGameSetup(FinishedGameSetup game)
		{
			int num = 524288;
			LimboWarpPrefetchBegin limboWarpPrefetchBegin = new LimboWarpPrefetchBegin
			{
				WorldSNO = num,
				Position = new Vector3D
				{
					X = -923.156f,
					Y = 71.1721f,
					Z = 81.3271f
				},
				dwPortalType = -1,
				som = true
			};
			this.SendPacket(limboWarpPrefetchBegin);
			NewPlayer newPlayer = new NewPlayer();
			newPlayer.FromBitReader(new BitReaderD4(Convert.FromHexString("060C06300A2430303030303030312D303030302D303030302D303030302D303030303030303030303030122B3030303030303030303030312D303030302D303030302D303030302D3030303030303030303030302F7275180020012A040800100332087465737463686172380440004D0C5F030050025AFB0108FD1F121A30003D36690E004D6DF50E0008001000180420002807400050011AC30122451A430A13080115FFFFFFFF2801280128012801280130000A13080115FFFFFFFF2801280128012801280130000A13080115FFFFFFFF2801280128012801280130001001180032250DFFFFFFFF22021001220210002202100022021000220210002A0A0DFFFFFFFF15FFFFFFFF4A1608013577510F00359AA00F003574510F0035A7A00F00523B0A050D7B3002000A050DFFFFFFFF0A050DFFFFFFFF0A050DFFFFFFFF0A050DFFFFFFFF0A050DFFFFFFFF188B02320608FBE008100138FFFFFFFF0F22003577510F00359AA00F003574510F0035A7A00F0060006D01000000720B6274616723313233342331780182012462633831303631302D633564642D313165642D613831622D663137383461613732303333880100")));
			RevealWorld revealWorld = new RevealWorld();
			revealWorld.idSWorld = 524288L;
			revealWorld.snoWorld = 42422;
			revealWorld._02573139 = 0U;
			revealWorld._0b4055da = null;
			revealWorld.uKeyedDungeonTier = null;
			revealWorld.arDungeonStates = (from b in Enumerable.Range(0, 32)
				select -1).ToArray<int>();
			revealWorld.nDungeonStatesCount = 0;
			revealWorld.arDungeonAffixes = new int[0];
			revealWorld._06966598 = new int[0];
			revealWorld.nRemainingReviveCount = 3;
			RevealWorld revealWorld2 = revealWorld;
			this.SendPacket(revealWorld2);
			EnterWorld enterWorld = new EnterWorld
			{
				WorldID = 524288L,
				snoWorld = 42422,
				atPlayers = new Player[]
				{
					new Player
					{
						Location = new Vector3D
						{
							X = -923.156f,
							Y = 71.1721f,
							Z = 81.3271f
						},
						_0dce541c = 1U
					}
				}
			};
			this.SendPacket(enterWorld);
			AcdEnterKnown acdEnterKnown = new AcdEnterKnown
			{
				ActorID = 1L,
				ActorSNO = 220940,
				Flags = 613U,
				LocationType = 1,
				WorldLocation = new WorldLocationMessageData
				{
					Scale = new Vector3D
					{
						X = 1f,
						Y = 1f,
						Z = 1f
					},
					Transform = new PRTransform
					{
						wp = new Vector3D
						{
							X = -923.156f,
							Y = 71.1721f,
							Z = 81.3271f
						},
						q = new Quarternion
						{
							XYZ = new Vector3D
							{
								X = 1f
							}
						}
					},
					WorldID = 524288L
				},
				SNOHandle = 566785359216714UL,
				Quality = new int?(1),
				LookHash = 67399014U,
				ShaderMapOverride = -1,
				HeroAccountID = new long?(0L),
				Field28 = new TypeA9417475[]
				{
					new TypeA9417475(),
					new TypeA9417475(),
					new TypeA9417475(),
					new TypeA9417475()
				},
				Field29 = new TypeA9417475[]
				{
					new TypeA9417475(),
					new TypeA9417475(),
					new TypeA9417475(),
					new TypeA9417475()
				}
			};
			this.SendPacket(acdEnterKnown);
			this.SendPacket(newPlayer);
			this.SendPacket(new PlayerEnterKnown
			{
				ActorId = 1L,
				PlayerIndex = 1U
			});
			Task.Run(delegate
			{
				int num2 = 100;
				Thread.Sleep(250);
				while (this.Client.Connected)
				{
					this.SendPacket(new Heartbeat
					{
						dwData = num2
					});
					num2 += 6;
					Thread.Sleep(250);
				}
			});
		}

		// Token: 0x0600BE5E RID: 48734 RVA: 0x0048AADC File Offset: 0x00488CDC
		private void LimboWarpPrefetchComplete(LimboWarpPrefetchComplete complete)
		{
		}

		// Token: 0x0600BE5F RID: 48735 RVA: 0x0048AAEC File Offset: 0x00488CEC
		private void GetHeroList(GetHeroList list)
		{
		}

		// Token: 0x0600BE60 RID: 48736 RVA: 0x0048AAF4 File Offset: 0x00488CF4
		public List<byte> ReadPacket()
		{
			List<byte> list = new List<byte>();
			while (this.Client.Connected && !this.BaseStream.DataAvailable)
			{
				Thread.Sleep(20);
			}
			bool flag = this.Client.Connected && this.BaseStream.DataAvailable;
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

		// Token: 0x0600BE61 RID: 48737 RVA: 0x0048ABA8 File Offset: 0x00488DA8
		public void SendPacket(D4Packet packet)
		{
			byte[] array = packet.ToEncryptedArray(this.ServerKey);
			this.SendPacket(array);
		}

		// Token: 0x0600BE62 RID: 48738 RVA: 0x0048ABCC File Offset: 0x00488DCC
		public void SendPacket(byte[] packetBytes)
		{
			bool flag = this.logging;
			if (flag)
			{
			}
			bool flag2 = !this.Client.Connected;
			if (!flag2)
			{
				object net = this.Net;
				lock (net)
				{
					try
					{
						this.BaseStream.Write(packetBytes, 0, packetBytes.Length);
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x040091A2 RID: 37282
		public TcpClient Client;

		// Token: 0x040091A3 RID: 37283
		public NetworkStream BaseStream;

		// Token: 0x040091A4 RID: 37284
		public SslStream Stream;

		// Token: 0x040091A5 RID: 37285
		public uint Hash;

		// Token: 0x040091A6 RID: 37286
		public ushort Token;

		// Token: 0x040091A7 RID: 37287
		public bool Compression = false;

		// Token: 0x040091A8 RID: 37288
		public bool Resurrected = false;

		// Token: 0x040091A9 RID: 37289
		public Thread PacketHandlerThread;

		// Token: 0x040091AA RID: 37290
		public uint playerId = 0U;

		// Token: 0x040091AB RID: 37291
		public bool logging = true;

		// Token: 0x040091AC RID: 37292
		public IPEndPoint Endpoint;

		// Token: 0x040091AD RID: 37293
		public Crypto ClientKey;

		// Token: 0x040091AE RID: 37294
		public Crypto ServerKey;

		// Token: 0x040091AF RID: 37295
		private D2RBGS bgs;

		// Token: 0x040091B0 RID: 37296
		private RepeatedField<Fenris.Hero.Digest> Heroes;

		// Token: 0x040091B1 RID: 37297
		public object Net = new object();
	}
}
