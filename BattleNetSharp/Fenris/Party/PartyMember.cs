using System;
using System.Diagnostics;
using Fenris.Hero;
using Fenris.Online;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Party
{
	// Token: 0x0200013A RID: 314
	public sealed class PartyMember : IMessage<PartyMember>, IMessage, IEquatable<PartyMember>, IDeepCloneable<PartyMember>, IBufferMessage
	{
		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06001FE7 RID: 8167 RVA: 0x0007BD90 File Offset: 0x00079F90
		[DebuggerNonUserCode]
		public static MessageParser<PartyMember> Parser
		{
			get
			{
				return PartyMember._parser;
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06001FE8 RID: 8168 RVA: 0x0007BDA8 File Offset: 0x00079FA8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PartyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06001FE9 RID: 8169 RVA: 0x0007BDCC File Offset: 0x00079FCC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartyMember.Descriptor;
			}
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x0007BDE3 File Offset: 0x00079FE3
		[DebuggerNonUserCode]
		public PartyMember()
		{
		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x0007BDF0 File Offset: 0x00079FF0
		[DebuggerNonUserCode]
		public PartyMember(PartyMember other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.bnetAccountId_ = other.bnetAccountId_;
			this.gameAccountId_ = other.gameAccountId_;
			this.heroId_ = other.heroId_;
			this.accountName_ = other.accountName_;
			this.heroClass_ = other.heroClass_;
			this.heroFlags_ = other.heroFlags_;
			this.heroLevel_ = other.heroLevel_;
			this.isLeader_ = other.isLeader_;
			this.partyId_ = other.partyId_;
			this.groupId_ = other.groupId_;
			this.xPosition_ = other.xPosition_;
			this.yPosition_ = other.yPosition_;
			this.worldSno_ = other.worldSno_;
			this.levelareaSno_ = other.levelareaSno_;
			this.hitpointPercent_ = other.hitpointPercent_;
			this.serverPool_ = other.serverPool_;
			this.visualEquipment_ = ((other.visualEquipment_ != null) ? other.visualEquipment_.Clone() : null);
			this.appearance_ = ((other.appearance_ != null) ? other.appearance_.Clone() : null);
			this.platformAccount_ = ((other.platformAccount_ != null) ? other.platformAccount_.Clone() : null);
			this.campaignState_ = ((other.campaignState_ != null) ? other.campaignState_.Clone() : null);
			this.returnPartyId_ = other.returnPartyId_;
			this.mapPinData_ = ((other.mapPinData_ != null) ? other.mapPinData_.Clone() : null);
			this.isCrossplayEnabled_ = other.isCrossplayEnabled_;
			this.disconnectedFromGameTime_ = other.disconnectedFromGameTime_;
			this.isMultiplayerAllowed_ = other.isMultiplayerAllowed_;
			this.maxWorldTier_ = other.maxWorldTier_;
			this.heroName_ = other.heroName_;
			this.canSetCampaignState_ = other.canSetCampaignState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x0007BFC4 File Offset: 0x0007A1C4
		[DebuggerNonUserCode]
		public PartyMember Clone()
		{
			return new PartyMember(this);
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06001FED RID: 8173 RVA: 0x0007BFDC File Offset: 0x0007A1DC
		// (set) Token: 0x06001FEE RID: 8174 RVA: 0x0007C00D File Offset: 0x0007A20D
		[DebuggerNonUserCode]
		public uint BnetAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint bnetAccountIdDefaultValue;
				if (flag)
				{
					bnetAccountIdDefaultValue = this.bnetAccountId_;
				}
				else
				{
					bnetAccountIdDefaultValue = PartyMember.BnetAccountIdDefaultValue;
				}
				return bnetAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.bnetAccountId_ = value;
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06001FEF RID: 8175 RVA: 0x0007C028 File Offset: 0x0007A228
		[DebuggerNonUserCode]
		public bool HasBnetAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x0007C045 File Offset: 0x0007A245
		[DebuggerNonUserCode]
		public void ClearBnetAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06001FF1 RID: 8177 RVA: 0x0007C058 File Offset: 0x0007A258
		// (set) Token: 0x06001FF2 RID: 8178 RVA: 0x0007C08D File Offset: 0x0007A28D
		[DebuggerNonUserCode]
		public uint GameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1024) != 0;
				uint gameAccountIdDefaultValue;
				if (flag)
				{
					gameAccountIdDefaultValue = this.gameAccountId_;
				}
				else
				{
					gameAccountIdDefaultValue = PartyMember.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1024;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06001FF3 RID: 8179 RVA: 0x0007C0AC File Offset: 0x0007A2AC
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1024) != 0;
			}
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x0007C0CD File Offset: 0x0007A2CD
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -1025;
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06001FF5 RID: 8181 RVA: 0x0007C0E4 File Offset: 0x0007A2E4
		// (set) Token: 0x06001FF6 RID: 8182 RVA: 0x0007C105 File Offset: 0x0007A305
		[DebuggerNonUserCode]
		public string HeroId
		{
			get
			{
				return this.heroId_ ?? PartyMember.HeroIdDefaultValue;
			}
			set
			{
				this.heroId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06001FF7 RID: 8183 RVA: 0x0007C11C File Offset: 0x0007A31C
		[DebuggerNonUserCode]
		public bool HasHeroId
		{
			get
			{
				return this.heroId_ != null;
			}
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x0007C137 File Offset: 0x0007A337
		[DebuggerNonUserCode]
		public void ClearHeroId()
		{
			this.heroId_ = null;
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06001FF9 RID: 8185 RVA: 0x0007C144 File Offset: 0x0007A344
		// (set) Token: 0x06001FFA RID: 8186 RVA: 0x0007C165 File Offset: 0x0007A365
		[DebuggerNonUserCode]
		public string AccountName
		{
			get
			{
				return this.accountName_ ?? PartyMember.AccountNameDefaultValue;
			}
			set
			{
				this.accountName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06001FFB RID: 8187 RVA: 0x0007C17C File Offset: 0x0007A37C
		[DebuggerNonUserCode]
		public bool HasAccountName
		{
			get
			{
				return this.accountName_ != null;
			}
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x0007C197 File Offset: 0x0007A397
		[DebuggerNonUserCode]
		public void ClearAccountName()
		{
			this.accountName_ = null;
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06001FFD RID: 8189 RVA: 0x0007C1A4 File Offset: 0x0007A3A4
		// (set) Token: 0x06001FFE RID: 8190 RVA: 0x0007C1D5 File Offset: 0x0007A3D5
		[DebuggerNonUserCode]
		public int HeroClass
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int heroClassDefaultValue;
				if (flag)
				{
					heroClassDefaultValue = this.heroClass_;
				}
				else
				{
					heroClassDefaultValue = PartyMember.HeroClassDefaultValue;
				}
				return heroClassDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.heroClass_ = value;
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06001FFF RID: 8191 RVA: 0x0007C1F0 File Offset: 0x0007A3F0
		[DebuggerNonUserCode]
		public bool HasHeroClass
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x0007C20D File Offset: 0x0007A40D
		[DebuggerNonUserCode]
		public void ClearHeroClass()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06002001 RID: 8193 RVA: 0x0007C220 File Offset: 0x0007A420
		// (set) Token: 0x06002002 RID: 8194 RVA: 0x0007C251 File Offset: 0x0007A451
		[DebuggerNonUserCode]
		public uint HeroFlags
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint heroFlagsDefaultValue;
				if (flag)
				{
					heroFlagsDefaultValue = this.heroFlags_;
				}
				else
				{
					heroFlagsDefaultValue = PartyMember.HeroFlagsDefaultValue;
				}
				return heroFlagsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.heroFlags_ = value;
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06002003 RID: 8195 RVA: 0x0007C26C File Offset: 0x0007A46C
		[DebuggerNonUserCode]
		public bool HasHeroFlags
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06002004 RID: 8196 RVA: 0x0007C289 File Offset: 0x0007A489
		[DebuggerNonUserCode]
		public void ClearHeroFlags()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06002005 RID: 8197 RVA: 0x0007C29C File Offset: 0x0007A49C
		// (set) Token: 0x06002006 RID: 8198 RVA: 0x0007C2CD File Offset: 0x0007A4CD
		[DebuggerNonUserCode]
		public uint HeroLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint heroLevelDefaultValue;
				if (flag)
				{
					heroLevelDefaultValue = this.heroLevel_;
				}
				else
				{
					heroLevelDefaultValue = PartyMember.HeroLevelDefaultValue;
				}
				return heroLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.heroLevel_ = value;
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06002007 RID: 8199 RVA: 0x0007C2E8 File Offset: 0x0007A4E8
		[DebuggerNonUserCode]
		public bool HasHeroLevel
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x0007C305 File Offset: 0x0007A505
		[DebuggerNonUserCode]
		public void ClearHeroLevel()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06002009 RID: 8201 RVA: 0x0007C318 File Offset: 0x0007A518
		// (set) Token: 0x0600200A RID: 8202 RVA: 0x0007C34A File Offset: 0x0007A54A
		[DebuggerNonUserCode]
		public bool IsLeader
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool isLeaderDefaultValue;
				if (flag)
				{
					isLeaderDefaultValue = this.isLeader_;
				}
				else
				{
					isLeaderDefaultValue = PartyMember.IsLeaderDefaultValue;
				}
				return isLeaderDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.isLeader_ = value;
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x0600200B RID: 8203 RVA: 0x0007C364 File Offset: 0x0007A564
		[DebuggerNonUserCode]
		public bool HasIsLeader
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x0007C382 File Offset: 0x0007A582
		[DebuggerNonUserCode]
		public void ClearIsLeader()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x0600200D RID: 8205 RVA: 0x0007C394 File Offset: 0x0007A594
		// (set) Token: 0x0600200E RID: 8206 RVA: 0x0007C3B5 File Offset: 0x0007A5B5
		[DebuggerNonUserCode]
		public string PartyId
		{
			get
			{
				return this.partyId_ ?? PartyMember.PartyIdDefaultValue;
			}
			set
			{
				this.partyId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x0600200F RID: 8207 RVA: 0x0007C3CC File Offset: 0x0007A5CC
		[DebuggerNonUserCode]
		public bool HasPartyId
		{
			get
			{
				return this.partyId_ != null;
			}
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x0007C3E7 File Offset: 0x0007A5E7
		[DebuggerNonUserCode]
		public void ClearPartyId()
		{
			this.partyId_ = null;
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06002011 RID: 8209 RVA: 0x0007C3F4 File Offset: 0x0007A5F4
		// (set) Token: 0x06002012 RID: 8210 RVA: 0x0007C426 File Offset: 0x0007A626
		[DebuggerNonUserCode]
		public uint GroupId
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				uint groupIdDefaultValue;
				if (flag)
				{
					groupIdDefaultValue = this.groupId_;
				}
				else
				{
					groupIdDefaultValue = PartyMember.GroupIdDefaultValue;
				}
				return groupIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.groupId_ = value;
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06002013 RID: 8211 RVA: 0x0007C440 File Offset: 0x0007A640
		[DebuggerNonUserCode]
		public bool HasGroupId
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x0007C45E File Offset: 0x0007A65E
		[DebuggerNonUserCode]
		public void ClearGroupId()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06002015 RID: 8213 RVA: 0x0007C470 File Offset: 0x0007A670
		// (set) Token: 0x06002016 RID: 8214 RVA: 0x0007C4A2 File Offset: 0x0007A6A2
		[DebuggerNonUserCode]
		public int XPosition
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				int xpositionDefaultValue;
				if (flag)
				{
					xpositionDefaultValue = this.xPosition_;
				}
				else
				{
					xpositionDefaultValue = PartyMember.XPositionDefaultValue;
				}
				return xpositionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.xPosition_ = value;
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06002017 RID: 8215 RVA: 0x0007C4BC File Offset: 0x0007A6BC
		[DebuggerNonUserCode]
		public bool HasXPosition
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x0007C4DA File Offset: 0x0007A6DA
		[DebuggerNonUserCode]
		public void ClearXPosition()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06002019 RID: 8217 RVA: 0x0007C4EC File Offset: 0x0007A6EC
		// (set) Token: 0x0600201A RID: 8218 RVA: 0x0007C521 File Offset: 0x0007A721
		[DebuggerNonUserCode]
		public int YPosition
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				int ypositionDefaultValue;
				if (flag)
				{
					ypositionDefaultValue = this.yPosition_;
				}
				else
				{
					ypositionDefaultValue = PartyMember.YPositionDefaultValue;
				}
				return ypositionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.yPosition_ = value;
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x0600201B RID: 8219 RVA: 0x0007C540 File Offset: 0x0007A740
		[DebuggerNonUserCode]
		public bool HasYPosition
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x0007C561 File Offset: 0x0007A761
		[DebuggerNonUserCode]
		public void ClearYPosition()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x0600201D RID: 8221 RVA: 0x0007C578 File Offset: 0x0007A778
		// (set) Token: 0x0600201E RID: 8222 RVA: 0x0007C5AD File Offset: 0x0007A7AD
		[DebuggerNonUserCode]
		public int WorldSno
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				int worldSnoDefaultValue;
				if (flag)
				{
					worldSnoDefaultValue = this.worldSno_;
				}
				else
				{
					worldSnoDefaultValue = PartyMember.WorldSnoDefaultValue;
				}
				return worldSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.worldSno_ = value;
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x0600201F RID: 8223 RVA: 0x0007C5CC File Offset: 0x0007A7CC
		[DebuggerNonUserCode]
		public bool HasWorldSno
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x0007C5ED File Offset: 0x0007A7ED
		[DebuggerNonUserCode]
		public void ClearWorldSno()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06002021 RID: 8225 RVA: 0x0007C604 File Offset: 0x0007A804
		// (set) Token: 0x06002022 RID: 8226 RVA: 0x0007C639 File Offset: 0x0007A839
		[DebuggerNonUserCode]
		public int LevelareaSno
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				int levelareaSnoDefaultValue;
				if (flag)
				{
					levelareaSnoDefaultValue = this.levelareaSno_;
				}
				else
				{
					levelareaSnoDefaultValue = PartyMember.LevelareaSnoDefaultValue;
				}
				return levelareaSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.levelareaSno_ = value;
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06002023 RID: 8227 RVA: 0x0007C658 File Offset: 0x0007A858
		[DebuggerNonUserCode]
		public bool HasLevelareaSno
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x0007C679 File Offset: 0x0007A879
		[DebuggerNonUserCode]
		public void ClearLevelareaSno()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06002025 RID: 8229 RVA: 0x0007C690 File Offset: 0x0007A890
		// (set) Token: 0x06002026 RID: 8230 RVA: 0x0007C6C5 File Offset: 0x0007A8C5
		[DebuggerNonUserCode]
		public float HitpointPercent
		{
			get
			{
				bool flag = (this._hasBits0 & 2048) != 0;
				float hitpointPercentDefaultValue;
				if (flag)
				{
					hitpointPercentDefaultValue = this.hitpointPercent_;
				}
				else
				{
					hitpointPercentDefaultValue = PartyMember.HitpointPercentDefaultValue;
				}
				return hitpointPercentDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2048;
				this.hitpointPercent_ = value;
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06002027 RID: 8231 RVA: 0x0007C6E4 File Offset: 0x0007A8E4
		[DebuggerNonUserCode]
		public bool HasHitpointPercent
		{
			get
			{
				return (this._hasBits0 & 2048) != 0;
			}
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x0007C705 File Offset: 0x0007A905
		[DebuggerNonUserCode]
		public void ClearHitpointPercent()
		{
			this._hasBits0 &= -2049;
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06002029 RID: 8233 RVA: 0x0007C71C File Offset: 0x0007A91C
		// (set) Token: 0x0600202A RID: 8234 RVA: 0x0007C73D File Offset: 0x0007A93D
		[DebuggerNonUserCode]
		public string ServerPool
		{
			get
			{
				return this.serverPool_ ?? PartyMember.ServerPoolDefaultValue;
			}
			set
			{
				this.serverPool_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x0600202B RID: 8235 RVA: 0x0007C754 File Offset: 0x0007A954
		[DebuggerNonUserCode]
		public bool HasServerPool
		{
			get
			{
				return this.serverPool_ != null;
			}
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x0007C76F File Offset: 0x0007A96F
		[DebuggerNonUserCode]
		public void ClearServerPool()
		{
			this.serverPool_ = null;
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x0600202D RID: 8237 RVA: 0x0007C77C File Offset: 0x0007A97C
		// (set) Token: 0x0600202E RID: 8238 RVA: 0x0007C794 File Offset: 0x0007A994
		[DebuggerNonUserCode]
		public VisualEquipment VisualEquipment
		{
			get
			{
				return this.visualEquipment_;
			}
			set
			{
				this.visualEquipment_ = value;
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x0600202F RID: 8239 RVA: 0x0007C7A0 File Offset: 0x0007A9A0
		// (set) Token: 0x06002030 RID: 8240 RVA: 0x0007C7B8 File Offset: 0x0007A9B8
		[DebuggerNonUserCode]
		public AppearanceCustomization Appearance
		{
			get
			{
				return this.appearance_;
			}
			set
			{
				this.appearance_ = value;
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06002031 RID: 8241 RVA: 0x0007C7C4 File Offset: 0x0007A9C4
		// (set) Token: 0x06002032 RID: 8242 RVA: 0x0007C7DC File Offset: 0x0007A9DC
		[DebuggerNonUserCode]
		public PlatformAccount PlatformAccount
		{
			get
			{
				return this.platformAccount_;
			}
			set
			{
				this.platformAccount_ = value;
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06002033 RID: 8243 RVA: 0x0007C7E8 File Offset: 0x0007A9E8
		// (set) Token: 0x06002034 RID: 8244 RVA: 0x0007C800 File Offset: 0x0007AA00
		[DebuggerNonUserCode]
		public CampaignState CampaignState
		{
			get
			{
				return this.campaignState_;
			}
			set
			{
				this.campaignState_ = value;
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06002035 RID: 8245 RVA: 0x0007C80C File Offset: 0x0007AA0C
		// (set) Token: 0x06002036 RID: 8246 RVA: 0x0007C82D File Offset: 0x0007AA2D
		[DebuggerNonUserCode]
		public string ReturnPartyId
		{
			get
			{
				return this.returnPartyId_ ?? PartyMember.ReturnPartyIdDefaultValue;
			}
			set
			{
				this.returnPartyId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06002037 RID: 8247 RVA: 0x0007C844 File Offset: 0x0007AA44
		[DebuggerNonUserCode]
		public bool HasReturnPartyId
		{
			get
			{
				return this.returnPartyId_ != null;
			}
		}

		// Token: 0x06002038 RID: 8248 RVA: 0x0007C85F File Offset: 0x0007AA5F
		[DebuggerNonUserCode]
		public void ClearReturnPartyId()
		{
			this.returnPartyId_ = null;
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06002039 RID: 8249 RVA: 0x0007C86C File Offset: 0x0007AA6C
		// (set) Token: 0x0600203A RID: 8250 RVA: 0x0007C884 File Offset: 0x0007AA84
		[DebuggerNonUserCode]
		public MapPinData MapPinData
		{
			get
			{
				return this.mapPinData_;
			}
			set
			{
				this.mapPinData_ = value;
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x0600203B RID: 8251 RVA: 0x0007C890 File Offset: 0x0007AA90
		// (set) Token: 0x0600203C RID: 8252 RVA: 0x0007C8C5 File Offset: 0x0007AAC5
		[DebuggerNonUserCode]
		public bool IsCrossplayEnabled
		{
			get
			{
				bool flag = (this._hasBits0 & 4096) != 0;
				bool isCrossplayEnabledDefaultValue;
				if (flag)
				{
					isCrossplayEnabledDefaultValue = this.isCrossplayEnabled_;
				}
				else
				{
					isCrossplayEnabledDefaultValue = PartyMember.IsCrossplayEnabledDefaultValue;
				}
				return isCrossplayEnabledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4096;
				this.isCrossplayEnabled_ = value;
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x0600203D RID: 8253 RVA: 0x0007C8E4 File Offset: 0x0007AAE4
		[DebuggerNonUserCode]
		public bool HasIsCrossplayEnabled
		{
			get
			{
				return (this._hasBits0 & 4096) != 0;
			}
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x0007C905 File Offset: 0x0007AB05
		[DebuggerNonUserCode]
		public void ClearIsCrossplayEnabled()
		{
			this._hasBits0 &= -4097;
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x0600203F RID: 8255 RVA: 0x0007C91C File Offset: 0x0007AB1C
		// (set) Token: 0x06002040 RID: 8256 RVA: 0x0007C951 File Offset: 0x0007AB51
		[DebuggerNonUserCode]
		public long DisconnectedFromGameTime
		{
			get
			{
				bool flag = (this._hasBits0 & 8192) != 0;
				long disconnectedFromGameTimeDefaultValue;
				if (flag)
				{
					disconnectedFromGameTimeDefaultValue = this.disconnectedFromGameTime_;
				}
				else
				{
					disconnectedFromGameTimeDefaultValue = PartyMember.DisconnectedFromGameTimeDefaultValue;
				}
				return disconnectedFromGameTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8192;
				this.disconnectedFromGameTime_ = value;
			}
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06002041 RID: 8257 RVA: 0x0007C970 File Offset: 0x0007AB70
		[DebuggerNonUserCode]
		public bool HasDisconnectedFromGameTime
		{
			get
			{
				return (this._hasBits0 & 8192) != 0;
			}
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x0007C991 File Offset: 0x0007AB91
		[DebuggerNonUserCode]
		public void ClearDisconnectedFromGameTime()
		{
			this._hasBits0 &= -8193;
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06002043 RID: 8259 RVA: 0x0007C9A8 File Offset: 0x0007ABA8
		// (set) Token: 0x06002044 RID: 8260 RVA: 0x0007C9DD File Offset: 0x0007ABDD
		[DebuggerNonUserCode]
		public bool IsMultiplayerAllowed
		{
			get
			{
				bool flag = (this._hasBits0 & 16384) != 0;
				bool isMultiplayerAllowedDefaultValue;
				if (flag)
				{
					isMultiplayerAllowedDefaultValue = this.isMultiplayerAllowed_;
				}
				else
				{
					isMultiplayerAllowedDefaultValue = PartyMember.IsMultiplayerAllowedDefaultValue;
				}
				return isMultiplayerAllowedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16384;
				this.isMultiplayerAllowed_ = value;
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06002045 RID: 8261 RVA: 0x0007C9FC File Offset: 0x0007ABFC
		[DebuggerNonUserCode]
		public bool HasIsMultiplayerAllowed
		{
			get
			{
				return (this._hasBits0 & 16384) != 0;
			}
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x0007CA1D File Offset: 0x0007AC1D
		[DebuggerNonUserCode]
		public void ClearIsMultiplayerAllowed()
		{
			this._hasBits0 &= -16385;
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06002047 RID: 8263 RVA: 0x0007CA34 File Offset: 0x0007AC34
		// (set) Token: 0x06002048 RID: 8264 RVA: 0x0007CA69 File Offset: 0x0007AC69
		[DebuggerNonUserCode]
		public int MaxWorldTier
		{
			get
			{
				bool flag = (this._hasBits0 & 32768) != 0;
				int maxWorldTierDefaultValue;
				if (flag)
				{
					maxWorldTierDefaultValue = this.maxWorldTier_;
				}
				else
				{
					maxWorldTierDefaultValue = PartyMember.MaxWorldTierDefaultValue;
				}
				return maxWorldTierDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32768;
				this.maxWorldTier_ = value;
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06002049 RID: 8265 RVA: 0x0007CA88 File Offset: 0x0007AC88
		[DebuggerNonUserCode]
		public bool HasMaxWorldTier
		{
			get
			{
				return (this._hasBits0 & 32768) != 0;
			}
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x0007CAA9 File Offset: 0x0007ACA9
		[DebuggerNonUserCode]
		public void ClearMaxWorldTier()
		{
			this._hasBits0 &= -32769;
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x0600204B RID: 8267 RVA: 0x0007CAC0 File Offset: 0x0007ACC0
		// (set) Token: 0x0600204C RID: 8268 RVA: 0x0007CAE1 File Offset: 0x0007ACE1
		[DebuggerNonUserCode]
		public string HeroName
		{
			get
			{
				return this.heroName_ ?? PartyMember.HeroNameDefaultValue;
			}
			set
			{
				this.heroName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x0600204D RID: 8269 RVA: 0x0007CAF8 File Offset: 0x0007ACF8
		[DebuggerNonUserCode]
		public bool HasHeroName
		{
			get
			{
				return this.heroName_ != null;
			}
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x0007CB13 File Offset: 0x0007AD13
		[DebuggerNonUserCode]
		public void ClearHeroName()
		{
			this.heroName_ = null;
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x0600204F RID: 8271 RVA: 0x0007CB20 File Offset: 0x0007AD20
		// (set) Token: 0x06002050 RID: 8272 RVA: 0x0007CB55 File Offset: 0x0007AD55
		[DebuggerNonUserCode]
		public bool CanSetCampaignState
		{
			get
			{
				bool flag = (this._hasBits0 & 65536) != 0;
				bool canSetCampaignStateDefaultValue;
				if (flag)
				{
					canSetCampaignStateDefaultValue = this.canSetCampaignState_;
				}
				else
				{
					canSetCampaignStateDefaultValue = PartyMember.CanSetCampaignStateDefaultValue;
				}
				return canSetCampaignStateDefaultValue;
			}
			set
			{
				this._hasBits0 |= 65536;
				this.canSetCampaignState_ = value;
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06002051 RID: 8273 RVA: 0x0007CB74 File Offset: 0x0007AD74
		[DebuggerNonUserCode]
		public bool HasCanSetCampaignState
		{
			get
			{
				return (this._hasBits0 & 65536) != 0;
			}
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x0007CB95 File Offset: 0x0007AD95
		[DebuggerNonUserCode]
		public void ClearCanSetCampaignState()
		{
			this._hasBits0 &= -65537;
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x0007CBAC File Offset: 0x0007ADAC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartyMember);
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x0007CBCC File Offset: 0x0007ADCC
		[DebuggerNonUserCode]
		public bool Equals(PartyMember other)
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
					bool flag4 = this.BnetAccountId != other.BnetAccountId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.GameAccountId != other.GameAccountId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.HeroId != other.HeroId;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.AccountName != other.AccountName;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.HeroClass != other.HeroClass;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.HeroFlags != other.HeroFlags;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.HeroLevel != other.HeroLevel;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.IsLeader != other.IsLeader;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.PartyId != other.PartyId;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.GroupId != other.GroupId;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.XPosition != other.XPosition;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.YPosition != other.YPosition;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.WorldSno != other.WorldSno;
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = this.LevelareaSno != other.LevelareaSno;
																		if (flag17)
																		{
																			flag2 = false;
																		}
																		else
																		{
																			bool flag18 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.HitpointPercent, other.HitpointPercent);
																			if (flag18)
																			{
																				flag2 = false;
																			}
																			else
																			{
																				bool flag19 = this.ServerPool != other.ServerPool;
																				if (flag19)
																				{
																					flag2 = false;
																				}
																				else
																				{
																					bool flag20 = !object.Equals(this.VisualEquipment, other.VisualEquipment);
																					if (flag20)
																					{
																						flag2 = false;
																					}
																					else
																					{
																						bool flag21 = !object.Equals(this.Appearance, other.Appearance);
																						if (flag21)
																						{
																							flag2 = false;
																						}
																						else
																						{
																							bool flag22 = !object.Equals(this.PlatformAccount, other.PlatformAccount);
																							if (flag22)
																							{
																								flag2 = false;
																							}
																							else
																							{
																								bool flag23 = !object.Equals(this.CampaignState, other.CampaignState);
																								if (flag23)
																								{
																									flag2 = false;
																								}
																								else
																								{
																									bool flag24 = this.ReturnPartyId != other.ReturnPartyId;
																									if (flag24)
																									{
																										flag2 = false;
																									}
																									else
																									{
																										bool flag25 = !object.Equals(this.MapPinData, other.MapPinData);
																										if (flag25)
																										{
																											flag2 = false;
																										}
																										else
																										{
																											bool flag26 = this.IsCrossplayEnabled != other.IsCrossplayEnabled;
																											if (flag26)
																											{
																												flag2 = false;
																											}
																											else
																											{
																												bool flag27 = this.DisconnectedFromGameTime != other.DisconnectedFromGameTime;
																												if (flag27)
																												{
																													flag2 = false;
																												}
																												else
																												{
																													bool flag28 = this.IsMultiplayerAllowed != other.IsMultiplayerAllowed;
																													if (flag28)
																													{
																														flag2 = false;
																													}
																													else
																													{
																														bool flag29 = this.MaxWorldTier != other.MaxWorldTier;
																														if (flag29)
																														{
																															flag2 = false;
																														}
																														else
																														{
																															bool flag30 = this.HeroName != other.HeroName;
																															if (flag30)
																															{
																																flag2 = false;
																															}
																															else
																															{
																																bool flag31 = this.CanSetCampaignState != other.CanSetCampaignState;
																																flag2 = !flag31 && object.Equals(this._unknownFields, other._unknownFields);
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x0007CF60 File Offset: 0x0007B160
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasBnetAccountId = this.HasBnetAccountId;
			if (hasBnetAccountId)
			{
				num ^= this.BnetAccountId.GetHashCode();
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				num ^= this.HeroId.GetHashCode();
			}
			bool hasAccountName = this.HasAccountName;
			if (hasAccountName)
			{
				num ^= this.AccountName.GetHashCode();
			}
			bool hasHeroClass = this.HasHeroClass;
			if (hasHeroClass)
			{
				num ^= this.HeroClass.GetHashCode();
			}
			bool hasHeroFlags = this.HasHeroFlags;
			if (hasHeroFlags)
			{
				num ^= this.HeroFlags.GetHashCode();
			}
			bool hasHeroLevel = this.HasHeroLevel;
			if (hasHeroLevel)
			{
				num ^= this.HeroLevel.GetHashCode();
			}
			bool hasIsLeader = this.HasIsLeader;
			if (hasIsLeader)
			{
				num ^= this.IsLeader.GetHashCode();
			}
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num ^= this.PartyId.GetHashCode();
			}
			bool hasGroupId = this.HasGroupId;
			if (hasGroupId)
			{
				num ^= this.GroupId.GetHashCode();
			}
			bool hasXPosition = this.HasXPosition;
			if (hasXPosition)
			{
				num ^= this.XPosition.GetHashCode();
			}
			bool hasYPosition = this.HasYPosition;
			if (hasYPosition)
			{
				num ^= this.YPosition.GetHashCode();
			}
			bool hasWorldSno = this.HasWorldSno;
			if (hasWorldSno)
			{
				num ^= this.WorldSno.GetHashCode();
			}
			bool hasLevelareaSno = this.HasLevelareaSno;
			if (hasLevelareaSno)
			{
				num ^= this.LevelareaSno.GetHashCode();
			}
			bool hasHitpointPercent = this.HasHitpointPercent;
			if (hasHitpointPercent)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.HitpointPercent);
			}
			bool hasServerPool = this.HasServerPool;
			if (hasServerPool)
			{
				num ^= this.ServerPool.GetHashCode();
			}
			bool flag = this.visualEquipment_ != null;
			if (flag)
			{
				num ^= this.VisualEquipment.GetHashCode();
			}
			bool flag2 = this.appearance_ != null;
			if (flag2)
			{
				num ^= this.Appearance.GetHashCode();
			}
			bool flag3 = this.platformAccount_ != null;
			if (flag3)
			{
				num ^= this.PlatformAccount.GetHashCode();
			}
			bool flag4 = this.campaignState_ != null;
			if (flag4)
			{
				num ^= this.CampaignState.GetHashCode();
			}
			bool hasReturnPartyId = this.HasReturnPartyId;
			if (hasReturnPartyId)
			{
				num ^= this.ReturnPartyId.GetHashCode();
			}
			bool flag5 = this.mapPinData_ != null;
			if (flag5)
			{
				num ^= this.MapPinData.GetHashCode();
			}
			bool hasIsCrossplayEnabled = this.HasIsCrossplayEnabled;
			if (hasIsCrossplayEnabled)
			{
				num ^= this.IsCrossplayEnabled.GetHashCode();
			}
			bool hasDisconnectedFromGameTime = this.HasDisconnectedFromGameTime;
			if (hasDisconnectedFromGameTime)
			{
				num ^= this.DisconnectedFromGameTime.GetHashCode();
			}
			bool hasIsMultiplayerAllowed = this.HasIsMultiplayerAllowed;
			if (hasIsMultiplayerAllowed)
			{
				num ^= this.IsMultiplayerAllowed.GetHashCode();
			}
			bool hasMaxWorldTier = this.HasMaxWorldTier;
			if (hasMaxWorldTier)
			{
				num ^= this.MaxWorldTier.GetHashCode();
			}
			bool hasHeroName = this.HasHeroName;
			if (hasHeroName)
			{
				num ^= this.HeroName.GetHashCode();
			}
			bool hasCanSetCampaignState = this.HasCanSetCampaignState;
			if (hasCanSetCampaignState)
			{
				num ^= this.CanSetCampaignState.GetHashCode();
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x0007D2BC File Offset: 0x0007B4BC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x0007D2D4 File Offset: 0x0007B4D4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x0007D2E0 File Offset: 0x0007B4E0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasBnetAccountId = this.HasBnetAccountId;
			if (hasBnetAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.BnetAccountId);
			}
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				output.WriteRawTag(18);
				output.WriteString(this.HeroId);
			}
			bool hasAccountName = this.HasAccountName;
			if (hasAccountName)
			{
				output.WriteRawTag(26);
				output.WriteString(this.AccountName);
			}
			bool hasHeroClass = this.HasHeroClass;
			if (hasHeroClass)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.HeroClass);
			}
			bool hasHeroFlags = this.HasHeroFlags;
			if (hasHeroFlags)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.HeroFlags);
			}
			bool hasHeroLevel = this.HasHeroLevel;
			if (hasHeroLevel)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.HeroLevel);
			}
			bool hasIsLeader = this.HasIsLeader;
			if (hasIsLeader)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsLeader);
			}
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				output.WriteRawTag(66);
				output.WriteString(this.PartyId);
			}
			bool hasGroupId = this.HasGroupId;
			if (hasGroupId)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.GroupId);
			}
			bool hasXPosition = this.HasXPosition;
			if (hasXPosition)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.XPosition);
			}
			bool hasYPosition = this.HasYPosition;
			if (hasYPosition)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.YPosition);
			}
			bool hasWorldSno = this.HasWorldSno;
			if (hasWorldSno)
			{
				output.WriteRawTag(109);
				output.WriteSFixed32(this.WorldSno);
			}
			bool hasLevelareaSno = this.HasLevelareaSno;
			if (hasLevelareaSno)
			{
				output.WriteRawTag(117);
				output.WriteSFixed32(this.LevelareaSno);
			}
			bool hasServerPool = this.HasServerPool;
			if (hasServerPool)
			{
				output.WriteRawTag(122);
				output.WriteString(this.ServerPool);
			}
			bool flag = this.visualEquipment_ != null;
			if (flag)
			{
				output.WriteRawTag(130, 1);
				output.WriteMessage(this.VisualEquipment);
			}
			bool flag2 = this.appearance_ != null;
			if (flag2)
			{
				output.WriteRawTag(138, 1);
				output.WriteMessage(this.Appearance);
			}
			bool flag3 = this.platformAccount_ != null;
			if (flag3)
			{
				output.WriteRawTag(146, 1);
				output.WriteMessage(this.PlatformAccount);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(152, 1);
				output.WriteUInt32(this.GameAccountId);
			}
			bool flag4 = this.campaignState_ != null;
			if (flag4)
			{
				output.WriteRawTag(170, 1);
				output.WriteMessage(this.CampaignState);
			}
			bool hasHitpointPercent = this.HasHitpointPercent;
			if (hasHitpointPercent)
			{
				output.WriteRawTag(181, 1);
				output.WriteFloat(this.HitpointPercent);
			}
			bool hasReturnPartyId = this.HasReturnPartyId;
			if (hasReturnPartyId)
			{
				output.WriteRawTag(186, 1);
				output.WriteString(this.ReturnPartyId);
			}
			bool flag5 = this.mapPinData_ != null;
			if (flag5)
			{
				output.WriteRawTag(194, 1);
				output.WriteMessage(this.MapPinData);
			}
			bool hasIsCrossplayEnabled = this.HasIsCrossplayEnabled;
			if (hasIsCrossplayEnabled)
			{
				output.WriteRawTag(200, 1);
				output.WriteBool(this.IsCrossplayEnabled);
			}
			bool hasDisconnectedFromGameTime = this.HasDisconnectedFromGameTime;
			if (hasDisconnectedFromGameTime)
			{
				output.WriteRawTag(208, 1);
				output.WriteInt64(this.DisconnectedFromGameTime);
			}
			bool hasIsMultiplayerAllowed = this.HasIsMultiplayerAllowed;
			if (hasIsMultiplayerAllowed)
			{
				output.WriteRawTag(216, 1);
				output.WriteBool(this.IsMultiplayerAllowed);
			}
			bool hasMaxWorldTier = this.HasMaxWorldTier;
			if (hasMaxWorldTier)
			{
				output.WriteRawTag(224, 1);
				output.WriteInt32(this.MaxWorldTier);
			}
			bool hasHeroName = this.HasHeroName;
			if (hasHeroName)
			{
				output.WriteRawTag(234, 1);
				output.WriteString(this.HeroName);
			}
			bool hasCanSetCampaignState = this.HasCanSetCampaignState;
			if (hasCanSetCampaignState)
			{
				output.WriteRawTag(240, 1);
				output.WriteBool(this.CanSetCampaignState);
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x0007D73C File Offset: 0x0007B93C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasBnetAccountId = this.HasBnetAccountId;
			if (hasBnetAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BnetAccountId);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.HeroId);
			}
			bool hasAccountName = this.HasAccountName;
			if (hasAccountName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AccountName);
			}
			bool hasHeroClass = this.HasHeroClass;
			if (hasHeroClass)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HeroClass);
			}
			bool hasHeroFlags = this.HasHeroFlags;
			if (hasHeroFlags)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HeroFlags);
			}
			bool hasHeroLevel = this.HasHeroLevel;
			if (hasHeroLevel)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HeroLevel);
			}
			bool hasIsLeader = this.HasIsLeader;
			if (hasIsLeader)
			{
				num += 2;
			}
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PartyId);
			}
			bool hasGroupId = this.HasGroupId;
			if (hasGroupId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			bool hasXPosition = this.HasXPosition;
			if (hasXPosition)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.XPosition);
			}
			bool hasYPosition = this.HasYPosition;
			if (hasYPosition)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.YPosition);
			}
			bool hasWorldSno = this.HasWorldSno;
			if (hasWorldSno)
			{
				num += 5;
			}
			bool hasLevelareaSno = this.HasLevelareaSno;
			if (hasLevelareaSno)
			{
				num += 5;
			}
			bool hasHitpointPercent = this.HasHitpointPercent;
			if (hasHitpointPercent)
			{
				num += 6;
			}
			bool hasServerPool = this.HasServerPool;
			if (hasServerPool)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ServerPool);
			}
			bool flag = this.visualEquipment_ != null;
			if (flag)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.VisualEquipment);
			}
			bool flag2 = this.appearance_ != null;
			if (flag2)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.Appearance);
			}
			bool flag3 = this.platformAccount_ != null;
			if (flag3)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PlatformAccount);
			}
			bool flag4 = this.campaignState_ != null;
			if (flag4)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.CampaignState);
			}
			bool hasReturnPartyId = this.HasReturnPartyId;
			if (hasReturnPartyId)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.ReturnPartyId);
			}
			bool flag5 = this.mapPinData_ != null;
			if (flag5)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MapPinData);
			}
			bool hasIsCrossplayEnabled = this.HasIsCrossplayEnabled;
			if (hasIsCrossplayEnabled)
			{
				num += 3;
			}
			bool hasDisconnectedFromGameTime = this.HasDisconnectedFromGameTime;
			if (hasDisconnectedFromGameTime)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.DisconnectedFromGameTime);
			}
			bool hasIsMultiplayerAllowed = this.HasIsMultiplayerAllowed;
			if (hasIsMultiplayerAllowed)
			{
				num += 3;
			}
			bool hasMaxWorldTier = this.HasMaxWorldTier;
			if (hasMaxWorldTier)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.MaxWorldTier);
			}
			bool hasHeroName = this.HasHeroName;
			if (hasHeroName)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.HeroName);
			}
			bool hasCanSetCampaignState = this.HasCanSetCampaignState;
			if (hasCanSetCampaignState)
			{
				num += 3;
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x0007DA70 File Offset: 0x0007BC70
		[DebuggerNonUserCode]
		public void MergeFrom(PartyMember other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasBnetAccountId = other.HasBnetAccountId;
				if (hasBnetAccountId)
				{
					this.BnetAccountId = other.BnetAccountId;
				}
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				bool hasHeroId = other.HasHeroId;
				if (hasHeroId)
				{
					this.HeroId = other.HeroId;
				}
				bool hasAccountName = other.HasAccountName;
				if (hasAccountName)
				{
					this.AccountName = other.AccountName;
				}
				bool hasHeroClass = other.HasHeroClass;
				if (hasHeroClass)
				{
					this.HeroClass = other.HeroClass;
				}
				bool hasHeroFlags = other.HasHeroFlags;
				if (hasHeroFlags)
				{
					this.HeroFlags = other.HeroFlags;
				}
				bool hasHeroLevel = other.HasHeroLevel;
				if (hasHeroLevel)
				{
					this.HeroLevel = other.HeroLevel;
				}
				bool hasIsLeader = other.HasIsLeader;
				if (hasIsLeader)
				{
					this.IsLeader = other.IsLeader;
				}
				bool hasPartyId = other.HasPartyId;
				if (hasPartyId)
				{
					this.PartyId = other.PartyId;
				}
				bool hasGroupId = other.HasGroupId;
				if (hasGroupId)
				{
					this.GroupId = other.GroupId;
				}
				bool hasXPosition = other.HasXPosition;
				if (hasXPosition)
				{
					this.XPosition = other.XPosition;
				}
				bool hasYPosition = other.HasYPosition;
				if (hasYPosition)
				{
					this.YPosition = other.YPosition;
				}
				bool hasWorldSno = other.HasWorldSno;
				if (hasWorldSno)
				{
					this.WorldSno = other.WorldSno;
				}
				bool hasLevelareaSno = other.HasLevelareaSno;
				if (hasLevelareaSno)
				{
					this.LevelareaSno = other.LevelareaSno;
				}
				bool hasHitpointPercent = other.HasHitpointPercent;
				if (hasHitpointPercent)
				{
					this.HitpointPercent = other.HitpointPercent;
				}
				bool hasServerPool = other.HasServerPool;
				if (hasServerPool)
				{
					this.ServerPool = other.ServerPool;
				}
				bool flag2 = other.visualEquipment_ != null;
				if (flag2)
				{
					bool flag3 = this.visualEquipment_ == null;
					if (flag3)
					{
						this.VisualEquipment = new VisualEquipment();
					}
					this.VisualEquipment.MergeFrom(other.VisualEquipment);
				}
				bool flag4 = other.appearance_ != null;
				if (flag4)
				{
					bool flag5 = this.appearance_ == null;
					if (flag5)
					{
						this.Appearance = new AppearanceCustomization();
					}
					this.Appearance.MergeFrom(other.Appearance);
				}
				bool flag6 = other.platformAccount_ != null;
				if (flag6)
				{
					bool flag7 = this.platformAccount_ == null;
					if (flag7)
					{
						this.PlatformAccount = new PlatformAccount();
					}
					this.PlatformAccount.MergeFrom(other.PlatformAccount);
				}
				bool flag8 = other.campaignState_ != null;
				if (flag8)
				{
					bool flag9 = this.campaignState_ == null;
					if (flag9)
					{
						this.CampaignState = new CampaignState();
					}
					this.CampaignState.MergeFrom(other.CampaignState);
				}
				bool hasReturnPartyId = other.HasReturnPartyId;
				if (hasReturnPartyId)
				{
					this.ReturnPartyId = other.ReturnPartyId;
				}
				bool flag10 = other.mapPinData_ != null;
				if (flag10)
				{
					bool flag11 = this.mapPinData_ == null;
					if (flag11)
					{
						this.MapPinData = new MapPinData();
					}
					this.MapPinData.MergeFrom(other.MapPinData);
				}
				bool hasIsCrossplayEnabled = other.HasIsCrossplayEnabled;
				if (hasIsCrossplayEnabled)
				{
					this.IsCrossplayEnabled = other.IsCrossplayEnabled;
				}
				bool hasDisconnectedFromGameTime = other.HasDisconnectedFromGameTime;
				if (hasDisconnectedFromGameTime)
				{
					this.DisconnectedFromGameTime = other.DisconnectedFromGameTime;
				}
				bool hasIsMultiplayerAllowed = other.HasIsMultiplayerAllowed;
				if (hasIsMultiplayerAllowed)
				{
					this.IsMultiplayerAllowed = other.IsMultiplayerAllowed;
				}
				bool hasMaxWorldTier = other.HasMaxWorldTier;
				if (hasMaxWorldTier)
				{
					this.MaxWorldTier = other.MaxWorldTier;
				}
				bool hasHeroName = other.HasHeroName;
				if (hasHeroName)
				{
					this.HeroName = other.HeroName;
				}
				bool hasCanSetCampaignState = other.HasCanSetCampaignState;
				if (hasCanSetCampaignState)
				{
					this.CanSetCampaignState = other.CanSetCampaignState;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x0007DE4A File Offset: 0x0007C04A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x0007DE58 File Offset: 0x0007C058
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 122U)
				{
					if (num3 <= 56U)
					{
						if (num3 <= 26U)
						{
							if (num3 != 8U)
							{
								if (num3 != 18U)
								{
									if (num3 != 26U)
									{
										goto IL_01AD;
									}
									this.AccountName = input.ReadString();
								}
								else
								{
									this.HeroId = input.ReadString();
								}
							}
							else
							{
								this.BnetAccountId = input.ReadUInt32();
							}
						}
						else if (num3 <= 40U)
						{
							if (num3 != 32U)
							{
								if (num3 != 40U)
								{
									goto IL_01AD;
								}
								this.HeroFlags = input.ReadUInt32();
							}
							else
							{
								this.HeroClass = input.ReadInt32();
							}
						}
						else if (num3 != 48U)
						{
							if (num3 != 56U)
							{
								goto IL_01AD;
							}
							this.IsLeader = input.ReadBool();
						}
						else
						{
							this.HeroLevel = input.ReadUInt32();
						}
					}
					else if (num3 <= 88U)
					{
						if (num3 != 66U)
						{
							if (num3 != 80U)
							{
								if (num3 != 88U)
								{
									goto IL_01AD;
								}
								this.XPosition = input.ReadInt32();
							}
							else
							{
								this.GroupId = input.ReadUInt32();
							}
						}
						else
						{
							this.PartyId = input.ReadString();
						}
					}
					else if (num3 <= 109U)
					{
						if (num3 != 96U)
						{
							if (num3 != 109U)
							{
								goto IL_01AD;
							}
							this.WorldSno = input.ReadSFixed32();
						}
						else
						{
							this.YPosition = input.ReadInt32();
						}
					}
					else if (num3 != 117U)
					{
						if (num3 != 122U)
						{
							goto IL_01AD;
						}
						this.ServerPool = input.ReadString();
					}
					else
					{
						this.LevelareaSno = input.ReadSFixed32();
					}
				}
				else if (num3 <= 186U)
				{
					if (num3 <= 146U)
					{
						if (num3 != 130U)
						{
							if (num3 != 138U)
							{
								if (num3 != 146U)
								{
									goto IL_01AD;
								}
								bool flag = this.platformAccount_ == null;
								if (flag)
								{
									this.PlatformAccount = new PlatformAccount();
								}
								input.ReadMessage(this.PlatformAccount);
							}
							else
							{
								bool flag2 = this.appearance_ == null;
								if (flag2)
								{
									this.Appearance = new AppearanceCustomization();
								}
								input.ReadMessage(this.Appearance);
							}
						}
						else
						{
							bool flag3 = this.visualEquipment_ == null;
							if (flag3)
							{
								this.VisualEquipment = new VisualEquipment();
							}
							input.ReadMessage(this.VisualEquipment);
						}
					}
					else if (num3 <= 170U)
					{
						if (num3 != 152U)
						{
							if (num3 != 170U)
							{
								goto IL_01AD;
							}
							bool flag4 = this.campaignState_ == null;
							if (flag4)
							{
								this.CampaignState = new CampaignState();
							}
							input.ReadMessage(this.CampaignState);
						}
						else
						{
							this.GameAccountId = input.ReadUInt32();
						}
					}
					else if (num3 != 181U)
					{
						if (num3 != 186U)
						{
							goto IL_01AD;
						}
						this.ReturnPartyId = input.ReadString();
					}
					else
					{
						this.HitpointPercent = input.ReadFloat();
					}
				}
				else if (num3 <= 208U)
				{
					if (num3 != 194U)
					{
						if (num3 != 200U)
						{
							if (num3 != 208U)
							{
								goto IL_01AD;
							}
							this.DisconnectedFromGameTime = input.ReadInt64();
						}
						else
						{
							this.IsCrossplayEnabled = input.ReadBool();
						}
					}
					else
					{
						bool flag5 = this.mapPinData_ == null;
						if (flag5)
						{
							this.MapPinData = new MapPinData();
						}
						input.ReadMessage(this.MapPinData);
					}
				}
				else if (num3 <= 224U)
				{
					if (num3 != 216U)
					{
						if (num3 != 224U)
						{
							goto IL_01AD;
						}
						this.MaxWorldTier = input.ReadInt32();
					}
					else
					{
						this.IsMultiplayerAllowed = input.ReadBool();
					}
				}
				else if (num3 != 234U)
				{
					if (num3 != 240U)
					{
						goto IL_01AD;
					}
					this.CanSetCampaignState = input.ReadBool();
				}
				else
				{
					this.HeroName = input.ReadString();
				}
				continue;
				IL_01AD:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000DF6 RID: 3574
		private static readonly MessageParser<PartyMember> _parser = new MessageParser<PartyMember>(() => new PartyMember());

		// Token: 0x04000DF7 RID: 3575
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000DF8 RID: 3576
		private int _hasBits0;

		// Token: 0x04000DF9 RID: 3577
		public const int BnetAccountIdFieldNumber = 1;

		// Token: 0x04000DFA RID: 3578
		private static readonly uint BnetAccountIdDefaultValue = 0U;

		// Token: 0x04000DFB RID: 3579
		private uint bnetAccountId_;

		// Token: 0x04000DFC RID: 3580
		public const int GameAccountIdFieldNumber = 19;

		// Token: 0x04000DFD RID: 3581
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x04000DFE RID: 3582
		private uint gameAccountId_;

		// Token: 0x04000DFF RID: 3583
		public const int HeroIdFieldNumber = 2;

		// Token: 0x04000E00 RID: 3584
		private static readonly string HeroIdDefaultValue = "";

		// Token: 0x04000E01 RID: 3585
		private string heroId_;

		// Token: 0x04000E02 RID: 3586
		public const int AccountNameFieldNumber = 3;

		// Token: 0x04000E03 RID: 3587
		private static readonly string AccountNameDefaultValue = "";

		// Token: 0x04000E04 RID: 3588
		private string accountName_;

		// Token: 0x04000E05 RID: 3589
		public const int HeroClassFieldNumber = 4;

		// Token: 0x04000E06 RID: 3590
		private static readonly int HeroClassDefaultValue = 0;

		// Token: 0x04000E07 RID: 3591
		private int heroClass_;

		// Token: 0x04000E08 RID: 3592
		public const int HeroFlagsFieldNumber = 5;

		// Token: 0x04000E09 RID: 3593
		private static readonly uint HeroFlagsDefaultValue = 0U;

		// Token: 0x04000E0A RID: 3594
		private uint heroFlags_;

		// Token: 0x04000E0B RID: 3595
		public const int HeroLevelFieldNumber = 6;

		// Token: 0x04000E0C RID: 3596
		private static readonly uint HeroLevelDefaultValue = 0U;

		// Token: 0x04000E0D RID: 3597
		private uint heroLevel_;

		// Token: 0x04000E0E RID: 3598
		public const int IsLeaderFieldNumber = 7;

		// Token: 0x04000E0F RID: 3599
		private static readonly bool IsLeaderDefaultValue = false;

		// Token: 0x04000E10 RID: 3600
		private bool isLeader_;

		// Token: 0x04000E11 RID: 3601
		public const int PartyIdFieldNumber = 8;

		// Token: 0x04000E12 RID: 3602
		private static readonly string PartyIdDefaultValue = "";

		// Token: 0x04000E13 RID: 3603
		private string partyId_;

		// Token: 0x04000E14 RID: 3604
		public const int GroupIdFieldNumber = 10;

		// Token: 0x04000E15 RID: 3605
		private static readonly uint GroupIdDefaultValue = 0U;

		// Token: 0x04000E16 RID: 3606
		private uint groupId_;

		// Token: 0x04000E17 RID: 3607
		public const int XPositionFieldNumber = 11;

		// Token: 0x04000E18 RID: 3608
		private static readonly int XPositionDefaultValue = 0;

		// Token: 0x04000E19 RID: 3609
		private int xPosition_;

		// Token: 0x04000E1A RID: 3610
		public const int YPositionFieldNumber = 12;

		// Token: 0x04000E1B RID: 3611
		private static readonly int YPositionDefaultValue = 0;

		// Token: 0x04000E1C RID: 3612
		private int yPosition_;

		// Token: 0x04000E1D RID: 3613
		public const int WorldSnoFieldNumber = 13;

		// Token: 0x04000E1E RID: 3614
		private static readonly int WorldSnoDefaultValue = 0;

		// Token: 0x04000E1F RID: 3615
		private int worldSno_;

		// Token: 0x04000E20 RID: 3616
		public const int LevelareaSnoFieldNumber = 14;

		// Token: 0x04000E21 RID: 3617
		private static readonly int LevelareaSnoDefaultValue = 0;

		// Token: 0x04000E22 RID: 3618
		private int levelareaSno_;

		// Token: 0x04000E23 RID: 3619
		public const int HitpointPercentFieldNumber = 22;

		// Token: 0x04000E24 RID: 3620
		private static readonly float HitpointPercentDefaultValue = 0f;

		// Token: 0x04000E25 RID: 3621
		private float hitpointPercent_;

		// Token: 0x04000E26 RID: 3622
		public const int ServerPoolFieldNumber = 15;

		// Token: 0x04000E27 RID: 3623
		private static readonly string ServerPoolDefaultValue = "";

		// Token: 0x04000E28 RID: 3624
		private string serverPool_;

		// Token: 0x04000E29 RID: 3625
		public const int VisualEquipmentFieldNumber = 16;

		// Token: 0x04000E2A RID: 3626
		private VisualEquipment visualEquipment_;

		// Token: 0x04000E2B RID: 3627
		public const int AppearanceFieldNumber = 17;

		// Token: 0x04000E2C RID: 3628
		private AppearanceCustomization appearance_;

		// Token: 0x04000E2D RID: 3629
		public const int PlatformAccountFieldNumber = 18;

		// Token: 0x04000E2E RID: 3630
		private PlatformAccount platformAccount_;

		// Token: 0x04000E2F RID: 3631
		public const int CampaignStateFieldNumber = 21;

		// Token: 0x04000E30 RID: 3632
		private CampaignState campaignState_;

		// Token: 0x04000E31 RID: 3633
		public const int ReturnPartyIdFieldNumber = 23;

		// Token: 0x04000E32 RID: 3634
		private static readonly string ReturnPartyIdDefaultValue = "";

		// Token: 0x04000E33 RID: 3635
		private string returnPartyId_;

		// Token: 0x04000E34 RID: 3636
		public const int MapPinDataFieldNumber = 24;

		// Token: 0x04000E35 RID: 3637
		private MapPinData mapPinData_;

		// Token: 0x04000E36 RID: 3638
		public const int IsCrossplayEnabledFieldNumber = 25;

		// Token: 0x04000E37 RID: 3639
		private static readonly bool IsCrossplayEnabledDefaultValue = false;

		// Token: 0x04000E38 RID: 3640
		private bool isCrossplayEnabled_;

		// Token: 0x04000E39 RID: 3641
		public const int DisconnectedFromGameTimeFieldNumber = 26;

		// Token: 0x04000E3A RID: 3642
		private static readonly long DisconnectedFromGameTimeDefaultValue = 0L;

		// Token: 0x04000E3B RID: 3643
		private long disconnectedFromGameTime_;

		// Token: 0x04000E3C RID: 3644
		public const int IsMultiplayerAllowedFieldNumber = 27;

		// Token: 0x04000E3D RID: 3645
		private static readonly bool IsMultiplayerAllowedDefaultValue = false;

		// Token: 0x04000E3E RID: 3646
		private bool isMultiplayerAllowed_;

		// Token: 0x04000E3F RID: 3647
		public const int MaxWorldTierFieldNumber = 28;

		// Token: 0x04000E40 RID: 3648
		private static readonly int MaxWorldTierDefaultValue = 1;

		// Token: 0x04000E41 RID: 3649
		private int maxWorldTier_;

		// Token: 0x04000E42 RID: 3650
		public const int HeroNameFieldNumber = 29;

		// Token: 0x04000E43 RID: 3651
		private static readonly string HeroNameDefaultValue = "";

		// Token: 0x04000E44 RID: 3652
		private string heroName_;

		// Token: 0x04000E45 RID: 3653
		public const int CanSetCampaignStateFieldNumber = 30;

		// Token: 0x04000E46 RID: 3654
		private static readonly bool CanSetCampaignStateDefaultValue = false;

		// Token: 0x04000E47 RID: 3655
		private bool canSetCampaignState_;
	}
}
