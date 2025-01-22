using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001D1 RID: 465
	public sealed class ProgressDiabloRequest : IMessage<ProgressDiabloRequest>, IMessage, IEquatable<ProgressDiabloRequest>, IDeepCloneable<ProgressDiabloRequest>, IBufferMessage
	{
		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x060031CD RID: 12749 RVA: 0x000C52D4 File Offset: 0x000C34D4
		[DebuggerNonUserCode]
		public static MessageParser<ProgressDiabloRequest> Parser
		{
			get
			{
				return ProgressDiabloRequest._parser;
			}
		}

		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x060031CE RID: 12750 RVA: 0x000C52EC File Offset: 0x000C34EC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[22];
			}
		}

		// Token: 0x17001015 RID: 4117
		// (get) Token: 0x060031CF RID: 12751 RVA: 0x000C5310 File Offset: 0x000C3510
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ProgressDiabloRequest.Descriptor;
			}
		}

		// Token: 0x060031D0 RID: 12752 RVA: 0x000C5327 File Offset: 0x000C3527
		[DebuggerNonUserCode]
		public ProgressDiabloRequest()
		{
		}

		// Token: 0x060031D1 RID: 12753 RVA: 0x000C5334 File Offset: 0x000C3534
		[DebuggerNonUserCode]
		public ProgressDiabloRequest(ProgressDiabloRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.endConditionType_ = other.endConditionType_;
			this.runGoal_ = other.runGoal_;
			this.levelGoal_ = other.levelGoal_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060031D2 RID: 12754 RVA: 0x000C538C File Offset: 0x000C358C
		[DebuggerNonUserCode]
		public ProgressDiabloRequest Clone()
		{
			return new ProgressDiabloRequest(this);
		}

		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x060031D3 RID: 12755 RVA: 0x000C53A4 File Offset: 0x000C35A4
		// (set) Token: 0x060031D4 RID: 12756 RVA: 0x000C53D5 File Offset: 0x000C35D5
		[DebuggerNonUserCode]
		public ProgressDiabloEndConditionType EndConditionType
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ProgressDiabloEndConditionType endConditionTypeDefaultValue;
				if (flag)
				{
					endConditionTypeDefaultValue = this.endConditionType_;
				}
				else
				{
					endConditionTypeDefaultValue = ProgressDiabloRequest.EndConditionTypeDefaultValue;
				}
				return endConditionTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.endConditionType_ = value;
			}
		}

		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x060031D5 RID: 12757 RVA: 0x000C53F0 File Offset: 0x000C35F0
		[DebuggerNonUserCode]
		public bool HasEndConditionType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060031D6 RID: 12758 RVA: 0x000C540D File Offset: 0x000C360D
		[DebuggerNonUserCode]
		public void ClearEndConditionType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001018 RID: 4120
		// (get) Token: 0x060031D7 RID: 12759 RVA: 0x000C5420 File Offset: 0x000C3620
		// (set) Token: 0x060031D8 RID: 12760 RVA: 0x000C5451 File Offset: 0x000C3651
		[DebuggerNonUserCode]
		public int RunGoal
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int runGoalDefaultValue;
				if (flag)
				{
					runGoalDefaultValue = this.runGoal_;
				}
				else
				{
					runGoalDefaultValue = ProgressDiabloRequest.RunGoalDefaultValue;
				}
				return runGoalDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.runGoal_ = value;
			}
		}

		// Token: 0x17001019 RID: 4121
		// (get) Token: 0x060031D9 RID: 12761 RVA: 0x000C546C File Offset: 0x000C366C
		[DebuggerNonUserCode]
		public bool HasRunGoal
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060031DA RID: 12762 RVA: 0x000C5489 File Offset: 0x000C3689
		[DebuggerNonUserCode]
		public void ClearRunGoal()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700101A RID: 4122
		// (get) Token: 0x060031DB RID: 12763 RVA: 0x000C549C File Offset: 0x000C369C
		// (set) Token: 0x060031DC RID: 12764 RVA: 0x000C54CD File Offset: 0x000C36CD
		[DebuggerNonUserCode]
		public int LevelGoal
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int levelGoalDefaultValue;
				if (flag)
				{
					levelGoalDefaultValue = this.levelGoal_;
				}
				else
				{
					levelGoalDefaultValue = ProgressDiabloRequest.LevelGoalDefaultValue;
				}
				return levelGoalDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.levelGoal_ = value;
			}
		}

		// Token: 0x1700101B RID: 4123
		// (get) Token: 0x060031DD RID: 12765 RVA: 0x000C54E8 File Offset: 0x000C36E8
		[DebuggerNonUserCode]
		public bool HasLevelGoal
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060031DE RID: 12766 RVA: 0x000C5505 File Offset: 0x000C3705
		[DebuggerNonUserCode]
		public void ClearLevelGoal()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x060031DF RID: 12767 RVA: 0x000C5518 File Offset: 0x000C3718
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ProgressDiabloRequest);
		}

		// Token: 0x060031E0 RID: 12768 RVA: 0x000C5538 File Offset: 0x000C3738
		[DebuggerNonUserCode]
		public bool Equals(ProgressDiabloRequest other)
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
					bool flag4 = this.EndConditionType != other.EndConditionType;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.RunGoal != other.RunGoal;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.LevelGoal != other.LevelGoal;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060031E1 RID: 12769 RVA: 0x000C55C4 File Offset: 0x000C37C4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasEndConditionType = this.HasEndConditionType;
			if (hasEndConditionType)
			{
				num ^= this.EndConditionType.GetHashCode();
			}
			bool hasRunGoal = this.HasRunGoal;
			if (hasRunGoal)
			{
				num ^= this.RunGoal.GetHashCode();
			}
			bool hasLevelGoal = this.HasLevelGoal;
			if (hasLevelGoal)
			{
				num ^= this.LevelGoal.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060031E2 RID: 12770 RVA: 0x000C5658 File Offset: 0x000C3858
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060031E3 RID: 12771 RVA: 0x000C5670 File Offset: 0x000C3870
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060031E4 RID: 12772 RVA: 0x000C567C File Offset: 0x000C387C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasEndConditionType = this.HasEndConditionType;
			if (hasEndConditionType)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.EndConditionType);
			}
			bool hasRunGoal = this.HasRunGoal;
			if (hasRunGoal)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RunGoal);
			}
			bool hasLevelGoal = this.HasLevelGoal;
			if (hasLevelGoal)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.LevelGoal);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060031E5 RID: 12773 RVA: 0x000C570C File Offset: 0x000C390C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasEndConditionType = this.HasEndConditionType;
			if (hasEndConditionType)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.EndConditionType);
			}
			bool hasRunGoal = this.HasRunGoal;
			if (hasRunGoal)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RunGoal);
			}
			bool hasLevelGoal = this.HasLevelGoal;
			if (hasLevelGoal)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelGoal);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060031E6 RID: 12774 RVA: 0x000C5798 File Offset: 0x000C3998
		[DebuggerNonUserCode]
		public void MergeFrom(ProgressDiabloRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasEndConditionType = other.HasEndConditionType;
				if (hasEndConditionType)
				{
					this.EndConditionType = other.EndConditionType;
				}
				bool hasRunGoal = other.HasRunGoal;
				if (hasRunGoal)
				{
					this.RunGoal = other.RunGoal;
				}
				bool hasLevelGoal = other.HasLevelGoal;
				if (hasLevelGoal)
				{
					this.LevelGoal = other.LevelGoal;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060031E7 RID: 12775 RVA: 0x000C5813 File Offset: 0x000C3A13
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060031E8 RID: 12776 RVA: 0x000C5820 File Offset: 0x000C3A20
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
							this.LevelGoal = input.ReadInt32();
						}
					}
					else
					{
						this.RunGoal = input.ReadInt32();
					}
				}
				else
				{
					this.EndConditionType = (ProgressDiabloEndConditionType)input.ReadEnum();
				}
			}
		}

		// Token: 0x040016D9 RID: 5849
		private static readonly MessageParser<ProgressDiabloRequest> _parser = new MessageParser<ProgressDiabloRequest>(() => new ProgressDiabloRequest());

		// Token: 0x040016DA RID: 5850
		private UnknownFieldSet _unknownFields;

		// Token: 0x040016DB RID: 5851
		private int _hasBits0;

		// Token: 0x040016DC RID: 5852
		public const int EndConditionTypeFieldNumber = 1;

		// Token: 0x040016DD RID: 5853
		private static readonly ProgressDiabloEndConditionType EndConditionTypeDefaultValue = ProgressDiabloEndConditionType.RunCount;

		// Token: 0x040016DE RID: 5854
		private ProgressDiabloEndConditionType endConditionType_;

		// Token: 0x040016DF RID: 5855
		public const int RunGoalFieldNumber = 2;

		// Token: 0x040016E0 RID: 5856
		private static readonly int RunGoalDefaultValue = 0;

		// Token: 0x040016E1 RID: 5857
		private int runGoal_;

		// Token: 0x040016E2 RID: 5858
		public const int LevelGoalFieldNumber = 3;

		// Token: 0x040016E3 RID: 5859
		private static readonly int LevelGoalDefaultValue = 0;

		// Token: 0x040016E4 RID: 5860
		private int levelGoal_;
	}
}
