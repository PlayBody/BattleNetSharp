using System;
using System.Diagnostics;
using Fenris.Online;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Clan
{
	// Token: 0x020002B2 RID: 690
	public sealed class ClanProfile : IMessage<ClanProfile>, IMessage, IEquatable<ClanProfile>, IDeepCloneable<ClanProfile>, IBufferMessage
	{
		// Token: 0x1700173A RID: 5946
		// (get) Token: 0x06004935 RID: 18741 RVA: 0x00118704 File Offset: 0x00116904
		[DebuggerNonUserCode]
		public static MessageParser<ClanProfile> Parser
		{
			get
			{
				return ClanProfile._parser;
			}
		}

		// Token: 0x1700173B RID: 5947
		// (get) Token: 0x06004936 RID: 18742 RVA: 0x0011871C File Offset: 0x0011691C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClanReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x1700173C RID: 5948
		// (get) Token: 0x06004937 RID: 18743 RVA: 0x00118740 File Offset: 0x00116940
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClanProfile.Descriptor;
			}
		}

		// Token: 0x06004938 RID: 18744 RVA: 0x00118757 File Offset: 0x00116957
		[DebuggerNonUserCode]
		public ClanProfile()
		{
		}

		// Token: 0x06004939 RID: 18745 RVA: 0x0011876C File Offset: 0x0011696C
		[DebuggerNonUserCode]
		public ClanProfile(ClanProfile other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clanId_ = other.clanId_;
			this.name_ = other.name_;
			this.lastEditedNameBnetAccount_ = other.lastEditedNameBnetAccount_;
			this.lastEditedNameGameAccount_ = other.lastEditedNameGameAccount_;
			this.tag_ = other.tag_;
			this.lastEditedTagBnetAccount_ = other.lastEditedTagBnetAccount_;
			this.lastEditedTagGameAccount_ = other.lastEditedTagGameAccount_;
			this.description_ = other.description_;
			this.lastEditedDescriptionBnetAccount_ = other.lastEditedDescriptionBnetAccount_;
			this.lastEditedDescriptionGameAccount_ = other.lastEditedDescriptionGameAccount_;
			this.createdAt_ = other.createdAt_;
			this.leader_ = ((other.leader_ != null) ? other.leader_.Clone() : null);
			this.memberCount_ = other.memberCount_;
			this.label_ = other.label_.Clone();
			this.heraldry_ = ((other.heraldry_ != null) ? other.heraldry_.Clone() : null);
			this.lastEditedHeraldryBnetAccount_ = other.lastEditedHeraldryBnetAccount_;
			this.lastEditedHeraldryGameAccount_ = other.lastEditedHeraldryGameAccount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600493A RID: 18746 RVA: 0x00118890 File Offset: 0x00116A90
		[DebuggerNonUserCode]
		public ClanProfile Clone()
		{
			return new ClanProfile(this);
		}

		// Token: 0x1700173D RID: 5949
		// (get) Token: 0x0600493B RID: 18747 RVA: 0x001188A8 File Offset: 0x00116AA8
		// (set) Token: 0x0600493C RID: 18748 RVA: 0x001188C9 File Offset: 0x00116AC9
		[DebuggerNonUserCode]
		public string ClanId
		{
			get
			{
				return this.clanId_ ?? ClanProfile.ClanIdDefaultValue;
			}
			set
			{
				this.clanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700173E RID: 5950
		// (get) Token: 0x0600493D RID: 18749 RVA: 0x001188E0 File Offset: 0x00116AE0
		[DebuggerNonUserCode]
		public bool HasClanId
		{
			get
			{
				return this.clanId_ != null;
			}
		}

		// Token: 0x0600493E RID: 18750 RVA: 0x001188FB File Offset: 0x00116AFB
		[DebuggerNonUserCode]
		public void ClearClanId()
		{
			this.clanId_ = null;
		}

		// Token: 0x1700173F RID: 5951
		// (get) Token: 0x0600493F RID: 18751 RVA: 0x00118908 File Offset: 0x00116B08
		// (set) Token: 0x06004940 RID: 18752 RVA: 0x00118929 File Offset: 0x00116B29
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? ClanProfile.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001740 RID: 5952
		// (get) Token: 0x06004941 RID: 18753 RVA: 0x00118940 File Offset: 0x00116B40
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06004942 RID: 18754 RVA: 0x0011895B File Offset: 0x00116B5B
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x17001741 RID: 5953
		// (get) Token: 0x06004943 RID: 18755 RVA: 0x00118968 File Offset: 0x00116B68
		// (set) Token: 0x06004944 RID: 18756 RVA: 0x0011899A File Offset: 0x00116B9A
		[DebuggerNonUserCode]
		public uint LastEditedNameBnetAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				uint lastEditedNameBnetAccountDefaultValue;
				if (flag)
				{
					lastEditedNameBnetAccountDefaultValue = this.lastEditedNameBnetAccount_;
				}
				else
				{
					lastEditedNameBnetAccountDefaultValue = ClanProfile.LastEditedNameBnetAccountDefaultValue;
				}
				return lastEditedNameBnetAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.lastEditedNameBnetAccount_ = value;
			}
		}

		// Token: 0x17001742 RID: 5954
		// (get) Token: 0x06004945 RID: 18757 RVA: 0x001189B4 File Offset: 0x00116BB4
		[DebuggerNonUserCode]
		public bool HasLastEditedNameBnetAccount
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06004946 RID: 18758 RVA: 0x001189D2 File Offset: 0x00116BD2
		[DebuggerNonUserCode]
		public void ClearLastEditedNameBnetAccount()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x17001743 RID: 5955
		// (get) Token: 0x06004947 RID: 18759 RVA: 0x001189E4 File Offset: 0x00116BE4
		// (set) Token: 0x06004948 RID: 18760 RVA: 0x00118A19 File Offset: 0x00116C19
		[DebuggerNonUserCode]
		public uint LastEditedNameGameAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				uint lastEditedNameGameAccountDefaultValue;
				if (flag)
				{
					lastEditedNameGameAccountDefaultValue = this.lastEditedNameGameAccount_;
				}
				else
				{
					lastEditedNameGameAccountDefaultValue = ClanProfile.LastEditedNameGameAccountDefaultValue;
				}
				return lastEditedNameGameAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.lastEditedNameGameAccount_ = value;
			}
		}

		// Token: 0x17001744 RID: 5956
		// (get) Token: 0x06004949 RID: 18761 RVA: 0x00118A38 File Offset: 0x00116C38
		[DebuggerNonUserCode]
		public bool HasLastEditedNameGameAccount
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x0600494A RID: 18762 RVA: 0x00118A59 File Offset: 0x00116C59
		[DebuggerNonUserCode]
		public void ClearLastEditedNameGameAccount()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x17001745 RID: 5957
		// (get) Token: 0x0600494B RID: 18763 RVA: 0x00118A70 File Offset: 0x00116C70
		// (set) Token: 0x0600494C RID: 18764 RVA: 0x00118A91 File Offset: 0x00116C91
		[DebuggerNonUserCode]
		public string Tag
		{
			get
			{
				return this.tag_ ?? ClanProfile.TagDefaultValue;
			}
			set
			{
				this.tag_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001746 RID: 5958
		// (get) Token: 0x0600494D RID: 18765 RVA: 0x00118AA8 File Offset: 0x00116CA8
		[DebuggerNonUserCode]
		public bool HasTag
		{
			get
			{
				return this.tag_ != null;
			}
		}

		// Token: 0x0600494E RID: 18766 RVA: 0x00118AC3 File Offset: 0x00116CC3
		[DebuggerNonUserCode]
		public void ClearTag()
		{
			this.tag_ = null;
		}

		// Token: 0x17001747 RID: 5959
		// (get) Token: 0x0600494F RID: 18767 RVA: 0x00118AD0 File Offset: 0x00116CD0
		// (set) Token: 0x06004950 RID: 18768 RVA: 0x00118B05 File Offset: 0x00116D05
		[DebuggerNonUserCode]
		public uint LastEditedTagBnetAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				uint lastEditedTagBnetAccountDefaultValue;
				if (flag)
				{
					lastEditedTagBnetAccountDefaultValue = this.lastEditedTagBnetAccount_;
				}
				else
				{
					lastEditedTagBnetAccountDefaultValue = ClanProfile.LastEditedTagBnetAccountDefaultValue;
				}
				return lastEditedTagBnetAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.lastEditedTagBnetAccount_ = value;
			}
		}

		// Token: 0x17001748 RID: 5960
		// (get) Token: 0x06004951 RID: 18769 RVA: 0x00118B24 File Offset: 0x00116D24
		[DebuggerNonUserCode]
		public bool HasLastEditedTagBnetAccount
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x06004952 RID: 18770 RVA: 0x00118B45 File Offset: 0x00116D45
		[DebuggerNonUserCode]
		public void ClearLastEditedTagBnetAccount()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x17001749 RID: 5961
		// (get) Token: 0x06004953 RID: 18771 RVA: 0x00118B5C File Offset: 0x00116D5C
		// (set) Token: 0x06004954 RID: 18772 RVA: 0x00118B91 File Offset: 0x00116D91
		[DebuggerNonUserCode]
		public uint LastEditedTagGameAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				uint lastEditedTagGameAccountDefaultValue;
				if (flag)
				{
					lastEditedTagGameAccountDefaultValue = this.lastEditedTagGameAccount_;
				}
				else
				{
					lastEditedTagGameAccountDefaultValue = ClanProfile.LastEditedTagGameAccountDefaultValue;
				}
				return lastEditedTagGameAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.lastEditedTagGameAccount_ = value;
			}
		}

		// Token: 0x1700174A RID: 5962
		// (get) Token: 0x06004955 RID: 18773 RVA: 0x00118BB0 File Offset: 0x00116DB0
		[DebuggerNonUserCode]
		public bool HasLastEditedTagGameAccount
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x06004956 RID: 18774 RVA: 0x00118BD1 File Offset: 0x00116DD1
		[DebuggerNonUserCode]
		public void ClearLastEditedTagGameAccount()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x1700174B RID: 5963
		// (get) Token: 0x06004957 RID: 18775 RVA: 0x00118BE8 File Offset: 0x00116DE8
		// (set) Token: 0x06004958 RID: 18776 RVA: 0x00118C09 File Offset: 0x00116E09
		[DebuggerNonUserCode]
		public string Description
		{
			get
			{
				return this.description_ ?? ClanProfile.DescriptionDefaultValue;
			}
			set
			{
				this.description_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700174C RID: 5964
		// (get) Token: 0x06004959 RID: 18777 RVA: 0x00118C20 File Offset: 0x00116E20
		[DebuggerNonUserCode]
		public bool HasDescription
		{
			get
			{
				return this.description_ != null;
			}
		}

		// Token: 0x0600495A RID: 18778 RVA: 0x00118C3B File Offset: 0x00116E3B
		[DebuggerNonUserCode]
		public void ClearDescription()
		{
			this.description_ = null;
		}

		// Token: 0x1700174D RID: 5965
		// (get) Token: 0x0600495B RID: 18779 RVA: 0x00118C48 File Offset: 0x00116E48
		// (set) Token: 0x0600495C RID: 18780 RVA: 0x00118C7A File Offset: 0x00116E7A
		[DebuggerNonUserCode]
		public uint LastEditedDescriptionBnetAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint lastEditedDescriptionBnetAccountDefaultValue;
				if (flag)
				{
					lastEditedDescriptionBnetAccountDefaultValue = this.lastEditedDescriptionBnetAccount_;
				}
				else
				{
					lastEditedDescriptionBnetAccountDefaultValue = ClanProfile.LastEditedDescriptionBnetAccountDefaultValue;
				}
				return lastEditedDescriptionBnetAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.lastEditedDescriptionBnetAccount_ = value;
			}
		}

		// Token: 0x1700174E RID: 5966
		// (get) Token: 0x0600495D RID: 18781 RVA: 0x00118C94 File Offset: 0x00116E94
		[DebuggerNonUserCode]
		public bool HasLastEditedDescriptionBnetAccount
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600495E RID: 18782 RVA: 0x00118CB2 File Offset: 0x00116EB2
		[DebuggerNonUserCode]
		public void ClearLastEditedDescriptionBnetAccount()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x1700174F RID: 5967
		// (get) Token: 0x0600495F RID: 18783 RVA: 0x00118CC4 File Offset: 0x00116EC4
		// (set) Token: 0x06004960 RID: 18784 RVA: 0x00118CF6 File Offset: 0x00116EF6
		[DebuggerNonUserCode]
		public uint LastEditedDescriptionGameAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				uint lastEditedDescriptionGameAccountDefaultValue;
				if (flag)
				{
					lastEditedDescriptionGameAccountDefaultValue = this.lastEditedDescriptionGameAccount_;
				}
				else
				{
					lastEditedDescriptionGameAccountDefaultValue = ClanProfile.LastEditedDescriptionGameAccountDefaultValue;
				}
				return lastEditedDescriptionGameAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.lastEditedDescriptionGameAccount_ = value;
			}
		}

		// Token: 0x17001750 RID: 5968
		// (get) Token: 0x06004961 RID: 18785 RVA: 0x00118D10 File Offset: 0x00116F10
		[DebuggerNonUserCode]
		public bool HasLastEditedDescriptionGameAccount
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06004962 RID: 18786 RVA: 0x00118D2E File Offset: 0x00116F2E
		[DebuggerNonUserCode]
		public void ClearLastEditedDescriptionGameAccount()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17001751 RID: 5969
		// (get) Token: 0x06004963 RID: 18787 RVA: 0x00118D40 File Offset: 0x00116F40
		// (set) Token: 0x06004964 RID: 18788 RVA: 0x00118D71 File Offset: 0x00116F71
		[DebuggerNonUserCode]
		public ulong CreatedAt
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong createdAtDefaultValue;
				if (flag)
				{
					createdAtDefaultValue = this.createdAt_;
				}
				else
				{
					createdAtDefaultValue = ClanProfile.CreatedAtDefaultValue;
				}
				return createdAtDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.createdAt_ = value;
			}
		}

		// Token: 0x17001752 RID: 5970
		// (get) Token: 0x06004965 RID: 18789 RVA: 0x00118D8C File Offset: 0x00116F8C
		[DebuggerNonUserCode]
		public bool HasCreatedAt
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004966 RID: 18790 RVA: 0x00118DA9 File Offset: 0x00116FA9
		[DebuggerNonUserCode]
		public void ClearCreatedAt()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001753 RID: 5971
		// (get) Token: 0x06004967 RID: 18791 RVA: 0x00118DBC File Offset: 0x00116FBC
		// (set) Token: 0x06004968 RID: 18792 RVA: 0x00118DD4 File Offset: 0x00116FD4
		[DebuggerNonUserCode]
		public ClanProfile.Types.Member Leader
		{
			get
			{
				return this.leader_;
			}
			set
			{
				this.leader_ = value;
			}
		}

		// Token: 0x17001754 RID: 5972
		// (get) Token: 0x06004969 RID: 18793 RVA: 0x00118DE0 File Offset: 0x00116FE0
		// (set) Token: 0x0600496A RID: 18794 RVA: 0x00118E11 File Offset: 0x00117011
		[DebuggerNonUserCode]
		public uint MemberCount
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint memberCountDefaultValue;
				if (flag)
				{
					memberCountDefaultValue = this.memberCount_;
				}
				else
				{
					memberCountDefaultValue = ClanProfile.MemberCountDefaultValue;
				}
				return memberCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.memberCount_ = value;
			}
		}

		// Token: 0x17001755 RID: 5973
		// (get) Token: 0x0600496B RID: 18795 RVA: 0x00118E2C File Offset: 0x0011702C
		[DebuggerNonUserCode]
		public bool HasMemberCount
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600496C RID: 18796 RVA: 0x00118E49 File Offset: 0x00117049
		[DebuggerNonUserCode]
		public void ClearMemberCount()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001756 RID: 5974
		// (get) Token: 0x0600496D RID: 18797 RVA: 0x00118E5C File Offset: 0x0011705C
		[DebuggerNonUserCode]
		public RepeatedField<uint> Label
		{
			get
			{
				return this.label_;
			}
		}

		// Token: 0x17001757 RID: 5975
		// (get) Token: 0x0600496E RID: 18798 RVA: 0x00118E74 File Offset: 0x00117074
		// (set) Token: 0x0600496F RID: 18799 RVA: 0x00118E8C File Offset: 0x0011708C
		[DebuggerNonUserCode]
		public ClanHeraldry Heraldry
		{
			get
			{
				return this.heraldry_;
			}
			set
			{
				this.heraldry_ = value;
			}
		}

		// Token: 0x17001758 RID: 5976
		// (get) Token: 0x06004970 RID: 18800 RVA: 0x00118E98 File Offset: 0x00117098
		// (set) Token: 0x06004971 RID: 18801 RVA: 0x00118EC9 File Offset: 0x001170C9
		[DebuggerNonUserCode]
		public uint LastEditedHeraldryBnetAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint lastEditedHeraldryBnetAccountDefaultValue;
				if (flag)
				{
					lastEditedHeraldryBnetAccountDefaultValue = this.lastEditedHeraldryBnetAccount_;
				}
				else
				{
					lastEditedHeraldryBnetAccountDefaultValue = ClanProfile.LastEditedHeraldryBnetAccountDefaultValue;
				}
				return lastEditedHeraldryBnetAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.lastEditedHeraldryBnetAccount_ = value;
			}
		}

		// Token: 0x17001759 RID: 5977
		// (get) Token: 0x06004972 RID: 18802 RVA: 0x00118EE4 File Offset: 0x001170E4
		[DebuggerNonUserCode]
		public bool HasLastEditedHeraldryBnetAccount
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06004973 RID: 18803 RVA: 0x00118F01 File Offset: 0x00117101
		[DebuggerNonUserCode]
		public void ClearLastEditedHeraldryBnetAccount()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x1700175A RID: 5978
		// (get) Token: 0x06004974 RID: 18804 RVA: 0x00118F14 File Offset: 0x00117114
		// (set) Token: 0x06004975 RID: 18805 RVA: 0x00118F45 File Offset: 0x00117145
		[DebuggerNonUserCode]
		public uint LastEditedHeraldryGameAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint lastEditedHeraldryGameAccountDefaultValue;
				if (flag)
				{
					lastEditedHeraldryGameAccountDefaultValue = this.lastEditedHeraldryGameAccount_;
				}
				else
				{
					lastEditedHeraldryGameAccountDefaultValue = ClanProfile.LastEditedHeraldryGameAccountDefaultValue;
				}
				return lastEditedHeraldryGameAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.lastEditedHeraldryGameAccount_ = value;
			}
		}

		// Token: 0x1700175B RID: 5979
		// (get) Token: 0x06004976 RID: 18806 RVA: 0x00118F60 File Offset: 0x00117160
		[DebuggerNonUserCode]
		public bool HasLastEditedHeraldryGameAccount
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06004977 RID: 18807 RVA: 0x00118F7D File Offset: 0x0011717D
		[DebuggerNonUserCode]
		public void ClearLastEditedHeraldryGameAccount()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06004978 RID: 18808 RVA: 0x00118F90 File Offset: 0x00117190
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClanProfile);
		}

		// Token: 0x06004979 RID: 18809 RVA: 0x00118FB0 File Offset: 0x001171B0
		[DebuggerNonUserCode]
		public bool Equals(ClanProfile other)
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
					bool flag4 = this.ClanId != other.ClanId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Name != other.Name;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.LastEditedNameBnetAccount != other.LastEditedNameBnetAccount;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.LastEditedNameGameAccount != other.LastEditedNameGameAccount;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Tag != other.Tag;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.LastEditedTagBnetAccount != other.LastEditedTagBnetAccount;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.LastEditedTagGameAccount != other.LastEditedTagGameAccount;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.Description != other.Description;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.LastEditedDescriptionBnetAccount != other.LastEditedDescriptionBnetAccount;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.LastEditedDescriptionGameAccount != other.LastEditedDescriptionGameAccount;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.CreatedAt != other.CreatedAt;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = !object.Equals(this.Leader, other.Leader);
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.MemberCount != other.MemberCount;
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = !this.label_.Equals(other.label_);
																		if (flag17)
																		{
																			flag2 = false;
																		}
																		else
																		{
																			bool flag18 = !object.Equals(this.Heraldry, other.Heraldry);
																			if (flag18)
																			{
																				flag2 = false;
																			}
																			else
																			{
																				bool flag19 = this.LastEditedHeraldryBnetAccount != other.LastEditedHeraldryBnetAccount;
																				if (flag19)
																				{
																					flag2 = false;
																				}
																				else
																				{
																					bool flag20 = this.LastEditedHeraldryGameAccount != other.LastEditedHeraldryGameAccount;
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

		// Token: 0x0600497A RID: 18810 RVA: 0x001191EC File Offset: 0x001173EC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num ^= this.ClanId.GetHashCode();
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool hasLastEditedNameBnetAccount = this.HasLastEditedNameBnetAccount;
			if (hasLastEditedNameBnetAccount)
			{
				num ^= this.LastEditedNameBnetAccount.GetHashCode();
			}
			bool hasLastEditedNameGameAccount = this.HasLastEditedNameGameAccount;
			if (hasLastEditedNameGameAccount)
			{
				num ^= this.LastEditedNameGameAccount.GetHashCode();
			}
			bool hasTag = this.HasTag;
			if (hasTag)
			{
				num ^= this.Tag.GetHashCode();
			}
			bool hasLastEditedTagBnetAccount = this.HasLastEditedTagBnetAccount;
			if (hasLastEditedTagBnetAccount)
			{
				num ^= this.LastEditedTagBnetAccount.GetHashCode();
			}
			bool hasLastEditedTagGameAccount = this.HasLastEditedTagGameAccount;
			if (hasLastEditedTagGameAccount)
			{
				num ^= this.LastEditedTagGameAccount.GetHashCode();
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				num ^= this.Description.GetHashCode();
			}
			bool hasLastEditedDescriptionBnetAccount = this.HasLastEditedDescriptionBnetAccount;
			if (hasLastEditedDescriptionBnetAccount)
			{
				num ^= this.LastEditedDescriptionBnetAccount.GetHashCode();
			}
			bool hasLastEditedDescriptionGameAccount = this.HasLastEditedDescriptionGameAccount;
			if (hasLastEditedDescriptionGameAccount)
			{
				num ^= this.LastEditedDescriptionGameAccount.GetHashCode();
			}
			bool hasCreatedAt = this.HasCreatedAt;
			if (hasCreatedAt)
			{
				num ^= this.CreatedAt.GetHashCode();
			}
			bool flag = this.leader_ != null;
			if (flag)
			{
				num ^= this.Leader.GetHashCode();
			}
			bool hasMemberCount = this.HasMemberCount;
			if (hasMemberCount)
			{
				num ^= this.MemberCount.GetHashCode();
			}
			num ^= this.label_.GetHashCode();
			bool flag2 = this.heraldry_ != null;
			if (flag2)
			{
				num ^= this.Heraldry.GetHashCode();
			}
			bool hasLastEditedHeraldryBnetAccount = this.HasLastEditedHeraldryBnetAccount;
			if (hasLastEditedHeraldryBnetAccount)
			{
				num ^= this.LastEditedHeraldryBnetAccount.GetHashCode();
			}
			bool hasLastEditedHeraldryGameAccount = this.HasLastEditedHeraldryGameAccount;
			if (hasLastEditedHeraldryGameAccount)
			{
				num ^= this.LastEditedHeraldryGameAccount.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600497B RID: 18811 RVA: 0x001193F8 File Offset: 0x001175F8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600497C RID: 18812 RVA: 0x00119410 File Offset: 0x00117610
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600497D RID: 18813 RVA: 0x0011941C File Offset: 0x0011761C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ClanId);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Name);
			}
			bool hasTag = this.HasTag;
			if (hasTag)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Tag);
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Description);
			}
			bool hasCreatedAt = this.HasCreatedAt;
			if (hasCreatedAt)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.CreatedAt);
			}
			bool flag = this.leader_ != null;
			if (flag)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Leader);
			}
			bool hasMemberCount = this.HasMemberCount;
			if (hasMemberCount)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.MemberCount);
			}
			this.label_.WriteTo(ref output, ClanProfile._repeated_label_codec);
			bool flag2 = this.heraldry_ != null;
			if (flag2)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Heraldry);
			}
			bool hasLastEditedHeraldryBnetAccount = this.HasLastEditedHeraldryBnetAccount;
			if (hasLastEditedHeraldryBnetAccount)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.LastEditedHeraldryBnetAccount);
			}
			bool hasLastEditedHeraldryGameAccount = this.HasLastEditedHeraldryGameAccount;
			if (hasLastEditedHeraldryGameAccount)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.LastEditedHeraldryGameAccount);
			}
			bool hasLastEditedDescriptionBnetAccount = this.HasLastEditedDescriptionBnetAccount;
			if (hasLastEditedDescriptionBnetAccount)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.LastEditedDescriptionBnetAccount);
			}
			bool hasLastEditedDescriptionGameAccount = this.HasLastEditedDescriptionGameAccount;
			if (hasLastEditedDescriptionGameAccount)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.LastEditedDescriptionGameAccount);
			}
			bool hasLastEditedNameBnetAccount = this.HasLastEditedNameBnetAccount;
			if (hasLastEditedNameBnetAccount)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.LastEditedNameBnetAccount);
			}
			bool hasLastEditedNameGameAccount = this.HasLastEditedNameGameAccount;
			if (hasLastEditedNameGameAccount)
			{
				output.WriteRawTag(128, 1);
				output.WriteUInt32(this.LastEditedNameGameAccount);
			}
			bool hasLastEditedTagBnetAccount = this.HasLastEditedTagBnetAccount;
			if (hasLastEditedTagBnetAccount)
			{
				output.WriteRawTag(136, 1);
				output.WriteUInt32(this.LastEditedTagBnetAccount);
			}
			bool hasLastEditedTagGameAccount = this.HasLastEditedTagGameAccount;
			if (hasLastEditedTagGameAccount)
			{
				output.WriteRawTag(144, 1);
				output.WriteUInt32(this.LastEditedTagGameAccount);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600497E RID: 18814 RVA: 0x001196A4 File Offset: 0x001178A4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClanId);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool hasLastEditedNameBnetAccount = this.HasLastEditedNameBnetAccount;
			if (hasLastEditedNameBnetAccount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LastEditedNameBnetAccount);
			}
			bool hasLastEditedNameGameAccount = this.HasLastEditedNameGameAccount;
			if (hasLastEditedNameGameAccount)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.LastEditedNameGameAccount);
			}
			bool hasTag = this.HasTag;
			if (hasTag)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Tag);
			}
			bool hasLastEditedTagBnetAccount = this.HasLastEditedTagBnetAccount;
			if (hasLastEditedTagBnetAccount)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.LastEditedTagBnetAccount);
			}
			bool hasLastEditedTagGameAccount = this.HasLastEditedTagGameAccount;
			if (hasLastEditedTagGameAccount)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.LastEditedTagGameAccount);
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Description);
			}
			bool hasLastEditedDescriptionBnetAccount = this.HasLastEditedDescriptionBnetAccount;
			if (hasLastEditedDescriptionBnetAccount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LastEditedDescriptionBnetAccount);
			}
			bool hasLastEditedDescriptionGameAccount = this.HasLastEditedDescriptionGameAccount;
			if (hasLastEditedDescriptionGameAccount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LastEditedDescriptionGameAccount);
			}
			bool hasCreatedAt = this.HasCreatedAt;
			if (hasCreatedAt)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreatedAt);
			}
			bool flag = this.leader_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Leader);
			}
			bool hasMemberCount = this.HasMemberCount;
			if (hasMemberCount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MemberCount);
			}
			num += this.label_.CalculateSize(ClanProfile._repeated_label_codec);
			bool flag2 = this.heraldry_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Heraldry);
			}
			bool hasLastEditedHeraldryBnetAccount = this.HasLastEditedHeraldryBnetAccount;
			if (hasLastEditedHeraldryBnetAccount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LastEditedHeraldryBnetAccount);
			}
			bool hasLastEditedHeraldryGameAccount = this.HasLastEditedHeraldryGameAccount;
			if (hasLastEditedHeraldryGameAccount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LastEditedHeraldryGameAccount);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600497F RID: 18815 RVA: 0x001198D0 File Offset: 0x00117AD0
		[DebuggerNonUserCode]
		public void MergeFrom(ClanProfile other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClanId = other.HasClanId;
				if (hasClanId)
				{
					this.ClanId = other.ClanId;
				}
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool hasLastEditedNameBnetAccount = other.HasLastEditedNameBnetAccount;
				if (hasLastEditedNameBnetAccount)
				{
					this.LastEditedNameBnetAccount = other.LastEditedNameBnetAccount;
				}
				bool hasLastEditedNameGameAccount = other.HasLastEditedNameGameAccount;
				if (hasLastEditedNameGameAccount)
				{
					this.LastEditedNameGameAccount = other.LastEditedNameGameAccount;
				}
				bool hasTag = other.HasTag;
				if (hasTag)
				{
					this.Tag = other.Tag;
				}
				bool hasLastEditedTagBnetAccount = other.HasLastEditedTagBnetAccount;
				if (hasLastEditedTagBnetAccount)
				{
					this.LastEditedTagBnetAccount = other.LastEditedTagBnetAccount;
				}
				bool hasLastEditedTagGameAccount = other.HasLastEditedTagGameAccount;
				if (hasLastEditedTagGameAccount)
				{
					this.LastEditedTagGameAccount = other.LastEditedTagGameAccount;
				}
				bool hasDescription = other.HasDescription;
				if (hasDescription)
				{
					this.Description = other.Description;
				}
				bool hasLastEditedDescriptionBnetAccount = other.HasLastEditedDescriptionBnetAccount;
				if (hasLastEditedDescriptionBnetAccount)
				{
					this.LastEditedDescriptionBnetAccount = other.LastEditedDescriptionBnetAccount;
				}
				bool hasLastEditedDescriptionGameAccount = other.HasLastEditedDescriptionGameAccount;
				if (hasLastEditedDescriptionGameAccount)
				{
					this.LastEditedDescriptionGameAccount = other.LastEditedDescriptionGameAccount;
				}
				bool hasCreatedAt = other.HasCreatedAt;
				if (hasCreatedAt)
				{
					this.CreatedAt = other.CreatedAt;
				}
				bool flag2 = other.leader_ != null;
				if (flag2)
				{
					bool flag3 = this.leader_ == null;
					if (flag3)
					{
						this.Leader = new ClanProfile.Types.Member();
					}
					this.Leader.MergeFrom(other.Leader);
				}
				bool hasMemberCount = other.HasMemberCount;
				if (hasMemberCount)
				{
					this.MemberCount = other.MemberCount;
				}
				this.label_.Add(other.label_);
				bool flag4 = other.heraldry_ != null;
				if (flag4)
				{
					bool flag5 = this.heraldry_ == null;
					if (flag5)
					{
						this.Heraldry = new ClanHeraldry();
					}
					this.Heraldry.MergeFrom(other.Heraldry);
				}
				bool hasLastEditedHeraldryBnetAccount = other.HasLastEditedHeraldryBnetAccount;
				if (hasLastEditedHeraldryBnetAccount)
				{
					this.LastEditedHeraldryBnetAccount = other.LastEditedHeraldryBnetAccount;
				}
				bool hasLastEditedHeraldryGameAccount = other.HasLastEditedHeraldryGameAccount;
				if (hasLastEditedHeraldryGameAccount)
				{
					this.LastEditedHeraldryGameAccount = other.LastEditedHeraldryGameAccount;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004980 RID: 18816 RVA: 0x00119B09 File Offset: 0x00117D09
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004981 RID: 18817 RVA: 0x00119B14 File Offset: 0x00117D14
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 66U)
				{
					if (num3 <= 34U)
					{
						if (num3 <= 18U)
						{
							if (num3 != 10U)
							{
								if (num3 != 18U)
								{
									goto IL_00F4;
								}
								this.Name = input.ReadString();
							}
							else
							{
								this.ClanId = input.ReadString();
							}
						}
						else if (num3 != 26U)
						{
							if (num3 != 34U)
							{
								goto IL_00F4;
							}
							this.Description = input.ReadString();
						}
						else
						{
							this.Tag = input.ReadString();
						}
					}
					else if (num3 <= 50U)
					{
						if (num3 != 40U)
						{
							if (num3 != 50U)
							{
								goto IL_00F4;
							}
							bool flag = this.leader_ == null;
							if (flag)
							{
								this.Leader = new ClanProfile.Types.Member();
							}
							input.ReadMessage(this.Leader);
						}
						else
						{
							this.CreatedAt = input.ReadUInt64();
						}
					}
					else if (num3 != 56U)
					{
						if (num3 != 64U && num3 != 66U)
						{
							goto IL_00F4;
						}
						this.label_.AddEntriesFrom(ref input, ClanProfile._repeated_label_codec);
					}
					else
					{
						this.MemberCount = input.ReadUInt32();
					}
				}
				else if (num3 <= 104U)
				{
					if (num3 <= 88U)
					{
						if (num3 != 82U)
						{
							if (num3 != 88U)
							{
								goto IL_00F4;
							}
							this.LastEditedHeraldryBnetAccount = input.ReadUInt32();
						}
						else
						{
							bool flag2 = this.heraldry_ == null;
							if (flag2)
							{
								this.Heraldry = new ClanHeraldry();
							}
							input.ReadMessage(this.Heraldry);
						}
					}
					else if (num3 != 96U)
					{
						if (num3 != 104U)
						{
							goto IL_00F4;
						}
						this.LastEditedDescriptionBnetAccount = input.ReadUInt32();
					}
					else
					{
						this.LastEditedHeraldryGameAccount = input.ReadUInt32();
					}
				}
				else if (num3 <= 120U)
				{
					if (num3 != 112U)
					{
						if (num3 != 120U)
						{
							goto IL_00F4;
						}
						this.LastEditedNameBnetAccount = input.ReadUInt32();
					}
					else
					{
						this.LastEditedDescriptionGameAccount = input.ReadUInt32();
					}
				}
				else if (num3 != 128U)
				{
					if (num3 != 136U)
					{
						if (num3 != 144U)
						{
							goto IL_00F4;
						}
						this.LastEditedTagGameAccount = input.ReadUInt32();
					}
					else
					{
						this.LastEditedTagBnetAccount = input.ReadUInt32();
					}
				}
				else
				{
					this.LastEditedNameGameAccount = input.ReadUInt32();
				}
				continue;
				IL_00F4:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040020A4 RID: 8356
		private static readonly MessageParser<ClanProfile> _parser = new MessageParser<ClanProfile>(() => new ClanProfile());

		// Token: 0x040020A5 RID: 8357
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020A6 RID: 8358
		private int _hasBits0;

		// Token: 0x040020A7 RID: 8359
		public const int ClanIdFieldNumber = 1;

		// Token: 0x040020A8 RID: 8360
		private static readonly string ClanIdDefaultValue = "";

		// Token: 0x040020A9 RID: 8361
		private string clanId_;

		// Token: 0x040020AA RID: 8362
		public const int NameFieldNumber = 2;

		// Token: 0x040020AB RID: 8363
		private static readonly string NameDefaultValue = "";

		// Token: 0x040020AC RID: 8364
		private string name_;

		// Token: 0x040020AD RID: 8365
		public const int LastEditedNameBnetAccountFieldNumber = 15;

		// Token: 0x040020AE RID: 8366
		private static readonly uint LastEditedNameBnetAccountDefaultValue = 0U;

		// Token: 0x040020AF RID: 8367
		private uint lastEditedNameBnetAccount_;

		// Token: 0x040020B0 RID: 8368
		public const int LastEditedNameGameAccountFieldNumber = 16;

		// Token: 0x040020B1 RID: 8369
		private static readonly uint LastEditedNameGameAccountDefaultValue = 0U;

		// Token: 0x040020B2 RID: 8370
		private uint lastEditedNameGameAccount_;

		// Token: 0x040020B3 RID: 8371
		public const int TagFieldNumber = 3;

		// Token: 0x040020B4 RID: 8372
		private static readonly string TagDefaultValue = "";

		// Token: 0x040020B5 RID: 8373
		private string tag_;

		// Token: 0x040020B6 RID: 8374
		public const int LastEditedTagBnetAccountFieldNumber = 17;

		// Token: 0x040020B7 RID: 8375
		private static readonly uint LastEditedTagBnetAccountDefaultValue = 0U;

		// Token: 0x040020B8 RID: 8376
		private uint lastEditedTagBnetAccount_;

		// Token: 0x040020B9 RID: 8377
		public const int LastEditedTagGameAccountFieldNumber = 18;

		// Token: 0x040020BA RID: 8378
		private static readonly uint LastEditedTagGameAccountDefaultValue = 0U;

		// Token: 0x040020BB RID: 8379
		private uint lastEditedTagGameAccount_;

		// Token: 0x040020BC RID: 8380
		public const int DescriptionFieldNumber = 4;

		// Token: 0x040020BD RID: 8381
		private static readonly string DescriptionDefaultValue = "";

		// Token: 0x040020BE RID: 8382
		private string description_;

		// Token: 0x040020BF RID: 8383
		public const int LastEditedDescriptionBnetAccountFieldNumber = 13;

		// Token: 0x040020C0 RID: 8384
		private static readonly uint LastEditedDescriptionBnetAccountDefaultValue = 0U;

		// Token: 0x040020C1 RID: 8385
		private uint lastEditedDescriptionBnetAccount_;

		// Token: 0x040020C2 RID: 8386
		public const int LastEditedDescriptionGameAccountFieldNumber = 14;

		// Token: 0x040020C3 RID: 8387
		private static readonly uint LastEditedDescriptionGameAccountDefaultValue = 0U;

		// Token: 0x040020C4 RID: 8388
		private uint lastEditedDescriptionGameAccount_;

		// Token: 0x040020C5 RID: 8389
		public const int CreatedAtFieldNumber = 5;

		// Token: 0x040020C6 RID: 8390
		private static readonly ulong CreatedAtDefaultValue = 0UL;

		// Token: 0x040020C7 RID: 8391
		private ulong createdAt_;

		// Token: 0x040020C8 RID: 8392
		public const int LeaderFieldNumber = 6;

		// Token: 0x040020C9 RID: 8393
		private ClanProfile.Types.Member leader_;

		// Token: 0x040020CA RID: 8394
		public const int MemberCountFieldNumber = 7;

		// Token: 0x040020CB RID: 8395
		private static readonly uint MemberCountDefaultValue = 0U;

		// Token: 0x040020CC RID: 8396
		private uint memberCount_;

		// Token: 0x040020CD RID: 8397
		public const int LabelFieldNumber = 8;

		// Token: 0x040020CE RID: 8398
		private static readonly FieldCodec<uint> _repeated_label_codec = FieldCodec.ForUInt32(64U);

		// Token: 0x040020CF RID: 8399
		private readonly RepeatedField<uint> label_ = new RepeatedField<uint>();

		// Token: 0x040020D0 RID: 8400
		public const int HeraldryFieldNumber = 10;

		// Token: 0x040020D1 RID: 8401
		private ClanHeraldry heraldry_;

		// Token: 0x040020D2 RID: 8402
		public const int LastEditedHeraldryBnetAccountFieldNumber = 11;

		// Token: 0x040020D3 RID: 8403
		private static readonly uint LastEditedHeraldryBnetAccountDefaultValue = 0U;

		// Token: 0x040020D4 RID: 8404
		private uint lastEditedHeraldryBnetAccount_;

		// Token: 0x040020D5 RID: 8405
		public const int LastEditedHeraldryGameAccountFieldNumber = 12;

		// Token: 0x040020D6 RID: 8406
		private static readonly uint LastEditedHeraldryGameAccountDefaultValue = 0U;

		// Token: 0x040020D7 RID: 8407
		private uint lastEditedHeraldryGameAccount_;

		// Token: 0x02000DC6 RID: 3526
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02001483 RID: 5251
			public sealed class Member : IMessage<ClanProfile.Types.Member>, IMessage, IEquatable<ClanProfile.Types.Member>, IDeepCloneable<ClanProfile.Types.Member>, IBufferMessage
			{
				// Token: 0x17003AC7 RID: 15047
				// (get) Token: 0x0600E6B8 RID: 59064 RVA: 0x004D8F3C File Offset: 0x004D713C
				[DebuggerNonUserCode]
				public static MessageParser<ClanProfile.Types.Member> Parser
				{
					get
					{
						return ClanProfile.Types.Member._parser;
					}
				}

				// Token: 0x17003AC8 RID: 15048
				// (get) Token: 0x0600E6B9 RID: 59065 RVA: 0x004D8F54 File Offset: 0x004D7154
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return ClanProfile.Descriptor.NestedTypes[0];
					}
				}

				// Token: 0x17003AC9 RID: 15049
				// (get) Token: 0x0600E6BA RID: 59066 RVA: 0x004D8F78 File Offset: 0x004D7178
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return ClanProfile.Types.Member.Descriptor;
					}
				}

				// Token: 0x0600E6BB RID: 59067 RVA: 0x004D8F8F File Offset: 0x004D718F
				[DebuggerNonUserCode]
				public Member()
				{
				}

				// Token: 0x0600E6BC RID: 59068 RVA: 0x004D8F9C File Offset: 0x004D719C
				[DebuggerNonUserCode]
				public Member(ClanProfile.Types.Member other)
					: this()
				{
					this._hasBits0 = other._hasBits0;
					this.gameAccountId_ = other.gameAccountId_;
					this.bnetAccountId_ = other.bnetAccountId_;
					this.platformAccount_ = ((other.platformAccount_ != null) ? other.platformAccount_.Clone() : null);
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E6BD RID: 59069 RVA: 0x004D9004 File Offset: 0x004D7204
				[DebuggerNonUserCode]
				public ClanProfile.Types.Member Clone()
				{
					return new ClanProfile.Types.Member(this);
				}

				// Token: 0x17003ACA RID: 15050
				// (get) Token: 0x0600E6BE RID: 59070 RVA: 0x004D901C File Offset: 0x004D721C
				// (set) Token: 0x0600E6BF RID: 59071 RVA: 0x004D904D File Offset: 0x004D724D
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
							gameAccountIdDefaultValue = ClanProfile.Types.Member.GameAccountIdDefaultValue;
						}
						return gameAccountIdDefaultValue;
					}
					set
					{
						this._hasBits0 |= 1;
						this.gameAccountId_ = value;
					}
				}

				// Token: 0x17003ACB RID: 15051
				// (get) Token: 0x0600E6C0 RID: 59072 RVA: 0x004D9068 File Offset: 0x004D7268
				[DebuggerNonUserCode]
				public bool HasGameAccountId
				{
					get
					{
						return (this._hasBits0 & 1) != 0;
					}
				}

				// Token: 0x0600E6C1 RID: 59073 RVA: 0x004D9085 File Offset: 0x004D7285
				[DebuggerNonUserCode]
				public void ClearGameAccountId()
				{
					this._hasBits0 &= -2;
				}

				// Token: 0x17003ACC RID: 15052
				// (get) Token: 0x0600E6C2 RID: 59074 RVA: 0x004D9098 File Offset: 0x004D7298
				// (set) Token: 0x0600E6C3 RID: 59075 RVA: 0x004D90C9 File Offset: 0x004D72C9
				[DebuggerNonUserCode]
				public uint BnetAccountId
				{
					get
					{
						bool flag = (this._hasBits0 & 2) != 0;
						uint bnetAccountIdDefaultValue;
						if (flag)
						{
							bnetAccountIdDefaultValue = this.bnetAccountId_;
						}
						else
						{
							bnetAccountIdDefaultValue = ClanProfile.Types.Member.BnetAccountIdDefaultValue;
						}
						return bnetAccountIdDefaultValue;
					}
					set
					{
						this._hasBits0 |= 2;
						this.bnetAccountId_ = value;
					}
				}

				// Token: 0x17003ACD RID: 15053
				// (get) Token: 0x0600E6C4 RID: 59076 RVA: 0x004D90E4 File Offset: 0x004D72E4
				[DebuggerNonUserCode]
				public bool HasBnetAccountId
				{
					get
					{
						return (this._hasBits0 & 2) != 0;
					}
				}

				// Token: 0x0600E6C5 RID: 59077 RVA: 0x004D9101 File Offset: 0x004D7301
				[DebuggerNonUserCode]
				public void ClearBnetAccountId()
				{
					this._hasBits0 &= -3;
				}

				// Token: 0x17003ACE RID: 15054
				// (get) Token: 0x0600E6C6 RID: 59078 RVA: 0x004D9114 File Offset: 0x004D7314
				// (set) Token: 0x0600E6C7 RID: 59079 RVA: 0x004D912C File Offset: 0x004D732C
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

				// Token: 0x0600E6C8 RID: 59080 RVA: 0x004D9138 File Offset: 0x004D7338
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as ClanProfile.Types.Member);
				}

				// Token: 0x0600E6C9 RID: 59081 RVA: 0x004D9158 File Offset: 0x004D7358
				[DebuggerNonUserCode]
				public bool Equals(ClanProfile.Types.Member other)
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
								bool flag5 = this.BnetAccountId != other.BnetAccountId;
								if (flag5)
								{
									flag2 = false;
								}
								else
								{
									bool flag6 = !object.Equals(this.PlatformAccount, other.PlatformAccount);
									flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
					return flag2;
				}

				// Token: 0x0600E6CA RID: 59082 RVA: 0x004D91E8 File Offset: 0x004D73E8
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					bool hasGameAccountId = this.HasGameAccountId;
					if (hasGameAccountId)
					{
						num ^= this.GameAccountId.GetHashCode();
					}
					bool hasBnetAccountId = this.HasBnetAccountId;
					if (hasBnetAccountId)
					{
						num ^= this.BnetAccountId.GetHashCode();
					}
					bool flag = this.platformAccount_ != null;
					if (flag)
					{
						num ^= this.PlatformAccount.GetHashCode();
					}
					bool flag2 = this._unknownFields != null;
					if (flag2)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E6CB RID: 59083 RVA: 0x004D9274 File Offset: 0x004D7474
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E6CC RID: 59084 RVA: 0x004D928C File Offset: 0x004D748C
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E6CD RID: 59085 RVA: 0x004D9298 File Offset: 0x004D7498
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					bool hasGameAccountId = this.HasGameAccountId;
					if (hasGameAccountId)
					{
						output.WriteRawTag(8);
						output.WriteUInt32(this.GameAccountId);
					}
					bool hasBnetAccountId = this.HasBnetAccountId;
					if (hasBnetAccountId)
					{
						output.WriteRawTag(16);
						output.WriteUInt32(this.BnetAccountId);
					}
					bool flag = this.platformAccount_ != null;
					if (flag)
					{
						output.WriteRawTag(26);
						output.WriteMessage(this.PlatformAccount);
					}
					bool flag2 = this._unknownFields != null;
					if (flag2)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E6CE RID: 59086 RVA: 0x004D932C File Offset: 0x004D752C
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					bool hasGameAccountId = this.HasGameAccountId;
					if (hasGameAccountId)
					{
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
					}
					bool hasBnetAccountId = this.HasBnetAccountId;
					if (hasBnetAccountId)
					{
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.BnetAccountId);
					}
					bool flag = this.platformAccount_ != null;
					if (flag)
					{
						num += 1 + CodedOutputStream.ComputeMessageSize(this.PlatformAccount);
					}
					bool flag2 = this._unknownFields != null;
					if (flag2)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E6CF RID: 59087 RVA: 0x004D93BC File Offset: 0x004D75BC
				[DebuggerNonUserCode]
				public void MergeFrom(ClanProfile.Types.Member other)
				{
					bool flag = other == null;
					if (!flag)
					{
						bool hasGameAccountId = other.HasGameAccountId;
						if (hasGameAccountId)
						{
							this.GameAccountId = other.GameAccountId;
						}
						bool hasBnetAccountId = other.HasBnetAccountId;
						if (hasBnetAccountId)
						{
							this.BnetAccountId = other.BnetAccountId;
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
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E6D0 RID: 59088 RVA: 0x004D945F File Offset: 0x004D765F
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E6D1 RID: 59089 RVA: 0x004D946C File Offset: 0x004D766C
				[DebuggerNonUserCode]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
					uint num;
					while ((num = input.ReadTag()) > 0U)
					{
						uint num2 = num;
						uint num3 = num2;
						if (num3 != 8U)
						{
							if (num3 != 16U)
							{
								if (num3 != 26U)
								{
									this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
							else
							{
								this.BnetAccountId = input.ReadUInt32();
							}
						}
						else
						{
							this.GameAccountId = input.ReadUInt32();
						}
					}
				}

				// Token: 0x0400A420 RID: 42016
				private static readonly MessageParser<ClanProfile.Types.Member> _parser = new MessageParser<ClanProfile.Types.Member>(() => new ClanProfile.Types.Member());

				// Token: 0x0400A421 RID: 42017
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A422 RID: 42018
				private int _hasBits0;

				// Token: 0x0400A423 RID: 42019
				public const int GameAccountIdFieldNumber = 1;

				// Token: 0x0400A424 RID: 42020
				private static readonly uint GameAccountIdDefaultValue = 0U;

				// Token: 0x0400A425 RID: 42021
				private uint gameAccountId_;

				// Token: 0x0400A426 RID: 42022
				public const int BnetAccountIdFieldNumber = 2;

				// Token: 0x0400A427 RID: 42023
				private static readonly uint BnetAccountIdDefaultValue = 0U;

				// Token: 0x0400A428 RID: 42024
				private uint bnetAccountId_;

				// Token: 0x0400A429 RID: 42025
				public const int PlatformAccountFieldNumber = 3;

				// Token: 0x0400A42A RID: 42026
				private PlatformAccount platformAccount_;
			}
		}
	}
}
