using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200029A RID: 666
	public sealed class ConsumeConsoleEntitlementsRequest : IMessage<ConsumeConsoleEntitlementsRequest>, IMessage, IEquatable<ConsumeConsoleEntitlementsRequest>, IDeepCloneable<ConsumeConsoleEntitlementsRequest>, IBufferMessage
	{
		// Token: 0x1700164F RID: 5711
		// (get) Token: 0x06004680 RID: 18048 RVA: 0x0010DC80 File Offset: 0x0010BE80
		[DebuggerNonUserCode]
		public static MessageParser<ConsumeConsoleEntitlementsRequest> Parser
		{
			get
			{
				return ConsumeConsoleEntitlementsRequest._parser;
			}
		}

		// Token: 0x17001650 RID: 5712
		// (get) Token: 0x06004681 RID: 18049 RVA: 0x0010DC98 File Offset: 0x0010BE98
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[138];
			}
		}

		// Token: 0x17001651 RID: 5713
		// (get) Token: 0x06004682 RID: 18050 RVA: 0x0010DCC0 File Offset: 0x0010BEC0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsumeConsoleEntitlementsRequest.Descriptor;
			}
		}

		// Token: 0x06004683 RID: 18051 RVA: 0x0010DCD7 File Offset: 0x0010BED7
		[DebuggerNonUserCode]
		public ConsumeConsoleEntitlementsRequest()
		{
		}

		// Token: 0x06004684 RID: 18052 RVA: 0x0010DCE4 File Offset: 0x0010BEE4
		[DebuggerNonUserCode]
		public ConsumeConsoleEntitlementsRequest(ConsumeConsoleEntitlementsRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.sessionKey_ = other.sessionKey_;
			this.voucherSno_ = other.voucherSno_;
			this.instanceId_ = other.instanceId_;
			this.productId_ = other.productId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004685 RID: 18053 RVA: 0x0010DD48 File Offset: 0x0010BF48
		[DebuggerNonUserCode]
		public ConsumeConsoleEntitlementsRequest Clone()
		{
			return new ConsumeConsoleEntitlementsRequest(this);
		}

		// Token: 0x17001652 RID: 5714
		// (get) Token: 0x06004686 RID: 18054 RVA: 0x0010DD60 File Offset: 0x0010BF60
		// (set) Token: 0x06004687 RID: 18055 RVA: 0x0010DD81 File Offset: 0x0010BF81
		[DebuggerNonUserCode]
		public ByteString SessionKey
		{
			get
			{
				return this.sessionKey_ ?? ConsumeConsoleEntitlementsRequest.SessionKeyDefaultValue;
			}
			set
			{
				this.sessionKey_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17001653 RID: 5715
		// (get) Token: 0x06004688 RID: 18056 RVA: 0x0010DD98 File Offset: 0x0010BF98
		[DebuggerNonUserCode]
		public bool HasSessionKey
		{
			get
			{
				return this.sessionKey_ != null;
			}
		}

		// Token: 0x06004689 RID: 18057 RVA: 0x0010DDB6 File Offset: 0x0010BFB6
		[DebuggerNonUserCode]
		public void ClearSessionKey()
		{
			this.sessionKey_ = null;
		}

		// Token: 0x17001654 RID: 5716
		// (get) Token: 0x0600468A RID: 18058 RVA: 0x0010DDC0 File Offset: 0x0010BFC0
		// (set) Token: 0x0600468B RID: 18059 RVA: 0x0010DDF1 File Offset: 0x0010BFF1
		[DebuggerNonUserCode]
		public int VoucherSno
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int voucherSnoDefaultValue;
				if (flag)
				{
					voucherSnoDefaultValue = this.voucherSno_;
				}
				else
				{
					voucherSnoDefaultValue = ConsumeConsoleEntitlementsRequest.VoucherSnoDefaultValue;
				}
				return voucherSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.voucherSno_ = value;
			}
		}

		// Token: 0x17001655 RID: 5717
		// (get) Token: 0x0600468C RID: 18060 RVA: 0x0010DE0C File Offset: 0x0010C00C
		[DebuggerNonUserCode]
		public bool HasVoucherSno
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600468D RID: 18061 RVA: 0x0010DE29 File Offset: 0x0010C029
		[DebuggerNonUserCode]
		public void ClearVoucherSno()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001656 RID: 5718
		// (get) Token: 0x0600468E RID: 18062 RVA: 0x0010DE3C File Offset: 0x0010C03C
		// (set) Token: 0x0600468F RID: 18063 RVA: 0x0010DE5D File Offset: 0x0010C05D
		[DebuggerNonUserCode]
		public string InstanceId
		{
			get
			{
				return this.instanceId_ ?? ConsumeConsoleEntitlementsRequest.InstanceIdDefaultValue;
			}
			set
			{
				this.instanceId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001657 RID: 5719
		// (get) Token: 0x06004690 RID: 18064 RVA: 0x0010DE74 File Offset: 0x0010C074
		[DebuggerNonUserCode]
		public bool HasInstanceId
		{
			get
			{
				return this.instanceId_ != null;
			}
		}

		// Token: 0x06004691 RID: 18065 RVA: 0x0010DE8F File Offset: 0x0010C08F
		[DebuggerNonUserCode]
		public void ClearInstanceId()
		{
			this.instanceId_ = null;
		}

		// Token: 0x17001658 RID: 5720
		// (get) Token: 0x06004692 RID: 18066 RVA: 0x0010DE9C File Offset: 0x0010C09C
		// (set) Token: 0x06004693 RID: 18067 RVA: 0x0010DECD File Offset: 0x0010C0CD
		[DebuggerNonUserCode]
		public ulong ProductId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong productIdDefaultValue;
				if (flag)
				{
					productIdDefaultValue = this.productId_;
				}
				else
				{
					productIdDefaultValue = ConsumeConsoleEntitlementsRequest.ProductIdDefaultValue;
				}
				return productIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.productId_ = value;
			}
		}

		// Token: 0x17001659 RID: 5721
		// (get) Token: 0x06004694 RID: 18068 RVA: 0x0010DEE8 File Offset: 0x0010C0E8
		[DebuggerNonUserCode]
		public bool HasProductId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004695 RID: 18069 RVA: 0x0010DF05 File Offset: 0x0010C105
		[DebuggerNonUserCode]
		public void ClearProductId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06004696 RID: 18070 RVA: 0x0010DF18 File Offset: 0x0010C118
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsumeConsoleEntitlementsRequest);
		}

		// Token: 0x06004697 RID: 18071 RVA: 0x0010DF38 File Offset: 0x0010C138
		[DebuggerNonUserCode]
		public bool Equals(ConsumeConsoleEntitlementsRequest other)
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
					bool flag4 = this.SessionKey != other.SessionKey;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.VoucherSno != other.VoucherSno;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.InstanceId != other.InstanceId;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.ProductId != other.ProductId;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004698 RID: 18072 RVA: 0x0010DFE4 File Offset: 0x0010C1E4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num ^= this.SessionKey.GetHashCode();
			}
			bool hasVoucherSno = this.HasVoucherSno;
			if (hasVoucherSno)
			{
				num ^= this.VoucherSno.GetHashCode();
			}
			bool hasInstanceId = this.HasInstanceId;
			if (hasInstanceId)
			{
				num ^= this.InstanceId.GetHashCode();
			}
			bool hasProductId = this.HasProductId;
			if (hasProductId)
			{
				num ^= this.ProductId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004699 RID: 18073 RVA: 0x0010E088 File Offset: 0x0010C288
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600469A RID: 18074 RVA: 0x0010E0A0 File Offset: 0x0010C2A0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600469B RID: 18075 RVA: 0x0010E0AC File Offset: 0x0010C2AC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				output.WriteRawTag(10);
				output.WriteBytes(this.SessionKey);
			}
			bool hasVoucherSno = this.HasVoucherSno;
			if (hasVoucherSno)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.VoucherSno);
			}
			bool hasInstanceId = this.HasInstanceId;
			if (hasInstanceId)
			{
				output.WriteRawTag(26);
				output.WriteString(this.InstanceId);
			}
			bool hasProductId = this.HasProductId;
			if (hasProductId)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.ProductId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600469C RID: 18076 RVA: 0x0010E160 File Offset: 0x0010C360
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.SessionKey);
			}
			bool hasVoucherSno = this.HasVoucherSno;
			if (hasVoucherSno)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.VoucherSno);
			}
			bool hasInstanceId = this.HasInstanceId;
			if (hasInstanceId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.InstanceId);
			}
			bool hasProductId = this.HasProductId;
			if (hasProductId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ProductId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600469D RID: 18077 RVA: 0x0010E208 File Offset: 0x0010C408
		[DebuggerNonUserCode]
		public void MergeFrom(ConsumeConsoleEntitlementsRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSessionKey = other.HasSessionKey;
				if (hasSessionKey)
				{
					this.SessionKey = other.SessionKey;
				}
				bool hasVoucherSno = other.HasVoucherSno;
				if (hasVoucherSno)
				{
					this.VoucherSno = other.VoucherSno;
				}
				bool hasInstanceId = other.HasInstanceId;
				if (hasInstanceId)
				{
					this.InstanceId = other.InstanceId;
				}
				bool hasProductId = other.HasProductId;
				if (hasProductId)
				{
					this.ProductId = other.ProductId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600469E RID: 18078 RVA: 0x0010E29E File Offset: 0x0010C49E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600469F RID: 18079 RVA: 0x0010E2AC File Offset: 0x0010C4AC
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
					if (num3 != 10U)
					{
						if (num3 != 16U)
						{
							goto IL_0029;
						}
						this.VoucherSno = input.ReadInt32();
					}
					else
					{
						this.SessionKey = input.ReadBytes();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 32U)
					{
						goto IL_0029;
					}
					this.ProductId = input.ReadUInt64();
				}
				else
				{
					this.InstanceId = input.ReadString();
				}
				continue;
				IL_0029:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001F53 RID: 8019
		private static readonly MessageParser<ConsumeConsoleEntitlementsRequest> _parser = new MessageParser<ConsumeConsoleEntitlementsRequest>(() => new ConsumeConsoleEntitlementsRequest());

		// Token: 0x04001F54 RID: 8020
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F55 RID: 8021
		private int _hasBits0;

		// Token: 0x04001F56 RID: 8022
		public const int SessionKeyFieldNumber = 1;

		// Token: 0x04001F57 RID: 8023
		private static readonly ByteString SessionKeyDefaultValue = ByteString.Empty;

		// Token: 0x04001F58 RID: 8024
		private ByteString sessionKey_;

		// Token: 0x04001F59 RID: 8025
		public const int VoucherSnoFieldNumber = 2;

		// Token: 0x04001F5A RID: 8026
		private static readonly int VoucherSnoDefaultValue = -1;

		// Token: 0x04001F5B RID: 8027
		private int voucherSno_;

		// Token: 0x04001F5C RID: 8028
		public const int InstanceIdFieldNumber = 3;

		// Token: 0x04001F5D RID: 8029
		private static readonly string InstanceIdDefaultValue = "";

		// Token: 0x04001F5E RID: 8030
		private string instanceId_;

		// Token: 0x04001F5F RID: 8031
		public const int ProductIdFieldNumber = 4;

		// Token: 0x04001F60 RID: 8032
		private static readonly ulong ProductIdDefaultValue = 0UL;

		// Token: 0x04001F61 RID: 8033
		private ulong productId_;
	}
}
