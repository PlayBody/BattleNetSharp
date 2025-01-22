using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Account
{
	// Token: 0x020002D3 RID: 723
	public sealed class Consumable : IMessage<Consumable>, IMessage, IEquatable<Consumable>, IDeepCloneable<Consumable>, IBufferMessage
	{
		// Token: 0x1700184A RID: 6218
		// (get) Token: 0x06004C7D RID: 19581 RVA: 0x00124BE8 File Offset: 0x00122DE8
		[DebuggerNonUserCode]
		public static MessageParser<Consumable> Parser
		{
			get
			{
				return Consumable._parser;
			}
		}

		// Token: 0x1700184B RID: 6219
		// (get) Token: 0x06004C7E RID: 19582 RVA: 0x00124C00 File Offset: 0x00122E00
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x1700184C RID: 6220
		// (get) Token: 0x06004C7F RID: 19583 RVA: 0x00124C24 File Offset: 0x00122E24
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Consumable.Descriptor;
			}
		}

		// Token: 0x06004C80 RID: 19584 RVA: 0x00124C3B File Offset: 0x00122E3B
		[DebuggerNonUserCode]
		public Consumable()
		{
		}

		// Token: 0x06004C81 RID: 19585 RVA: 0x00124C45 File Offset: 0x00122E45
		[DebuggerNonUserCode]
		public Consumable(Consumable other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.bnetConsumableId_ = other.bnetConsumableId_;
			this.statusId_ = other.statusId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004C82 RID: 19586 RVA: 0x00124C84 File Offset: 0x00122E84
		[DebuggerNonUserCode]
		public Consumable Clone()
		{
			return new Consumable(this);
		}

		// Token: 0x1700184D RID: 6221
		// (get) Token: 0x06004C83 RID: 19587 RVA: 0x00124C9C File Offset: 0x00122E9C
		// (set) Token: 0x06004C84 RID: 19588 RVA: 0x00124CCD File Offset: 0x00122ECD
		[DebuggerNonUserCode]
		public long BnetConsumableId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				long bnetConsumableIdDefaultValue;
				if (flag)
				{
					bnetConsumableIdDefaultValue = this.bnetConsumableId_;
				}
				else
				{
					bnetConsumableIdDefaultValue = Consumable.BnetConsumableIdDefaultValue;
				}
				return bnetConsumableIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.bnetConsumableId_ = value;
			}
		}

		// Token: 0x1700184E RID: 6222
		// (get) Token: 0x06004C85 RID: 19589 RVA: 0x00124CE8 File Offset: 0x00122EE8
		[DebuggerNonUserCode]
		public bool HasBnetConsumableId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004C86 RID: 19590 RVA: 0x00124D05 File Offset: 0x00122F05
		[DebuggerNonUserCode]
		public void ClearBnetConsumableId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700184F RID: 6223
		// (get) Token: 0x06004C87 RID: 19591 RVA: 0x00124D18 File Offset: 0x00122F18
		// (set) Token: 0x06004C88 RID: 19592 RVA: 0x00124D49 File Offset: 0x00122F49
		[DebuggerNonUserCode]
		public int StatusId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int statusIdDefaultValue;
				if (flag)
				{
					statusIdDefaultValue = this.statusId_;
				}
				else
				{
					statusIdDefaultValue = Consumable.StatusIdDefaultValue;
				}
				return statusIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.statusId_ = value;
			}
		}

		// Token: 0x17001850 RID: 6224
		// (get) Token: 0x06004C89 RID: 19593 RVA: 0x00124D64 File Offset: 0x00122F64
		[DebuggerNonUserCode]
		public bool HasStatusId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004C8A RID: 19594 RVA: 0x00124D81 File Offset: 0x00122F81
		[DebuggerNonUserCode]
		public void ClearStatusId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06004C8B RID: 19595 RVA: 0x00124D94 File Offset: 0x00122F94
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Consumable);
		}

		// Token: 0x06004C8C RID: 19596 RVA: 0x00124DB4 File Offset: 0x00122FB4
		[DebuggerNonUserCode]
		public bool Equals(Consumable other)
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
					bool flag4 = this.BnetConsumableId != other.BnetConsumableId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.StatusId != other.StatusId;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004C8D RID: 19597 RVA: 0x00124E28 File Offset: 0x00123028
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasBnetConsumableId = this.HasBnetConsumableId;
			if (hasBnetConsumableId)
			{
				num ^= this.BnetConsumableId.GetHashCode();
			}
			bool hasStatusId = this.HasStatusId;
			if (hasStatusId)
			{
				num ^= this.StatusId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004C8E RID: 19598 RVA: 0x00124E98 File Offset: 0x00123098
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004C8F RID: 19599 RVA: 0x00124EB0 File Offset: 0x001230B0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004C90 RID: 19600 RVA: 0x00124EBC File Offset: 0x001230BC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasBnetConsumableId = this.HasBnetConsumableId;
			if (hasBnetConsumableId)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.BnetConsumableId);
			}
			bool hasStatusId = this.HasStatusId;
			if (hasStatusId)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.StatusId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004C91 RID: 19601 RVA: 0x00124F2C File Offset: 0x0012312C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasBnetConsumableId = this.HasBnetConsumableId;
			if (hasBnetConsumableId)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BnetConsumableId);
			}
			bool hasStatusId = this.HasStatusId;
			if (hasStatusId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StatusId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004C92 RID: 19602 RVA: 0x00124F98 File Offset: 0x00123198
		[DebuggerNonUserCode]
		public void MergeFrom(Consumable other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasBnetConsumableId = other.HasBnetConsumableId;
				if (hasBnetConsumableId)
				{
					this.BnetConsumableId = other.BnetConsumableId;
				}
				bool hasStatusId = other.HasStatusId;
				if (hasStatusId)
				{
					this.StatusId = other.StatusId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004C93 RID: 19603 RVA: 0x00124FFA File Offset: 0x001231FA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004C94 RID: 19604 RVA: 0x00125008 File Offset: 0x00123208
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.StatusId = input.ReadInt32();
					}
				}
				else
				{
					this.BnetConsumableId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002220 RID: 8736
		private static readonly MessageParser<Consumable> _parser = new MessageParser<Consumable>(() => new Consumable());

		// Token: 0x04002221 RID: 8737
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002222 RID: 8738
		private int _hasBits0;

		// Token: 0x04002223 RID: 8739
		public const int BnetConsumableIdFieldNumber = 1;

		// Token: 0x04002224 RID: 8740
		private static readonly long BnetConsumableIdDefaultValue = 0L;

		// Token: 0x04002225 RID: 8741
		private long bnetConsumableId_;

		// Token: 0x04002226 RID: 8742
		public const int StatusIdFieldNumber = 2;

		// Token: 0x04002227 RID: 8743
		private static readonly int StatusIdDefaultValue = 0;

		// Token: 0x04002228 RID: 8744
		private int statusId_;
	}
}
