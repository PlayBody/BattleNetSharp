using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Connection.V1
{
	// Token: 0x02000433 RID: 1075
	public sealed class EchoResponse : IMessage<EchoResponse>, IMessage, IEquatable<EchoResponse>, IDeepCloneable<EchoResponse>, IBufferMessage
	{
		// Token: 0x170021C7 RID: 8647
		// (get) Token: 0x060069B4 RID: 27060 RVA: 0x00199424 File Offset: 0x00197624
		[DebuggerNonUserCode]
		public static MessageParser<EchoResponse> Parser
		{
			get
			{
				return EchoResponse._parser;
			}
		}

		// Token: 0x170021C8 RID: 8648
		// (get) Token: 0x060069B5 RID: 27061 RVA: 0x0019943C File Offset: 0x0019763C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ConnectionServiceReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x170021C9 RID: 8649
		// (get) Token: 0x060069B6 RID: 27062 RVA: 0x00199460 File Offset: 0x00197660
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EchoResponse.Descriptor;
			}
		}

		// Token: 0x060069B7 RID: 27063 RVA: 0x00199477 File Offset: 0x00197677
		[DebuggerNonUserCode]
		public EchoResponse()
		{
		}

		// Token: 0x060069B8 RID: 27064 RVA: 0x00199481 File Offset: 0x00197681
		[DebuggerNonUserCode]
		public EchoResponse(EchoResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.time_ = other.time_;
			this.payload_ = other.payload_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060069B9 RID: 27065 RVA: 0x001994C0 File Offset: 0x001976C0
		[DebuggerNonUserCode]
		public EchoResponse Clone()
		{
			return new EchoResponse(this);
		}

		// Token: 0x170021CA RID: 8650
		// (get) Token: 0x060069BA RID: 27066 RVA: 0x001994D8 File Offset: 0x001976D8
		// (set) Token: 0x060069BB RID: 27067 RVA: 0x00199509 File Offset: 0x00197709
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
					timeDefaultValue = EchoResponse.TimeDefaultValue;
				}
				return timeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.time_ = value;
			}
		}

		// Token: 0x170021CB RID: 8651
		// (get) Token: 0x060069BC RID: 27068 RVA: 0x00199524 File Offset: 0x00197724
		[DebuggerNonUserCode]
		public bool HasTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060069BD RID: 27069 RVA: 0x00199541 File Offset: 0x00197741
		[DebuggerNonUserCode]
		public void ClearTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170021CC RID: 8652
		// (get) Token: 0x060069BE RID: 27070 RVA: 0x00199554 File Offset: 0x00197754
		// (set) Token: 0x060069BF RID: 27071 RVA: 0x00199575 File Offset: 0x00197775
		[DebuggerNonUserCode]
		public ByteString Payload
		{
			get
			{
				return this.payload_ ?? EchoResponse.PayloadDefaultValue;
			}
			set
			{
				this.payload_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x170021CD RID: 8653
		// (get) Token: 0x060069C0 RID: 27072 RVA: 0x0019958C File Offset: 0x0019778C
		[DebuggerNonUserCode]
		public bool HasPayload
		{
			get
			{
				return this.payload_ != null;
			}
		}

		// Token: 0x060069C1 RID: 27073 RVA: 0x001995AA File Offset: 0x001977AA
		[DebuggerNonUserCode]
		public void ClearPayload()
		{
			this.payload_ = null;
		}

		// Token: 0x060069C2 RID: 27074 RVA: 0x001995B4 File Offset: 0x001977B4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EchoResponse);
		}

		// Token: 0x060069C3 RID: 27075 RVA: 0x001995D4 File Offset: 0x001977D4
		[DebuggerNonUserCode]
		public bool Equals(EchoResponse other)
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
						bool flag5 = this.Payload != other.Payload;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060069C4 RID: 27076 RVA: 0x00199648 File Offset: 0x00197848
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTime = this.HasTime;
			if (hasTime)
			{
				num ^= this.Time.GetHashCode();
			}
			bool hasPayload = this.HasPayload;
			if (hasPayload)
			{
				num ^= this.Payload.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060069C5 RID: 27077 RVA: 0x001996B4 File Offset: 0x001978B4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060069C6 RID: 27078 RVA: 0x001996CC File Offset: 0x001978CC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060069C7 RID: 27079 RVA: 0x001996D8 File Offset: 0x001978D8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTime = this.HasTime;
			if (hasTime)
			{
				output.WriteRawTag(9);
				output.WriteFixed64(this.Time);
			}
			bool hasPayload = this.HasPayload;
			if (hasPayload)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.Payload);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060069C8 RID: 27080 RVA: 0x00199748 File Offset: 0x00197948
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTime = this.HasTime;
			if (hasTime)
			{
				num += 9;
			}
			bool hasPayload = this.HasPayload;
			if (hasPayload)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Payload);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060069C9 RID: 27081 RVA: 0x001997AC File Offset: 0x001979AC
		[DebuggerNonUserCode]
		public void MergeFrom(EchoResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTime = other.HasTime;
				if (hasTime)
				{
					this.Time = other.Time;
				}
				bool hasPayload = other.HasPayload;
				if (hasPayload)
				{
					this.Payload = other.Payload;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060069CA RID: 27082 RVA: 0x0019980E File Offset: 0x00197A0E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060069CB RID: 27083 RVA: 0x0019981C File Offset: 0x00197A1C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 9U)
				{
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Payload = input.ReadBytes();
					}
				}
				else
				{
					this.Time = input.ReadFixed64();
				}
			}
		}

		// Token: 0x04003020 RID: 12320
		private static readonly MessageParser<EchoResponse> _parser = new MessageParser<EchoResponse>(() => new EchoResponse());

		// Token: 0x04003021 RID: 12321
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003022 RID: 12322
		private int _hasBits0;

		// Token: 0x04003023 RID: 12323
		public const int TimeFieldNumber = 1;

		// Token: 0x04003024 RID: 12324
		private static readonly ulong TimeDefaultValue = 0UL;

		// Token: 0x04003025 RID: 12325
		private ulong time_;

		// Token: 0x04003026 RID: 12326
		public const int PayloadFieldNumber = 2;

		// Token: 0x04003027 RID: 12327
		private static readonly ByteString PayloadDefaultValue = ByteString.Empty;

		// Token: 0x04003028 RID: 12328
		private ByteString payload_;
	}
}
