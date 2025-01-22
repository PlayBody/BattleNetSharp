using System;

namespace D2Packets.Game.Server
{
	// Token: 0x020009BA RID: 2490
	public enum GameServerPacket : byte
	{
		// Token: 0x040089AA RID: 35242
		GameLoading,
		// Token: 0x040089AB RID: 35243
		GameLogonReceipt,
		// Token: 0x040089AC RID: 35244
		GameLogonSuccess,
		// Token: 0x040089AD RID: 35245
		LoadAct,
		// Token: 0x040089AE RID: 35246
		LoadDone,
		// Token: 0x040089AF RID: 35247
		UnloadDone,
		// Token: 0x040089B0 RID: 35248
		GameLogoutSuccess,
		// Token: 0x040089B1 RID: 35249
		MapAdd,
		// Token: 0x040089B2 RID: 35250
		MapRemove,
		// Token: 0x040089B3 RID: 35251
		AssignWarp,
		// Token: 0x040089B4 RID: 35252
		RemoveGroundUnit,
		// Token: 0x040089B5 RID: 35253
		GameHandshake,
		// Token: 0x040089B6 RID: 35254
		NPCGetHit,
		// Token: 0x040089B7 RID: 35255
		PlayerStop,
		// Token: 0x040089B8 RID: 35256
		SetGameObjectMode,
		// Token: 0x040089B9 RID: 35257
		PlayerMove,
		// Token: 0x040089BA RID: 35258
		PlayerMoveToTarget,
		// Token: 0x040089BB RID: 35259
		ReportKill,
		// Token: 0x040089BC RID: 35260
		PlayerReassign = 21,
		// Token: 0x040089BD RID: 35261
		PlayerLifeManaChangeRegen = 24,
		// Token: 0x040089BE RID: 35262
		SmallGoldAdd,
		// Token: 0x040089BF RID: 35263
		ExperienceByte,
		// Token: 0x040089C0 RID: 35264
		ExperienceUInt16,
		// Token: 0x040089C1 RID: 35265
		ExperienceUInt32,
		// Token: 0x040089C2 RID: 35266
		AttributeByte,
		// Token: 0x040089C3 RID: 35267
		AttributeWord,
		// Token: 0x040089C4 RID: 35268
		AttributeDWord,
		// Token: 0x040089C5 RID: 35269
		PlayerAttributeNotification,
		// Token: 0x040089C6 RID: 35270
		UpdateSkill,
		// Token: 0x040089C7 RID: 35271
		UpdatePlayerItemSkill,
		// Token: 0x040089C8 RID: 35272
		AssignSkill,
		// Token: 0x040089C9 RID: 35273
		GameMessage = 38,
		// Token: 0x040089CA RID: 35274
		NPCInfo,
		// Token: 0x040089CB RID: 35275
		UpdateQuestInfo,
		// Token: 0x040089CC RID: 35276
		UpdateGameQuestLog,
		// Token: 0x040089CD RID: 35277
		TransactionComplete,
		// Token: 0x040089CE RID: 35278
		Confirm,
		// Token: 0x040089CF RID: 35279
		PlaySound,
		// Token: 0x040089D0 RID: 35280
		TimestampResponse,
		// Token: 0x040089D1 RID: 35281
		TradeRequest,
		// Token: 0x040089D2 RID: 35282
		QuestComplete = 58,
		// Token: 0x040089D3 RID: 35283
		UpdateItemStats = 62,
		// Token: 0x040089D4 RID: 35284
		UseStackableItem,
		// Token: 0x040089D5 RID: 35285
		PlayerClearCursor = 66,
		// Token: 0x040089D6 RID: 35286
		Relator1 = 71,
		// Token: 0x040089D7 RID: 35287
		Relator2,
		// Token: 0x040089D8 RID: 35288
		Unk4a = 74,
		// Token: 0x040089D9 RID: 35289
		UnitUseSkillOnTarget = 76,
		// Token: 0x040089DA RID: 35290
		UnitUseSkill,
		// Token: 0x040089DB RID: 35291
		MercForHire,
		// Token: 0x040089DC RID: 35292
		MercForHireListStart,
		// Token: 0x040089DD RID: 35293
		Unk50,
		// Token: 0x040089DE RID: 35294
		AssignGameObject,
		// Token: 0x040089DF RID: 35295
		UpdateQuestLog,
		// Token: 0x040089E0 RID: 35296
		PartyRefresh,
		// Token: 0x040089E1 RID: 35297
		SummBook = 87,
		// Token: 0x040089E2 RID: 35298
		OpenUI,
		// Token: 0x040089E3 RID: 35299
		AssignPlayer,
		// Token: 0x040089E4 RID: 35300
		InformationMessage,
		// Token: 0x040089E5 RID: 35301
		PlayerInGame,
		// Token: 0x040089E6 RID: 35302
		PlayerLeaveGame,
		// Token: 0x040089E7 RID: 35303
		QuestItemState,
		// Token: 0x040089E8 RID: 35304
		UpdateQuestStatus,
		// Token: 0x040089E9 RID: 35305
		Unk5f,
		// Token: 0x040089EA RID: 35306
		PortalInfo,
		// Token: 0x040089EB RID: 35307
		ActChange,
		// Token: 0x040089EC RID: 35308
		OpenWaypoint = 99,
		// Token: 0x040089ED RID: 35309
		CurrentWaypoint,
		// Token: 0x040089EE RID: 35310
		PlayerKillCount,
		// Token: 0x040089EF RID: 35311
		NPCMove = 103,
		// Token: 0x040089F0 RID: 35312
		NPCMoveToTarget,
		// Token: 0x040089F1 RID: 35313
		SetNPCMode,
		// Token: 0x040089F2 RID: 35314
		NPCAction = 107,
		// Token: 0x040089F3 RID: 35315
		MonsterAttack,
		// Token: 0x040089F4 RID: 35316
		NPCStop,
		// Token: 0x040089F5 RID: 35317
		CreateMissile = 115,
		// Token: 0x040089F6 RID: 35318
		PlayerCorpseVisible,
		// Token: 0x040089F7 RID: 35319
		AboutPlayer,
		// Token: 0x040089F8 RID: 35320
		PlayerInSight,
		// Token: 0x040089F9 RID: 35321
		UpdateUI,
		// Token: 0x040089FA RID: 35322
		AcceptTrade,
		// Token: 0x040089FB RID: 35323
		GoldTrade,
		// Token: 0x040089FC RID: 35324
		SummonAction,
		// Token: 0x040089FD RID: 35325
		AssignSkillHotkey,
		// Token: 0x040089FE RID: 35326
		UseSpecialItem,
		// Token: 0x040089FF RID: 35327
		SetItemState,
		// Token: 0x04008A00 RID: 35328
		Unk7e,
		// Token: 0x04008A01 RID: 35329
		PartyMemberUpdate,
		// Token: 0x04008A02 RID: 35330
		AssignMerc = 129,
		// Token: 0x04008A03 RID: 35331
		PortalOwnership,
		// Token: 0x04008A04 RID: 35332
		Relator3,
		// Token: 0x04008A05 RID: 35333
		Relator4,
		// Token: 0x04008A06 RID: 35334
		Relator5,
		// Token: 0x04008A07 RID: 35335
		Relator6,
		// Token: 0x04008A08 RID: 35336
		UniqueEvents = 137,
		// Token: 0x04008A09 RID: 35337
		NPCWantsInteract,
		// Token: 0x04008A0A RID: 35338
		PlayerPartyRelationship,
		// Token: 0x04008A0B RID: 35339
		PlayerRelationship,
		// Token: 0x04008A0C RID: 35340
		AssignPlayerToParty,
		// Token: 0x04008A0D RID: 35341
		AssignPlayerCorpse,
		// Token: 0x04008A0E RID: 35342
		Pong,
		// Token: 0x04008A0F RID: 35343
		PartyMemberPulse,
		// Token: 0x04008A10 RID: 35344
		NPCIntro,
		// Token: 0x04008A11 RID: 35345
		RemoveItemsDisplay,
		// Token: 0x04008A12 RID: 35346
		SkillsLog = 148,
		// Token: 0x04008A13 RID: 35347
		PlayerLifeManaChange,
		// Token: 0x04008A14 RID: 35348
		WalkVerify,
		// Token: 0x04008A15 RID: 35349
		SwitchWeaponSet,
		// Token: 0x04008A16 RID: 35350
		ItemTriggerSkill = 153,
		// Token: 0x04008A17 RID: 35351
		MercCost = 155,
		// Token: 0x04008A18 RID: 35352
		WorldItemAction,
		// Token: 0x04008A19 RID: 35353
		OwnedItemAction,
		// Token: 0x04008A1A RID: 35354
		MercAttributeByte,
		// Token: 0x04008A1B RID: 35355
		MercAttributeUInt16,
		// Token: 0x04008A1C RID: 35356
		MercAttributeUInt32,
		// Token: 0x04008A1D RID: 35357
		MercByteToExperience,
		// Token: 0x04008A1E RID: 35358
		MercWordToExperience,
		// Token: 0x04008A1F RID: 35359
		BaalWaveClear = 164,
		// Token: 0x04008A20 RID: 35360
		StateSkillMove,
		// Token: 0x04008A21 RID: 35361
		DelayedState = 167,
		// Token: 0x04008A22 RID: 35362
		SetState,
		// Token: 0x04008A23 RID: 35363
		EndState,
		// Token: 0x04008A24 RID: 35364
		MultipleStates,
		// Token: 0x04008A25 RID: 35365
		NPCHeal,
		// Token: 0x04008A26 RID: 35366
		AssignNPC,
		// Token: 0x04008A27 RID: 35367
		NPCUpdate,
		// Token: 0x04008A28 RID: 35368
		WardenCheck,
		// Token: 0x04008A29 RID: 35369
		RequestLogonInfo,
		// Token: 0x04008A2A RID: 35370
		GameOver,
		// Token: 0x04008A2B RID: 35371
		Invalid,
		// Token: 0x04008A2C RID: 35372
		HostedGamesInfo,
		// Token: 0x04008A2D RID: 35373
		DownloadSave,
		// Token: 0x04008A2E RID: 35374
		ConnectionRefused,
		// Token: 0x04008A2F RID: 35375
		ConnectionSomething
	}
}
