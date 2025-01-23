using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.GameUtilities.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;
using Newtonsoft.Json;

namespace BattleNetSharp
{
	// Token: 0x02000ACD RID: 2765
	public class gRPCWebSocket : DefaultCallInvoker
	{
		// Token: 0x0600BC4C RID: 48204 RVA: 0x0047925C File Offset: 0x0047745C
		public gRPCWebSocket(Channel channel, ClientWebSocket webSocket, string tag)
			: base(channel)
		{
			this.Tag = tag;
			this.clientWebSocket = webSocket;
		}

		// Token: 0x0600BC4D RID: 48205 RVA: 0x004792C4 File Offset: 0x004774C4
		public gRPCWebSocket(Channel channel, ClientWebSocket webSocket)
			: base(channel)
		{
			this.clientWebSocket = webSocket;
		}

		// Token: 0x0600BC4E RID: 48206 RVA: 0x00479322 File Offset: 0x00477522
		public override AsyncClientStreamingCall<TRequest, TResponse> AsyncClientStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options)
		{
			throw new Exception("not implemented");
		}

		// Token: 0x0600BC4F RID: 48207 RVA: 0x0047932F File Offset: 0x0047752F
		public override AsyncDuplexStreamingCall<TRequest, TResponse> AsyncDuplexStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options)
		{
			throw new Exception("not implemented");
		}

		// Token: 0x0600BC50 RID: 48208 RVA: 0x0047933C File Offset: 0x0047753C
		public override AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
		{
			throw new Exception("not implemented");
		}

		// Token: 0x0600BC51 RID: 48209 RVA: 0x00479349 File Offset: 0x00477549
		public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
		{
			throw new Exception("not implemented");
		}

		// Token: 0x0600BC52 RID: 48210 RVA: 0x00479358 File Offset: 0x00477558
		public override TResponse BlockingUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
		{
			Header header = new Header();
			header.ServiceId = 0U;
			Header header2 = header;
			uint num = this.token;
			this.token = num + 1U;
			header2.Token = num;
			Type type = Type.GetType(method.ServiceName.Replace("_", ""), false, true);
			bool flag = this.logging;
			if (flag)
			{
				Console.WriteLine("bgs c2s " + type.FullName + " : " + method.Name);
			}
			bool flag2 = this.logging;
			if (flag2)
			{
				Console.WriteLine(request.ToString());
			}
			ServiceDescriptor serviceDescriptor = (ServiceDescriptor)type.GetProperty("Descriptor").GetValue(null);
			BGSServiceOptions extension = serviceDescriptor.GetOptions().GetExtension<BGSServiceOptions>(ServiceOptionsExtensions.ServiceOptions_);
			string text = extension.DescriptorName;
			bool flag3 = text == "bnet.protocol.leaderboard.v1.client.LeaderboardService";
			if (flag3)
			{
				text = "bnet.protocol.leaderboard.v1.server.LeaderboardService";
			}
			uint num2 = BitConverter.ToUInt32(new FNV1A32().ComputeHash(Encoding.UTF8.GetBytes(text)));
			header.ServiceHash = num2;
			MethodDescriptor methodDescriptor = serviceDescriptor.FindMethodByName(method.Name);
			header.MethodId = methodDescriptor.GetOptions().GetExtension<BGSMethodOptions>(MethodOptionsExtensions.MethodOptions_).Id;
			byte[] array = MessageExtensions.ToByteArray(header);
			byte[] array2 = MessageExtensions.ToByteArray((IMessage)((object)request));
			List<byte> list = BitConverter.GetBytes((ushort)array.Length).Reverse<byte>().ToList<byte>();
			list.AddRange(array);
			list.AddRange(array2);
			try
			{
				this.clientWebSocket.SendAsync(list.ToArray(), WebSocketMessageType.Binary, true, CancellationToken.None).Wait();
			}
			catch
			{
				Console.WriteLine("grpc websocket 1");
			}
			bool flag4 = typeof(TResponse) == typeof(NO_RESPONSE);
			TResponse tresponse;
			if (flag4)
			{
				tresponse = default(TResponse);
			}
			else
			{
				IMessage message = (IMessage)Activator.CreateInstance(typeof(TResponse));
				try
				{
					gRPCWebSocket.BgsPacket bgsPacket;
					bool flag5 = this.RpcMessages.TryTake(out bgsPacket, 100000, this.cts.Token);
					if (flag5)
					{
						bool flag6 = bgsPacket.Header.Token != header.Token;
						if (flag6)
						{
							bool flag7 = this.RpcMessages.TryTake(out bgsPacket, 10000, this.cts.Token);
							if (flag7)
							{
							}
						}
						string text2 = ProtobufDumper.Dump(bgsPacket.Payload, 0);
						MessageExtensions.MergeFrom(message, bgsPacket.Payload);
						bool flag8 = this.logging;
						if (flag8)
						{
							string[] array3 = new string[6];
							array3[0] = "bgs s2c response to ";
							array3[1] = type.FullName;
							array3[2] = " : ";
							array3[3] = method.Name;
							array3[4] = " : type is : ";
							int num3 = 5;
							Type typeFromHandle = typeof(TResponse);
							array3[num3] = ((typeFromHandle != null) ? typeFromHandle.ToString() : null);
							Console.WriteLine(string.Concat(array3));
						}
						bool flag9 = this.logging;
						if (flag9)
						{
							Console.WriteLine(message.ToString());
						}
						return (TResponse)((object)message);
					}
				}
				catch (InvalidProtocolBufferException ex)
				{
					Console.WriteLine("rpc protobuf err : " + ex.Message);
				}
				catch (TaskCanceledException ex2)
				{
					Console.WriteLine("rpc reponse fail : " + ex2.Message);
				}
				catch
				{
					Console.WriteLine("grpc websocket 2");
				}
				tresponse = default(TResponse);
			}
			return tresponse;
		}

		// Token: 0x0600BC53 RID: 48211 RVA: 0x00479728 File Offset: 0x00477928
		public void HandlePacket()
		{
		}

		// Token: 0x0600BC54 RID: 48212 RVA: 0x0047972C File Offset: 0x0047792C
		public void RecvLoop()
		{
			foreach (Type type in from t in Assembly.GetExecutingAssembly().GetTypes()
				where t.GetInterface("IServiceListener") != null
				select t)
			{
				IServiceListener serviceListener = (IServiceListener)Activator.CreateInstance(type);
				this.Listeners.Add(serviceListener.Hash, serviceListener);
			}
			Task.Run(delegate
			{
				Dictionary<uint, IServiceListener> listeners = this.Listeners;
				while (this.Running && this.clientWebSocket.State == WebSocketState.Open)
				{
					byte[] array = new byte[65536];
					WebSocketReceiveResult result = this.clientWebSocket.ReceiveAsync(array, CancellationToken.None).Result;
					WebSocketCloseStatus? closeStatus = result.CloseStatus;
					WebSocketCloseStatus webSocketCloseStatus = WebSocketCloseStatus.NormalClosure;
					bool flag = (closeStatus.GetValueOrDefault() == webSocketCloseStatus) & (closeStatus != null);
					if (flag)
					{
						this.cts.Cancel();
						break;
					}
					ushort num = BitConverter.ToUInt16(array.Take(2).Reverse<byte>().ToArray<byte>(), 0);
					Header recvHeader = new Header();
					MessageExtensions.MergeFrom(recvHeader, array.Skip(2).Take((int)num).ToArray<byte>());
					bool flag2 = (long)(result.Count - 2 - (int)num) != (long)((ulong)recvHeader.Size);
					if (flag2)
					{
						Console.WriteLine("rawr");
					}
					bool flag3 = recvHeader.ServiceId == 254U;
					if (flag3)
					{
						byte[] array2 = array.Skip(2).Skip((int)num).Take(result.Count - 2 - (int)num)
							.ToArray<byte>();
						bool flag4 = recvHeader.Status > 0U;
						if (flag4)
						{
							Console.WriteLine(recvHeader.Status.ToString() + " : RECV FAIL ERROR");
						}
						this.RpcMessages.Add(new gRPCWebSocket.BgsPacket
						{
							Header = recvHeader,
							Payload = array2
						});
					}
					else
					{
						this.ClientId = recvHeader.ClientId;
						bool flag5 = this.Listeners.ContainsKey(recvHeader.ServiceHash);
						if (flag5)
						{
							IServiceListener serviceListener2 = this.Listeners[recvHeader.ServiceHash];
							string text;
							IMessage packet = serviceListener2.GetPacket(recvHeader.MethodId, array.Skip(2).Skip((int)num).Take(result.Count - 2 - (int)num)
								.ToArray<byte>(), out text);
							bool flag6 = this.logging;
							if (flag6)
							{
								string[] array3 = new string[6];
								array3[0] = "some listerner: ";
								array3[1] = serviceListener2.GetType().Name;
								array3[2] = " : ";
								array3[3] = text;
								array3[4] = " : ";
								int num2 = 5;
								IMessage message = packet;
								array3[num2] = ((message != null) ? message.ToString() : null);
								Console.WriteLine(string.Concat(array3));
							}
							IMessage message2 = serviceListener2.Invoke(recvHeader.MethodId, array.Skip(2).Skip((int)num).Take(result.Count - 2 - (int)num)
								.ToArray<byte>(), null);
							bool flag7 = message2 is NO_RESPONSE;
							if (!flag7)
							{
								byte[] array4 = MessageExtensions.ToByteArray(message2);
								byte[] array5 = MessageExtensions.ToByteArray(new Header
								{
									ServiceId = 254U,
									Token = recvHeader.Token,
									Status = 0U,
									Size = (uint)array4.Length
								});
								List<byte> list = BitConverter.GetBytes((ushort)array5.Length).Reverse<byte>().ToList<byte>();
								list.AddRange(array5);
								list.AddRange(array4);
								this.clientWebSocket.SendAsync(list.ToArray(), WebSocketMessageType.Binary, true, CancellationToken.None).Wait();
							}
						}
						else
						{
							bool flag8 = recvHeader.ServiceHash > 0U;
							if (flag8)
							{
								Type type2 = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault((Type t) => t.Name.EndsWith("Service") && t.Namespace.Contains("Bgs") && gRPCWebSocket.ServiceHash(t, false) == recvHeader.ServiceHash);
								ServiceDescriptor serviceDescriptor = (ServiceDescriptor)type2.GetProperty("Descriptor").GetValue(null);
								MethodDescriptor methodDescriptor = serviceDescriptor.Methods.First((MethodDescriptor m) => m.GetOptions().GetExtension<BGSMethodOptions>(MethodOptionsExtensions.MethodOptions_).Id == recvHeader.MethodId);
								IMessage message3 = (IMessage)Activator.CreateInstance(methodDescriptor.InputType.ClrType);
								MessageExtensions.MergeFrom(message3, array.Skip(2).Skip((int)num).Take(result.Count - 2 - (int)num)
									.ToArray<byte>());
								string fullName = methodDescriptor.FullName;
								string text2 = " : ";
								Type type3 = message3.GetType();
								Console.WriteLine(fullName + text2 + ((type3 != null) ? type3.ToString() : null));
								object obj = JsonConvert.DeserializeObject(message3.ToString());
								string text3 = JsonConvert.SerializeObject(obj, Formatting.Indented);
								Console.WriteLine(text3);
							}
							else
							{
								Console.WriteLine("bgs bad grpc websocket hash");
							}
						}
					}
				}
			});
		}

		// Token: 0x0600BC55 RID: 48213 RVA: 0x004797D0 File Offset: 0x004779D0
		public T RecvPacket<T>()
		{
			byte[] array = new byte[4096];
			WebSocketReceiveResult result = this.clientWebSocket.ReceiveAsync(array, CancellationToken.None).Result;
			ushort num = BitConverter.ToUInt16(array.Take(2).Reverse<byte>().ToArray<byte>(), 0);
			Header header = new Header();
			MessageExtensions.MergeFrom(header, array.Skip(2).Take((int)num).ToArray<byte>());
			IMessage message = (IMessage)Activator.CreateInstance(typeof(T));
			MessageExtensions.MergeFrom(message, array.Skip(2).Skip((int)num).Take(result.Count - 2 - (int)num)
				.ToArray<byte>());
			return (T)((object)message);
		}

		// Token: 0x0600BC56 RID: 48214 RVA: 0x00479888 File Offset: 0x00477A88
		public static void ProcessBytes(string dir, byte[] recv)
		{
			Dictionary<uint, IServiceListener> dictionary = new Dictionary<uint, IServiceListener>();
			foreach (Type type in from t in Assembly.GetExecutingAssembly().GetTypes()
				where t.GetInterface("IServiceListener") != null
				select t)
			{
				IServiceListener serviceListener = (IServiceListener)Activator.CreateInstance(type);
				dictionary.Add(serviceListener.Hash, serviceListener);
			}
			ushort num = BitConverter.ToUInt16(recv.Take(2).Reverse<byte>().ToArray<byte>(), 0);
			bool flag = dir.Contains("rs");
			if (flag)
			{
				while (recv.Length != 0)
				{
					Header header = new Header();
					MessageExtensions.MergeFrom(header, recv.Skip(2).Take((int)num).ToArray<byte>());
					bool flag2 = !header.HasSize;
					if (flag2)
					{
						header.Size = (uint)(recv.Length - (int)num);
					}
					string text;
					IMessage message = dictionary[header.ServiceId].GetPacket(header.MethodId, recv.Skip(2).Skip((int)num).Take((int)header.Size)
						.ToArray<byte>(), out text);
					bool flag3 = dir.Contains("rs2c");
					if (flag3)
					{
						string text2;
						message = dictionary[header.ServiceId].GetResult(header.MethodId, recv.Skip(2).Skip((int)num).Take((int)header.Size)
							.ToArray<byte>(), out text2);
					}
					string text3 = text;
					string text4 = " : ";
					Type type2 = message.GetType();
					Console.WriteLine(text3 + text4 + ((type2 != null) ? type2.ToString() : null));
					Console.WriteLine(header);
					byte[] array = recv.Skip(2).Skip((int)num).Take((int)header.Size)
						.ToArray<byte>();
					string text5 = ProtobufDumper.Dump(array, 0);
					Console.WriteLine(text5);
					object obj = JsonConvert.DeserializeObject(message.ToString());
					string text6 = JsonConvert.SerializeObject(obj, Formatting.Indented);
					Console.WriteLine(text6);
					recv = recv.Take(0).ToArray<byte>();
				}
			}
			else
			{
				Header recvHeader = new Header();
				MessageExtensions.MergeFrom(recvHeader, recv.Skip(2).Take((int)num).ToArray<byte>());
				bool flag4 = !recvHeader.HasSize;
				if (flag4)
				{
					recvHeader.Size = (uint)(recv.Length - (int)num);
				}
				Console.WriteLine(recvHeader);
				bool flag5 = recvHeader.ServiceId == 254U;
				if (flag5)
				{
					byte[] array2 = recv.Skip(2).Skip((int)num).Take((int)recvHeader.Size)
						.ToArray<byte>();
					string text7 = ProtobufDumper.Dump(array2, 0);
					Console.WriteLine(text7);
					bool flag6 = text7.Contains("Param_RealmJoinTicket");
					if (flag6)
					{
						ClientResponse clientResponse = ClientResponse.Parser.ParseFrom(array2);
						Console.WriteLine("");
					}
				}
				else
				{
					Type type3 = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault((Type t) => t.GetInterface("IServiceListener") != null && gRPCWebSocket.ServiceHash(t, false) == recvHeader.ServiceHash);
					bool flag7 = type3 == null;
					object obj2;
					if (flag7)
					{
						type3 = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(delegate(Type t)
						{
							string @namespace = t.Namespace;
							return @namespace != null && @namespace.Contains("Bgs") && t.Name.EndsWith("Service") && gRPCWebSocket.ServiceHash(t, true) == recvHeader.ServiceHash;
						});
						bool flag8 = type3 == null;
						if (flag8)
						{
							return;
						}
						obj2 = type3.GetProperty("Descriptor").GetValue(null);
					}
					else
					{
						obj2 = type3.GetInterfaces()[0].GetProperty("Descriptor").GetValue(Activator.CreateInstance(type3));
					}
					MethodDescriptor methodDescriptor = ((ServiceDescriptor)obj2).Methods.First((MethodDescriptor m) => m.GetOptions().GetExtension<BGSMethodOptions>(MethodOptionsExtensions.MethodOptions_).Id == recvHeader.MethodId);
					IMessage message2 = (IMessage)Activator.CreateInstance(methodDescriptor.InputType.ClrType);
					string text8 = ProtobufDumper.Dump(recv.Skip(2).Skip((int)num).Take((int)recvHeader.Size)
						.ToArray<byte>(), 0);
					Console.WriteLine(BitConverter.ToString(recv.Skip(2).Skip((int)num).Take((int)recvHeader.Size)
						.ToArray<byte>()));
					Console.WriteLine(text8);
					MessageExtensions.MergeFrom(message2, recv.Skip(2).Skip((int)num).Take((int)recvHeader.Size)
						.ToArray<byte>());
					string fullName = methodDescriptor.FullName;
					string text9 = " : ";
					Type type4 = message2.GetType();
					Console.WriteLine(fullName + text9 + ((type4 != null) ? type4.ToString() : null));
					object obj3 = JsonConvert.DeserializeObject(message2.ToString());
					string text10 = JsonConvert.SerializeObject(obj3, Formatting.Indented);
					Console.WriteLine(text10);
				}
			}
		}

		// Token: 0x0600BC57 RID: 48215 RVA: 0x00479D4C File Offset: 0x00477F4C
		public static void DumpHashes()
		{
			IEnumerable<Type> enumerable = Assembly.GetExecutingAssembly().GetTypes().Where(delegate(Type t)
			{
				string @namespace = t.Namespace;
				return @namespace != null && @namespace.Contains("Bgs");
			});
			foreach (Type type in enumerable)
			{
				PropertyInfo property = type.GetProperty("Descriptor");
				object obj = ((property != null) ? property.GetValue(null) : null);
				bool flag = obj == null || !(obj is ServiceDescriptor);
				if (!flag)
				{
					ServiceDescriptor serviceDescriptor = (ServiceDescriptor)obj;
					BGSServiceOptions extension = serviceDescriptor.GetOptions().GetExtension<BGSServiceOptions>(ServiceOptionsExtensions.ServiceOptions_);
					uint num = BitConverter.ToUInt32(new FNV1A32().ComputeHash(Encoding.UTF8.GetBytes(extension.DescriptorName)));
					string[] array = new string[5];
					int num2 = 0;
					Type type2 = type;
					array[num2] = ((type2 != null) ? type2.ToString() : null);
					array[1] = " : ";
					array[2] = num.ToString("X");
					array[3] = " : ";
					array[4] = num.ToString();
					Console.WriteLine(string.Concat(array));
				}
			}
		}

		// Token: 0x0600BC58 RID: 48216 RVA: 0x00479E8C File Offset: 0x0047808C
		public static uint ServiceHash(Type t, bool baseService = false)
		{
			object obj;
			if (baseService)
			{
				obj = t.GetProperty("Descriptor").GetValue(null);
			}
			else
			{
				bool flag = t.GetInterfaces().Count<Type>() > 0;
				if (!flag)
				{
					return 1U;
				}
				PropertyInfo property = t.GetInterfaces()[0].GetProperty("Descriptor");
				bool flag2 = property == null;
				if (flag2)
				{
					Console.WriteLine("service null : " + t.FullName);
					return 2U;
				}
				obj = t.GetInterfaces()[0].GetProperty("Descriptor").GetValue(Activator.CreateInstance(t));
			}
			bool flag3 = !(obj is ServiceDescriptor);
			uint num;
			if (flag3)
			{
				num = 1U;
			}
			else
			{
				ServiceDescriptor serviceDescriptor = (ServiceDescriptor)obj;
				ServiceOptions options = serviceDescriptor.GetOptions();
				bool flag4 = options == null;
				if (flag4)
				{
					Console.WriteLine("failed to parse : " + t.Name);
					num = 4660U;
				}
				else
				{
					BGSServiceOptions extension = serviceDescriptor.GetOptions().GetExtension<BGSServiceOptions>(ServiceOptionsExtensions.ServiceOptions_);
					uint num2 = BitConverter.ToUInt32(new FNV1A32().ComputeHash(Encoding.UTF8.GetBytes(extension.DescriptorName)));
					num = num2;
				}
			}
			return num;
		}

		// Token: 0x04009127 RID: 37159
		public bool logging = false;

		// Token: 0x04009128 RID: 37160
		public uint token = 0U;

		// Token: 0x04009129 RID: 37161
		public ClientWebSocket clientWebSocket;

		// Token: 0x0400912A RID: 37162
		public TcpClient Client;

		// Token: 0x0400912B RID: 37163
		public NetworkStream BaseStream;

		// Token: 0x0400912C RID: 37164
		public SslStream Stream;

		// Token: 0x0400912D RID: 37165
		private string Tag = "";

		// Token: 0x0400912E RID: 37166
		public CancellationTokenSource cts = new CancellationTokenSource();

		// Token: 0x0400912F RID: 37167
		public BlockingCollection<gRPCWebSocket.BgsPacket> RpcMessages = new BlockingCollection<gRPCWebSocket.BgsPacket>();

		// Token: 0x04009130 RID: 37168
		public Dictionary<uint, IServiceListener> Listeners = new Dictionary<uint, IServiceListener>();

		// Token: 0x04009131 RID: 37169
		public bool Running = true;

		// Token: 0x04009132 RID: 37170
		public string ClientId;

		// Token: 0x020013A6 RID: 5030
		public class BgsPacket
		{
			// Token: 0x04009FC4 RID: 40900
			public Header Header;

			// Token: 0x04009FC5 RID: 40901
			public byte[] Payload;
		}
	}
}
