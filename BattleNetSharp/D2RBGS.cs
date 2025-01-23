using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Net.WebSockets;
using System.Reflection;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BattleNetSharp.D4;
using BattleNetSharp.jam;
using BattleNetSharp.Network;
using Bgs.Protocol;
using Bgs.Protocol.Account.V1;
using Bgs.Protocol.Authentication.V1;
using Bgs.Protocol.Authentication.V2.Client;
using Bgs.Protocol.Connection.V1;
using Bgs.Protocol.GameUtilities.V1;
using Bgs.Protocol.GameUtilities.V2.Client;
using Bgs.Protocol.Leaderboard.V1.Client;
using Bgs.Protocol.Notification.V2.Client;
using Bgs.Protocol.Presence.V1;
using Bgs.Protocol.Resources.V1;
using Bgs.Protocol.Session.V1;
using Bgs.Protocol.Session.V2.Client;
using Bgs.Protocol.V2;
using Classic.Protocol.External.V1.Character;
using Classic.Protocol.External.V1.GameManagement;
using Classic.Protocol.V1.D2RConnection;
using Classic.Protocol.V1.GameVersion;
using Classic.Protocol.V1.Network;
using D2Data;
using Fenris.ClientMessage;
using Fenris.Online;
using Fleck;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Grpc.Core;
using Newtonsoft.Json;

namespace BattleNetSharp
{
	// Token: 0x02000ACB RID: 2763
	public class D2RBGS
	{
		// Token: 0x17003925 RID: 14629
		// (get) Token: 0x0600BC1B RID: 48155 RVA: 0x004749A8 File Offset: 0x00472BA8
		public bool Connected
		{
			get
			{
				RealmWebSocket realmConnection = this.RealmConnection;
				bool flag;
				if (realmConnection == null)
				{
					flag = false;
				}
				else
				{
					ClientWebSocket clientWebSocket = realmConnection.clientWebSocket;
					WebSocketState? webSocketState = ((clientWebSocket != null) ? new WebSocketState?(clientWebSocket.State) : null);
					WebSocketState webSocketState2 = WebSocketState.Open;
					flag = (webSocketState.GetValueOrDefault() == webSocketState2) & (webSocketState != null);
				}
				return flag;
			}
		}

		// Token: 0x17003926 RID: 14630
		// (get) Token: 0x0600BC1C RID: 48156 RVA: 0x004749F5 File Offset: 0x00472BF5
		public uint GameAccountLow
		{
			get
			{
				return 1U;
			}
		}

		// Token: 0x0600BC1D RID: 48157 RVA: 0x004749F8 File Offset: 0x00472BF8
		public void WebServer()
		{
			Task.Run(delegate
			{
				Console.WriteLine("web server starting");
				HttpListener httpListener = new HttpListener();
				httpListener.Prefixes.Add("https://*/");
				httpListener.Prefixes.Add("http://*/");
				httpListener.Start();
				Console.WriteLine("web server started");
				for (;;)
				{
					try
					{
						HttpListenerContext context = httpListener.GetContext();
						HttpListenerRequest request = context.Request;
						HttpListenerResponse response = context.Response;
						Console.WriteLine(context.Request.RawUrl);
						bool flag = context.Request.RawUrl != "/";
						if (flag)
						{
							byte[] array = File.ReadAllBytes("bgs-key-fingerprint");
							response.ContentLength64 = (long)array.Length;
							response.OutputStream.Write(array, 0, array.Length);
						}
						else
						{
							bool flag2 = request.HttpMethod == "POST";
							if (flag2)
							{
								int num = (int)context.Request.ContentLength64;
								byte[] array2 = new byte[num];
								for (int i = 0; i < num; i += context.Request.InputStream.Read(array2, i, num - i))
								{
								}
							}
							else
							{
								byte[] array3 = File.ReadAllBytes("bgs-key-fingerprint");
								response.ContentLength64 = (long)array3.Length;
								response.OutputStream.Write(array3, 0, array3.Length);
							}
						}
						response.OutputStream.Close();
					}
					catch (Exception ex)
					{
						Console.WriteLine("error in webserver : " + ex.Message);
						Console.WriteLine(ex.StackTrace);
					}
				}
			}).Start();
		}

		// Token: 0x0600BC1E RID: 48158 RVA: 0x00474A28 File Offset: 0x00472C28
		public void SendBgsServer(IMessage reply, string methodName, Type service)
		{
			Header header = new Header();
			header.ServiceId = 0U;
			Header header2 = header;
			uint num = this.bgsToken;
			this.bgsToken = num + 1U;
			header2.Token = num;
			header.ClientId = this.ClientId;
			Type type = (Type)service.BaseType.GetCustomAttributesData()[0].ConstructorArguments[0].Value;
			ServiceDescriptor serviceDescriptor = (ServiceDescriptor)type.GetProperty("Descriptor").GetValue(null);
			MethodDescriptor methodDescriptor = serviceDescriptor.Methods.First((MethodDescriptor m) => m.Name == methodName);
			BGSServiceOptions extension = serviceDescriptor.GetOptions().GetExtension<BGSServiceOptions>(ServiceOptionsExtensions.ServiceOptions_);
			uint num2 = BitConverter.ToUInt32(new FNV1A32().ComputeHash(Encoding.UTF8.GetBytes(extension.DescriptorName)));
			header.ServiceHash = num2;
			MethodDescriptor methodDescriptor2 = serviceDescriptor.FindMethodByName(methodDescriptor.Name);
			header.MethodId = methodDescriptor2.GetOptions().GetExtension<BGSMethodOptions>(MethodOptionsExtensions.MethodOptions_).Id;
			header.Size = (uint)MessageExtensions.ToByteArray(reply).Length;
			byte[] array = MessageExtensions.ToByteArray(header);
			byte[] array2 = MessageExtensions.ToByteArray(reply);
			List<byte> list = BitConverter.GetBytes((ushort)array.Length).Reverse<byte>().ToList<byte>();
			list.AddRange(array);
			list.AddRange(array2);
			bool flag = D2RBGS.logging;
			if (flag)
			{
				string[] array3 = new string[6];
				array3[0] = "s2c invoke : ";
				array3[1] = service.FullName;
				array3[2] = ".";
				array3[3] = methodDescriptor.Name;
				array3[4] = "() : ";
				int num3 = 5;
				Header header3 = header;
				array3[num3] = ((header3 != null) ? header3.ToString() : null);
				Console.WriteLine(string.Concat(array3));
			}
			bool flag2 = D2RBGS.logging;
			if (flag2)
			{
				Console.WriteLine(reply);
			}
			this.bgsWsConnection.Send(list.ToArray());
		}

		// Token: 0x0600BC1F RID: 48159 RVA: 0x00474C08 File Offset: 0x00472E08
		public void SendRealmServer(IMessage reply, string methodName, IServiceListener service)
		{
			Header header = new Header();
			header.ServiceId = service.Hash;
			Header header2 = header;
			uint num = this.realmToken;
			this.realmToken = num + 1U;
			header2.Token = num;
			header.ObjectId = (ulong)(0xFFFFFFFF968224F1);
			header.Status = 0U;
			header.IsResponse = false;
			header.RequestId = "";
			MethodDescriptor methodDescriptor = service.Descriptor.FindMethodByName(methodName);
			header.MethodId = methodDescriptor.GetOptions().GetExtension<BGSMethodOptions>(MethodOptionsExtensions.MethodOptions_).Id;
			header.Size = (uint)MessageExtensions.ToByteArray(reply).Length;
			byte[] array = MessageExtensions.ToByteArray(header);
			byte[] array2 = MessageExtensions.ToByteArray(reply);
			List<byte> list = BitConverter.GetBytes((ushort)array.Length).Reverse<byte>().ToList<byte>();
			list.AddRange(array);
			list.AddRange(array2);
			this.realmWsConnection.Send(list.ToArray());
		}

		// Token: 0x0600BC20 RID: 48160 RVA: 0x00474CF0 File Offset: 0x00472EF0
		public void RealmServer()
		{
			Dictionary<uint, IServiceListener> Services = new Dictionary<uint, IServiceListener>();
			foreach (Type type in from t in Assembly.GetExecutingAssembly().GetTypes()
				where t.GetInterface("IServiceListener") != null
				select t)
			{
				IServiceListener serviceListener = (IServiceListener)Activator.CreateInstance(type);
				Services.Add(serviceListener.Hash, serviceListener);
			}
			new WebSocketServer("wss://127.0.0.1:443", true)
			{
				ListenerSocket = 
				{
					NoDelay = true
				},
				RestartAfterListenError = true,
				EnabledSslProtocols = SslProtocols.Tls12,
				Certificate = new X509Certificate2("C:\\Users\\" + Environment.UserName + "\\Documents\\GitHub\\BattleNetSharp\\BattleNetSharp\\bnetserver.p12", "123")
			}.Start(delegate(IWebSocketConnection socket)
			{
				socket.OnOpen = delegate
				{
					Console.WriteLine("Open!");
				};
				socket.OnClose = delegate
				{
					Console.WriteLine("Close!");
				};
				socket.OnMessage = delegate(string message)
				{
					Console.WriteLine("Msg::" + message);
				};
				socket.OnBinary = delegate(byte[] recv)
				{
					this.realmWsConnection = socket;
					ushort num = BitConverter.ToUInt16(recv.Take(2).Reverse<byte>().ToArray<byte>(), 0);
					Header header = new Header();
					MessageExtensions.MergeFrom(header, recv.Skip(2).Take((int)num).ToArray<byte>());
					bool flag = D2RBGS.logging;
					if (flag)
					{
						Console.WriteLine(header);
					}
					bool flag2 = Services.ContainsKey(header.ServiceId);
					if (flag2)
					{
						IServiceListener serviceListener2 = Services[header.ServiceId];
						bool flag3 = D2RBGS.logging;
						if (flag3)
						{
							string[] array = new string[6];
							array[0] = "c2rs invoke : ";
							array[1] = serviceListener2.GetType().Name;
							array[2] = ".";
							array[3] = serviceListener2.GetMethod(header.MethodId);
							array[4] = "()";
							int num2 = 5;
							Header header2 = header;
							array[num2] = ((header2 != null) ? header2.ToString() : null);
							Console.WriteLine(string.Concat(array));
						}
						bool flag4 = D2RBGS.logging;
						if (flag4)
						{
							Console.WriteLine(Convert.ToBase64String(recv.ToArray<byte>()));
						}
						bool flag5 = D2RBGS.logging;
						if (flag5)
						{
							string text;
							Console.WriteLine(serviceListener2.GetPacket(header.MethodId, recv.Skip(2).Skip((int)num).ToArray<byte>(), out text));
						}
						ConnectionContext connectionContext = new ConnectionContext
						{
							Caller = socket.ConnectionInfo.Id
						};
						IMessage message = serviceListener2.Invoke(header.MethodId, recv.Skip(2).Skip((int)num).ToArray<byte>(), connectionContext);
						bool flag6 = message is NO_RESPONSE;
						if (!flag6)
						{
							byte[] array2 = MessageExtensions.ToByteArray(message);
							Header header3 = new Header();
							header3.ServiceId = header.ServiceId;
							header3.MethodId = header.MethodId;
							header3.Token = header.Token;
							header3.ObjectId = header.ObjectId;
							header3.Size = (uint)array2.Length;
							header3.Status = 0U;
							header3.IsResponse = true;
							header3.RequestId = "";
							byte[] array3 = MessageExtensions.ToByteArray(header3);
							List<byte> list = BitConverter.GetBytes((ushort)array3.Length).Reverse<byte>().ToList<byte>();
							list.AddRange(array3);
							list.AddRange(array2);
							bool flag7 = D2RBGS.logging;
							if (flag7)
							{
								string[] array4 = new string[6];
								array4[0] = "rs2c reply : ";
								array4[1] = serviceListener2.GetType().Name;
								array4[2] = ".";
								array4[3] = serviceListener2.GetMethod(header.MethodId);
								array4[4] = "()";
								int num3 = 5;
								Header header4 = header3;
								array4[num3] = ((header4 != null) ? header4.ToString() : null);
								Console.WriteLine(string.Concat(array4));
							}
							bool flag8 = D2RBGS.logging;
							if (flag8)
							{
								Console.WriteLine(message);
							}
							socket.Send(list.ToArray());
						}
					}
					else
					{
						Console.WriteLine("no realm service");
					}
				};
				socket.OnError = delegate(Exception exception)
				{
					Console.WriteLine("err : " + exception.Message);
				};
			});
		}

		// Token: 0x0600BC21 RID: 48161 RVA: 0x00474E04 File Offset: 0x00473004
		public void RealmProxyServer(string url)
		{
			ClientWebSocket realmWs = new ClientWebSocket();
			realmWs.Options.RemoteCertificateValidationCallback = new RemoteCertificateValidationCallback(D2RBGS.ValidateServerCertificate);
			realmWs.ConnectAsync(new Uri(url + "OSI/v2/rpc/client"), new CancellationTokenSource(10000).Token).Wait();
			new WebSocketServer("wss://127.0.0.1:443", true)
			{
				ListenerSocket = 
				{
					NoDelay = true
				},
				RestartAfterListenError = true,
				EnabledSslProtocols = SslProtocols.Tls12,
				Certificate = new X509Certificate2("C:\\Users\\shalzuth\\Documents\\GitHub\\BattleNetSharp\\BattleNetSharp\\bnet.pfx", "123")
			}.Start(delegate(IWebSocketConnection socket)
			{
				socket.OnOpen = delegate
				{
					Console.WriteLine("Open!");
				};
				socket.OnClose = delegate
				{
					Console.WriteLine("Close!");
				};
				socket.OnMessage = delegate(string message)
				{
					Console.WriteLine("Msg::" + message);
				};
				socket.OnBinary = delegate(byte[] recv)
				{
					this.realmWsConnection = socket;
					Console.WriteLine("c2rs : " + BitConverter.ToString(recv));
					ushort num = BitConverter.ToUInt16(recv.Take(2).Reverse<byte>().ToArray<byte>(), 0);
					Header header = new Header();
					MessageExtensions.MergeFrom(header, recv.Skip(2).Take((int)num).ToArray<byte>());
					realmWs.SendAsync(recv, WebSocketMessageType.Binary, true, CancellationToken.None).Wait();
				};
				socket.OnError = delegate(Exception exception)
				{
					Console.WriteLine("err : " + exception.Message);
				};
			});
			Task.Run(delegate
			{
				for (;;)
				{
					byte[] array = new byte[4096];
					try
					{
						WebSocketReceiveResult result = realmWs.ReceiveAsync(array, CancellationToken.None).Result;
						Console.WriteLine(string.Concat(new string[]
						{
							result.MessageType.ToString(),
							" : ",
							result.Count.ToString(),
							" : ",
							result.EndOfMessage.ToString()
						}));
						Console.WriteLine("rs2c : " + BitConverter.ToString(array.Take(result.Count).ToArray<byte>()));
						ushort num2 = BitConverter.ToUInt16(array.Take(2).Reverse<byte>().ToArray<byte>(), 0);
						Header header2 = new Header();
						MessageExtensions.MergeFrom(header2, array.Skip(2).Take((int)num2).ToArray<byte>());
						bool flag = header2.Status == 26U;
						if (flag)
						{
							header2.Status = 0U;
							byte[] array2 = array.Skip(2).Take((int)num2).ToArray<byte>();
							byte[] array3 = MessageExtensions.ToByteArray(header2);
							List<byte> list = BitConverter.GetBytes((ushort)array3.Length).Reverse<byte>().ToList<byte>();
							list.AddRange(array3);
							list.AddRange(array.Skip(2).Skip((int)num2).ToArray<byte>());
							array = list.ToArray();
						}
					}
					catch
					{
						Console.WriteLine("conn term");
						Thread.Sleep(5000);
						break;
					}
				}
			});
		}

        // Token: 0x0600BC22 RID: 48162 RVA: 0x00474EE0 File Offset: 0x004730E0
		// [Ares]
        public static void BgsProxyServer()
        {
            ulong token = 0UL;
            string url = "us.actual.battle.net";

            new WebSocketServer("wss://127.0.0.1:1119", true)
            {
                SupportedSubProtocols = new[] { "v1.rpc.battle.net" },
                ListenerSocket = { NoDelay = true },
                RestartAfterListenError = true,
                EnabledSslProtocols = SslProtocols.Tls12,
                Certificate = new X509Certificate2($"C:\\Users\\{Environment.UserName}\\Documents\\GitHub\\BattleNetSharp\\BattleNetSharp\\bnetserver.p12", "123")
            }.Start(socket =>
            {
                bool connected = false;

                socket.OnOpen = () =>
                {
                    Console.WriteLine("Connection opened!");
                    var connectionId = socket.ConnectionInfo.Id;
                    var connection = new D2RBGS { bgsWsConnection = socket };
                    D2RBGS.BGSConnections[connectionId] = connection;

                    foreach (var type in Assembly.GetExecutingAssembly().GetTypes()
                        .Where(t => t.GetInterface(nameof(IServiceListener)) != null))
                    {
                        var listener = (IServiceListener)Activator.CreateInstance(type);
                        connection.Listeners.Add(listener.Hash, listener);
                    }

                    connection.bgsWs.Options.RemoteCertificateValidationCallback = D2RBGS.ValidateServerCertificate;
                    connection.bgsWs.Options.AddSubProtocol("v1.rpc.battle.net");

                    var cancellationToken = new CancellationTokenSource(10000).Token;
                    connection.bgsWs.ConnectAsync(new Uri($"wss://{url}:1119"), cancellationToken).Wait();

                    Task.Run(() =>
                    {
                        var buffer = new List<byte>();
                        while (true)
                        {
                            try
                            {
                                var array = new byte[4096];
                                var result = connection.bgsWs.ReceiveAsync(array, CancellationToken.None).Result;

                                if (result.MessageType == WebSocketMessageType.Close)
                                {
                                    Console.WriteLine("Connection closing!");
                                    break;
                                }

                                buffer.AddRange(array.Take(result.Count));
                                if (!result.EndOfMessage) continue;

                                try
                                {
                                    var headerLength = BitConverter.ToUInt16(buffer.Take(2).Reverse().ToArray(), 0);
                                    var headerData = buffer.Skip(2).Take(headerLength).ToArray();

                                    var header = new Header();
                                    MessageExtensions.MergeFrom(header, headerData);

                                    Console.WriteLine($"Received header: {header}");

                                    if (header.HasServiceHash)
                                    {
                                        if (connection.Listeners.TryGetValue(header.ServiceHash, out var listener))
                                        {
                                            Console.WriteLine($"Processing service hash {header.ServiceHash} with method {header.MethodId}");
                                            var response = listener.GetPacket(header.MethodId, buffer.Skip(2 + headerLength).ToArray(), out var methodName);
                                            Console.WriteLine($"Processed packet: {response}");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Unknown service hash: {header.ServiceHash}");
                                        }
                                    }
                                    else
                                    {
                                        if (connection.TokenToService.TryGetValue(header.Token, out var service))
                                        {
                                            Console.WriteLine($"Processing token {header.Token} for service {service.Item1}");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Unknown token: {header.Token}");
                                        }
                                    }

                                    connection.bgsWsConnection.Send(buffer.ToArray());
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Error processing data: {ex.Message}");
                                }
                                finally
                                {
                                    buffer.Clear();
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error processing WebSocket: {ex.Message}");
                                break;
                            }
                        }
                    });

                    connected = true;
                };

                socket.OnClose = () => Console.WriteLine("Connection closed!");
                socket.OnMessage = message => Console.WriteLine($"Message received: {message}");
                socket.OnBinary = recv =>
                {
                    while (!connected) Thread.Sleep(100);
                    try
                    {
                        var headerLength = BitConverter.ToUInt16(recv.Take(2).Reverse().ToArray(), 0);
                        var header = new Header();
                        MessageExtensions.MergeFrom(header, recv.Skip(2).Take(headerLength).ToArray());

                        Console.WriteLine($"Binary data received: {header}");

                        if (D2RBGS.BGSConnections[socket.ConnectionInfo.Id].Listeners.TryGetValue(header.ServiceHash, out var listener))
                        {
                            Console.WriteLine($"Listener found for service hash {header.ServiceHash}");
                        }
                        else
                        {
                            Console.WriteLine("Unknown service hash in binary data.");
                        }

                        D2RBGS.BGSConnections[socket.ConnectionInfo.Id].bgsWs.SendAsync(recv, WebSocketMessageType.Binary, true, CancellationToken.None).Wait();
                    }
                    catch
                    {
                        Console.WriteLine("Error processing binary data.");
                        D2RBGS.BGSConnections[socket.ConnectionInfo.Id].bgsWs.SendAsync(recv, WebSocketMessageType.Binary, true, CancellationToken.None).Wait();
                    }
                };
                socket.OnError = ex => Console.WriteLine($"Error: {ex.Message}");
                socket.OnPing = _ => Console.WriteLine("Ping received");
                socket.OnPong = _ => Console.WriteLine("Pong received");
            });
        }

        // Token: 0x0600BC23 RID: 48163 RVA: 0x00474F84 File Offset: 0x00473184
        public static void BgsServer()
		{
			Dictionary<uint, IServiceListener> Services = new Dictionary<uint, IServiceListener>();
			foreach (Type type in from t in Assembly.GetExecutingAssembly().GetTypes()
				where t.GetInterface("IServiceListener") != null
				select t)
			{
				IServiceListener serviceListener = (IServiceListener)Activator.CreateInstance(type);
				bool flag = serviceListener.Hash == 3799244302U;
				if (flag)
				{
					Console.WriteLine("");
				}
				bool flag2 = serviceListener is SessionServiceV2;
				if (flag2)
				{
					Console.WriteLine("");
				}
				Services.Add(serviceListener.Hash, serviceListener);
			}
			new WebSocketServer("wss://127.0.0.1:443", true)
			{
				SupportedSubProtocols = new string[] { "v1.rpc.battle.net" },
				ListenerSocket = 
				{
					NoDelay = true
				},
				RestartAfterListenError = true,
				EnabledSslProtocols = SslProtocols.Tls12,
				Certificate = new X509Certificate2("C:\\Users\\" + Environment.UserName + "\\Documents\\GitHub\\BattleNetSharp\\BattleNetSharp\\bnetserver.p12", "123")
			}.Start(delegate(IWebSocketConnection socket)
			{
				socket.OnOpen = delegate
				{
					Console.WriteLine("Open!");
					D2RBGS.BGSConnections[socket.ConnectionInfo.Id] = new D2RBGS();
					D2RBGS.BGSConnections[socket.ConnectionInfo.Id].bgsWsConnection = socket;
				};
				socket.OnClose = delegate
				{
					Console.WriteLine("Close!");
				};
				socket.OnMessage = delegate(string message)
				{
					Console.WriteLine("Msg::" + message);
				};
				socket.OnBinary = delegate(byte[] recv)
				{
					ushort num = BitConverter.ToUInt16(recv.Take(2).Reverse<byte>().ToArray<byte>(), 0);
					Header header = new Header();
					MessageExtensions.MergeFrom(header, recv.Skip(2).Take((int)num).ToArray<byte>());
					bool flag3 = Services.ContainsKey(header.ServiceHash);
					if (flag3)
					{
						IServiceListener serviceListener2 = Services[header.ServiceHash];
						bool flag4 = D2RBGS.logging;
						if (flag4)
						{
							string[] array = new string[6];
							array[0] = "c2bgs invoke : ";
							array[1] = serviceListener2.GetType().Name;
							array[2] = ".";
							array[3] = serviceListener2.GetMethod(header.MethodId);
							array[4] = "()";
							int num2 = 5;
							Header header2 = header;
							array[num2] = ((header2 != null) ? header2.ToString() : null);
							Console.WriteLine(string.Concat(array));
						}
						bool flag5 = D2RBGS.logging;
						if (flag5)
						{
							Console.WriteLine(Convert.ToBase64String(recv.ToArray<byte>()));
						}
						bool flag6 = D2RBGS.logging;
						if (flag6)
						{
							string text;
							Console.WriteLine(serviceListener2.GetPacket(header.MethodId, recv.Skip(2).Skip((int)num).ToArray<byte>(), out text));
						}
						ConnectionContext connectionContext = new ConnectionContext
						{
							Caller = socket.ConnectionInfo.Id
						};
						IMessage message = serviceListener2.Invoke(header.MethodId, recv.Skip(2).Skip((int)num).ToArray<byte>(), connectionContext);
						bool flag7 = message is NO_RESPONSE;
						if (flag7)
						{
							return;
						}
						bool flag8 = message == null;
						if (flag8)
						{
							return;
						}
						byte[] array2 = MessageExtensions.ToByteArray(message);
						Header header3 = new Header();
						header3.ServiceId = 254U;
						header3.Token = header.Token;
						header3.Status = 0U;
						header3.Size = (uint)array2.Length;
						byte[] array3 = MessageExtensions.ToByteArray(header3);
						List<byte> list = BitConverter.GetBytes((ushort)array3.Length).Reverse<byte>().ToList<byte>();
						list.AddRange(array3);
						list.AddRange(array2);
						bool flag9 = D2RBGS.logging;
						if (flag9)
						{
							string[] array4 = new string[6];
							array4[0] = "bgs2c reply : ";
							array4[1] = serviceListener2.GetType().Name;
							array4[2] = ".";
							array4[3] = serviceListener2.GetMethod(header.MethodId);
							array4[4] = "()";
							int num3 = 5;
							Header header4 = header3;
							array4[num3] = ((header4 != null) ? header4.ToString() : null);
							Console.WriteLine(string.Concat(array4));
						}
						bool flag10 = D2RBGS.logging;
						if (flag10)
						{
							Console.WriteLine(message);
						}
						socket.Send(list.ToArray());
					}
					else
					{
						Console.WriteLine("no bgs service + : " + Convert.ToBase64String(recv.ToArray<byte>()));
						socket.Send(recv.ToArray<byte>());
					}
					bool flag11 = header.ServiceId == 254U;
					if (flag11)
					{
						bool flag12 = D2RBGS.logging;
						if (flag12)
						{
							string text2 = "c2s reply : ";
							Header header5 = header;
							Console.WriteLine(text2 + ((header5 != null) ? header5.ToString() : null));
						}
						byte[] array5 = recv.Skip(2).Skip((int)num).ToArray<byte>();
					}
				};
				socket.OnError = delegate(Exception exception)
				{
					Console.WriteLine("BGSsocketOnError : " + exception.Message);
				};
			});
		}

		// Token: 0x0600BC24 RID: 48164 RVA: 0x004750E0 File Offset: 0x004732E0
		public bool BGSLoginLocked(string region, string loginToken, string tag = "", D2RBGS.App d2r = D2RBGS.App.D2R)
		{
			bool flag = !Monitor.TryEnter(D2RBGS.ddosLock, 1000);
			while (flag)
			{
				Thread.Sleep(1000);
				flag = !Monitor.TryEnter(D2RBGS.ddosLock, 1000);
			}
			bool flag2 = this.BGSLogin(region, loginToken, tag, D2RBGS.App.D2R);
			Monitor.Exit(D2RBGS.ddosLock);
			return flag2;
		}

		// Token: 0x0600BC25 RID: 48165 RVA: 0x00475144 File Offset: 0x00473344
		public bool BGSLoginV2(string region, string loginToken, string tag, D2RBGS.App d2r = D2RBGS.App.D2R)
		{
			bool flag5;
			try
			{
				this.Tag = tag;
				int tickCount = Environment.TickCount;
				this.LoginToken = loginToken;
				string text = region + ".actual.battle.net";
				ClientWebSocket bgsWs = new ClientWebSocket();
				bgsWs.Options.RemoteCertificateValidationCallback = new RemoteCertificateValidationCallback(D2RBGS.ValidateServerCertificate);
				bgsWs.Options.AddSubProtocol("v1.rpc.battle.net");
				bgsWs.Options.KeepAliveInterval = new TimeSpan(0, 0, 21);
				try
				{
					bgsWs.ConnectAsync(new Uri("wss://" + text + ":1119"), new CancellationTokenSource(15000).Token).Wait();
				}
				catch
				{
					Console.WriteLine("couldn't connect to bnet rpc timeout");
					return false;
				}
				Channel channel = new Channel(text + ":1119", 1119, new SslCredentials());
				this.BgsConnection = new gRPCWebSocket(channel, bgsWs, tag);
				this.BgsConnection.RecvLoop();
                Bgs.Protocol.Connection.V1.ConnectionService.ConnectionServiceClient ConnectionService = new Bgs.Protocol.Connection.V1.ConnectionService.ConnectionServiceClient(this.BgsConnection);
				Bgs.Protocol.Authentication.V2.Client.AuthenticationService.AuthenticationServiceClient authenticationServiceClient = new Bgs.Protocol.Authentication.V2.Client.AuthenticationService.AuthenticationServiceClient(this.BgsConnection);
				AccountService.AccountServiceClient accountServiceClient = new AccountService.AccountServiceClient(this.BgsConnection);
				Bgs.Protocol.Session.V2.Client.SessionService.SessionServiceClient sessionServiceClient = new Bgs.Protocol.Session.V2.Client.SessionService.SessionServiceClient(this.BgsConnection);
				ResourcesService.ResourcesServiceClient resourcesServiceClient = new ResourcesService.ResourcesServiceClient(this.BgsConnection);
				PresenceService.PresenceServiceClient presenceServiceClient = new PresenceService.PresenceServiceClient(this.BgsConnection);
				ConnectResponse connectResponse = ConnectionService.Connect(new ConnectRequest
				{
					UseBindlessRpc = true
				}, null, null, default(CancellationToken));
				Task.Run(delegate
				{
					try
					{
						while (bgsWs.State == WebSocketState.Open)
						{
                            Bgs.Protocol.Connection.V1.ConnectionService.ConnectionServiceClient connectionService = ConnectionService;
							if (connectionService != null)
							{
								connectionService.KeepAlive(new NoData(), null, null, default(CancellationToken));
							}
							Thread.Sleep(21000);
						}
					}
					catch
					{
						Console.WriteLine("bgs ping end");
					}
				});
				Bgs.Protocol.Authentication.V1.LogonRequest logonRequest = new Bgs.Protocol.Authentication.V1.LogonRequest
				{
					Program = ((d2r == D2RBGS.App.D2R) ? "OSI" : ((d2r == D2RBGS.App.WoW) ? "WoW" : ((d2r == D2RBGS.App.D4) ? "Fen" : "unk"))),
					Platform = "Wn64",
					Locale = "enUS",
					Version = "BGS C++ SDK - v0.0.0",
					ApplicationVersion = ((d2r != D2RBGS.App.D4) ? 1 : int.Parse(this.D4Version.Split('.', StringSplitOptions.None).Last<string>())),
					AllowLogonQueueNotifications = true,
					WebClientVerification = true,
					DeviceId = DeviceId.Json
				};
				Bgs.Protocol.Authentication.V2.Client.LogonRequest logonRequest2 = new Bgs.Protocol.Authentication.V2.Client.LogonRequest
				{
					Platform = logonRequest.Platform,
					Locale = logonRequest.Locale,
					ApplicationVersion = (uint)logonRequest.ApplicationVersion,
					TitleId = 4613486U
				};
				AuthenticationListenerV2 authenticationListenerV = (AuthenticationListenerV2)this.BgsConnection.Listeners.Values.First((IServiceListener a) => a is AuthenticationListenerV2);
				bool flag = !string.IsNullOrEmpty(loginToken);
				if (flag)
				{
					logonRequest.CachedWebCredentials = ByteString.CopyFromUtf8(loginToken);
				}
				bool flag2 = !string.IsNullOrEmpty(loginToken);
				if (flag2)
				{
					logonRequest2.LogonOptions = new LogonOptions
					{
						AuthToken = ByteString.CopyFromUtf8(loginToken)
					};
				}
				NoData noData = authenticationServiceClient.Logon(logonRequest2, null, null, default(CancellationToken));
				bool flag3 = string.IsNullOrEmpty(loginToken);
				if (flag3)
				{
					throw new Exception("add user");
				}
				int num = 100;
				while (authenticationListenerV.LogonResult == null && num-- > 1)
				{
					Thread.Sleep(100);
				}
				bool flag4 = num < 4;
				if (flag4)
				{
					flag5 = false;
				}
				else
				{
					bool flag6 = authenticationListenerV.LogonResult.HasErrorCode && authenticationListenerV.LogonResult.ErrorCode == 52U;
					if (flag6)
					{
						Console.WriteLine("banned account! " + tag);
						flag5 = false;
					}
					else
					{
						GenerateAuthTokenResponse generateAuthTokenResponse = authenticationServiceClient.GenerateAuthToken(new GenerateAuthTokenRequest
						{
							TitleId = logonRequest2.TitleId
						}, null, null, default(CancellationToken));
						this.SessionKey = authenticationListenerV.LogonResult.Record.SessionKey.ToByteArray();
						bool flag7 = d2r == D2RBGS.App.WoW;
						if (flag7)
						{
							flag5 = true;
						}
						else
						{
							Bgs.Protocol.Session.V2.Client.CreateSessionRequest createSessionRequest = new Bgs.Protocol.Session.V2.Client.CreateSessionRequest
							{
								GameAccount = authenticationListenerV.LogonResult.Record.GameAccount[0]
							};
							Bgs.Protocol.Session.V2.Client.CreateSessionResponse createSessionResponse = sessionServiceClient.CreateSession(createSessionRequest, null, null, default(CancellationToken));
							SessionListenerV2 sessionListenerV = (SessionListenerV2)this.BgsConnection.Listeners.Values.First((IServiceListener a) => a is SessionListenerV2);
							num = 100;
							while (sessionListenerV.SessionCreatedNotification == null && num-- > 1)
							{
								Thread.Sleep(100);
							}
							bool flag8 = num < 4;
							if (flag8)
							{
								flag5 = false;
							}
							else
							{
								flag5 = true;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("bgs login fail : " + ex.Message);
				flag5 = false;
			}
			return flag5;
		}

		// Token: 0x0600BC26 RID: 48166 RVA: 0x00475674 File Offset: 0x00473874
		public bool BGSLogin(string region, string loginToken, string tag, D2RBGS.App d2r = D2RBGS.App.D2R)
		{
			bool flag4;
			try
			{
				this.Tag = tag;
				int tickCount = Environment.TickCount;
				this.LoginToken = loginToken;
				string text = region + ".actual.battle.net";
				ClientWebSocket bgsWs = new ClientWebSocket();
				bgsWs.Options.RemoteCertificateValidationCallback = new RemoteCertificateValidationCallback(D2RBGS.ValidateServerCertificate);
				bgsWs.Options.AddSubProtocol("v1.rpc.battle.net");
				bgsWs.Options.KeepAliveInterval = new TimeSpan(0, 0, 21);
				try
				{
					bgsWs.ConnectAsync(new Uri("wss://" + text + ":1119"), new CancellationTokenSource(15000).Token).Wait();
				}
				catch (Exception ex)
				{
					Console.WriteLine("couldn't connect to bnet rpc timeout");
					return false;
				}
				Channel channel = new Channel(text + ":1119", 1119, new SslCredentials());
				this.BgsConnection = new gRPCWebSocket(channel, bgsWs, tag);
				this.BgsConnection.RecvLoop();
                Bgs.Protocol.Connection.V1.ConnectionService.ConnectionServiceClient ConnectionService = new Bgs.Protocol.Connection.V1.ConnectionService.ConnectionServiceClient(this.BgsConnection);
				Bgs.Protocol.Authentication.V1.AuthenticationService.AuthenticationServiceClient authenticationServiceClient = new Bgs.Protocol.Authentication.V1.AuthenticationService.AuthenticationServiceClient(this.BgsConnection);
				AccountService.AccountServiceClient accountServiceClient = new AccountService.AccountServiceClient(this.BgsConnection);
				Bgs.Protocol.Session.V1.SessionService.SessionServiceClient sessionServiceClient = new Bgs.Protocol.Session.V1.SessionService.SessionServiceClient(this.BgsConnection);
				ResourcesService.ResourcesServiceClient resourcesServiceClient = new ResourcesService.ResourcesServiceClient(this.BgsConnection);
				PresenceService.PresenceServiceClient presenceServiceClient = new PresenceService.PresenceServiceClient(this.BgsConnection);
				ConnectResponse connectResponse = ConnectionService.Connect(new ConnectRequest
				{
					UseBindlessRpc = true
				}, null, null, default(CancellationToken));
				Task.Run(delegate
				{
					try
					{
						while (bgsWs.State == WebSocketState.Open)
						{
							Bgs.Protocol.Connection.V1.ConnectionService.ConnectionServiceClient connectionService = ConnectionService;
							if (connectionService != null)
							{
								connectionService.KeepAlive(new NoData(), null, null, default(CancellationToken));
							}
							Thread.Sleep(21000);
						}
					}
					catch
					{
						Console.WriteLine("bgs ping end");
					}
				});
				Bgs.Protocol.Authentication.V1.LogonRequest logonRequest = new Bgs.Protocol.Authentication.V1.LogonRequest
				{
					Program = ((d2r == D2RBGS.App.D2R) ? "OSI" : ((d2r == D2RBGS.App.WoW) ? "WoW" : ((d2r == D2RBGS.App.D4) ? "Fen" : "unk"))),
					Platform = "Wn64",
					Locale = "enUS",
					Version = "BGS C++ SDK - v0.0.0",
					ApplicationVersion = ((d2r != D2RBGS.App.D4) ? 1 : int.Parse(this.D4Version.Split('.', StringSplitOptions.None).Last<string>())),
					AllowLogonQueueNotifications = true,
					WebClientVerification = true,
					DeviceId = DeviceId.Json
				};
				Bgs.Protocol.Authentication.V2.Client.LogonRequest logonRequest2 = new Bgs.Protocol.Authentication.V2.Client.LogonRequest();
				logonRequest2.Platform = logonRequest.Platform;
				logonRequest2.Locale = logonRequest.Locale;
				logonRequest2.ApplicationVersion = (uint)logonRequest.ApplicationVersion;
				logonRequest2.TitleId = 4613486U;
				BattleNetSharp.AuthenticationListener authenticationListener = (BattleNetSharp.AuthenticationListener)this.BgsConnection.Listeners.Values.First((IServiceListener a) => a is BattleNetSharp.AuthenticationListener);
				bool flag = !string.IsNullOrEmpty(loginToken);
				if (flag)
				{
					logonRequest.CachedWebCredentials = ByteString.CopyFromUtf8(loginToken);
				}
				NoData noData = authenticationServiceClient.Logon(logonRequest, null, null, default(CancellationToken));
				bool flag2 = string.IsNullOrEmpty(loginToken);
				if (flag2)
				{
					throw new Exception("add user");
				}
				int num = 100;
				while (authenticationListener.LogonResult == null && num-- > 1)
				{
					Thread.Sleep(1000);
				}
				bool flag3 = num < 4;
				if (flag3)
				{
					flag4 = false;
				}
				else
				{
					bool flag5 = authenticationListener.LogonResult.HasErrorCode && authenticationListener.LogonResult.ErrorCode == 52U;
					if (flag5)
					{
						Console.WriteLine("banned account! " + tag);
						flag4 = false;
					}
					else
					{
						this.SessionKey = authenticationListener.LogonResult.SessionKey.ToByteArray();
						bool flag6 = d2r == D2RBGS.App.WoW;
						if (flag6)
						{
							flag4 = true;
						}
						else
						{
							EntityId entityId = new EntityId();
							entityId.High = authenticationListener.LogonResult.AccountId.High;
							entityId.Low = authenticationListener.LogonResult.AccountId.Low;
							EntityId entityId2 = new EntityId();
							entityId2.High = authenticationListener.LogonResult.GameAccountId[0].High;
							entityId2.Low = authenticationListener.LogonResult.GameAccountId[0].Low;
							Bgs.Protocol.Session.V1.CreateSessionRequest createSessionRequest = new Bgs.Protocol.Session.V1.CreateSessionRequest
							{
								Identity = new Bgs.Protocol.Account.V1.Identity
								{
									Account = new AccountId
									{
										Id = (uint)authenticationListener.LogonResult.AccountId.Low
									},
									GameAccount = new GameAccountHandle
									{
										Id = (uint)authenticationListener.LogonResult.GameAccountId[0].Low,
										Program = ((d2r == D2RBGS.App.D2R) ? 5198665U : ((d2r == D2RBGS.App.WoW) ? 5730135U : 4613486U)),
										Region = 100U
									}
								},
								Platform = BitConverter.ToUInt32(Encoding.UTF8.GetBytes("Wn64").Reverse<byte>().ToArray<byte>()),
								Locale = BitConverter.ToUInt32(Encoding.UTF8.GetBytes("enUS").Reverse<byte>().ToArray<byte>()),
								ApplicationVersion = this.wowVersion,
								SessionKey = authenticationListener.LogonResult.SessionKey
							};
							bool flag7 = d2r == D2RBGS.App.D4;
							if (flag7)
							{
								createSessionRequest.UserAgent = "Fenris";
							}
							Bgs.Protocol.Session.V1.CreateSessionResponse createSessionResponse = sessionServiceClient.CreateSession(createSessionRequest, null, null, default(CancellationToken));
							BattleNetSharp.SessionListener sessionListener = (BattleNetSharp.SessionListener)this.BgsConnection.Listeners.Values.First((IServiceListener a) => a is BattleNetSharp.SessionListener);
							num = 100;
							while (sessionListener.SessionCreatedNotification == null && num-- > 1)
							{
								Thread.Sleep(100);
							}
							bool flag8 = num < 4;
							if (flag8)
							{
								flag4 = false;
							}
							else
							{
								flag4 = true;
							}
						}
					}
				}
			}
			catch (Exception ex2)
			{
				Console.WriteLine("bgs login fail : " + ex2.Message);
				flag4 = false;
			}
			return flag4;
		}

		// Token: 0x0600BC27 RID: 48167 RVA: 0x00475CB8 File Offset: 0x00473EB8
		public void Disconnect()
		{
			Bgs.Protocol.Connection.V1.ConnectionService.ConnectionServiceClient connectionServiceClient = new Bgs.Protocol.Connection.V1.ConnectionService.ConnectionServiceClient(this.BgsConnection);
			connectionServiceClient.ForceDisconnect(new DisconnectNotification
			{
				ErrorCode = 0U
			}, null, null, default(CancellationToken));
		}

		// Token: 0x0600BC28 RID: 48168 RVA: 0x00475CFC File Offset: 0x00473EFC
		public bool RealmLoginLocked(bool d2r = true)
		{
			bool flag = !Monitor.TryEnter(this.realmDdosLock, 1000);
			while (flag)
			{
				Thread.Sleep(100);
				flag = !Monitor.TryEnter(this.realmDdosLock, 1000);
			}
			bool flag2 = (d2r ? this.RealmD2RLogin() : this.RealmD4Login());
			Monitor.Exit(this.realmDdosLock);
			return flag2;
		}

		// Token: 0x0600BC29 RID: 48169 RVA: 0x00475D68 File Offset: 0x00473F68
		public static byte[] WoWDecompress(byte[] input)
		{
			MemoryStream memoryStream = new MemoryStream();
			using (MemoryStream memoryStream2 = new MemoryStream(input))
			{
				using (DeflateStream deflateStream = new DeflateStream(memoryStream2, CompressionMode.Decompress))
				{
					deflateStream.CopyTo(memoryStream);
				}
			}
			return memoryStream.ToArray();
		}

		// Token: 0x0600BC2A RID: 48170 RVA: 0x00475DD4 File Offset: 0x00473FD4
		public bool RealmWowLogin()
		{
			bool flag2;
			try
			{
				bool flag = this.BgsConnection.clientWebSocket.State != WebSocketState.Open;
				if (flag)
				{
					flag2 = false;
				}
				else
				{
					BattleNetSharp.AuthenticationListener authenticationListener = (BattleNetSharp.AuthenticationListener)this.BgsConnection.Listeners.Values.First((IServiceListener a) => a is BattleNetSharp.AuthenticationListener);
					wow.JSONRealmListTicketIdentity jsonrealmListTicketIdentity = new wow.JSONRealmListTicketIdentity
					{
						gameAccountID = authenticationListener.LogonResult.GameAccountId[0].Low,
						gameAccountRegion = 1
					};
					byte[] bytes = RandomNumberGenerator.GetBytes(32);
					wow.JSONRealmListTicketClientInformation jsonrealmListTicketClientInformation = new wow.JSONRealmListTicketClientInformation
					{
						info = new wow.JamJSONRealmListTicketClientInformation
						{
							platform = BitConverter.ToUInt32(Encoding.UTF8.GetBytes("Wn64").Reverse<byte>().ToArray<byte>()),
							currentTime = (uint)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds,
							timeZone = "Etc/UTC",
							versionDataBuild = 47621U,
							audioLocale = BitConverter.ToUInt32(Encoding.UTF8.GetBytes("enUS").Reverse<byte>().ToArray<byte>()),
							version = new wow.JamJSONGameVersion
							{
								versionMajor = 10,
								versionMinor = 0,
								versionRevision = 5,
								versionBuild = this.wowVersion
							},
							secret = bytes.ToList<byte>(),
							type = BitConverter.ToUInt32(Encoding.UTF8.GetBytes("WoW").Reverse<byte>().Concat(new byte[1])
								.ToArray<byte>()),
							textLocale = BitConverter.ToUInt32(Encoding.UTF8.GetBytes("enUS").Reverse<byte>().ToArray<byte>()),
							buildVariant = "win32-x86_64-vc141-release",
							clientArch = BitConverter.ToUInt32(Encoding.UTF8.GetBytes("x64").Reverse<byte>().Concat(new byte[1])
								.ToArray<byte>()),
							platformType = BitConverter.ToUInt32(Encoding.UTF8.GetBytes("Win").Reverse<byte>().Concat(new byte[1])
								.ToArray<byte>()),
							systemArch = BitConverter.ToUInt32(Encoding.UTF8.GetBytes("x64").Reverse<byte>().Concat(new byte[1])
								.ToArray<byte>()),
							systemVersion = "10.0.0.22000"
						}
					};
					Bgs.Protocol.GameUtilities.V1.GameUtilitiesService.GameUtilitiesServiceClient gameUtilitiesServiceClient = new Bgs.Protocol.GameUtilities.V1.GameUtilitiesService.GameUtilitiesServiceClient(this.BgsConnection);
					Bgs.Protocol.GameUtilities.V1.GetAllValuesForAttributeResponse allValuesForAttribute = gameUtilitiesServiceClient.GetAllValuesForAttribute(new Bgs.Protocol.GameUtilities.V1.GetAllValuesForAttributeRequest
					{
						AttributeKey = "Command_RealmListRequest_v1_b9"
					}, null, null, default(CancellationToken));
					Bgs.Protocol.GameUtilities.V1.GetAllValuesForAttributeResponse allValuesForAttribute2 = gameUtilitiesServiceClient.GetAllValuesForAttribute(new Bgs.Protocol.GameUtilities.V1.GetAllValuesForAttributeRequest
					{
						AttributeKey = "Command_RealmListTicketRequest_v1_b9"
					}, null, null, default(CancellationToken));
					Bgs.Protocol.GameUtilities.V1.GetAllValuesForAttributeResponse allValuesForAttribute3 = gameUtilitiesServiceClient.GetAllValuesForAttribute(new Bgs.Protocol.GameUtilities.V1.GetAllValuesForAttributeRequest
					{
						AttributeKey = "Command_RealmJoinRequest_v1_b9"
					}, null, null, default(CancellationToken));
					ClientRequest clientRequest = new ClientRequest();
					clientRequest.Attribute.Add(new List<Bgs.Protocol.Attribute>
					{
						new Bgs.Protocol.Attribute
						{
							Name = "Command_RealmListTicketRequest_v1_b9",
							Value = new Bgs.Protocol.Variant
							{
								IntValue = 0L
							}
						},
						new Bgs.Protocol.Attribute
						{
							Name = "Param_Identity",
							Value = new Bgs.Protocol.Variant
							{
								BlobValue = ByteString.CopyFromUtf8("JSONRealmListTicketIdentity:" + JsonConvert.SerializeObject(jsonrealmListTicketIdentity) + "\0")
							}
						},
						new Bgs.Protocol.Attribute
						{
							Name = "Param_ClientInfo",
							Value = new Bgs.Protocol.Variant
							{
								BlobValue = ByteString.CopyFromUtf8("JSONRealmListTicketClientInformation:" + JsonConvert.SerializeObject(jsonrealmListTicketClientInformation) + "\0")
							}
						}
					});
					ClientResponse clientResponse = gameUtilitiesServiceClient.ProcessClientRequest(clientRequest, null, null, default(CancellationToken));
					Bgs.Protocol.Attribute attribute = clientResponse.Attribute.First((Bgs.Protocol.Attribute a) => a.Name == "Param_RealmListTicket");
					clientRequest = new ClientRequest();
					clientRequest.Attribute.Add(new List<Bgs.Protocol.Attribute>
					{
						new Bgs.Protocol.Attribute
						{
							Name = "Command_LastCharPlayedRequest_v1_b9",
							Value = new Bgs.Protocol.Variant
							{
								StringValue = "1-1-89"
							}
						},
						new Bgs.Protocol.Attribute
						{
							Name = "Param_RealmListTicket",
							Value = new Bgs.Protocol.Variant
							{
								BlobValue = attribute.Value.BlobValue
							}
						}
					});
					ClientResponse clientResponse2 = gameUtilitiesServiceClient.ProcessClientRequest(clientRequest, null, null, default(CancellationToken));
					clientRequest = new ClientRequest();
					clientRequest.Attribute.Add(new List<Bgs.Protocol.Attribute>
					{
						new Bgs.Protocol.Attribute
						{
							Name = "Command_RealmListRequest_v1_b9",
							Value = new Bgs.Protocol.Variant
							{
								StringValue = "1-1-89"
							}
						},
						new Bgs.Protocol.Attribute
						{
							Name = "Param_RealmListTicket",
							Value = new Bgs.Protocol.Variant
							{
								BlobValue = attribute.Value.BlobValue
							}
						},
						new Bgs.Protocol.Attribute
						{
							Name = "Param_Identity",
							Value = new Bgs.Protocol.Variant
							{
								BlobValue = ByteString.CopyFromUtf8("JSONRealmListTicketIdentity:" + JsonConvert.SerializeObject(jsonrealmListTicketIdentity) + "\0")
							}
						},
						new Bgs.Protocol.Attribute
						{
							Name = "Param_ClientInfo",
							Value = new Bgs.Protocol.Variant
							{
								BlobValue = ByteString.CopyFromUtf8("JSONRealmListTicketClientInformation:" + JsonConvert.SerializeObject(jsonrealmListTicketClientInformation) + "\0")
							}
						}
					});
					ClientResponse clientResponse3 = gameUtilitiesServiceClient.ProcessClientRequest(clientRequest, null, null, default(CancellationToken));
					string @string = Encoding.UTF8.GetString(D2RBGS.WoWDecompress(clientResponse3.Attribute.First((Bgs.Protocol.Attribute a) => a.Name == "Param_RealmList").Value.BlobValue.ToByteArray().Skip(6).ToArray<byte>()));
					string string2 = Encoding.UTF8.GetString(D2RBGS.WoWDecompress(clientResponse3.Attribute.First((Bgs.Protocol.Attribute a) => a.Name == "Param_CharacterCountList").Value.BlobValue.ToByteArray().Skip(6).ToArray<byte>()));
					wow.JamJSONRealmEntry jamJSONRealmEntry = JsonConvert.DeserializeObject<wow.JamJSONRealmEntry>(Encoding.UTF8.GetString(D2RBGS.WoWDecompress(clientResponse2.Attribute.First((Bgs.Protocol.Attribute a) => a.Name == "Param_RealmEntry").Value.BlobValue.ToByteArray().Skip(6).ToArray<byte>())).Substring("JamJSONRealmEntry:".Length));
					clientRequest = new ClientRequest();
					clientRequest.Attribute.Add(new List<Bgs.Protocol.Attribute>
					{
						new Bgs.Protocol.Attribute
						{
							Name = "Command_RealmJoinRequest_v1_b9",
							Value = new Bgs.Protocol.Variant
							{
								StringValue = "1-1-89"
							}
						},
						new Bgs.Protocol.Attribute
						{
							Name = "Param_RealmAddress",
							Value = new Bgs.Protocol.Variant
							{
								UintValue = (ulong)jamJSONRealmEntry.wowRealmAddress
							}
						},
						new Bgs.Protocol.Attribute
						{
							Name = "Param_RealmListTicket",
							Value = new Bgs.Protocol.Variant
							{
								BlobValue = attribute.Value.BlobValue
							}
						},
						new Bgs.Protocol.Attribute
						{
							Name = "Param_BnetSessionKey",
							Value = new Bgs.Protocol.Variant
							{
								BlobValue = authenticationListener.LogonResult.SessionKey
							}
						}
					});
					ClientResponse clientResponse4 = gameUtilitiesServiceClient.ProcessClientRequest(clientRequest, null, null, default(CancellationToken));
					Bgs.Protocol.Attribute attribute2 = clientResponse4.Attribute.First((Bgs.Protocol.Attribute a) => a.Name == "Param_RealmJoinTicket");
					Bgs.Protocol.Attribute attribute3 = clientResponse4.Attribute.First((Bgs.Protocol.Attribute a) => a.Name == "Param_ServerAddresses");
					Bgs.Protocol.Attribute attribute4 = clientResponse4.Attribute.First((Bgs.Protocol.Attribute a) => a.Name == "Param_JoinSecret");
					wow.JSONRealmListServerIPAddresses jsonrealmListServerIPAddresses = JsonConvert.DeserializeObject<wow.JSONRealmListServerIPAddresses>(Encoding.UTF8.GetString(D2RBGS.WoWDecompress(attribute3.Value.BlobValue.ToByteArray().Skip(6).ToArray<byte>())).Substring("JSONRealmListServerIPAddresses:".Length));
					RealmClient realmClient = new RealmClient();
					bool flag3 = realmClient.Connect(IPAddress.Parse(jsonrealmListServerIPAddresses.families[0].addresses[0].ip), bytes, attribute4.Value.BlobValue.ToByteArray(), attribute2.Value.BlobValue.ToByteArray(), 3724);
					bool flag4 = !flag3;
					if (flag4)
					{
						realmClient = new RealmClient();
						flag3 = realmClient.Connect(IPAddress.Parse(jsonrealmListServerIPAddresses.families[0].addresses[1].ip), bytes, attribute4.Value.BlobValue.ToByteArray(), attribute2.Value.BlobValue.ToByteArray(), 3724);
						bool flag5 = !flag3;
						if (flag5)
						{
							realmClient = new RealmClient();
							realmClient.Connect(IPAddress.Parse(jsonrealmListServerIPAddresses.families[0].addresses[0].ip), bytes, attribute4.Value.BlobValue.ToByteArray(), attribute2.Value.BlobValue.ToByteArray(), 3724);
						}
					}
					Console.WriteLine("fin!?!?");
					for (;;)
					{
						Thread.Sleep(1000);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("realmn log in fail : " + ex.Message);
				flag2 = false;
			}
			return flag2;
		}

		// Token: 0x0600BC2B RID: 48171 RVA: 0x00476874 File Offset: 0x00474A74
		public bool RealmD4Login()
		{
			bool flag2;
			try
			{
				bool flag = this.BgsConnection.clientWebSocket.State != WebSocketState.Open;
				if (flag)
				{
					flag2 = false;
				}
				else
				{
					Console.WriteLine("realm login");
					BattleNetSharp.AuthenticationListener authenticationListener = (BattleNetSharp.AuthenticationListener)this.BgsConnection.Listeners.Values.First((IServiceListener a) => a is BattleNetSharp.AuthenticationListener);
					Bgs.Protocol.GameUtilities.V2.Client.GameUtilitiesService.GameUtilitiesServiceClient gameUtilitiesServiceClient = new Bgs.Protocol.GameUtilities.V2.Client.GameUtilitiesService.GameUtilitiesServiceClient(this.BgsConnection);
					ProcessTaskRequest processTaskRequest = new ProcessTaskRequest();
					processTaskRequest.Attribute.Add(new List<Bgs.Protocol.V2.Attribute>
					{
						new Bgs.Protocol.V2.Attribute
						{
							Name = "fenris_message_id",
							Value = new Bgs.Protocol.V2.Variant
							{
								UintValue = 4UL
							}
						}
					});
					ProcessTaskResponse processTaskResponse = gameUtilitiesServiceClient.ProcessTask(processTaskRequest, null, null, default(CancellationToken));
					ProcessTaskRequest processTaskRequest2 = new ProcessTaskRequest();
					processTaskRequest2.Attribute.Add(new List<Bgs.Protocol.V2.Attribute>
					{
						new Bgs.Protocol.V2.Attribute
						{
							Name = "fenris_message_id",
							Value = new Bgs.Protocol.V2.Variant
							{
								UintValue = 3UL
							}
						}
					});
					ProcessTaskResponse processTaskResponse2 = gameUtilitiesServiceClient.ProcessTask(processTaskRequest2, null, null, default(CancellationToken));
					string text = ProtobufDumper.Dump(Convert.FromBase64String(processTaskResponse2.Result[0].Value.BlobValue.ToBase64()), 0);
					PingConnectionInfoList pingConnectionInfoList = PingConnectionInfoList.Parser.ParseFrom(processTaskResponse2.Result.First<Bgs.Protocol.V2.Attribute>().Value.BlobValue);
					Client client = new Client();
					ProcessTaskRequest processTaskRequest3 = new ProcessTaskRequest();
					processTaskRequest3.Attribute.Add(new List<Bgs.Protocol.V2.Attribute>
					{
						new Bgs.Protocol.V2.Attribute
						{
							Name = "fenris_message_id",
							Value = new Bgs.Protocol.V2.Variant
							{
								UintValue = 0UL
							}
						},
						new Bgs.Protocol.V2.Attribute
						{
							Name = "version",
							Value = new Bgs.Protocol.V2.Variant
							{
								StringValue = this.D4Version
							}
						}
					});
					this.TimeToken = (ulong)(Stopwatch.GetTimestamp() * 100L);
					FindUserProxyRequest findUserProxyRequest = new FindUserProxyRequest
					{
						Token = this.TimeToken,
						SessionId = "00000000-0000-0000-0000-000000000000",
						ServerPool = pingConnectionInfoList.ConnectionInfos[0].ServerPool,
						ConnectedRegionId = 1U
					};
					processTaskRequest3.Payload.Add(new Bgs.Protocol.V2.Attribute
					{
						Name = "fenris_message_payload",
						Value = new Bgs.Protocol.V2.Variant
						{
							BlobValue = MessageExtensions.ToByteString(findUserProxyRequest)
						}
					});
					ProcessTaskResponse processTaskResponse3 = gameUtilitiesServiceClient.ProcessTask(processTaskRequest3, null, null, default(CancellationToken));
					NotificationListener notificationListener = (NotificationListener)this.BgsConnection.Listeners.Values.First((IServiceListener a) => a is NotificationListener);
					for (;;)
					{
						bool flag3;
						if (notificationListener.Notifications.Count != 0)
						{
							flag3 = !notificationListener.Notifications.Any((NotificationReceivedNotification n) => n.Notifications[0].Attribute.Count > 0 && n.Notifications[0].Attribute[0].Value.IntValue == 0L);
						}
						else
						{
							flag3 = true;
						}
						if (!flag3)
						{
							break;
						}
						Thread.Sleep(100);
					}
					RepeatedField<Bgs.Protocol.V2.Attribute> attribute = notificationListener.Notifications.First((NotificationReceivedNotification n) => n.Notifications[0].Attribute.Count > 0 && n.Notifications[0].Attribute[0].Value.IntValue == 0L).Notifications[0].Attribute;
					FindUserProxyResponse findUserProxyResponse = FindUserProxyResponse.Parser.ParseFrom(attribute[1].Value.BlobValue);
					Client client2 = new Client();
					client2.Init(this, (ulong)findUserProxyResponse.ConnectInfo.Player[0].GameAccountId, findUserProxyResponse.ConnectInfo.Address, (int)findUserProxyResponse.ConnectInfo.Port, findUserProxyResponse.ConnectInfo.Player[0].AuthToken, findUserProxyResponse.ConnectInfo.Player[0].EncryptionInfo.Token, findUserProxyResponse.ConnectInfo.Player[0].EncryptionInfo.PresharedKey.Modulus.ToByteArray().Reverse<byte>().ToArray<byte>(), findUserProxyResponse.ConnectInfo.Player[0].EncryptionInfo.PresharedKey.Exponent.ToByteArray().Reverse<byte>().ToArray<byte>());
					client2.Connect(Client.ClientType.Lobby);
					flag2 = true;
				}
			}
			catch
			{
				Console.WriteLine("realmn log in fail");
				flag2 = false;
			}
			return flag2;
		}

		// Token: 0x0600BC2C RID: 48172 RVA: 0x00476D24 File Offset: 0x00474F24
		public int Str2Int2(string s)
		{
			return BitConverter.ToInt32(Encoding.UTF8.GetBytes(s).Reverse<byte>().Concat((from b in Enumerable.Range(0, 4 - s.Length)
				select (byte)b).ToArray<byte>())
				.ToArray<byte>());
		}

		// Token: 0x0600BC2D RID: 48173 RVA: 0x00476D94 File Offset: 0x00474F94
		public uint Str2UInt2(string s)
		{
			return BitConverter.ToUInt32(Encoding.UTF8.GetBytes(s).Reverse<byte>().Concat((from b in Enumerable.Range(0, 4 - s.Length)
				select (byte)b).ToArray<byte>())
				.ToArray<byte>());
		}

		// Token: 0x0600BC2E RID: 48174 RVA: 0x00476E04 File Offset: 0x00475004
		public bool RealmD2RLogin()
		{
			bool flag = this.BgsConnection.clientWebSocket.State != WebSocketState.Open;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				Bgs.Protocol.GameUtilities.V2.Client.GameUtilitiesService.GameUtilitiesServiceClient gameUtilitiesServiceClient = new Bgs.Protocol.GameUtilities.V2.Client.GameUtilitiesService.GameUtilitiesServiceClient(this.BgsConnection);
				ProcessTaskRequest processTaskRequest = new ProcessTaskRequest();
				processTaskRequest.Attribute.Add(new List<Bgs.Protocol.V2.Attribute>
				{
					new Bgs.Protocol.V2.Attribute
					{
						Name = "server_instance",
						Value = new Bgs.Protocol.V2.Variant
						{
							StringValue = "Release"
						}
					},
					new Bgs.Protocol.V2.Attribute
					{
						Name = "client_request",
						Value = new Bgs.Protocol.V2.Variant
						{
							StringValue = "classic.protocol.v1.d2r_connection.LoginRequest"
						}
					}
				});
				LoginRequest loginRequest = new LoginRequest
				{
					Program = BitConverter.ToInt32(Encoding.UTF8.GetBytes("OSI").Reverse<byte>().Concat(new byte[1])
						.ToArray<byte>()),
					Version = "1.15.0." + this.D2Version.ToString(),
					Platform = BitConverter.ToInt32(Encoding.UTF8.GetBytes("Wn64").Reverse<byte>().ToArray<byte>())
				};
				processTaskRequest.Payload.Add(new Bgs.Protocol.V2.Attribute
				{
					Name = "protobuf_request",
					Value = new Bgs.Protocol.V2.Variant
					{
						BlobValue = MessageExtensions.ToByteString(loginRequest)
					}
				});
				ProcessTaskResponse processTaskResponse = gameUtilitiesServiceClient.ProcessTask(processTaskRequest, null, null, default(CancellationToken));
				bool flag3 = processTaskResponse == null || processTaskResponse.Result.Count == 0;
				if (flag3)
				{
					flag2 = false;
				}
				else
				{
					Bgs.Protocol.V2.Attribute attribute = processTaskResponse.Result.Last<Bgs.Protocol.V2.Attribute>();
					LoginResponse loginResponse = (this.LoginResponse = LoginResponse.Parser.ParseFrom(Encoding.UTF8.GetBytes(attribute.Value.StringValue)));
					BattleNetSharp.AuthenticationListener authenticationListener = (BattleNetSharp.AuthenticationListener)this.BgsConnection.Listeners.Values.First((IServiceListener a) => a is BattleNetSharp.AuthenticationListener);
					ClientWebSocket clientWebSocket = new ClientWebSocket();
					clientWebSocket.Options.KeepAliveInterval = new TimeSpan(0, 0, 21);
					clientWebSocket.Options.RemoteCertificateValidationCallback = new RemoteCertificateValidationCallback(D2RBGS.ValidateServerCertificate);
					try
					{
						clientWebSocket.ConnectAsync(new Uri(this.LoginResponse.Url + "OSI/v2/rpc/client"), new CancellationTokenSource(5000).Token).Wait();
					}
					catch
					{
						Console.WriteLine("couldn't connect to realm rpc timeout");
						return false;
					}
					Channel channel = new Channel(this.LoginResponse.Url, 443, new SslCredentials());
					this.RealmConnection = new RealmWebSocket(channel, clientWebSocket, this.Tag);
					this.RealmConnection.RecvLoop();
					D2rServicesConnection.D2rServicesConnectionClient d2rServicesConnectionClient = new D2rServicesConnection.D2rServicesConnectionClient(this.RealmConnection);
					GameVersion.GameVersionClient gameVersionClient = new GameVersion.GameVersionClient(this.RealmConnection);
					AuthSessionResponse authSessionResponse = d2rServicesConnectionClient.AuthSession(new AuthSessionRequest
					{
						SessionKey = this.LoginResponse.Key,
						Body = new AuthBody
						{
							SessionKey = ByteString.CopyFromUtf8(this.LoginToken),
							Zero = 0,
							Platform = 1466840628,
							Entity = new Entity
							{
								AccoundIdHigh = authenticationListener.LogonResult.AccountId.High,
								AccoundIdLow = authenticationListener.LogonResult.AccountId.Low,
								GameAccountIdHigh = authenticationListener.LogonResult.GameAccountId[0].High,
								GameAccountIdLow = authenticationListener.LogonResult.GameAccountId[0].Low
							},
							Zero2 = 0
						},
						Program = 5198665U,
						Version = "1.6." + this.D2Version.ToString(),
						BaseKey = "Xd0T6OUZ2BERaIu2Tl9xHfW35hE=",
						Thirty100 = 196864U,
						Platform = 1466840628U,
						One = 1U,
						Unk3 = "",
						Unk4 = ""
					}, null, null, default(CancellationToken));
					gameVersionClient.SetGameVersion(new GameVersionRequest
					{
						Version = "1.6." + this.D2Version.ToString()
					}, null, null, default(CancellationToken));
					bool flag4 = gameVersionClient == null;
					if (flag4)
					{
                        Classic.Protocol.V1.Network.Network.NetworkClient networkClient = new Classic.Protocol.V1.Network.Network.NetworkClient(this.RealmConnection);
						GameManagement.GameManagementClient gameManagementClient = new GameManagement.GameManagementClient(this.RealmConnection);
						GameGetSitePingListResponse gameGetSitePingListResponse = gameManagementClient.GameGetSitePingList(new NoData(), null, null, default(CancellationToken));
						foreach (GameSite gameSite in gameGetSitePingListResponse.GameSite)
						{
							Console.WriteLine(gameSite.Region + " : " + gameSite.IpAddress);
							uint id = this.ReadCharacters()[0].Id;
							List<GameInfo> games = this.GetGames(id, gameSite.Region, 2U, 80U);
							Console.WriteLine(gameSite.Region + " : " + gameSite.IpAddress);
						}
					}
					flag2 = true;
				}
			}
			return flag2;
		}

		// Token: 0x0600BC2F RID: 48175 RVA: 0x004773A4 File Offset: 0x004755A4
		public List<GameSite> GetSubregions()
		{
			GameManagement.GameManagementClient gameManagementClient = new GameManagement.GameManagementClient(this.RealmConnection);
			return gameManagementClient.GameGetSitePingList(new NoData(), null, null, default(CancellationToken)).GameSite.ToList<GameSite>();
		}

		// Token: 0x0600BC30 RID: 48176 RVA: 0x004773EC File Offset: 0x004755EC
		public List<CharData> ReadCharacters()
		{
			Character.CharacterClient characterClient = new Character.CharacterClient(this.RealmConnection);
			ReadCharacterResponse readCharacterResponse = characterClient.ReadCharacter(new NoData(), null, null, default(CancellationToken));
			List<CharData> list;
			if (readCharacterResponse == null)
			{
				list = null;
			}
			else
			{
				RepeatedField<CharData> characters = readCharacterResponse.Characters;
				list = ((characters != null) ? characters.ToList<CharData>() : null);
			}
			return list ?? new List<CharData>();
		}

		// Token: 0x0600BC31 RID: 48177 RVA: 0x0047744C File Offset: 0x0047564C
		public List<GameInfo> GetGames(uint id, string region, uint difficulty, uint level)
		{
			Console.WriteLine("getting games");
			bool flag = this.RealmConnection.clientWebSocket.State != WebSocketState.Open;
			if (flag)
			{
				this.RealmLoginLocked(true);
			}
			GameManagement.GameManagementClient gameManagementClient = new GameManagement.GameManagementClient(this.RealmConnection);
			GameListResponse gameListResponse = gameManagementClient.GameList(new GameListRequest
			{
				CharId = id,
				Unkzero = 0U,
				Emptystring = "",
				Level = level,
				X0 = 0U,
				Difficulty = difficulty,
				XF28 = 40U,
				Region = region
			}, null, null, default(CancellationToken));
			return gameListResponse.Games.ToList<GameInfo>();
		}

		// Token: 0x0600BC32 RID: 48178 RVA: 0x0047750C File Offset: 0x0047570C
		public CharacterResponse DeleteCharacter(uint id)
		{
			Character.CharacterClient characterClient = new Character.CharacterClient(this.RealmConnection);
			return characterClient.DeleteCharacter(new DeleteCharacterRequest
			{
				Id = id,
				Unk0 = 0
			}, null, null, default(CancellationToken));
		}

		// Token: 0x0600BC33 RID: 48179 RVA: 0x0047755C File Offset: 0x0047575C
		public GetRanksByPositionRangeResponse DumpLeaderboard3(int season, uint start, uint end)
		{
			LeaderboardService.LeaderboardServiceClient leaderboardServiceClient = new LeaderboardService.LeaderboardServiceClient(this.BgsConnection);
			return leaderboardServiceClient.GetRanksByPositionRange(new GetRanksByPositionRangeRequest
			{
				LeaderboardId = "4613486-gametype+leaderboards-xp1~gamemode-standardhardcore.platform-pc",
				StartPosition = (ulong)start,
				EndPosition = (ulong)end
			}, null, null, default(CancellationToken));
		}

		// Token: 0x0600BC34 RID: 48180 RVA: 0x004775BC File Offset: 0x004757BC
		public GetRanksByPositionRangeResponse DumpLeaderboard2(int season, uint start, uint end)
		{
			LeaderboardService.LeaderboardServiceClient leaderboardServiceClient = new LeaderboardService.LeaderboardServiceClient(this.BgsConnection);
			GetRanksByPositionResponse ranksByPosition = leaderboardServiceClient.GetRanksByPosition(new GetRanksByPositionRequest(), null, null, default(CancellationToken));
			return leaderboardServiceClient.GetRanksByPositionRange(new GetRanksByPositionRangeRequest
			{
				LeaderboardId = "5198665-gametype+leaderboards-xp1~gamemode-standardhardcore.platform-pc.seasonid-" + season.ToString(),
				StartPosition = (ulong)start,
				EndPosition = (ulong)end
			}, null, null, default(CancellationToken));
		}

		// Token: 0x0600BC35 RID: 48181 RVA: 0x00477648 File Offset: 0x00475848
		public GetRanksByPositionRangeResponse DumpLeaderboard(uint start, uint end)
		{
			LeaderboardService.LeaderboardServiceClient leaderboardServiceClient = new LeaderboardService.LeaderboardServiceClient(this.BgsConnection);
			return leaderboardServiceClient.GetRanksByPositionRange(new GetRanksByPositionRangeRequest
			{
				LeaderboardId = "5198665-gametype+leaderboards-xp~gamemode-expansion.platform-pc.seasonid-1",
				StartPosition = (ulong)start,
				EndPosition = (ulong)end
			}, null, null, default(CancellationToken));
		}

		// Token: 0x0600BC36 RID: 48182 RVA: 0x004776A8 File Offset: 0x004758A8
		public CharacterResponse CreateCharacter(string name, CharacterClass characterClass)
		{
			Character.CharacterClient characterClient = new Character.CharacterClient(this.RealmConnection);
			return characterClient.CreateCharacter(new CreateCharacterRequest
			{
				Class = (int)characterClass,
				Name = name,
				FlagsHcLadder = 96
			}, null, null, default(CancellationToken));
		}

		// Token: 0x0600BC37 RID: 48183 RVA: 0x00477704 File Offset: 0x00475904
		public GameListResponse GameList()
		{
			GameManagement.GameManagementClient gameManagementClient = new GameManagement.GameManagementClient(this.RealmConnection);
			GameListRequest gameListRequest = new GameListRequest
			{
				CharId = 63930328U,
				Unkzero = 0U,
				Emptystring = "",
				XF28 = 3944U,
				Level = 83U,
				Region = "USW1",
				Difficulty = 2U,
				X0 = 0U
			};
			return gameManagementClient.GameList(gameListRequest, null, null, default(CancellationToken));
		}

		// Token: 0x0600BC38 RID: 48184 RVA: 0x00477798 File Offset: 0x00475998
		public GameJoinResponse JoinGame(string gameName, string password, uint charId, uint charLevel, string region = "")
		{
			bool flag = this.RealmConnection.clientWebSocket.State != WebSocketState.Open;
			if (flag)
			{
				this.RealmLoginLocked(true);
			}
			GameManagement.GameManagementClient gameManagementClient = new GameManagement.GameManagementClient(this.RealmConnection);
			GameJoinRequest gameJoinRequest = new GameJoinRequest
			{
				GameName = gameName.ToLower(),
				GamePassword = password.ToLower(),
				CharId = charId,
				CharLevel = charLevel
			};
			gameJoinRequest.Region = region;
			GameJoinResponse gameJoinResponse = gameManagementClient.GameJoin(gameJoinRequest, null, null, default(CancellationToken));
			this.RealmConnection.clientWebSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, null, default(CancellationToken));
			return gameJoinResponse;
		}

		// Token: 0x0600BC39 RID: 48185 RVA: 0x00477854 File Offset: 0x00475A54
		public bool CreateGame(string gameName, string password, uint charId, uint difficulty, uint level, bool doCreate, string prefRegion)
		{
			bool flag = this.RealmConnection.clientWebSocket.State != WebSocketState.Open;
			if (flag)
			{
				this.RealmLoginLocked(true);
			}
			GameManagement.GameManagementClient gameManagementClient = new GameManagement.GameManagementClient(this.RealmConnection);
			uint num = 7471104U;
			bool flag2 = difficulty == 1U;
			if (flag2)
			{
				num = 7475200U;
			}
			bool flag3 = difficulty == 2U;
			if (flag3)
			{
				num = 7479296U;
			}
			GameCreateRequest gameCreateRequest = new GameCreateRequest
			{
				CharId = charId,
				GameName = gameName.ToLower(),
				GamePassword = password.ToLower(),
				Empty = "",
				LevelDifference = 255U,
				MaxPlayers = 8U,
				Flags = num,
				Unk1 = "",
				Unk2 = "",
				Difficulty = 0U
			};
			gameCreateRequest.Pings.Add(new GameServerPing
			{
				Region = "USW2",
				Value = 132U
			});
			gameCreateRequest.Pings.Add(new GameServerPing
			{
				Region = "USW1",
				Value = 19U
			});
			gameCreateRequest.Pings.Add(new GameServerPing
			{
				Region = prefRegion,
				Value = 19U
			});
			GameCreateResponse gameCreateResponse = gameManagementClient.GameCreate(gameCreateRequest, null, null, default(CancellationToken));
			return gameCreateResponse != null && gameCreateResponse.Id > 0U;
		}

		// Token: 0x0600BC3A RID: 48186 RVA: 0x004779D0 File Offset: 0x00475BD0
		public static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return true;
		}

		// Token: 0x0600BC3B RID: 48187 RVA: 0x004779E4 File Offset: 0x00475BE4
		public void Close()
		{
			RealmWebSocket realmConnection = this.RealmConnection;
			bool flag = realmConnection != null && realmConnection.clientWebSocket.State == WebSocketState.Open;
			if (flag)
			{
				RealmWebSocket realmConnection2 = this.RealmConnection;
				if (realmConnection2 != null)
				{
					realmConnection2.clientWebSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, null, default(CancellationToken));
				}
			}
			gRPCWebSocket bgsConnection = this.BgsConnection;
			bool flag2 = bgsConnection != null && bgsConnection.clientWebSocket.State == WebSocketState.Open;
			if (flag2)
			{
				gRPCWebSocket bgsConnection2 = this.BgsConnection;
				if (bgsConnection2 != null)
				{
					bgsConnection2.clientWebSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, null, default(CancellationToken));
				}
			}
		}

		// Token: 0x040090FF RID: 37119
		public static bool logging = true;

		// Token: 0x04009100 RID: 37120
		public static ConcurrentDictionary<Guid, D2RBGS> BGSConnections = new ConcurrentDictionary<Guid, D2RBGS>();

		// Token: 0x04009101 RID: 37121
		public uint AccountLow = 1U;

		// Token: 0x04009102 RID: 37122
		public ulong AccountHigh = 72057594037927936UL;

		// Token: 0x04009103 RID: 37123
		public ulong GameAccountHigh = 144115600397329774UL;

		// Token: 0x04009104 RID: 37124
		public uint bgsToken = 1U;

		// Token: 0x04009105 RID: 37125
		public uint realmToken = 1U;

		// Token: 0x04009106 RID: 37126
		public int D2Version = 74264;

		// Token: 0x04009107 RID: 37127
		public string D4Version = "1.1.x.41925";

		// Token: 0x04009108 RID: 37128
		public int wowVersion = 48069;

		// Token: 0x04009109 RID: 37129
		public IWebSocketConnection bgsWsConnection;

		// Token: 0x0400910A RID: 37130
		public IWebSocketConnection realmWsConnection;

		// Token: 0x0400910B RID: 37131
		public string ClientId = "A0CAE542608784BD-00000000001E8692";

		// Token: 0x0400910C RID: 37132
		public byte[] SessionKey;

		// Token: 0x0400910D RID: 37133
		public Dictionary<uint, IServiceListener> Listeners = new Dictionary<uint, IServiceListener>();

		// Token: 0x0400910E RID: 37134
		public Dictionary<uint, Tuple<uint, uint>> TokenToService = new Dictionary<uint, Tuple<uint, uint>>();

		// Token: 0x0400910F RID: 37135
		public Dictionary<uint, uint> ProcessTaskId = new Dictionary<uint, uint>();

		// Token: 0x04009110 RID: 37136
		private ClientWebSocket bgsWs = new ClientWebSocket();

		// Token: 0x04009111 RID: 37137
		public ulong lastMessageReq = 10UL;

		// Token: 0x04009112 RID: 37138
		public static List<string> test23 = new List<string>
		{
			"classic.protocol.Empty", "classic.protocol.ErrorInfo", "classic.protocol.Header", "classic.protocol.ProcessId", "classic.protocol.external.v1.character.Character", "classic.protocol.external.v1.character.CharacterSummary", "classic.protocol.external.v1.character.ConvertCharacterRequest", "classic.protocol.external.v1.character.ConvertCharacterResponse", "classic.protocol.external.v1.character.CreateCharacterRequest", "classic.protocol.external.v1.character.CreateCharacterResponse",
			"classic.protocol.external.v1.character.DeleteCharacterRequest", "classic.protocol.external.v1.character.DeleteCharacterResponse", "classic.protocol.external.v1.character.ReadCharacterListRequest", "classic.protocol.external.v1.character.ReadCharacterListResponse", "classic.protocol.external.v1.character.UseCharacterRequest", "classic.protocol.external.v1.character.UseCharacterResponse", "classic.protocol.external.v1.cs_report.CsReport", "classic.protocol.external.v1.cs_report.ReportPlayerRequest", "classic.protocol.external.v1.game_management.GameAttribute", "classic.protocol.external.v1.game_management.GameCreateCancelRequest",
			"classic.protocol.external.v1.game_management.GameCreateQueueTimeRequest", "classic.protocol.external.v1.game_management.GameCreateQueueTimeResponse", "classic.protocol.external.v1.game_management.GameCreateRequest", "classic.protocol.external.v1.game_management.GameCreateResponse", "classic.protocol.external.v1.game_management.GameDetailPlayer", "classic.protocol.external.v1.game_management.GameDetailRequest", "classic.protocol.external.v1.game_management.GameDetailResponse", "classic.protocol.external.v1.game_management.GameJoinRequest", "classic.protocol.external.v1.game_management.GameJoinResponse", "classic.protocol.external.v1.game_management.GameListInfo",
			"classic.protocol.external.v1.game_management.GameListRequest", "classic.protocol.external.v1.game_management.GameListResponse", "classic.protocol.external.v1.game_management.GameManagement", "classic.protocol.external.v1.game_management.GameMatchmakeRequest", "classic.protocol.external.v1.game_management.GameMatchmakeResponse", "classic.protocol.external.v1.game_management.GameSiteLatency", "classic.protocol.external.v1.game_management.GameSitePingListResponse", "classic.protocol.external.v1.game_management.PingTargetRecord", "classic.protocol.external.v1.gem_ticket.GemTicket", "classic.protocol.external.v1.gem_ticket.GemTicketRequest",
			"classic.protocol.external.v1.gem_ticket.GemTicketResponse", "classic.protocol.local.Empty", "classic.protocol.local.Header", "classic.protocol.local.v1.chat.Chat", "classic.protocol.local.v1.chat.ChatMessage", "classic.protocol.local.v1.player.Attribute", "classic.protocol.local.v1.player.Attributes", "classic.protocol.local.v1.player.GameInfo", "classic.protocol.local.v1.player.LobbyInfo", "classic.protocol.local.v1.player.PlayerInfo",
			"classic.protocol.local.v1.upnp.UPNPAttribute", "classic.protocol.local.v1.upnp.UPNPService", "classic.protocol.v1.d2r_connection.AuroraAccountInfo", "classic.protocol.v1.d2r_connection.AuthSessionRequest", "classic.protocol.v1.d2r_connection.AuthSessionResponse", "classic.protocol.v1.d2r_connection.ClientPing", "classic.protocol.v1.d2r_connection.CookieUpdateRequest", "classic.protocol.v1.d2r_connection.D2rServicesConnection", "classic.protocol.v1.d2r_connection.LoginRequest", "classic.protocol.v1.d2r_connection.LoginResponse",
			"classic.protocol.v1.d2r_connection.OfflineCookie", "classic.protocol.v1.d2r_connection.OfflineCookies", "classic.protocol.v1.d2r_connection.OnlineStats", "classic.protocol.v1.d2r_connection.ServerPingRequest", "classic.protocol.v1.d2r_connection.ServerPingResponse", "classic.protocol.v1.d2r_connection.SessionDestroyedRequest", "classic.protocol.v1.d2r_connection.SessionInfo", "classic.protocol.v1.d2r_connection.SessionUpdateRequest", "classic.protocol.v1.game_proxy.AddressInfo", "classic.protocol.v1.game_proxy.DelClientRequest",
			"classic.protocol.v1.game_proxy.DisconnectClientRequest", "classic.protocol.v1.game_proxy.EchoPacket", "classic.protocol.v1.game_proxy.NatPacket", "classic.protocol.v1.game_proxy.NewClientRequest", "classic.protocol.v1.game_proxy.Packet", "classic.protocol.v1.game_proxy.UDPPacket", "classic.protocol.v1.game_version.GameUpdateRequest", "classic.protocol.v1.game_version.GameVersion", "classic.protocol.v1.game_version.SetGameVersionRequest", "classic.protocol.v1.igr.CreateAuroraAccountRequest",
			"classic.protocol.v1.igr.CreateAuroraAccountResponse", "classic.protocol.v1.igr.IGR", "classic.protocol.v1.lobby.ChatMessageRecvRequest", "classic.protocol.v1.lobby.CreateRequest", "classic.protocol.v1.lobby.CreateResponse", "classic.protocol.v1.lobby.GenericRequest", "classic.protocol.v1.lobby.InviteRequest", "classic.protocol.v1.lobby.InviteResponse", "classic.protocol.v1.lobby.KickFromLobbyRequest", "classic.protocol.v1.lobby.Lobby",
			"classic.protocol.v1.lobby.LobbyAttribute", "classic.protocol.v1.lobby.LobbyInfo", "classic.protocol.v1.lobby.LobbyMember", "classic.protocol.v1.lobby.NewInviteRequest", "classic.protocol.v1.lobby.PromoteToLeaderRequest", "classic.protocol.v1.lobby.PromotedToLeaderRequest", "classic.protocol.v1.lobby.RejectInviteRequest", "classic.protocol.v1.lobby.SendChatMessageRequest", "classic.protocol.v1.lobby.SetLobbyMetaRequest", "classic.protocol.v1.lobby.SetSelfMetaRequest",
			"classic.protocol.v1.lobby.ToonInfo", "classic.protocol.v1.network.EchoServerInfo", "classic.protocol.v1.network.EchoServerListResponse", "classic.protocol.v1.network.Network", "classic.protocol.v1.network.SendUDPRequest", "classic.protocol.v1.network.SendUDPResponse", "classic.protocol.v1.network.UDPTestRequest", "classic.protocol.v1.network.UDPTestResponse", "classic.protocol.v1.setting.ApplySettingRequest", "classic.protocol.v1.setting.PushSettingRequest",
			"classic.protocol.v1.setting.Setting", "classic.protocol.v1.stats.GetAuroraProfileByToonRequest", "classic.protocol.v1.stats.GetStatResponse", "classic.protocol.v1.stats.PushStatRequest", "classic.protocol.v1.stats.Stats", "classic.protocol.v1.warden.PacketRequest", "classic.protocol.v1.warden.Warden3", "classic.protocol.v1.webapi.Attribute", "classic.protocol.v1.webapi.WebApi", "classic.protocol.v1.webapi.WebApiRequest",
			"classic.protocol.v1.webapi.WebApiResponse"
		};

		// Token: 0x04009113 RID: 37139
		public gRPCWebSocket BgsConnection;

		// Token: 0x04009114 RID: 37140
		public RealmWebSocket RealmConnection;

		// Token: 0x04009115 RID: 37141
		public string LoginToken;

		// Token: 0x04009116 RID: 37142
		public string Tag;

		// Token: 0x04009117 RID: 37143
		private static object ddosLock = new object();

		// Token: 0x04009118 RID: 37144
		public LoginResponse LoginResponse;

		// Token: 0x04009119 RID: 37145
		private object realmDdosLock = new object();

		// Token: 0x0400911A RID: 37146
		public ulong TimeToken;

		// Token: 0x0400911B RID: 37147
		public uint GameId;

		// Token: 0x02001395 RID: 5013
		public enum App
		{
			// Token: 0x04009F7A RID: 40826
			D2R,
			// Token: 0x04009F7B RID: 40827
			D4,
			// Token: 0x04009F7C RID: 40828
			WoW,
			// Token: 0x04009F7D RID: 40829
			wowdev
		}
	}
}
