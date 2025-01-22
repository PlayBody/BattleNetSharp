using System;
using System.Diagnostics;
using Fenris.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.DemonSummoning
{
	// Token: 0x020001FD RID: 509
	public sealed class Scroll : IMessage<Scroll>, IMessage, IEquatable<Scroll>, IDeepCloneable<Scroll>, IBufferMessage
	{
		// Token: 0x17001238 RID: 4664
		// (get) Token: 0x060037CF RID: 14287 RVA: 0x000DCC48 File Offset: 0x000DAE48
		[DebuggerNonUserCode]
		public static MessageParser<Scroll> Parser
		{
			get
			{
				return Scroll._parser;
			}
		}

		// Token: 0x17001239 RID: 4665
		// (get) Token: 0x060037D0 RID: 14288 RVA: 0x000DCC60 File Offset: 0x000DAE60
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DemonSummoningReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x1700123A RID: 4666
		// (get) Token: 0x060037D1 RID: 14289 RVA: 0x000DCC84 File Offset: 0x000DAE84
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Scroll.Descriptor;
			}
		}

		// Token: 0x060037D2 RID: 14290 RVA: 0x000DCC9B File Offset: 0x000DAE9B
		[DebuggerNonUserCode]
		public Scroll()
		{
		}

		// Token: 0x060037D3 RID: 14291 RVA: 0x000DCCBC File Offset: 0x000DAEBC
		[DebuggerNonUserCode]
		public Scroll(Scroll other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoScroll_ = other.snoScroll_;
			this.isNightmare_ = other.isNightmare_;
			this.snoBoss_ = other.snoBoss_;
			this.rituals_ = other.rituals_.Clone();
			this.rewards_ = other.rewards_.Clone();
			this.snoBossQuest_ = other.snoBossQuest_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060037D4 RID: 14292 RVA: 0x000DCD40 File Offset: 0x000DAF40
		[DebuggerNonUserCode]
		public Scroll Clone()
		{
			return new Scroll(this);
		}

		// Token: 0x1700123B RID: 4667
		// (get) Token: 0x060037D5 RID: 14293 RVA: 0x000DCD58 File Offset: 0x000DAF58
		// (set) Token: 0x060037D6 RID: 14294 RVA: 0x000DCD89 File Offset: 0x000DAF89
		[DebuggerNonUserCode]
		public int SnoScroll
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoScrollDefaultValue;
				if (flag)
				{
					snoScrollDefaultValue = this.snoScroll_;
				}
				else
				{
					snoScrollDefaultValue = Scroll.SnoScrollDefaultValue;
				}
				return snoScrollDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoScroll_ = value;
			}
		}

		// Token: 0x1700123C RID: 4668
		// (get) Token: 0x060037D7 RID: 14295 RVA: 0x000DCDA4 File Offset: 0x000DAFA4
		[DebuggerNonUserCode]
		public bool HasSnoScroll
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060037D8 RID: 14296 RVA: 0x000DCDC1 File Offset: 0x000DAFC1
		[DebuggerNonUserCode]
		public void ClearSnoScroll()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700123D RID: 4669
		// (get) Token: 0x060037D9 RID: 14297 RVA: 0x000DCDD4 File Offset: 0x000DAFD4
		// (set) Token: 0x060037DA RID: 14298 RVA: 0x000DCE05 File Offset: 0x000DB005
		[DebuggerNonUserCode]
		public bool IsNightmare
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool isNightmareDefaultValue;
				if (flag)
				{
					isNightmareDefaultValue = this.isNightmare_;
				}
				else
				{
					isNightmareDefaultValue = Scroll.IsNightmareDefaultValue;
				}
				return isNightmareDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.isNightmare_ = value;
			}
		}

		// Token: 0x1700123E RID: 4670
		// (get) Token: 0x060037DB RID: 14299 RVA: 0x000DCE20 File Offset: 0x000DB020
		[DebuggerNonUserCode]
		public bool HasIsNightmare
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060037DC RID: 14300 RVA: 0x000DCE3D File Offset: 0x000DB03D
		[DebuggerNonUserCode]
		public void ClearIsNightmare()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700123F RID: 4671
		// (get) Token: 0x060037DD RID: 14301 RVA: 0x000DCE50 File Offset: 0x000DB050
		// (set) Token: 0x060037DE RID: 14302 RVA: 0x000DCE81 File Offset: 0x000DB081
		[DebuggerNonUserCode]
		public int SnoBoss
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int snoBossDefaultValue;
				if (flag)
				{
					snoBossDefaultValue = this.snoBoss_;
				}
				else
				{
					snoBossDefaultValue = Scroll.SnoBossDefaultValue;
				}
				return snoBossDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.snoBoss_ = value;
			}
		}

		// Token: 0x17001240 RID: 4672
		// (get) Token: 0x060037DF RID: 14303 RVA: 0x000DCE9C File Offset: 0x000DB09C
		[DebuggerNonUserCode]
		public bool HasSnoBoss
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060037E0 RID: 14304 RVA: 0x000DCEB9 File Offset: 0x000DB0B9
		[DebuggerNonUserCode]
		public void ClearSnoBoss()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001241 RID: 4673
		// (get) Token: 0x060037E1 RID: 14305 RVA: 0x000DCECC File Offset: 0x000DB0CC
		[DebuggerNonUserCode]
		public RepeatedField<ScrollRitual> Rituals
		{
			get
			{
				return this.rituals_;
			}
		}

		// Token: 0x17001242 RID: 4674
		// (get) Token: 0x060037E2 RID: 14306 RVA: 0x000DCEE4 File Offset: 0x000DB0E4
		[DebuggerNonUserCode]
		public RepeatedField<Generator> Rewards
		{
			get
			{
				return this.rewards_;
			}
		}

		// Token: 0x17001243 RID: 4675
		// (get) Token: 0x060037E3 RID: 14307 RVA: 0x000DCEFC File Offset: 0x000DB0FC
		// (set) Token: 0x060037E4 RID: 14308 RVA: 0x000DCF2D File Offset: 0x000DB12D
		[DebuggerNonUserCode]
		public int SnoBossQuest
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int snoBossQuestDefaultValue;
				if (flag)
				{
					snoBossQuestDefaultValue = this.snoBossQuest_;
				}
				else
				{
					snoBossQuestDefaultValue = Scroll.SnoBossQuestDefaultValue;
				}
				return snoBossQuestDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.snoBossQuest_ = value;
			}
		}

		// Token: 0x17001244 RID: 4676
		// (get) Token: 0x060037E5 RID: 14309 RVA: 0x000DCF48 File Offset: 0x000DB148
		[DebuggerNonUserCode]
		public bool HasSnoBossQuest
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060037E6 RID: 14310 RVA: 0x000DCF65 File Offset: 0x000DB165
		[DebuggerNonUserCode]
		public void ClearSnoBossQuest()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x060037E7 RID: 14311 RVA: 0x000DCF78 File Offset: 0x000DB178
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Scroll);
		}

		// Token: 0x060037E8 RID: 14312 RVA: 0x000DCF98 File Offset: 0x000DB198
		[DebuggerNonUserCode]
		public bool Equals(Scroll other)
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
					bool flag4 = this.SnoScroll != other.SnoScroll;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.IsNightmare != other.IsNightmare;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.SnoBoss != other.SnoBoss;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.rituals_.Equals(other.rituals_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.rewards_.Equals(other.rewards_);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.SnoBossQuest != other.SnoBossQuest;
										flag2 = !flag9 && object.Equals(this._unknownFields, other._unknownFields);
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060037E9 RID: 14313 RVA: 0x000DD088 File Offset: 0x000DB288
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoScroll = this.HasSnoScroll;
			if (hasSnoScroll)
			{
				num ^= this.SnoScroll.GetHashCode();
			}
			bool hasIsNightmare = this.HasIsNightmare;
			if (hasIsNightmare)
			{
				num ^= this.IsNightmare.GetHashCode();
			}
			bool hasSnoBoss = this.HasSnoBoss;
			if (hasSnoBoss)
			{
				num ^= this.SnoBoss.GetHashCode();
			}
			num ^= this.rituals_.GetHashCode();
			num ^= this.rewards_.GetHashCode();
			bool hasSnoBossQuest = this.HasSnoBossQuest;
			if (hasSnoBossQuest)
			{
				num ^= this.SnoBossQuest.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060037EA RID: 14314 RVA: 0x000DD14C File Offset: 0x000DB34C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060037EB RID: 14315 RVA: 0x000DD164 File Offset: 0x000DB364
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060037EC RID: 14316 RVA: 0x000DD170 File Offset: 0x000DB370
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoScroll = this.HasSnoScroll;
			if (hasSnoScroll)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoScroll);
			}
			bool hasIsNightmare = this.HasIsNightmare;
			if (hasIsNightmare)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsNightmare);
			}
			bool hasSnoBoss = this.HasSnoBoss;
			if (hasSnoBoss)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SnoBoss);
			}
			this.rituals_.WriteTo(ref output, Scroll._repeated_rituals_codec);
			this.rewards_.WriteTo(ref output, Scroll._repeated_rewards_codec);
			bool hasSnoBossQuest = this.HasSnoBossQuest;
			if (hasSnoBossQuest)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.SnoBossQuest);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060037ED RID: 14317 RVA: 0x000DD248 File Offset: 0x000DB448
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoScroll = this.HasSnoScroll;
			if (hasSnoScroll)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoScroll);
			}
			bool hasIsNightmare = this.HasIsNightmare;
			if (hasIsNightmare)
			{
				num += 2;
			}
			bool hasSnoBoss = this.HasSnoBoss;
			if (hasSnoBoss)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoBoss);
			}
			num += this.rituals_.CalculateSize(Scroll._repeated_rituals_codec);
			num += this.rewards_.CalculateSize(Scroll._repeated_rewards_codec);
			bool hasSnoBossQuest = this.HasSnoBossQuest;
			if (hasSnoBossQuest)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoBossQuest);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060037EE RID: 14318 RVA: 0x000DD30C File Offset: 0x000DB50C
		[DebuggerNonUserCode]
		public void MergeFrom(Scroll other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoScroll = other.HasSnoScroll;
				if (hasSnoScroll)
				{
					this.SnoScroll = other.SnoScroll;
				}
				bool hasIsNightmare = other.HasIsNightmare;
				if (hasIsNightmare)
				{
					this.IsNightmare = other.IsNightmare;
				}
				bool hasSnoBoss = other.HasSnoBoss;
				if (hasSnoBoss)
				{
					this.SnoBoss = other.SnoBoss;
				}
				this.rituals_.Add(other.rituals_);
				this.rewards_.Add(other.rewards_);
				bool hasSnoBossQuest = other.HasSnoBossQuest;
				if (hasSnoBossQuest)
				{
					this.SnoBossQuest = other.SnoBossQuest;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060037EF RID: 14319 RVA: 0x000DD3C9 File Offset: 0x000DB5C9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060037F0 RID: 14320 RVA: 0x000DD3D4 File Offset: 0x000DB5D4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 24U)
				{
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							if (num3 != 24U)
							{
								goto IL_0039;
							}
							this.SnoBoss = input.ReadInt32();
						}
						else
						{
							this.IsNightmare = input.ReadBool();
						}
					}
					else
					{
						this.SnoScroll = input.ReadInt32();
					}
				}
				else if (num3 != 34U)
				{
					if (num3 != 42U)
					{
						if (num3 != 48U)
						{
							goto IL_0039;
						}
						this.SnoBossQuest = input.ReadInt32();
					}
					else
					{
						this.rewards_.AddEntriesFrom(ref input, Scroll._repeated_rewards_codec);
					}
				}
				else
				{
					this.rituals_.AddEntriesFrom(ref input, Scroll._repeated_rituals_codec);
				}
				continue;
				IL_0039:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001A09 RID: 6665
		private static readonly MessageParser<Scroll> _parser = new MessageParser<Scroll>(() => new Scroll());

		// Token: 0x04001A0A RID: 6666
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001A0B RID: 6667
		private int _hasBits0;

		// Token: 0x04001A0C RID: 6668
		public const int SnoScrollFieldNumber = 1;

		// Token: 0x04001A0D RID: 6669
		private static readonly int SnoScrollDefaultValue = 0;

		// Token: 0x04001A0E RID: 6670
		private int snoScroll_;

		// Token: 0x04001A0F RID: 6671
		public const int IsNightmareFieldNumber = 2;

		// Token: 0x04001A10 RID: 6672
		private static readonly bool IsNightmareDefaultValue = false;

		// Token: 0x04001A11 RID: 6673
		private bool isNightmare_;

		// Token: 0x04001A12 RID: 6674
		public const int SnoBossFieldNumber = 3;

		// Token: 0x04001A13 RID: 6675
		private static readonly int SnoBossDefaultValue = 0;

		// Token: 0x04001A14 RID: 6676
		private int snoBoss_;

		// Token: 0x04001A15 RID: 6677
		public const int RitualsFieldNumber = 4;

		// Token: 0x04001A16 RID: 6678
		private static readonly FieldCodec<ScrollRitual> _repeated_rituals_codec = FieldCodec.ForMessage<ScrollRitual>(34U, ScrollRitual.Parser);

		// Token: 0x04001A17 RID: 6679
		private readonly RepeatedField<ScrollRitual> rituals_ = new RepeatedField<ScrollRitual>();

		// Token: 0x04001A18 RID: 6680
		public const int RewardsFieldNumber = 5;

		// Token: 0x04001A19 RID: 6681
		private static readonly FieldCodec<Generator> _repeated_rewards_codec = FieldCodec.ForMessage<Generator>(42U, Generator.Parser);

		// Token: 0x04001A1A RID: 6682
		private readonly RepeatedField<Generator> rewards_ = new RepeatedField<Generator>();

		// Token: 0x04001A1B RID: 6683
		public const int SnoBossQuestFieldNumber = 6;

		// Token: 0x04001A1C RID: 6684
		private static readonly int SnoBossQuestDefaultValue = 0;

		// Token: 0x04001A1D RID: 6685
		private int snoBossQuest_;
	}
}
