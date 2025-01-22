using System;

namespace Framework.Constants
{
	// Token: 0x020007AB RID: 1963
	public enum ClientOpcodes : uint
	{
		// Token: 0x04005173 RID: 20851
		AbandonNpeResponse = 13291U,
		// Token: 0x04005174 RID: 20852
		AcceptGuildInvite = 13820U,
		// Token: 0x04005175 RID: 20853
		AcceptReturningPlayerPrompt = 13205U,
		// Token: 0x04005176 RID: 20854
		AcceptSocialContract = 14140U,
		// Token: 0x04005177 RID: 20855
		AcceptTrade = 12634U,
		// Token: 0x04005178 RID: 20856
		AcceptWargameInvite = 13792U,
		// Token: 0x04005179 RID: 20857
		AccountNotificationAcknowledged = 14129U,
		// Token: 0x0400517A RID: 20858
		ActivateSoulbind = 13274U,
		// Token: 0x0400517B RID: 20859
		ActivateTaxi = 13489U,
		// Token: 0x0400517C RID: 20860
		AddonList = 13784U,
		// Token: 0x0400517D RID: 20861
		AddAccountCosmetic = 12977U,
		// Token: 0x0400517E RID: 20862
		AddBattlenetFriend = 13912U,
		// Token: 0x0400517F RID: 20863
		AddFriend = 14028U,
		// Token: 0x04005180 RID: 20864
		AddIgnore = 14032U,
		// Token: 0x04005181 RID: 20865
		AddToy = 12976U,
		// Token: 0x04005182 RID: 20866
		AdventureJournalOpenQuest = 12804U,
		// Token: 0x04005183 RID: 20867
		AdventureJournalUpdateSuggestions = 13277U,
		// Token: 0x04005184 RID: 20868
		AdventureMapStartQuest = 13161U,
		// Token: 0x04005185 RID: 20869
		AlterAppearance = 13571U,
		// Token: 0x04005186 RID: 20870
		AreaSpiritHealerQuery = 13494U,
		// Token: 0x04005187 RID: 20871
		AreaSpiritHealerQueue,
		// Token: 0x04005188 RID: 20872
		AreaTrigger = 12760U,
		// Token: 0x04005189 RID: 20873
		ArtifactAddPower = 12715U,
		// Token: 0x0400518A RID: 20874
		ArtifactSetAppearance = 12717U,
		// Token: 0x0400518B RID: 20875
		AssignEquipmentSetSpec = 12816U,
		// Token: 0x0400518C RID: 20876
		AttackStop = 12899U,
		// Token: 0x0400518D RID: 20877
		AttackSwing = 12898U,
		// Token: 0x0400518E RID: 20878
		AuctionableTokenSell = 14050U,
		// Token: 0x0400518F RID: 20879
		AuctionableTokenSellAtMarketPrice,
		// Token: 0x04005190 RID: 20880
		AuctionBrowseQuery = 13526U,
		// Token: 0x04005191 RID: 20881
		AuctionCancelCommoditiesPurchase = 13534U,
		// Token: 0x04005192 RID: 20882
		AuctionConfirmCommoditiesPurchase = 13533U,
		// Token: 0x04005193 RID: 20883
		AuctionGetCommodityQuote = 13532U,
		// Token: 0x04005194 RID: 20884
		AuctionHelloRequest = 13521U,
		// Token: 0x04005195 RID: 20885
		AuctionListBiddedItems = 13530U,
		// Token: 0x04005196 RID: 20886
		AuctionListBucketsByBucketKeys,
		// Token: 0x04005197 RID: 20887
		AuctionListItemsByBucketKey = 13527U,
		// Token: 0x04005198 RID: 20888
		AuctionListItemsByItemId,
		// Token: 0x04005199 RID: 20889
		AuctionListOwnedItems,
		// Token: 0x0400519A RID: 20890
		AuctionPlaceBid = 13525U,
		// Token: 0x0400519B RID: 20891
		AuctionRemoveItem = 13523U,
		// Token: 0x0400519C RID: 20892
		AuctionReplicateItems,
		// Token: 0x0400519D RID: 20893
		AuctionRequestFavoriteList = 14131U,
		// Token: 0x0400519E RID: 20894
		AuctionSellCommodity = 13535U,
		// Token: 0x0400519F RID: 20895
		AuctionSellItem = 13522U,
		// Token: 0x040051A0 RID: 20896
		AuctionSetFavoriteItem = 14130U,
		// Token: 0x040051A1 RID: 20897
		AuthContinuedSession = 14182U,
		// Token: 0x040051A2 RID: 20898
		AuthSession = 14181U,
		// Token: 0x040051A3 RID: 20899
		AutobankItem = 14743U,
		// Token: 0x040051A4 RID: 20900
		AutobankReagent = 14745U,
		// Token: 0x040051A5 RID: 20901
		AutostoreBankItem = 14742U,
		// Token: 0x040051A6 RID: 20902
		AutostoreBankReagent = 14744U,
		// Token: 0x040051A7 RID: 20903
		AutoEquipItem = 14746U,
		// Token: 0x040051A8 RID: 20904
		AutoEquipItemSlot = 14751U,
		// Token: 0x040051A9 RID: 20905
		AutoGuildBankItem = 13501U,
		// Token: 0x040051AA RID: 20906
		AutoStoreBagItem = 14747U,
		// Token: 0x040051AB RID: 20907
		AutoStoreGuildBankItem = 13510U,
		// Token: 0x040051AC RID: 20908
		AzeriteEmpoweredItemSelectPower = 13201U,
		// Token: 0x040051AD RID: 20909
		AzeriteEmpoweredItemViewed = 13172U,
		// Token: 0x040051AE RID: 20910
		AzeriteEssenceActivateEssence = 13203U,
		// Token: 0x040051AF RID: 20911
		AzeriteEssenceUnlockMilestone = 13202U,
		// Token: 0x040051B0 RID: 20912
		BankerActivate = 13497U,
		// Token: 0x040051B1 RID: 20913
		BattlefieldLeave = 12659U,
		// Token: 0x040051B2 RID: 20914
		BattlefieldList = 12671U,
		// Token: 0x040051B3 RID: 20915
		BattlefieldPort = 13624U,
		// Token: 0x040051B4 RID: 20916
		BattlemasterHello = 13005U,
		// Token: 0x040051B5 RID: 20917
		BattlemasterJoin = 13616U,
		// Token: 0x040051B6 RID: 20918
		BattlemasterJoinArena,
		// Token: 0x040051B7 RID: 20919
		BattlemasterJoinBrawl = 13622U,
		// Token: 0x040051B8 RID: 20920
		BattlemasterJoinRatedSoloShuffle = 13618U,
		// Token: 0x040051B9 RID: 20921
		BattlemasterJoinSkirmish,
		// Token: 0x040051BA RID: 20922
		BattlenetChallengeResponse = 14031U,
		// Token: 0x040051BB RID: 20923
		BattlenetRequest = 14065U,
		// Token: 0x040051BC RID: 20924
		BattlePayAckFailedResponse = 14025U,
		// Token: 0x040051BD RID: 20925
		BattlePayCancelOpenCheckout = 14095U,
		// Token: 0x040051BE RID: 20926
		BattlePayConfirmPurchaseResponse = 14024U,
		// Token: 0x040051BF RID: 20927
		BattlePayDistributionAssignToTarget = 14015U,
		// Token: 0x040051C0 RID: 20928
		BattlePayDistributionAssignVas = 14134U,
		// Token: 0x040051C1 RID: 20929
		BattlePayGetProductList = 14007U,
		// Token: 0x040051C2 RID: 20930
		BattlePayGetPurchaseList,
		// Token: 0x040051C3 RID: 20931
		BattlePayOpenCheckout = 14088U,
		// Token: 0x040051C4 RID: 20932
		BattlePayRequestPriceInfo = 14084U,
		// Token: 0x040051C5 RID: 20933
		BattlePayStartPurchase = 14023U,
		// Token: 0x040051C6 RID: 20934
		BattlePayStartVasPurchase = 14062U,
		// Token: 0x040051C7 RID: 20935
		BattlePetClearFanfare = 12587U,
		// Token: 0x040051C8 RID: 20936
		BattlePetDeletePet = 13859U,
		// Token: 0x040051C9 RID: 20937
		BattlePetDeletePetCheat,
		// Token: 0x040051CA RID: 20938
		BattlePetModifyName = 13862U,
		// Token: 0x040051CB RID: 20939
		BattlePetRequestJournal = 13858U,
		// Token: 0x040051CC RID: 20940
		BattlePetRequestJournalLock = 13857U,
		// Token: 0x040051CD RID: 20941
		BattlePetSetBattleSlot = 13867U,
		// Token: 0x040051CE RID: 20942
		BattlePetSetFlags = 13870U,
		// Token: 0x040051CF RID: 20943
		BattlePetSummon = 13863U,
		// Token: 0x040051D0 RID: 20944
		BattlePetUpdateDisplayNotify = 12770U,
		// Token: 0x040051D1 RID: 20945
		BattlePetUpdateNotify = 12769U,
		// Token: 0x040051D2 RID: 20946
		BeginTrade = 12631U,
		// Token: 0x040051D3 RID: 20947
		BinderActivate = 13496U,
		// Token: 0x040051D4 RID: 20948
		BlackMarketBidOnItem = 13632U,
		// Token: 0x040051D5 RID: 20949
		BlackMarketOpen = 13630U,
		// Token: 0x040051D6 RID: 20950
		BlackMarketRequestItems,
		// Token: 0x040051D7 RID: 20951
		BonusRoll = 13204U,
		// Token: 0x040051D8 RID: 20952
		BugReport = 13955U,
		// Token: 0x040051D9 RID: 20953
		BusyTrade = 12632U,
		// Token: 0x040051DA RID: 20954
		BuyBackItem = 13482U,
		// Token: 0x040051DB RID: 20955
		BuyBankSlot = 13498U,
		// Token: 0x040051DC RID: 20956
		BuyItem = 13481U,
		// Token: 0x040051DD RID: 20957
		BuyReagentBank = 13499U,
		// Token: 0x040051DE RID: 20958
		CageBattlePet = 12788U,
		// Token: 0x040051DF RID: 20959
		CalendarAddEvent = 13947U,
		// Token: 0x040051E0 RID: 20960
		CalendarCommunityInvite = 13935U,
		// Token: 0x040051E1 RID: 20961
		CalendarComplain = 13943U,
		// Token: 0x040051E2 RID: 20962
		CalendarCopyEvent = 13942U,
		// Token: 0x040051E3 RID: 20963
		CalendarEventSignUp = 13945U,
		// Token: 0x040051E4 RID: 20964
		CalendarGet = 13933U,
		// Token: 0x040051E5 RID: 20965
		CalendarGetEvent,
		// Token: 0x040051E6 RID: 20966
		CalendarGetNumPending = 13944U,
		// Token: 0x040051E7 RID: 20967
		CalendarInvite = 13936U,
		// Token: 0x040051E8 RID: 20968
		CalendarModeratorStatus = 13940U,
		// Token: 0x040051E9 RID: 20969
		CalendarRemoveEvent,
		// Token: 0x040051EA RID: 20970
		CalendarRemoveInvite = 13937U,
		// Token: 0x040051EB RID: 20971
		CalendarRsvp,
		// Token: 0x040051EC RID: 20972
		CalendarStatus,
		// Token: 0x040051ED RID: 20973
		CalendarUpdateEvent = 13948U,
		// Token: 0x040051EE RID: 20974
		CancelAura = 12719U,
		// Token: 0x040051EF RID: 20975
		CancelAutoRepeatSpell = 13557U,
		// Token: 0x040051F0 RID: 20976
		CancelCast = 12983U,
		// Token: 0x040051F1 RID: 20977
		CancelChannelling = 12923U,
		// Token: 0x040051F2 RID: 20978
		CancelGrowthAura = 12931U,
		// Token: 0x040051F3 RID: 20979
		CancelMasterLootRoll = 12828U,
		// Token: 0x040051F4 RID: 20980
		CancelModSpeedNoControlAuras = 12718U,
		// Token: 0x040051F5 RID: 20981
		CancelMountAura = 12950U,
		// Token: 0x040051F6 RID: 20982
		CancelQueuedSpell = 12672U,
		// Token: 0x040051F7 RID: 20983
		CancelTempEnchantment = 13568U,
		// Token: 0x040051F8 RID: 20984
		CancelTrade = 12636U,
		// Token: 0x040051F9 RID: 20985
		CanDuel = 13920U,
		// Token: 0x040051FA RID: 20986
		CanRedeemTokenForBalance = 14083U,
		// Token: 0x040051FB RID: 20987
		CastSpell = 12980U,
		// Token: 0x040051FC RID: 20988
		ChallengeModeRequestLeaders = 12431U,
		// Token: 0x040051FD RID: 20989
		ChangeBagSlotFlag = 13134U,
		// Token: 0x040051FE RID: 20990
		ChangeBankBagSlotFlag,
		// Token: 0x040051FF RID: 20991
		ChangeMonumentAppearance = 13103U,
		// Token: 0x04005200 RID: 20992
		ChangeRealmTicket = 14070U,
		// Token: 0x04005201 RID: 20993
		ChangeSubGroup = 13898U,
		// Token: 0x04005202 RID: 20994
		CharacterCheckUpgrade = 14018U,
		// Token: 0x04005203 RID: 20995
		CharacterRenameRequest = 14013U,
		// Token: 0x04005204 RID: 20996
		CharacterUpgradeManualUnrevokeRequest = 14016U,
		// Token: 0x04005205 RID: 20997
		CharacterUpgradeStart,
		// Token: 0x04005206 RID: 20998
		CharCustomize = 13962U,
		// Token: 0x04005207 RID: 20999
		CharDelete = 13978U,
		// Token: 0x04005208 RID: 21000
		CharRaceOrFactionChange = 13968U,
		// Token: 0x04005209 RID: 21001
		ChatAddonMessage = 14318U,
		// Token: 0x0400520A RID: 21002
		ChatAddonMessageTargeted,
		// Token: 0x0400520B RID: 21003
		ChatChannelAnnouncements = 14307U,
		// Token: 0x0400520C RID: 21004
		ChatChannelBan = 14305U,
		// Token: 0x0400520D RID: 21005
		ChatChannelDeclineInvite = 14310U,
		// Token: 0x0400520E RID: 21006
		ChatChannelDisplayList = 14294U,
		// Token: 0x0400520F RID: 21007
		ChatChannelInvite = 14303U,
		// Token: 0x04005210 RID: 21008
		ChatChannelKick,
		// Token: 0x04005211 RID: 21009
		ChatChannelList = 14293U,
		// Token: 0x04005212 RID: 21010
		ChatChannelModerator = 14299U,
		// Token: 0x04005213 RID: 21011
		ChatChannelOwner = 14297U,
		// Token: 0x04005214 RID: 21012
		ChatChannelPassword = 14295U,
		// Token: 0x04005215 RID: 21013
		ChatChannelSetOwner,
		// Token: 0x04005216 RID: 21014
		ChatChannelSilenceAll = 14308U,
		// Token: 0x04005217 RID: 21015
		ChatChannelUnban = 14306U,
		// Token: 0x04005218 RID: 21016
		ChatChannelUnmoderator = 14300U,
		// Token: 0x04005219 RID: 21017
		ChatChannelUnsilenceAll = 14309U,
		// Token: 0x0400521A RID: 21018
		ChatJoinChannel = 14280U,
		// Token: 0x0400521B RID: 21019
		ChatLeaveChannel,
		// Token: 0x0400521C RID: 21020
		ChatMessageAfk = 14291U,
		// Token: 0x0400521D RID: 21021
		ChatMessageChannel = 14287U,
		// Token: 0x0400521E RID: 21022
		ChatMessageDnd = 14292U,
		// Token: 0x0400521F RID: 21023
		ChatMessageEmote = 14312U,
		// Token: 0x04005220 RID: 21024
		ChatMessageGuild = 14289U,
		// Token: 0x04005221 RID: 21025
		ChatMessageInstanceChat = 14316U,
		// Token: 0x04005222 RID: 21026
		ChatMessageOfficer = 14290U,
		// Token: 0x04005223 RID: 21027
		ChatMessageParty = 14314U,
		// Token: 0x04005224 RID: 21028
		ChatMessageRaid,
		// Token: 0x04005225 RID: 21029
		ChatMessageRaidWarning = 14317U,
		// Token: 0x04005226 RID: 21030
		ChatMessageSay = 14311U,
		// Token: 0x04005227 RID: 21031
		ChatMessageWhisper = 14288U,
		// Token: 0x04005228 RID: 21032
		ChatMessageYell = 14313U,
		// Token: 0x04005229 RID: 21033
		ChatRegisterAddonPrefixes = 14285U,
		// Token: 0x0400522A RID: 21034
		ChatReportFiltered = 14284U,
		// Token: 0x0400522B RID: 21035
		ChatReportIgnored = 14283U,
		// Token: 0x0400522C RID: 21036
		ChatUnregisterAllAddonPrefixes = 14286U,
		// Token: 0x0400522D RID: 21037
		CheckCharacterNameAvailability = 13891U,
		// Token: 0x0400522E RID: 21038
		CheckIsAdventureMapPoiValid = 12884U,
		// Token: 0x0400522F RID: 21039
		ChoiceResponse = 12988U,
		// Token: 0x04005230 RID: 21040
		ChromieTimeSelectExpansion = 13273U,
		// Token: 0x04005231 RID: 21041
		ClaimWeeklyReward = 13237U,
		// Token: 0x04005232 RID: 21042
		ClassTalentsDeleteConfig = 13328U,
		// Token: 0x04005233 RID: 21043
		ClassTalentsNotifyEmptyConfig = 12820U,
		// Token: 0x04005234 RID: 21044
		ClassTalentsNotifyValidationFailed = 13330U,
		// Token: 0x04005235 RID: 21045
		ClassTalentsRenameConfig = 13327U,
		// Token: 0x04005236 RID: 21046
		ClassTalentsRequestNewConfig = 13326U,
		// Token: 0x04005237 RID: 21047
		ClassTalentsSetStarterBuildActive = 13331U,
		// Token: 0x04005238 RID: 21048
		ClassTalentsSetUsesSharedActionBars = 12819U,
		// Token: 0x04005239 RID: 21049
		ClearNewAppearance = 12590U,
		// Token: 0x0400523A RID: 21050
		ClearRaidMarker = 12711U,
		// Token: 0x0400523B RID: 21051
		ClearTradeItem = 12638U,
		// Token: 0x0400523C RID: 21052
		ClientPortGraveyard = 13626U,
		// Token: 0x0400523D RID: 21053
		CloseInteraction = 13465U,
		// Token: 0x0400523E RID: 21054
		CloseQuestChoice = 12989U,
		// Token: 0x0400523F RID: 21055
		CloseRuneforgeInteraction = 13281U,
		// Token: 0x04005240 RID: 21056
		CloseTraitSystemInteraction = 13332U,
		// Token: 0x04005241 RID: 21057
		ClubFinderApplicationResponse = 14106U,
		// Token: 0x04005242 RID: 21058
		ClubFinderGetApplicantsList = 14104U,
		// Token: 0x04005243 RID: 21059
		ClubFinderPost = 14101U,
		// Token: 0x04005244 RID: 21060
		ClubFinderRequestClubsData = 14108U,
		// Token: 0x04005245 RID: 21061
		ClubFinderRequestClubsList = 14102U,
		// Token: 0x04005246 RID: 21062
		ClubFinderRequestMembershipToClub,
		// Token: 0x04005247 RID: 21063
		ClubFinderRequestPendingClubsList = 14107U,
		// Token: 0x04005248 RID: 21064
		ClubFinderRequestSubscribedClubPostingIds = 14109U,
		// Token: 0x04005249 RID: 21065
		ClubFinderRespondToApplicant = 14105U,
		// Token: 0x0400524A RID: 21066
		ClubFinderWhisperApplicantRequest = 14137U,
		// Token: 0x0400524B RID: 21067
		ClubPresenceSubscribe = 14067U,
		// Token: 0x0400524C RID: 21068
		CollectionItemSetFavorite = 13873U,
		// Token: 0x0400524D RID: 21069
		CommentatorEnable = 13808U,
		// Token: 0x0400524E RID: 21070
		CommentatorEnterInstance = 13812U,
		// Token: 0x0400524F RID: 21071
		CommentatorExitInstance,
		// Token: 0x04005250 RID: 21072
		CommentatorGetMapInfo = 13809U,
		// Token: 0x04005251 RID: 21073
		CommentatorGetPlayerCooldowns = 13811U,
		// Token: 0x04005252 RID: 21074
		CommentatorGetPlayerInfo = 13810U,
		// Token: 0x04005253 RID: 21075
		CommentatorSpectate = 14135U,
		// Token: 0x04005254 RID: 21076
		CommentatorStartWargame = 13807U,
		// Token: 0x04005255 RID: 21077
		CommerceTokenGetCount = 14048U,
		// Token: 0x04005256 RID: 21078
		CommerceTokenGetLog = 14058U,
		// Token: 0x04005257 RID: 21079
		CommerceTokenGetMarketPrice = 14049U,
		// Token: 0x04005258 RID: 21080
		Complaint = 13930U,
		// Token: 0x04005259 RID: 21081
		CompleteCinematic = 13656U,
		// Token: 0x0400525A RID: 21082
		CompleteMovie = 13547U,
		// Token: 0x0400525B RID: 21083
		ConfirmArtifactRespec = 12716U,
		// Token: 0x0400525C RID: 21084
		ConfirmRespecWipe = 12822U,
		// Token: 0x0400525D RID: 21085
		ConnectToFailed = 13780U,
		// Token: 0x0400525E RID: 21086
		ConsumableTokenBuy = 14053U,
		// Token: 0x0400525F RID: 21087
		ConsumableTokenBuyAtMarketPrice,
		// Token: 0x04005260 RID: 21088
		ConsumableTokenCanVeteranBuy = 14052U,
		// Token: 0x04005261 RID: 21089
		ConsumableTokenRedeem = 14056U,
		// Token: 0x04005262 RID: 21090
		ConsumableTokenRedeemConfirmation,
		// Token: 0x04005263 RID: 21091
		ContributionContribute = 13676U,
		// Token: 0x04005264 RID: 21092
		ContributionLastUpdateRequest,
		// Token: 0x04005265 RID: 21093
		ConversationCinematicReady = 13658U,
		// Token: 0x04005266 RID: 21094
		ConversationLineStarted = 13657U,
		// Token: 0x04005267 RID: 21095
		ConvertRaid = 13900U,
		// Token: 0x04005268 RID: 21096
		CovenantRenownRequestCatchupState = 13696U,
		// Token: 0x04005269 RID: 21097
		CraftingOrderCancel = 13707U,
		// Token: 0x0400526A RID: 21098
		CraftingOrderClaim = 13704U,
		// Token: 0x0400526B RID: 21099
		CraftingOrderCreate = 13701U,
		// Token: 0x0400526C RID: 21100
		CraftingOrderFulfill = 13706U,
		// Token: 0x0400526D RID: 21101
		CraftingOrderListCrafterOrders = 13703U,
		// Token: 0x0400526E RID: 21102
		CraftingOrderListMyOrders = 13702U,
		// Token: 0x0400526F RID: 21103
		CraftingOrderReject = 13708U,
		// Token: 0x04005270 RID: 21104
		CraftingOrderRelease = 13705U,
		// Token: 0x04005271 RID: 21105
		CraftingOrderUpdateIgnoreList = 13709U,
		// Token: 0x04005272 RID: 21106
		CreateCharacter = 13890U,
		// Token: 0x04005273 RID: 21107
		CreateShipment = 13082U,
		// Token: 0x04005274 RID: 21108
		DbQueryBulk = 13796U,
		// Token: 0x04005275 RID: 21109
		DeclineGuildInvites = 13613U,
		// Token: 0x04005276 RID: 21110
		DeclinePetition = 13639U,
		// Token: 0x04005277 RID: 21111
		DeleteEquipmentSet = 13593U,
		// Token: 0x04005278 RID: 21112
		DelFriend = 14029U,
		// Token: 0x04005279 RID: 21113
		DelIgnore = 14033U,
		// Token: 0x0400527A RID: 21114
		DepositReagentBank = 13143U,
		// Token: 0x0400527B RID: 21115
		DestroyItem = 12970U,
		// Token: 0x0400527C RID: 21116
		DfBootPlayerVote = 13846U,
		// Token: 0x0400527D RID: 21117
		DfConfirmExpandSearch = 13832U,
		// Token: 0x0400527E RID: 21118
		DfGetJoinStatus = 13844U,
		// Token: 0x0400527F RID: 21119
		DfGetSystemInfo = 13843U,
		// Token: 0x04005280 RID: 21120
		DfJoin = 13833U,
		// Token: 0x04005281 RID: 21121
		DfLeave = 13842U,
		// Token: 0x04005282 RID: 21122
		DfProposalResponse = 13831U,
		// Token: 0x04005283 RID: 21123
		DfReadyCheckResponse = 13849U,
		// Token: 0x04005284 RID: 21124
		DfSetRoles = 13845U,
		// Token: 0x04005285 RID: 21125
		DfTeleport = 13847U,
		// Token: 0x04005286 RID: 21126
		DiscardedTimeSyncAcks = 14913U,
		// Token: 0x04005287 RID: 21127
		DismissCritter = 13575U,
		// Token: 0x04005288 RID: 21128
		DoCountdown = 14100U,
		// Token: 0x04005289 RID: 21129
		DoMasterLootRoll = 12827U,
		// Token: 0x0400528A RID: 21130
		DoReadyCheck = 13874U,
		// Token: 0x0400528B RID: 21131
		DuelResponse = 13552U,
		// Token: 0x0400528C RID: 21132
		EjectPassenger = 12873U,
		// Token: 0x0400528D RID: 21133
		Emote = 13652U,
		// Token: 0x0400528E RID: 21134
		EnableNagle = 14187U,
		// Token: 0x0400528F RID: 21135
		EnableTaxiNode = 13487U,
		// Token: 0x04005290 RID: 21136
		EngineSurvey = 14047U,
		// Token: 0x04005291 RID: 21137
		EnterEncryptedModeAck = 14183U,
		// Token: 0x04005292 RID: 21138
		EnumCharacters = 13800U,
		// Token: 0x04005293 RID: 21139
		EnumCharactersDeletedByClient = 14041U,
		// Token: 0x04005294 RID: 21140
		FarSight = 13558U,
		// Token: 0x04005295 RID: 21141
		GameEventDebugDisable = 12723U,
		// Token: 0x04005296 RID: 21142
		GameEventDebugEnable = 12722U,
		// Token: 0x04005297 RID: 21143
		GameObjReportUse = 13565U,
		// Token: 0x04005298 RID: 21144
		GameObjUse = 13564U,
		// Token: 0x04005299 RID: 21145
		GarrisonAddFollowerHealth = 13077U,
		// Token: 0x0400529A RID: 21146
		GarrisonAssignFollowerToBuilding = 13051U,
		// Token: 0x0400529B RID: 21147
		GarrisonCancelConstruction = 13032U,
		// Token: 0x0400529C RID: 21148
		GarrisonCheckUpgradeable = 13130U,
		// Token: 0x0400529D RID: 21149
		GarrisonCompleteMission = 13116U,
		// Token: 0x0400529E RID: 21150
		GarrisonFullyHealAllFollowers = 13078U,
		// Token: 0x0400529F RID: 21151
		GarrisonGenerateRecruits = 13054U,
		// Token: 0x040052A0 RID: 21152
		GarrisonGetClassSpecCategoryInfo = 13069U,
		// Token: 0x040052A1 RID: 21153
		GarrisonGetMapData = 13076U,
		// Token: 0x040052A2 RID: 21154
		GarrisonGetMissionReward = 13165U,
		// Token: 0x040052A3 RID: 21155
		GarrisonLearnTalent = 13065U,
		// Token: 0x040052A4 RID: 21156
		GarrisonMissionBonusRoll = 13118U,
		// Token: 0x040052A5 RID: 21157
		GarrisonPurchaseBuilding = 13028U,
		// Token: 0x040052A6 RID: 21158
		GarrisonRecruitFollower = 13056U,
		// Token: 0x040052A7 RID: 21159
		GarrisonRemoveFollower = 13107U,
		// Token: 0x040052A8 RID: 21160
		GarrisonRemoveFollowerFromBuilding = 13052U,
		// Token: 0x040052A9 RID: 21161
		GarrisonRenameFollower,
		// Token: 0x040052AA RID: 21162
		GarrisonRequestBlueprintAndSpecializationData = 13027U,
		// Token: 0x040052AB RID: 21163
		GarrisonRequestShipmentInfo = 13080U,
		// Token: 0x040052AC RID: 21164
		GarrisonResearchTalent = 13057U,
		// Token: 0x040052AD RID: 21165
		GarrisonSetBuildingActive = 13029U,
		// Token: 0x040052AE RID: 21166
		GarrisonSetFollowerFavorite = 13049U,
		// Token: 0x040052AF RID: 21167
		GarrisonSetFollowerInactive = 13041U,
		// Token: 0x040052B0 RID: 21168
		GarrisonSetRecruitmentPreferences = 13055U,
		// Token: 0x040052B1 RID: 21169
		GarrisonSocketTalent = 13294U,
		// Token: 0x040052B2 RID: 21170
		GarrisonStartMission = 13115U,
		// Token: 0x040052B3 RID: 21171
		GarrisonSwapBuildings = 13033U,
		// Token: 0x040052B4 RID: 21172
		GenerateRandomCharacterName = 13799U,
		// Token: 0x040052B5 RID: 21173
		GetAccountCharacterList = 14002U,
		// Token: 0x040052B6 RID: 21174
		GetAccountNotifications = 14128U,
		// Token: 0x040052B7 RID: 21175
		GetGarrisonInfo = 13022U,
		// Token: 0x040052B8 RID: 21176
		GetItemPurchaseData = 13634U,
		// Token: 0x040052B9 RID: 21177
		GetLandingPageShipments = 13081U,
		// Token: 0x040052BA RID: 21178
		GetMirrorImageData = 12974U,
		// Token: 0x040052BB RID: 21179
		GetPvpOptionsEnabled = 13806U,
		// Token: 0x040052BC RID: 21180
		GetRafAccountInfo = 14110U,
		// Token: 0x040052BD RID: 21181
		GetRemainingGameTime = 14055U,
		// Token: 0x040052BE RID: 21182
		GetTrophyList = 13100U,
		// Token: 0x040052BF RID: 21183
		GetUndeleteCharacterCooldownStatus = 14043U,
		// Token: 0x040052C0 RID: 21184
		GetVasAccountCharacterList = 14060U,
		// Token: 0x040052C1 RID: 21185
		GetVasTransferTargetRealmList,
		// Token: 0x040052C2 RID: 21186
		GmTicketAcknowledgeSurvey = 13966U,
		// Token: 0x040052C3 RID: 21187
		GmTicketGetCaseStatus = 13965U,
		// Token: 0x040052C4 RID: 21188
		GmTicketGetSystemStatus = 13964U,
		// Token: 0x040052C5 RID: 21189
		GossipRefreshOptions = 13695U,
		// Token: 0x040052C6 RID: 21190
		GossipSelectOption = 13466U,
		// Token: 0x040052C7 RID: 21191
		GuildAddBattlenetFriend = 12429U,
		// Token: 0x040052C8 RID: 21192
		GuildAddRank = 12389U,
		// Token: 0x040052C9 RID: 21193
		GuildAssignMemberRank = 12384U,
		// Token: 0x040052CA RID: 21194
		GuildAutoDeclineInvitation = 12386U,
		// Token: 0x040052CB RID: 21195
		GuildBankActivate = 13500U,
		// Token: 0x040052CC RID: 21196
		GuildBankBuyTab = 13514U,
		// Token: 0x040052CD RID: 21197
		GuildBankDepositMoney = 13516U,
		// Token: 0x040052CE RID: 21198
		GuildBankLogQuery = 12419U,
		// Token: 0x040052CF RID: 21199
		GuildBankQueryTab = 13513U,
		// Token: 0x040052D0 RID: 21200
		GuildBankRemainingWithdrawMoneyQuery = 12420U,
		// Token: 0x040052D1 RID: 21201
		GuildBankSetTabText = 12423U,
		// Token: 0x040052D2 RID: 21202
		GuildBankTextQuery,
		// Token: 0x040052D3 RID: 21203
		GuildBankUpdateTab = 13515U,
		// Token: 0x040052D4 RID: 21204
		GuildBankWithdrawMoney = 13517U,
		// Token: 0x040052D5 RID: 21205
		GuildChallengeUpdateRequest = 12412U,
		// Token: 0x040052D6 RID: 21206
		GuildChangeNameRequest = 12415U,
		// Token: 0x040052D7 RID: 21207
		GuildDeclineInvitation = 12385U,
		// Token: 0x040052D8 RID: 21208
		GuildDelete = 12393U,
		// Token: 0x040052D9 RID: 21209
		GuildDeleteRank = 12390U,
		// Token: 0x040052DA RID: 21210
		GuildDemoteMember = 12383U,
		// Token: 0x040052DB RID: 21211
		GuildEventLogQuery = 12422U,
		// Token: 0x040052DC RID: 21212
		GuildGetAchievementMembers = 12402U,
		// Token: 0x040052DD RID: 21213
		GuildGetRanks = 12398U,
		// Token: 0x040052DE RID: 21214
		GuildGetRoster = 12404U,
		// Token: 0x040052DF RID: 21215
		GuildInviteByName = 13830U,
		// Token: 0x040052E0 RID: 21216
		GuildLeave = 12387U,
		// Token: 0x040052E1 RID: 21217
		GuildNewsUpdateSticky = 12399U,
		// Token: 0x040052E2 RID: 21218
		GuildOfficerRemoveMember = 12388U,
		// Token: 0x040052E3 RID: 21219
		GuildPermissionsQuery = 12421U,
		// Token: 0x040052E4 RID: 21220
		GuildPromoteMember = 12382U,
		// Token: 0x040052E5 RID: 21221
		GuildQueryMembersForRecipe = 12396U,
		// Token: 0x040052E6 RID: 21222
		GuildQueryMemberRecipes = 12394U,
		// Token: 0x040052E7 RID: 21223
		GuildQueryNews = 12397U,
		// Token: 0x040052E8 RID: 21224
		GuildQueryRecipes = 12395U,
		// Token: 0x040052E9 RID: 21225
		GuildReplaceGuildMaster = 12425U,
		// Token: 0x040052EA RID: 21226
		GuildSetAchievementTracking = 12400U,
		// Token: 0x040052EB RID: 21227
		GuildSetFocusedAchievement,
		// Token: 0x040052EC RID: 21228
		GuildSetGuildMaster = 14020U,
		// Token: 0x040052ED RID: 21229
		GuildSetMemberNote = 12403U,
		// Token: 0x040052EE RID: 21230
		GuildSetRankPermissions = 12392U,
		// Token: 0x040052EF RID: 21231
		GuildShiftRank = 12391U,
		// Token: 0x040052F0 RID: 21232
		GuildUpdateInfoText = 12406U,
		// Token: 0x040052F1 RID: 21233
		GuildUpdateMotdText = 12405U,
		// Token: 0x040052F2 RID: 21234
		HearthAndResurrect = 13589U,
		// Token: 0x040052F3 RID: 21235
		HideQuestChoice = 12990U,
		// Token: 0x040052F4 RID: 21236
		HotfixRequest = 13797U,
		// Token: 0x040052F5 RID: 21237
		IgnoreTrade = 12633U,
		// Token: 0x040052F6 RID: 21238
		InitiateRolePoll = 13786U,
		// Token: 0x040052F7 RID: 21239
		InitiateTrade = 12630U,
		// Token: 0x040052F8 RID: 21240
		Inspect = 13628U,
		// Token: 0x040052F9 RID: 21241
		InstanceLockResponse = 13594U,
		// Token: 0x040052FA RID: 21242
		IslandQueue = 13233U,
		// Token: 0x040052FB RID: 21243
		ItemPurchaseRefund = 13635U,
		// Token: 0x040052FC RID: 21244
		ItemTextQuery = 13131U,
		// Token: 0x040052FD RID: 21245
		JoinPetBattleQueue = 12767U,
		// Token: 0x040052FE RID: 21246
		JoinRatedBattleground = 12665U,
		// Token: 0x040052FF RID: 21247
		KeepAlive = 13949U,
		// Token: 0x04005300 RID: 21248
		KeyboundOverride = 12846U,
		// Token: 0x04005301 RID: 21249
		LatencyReport = 14193U,
		// Token: 0x04005302 RID: 21250
		LearnPvpTalents = 13675U,
		// Token: 0x04005303 RID: 21251
		LearnTalents = 13673U,
		// Token: 0x04005304 RID: 21252
		LeaveGroup = 13895U,
		// Token: 0x04005305 RID: 21253
		LeavePetBattleQueue = 12768U,
		// Token: 0x04005306 RID: 21254
		LfgListApplyToGroup = 13837U,
		// Token: 0x04005307 RID: 21255
		LfgListCancelApplication,
		// Token: 0x04005308 RID: 21256
		LfgListDeclineApplicant,
		// Token: 0x04005309 RID: 21257
		LfgListGetStatus = 13835U,
		// Token: 0x0400530A RID: 21258
		LfgListInviteApplicant = 13840U,
		// Token: 0x0400530B RID: 21259
		LfgListInviteResponse,
		// Token: 0x0400530C RID: 21260
		LfgListJoin = 13199U,
		// Token: 0x0400530D RID: 21261
		LfgListLeave = 13834U,
		// Token: 0x0400530E RID: 21262
		LfgListSearch = 13836U,
		// Token: 0x0400530F RID: 21263
		LfgListUpdateRequest = 13200U,
		// Token: 0x04005310 RID: 21264
		ListInventory = 13479U,
		// Token: 0x04005311 RID: 21265
		LiveRegionAccountRestore = 14005U,
		// Token: 0x04005312 RID: 21266
		LiveRegionCharacterCopy = 14004U,
		// Token: 0x04005313 RID: 21267
		LiveRegionGetAccountCharacterList = 14003U,
		// Token: 0x04005314 RID: 21268
		LiveRegionKeyBindingsCopy = 14006U,
		// Token: 0x04005315 RID: 21269
		LoadingScreenNotify = 13816U,
		// Token: 0x04005316 RID: 21270
		LoadSelectedTrophy = 13101U,
		// Token: 0x04005317 RID: 21271
		LogoutCancel = 13542U,
		// Token: 0x04005318 RID: 21272
		LogoutInstant,
		// Token: 0x04005319 RID: 21273
		LogoutRequest = 13540U,
		// Token: 0x0400531A RID: 21274
		LogDisconnect = 14185U,
		// Token: 0x0400531B RID: 21275
		LogStreamingError = 14189U,
		// Token: 0x0400531C RID: 21276
		LootItem = 12825U,
		// Token: 0x0400531D RID: 21277
		LootMoney = 12824U,
		// Token: 0x0400531E RID: 21278
		LootRelease = 12829U,
		// Token: 0x0400531F RID: 21279
		LootRoll,
		// Token: 0x04005320 RID: 21280
		LootUnit = 12823U,
		// Token: 0x04005321 RID: 21281
		LowLevelRaid1 = 13982U,
		// Token: 0x04005322 RID: 21282
		LowLevelRaid2 = 13601U,
		// Token: 0x04005323 RID: 21283
		MailCreateTextItem = 13646U,
		// Token: 0x04005324 RID: 21284
		MailDelete = 12848U,
		// Token: 0x04005325 RID: 21285
		MailGetList = 13641U,
		// Token: 0x04005326 RID: 21286
		MailMarkAsRead = 13645U,
		// Token: 0x04005327 RID: 21287
		MailReturnToSender = 13907U,
		// Token: 0x04005328 RID: 21288
		MailTakeItem = 13643U,
		// Token: 0x04005329 RID: 21289
		MailTakeMoney = 13642U,
		// Token: 0x0400532A RID: 21290
		MakeContitionalAppearancePermanent = 12850U,
		// Token: 0x0400532B RID: 21291
		MasterLootItem = 12826U,
		// Token: 0x0400532C RID: 21292
		MergeGuildBankItemWithGuildBankItem = 13511U,
		// Token: 0x0400532D RID: 21293
		MergeGuildBankItemWithItem = 13508U,
		// Token: 0x0400532E RID: 21294
		MergeItemWithGuildBankItem = 13506U,
		// Token: 0x0400532F RID: 21295
		MinimapPing = 13897U,
		// Token: 0x04005330 RID: 21296
		MissileTrajectoryCollision = 12683U,
		// Token: 0x04005331 RID: 21297
		MountClearFanfare = 12588U,
		// Token: 0x04005332 RID: 21298
		MountSetFavorite = 13872U,
		// Token: 0x04005333 RID: 21299
		MountSpecialAnim = 12951U,
		// Token: 0x04005334 RID: 21300
		MoveAddImpulseAck = 14928U,
		// Token: 0x04005335 RID: 21301
		MoveApplyInertiaAck = 14926U,
		// Token: 0x04005336 RID: 21302
		MoveApplyMovementForceAck = 14869U,
		// Token: 0x04005337 RID: 21303
		MoveChangeTransport = 14895U,
		// Token: 0x04005338 RID: 21304
		MoveChangeVehicleSeats = 14900U,
		// Token: 0x04005339 RID: 21305
		MoveCollisionDisableAck = 14905U,
		// Token: 0x0400533A RID: 21306
		MoveCollisionEnableAck,
		// Token: 0x0400533B RID: 21307
		MoveDismissVehicle = 14899U,
		// Token: 0x0400533C RID: 21308
		MoveDoubleJump = 14827U,
		// Token: 0x0400533D RID: 21309
		MoveEnableDoubleJumpAck = 14878U,
		// Token: 0x0400533E RID: 21310
		MoveEnableSwimToFlyTransAck = 14884U,
		// Token: 0x0400533F RID: 21311
		MoveFallLand = 14843U,
		// Token: 0x04005340 RID: 21312
		MoveFallReset = 14873U,
		// Token: 0x04005341 RID: 21313
		MoveFeatherFallAck = 14876U,
		// Token: 0x04005342 RID: 21314
		MoveForceFlightBackSpeedChangeAck = 14894U,
		// Token: 0x04005343 RID: 21315
		MoveForceFlightSpeedChangeAck = 14893U,
		// Token: 0x04005344 RID: 21316
		MoveForcePitchRateChangeAck = 14898U,
		// Token: 0x04005345 RID: 21317
		MoveForceRootAck = 14862U,
		// Token: 0x04005346 RID: 21318
		MoveForceRunBackSpeedChangeAck = 14860U,
		// Token: 0x04005347 RID: 21319
		MoveForceRunSpeedChangeAck = 14859U,
		// Token: 0x04005348 RID: 21320
		MoveForceSwimBackSpeedChangeAck = 14882U,
		// Token: 0x04005349 RID: 21321
		MoveForceSwimSpeedChangeAck = 14861U,
		// Token: 0x0400534A RID: 21322
		MoveForceTurnRateChangeAck = 14883U,
		// Token: 0x0400534B RID: 21323
		MoveForceUnrootAck = 14863U,
		// Token: 0x0400534C RID: 21324
		MoveForceWalkSpeedChangeAck = 14881U,
		// Token: 0x0400534D RID: 21325
		MoveGravityDisableAck = 14901U,
		// Token: 0x0400534E RID: 21326
		MoveGravityEnableAck,
		// Token: 0x0400534F RID: 21327
		MoveGuildBankItem = 13505U,
		// Token: 0x04005350 RID: 21328
		MoveHeartbeat = 14864U,
		// Token: 0x04005351 RID: 21329
		MoveHoverAck = 14867U,
		// Token: 0x04005352 RID: 21330
		MoveInertiaDisableAck = 14903U,
		// Token: 0x04005353 RID: 21331
		MoveInertiaEnableAck,
		// Token: 0x04005354 RID: 21332
		MoveInitActiveMoverComplete = 14918U,
		// Token: 0x04005355 RID: 21333
		MoveJump = 14826U,
		// Token: 0x04005356 RID: 21334
		MoveKnockBackAck = 14866U,
		// Token: 0x04005357 RID: 21335
		MoveRemoveInertiaAck = 14927U,
		// Token: 0x04005358 RID: 21336
		MoveRemoveMovementForces = 14871U,
		// Token: 0x04005359 RID: 21337
		MoveRemoveMovementForceAck = 14870U,
		// Token: 0x0400535A RID: 21338
		MoveSeamlessTransferComplete = 14916U,
		// Token: 0x0400535B RID: 21339
		MoveSetAdvFly = 14930U,
		// Token: 0x0400535C RID: 21340
		MoveSetAdvFlyingAddImpulseMaxSpeedAck = 14936U,
		// Token: 0x0400535D RID: 21341
		MoveSetAdvFlyingAirFrictionAck = 14931U,
		// Token: 0x0400535E RID: 21342
		MoveSetAdvFlyingBankingRateAck = 14937U,
		// Token: 0x0400535F RID: 21343
		MoveSetAdvFlyingDoubleJumpVelModAck = 14934U,
		// Token: 0x04005360 RID: 21344
		MoveSetAdvFlyingGlideStartMinHeightAck,
		// Token: 0x04005361 RID: 21345
		MoveSetAdvFlyingLaunchSpeedCoefficientAck = 14944U,
		// Token: 0x04005362 RID: 21346
		MoveSetAdvFlyingLiftCoefficientAck = 14933U,
		// Token: 0x04005363 RID: 21347
		MoveSetAdvFlyingMaxVelAck = 14932U,
		// Token: 0x04005364 RID: 21348
		MoveSetAdvFlyingOverMaxDecelerationAck = 14942U,
		// Token: 0x04005365 RID: 21349
		MoveSetAdvFlyingPitchingRateDownAck = 14938U,
		// Token: 0x04005366 RID: 21350
		MoveSetAdvFlyingPitchingRateUpAck,
		// Token: 0x04005367 RID: 21351
		MoveSetAdvFlyingSurfaceFrictionAck = 14941U,
		// Token: 0x04005368 RID: 21352
		MoveSetAdvFlyingTurnVelocityThresholdAck = 14940U,
		// Token: 0x04005369 RID: 21353
		MoveSetCanAdvFlyAck = 14929U,
		// Token: 0x0400536A RID: 21354
		MoveSetCanFlyAck = 14887U,
		// Token: 0x0400536B RID: 21355
		MoveSetCanTurnWhileFallingAck = 14885U,
		// Token: 0x0400536C RID: 21356
		MoveSetCollisionHeightAck = 14907U,
		// Token: 0x0400536D RID: 21357
		MoveSetFacing = 14857U,
		// Token: 0x0400536E RID: 21358
		MoveSetFacingHeartbeat = 14943U,
		// Token: 0x0400536F RID: 21359
		MoveSetFly = 14888U,
		// Token: 0x04005370 RID: 21360
		MoveSetIgnoreMovementForcesAck = 14886U,
		// Token: 0x04005371 RID: 21361
		MoveSetModMovementForceMagnitudeAck = 14914U,
		// Token: 0x04005372 RID: 21362
		MoveSetPitch = 14858U,
		// Token: 0x04005373 RID: 21363
		MoveSetRunMode = 14834U,
		// Token: 0x04005374 RID: 21364
		MoveSetTurnRateCheat = 14854U,
		// Token: 0x04005375 RID: 21365
		MoveSetVehicleRecIdAck = 14868U,
		// Token: 0x04005376 RID: 21366
		MoveSetWalkMode = 14835U,
		// Token: 0x04005377 RID: 21367
		MoveSplineDone = 14872U,
		// Token: 0x04005378 RID: 21368
		MoveStartAscend = 14889U,
		// Token: 0x04005379 RID: 21369
		MoveStartBackward = 14821U,
		// Token: 0x0400537A RID: 21370
		MoveStartDescend = 14896U,
		// Token: 0x0400537B RID: 21371
		MoveStartForward = 14820U,
		// Token: 0x0400537C RID: 21372
		MoveStartPitchDown = 14832U,
		// Token: 0x0400537D RID: 21373
		MoveStartPitchUp = 14831U,
		// Token: 0x0400537E RID: 21374
		MoveStartStrafeLeft = 14823U,
		// Token: 0x0400537F RID: 21375
		MoveStartStrafeRight,
		// Token: 0x04005380 RID: 21376
		MoveStartSwim = 14844U,
		// Token: 0x04005381 RID: 21377
		MoveStartTurnLeft = 14828U,
		// Token: 0x04005382 RID: 21378
		MoveStartTurnRight,
		// Token: 0x04005383 RID: 21379
		MoveStop = 14822U,
		// Token: 0x04005384 RID: 21380
		MoveStopAscend = 14890U,
		// Token: 0x04005385 RID: 21381
		MoveStopPitch = 14833U,
		// Token: 0x04005386 RID: 21382
		MoveStopStrafe = 14825U,
		// Token: 0x04005387 RID: 21383
		MoveStopSwim = 14845U,
		// Token: 0x04005388 RID: 21384
		MoveStopTurn = 14830U,
		// Token: 0x04005389 RID: 21385
		MoveTeleportAck = 14842U,
		// Token: 0x0400538A RID: 21386
		MoveTimeSkipped = 14875U,
		// Token: 0x0400538B RID: 21387
		MoveUpdateFallSpeed = 14874U,
		// Token: 0x0400538C RID: 21388
		MoveWaterWalkAck = 14877U,
		// Token: 0x0400538D RID: 21389
		MythicPlusRequestMapStats = 12430U,
		// Token: 0x0400538E RID: 21390
		NeutralPlayerSelectFaction = 12757U,
		// Token: 0x0400538F RID: 21391
		NextCinematicCamera = 13655U,
		// Token: 0x04005390 RID: 21392
		ObjectUpdateFailed = 12673U,
		// Token: 0x04005391 RID: 21393
		ObjectUpdateRescued,
		// Token: 0x04005392 RID: 21394
		OfferPetition = 13272U,
		// Token: 0x04005393 RID: 21395
		OpeningCinematic = 13654U,
		// Token: 0x04005394 RID: 21396
		OpenItem = 13132U,
		// Token: 0x04005395 RID: 21397
		OpenMissionNpc = 13071U,
		// Token: 0x04005396 RID: 21398
		OpenShipmentNpc = 13079U,
		// Token: 0x04005397 RID: 21399
		OpenTradeskillNpc = 13090U,
		// Token: 0x04005398 RID: 21400
		OptOutOfLoot = 13572U,
		// Token: 0x04005399 RID: 21401
		OverrideScreenFlash = 13614U,
		// Token: 0x0400539A RID: 21402
		PartyInvite = 13826U,
		// Token: 0x0400539B RID: 21403
		PartyInviteResponse = 13828U,
		// Token: 0x0400539C RID: 21404
		PartyUninvite = 13893U,
		// Token: 0x0400539D RID: 21405
		PerformItemInteraction = 12858U,
		// Token: 0x0400539E RID: 21406
		PerksProgramRequestPendingRewards = 12602U,
		// Token: 0x0400539F RID: 21407
		PerksProgramRequestPurchase = 13312U,
		// Token: 0x040053A0 RID: 21408
		PerksProgramRequestRefund,
		// Token: 0x040053A1 RID: 21409
		PerksProgramSetFrozenVendorItem,
		// Token: 0x040053A2 RID: 21410
		PerksProgramStatusRequest = 13311U,
		// Token: 0x040053A3 RID: 21411
		PetitionBuy = 13519U,
		// Token: 0x040053A4 RID: 21412
		PetitionRenameGuild = 14021U,
		// Token: 0x040053A5 RID: 21413
		PetitionShowList = 13518U,
		// Token: 0x040053A6 RID: 21414
		PetitionShowSignatures = 13520U,
		// Token: 0x040053A7 RID: 21415
		PetAbandon = 13459U,
		// Token: 0x040053A8 RID: 21416
		PetAction = 13457U,
		// Token: 0x040053A9 RID: 21417
		PetBattleFinalNotify = 12772U,
		// Token: 0x040053AA RID: 21418
		PetBattleInput = 13887U,
		// Token: 0x040053AB RID: 21419
		PetBattleQueueProposeMatchResult = 12847U,
		// Token: 0x040053AC RID: 21420
		PetBattleQuitNotify = 12771U,
		// Token: 0x040053AD RID: 21421
		PetBattleReplaceFrontPet = 13888U,
		// Token: 0x040053AE RID: 21422
		PetBattleRequestPvp = 12765U,
		// Token: 0x040053AF RID: 21423
		PetBattleRequestUpdate,
		// Token: 0x040053B0 RID: 21424
		PetBattleRequestWild = 12763U,
		// Token: 0x040053B1 RID: 21425
		PetBattleScriptErrorNotify = 12773U,
		// Token: 0x040053B2 RID: 21426
		PetBattleWildLocationFail = 12764U,
		// Token: 0x040053B3 RID: 21427
		PetCancelAura = 13460U,
		// Token: 0x040053B4 RID: 21428
		PetCastSpell = 12979U,
		// Token: 0x040053B5 RID: 21429
		PetRename = 13954U,
		// Token: 0x040053B6 RID: 21430
		PetSetAction = 13456U,
		// Token: 0x040053B7 RID: 21431
		PetSpellAutocast = 13461U,
		// Token: 0x040053B8 RID: 21432
		PetStopAttack = 13458U,
		// Token: 0x040053B9 RID: 21433
		Ping = 14184U,
		// Token: 0x040053BA RID: 21434
		PlayerLogin = 13802U,
		// Token: 0x040053BB RID: 21435
		PushQuestToParty = 13477U,
		// Token: 0x040053BC RID: 21436
		PvpLogData = 12668U,
		// Token: 0x040053BD RID: 21437
		QueryBattlePetName = 12938U,
		// Token: 0x040053BE RID: 21438
		QueryCorpseLocationFromClient = 13918U,
		// Token: 0x040053BF RID: 21439
		QueryCorpseTransport,
		// Token: 0x040053C0 RID: 21440
		QueryCountdownTimer = 12714U,
		// Token: 0x040053C1 RID: 21441
		QueryCreature = 12932U,
		// Token: 0x040053C2 RID: 21442
		QueryGameObject,
		// Token: 0x040053C3 RID: 21443
		QueryGarrisonPetName = 12939U,
		// Token: 0x040053C4 RID: 21444
		QueryGuildInfo = 13960U,
		// Token: 0x040053C5 RID: 21445
		QueryInspectAchievements = 13582U,
		// Token: 0x040053C6 RID: 21446
		QueryNextMailTime = 13644U,
		// Token: 0x040053C7 RID: 21447
		QueryNpcText = 12934U,
		// Token: 0x040053C8 RID: 21448
		QueryPageText = 12936U,
		// Token: 0x040053C9 RID: 21449
		QueryPetition = 12940U,
		// Token: 0x040053CA RID: 21450
		QueryPetName = 12937U,
		// Token: 0x040053CB RID: 21451
		QueryPlayerNames = 14194U,
		// Token: 0x040053CC RID: 21452
		QueryPlayerNamesForCommunity = 14192U,
		// Token: 0x040053CD RID: 21453
		QueryPlayerNameByCommunityId = 14191U,
		// Token: 0x040053CE RID: 21454
		QueryQuestCompletionNpcs = 12661U,
		// Token: 0x040053CF RID: 21455
		QueryQuestInfo = 12935U,
		// Token: 0x040053D0 RID: 21456
		QueryQuestItemUsability = 12662U,
		// Token: 0x040053D1 RID: 21457
		QueryRealmName = 13959U,
		// Token: 0x040053D2 RID: 21458
		QueryScenarioPoi = 13908U,
		// Token: 0x040053D3 RID: 21459
		QueryTime = 13539U,
		// Token: 0x040053D4 RID: 21460
		QueryTreasurePicker = 13168U,
		// Token: 0x040053D5 RID: 21461
		QueryVoidStorage = 12707U,
		// Token: 0x040053D6 RID: 21462
		QuestConfirmAccept = 13476U,
		// Token: 0x040053D7 RID: 21463
		QuestGiverAcceptQuest = 13470U,
		// Token: 0x040053D8 RID: 21464
		QuestGiverChooseReward = 13472U,
		// Token: 0x040053D9 RID: 21465
		QuestGiverCloseQuest = 13661U,
		// Token: 0x040053DA RID: 21466
		QuestGiverCompleteQuest = 13471U,
		// Token: 0x040053DB RID: 21467
		QuestGiverHello = 13468U,
		// Token: 0x040053DC RID: 21468
		QuestGiverQueryQuest,
		// Token: 0x040053DD RID: 21469
		QuestGiverRequestReward = 13473U,
		// Token: 0x040053DE RID: 21470
		QuestGiverStatusMultipleQuery = 13475U,
		// Token: 0x040053DF RID: 21471
		QuestGiverStatusQuery = 13474U,
		// Token: 0x040053E0 RID: 21472
		QuestGiverStatusTrackedQuery = 13711U,
		// Token: 0x040053E1 RID: 21473
		QuestLogRemoveQuest = 13633U,
		// Token: 0x040053E2 RID: 21474
		QuestPoiQuery = 13996U,
		// Token: 0x040053E3 RID: 21475
		QuestPushResult = 13478U,
		// Token: 0x040053E4 RID: 21476
		QuestSessionBeginResponse = 13257U,
		// Token: 0x040053E5 RID: 21477
		QuestSessionRequestStart = 13256U,
		// Token: 0x040053E6 RID: 21478
		QuestSessionRequestStop = 14121U,
		// Token: 0x040053E7 RID: 21479
		QueuedMessagesEnd = 14188U,
		// Token: 0x040053E8 RID: 21480
		QuickJoinAutoAcceptRequests = 14082U,
		// Token: 0x040053E9 RID: 21481
		QuickJoinRequestInvite = 14081U,
		// Token: 0x040053EA RID: 21482
		QuickJoinRequestInviteWithConfirmation = 14126U,
		// Token: 0x040053EB RID: 21483
		QuickJoinRespondToInvite = 14080U,
		// Token: 0x040053EC RID: 21484
		QuickJoinSignalToastDisplayed = 14079U,
		// Token: 0x040053ED RID: 21485
		RafClaimActivityReward = 13586U,
		// Token: 0x040053EE RID: 21486
		RafClaimNextReward = 14111U,
		// Token: 0x040053EF RID: 21487
		RafGenerateRecruitmentLink = 14113U,
		// Token: 0x040053F0 RID: 21488
		RafUpdateRecruitmentInfo = 14112U,
		// Token: 0x040053F1 RID: 21489
		RandomRoll = 13906U,
		// Token: 0x040053F2 RID: 21490
		ReadyCheckResponse = 13875U,
		// Token: 0x040053F3 RID: 21491
		ReadItem = 13133U,
		// Token: 0x040053F4 RID: 21492
		ReclaimCorpse = 13545U,
		// Token: 0x040053F5 RID: 21493
		RemoveNewItem = 13171U,
		// Token: 0x040053F6 RID: 21494
		RemoveRafRecruit = 14114U,
		// Token: 0x040053F7 RID: 21495
		ReorderCharacters = 13801U,
		// Token: 0x040053F8 RID: 21496
		RepairItem = 13562U,
		// Token: 0x040053F9 RID: 21497
		ReplaceTrophy = 13102U,
		// Token: 0x040053FA RID: 21498
		RepopRequest = 13625U,
		// Token: 0x040053FB RID: 21499
		ReportClientVariables = 14076U,
		// Token: 0x040053FC RID: 21500
		ReportEnabledAddons = 14075U,
		// Token: 0x040053FD RID: 21501
		ReportFrozenWhileLoadingMap = 13988U,
		// Token: 0x040053FE RID: 21502
		ReportKeybindingExecutionCounts = 14077U,
		// Token: 0x040053FF RID: 21503
		ReportPvpPlayerAfk = 13570U,
		// Token: 0x04005400 RID: 21504
		ReportServerLag = 13249U,
		// Token: 0x04005401 RID: 21505
		ReportStuckInCombat,
		// Token: 0x04005402 RID: 21506
		RequestAccountData = 13970U,
		// Token: 0x04005403 RID: 21507
		RequestAreaPoiUpdate = 13170U,
		// Token: 0x04005404 RID: 21508
		RequestBattlefieldStatus = 13788U,
		// Token: 0x04005405 RID: 21509
		RequestCategoryCooldowns = 12670U,
		// Token: 0x04005406 RID: 21510
		RequestCemeteryList = 12663U,
		// Token: 0x04005407 RID: 21511
		RequestCharacterGuildFollowInfo = 13961U,
		// Token: 0x04005408 RID: 21512
		RequestConquestFormulaConstants = 13008U,
		// Token: 0x04005409 RID: 21513
		RequestCovenantCallings = 13235U,
		// Token: 0x0400540A RID: 21514
		RequestCrowdControlSpell = 13629U,
		// Token: 0x0400540B RID: 21515
		RequestForcedReactions = 12814U,
		// Token: 0x0400540C RID: 21516
		RequestGarrisonTalentWorldQuestUnlocks = 13293U,
		// Token: 0x0400540D RID: 21517
		RequestGuildPartyState = 12713U,
		// Token: 0x0400540E RID: 21518
		RequestGuildRewardsList = 12712U,
		// Token: 0x0400540F RID: 21519
		RequestLatestSplashScreen = 13251U,
		// Token: 0x04005410 RID: 21520
		RequestLfgListBlacklist = 12991U,
		// Token: 0x04005411 RID: 21521
		RequestMythicPlusAffixes = 12808U,
		// Token: 0x04005412 RID: 21522
		RequestMythicPlusSeasonData,
		// Token: 0x04005413 RID: 21523
		RequestPartyJoinUpdates = 13815U,
		// Token: 0x04005414 RID: 21524
		RequestPartyMemberStats = 13905U,
		// Token: 0x04005415 RID: 21525
		RequestPetInfo = 13462U,
		// Token: 0x04005416 RID: 21526
		RequestPlayedTime = 12943U,
		// Token: 0x04005417 RID: 21527
		RequestPvpRewards = 12694U,
		// Token: 0x04005418 RID: 21528
		RequestRaidInfo = 14022U,
		// Token: 0x04005419 RID: 21529
		RequestRatedPvpInfo = 13795U,
		// Token: 0x0400541A RID: 21530
		RequestRealmGuildMasterInfo = 12442U,
		// Token: 0x0400541B RID: 21531
		RequestResearchHistory = 12647U,
		// Token: 0x0400541C RID: 21532
		RequestScheduledPvpInfo = 12695U,
		// Token: 0x0400541D RID: 21533
		RequestStabledPets = 13463U,
		// Token: 0x0400541E RID: 21534
		RequestVehicleExit = 12868U,
		// Token: 0x0400541F RID: 21535
		RequestVehicleNextSeat = 12870U,
		// Token: 0x04005420 RID: 21536
		RequestVehiclePrevSeat = 12869U,
		// Token: 0x04005421 RID: 21537
		RequestVehicleSwitchSeat = 12871U,
		// Token: 0x04005422 RID: 21538
		RequestWeeklyRewards = 13238U,
		// Token: 0x04005423 RID: 21539
		RequestWorldQuestUpdate = 13169U,
		// Token: 0x04005424 RID: 21540
		ResetChallengeMode = 12806U,
		// Token: 0x04005425 RID: 21541
		ResetChallengeModeCheat,
		// Token: 0x04005426 RID: 21542
		ResetInstances = 13926U,
		// Token: 0x04005427 RID: 21543
		ResurrectResponse = 13953U,
		// Token: 0x04005428 RID: 21544
		RevertMonumentAppearance = 13104U,
		// Token: 0x04005429 RID: 21545
		RideVehicleInteract = 12872U,
		// Token: 0x0400542A RID: 21546
		SaveCufProfiles = 12684U,
		// Token: 0x0400542B RID: 21547
		SaveEquipmentSet = 13592U,
		// Token: 0x0400542C RID: 21548
		SaveGuildEmblem = 12995U,
		// Token: 0x0400542D RID: 21549
		ScenePlaybackCanceled = 12843U,
		// Token: 0x0400542E RID: 21550
		ScenePlaybackComplete = 12842U,
		// Token: 0x0400542F RID: 21551
		SceneTriggerEvent = 12844U,
		// Token: 0x04005430 RID: 21552
		SelfRes = 13636U,
		// Token: 0x04005431 RID: 21553
		SellItem = 13480U,
		// Token: 0x04005432 RID: 21554
		SendCharacterClubInvitation = 14069U,
		// Token: 0x04005433 RID: 21555
		SendContactList = 14027U,
		// Token: 0x04005434 RID: 21556
		SendMail = 13818U,
		// Token: 0x04005435 RID: 21557
		SendTextEmote = 13454U,
		// Token: 0x04005436 RID: 21558
		ServerTimeOffsetRequest = 13977U,
		// Token: 0x04005437 RID: 21559
		SetAchievementsHidden = 12849U,
		// Token: 0x04005438 RID: 21560
		SetActionBarToggles = 13637U,
		// Token: 0x04005439 RID: 21561
		SetActionButton = 13876U,
		// Token: 0x0400543A RID: 21562
		SetActiveMover = 14908U,
		// Token: 0x0400543B RID: 21563
		SetAdvancedCombatLogging = 13009U,
		// Token: 0x0400543C RID: 21564
		SetAssistantLeader = 13901U,
		// Token: 0x0400543D RID: 21565
		SetBackpackAutosortDisabled = 13136U,
		// Token: 0x0400543E RID: 21566
		SetBankAutosortDisabled,
		// Token: 0x0400543F RID: 21567
		SetContactNotes = 14030U,
		// Token: 0x04005440 RID: 21568
		SetCurrencyFlags = 12649U,
		// Token: 0x04005441 RID: 21569
		SetDifficultyId = 12845U,
		// Token: 0x04005442 RID: 21570
		SetDungeonDifficulty = 13952U,
		// Token: 0x04005443 RID: 21571
		SetEmpowerMinHoldStagePercent = 12926U,
		// Token: 0x04005444 RID: 21572
		SetEveryoneIsAssistant = 13848U,
		// Token: 0x04005445 RID: 21573
		SetFactionAtWar = 13548U,
		// Token: 0x04005446 RID: 21574
		SetFactionInactive = 13550U,
		// Token: 0x04005447 RID: 21575
		SetFactionNotAtWar = 13549U,
		// Token: 0x04005448 RID: 21576
		SetGameEventDebugViewState = 12730U,
		// Token: 0x04005449 RID: 21577
		SetInsertItemsLeftToRight = 13139U,
		// Token: 0x0400544A RID: 21578
		SetLootMethod = 13894U,
		// Token: 0x0400544B RID: 21579
		SetLootSpecialization = 13650U,
		// Token: 0x0400544C RID: 21580
		SetPartyAssignment = 13903U,
		// Token: 0x0400544D RID: 21581
		SetPartyLeader = 13896U,
		// Token: 0x0400544E RID: 21582
		SetPetSlot = 12648U,
		// Token: 0x0400544F RID: 21583
		SetPlayerDeclinedNames = 13958U,
		// Token: 0x04005450 RID: 21584
		SetPreferredCemetery = 12664U,
		// Token: 0x04005451 RID: 21585
		SetPvp = 12999U,
		// Token: 0x04005452 RID: 21586
		SetRaidDifficulty = 14039U,
		// Token: 0x04005453 RID: 21587
		SetRole = 13785U,
		// Token: 0x04005454 RID: 21588
		SetSavedInstanceExtend = 13956U,
		// Token: 0x04005455 RID: 21589
		SetSelection = 13627U,
		// Token: 0x04005456 RID: 21590
		SetSheathed = 13455U,
		// Token: 0x04005457 RID: 21591
		SetSortBagsRightToLeft = 13138U,
		// Token: 0x04005458 RID: 21592
		SetTaxiBenchmarkMode = 13569U,
		// Token: 0x04005459 RID: 21593
		SetTitle = 12949U,
		// Token: 0x0400545A RID: 21594
		SetTradeCurrency = 12640U,
		// Token: 0x0400545B RID: 21595
		SetTradeGold = 12639U,
		// Token: 0x0400545C RID: 21596
		SetTradeItem = 12637U,
		// Token: 0x0400545D RID: 21597
		SetUsingPartyGarrison = 13073U,
		// Token: 0x0400545E RID: 21598
		SetWarMode = 13000U,
		// Token: 0x0400545F RID: 21599
		SetWatchedFaction = 13551U,
		// Token: 0x04005460 RID: 21600
		ShowTradeSkill = 14014U,
		// Token: 0x04005461 RID: 21601
		SignPetition = 13638U,
		// Token: 0x04005462 RID: 21602
		SilencePartyTalker = 13904U,
		// Token: 0x04005463 RID: 21603
		SocialContractRequest = 14139U,
		// Token: 0x04005464 RID: 21604
		SocketGems = 13561U,
		// Token: 0x04005465 RID: 21605
		SortBags = 13140U,
		// Token: 0x04005466 RID: 21606
		SortBankBags,
		// Token: 0x04005467 RID: 21607
		SortReagentBankBags,
		// Token: 0x04005468 RID: 21608
		SpellClick = 13467U,
		// Token: 0x04005469 RID: 21609
		SpellEmpowerRelease = 12924U,
		// Token: 0x0400546A RID: 21610
		SpellEmpowerRestart,
		// Token: 0x0400546B RID: 21611
		SpiritHealerActivate = 13493U,
		// Token: 0x0400546C RID: 21612
		SplitGuildBankItem = 13512U,
		// Token: 0x0400546D RID: 21613
		SplitGuildBankItemToInventory = 13509U,
		// Token: 0x0400546E RID: 21614
		SplitItem = 14750U,
		// Token: 0x0400546F RID: 21615
		SplitItemToGuildBank = 13507U,
		// Token: 0x04005470 RID: 21616
		StandStateChange = 12682U,
		// Token: 0x04005471 RID: 21617
		StartChallengeMode = 13662U,
		// Token: 0x04005472 RID: 21618
		StartSpectatorWarGame = 13791U,
		// Token: 0x04005473 RID: 21619
		StartWarGame = 13790U,
		// Token: 0x04005474 RID: 21620
		StoreGuildBankItem = 13502U,
		// Token: 0x04005475 RID: 21621
		SubmitUserFeedback = 13969U,
		// Token: 0x04005476 RID: 21622
		SubscriptionInterstitialResponse = 13282U,
		// Token: 0x04005477 RID: 21623
		SummonResponse = 13928U,
		// Token: 0x04005478 RID: 21624
		SupportTicketSubmitComplaint = 13892U,
		// Token: 0x04005479 RID: 21625
		SurrenderArena = 12660U,
		// Token: 0x0400547A RID: 21626
		SuspendCommsAck = 14180U,
		// Token: 0x0400547B RID: 21627
		SuspendTokenResponse = 14186U,
		// Token: 0x0400547C RID: 21628
		SwapGuildBankItemWithGuildBankItem = 13504U,
		// Token: 0x0400547D RID: 21629
		SwapInvItem = 14749U,
		// Token: 0x0400547E RID: 21630
		SwapItem = 14748U,
		// Token: 0x0400547F RID: 21631
		SwapItemWithGuildBankItem = 13503U,
		// Token: 0x04005480 RID: 21632
		SwapSubGroups = 13899U,
		// Token: 0x04005481 RID: 21633
		SwapVoidItem = 12709U,
		// Token: 0x04005482 RID: 21634
		TabardVendorActivate = 12996U,
		// Token: 0x04005483 RID: 21635
		TalkToGossip = 13464U,
		// Token: 0x04005484 RID: 21636
		TaxiNodeStatusQuery = 13486U,
		// Token: 0x04005485 RID: 21637
		TaxiQueryAvailableNodes = 13488U,
		// Token: 0x04005486 RID: 21638
		TaxiRequestEarlyLanding = 13490U,
		// Token: 0x04005487 RID: 21639
		TimeAdjustmentResponse = 14912U,
		// Token: 0x04005488 RID: 21640
		TimeSyncResponse = 14909U,
		// Token: 0x04005489 RID: 21641
		TimeSyncResponseDropped = 14911U,
		// Token: 0x0400548A RID: 21642
		TimeSyncResponseFailed = 14910U,
		// Token: 0x0400548B RID: 21643
		ToggleDifficulty = 13909U,
		// Token: 0x0400548C RID: 21644
		TogglePvp = 12998U,
		// Token: 0x0400548D RID: 21645
		TotemDestroyed = 13574U,
		// Token: 0x0400548E RID: 21646
		ToyClearFanfare = 12589U,
		// Token: 0x0400548F RID: 21647
		TradeSkillSetFavorite = 13167U,
		// Token: 0x04005490 RID: 21648
		TrainerBuySpell = 13492U,
		// Token: 0x04005491 RID: 21649
		TrainerList = 13491U,
		// Token: 0x04005492 RID: 21650
		TraitsCommitConfig = 13320U,
		// Token: 0x04005493 RID: 21651
		TraitsTalentTestUnlearnSpells = 13318U,
		// Token: 0x04005494 RID: 21652
		TransmogrifyItems = 12696U,
		// Token: 0x04005495 RID: 21653
		TurnInPetition = 13640U,
		// Token: 0x04005496 RID: 21654
		Tutorial = 14040U,
		// Token: 0x04005497 RID: 21655
		TwitterCheckStatus = 12585U,
		// Token: 0x04005498 RID: 21656
		TwitterConnect = 12582U,
		// Token: 0x04005499 RID: 21657
		TwitterDisconnect = 12586U,
		// Token: 0x0400549A RID: 21658
		UiMapQuestLinesRequest = 13234U,
		// Token: 0x0400549B RID: 21659
		UnacceptTrade = 12635U,
		// Token: 0x0400549C RID: 21660
		UndeleteCharacter = 14042U,
		// Token: 0x0400549D RID: 21661
		UnlearnSkill = 13555U,
		// Token: 0x0400549E RID: 21662
		UnlearnSpecialization = 12710U,
		// Token: 0x0400549F RID: 21663
		UnlockVoidStorage = 12706U,
		// Token: 0x040054A0 RID: 21664
		UpdateAadcStatus = 14133U,
		// Token: 0x040054A1 RID: 21665
		UpdateAccountData = 13971U,
		// Token: 0x040054A2 RID: 21666
		UpdateAreaTriggerVisual = 12982U,
		// Token: 0x040054A3 RID: 21667
		UpdateClientSettings = 13922U,
		// Token: 0x040054A4 RID: 21668
		UpdateCraftingNpcRecipes = 13091U,
		// Token: 0x040054A5 RID: 21669
		UpdateMissileTrajectory = 14915U,
		// Token: 0x040054A6 RID: 21670
		UpdateRaidTarget = 13902U,
		// Token: 0x040054A7 RID: 21671
		UpdateSpellVisual = 12981U,
		// Token: 0x040054A8 RID: 21672
		UpdateVasPurchaseStates = 14063U,
		// Token: 0x040054A9 RID: 21673
		UpgradeGarrison = 13017U,
		// Token: 0x040054AA RID: 21674
		UpgradeRuneforgeLegendary = 13280U,
		// Token: 0x040054AB RID: 21675
		UsedFollow = 12679U,
		// Token: 0x040054AC RID: 21676
		UseCritterItem = 12878U,
		// Token: 0x040054AD RID: 21677
		UseEquipmentSet = 14741U,
		// Token: 0x040054AE RID: 21678
		UseItem = 12975U,
		// Token: 0x040054AF RID: 21679
		UseToy = 12978U,
		// Token: 0x040054B0 RID: 21680
		VasCheckTransferOk = 14087U,
		// Token: 0x040054B1 RID: 21681
		VasGetQueueMinutes = 14086U,
		// Token: 0x040054B2 RID: 21682
		VasGetServiceStatus = 14085U,
		// Token: 0x040054B3 RID: 21683
		ViolenceLevel = 12677U,
		// Token: 0x040054B4 RID: 21684
		VoiceChannelSttTokenRequest = 14091U,
		// Token: 0x040054B5 RID: 21685
		VoiceChatJoinChannel,
		// Token: 0x040054B6 RID: 21686
		VoiceChatLogin = 14090U,
		// Token: 0x040054B7 RID: 21687
		VoidStorageTransfer = 12708U,
		// Token: 0x040054B8 RID: 21688
		Warden3Data = 13804U,
		// Token: 0x040054B9 RID: 21689
		Who = 13951U,
		// Token: 0x040054BA RID: 21690
		WhoIs = 13950U,
		// Token: 0x040054BB RID: 21691
		WorldPortResponse = 13817U,
		// Token: 0x040054BC RID: 21692
		WrapItem = 14740U
	}
}
