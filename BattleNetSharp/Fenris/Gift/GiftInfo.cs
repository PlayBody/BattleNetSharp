using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Gift
{
	// Token: 0x020001B8 RID: 440
	public sealed class GiftInfo : IMessage<GiftInfo>, IMessage, IEquatable<GiftInfo>, IDeepCloneable<GiftInfo>, IBufferMessage
	{
		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x06002E3F RID: 11839 RVA: 0x000B4B08 File Offset: 0x000B2D08
		[DebuggerNonUserCode]
		public static MessageParser<GiftInfo> Parser
		{
			get
			{
				return GiftInfo._parser;
			}
		}

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x06002E40 RID: 11840 RVA: 0x000B4B20 File Offset: 0x000B2D20
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GiftReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x06002E41 RID: 11841 RVA: 0x000B4B44 File Offset: 0x000B2D44
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiftInfo.Descriptor;
			}
		}

		// Token: 0x06002E42 RID: 11842 RVA: 0x000B4B5B File Offset: 0x000B2D5B
		[DebuggerNonUserCode]
		public GiftInfo()
		{
		}

		// Token: 0x06002E43 RID: 11843 RVA: 0x000B4B68 File Offset: 0x000B2D68
		[DebuggerNonUserCode]
		public GiftInfo(GiftInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.accountId_ = other.accountId_;
			this.giftId_ = other.giftId_;
			this.claimId_ = other.claimId_;
			this.claimState_ = other.claimState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002E44 RID: 11844 RVA: 0x000B4BCC File Offset: 0x000B2DCC
		[DebuggerNonUserCode]
		public GiftInfo Clone()
		{
			return new GiftInfo(this);
		}

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06002E45 RID: 11845 RVA: 0x000B4BE4 File Offset: 0x000B2DE4
		// (set) Token: 0x06002E46 RID: 11846 RVA: 0x000B4C15 File Offset: 0x000B2E15
		[DebuggerNonUserCode]
		public ulong AccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong accountIdDefaultValue;
				if (flag)
				{
					accountIdDefaultValue = this.accountId_;
				}
				else
				{
					accountIdDefaultValue = GiftInfo.AccountIdDefaultValue;
				}
				return accountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.accountId_ = value;
			}
		}

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x06002E47 RID: 11847 RVA: 0x000B4C30 File Offset: 0x000B2E30
		[DebuggerNonUserCode]
		public bool HasAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002E48 RID: 11848 RVA: 0x000B4C4D File Offset: 0x000B2E4D
		[DebuggerNonUserCode]
		public void ClearAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x06002E49 RID: 11849 RVA: 0x000B4C60 File Offset: 0x000B2E60
		// (set) Token: 0x06002E4A RID: 11850 RVA: 0x000B4C81 File Offset: 0x000B2E81
		[DebuggerNonUserCode]
		public string GiftId
		{
			get
			{
				return this.giftId_ ?? GiftInfo.GiftIdDefaultValue;
			}
			set
			{
				this.giftId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x06002E4B RID: 11851 RVA: 0x000B4C98 File Offset: 0x000B2E98
		[DebuggerNonUserCode]
		public bool HasGiftId
		{
			get
			{
				return this.giftId_ != null;
			}
		}

		// Token: 0x06002E4C RID: 11852 RVA: 0x000B4CB3 File Offset: 0x000B2EB3
		[DebuggerNonUserCode]
		public void ClearGiftId()
		{
			this.giftId_ = null;
		}

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x06002E4D RID: 11853 RVA: 0x000B4CC0 File Offset: 0x000B2EC0
		// (set) Token: 0x06002E4E RID: 11854 RVA: 0x000B4CE1 File Offset: 0x000B2EE1
		[DebuggerNonUserCode]
		public string ClaimId
		{
			get
			{
				return this.claimId_ ?? GiftInfo.ClaimIdDefaultValue;
			}
			set
			{
				this.claimId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x06002E4F RID: 11855 RVA: 0x000B4CF8 File Offset: 0x000B2EF8
		[DebuggerNonUserCode]
		public bool HasClaimId
		{
			get
			{
				return this.claimId_ != null;
			}
		}

		// Token: 0x06002E50 RID: 11856 RVA: 0x000B4D13 File Offset: 0x000B2F13
		[DebuggerNonUserCode]
		public void ClearClaimId()
		{
			this.claimId_ = null;
		}

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x06002E51 RID: 11857 RVA: 0x000B4D20 File Offset: 0x000B2F20
		// (set) Token: 0x06002E52 RID: 11858 RVA: 0x000B4D51 File Offset: 0x000B2F51
		[DebuggerNonUserCode]
		public uint ClaimState
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint claimStateDefaultValue;
				if (flag)
				{
					claimStateDefaultValue = this.claimState_;
				}
				else
				{
					claimStateDefaultValue = GiftInfo.ClaimStateDefaultValue;
				}
				return claimStateDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.claimState_ = value;
			}
		}

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x06002E53 RID: 11859 RVA: 0x000B4D6C File Offset: 0x000B2F6C
		[DebuggerNonUserCode]
		public bool HasClaimState
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002E54 RID: 11860 RVA: 0x000B4D89 File Offset: 0x000B2F89
		[DebuggerNonUserCode]
		public void ClearClaimState()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06002E55 RID: 11861 RVA: 0x000B4D9C File Offset: 0x000B2F9C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiftInfo);
		}

		// Token: 0x06002E56 RID: 11862 RVA: 0x000B4DBC File Offset: 0x000B2FBC
		[DebuggerNonUserCode]
		public bool Equals(GiftInfo other)
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
					bool flag4 = this.AccountId != other.AccountId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.GiftId != other.GiftId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ClaimId != other.ClaimId;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.ClaimState != other.ClaimState;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002E57 RID: 11863 RVA: 0x000B4E68 File Offset: 0x000B3068
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num ^= this.AccountId.GetHashCode();
			}
			bool hasGiftId = this.HasGiftId;
			if (hasGiftId)
			{
				num ^= this.GiftId.GetHashCode();
			}
			bool hasClaimId = this.HasClaimId;
			if (hasClaimId)
			{
				num ^= this.ClaimId.GetHashCode();
			}
			bool hasClaimState = this.HasClaimState;
			if (hasClaimState)
			{
				num ^= this.ClaimState.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002E58 RID: 11864 RVA: 0x000B4F0C File Offset: 0x000B310C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x000B4F24 File Offset: 0x000B3124
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002E5A RID: 11866 RVA: 0x000B4F30 File Offset: 0x000B3130
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.AccountId);
			}
			bool hasGiftId = this.HasGiftId;
			if (hasGiftId)
			{
				output.WriteRawTag(18);
				output.WriteString(this.GiftId);
			}
			bool hasClaimId = this.HasClaimId;
			if (hasClaimId)
			{
				output.WriteRawTag(26);
				output.WriteString(this.ClaimId);
			}
			bool hasClaimState = this.HasClaimState;
			if (hasClaimState)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.ClaimState);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002E5B RID: 11867 RVA: 0x000B4FE4 File Offset: 0x000B31E4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.AccountId);
			}
			bool hasGiftId = this.HasGiftId;
			if (hasGiftId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.GiftId);
			}
			bool hasClaimId = this.HasClaimId;
			if (hasClaimId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClaimId);
			}
			bool hasClaimState = this.HasClaimState;
			if (hasClaimState)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ClaimState);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002E5C RID: 11868 RVA: 0x000B508C File Offset: 0x000B328C
		[DebuggerNonUserCode]
		public void MergeFrom(GiftInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAccountId = other.HasAccountId;
				if (hasAccountId)
				{
					this.AccountId = other.AccountId;
				}
				bool hasGiftId = other.HasGiftId;
				if (hasGiftId)
				{
					this.GiftId = other.GiftId;
				}
				bool hasClaimId = other.HasClaimId;
				if (hasClaimId)
				{
					this.ClaimId = other.ClaimId;
				}
				bool hasClaimState = other.HasClaimState;
				if (hasClaimState)
				{
					this.ClaimState = other.ClaimState;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002E5D RID: 11869 RVA: 0x000B5122 File Offset: 0x000B3322
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002E5E RID: 11870 RVA: 0x000B5130 File Offset: 0x000B3330
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
						this.GiftId = input.ReadString();
					}
					else
					{
						this.AccountId = input.ReadUInt64();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 32U)
					{
						goto IL_0028;
					}
					this.ClaimState = input.ReadUInt32();
				}
				else
				{
					this.ClaimId = input.ReadString();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040014DE RID: 5342
		private static readonly MessageParser<GiftInfo> _parser = new MessageParser<GiftInfo>(() => new GiftInfo());

		// Token: 0x040014DF RID: 5343
		private UnknownFieldSet _unknownFields;

		// Token: 0x040014E0 RID: 5344
		private int _hasBits0;

		// Token: 0x040014E1 RID: 5345
		public const int AccountIdFieldNumber = 1;

		// Token: 0x040014E2 RID: 5346
		private static readonly ulong AccountIdDefaultValue = 0UL;

		// Token: 0x040014E3 RID: 5347
		private ulong accountId_;

		// Token: 0x040014E4 RID: 5348
		public const int GiftIdFieldNumber = 2;

		// Token: 0x040014E5 RID: 5349
		private static readonly string GiftIdDefaultValue = "";

		// Token: 0x040014E6 RID: 5350
		private string giftId_;

		// Token: 0x040014E7 RID: 5351
		public const int ClaimIdFieldNumber = 3;

		// Token: 0x040014E8 RID: 5352
		private static readonly string ClaimIdDefaultValue = "";

		// Token: 0x040014E9 RID: 5353
		private string claimId_;

		// Token: 0x040014EA RID: 5354
		public const int ClaimStateFieldNumber = 4;

		// Token: 0x040014EB RID: 5355
		private static readonly uint ClaimStateDefaultValue = 0U;

		// Token: 0x040014EC RID: 5356
		private uint claimState_;
	}
}
