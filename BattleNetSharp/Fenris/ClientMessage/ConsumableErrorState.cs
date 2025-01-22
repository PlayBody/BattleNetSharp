using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200029B RID: 667
	public sealed class ConsumableErrorState : IMessage<ConsumableErrorState>, IMessage, IEquatable<ConsumableErrorState>, IDeepCloneable<ConsumableErrorState>, IBufferMessage
	{
		// Token: 0x1700165A RID: 5722
		// (get) Token: 0x060046A1 RID: 18081 RVA: 0x0010E388 File Offset: 0x0010C588
		[DebuggerNonUserCode]
		public static MessageParser<ConsumableErrorState> Parser
		{
			get
			{
				return ConsumableErrorState._parser;
			}
		}

		// Token: 0x1700165B RID: 5723
		// (get) Token: 0x060046A2 RID: 18082 RVA: 0x0010E3A0 File Offset: 0x0010C5A0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[139];
			}
		}

		// Token: 0x1700165C RID: 5724
		// (get) Token: 0x060046A3 RID: 18083 RVA: 0x0010E3C8 File Offset: 0x0010C5C8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsumableErrorState.Descriptor;
			}
		}

		// Token: 0x060046A4 RID: 18084 RVA: 0x0010E3DF File Offset: 0x0010C5DF
		[DebuggerNonUserCode]
		public ConsumableErrorState()
		{
		}

		// Token: 0x060046A5 RID: 18085 RVA: 0x0010E3EC File Offset: 0x0010C5EC
		[DebuggerNonUserCode]
		public ConsumableErrorState(ConsumableErrorState other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.voucherSno_ = other.voucherSno_;
			this.orderId_ = other.orderId_;
			this.errorCode_ = other.errorCode_;
			this.productId_ = other.productId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060046A6 RID: 18086 RVA: 0x0010E450 File Offset: 0x0010C650
		[DebuggerNonUserCode]
		public ConsumableErrorState Clone()
		{
			return new ConsumableErrorState(this);
		}

		// Token: 0x1700165D RID: 5725
		// (get) Token: 0x060046A7 RID: 18087 RVA: 0x0010E468 File Offset: 0x0010C668
		// (set) Token: 0x060046A8 RID: 18088 RVA: 0x0010E499 File Offset: 0x0010C699
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
					voucherSnoDefaultValue = ConsumableErrorState.VoucherSnoDefaultValue;
				}
				return voucherSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.voucherSno_ = value;
			}
		}

		// Token: 0x1700165E RID: 5726
		// (get) Token: 0x060046A9 RID: 18089 RVA: 0x0010E4B4 File Offset: 0x0010C6B4
		[DebuggerNonUserCode]
		public bool HasVoucherSno
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060046AA RID: 18090 RVA: 0x0010E4D1 File Offset: 0x0010C6D1
		[DebuggerNonUserCode]
		public void ClearVoucherSno()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700165F RID: 5727
		// (get) Token: 0x060046AB RID: 18091 RVA: 0x0010E4E4 File Offset: 0x0010C6E4
		// (set) Token: 0x060046AC RID: 18092 RVA: 0x0010E505 File Offset: 0x0010C705
		[DebuggerNonUserCode]
		public string OrderId
		{
			get
			{
				return this.orderId_ ?? ConsumableErrorState.OrderIdDefaultValue;
			}
			set
			{
				this.orderId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001660 RID: 5728
		// (get) Token: 0x060046AD RID: 18093 RVA: 0x0010E51C File Offset: 0x0010C71C
		[DebuggerNonUserCode]
		public bool HasOrderId
		{
			get
			{
				return this.orderId_ != null;
			}
		}

		// Token: 0x060046AE RID: 18094 RVA: 0x0010E537 File Offset: 0x0010C737
		[DebuggerNonUserCode]
		public void ClearOrderId()
		{
			this.orderId_ = null;
		}

		// Token: 0x17001661 RID: 5729
		// (get) Token: 0x060046AF RID: 18095 RVA: 0x0010E544 File Offset: 0x0010C744
		// (set) Token: 0x060046B0 RID: 18096 RVA: 0x0010E575 File Offset: 0x0010C775
		[DebuggerNonUserCode]
		public uint ErrorCode
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint errorCodeDefaultValue;
				if (flag)
				{
					errorCodeDefaultValue = this.errorCode_;
				}
				else
				{
					errorCodeDefaultValue = ConsumableErrorState.ErrorCodeDefaultValue;
				}
				return errorCodeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.errorCode_ = value;
			}
		}

		// Token: 0x17001662 RID: 5730
		// (get) Token: 0x060046B1 RID: 18097 RVA: 0x0010E590 File Offset: 0x0010C790
		[DebuggerNonUserCode]
		public bool HasErrorCode
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060046B2 RID: 18098 RVA: 0x0010E5AD File Offset: 0x0010C7AD
		[DebuggerNonUserCode]
		public void ClearErrorCode()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001663 RID: 5731
		// (get) Token: 0x060046B3 RID: 18099 RVA: 0x0010E5C0 File Offset: 0x0010C7C0
		// (set) Token: 0x060046B4 RID: 18100 RVA: 0x0010E5F1 File Offset: 0x0010C7F1
		[DebuggerNonUserCode]
		public ulong ProductId
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong productIdDefaultValue;
				if (flag)
				{
					productIdDefaultValue = this.productId_;
				}
				else
				{
					productIdDefaultValue = ConsumableErrorState.ProductIdDefaultValue;
				}
				return productIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.productId_ = value;
			}
		}

		// Token: 0x17001664 RID: 5732
		// (get) Token: 0x060046B5 RID: 18101 RVA: 0x0010E60C File Offset: 0x0010C80C
		[DebuggerNonUserCode]
		public bool HasProductId
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060046B6 RID: 18102 RVA: 0x0010E629 File Offset: 0x0010C829
		[DebuggerNonUserCode]
		public void ClearProductId()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x060046B7 RID: 18103 RVA: 0x0010E63C File Offset: 0x0010C83C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsumableErrorState);
		}

		// Token: 0x060046B8 RID: 18104 RVA: 0x0010E65C File Offset: 0x0010C85C
		[DebuggerNonUserCode]
		public bool Equals(ConsumableErrorState other)
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
					bool flag4 = this.VoucherSno != other.VoucherSno;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.OrderId != other.OrderId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ErrorCode != other.ErrorCode;
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

		// Token: 0x060046B9 RID: 18105 RVA: 0x0010E708 File Offset: 0x0010C908
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasVoucherSno = this.HasVoucherSno;
			if (hasVoucherSno)
			{
				num ^= this.VoucherSno.GetHashCode();
			}
			bool hasOrderId = this.HasOrderId;
			if (hasOrderId)
			{
				num ^= this.OrderId.GetHashCode();
			}
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				num ^= this.ErrorCode.GetHashCode();
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

		// Token: 0x060046BA RID: 18106 RVA: 0x0010E7B0 File Offset: 0x0010C9B0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060046BB RID: 18107 RVA: 0x0010E7C8 File Offset: 0x0010C9C8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060046BC RID: 18108 RVA: 0x0010E7D4 File Offset: 0x0010C9D4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasVoucherSno = this.HasVoucherSno;
			if (hasVoucherSno)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.VoucherSno);
			}
			bool hasOrderId = this.HasOrderId;
			if (hasOrderId)
			{
				output.WriteRawTag(18);
				output.WriteString(this.OrderId);
			}
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.ErrorCode);
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

		// Token: 0x060046BD RID: 18109 RVA: 0x0010E888 File Offset: 0x0010CA88
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasVoucherSno = this.HasVoucherSno;
			if (hasVoucherSno)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.VoucherSno);
			}
			bool hasOrderId = this.HasOrderId;
			if (hasOrderId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.OrderId);
			}
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ErrorCode);
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

		// Token: 0x060046BE RID: 18110 RVA: 0x0010E930 File Offset: 0x0010CB30
		[DebuggerNonUserCode]
		public void MergeFrom(ConsumableErrorState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasVoucherSno = other.HasVoucherSno;
				if (hasVoucherSno)
				{
					this.VoucherSno = other.VoucherSno;
				}
				bool hasOrderId = other.HasOrderId;
				if (hasOrderId)
				{
					this.OrderId = other.OrderId;
				}
				bool hasErrorCode = other.HasErrorCode;
				if (hasErrorCode)
				{
					this.ErrorCode = other.ErrorCode;
				}
				bool hasProductId = other.HasProductId;
				if (hasProductId)
				{
					this.ProductId = other.ProductId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060046BF RID: 18111 RVA: 0x0010E9C6 File Offset: 0x0010CBC6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060046C0 RID: 18112 RVA: 0x0010E9D4 File Offset: 0x0010CBD4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 8U)
					{
						if (num3 != 18U)
						{
							goto IL_0028;
						}
						this.OrderId = input.ReadString();
					}
					else
					{
						this.VoucherSno = input.ReadInt32();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_0028;
					}
					this.ProductId = input.ReadUInt64();
				}
				else
				{
					this.ErrorCode = input.ReadUInt32();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001F62 RID: 8034
		private static readonly MessageParser<ConsumableErrorState> _parser = new MessageParser<ConsumableErrorState>(() => new ConsumableErrorState());

		// Token: 0x04001F63 RID: 8035
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F64 RID: 8036
		private int _hasBits0;

		// Token: 0x04001F65 RID: 8037
		public const int VoucherSnoFieldNumber = 1;

		// Token: 0x04001F66 RID: 8038
		private static readonly int VoucherSnoDefaultValue = -1;

		// Token: 0x04001F67 RID: 8039
		private int voucherSno_;

		// Token: 0x04001F68 RID: 8040
		public const int OrderIdFieldNumber = 2;

		// Token: 0x04001F69 RID: 8041
		private static readonly string OrderIdDefaultValue = "";

		// Token: 0x04001F6A RID: 8042
		private string orderId_;

		// Token: 0x04001F6B RID: 8043
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04001F6C RID: 8044
		private static readonly uint ErrorCodeDefaultValue = 0U;

		// Token: 0x04001F6D RID: 8045
		private uint errorCode_;

		// Token: 0x04001F6E RID: 8046
		public const int ProductIdFieldNumber = 4;

		// Token: 0x04001F6F RID: 8047
		private static readonly ulong ProductIdDefaultValue = 0UL;

		// Token: 0x04001F70 RID: 8048
		private ulong productId_;
	}
}
