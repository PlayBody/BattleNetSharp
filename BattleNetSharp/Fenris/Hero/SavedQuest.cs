using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x0200019C RID: 412
	public sealed class SavedQuest : IMessage<SavedQuest>, IMessage, IEquatable<SavedQuest>, IDeepCloneable<SavedQuest>, IBufferMessage
	{
		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x06002B7F RID: 11135 RVA: 0x000AB7BC File Offset: 0x000A99BC
		[DebuggerNonUserCode]
		public static MessageParser<SavedQuest> Parser
		{
			get
			{
				return SavedQuest._parser;
			}
		}

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x06002B80 RID: 11136 RVA: 0x000AB7D4 File Offset: 0x000A99D4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroCommonReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x06002B81 RID: 11137 RVA: 0x000AB7F8 File Offset: 0x000A99F8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SavedQuest.Descriptor;
			}
		}

		// Token: 0x06002B82 RID: 11138 RVA: 0x000AB80F File Offset: 0x000A9A0F
		[DebuggerNonUserCode]
		public SavedQuest()
		{
		}

		// Token: 0x06002B83 RID: 11139 RVA: 0x000AB830 File Offset: 0x000A9A30
		[DebuggerNonUserCode]
		public SavedQuest(SavedQuest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoQuest_ = other.snoQuest_;
			this.difficultyDeprecated_ = other.difficultyDeprecated_;
			this.currentStepUid_ = other.currentStepUid_;
			this.objectiveState_ = other.objectiveState_.Clone();
			this.failureConditionState_ = other.failureConditionState_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002B84 RID: 11140 RVA: 0x000AB8A8 File Offset: 0x000A9AA8
		[DebuggerNonUserCode]
		public SavedQuest Clone()
		{
			return new SavedQuest(this);
		}

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x06002B85 RID: 11141 RVA: 0x000AB8C0 File Offset: 0x000A9AC0
		// (set) Token: 0x06002B86 RID: 11142 RVA: 0x000AB8F1 File Offset: 0x000A9AF1
		[DebuggerNonUserCode]
		public int SnoQuest
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoQuestDefaultValue;
				if (flag)
				{
					snoQuestDefaultValue = this.snoQuest_;
				}
				else
				{
					snoQuestDefaultValue = SavedQuest.SnoQuestDefaultValue;
				}
				return snoQuestDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoQuest_ = value;
			}
		}

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x06002B87 RID: 11143 RVA: 0x000AB90C File Offset: 0x000A9B0C
		[DebuggerNonUserCode]
		public bool HasSnoQuest
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002B88 RID: 11144 RVA: 0x000AB929 File Offset: 0x000A9B29
		[DebuggerNonUserCode]
		public void ClearSnoQuest()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x06002B89 RID: 11145 RVA: 0x000AB93C File Offset: 0x000A9B3C
		// (set) Token: 0x06002B8A RID: 11146 RVA: 0x000AB96D File Offset: 0x000A9B6D
		[DebuggerNonUserCode]
		public int DifficultyDeprecated
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int difficultyDeprecatedDefaultValue;
				if (flag)
				{
					difficultyDeprecatedDefaultValue = this.difficultyDeprecated_;
				}
				else
				{
					difficultyDeprecatedDefaultValue = SavedQuest.DifficultyDeprecatedDefaultValue;
				}
				return difficultyDeprecatedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.difficultyDeprecated_ = value;
			}
		}

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x06002B8B RID: 11147 RVA: 0x000AB988 File Offset: 0x000A9B88
		[DebuggerNonUserCode]
		public bool HasDifficultyDeprecated
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x000AB9A5 File Offset: 0x000A9BA5
		[DebuggerNonUserCode]
		public void ClearDifficultyDeprecated()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x06002B8D RID: 11149 RVA: 0x000AB9B8 File Offset: 0x000A9BB8
		// (set) Token: 0x06002B8E RID: 11150 RVA: 0x000AB9E9 File Offset: 0x000A9BE9
		[DebuggerNonUserCode]
		public int CurrentStepUid
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int currentStepUidDefaultValue;
				if (flag)
				{
					currentStepUidDefaultValue = this.currentStepUid_;
				}
				else
				{
					currentStepUidDefaultValue = SavedQuest.CurrentStepUidDefaultValue;
				}
				return currentStepUidDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.currentStepUid_ = value;
			}
		}

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x06002B8F RID: 11151 RVA: 0x000ABA04 File Offset: 0x000A9C04
		[DebuggerNonUserCode]
		public bool HasCurrentStepUid
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06002B90 RID: 11152 RVA: 0x000ABA21 File Offset: 0x000A9C21
		[DebuggerNonUserCode]
		public void ClearCurrentStepUid()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x06002B91 RID: 11153 RVA: 0x000ABA34 File Offset: 0x000A9C34
		[DebuggerNonUserCode]
		public RepeatedField<int> ObjectiveState
		{
			get
			{
				return this.objectiveState_;
			}
		}

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x06002B92 RID: 11154 RVA: 0x000ABA4C File Offset: 0x000A9C4C
		[DebuggerNonUserCode]
		public RepeatedField<int> FailureConditionState
		{
			get
			{
				return this.failureConditionState_;
			}
		}

		// Token: 0x06002B93 RID: 11155 RVA: 0x000ABA64 File Offset: 0x000A9C64
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SavedQuest);
		}

		// Token: 0x06002B94 RID: 11156 RVA: 0x000ABA84 File Offset: 0x000A9C84
		[DebuggerNonUserCode]
		public bool Equals(SavedQuest other)
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
					bool flag4 = this.SnoQuest != other.SnoQuest;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.DifficultyDeprecated != other.DifficultyDeprecated;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.CurrentStepUid != other.CurrentStepUid;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.objectiveState_.Equals(other.objectiveState_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.failureConditionState_.Equals(other.failureConditionState_);
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002B95 RID: 11157 RVA: 0x000ABB58 File Offset: 0x000A9D58
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoQuest = this.HasSnoQuest;
			if (hasSnoQuest)
			{
				num ^= this.SnoQuest.GetHashCode();
			}
			bool hasDifficultyDeprecated = this.HasDifficultyDeprecated;
			if (hasDifficultyDeprecated)
			{
				num ^= this.DifficultyDeprecated.GetHashCode();
			}
			bool hasCurrentStepUid = this.HasCurrentStepUid;
			if (hasCurrentStepUid)
			{
				num ^= this.CurrentStepUid.GetHashCode();
			}
			num ^= this.objectiveState_.GetHashCode();
			num ^= this.failureConditionState_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002B96 RID: 11158 RVA: 0x000ABC00 File Offset: 0x000A9E00
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002B97 RID: 11159 RVA: 0x000ABC18 File Offset: 0x000A9E18
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002B98 RID: 11160 RVA: 0x000ABC24 File Offset: 0x000A9E24
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoQuest = this.HasSnoQuest;
			if (hasSnoQuest)
			{
				output.WriteRawTag(13);
				output.WriteSFixed32(this.SnoQuest);
			}
			bool hasDifficultyDeprecated = this.HasDifficultyDeprecated;
			if (hasDifficultyDeprecated)
			{
				output.WriteRawTag(16);
				output.WriteSInt32(this.DifficultyDeprecated);
			}
			bool hasCurrentStepUid = this.HasCurrentStepUid;
			if (hasCurrentStepUid)
			{
				output.WriteRawTag(24);
				output.WriteSInt32(this.CurrentStepUid);
			}
			this.objectiveState_.WriteTo(ref output, SavedQuest._repeated_objectiveState_codec);
			this.failureConditionState_.WriteTo(ref output, SavedQuest._repeated_failureConditionState_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002B99 RID: 11161 RVA: 0x000ABCD8 File Offset: 0x000A9ED8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoQuest = this.HasSnoQuest;
			if (hasSnoQuest)
			{
				num += 5;
			}
			bool hasDifficultyDeprecated = this.HasDifficultyDeprecated;
			if (hasDifficultyDeprecated)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.DifficultyDeprecated);
			}
			bool hasCurrentStepUid = this.HasCurrentStepUid;
			if (hasCurrentStepUid)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.CurrentStepUid);
			}
			num += this.objectiveState_.CalculateSize(SavedQuest._repeated_objectiveState_codec);
			num += this.failureConditionState_.CalculateSize(SavedQuest._repeated_failureConditionState_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002B9A RID: 11162 RVA: 0x000ABD7C File Offset: 0x000A9F7C
		[DebuggerNonUserCode]
		public void MergeFrom(SavedQuest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoQuest = other.HasSnoQuest;
				if (hasSnoQuest)
				{
					this.SnoQuest = other.SnoQuest;
				}
				bool hasDifficultyDeprecated = other.HasDifficultyDeprecated;
				if (hasDifficultyDeprecated)
				{
					this.DifficultyDeprecated = other.DifficultyDeprecated;
				}
				bool hasCurrentStepUid = other.HasCurrentStepUid;
				if (hasCurrentStepUid)
				{
					this.CurrentStepUid = other.CurrentStepUid;
				}
				this.objectiveState_.Add(other.objectiveState_);
				this.failureConditionState_.Add(other.failureConditionState_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002B9B RID: 11163 RVA: 0x000ABE1E File Offset: 0x000AA01E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002B9C RID: 11164 RVA: 0x000ABE2C File Offset: 0x000AA02C
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
					if (num3 != 13U)
					{
						if (num3 != 16U)
						{
							if (num3 != 24U)
							{
								goto IL_0046;
							}
							this.CurrentStepUid = input.ReadSInt32();
						}
						else
						{
							this.DifficultyDeprecated = input.ReadSInt32();
						}
					}
					else
					{
						this.SnoQuest = input.ReadSFixed32();
					}
				}
				else if (num3 <= 34U)
				{
					if (num3 != 32U && num3 != 34U)
					{
						goto IL_0046;
					}
					this.objectiveState_.AddEntriesFrom(ref input, SavedQuest._repeated_objectiveState_codec);
				}
				else
				{
					if (num3 != 40U && num3 != 42U)
					{
						goto IL_0046;
					}
					this.failureConditionState_.AddEntriesFrom(ref input, SavedQuest._repeated_failureConditionState_codec);
				}
				continue;
				IL_0046:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040013B0 RID: 5040
		private static readonly MessageParser<SavedQuest> _parser = new MessageParser<SavedQuest>(() => new SavedQuest());

		// Token: 0x040013B1 RID: 5041
		private UnknownFieldSet _unknownFields;

		// Token: 0x040013B2 RID: 5042
		private int _hasBits0;

		// Token: 0x040013B3 RID: 5043
		public const int SnoQuestFieldNumber = 1;

		// Token: 0x040013B4 RID: 5044
		private static readonly int SnoQuestDefaultValue = -1;

		// Token: 0x040013B5 RID: 5045
		private int snoQuest_;

		// Token: 0x040013B6 RID: 5046
		public const int DifficultyDeprecatedFieldNumber = 2;

		// Token: 0x040013B7 RID: 5047
		private static readonly int DifficultyDeprecatedDefaultValue = 0;

		// Token: 0x040013B8 RID: 5048
		private int difficultyDeprecated_;

		// Token: 0x040013B9 RID: 5049
		public const int CurrentStepUidFieldNumber = 3;

		// Token: 0x040013BA RID: 5050
		private static readonly int CurrentStepUidDefaultValue = -1;

		// Token: 0x040013BB RID: 5051
		private int currentStepUid_;

		// Token: 0x040013BC RID: 5052
		public const int ObjectiveStateFieldNumber = 4;

		// Token: 0x040013BD RID: 5053
		private static readonly FieldCodec<int> _repeated_objectiveState_codec = FieldCodec.ForSInt32(34U);

		// Token: 0x040013BE RID: 5054
		private readonly RepeatedField<int> objectiveState_ = new RepeatedField<int>();

		// Token: 0x040013BF RID: 5055
		public const int FailureConditionStateFieldNumber = 5;

		// Token: 0x040013C0 RID: 5056
		private static readonly FieldCodec<int> _repeated_failureConditionState_codec = FieldCodec.ForSInt32(42U);

		// Token: 0x040013C1 RID: 5057
		private readonly RepeatedField<int> failureConditionState_ = new RepeatedField<int>();
	}
}
