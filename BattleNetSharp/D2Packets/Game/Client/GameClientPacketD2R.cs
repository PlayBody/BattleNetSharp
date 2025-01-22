using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A3B RID: 2619
	public enum GameClientPacketD2R : byte
	{
		// Token: 0x04008D55 RID: 36181
		WalkToLocation = 1,
		// Token: 0x04008D56 RID: 36182
		WalkToTarget,
		// Token: 0x04008D57 RID: 36183
		RunToLocation,
		// Token: 0x04008D58 RID: 36184
		RunToTarget,
		// Token: 0x04008D59 RID: 36185
		CastLeftSkill,
		// Token: 0x04008D5A RID: 36186
		CastLeftSkillOnTarget,
		// Token: 0x04008D5B RID: 36187
		CastLeftSkillOnTargetStopped,
		// Token: 0x04008D5C RID: 36188
		RecastLeftSkill,
		// Token: 0x04008D5D RID: 36189
		RecastLeftSkillOnTarget,
		// Token: 0x04008D5E RID: 36190
		RecastLeftSkillOnTargetStopped,
		// Token: 0x04008D5F RID: 36191
		CastRightSkill = 12,
		// Token: 0x04008D60 RID: 36192
		CastRightSkillOnTarget,
		// Token: 0x04008D61 RID: 36193
		CastRightSkillOnTargetStopped,
		// Token: 0x04008D62 RID: 36194
		RecastRightSkill,
		// Token: 0x04008D63 RID: 36195
		RecastRightSkillOnTarget,
		// Token: 0x04008D64 RID: 36196
		RecastRightSkillOnTargetStopped,
		// Token: 0x04008D65 RID: 36197
		UnitInteract = 19,
		// Token: 0x04008D66 RID: 36198
		SwapSharedStashItem,
		// Token: 0x04008D67 RID: 36199
		SendMessage,
		// Token: 0x04008D68 RID: 36200
		PickItem,
		// Token: 0x04008D69 RID: 36201
		DropItem,
		// Token: 0x04008D6A RID: 36202
		DropItemToContainer,
		// Token: 0x04008D6B RID: 36203
		PickItemFromContainer,
		// Token: 0x04008D6C RID: 36204
		EquipItem,
		// Token: 0x04008D6D RID: 36205
		SwapTwoHandedItem,
		// Token: 0x04008D6E RID: 36206
		UnequipItem,
		// Token: 0x04008D6F RID: 36207
		SwapEquippedItem,
		// Token: 0x04008D70 RID: 36208
		SwapTwoEquippedItems,
		// Token: 0x04008D71 RID: 36209
		SwapContainerItem,
		// Token: 0x04008D72 RID: 36210
		UseInventoryItem,
		// Token: 0x04008D73 RID: 36211
		StackItems,
		// Token: 0x04008D74 RID: 36212
		EquipSmallBelt,
		// Token: 0x04008D75 RID: 36213
		AddBeltItem,
		// Token: 0x04008D76 RID: 36214
		RemoveBeltItem,
		// Token: 0x04008D77 RID: 36215
		SwapBeltItem,
		// Token: 0x04008D78 RID: 36216
		UseItem,
		// Token: 0x04008D79 RID: 36217
		IdentifyItemGoldXfer,
		// Token: 0x04008D7A RID: 36218
		SocketItem,
		// Token: 0x04008D7B RID: 36219
		EmbedItem,
		// Token: 0x04008D7C RID: 36220
		ItemToCube,
		// Token: 0x04008D7D RID: 36221
		Trade,
		// Token: 0x04008D7E RID: 36222
		TradeConfirm,
		// Token: 0x04008D7F RID: 36223
		SocketQuest = 46,
		// Token: 0x04008D80 RID: 36224
		TownFolkInteract,
		// Token: 0x04008D81 RID: 36225
		TownFolkCancelInteraction,
		// Token: 0x04008D82 RID: 36226
		DisplayQuestMessage,
		// Token: 0x04008D83 RID: 36227
		BuyItem,
		// Token: 0x04008D84 RID: 36228
		SellItem,
		// Token: 0x04008D85 RID: 36229
		CainIdentifyItems,
		// Token: 0x04008D86 RID: 36230
		TownFolkRepair,
		// Token: 0x04008D87 RID: 36231
		HireMercenary,
		// Token: 0x04008D88 RID: 36232
		IdentifyGambleItemOrTravel,
		// Token: 0x04008D89 RID: 36233
		TownFolkMenuSelect,
		// Token: 0x04008D8A RID: 36234
		ResetCharacter,
		// Token: 0x04008D8B RID: 36235
		IncrementAttribute,
		// Token: 0x04008D8C RID: 36236
		IncrementSkill,
		// Token: 0x04008D8D RID: 36237
		SelectSkill,
		// Token: 0x04008D8E RID: 36238
		SendCharacterSpeech,
		// Token: 0x04008D8F RID: 36239
		RequestQuestLog,
		// Token: 0x04008D90 RID: 36240
		Respawn,
		// Token: 0x04008D91 RID: 36241
		WarpInteract,
		// Token: 0x04008D92 RID: 36242
		Interact,
		// Token: 0x04008D93 RID: 36243
		RequestReassign = 67,
		// Token: 0x04008D94 RID: 36244
		WaypointTravelPutSharedStash = 69,
		// Token: 0x04008D95 RID: 36245
		PickItemFromSharedStash,
		// Token: 0x04008D96 RID: 36246
		DropGold,
		// Token: 0x04008D97 RID: 36247
		SetSkillHotkey,
		// Token: 0x04008D98 RID: 36248
		Transmog,
		// Token: 0x04008D99 RID: 36249
		WaypointInteract = 75,
		// Token: 0x04008D9A RID: 36250
		GoToTownFolk = 77,
		// Token: 0x04008D9B RID: 36251
		PlayNpcMsg,
		// Token: 0x04008D9C RID: 36252
		SortContainer = 78,
		// Token: 0x04008D9D RID: 36253
		PartyRequest,
		// Token: 0x04008D9E RID: 36254
		SwitchWeapons,
		// Token: 0x04008D9F RID: 36255
		ChangeMercEquipment,
		// Token: 0x04008DA0 RID: 36256
		ResurrectMerc,
		// Token: 0x04008DA1 RID: 36257
		InventoryItemToBelt,
		// Token: 0x04008DA2 RID: 36258
		SwitchItemStashInventory,
		// Token: 0x04008DA3 RID: 36259
		SwitchItemShared,
		// Token: 0x04008DA4 RID: 36260
		EquipItemSwap = 89,
		// Token: 0x04008DA5 RID: 36261
		DropItemFromContainer = 92,
		// Token: 0x04008DA6 RID: 36262
		MovePotFromBelt = 94,
		// Token: 0x04008DA7 RID: 36263
		ClickButton = 159,
		// Token: 0x04008DA8 RID: 36264
		WaypointOpen,
		// Token: 0x04008DA9 RID: 36265
		CloseQuest = 88,
		// Token: 0x04008DAA RID: 36266
		SetPlayerRelation = 93,
		// Token: 0x04008DAB RID: 36267
		UpdatePosition,
		// Token: 0x04008DAC RID: 36268
		WardenResponse = 102,
		// Token: 0x04008DAD RID: 36269
		splogon,
		// Token: 0x04008DAE RID: 36270
		TownFolkRepair2 = 103,
		// Token: 0x04008DAF RID: 36271
		GameLogonRequest,
		// Token: 0x04008DB0 RID: 36272
		ExitGame,
		// Token: 0x04008DB1 RID: 36273
		RequestHostedGames,
		// Token: 0x04008DB2 RID: 36274
		EnterGame,
		// Token: 0x04008DB3 RID: 36275
		UploadSave,
		// Token: 0x04008DB4 RID: 36276
		Ping,
		// Token: 0x04008DB5 RID: 36277
		Invalid,
		// Token: 0x04008DB6 RID: 36278
		Timestamp
	}
}
