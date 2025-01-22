using System;

namespace D2Data
{
	// Token: 0x0200094F RID: 2383
	public enum ItemType
	{
		// Token: 0x0400733B RID: 29499
		Elixir,
		// Token: 0x0400733C RID: 29500
		PotionOfHealing,
		// Token: 0x0400733D RID: 29501
		PotionOfMana,
		// Token: 0x0400733E RID: 29502
		FullHealingPotion,
		// Token: 0x0400733F RID: 29503
		FullManaPotion,
		// Token: 0x04007340 RID: 29504
		StaminaPotion,
		// Token: 0x04007341 RID: 29505
		AntidotePotion,
		// Token: 0x04007342 RID: 29506
		RejuvenationPotion,
		// Token: 0x04007343 RID: 29507
		FullRejuvenationPotion,
		// Token: 0x04007344 RID: 29508
		ThawingPotion,
		// Token: 0x04007345 RID: 29509
		TomeOfTownPortal,
		// Token: 0x04007346 RID: 29510
		TomeOfIdentify,
		// Token: 0x04007347 RID: 29511
		Amulet,
		// Token: 0x04007348 RID: 29512
		ViperAmulet,
		// Token: 0x04007349 RID: 29513
		Ring,
		// Token: 0x0400734A RID: 29514
		Gold,
		// Token: 0x0400734B RID: 29515
		BarkScroll,
		// Token: 0x0400734C RID: 29516
		DecipheredBarkScroll,
		// Token: 0x0400734D RID: 29517
		Arrows,
		// Token: 0x0400734E RID: 29518
		Torch,
		// Token: 0x0400734F RID: 29519
		Bolts,
		// Token: 0x04007350 RID: 29520
		ScrollOfTownPortal,
		// Token: 0x04007351 RID: 29521
		ScrollOfIdentify,
		// Token: 0x04007352 RID: 29522
		Heart,
		// Token: 0x04007353 RID: 29523
		Brain,
		// Token: 0x04007354 RID: 29524
		Jawbone,
		// Token: 0x04007355 RID: 29525
		Eye,
		// Token: 0x04007356 RID: 29526
		Horn,
		// Token: 0x04007357 RID: 29527
		Tail,
		// Token: 0x04007358 RID: 29528
		Flag,
		// Token: 0x04007359 RID: 29529
		Fang,
		// Token: 0x0400735A RID: 29530
		Quill,
		// Token: 0x0400735B RID: 29531
		Soul,
		// Token: 0x0400735C RID: 29532
		Scalp,
		// Token: 0x0400735D RID: 29533
		Spleen,
		// Token: 0x0400735E RID: 29534
		Key,
		// Token: 0x0400735F RID: 29535
		MephistoKey,
		// Token: 0x04007360 RID: 29536
		ScrollOfSelfResurrect,
		// Token: 0x04007361 RID: 29537
		JadeFigurine,
		// Token: 0x04007362 RID: 29538
		GoldBird,
		// Token: 0x04007363 RID: 29539
		LamEsensTome,
		// Token: 0x04007364 RID: 29540
		HoradricCube,
		// Token: 0x04007365 RID: 29541
		HoradricScroll,
		// Token: 0x04007366 RID: 29542
		MephistoSoulStone,
		// Token: 0x04007367 RID: 29543
		BookOfSkill,
		// Token: 0x04007368 RID: 29544
		KhalimsEye,
		// Token: 0x04007369 RID: 29545
		KhalimsHeart,
		// Token: 0x0400736A RID: 29546
		KhalimsBrain,
		// Token: 0x0400736B RID: 29547
		Ear,
		// Token: 0x0400736C RID: 29548
		ChippedAmethyst,
		// Token: 0x0400736D RID: 29549
		FlawedAmethyst,
		// Token: 0x0400736E RID: 29550
		Amethyst,
		// Token: 0x0400736F RID: 29551
		FlawlessAmethyst,
		// Token: 0x04007370 RID: 29552
		PerfectAmethyst,
		// Token: 0x04007371 RID: 29553
		ChippedTopaz,
		// Token: 0x04007372 RID: 29554
		FlawedTopaz,
		// Token: 0x04007373 RID: 29555
		Topaz,
		// Token: 0x04007374 RID: 29556
		FlawlessTopaz,
		// Token: 0x04007375 RID: 29557
		PerfectTopaz,
		// Token: 0x04007376 RID: 29558
		ChippedSapphire,
		// Token: 0x04007377 RID: 29559
		FlawedSapphire,
		// Token: 0x04007378 RID: 29560
		Sapphire,
		// Token: 0x04007379 RID: 29561
		FlawlessSapphire,
		// Token: 0x0400737A RID: 29562
		PerfectSapphire,
		// Token: 0x0400737B RID: 29563
		ChippedEmerald,
		// Token: 0x0400737C RID: 29564
		FlawedEmerald,
		// Token: 0x0400737D RID: 29565
		Emerald,
		// Token: 0x0400737E RID: 29566
		FlawlessEmerald,
		// Token: 0x0400737F RID: 29567
		PerfectEmerald,
		// Token: 0x04007380 RID: 29568
		ChippedRuby,
		// Token: 0x04007381 RID: 29569
		FlawedRuby,
		// Token: 0x04007382 RID: 29570
		Ruby,
		// Token: 0x04007383 RID: 29571
		FlawlessRuby,
		// Token: 0x04007384 RID: 29572
		PerfectRuby,
		// Token: 0x04007385 RID: 29573
		ChippedDiamond,
		// Token: 0x04007386 RID: 29574
		FlawedDiamond,
		// Token: 0x04007387 RID: 29575
		Diamond,
		// Token: 0x04007388 RID: 29576
		FlawlessDiamond,
		// Token: 0x04007389 RID: 29577
		PerfectDiamond,
		// Token: 0x0400738A RID: 29578
		MinorHealingPotion,
		// Token: 0x0400738B RID: 29579
		LightHealingPotion,
		// Token: 0x0400738C RID: 29580
		HealingPotion,
		// Token: 0x0400738D RID: 29581
		GreaterHealingPotion,
		// Token: 0x0400738E RID: 29582
		SuperHealingPotion,
		// Token: 0x0400738F RID: 29583
		MinorManaPotion,
		// Token: 0x04007390 RID: 29584
		LightManaPotion,
		// Token: 0x04007391 RID: 29585
		ManaPotion,
		// Token: 0x04007392 RID: 29586
		GreaterManaPotion,
		// Token: 0x04007393 RID: 29587
		SuperManaPotion,
		// Token: 0x04007394 RID: 29588
		ChippedSkull,
		// Token: 0x04007395 RID: 29589
		FlawedSkull,
		// Token: 0x04007396 RID: 29590
		Skull,
		// Token: 0x04007397 RID: 29591
		FlawlessSkull,
		// Token: 0x04007398 RID: 29592
		PerfectSkull,
		// Token: 0x04007399 RID: 29593
		Herb,
		// Token: 0x0400739A RID: 29594
		SmallCharm,
		// Token: 0x0400739B RID: 29595
		LargeCharm,
		// Token: 0x0400739C RID: 29596
		GrandCharm,
		// Token: 0x0400739D RID: 29597
		SmallRedPotion,
		// Token: 0x0400739E RID: 29598
		LargeRedPotion,
		// Token: 0x0400739F RID: 29599
		SmallBluePotion,
		// Token: 0x040073A0 RID: 29600
		LargeBluePotion,
		// Token: 0x040073A1 RID: 29601
		ElRune,
		// Token: 0x040073A2 RID: 29602
		EldRune,
		// Token: 0x040073A3 RID: 29603
		TirRune,
		// Token: 0x040073A4 RID: 29604
		NefRune,
		// Token: 0x040073A5 RID: 29605
		EthRune,
		// Token: 0x040073A6 RID: 29606
		IthRune,
		// Token: 0x040073A7 RID: 29607
		TalRune,
		// Token: 0x040073A8 RID: 29608
		RalRune,
		// Token: 0x040073A9 RID: 29609
		OrtRune,
		// Token: 0x040073AA RID: 29610
		ThulRune,
		// Token: 0x040073AB RID: 29611
		AmnRune,
		// Token: 0x040073AC RID: 29612
		SolRune,
		// Token: 0x040073AD RID: 29613
		ShaelRune,
		// Token: 0x040073AE RID: 29614
		DolRune,
		// Token: 0x040073AF RID: 29615
		HelRune,
		// Token: 0x040073B0 RID: 29616
		IoRune,
		// Token: 0x040073B1 RID: 29617
		LumRune,
		// Token: 0x040073B2 RID: 29618
		KoRune,
		// Token: 0x040073B3 RID: 29619
		FalRune,
		// Token: 0x040073B4 RID: 29620
		LemRune,
		// Token: 0x040073B5 RID: 29621
		PulRune,
		// Token: 0x040073B6 RID: 29622
		UmRune,
		// Token: 0x040073B7 RID: 29623
		MalRune,
		// Token: 0x040073B8 RID: 29624
		IstRune,
		// Token: 0x040073B9 RID: 29625
		GulRune,
		// Token: 0x040073BA RID: 29626
		VexRune,
		// Token: 0x040073BB RID: 29627
		OhmRune,
		// Token: 0x040073BC RID: 29628
		LoRune,
		// Token: 0x040073BD RID: 29629
		SurRune,
		// Token: 0x040073BE RID: 29630
		BerRune,
		// Token: 0x040073BF RID: 29631
		JahRune,
		// Token: 0x040073C0 RID: 29632
		ChamRune,
		// Token: 0x040073C1 RID: 29633
		ZodRune,
		// Token: 0x040073C2 RID: 29634
		Jewel,
		// Token: 0x040073C3 RID: 29635
		Maguffin,
		// Token: 0x040073C4 RID: 29636
		Scroll,
		// Token: 0x040073C5 RID: 29637
		ScrollOfMalah,
		// Token: 0x040073C6 RID: 29638
		KeyOfTerror,
		// Token: 0x040073C7 RID: 29639
		KeyOfHate,
		// Token: 0x040073C8 RID: 29640
		KeyOfDestruction,
		// Token: 0x040073C9 RID: 29641
		DiablosHorn,
		// Token: 0x040073CA RID: 29642
		BaalsEye,
		// Token: 0x040073CB RID: 29643
		MephistosBrain,
		// Token: 0x040073CC RID: 29644
		StandardOfHeroes,
		// Token: 0x040073CD RID: 29645
		Suffering,
		// Token: 0x040073CE RID: 29646
		Hated,
		// Token: 0x040073CF RID: 29647
		Terror,
		// Token: 0x040073D0 RID: 29648
		Destruction,
		// Token: 0x040073D1 RID: 29649
		TokenOfAbsolution,
		// Token: 0x040073D2 RID: 29650
		Cap,
		// Token: 0x040073D3 RID: 29651
		SkullCap,
		// Token: 0x040073D4 RID: 29652
		Helm,
		// Token: 0x040073D5 RID: 29653
		FullHelm,
		// Token: 0x040073D6 RID: 29654
		GreatHelm,
		// Token: 0x040073D7 RID: 29655
		Crown,
		// Token: 0x040073D8 RID: 29656
		Mask,
		// Token: 0x040073D9 RID: 29657
		QuiltedArmor,
		// Token: 0x040073DA RID: 29658
		LeatherArmor,
		// Token: 0x040073DB RID: 29659
		HardLeatherArmor,
		// Token: 0x040073DC RID: 29660
		StuddedLeather,
		// Token: 0x040073DD RID: 29661
		RingMail,
		// Token: 0x040073DE RID: 29662
		ScaleMail,
		// Token: 0x040073DF RID: 29663
		ChainMail,
		// Token: 0x040073E0 RID: 29664
		BreastPlate,
		// Token: 0x040073E1 RID: 29665
		SplintMail,
		// Token: 0x040073E2 RID: 29666
		PlateMail,
		// Token: 0x040073E3 RID: 29667
		FieldPlate,
		// Token: 0x040073E4 RID: 29668
		GothicPlate,
		// Token: 0x040073E5 RID: 29669
		FullPlateMail,
		// Token: 0x040073E6 RID: 29670
		AncientArmor,
		// Token: 0x040073E7 RID: 29671
		LightPlate,
		// Token: 0x040073E8 RID: 29672
		Buckler,
		// Token: 0x040073E9 RID: 29673
		SmallShield,
		// Token: 0x040073EA RID: 29674
		LargeShield,
		// Token: 0x040073EB RID: 29675
		KiteShield,
		// Token: 0x040073EC RID: 29676
		TowerShield,
		// Token: 0x040073ED RID: 29677
		GothicShield,
		// Token: 0x040073EE RID: 29678
		Gloves,
		// Token: 0x040073EF RID: 29679
		HeavyGloves,
		// Token: 0x040073F0 RID: 29680
		ChainGloves,
		// Token: 0x040073F1 RID: 29681
		LightGauntlets,
		// Token: 0x040073F2 RID: 29682
		Gaunlets,
		// Token: 0x040073F3 RID: 29683
		LeatherBoots,
		// Token: 0x040073F4 RID: 29684
		HeavyBoots,
		// Token: 0x040073F5 RID: 29685
		ChainBoots,
		// Token: 0x040073F6 RID: 29686
		LightPlateBoots,
		// Token: 0x040073F7 RID: 29687
		PlateBoots,
		// Token: 0x040073F8 RID: 29688
		Sash,
		// Token: 0x040073F9 RID: 29689
		LightBelt,
		// Token: 0x040073FA RID: 29690
		Belt,
		// Token: 0x040073FB RID: 29691
		HeavyBelt,
		// Token: 0x040073FC RID: 29692
		PlatedBelt,
		// Token: 0x040073FD RID: 29693
		BoneHelm,
		// Token: 0x040073FE RID: 29694
		BoneShield,
		// Token: 0x040073FF RID: 29695
		SpikedShield,
		// Token: 0x04007400 RID: 29696
		WarHat,
		// Token: 0x04007401 RID: 29697
		Sallet,
		// Token: 0x04007402 RID: 29698
		Casque,
		// Token: 0x04007403 RID: 29699
		Basinet,
		// Token: 0x04007404 RID: 29700
		WingedHelm,
		// Token: 0x04007405 RID: 29701
		GrandCrown,
		// Token: 0x04007406 RID: 29702
		DeathMask,
		// Token: 0x04007407 RID: 29703
		GhostArmor,
		// Token: 0x04007408 RID: 29704
		SerpentskinArmor,
		// Token: 0x04007409 RID: 29705
		DemonhideArmor,
		// Token: 0x0400740A RID: 29706
		TrellisedArmor,
		// Token: 0x0400740B RID: 29707
		LinkedMail,
		// Token: 0x0400740C RID: 29708
		TigulatedMail,
		// Token: 0x0400740D RID: 29709
		MeshArmor,
		// Token: 0x0400740E RID: 29710
		Cuirass,
		// Token: 0x0400740F RID: 29711
		RussetArmor,
		// Token: 0x04007410 RID: 29712
		TemplarCoat,
		// Token: 0x04007411 RID: 29713
		SharktoothArmor,
		// Token: 0x04007412 RID: 29714
		EmbossedPlate,
		// Token: 0x04007413 RID: 29715
		ChaosArmor,
		// Token: 0x04007414 RID: 29716
		OrnateArmor,
		// Token: 0x04007415 RID: 29717
		MagePlate,
		// Token: 0x04007416 RID: 29718
		Defender,
		// Token: 0x04007417 RID: 29719
		RoundShield,
		// Token: 0x04007418 RID: 29720
		Scutum,
		// Token: 0x04007419 RID: 29721
		DragonShield,
		// Token: 0x0400741A RID: 29722
		Pavise,
		// Token: 0x0400741B RID: 29723
		AncientShield,
		// Token: 0x0400741C RID: 29724
		DemonhideGloves,
		// Token: 0x0400741D RID: 29725
		SharkskinGloves,
		// Token: 0x0400741E RID: 29726
		HeavyBracers,
		// Token: 0x0400741F RID: 29727
		BattleGauntlets,
		// Token: 0x04007420 RID: 29728
		WarGauntlets,
		// Token: 0x04007421 RID: 29729
		DemonhideBoots,
		// Token: 0x04007422 RID: 29730
		SharkskinBoots,
		// Token: 0x04007423 RID: 29731
		MeshBoots,
		// Token: 0x04007424 RID: 29732
		BattleBoots,
		// Token: 0x04007425 RID: 29733
		WarBoots,
		// Token: 0x04007426 RID: 29734
		DemonhideSash,
		// Token: 0x04007427 RID: 29735
		SharkskinBelt,
		// Token: 0x04007428 RID: 29736
		MeshBelt,
		// Token: 0x04007429 RID: 29737
		BattleBelt,
		// Token: 0x0400742A RID: 29738
		WarBelt,
		// Token: 0x0400742B RID: 29739
		GrimHelm,
		// Token: 0x0400742C RID: 29740
		GrimShield,
		// Token: 0x0400742D RID: 29741
		BarbedShield,
		// Token: 0x0400742E RID: 29742
		WolfHead,
		// Token: 0x0400742F RID: 29743
		HawkHelm,
		// Token: 0x04007430 RID: 29744
		Antlers,
		// Token: 0x04007431 RID: 29745
		FalconMask,
		// Token: 0x04007432 RID: 29746
		SpiritMask,
		// Token: 0x04007433 RID: 29747
		JawboneCap,
		// Token: 0x04007434 RID: 29748
		FangedHelm,
		// Token: 0x04007435 RID: 29749
		HornedHelm,
		// Token: 0x04007436 RID: 29750
		AssaultHelmet,
		// Token: 0x04007437 RID: 29751
		AvengerGuard,
		// Token: 0x04007438 RID: 29752
		Targe,
		// Token: 0x04007439 RID: 29753
		Rondache,
		// Token: 0x0400743A RID: 29754
		HeraldicShield,
		// Token: 0x0400743B RID: 29755
		AerinShield,
		// Token: 0x0400743C RID: 29756
		CrownShield,
		// Token: 0x0400743D RID: 29757
		PreservedHead,
		// Token: 0x0400743E RID: 29758
		ZombieHead,
		// Token: 0x0400743F RID: 29759
		UnravellerHead,
		// Token: 0x04007440 RID: 29760
		GargoyleHead,
		// Token: 0x04007441 RID: 29761
		DemonHead,
		// Token: 0x04007442 RID: 29762
		Circlet,
		// Token: 0x04007443 RID: 29763
		Coronet,
		// Token: 0x04007444 RID: 29764
		Tiara,
		// Token: 0x04007445 RID: 29765
		Diadem,
		// Token: 0x04007446 RID: 29766
		Shako,
		// Token: 0x04007447 RID: 29767
		Hydraskull,
		// Token: 0x04007448 RID: 29768
		Armet,
		// Token: 0x04007449 RID: 29769
		GiantConch,
		// Token: 0x0400744A RID: 29770
		SpiredHelm,
		// Token: 0x0400744B RID: 29771
		Corona,
		// Token: 0x0400744C RID: 29772
		Demonhead,
		// Token: 0x0400744D RID: 29773
		DuskShroud,
		// Token: 0x0400744E RID: 29774
		Wyrmhide,
		// Token: 0x0400744F RID: 29775
		ScarabHusk,
		// Token: 0x04007450 RID: 29776
		WireFleece,
		// Token: 0x04007451 RID: 29777
		DiamondMail,
		// Token: 0x04007452 RID: 29778
		LoricatedMail,
		// Token: 0x04007453 RID: 29779
		Boneweave,
		// Token: 0x04007454 RID: 29780
		GreatHauberk,
		// Token: 0x04007455 RID: 29781
		BalrogSkin,
		// Token: 0x04007456 RID: 29782
		HellforgedPlate,
		// Token: 0x04007457 RID: 29783
		KrakenShell,
		// Token: 0x04007458 RID: 29784
		LacqueredPlate,
		// Token: 0x04007459 RID: 29785
		ShadowPlate,
		// Token: 0x0400745A RID: 29786
		SacredArmor,
		// Token: 0x0400745B RID: 29787
		ArchonPlate,
		// Token: 0x0400745C RID: 29788
		Heater,
		// Token: 0x0400745D RID: 29789
		Luna,
		// Token: 0x0400745E RID: 29790
		Hyperion,
		// Token: 0x0400745F RID: 29791
		Monarch,
		// Token: 0x04007460 RID: 29792
		Aegis,
		// Token: 0x04007461 RID: 29793
		Ward,
		// Token: 0x04007462 RID: 29794
		BrambleMitts,
		// Token: 0x04007463 RID: 29795
		VampireboneGloves,
		// Token: 0x04007464 RID: 29796
		Vambraces,
		// Token: 0x04007465 RID: 29797
		CrusaderGauntlets,
		// Token: 0x04007466 RID: 29798
		OgreGauntlets,
		// Token: 0x04007467 RID: 29799
		WyrmhideBoots,
		// Token: 0x04007468 RID: 29800
		ScarabshellBoots,
		// Token: 0x04007469 RID: 29801
		BoneweaveBoots,
		// Token: 0x0400746A RID: 29802
		MirroredBoots,
		// Token: 0x0400746B RID: 29803
		MyrmidonGreaves,
		// Token: 0x0400746C RID: 29804
		SpiderwebSash,
		// Token: 0x0400746D RID: 29805
		VampirefangBelt,
		// Token: 0x0400746E RID: 29806
		MithrilCoil,
		// Token: 0x0400746F RID: 29807
		TrollBelt,
		// Token: 0x04007470 RID: 29808
		ColossusGirdle,
		// Token: 0x04007471 RID: 29809
		BoneVisage,
		// Token: 0x04007472 RID: 29810
		TrollNest,
		// Token: 0x04007473 RID: 29811
		BladeBarrier,
		// Token: 0x04007474 RID: 29812
		AlphaHelm,
		// Token: 0x04007475 RID: 29813
		GriffonHeadress,
		// Token: 0x04007476 RID: 29814
		HuntersGuise,
		// Token: 0x04007477 RID: 29815
		SacredFeathers,
		// Token: 0x04007478 RID: 29816
		TotemicMask,
		// Token: 0x04007479 RID: 29817
		JawboneVisor,
		// Token: 0x0400747A RID: 29818
		LionHelm,
		// Token: 0x0400747B RID: 29819
		RageMask,
		// Token: 0x0400747C RID: 29820
		SavageHelmet,
		// Token: 0x0400747D RID: 29821
		SlayerGuard,
		// Token: 0x0400747E RID: 29822
		AkaranTarge,
		// Token: 0x0400747F RID: 29823
		AkaranRondache,
		// Token: 0x04007480 RID: 29824
		ProtectorShield,
		// Token: 0x04007481 RID: 29825
		GuildedShield,
		// Token: 0x04007482 RID: 29826
		RoyalShield,
		// Token: 0x04007483 RID: 29827
		MummifiedTrophy,
		// Token: 0x04007484 RID: 29828
		FetishTrophy,
		// Token: 0x04007485 RID: 29829
		SextonTrophy,
		// Token: 0x04007486 RID: 29830
		CantorTrophy,
		// Token: 0x04007487 RID: 29831
		HierophantTrophy,
		// Token: 0x04007488 RID: 29832
		BloodSpirt,
		// Token: 0x04007489 RID: 29833
		SunSpirit,
		// Token: 0x0400748A RID: 29834
		EarthSpirit,
		// Token: 0x0400748B RID: 29835
		SkySpirit,
		// Token: 0x0400748C RID: 29836
		DreamSpirit,
		// Token: 0x0400748D RID: 29837
		CarnageHelm,
		// Token: 0x0400748E RID: 29838
		FuryVisor,
		// Token: 0x0400748F RID: 29839
		DestroyerHelm,
		// Token: 0x04007490 RID: 29840
		ConquerorCrown,
		// Token: 0x04007491 RID: 29841
		GuardianCrown,
		// Token: 0x04007492 RID: 29842
		SacredTarge,
		// Token: 0x04007493 RID: 29843
		SacredRondache,
		// Token: 0x04007494 RID: 29844
		KurastShield,
		// Token: 0x04007495 RID: 29845
		ZakarumShield,
		// Token: 0x04007496 RID: 29846
		VortexShield,
		// Token: 0x04007497 RID: 29847
		MinionSkull,
		// Token: 0x04007498 RID: 29848
		HellspawnSkull,
		// Token: 0x04007499 RID: 29849
		OverseerSkull,
		// Token: 0x0400749A RID: 29850
		SuccubusSkull,
		// Token: 0x0400749B RID: 29851
		BloodlordSkull,
		// Token: 0x0400749C RID: 29852
		HandAxe,
		// Token: 0x0400749D RID: 29853
		Axe,
		// Token: 0x0400749E RID: 29854
		DoubleAxe,
		// Token: 0x0400749F RID: 29855
		MilitaryPick,
		// Token: 0x040074A0 RID: 29856
		WarAxe,
		// Token: 0x040074A1 RID: 29857
		LargeAxe,
		// Token: 0x040074A2 RID: 29858
		BroadAxe,
		// Token: 0x040074A3 RID: 29859
		BattleAxe,
		// Token: 0x040074A4 RID: 29860
		GreatAxe,
		// Token: 0x040074A5 RID: 29861
		GiantAxe,
		// Token: 0x040074A6 RID: 29862
		Wand,
		// Token: 0x040074A7 RID: 29863
		YewWand,
		// Token: 0x040074A8 RID: 29864
		BoneWand,
		// Token: 0x040074A9 RID: 29865
		GrimWand,
		// Token: 0x040074AA RID: 29866
		Club,
		// Token: 0x040074AB RID: 29867
		Scepter,
		// Token: 0x040074AC RID: 29868
		GrandScepter,
		// Token: 0x040074AD RID: 29869
		WarScepter,
		// Token: 0x040074AE RID: 29870
		SpikedClub,
		// Token: 0x040074AF RID: 29871
		Mace,
		// Token: 0x040074B0 RID: 29872
		MorningStar,
		// Token: 0x040074B1 RID: 29873
		Flail,
		// Token: 0x040074B2 RID: 29874
		WarHammer,
		// Token: 0x040074B3 RID: 29875
		Maul,
		// Token: 0x040074B4 RID: 29876
		GreatMaul,
		// Token: 0x040074B5 RID: 29877
		ShortSword,
		// Token: 0x040074B6 RID: 29878
		Scimitar,
		// Token: 0x040074B7 RID: 29879
		Saber,
		// Token: 0x040074B8 RID: 29880
		Falchion,
		// Token: 0x040074B9 RID: 29881
		CrystalSword,
		// Token: 0x040074BA RID: 29882
		BroadSword,
		// Token: 0x040074BB RID: 29883
		LongSword,
		// Token: 0x040074BC RID: 29884
		WarSword,
		// Token: 0x040074BD RID: 29885
		TwoHandedSword,
		// Token: 0x040074BE RID: 29886
		Claymore,
		// Token: 0x040074BF RID: 29887
		GiantSword,
		// Token: 0x040074C0 RID: 29888
		BastardSword,
		// Token: 0x040074C1 RID: 29889
		Flamberge,
		// Token: 0x040074C2 RID: 29890
		GreatSword,
		// Token: 0x040074C3 RID: 29891
		Dagger,
		// Token: 0x040074C4 RID: 29892
		Dirk,
		// Token: 0x040074C5 RID: 29893
		Kris,
		// Token: 0x040074C6 RID: 29894
		Blade,
		// Token: 0x040074C7 RID: 29895
		ThrowingKnife,
		// Token: 0x040074C8 RID: 29896
		ThrowingAxe,
		// Token: 0x040074C9 RID: 29897
		BalancedKnife,
		// Token: 0x040074CA RID: 29898
		BalancedAxe,
		// Token: 0x040074CB RID: 29899
		Javelin,
		// Token: 0x040074CC RID: 29900
		Pilum,
		// Token: 0x040074CD RID: 29901
		ShortSpear,
		// Token: 0x040074CE RID: 29902
		Glaive,
		// Token: 0x040074CF RID: 29903
		ThrowingSpear,
		// Token: 0x040074D0 RID: 29904
		Spear,
		// Token: 0x040074D1 RID: 29905
		Trident,
		// Token: 0x040074D2 RID: 29906
		Brandistock,
		// Token: 0x040074D3 RID: 29907
		Spetum,
		// Token: 0x040074D4 RID: 29908
		Pike,
		// Token: 0x040074D5 RID: 29909
		Bardiche,
		// Token: 0x040074D6 RID: 29910
		Voulge,
		// Token: 0x040074D7 RID: 29911
		Scythe,
		// Token: 0x040074D8 RID: 29912
		Poleaxe,
		// Token: 0x040074D9 RID: 29913
		Halberd,
		// Token: 0x040074DA RID: 29914
		WarScythe,
		// Token: 0x040074DB RID: 29915
		ShortStaff,
		// Token: 0x040074DC RID: 29916
		LongStaff,
		// Token: 0x040074DD RID: 29917
		GnarledStaff,
		// Token: 0x040074DE RID: 29918
		BattleStaff,
		// Token: 0x040074DF RID: 29919
		WarStaff,
		// Token: 0x040074E0 RID: 29920
		ShortBow,
		// Token: 0x040074E1 RID: 29921
		HuntersBow,
		// Token: 0x040074E2 RID: 29922
		LongBow,
		// Token: 0x040074E3 RID: 29923
		CompositeBow,
		// Token: 0x040074E4 RID: 29924
		ShortBattleBow,
		// Token: 0x040074E5 RID: 29925
		LongBattleBow,
		// Token: 0x040074E6 RID: 29926
		ShortWarBow,
		// Token: 0x040074E7 RID: 29927
		LongWarBow,
		// Token: 0x040074E8 RID: 29928
		LightCrossbow,
		// Token: 0x040074E9 RID: 29929
		Crossbow,
		// Token: 0x040074EA RID: 29930
		HeavyCrossbow,
		// Token: 0x040074EB RID: 29931
		RepeatingCrossbow,
		// Token: 0x040074EC RID: 29932
		RancidGasPotion,
		// Token: 0x040074ED RID: 29933
		OilPotion,
		// Token: 0x040074EE RID: 29934
		ChokingGasPotion,
		// Token: 0x040074EF RID: 29935
		ExplodingPotion,
		// Token: 0x040074F0 RID: 29936
		StranglingGasPotion,
		// Token: 0x040074F1 RID: 29937
		FulminatingPotion,
		// Token: 0x040074F2 RID: 29938
		DecoyDagger,
		// Token: 0x040074F3 RID: 29939
		Gidbinn,
		// Token: 0x040074F4 RID: 29940
		WirtsLeg,
		// Token: 0x040074F5 RID: 29941
		HoradricMalus,
		// Token: 0x040074F6 RID: 29942
		HellforgeHammer,
		// Token: 0x040074F7 RID: 29943
		HoradricStaff,
		// Token: 0x040074F8 RID: 29944
		StaffOfKings,
		// Token: 0x040074F9 RID: 29945
		Hatchet,
		// Token: 0x040074FA RID: 29946
		Cleaver,
		// Token: 0x040074FB RID: 29947
		TwinAxe,
		// Token: 0x040074FC RID: 29948
		Crowbill,
		// Token: 0x040074FD RID: 29949
		Naga,
		// Token: 0x040074FE RID: 29950
		MilitaryAxe,
		// Token: 0x040074FF RID: 29951
		BeardedAxe,
		// Token: 0x04007500 RID: 29952
		Tabar,
		// Token: 0x04007501 RID: 29953
		GothicAxe,
		// Token: 0x04007502 RID: 29954
		AncientAxe,
		// Token: 0x04007503 RID: 29955
		BurntWand,
		// Token: 0x04007504 RID: 29956
		PetrifiedWand,
		// Token: 0x04007505 RID: 29957
		TombWand,
		// Token: 0x04007506 RID: 29958
		GraveWand,
		// Token: 0x04007507 RID: 29959
		Cudgel,
		// Token: 0x04007508 RID: 29960
		RuneScepter,
		// Token: 0x04007509 RID: 29961
		HolyWaterSprinkler,
		// Token: 0x0400750A RID: 29962
		DivineScepter,
		// Token: 0x0400750B RID: 29963
		BarbedClub,
		// Token: 0x0400750C RID: 29964
		FlangedMace,
		// Token: 0x0400750D RID: 29965
		JaggedStar,
		// Token: 0x0400750E RID: 29966
		Knout,
		// Token: 0x0400750F RID: 29967
		BattleHammer,
		// Token: 0x04007510 RID: 29968
		WarClub,
		// Token: 0x04007511 RID: 29969
		MartelDeFer,
		// Token: 0x04007512 RID: 29970
		Gladius,
		// Token: 0x04007513 RID: 29971
		Cutlass,
		// Token: 0x04007514 RID: 29972
		Shamshir,
		// Token: 0x04007515 RID: 29973
		Tulwar,
		// Token: 0x04007516 RID: 29974
		DimensionalBlade,
		// Token: 0x04007517 RID: 29975
		BattleSword,
		// Token: 0x04007518 RID: 29976
		RuneSword,
		// Token: 0x04007519 RID: 29977
		AncientSword,
		// Token: 0x0400751A RID: 29978
		Espadon,
		// Token: 0x0400751B RID: 29979
		DacianFalx,
		// Token: 0x0400751C RID: 29980
		TuskSword,
		// Token: 0x0400751D RID: 29981
		GothicSword,
		// Token: 0x0400751E RID: 29982
		Zweihander,
		// Token: 0x0400751F RID: 29983
		ExecutionerSword,
		// Token: 0x04007520 RID: 29984
		Poignard,
		// Token: 0x04007521 RID: 29985
		Rondel,
		// Token: 0x04007522 RID: 29986
		Cinquedeas,
		// Token: 0x04007523 RID: 29987
		Stilleto,
		// Token: 0x04007524 RID: 29988
		BattleDart,
		// Token: 0x04007525 RID: 29989
		Francisca,
		// Token: 0x04007526 RID: 29990
		WarDart,
		// Token: 0x04007527 RID: 29991
		Hurlbat,
		// Token: 0x04007528 RID: 29992
		WarJavelin,
		// Token: 0x04007529 RID: 29993
		GreatPilum,
		// Token: 0x0400752A RID: 29994
		Simbilan,
		// Token: 0x0400752B RID: 29995
		Spiculum,
		// Token: 0x0400752C RID: 29996
		Harpoon,
		// Token: 0x0400752D RID: 29997
		WarSpear,
		// Token: 0x0400752E RID: 29998
		Fuscina,
		// Token: 0x0400752F RID: 29999
		WarFork,
		// Token: 0x04007530 RID: 30000
		Yari,
		// Token: 0x04007531 RID: 30001
		Lance,
		// Token: 0x04007532 RID: 30002
		LochaberAxe,
		// Token: 0x04007533 RID: 30003
		Bill,
		// Token: 0x04007534 RID: 30004
		BattleScythe,
		// Token: 0x04007535 RID: 30005
		Partizan,
		// Token: 0x04007536 RID: 30006
		BecDeCorbin,
		// Token: 0x04007537 RID: 30007
		GrimScythe,
		// Token: 0x04007538 RID: 30008
		JoStaff,
		// Token: 0x04007539 RID: 30009
		Quarterstaff,
		// Token: 0x0400753A RID: 30010
		CedarStaff,
		// Token: 0x0400753B RID: 30011
		GothicStaff,
		// Token: 0x0400753C RID: 30012
		RuneStaff,
		// Token: 0x0400753D RID: 30013
		EdgeBow,
		// Token: 0x0400753E RID: 30014
		RazorBow,
		// Token: 0x0400753F RID: 30015
		CedarBow,
		// Token: 0x04007540 RID: 30016
		DoubleBow,
		// Token: 0x04007541 RID: 30017
		ShortSiegeBow,
		// Token: 0x04007542 RID: 30018
		LongSiegeBow,
		// Token: 0x04007543 RID: 30019
		RuneBow,
		// Token: 0x04007544 RID: 30020
		GothicBow,
		// Token: 0x04007545 RID: 30021
		Arbalest,
		// Token: 0x04007546 RID: 30022
		SiegeCrossbow,
		// Token: 0x04007547 RID: 30023
		Balista,
		// Token: 0x04007548 RID: 30024
		ChuKoNu,
		// Token: 0x04007549 RID: 30025
		KhalimFlail,
		// Token: 0x0400754A RID: 30026
		SuperKhalimFlail,
		// Token: 0x0400754B RID: 30027
		Katar,
		// Token: 0x0400754C RID: 30028
		WristBlade,
		// Token: 0x0400754D RID: 30029
		HatchetHands,
		// Token: 0x0400754E RID: 30030
		Cestus,
		// Token: 0x0400754F RID: 30031
		Claws,
		// Token: 0x04007550 RID: 30032
		BladeTalons,
		// Token: 0x04007551 RID: 30033
		ScissorsKatar,
		// Token: 0x04007552 RID: 30034
		Quhab,
		// Token: 0x04007553 RID: 30035
		WristSpike,
		// Token: 0x04007554 RID: 30036
		Fascia,
		// Token: 0x04007555 RID: 30037
		HandScythe,
		// Token: 0x04007556 RID: 30038
		GreaterClaws,
		// Token: 0x04007557 RID: 30039
		GreaterTalons,
		// Token: 0x04007558 RID: 30040
		ScissorsQuhab,
		// Token: 0x04007559 RID: 30041
		Suwayyah,
		// Token: 0x0400755A RID: 30042
		WristSword,
		// Token: 0x0400755B RID: 30043
		WarFist,
		// Token: 0x0400755C RID: 30044
		BattleCestus,
		// Token: 0x0400755D RID: 30045
		FeralClaws,
		// Token: 0x0400755E RID: 30046
		RunicTalons,
		// Token: 0x0400755F RID: 30047
		ScissorsSuwayyah,
		// Token: 0x04007560 RID: 30048
		Tomahawk,
		// Token: 0x04007561 RID: 30049
		SmallCrescent,
		// Token: 0x04007562 RID: 30050
		EttinAxe,
		// Token: 0x04007563 RID: 30051
		WarSpike,
		// Token: 0x04007564 RID: 30052
		BerserkerAxe,
		// Token: 0x04007565 RID: 30053
		FeralAxe,
		// Token: 0x04007566 RID: 30054
		SilverEdgedAxe,
		// Token: 0x04007567 RID: 30055
		Decapitator,
		// Token: 0x04007568 RID: 30056
		ChampionAxe,
		// Token: 0x04007569 RID: 30057
		GloriousAxe,
		// Token: 0x0400756A RID: 30058
		PolishedWand,
		// Token: 0x0400756B RID: 30059
		GhostWand,
		// Token: 0x0400756C RID: 30060
		LichWand,
		// Token: 0x0400756D RID: 30061
		UnearthedWand,
		// Token: 0x0400756E RID: 30062
		Truncheon,
		// Token: 0x0400756F RID: 30063
		MightyScepter,
		// Token: 0x04007570 RID: 30064
		SeraphRod,
		// Token: 0x04007571 RID: 30065
		Caduceus,
		// Token: 0x04007572 RID: 30066
		TyrantClub,
		// Token: 0x04007573 RID: 30067
		ReinforcedMace,
		// Token: 0x04007574 RID: 30068
		DevilStar,
		// Token: 0x04007575 RID: 30069
		Scourge,
		// Token: 0x04007576 RID: 30070
		LegendaryMallet,
		// Token: 0x04007577 RID: 30071
		OgreMaul,
		// Token: 0x04007578 RID: 30072
		ThunderMaul,
		// Token: 0x04007579 RID: 30073
		Falcata,
		// Token: 0x0400757A RID: 30074
		Ataghan,
		// Token: 0x0400757B RID: 30075
		ElegantBlade,
		// Token: 0x0400757C RID: 30076
		HydraEdge,
		// Token: 0x0400757D RID: 30077
		PhaseBlade,
		// Token: 0x0400757E RID: 30078
		ConquestSword,
		// Token: 0x0400757F RID: 30079
		CrypticSword,
		// Token: 0x04007580 RID: 30080
		MythicalSword,
		// Token: 0x04007581 RID: 30081
		LegendSword,
		// Token: 0x04007582 RID: 30082
		HighlandBlade,
		// Token: 0x04007583 RID: 30083
		BalrogBlade,
		// Token: 0x04007584 RID: 30084
		ChampionSword,
		// Token: 0x04007585 RID: 30085
		ColossalSword,
		// Token: 0x04007586 RID: 30086
		ColossusBlade,
		// Token: 0x04007587 RID: 30087
		BoneKnife,
		// Token: 0x04007588 RID: 30088
		MithralPoint,
		// Token: 0x04007589 RID: 30089
		FangedKnife,
		// Token: 0x0400758A RID: 30090
		LegendSpike,
		// Token: 0x0400758B RID: 30091
		FlyingKnife,
		// Token: 0x0400758C RID: 30092
		FlyingAxe,
		// Token: 0x0400758D RID: 30093
		WingedKnife,
		// Token: 0x0400758E RID: 30094
		WingedAxe,
		// Token: 0x0400758F RID: 30095
		HyperionJavelin,
		// Token: 0x04007590 RID: 30096
		StygianPilum,
		// Token: 0x04007591 RID: 30097
		BalrogSpear,
		// Token: 0x04007592 RID: 30098
		GhostGlaive,
		// Token: 0x04007593 RID: 30099
		WingedHarpoon,
		// Token: 0x04007594 RID: 30100
		HyperionSpear,
		// Token: 0x04007595 RID: 30101
		StygianPike,
		// Token: 0x04007596 RID: 30102
		Mancatcher,
		// Token: 0x04007597 RID: 30103
		GhostSpear,
		// Token: 0x04007598 RID: 30104
		WarPike,
		// Token: 0x04007599 RID: 30105
		OgreAxe,
		// Token: 0x0400759A RID: 30106
		ColossusVoulge,
		// Token: 0x0400759B RID: 30107
		Thresher,
		// Token: 0x0400759C RID: 30108
		CrypticAxe,
		// Token: 0x0400759D RID: 30109
		GreatPoleaxe,
		// Token: 0x0400759E RID: 30110
		GiantThresher,
		// Token: 0x0400759F RID: 30111
		WalkingStick,
		// Token: 0x040075A0 RID: 30112
		Stalagmite,
		// Token: 0x040075A1 RID: 30113
		ElderStaff,
		// Token: 0x040075A2 RID: 30114
		Shillelagh,
		// Token: 0x040075A3 RID: 30115
		ArchonStaff,
		// Token: 0x040075A4 RID: 30116
		SpiderBow,
		// Token: 0x040075A5 RID: 30117
		BladeBow,
		// Token: 0x040075A6 RID: 30118
		ShadowBow,
		// Token: 0x040075A7 RID: 30119
		GreatBow,
		// Token: 0x040075A8 RID: 30120
		DiamondBow,
		// Token: 0x040075A9 RID: 30121
		CrusaderBow,
		// Token: 0x040075AA RID: 30122
		WardBow,
		// Token: 0x040075AB RID: 30123
		HydraBow,
		// Token: 0x040075AC RID: 30124
		PelletBow,
		// Token: 0x040075AD RID: 30125
		GorgonCrossbow,
		// Token: 0x040075AE RID: 30126
		ColossusCrossbow,
		// Token: 0x040075AF RID: 30127
		DemonCrossbow,
		// Token: 0x040075B0 RID: 30128
		EagleOrb,
		// Token: 0x040075B1 RID: 30129
		SacredGlobe,
		// Token: 0x040075B2 RID: 30130
		SmokedSphere,
		// Token: 0x040075B3 RID: 30131
		ClaspedOrb,
		// Token: 0x040075B4 RID: 30132
		DragonStone,
		// Token: 0x040075B5 RID: 30133
		StagBow,
		// Token: 0x040075B6 RID: 30134
		ReflexBow,
		// Token: 0x040075B7 RID: 30135
		MaidenSpear,
		// Token: 0x040075B8 RID: 30136
		MaidenPike,
		// Token: 0x040075B9 RID: 30137
		MaidenJavelin,
		// Token: 0x040075BA RID: 30138
		GlowingOrb,
		// Token: 0x040075BB RID: 30139
		CrystallineGlobe,
		// Token: 0x040075BC RID: 30140
		CloudySphere,
		// Token: 0x040075BD RID: 30141
		SparklingBall,
		// Token: 0x040075BE RID: 30142
		SwirlingCrystal,
		// Token: 0x040075BF RID: 30143
		AshwoodBow,
		// Token: 0x040075C0 RID: 30144
		CeremonialBow,
		// Token: 0x040075C1 RID: 30145
		CeremonialSpear,
		// Token: 0x040075C2 RID: 30146
		CeremonialPike,
		// Token: 0x040075C3 RID: 30147
		CeremonialJavelin,
		// Token: 0x040075C4 RID: 30148
		HeavenlyStone,
		// Token: 0x040075C5 RID: 30149
		EldritchOrb,
		// Token: 0x040075C6 RID: 30150
		DemonHeart,
		// Token: 0x040075C7 RID: 30151
		VortexOrb,
		// Token: 0x040075C8 RID: 30152
		DimensionalShard,
		// Token: 0x040075C9 RID: 30153
		MatriarchalBow,
		// Token: 0x040075CA RID: 30154
		GrandMatronBow,
		// Token: 0x040075CB RID: 30155
		MatriarchalSpear,
		// Token: 0x040075CC RID: 30156
		MatriarchalPike,
		// Token: 0x040075CD RID: 30157
		MatriarchalJavelin,
		// Token: 0x040075CE RID: 30158
		Invalid,
		// Token: 0x040075CF RID: 30159
		None = -1
	}
}
