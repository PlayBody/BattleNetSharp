using System;

namespace D2Data
{
	// Token: 0x02000977 RID: 2423
	public enum StatType : ushort
	{
		// Token: 0x04008298 RID: 33432
		Strength,
		// Token: 0x04008299 RID: 33433
		Energy,
		// Token: 0x0400829A RID: 33434
		Dexterity,
		// Token: 0x0400829B RID: 33435
		Vitality,
		// Token: 0x0400829C RID: 33436
		StatPoints,
		// Token: 0x0400829D RID: 33437
		SkillPoints,
		// Token: 0x0400829E RID: 33438
		Life,
		// Token: 0x0400829F RID: 33439
		MaxLife,
		// Token: 0x040082A0 RID: 33440
		Mana,
		// Token: 0x040082A1 RID: 33441
		MaxMana,
		// Token: 0x040082A2 RID: 33442
		Stamina,
		// Token: 0x040082A3 RID: 33443
		MaxStamina,
		// Token: 0x040082A4 RID: 33444
		Level,
		// Token: 0x040082A5 RID: 33445
		Experience,
		// Token: 0x040082A6 RID: 33446
		Gold,
		// Token: 0x040082A7 RID: 33447
		GoldBank,
		// Token: 0x040082A8 RID: 33448
		DefensePercent,
		// Token: 0x040082A9 RID: 33449
		MaxDamagePercent,
		// Token: 0x040082AA RID: 33450
		MinDamagePercent,
		// Token: 0x040082AB RID: 33451
		ToHit,
		// Token: 0x040082AC RID: 33452
		ToBlock,
		// Token: 0x040082AD RID: 33453
		MinDamage,
		// Token: 0x040082AE RID: 33454
		MaxDamage,
		// Token: 0x040082AF RID: 33455
		SecondaryMinDamage,
		// Token: 0x040082B0 RID: 33456
		SecondaryMaxDamage,
		// Token: 0x040082B1 RID: 33457
		DamagePercent,
		// Token: 0x040082B2 RID: 33458
		ManaRecovery,
		// Token: 0x040082B3 RID: 33459
		ManaRecoveryBonus,
		// Token: 0x040082B4 RID: 33460
		StaminaRecoveryBonus,
		// Token: 0x040082B5 RID: 33461
		LastExperience,
		// Token: 0x040082B6 RID: 33462
		NextExperience,
		// Token: 0x040082B7 RID: 33463
		ArmorClass,
		// Token: 0x040082B8 RID: 33464
		ArmorClassVsMissile,
		// Token: 0x040082B9 RID: 33465
		ArmorClassVsMelee,
		// Token: 0x040082BA RID: 33466
		DamageReduction,
		// Token: 0x040082BB RID: 33467
		MagicDamageReduction,
		// Token: 0x040082BC RID: 33468
		DamageResist,
		// Token: 0x040082BD RID: 33469
		MagicResist,
		// Token: 0x040082BE RID: 33470
		MaxMagicResist,
		// Token: 0x040082BF RID: 33471
		FireResist,
		// Token: 0x040082C0 RID: 33472
		MaxFireResist,
		// Token: 0x040082C1 RID: 33473
		LightResist,
		// Token: 0x040082C2 RID: 33474
		MaxLightResist,
		// Token: 0x040082C3 RID: 33475
		ColdResist,
		// Token: 0x040082C4 RID: 33476
		MaxColdResist,
		// Token: 0x040082C5 RID: 33477
		PoisonResist,
		// Token: 0x040082C6 RID: 33478
		MaxPoisonResist,
		// Token: 0x040082C7 RID: 33479
		DamageAura,
		// Token: 0x040082C8 RID: 33480
		FireMinDamage,
		// Token: 0x040082C9 RID: 33481
		FireMaxDamage,
		// Token: 0x040082CA RID: 33482
		LightMinDamage,
		// Token: 0x040082CB RID: 33483
		LightMaxDamage,
		// Token: 0x040082CC RID: 33484
		MagicMinDamage,
		// Token: 0x040082CD RID: 33485
		MagicMaxDamage,
		// Token: 0x040082CE RID: 33486
		ColdMinDamage,
		// Token: 0x040082CF RID: 33487
		ColdMaxDamage,
		// Token: 0x040082D0 RID: 33488
		ColdLength,
		// Token: 0x040082D1 RID: 33489
		PoisonMinDamage,
		// Token: 0x040082D2 RID: 33490
		PoisonMaxDamage,
		// Token: 0x040082D3 RID: 33491
		PoisonLength,
		// Token: 0x040082D4 RID: 33492
		LifeDrainMinDamage,
		// Token: 0x040082D5 RID: 33493
		LifeDrainMaxDamage,
		// Token: 0x040082D6 RID: 33494
		ManaDrainMinDamage,
		// Token: 0x040082D7 RID: 33495
		ManaDrainMaxDamage,
		// Token: 0x040082D8 RID: 33496
		StamDrainMinDamage,
		// Token: 0x040082D9 RID: 33497
		StamDrainMaxDamage,
		// Token: 0x040082DA RID: 33498
		StunLength,
		// Token: 0x040082DB RID: 33499
		VelocityPercent,
		// Token: 0x040082DC RID: 33500
		AttackRate,
		// Token: 0x040082DD RID: 33501
		OtherAnimRate,
		// Token: 0x040082DE RID: 33502
		Quantity,
		// Token: 0x040082DF RID: 33503
		Value,
		// Token: 0x040082E0 RID: 33504
		Durability,
		// Token: 0x040082E1 RID: 33505
		MaxDurability,
		// Token: 0x040082E2 RID: 33506
		LifeRegen,
		// Token: 0x040082E3 RID: 33507
		MaxDurabilityPercent,
		// Token: 0x040082E4 RID: 33508
		MaxLifePercent,
		// Token: 0x040082E5 RID: 33509
		MaxManaPercent,
		// Token: 0x040082E6 RID: 33510
		AttackerTakesDamage,
		// Token: 0x040082E7 RID: 33511
		GoldFind,
		// Token: 0x040082E8 RID: 33512
		MagicFind,
		// Token: 0x040082E9 RID: 33513
		Knockback,
		// Token: 0x040082EA RID: 33514
		TimeDuration,
		// Token: 0x040082EB RID: 33515
		ClassSkillsBonus,
		// Token: 0x040082EC RID: 33516
		UnsentParam1,
		// Token: 0x040082ED RID: 33517
		AddExperience,
		// Token: 0x040082EE RID: 33518
		HealAfterKill,
		// Token: 0x040082EF RID: 33519
		ReducedPrices,
		// Token: 0x040082F0 RID: 33520
		DoubleHerbDuration,
		// Token: 0x040082F1 RID: 33521
		LightRadius,
		// Token: 0x040082F2 RID: 33522
		LightColor,
		// Token: 0x040082F3 RID: 33523
		LowerRequirementsPercent,
		// Token: 0x040082F4 RID: 33524
		LowerLevelRequirement,
		// Token: 0x040082F5 RID: 33525
		FasterAttackRate,
		// Token: 0x040082F6 RID: 33526
		LowerLevelRequirementPercent,
		// Token: 0x040082F7 RID: 33527
		LastBlockFrame,
		// Token: 0x040082F8 RID: 33528
		FasterMoveVelocity,
		// Token: 0x040082F9 RID: 33529
		NonClassSkill,
		// Token: 0x040082FA RID: 33530
		State,
		// Token: 0x040082FB RID: 33531
		FasterHitRecovery,
		// Token: 0x040082FC RID: 33532
		MonsterPlayerCount,
		// Token: 0x040082FD RID: 33533
		SkillPoisonOverrideLength,
		// Token: 0x040082FE RID: 33534
		FasterBlockRate,
		// Token: 0x040082FF RID: 33535
		SkillBypassUndead,
		// Token: 0x04008300 RID: 33536
		SkillBypassDemons,
		// Token: 0x04008301 RID: 33537
		FasterCastRate,
		// Token: 0x04008302 RID: 33538
		SkillBypassBeasts,
		// Token: 0x04008303 RID: 33539
		SingleSkill,
		// Token: 0x04008304 RID: 33540
		RestInPeace,
		// Token: 0x04008305 RID: 33541
		CurseResistance,
		// Token: 0x04008306 RID: 33542
		PoisonLengthReduction,
		// Token: 0x04008307 RID: 33543
		NormalDamage,
		// Token: 0x04008308 RID: 33544
		Howl,
		// Token: 0x04008309 RID: 33545
		HitBlindsTarget,
		// Token: 0x0400830A RID: 33546
		DamageToMana,
		// Token: 0x0400830B RID: 33547
		IgnoreTargetDefense,
		// Token: 0x0400830C RID: 33548
		FractionalTargetAC,
		// Token: 0x0400830D RID: 33549
		PreventHeal,
		// Token: 0x0400830E RID: 33550
		HalfFreezeDuration,
		// Token: 0x0400830F RID: 33551
		ToHitPercent,
		// Token: 0x04008310 RID: 33552
		DamageTargetAC,
		// Token: 0x04008311 RID: 33553
		DemonDamagePercent,
		// Token: 0x04008312 RID: 33554
		UndeadDamagepercent,
		// Token: 0x04008313 RID: 33555
		DemonToHit,
		// Token: 0x04008314 RID: 33556
		UndeadToHit,
		// Token: 0x04008315 RID: 33557
		Throwable,
		// Token: 0x04008316 RID: 33558
		ElementalSkillBonus,
		// Token: 0x04008317 RID: 33559
		AllSkillsBonus,
		// Token: 0x04008318 RID: 33560
		AttackerTakesLightingDamage,
		// Token: 0x04008319 RID: 33561
		IronMaidenLevel,
		// Token: 0x0400831A RID: 33562
		LifeTapLevel,
		// Token: 0x0400831B RID: 33563
		ThornsPercent,
		// Token: 0x0400831C RID: 33564
		BoneArmor,
		// Token: 0x0400831D RID: 33565
		BoneArmorMax,
		// Token: 0x0400831E RID: 33566
		Freeze,
		// Token: 0x0400831F RID: 33567
		OpenWounds,
		// Token: 0x04008320 RID: 33568
		CrushingBlow,
		// Token: 0x04008321 RID: 33569
		KickDamage,
		// Token: 0x04008322 RID: 33570
		ManaAfterKill,
		// Token: 0x04008323 RID: 33571
		HealAfterDemonKill,
		// Token: 0x04008324 RID: 33572
		ExtraBlood,
		// Token: 0x04008325 RID: 33573
		DeadlyStrike,
		// Token: 0x04008326 RID: 33574
		AbsorbFirePercent,
		// Token: 0x04008327 RID: 33575
		AbsorbFire,
		// Token: 0x04008328 RID: 33576
		AbsorbLightingPercent,
		// Token: 0x04008329 RID: 33577
		AbsorbLight,
		// Token: 0x0400832A RID: 33578
		AbsorbMagicPercent,
		// Token: 0x0400832B RID: 33579
		AbsorbMagic,
		// Token: 0x0400832C RID: 33580
		AbsorbColdPercent,
		// Token: 0x0400832D RID: 33581
		AbsorbCold,
		// Token: 0x0400832E RID: 33582
		Slow,
		// Token: 0x0400832F RID: 33583
		Aura,
		// Token: 0x04008330 RID: 33584
		Indesctructible,
		// Token: 0x04008331 RID: 33585
		CannotBeFrozen,
		// Token: 0x04008332 RID: 33586
		StaminaDrainPercent,
		// Token: 0x04008333 RID: 33587
		Reanimate,
		// Token: 0x04008334 RID: 33588
		Pierce,
		// Token: 0x04008335 RID: 33589
		MagicArrow,
		// Token: 0x04008336 RID: 33590
		ExplosiveArrow,
		// Token: 0x04008337 RID: 33591
		ThrowMinDamage,
		// Token: 0x04008338 RID: 33592
		ThrowMaxDamage,
		// Token: 0x04008339 RID: 33593
		SkillHandOfAthena,
		// Token: 0x0400833A RID: 33594
		SkillStaminaPercent,
		// Token: 0x0400833B RID: 33595
		SkillPassiveStaminaPercent,
		// Token: 0x0400833C RID: 33596
		SkillConcentration,
		// Token: 0x0400833D RID: 33597
		SkillEnchant,
		// Token: 0x0400833E RID: 33598
		SkillPierce,
		// Token: 0x0400833F RID: 33599
		SkillConviction,
		// Token: 0x04008340 RID: 33600
		SkillChillingArmor,
		// Token: 0x04008341 RID: 33601
		SkillFrenzy,
		// Token: 0x04008342 RID: 33602
		SkillDecrepify,
		// Token: 0x04008343 RID: 33603
		SkillArmorPercent,
		// Token: 0x04008344 RID: 33604
		Alignment,
		// Token: 0x04008345 RID: 33605
		Target0,
		// Token: 0x04008346 RID: 33606
		Target1,
		// Token: 0x04008347 RID: 33607
		GoldLost,
		// Token: 0x04008348 RID: 33608
		ConversionLevel,
		// Token: 0x04008349 RID: 33609
		ConversionMaxHP,
		// Token: 0x0400834A RID: 33610
		UnitDoOverlay,
		// Token: 0x0400834B RID: 33611
		AttackVsMonsterType,
		// Token: 0x0400834C RID: 33612
		DamageVsMonsterType,
		// Token: 0x0400834D RID: 33613
		Fade,
		// Token: 0x0400834E RID: 33614
		ArmorOverridePercent,
		// Token: 0x0400834F RID: 33615
		Unused183,
		// Token: 0x04008350 RID: 33616
		Unused184,
		// Token: 0x04008351 RID: 33617
		Unused185,
		// Token: 0x04008352 RID: 33618
		Unused186,
		// Token: 0x04008353 RID: 33619
		Unused187,
		// Token: 0x04008354 RID: 33620
		SkillTabBonus,
		// Token: 0x04008355 RID: 33621
		Unused189,
		// Token: 0x04008356 RID: 33622
		Unused190,
		// Token: 0x04008357 RID: 33623
		Unused191,
		// Token: 0x04008358 RID: 33624
		Unused192,
		// Token: 0x04008359 RID: 33625
		Unused193,
		// Token: 0x0400835A RID: 33626
		Sockets,
		// Token: 0x0400835B RID: 33627
		SkillOnAttack,
		// Token: 0x0400835C RID: 33628
		SkillOnKill,
		// Token: 0x0400835D RID: 33629
		SkillOnDeath,
		// Token: 0x0400835E RID: 33630
		SkillOnStriking,
		// Token: 0x0400835F RID: 33631
		SkillOnLevelUp,
		// Token: 0x04008360 RID: 33632
		Unused200,
		// Token: 0x04008361 RID: 33633
		SkillOnGetHit,
		// Token: 0x04008362 RID: 33634
		Unused202,
		// Token: 0x04008363 RID: 33635
		Unused203,
		// Token: 0x04008364 RID: 33636
		ChargedSkill,
		// Token: 0x04008365 RID: 33637
		Unused204,
		// Token: 0x04008366 RID: 33638
		Unused205,
		// Token: 0x04008367 RID: 33639
		Unused206,
		// Token: 0x04008368 RID: 33640
		Unused207,
		// Token: 0x04008369 RID: 33641
		Unused208,
		// Token: 0x0400836A RID: 33642
		Unused209,
		// Token: 0x0400836B RID: 33643
		Unused210,
		// Token: 0x0400836C RID: 33644
		Unused211,
		// Token: 0x0400836D RID: 33645
		Unused212,
		// Token: 0x0400836E RID: 33646
		ArmorPerLevel,
		// Token: 0x0400836F RID: 33647
		ArmorPercentPerLevel,
		// Token: 0x04008370 RID: 33648
		LifePerLevel,
		// Token: 0x04008371 RID: 33649
		ManaPerLevel,
		// Token: 0x04008372 RID: 33650
		MaxDamagePerLevel,
		// Token: 0x04008373 RID: 33651
		MaxDamagePercentPerLevel,
		// Token: 0x04008374 RID: 33652
		StrengthPerLevel,
		// Token: 0x04008375 RID: 33653
		DexterityPerLevel,
		// Token: 0x04008376 RID: 33654
		EnergyPerLevel,
		// Token: 0x04008377 RID: 33655
		VitalityPerLevel,
		// Token: 0x04008378 RID: 33656
		ToHitPerLevel,
		// Token: 0x04008379 RID: 33657
		ToHitPercentPerLevel,
		// Token: 0x0400837A RID: 33658
		ColdDamageMaxPerLevel,
		// Token: 0x0400837B RID: 33659
		FireDamageMaxPerLevel,
		// Token: 0x0400837C RID: 33660
		LightningDamageMaxPerLevel,
		// Token: 0x0400837D RID: 33661
		PoisonDamageMaxPerLevel,
		// Token: 0x0400837E RID: 33662
		ResistColdPerLevel,
		// Token: 0x0400837F RID: 33663
		ResistFirePerLevel,
		// Token: 0x04008380 RID: 33664
		ResistLightningPerLevel,
		// Token: 0x04008381 RID: 33665
		ResistPoisonPerLevel,
		// Token: 0x04008382 RID: 33666
		AbsorbColdPerLevel,
		// Token: 0x04008383 RID: 33667
		AbsorbFirePerLevel,
		// Token: 0x04008384 RID: 33668
		AbsorbLightningPerLevel,
		// Token: 0x04008385 RID: 33669
		AbsorbPoisonPerLevel,
		// Token: 0x04008386 RID: 33670
		ThornsPerLevel,
		// Token: 0x04008387 RID: 33671
		GoldFindPerLevel,
		// Token: 0x04008388 RID: 33672
		MagicFindPerLevel,
		// Token: 0x04008389 RID: 33673
		RegenStaminaPerLevel,
		// Token: 0x0400838A RID: 33674
		StaminaPerLevel,
		// Token: 0x0400838B RID: 33675
		DamageDemonPerLevel,
		// Token: 0x0400838C RID: 33676
		DamageUndeadPerLevel,
		// Token: 0x0400838D RID: 33677
		ToHitDemonPerLevel,
		// Token: 0x0400838E RID: 33678
		ToHitUndeadPerLevel,
		// Token: 0x0400838F RID: 33679
		CrushingBlowPerLevel,
		// Token: 0x04008390 RID: 33680
		OpenWoundsPerLevel,
		// Token: 0x04008391 RID: 33681
		KickDamagePerLevel,
		// Token: 0x04008392 RID: 33682
		DeadlyStrikePerLevel,
		// Token: 0x04008393 RID: 33683
		FindGemsPerLevel,
		// Token: 0x04008394 RID: 33684
		ReplenishDurability,
		// Token: 0x04008395 RID: 33685
		ReplenishQuantity,
		// Token: 0x04008396 RID: 33686
		ExtraStack,
		// Token: 0x04008397 RID: 33687
		FindItem,
		// Token: 0x04008398 RID: 33688
		SlashDamage,
		// Token: 0x04008399 RID: 33689
		SlashDamagePercent,
		// Token: 0x0400839A RID: 33690
		CrushDamage,
		// Token: 0x0400839B RID: 33691
		CrushDamagePercent,
		// Token: 0x0400839C RID: 33692
		ThrustDamage,
		// Token: 0x0400839D RID: 33693
		ThrustDamagePercent,
		// Token: 0x0400839E RID: 33694
		AbsorbSlash,
		// Token: 0x0400839F RID: 33695
		AbsorbCrush,
		// Token: 0x040083A0 RID: 33696
		AbsorbThrust,
		// Token: 0x040083A1 RID: 33697
		AbsorbSlashPercent,
		// Token: 0x040083A2 RID: 33698
		AbsorbCrushPercent,
		// Token: 0x040083A3 RID: 33699
		AbsorbThrustPercent,
		// Token: 0x040083A4 RID: 33700
		ArmorByTime,
		// Token: 0x040083A5 RID: 33701
		ArmorPercentByTime,
		// Token: 0x040083A6 RID: 33702
		LifeByTime,
		// Token: 0x040083A7 RID: 33703
		ManaByTime,
		// Token: 0x040083A8 RID: 33704
		MaxDamageByTime,
		// Token: 0x040083A9 RID: 33705
		MaxDamagePercentByTime,
		// Token: 0x040083AA RID: 33706
		StrengthByTime,
		// Token: 0x040083AB RID: 33707
		DexterityByTime,
		// Token: 0x040083AC RID: 33708
		EnergyByTime,
		// Token: 0x040083AD RID: 33709
		VitalityByTime,
		// Token: 0x040083AE RID: 33710
		ToHitByTime,
		// Token: 0x040083AF RID: 33711
		ToHitPercentByTime,
		// Token: 0x040083B0 RID: 33712
		ColdMaxDamageByTime,
		// Token: 0x040083B1 RID: 33713
		FireMaxDamageByTime,
		// Token: 0x040083B2 RID: 33714
		LightningMaxDamageByTime,
		// Token: 0x040083B3 RID: 33715
		PoisonMaxDamageByTime,
		// Token: 0x040083B4 RID: 33716
		ResistColdByTime,
		// Token: 0x040083B5 RID: 33717
		ResistFireByTime,
		// Token: 0x040083B6 RID: 33718
		ResistLightningByTime,
		// Token: 0x040083B7 RID: 33719
		ResistPoisonByTime,
		// Token: 0x040083B8 RID: 33720
		AbsorbColdByTime,
		// Token: 0x040083B9 RID: 33721
		AbsorbFireByTime,
		// Token: 0x040083BA RID: 33722
		AbsorbLightningByTime,
		// Token: 0x040083BB RID: 33723
		AbsorbPoisonByTime,
		// Token: 0x040083BC RID: 33724
		FindGoldByTime,
		// Token: 0x040083BD RID: 33725
		FindMagicByTime,
		// Token: 0x040083BE RID: 33726
		RegenStaminaByTime,
		// Token: 0x040083BF RID: 33727
		StaminaByTime,
		// Token: 0x040083C0 RID: 33728
		DamageDemonByTime,
		// Token: 0x040083C1 RID: 33729
		DamageUndeadByTime,
		// Token: 0x040083C2 RID: 33730
		ToHitDemonByTime,
		// Token: 0x040083C3 RID: 33731
		ToHitUndeadByTime,
		// Token: 0x040083C4 RID: 33732
		CrushingBlowByTime,
		// Token: 0x040083C5 RID: 33733
		OpenWoundsByTime,
		// Token: 0x040083C6 RID: 33734
		KickDamageByTime,
		// Token: 0x040083C7 RID: 33735
		DeadlyStrikeByTime,
		// Token: 0x040083C8 RID: 33736
		FindGemsByTime,
		// Token: 0x040083C9 RID: 33737
		PierceCold,
		// Token: 0x040083CA RID: 33738
		PierceFire,
		// Token: 0x040083CB RID: 33739
		PierceLightning,
		// Token: 0x040083CC RID: 33740
		PiercePoison,
		// Token: 0x040083CD RID: 33741
		DamageVsMonster,
		// Token: 0x040083CE RID: 33742
		DamagePercentVsMonster,
		// Token: 0x040083CF RID: 33743
		ToHitVsMonster,
		// Token: 0x040083D0 RID: 33744
		ToHitPercentVsMonster,
		// Token: 0x040083D1 RID: 33745
		DefenseVsMonster,
		// Token: 0x040083D2 RID: 33746
		DefensePercentVsMonster,
		// Token: 0x040083D3 RID: 33747
		FireLength,
		// Token: 0x040083D4 RID: 33748
		BurningMin,
		// Token: 0x040083D5 RID: 33749
		BurningMax,
		// Token: 0x040083D6 RID: 33750
		ProgressiveDamage,
		// Token: 0x040083D7 RID: 33751
		ProgressiveSteal,
		// Token: 0x040083D8 RID: 33752
		ProgressiveOther,
		// Token: 0x040083D9 RID: 33753
		ProgressiveFire,
		// Token: 0x040083DA RID: 33754
		ProgressiveCold,
		// Token: 0x040083DB RID: 33755
		ProgressiveLightning,
		// Token: 0x040083DC RID: 33756
		ExtraCharges,
		// Token: 0x040083DD RID: 33757
		ProgressiveToHit,
		// Token: 0x040083DE RID: 33758
		PoisonCount,
		// Token: 0x040083DF RID: 33759
		DamageFramerate,
		// Token: 0x040083E0 RID: 33760
		PierceIdx,
		// Token: 0x040083E1 RID: 33761
		PassiveFireMastery,
		// Token: 0x040083E2 RID: 33762
		PassiveLightningMastery,
		// Token: 0x040083E3 RID: 33763
		PassiveColdMastery,
		// Token: 0x040083E4 RID: 33764
		PassivePoisonMastery,
		// Token: 0x040083E5 RID: 33765
		PassiveFirePierce,
		// Token: 0x040083E6 RID: 33766
		PassiveLightningPierce,
		// Token: 0x040083E7 RID: 33767
		PassiveColdPierce,
		// Token: 0x040083E8 RID: 33768
		PassivePoisonPierce,
		// Token: 0x040083E9 RID: 33769
		PassiveCriticalStrike,
		// Token: 0x040083EA RID: 33770
		PassiveDodge,
		// Token: 0x040083EB RID: 33771
		PassiveAvoid,
		// Token: 0x040083EC RID: 33772
		PassiveEvade,
		// Token: 0x040083ED RID: 33773
		PassiveWarmth,
		// Token: 0x040083EE RID: 33774
		PassiveMasteryMeleeToHit,
		// Token: 0x040083EF RID: 33775
		PassiveMasteryMeleeDamage,
		// Token: 0x040083F0 RID: 33776
		PassiveMasteryMeleeCritical,
		// Token: 0x040083F1 RID: 33777
		PassiveMasteryThrowToHit,
		// Token: 0x040083F2 RID: 33778
		PassiveMasteryThrowDamage,
		// Token: 0x040083F3 RID: 33779
		PassiveMasteryThrowCritical,
		// Token: 0x040083F4 RID: 33780
		PassiveWeaponBlock,
		// Token: 0x040083F5 RID: 33781
		PassiveSummon_resist,
		// Token: 0x040083F6 RID: 33782
		ModifierListSkill,
		// Token: 0x040083F7 RID: 33783
		ModifierListLevel,
		// Token: 0x040083F8 RID: 33784
		LastSentLifePercent,
		// Token: 0x040083F9 RID: 33785
		SourceUnitType,
		// Token: 0x040083FA RID: 33786
		SourceUnitID,
		// Token: 0x040083FB RID: 33787
		ShortParam1,
		// Token: 0x040083FC RID: 33788
		QuestItemDifficulty,
		// Token: 0x040083FD RID: 33789
		PassiveMagicMastery,
		// Token: 0x040083FE RID: 33790
		PassiveMagicPierce,
		// Token: 0x040083FF RID: 33791
		Invalid,
		// Token: 0x04008400 RID: 33792
		None = 65535
	}
}
