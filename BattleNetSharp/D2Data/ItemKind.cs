using System;

namespace D2Data
{
	// Token: 0x02000949 RID: 2377
	public enum ItemKind
	{
		// Token: 0x04007259 RID: 29273
		NotUsed1,
		// Token: 0x0400725A RID: 29274
		NotUsed2,
		// Token: 0x0400725B RID: 29275
		Shield,
		// Token: 0x0400725C RID: 29276
		Armor,
		// Token: 0x0400725D RID: 29277
		Gold,
		// Token: 0x0400725E RID: 29278
		BowQuiver,
		// Token: 0x0400725F RID: 29279
		CrossbowQuiver,
		// Token: 0x04007260 RID: 29280
		PlayerBodyPart,
		// Token: 0x04007261 RID: 29281
		Herb,
		// Token: 0x04007262 RID: 29282
		Potion,
		// Token: 0x04007263 RID: 29283
		Ring,
		// Token: 0x04007264 RID: 29284
		Elixir,
		// Token: 0x04007265 RID: 29285
		Amulet,
		// Token: 0x04007266 RID: 29286
		Charm,
		// Token: 0x04007267 RID: 29287
		NotUsed3,
		// Token: 0x04007268 RID: 29288
		Boots,
		// Token: 0x04007269 RID: 29289
		Gloves,
		// Token: 0x0400726A RID: 29290
		NotUsed4,
		// Token: 0x0400726B RID: 29291
		Book,
		// Token: 0x0400726C RID: 29292
		Belt,
		// Token: 0x0400726D RID: 29293
		Gem,
		// Token: 0x0400726E RID: 29294
		Torch,
		// Token: 0x0400726F RID: 29295
		Scroll,
		// Token: 0x04007270 RID: 29296
		NotUsed5,
		// Token: 0x04007271 RID: 29297
		Scepter,
		// Token: 0x04007272 RID: 29298
		Wand,
		// Token: 0x04007273 RID: 29299
		Staff,
		// Token: 0x04007274 RID: 29300
		Bow,
		// Token: 0x04007275 RID: 29301
		Axe,
		// Token: 0x04007276 RID: 29302
		Club,
		// Token: 0x04007277 RID: 29303
		Sword,
		// Token: 0x04007278 RID: 29304
		Hammer,
		// Token: 0x04007279 RID: 29305
		Knife,
		// Token: 0x0400727A RID: 29306
		Spear,
		// Token: 0x0400727B RID: 29307
		Polearm,
		// Token: 0x0400727C RID: 29308
		Crossbow,
		// Token: 0x0400727D RID: 29309
		Mace,
		// Token: 0x0400727E RID: 29310
		Helm,
		// Token: 0x0400727F RID: 29311
		MissilePotion,
		// Token: 0x04007280 RID: 29312
		Quest,
		// Token: 0x04007281 RID: 29313
		BodyPart,
		// Token: 0x04007282 RID: 29314
		Key,
		// Token: 0x04007283 RID: 29315
		ThrowingKnife,
		// Token: 0x04007284 RID: 29316
		ThrowingAxe,
		// Token: 0x04007285 RID: 29317
		Javelin,
		// Token: 0x04007286 RID: 29318
		Weapon,
		// Token: 0x04007287 RID: 29319
		MeleeWeapon,
		// Token: 0x04007288 RID: 29320
		MissileWeapon,
		// Token: 0x04007289 RID: 29321
		ThrownWeapon,
		// Token: 0x0400728A RID: 29322
		ComboWeapon,
		// Token: 0x0400728B RID: 29323
		AnyArmor,
		// Token: 0x0400728C RID: 29324
		AnyShield,
		// Token: 0x0400728D RID: 29325
		Miscellaneous,
		// Token: 0x0400728E RID: 29326
		SocketFiller,
		// Token: 0x0400728F RID: 29327
		SecondHand,
		// Token: 0x04007290 RID: 29328
		StavesAndRods,
		// Token: 0x04007291 RID: 29329
		Missile,
		// Token: 0x04007292 RID: 29330
		Blunt,
		// Token: 0x04007293 RID: 29331
		Jewel,
		// Token: 0x04007294 RID: 29332
		ClassSpecific,
		// Token: 0x04007295 RID: 29333
		AmazonItem,
		// Token: 0x04007296 RID: 29334
		BarbarianItem,
		// Token: 0x04007297 RID: 29335
		NecromancerItem,
		// Token: 0x04007298 RID: 29336
		PaladinItem,
		// Token: 0x04007299 RID: 29337
		SorceressItem,
		// Token: 0x0400729A RID: 29338
		AssassinClaw,
		// Token: 0x0400729B RID: 29339
		DruidItem,
		// Token: 0x0400729C RID: 29340
		HandToHand,
		// Token: 0x0400729D RID: 29341
		Orb,
		// Token: 0x0400729E RID: 29342
		VoodooHeads,
		// Token: 0x0400729F RID: 29343
		AuricShields,
		// Token: 0x040072A0 RID: 29344
		PrimalHelm,
		// Token: 0x040072A1 RID: 29345
		Pelt,
		// Token: 0x040072A2 RID: 29346
		Cloak,
		// Token: 0x040072A3 RID: 29347
		Rune,
		// Token: 0x040072A4 RID: 29348
		Circlet,
		// Token: 0x040072A5 RID: 29349
		HealingPotion,
		// Token: 0x040072A6 RID: 29350
		ManaPotion,
		// Token: 0x040072A7 RID: 29351
		RejuvenationPotion,
		// Token: 0x040072A8 RID: 29352
		StaminaPotion,
		// Token: 0x040072A9 RID: 29353
		AntidotePotion,
		// Token: 0x040072AA RID: 29354
		ThawingPotion,
		// Token: 0x040072AB RID: 29355
		SmallCharm,
		// Token: 0x040072AC RID: 29356
		MediumCharm,
		// Token: 0x040072AD RID: 29357
		LargeCharm,
		// Token: 0x040072AE RID: 29358
		AmazonBow,
		// Token: 0x040072AF RID: 29359
		AmazonSpear,
		// Token: 0x040072B0 RID: 29360
		AmazonJavelin,
		// Token: 0x040072B1 RID: 29361
		HandToHand2,
		// Token: 0x040072B2 RID: 29362
		MagicBowQuiver,
		// Token: 0x040072B3 RID: 29363
		MagicXbowQuiver,
		// Token: 0x040072B4 RID: 29364
		ChippedGem,
		// Token: 0x040072B5 RID: 29365
		FlawedGem,
		// Token: 0x040072B6 RID: 29366
		StandardGem,
		// Token: 0x040072B7 RID: 29367
		FlawlessGem,
		// Token: 0x040072B8 RID: 29368
		PerfectGem,
		// Token: 0x040072B9 RID: 29369
		Amethyst,
		// Token: 0x040072BA RID: 29370
		Diamond,
		// Token: 0x040072BB RID: 29371
		Emerald,
		// Token: 0x040072BC RID: 29372
		Ruby,
		// Token: 0x040072BD RID: 29373
		Sapphire,
		// Token: 0x040072BE RID: 29374
		Topaz,
		// Token: 0x040072BF RID: 29375
		Skull,
		// Token: 0x040072C0 RID: 29376
		Invalid
	}
}
