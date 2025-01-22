using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000742 RID: 1858
	public sealed class GameTimeInfo : IMessage<GameTimeInfo>, IMessage, IEquatable<GameTimeInfo>, IDeepCloneable<GameTimeInfo>, IBufferMessage
	{
		// Token: 0x170034C2 RID: 13506
		// (get) Token: 0x0600AAC0 RID: 43712 RVA: 0x002999D8 File Offset: 0x00297BD8
		[DebuggerNonUserCode]
		public static MessageParser<GameTimeInfo> Parser
		{
			get
			{
				return GameTimeInfo._parser;
			}
		}

		// Token: 0x170034C3 RID: 13507
		// (get) Token: 0x0600AAC1 RID: 43713 RVA: 0x002999F0 File Offset: 0x00297BF0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[18];
			}
		}

		// Token: 0x170034C4 RID: 13508
		// (get) Token: 0x0600AAC2 RID: 43714 RVA: 0x00299A14 File Offset: 0x00297C14
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameTimeInfo.Descriptor;
			}
		}

		// Token: 0x0600AAC3 RID: 43715 RVA: 0x00299A2B File Offset: 0x00297C2B
		[DebuggerNonUserCode]
		public GameTimeInfo()
		{
		}

		// Token: 0x0600AAC4 RID: 43716 RVA: 0x00299A38 File Offset: 0x00297C38
		[DebuggerNonUserCode]
		public GameTimeInfo(GameTimeInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.isUnlimitedPlayTime_ = other.isUnlimitedPlayTime_;
			this.playTimeExpires_ = other.playTimeExpires_;
			this.isSubscription_ = other.isSubscription_;
			this.isRecurringSubscription_ = other.isRecurringSubscription_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AAC5 RID: 43717 RVA: 0x00299A9C File Offset: 0x00297C9C
		[DebuggerNonUserCode]
		public GameTimeInfo Clone()
		{
			return new GameTimeInfo(this);
		}

		// Token: 0x170034C5 RID: 13509
		// (get) Token: 0x0600AAC6 RID: 43718 RVA: 0x00299AB4 File Offset: 0x00297CB4
		// (set) Token: 0x0600AAC7 RID: 43719 RVA: 0x00299AE5 File Offset: 0x00297CE5
		[DebuggerNonUserCode]
		public bool IsUnlimitedPlayTime
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool isUnlimitedPlayTimeDefaultValue;
				if (flag)
				{
					isUnlimitedPlayTimeDefaultValue = this.isUnlimitedPlayTime_;
				}
				else
				{
					isUnlimitedPlayTimeDefaultValue = GameTimeInfo.IsUnlimitedPlayTimeDefaultValue;
				}
				return isUnlimitedPlayTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.isUnlimitedPlayTime_ = value;
			}
		}

		// Token: 0x170034C6 RID: 13510
		// (get) Token: 0x0600AAC8 RID: 43720 RVA: 0x00299B00 File Offset: 0x00297D00
		[DebuggerNonUserCode]
		public bool HasIsUnlimitedPlayTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600AAC9 RID: 43721 RVA: 0x00299B1D File Offset: 0x00297D1D
		[DebuggerNonUserCode]
		public void ClearIsUnlimitedPlayTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170034C7 RID: 13511
		// (get) Token: 0x0600AACA RID: 43722 RVA: 0x00299B30 File Offset: 0x00297D30
		// (set) Token: 0x0600AACB RID: 43723 RVA: 0x00299B61 File Offset: 0x00297D61
		[DebuggerNonUserCode]
		public ulong PlayTimeExpires
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong playTimeExpiresDefaultValue;
				if (flag)
				{
					playTimeExpiresDefaultValue = this.playTimeExpires_;
				}
				else
				{
					playTimeExpiresDefaultValue = GameTimeInfo.PlayTimeExpiresDefaultValue;
				}
				return playTimeExpiresDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.playTimeExpires_ = value;
			}
		}

		// Token: 0x170034C8 RID: 13512
		// (get) Token: 0x0600AACC RID: 43724 RVA: 0x00299B7C File Offset: 0x00297D7C
		[DebuggerNonUserCode]
		public bool HasPlayTimeExpires
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600AACD RID: 43725 RVA: 0x00299B99 File Offset: 0x00297D99
		[DebuggerNonUserCode]
		public void ClearPlayTimeExpires()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170034C9 RID: 13513
		// (get) Token: 0x0600AACE RID: 43726 RVA: 0x00299BAC File Offset: 0x00297DAC
		// (set) Token: 0x0600AACF RID: 43727 RVA: 0x00299BDD File Offset: 0x00297DDD
		[DebuggerNonUserCode]
		public bool IsSubscription
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool isSubscriptionDefaultValue;
				if (flag)
				{
					isSubscriptionDefaultValue = this.isSubscription_;
				}
				else
				{
					isSubscriptionDefaultValue = GameTimeInfo.IsSubscriptionDefaultValue;
				}
				return isSubscriptionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.isSubscription_ = value;
			}
		}

		// Token: 0x170034CA RID: 13514
		// (get) Token: 0x0600AAD0 RID: 43728 RVA: 0x00299BF8 File Offset: 0x00297DF8
		[DebuggerNonUserCode]
		public bool HasIsSubscription
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600AAD1 RID: 43729 RVA: 0x00299C15 File Offset: 0x00297E15
		[DebuggerNonUserCode]
		public void ClearIsSubscription()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170034CB RID: 13515
		// (get) Token: 0x0600AAD2 RID: 43730 RVA: 0x00299C28 File Offset: 0x00297E28
		// (set) Token: 0x0600AAD3 RID: 43731 RVA: 0x00299C59 File Offset: 0x00297E59
		[DebuggerNonUserCode]
		public bool IsRecurringSubscription
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool isRecurringSubscriptionDefaultValue;
				if (flag)
				{
					isRecurringSubscriptionDefaultValue = this.isRecurringSubscription_;
				}
				else
				{
					isRecurringSubscriptionDefaultValue = GameTimeInfo.IsRecurringSubscriptionDefaultValue;
				}
				return isRecurringSubscriptionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.isRecurringSubscription_ = value;
			}
		}

		// Token: 0x170034CC RID: 13516
		// (get) Token: 0x0600AAD4 RID: 43732 RVA: 0x00299C74 File Offset: 0x00297E74
		[DebuggerNonUserCode]
		public bool HasIsRecurringSubscription
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600AAD5 RID: 43733 RVA: 0x00299C91 File Offset: 0x00297E91
		[DebuggerNonUserCode]
		public void ClearIsRecurringSubscription()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x0600AAD6 RID: 43734 RVA: 0x00299CA4 File Offset: 0x00297EA4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameTimeInfo);
		}

		// Token: 0x0600AAD7 RID: 43735 RVA: 0x00299CC4 File Offset: 0x00297EC4
		[DebuggerNonUserCode]
		public bool Equals(GameTimeInfo other)
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
					bool flag4 = this.IsUnlimitedPlayTime != other.IsUnlimitedPlayTime;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.PlayTimeExpires != other.PlayTimeExpires;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.IsSubscription != other.IsSubscription;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.IsRecurringSubscription != other.IsRecurringSubscription;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600AAD8 RID: 43736 RVA: 0x00299D70 File Offset: 0x00297F70
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasIsUnlimitedPlayTime = this.HasIsUnlimitedPlayTime;
			if (hasIsUnlimitedPlayTime)
			{
				num ^= this.IsUnlimitedPlayTime.GetHashCode();
			}
			bool hasPlayTimeExpires = this.HasPlayTimeExpires;
			if (hasPlayTimeExpires)
			{
				num ^= this.PlayTimeExpires.GetHashCode();
			}
			bool hasIsSubscription = this.HasIsSubscription;
			if (hasIsSubscription)
			{
				num ^= this.IsSubscription.GetHashCode();
			}
			bool hasIsRecurringSubscription = this.HasIsRecurringSubscription;
			if (hasIsRecurringSubscription)
			{
				num ^= this.IsRecurringSubscription.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AAD9 RID: 43737 RVA: 0x00299E18 File Offset: 0x00298018
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AADA RID: 43738 RVA: 0x00299E30 File Offset: 0x00298030
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AADB RID: 43739 RVA: 0x00299E3C File Offset: 0x0029803C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasIsUnlimitedPlayTime = this.HasIsUnlimitedPlayTime;
			if (hasIsUnlimitedPlayTime)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsUnlimitedPlayTime);
			}
			bool hasPlayTimeExpires = this.HasPlayTimeExpires;
			if (hasPlayTimeExpires)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.PlayTimeExpires);
			}
			bool hasIsSubscription = this.HasIsSubscription;
			if (hasIsSubscription)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsSubscription);
			}
			bool hasIsRecurringSubscription = this.HasIsRecurringSubscription;
			if (hasIsRecurringSubscription)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsRecurringSubscription);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AADC RID: 43740 RVA: 0x00299EF0 File Offset: 0x002980F0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasIsUnlimitedPlayTime = this.HasIsUnlimitedPlayTime;
			if (hasIsUnlimitedPlayTime)
			{
				num += 2;
			}
			bool hasPlayTimeExpires = this.HasPlayTimeExpires;
			if (hasPlayTimeExpires)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.PlayTimeExpires);
			}
			bool hasIsSubscription = this.HasIsSubscription;
			if (hasIsSubscription)
			{
				num += 2;
			}
			bool hasIsRecurringSubscription = this.HasIsRecurringSubscription;
			if (hasIsRecurringSubscription)
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

		// Token: 0x0600AADD RID: 43741 RVA: 0x00299F74 File Offset: 0x00298174
		[DebuggerNonUserCode]
		public void MergeFrom(GameTimeInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasIsUnlimitedPlayTime = other.HasIsUnlimitedPlayTime;
				if (hasIsUnlimitedPlayTime)
				{
					this.IsUnlimitedPlayTime = other.IsUnlimitedPlayTime;
				}
				bool hasPlayTimeExpires = other.HasPlayTimeExpires;
				if (hasPlayTimeExpires)
				{
					this.PlayTimeExpires = other.PlayTimeExpires;
				}
				bool hasIsSubscription = other.HasIsSubscription;
				if (hasIsSubscription)
				{
					this.IsSubscription = other.IsSubscription;
				}
				bool hasIsRecurringSubscription = other.HasIsRecurringSubscription;
				if (hasIsRecurringSubscription)
				{
					this.IsRecurringSubscription = other.IsRecurringSubscription;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600AADE RID: 43742 RVA: 0x0029A00A File Offset: 0x0029820A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AADF RID: 43743 RVA: 0x0029A018 File Offset: 0x00298218
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 40U)
				{
					if (num3 != 24U)
					{
						if (num3 != 40U)
						{
							goto IL_0029;
						}
						this.PlayTimeExpires = input.ReadUInt64();
					}
					else
					{
						this.IsUnlimitedPlayTime = input.ReadBool();
					}
				}
				else if (num3 != 48U)
				{
					if (num3 != 56U)
					{
						goto IL_0029;
					}
					this.IsRecurringSubscription = input.ReadBool();
				}
				else
				{
					this.IsSubscription = input.ReadBool();
				}
				continue;
				IL_0029:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004CED RID: 19693
		private static readonly MessageParser<GameTimeInfo> _parser = new MessageParser<GameTimeInfo>(() => new GameTimeInfo());

		// Token: 0x04004CEE RID: 19694
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CEF RID: 19695
		private int _hasBits0;

		// Token: 0x04004CF0 RID: 19696
		public const int IsUnlimitedPlayTimeFieldNumber = 3;

		// Token: 0x04004CF1 RID: 19697
		private static readonly bool IsUnlimitedPlayTimeDefaultValue = false;

		// Token: 0x04004CF2 RID: 19698
		private bool isUnlimitedPlayTime_;

		// Token: 0x04004CF3 RID: 19699
		public const int PlayTimeExpiresFieldNumber = 5;

		// Token: 0x04004CF4 RID: 19700
		private static readonly ulong PlayTimeExpiresDefaultValue = 0UL;

		// Token: 0x04004CF5 RID: 19701
		private ulong playTimeExpires_;

		// Token: 0x04004CF6 RID: 19702
		public const int IsSubscriptionFieldNumber = 6;

		// Token: 0x04004CF7 RID: 19703
		private static readonly bool IsSubscriptionDefaultValue = false;

		// Token: 0x04004CF8 RID: 19704
		private bool isSubscription_;

		// Token: 0x04004CF9 RID: 19705
		public const int IsRecurringSubscriptionFieldNumber = 7;

		// Token: 0x04004CFA RID: 19706
		private static readonly bool IsRecurringSubscriptionDefaultValue = false;

		// Token: 0x04004CFB RID: 19707
		private bool isRecurringSubscription_;
	}
}
