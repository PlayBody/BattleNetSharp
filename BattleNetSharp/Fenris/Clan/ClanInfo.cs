using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Clan
{
	// Token: 0x020002AC RID: 684
	public sealed class ClanInfo : IMessage<ClanInfo>, IMessage, IEquatable<ClanInfo>, IDeepCloneable<ClanInfo>, IBufferMessage
	{
		// Token: 0x170016C4 RID: 5828
		// (get) Token: 0x0600480C RID: 18444 RVA: 0x001136E0 File Offset: 0x001118E0
		[DebuggerNonUserCode]
		public static MessageParser<ClanInfo> Parser
		{
			get
			{
				return ClanInfo._parser;
			}
		}

		// Token: 0x170016C5 RID: 5829
		// (get) Token: 0x0600480D RID: 18445 RVA: 0x001136F8 File Offset: 0x001118F8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClanReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170016C6 RID: 5830
		// (get) Token: 0x0600480E RID: 18446 RVA: 0x0011371C File Offset: 0x0011191C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClanInfo.Descriptor;
			}
		}

		// Token: 0x0600480F RID: 18447 RVA: 0x00113733 File Offset: 0x00111933
		[DebuggerNonUserCode]
		public ClanInfo()
		{
		}

		// Token: 0x06004810 RID: 18448 RVA: 0x00113748 File Offset: 0x00111948
		[DebuggerNonUserCode]
		public ClanInfo(ClanInfo other)
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
			this.info_ = other.info_;
			this.lastEditedInfoBnetAccount_ = other.lastEditedInfoBnetAccount_;
			this.lastEditedInfoGameAccount_ = other.lastEditedInfoGameAccount_;
			this.label_ = other.label_.Clone();
			this.motd_ = other.motd_;
			this.lastEditedMotdBnetAccount_ = other.lastEditedMotdBnetAccount_;
			this.lastEditedMotdGameAccount_ = other.lastEditedMotdGameAccount_;
			this.permissions_ = ((other.permissions_ != null) ? other.permissions_.Clone() : null);
			this.heraldry_ = ((other.heraldry_ != null) ? other.heraldry_.Clone() : null);
			this.lastEditedHeraldryBnetAccount_ = other.lastEditedHeraldryBnetAccount_;
			this.lastEditedHeraldryGameAccount_ = other.lastEditedHeraldryGameAccount_;
			this.createdAt_ = other.createdAt_;
			this.bgsClubId_ = other.bgsClubId_;
			this.isPrivate_ = other.isPrivate_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004811 RID: 18449 RVA: 0x001138C0 File Offset: 0x00111AC0
		[DebuggerNonUserCode]
		public ClanInfo Clone()
		{
			return new ClanInfo(this);
		}

		// Token: 0x170016C7 RID: 5831
		// (get) Token: 0x06004812 RID: 18450 RVA: 0x001138D8 File Offset: 0x00111AD8
		// (set) Token: 0x06004813 RID: 18451 RVA: 0x001138F9 File Offset: 0x00111AF9
		[DebuggerNonUserCode]
		public string ClanId
		{
			get
			{
				return this.clanId_ ?? ClanInfo.ClanIdDefaultValue;
			}
			set
			{
				this.clanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170016C8 RID: 5832
		// (get) Token: 0x06004814 RID: 18452 RVA: 0x00113910 File Offset: 0x00111B10
		[DebuggerNonUserCode]
		public bool HasClanId
		{
			get
			{
				return this.clanId_ != null;
			}
		}

		// Token: 0x06004815 RID: 18453 RVA: 0x0011392B File Offset: 0x00111B2B
		[DebuggerNonUserCode]
		public void ClearClanId()
		{
			this.clanId_ = null;
		}

		// Token: 0x170016C9 RID: 5833
		// (get) Token: 0x06004816 RID: 18454 RVA: 0x00113938 File Offset: 0x00111B38
		// (set) Token: 0x06004817 RID: 18455 RVA: 0x00113959 File Offset: 0x00111B59
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? ClanInfo.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170016CA RID: 5834
		// (get) Token: 0x06004818 RID: 18456 RVA: 0x00113970 File Offset: 0x00111B70
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06004819 RID: 18457 RVA: 0x0011398B File Offset: 0x00111B8B
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x170016CB RID: 5835
		// (get) Token: 0x0600481A RID: 18458 RVA: 0x00113998 File Offset: 0x00111B98
		// (set) Token: 0x0600481B RID: 18459 RVA: 0x001139CD File Offset: 0x00111BCD
		[DebuggerNonUserCode]
		public uint LastEditedNameBnetAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 2048) != 0;
				uint lastEditedNameBnetAccountDefaultValue;
				if (flag)
				{
					lastEditedNameBnetAccountDefaultValue = this.lastEditedNameBnetAccount_;
				}
				else
				{
					lastEditedNameBnetAccountDefaultValue = ClanInfo.LastEditedNameBnetAccountDefaultValue;
				}
				return lastEditedNameBnetAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2048;
				this.lastEditedNameBnetAccount_ = value;
			}
		}

		// Token: 0x170016CC RID: 5836
		// (get) Token: 0x0600481C RID: 18460 RVA: 0x001139EC File Offset: 0x00111BEC
		[DebuggerNonUserCode]
		public bool HasLastEditedNameBnetAccount
		{
			get
			{
				return (this._hasBits0 & 2048) != 0;
			}
		}

		// Token: 0x0600481D RID: 18461 RVA: 0x00113A0D File Offset: 0x00111C0D
		[DebuggerNonUserCode]
		public void ClearLastEditedNameBnetAccount()
		{
			this._hasBits0 &= -2049;
		}

		// Token: 0x170016CD RID: 5837
		// (get) Token: 0x0600481E RID: 18462 RVA: 0x00113A24 File Offset: 0x00111C24
		// (set) Token: 0x0600481F RID: 18463 RVA: 0x00113A59 File Offset: 0x00111C59
		[DebuggerNonUserCode]
		public uint LastEditedNameGameAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 4096) != 0;
				uint lastEditedNameGameAccountDefaultValue;
				if (flag)
				{
					lastEditedNameGameAccountDefaultValue = this.lastEditedNameGameAccount_;
				}
				else
				{
					lastEditedNameGameAccountDefaultValue = ClanInfo.LastEditedNameGameAccountDefaultValue;
				}
				return lastEditedNameGameAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4096;
				this.lastEditedNameGameAccount_ = value;
			}
		}

		// Token: 0x170016CE RID: 5838
		// (get) Token: 0x06004820 RID: 18464 RVA: 0x00113A78 File Offset: 0x00111C78
		[DebuggerNonUserCode]
		public bool HasLastEditedNameGameAccount
		{
			get
			{
				return (this._hasBits0 & 4096) != 0;
			}
		}

		// Token: 0x06004821 RID: 18465 RVA: 0x00113A99 File Offset: 0x00111C99
		[DebuggerNonUserCode]
		public void ClearLastEditedNameGameAccount()
		{
			this._hasBits0 &= -4097;
		}

		// Token: 0x170016CF RID: 5839
		// (get) Token: 0x06004822 RID: 18466 RVA: 0x00113AB0 File Offset: 0x00111CB0
		// (set) Token: 0x06004823 RID: 18467 RVA: 0x00113AD1 File Offset: 0x00111CD1
		[DebuggerNonUserCode]
		public string Tag
		{
			get
			{
				return this.tag_ ?? ClanInfo.TagDefaultValue;
			}
			set
			{
				this.tag_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170016D0 RID: 5840
		// (get) Token: 0x06004824 RID: 18468 RVA: 0x00113AE8 File Offset: 0x00111CE8
		[DebuggerNonUserCode]
		public bool HasTag
		{
			get
			{
				return this.tag_ != null;
			}
		}

		// Token: 0x06004825 RID: 18469 RVA: 0x00113B03 File Offset: 0x00111D03
		[DebuggerNonUserCode]
		public void ClearTag()
		{
			this.tag_ = null;
		}

		// Token: 0x170016D1 RID: 5841
		// (get) Token: 0x06004826 RID: 18470 RVA: 0x00113B10 File Offset: 0x00111D10
		// (set) Token: 0x06004827 RID: 18471 RVA: 0x00113B45 File Offset: 0x00111D45
		[DebuggerNonUserCode]
		public uint LastEditedTagBnetAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 8192) != 0;
				uint lastEditedTagBnetAccountDefaultValue;
				if (flag)
				{
					lastEditedTagBnetAccountDefaultValue = this.lastEditedTagBnetAccount_;
				}
				else
				{
					lastEditedTagBnetAccountDefaultValue = ClanInfo.LastEditedTagBnetAccountDefaultValue;
				}
				return lastEditedTagBnetAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8192;
				this.lastEditedTagBnetAccount_ = value;
			}
		}

		// Token: 0x170016D2 RID: 5842
		// (get) Token: 0x06004828 RID: 18472 RVA: 0x00113B64 File Offset: 0x00111D64
		[DebuggerNonUserCode]
		public bool HasLastEditedTagBnetAccount
		{
			get
			{
				return (this._hasBits0 & 8192) != 0;
			}
		}

		// Token: 0x06004829 RID: 18473 RVA: 0x00113B85 File Offset: 0x00111D85
		[DebuggerNonUserCode]
		public void ClearLastEditedTagBnetAccount()
		{
			this._hasBits0 &= -8193;
		}

		// Token: 0x170016D3 RID: 5843
		// (get) Token: 0x0600482A RID: 18474 RVA: 0x00113B9C File Offset: 0x00111D9C
		// (set) Token: 0x0600482B RID: 18475 RVA: 0x00113BD1 File Offset: 0x00111DD1
		[DebuggerNonUserCode]
		public uint LastEditedTagGameAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 16384) != 0;
				uint lastEditedTagGameAccountDefaultValue;
				if (flag)
				{
					lastEditedTagGameAccountDefaultValue = this.lastEditedTagGameAccount_;
				}
				else
				{
					lastEditedTagGameAccountDefaultValue = ClanInfo.LastEditedTagGameAccountDefaultValue;
				}
				return lastEditedTagGameAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16384;
				this.lastEditedTagGameAccount_ = value;
			}
		}

		// Token: 0x170016D4 RID: 5844
		// (get) Token: 0x0600482C RID: 18476 RVA: 0x00113BF0 File Offset: 0x00111DF0
		[DebuggerNonUserCode]
		public bool HasLastEditedTagGameAccount
		{
			get
			{
				return (this._hasBits0 & 16384) != 0;
			}
		}

		// Token: 0x0600482D RID: 18477 RVA: 0x00113C11 File Offset: 0x00111E11
		[DebuggerNonUserCode]
		public void ClearLastEditedTagGameAccount()
		{
			this._hasBits0 &= -16385;
		}

		// Token: 0x170016D5 RID: 5845
		// (get) Token: 0x0600482E RID: 18478 RVA: 0x00113C28 File Offset: 0x00111E28
		// (set) Token: 0x0600482F RID: 18479 RVA: 0x00113C49 File Offset: 0x00111E49
		[DebuggerNonUserCode]
		public string Description
		{
			get
			{
				return this.description_ ?? ClanInfo.DescriptionDefaultValue;
			}
			set
			{
				this.description_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170016D6 RID: 5846
		// (get) Token: 0x06004830 RID: 18480 RVA: 0x00113C60 File Offset: 0x00111E60
		[DebuggerNonUserCode]
		public bool HasDescription
		{
			get
			{
				return this.description_ != null;
			}
		}

		// Token: 0x06004831 RID: 18481 RVA: 0x00113C7B File Offset: 0x00111E7B
		[DebuggerNonUserCode]
		public void ClearDescription()
		{
			this.description_ = null;
		}

		// Token: 0x170016D7 RID: 5847
		// (get) Token: 0x06004832 RID: 18482 RVA: 0x00113C88 File Offset: 0x00111E88
		// (set) Token: 0x06004833 RID: 18483 RVA: 0x00113CBD File Offset: 0x00111EBD
		[DebuggerNonUserCode]
		public uint LastEditedDescriptionBnetAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				uint lastEditedDescriptionBnetAccountDefaultValue;
				if (flag)
				{
					lastEditedDescriptionBnetAccountDefaultValue = this.lastEditedDescriptionBnetAccount_;
				}
				else
				{
					lastEditedDescriptionBnetAccountDefaultValue = ClanInfo.LastEditedDescriptionBnetAccountDefaultValue;
				}
				return lastEditedDescriptionBnetAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.lastEditedDescriptionBnetAccount_ = value;
			}
		}

		// Token: 0x170016D8 RID: 5848
		// (get) Token: 0x06004834 RID: 18484 RVA: 0x00113CDC File Offset: 0x00111EDC
		[DebuggerNonUserCode]
		public bool HasLastEditedDescriptionBnetAccount
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x06004835 RID: 18485 RVA: 0x00113CFD File Offset: 0x00111EFD
		[DebuggerNonUserCode]
		public void ClearLastEditedDescriptionBnetAccount()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x170016D9 RID: 5849
		// (get) Token: 0x06004836 RID: 18486 RVA: 0x00113D14 File Offset: 0x00111F14
		// (set) Token: 0x06004837 RID: 18487 RVA: 0x00113D49 File Offset: 0x00111F49
		[DebuggerNonUserCode]
		public uint LastEditedDescriptionGameAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 1024) != 0;
				uint lastEditedDescriptionGameAccountDefaultValue;
				if (flag)
				{
					lastEditedDescriptionGameAccountDefaultValue = this.lastEditedDescriptionGameAccount_;
				}
				else
				{
					lastEditedDescriptionGameAccountDefaultValue = ClanInfo.LastEditedDescriptionGameAccountDefaultValue;
				}
				return lastEditedDescriptionGameAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1024;
				this.lastEditedDescriptionGameAccount_ = value;
			}
		}

		// Token: 0x170016DA RID: 5850
		// (get) Token: 0x06004838 RID: 18488 RVA: 0x00113D68 File Offset: 0x00111F68
		[DebuggerNonUserCode]
		public bool HasLastEditedDescriptionGameAccount
		{
			get
			{
				return (this._hasBits0 & 1024) != 0;
			}
		}

		// Token: 0x06004839 RID: 18489 RVA: 0x00113D89 File Offset: 0x00111F89
		[DebuggerNonUserCode]
		public void ClearLastEditedDescriptionGameAccount()
		{
			this._hasBits0 &= -1025;
		}

		// Token: 0x170016DB RID: 5851
		// (get) Token: 0x0600483A RID: 18490 RVA: 0x00113DA0 File Offset: 0x00111FA0
		// (set) Token: 0x0600483B RID: 18491 RVA: 0x00113DC1 File Offset: 0x00111FC1
		[DebuggerNonUserCode]
		public string Info
		{
			get
			{
				return this.info_ ?? ClanInfo.InfoDefaultValue;
			}
			set
			{
				this.info_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170016DC RID: 5852
		// (get) Token: 0x0600483C RID: 18492 RVA: 0x00113DD8 File Offset: 0x00111FD8
		[DebuggerNonUserCode]
		public bool HasInfo
		{
			get
			{
				return this.info_ != null;
			}
		}

		// Token: 0x0600483D RID: 18493 RVA: 0x00113DF3 File Offset: 0x00111FF3
		[DebuggerNonUserCode]
		public void ClearInfo()
		{
			this.info_ = null;
		}

		// Token: 0x170016DD RID: 5853
		// (get) Token: 0x0600483E RID: 18494 RVA: 0x00113E00 File Offset: 0x00112000
		// (set) Token: 0x0600483F RID: 18495 RVA: 0x00113E32 File Offset: 0x00112032
		[DebuggerNonUserCode]
		public uint LastEditedInfoBnetAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				uint lastEditedInfoBnetAccountDefaultValue;
				if (flag)
				{
					lastEditedInfoBnetAccountDefaultValue = this.lastEditedInfoBnetAccount_;
				}
				else
				{
					lastEditedInfoBnetAccountDefaultValue = ClanInfo.LastEditedInfoBnetAccountDefaultValue;
				}
				return lastEditedInfoBnetAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.lastEditedInfoBnetAccount_ = value;
			}
		}

		// Token: 0x170016DE RID: 5854
		// (get) Token: 0x06004840 RID: 18496 RVA: 0x00113E4C File Offset: 0x0011204C
		[DebuggerNonUserCode]
		public bool HasLastEditedInfoBnetAccount
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06004841 RID: 18497 RVA: 0x00113E6A File Offset: 0x0011206A
		[DebuggerNonUserCode]
		public void ClearLastEditedInfoBnetAccount()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x170016DF RID: 5855
		// (get) Token: 0x06004842 RID: 18498 RVA: 0x00113E7C File Offset: 0x0011207C
		// (set) Token: 0x06004843 RID: 18499 RVA: 0x00113EAE File Offset: 0x001120AE
		[DebuggerNonUserCode]
		public uint LastEditedInfoGameAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint lastEditedInfoGameAccountDefaultValue;
				if (flag)
				{
					lastEditedInfoGameAccountDefaultValue = this.lastEditedInfoGameAccount_;
				}
				else
				{
					lastEditedInfoGameAccountDefaultValue = ClanInfo.LastEditedInfoGameAccountDefaultValue;
				}
				return lastEditedInfoGameAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.lastEditedInfoGameAccount_ = value;
			}
		}

		// Token: 0x170016E0 RID: 5856
		// (get) Token: 0x06004844 RID: 18500 RVA: 0x00113EC8 File Offset: 0x001120C8
		[DebuggerNonUserCode]
		public bool HasLastEditedInfoGameAccount
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06004845 RID: 18501 RVA: 0x00113EE6 File Offset: 0x001120E6
		[DebuggerNonUserCode]
		public void ClearLastEditedInfoGameAccount()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x170016E1 RID: 5857
		// (get) Token: 0x06004846 RID: 18502 RVA: 0x00113EF8 File Offset: 0x001120F8
		[DebuggerNonUserCode]
		public RepeatedField<uint> Label
		{
			get
			{
				return this.label_;
			}
		}

		// Token: 0x170016E2 RID: 5858
		// (get) Token: 0x06004847 RID: 18503 RVA: 0x00113F10 File Offset: 0x00112110
		// (set) Token: 0x06004848 RID: 18504 RVA: 0x00113F31 File Offset: 0x00112131
		[DebuggerNonUserCode]
		public string Motd
		{
			get
			{
				return this.motd_ ?? ClanInfo.MotdDefaultValue;
			}
			set
			{
				this.motd_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170016E3 RID: 5859
		// (get) Token: 0x06004849 RID: 18505 RVA: 0x00113F48 File Offset: 0x00112148
		[DebuggerNonUserCode]
		public bool HasMotd
		{
			get
			{
				return this.motd_ != null;
			}
		}

		// Token: 0x0600484A RID: 18506 RVA: 0x00113F63 File Offset: 0x00112163
		[DebuggerNonUserCode]
		public void ClearMotd()
		{
			this.motd_ = null;
		}

		// Token: 0x170016E4 RID: 5860
		// (get) Token: 0x0600484B RID: 18507 RVA: 0x00113F70 File Offset: 0x00112170
		// (set) Token: 0x0600484C RID: 18508 RVA: 0x00113FA5 File Offset: 0x001121A5
		[DebuggerNonUserCode]
		public uint LastEditedMotdBnetAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				uint lastEditedMotdBnetAccountDefaultValue;
				if (flag)
				{
					lastEditedMotdBnetAccountDefaultValue = this.lastEditedMotdBnetAccount_;
				}
				else
				{
					lastEditedMotdBnetAccountDefaultValue = ClanInfo.LastEditedMotdBnetAccountDefaultValue;
				}
				return lastEditedMotdBnetAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.lastEditedMotdBnetAccount_ = value;
			}
		}

		// Token: 0x170016E5 RID: 5861
		// (get) Token: 0x0600484D RID: 18509 RVA: 0x00113FC4 File Offset: 0x001121C4
		[DebuggerNonUserCode]
		public bool HasLastEditedMotdBnetAccount
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x0600484E RID: 18510 RVA: 0x00113FE5 File Offset: 0x001121E5
		[DebuggerNonUserCode]
		public void ClearLastEditedMotdBnetAccount()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x170016E6 RID: 5862
		// (get) Token: 0x0600484F RID: 18511 RVA: 0x00113FFC File Offset: 0x001121FC
		// (set) Token: 0x06004850 RID: 18512 RVA: 0x0011402D File Offset: 0x0011222D
		[DebuggerNonUserCode]
		public uint LastEditedMotdGameAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint lastEditedMotdGameAccountDefaultValue;
				if (flag)
				{
					lastEditedMotdGameAccountDefaultValue = this.lastEditedMotdGameAccount_;
				}
				else
				{
					lastEditedMotdGameAccountDefaultValue = ClanInfo.LastEditedMotdGameAccountDefaultValue;
				}
				return lastEditedMotdGameAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.lastEditedMotdGameAccount_ = value;
			}
		}

		// Token: 0x170016E7 RID: 5863
		// (get) Token: 0x06004851 RID: 18513 RVA: 0x00114048 File Offset: 0x00112248
		[DebuggerNonUserCode]
		public bool HasLastEditedMotdGameAccount
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06004852 RID: 18514 RVA: 0x00114065 File Offset: 0x00112265
		[DebuggerNonUserCode]
		public void ClearLastEditedMotdGameAccount()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x170016E8 RID: 5864
		// (get) Token: 0x06004853 RID: 18515 RVA: 0x00114078 File Offset: 0x00112278
		// (set) Token: 0x06004854 RID: 18516 RVA: 0x00114090 File Offset: 0x00112290
		[DebuggerNonUserCode]
		public ClanPermissions Permissions
		{
			get
			{
				return this.permissions_;
			}
			set
			{
				this.permissions_ = value;
			}
		}

		// Token: 0x170016E9 RID: 5865
		// (get) Token: 0x06004855 RID: 18517 RVA: 0x0011409C File Offset: 0x0011229C
		// (set) Token: 0x06004856 RID: 18518 RVA: 0x001140B4 File Offset: 0x001122B4
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

		// Token: 0x170016EA RID: 5866
		// (get) Token: 0x06004857 RID: 18519 RVA: 0x001140C0 File Offset: 0x001122C0
		// (set) Token: 0x06004858 RID: 18520 RVA: 0x001140F5 File Offset: 0x001122F5
		[DebuggerNonUserCode]
		public uint LastEditedHeraldryBnetAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				uint lastEditedHeraldryBnetAccountDefaultValue;
				if (flag)
				{
					lastEditedHeraldryBnetAccountDefaultValue = this.lastEditedHeraldryBnetAccount_;
				}
				else
				{
					lastEditedHeraldryBnetAccountDefaultValue = ClanInfo.LastEditedHeraldryBnetAccountDefaultValue;
				}
				return lastEditedHeraldryBnetAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.lastEditedHeraldryBnetAccount_ = value;
			}
		}

		// Token: 0x170016EB RID: 5867
		// (get) Token: 0x06004859 RID: 18521 RVA: 0x00114114 File Offset: 0x00112314
		[DebuggerNonUserCode]
		public bool HasLastEditedHeraldryBnetAccount
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x0600485A RID: 18522 RVA: 0x00114135 File Offset: 0x00112335
		[DebuggerNonUserCode]
		public void ClearLastEditedHeraldryBnetAccount()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x170016EC RID: 5868
		// (get) Token: 0x0600485B RID: 18523 RVA: 0x0011414C File Offset: 0x0011234C
		// (set) Token: 0x0600485C RID: 18524 RVA: 0x0011417E File Offset: 0x0011237E
		[DebuggerNonUserCode]
		public uint LastEditedHeraldryGameAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				uint lastEditedHeraldryGameAccountDefaultValue;
				if (flag)
				{
					lastEditedHeraldryGameAccountDefaultValue = this.lastEditedHeraldryGameAccount_;
				}
				else
				{
					lastEditedHeraldryGameAccountDefaultValue = ClanInfo.LastEditedHeraldryGameAccountDefaultValue;
				}
				return lastEditedHeraldryGameAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.lastEditedHeraldryGameAccount_ = value;
			}
		}

		// Token: 0x170016ED RID: 5869
		// (get) Token: 0x0600485D RID: 18525 RVA: 0x00114198 File Offset: 0x00112398
		[DebuggerNonUserCode]
		public bool HasLastEditedHeraldryGameAccount
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x0600485E RID: 18526 RVA: 0x001141B6 File Offset: 0x001123B6
		[DebuggerNonUserCode]
		public void ClearLastEditedHeraldryGameAccount()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x170016EE RID: 5870
		// (get) Token: 0x0600485F RID: 18527 RVA: 0x001141C8 File Offset: 0x001123C8
		// (set) Token: 0x06004860 RID: 18528 RVA: 0x001141F9 File Offset: 0x001123F9
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
					createdAtDefaultValue = ClanInfo.CreatedAtDefaultValue;
				}
				return createdAtDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.createdAt_ = value;
			}
		}

		// Token: 0x170016EF RID: 5871
		// (get) Token: 0x06004861 RID: 18529 RVA: 0x00114214 File Offset: 0x00112414
		[DebuggerNonUserCode]
		public bool HasCreatedAt
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004862 RID: 18530 RVA: 0x00114231 File Offset: 0x00112431
		[DebuggerNonUserCode]
		public void ClearCreatedAt()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170016F0 RID: 5872
		// (get) Token: 0x06004863 RID: 18531 RVA: 0x00114244 File Offset: 0x00112444
		// (set) Token: 0x06004864 RID: 18532 RVA: 0x00114275 File Offset: 0x00112475
		[DebuggerNonUserCode]
		public ulong BgsClubId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong bgsClubIdDefaultValue;
				if (flag)
				{
					bgsClubIdDefaultValue = this.bgsClubId_;
				}
				else
				{
					bgsClubIdDefaultValue = ClanInfo.BgsClubIdDefaultValue;
				}
				return bgsClubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.bgsClubId_ = value;
			}
		}

		// Token: 0x170016F1 RID: 5873
		// (get) Token: 0x06004865 RID: 18533 RVA: 0x00114290 File Offset: 0x00112490
		[DebuggerNonUserCode]
		public bool HasBgsClubId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004866 RID: 18534 RVA: 0x001142AD File Offset: 0x001124AD
		[DebuggerNonUserCode]
		public void ClearBgsClubId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170016F2 RID: 5874
		// (get) Token: 0x06004867 RID: 18535 RVA: 0x001142C0 File Offset: 0x001124C0
		// (set) Token: 0x06004868 RID: 18536 RVA: 0x001142F1 File Offset: 0x001124F1
		[DebuggerNonUserCode]
		public bool IsPrivate
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool isPrivateDefaultValue;
				if (flag)
				{
					isPrivateDefaultValue = this.isPrivate_;
				}
				else
				{
					isPrivateDefaultValue = ClanInfo.IsPrivateDefaultValue;
				}
				return isPrivateDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.isPrivate_ = value;
			}
		}

		// Token: 0x170016F3 RID: 5875
		// (get) Token: 0x06004869 RID: 18537 RVA: 0x0011430C File Offset: 0x0011250C
		[DebuggerNonUserCode]
		public bool HasIsPrivate
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600486A RID: 18538 RVA: 0x00114329 File Offset: 0x00112529
		[DebuggerNonUserCode]
		public void ClearIsPrivate()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x0600486B RID: 18539 RVA: 0x0011433C File Offset: 0x0011253C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClanInfo);
		}

		// Token: 0x0600486C RID: 18540 RVA: 0x0011435C File Offset: 0x0011255C
		[DebuggerNonUserCode]
		public bool Equals(ClanInfo other)
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
															bool flag14 = this.Info != other.Info;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.LastEditedInfoBnetAccount != other.LastEditedInfoBnetAccount;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.LastEditedInfoGameAccount != other.LastEditedInfoGameAccount;
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
																			bool flag18 = this.Motd != other.Motd;
																			if (flag18)
																			{
																				flag2 = false;
																			}
																			else
																			{
																				bool flag19 = this.LastEditedMotdBnetAccount != other.LastEditedMotdBnetAccount;
																				if (flag19)
																				{
																					flag2 = false;
																				}
																				else
																				{
																					bool flag20 = this.LastEditedMotdGameAccount != other.LastEditedMotdGameAccount;
																					if (flag20)
																					{
																						flag2 = false;
																					}
																					else
																					{
																						bool flag21 = !object.Equals(this.Permissions, other.Permissions);
																						if (flag21)
																						{
																							flag2 = false;
																						}
																						else
																						{
																							bool flag22 = !object.Equals(this.Heraldry, other.Heraldry);
																							if (flag22)
																							{
																								flag2 = false;
																							}
																							else
																							{
																								bool flag23 = this.LastEditedHeraldryBnetAccount != other.LastEditedHeraldryBnetAccount;
																								if (flag23)
																								{
																									flag2 = false;
																								}
																								else
																								{
																									bool flag24 = this.LastEditedHeraldryGameAccount != other.LastEditedHeraldryGameAccount;
																									if (flag24)
																									{
																										flag2 = false;
																									}
																									else
																									{
																										bool flag25 = this.CreatedAt != other.CreatedAt;
																										if (flag25)
																										{
																											flag2 = false;
																										}
																										else
																										{
																											bool flag26 = this.BgsClubId != other.BgsClubId;
																											if (flag26)
																											{
																												flag2 = false;
																											}
																											else
																											{
																												bool flag27 = this.IsPrivate != other.IsPrivate;
																												flag2 = !flag27 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x0600486D RID: 18541 RVA: 0x0011466C File Offset: 0x0011286C
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
			bool hasInfo = this.HasInfo;
			if (hasInfo)
			{
				num ^= this.Info.GetHashCode();
			}
			bool hasLastEditedInfoBnetAccount = this.HasLastEditedInfoBnetAccount;
			if (hasLastEditedInfoBnetAccount)
			{
				num ^= this.LastEditedInfoBnetAccount.GetHashCode();
			}
			bool hasLastEditedInfoGameAccount = this.HasLastEditedInfoGameAccount;
			if (hasLastEditedInfoGameAccount)
			{
				num ^= this.LastEditedInfoGameAccount.GetHashCode();
			}
			num ^= this.label_.GetHashCode();
			bool hasMotd = this.HasMotd;
			if (hasMotd)
			{
				num ^= this.Motd.GetHashCode();
			}
			bool hasLastEditedMotdBnetAccount = this.HasLastEditedMotdBnetAccount;
			if (hasLastEditedMotdBnetAccount)
			{
				num ^= this.LastEditedMotdBnetAccount.GetHashCode();
			}
			bool hasLastEditedMotdGameAccount = this.HasLastEditedMotdGameAccount;
			if (hasLastEditedMotdGameAccount)
			{
				num ^= this.LastEditedMotdGameAccount.GetHashCode();
			}
			bool flag = this.permissions_ != null;
			if (flag)
			{
				num ^= this.Permissions.GetHashCode();
			}
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
			bool hasCreatedAt = this.HasCreatedAt;
			if (hasCreatedAt)
			{
				num ^= this.CreatedAt.GetHashCode();
			}
			bool hasBgsClubId = this.HasBgsClubId;
			if (hasBgsClubId)
			{
				num ^= this.BgsClubId.GetHashCode();
			}
			bool hasIsPrivate = this.HasIsPrivate;
			if (hasIsPrivate)
			{
				num ^= this.IsPrivate.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600486E RID: 18542 RVA: 0x00114944 File Offset: 0x00112B44
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600486F RID: 18543 RVA: 0x0011495C File Offset: 0x00112B5C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004870 RID: 18544 RVA: 0x00114968 File Offset: 0x00112B68
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			bool hasTag = this.HasTag;
			if (hasTag)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Tag);
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Description);
			}
			bool hasCreatedAt = this.HasCreatedAt;
			if (hasCreatedAt)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.CreatedAt);
			}
			bool hasBgsClubId = this.HasBgsClubId;
			if (hasBgsClubId)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.BgsClubId);
			}
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				output.WriteRawTag(50);
				output.WriteString(this.ClanId);
			}
			bool hasMotd = this.HasMotd;
			if (hasMotd)
			{
				output.WriteRawTag(58);
				output.WriteString(this.Motd);
			}
			bool hasInfo = this.HasInfo;
			if (hasInfo)
			{
				output.WriteRawTag(66);
				output.WriteString(this.Info);
			}
			this.label_.WriteTo(ref output, ClanInfo._repeated_label_codec);
			bool hasIsPrivate = this.HasIsPrivate;
			if (hasIsPrivate)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsPrivate);
			}
			bool hasLastEditedMotdGameAccount = this.HasLastEditedMotdGameAccount;
			if (hasLastEditedMotdGameAccount)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.LastEditedMotdGameAccount);
			}
			bool flag = this.heraldry_ != null;
			if (flag)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Heraldry);
			}
			bool hasLastEditedInfoGameAccount = this.HasLastEditedInfoGameAccount;
			if (hasLastEditedInfoGameAccount)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.LastEditedInfoGameAccount);
			}
			bool flag2 = this.permissions_ != null;
			if (flag2)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Permissions);
			}
			bool hasLastEditedHeraldryGameAccount = this.HasLastEditedHeraldryGameAccount;
			if (hasLastEditedHeraldryGameAccount)
			{
				output.WriteRawTag(128, 1);
				output.WriteUInt32(this.LastEditedHeraldryGameAccount);
			}
			bool hasLastEditedInfoBnetAccount = this.HasLastEditedInfoBnetAccount;
			if (hasLastEditedInfoBnetAccount)
			{
				output.WriteRawTag(136, 1);
				output.WriteUInt32(this.LastEditedInfoBnetAccount);
			}
			bool hasLastEditedMotdBnetAccount = this.HasLastEditedMotdBnetAccount;
			if (hasLastEditedMotdBnetAccount)
			{
				output.WriteRawTag(144, 1);
				output.WriteUInt32(this.LastEditedMotdBnetAccount);
			}
			bool hasLastEditedHeraldryBnetAccount = this.HasLastEditedHeraldryBnetAccount;
			if (hasLastEditedHeraldryBnetAccount)
			{
				output.WriteRawTag(152, 1);
				output.WriteUInt32(this.LastEditedHeraldryBnetAccount);
			}
			bool hasLastEditedDescriptionBnetAccount = this.HasLastEditedDescriptionBnetAccount;
			if (hasLastEditedDescriptionBnetAccount)
			{
				output.WriteRawTag(160, 1);
				output.WriteUInt32(this.LastEditedDescriptionBnetAccount);
			}
			bool hasLastEditedDescriptionGameAccount = this.HasLastEditedDescriptionGameAccount;
			if (hasLastEditedDescriptionGameAccount)
			{
				output.WriteRawTag(168, 1);
				output.WriteUInt32(this.LastEditedDescriptionGameAccount);
			}
			bool hasLastEditedNameBnetAccount = this.HasLastEditedNameBnetAccount;
			if (hasLastEditedNameBnetAccount)
			{
				output.WriteRawTag(176, 1);
				output.WriteUInt32(this.LastEditedNameBnetAccount);
			}
			bool hasLastEditedNameGameAccount = this.HasLastEditedNameGameAccount;
			if (hasLastEditedNameGameAccount)
			{
				output.WriteRawTag(184, 1);
				output.WriteUInt32(this.LastEditedNameGameAccount);
			}
			bool hasLastEditedTagBnetAccount = this.HasLastEditedTagBnetAccount;
			if (hasLastEditedTagBnetAccount)
			{
				output.WriteRawTag(192, 1);
				output.WriteUInt32(this.LastEditedTagBnetAccount);
			}
			bool hasLastEditedTagGameAccount = this.HasLastEditedTagGameAccount;
			if (hasLastEditedTagGameAccount)
			{
				output.WriteRawTag(200, 1);
				output.WriteUInt32(this.LastEditedTagGameAccount);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004871 RID: 18545 RVA: 0x00114D08 File Offset: 0x00112F08
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
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.LastEditedNameBnetAccount);
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
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.LastEditedDescriptionBnetAccount);
			}
			bool hasLastEditedDescriptionGameAccount = this.HasLastEditedDescriptionGameAccount;
			if (hasLastEditedDescriptionGameAccount)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.LastEditedDescriptionGameAccount);
			}
			bool hasInfo = this.HasInfo;
			if (hasInfo)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Info);
			}
			bool hasLastEditedInfoBnetAccount = this.HasLastEditedInfoBnetAccount;
			if (hasLastEditedInfoBnetAccount)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.LastEditedInfoBnetAccount);
			}
			bool hasLastEditedInfoGameAccount = this.HasLastEditedInfoGameAccount;
			if (hasLastEditedInfoGameAccount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LastEditedInfoGameAccount);
			}
			num += this.label_.CalculateSize(ClanInfo._repeated_label_codec);
			bool hasMotd = this.HasMotd;
			if (hasMotd)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Motd);
			}
			bool hasLastEditedMotdBnetAccount = this.HasLastEditedMotdBnetAccount;
			if (hasLastEditedMotdBnetAccount)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.LastEditedMotdBnetAccount);
			}
			bool hasLastEditedMotdGameAccount = this.HasLastEditedMotdGameAccount;
			if (hasLastEditedMotdGameAccount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LastEditedMotdGameAccount);
			}
			bool flag = this.permissions_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Permissions);
			}
			bool flag2 = this.heraldry_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Heraldry);
			}
			bool hasLastEditedHeraldryBnetAccount = this.HasLastEditedHeraldryBnetAccount;
			if (hasLastEditedHeraldryBnetAccount)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.LastEditedHeraldryBnetAccount);
			}
			bool hasLastEditedHeraldryGameAccount = this.HasLastEditedHeraldryGameAccount;
			if (hasLastEditedHeraldryGameAccount)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.LastEditedHeraldryGameAccount);
			}
			bool hasCreatedAt = this.HasCreatedAt;
			if (hasCreatedAt)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreatedAt);
			}
			bool hasBgsClubId = this.HasBgsClubId;
			if (hasBgsClubId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.BgsClubId);
			}
			bool hasIsPrivate = this.HasIsPrivate;
			if (hasIsPrivate)
			{
				num += 2;
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004872 RID: 18546 RVA: 0x00114FF8 File Offset: 0x001131F8
		[DebuggerNonUserCode]
		public void MergeFrom(ClanInfo other)
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
				bool hasInfo = other.HasInfo;
				if (hasInfo)
				{
					this.Info = other.Info;
				}
				bool hasLastEditedInfoBnetAccount = other.HasLastEditedInfoBnetAccount;
				if (hasLastEditedInfoBnetAccount)
				{
					this.LastEditedInfoBnetAccount = other.LastEditedInfoBnetAccount;
				}
				bool hasLastEditedInfoGameAccount = other.HasLastEditedInfoGameAccount;
				if (hasLastEditedInfoGameAccount)
				{
					this.LastEditedInfoGameAccount = other.LastEditedInfoGameAccount;
				}
				this.label_.Add(other.label_);
				bool hasMotd = other.HasMotd;
				if (hasMotd)
				{
					this.Motd = other.Motd;
				}
				bool hasLastEditedMotdBnetAccount = other.HasLastEditedMotdBnetAccount;
				if (hasLastEditedMotdBnetAccount)
				{
					this.LastEditedMotdBnetAccount = other.LastEditedMotdBnetAccount;
				}
				bool hasLastEditedMotdGameAccount = other.HasLastEditedMotdGameAccount;
				if (hasLastEditedMotdGameAccount)
				{
					this.LastEditedMotdGameAccount = other.LastEditedMotdGameAccount;
				}
				bool flag2 = other.permissions_ != null;
				if (flag2)
				{
					bool flag3 = this.permissions_ == null;
					if (flag3)
					{
						this.Permissions = new ClanPermissions();
					}
					this.Permissions.MergeFrom(other.Permissions);
				}
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
				bool hasCreatedAt = other.HasCreatedAt;
				if (hasCreatedAt)
				{
					this.CreatedAt = other.CreatedAt;
				}
				bool hasBgsClubId = other.HasBgsClubId;
				if (hasBgsClubId)
				{
					this.BgsClubId = other.BgsClubId;
				}
				bool hasIsPrivate = other.HasIsPrivate;
				if (hasIsPrivate)
				{
					this.IsPrivate = other.IsPrivate;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004873 RID: 18547 RVA: 0x001152EE File Offset: 0x001134EE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004874 RID: 18548 RVA: 0x001152FC File Offset: 0x001134FC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 96U)
				{
					if (num3 <= 50U)
					{
						if (num3 <= 26U)
						{
							if (num3 != 10U)
							{
								if (num3 != 18U)
								{
									if (num3 != 26U)
									{
										goto IL_0166;
									}
									this.Description = input.ReadString();
								}
								else
								{
									this.Tag = input.ReadString();
								}
							}
							else
							{
								this.Name = input.ReadString();
							}
						}
						else if (num3 != 32U)
						{
							if (num3 != 40U)
							{
								if (num3 != 50U)
								{
									goto IL_0166;
								}
								this.ClanId = input.ReadString();
							}
							else
							{
								this.BgsClubId = input.ReadUInt64();
							}
						}
						else
						{
							this.CreatedAt = input.ReadUInt64();
						}
					}
					else
					{
						if (num3 <= 80U)
						{
							if (num3 == 58U)
							{
								this.Motd = input.ReadString();
								continue;
							}
							if (num3 == 66U)
							{
								this.Info = input.ReadString();
								continue;
							}
							if (num3 != 80U)
							{
								goto IL_0166;
							}
						}
						else if (num3 != 82U)
						{
							if (num3 == 88U)
							{
								this.IsPrivate = input.ReadBool();
								continue;
							}
							if (num3 != 96U)
							{
								goto IL_0166;
							}
							this.LastEditedMotdGameAccount = input.ReadUInt32();
							continue;
						}
						this.label_.AddEntriesFrom(ref input, ClanInfo._repeated_label_codec);
					}
				}
				else if (num3 <= 144U)
				{
					if (num3 <= 122U)
					{
						if (num3 != 106U)
						{
							if (num3 != 112U)
							{
								if (num3 != 122U)
								{
									goto IL_0166;
								}
								bool flag = this.permissions_ == null;
								if (flag)
								{
									this.Permissions = new ClanPermissions();
								}
								input.ReadMessage(this.Permissions);
							}
							else
							{
								this.LastEditedInfoGameAccount = input.ReadUInt32();
							}
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
					else if (num3 != 128U)
					{
						if (num3 != 136U)
						{
							if (num3 != 144U)
							{
								goto IL_0166;
							}
							this.LastEditedMotdBnetAccount = input.ReadUInt32();
						}
						else
						{
							this.LastEditedInfoBnetAccount = input.ReadUInt32();
						}
					}
					else
					{
						this.LastEditedHeraldryGameAccount = input.ReadUInt32();
					}
				}
				else if (num3 <= 168U)
				{
					if (num3 != 152U)
					{
						if (num3 != 160U)
						{
							if (num3 != 168U)
							{
								goto IL_0166;
							}
							this.LastEditedDescriptionGameAccount = input.ReadUInt32();
						}
						else
						{
							this.LastEditedDescriptionBnetAccount = input.ReadUInt32();
						}
					}
					else
					{
						this.LastEditedHeraldryBnetAccount = input.ReadUInt32();
					}
				}
				else if (num3 <= 184U)
				{
					if (num3 != 176U)
					{
						if (num3 != 184U)
						{
							goto IL_0166;
						}
						this.LastEditedNameGameAccount = input.ReadUInt32();
					}
					else
					{
						this.LastEditedNameBnetAccount = input.ReadUInt32();
					}
				}
				else if (num3 != 192U)
				{
					if (num3 != 200U)
					{
						goto IL_0166;
					}
					this.LastEditedTagGameAccount = input.ReadUInt32();
				}
				else
				{
					this.LastEditedTagBnetAccount = input.ReadUInt32();
				}
				continue;
				IL_0166:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001FF3 RID: 8179
		private static readonly MessageParser<ClanInfo> _parser = new MessageParser<ClanInfo>(() => new ClanInfo());

		// Token: 0x04001FF4 RID: 8180
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FF5 RID: 8181
		private int _hasBits0;

		// Token: 0x04001FF6 RID: 8182
		public const int ClanIdFieldNumber = 6;

		// Token: 0x04001FF7 RID: 8183
		private static readonly string ClanIdDefaultValue = "";

		// Token: 0x04001FF8 RID: 8184
		private string clanId_;

		// Token: 0x04001FF9 RID: 8185
		public const int NameFieldNumber = 1;

		// Token: 0x04001FFA RID: 8186
		private static readonly string NameDefaultValue = "";

		// Token: 0x04001FFB RID: 8187
		private string name_;

		// Token: 0x04001FFC RID: 8188
		public const int LastEditedNameBnetAccountFieldNumber = 22;

		// Token: 0x04001FFD RID: 8189
		private static readonly uint LastEditedNameBnetAccountDefaultValue = 0U;

		// Token: 0x04001FFE RID: 8190
		private uint lastEditedNameBnetAccount_;

		// Token: 0x04001FFF RID: 8191
		public const int LastEditedNameGameAccountFieldNumber = 23;

		// Token: 0x04002000 RID: 8192
		private static readonly uint LastEditedNameGameAccountDefaultValue = 0U;

		// Token: 0x04002001 RID: 8193
		private uint lastEditedNameGameAccount_;

		// Token: 0x04002002 RID: 8194
		public const int TagFieldNumber = 2;

		// Token: 0x04002003 RID: 8195
		private static readonly string TagDefaultValue = "";

		// Token: 0x04002004 RID: 8196
		private string tag_;

		// Token: 0x04002005 RID: 8197
		public const int LastEditedTagBnetAccountFieldNumber = 24;

		// Token: 0x04002006 RID: 8198
		private static readonly uint LastEditedTagBnetAccountDefaultValue = 0U;

		// Token: 0x04002007 RID: 8199
		private uint lastEditedTagBnetAccount_;

		// Token: 0x04002008 RID: 8200
		public const int LastEditedTagGameAccountFieldNumber = 25;

		// Token: 0x04002009 RID: 8201
		private static readonly uint LastEditedTagGameAccountDefaultValue = 0U;

		// Token: 0x0400200A RID: 8202
		private uint lastEditedTagGameAccount_;

		// Token: 0x0400200B RID: 8203
		public const int DescriptionFieldNumber = 3;

		// Token: 0x0400200C RID: 8204
		private static readonly string DescriptionDefaultValue = "";

		// Token: 0x0400200D RID: 8205
		private string description_;

		// Token: 0x0400200E RID: 8206
		public const int LastEditedDescriptionBnetAccountFieldNumber = 20;

		// Token: 0x0400200F RID: 8207
		private static readonly uint LastEditedDescriptionBnetAccountDefaultValue = 0U;

		// Token: 0x04002010 RID: 8208
		private uint lastEditedDescriptionBnetAccount_;

		// Token: 0x04002011 RID: 8209
		public const int LastEditedDescriptionGameAccountFieldNumber = 21;

		// Token: 0x04002012 RID: 8210
		private static readonly uint LastEditedDescriptionGameAccountDefaultValue = 0U;

		// Token: 0x04002013 RID: 8211
		private uint lastEditedDescriptionGameAccount_;

		// Token: 0x04002014 RID: 8212
		public const int InfoFieldNumber = 8;

		// Token: 0x04002015 RID: 8213
		private static readonly string InfoDefaultValue = "";

		// Token: 0x04002016 RID: 8214
		private string info_;

		// Token: 0x04002017 RID: 8215
		public const int LastEditedInfoBnetAccountFieldNumber = 17;

		// Token: 0x04002018 RID: 8216
		private static readonly uint LastEditedInfoBnetAccountDefaultValue = 0U;

		// Token: 0x04002019 RID: 8217
		private uint lastEditedInfoBnetAccount_;

		// Token: 0x0400201A RID: 8218
		public const int LastEditedInfoGameAccountFieldNumber = 14;

		// Token: 0x0400201B RID: 8219
		private static readonly uint LastEditedInfoGameAccountDefaultValue = 0U;

		// Token: 0x0400201C RID: 8220
		private uint lastEditedInfoGameAccount_;

		// Token: 0x0400201D RID: 8221
		public const int LabelFieldNumber = 10;

		// Token: 0x0400201E RID: 8222
		private static readonly FieldCodec<uint> _repeated_label_codec = FieldCodec.ForUInt32(80U);

		// Token: 0x0400201F RID: 8223
		private readonly RepeatedField<uint> label_ = new RepeatedField<uint>();

		// Token: 0x04002020 RID: 8224
		public const int MotdFieldNumber = 7;

		// Token: 0x04002021 RID: 8225
		private static readonly string MotdDefaultValue = "";

		// Token: 0x04002022 RID: 8226
		private string motd_;

		// Token: 0x04002023 RID: 8227
		public const int LastEditedMotdBnetAccountFieldNumber = 18;

		// Token: 0x04002024 RID: 8228
		private static readonly uint LastEditedMotdBnetAccountDefaultValue = 0U;

		// Token: 0x04002025 RID: 8229
		private uint lastEditedMotdBnetAccount_;

		// Token: 0x04002026 RID: 8230
		public const int LastEditedMotdGameAccountFieldNumber = 12;

		// Token: 0x04002027 RID: 8231
		private static readonly uint LastEditedMotdGameAccountDefaultValue = 0U;

		// Token: 0x04002028 RID: 8232
		private uint lastEditedMotdGameAccount_;

		// Token: 0x04002029 RID: 8233
		public const int PermissionsFieldNumber = 15;

		// Token: 0x0400202A RID: 8234
		private ClanPermissions permissions_;

		// Token: 0x0400202B RID: 8235
		public const int HeraldryFieldNumber = 13;

		// Token: 0x0400202C RID: 8236
		private ClanHeraldry heraldry_;

		// Token: 0x0400202D RID: 8237
		public const int LastEditedHeraldryBnetAccountFieldNumber = 19;

		// Token: 0x0400202E RID: 8238
		private static readonly uint LastEditedHeraldryBnetAccountDefaultValue = 0U;

		// Token: 0x0400202F RID: 8239
		private uint lastEditedHeraldryBnetAccount_;

		// Token: 0x04002030 RID: 8240
		public const int LastEditedHeraldryGameAccountFieldNumber = 16;

		// Token: 0x04002031 RID: 8241
		private static readonly uint LastEditedHeraldryGameAccountDefaultValue = 0U;

		// Token: 0x04002032 RID: 8242
		private uint lastEditedHeraldryGameAccount_;

		// Token: 0x04002033 RID: 8243
		public const int CreatedAtFieldNumber = 4;

		// Token: 0x04002034 RID: 8244
		private static readonly ulong CreatedAtDefaultValue = 0UL;

		// Token: 0x04002035 RID: 8245
		private ulong createdAt_;

		// Token: 0x04002036 RID: 8246
		public const int BgsClubIdFieldNumber = 5;

		// Token: 0x04002037 RID: 8247
		private static readonly ulong BgsClubIdDefaultValue = 0UL;

		// Token: 0x04002038 RID: 8248
		private ulong bgsClubId_;

		// Token: 0x04002039 RID: 8249
		public const int IsPrivateFieldNumber = 11;

		// Token: 0x0400203A RID: 8250
		private static readonly bool IsPrivateDefaultValue = false;

		// Token: 0x0400203B RID: 8251
		private bool isPrivate_;
	}
}
