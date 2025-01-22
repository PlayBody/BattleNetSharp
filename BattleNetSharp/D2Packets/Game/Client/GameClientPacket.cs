using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A3A RID: 2618
	public enum GameClientPacket : byte
	{
		// Token: 0x04008CF1 RID: 36081
		WalkToLocation = 1,
		// Token: 0x04008CF2 RID: 36082
		WalkToTarget,
		// Token: 0x04008CF3 RID: 36083
		RunToLocation,
		// Token: 0x04008CF4 RID: 36084
		RunToTarget,
		// Token: 0x04008CF5 RID: 36085
		CastLeftSkill,
		// Token: 0x04008CF6 RID: 36086
		CastLeftSkillOnTarget,
		// Token: 0x04008CF7 RID: 36087
		CastLeftSkillOnTargetStopped,
		// Token: 0x04008CF8 RID: 36088
		RecastLeftSkill,
		// Token: 0x04008CF9 RID: 36089
		RecastLeftSkillOnTarget,
		// Token: 0x04008CFA RID: 36090
		RecastLeftSkillOnTargetStopped,
		// Token: 0x04008CFB RID: 36091
		CastRightSkill = 12,
		// Token: 0x04008CFC RID: 36092
		CastRightSkillOnTarget,
		// Token: 0x04008CFD RID: 36093
		CastRightSkillOnTargetStopped,
		// Token: 0x04008CFE RID: 36094
		RecastRightSkill,
		// Token: 0x04008CFF RID: 36095
		RecastRightSkillOnTarget,
		// Token: 0x04008D00 RID: 36096
		RecastRightSkillOnTargetStopped,
		// Token: 0x04008D01 RID: 36097
		UnitInteract = 19,
		// Token: 0x04008D02 RID: 36098
		SendOverheadMessage,
		// Token: 0x04008D03 RID: 36099
		SendMessage,
		// Token: 0x04008D04 RID: 36100
		PickItem,
		// Token: 0x04008D05 RID: 36101
		DropItem,
		// Token: 0x04008D06 RID: 36102
		DropItemToContainer,
		// Token: 0x04008D07 RID: 36103
		PickItemFromContainer,
		// Token: 0x04008D08 RID: 36104
		EquipItem,
		// Token: 0x04008D09 RID: 36105
		SwapTwoHandedItem,
		// Token: 0x04008D0A RID: 36106
		UnequipItem,
		// Token: 0x04008D0B RID: 36107
		SwapEquippedItem,
		// Token: 0x04008D0C RID: 36108
		SwapTwoEquippedItems,
		// Token: 0x04008D0D RID: 36109
		SwapContainerItem,
		// Token: 0x04008D0E RID: 36110
		UseInventoryItem,
		// Token: 0x04008D0F RID: 36111
		StackItems,
		// Token: 0x04008D10 RID: 36112
		EquipSmallBelt,
		// Token: 0x04008D11 RID: 36113
		AddBeltItem,
		// Token: 0x04008D12 RID: 36114
		RemoveBeltItem,
		// Token: 0x04008D13 RID: 36115
		SwapBeltItem,
		// Token: 0x04008D14 RID: 36116
		UseItem,
		// Token: 0x04008D15 RID: 36117
		IdentifyItemGoldXfer,
		// Token: 0x04008D16 RID: 36118
		SocketItem,
		// Token: 0x04008D17 RID: 36119
		EmbedItem,
		// Token: 0x04008D18 RID: 36120
		ItemToCube,
		// Token: 0x04008D19 RID: 36121
		Trade,
		// Token: 0x04008D1A RID: 36122
		TradeConfirm,
		// Token: 0x04008D1B RID: 36123
		SocketQuest = 46,
		// Token: 0x04008D1C RID: 36124
		TownFolkInteract,
		// Token: 0x04008D1D RID: 36125
		TownFolkCancelInteraction,
		// Token: 0x04008D1E RID: 36126
		DisplayQuestMessage,
		// Token: 0x04008D1F RID: 36127
		BuyItem,
		// Token: 0x04008D20 RID: 36128
		SellItem,
		// Token: 0x04008D21 RID: 36129
		CainIdentifyItems,
		// Token: 0x04008D22 RID: 36130
		TownFolkRepair,
		// Token: 0x04008D23 RID: 36131
		HireMercenary,
		// Token: 0x04008D24 RID: 36132
		IdentifyGambleItemOrTravel,
		// Token: 0x04008D25 RID: 36133
		TownFolkMenuSelect,
		// Token: 0x04008D26 RID: 36134
		ResetCharacter,
		// Token: 0x04008D27 RID: 36135
		IncrementAttribute,
		// Token: 0x04008D28 RID: 36136
		IncrementSkill,
		// Token: 0x04008D29 RID: 36137
		SelectSkill,
		// Token: 0x04008D2A RID: 36138
		HoverUnit,
		// Token: 0x04008D2B RID: 36139
		ScrollOfInifuss,
		// Token: 0x04008D2C RID: 36140
		SendCharacterSpeech,
		// Token: 0x04008D2D RID: 36141
		RequestQuestLog,
		// Token: 0x04008D2E RID: 36142
		Respawn,
		// Token: 0x04008D2F RID: 36143
		WarpInteract = 67,
		// Token: 0x04008D30 RID: 36144
		Interact,
		// Token: 0x04008D31 RID: 36145
		MercInteract = 70,
		// Token: 0x04008D32 RID: 36146
		MercMove,
		// Token: 0x04008D33 RID: 36147
		EndCinematic,
		// Token: 0x04008D34 RID: 36148
		WaypointTravelPutSharedStash,
		// Token: 0x04008D35 RID: 36149
		RequestReassign = 75,
		// Token: 0x04008D36 RID: 36150
		Transmog,
		// Token: 0x04008D37 RID: 36151
		PlayNpcMsg,
		// Token: 0x04008D38 RID: 36152
		PickItemFromSharedStash,
		// Token: 0x04008D39 RID: 36153
		ClickButton,
		// Token: 0x04008D3A RID: 36154
		DropGold,
		// Token: 0x04008D3B RID: 36155
		SetSkillHotkey,
		// Token: 0x04008D3C RID: 36156
		StaminaOn = 83,
		// Token: 0x04008D3D RID: 36157
		StaminaOff,
		// Token: 0x04008D3E RID: 36158
		WaypointOpen,
		// Token: 0x04008D3F RID: 36159
		WaypointInteract = 87,
		// Token: 0x04008D40 RID: 36160
		CloseQuest,
		// Token: 0x04008D41 RID: 36161
		GoToTownFolk,
		// Token: 0x04008D42 RID: 36162
		SetPlayerRelation = 93,
		// Token: 0x04008D43 RID: 36163
		PartyRequest,
		// Token: 0x04008D44 RID: 36164
		UpdatePosition,
		// Token: 0x04008D45 RID: 36165
		SwitchWeapons,
		// Token: 0x04008D46 RID: 36166
		ChangeMercEquipment,
		// Token: 0x04008D47 RID: 36167
		ResurrectMerc,
		// Token: 0x04008D48 RID: 36168
		InventoryItemToBelt,
		// Token: 0x04008D49 RID: 36169
		WardenResponse = 102,
		// Token: 0x04008D4A RID: 36170
		splogon,
		// Token: 0x04008D4B RID: 36171
		TownFolkRepair2 = 103,
		// Token: 0x04008D4C RID: 36172
		GameLogonRequest,
		// Token: 0x04008D4D RID: 36173
		ExitGame,
		// Token: 0x04008D4E RID: 36174
		RequestHostedGames,
		// Token: 0x04008D4F RID: 36175
		EnterGame,
		// Token: 0x04008D50 RID: 36176
		UploadSave,
		// Token: 0x04008D51 RID: 36177
		Ping,
		// Token: 0x04008D52 RID: 36178
		Invalid,
		// Token: 0x04008D53 RID: 36179
		Timestamp
	}
}
