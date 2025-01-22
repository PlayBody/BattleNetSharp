using System;

namespace Framework.Constants
{
	// Token: 0x020007AC RID: 1964
	public enum ServerOpcodes : uint
	{
		// Token: 0x040054BE RID: 21694
		AbortNewWorld = 9628U,
		// Token: 0x040054BF RID: 21695
		AccountCosmeticAdded = 10364U,
		// Token: 0x040054C0 RID: 21696
		AccountCriteriaUpdate = 10338U,
		// Token: 0x040054C1 RID: 21697
		AccountDataTimes = 9989U,
		// Token: 0x040054C2 RID: 21698
		AccountMountRemoved = 9648U,
		// Token: 0x040054C3 RID: 21699
		AccountMountUpdate = 9647U,
		// Token: 0x040054C4 RID: 21700
		AccountNotificationsResponse = 10363U,
		// Token: 0x040054C5 RID: 21701
		AccountToyUpdate = 9649U,
		// Token: 0x040054C6 RID: 21702
		AccountTransmogSetFavoritesUpdate = 9652U,
		// Token: 0x040054C7 RID: 21703
		AccountTransmogUpdate = 9651U,
		// Token: 0x040054C8 RID: 21704
		AchievementDeleted = 9955U,
		// Token: 0x040054C9 RID: 21705
		AchievementEarned = 9793U,
		// Token: 0x040054CA RID: 21706
		ActivateEssenceFailed = 12309U,
		// Token: 0x040054CB RID: 21707
		ActivateSoulbindFailed = 12311U,
		// Token: 0x040054CC RID: 21708
		ActivateTaxiReply = 9851U,
		// Token: 0x040054CD RID: 21709
		ActiveGlyphs = 11351U,
		// Token: 0x040054CE RID: 21710
		AddonListRequest = 9792U,
		// Token: 0x040054CF RID: 21711
		AddBattlenetFriendResponse = 9787U,
		// Token: 0x040054D0 RID: 21712
		AddItemPassive = 9643U,
		// Token: 0x040054D1 RID: 21713
		AddLossOfControl = 9839U,
		// Token: 0x040054D2 RID: 21714
		AddRunePower = 9909U,
		// Token: 0x040054D3 RID: 21715
		AdjustSplineDuration = 9680U,
		// Token: 0x040054D4 RID: 21716
		AdvancedCombatLog = 10360U,
		// Token: 0x040054D5 RID: 21717
		AdventureJournalDataResponse = 10354U,
		// Token: 0x040054D6 RID: 21718
		AeLootTargets = 9750U,
		// Token: 0x040054D7 RID: 21719
		AeLootTargetAck,
		// Token: 0x040054D8 RID: 21720
		AiReaction = 9906U,
		// Token: 0x040054D9 RID: 21721
		AlliedRaceDetails = 10229U,
		// Token: 0x040054DA RID: 21722
		AllAccountCriteria = 9585U,
		// Token: 0x040054DB RID: 21723
		AllAchievementData = 9584U,
		// Token: 0x040054DC RID: 21724
		AllGuildAchievements = 10680U,
		// Token: 0x040054DD RID: 21725
		ApplyMountEquipmentResult = 10319U,
		// Token: 0x040054DE RID: 21726
		ArchaeologySurveryCast = 9608U,
		// Token: 0x040054DF RID: 21727
		AreaPoiUpdateResponse = 12304U,
		// Token: 0x040054E0 RID: 21728
		AreaSpiritHealerTime = 10042U,
		// Token: 0x040054E1 RID: 21729
		AreaTriggerDenied = 10498U,
		// Token: 0x040054E2 RID: 21730
		AreaTriggerForceSetPositionAndFacing = 10495U,
		// Token: 0x040054E3 RID: 21731
		AreaTriggerNoCorpse = 10001U,
		// Token: 0x040054E4 RID: 21732
		AreaTriggerPlaySpellVisual = 10494U,
		// Token: 0x040054E5 RID: 21733
		AreaTriggerRePath = 10493U,
		// Token: 0x040054E6 RID: 21734
		AreaTriggerReShape = 10497U,
		// Token: 0x040054E7 RID: 21735
		AreaTriggerUnattach = 10496U,
		// Token: 0x040054E8 RID: 21736
		ArenaClearOpponents = 9799U,
		// Token: 0x040054E9 RID: 21737
		ArenaCrowdControlSpellResult = 9776U,
		// Token: 0x040054EA RID: 21738
		ArenaPrepOpponentSpecializations = 9798U,
		// Token: 0x040054EB RID: 21739
		ArtifactEndgamePowersRefunded = 10143U,
		// Token: 0x040054EC RID: 21740
		ArtifactForgeError = 10141U,
		// Token: 0x040054ED RID: 21741
		ArtifactRespecPrompt,
		// Token: 0x040054EE RID: 21742
		ArtifactXpGain = 10216U,
		// Token: 0x040054EF RID: 21743
		AttackerStateUpdate = 10573U,
		// Token: 0x040054F0 RID: 21744
		AttackStart = 10552U,
		// Token: 0x040054F1 RID: 21745
		AttackStop,
		// Token: 0x040054F2 RID: 21746
		AttackSwingError = 10567U,
		// Token: 0x040054F3 RID: 21747
		AttackSwingLandedLog,
		// Token: 0x040054F4 RID: 21748
		AuctionableTokenAuctionSold = 10193U,
		// Token: 0x040054F5 RID: 21749
		AuctionableTokenSellAtMarketPriceResponse = 10192U,
		// Token: 0x040054F6 RID: 21750
		AuctionableTokenSellConfirmRequired = 10191U,
		// Token: 0x040054F7 RID: 21751
		AuctionClosedNotification = 9966U,
		// Token: 0x040054F8 RID: 21752
		AuctionCommandResult = 9963U,
		// Token: 0x040054F9 RID: 21753
		AuctionDisableNewPostings = 10389U,
		// Token: 0x040054FA RID: 21754
		AuctionFavoriteList = 10345U,
		// Token: 0x040054FB RID: 21755
		AuctionGetCommodityQuoteResult = 10336U,
		// Token: 0x040054FC RID: 21756
		AuctionHelloResponse = 9961U,
		// Token: 0x040054FD RID: 21757
		AuctionListBiddedItemsResult = 10335U,
		// Token: 0x040054FE RID: 21758
		AuctionListBucketsResult = 10332U,
		// Token: 0x040054FF RID: 21759
		AuctionListItemsResult,
		// Token: 0x04005500 RID: 21760
		AuctionListOwnedItemsResult,
		// Token: 0x04005501 RID: 21761
		AuctionOutbidNotification = 9965U,
		// Token: 0x04005502 RID: 21762
		AuctionOwnerBidNotification = 9967U,
		// Token: 0x04005503 RID: 21763
		AuctionReplicateResponse = 9962U,
		// Token: 0x04005504 RID: 21764
		AuctionWonNotification = 9964U,
		// Token: 0x04005505 RID: 21765
		AuraPointsDepleted = 11299U,
		// Token: 0x04005506 RID: 21766
		AuraUpdate = 11298U,
		// Token: 0x04005507 RID: 21767
		AuthChallenge = 12360U,
		// Token: 0x04005508 RID: 21768
		AuthFailed = 9580U,
		// Token: 0x04005509 RID: 21769
		AuthResponse,
		// Token: 0x0400550A RID: 21770
		AvailableHotfixes = 10511U,
		// Token: 0x0400550B RID: 21771
		BagCleanupFinished = 11687U,
		// Token: 0x0400550C RID: 21772
		BarberShopResult = 9914U,
		// Token: 0x0400550D RID: 21773
		BatchPresenceSubscription = 10304U,
		// Token: 0x0400550E RID: 21774
		BattlefieldList = 10535U,
		// Token: 0x0400550F RID: 21775
		BattlefieldPortDenied = 10541U,
		// Token: 0x04005510 RID: 21776
		BattlefieldStatusActive = 10531U,
		// Token: 0x04005511 RID: 21777
		BattlefieldStatusFailed = 10534U,
		// Token: 0x04005512 RID: 21778
		BattlefieldStatusGroupProposalFailed = 10544U,
		// Token: 0x04005513 RID: 21779
		BattlefieldStatusNeedConfirmation = 10530U,
		// Token: 0x04005514 RID: 21780
		BattlefieldStatusNone = 10533U,
		// Token: 0x04005515 RID: 21781
		BattlefieldStatusQueued = 10532U,
		// Token: 0x04005516 RID: 21782
		BattlefieldStatusWaitForGroups = 10543U,
		// Token: 0x04005517 RID: 21783
		BattlegroundInfoThrottled = 10542U,
		// Token: 0x04005518 RID: 21784
		BattlegroundInit = 10570U,
		// Token: 0x04005519 RID: 21785
		BattlegroundPlayerJoined = 10539U,
		// Token: 0x0400551A RID: 21786
		BattlegroundPlayerLeft,
		// Token: 0x0400551B RID: 21787
		BattlegroundPlayerPositions = 10536U,
		// Token: 0x0400551C RID: 21788
		BattlegroundPoints = 10569U,
		// Token: 0x0400551D RID: 21789
		BattlenetChallengeAbort = 10116U,
		// Token: 0x0400551E RID: 21790
		BattlenetChallengeStart = 10115U,
		// Token: 0x0400551F RID: 21791
		BattlenetNotification = 10241U,
		// Token: 0x04005520 RID: 21792
		BattlenetResponse = 10240U,
		// Token: 0x04005521 RID: 21793
		BattleNetConnectionStatus = 10242U,
		// Token: 0x04005522 RID: 21794
		BattlePayAckFailed = 10110U,
		// Token: 0x04005523 RID: 21795
		BattlePayBattlePetDelivered = 10099U,
		// Token: 0x04005524 RID: 21796
		BattlePayCollectionItemDelivered,
		// Token: 0x04005525 RID: 21797
		BattlePayConfirmPurchase = 10109U,
		// Token: 0x04005526 RID: 21798
		BattlePayDeliveryEnded = 10097U,
		// Token: 0x04005527 RID: 21799
		BattlePayDeliveryStarted = 10096U,
		// Token: 0x04005528 RID: 21800
		BattlePayDistributionAssignVasResponse = 10369U,
		// Token: 0x04005529 RID: 21801
		BattlePayDistributionUnrevoked = 10094U,
		// Token: 0x0400552A RID: 21802
		BattlePayDistributionUpdate,
		// Token: 0x0400552B RID: 21803
		BattlePayGetDistributionListResponse = 10093U,
		// Token: 0x0400552C RID: 21804
		BattlePayGetProductListResponse = 10091U,
		// Token: 0x0400552D RID: 21805
		BattlePayGetPurchaseListResponse,
		// Token: 0x0400552E RID: 21806
		BattlePayMountDelivered = 10098U,
		// Token: 0x0400552F RID: 21807
		BattlePayPurchaseUpdate = 10108U,
		// Token: 0x04005530 RID: 21808
		BattlePayStartCheckout = 10269U,
		// Token: 0x04005531 RID: 21809
		BattlePayStartDistributionAssignToTargetResponse = 10106U,
		// Token: 0x04005532 RID: 21810
		BattlePayStartPurchaseResponse = 10105U,
		// Token: 0x04005533 RID: 21811
		BattlePayValidatePurchaseResponse = 10257U,
		// Token: 0x04005534 RID: 21812
		BattlePetsHealed = 9714U,
		// Token: 0x04005535 RID: 21813
		BattlePetCageDateError = 9846U,
		// Token: 0x04005536 RID: 21814
		BattlePetDeleted = 9711U,
		// Token: 0x04005537 RID: 21815
		BattlePetError = 9782U,
		// Token: 0x04005538 RID: 21816
		BattlePetJournal = 9710U,
		// Token: 0x04005539 RID: 21817
		BattlePetJournalLockAcquired = 9708U,
		// Token: 0x0400553A RID: 21818
		BattlePetJournalLockDenied,
		// Token: 0x0400553B RID: 21819
		BattlePetLicenseChanged = 9715U,
		// Token: 0x0400553C RID: 21820
		BattlePetRestored = 9713U,
		// Token: 0x0400553D RID: 21821
		BattlePetRevoked = 9712U,
		// Token: 0x0400553E RID: 21822
		BattlePetTrapLevel = 9706U,
		// Token: 0x0400553F RID: 21823
		BattlePetUpdates = 9705U,
		// Token: 0x04005540 RID: 21824
		BindPointUpdate = 9597U,
		// Token: 0x04005541 RID: 21825
		BlackMarketBidOnItemResult = 9766U,
		// Token: 0x04005542 RID: 21826
		BlackMarketOutbid,
		// Token: 0x04005543 RID: 21827
		BlackMarketRequestItemsResult = 9765U,
		// Token: 0x04005544 RID: 21828
		BlackMarketWon = 9768U,
		// Token: 0x04005545 RID: 21829
		BonusRollEmpty = 9795U,
		// Token: 0x04005546 RID: 21830
		BossKill = 10572U,
		// Token: 0x04005547 RID: 21831
		BreakTarget = 10551U,
		// Token: 0x04005548 RID: 21832
		BroadcastAchievement = 11196U,
		// Token: 0x04005549 RID: 21833
		BroadcastSummonCast = 10306U,
		// Token: 0x0400554A RID: 21834
		BroadcastSummonResponse,
		// Token: 0x0400554B RID: 21835
		BuyFailed = 9923U,
		// Token: 0x0400554C RID: 21836
		BuySucceeded = 9922U,
		// Token: 0x0400554D RID: 21837
		CacheInfo = 10525U,
		// Token: 0x0400554E RID: 21838
		CacheVersion = 10524U,
		// Token: 0x0400554F RID: 21839
		CalendarClearPendingAction = 9883U,
		// Token: 0x04005550 RID: 21840
		CalendarCommandResult,
		// Token: 0x04005551 RID: 21841
		CalendarCommunityInvite = 9867U,
		// Token: 0x04005552 RID: 21842
		CalendarEventRemovedAlert = 9875U,
		// Token: 0x04005553 RID: 21843
		CalendarEventUpdatedAlert,
		// Token: 0x04005554 RID: 21844
		CalendarInviteAdded = 9868U,
		// Token: 0x04005555 RID: 21845
		CalendarInviteAlert = 9872U,
		// Token: 0x04005556 RID: 21846
		CalendarInviteNotes = 9877U,
		// Token: 0x04005557 RID: 21847
		CalendarInviteNotesAlert,
		// Token: 0x04005558 RID: 21848
		CalendarInviteRemoved = 9869U,
		// Token: 0x04005559 RID: 21849
		CalendarInviteRemovedAlert = 9874U,
		// Token: 0x0400555A RID: 21850
		CalendarInviteStatus = 9870U,
		// Token: 0x0400555B RID: 21851
		CalendarInviteStatusAlert = 9873U,
		// Token: 0x0400555C RID: 21852
		CalendarModeratorStatus = 9871U,
		// Token: 0x0400555D RID: 21853
		CalendarRaidLockoutAdded = 9879U,
		// Token: 0x0400555E RID: 21854
		CalendarRaidLockoutRemoved,
		// Token: 0x0400555F RID: 21855
		CalendarRaidLockoutUpdated,
		// Token: 0x04005560 RID: 21856
		CalendarSendCalendar = 9865U,
		// Token: 0x04005561 RID: 21857
		CalendarSendEvent,
		// Token: 0x04005562 RID: 21858
		CalendarSendNumPending = 9882U,
		// Token: 0x04005563 RID: 21859
		CameraEffect = 10016U,
		// Token: 0x04005564 RID: 21860
		CancelAutoRepeat = 9945U,
		// Token: 0x04005565 RID: 21861
		CancelCombat = 10566U,
		// Token: 0x04005566 RID: 21862
		CancelOrphanSpellVisual = 11337U,
		// Token: 0x04005567 RID: 21863
		CancelPreloadWorld = 9626U,
		// Token: 0x04005568 RID: 21864
		CancelScene = 9781U,
		// Token: 0x04005569 RID: 21865
		CancelSpellVisual = 11335U,
		// Token: 0x0400556A RID: 21866
		CancelSpellVisualKit = 11339U,
		// Token: 0x0400556B RID: 21867
		CanDuelResult = 10562U,
		// Token: 0x0400556C RID: 21868
		CanRedeemTokenForBalanceResponse = 10256U,
		// Token: 0x0400556D RID: 21869
		CapturePointRemoved = 10538U,
		// Token: 0x0400556E RID: 21870
		CastFailed = 11354U,
		// Token: 0x0400556F RID: 21871
		CategoryCooldown = 11286U,
		// Token: 0x04005570 RID: 21872
		ChainMissileBounce = 9672U,
		// Token: 0x04005571 RID: 21873
		ChallengeModeComplete = 9738U,
		// Token: 0x04005572 RID: 21874
		ChallengeModeRequestLeadersResult = 9742U,
		// Token: 0x04005573 RID: 21875
		ChallengeModeReset = 9737U,
		// Token: 0x04005574 RID: 21876
		ChallengeModeStart = 9735U,
		// Token: 0x04005575 RID: 21877
		ChallengeModeUpdateDeathCount,
		// Token: 0x04005576 RID: 21878
		ChangePlayerDifficultyResult = 12292U,
		// Token: 0x04005577 RID: 21879
		ChangeRealmTicketResponse = 10243U,
		// Token: 0x04005578 RID: 21880
		ChannelList = 11203U,
		// Token: 0x04005579 RID: 21881
		ChannelNotify = 11200U,
		// Token: 0x0400557A RID: 21882
		ChannelNotifyJoined,
		// Token: 0x0400557B RID: 21883
		ChannelNotifyLeft,
		// Token: 0x0400557C RID: 21884
		CharacterCheckUpgradeResult = 10170U,
		// Token: 0x0400557D RID: 21885
		CharacterLoginFailed = 9984U,
		// Token: 0x0400557E RID: 21886
		CharacterObjectTestResponse = 10114U,
		// Token: 0x0400557F RID: 21887
		CharacterRenameResult = 10077U,
		// Token: 0x04005580 RID: 21888
		CharacterUpgradeAborted = 10169U,
		// Token: 0x04005581 RID: 21889
		CharacterUpgradeComplete = 10168U,
		// Token: 0x04005582 RID: 21890
		CharacterUpgradeManualUnrevokeResult = 10171U,
		// Token: 0x04005583 RID: 21891
		CharacterUpgradeStarted = 10167U,
		// Token: 0x04005584 RID: 21892
		CharCustomizeFailure = 9949U,
		// Token: 0x04005585 RID: 21893
		CharCustomizeSuccess,
		// Token: 0x04005586 RID: 21894
		CharFactionChangeResult = 10148U,
		// Token: 0x04005587 RID: 21895
		Chat = 11181U,
		// Token: 0x04005588 RID: 21896
		ChatAutoResponded = 11192U,
		// Token: 0x04005589 RID: 21897
		ChatDown = 11197U,
		// Token: 0x0400558A RID: 21898
		ChatIgnoredAccountMuted = 11180U,
		// Token: 0x0400558B RID: 21899
		ChatIsDown = 11198U,
		// Token: 0x0400558C RID: 21900
		ChatNotInParty = 11186U,
		// Token: 0x0400558D RID: 21901
		ChatPlayerAmbiguous = 11184U,
		// Token: 0x0400558E RID: 21902
		ChatPlayerNotfound = 11191U,
		// Token: 0x0400558F RID: 21903
		ChatReconnect = 11199U,
		// Token: 0x04005590 RID: 21904
		ChatRegionalServiceStatus = 11205U,
		// Token: 0x04005591 RID: 21905
		ChatRestricted = 11187U,
		// Token: 0x04005592 RID: 21906
		ChatServerMessage = 11204U,
		// Token: 0x04005593 RID: 21907
		CheatIgnoreDimishingReturns = 11282U,
		// Token: 0x04005594 RID: 21908
		CheckAbandonNpe = 12312U,
		// Token: 0x04005595 RID: 21909
		CheckCharacterNameAvailabilityResult = 9604U,
		// Token: 0x04005596 RID: 21910
		CheckWargameEntry = 9618U,
		// Token: 0x04005597 RID: 21911
		ChromieTimeSelectExpansionSuccess = 10348U,
		// Token: 0x04005598 RID: 21912
		ClaimRafRewardResponse = 10323U,
		// Token: 0x04005599 RID: 21913
		ClearAllSpellCharges = 11303U,
		// Token: 0x0400559A RID: 21914
		ClearBossEmotes = 9659U,
		// Token: 0x0400559B RID: 21915
		ClearCooldown = 9911U,
		// Token: 0x0400559C RID: 21916
		ClearCooldowns = 11302U,
		// Token: 0x0400559D RID: 21917
		ClearResurrect = 9599U,
		// Token: 0x0400559E RID: 21918
		ClearSpellCharges = 11304U,
		// Token: 0x0400559F RID: 21919
		ClearTarget = 10563U,
		// Token: 0x040055A0 RID: 21920
		ClearTreasurePickerCache = 10913U,
		// Token: 0x040055A1 RID: 21921
		CloseArtifactForge = 10140U,
		// Token: 0x040055A2 RID: 21922
		ClubFinderErrorMessage = 10315U,
		// Token: 0x040055A3 RID: 21923
		ClubFinderGetClubPostingIdsResponse = 10318U,
		// Token: 0x040055A4 RID: 21924
		ClubFinderLookupClubPostingsList = 10316U,
		// Token: 0x040055A5 RID: 21925
		ClubFinderResponseCharacterApplicationList = 10313U,
		// Token: 0x040055A6 RID: 21926
		ClubFinderResponsePostRecruitmentMessage = 10317U,
		// Token: 0x040055A7 RID: 21927
		ClubFinderUpdateApplications = 10314U,
		// Token: 0x040055A8 RID: 21928
		ClubFinderWhisperApplicantResponse = 10383U,
		// Token: 0x040055A9 RID: 21929
		CoinRemoved = 9749U,
		// Token: 0x040055AA RID: 21930
		CombatEventFailed = 10554U,
		// Token: 0x040055AB RID: 21931
		CommentatorMapInfo = 9986U,
		// Token: 0x040055AC RID: 21932
		CommentatorPlayerInfo,
		// Token: 0x040055AD RID: 21933
		CommentatorStateChanged = 9985U,
		// Token: 0x040055AE RID: 21934
		CommerceTokenGetCountResponse = 10188U,
		// Token: 0x040055AF RID: 21935
		CommerceTokenGetLogResponse = 10200U,
		// Token: 0x040055B0 RID: 21936
		CommerceTokenGetMarketPriceResponse = 10190U,
		// Token: 0x040055B1 RID: 21937
		CommerceTokenUpdate = 10189U,
		// Token: 0x040055B2 RID: 21938
		ComplaintResult = 9897U,
		// Token: 0x040055B3 RID: 21939
		CompleteShipmentResponse = 10133U,
		// Token: 0x040055B4 RID: 21940
		ConfirmPartyInvite = 10255U,
		// Token: 0x040055B5 RID: 21941
		ConnectTo = 12365U,
		// Token: 0x040055B6 RID: 21942
		ConquestFormulaConstants = 10111U,
		// Token: 0x040055B7 RID: 21943
		ConsoleWrite = 9779U,
		// Token: 0x040055B8 RID: 21944
		ConsumableTokenBuyAtMarketPriceResponse = 10196U,
		// Token: 0x040055B9 RID: 21945
		ConsumableTokenBuyChoiceRequired = 10195U,
		// Token: 0x040055BA RID: 21946
		ConsumableTokenCanVeteranBuyResponse = 10194U,
		// Token: 0x040055BB RID: 21947
		ConsumableTokenRedeemConfirmRequired = 10198U,
		// Token: 0x040055BC RID: 21948
		ConsumableTokenRedeemResponse,
		// Token: 0x040055BD RID: 21949
		ContactList = 10112U,
		// Token: 0x040055BE RID: 21950
		ContributionLastUpdateResponse = 10262U,
		// Token: 0x040055BF RID: 21951
		ControlUpdate = 9797U,
		// Token: 0x040055C0 RID: 21952
		ConvertItemsToCurrencyValue = 10357U,
		// Token: 0x040055C1 RID: 21953
		CooldownCheat = 10035U,
		// Token: 0x040055C2 RID: 21954
		CooldownEvent = 9910U,
		// Token: 0x040055C3 RID: 21955
		CorpseLocation = 9805U,
		// Token: 0x040055C4 RID: 21956
		CorpseReclaimDelay = 10052U,
		// Token: 0x040055C5 RID: 21957
		CorpseTransportQuery = 9997U,
		// Token: 0x040055C6 RID: 21958
		CovenantCallingsAvailabilityResponse = 10915U,
		// Token: 0x040055C7 RID: 21959
		CovenantPreviewOpenNpc = 10232U,
		// Token: 0x040055C8 RID: 21960
		CovenantRenownSendCatchupState = 10358U,
		// Token: 0x040055C9 RID: 21961
		CraftingHouseHelloResponse = 10406U,
		// Token: 0x040055CA RID: 21962
		CraftingOrderCancelResult = 10402U,
		// Token: 0x040055CB RID: 21963
		CraftingOrderClaimResult = 10398U,
		// Token: 0x040055CC RID: 21964
		CraftingOrderCraftResult = 10400U,
		// Token: 0x040055CD RID: 21965
		CraftingOrderCreateResult = 10396U,
		// Token: 0x040055CE RID: 21966
		CraftingOrderFulfillResult = 10401U,
		// Token: 0x040055CF RID: 21967
		CraftingOrderListOrdersResponse = 10397U,
		// Token: 0x040055D0 RID: 21968
		CraftingOrderRejectResult = 10404U,
		// Token: 0x040055D1 RID: 21969
		CraftingOrderReleaseResult = 10399U,
		// Token: 0x040055D2 RID: 21970
		CraftingOrderUpdateState = 10407U,
		// Token: 0x040055D3 RID: 21971
		CraftEnchantResult = 10405U,
		// Token: 0x040055D4 RID: 21972
		CreateChar = 9980U,
		// Token: 0x040055D5 RID: 21973
		CreateShipmentResponse = 10132U,
		// Token: 0x040055D6 RID: 21974
		CreatorVisualsOverride = 10410U,
		// Token: 0x040055D7 RID: 21975
		CriteriaDeleted = 9954U,
		// Token: 0x040055D8 RID: 21976
		CriteriaUpdate = 9948U,
		// Token: 0x040055D9 RID: 21977
		CrossedInebriationThreshold = 9918U,
		// Token: 0x040055DA RID: 21978
		CustomLoadScreen = 9675U,
		// Token: 0x040055DB RID: 21979
		DailyQuestsReset = 10880U,
		// Token: 0x040055DC RID: 21980
		DamageCalcLog = 10177U,
		// Token: 0x040055DD RID: 21981
		DbReply = 10510U,
		// Token: 0x040055DE RID: 21982
		DeathReleaseLoc = 9935U,
		// Token: 0x040055DF RID: 21983
		DebugMenuManagerFullUpdate = 9811U,
		// Token: 0x040055E0 RID: 21984
		DefenseMessage = 11190U,
		// Token: 0x040055E1 RID: 21985
		DeleteChar = 9981U,
		// Token: 0x040055E2 RID: 21986
		DeleteExpiredMissionsResult = 10624U,
		// Token: 0x040055E3 RID: 21987
		DestroyArenaUnit = 10044U,
		// Token: 0x040055E4 RID: 21988
		DestructibleBuildingDamage = 9972U,
		// Token: 0x040055E5 RID: 21989
		DifferentInstanceFromParty = 9612U,
		// Token: 0x040055E6 RID: 21990
		DisenchantCredit = 9640U,
		// Token: 0x040055E7 RID: 21991
		DismountResult = 9596U,
		// Token: 0x040055E8 RID: 21992
		DispelFailed = 11312U,
		// Token: 0x040055E9 RID: 21993
		DisplayGameError = 9633U,
		// Token: 0x040055EA RID: 21994
		DisplayPlayerChoice = 12284U,
		// Token: 0x040055EB RID: 21995
		DisplayPromotion = 9802U,
		// Token: 0x040055EC RID: 21996
		DisplayQuestPopup = 10910U,
		// Token: 0x040055ED RID: 21997
		DisplaySoulbindUpdateMessage = 10362U,
		// Token: 0x040055EE RID: 21998
		DisplayToast = 9762U,
		// Token: 0x040055EF RID: 21999
		DisplayWorldText = 10217U,
		// Token: 0x040055F0 RID: 22000
		DontAutoPushSpellsToActionBar = 9696U,
		// Token: 0x040055F1 RID: 22001
		DropNewConnection = 12364U,
		// Token: 0x040055F2 RID: 22002
		DuelArranged = 10556U,
		// Token: 0x040055F3 RID: 22003
		DuelComplete = 10560U,
		// Token: 0x040055F4 RID: 22004
		DuelCountdown = 10559U,
		// Token: 0x040055F5 RID: 22005
		DuelInBounds = 10558U,
		// Token: 0x040055F6 RID: 22006
		DuelOutOfBounds = 10557U,
		// Token: 0x040055F7 RID: 22007
		DuelRequested = 10555U,
		// Token: 0x040055F8 RID: 22008
		DuelWinner = 10561U,
		// Token: 0x040055F9 RID: 22009
		DurabilityDamageDeath = 10048U,
		// Token: 0x040055FA RID: 22010
		Emote = 10178U,
		// Token: 0x040055FB RID: 22011
		EnableBarberShop = 9913U,
		// Token: 0x040055FC RID: 22012
		EnchantmentLog = 9998U,
		// Token: 0x040055FD RID: 22013
		EncounterEnd = 10104U,
		// Token: 0x040055FE RID: 22014
		EncounterStart = 10103U,
		// Token: 0x040055FF RID: 22015
		EndLightningStorm = 9894U,
		// Token: 0x04005600 RID: 22016
		EnsureWorldLoaded = 10377U,
		// Token: 0x04005601 RID: 22017
		EnterEncryptedMode = 12361U,
		// Token: 0x04005602 RID: 22018
		EnumCharactersResult = 9603U,
		// Token: 0x04005603 RID: 22019
		EnumVasPurchaseStatesResponse = 10222U,
		// Token: 0x04005604 RID: 22020
		EnvironmentalDamageLog = 11297U,
		// Token: 0x04005605 RID: 22021
		EquipmentSetId = 9903U,
		// Token: 0x04005606 RID: 22022
		ExpectedSpamRecords = 11185U,
		// Token: 0x04005607 RID: 22023
		ExplorationExperience = 10073U,
		// Token: 0x04005608 RID: 22024
		ExternalTransactionIdGenerated = 10355U,
		// Token: 0x04005609 RID: 22025
		FactionBonusInfo = 10015U,
		// Token: 0x0400560A RID: 22026
		FailedPlayerCondition = 12282U,
		// Token: 0x0400560B RID: 22027
		FailedQuestTurnIn = 10252U,
		// Token: 0x0400560C RID: 22028
		FeatureSystemStatus = 9663U,
		// Token: 0x0400560D RID: 22029
		FeatureSystemStatusGlueScreen,
		// Token: 0x0400560E RID: 22030
		FeignDeathResisted = 10047U,
		// Token: 0x0400560F RID: 22031
		FishEscaped = 9932U,
		// Token: 0x04005610 RID: 22032
		FishNotHooked = 9931U,
		// Token: 0x04005611 RID: 22033
		FlightSplineSync = 11819U,
		// Token: 0x04005612 RID: 22034
		ForcedDeathUpdate = 9936U,
		// Token: 0x04005613 RID: 22035
		ForceAnim = 10059U,
		// Token: 0x04005614 RID: 22036
		ForceAnimations,
		// Token: 0x04005615 RID: 22037
		ForceObjectRelink = 9801U,
		// Token: 0x04005616 RID: 22038
		FriendStatus = 10113U,
		// Token: 0x04005617 RID: 22039
		GainMawPower = 10205U,
		// Token: 0x04005618 RID: 22040
		GameObjectActivateAnimKit = 9667U,
		// Token: 0x04005619 RID: 22041
		GameObjectBase = 10275U,
		// Token: 0x0400561A RID: 22042
		GameObjectCloseInteraction = 10381U,
		// Token: 0x0400561B RID: 22043
		GameObjectCustomAnim = 9668U,
		// Token: 0x0400561C RID: 22044
		GameObjectDespawn,
		// Token: 0x0400561D RID: 22045
		GameObjectInteraction = 10380U,
		// Token: 0x0400561E RID: 22046
		GameObjectPlaySpellVisual = 11342U,
		// Token: 0x0400561F RID: 22047
		GameObjectPlaySpellVisualKit = 11341U,
		// Token: 0x04005620 RID: 22048
		GameObjectResetState = 10009U,
		// Token: 0x04005621 RID: 22049
		GameObjectSetStateLocal = 10239U,
		// Token: 0x04005622 RID: 22050
		GameSpeedSet = 9855U,
		// Token: 0x04005623 RID: 22051
		GameTimeSet = 9991U,
		// Token: 0x04005624 RID: 22052
		GameTimeUpdate = 9990U,
		// Token: 0x04005625 RID: 22053
		GarrisonActivateMissionBonusAbility = 10626U,
		// Token: 0x04005626 RID: 22054
		GarrisonAddEvent = 10662U,
		// Token: 0x04005627 RID: 22055
		GarrisonAddFollowerResult = 10612U,
		// Token: 0x04005628 RID: 22056
		GarrisonAddMissionResult = 10616U,
		// Token: 0x04005629 RID: 22057
		GarrisonAddSpecGroups = 10665U,
		// Token: 0x0400562A RID: 22058
		GarrisonApplyTalentSocketDataChanges = 10669U,
		// Token: 0x0400562B RID: 22059
		GarrisonAssignFollowerToBuildingResult = 10634U,
		// Token: 0x0400562C RID: 22060
		GarrisonAutoTroopMinLevelUpdateResult = 10671U,
		// Token: 0x0400562D RID: 22061
		GarrisonBuildingActivated = 10601U,
		// Token: 0x0400562E RID: 22062
		GarrisonBuildingRemoved = 10594U,
		// Token: 0x0400562F RID: 22063
		GarrisonBuildingSetActiveSpecializationResult = 10596U,
		// Token: 0x04005630 RID: 22064
		GarrisonChangeMissionStartTimeResult = 10619U,
		// Token: 0x04005631 RID: 22065
		GarrisonClearCollection = 10661U,
		// Token: 0x04005632 RID: 22066
		GarrisonClearEventList = 10664U,
		// Token: 0x04005633 RID: 22067
		GarrisonClearSpecGroups = 10666U,
		// Token: 0x04005634 RID: 22068
		GarrisonCollectionRemoveEntry = 10660U,
		// Token: 0x04005635 RID: 22069
		GarrisonCollectionUpdateEntry = 10659U,
		// Token: 0x04005636 RID: 22070
		GarrisonCompleteBuildingConstructionResult = 10651U,
		// Token: 0x04005637 RID: 22071
		GarrisonCompleteMissionResult = 10618U,
		// Token: 0x04005638 RID: 22072
		GarrisonCreateResult = 10602U,
		// Token: 0x04005639 RID: 22073
		GarrisonDeleteMissionResult = 10625U,
		// Token: 0x0400563A RID: 22074
		GarrisonDeleteResult = 10643U,
		// Token: 0x0400563B RID: 22075
		GarrisonFollowerActivationsSet = 10633U,
		// Token: 0x0400563C RID: 22076
		GarrisonFollowerChangedFlags = 10631U,
		// Token: 0x0400563D RID: 22077
		GarrisonFollowerChangedItemLevel = 10629U,
		// Token: 0x0400563E RID: 22078
		GarrisonFollowerChangedQuality,
		// Token: 0x0400563F RID: 22079
		GarrisonFollowerChangedXp = 10628U,
		// Token: 0x04005640 RID: 22080
		GarrisonFollowerFatigueCleared = 10632U,
		// Token: 0x04005641 RID: 22081
		GarrisonGenerateFollowersResult = 10641U,
		// Token: 0x04005642 RID: 22082
		GarrisonGetClassSpecCategoryInfoResult = 10611U,
		// Token: 0x04005643 RID: 22083
		GarrisonGetRecallPortalLastUsedTimeResult = 10620U,
		// Token: 0x04005644 RID: 22084
		GarrisonIsUpgradeableResponse = 10653U,
		// Token: 0x04005645 RID: 22085
		GarrisonLearnBlueprintResult = 10597U,
		// Token: 0x04005646 RID: 22086
		GarrisonLearnSpecializationResult = 10595U,
		// Token: 0x04005647 RID: 22087
		GarrisonListCompletedMissionsCheatResult = 10654U,
		// Token: 0x04005648 RID: 22088
		GarrisonListFollowersCheatResult = 10615U,
		// Token: 0x04005649 RID: 22089
		GarrisonMapDataResponse = 10656U,
		// Token: 0x0400564A RID: 22090
		GarrisonMissionBonusRollResult = 10622U,
		// Token: 0x0400564B RID: 22091
		GarrisonMissionRequestRewardInfoResponse = 10657U,
		// Token: 0x0400564C RID: 22092
		GarrisonMissionStartConditionUpdate = 10627U,
		// Token: 0x0400564D RID: 22093
		GarrisonOpenCrafter = 10645U,
		// Token: 0x0400564E RID: 22094
		GarrisonOpenRecruitmentNpc = 10638U,
		// Token: 0x0400564F RID: 22095
		GarrisonPlaceBuildingResult = 10593U,
		// Token: 0x04005650 RID: 22096
		GarrisonPlotPlaced = 10591U,
		// Token: 0x04005651 RID: 22097
		GarrisonPlotRemoved,
		// Token: 0x04005652 RID: 22098
		GarrisonRecruitFollowerResult = 10642U,
		// Token: 0x04005653 RID: 22099
		GarrisonRemoteInfo = 10600U,
		// Token: 0x04005654 RID: 22100
		GarrisonRemoveEvent = 10663U,
		// Token: 0x04005655 RID: 22101
		GarrisonRemoveFollowerAbilityResult = 10637U,
		// Token: 0x04005656 RID: 22102
		GarrisonRemoveFollowerFromBuildingResult = 10635U,
		// Token: 0x04005657 RID: 22103
		GarrisonRemoveFollowerResult = 10613U,
		// Token: 0x04005658 RID: 22104
		GarrisonRenameFollowerResult = 10636U,
		// Token: 0x04005659 RID: 22105
		GarrisonRequestBlueprintAndSpecializationDataResult = 10599U,
		// Token: 0x0400565A RID: 22106
		GarrisonResearchTalentResult = 10604U,
		// Token: 0x0400565B RID: 22107
		GarrisonResetTalentTree = 10609U,
		// Token: 0x0400565C RID: 22108
		GarrisonResetTalentTreeSocketData,
		// Token: 0x0400565D RID: 22109
		GarrisonStartMissionResult = 10617U,
		// Token: 0x0400565E RID: 22110
		GarrisonSwapBuildingsResponse = 10650U,
		// Token: 0x0400565F RID: 22111
		GarrisonSwitchTalentTreeBranch = 10667U,
		// Token: 0x04005660 RID: 22112
		GarrisonTalentCompleted = 10605U,
		// Token: 0x04005661 RID: 22113
		GarrisonTalentRemoved,
		// Token: 0x04005662 RID: 22114
		GarrisonTalentRemoveSocketData = 10608U,
		// Token: 0x04005663 RID: 22115
		GarrisonTalentUpdateSocketData = 10607U,
		// Token: 0x04005664 RID: 22116
		GarrisonTalentWorldQuestUnlocksResponse = 10668U,
		// Token: 0x04005665 RID: 22117
		GarrisonUnlearnBlueprintResult = 10598U,
		// Token: 0x04005666 RID: 22118
		GarrisonUpdateFollower = 10614U,
		// Token: 0x04005667 RID: 22119
		GarrisonUpdateGarrisonMonumentSelections = 10652U,
		// Token: 0x04005668 RID: 22120
		GarrisonUpdateMissionCheatResult = 10670U,
		// Token: 0x04005669 RID: 22121
		GarrisonUpgradeResult = 10603U,
		// Token: 0x0400566A RID: 22122
		GarrisonUseRecallPortalResult = 10621U,
		// Token: 0x0400566B RID: 22123
		GenerateRandomCharacterNameResult = 9605U,
		// Token: 0x0400566C RID: 22124
		GenerateSsoTokenResponse = 10263U,
		// Token: 0x0400566D RID: 22125
		GetAccountCharacterListResult = 10075U,
		// Token: 0x0400566E RID: 22126
		GetGarrisonInfoResult = 10590U,
		// Token: 0x0400566F RID: 22127
		GetLandingPageShipmentsResponse = 10135U,
		// Token: 0x04005670 RID: 22128
		GetRemainingGameTimeResponse = 10197U,
		// Token: 0x04005671 RID: 22129
		GetSelectedTrophyIdResponse = 10175U,
		// Token: 0x04005672 RID: 22130
		GetShipmentsOfTypeResponse = 10134U,
		// Token: 0x04005673 RID: 22131
		GetShipmentInfoResponse = 10130U,
		// Token: 0x04005674 RID: 22132
		GetTrophyListResponse = 10174U,
		// Token: 0x04005675 RID: 22133
		GetVasAccountCharacterListResult = 10218U,
		// Token: 0x04005676 RID: 22134
		GetVasTransferTargetRealmListResult,
		// Token: 0x04005677 RID: 22135
		GmPlayerInfo = 12293U,
		// Token: 0x04005678 RID: 22136
		GmRequestPlayerInfo = 12283U,
		// Token: 0x04005679 RID: 22137
		GmTicketCaseStatus = 9889U,
		// Token: 0x0400567A RID: 22138
		GmTicketSystemStatus = 9888U,
		// Token: 0x0400567B RID: 22139
		GodMode = 9975U,
		// Token: 0x0400567C RID: 22140
		GossipComplete = 10903U,
		// Token: 0x0400567D RID: 22141
		GossipMessage,
		// Token: 0x0400567E RID: 22142
		GossipOptionNpcInteraction = 10919U,
		// Token: 0x0400567F RID: 22143
		GossipPoi = 10127U,
		// Token: 0x04005680 RID: 22144
		GossipQuestUpdate = 10905U,
		// Token: 0x04005681 RID: 22145
		GossipRefreshOptions = 10918U,
		// Token: 0x04005682 RID: 22146
		GroupActionThrottled = 9616U,
		// Token: 0x04005683 RID: 22147
		GroupAutoKick = 10124U,
		// Token: 0x04005684 RID: 22148
		GroupDecline = 10120U,
		// Token: 0x04005685 RID: 22149
		GroupDestroyed = 10123U,
		// Token: 0x04005686 RID: 22150
		GroupNewLeader = 9771U,
		// Token: 0x04005687 RID: 22151
		GroupRequestDecline = 10121U,
		// Token: 0x04005688 RID: 22152
		GroupUninvite,
		// Token: 0x04005689 RID: 22153
		GuildAchievementDeleted = 10693U,
		// Token: 0x0400568A RID: 22154
		GuildAchievementEarned = 10692U,
		// Token: 0x0400568B RID: 22155
		GuildAchievementMembers = 10695U,
		// Token: 0x0400568C RID: 22156
		GuildBankLogQueryResults = 10719U,
		// Token: 0x0400568D RID: 22157
		GuildBankQueryResults = 10718U,
		// Token: 0x0400568E RID: 22158
		GuildBankRemainingWithdrawMoney = 10720U,
		// Token: 0x0400568F RID: 22159
		GuildBankTextQueryResult = 10723U,
		// Token: 0x04005690 RID: 22160
		GuildChallengeCompleted = 10707U,
		// Token: 0x04005691 RID: 22161
		GuildChallengeUpdate = 10706U,
		// Token: 0x04005692 RID: 22162
		GuildChangeNameResult = 10717U,
		// Token: 0x04005693 RID: 22163
		GuildCommandResult = 10682U,
		// Token: 0x04005694 RID: 22164
		GuildCriteriaDeleted = 10694U,
		// Token: 0x04005695 RID: 22165
		GuildCriteriaUpdate = 10691U,
		// Token: 0x04005696 RID: 22166
		GuildEventBankContentsChanged = 10744U,
		// Token: 0x04005697 RID: 22167
		GuildEventBankMoneyChanged = 10743U,
		// Token: 0x04005698 RID: 22168
		GuildEventDisbanded = 10733U,
		// Token: 0x04005699 RID: 22169
		GuildEventLogQueryResults = 10722U,
		// Token: 0x0400569A RID: 22170
		GuildEventMotd = 10734U,
		// Token: 0x0400569B RID: 22171
		GuildEventNewLeader = 10732U,
		// Token: 0x0400569C RID: 22172
		GuildEventPlayerJoined = 10730U,
		// Token: 0x0400569D RID: 22173
		GuildEventPlayerLeft,
		// Token: 0x0400569E RID: 22174
		GuildEventPresenceChange = 10735U,
		// Token: 0x0400569F RID: 22175
		GuildEventRanksUpdated = 10737U,
		// Token: 0x040056A0 RID: 22176
		GuildEventRankChanged,
		// Token: 0x040056A1 RID: 22177
		GuildEventStatusChange = 10736U,
		// Token: 0x040056A2 RID: 22178
		GuildEventTabAdded = 10739U,
		// Token: 0x040056A3 RID: 22179
		GuildEventTabDeleted,
		// Token: 0x040056A4 RID: 22180
		GuildEventTabModified,
		// Token: 0x040056A5 RID: 22181
		GuildEventTabTextChanged,
		// Token: 0x040056A6 RID: 22182
		GuildFlaggedForRename = 10716U,
		// Token: 0x040056A7 RID: 22183
		GuildInvite = 10698U,
		// Token: 0x040056A8 RID: 22184
		GuildInviteDeclined = 10728U,
		// Token: 0x040056A9 RID: 22185
		GuildInviteExpired,
		// Token: 0x040056AA RID: 22186
		GuildItemLootedNotify = 10708U,
		// Token: 0x040056AB RID: 22187
		GuildKnownRecipes = 10686U,
		// Token: 0x040056AC RID: 22188
		GuildMembersWithRecipe,
		// Token: 0x040056AD RID: 22189
		GuildMemberDailyReset = 10724U,
		// Token: 0x040056AE RID: 22190
		GuildMemberRecipes = 10685U,
		// Token: 0x040056AF RID: 22191
		GuildMemberUpdateNote = 10697U,
		// Token: 0x040056B0 RID: 22192
		GuildMoved = 10714U,
		// Token: 0x040056B1 RID: 22193
		GuildMoveStarting = 10713U,
		// Token: 0x040056B2 RID: 22194
		GuildNameChanged = 10715U,
		// Token: 0x040056B3 RID: 22195
		GuildNews = 10689U,
		// Token: 0x040056B4 RID: 22196
		GuildNewsDeleted,
		// Token: 0x040056B5 RID: 22197
		GuildPartyState = 10699U,
		// Token: 0x040056B6 RID: 22198
		GuildPermissionsQueryResults = 10721U,
		// Token: 0x040056B7 RID: 22199
		GuildRanks = 10696U,
		// Token: 0x040056B8 RID: 22200
		GuildReputationReactionChanged = 10700U,
		// Token: 0x040056B9 RID: 22201
		GuildReset = 10712U,
		// Token: 0x040056BA RID: 22202
		GuildRewardList = 10688U,
		// Token: 0x040056BB RID: 22203
		GuildRoster = 10683U,
		// Token: 0x040056BC RID: 22204
		GuildRosterUpdate,
		// Token: 0x040056BD RID: 22205
		GuildSendRankChange = 10681U,
		// Token: 0x040056BE RID: 22206
		HealthUpdate = 9933U,
		// Token: 0x040056BF RID: 22207
		HighestThreatUpdate = 9941U,
		// Token: 0x040056C0 RID: 22208
		HotfixConnect = 10513U,
		// Token: 0x040056C1 RID: 22209
		HotfixMessage = 10512U,
		// Token: 0x040056C2 RID: 22210
		InitializeFactions = 10014U,
		// Token: 0x040056C3 RID: 22211
		InitialSetup = 9600U,
		// Token: 0x040056C4 RID: 22212
		InitWorldStates = 10049U,
		// Token: 0x040056C5 RID: 22213
		InspectResult = 9775U,
		// Token: 0x040056C6 RID: 22214
		InstanceEncounterChangePriority = 10154U,
		// Token: 0x040056C7 RID: 22215
		InstanceEncounterDisengageUnit = 10153U,
		// Token: 0x040056C8 RID: 22216
		InstanceEncounterEnd = 10162U,
		// Token: 0x040056C9 RID: 22217
		InstanceEncounterEngageUnit = 10152U,
		// Token: 0x040056CA RID: 22218
		InstanceEncounterGainCombatResurrectionCharge = 10164U,
		// Token: 0x040056CB RID: 22219
		InstanceEncounterInCombatResurrection = 10163U,
		// Token: 0x040056CC RID: 22220
		InstanceEncounterObjectiveComplete = 10157U,
		// Token: 0x040056CD RID: 22221
		InstanceEncounterObjectiveStart = 10156U,
		// Token: 0x040056CE RID: 22222
		InstanceEncounterObjectiveUpdate = 10161U,
		// Token: 0x040056CF RID: 22223
		InstanceEncounterPhaseShiftChanged = 10165U,
		// Token: 0x040056D0 RID: 22224
		InstanceEncounterStart = 10158U,
		// Token: 0x040056D1 RID: 22225
		InstanceEncounterTimerStart = 10155U,
		// Token: 0x040056D2 RID: 22226
		InstanceEncounterUpdateAllowReleaseInProgress = 10160U,
		// Token: 0x040056D3 RID: 22227
		InstanceEncounterUpdateSuppressRelease = 10159U,
		// Token: 0x040056D4 RID: 22228
		InstanceGroupSizeChanged = 9973U,
		// Token: 0x040056D5 RID: 22229
		InstanceInfo = 9778U,
		// Token: 0x040056D6 RID: 22230
		InstanceReset = 9860U,
		// Token: 0x040056D7 RID: 22231
		InstanceResetFailed,
		// Token: 0x040056D8 RID: 22232
		InstanceSaveCreated = 10102U,
		// Token: 0x040056D9 RID: 22233
		InterruptPowerRegen = 11356U,
		// Token: 0x040056DA RID: 22234
		InvalidatePageText = 10520U,
		// Token: 0x040056DB RID: 22235
		InvalidatePlayer = 12287U,
		// Token: 0x040056DC RID: 22236
		InvalidPromotionCode = 10061U,
		// Token: 0x040056DD RID: 22237
		InventoryChangeFailure = 11685U,
		// Token: 0x040056DE RID: 22238
		InventoryFixupComplete = 10254U,
		// Token: 0x040056DF RID: 22239
		InventoryFullOverflow = 10271U,
		// Token: 0x040056E0 RID: 22240
		IslandAzeriteGain = 10070U,
		// Token: 0x040056E1 RID: 22241
		IslandComplete,
		// Token: 0x040056E2 RID: 22242
		IsQuestCompleteResponse = 10884U,
		// Token: 0x040056E3 RID: 22243
		ItemChanged = 9958U,
		// Token: 0x040056E4 RID: 22244
		ItemCooldown = 10176U,
		// Token: 0x040056E5 RID: 22245
		ItemEnchantTimeUpdate = 10063U,
		// Token: 0x040056E6 RID: 22246
		ItemExpirePurchaseRefund = 9632U,
		// Token: 0x040056E7 RID: 22247
		ItemInteractionComplete = 10347U,
		// Token: 0x040056E8 RID: 22248
		ItemPurchaseRefundResult = 9630U,
		// Token: 0x040056E9 RID: 22249
		ItemPushResult = 9761U,
		// Token: 0x040056EA RID: 22250
		ItemTimeUpdate = 10062U,
		// Token: 0x040056EB RID: 22251
		KickReason = 9863U,
		// Token: 0x040056EC RID: 22252
		LatencyReportPing = 10365U,
		// Token: 0x040056ED RID: 22253
		LearnedSpells = 11344U,
		// Token: 0x040056EE RID: 22254
		LearnPvpTalentFailed = 9684U,
		// Token: 0x040056EF RID: 22255
		LearnTalentFailed = 9683U,
		// Token: 0x040056F0 RID: 22256
		LegacyLootRules = 10276U,
		// Token: 0x040056F1 RID: 22257
		LevelLinkingResult = 10321U,
		// Token: 0x040056F2 RID: 22258
		LevelUpInfo = 9956U,
		// Token: 0x040056F3 RID: 22259
		LfgBootPlayer = 10805U,
		// Token: 0x040056F4 RID: 22260
		LfgDisabled = 10803U,
		// Token: 0x040056F5 RID: 22261
		LfgExpandSearchPrompt = 10811U,
		// Token: 0x040056F6 RID: 22262
		LfgInstanceShutdownCountdown = 10789U,
		// Token: 0x040056F7 RID: 22263
		LfgJoinResult = 10780U,
		// Token: 0x040056F8 RID: 22264
		LfgListApplicantListUpdate = 10795U,
		// Token: 0x040056F9 RID: 22265
		LfgListApplicationStatusUpdate = 10792U,
		// Token: 0x040056FA RID: 22266
		LfgListApplyToGroupResult,
		// Token: 0x040056FB RID: 22267
		LfgListJoinResult = 10781U,
		// Token: 0x040056FC RID: 22268
		LfgListSearchResults,
		// Token: 0x040056FD RID: 22269
		LfgListSearchResultsUpdate = 10796U,
		// Token: 0x040056FE RID: 22270
		LfgListSearchStatus = 10783U,
		// Token: 0x040056FF RID: 22271
		LfgListUpdateBlacklist = 10794U,
		// Token: 0x04005700 RID: 22272
		LfgListUpdateExpiration = 10791U,
		// Token: 0x04005701 RID: 22273
		LfgListUpdateStatus = 10790U,
		// Token: 0x04005702 RID: 22274
		LfgOfferContinue = 10804U,
		// Token: 0x04005703 RID: 22275
		LfgPartyInfo = 10806U,
		// Token: 0x04005704 RID: 22276
		LfgPlayerInfo,
		// Token: 0x04005705 RID: 22277
		LfgPlayerReward,
		// Token: 0x04005706 RID: 22278
		LfgProposalUpdate = 10797U,
		// Token: 0x04005707 RID: 22279
		LfgQueueStatus = 10784U,
		// Token: 0x04005708 RID: 22280
		LfgReadyCheckResult = 10810U,
		// Token: 0x04005709 RID: 22281
		LfgReadyCheckUpdate = 10786U,
		// Token: 0x0400570A RID: 22282
		LfgRoleCheckUpdate = 10785U,
		// Token: 0x0400570B RID: 22283
		LfgSlotInvalid = 10800U,
		// Token: 0x0400570C RID: 22284
		LfgTeleportDenied = 10802U,
		// Token: 0x0400570D RID: 22285
		LfgUpdateStatus = 10788U,
		// Token: 0x0400570E RID: 22286
		LiveRegionAccountRestoreResult = 10088U,
		// Token: 0x0400570F RID: 22287
		LiveRegionCharacterCopyResult = 10087U,
		// Token: 0x04005710 RID: 22288
		LiveRegionGetAccountCharacterListResult = 10076U,
		// Token: 0x04005711 RID: 22289
		LiveRegionKeyBindingsCopyResult = 10089U,
		// Token: 0x04005712 RID: 22290
		LoadCufProfiles = 9660U,
		// Token: 0x04005713 RID: 22291
		LoadEquipmentSet = 9993U,
		// Token: 0x04005714 RID: 22292
		LobbyMatchmakerPartyInfo = 10385U,
		// Token: 0x04005715 RID: 22293
		LoginSetTimeSpeed = 9992U,
		// Token: 0x04005716 RID: 22294
		LoginVerifyWorld = 9627U,
		// Token: 0x04005717 RID: 22295
		LogoutCancelAck = 9859U,
		// Token: 0x04005718 RID: 22296
		LogoutComplete = 9858U,
		// Token: 0x04005719 RID: 22297
		LogoutResponse = 9857U,
		// Token: 0x0400571A RID: 22298
		LogXpGain = 9952U,
		// Token: 0x0400571B RID: 22299
		LootAllPassed = 9759U,
		// Token: 0x0400571C RID: 22300
		LootList = 10043U,
		// Token: 0x0400571D RID: 22301
		LootMoneyNotify = 9754U,
		// Token: 0x0400571E RID: 22302
		LootRelease = 9753U,
		// Token: 0x0400571F RID: 22303
		LootReleaseAll = 9752U,
		// Token: 0x04005720 RID: 22304
		LootRemoved = 9748U,
		// Token: 0x04005721 RID: 22305
		LootResponse = 9747U,
		// Token: 0x04005722 RID: 22306
		LootRoll = 9756U,
		// Token: 0x04005723 RID: 22307
		LootRollsComplete = 9758U,
		// Token: 0x04005724 RID: 22308
		LootRollWon = 9760U,
		// Token: 0x04005725 RID: 22309
		LossOfControlAuraUpdate = 9838U,
		// Token: 0x04005726 RID: 22310
		MailCommandResult = 9785U,
		// Token: 0x04005727 RID: 22311
		MailListResult = 10064U,
		// Token: 0x04005728 RID: 22312
		MailQueryNextTimeResult,
		// Token: 0x04005729 RID: 22313
		MapObjectivesInit = 10571U,
		// Token: 0x0400572A RID: 22314
		MapObjEvents = 9670U,
		// Token: 0x0400572B RID: 22315
		MasterLootCandidateList = 9757U,
		// Token: 0x0400572C RID: 22316
		MeetingStoneFailed = 10386U,
		// Token: 0x0400572D RID: 22317
		MessageBox = 9590U,
		// Token: 0x0400572E RID: 22318
		MinimapPing = 9930U,
		// Token: 0x0400572F RID: 22319
		MirrorImageComponentedData = 11284U,
		// Token: 0x04005730 RID: 22320
		MirrorImageCreatureData = 11283U,
		// Token: 0x04005731 RID: 22321
		MissileCancel = 9671U,
		// Token: 0x04005732 RID: 22322
		ModifyCooldown = 10078U,
		// Token: 0x04005733 RID: 22323
		Motd = 11183U,
		// Token: 0x04005734 RID: 22324
		MountResult = 9595U,
		// Token: 0x04005735 RID: 22325
		MovementEnforcementAlert = 10305U,
		// Token: 0x04005736 RID: 22326
		MoveAddImpulse = 11826U,
		// Token: 0x04005737 RID: 22327
		MoveApplyInertia = 11822U,
		// Token: 0x04005738 RID: 22328
		MoveApplyMovementForce = 11797U,
		// Token: 0x04005739 RID: 22329
		MoveDisableCollision = 11793U,
		// Token: 0x0400573A RID: 22330
		MoveDisableDoubleJump = 11773U,
		// Token: 0x0400573B RID: 22331
		MoveDisableGravity = 11789U,
		// Token: 0x0400573C RID: 22332
		MoveDisableInertia = 11791U,
		// Token: 0x0400573D RID: 22333
		MoveDisableTransitionBetweenSwimAndFly = 11788U,
		// Token: 0x0400573E RID: 22334
		MoveEnableCollision = 11794U,
		// Token: 0x0400573F RID: 22335
		MoveEnableDoubleJump = 11772U,
		// Token: 0x04005740 RID: 22336
		MoveEnableGravity = 11790U,
		// Token: 0x04005741 RID: 22337
		MoveEnableInertia = 11792U,
		// Token: 0x04005742 RID: 22338
		MoveEnableTransitionBetweenSwimAndFly = 11787U,
		// Token: 0x04005743 RID: 22339
		MoveKnockBack = 11779U,
		// Token: 0x04005744 RID: 22340
		MoveRemoveInertia = 11823U,
		// Token: 0x04005745 RID: 22341
		MoveRemoveMovementForce = 11798U,
		// Token: 0x04005746 RID: 22342
		MoveRoot = 11769U,
		// Token: 0x04005747 RID: 22343
		MoveSetActiveMover = 11733U,
		// Token: 0x04005748 RID: 22344
		MoveSetAdvFlyingAddImpulseMaxSpeed = 11835U,
		// Token: 0x04005749 RID: 22345
		MoveSetAdvFlyingAirFriction = 11830U,
		// Token: 0x0400574A RID: 22346
		MoveSetAdvFlyingBankingRate = 11836U,
		// Token: 0x0400574B RID: 22347
		MoveSetAdvFlyingDoubleJumpVelMod = 11833U,
		// Token: 0x0400574C RID: 22348
		MoveSetAdvFlyingGlideStartMinHeight,
		// Token: 0x0400574D RID: 22349
		MoveSetAdvFlyingLaunchSpeedCoefficient = 11842U,
		// Token: 0x0400574E RID: 22350
		MoveSetAdvFlyingLiftCoefficient = 11832U,
		// Token: 0x0400574F RID: 22351
		MoveSetAdvFlyingMaxVel = 11831U,
		// Token: 0x04005750 RID: 22352
		MoveSetAdvFlyingOverMaxDeceleration = 11841U,
		// Token: 0x04005751 RID: 22353
		MoveSetAdvFlyingPitchingRateDown = 11837U,
		// Token: 0x04005752 RID: 22354
		MoveSetAdvFlyingPitchingRateUp,
		// Token: 0x04005753 RID: 22355
		MoveSetAdvFlyingSurfaceFriction = 11840U,
		// Token: 0x04005754 RID: 22356
		MoveSetAdvFlyingTurnVelocityThreshold = 11839U,
		// Token: 0x04005755 RID: 22357
		MoveSetCanAdvFly = 11828U,
		// Token: 0x04005756 RID: 22358
		MoveSetCanFly = 11781U,
		// Token: 0x04005757 RID: 22359
		MoveSetCanTurnWhileFalling = 11783U,
		// Token: 0x04005758 RID: 22360
		MoveSetCollisionHeight = 11795U,
		// Token: 0x04005759 RID: 22361
		MoveSetCompoundState = 11799U,
		// Token: 0x0400575A RID: 22362
		MoveSetFeatherFall = 11775U,
		// Token: 0x0400575B RID: 22363
		MoveSetFlightBackSpeed = 11765U,
		// Token: 0x0400575C RID: 22364
		MoveSetFlightSpeed = 11764U,
		// Token: 0x0400575D RID: 22365
		MoveSetHovering = 11777U,
		// Token: 0x0400575E RID: 22366
		MoveSetIgnoreMovementForces = 11785U,
		// Token: 0x0400575F RID: 22367
		MoveSetLandWalk = 11774U,
		// Token: 0x04005760 RID: 22368
		MoveSetModMovementForceMagnitude = 11750U,
		// Token: 0x04005761 RID: 22369
		MoveSetNormalFall = 11776U,
		// Token: 0x04005762 RID: 22370
		MoveSetPitchRate = 11768U,
		// Token: 0x04005763 RID: 22371
		MoveSetRunBackSpeed = 11761U,
		// Token: 0x04005764 RID: 22372
		MoveSetRunSpeed = 11760U,
		// Token: 0x04005765 RID: 22373
		MoveSetSwimBackSpeed = 11763U,
		// Token: 0x04005766 RID: 22374
		MoveSetSwimSpeed = 11762U,
		// Token: 0x04005767 RID: 22375
		MoveSetTurnRate = 11767U,
		// Token: 0x04005768 RID: 22376
		MoveSetVehicleRecId = 11796U,
		// Token: 0x04005769 RID: 22377
		MoveSetWalkSpeed = 11766U,
		// Token: 0x0400576A RID: 22378
		MoveSetWaterWalk = 11771U,
		// Token: 0x0400576B RID: 22379
		MoveSkipTime = 11800U,
		// Token: 0x0400576C RID: 22380
		MoveSplineDisableCollision = 11805U,
		// Token: 0x0400576D RID: 22381
		MoveSplineDisableGravity = 11803U,
		// Token: 0x0400576E RID: 22382
		MoveSplineEnableCollision = 11806U,
		// Token: 0x0400576F RID: 22383
		MoveSplineEnableGravity = 11804U,
		// Token: 0x04005770 RID: 22384
		MoveSplineRoot = 11801U,
		// Token: 0x04005771 RID: 22385
		MoveSplineSetFeatherFall = 11807U,
		// Token: 0x04005772 RID: 22386
		MoveSplineSetFlightBackSpeed = 11756U,
		// Token: 0x04005773 RID: 22387
		MoveSplineSetFlightSpeed = 11755U,
		// Token: 0x04005774 RID: 22388
		MoveSplineSetFlying = 11817U,
		// Token: 0x04005775 RID: 22389
		MoveSplineSetHover = 11809U,
		// Token: 0x04005776 RID: 22390
		MoveSplineSetLandWalk = 11812U,
		// Token: 0x04005777 RID: 22391
		MoveSplineSetNormalFall = 11808U,
		// Token: 0x04005778 RID: 22392
		MoveSplineSetPitchRate = 11759U,
		// Token: 0x04005779 RID: 22393
		MoveSplineSetRunBackSpeed = 11752U,
		// Token: 0x0400577A RID: 22394
		MoveSplineSetRunMode = 11815U,
		// Token: 0x0400577B RID: 22395
		MoveSplineSetRunSpeed = 11751U,
		// Token: 0x0400577C RID: 22396
		MoveSplineSetSwimBackSpeed = 11754U,
		// Token: 0x0400577D RID: 22397
		MoveSplineSetSwimSpeed = 11753U,
		// Token: 0x0400577E RID: 22398
		MoveSplineSetTurnRate = 11758U,
		// Token: 0x0400577F RID: 22399
		MoveSplineSetWalkMode = 11816U,
		// Token: 0x04005780 RID: 22400
		MoveSplineSetWalkSpeed = 11757U,
		// Token: 0x04005781 RID: 22401
		MoveSplineSetWaterWalk = 11811U,
		// Token: 0x04005782 RID: 22402
		MoveSplineStartSwim = 11813U,
		// Token: 0x04005783 RID: 22403
		MoveSplineStopSwim,
		// Token: 0x04005784 RID: 22404
		MoveSplineUnroot = 11802U,
		// Token: 0x04005785 RID: 22405
		MoveSplineUnsetFlying = 11818U,
		// Token: 0x04005786 RID: 22406
		MoveSplineUnsetHover = 11810U,
		// Token: 0x04005787 RID: 22407
		MoveTeleport = 11780U,
		// Token: 0x04005788 RID: 22408
		MoveUnroot = 11770U,
		// Token: 0x04005789 RID: 22409
		MoveUnsetCanAdvFly = 11829U,
		// Token: 0x0400578A RID: 22410
		MoveUnsetCanFly = 11782U,
		// Token: 0x0400578B RID: 22411
		MoveUnsetCanTurnWhileFalling = 11784U,
		// Token: 0x0400578C RID: 22412
		MoveUnsetHovering = 11778U,
		// Token: 0x0400578D RID: 22413
		MoveUnsetIgnoreMovementForces = 11786U,
		// Token: 0x0400578E RID: 22414
		MoveUpdate = 11744U,
		// Token: 0x0400578F RID: 22415
		MoveUpdateAddImpulse = 11827U,
		// Token: 0x04005790 RID: 22416
		MoveUpdateApplyInertia = 11824U,
		// Token: 0x04005791 RID: 22417
		MoveUpdateApplyMovementForce = 11748U,
		// Token: 0x04005792 RID: 22418
		MoveUpdateCollisionHeight = 11743U,
		// Token: 0x04005793 RID: 22419
		MoveUpdateFlightBackSpeed = 11740U,
		// Token: 0x04005794 RID: 22420
		MoveUpdateFlightSpeed = 11739U,
		// Token: 0x04005795 RID: 22421
		MoveUpdateKnockBack = 11746U,
		// Token: 0x04005796 RID: 22422
		MoveUpdateModMovementForceMagnitude,
		// Token: 0x04005797 RID: 22423
		MoveUpdatePitchRate = 11742U,
		// Token: 0x04005798 RID: 22424
		MoveUpdateRemoveInertia = 11825U,
		// Token: 0x04005799 RID: 22425
		MoveUpdateRemoveMovementForce = 11749U,
		// Token: 0x0400579A RID: 22426
		MoveUpdateRunBackSpeed = 11735U,
		// Token: 0x0400579B RID: 22427
		MoveUpdateRunSpeed = 11734U,
		// Token: 0x0400579C RID: 22428
		MoveUpdateSwimBackSpeed = 11738U,
		// Token: 0x0400579D RID: 22429
		MoveUpdateSwimSpeed = 11737U,
		// Token: 0x0400579E RID: 22430
		MoveUpdateTeleport = 11745U,
		// Token: 0x0400579F RID: 22431
		MoveUpdateTurnRate = 11741U,
		// Token: 0x040057A0 RID: 22432
		MoveUpdateWalkSpeed = 11736U,
		// Token: 0x040057A1 RID: 22433
		MultiFloorLeaveFloor = 10202U,
		// Token: 0x040057A2 RID: 22434
		MultiFloorNewFloor = 10201U,
		// Token: 0x040057A3 RID: 22435
		MythicPlusAllMapStats = 9739U,
		// Token: 0x040057A4 RID: 22436
		MythicPlusCurrentAffixes = 9741U,
		// Token: 0x040057A5 RID: 22437
		MythicPlusNewWeekRecord = 9744U,
		// Token: 0x040057A6 RID: 22438
		MythicPlusSeasonData = 9740U,
		// Token: 0x040057A7 RID: 22439
		NeutralPlayerFactionSelectResult = 9691U,
		// Token: 0x040057A8 RID: 22440
		NewTaxiPath = 9852U,
		// Token: 0x040057A9 RID: 22441
		NewWorld = 9624U,
		// Token: 0x040057AA RID: 22442
		NotifyDestLocSpellCast = 11334U,
		// Token: 0x040057AB RID: 22443
		NotifyMissileTrajectoryCollision = 9896U,
		// Token: 0x040057AC RID: 22444
		NotifyMoney = 9629U,
		// Token: 0x040057AD RID: 22445
		NotifyReceivedMail = 9786U,
		// Token: 0x040057AE RID: 22446
		NpcInteractionOpenResult = 10379U,
		// Token: 0x040057AF RID: 22447
		OfferPetitionError = 9907U,
		// Token: 0x040057B0 RID: 22448
		OnCancelExpectedRideVehicleAura = 9953U,
		// Token: 0x040057B1 RID: 22449
		OnMonsterMove = 11732U,
		// Token: 0x040057B2 RID: 22450
		OpenArtifactForge = 10139U,
		// Token: 0x040057B3 RID: 22451
		OpenContainer = 11686U,
		// Token: 0x040057B4 RID: 22452
		OpenLfgDungeonFinder = 10801U,
		// Token: 0x040057B5 RID: 22453
		OpenShipmentNpcResult = 10131U,
		// Token: 0x040057B6 RID: 22454
		OverrideLight = 9912U,
		// Token: 0x040057B7 RID: 22455
		PageText = 10004U,
		// Token: 0x040057B8 RID: 22456
		PartyCommandResult = 10125U,
		// Token: 0x040057B9 RID: 22457
		PartyInvite = 9661U,
		// Token: 0x040057BA RID: 22458
		PartyKillLog = 10068U,
		// Token: 0x040057BB RID: 22459
		PartyMemberFullState = 10067U,
		// Token: 0x040057BC RID: 22460
		PartyMemberPartialState = 10066U,
		// Token: 0x040057BD RID: 22461
		PartyNotifyLfgLeaderChange = 10353U,
		// Token: 0x040057BE RID: 22462
		PartyUpdate = 9716U,
		// Token: 0x040057BF RID: 22463
		PastTimeEvents = 9666U,
		// Token: 0x040057C0 RID: 22464
		PauseMirrorTimer = 9995U,
		// Token: 0x040057C1 RID: 22465
		PendingRaidLock = 9971U,
		// Token: 0x040057C2 RID: 22466
		PerksProgramActivityComplete = 10375U,
		// Token: 0x040057C3 RID: 22467
		PerksProgramActivityUpdate = 10371U,
		// Token: 0x040057C4 RID: 22468
		PerksProgramDisabled = 10376U,
		// Token: 0x040057C5 RID: 22469
		PerksProgramResult = 10372U,
		// Token: 0x040057C6 RID: 22470
		PerksProgramVendorUpdate = 10370U,
		// Token: 0x040057C7 RID: 22471
		PetitionAlreadySigned = 9635U,
		// Token: 0x040057C8 RID: 22472
		PetitionRenameGuildResponse = 10746U,
		// Token: 0x040057C9 RID: 22473
		PetitionShowList = 9915U,
		// Token: 0x040057CA RID: 22474
		PetitionShowSignatures,
		// Token: 0x040057CB RID: 22475
		PetitionSignResults = 10054U,
		// Token: 0x040057CC RID: 22476
		PetActionFeedback = 10051U,
		// Token: 0x040057CD RID: 22477
		PetActionSound = 9886U,
		// Token: 0x040057CE RID: 22478
		PetAdded = 9621U,
		// Token: 0x040057CF RID: 22479
		PetBattleChatRestricted = 9730U,
		// Token: 0x040057D0 RID: 22480
		PetBattleDebugQueueDumpResponse = 9843U,
		// Token: 0x040057D1 RID: 22481
		PetBattleFinalizeLocation = 9723U,
		// Token: 0x040057D2 RID: 22482
		PetBattleFinalRound = 9728U,
		// Token: 0x040057D3 RID: 22483
		PetBattleFinished,
		// Token: 0x040057D4 RID: 22484
		PetBattleFirstRound = 9725U,
		// Token: 0x040057D5 RID: 22485
		PetBattleInitialUpdate = 9724U,
		// Token: 0x040057D6 RID: 22486
		PetBattleMaxGameLengthWarning = 9731U,
		// Token: 0x040057D7 RID: 22487
		PetBattlePvpChallenge = 9722U,
		// Token: 0x040057D8 RID: 22488
		PetBattleQueueProposeMatch = 9783U,
		// Token: 0x040057D9 RID: 22489
		PetBattleQueueStatus,
		// Token: 0x040057DA RID: 22490
		PetBattleReplacementsMade = 9727U,
		// Token: 0x040057DB RID: 22491
		PetBattleRequestFailed = 9721U,
		// Token: 0x040057DC RID: 22492
		PetBattleRoundResult = 9726U,
		// Token: 0x040057DD RID: 22493
		PetBattleSlotUpdates = 9707U,
		// Token: 0x040057DE RID: 22494
		PetCastFailed = 11355U,
		// Token: 0x040057DF RID: 22495
		PetClearSpells = 11300U,
		// Token: 0x040057E0 RID: 22496
		PetDismissSound = 9887U,
		// Token: 0x040057E1 RID: 22497
		PetGodMode = 9849U,
		// Token: 0x040057E2 RID: 22498
		PetGuids = 9983U,
		// Token: 0x040057E3 RID: 22499
		PetLearnedSpells = 11346U,
		// Token: 0x040057E4 RID: 22500
		PetMode = 9611U,
		// Token: 0x040057E5 RID: 22501
		PetNameInvalid = 9920U,
		// Token: 0x040057E6 RID: 22502
		PetNewlyTamed = 9609U,
		// Token: 0x040057E7 RID: 22503
		PetSlotUpdated,
		// Token: 0x040057E8 RID: 22504
		PetSpellsMessage = 11301U,
		// Token: 0x040057E9 RID: 22505
		PetStableList = 9622U,
		// Token: 0x040057EA RID: 22506
		PetStableResult,
		// Token: 0x040057EB RID: 22507
		PetTameFailure = 9904U,
		// Token: 0x040057EC RID: 22508
		PetUnlearnedSpells = 11347U,
		// Token: 0x040057ED RID: 22509
		PhaseShiftChange = 9592U,
		// Token: 0x040057EE RID: 22510
		PlayedTime = 9937U,
		// Token: 0x040057EF RID: 22511
		PlayerAzeriteItemEquippedStatusChanged = 12308U,
		// Token: 0x040057F0 RID: 22512
		PlayerAzeriteItemGains = 12307U,
		// Token: 0x040057F1 RID: 22513
		PlayerBonusRollFailed = 12310U,
		// Token: 0x040057F2 RID: 22514
		PlayerBound = 12280U,
		// Token: 0x040057F3 RID: 22515
		PlayerChoiceClear = 12286U,
		// Token: 0x040057F4 RID: 22516
		PlayerChoiceDisplayError = 12285U,
		// Token: 0x040057F5 RID: 22517
		PlayerConditionResult = 12298U,
		// Token: 0x040057F6 RID: 22518
		PlayerIsAdventureMapPoiValid = 12297U,
		// Token: 0x040057F7 RID: 22519
		PlayerOpenSubscriptionInterstitial = 12302U,
		// Token: 0x040057F8 RID: 22520
		PlayerSaveGuildEmblem = 10745U,
		// Token: 0x040057F9 RID: 22521
		PlayerShowGenericWidgetDisplay = 12318U,
		// Token: 0x040057FA RID: 22522
		PlayerShowUiEventToast = 12313U,
		// Token: 0x040057FB RID: 22523
		PlayerSkinned = 12294U,
		// Token: 0x040057FC RID: 22524
		PlayerTutorialHighlightSpell = 12301U,
		// Token: 0x040057FD RID: 22525
		PlayerTutorialUnhighlightSpell = 12300U,
		// Token: 0x040057FE RID: 22526
		PlayMusic = 10083U,
		// Token: 0x040057FF RID: 22527
		PlayObjectSound,
		// Token: 0x04005800 RID: 22528
		PlayOneShotAnimKit = 10027U,
		// Token: 0x04005801 RID: 22529
		PlayOrphanSpellVisual = 11338U,
		// Token: 0x04005802 RID: 22530
		PlayScene = 9780U,
		// Token: 0x04005803 RID: 22531
		PlaySound = 10082U,
		// Token: 0x04005804 RID: 22532
		PlaySpeakerbotSound = 10085U,
		// Token: 0x04005805 RID: 22533
		PlaySpellVisual = 11336U,
		// Token: 0x04005806 RID: 22534
		PlaySpellVisualKit = 11340U,
		// Token: 0x04005807 RID: 22535
		PlayTimeWarning = 9977U,
		// Token: 0x04005808 RID: 22536
		Pong = 12366U,
		// Token: 0x04005809 RID: 22537
		PowerUpdate = 9934U,
		// Token: 0x0400580A RID: 22538
		PreloadChildMap = 9593U,
		// Token: 0x0400580B RID: 22539
		PreloadWorld = 9625U,
		// Token: 0x0400580C RID: 22540
		PrepopulateNameCache = 10308U,
		// Token: 0x0400580D RID: 22541
		PreRessurect = 10081U,
		// Token: 0x0400580E RID: 22542
		PrintNotification = 9674U,
		// Token: 0x0400580F RID: 22543
		ProcResist = 10069U,
		// Token: 0x04005810 RID: 22544
		ProfessionGossip = 10234U,
		// Token: 0x04005811 RID: 22545
		PushSpellToActionBar = 11348U,
		// Token: 0x04005812 RID: 22546
		PvpCredit = 10565U,
		// Token: 0x04005813 RID: 22547
		PvpMatchComplete = 10575U,
		// Token: 0x04005814 RID: 22548
		PvpMatchInitialize,
		// Token: 0x04005815 RID: 22549
		PvpMatchStart = 10574U,
		// Token: 0x04005816 RID: 22550
		PvpMatchStatistics = 10546U,
		// Token: 0x04005817 RID: 22551
		PvpOptionsEnabled = 10548U,
		// Token: 0x04005818 RID: 22552
		PvpTierRecord = 10366U,
		// Token: 0x04005819 RID: 22553
		QueryBattlePetNameResponse = 10522U,
		// Token: 0x0400581A RID: 22554
		QueryCreatureResponse = 10516U,
		// Token: 0x0400581B RID: 22555
		QueryGameObjectResponse,
		// Token: 0x0400581C RID: 22556
		QueryGarrisonPetNameResponse = 10655U,
		// Token: 0x0400581D RID: 22557
		QueryGuildFollowInfoResponse = 10727U,
		// Token: 0x0400581E RID: 22558
		QueryGuildInfoResponse = 10725U,
		// Token: 0x0400581F RID: 22559
		QueryItemTextResponse = 10526U,
		// Token: 0x04005820 RID: 22560
		QueryNpcTextResponse = 10518U,
		// Token: 0x04005821 RID: 22561
		QueryPageTextResponse,
		// Token: 0x04005822 RID: 22562
		QueryPetitionResponse = 10523U,
		// Token: 0x04005823 RID: 22563
		QueryPetNameResponse = 10521U,
		// Token: 0x04005824 RID: 22564
		QueryPlayerNamesResponse = 12315U,
		// Token: 0x04005825 RID: 22565
		QueryPlayerNameByCommunityIdResponse = 12290U,
		// Token: 0x04005826 RID: 22566
		QueryQuestInfoResponse = 10902U,
		// Token: 0x04005827 RID: 22567
		QueryRealmGuildMasterInfoResponse = 10726U,
		// Token: 0x04005828 RID: 22568
		QueryTimeResponse = 9951U,
		// Token: 0x04005829 RID: 22569
		QuestCompletionNpcResponse = 10881U,
		// Token: 0x0400582A RID: 22570
		QuestConfirmAccept = 10895U,
		// Token: 0x0400582B RID: 22571
		QuestForceRemoved = 10908U,
		// Token: 0x0400582C RID: 22572
		QuestGiverInvalidQuest = 10885U,
		// Token: 0x0400582D RID: 22573
		QuestGiverOfferRewardMessage = 10900U,
		// Token: 0x0400582E RID: 22574
		QuestGiverQuestComplete = 10883U,
		// Token: 0x0400582F RID: 22575
		QuestGiverQuestDetails = 10898U,
		// Token: 0x04005830 RID: 22576
		QuestGiverQuestFailed = 10886U,
		// Token: 0x04005831 RID: 22577
		QuestGiverQuestListMessage = 10906U,
		// Token: 0x04005832 RID: 22578
		QuestGiverRequestItems = 10899U,
		// Token: 0x04005833 RID: 22579
		QuestGiverStatus = 10907U,
		// Token: 0x04005834 RID: 22580
		QuestGiverStatusMultiple = 10897U,
		// Token: 0x04005835 RID: 22581
		QuestItemUsabilityResponse = 10882U,
		// Token: 0x04005836 RID: 22582
		QuestLogFull = 10887U,
		// Token: 0x04005837 RID: 22583
		QuestNonLogUpdateComplete,
		// Token: 0x04005838 RID: 22584
		QuestPoiQueryResponse = 10909U,
		// Token: 0x04005839 RID: 22585
		QuestPoiUpdateResponse = 10911U,
		// Token: 0x0400583A RID: 22586
		QuestPushResult = 10896U,
		// Token: 0x0400583B RID: 22587
		QuestSessionInfoResponse = 10343U,
		// Token: 0x0400583C RID: 22588
		QuestSessionReadyCheck = 10325U,
		// Token: 0x0400583D RID: 22589
		QuestSessionReadyCheckResponse,
		// Token: 0x0400583E RID: 22590
		QuestSessionResult = 10324U,
		// Token: 0x0400583F RID: 22591
		QuestUpdateAddCredit = 10892U,
		// Token: 0x04005840 RID: 22592
		QuestUpdateAddCreditSimple,
		// Token: 0x04005841 RID: 22593
		QuestUpdateAddPvpCredit,
		// Token: 0x04005842 RID: 22594
		QuestUpdateComplete = 10889U,
		// Token: 0x04005843 RID: 22595
		QuestUpdateFailed,
		// Token: 0x04005844 RID: 22596
		QuestUpdateFailedTimer,
		// Token: 0x04005845 RID: 22597
		QueueSummaryUpdate = 10253U,
		// Token: 0x04005846 RID: 22598
		RafAccountInfo = 10322U,
		// Token: 0x04005847 RID: 22599
		RafActivityStateChanged = 10339U,
		// Token: 0x04005848 RID: 22600
		RaidDifficultySet = 10149U,
		// Token: 0x04005849 RID: 22601
		RaidGroupOnly = 10151U,
		// Token: 0x0400584A RID: 22602
		RaidInstanceMessage = 11188U,
		// Token: 0x0400584B RID: 22603
		RaidMarkersChanged = 9636U,
		// Token: 0x0400584C RID: 22604
		RandomRoll = 9774U,
		// Token: 0x0400584D RID: 22605
		RatedPvpInfo = 10545U,
		// Token: 0x0400584E RID: 22606
		ReadyCheckCompleted = 9720U,
		// Token: 0x0400584F RID: 22607
		ReadyCheckResponse = 9719U,
		// Token: 0x04005850 RID: 22608
		ReadyCheckStarted = 9718U,
		// Token: 0x04005851 RID: 22609
		ReadItemResultFailed = 10145U,
		// Token: 0x04005852 RID: 22610
		ReadItemResultOk = 10136U,
		// Token: 0x04005853 RID: 22611
		RealmLookupInfo = 10181U,
		// Token: 0x04005854 RID: 22612
		RealmQueryResponse = 10515U,
		// Token: 0x04005855 RID: 22613
		ReattachResurrect = 10053U,
		// Token: 0x04005856 RID: 22614
		RecraftItemResult = 10403U,
		// Token: 0x04005857 RID: 22615
		RecruitAFriendFailure = 9917U,
		// Token: 0x04005858 RID: 22616
		RefreshComponent = 9807U,
		// Token: 0x04005859 RID: 22617
		RefreshSpellHistory = 11308U,
		// Token: 0x0400585A RID: 22618
		RemoveItemPassive = 9644U,
		// Token: 0x0400585B RID: 22619
		RemoveSpellFromActionBar = 11349U,
		// Token: 0x0400585C RID: 22620
		ReplaceTrophyResponse = 10173U,
		// Token: 0x0400585D RID: 22621
		ReportPvpPlayerAfkResult = 12289U,
		// Token: 0x0400585E RID: 22622
		RequestCemeteryListResponse = 9617U,
		// Token: 0x0400585F RID: 22623
		RequestPvpRewardsResponse = 10549U,
		// Token: 0x04005860 RID: 22624
		RequestScheduledPvpInfoResponse,
		// Token: 0x04005861 RID: 22625
		ResearchComplete = 9607U,
		// Token: 0x04005862 RID: 22626
		ResetCompressionContext = 12367U,
		// Token: 0x04005863 RID: 22627
		ResetFailedNotify = 9908U,
		// Token: 0x04005864 RID: 22628
		ResetLastLoadedConfigCvars = 10409U,
		// Token: 0x04005865 RID: 22629
		ResetQuestPoi = 10912U,
		// Token: 0x04005866 RID: 22630
		ResetRangedCombatTimer = 10564U,
		// Token: 0x04005867 RID: 22631
		ResetWeeklyCurrency = 9589U,
		// Token: 0x04005868 RID: 22632
		RespecWipeConfirm = 9745U,
		// Token: 0x04005869 RID: 22633
		RespondInspectAchievements = 9586U,
		// Token: 0x0400586A RID: 22634
		ResponsePerkPendingRewards = 10373U,
		// Token: 0x0400586B RID: 22635
		ResponsePerkRecentPurchases,
		// Token: 0x0400586C RID: 22636
		RestartGlobalCooldown = 11364U,
		// Token: 0x0400586D RID: 22637
		RestrictedAccountWarning = 9657U,
		// Token: 0x0400586E RID: 22638
		ResumeCast = 11326U,
		// Token: 0x0400586F RID: 22639
		ResumeCastBar = 11329U,
		// Token: 0x04005870 RID: 22640
		ResumeComms = 12363U,
		// Token: 0x04005871 RID: 22641
		ResumeToken = 9642U,
		// Token: 0x04005872 RID: 22642
		ResurrectRequest = 9598U,
		// Token: 0x04005873 RID: 22643
		ResyncRunes = 11362U,
		// Token: 0x04005874 RID: 22644
		ReturningPlayerPrompt = 10144U,
		// Token: 0x04005875 RID: 22645
		ReturnApplicantList = 10312U,
		// Token: 0x04005876 RID: 22646
		ReturnRecruitingClubs = 10311U,
		// Token: 0x04005877 RID: 22647
		RoleChangedInform = 9613U,
		// Token: 0x04005878 RID: 22648
		RoleChosen = 10809U,
		// Token: 0x04005879 RID: 22649
		RolePollInform = 9614U,
		// Token: 0x0400587A RID: 22650
		RuneforgeLegendaryCraftingOpenNpc = 10233U,
		// Token: 0x0400587B RID: 22651
		RuneRegenDebug = 9654U,
		// Token: 0x0400587C RID: 22652
		ScenarioCompleted = 10215U,
		// Token: 0x0400587D RID: 22653
		ScenarioPois = 9777U,
		// Token: 0x0400587E RID: 22654
		ScenarioProgressUpdate = 9770U,
		// Token: 0x0400587F RID: 22655
		ScenarioShowCriteria = 10237U,
		// Token: 0x04005880 RID: 22656
		ScenarioState = 9769U,
		// Token: 0x04005881 RID: 22657
		ScenarioUiUpdate = 10236U,
		// Token: 0x04005882 RID: 22658
		ScenarioVacate = 10146U,
		// Token: 0x04005883 RID: 22659
		SceneObjectEvent = 9697U,
		// Token: 0x04005884 RID: 22660
		SceneObjectPetBattleFinalRound = 9702U,
		// Token: 0x04005885 RID: 22661
		SceneObjectPetBattleFinished,
		// Token: 0x04005886 RID: 22662
		SceneObjectPetBattleFirstRound = 9699U,
		// Token: 0x04005887 RID: 22663
		SceneObjectPetBattleInitialUpdate = 9698U,
		// Token: 0x04005888 RID: 22664
		SceneObjectPetBattleReplacementsMade = 9701U,
		// Token: 0x04005889 RID: 22665
		SceneObjectPetBattleRoundResult = 9700U,
		// Token: 0x0400588A RID: 22666
		ScriptCast = 11353U,
		// Token: 0x0400588B RID: 22667
		SeasonInfo = 9665U,
		// Token: 0x0400588C RID: 22668
		SellResponse = 9921U,
		// Token: 0x0400588D RID: 22669
		SendItemPassives = 9645U,
		// Token: 0x0400588E RID: 22670
		SendKnownSpells = 11306U,
		// Token: 0x0400588F RID: 22671
		SendRaidTargetUpdateAll = 9772U,
		// Token: 0x04005890 RID: 22672
		SendRaidTargetUpdateSingle,
		// Token: 0x04005891 RID: 22673
		SendSpellCharges = 11309U,
		// Token: 0x04005892 RID: 22674
		SendSpellHistory = 11307U,
		// Token: 0x04005893 RID: 22675
		SendUnlearnSpells = 11310U,
		// Token: 0x04005894 RID: 22676
		ServerFirstAchievements = 9804U,
		// Token: 0x04005895 RID: 22677
		ServerTime = 9856U,
		// Token: 0x04005896 RID: 22678
		ServerTimeOffset = 9999U,
		// Token: 0x04005897 RID: 22679
		SetupCurrency = 9587U,
		// Token: 0x04005898 RID: 22680
		SetupResearchHistory = 9606U,
		// Token: 0x04005899 RID: 22681
		SetAiAnimKit = 10026U,
		// Token: 0x0400589A RID: 22682
		SetAllTaskProgress = 10118U,
		// Token: 0x0400589B RID: 22683
		SetAnimTier = 10030U,
		// Token: 0x0400589C RID: 22684
		SetChrUpgradeTier = 9694U,
		// Token: 0x0400589D RID: 22685
		SetCurrency = 9588U,
		// Token: 0x0400589E RID: 22686
		SetDfFastLaunchResult = 10798U,
		// Token: 0x0400589F RID: 22687
		SetDungeonDifficulty = 9890U,
		// Token: 0x040058A0 RID: 22688
		SetFactionAtWar = 9979U,
		// Token: 0x040058A1 RID: 22689
		SetFactionNotVisible = 10021U,
		// Token: 0x040058A2 RID: 22690
		SetFactionStanding,
		// Token: 0x040058A3 RID: 22691
		SetFactionVisible = 10020U,
		// Token: 0x040058A4 RID: 22692
		SetFlatSpellModifier = 11321U,
		// Token: 0x040058A5 RID: 22693
		SetForcedReactions = 10008U,
		// Token: 0x040058A6 RID: 22694
		SetItemPurchaseData = 9631U,
		// Token: 0x040058A7 RID: 22695
		SetLootMethodFailed = 10187U,
		// Token: 0x040058A8 RID: 22696
		SetMaxWeeklyQuantity = 9634U,
		// Token: 0x040058A9 RID: 22697
		SetMeleeAnimKit = 10029U,
		// Token: 0x040058AA RID: 22698
		SetMovementAnimKit = 10028U,
		// Token: 0x040058AB RID: 22699
		SetPctSpellModifier = 11322U,
		// Token: 0x040058AC RID: 22700
		SetPetSpecialization = 9763U,
		// Token: 0x040058AD RID: 22701
		SetPlayerDeclinedNamesResult = 12291U,
		// Token: 0x040058AE RID: 22702
		SetPlayHoverAnim = 9658U,
		// Token: 0x040058AF RID: 22703
		SetProficiency = 10031U,
		// Token: 0x040058B0 RID: 22704
		SetQuestReplayCooldownOverride = 10331U,
		// Token: 0x040058B1 RID: 22705
		SetShipmentReadyResponse = 10648U,
		// Token: 0x040058B2 RID: 22706
		SetSpellCharges = 11305U,
		// Token: 0x040058B3 RID: 22707
		SetTaskComplete = 10119U,
		// Token: 0x040058B4 RID: 22708
		SetTimeZoneInformation = 9845U,
		// Token: 0x040058B5 RID: 22709
		SetVehicleRecId = 9970U,
		// Token: 0x040058B6 RID: 22710
		ShadowlandsCapacitanceUpdate = 10378U,
		// Token: 0x040058B7 RID: 22711
		ShipmentFactionUpdateResult = 10649U,
		// Token: 0x040058B8 RID: 22712
		ShowNeutralPlayerFactionSelectUi = 9690U,
		// Token: 0x040058B9 RID: 22713
		ShowQuestCompletionText = 10901U,
		// Token: 0x040058BA RID: 22714
		ShowTaxiNodes = 9929U,
		// Token: 0x040058BB RID: 22715
		ShowTradeSkillResponse = 10090U,
		// Token: 0x040058BC RID: 22716
		SocialContractRequestResponse = 10387U,
		// Token: 0x040058BD RID: 22717
		SocketGemsFailure = 10018U,
		// Token: 0x040058BE RID: 22718
		SocketGemsSuccess = 10017U,
		// Token: 0x040058BF RID: 22719
		SpecialMountAnim = 9885U,
		// Token: 0x040058C0 RID: 22720
		SpecInvoluntarilyChanged = 10003U,
		// Token: 0x040058C1 RID: 22721
		SpellAbsorbLog = 11295U,
		// Token: 0x040058C2 RID: 22722
		SpellCategoryCooldown = 11287U,
		// Token: 0x040058C3 RID: 22723
		SpellChannelStart = 11316U,
		// Token: 0x040058C4 RID: 22724
		SpellChannelUpdate,
		// Token: 0x040058C5 RID: 22725
		SpellCooldown = 11285U,
		// Token: 0x040058C6 RID: 22726
		SpellDamageShield = 11313U,
		// Token: 0x040058C7 RID: 22727
		SpellDelayed = 11330U,
		// Token: 0x040058C8 RID: 22728
		SpellDispellLog = 11290U,
		// Token: 0x040058C9 RID: 22729
		SpellEmpowerSetStage = 11320U,
		// Token: 0x040058CA RID: 22730
		SpellEmpowerStart = 11318U,
		// Token: 0x040058CB RID: 22731
		SpellEmpowerUpdate,
		// Token: 0x040058CC RID: 22732
		SpellEnergizeLog = 11292U,
		// Token: 0x040058CD RID: 22733
		SpellExecuteLog = 11331U,
		// Token: 0x040058CE RID: 22734
		SpellFailedOther = 11352U,
		// Token: 0x040058CF RID: 22735
		SpellFailure = 11350U,
		// Token: 0x040058D0 RID: 22736
		SpellFailureMessage = 11357U,
		// Token: 0x040058D1 RID: 22737
		SpellGo = 11324U,
		// Token: 0x040058D2 RID: 22738
		SpellHealAbsorbLog = 11294U,
		// Token: 0x040058D3 RID: 22739
		SpellHealLog = 11293U,
		// Token: 0x040058D4 RID: 22740
		SpellInstakillLog = 11315U,
		// Token: 0x040058D5 RID: 22741
		SpellInterruptLog = 11296U,
		// Token: 0x040058D6 RID: 22742
		SpellMissLog = 11332U,
		// Token: 0x040058D7 RID: 22743
		SpellNonMeleeDamageLog = 11314U,
		// Token: 0x040058D8 RID: 22744
		SpellOrDamageImmune = 11311U,
		// Token: 0x040058D9 RID: 22745
		SpellPeriodicAuraLog = 11291U,
		// Token: 0x040058DA RID: 22746
		SpellPrepare = 11323U,
		// Token: 0x040058DB RID: 22747
		SpellStart = 11325U,
		// Token: 0x040058DC RID: 22748
		SpellVisualLoadScreen = 9676U,
		// Token: 0x040058DD RID: 22749
		SplashScreenShowLatest = 10349U,
		// Token: 0x040058DE RID: 22750
		StandStateUpdate = 10007U,
		// Token: 0x040058DF RID: 22751
		StarterBuildActivateFailed = 9682U,
		// Token: 0x040058E0 RID: 22752
		StartElapsedTimer = 9732U,
		// Token: 0x040058E1 RID: 22753
		StartElapsedTimers = 9734U,
		// Token: 0x040058E2 RID: 22754
		StartLightningStorm = 9893U,
		// Token: 0x040058E3 RID: 22755
		StartLootRoll = 9755U,
		// Token: 0x040058E4 RID: 22756
		StartMirrorTimer = 9994U,
		// Token: 0x040058E5 RID: 22757
		StartTimer = 9638U,
		// Token: 0x040058E6 RID: 22758
		StopElapsedTimer = 9733U,
		// Token: 0x040058E7 RID: 22759
		StopMirrorTimer = 9996U,
		// Token: 0x040058E8 RID: 22760
		StopSpeakerbotSound = 10086U,
		// Token: 0x040058E9 RID: 22761
		StopTimer = 9639U,
		// Token: 0x040058EA RID: 22762
		StreamingMovies = 9637U,
		// Token: 0x040058EB RID: 22763
		SuggestInviteInform = 10126U,
		// Token: 0x040058EC RID: 22764
		SummonCancel = 9902U,
		// Token: 0x040058ED RID: 22765
		SummonRaidMemberValidateFailed = 9615U,
		// Token: 0x040058EE RID: 22766
		SummonRequest = 10012U,
		// Token: 0x040058EF RID: 22767
		SupercededSpells = 11343U,
		// Token: 0x040058F0 RID: 22768
		SuspendComms = 12362U,
		// Token: 0x040058F1 RID: 22769
		SuspendToken = 9641U,
		// Token: 0x040058F2 RID: 22770
		SyncWowEntitlements = 10341U,
		// Token: 0x040058F3 RID: 22771
		TalentsInvoluntarilyReset = 10002U,
		// Token: 0x040058F4 RID: 22772
		TaxiNodeStatus = 9850U,
		// Token: 0x040058F5 RID: 22773
		TextEmote = 9848U,
		// Token: 0x040058F6 RID: 22774
		ThreatClear = 9944U,
		// Token: 0x040058F7 RID: 22775
		ThreatRemove = 9943U,
		// Token: 0x040058F8 RID: 22776
		ThreatUpdate = 9942U,
		// Token: 0x040058F9 RID: 22777
		TimeAdjustment = 11731U,
		// Token: 0x040058FA RID: 22778
		TimeSyncRequest = 11730U,
		// Token: 0x040058FB RID: 22779
		TitleEarned = 9939U,
		// Token: 0x040058FC RID: 22780
		TitleLost,
		// Token: 0x040058FD RID: 22781
		TotemCreated = 9924U,
		// Token: 0x040058FE RID: 22782
		TotemDurationChanged,
		// Token: 0x040058FF RID: 22783
		TotemMoved,
		// Token: 0x04005900 RID: 22784
		TradeStatus = 9602U,
		// Token: 0x04005901 RID: 22785
		TradeUpdated = 9601U,
		// Token: 0x04005902 RID: 22786
		TrainerBuyFailed = 9947U,
		// Token: 0x04005903 RID: 22787
		TrainerList = 9946U,
		// Token: 0x04005904 RID: 22788
		TraitConfigCommitFailed = 9681U,
		// Token: 0x04005905 RID: 22789
		TransferAborted = 9982U,
		// Token: 0x04005906 RID: 22790
		TransferPending = 9677U,
		// Token: 0x04005907 RID: 22791
		TreasurePickerResponse = 10527U,
		// Token: 0x04005908 RID: 22792
		TriggerCinematic = 10179U,
		// Token: 0x04005909 RID: 22793
		TriggerMovie = 9927U,
		// Token: 0x0400590A RID: 22794
		TurnInPetitionResult = 10056U,
		// Token: 0x0400590B RID: 22795
		TutorialFlags = 10166U,
		// Token: 0x0400590C RID: 22796
		TwitterStatus = 12355U,
		// Token: 0x0400590D RID: 22797
		UiHealingRangeModified = 10046U,
		// Token: 0x0400590E RID: 22798
		UiMapQuestLinesResponse = 10914U,
		// Token: 0x0400590F RID: 22799
		UndeleteCharacterResponse = 10182U,
		// Token: 0x04005910 RID: 22800
		UndeleteCooldownStatusResponse,
		// Token: 0x04005911 RID: 22801
		UnlearnedSpells = 11345U,
		// Token: 0x04005912 RID: 22802
		UnloadChildMap = 9594U,
		// Token: 0x04005913 RID: 22803
		UpdateAadcStatusResponse = 10367U,
		// Token: 0x04005914 RID: 22804
		UpdateAccountData = 9988U,
		// Token: 0x04005915 RID: 22805
		UpdateActionButtons = 9695U,
		// Token: 0x04005916 RID: 22806
		UpdateBnetSessionKey = 10270U,
		// Token: 0x04005917 RID: 22807
		UpdateCapturePoint = 10537U,
		// Token: 0x04005918 RID: 22808
		UpdateCelestialBody = 10266U,
		// Token: 0x04005919 RID: 22809
		UpdateCharacterFlags = 10172U,
		// Token: 0x0400591A RID: 22810
		UpdateChargeCategoryCooldown = 10080U,
		// Token: 0x0400591B RID: 22811
		UpdateCooldown = 10079U,
		// Token: 0x0400591C RID: 22812
		UpdateCraftingNpcRecipes = 10646U,
		// Token: 0x0400591D RID: 22813
		UpdateDailyMissionCounter = 10623U,
		// Token: 0x0400591E RID: 22814
		UpdateExpansionLevel = 9796U,
		// Token: 0x0400591F RID: 22815
		UpdateGameTimeState = 10273U,
		// Token: 0x04005920 RID: 22816
		UpdateInstanceOwnership = 9895U,
		// Token: 0x04005921 RID: 22817
		UpdateLastInstance = 9862U,
		// Token: 0x04005922 RID: 22818
		UpdateObject = 10180U,
		// Token: 0x04005923 RID: 22819
		UpdatePrimarySpec = 9687U,
		// Token: 0x04005924 RID: 22820
		UpdateRecentPlayerGuids = 9717U,
		// Token: 0x04005925 RID: 22821
		UpdateTalentData = 9686U,
		// Token: 0x04005926 RID: 22822
		UpdateTaskProgress = 10117U,
		// Token: 0x04005927 RID: 22823
		UpdateWeeklySpellUsage = 11289U,
		// Token: 0x04005928 RID: 22824
		UpdateWorldState = 10050U,
		// Token: 0x04005929 RID: 22825
		UserlistAdd = 11193U,
		// Token: 0x0400592A RID: 22826
		UserlistRemove,
		// Token: 0x0400592B RID: 22827
		UserlistUpdate,
		// Token: 0x0400592C RID: 22828
		UseEquipmentSetResult = 10057U,
		// Token: 0x0400592D RID: 22829
		VasCheckTransferOkResponse = 10261U,
		// Token: 0x0400592E RID: 22830
		VasGetQueueMinutesResponse = 10259U,
		// Token: 0x0400592F RID: 22831
		VasGetServiceStatusResponse = 10258U,
		// Token: 0x04005930 RID: 22832
		VasPurchaseComplete = 10221U,
		// Token: 0x04005931 RID: 22833
		VasPurchaseStateUpdate = 10220U,
		// Token: 0x04005932 RID: 22834
		VendorInventory = 9656U,
		// Token: 0x04005933 RID: 22835
		VignetteUpdate = 12296U,
		// Token: 0x04005934 RID: 22836
		VoiceChannelInfoResponse = 10265U,
		// Token: 0x04005935 RID: 22837
		VoiceChannelSttTokenResponse = 10361U,
		// Token: 0x04005936 RID: 22838
		VoiceLoginResponse = 10264U,
		// Token: 0x04005937 RID: 22839
		VoidItemSwapResponse = 11684U,
		// Token: 0x04005938 RID: 22840
		VoidStorageContents = 11681U,
		// Token: 0x04005939 RID: 22841
		VoidStorageFailed = 11680U,
		// Token: 0x0400593A RID: 22842
		VoidStorageTransferChanges = 11682U,
		// Token: 0x0400593B RID: 22843
		VoidTransferResult,
		// Token: 0x0400593C RID: 22844
		WaitQueueFinish = 9583U,
		// Token: 0x0400593D RID: 22845
		WaitQueueUpdate = 9582U,
		// Token: 0x0400593E RID: 22846
		Warden3Data = 9591U,
		// Token: 0x0400593F RID: 22847
		Warden3Disabled = 10268U,
		// Token: 0x04005940 RID: 22848
		Warden3Enabled = 10267U,
		// Token: 0x04005941 RID: 22849
		WarfrontComplete = 10072U,
		// Token: 0x04005942 RID: 22850
		WargameRequestSuccessfullySentToOpponent = 10547U,
		// Token: 0x04005943 RID: 22851
		Weather = 9892U,
		// Token: 0x04005944 RID: 22852
		WeeklyRewardsProgressResult = 10352U,
		// Token: 0x04005945 RID: 22853
		WeeklyRewardsResult = 10350U,
		// Token: 0x04005946 RID: 22854
		WeeklyRewardClaimResult,
		// Token: 0x04005947 RID: 22855
		WeeklySpellUsage = 11288U,
		// Token: 0x04005948 RID: 22856
		Who = 11182U,
		// Token: 0x04005949 RID: 22857
		WhoIs = 9891U,
		// Token: 0x0400594A RID: 22858
		WillBeKickedForAddedSubscriptionTime = 10272U,
		// Token: 0x0400594B RID: 22859
		WorldQuestUpdateResponse = 12303U,
		// Token: 0x0400594C RID: 22860
		WorldServerInfo = 9646U,
		// Token: 0x0400594D RID: 22861
		WowEntitlementNotification = 10342U,
		// Token: 0x0400594E RID: 22862
		XpAwardedFromCurrency = 10408U,
		// Token: 0x0400594F RID: 22863
		XpGainAborted = 9673U,
		// Token: 0x04005950 RID: 22864
		XpGainEnabled = 10150U,
		// Token: 0x04005951 RID: 22865
		ZoneUnderAttack = 11189U,
		// Token: 0x04005952 RID: 22866
		AccountHeirloomUpdate = 9650U,
		// Token: 0x04005953 RID: 22867
		CompressedPacket = 12370U,
		// Token: 0x04005954 RID: 22868
		MultiplePackets = 12369U,
		// Token: 0x04005955 RID: 22869
		ArenaTeamStats = 47837U
	}
}
