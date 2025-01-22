using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Quests
{
	// Token: 0x0200012C RID: 300
	public sealed class ReputationReward : IMessage<ReputationReward>, IMessage, IEquatable<ReputationReward>, IDeepCloneable<ReputationReward>, IBufferMessage
	{
		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06001E0B RID: 7691 RVA: 0x00073948 File Offset: 0x00071B48
		[DebuggerNonUserCode]
		public static MessageParser<ReputationReward> Parser
		{
			get
			{
				return ReputationReward._parser;
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06001E0C RID: 7692 RVA: 0x00073960 File Offset: 0x00071B60
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return QuestReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06001E0D RID: 7693 RVA: 0x00073984 File Offset: 0x00071B84
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReputationReward.Descriptor;
			}
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x0007399B File Offset: 0x00071B9B
		[DebuggerNonUserCode]
		public ReputationReward()
		{
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x000739A8 File Offset: 0x00071BA8
		[DebuggerNonUserCode]
		public ReputationReward(ReputationReward other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoReputation_ = other.snoReputation_;
			this.repCurrent_ = other.repCurrent_;
			this.repMax_ = other.repMax_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x00073A00 File Offset: 0x00071C00
		[DebuggerNonUserCode]
		public ReputationReward Clone()
		{
			return new ReputationReward(this);
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06001E11 RID: 7697 RVA: 0x00073A18 File Offset: 0x00071C18
		// (set) Token: 0x06001E12 RID: 7698 RVA: 0x00073A49 File Offset: 0x00071C49
		[DebuggerNonUserCode]
		public int SnoReputation
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoReputationDefaultValue;
				if (flag)
				{
					snoReputationDefaultValue = this.snoReputation_;
				}
				else
				{
					snoReputationDefaultValue = ReputationReward.SnoReputationDefaultValue;
				}
				return snoReputationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoReputation_ = value;
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06001E13 RID: 7699 RVA: 0x00073A64 File Offset: 0x00071C64
		[DebuggerNonUserCode]
		public bool HasSnoReputation
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x00073A81 File Offset: 0x00071C81
		[DebuggerNonUserCode]
		public void ClearSnoReputation()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06001E15 RID: 7701 RVA: 0x00073A94 File Offset: 0x00071C94
		// (set) Token: 0x06001E16 RID: 7702 RVA: 0x00073AC5 File Offset: 0x00071CC5
		[DebuggerNonUserCode]
		public int RepCurrent
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int repCurrentDefaultValue;
				if (flag)
				{
					repCurrentDefaultValue = this.repCurrent_;
				}
				else
				{
					repCurrentDefaultValue = ReputationReward.RepCurrentDefaultValue;
				}
				return repCurrentDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.repCurrent_ = value;
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06001E17 RID: 7703 RVA: 0x00073AE0 File Offset: 0x00071CE0
		[DebuggerNonUserCode]
		public bool HasRepCurrent
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x00073AFD File Offset: 0x00071CFD
		[DebuggerNonUserCode]
		public void ClearRepCurrent()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06001E19 RID: 7705 RVA: 0x00073B10 File Offset: 0x00071D10
		// (set) Token: 0x06001E1A RID: 7706 RVA: 0x00073B41 File Offset: 0x00071D41
		[DebuggerNonUserCode]
		public int RepMax
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int repMaxDefaultValue;
				if (flag)
				{
					repMaxDefaultValue = this.repMax_;
				}
				else
				{
					repMaxDefaultValue = ReputationReward.RepMaxDefaultValue;
				}
				return repMaxDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.repMax_ = value;
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06001E1B RID: 7707 RVA: 0x00073B5C File Offset: 0x00071D5C
		[DebuggerNonUserCode]
		public bool HasRepMax
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x00073B79 File Offset: 0x00071D79
		[DebuggerNonUserCode]
		public void ClearRepMax()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x00073B8C File Offset: 0x00071D8C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReputationReward);
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x00073BAC File Offset: 0x00071DAC
		[DebuggerNonUserCode]
		public bool Equals(ReputationReward other)
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
					bool flag4 = this.SnoReputation != other.SnoReputation;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.RepCurrent != other.RepCurrent;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.RepMax != other.RepMax;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x00073C38 File Offset: 0x00071E38
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoReputation = this.HasSnoReputation;
			if (hasSnoReputation)
			{
				num ^= this.SnoReputation.GetHashCode();
			}
			bool hasRepCurrent = this.HasRepCurrent;
			if (hasRepCurrent)
			{
				num ^= this.RepCurrent.GetHashCode();
			}
			bool hasRepMax = this.HasRepMax;
			if (hasRepMax)
			{
				num ^= this.RepMax.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x00073CC4 File Offset: 0x00071EC4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x00073CDC File Offset: 0x00071EDC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x00073CE8 File Offset: 0x00071EE8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoReputation = this.HasSnoReputation;
			if (hasSnoReputation)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoReputation);
			}
			bool hasRepCurrent = this.HasRepCurrent;
			if (hasRepCurrent)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RepCurrent);
			}
			bool hasRepMax = this.HasRepMax;
			if (hasRepMax)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RepMax);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x00073D78 File Offset: 0x00071F78
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoReputation = this.HasSnoReputation;
			if (hasSnoReputation)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoReputation);
			}
			bool hasRepCurrent = this.HasRepCurrent;
			if (hasRepCurrent)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RepCurrent);
			}
			bool hasRepMax = this.HasRepMax;
			if (hasRepMax)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RepMax);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x00073E04 File Offset: 0x00072004
		[DebuggerNonUserCode]
		public void MergeFrom(ReputationReward other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoReputation = other.HasSnoReputation;
				if (hasSnoReputation)
				{
					this.SnoReputation = other.SnoReputation;
				}
				bool hasRepCurrent = other.HasRepCurrent;
				if (hasRepCurrent)
				{
					this.RepCurrent = other.RepCurrent;
				}
				bool hasRepMax = other.HasRepMax;
				if (hasRepMax)
				{
					this.RepMax = other.RepMax;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x00073E7F File Offset: 0x0007207F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x00073E8C File Offset: 0x0007208C
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
							this.RepMax = input.ReadInt32();
						}
					}
					else
					{
						this.RepCurrent = input.ReadInt32();
					}
				}
				else
				{
					this.SnoReputation = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000CED RID: 3309
		private static readonly MessageParser<ReputationReward> _parser = new MessageParser<ReputationReward>(() => new ReputationReward());

		// Token: 0x04000CEE RID: 3310
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000CEF RID: 3311
		private int _hasBits0;

		// Token: 0x04000CF0 RID: 3312
		public const int SnoReputationFieldNumber = 1;

		// Token: 0x04000CF1 RID: 3313
		private static readonly int SnoReputationDefaultValue = 0;

		// Token: 0x04000CF2 RID: 3314
		private int snoReputation_;

		// Token: 0x04000CF3 RID: 3315
		public const int RepCurrentFieldNumber = 2;

		// Token: 0x04000CF4 RID: 3316
		private static readonly int RepCurrentDefaultValue = 0;

		// Token: 0x04000CF5 RID: 3317
		private int repCurrent_;

		// Token: 0x04000CF6 RID: 3318
		public const int RepMaxFieldNumber = 3;

		// Token: 0x04000CF7 RID: 3319
		private static readonly int RepMaxDefaultValue = 0;

		// Token: 0x04000CF8 RID: 3320
		private int repMax_;
	}
}
