using System;
using System.Diagnostics;
using Fenris.DemonSummoning;
using Fenris.Quests;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x0200018A RID: 394
	public sealed class Quests : IMessage<Quests>, IMessage, IEquatable<Quests>, IDeepCloneable<Quests>, IBufferMessage
	{
		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x0600295D RID: 10589 RVA: 0x000A16E8 File Offset: 0x0009F8E8
		[DebuggerNonUserCode]
		public static MessageParser<Quests> Parser
		{
			get
			{
				return Quests._parser;
			}
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x0600295E RID: 10590 RVA: 0x000A1700 File Offset: 0x0009F900
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[17];
			}
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x0600295F RID: 10591 RVA: 0x000A1724 File Offset: 0x0009F924
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Quests.Descriptor;
			}
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x000A173C File Offset: 0x0009F93C
		[DebuggerNonUserCode]
		public Quests()
		{
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x000A1788 File Offset: 0x0009F988
		[DebuggerNonUserCode]
		public Quests(Quests other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.savedQuest_ = other.savedQuest_.Clone();
			this.snoCompletedQuest_ = other.snoCompletedQuest_.Clone();
			this.completedRepeatableQuest_ = other.completedRepeatableQuest_.Clone();
			this.reputation_ = ((other.reputation_ != null) ? other.reputation_.Clone() : null);
			this.savedBounty_ = other.savedBounty_.Clone();
			this.completedBounty_ = other.completedBounty_.Clone();
			this.demonScroll_ = ((other.demonScroll_ != null) ? other.demonScroll_.Clone() : null);
			this.maxNightmareDungeonCompleted_ = other.maxNightmareDungeonCompleted_;
			this.subzoneModifierOccurrence_ = other.subzoneModifierOccurrence_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x000A1860 File Offset: 0x0009FA60
		[DebuggerNonUserCode]
		public Quests Clone()
		{
			return new Quests(this);
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x06002963 RID: 10595 RVA: 0x000A1878 File Offset: 0x0009FA78
		[DebuggerNonUserCode]
		public RepeatedField<QuestSavedState> SavedQuest
		{
			get
			{
				return this.savedQuest_;
			}
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x06002964 RID: 10596 RVA: 0x000A1890 File Offset: 0x0009FA90
		[DebuggerNonUserCode]
		public RepeatedField<int> SnoCompletedQuest
		{
			get
			{
				return this.snoCompletedQuest_;
			}
		}

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x06002965 RID: 10597 RVA: 0x000A18A8 File Offset: 0x0009FAA8
		[DebuggerNonUserCode]
		public RepeatedField<CompletedRepeatableQuest> CompletedRepeatableQuest
		{
			get
			{
				return this.completedRepeatableQuest_;
			}
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x06002966 RID: 10598 RVA: 0x000A18C0 File Offset: 0x0009FAC0
		// (set) Token: 0x06002967 RID: 10599 RVA: 0x000A18D8 File Offset: 0x0009FAD8
		[DebuggerNonUserCode]
		public SavedReputation Reputation
		{
			get
			{
				return this.reputation_;
			}
			set
			{
				this.reputation_ = value;
			}
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x06002968 RID: 10600 RVA: 0x000A18E4 File Offset: 0x0009FAE4
		[DebuggerNonUserCode]
		public RepeatedField<QuestSavedState> SavedBounty
		{
			get
			{
				return this.savedBounty_;
			}
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x06002969 RID: 10601 RVA: 0x000A18FC File Offset: 0x0009FAFC
		[DebuggerNonUserCode]
		public RepeatedField<CompletedRepeatableQuest> CompletedBounty
		{
			get
			{
				return this.completedBounty_;
			}
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x0600296A RID: 10602 RVA: 0x000A1914 File Offset: 0x0009FB14
		// (set) Token: 0x0600296B RID: 10603 RVA: 0x000A192C File Offset: 0x0009FB2C
		[DebuggerNonUserCode]
		public EquippedScroll DemonScroll
		{
			get
			{
				return this.demonScroll_;
			}
			set
			{
				this.demonScroll_ = value;
			}
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x0600296C RID: 10604 RVA: 0x000A1938 File Offset: 0x0009FB38
		// (set) Token: 0x0600296D RID: 10605 RVA: 0x000A1969 File Offset: 0x0009FB69
		[DebuggerNonUserCode]
		public int MaxNightmareDungeonCompleted
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int maxNightmareDungeonCompletedDefaultValue;
				if (flag)
				{
					maxNightmareDungeonCompletedDefaultValue = this.maxNightmareDungeonCompleted_;
				}
				else
				{
					maxNightmareDungeonCompletedDefaultValue = Quests.MaxNightmareDungeonCompletedDefaultValue;
				}
				return maxNightmareDungeonCompletedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.maxNightmareDungeonCompleted_ = value;
			}
		}

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x0600296E RID: 10606 RVA: 0x000A1984 File Offset: 0x0009FB84
		[DebuggerNonUserCode]
		public bool HasMaxNightmareDungeonCompleted
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x000A19A1 File Offset: 0x0009FBA1
		[DebuggerNonUserCode]
		public void ClearMaxNightmareDungeonCompleted()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x06002970 RID: 10608 RVA: 0x000A19B4 File Offset: 0x0009FBB4
		// (set) Token: 0x06002971 RID: 10609 RVA: 0x000A19E5 File Offset: 0x0009FBE5
		[DebuggerNonUserCode]
		public int SubzoneModifierOccurrence
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int subzoneModifierOccurrenceDefaultValue;
				if (flag)
				{
					subzoneModifierOccurrenceDefaultValue = this.subzoneModifierOccurrence_;
				}
				else
				{
					subzoneModifierOccurrenceDefaultValue = Quests.SubzoneModifierOccurrenceDefaultValue;
				}
				return subzoneModifierOccurrenceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.subzoneModifierOccurrence_ = value;
			}
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x06002972 RID: 10610 RVA: 0x000A1A00 File Offset: 0x0009FC00
		[DebuggerNonUserCode]
		public bool HasSubzoneModifierOccurrence
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x000A1A1D File Offset: 0x0009FC1D
		[DebuggerNonUserCode]
		public void ClearSubzoneModifierOccurrence()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x000A1A30 File Offset: 0x0009FC30
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Quests);
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x000A1A50 File Offset: 0x0009FC50
		[DebuggerNonUserCode]
		public bool Equals(Quests other)
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
					bool flag4 = !this.savedQuest_.Equals(other.savedQuest_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.snoCompletedQuest_.Equals(other.snoCompletedQuest_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.completedRepeatableQuest_.Equals(other.completedRepeatableQuest_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.Reputation, other.Reputation);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.savedBounty_.Equals(other.savedBounty_);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !this.completedBounty_.Equals(other.completedBounty_);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !object.Equals(this.DemonScroll, other.DemonScroll);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.MaxNightmareDungeonCompleted != other.MaxNightmareDungeonCompleted;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.SubzoneModifierOccurrence != other.SubzoneModifierOccurrence;
													flag2 = !flag12 && object.Equals(this._unknownFields, other._unknownFields);
												}
											}
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

		// Token: 0x06002976 RID: 10614 RVA: 0x000A1BA8 File Offset: 0x0009FDA8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.savedQuest_.GetHashCode();
			num ^= this.snoCompletedQuest_.GetHashCode();
			num ^= this.completedRepeatableQuest_.GetHashCode();
			bool flag = this.reputation_ != null;
			if (flag)
			{
				num ^= this.Reputation.GetHashCode();
			}
			num ^= this.savedBounty_.GetHashCode();
			num ^= this.completedBounty_.GetHashCode();
			bool flag2 = this.demonScroll_ != null;
			if (flag2)
			{
				num ^= this.DemonScroll.GetHashCode();
			}
			bool hasMaxNightmareDungeonCompleted = this.HasMaxNightmareDungeonCompleted;
			if (hasMaxNightmareDungeonCompleted)
			{
				num ^= this.MaxNightmareDungeonCompleted.GetHashCode();
			}
			bool hasSubzoneModifierOccurrence = this.HasSubzoneModifierOccurrence;
			if (hasSubzoneModifierOccurrence)
			{
				num ^= this.SubzoneModifierOccurrence.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002977 RID: 10615 RVA: 0x000A1C94 File Offset: 0x0009FE94
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x000A1CAC File Offset: 0x0009FEAC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x000A1CB8 File Offset: 0x0009FEB8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.savedQuest_.WriteTo(ref output, Quests._repeated_savedQuest_codec);
			this.snoCompletedQuest_.WriteTo(ref output, Quests._repeated_snoCompletedQuest_codec);
			this.completedRepeatableQuest_.WriteTo(ref output, Quests._repeated_completedRepeatableQuest_codec);
			bool flag = this.reputation_ != null;
			if (flag)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Reputation);
			}
			this.savedBounty_.WriteTo(ref output, Quests._repeated_savedBounty_codec);
			this.completedBounty_.WriteTo(ref output, Quests._repeated_completedBounty_codec);
			bool flag2 = this.demonScroll_ != null;
			if (flag2)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.DemonScroll);
			}
			bool hasMaxNightmareDungeonCompleted = this.HasMaxNightmareDungeonCompleted;
			if (hasMaxNightmareDungeonCompleted)
			{
				output.WriteRawTag(96);
				output.WriteSInt32(this.MaxNightmareDungeonCompleted);
			}
			bool hasSubzoneModifierOccurrence = this.HasSubzoneModifierOccurrence;
			if (hasSubzoneModifierOccurrence)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.SubzoneModifierOccurrence);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x000A1DCC File Offset: 0x0009FFCC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.savedQuest_.CalculateSize(Quests._repeated_savedQuest_codec);
			num += this.snoCompletedQuest_.CalculateSize(Quests._repeated_snoCompletedQuest_codec);
			num += this.completedRepeatableQuest_.CalculateSize(Quests._repeated_completedRepeatableQuest_codec);
			bool flag = this.reputation_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reputation);
			}
			num += this.savedBounty_.CalculateSize(Quests._repeated_savedBounty_codec);
			num += this.completedBounty_.CalculateSize(Quests._repeated_completedBounty_codec);
			bool flag2 = this.demonScroll_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DemonScroll);
			}
			bool hasMaxNightmareDungeonCompleted = this.HasMaxNightmareDungeonCompleted;
			if (hasMaxNightmareDungeonCompleted)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.MaxNightmareDungeonCompleted);
			}
			bool hasSubzoneModifierOccurrence = this.HasSubzoneModifierOccurrence;
			if (hasSubzoneModifierOccurrence)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubzoneModifierOccurrence);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x000A1EDC File Offset: 0x000A00DC
		[DebuggerNonUserCode]
		public void MergeFrom(Quests other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.savedQuest_.Add(other.savedQuest_);
				this.snoCompletedQuest_.Add(other.snoCompletedQuest_);
				this.completedRepeatableQuest_.Add(other.completedRepeatableQuest_);
				bool flag2 = other.reputation_ != null;
				if (flag2)
				{
					bool flag3 = this.reputation_ == null;
					if (flag3)
					{
						this.Reputation = new SavedReputation();
					}
					this.Reputation.MergeFrom(other.Reputation);
				}
				this.savedBounty_.Add(other.savedBounty_);
				this.completedBounty_.Add(other.completedBounty_);
				bool flag4 = other.demonScroll_ != null;
				if (flag4)
				{
					bool flag5 = this.demonScroll_ == null;
					if (flag5)
					{
						this.DemonScroll = new EquippedScroll();
					}
					this.DemonScroll.MergeFrom(other.DemonScroll);
				}
				bool hasMaxNightmareDungeonCompleted = other.HasMaxNightmareDungeonCompleted;
				if (hasMaxNightmareDungeonCompleted)
				{
					this.MaxNightmareDungeonCompleted = other.MaxNightmareDungeonCompleted;
				}
				bool hasSubzoneModifierOccurrence = other.HasSubzoneModifierOccurrence;
				if (hasSubzoneModifierOccurrence)
				{
					this.SubzoneModifierOccurrence = other.SubzoneModifierOccurrence;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x000A2019 File Offset: 0x000A0219
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x000A2024 File Offset: 0x000A0224
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 50U)
				{
					if (num3 <= 18U)
					{
						if (num3 == 10U)
						{
							this.savedQuest_.AddEntriesFrom(ref input, Quests._repeated_savedQuest_codec);
							continue;
						}
						if (num3 != 18U)
						{
							goto IL_0078;
						}
					}
					else if (num3 != 21U)
					{
						if (num3 == 26U)
						{
							this.completedRepeatableQuest_.AddEntriesFrom(ref input, Quests._repeated_completedRepeatableQuest_codec);
							continue;
						}
						if (num3 != 50U)
						{
							goto IL_0078;
						}
						bool flag = this.reputation_ == null;
						if (flag)
						{
							this.Reputation = new SavedReputation();
						}
						input.ReadMessage(this.Reputation);
						continue;
					}
					this.snoCompletedQuest_.AddEntriesFrom(ref input, Quests._repeated_snoCompletedQuest_codec);
				}
				else if (num3 <= 66U)
				{
					if (num3 != 58U)
					{
						if (num3 != 66U)
						{
							goto IL_0078;
						}
						this.completedBounty_.AddEntriesFrom(ref input, Quests._repeated_completedBounty_codec);
					}
					else
					{
						this.savedBounty_.AddEntriesFrom(ref input, Quests._repeated_savedBounty_codec);
					}
				}
				else if (num3 != 90U)
				{
					if (num3 != 96U)
					{
						if (num3 != 104U)
						{
							goto IL_0078;
						}
						this.SubzoneModifierOccurrence = input.ReadInt32();
					}
					else
					{
						this.MaxNightmareDungeonCompleted = input.ReadSInt32();
					}
				}
				else
				{
					bool flag2 = this.demonScroll_ == null;
					if (flag2)
					{
						this.DemonScroll = new EquippedScroll();
					}
					input.ReadMessage(this.DemonScroll);
				}
				continue;
				IL_0078:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400126F RID: 4719
		private static readonly MessageParser<Quests> _parser = new MessageParser<Quests>(() => new Quests());

		// Token: 0x04001270 RID: 4720
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001271 RID: 4721
		private int _hasBits0;

		// Token: 0x04001272 RID: 4722
		public const int SavedQuestFieldNumber = 1;

		// Token: 0x04001273 RID: 4723
		private static readonly FieldCodec<QuestSavedState> _repeated_savedQuest_codec = FieldCodec.ForMessage<QuestSavedState>(10U, QuestSavedState.Parser);

		// Token: 0x04001274 RID: 4724
		private readonly RepeatedField<QuestSavedState> savedQuest_ = new RepeatedField<QuestSavedState>();

		// Token: 0x04001275 RID: 4725
		public const int SnoCompletedQuestFieldNumber = 2;

		// Token: 0x04001276 RID: 4726
		private static readonly FieldCodec<int> _repeated_snoCompletedQuest_codec = FieldCodec.ForSFixed32(21U);

		// Token: 0x04001277 RID: 4727
		private readonly RepeatedField<int> snoCompletedQuest_ = new RepeatedField<int>();

		// Token: 0x04001278 RID: 4728
		public const int CompletedRepeatableQuestFieldNumber = 3;

		// Token: 0x04001279 RID: 4729
		private static readonly FieldCodec<CompletedRepeatableQuest> _repeated_completedRepeatableQuest_codec = FieldCodec.ForMessage<CompletedRepeatableQuest>(26U, Fenris.Hero.CompletedRepeatableQuest.Parser);

		// Token: 0x0400127A RID: 4730
		private readonly RepeatedField<CompletedRepeatableQuest> completedRepeatableQuest_ = new RepeatedField<CompletedRepeatableQuest>();

		// Token: 0x0400127B RID: 4731
		public const int ReputationFieldNumber = 6;

		// Token: 0x0400127C RID: 4732
		private SavedReputation reputation_;

		// Token: 0x0400127D RID: 4733
		public const int SavedBountyFieldNumber = 7;

		// Token: 0x0400127E RID: 4734
		private static readonly FieldCodec<QuestSavedState> _repeated_savedBounty_codec = FieldCodec.ForMessage<QuestSavedState>(58U, QuestSavedState.Parser);

		// Token: 0x0400127F RID: 4735
		private readonly RepeatedField<QuestSavedState> savedBounty_ = new RepeatedField<QuestSavedState>();

		// Token: 0x04001280 RID: 4736
		public const int CompletedBountyFieldNumber = 8;

		// Token: 0x04001281 RID: 4737
		private static readonly FieldCodec<CompletedRepeatableQuest> _repeated_completedBounty_codec = FieldCodec.ForMessage<CompletedRepeatableQuest>(66U, Fenris.Hero.CompletedRepeatableQuest.Parser);

		// Token: 0x04001282 RID: 4738
		private readonly RepeatedField<CompletedRepeatableQuest> completedBounty_ = new RepeatedField<CompletedRepeatableQuest>();

		// Token: 0x04001283 RID: 4739
		public const int DemonScrollFieldNumber = 11;

		// Token: 0x04001284 RID: 4740
		private EquippedScroll demonScroll_;

		// Token: 0x04001285 RID: 4741
		public const int MaxNightmareDungeonCompletedFieldNumber = 12;

		// Token: 0x04001286 RID: 4742
		private static readonly int MaxNightmareDungeonCompletedDefaultValue = 0;

		// Token: 0x04001287 RID: 4743
		private int maxNightmareDungeonCompleted_;

		// Token: 0x04001288 RID: 4744
		public const int SubzoneModifierOccurrenceFieldNumber = 13;

		// Token: 0x04001289 RID: 4745
		private static readonly int SubzoneModifierOccurrenceDefaultValue = 0;

		// Token: 0x0400128A RID: 4746
		private int subzoneModifierOccurrence_;
	}
}
