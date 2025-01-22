using System;
using System.Diagnostics;
using Fenris.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Quests
{
	// Token: 0x0200012E RID: 302
	public sealed class QuestGrantedItems : IMessage<QuestGrantedItems>, IMessage, IEquatable<QuestGrantedItems>, IDeepCloneable<QuestGrantedItems>, IBufferMessage
	{
		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06001E41 RID: 7745 RVA: 0x000743CC File Offset: 0x000725CC
		[DebuggerNonUserCode]
		public static MessageParser<QuestGrantedItems> Parser
		{
			get
			{
				return QuestGrantedItems._parser;
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06001E42 RID: 7746 RVA: 0x000743E4 File Offset: 0x000725E4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return QuestReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06001E43 RID: 7747 RVA: 0x00074408 File Offset: 0x00072608
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestGrantedItems.Descriptor;
			}
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x0007441F File Offset: 0x0007261F
		[DebuggerNonUserCode]
		public QuestGrantedItems()
		{
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x00074434 File Offset: 0x00072634
		[DebuggerNonUserCode]
		public QuestGrantedItems(QuestGrantedItems other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.ownerGameAccountId_ = other.ownerGameAccountId_;
			this.snoQuest_ = other.snoQuest_;
			this.items_ = other.items_.Clone();
			this.wasFlippyCreated_ = other.wasFlippyCreated_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x0007449C File Offset: 0x0007269C
		[DebuggerNonUserCode]
		public QuestGrantedItems Clone()
		{
			return new QuestGrantedItems(this);
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06001E47 RID: 7751 RVA: 0x000744B4 File Offset: 0x000726B4
		// (set) Token: 0x06001E48 RID: 7752 RVA: 0x000744E5 File Offset: 0x000726E5
		[DebuggerNonUserCode]
		public uint OwnerGameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint ownerGameAccountIdDefaultValue;
				if (flag)
				{
					ownerGameAccountIdDefaultValue = this.ownerGameAccountId_;
				}
				else
				{
					ownerGameAccountIdDefaultValue = QuestGrantedItems.OwnerGameAccountIdDefaultValue;
				}
				return ownerGameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.ownerGameAccountId_ = value;
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06001E49 RID: 7753 RVA: 0x00074500 File Offset: 0x00072700
		[DebuggerNonUserCode]
		public bool HasOwnerGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x0007451D File Offset: 0x0007271D
		[DebuggerNonUserCode]
		public void ClearOwnerGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06001E4B RID: 7755 RVA: 0x00074530 File Offset: 0x00072730
		// (set) Token: 0x06001E4C RID: 7756 RVA: 0x00074561 File Offset: 0x00072761
		[DebuggerNonUserCode]
		public int SnoQuest
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int snoQuestDefaultValue;
				if (flag)
				{
					snoQuestDefaultValue = this.snoQuest_;
				}
				else
				{
					snoQuestDefaultValue = QuestGrantedItems.SnoQuestDefaultValue;
				}
				return snoQuestDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoQuest_ = value;
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06001E4D RID: 7757 RVA: 0x0007457C File Offset: 0x0007277C
		[DebuggerNonUserCode]
		public bool HasSnoQuest
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x00074599 File Offset: 0x00072799
		[DebuggerNonUserCode]
		public void ClearSnoQuest()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06001E4F RID: 7759 RVA: 0x000745AC File Offset: 0x000727AC
		[DebuggerNonUserCode]
		public RepeatedField<Generator> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06001E50 RID: 7760 RVA: 0x000745C4 File Offset: 0x000727C4
		// (set) Token: 0x06001E51 RID: 7761 RVA: 0x000745F5 File Offset: 0x000727F5
		[DebuggerNonUserCode]
		public bool WasFlippyCreated
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool wasFlippyCreatedDefaultValue;
				if (flag)
				{
					wasFlippyCreatedDefaultValue = this.wasFlippyCreated_;
				}
				else
				{
					wasFlippyCreatedDefaultValue = QuestGrantedItems.WasFlippyCreatedDefaultValue;
				}
				return wasFlippyCreatedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.wasFlippyCreated_ = value;
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06001E52 RID: 7762 RVA: 0x00074610 File Offset: 0x00072810
		[DebuggerNonUserCode]
		public bool HasWasFlippyCreated
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x0007462D File Offset: 0x0007282D
		[DebuggerNonUserCode]
		public void ClearWasFlippyCreated()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x00074640 File Offset: 0x00072840
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestGrantedItems);
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x00074660 File Offset: 0x00072860
		[DebuggerNonUserCode]
		public bool Equals(QuestGrantedItems other)
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
					bool flag4 = this.OwnerGameAccountId != other.OwnerGameAccountId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoQuest != other.SnoQuest;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.items_.Equals(other.items_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.WasFlippyCreated != other.WasFlippyCreated;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x00074710 File Offset: 0x00072910
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasOwnerGameAccountId = this.HasOwnerGameAccountId;
			if (hasOwnerGameAccountId)
			{
				num ^= this.OwnerGameAccountId.GetHashCode();
			}
			bool hasSnoQuest = this.HasSnoQuest;
			if (hasSnoQuest)
			{
				num ^= this.SnoQuest.GetHashCode();
			}
			num ^= this.items_.GetHashCode();
			bool hasWasFlippyCreated = this.HasWasFlippyCreated;
			if (hasWasFlippyCreated)
			{
				num ^= this.WasFlippyCreated.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x000747AC File Offset: 0x000729AC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x000747C4 File Offset: 0x000729C4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x000747D0 File Offset: 0x000729D0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasOwnerGameAccountId = this.HasOwnerGameAccountId;
			if (hasOwnerGameAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.OwnerGameAccountId);
			}
			bool hasSnoQuest = this.HasSnoQuest;
			if (hasSnoQuest)
			{
				output.WriteRawTag(21);
				output.WriteSFixed32(this.SnoQuest);
			}
			this.items_.WriteTo(ref output, QuestGrantedItems._repeated_items_codec);
			bool hasWasFlippyCreated = this.HasWasFlippyCreated;
			if (hasWasFlippyCreated)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.WasFlippyCreated);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x00074874 File Offset: 0x00072A74
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasOwnerGameAccountId = this.HasOwnerGameAccountId;
			if (hasOwnerGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OwnerGameAccountId);
			}
			bool hasSnoQuest = this.HasSnoQuest;
			if (hasSnoQuest)
			{
				num += 5;
			}
			num += this.items_.CalculateSize(QuestGrantedItems._repeated_items_codec);
			bool hasWasFlippyCreated = this.HasWasFlippyCreated;
			if (hasWasFlippyCreated)
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

		// Token: 0x06001E5B RID: 7771 RVA: 0x000748FC File Offset: 0x00072AFC
		[DebuggerNonUserCode]
		public void MergeFrom(QuestGrantedItems other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasOwnerGameAccountId = other.HasOwnerGameAccountId;
				if (hasOwnerGameAccountId)
				{
					this.OwnerGameAccountId = other.OwnerGameAccountId;
				}
				bool hasSnoQuest = other.HasSnoQuest;
				if (hasSnoQuest)
				{
					this.SnoQuest = other.SnoQuest;
				}
				this.items_.Add(other.items_);
				bool hasWasFlippyCreated = other.HasWasFlippyCreated;
				if (hasWasFlippyCreated)
				{
					this.WasFlippyCreated = other.WasFlippyCreated;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x00074989 File Offset: 0x00072B89
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x00074994 File Offset: 0x00072B94
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 21U)
				{
					if (num3 != 8U)
					{
						if (num3 != 21U)
						{
							goto IL_0028;
						}
						this.SnoQuest = input.ReadSFixed32();
					}
					else
					{
						this.OwnerGameAccountId = input.ReadUInt32();
					}
				}
				else if (num3 != 42U)
				{
					if (num3 != 48U)
					{
						goto IL_0028;
					}
					this.WasFlippyCreated = input.ReadBool();
				}
				else
				{
					this.items_.AddEntriesFrom(ref input, QuestGrantedItems._repeated_items_codec);
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000D02 RID: 3330
		private static readonly MessageParser<QuestGrantedItems> _parser = new MessageParser<QuestGrantedItems>(() => new QuestGrantedItems());

		// Token: 0x04000D03 RID: 3331
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D04 RID: 3332
		private int _hasBits0;

		// Token: 0x04000D05 RID: 3333
		public const int OwnerGameAccountIdFieldNumber = 1;

		// Token: 0x04000D06 RID: 3334
		private static readonly uint OwnerGameAccountIdDefaultValue = 0U;

		// Token: 0x04000D07 RID: 3335
		private uint ownerGameAccountId_;

		// Token: 0x04000D08 RID: 3336
		public const int SnoQuestFieldNumber = 2;

		// Token: 0x04000D09 RID: 3337
		private static readonly int SnoQuestDefaultValue = -1;

		// Token: 0x04000D0A RID: 3338
		private int snoQuest_;

		// Token: 0x04000D0B RID: 3339
		public const int ItemsFieldNumber = 5;

		// Token: 0x04000D0C RID: 3340
		private static readonly FieldCodec<Generator> _repeated_items_codec = FieldCodec.ForMessage<Generator>(42U, Generator.Parser);

		// Token: 0x04000D0D RID: 3341
		private readonly RepeatedField<Generator> items_ = new RepeatedField<Generator>();

		// Token: 0x04000D0E RID: 3342
		public const int WasFlippyCreatedFieldNumber = 6;

		// Token: 0x04000D0F RID: 3343
		private static readonly bool WasFlippyCreatedDefaultValue = false;

		// Token: 0x04000D10 RID: 3344
		private bool wasFlippyCreated_;
	}
}
