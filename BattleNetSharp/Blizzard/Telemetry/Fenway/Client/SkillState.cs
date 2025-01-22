using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x0200032F RID: 815
	public sealed class SkillState : IMessage<SkillState>, IMessage, IEquatable<SkillState>, IDeepCloneable<SkillState>, IBufferMessage
	{
		// Token: 0x17001B77 RID: 7031
		// (get) Token: 0x0600551D RID: 21789 RVA: 0x00148F94 File Offset: 0x00147194
		[DebuggerNonUserCode]
		public static MessageParser<SkillState> Parser
		{
			get
			{
				return SkillState._parser;
			}
		}

		// Token: 0x17001B78 RID: 7032
		// (get) Token: 0x0600551E RID: 21790 RVA: 0x00148FAC File Offset: 0x001471AC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CommonSkillStateReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17001B79 RID: 7033
		// (get) Token: 0x0600551F RID: 21791 RVA: 0x00148FD0 File Offset: 0x001471D0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkillState.Descriptor;
			}
		}

		// Token: 0x06005520 RID: 21792 RVA: 0x00148FE7 File Offset: 0x001471E7
		[DebuggerNonUserCode]
		public SkillState()
		{
		}

		// Token: 0x06005521 RID: 21793 RVA: 0x00148FFC File Offset: 0x001471FC
		[DebuggerNonUserCode]
		public SkillState(SkillState other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.skillPointsUsed_ = other.skillPointsUsed_;
			this.skillPointsAvailable_ = other.skillPointsAvailable_;
			this.skills_ = other.skills_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005522 RID: 21794 RVA: 0x00149058 File Offset: 0x00147258
		[DebuggerNonUserCode]
		public SkillState Clone()
		{
			return new SkillState(this);
		}

		// Token: 0x17001B7A RID: 7034
		// (get) Token: 0x06005523 RID: 21795 RVA: 0x00149070 File Offset: 0x00147270
		// (set) Token: 0x06005524 RID: 21796 RVA: 0x001490A1 File Offset: 0x001472A1
		[DebuggerNonUserCode]
		public ulong SkillPointsUsed
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong skillPointsUsedDefaultValue;
				if (flag)
				{
					skillPointsUsedDefaultValue = this.skillPointsUsed_;
				}
				else
				{
					skillPointsUsedDefaultValue = SkillState.SkillPointsUsedDefaultValue;
				}
				return skillPointsUsedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.skillPointsUsed_ = value;
			}
		}

		// Token: 0x17001B7B RID: 7035
		// (get) Token: 0x06005525 RID: 21797 RVA: 0x001490BC File Offset: 0x001472BC
		[DebuggerNonUserCode]
		public bool HasSkillPointsUsed
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005526 RID: 21798 RVA: 0x001490D9 File Offset: 0x001472D9
		[DebuggerNonUserCode]
		public void ClearSkillPointsUsed()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001B7C RID: 7036
		// (get) Token: 0x06005527 RID: 21799 RVA: 0x001490EC File Offset: 0x001472EC
		// (set) Token: 0x06005528 RID: 21800 RVA: 0x0014911D File Offset: 0x0014731D
		[DebuggerNonUserCode]
		public ulong SkillPointsAvailable
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong skillPointsAvailableDefaultValue;
				if (flag)
				{
					skillPointsAvailableDefaultValue = this.skillPointsAvailable_;
				}
				else
				{
					skillPointsAvailableDefaultValue = SkillState.SkillPointsAvailableDefaultValue;
				}
				return skillPointsAvailableDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.skillPointsAvailable_ = value;
			}
		}

		// Token: 0x17001B7D RID: 7037
		// (get) Token: 0x06005529 RID: 21801 RVA: 0x00149138 File Offset: 0x00147338
		[DebuggerNonUserCode]
		public bool HasSkillPointsAvailable
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600552A RID: 21802 RVA: 0x00149155 File Offset: 0x00147355
		[DebuggerNonUserCode]
		public void ClearSkillPointsAvailable()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001B7E RID: 7038
		// (get) Token: 0x0600552B RID: 21803 RVA: 0x00149168 File Offset: 0x00147368
		[DebuggerNonUserCode]
		public RepeatedField<Skill> Skills
		{
			get
			{
				return this.skills_;
			}
		}

		// Token: 0x0600552C RID: 21804 RVA: 0x00149180 File Offset: 0x00147380
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkillState);
		}

		// Token: 0x0600552D RID: 21805 RVA: 0x001491A0 File Offset: 0x001473A0
		[DebuggerNonUserCode]
		public bool Equals(SkillState other)
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
					bool flag4 = this.SkillPointsUsed != other.SkillPointsUsed;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SkillPointsAvailable != other.SkillPointsAvailable;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.skills_.Equals(other.skills_);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600552E RID: 21806 RVA: 0x00149230 File Offset: 0x00147430
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSkillPointsUsed = this.HasSkillPointsUsed;
			if (hasSkillPointsUsed)
			{
				num ^= this.SkillPointsUsed.GetHashCode();
			}
			bool hasSkillPointsAvailable = this.HasSkillPointsAvailable;
			if (hasSkillPointsAvailable)
			{
				num ^= this.SkillPointsAvailable.GetHashCode();
			}
			num ^= this.skills_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600552F RID: 21807 RVA: 0x001492AC File Offset: 0x001474AC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005530 RID: 21808 RVA: 0x001492C4 File Offset: 0x001474C4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005531 RID: 21809 RVA: 0x001492D0 File Offset: 0x001474D0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSkillPointsUsed = this.HasSkillPointsUsed;
			if (hasSkillPointsUsed)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.SkillPointsUsed);
			}
			bool hasSkillPointsAvailable = this.HasSkillPointsAvailable;
			if (hasSkillPointsAvailable)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.SkillPointsAvailable);
			}
			this.skills_.WriteTo(ref output, SkillState._repeated_skills_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005532 RID: 21810 RVA: 0x00149350 File Offset: 0x00147550
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSkillPointsUsed = this.HasSkillPointsUsed;
			if (hasSkillPointsUsed)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.SkillPointsUsed);
			}
			bool hasSkillPointsAvailable = this.HasSkillPointsAvailable;
			if (hasSkillPointsAvailable)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.SkillPointsAvailable);
			}
			num += this.skills_.CalculateSize(SkillState._repeated_skills_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005533 RID: 21811 RVA: 0x001493D0 File Offset: 0x001475D0
		[DebuggerNonUserCode]
		public void MergeFrom(SkillState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSkillPointsUsed = other.HasSkillPointsUsed;
				if (hasSkillPointsUsed)
				{
					this.SkillPointsUsed = other.SkillPointsUsed;
				}
				bool hasSkillPointsAvailable = other.HasSkillPointsAvailable;
				if (hasSkillPointsAvailable)
				{
					this.SkillPointsAvailable = other.SkillPointsAvailable;
				}
				this.skills_.Add(other.skills_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005534 RID: 21812 RVA: 0x00149444 File Offset: 0x00147644
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005535 RID: 21813 RVA: 0x00149450 File Offset: 0x00147650
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.skills_.AddEntriesFrom(ref input, SkillState._repeated_skills_codec);
						}
					}
					else
					{
						this.SkillPointsAvailable = input.ReadUInt64();
					}
				}
				else
				{
					this.SkillPointsUsed = input.ReadUInt64();
				}
			}
		}

		// Token: 0x040026AF RID: 9903
		private static readonly MessageParser<SkillState> _parser = new MessageParser<SkillState>(() => new SkillState());

		// Token: 0x040026B0 RID: 9904
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026B1 RID: 9905
		private int _hasBits0;

		// Token: 0x040026B2 RID: 9906
		public const int SkillPointsUsedFieldNumber = 1;

		// Token: 0x040026B3 RID: 9907
		private static readonly ulong SkillPointsUsedDefaultValue = 0UL;

		// Token: 0x040026B4 RID: 9908
		private ulong skillPointsUsed_;

		// Token: 0x040026B5 RID: 9909
		public const int SkillPointsAvailableFieldNumber = 2;

		// Token: 0x040026B6 RID: 9910
		private static readonly ulong SkillPointsAvailableDefaultValue = 0UL;

		// Token: 0x040026B7 RID: 9911
		private ulong skillPointsAvailable_;

		// Token: 0x040026B8 RID: 9912
		public const int SkillsFieldNumber = 3;

		// Token: 0x040026B9 RID: 9913
		private static readonly FieldCodec<Skill> _repeated_skills_codec = FieldCodec.ForMessage<Skill>(26U, Skill.Parser);

		// Token: 0x040026BA RID: 9914
		private readonly RepeatedField<Skill> skills_ = new RepeatedField<Skill>();
	}
}
