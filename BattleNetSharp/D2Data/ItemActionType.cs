using System;

namespace D2Data
{
	// Token: 0x0200093F RID: 2367
	public enum ItemActionType
	{
		// Token: 0x040071D7 RID: 29143
		AddToGround,
		// Token: 0x040071D8 RID: 29144
		GroundToCursor,
		// Token: 0x040071D9 RID: 29145
		DropToGround,
		// Token: 0x040071DA RID: 29146
		OnGround,
		// Token: 0x040071DB RID: 29147
		PutInContainer,
		// Token: 0x040071DC RID: 29148
		RemoveFromContainer,
		// Token: 0x040071DD RID: 29149
		Equip,
		// Token: 0x040071DE RID: 29150
		IndirectlySwapBodyItem,
		// Token: 0x040071DF RID: 29151
		Unequip,
		// Token: 0x040071E0 RID: 29152
		SwapBodyItem,
		// Token: 0x040071E1 RID: 29153
		AddQuantity,
		// Token: 0x040071E2 RID: 29154
		AddToShop,
		// Token: 0x040071E3 RID: 29155
		RemoveFromShop,
		// Token: 0x040071E4 RID: 29156
		SwapInContainer,
		// Token: 0x040071E5 RID: 29157
		PutInBeltD2R = 13,
		// Token: 0x040071E6 RID: 29158
		PutInBelt,
		// Token: 0x040071E7 RID: 29159
		RemoveFromBeltD2R = 14,
		// Token: 0x040071E8 RID: 29160
		RemoveFromBelt,
		// Token: 0x040071E9 RID: 29161
		SwapInBelt,
		// Token: 0x040071EA RID: 29162
		AutoUnequipD2R = 16,
		// Token: 0x040071EB RID: 29163
		AutoUnequip,
		// Token: 0x040071EC RID: 29164
		ToCursorD2R = 17,
		// Token: 0x040071ED RID: 29165
		ToCursor,
		// Token: 0x040071EE RID: 29166
		ItemInSocketD2R = 18,
		// Token: 0x040071EF RID: 29167
		ItemInSocket,
		// Token: 0x040071F0 RID: 29168
		UNKNOWNx14,
		// Token: 0x040071F1 RID: 29169
		UpdateStatsD2R = 20,
		// Token: 0x040071F2 RID: 29170
		UpdateStats,
		// Token: 0x040071F3 RID: 29171
		UNKNOWNx16,
		// Token: 0x040071F4 RID: 29172
		WeaponSwitchD2R = 22,
		// Token: 0x040071F5 RID: 29173
		WeaponSwitch
	}
}
