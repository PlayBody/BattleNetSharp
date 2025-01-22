using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.CS
{
	// Token: 0x02000207 RID: 519
	public sealed class PartitionedGBIDCapQuantity : IMessage<PartitionedGBIDCapQuantity>, IMessage, IEquatable<PartitionedGBIDCapQuantity>, IDeepCloneable<PartitionedGBIDCapQuantity>, IBufferMessage
	{
		// Token: 0x17001293 RID: 4755
		// (get) Token: 0x060038E1 RID: 14561 RVA: 0x000E119C File Offset: 0x000DF39C
		[DebuggerNonUserCode]
		public static MessageParser<PartitionedGBIDCapQuantity> Parser
		{
			get
			{
				return PartitionedGBIDCapQuantity._parser;
			}
		}

		// Token: 0x17001294 RID: 4756
		// (get) Token: 0x060038E2 RID: 14562 RVA: 0x000E11B4 File Offset: 0x000DF3B4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CSReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x17001295 RID: 4757
		// (get) Token: 0x060038E3 RID: 14563 RVA: 0x000E11D8 File Offset: 0x000DF3D8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartitionedGBIDCapQuantity.Descriptor;
			}
		}

		// Token: 0x060038E4 RID: 14564 RVA: 0x000E11EF File Offset: 0x000DF3EF
		[DebuggerNonUserCode]
		public PartitionedGBIDCapQuantity()
		{
		}

		// Token: 0x060038E5 RID: 14565 RVA: 0x000E11FC File Offset: 0x000DF3FC
		[DebuggerNonUserCode]
		public PartitionedGBIDCapQuantity(PartitionedGBIDCapQuantity other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gbid_ = other.gbid_;
			this.partitionId_ = other.partitionId_;
			this.capQuantity_ = other.capQuantity_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060038E6 RID: 14566 RVA: 0x000E1254 File Offset: 0x000DF454
		[DebuggerNonUserCode]
		public PartitionedGBIDCapQuantity Clone()
		{
			return new PartitionedGBIDCapQuantity(this);
		}

		// Token: 0x17001296 RID: 4758
		// (get) Token: 0x060038E7 RID: 14567 RVA: 0x000E126C File Offset: 0x000DF46C
		// (set) Token: 0x060038E8 RID: 14568 RVA: 0x000E129D File Offset: 0x000DF49D
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
					gbidDefaultValue = PartitionedGBIDCapQuantity.GbidDefaultValue;
				}
				return gbidDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gbid_ = value;
			}
		}

		// Token: 0x17001297 RID: 4759
		// (get) Token: 0x060038E9 RID: 14569 RVA: 0x000E12B8 File Offset: 0x000DF4B8
		[DebuggerNonUserCode]
		public bool HasGbid
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060038EA RID: 14570 RVA: 0x000E12D5 File Offset: 0x000DF4D5
		[DebuggerNonUserCode]
		public void ClearGbid()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001298 RID: 4760
		// (get) Token: 0x060038EB RID: 14571 RVA: 0x000E12E8 File Offset: 0x000DF4E8
		// (set) Token: 0x060038EC RID: 14572 RVA: 0x000E1319 File Offset: 0x000DF519
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
					partitionIdDefaultValue = PartitionedGBIDCapQuantity.PartitionIdDefaultValue;
				}
				return partitionIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.partitionId_ = value;
			}
		}

		// Token: 0x17001299 RID: 4761
		// (get) Token: 0x060038ED RID: 14573 RVA: 0x000E1334 File Offset: 0x000DF534
		[DebuggerNonUserCode]
		public bool HasPartitionId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060038EE RID: 14574 RVA: 0x000E1351 File Offset: 0x000DF551
		[DebuggerNonUserCode]
		public void ClearPartitionId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700129A RID: 4762
		// (get) Token: 0x060038EF RID: 14575 RVA: 0x000E1364 File Offset: 0x000DF564
		// (set) Token: 0x060038F0 RID: 14576 RVA: 0x000E1395 File Offset: 0x000DF595
		[DebuggerNonUserCode]
		public ulong CapQuantity
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong capQuantityDefaultValue;
				if (flag)
				{
					capQuantityDefaultValue = this.capQuantity_;
				}
				else
				{
					capQuantityDefaultValue = PartitionedGBIDCapQuantity.CapQuantityDefaultValue;
				}
				return capQuantityDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.capQuantity_ = value;
			}
		}

		// Token: 0x1700129B RID: 4763
		// (get) Token: 0x060038F1 RID: 14577 RVA: 0x000E13B0 File Offset: 0x000DF5B0
		[DebuggerNonUserCode]
		public bool HasCapQuantity
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060038F2 RID: 14578 RVA: 0x000E13CD File Offset: 0x000DF5CD
		[DebuggerNonUserCode]
		public void ClearCapQuantity()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x060038F3 RID: 14579 RVA: 0x000E13E0 File Offset: 0x000DF5E0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartitionedGBIDCapQuantity);
		}

		// Token: 0x060038F4 RID: 14580 RVA: 0x000E1400 File Offset: 0x000DF600
		[DebuggerNonUserCode]
		public bool Equals(PartitionedGBIDCapQuantity other)
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
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.CapQuantity != other.CapQuantity;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060038F5 RID: 14581 RVA: 0x000E148C File Offset: 0x000DF68C
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
			bool hasCapQuantity = this.HasCapQuantity;
			if (hasCapQuantity)
			{
				num ^= this.CapQuantity.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060038F6 RID: 14582 RVA: 0x000E1518 File Offset: 0x000DF718
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060038F7 RID: 14583 RVA: 0x000E1530 File Offset: 0x000DF730
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060038F8 RID: 14584 RVA: 0x000E153C File Offset: 0x000DF73C
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
			bool hasCapQuantity = this.HasCapQuantity;
			if (hasCapQuantity)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.CapQuantity);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060038F9 RID: 14585 RVA: 0x000E15CC File Offset: 0x000DF7CC
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
			bool hasCapQuantity = this.HasCapQuantity;
			if (hasCapQuantity)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CapQuantity);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060038FA RID: 14586 RVA: 0x000E164C File Offset: 0x000DF84C
		[DebuggerNonUserCode]
		public void MergeFrom(PartitionedGBIDCapQuantity other)
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
				bool hasCapQuantity = other.HasCapQuantity;
				if (hasCapQuantity)
				{
					this.CapQuantity = other.CapQuantity;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060038FB RID: 14587 RVA: 0x000E16C7 File Offset: 0x000DF8C7
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060038FC RID: 14588 RVA: 0x000E16D4 File Offset: 0x000DF8D4
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CapQuantity = input.ReadUInt64();
						}
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

		// Token: 0x04001A8D RID: 6797
		private static readonly MessageParser<PartitionedGBIDCapQuantity> _parser = new MessageParser<PartitionedGBIDCapQuantity>(() => new PartitionedGBIDCapQuantity());

		// Token: 0x04001A8E RID: 6798
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001A8F RID: 6799
		private int _hasBits0;

		// Token: 0x04001A90 RID: 6800
		public const int GbidFieldNumber = 1;

		// Token: 0x04001A91 RID: 6801
		private static readonly int GbidDefaultValue = 0;

		// Token: 0x04001A92 RID: 6802
		private int gbid_;

		// Token: 0x04001A93 RID: 6803
		public const int PartitionIdFieldNumber = 2;

		// Token: 0x04001A94 RID: 6804
		private static readonly uint PartitionIdDefaultValue = 0U;

		// Token: 0x04001A95 RID: 6805
		private uint partitionId_;

		// Token: 0x04001A96 RID: 6806
		public const int CapQuantityFieldNumber = 3;

		// Token: 0x04001A97 RID: 6807
		private static readonly ulong CapQuantityDefaultValue = 0UL;

		// Token: 0x04001A98 RID: 6808
		private ulong capQuantity_;
	}
}
