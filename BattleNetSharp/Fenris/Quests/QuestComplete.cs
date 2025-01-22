using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Quests
{
	// Token: 0x02000130 RID: 304
	public sealed class QuestComplete : IMessage<QuestComplete>, IMessage, IEquatable<QuestComplete>, IDeepCloneable<QuestComplete>, IBufferMessage
	{
		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06001E8B RID: 7819 RVA: 0x0007569C File Offset: 0x0007389C
		[DebuggerNonUserCode]
		public static MessageParser<QuestComplete> Parser
		{
			get
			{
				return QuestComplete._parser;
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06001E8C RID: 7820 RVA: 0x000756B4 File Offset: 0x000738B4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return QuestReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06001E8D RID: 7821 RVA: 0x000756D8 File Offset: 0x000738D8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestComplete.Descriptor;
			}
		}

		// Token: 0x06001E8E RID: 7822 RVA: 0x000756EF File Offset: 0x000738EF
		[DebuggerNonUserCode]
		public QuestComplete()
		{
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x00075704 File Offset: 0x00073904
		[DebuggerNonUserCode]
		public QuestComplete(QuestComplete other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoQuest_ = other.snoQuest_;
			this.rewards_ = other.rewards_.Clone();
			this.isFailure_ = other.isFailure_;
			this.isSynced_ = other.isSynced_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x0007576C File Offset: 0x0007396C
		[DebuggerNonUserCode]
		public QuestComplete Clone()
		{
			return new QuestComplete(this);
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06001E91 RID: 7825 RVA: 0x00075784 File Offset: 0x00073984
		// (set) Token: 0x06001E92 RID: 7826 RVA: 0x000757B5 File Offset: 0x000739B5
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
					snoQuestDefaultValue = QuestComplete.SnoQuestDefaultValue;
				}
				return snoQuestDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoQuest_ = value;
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06001E93 RID: 7827 RVA: 0x000757D0 File Offset: 0x000739D0
		[DebuggerNonUserCode]
		public bool HasSnoQuest
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001E94 RID: 7828 RVA: 0x000757ED File Offset: 0x000739ED
		[DebuggerNonUserCode]
		public void ClearSnoQuest()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06001E95 RID: 7829 RVA: 0x00075800 File Offset: 0x00073A00
		[DebuggerNonUserCode]
		public RepeatedField<QuestReward> Rewards
		{
			get
			{
				return this.rewards_;
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06001E96 RID: 7830 RVA: 0x00075818 File Offset: 0x00073A18
		// (set) Token: 0x06001E97 RID: 7831 RVA: 0x00075849 File Offset: 0x00073A49
		[DebuggerNonUserCode]
		public bool IsFailure
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool isFailureDefaultValue;
				if (flag)
				{
					isFailureDefaultValue = this.isFailure_;
				}
				else
				{
					isFailureDefaultValue = QuestComplete.IsFailureDefaultValue;
				}
				return isFailureDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.isFailure_ = value;
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06001E98 RID: 7832 RVA: 0x00075864 File Offset: 0x00073A64
		[DebuggerNonUserCode]
		public bool HasIsFailure
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x00075881 File Offset: 0x00073A81
		[DebuggerNonUserCode]
		public void ClearIsFailure()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06001E9A RID: 7834 RVA: 0x00075894 File Offset: 0x00073A94
		// (set) Token: 0x06001E9B RID: 7835 RVA: 0x000758C5 File Offset: 0x00073AC5
		[DebuggerNonUserCode]
		public bool IsSynced
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool isSyncedDefaultValue;
				if (flag)
				{
					isSyncedDefaultValue = this.isSynced_;
				}
				else
				{
					isSyncedDefaultValue = QuestComplete.IsSyncedDefaultValue;
				}
				return isSyncedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.isSynced_ = value;
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06001E9C RID: 7836 RVA: 0x000758E0 File Offset: 0x00073AE0
		[DebuggerNonUserCode]
		public bool HasIsSynced
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x000758FD File Offset: 0x00073AFD
		[DebuggerNonUserCode]
		public void ClearIsSynced()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x00075910 File Offset: 0x00073B10
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestComplete);
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x00075930 File Offset: 0x00073B30
		[DebuggerNonUserCode]
		public bool Equals(QuestComplete other)
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
						bool flag5 = !this.rewards_.Equals(other.rewards_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.IsFailure != other.IsFailure;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.IsSynced != other.IsSynced;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x000759E0 File Offset: 0x00073BE0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoQuest = this.HasSnoQuest;
			if (hasSnoQuest)
			{
				num ^= this.SnoQuest.GetHashCode();
			}
			num ^= this.rewards_.GetHashCode();
			bool hasIsFailure = this.HasIsFailure;
			if (hasIsFailure)
			{
				num ^= this.IsFailure.GetHashCode();
			}
			bool hasIsSynced = this.HasIsSynced;
			if (hasIsSynced)
			{
				num ^= this.IsSynced.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x00075A7C File Offset: 0x00073C7C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x00075A94 File Offset: 0x00073C94
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x00075AA0 File Offset: 0x00073CA0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoQuest = this.HasSnoQuest;
			if (hasSnoQuest)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoQuest);
			}
			this.rewards_.WriteTo(ref output, QuestComplete._repeated_rewards_codec);
			bool hasIsFailure = this.HasIsFailure;
			if (hasIsFailure)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsFailure);
			}
			bool hasIsSynced = this.HasIsSynced;
			if (hasIsSynced)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsSynced);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x00075B44 File Offset: 0x00073D44
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoQuest = this.HasSnoQuest;
			if (hasSnoQuest)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoQuest);
			}
			num += this.rewards_.CalculateSize(QuestComplete._repeated_rewards_codec);
			bool hasIsFailure = this.HasIsFailure;
			if (hasIsFailure)
			{
				num += 2;
			}
			bool hasIsSynced = this.HasIsSynced;
			if (hasIsSynced)
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

		// Token: 0x06001EA5 RID: 7845 RVA: 0x00075BCC File Offset: 0x00073DCC
		[DebuggerNonUserCode]
		public void MergeFrom(QuestComplete other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoQuest = other.HasSnoQuest;
				if (hasSnoQuest)
				{
					this.SnoQuest = other.SnoQuest;
				}
				this.rewards_.Add(other.rewards_);
				bool hasIsFailure = other.HasIsFailure;
				if (hasIsFailure)
				{
					this.IsFailure = other.IsFailure;
				}
				bool hasIsSynced = other.HasIsSynced;
				if (hasIsSynced)
				{
					this.IsSynced = other.IsSynced;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x00075C59 File Offset: 0x00073E59
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x00075C64 File Offset: 0x00073E64
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 8U)
					{
						if (num3 != 18U)
						{
							goto IL_0028;
						}
						this.rewards_.AddEntriesFrom(ref input, QuestComplete._repeated_rewards_codec);
					}
					else
					{
						this.SnoQuest = input.ReadInt32();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_0028;
					}
					this.IsSynced = input.ReadBool();
				}
				else
				{
					this.IsFailure = input.ReadBool();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000D2F RID: 3375
		private static readonly MessageParser<QuestComplete> _parser = new MessageParser<QuestComplete>(() => new QuestComplete());

		// Token: 0x04000D30 RID: 3376
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D31 RID: 3377
		private int _hasBits0;

		// Token: 0x04000D32 RID: 3378
		public const int SnoQuestFieldNumber = 1;

		// Token: 0x04000D33 RID: 3379
		private static readonly int SnoQuestDefaultValue = 0;

		// Token: 0x04000D34 RID: 3380
		private int snoQuest_;

		// Token: 0x04000D35 RID: 3381
		public const int RewardsFieldNumber = 2;

		// Token: 0x04000D36 RID: 3382
		private static readonly FieldCodec<QuestReward> _repeated_rewards_codec = FieldCodec.ForMessage<QuestReward>(18U, QuestReward.Parser);

		// Token: 0x04000D37 RID: 3383
		private readonly RepeatedField<QuestReward> rewards_ = new RepeatedField<QuestReward>();

		// Token: 0x04000D38 RID: 3384
		public const int IsFailureFieldNumber = 3;

		// Token: 0x04000D39 RID: 3385
		private static readonly bool IsFailureDefaultValue = false;

		// Token: 0x04000D3A RID: 3386
		private bool isFailure_;

		// Token: 0x04000D3B RID: 3387
		public const int IsSyncedFieldNumber = 4;

		// Token: 0x04000D3C RID: 3388
		private static readonly bool IsSyncedDefaultValue = false;

		// Token: 0x04000D3D RID: 3389
		private bool isSynced_;
	}
}
