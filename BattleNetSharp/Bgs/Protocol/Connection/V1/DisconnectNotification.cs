using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Connection.V1
{
	// Token: 0x02000435 RID: 1077
	public sealed class DisconnectNotification : IMessage<DisconnectNotification>, IMessage, IEquatable<DisconnectNotification>, IDeepCloneable<DisconnectNotification>, IBufferMessage
	{
		// Token: 0x170021D3 RID: 8659
		// (get) Token: 0x060069E2 RID: 27106 RVA: 0x00199C24 File Offset: 0x00197E24
		[DebuggerNonUserCode]
		public static MessageParser<DisconnectNotification> Parser
		{
			get
			{
				return DisconnectNotification._parser;
			}
		}

		// Token: 0x170021D4 RID: 8660
		// (get) Token: 0x060069E3 RID: 27107 RVA: 0x00199C3C File Offset: 0x00197E3C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ConnectionServiceReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x170021D5 RID: 8661
		// (get) Token: 0x060069E4 RID: 27108 RVA: 0x00199C60 File Offset: 0x00197E60
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DisconnectNotification.Descriptor;
			}
		}

		// Token: 0x060069E5 RID: 27109 RVA: 0x00199C77 File Offset: 0x00197E77
		[DebuggerNonUserCode]
		public DisconnectNotification()
		{
		}

		// Token: 0x060069E6 RID: 27110 RVA: 0x00199C81 File Offset: 0x00197E81
		[DebuggerNonUserCode]
		public DisconnectNotification(DisconnectNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.errorCode_ = other.errorCode_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060069E7 RID: 27111 RVA: 0x00199CC0 File Offset: 0x00197EC0
		[DebuggerNonUserCode]
		public DisconnectNotification Clone()
		{
			return new DisconnectNotification(this);
		}

		// Token: 0x170021D6 RID: 8662
		// (get) Token: 0x060069E8 RID: 27112 RVA: 0x00199CD8 File Offset: 0x00197ED8
		// (set) Token: 0x060069E9 RID: 27113 RVA: 0x00199D09 File Offset: 0x00197F09
		[DebuggerNonUserCode]
		public uint ErrorCode
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint errorCodeDefaultValue;
				if (flag)
				{
					errorCodeDefaultValue = this.errorCode_;
				}
				else
				{
					errorCodeDefaultValue = DisconnectNotification.ErrorCodeDefaultValue;
				}
				return errorCodeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.errorCode_ = value;
			}
		}

		// Token: 0x170021D7 RID: 8663
		// (get) Token: 0x060069EA RID: 27114 RVA: 0x00199D24 File Offset: 0x00197F24
		[DebuggerNonUserCode]
		public bool HasErrorCode
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060069EB RID: 27115 RVA: 0x00199D41 File Offset: 0x00197F41
		[DebuggerNonUserCode]
		public void ClearErrorCode()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170021D8 RID: 8664
		// (get) Token: 0x060069EC RID: 27116 RVA: 0x00199D54 File Offset: 0x00197F54
		// (set) Token: 0x060069ED RID: 27117 RVA: 0x00199D75 File Offset: 0x00197F75
		[DebuggerNonUserCode]
		public string Reason
		{
			get
			{
				return this.reason_ ?? DisconnectNotification.ReasonDefaultValue;
			}
			set
			{
				this.reason_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170021D9 RID: 8665
		// (get) Token: 0x060069EE RID: 27118 RVA: 0x00199D8C File Offset: 0x00197F8C
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return this.reason_ != null;
			}
		}

		// Token: 0x060069EF RID: 27119 RVA: 0x00199DA7 File Offset: 0x00197FA7
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this.reason_ = null;
		}

		// Token: 0x060069F0 RID: 27120 RVA: 0x00199DB4 File Offset: 0x00197FB4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DisconnectNotification);
		}

		// Token: 0x060069F1 RID: 27121 RVA: 0x00199DD4 File Offset: 0x00197FD4
		[DebuggerNonUserCode]
		public bool Equals(DisconnectNotification other)
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
					bool flag4 = this.ErrorCode != other.ErrorCode;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Reason != other.Reason;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060069F2 RID: 27122 RVA: 0x00199E48 File Offset: 0x00198048
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num ^= this.Reason.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060069F3 RID: 27123 RVA: 0x00199EB4 File Offset: 0x001980B4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060069F4 RID: 27124 RVA: 0x00199ECC File Offset: 0x001980CC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060069F5 RID: 27125 RVA: 0x00199ED8 File Offset: 0x001980D8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ErrorCode);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Reason);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060069F6 RID: 27126 RVA: 0x00199F48 File Offset: 0x00198148
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ErrorCode);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Reason);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060069F7 RID: 27127 RVA: 0x00199FB4 File Offset: 0x001981B4
		[DebuggerNonUserCode]
		public void MergeFrom(DisconnectNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasErrorCode = other.HasErrorCode;
				if (hasErrorCode)
				{
					this.ErrorCode = other.ErrorCode;
				}
				bool hasReason = other.HasReason;
				if (hasReason)
				{
					this.Reason = other.Reason;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060069F8 RID: 27128 RVA: 0x0019A016 File Offset: 0x00198216
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060069F9 RID: 27129 RVA: 0x0019A024 File Offset: 0x00198224
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Reason = input.ReadString();
					}
				}
				else
				{
					this.ErrorCode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400302F RID: 12335
		private static readonly MessageParser<DisconnectNotification> _parser = new MessageParser<DisconnectNotification>(() => new DisconnectNotification());

		// Token: 0x04003030 RID: 12336
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003031 RID: 12337
		private int _hasBits0;

		// Token: 0x04003032 RID: 12338
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04003033 RID: 12339
		private static readonly uint ErrorCodeDefaultValue = 0U;

		// Token: 0x04003034 RID: 12340
		private uint errorCode_;

		// Token: 0x04003035 RID: 12341
		public const int ReasonFieldNumber = 2;

		// Token: 0x04003036 RID: 12342
		private static readonly string ReasonDefaultValue = "";

		// Token: 0x04003037 RID: 12343
		private string reason_;
	}
}
