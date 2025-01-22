using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004EF RID: 1263
	public sealed class ClubPrivilegeSet : IMessage<ClubPrivilegeSet>, IMessage, IEquatable<ClubPrivilegeSet>, IDeepCloneable<ClubPrivilegeSet>, IBufferMessage
	{
		// Token: 0x170026DA RID: 9946
		// (get) Token: 0x06007AC0 RID: 31424 RVA: 0x001DD188 File Offset: 0x001DB388
		[DebuggerNonUserCode]
		public static MessageParser<ClubPrivilegeSet> Parser
		{
			get
			{
				return ClubPrivilegeSet._parser;
			}
		}

		// Token: 0x170026DB RID: 9947
		// (get) Token: 0x06007AC1 RID: 31425 RVA: 0x001DD1A0 File Offset: 0x001DB3A0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRoleReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170026DC RID: 9948
		// (get) Token: 0x06007AC2 RID: 31426 RVA: 0x001DD1C4 File Offset: 0x001DB3C4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubPrivilegeSet.Descriptor;
			}
		}

		// Token: 0x06007AC3 RID: 31427 RVA: 0x001DD1DB File Offset: 0x001DB3DB
		[DebuggerNonUserCode]
		public ClubPrivilegeSet()
		{
		}

		// Token: 0x06007AC4 RID: 31428 RVA: 0x001DD1E8 File Offset: 0x001DB3E8
		[DebuggerNonUserCode]
		public ClubPrivilegeSet(ClubPrivilegeSet other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this._hasBits1 = other._hasBits1;
			this.canDestroy_ = other.canDestroy_;
			this.canSetAttribute_ = other.canSetAttribute_;
			this.canSetName_ = other.canSetName_;
			this.canSetDescription_ = other.canSetDescription_;
			this.canSetAvatar_ = other.canSetAvatar_;
			this.canSetBroadcast_ = other.canSetBroadcast_;
			this.canSetPrivacyLevel_ = other.canSetPrivacyLevel_;
			this.canKickMember_ = other.canKickMember_;
			this.canSetOwnMemberAttribute_ = other.canSetOwnMemberAttribute_;
			this.canSetOtherMemberAttribute_ = other.canSetOtherMemberAttribute_;
			this.canSetOwnVoiceState_ = other.canSetOwnVoiceState_;
			this.canSetOwnPresenceLevel_ = other.canSetOwnPresenceLevel_;
			this.canSetOwnWhisperLevel_ = other.canSetOwnWhisperLevel_;
			this.canSetOwnMemberNote_ = other.canSetOwnMemberNote_;
			this.canSetOtherMemberNote_ = other.canSetOtherMemberNote_;
			this.canUseVoice_ = other.canUseVoice_;
			this.canVoiceMuteMemberForAll_ = other.canVoiceMuteMemberForAll_;
			this.canGetInvitation_ = other.canGetInvitation_;
			this.canSendInvitation_ = other.canSendInvitation_;
			this.canSendGuestInvitation_ = other.canSendGuestInvitation_;
			this.canRevokeOwnInvitation_ = other.canRevokeOwnInvitation_;
			this.canRevokeOtherInvitation_ = other.canRevokeOtherInvitation_;
			this.canGetSuggestion_ = other.canGetSuggestion_;
			this.canSuggestMember_ = other.canSuggestMember_;
			this.canApproveMember_ = other.canApproveMember_;
			this.canGetTicket_ = other.canGetTicket_;
			this.canCreateTicket_ = other.canCreateTicket_;
			this.canDestroyTicket_ = other.canDestroyTicket_;
			this.canGetBan_ = other.canGetBan_;
			this.canAddBan_ = other.canAddBan_;
			this.canRemoveBan_ = other.canRemoveBan_;
			this.canCreateStream_ = other.canCreateStream_;
			this.canDestroyStream_ = other.canDestroyStream_;
			this.canSetStreamPosition_ = other.canSetStreamPosition_;
			this.canSetStreamAttribute_ = other.canSetStreamAttribute_;
			this.canSetStreamName_ = other.canSetStreamName_;
			this.canSetStreamSubject_ = other.canSetStreamSubject_;
			this.canSetStreamAccess_ = other.canSetStreamAccess_;
			this.canSetStreamVoiceLevel_ = other.canSetStreamVoiceLevel_;
			this.canCreateMessage_ = other.canCreateMessage_;
			this.canDestroyOwnMessage_ = other.canDestroyOwnMessage_;
			this.canDestroyOtherMessage_ = other.canDestroyOtherMessage_;
			this.canEditOwnMessage_ = other.canEditOwnMessage_;
			this.canPinMessage_ = other.canPinMessage_;
			this.canMentionAll_ = other.canMentionAll_;
			this.canMentionHere_ = other.canMentionHere_;
			this.canMentionMember_ = other.canMentionMember_;
			this.canMentionRole_ = other.canMentionRole_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007AC5 RID: 31429 RVA: 0x001DD468 File Offset: 0x001DB668
		[DebuggerNonUserCode]
		public ClubPrivilegeSet Clone()
		{
			return new ClubPrivilegeSet(this);
		}

		// Token: 0x170026DD RID: 9949
		// (get) Token: 0x06007AC6 RID: 31430 RVA: 0x001DD480 File Offset: 0x001DB680
		// (set) Token: 0x06007AC7 RID: 31431 RVA: 0x001DD4B1 File Offset: 0x001DB6B1
		[DebuggerNonUserCode]
		public bool CanDestroy
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool canDestroyDefaultValue;
				if (flag)
				{
					canDestroyDefaultValue = this.canDestroy_;
				}
				else
				{
					canDestroyDefaultValue = ClubPrivilegeSet.CanDestroyDefaultValue;
				}
				return canDestroyDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.canDestroy_ = value;
			}
		}

		// Token: 0x170026DE RID: 9950
		// (get) Token: 0x06007AC8 RID: 31432 RVA: 0x001DD4CC File Offset: 0x001DB6CC
		[DebuggerNonUserCode]
		public bool HasCanDestroy
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007AC9 RID: 31433 RVA: 0x001DD4E9 File Offset: 0x001DB6E9
		[DebuggerNonUserCode]
		public void ClearCanDestroy()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170026DF RID: 9951
		// (get) Token: 0x06007ACA RID: 31434 RVA: 0x001DD4FC File Offset: 0x001DB6FC
		// (set) Token: 0x06007ACB RID: 31435 RVA: 0x001DD52D File Offset: 0x001DB72D
		[DebuggerNonUserCode]
		public bool CanSetAttribute
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool canSetAttributeDefaultValue;
				if (flag)
				{
					canSetAttributeDefaultValue = this.canSetAttribute_;
				}
				else
				{
					canSetAttributeDefaultValue = ClubPrivilegeSet.CanSetAttributeDefaultValue;
				}
				return canSetAttributeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.canSetAttribute_ = value;
			}
		}

		// Token: 0x170026E0 RID: 9952
		// (get) Token: 0x06007ACC RID: 31436 RVA: 0x001DD548 File Offset: 0x001DB748
		[DebuggerNonUserCode]
		public bool HasCanSetAttribute
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06007ACD RID: 31437 RVA: 0x001DD565 File Offset: 0x001DB765
		[DebuggerNonUserCode]
		public void ClearCanSetAttribute()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170026E1 RID: 9953
		// (get) Token: 0x06007ACE RID: 31438 RVA: 0x001DD578 File Offset: 0x001DB778
		// (set) Token: 0x06007ACF RID: 31439 RVA: 0x001DD5A9 File Offset: 0x001DB7A9
		[DebuggerNonUserCode]
		public bool CanSetName
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool canSetNameDefaultValue;
				if (flag)
				{
					canSetNameDefaultValue = this.canSetName_;
				}
				else
				{
					canSetNameDefaultValue = ClubPrivilegeSet.CanSetNameDefaultValue;
				}
				return canSetNameDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.canSetName_ = value;
			}
		}

		// Token: 0x170026E2 RID: 9954
		// (get) Token: 0x06007AD0 RID: 31440 RVA: 0x001DD5C4 File Offset: 0x001DB7C4
		[DebuggerNonUserCode]
		public bool HasCanSetName
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06007AD1 RID: 31441 RVA: 0x001DD5E1 File Offset: 0x001DB7E1
		[DebuggerNonUserCode]
		public void ClearCanSetName()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170026E3 RID: 9955
		// (get) Token: 0x06007AD2 RID: 31442 RVA: 0x001DD5F4 File Offset: 0x001DB7F4
		// (set) Token: 0x06007AD3 RID: 31443 RVA: 0x001DD625 File Offset: 0x001DB825
		[DebuggerNonUserCode]
		public bool CanSetDescription
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool canSetDescriptionDefaultValue;
				if (flag)
				{
					canSetDescriptionDefaultValue = this.canSetDescription_;
				}
				else
				{
					canSetDescriptionDefaultValue = ClubPrivilegeSet.CanSetDescriptionDefaultValue;
				}
				return canSetDescriptionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.canSetDescription_ = value;
			}
		}

		// Token: 0x170026E4 RID: 9956
		// (get) Token: 0x06007AD4 RID: 31444 RVA: 0x001DD640 File Offset: 0x001DB840
		[DebuggerNonUserCode]
		public bool HasCanSetDescription
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06007AD5 RID: 31445 RVA: 0x001DD65D File Offset: 0x001DB85D
		[DebuggerNonUserCode]
		public void ClearCanSetDescription()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x170026E5 RID: 9957
		// (get) Token: 0x06007AD6 RID: 31446 RVA: 0x001DD670 File Offset: 0x001DB870
		// (set) Token: 0x06007AD7 RID: 31447 RVA: 0x001DD6A2 File Offset: 0x001DB8A2
		[DebuggerNonUserCode]
		public bool CanSetAvatar
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool canSetAvatarDefaultValue;
				if (flag)
				{
					canSetAvatarDefaultValue = this.canSetAvatar_;
				}
				else
				{
					canSetAvatarDefaultValue = ClubPrivilegeSet.CanSetAvatarDefaultValue;
				}
				return canSetAvatarDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.canSetAvatar_ = value;
			}
		}

		// Token: 0x170026E6 RID: 9958
		// (get) Token: 0x06007AD8 RID: 31448 RVA: 0x001DD6BC File Offset: 0x001DB8BC
		[DebuggerNonUserCode]
		public bool HasCanSetAvatar
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06007AD9 RID: 31449 RVA: 0x001DD6DA File Offset: 0x001DB8DA
		[DebuggerNonUserCode]
		public void ClearCanSetAvatar()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x170026E7 RID: 9959
		// (get) Token: 0x06007ADA RID: 31450 RVA: 0x001DD6EC File Offset: 0x001DB8EC
		// (set) Token: 0x06007ADB RID: 31451 RVA: 0x001DD71E File Offset: 0x001DB91E
		[DebuggerNonUserCode]
		public bool CanSetBroadcast
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				bool canSetBroadcastDefaultValue;
				if (flag)
				{
					canSetBroadcastDefaultValue = this.canSetBroadcast_;
				}
				else
				{
					canSetBroadcastDefaultValue = ClubPrivilegeSet.CanSetBroadcastDefaultValue;
				}
				return canSetBroadcastDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.canSetBroadcast_ = value;
			}
		}

		// Token: 0x170026E8 RID: 9960
		// (get) Token: 0x06007ADC RID: 31452 RVA: 0x001DD738 File Offset: 0x001DB938
		[DebuggerNonUserCode]
		public bool HasCanSetBroadcast
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06007ADD RID: 31453 RVA: 0x001DD756 File Offset: 0x001DB956
		[DebuggerNonUserCode]
		public void ClearCanSetBroadcast()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x170026E9 RID: 9961
		// (get) Token: 0x06007ADE RID: 31454 RVA: 0x001DD768 File Offset: 0x001DB968
		// (set) Token: 0x06007ADF RID: 31455 RVA: 0x001DD79A File Offset: 0x001DB99A
		[DebuggerNonUserCode]
		public bool CanSetPrivacyLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				bool canSetPrivacyLevelDefaultValue;
				if (flag)
				{
					canSetPrivacyLevelDefaultValue = this.canSetPrivacyLevel_;
				}
				else
				{
					canSetPrivacyLevelDefaultValue = ClubPrivilegeSet.CanSetPrivacyLevelDefaultValue;
				}
				return canSetPrivacyLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.canSetPrivacyLevel_ = value;
			}
		}

		// Token: 0x170026EA RID: 9962
		// (get) Token: 0x06007AE0 RID: 31456 RVA: 0x001DD7B4 File Offset: 0x001DB9B4
		[DebuggerNonUserCode]
		public bool HasCanSetPrivacyLevel
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06007AE1 RID: 31457 RVA: 0x001DD7D2 File Offset: 0x001DB9D2
		[DebuggerNonUserCode]
		public void ClearCanSetPrivacyLevel()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x170026EB RID: 9963
		// (get) Token: 0x06007AE2 RID: 31458 RVA: 0x001DD7E4 File Offset: 0x001DB9E4
		// (set) Token: 0x06007AE3 RID: 31459 RVA: 0x001DD819 File Offset: 0x001DBA19
		[DebuggerNonUserCode]
		public bool CanKickMember
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				bool canKickMemberDefaultValue;
				if (flag)
				{
					canKickMemberDefaultValue = this.canKickMember_;
				}
				else
				{
					canKickMemberDefaultValue = ClubPrivilegeSet.CanKickMemberDefaultValue;
				}
				return canKickMemberDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.canKickMember_ = value;
			}
		}

		// Token: 0x170026EC RID: 9964
		// (get) Token: 0x06007AE4 RID: 31460 RVA: 0x001DD838 File Offset: 0x001DBA38
		[DebuggerNonUserCode]
		public bool HasCanKickMember
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x06007AE5 RID: 31461 RVA: 0x001DD859 File Offset: 0x001DBA59
		[DebuggerNonUserCode]
		public void ClearCanKickMember()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x170026ED RID: 9965
		// (get) Token: 0x06007AE6 RID: 31462 RVA: 0x001DD870 File Offset: 0x001DBA70
		// (set) Token: 0x06007AE7 RID: 31463 RVA: 0x001DD8A5 File Offset: 0x001DBAA5
		[DebuggerNonUserCode]
		public bool CanSetOwnMemberAttribute
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				bool canSetOwnMemberAttributeDefaultValue;
				if (flag)
				{
					canSetOwnMemberAttributeDefaultValue = this.canSetOwnMemberAttribute_;
				}
				else
				{
					canSetOwnMemberAttributeDefaultValue = ClubPrivilegeSet.CanSetOwnMemberAttributeDefaultValue;
				}
				return canSetOwnMemberAttributeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.canSetOwnMemberAttribute_ = value;
			}
		}

		// Token: 0x170026EE RID: 9966
		// (get) Token: 0x06007AE8 RID: 31464 RVA: 0x001DD8C4 File Offset: 0x001DBAC4
		[DebuggerNonUserCode]
		public bool HasCanSetOwnMemberAttribute
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x06007AE9 RID: 31465 RVA: 0x001DD8E5 File Offset: 0x001DBAE5
		[DebuggerNonUserCode]
		public void ClearCanSetOwnMemberAttribute()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x170026EF RID: 9967
		// (get) Token: 0x06007AEA RID: 31466 RVA: 0x001DD8FC File Offset: 0x001DBAFC
		// (set) Token: 0x06007AEB RID: 31467 RVA: 0x001DD931 File Offset: 0x001DBB31
		[DebuggerNonUserCode]
		public bool CanSetOtherMemberAttribute
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				bool canSetOtherMemberAttributeDefaultValue;
				if (flag)
				{
					canSetOtherMemberAttributeDefaultValue = this.canSetOtherMemberAttribute_;
				}
				else
				{
					canSetOtherMemberAttributeDefaultValue = ClubPrivilegeSet.CanSetOtherMemberAttributeDefaultValue;
				}
				return canSetOtherMemberAttributeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.canSetOtherMemberAttribute_ = value;
			}
		}

		// Token: 0x170026F0 RID: 9968
		// (get) Token: 0x06007AEC RID: 31468 RVA: 0x001DD950 File Offset: 0x001DBB50
		[DebuggerNonUserCode]
		public bool HasCanSetOtherMemberAttribute
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x06007AED RID: 31469 RVA: 0x001DD971 File Offset: 0x001DBB71
		[DebuggerNonUserCode]
		public void ClearCanSetOtherMemberAttribute()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x170026F1 RID: 9969
		// (get) Token: 0x06007AEE RID: 31470 RVA: 0x001DD988 File Offset: 0x001DBB88
		// (set) Token: 0x06007AEF RID: 31471 RVA: 0x001DD9BD File Offset: 0x001DBBBD
		[DebuggerNonUserCode]
		public bool CanSetOwnVoiceState
		{
			get
			{
				bool flag = (this._hasBits0 & 1024) != 0;
				bool canSetOwnVoiceStateDefaultValue;
				if (flag)
				{
					canSetOwnVoiceStateDefaultValue = this.canSetOwnVoiceState_;
				}
				else
				{
					canSetOwnVoiceStateDefaultValue = ClubPrivilegeSet.CanSetOwnVoiceStateDefaultValue;
				}
				return canSetOwnVoiceStateDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1024;
				this.canSetOwnVoiceState_ = value;
			}
		}

		// Token: 0x170026F2 RID: 9970
		// (get) Token: 0x06007AF0 RID: 31472 RVA: 0x001DD9DC File Offset: 0x001DBBDC
		[DebuggerNonUserCode]
		public bool HasCanSetOwnVoiceState
		{
			get
			{
				return (this._hasBits0 & 1024) != 0;
			}
		}

		// Token: 0x06007AF1 RID: 31473 RVA: 0x001DD9FD File Offset: 0x001DBBFD
		[DebuggerNonUserCode]
		public void ClearCanSetOwnVoiceState()
		{
			this._hasBits0 &= -1025;
		}

		// Token: 0x170026F3 RID: 9971
		// (get) Token: 0x06007AF2 RID: 31474 RVA: 0x001DDA14 File Offset: 0x001DBC14
		// (set) Token: 0x06007AF3 RID: 31475 RVA: 0x001DDA49 File Offset: 0x001DBC49
		[DebuggerNonUserCode]
		public bool CanSetOwnPresenceLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 2048) != 0;
				bool canSetOwnPresenceLevelDefaultValue;
				if (flag)
				{
					canSetOwnPresenceLevelDefaultValue = this.canSetOwnPresenceLevel_;
				}
				else
				{
					canSetOwnPresenceLevelDefaultValue = ClubPrivilegeSet.CanSetOwnPresenceLevelDefaultValue;
				}
				return canSetOwnPresenceLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2048;
				this.canSetOwnPresenceLevel_ = value;
			}
		}

		// Token: 0x170026F4 RID: 9972
		// (get) Token: 0x06007AF4 RID: 31476 RVA: 0x001DDA68 File Offset: 0x001DBC68
		[DebuggerNonUserCode]
		public bool HasCanSetOwnPresenceLevel
		{
			get
			{
				return (this._hasBits0 & 2048) != 0;
			}
		}

		// Token: 0x06007AF5 RID: 31477 RVA: 0x001DDA89 File Offset: 0x001DBC89
		[DebuggerNonUserCode]
		public void ClearCanSetOwnPresenceLevel()
		{
			this._hasBits0 &= -2049;
		}

		// Token: 0x170026F5 RID: 9973
		// (get) Token: 0x06007AF6 RID: 31478 RVA: 0x001DDAA0 File Offset: 0x001DBCA0
		// (set) Token: 0x06007AF7 RID: 31479 RVA: 0x001DDAD5 File Offset: 0x001DBCD5
		[DebuggerNonUserCode]
		public bool CanSetOwnWhisperLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 4096) != 0;
				bool canSetOwnWhisperLevelDefaultValue;
				if (flag)
				{
					canSetOwnWhisperLevelDefaultValue = this.canSetOwnWhisperLevel_;
				}
				else
				{
					canSetOwnWhisperLevelDefaultValue = ClubPrivilegeSet.CanSetOwnWhisperLevelDefaultValue;
				}
				return canSetOwnWhisperLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4096;
				this.canSetOwnWhisperLevel_ = value;
			}
		}

		// Token: 0x170026F6 RID: 9974
		// (get) Token: 0x06007AF8 RID: 31480 RVA: 0x001DDAF4 File Offset: 0x001DBCF4
		[DebuggerNonUserCode]
		public bool HasCanSetOwnWhisperLevel
		{
			get
			{
				return (this._hasBits0 & 4096) != 0;
			}
		}

		// Token: 0x06007AF9 RID: 31481 RVA: 0x001DDB15 File Offset: 0x001DBD15
		[DebuggerNonUserCode]
		public void ClearCanSetOwnWhisperLevel()
		{
			this._hasBits0 &= -4097;
		}

		// Token: 0x170026F7 RID: 9975
		// (get) Token: 0x06007AFA RID: 31482 RVA: 0x001DDB2C File Offset: 0x001DBD2C
		// (set) Token: 0x06007AFB RID: 31483 RVA: 0x001DDB61 File Offset: 0x001DBD61
		[DebuggerNonUserCode]
		public bool CanSetOwnMemberNote
		{
			get
			{
				bool flag = (this._hasBits0 & 8192) != 0;
				bool canSetOwnMemberNoteDefaultValue;
				if (flag)
				{
					canSetOwnMemberNoteDefaultValue = this.canSetOwnMemberNote_;
				}
				else
				{
					canSetOwnMemberNoteDefaultValue = ClubPrivilegeSet.CanSetOwnMemberNoteDefaultValue;
				}
				return canSetOwnMemberNoteDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8192;
				this.canSetOwnMemberNote_ = value;
			}
		}

		// Token: 0x170026F8 RID: 9976
		// (get) Token: 0x06007AFC RID: 31484 RVA: 0x001DDB80 File Offset: 0x001DBD80
		[DebuggerNonUserCode]
		public bool HasCanSetOwnMemberNote
		{
			get
			{
				return (this._hasBits0 & 8192) != 0;
			}
		}

		// Token: 0x06007AFD RID: 31485 RVA: 0x001DDBA1 File Offset: 0x001DBDA1
		[DebuggerNonUserCode]
		public void ClearCanSetOwnMemberNote()
		{
			this._hasBits0 &= -8193;
		}

		// Token: 0x170026F9 RID: 9977
		// (get) Token: 0x06007AFE RID: 31486 RVA: 0x001DDBB8 File Offset: 0x001DBDB8
		// (set) Token: 0x06007AFF RID: 31487 RVA: 0x001DDBED File Offset: 0x001DBDED
		[DebuggerNonUserCode]
		public bool CanSetOtherMemberNote
		{
			get
			{
				bool flag = (this._hasBits0 & 16384) != 0;
				bool canSetOtherMemberNoteDefaultValue;
				if (flag)
				{
					canSetOtherMemberNoteDefaultValue = this.canSetOtherMemberNote_;
				}
				else
				{
					canSetOtherMemberNoteDefaultValue = ClubPrivilegeSet.CanSetOtherMemberNoteDefaultValue;
				}
				return canSetOtherMemberNoteDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16384;
				this.canSetOtherMemberNote_ = value;
			}
		}

		// Token: 0x170026FA RID: 9978
		// (get) Token: 0x06007B00 RID: 31488 RVA: 0x001DDC0C File Offset: 0x001DBE0C
		[DebuggerNonUserCode]
		public bool HasCanSetOtherMemberNote
		{
			get
			{
				return (this._hasBits0 & 16384) != 0;
			}
		}

		// Token: 0x06007B01 RID: 31489 RVA: 0x001DDC2D File Offset: 0x001DBE2D
		[DebuggerNonUserCode]
		public void ClearCanSetOtherMemberNote()
		{
			this._hasBits0 &= -16385;
		}

		// Token: 0x170026FB RID: 9979
		// (get) Token: 0x06007B02 RID: 31490 RVA: 0x001DDC44 File Offset: 0x001DBE44
		// (set) Token: 0x06007B03 RID: 31491 RVA: 0x001DDC79 File Offset: 0x001DBE79
		[DebuggerNonUserCode]
		public bool CanUseVoice
		{
			get
			{
				bool flag = (this._hasBits0 & 32768) != 0;
				bool canUseVoiceDefaultValue;
				if (flag)
				{
					canUseVoiceDefaultValue = this.canUseVoice_;
				}
				else
				{
					canUseVoiceDefaultValue = ClubPrivilegeSet.CanUseVoiceDefaultValue;
				}
				return canUseVoiceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32768;
				this.canUseVoice_ = value;
			}
		}

		// Token: 0x170026FC RID: 9980
		// (get) Token: 0x06007B04 RID: 31492 RVA: 0x001DDC98 File Offset: 0x001DBE98
		[DebuggerNonUserCode]
		public bool HasCanUseVoice
		{
			get
			{
				return (this._hasBits0 & 32768) != 0;
			}
		}

		// Token: 0x06007B05 RID: 31493 RVA: 0x001DDCB9 File Offset: 0x001DBEB9
		[DebuggerNonUserCode]
		public void ClearCanUseVoice()
		{
			this._hasBits0 &= -32769;
		}

		// Token: 0x170026FD RID: 9981
		// (get) Token: 0x06007B06 RID: 31494 RVA: 0x001DDCD0 File Offset: 0x001DBED0
		// (set) Token: 0x06007B07 RID: 31495 RVA: 0x001DDD05 File Offset: 0x001DBF05
		[DebuggerNonUserCode]
		public bool CanVoiceMuteMemberForAll
		{
			get
			{
				bool flag = (this._hasBits0 & 65536) != 0;
				bool canVoiceMuteMemberForAllDefaultValue;
				if (flag)
				{
					canVoiceMuteMemberForAllDefaultValue = this.canVoiceMuteMemberForAll_;
				}
				else
				{
					canVoiceMuteMemberForAllDefaultValue = ClubPrivilegeSet.CanVoiceMuteMemberForAllDefaultValue;
				}
				return canVoiceMuteMemberForAllDefaultValue;
			}
			set
			{
				this._hasBits0 |= 65536;
				this.canVoiceMuteMemberForAll_ = value;
			}
		}

		// Token: 0x170026FE RID: 9982
		// (get) Token: 0x06007B08 RID: 31496 RVA: 0x001DDD24 File Offset: 0x001DBF24
		[DebuggerNonUserCode]
		public bool HasCanVoiceMuteMemberForAll
		{
			get
			{
				return (this._hasBits0 & 65536) != 0;
			}
		}

		// Token: 0x06007B09 RID: 31497 RVA: 0x001DDD45 File Offset: 0x001DBF45
		[DebuggerNonUserCode]
		public void ClearCanVoiceMuteMemberForAll()
		{
			this._hasBits0 &= -65537;
		}

		// Token: 0x170026FF RID: 9983
		// (get) Token: 0x06007B0A RID: 31498 RVA: 0x001DDD5C File Offset: 0x001DBF5C
		// (set) Token: 0x06007B0B RID: 31499 RVA: 0x001DDD91 File Offset: 0x001DBF91
		[DebuggerNonUserCode]
		public bool CanGetInvitation
		{
			get
			{
				bool flag = (this._hasBits0 & 131072) != 0;
				bool canGetInvitationDefaultValue;
				if (flag)
				{
					canGetInvitationDefaultValue = this.canGetInvitation_;
				}
				else
				{
					canGetInvitationDefaultValue = ClubPrivilegeSet.CanGetInvitationDefaultValue;
				}
				return canGetInvitationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 131072;
				this.canGetInvitation_ = value;
			}
		}

		// Token: 0x17002700 RID: 9984
		// (get) Token: 0x06007B0C RID: 31500 RVA: 0x001DDDB0 File Offset: 0x001DBFB0
		[DebuggerNonUserCode]
		public bool HasCanGetInvitation
		{
			get
			{
				return (this._hasBits0 & 131072) != 0;
			}
		}

		// Token: 0x06007B0D RID: 31501 RVA: 0x001DDDD1 File Offset: 0x001DBFD1
		[DebuggerNonUserCode]
		public void ClearCanGetInvitation()
		{
			this._hasBits0 &= -131073;
		}

		// Token: 0x17002701 RID: 9985
		// (get) Token: 0x06007B0E RID: 31502 RVA: 0x001DDDE8 File Offset: 0x001DBFE8
		// (set) Token: 0x06007B0F RID: 31503 RVA: 0x001DDE1D File Offset: 0x001DC01D
		[DebuggerNonUserCode]
		public bool CanSendInvitation
		{
			get
			{
				bool flag = (this._hasBits0 & 262144) != 0;
				bool canSendInvitationDefaultValue;
				if (flag)
				{
					canSendInvitationDefaultValue = this.canSendInvitation_;
				}
				else
				{
					canSendInvitationDefaultValue = ClubPrivilegeSet.CanSendInvitationDefaultValue;
				}
				return canSendInvitationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 262144;
				this.canSendInvitation_ = value;
			}
		}

		// Token: 0x17002702 RID: 9986
		// (get) Token: 0x06007B10 RID: 31504 RVA: 0x001DDE3C File Offset: 0x001DC03C
		[DebuggerNonUserCode]
		public bool HasCanSendInvitation
		{
			get
			{
				return (this._hasBits0 & 262144) != 0;
			}
		}

		// Token: 0x06007B11 RID: 31505 RVA: 0x001DDE5D File Offset: 0x001DC05D
		[DebuggerNonUserCode]
		public void ClearCanSendInvitation()
		{
			this._hasBits0 &= -262145;
		}

		// Token: 0x17002703 RID: 9987
		// (get) Token: 0x06007B12 RID: 31506 RVA: 0x001DDE74 File Offset: 0x001DC074
		// (set) Token: 0x06007B13 RID: 31507 RVA: 0x001DDEA9 File Offset: 0x001DC0A9
		[DebuggerNonUserCode]
		public bool CanSendGuestInvitation
		{
			get
			{
				bool flag = (this._hasBits0 & 524288) != 0;
				bool canSendGuestInvitationDefaultValue;
				if (flag)
				{
					canSendGuestInvitationDefaultValue = this.canSendGuestInvitation_;
				}
				else
				{
					canSendGuestInvitationDefaultValue = ClubPrivilegeSet.CanSendGuestInvitationDefaultValue;
				}
				return canSendGuestInvitationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 524288;
				this.canSendGuestInvitation_ = value;
			}
		}

		// Token: 0x17002704 RID: 9988
		// (get) Token: 0x06007B14 RID: 31508 RVA: 0x001DDEC8 File Offset: 0x001DC0C8
		[DebuggerNonUserCode]
		public bool HasCanSendGuestInvitation
		{
			get
			{
				return (this._hasBits0 & 524288) != 0;
			}
		}

		// Token: 0x06007B15 RID: 31509 RVA: 0x001DDEE9 File Offset: 0x001DC0E9
		[DebuggerNonUserCode]
		public void ClearCanSendGuestInvitation()
		{
			this._hasBits0 &= -524289;
		}

		// Token: 0x17002705 RID: 9989
		// (get) Token: 0x06007B16 RID: 31510 RVA: 0x001DDF00 File Offset: 0x001DC100
		// (set) Token: 0x06007B17 RID: 31511 RVA: 0x001DDF35 File Offset: 0x001DC135
		[DebuggerNonUserCode]
		public bool CanRevokeOwnInvitation
		{
			get
			{
				bool flag = (this._hasBits0 & 1048576) != 0;
				bool canRevokeOwnInvitationDefaultValue;
				if (flag)
				{
					canRevokeOwnInvitationDefaultValue = this.canRevokeOwnInvitation_;
				}
				else
				{
					canRevokeOwnInvitationDefaultValue = ClubPrivilegeSet.CanRevokeOwnInvitationDefaultValue;
				}
				return canRevokeOwnInvitationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1048576;
				this.canRevokeOwnInvitation_ = value;
			}
		}

		// Token: 0x17002706 RID: 9990
		// (get) Token: 0x06007B18 RID: 31512 RVA: 0x001DDF54 File Offset: 0x001DC154
		[DebuggerNonUserCode]
		public bool HasCanRevokeOwnInvitation
		{
			get
			{
				return (this._hasBits0 & 1048576) != 0;
			}
		}

		// Token: 0x06007B19 RID: 31513 RVA: 0x001DDF75 File Offset: 0x001DC175
		[DebuggerNonUserCode]
		public void ClearCanRevokeOwnInvitation()
		{
			this._hasBits0 &= -1048577;
		}

		// Token: 0x17002707 RID: 9991
		// (get) Token: 0x06007B1A RID: 31514 RVA: 0x001DDF8C File Offset: 0x001DC18C
		// (set) Token: 0x06007B1B RID: 31515 RVA: 0x001DDFC1 File Offset: 0x001DC1C1
		[DebuggerNonUserCode]
		public bool CanRevokeOtherInvitation
		{
			get
			{
				bool flag = (this._hasBits0 & 2097152) != 0;
				bool canRevokeOtherInvitationDefaultValue;
				if (flag)
				{
					canRevokeOtherInvitationDefaultValue = this.canRevokeOtherInvitation_;
				}
				else
				{
					canRevokeOtherInvitationDefaultValue = ClubPrivilegeSet.CanRevokeOtherInvitationDefaultValue;
				}
				return canRevokeOtherInvitationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2097152;
				this.canRevokeOtherInvitation_ = value;
			}
		}

		// Token: 0x17002708 RID: 9992
		// (get) Token: 0x06007B1C RID: 31516 RVA: 0x001DDFE0 File Offset: 0x001DC1E0
		[DebuggerNonUserCode]
		public bool HasCanRevokeOtherInvitation
		{
			get
			{
				return (this._hasBits0 & 2097152) != 0;
			}
		}

		// Token: 0x06007B1D RID: 31517 RVA: 0x001DE001 File Offset: 0x001DC201
		[DebuggerNonUserCode]
		public void ClearCanRevokeOtherInvitation()
		{
			this._hasBits0 &= -2097153;
		}

		// Token: 0x17002709 RID: 9993
		// (get) Token: 0x06007B1E RID: 31518 RVA: 0x001DE018 File Offset: 0x001DC218
		// (set) Token: 0x06007B1F RID: 31519 RVA: 0x001DE04D File Offset: 0x001DC24D
		[DebuggerNonUserCode]
		public bool CanGetSuggestion
		{
			get
			{
				bool flag = (this._hasBits0 & 4194304) != 0;
				bool canGetSuggestionDefaultValue;
				if (flag)
				{
					canGetSuggestionDefaultValue = this.canGetSuggestion_;
				}
				else
				{
					canGetSuggestionDefaultValue = ClubPrivilegeSet.CanGetSuggestionDefaultValue;
				}
				return canGetSuggestionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4194304;
				this.canGetSuggestion_ = value;
			}
		}

		// Token: 0x1700270A RID: 9994
		// (get) Token: 0x06007B20 RID: 31520 RVA: 0x001DE06C File Offset: 0x001DC26C
		[DebuggerNonUserCode]
		public bool HasCanGetSuggestion
		{
			get
			{
				return (this._hasBits0 & 4194304) != 0;
			}
		}

		// Token: 0x06007B21 RID: 31521 RVA: 0x001DE08D File Offset: 0x001DC28D
		[DebuggerNonUserCode]
		public void ClearCanGetSuggestion()
		{
			this._hasBits0 &= -4194305;
		}

		// Token: 0x1700270B RID: 9995
		// (get) Token: 0x06007B22 RID: 31522 RVA: 0x001DE0A4 File Offset: 0x001DC2A4
		// (set) Token: 0x06007B23 RID: 31523 RVA: 0x001DE0D9 File Offset: 0x001DC2D9
		[DebuggerNonUserCode]
		public bool CanSuggestMember
		{
			get
			{
				bool flag = (this._hasBits0 & 8388608) != 0;
				bool canSuggestMemberDefaultValue;
				if (flag)
				{
					canSuggestMemberDefaultValue = this.canSuggestMember_;
				}
				else
				{
					canSuggestMemberDefaultValue = ClubPrivilegeSet.CanSuggestMemberDefaultValue;
				}
				return canSuggestMemberDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8388608;
				this.canSuggestMember_ = value;
			}
		}

		// Token: 0x1700270C RID: 9996
		// (get) Token: 0x06007B24 RID: 31524 RVA: 0x001DE0F8 File Offset: 0x001DC2F8
		[DebuggerNonUserCode]
		public bool HasCanSuggestMember
		{
			get
			{
				return (this._hasBits0 & 8388608) != 0;
			}
		}

		// Token: 0x06007B25 RID: 31525 RVA: 0x001DE119 File Offset: 0x001DC319
		[DebuggerNonUserCode]
		public void ClearCanSuggestMember()
		{
			this._hasBits0 &= -8388609;
		}

		// Token: 0x1700270D RID: 9997
		// (get) Token: 0x06007B26 RID: 31526 RVA: 0x001DE130 File Offset: 0x001DC330
		// (set) Token: 0x06007B27 RID: 31527 RVA: 0x001DE165 File Offset: 0x001DC365
		[DebuggerNonUserCode]
		public bool CanApproveMember
		{
			get
			{
				bool flag = (this._hasBits0 & 16777216) != 0;
				bool canApproveMemberDefaultValue;
				if (flag)
				{
					canApproveMemberDefaultValue = this.canApproveMember_;
				}
				else
				{
					canApproveMemberDefaultValue = ClubPrivilegeSet.CanApproveMemberDefaultValue;
				}
				return canApproveMemberDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16777216;
				this.canApproveMember_ = value;
			}
		}

		// Token: 0x1700270E RID: 9998
		// (get) Token: 0x06007B28 RID: 31528 RVA: 0x001DE184 File Offset: 0x001DC384
		[DebuggerNonUserCode]
		public bool HasCanApproveMember
		{
			get
			{
				return (this._hasBits0 & 16777216) != 0;
			}
		}

		// Token: 0x06007B29 RID: 31529 RVA: 0x001DE1A5 File Offset: 0x001DC3A5
		[DebuggerNonUserCode]
		public void ClearCanApproveMember()
		{
			this._hasBits0 &= -16777217;
		}

		// Token: 0x1700270F RID: 9999
		// (get) Token: 0x06007B2A RID: 31530 RVA: 0x001DE1BC File Offset: 0x001DC3BC
		// (set) Token: 0x06007B2B RID: 31531 RVA: 0x001DE1F1 File Offset: 0x001DC3F1
		[DebuggerNonUserCode]
		public bool CanGetTicket
		{
			get
			{
				bool flag = (this._hasBits0 & 33554432) != 0;
				bool canGetTicketDefaultValue;
				if (flag)
				{
					canGetTicketDefaultValue = this.canGetTicket_;
				}
				else
				{
					canGetTicketDefaultValue = ClubPrivilegeSet.CanGetTicketDefaultValue;
				}
				return canGetTicketDefaultValue;
			}
			set
			{
				this._hasBits0 |= 33554432;
				this.canGetTicket_ = value;
			}
		}

		// Token: 0x17002710 RID: 10000
		// (get) Token: 0x06007B2C RID: 31532 RVA: 0x001DE210 File Offset: 0x001DC410
		[DebuggerNonUserCode]
		public bool HasCanGetTicket
		{
			get
			{
				return (this._hasBits0 & 33554432) != 0;
			}
		}

		// Token: 0x06007B2D RID: 31533 RVA: 0x001DE231 File Offset: 0x001DC431
		[DebuggerNonUserCode]
		public void ClearCanGetTicket()
		{
			this._hasBits0 &= -33554433;
		}

		// Token: 0x17002711 RID: 10001
		// (get) Token: 0x06007B2E RID: 31534 RVA: 0x001DE248 File Offset: 0x001DC448
		// (set) Token: 0x06007B2F RID: 31535 RVA: 0x001DE27D File Offset: 0x001DC47D
		[DebuggerNonUserCode]
		public bool CanCreateTicket
		{
			get
			{
				bool flag = (this._hasBits0 & 67108864) != 0;
				bool canCreateTicketDefaultValue;
				if (flag)
				{
					canCreateTicketDefaultValue = this.canCreateTicket_;
				}
				else
				{
					canCreateTicketDefaultValue = ClubPrivilegeSet.CanCreateTicketDefaultValue;
				}
				return canCreateTicketDefaultValue;
			}
			set
			{
				this._hasBits0 |= 67108864;
				this.canCreateTicket_ = value;
			}
		}

		// Token: 0x17002712 RID: 10002
		// (get) Token: 0x06007B30 RID: 31536 RVA: 0x001DE29C File Offset: 0x001DC49C
		[DebuggerNonUserCode]
		public bool HasCanCreateTicket
		{
			get
			{
				return (this._hasBits0 & 67108864) != 0;
			}
		}

		// Token: 0x06007B31 RID: 31537 RVA: 0x001DE2BD File Offset: 0x001DC4BD
		[DebuggerNonUserCode]
		public void ClearCanCreateTicket()
		{
			this._hasBits0 &= -67108865;
		}

		// Token: 0x17002713 RID: 10003
		// (get) Token: 0x06007B32 RID: 31538 RVA: 0x001DE2D4 File Offset: 0x001DC4D4
		// (set) Token: 0x06007B33 RID: 31539 RVA: 0x001DE309 File Offset: 0x001DC509
		[DebuggerNonUserCode]
		public bool CanDestroyTicket
		{
			get
			{
				bool flag = (this._hasBits0 & 134217728) != 0;
				bool canDestroyTicketDefaultValue;
				if (flag)
				{
					canDestroyTicketDefaultValue = this.canDestroyTicket_;
				}
				else
				{
					canDestroyTicketDefaultValue = ClubPrivilegeSet.CanDestroyTicketDefaultValue;
				}
				return canDestroyTicketDefaultValue;
			}
			set
			{
				this._hasBits0 |= 134217728;
				this.canDestroyTicket_ = value;
			}
		}

		// Token: 0x17002714 RID: 10004
		// (get) Token: 0x06007B34 RID: 31540 RVA: 0x001DE328 File Offset: 0x001DC528
		[DebuggerNonUserCode]
		public bool HasCanDestroyTicket
		{
			get
			{
				return (this._hasBits0 & 134217728) != 0;
			}
		}

		// Token: 0x06007B35 RID: 31541 RVA: 0x001DE349 File Offset: 0x001DC549
		[DebuggerNonUserCode]
		public void ClearCanDestroyTicket()
		{
			this._hasBits0 &= -134217729;
		}

		// Token: 0x17002715 RID: 10005
		// (get) Token: 0x06007B36 RID: 31542 RVA: 0x001DE360 File Offset: 0x001DC560
		// (set) Token: 0x06007B37 RID: 31543 RVA: 0x001DE395 File Offset: 0x001DC595
		[DebuggerNonUserCode]
		public bool CanGetBan
		{
			get
			{
				bool flag = (this._hasBits0 & 268435456) != 0;
				bool canGetBanDefaultValue;
				if (flag)
				{
					canGetBanDefaultValue = this.canGetBan_;
				}
				else
				{
					canGetBanDefaultValue = ClubPrivilegeSet.CanGetBanDefaultValue;
				}
				return canGetBanDefaultValue;
			}
			set
			{
				this._hasBits0 |= 268435456;
				this.canGetBan_ = value;
			}
		}

		// Token: 0x17002716 RID: 10006
		// (get) Token: 0x06007B38 RID: 31544 RVA: 0x001DE3B4 File Offset: 0x001DC5B4
		[DebuggerNonUserCode]
		public bool HasCanGetBan
		{
			get
			{
				return (this._hasBits0 & 268435456) != 0;
			}
		}

		// Token: 0x06007B39 RID: 31545 RVA: 0x001DE3D5 File Offset: 0x001DC5D5
		[DebuggerNonUserCode]
		public void ClearCanGetBan()
		{
			this._hasBits0 &= -268435457;
		}

		// Token: 0x17002717 RID: 10007
		// (get) Token: 0x06007B3A RID: 31546 RVA: 0x001DE3EC File Offset: 0x001DC5EC
		// (set) Token: 0x06007B3B RID: 31547 RVA: 0x001DE421 File Offset: 0x001DC621
		[DebuggerNonUserCode]
		public bool CanAddBan
		{
			get
			{
				bool flag = (this._hasBits0 & 536870912) != 0;
				bool canAddBanDefaultValue;
				if (flag)
				{
					canAddBanDefaultValue = this.canAddBan_;
				}
				else
				{
					canAddBanDefaultValue = ClubPrivilegeSet.CanAddBanDefaultValue;
				}
				return canAddBanDefaultValue;
			}
			set
			{
				this._hasBits0 |= 536870912;
				this.canAddBan_ = value;
			}
		}

		// Token: 0x17002718 RID: 10008
		// (get) Token: 0x06007B3C RID: 31548 RVA: 0x001DE440 File Offset: 0x001DC640
		[DebuggerNonUserCode]
		public bool HasCanAddBan
		{
			get
			{
				return (this._hasBits0 & 536870912) != 0;
			}
		}

		// Token: 0x06007B3D RID: 31549 RVA: 0x001DE461 File Offset: 0x001DC661
		[DebuggerNonUserCode]
		public void ClearCanAddBan()
		{
			this._hasBits0 &= -536870913;
		}

		// Token: 0x17002719 RID: 10009
		// (get) Token: 0x06007B3E RID: 31550 RVA: 0x001DE478 File Offset: 0x001DC678
		// (set) Token: 0x06007B3F RID: 31551 RVA: 0x001DE4AD File Offset: 0x001DC6AD
		[DebuggerNonUserCode]
		public bool CanRemoveBan
		{
			get
			{
				bool flag = (this._hasBits0 & 1073741824) != 0;
				bool canRemoveBanDefaultValue;
				if (flag)
				{
					canRemoveBanDefaultValue = this.canRemoveBan_;
				}
				else
				{
					canRemoveBanDefaultValue = ClubPrivilegeSet.CanRemoveBanDefaultValue;
				}
				return canRemoveBanDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1073741824;
				this.canRemoveBan_ = value;
			}
		}

		// Token: 0x1700271A RID: 10010
		// (get) Token: 0x06007B40 RID: 31552 RVA: 0x001DE4CC File Offset: 0x001DC6CC
		[DebuggerNonUserCode]
		public bool HasCanRemoveBan
		{
			get
			{
				return (this._hasBits0 & 1073741824) != 0;
			}
		}

		// Token: 0x06007B41 RID: 31553 RVA: 0x001DE4ED File Offset: 0x001DC6ED
		[DebuggerNonUserCode]
		public void ClearCanRemoveBan()
		{
			this._hasBits0 &= -1073741825;
		}

		// Token: 0x1700271B RID: 10011
		// (get) Token: 0x06007B42 RID: 31554 RVA: 0x001DE504 File Offset: 0x001DC704
		// (set) Token: 0x06007B43 RID: 31555 RVA: 0x001DE539 File Offset: 0x001DC739
		[DebuggerNonUserCode]
		public bool CanCreateStream
		{
			get
			{
				bool flag = (this._hasBits0 & int.MinValue) != 0;
				bool canCreateStreamDefaultValue;
				if (flag)
				{
					canCreateStreamDefaultValue = this.canCreateStream_;
				}
				else
				{
					canCreateStreamDefaultValue = ClubPrivilegeSet.CanCreateStreamDefaultValue;
				}
				return canCreateStreamDefaultValue;
			}
			set
			{
				this._hasBits0 |= int.MinValue;
				this.canCreateStream_ = value;
			}
		}

		// Token: 0x1700271C RID: 10012
		// (get) Token: 0x06007B44 RID: 31556 RVA: 0x001DE558 File Offset: 0x001DC758
		[DebuggerNonUserCode]
		public bool HasCanCreateStream
		{
			get
			{
				return (this._hasBits0 & int.MinValue) != 0;
			}
		}

		// Token: 0x06007B45 RID: 31557 RVA: 0x001DE579 File Offset: 0x001DC779
		[DebuggerNonUserCode]
		public void ClearCanCreateStream()
		{
			this._hasBits0 &= int.MaxValue;
		}

		// Token: 0x1700271D RID: 10013
		// (get) Token: 0x06007B46 RID: 31558 RVA: 0x001DE590 File Offset: 0x001DC790
		// (set) Token: 0x06007B47 RID: 31559 RVA: 0x001DE5C1 File Offset: 0x001DC7C1
		[DebuggerNonUserCode]
		public bool CanDestroyStream
		{
			get
			{
				bool flag = (this._hasBits1 & 1) != 0;
				bool canDestroyStreamDefaultValue;
				if (flag)
				{
					canDestroyStreamDefaultValue = this.canDestroyStream_;
				}
				else
				{
					canDestroyStreamDefaultValue = ClubPrivilegeSet.CanDestroyStreamDefaultValue;
				}
				return canDestroyStreamDefaultValue;
			}
			set
			{
				this._hasBits1 |= 1;
				this.canDestroyStream_ = value;
			}
		}

		// Token: 0x1700271E RID: 10014
		// (get) Token: 0x06007B48 RID: 31560 RVA: 0x001DE5DC File Offset: 0x001DC7DC
		[DebuggerNonUserCode]
		public bool HasCanDestroyStream
		{
			get
			{
				return (this._hasBits1 & 1) != 0;
			}
		}

		// Token: 0x06007B49 RID: 31561 RVA: 0x001DE5F9 File Offset: 0x001DC7F9
		[DebuggerNonUserCode]
		public void ClearCanDestroyStream()
		{
			this._hasBits1 &= -2;
		}

		// Token: 0x1700271F RID: 10015
		// (get) Token: 0x06007B4A RID: 31562 RVA: 0x001DE60C File Offset: 0x001DC80C
		// (set) Token: 0x06007B4B RID: 31563 RVA: 0x001DE63D File Offset: 0x001DC83D
		[DebuggerNonUserCode]
		public bool CanSetStreamPosition
		{
			get
			{
				bool flag = (this._hasBits1 & 2) != 0;
				bool canSetStreamPositionDefaultValue;
				if (flag)
				{
					canSetStreamPositionDefaultValue = this.canSetStreamPosition_;
				}
				else
				{
					canSetStreamPositionDefaultValue = ClubPrivilegeSet.CanSetStreamPositionDefaultValue;
				}
				return canSetStreamPositionDefaultValue;
			}
			set
			{
				this._hasBits1 |= 2;
				this.canSetStreamPosition_ = value;
			}
		}

		// Token: 0x17002720 RID: 10016
		// (get) Token: 0x06007B4C RID: 31564 RVA: 0x001DE658 File Offset: 0x001DC858
		[DebuggerNonUserCode]
		public bool HasCanSetStreamPosition
		{
			get
			{
				return (this._hasBits1 & 2) != 0;
			}
		}

		// Token: 0x06007B4D RID: 31565 RVA: 0x001DE675 File Offset: 0x001DC875
		[DebuggerNonUserCode]
		public void ClearCanSetStreamPosition()
		{
			this._hasBits1 &= -3;
		}

		// Token: 0x17002721 RID: 10017
		// (get) Token: 0x06007B4E RID: 31566 RVA: 0x001DE688 File Offset: 0x001DC888
		// (set) Token: 0x06007B4F RID: 31567 RVA: 0x001DE6B9 File Offset: 0x001DC8B9
		[DebuggerNonUserCode]
		public bool CanSetStreamAttribute
		{
			get
			{
				bool flag = (this._hasBits1 & 4) != 0;
				bool canSetStreamAttributeDefaultValue;
				if (flag)
				{
					canSetStreamAttributeDefaultValue = this.canSetStreamAttribute_;
				}
				else
				{
					canSetStreamAttributeDefaultValue = ClubPrivilegeSet.CanSetStreamAttributeDefaultValue;
				}
				return canSetStreamAttributeDefaultValue;
			}
			set
			{
				this._hasBits1 |= 4;
				this.canSetStreamAttribute_ = value;
			}
		}

		// Token: 0x17002722 RID: 10018
		// (get) Token: 0x06007B50 RID: 31568 RVA: 0x001DE6D4 File Offset: 0x001DC8D4
		[DebuggerNonUserCode]
		public bool HasCanSetStreamAttribute
		{
			get
			{
				return (this._hasBits1 & 4) != 0;
			}
		}

		// Token: 0x06007B51 RID: 31569 RVA: 0x001DE6F1 File Offset: 0x001DC8F1
		[DebuggerNonUserCode]
		public void ClearCanSetStreamAttribute()
		{
			this._hasBits1 &= -5;
		}

		// Token: 0x17002723 RID: 10019
		// (get) Token: 0x06007B52 RID: 31570 RVA: 0x001DE704 File Offset: 0x001DC904
		// (set) Token: 0x06007B53 RID: 31571 RVA: 0x001DE735 File Offset: 0x001DC935
		[DebuggerNonUserCode]
		public bool CanSetStreamName
		{
			get
			{
				bool flag = (this._hasBits1 & 8) != 0;
				bool canSetStreamNameDefaultValue;
				if (flag)
				{
					canSetStreamNameDefaultValue = this.canSetStreamName_;
				}
				else
				{
					canSetStreamNameDefaultValue = ClubPrivilegeSet.CanSetStreamNameDefaultValue;
				}
				return canSetStreamNameDefaultValue;
			}
			set
			{
				this._hasBits1 |= 8;
				this.canSetStreamName_ = value;
			}
		}

		// Token: 0x17002724 RID: 10020
		// (get) Token: 0x06007B54 RID: 31572 RVA: 0x001DE750 File Offset: 0x001DC950
		[DebuggerNonUserCode]
		public bool HasCanSetStreamName
		{
			get
			{
				return (this._hasBits1 & 8) != 0;
			}
		}

		// Token: 0x06007B55 RID: 31573 RVA: 0x001DE76D File Offset: 0x001DC96D
		[DebuggerNonUserCode]
		public void ClearCanSetStreamName()
		{
			this._hasBits1 &= -9;
		}

		// Token: 0x17002725 RID: 10021
		// (get) Token: 0x06007B56 RID: 31574 RVA: 0x001DE780 File Offset: 0x001DC980
		// (set) Token: 0x06007B57 RID: 31575 RVA: 0x001DE7B2 File Offset: 0x001DC9B2
		[DebuggerNonUserCode]
		public bool CanSetStreamSubject
		{
			get
			{
				bool flag = (this._hasBits1 & 16) != 0;
				bool canSetStreamSubjectDefaultValue;
				if (flag)
				{
					canSetStreamSubjectDefaultValue = this.canSetStreamSubject_;
				}
				else
				{
					canSetStreamSubjectDefaultValue = ClubPrivilegeSet.CanSetStreamSubjectDefaultValue;
				}
				return canSetStreamSubjectDefaultValue;
			}
			set
			{
				this._hasBits1 |= 16;
				this.canSetStreamSubject_ = value;
			}
		}

		// Token: 0x17002726 RID: 10022
		// (get) Token: 0x06007B58 RID: 31576 RVA: 0x001DE7CC File Offset: 0x001DC9CC
		[DebuggerNonUserCode]
		public bool HasCanSetStreamSubject
		{
			get
			{
				return (this._hasBits1 & 16) != 0;
			}
		}

		// Token: 0x06007B59 RID: 31577 RVA: 0x001DE7EA File Offset: 0x001DC9EA
		[DebuggerNonUserCode]
		public void ClearCanSetStreamSubject()
		{
			this._hasBits1 &= -17;
		}

		// Token: 0x17002727 RID: 10023
		// (get) Token: 0x06007B5A RID: 31578 RVA: 0x001DE7FC File Offset: 0x001DC9FC
		// (set) Token: 0x06007B5B RID: 31579 RVA: 0x001DE82E File Offset: 0x001DCA2E
		[DebuggerNonUserCode]
		public bool CanSetStreamAccess
		{
			get
			{
				bool flag = (this._hasBits1 & 32) != 0;
				bool canSetStreamAccessDefaultValue;
				if (flag)
				{
					canSetStreamAccessDefaultValue = this.canSetStreamAccess_;
				}
				else
				{
					canSetStreamAccessDefaultValue = ClubPrivilegeSet.CanSetStreamAccessDefaultValue;
				}
				return canSetStreamAccessDefaultValue;
			}
			set
			{
				this._hasBits1 |= 32;
				this.canSetStreamAccess_ = value;
			}
		}

		// Token: 0x17002728 RID: 10024
		// (get) Token: 0x06007B5C RID: 31580 RVA: 0x001DE848 File Offset: 0x001DCA48
		[DebuggerNonUserCode]
		public bool HasCanSetStreamAccess
		{
			get
			{
				return (this._hasBits1 & 32) != 0;
			}
		}

		// Token: 0x06007B5D RID: 31581 RVA: 0x001DE866 File Offset: 0x001DCA66
		[DebuggerNonUserCode]
		public void ClearCanSetStreamAccess()
		{
			this._hasBits1 &= -33;
		}

		// Token: 0x17002729 RID: 10025
		// (get) Token: 0x06007B5E RID: 31582 RVA: 0x001DE878 File Offset: 0x001DCA78
		// (set) Token: 0x06007B5F RID: 31583 RVA: 0x001DE8AA File Offset: 0x001DCAAA
		[DebuggerNonUserCode]
		public bool CanSetStreamVoiceLevel
		{
			get
			{
				bool flag = (this._hasBits1 & 64) != 0;
				bool canSetStreamVoiceLevelDefaultValue;
				if (flag)
				{
					canSetStreamVoiceLevelDefaultValue = this.canSetStreamVoiceLevel_;
				}
				else
				{
					canSetStreamVoiceLevelDefaultValue = ClubPrivilegeSet.CanSetStreamVoiceLevelDefaultValue;
				}
				return canSetStreamVoiceLevelDefaultValue;
			}
			set
			{
				this._hasBits1 |= 64;
				this.canSetStreamVoiceLevel_ = value;
			}
		}

		// Token: 0x1700272A RID: 10026
		// (get) Token: 0x06007B60 RID: 31584 RVA: 0x001DE8C4 File Offset: 0x001DCAC4
		[DebuggerNonUserCode]
		public bool HasCanSetStreamVoiceLevel
		{
			get
			{
				return (this._hasBits1 & 64) != 0;
			}
		}

		// Token: 0x06007B61 RID: 31585 RVA: 0x001DE8E2 File Offset: 0x001DCAE2
		[DebuggerNonUserCode]
		public void ClearCanSetStreamVoiceLevel()
		{
			this._hasBits1 &= -65;
		}

		// Token: 0x1700272B RID: 10027
		// (get) Token: 0x06007B62 RID: 31586 RVA: 0x001DE8F4 File Offset: 0x001DCAF4
		// (set) Token: 0x06007B63 RID: 31587 RVA: 0x001DE929 File Offset: 0x001DCB29
		[DebuggerNonUserCode]
		public bool CanCreateMessage
		{
			get
			{
				bool flag = (this._hasBits1 & 128) != 0;
				bool canCreateMessageDefaultValue;
				if (flag)
				{
					canCreateMessageDefaultValue = this.canCreateMessage_;
				}
				else
				{
					canCreateMessageDefaultValue = ClubPrivilegeSet.CanCreateMessageDefaultValue;
				}
				return canCreateMessageDefaultValue;
			}
			set
			{
				this._hasBits1 |= 128;
				this.canCreateMessage_ = value;
			}
		}

		// Token: 0x1700272C RID: 10028
		// (get) Token: 0x06007B64 RID: 31588 RVA: 0x001DE948 File Offset: 0x001DCB48
		[DebuggerNonUserCode]
		public bool HasCanCreateMessage
		{
			get
			{
				return (this._hasBits1 & 128) != 0;
			}
		}

		// Token: 0x06007B65 RID: 31589 RVA: 0x001DE969 File Offset: 0x001DCB69
		[DebuggerNonUserCode]
		public void ClearCanCreateMessage()
		{
			this._hasBits1 &= -129;
		}

		// Token: 0x1700272D RID: 10029
		// (get) Token: 0x06007B66 RID: 31590 RVA: 0x001DE980 File Offset: 0x001DCB80
		// (set) Token: 0x06007B67 RID: 31591 RVA: 0x001DE9B5 File Offset: 0x001DCBB5
		[DebuggerNonUserCode]
		public bool CanDestroyOwnMessage
		{
			get
			{
				bool flag = (this._hasBits1 & 256) != 0;
				bool canDestroyOwnMessageDefaultValue;
				if (flag)
				{
					canDestroyOwnMessageDefaultValue = this.canDestroyOwnMessage_;
				}
				else
				{
					canDestroyOwnMessageDefaultValue = ClubPrivilegeSet.CanDestroyOwnMessageDefaultValue;
				}
				return canDestroyOwnMessageDefaultValue;
			}
			set
			{
				this._hasBits1 |= 256;
				this.canDestroyOwnMessage_ = value;
			}
		}

		// Token: 0x1700272E RID: 10030
		// (get) Token: 0x06007B68 RID: 31592 RVA: 0x001DE9D4 File Offset: 0x001DCBD4
		[DebuggerNonUserCode]
		public bool HasCanDestroyOwnMessage
		{
			get
			{
				return (this._hasBits1 & 256) != 0;
			}
		}

		// Token: 0x06007B69 RID: 31593 RVA: 0x001DE9F5 File Offset: 0x001DCBF5
		[DebuggerNonUserCode]
		public void ClearCanDestroyOwnMessage()
		{
			this._hasBits1 &= -257;
		}

		// Token: 0x1700272F RID: 10031
		// (get) Token: 0x06007B6A RID: 31594 RVA: 0x001DEA0C File Offset: 0x001DCC0C
		// (set) Token: 0x06007B6B RID: 31595 RVA: 0x001DEA41 File Offset: 0x001DCC41
		[DebuggerNonUserCode]
		public bool CanDestroyOtherMessage
		{
			get
			{
				bool flag = (this._hasBits1 & 512) != 0;
				bool canDestroyOtherMessageDefaultValue;
				if (flag)
				{
					canDestroyOtherMessageDefaultValue = this.canDestroyOtherMessage_;
				}
				else
				{
					canDestroyOtherMessageDefaultValue = ClubPrivilegeSet.CanDestroyOtherMessageDefaultValue;
				}
				return canDestroyOtherMessageDefaultValue;
			}
			set
			{
				this._hasBits1 |= 512;
				this.canDestroyOtherMessage_ = value;
			}
		}

		// Token: 0x17002730 RID: 10032
		// (get) Token: 0x06007B6C RID: 31596 RVA: 0x001DEA60 File Offset: 0x001DCC60
		[DebuggerNonUserCode]
		public bool HasCanDestroyOtherMessage
		{
			get
			{
				return (this._hasBits1 & 512) != 0;
			}
		}

		// Token: 0x06007B6D RID: 31597 RVA: 0x001DEA81 File Offset: 0x001DCC81
		[DebuggerNonUserCode]
		public void ClearCanDestroyOtherMessage()
		{
			this._hasBits1 &= -513;
		}

		// Token: 0x17002731 RID: 10033
		// (get) Token: 0x06007B6E RID: 31598 RVA: 0x001DEA98 File Offset: 0x001DCC98
		// (set) Token: 0x06007B6F RID: 31599 RVA: 0x001DEACD File Offset: 0x001DCCCD
		[DebuggerNonUserCode]
		public bool CanEditOwnMessage
		{
			get
			{
				bool flag = (this._hasBits1 & 1024) != 0;
				bool canEditOwnMessageDefaultValue;
				if (flag)
				{
					canEditOwnMessageDefaultValue = this.canEditOwnMessage_;
				}
				else
				{
					canEditOwnMessageDefaultValue = ClubPrivilegeSet.CanEditOwnMessageDefaultValue;
				}
				return canEditOwnMessageDefaultValue;
			}
			set
			{
				this._hasBits1 |= 1024;
				this.canEditOwnMessage_ = value;
			}
		}

		// Token: 0x17002732 RID: 10034
		// (get) Token: 0x06007B70 RID: 31600 RVA: 0x001DEAEC File Offset: 0x001DCCEC
		[DebuggerNonUserCode]
		public bool HasCanEditOwnMessage
		{
			get
			{
				return (this._hasBits1 & 1024) != 0;
			}
		}

		// Token: 0x06007B71 RID: 31601 RVA: 0x001DEB0D File Offset: 0x001DCD0D
		[DebuggerNonUserCode]
		public void ClearCanEditOwnMessage()
		{
			this._hasBits1 &= -1025;
		}

		// Token: 0x17002733 RID: 10035
		// (get) Token: 0x06007B72 RID: 31602 RVA: 0x001DEB24 File Offset: 0x001DCD24
		// (set) Token: 0x06007B73 RID: 31603 RVA: 0x001DEB59 File Offset: 0x001DCD59
		[DebuggerNonUserCode]
		public bool CanPinMessage
		{
			get
			{
				bool flag = (this._hasBits1 & 2048) != 0;
				bool canPinMessageDefaultValue;
				if (flag)
				{
					canPinMessageDefaultValue = this.canPinMessage_;
				}
				else
				{
					canPinMessageDefaultValue = ClubPrivilegeSet.CanPinMessageDefaultValue;
				}
				return canPinMessageDefaultValue;
			}
			set
			{
				this._hasBits1 |= 2048;
				this.canPinMessage_ = value;
			}
		}

		// Token: 0x17002734 RID: 10036
		// (get) Token: 0x06007B74 RID: 31604 RVA: 0x001DEB78 File Offset: 0x001DCD78
		[DebuggerNonUserCode]
		public bool HasCanPinMessage
		{
			get
			{
				return (this._hasBits1 & 2048) != 0;
			}
		}

		// Token: 0x06007B75 RID: 31605 RVA: 0x001DEB99 File Offset: 0x001DCD99
		[DebuggerNonUserCode]
		public void ClearCanPinMessage()
		{
			this._hasBits1 &= -2049;
		}

		// Token: 0x17002735 RID: 10037
		// (get) Token: 0x06007B76 RID: 31606 RVA: 0x001DEBB0 File Offset: 0x001DCDB0
		// (set) Token: 0x06007B77 RID: 31607 RVA: 0x001DEBE5 File Offset: 0x001DCDE5
		[DebuggerNonUserCode]
		public bool CanMentionAll
		{
			get
			{
				bool flag = (this._hasBits1 & 4096) != 0;
				bool canMentionAllDefaultValue;
				if (flag)
				{
					canMentionAllDefaultValue = this.canMentionAll_;
				}
				else
				{
					canMentionAllDefaultValue = ClubPrivilegeSet.CanMentionAllDefaultValue;
				}
				return canMentionAllDefaultValue;
			}
			set
			{
				this._hasBits1 |= 4096;
				this.canMentionAll_ = value;
			}
		}

		// Token: 0x17002736 RID: 10038
		// (get) Token: 0x06007B78 RID: 31608 RVA: 0x001DEC04 File Offset: 0x001DCE04
		[DebuggerNonUserCode]
		public bool HasCanMentionAll
		{
			get
			{
				return (this._hasBits1 & 4096) != 0;
			}
		}

		// Token: 0x06007B79 RID: 31609 RVA: 0x001DEC25 File Offset: 0x001DCE25
		[DebuggerNonUserCode]
		public void ClearCanMentionAll()
		{
			this._hasBits1 &= -4097;
		}

		// Token: 0x17002737 RID: 10039
		// (get) Token: 0x06007B7A RID: 31610 RVA: 0x001DEC3C File Offset: 0x001DCE3C
		// (set) Token: 0x06007B7B RID: 31611 RVA: 0x001DEC71 File Offset: 0x001DCE71
		[DebuggerNonUserCode]
		public bool CanMentionHere
		{
			get
			{
				bool flag = (this._hasBits1 & 8192) != 0;
				bool canMentionHereDefaultValue;
				if (flag)
				{
					canMentionHereDefaultValue = this.canMentionHere_;
				}
				else
				{
					canMentionHereDefaultValue = ClubPrivilegeSet.CanMentionHereDefaultValue;
				}
				return canMentionHereDefaultValue;
			}
			set
			{
				this._hasBits1 |= 8192;
				this.canMentionHere_ = value;
			}
		}

		// Token: 0x17002738 RID: 10040
		// (get) Token: 0x06007B7C RID: 31612 RVA: 0x001DEC90 File Offset: 0x001DCE90
		[DebuggerNonUserCode]
		public bool HasCanMentionHere
		{
			get
			{
				return (this._hasBits1 & 8192) != 0;
			}
		}

		// Token: 0x06007B7D RID: 31613 RVA: 0x001DECB1 File Offset: 0x001DCEB1
		[DebuggerNonUserCode]
		public void ClearCanMentionHere()
		{
			this._hasBits1 &= -8193;
		}

		// Token: 0x17002739 RID: 10041
		// (get) Token: 0x06007B7E RID: 31614 RVA: 0x001DECC8 File Offset: 0x001DCEC8
		// (set) Token: 0x06007B7F RID: 31615 RVA: 0x001DECFD File Offset: 0x001DCEFD
		[DebuggerNonUserCode]
		public bool CanMentionMember
		{
			get
			{
				bool flag = (this._hasBits1 & 16384) != 0;
				bool canMentionMemberDefaultValue;
				if (flag)
				{
					canMentionMemberDefaultValue = this.canMentionMember_;
				}
				else
				{
					canMentionMemberDefaultValue = ClubPrivilegeSet.CanMentionMemberDefaultValue;
				}
				return canMentionMemberDefaultValue;
			}
			set
			{
				this._hasBits1 |= 16384;
				this.canMentionMember_ = value;
			}
		}

		// Token: 0x1700273A RID: 10042
		// (get) Token: 0x06007B80 RID: 31616 RVA: 0x001DED1C File Offset: 0x001DCF1C
		[DebuggerNonUserCode]
		public bool HasCanMentionMember
		{
			get
			{
				return (this._hasBits1 & 16384) != 0;
			}
		}

		// Token: 0x06007B81 RID: 31617 RVA: 0x001DED3D File Offset: 0x001DCF3D
		[DebuggerNonUserCode]
		public void ClearCanMentionMember()
		{
			this._hasBits1 &= -16385;
		}

		// Token: 0x1700273B RID: 10043
		// (get) Token: 0x06007B82 RID: 31618 RVA: 0x001DED54 File Offset: 0x001DCF54
		// (set) Token: 0x06007B83 RID: 31619 RVA: 0x001DED89 File Offset: 0x001DCF89
		[DebuggerNonUserCode]
		public bool CanMentionRole
		{
			get
			{
				bool flag = (this._hasBits1 & 32768) != 0;
				bool canMentionRoleDefaultValue;
				if (flag)
				{
					canMentionRoleDefaultValue = this.canMentionRole_;
				}
				else
				{
					canMentionRoleDefaultValue = ClubPrivilegeSet.CanMentionRoleDefaultValue;
				}
				return canMentionRoleDefaultValue;
			}
			set
			{
				this._hasBits1 |= 32768;
				this.canMentionRole_ = value;
			}
		}

		// Token: 0x1700273C RID: 10044
		// (get) Token: 0x06007B84 RID: 31620 RVA: 0x001DEDA8 File Offset: 0x001DCFA8
		[DebuggerNonUserCode]
		public bool HasCanMentionRole
		{
			get
			{
				return (this._hasBits1 & 32768) != 0;
			}
		}

		// Token: 0x06007B85 RID: 31621 RVA: 0x001DEDC9 File Offset: 0x001DCFC9
		[DebuggerNonUserCode]
		public void ClearCanMentionRole()
		{
			this._hasBits1 &= -32769;
		}

		// Token: 0x06007B86 RID: 31622 RVA: 0x001DEDE0 File Offset: 0x001DCFE0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubPrivilegeSet);
		}

		// Token: 0x06007B87 RID: 31623 RVA: 0x001DEE00 File Offset: 0x001DD000
		[DebuggerNonUserCode]
		public bool Equals(ClubPrivilegeSet other)
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
					bool flag4 = this.CanDestroy != other.CanDestroy;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.CanSetAttribute != other.CanSetAttribute;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.CanSetName != other.CanSetName;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.CanSetDescription != other.CanSetDescription;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.CanSetAvatar != other.CanSetAvatar;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.CanSetBroadcast != other.CanSetBroadcast;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.CanSetPrivacyLevel != other.CanSetPrivacyLevel;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.CanKickMember != other.CanKickMember;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.CanSetOwnMemberAttribute != other.CanSetOwnMemberAttribute;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.CanSetOtherMemberAttribute != other.CanSetOtherMemberAttribute;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.CanSetOwnVoiceState != other.CanSetOwnVoiceState;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.CanSetOwnPresenceLevel != other.CanSetOwnPresenceLevel;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.CanSetOwnWhisperLevel != other.CanSetOwnWhisperLevel;
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = this.CanSetOwnMemberNote != other.CanSetOwnMemberNote;
																		if (flag17)
																		{
																			flag2 = false;
																		}
																		else
																		{
																			bool flag18 = this.CanSetOtherMemberNote != other.CanSetOtherMemberNote;
																			if (flag18)
																			{
																				flag2 = false;
																			}
																			else
																			{
																				bool flag19 = this.CanUseVoice != other.CanUseVoice;
																				if (flag19)
																				{
																					flag2 = false;
																				}
																				else
																				{
																					bool flag20 = this.CanVoiceMuteMemberForAll != other.CanVoiceMuteMemberForAll;
																					if (flag20)
																					{
																						flag2 = false;
																					}
																					else
																					{
																						bool flag21 = this.CanGetInvitation != other.CanGetInvitation;
																						if (flag21)
																						{
																							flag2 = false;
																						}
																						else
																						{
																							bool flag22 = this.CanSendInvitation != other.CanSendInvitation;
																							if (flag22)
																							{
																								flag2 = false;
																							}
																							else
																							{
																								bool flag23 = this.CanSendGuestInvitation != other.CanSendGuestInvitation;
																								if (flag23)
																								{
																									flag2 = false;
																								}
																								else
																								{
																									bool flag24 = this.CanRevokeOwnInvitation != other.CanRevokeOwnInvitation;
																									if (flag24)
																									{
																										flag2 = false;
																									}
																									else
																									{
																										bool flag25 = this.CanRevokeOtherInvitation != other.CanRevokeOtherInvitation;
																										if (flag25)
																										{
																											flag2 = false;
																										}
																										else
																										{
																											bool flag26 = this.CanGetSuggestion != other.CanGetSuggestion;
																											if (flag26)
																											{
																												flag2 = false;
																											}
																											else
																											{
																												bool flag27 = this.CanSuggestMember != other.CanSuggestMember;
																												if (flag27)
																												{
																													flag2 = false;
																												}
																												else
																												{
																													bool flag28 = this.CanApproveMember != other.CanApproveMember;
																													if (flag28)
																													{
																														flag2 = false;
																													}
																													else
																													{
																														bool flag29 = this.CanGetTicket != other.CanGetTicket;
																														if (flag29)
																														{
																															flag2 = false;
																														}
																														else
																														{
																															bool flag30 = this.CanCreateTicket != other.CanCreateTicket;
																															if (flag30)
																															{
																																flag2 = false;
																															}
																															else
																															{
																																bool flag31 = this.CanDestroyTicket != other.CanDestroyTicket;
																																if (flag31)
																																{
																																	flag2 = false;
																																}
																																else
																																{
																																	bool flag32 = this.CanGetBan != other.CanGetBan;
																																	if (flag32)
																																	{
																																		flag2 = false;
																																	}
																																	else
																																	{
																																		bool flag33 = this.CanAddBan != other.CanAddBan;
																																		if (flag33)
																																		{
																																			flag2 = false;
																																		}
																																		else
																																		{
																																			bool flag34 = this.CanRemoveBan != other.CanRemoveBan;
																																			if (flag34)
																																			{
																																				flag2 = false;
																																			}
																																			else
																																			{
																																				bool flag35 = this.CanCreateStream != other.CanCreateStream;
																																				if (flag35)
																																				{
																																					flag2 = false;
																																				}
																																				else
																																				{
																																					bool flag36 = this.CanDestroyStream != other.CanDestroyStream;
																																					if (flag36)
																																					{
																																						flag2 = false;
																																					}
																																					else
																																					{
																																						bool flag37 = this.CanSetStreamPosition != other.CanSetStreamPosition;
																																						if (flag37)
																																						{
																																							flag2 = false;
																																						}
																																						else
																																						{
																																							bool flag38 = this.CanSetStreamAttribute != other.CanSetStreamAttribute;
																																							if (flag38)
																																							{
																																								flag2 = false;
																																							}
																																							else
																																							{
																																								bool flag39 = this.CanSetStreamName != other.CanSetStreamName;
																																								if (flag39)
																																								{
																																									flag2 = false;
																																								}
																																								else
																																								{
																																									bool flag40 = this.CanSetStreamSubject != other.CanSetStreamSubject;
																																									if (flag40)
																																									{
																																										flag2 = false;
																																									}
																																									else
																																									{
																																										bool flag41 = this.CanSetStreamAccess != other.CanSetStreamAccess;
																																										if (flag41)
																																										{
																																											flag2 = false;
																																										}
																																										else
																																										{
																																											bool flag42 = this.CanSetStreamVoiceLevel != other.CanSetStreamVoiceLevel;
																																											if (flag42)
																																											{
																																												flag2 = false;
																																											}
																																											else
																																											{
																																												bool flag43 = this.CanCreateMessage != other.CanCreateMessage;
																																												if (flag43)
																																												{
																																													flag2 = false;
																																												}
																																												else
																																												{
																																													bool flag44 = this.CanDestroyOwnMessage != other.CanDestroyOwnMessage;
																																													if (flag44)
																																													{
																																														flag2 = false;
																																													}
																																													else
																																													{
																																														bool flag45 = this.CanDestroyOtherMessage != other.CanDestroyOtherMessage;
																																														if (flag45)
																																														{
																																															flag2 = false;
																																														}
																																														else
																																														{
																																															bool flag46 = this.CanEditOwnMessage != other.CanEditOwnMessage;
																																															if (flag46)
																																															{
																																																flag2 = false;
																																															}
																																															else
																																															{
																																																bool flag47 = this.CanPinMessage != other.CanPinMessage;
																																																if (flag47)
																																																{
																																																	flag2 = false;
																																																}
																																																else
																																																{
																																																	bool flag48 = this.CanMentionAll != other.CanMentionAll;
																																																	if (flag48)
																																																	{
																																																		flag2 = false;
																																																	}
																																																	else
																																																	{
																																																		bool flag49 = this.CanMentionHere != other.CanMentionHere;
																																																		if (flag49)
																																																		{
																																																			flag2 = false;
																																																		}
																																																		else
																																																		{
																																																			bool flag50 = this.CanMentionMember != other.CanMentionMember;
																																																			if (flag50)
																																																			{
																																																				flag2 = false;
																																																			}
																																																			else
																																																			{
																																																				bool flag51 = this.CanMentionRole != other.CanMentionRole;
																																																				flag2 = !flag51 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x06007B88 RID: 31624 RVA: 0x001DF3D8 File Offset: 0x001DD5D8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasCanDestroy = this.HasCanDestroy;
			if (hasCanDestroy)
			{
				num ^= this.CanDestroy.GetHashCode();
			}
			bool hasCanSetAttribute = this.HasCanSetAttribute;
			if (hasCanSetAttribute)
			{
				num ^= this.CanSetAttribute.GetHashCode();
			}
			bool hasCanSetName = this.HasCanSetName;
			if (hasCanSetName)
			{
				num ^= this.CanSetName.GetHashCode();
			}
			bool hasCanSetDescription = this.HasCanSetDescription;
			if (hasCanSetDescription)
			{
				num ^= this.CanSetDescription.GetHashCode();
			}
			bool hasCanSetAvatar = this.HasCanSetAvatar;
			if (hasCanSetAvatar)
			{
				num ^= this.CanSetAvatar.GetHashCode();
			}
			bool hasCanSetBroadcast = this.HasCanSetBroadcast;
			if (hasCanSetBroadcast)
			{
				num ^= this.CanSetBroadcast.GetHashCode();
			}
			bool hasCanSetPrivacyLevel = this.HasCanSetPrivacyLevel;
			if (hasCanSetPrivacyLevel)
			{
				num ^= this.CanSetPrivacyLevel.GetHashCode();
			}
			bool hasCanKickMember = this.HasCanKickMember;
			if (hasCanKickMember)
			{
				num ^= this.CanKickMember.GetHashCode();
			}
			bool hasCanSetOwnMemberAttribute = this.HasCanSetOwnMemberAttribute;
			if (hasCanSetOwnMemberAttribute)
			{
				num ^= this.CanSetOwnMemberAttribute.GetHashCode();
			}
			bool hasCanSetOtherMemberAttribute = this.HasCanSetOtherMemberAttribute;
			if (hasCanSetOtherMemberAttribute)
			{
				num ^= this.CanSetOtherMemberAttribute.GetHashCode();
			}
			bool hasCanSetOwnVoiceState = this.HasCanSetOwnVoiceState;
			if (hasCanSetOwnVoiceState)
			{
				num ^= this.CanSetOwnVoiceState.GetHashCode();
			}
			bool hasCanSetOwnPresenceLevel = this.HasCanSetOwnPresenceLevel;
			if (hasCanSetOwnPresenceLevel)
			{
				num ^= this.CanSetOwnPresenceLevel.GetHashCode();
			}
			bool hasCanSetOwnWhisperLevel = this.HasCanSetOwnWhisperLevel;
			if (hasCanSetOwnWhisperLevel)
			{
				num ^= this.CanSetOwnWhisperLevel.GetHashCode();
			}
			bool hasCanSetOwnMemberNote = this.HasCanSetOwnMemberNote;
			if (hasCanSetOwnMemberNote)
			{
				num ^= this.CanSetOwnMemberNote.GetHashCode();
			}
			bool hasCanSetOtherMemberNote = this.HasCanSetOtherMemberNote;
			if (hasCanSetOtherMemberNote)
			{
				num ^= this.CanSetOtherMemberNote.GetHashCode();
			}
			bool hasCanUseVoice = this.HasCanUseVoice;
			if (hasCanUseVoice)
			{
				num ^= this.CanUseVoice.GetHashCode();
			}
			bool hasCanVoiceMuteMemberForAll = this.HasCanVoiceMuteMemberForAll;
			if (hasCanVoiceMuteMemberForAll)
			{
				num ^= this.CanVoiceMuteMemberForAll.GetHashCode();
			}
			bool hasCanGetInvitation = this.HasCanGetInvitation;
			if (hasCanGetInvitation)
			{
				num ^= this.CanGetInvitation.GetHashCode();
			}
			bool hasCanSendInvitation = this.HasCanSendInvitation;
			if (hasCanSendInvitation)
			{
				num ^= this.CanSendInvitation.GetHashCode();
			}
			bool hasCanSendGuestInvitation = this.HasCanSendGuestInvitation;
			if (hasCanSendGuestInvitation)
			{
				num ^= this.CanSendGuestInvitation.GetHashCode();
			}
			bool hasCanRevokeOwnInvitation = this.HasCanRevokeOwnInvitation;
			if (hasCanRevokeOwnInvitation)
			{
				num ^= this.CanRevokeOwnInvitation.GetHashCode();
			}
			bool hasCanRevokeOtherInvitation = this.HasCanRevokeOtherInvitation;
			if (hasCanRevokeOtherInvitation)
			{
				num ^= this.CanRevokeOtherInvitation.GetHashCode();
			}
			bool hasCanGetSuggestion = this.HasCanGetSuggestion;
			if (hasCanGetSuggestion)
			{
				num ^= this.CanGetSuggestion.GetHashCode();
			}
			bool hasCanSuggestMember = this.HasCanSuggestMember;
			if (hasCanSuggestMember)
			{
				num ^= this.CanSuggestMember.GetHashCode();
			}
			bool hasCanApproveMember = this.HasCanApproveMember;
			if (hasCanApproveMember)
			{
				num ^= this.CanApproveMember.GetHashCode();
			}
			bool hasCanGetTicket = this.HasCanGetTicket;
			if (hasCanGetTicket)
			{
				num ^= this.CanGetTicket.GetHashCode();
			}
			bool hasCanCreateTicket = this.HasCanCreateTicket;
			if (hasCanCreateTicket)
			{
				num ^= this.CanCreateTicket.GetHashCode();
			}
			bool hasCanDestroyTicket = this.HasCanDestroyTicket;
			if (hasCanDestroyTicket)
			{
				num ^= this.CanDestroyTicket.GetHashCode();
			}
			bool hasCanGetBan = this.HasCanGetBan;
			if (hasCanGetBan)
			{
				num ^= this.CanGetBan.GetHashCode();
			}
			bool hasCanAddBan = this.HasCanAddBan;
			if (hasCanAddBan)
			{
				num ^= this.CanAddBan.GetHashCode();
			}
			bool hasCanRemoveBan = this.HasCanRemoveBan;
			if (hasCanRemoveBan)
			{
				num ^= this.CanRemoveBan.GetHashCode();
			}
			bool hasCanCreateStream = this.HasCanCreateStream;
			if (hasCanCreateStream)
			{
				num ^= this.CanCreateStream.GetHashCode();
			}
			bool hasCanDestroyStream = this.HasCanDestroyStream;
			if (hasCanDestroyStream)
			{
				num ^= this.CanDestroyStream.GetHashCode();
			}
			bool hasCanSetStreamPosition = this.HasCanSetStreamPosition;
			if (hasCanSetStreamPosition)
			{
				num ^= this.CanSetStreamPosition.GetHashCode();
			}
			bool hasCanSetStreamAttribute = this.HasCanSetStreamAttribute;
			if (hasCanSetStreamAttribute)
			{
				num ^= this.CanSetStreamAttribute.GetHashCode();
			}
			bool hasCanSetStreamName = this.HasCanSetStreamName;
			if (hasCanSetStreamName)
			{
				num ^= this.CanSetStreamName.GetHashCode();
			}
			bool hasCanSetStreamSubject = this.HasCanSetStreamSubject;
			if (hasCanSetStreamSubject)
			{
				num ^= this.CanSetStreamSubject.GetHashCode();
			}
			bool hasCanSetStreamAccess = this.HasCanSetStreamAccess;
			if (hasCanSetStreamAccess)
			{
				num ^= this.CanSetStreamAccess.GetHashCode();
			}
			bool hasCanSetStreamVoiceLevel = this.HasCanSetStreamVoiceLevel;
			if (hasCanSetStreamVoiceLevel)
			{
				num ^= this.CanSetStreamVoiceLevel.GetHashCode();
			}
			bool hasCanCreateMessage = this.HasCanCreateMessage;
			if (hasCanCreateMessage)
			{
				num ^= this.CanCreateMessage.GetHashCode();
			}
			bool hasCanDestroyOwnMessage = this.HasCanDestroyOwnMessage;
			if (hasCanDestroyOwnMessage)
			{
				num ^= this.CanDestroyOwnMessage.GetHashCode();
			}
			bool hasCanDestroyOtherMessage = this.HasCanDestroyOtherMessage;
			if (hasCanDestroyOtherMessage)
			{
				num ^= this.CanDestroyOtherMessage.GetHashCode();
			}
			bool hasCanEditOwnMessage = this.HasCanEditOwnMessage;
			if (hasCanEditOwnMessage)
			{
				num ^= this.CanEditOwnMessage.GetHashCode();
			}
			bool hasCanPinMessage = this.HasCanPinMessage;
			if (hasCanPinMessage)
			{
				num ^= this.CanPinMessage.GetHashCode();
			}
			bool hasCanMentionAll = this.HasCanMentionAll;
			if (hasCanMentionAll)
			{
				num ^= this.CanMentionAll.GetHashCode();
			}
			bool hasCanMentionHere = this.HasCanMentionHere;
			if (hasCanMentionHere)
			{
				num ^= this.CanMentionHere.GetHashCode();
			}
			bool hasCanMentionMember = this.HasCanMentionMember;
			if (hasCanMentionMember)
			{
				num ^= this.CanMentionMember.GetHashCode();
			}
			bool hasCanMentionRole = this.HasCanMentionRole;
			if (hasCanMentionRole)
			{
				num ^= this.CanMentionRole.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007B89 RID: 31625 RVA: 0x001DF97C File Offset: 0x001DDB7C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007B8A RID: 31626 RVA: 0x001DF994 File Offset: 0x001DDB94
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007B8B RID: 31627 RVA: 0x001DF9A0 File Offset: 0x001DDBA0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasCanDestroy = this.HasCanDestroy;
			if (hasCanDestroy)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.CanDestroy);
			}
			bool hasCanSetAttribute = this.HasCanSetAttribute;
			if (hasCanSetAttribute)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.CanSetAttribute);
			}
			bool hasCanSetName = this.HasCanSetName;
			if (hasCanSetName)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.CanSetName);
			}
			bool hasCanSetDescription = this.HasCanSetDescription;
			if (hasCanSetDescription)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.CanSetDescription);
			}
			bool hasCanSetAvatar = this.HasCanSetAvatar;
			if (hasCanSetAvatar)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.CanSetAvatar);
			}
			bool hasCanSetBroadcast = this.HasCanSetBroadcast;
			if (hasCanSetBroadcast)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.CanSetBroadcast);
			}
			bool hasCanSetPrivacyLevel = this.HasCanSetPrivacyLevel;
			if (hasCanSetPrivacyLevel)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.CanSetPrivacyLevel);
			}
			bool hasCanKickMember = this.HasCanKickMember;
			if (hasCanKickMember)
			{
				output.WriteRawTag(240, 1);
				output.WriteBool(this.CanKickMember);
			}
			bool hasCanSetOwnMemberAttribute = this.HasCanSetOwnMemberAttribute;
			if (hasCanSetOwnMemberAttribute)
			{
				output.WriteRawTag(248, 1);
				output.WriteBool(this.CanSetOwnMemberAttribute);
			}
			bool hasCanSetOtherMemberAttribute = this.HasCanSetOtherMemberAttribute;
			if (hasCanSetOtherMemberAttribute)
			{
				output.WriteRawTag(128, 2);
				output.WriteBool(this.CanSetOtherMemberAttribute);
			}
			bool hasCanSetOwnVoiceState = this.HasCanSetOwnVoiceState;
			if (hasCanSetOwnVoiceState)
			{
				output.WriteRawTag(136, 2);
				output.WriteBool(this.CanSetOwnVoiceState);
			}
			bool hasCanSetOwnPresenceLevel = this.HasCanSetOwnPresenceLevel;
			if (hasCanSetOwnPresenceLevel)
			{
				output.WriteRawTag(144, 2);
				output.WriteBool(this.CanSetOwnPresenceLevel);
			}
			bool hasCanSetOwnWhisperLevel = this.HasCanSetOwnWhisperLevel;
			if (hasCanSetOwnWhisperLevel)
			{
				output.WriteRawTag(152, 2);
				output.WriteBool(this.CanSetOwnWhisperLevel);
			}
			bool hasCanSetOwnMemberNote = this.HasCanSetOwnMemberNote;
			if (hasCanSetOwnMemberNote)
			{
				output.WriteRawTag(160, 2);
				output.WriteBool(this.CanSetOwnMemberNote);
			}
			bool hasCanSetOtherMemberNote = this.HasCanSetOtherMemberNote;
			if (hasCanSetOtherMemberNote)
			{
				output.WriteRawTag(168, 2);
				output.WriteBool(this.CanSetOtherMemberNote);
			}
			bool hasCanUseVoice = this.HasCanUseVoice;
			if (hasCanUseVoice)
			{
				output.WriteRawTag(144, 3);
				output.WriteBool(this.CanUseVoice);
			}
			bool hasCanVoiceMuteMemberForAll = this.HasCanVoiceMuteMemberForAll;
			if (hasCanVoiceMuteMemberForAll)
			{
				output.WriteRawTag(152, 3);
				output.WriteBool(this.CanVoiceMuteMemberForAll);
			}
			bool hasCanGetInvitation = this.HasCanGetInvitation;
			if (hasCanGetInvitation)
			{
				output.WriteRawTag(176, 4);
				output.WriteBool(this.CanGetInvitation);
			}
			bool hasCanSendInvitation = this.HasCanSendInvitation;
			if (hasCanSendInvitation)
			{
				output.WriteRawTag(184, 4);
				output.WriteBool(this.CanSendInvitation);
			}
			bool hasCanSendGuestInvitation = this.HasCanSendGuestInvitation;
			if (hasCanSendGuestInvitation)
			{
				output.WriteRawTag(192, 4);
				output.WriteBool(this.CanSendGuestInvitation);
			}
			bool hasCanRevokeOwnInvitation = this.HasCanRevokeOwnInvitation;
			if (hasCanRevokeOwnInvitation)
			{
				output.WriteRawTag(200, 4);
				output.WriteBool(this.CanRevokeOwnInvitation);
			}
			bool hasCanRevokeOtherInvitation = this.HasCanRevokeOtherInvitation;
			if (hasCanRevokeOtherInvitation)
			{
				output.WriteRawTag(208, 4);
				output.WriteBool(this.CanRevokeOtherInvitation);
			}
			bool hasCanGetSuggestion = this.HasCanGetSuggestion;
			if (hasCanGetSuggestion)
			{
				output.WriteRawTag(208, 5);
				output.WriteBool(this.CanGetSuggestion);
			}
			bool hasCanSuggestMember = this.HasCanSuggestMember;
			if (hasCanSuggestMember)
			{
				output.WriteRawTag(216, 5);
				output.WriteBool(this.CanSuggestMember);
			}
			bool hasCanApproveMember = this.HasCanApproveMember;
			if (hasCanApproveMember)
			{
				output.WriteRawTag(224, 5);
				output.WriteBool(this.CanApproveMember);
			}
			bool hasCanGetTicket = this.HasCanGetTicket;
			if (hasCanGetTicket)
			{
				output.WriteRawTag(240, 6);
				output.WriteBool(this.CanGetTicket);
			}
			bool hasCanCreateTicket = this.HasCanCreateTicket;
			if (hasCanCreateTicket)
			{
				output.WriteRawTag(248, 6);
				output.WriteBool(this.CanCreateTicket);
			}
			bool hasCanDestroyTicket = this.HasCanDestroyTicket;
			if (hasCanDestroyTicket)
			{
				output.WriteRawTag(128, 7);
				output.WriteBool(this.CanDestroyTicket);
			}
			bool hasCanGetBan = this.HasCanGetBan;
			if (hasCanGetBan)
			{
				output.WriteRawTag(144, 8);
				output.WriteBool(this.CanGetBan);
			}
			bool hasCanAddBan = this.HasCanAddBan;
			if (hasCanAddBan)
			{
				output.WriteRawTag(152, 8);
				output.WriteBool(this.CanAddBan);
			}
			bool hasCanRemoveBan = this.HasCanRemoveBan;
			if (hasCanRemoveBan)
			{
				output.WriteRawTag(160, 8);
				output.WriteBool(this.CanRemoveBan);
			}
			bool hasCanCreateStream = this.HasCanCreateStream;
			if (hasCanCreateStream)
			{
				output.WriteRawTag(224, 8);
				output.WriteBool(this.CanCreateStream);
			}
			bool hasCanDestroyStream = this.HasCanDestroyStream;
			if (hasCanDestroyStream)
			{
				output.WriteRawTag(232, 8);
				output.WriteBool(this.CanDestroyStream);
			}
			bool hasCanSetStreamPosition = this.HasCanSetStreamPosition;
			if (hasCanSetStreamPosition)
			{
				output.WriteRawTag(240, 8);
				output.WriteBool(this.CanSetStreamPosition);
			}
			bool hasCanSetStreamAttribute = this.HasCanSetStreamAttribute;
			if (hasCanSetStreamAttribute)
			{
				output.WriteRawTag(248, 8);
				output.WriteBool(this.CanSetStreamAttribute);
			}
			bool hasCanSetStreamName = this.HasCanSetStreamName;
			if (hasCanSetStreamName)
			{
				output.WriteRawTag(128, 9);
				output.WriteBool(this.CanSetStreamName);
			}
			bool hasCanSetStreamSubject = this.HasCanSetStreamSubject;
			if (hasCanSetStreamSubject)
			{
				output.WriteRawTag(136, 9);
				output.WriteBool(this.CanSetStreamSubject);
			}
			bool hasCanSetStreamAccess = this.HasCanSetStreamAccess;
			if (hasCanSetStreamAccess)
			{
				output.WriteRawTag(144, 9);
				output.WriteBool(this.CanSetStreamAccess);
			}
			bool hasCanSetStreamVoiceLevel = this.HasCanSetStreamVoiceLevel;
			if (hasCanSetStreamVoiceLevel)
			{
				output.WriteRawTag(152, 9);
				output.WriteBool(this.CanSetStreamVoiceLevel);
			}
			bool hasCanCreateMessage = this.HasCanCreateMessage;
			if (hasCanCreateMessage)
			{
				output.WriteRawTag(160, 11);
				output.WriteBool(this.CanCreateMessage);
			}
			bool hasCanDestroyOwnMessage = this.HasCanDestroyOwnMessage;
			if (hasCanDestroyOwnMessage)
			{
				output.WriteRawTag(168, 11);
				output.WriteBool(this.CanDestroyOwnMessage);
			}
			bool hasCanDestroyOtherMessage = this.HasCanDestroyOtherMessage;
			if (hasCanDestroyOtherMessage)
			{
				output.WriteRawTag(176, 11);
				output.WriteBool(this.CanDestroyOtherMessage);
			}
			bool hasCanEditOwnMessage = this.HasCanEditOwnMessage;
			if (hasCanEditOwnMessage)
			{
				output.WriteRawTag(184, 11);
				output.WriteBool(this.CanEditOwnMessage);
			}
			bool hasCanPinMessage = this.HasCanPinMessage;
			if (hasCanPinMessage)
			{
				output.WriteRawTag(192, 11);
				output.WriteBool(this.CanPinMessage);
			}
			bool hasCanMentionAll = this.HasCanMentionAll;
			if (hasCanMentionAll)
			{
				output.WriteRawTag(200, 11);
				output.WriteBool(this.CanMentionAll);
			}
			bool hasCanMentionHere = this.HasCanMentionHere;
			if (hasCanMentionHere)
			{
				output.WriteRawTag(208, 11);
				output.WriteBool(this.CanMentionHere);
			}
			bool hasCanMentionMember = this.HasCanMentionMember;
			if (hasCanMentionMember)
			{
				output.WriteRawTag(216, 11);
				output.WriteBool(this.CanMentionMember);
			}
			bool hasCanMentionRole = this.HasCanMentionRole;
			if (hasCanMentionRole)
			{
				output.WriteRawTag(224, 11);
				output.WriteBool(this.CanMentionRole);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007B8C RID: 31628 RVA: 0x001E0134 File Offset: 0x001DE334
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasCanDestroy = this.HasCanDestroy;
			if (hasCanDestroy)
			{
				num += 2;
			}
			bool hasCanSetAttribute = this.HasCanSetAttribute;
			if (hasCanSetAttribute)
			{
				num += 2;
			}
			bool hasCanSetName = this.HasCanSetName;
			if (hasCanSetName)
			{
				num += 2;
			}
			bool hasCanSetDescription = this.HasCanSetDescription;
			if (hasCanSetDescription)
			{
				num += 2;
			}
			bool hasCanSetAvatar = this.HasCanSetAvatar;
			if (hasCanSetAvatar)
			{
				num += 2;
			}
			bool hasCanSetBroadcast = this.HasCanSetBroadcast;
			if (hasCanSetBroadcast)
			{
				num += 2;
			}
			bool hasCanSetPrivacyLevel = this.HasCanSetPrivacyLevel;
			if (hasCanSetPrivacyLevel)
			{
				num += 2;
			}
			bool hasCanKickMember = this.HasCanKickMember;
			if (hasCanKickMember)
			{
				num += 3;
			}
			bool hasCanSetOwnMemberAttribute = this.HasCanSetOwnMemberAttribute;
			if (hasCanSetOwnMemberAttribute)
			{
				num += 3;
			}
			bool hasCanSetOtherMemberAttribute = this.HasCanSetOtherMemberAttribute;
			if (hasCanSetOtherMemberAttribute)
			{
				num += 3;
			}
			bool hasCanSetOwnVoiceState = this.HasCanSetOwnVoiceState;
			if (hasCanSetOwnVoiceState)
			{
				num += 3;
			}
			bool hasCanSetOwnPresenceLevel = this.HasCanSetOwnPresenceLevel;
			if (hasCanSetOwnPresenceLevel)
			{
				num += 3;
			}
			bool hasCanSetOwnWhisperLevel = this.HasCanSetOwnWhisperLevel;
			if (hasCanSetOwnWhisperLevel)
			{
				num += 3;
			}
			bool hasCanSetOwnMemberNote = this.HasCanSetOwnMemberNote;
			if (hasCanSetOwnMemberNote)
			{
				num += 3;
			}
			bool hasCanSetOtherMemberNote = this.HasCanSetOtherMemberNote;
			if (hasCanSetOtherMemberNote)
			{
				num += 3;
			}
			bool hasCanUseVoice = this.HasCanUseVoice;
			if (hasCanUseVoice)
			{
				num += 3;
			}
			bool hasCanVoiceMuteMemberForAll = this.HasCanVoiceMuteMemberForAll;
			if (hasCanVoiceMuteMemberForAll)
			{
				num += 3;
			}
			bool hasCanGetInvitation = this.HasCanGetInvitation;
			if (hasCanGetInvitation)
			{
				num += 3;
			}
			bool hasCanSendInvitation = this.HasCanSendInvitation;
			if (hasCanSendInvitation)
			{
				num += 3;
			}
			bool hasCanSendGuestInvitation = this.HasCanSendGuestInvitation;
			if (hasCanSendGuestInvitation)
			{
				num += 3;
			}
			bool hasCanRevokeOwnInvitation = this.HasCanRevokeOwnInvitation;
			if (hasCanRevokeOwnInvitation)
			{
				num += 3;
			}
			bool hasCanRevokeOtherInvitation = this.HasCanRevokeOtherInvitation;
			if (hasCanRevokeOtherInvitation)
			{
				num += 3;
			}
			bool hasCanGetSuggestion = this.HasCanGetSuggestion;
			if (hasCanGetSuggestion)
			{
				num += 3;
			}
			bool hasCanSuggestMember = this.HasCanSuggestMember;
			if (hasCanSuggestMember)
			{
				num += 3;
			}
			bool hasCanApproveMember = this.HasCanApproveMember;
			if (hasCanApproveMember)
			{
				num += 3;
			}
			bool hasCanGetTicket = this.HasCanGetTicket;
			if (hasCanGetTicket)
			{
				num += 3;
			}
			bool hasCanCreateTicket = this.HasCanCreateTicket;
			if (hasCanCreateTicket)
			{
				num += 3;
			}
			bool hasCanDestroyTicket = this.HasCanDestroyTicket;
			if (hasCanDestroyTicket)
			{
				num += 3;
			}
			bool hasCanGetBan = this.HasCanGetBan;
			if (hasCanGetBan)
			{
				num += 3;
			}
			bool hasCanAddBan = this.HasCanAddBan;
			if (hasCanAddBan)
			{
				num += 3;
			}
			bool hasCanRemoveBan = this.HasCanRemoveBan;
			if (hasCanRemoveBan)
			{
				num += 3;
			}
			bool hasCanCreateStream = this.HasCanCreateStream;
			if (hasCanCreateStream)
			{
				num += 3;
			}
			bool hasCanDestroyStream = this.HasCanDestroyStream;
			if (hasCanDestroyStream)
			{
				num += 3;
			}
			bool hasCanSetStreamPosition = this.HasCanSetStreamPosition;
			if (hasCanSetStreamPosition)
			{
				num += 3;
			}
			bool hasCanSetStreamAttribute = this.HasCanSetStreamAttribute;
			if (hasCanSetStreamAttribute)
			{
				num += 3;
			}
			bool hasCanSetStreamName = this.HasCanSetStreamName;
			if (hasCanSetStreamName)
			{
				num += 3;
			}
			bool hasCanSetStreamSubject = this.HasCanSetStreamSubject;
			if (hasCanSetStreamSubject)
			{
				num += 3;
			}
			bool hasCanSetStreamAccess = this.HasCanSetStreamAccess;
			if (hasCanSetStreamAccess)
			{
				num += 3;
			}
			bool hasCanSetStreamVoiceLevel = this.HasCanSetStreamVoiceLevel;
			if (hasCanSetStreamVoiceLevel)
			{
				num += 3;
			}
			bool hasCanCreateMessage = this.HasCanCreateMessage;
			if (hasCanCreateMessage)
			{
				num += 3;
			}
			bool hasCanDestroyOwnMessage = this.HasCanDestroyOwnMessage;
			if (hasCanDestroyOwnMessage)
			{
				num += 3;
			}
			bool hasCanDestroyOtherMessage = this.HasCanDestroyOtherMessage;
			if (hasCanDestroyOtherMessage)
			{
				num += 3;
			}
			bool hasCanEditOwnMessage = this.HasCanEditOwnMessage;
			if (hasCanEditOwnMessage)
			{
				num += 3;
			}
			bool hasCanPinMessage = this.HasCanPinMessage;
			if (hasCanPinMessage)
			{
				num += 3;
			}
			bool hasCanMentionAll = this.HasCanMentionAll;
			if (hasCanMentionAll)
			{
				num += 3;
			}
			bool hasCanMentionHere = this.HasCanMentionHere;
			if (hasCanMentionHere)
			{
				num += 3;
			}
			bool hasCanMentionMember = this.HasCanMentionMember;
			if (hasCanMentionMember)
			{
				num += 3;
			}
			bool hasCanMentionRole = this.HasCanMentionRole;
			if (hasCanMentionRole)
			{
				num += 3;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007B8D RID: 31629 RVA: 0x001E04C4 File Offset: 0x001DE6C4
		[DebuggerNonUserCode]
		public void MergeFrom(ClubPrivilegeSet other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasCanDestroy = other.HasCanDestroy;
				if (hasCanDestroy)
				{
					this.CanDestroy = other.CanDestroy;
				}
				bool hasCanSetAttribute = other.HasCanSetAttribute;
				if (hasCanSetAttribute)
				{
					this.CanSetAttribute = other.CanSetAttribute;
				}
				bool hasCanSetName = other.HasCanSetName;
				if (hasCanSetName)
				{
					this.CanSetName = other.CanSetName;
				}
				bool hasCanSetDescription = other.HasCanSetDescription;
				if (hasCanSetDescription)
				{
					this.CanSetDescription = other.CanSetDescription;
				}
				bool hasCanSetAvatar = other.HasCanSetAvatar;
				if (hasCanSetAvatar)
				{
					this.CanSetAvatar = other.CanSetAvatar;
				}
				bool hasCanSetBroadcast = other.HasCanSetBroadcast;
				if (hasCanSetBroadcast)
				{
					this.CanSetBroadcast = other.CanSetBroadcast;
				}
				bool hasCanSetPrivacyLevel = other.HasCanSetPrivacyLevel;
				if (hasCanSetPrivacyLevel)
				{
					this.CanSetPrivacyLevel = other.CanSetPrivacyLevel;
				}
				bool hasCanKickMember = other.HasCanKickMember;
				if (hasCanKickMember)
				{
					this.CanKickMember = other.CanKickMember;
				}
				bool hasCanSetOwnMemberAttribute = other.HasCanSetOwnMemberAttribute;
				if (hasCanSetOwnMemberAttribute)
				{
					this.CanSetOwnMemberAttribute = other.CanSetOwnMemberAttribute;
				}
				bool hasCanSetOtherMemberAttribute = other.HasCanSetOtherMemberAttribute;
				if (hasCanSetOtherMemberAttribute)
				{
					this.CanSetOtherMemberAttribute = other.CanSetOtherMemberAttribute;
				}
				bool hasCanSetOwnVoiceState = other.HasCanSetOwnVoiceState;
				if (hasCanSetOwnVoiceState)
				{
					this.CanSetOwnVoiceState = other.CanSetOwnVoiceState;
				}
				bool hasCanSetOwnPresenceLevel = other.HasCanSetOwnPresenceLevel;
				if (hasCanSetOwnPresenceLevel)
				{
					this.CanSetOwnPresenceLevel = other.CanSetOwnPresenceLevel;
				}
				bool hasCanSetOwnWhisperLevel = other.HasCanSetOwnWhisperLevel;
				if (hasCanSetOwnWhisperLevel)
				{
					this.CanSetOwnWhisperLevel = other.CanSetOwnWhisperLevel;
				}
				bool hasCanSetOwnMemberNote = other.HasCanSetOwnMemberNote;
				if (hasCanSetOwnMemberNote)
				{
					this.CanSetOwnMemberNote = other.CanSetOwnMemberNote;
				}
				bool hasCanSetOtherMemberNote = other.HasCanSetOtherMemberNote;
				if (hasCanSetOtherMemberNote)
				{
					this.CanSetOtherMemberNote = other.CanSetOtherMemberNote;
				}
				bool hasCanUseVoice = other.HasCanUseVoice;
				if (hasCanUseVoice)
				{
					this.CanUseVoice = other.CanUseVoice;
				}
				bool hasCanVoiceMuteMemberForAll = other.HasCanVoiceMuteMemberForAll;
				if (hasCanVoiceMuteMemberForAll)
				{
					this.CanVoiceMuteMemberForAll = other.CanVoiceMuteMemberForAll;
				}
				bool hasCanGetInvitation = other.HasCanGetInvitation;
				if (hasCanGetInvitation)
				{
					this.CanGetInvitation = other.CanGetInvitation;
				}
				bool hasCanSendInvitation = other.HasCanSendInvitation;
				if (hasCanSendInvitation)
				{
					this.CanSendInvitation = other.CanSendInvitation;
				}
				bool hasCanSendGuestInvitation = other.HasCanSendGuestInvitation;
				if (hasCanSendGuestInvitation)
				{
					this.CanSendGuestInvitation = other.CanSendGuestInvitation;
				}
				bool hasCanRevokeOwnInvitation = other.HasCanRevokeOwnInvitation;
				if (hasCanRevokeOwnInvitation)
				{
					this.CanRevokeOwnInvitation = other.CanRevokeOwnInvitation;
				}
				bool hasCanRevokeOtherInvitation = other.HasCanRevokeOtherInvitation;
				if (hasCanRevokeOtherInvitation)
				{
					this.CanRevokeOtherInvitation = other.CanRevokeOtherInvitation;
				}
				bool hasCanGetSuggestion = other.HasCanGetSuggestion;
				if (hasCanGetSuggestion)
				{
					this.CanGetSuggestion = other.CanGetSuggestion;
				}
				bool hasCanSuggestMember = other.HasCanSuggestMember;
				if (hasCanSuggestMember)
				{
					this.CanSuggestMember = other.CanSuggestMember;
				}
				bool hasCanApproveMember = other.HasCanApproveMember;
				if (hasCanApproveMember)
				{
					this.CanApproveMember = other.CanApproveMember;
				}
				bool hasCanGetTicket = other.HasCanGetTicket;
				if (hasCanGetTicket)
				{
					this.CanGetTicket = other.CanGetTicket;
				}
				bool hasCanCreateTicket = other.HasCanCreateTicket;
				if (hasCanCreateTicket)
				{
					this.CanCreateTicket = other.CanCreateTicket;
				}
				bool hasCanDestroyTicket = other.HasCanDestroyTicket;
				if (hasCanDestroyTicket)
				{
					this.CanDestroyTicket = other.CanDestroyTicket;
				}
				bool hasCanGetBan = other.HasCanGetBan;
				if (hasCanGetBan)
				{
					this.CanGetBan = other.CanGetBan;
				}
				bool hasCanAddBan = other.HasCanAddBan;
				if (hasCanAddBan)
				{
					this.CanAddBan = other.CanAddBan;
				}
				bool hasCanRemoveBan = other.HasCanRemoveBan;
				if (hasCanRemoveBan)
				{
					this.CanRemoveBan = other.CanRemoveBan;
				}
				bool hasCanCreateStream = other.HasCanCreateStream;
				if (hasCanCreateStream)
				{
					this.CanCreateStream = other.CanCreateStream;
				}
				bool hasCanDestroyStream = other.HasCanDestroyStream;
				if (hasCanDestroyStream)
				{
					this.CanDestroyStream = other.CanDestroyStream;
				}
				bool hasCanSetStreamPosition = other.HasCanSetStreamPosition;
				if (hasCanSetStreamPosition)
				{
					this.CanSetStreamPosition = other.CanSetStreamPosition;
				}
				bool hasCanSetStreamAttribute = other.HasCanSetStreamAttribute;
				if (hasCanSetStreamAttribute)
				{
					this.CanSetStreamAttribute = other.CanSetStreamAttribute;
				}
				bool hasCanSetStreamName = other.HasCanSetStreamName;
				if (hasCanSetStreamName)
				{
					this.CanSetStreamName = other.CanSetStreamName;
				}
				bool hasCanSetStreamSubject = other.HasCanSetStreamSubject;
				if (hasCanSetStreamSubject)
				{
					this.CanSetStreamSubject = other.CanSetStreamSubject;
				}
				bool hasCanSetStreamAccess = other.HasCanSetStreamAccess;
				if (hasCanSetStreamAccess)
				{
					this.CanSetStreamAccess = other.CanSetStreamAccess;
				}
				bool hasCanSetStreamVoiceLevel = other.HasCanSetStreamVoiceLevel;
				if (hasCanSetStreamVoiceLevel)
				{
					this.CanSetStreamVoiceLevel = other.CanSetStreamVoiceLevel;
				}
				bool hasCanCreateMessage = other.HasCanCreateMessage;
				if (hasCanCreateMessage)
				{
					this.CanCreateMessage = other.CanCreateMessage;
				}
				bool hasCanDestroyOwnMessage = other.HasCanDestroyOwnMessage;
				if (hasCanDestroyOwnMessage)
				{
					this.CanDestroyOwnMessage = other.CanDestroyOwnMessage;
				}
				bool hasCanDestroyOtherMessage = other.HasCanDestroyOtherMessage;
				if (hasCanDestroyOtherMessage)
				{
					this.CanDestroyOtherMessage = other.CanDestroyOtherMessage;
				}
				bool hasCanEditOwnMessage = other.HasCanEditOwnMessage;
				if (hasCanEditOwnMessage)
				{
					this.CanEditOwnMessage = other.CanEditOwnMessage;
				}
				bool hasCanPinMessage = other.HasCanPinMessage;
				if (hasCanPinMessage)
				{
					this.CanPinMessage = other.CanPinMessage;
				}
				bool hasCanMentionAll = other.HasCanMentionAll;
				if (hasCanMentionAll)
				{
					this.CanMentionAll = other.CanMentionAll;
				}
				bool hasCanMentionHere = other.HasCanMentionHere;
				if (hasCanMentionHere)
				{
					this.CanMentionHere = other.CanMentionHere;
				}
				bool hasCanMentionMember = other.HasCanMentionMember;
				if (hasCanMentionMember)
				{
					this.CanMentionMember = other.CanMentionMember;
				}
				bool hasCanMentionRole = other.HasCanMentionRole;
				if (hasCanMentionRole)
				{
					this.CanMentionRole = other.CanMentionRole;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007B8E RID: 31630 RVA: 0x001E0A01 File Offset: 0x001DEC01
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007B8F RID: 31631 RVA: 0x001E0A0C File Offset: 0x001DEC0C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 728U)
				{
					if (num3 <= 272U)
					{
						if (num3 <= 112U)
						{
							if (num3 <= 88U)
							{
								if (num3 != 8U)
								{
									if (num3 != 80U)
									{
										if (num3 != 88U)
										{
											goto IL_0304;
										}
										this.CanSetName = input.ReadBool();
									}
									else
									{
										this.CanSetAttribute = input.ReadBool();
									}
								}
								else
								{
									this.CanDestroy = input.ReadBool();
								}
							}
							else if (num3 != 96U)
							{
								if (num3 != 104U)
								{
									if (num3 != 112U)
									{
										goto IL_0304;
									}
									this.CanSetBroadcast = input.ReadBool();
								}
								else
								{
									this.CanSetAvatar = input.ReadBool();
								}
							}
							else
							{
								this.CanSetDescription = input.ReadBool();
							}
						}
						else if (num3 <= 248U)
						{
							if (num3 != 120U)
							{
								if (num3 != 240U)
								{
									if (num3 != 248U)
									{
										goto IL_0304;
									}
									this.CanSetOwnMemberAttribute = input.ReadBool();
								}
								else
								{
									this.CanKickMember = input.ReadBool();
								}
							}
							else
							{
								this.CanSetPrivacyLevel = input.ReadBool();
							}
						}
						else if (num3 != 256U)
						{
							if (num3 != 264U)
							{
								if (num3 != 272U)
								{
									goto IL_0304;
								}
								this.CanSetOwnPresenceLevel = input.ReadBool();
							}
							else
							{
								this.CanSetOwnVoiceState = input.ReadBool();
							}
						}
						else
						{
							this.CanSetOtherMemberAttribute = input.ReadBool();
						}
					}
					else if (num3 <= 560U)
					{
						if (num3 <= 296U)
						{
							if (num3 != 280U)
							{
								if (num3 != 288U)
								{
									if (num3 != 296U)
									{
										goto IL_0304;
									}
									this.CanSetOtherMemberNote = input.ReadBool();
								}
								else
								{
									this.CanSetOwnMemberNote = input.ReadBool();
								}
							}
							else
							{
								this.CanSetOwnWhisperLevel = input.ReadBool();
							}
						}
						else if (num3 != 400U)
						{
							if (num3 != 408U)
							{
								if (num3 != 560U)
								{
									goto IL_0304;
								}
								this.CanGetInvitation = input.ReadBool();
							}
							else
							{
								this.CanVoiceMuteMemberForAll = input.ReadBool();
							}
						}
						else
						{
							this.CanUseVoice = input.ReadBool();
						}
					}
					else if (num3 <= 584U)
					{
						if (num3 != 568U)
						{
							if (num3 != 576U)
							{
								if (num3 != 584U)
								{
									goto IL_0304;
								}
								this.CanRevokeOwnInvitation = input.ReadBool();
							}
							else
							{
								this.CanSendGuestInvitation = input.ReadBool();
							}
						}
						else
						{
							this.CanSendInvitation = input.ReadBool();
						}
					}
					else if (num3 != 592U)
					{
						if (num3 != 720U)
						{
							if (num3 != 728U)
							{
								goto IL_0304;
							}
							this.CanSuggestMember = input.ReadBool();
						}
						else
						{
							this.CanGetSuggestion = input.ReadBool();
						}
					}
					else
					{
						this.CanRevokeOtherInvitation = input.ReadBool();
					}
				}
				else if (num3 <= 1152U)
				{
					if (num3 <= 1048U)
					{
						if (num3 <= 888U)
						{
							if (num3 != 736U)
							{
								if (num3 != 880U)
								{
									if (num3 != 888U)
									{
										goto IL_0304;
									}
									this.CanCreateTicket = input.ReadBool();
								}
								else
								{
									this.CanGetTicket = input.ReadBool();
								}
							}
							else
							{
								this.CanApproveMember = input.ReadBool();
							}
						}
						else if (num3 != 896U)
						{
							if (num3 != 1040U)
							{
								if (num3 != 1048U)
								{
									goto IL_0304;
								}
								this.CanAddBan = input.ReadBool();
							}
							else
							{
								this.CanGetBan = input.ReadBool();
							}
						}
						else
						{
							this.CanDestroyTicket = input.ReadBool();
						}
					}
					else if (num3 <= 1128U)
					{
						if (num3 != 1056U)
						{
							if (num3 != 1120U)
							{
								if (num3 != 1128U)
								{
									goto IL_0304;
								}
								this.CanDestroyStream = input.ReadBool();
							}
							else
							{
								this.CanCreateStream = input.ReadBool();
							}
						}
						else
						{
							this.CanRemoveBan = input.ReadBool();
						}
					}
					else if (num3 != 1136U)
					{
						if (num3 != 1144U)
						{
							if (num3 != 1152U)
							{
								goto IL_0304;
							}
							this.CanSetStreamName = input.ReadBool();
						}
						else
						{
							this.CanSetStreamAttribute = input.ReadBool();
						}
					}
					else
					{
						this.CanSetStreamPosition = input.ReadBool();
					}
				}
				else if (num3 <= 1456U)
				{
					if (num3 <= 1176U)
					{
						if (num3 != 1160U)
						{
							if (num3 != 1168U)
							{
								if (num3 != 1176U)
								{
									goto IL_0304;
								}
								this.CanSetStreamVoiceLevel = input.ReadBool();
							}
							else
							{
								this.CanSetStreamAccess = input.ReadBool();
							}
						}
						else
						{
							this.CanSetStreamSubject = input.ReadBool();
						}
					}
					else if (num3 != 1440U)
					{
						if (num3 != 1448U)
						{
							if (num3 != 1456U)
							{
								goto IL_0304;
							}
							this.CanDestroyOtherMessage = input.ReadBool();
						}
						else
						{
							this.CanDestroyOwnMessage = input.ReadBool();
						}
					}
					else
					{
						this.CanCreateMessage = input.ReadBool();
					}
				}
				else if (num3 <= 1480U)
				{
					if (num3 != 1464U)
					{
						if (num3 != 1472U)
						{
							if (num3 != 1480U)
							{
								goto IL_0304;
							}
							this.CanMentionAll = input.ReadBool();
						}
						else
						{
							this.CanPinMessage = input.ReadBool();
						}
					}
					else
					{
						this.CanEditOwnMessage = input.ReadBool();
					}
				}
				else if (num3 != 1488U)
				{
					if (num3 != 1496U)
					{
						if (num3 != 1504U)
						{
							goto IL_0304;
						}
						this.CanMentionRole = input.ReadBool();
					}
					else
					{
						this.CanMentionMember = input.ReadBool();
					}
				}
				else
				{
					this.CanMentionHere = input.ReadBool();
				}
				continue;
				IL_0304:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400379A RID: 14234
		private static readonly MessageParser<ClubPrivilegeSet> _parser = new MessageParser<ClubPrivilegeSet>(() => new ClubPrivilegeSet());

		// Token: 0x0400379B RID: 14235
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400379C RID: 14236
		private int _hasBits0;

		// Token: 0x0400379D RID: 14237
		private int _hasBits1;

		// Token: 0x0400379E RID: 14238
		public const int CanDestroyFieldNumber = 1;

		// Token: 0x0400379F RID: 14239
		private static readonly bool CanDestroyDefaultValue = false;

		// Token: 0x040037A0 RID: 14240
		private bool canDestroy_;

		// Token: 0x040037A1 RID: 14241
		public const int CanSetAttributeFieldNumber = 10;

		// Token: 0x040037A2 RID: 14242
		private static readonly bool CanSetAttributeDefaultValue = false;

		// Token: 0x040037A3 RID: 14243
		private bool canSetAttribute_;

		// Token: 0x040037A4 RID: 14244
		public const int CanSetNameFieldNumber = 11;

		// Token: 0x040037A5 RID: 14245
		private static readonly bool CanSetNameDefaultValue = false;

		// Token: 0x040037A6 RID: 14246
		private bool canSetName_;

		// Token: 0x040037A7 RID: 14247
		public const int CanSetDescriptionFieldNumber = 12;

		// Token: 0x040037A8 RID: 14248
		private static readonly bool CanSetDescriptionDefaultValue = false;

		// Token: 0x040037A9 RID: 14249
		private bool canSetDescription_;

		// Token: 0x040037AA RID: 14250
		public const int CanSetAvatarFieldNumber = 13;

		// Token: 0x040037AB RID: 14251
		private static readonly bool CanSetAvatarDefaultValue = false;

		// Token: 0x040037AC RID: 14252
		private bool canSetAvatar_;

		// Token: 0x040037AD RID: 14253
		public const int CanSetBroadcastFieldNumber = 14;

		// Token: 0x040037AE RID: 14254
		private static readonly bool CanSetBroadcastDefaultValue = false;

		// Token: 0x040037AF RID: 14255
		private bool canSetBroadcast_;

		// Token: 0x040037B0 RID: 14256
		public const int CanSetPrivacyLevelFieldNumber = 15;

		// Token: 0x040037B1 RID: 14257
		private static readonly bool CanSetPrivacyLevelDefaultValue = false;

		// Token: 0x040037B2 RID: 14258
		private bool canSetPrivacyLevel_;

		// Token: 0x040037B3 RID: 14259
		public const int CanKickMemberFieldNumber = 30;

		// Token: 0x040037B4 RID: 14260
		private static readonly bool CanKickMemberDefaultValue = false;

		// Token: 0x040037B5 RID: 14261
		private bool canKickMember_;

		// Token: 0x040037B6 RID: 14262
		public const int CanSetOwnMemberAttributeFieldNumber = 31;

		// Token: 0x040037B7 RID: 14263
		private static readonly bool CanSetOwnMemberAttributeDefaultValue = false;

		// Token: 0x040037B8 RID: 14264
		private bool canSetOwnMemberAttribute_;

		// Token: 0x040037B9 RID: 14265
		public const int CanSetOtherMemberAttributeFieldNumber = 32;

		// Token: 0x040037BA RID: 14266
		private static readonly bool CanSetOtherMemberAttributeDefaultValue = false;

		// Token: 0x040037BB RID: 14267
		private bool canSetOtherMemberAttribute_;

		// Token: 0x040037BC RID: 14268
		public const int CanSetOwnVoiceStateFieldNumber = 33;

		// Token: 0x040037BD RID: 14269
		private static readonly bool CanSetOwnVoiceStateDefaultValue = false;

		// Token: 0x040037BE RID: 14270
		private bool canSetOwnVoiceState_;

		// Token: 0x040037BF RID: 14271
		public const int CanSetOwnPresenceLevelFieldNumber = 34;

		// Token: 0x040037C0 RID: 14272
		private static readonly bool CanSetOwnPresenceLevelDefaultValue = false;

		// Token: 0x040037C1 RID: 14273
		private bool canSetOwnPresenceLevel_;

		// Token: 0x040037C2 RID: 14274
		public const int CanSetOwnWhisperLevelFieldNumber = 35;

		// Token: 0x040037C3 RID: 14275
		private static readonly bool CanSetOwnWhisperLevelDefaultValue = false;

		// Token: 0x040037C4 RID: 14276
		private bool canSetOwnWhisperLevel_;

		// Token: 0x040037C5 RID: 14277
		public const int CanSetOwnMemberNoteFieldNumber = 36;

		// Token: 0x040037C6 RID: 14278
		private static readonly bool CanSetOwnMemberNoteDefaultValue = false;

		// Token: 0x040037C7 RID: 14279
		private bool canSetOwnMemberNote_;

		// Token: 0x040037C8 RID: 14280
		public const int CanSetOtherMemberNoteFieldNumber = 37;

		// Token: 0x040037C9 RID: 14281
		private static readonly bool CanSetOtherMemberNoteDefaultValue = false;

		// Token: 0x040037CA RID: 14282
		private bool canSetOtherMemberNote_;

		// Token: 0x040037CB RID: 14283
		public const int CanUseVoiceFieldNumber = 50;

		// Token: 0x040037CC RID: 14284
		private static readonly bool CanUseVoiceDefaultValue = false;

		// Token: 0x040037CD RID: 14285
		private bool canUseVoice_;

		// Token: 0x040037CE RID: 14286
		public const int CanVoiceMuteMemberForAllFieldNumber = 51;

		// Token: 0x040037CF RID: 14287
		private static readonly bool CanVoiceMuteMemberForAllDefaultValue = false;

		// Token: 0x040037D0 RID: 14288
		private bool canVoiceMuteMemberForAll_;

		// Token: 0x040037D1 RID: 14289
		public const int CanGetInvitationFieldNumber = 70;

		// Token: 0x040037D2 RID: 14290
		private static readonly bool CanGetInvitationDefaultValue = false;

		// Token: 0x040037D3 RID: 14291
		private bool canGetInvitation_;

		// Token: 0x040037D4 RID: 14292
		public const int CanSendInvitationFieldNumber = 71;

		// Token: 0x040037D5 RID: 14293
		private static readonly bool CanSendInvitationDefaultValue = false;

		// Token: 0x040037D6 RID: 14294
		private bool canSendInvitation_;

		// Token: 0x040037D7 RID: 14295
		public const int CanSendGuestInvitationFieldNumber = 72;

		// Token: 0x040037D8 RID: 14296
		private static readonly bool CanSendGuestInvitationDefaultValue = false;

		// Token: 0x040037D9 RID: 14297
		private bool canSendGuestInvitation_;

		// Token: 0x040037DA RID: 14298
		public const int CanRevokeOwnInvitationFieldNumber = 73;

		// Token: 0x040037DB RID: 14299
		private static readonly bool CanRevokeOwnInvitationDefaultValue = false;

		// Token: 0x040037DC RID: 14300
		private bool canRevokeOwnInvitation_;

		// Token: 0x040037DD RID: 14301
		public const int CanRevokeOtherInvitationFieldNumber = 74;

		// Token: 0x040037DE RID: 14302
		private static readonly bool CanRevokeOtherInvitationDefaultValue = false;

		// Token: 0x040037DF RID: 14303
		private bool canRevokeOtherInvitation_;

		// Token: 0x040037E0 RID: 14304
		public const int CanGetSuggestionFieldNumber = 90;

		// Token: 0x040037E1 RID: 14305
		private static readonly bool CanGetSuggestionDefaultValue = false;

		// Token: 0x040037E2 RID: 14306
		private bool canGetSuggestion_;

		// Token: 0x040037E3 RID: 14307
		public const int CanSuggestMemberFieldNumber = 91;

		// Token: 0x040037E4 RID: 14308
		private static readonly bool CanSuggestMemberDefaultValue = false;

		// Token: 0x040037E5 RID: 14309
		private bool canSuggestMember_;

		// Token: 0x040037E6 RID: 14310
		public const int CanApproveMemberFieldNumber = 92;

		// Token: 0x040037E7 RID: 14311
		private static readonly bool CanApproveMemberDefaultValue = false;

		// Token: 0x040037E8 RID: 14312
		private bool canApproveMember_;

		// Token: 0x040037E9 RID: 14313
		public const int CanGetTicketFieldNumber = 110;

		// Token: 0x040037EA RID: 14314
		private static readonly bool CanGetTicketDefaultValue = false;

		// Token: 0x040037EB RID: 14315
		private bool canGetTicket_;

		// Token: 0x040037EC RID: 14316
		public const int CanCreateTicketFieldNumber = 111;

		// Token: 0x040037ED RID: 14317
		private static readonly bool CanCreateTicketDefaultValue = false;

		// Token: 0x040037EE RID: 14318
		private bool canCreateTicket_;

		// Token: 0x040037EF RID: 14319
		public const int CanDestroyTicketFieldNumber = 112;

		// Token: 0x040037F0 RID: 14320
		private static readonly bool CanDestroyTicketDefaultValue = false;

		// Token: 0x040037F1 RID: 14321
		private bool canDestroyTicket_;

		// Token: 0x040037F2 RID: 14322
		public const int CanGetBanFieldNumber = 130;

		// Token: 0x040037F3 RID: 14323
		private static readonly bool CanGetBanDefaultValue = false;

		// Token: 0x040037F4 RID: 14324
		private bool canGetBan_;

		// Token: 0x040037F5 RID: 14325
		public const int CanAddBanFieldNumber = 131;

		// Token: 0x040037F6 RID: 14326
		private static readonly bool CanAddBanDefaultValue = false;

		// Token: 0x040037F7 RID: 14327
		private bool canAddBan_;

		// Token: 0x040037F8 RID: 14328
		public const int CanRemoveBanFieldNumber = 132;

		// Token: 0x040037F9 RID: 14329
		private static readonly bool CanRemoveBanDefaultValue = false;

		// Token: 0x040037FA RID: 14330
		private bool canRemoveBan_;

		// Token: 0x040037FB RID: 14331
		public const int CanCreateStreamFieldNumber = 140;

		// Token: 0x040037FC RID: 14332
		private static readonly bool CanCreateStreamDefaultValue = false;

		// Token: 0x040037FD RID: 14333
		private bool canCreateStream_;

		// Token: 0x040037FE RID: 14334
		public const int CanDestroyStreamFieldNumber = 141;

		// Token: 0x040037FF RID: 14335
		private static readonly bool CanDestroyStreamDefaultValue = false;

		// Token: 0x04003800 RID: 14336
		private bool canDestroyStream_;

		// Token: 0x04003801 RID: 14337
		public const int CanSetStreamPositionFieldNumber = 142;

		// Token: 0x04003802 RID: 14338
		private static readonly bool CanSetStreamPositionDefaultValue = false;

		// Token: 0x04003803 RID: 14339
		private bool canSetStreamPosition_;

		// Token: 0x04003804 RID: 14340
		public const int CanSetStreamAttributeFieldNumber = 143;

		// Token: 0x04003805 RID: 14341
		private static readonly bool CanSetStreamAttributeDefaultValue = false;

		// Token: 0x04003806 RID: 14342
		private bool canSetStreamAttribute_;

		// Token: 0x04003807 RID: 14343
		public const int CanSetStreamNameFieldNumber = 144;

		// Token: 0x04003808 RID: 14344
		private static readonly bool CanSetStreamNameDefaultValue = false;

		// Token: 0x04003809 RID: 14345
		private bool canSetStreamName_;

		// Token: 0x0400380A RID: 14346
		public const int CanSetStreamSubjectFieldNumber = 145;

		// Token: 0x0400380B RID: 14347
		private static readonly bool CanSetStreamSubjectDefaultValue = false;

		// Token: 0x0400380C RID: 14348
		private bool canSetStreamSubject_;

		// Token: 0x0400380D RID: 14349
		public const int CanSetStreamAccessFieldNumber = 146;

		// Token: 0x0400380E RID: 14350
		private static readonly bool CanSetStreamAccessDefaultValue = false;

		// Token: 0x0400380F RID: 14351
		private bool canSetStreamAccess_;

		// Token: 0x04003810 RID: 14352
		public const int CanSetStreamVoiceLevelFieldNumber = 147;

		// Token: 0x04003811 RID: 14353
		private static readonly bool CanSetStreamVoiceLevelDefaultValue = false;

		// Token: 0x04003812 RID: 14354
		private bool canSetStreamVoiceLevel_;

		// Token: 0x04003813 RID: 14355
		public const int CanCreateMessageFieldNumber = 180;

		// Token: 0x04003814 RID: 14356
		private static readonly bool CanCreateMessageDefaultValue = false;

		// Token: 0x04003815 RID: 14357
		private bool canCreateMessage_;

		// Token: 0x04003816 RID: 14358
		public const int CanDestroyOwnMessageFieldNumber = 181;

		// Token: 0x04003817 RID: 14359
		private static readonly bool CanDestroyOwnMessageDefaultValue = false;

		// Token: 0x04003818 RID: 14360
		private bool canDestroyOwnMessage_;

		// Token: 0x04003819 RID: 14361
		public const int CanDestroyOtherMessageFieldNumber = 182;

		// Token: 0x0400381A RID: 14362
		private static readonly bool CanDestroyOtherMessageDefaultValue = false;

		// Token: 0x0400381B RID: 14363
		private bool canDestroyOtherMessage_;

		// Token: 0x0400381C RID: 14364
		public const int CanEditOwnMessageFieldNumber = 183;

		// Token: 0x0400381D RID: 14365
		private static readonly bool CanEditOwnMessageDefaultValue = false;

		// Token: 0x0400381E RID: 14366
		private bool canEditOwnMessage_;

		// Token: 0x0400381F RID: 14367
		public const int CanPinMessageFieldNumber = 184;

		// Token: 0x04003820 RID: 14368
		private static readonly bool CanPinMessageDefaultValue = false;

		// Token: 0x04003821 RID: 14369
		private bool canPinMessage_;

		// Token: 0x04003822 RID: 14370
		public const int CanMentionAllFieldNumber = 185;

		// Token: 0x04003823 RID: 14371
		private static readonly bool CanMentionAllDefaultValue = false;

		// Token: 0x04003824 RID: 14372
		private bool canMentionAll_;

		// Token: 0x04003825 RID: 14373
		public const int CanMentionHereFieldNumber = 186;

		// Token: 0x04003826 RID: 14374
		private static readonly bool CanMentionHereDefaultValue = false;

		// Token: 0x04003827 RID: 14375
		private bool canMentionHere_;

		// Token: 0x04003828 RID: 14376
		public const int CanMentionMemberFieldNumber = 187;

		// Token: 0x04003829 RID: 14377
		private static readonly bool CanMentionMemberDefaultValue = false;

		// Token: 0x0400382A RID: 14378
		private bool canMentionMember_;

		// Token: 0x0400382B RID: 14379
		public const int CanMentionRoleFieldNumber = 188;

		// Token: 0x0400382C RID: 14380
		private static readonly bool CanMentionRoleDefaultValue = false;

		// Token: 0x0400382D RID: 14381
		private bool canMentionRole_;
	}
}
