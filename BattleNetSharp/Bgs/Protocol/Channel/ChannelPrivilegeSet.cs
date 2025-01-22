using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel
{
	// Token: 0x02000655 RID: 1621
	public sealed class ChannelPrivilegeSet : IMessage<ChannelPrivilegeSet>, IMessage, IEquatable<ChannelPrivilegeSet>, IDeepCloneable<ChannelPrivilegeSet>, IBufferMessage
	{
		// Token: 0x17002EF4 RID: 12020
		// (get) Token: 0x060096A6 RID: 38566 RVA: 0x00246B54 File Offset: 0x00244D54
		[DebuggerNonUserCode]
		public static MessageParser<ChannelPrivilegeSet> Parser
		{
			get
			{
				return ChannelPrivilegeSet._parser;
			}
		}

		// Token: 0x17002EF5 RID: 12021
		// (get) Token: 0x060096A7 RID: 38567 RVA: 0x00246B6C File Offset: 0x00244D6C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelRoleSetReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002EF6 RID: 12022
		// (get) Token: 0x060096A8 RID: 38568 RVA: 0x00246B90 File Offset: 0x00244D90
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelPrivilegeSet.Descriptor;
			}
		}

		// Token: 0x060096A9 RID: 38569 RVA: 0x00246BA7 File Offset: 0x00244DA7
		[DebuggerNonUserCode]
		public ChannelPrivilegeSet()
		{
		}

		// Token: 0x060096AA RID: 38570 RVA: 0x00246BB4 File Offset: 0x00244DB4
		[DebuggerNonUserCode]
		public ChannelPrivilegeSet(ChannelPrivilegeSet other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.canInvite_ = other.canInvite_;
			this.canInviteWithReservation_ = other.canInviteWithReservation_;
			this.canRevokeOtherInvitation_ = other.canRevokeOtherInvitation_;
			this.canRevokeOwnInvitation_ = other.canRevokeOwnInvitation_;
			this.canKick_ = other.canKick_;
			this.canDissolve_ = other.canDissolve_;
			this.canSetPrivacy_ = other.canSetPrivacy_;
			this.canSendMessage_ = other.canSendMessage_;
			this.canReceiveMessage_ = other.canReceiveMessage_;
			this.canSetAttribute_ = other.canSetAttribute_;
			this.canSetOtherMemberAttribute_ = other.canSetOtherMemberAttribute_;
			this.canSetOwnMemberAttribute_ = other.canSetOwnMemberAttribute_;
			this.canEnterGame_ = other.canEnterGame_;
			this.canSuggest_ = other.canSuggest_;
			this.canApprove_ = other.canApprove_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060096AB RID: 38571 RVA: 0x00246C9C File Offset: 0x00244E9C
		[DebuggerNonUserCode]
		public ChannelPrivilegeSet Clone()
		{
			return new ChannelPrivilegeSet(this);
		}

		// Token: 0x17002EF7 RID: 12023
		// (get) Token: 0x060096AC RID: 38572 RVA: 0x00246CB4 File Offset: 0x00244EB4
		// (set) Token: 0x060096AD RID: 38573 RVA: 0x00246CE5 File Offset: 0x00244EE5
		[DebuggerNonUserCode]
		public bool CanInvite
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool canInviteDefaultValue;
				if (flag)
				{
					canInviteDefaultValue = this.canInvite_;
				}
				else
				{
					canInviteDefaultValue = ChannelPrivilegeSet.CanInviteDefaultValue;
				}
				return canInviteDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.canInvite_ = value;
			}
		}

		// Token: 0x17002EF8 RID: 12024
		// (get) Token: 0x060096AE RID: 38574 RVA: 0x00246D00 File Offset: 0x00244F00
		[DebuggerNonUserCode]
		public bool HasCanInvite
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060096AF RID: 38575 RVA: 0x00246D1D File Offset: 0x00244F1D
		[DebuggerNonUserCode]
		public void ClearCanInvite()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002EF9 RID: 12025
		// (get) Token: 0x060096B0 RID: 38576 RVA: 0x00246D30 File Offset: 0x00244F30
		// (set) Token: 0x060096B1 RID: 38577 RVA: 0x00246D61 File Offset: 0x00244F61
		[DebuggerNonUserCode]
		public bool CanInviteWithReservation
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool canInviteWithReservationDefaultValue;
				if (flag)
				{
					canInviteWithReservationDefaultValue = this.canInviteWithReservation_;
				}
				else
				{
					canInviteWithReservationDefaultValue = ChannelPrivilegeSet.CanInviteWithReservationDefaultValue;
				}
				return canInviteWithReservationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.canInviteWithReservation_ = value;
			}
		}

		// Token: 0x17002EFA RID: 12026
		// (get) Token: 0x060096B2 RID: 38578 RVA: 0x00246D7C File Offset: 0x00244F7C
		[DebuggerNonUserCode]
		public bool HasCanInviteWithReservation
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060096B3 RID: 38579 RVA: 0x00246D99 File Offset: 0x00244F99
		[DebuggerNonUserCode]
		public void ClearCanInviteWithReservation()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002EFB RID: 12027
		// (get) Token: 0x060096B4 RID: 38580 RVA: 0x00246DAC File Offset: 0x00244FAC
		// (set) Token: 0x060096B5 RID: 38581 RVA: 0x00246DDD File Offset: 0x00244FDD
		[DebuggerNonUserCode]
		public bool CanRevokeOtherInvitation
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool canRevokeOtherInvitationDefaultValue;
				if (flag)
				{
					canRevokeOtherInvitationDefaultValue = this.canRevokeOtherInvitation_;
				}
				else
				{
					canRevokeOtherInvitationDefaultValue = ChannelPrivilegeSet.CanRevokeOtherInvitationDefaultValue;
				}
				return canRevokeOtherInvitationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.canRevokeOtherInvitation_ = value;
			}
		}

		// Token: 0x17002EFC RID: 12028
		// (get) Token: 0x060096B6 RID: 38582 RVA: 0x00246DF8 File Offset: 0x00244FF8
		[DebuggerNonUserCode]
		public bool HasCanRevokeOtherInvitation
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060096B7 RID: 38583 RVA: 0x00246E15 File Offset: 0x00245015
		[DebuggerNonUserCode]
		public void ClearCanRevokeOtherInvitation()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17002EFD RID: 12029
		// (get) Token: 0x060096B8 RID: 38584 RVA: 0x00246E28 File Offset: 0x00245028
		// (set) Token: 0x060096B9 RID: 38585 RVA: 0x00246E59 File Offset: 0x00245059
		[DebuggerNonUserCode]
		public bool CanRevokeOwnInvitation
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool canRevokeOwnInvitationDefaultValue;
				if (flag)
				{
					canRevokeOwnInvitationDefaultValue = this.canRevokeOwnInvitation_;
				}
				else
				{
					canRevokeOwnInvitationDefaultValue = ChannelPrivilegeSet.CanRevokeOwnInvitationDefaultValue;
				}
				return canRevokeOwnInvitationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.canRevokeOwnInvitation_ = value;
			}
		}

		// Token: 0x17002EFE RID: 12030
		// (get) Token: 0x060096BA RID: 38586 RVA: 0x00246E74 File Offset: 0x00245074
		[DebuggerNonUserCode]
		public bool HasCanRevokeOwnInvitation
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060096BB RID: 38587 RVA: 0x00246E91 File Offset: 0x00245091
		[DebuggerNonUserCode]
		public void ClearCanRevokeOwnInvitation()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17002EFF RID: 12031
		// (get) Token: 0x060096BC RID: 38588 RVA: 0x00246EA4 File Offset: 0x002450A4
		// (set) Token: 0x060096BD RID: 38589 RVA: 0x00246ED6 File Offset: 0x002450D6
		[DebuggerNonUserCode]
		public bool CanKick
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool canKickDefaultValue;
				if (flag)
				{
					canKickDefaultValue = this.canKick_;
				}
				else
				{
					canKickDefaultValue = ChannelPrivilegeSet.CanKickDefaultValue;
				}
				return canKickDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.canKick_ = value;
			}
		}

		// Token: 0x17002F00 RID: 12032
		// (get) Token: 0x060096BE RID: 38590 RVA: 0x00246EF0 File Offset: 0x002450F0
		[DebuggerNonUserCode]
		public bool HasCanKick
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x060096BF RID: 38591 RVA: 0x00246F0E File Offset: 0x0024510E
		[DebuggerNonUserCode]
		public void ClearCanKick()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17002F01 RID: 12033
		// (get) Token: 0x060096C0 RID: 38592 RVA: 0x00246F20 File Offset: 0x00245120
		// (set) Token: 0x060096C1 RID: 38593 RVA: 0x00246F52 File Offset: 0x00245152
		[DebuggerNonUserCode]
		public bool CanDissolve
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				bool canDissolveDefaultValue;
				if (flag)
				{
					canDissolveDefaultValue = this.canDissolve_;
				}
				else
				{
					canDissolveDefaultValue = ChannelPrivilegeSet.CanDissolveDefaultValue;
				}
				return canDissolveDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.canDissolve_ = value;
			}
		}

		// Token: 0x17002F02 RID: 12034
		// (get) Token: 0x060096C2 RID: 38594 RVA: 0x00246F6C File Offset: 0x0024516C
		[DebuggerNonUserCode]
		public bool HasCanDissolve
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x060096C3 RID: 38595 RVA: 0x00246F8A File Offset: 0x0024518A
		[DebuggerNonUserCode]
		public void ClearCanDissolve()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17002F03 RID: 12035
		// (get) Token: 0x060096C4 RID: 38596 RVA: 0x00246F9C File Offset: 0x0024519C
		// (set) Token: 0x060096C5 RID: 38597 RVA: 0x00246FCE File Offset: 0x002451CE
		[DebuggerNonUserCode]
		public bool CanSetPrivacy
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				bool canSetPrivacyDefaultValue;
				if (flag)
				{
					canSetPrivacyDefaultValue = this.canSetPrivacy_;
				}
				else
				{
					canSetPrivacyDefaultValue = ChannelPrivilegeSet.CanSetPrivacyDefaultValue;
				}
				return canSetPrivacyDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.canSetPrivacy_ = value;
			}
		}

		// Token: 0x17002F04 RID: 12036
		// (get) Token: 0x060096C6 RID: 38598 RVA: 0x00246FE8 File Offset: 0x002451E8
		[DebuggerNonUserCode]
		public bool HasCanSetPrivacy
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x060096C7 RID: 38599 RVA: 0x00247006 File Offset: 0x00245206
		[DebuggerNonUserCode]
		public void ClearCanSetPrivacy()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x17002F05 RID: 12037
		// (get) Token: 0x060096C8 RID: 38600 RVA: 0x00247018 File Offset: 0x00245218
		// (set) Token: 0x060096C9 RID: 38601 RVA: 0x0024704D File Offset: 0x0024524D
		[DebuggerNonUserCode]
		public bool CanSendMessage
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				bool canSendMessageDefaultValue;
				if (flag)
				{
					canSendMessageDefaultValue = this.canSendMessage_;
				}
				else
				{
					canSendMessageDefaultValue = ChannelPrivilegeSet.CanSendMessageDefaultValue;
				}
				return canSendMessageDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.canSendMessage_ = value;
			}
		}

		// Token: 0x17002F06 RID: 12038
		// (get) Token: 0x060096CA RID: 38602 RVA: 0x0024706C File Offset: 0x0024526C
		[DebuggerNonUserCode]
		public bool HasCanSendMessage
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x060096CB RID: 38603 RVA: 0x0024708D File Offset: 0x0024528D
		[DebuggerNonUserCode]
		public void ClearCanSendMessage()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x17002F07 RID: 12039
		// (get) Token: 0x060096CC RID: 38604 RVA: 0x002470A4 File Offset: 0x002452A4
		// (set) Token: 0x060096CD RID: 38605 RVA: 0x002470D9 File Offset: 0x002452D9
		[DebuggerNonUserCode]
		public bool CanReceiveMessage
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				bool canReceiveMessageDefaultValue;
				if (flag)
				{
					canReceiveMessageDefaultValue = this.canReceiveMessage_;
				}
				else
				{
					canReceiveMessageDefaultValue = ChannelPrivilegeSet.CanReceiveMessageDefaultValue;
				}
				return canReceiveMessageDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.canReceiveMessage_ = value;
			}
		}

		// Token: 0x17002F08 RID: 12040
		// (get) Token: 0x060096CE RID: 38606 RVA: 0x002470F8 File Offset: 0x002452F8
		[DebuggerNonUserCode]
		public bool HasCanReceiveMessage
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x060096CF RID: 38607 RVA: 0x00247119 File Offset: 0x00245319
		[DebuggerNonUserCode]
		public void ClearCanReceiveMessage()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x17002F09 RID: 12041
		// (get) Token: 0x060096D0 RID: 38608 RVA: 0x00247130 File Offset: 0x00245330
		// (set) Token: 0x060096D1 RID: 38609 RVA: 0x00247165 File Offset: 0x00245365
		[DebuggerNonUserCode]
		public bool CanSetAttribute
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				bool canSetAttributeDefaultValue;
				if (flag)
				{
					canSetAttributeDefaultValue = this.canSetAttribute_;
				}
				else
				{
					canSetAttributeDefaultValue = ChannelPrivilegeSet.CanSetAttributeDefaultValue;
				}
				return canSetAttributeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.canSetAttribute_ = value;
			}
		}

		// Token: 0x17002F0A RID: 12042
		// (get) Token: 0x060096D2 RID: 38610 RVA: 0x00247184 File Offset: 0x00245384
		[DebuggerNonUserCode]
		public bool HasCanSetAttribute
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x060096D3 RID: 38611 RVA: 0x002471A5 File Offset: 0x002453A5
		[DebuggerNonUserCode]
		public void ClearCanSetAttribute()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x17002F0B RID: 12043
		// (get) Token: 0x060096D4 RID: 38612 RVA: 0x002471BC File Offset: 0x002453BC
		// (set) Token: 0x060096D5 RID: 38613 RVA: 0x002471F1 File Offset: 0x002453F1
		[DebuggerNonUserCode]
		public bool CanSetOtherMemberAttribute
		{
			get
			{
				bool flag = (this._hasBits0 & 1024) != 0;
				bool canSetOtherMemberAttributeDefaultValue;
				if (flag)
				{
					canSetOtherMemberAttributeDefaultValue = this.canSetOtherMemberAttribute_;
				}
				else
				{
					canSetOtherMemberAttributeDefaultValue = ChannelPrivilegeSet.CanSetOtherMemberAttributeDefaultValue;
				}
				return canSetOtherMemberAttributeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1024;
				this.canSetOtherMemberAttribute_ = value;
			}
		}

		// Token: 0x17002F0C RID: 12044
		// (get) Token: 0x060096D6 RID: 38614 RVA: 0x00247210 File Offset: 0x00245410
		[DebuggerNonUserCode]
		public bool HasCanSetOtherMemberAttribute
		{
			get
			{
				return (this._hasBits0 & 1024) != 0;
			}
		}

		// Token: 0x060096D7 RID: 38615 RVA: 0x00247231 File Offset: 0x00245431
		[DebuggerNonUserCode]
		public void ClearCanSetOtherMemberAttribute()
		{
			this._hasBits0 &= -1025;
		}

		// Token: 0x17002F0D RID: 12045
		// (get) Token: 0x060096D8 RID: 38616 RVA: 0x00247248 File Offset: 0x00245448
		// (set) Token: 0x060096D9 RID: 38617 RVA: 0x0024727D File Offset: 0x0024547D
		[DebuggerNonUserCode]
		public bool CanSetOwnMemberAttribute
		{
			get
			{
				bool flag = (this._hasBits0 & 2048) != 0;
				bool canSetOwnMemberAttributeDefaultValue;
				if (flag)
				{
					canSetOwnMemberAttributeDefaultValue = this.canSetOwnMemberAttribute_;
				}
				else
				{
					canSetOwnMemberAttributeDefaultValue = ChannelPrivilegeSet.CanSetOwnMemberAttributeDefaultValue;
				}
				return canSetOwnMemberAttributeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2048;
				this.canSetOwnMemberAttribute_ = value;
			}
		}

		// Token: 0x17002F0E RID: 12046
		// (get) Token: 0x060096DA RID: 38618 RVA: 0x0024729C File Offset: 0x0024549C
		[DebuggerNonUserCode]
		public bool HasCanSetOwnMemberAttribute
		{
			get
			{
				return (this._hasBits0 & 2048) != 0;
			}
		}

		// Token: 0x060096DB RID: 38619 RVA: 0x002472BD File Offset: 0x002454BD
		[DebuggerNonUserCode]
		public void ClearCanSetOwnMemberAttribute()
		{
			this._hasBits0 &= -2049;
		}

		// Token: 0x17002F0F RID: 12047
		// (get) Token: 0x060096DC RID: 38620 RVA: 0x002472D4 File Offset: 0x002454D4
		// (set) Token: 0x060096DD RID: 38621 RVA: 0x00247309 File Offset: 0x00245509
		[DebuggerNonUserCode]
		public bool CanEnterGame
		{
			get
			{
				bool flag = (this._hasBits0 & 4096) != 0;
				bool canEnterGameDefaultValue;
				if (flag)
				{
					canEnterGameDefaultValue = this.canEnterGame_;
				}
				else
				{
					canEnterGameDefaultValue = ChannelPrivilegeSet.CanEnterGameDefaultValue;
				}
				return canEnterGameDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4096;
				this.canEnterGame_ = value;
			}
		}

		// Token: 0x17002F10 RID: 12048
		// (get) Token: 0x060096DE RID: 38622 RVA: 0x00247328 File Offset: 0x00245528
		[DebuggerNonUserCode]
		public bool HasCanEnterGame
		{
			get
			{
				return (this._hasBits0 & 4096) != 0;
			}
		}

		// Token: 0x060096DF RID: 38623 RVA: 0x00247349 File Offset: 0x00245549
		[DebuggerNonUserCode]
		public void ClearCanEnterGame()
		{
			this._hasBits0 &= -4097;
		}

		// Token: 0x17002F11 RID: 12049
		// (get) Token: 0x060096E0 RID: 38624 RVA: 0x00247360 File Offset: 0x00245560
		// (set) Token: 0x060096E1 RID: 38625 RVA: 0x00247395 File Offset: 0x00245595
		[DebuggerNonUserCode]
		public bool CanSuggest
		{
			get
			{
				bool flag = (this._hasBits0 & 8192) != 0;
				bool canSuggestDefaultValue;
				if (flag)
				{
					canSuggestDefaultValue = this.canSuggest_;
				}
				else
				{
					canSuggestDefaultValue = ChannelPrivilegeSet.CanSuggestDefaultValue;
				}
				return canSuggestDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8192;
				this.canSuggest_ = value;
			}
		}

		// Token: 0x17002F12 RID: 12050
		// (get) Token: 0x060096E2 RID: 38626 RVA: 0x002473B4 File Offset: 0x002455B4
		[DebuggerNonUserCode]
		public bool HasCanSuggest
		{
			get
			{
				return (this._hasBits0 & 8192) != 0;
			}
		}

		// Token: 0x060096E3 RID: 38627 RVA: 0x002473D5 File Offset: 0x002455D5
		[DebuggerNonUserCode]
		public void ClearCanSuggest()
		{
			this._hasBits0 &= -8193;
		}

		// Token: 0x17002F13 RID: 12051
		// (get) Token: 0x060096E4 RID: 38628 RVA: 0x002473EC File Offset: 0x002455EC
		// (set) Token: 0x060096E5 RID: 38629 RVA: 0x00247421 File Offset: 0x00245621
		[DebuggerNonUserCode]
		public bool CanApprove
		{
			get
			{
				bool flag = (this._hasBits0 & 16384) != 0;
				bool canApproveDefaultValue;
				if (flag)
				{
					canApproveDefaultValue = this.canApprove_;
				}
				else
				{
					canApproveDefaultValue = ChannelPrivilegeSet.CanApproveDefaultValue;
				}
				return canApproveDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16384;
				this.canApprove_ = value;
			}
		}

		// Token: 0x17002F14 RID: 12052
		// (get) Token: 0x060096E6 RID: 38630 RVA: 0x00247440 File Offset: 0x00245640
		[DebuggerNonUserCode]
		public bool HasCanApprove
		{
			get
			{
				return (this._hasBits0 & 16384) != 0;
			}
		}

		// Token: 0x060096E7 RID: 38631 RVA: 0x00247461 File Offset: 0x00245661
		[DebuggerNonUserCode]
		public void ClearCanApprove()
		{
			this._hasBits0 &= -16385;
		}

		// Token: 0x060096E8 RID: 38632 RVA: 0x00247478 File Offset: 0x00245678
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelPrivilegeSet);
		}

		// Token: 0x060096E9 RID: 38633 RVA: 0x00247498 File Offset: 0x00245698
		[DebuggerNonUserCode]
		public bool Equals(ChannelPrivilegeSet other)
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
					bool flag4 = this.CanInvite != other.CanInvite;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.CanInviteWithReservation != other.CanInviteWithReservation;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.CanRevokeOtherInvitation != other.CanRevokeOtherInvitation;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.CanRevokeOwnInvitation != other.CanRevokeOwnInvitation;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.CanKick != other.CanKick;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.CanDissolve != other.CanDissolve;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.CanSetPrivacy != other.CanSetPrivacy;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.CanSendMessage != other.CanSendMessage;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.CanReceiveMessage != other.CanReceiveMessage;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.CanSetAttribute != other.CanSetAttribute;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.CanSetOtherMemberAttribute != other.CanSetOtherMemberAttribute;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.CanSetOwnMemberAttribute != other.CanSetOwnMemberAttribute;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.CanEnterGame != other.CanEnterGame;
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = this.CanSuggest != other.CanSuggest;
																		if (flag17)
																		{
																			flag2 = false;
																		}
																		else
																		{
																			bool flag18 = this.CanApprove != other.CanApprove;
																			flag2 = !flag18 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x060096EA RID: 38634 RVA: 0x00247690 File Offset: 0x00245890
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasCanInvite = this.HasCanInvite;
			if (hasCanInvite)
			{
				num ^= this.CanInvite.GetHashCode();
			}
			bool hasCanInviteWithReservation = this.HasCanInviteWithReservation;
			if (hasCanInviteWithReservation)
			{
				num ^= this.CanInviteWithReservation.GetHashCode();
			}
			bool hasCanRevokeOtherInvitation = this.HasCanRevokeOtherInvitation;
			if (hasCanRevokeOtherInvitation)
			{
				num ^= this.CanRevokeOtherInvitation.GetHashCode();
			}
			bool hasCanRevokeOwnInvitation = this.HasCanRevokeOwnInvitation;
			if (hasCanRevokeOwnInvitation)
			{
				num ^= this.CanRevokeOwnInvitation.GetHashCode();
			}
			bool hasCanKick = this.HasCanKick;
			if (hasCanKick)
			{
				num ^= this.CanKick.GetHashCode();
			}
			bool hasCanDissolve = this.HasCanDissolve;
			if (hasCanDissolve)
			{
				num ^= this.CanDissolve.GetHashCode();
			}
			bool hasCanSetPrivacy = this.HasCanSetPrivacy;
			if (hasCanSetPrivacy)
			{
				num ^= this.CanSetPrivacy.GetHashCode();
			}
			bool hasCanSendMessage = this.HasCanSendMessage;
			if (hasCanSendMessage)
			{
				num ^= this.CanSendMessage.GetHashCode();
			}
			bool hasCanReceiveMessage = this.HasCanReceiveMessage;
			if (hasCanReceiveMessage)
			{
				num ^= this.CanReceiveMessage.GetHashCode();
			}
			bool hasCanSetAttribute = this.HasCanSetAttribute;
			if (hasCanSetAttribute)
			{
				num ^= this.CanSetAttribute.GetHashCode();
			}
			bool hasCanSetOtherMemberAttribute = this.HasCanSetOtherMemberAttribute;
			if (hasCanSetOtherMemberAttribute)
			{
				num ^= this.CanSetOtherMemberAttribute.GetHashCode();
			}
			bool hasCanSetOwnMemberAttribute = this.HasCanSetOwnMemberAttribute;
			if (hasCanSetOwnMemberAttribute)
			{
				num ^= this.CanSetOwnMemberAttribute.GetHashCode();
			}
			bool hasCanEnterGame = this.HasCanEnterGame;
			if (hasCanEnterGame)
			{
				num ^= this.CanEnterGame.GetHashCode();
			}
			bool hasCanSuggest = this.HasCanSuggest;
			if (hasCanSuggest)
			{
				num ^= this.CanSuggest.GetHashCode();
			}
			bool hasCanApprove = this.HasCanApprove;
			if (hasCanApprove)
			{
				num ^= this.CanApprove.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060096EB RID: 38635 RVA: 0x00247878 File Offset: 0x00245A78
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060096EC RID: 38636 RVA: 0x00247890 File Offset: 0x00245A90
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060096ED RID: 38637 RVA: 0x0024789C File Offset: 0x00245A9C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasCanInvite = this.HasCanInvite;
			if (hasCanInvite)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.CanInvite);
			}
			bool hasCanInviteWithReservation = this.HasCanInviteWithReservation;
			if (hasCanInviteWithReservation)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.CanInviteWithReservation);
			}
			bool hasCanRevokeOtherInvitation = this.HasCanRevokeOtherInvitation;
			if (hasCanRevokeOtherInvitation)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.CanRevokeOtherInvitation);
			}
			bool hasCanRevokeOwnInvitation = this.HasCanRevokeOwnInvitation;
			if (hasCanRevokeOwnInvitation)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.CanRevokeOwnInvitation);
			}
			bool hasCanKick = this.HasCanKick;
			if (hasCanKick)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.CanKick);
			}
			bool hasCanDissolve = this.HasCanDissolve;
			if (hasCanDissolve)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.CanDissolve);
			}
			bool hasCanSetPrivacy = this.HasCanSetPrivacy;
			if (hasCanSetPrivacy)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.CanSetPrivacy);
			}
			bool hasCanSendMessage = this.HasCanSendMessage;
			if (hasCanSendMessage)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.CanSendMessage);
			}
			bool hasCanReceiveMessage = this.HasCanReceiveMessage;
			if (hasCanReceiveMessage)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.CanReceiveMessage);
			}
			bool hasCanSetAttribute = this.HasCanSetAttribute;
			if (hasCanSetAttribute)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.CanSetAttribute);
			}
			bool hasCanSetOtherMemberAttribute = this.HasCanSetOtherMemberAttribute;
			if (hasCanSetOtherMemberAttribute)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.CanSetOtherMemberAttribute);
			}
			bool hasCanSetOwnMemberAttribute = this.HasCanSetOwnMemberAttribute;
			if (hasCanSetOwnMemberAttribute)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.CanSetOwnMemberAttribute);
			}
			bool hasCanEnterGame = this.HasCanEnterGame;
			if (hasCanEnterGame)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.CanEnterGame);
			}
			bool hasCanSuggest = this.HasCanSuggest;
			if (hasCanSuggest)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.CanSuggest);
			}
			bool hasCanApprove = this.HasCanApprove;
			if (hasCanApprove)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.CanApprove);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060096EE RID: 38638 RVA: 0x00247ADC File Offset: 0x00245CDC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasCanInvite = this.HasCanInvite;
			if (hasCanInvite)
			{
				num += 2;
			}
			bool hasCanInviteWithReservation = this.HasCanInviteWithReservation;
			if (hasCanInviteWithReservation)
			{
				num += 2;
			}
			bool hasCanRevokeOtherInvitation = this.HasCanRevokeOtherInvitation;
			if (hasCanRevokeOtherInvitation)
			{
				num += 2;
			}
			bool hasCanRevokeOwnInvitation = this.HasCanRevokeOwnInvitation;
			if (hasCanRevokeOwnInvitation)
			{
				num += 2;
			}
			bool hasCanKick = this.HasCanKick;
			if (hasCanKick)
			{
				num += 2;
			}
			bool hasCanDissolve = this.HasCanDissolve;
			if (hasCanDissolve)
			{
				num += 2;
			}
			bool hasCanSetPrivacy = this.HasCanSetPrivacy;
			if (hasCanSetPrivacy)
			{
				num += 2;
			}
			bool hasCanSendMessage = this.HasCanSendMessage;
			if (hasCanSendMessage)
			{
				num += 2;
			}
			bool hasCanReceiveMessage = this.HasCanReceiveMessage;
			if (hasCanReceiveMessage)
			{
				num += 2;
			}
			bool hasCanSetAttribute = this.HasCanSetAttribute;
			if (hasCanSetAttribute)
			{
				num += 2;
			}
			bool hasCanSetOtherMemberAttribute = this.HasCanSetOtherMemberAttribute;
			if (hasCanSetOtherMemberAttribute)
			{
				num += 2;
			}
			bool hasCanSetOwnMemberAttribute = this.HasCanSetOwnMemberAttribute;
			if (hasCanSetOwnMemberAttribute)
			{
				num += 2;
			}
			bool hasCanEnterGame = this.HasCanEnterGame;
			if (hasCanEnterGame)
			{
				num += 2;
			}
			bool hasCanSuggest = this.HasCanSuggest;
			if (hasCanSuggest)
			{
				num += 2;
			}
			bool hasCanApprove = this.HasCanApprove;
			if (hasCanApprove)
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

		// Token: 0x060096EF RID: 38639 RVA: 0x00247C1C File Offset: 0x00245E1C
		[DebuggerNonUserCode]
		public void MergeFrom(ChannelPrivilegeSet other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasCanInvite = other.HasCanInvite;
				if (hasCanInvite)
				{
					this.CanInvite = other.CanInvite;
				}
				bool hasCanInviteWithReservation = other.HasCanInviteWithReservation;
				if (hasCanInviteWithReservation)
				{
					this.CanInviteWithReservation = other.CanInviteWithReservation;
				}
				bool hasCanRevokeOtherInvitation = other.HasCanRevokeOtherInvitation;
				if (hasCanRevokeOtherInvitation)
				{
					this.CanRevokeOtherInvitation = other.CanRevokeOtherInvitation;
				}
				bool hasCanRevokeOwnInvitation = other.HasCanRevokeOwnInvitation;
				if (hasCanRevokeOwnInvitation)
				{
					this.CanRevokeOwnInvitation = other.CanRevokeOwnInvitation;
				}
				bool hasCanKick = other.HasCanKick;
				if (hasCanKick)
				{
					this.CanKick = other.CanKick;
				}
				bool hasCanDissolve = other.HasCanDissolve;
				if (hasCanDissolve)
				{
					this.CanDissolve = other.CanDissolve;
				}
				bool hasCanSetPrivacy = other.HasCanSetPrivacy;
				if (hasCanSetPrivacy)
				{
					this.CanSetPrivacy = other.CanSetPrivacy;
				}
				bool hasCanSendMessage = other.HasCanSendMessage;
				if (hasCanSendMessage)
				{
					this.CanSendMessage = other.CanSendMessage;
				}
				bool hasCanReceiveMessage = other.HasCanReceiveMessage;
				if (hasCanReceiveMessage)
				{
					this.CanReceiveMessage = other.CanReceiveMessage;
				}
				bool hasCanSetAttribute = other.HasCanSetAttribute;
				if (hasCanSetAttribute)
				{
					this.CanSetAttribute = other.CanSetAttribute;
				}
				bool hasCanSetOtherMemberAttribute = other.HasCanSetOtherMemberAttribute;
				if (hasCanSetOtherMemberAttribute)
				{
					this.CanSetOtherMemberAttribute = other.CanSetOtherMemberAttribute;
				}
				bool hasCanSetOwnMemberAttribute = other.HasCanSetOwnMemberAttribute;
				if (hasCanSetOwnMemberAttribute)
				{
					this.CanSetOwnMemberAttribute = other.CanSetOwnMemberAttribute;
				}
				bool hasCanEnterGame = other.HasCanEnterGame;
				if (hasCanEnterGame)
				{
					this.CanEnterGame = other.CanEnterGame;
				}
				bool hasCanSuggest = other.HasCanSuggest;
				if (hasCanSuggest)
				{
					this.CanSuggest = other.CanSuggest;
				}
				bool hasCanApprove = other.HasCanApprove;
				if (hasCanApprove)
				{
					this.CanApprove = other.CanApprove;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060096F0 RID: 38640 RVA: 0x00247DDE File Offset: 0x00245FDE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060096F1 RID: 38641 RVA: 0x00247DEC File Offset: 0x00245FEC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 56U)
				{
					if (num3 <= 24U)
					{
						if (num3 != 8U)
						{
							if (num3 != 16U)
							{
								if (num3 != 24U)
								{
									goto IL_00C1;
								}
								this.CanRevokeOtherInvitation = input.ReadBool();
							}
							else
							{
								this.CanInviteWithReservation = input.ReadBool();
							}
						}
						else
						{
							this.CanInvite = input.ReadBool();
						}
					}
					else if (num3 <= 40U)
					{
						if (num3 != 32U)
						{
							if (num3 != 40U)
							{
								goto IL_00C1;
							}
							this.CanKick = input.ReadBool();
						}
						else
						{
							this.CanRevokeOwnInvitation = input.ReadBool();
						}
					}
					else if (num3 != 48U)
					{
						if (num3 != 56U)
						{
							goto IL_00C1;
						}
						this.CanSetPrivacy = input.ReadBool();
					}
					else
					{
						this.CanDissolve = input.ReadBool();
					}
				}
				else if (num3 <= 88U)
				{
					if (num3 <= 72U)
					{
						if (num3 != 64U)
						{
							if (num3 != 72U)
							{
								goto IL_00C1;
							}
							this.CanReceiveMessage = input.ReadBool();
						}
						else
						{
							this.CanSendMessage = input.ReadBool();
						}
					}
					else if (num3 != 80U)
					{
						if (num3 != 88U)
						{
							goto IL_00C1;
						}
						this.CanSetOtherMemberAttribute = input.ReadBool();
					}
					else
					{
						this.CanSetAttribute = input.ReadBool();
					}
				}
				else if (num3 <= 104U)
				{
					if (num3 != 96U)
					{
						if (num3 != 104U)
						{
							goto IL_00C1;
						}
						this.CanEnterGame = input.ReadBool();
					}
					else
					{
						this.CanSetOwnMemberAttribute = input.ReadBool();
					}
				}
				else if (num3 != 112U)
				{
					if (num3 != 120U)
					{
						goto IL_00C1;
					}
					this.CanApprove = input.ReadBool();
				}
				else
				{
					this.CanSuggest = input.ReadBool();
				}
				continue;
				IL_00C1:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040043DF RID: 17375
		private static readonly MessageParser<ChannelPrivilegeSet> _parser = new MessageParser<ChannelPrivilegeSet>(() => new ChannelPrivilegeSet());

		// Token: 0x040043E0 RID: 17376
		private UnknownFieldSet _unknownFields;

		// Token: 0x040043E1 RID: 17377
		private int _hasBits0;

		// Token: 0x040043E2 RID: 17378
		public const int CanInviteFieldNumber = 1;

		// Token: 0x040043E3 RID: 17379
		private static readonly bool CanInviteDefaultValue = false;

		// Token: 0x040043E4 RID: 17380
		private bool canInvite_;

		// Token: 0x040043E5 RID: 17381
		public const int CanInviteWithReservationFieldNumber = 2;

		// Token: 0x040043E6 RID: 17382
		private static readonly bool CanInviteWithReservationDefaultValue = false;

		// Token: 0x040043E7 RID: 17383
		private bool canInviteWithReservation_;

		// Token: 0x040043E8 RID: 17384
		public const int CanRevokeOtherInvitationFieldNumber = 3;

		// Token: 0x040043E9 RID: 17385
		private static readonly bool CanRevokeOtherInvitationDefaultValue = false;

		// Token: 0x040043EA RID: 17386
		private bool canRevokeOtherInvitation_;

		// Token: 0x040043EB RID: 17387
		public const int CanRevokeOwnInvitationFieldNumber = 4;

		// Token: 0x040043EC RID: 17388
		private static readonly bool CanRevokeOwnInvitationDefaultValue = false;

		// Token: 0x040043ED RID: 17389
		private bool canRevokeOwnInvitation_;

		// Token: 0x040043EE RID: 17390
		public const int CanKickFieldNumber = 5;

		// Token: 0x040043EF RID: 17391
		private static readonly bool CanKickDefaultValue = false;

		// Token: 0x040043F0 RID: 17392
		private bool canKick_;

		// Token: 0x040043F1 RID: 17393
		public const int CanDissolveFieldNumber = 6;

		// Token: 0x040043F2 RID: 17394
		private static readonly bool CanDissolveDefaultValue = false;

		// Token: 0x040043F3 RID: 17395
		private bool canDissolve_;

		// Token: 0x040043F4 RID: 17396
		public const int CanSetPrivacyFieldNumber = 7;

		// Token: 0x040043F5 RID: 17397
		private static readonly bool CanSetPrivacyDefaultValue = false;

		// Token: 0x040043F6 RID: 17398
		private bool canSetPrivacy_;

		// Token: 0x040043F7 RID: 17399
		public const int CanSendMessageFieldNumber = 8;

		// Token: 0x040043F8 RID: 17400
		private static readonly bool CanSendMessageDefaultValue = false;

		// Token: 0x040043F9 RID: 17401
		private bool canSendMessage_;

		// Token: 0x040043FA RID: 17402
		public const int CanReceiveMessageFieldNumber = 9;

		// Token: 0x040043FB RID: 17403
		private static readonly bool CanReceiveMessageDefaultValue = false;

		// Token: 0x040043FC RID: 17404
		private bool canReceiveMessage_;

		// Token: 0x040043FD RID: 17405
		public const int CanSetAttributeFieldNumber = 10;

		// Token: 0x040043FE RID: 17406
		private static readonly bool CanSetAttributeDefaultValue = false;

		// Token: 0x040043FF RID: 17407
		private bool canSetAttribute_;

		// Token: 0x04004400 RID: 17408
		public const int CanSetOtherMemberAttributeFieldNumber = 11;

		// Token: 0x04004401 RID: 17409
		private static readonly bool CanSetOtherMemberAttributeDefaultValue = false;

		// Token: 0x04004402 RID: 17410
		private bool canSetOtherMemberAttribute_;

		// Token: 0x04004403 RID: 17411
		public const int CanSetOwnMemberAttributeFieldNumber = 12;

		// Token: 0x04004404 RID: 17412
		private static readonly bool CanSetOwnMemberAttributeDefaultValue = false;

		// Token: 0x04004405 RID: 17413
		private bool canSetOwnMemberAttribute_;

		// Token: 0x04004406 RID: 17414
		public const int CanEnterGameFieldNumber = 13;

		// Token: 0x04004407 RID: 17415
		private static readonly bool CanEnterGameDefaultValue = false;

		// Token: 0x04004408 RID: 17416
		private bool canEnterGame_;

		// Token: 0x04004409 RID: 17417
		public const int CanSuggestFieldNumber = 14;

		// Token: 0x0400440A RID: 17418
		private static readonly bool CanSuggestDefaultValue = false;

		// Token: 0x0400440B RID: 17419
		private bool canSuggest_;

		// Token: 0x0400440C RID: 17420
		public const int CanApproveFieldNumber = 15;

		// Token: 0x0400440D RID: 17421
		private static readonly bool CanApproveDefaultValue = false;

		// Token: 0x0400440E RID: 17422
		private bool canApprove_;
	}
}
