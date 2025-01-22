using System;

namespace D2Data
{
	// Token: 0x02000982 RID: 2434
	public enum WarpType : byte
	{
		// Token: 0x040085BF RID: 34239
		Act1WildernessToCaveCliffL,
		// Token: 0x040085C0 RID: 34240
		Act1WildernessToCaveCliffR,
		// Token: 0x040085C1 RID: 34241
		Act1WildernessToCaveFloorL,
		// Token: 0x040085C2 RID: 34242
		Act1WildernessToCaveFloorR,
		// Token: 0x040085C3 RID: 34243
		Act1CaveUp,
		// Token: 0x040085C4 RID: 34244
		Act1CaveDown,
		// Token: 0x040085C5 RID: 34245
		Act1GraveyardToCrypt1,
		// Token: 0x040085C6 RID: 34246
		Act1GraveyardToCrypt2,
		// Token: 0x040085C7 RID: 34247
		Act1CryptUp,
		// Token: 0x040085C8 RID: 34248
		Act1CryptDown,
		// Token: 0x040085C9 RID: 34249
		Act1WildernessToTower,
		// Token: 0x040085CA RID: 34250
		Act1TowerToWilderness,
		// Token: 0x040085CB RID: 34251
		Act1TowerToCrypt,
		// Token: 0x040085CC RID: 34252
		Act1JailUp,
		// Token: 0x040085CD RID: 34253
		Act1JailDown,
		// Token: 0x040085CE RID: 34254
		Act1CathedralToCatacombs,
		// Token: 0x040085CF RID: 34255
		Act1CatacombsToCathedral,
		// Token: 0x040085D0 RID: 34256
		Act1CatacombsUp,
		// Token: 0x040085D1 RID: 34257
		Act1CatacombsDown,
		// Token: 0x040085D2 RID: 34258
		Act2TownToSewerTrap,
		// Token: 0x040085D3 RID: 34259
		Act2TownToSewerDock,
		// Token: 0x040085D4 RID: 34260
		Act2SewerDockToTown,
		// Token: 0x040085D5 RID: 34261
		Act2SewerUp,
		// Token: 0x040085D6 RID: 34262
		Act2SewerDown,
		// Token: 0x040085D7 RID: 34263
		Act2TownToHarem,
		// Token: 0x040085D8 RID: 34264
		Act2HaremToTown,
		// Token: 0x040085D9 RID: 34265
		Act2HaremUp1,
		// Token: 0x040085DA RID: 34266
		Act2HaremUp2,
		// Token: 0x040085DB RID: 34267
		Act2HaremDown1,
		// Token: 0x040085DC RID: 34268
		Act2HaremDown2,
		// Token: 0x040085DD RID: 34269
		Act2BasementUp1,
		// Token: 0x040085DE RID: 34270
		Act2BasementUp2,
		// Token: 0x040085DF RID: 34271
		Act2BasementDown,
		// Token: 0x040085E0 RID: 34272
		Act2DesertToTombL1,
		// Token: 0x040085E1 RID: 34273
		Act2DesertToTombL2,
		// Token: 0x040085E2 RID: 34274
		Act2DesertToTombR1,
		// Token: 0x040085E3 RID: 34275
		Act2DesertToTombR2,
		// Token: 0x040085E4 RID: 34276
		Act2DesertToTombViper,
		// Token: 0x040085E5 RID: 34277
		Act2DesertToTombTal1,
		// Token: 0x040085E6 RID: 34278
		Act2DesertToTombTal2,
		// Token: 0x040085E7 RID: 34279
		Act2DesertToTombTal3,
		// Token: 0x040085E8 RID: 34280
		Act2DesertToTombTal4,
		// Token: 0x040085E9 RID: 34281
		Act2DesertToTombTal5,
		// Token: 0x040085EA RID: 34282
		Act2DesertToTombTal6,
		// Token: 0x040085EB RID: 34283
		Act2DesertToTombTal7,
		// Token: 0x040085EC RID: 34284
		Act2TombUp,
		// Token: 0x040085ED RID: 34285
		Act2TombDown,
		// Token: 0x040085EE RID: 34286
		Act2DesertToLair,
		// Token: 0x040085EF RID: 34287
		Act2LairUp,
		// Token: 0x040085F0 RID: 34288
		Act2LairDown,
		// Token: 0x040085F1 RID: 34289
		Act2DesertToSewerTrap,
		// Token: 0x040085F2 RID: 34290
		Act3JungleToSpider,
		// Token: 0x040085F3 RID: 34291
		Act3SpiderToJungle,
		// Token: 0x040085F4 RID: 34292
		Act3JungleToDungeonFort,
		// Token: 0x040085F5 RID: 34293
		Act3JungleToDungeonHole,
		// Token: 0x040085F6 RID: 34294
		Act3DungeonUp,
		// Token: 0x040085F7 RID: 34295
		Act3DungeonDown,
		// Token: 0x040085F8 RID: 34296
		Act3KurastToSewer,
		// Token: 0x040085F9 RID: 34297
		Act3SewerUpL,
		// Token: 0x040085FA RID: 34298
		Act3SewerUpR,
		// Token: 0x040085FB RID: 34299
		Act3SewerDown,
		// Token: 0x040085FC RID: 34300
		Act3KurastToTemple,
		// Token: 0x040085FD RID: 34301
		Act3TempleUpL,
		// Token: 0x040085FE RID: 34302
		Act3TempleUpR,
		// Token: 0x040085FF RID: 34303
		Act3TravincalToMephisto,
		// Token: 0x04008600 RID: 34304
		Act3MephistoUpL,
		// Token: 0x04008601 RID: 34305
		Act3MephistoUpR,
		// Token: 0x04008602 RID: 34306
		Act3MephistoDownL,
		// Token: 0x04008603 RID: 34307
		Act3MephistoDownR,
		// Token: 0x04008604 RID: 34308
		Act4MesaToLava,
		// Token: 0x04008605 RID: 34309
		Act4LavaToMesa,
		// Token: 0x04008606 RID: 34310
		Act5BarricadeDownWall,
		// Token: 0x04008607 RID: 34311
		Act5BarricadeDownFloor,
		// Token: 0x04008608 RID: 34312
		Act5IceCavesUp,
		// Token: 0x04008609 RID: 34313
		Act5IceCavesDown,
		// Token: 0x0400860A RID: 34314
		Act5IceCavesDownFloor,
		// Token: 0x0400860B RID: 34315
		Act5TempleEntrance,
		// Token: 0x0400860C RID: 34316
		Act5TempleDown,
		// Token: 0x0400860D RID: 34317
		Act5TempleUp,
		// Token: 0x0400860E RID: 34318
		Act5MountainTopToIce,
		// Token: 0x0400860F RID: 34319
		Act5MountainTopToBaal,
		// Token: 0x04008610 RID: 34320
		Act5BaalTempleUp,
		// Token: 0x04008611 RID: 34321
		Act5BaalTempleDown,
		// Token: 0x04008612 RID: 34322
		NotApplicable
	}
}
