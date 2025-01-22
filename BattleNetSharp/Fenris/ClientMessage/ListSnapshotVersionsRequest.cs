using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200023A RID: 570
	public sealed class ListSnapshotVersionsRequest : IMessage<ListSnapshotVersionsRequest>, IMessage, IEquatable<ListSnapshotVersionsRequest>, IDeepCloneable<ListSnapshotVersionsRequest>, IBufferMessage
	{
		// Token: 0x170013E4 RID: 5092
		// (get) Token: 0x06003D97 RID: 15767 RVA: 0x000F322C File Offset: 0x000F142C
		[DebuggerNonUserCode]
		public static MessageParser<ListSnapshotVersionsRequest> Parser
		{
			get
			{
				return ListSnapshotVersionsRequest._parser;
			}
		}

		// Token: 0x170013E5 RID: 5093
		// (get) Token: 0x06003D98 RID: 15768 RVA: 0x000F3244 File Offset: 0x000F1444
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[42];
			}
		}

		// Token: 0x170013E6 RID: 5094
		// (get) Token: 0x06003D99 RID: 15769 RVA: 0x000F3268 File Offset: 0x000F1468
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ListSnapshotVersionsRequest.Descriptor;
			}
		}

		// Token: 0x06003D9A RID: 15770 RVA: 0x000F327F File Offset: 0x000F147F
		[DebuggerNonUserCode]
		public ListSnapshotVersionsRequest()
		{
		}

		// Token: 0x06003D9B RID: 15771 RVA: 0x000F328C File Offset: 0x000F148C
		[DebuggerNonUserCode]
		public ListSnapshotVersionsRequest(ListSnapshotVersionsRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameAccountId_ = other.gameAccountId_;
			this.returnSnapshots_ = other.returnSnapshots_;
			this.limit_ = other.limit_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D9C RID: 15772 RVA: 0x000F32E4 File Offset: 0x000F14E4
		[DebuggerNonUserCode]
		public ListSnapshotVersionsRequest Clone()
		{
			return new ListSnapshotVersionsRequest(this);
		}

		// Token: 0x170013E7 RID: 5095
		// (get) Token: 0x06003D9D RID: 15773 RVA: 0x000F32FC File Offset: 0x000F14FC
		// (set) Token: 0x06003D9E RID: 15774 RVA: 0x000F332D File Offset: 0x000F152D
		[DebuggerNonUserCode]
		public uint GameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint gameAccountIdDefaultValue;
				if (flag)
				{
					gameAccountIdDefaultValue = this.gameAccountId_;
				}
				else
				{
					gameAccountIdDefaultValue = ListSnapshotVersionsRequest.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x170013E8 RID: 5096
		// (get) Token: 0x06003D9F RID: 15775 RVA: 0x000F3348 File Offset: 0x000F1548
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003DA0 RID: 15776 RVA: 0x000F3365 File Offset: 0x000F1565
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170013E9 RID: 5097
		// (get) Token: 0x06003DA1 RID: 15777 RVA: 0x000F3378 File Offset: 0x000F1578
		// (set) Token: 0x06003DA2 RID: 15778 RVA: 0x000F33A9 File Offset: 0x000F15A9
		[DebuggerNonUserCode]
		public bool ReturnSnapshots
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool returnSnapshotsDefaultValue;
				if (flag)
				{
					returnSnapshotsDefaultValue = this.returnSnapshots_;
				}
				else
				{
					returnSnapshotsDefaultValue = ListSnapshotVersionsRequest.ReturnSnapshotsDefaultValue;
				}
				return returnSnapshotsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.returnSnapshots_ = value;
			}
		}

		// Token: 0x170013EA RID: 5098
		// (get) Token: 0x06003DA3 RID: 15779 RVA: 0x000F33C4 File Offset: 0x000F15C4
		[DebuggerNonUserCode]
		public bool HasReturnSnapshots
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003DA4 RID: 15780 RVA: 0x000F33E1 File Offset: 0x000F15E1
		[DebuggerNonUserCode]
		public void ClearReturnSnapshots()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170013EB RID: 5099
		// (get) Token: 0x06003DA5 RID: 15781 RVA: 0x000F33F4 File Offset: 0x000F15F4
		// (set) Token: 0x06003DA6 RID: 15782 RVA: 0x000F3425 File Offset: 0x000F1625
		[DebuggerNonUserCode]
		public uint Limit
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint limitDefaultValue;
				if (flag)
				{
					limitDefaultValue = this.limit_;
				}
				else
				{
					limitDefaultValue = ListSnapshotVersionsRequest.LimitDefaultValue;
				}
				return limitDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.limit_ = value;
			}
		}

		// Token: 0x170013EC RID: 5100
		// (get) Token: 0x06003DA7 RID: 15783 RVA: 0x000F3440 File Offset: 0x000F1640
		[DebuggerNonUserCode]
		public bool HasLimit
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06003DA8 RID: 15784 RVA: 0x000F345D File Offset: 0x000F165D
		[DebuggerNonUserCode]
		public void ClearLimit()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06003DA9 RID: 15785 RVA: 0x000F3470 File Offset: 0x000F1670
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ListSnapshotVersionsRequest);
		}

		// Token: 0x06003DAA RID: 15786 RVA: 0x000F3490 File Offset: 0x000F1690
		[DebuggerNonUserCode]
		public bool Equals(ListSnapshotVersionsRequest other)
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
					bool flag4 = this.GameAccountId != other.GameAccountId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ReturnSnapshots != other.ReturnSnapshots;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Limit != other.Limit;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003DAB RID: 15787 RVA: 0x000F351C File Offset: 0x000F171C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool hasReturnSnapshots = this.HasReturnSnapshots;
			if (hasReturnSnapshots)
			{
				num ^= this.ReturnSnapshots.GetHashCode();
			}
			bool hasLimit = this.HasLimit;
			if (hasLimit)
			{
				num ^= this.Limit.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003DAC RID: 15788 RVA: 0x000F35A8 File Offset: 0x000F17A8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003DAD RID: 15789 RVA: 0x000F35C0 File Offset: 0x000F17C0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003DAE RID: 15790 RVA: 0x000F35CC File Offset: 0x000F17CC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GameAccountId);
			}
			bool hasReturnSnapshots = this.HasReturnSnapshots;
			if (hasReturnSnapshots)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.ReturnSnapshots);
			}
			bool hasLimit = this.HasLimit;
			if (hasLimit)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Limit);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003DAF RID: 15791 RVA: 0x000F365C File Offset: 0x000F185C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			bool hasReturnSnapshots = this.HasReturnSnapshots;
			if (hasReturnSnapshots)
			{
				num += 2;
			}
			bool hasLimit = this.HasLimit;
			if (hasLimit)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Limit);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003DB0 RID: 15792 RVA: 0x000F36DC File Offset: 0x000F18DC
		[DebuggerNonUserCode]
		public void MergeFrom(ListSnapshotVersionsRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				bool hasReturnSnapshots = other.HasReturnSnapshots;
				if (hasReturnSnapshots)
				{
					this.ReturnSnapshots = other.ReturnSnapshots;
				}
				bool hasLimit = other.HasLimit;
				if (hasLimit)
				{
					this.Limit = other.Limit;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003DB1 RID: 15793 RVA: 0x000F3757 File Offset: 0x000F1957
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003DB2 RID: 15794 RVA: 0x000F3764 File Offset: 0x000F1964
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Limit = input.ReadUInt32();
						}
					}
					else
					{
						this.ReturnSnapshots = input.ReadBool();
					}
				}
				else
				{
					this.GameAccountId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001C49 RID: 7241
		private static readonly MessageParser<ListSnapshotVersionsRequest> _parser = new MessageParser<ListSnapshotVersionsRequest>(() => new ListSnapshotVersionsRequest());

		// Token: 0x04001C4A RID: 7242
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C4B RID: 7243
		private int _hasBits0;

		// Token: 0x04001C4C RID: 7244
		public const int GameAccountIdFieldNumber = 1;

		// Token: 0x04001C4D RID: 7245
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x04001C4E RID: 7246
		private uint gameAccountId_;

		// Token: 0x04001C4F RID: 7247
		public const int ReturnSnapshotsFieldNumber = 2;

		// Token: 0x04001C50 RID: 7248
		private static readonly bool ReturnSnapshotsDefaultValue = false;

		// Token: 0x04001C51 RID: 7249
		private bool returnSnapshots_;

		// Token: 0x04001C52 RID: 7250
		public const int LimitFieldNumber = 3;

		// Token: 0x04001C53 RID: 7251
		private static readonly uint LimitDefaultValue = 0U;

		// Token: 0x04001C54 RID: 7252
		private uint limit_;
	}
}
