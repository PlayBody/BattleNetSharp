using System;

namespace D2Data
{
	// Token: 0x02000975 RID: 2421
	public enum StateType
	{
		// Token: 0x040081DD RID: 33245
		None,
		// Token: 0x040081DE RID: 33246
		Freeze,
		// Token: 0x040081DF RID: 33247
		Poison,
		// Token: 0x040081E0 RID: 33248
		ResistFire,
		// Token: 0x040081E1 RID: 33249
		ResistCold,
		// Token: 0x040081E2 RID: 33250
		ResistLight,
		// Token: 0x040081E3 RID: 33251
		ResistMagic,
		// Token: 0x040081E4 RID: 33252
		PlayerBody,
		// Token: 0x040081E5 RID: 33253
		ResistAll,
		// Token: 0x040081E6 RID: 33254
		AmplifyDamage,
		// Token: 0x040081E7 RID: 33255
		FrozenArmor,
		// Token: 0x040081E8 RID: 33256
		Cold,
		// Token: 0x040081E9 RID: 33257
		Inferno,
		// Token: 0x040081EA RID: 33258
		Blaze,
		// Token: 0x040081EB RID: 33259
		BoneArmor,
		// Token: 0x040081EC RID: 33260
		Concentrate,
		// Token: 0x040081ED RID: 33261
		Enchant,
		// Token: 0x040081EE RID: 33262
		InnerSight,
		// Token: 0x040081EF RID: 33263
		SkillMove,
		// Token: 0x040081F0 RID: 33264
		Weaken,
		// Token: 0x040081F1 RID: 33265
		ChillingArmor,
		// Token: 0x040081F2 RID: 33266
		Stunned,
		// Token: 0x040081F3 RID: 33267
		SpiderLay,
		// Token: 0x040081F4 RID: 33268
		DimVision,
		// Token: 0x040081F5 RID: 33269
		Slowed,
		// Token: 0x040081F6 RID: 33270
		FetishAura,
		// Token: 0x040081F7 RID: 33271
		Shout,
		// Token: 0x040081F8 RID: 33272
		Taunt,
		// Token: 0x040081F9 RID: 33273
		Conviction,
		// Token: 0x040081FA RID: 33274
		Convicted,
		// Token: 0x040081FB RID: 33275
		EnergyShield,
		// Token: 0x040081FC RID: 33276
		VenomClaws,
		// Token: 0x040081FD RID: 33277
		BattleOrders,
		// Token: 0x040081FE RID: 33278
		Might,
		// Token: 0x040081FF RID: 33279
		Prayer,
		// Token: 0x04008200 RID: 33280
		HolyFire,
		// Token: 0x04008201 RID: 33281
		Thorns,
		// Token: 0x04008202 RID: 33282
		Defiance,
		// Token: 0x04008203 RID: 33283
		Thunderstorm,
		// Token: 0x04008204 RID: 33284
		Lightningbolt,
		// Token: 0x04008205 RID: 33285
		BlessedAim,
		// Token: 0x04008206 RID: 33286
		Stamina,
		// Token: 0x04008207 RID: 33287
		Concentration,
		// Token: 0x04008208 RID: 33288
		HolyWind,
		// Token: 0x04008209 RID: 33289
		HolyWindCold,
		// Token: 0x0400820A RID: 33290
		Cleansing,
		// Token: 0x0400820B RID: 33291
		HolyShock,
		// Token: 0x0400820C RID: 33292
		Sanctuary,
		// Token: 0x0400820D RID: 33293
		Meditation,
		// Token: 0x0400820E RID: 33294
		Fanaticism,
		// Token: 0x0400820F RID: 33295
		Redemption,
		// Token: 0x04008210 RID: 33296
		BattleCommand,
		// Token: 0x04008211 RID: 33297
		PreventHeal,
		// Token: 0x04008212 RID: 33298
		Conversion,
		// Token: 0x04008213 RID: 33299
		Uninterruptable,
		// Token: 0x04008214 RID: 33300
		IronMaiden,
		// Token: 0x04008215 RID: 33301
		Terror,
		// Token: 0x04008216 RID: 33302
		Attract,
		// Token: 0x04008217 RID: 33303
		LifeTap,
		// Token: 0x04008218 RID: 33304
		Confuse,
		// Token: 0x04008219 RID: 33305
		Decrepify,
		// Token: 0x0400821A RID: 33306
		LowerResist,
		// Token: 0x0400821B RID: 33307
		OpenWounds,
		// Token: 0x0400821C RID: 33308
		Decoy,
		// Token: 0x0400821D RID: 33309
		CriticalStrike,
		// Token: 0x0400821E RID: 33310
		Dodge,
		// Token: 0x0400821F RID: 33311
		Avoid,
		// Token: 0x04008220 RID: 33312
		Penetrate,
		// Token: 0x04008221 RID: 33313
		Evade,
		// Token: 0x04008222 RID: 33314
		Pierce,
		// Token: 0x04008223 RID: 33315
		Warmth,
		// Token: 0x04008224 RID: 33316
		FireMastery,
		// Token: 0x04008225 RID: 33317
		LightningMastery,
		// Token: 0x04008226 RID: 33318
		ColdMastery,
		// Token: 0x04008227 RID: 33319
		SwordMastery,
		// Token: 0x04008228 RID: 33320
		AxeMastery,
		// Token: 0x04008229 RID: 33321
		MaceMastery,
		// Token: 0x0400822A RID: 33322
		PolearmMastery,
		// Token: 0x0400822B RID: 33323
		ThrowingMastery,
		// Token: 0x0400822C RID: 33324
		SpearMastery,
		// Token: 0x0400822D RID: 33325
		IncreasedStamina,
		// Token: 0x0400822E RID: 33326
		IronSkin,
		// Token: 0x0400822F RID: 33327
		IncreasedSpeed,
		// Token: 0x04008230 RID: 33328
		NaturalResistance,
		// Token: 0x04008231 RID: 33329
		FingerMageCurse,
		// Token: 0x04008232 RID: 33330
		NoManaRegen,
		// Token: 0x04008233 RID: 33331
		JustHit,
		// Token: 0x04008234 RID: 33332
		SlowMissiles,
		// Token: 0x04008235 RID: 33333
		ShiverArmor,
		// Token: 0x04008236 RID: 33334
		BattleCry,
		// Token: 0x04008237 RID: 33335
		Blue,
		// Token: 0x04008238 RID: 33336
		Red,
		// Token: 0x04008239 RID: 33337
		DeathDelay,
		// Token: 0x0400823A RID: 33338
		Valkyrie,
		// Token: 0x0400823B RID: 33339
		Frenzy,
		// Token: 0x0400823C RID: 33340
		Berserk,
		// Token: 0x0400823D RID: 33341
		Revive,
		// Token: 0x0400823E RID: 33342
		SkeletonMastery,
		// Token: 0x0400823F RID: 33343
		SourceUnit,
		// Token: 0x04008240 RID: 33344
		Redeemed,
		// Token: 0x04008241 RID: 33345
		HealthPot,
		// Token: 0x04008242 RID: 33346
		HolyShield,
		// Token: 0x04008243 RID: 33347
		JustPortaled,
		// Token: 0x04008244 RID: 33348
		MonsterFrenzy,
		// Token: 0x04008245 RID: 33349
		CorpseNoDraw,
		// Token: 0x04008246 RID: 33350
		Alignment,
		// Token: 0x04008247 RID: 33351
		ManaPot,
		// Token: 0x04008248 RID: 33352
		Shatter,
		// Token: 0x04008249 RID: 33353
		SyncWarped,
		// Token: 0x0400824A RID: 33354
		ConversionSave,
		// Token: 0x0400824B RID: 33355
		Pregnant,
		// Token: 0x0400824C RID: 33356
		GolemMastery,
		// Token: 0x0400824D RID: 33357
		Rabies,
		// Token: 0x0400824E RID: 33358
		DefenseCurse,
		// Token: 0x0400824F RID: 33359
		BloodMana,
		// Token: 0x04008250 RID: 33360
		Burning,
		// Token: 0x04008251 RID: 33361
		DragonFlight,
		// Token: 0x04008252 RID: 33362
		Maul,
		// Token: 0x04008253 RID: 33363
		CorpseNoselect,
		// Token: 0x04008254 RID: 33364
		ShadowWarrior,
		// Token: 0x04008255 RID: 33365
		FeralRage,
		// Token: 0x04008256 RID: 33366
		SkillDelay,
		// Token: 0x04008257 RID: 33367
		ProgressiveDamage,
		// Token: 0x04008258 RID: 33368
		ProgressiveSteal,
		// Token: 0x04008259 RID: 33369
		ProgressiveOther,
		// Token: 0x0400825A RID: 33370
		ProgressiveFire,
		// Token: 0x0400825B RID: 33371
		ProgressiveCold,
		// Token: 0x0400825C RID: 33372
		ProgressiveLightning,
		// Token: 0x0400825D RID: 33373
		ShrineArmor,
		// Token: 0x0400825E RID: 33374
		ShrineCombat,
		// Token: 0x0400825F RID: 33375
		ShrineResistLightning,
		// Token: 0x04008260 RID: 33376
		ShrineResistFire,
		// Token: 0x04008261 RID: 33377
		ShrineResistCold,
		// Token: 0x04008262 RID: 33378
		ShrineResistPoison,
		// Token: 0x04008263 RID: 33379
		ShrineSkill,
		// Token: 0x04008264 RID: 33380
		ShrineManaRegen,
		// Token: 0x04008265 RID: 33381
		ShrineStamina,
		// Token: 0x04008266 RID: 33382
		ShrineExperience,
		// Token: 0x04008267 RID: 33383
		FenrisRage,
		// Token: 0x04008268 RID: 33384
		Wolf,
		// Token: 0x04008269 RID: 33385
		Bear,
		// Token: 0x0400826A RID: 33386
		Bloodlust,
		// Token: 0x0400826B RID: 33387
		ChangeClass,
		// Token: 0x0400826C RID: 33388
		Attached,
		// Token: 0x0400826D RID: 33389
		Hurricane,
		// Token: 0x0400826E RID: 33390
		Armageddon,
		// Token: 0x0400826F RID: 33391
		Invis,
		// Token: 0x04008270 RID: 33392
		Barbs,
		// Token: 0x04008271 RID: 33393
		Wolverine,
		// Token: 0x04008272 RID: 33394
		Oaksage,
		// Token: 0x04008273 RID: 33395
		VineBeast,
		// Token: 0x04008274 RID: 33396
		CycloneArmor,
		// Token: 0x04008275 RID: 33397
		ClawMastery,
		// Token: 0x04008276 RID: 33398
		CloakOfShadows,
		// Token: 0x04008277 RID: 33399
		Recycled,
		// Token: 0x04008278 RID: 33400
		WeaponBlock,
		// Token: 0x04008279 RID: 33401
		Cloaked,
		// Token: 0x0400827A RID: 33402
		Quickness,
		// Token: 0x0400827B RID: 33403
		BladeShield,
		// Token: 0x0400827C RID: 33404
		Fade,
		// Token: 0x0400827D RID: 33405
		SummonResist,
		// Token: 0x0400827E RID: 33406
		OakSageControl,
		// Token: 0x0400827F RID: 33407
		WolverineControl,
		// Token: 0x04008280 RID: 33408
		BarbsControl,
		// Token: 0x04008281 RID: 33409
		DebugControl,
		// Token: 0x04008282 RID: 33410
		ItemSet1,
		// Token: 0x04008283 RID: 33411
		ItemSet2,
		// Token: 0x04008284 RID: 33412
		ItemSet3,
		// Token: 0x04008285 RID: 33413
		ItemSet4,
		// Token: 0x04008286 RID: 33414
		ItemSet5,
		// Token: 0x04008287 RID: 33415
		ItemSet6,
		// Token: 0x04008288 RID: 33416
		Runeword,
		// Token: 0x04008289 RID: 33417
		RestInPeace,
		// Token: 0x0400828A RID: 33418
		CorpseExp,
		// Token: 0x0400828B RID: 33419
		WhirlWind,
		// Token: 0x0400828C RID: 33420
		FullSetGeneric,
		// Token: 0x0400828D RID: 33421
		MonsterSet,
		// Token: 0x0400828E RID: 33422
		Delerium,
		// Token: 0x0400828F RID: 33423
		Antidote,
		// Token: 0x04008290 RID: 33424
		Thawing,
		// Token: 0x04008291 RID: 33425
		StaminaPot,
		// Token: 0x04008292 RID: 33426
		PassiveResistFire,
		// Token: 0x04008293 RID: 33427
		PassiveResistCold,
		// Token: 0x04008294 RID: 33428
		PassiveResistLightning,
		// Token: 0x04008295 RID: 33429
		UberMinion,
		// Token: 0x04008296 RID: 33430
		Invalid
	}
}
