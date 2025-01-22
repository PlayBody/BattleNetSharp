using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000C6 RID: 198
	public sealed class RollDRLGRequest : IMessage<RollDRLGRequest>, IMessage, IEquatable<RollDRLGRequest>, IDeepCloneable<RollDRLGRequest>, IBufferMessage
	{
		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x060012B2 RID: 4786 RVA: 0x000444CC File Offset: 0x000426CC
		[DebuggerNonUserCode]
		public static MessageParser<RollDRLGRequest> Parser
		{
			get
			{
				return RollDRLGRequest._parser;
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x060012B3 RID: 4787 RVA: 0x000444E4 File Offset: 0x000426E4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[175];
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x060012B4 RID: 4788 RVA: 0x0004450C File Offset: 0x0004270C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollDRLGRequest.Descriptor;
			}
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x00044523 File Offset: 0x00042723
		[DebuggerNonUserCode]
		public RollDRLGRequest()
		{
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x00044544 File Offset: 0x00042744
		[DebuggerNonUserCode]
		public RollDRLGRequest(RollDRLGRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoWorld_ = other.snoWorld_;
			this.detail_ = other.detail_;
			this.seed_ = other.seed_;
			this.count_ = other.count_;
			this.dungeonStates_ = other.dungeonStates_.Clone();
			this.spawningPools_ = other.spawningPools_.Clone();
			this.treatWarningsAsErrors_ = other.treatWarningsAsErrors_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x000445D4 File Offset: 0x000427D4
		[DebuggerNonUserCode]
		public RollDRLGRequest Clone()
		{
			return new RollDRLGRequest(this);
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x060012B8 RID: 4792 RVA: 0x000445EC File Offset: 0x000427EC
		// (set) Token: 0x060012B9 RID: 4793 RVA: 0x0004461D File Offset: 0x0004281D
		[DebuggerNonUserCode]
		public int SnoWorld
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoWorldDefaultValue;
				if (flag)
				{
					snoWorldDefaultValue = this.snoWorld_;
				}
				else
				{
					snoWorldDefaultValue = RollDRLGRequest.SnoWorldDefaultValue;
				}
				return snoWorldDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoWorld_ = value;
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x060012BA RID: 4794 RVA: 0x00044638 File Offset: 0x00042838
		[DebuggerNonUserCode]
		public bool HasSnoWorld
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x00044655 File Offset: 0x00042855
		[DebuggerNonUserCode]
		public void ClearSnoWorld()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x060012BC RID: 4796 RVA: 0x00044668 File Offset: 0x00042868
		// (set) Token: 0x060012BD RID: 4797 RVA: 0x00044699 File Offset: 0x00042899
		[DebuggerNonUserCode]
		public int Detail
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int detailDefaultValue;
				if (flag)
				{
					detailDefaultValue = this.detail_;
				}
				else
				{
					detailDefaultValue = RollDRLGRequest.DetailDefaultValue;
				}
				return detailDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.detail_ = value;
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x060012BE RID: 4798 RVA: 0x000446B4 File Offset: 0x000428B4
		[DebuggerNonUserCode]
		public bool HasDetail
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x000446D1 File Offset: 0x000428D1
		[DebuggerNonUserCode]
		public void ClearDetail()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x060012C0 RID: 4800 RVA: 0x000446E4 File Offset: 0x000428E4
		// (set) Token: 0x060012C1 RID: 4801 RVA: 0x00044715 File Offset: 0x00042915
		[DebuggerNonUserCode]
		public int Seed
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int seedDefaultValue;
				if (flag)
				{
					seedDefaultValue = this.seed_;
				}
				else
				{
					seedDefaultValue = RollDRLGRequest.SeedDefaultValue;
				}
				return seedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.seed_ = value;
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x060012C2 RID: 4802 RVA: 0x00044730 File Offset: 0x00042930
		[DebuggerNonUserCode]
		public bool HasSeed
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x0004474D File Offset: 0x0004294D
		[DebuggerNonUserCode]
		public void ClearSeed()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x060012C4 RID: 4804 RVA: 0x00044760 File Offset: 0x00042960
		// (set) Token: 0x060012C5 RID: 4805 RVA: 0x00044791 File Offset: 0x00042991
		[DebuggerNonUserCode]
		public uint Count
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint countDefaultValue;
				if (flag)
				{
					countDefaultValue = this.count_;
				}
				else
				{
					countDefaultValue = RollDRLGRequest.CountDefaultValue;
				}
				return countDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.count_ = value;
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x060012C6 RID: 4806 RVA: 0x000447AC File Offset: 0x000429AC
		[DebuggerNonUserCode]
		public bool HasCount
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x000447C9 File Offset: 0x000429C9
		[DebuggerNonUserCode]
		public void ClearCount()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x060012C8 RID: 4808 RVA: 0x000447DC File Offset: 0x000429DC
		[DebuggerNonUserCode]
		public RepeatedField<uint> DungeonStates
		{
			get
			{
				return this.dungeonStates_;
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x060012C9 RID: 4809 RVA: 0x000447F4 File Offset: 0x000429F4
		[DebuggerNonUserCode]
		public RepeatedField<uint> SpawningPools
		{
			get
			{
				return this.spawningPools_;
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x060012CA RID: 4810 RVA: 0x0004480C File Offset: 0x00042A0C
		// (set) Token: 0x060012CB RID: 4811 RVA: 0x0004483E File Offset: 0x00042A3E
		[DebuggerNonUserCode]
		public bool TreatWarningsAsErrors
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool treatWarningsAsErrorsDefaultValue;
				if (flag)
				{
					treatWarningsAsErrorsDefaultValue = this.treatWarningsAsErrors_;
				}
				else
				{
					treatWarningsAsErrorsDefaultValue = RollDRLGRequest.TreatWarningsAsErrorsDefaultValue;
				}
				return treatWarningsAsErrorsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.treatWarningsAsErrors_ = value;
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x060012CC RID: 4812 RVA: 0x00044858 File Offset: 0x00042A58
		[DebuggerNonUserCode]
		public bool HasTreatWarningsAsErrors
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x00044876 File Offset: 0x00042A76
		[DebuggerNonUserCode]
		public void ClearTreatWarningsAsErrors()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x00044888 File Offset: 0x00042A88
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollDRLGRequest);
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x000448A8 File Offset: 0x00042AA8
		[DebuggerNonUserCode]
		public bool Equals(RollDRLGRequest other)
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
					bool flag4 = this.SnoWorld != other.SnoWorld;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Detail != other.Detail;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Seed != other.Seed;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Count != other.Count;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.dungeonStates_.Equals(other.dungeonStates_);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !this.spawningPools_.Equals(other.spawningPools_);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.TreatWarningsAsErrors != other.TreatWarningsAsErrors;
											flag2 = !flag10 && object.Equals(this._unknownFields, other._unknownFields);
										}
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x000449B8 File Offset: 0x00042BB8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num ^= this.SnoWorld.GetHashCode();
			}
			bool hasDetail = this.HasDetail;
			if (hasDetail)
			{
				num ^= this.Detail.GetHashCode();
			}
			bool hasSeed = this.HasSeed;
			if (hasSeed)
			{
				num ^= this.Seed.GetHashCode();
			}
			bool hasCount = this.HasCount;
			if (hasCount)
			{
				num ^= this.Count.GetHashCode();
			}
			num ^= this.dungeonStates_.GetHashCode();
			num ^= this.spawningPools_.GetHashCode();
			bool hasTreatWarningsAsErrors = this.HasTreatWarningsAsErrors;
			if (hasTreatWarningsAsErrors)
			{
				num ^= this.TreatWarningsAsErrors.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x00044A9C File Offset: 0x00042C9C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x00044AB4 File Offset: 0x00042CB4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x00044AC0 File Offset: 0x00042CC0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoWorld);
			}
			bool hasDetail = this.HasDetail;
			if (hasDetail)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Detail);
			}
			bool hasSeed = this.HasSeed;
			if (hasSeed)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Seed);
			}
			bool hasCount = this.HasCount;
			if (hasCount)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Count);
			}
			this.dungeonStates_.WriteTo(ref output, RollDRLGRequest._repeated_dungeonStates_codec);
			this.spawningPools_.WriteTo(ref output, RollDRLGRequest._repeated_spawningPools_codec);
			bool hasTreatWarningsAsErrors = this.HasTreatWarningsAsErrors;
			if (hasTreatWarningsAsErrors)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.TreatWarningsAsErrors);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x00044BBC File Offset: 0x00042DBC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoWorld);
			}
			bool hasDetail = this.HasDetail;
			if (hasDetail)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Detail);
			}
			bool hasSeed = this.HasSeed;
			if (hasSeed)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Seed);
			}
			bool hasCount = this.HasCount;
			if (hasCount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Count);
			}
			num += this.dungeonStates_.CalculateSize(RollDRLGRequest._repeated_dungeonStates_codec);
			num += this.spawningPools_.CalculateSize(RollDRLGRequest._repeated_spawningPools_codec);
			bool hasTreatWarningsAsErrors = this.HasTreatWarningsAsErrors;
			if (hasTreatWarningsAsErrors)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x00044C9C File Offset: 0x00042E9C
		[DebuggerNonUserCode]
		public void MergeFrom(RollDRLGRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoWorld = other.HasSnoWorld;
				if (hasSnoWorld)
				{
					this.SnoWorld = other.SnoWorld;
				}
				bool hasDetail = other.HasDetail;
				if (hasDetail)
				{
					this.Detail = other.Detail;
				}
				bool hasSeed = other.HasSeed;
				if (hasSeed)
				{
					this.Seed = other.Seed;
				}
				bool hasCount = other.HasCount;
				if (hasCount)
				{
					this.Count = other.Count;
				}
				this.dungeonStates_.Add(other.dungeonStates_);
				this.spawningPools_.Add(other.spawningPools_);
				bool hasTreatWarningsAsErrors = other.HasTreatWarningsAsErrors;
				if (hasTreatWarningsAsErrors)
				{
					this.TreatWarningsAsErrors = other.TreatWarningsAsErrors;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x00044D74 File Offset: 0x00042F74
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x00044D80 File Offset: 0x00042F80
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 32U)
				{
					if (num3 <= 16U)
					{
						if (num3 != 8U)
						{
							if (num3 != 16U)
							{
								goto IL_005B;
							}
							this.Detail = input.ReadInt32();
						}
						else
						{
							this.SnoWorld = input.ReadInt32();
						}
					}
					else if (num3 != 24U)
					{
						if (num3 != 32U)
						{
							goto IL_005B;
						}
						this.Count = input.ReadUInt32();
					}
					else
					{
						this.Seed = input.ReadInt32();
					}
				}
				else if (num3 <= 42U)
				{
					if (num3 != 40U && num3 != 42U)
					{
						goto IL_005B;
					}
					this.dungeonStates_.AddEntriesFrom(ref input, RollDRLGRequest._repeated_dungeonStates_codec);
				}
				else if (num3 != 48U && num3 != 50U)
				{
					if (num3 != 56U)
					{
						goto IL_005B;
					}
					this.TreatWarningsAsErrors = input.ReadBool();
				}
				else
				{
					this.spawningPools_.AddEntriesFrom(ref input, RollDRLGRequest._repeated_spawningPools_codec);
				}
				continue;
				IL_005B:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000781 RID: 1921
		private static readonly MessageParser<RollDRLGRequest> _parser = new MessageParser<RollDRLGRequest>(() => new RollDRLGRequest());

		// Token: 0x04000782 RID: 1922
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000783 RID: 1923
		private int _hasBits0;

		// Token: 0x04000784 RID: 1924
		public const int SnoWorldFieldNumber = 1;

		// Token: 0x04000785 RID: 1925
		private static readonly int SnoWorldDefaultValue = 0;

		// Token: 0x04000786 RID: 1926
		private int snoWorld_;

		// Token: 0x04000787 RID: 1927
		public const int DetailFieldNumber = 2;

		// Token: 0x04000788 RID: 1928
		private static readonly int DetailDefaultValue = 0;

		// Token: 0x04000789 RID: 1929
		private int detail_;

		// Token: 0x0400078A RID: 1930
		public const int SeedFieldNumber = 3;

		// Token: 0x0400078B RID: 1931
		private static readonly int SeedDefaultValue = 0;

		// Token: 0x0400078C RID: 1932
		private int seed_;

		// Token: 0x0400078D RID: 1933
		public const int CountFieldNumber = 4;

		// Token: 0x0400078E RID: 1934
		private static readonly uint CountDefaultValue = 0U;

		// Token: 0x0400078F RID: 1935
		private uint count_;

		// Token: 0x04000790 RID: 1936
		public const int DungeonStatesFieldNumber = 5;

		// Token: 0x04000791 RID: 1937
		private static readonly FieldCodec<uint> _repeated_dungeonStates_codec = FieldCodec.ForUInt32(40U);

		// Token: 0x04000792 RID: 1938
		private readonly RepeatedField<uint> dungeonStates_ = new RepeatedField<uint>();

		// Token: 0x04000793 RID: 1939
		public const int SpawningPoolsFieldNumber = 6;

		// Token: 0x04000794 RID: 1940
		private static readonly FieldCodec<uint> _repeated_spawningPools_codec = FieldCodec.ForUInt32(48U);

		// Token: 0x04000795 RID: 1941
		private readonly RepeatedField<uint> spawningPools_ = new RepeatedField<uint>();

		// Token: 0x04000796 RID: 1942
		public const int TreatWarningsAsErrorsFieldNumber = 7;

		// Token: 0x04000797 RID: 1943
		private static readonly bool TreatWarningsAsErrorsDefaultValue = false;

		// Token: 0x04000798 RID: 1944
		private bool treatWarningsAsErrors_;
	}
}
