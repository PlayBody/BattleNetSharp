using System;
using System.Diagnostics;
using Fenris.Online;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x02000196 RID: 406
	public sealed class NewPlayerMessage : IMessage<NewPlayerMessage>, IMessage, IEquatable<NewPlayerMessage>, IDeepCloneable<NewPlayerMessage>, IBufferMessage
	{
		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x06002AD4 RID: 10964 RVA: 0x000A8634 File Offset: 0x000A6834
		[DebuggerNonUserCode]
		public static MessageParser<NewPlayerMessage> Parser
		{
			get
			{
				return NewPlayerMessage._parser;
			}
		}

		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x06002AD5 RID: 10965 RVA: 0x000A864C File Offset: 0x000A684C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[29];
			}
		}

		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x06002AD6 RID: 10966 RVA: 0x000A8670 File Offset: 0x000A6870
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerMessage.Descriptor;
			}
		}

		// Token: 0x06002AD7 RID: 10967 RVA: 0x000A8687 File Offset: 0x000A6887
		[DebuggerNonUserCode]
		public NewPlayerMessage()
		{
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x000A8694 File Offset: 0x000A6894
		[DebuggerNonUserCode]
		public NewPlayerMessage(NewPlayerMessage other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.heroId_ = other.heroId_;
			this.partyId_ = other.partyId_;
			this.accountId_ = other.accountId_;
			this.gameAccountId_ = other.gameAccountId_;
			this.platformAccount_ = ((other.platformAccount_ != null) ? other.platformAccount_.Clone() : null);
			this.heroName_ = other.heroName_;
			this.team_ = other.team_;
			this.playerclass_ = other.playerclass_;
			this.actorPortraitSno_ = other.actorPortraitSno_;
			this.currentLevel_ = other.currentLevel_;
			this.heroStateData_ = ((other.heroStateData_ != null) ? other.heroStateData_.Clone() : null);
			this.justJoined_ = other.justJoined_;
			this.ann_ = other.ann_;
			this.accountName_ = other.accountName_;
			this.shapeshiftForm_ = other.shapeshiftForm_;
			this.sessionId_ = other.sessionId_;
			this.privateProfile_ = other.privateProfile_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x000A87B4 File Offset: 0x000A69B4
		[DebuggerNonUserCode]
		public NewPlayerMessage Clone()
		{
			return new NewPlayerMessage(this);
		}

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x06002ADA RID: 10970 RVA: 0x000A87CC File Offset: 0x000A69CC
		// (set) Token: 0x06002ADB RID: 10971 RVA: 0x000A87ED File Offset: 0x000A69ED
		[DebuggerNonUserCode]
		public string HeroId
		{
			get
			{
				return this.heroId_ ?? NewPlayerMessage.HeroIdDefaultValue;
			}
			set
			{
				this.heroId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x06002ADC RID: 10972 RVA: 0x000A8804 File Offset: 0x000A6A04
		[DebuggerNonUserCode]
		public bool HasHeroId
		{
			get
			{
				return this.heroId_ != null;
			}
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x000A881F File Offset: 0x000A6A1F
		[DebuggerNonUserCode]
		public void ClearHeroId()
		{
			this.heroId_ = null;
		}

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x06002ADE RID: 10974 RVA: 0x000A882C File Offset: 0x000A6A2C
		// (set) Token: 0x06002ADF RID: 10975 RVA: 0x000A884D File Offset: 0x000A6A4D
		[DebuggerNonUserCode]
		public string PartyId
		{
			get
			{
				return this.partyId_ ?? NewPlayerMessage.PartyIdDefaultValue;
			}
			set
			{
				this.partyId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x06002AE0 RID: 10976 RVA: 0x000A8864 File Offset: 0x000A6A64
		[DebuggerNonUserCode]
		public bool HasPartyId
		{
			get
			{
				return this.partyId_ != null;
			}
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x000A887F File Offset: 0x000A6A7F
		[DebuggerNonUserCode]
		public void ClearPartyId()
		{
			this.partyId_ = null;
		}

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x06002AE2 RID: 10978 RVA: 0x000A888C File Offset: 0x000A6A8C
		// (set) Token: 0x06002AE3 RID: 10979 RVA: 0x000A88BD File Offset: 0x000A6ABD
		[DebuggerNonUserCode]
		public uint AccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint accountIdDefaultValue;
				if (flag)
				{
					accountIdDefaultValue = this.accountId_;
				}
				else
				{
					accountIdDefaultValue = NewPlayerMessage.AccountIdDefaultValue;
				}
				return accountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.accountId_ = value;
			}
		}

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x06002AE4 RID: 10980 RVA: 0x000A88D8 File Offset: 0x000A6AD8
		[DebuggerNonUserCode]
		public bool HasAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002AE5 RID: 10981 RVA: 0x000A88F5 File Offset: 0x000A6AF5
		[DebuggerNonUserCode]
		public void ClearAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x06002AE6 RID: 10982 RVA: 0x000A8908 File Offset: 0x000A6B08
		// (set) Token: 0x06002AE7 RID: 10983 RVA: 0x000A8939 File Offset: 0x000A6B39
		[DebuggerNonUserCode]
		public uint GameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint gameAccountIdDefaultValue;
				if (flag)
				{
					gameAccountIdDefaultValue = this.gameAccountId_;
				}
				else
				{
					gameAccountIdDefaultValue = NewPlayerMessage.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x06002AE8 RID: 10984 RVA: 0x000A8954 File Offset: 0x000A6B54
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002AE9 RID: 10985 RVA: 0x000A8971 File Offset: 0x000A6B71
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x06002AEA RID: 10986 RVA: 0x000A8984 File Offset: 0x000A6B84
		// (set) Token: 0x06002AEB RID: 10987 RVA: 0x000A899C File Offset: 0x000A6B9C
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

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x06002AEC RID: 10988 RVA: 0x000A89A8 File Offset: 0x000A6BA8
		// (set) Token: 0x06002AED RID: 10989 RVA: 0x000A89C9 File Offset: 0x000A6BC9
		[DebuggerNonUserCode]
		public string HeroName
		{
			get
			{
				return this.heroName_ ?? NewPlayerMessage.HeroNameDefaultValue;
			}
			set
			{
				this.heroName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x06002AEE RID: 10990 RVA: 0x000A89E0 File Offset: 0x000A6BE0
		[DebuggerNonUserCode]
		public bool HasHeroName
		{
			get
			{
				return this.heroName_ != null;
			}
		}

		// Token: 0x06002AEF RID: 10991 RVA: 0x000A89FB File Offset: 0x000A6BFB
		[DebuggerNonUserCode]
		public void ClearHeroName()
		{
			this.heroName_ = null;
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x06002AF0 RID: 10992 RVA: 0x000A8A08 File Offset: 0x000A6C08
		// (set) Token: 0x06002AF1 RID: 10993 RVA: 0x000A8A39 File Offset: 0x000A6C39
		[DebuggerNonUserCode]
		public int Team
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int teamDefaultValue;
				if (flag)
				{
					teamDefaultValue = this.team_;
				}
				else
				{
					teamDefaultValue = NewPlayerMessage.TeamDefaultValue;
				}
				return teamDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.team_ = value;
			}
		}

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x06002AF2 RID: 10994 RVA: 0x000A8A54 File Offset: 0x000A6C54
		[DebuggerNonUserCode]
		public bool HasTeam
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06002AF3 RID: 10995 RVA: 0x000A8A71 File Offset: 0x000A6C71
		[DebuggerNonUserCode]
		public void ClearTeam()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x06002AF4 RID: 10996 RVA: 0x000A8A84 File Offset: 0x000A6C84
		// (set) Token: 0x06002AF5 RID: 10997 RVA: 0x000A8AB5 File Offset: 0x000A6CB5
		[DebuggerNonUserCode]
		public int Playerclass
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int playerclassDefaultValue;
				if (flag)
				{
					playerclassDefaultValue = this.playerclass_;
				}
				else
				{
					playerclassDefaultValue = NewPlayerMessage.PlayerclassDefaultValue;
				}
				return playerclassDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.playerclass_ = value;
			}
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x06002AF6 RID: 10998 RVA: 0x000A8AD0 File Offset: 0x000A6CD0
		[DebuggerNonUserCode]
		public bool HasPlayerclass
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06002AF7 RID: 10999 RVA: 0x000A8AED File Offset: 0x000A6CED
		[DebuggerNonUserCode]
		public void ClearPlayerclass()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x06002AF8 RID: 11000 RVA: 0x000A8B00 File Offset: 0x000A6D00
		// (set) Token: 0x06002AF9 RID: 11001 RVA: 0x000A8B32 File Offset: 0x000A6D32
		[DebuggerNonUserCode]
		public int ActorPortraitSno
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				int actorPortraitSnoDefaultValue;
				if (flag)
				{
					actorPortraitSnoDefaultValue = this.actorPortraitSno_;
				}
				else
				{
					actorPortraitSnoDefaultValue = NewPlayerMessage.ActorPortraitSnoDefaultValue;
				}
				return actorPortraitSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.actorPortraitSno_ = value;
			}
		}

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x06002AFA RID: 11002 RVA: 0x000A8B4C File Offset: 0x000A6D4C
		[DebuggerNonUserCode]
		public bool HasActorPortraitSno
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x000A8B6A File Offset: 0x000A6D6A
		[DebuggerNonUserCode]
		public void ClearActorPortraitSno()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x06002AFC RID: 11004 RVA: 0x000A8B7C File Offset: 0x000A6D7C
		// (set) Token: 0x06002AFD RID: 11005 RVA: 0x000A8BAE File Offset: 0x000A6DAE
		[DebuggerNonUserCode]
		public int CurrentLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				int currentLevelDefaultValue;
				if (flag)
				{
					currentLevelDefaultValue = this.currentLevel_;
				}
				else
				{
					currentLevelDefaultValue = NewPlayerMessage.CurrentLevelDefaultValue;
				}
				return currentLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.currentLevel_ = value;
			}
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x06002AFE RID: 11006 RVA: 0x000A8BC8 File Offset: 0x000A6DC8
		[DebuggerNonUserCode]
		public bool HasCurrentLevel
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x000A8BE6 File Offset: 0x000A6DE6
		[DebuggerNonUserCode]
		public void ClearCurrentLevel()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x06002B00 RID: 11008 RVA: 0x000A8BF8 File Offset: 0x000A6DF8
		// (set) Token: 0x06002B01 RID: 11009 RVA: 0x000A8C10 File Offset: 0x000A6E10
		[DebuggerNonUserCode]
		public HeroStateDataDef HeroStateData
		{
			get
			{
				return this.heroStateData_;
			}
			set
			{
				this.heroStateData_ = value;
			}
		}

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x06002B02 RID: 11010 RVA: 0x000A8C1C File Offset: 0x000A6E1C
		// (set) Token: 0x06002B03 RID: 11011 RVA: 0x000A8C4E File Offset: 0x000A6E4E
		[DebuggerNonUserCode]
		public bool JustJoined
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				bool justJoinedDefaultValue;
				if (flag)
				{
					justJoinedDefaultValue = this.justJoined_;
				}
				else
				{
					justJoinedDefaultValue = NewPlayerMessage.JustJoinedDefaultValue;
				}
				return justJoinedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.justJoined_ = value;
			}
		}

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x06002B04 RID: 11012 RVA: 0x000A8C68 File Offset: 0x000A6E68
		[DebuggerNonUserCode]
		public bool HasJustJoined
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06002B05 RID: 11013 RVA: 0x000A8C86 File Offset: 0x000A6E86
		[DebuggerNonUserCode]
		public void ClearJustJoined()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x06002B06 RID: 11014 RVA: 0x000A8C98 File Offset: 0x000A6E98
		// (set) Token: 0x06002B07 RID: 11015 RVA: 0x000A8CCD File Offset: 0x000A6ECD
		[DebuggerNonUserCode]
		public int Ann
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				int annDefaultValue;
				if (flag)
				{
					annDefaultValue = this.ann_;
				}
				else
				{
					annDefaultValue = NewPlayerMessage.AnnDefaultValue;
				}
				return annDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.ann_ = value;
			}
		}

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x06002B08 RID: 11016 RVA: 0x000A8CEC File Offset: 0x000A6EEC
		[DebuggerNonUserCode]
		public bool HasAnn
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x06002B09 RID: 11017 RVA: 0x000A8D0D File Offset: 0x000A6F0D
		[DebuggerNonUserCode]
		public void ClearAnn()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x06002B0A RID: 11018 RVA: 0x000A8D24 File Offset: 0x000A6F24
		// (set) Token: 0x06002B0B RID: 11019 RVA: 0x000A8D45 File Offset: 0x000A6F45
		[DebuggerNonUserCode]
		public string AccountName
		{
			get
			{
				return this.accountName_ ?? NewPlayerMessage.AccountNameDefaultValue;
			}
			set
			{
				this.accountName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x06002B0C RID: 11020 RVA: 0x000A8D5C File Offset: 0x000A6F5C
		[DebuggerNonUserCode]
		public bool HasAccountName
		{
			get
			{
				return this.accountName_ != null;
			}
		}

		// Token: 0x06002B0D RID: 11021 RVA: 0x000A8D77 File Offset: 0x000A6F77
		[DebuggerNonUserCode]
		public void ClearAccountName()
		{
			this.accountName_ = null;
		}

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x06002B0E RID: 11022 RVA: 0x000A8D84 File Offset: 0x000A6F84
		// (set) Token: 0x06002B0F RID: 11023 RVA: 0x000A8DB9 File Offset: 0x000A6FB9
		[DebuggerNonUserCode]
		public int ShapeshiftForm
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				int shapeshiftFormDefaultValue;
				if (flag)
				{
					shapeshiftFormDefaultValue = this.shapeshiftForm_;
				}
				else
				{
					shapeshiftFormDefaultValue = NewPlayerMessage.ShapeshiftFormDefaultValue;
				}
				return shapeshiftFormDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.shapeshiftForm_ = value;
			}
		}

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x06002B10 RID: 11024 RVA: 0x000A8DD8 File Offset: 0x000A6FD8
		[DebuggerNonUserCode]
		public bool HasShapeshiftForm
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x06002B11 RID: 11025 RVA: 0x000A8DF9 File Offset: 0x000A6FF9
		[DebuggerNonUserCode]
		public void ClearShapeshiftForm()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x06002B12 RID: 11026 RVA: 0x000A8E10 File Offset: 0x000A7010
		// (set) Token: 0x06002B13 RID: 11027 RVA: 0x000A8E31 File Offset: 0x000A7031
		[DebuggerNonUserCode]
		public string SessionId
		{
			get
			{
				return this.sessionId_ ?? NewPlayerMessage.SessionIdDefaultValue;
			}
			set
			{
				this.sessionId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x06002B14 RID: 11028 RVA: 0x000A8E48 File Offset: 0x000A7048
		[DebuggerNonUserCode]
		public bool HasSessionId
		{
			get
			{
				return this.sessionId_ != null;
			}
		}

		// Token: 0x06002B15 RID: 11029 RVA: 0x000A8E63 File Offset: 0x000A7063
		[DebuggerNonUserCode]
		public void ClearSessionId()
		{
			this.sessionId_ = null;
		}

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x06002B16 RID: 11030 RVA: 0x000A8E70 File Offset: 0x000A7070
		// (set) Token: 0x06002B17 RID: 11031 RVA: 0x000A8EA5 File Offset: 0x000A70A5
		[DebuggerNonUserCode]
		public bool PrivateProfile
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				bool privateProfileDefaultValue;
				if (flag)
				{
					privateProfileDefaultValue = this.privateProfile_;
				}
				else
				{
					privateProfileDefaultValue = NewPlayerMessage.PrivateProfileDefaultValue;
				}
				return privateProfileDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.privateProfile_ = value;
			}
		}

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x06002B18 RID: 11032 RVA: 0x000A8EC4 File Offset: 0x000A70C4
		[DebuggerNonUserCode]
		public bool HasPrivateProfile
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x000A8EE5 File Offset: 0x000A70E5
		[DebuggerNonUserCode]
		public void ClearPrivateProfile()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x06002B1A RID: 11034 RVA: 0x000A8EFC File Offset: 0x000A70FC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerMessage);
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x000A8F1C File Offset: 0x000A711C
		[DebuggerNonUserCode]
		public bool Equals(NewPlayerMessage other)
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
					bool flag4 = this.HeroId != other.HeroId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.PartyId != other.PartyId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.AccountId != other.AccountId;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.GameAccountId != other.GameAccountId;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.PlatformAccount, other.PlatformAccount);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.HeroName != other.HeroName;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.Team != other.Team;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.Playerclass != other.Playerclass;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.ActorPortraitSno != other.ActorPortraitSno;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.CurrentLevel != other.CurrentLevel;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = !object.Equals(this.HeroStateData, other.HeroStateData);
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.JustJoined != other.JustJoined;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.Ann != other.Ann;
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = this.AccountName != other.AccountName;
																		if (flag17)
																		{
																			flag2 = false;
																		}
																		else
																		{
																			bool flag18 = this.ShapeshiftForm != other.ShapeshiftForm;
																			if (flag18)
																			{
																				flag2 = false;
																			}
																			else
																			{
																				bool flag19 = this.SessionId != other.SessionId;
																				if (flag19)
																				{
																					flag2 = false;
																				}
																				else
																				{
																					bool flag20 = this.PrivateProfile != other.PrivateProfile;
																					flag2 = !flag20 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x06002B1C RID: 11036 RVA: 0x000A9158 File Offset: 0x000A7358
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				num ^= this.HeroId.GetHashCode();
			}
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num ^= this.PartyId.GetHashCode();
			}
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num ^= this.AccountId.GetHashCode();
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool flag = this.platformAccount_ != null;
			if (flag)
			{
				num ^= this.PlatformAccount.GetHashCode();
			}
			bool hasHeroName = this.HasHeroName;
			if (hasHeroName)
			{
				num ^= this.HeroName.GetHashCode();
			}
			bool hasTeam = this.HasTeam;
			if (hasTeam)
			{
				num ^= this.Team.GetHashCode();
			}
			bool hasPlayerclass = this.HasPlayerclass;
			if (hasPlayerclass)
			{
				num ^= this.Playerclass.GetHashCode();
			}
			bool hasActorPortraitSno = this.HasActorPortraitSno;
			if (hasActorPortraitSno)
			{
				num ^= this.ActorPortraitSno.GetHashCode();
			}
			bool hasCurrentLevel = this.HasCurrentLevel;
			if (hasCurrentLevel)
			{
				num ^= this.CurrentLevel.GetHashCode();
			}
			bool flag2 = this.heroStateData_ != null;
			if (flag2)
			{
				num ^= this.HeroStateData.GetHashCode();
			}
			bool hasJustJoined = this.HasJustJoined;
			if (hasJustJoined)
			{
				num ^= this.JustJoined.GetHashCode();
			}
			bool hasAnn = this.HasAnn;
			if (hasAnn)
			{
				num ^= this.Ann.GetHashCode();
			}
			bool hasAccountName = this.HasAccountName;
			if (hasAccountName)
			{
				num ^= this.AccountName.GetHashCode();
			}
			bool hasShapeshiftForm = this.HasShapeshiftForm;
			if (hasShapeshiftForm)
			{
				num ^= this.ShapeshiftForm.GetHashCode();
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				num ^= this.SessionId.GetHashCode();
			}
			bool hasPrivateProfile = this.HasPrivateProfile;
			if (hasPrivateProfile)
			{
				num ^= this.PrivateProfile.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002B1D RID: 11037 RVA: 0x000A9370 File Offset: 0x000A7570
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002B1E RID: 11038 RVA: 0x000A9388 File Offset: 0x000A7588
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x000A9394 File Offset: 0x000A7594
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.HeroId);
			}
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				output.WriteRawTag(18);
				output.WriteString(this.PartyId);
			}
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.AccountId);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.GameAccountId);
			}
			bool flag = this.platformAccount_ != null;
			if (flag)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.PlatformAccount);
			}
			bool hasHeroName = this.HasHeroName;
			if (hasHeroName)
			{
				output.WriteRawTag(50);
				output.WriteString(this.HeroName);
			}
			bool hasTeam = this.HasTeam;
			if (hasTeam)
			{
				output.WriteRawTag(56);
				output.WriteSInt32(this.Team);
			}
			bool hasPlayerclass = this.HasPlayerclass;
			if (hasPlayerclass)
			{
				output.WriteRawTag(64);
				output.WriteSInt32(this.Playerclass);
			}
			bool hasActorPortraitSno = this.HasActorPortraitSno;
			if (hasActorPortraitSno)
			{
				output.WriteRawTag(77);
				output.WriteSFixed32(this.ActorPortraitSno);
			}
			bool hasCurrentLevel = this.HasCurrentLevel;
			if (hasCurrentLevel)
			{
				output.WriteRawTag(80);
				output.WriteSInt32(this.CurrentLevel);
			}
			bool flag2 = this.heroStateData_ != null;
			if (flag2)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.HeroStateData);
			}
			bool hasJustJoined = this.HasJustJoined;
			if (hasJustJoined)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.JustJoined);
			}
			bool hasAnn = this.HasAnn;
			if (hasAnn)
			{
				output.WriteRawTag(109);
				output.WriteSFixed32(this.Ann);
			}
			bool hasAccountName = this.HasAccountName;
			if (hasAccountName)
			{
				output.WriteRawTag(114);
				output.WriteString(this.AccountName);
			}
			bool hasShapeshiftForm = this.HasShapeshiftForm;
			if (hasShapeshiftForm)
			{
				output.WriteRawTag(120);
				output.WriteSInt32(this.ShapeshiftForm);
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				output.WriteRawTag(130, 1);
				output.WriteString(this.SessionId);
			}
			bool hasPrivateProfile = this.HasPrivateProfile;
			if (hasPrivateProfile)
			{
				output.WriteRawTag(136, 1);
				output.WriteBool(this.PrivateProfile);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002B20 RID: 11040 RVA: 0x000A962C File Offset: 0x000A782C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.HeroId);
			}
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PartyId);
			}
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AccountId);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			bool flag = this.platformAccount_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlatformAccount);
			}
			bool hasHeroName = this.HasHeroName;
			if (hasHeroName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.HeroName);
			}
			bool hasTeam = this.HasTeam;
			if (hasTeam)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.Team);
			}
			bool hasPlayerclass = this.HasPlayerclass;
			if (hasPlayerclass)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.Playerclass);
			}
			bool hasActorPortraitSno = this.HasActorPortraitSno;
			if (hasActorPortraitSno)
			{
				num += 5;
			}
			bool hasCurrentLevel = this.HasCurrentLevel;
			if (hasCurrentLevel)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.CurrentLevel);
			}
			bool flag2 = this.heroStateData_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HeroStateData);
			}
			bool hasJustJoined = this.HasJustJoined;
			if (hasJustJoined)
			{
				num += 2;
			}
			bool hasAnn = this.HasAnn;
			if (hasAnn)
			{
				num += 5;
			}
			bool hasAccountName = this.HasAccountName;
			if (hasAccountName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AccountName);
			}
			bool hasShapeshiftForm = this.HasShapeshiftForm;
			if (hasShapeshiftForm)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.ShapeshiftForm);
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.SessionId);
			}
			bool hasPrivateProfile = this.HasPrivateProfile;
			if (hasPrivateProfile)
			{
				num += 3;
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002B21 RID: 11041 RVA: 0x000A9830 File Offset: 0x000A7A30
		[DebuggerNonUserCode]
		public void MergeFrom(NewPlayerMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasHeroId = other.HasHeroId;
				if (hasHeroId)
				{
					this.HeroId = other.HeroId;
				}
				bool hasPartyId = other.HasPartyId;
				if (hasPartyId)
				{
					this.PartyId = other.PartyId;
				}
				bool hasAccountId = other.HasAccountId;
				if (hasAccountId)
				{
					this.AccountId = other.AccountId;
				}
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				bool flag2 = other.platformAccount_ != null;
				if (flag2)
				{
					bool flag3 = this.platformAccount_ == null;
					if (flag3)
					{
						this.PlatformAccount = new PlatformAccount();
					}
					this.PlatformAccount.MergeFrom(other.PlatformAccount);
				}
				bool hasHeroName = other.HasHeroName;
				if (hasHeroName)
				{
					this.HeroName = other.HeroName;
				}
				bool hasTeam = other.HasTeam;
				if (hasTeam)
				{
					this.Team = other.Team;
				}
				bool hasPlayerclass = other.HasPlayerclass;
				if (hasPlayerclass)
				{
					this.Playerclass = other.Playerclass;
				}
				bool hasActorPortraitSno = other.HasActorPortraitSno;
				if (hasActorPortraitSno)
				{
					this.ActorPortraitSno = other.ActorPortraitSno;
				}
				bool hasCurrentLevel = other.HasCurrentLevel;
				if (hasCurrentLevel)
				{
					this.CurrentLevel = other.CurrentLevel;
				}
				bool flag4 = other.heroStateData_ != null;
				if (flag4)
				{
					bool flag5 = this.heroStateData_ == null;
					if (flag5)
					{
						this.HeroStateData = new HeroStateDataDef();
					}
					this.HeroStateData.MergeFrom(other.HeroStateData);
				}
				bool hasJustJoined = other.HasJustJoined;
				if (hasJustJoined)
				{
					this.JustJoined = other.JustJoined;
				}
				bool hasAnn = other.HasAnn;
				if (hasAnn)
				{
					this.Ann = other.Ann;
				}
				bool hasAccountName = other.HasAccountName;
				if (hasAccountName)
				{
					this.AccountName = other.AccountName;
				}
				bool hasShapeshiftForm = other.HasShapeshiftForm;
				if (hasShapeshiftForm)
				{
					this.ShapeshiftForm = other.ShapeshiftForm;
				}
				bool hasSessionId = other.HasSessionId;
				if (hasSessionId)
				{
					this.SessionId = other.SessionId;
				}
				bool hasPrivateProfile = other.HasPrivateProfile;
				if (hasPrivateProfile)
				{
					this.PrivateProfile = other.PrivateProfile;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002B22 RID: 11042 RVA: 0x000A9A72 File Offset: 0x000A7C72
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002B23 RID: 11043 RVA: 0x000A9A80 File Offset: 0x000A7C80
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 64U)
				{
					if (num3 <= 32U)
					{
						if (num3 <= 18U)
						{
							if (num3 != 10U)
							{
								if (num3 != 18U)
								{
									goto IL_00E7;
								}
								this.PartyId = input.ReadString();
							}
							else
							{
								this.HeroId = input.ReadString();
							}
						}
						else if (num3 != 24U)
						{
							if (num3 != 32U)
							{
								goto IL_00E7;
							}
							this.GameAccountId = input.ReadUInt32();
						}
						else
						{
							this.AccountId = input.ReadUInt32();
						}
					}
					else if (num3 <= 50U)
					{
						if (num3 != 42U)
						{
							if (num3 != 50U)
							{
								goto IL_00E7;
							}
							this.HeroName = input.ReadString();
						}
						else
						{
							bool flag = this.platformAccount_ == null;
							if (flag)
							{
								this.PlatformAccount = new PlatformAccount();
							}
							input.ReadMessage(this.PlatformAccount);
						}
					}
					else if (num3 != 56U)
					{
						if (num3 != 64U)
						{
							goto IL_00E7;
						}
						this.Playerclass = input.ReadSInt32();
					}
					else
					{
						this.Team = input.ReadSInt32();
					}
				}
				else if (num3 <= 96U)
				{
					if (num3 <= 80U)
					{
						if (num3 != 77U)
						{
							if (num3 != 80U)
							{
								goto IL_00E7;
							}
							this.CurrentLevel = input.ReadSInt32();
						}
						else
						{
							this.ActorPortraitSno = input.ReadSFixed32();
						}
					}
					else if (num3 != 90U)
					{
						if (num3 != 96U)
						{
							goto IL_00E7;
						}
						this.JustJoined = input.ReadBool();
					}
					else
					{
						bool flag2 = this.heroStateData_ == null;
						if (flag2)
						{
							this.HeroStateData = new HeroStateDataDef();
						}
						input.ReadMessage(this.HeroStateData);
					}
				}
				else if (num3 <= 114U)
				{
					if (num3 != 109U)
					{
						if (num3 != 114U)
						{
							goto IL_00E7;
						}
						this.AccountName = input.ReadString();
					}
					else
					{
						this.Ann = input.ReadSFixed32();
					}
				}
				else if (num3 != 120U)
				{
					if (num3 != 130U)
					{
						if (num3 != 136U)
						{
							goto IL_00E7;
						}
						this.PrivateProfile = input.ReadBool();
					}
					else
					{
						this.SessionId = input.ReadString();
					}
				}
				else
				{
					this.ShapeshiftForm = input.ReadSInt32();
				}
				continue;
				IL_00E7:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001358 RID: 4952
		private static readonly MessageParser<NewPlayerMessage> _parser = new MessageParser<NewPlayerMessage>(() => new NewPlayerMessage());

		// Token: 0x04001359 RID: 4953
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400135A RID: 4954
		private int _hasBits0;

		// Token: 0x0400135B RID: 4955
		public const int HeroIdFieldNumber = 1;

		// Token: 0x0400135C RID: 4956
		private static readonly string HeroIdDefaultValue = "";

		// Token: 0x0400135D RID: 4957
		private string heroId_;

		// Token: 0x0400135E RID: 4958
		public const int PartyIdFieldNumber = 2;

		// Token: 0x0400135F RID: 4959
		private static readonly string PartyIdDefaultValue = "";

		// Token: 0x04001360 RID: 4960
		private string partyId_;

		// Token: 0x04001361 RID: 4961
		public const int AccountIdFieldNumber = 3;

		// Token: 0x04001362 RID: 4962
		private static readonly uint AccountIdDefaultValue = 0U;

		// Token: 0x04001363 RID: 4963
		private uint accountId_;

		// Token: 0x04001364 RID: 4964
		public const int GameAccountIdFieldNumber = 4;

		// Token: 0x04001365 RID: 4965
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x04001366 RID: 4966
		private uint gameAccountId_;

		// Token: 0x04001367 RID: 4967
		public const int PlatformAccountFieldNumber = 5;

		// Token: 0x04001368 RID: 4968
		private PlatformAccount platformAccount_;

		// Token: 0x04001369 RID: 4969
		public const int HeroNameFieldNumber = 6;

		// Token: 0x0400136A RID: 4970
		private static readonly string HeroNameDefaultValue = "";

		// Token: 0x0400136B RID: 4971
		private string heroName_;

		// Token: 0x0400136C RID: 4972
		public const int TeamFieldNumber = 7;

		// Token: 0x0400136D RID: 4973
		private static readonly int TeamDefaultValue = 0;

		// Token: 0x0400136E RID: 4974
		private int team_;

		// Token: 0x0400136F RID: 4975
		public const int PlayerclassFieldNumber = 8;

		// Token: 0x04001370 RID: 4976
		private static readonly int PlayerclassDefaultValue = 0;

		// Token: 0x04001371 RID: 4977
		private int playerclass_;

		// Token: 0x04001372 RID: 4978
		public const int ActorPortraitSnoFieldNumber = 9;

		// Token: 0x04001373 RID: 4979
		private static readonly int ActorPortraitSnoDefaultValue = 0;

		// Token: 0x04001374 RID: 4980
		private int actorPortraitSno_;

		// Token: 0x04001375 RID: 4981
		public const int CurrentLevelFieldNumber = 10;

		// Token: 0x04001376 RID: 4982
		private static readonly int CurrentLevelDefaultValue = 0;

		// Token: 0x04001377 RID: 4983
		private int currentLevel_;

		// Token: 0x04001378 RID: 4984
		public const int HeroStateDataFieldNumber = 11;

		// Token: 0x04001379 RID: 4985
		private HeroStateDataDef heroStateData_;

		// Token: 0x0400137A RID: 4986
		public const int JustJoinedFieldNumber = 12;

		// Token: 0x0400137B RID: 4987
		private static readonly bool JustJoinedDefaultValue = false;

		// Token: 0x0400137C RID: 4988
		private bool justJoined_;

		// Token: 0x0400137D RID: 4989
		public const int AnnFieldNumber = 13;

		// Token: 0x0400137E RID: 4990
		private static readonly int AnnDefaultValue = 0;

		// Token: 0x0400137F RID: 4991
		private int ann_;

		// Token: 0x04001380 RID: 4992
		public const int AccountNameFieldNumber = 14;

		// Token: 0x04001381 RID: 4993
		private static readonly string AccountNameDefaultValue = "";

		// Token: 0x04001382 RID: 4994
		private string accountName_;

		// Token: 0x04001383 RID: 4995
		public const int ShapeshiftFormFieldNumber = 15;

		// Token: 0x04001384 RID: 4996
		private static readonly int ShapeshiftFormDefaultValue = 0;

		// Token: 0x04001385 RID: 4997
		private int shapeshiftForm_;

		// Token: 0x04001386 RID: 4998
		public const int SessionIdFieldNumber = 16;

		// Token: 0x04001387 RID: 4999
		private static readonly string SessionIdDefaultValue = "";

		// Token: 0x04001388 RID: 5000
		private string sessionId_;

		// Token: 0x04001389 RID: 5001
		public const int PrivateProfileFieldNumber = 17;

		// Token: 0x0400138A RID: 5002
		private static readonly bool PrivateProfileDefaultValue = false;

		// Token: 0x0400138B RID: 5003
		private bool privateProfile_;
	}
}
