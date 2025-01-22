using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Achievements
{
	// Token: 0x020002C3 RID: 707
	public sealed class Achievement : IMessage<Achievement>, IMessage, IEquatable<Achievement>, IDeepCloneable<Achievement>, IBufferMessage
	{
		// Token: 0x170017DC RID: 6108
		// (get) Token: 0x06004B16 RID: 19222 RVA: 0x0011F9A8 File Offset: 0x0011DBA8
		[DebuggerNonUserCode]
		public static MessageParser<Achievement> Parser
		{
			get
			{
				return Achievement._parser;
			}
		}

		// Token: 0x170017DD RID: 6109
		// (get) Token: 0x06004B17 RID: 19223 RVA: 0x0011F9C0 File Offset: 0x0011DBC0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AchievementsReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170017DE RID: 6110
		// (get) Token: 0x06004B18 RID: 19224 RVA: 0x0011F9E4 File Offset: 0x0011DBE4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Achievement.Descriptor;
			}
		}

		// Token: 0x06004B19 RID: 19225 RVA: 0x0011F9FB File Offset: 0x0011DBFB
		[DebuggerNonUserCode]
		public Achievement()
		{
		}

		// Token: 0x06004B1A RID: 19226 RVA: 0x0011FA08 File Offset: 0x0011DC08
		[DebuggerNonUserCode]
		public Achievement(Achievement other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.achievementSno_ = other.achievementSno_;
			this.completion_ = other.completion_;
			this.collection_ = other.collection_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004B1B RID: 19227 RVA: 0x0011FA60 File Offset: 0x0011DC60
		[DebuggerNonUserCode]
		public Achievement Clone()
		{
			return new Achievement(this);
		}

		// Token: 0x170017DF RID: 6111
		// (get) Token: 0x06004B1C RID: 19228 RVA: 0x0011FA78 File Offset: 0x0011DC78
		// (set) Token: 0x06004B1D RID: 19229 RVA: 0x0011FAA9 File Offset: 0x0011DCA9
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
					achievementSnoDefaultValue = Achievement.AchievementSnoDefaultValue;
				}
				return achievementSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.achievementSno_ = value;
			}
		}

		// Token: 0x170017E0 RID: 6112
		// (get) Token: 0x06004B1E RID: 19230 RVA: 0x0011FAC4 File Offset: 0x0011DCC4
		[DebuggerNonUserCode]
		public bool HasAchievementSno
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004B1F RID: 19231 RVA: 0x0011FAE1 File Offset: 0x0011DCE1
		[DebuggerNonUserCode]
		public void ClearAchievementSno()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170017E1 RID: 6113
		// (get) Token: 0x06004B20 RID: 19232 RVA: 0x0011FAF4 File Offset: 0x0011DCF4
		// (set) Token: 0x06004B21 RID: 19233 RVA: 0x0011FB25 File Offset: 0x0011DD25
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
					completionDefaultValue = Achievement.CompletionDefaultValue;
				}
				return completionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.completion_ = value;
			}
		}

		// Token: 0x170017E2 RID: 6114
		// (get) Token: 0x06004B22 RID: 19234 RVA: 0x0011FB40 File Offset: 0x0011DD40
		[DebuggerNonUserCode]
		public bool HasCompletion
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004B23 RID: 19235 RVA: 0x0011FB5D File Offset: 0x0011DD5D
		[DebuggerNonUserCode]
		public void ClearCompletion()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170017E3 RID: 6115
		// (get) Token: 0x06004B24 RID: 19236 RVA: 0x0011FB70 File Offset: 0x0011DD70
		// (set) Token: 0x06004B25 RID: 19237 RVA: 0x0011FBA1 File Offset: 0x0011DDA1
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
					collectionDefaultValue = Achievement.CollectionDefaultValue;
				}
				return collectionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.collection_ = value;
			}
		}

		// Token: 0x170017E4 RID: 6116
		// (get) Token: 0x06004B26 RID: 19238 RVA: 0x0011FBBC File Offset: 0x0011DDBC
		[DebuggerNonUserCode]
		public bool HasCollection
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06004B27 RID: 19239 RVA: 0x0011FBD9 File Offset: 0x0011DDD9
		[DebuggerNonUserCode]
		public void ClearCollection()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06004B28 RID: 19240 RVA: 0x0011FBEC File Offset: 0x0011DDEC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Achievement);
		}

		// Token: 0x06004B29 RID: 19241 RVA: 0x0011FC0C File Offset: 0x0011DE0C
		[DebuggerNonUserCode]
		public bool Equals(Achievement other)
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

		// Token: 0x06004B2A RID: 19242 RVA: 0x0011FC98 File Offset: 0x0011DE98
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

		// Token: 0x06004B2B RID: 19243 RVA: 0x0011FD24 File Offset: 0x0011DF24
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004B2C RID: 19244 RVA: 0x0011FD3C File Offset: 0x0011DF3C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B2D RID: 19245 RVA: 0x0011FD48 File Offset: 0x0011DF48
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

		// Token: 0x06004B2E RID: 19246 RVA: 0x0011FDD8 File Offset: 0x0011DFD8
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

		// Token: 0x06004B2F RID: 19247 RVA: 0x0011FE58 File Offset: 0x0011E058
		[DebuggerNonUserCode]
		public void MergeFrom(Achievement other)
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

		// Token: 0x06004B30 RID: 19248 RVA: 0x0011FED3 File Offset: 0x0011E0D3
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004B31 RID: 19249 RVA: 0x0011FEE0 File Offset: 0x0011E0E0
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

		// Token: 0x04002186 RID: 8582
		private static readonly MessageParser<Achievement> _parser = new MessageParser<Achievement>(() => new Achievement());

		// Token: 0x04002187 RID: 8583
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002188 RID: 8584
		private int _hasBits0;

		// Token: 0x04002189 RID: 8585
		public const int AchievementSnoFieldNumber = 1;

		// Token: 0x0400218A RID: 8586
		private static readonly int AchievementSnoDefaultValue = -1;

		// Token: 0x0400218B RID: 8587
		private int achievementSno_;

		// Token: 0x0400218C RID: 8588
		public const int CompletionFieldNumber = 2;

		// Token: 0x0400218D RID: 8589
		private static readonly ulong CompletionDefaultValue = 0UL;

		// Token: 0x0400218E RID: 8590
		private ulong completion_;

		// Token: 0x0400218F RID: 8591
		public const int CollectionFieldNumber = 3;

		// Token: 0x04002190 RID: 8592
		private static readonly ulong CollectionDefaultValue = 0UL;

		// Token: 0x04002191 RID: 8593
		private ulong collection_;
	}
}
