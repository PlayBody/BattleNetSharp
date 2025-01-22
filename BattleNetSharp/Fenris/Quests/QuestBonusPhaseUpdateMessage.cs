using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Quests
{
	// Token: 0x0200012B RID: 299
	public sealed class QuestBonusPhaseUpdateMessage : IMessage<QuestBonusPhaseUpdateMessage>, IMessage, IEquatable<QuestBonusPhaseUpdateMessage>, IDeepCloneable<QuestBonusPhaseUpdateMessage>, IBufferMessage
	{
		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06001DEE RID: 7662 RVA: 0x00073358 File Offset: 0x00071558
		[DebuggerNonUserCode]
		public static MessageParser<QuestBonusPhaseUpdateMessage> Parser
		{
			get
			{
				return QuestBonusPhaseUpdateMessage._parser;
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06001DEF RID: 7663 RVA: 0x00073370 File Offset: 0x00071570
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return QuestReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x00073394 File Offset: 0x00071594
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestBonusPhaseUpdateMessage.Descriptor;
			}
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x000733AB File Offset: 0x000715AB
		[DebuggerNonUserCode]
		public QuestBonusPhaseUpdateMessage()
		{
		}

		// Token: 0x06001DF2 RID: 7666 RVA: 0x000733B8 File Offset: 0x000715B8
		[DebuggerNonUserCode]
		public QuestBonusPhaseUpdateMessage(QuestBonusPhaseUpdateMessage other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.questId_ = other.questId_;
			this.bonusPhaseId_ = other.bonusPhaseId_;
			this.bonusPhaseState_ = other.bonusPhaseState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001DF3 RID: 7667 RVA: 0x00073410 File Offset: 0x00071610
		[DebuggerNonUserCode]
		public QuestBonusPhaseUpdateMessage Clone()
		{
			return new QuestBonusPhaseUpdateMessage(this);
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06001DF4 RID: 7668 RVA: 0x00073428 File Offset: 0x00071628
		// (set) Token: 0x06001DF5 RID: 7669 RVA: 0x00073459 File Offset: 0x00071659
		[DebuggerNonUserCode]
		public int QuestId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int questIdDefaultValue;
				if (flag)
				{
					questIdDefaultValue = this.questId_;
				}
				else
				{
					questIdDefaultValue = QuestBonusPhaseUpdateMessage.QuestIdDefaultValue;
				}
				return questIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.questId_ = value;
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06001DF6 RID: 7670 RVA: 0x00073474 File Offset: 0x00071674
		[DebuggerNonUserCode]
		public bool HasQuestId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x00073491 File Offset: 0x00071691
		[DebuggerNonUserCode]
		public void ClearQuestId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06001DF8 RID: 7672 RVA: 0x000734A4 File Offset: 0x000716A4
		// (set) Token: 0x06001DF9 RID: 7673 RVA: 0x000734D5 File Offset: 0x000716D5
		[DebuggerNonUserCode]
		public int BonusPhaseId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int bonusPhaseIdDefaultValue;
				if (flag)
				{
					bonusPhaseIdDefaultValue = this.bonusPhaseId_;
				}
				else
				{
					bonusPhaseIdDefaultValue = QuestBonusPhaseUpdateMessage.BonusPhaseIdDefaultValue;
				}
				return bonusPhaseIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.bonusPhaseId_ = value;
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06001DFA RID: 7674 RVA: 0x000734F0 File Offset: 0x000716F0
		[DebuggerNonUserCode]
		public bool HasBonusPhaseId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x0007350D File Offset: 0x0007170D
		[DebuggerNonUserCode]
		public void ClearBonusPhaseId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06001DFC RID: 7676 RVA: 0x00073520 File Offset: 0x00071720
		// (set) Token: 0x06001DFD RID: 7677 RVA: 0x00073551 File Offset: 0x00071751
		[DebuggerNonUserCode]
		public int BonusPhaseState
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int bonusPhaseStateDefaultValue;
				if (flag)
				{
					bonusPhaseStateDefaultValue = this.bonusPhaseState_;
				}
				else
				{
					bonusPhaseStateDefaultValue = QuestBonusPhaseUpdateMessage.BonusPhaseStateDefaultValue;
				}
				return bonusPhaseStateDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.bonusPhaseState_ = value;
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06001DFE RID: 7678 RVA: 0x0007356C File Offset: 0x0007176C
		[DebuggerNonUserCode]
		public bool HasBonusPhaseState
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x00073589 File Offset: 0x00071789
		[DebuggerNonUserCode]
		public void ClearBonusPhaseState()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x0007359C File Offset: 0x0007179C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestBonusPhaseUpdateMessage);
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x000735BC File Offset: 0x000717BC
		[DebuggerNonUserCode]
		public bool Equals(QuestBonusPhaseUpdateMessage other)
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
					bool flag4 = this.QuestId != other.QuestId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.BonusPhaseId != other.BonusPhaseId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.BonusPhaseState != other.BonusPhaseState;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x00073648 File Offset: 0x00071848
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasQuestId = this.HasQuestId;
			if (hasQuestId)
			{
				num ^= this.QuestId.GetHashCode();
			}
			bool hasBonusPhaseId = this.HasBonusPhaseId;
			if (hasBonusPhaseId)
			{
				num ^= this.BonusPhaseId.GetHashCode();
			}
			bool hasBonusPhaseState = this.HasBonusPhaseState;
			if (hasBonusPhaseState)
			{
				num ^= this.BonusPhaseState.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x000736D4 File Offset: 0x000718D4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001E04 RID: 7684 RVA: 0x000736EC File Offset: 0x000718EC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x000736F8 File Offset: 0x000718F8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasQuestId = this.HasQuestId;
			if (hasQuestId)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.QuestId);
			}
			bool hasBonusPhaseId = this.HasBonusPhaseId;
			if (hasBonusPhaseId)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.BonusPhaseId);
			}
			bool hasBonusPhaseState = this.HasBonusPhaseState;
			if (hasBonusPhaseState)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.BonusPhaseState);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x00073788 File Offset: 0x00071988
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasQuestId = this.HasQuestId;
			if (hasQuestId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			bool hasBonusPhaseId = this.HasBonusPhaseId;
			if (hasBonusPhaseId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BonusPhaseId);
			}
			bool hasBonusPhaseState = this.HasBonusPhaseState;
			if (hasBonusPhaseState)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BonusPhaseState);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x00073814 File Offset: 0x00071A14
		[DebuggerNonUserCode]
		public void MergeFrom(QuestBonusPhaseUpdateMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasQuestId = other.HasQuestId;
				if (hasQuestId)
				{
					this.QuestId = other.QuestId;
				}
				bool hasBonusPhaseId = other.HasBonusPhaseId;
				if (hasBonusPhaseId)
				{
					this.BonusPhaseId = other.BonusPhaseId;
				}
				bool hasBonusPhaseState = other.HasBonusPhaseState;
				if (hasBonusPhaseState)
				{
					this.BonusPhaseState = other.BonusPhaseState;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x0007388F File Offset: 0x00071A8F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x0007389C File Offset: 0x00071A9C
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
							this.BonusPhaseState = input.ReadInt32();
						}
					}
					else
					{
						this.BonusPhaseId = input.ReadInt32();
					}
				}
				else
				{
					this.QuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000CE1 RID: 3297
		private static readonly MessageParser<QuestBonusPhaseUpdateMessage> _parser = new MessageParser<QuestBonusPhaseUpdateMessage>(() => new QuestBonusPhaseUpdateMessage());

		// Token: 0x04000CE2 RID: 3298
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000CE3 RID: 3299
		private int _hasBits0;

		// Token: 0x04000CE4 RID: 3300
		public const int QuestIdFieldNumber = 1;

		// Token: 0x04000CE5 RID: 3301
		private static readonly int QuestIdDefaultValue = 0;

		// Token: 0x04000CE6 RID: 3302
		private int questId_;

		// Token: 0x04000CE7 RID: 3303
		public const int BonusPhaseIdFieldNumber = 2;

		// Token: 0x04000CE8 RID: 3304
		private static readonly int BonusPhaseIdDefaultValue = 0;

		// Token: 0x04000CE9 RID: 3305
		private int bonusPhaseId_;

		// Token: 0x04000CEA RID: 3306
		public const int BonusPhaseStateFieldNumber = 3;

		// Token: 0x04000CEB RID: 3307
		private static readonly int BonusPhaseStateDefaultValue = 0;

		// Token: 0x04000CEC RID: 3308
		private int bonusPhaseState_;
	}
}
