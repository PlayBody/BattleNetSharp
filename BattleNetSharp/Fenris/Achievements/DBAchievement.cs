using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Achievements
{
	// Token: 0x020002CA RID: 714
	public sealed class DBAchievement : IMessage<DBAchievement>, IMessage, IEquatable<DBAchievement>, IDeepCloneable<DBAchievement>, IBufferMessage
	{
		// Token: 0x17001819 RID: 6169
		// (get) Token: 0x06004BDA RID: 19418 RVA: 0x0012232C File Offset: 0x0012052C
		[DebuggerNonUserCode]
		public static MessageParser<DBAchievement> Parser
		{
			get
			{
				return DBAchievement._parser;
			}
		}

		// Token: 0x1700181A RID: 6170
		// (get) Token: 0x06004BDB RID: 19419 RVA: 0x00122344 File Offset: 0x00120544
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AchievementsReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x1700181B RID: 6171
		// (get) Token: 0x06004BDC RID: 19420 RVA: 0x00122368 File Offset: 0x00120568
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DBAchievement.Descriptor;
			}
		}

		// Token: 0x06004BDD RID: 19421 RVA: 0x0012237F File Offset: 0x0012057F
		[DebuggerNonUserCode]
		public DBAchievement()
		{
		}

		// Token: 0x06004BDE RID: 19422 RVA: 0x0012238C File Offset: 0x0012058C
		[DebuggerNonUserCode]
		public DBAchievement(DBAchievement other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.achievementSno_ = other.achievementSno_;
			this.completion_ = other.completion_;
			this.collection_ = other.collection_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004BDF RID: 19423 RVA: 0x001223E4 File Offset: 0x001205E4
		[DebuggerNonUserCode]
		public DBAchievement Clone()
		{
			return new DBAchievement(this);
		}

		// Token: 0x1700181C RID: 6172
		// (get) Token: 0x06004BE0 RID: 19424 RVA: 0x001223FC File Offset: 0x001205FC
		// (set) Token: 0x06004BE1 RID: 19425 RVA: 0x0012242D File Offset: 0x0012062D
		[DebuggerNonUserCode]
		public int AchievementSno
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int achievementSnoDefaultValue;
				if (flag)
				{
					achievementSnoDefaultValue = this.achievementSno_;
				}
				else
				{
					achievementSnoDefaultValue = DBAchievement.AchievementSnoDefaultValue;
				}
				return achievementSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.achievementSno_ = value;
			}
		}

		// Token: 0x1700181D RID: 6173
		// (get) Token: 0x06004BE2 RID: 19426 RVA: 0x00122448 File Offset: 0x00120648
		[DebuggerNonUserCode]
		public bool HasAchievementSno
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004BE3 RID: 19427 RVA: 0x00122465 File Offset: 0x00120665
		[DebuggerNonUserCode]
		public void ClearAchievementSno()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700181E RID: 6174
		// (get) Token: 0x06004BE4 RID: 19428 RVA: 0x00122478 File Offset: 0x00120678
		// (set) Token: 0x06004BE5 RID: 19429 RVA: 0x001224A9 File Offset: 0x001206A9
		[DebuggerNonUserCode]
		public ulong Completion
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong completionDefaultValue;
				if (flag)
				{
					completionDefaultValue = this.completion_;
				}
				else
				{
					completionDefaultValue = DBAchievement.CompletionDefaultValue;
				}
				return completionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.completion_ = value;
			}
		}

		// Token: 0x1700181F RID: 6175
		// (get) Token: 0x06004BE6 RID: 19430 RVA: 0x001224C4 File Offset: 0x001206C4
		[DebuggerNonUserCode]
		public bool HasCompletion
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004BE7 RID: 19431 RVA: 0x001224E1 File Offset: 0x001206E1
		[DebuggerNonUserCode]
		public void ClearCompletion()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001820 RID: 6176
		// (get) Token: 0x06004BE8 RID: 19432 RVA: 0x001224F4 File Offset: 0x001206F4
		// (set) Token: 0x06004BE9 RID: 19433 RVA: 0x00122525 File Offset: 0x00120725
		[DebuggerNonUserCode]
		public ulong Collection
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong collectionDefaultValue;
				if (flag)
				{
					collectionDefaultValue = this.collection_;
				}
				else
				{
					collectionDefaultValue = DBAchievement.CollectionDefaultValue;
				}
				return collectionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.collection_ = value;
			}
		}

		// Token: 0x17001821 RID: 6177
		// (get) Token: 0x06004BEA RID: 19434 RVA: 0x00122540 File Offset: 0x00120740
		[DebuggerNonUserCode]
		public bool HasCollection
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06004BEB RID: 19435 RVA: 0x0012255D File Offset: 0x0012075D
		[DebuggerNonUserCode]
		public void ClearCollection()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06004BEC RID: 19436 RVA: 0x00122570 File Offset: 0x00120770
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DBAchievement);
		}

		// Token: 0x06004BED RID: 19437 RVA: 0x00122590 File Offset: 0x00120790
		[DebuggerNonUserCode]
		public bool Equals(DBAchievement other)
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
					bool flag4 = this.AchievementSno != other.AchievementSno;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Completion != other.Completion;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Collection != other.Collection;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004BEE RID: 19438 RVA: 0x0012261C File Offset: 0x0012081C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAchievementSno = this.HasAchievementSno;
			if (hasAchievementSno)
			{
				num ^= this.AchievementSno.GetHashCode();
			}
			bool hasCompletion = this.HasCompletion;
			if (hasCompletion)
			{
				num ^= this.Completion.GetHashCode();
			}
			bool hasCollection = this.HasCollection;
			if (hasCollection)
			{
				num ^= this.Collection.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004BEF RID: 19439 RVA: 0x001226A8 File Offset: 0x001208A8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004BF0 RID: 19440 RVA: 0x001226C0 File Offset: 0x001208C0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004BF1 RID: 19441 RVA: 0x001226CC File Offset: 0x001208CC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAchievementSno = this.HasAchievementSno;
			if (hasAchievementSno)
			{
				output.WriteRawTag(13);
				output.WriteSFixed32(this.AchievementSno);
			}
			bool hasCompletion = this.HasCompletion;
			if (hasCompletion)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.Completion);
			}
			bool hasCollection = this.HasCollection;
			if (hasCollection)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.Collection);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004BF2 RID: 19442 RVA: 0x0012275C File Offset: 0x0012095C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAchievementSno = this.HasAchievementSno;
			if (hasAchievementSno)
			{
				num += 5;
			}
			bool hasCompletion = this.HasCompletion;
			if (hasCompletion)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Completion);
			}
			bool hasCollection = this.HasCollection;
			if (hasCollection)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Collection);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004BF3 RID: 19443 RVA: 0x001227DC File Offset: 0x001209DC
		[DebuggerNonUserCode]
		public void MergeFrom(DBAchievement other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAchievementSno = other.HasAchievementSno;
				if (hasAchievementSno)
				{
					this.AchievementSno = other.AchievementSno;
				}
				bool hasCompletion = other.HasCompletion;
				if (hasCompletion)
				{
					this.Completion = other.Completion;
				}
				bool hasCollection = other.HasCollection;
				if (hasCollection)
				{
					this.Collection = other.Collection;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004BF4 RID: 19444 RVA: 0x00122857 File Offset: 0x00120A57
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004BF5 RID: 19445 RVA: 0x00122864 File Offset: 0x00120A64
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 13U)
				{
					if (num3 != 16U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Collection = input.ReadUInt64();
						}
					}
					else
					{
						this.Completion = input.ReadUInt64();
					}
				}
				else
				{
					this.AchievementSno = input.ReadSFixed32();
				}
			}
		}

		// Token: 0x040021DC RID: 8668
		private static readonly MessageParser<DBAchievement> _parser = new MessageParser<DBAchievement>(() => new DBAchievement());

		// Token: 0x040021DD RID: 8669
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021DE RID: 8670
		private int _hasBits0;

		// Token: 0x040021DF RID: 8671
		public const int AchievementSnoFieldNumber = 1;

		// Token: 0x040021E0 RID: 8672
		private static readonly int AchievementSnoDefaultValue = -1;

		// Token: 0x040021E1 RID: 8673
		private int achievementSno_;

		// Token: 0x040021E2 RID: 8674
		public const int CompletionFieldNumber = 2;

		// Token: 0x040021E3 RID: 8675
		private static readonly ulong CompletionDefaultValue = 0UL;

		// Token: 0x040021E4 RID: 8676
		private ulong completion_;

		// Token: 0x040021E5 RID: 8677
		public const int CollectionFieldNumber = 3;

		// Token: 0x040021E6 RID: 8678
		private static readonly ulong CollectionDefaultValue = 0UL;

		// Token: 0x040021E7 RID: 8679
		private ulong collection_;
	}
}
