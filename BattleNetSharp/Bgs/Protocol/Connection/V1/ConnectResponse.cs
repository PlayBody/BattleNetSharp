using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Connection.V1
{
	// Token: 0x0200042E RID: 1070
	public sealed class ConnectResponse : IMessage<ConnectResponse>, IMessage, IEquatable<ConnectResponse>, IDeepCloneable<ConnectResponse>, IBufferMessage
	{
		// Token: 0x1700219B RID: 8603
		// (get) Token: 0x0600692A RID: 26922 RVA: 0x0019729C File Offset: 0x0019549C
		[DebuggerNonUserCode]
		public static MessageParser<ConnectResponse> Parser
		{
			get
			{
				return ConnectResponse._parser;
			}
		}

		// Token: 0x1700219C RID: 8604
		// (get) Token: 0x0600692B RID: 26923 RVA: 0x001972B4 File Offset: 0x001954B4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ConnectionServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x1700219D RID: 8605
		// (get) Token: 0x0600692C RID: 26924 RVA: 0x001972D8 File Offset: 0x001954D8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConnectResponse.Descriptor;
			}
		}

		// Token: 0x0600692D RID: 26925 RVA: 0x001972EF File Offset: 0x001954EF
		[DebuggerNonUserCode]
		public ConnectResponse()
		{
		}

		// Token: 0x0600692E RID: 26926 RVA: 0x001972FC File Offset: 0x001954FC
		[DebuggerNonUserCode]
		public ConnectResponse(ConnectResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.serverId_ = ((other.serverId_ != null) ? other.serverId_.Clone() : null);
			this.clientId_ = ((other.clientId_ != null) ? other.clientId_.Clone() : null);
			this.bindResult_ = other.bindResult_;
			this.bindResponse_ = ((other.bindResponse_ != null) ? other.bindResponse_.Clone() : null);
			this.contentHandleArray_ = ((other.contentHandleArray_ != null) ? other.contentHandleArray_.Clone() : null);
			this.serverTime_ = other.serverTime_;
			this.useBindlessRpc_ = other.useBindlessRpc_;
			this.binaryContentHandleArray_ = ((other.binaryContentHandleArray_ != null) ? other.binaryContentHandleArray_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600692F RID: 26927 RVA: 0x001973E0 File Offset: 0x001955E0
		[DebuggerNonUserCode]
		public ConnectResponse Clone()
		{
			return new ConnectResponse(this);
		}

		// Token: 0x1700219E RID: 8606
		// (get) Token: 0x06006930 RID: 26928 RVA: 0x001973F8 File Offset: 0x001955F8
		// (set) Token: 0x06006931 RID: 26929 RVA: 0x00197410 File Offset: 0x00195610
		[DebuggerNonUserCode]
		public ProcessId ServerId
		{
			get
			{
				return this.serverId_;
			}
			set
			{
				this.serverId_ = value;
			}
		}

		// Token: 0x1700219F RID: 8607
		// (get) Token: 0x06006932 RID: 26930 RVA: 0x0019741C File Offset: 0x0019561C
		// (set) Token: 0x06006933 RID: 26931 RVA: 0x00197434 File Offset: 0x00195634
		[DebuggerNonUserCode]
		public ProcessId ClientId
		{
			get
			{
				return this.clientId_;
			}
			set
			{
				this.clientId_ = value;
			}
		}

		// Token: 0x170021A0 RID: 8608
		// (get) Token: 0x06006934 RID: 26932 RVA: 0x00197440 File Offset: 0x00195640
		// (set) Token: 0x06006935 RID: 26933 RVA: 0x00197471 File Offset: 0x00195671
		[DebuggerNonUserCode]
		public uint BindResult
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint bindResultDefaultValue;
				if (flag)
				{
					bindResultDefaultValue = this.bindResult_;
				}
				else
				{
					bindResultDefaultValue = ConnectResponse.BindResultDefaultValue;
				}
				return bindResultDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.bindResult_ = value;
			}
		}

		// Token: 0x170021A1 RID: 8609
		// (get) Token: 0x06006936 RID: 26934 RVA: 0x0019748C File Offset: 0x0019568C
		[DebuggerNonUserCode]
		public bool HasBindResult
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006937 RID: 26935 RVA: 0x001974A9 File Offset: 0x001956A9
		[DebuggerNonUserCode]
		public void ClearBindResult()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170021A2 RID: 8610
		// (get) Token: 0x06006938 RID: 26936 RVA: 0x001974BC File Offset: 0x001956BC
		// (set) Token: 0x06006939 RID: 26937 RVA: 0x001974D4 File Offset: 0x001956D4
		[DebuggerNonUserCode]
		public BindResponse BindResponse
		{
			get
			{
				return this.bindResponse_;
			}
			set
			{
				this.bindResponse_ = value;
			}
		}

		// Token: 0x170021A3 RID: 8611
		// (get) Token: 0x0600693A RID: 26938 RVA: 0x001974E0 File Offset: 0x001956E0
		// (set) Token: 0x0600693B RID: 26939 RVA: 0x001974F8 File Offset: 0x001956F8
		[DebuggerNonUserCode]
		public ConnectionMeteringContentHandles ContentHandleArray
		{
			get
			{
				return this.contentHandleArray_;
			}
			set
			{
				this.contentHandleArray_ = value;
			}
		}

		// Token: 0x170021A4 RID: 8612
		// (get) Token: 0x0600693C RID: 26940 RVA: 0x00197504 File Offset: 0x00195704
		// (set) Token: 0x0600693D RID: 26941 RVA: 0x00197535 File Offset: 0x00195735
		[DebuggerNonUserCode]
		public ulong ServerTime
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong serverTimeDefaultValue;
				if (flag)
				{
					serverTimeDefaultValue = this.serverTime_;
				}
				else
				{
					serverTimeDefaultValue = ConnectResponse.ServerTimeDefaultValue;
				}
				return serverTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.serverTime_ = value;
			}
		}

		// Token: 0x170021A5 RID: 8613
		// (get) Token: 0x0600693E RID: 26942 RVA: 0x00197550 File Offset: 0x00195750
		[DebuggerNonUserCode]
		public bool HasServerTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600693F RID: 26943 RVA: 0x0019756D File Offset: 0x0019576D
		[DebuggerNonUserCode]
		public void ClearServerTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170021A6 RID: 8614
		// (get) Token: 0x06006940 RID: 26944 RVA: 0x00197580 File Offset: 0x00195780
		// (set) Token: 0x06006941 RID: 26945 RVA: 0x001975B1 File Offset: 0x001957B1
		[DebuggerNonUserCode]
		public bool UseBindlessRpc
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool useBindlessRpcDefaultValue;
				if (flag)
				{
					useBindlessRpcDefaultValue = this.useBindlessRpc_;
				}
				else
				{
					useBindlessRpcDefaultValue = ConnectResponse.UseBindlessRpcDefaultValue;
				}
				return useBindlessRpcDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.useBindlessRpc_ = value;
			}
		}

		// Token: 0x170021A7 RID: 8615
		// (get) Token: 0x06006942 RID: 26946 RVA: 0x001975CC File Offset: 0x001957CC
		[DebuggerNonUserCode]
		public bool HasUseBindlessRpc
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06006943 RID: 26947 RVA: 0x001975E9 File Offset: 0x001957E9
		[DebuggerNonUserCode]
		public void ClearUseBindlessRpc()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170021A8 RID: 8616
		// (get) Token: 0x06006944 RID: 26948 RVA: 0x001975FC File Offset: 0x001957FC
		// (set) Token: 0x06006945 RID: 26949 RVA: 0x00197614 File Offset: 0x00195814
		[DebuggerNonUserCode]
		public ConnectionMeteringContentHandles BinaryContentHandleArray
		{
			get
			{
				return this.binaryContentHandleArray_;
			}
			set
			{
				this.binaryContentHandleArray_ = value;
			}
		}

		// Token: 0x06006946 RID: 26950 RVA: 0x00197620 File Offset: 0x00195820
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConnectResponse);
		}

		// Token: 0x06006947 RID: 26951 RVA: 0x00197640 File Offset: 0x00195840
		[DebuggerNonUserCode]
		public bool Equals(ConnectResponse other)
		{
			bool flag = other == null;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				bool flag3 = other == this;
				if (flag3)
				{
					flag2 = true;
				}
				else
				{
					bool flag4 = !object.Equals(this.ServerId, other.ServerId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.ClientId, other.ClientId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.BindResult != other.BindResult;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.BindResponse, other.BindResponse);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.ContentHandleArray, other.ContentHandleArray);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.ServerTime != other.ServerTime;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.UseBindlessRpc != other.UseBindlessRpc;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !object.Equals(this.BinaryContentHandleArray, other.BinaryContentHandleArray);
												flag2 = !flag11 && object.Equals(this._unknownFields, other._unknownFields);
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006948 RID: 26952 RVA: 0x00197774 File Offset: 0x00195974
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.serverId_ != null;
			if (flag)
			{
				num ^= this.ServerId.GetHashCode();
			}
			bool flag2 = this.clientId_ != null;
			if (flag2)
			{
				num ^= this.ClientId.GetHashCode();
			}
			bool hasBindResult = this.HasBindResult;
			if (hasBindResult)
			{
				num ^= this.BindResult.GetHashCode();
			}
			bool flag3 = this.bindResponse_ != null;
			if (flag3)
			{
				num ^= this.BindResponse.GetHashCode();
			}
			bool flag4 = this.contentHandleArray_ != null;
			if (flag4)
			{
				num ^= this.ContentHandleArray.GetHashCode();
			}
			bool hasServerTime = this.HasServerTime;
			if (hasServerTime)
			{
				num ^= this.ServerTime.GetHashCode();
			}
			bool hasUseBindlessRpc = this.HasUseBindlessRpc;
			if (hasUseBindlessRpc)
			{
				num ^= this.UseBindlessRpc.GetHashCode();
			}
			bool flag5 = this.binaryContentHandleArray_ != null;
			if (flag5)
			{
				num ^= this.BinaryContentHandleArray.GetHashCode();
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006949 RID: 26953 RVA: 0x00197890 File Offset: 0x00195A90
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600694A RID: 26954 RVA: 0x001978A8 File Offset: 0x00195AA8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600694B RID: 26955 RVA: 0x001978B4 File Offset: 0x00195AB4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.serverId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ServerId);
			}
			bool flag2 = this.clientId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ClientId);
			}
			bool hasBindResult = this.HasBindResult;
			if (hasBindResult)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.BindResult);
			}
			bool flag3 = this.bindResponse_ != null;
			if (flag3)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.BindResponse);
			}
			bool flag4 = this.contentHandleArray_ != null;
			if (flag4)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.ContentHandleArray);
			}
			bool hasServerTime = this.HasServerTime;
			if (hasServerTime)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.ServerTime);
			}
			bool hasUseBindlessRpc = this.HasUseBindlessRpc;
			if (hasUseBindlessRpc)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.UseBindlessRpc);
			}
			bool flag5 = this.binaryContentHandleArray_ != null;
			if (flag5)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.BinaryContentHandleArray);
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600694C RID: 26956 RVA: 0x00197A08 File Offset: 0x00195C08
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.serverId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ServerId);
			}
			bool flag2 = this.clientId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ClientId);
			}
			bool hasBindResult = this.HasBindResult;
			if (hasBindResult)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BindResult);
			}
			bool flag3 = this.bindResponse_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BindResponse);
			}
			bool flag4 = this.contentHandleArray_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ContentHandleArray);
			}
			bool hasServerTime = this.HasServerTime;
			if (hasServerTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ServerTime);
			}
			bool hasUseBindlessRpc = this.HasUseBindlessRpc;
			if (hasUseBindlessRpc)
			{
				num += 2;
			}
			bool flag5 = this.binaryContentHandleArray_ != null;
			if (flag5)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BinaryContentHandleArray);
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600694D RID: 26957 RVA: 0x00197B2C File Offset: 0x00195D2C
		[DebuggerNonUserCode]
		public void MergeFrom(ConnectResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.serverId_ != null;
				if (flag2)
				{
					bool flag3 = this.serverId_ == null;
					if (flag3)
					{
						this.ServerId = new ProcessId();
					}
					this.ServerId.MergeFrom(other.ServerId);
				}
				bool flag4 = other.clientId_ != null;
				if (flag4)
				{
					bool flag5 = this.clientId_ == null;
					if (flag5)
					{
						this.ClientId = new ProcessId();
					}
					this.ClientId.MergeFrom(other.ClientId);
				}
				bool hasBindResult = other.HasBindResult;
				if (hasBindResult)
				{
					this.BindResult = other.BindResult;
				}
				bool flag6 = other.bindResponse_ != null;
				if (flag6)
				{
					bool flag7 = this.bindResponse_ == null;
					if (flag7)
					{
						this.BindResponse = new BindResponse();
					}
					this.BindResponse.MergeFrom(other.BindResponse);
				}
				bool flag8 = other.contentHandleArray_ != null;
				if (flag8)
				{
					bool flag9 = this.contentHandleArray_ == null;
					if (flag9)
					{
						this.ContentHandleArray = new ConnectionMeteringContentHandles();
					}
					this.ContentHandleArray.MergeFrom(other.ContentHandleArray);
				}
				bool hasServerTime = other.HasServerTime;
				if (hasServerTime)
				{
					this.ServerTime = other.ServerTime;
				}
				bool hasUseBindlessRpc = other.HasUseBindlessRpc;
				if (hasUseBindlessRpc)
				{
					this.UseBindlessRpc = other.UseBindlessRpc;
				}
				bool flag10 = other.binaryContentHandleArray_ != null;
				if (flag10)
				{
					bool flag11 = this.binaryContentHandleArray_ == null;
					if (flag11)
					{
						this.BinaryContentHandleArray = new ConnectionMeteringContentHandles();
					}
					this.BinaryContentHandleArray.MergeFrom(other.BinaryContentHandleArray);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600694E RID: 26958 RVA: 0x00197CEA File Offset: 0x00195EEA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600694F RID: 26959 RVA: 0x00197CF8 File Offset: 0x00195EF8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 34U)
				{
					if (num3 <= 18U)
					{
						if (num3 != 10U)
						{
							if (num3 != 18U)
							{
								goto IL_0067;
							}
							bool flag = this.clientId_ == null;
							if (flag)
							{
								this.ClientId = new ProcessId();
							}
							input.ReadMessage(this.ClientId);
						}
						else
						{
							bool flag2 = this.serverId_ == null;
							if (flag2)
							{
								this.ServerId = new ProcessId();
							}
							input.ReadMessage(this.ServerId);
						}
					}
					else if (num3 != 24U)
					{
						if (num3 != 34U)
						{
							goto IL_0067;
						}
						bool flag3 = this.bindResponse_ == null;
						if (flag3)
						{
							this.BindResponse = new BindResponse();
						}
						input.ReadMessage(this.BindResponse);
					}
					else
					{
						this.BindResult = input.ReadUInt32();
					}
				}
				else if (num3 <= 48U)
				{
					if (num3 != 42U)
					{
						if (num3 != 48U)
						{
							goto IL_0067;
						}
						this.ServerTime = input.ReadUInt64();
					}
					else
					{
						bool flag4 = this.contentHandleArray_ == null;
						if (flag4)
						{
							this.ContentHandleArray = new ConnectionMeteringContentHandles();
						}
						input.ReadMessage(this.ContentHandleArray);
					}
				}
				else if (num3 != 56U)
				{
					if (num3 != 66U)
					{
						goto IL_0067;
					}
					bool flag5 = this.binaryContentHandleArray_ == null;
					if (flag5)
					{
						this.BinaryContentHandleArray = new ConnectionMeteringContentHandles();
					}
					input.ReadMessage(this.BinaryContentHandleArray);
				}
				else
				{
					this.UseBindlessRpc = input.ReadBool();
				}
				continue;
				IL_0067:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002FDD RID: 12253
		private static readonly MessageParser<ConnectResponse> _parser = new MessageParser<ConnectResponse>(() => new ConnectResponse());

		// Token: 0x04002FDE RID: 12254
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FDF RID: 12255
		private int _hasBits0;

		// Token: 0x04002FE0 RID: 12256
		public const int ServerIdFieldNumber = 1;

		// Token: 0x04002FE1 RID: 12257
		private ProcessId serverId_;

		// Token: 0x04002FE2 RID: 12258
		public const int ClientIdFieldNumber = 2;

		// Token: 0x04002FE3 RID: 12259
		private ProcessId clientId_;

		// Token: 0x04002FE4 RID: 12260
		public const int BindResultFieldNumber = 3;

		// Token: 0x04002FE5 RID: 12261
		private static readonly uint BindResultDefaultValue = 0U;

		// Token: 0x04002FE6 RID: 12262
		private uint bindResult_;

		// Token: 0x04002FE7 RID: 12263
		public const int BindResponseFieldNumber = 4;

		// Token: 0x04002FE8 RID: 12264
		private BindResponse bindResponse_;

		// Token: 0x04002FE9 RID: 12265
		public const int ContentHandleArrayFieldNumber = 5;

		// Token: 0x04002FEA RID: 12266
		private ConnectionMeteringContentHandles contentHandleArray_;

		// Token: 0x04002FEB RID: 12267
		public const int ServerTimeFieldNumber = 6;

		// Token: 0x04002FEC RID: 12268
		private static readonly ulong ServerTimeDefaultValue = 0UL;

		// Token: 0x04002FED RID: 12269
		private ulong serverTime_;

		// Token: 0x04002FEE RID: 12270
		public const int UseBindlessRpcFieldNumber = 7;

		// Token: 0x04002FEF RID: 12271
		private static readonly bool UseBindlessRpcDefaultValue = false;

		// Token: 0x04002FF0 RID: 12272
		private bool useBindlessRpc_;

		// Token: 0x04002FF1 RID: 12273
		public const int BinaryContentHandleArrayFieldNumber = 8;

		// Token: 0x04002FF2 RID: 12274
		private ConnectionMeteringContentHandles binaryContentHandleArray_;
	}
}
