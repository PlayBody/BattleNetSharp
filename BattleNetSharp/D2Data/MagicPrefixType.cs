using System;

namespace D2Data
{
	// Token: 0x02000953 RID: 2387
	public enum MagicPrefixType
	{
		// Token: 0x040075ED RID: 30189
		None,
		// Token: 0x040075EE RID: 30190
		Unused1,
		// Token: 0x040075EF RID: 30191
		Sturdy,
		// Token: 0x040075F0 RID: 30192
		Strong,
		// Token: 0x040075F1 RID: 30193
		Glorious,
		// Token: 0x040075F2 RID: 30194
		Blessed,
		// Token: 0x040075F3 RID: 30195
		Saintly,
		// Token: 0x040075F4 RID: 30196
		Holy,
		// Token: 0x040075F5 RID: 30197
		Devious,
		// Token: 0x040075F6 RID: 30198
		Fortified,
		// Token: 0x040075F7 RID: 30199
		Unused10,
		// Token: 0x040075F8 RID: 30200
		Unused11,
		// Token: 0x040075F9 RID: 30201
		Unused12,
		// Token: 0x040075FA RID: 30202
		Jagged6,
		// Token: 0x040075FB RID: 30203
		Deadly,
		// Token: 0x040075FC RID: 30204
		Vicious,
		// Token: 0x040075FD RID: 30205
		Brutal,
		// Token: 0x040075FE RID: 30206
		Massive,
		// Token: 0x040075FF RID: 30207
		Savage,
		// Token: 0x04007600 RID: 30208
		Merciless,
		// Token: 0x04007601 RID: 30209
		Vulpine,
		// Token: 0x04007602 RID: 30210
		Unused21,
		// Token: 0x04007603 RID: 30211
		Unused22,
		// Token: 0x04007604 RID: 30212
		Unused23,
		// Token: 0x04007605 RID: 30213
		Unused24,
		// Token: 0x04007606 RID: 30214
		Tireless,
		// Token: 0x04007607 RID: 30215
		Rugged,
		// Token: 0x04007608 RID: 30216
		Bronze,
		// Token: 0x04007609 RID: 30217
		Iron,
		// Token: 0x0400760A RID: 30218
		Steel,
		// Token: 0x0400760B RID: 30219
		Silver,
		// Token: 0x0400760C RID: 30220
		Unused31,
		// Token: 0x0400760D RID: 30221
		Gold,
		// Token: 0x0400760E RID: 30222
		Platinum,
		// Token: 0x0400760F RID: 30223
		Meteoric,
		// Token: 0x04007610 RID: 30224
		Sharp,
		// Token: 0x04007611 RID: 30225
		Fine,
		// Token: 0x04007612 RID: 30226
		Warriors,
		// Token: 0x04007613 RID: 30227
		Soldiers,
		// Token: 0x04007614 RID: 30228
		Knights,
		// Token: 0x04007615 RID: 30229
		Lords,
		// Token: 0x04007616 RID: 30230
		Kings,
		// Token: 0x04007617 RID: 30231
		Howling,
		// Token: 0x04007618 RID: 30232
		Fortuitous,
		// Token: 0x04007619 RID: 30233
		Unused44,
		// Token: 0x0400761A RID: 30234
		Unused45,
		// Token: 0x0400761B RID: 30235
		Unused46,
		// Token: 0x0400761C RID: 30236
		Unused47,
		// Token: 0x0400761D RID: 30237
		Unused48,
		// Token: 0x0400761E RID: 30238
		Glimmering,
		// Token: 0x0400761F RID: 30239
		Glowing7,
		// Token: 0x04007620 RID: 30240
		Unused51,
		// Token: 0x04007621 RID: 30241
		Unused52,
		// Token: 0x04007622 RID: 30242
		Lizards,
		// Token: 0x04007623 RID: 30243
		Unused54,
		// Token: 0x04007624 RID: 30244
		Snakes,
		// Token: 0x04007625 RID: 30245
		Serpents,
		// Token: 0x04007626 RID: 30246
		Serpents2,
		// Token: 0x04007627 RID: 30247
		Drakes,
		// Token: 0x04007628 RID: 30248
		Dragons,
		// Token: 0x04007629 RID: 30249
		Dragons2,
		// Token: 0x0400762A RID: 30250
		Wyrms,
		// Token: 0x0400762B RID: 30251
		Unused62,
		// Token: 0x0400762C RID: 30252
		Unused63,
		// Token: 0x0400762D RID: 30253
		Prismatic,
		// Token: 0x0400762E RID: 30254
		Prismatic2,
		// Token: 0x0400762F RID: 30255
		Azure,
		// Token: 0x04007630 RID: 30256
		Lapis,
		// Token: 0x04007631 RID: 30257
		Lapis2,
		// Token: 0x04007632 RID: 30258
		Cobalt,
		// Token: 0x04007633 RID: 30259
		Cobalt2,
		// Token: 0x04007634 RID: 30260
		Unused71,
		// Token: 0x04007635 RID: 30261
		Sapphire,
		// Token: 0x04007636 RID: 30262
		Unused73,
		// Token: 0x04007637 RID: 30263
		Unused74,
		// Token: 0x04007638 RID: 30264
		Crimson,
		// Token: 0x04007639 RID: 30265
		Burgundy,
		// Token: 0x0400763A RID: 30266
		Burgundy2,
		// Token: 0x0400763B RID: 30267
		Garnet,
		// Token: 0x0400763C RID: 30268
		Garnet2,
		// Token: 0x0400763D RID: 30269
		Unused80,
		// Token: 0x0400763E RID: 30270
		Ruby,
		// Token: 0x0400763F RID: 30271
		Unused82,
		// Token: 0x04007640 RID: 30272
		Unused83,
		// Token: 0x04007641 RID: 30273
		Ocher,
		// Token: 0x04007642 RID: 30274
		Tangerine,
		// Token: 0x04007643 RID: 30275
		Tangerine2,
		// Token: 0x04007644 RID: 30276
		Coral,
		// Token: 0x04007645 RID: 30277
		Coral2,
		// Token: 0x04007646 RID: 30278
		Unused89,
		// Token: 0x04007647 RID: 30279
		Amber,
		// Token: 0x04007648 RID: 30280
		Unused91,
		// Token: 0x04007649 RID: 30281
		Unused92,
		// Token: 0x0400764A RID: 30282
		Beryl,
		// Token: 0x0400764B RID: 30283
		Jade,
		// Token: 0x0400764C RID: 30284
		Jade2,
		// Token: 0x0400764D RID: 30285
		Viridian,
		// Token: 0x0400764E RID: 30286
		Viridian2,
		// Token: 0x0400764F RID: 30287
		Unused98,
		// Token: 0x04007650 RID: 30288
		Emerald,
		// Token: 0x04007651 RID: 30289
		Unused100,
		// Token: 0x04007652 RID: 30290
		Fletchers,
		// Token: 0x04007653 RID: 30291
		Archers,
		// Token: 0x04007654 RID: 30292
		Archers2,
		// Token: 0x04007655 RID: 30293
		Monks,
		// Token: 0x04007656 RID: 30294
		Priests,
		// Token: 0x04007657 RID: 30295
		Priests2,
		// Token: 0x04007658 RID: 30296
		Summoners,
		// Token: 0x04007659 RID: 30297
		Necromancers,
		// Token: 0x0400765A RID: 30298
		Necromancers2,
		// Token: 0x0400765B RID: 30299
		Angels,
		// Token: 0x0400765C RID: 30300
		Arch,
		// Token: 0x0400765D RID: 30301
		Arch2,
		// Token: 0x0400765E RID: 30302
		Slayers,
		// Token: 0x0400765F RID: 30303
		Berserkers,
		// Token: 0x04007660 RID: 30304
		Berserkers2,
		// Token: 0x04007661 RID: 30305
		Unused116,
		// Token: 0x04007662 RID: 30306
		Unused117,
		// Token: 0x04007663 RID: 30307
		Triumphant,
		// Token: 0x04007664 RID: 30308
		Stout,
		// Token: 0x04007665 RID: 30309
		Stout2,
		// Token: 0x04007666 RID: 30310
		Stout3,
		// Token: 0x04007667 RID: 30311
		Burly,
		// Token: 0x04007668 RID: 30312
		Burly2,
		// Token: 0x04007669 RID: 30313
		Burly3,
		// Token: 0x0400766A RID: 30314
		Stalwart,
		// Token: 0x0400766B RID: 30315
		Stalwart2,
		// Token: 0x0400766C RID: 30316
		Stalwart3,
		// Token: 0x0400766D RID: 30317
		Stout4,
		// Token: 0x0400766E RID: 30318
		Stout5,
		// Token: 0x0400766F RID: 30319
		Stout6,
		// Token: 0x04007670 RID: 30320
		Burly4,
		// Token: 0x04007671 RID: 30321
		Burly5,
		// Token: 0x04007672 RID: 30322
		Stalwart4,
		// Token: 0x04007673 RID: 30323
		Stalwart5,
		// Token: 0x04007674 RID: 30324
		Stout7,
		// Token: 0x04007675 RID: 30325
		Stout8,
		// Token: 0x04007676 RID: 30326
		Burly6,
		// Token: 0x04007677 RID: 30327
		Stalwart6,
		// Token: 0x04007678 RID: 30328
		Blanched,
		// Token: 0x04007679 RID: 30329
		Eburin,
		// Token: 0x0400767A RID: 30330
		Bone,
		// Token: 0x0400767B RID: 30331
		Ivory,
		// Token: 0x0400767C RID: 30332
		Sturdy2,
		// Token: 0x0400767D RID: 30333
		Sturdy3,
		// Token: 0x0400767E RID: 30334
		Strong2,
		// Token: 0x0400767F RID: 30335
		Glorious2,
		// Token: 0x04007680 RID: 30336
		Blessed2,
		// Token: 0x04007681 RID: 30337
		Saintly2,
		// Token: 0x04007682 RID: 30338
		Holy2,
		// Token: 0x04007683 RID: 30339
		Godly,
		// Token: 0x04007684 RID: 30340
		Unused151,
		// Token: 0x04007685 RID: 30341
		Unused152,
		// Token: 0x04007686 RID: 30342
		Unused153,
		// Token: 0x04007687 RID: 30343
		Unused154,
		// Token: 0x04007688 RID: 30344
		Unused155,
		// Token: 0x04007689 RID: 30345
		Unused156,
		// Token: 0x0400768A RID: 30346
		Unused157,
		// Token: 0x0400768B RID: 30347
		Unused158,
		// Token: 0x0400768C RID: 30348
		Unused159,
		// Token: 0x0400768D RID: 30349
		Unused160,
		// Token: 0x0400768E RID: 30350
		Unused161,
		// Token: 0x0400768F RID: 30351
		Unused162,
		// Token: 0x04007690 RID: 30352
		Unused163,
		// Token: 0x04007691 RID: 30353
		Unused164,
		// Token: 0x04007692 RID: 30354
		Unused165,
		// Token: 0x04007693 RID: 30355
		Scarlet,
		// Token: 0x04007694 RID: 30356
		Crimson2,
		// Token: 0x04007695 RID: 30357
		Unused168,
		// Token: 0x04007696 RID: 30358
		Unused169,
		// Token: 0x04007697 RID: 30359
		Unused170,
		// Token: 0x04007698 RID: 30360
		Unused171,
		// Token: 0x04007699 RID: 30361
		Unused172,
		// Token: 0x0400769A RID: 30362
		Unused173,
		// Token: 0x0400769B RID: 30363
		Unused174,
		// Token: 0x0400769C RID: 30364
		Unused175,
		// Token: 0x0400769D RID: 30365
		Unused176,
		// Token: 0x0400769E RID: 30366
		Unused177,
		// Token: 0x0400769F RID: 30367
		Unused178,
		// Token: 0x040076A0 RID: 30368
		Unused179,
		// Token: 0x040076A1 RID: 30369
		Unused180,
		// Token: 0x040076A2 RID: 30370
		Unused181,
		// Token: 0x040076A3 RID: 30371
		Unused182,
		// Token: 0x040076A4 RID: 30372
		Carbuncle,
		// Token: 0x040076A5 RID: 30373
		Carmine,
		// Token: 0x040076A6 RID: 30374
		Vermillion,
		// Token: 0x040076A7 RID: 30375
		Jagged2,
		// Token: 0x040076A8 RID: 30376
		Deadly2,
		// Token: 0x040076A9 RID: 30377
		Vicious2,
		// Token: 0x040076AA RID: 30378
		Brutal2,
		// Token: 0x040076AB RID: 30379
		Massive2,
		// Token: 0x040076AC RID: 30380
		Savage2,
		// Token: 0x040076AD RID: 30381
		Merciless2,
		// Token: 0x040076AE RID: 30382
		Ferocious,
		// Token: 0x040076AF RID: 30383
		Cruel,
		// Token: 0x040076B0 RID: 30384
		Cinnabar,
		// Token: 0x040076B1 RID: 30385
		Rusty,
		// Token: 0x040076B2 RID: 30386
		Realgar,
		// Token: 0x040076B3 RID: 30387
		Ruby2,
		// Token: 0x040076B4 RID: 30388
		Vulpine2,
		// Token: 0x040076B5 RID: 30389
		Dun,
		// Token: 0x040076B6 RID: 30390
		Tireless2,
		// Token: 0x040076B7 RID: 30391
		Tireless3,
		// Token: 0x040076B8 RID: 30392
		Brown,
		// Token: 0x040076B9 RID: 30393
		Rugged2,
		// Token: 0x040076BA RID: 30394
		Rugged3,
		// Token: 0x040076BB RID: 30395
		Rugged4,
		// Token: 0x040076BC RID: 30396
		Rugged5,
		// Token: 0x040076BD RID: 30397
		Rugged6,
		// Token: 0x040076BE RID: 30398
		Rugged7,
		// Token: 0x040076BF RID: 30399
		Rugged8,
		// Token: 0x040076C0 RID: 30400
		Rugged9,
		// Token: 0x040076C1 RID: 30401
		Rugged10,
		// Token: 0x040076C2 RID: 30402
		Rugged11,
		// Token: 0x040076C3 RID: 30403
		Rugged12,
		// Token: 0x040076C4 RID: 30404
		Vigorous,
		// Token: 0x040076C5 RID: 30405
		Chestnut,
		// Token: 0x040076C6 RID: 30406
		Maroon,
		// Token: 0x040076C7 RID: 30407
		Bronze2,
		// Token: 0x040076C8 RID: 30408
		Bronze3,
		// Token: 0x040076C9 RID: 30409
		Bronze4,
		// Token: 0x040076CA RID: 30410
		Iron2,
		// Token: 0x040076CB RID: 30411
		Iron3,
		// Token: 0x040076CC RID: 30412
		Iron4,
		// Token: 0x040076CD RID: 30413
		Steel2,
		// Token: 0x040076CE RID: 30414
		Steel3,
		// Token: 0x040076CF RID: 30415
		Steel4,
		// Token: 0x040076D0 RID: 30416
		Bronze5,
		// Token: 0x040076D1 RID: 30417
		Bronze6,
		// Token: 0x040076D2 RID: 30418
		Bronze7,
		// Token: 0x040076D3 RID: 30419
		Iron5,
		// Token: 0x040076D4 RID: 30420
		Iron6,
		// Token: 0x040076D5 RID: 30421
		Steel5,
		// Token: 0x040076D6 RID: 30422
		Steel6,
		// Token: 0x040076D7 RID: 30423
		Bronze8,
		// Token: 0x040076D8 RID: 30424
		Bronze9,
		// Token: 0x040076D9 RID: 30425
		Iron7,
		// Token: 0x040076DA RID: 30426
		Steel7,
		// Token: 0x040076DB RID: 30427
		Bronze10,
		// Token: 0x040076DC RID: 30428
		Iron8,
		// Token: 0x040076DD RID: 30429
		Steel8,
		// Token: 0x040076DE RID: 30430
		Silver2,
		// Token: 0x040076DF RID: 30431
		Gold2,
		// Token: 0x040076E0 RID: 30432
		Platinum2,
		// Token: 0x040076E1 RID: 30433
		Meteoric2,
		// Token: 0x040076E2 RID: 30434
		Strange,
		// Token: 0x040076E3 RID: 30435
		Weird,
		// Token: 0x040076E4 RID: 30436
		Nickel,
		// Token: 0x040076E5 RID: 30437
		Tin,
		// Token: 0x040076E6 RID: 30438
		Silver3,
		// Token: 0x040076E7 RID: 30439
		Argent,
		// Token: 0x040076E8 RID: 30440
		Fine2,
		// Token: 0x040076E9 RID: 30441
		Fine3,
		// Token: 0x040076EA RID: 30442
		Sharp2,
		// Token: 0x040076EB RID: 30443
		Fine4,
		// Token: 0x040076EC RID: 30444
		Sharp3,
		// Token: 0x040076ED RID: 30445
		Fine5,
		// Token: 0x040076EE RID: 30446
		Sharp4,
		// Token: 0x040076EF RID: 30447
		Fine6,
		// Token: 0x040076F0 RID: 30448
		Warriors2,
		// Token: 0x040076F1 RID: 30449
		Soldiers2,
		// Token: 0x040076F2 RID: 30450
		Knights2,
		// Token: 0x040076F3 RID: 30451
		Lords2,
		// Token: 0x040076F4 RID: 30452
		Kings2,
		// Token: 0x040076F5 RID: 30453
		Masters,
		// Token: 0x040076F6 RID: 30454
		Grandmasters,
		// Token: 0x040076F7 RID: 30455
		Glimmering2,
		// Token: 0x040076F8 RID: 30456
		Glowing2,
		// Token: 0x040076F9 RID: 30457
		Bright,
		// Token: 0x040076FA RID: 30458
		Screaming,
		// Token: 0x040076FB RID: 30459
		Howling2,
		// Token: 0x040076FC RID: 30460
		Wailing,
		// Token: 0x040076FD RID: 30461
		Screaming2,
		// Token: 0x040076FE RID: 30462
		Howling3,
		// Token: 0x040076FF RID: 30463
		Wailing2,
		// Token: 0x04007700 RID: 30464
		Lucky,
		// Token: 0x04007701 RID: 30465
		Lucky2,
		// Token: 0x04007702 RID: 30466
		Lucky3,
		// Token: 0x04007703 RID: 30467
		Lucky4,
		// Token: 0x04007704 RID: 30468
		Lucky5,
		// Token: 0x04007705 RID: 30469
		Lucky6,
		// Token: 0x04007706 RID: 30470
		Felicitous,
		// Token: 0x04007707 RID: 30471
		Fortuitous2,
		// Token: 0x04007708 RID: 30472
		Emerald2,
		// Token: 0x04007709 RID: 30473
		Lizards3,
		// Token: 0x0400770A RID: 30474
		Lizards4,
		// Token: 0x0400770B RID: 30475
		Lizards5,
		// Token: 0x0400770C RID: 30476
		Snakes2,
		// Token: 0x0400770D RID: 30477
		Snakes3,
		// Token: 0x0400770E RID: 30478
		Snakes4,
		// Token: 0x0400770F RID: 30479
		Serpents3,
		// Token: 0x04007710 RID: 30480
		Serpents4,
		// Token: 0x04007711 RID: 30481
		Serpents5,
		// Token: 0x04007712 RID: 30482
		Lizards6,
		// Token: 0x04007713 RID: 30483
		Lizards7,
		// Token: 0x04007714 RID: 30484
		Lizards8,
		// Token: 0x04007715 RID: 30485
		Snakes5,
		// Token: 0x04007716 RID: 30486
		Snakes6,
		// Token: 0x04007717 RID: 30487
		Serpents6,
		// Token: 0x04007718 RID: 30488
		Serpents7,
		// Token: 0x04007719 RID: 30489
		Lizards9,
		// Token: 0x0400771A RID: 30490
		Lizards10,
		// Token: 0x0400771B RID: 30491
		Snakes7,
		// Token: 0x0400771C RID: 30492
		Serpents8,
		// Token: 0x0400771D RID: 30493
		Lizards11,
		// Token: 0x0400771E RID: 30494
		Snakes8,
		// Token: 0x0400771F RID: 30495
		Serpents9,
		// Token: 0x04007720 RID: 30496
		Serpents10,
		// Token: 0x04007721 RID: 30497
		Drakes2,
		// Token: 0x04007722 RID: 30498
		Dragons3,
		// Token: 0x04007723 RID: 30499
		Dragons4,
		// Token: 0x04007724 RID: 30500
		Wyrms2,
		// Token: 0x04007725 RID: 30501
		Great,
		// Token: 0x04007726 RID: 30502
		Bahamuts,
		// Token: 0x04007727 RID: 30503
		Zircon,
		// Token: 0x04007728 RID: 30504
		Jacinth,
		// Token: 0x04007729 RID: 30505
		Turquoise,
		// Token: 0x0400772A RID: 30506
		Shimmering,
		// Token: 0x0400772B RID: 30507
		Shimmering2,
		// Token: 0x0400772C RID: 30508
		Shimmering3,
		// Token: 0x0400772D RID: 30509
		Shimmering4,
		// Token: 0x0400772E RID: 30510
		Shimmering5,
		// Token: 0x0400772F RID: 30511
		Shimmering6,
		// Token: 0x04007730 RID: 30512
		Shimmering7,
		// Token: 0x04007731 RID: 30513
		Rainbow,
		// Token: 0x04007732 RID: 30514
		Scintillating,
		// Token: 0x04007733 RID: 30515
		Prismatic3,
		// Token: 0x04007734 RID: 30516
		Chromatic,
		// Token: 0x04007735 RID: 30517
		Shimmering8,
		// Token: 0x04007736 RID: 30518
		Rainbow2,
		// Token: 0x04007737 RID: 30519
		Scintillating2,
		// Token: 0x04007738 RID: 30520
		Prismatic4,
		// Token: 0x04007739 RID: 30521
		Chromatic2,
		// Token: 0x0400773A RID: 30522
		Shimmering9,
		// Token: 0x0400773B RID: 30523
		Rainbow3,
		// Token: 0x0400773C RID: 30524
		Scintillating3,
		// Token: 0x0400773D RID: 30525
		Shimmering10,
		// Token: 0x0400773E RID: 30526
		Scintillating4,
		// Token: 0x0400773F RID: 30527
		Azure2,
		// Token: 0x04007740 RID: 30528
		Lapis3,
		// Token: 0x04007741 RID: 30529
		Cobalt3,
		// Token: 0x04007742 RID: 30530
		Sapphire2,
		// Token: 0x04007743 RID: 30531
		Azure3,
		// Token: 0x04007744 RID: 30532
		Lapis4,
		// Token: 0x04007745 RID: 30533
		Cobalt4,
		// Token: 0x04007746 RID: 30534
		Sapphire3,
		// Token: 0x04007747 RID: 30535
		Azure4,
		// Token: 0x04007748 RID: 30536
		Lapis5,
		// Token: 0x04007749 RID: 30537
		Cobalt5,
		// Token: 0x0400774A RID: 30538
		Sapphire4,
		// Token: 0x0400774B RID: 30539
		Azure5,
		// Token: 0x0400774C RID: 30540
		Lapis6,
		// Token: 0x0400774D RID: 30541
		Lapis7,
		// Token: 0x0400774E RID: 30542
		Cobalt6,
		// Token: 0x0400774F RID: 30543
		Cobalt7,
		// Token: 0x04007750 RID: 30544
		Sapphire5,
		// Token: 0x04007751 RID: 30545
		Lapis8,
		// Token: 0x04007752 RID: 30546
		Sapphire6,
		// Token: 0x04007753 RID: 30547
		Crimson3,
		// Token: 0x04007754 RID: 30548
		Russet,
		// Token: 0x04007755 RID: 30549
		Garnet3,
		// Token: 0x04007756 RID: 30550
		Ruby3,
		// Token: 0x04007757 RID: 30551
		Crimson4,
		// Token: 0x04007758 RID: 30552
		Russet2,
		// Token: 0x04007759 RID: 30553
		Garnet4,
		// Token: 0x0400775A RID: 30554
		Ruby4,
		// Token: 0x0400775B RID: 30555
		Crimson5,
		// Token: 0x0400775C RID: 30556
		Russet5,
		// Token: 0x0400775D RID: 30557
		Garnet5,
		// Token: 0x0400775E RID: 30558
		Ruby5,
		// Token: 0x0400775F RID: 30559
		Russet6,
		// Token: 0x04007760 RID: 30560
		Russet7,
		// Token: 0x04007761 RID: 30561
		Garnet6,
		// Token: 0x04007762 RID: 30562
		Garnet7,
		// Token: 0x04007763 RID: 30563
		Ruby6,
		// Token: 0x04007764 RID: 30564
		Garnet8,
		// Token: 0x04007765 RID: 30565
		Ruby7,
		// Token: 0x04007766 RID: 30566
		Tangerine3,
		// Token: 0x04007767 RID: 30567
		Ocher2,
		// Token: 0x04007768 RID: 30568
		Coral3,
		// Token: 0x04007769 RID: 30569
		Amber2,
		// Token: 0x0400776A RID: 30570
		Tangerine4,
		// Token: 0x0400776B RID: 30571
		Ocher3,
		// Token: 0x0400776C RID: 30572
		Coral4,
		// Token: 0x0400776D RID: 30573
		Amber3,
		// Token: 0x0400776E RID: 30574
		Tangerine5,
		// Token: 0x0400776F RID: 30575
		Ocher4,
		// Token: 0x04007770 RID: 30576
		Coral5,
		// Token: 0x04007771 RID: 30577
		Amber4,
		// Token: 0x04007772 RID: 30578
		Tangerine6,
		// Token: 0x04007773 RID: 30579
		Ocher5,
		// Token: 0x04007774 RID: 30580
		Ocher6,
		// Token: 0x04007775 RID: 30581
		Coral6,
		// Token: 0x04007776 RID: 30582
		Coral7,
		// Token: 0x04007777 RID: 30583
		Amber5,
		// Token: 0x04007778 RID: 30584
		Camphor,
		// Token: 0x04007779 RID: 30585
		Ambergris,
		// Token: 0x0400777A RID: 30586
		Beryl2,
		// Token: 0x0400777B RID: 30587
		Viridian3,
		// Token: 0x0400777C RID: 30588
		Jade3,
		// Token: 0x0400777D RID: 30589
		Emerald3,
		// Token: 0x0400777E RID: 30590
		Beryl3,
		// Token: 0x0400777F RID: 30591
		Viridian4,
		// Token: 0x04007780 RID: 30592
		Jade4,
		// Token: 0x04007781 RID: 30593
		Emerald4,
		// Token: 0x04007782 RID: 30594
		Beryl4,
		// Token: 0x04007783 RID: 30595
		Viridian5,
		// Token: 0x04007784 RID: 30596
		Jade5,
		// Token: 0x04007785 RID: 30597
		Emerald5,
		// Token: 0x04007786 RID: 30598
		Beryl5,
		// Token: 0x04007787 RID: 30599
		Viridian6,
		// Token: 0x04007788 RID: 30600
		Viridian7,
		// Token: 0x04007789 RID: 30601
		Jade6,
		// Token: 0x0400778A RID: 30602
		Jade7,
		// Token: 0x0400778B RID: 30603
		Emerald6,
		// Token: 0x0400778C RID: 30604
		Beryl6,
		// Token: 0x0400778D RID: 30605
		Jade8,
		// Token: 0x0400778E RID: 30606
		Triumphant2,
		// Token: 0x0400778F RID: 30607
		Victorious,
		// Token: 0x04007790 RID: 30608
		Aureolin,
		// Token: 0x04007791 RID: 30609
		Mechanists,
		// Token: 0x04007792 RID: 30610
		Artificers,
		// Token: 0x04007793 RID: 30611
		Jewelers,
		// Token: 0x04007794 RID: 30612
		Assamic,
		// Token: 0x04007795 RID: 30613
		Arcadian,
		// Token: 0x04007796 RID: 30614
		Unearthly,
		// Token: 0x04007797 RID: 30615
		Astral,
		// Token: 0x04007798 RID: 30616
		Elysian,
		// Token: 0x04007799 RID: 30617
		Celestial,
		// Token: 0x0400779A RID: 30618
		Diamond,
		// Token: 0x0400779B RID: 30619
		Fletchers2,
		// Token: 0x0400779C RID: 30620
		Acrobats,
		// Token: 0x0400779D RID: 30621
		Harpoonists,
		// Token: 0x0400779E RID: 30622
		Fletchers3,
		// Token: 0x0400779F RID: 30623
		Bowyers,
		// Token: 0x040077A0 RID: 30624
		Archers3,
		// Token: 0x040077A1 RID: 30625
		Acrobats2,
		// Token: 0x040077A2 RID: 30626
		Gymnasts,
		// Token: 0x040077A3 RID: 30627
		Athletes,
		// Token: 0x040077A4 RID: 30628
		Harpoonists2,
		// Token: 0x040077A5 RID: 30629
		Spearmaidens,
		// Token: 0x040077A6 RID: 30630
		Lancers,
		// Token: 0x040077A7 RID: 30631
		Burning,
		// Token: 0x040077A8 RID: 30632
		Sparking,
		// Token: 0x040077A9 RID: 30633
		Chilling,
		// Token: 0x040077AA RID: 30634
		Burning2,
		// Token: 0x040077AB RID: 30635
		Blazing,
		// Token: 0x040077AC RID: 30636
		Volcanic,
		// Token: 0x040077AD RID: 30637
		Sparking2,
		// Token: 0x040077AE RID: 30638
		Charged,
		// Token: 0x040077AF RID: 30639
		Powered,
		// Token: 0x040077B0 RID: 30640
		Chilling2,
		// Token: 0x040077B1 RID: 30641
		Freezing,
		// Token: 0x040077B2 RID: 30642
		Glacial,
		// Token: 0x040077B3 RID: 30643
		Hexing,
		// Token: 0x040077B4 RID: 30644
		Fungal,
		// Token: 0x040077B5 RID: 30645
		Graverobbers,
		// Token: 0x040077B6 RID: 30646
		Hexing2,
		// Token: 0x040077B7 RID: 30647
		Blighting,
		// Token: 0x040077B8 RID: 30648
		Accursed,
		// Token: 0x040077B9 RID: 30649
		Fungal2,
		// Token: 0x040077BA RID: 30650
		Noxious,
		// Token: 0x040077BB RID: 30651
		Venomous,
		// Token: 0x040077BC RID: 30652
		Graverobbers2,
		// Token: 0x040077BD RID: 30653
		Vodoun,
		// Token: 0x040077BE RID: 30654
		Golemlords,
		// Token: 0x040077BF RID: 30655
		Lion,
		// Token: 0x040077C0 RID: 30656
		Captains,
		// Token: 0x040077C1 RID: 30657
		Preservers,
		// Token: 0x040077C2 RID: 30658
		Lion2,
		// Token: 0x040077C3 RID: 30659
		Hawk,
		// Token: 0x040077C4 RID: 30660
		Rose,
		// Token: 0x040077C5 RID: 30661
		Captains2,
		// Token: 0x040077C6 RID: 30662
		Commanders,
		// Token: 0x040077C7 RID: 30663
		Marshals,
		// Token: 0x040077C8 RID: 30664
		Preservers2,
		// Token: 0x040077C9 RID: 30665
		Warders,
		// Token: 0x040077CA RID: 30666
		Guardians,
		// Token: 0x040077CB RID: 30667
		Experts,
		// Token: 0x040077CC RID: 30668
		Fanatic,
		// Token: 0x040077CD RID: 30669
		Sounding,
		// Token: 0x040077CE RID: 30670
		Experts2,
		// Token: 0x040077CF RID: 30671
		Veterans,
		// Token: 0x040077D0 RID: 30672
		Masters2,
		// Token: 0x040077D1 RID: 30673
		Fanatic2,
		// Token: 0x040077D2 RID: 30674
		Raging,
		// Token: 0x040077D3 RID: 30675
		Furious,
		// Token: 0x040077D4 RID: 30676
		Sounding2,
		// Token: 0x040077D5 RID: 30677
		Resonant,
		// Token: 0x040077D6 RID: 30678
		Echoing,
		// Token: 0x040077D7 RID: 30679
		Trainers,
		// Token: 0x040077D8 RID: 30680
		Spiritual,
		// Token: 0x040077D9 RID: 30681
		Natures,
		// Token: 0x040077DA RID: 30682
		Trainers2,
		// Token: 0x040077DB RID: 30683
		Caretakers,
		// Token: 0x040077DC RID: 30684
		Keepers,
		// Token: 0x040077DD RID: 30685
		Spiritual2,
		// Token: 0x040077DE RID: 30686
		Feral,
		// Token: 0x040077DF RID: 30687
		Communal,
		// Token: 0x040077E0 RID: 30688
		Natures2,
		// Token: 0x040077E1 RID: 30689
		Terras,
		// Token: 0x040077E2 RID: 30690
		Gaeas,
		// Token: 0x040077E3 RID: 30691
		Entrapping,
		// Token: 0x040077E4 RID: 30692
		Mentalists,
		// Token: 0x040077E5 RID: 30693
		Shogukushas,
		// Token: 0x040077E6 RID: 30694
		Entrapping2,
		// Token: 0x040077E7 RID: 30695
		Tricksters,
		// Token: 0x040077E8 RID: 30696
		Cunning,
		// Token: 0x040077E9 RID: 30697
		Mentalists2,
		// Token: 0x040077EA RID: 30698
		Psychic,
		// Token: 0x040077EB RID: 30699
		Shadow,
		// Token: 0x040077EC RID: 30700
		Shogukushas2,
		// Token: 0x040077ED RID: 30701
		Senseis,
		// Token: 0x040077EE RID: 30702
		Kenshis,
		// Token: 0x040077EF RID: 30703
		Unused514,
		// Token: 0x040077F0 RID: 30704
		Unused515,
		// Token: 0x040077F1 RID: 30705
		Unused516,
		// Token: 0x040077F2 RID: 30706
		Unused517,
		// Token: 0x040077F3 RID: 30707
		Unused518,
		// Token: 0x040077F4 RID: 30708
		Unused519,
		// Token: 0x040077F5 RID: 30709
		Paleocene,
		// Token: 0x040077F6 RID: 30710
		Paleocene2,
		// Token: 0x040077F7 RID: 30711
		Unused520,
		// Token: 0x040077F8 RID: 30712
		Unused521,
		// Token: 0x040077F9 RID: 30713
		Unused522,
		// Token: 0x040077FA RID: 30714
		Unused523,
		// Token: 0x040077FB RID: 30715
		Trump,
		// Token: 0x040077FC RID: 30716
		Unused525,
		// Token: 0x040077FD RID: 30717
		Unused526,
		// Token: 0x040077FE RID: 30718
		Unused527,
		// Token: 0x040077FF RID: 30719
		Unused528,
		// Token: 0x04007800 RID: 30720
		Gritty,
		// Token: 0x04007801 RID: 30721
		Unused530,
		// Token: 0x04007802 RID: 30722
		Unused531,
		// Token: 0x04007803 RID: 30723
		Unused532,
		// Token: 0x04007804 RID: 30724
		Unused533,
		// Token: 0x04007805 RID: 30725
		Unused534,
		// Token: 0x04007806 RID: 30726
		Hawkeye,
		// Token: 0x04007807 RID: 30727
		Unused535,
		// Token: 0x04007808 RID: 30728
		Visionary,
		// Token: 0x04007809 RID: 30729
		Mnemonic,
		// Token: 0x0400780A RID: 30730
		Snowflake,
		// Token: 0x0400780B RID: 30731
		Shivering,
		// Token: 0x0400780C RID: 30732
		Boreal,
		// Token: 0x0400780D RID: 30733
		Hibernal,
		// Token: 0x0400780E RID: 30734
		Ember,
		// Token: 0x0400780F RID: 30735
		Smoldering,
		// Token: 0x04007810 RID: 30736
		Smoking,
		// Token: 0x04007811 RID: 30737
		Flaming,
		// Token: 0x04007812 RID: 30738
		Scorching,
		// Token: 0x04007813 RID: 30739
		Static,
		// Token: 0x04007814 RID: 30740
		Glowing3,
		// Token: 0x04007815 RID: 30741
		Buzzing,
		// Token: 0x04007816 RID: 30742
		Arcing,
		// Token: 0x04007817 RID: 30743
		Shocking,
		// Token: 0x04007818 RID: 30744
		Septic,
		// Token: 0x04007819 RID: 30745
		Envenomed,
		// Token: 0x0400781A RID: 30746
		Corosive,
		// Token: 0x0400781B RID: 30747
		Toxic,
		// Token: 0x0400781C RID: 30748
		Pestilent,
		// Token: 0x0400781D RID: 30749
		Maidens,
		// Token: 0x0400781E RID: 30750
		Valkyries,
		// Token: 0x0400781F RID: 30751
		Maidens2,
		// Token: 0x04007820 RID: 30752
		Valkyries2,
		// Token: 0x04007821 RID: 30753
		Monks2,
		// Token: 0x04007822 RID: 30754
		Priests3,
		// Token: 0x04007823 RID: 30755
		Monks3,
		// Token: 0x04007824 RID: 30756
		Priests4,
		// Token: 0x04007825 RID: 30757
		Monks4,
		// Token: 0x04007826 RID: 30758
		Priests5,
		// Token: 0x04007827 RID: 30759
		Summoners2,
		// Token: 0x04007828 RID: 30760
		Necromancers3,
		// Token: 0x04007829 RID: 30761
		Summoners3,
		// Token: 0x0400782A RID: 30762
		Necromancers4,
		// Token: 0x0400782B RID: 30763
		Angels2,
		// Token: 0x0400782C RID: 30764
		Arch3,
		// Token: 0x0400782D RID: 30765
		Angels3,
		// Token: 0x0400782E RID: 30766
		Arch4,
		// Token: 0x0400782F RID: 30767
		Slayers2,
		// Token: 0x04007830 RID: 30768
		Berserkers3,
		// Token: 0x04007831 RID: 30769
		Slayers3,
		// Token: 0x04007832 RID: 30770
		Berserkers4,
		// Token: 0x04007833 RID: 30771
		Slayers4,
		// Token: 0x04007834 RID: 30772
		Berserkers5,
		// Token: 0x04007835 RID: 30773
		Shamans,
		// Token: 0x04007836 RID: 30774
		Hierophants,
		// Token: 0x04007837 RID: 30775
		Shamans2,
		// Token: 0x04007838 RID: 30776
		Hierophants2,
		// Token: 0x04007839 RID: 30777
		Magekillers,
		// Token: 0x0400783A RID: 30778
		Witch,
		// Token: 0x0400783B RID: 30779
		Magekillers2,
		// Token: 0x0400783C RID: 30780
		Witch2,
		// Token: 0x0400783D RID: 30781
		Compact,
		// Token: 0x0400783E RID: 30782
		Thin,
		// Token: 0x0400783F RID: 30783
		Dense,
		// Token: 0x04007840 RID: 30784
		Consecrated,
		// Token: 0x04007841 RID: 30785
		Pure,
		// Token: 0x04007842 RID: 30786
		Sacred,
		// Token: 0x04007843 RID: 30787
		Hallowed,
		// Token: 0x04007844 RID: 30788
		Divine,
		// Token: 0x04007845 RID: 30789
		Pearl,
		// Token: 0x04007846 RID: 30790
		Crimson6,
		// Token: 0x04007847 RID: 30791
		Red,
		// Token: 0x04007848 RID: 30792
		Sanguinary,
		// Token: 0x04007849 RID: 30793
		Bloody,
		// Token: 0x0400784A RID: 30794
		Red2,
		// Token: 0x0400784B RID: 30795
		Sanguinary2,
		// Token: 0x0400784C RID: 30796
		Red3,
		// Token: 0x0400784D RID: 30797
		Jagged3,
		// Token: 0x0400784E RID: 30798
		Forked,
		// Token: 0x0400784F RID: 30799
		Serrated,
		// Token: 0x04007850 RID: 30800
		Jagged4,
		// Token: 0x04007851 RID: 30801
		Forked2,
		// Token: 0x04007852 RID: 30802
		Jagged5,
		// Token: 0x04007853 RID: 30803
		Snowflake2,
		// Token: 0x04007854 RID: 30804
		Shivering2,
		// Token: 0x04007855 RID: 30805
		Boreal2,
		// Token: 0x04007856 RID: 30806
		Hibernal2,
		// Token: 0x04007857 RID: 30807
		Snowflake3,
		// Token: 0x04007858 RID: 30808
		Shivering3,
		// Token: 0x04007859 RID: 30809
		Boreal3,
		// Token: 0x0400785A RID: 30810
		Hibernal3,
		// Token: 0x0400785B RID: 30811
		Snowflake4,
		// Token: 0x0400785C RID: 30812
		Shivering4,
		// Token: 0x0400785D RID: 30813
		Boreal4,
		// Token: 0x0400785E RID: 30814
		Hibernal4,
		// Token: 0x0400785F RID: 30815
		Ember2,
		// Token: 0x04007860 RID: 30816
		Smoldering2,
		// Token: 0x04007861 RID: 30817
		Smoking2,
		// Token: 0x04007862 RID: 30818
		Flaming2,
		// Token: 0x04007863 RID: 30819
		Ember3,
		// Token: 0x04007864 RID: 30820
		Smoldering3,
		// Token: 0x04007865 RID: 30821
		Smoking3,
		// Token: 0x04007866 RID: 30822
		Flaming3,
		// Token: 0x04007867 RID: 30823
		Ember4,
		// Token: 0x04007868 RID: 30824
		Smoldering4,
		// Token: 0x04007869 RID: 30825
		Smoking4,
		// Token: 0x0400786A RID: 30826
		Flaming4,
		// Token: 0x0400786B RID: 30827
		Static2,
		// Token: 0x0400786C RID: 30828
		Glowing4,
		// Token: 0x0400786D RID: 30829
		Arcing2,
		// Token: 0x0400786E RID: 30830
		Shocking2,
		// Token: 0x0400786F RID: 30831
		Static3,
		// Token: 0x04007870 RID: 30832
		Glowing5,
		// Token: 0x04007871 RID: 30833
		Arcing3,
		// Token: 0x04007872 RID: 30834
		Shocking3,
		// Token: 0x04007873 RID: 30835
		Static4,
		// Token: 0x04007874 RID: 30836
		Glowing6,
		// Token: 0x04007875 RID: 30837
		Arcing4,
		// Token: 0x04007876 RID: 30838
		Shocking4,
		// Token: 0x04007877 RID: 30839
		Septic2,
		// Token: 0x04007878 RID: 30840
		Envenomed2,
		// Token: 0x04007879 RID: 30841
		Toxic2,
		// Token: 0x0400787A RID: 30842
		Pestilent2,
		// Token: 0x0400787B RID: 30843
		Septic3,
		// Token: 0x0400787C RID: 30844
		Envenomed3,
		// Token: 0x0400787D RID: 30845
		Toxic3,
		// Token: 0x0400787E RID: 30846
		Pestilent3,
		// Token: 0x0400787F RID: 30847
		Septic4,
		// Token: 0x04007880 RID: 30848
		Envenomed4,
		// Token: 0x04007881 RID: 30849
		Toxic4,
		// Token: 0x04007882 RID: 30850
		Pestilent4,
		// Token: 0x04007883 RID: 30851
		Tireless4,
		// Token: 0x04007884 RID: 30852
		Lizards2,
		// Token: 0x04007885 RID: 30853
		Azure6,
		// Token: 0x04007886 RID: 30854
		Crimson7,
		// Token: 0x04007887 RID: 30855
		Tangerine7,
		// Token: 0x04007888 RID: 30856
		Beryl7,
		// Token: 0x04007889 RID: 30857
		Godly2,
		// Token: 0x0400788A RID: 30858
		Cruel2
	}
}
