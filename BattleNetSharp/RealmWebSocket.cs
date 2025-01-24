using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Bgs.Protocol;
using Classic.Protocol.V1.D2RConnection;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace BattleNetSharp
{
	// Token: 0x02000ACF RID: 2767
	public class RealmWebSocket : DefaultCallInvoker
	{
		// Token: 0x0600BC5D RID: 48221 RVA: 0x0047A520 File Offset: 0x00478720
		public RealmWebSocket(Channel channel, ClientWebSocket webSocket, string loginToken)
			: base(channel)
		{
			this.LoginToken = loginToken;
			this.clientWebSocket = webSocket;
		}

		// Token: 0x0600BC5E RID: 48222 RVA: 0x0047A585 File Offset: 0x00478785
		public override AsyncClientStreamingCall<TRequest, TResponse> AsyncClientStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options)
		{
			throw new Exception("not implemented");
		}

		// Token: 0x0600BC5F RID: 48223 RVA: 0x0047A592 File Offset: 0x00478792
		public override AsyncDuplexStreamingCall<TRequest, TResponse> AsyncDuplexStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options)
		{
			throw new Exception("not implemented");
		}

		// Token: 0x0600BC60 RID: 48224 RVA: 0x0047A59F File Offset: 0x0047879F
		public override AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
		{
			throw new Exception("not implemented");
		}

		// Token: 0x0600BC61 RID: 48225 RVA: 0x0047A5AC File Offset: 0x004787AC
		public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
		{
			throw new Exception("not implemented");
		}

		// Token: 0x0600BC62 RID: 48226 RVA: 0x0047A5BC File Offset: 0x004787BC
		public override TResponse BlockingUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
		{
			Header header = new Header();
			Header header2 = header;
			uint num = this.token;
			this.token = num + 1U;
			header2.Token = num;
			header.ObjectId = 2525111537UL; // Equivalent to -1769855759 as an unsigned value
			header.Status = 0U;
			Type type = Type.GetType(method.ServiceName.Replace("_", ""), false, true);
			bool flag = this.logging;
			if (flag)
			{
				Console.WriteLine("realm c2s " + type.FullName + " : " + method.Name);
			}
			bool flag2 = this.logging;
			if (flag2)
			{
				Console.WriteLine(request.ToString());
			}
			ServiceDescriptor serviceDescriptor = (ServiceDescriptor)type.GetProperty("Descriptor").GetValue(null);
			BGSServiceOptions extension = serviceDescriptor.GetOptions().GetExtension<BGSServiceOptions>(ServiceOptionsExtensions.ServiceOptions_);
			uint num2 = BitConverter.ToUInt32(new FNV1A32().ComputeHash(Encoding.UTF8.GetBytes(extension.DescriptorName)));
			num2 = Convert.ToUInt32(extension.DescriptorName, 16);
			header.ServiceId = num2;
			MethodDescriptor methodDescriptor = serviceDescriptor.FindMethodByName(method.Name);
			header.MethodId = methodDescriptor.GetOptions().GetExtension<BGSMethodOptions>(MethodOptionsExtensions.MethodOptions_).Id;
			byte[] array = MessageExtensions.ToByteArray((IMessage)((object)request));
			header.Size = (uint)array.Length;
			header.IsResponse = false;
			header.RequestId = "RT-" + Guid.NewGuid().ToString().ToUpper();
			byte[] array2 = MessageExtensions.ToByteArray(header);
			List<byte> list = BitConverter.GetBytes((ushort)array2.Length).Reverse<byte>().ToList<byte>();
			list.AddRange(array2);
			list.AddRange(array);
			try
			{
				this.clientWebSocket.SendAsync(list.ToArray(), WebSocketMessageType.Binary, true, this.cts.Token).Wait();
			}
			catch (AggregateException ex)
			{
				bool flag3 = ex.Message == "";
				if (flag3)
				{
					return default(TResponse);
				}
				return default(TResponse);
			}
			catch (TaskCanceledException ex2)
			{
				Console.WriteLine("realm websocket timeout : " + ex2.Message);
				return default(TResponse);
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
					bool flag5 = this.RpcMessages.TryTake(out bgsPacket, 10000, this.cts.Token);
					if (flag5)
					{
						bool flag6 = bgsPacket.Header.Token != header.Token || bgsPacket.Header.ServiceId != header.ServiceId || bgsPacket.Header.MethodId != header.MethodId;
						if (flag6)
						{
							Console.WriteLine("out of order rpc");
							return default(TResponse);
						}
						MessageExtensions.MergeFrom(message, bgsPacket.Payload);
						bool flag7 = this.logging;
						if (flag7)
						{
							string[] array3 = new string[6];
							array3[0] = "realm s2c response to ";
							array3[1] = type.FullName;
							array3[2] = " : ";
							array3[3] = method.Name;
							array3[4] = " : type is : ";
							int num3 = 5;
							Type typeFromHandle = typeof(TResponse);
							array3[num3] = ((typeFromHandle != null) ? typeFromHandle.ToString() : null);
							Console.WriteLine(string.Concat(array3));
						}
						bool flag8 = this.logging;
						if (flag8)
						{
							Console.WriteLine(message.ToString());
						}
						return (TResponse)((object)message);
					}
				}
				catch (TaskCanceledException ex3)
				{
					ex3.GetType();
					return default(TResponse);
				}
				catch (OperationCanceledException ex4)
				{
					ex4.GetType();
					return default(TResponse);
				}
				bool flag9 = this.logging;
				if (flag9)
				{
					Console.WriteLine("timeout waiting for response");
				}
				tresponse = default(TResponse);
			}
			return tresponse;
		}

		// Token: 0x0600BC63 RID: 48227 RVA: 0x0047AA38 File Offset: 0x00478C38
		public void HandlePacket()
		{
		}

		// Token: 0x0600BC64 RID: 48228 RVA: 0x0047AA3C File Offset: 0x00478C3C
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
				try
				{
					while (this.Running)
					{
						byte[] array = new byte[65536];
						bool flag = this.clientWebSocket.State != WebSocketState.Open;
						if (flag)
						{
							break;
						}
						WebSocketReceiveResult result = this.clientWebSocket.ReceiveAsync(array, CancellationToken.None).Result;
						ushort num = BitConverter.ToUInt16(array.Take(2).Reverse<byte>().ToArray<byte>(), 0);
						Header header = new Header();
						MessageExtensions.MergeFrom(header, array.Skip(2).Take((int)num).ToArray<byte>());
						bool isResponse = header.IsResponse;
						if (isResponse)
						{
							bool flag2 = this.logging;
							if (flag2)
							{
								Console.WriteLine(string.Concat(new string[]
								{
									"realm adding rpc : ",
									header.Token.ToString(),
									" : ",
									header.Size.ToString(),
									" : ",
									header.Status.ToString()
								}));
							}
							byte[] array2 = array.Skip(2).Skip((int)num).Take(result.Count - 2 - (int)num)
								.ToArray<byte>();
							this.RpcMessages.Add(new gRPCWebSocket.BgsPacket
							{
								Header = header,
								Payload = array2
							});
						}
						else
						{
							bool flag3 = this.Listeners.ContainsKey(header.ServiceId);
							if (flag3)
							{
								IServiceListener serviceListener2 = this.Listeners[header.ServiceId];
								bool flag4 = this.logging;
								if (flag4)
								{
									string loginToken = this.LoginToken;
									string text = " : realm invoke : ";
									Type type2 = serviceListener2.GetType();
									Console.WriteLine(loginToken + text + ((type2 != null) ? type2.ToString() : null));
								}
								IMessage message = serviceListener2.Invoke(header.MethodId, array.Skip(2).Skip((int)num).Take(result.Count - 2 - (int)num)
									.ToArray<byte>(), null);
								bool flag5 = message is NO_RESPONSE;
								if (!flag5)
								{
									byte[] array3 = MessageExtensions.ToByteArray(message);
									Header header2 = new Header();
									header2.ServiceId = header.ServiceId;
									header2.MethodId = header.MethodId;
									header2.Token = header.Token;
									header2.Status = 0U;
									header2.Size = (uint)array3.Length;
									header2.IsResponse = true;
									header2.ObjectId = 2525111537UL;
									header2.RequestId = "";
									bool flag6 = message is CookieUpdateResponse;
									if (flag6)
									{
										header2.RequestId = "RT-" + Guid.NewGuid().ToString().ToUpper();
									}
									byte[] array4 = MessageExtensions.ToByteArray(header2);
									List<byte> list = BitConverter.GetBytes((ushort)array4.Length).Reverse<byte>().ToList<byte>();
									list.AddRange(array4);
									list.AddRange(array3);
									bool flag7 = this.logging;
									if (flag7)
									{
										string[] array5 = new string[5];
										array5[0] = this.LoginToken;
										array5[1] = " : response : ";
										int num2 = 2;
										Type type3 = message.GetType();
										array5[num2] = ((type3 != null) ? type3.ToString() : null);
										array5[3] = " : ";
										int num3 = 4;
										IMessage message2 = message;
										array5[num3] = ((message2 != null) ? message2.ToString() : null);
										Console.WriteLine(string.Concat(array5));
									}
									this.clientWebSocket.SendAsync(list.ToArray(), WebSocketMessageType.Binary, true, CancellationToken.None).Wait();
								}
							}
							else
							{
								bool flag8 = this.logging;
								if (flag8)
								{
									Console.WriteLine(string.Concat(new string[]
									{
										this.LoginToken,
										" : realm invoke : ",
										header.Token.ToString(),
										" : ",
										header.Size.ToString(),
										" : ",
										header.Status.ToString(),
										" : ",
										header.ServiceId.ToString(),
										" : ",
										header.MethodId.ToString()
									}));
								}
								byte[] array6 = array.Skip(2).Skip((int)num).Take(result.Count - 2 - (int)num)
									.ToArray<byte>();
								bool flag9 = header.Token == 0U;
								if (flag9)
								{
									this.cts.Cancel();
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(string.Concat(new string[] { this.LoginToken, " : realm websocket fail, ending realm server : ", ex.Message, " : ", ex.StackTrace }));
				}
			});
		}

		// Token: 0x0600BC65 RID: 48229 RVA: 0x0047AAE0 File Offset: 0x00478CE0
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

		// Token: 0x04009134 RID: 37172
		public bool logging = false;

		// Token: 0x04009135 RID: 37173
		public uint token = 1U;

		// Token: 0x04009136 RID: 37174
		public ClientWebSocket clientWebSocket;

		// Token: 0x04009137 RID: 37175
		private string LoginToken = "";

		// Token: 0x04009138 RID: 37176
		public CancellationTokenSource cts = new CancellationTokenSource();

		// Token: 0x04009139 RID: 37177
		public BlockingCollection<gRPCWebSocket.BgsPacket> RpcMessages = new BlockingCollection<gRPCWebSocket.BgsPacket>();

		// Token: 0x0400913A RID: 37178
		public Dictionary<uint, IServiceListener> Listeners = new Dictionary<uint, IServiceListener>();

		// Token: 0x0400913B RID: 37179
		public bool Running = true;

		// Token: 0x0400913C RID: 37180
		public static bool reset;
	}
}
