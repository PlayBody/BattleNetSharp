using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Connection.V1
{
	// Token: 0x02000432 RID: 1074
	public sealed class EchoRequest : IMessage<EchoRequest>, IMessage, IEquatable<EchoRequest>, IDeepCloneable<EchoRequest>, IBufferMessage
	{
		// Token: 0x170021BB RID: 8635
		// (get) Token: 0x06006991 RID: 27025 RVA: 0x00198BF4 File Offset: 0x00196DF4
		[DebuggerNonUserCode]
		public static MessageParser<EchoRequest> Parser
		{
			get
			{
				return EchoRequest._parser;
			}
		}

		// Token: 0x170021BC RID: 8636
		// (get) Token: 0x06006992 RID: 27026 RVA: 0x00198C0C File Offset: 0x00196E0C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ConnectionServiceReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x170021BD RID: 8637
		// (get) Token: 0x06006993 RID: 27027 RVA: 0x00198C30 File Offset: 0x00196E30
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EchoRequest.Descriptor;
			}
		}

		// Token: 0x06006994 RID: 27028 RVA: 0x00198C47 File Offset: 0x00196E47
		[DebuggerNonUserCode]
		public EchoRequest()
		{
		}

		// Token: 0x06006995 RID: 27029 RVA: 0x00198C54 File Offset: 0x00196E54
		[DebuggerNonUserCode]
		public EchoRequest(EchoRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.time_ = other.time_;
			this.networkOnly_ = other.networkOnly_;
			this.payload_ = other.payload_;
			this.forward_ = ((other.forward_ != null) ? other.forward_.Clone() : null);
			this.forwardClientId_ = other.forwardClientId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006996 RID: 27030 RVA: 0x00198CD4 File Offset: 0x00196ED4
		[DebuggerNonUserCode]
		public EchoRequest Clone()
		{
			return new EchoRequest(this);
		}

		// Token: 0x170021BE RID: 8638
		// (get) Token: 0x06006997 RID: 27031 RVA: 0x00198CEC File Offset: 0x00196EEC
		// (set) Token: 0x06006998 RID: 27032 RVA: 0x00198D1D File Offset: 0x00196F1D
		[DebuggerNonUserCode]
		public ulong Time
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong timeDefaultValue;
				if (flag)
				{
					timeDefaultValue = this.time_;
				}
				else
				{
					timeDefaultValue = EchoRequest.TimeDefaultValue;
				}
				return timeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.time_ = value;
			}
		}

		// Token: 0x170021BF RID: 8639
		// (get) Token: 0x06006999 RID: 27033 RVA: 0x00198D38 File Offset: 0x00196F38
		[DebuggerNonUserCode]
		public bool HasTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600699A RID: 27034 RVA: 0x00198D55 File Offset: 0x00196F55
		[DebuggerNonUserCode]
		public void ClearTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170021C0 RID: 8640
		// (get) Token: 0x0600699B RID: 27035 RVA: 0x00198D68 File Offset: 0x00196F68
		// (set) Token: 0x0600699C RID: 27036 RVA: 0x00198D99 File Offset: 0x00196F99
		[DebuggerNonUserCode]
		public bool NetworkOnly
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool networkOnlyDefaultValue;
				if (flag)
				{
					networkOnlyDefaultValue = this.networkOnly_;
				}
				else
				{
					networkOnlyDefaultValue = EchoRequest.NetworkOnlyDefaultValue;
				}
				return networkOnlyDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.networkOnly_ = value;
			}
		}

		// Token: 0x170021C1 RID: 8641
		// (get) Token: 0x0600699D RID: 27037 RVA: 0x00198DB4 File Offset: 0x00196FB4
		[DebuggerNonUserCode]
		public bool HasNetworkOnly
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600699E RID: 27038 RVA: 0x00198DD1 File Offset: 0x00196FD1
		[DebuggerNonUserCode]
		public void ClearNetworkOnly()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170021C2 RID: 8642
		// (get) Token: 0x0600699F RID: 27039 RVA: 0x00198DE4 File Offset: 0x00196FE4
		// (set) Token: 0x060069A0 RID: 27040 RVA: 0x00198E05 File Offset: 0x00197005
		[DebuggerNonUserCode]
		public ByteString Payload
		{
			get
			{
				return this.payload_ ?? EchoRequest.PayloadDefaultValue;
			}
			set
			{
				this.payload_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x170021C3 RID: 8643
		// (get) Token: 0x060069A1 RID: 27041 RVA: 0x00198E1C File Offset: 0x0019701C
		[DebuggerNonUserCode]
		public bool HasPayload
		{
			get
			{
				return this.payload_ != null;
			}
		}

		// Token: 0x060069A2 RID: 27042 RVA: 0x00198E3A File Offset: 0x0019703A
		[DebuggerNonUserCode]
		public void ClearPayload()
		{
			this.payload_ = null;
		}

		// Token: 0x170021C4 RID: 8644
		// (get) Token: 0x060069A3 RID: 27043 RVA: 0x00198E44 File Offset: 0x00197044
		// (set) Token: 0x060069A4 RID: 27044 RVA: 0x00198E5C File Offset: 0x0019705C
		[DebuggerNonUserCode]
		public ProcessId Forward
		{
			get
			{
				return this.forward_;
			}
			set
			{
				this.forward_ = value;
			}
		}

		// Token: 0x170021C5 RID: 8645
		// (get) Token: 0x060069A5 RID: 27045 RVA: 0x00198E68 File Offset: 0x00197068
		// (set) Token: 0x060069A6 RID: 27046 RVA: 0x00198E89 File Offset: 0x00197089
		[DebuggerNonUserCode]
		public string ForwardClientId
		{
			get
			{
				return this.forwardClientId_ ?? EchoRequest.ForwardClientIdDefaultValue;
			}
			set
			{
				this.forwardClientId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170021C6 RID: 8646
		// (get) Token: 0x060069A7 RID: 27047 RVA: 0x00198EA0 File Offset: 0x001970A0
		[DebuggerNonUserCode]
		public bool HasForwardClientId
		{
			get
			{
				return this.forwardClientId_ != null;
			}
		}

		// Token: 0x060069A8 RID: 27048 RVA: 0x00198EBB File Offset: 0x001970BB
		[DebuggerNonUserCode]
		public void ClearForwardClientId()
		{
			this.forwardClientId_ = null;
		}

		// Token: 0x060069A9 RID: 27049 RVA: 0x00198EC8 File Offset: 0x001970C8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EchoRequest);
		}

		// Token: 0x060069AA RID: 27050 RVA: 0x00198EE8 File Offset: 0x001970E8
		[DebuggerNonUserCode]
		public bool Equals(EchoRequest other)
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
					bool flag4 = this.Time != other.Time;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.NetworkOnly != other.NetworkOnly;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Payload != other.Payload;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.Forward, other.Forward);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.ForwardClientId != other.ForwardClientId;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060069AB RID: 27051 RVA: 0x00198FB8 File Offset: 0x001971B8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTime = this.HasTime;
			if (hasTime)
			{
				num ^= this.Time.GetHashCode();
			}
			bool hasNetworkOnly = this.HasNetworkOnly;
			if (hasNetworkOnly)
			{
				num ^= this.NetworkOnly.GetHashCode();
			}
			bool hasPayload = this.HasPayload;
			if (hasPayload)
			{
				num ^= this.Payload.GetHashCode();
			}
			bool flag = this.forward_ != null;
			if (flag)
			{
				num ^= this.Forward.GetHashCode();
			}
			bool hasForwardClientId = this.HasForwardClientId;
			if (hasForwardClientId)
			{
				num ^= this.ForwardClientId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060069AC RID: 27052 RVA: 0x00199078 File Offset: 0x00197278
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060069AD RID: 27053 RVA: 0x00199090 File Offset: 0x00197290
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060069AE RID: 27054 RVA: 0x0019909C File Offset: 0x0019729C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTime = this.HasTime;
			if (hasTime)
			{
				output.WriteRawTag(9);
				output.WriteFixed64(this.Time);
			}
			bool hasNetworkOnly = this.HasNetworkOnly;
			if (hasNetworkOnly)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.NetworkOnly);
			}
			bool hasPayload = this.HasPayload;
			if (hasPayload)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.Payload);
			}
			bool flag = this.forward_ != null;
			if (flag)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Forward);
			}
			bool hasForwardClientId = this.HasForwardClientId;
			if (hasForwardClientId)
			{
				output.WriteRawTag(42);
				output.WriteString(this.ForwardClientId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060069AF RID: 27055 RVA: 0x00199178 File Offset: 0x00197378
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTime = this.HasTime;
			if (hasTime)
			{
				num += 9;
			}
			bool hasNetworkOnly = this.HasNetworkOnly;
			if (hasNetworkOnly)
			{
				num += 2;
			}
			bool hasPayload = this.HasPayload;
			if (hasPayload)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Payload);
			}
			bool flag = this.forward_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Forward);
			}
			bool hasForwardClientId = this.HasForwardClientId;
			if (hasForwardClientId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ForwardClientId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060069B0 RID: 27056 RVA: 0x0019922C File Offset: 0x0019742C
		[DebuggerNonUserCode]
		public void MergeFrom(EchoRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTime = other.HasTime;
				if (hasTime)
				{
					this.Time = other.Time;
				}
				bool hasNetworkOnly = other.HasNetworkOnly;
				if (hasNetworkOnly)
				{
					this.NetworkOnly = other.NetworkOnly;
				}
				bool hasPayload = other.HasPayload;
				if (hasPayload)
				{
					this.Payload = other.Payload;
				}
				bool flag2 = other.forward_ != null;
				if (flag2)
				{
					bool flag3 = this.forward_ == null;
					if (flag3)
					{
						this.Forward = new ProcessId();
					}
					this.Forward.MergeFrom(other.Forward);
				}
				bool hasForwardClientId = other.HasForwardClientId;
				if (hasForwardClientId)
				{
					this.ForwardClientId = other.ForwardClientId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060069B1 RID: 27057 RVA: 0x00199305 File Offset: 0x00197505
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060069B2 RID: 27058 RVA: 0x00199310 File Offset: 0x00197510
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 16U)
				{
					if (num3 != 9U)
					{
						if (num3 != 16U)
						{
							goto IL_0033;
						}
						this.NetworkOnly = input.ReadBool();
					}
					else
					{
						this.Time = input.ReadFixed64();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							goto IL_0033;
						}
						this.ForwardClientId = input.ReadString();
					}
					else
					{
						bool flag = this.forward_ == null;
						if (flag)
						{
							this.Forward = new ProcessId();
						}
						input.ReadMessage(this.Forward);
					}
				}
				else
				{
					this.Payload = input.ReadBytes();
				}
				continue;
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400300F RID: 12303
		private static readonly MessageParser<EchoRequest> _parser = new MessageParser<EchoRequest>(() => new EchoRequest());

		// Token: 0x04003010 RID: 12304
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003011 RID: 12305
		private int _hasBits0;

		// Token: 0x04003012 RID: 12306
		public const int TimeFieldNumber = 1;

		// Token: 0x04003013 RID: 12307
		private static readonly ulong TimeDefaultValue = 0UL;

		// Token: 0x04003014 RID: 12308
		private ulong time_;

		// Token: 0x04003015 RID: 12309
		public const int NetworkOnlyFieldNumber = 2;

		// Token: 0x04003016 RID: 12310
		private static readonly bool NetworkOnlyDefaultValue = false;

		// Token: 0x04003017 RID: 12311
		private bool networkOnly_;

		// Token: 0x04003018 RID: 12312
		public const int PayloadFieldNumber = 3;

		// Token: 0x04003019 RID: 12313
		private static readonly ByteString PayloadDefaultValue = ByteString.Empty;

		// Token: 0x0400301A RID: 12314
		private ByteString payload_;

		// Token: 0x0400301B RID: 12315
		public const int ForwardFieldNumber = 4;

		// Token: 0x0400301C RID: 12316
		private ProcessId forward_;

		// Token: 0x0400301D RID: 12317
		public const int ForwardClientIdFieldNumber = 5;

		// Token: 0x0400301E RID: 12318
		private static readonly string ForwardClientIdDefaultValue = "";

		// Token: 0x0400301F RID: 12319
		private string forwardClientId_;
	}
}
