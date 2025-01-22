using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.CS
{
	// Token: 0x02000205 RID: 517
	public sealed class PartitionedGBID : IMessage<PartitionedGBID>, IMessage, IEquatable<PartitionedGBID>, IDeepCloneable<PartitionedGBID>, IBufferMessage
	{
		// Token: 0x17001288 RID: 4744
		// (get) Token: 0x060038B6 RID: 14518 RVA: 0x000E09FC File Offset: 0x000DEBFC
		[DebuggerNonUserCode]
		public static MessageParser<PartitionedGBID> Parser
		{
			get
			{
				return PartitionedGBID._parser;
			}
		}

		// Token: 0x17001289 RID: 4745
		// (get) Token: 0x060038B7 RID: 14519 RVA: 0x000E0A14 File Offset: 0x000DEC14
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CSReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x1700128A RID: 4746
		// (get) Token: 0x060038B8 RID: 14520 RVA: 0x000E0A38 File Offset: 0x000DEC38
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartitionedGBID.Descriptor;
			}
		}

		// Token: 0x060038B9 RID: 14521 RVA: 0x000E0A4F File Offset: 0x000DEC4F
		[DebuggerNonUserCode]
		public PartitionedGBID()
		{
		}

		// Token: 0x060038BA RID: 14522 RVA: 0x000E0A59 File Offset: 0x000DEC59
		[DebuggerNonUserCode]
		public PartitionedGBID(PartitionedGBID other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gbid_ = other.gbid_;
			this.partitionId_ = other.partitionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060038BB RID: 14523 RVA: 0x000E0A98 File Offset: 0x000DEC98
		[DebuggerNonUserCode]
		public PartitionedGBID Clone()
		{
			return new PartitionedGBID(this);
		}

		// Token: 0x1700128B RID: 4747
		// (get) Token: 0x060038BC RID: 14524 RVA: 0x000E0AB0 File Offset: 0x000DECB0
		// (set) Token: 0x060038BD RID: 14525 RVA: 0x000E0AE1 File Offset: 0x000DECE1
		[DebuggerNonUserCode]
		public int Gbid
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int gbidDefaultValue;
				if (flag)
				{
					gbidDefaultValue = this.gbid_;
				}
				else
				{
					gbidDefaultValue = PartitionedGBID.GbidDefaultValue;
				}
				return gbidDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gbid_ = value;
			}
		}

		// Token: 0x1700128C RID: 4748
		// (get) Token: 0x060038BE RID: 14526 RVA: 0x000E0AFC File Offset: 0x000DECFC
		[DebuggerNonUserCode]
		public bool HasGbid
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060038BF RID: 14527 RVA: 0x000E0B19 File Offset: 0x000DED19
		[DebuggerNonUserCode]
		public void ClearGbid()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700128D RID: 4749
		// (get) Token: 0x060038C0 RID: 14528 RVA: 0x000E0B2C File Offset: 0x000DED2C
		// (set) Token: 0x060038C1 RID: 14529 RVA: 0x000E0B5D File Offset: 0x000DED5D
		[DebuggerNonUserCode]
		public uint PartitionId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint partitionIdDefaultValue;
				if (flag)
				{
					partitionIdDefaultValue = this.partitionId_;
				}
				else
				{
					partitionIdDefaultValue = PartitionedGBID.PartitionIdDefaultValue;
				}
				return partitionIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.partitionId_ = value;
			}
		}

		// Token: 0x1700128E RID: 4750
		// (get) Token: 0x060038C2 RID: 14530 RVA: 0x000E0B78 File Offset: 0x000DED78
		[DebuggerNonUserCode]
		public bool HasPartitionId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060038C3 RID: 14531 RVA: 0x000E0B95 File Offset: 0x000DED95
		[DebuggerNonUserCode]
		public void ClearPartitionId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060038C4 RID: 14532 RVA: 0x000E0BA8 File Offset: 0x000DEDA8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartitionedGBID);
		}

		// Token: 0x060038C5 RID: 14533 RVA: 0x000E0BC8 File Offset: 0x000DEDC8
		[DebuggerNonUserCode]
		public bool Equals(PartitionedGBID other)
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
					bool flag4 = this.Gbid != other.Gbid;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.PartitionId != other.PartitionId;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060038C6 RID: 14534 RVA: 0x000E0C3C File Offset: 0x000DEE3C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGbid = this.HasGbid;
			if (hasGbid)
			{
				num ^= this.Gbid.GetHashCode();
			}
			bool hasPartitionId = this.HasPartitionId;
			if (hasPartitionId)
			{
				num ^= this.PartitionId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060038C7 RID: 14535 RVA: 0x000E0CAC File Offset: 0x000DEEAC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060038C8 RID: 14536 RVA: 0x000E0CC4 File Offset: 0x000DEEC4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060038C9 RID: 14537 RVA: 0x000E0CD0 File Offset: 0x000DEED0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGbid = this.HasGbid;
			if (hasGbid)
			{
				output.WriteRawTag(13);
				output.WriteSFixed32(this.Gbid);
			}
			bool hasPartitionId = this.HasPartitionId;
			if (hasPartitionId)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.PartitionId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060038CA RID: 14538 RVA: 0x000E0D40 File Offset: 0x000DEF40
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGbid = this.HasGbid;
			if (hasGbid)
			{
				num += 5;
			}
			bool hasPartitionId = this.HasPartitionId;
			if (hasPartitionId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PartitionId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060038CB RID: 14539 RVA: 0x000E0DA0 File Offset: 0x000DEFA0
		[DebuggerNonUserCode]
		public void MergeFrom(PartitionedGBID other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGbid = other.HasGbid;
				if (hasGbid)
				{
					this.Gbid = other.Gbid;
				}
				bool hasPartitionId = other.HasPartitionId;
				if (hasPartitionId)
				{
					this.PartitionId = other.PartitionId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060038CC RID: 14540 RVA: 0x000E0E02 File Offset: 0x000DF002
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060038CD RID: 14541 RVA: 0x000E0E10 File Offset: 0x000DF010
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 13U)
				{
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PartitionId = input.ReadUInt32();
					}
				}
				else
				{
					this.Gbid = input.ReadSFixed32();
				}
			}
		}

		// Token: 0x04001A7F RID: 6783
		private static readonly MessageParser<PartitionedGBID> _parser = new MessageParser<PartitionedGBID>(() => new PartitionedGBID());

		// Token: 0x04001A80 RID: 6784
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001A81 RID: 6785
		private int _hasBits0;

		// Token: 0x04001A82 RID: 6786
		public const int GbidFieldNumber = 1;

		// Token: 0x04001A83 RID: 6787
		private static readonly int GbidDefaultValue = 0;

		// Token: 0x04001A84 RID: 6788
		private int gbid_;

		// Token: 0x04001A85 RID: 6789
		public const int PartitionIdFieldNumber = 2;

		// Token: 0x04001A86 RID: 6790
		private static readonly uint PartitionIdDefaultValue = 0U;

		// Token: 0x04001A87 RID: 6791
		private uint partitionId_;
	}
}
