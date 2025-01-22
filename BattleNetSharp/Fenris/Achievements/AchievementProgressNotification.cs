using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Achievements
{
	// Token: 0x020002C9 RID: 713
	public sealed class AchievementProgressNotification : IMessage<AchievementProgressNotification>, IMessage, IEquatable<AchievementProgressNotification>, IDeepCloneable<AchievementProgressNotification>, IBufferMessage
	{
		// Token: 0x1700180C RID: 6156
		// (get) Token: 0x06004BB5 RID: 19381 RVA: 0x00121AC4 File Offset: 0x0011FCC4
		[DebuggerNonUserCode]
		public static MessageParser<AchievementProgressNotification> Parser
		{
			get
			{
				return AchievementProgressNotification._parser;
			}
		}

		// Token: 0x1700180D RID: 6157
		// (get) Token: 0x06004BB6 RID: 19382 RVA: 0x00121ADC File Offset: 0x0011FCDC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AchievementsReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x1700180E RID: 6158
		// (get) Token: 0x06004BB7 RID: 19383 RVA: 0x00121B00 File Offset: 0x0011FD00
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementProgressNotification.Descriptor;
			}
		}

		// Token: 0x06004BB8 RID: 19384 RVA: 0x00121B17 File Offset: 0x0011FD17
		[DebuggerNonUserCode]
		public AchievementProgressNotification()
		{
		}

		// Token: 0x06004BB9 RID: 19385 RVA: 0x00121B24 File Offset: 0x0011FD24
		[DebuggerNonUserCode]
		public AchievementProgressNotification(AchievementProgressNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameAccountId_ = other.gameAccountId_;
			this.accountId_ = other.accountId_;
			this.achievementSno_ = other.achievementSno_;
			this.criteriaId_ = other.criteriaId_;
			this.quantity_ = other.quantity_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004BBA RID: 19386 RVA: 0x00121B94 File Offset: 0x0011FD94
		[DebuggerNonUserCode]
		public AchievementProgressNotification Clone()
		{
			return new AchievementProgressNotification(this);
		}

		// Token: 0x1700180F RID: 6159
		// (get) Token: 0x06004BBB RID: 19387 RVA: 0x00121BAC File Offset: 0x0011FDAC
		// (set) Token: 0x06004BBC RID: 19388 RVA: 0x00121BDD File Offset: 0x0011FDDD
		[DebuggerNonUserCode]
		public uint GameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint gameAccountIdDefaultValue;
				if (flag)
				{
					gameAccountIdDefaultValue = this.gameAccountId_;
				}
				else
				{
					gameAccountIdDefaultValue = AchievementProgressNotification.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x17001810 RID: 6160
		// (get) Token: 0x06004BBD RID: 19389 RVA: 0x00121BF8 File Offset: 0x0011FDF8
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004BBE RID: 19390 RVA: 0x00121C15 File Offset: 0x0011FE15
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001811 RID: 6161
		// (get) Token: 0x06004BBF RID: 19391 RVA: 0x00121C28 File Offset: 0x0011FE28
		// (set) Token: 0x06004BC0 RID: 19392 RVA: 0x00121C59 File Offset: 0x0011FE59
		[DebuggerNonUserCode]
		public uint AccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint accountIdDefaultValue;
				if (flag)
				{
					accountIdDefaultValue = this.accountId_;
				}
				else
				{
					accountIdDefaultValue = AchievementProgressNotification.AccountIdDefaultValue;
				}
				return accountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.accountId_ = value;
			}
		}

		// Token: 0x17001812 RID: 6162
		// (get) Token: 0x06004BC1 RID: 19393 RVA: 0x00121C74 File Offset: 0x0011FE74
		[DebuggerNonUserCode]
		public bool HasAccountId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004BC2 RID: 19394 RVA: 0x00121C91 File Offset: 0x0011FE91
		[DebuggerNonUserCode]
		public void ClearAccountId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001813 RID: 6163
		// (get) Token: 0x06004BC3 RID: 19395 RVA: 0x00121CA4 File Offset: 0x0011FEA4
		// (set) Token: 0x06004BC4 RID: 19396 RVA: 0x00121CD5 File Offset: 0x0011FED5
		[DebuggerNonUserCode]
		public int AchievementSno
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int achievementSnoDefaultValue;
				if (flag)
				{
					achievementSnoDefaultValue = this.achievementSno_;
				}
				else
				{
					achievementSnoDefaultValue = AchievementProgressNotification.AchievementSnoDefaultValue;
				}
				return achievementSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.achievementSno_ = value;
			}
		}

		// Token: 0x17001814 RID: 6164
		// (get) Token: 0x06004BC5 RID: 19397 RVA: 0x00121CF0 File Offset: 0x0011FEF0
		[DebuggerNonUserCode]
		public bool HasAchievementSno
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06004BC6 RID: 19398 RVA: 0x00121D0D File Offset: 0x0011FF0D
		[DebuggerNonUserCode]
		public void ClearAchievementSno()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001815 RID: 6165
		// (get) Token: 0x06004BC7 RID: 19399 RVA: 0x00121D20 File Offset: 0x0011FF20
		// (set) Token: 0x06004BC8 RID: 19400 RVA: 0x00121D51 File Offset: 0x0011FF51
		[DebuggerNonUserCode]
		public int CriteriaId
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int criteriaIdDefaultValue;
				if (flag)
				{
					criteriaIdDefaultValue = this.criteriaId_;
				}
				else
				{
					criteriaIdDefaultValue = AchievementProgressNotification.CriteriaIdDefaultValue;
				}
				return criteriaIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.criteriaId_ = value;
			}
		}

		// Token: 0x17001816 RID: 6166
		// (get) Token: 0x06004BC9 RID: 19401 RVA: 0x00121D6C File Offset: 0x0011FF6C
		[DebuggerNonUserCode]
		public bool HasCriteriaId
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06004BCA RID: 19402 RVA: 0x00121D89 File Offset: 0x0011FF89
		[DebuggerNonUserCode]
		public void ClearCriteriaId()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17001817 RID: 6167
		// (get) Token: 0x06004BCB RID: 19403 RVA: 0x00121D9C File Offset: 0x0011FF9C
		// (set) Token: 0x06004BCC RID: 19404 RVA: 0x00121DCE File Offset: 0x0011FFCE
		[DebuggerNonUserCode]
		public ulong Quantity
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				ulong quantityDefaultValue;
				if (flag)
				{
					quantityDefaultValue = this.quantity_;
				}
				else
				{
					quantityDefaultValue = AchievementProgressNotification.QuantityDefaultValue;
				}
				return quantityDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.quantity_ = value;
			}
		}

		// Token: 0x17001818 RID: 6168
		// (get) Token: 0x06004BCD RID: 19405 RVA: 0x00121DE8 File Offset: 0x0011FFE8
		[DebuggerNonUserCode]
		public bool HasQuantity
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06004BCE RID: 19406 RVA: 0x00121E06 File Offset: 0x00120006
		[DebuggerNonUserCode]
		public void ClearQuantity()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x06004BCF RID: 19407 RVA: 0x00121E18 File Offset: 0x00120018
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementProgressNotification);
		}

		// Token: 0x06004BD0 RID: 19408 RVA: 0x00121E38 File Offset: 0x00120038
		[DebuggerNonUserCode]
		public bool Equals(AchievementProgressNotification other)
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
					bool flag4 = this.GameAccountId != other.GameAccountId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.AccountId != other.AccountId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.AchievementSno != other.AchievementSno;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.CriteriaId != other.CriteriaId;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Quantity != other.Quantity;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004BD1 RID: 19409 RVA: 0x00121F04 File Offset: 0x00120104
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num ^= this.AccountId.GetHashCode();
			}
			bool hasAchievementSno = this.HasAchievementSno;
			if (hasAchievementSno)
			{
				num ^= this.AchievementSno.GetHashCode();
			}
			bool hasCriteriaId = this.HasCriteriaId;
			if (hasCriteriaId)
			{
				num ^= this.CriteriaId.GetHashCode();
			}
			bool hasQuantity = this.HasQuantity;
			if (hasQuantity)
			{
				num ^= this.Quantity.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004BD2 RID: 19410 RVA: 0x00121FCC File Offset: 0x001201CC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004BD3 RID: 19411 RVA: 0x00121FE4 File Offset: 0x001201E4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004BD4 RID: 19412 RVA: 0x00121FF0 File Offset: 0x001201F0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GameAccountId);
			}
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.AccountId);
			}
			bool hasAchievementSno = this.HasAchievementSno;
			if (hasAchievementSno)
			{
				output.WriteRawTag(29);
				output.WriteSFixed32(this.AchievementSno);
			}
			bool hasCriteriaId = this.HasCriteriaId;
			if (hasCriteriaId)
			{
				output.WriteRawTag(37);
				output.WriteSFixed32(this.CriteriaId);
			}
			bool hasQuantity = this.HasQuantity;
			if (hasQuantity)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.Quantity);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004BD5 RID: 19413 RVA: 0x001220C8 File Offset: 0x001202C8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AccountId);
			}
			bool hasAchievementSno = this.HasAchievementSno;
			if (hasAchievementSno)
			{
				num += 5;
			}
			bool hasCriteriaId = this.HasCriteriaId;
			if (hasCriteriaId)
			{
				num += 5;
			}
			bool hasQuantity = this.HasQuantity;
			if (hasQuantity)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Quantity);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004BD6 RID: 19414 RVA: 0x00122178 File Offset: 0x00120378
		[DebuggerNonUserCode]
		public void MergeFrom(AchievementProgressNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				bool hasAccountId = other.HasAccountId;
				if (hasAccountId)
				{
					this.AccountId = other.AccountId;
				}
				bool hasAchievementSno = other.HasAchievementSno;
				if (hasAchievementSno)
				{
					this.AchievementSno = other.AchievementSno;
				}
				bool hasCriteriaId = other.HasCriteriaId;
				if (hasCriteriaId)
				{
					this.CriteriaId = other.CriteriaId;
				}
				bool hasQuantity = other.HasQuantity;
				if (hasQuantity)
				{
					this.Quantity = other.Quantity;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004BD7 RID: 19415 RVA: 0x0012222C File Offset: 0x0012042C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004BD8 RID: 19416 RVA: 0x00122238 File Offset: 0x00120438
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 16U)
				{
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							goto IL_0032;
						}
						this.AccountId = input.ReadUInt32();
					}
					else
					{
						this.GameAccountId = input.ReadUInt32();
					}
				}
				else if (num3 != 29U)
				{
					if (num3 != 37U)
					{
						if (num3 != 40U)
						{
							goto IL_0032;
						}
						this.Quantity = input.ReadUInt64();
					}
					else
					{
						this.CriteriaId = input.ReadSFixed32();
					}
				}
				else
				{
					this.AchievementSno = input.ReadSFixed32();
				}
				continue;
				IL_0032:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040021CA RID: 8650
		private static readonly MessageParser<AchievementProgressNotification> _parser = new MessageParser<AchievementProgressNotification>(() => new AchievementProgressNotification());

		// Token: 0x040021CB RID: 8651
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021CC RID: 8652
		private int _hasBits0;

		// Token: 0x040021CD RID: 8653
		public const int GameAccountIdFieldNumber = 1;

		// Token: 0x040021CE RID: 8654
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x040021CF RID: 8655
		private uint gameAccountId_;

		// Token: 0x040021D0 RID: 8656
		public const int AccountIdFieldNumber = 2;

		// Token: 0x040021D1 RID: 8657
		private static readonly uint AccountIdDefaultValue = 0U;

		// Token: 0x040021D2 RID: 8658
		private uint accountId_;

		// Token: 0x040021D3 RID: 8659
		public const int AchievementSnoFieldNumber = 3;

		// Token: 0x040021D4 RID: 8660
		private static readonly int AchievementSnoDefaultValue = 0;

		// Token: 0x040021D5 RID: 8661
		private int achievementSno_;

		// Token: 0x040021D6 RID: 8662
		public const int CriteriaIdFieldNumber = 4;

		// Token: 0x040021D7 RID: 8663
		private static readonly int CriteriaIdDefaultValue = 0;

		// Token: 0x040021D8 RID: 8664
		private int criteriaId_;

		// Token: 0x040021D9 RID: 8665
		public const int QuantityFieldNumber = 5;

		// Token: 0x040021DA RID: 8666
		private static readonly ulong QuantityDefaultValue = 0UL;

		// Token: 0x040021DB RID: 8667
		private ulong quantity_;
	}
}
