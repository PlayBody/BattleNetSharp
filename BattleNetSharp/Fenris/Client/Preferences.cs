using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Client
{
	// Token: 0x0200011A RID: 282
	public sealed class Preferences : IMessage<Preferences>, IMessage, IEquatable<Preferences>, IDeepCloneable<Preferences>, IBufferMessage
	{
		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06001AE7 RID: 6887 RVA: 0x00061FE0 File Offset: 0x000601E0
		[DebuggerNonUserCode]
		public static MessageParser<Preferences> Parser
		{
			get
			{
				return Preferences._parser;
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06001AE8 RID: 6888 RVA: 0x00061FF8 File Offset: 0x000601F8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SettingsReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06001AE9 RID: 6889 RVA: 0x0006201C File Offset: 0x0006021C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Preferences.Descriptor;
			}
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x00062033 File Offset: 0x00060233
		[DebuggerNonUserCode]
		public Preferences()
		{
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x00062060 File Offset: 0x00060260
		[DebuggerNonUserCode]
		public Preferences(Preferences other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.version_ = other.version_;
			this.flags_ = other.flags_;
			this.deprecatedItemsOnGroundSetting_ = other.deprecatedItemsOnGroundSetting_;
			this.actionBindingHireling_ = ((other.actionBindingHireling_ != null) ? other.actionBindingHireling_.Clone() : null);
			this.actionBindingSkills_ = ((other.actionBindingSkills_ != null) ? other.actionBindingSkills_.Clone() : null);
			this.actionBindingAcceptPartyInviteRequest_ = ((other.actionBindingAcceptPartyInviteRequest_ != null) ? other.actionBindingAcceptPartyInviteRequest_.Clone() : null);
			this.actionBindingLore_ = ((other.actionBindingLore_ != null) ? other.actionBindingLore_.Clone() : null);
			this.actionBindingSocial_ = ((other.actionBindingSocial_ != null) ? other.actionBindingSocial_.Clone() : null);
			this.actionBindingHelp_ = ((other.actionBindingHelp_ != null) ? other.actionBindingHelp_.Clone() : null);
			this.actionBindingRecentplayers_ = ((other.actionBindingRecentplayers_ != null) ? other.actionBindingRecentplayers_.Clone() : null);
			this.actionBindingChatlobby_ = ((other.actionBindingChatlobby_ != null) ? other.actionBindingChatlobby_.Clone() : null);
			this.actionBindingAchievements_ = ((other.actionBindingAchievements_ != null) ? other.actionBindingAchievements_.Clone() : null);
			this.actionBindingProfile_ = ((other.actionBindingProfile_ != null) ? other.actionBindingProfile_.Clone() : null);
			this.actionBindingEquippables_ = ((other.actionBindingEquippables_ != null) ? other.actionBindingEquippables_.Clone() : null);
			this.actionBindingConsole_ = ((other.actionBindingConsole_ != null) ? other.actionBindingConsole_.Clone() : null);
			this.actionBindingMap_ = ((other.actionBindingMap_ != null) ? other.actionBindingMap_.Clone() : null);
			this.actionBindingSkillTree_ = ((other.actionBindingSkillTree_ != null) ? other.actionBindingSkillTree_.Clone() : null);
			this.actionBindingToggleplayerhpbars_ = ((other.actionBindingToggleplayerhpbars_ != null) ? other.actionBindingToggleplayerhpbars_.Clone() : null);
			this.actionBindingToggledamagenumbers_ = ((other.actionBindingToggledamagenumbers_ != null) ? other.actionBindingToggledamagenumbers_.Clone() : null);
			this.actionBindingToggleitemsonground_ = ((other.actionBindingToggleitemsonground_ != null) ? other.actionBindingToggleitemsonground_.Clone() : null);
			this.actionBindingRewhisper_ = ((other.actionBindingRewhisper_ != null) ? other.actionBindingRewhisper_.Clone() : null);
			this.actionBindingWhisperreply_ = ((other.actionBindingWhisperreply_ != null) ? other.actionBindingWhisperreply_.Clone() : null);
			this.actionBindingVoiceptt_ = ((other.actionBindingVoiceptt_ != null) ? other.actionBindingVoiceptt_.Clone() : null);
			this.actionBindingSocialwheel_ = ((other.actionBindingSocialwheel_ != null) ? other.actionBindingSocialwheel_.Clone() : null);
			this.actionBindingFastquesttrack_ = ((other.actionBindingFastquesttrack_ != null) ? other.actionBindingFastquesttrack_.Clone() : null);
			this.actionBindingToggleLfdCompanions_ = ((other.actionBindingToggleLfdCompanions_ != null) ? other.actionBindingToggleLfdCompanions_.Clone() : null);
			this.actionBindingCollections_ = ((other.actionBindingCollections_ != null) ? other.actionBindingCollections_.Clone() : null);
			this.actionBindingSocialwheelLeft_ = other.actionBindingSocialwheelLeft_.Clone();
			this.actionBindingSocialwheelMiddle_ = other.actionBindingSocialwheelMiddle_.Clone();
			this.actionBindingSocialwheelRight_ = other.actionBindingSocialwheelRight_.Clone();
			this.actionBindingSocialwheelPageBackward_ = ((other.actionBindingSocialwheelPageBackward_ != null) ? other.actionBindingSocialwheelPageBackward_.Clone() : null);
			this.actionBindingSocialwheelPageForward_ = ((other.actionBindingSocialwheelPageForward_ != null) ? other.actionBindingSocialwheelPageForward_.Clone() : null);
			this.actionBindingAbilities_ = ((other.actionBindingAbilities_ != null) ? other.actionBindingAbilities_.Clone() : null);
			this.actionBindingReportBug_ = ((other.actionBindingReportBug_ != null) ? other.actionBindingReportBug_.Clone() : null);
			this.actionBindingReportContent_ = ((other.actionBindingReportContent_ != null) ? other.actionBindingReportContent_.Clone() : null);
			this.actionBindingJoinSpeechToTextChat_ = ((other.actionBindingJoinSpeechToTextChat_ != null) ? other.actionBindingJoinSpeechToTextChat_.Clone() : null);
			this.actionBindingTtsSkipCurrentUtterance_ = ((other.actionBindingTtsSkipCurrentUtterance_ != null) ? other.actionBindingTtsSkipCurrentUtterance_.Clone() : null);
			this.actionBindingTtsCancelAllUtterances_ = ((other.actionBindingTtsCancelAllUtterances_ != null) ? other.actionBindingTtsCancelAllUtterances_.Clone() : null);
			this.actionBindingScreenReaderSkipLine_ = ((other.actionBindingScreenReaderSkipLine_ != null) ? other.actionBindingScreenReaderSkipLine_.Clone() : null);
			this.actionBindingStore_ = ((other.actionBindingStore_ != null) ? other.actionBindingStore_.Clone() : null);
			this.actionBindingMountSpur_ = ((other.actionBindingMountSpur_ != null) ? other.actionBindingMountSpur_.Clone() : null);
			this.actionBindingMountDismount_ = ((other.actionBindingMountDismount_ != null) ? other.actionBindingMountDismount_.Clone() : null);
			this.actionBindingMountCombatDismount_ = ((other.actionBindingMountCombatDismount_ != null) ? other.actionBindingMountCombatDismount_.Clone() : null);
			this.actionBindingToggleZoom_ = ((other.actionBindingToggleZoom_ != null) ? other.actionBindingToggleZoom_.Clone() : null);
			this.actionBindingHoldposition_ = ((other.actionBindingHoldposition_ != null) ? other.actionBindingHoldposition_.Clone() : null);
			this.actionBindingSystemmastervolumeup_ = ((other.actionBindingSystemmastervolumeup_ != null) ? other.actionBindingSystemmastervolumeup_.Clone() : null);
			this.actionBindingSystemmastervolumedown_ = ((other.actionBindingSystemmastervolumedown_ != null) ? other.actionBindingSystemmastervolumedown_.Clone() : null);
			this.actionBindingSystemtogglemusic_ = ((other.actionBindingSystemtogglemusic_ != null) ? other.actionBindingSystemtogglemusic_.Clone() : null);
			this.actionBindingSystemtogglesound_ = ((other.actionBindingSystemtogglesound_ != null) ? other.actionBindingSystemtogglesound_.Clone() : null);
			this.actionBindingSystemscreenshot_ = ((other.actionBindingSystemscreenshot_ != null) ? other.actionBindingSystemscreenshot_.Clone() : null);
			this.actionBindingSystemtogglefps_ = ((other.actionBindingSystemtogglefps_ != null) ? other.actionBindingSystemtogglefps_.Clone() : null);
			this.actionBindingChatpageup_ = ((other.actionBindingChatpageup_ != null) ? other.actionBindingChatpageup_.Clone() : null);
			this.actionBindingChatpagedown_ = ((other.actionBindingChatpagedown_ != null) ? other.actionBindingChatpagedown_.Clone() : null);
			this.actionBindingGroups_ = ((other.actionBindingGroups_ != null) ? other.actionBindingGroups_.Clone() : null);
			this.actionBindingClan_ = ((other.actionBindingClan_ != null) ? other.actionBindingClan_.Clone() : null);
			this.actionBindingChatNextView_ = ((other.actionBindingChatNextView_ != null) ? other.actionBindingChatNextView_.Clone() : null);
			this.actionBindingChatPreviousView_ = ((other.actionBindingChatPreviousView_ != null) ? other.actionBindingChatPreviousView_.Clone() : null);
			this.actionBindingLeaderboards_ = ((other.actionBindingLeaderboards_ != null) ? other.actionBindingLeaderboards_.Clone() : null);
			this.actionBindingChatResetFade_ = ((other.actionBindingChatResetFade_ != null) ? other.actionBindingChatResetFade_.Clone() : null);
			this.actionBindingQuests_ = ((other.actionBindingQuests_ != null) ? other.actionBindingQuests_.Clone() : null);
			this.actionBindingQuestsToggle_ = ((other.actionBindingQuestsToggle_ != null) ? other.actionBindingQuestsToggle_.Clone() : null);
			this.actionBindingRun_ = ((other.actionBindingRun_ != null) ? other.actionBindingRun_.Clone() : null);
			this.actionBindingInteract_ = ((other.actionBindingInteract_ != null) ? other.actionBindingInteract_.Clone() : null);
			this.actionBindingPrimary_ = ((other.actionBindingPrimary_ != null) ? other.actionBindingPrimary_.Clone() : null);
			this.actionBindingSecondary_ = ((other.actionBindingSecondary_ != null) ? other.actionBindingSecondary_.Clone() : null);
			this.actionBindingSkill1_ = ((other.actionBindingSkill1_ != null) ? other.actionBindingSkill1_.Clone() : null);
			this.actionBindingSkill2_ = ((other.actionBindingSkill2_ != null) ? other.actionBindingSkill2_.Clone() : null);
			this.actionBindingSkill3_ = ((other.actionBindingSkill3_ != null) ? other.actionBindingSkill3_.Clone() : null);
			this.actionBindingSkill4_ = ((other.actionBindingSkill4_ != null) ? other.actionBindingSkill4_.Clone() : null);
			this.actionBindingMount_ = ((other.actionBindingMount_ != null) ? other.actionBindingMount_.Clone() : null);
			this.actionBindingEvade_ = ((other.actionBindingEvade_ != null) ? other.actionBindingEvade_.Clone() : null);
			this.actionBindingUseItem_ = ((other.actionBindingUseItem_ != null) ? other.actionBindingUseItem_.Clone() : null);
			this.actionBindingCenterCamera_ = ((other.actionBindingCenterCamera_ != null) ? other.actionBindingCenterCamera_.Clone() : null);
			this.actionBindingDebugCamera_ = ((other.actionBindingDebugCamera_ != null) ? other.actionBindingDebugCamera_.Clone() : null);
			this.actionBindingSocialInteract_ = ((other.actionBindingSocialInteract_ != null) ? other.actionBindingSocialInteract_.Clone() : null);
			this.actionBindingAcceptPartyInvite_ = ((other.actionBindingAcceptPartyInvite_ != null) ? other.actionBindingAcceptPartyInvite_.Clone() : null);
			this.actionBindingLockTarget_ = ((other.actionBindingLockTarget_ != null) ? other.actionBindingLockTarget_.Clone() : null);
			this.actionBindingTownPortal_ = ((other.actionBindingTownPortal_ != null) ? other.actionBindingTownPortal_.Clone() : null);
			this.actionBindingForceMove_ = ((other.actionBindingForceMove_ != null) ? other.actionBindingForceMove_.Clone() : null);
			this.actionBindingClassScreen_ = ((other.actionBindingClassScreen_ != null) ? other.actionBindingClassScreen_.Clone() : null);
			this.actionBindingCycleLockTarget_ = ((other.actionBindingCycleLockTarget_ != null) ? other.actionBindingCycleLockTarget_.Clone() : null);
			this.notifyDuration_ = other.notifyDuration_;
			this.keybindingVersion_ = other.keybindingVersion_;
			this.flags2_ = other.flags2_;
			this.controlScheme_ = other.controlScheme_;
			this.controllerButtonBindingVersion_ = other.controllerButtonBindingVersion_;
			this.controllerBindingsXinput_ = ((other.controllerBindingsXinput_ != null) ? other.controllerBindingsXinput_.Clone() : null);
			this.controllerBindingsPs4_ = ((other.controllerBindingsPs4_ != null) ? other.controllerBindingsPs4_.Clone() : null);
			this.controllerBindingsNx64_ = ((other.controllerBindingsNx64_ != null) ? other.controllerBindingsNx64_.Clone() : null);
			this.chatBackgroundOpacityWhenActive_ = other.chatBackgroundOpacityWhenActive_;
			this.chatTimestampFormat_ = other.chatTimestampFormat_;
			this.itemLabelOnDropDuration_ = other.itemLabelOnDropDuration_;
			this.itemLabelDisplayMode_ = other.itemLabelDisplayMode_;
			this.controllerCursorSensitivity_ = other.controllerCursorSensitivity_;
			this.controllerInnerDeadZone_ = other.controllerInnerDeadZone_;
			this.controllerOuterDeadZone_ = other.controllerOuterDeadZone_;
			this.powerToggleMode_ = other.powerToggleMode_;
			this.socialWheelActivationStyle_ = other.socialWheelActivationStyle_;
			this.monsterHealthBarMode_ = other.monsterHealthBarMode_;
			this.holdPositionInputMode_ = other.holdPositionInputMode_;
			this.controllerBindingsPs5_ = ((other.controllerBindingsPs5_ != null) ? other.controllerBindingsPs5_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x00062A50 File Offset: 0x00060C50
		[DebuggerNonUserCode]
		public Preferences Clone()
		{
			return new Preferences(this);
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06001AED RID: 6893 RVA: 0x00062A68 File Offset: 0x00060C68
		// (set) Token: 0x06001AEE RID: 6894 RVA: 0x00062A99 File Offset: 0x00060C99
		[DebuggerNonUserCode]
		public int Version
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int versionDefaultValue;
				if (flag)
				{
					versionDefaultValue = this.version_;
				}
				else
				{
					versionDefaultValue = Preferences.VersionDefaultValue;
				}
				return versionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.version_ = value;
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06001AEF RID: 6895 RVA: 0x00062AB4 File Offset: 0x00060CB4
		[DebuggerNonUserCode]
		public bool HasVersion
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x00062AD1 File Offset: 0x00060CD1
		[DebuggerNonUserCode]
		public void ClearVersion()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06001AF1 RID: 6897 RVA: 0x00062AE4 File Offset: 0x00060CE4
		// (set) Token: 0x06001AF2 RID: 6898 RVA: 0x00062B15 File Offset: 0x00060D15
		[DebuggerNonUserCode]
		public uint Flags
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint flagsDefaultValue;
				if (flag)
				{
					flagsDefaultValue = this.flags_;
				}
				else
				{
					flagsDefaultValue = Preferences.FlagsDefaultValue;
				}
				return flagsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.flags_ = value;
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06001AF3 RID: 6899 RVA: 0x00062B30 File Offset: 0x00060D30
		[DebuggerNonUserCode]
		public bool HasFlags
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x00062B4D File Offset: 0x00060D4D
		[DebuggerNonUserCode]
		public void ClearFlags()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06001AF5 RID: 6901 RVA: 0x00062B60 File Offset: 0x00060D60
		// (set) Token: 0x06001AF6 RID: 6902 RVA: 0x00062B91 File Offset: 0x00060D91
		[DebuggerNonUserCode]
		public uint DeprecatedItemsOnGroundSetting
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint deprecatedItemsOnGroundSettingDefaultValue;
				if (flag)
				{
					deprecatedItemsOnGroundSettingDefaultValue = this.deprecatedItemsOnGroundSetting_;
				}
				else
				{
					deprecatedItemsOnGroundSettingDefaultValue = Preferences.DeprecatedItemsOnGroundSettingDefaultValue;
				}
				return deprecatedItemsOnGroundSettingDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.deprecatedItemsOnGroundSetting_ = value;
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06001AF7 RID: 6903 RVA: 0x00062BAC File Offset: 0x00060DAC
		[DebuggerNonUserCode]
		public bool HasDeprecatedItemsOnGroundSetting
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x00062BC9 File Offset: 0x00060DC9
		[DebuggerNonUserCode]
		public void ClearDeprecatedItemsOnGroundSetting()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06001AF9 RID: 6905 RVA: 0x00062BDC File Offset: 0x00060DDC
		// (set) Token: 0x06001AFA RID: 6906 RVA: 0x00062BF4 File Offset: 0x00060DF4
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingHireling
		{
			get
			{
				return this.actionBindingHireling_;
			}
			set
			{
				this.actionBindingHireling_ = value;
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06001AFB RID: 6907 RVA: 0x00062C00 File Offset: 0x00060E00
		// (set) Token: 0x06001AFC RID: 6908 RVA: 0x00062C18 File Offset: 0x00060E18
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingSkills
		{
			get
			{
				return this.actionBindingSkills_;
			}
			set
			{
				this.actionBindingSkills_ = value;
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06001AFD RID: 6909 RVA: 0x00062C24 File Offset: 0x00060E24
		// (set) Token: 0x06001AFE RID: 6910 RVA: 0x00062C3C File Offset: 0x00060E3C
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingAcceptPartyInviteRequest
		{
			get
			{
				return this.actionBindingAcceptPartyInviteRequest_;
			}
			set
			{
				this.actionBindingAcceptPartyInviteRequest_ = value;
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06001AFF RID: 6911 RVA: 0x00062C48 File Offset: 0x00060E48
		// (set) Token: 0x06001B00 RID: 6912 RVA: 0x00062C60 File Offset: 0x00060E60
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingLore
		{
			get
			{
				return this.actionBindingLore_;
			}
			set
			{
				this.actionBindingLore_ = value;
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06001B01 RID: 6913 RVA: 0x00062C6C File Offset: 0x00060E6C
		// (set) Token: 0x06001B02 RID: 6914 RVA: 0x00062C84 File Offset: 0x00060E84
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingSocial
		{
			get
			{
				return this.actionBindingSocial_;
			}
			set
			{
				this.actionBindingSocial_ = value;
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06001B03 RID: 6915 RVA: 0x00062C90 File Offset: 0x00060E90
		// (set) Token: 0x06001B04 RID: 6916 RVA: 0x00062CA8 File Offset: 0x00060EA8
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingHelp
		{
			get
			{
				return this.actionBindingHelp_;
			}
			set
			{
				this.actionBindingHelp_ = value;
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06001B05 RID: 6917 RVA: 0x00062CB4 File Offset: 0x00060EB4
		// (set) Token: 0x06001B06 RID: 6918 RVA: 0x00062CCC File Offset: 0x00060ECC
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingRecentplayers
		{
			get
			{
				return this.actionBindingRecentplayers_;
			}
			set
			{
				this.actionBindingRecentplayers_ = value;
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06001B07 RID: 6919 RVA: 0x00062CD8 File Offset: 0x00060ED8
		// (set) Token: 0x06001B08 RID: 6920 RVA: 0x00062CF0 File Offset: 0x00060EF0
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingChatlobby
		{
			get
			{
				return this.actionBindingChatlobby_;
			}
			set
			{
				this.actionBindingChatlobby_ = value;
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06001B09 RID: 6921 RVA: 0x00062CFC File Offset: 0x00060EFC
		// (set) Token: 0x06001B0A RID: 6922 RVA: 0x00062D14 File Offset: 0x00060F14
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingAchievements
		{
			get
			{
				return this.actionBindingAchievements_;
			}
			set
			{
				this.actionBindingAchievements_ = value;
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06001B0B RID: 6923 RVA: 0x00062D20 File Offset: 0x00060F20
		// (set) Token: 0x06001B0C RID: 6924 RVA: 0x00062D38 File Offset: 0x00060F38
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingProfile
		{
			get
			{
				return this.actionBindingProfile_;
			}
			set
			{
				this.actionBindingProfile_ = value;
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06001B0D RID: 6925 RVA: 0x00062D44 File Offset: 0x00060F44
		// (set) Token: 0x06001B0E RID: 6926 RVA: 0x00062D5C File Offset: 0x00060F5C
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingEquippables
		{
			get
			{
				return this.actionBindingEquippables_;
			}
			set
			{
				this.actionBindingEquippables_ = value;
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06001B0F RID: 6927 RVA: 0x00062D68 File Offset: 0x00060F68
		// (set) Token: 0x06001B10 RID: 6928 RVA: 0x00062D80 File Offset: 0x00060F80
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingConsole
		{
			get
			{
				return this.actionBindingConsole_;
			}
			set
			{
				this.actionBindingConsole_ = value;
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06001B11 RID: 6929 RVA: 0x00062D8C File Offset: 0x00060F8C
		// (set) Token: 0x06001B12 RID: 6930 RVA: 0x00062DA4 File Offset: 0x00060FA4
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingMap
		{
			get
			{
				return this.actionBindingMap_;
			}
			set
			{
				this.actionBindingMap_ = value;
			}
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06001B13 RID: 6931 RVA: 0x00062DB0 File Offset: 0x00060FB0
		// (set) Token: 0x06001B14 RID: 6932 RVA: 0x00062DC8 File Offset: 0x00060FC8
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingSkillTree
		{
			get
			{
				return this.actionBindingSkillTree_;
			}
			set
			{
				this.actionBindingSkillTree_ = value;
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06001B15 RID: 6933 RVA: 0x00062DD4 File Offset: 0x00060FD4
		// (set) Token: 0x06001B16 RID: 6934 RVA: 0x00062DEC File Offset: 0x00060FEC
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingToggleplayerhpbars
		{
			get
			{
				return this.actionBindingToggleplayerhpbars_;
			}
			set
			{
				this.actionBindingToggleplayerhpbars_ = value;
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06001B17 RID: 6935 RVA: 0x00062DF8 File Offset: 0x00060FF8
		// (set) Token: 0x06001B18 RID: 6936 RVA: 0x00062E10 File Offset: 0x00061010
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingToggledamagenumbers
		{
			get
			{
				return this.actionBindingToggledamagenumbers_;
			}
			set
			{
				this.actionBindingToggledamagenumbers_ = value;
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06001B19 RID: 6937 RVA: 0x00062E1C File Offset: 0x0006101C
		// (set) Token: 0x06001B1A RID: 6938 RVA: 0x00062E34 File Offset: 0x00061034
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingToggleitemsonground
		{
			get
			{
				return this.actionBindingToggleitemsonground_;
			}
			set
			{
				this.actionBindingToggleitemsonground_ = value;
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06001B1B RID: 6939 RVA: 0x00062E40 File Offset: 0x00061040
		// (set) Token: 0x06001B1C RID: 6940 RVA: 0x00062E58 File Offset: 0x00061058
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingRewhisper
		{
			get
			{
				return this.actionBindingRewhisper_;
			}
			set
			{
				this.actionBindingRewhisper_ = value;
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06001B1D RID: 6941 RVA: 0x00062E64 File Offset: 0x00061064
		// (set) Token: 0x06001B1E RID: 6942 RVA: 0x00062E7C File Offset: 0x0006107C
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingWhisperreply
		{
			get
			{
				return this.actionBindingWhisperreply_;
			}
			set
			{
				this.actionBindingWhisperreply_ = value;
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06001B1F RID: 6943 RVA: 0x00062E88 File Offset: 0x00061088
		// (set) Token: 0x06001B20 RID: 6944 RVA: 0x00062EA0 File Offset: 0x000610A0
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingVoiceptt
		{
			get
			{
				return this.actionBindingVoiceptt_;
			}
			set
			{
				this.actionBindingVoiceptt_ = value;
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06001B21 RID: 6945 RVA: 0x00062EAC File Offset: 0x000610AC
		// (set) Token: 0x06001B22 RID: 6946 RVA: 0x00062EC4 File Offset: 0x000610C4
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingSocialwheel
		{
			get
			{
				return this.actionBindingSocialwheel_;
			}
			set
			{
				this.actionBindingSocialwheel_ = value;
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06001B23 RID: 6947 RVA: 0x00062ED0 File Offset: 0x000610D0
		// (set) Token: 0x06001B24 RID: 6948 RVA: 0x00062EE8 File Offset: 0x000610E8
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingFastquesttrack
		{
			get
			{
				return this.actionBindingFastquesttrack_;
			}
			set
			{
				this.actionBindingFastquesttrack_ = value;
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06001B25 RID: 6949 RVA: 0x00062EF4 File Offset: 0x000610F4
		// (set) Token: 0x06001B26 RID: 6950 RVA: 0x00062F0C File Offset: 0x0006110C
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingToggleLfdCompanions
		{
			get
			{
				return this.actionBindingToggleLfdCompanions_;
			}
			set
			{
				this.actionBindingToggleLfdCompanions_ = value;
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06001B27 RID: 6951 RVA: 0x00062F18 File Offset: 0x00061118
		// (set) Token: 0x06001B28 RID: 6952 RVA: 0x00062F30 File Offset: 0x00061130
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingCollections
		{
			get
			{
				return this.actionBindingCollections_;
			}
			set
			{
				this.actionBindingCollections_ = value;
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06001B29 RID: 6953 RVA: 0x00062F3C File Offset: 0x0006113C
		[DebuggerNonUserCode]
		public RepeatedField<SocialWheelBinding> ActionBindingSocialwheelLeft
		{
			get
			{
				return this.actionBindingSocialwheelLeft_;
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06001B2A RID: 6954 RVA: 0x00062F54 File Offset: 0x00061154
		[DebuggerNonUserCode]
		public RepeatedField<SocialWheelBinding> ActionBindingSocialwheelMiddle
		{
			get
			{
				return this.actionBindingSocialwheelMiddle_;
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06001B2B RID: 6955 RVA: 0x00062F6C File Offset: 0x0006116C
		[DebuggerNonUserCode]
		public RepeatedField<SocialWheelBinding> ActionBindingSocialwheelRight
		{
			get
			{
				return this.actionBindingSocialwheelRight_;
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06001B2C RID: 6956 RVA: 0x00062F84 File Offset: 0x00061184
		// (set) Token: 0x06001B2D RID: 6957 RVA: 0x00062F9C File Offset: 0x0006119C
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingSocialwheelPageBackward
		{
			get
			{
				return this.actionBindingSocialwheelPageBackward_;
			}
			set
			{
				this.actionBindingSocialwheelPageBackward_ = value;
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06001B2E RID: 6958 RVA: 0x00062FA8 File Offset: 0x000611A8
		// (set) Token: 0x06001B2F RID: 6959 RVA: 0x00062FC0 File Offset: 0x000611C0
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingSocialwheelPageForward
		{
			get
			{
				return this.actionBindingSocialwheelPageForward_;
			}
			set
			{
				this.actionBindingSocialwheelPageForward_ = value;
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06001B30 RID: 6960 RVA: 0x00062FCC File Offset: 0x000611CC
		// (set) Token: 0x06001B31 RID: 6961 RVA: 0x00062FE4 File Offset: 0x000611E4
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingAbilities
		{
			get
			{
				return this.actionBindingAbilities_;
			}
			set
			{
				this.actionBindingAbilities_ = value;
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06001B32 RID: 6962 RVA: 0x00062FF0 File Offset: 0x000611F0
		// (set) Token: 0x06001B33 RID: 6963 RVA: 0x00063008 File Offset: 0x00061208
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingReportBug
		{
			get
			{
				return this.actionBindingReportBug_;
			}
			set
			{
				this.actionBindingReportBug_ = value;
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06001B34 RID: 6964 RVA: 0x00063014 File Offset: 0x00061214
		// (set) Token: 0x06001B35 RID: 6965 RVA: 0x0006302C File Offset: 0x0006122C
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingReportContent
		{
			get
			{
				return this.actionBindingReportContent_;
			}
			set
			{
				this.actionBindingReportContent_ = value;
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06001B36 RID: 6966 RVA: 0x00063038 File Offset: 0x00061238
		// (set) Token: 0x06001B37 RID: 6967 RVA: 0x00063050 File Offset: 0x00061250
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingJoinSpeechToTextChat
		{
			get
			{
				return this.actionBindingJoinSpeechToTextChat_;
			}
			set
			{
				this.actionBindingJoinSpeechToTextChat_ = value;
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06001B38 RID: 6968 RVA: 0x0006305C File Offset: 0x0006125C
		// (set) Token: 0x06001B39 RID: 6969 RVA: 0x00063074 File Offset: 0x00061274
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingTtsSkipCurrentUtterance
		{
			get
			{
				return this.actionBindingTtsSkipCurrentUtterance_;
			}
			set
			{
				this.actionBindingTtsSkipCurrentUtterance_ = value;
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06001B3A RID: 6970 RVA: 0x00063080 File Offset: 0x00061280
		// (set) Token: 0x06001B3B RID: 6971 RVA: 0x00063098 File Offset: 0x00061298
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingTtsCancelAllUtterances
		{
			get
			{
				return this.actionBindingTtsCancelAllUtterances_;
			}
			set
			{
				this.actionBindingTtsCancelAllUtterances_ = value;
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06001B3C RID: 6972 RVA: 0x000630A4 File Offset: 0x000612A4
		// (set) Token: 0x06001B3D RID: 6973 RVA: 0x000630BC File Offset: 0x000612BC
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingScreenReaderSkipLine
		{
			get
			{
				return this.actionBindingScreenReaderSkipLine_;
			}
			set
			{
				this.actionBindingScreenReaderSkipLine_ = value;
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06001B3E RID: 6974 RVA: 0x000630C8 File Offset: 0x000612C8
		// (set) Token: 0x06001B3F RID: 6975 RVA: 0x000630E0 File Offset: 0x000612E0
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingStore
		{
			get
			{
				return this.actionBindingStore_;
			}
			set
			{
				this.actionBindingStore_ = value;
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06001B40 RID: 6976 RVA: 0x000630EC File Offset: 0x000612EC
		// (set) Token: 0x06001B41 RID: 6977 RVA: 0x00063104 File Offset: 0x00061304
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingMountSpur
		{
			get
			{
				return this.actionBindingMountSpur_;
			}
			set
			{
				this.actionBindingMountSpur_ = value;
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06001B42 RID: 6978 RVA: 0x00063110 File Offset: 0x00061310
		// (set) Token: 0x06001B43 RID: 6979 RVA: 0x00063128 File Offset: 0x00061328
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingMountDismount
		{
			get
			{
				return this.actionBindingMountDismount_;
			}
			set
			{
				this.actionBindingMountDismount_ = value;
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06001B44 RID: 6980 RVA: 0x00063134 File Offset: 0x00061334
		// (set) Token: 0x06001B45 RID: 6981 RVA: 0x0006314C File Offset: 0x0006134C
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingMountCombatDismount
		{
			get
			{
				return this.actionBindingMountCombatDismount_;
			}
			set
			{
				this.actionBindingMountCombatDismount_ = value;
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06001B46 RID: 6982 RVA: 0x00063158 File Offset: 0x00061358
		// (set) Token: 0x06001B47 RID: 6983 RVA: 0x00063170 File Offset: 0x00061370
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingToggleZoom
		{
			get
			{
				return this.actionBindingToggleZoom_;
			}
			set
			{
				this.actionBindingToggleZoom_ = value;
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06001B48 RID: 6984 RVA: 0x0006317C File Offset: 0x0006137C
		// (set) Token: 0x06001B49 RID: 6985 RVA: 0x00063194 File Offset: 0x00061394
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingHoldposition
		{
			get
			{
				return this.actionBindingHoldposition_;
			}
			set
			{
				this.actionBindingHoldposition_ = value;
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06001B4A RID: 6986 RVA: 0x000631A0 File Offset: 0x000613A0
		// (set) Token: 0x06001B4B RID: 6987 RVA: 0x000631B8 File Offset: 0x000613B8
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingSystemmastervolumeup
		{
			get
			{
				return this.actionBindingSystemmastervolumeup_;
			}
			set
			{
				this.actionBindingSystemmastervolumeup_ = value;
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06001B4C RID: 6988 RVA: 0x000631C4 File Offset: 0x000613C4
		// (set) Token: 0x06001B4D RID: 6989 RVA: 0x000631DC File Offset: 0x000613DC
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingSystemmastervolumedown
		{
			get
			{
				return this.actionBindingSystemmastervolumedown_;
			}
			set
			{
				this.actionBindingSystemmastervolumedown_ = value;
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06001B4E RID: 6990 RVA: 0x000631E8 File Offset: 0x000613E8
		// (set) Token: 0x06001B4F RID: 6991 RVA: 0x00063200 File Offset: 0x00061400
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingSystemtogglemusic
		{
			get
			{
				return this.actionBindingSystemtogglemusic_;
			}
			set
			{
				this.actionBindingSystemtogglemusic_ = value;
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06001B50 RID: 6992 RVA: 0x0006320C File Offset: 0x0006140C
		// (set) Token: 0x06001B51 RID: 6993 RVA: 0x00063224 File Offset: 0x00061424
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingSystemtogglesound
		{
			get
			{
				return this.actionBindingSystemtogglesound_;
			}
			set
			{
				this.actionBindingSystemtogglesound_ = value;
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06001B52 RID: 6994 RVA: 0x00063230 File Offset: 0x00061430
		// (set) Token: 0x06001B53 RID: 6995 RVA: 0x00063248 File Offset: 0x00061448
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingSystemscreenshot
		{
			get
			{
				return this.actionBindingSystemscreenshot_;
			}
			set
			{
				this.actionBindingSystemscreenshot_ = value;
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06001B54 RID: 6996 RVA: 0x00063254 File Offset: 0x00061454
		// (set) Token: 0x06001B55 RID: 6997 RVA: 0x0006326C File Offset: 0x0006146C
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingSystemtogglefps
		{
			get
			{
				return this.actionBindingSystemtogglefps_;
			}
			set
			{
				this.actionBindingSystemtogglefps_ = value;
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06001B56 RID: 6998 RVA: 0x00063278 File Offset: 0x00061478
		// (set) Token: 0x06001B57 RID: 6999 RVA: 0x00063290 File Offset: 0x00061490
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingChatpageup
		{
			get
			{
				return this.actionBindingChatpageup_;
			}
			set
			{
				this.actionBindingChatpageup_ = value;
			}
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06001B58 RID: 7000 RVA: 0x0006329C File Offset: 0x0006149C
		// (set) Token: 0x06001B59 RID: 7001 RVA: 0x000632B4 File Offset: 0x000614B4
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingChatpagedown
		{
			get
			{
				return this.actionBindingChatpagedown_;
			}
			set
			{
				this.actionBindingChatpagedown_ = value;
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06001B5A RID: 7002 RVA: 0x000632C0 File Offset: 0x000614C0
		// (set) Token: 0x06001B5B RID: 7003 RVA: 0x000632D8 File Offset: 0x000614D8
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingGroups
		{
			get
			{
				return this.actionBindingGroups_;
			}
			set
			{
				this.actionBindingGroups_ = value;
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06001B5C RID: 7004 RVA: 0x000632E4 File Offset: 0x000614E4
		// (set) Token: 0x06001B5D RID: 7005 RVA: 0x000632FC File Offset: 0x000614FC
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingClan
		{
			get
			{
				return this.actionBindingClan_;
			}
			set
			{
				this.actionBindingClan_ = value;
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06001B5E RID: 7006 RVA: 0x00063308 File Offset: 0x00061508
		// (set) Token: 0x06001B5F RID: 7007 RVA: 0x00063320 File Offset: 0x00061520
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingChatNextView
		{
			get
			{
				return this.actionBindingChatNextView_;
			}
			set
			{
				this.actionBindingChatNextView_ = value;
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06001B60 RID: 7008 RVA: 0x0006332C File Offset: 0x0006152C
		// (set) Token: 0x06001B61 RID: 7009 RVA: 0x00063344 File Offset: 0x00061544
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingChatPreviousView
		{
			get
			{
				return this.actionBindingChatPreviousView_;
			}
			set
			{
				this.actionBindingChatPreviousView_ = value;
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06001B62 RID: 7010 RVA: 0x00063350 File Offset: 0x00061550
		// (set) Token: 0x06001B63 RID: 7011 RVA: 0x00063368 File Offset: 0x00061568
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingLeaderboards
		{
			get
			{
				return this.actionBindingLeaderboards_;
			}
			set
			{
				this.actionBindingLeaderboards_ = value;
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06001B64 RID: 7012 RVA: 0x00063374 File Offset: 0x00061574
		// (set) Token: 0x06001B65 RID: 7013 RVA: 0x0006338C File Offset: 0x0006158C
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingChatResetFade
		{
			get
			{
				return this.actionBindingChatResetFade_;
			}
			set
			{
				this.actionBindingChatResetFade_ = value;
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06001B66 RID: 7014 RVA: 0x00063398 File Offset: 0x00061598
		// (set) Token: 0x06001B67 RID: 7015 RVA: 0x000633B0 File Offset: 0x000615B0
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingQuests
		{
			get
			{
				return this.actionBindingQuests_;
			}
			set
			{
				this.actionBindingQuests_ = value;
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06001B68 RID: 7016 RVA: 0x000633BC File Offset: 0x000615BC
		// (set) Token: 0x06001B69 RID: 7017 RVA: 0x000633D4 File Offset: 0x000615D4
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingQuestsToggle
		{
			get
			{
				return this.actionBindingQuestsToggle_;
			}
			set
			{
				this.actionBindingQuestsToggle_ = value;
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06001B6A RID: 7018 RVA: 0x000633E0 File Offset: 0x000615E0
		// (set) Token: 0x06001B6B RID: 7019 RVA: 0x000633F8 File Offset: 0x000615F8
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingRun
		{
			get
			{
				return this.actionBindingRun_;
			}
			set
			{
				this.actionBindingRun_ = value;
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06001B6C RID: 7020 RVA: 0x00063404 File Offset: 0x00061604
		// (set) Token: 0x06001B6D RID: 7021 RVA: 0x0006341C File Offset: 0x0006161C
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingInteract
		{
			get
			{
				return this.actionBindingInteract_;
			}
			set
			{
				this.actionBindingInteract_ = value;
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06001B6E RID: 7022 RVA: 0x00063428 File Offset: 0x00061628
		// (set) Token: 0x06001B6F RID: 7023 RVA: 0x00063440 File Offset: 0x00061640
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingPrimary
		{
			get
			{
				return this.actionBindingPrimary_;
			}
			set
			{
				this.actionBindingPrimary_ = value;
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06001B70 RID: 7024 RVA: 0x0006344C File Offset: 0x0006164C
		// (set) Token: 0x06001B71 RID: 7025 RVA: 0x00063464 File Offset: 0x00061664
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingSecondary
		{
			get
			{
				return this.actionBindingSecondary_;
			}
			set
			{
				this.actionBindingSecondary_ = value;
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06001B72 RID: 7026 RVA: 0x00063470 File Offset: 0x00061670
		// (set) Token: 0x06001B73 RID: 7027 RVA: 0x00063488 File Offset: 0x00061688
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingSkill1
		{
			get
			{
				return this.actionBindingSkill1_;
			}
			set
			{
				this.actionBindingSkill1_ = value;
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06001B74 RID: 7028 RVA: 0x00063494 File Offset: 0x00061694
		// (set) Token: 0x06001B75 RID: 7029 RVA: 0x000634AC File Offset: 0x000616AC
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingSkill2
		{
			get
			{
				return this.actionBindingSkill2_;
			}
			set
			{
				this.actionBindingSkill2_ = value;
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06001B76 RID: 7030 RVA: 0x000634B8 File Offset: 0x000616B8
		// (set) Token: 0x06001B77 RID: 7031 RVA: 0x000634D0 File Offset: 0x000616D0
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingSkill3
		{
			get
			{
				return this.actionBindingSkill3_;
			}
			set
			{
				this.actionBindingSkill3_ = value;
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06001B78 RID: 7032 RVA: 0x000634DC File Offset: 0x000616DC
		// (set) Token: 0x06001B79 RID: 7033 RVA: 0x000634F4 File Offset: 0x000616F4
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingSkill4
		{
			get
			{
				return this.actionBindingSkill4_;
			}
			set
			{
				this.actionBindingSkill4_ = value;
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06001B7A RID: 7034 RVA: 0x00063500 File Offset: 0x00061700
		// (set) Token: 0x06001B7B RID: 7035 RVA: 0x00063518 File Offset: 0x00061718
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingMount
		{
			get
			{
				return this.actionBindingMount_;
			}
			set
			{
				this.actionBindingMount_ = value;
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06001B7C RID: 7036 RVA: 0x00063524 File Offset: 0x00061724
		// (set) Token: 0x06001B7D RID: 7037 RVA: 0x0006353C File Offset: 0x0006173C
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingEvade
		{
			get
			{
				return this.actionBindingEvade_;
			}
			set
			{
				this.actionBindingEvade_ = value;
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06001B7E RID: 7038 RVA: 0x00063548 File Offset: 0x00061748
		// (set) Token: 0x06001B7F RID: 7039 RVA: 0x00063560 File Offset: 0x00061760
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingUseItem
		{
			get
			{
				return this.actionBindingUseItem_;
			}
			set
			{
				this.actionBindingUseItem_ = value;
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06001B80 RID: 7040 RVA: 0x0006356C File Offset: 0x0006176C
		// (set) Token: 0x06001B81 RID: 7041 RVA: 0x00063584 File Offset: 0x00061784
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingCenterCamera
		{
			get
			{
				return this.actionBindingCenterCamera_;
			}
			set
			{
				this.actionBindingCenterCamera_ = value;
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06001B82 RID: 7042 RVA: 0x00063590 File Offset: 0x00061790
		// (set) Token: 0x06001B83 RID: 7043 RVA: 0x000635A8 File Offset: 0x000617A8
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingDebugCamera
		{
			get
			{
				return this.actionBindingDebugCamera_;
			}
			set
			{
				this.actionBindingDebugCamera_ = value;
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06001B84 RID: 7044 RVA: 0x000635B4 File Offset: 0x000617B4
		// (set) Token: 0x06001B85 RID: 7045 RVA: 0x000635CC File Offset: 0x000617CC
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingSocialInteract
		{
			get
			{
				return this.actionBindingSocialInteract_;
			}
			set
			{
				this.actionBindingSocialInteract_ = value;
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06001B86 RID: 7046 RVA: 0x000635D8 File Offset: 0x000617D8
		// (set) Token: 0x06001B87 RID: 7047 RVA: 0x000635F0 File Offset: 0x000617F0
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingAcceptPartyInvite
		{
			get
			{
				return this.actionBindingAcceptPartyInvite_;
			}
			set
			{
				this.actionBindingAcceptPartyInvite_ = value;
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06001B88 RID: 7048 RVA: 0x000635FC File Offset: 0x000617FC
		// (set) Token: 0x06001B89 RID: 7049 RVA: 0x00063614 File Offset: 0x00061814
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingLockTarget
		{
			get
			{
				return this.actionBindingLockTarget_;
			}
			set
			{
				this.actionBindingLockTarget_ = value;
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06001B8A RID: 7050 RVA: 0x00063620 File Offset: 0x00061820
		// (set) Token: 0x06001B8B RID: 7051 RVA: 0x00063638 File Offset: 0x00061838
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingTownPortal
		{
			get
			{
				return this.actionBindingTownPortal_;
			}
			set
			{
				this.actionBindingTownPortal_ = value;
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06001B8C RID: 7052 RVA: 0x00063644 File Offset: 0x00061844
		// (set) Token: 0x06001B8D RID: 7053 RVA: 0x0006365C File Offset: 0x0006185C
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingForceMove
		{
			get
			{
				return this.actionBindingForceMove_;
			}
			set
			{
				this.actionBindingForceMove_ = value;
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06001B8E RID: 7054 RVA: 0x00063668 File Offset: 0x00061868
		// (set) Token: 0x06001B8F RID: 7055 RVA: 0x00063680 File Offset: 0x00061880
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingClassScreen
		{
			get
			{
				return this.actionBindingClassScreen_;
			}
			set
			{
				this.actionBindingClassScreen_ = value;
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06001B90 RID: 7056 RVA: 0x0006368C File Offset: 0x0006188C
		// (set) Token: 0x06001B91 RID: 7057 RVA: 0x000636A4 File Offset: 0x000618A4
		[DebuggerNonUserCode]
		public ActionBinding ActionBindingCycleLockTarget
		{
			get
			{
				return this.actionBindingCycleLockTarget_;
			}
			set
			{
				this.actionBindingCycleLockTarget_ = value;
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06001B92 RID: 7058 RVA: 0x000636B0 File Offset: 0x000618B0
		// (set) Token: 0x06001B93 RID: 7059 RVA: 0x000636E1 File Offset: 0x000618E1
		[DebuggerNonUserCode]
		public uint NotifyDuration
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint notifyDurationDefaultValue;
				if (flag)
				{
					notifyDurationDefaultValue = this.notifyDuration_;
				}
				else
				{
					notifyDurationDefaultValue = Preferences.NotifyDurationDefaultValue;
				}
				return notifyDurationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.notifyDuration_ = value;
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06001B94 RID: 7060 RVA: 0x000636FC File Offset: 0x000618FC
		[DebuggerNonUserCode]
		public bool HasNotifyDuration
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x00063719 File Offset: 0x00061919
		[DebuggerNonUserCode]
		public void ClearNotifyDuration()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06001B96 RID: 7062 RVA: 0x0006372C File Offset: 0x0006192C
		// (set) Token: 0x06001B97 RID: 7063 RVA: 0x0006375E File Offset: 0x0006195E
		[DebuggerNonUserCode]
		public uint KeybindingVersion
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint keybindingVersionDefaultValue;
				if (flag)
				{
					keybindingVersionDefaultValue = this.keybindingVersion_;
				}
				else
				{
					keybindingVersionDefaultValue = Preferences.KeybindingVersionDefaultValue;
				}
				return keybindingVersionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.keybindingVersion_ = value;
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06001B98 RID: 7064 RVA: 0x00063778 File Offset: 0x00061978
		[DebuggerNonUserCode]
		public bool HasKeybindingVersion
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x00063796 File Offset: 0x00061996
		[DebuggerNonUserCode]
		public void ClearKeybindingVersion()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06001B9A RID: 7066 RVA: 0x000637A8 File Offset: 0x000619A8
		// (set) Token: 0x06001B9B RID: 7067 RVA: 0x000637DA File Offset: 0x000619DA
		[DebuggerNonUserCode]
		public uint Flags2
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				uint flags2DefaultValue;
				if (flag)
				{
					flags2DefaultValue = this.flags2_;
				}
				else
				{
					flags2DefaultValue = Preferences.Flags2DefaultValue;
				}
				return flags2DefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.flags2_ = value;
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06001B9C RID: 7068 RVA: 0x000637F4 File Offset: 0x000619F4
		[DebuggerNonUserCode]
		public bool HasFlags2
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x00063812 File Offset: 0x00061A12
		[DebuggerNonUserCode]
		public void ClearFlags2()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06001B9E RID: 7070 RVA: 0x00063824 File Offset: 0x00061A24
		// (set) Token: 0x06001B9F RID: 7071 RVA: 0x00063856 File Offset: 0x00061A56
		[DebuggerNonUserCode]
		public int ControlScheme
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				int controlSchemeDefaultValue;
				if (flag)
				{
					controlSchemeDefaultValue = this.controlScheme_;
				}
				else
				{
					controlSchemeDefaultValue = Preferences.ControlSchemeDefaultValue;
				}
				return controlSchemeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.controlScheme_ = value;
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06001BA0 RID: 7072 RVA: 0x00063870 File Offset: 0x00061A70
		[DebuggerNonUserCode]
		public bool HasControlScheme
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x0006388E File Offset: 0x00061A8E
		[DebuggerNonUserCode]
		public void ClearControlScheme()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06001BA2 RID: 7074 RVA: 0x000638A0 File Offset: 0x00061AA0
		// (set) Token: 0x06001BA3 RID: 7075 RVA: 0x000638D5 File Offset: 0x00061AD5
		[DebuggerNonUserCode]
		public uint ControllerButtonBindingVersion
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				uint controllerButtonBindingVersionDefaultValue;
				if (flag)
				{
					controllerButtonBindingVersionDefaultValue = this.controllerButtonBindingVersion_;
				}
				else
				{
					controllerButtonBindingVersionDefaultValue = Preferences.ControllerButtonBindingVersionDefaultValue;
				}
				return controllerButtonBindingVersionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.controllerButtonBindingVersion_ = value;
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06001BA4 RID: 7076 RVA: 0x000638F4 File Offset: 0x00061AF4
		[DebuggerNonUserCode]
		public bool HasControllerButtonBindingVersion
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x00063915 File Offset: 0x00061B15
		[DebuggerNonUserCode]
		public void ClearControllerButtonBindingVersion()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06001BA6 RID: 7078 RVA: 0x0006392C File Offset: 0x00061B2C
		// (set) Token: 0x06001BA7 RID: 7079 RVA: 0x00063944 File Offset: 0x00061B44
		[DebuggerNonUserCode]
		public ControllerActionBindings ControllerBindingsXinput
		{
			get
			{
				return this.controllerBindingsXinput_;
			}
			set
			{
				this.controllerBindingsXinput_ = value;
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06001BA8 RID: 7080 RVA: 0x00063950 File Offset: 0x00061B50
		// (set) Token: 0x06001BA9 RID: 7081 RVA: 0x00063968 File Offset: 0x00061B68
		[DebuggerNonUserCode]
		public ControllerActionBindings ControllerBindingsPs4
		{
			get
			{
				return this.controllerBindingsPs4_;
			}
			set
			{
				this.controllerBindingsPs4_ = value;
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06001BAA RID: 7082 RVA: 0x00063974 File Offset: 0x00061B74
		// (set) Token: 0x06001BAB RID: 7083 RVA: 0x0006398C File Offset: 0x00061B8C
		[DebuggerNonUserCode]
		public ControllerActionBindings ControllerBindingsNx64
		{
			get
			{
				return this.controllerBindingsNx64_;
			}
			set
			{
				this.controllerBindingsNx64_ = value;
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06001BAC RID: 7084 RVA: 0x00063998 File Offset: 0x00061B98
		// (set) Token: 0x06001BAD RID: 7085 RVA: 0x000639CD File Offset: 0x00061BCD
		[DebuggerNonUserCode]
		public uint ChatBackgroundOpacityWhenActive
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				uint chatBackgroundOpacityWhenActiveDefaultValue;
				if (flag)
				{
					chatBackgroundOpacityWhenActiveDefaultValue = this.chatBackgroundOpacityWhenActive_;
				}
				else
				{
					chatBackgroundOpacityWhenActiveDefaultValue = Preferences.ChatBackgroundOpacityWhenActiveDefaultValue;
				}
				return chatBackgroundOpacityWhenActiveDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.chatBackgroundOpacityWhenActive_ = value;
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06001BAE RID: 7086 RVA: 0x000639EC File Offset: 0x00061BEC
		[DebuggerNonUserCode]
		public bool HasChatBackgroundOpacityWhenActive
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x00063A0D File Offset: 0x00061C0D
		[DebuggerNonUserCode]
		public void ClearChatBackgroundOpacityWhenActive()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06001BB0 RID: 7088 RVA: 0x00063A24 File Offset: 0x00061C24
		// (set) Token: 0x06001BB1 RID: 7089 RVA: 0x00063A59 File Offset: 0x00061C59
		[DebuggerNonUserCode]
		public uint ChatTimestampFormat
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				uint chatTimestampFormatDefaultValue;
				if (flag)
				{
					chatTimestampFormatDefaultValue = this.chatTimestampFormat_;
				}
				else
				{
					chatTimestampFormatDefaultValue = Preferences.ChatTimestampFormatDefaultValue;
				}
				return chatTimestampFormatDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.chatTimestampFormat_ = value;
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06001BB2 RID: 7090 RVA: 0x00063A78 File Offset: 0x00061C78
		[DebuggerNonUserCode]
		public bool HasChatTimestampFormat
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x00063A99 File Offset: 0x00061C99
		[DebuggerNonUserCode]
		public void ClearChatTimestampFormat()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06001BB4 RID: 7092 RVA: 0x00063AB0 File Offset: 0x00061CB0
		// (set) Token: 0x06001BB5 RID: 7093 RVA: 0x00063AE5 File Offset: 0x00061CE5
		[DebuggerNonUserCode]
		public uint ItemLabelOnDropDuration
		{
			get
			{
				bool flag = (this._hasBits0 & 1024) != 0;
				uint itemLabelOnDropDurationDefaultValue;
				if (flag)
				{
					itemLabelOnDropDurationDefaultValue = this.itemLabelOnDropDuration_;
				}
				else
				{
					itemLabelOnDropDurationDefaultValue = Preferences.ItemLabelOnDropDurationDefaultValue;
				}
				return itemLabelOnDropDurationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1024;
				this.itemLabelOnDropDuration_ = value;
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06001BB6 RID: 7094 RVA: 0x00063B04 File Offset: 0x00061D04
		[DebuggerNonUserCode]
		public bool HasItemLabelOnDropDuration
		{
			get
			{
				return (this._hasBits0 & 1024) != 0;
			}
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x00063B25 File Offset: 0x00061D25
		[DebuggerNonUserCode]
		public void ClearItemLabelOnDropDuration()
		{
			this._hasBits0 &= -1025;
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06001BB8 RID: 7096 RVA: 0x00063B3C File Offset: 0x00061D3C
		// (set) Token: 0x06001BB9 RID: 7097 RVA: 0x00063B71 File Offset: 0x00061D71
		[DebuggerNonUserCode]
		public uint ItemLabelDisplayMode
		{
			get
			{
				bool flag = (this._hasBits0 & 2048) != 0;
				uint itemLabelDisplayModeDefaultValue;
				if (flag)
				{
					itemLabelDisplayModeDefaultValue = this.itemLabelDisplayMode_;
				}
				else
				{
					itemLabelDisplayModeDefaultValue = Preferences.ItemLabelDisplayModeDefaultValue;
				}
				return itemLabelDisplayModeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2048;
				this.itemLabelDisplayMode_ = value;
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06001BBA RID: 7098 RVA: 0x00063B90 File Offset: 0x00061D90
		[DebuggerNonUserCode]
		public bool HasItemLabelDisplayMode
		{
			get
			{
				return (this._hasBits0 & 2048) != 0;
			}
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x00063BB1 File Offset: 0x00061DB1
		[DebuggerNonUserCode]
		public void ClearItemLabelDisplayMode()
		{
			this._hasBits0 &= -2049;
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06001BBC RID: 7100 RVA: 0x00063BC8 File Offset: 0x00061DC8
		// (set) Token: 0x06001BBD RID: 7101 RVA: 0x00063BFD File Offset: 0x00061DFD
		[DebuggerNonUserCode]
		public float ControllerCursorSensitivity
		{
			get
			{
				bool flag = (this._hasBits0 & 4096) != 0;
				float controllerCursorSensitivityDefaultValue;
				if (flag)
				{
					controllerCursorSensitivityDefaultValue = this.controllerCursorSensitivity_;
				}
				else
				{
					controllerCursorSensitivityDefaultValue = Preferences.ControllerCursorSensitivityDefaultValue;
				}
				return controllerCursorSensitivityDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4096;
				this.controllerCursorSensitivity_ = value;
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06001BBE RID: 7102 RVA: 0x00063C1C File Offset: 0x00061E1C
		[DebuggerNonUserCode]
		public bool HasControllerCursorSensitivity
		{
			get
			{
				return (this._hasBits0 & 4096) != 0;
			}
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x00063C3D File Offset: 0x00061E3D
		[DebuggerNonUserCode]
		public void ClearControllerCursorSensitivity()
		{
			this._hasBits0 &= -4097;
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06001BC0 RID: 7104 RVA: 0x00063C54 File Offset: 0x00061E54
		// (set) Token: 0x06001BC1 RID: 7105 RVA: 0x00063C89 File Offset: 0x00061E89
		[DebuggerNonUserCode]
		public float ControllerInnerDeadZone
		{
			get
			{
				bool flag = (this._hasBits0 & 8192) != 0;
				float controllerInnerDeadZoneDefaultValue;
				if (flag)
				{
					controllerInnerDeadZoneDefaultValue = this.controllerInnerDeadZone_;
				}
				else
				{
					controllerInnerDeadZoneDefaultValue = Preferences.ControllerInnerDeadZoneDefaultValue;
				}
				return controllerInnerDeadZoneDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8192;
				this.controllerInnerDeadZone_ = value;
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06001BC2 RID: 7106 RVA: 0x00063CA8 File Offset: 0x00061EA8
		[DebuggerNonUserCode]
		public bool HasControllerInnerDeadZone
		{
			get
			{
				return (this._hasBits0 & 8192) != 0;
			}
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x00063CC9 File Offset: 0x00061EC9
		[DebuggerNonUserCode]
		public void ClearControllerInnerDeadZone()
		{
			this._hasBits0 &= -8193;
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06001BC4 RID: 7108 RVA: 0x00063CE0 File Offset: 0x00061EE0
		// (set) Token: 0x06001BC5 RID: 7109 RVA: 0x00063D15 File Offset: 0x00061F15
		[DebuggerNonUserCode]
		public float ControllerOuterDeadZone
		{
			get
			{
				bool flag = (this._hasBits0 & 16384) != 0;
				float controllerOuterDeadZoneDefaultValue;
				if (flag)
				{
					controllerOuterDeadZoneDefaultValue = this.controllerOuterDeadZone_;
				}
				else
				{
					controllerOuterDeadZoneDefaultValue = Preferences.ControllerOuterDeadZoneDefaultValue;
				}
				return controllerOuterDeadZoneDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16384;
				this.controllerOuterDeadZone_ = value;
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06001BC6 RID: 7110 RVA: 0x00063D34 File Offset: 0x00061F34
		[DebuggerNonUserCode]
		public bool HasControllerOuterDeadZone
		{
			get
			{
				return (this._hasBits0 & 16384) != 0;
			}
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x00063D55 File Offset: 0x00061F55
		[DebuggerNonUserCode]
		public void ClearControllerOuterDeadZone()
		{
			this._hasBits0 &= -16385;
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06001BC8 RID: 7112 RVA: 0x00063D6C File Offset: 0x00061F6C
		// (set) Token: 0x06001BC9 RID: 7113 RVA: 0x00063DA1 File Offset: 0x00061FA1
		[DebuggerNonUserCode]
		public uint PowerToggleMode
		{
			get
			{
				bool flag = (this._hasBits0 & 32768) != 0;
				uint powerToggleModeDefaultValue;
				if (flag)
				{
					powerToggleModeDefaultValue = this.powerToggleMode_;
				}
				else
				{
					powerToggleModeDefaultValue = Preferences.PowerToggleModeDefaultValue;
				}
				return powerToggleModeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32768;
				this.powerToggleMode_ = value;
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06001BCA RID: 7114 RVA: 0x00063DC0 File Offset: 0x00061FC0
		[DebuggerNonUserCode]
		public bool HasPowerToggleMode
		{
			get
			{
				return (this._hasBits0 & 32768) != 0;
			}
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x00063DE1 File Offset: 0x00061FE1
		[DebuggerNonUserCode]
		public void ClearPowerToggleMode()
		{
			this._hasBits0 &= -32769;
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06001BCC RID: 7116 RVA: 0x00063DF8 File Offset: 0x00061FF8
		// (set) Token: 0x06001BCD RID: 7117 RVA: 0x00063E2D File Offset: 0x0006202D
		[DebuggerNonUserCode]
		public uint SocialWheelActivationStyle
		{
			get
			{
				bool flag = (this._hasBits0 & 65536) != 0;
				uint socialWheelActivationStyleDefaultValue;
				if (flag)
				{
					socialWheelActivationStyleDefaultValue = this.socialWheelActivationStyle_;
				}
				else
				{
					socialWheelActivationStyleDefaultValue = Preferences.SocialWheelActivationStyleDefaultValue;
				}
				return socialWheelActivationStyleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 65536;
				this.socialWheelActivationStyle_ = value;
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06001BCE RID: 7118 RVA: 0x00063E4C File Offset: 0x0006204C
		[DebuggerNonUserCode]
		public bool HasSocialWheelActivationStyle
		{
			get
			{
				return (this._hasBits0 & 65536) != 0;
			}
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x00063E6D File Offset: 0x0006206D
		[DebuggerNonUserCode]
		public void ClearSocialWheelActivationStyle()
		{
			this._hasBits0 &= -65537;
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06001BD0 RID: 7120 RVA: 0x00063E84 File Offset: 0x00062084
		// (set) Token: 0x06001BD1 RID: 7121 RVA: 0x00063EB9 File Offset: 0x000620B9
		[DebuggerNonUserCode]
		public uint MonsterHealthBarMode
		{
			get
			{
				bool flag = (this._hasBits0 & 131072) != 0;
				uint monsterHealthBarModeDefaultValue;
				if (flag)
				{
					monsterHealthBarModeDefaultValue = this.monsterHealthBarMode_;
				}
				else
				{
					monsterHealthBarModeDefaultValue = Preferences.MonsterHealthBarModeDefaultValue;
				}
				return monsterHealthBarModeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 131072;
				this.monsterHealthBarMode_ = value;
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06001BD2 RID: 7122 RVA: 0x00063ED8 File Offset: 0x000620D8
		[DebuggerNonUserCode]
		public bool HasMonsterHealthBarMode
		{
			get
			{
				return (this._hasBits0 & 131072) != 0;
			}
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x00063EF9 File Offset: 0x000620F9
		[DebuggerNonUserCode]
		public void ClearMonsterHealthBarMode()
		{
			this._hasBits0 &= -131073;
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06001BD4 RID: 7124 RVA: 0x00063F10 File Offset: 0x00062110
		// (set) Token: 0x06001BD5 RID: 7125 RVA: 0x00063F45 File Offset: 0x00062145
		[DebuggerNonUserCode]
		public uint HoldPositionInputMode
		{
			get
			{
				bool flag = (this._hasBits0 & 262144) != 0;
				uint holdPositionInputModeDefaultValue;
				if (flag)
				{
					holdPositionInputModeDefaultValue = this.holdPositionInputMode_;
				}
				else
				{
					holdPositionInputModeDefaultValue = Preferences.HoldPositionInputModeDefaultValue;
				}
				return holdPositionInputModeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 262144;
				this.holdPositionInputMode_ = value;
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06001BD6 RID: 7126 RVA: 0x00063F64 File Offset: 0x00062164
		[DebuggerNonUserCode]
		public bool HasHoldPositionInputMode
		{
			get
			{
				return (this._hasBits0 & 262144) != 0;
			}
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x00063F85 File Offset: 0x00062185
		[DebuggerNonUserCode]
		public void ClearHoldPositionInputMode()
		{
			this._hasBits0 &= -262145;
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06001BD8 RID: 7128 RVA: 0x00063F9C File Offset: 0x0006219C
		// (set) Token: 0x06001BD9 RID: 7129 RVA: 0x00063FB4 File Offset: 0x000621B4
		[DebuggerNonUserCode]
		public ControllerActionBindings ControllerBindingsPs5
		{
			get
			{
				return this.controllerBindingsPs5_;
			}
			set
			{
				this.controllerBindingsPs5_ = value;
			}
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x00063FC0 File Offset: 0x000621C0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Preferences);
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x00063FE0 File Offset: 0x000621E0
		[DebuggerNonUserCode]
		public bool Equals(Preferences other)
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
					bool flag4 = this.Version != other.Version;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Flags != other.Flags;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.DeprecatedItemsOnGroundSetting != other.DeprecatedItemsOnGroundSetting;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.ActionBindingHireling, other.ActionBindingHireling);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.ActionBindingSkills, other.ActionBindingSkills);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.ActionBindingAcceptPartyInviteRequest, other.ActionBindingAcceptPartyInviteRequest);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !object.Equals(this.ActionBindingLore, other.ActionBindingLore);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !object.Equals(this.ActionBindingSocial, other.ActionBindingSocial);
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !object.Equals(this.ActionBindingHelp, other.ActionBindingHelp);
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = !object.Equals(this.ActionBindingRecentplayers, other.ActionBindingRecentplayers);
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = !object.Equals(this.ActionBindingChatlobby, other.ActionBindingChatlobby);
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = !object.Equals(this.ActionBindingAchievements, other.ActionBindingAchievements);
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = !object.Equals(this.ActionBindingProfile, other.ActionBindingProfile);
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = !object.Equals(this.ActionBindingEquippables, other.ActionBindingEquippables);
																		if (flag17)
																		{
																			flag2 = false;
																		}
																		else
																		{
																			bool flag18 = !object.Equals(this.ActionBindingConsole, other.ActionBindingConsole);
																			if (flag18)
																			{
																				flag2 = false;
																			}
																			else
																			{
																				bool flag19 = !object.Equals(this.ActionBindingMap, other.ActionBindingMap);
																				if (flag19)
																				{
																					flag2 = false;
																				}
																				else
																				{
																					bool flag20 = !object.Equals(this.ActionBindingSkillTree, other.ActionBindingSkillTree);
																					if (flag20)
																					{
																						flag2 = false;
																					}
																					else
																					{
																						bool flag21 = !object.Equals(this.ActionBindingToggleplayerhpbars, other.ActionBindingToggleplayerhpbars);
																						if (flag21)
																						{
																							flag2 = false;
																						}
																						else
																						{
																							bool flag22 = !object.Equals(this.ActionBindingToggledamagenumbers, other.ActionBindingToggledamagenumbers);
																							if (flag22)
																							{
																								flag2 = false;
																							}
																							else
																							{
																								bool flag23 = !object.Equals(this.ActionBindingToggleitemsonground, other.ActionBindingToggleitemsonground);
																								if (flag23)
																								{
																									flag2 = false;
																								}
																								else
																								{
																									bool flag24 = !object.Equals(this.ActionBindingRewhisper, other.ActionBindingRewhisper);
																									if (flag24)
																									{
																										flag2 = false;
																									}
																									else
																									{
																										bool flag25 = !object.Equals(this.ActionBindingWhisperreply, other.ActionBindingWhisperreply);
																										if (flag25)
																										{
																											flag2 = false;
																										}
																										else
																										{
																											bool flag26 = !object.Equals(this.ActionBindingVoiceptt, other.ActionBindingVoiceptt);
																											if (flag26)
																											{
																												flag2 = false;
																											}
																											else
																											{
																												bool flag27 = !object.Equals(this.ActionBindingSocialwheel, other.ActionBindingSocialwheel);
																												if (flag27)
																												{
																													flag2 = false;
																												}
																												else
																												{
																													bool flag28 = !object.Equals(this.ActionBindingFastquesttrack, other.ActionBindingFastquesttrack);
																													if (flag28)
																													{
																														flag2 = false;
																													}
																													else
																													{
																														bool flag29 = !object.Equals(this.ActionBindingToggleLfdCompanions, other.ActionBindingToggleLfdCompanions);
																														if (flag29)
																														{
																															flag2 = false;
																														}
																														else
																														{
																															bool flag30 = !object.Equals(this.ActionBindingCollections, other.ActionBindingCollections);
																															if (flag30)
																															{
																																flag2 = false;
																															}
																															else
																															{
																																bool flag31 = !this.actionBindingSocialwheelLeft_.Equals(other.actionBindingSocialwheelLeft_);
																																if (flag31)
																																{
																																	flag2 = false;
																																}
																																else
																																{
																																	bool flag32 = !this.actionBindingSocialwheelMiddle_.Equals(other.actionBindingSocialwheelMiddle_);
																																	if (flag32)
																																	{
																																		flag2 = false;
																																	}
																																	else
																																	{
																																		bool flag33 = !this.actionBindingSocialwheelRight_.Equals(other.actionBindingSocialwheelRight_);
																																		if (flag33)
																																		{
																																			flag2 = false;
																																		}
																																		else
																																		{
																																			bool flag34 = !object.Equals(this.ActionBindingSocialwheelPageBackward, other.ActionBindingSocialwheelPageBackward);
																																			if (flag34)
																																			{
																																				flag2 = false;
																																			}
																																			else
																																			{
																																				bool flag35 = !object.Equals(this.ActionBindingSocialwheelPageForward, other.ActionBindingSocialwheelPageForward);
																																				if (flag35)
																																				{
																																					flag2 = false;
																																				}
																																				else
																																				{
																																					bool flag36 = !object.Equals(this.ActionBindingAbilities, other.ActionBindingAbilities);
																																					if (flag36)
																																					{
																																						flag2 = false;
																																					}
																																					else
																																					{
																																						bool flag37 = !object.Equals(this.ActionBindingReportBug, other.ActionBindingReportBug);
																																						if (flag37)
																																						{
																																							flag2 = false;
																																						}
																																						else
																																						{
																																							bool flag38 = !object.Equals(this.ActionBindingReportContent, other.ActionBindingReportContent);
																																							if (flag38)
																																							{
																																								flag2 = false;
																																							}
																																							else
																																							{
																																								bool flag39 = !object.Equals(this.ActionBindingJoinSpeechToTextChat, other.ActionBindingJoinSpeechToTextChat);
																																								if (flag39)
																																								{
																																									flag2 = false;
																																								}
																																								else
																																								{
																																									bool flag40 = !object.Equals(this.ActionBindingTtsSkipCurrentUtterance, other.ActionBindingTtsSkipCurrentUtterance);
																																									if (flag40)
																																									{
																																										flag2 = false;
																																									}
																																									else
																																									{
																																										bool flag41 = !object.Equals(this.ActionBindingTtsCancelAllUtterances, other.ActionBindingTtsCancelAllUtterances);
																																										if (flag41)
																																										{
																																											flag2 = false;
																																										}
																																										else
																																										{
																																											bool flag42 = !object.Equals(this.ActionBindingScreenReaderSkipLine, other.ActionBindingScreenReaderSkipLine);
																																											if (flag42)
																																											{
																																												flag2 = false;
																																											}
																																											else
																																											{
																																												bool flag43 = !object.Equals(this.ActionBindingStore, other.ActionBindingStore);
																																												if (flag43)
																																												{
																																													flag2 = false;
																																												}
																																												else
																																												{
																																													bool flag44 = !object.Equals(this.ActionBindingMountSpur, other.ActionBindingMountSpur);
																																													if (flag44)
																																													{
																																														flag2 = false;
																																													}
																																													else
																																													{
																																														bool flag45 = !object.Equals(this.ActionBindingMountDismount, other.ActionBindingMountDismount);
																																														if (flag45)
																																														{
																																															flag2 = false;
																																														}
																																														else
																																														{
																																															bool flag46 = !object.Equals(this.ActionBindingMountCombatDismount, other.ActionBindingMountCombatDismount);
																																															if (flag46)
																																															{
																																																flag2 = false;
																																															}
																																															else
																																															{
																																																bool flag47 = !object.Equals(this.ActionBindingToggleZoom, other.ActionBindingToggleZoom);
																																																if (flag47)
																																																{
																																																	flag2 = false;
																																																}
																																																else
																																																{
																																																	bool flag48 = !object.Equals(this.ActionBindingHoldposition, other.ActionBindingHoldposition);
																																																	if (flag48)
																																																	{
																																																		flag2 = false;
																																																	}
																																																	else
																																																	{
																																																		bool flag49 = !object.Equals(this.ActionBindingSystemmastervolumeup, other.ActionBindingSystemmastervolumeup);
																																																		if (flag49)
																																																		{
																																																			flag2 = false;
																																																		}
																																																		else
																																																		{
																																																			bool flag50 = !object.Equals(this.ActionBindingSystemmastervolumedown, other.ActionBindingSystemmastervolumedown);
																																																			if (flag50)
																																																			{
																																																				flag2 = false;
																																																			}
																																																			else
																																																			{
																																																				bool flag51 = !object.Equals(this.ActionBindingSystemtogglemusic, other.ActionBindingSystemtogglemusic);
																																																				if (flag51)
																																																				{
																																																					flag2 = false;
																																																				}
																																																				else
																																																				{
																																																					bool flag52 = !object.Equals(this.ActionBindingSystemtogglesound, other.ActionBindingSystemtogglesound);
																																																					if (flag52)
																																																					{
																																																						flag2 = false;
																																																					}
																																																					else
																																																					{
																																																						bool flag53 = !object.Equals(this.ActionBindingSystemscreenshot, other.ActionBindingSystemscreenshot);
																																																						if (flag53)
																																																						{
																																																							flag2 = false;
																																																						}
																																																						else
																																																						{
																																																							bool flag54 = !object.Equals(this.ActionBindingSystemtogglefps, other.ActionBindingSystemtogglefps);
																																																							if (flag54)
																																																							{
																																																								flag2 = false;
																																																							}
																																																							else
																																																							{
																																																								bool flag55 = !object.Equals(this.ActionBindingChatpageup, other.ActionBindingChatpageup);
																																																								if (flag55)
																																																								{
																																																									flag2 = false;
																																																								}
																																																								else
																																																								{
																																																									bool flag56 = !object.Equals(this.ActionBindingChatpagedown, other.ActionBindingChatpagedown);
																																																									if (flag56)
																																																									{
																																																										flag2 = false;
																																																									}
																																																									else
																																																									{
																																																										bool flag57 = !object.Equals(this.ActionBindingGroups, other.ActionBindingGroups);
																																																										if (flag57)
																																																										{
																																																											flag2 = false;
																																																										}
																																																										else
																																																										{
																																																											bool flag58 = !object.Equals(this.ActionBindingClan, other.ActionBindingClan);
																																																											if (flag58)
																																																											{
																																																												flag2 = false;
																																																											}
																																																											else
																																																											{
																																																												bool flag59 = !object.Equals(this.ActionBindingChatNextView, other.ActionBindingChatNextView);
																																																												if (flag59)
																																																												{
																																																													flag2 = false;
																																																												}
																																																												else
																																																												{
																																																													bool flag60 = !object.Equals(this.ActionBindingChatPreviousView, other.ActionBindingChatPreviousView);
																																																													if (flag60)
																																																													{
																																																														flag2 = false;
																																																													}
																																																													else
																																																													{
																																																														bool flag61 = !object.Equals(this.ActionBindingLeaderboards, other.ActionBindingLeaderboards);
																																																														if (flag61)
																																																														{
																																																															flag2 = false;
																																																														}
																																																														else
																																																														{
																																																															bool flag62 = !object.Equals(this.ActionBindingChatResetFade, other.ActionBindingChatResetFade);
																																																															if (flag62)
																																																															{
																																																																flag2 = false;
																																																															}
																																																															else
																																																															{
																																																																bool flag63 = !object.Equals(this.ActionBindingQuests, other.ActionBindingQuests);
																																																																if (flag63)
																																																																{
																																																																	flag2 = false;
																																																																}
																																																																else
																																																																{
																																																																	bool flag64 = !object.Equals(this.ActionBindingQuestsToggle, other.ActionBindingQuestsToggle);
																																																																	if (flag64)
																																																																	{
																																																																		flag2 = false;
																																																																	}
																																																																	else
																																																																	{
																																																																		bool flag65 = !object.Equals(this.ActionBindingRun, other.ActionBindingRun);
																																																																		if (flag65)
																																																																		{
																																																																			flag2 = false;
																																																																		}
																																																																		else
																																																																		{
																																																																			bool flag66 = !object.Equals(this.ActionBindingInteract, other.ActionBindingInteract);
																																																																			if (flag66)
																																																																			{
																																																																				flag2 = false;
																																																																			}
																																																																			else
																																																																			{
																																																																				bool flag67 = !object.Equals(this.ActionBindingPrimary, other.ActionBindingPrimary);
																																																																				if (flag67)
																																																																				{
																																																																					flag2 = false;
																																																																				}
																																																																				else
																																																																				{
																																																																					bool flag68 = !object.Equals(this.ActionBindingSecondary, other.ActionBindingSecondary);
																																																																					if (flag68)
																																																																					{
																																																																						flag2 = false;
																																																																					}
																																																																					else
																																																																					{
																																																																						bool flag69 = !object.Equals(this.ActionBindingSkill1, other.ActionBindingSkill1);
																																																																						if (flag69)
																																																																						{
																																																																							flag2 = false;
																																																																						}
																																																																						else
																																																																						{
																																																																							bool flag70 = !object.Equals(this.ActionBindingSkill2, other.ActionBindingSkill2);
																																																																							if (flag70)
																																																																							{
																																																																								flag2 = false;
																																																																							}
																																																																							else
																																																																							{
																																																																								bool flag71 = !object.Equals(this.ActionBindingSkill3, other.ActionBindingSkill3);
																																																																								if (flag71)
																																																																								{
																																																																									flag2 = false;
																																																																								}
																																																																								else
																																																																								{
																																																																									bool flag72 = !object.Equals(this.ActionBindingSkill4, other.ActionBindingSkill4);
																																																																									if (flag72)
																																																																									{
																																																																										flag2 = false;
																																																																									}
																																																																									else
																																																																									{
																																																																										bool flag73 = !object.Equals(this.ActionBindingMount, other.ActionBindingMount);
																																																																										if (flag73)
																																																																										{
																																																																											flag2 = false;
																																																																										}
																																																																										else
																																																																										{
																																																																											bool flag74 = !object.Equals(this.ActionBindingEvade, other.ActionBindingEvade);
																																																																											if (flag74)
																																																																											{
																																																																												flag2 = false;
																																																																											}
																																																																											else
																																																																											{
																																																																												bool flag75 = !object.Equals(this.ActionBindingUseItem, other.ActionBindingUseItem);
																																																																												if (flag75)
																																																																												{
																																																																													flag2 = false;
																																																																												}
																																																																												else
																																																																												{
																																																																													bool flag76 = !object.Equals(this.ActionBindingCenterCamera, other.ActionBindingCenterCamera);
																																																																													if (flag76)
																																																																													{
																																																																														flag2 = false;
																																																																													}
																																																																													else
																																																																													{
																																																																														bool flag77 = !object.Equals(this.ActionBindingDebugCamera, other.ActionBindingDebugCamera);
																																																																														if (flag77)
																																																																														{
																																																																															flag2 = false;
																																																																														}
																																																																														else
																																																																														{
																																																																															bool flag78 = !object.Equals(this.ActionBindingSocialInteract, other.ActionBindingSocialInteract);
																																																																															if (flag78)
																																																																															{
																																																																																flag2 = false;
																																																																															}
																																																																															else
																																																																															{
																																																																																bool flag79 = !object.Equals(this.ActionBindingAcceptPartyInvite, other.ActionBindingAcceptPartyInvite);
																																																																																if (flag79)
																																																																																{
																																																																																	flag2 = false;
																																																																																}
																																																																																else
																																																																																{
																																																																																	bool flag80 = !object.Equals(this.ActionBindingLockTarget, other.ActionBindingLockTarget);
																																																																																	if (flag80)
																																																																																	{
																																																																																		flag2 = false;
																																																																																	}
																																																																																	else
																																																																																	{
																																																																																		bool flag81 = !object.Equals(this.ActionBindingTownPortal, other.ActionBindingTownPortal);
																																																																																		if (flag81)
																																																																																		{
																																																																																			flag2 = false;
																																																																																		}
																																																																																		else
																																																																																		{
																																																																																			bool flag82 = !object.Equals(this.ActionBindingForceMove, other.ActionBindingForceMove);
																																																																																			if (flag82)
																																																																																			{
																																																																																				flag2 = false;
																																																																																			}
																																																																																			else
																																																																																			{
																																																																																				bool flag83 = !object.Equals(this.ActionBindingClassScreen, other.ActionBindingClassScreen);
																																																																																				if (flag83)
																																																																																				{
																																																																																					flag2 = false;
																																																																																				}
																																																																																				else
																																																																																				{
																																																																																					bool flag84 = !object.Equals(this.ActionBindingCycleLockTarget, other.ActionBindingCycleLockTarget);
																																																																																					if (flag84)
																																																																																					{
																																																																																						flag2 = false;
																																																																																					}
																																																																																					else
																																																																																					{
																																																																																						bool flag85 = this.NotifyDuration != other.NotifyDuration;
																																																																																						if (flag85)
																																																																																						{
																																																																																							flag2 = false;
																																																																																						}
																																																																																						else
																																																																																						{
																																																																																							bool flag86 = this.KeybindingVersion != other.KeybindingVersion;
																																																																																							if (flag86)
																																																																																							{
																																																																																								flag2 = false;
																																																																																							}
																																																																																							else
																																																																																							{
																																																																																								bool flag87 = this.Flags2 != other.Flags2;
																																																																																								if (flag87)
																																																																																								{
																																																																																									flag2 = false;
																																																																																								}
																																																																																								else
																																																																																								{
																																																																																									bool flag88 = this.ControlScheme != other.ControlScheme;
																																																																																									if (flag88)
																																																																																									{
																																																																																										flag2 = false;
																																																																																									}
																																																																																									else
																																																																																									{
																																																																																										bool flag89 = this.ControllerButtonBindingVersion != other.ControllerButtonBindingVersion;
																																																																																										if (flag89)
																																																																																										{
																																																																																											flag2 = false;
																																																																																										}
																																																																																										else
																																																																																										{
																																																																																											bool flag90 = !object.Equals(this.ControllerBindingsXinput, other.ControllerBindingsXinput);
																																																																																											if (flag90)
																																																																																											{
																																																																																												flag2 = false;
																																																																																											}
																																																																																											else
																																																																																											{
																																																																																												bool flag91 = !object.Equals(this.ControllerBindingsPs4, other.ControllerBindingsPs4);
																																																																																												if (flag91)
																																																																																												{
																																																																																													flag2 = false;
																																																																																												}
																																																																																												else
																																																																																												{
																																																																																													bool flag92 = !object.Equals(this.ControllerBindingsNx64, other.ControllerBindingsNx64);
																																																																																													if (flag92)
																																																																																													{
																																																																																														flag2 = false;
																																																																																													}
																																																																																													else
																																																																																													{
																																																																																														bool flag93 = this.ChatBackgroundOpacityWhenActive != other.ChatBackgroundOpacityWhenActive;
																																																																																														if (flag93)
																																																																																														{
																																																																																															flag2 = false;
																																																																																														}
																																																																																														else
																																																																																														{
																																																																																															bool flag94 = this.ChatTimestampFormat != other.ChatTimestampFormat;
																																																																																															if (flag94)
																																																																																															{
																																																																																																flag2 = false;
																																																																																															}
																																																																																															else
																																																																																															{
																																																																																																bool flag95 = this.ItemLabelOnDropDuration != other.ItemLabelOnDropDuration;
																																																																																																if (flag95)
																																																																																																{
																																																																																																	flag2 = false;
																																																																																																}
																																																																																																else
																																																																																																{
																																																																																																	bool flag96 = this.ItemLabelDisplayMode != other.ItemLabelDisplayMode;
																																																																																																	if (flag96)
																																																																																																	{
																																																																																																		flag2 = false;
																																																																																																	}
																																																																																																	else
																																																																																																	{
																																																																																																		bool flag97 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ControllerCursorSensitivity, other.ControllerCursorSensitivity);
																																																																																																		if (flag97)
																																																																																																		{
																																																																																																			flag2 = false;
																																																																																																		}
																																																																																																		else
																																																																																																		{
																																																																																																			bool flag98 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ControllerInnerDeadZone, other.ControllerInnerDeadZone);
																																																																																																			if (flag98)
																																																																																																			{
																																																																																																				flag2 = false;
																																																																																																			}
																																																																																																			else
																																																																																																			{
																																																																																																				bool flag99 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ControllerOuterDeadZone, other.ControllerOuterDeadZone);
																																																																																																				if (flag99)
																																																																																																				{
																																																																																																					flag2 = false;
																																																																																																				}
																																																																																																				else
																																																																																																				{
																																																																																																					bool flag100 = this.PowerToggleMode != other.PowerToggleMode;
																																																																																																					if (flag100)
																																																																																																					{
																																																																																																						flag2 = false;
																																																																																																					}
																																																																																																					else
																																																																																																					{
																																																																																																						bool flag101 = this.SocialWheelActivationStyle != other.SocialWheelActivationStyle;
																																																																																																						if (flag101)
																																																																																																						{
																																																																																																							flag2 = false;
																																																																																																						}
																																																																																																						else
																																																																																																						{
																																																																																																							bool flag102 = this.MonsterHealthBarMode != other.MonsterHealthBarMode;
																																																																																																							if (flag102)
																																																																																																							{
																																																																																																								flag2 = false;
																																																																																																							}
																																																																																																							else
																																																																																																							{
																																																																																																								bool flag103 = this.HoldPositionInputMode != other.HoldPositionInputMode;
																																																																																																								if (flag103)
																																																																																																								{
																																																																																																									flag2 = false;
																																																																																																								}
																																																																																																								else
																																																																																																								{
																																																																																																									bool flag104 = !object.Equals(this.ControllerBindingsPs5, other.ControllerBindingsPs5);
																																																																																																									flag2 = !flag104 && object.Equals(this._unknownFields, other._unknownFields);
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
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x00064CFC File Offset: 0x00062EFC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num ^= this.Version.GetHashCode();
			}
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				num ^= this.Flags.GetHashCode();
			}
			bool hasDeprecatedItemsOnGroundSetting = this.HasDeprecatedItemsOnGroundSetting;
			if (hasDeprecatedItemsOnGroundSetting)
			{
				num ^= this.DeprecatedItemsOnGroundSetting.GetHashCode();
			}
			bool flag = this.actionBindingHireling_ != null;
			if (flag)
			{
				num ^= this.ActionBindingHireling.GetHashCode();
			}
			bool flag2 = this.actionBindingSkills_ != null;
			if (flag2)
			{
				num ^= this.ActionBindingSkills.GetHashCode();
			}
			bool flag3 = this.actionBindingAcceptPartyInviteRequest_ != null;
			if (flag3)
			{
				num ^= this.ActionBindingAcceptPartyInviteRequest.GetHashCode();
			}
			bool flag4 = this.actionBindingLore_ != null;
			if (flag4)
			{
				num ^= this.ActionBindingLore.GetHashCode();
			}
			bool flag5 = this.actionBindingSocial_ != null;
			if (flag5)
			{
				num ^= this.ActionBindingSocial.GetHashCode();
			}
			bool flag6 = this.actionBindingHelp_ != null;
			if (flag6)
			{
				num ^= this.ActionBindingHelp.GetHashCode();
			}
			bool flag7 = this.actionBindingRecentplayers_ != null;
			if (flag7)
			{
				num ^= this.ActionBindingRecentplayers.GetHashCode();
			}
			bool flag8 = this.actionBindingChatlobby_ != null;
			if (flag8)
			{
				num ^= this.ActionBindingChatlobby.GetHashCode();
			}
			bool flag9 = this.actionBindingAchievements_ != null;
			if (flag9)
			{
				num ^= this.ActionBindingAchievements.GetHashCode();
			}
			bool flag10 = this.actionBindingProfile_ != null;
			if (flag10)
			{
				num ^= this.ActionBindingProfile.GetHashCode();
			}
			bool flag11 = this.actionBindingEquippables_ != null;
			if (flag11)
			{
				num ^= this.ActionBindingEquippables.GetHashCode();
			}
			bool flag12 = this.actionBindingConsole_ != null;
			if (flag12)
			{
				num ^= this.ActionBindingConsole.GetHashCode();
			}
			bool flag13 = this.actionBindingMap_ != null;
			if (flag13)
			{
				num ^= this.ActionBindingMap.GetHashCode();
			}
			bool flag14 = this.actionBindingSkillTree_ != null;
			if (flag14)
			{
				num ^= this.ActionBindingSkillTree.GetHashCode();
			}
			bool flag15 = this.actionBindingToggleplayerhpbars_ != null;
			if (flag15)
			{
				num ^= this.ActionBindingToggleplayerhpbars.GetHashCode();
			}
			bool flag16 = this.actionBindingToggledamagenumbers_ != null;
			if (flag16)
			{
				num ^= this.ActionBindingToggledamagenumbers.GetHashCode();
			}
			bool flag17 = this.actionBindingToggleitemsonground_ != null;
			if (flag17)
			{
				num ^= this.ActionBindingToggleitemsonground.GetHashCode();
			}
			bool flag18 = this.actionBindingRewhisper_ != null;
			if (flag18)
			{
				num ^= this.ActionBindingRewhisper.GetHashCode();
			}
			bool flag19 = this.actionBindingWhisperreply_ != null;
			if (flag19)
			{
				num ^= this.ActionBindingWhisperreply.GetHashCode();
			}
			bool flag20 = this.actionBindingVoiceptt_ != null;
			if (flag20)
			{
				num ^= this.ActionBindingVoiceptt.GetHashCode();
			}
			bool flag21 = this.actionBindingSocialwheel_ != null;
			if (flag21)
			{
				num ^= this.ActionBindingSocialwheel.GetHashCode();
			}
			bool flag22 = this.actionBindingFastquesttrack_ != null;
			if (flag22)
			{
				num ^= this.ActionBindingFastquesttrack.GetHashCode();
			}
			bool flag23 = this.actionBindingToggleLfdCompanions_ != null;
			if (flag23)
			{
				num ^= this.ActionBindingToggleLfdCompanions.GetHashCode();
			}
			bool flag24 = this.actionBindingCollections_ != null;
			if (flag24)
			{
				num ^= this.ActionBindingCollections.GetHashCode();
			}
			num ^= this.actionBindingSocialwheelLeft_.GetHashCode();
			num ^= this.actionBindingSocialwheelMiddle_.GetHashCode();
			num ^= this.actionBindingSocialwheelRight_.GetHashCode();
			bool flag25 = this.actionBindingSocialwheelPageBackward_ != null;
			if (flag25)
			{
				num ^= this.ActionBindingSocialwheelPageBackward.GetHashCode();
			}
			bool flag26 = this.actionBindingSocialwheelPageForward_ != null;
			if (flag26)
			{
				num ^= this.ActionBindingSocialwheelPageForward.GetHashCode();
			}
			bool flag27 = this.actionBindingAbilities_ != null;
			if (flag27)
			{
				num ^= this.ActionBindingAbilities.GetHashCode();
			}
			bool flag28 = this.actionBindingReportBug_ != null;
			if (flag28)
			{
				num ^= this.ActionBindingReportBug.GetHashCode();
			}
			bool flag29 = this.actionBindingReportContent_ != null;
			if (flag29)
			{
				num ^= this.ActionBindingReportContent.GetHashCode();
			}
			bool flag30 = this.actionBindingJoinSpeechToTextChat_ != null;
			if (flag30)
			{
				num ^= this.ActionBindingJoinSpeechToTextChat.GetHashCode();
			}
			bool flag31 = this.actionBindingTtsSkipCurrentUtterance_ != null;
			if (flag31)
			{
				num ^= this.ActionBindingTtsSkipCurrentUtterance.GetHashCode();
			}
			bool flag32 = this.actionBindingTtsCancelAllUtterances_ != null;
			if (flag32)
			{
				num ^= this.ActionBindingTtsCancelAllUtterances.GetHashCode();
			}
			bool flag33 = this.actionBindingScreenReaderSkipLine_ != null;
			if (flag33)
			{
				num ^= this.ActionBindingScreenReaderSkipLine.GetHashCode();
			}
			bool flag34 = this.actionBindingStore_ != null;
			if (flag34)
			{
				num ^= this.ActionBindingStore.GetHashCode();
			}
			bool flag35 = this.actionBindingMountSpur_ != null;
			if (flag35)
			{
				num ^= this.ActionBindingMountSpur.GetHashCode();
			}
			bool flag36 = this.actionBindingMountDismount_ != null;
			if (flag36)
			{
				num ^= this.ActionBindingMountDismount.GetHashCode();
			}
			bool flag37 = this.actionBindingMountCombatDismount_ != null;
			if (flag37)
			{
				num ^= this.ActionBindingMountCombatDismount.GetHashCode();
			}
			bool flag38 = this.actionBindingToggleZoom_ != null;
			if (flag38)
			{
				num ^= this.ActionBindingToggleZoom.GetHashCode();
			}
			bool flag39 = this.actionBindingHoldposition_ != null;
			if (flag39)
			{
				num ^= this.ActionBindingHoldposition.GetHashCode();
			}
			bool flag40 = this.actionBindingSystemmastervolumeup_ != null;
			if (flag40)
			{
				num ^= this.ActionBindingSystemmastervolumeup.GetHashCode();
			}
			bool flag41 = this.actionBindingSystemmastervolumedown_ != null;
			if (flag41)
			{
				num ^= this.ActionBindingSystemmastervolumedown.GetHashCode();
			}
			bool flag42 = this.actionBindingSystemtogglemusic_ != null;
			if (flag42)
			{
				num ^= this.ActionBindingSystemtogglemusic.GetHashCode();
			}
			bool flag43 = this.actionBindingSystemtogglesound_ != null;
			if (flag43)
			{
				num ^= this.ActionBindingSystemtogglesound.GetHashCode();
			}
			bool flag44 = this.actionBindingSystemscreenshot_ != null;
			if (flag44)
			{
				num ^= this.ActionBindingSystemscreenshot.GetHashCode();
			}
			bool flag45 = this.actionBindingSystemtogglefps_ != null;
			if (flag45)
			{
				num ^= this.ActionBindingSystemtogglefps.GetHashCode();
			}
			bool flag46 = this.actionBindingChatpageup_ != null;
			if (flag46)
			{
				num ^= this.ActionBindingChatpageup.GetHashCode();
			}
			bool flag47 = this.actionBindingChatpagedown_ != null;
			if (flag47)
			{
				num ^= this.ActionBindingChatpagedown.GetHashCode();
			}
			bool flag48 = this.actionBindingGroups_ != null;
			if (flag48)
			{
				num ^= this.ActionBindingGroups.GetHashCode();
			}
			bool flag49 = this.actionBindingClan_ != null;
			if (flag49)
			{
				num ^= this.ActionBindingClan.GetHashCode();
			}
			bool flag50 = this.actionBindingChatNextView_ != null;
			if (flag50)
			{
				num ^= this.ActionBindingChatNextView.GetHashCode();
			}
			bool flag51 = this.actionBindingChatPreviousView_ != null;
			if (flag51)
			{
				num ^= this.ActionBindingChatPreviousView.GetHashCode();
			}
			bool flag52 = this.actionBindingLeaderboards_ != null;
			if (flag52)
			{
				num ^= this.ActionBindingLeaderboards.GetHashCode();
			}
			bool flag53 = this.actionBindingChatResetFade_ != null;
			if (flag53)
			{
				num ^= this.ActionBindingChatResetFade.GetHashCode();
			}
			bool flag54 = this.actionBindingQuests_ != null;
			if (flag54)
			{
				num ^= this.ActionBindingQuests.GetHashCode();
			}
			bool flag55 = this.actionBindingQuestsToggle_ != null;
			if (flag55)
			{
				num ^= this.ActionBindingQuestsToggle.GetHashCode();
			}
			bool flag56 = this.actionBindingRun_ != null;
			if (flag56)
			{
				num ^= this.ActionBindingRun.GetHashCode();
			}
			bool flag57 = this.actionBindingInteract_ != null;
			if (flag57)
			{
				num ^= this.ActionBindingInteract.GetHashCode();
			}
			bool flag58 = this.actionBindingPrimary_ != null;
			if (flag58)
			{
				num ^= this.ActionBindingPrimary.GetHashCode();
			}
			bool flag59 = this.actionBindingSecondary_ != null;
			if (flag59)
			{
				num ^= this.ActionBindingSecondary.GetHashCode();
			}
			bool flag60 = this.actionBindingSkill1_ != null;
			if (flag60)
			{
				num ^= this.ActionBindingSkill1.GetHashCode();
			}
			bool flag61 = this.actionBindingSkill2_ != null;
			if (flag61)
			{
				num ^= this.ActionBindingSkill2.GetHashCode();
			}
			bool flag62 = this.actionBindingSkill3_ != null;
			if (flag62)
			{
				num ^= this.ActionBindingSkill3.GetHashCode();
			}
			bool flag63 = this.actionBindingSkill4_ != null;
			if (flag63)
			{
				num ^= this.ActionBindingSkill4.GetHashCode();
			}
			bool flag64 = this.actionBindingMount_ != null;
			if (flag64)
			{
				num ^= this.ActionBindingMount.GetHashCode();
			}
			bool flag65 = this.actionBindingEvade_ != null;
			if (flag65)
			{
				num ^= this.ActionBindingEvade.GetHashCode();
			}
			bool flag66 = this.actionBindingUseItem_ != null;
			if (flag66)
			{
				num ^= this.ActionBindingUseItem.GetHashCode();
			}
			bool flag67 = this.actionBindingCenterCamera_ != null;
			if (flag67)
			{
				num ^= this.ActionBindingCenterCamera.GetHashCode();
			}
			bool flag68 = this.actionBindingDebugCamera_ != null;
			if (flag68)
			{
				num ^= this.ActionBindingDebugCamera.GetHashCode();
			}
			bool flag69 = this.actionBindingSocialInteract_ != null;
			if (flag69)
			{
				num ^= this.ActionBindingSocialInteract.GetHashCode();
			}
			bool flag70 = this.actionBindingAcceptPartyInvite_ != null;
			if (flag70)
			{
				num ^= this.ActionBindingAcceptPartyInvite.GetHashCode();
			}
			bool flag71 = this.actionBindingLockTarget_ != null;
			if (flag71)
			{
				num ^= this.ActionBindingLockTarget.GetHashCode();
			}
			bool flag72 = this.actionBindingTownPortal_ != null;
			if (flag72)
			{
				num ^= this.ActionBindingTownPortal.GetHashCode();
			}
			bool flag73 = this.actionBindingForceMove_ != null;
			if (flag73)
			{
				num ^= this.ActionBindingForceMove.GetHashCode();
			}
			bool flag74 = this.actionBindingClassScreen_ != null;
			if (flag74)
			{
				num ^= this.ActionBindingClassScreen.GetHashCode();
			}
			bool flag75 = this.actionBindingCycleLockTarget_ != null;
			if (flag75)
			{
				num ^= this.ActionBindingCycleLockTarget.GetHashCode();
			}
			bool hasNotifyDuration = this.HasNotifyDuration;
			if (hasNotifyDuration)
			{
				num ^= this.NotifyDuration.GetHashCode();
			}
			bool hasKeybindingVersion = this.HasKeybindingVersion;
			if (hasKeybindingVersion)
			{
				num ^= this.KeybindingVersion.GetHashCode();
			}
			bool hasFlags2 = this.HasFlags2;
			if (hasFlags2)
			{
				num ^= this.Flags2.GetHashCode();
			}
			bool hasControlScheme = this.HasControlScheme;
			if (hasControlScheme)
			{
				num ^= this.ControlScheme.GetHashCode();
			}
			bool hasControllerButtonBindingVersion = this.HasControllerButtonBindingVersion;
			if (hasControllerButtonBindingVersion)
			{
				num ^= this.ControllerButtonBindingVersion.GetHashCode();
			}
			bool flag76 = this.controllerBindingsXinput_ != null;
			if (flag76)
			{
				num ^= this.ControllerBindingsXinput.GetHashCode();
			}
			bool flag77 = this.controllerBindingsPs4_ != null;
			if (flag77)
			{
				num ^= this.ControllerBindingsPs4.GetHashCode();
			}
			bool flag78 = this.controllerBindingsNx64_ != null;
			if (flag78)
			{
				num ^= this.ControllerBindingsNx64.GetHashCode();
			}
			bool hasChatBackgroundOpacityWhenActive = this.HasChatBackgroundOpacityWhenActive;
			if (hasChatBackgroundOpacityWhenActive)
			{
				num ^= this.ChatBackgroundOpacityWhenActive.GetHashCode();
			}
			bool hasChatTimestampFormat = this.HasChatTimestampFormat;
			if (hasChatTimestampFormat)
			{
				num ^= this.ChatTimestampFormat.GetHashCode();
			}
			bool hasItemLabelOnDropDuration = this.HasItemLabelOnDropDuration;
			if (hasItemLabelOnDropDuration)
			{
				num ^= this.ItemLabelOnDropDuration.GetHashCode();
			}
			bool hasItemLabelDisplayMode = this.HasItemLabelDisplayMode;
			if (hasItemLabelDisplayMode)
			{
				num ^= this.ItemLabelDisplayMode.GetHashCode();
			}
			bool hasControllerCursorSensitivity = this.HasControllerCursorSensitivity;
			if (hasControllerCursorSensitivity)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.ControllerCursorSensitivity);
			}
			bool hasControllerInnerDeadZone = this.HasControllerInnerDeadZone;
			if (hasControllerInnerDeadZone)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.ControllerInnerDeadZone);
			}
			bool hasControllerOuterDeadZone = this.HasControllerOuterDeadZone;
			if (hasControllerOuterDeadZone)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.ControllerOuterDeadZone);
			}
			bool hasPowerToggleMode = this.HasPowerToggleMode;
			if (hasPowerToggleMode)
			{
				num ^= this.PowerToggleMode.GetHashCode();
			}
			bool hasSocialWheelActivationStyle = this.HasSocialWheelActivationStyle;
			if (hasSocialWheelActivationStyle)
			{
				num ^= this.SocialWheelActivationStyle.GetHashCode();
			}
			bool hasMonsterHealthBarMode = this.HasMonsterHealthBarMode;
			if (hasMonsterHealthBarMode)
			{
				num ^= this.MonsterHealthBarMode.GetHashCode();
			}
			bool hasHoldPositionInputMode = this.HasHoldPositionInputMode;
			if (hasHoldPositionInputMode)
			{
				num ^= this.HoldPositionInputMode.GetHashCode();
			}
			bool flag79 = this.controllerBindingsPs5_ != null;
			if (flag79)
			{
				num ^= this.ControllerBindingsPs5.GetHashCode();
			}
			bool flag80 = this._unknownFields != null;
			if (flag80)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x00065888 File Offset: 0x00063A88
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x000658A0 File Offset: 0x00063AA0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x000658AC File Offset: 0x00063AAC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Version);
			}
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Flags);
			}
			bool hasDeprecatedItemsOnGroundSetting = this.HasDeprecatedItemsOnGroundSetting;
			if (hasDeprecatedItemsOnGroundSetting)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.DeprecatedItemsOnGroundSetting);
			}
			bool flag = this.actionBindingHireling_ != null;
			if (flag)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.ActionBindingHireling);
			}
			bool flag2 = this.actionBindingSkills_ != null;
			if (flag2)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.ActionBindingSkills);
			}
			bool flag3 = this.actionBindingAcceptPartyInviteRequest_ != null;
			if (flag3)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.ActionBindingAcceptPartyInviteRequest);
			}
			bool flag4 = this.actionBindingLore_ != null;
			if (flag4)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.ActionBindingLore);
			}
			bool flag5 = this.actionBindingSocial_ != null;
			if (flag5)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.ActionBindingSocial);
			}
			bool flag6 = this.actionBindingHelp_ != null;
			if (flag6)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.ActionBindingHelp);
			}
			bool flag7 = this.actionBindingRecentplayers_ != null;
			if (flag7)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.ActionBindingRecentplayers);
			}
			bool flag8 = this.actionBindingChatlobby_ != null;
			if (flag8)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.ActionBindingChatlobby);
			}
			bool flag9 = this.actionBindingAchievements_ != null;
			if (flag9)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.ActionBindingAchievements);
			}
			bool flag10 = this.actionBindingProfile_ != null;
			if (flag10)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.ActionBindingProfile);
			}
			bool flag11 = this.actionBindingEquippables_ != null;
			if (flag11)
			{
				output.WriteRawTag(130, 1);
				output.WriteMessage(this.ActionBindingEquippables);
			}
			bool flag12 = this.actionBindingConsole_ != null;
			if (flag12)
			{
				output.WriteRawTag(146, 1);
				output.WriteMessage(this.ActionBindingConsole);
			}
			bool flag13 = this.actionBindingMap_ != null;
			if (flag13)
			{
				output.WriteRawTag(154, 1);
				output.WriteMessage(this.ActionBindingMap);
			}
			bool flag14 = this.actionBindingSkillTree_ != null;
			if (flag14)
			{
				output.WriteRawTag(162, 1);
				output.WriteMessage(this.ActionBindingSkillTree);
			}
			bool flag15 = this.actionBindingToggleplayerhpbars_ != null;
			if (flag15)
			{
				output.WriteRawTag(178, 1);
				output.WriteMessage(this.ActionBindingToggleplayerhpbars);
			}
			bool flag16 = this.actionBindingToggledamagenumbers_ != null;
			if (flag16)
			{
				output.WriteRawTag(186, 1);
				output.WriteMessage(this.ActionBindingToggledamagenumbers);
			}
			bool flag17 = this.actionBindingToggleitemsonground_ != null;
			if (flag17)
			{
				output.WriteRawTag(194, 1);
				output.WriteMessage(this.ActionBindingToggleitemsonground);
			}
			bool flag18 = this.actionBindingRewhisper_ != null;
			if (flag18)
			{
				output.WriteRawTag(202, 1);
				output.WriteMessage(this.ActionBindingRewhisper);
			}
			bool flag19 = this.actionBindingWhisperreply_ != null;
			if (flag19)
			{
				output.WriteRawTag(210, 1);
				output.WriteMessage(this.ActionBindingWhisperreply);
			}
			bool flag20 = this.actionBindingVoiceptt_ != null;
			if (flag20)
			{
				output.WriteRawTag(218, 1);
				output.WriteMessage(this.ActionBindingVoiceptt);
			}
			bool flag21 = this.actionBindingSocialwheel_ != null;
			if (flag21)
			{
				output.WriteRawTag(226, 1);
				output.WriteMessage(this.ActionBindingSocialwheel);
			}
			bool flag22 = this.actionBindingFastquesttrack_ != null;
			if (flag22)
			{
				output.WriteRawTag(234, 1);
				output.WriteMessage(this.ActionBindingFastquesttrack);
			}
			bool flag23 = this.actionBindingToggleLfdCompanions_ != null;
			if (flag23)
			{
				output.WriteRawTag(242, 1);
				output.WriteMessage(this.ActionBindingToggleLfdCompanions);
			}
			bool flag24 = this.actionBindingCollections_ != null;
			if (flag24)
			{
				output.WriteRawTag(250, 1);
				output.WriteMessage(this.ActionBindingCollections);
			}
			this.actionBindingSocialwheelLeft_.WriteTo(ref output, Preferences._repeated_actionBindingSocialwheelLeft_codec);
			this.actionBindingSocialwheelMiddle_.WriteTo(ref output, Preferences._repeated_actionBindingSocialwheelMiddle_codec);
			this.actionBindingSocialwheelRight_.WriteTo(ref output, Preferences._repeated_actionBindingSocialwheelRight_codec);
			bool flag25 = this.actionBindingSocialwheelPageBackward_ != null;
			if (flag25)
			{
				output.WriteRawTag(154, 2);
				output.WriteMessage(this.ActionBindingSocialwheelPageBackward);
			}
			bool flag26 = this.actionBindingSocialwheelPageForward_ != null;
			if (flag26)
			{
				output.WriteRawTag(162, 2);
				output.WriteMessage(this.ActionBindingSocialwheelPageForward);
			}
			bool flag27 = this.actionBindingAbilities_ != null;
			if (flag27)
			{
				output.WriteRawTag(170, 2);
				output.WriteMessage(this.ActionBindingAbilities);
			}
			bool flag28 = this.actionBindingReportBug_ != null;
			if (flag28)
			{
				output.WriteRawTag(178, 2);
				output.WriteMessage(this.ActionBindingReportBug);
			}
			bool flag29 = this.actionBindingReportContent_ != null;
			if (flag29)
			{
				output.WriteRawTag(186, 2);
				output.WriteMessage(this.ActionBindingReportContent);
			}
			bool flag30 = this.actionBindingJoinSpeechToTextChat_ != null;
			if (flag30)
			{
				output.WriteRawTag(194, 2);
				output.WriteMessage(this.ActionBindingJoinSpeechToTextChat);
			}
			bool flag31 = this.actionBindingTtsSkipCurrentUtterance_ != null;
			if (flag31)
			{
				output.WriteRawTag(202, 2);
				output.WriteMessage(this.ActionBindingTtsSkipCurrentUtterance);
			}
			bool flag32 = this.actionBindingTtsCancelAllUtterances_ != null;
			if (flag32)
			{
				output.WriteRawTag(210, 2);
				output.WriteMessage(this.ActionBindingTtsCancelAllUtterances);
			}
			bool flag33 = this.actionBindingScreenReaderSkipLine_ != null;
			if (flag33)
			{
				output.WriteRawTag(218, 2);
				output.WriteMessage(this.ActionBindingScreenReaderSkipLine);
			}
			bool flag34 = this.actionBindingStore_ != null;
			if (flag34)
			{
				output.WriteRawTag(226, 2);
				output.WriteMessage(this.ActionBindingStore);
			}
			bool flag35 = this.actionBindingMountSpur_ != null;
			if (flag35)
			{
				output.WriteRawTag(234, 2);
				output.WriteMessage(this.ActionBindingMountSpur);
			}
			bool flag36 = this.actionBindingMountDismount_ != null;
			if (flag36)
			{
				output.WriteRawTag(242, 2);
				output.WriteMessage(this.ActionBindingMountDismount);
			}
			bool flag37 = this.actionBindingMountCombatDismount_ != null;
			if (flag37)
			{
				output.WriteRawTag(250, 2);
				output.WriteMessage(this.ActionBindingMountCombatDismount);
			}
			bool flag38 = this.actionBindingToggleZoom_ != null;
			if (flag38)
			{
				output.WriteRawTag(130, 3);
				output.WriteMessage(this.ActionBindingToggleZoom);
			}
			bool flag39 = this.actionBindingHoldposition_ != null;
			if (flag39)
			{
				output.WriteRawTag(170, 3);
				output.WriteMessage(this.ActionBindingHoldposition);
			}
			bool flag40 = this.actionBindingSystemmastervolumeup_ != null;
			if (flag40)
			{
				output.WriteRawTag(178, 3);
				output.WriteMessage(this.ActionBindingSystemmastervolumeup);
			}
			bool flag41 = this.actionBindingSystemmastervolumedown_ != null;
			if (flag41)
			{
				output.WriteRawTag(186, 3);
				output.WriteMessage(this.ActionBindingSystemmastervolumedown);
			}
			bool flag42 = this.actionBindingSystemtogglemusic_ != null;
			if (flag42)
			{
				output.WriteRawTag(194, 3);
				output.WriteMessage(this.ActionBindingSystemtogglemusic);
			}
			bool flag43 = this.actionBindingSystemtogglesound_ != null;
			if (flag43)
			{
				output.WriteRawTag(202, 3);
				output.WriteMessage(this.ActionBindingSystemtogglesound);
			}
			bool flag44 = this.actionBindingSystemscreenshot_ != null;
			if (flag44)
			{
				output.WriteRawTag(210, 3);
				output.WriteMessage(this.ActionBindingSystemscreenshot);
			}
			bool flag45 = this.actionBindingSystemtogglefps_ != null;
			if (flag45)
			{
				output.WriteRawTag(130, 4);
				output.WriteMessage(this.ActionBindingSystemtogglefps);
			}
			bool flag46 = this.actionBindingChatpageup_ != null;
			if (flag46)
			{
				output.WriteRawTag(138, 4);
				output.WriteMessage(this.ActionBindingChatpageup);
			}
			bool flag47 = this.actionBindingChatpagedown_ != null;
			if (flag47)
			{
				output.WriteRawTag(146, 4);
				output.WriteMessage(this.ActionBindingChatpagedown);
			}
			bool flag48 = this.actionBindingGroups_ != null;
			if (flag48)
			{
				output.WriteRawTag(154, 4);
				output.WriteMessage(this.ActionBindingGroups);
			}
			bool flag49 = this.actionBindingClan_ != null;
			if (flag49)
			{
				output.WriteRawTag(162, 4);
				output.WriteMessage(this.ActionBindingClan);
			}
			bool flag50 = this.actionBindingChatNextView_ != null;
			if (flag50)
			{
				output.WriteRawTag(178, 4);
				output.WriteMessage(this.ActionBindingChatNextView);
			}
			bool flag51 = this.actionBindingChatPreviousView_ != null;
			if (flag51)
			{
				output.WriteRawTag(186, 4);
				output.WriteMessage(this.ActionBindingChatPreviousView);
			}
			bool flag52 = this.actionBindingLeaderboards_ != null;
			if (flag52)
			{
				output.WriteRawTag(194, 4);
				output.WriteMessage(this.ActionBindingLeaderboards);
			}
			bool flag53 = this.actionBindingChatResetFade_ != null;
			if (flag53)
			{
				output.WriteRawTag(202, 4);
				output.WriteMessage(this.ActionBindingChatResetFade);
			}
			bool flag54 = this.actionBindingQuests_ != null;
			if (flag54)
			{
				output.WriteRawTag(210, 4);
				output.WriteMessage(this.ActionBindingQuests);
			}
			bool flag55 = this.actionBindingQuestsToggle_ != null;
			if (flag55)
			{
				output.WriteRawTag(218, 4);
				output.WriteMessage(this.ActionBindingQuestsToggle);
			}
			bool flag56 = this.actionBindingRun_ != null;
			if (flag56)
			{
				output.WriteRawTag(250, 4);
				output.WriteMessage(this.ActionBindingRun);
			}
			bool flag57 = this.actionBindingInteract_ != null;
			if (flag57)
			{
				output.WriteRawTag(130, 5);
				output.WriteMessage(this.ActionBindingInteract);
			}
			bool flag58 = this.actionBindingPrimary_ != null;
			if (flag58)
			{
				output.WriteRawTag(138, 5);
				output.WriteMessage(this.ActionBindingPrimary);
			}
			bool flag59 = this.actionBindingSecondary_ != null;
			if (flag59)
			{
				output.WriteRawTag(146, 5);
				output.WriteMessage(this.ActionBindingSecondary);
			}
			bool flag60 = this.actionBindingSkill1_ != null;
			if (flag60)
			{
				output.WriteRawTag(154, 5);
				output.WriteMessage(this.ActionBindingSkill1);
			}
			bool flag61 = this.actionBindingSkill2_ != null;
			if (flag61)
			{
				output.WriteRawTag(162, 5);
				output.WriteMessage(this.ActionBindingSkill2);
			}
			bool flag62 = this.actionBindingSkill3_ != null;
			if (flag62)
			{
				output.WriteRawTag(170, 5);
				output.WriteMessage(this.ActionBindingSkill3);
			}
			bool flag63 = this.actionBindingSkill4_ != null;
			if (flag63)
			{
				output.WriteRawTag(178, 5);
				output.WriteMessage(this.ActionBindingSkill4);
			}
			bool flag64 = this.actionBindingMount_ != null;
			if (flag64)
			{
				output.WriteRawTag(186, 5);
				output.WriteMessage(this.ActionBindingMount);
			}
			bool flag65 = this.actionBindingEvade_ != null;
			if (flag65)
			{
				output.WriteRawTag(194, 5);
				output.WriteMessage(this.ActionBindingEvade);
			}
			bool flag66 = this.actionBindingUseItem_ != null;
			if (flag66)
			{
				output.WriteRawTag(202, 5);
				output.WriteMessage(this.ActionBindingUseItem);
			}
			bool flag67 = this.actionBindingCenterCamera_ != null;
			if (flag67)
			{
				output.WriteRawTag(210, 5);
				output.WriteMessage(this.ActionBindingCenterCamera);
			}
			bool flag68 = this.actionBindingDebugCamera_ != null;
			if (flag68)
			{
				output.WriteRawTag(218, 5);
				output.WriteMessage(this.ActionBindingDebugCamera);
			}
			bool flag69 = this.actionBindingSocialInteract_ != null;
			if (flag69)
			{
				output.WriteRawTag(234, 5);
				output.WriteMessage(this.ActionBindingSocialInteract);
			}
			bool flag70 = this.actionBindingAcceptPartyInvite_ != null;
			if (flag70)
			{
				output.WriteRawTag(242, 5);
				output.WriteMessage(this.ActionBindingAcceptPartyInvite);
			}
			bool flag71 = this.actionBindingLockTarget_ != null;
			if (flag71)
			{
				output.WriteRawTag(250, 5);
				output.WriteMessage(this.ActionBindingLockTarget);
			}
			bool flag72 = this.actionBindingTownPortal_ != null;
			if (flag72)
			{
				output.WriteRawTag(130, 6);
				output.WriteMessage(this.ActionBindingTownPortal);
			}
			bool flag73 = this.actionBindingForceMove_ != null;
			if (flag73)
			{
				output.WriteRawTag(138, 6);
				output.WriteMessage(this.ActionBindingForceMove);
			}
			bool flag74 = this.actionBindingClassScreen_ != null;
			if (flag74)
			{
				output.WriteRawTag(146, 6);
				output.WriteMessage(this.ActionBindingClassScreen);
			}
			bool flag75 = this.actionBindingCycleLockTarget_ != null;
			if (flag75)
			{
				output.WriteRawTag(154, 6);
				output.WriteMessage(this.ActionBindingCycleLockTarget);
			}
			bool hasNotifyDuration = this.HasNotifyDuration;
			if (hasNotifyDuration)
			{
				output.WriteRawTag(160, 6);
				output.WriteUInt32(this.NotifyDuration);
			}
			bool hasKeybindingVersion = this.HasKeybindingVersion;
			if (hasKeybindingVersion)
			{
				output.WriteRawTag(168, 6);
				output.WriteUInt32(this.KeybindingVersion);
			}
			bool hasFlags2 = this.HasFlags2;
			if (hasFlags2)
			{
				output.WriteRawTag(192, 12);
				output.WriteUInt32(this.Flags2);
			}
			bool hasControlScheme = this.HasControlScheme;
			if (hasControlScheme)
			{
				output.WriteRawTag(237, 12);
				output.WriteSFixed32(this.ControlScheme);
			}
			bool hasControllerButtonBindingVersion = this.HasControllerButtonBindingVersion;
			if (hasControllerButtonBindingVersion)
			{
				output.WriteRawTag(240, 12);
				output.WriteUInt32(this.ControllerButtonBindingVersion);
			}
			bool flag76 = this.controllerBindingsXinput_ != null;
			if (flag76)
			{
				output.WriteRawTag(250, 12);
				output.WriteMessage(this.ControllerBindingsXinput);
			}
			bool flag77 = this.controllerBindingsPs4_ != null;
			if (flag77)
			{
				output.WriteRawTag(130, 13);
				output.WriteMessage(this.ControllerBindingsPs4);
			}
			bool flag78 = this.controllerBindingsNx64_ != null;
			if (flag78)
			{
				output.WriteRawTag(138, 13);
				output.WriteMessage(this.ControllerBindingsNx64);
			}
			bool hasChatBackgroundOpacityWhenActive = this.HasChatBackgroundOpacityWhenActive;
			if (hasChatBackgroundOpacityWhenActive)
			{
				output.WriteRawTag(144, 13);
				output.WriteUInt32(this.ChatBackgroundOpacityWhenActive);
			}
			bool hasChatTimestampFormat = this.HasChatTimestampFormat;
			if (hasChatTimestampFormat)
			{
				output.WriteRawTag(152, 13);
				output.WriteUInt32(this.ChatTimestampFormat);
			}
			bool hasItemLabelOnDropDuration = this.HasItemLabelOnDropDuration;
			if (hasItemLabelOnDropDuration)
			{
				output.WriteRawTag(160, 13);
				output.WriteUInt32(this.ItemLabelOnDropDuration);
			}
			bool hasItemLabelDisplayMode = this.HasItemLabelDisplayMode;
			if (hasItemLabelDisplayMode)
			{
				output.WriteRawTag(168, 13);
				output.WriteUInt32(this.ItemLabelDisplayMode);
			}
			bool hasControllerCursorSensitivity = this.HasControllerCursorSensitivity;
			if (hasControllerCursorSensitivity)
			{
				output.WriteRawTag(181, 13);
				output.WriteFloat(this.ControllerCursorSensitivity);
			}
			bool hasControllerInnerDeadZone = this.HasControllerInnerDeadZone;
			if (hasControllerInnerDeadZone)
			{
				output.WriteRawTag(189, 13);
				output.WriteFloat(this.ControllerInnerDeadZone);
			}
			bool hasControllerOuterDeadZone = this.HasControllerOuterDeadZone;
			if (hasControllerOuterDeadZone)
			{
				output.WriteRawTag(197, 13);
				output.WriteFloat(this.ControllerOuterDeadZone);
			}
			bool hasPowerToggleMode = this.HasPowerToggleMode;
			if (hasPowerToggleMode)
			{
				output.WriteRawTag(200, 13);
				output.WriteUInt32(this.PowerToggleMode);
			}
			bool hasSocialWheelActivationStyle = this.HasSocialWheelActivationStyle;
			if (hasSocialWheelActivationStyle)
			{
				output.WriteRawTag(208, 13);
				output.WriteUInt32(this.SocialWheelActivationStyle);
			}
			bool hasMonsterHealthBarMode = this.HasMonsterHealthBarMode;
			if (hasMonsterHealthBarMode)
			{
				output.WriteRawTag(216, 13);
				output.WriteUInt32(this.MonsterHealthBarMode);
			}
			bool hasHoldPositionInputMode = this.HasHoldPositionInputMode;
			if (hasHoldPositionInputMode)
			{
				output.WriteRawTag(224, 13);
				output.WriteUInt32(this.HoldPositionInputMode);
			}
			bool flag79 = this.controllerBindingsPs5_ != null;
			if (flag79)
			{
				output.WriteRawTag(234, 13);
				output.WriteMessage(this.ControllerBindingsPs5);
			}
			bool flag80 = this._unknownFields != null;
			if (flag80)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x00066920 File Offset: 0x00064B20
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Version);
			}
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Flags);
			}
			bool hasDeprecatedItemsOnGroundSetting = this.HasDeprecatedItemsOnGroundSetting;
			if (hasDeprecatedItemsOnGroundSetting)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DeprecatedItemsOnGroundSetting);
			}
			bool flag = this.actionBindingHireling_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActionBindingHireling);
			}
			bool flag2 = this.actionBindingSkills_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActionBindingSkills);
			}
			bool flag3 = this.actionBindingAcceptPartyInviteRequest_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActionBindingAcceptPartyInviteRequest);
			}
			bool flag4 = this.actionBindingLore_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActionBindingLore);
			}
			bool flag5 = this.actionBindingSocial_ != null;
			if (flag5)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActionBindingSocial);
			}
			bool flag6 = this.actionBindingHelp_ != null;
			if (flag6)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActionBindingHelp);
			}
			bool flag7 = this.actionBindingRecentplayers_ != null;
			if (flag7)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActionBindingRecentplayers);
			}
			bool flag8 = this.actionBindingChatlobby_ != null;
			if (flag8)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActionBindingChatlobby);
			}
			bool flag9 = this.actionBindingAchievements_ != null;
			if (flag9)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActionBindingAchievements);
			}
			bool flag10 = this.actionBindingProfile_ != null;
			if (flag10)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActionBindingProfile);
			}
			bool flag11 = this.actionBindingEquippables_ != null;
			if (flag11)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingEquippables);
			}
			bool flag12 = this.actionBindingConsole_ != null;
			if (flag12)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingConsole);
			}
			bool flag13 = this.actionBindingMap_ != null;
			if (flag13)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingMap);
			}
			bool flag14 = this.actionBindingSkillTree_ != null;
			if (flag14)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingSkillTree);
			}
			bool flag15 = this.actionBindingToggleplayerhpbars_ != null;
			if (flag15)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingToggleplayerhpbars);
			}
			bool flag16 = this.actionBindingToggledamagenumbers_ != null;
			if (flag16)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingToggledamagenumbers);
			}
			bool flag17 = this.actionBindingToggleitemsonground_ != null;
			if (flag17)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingToggleitemsonground);
			}
			bool flag18 = this.actionBindingRewhisper_ != null;
			if (flag18)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingRewhisper);
			}
			bool flag19 = this.actionBindingWhisperreply_ != null;
			if (flag19)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingWhisperreply);
			}
			bool flag20 = this.actionBindingVoiceptt_ != null;
			if (flag20)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingVoiceptt);
			}
			bool flag21 = this.actionBindingSocialwheel_ != null;
			if (flag21)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingSocialwheel);
			}
			bool flag22 = this.actionBindingFastquesttrack_ != null;
			if (flag22)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingFastquesttrack);
			}
			bool flag23 = this.actionBindingToggleLfdCompanions_ != null;
			if (flag23)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingToggleLfdCompanions);
			}
			bool flag24 = this.actionBindingCollections_ != null;
			if (flag24)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingCollections);
			}
			num += this.actionBindingSocialwheelLeft_.CalculateSize(Preferences._repeated_actionBindingSocialwheelLeft_codec);
			num += this.actionBindingSocialwheelMiddle_.CalculateSize(Preferences._repeated_actionBindingSocialwheelMiddle_codec);
			num += this.actionBindingSocialwheelRight_.CalculateSize(Preferences._repeated_actionBindingSocialwheelRight_codec);
			bool flag25 = this.actionBindingSocialwheelPageBackward_ != null;
			if (flag25)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingSocialwheelPageBackward);
			}
			bool flag26 = this.actionBindingSocialwheelPageForward_ != null;
			if (flag26)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingSocialwheelPageForward);
			}
			bool flag27 = this.actionBindingAbilities_ != null;
			if (flag27)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingAbilities);
			}
			bool flag28 = this.actionBindingReportBug_ != null;
			if (flag28)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingReportBug);
			}
			bool flag29 = this.actionBindingReportContent_ != null;
			if (flag29)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingReportContent);
			}
			bool flag30 = this.actionBindingJoinSpeechToTextChat_ != null;
			if (flag30)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingJoinSpeechToTextChat);
			}
			bool flag31 = this.actionBindingTtsSkipCurrentUtterance_ != null;
			if (flag31)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingTtsSkipCurrentUtterance);
			}
			bool flag32 = this.actionBindingTtsCancelAllUtterances_ != null;
			if (flag32)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingTtsCancelAllUtterances);
			}
			bool flag33 = this.actionBindingScreenReaderSkipLine_ != null;
			if (flag33)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingScreenReaderSkipLine);
			}
			bool flag34 = this.actionBindingStore_ != null;
			if (flag34)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingStore);
			}
			bool flag35 = this.actionBindingMountSpur_ != null;
			if (flag35)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingMountSpur);
			}
			bool flag36 = this.actionBindingMountDismount_ != null;
			if (flag36)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingMountDismount);
			}
			bool flag37 = this.actionBindingMountCombatDismount_ != null;
			if (flag37)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingMountCombatDismount);
			}
			bool flag38 = this.actionBindingToggleZoom_ != null;
			if (flag38)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingToggleZoom);
			}
			bool flag39 = this.actionBindingHoldposition_ != null;
			if (flag39)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingHoldposition);
			}
			bool flag40 = this.actionBindingSystemmastervolumeup_ != null;
			if (flag40)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingSystemmastervolumeup);
			}
			bool flag41 = this.actionBindingSystemmastervolumedown_ != null;
			if (flag41)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingSystemmastervolumedown);
			}
			bool flag42 = this.actionBindingSystemtogglemusic_ != null;
			if (flag42)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingSystemtogglemusic);
			}
			bool flag43 = this.actionBindingSystemtogglesound_ != null;
			if (flag43)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingSystemtogglesound);
			}
			bool flag44 = this.actionBindingSystemscreenshot_ != null;
			if (flag44)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingSystemscreenshot);
			}
			bool flag45 = this.actionBindingSystemtogglefps_ != null;
			if (flag45)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingSystemtogglefps);
			}
			bool flag46 = this.actionBindingChatpageup_ != null;
			if (flag46)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingChatpageup);
			}
			bool flag47 = this.actionBindingChatpagedown_ != null;
			if (flag47)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingChatpagedown);
			}
			bool flag48 = this.actionBindingGroups_ != null;
			if (flag48)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingGroups);
			}
			bool flag49 = this.actionBindingClan_ != null;
			if (flag49)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingClan);
			}
			bool flag50 = this.actionBindingChatNextView_ != null;
			if (flag50)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingChatNextView);
			}
			bool flag51 = this.actionBindingChatPreviousView_ != null;
			if (flag51)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingChatPreviousView);
			}
			bool flag52 = this.actionBindingLeaderboards_ != null;
			if (flag52)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingLeaderboards);
			}
			bool flag53 = this.actionBindingChatResetFade_ != null;
			if (flag53)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingChatResetFade);
			}
			bool flag54 = this.actionBindingQuests_ != null;
			if (flag54)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingQuests);
			}
			bool flag55 = this.actionBindingQuestsToggle_ != null;
			if (flag55)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingQuestsToggle);
			}
			bool flag56 = this.actionBindingRun_ != null;
			if (flag56)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingRun);
			}
			bool flag57 = this.actionBindingInteract_ != null;
			if (flag57)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingInteract);
			}
			bool flag58 = this.actionBindingPrimary_ != null;
			if (flag58)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingPrimary);
			}
			bool flag59 = this.actionBindingSecondary_ != null;
			if (flag59)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingSecondary);
			}
			bool flag60 = this.actionBindingSkill1_ != null;
			if (flag60)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingSkill1);
			}
			bool flag61 = this.actionBindingSkill2_ != null;
			if (flag61)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingSkill2);
			}
			bool flag62 = this.actionBindingSkill3_ != null;
			if (flag62)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingSkill3);
			}
			bool flag63 = this.actionBindingSkill4_ != null;
			if (flag63)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingSkill4);
			}
			bool flag64 = this.actionBindingMount_ != null;
			if (flag64)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingMount);
			}
			bool flag65 = this.actionBindingEvade_ != null;
			if (flag65)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingEvade);
			}
			bool flag66 = this.actionBindingUseItem_ != null;
			if (flag66)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingUseItem);
			}
			bool flag67 = this.actionBindingCenterCamera_ != null;
			if (flag67)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingCenterCamera);
			}
			bool flag68 = this.actionBindingDebugCamera_ != null;
			if (flag68)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingDebugCamera);
			}
			bool flag69 = this.actionBindingSocialInteract_ != null;
			if (flag69)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingSocialInteract);
			}
			bool flag70 = this.actionBindingAcceptPartyInvite_ != null;
			if (flag70)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingAcceptPartyInvite);
			}
			bool flag71 = this.actionBindingLockTarget_ != null;
			if (flag71)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingLockTarget);
			}
			bool flag72 = this.actionBindingTownPortal_ != null;
			if (flag72)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingTownPortal);
			}
			bool flag73 = this.actionBindingForceMove_ != null;
			if (flag73)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingForceMove);
			}
			bool flag74 = this.actionBindingClassScreen_ != null;
			if (flag74)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingClassScreen);
			}
			bool flag75 = this.actionBindingCycleLockTarget_ != null;
			if (flag75)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActionBindingCycleLockTarget);
			}
			bool hasNotifyDuration = this.HasNotifyDuration;
			if (hasNotifyDuration)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.NotifyDuration);
			}
			bool hasKeybindingVersion = this.HasKeybindingVersion;
			if (hasKeybindingVersion)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.KeybindingVersion);
			}
			bool hasFlags2 = this.HasFlags2;
			if (hasFlags2)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.Flags2);
			}
			bool hasControlScheme = this.HasControlScheme;
			if (hasControlScheme)
			{
				num += 6;
			}
			bool hasControllerButtonBindingVersion = this.HasControllerButtonBindingVersion;
			if (hasControllerButtonBindingVersion)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.ControllerButtonBindingVersion);
			}
			bool flag76 = this.controllerBindingsXinput_ != null;
			if (flag76)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ControllerBindingsXinput);
			}
			bool flag77 = this.controllerBindingsPs4_ != null;
			if (flag77)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ControllerBindingsPs4);
			}
			bool flag78 = this.controllerBindingsNx64_ != null;
			if (flag78)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ControllerBindingsNx64);
			}
			bool hasChatBackgroundOpacityWhenActive = this.HasChatBackgroundOpacityWhenActive;
			if (hasChatBackgroundOpacityWhenActive)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.ChatBackgroundOpacityWhenActive);
			}
			bool hasChatTimestampFormat = this.HasChatTimestampFormat;
			if (hasChatTimestampFormat)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.ChatTimestampFormat);
			}
			bool hasItemLabelOnDropDuration = this.HasItemLabelOnDropDuration;
			if (hasItemLabelOnDropDuration)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.ItemLabelOnDropDuration);
			}
			bool hasItemLabelDisplayMode = this.HasItemLabelDisplayMode;
			if (hasItemLabelDisplayMode)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.ItemLabelDisplayMode);
			}
			bool hasControllerCursorSensitivity = this.HasControllerCursorSensitivity;
			if (hasControllerCursorSensitivity)
			{
				num += 6;
			}
			bool hasControllerInnerDeadZone = this.HasControllerInnerDeadZone;
			if (hasControllerInnerDeadZone)
			{
				num += 6;
			}
			bool hasControllerOuterDeadZone = this.HasControllerOuterDeadZone;
			if (hasControllerOuterDeadZone)
			{
				num += 6;
			}
			bool hasPowerToggleMode = this.HasPowerToggleMode;
			if (hasPowerToggleMode)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.PowerToggleMode);
			}
			bool hasSocialWheelActivationStyle = this.HasSocialWheelActivationStyle;
			if (hasSocialWheelActivationStyle)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.SocialWheelActivationStyle);
			}
			bool hasMonsterHealthBarMode = this.HasMonsterHealthBarMode;
			if (hasMonsterHealthBarMode)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.MonsterHealthBarMode);
			}
			bool hasHoldPositionInputMode = this.HasHoldPositionInputMode;
			if (hasHoldPositionInputMode)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.HoldPositionInputMode);
			}
			bool flag79 = this.controllerBindingsPs5_ != null;
			if (flag79)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ControllerBindingsPs5);
			}
			bool flag80 = this._unknownFields != null;
			if (flag80)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x000675C4 File Offset: 0x000657C4
		[DebuggerNonUserCode]
		public void MergeFrom(Preferences other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasVersion = other.HasVersion;
				if (hasVersion)
				{
					this.Version = other.Version;
				}
				bool hasFlags = other.HasFlags;
				if (hasFlags)
				{
					this.Flags = other.Flags;
				}
				bool hasDeprecatedItemsOnGroundSetting = other.HasDeprecatedItemsOnGroundSetting;
				if (hasDeprecatedItemsOnGroundSetting)
				{
					this.DeprecatedItemsOnGroundSetting = other.DeprecatedItemsOnGroundSetting;
				}
				bool flag2 = other.actionBindingHireling_ != null;
				if (flag2)
				{
					bool flag3 = this.actionBindingHireling_ == null;
					if (flag3)
					{
						this.ActionBindingHireling = new ActionBinding();
					}
					this.ActionBindingHireling.MergeFrom(other.ActionBindingHireling);
				}
				bool flag4 = other.actionBindingSkills_ != null;
				if (flag4)
				{
					bool flag5 = this.actionBindingSkills_ == null;
					if (flag5)
					{
						this.ActionBindingSkills = new ActionBinding();
					}
					this.ActionBindingSkills.MergeFrom(other.ActionBindingSkills);
				}
				bool flag6 = other.actionBindingAcceptPartyInviteRequest_ != null;
				if (flag6)
				{
					bool flag7 = this.actionBindingAcceptPartyInviteRequest_ == null;
					if (flag7)
					{
						this.ActionBindingAcceptPartyInviteRequest = new ActionBinding();
					}
					this.ActionBindingAcceptPartyInviteRequest.MergeFrom(other.ActionBindingAcceptPartyInviteRequest);
				}
				bool flag8 = other.actionBindingLore_ != null;
				if (flag8)
				{
					bool flag9 = this.actionBindingLore_ == null;
					if (flag9)
					{
						this.ActionBindingLore = new ActionBinding();
					}
					this.ActionBindingLore.MergeFrom(other.ActionBindingLore);
				}
				bool flag10 = other.actionBindingSocial_ != null;
				if (flag10)
				{
					bool flag11 = this.actionBindingSocial_ == null;
					if (flag11)
					{
						this.ActionBindingSocial = new ActionBinding();
					}
					this.ActionBindingSocial.MergeFrom(other.ActionBindingSocial);
				}
				bool flag12 = other.actionBindingHelp_ != null;
				if (flag12)
				{
					bool flag13 = this.actionBindingHelp_ == null;
					if (flag13)
					{
						this.ActionBindingHelp = new ActionBinding();
					}
					this.ActionBindingHelp.MergeFrom(other.ActionBindingHelp);
				}
				bool flag14 = other.actionBindingRecentplayers_ != null;
				if (flag14)
				{
					bool flag15 = this.actionBindingRecentplayers_ == null;
					if (flag15)
					{
						this.ActionBindingRecentplayers = new ActionBinding();
					}
					this.ActionBindingRecentplayers.MergeFrom(other.ActionBindingRecentplayers);
				}
				bool flag16 = other.actionBindingChatlobby_ != null;
				if (flag16)
				{
					bool flag17 = this.actionBindingChatlobby_ == null;
					if (flag17)
					{
						this.ActionBindingChatlobby = new ActionBinding();
					}
					this.ActionBindingChatlobby.MergeFrom(other.ActionBindingChatlobby);
				}
				bool flag18 = other.actionBindingAchievements_ != null;
				if (flag18)
				{
					bool flag19 = this.actionBindingAchievements_ == null;
					if (flag19)
					{
						this.ActionBindingAchievements = new ActionBinding();
					}
					this.ActionBindingAchievements.MergeFrom(other.ActionBindingAchievements);
				}
				bool flag20 = other.actionBindingProfile_ != null;
				if (flag20)
				{
					bool flag21 = this.actionBindingProfile_ == null;
					if (flag21)
					{
						this.ActionBindingProfile = new ActionBinding();
					}
					this.ActionBindingProfile.MergeFrom(other.ActionBindingProfile);
				}
				bool flag22 = other.actionBindingEquippables_ != null;
				if (flag22)
				{
					bool flag23 = this.actionBindingEquippables_ == null;
					if (flag23)
					{
						this.ActionBindingEquippables = new ActionBinding();
					}
					this.ActionBindingEquippables.MergeFrom(other.ActionBindingEquippables);
				}
				bool flag24 = other.actionBindingConsole_ != null;
				if (flag24)
				{
					bool flag25 = this.actionBindingConsole_ == null;
					if (flag25)
					{
						this.ActionBindingConsole = new ActionBinding();
					}
					this.ActionBindingConsole.MergeFrom(other.ActionBindingConsole);
				}
				bool flag26 = other.actionBindingMap_ != null;
				if (flag26)
				{
					bool flag27 = this.actionBindingMap_ == null;
					if (flag27)
					{
						this.ActionBindingMap = new ActionBinding();
					}
					this.ActionBindingMap.MergeFrom(other.ActionBindingMap);
				}
				bool flag28 = other.actionBindingSkillTree_ != null;
				if (flag28)
				{
					bool flag29 = this.actionBindingSkillTree_ == null;
					if (flag29)
					{
						this.ActionBindingSkillTree = new ActionBinding();
					}
					this.ActionBindingSkillTree.MergeFrom(other.ActionBindingSkillTree);
				}
				bool flag30 = other.actionBindingToggleplayerhpbars_ != null;
				if (flag30)
				{
					bool flag31 = this.actionBindingToggleplayerhpbars_ == null;
					if (flag31)
					{
						this.ActionBindingToggleplayerhpbars = new ActionBinding();
					}
					this.ActionBindingToggleplayerhpbars.MergeFrom(other.ActionBindingToggleplayerhpbars);
				}
				bool flag32 = other.actionBindingToggledamagenumbers_ != null;
				if (flag32)
				{
					bool flag33 = this.actionBindingToggledamagenumbers_ == null;
					if (flag33)
					{
						this.ActionBindingToggledamagenumbers = new ActionBinding();
					}
					this.ActionBindingToggledamagenumbers.MergeFrom(other.ActionBindingToggledamagenumbers);
				}
				bool flag34 = other.actionBindingToggleitemsonground_ != null;
				if (flag34)
				{
					bool flag35 = this.actionBindingToggleitemsonground_ == null;
					if (flag35)
					{
						this.ActionBindingToggleitemsonground = new ActionBinding();
					}
					this.ActionBindingToggleitemsonground.MergeFrom(other.ActionBindingToggleitemsonground);
				}
				bool flag36 = other.actionBindingRewhisper_ != null;
				if (flag36)
				{
					bool flag37 = this.actionBindingRewhisper_ == null;
					if (flag37)
					{
						this.ActionBindingRewhisper = new ActionBinding();
					}
					this.ActionBindingRewhisper.MergeFrom(other.ActionBindingRewhisper);
				}
				bool flag38 = other.actionBindingWhisperreply_ != null;
				if (flag38)
				{
					bool flag39 = this.actionBindingWhisperreply_ == null;
					if (flag39)
					{
						this.ActionBindingWhisperreply = new ActionBinding();
					}
					this.ActionBindingWhisperreply.MergeFrom(other.ActionBindingWhisperreply);
				}
				bool flag40 = other.actionBindingVoiceptt_ != null;
				if (flag40)
				{
					bool flag41 = this.actionBindingVoiceptt_ == null;
					if (flag41)
					{
						this.ActionBindingVoiceptt = new ActionBinding();
					}
					this.ActionBindingVoiceptt.MergeFrom(other.ActionBindingVoiceptt);
				}
				bool flag42 = other.actionBindingSocialwheel_ != null;
				if (flag42)
				{
					bool flag43 = this.actionBindingSocialwheel_ == null;
					if (flag43)
					{
						this.ActionBindingSocialwheel = new ActionBinding();
					}
					this.ActionBindingSocialwheel.MergeFrom(other.ActionBindingSocialwheel);
				}
				bool flag44 = other.actionBindingFastquesttrack_ != null;
				if (flag44)
				{
					bool flag45 = this.actionBindingFastquesttrack_ == null;
					if (flag45)
					{
						this.ActionBindingFastquesttrack = new ActionBinding();
					}
					this.ActionBindingFastquesttrack.MergeFrom(other.ActionBindingFastquesttrack);
				}
				bool flag46 = other.actionBindingToggleLfdCompanions_ != null;
				if (flag46)
				{
					bool flag47 = this.actionBindingToggleLfdCompanions_ == null;
					if (flag47)
					{
						this.ActionBindingToggleLfdCompanions = new ActionBinding();
					}
					this.ActionBindingToggleLfdCompanions.MergeFrom(other.ActionBindingToggleLfdCompanions);
				}
				bool flag48 = other.actionBindingCollections_ != null;
				if (flag48)
				{
					bool flag49 = this.actionBindingCollections_ == null;
					if (flag49)
					{
						this.ActionBindingCollections = new ActionBinding();
					}
					this.ActionBindingCollections.MergeFrom(other.ActionBindingCollections);
				}
				this.actionBindingSocialwheelLeft_.Add(other.actionBindingSocialwheelLeft_);
				this.actionBindingSocialwheelMiddle_.Add(other.actionBindingSocialwheelMiddle_);
				this.actionBindingSocialwheelRight_.Add(other.actionBindingSocialwheelRight_);
				bool flag50 = other.actionBindingSocialwheelPageBackward_ != null;
				if (flag50)
				{
					bool flag51 = this.actionBindingSocialwheelPageBackward_ == null;
					if (flag51)
					{
						this.ActionBindingSocialwheelPageBackward = new ActionBinding();
					}
					this.ActionBindingSocialwheelPageBackward.MergeFrom(other.ActionBindingSocialwheelPageBackward);
				}
				bool flag52 = other.actionBindingSocialwheelPageForward_ != null;
				if (flag52)
				{
					bool flag53 = this.actionBindingSocialwheelPageForward_ == null;
					if (flag53)
					{
						this.ActionBindingSocialwheelPageForward = new ActionBinding();
					}
					this.ActionBindingSocialwheelPageForward.MergeFrom(other.ActionBindingSocialwheelPageForward);
				}
				bool flag54 = other.actionBindingAbilities_ != null;
				if (flag54)
				{
					bool flag55 = this.actionBindingAbilities_ == null;
					if (flag55)
					{
						this.ActionBindingAbilities = new ActionBinding();
					}
					this.ActionBindingAbilities.MergeFrom(other.ActionBindingAbilities);
				}
				bool flag56 = other.actionBindingReportBug_ != null;
				if (flag56)
				{
					bool flag57 = this.actionBindingReportBug_ == null;
					if (flag57)
					{
						this.ActionBindingReportBug = new ActionBinding();
					}
					this.ActionBindingReportBug.MergeFrom(other.ActionBindingReportBug);
				}
				bool flag58 = other.actionBindingReportContent_ != null;
				if (flag58)
				{
					bool flag59 = this.actionBindingReportContent_ == null;
					if (flag59)
					{
						this.ActionBindingReportContent = new ActionBinding();
					}
					this.ActionBindingReportContent.MergeFrom(other.ActionBindingReportContent);
				}
				bool flag60 = other.actionBindingJoinSpeechToTextChat_ != null;
				if (flag60)
				{
					bool flag61 = this.actionBindingJoinSpeechToTextChat_ == null;
					if (flag61)
					{
						this.ActionBindingJoinSpeechToTextChat = new ActionBinding();
					}
					this.ActionBindingJoinSpeechToTextChat.MergeFrom(other.ActionBindingJoinSpeechToTextChat);
				}
				bool flag62 = other.actionBindingTtsSkipCurrentUtterance_ != null;
				if (flag62)
				{
					bool flag63 = this.actionBindingTtsSkipCurrentUtterance_ == null;
					if (flag63)
					{
						this.ActionBindingTtsSkipCurrentUtterance = new ActionBinding();
					}
					this.ActionBindingTtsSkipCurrentUtterance.MergeFrom(other.ActionBindingTtsSkipCurrentUtterance);
				}
				bool flag64 = other.actionBindingTtsCancelAllUtterances_ != null;
				if (flag64)
				{
					bool flag65 = this.actionBindingTtsCancelAllUtterances_ == null;
					if (flag65)
					{
						this.ActionBindingTtsCancelAllUtterances = new ActionBinding();
					}
					this.ActionBindingTtsCancelAllUtterances.MergeFrom(other.ActionBindingTtsCancelAllUtterances);
				}
				bool flag66 = other.actionBindingScreenReaderSkipLine_ != null;
				if (flag66)
				{
					bool flag67 = this.actionBindingScreenReaderSkipLine_ == null;
					if (flag67)
					{
						this.ActionBindingScreenReaderSkipLine = new ActionBinding();
					}
					this.ActionBindingScreenReaderSkipLine.MergeFrom(other.ActionBindingScreenReaderSkipLine);
				}
				bool flag68 = other.actionBindingStore_ != null;
				if (flag68)
				{
					bool flag69 = this.actionBindingStore_ == null;
					if (flag69)
					{
						this.ActionBindingStore = new ActionBinding();
					}
					this.ActionBindingStore.MergeFrom(other.ActionBindingStore);
				}
				bool flag70 = other.actionBindingMountSpur_ != null;
				if (flag70)
				{
					bool flag71 = this.actionBindingMountSpur_ == null;
					if (flag71)
					{
						this.ActionBindingMountSpur = new ActionBinding();
					}
					this.ActionBindingMountSpur.MergeFrom(other.ActionBindingMountSpur);
				}
				bool flag72 = other.actionBindingMountDismount_ != null;
				if (flag72)
				{
					bool flag73 = this.actionBindingMountDismount_ == null;
					if (flag73)
					{
						this.ActionBindingMountDismount = new ActionBinding();
					}
					this.ActionBindingMountDismount.MergeFrom(other.ActionBindingMountDismount);
				}
				bool flag74 = other.actionBindingMountCombatDismount_ != null;
				if (flag74)
				{
					bool flag75 = this.actionBindingMountCombatDismount_ == null;
					if (flag75)
					{
						this.ActionBindingMountCombatDismount = new ActionBinding();
					}
					this.ActionBindingMountCombatDismount.MergeFrom(other.ActionBindingMountCombatDismount);
				}
				bool flag76 = other.actionBindingToggleZoom_ != null;
				if (flag76)
				{
					bool flag77 = this.actionBindingToggleZoom_ == null;
					if (flag77)
					{
						this.ActionBindingToggleZoom = new ActionBinding();
					}
					this.ActionBindingToggleZoom.MergeFrom(other.ActionBindingToggleZoom);
				}
				bool flag78 = other.actionBindingHoldposition_ != null;
				if (flag78)
				{
					bool flag79 = this.actionBindingHoldposition_ == null;
					if (flag79)
					{
						this.ActionBindingHoldposition = new ActionBinding();
					}
					this.ActionBindingHoldposition.MergeFrom(other.ActionBindingHoldposition);
				}
				bool flag80 = other.actionBindingSystemmastervolumeup_ != null;
				if (flag80)
				{
					bool flag81 = this.actionBindingSystemmastervolumeup_ == null;
					if (flag81)
					{
						this.ActionBindingSystemmastervolumeup = new ActionBinding();
					}
					this.ActionBindingSystemmastervolumeup.MergeFrom(other.ActionBindingSystemmastervolumeup);
				}
				bool flag82 = other.actionBindingSystemmastervolumedown_ != null;
				if (flag82)
				{
					bool flag83 = this.actionBindingSystemmastervolumedown_ == null;
					if (flag83)
					{
						this.ActionBindingSystemmastervolumedown = new ActionBinding();
					}
					this.ActionBindingSystemmastervolumedown.MergeFrom(other.ActionBindingSystemmastervolumedown);
				}
				bool flag84 = other.actionBindingSystemtogglemusic_ != null;
				if (flag84)
				{
					bool flag85 = this.actionBindingSystemtogglemusic_ == null;
					if (flag85)
					{
						this.ActionBindingSystemtogglemusic = new ActionBinding();
					}
					this.ActionBindingSystemtogglemusic.MergeFrom(other.ActionBindingSystemtogglemusic);
				}
				bool flag86 = other.actionBindingSystemtogglesound_ != null;
				if (flag86)
				{
					bool flag87 = this.actionBindingSystemtogglesound_ == null;
					if (flag87)
					{
						this.ActionBindingSystemtogglesound = new ActionBinding();
					}
					this.ActionBindingSystemtogglesound.MergeFrom(other.ActionBindingSystemtogglesound);
				}
				bool flag88 = other.actionBindingSystemscreenshot_ != null;
				if (flag88)
				{
					bool flag89 = this.actionBindingSystemscreenshot_ == null;
					if (flag89)
					{
						this.ActionBindingSystemscreenshot = new ActionBinding();
					}
					this.ActionBindingSystemscreenshot.MergeFrom(other.ActionBindingSystemscreenshot);
				}
				bool flag90 = other.actionBindingSystemtogglefps_ != null;
				if (flag90)
				{
					bool flag91 = this.actionBindingSystemtogglefps_ == null;
					if (flag91)
					{
						this.ActionBindingSystemtogglefps = new ActionBinding();
					}
					this.ActionBindingSystemtogglefps.MergeFrom(other.ActionBindingSystemtogglefps);
				}
				bool flag92 = other.actionBindingChatpageup_ != null;
				if (flag92)
				{
					bool flag93 = this.actionBindingChatpageup_ == null;
					if (flag93)
					{
						this.ActionBindingChatpageup = new ActionBinding();
					}
					this.ActionBindingChatpageup.MergeFrom(other.ActionBindingChatpageup);
				}
				bool flag94 = other.actionBindingChatpagedown_ != null;
				if (flag94)
				{
					bool flag95 = this.actionBindingChatpagedown_ == null;
					if (flag95)
					{
						this.ActionBindingChatpagedown = new ActionBinding();
					}
					this.ActionBindingChatpagedown.MergeFrom(other.ActionBindingChatpagedown);
				}
				bool flag96 = other.actionBindingGroups_ != null;
				if (flag96)
				{
					bool flag97 = this.actionBindingGroups_ == null;
					if (flag97)
					{
						this.ActionBindingGroups = new ActionBinding();
					}
					this.ActionBindingGroups.MergeFrom(other.ActionBindingGroups);
				}
				bool flag98 = other.actionBindingClan_ != null;
				if (flag98)
				{
					bool flag99 = this.actionBindingClan_ == null;
					if (flag99)
					{
						this.ActionBindingClan = new ActionBinding();
					}
					this.ActionBindingClan.MergeFrom(other.ActionBindingClan);
				}
				bool flag100 = other.actionBindingChatNextView_ != null;
				if (flag100)
				{
					bool flag101 = this.actionBindingChatNextView_ == null;
					if (flag101)
					{
						this.ActionBindingChatNextView = new ActionBinding();
					}
					this.ActionBindingChatNextView.MergeFrom(other.ActionBindingChatNextView);
				}
				bool flag102 = other.actionBindingChatPreviousView_ != null;
				if (flag102)
				{
					bool flag103 = this.actionBindingChatPreviousView_ == null;
					if (flag103)
					{
						this.ActionBindingChatPreviousView = new ActionBinding();
					}
					this.ActionBindingChatPreviousView.MergeFrom(other.ActionBindingChatPreviousView);
				}
				bool flag104 = other.actionBindingLeaderboards_ != null;
				if (flag104)
				{
					bool flag105 = this.actionBindingLeaderboards_ == null;
					if (flag105)
					{
						this.ActionBindingLeaderboards = new ActionBinding();
					}
					this.ActionBindingLeaderboards.MergeFrom(other.ActionBindingLeaderboards);
				}
				bool flag106 = other.actionBindingChatResetFade_ != null;
				if (flag106)
				{
					bool flag107 = this.actionBindingChatResetFade_ == null;
					if (flag107)
					{
						this.ActionBindingChatResetFade = new ActionBinding();
					}
					this.ActionBindingChatResetFade.MergeFrom(other.ActionBindingChatResetFade);
				}
				bool flag108 = other.actionBindingQuests_ != null;
				if (flag108)
				{
					bool flag109 = this.actionBindingQuests_ == null;
					if (flag109)
					{
						this.ActionBindingQuests = new ActionBinding();
					}
					this.ActionBindingQuests.MergeFrom(other.ActionBindingQuests);
				}
				bool flag110 = other.actionBindingQuestsToggle_ != null;
				if (flag110)
				{
					bool flag111 = this.actionBindingQuestsToggle_ == null;
					if (flag111)
					{
						this.ActionBindingQuestsToggle = new ActionBinding();
					}
					this.ActionBindingQuestsToggle.MergeFrom(other.ActionBindingQuestsToggle);
				}
				bool flag112 = other.actionBindingRun_ != null;
				if (flag112)
				{
					bool flag113 = this.actionBindingRun_ == null;
					if (flag113)
					{
						this.ActionBindingRun = new ActionBinding();
					}
					this.ActionBindingRun.MergeFrom(other.ActionBindingRun);
				}
				bool flag114 = other.actionBindingInteract_ != null;
				if (flag114)
				{
					bool flag115 = this.actionBindingInteract_ == null;
					if (flag115)
					{
						this.ActionBindingInteract = new ActionBinding();
					}
					this.ActionBindingInteract.MergeFrom(other.ActionBindingInteract);
				}
				bool flag116 = other.actionBindingPrimary_ != null;
				if (flag116)
				{
					bool flag117 = this.actionBindingPrimary_ == null;
					if (flag117)
					{
						this.ActionBindingPrimary = new ActionBinding();
					}
					this.ActionBindingPrimary.MergeFrom(other.ActionBindingPrimary);
				}
				bool flag118 = other.actionBindingSecondary_ != null;
				if (flag118)
				{
					bool flag119 = this.actionBindingSecondary_ == null;
					if (flag119)
					{
						this.ActionBindingSecondary = new ActionBinding();
					}
					this.ActionBindingSecondary.MergeFrom(other.ActionBindingSecondary);
				}
				bool flag120 = other.actionBindingSkill1_ != null;
				if (flag120)
				{
					bool flag121 = this.actionBindingSkill1_ == null;
					if (flag121)
					{
						this.ActionBindingSkill1 = new ActionBinding();
					}
					this.ActionBindingSkill1.MergeFrom(other.ActionBindingSkill1);
				}
				bool flag122 = other.actionBindingSkill2_ != null;
				if (flag122)
				{
					bool flag123 = this.actionBindingSkill2_ == null;
					if (flag123)
					{
						this.ActionBindingSkill2 = new ActionBinding();
					}
					this.ActionBindingSkill2.MergeFrom(other.ActionBindingSkill2);
				}
				bool flag124 = other.actionBindingSkill3_ != null;
				if (flag124)
				{
					bool flag125 = this.actionBindingSkill3_ == null;
					if (flag125)
					{
						this.ActionBindingSkill3 = new ActionBinding();
					}
					this.ActionBindingSkill3.MergeFrom(other.ActionBindingSkill3);
				}
				bool flag126 = other.actionBindingSkill4_ != null;
				if (flag126)
				{
					bool flag127 = this.actionBindingSkill4_ == null;
					if (flag127)
					{
						this.ActionBindingSkill4 = new ActionBinding();
					}
					this.ActionBindingSkill4.MergeFrom(other.ActionBindingSkill4);
				}
				bool flag128 = other.actionBindingMount_ != null;
				if (flag128)
				{
					bool flag129 = this.actionBindingMount_ == null;
					if (flag129)
					{
						this.ActionBindingMount = new ActionBinding();
					}
					this.ActionBindingMount.MergeFrom(other.ActionBindingMount);
				}
				bool flag130 = other.actionBindingEvade_ != null;
				if (flag130)
				{
					bool flag131 = this.actionBindingEvade_ == null;
					if (flag131)
					{
						this.ActionBindingEvade = new ActionBinding();
					}
					this.ActionBindingEvade.MergeFrom(other.ActionBindingEvade);
				}
				bool flag132 = other.actionBindingUseItem_ != null;
				if (flag132)
				{
					bool flag133 = this.actionBindingUseItem_ == null;
					if (flag133)
					{
						this.ActionBindingUseItem = new ActionBinding();
					}
					this.ActionBindingUseItem.MergeFrom(other.ActionBindingUseItem);
				}
				bool flag134 = other.actionBindingCenterCamera_ != null;
				if (flag134)
				{
					bool flag135 = this.actionBindingCenterCamera_ == null;
					if (flag135)
					{
						this.ActionBindingCenterCamera = new ActionBinding();
					}
					this.ActionBindingCenterCamera.MergeFrom(other.ActionBindingCenterCamera);
				}
				bool flag136 = other.actionBindingDebugCamera_ != null;
				if (flag136)
				{
					bool flag137 = this.actionBindingDebugCamera_ == null;
					if (flag137)
					{
						this.ActionBindingDebugCamera = new ActionBinding();
					}
					this.ActionBindingDebugCamera.MergeFrom(other.ActionBindingDebugCamera);
				}
				bool flag138 = other.actionBindingSocialInteract_ != null;
				if (flag138)
				{
					bool flag139 = this.actionBindingSocialInteract_ == null;
					if (flag139)
					{
						this.ActionBindingSocialInteract = new ActionBinding();
					}
					this.ActionBindingSocialInteract.MergeFrom(other.ActionBindingSocialInteract);
				}
				bool flag140 = other.actionBindingAcceptPartyInvite_ != null;
				if (flag140)
				{
					bool flag141 = this.actionBindingAcceptPartyInvite_ == null;
					if (flag141)
					{
						this.ActionBindingAcceptPartyInvite = new ActionBinding();
					}
					this.ActionBindingAcceptPartyInvite.MergeFrom(other.ActionBindingAcceptPartyInvite);
				}
				bool flag142 = other.actionBindingLockTarget_ != null;
				if (flag142)
				{
					bool flag143 = this.actionBindingLockTarget_ == null;
					if (flag143)
					{
						this.ActionBindingLockTarget = new ActionBinding();
					}
					this.ActionBindingLockTarget.MergeFrom(other.ActionBindingLockTarget);
				}
				bool flag144 = other.actionBindingTownPortal_ != null;
				if (flag144)
				{
					bool flag145 = this.actionBindingTownPortal_ == null;
					if (flag145)
					{
						this.ActionBindingTownPortal = new ActionBinding();
					}
					this.ActionBindingTownPortal.MergeFrom(other.ActionBindingTownPortal);
				}
				bool flag146 = other.actionBindingForceMove_ != null;
				if (flag146)
				{
					bool flag147 = this.actionBindingForceMove_ == null;
					if (flag147)
					{
						this.ActionBindingForceMove = new ActionBinding();
					}
					this.ActionBindingForceMove.MergeFrom(other.ActionBindingForceMove);
				}
				bool flag148 = other.actionBindingClassScreen_ != null;
				if (flag148)
				{
					bool flag149 = this.actionBindingClassScreen_ == null;
					if (flag149)
					{
						this.ActionBindingClassScreen = new ActionBinding();
					}
					this.ActionBindingClassScreen.MergeFrom(other.ActionBindingClassScreen);
				}
				bool flag150 = other.actionBindingCycleLockTarget_ != null;
				if (flag150)
				{
					bool flag151 = this.actionBindingCycleLockTarget_ == null;
					if (flag151)
					{
						this.ActionBindingCycleLockTarget = new ActionBinding();
					}
					this.ActionBindingCycleLockTarget.MergeFrom(other.ActionBindingCycleLockTarget);
				}
				bool hasNotifyDuration = other.HasNotifyDuration;
				if (hasNotifyDuration)
				{
					this.NotifyDuration = other.NotifyDuration;
				}
				bool hasKeybindingVersion = other.HasKeybindingVersion;
				if (hasKeybindingVersion)
				{
					this.KeybindingVersion = other.KeybindingVersion;
				}
				bool hasFlags2 = other.HasFlags2;
				if (hasFlags2)
				{
					this.Flags2 = other.Flags2;
				}
				bool hasControlScheme = other.HasControlScheme;
				if (hasControlScheme)
				{
					this.ControlScheme = other.ControlScheme;
				}
				bool hasControllerButtonBindingVersion = other.HasControllerButtonBindingVersion;
				if (hasControllerButtonBindingVersion)
				{
					this.ControllerButtonBindingVersion = other.ControllerButtonBindingVersion;
				}
				bool flag152 = other.controllerBindingsXinput_ != null;
				if (flag152)
				{
					bool flag153 = this.controllerBindingsXinput_ == null;
					if (flag153)
					{
						this.ControllerBindingsXinput = new ControllerActionBindings();
					}
					this.ControllerBindingsXinput.MergeFrom(other.ControllerBindingsXinput);
				}
				bool flag154 = other.controllerBindingsPs4_ != null;
				if (flag154)
				{
					bool flag155 = this.controllerBindingsPs4_ == null;
					if (flag155)
					{
						this.ControllerBindingsPs4 = new ControllerActionBindings();
					}
					this.ControllerBindingsPs4.MergeFrom(other.ControllerBindingsPs4);
				}
				bool flag156 = other.controllerBindingsNx64_ != null;
				if (flag156)
				{
					bool flag157 = this.controllerBindingsNx64_ == null;
					if (flag157)
					{
						this.ControllerBindingsNx64 = new ControllerActionBindings();
					}
					this.ControllerBindingsNx64.MergeFrom(other.ControllerBindingsNx64);
				}
				bool hasChatBackgroundOpacityWhenActive = other.HasChatBackgroundOpacityWhenActive;
				if (hasChatBackgroundOpacityWhenActive)
				{
					this.ChatBackgroundOpacityWhenActive = other.ChatBackgroundOpacityWhenActive;
				}
				bool hasChatTimestampFormat = other.HasChatTimestampFormat;
				if (hasChatTimestampFormat)
				{
					this.ChatTimestampFormat = other.ChatTimestampFormat;
				}
				bool hasItemLabelOnDropDuration = other.HasItemLabelOnDropDuration;
				if (hasItemLabelOnDropDuration)
				{
					this.ItemLabelOnDropDuration = other.ItemLabelOnDropDuration;
				}
				bool hasItemLabelDisplayMode = other.HasItemLabelDisplayMode;
				if (hasItemLabelDisplayMode)
				{
					this.ItemLabelDisplayMode = other.ItemLabelDisplayMode;
				}
				bool hasControllerCursorSensitivity = other.HasControllerCursorSensitivity;
				if (hasControllerCursorSensitivity)
				{
					this.ControllerCursorSensitivity = other.ControllerCursorSensitivity;
				}
				bool hasControllerInnerDeadZone = other.HasControllerInnerDeadZone;
				if (hasControllerInnerDeadZone)
				{
					this.ControllerInnerDeadZone = other.ControllerInnerDeadZone;
				}
				bool hasControllerOuterDeadZone = other.HasControllerOuterDeadZone;
				if (hasControllerOuterDeadZone)
				{
					this.ControllerOuterDeadZone = other.ControllerOuterDeadZone;
				}
				bool hasPowerToggleMode = other.HasPowerToggleMode;
				if (hasPowerToggleMode)
				{
					this.PowerToggleMode = other.PowerToggleMode;
				}
				bool hasSocialWheelActivationStyle = other.HasSocialWheelActivationStyle;
				if (hasSocialWheelActivationStyle)
				{
					this.SocialWheelActivationStyle = other.SocialWheelActivationStyle;
				}
				bool hasMonsterHealthBarMode = other.HasMonsterHealthBarMode;
				if (hasMonsterHealthBarMode)
				{
					this.MonsterHealthBarMode = other.MonsterHealthBarMode;
				}
				bool hasHoldPositionInputMode = other.HasHoldPositionInputMode;
				if (hasHoldPositionInputMode)
				{
					this.HoldPositionInputMode = other.HoldPositionInputMode;
				}
				bool flag158 = other.controllerBindingsPs5_ != null;
				if (flag158)
				{
					bool flag159 = this.controllerBindingsPs5_ == null;
					if (flag159)
					{
						this.ControllerBindingsPs5 = new ControllerActionBindings();
					}
					this.ControllerBindingsPs5.MergeFrom(other.ControllerBindingsPs5);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x00068BE8 File Offset: 0x00066DE8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x00068BF4 File Offset: 0x00066DF4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 466U)
				{
					if (num3 <= 234U)
					{
						if (num3 <= 114U)
						{
							if (num3 <= 58U)
							{
								if (num3 <= 24U)
								{
									if (num3 != 8U)
									{
										if (num3 != 16U)
										{
											if (num3 != 24U)
											{
												goto IL_0690;
											}
											this.DeprecatedItemsOnGroundSetting = input.ReadUInt32();
										}
										else
										{
											this.Flags = input.ReadUInt32();
										}
									}
									else
									{
										this.Version = input.ReadInt32();
									}
								}
								else if (num3 != 42U)
								{
									if (num3 != 50U)
									{
										if (num3 != 58U)
										{
											goto IL_0690;
										}
										bool flag = this.actionBindingAcceptPartyInviteRequest_ == null;
										if (flag)
										{
											this.ActionBindingAcceptPartyInviteRequest = new ActionBinding();
										}
										input.ReadMessage(this.ActionBindingAcceptPartyInviteRequest);
									}
									else
									{
										bool flag2 = this.actionBindingSkills_ == null;
										if (flag2)
										{
											this.ActionBindingSkills = new ActionBinding();
										}
										input.ReadMessage(this.ActionBindingSkills);
									}
								}
								else
								{
									bool flag3 = this.actionBindingHireling_ == null;
									if (flag3)
									{
										this.ActionBindingHireling = new ActionBinding();
									}
									input.ReadMessage(this.ActionBindingHireling);
								}
							}
							else if (num3 <= 90U)
							{
								if (num3 != 66U)
								{
									if (num3 != 74U)
									{
										if (num3 != 90U)
										{
											goto IL_0690;
										}
										bool flag4 = this.actionBindingHelp_ == null;
										if (flag4)
										{
											this.ActionBindingHelp = new ActionBinding();
										}
										input.ReadMessage(this.ActionBindingHelp);
									}
									else
									{
										bool flag5 = this.actionBindingSocial_ == null;
										if (flag5)
										{
											this.ActionBindingSocial = new ActionBinding();
										}
										input.ReadMessage(this.ActionBindingSocial);
									}
								}
								else
								{
									bool flag6 = this.actionBindingLore_ == null;
									if (flag6)
									{
										this.ActionBindingLore = new ActionBinding();
									}
									input.ReadMessage(this.ActionBindingLore);
								}
							}
							else if (num3 != 98U)
							{
								if (num3 != 106U)
								{
									if (num3 != 114U)
									{
										goto IL_0690;
									}
									bool flag7 = this.actionBindingAchievements_ == null;
									if (flag7)
									{
										this.ActionBindingAchievements = new ActionBinding();
									}
									input.ReadMessage(this.ActionBindingAchievements);
								}
								else
								{
									bool flag8 = this.actionBindingChatlobby_ == null;
									if (flag8)
									{
										this.ActionBindingChatlobby = new ActionBinding();
									}
									input.ReadMessage(this.ActionBindingChatlobby);
								}
							}
							else
							{
								bool flag9 = this.actionBindingRecentplayers_ == null;
								if (flag9)
								{
									this.ActionBindingRecentplayers = new ActionBinding();
								}
								input.ReadMessage(this.ActionBindingRecentplayers);
							}
						}
						else if (num3 <= 178U)
						{
							if (num3 <= 146U)
							{
								if (num3 != 122U)
								{
									if (num3 != 130U)
									{
										if (num3 != 146U)
										{
											goto IL_0690;
										}
										bool flag10 = this.actionBindingConsole_ == null;
										if (flag10)
										{
											this.ActionBindingConsole = new ActionBinding();
										}
										input.ReadMessage(this.ActionBindingConsole);
									}
									else
									{
										bool flag11 = this.actionBindingEquippables_ == null;
										if (flag11)
										{
											this.ActionBindingEquippables = new ActionBinding();
										}
										input.ReadMessage(this.ActionBindingEquippables);
									}
								}
								else
								{
									bool flag12 = this.actionBindingProfile_ == null;
									if (flag12)
									{
										this.ActionBindingProfile = new ActionBinding();
									}
									input.ReadMessage(this.ActionBindingProfile);
								}
							}
							else if (num3 != 154U)
							{
								if (num3 != 162U)
								{
									if (num3 != 178U)
									{
										goto IL_0690;
									}
									bool flag13 = this.actionBindingToggleplayerhpbars_ == null;
									if (flag13)
									{
										this.ActionBindingToggleplayerhpbars = new ActionBinding();
									}
									input.ReadMessage(this.ActionBindingToggleplayerhpbars);
								}
								else
								{
									bool flag14 = this.actionBindingSkillTree_ == null;
									if (flag14)
									{
										this.ActionBindingSkillTree = new ActionBinding();
									}
									input.ReadMessage(this.ActionBindingSkillTree);
								}
							}
							else
							{
								bool flag15 = this.actionBindingMap_ == null;
								if (flag15)
								{
									this.ActionBindingMap = new ActionBinding();
								}
								input.ReadMessage(this.ActionBindingMap);
							}
						}
						else if (num3 <= 202U)
						{
							if (num3 != 186U)
							{
								if (num3 != 194U)
								{
									if (num3 != 202U)
									{
										goto IL_0690;
									}
									bool flag16 = this.actionBindingRewhisper_ == null;
									if (flag16)
									{
										this.ActionBindingRewhisper = new ActionBinding();
									}
									input.ReadMessage(this.ActionBindingRewhisper);
								}
								else
								{
									bool flag17 = this.actionBindingToggleitemsonground_ == null;
									if (flag17)
									{
										this.ActionBindingToggleitemsonground = new ActionBinding();
									}
									input.ReadMessage(this.ActionBindingToggleitemsonground);
								}
							}
							else
							{
								bool flag18 = this.actionBindingToggledamagenumbers_ == null;
								if (flag18)
								{
									this.ActionBindingToggledamagenumbers = new ActionBinding();
								}
								input.ReadMessage(this.ActionBindingToggledamagenumbers);
							}
						}
						else if (num3 <= 218U)
						{
							if (num3 != 210U)
							{
								if (num3 != 218U)
								{
									goto IL_0690;
								}
								bool flag19 = this.actionBindingVoiceptt_ == null;
								if (flag19)
								{
									this.ActionBindingVoiceptt = new ActionBinding();
								}
								input.ReadMessage(this.ActionBindingVoiceptt);
							}
							else
							{
								bool flag20 = this.actionBindingWhisperreply_ == null;
								if (flag20)
								{
									this.ActionBindingWhisperreply = new ActionBinding();
								}
								input.ReadMessage(this.ActionBindingWhisperreply);
							}
						}
						else if (num3 != 226U)
						{
							if (num3 != 234U)
							{
								goto IL_0690;
							}
							bool flag21 = this.actionBindingFastquesttrack_ == null;
							if (flag21)
							{
								this.ActionBindingFastquesttrack = new ActionBinding();
							}
							input.ReadMessage(this.ActionBindingFastquesttrack);
						}
						else
						{
							bool flag22 = this.actionBindingSocialwheel_ == null;
							if (flag22)
							{
								this.ActionBindingSocialwheel = new ActionBinding();
							}
							input.ReadMessage(this.ActionBindingSocialwheel);
						}
					}
					else if (num3 <= 330U)
					{
						if (num3 <= 282U)
						{
							if (num3 <= 258U)
							{
								if (num3 != 242U)
								{
									if (num3 != 250U)
									{
										if (num3 != 258U)
										{
											goto IL_0690;
										}
										this.actionBindingSocialwheelLeft_.AddEntriesFrom(ref input, Preferences._repeated_actionBindingSocialwheelLeft_codec);
									}
									else
									{
										bool flag23 = this.actionBindingCollections_ == null;
										if (flag23)
										{
											this.ActionBindingCollections = new ActionBinding();
										}
										input.ReadMessage(this.ActionBindingCollections);
									}
								}
								else
								{
									bool flag24 = this.actionBindingToggleLfdCompanions_ == null;
									if (flag24)
									{
										this.ActionBindingToggleLfdCompanions = new ActionBinding();
									}
									input.ReadMessage(this.ActionBindingToggleLfdCompanions);
								}
							}
							else if (num3 != 266U)
							{
								if (num3 != 274U)
								{
									if (num3 != 282U)
									{
										goto IL_0690;
									}
									bool flag25 = this.actionBindingSocialwheelPageBackward_ == null;
									if (flag25)
									{
										this.ActionBindingSocialwheelPageBackward = new ActionBinding();
									}
									input.ReadMessage(this.ActionBindingSocialwheelPageBackward);
								}
								else
								{
									this.actionBindingSocialwheelRight_.AddEntriesFrom(ref input, Preferences._repeated_actionBindingSocialwheelRight_codec);
								}
							}
							else
							{
								this.actionBindingSocialwheelMiddle_.AddEntriesFrom(ref input, Preferences._repeated_actionBindingSocialwheelMiddle_codec);
							}
						}
						else if (num3 <= 306U)
						{
							if (num3 != 290U)
							{
								if (num3 != 298U)
								{
									if (num3 != 306U)
									{
										goto IL_0690;
									}
									bool flag26 = this.actionBindingReportBug_ == null;
									if (flag26)
									{
										this.ActionBindingReportBug = new ActionBinding();
									}
									input.ReadMessage(this.ActionBindingReportBug);
								}
								else
								{
									bool flag27 = this.actionBindingAbilities_ == null;
									if (flag27)
									{
										this.ActionBindingAbilities = new ActionBinding();
									}
									input.ReadMessage(this.ActionBindingAbilities);
								}
							}
							else
							{
								bool flag28 = this.actionBindingSocialwheelPageForward_ == null;
								if (flag28)
								{
									this.ActionBindingSocialwheelPageForward = new ActionBinding();
								}
								input.ReadMessage(this.ActionBindingSocialwheelPageForward);
							}
						}
						else if (num3 != 314U)
						{
							if (num3 != 322U)
							{
								if (num3 != 330U)
								{
									goto IL_0690;
								}
								bool flag29 = this.actionBindingTtsSkipCurrentUtterance_ == null;
								if (flag29)
								{
									this.ActionBindingTtsSkipCurrentUtterance = new ActionBinding();
								}
								input.ReadMessage(this.ActionBindingTtsSkipCurrentUtterance);
							}
							else
							{
								bool flag30 = this.actionBindingJoinSpeechToTextChat_ == null;
								if (flag30)
								{
									this.ActionBindingJoinSpeechToTextChat = new ActionBinding();
								}
								input.ReadMessage(this.ActionBindingJoinSpeechToTextChat);
							}
						}
						else
						{
							bool flag31 = this.actionBindingReportContent_ == null;
							if (flag31)
							{
								this.ActionBindingReportContent = new ActionBinding();
							}
							input.ReadMessage(this.ActionBindingReportContent);
						}
					}
					else if (num3 <= 378U)
					{
						if (num3 <= 354U)
						{
							if (num3 != 338U)
							{
								if (num3 != 346U)
								{
									if (num3 != 354U)
									{
										goto IL_0690;
									}
									bool flag32 = this.actionBindingStore_ == null;
									if (flag32)
									{
										this.ActionBindingStore = new ActionBinding();
									}
									input.ReadMessage(this.ActionBindingStore);
								}
								else
								{
									bool flag33 = this.actionBindingScreenReaderSkipLine_ == null;
									if (flag33)
									{
										this.ActionBindingScreenReaderSkipLine = new ActionBinding();
									}
									input.ReadMessage(this.ActionBindingScreenReaderSkipLine);
								}
							}
							else
							{
								bool flag34 = this.actionBindingTtsCancelAllUtterances_ == null;
								if (flag34)
								{
									this.ActionBindingTtsCancelAllUtterances = new ActionBinding();
								}
								input.ReadMessage(this.ActionBindingTtsCancelAllUtterances);
							}
						}
						else if (num3 != 362U)
						{
							if (num3 != 370U)
							{
								if (num3 != 378U)
								{
									goto IL_0690;
								}
								bool flag35 = this.actionBindingMountCombatDismount_ == null;
								if (flag35)
								{
									this.ActionBindingMountCombatDismount = new ActionBinding();
								}
								input.ReadMessage(this.ActionBindingMountCombatDismount);
							}
							else
							{
								bool flag36 = this.actionBindingMountDismount_ == null;
								if (flag36)
								{
									this.ActionBindingMountDismount = new ActionBinding();
								}
								input.ReadMessage(this.ActionBindingMountDismount);
							}
						}
						else
						{
							bool flag37 = this.actionBindingMountSpur_ == null;
							if (flag37)
							{
								this.ActionBindingMountSpur = new ActionBinding();
							}
							input.ReadMessage(this.ActionBindingMountSpur);
						}
					}
					else if (num3 <= 434U)
					{
						if (num3 != 386U)
						{
							if (num3 != 426U)
							{
								if (num3 != 434U)
								{
									goto IL_0690;
								}
								bool flag38 = this.actionBindingSystemmastervolumeup_ == null;
								if (flag38)
								{
									this.ActionBindingSystemmastervolumeup = new ActionBinding();
								}
								input.ReadMessage(this.ActionBindingSystemmastervolumeup);
							}
							else
							{
								bool flag39 = this.actionBindingHoldposition_ == null;
								if (flag39)
								{
									this.ActionBindingHoldposition = new ActionBinding();
								}
								input.ReadMessage(this.ActionBindingHoldposition);
							}
						}
						else
						{
							bool flag40 = this.actionBindingToggleZoom_ == null;
							if (flag40)
							{
								this.ActionBindingToggleZoom = new ActionBinding();
							}
							input.ReadMessage(this.ActionBindingToggleZoom);
						}
					}
					else if (num3 <= 450U)
					{
						if (num3 != 442U)
						{
							if (num3 != 450U)
							{
								goto IL_0690;
							}
							bool flag41 = this.actionBindingSystemtogglemusic_ == null;
							if (flag41)
							{
								this.ActionBindingSystemtogglemusic = new ActionBinding();
							}
							input.ReadMessage(this.ActionBindingSystemtogglemusic);
						}
						else
						{
							bool flag42 = this.actionBindingSystemmastervolumedown_ == null;
							if (flag42)
							{
								this.ActionBindingSystemmastervolumedown = new ActionBinding();
							}
							input.ReadMessage(this.ActionBindingSystemmastervolumedown);
						}
					}
					else if (num3 != 458U)
					{
						if (num3 != 466U)
						{
							goto IL_0690;
						}
						bool flag43 = this.actionBindingSystemscreenshot_ == null;
						if (flag43)
						{
							this.ActionBindingSystemscreenshot = new ActionBinding();
						}
						input.ReadMessage(this.ActionBindingSystemscreenshot);
					}
					else
					{
						bool flag44 = this.actionBindingSystemtogglesound_ == null;
						if (flag44)
						{
							this.ActionBindingSystemtogglesound = new ActionBinding();
						}
						input.ReadMessage(this.ActionBindingSystemtogglesound);
					}
				}
				else if (num3 <= 746U)
				{
					if (num3 <= 634U)
					{
						if (num3 <= 562U)
						{
							if (num3 <= 530U)
							{
								if (num3 != 514U)
								{
									if (num3 != 522U)
									{
										if (num3 != 530U)
										{
											goto IL_0690;
										}
										bool flag45 = this.actionBindingChatpagedown_ == null;
										if (flag45)
										{
											this.ActionBindingChatpagedown = new ActionBinding();
										}
										input.ReadMessage(this.ActionBindingChatpagedown);
									}
									else
									{
										bool flag46 = this.actionBindingChatpageup_ == null;
										if (flag46)
										{
											this.ActionBindingChatpageup = new ActionBinding();
										}
										input.ReadMessage(this.ActionBindingChatpageup);
									}
								}
								else
								{
									bool flag47 = this.actionBindingSystemtogglefps_ == null;
									if (flag47)
									{
										this.ActionBindingSystemtogglefps = new ActionBinding();
									}
									input.ReadMessage(this.ActionBindingSystemtogglefps);
								}
							}
							else if (num3 != 538U)
							{
								if (num3 != 546U)
								{
									if (num3 != 562U)
									{
										goto IL_0690;
									}
									bool flag48 = this.actionBindingChatNextView_ == null;
									if (flag48)
									{
										this.ActionBindingChatNextView = new ActionBinding();
									}
									input.ReadMessage(this.ActionBindingChatNextView);
								}
								else
								{
									bool flag49 = this.actionBindingClan_ == null;
									if (flag49)
									{
										this.ActionBindingClan = new ActionBinding();
									}
									input.ReadMessage(this.ActionBindingClan);
								}
							}
							else
							{
								bool flag50 = this.actionBindingGroups_ == null;
								if (flag50)
								{
									this.ActionBindingGroups = new ActionBinding();
								}
								input.ReadMessage(this.ActionBindingGroups);
							}
						}
						else if (num3 <= 586U)
						{
							if (num3 != 570U)
							{
								if (num3 != 578U)
								{
									if (num3 != 586U)
									{
										goto IL_0690;
									}
									bool flag51 = this.actionBindingChatResetFade_ == null;
									if (flag51)
									{
										this.ActionBindingChatResetFade = new ActionBinding();
									}
									input.ReadMessage(this.ActionBindingChatResetFade);
								}
								else
								{
									bool flag52 = this.actionBindingLeaderboards_ == null;
									if (flag52)
									{
										this.ActionBindingLeaderboards = new ActionBinding();
									}
									input.ReadMessage(this.ActionBindingLeaderboards);
								}
							}
							else
							{
								bool flag53 = this.actionBindingChatPreviousView_ == null;
								if (flag53)
								{
									this.ActionBindingChatPreviousView = new ActionBinding();
								}
								input.ReadMessage(this.ActionBindingChatPreviousView);
							}
						}
						else if (num3 != 594U)
						{
							if (num3 != 602U)
							{
								if (num3 != 634U)
								{
									goto IL_0690;
								}
								bool flag54 = this.actionBindingRun_ == null;
								if (flag54)
								{
									this.ActionBindingRun = new ActionBinding();
								}
								input.ReadMessage(this.ActionBindingRun);
							}
							else
							{
								bool flag55 = this.actionBindingQuestsToggle_ == null;
								if (flag55)
								{
									this.ActionBindingQuestsToggle = new ActionBinding();
								}
								input.ReadMessage(this.ActionBindingQuestsToggle);
							}
						}
						else
						{
							bool flag56 = this.actionBindingQuests_ == null;
							if (flag56)
							{
								this.ActionBindingQuests = new ActionBinding();
							}
							input.ReadMessage(this.ActionBindingQuests);
						}
					}
					else if (num3 <= 682U)
					{
						if (num3 <= 658U)
						{
							if (num3 != 642U)
							{
								if (num3 != 650U)
								{
									if (num3 != 658U)
									{
										goto IL_0690;
									}
									bool flag57 = this.actionBindingSecondary_ == null;
									if (flag57)
									{
										this.ActionBindingSecondary = new ActionBinding();
									}
									input.ReadMessage(this.ActionBindingSecondary);
								}
								else
								{
									bool flag58 = this.actionBindingPrimary_ == null;
									if (flag58)
									{
										this.ActionBindingPrimary = new ActionBinding();
									}
									input.ReadMessage(this.ActionBindingPrimary);
								}
							}
							else
							{
								bool flag59 = this.actionBindingInteract_ == null;
								if (flag59)
								{
									this.ActionBindingInteract = new ActionBinding();
								}
								input.ReadMessage(this.ActionBindingInteract);
							}
						}
						else if (num3 != 666U)
						{
							if (num3 != 674U)
							{
								if (num3 != 682U)
								{
									goto IL_0690;
								}
								bool flag60 = this.actionBindingSkill3_ == null;
								if (flag60)
								{
									this.ActionBindingSkill3 = new ActionBinding();
								}
								input.ReadMessage(this.ActionBindingSkill3);
							}
							else
							{
								bool flag61 = this.actionBindingSkill2_ == null;
								if (flag61)
								{
									this.ActionBindingSkill2 = new ActionBinding();
								}
								input.ReadMessage(this.ActionBindingSkill2);
							}
						}
						else
						{
							bool flag62 = this.actionBindingSkill1_ == null;
							if (flag62)
							{
								this.ActionBindingSkill1 = new ActionBinding();
							}
							input.ReadMessage(this.ActionBindingSkill1);
						}
					}
					else if (num3 <= 706U)
					{
						if (num3 != 690U)
						{
							if (num3 != 698U)
							{
								if (num3 != 706U)
								{
									goto IL_0690;
								}
								bool flag63 = this.actionBindingEvade_ == null;
								if (flag63)
								{
									this.ActionBindingEvade = new ActionBinding();
								}
								input.ReadMessage(this.ActionBindingEvade);
							}
							else
							{
								bool flag64 = this.actionBindingMount_ == null;
								if (flag64)
								{
									this.ActionBindingMount = new ActionBinding();
								}
								input.ReadMessage(this.ActionBindingMount);
							}
						}
						else
						{
							bool flag65 = this.actionBindingSkill4_ == null;
							if (flag65)
							{
								this.ActionBindingSkill4 = new ActionBinding();
							}
							input.ReadMessage(this.ActionBindingSkill4);
						}
					}
					else if (num3 <= 722U)
					{
						if (num3 != 714U)
						{
							if (num3 != 722U)
							{
								goto IL_0690;
							}
							bool flag66 = this.actionBindingCenterCamera_ == null;
							if (flag66)
							{
								this.ActionBindingCenterCamera = new ActionBinding();
							}
							input.ReadMessage(this.ActionBindingCenterCamera);
						}
						else
						{
							bool flag67 = this.actionBindingUseItem_ == null;
							if (flag67)
							{
								this.ActionBindingUseItem = new ActionBinding();
							}
							input.ReadMessage(this.ActionBindingUseItem);
						}
					}
					else if (num3 != 730U)
					{
						if (num3 != 746U)
						{
							goto IL_0690;
						}
						bool flag68 = this.actionBindingSocialInteract_ == null;
						if (flag68)
						{
							this.ActionBindingSocialInteract = new ActionBinding();
						}
						input.ReadMessage(this.ActionBindingSocialInteract);
					}
					else
					{
						bool flag69 = this.actionBindingDebugCamera_ == null;
						if (flag69)
						{
							this.ActionBindingDebugCamera = new ActionBinding();
						}
						input.ReadMessage(this.ActionBindingDebugCamera);
					}
				}
				else if (num3 <= 1666U)
				{
					if (num3 <= 794U)
					{
						if (num3 <= 770U)
						{
							if (num3 != 754U)
							{
								if (num3 != 762U)
								{
									if (num3 != 770U)
									{
										goto IL_0690;
									}
									bool flag70 = this.actionBindingTownPortal_ == null;
									if (flag70)
									{
										this.ActionBindingTownPortal = new ActionBinding();
									}
									input.ReadMessage(this.ActionBindingTownPortal);
								}
								else
								{
									bool flag71 = this.actionBindingLockTarget_ == null;
									if (flag71)
									{
										this.ActionBindingLockTarget = new ActionBinding();
									}
									input.ReadMessage(this.ActionBindingLockTarget);
								}
							}
							else
							{
								bool flag72 = this.actionBindingAcceptPartyInvite_ == null;
								if (flag72)
								{
									this.ActionBindingAcceptPartyInvite = new ActionBinding();
								}
								input.ReadMessage(this.ActionBindingAcceptPartyInvite);
							}
						}
						else if (num3 != 778U)
						{
							if (num3 != 786U)
							{
								if (num3 != 794U)
								{
									goto IL_0690;
								}
								bool flag73 = this.actionBindingCycleLockTarget_ == null;
								if (flag73)
								{
									this.ActionBindingCycleLockTarget = new ActionBinding();
								}
								input.ReadMessage(this.ActionBindingCycleLockTarget);
							}
							else
							{
								bool flag74 = this.actionBindingClassScreen_ == null;
								if (flag74)
								{
									this.ActionBindingClassScreen = new ActionBinding();
								}
								input.ReadMessage(this.ActionBindingClassScreen);
							}
						}
						else
						{
							bool flag75 = this.actionBindingForceMove_ == null;
							if (flag75)
							{
								this.ActionBindingForceMove = new ActionBinding();
							}
							input.ReadMessage(this.ActionBindingForceMove);
						}
					}
					else if (num3 <= 1600U)
					{
						if (num3 != 800U)
						{
							if (num3 != 808U)
							{
								if (num3 != 1600U)
								{
									goto IL_0690;
								}
								this.Flags2 = input.ReadUInt32();
							}
							else
							{
								this.KeybindingVersion = input.ReadUInt32();
							}
						}
						else
						{
							this.NotifyDuration = input.ReadUInt32();
						}
					}
					else if (num3 <= 1648U)
					{
						if (num3 != 1645U)
						{
							if (num3 != 1648U)
							{
								goto IL_0690;
							}
							this.ControllerButtonBindingVersion = input.ReadUInt32();
						}
						else
						{
							this.ControlScheme = input.ReadSFixed32();
						}
					}
					else if (num3 != 1658U)
					{
						if (num3 != 1666U)
						{
							goto IL_0690;
						}
						bool flag76 = this.controllerBindingsPs4_ == null;
						if (flag76)
						{
							this.ControllerBindingsPs4 = new ControllerActionBindings();
						}
						input.ReadMessage(this.ControllerBindingsPs4);
					}
					else
					{
						bool flag77 = this.controllerBindingsXinput_ == null;
						if (flag77)
						{
							this.ControllerBindingsXinput = new ControllerActionBindings();
						}
						input.ReadMessage(this.ControllerBindingsXinput);
					}
				}
				else if (num3 <= 1717U)
				{
					if (num3 <= 1688U)
					{
						if (num3 != 1674U)
						{
							if (num3 != 1680U)
							{
								if (num3 != 1688U)
								{
									goto IL_0690;
								}
								this.ChatTimestampFormat = input.ReadUInt32();
							}
							else
							{
								this.ChatBackgroundOpacityWhenActive = input.ReadUInt32();
							}
						}
						else
						{
							bool flag78 = this.controllerBindingsNx64_ == null;
							if (flag78)
							{
								this.ControllerBindingsNx64 = new ControllerActionBindings();
							}
							input.ReadMessage(this.ControllerBindingsNx64);
						}
					}
					else if (num3 != 1696U)
					{
						if (num3 != 1704U)
						{
							if (num3 != 1717U)
							{
								goto IL_0690;
							}
							this.ControllerCursorSensitivity = input.ReadFloat();
						}
						else
						{
							this.ItemLabelDisplayMode = input.ReadUInt32();
						}
					}
					else
					{
						this.ItemLabelOnDropDuration = input.ReadUInt32();
					}
				}
				else if (num3 <= 1736U)
				{
					if (num3 != 1725U)
					{
						if (num3 != 1733U)
						{
							if (num3 != 1736U)
							{
								goto IL_0690;
							}
							this.PowerToggleMode = input.ReadUInt32();
						}
						else
						{
							this.ControllerOuterDeadZone = input.ReadFloat();
						}
					}
					else
					{
						this.ControllerInnerDeadZone = input.ReadFloat();
					}
				}
				else if (num3 <= 1752U)
				{
					if (num3 != 1744U)
					{
						if (num3 != 1752U)
						{
							goto IL_0690;
						}
						this.MonsterHealthBarMode = input.ReadUInt32();
					}
					else
					{
						this.SocialWheelActivationStyle = input.ReadUInt32();
					}
				}
				else if (num3 != 1760U)
				{
					if (num3 != 1770U)
					{
						goto IL_0690;
					}
					bool flag79 = this.controllerBindingsPs5_ == null;
					if (flag79)
					{
						this.ControllerBindingsPs5 = new ControllerActionBindings();
					}
					input.ReadMessage(this.ControllerBindingsPs5);
				}
				else
				{
					this.HoldPositionInputMode = input.ReadUInt32();
				}
				continue;
				IL_0690:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000AE3 RID: 2787
		private static readonly MessageParser<Preferences> _parser = new MessageParser<Preferences>(() => new Preferences());

		// Token: 0x04000AE4 RID: 2788
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000AE5 RID: 2789
		private int _hasBits0;

		// Token: 0x04000AE6 RID: 2790
		public const int VersionFieldNumber = 1;

		// Token: 0x04000AE7 RID: 2791
		private static readonly int VersionDefaultValue = 0;

		// Token: 0x04000AE8 RID: 2792
		private int version_;

		// Token: 0x04000AE9 RID: 2793
		public const int FlagsFieldNumber = 2;

		// Token: 0x04000AEA RID: 2794
		private static readonly uint FlagsDefaultValue = 0U;

		// Token: 0x04000AEB RID: 2795
		private uint flags_;

		// Token: 0x04000AEC RID: 2796
		public const int DeprecatedItemsOnGroundSettingFieldNumber = 3;

		// Token: 0x04000AED RID: 2797
		private static readonly uint DeprecatedItemsOnGroundSettingDefaultValue = 0U;

		// Token: 0x04000AEE RID: 2798
		private uint deprecatedItemsOnGroundSetting_;

		// Token: 0x04000AEF RID: 2799
		public const int ActionBindingHirelingFieldNumber = 5;

		// Token: 0x04000AF0 RID: 2800
		private ActionBinding actionBindingHireling_;

		// Token: 0x04000AF1 RID: 2801
		public const int ActionBindingSkillsFieldNumber = 6;

		// Token: 0x04000AF2 RID: 2802
		private ActionBinding actionBindingSkills_;

		// Token: 0x04000AF3 RID: 2803
		public const int ActionBindingAcceptPartyInviteRequestFieldNumber = 7;

		// Token: 0x04000AF4 RID: 2804
		private ActionBinding actionBindingAcceptPartyInviteRequest_;

		// Token: 0x04000AF5 RID: 2805
		public const int ActionBindingLoreFieldNumber = 8;

		// Token: 0x04000AF6 RID: 2806
		private ActionBinding actionBindingLore_;

		// Token: 0x04000AF7 RID: 2807
		public const int ActionBindingSocialFieldNumber = 9;

		// Token: 0x04000AF8 RID: 2808
		private ActionBinding actionBindingSocial_;

		// Token: 0x04000AF9 RID: 2809
		public const int ActionBindingHelpFieldNumber = 11;

		// Token: 0x04000AFA RID: 2810
		private ActionBinding actionBindingHelp_;

		// Token: 0x04000AFB RID: 2811
		public const int ActionBindingRecentplayersFieldNumber = 12;

		// Token: 0x04000AFC RID: 2812
		private ActionBinding actionBindingRecentplayers_;

		// Token: 0x04000AFD RID: 2813
		public const int ActionBindingChatlobbyFieldNumber = 13;

		// Token: 0x04000AFE RID: 2814
		private ActionBinding actionBindingChatlobby_;

		// Token: 0x04000AFF RID: 2815
		public const int ActionBindingAchievementsFieldNumber = 14;

		// Token: 0x04000B00 RID: 2816
		private ActionBinding actionBindingAchievements_;

		// Token: 0x04000B01 RID: 2817
		public const int ActionBindingProfileFieldNumber = 15;

		// Token: 0x04000B02 RID: 2818
		private ActionBinding actionBindingProfile_;

		// Token: 0x04000B03 RID: 2819
		public const int ActionBindingEquippablesFieldNumber = 16;

		// Token: 0x04000B04 RID: 2820
		private ActionBinding actionBindingEquippables_;

		// Token: 0x04000B05 RID: 2821
		public const int ActionBindingConsoleFieldNumber = 18;

		// Token: 0x04000B06 RID: 2822
		private ActionBinding actionBindingConsole_;

		// Token: 0x04000B07 RID: 2823
		public const int ActionBindingMapFieldNumber = 19;

		// Token: 0x04000B08 RID: 2824
		private ActionBinding actionBindingMap_;

		// Token: 0x04000B09 RID: 2825
		public const int ActionBindingSkillTreeFieldNumber = 20;

		// Token: 0x04000B0A RID: 2826
		private ActionBinding actionBindingSkillTree_;

		// Token: 0x04000B0B RID: 2827
		public const int ActionBindingToggleplayerhpbarsFieldNumber = 22;

		// Token: 0x04000B0C RID: 2828
		private ActionBinding actionBindingToggleplayerhpbars_;

		// Token: 0x04000B0D RID: 2829
		public const int ActionBindingToggledamagenumbersFieldNumber = 23;

		// Token: 0x04000B0E RID: 2830
		private ActionBinding actionBindingToggledamagenumbers_;

		// Token: 0x04000B0F RID: 2831
		public const int ActionBindingToggleitemsongroundFieldNumber = 24;

		// Token: 0x04000B10 RID: 2832
		private ActionBinding actionBindingToggleitemsonground_;

		// Token: 0x04000B11 RID: 2833
		public const int ActionBindingRewhisperFieldNumber = 25;

		// Token: 0x04000B12 RID: 2834
		private ActionBinding actionBindingRewhisper_;

		// Token: 0x04000B13 RID: 2835
		public const int ActionBindingWhisperreplyFieldNumber = 26;

		// Token: 0x04000B14 RID: 2836
		private ActionBinding actionBindingWhisperreply_;

		// Token: 0x04000B15 RID: 2837
		public const int ActionBindingVoicepttFieldNumber = 27;

		// Token: 0x04000B16 RID: 2838
		private ActionBinding actionBindingVoiceptt_;

		// Token: 0x04000B17 RID: 2839
		public const int ActionBindingSocialwheelFieldNumber = 28;

		// Token: 0x04000B18 RID: 2840
		private ActionBinding actionBindingSocialwheel_;

		// Token: 0x04000B19 RID: 2841
		public const int ActionBindingFastquesttrackFieldNumber = 29;

		// Token: 0x04000B1A RID: 2842
		private ActionBinding actionBindingFastquesttrack_;

		// Token: 0x04000B1B RID: 2843
		public const int ActionBindingToggleLfdCompanionsFieldNumber = 30;

		// Token: 0x04000B1C RID: 2844
		private ActionBinding actionBindingToggleLfdCompanions_;

		// Token: 0x04000B1D RID: 2845
		public const int ActionBindingCollectionsFieldNumber = 31;

		// Token: 0x04000B1E RID: 2846
		private ActionBinding actionBindingCollections_;

		// Token: 0x04000B1F RID: 2847
		public const int ActionBindingSocialwheelLeftFieldNumber = 32;

		// Token: 0x04000B20 RID: 2848
		private static readonly FieldCodec<SocialWheelBinding> _repeated_actionBindingSocialwheelLeft_codec = FieldCodec.ForMessage<SocialWheelBinding>(258U, SocialWheelBinding.Parser);

		// Token: 0x04000B21 RID: 2849
		private readonly RepeatedField<SocialWheelBinding> actionBindingSocialwheelLeft_ = new RepeatedField<SocialWheelBinding>();

		// Token: 0x04000B22 RID: 2850
		public const int ActionBindingSocialwheelMiddleFieldNumber = 33;

		// Token: 0x04000B23 RID: 2851
		private static readonly FieldCodec<SocialWheelBinding> _repeated_actionBindingSocialwheelMiddle_codec = FieldCodec.ForMessage<SocialWheelBinding>(266U, SocialWheelBinding.Parser);

		// Token: 0x04000B24 RID: 2852
		private readonly RepeatedField<SocialWheelBinding> actionBindingSocialwheelMiddle_ = new RepeatedField<SocialWheelBinding>();

		// Token: 0x04000B25 RID: 2853
		public const int ActionBindingSocialwheelRightFieldNumber = 34;

		// Token: 0x04000B26 RID: 2854
		private static readonly FieldCodec<SocialWheelBinding> _repeated_actionBindingSocialwheelRight_codec = FieldCodec.ForMessage<SocialWheelBinding>(274U, SocialWheelBinding.Parser);

		// Token: 0x04000B27 RID: 2855
		private readonly RepeatedField<SocialWheelBinding> actionBindingSocialwheelRight_ = new RepeatedField<SocialWheelBinding>();

		// Token: 0x04000B28 RID: 2856
		public const int ActionBindingSocialwheelPageBackwardFieldNumber = 35;

		// Token: 0x04000B29 RID: 2857
		private ActionBinding actionBindingSocialwheelPageBackward_;

		// Token: 0x04000B2A RID: 2858
		public const int ActionBindingSocialwheelPageForwardFieldNumber = 36;

		// Token: 0x04000B2B RID: 2859
		private ActionBinding actionBindingSocialwheelPageForward_;

		// Token: 0x04000B2C RID: 2860
		public const int ActionBindingAbilitiesFieldNumber = 37;

		// Token: 0x04000B2D RID: 2861
		private ActionBinding actionBindingAbilities_;

		// Token: 0x04000B2E RID: 2862
		public const int ActionBindingReportBugFieldNumber = 38;

		// Token: 0x04000B2F RID: 2863
		private ActionBinding actionBindingReportBug_;

		// Token: 0x04000B30 RID: 2864
		public const int ActionBindingReportContentFieldNumber = 39;

		// Token: 0x04000B31 RID: 2865
		private ActionBinding actionBindingReportContent_;

		// Token: 0x04000B32 RID: 2866
		public const int ActionBindingJoinSpeechToTextChatFieldNumber = 40;

		// Token: 0x04000B33 RID: 2867
		private ActionBinding actionBindingJoinSpeechToTextChat_;

		// Token: 0x04000B34 RID: 2868
		public const int ActionBindingTtsSkipCurrentUtteranceFieldNumber = 41;

		// Token: 0x04000B35 RID: 2869
		private ActionBinding actionBindingTtsSkipCurrentUtterance_;

		// Token: 0x04000B36 RID: 2870
		public const int ActionBindingTtsCancelAllUtterancesFieldNumber = 42;

		// Token: 0x04000B37 RID: 2871
		private ActionBinding actionBindingTtsCancelAllUtterances_;

		// Token: 0x04000B38 RID: 2872
		public const int ActionBindingScreenReaderSkipLineFieldNumber = 43;

		// Token: 0x04000B39 RID: 2873
		private ActionBinding actionBindingScreenReaderSkipLine_;

		// Token: 0x04000B3A RID: 2874
		public const int ActionBindingStoreFieldNumber = 44;

		// Token: 0x04000B3B RID: 2875
		private ActionBinding actionBindingStore_;

		// Token: 0x04000B3C RID: 2876
		public const int ActionBindingMountSpurFieldNumber = 45;

		// Token: 0x04000B3D RID: 2877
		private ActionBinding actionBindingMountSpur_;

		// Token: 0x04000B3E RID: 2878
		public const int ActionBindingMountDismountFieldNumber = 46;

		// Token: 0x04000B3F RID: 2879
		private ActionBinding actionBindingMountDismount_;

		// Token: 0x04000B40 RID: 2880
		public const int ActionBindingMountCombatDismountFieldNumber = 47;

		// Token: 0x04000B41 RID: 2881
		private ActionBinding actionBindingMountCombatDismount_;

		// Token: 0x04000B42 RID: 2882
		public const int ActionBindingToggleZoomFieldNumber = 48;

		// Token: 0x04000B43 RID: 2883
		private ActionBinding actionBindingToggleZoom_;

		// Token: 0x04000B44 RID: 2884
		public const int ActionBindingHoldpositionFieldNumber = 53;

		// Token: 0x04000B45 RID: 2885
		private ActionBinding actionBindingHoldposition_;

		// Token: 0x04000B46 RID: 2886
		public const int ActionBindingSystemmastervolumeupFieldNumber = 54;

		// Token: 0x04000B47 RID: 2887
		private ActionBinding actionBindingSystemmastervolumeup_;

		// Token: 0x04000B48 RID: 2888
		public const int ActionBindingSystemmastervolumedownFieldNumber = 55;

		// Token: 0x04000B49 RID: 2889
		private ActionBinding actionBindingSystemmastervolumedown_;

		// Token: 0x04000B4A RID: 2890
		public const int ActionBindingSystemtogglemusicFieldNumber = 56;

		// Token: 0x04000B4B RID: 2891
		private ActionBinding actionBindingSystemtogglemusic_;

		// Token: 0x04000B4C RID: 2892
		public const int ActionBindingSystemtogglesoundFieldNumber = 57;

		// Token: 0x04000B4D RID: 2893
		private ActionBinding actionBindingSystemtogglesound_;

		// Token: 0x04000B4E RID: 2894
		public const int ActionBindingSystemscreenshotFieldNumber = 58;

		// Token: 0x04000B4F RID: 2895
		private ActionBinding actionBindingSystemscreenshot_;

		// Token: 0x04000B50 RID: 2896
		public const int ActionBindingSystemtogglefpsFieldNumber = 64;

		// Token: 0x04000B51 RID: 2897
		private ActionBinding actionBindingSystemtogglefps_;

		// Token: 0x04000B52 RID: 2898
		public const int ActionBindingChatpageupFieldNumber = 65;

		// Token: 0x04000B53 RID: 2899
		private ActionBinding actionBindingChatpageup_;

		// Token: 0x04000B54 RID: 2900
		public const int ActionBindingChatpagedownFieldNumber = 66;

		// Token: 0x04000B55 RID: 2901
		private ActionBinding actionBindingChatpagedown_;

		// Token: 0x04000B56 RID: 2902
		public const int ActionBindingGroupsFieldNumber = 67;

		// Token: 0x04000B57 RID: 2903
		private ActionBinding actionBindingGroups_;

		// Token: 0x04000B58 RID: 2904
		public const int ActionBindingClanFieldNumber = 68;

		// Token: 0x04000B59 RID: 2905
		private ActionBinding actionBindingClan_;

		// Token: 0x04000B5A RID: 2906
		public const int ActionBindingChatNextViewFieldNumber = 70;

		// Token: 0x04000B5B RID: 2907
		private ActionBinding actionBindingChatNextView_;

		// Token: 0x04000B5C RID: 2908
		public const int ActionBindingChatPreviousViewFieldNumber = 71;

		// Token: 0x04000B5D RID: 2909
		private ActionBinding actionBindingChatPreviousView_;

		// Token: 0x04000B5E RID: 2910
		public const int ActionBindingLeaderboardsFieldNumber = 72;

		// Token: 0x04000B5F RID: 2911
		private ActionBinding actionBindingLeaderboards_;

		// Token: 0x04000B60 RID: 2912
		public const int ActionBindingChatResetFadeFieldNumber = 73;

		// Token: 0x04000B61 RID: 2913
		private ActionBinding actionBindingChatResetFade_;

		// Token: 0x04000B62 RID: 2914
		public const int ActionBindingQuestsFieldNumber = 74;

		// Token: 0x04000B63 RID: 2915
		private ActionBinding actionBindingQuests_;

		// Token: 0x04000B64 RID: 2916
		public const int ActionBindingQuestsToggleFieldNumber = 75;

		// Token: 0x04000B65 RID: 2917
		private ActionBinding actionBindingQuestsToggle_;

		// Token: 0x04000B66 RID: 2918
		public const int ActionBindingRunFieldNumber = 79;

		// Token: 0x04000B67 RID: 2919
		private ActionBinding actionBindingRun_;

		// Token: 0x04000B68 RID: 2920
		public const int ActionBindingInteractFieldNumber = 80;

		// Token: 0x04000B69 RID: 2921
		private ActionBinding actionBindingInteract_;

		// Token: 0x04000B6A RID: 2922
		public const int ActionBindingPrimaryFieldNumber = 81;

		// Token: 0x04000B6B RID: 2923
		private ActionBinding actionBindingPrimary_;

		// Token: 0x04000B6C RID: 2924
		public const int ActionBindingSecondaryFieldNumber = 82;

		// Token: 0x04000B6D RID: 2925
		private ActionBinding actionBindingSecondary_;

		// Token: 0x04000B6E RID: 2926
		public const int ActionBindingSkill1FieldNumber = 83;

		// Token: 0x04000B6F RID: 2927
		private ActionBinding actionBindingSkill1_;

		// Token: 0x04000B70 RID: 2928
		public const int ActionBindingSkill2FieldNumber = 84;

		// Token: 0x04000B71 RID: 2929
		private ActionBinding actionBindingSkill2_;

		// Token: 0x04000B72 RID: 2930
		public const int ActionBindingSkill3FieldNumber = 85;

		// Token: 0x04000B73 RID: 2931
		private ActionBinding actionBindingSkill3_;

		// Token: 0x04000B74 RID: 2932
		public const int ActionBindingSkill4FieldNumber = 86;

		// Token: 0x04000B75 RID: 2933
		private ActionBinding actionBindingSkill4_;

		// Token: 0x04000B76 RID: 2934
		public const int ActionBindingMountFieldNumber = 87;

		// Token: 0x04000B77 RID: 2935
		private ActionBinding actionBindingMount_;

		// Token: 0x04000B78 RID: 2936
		public const int ActionBindingEvadeFieldNumber = 88;

		// Token: 0x04000B79 RID: 2937
		private ActionBinding actionBindingEvade_;

		// Token: 0x04000B7A RID: 2938
		public const int ActionBindingUseItemFieldNumber = 89;

		// Token: 0x04000B7B RID: 2939
		private ActionBinding actionBindingUseItem_;

		// Token: 0x04000B7C RID: 2940
		public const int ActionBindingCenterCameraFieldNumber = 90;

		// Token: 0x04000B7D RID: 2941
		private ActionBinding actionBindingCenterCamera_;

		// Token: 0x04000B7E RID: 2942
		public const int ActionBindingDebugCameraFieldNumber = 91;

		// Token: 0x04000B7F RID: 2943
		private ActionBinding actionBindingDebugCamera_;

		// Token: 0x04000B80 RID: 2944
		public const int ActionBindingSocialInteractFieldNumber = 93;

		// Token: 0x04000B81 RID: 2945
		private ActionBinding actionBindingSocialInteract_;

		// Token: 0x04000B82 RID: 2946
		public const int ActionBindingAcceptPartyInviteFieldNumber = 94;

		// Token: 0x04000B83 RID: 2947
		private ActionBinding actionBindingAcceptPartyInvite_;

		// Token: 0x04000B84 RID: 2948
		public const int ActionBindingLockTargetFieldNumber = 95;

		// Token: 0x04000B85 RID: 2949
		private ActionBinding actionBindingLockTarget_;

		// Token: 0x04000B86 RID: 2950
		public const int ActionBindingTownPortalFieldNumber = 96;

		// Token: 0x04000B87 RID: 2951
		private ActionBinding actionBindingTownPortal_;

		// Token: 0x04000B88 RID: 2952
		public const int ActionBindingForceMoveFieldNumber = 97;

		// Token: 0x04000B89 RID: 2953
		private ActionBinding actionBindingForceMove_;

		// Token: 0x04000B8A RID: 2954
		public const int ActionBindingClassScreenFieldNumber = 98;

		// Token: 0x04000B8B RID: 2955
		private ActionBinding actionBindingClassScreen_;

		// Token: 0x04000B8C RID: 2956
		public const int ActionBindingCycleLockTargetFieldNumber = 99;

		// Token: 0x04000B8D RID: 2957
		private ActionBinding actionBindingCycleLockTarget_;

		// Token: 0x04000B8E RID: 2958
		public const int NotifyDurationFieldNumber = 100;

		// Token: 0x04000B8F RID: 2959
		private static readonly uint NotifyDurationDefaultValue = 0U;

		// Token: 0x04000B90 RID: 2960
		private uint notifyDuration_;

		// Token: 0x04000B91 RID: 2961
		public const int KeybindingVersionFieldNumber = 101;

		// Token: 0x04000B92 RID: 2962
		private static readonly uint KeybindingVersionDefaultValue = 0U;

		// Token: 0x04000B93 RID: 2963
		private uint keybindingVersion_;

		// Token: 0x04000B94 RID: 2964
		public const int Flags2FieldNumber = 200;

		// Token: 0x04000B95 RID: 2965
		private static readonly uint Flags2DefaultValue = 0U;

		// Token: 0x04000B96 RID: 2966
		private uint flags2_;

		// Token: 0x04000B97 RID: 2967
		public const int ControlSchemeFieldNumber = 205;

		// Token: 0x04000B98 RID: 2968
		private static readonly int ControlSchemeDefaultValue = -1;

		// Token: 0x04000B99 RID: 2969
		private int controlScheme_;

		// Token: 0x04000B9A RID: 2970
		public const int ControllerButtonBindingVersionFieldNumber = 206;

		// Token: 0x04000B9B RID: 2971
		private static readonly uint ControllerButtonBindingVersionDefaultValue = 0U;

		// Token: 0x04000B9C RID: 2972
		private uint controllerButtonBindingVersion_;

		// Token: 0x04000B9D RID: 2973
		public const int ControllerBindingsXinputFieldNumber = 207;

		// Token: 0x04000B9E RID: 2974
		private ControllerActionBindings controllerBindingsXinput_;

		// Token: 0x04000B9F RID: 2975
		public const int ControllerBindingsPs4FieldNumber = 208;

		// Token: 0x04000BA0 RID: 2976
		private ControllerActionBindings controllerBindingsPs4_;

		// Token: 0x04000BA1 RID: 2977
		public const int ControllerBindingsNx64FieldNumber = 209;

		// Token: 0x04000BA2 RID: 2978
		private ControllerActionBindings controllerBindingsNx64_;

		// Token: 0x04000BA3 RID: 2979
		public const int ChatBackgroundOpacityWhenActiveFieldNumber = 210;

		// Token: 0x04000BA4 RID: 2980
		private static readonly uint ChatBackgroundOpacityWhenActiveDefaultValue = 0U;

		// Token: 0x04000BA5 RID: 2981
		private uint chatBackgroundOpacityWhenActive_;

		// Token: 0x04000BA6 RID: 2982
		public const int ChatTimestampFormatFieldNumber = 211;

		// Token: 0x04000BA7 RID: 2983
		private static readonly uint ChatTimestampFormatDefaultValue = 0U;

		// Token: 0x04000BA8 RID: 2984
		private uint chatTimestampFormat_;

		// Token: 0x04000BA9 RID: 2985
		public const int ItemLabelOnDropDurationFieldNumber = 212;

		// Token: 0x04000BAA RID: 2986
		private static readonly uint ItemLabelOnDropDurationDefaultValue = 0U;

		// Token: 0x04000BAB RID: 2987
		private uint itemLabelOnDropDuration_;

		// Token: 0x04000BAC RID: 2988
		public const int ItemLabelDisplayModeFieldNumber = 213;

		// Token: 0x04000BAD RID: 2989
		private static readonly uint ItemLabelDisplayModeDefaultValue = 0U;

		// Token: 0x04000BAE RID: 2990
		private uint itemLabelDisplayMode_;

		// Token: 0x04000BAF RID: 2991
		public const int ControllerCursorSensitivityFieldNumber = 214;

		// Token: 0x04000BB0 RID: 2992
		private static readonly float ControllerCursorSensitivityDefaultValue = 0.4f;

		// Token: 0x04000BB1 RID: 2993
		private float controllerCursorSensitivity_;

		// Token: 0x04000BB2 RID: 2994
		public const int ControllerInnerDeadZoneFieldNumber = 215;

		// Token: 0x04000BB3 RID: 2995
		private static readonly float ControllerInnerDeadZoneDefaultValue = 0.5f;

		// Token: 0x04000BB4 RID: 2996
		private float controllerInnerDeadZone_;

		// Token: 0x04000BB5 RID: 2997
		public const int ControllerOuterDeadZoneFieldNumber = 216;

		// Token: 0x04000BB6 RID: 2998
		private static readonly float ControllerOuterDeadZoneDefaultValue = 0f;

		// Token: 0x04000BB7 RID: 2999
		private float controllerOuterDeadZone_;

		// Token: 0x04000BB8 RID: 3000
		public const int PowerToggleModeFieldNumber = 217;

		// Token: 0x04000BB9 RID: 3001
		private static readonly uint PowerToggleModeDefaultValue = 0U;

		// Token: 0x04000BBA RID: 3002
		private uint powerToggleMode_;

		// Token: 0x04000BBB RID: 3003
		public const int SocialWheelActivationStyleFieldNumber = 218;

		// Token: 0x04000BBC RID: 3004
		private static readonly uint SocialWheelActivationStyleDefaultValue = 0U;

		// Token: 0x04000BBD RID: 3005
		private uint socialWheelActivationStyle_;

		// Token: 0x04000BBE RID: 3006
		public const int MonsterHealthBarModeFieldNumber = 219;

		// Token: 0x04000BBF RID: 3007
		private static readonly uint MonsterHealthBarModeDefaultValue = 0U;

		// Token: 0x04000BC0 RID: 3008
		private uint monsterHealthBarMode_;

		// Token: 0x04000BC1 RID: 3009
		public const int HoldPositionInputModeFieldNumber = 220;

		// Token: 0x04000BC2 RID: 3010
		private static readonly uint HoldPositionInputModeDefaultValue = 0U;

		// Token: 0x04000BC3 RID: 3011
		private uint holdPositionInputMode_;

		// Token: 0x04000BC4 RID: 3012
		public const int ControllerBindingsPs5FieldNumber = 221;

		// Token: 0x04000BC5 RID: 3013
		private ControllerActionBindings controllerBindingsPs5_;

		// Token: 0x02000C36 RID: 3126
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02001473 RID: 5235
			public enum Flags
			{
				// Token: 0x0400A35F RID: 41823
				[OriginalName("SHOW_PLAYER_HP_BARS")]
				ShowPlayerHpBars = 2,
				// Token: 0x0400A360 RID: 41824
				[OriginalName("SHOW_DAMAGE_NUMBERS")]
				ShowDamageNumbers,
				// Token: 0x0400A361 RID: 41825
				[OriginalName("AUTO_EQUIP_ITEMS")]
				AutoEquipItems,
				// Token: 0x0400A362 RID: 41826
				[OriginalName("SHOW_TUTORIALS")]
				ShowTutorials,
				// Token: 0x0400A363 RID: 41827
				[OriginalName("NOTIFY_FRIEND_ONLINE")]
				NotifyFriendOnline = 7,
				// Token: 0x0400A364 RID: 41828
				[OriginalName("NOTIFY_FRIEND_OFFLINE")]
				NotifyFriendOffline,
				// Token: 0x0400A365 RID: 41829
				[OriginalName("NOTIFY_FRIEND_REQUEST")]
				NotifyFriendRequest,
				// Token: 0x0400A366 RID: 41830
				[OriginalName("NOTIFY_FRIEND_ACHIEVEMENT")]
				NotifyFriendAchievement,
				// Token: 0x0400A367 RID: 41831
				[OriginalName("NOTIFY_DISPLAY_WINDOW")]
				NotifyDisplayWindow,
				// Token: 0x0400A368 RID: 41832
				[OriginalName("MATURE_LANGUAGE_FILTER")]
				MatureLanguageFilter,
				// Token: 0x0400A369 RID: 41833
				[OriginalName("ALLOW_QUICK_JOIN")]
				AllowQuickJoin,
				// Token: 0x0400A36A RID: 41834
				[OriginalName("ECHO_QUEST_DIALOG_TO_CHAT")]
				EchoQuestDialogToChat,
				// Token: 0x0400A36B RID: 41835
				[OriginalName("DISABLE_SCREEN_SHAKE")]
				DisableScreenShake,
				// Token: 0x0400A36C RID: 41836
				[OriginalName("USE_LEFT_HUD_CONFIG")]
				UseLeftHudConfig,
				// Token: 0x0400A36D RID: 41837
				[OriginalName("DISABLE_CONTROLLER_VIBRATION")]
				DisableControllerVibration,
				// Token: 0x0400A36E RID: 41838
				[OriginalName("NOTIFY_CLAN_MEMBER_ONLINE")]
				NotifyClanMemberOnline,
				// Token: 0x0400A36F RID: 41839
				[OriginalName("CROSSPLAY_ENABLED")]
				CrossplayEnabled,
				// Token: 0x0400A370 RID: 41840
				[OriginalName("CROSSCOMMS_ENABLED")]
				CrosscommsEnabled,
				// Token: 0x0400A371 RID: 41841
				[OriginalName("DISABLE_COMBAT_HIT_FLASH")]
				DisableCombatHitFlash,
				// Token: 0x0400A372 RID: 41842
				[OriginalName("SQUELCH_CLAN_NEWS_NOTIFICATIONS")]
				SquelchClanNewsNotifications,
				// Token: 0x0400A373 RID: 41843
				[OriginalName("REDUCE_STROBING")]
				ReduceStrobing,
				// Token: 0x0400A374 RID: 41844
				[OriginalName("PLAY_SOUND_ON_WHISPER_RECEIVED")]
				PlaySoundOnWhisperReceived,
				// Token: 0x0400A375 RID: 41845
				[OriginalName("JOIN_LOCAL_CHAT_CHANNEL")]
				JoinLocalChatChannel = 26,
				// Token: 0x0400A376 RID: 41846
				[OriginalName("JOIN_TRADE_CHAT_CHANNEL")]
				JoinTradeChatChannel,
				// Token: 0x0400A377 RID: 41847
				[OriginalName("SHOW_LOCAL_CHAT_BALLOONS")]
				ShowLocalChatBalloons,
				// Token: 0x0400A378 RID: 41848
				[OriginalName("SHOW_PARTY_CHAT_BALLOONS")]
				ShowPartyChatBalloons,
				// Token: 0x0400A379 RID: 41849
				[OriginalName("SHOW_CLAN_CHAT_BALLOONS")]
				ShowClanChatBalloons,
				// Token: 0x0400A37A RID: 41850
				[OriginalName("SHOW_TRADE_CHAT_BALLOONS")]
				ShowTradeChatBalloons
			}

			// Token: 0x02001474 RID: 5236
			public enum Flags2
			{
				// Token: 0x0400A37C RID: 41852
				[OriginalName("DISABLE_CUTSCENES")]
				DisableCutscenes = 3,
				// Token: 0x0400A37D RID: 41853
				[OriginalName("SHOW_LOCALPLAYERS")]
				ShowLocalplayers = 5,
				// Token: 0x0400A37E RID: 41854
				[OriginalName("NOTIFY_GUILD_MEMBER_ONLINE_DISABLED")]
				NotifyGuildMemberOnlineDisabled,
				// Token: 0x0400A37F RID: 41855
				[OriginalName("ADVANCED_COMPARE")]
				AdvancedCompare,
				// Token: 0x0400A380 RID: 41856
				[OriginalName("ADVANCED_TOOLTIP_INFO")]
				AdvancedTooltipInfo,
				// Token: 0x0400A381 RID: 41857
				[OriginalName("DISABLE_COMBINED_INTERACT")]
				DisableCombinedInteract,
				// Token: 0x0400A382 RID: 41858
				[OriginalName("HOLD_TO_LOCK_TARGET")]
				HoldToLockTarget,
				// Token: 0x0400A383 RID: 41859
				[OriginalName("AUTO_PROGRESSING_DIALOG")]
				AutoProgressingDialog,
				// Token: 0x0400A384 RID: 41860
				[OriginalName("SHOW_MINION_HP_BARS")]
				ShowMinionHpBars,
				// Token: 0x0400A385 RID: 41861
				[OriginalName("FIRST_TIME_OPTION_SETTING_COMPLETED")]
				FirstTimeOptionSettingCompleted,
				// Token: 0x0400A386 RID: 41862
				[OriginalName("FIRST_CHARACTER_FLOW_COMPLETED")]
				FirstCharacterFlowCompleted,
				// Token: 0x0400A387 RID: 41863
				[OriginalName("PERSIST_TARGET_LOCK")]
				PersistTargetLock = 16,
				// Token: 0x0400A388 RID: 41864
				[OriginalName("SWAP_CONTROLLER_STICKS")]
				SwapControllerSticks,
				// Token: 0x0400A389 RID: 41865
				[OriginalName("OCCLUSION_HIGHLIGHTING")]
				OcclusionHighlighting,
				// Token: 0x0400A38A RID: 41866
				[OriginalName("PLAYER_HIGHLIGHTING")]
				PlayerHighlighting,
				// Token: 0x0400A38B RID: 41867
				[OriginalName("COMBINE_PRIMARY_ACTIONS")]
				CombinePrimaryActions,
				// Token: 0x0400A38C RID: 41868
				[OriginalName("MOUSE_WHEEL_ZOOM")]
				MouseWheelZoom
			}
		}
	}
}
