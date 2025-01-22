using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.CS
{
	// Token: 0x0200020E RID: 526
	public sealed class GDPRPlayerDataAll : IMessage<GDPRPlayerDataAll>, IMessage, IEquatable<GDPRPlayerDataAll>, IDeepCloneable<GDPRPlayerDataAll>, IBufferMessage
	{
		// Token: 0x170012BD RID: 4797
		// (get) Token: 0x0600397B RID: 14715 RVA: 0x000E31D0 File Offset: 0x000E13D0
		[DebuggerNonUserCode]
		public static MessageParser<GDPRPlayerDataAll> Parser
		{
			get
			{
				return GDPRPlayerDataAll._parser;
			}
		}

		// Token: 0x170012BE RID: 4798
		// (get) Token: 0x0600397C RID: 14716 RVA: 0x000E31E8 File Offset: 0x000E13E8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CSReflection.Descriptor.MessageTypes[14];
			}
		}

		// Token: 0x170012BF RID: 4799
		// (get) Token: 0x0600397D RID: 14717 RVA: 0x000E320C File Offset: 0x000E140C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GDPRPlayerDataAll.Descriptor;
			}
		}

		// Token: 0x0600397E RID: 14718 RVA: 0x000E3223 File Offset: 0x000E1423
		[DebuggerNonUserCode]
		public GDPRPlayerDataAll()
		{
		}

		// Token: 0x0600397F RID: 14719 RVA: 0x000E3230 File Offset: 0x000E1430
		[DebuggerNonUserCode]
		public GDPRPlayerDataAll(GDPRPlayerDataAll other)
			: this()
		{
			this.accountSnapshot_ = ((other.accountSnapshot_ != null) ? other.accountSnapshot_.Clone() : null);
			this.fallenHeroData_ = ((other.fallenHeroData_ != null) ? other.fallenHeroData_.Clone() : null);
			this.clanData_ = ((other.clanData_ != null) ? other.clanData_.Clone() : null);
			this.achievementData_ = ((other.achievementData_ != null) ? other.achievementData_.Clone() : null);
			this.giftData_ = ((other.giftData_ != null) ? other.giftData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003980 RID: 14720 RVA: 0x000E32E4 File Offset: 0x000E14E4
		[DebuggerNonUserCode]
		public GDPRPlayerDataAll Clone()
		{
			return new GDPRPlayerDataAll(this);
		}

		// Token: 0x170012C0 RID: 4800
		// (get) Token: 0x06003981 RID: 14721 RVA: 0x000E32FC File Offset: 0x000E14FC
		// (set) Token: 0x06003982 RID: 14722 RVA: 0x000E3314 File Offset: 0x000E1514
		[DebuggerNonUserCode]
		public Snapshot AccountSnapshot
		{
			get
			{
				return this.accountSnapshot_;
			}
			set
			{
				this.accountSnapshot_ = value;
			}
		}

		// Token: 0x170012C1 RID: 4801
		// (get) Token: 0x06003983 RID: 14723 RVA: 0x000E3320 File Offset: 0x000E1520
		// (set) Token: 0x06003984 RID: 14724 RVA: 0x000E3338 File Offset: 0x000E1538
		[DebuggerNonUserCode]
		public FallenHeroData FallenHeroData
		{
			get
			{
				return this.fallenHeroData_;
			}
			set
			{
				this.fallenHeroData_ = value;
			}
		}

		// Token: 0x170012C2 RID: 4802
		// (get) Token: 0x06003985 RID: 14725 RVA: 0x000E3344 File Offset: 0x000E1544
		// (set) Token: 0x06003986 RID: 14726 RVA: 0x000E335C File Offset: 0x000E155C
		[DebuggerNonUserCode]
		public ClanData ClanData
		{
			get
			{
				return this.clanData_;
			}
			set
			{
				this.clanData_ = value;
			}
		}

		// Token: 0x170012C3 RID: 4803
		// (get) Token: 0x06003987 RID: 14727 RVA: 0x000E3368 File Offset: 0x000E1568
		// (set) Token: 0x06003988 RID: 14728 RVA: 0x000E3380 File Offset: 0x000E1580
		[DebuggerNonUserCode]
		public AchievementData AchievementData
		{
			get
			{
				return this.achievementData_;
			}
			set
			{
				this.achievementData_ = value;
			}
		}

		// Token: 0x170012C4 RID: 4804
		// (get) Token: 0x06003989 RID: 14729 RVA: 0x000E338C File Offset: 0x000E158C
		// (set) Token: 0x0600398A RID: 14730 RVA: 0x000E33A4 File Offset: 0x000E15A4
		[DebuggerNonUserCode]
		public GiftData GiftData
		{
			get
			{
				return this.giftData_;
			}
			set
			{
				this.giftData_ = value;
			}
		}

		// Token: 0x0600398B RID: 14731 RVA: 0x000E33B0 File Offset: 0x000E15B0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GDPRPlayerDataAll);
		}

		// Token: 0x0600398C RID: 14732 RVA: 0x000E33D0 File Offset: 0x000E15D0
		[DebuggerNonUserCode]
		public bool Equals(GDPRPlayerDataAll other)
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
					bool flag4 = !object.Equals(this.AccountSnapshot, other.AccountSnapshot);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.FallenHeroData, other.FallenHeroData);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.ClanData, other.ClanData);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.AchievementData, other.AchievementData);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.GiftData, other.GiftData);
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600398D RID: 14733 RVA: 0x000E34AC File Offset: 0x000E16AC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.accountSnapshot_ != null;
			if (flag)
			{
				num ^= this.AccountSnapshot.GetHashCode();
			}
			bool flag2 = this.fallenHeroData_ != null;
			if (flag2)
			{
				num ^= this.FallenHeroData.GetHashCode();
			}
			bool flag3 = this.clanData_ != null;
			if (flag3)
			{
				num ^= this.ClanData.GetHashCode();
			}
			bool flag4 = this.achievementData_ != null;
			if (flag4)
			{
				num ^= this.AchievementData.GetHashCode();
			}
			bool flag5 = this.giftData_ != null;
			if (flag5)
			{
				num ^= this.GiftData.GetHashCode();
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600398E RID: 14734 RVA: 0x000E3570 File Offset: 0x000E1770
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600398F RID: 14735 RVA: 0x000E3588 File Offset: 0x000E1788
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003990 RID: 14736 RVA: 0x000E3594 File Offset: 0x000E1794
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.accountSnapshot_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AccountSnapshot);
			}
			bool flag2 = this.fallenHeroData_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.FallenHeroData);
			}
			bool flag3 = this.clanData_ != null;
			if (flag3)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.ClanData);
			}
			bool flag4 = this.achievementData_ != null;
			if (flag4)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.AchievementData);
			}
			bool flag5 = this.giftData_ != null;
			if (flag5)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.GiftData);
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003991 RID: 14737 RVA: 0x000E367C File Offset: 0x000E187C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.accountSnapshot_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountSnapshot);
			}
			bool flag2 = this.fallenHeroData_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FallenHeroData);
			}
			bool flag3 = this.clanData_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ClanData);
			}
			bool flag4 = this.achievementData_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AchievementData);
			}
			bool flag5 = this.giftData_ != null;
			if (flag5)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GiftData);
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003992 RID: 14738 RVA: 0x000E3754 File Offset: 0x000E1954
		[DebuggerNonUserCode]
		public void MergeFrom(GDPRPlayerDataAll other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.accountSnapshot_ != null;
				if (flag2)
				{
					bool flag3 = this.accountSnapshot_ == null;
					if (flag3)
					{
						this.AccountSnapshot = new Snapshot();
					}
					this.AccountSnapshot.MergeFrom(other.AccountSnapshot);
				}
				bool flag4 = other.fallenHeroData_ != null;
				if (flag4)
				{
					bool flag5 = this.fallenHeroData_ == null;
					if (flag5)
					{
						this.FallenHeroData = new FallenHeroData();
					}
					this.FallenHeroData.MergeFrom(other.FallenHeroData);
				}
				bool flag6 = other.clanData_ != null;
				if (flag6)
				{
					bool flag7 = this.clanData_ == null;
					if (flag7)
					{
						this.ClanData = new ClanData();
					}
					this.ClanData.MergeFrom(other.ClanData);
				}
				bool flag8 = other.achievementData_ != null;
				if (flag8)
				{
					bool flag9 = this.achievementData_ == null;
					if (flag9)
					{
						this.AchievementData = new AchievementData();
					}
					this.AchievementData.MergeFrom(other.AchievementData);
				}
				bool flag10 = other.giftData_ != null;
				if (flag10)
				{
					bool flag11 = this.giftData_ == null;
					if (flag11)
					{
						this.GiftData = new GiftData();
					}
					this.GiftData.MergeFrom(other.GiftData);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003993 RID: 14739 RVA: 0x000E38C1 File Offset: 0x000E1AC1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003994 RID: 14740 RVA: 0x000E38CC File Offset: 0x000E1ACC
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
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							goto IL_003C;
						}
						bool flag = this.fallenHeroData_ == null;
						if (flag)
						{
							this.FallenHeroData = new FallenHeroData();
						}
						input.ReadMessage(this.FallenHeroData);
					}
					else
					{
						bool flag2 = this.accountSnapshot_ == null;
						if (flag2)
						{
							this.AccountSnapshot = new Snapshot();
						}
						input.ReadMessage(this.AccountSnapshot);
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							goto IL_003C;
						}
						bool flag3 = this.giftData_ == null;
						if (flag3)
						{
							this.GiftData = new GiftData();
						}
						input.ReadMessage(this.GiftData);
					}
					else
					{
						bool flag4 = this.achievementData_ == null;
						if (flag4)
						{
							this.AchievementData = new AchievementData();
						}
						input.ReadMessage(this.AchievementData);
					}
				}
				else
				{
					bool flag5 = this.clanData_ == null;
					if (flag5)
					{
						this.ClanData = new ClanData();
					}
					input.ReadMessage(this.ClanData);
				}
				continue;
				IL_003C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001AC9 RID: 6857
		private static readonly MessageParser<GDPRPlayerDataAll> _parser = new MessageParser<GDPRPlayerDataAll>(() => new GDPRPlayerDataAll());

		// Token: 0x04001ACA RID: 6858
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001ACB RID: 6859
		public const int AccountSnapshotFieldNumber = 1;

		// Token: 0x04001ACC RID: 6860
		private Snapshot accountSnapshot_;

		// Token: 0x04001ACD RID: 6861
		public const int FallenHeroDataFieldNumber = 2;

		// Token: 0x04001ACE RID: 6862
		private FallenHeroData fallenHeroData_;

		// Token: 0x04001ACF RID: 6863
		public const int ClanDataFieldNumber = 3;

		// Token: 0x04001AD0 RID: 6864
		private ClanData clanData_;

		// Token: 0x04001AD1 RID: 6865
		public const int AchievementDataFieldNumber = 4;

		// Token: 0x04001AD2 RID: 6866
		private AchievementData achievementData_;

		// Token: 0x04001AD3 RID: 6867
		public const int GiftDataFieldNumber = 5;

		// Token: 0x04001AD4 RID: 6868
		private GiftData giftData_;
	}
}
