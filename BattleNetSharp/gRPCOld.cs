using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
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
	// Token: 0x02000ACC RID: 2764
	public class gRPCOld : DefaultCallInvoker
	{
		// Token: 0x0600BC3E RID: 48190 RVA: 0x00478110 File Offset: 0x00476310
		public gRPCOld(Channel channel, SslStream webSocket, string tag)
			: base(channel)
		{
			this.Tag = tag;
			this.Stream = webSocket;
		}

		// Token: 0x0600BC3F RID: 48191 RVA: 0x00478178 File Offset: 0x00476378
		public gRPCOld(Channel channel, SslStream webSocket)
			: base(channel)
		{
			this.Stream = webSocket;
		}

		// Token: 0x0600BC40 RID: 48192 RVA: 0x004781D6 File Offset: 0x004763D6
		public override AsyncClientStreamingCall<TRequest, TResponse> AsyncClientStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options)
		{
			throw new Exception("not implemented");
		}

		// Token: 0x0600BC41 RID: 48193 RVA: 0x004781E3 File Offset: 0x004763E3
		public override AsyncDuplexStreamingCall<TRequest, TResponse> AsyncDuplexStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options)
		{
			throw new Exception("not implemented");
		}

		// Token: 0x0600BC42 RID: 48194 RVA: 0x004781F0 File Offset: 0x004763F0
		public override AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
		{
			throw new Exception("not implemented");
		}

		// Token: 0x0600BC43 RID: 48195 RVA: 0x004781FD File Offset: 0x004763FD
		public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
		{
			throw new Exception("not implemented");
		}

		// Token: 0x0600BC44 RID: 48196 RVA: 0x0047820C File Offset: 0x0047640C
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
			uint num2 = BitConverter.ToUInt32(new FNV1A32().ComputeHash(Encoding.UTF8.GetBytes(extension.DescriptorName)));
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
				this.Stream.Write(list.ToArray());
			}
			catch
			{
				Console.WriteLine("grpc websocket 1");
			}
			bool flag3 = typeof(TResponse) == typeof(NO_RESPONSE);
			TResponse tresponse;
			if (flag3)
			{
				tresponse = default(TResponse);
			}
			else
			{
				IMessage message = (IMessage)Activator.CreateInstance(typeof(TResponse));
				try
				{
					gRPCOld.BgsPacket bgsPacket;
					bool flag4 = this.RpcMessages.TryTake(out bgsPacket, 10000, this.cts.Token);
					if (flag4)
					{
						bool flag5 = bgsPacket.Header.Token != header.Token;
						if (flag5)
						{
							bool flag6 = this.RpcMessages.TryTake(out bgsPacket, 10000, this.cts.Token);
							if (flag6)
							{
							}
						}
						string text = ProtobufDumper.Dump(bgsPacket.Payload, 0);
						MessageExtensions.MergeFrom(message, bgsPacket.Payload);
						bool flag7 = this.logging;
						if (flag7)
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
						bool flag8 = this.logging;
						if (flag8)
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

		// Token: 0x0600BC45 RID: 48197 RVA: 0x004785B0 File Offset: 0x004767B0
		public void HandlePacket()
		{
		}

		// Token: 0x0600BC46 RID: 48198 RVA: 0x004785B4 File Offset: 0x004767B4
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
				while (this.Running && this.Stream.CanRead)
				{
					List<byte> list = new List<byte>();
					byte[] array = new byte[65536];
					int num = this.Stream.Read(array, 0, array.Length);
					list.AddRange(array.Take(num));
					ushort num2 = BitConverter.ToUInt16(list.Take(2).Reverse<byte>().ToArray<byte>(), 0);
					Header recvHeader = new Header();
					MessageExtensions.MergeFrom(recvHeader, list.Skip(2).Take((int)num2).ToArray<byte>());
					bool flag = (long)(list.Count - 2 - (int)num2) != (long)((ulong)recvHeader.Size);
					if (flag)
					{
						Console.WriteLine("rawr");
					}
					bool flag2 = recvHeader.ServiceId == 254U;
					if (flag2)
					{
						byte[] array2 = list.Skip(2).Skip((int)num2).Take(list.Count - 2 - (int)num2)
							.ToArray<byte>();
						bool flag3 = recvHeader.Status > 0U;
						if (flag3)
						{
						}
						this.RpcMessages.Add(new gRPCOld.BgsPacket
						{
							Header = recvHeader,
							Payload = array2
						});
					}
					else
					{
						this.ClientId = recvHeader.ClientId;
						bool flag4 = this.Listeners.ContainsKey(recvHeader.ServiceHash);
						if (flag4)
						{
							IServiceListener serviceListener2 = this.Listeners[recvHeader.ServiceHash];
							string text;
							IMessage packet = serviceListener2.GetPacket(recvHeader.MethodId, list.Skip(2).Skip((int)num2).Take(list.Count - 2 - (int)num2)
								.ToArray<byte>(), out text);
							bool flag5 = this.logging;
							if (flag5)
							{
								string[] array3 = new string[6];
								array3[0] = "some listerner: ";
								array3[1] = serviceListener2.GetType().Name;
								array3[2] = " : ";
								array3[3] = text;
								array3[4] = " : ";
								int num3 = 5;
								IMessage message = packet;
								array3[num3] = ((message != null) ? message.ToString() : null);
								Console.WriteLine(string.Concat(array3));
							}
							IMessage message2 = serviceListener2.Invoke(recvHeader.MethodId, list.Skip(2).Skip((int)num2).Take(list.Count - 2 - (int)num2)
								.ToArray<byte>(), null);
							bool flag6 = message2 is NO_RESPONSE;
							if (!flag6)
							{
								byte[] array4 = MessageExtensions.ToByteArray(message2);
								byte[] array5 = MessageExtensions.ToByteArray(new Header
								{
									ServiceId = 254U,
									Token = recvHeader.Token,
									Status = 0U,
									Size = (uint)array4.Length
								});
								List<byte> list2 = BitConverter.GetBytes((ushort)array5.Length).Reverse<byte>().ToList<byte>();
								list2.AddRange(array5);
								list2.AddRange(array4);
								this.Stream.Write(list2.ToArray());
							}
						}
						else
						{
							bool flag7 = recvHeader.ServiceHash > 0U;
							if (flag7)
							{
								Type type2 = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault((Type t) => t.Name.EndsWith("Service") && t.Namespace.Contains("Bgs") && gRPCOld.ServiceHash(t, false) == recvHeader.ServiceHash);
								ServiceDescriptor serviceDescriptor = (ServiceDescriptor)type2.GetProperty("Descriptor").GetValue(null);
								MethodDescriptor methodDescriptor = serviceDescriptor.Methods.First((MethodDescriptor m) => m.GetOptions().GetExtension<BGSMethodOptions>(MethodOptionsExtensions.MethodOptions_).Id == recvHeader.MethodId);
								IMessage message3 = (IMessage)Activator.CreateInstance(methodDescriptor.InputType.ClrType);
								MessageExtensions.MergeFrom(message3, list.Skip(2).Skip((int)num2).Take(list.Count - 2 - (int)num2)
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

		// Token: 0x0600BC47 RID: 48199 RVA: 0x00478658 File Offset: 0x00476858
		public T RecvPacket<T>()
		{
			List<byte> list = new List<byte>();
			byte[] array = new byte[65536];
			int num = this.Stream.Read(array, 0, array.Length);
			list.AddRange(array.Take(num));
			ushort num2 = BitConverter.ToUInt16(list.Take(2).Reverse<byte>().ToArray<byte>(), 0);
			Header header = new Header();
			MessageExtensions.MergeFrom(header, list.Skip(2).Take((int)num2).ToArray<byte>());
			IMessage message = (IMessage)Activator.CreateInstance(typeof(T));
			MessageExtensions.MergeFrom(message, list.Skip(2).Skip((int)num2).Take(list.Count - 2 - (int)num2)
				.ToArray<byte>());
			return (T)((object)message);
		}

		// Token: 0x0600BC48 RID: 48200 RVA: 0x0047871C File Offset: 0x0047691C
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
					Type type3 = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault((Type t) => t.GetInterface("IServiceListener") != null && gRPCOld.ServiceHash(t, false) == recvHeader.ServiceHash);
					bool flag7 = type3 == null;
					object obj2;
					if (flag7)
					{
						type3 = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(delegate(Type t)
						{
							string @namespace = t.Namespace;
							return @namespace != null && @namespace.Contains("Bgs") && t.Name.EndsWith("Service") && gRPCOld.ServiceHash(t, true) == recvHeader.ServiceHash;
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

		// Token: 0x0600BC49 RID: 48201 RVA: 0x00478BBC File Offset: 0x00476DBC
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

		// Token: 0x0600BC4A RID: 48202 RVA: 0x00478CFC File Offset: 0x00476EFC
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

		// Token: 0x0400911C RID: 37148
		public bool logging = false;

		// Token: 0x0400911D RID: 37149
		public uint token = 0U;

		// Token: 0x0400911E RID: 37150
		public TcpClient Client;

		// Token: 0x0400911F RID: 37151
		public NetworkStream BaseStream;

		// Token: 0x04009120 RID: 37152
		public SslStream Stream;

		// Token: 0x04009121 RID: 37153
		private string Tag = "";

		// Token: 0x04009122 RID: 37154
		public CancellationTokenSource cts = new CancellationTokenSource();

		// Token: 0x04009123 RID: 37155
		public BlockingCollection<gRPCOld.BgsPacket> RpcMessages = new BlockingCollection<gRPCOld.BgsPacket>();

		// Token: 0x04009124 RID: 37156
		public Dictionary<uint, IServiceListener> Listeners = new Dictionary<uint, IServiceListener>();

		// Token: 0x04009125 RID: 37157
		public bool Running = true;

		// Token: 0x04009126 RID: 37158
		public string ClientId;

		// Token: 0x020013A2 RID: 5026
		public class BgsPacket
		{
			// Token: 0x04009FBC RID: 40892
			public Header Header;

			// Token: 0x04009FBD RID: 40893
			public byte[] Payload;
		}
	}
}
