using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace DiabloBridge
{
	// Token: 0x02000990 RID: 2448
	public class Server
	{
		// Token: 0x0600BA70 RID: 47728 RVA: 0x00469D18 File Offset: 0x00467F18
		public void Listen(IPAddress server)
		{
			Console.WriteLine("server starting");
			this.Realm = new TcpListener(server, 6113);
			this.Realm.Start();
			this.BNet = new TcpListener(server, 6112);
			this.BNet.Server.DontFragment = true;
			this.BNet.Server.NoDelay = true;
			this.BNet.Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
			this.BNet.Start();
			this.Ftp = new TcpListener(server, 6111);
			this.Ftp.Start();
			this.Game = new TcpListener(server, 4000);
			this.Game.Start();
			Console.WriteLine("server started");
			while (this.ServerListening)
			{
				try
				{
					bool flag = this.BNet.Pending();
					if (flag)
					{
						BNetServer bnetServer = new BNetServer(this.BNet.AcceptTcpClient());
					}
					else
					{
						bool flag2 = this.Realm.Pending();
						if (flag2)
						{
							RealmServer realmServer = new RealmServer(this.Realm.AcceptTcpClient());
						}
						else
						{
							bool flag3 = this.Ftp.Pending();
							if (flag3)
							{
								RealmServer realmServer2 = new RealmServer(this.Realm.AcceptTcpClient());
							}
							else
							{
								bool flag4 = this.Game.Pending();
								if (flag4)
								{
									GameProxy gameProxy = new GameProxy(this.Game.AcceptTcpClient());
								}
								else
								{
									Thread.Sleep(100);
								}
							}
						}
					}
				}
				catch
				{
					Thread.Sleep(100);
				}
			}
		}

		// Token: 0x0600BA71 RID: 47729 RVA: 0x00469EC4 File Offset: 0x004680C4
		public static void BlockAccount(string email)
		{
			BNetServer bnetServer;
			bool flag = BNetServer.BNetServers.TryRemove(email, out bnetServer);
			if (flag)
			{
				bnetServer.Dispose();
			}
			BNetServer.BNetServers.TryAdd(email, new BNetServer());
			RealmServer realmServer;
			bool flag2 = RealmServer.RealmServers.TryRemove(email, out realmServer);
			if (flag2)
			{
				realmServer.Dispose();
			}
			RealmServer.RealmServers.TryAdd(email, new RealmServer());
			GameProxy gameProxy;
			bool flag3 = GameProxy.GameProxies.TryRemove(email, out gameProxy);
			if (flag3)
			{
				gameProxy.Terminate();
			}
			GameProxy.GameProxies.TryAdd(email, new GameProxy());
		}

		// Token: 0x0600BA72 RID: 47730 RVA: 0x00469F54 File Offset: 0x00468154
		public static void UnblockAccount(string email)
		{
			BNetServer bnetServer;
			BNetServer.BNetServers.TryRemove(email, out bnetServer);
			RealmServer realmServer;
			RealmServer.RealmServers.TryRemove(email, out realmServer);
			GameProxy gameProxy;
			GameProxy.GameProxies.TryRemove(email, out gameProxy);
		}

		// Token: 0x040088DE RID: 35038
		public TcpListener GameServer;

		// Token: 0x040088DF RID: 35039
		public TcpListener BNet;

		// Token: 0x040088E0 RID: 35040
		public TcpListener Realm;

		// Token: 0x040088E1 RID: 35041
		public TcpListener Ftp;

		// Token: 0x040088E2 RID: 35042
		public TcpListener Game;

		// Token: 0x040088E3 RID: 35043
		public bool Compression = false;

		// Token: 0x040088E4 RID: 35044
		public Thread PacketHandlerThread;

		// Token: 0x040088E5 RID: 35045
		public bool ServerListening = true;
	}
}
