using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Achievements
{
	// Token: 0x020002C8 RID: 712
	public sealed class AchievementAwardedNotification : IMessage<AchievementAwardedNotification>, IMessage, IEquatable<AchievementAwardedNotification>, IDeepCloneable<AchievementAwardedNotification>, IBufferMessage
	{
		// Token: 0x17001804 RID: 6148
		// (get) Token: 0x06004B9B RID: 19355 RVA: 0x00121544 File Offset: 0x0011F744
		[DebuggerNonUserCode]
		public static MessageParser<AchievementAwardedNotification> Parser
		{
			get
			{
				return AchievementAwardedNotification._parser;
			}
		}

		// Token: 0x17001805 RID: 6149
		// (get) Token: 0x06004B9C RID: 19356 RVA: 0x0012155C File Offset: 0x0011F75C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AchievementsReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17001806 RID: 6150
		// (get) Token: 0x06004B9D RID: 19357 RVA: 0x00121580 File Offset: 0x0011F780
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementAwardedNotification.Descriptor;
			}
		}

		// Token: 0x06004B9E RID: 19358 RVA: 0x00121597 File Offset: 0x0011F797
		[DebuggerNonUserCode]
		public AchievementAwardedNotification()
		{
		}

		// Token: 0x06004B9F RID: 19359 RVA: 0x001215AC File Offset: 0x0011F7AC
		[DebuggerNonUserCode]
		public AchievementAwardedNotification(AchievementAwardedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameAccountId_ = other.gameAccountId_;
			this.achievementSno_ = other.achievementSno_.Clone();
			this.accountId_ = other.accountId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004BA0 RID: 19360 RVA: 0x00121608 File Offset: 0x0011F808
		[DebuggerNonUserCode]
		public AchievementAwardedNotification Clone()
		{
			return new AchievementAwardedNotification(this);
		}

		// Token: 0x17001807 RID: 6151
		// (get) Token: 0x06004BA1 RID: 19361 RVA: 0x00121620 File Offset: 0x0011F820
		// (set) Token: 0x06004BA2 RID: 19362 RVA: 0x00121651 File Offset: 0x0011F851
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
					gameAccountIdDefaultValue = AchievementAwardedNotification.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x17001808 RID: 6152
		// (get) Token: 0x06004BA3 RID: 19363 RVA: 0x0012166C File Offset: 0x0011F86C
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004BA4 RID: 19364 RVA: 0x00121689 File Offset: 0x0011F889
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001809 RID: 6153
		// (get) Token: 0x06004BA5 RID: 19365 RVA: 0x0012169C File Offset: 0x0011F89C
		[DebuggerNonUserCode]
		public RepeatedField<int> AchievementSno
		{
			get
			{
				return this.achievementSno_;
			}
		}

		// Token: 0x1700180A RID: 6154
		// (get) Token: 0x06004BA6 RID: 19366 RVA: 0x001216B4 File Offset: 0x0011F8B4
		// (set) Token: 0x06004BA7 RID: 19367 RVA: 0x001216E5 File Offset: 0x0011F8E5
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
					accountIdDefaultValue = AchievementAwardedNotification.AccountIdDefaultValue;
				}
				return accountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.accountId_ = value;
			}
		}

		// Token: 0x1700180B RID: 6155
		// (get) Token: 0x06004BA8 RID: 19368 RVA: 0x00121700 File Offset: 0x0011F900
		[DebuggerNonUserCode]
		public bool HasAccountId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004BA9 RID: 19369 RVA: 0x0012171D File Offset: 0x0011F91D
		[DebuggerNonUserCode]
		public void ClearAccountId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06004BAA RID: 19370 RVA: 0x00121730 File Offset: 0x0011F930
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementAwardedNotification);
		}

		// Token: 0x06004BAB RID: 19371 RVA: 0x00121750 File Offset: 0x0011F950
		[DebuggerNonUserCode]
		public bool Equals(AchievementAwardedNotification other)
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
						bool flag5 = !this.achievementSno_.Equals(other.achievementSno_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.AccountId != other.AccountId;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004BAC RID: 19372 RVA: 0x001217E0 File Offset: 0x0011F9E0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			num ^= this.achievementSno_.GetHashCode();
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num ^= this.AccountId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004BAD RID: 19373 RVA: 0x0012185C File Offset: 0x0011FA5C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004BAE RID: 19374 RVA: 0x00121874 File Offset: 0x0011FA74
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004BAF RID: 19375 RVA: 0x00121880 File Offset: 0x0011FA80
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GameAccountId);
			}
			this.achievementSno_.WriteTo(ref output, AchievementAwardedNotification._repeated_achievementSno_codec);
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.AccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004BB0 RID: 19376 RVA: 0x00121900 File Offset: 0x0011FB00
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			num += this.achievementSno_.CalculateSize(AchievementAwardedNotification._repeated_achievementSno_codec);
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004BB1 RID: 19377 RVA: 0x00121980 File Offset: 0x0011FB80
		[DebuggerNonUserCode]
		public void MergeFrom(AchievementAwardedNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				this.achievementSno_.Add(other.achievementSno_);
				bool hasAccountId = other.HasAccountId;
				if (hasAccountId)
				{
					this.AccountId = other.AccountId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004BB2 RID: 19378 RVA: 0x001219F4 File Offset: 0x0011FBF4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004BB3 RID: 19379 RVA: 0x00121A00 File Offset: 0x0011FC00
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
						goto IL_004C;
					}
					else
					{
						this.GameAccountId = input.ReadUInt32();
					}
				}
				else
				{
					if (num3 == 21U)
					{
						goto IL_004C;
					}
					if (num3 != 24U)
					{
						goto IL_0028;
					}
					this.AccountId = input.ReadUInt32();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_004C:
				this.achievementSno_.AddEntriesFrom(ref input, AchievementAwardedNotification._repeated_achievementSno_codec);
			}
		}

		// Token: 0x040021BE RID: 8638
		private static readonly MessageParser<AchievementAwardedNotification> _parser = new MessageParser<AchievementAwardedNotification>(() => new AchievementAwardedNotification());

		// Token: 0x040021BF RID: 8639
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021C0 RID: 8640
		private int _hasBits0;

		// Token: 0x040021C1 RID: 8641
		public const int GameAccountIdFieldNumber = 1;

		// Token: 0x040021C2 RID: 8642
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x040021C3 RID: 8643
		private uint gameAccountId_;

		// Token: 0x040021C4 RID: 8644
		public const int AchievementSnoFieldNumber = 2;

		// Token: 0x040021C5 RID: 8645
		private static readonly FieldCodec<int> _repeated_achievementSno_codec = FieldCodec.ForSFixed32(21U);

		// Token: 0x040021C6 RID: 8646
		private readonly RepeatedField<int> achievementSno_ = new RepeatedField<int>();

		// Token: 0x040021C7 RID: 8647
		public const int AccountIdFieldNumber = 3;

		// Token: 0x040021C8 RID: 8648
		private static readonly uint AccountIdDefaultValue = 0U;

		// Token: 0x040021C9 RID: 8649
		private uint accountId_;
	}
}
