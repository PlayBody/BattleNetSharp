using System;

namespace D2Data
{
	// Token: 0x02000916 RID: 2326
	public abstract class BaseItem
	{
		// Token: 0x17003874 RID: 14452
		// (get) Token: 0x0600B875 RID: 47221 RVA: 0x002DEADC File Offset: 0x002DCCDC
		public ItemType Type
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x17003875 RID: 14453
		// (get) Token: 0x0600B876 RID: 47222 RVA: 0x002DEAF4 File Offset: 0x002DCCF4
		public int Index
		{
			get
			{
				return this.index;
			}
		}

		// Token: 0x17003876 RID: 14454
		// (get) Token: 0x0600B877 RID: 47223 RVA: 0x002DEB0C File Offset: 0x002DCD0C
		public int TableIndex
		{
			get
			{
				return this.tableIndex;
			}
		}

		// Token: 0x17003877 RID: 14455
		// (get) Token: 0x0600B878 RID: 47224 RVA: 0x002DEB24 File Offset: 0x002DCD24
		public BaseItemType BaseType
		{
			get
			{
				return this.baseType;
			}
		}

		// Token: 0x17003878 RID: 14456
		// (get) Token: 0x0600B879 RID: 47225 RVA: 0x002DEB3C File Offset: 0x002DCD3C
		public BaseItemType BaseType2
		{
			get
			{
				return this.baseType2;
			}
		}

		// Token: 0x17003879 RID: 14457
		// (get) Token: 0x0600B87A RID: 47226 RVA: 0x002DEB54 File Offset: 0x002DCD54
		public string Code
		{
			get
			{
				return this.code;
			}
		}

		// Token: 0x1700387A RID: 14458
		// (get) Token: 0x0600B87B RID: 47227 RVA: 0x002DEB6C File Offset: 0x002DCD6C
		public uint ID
		{
			get
			{
				return this.id;
			}
		}

		// Token: 0x1700387B RID: 14459
		// (get) Token: 0x0600B87C RID: 47228 RVA: 0x002DEB84 File Offset: 0x002DCD84
		public uint NightmareUpgrade
		{
			get
			{
				return this.nightmareUpgrade;
			}
		}

		// Token: 0x1700387C RID: 14460
		// (get) Token: 0x0600B87D RID: 47229 RVA: 0x002DEB9C File Offset: 0x002DCD9C
		public uint HellUpgrade
		{
			get
			{
				return this.hellUpgrade;
			}
		}

		// Token: 0x1700387D RID: 14461
		// (get) Token: 0x0600B87E RID: 47230 RVA: 0x002DEBB4 File Offset: 0x002DCDB4
		public int AkaraMagicLvl
		{
			get
			{
				return this.akaraMagicLvl;
			}
		}

		// Token: 0x1700387E RID: 14462
		// (get) Token: 0x0600B87F RID: 47231 RVA: 0x002DEBCC File Offset: 0x002DCDCC
		public int AkaraMagicMax
		{
			get
			{
				return this.akaraMagicMax;
			}
		}

		// Token: 0x1700387F RID: 14463
		// (get) Token: 0x0600B880 RID: 47232 RVA: 0x002DEBE4 File Offset: 0x002DCDE4
		public int AkaraMagicMin
		{
			get
			{
				return this.akaraMagicMin;
			}
		}

		// Token: 0x17003880 RID: 14464
		// (get) Token: 0x0600B881 RID: 47233 RVA: 0x002DEBFC File Offset: 0x002DCDFC
		public int AkaraMax
		{
			get
			{
				return this.akaraMax;
			}
		}

		// Token: 0x17003881 RID: 14465
		// (get) Token: 0x0600B882 RID: 47234 RVA: 0x002DEC14 File Offset: 0x002DCE14
		public int AkaraMin
		{
			get
			{
				return this.akaraMin;
			}
		}

		// Token: 0x17003882 RID: 14466
		// (get) Token: 0x0600B883 RID: 47235 RVA: 0x002DEC2C File Offset: 0x002DCE2C
		public int AlkorMagicLvl
		{
			get
			{
				return this.alkorMagicLvl;
			}
		}

		// Token: 0x17003883 RID: 14467
		// (get) Token: 0x0600B884 RID: 47236 RVA: 0x002DEC44 File Offset: 0x002DCE44
		public int AlkorMagicMax
		{
			get
			{
				return this.alkorMagicMax;
			}
		}

		// Token: 0x17003884 RID: 14468
		// (get) Token: 0x0600B885 RID: 47237 RVA: 0x002DEC5C File Offset: 0x002DCE5C
		public int AlkorMagicMin
		{
			get
			{
				return this.alkorMagicMin;
			}
		}

		// Token: 0x17003885 RID: 14469
		// (get) Token: 0x0600B886 RID: 47238 RVA: 0x002DEC74 File Offset: 0x002DCE74
		public int AlkorMax
		{
			get
			{
				return this.alkorMax;
			}
		}

		// Token: 0x17003886 RID: 14470
		// (get) Token: 0x0600B887 RID: 47239 RVA: 0x002DEC8C File Offset: 0x002DCE8C
		public int AlkorMin
		{
			get
			{
				return this.alkorMin;
			}
		}

		// Token: 0x17003887 RID: 14471
		// (get) Token: 0x0600B888 RID: 47240 RVA: 0x002DECA4 File Offset: 0x002DCEA4
		public string AlternateGfx
		{
			get
			{
				return this.alternateGfx;
			}
		}

		// Token: 0x17003888 RID: 14472
		// (get) Token: 0x0600B889 RID: 47241 RVA: 0x002DECBC File Offset: 0x002DCEBC
		public int AshearaMagicLvl
		{
			get
			{
				return this.ashearaMagicLvl;
			}
		}

		// Token: 0x17003889 RID: 14473
		// (get) Token: 0x0600B88A RID: 47242 RVA: 0x002DECD4 File Offset: 0x002DCED4
		public int AshearaMagicMax
		{
			get
			{
				return this.ashearaMagicMax;
			}
		}

		// Token: 0x1700388A RID: 14474
		// (get) Token: 0x0600B88B RID: 47243 RVA: 0x002DECEC File Offset: 0x002DCEEC
		public int AshearaMagicMin
		{
			get
			{
				return this.ashearaMagicMin;
			}
		}

		// Token: 0x1700388B RID: 14475
		// (get) Token: 0x0600B88C RID: 47244 RVA: 0x002DED04 File Offset: 0x002DCF04
		public int AshearaMax
		{
			get
			{
				return this.ashearaMax;
			}
		}

		// Token: 0x1700388C RID: 14476
		// (get) Token: 0x0600B88D RID: 47245 RVA: 0x002DED1C File Offset: 0x002DCF1C
		public int AshearaMin
		{
			get
			{
				return this.ashearaMin;
			}
		}

		// Token: 0x1700388D RID: 14477
		// (get) Token: 0x0600B88E RID: 47246 RVA: 0x002DED34 File Offset: 0x002DCF34
		public int AutoPrefix
		{
			get
			{
				return this.autoPrefix;
			}
		}

		// Token: 0x1700388E RID: 14478
		// (get) Token: 0x0600B88F RID: 47247 RVA: 0x002DED4C File Offset: 0x002DCF4C
		public bool Belt
		{
			get
			{
				return this.belt;
			}
		}

		// Token: 0x1700388F RID: 14479
		// (get) Token: 0x0600B890 RID: 47248 RVA: 0x002DED64 File Offset: 0x002DCF64
		public int BitField1
		{
			get
			{
				return this.bitField1;
			}
		}

		// Token: 0x17003890 RID: 14480
		// (get) Token: 0x0600B891 RID: 47249 RVA: 0x002DED7C File Offset: 0x002DCF7C
		public int CainMagicLvl
		{
			get
			{
				return this.cainMagicLvl;
			}
		}

		// Token: 0x17003891 RID: 14481
		// (get) Token: 0x0600B892 RID: 47250 RVA: 0x002DED94 File Offset: 0x002DCF94
		public int CainMagicMax
		{
			get
			{
				return this.cainMagicMax;
			}
		}

		// Token: 0x17003892 RID: 14482
		// (get) Token: 0x0600B893 RID: 47251 RVA: 0x002DEDAC File Offset: 0x002DCFAC
		public int CainMagicMin
		{
			get
			{
				return this.cainMagicMin;
			}
		}

		// Token: 0x17003893 RID: 14483
		// (get) Token: 0x0600B894 RID: 47252 RVA: 0x002DEDC4 File Offset: 0x002DCFC4
		public int CainMax
		{
			get
			{
				return this.cainMax;
			}
		}

		// Token: 0x17003894 RID: 14484
		// (get) Token: 0x0600B895 RID: 47253 RVA: 0x002DEDDC File Offset: 0x002DCFDC
		public int CainMin
		{
			get
			{
				return this.cainMin;
			}
		}

		// Token: 0x17003895 RID: 14485
		// (get) Token: 0x0600B896 RID: 47254 RVA: 0x002DEDF4 File Offset: 0x002DCFF4
		public int CharsiMagicLvl
		{
			get
			{
				return this.charsiMagicLvl;
			}
		}

		// Token: 0x17003896 RID: 14486
		// (get) Token: 0x0600B897 RID: 47255 RVA: 0x002DEE0C File Offset: 0x002DD00C
		public int CharsiMagicMax
		{
			get
			{
				return this.charsiMagicMax;
			}
		}

		// Token: 0x17003897 RID: 14487
		// (get) Token: 0x0600B898 RID: 47256 RVA: 0x002DEE24 File Offset: 0x002DD024
		public int CharsiMagicMin
		{
			get
			{
				return this.charsiMagicMin;
			}
		}

		// Token: 0x17003898 RID: 14488
		// (get) Token: 0x0600B899 RID: 47257 RVA: 0x002DEE3C File Offset: 0x002DD03C
		public int CharsiMax
		{
			get
			{
				return this.charsiMax;
			}
		}

		// Token: 0x17003899 RID: 14489
		// (get) Token: 0x0600B89A RID: 47258 RVA: 0x002DEE54 File Offset: 0x002DD054
		public int CharsiMin
		{
			get
			{
				return this.charsiMin;
			}
		}

		// Token: 0x1700389A RID: 14490
		// (get) Token: 0x0600B89B RID: 47259 RVA: 0x002DEE6C File Offset: 0x002DD06C
		public int CompactSave
		{
			get
			{
				return this.compactSave;
			}
		}

		// Token: 0x1700389B RID: 14491
		// (get) Token: 0x0600B89C RID: 47260 RVA: 0x002DEE84 File Offset: 0x002DD084
		public int Component
		{
			get
			{
				return this.component;
			}
		}

		// Token: 0x1700389C RID: 14492
		// (get) Token: 0x0600B89D RID: 47261 RVA: 0x002DEE9C File Offset: 0x002DD09C
		public int Cost
		{
			get
			{
				return this.cost;
			}
		}

		// Token: 0x1700389D RID: 14493
		// (get) Token: 0x0600B89E RID: 47262 RVA: 0x002DEEB4 File Offset: 0x002DD0B4
		public int DrehyaMagicLvl
		{
			get
			{
				return this.drehyaMagicLvl;
			}
		}

		// Token: 0x1700389E RID: 14494
		// (get) Token: 0x0600B89F RID: 47263 RVA: 0x002DEECC File Offset: 0x002DD0CC
		public int DrehyaMagicMax
		{
			get
			{
				return this.drehyaMagicMax;
			}
		}

		// Token: 0x1700389F RID: 14495
		// (get) Token: 0x0600B8A0 RID: 47264 RVA: 0x002DEEE4 File Offset: 0x002DD0E4
		public int DrehyaMagicMin
		{
			get
			{
				return this.drehyaMagicMin;
			}
		}

		// Token: 0x170038A0 RID: 14496
		// (get) Token: 0x0600B8A1 RID: 47265 RVA: 0x002DEEFC File Offset: 0x002DD0FC
		public int DrehyaMax
		{
			get
			{
				return this.drehyaMax;
			}
		}

		// Token: 0x170038A1 RID: 14497
		// (get) Token: 0x0600B8A2 RID: 47266 RVA: 0x002DEF14 File Offset: 0x002DD114
		public int DrehyaMin
		{
			get
			{
				return this.drehyaMin;
			}
		}

		// Token: 0x170038A2 RID: 14498
		// (get) Token: 0x0600B8A3 RID: 47267 RVA: 0x002DEF2C File Offset: 0x002DD12C
		public int DrognanMagicLvl
		{
			get
			{
				return this.drognanMagicLvl;
			}
		}

		// Token: 0x170038A3 RID: 14499
		// (get) Token: 0x0600B8A4 RID: 47268 RVA: 0x002DEF44 File Offset: 0x002DD144
		public int DrognanMagicMax
		{
			get
			{
				return this.drognanMagicMax;
			}
		}

		// Token: 0x170038A4 RID: 14500
		// (get) Token: 0x0600B8A5 RID: 47269 RVA: 0x002DEF5C File Offset: 0x002DD15C
		public int DrognanMagicMin
		{
			get
			{
				return this.drognanMagicMin;
			}
		}

		// Token: 0x170038A5 RID: 14501
		// (get) Token: 0x0600B8A6 RID: 47270 RVA: 0x002DEF74 File Offset: 0x002DD174
		public int DrognanMax
		{
			get
			{
				return this.drognanMax;
			}
		}

		// Token: 0x170038A6 RID: 14502
		// (get) Token: 0x0600B8A7 RID: 47271 RVA: 0x002DEF8C File Offset: 0x002DD18C
		public int DrognanMin
		{
			get
			{
				return this.drognanMin;
			}
		}

		// Token: 0x170038A7 RID: 14503
		// (get) Token: 0x0600B8A8 RID: 47272 RVA: 0x002DEFA4 File Offset: 0x002DD1A4
		public int DropSfxFrame
		{
			get
			{
				return this.dropSfxFrame;
			}
		}

		// Token: 0x170038A8 RID: 14504
		// (get) Token: 0x0600B8A9 RID: 47273 RVA: 0x002DEFBC File Offset: 0x002DD1BC
		public string DropSound
		{
			get
			{
				return this.dropSound;
			}
		}

		// Token: 0x170038A9 RID: 14505
		// (get) Token: 0x0600B8AA RID: 47274 RVA: 0x002DEFD4 File Offset: 0x002DD1D4
		public int DurabilityWarning
		{
			get
			{
				return this.durabilityWarning;
			}
		}

		// Token: 0x170038AA RID: 14506
		// (get) Token: 0x0600B8AB RID: 47275 RVA: 0x002DEFEC File Offset: 0x002DD1EC
		public int ElzixMagicLvl
		{
			get
			{
				return this.elzixMagicLvl;
			}
		}

		// Token: 0x170038AB RID: 14507
		// (get) Token: 0x0600B8AC RID: 47276 RVA: 0x002DF004 File Offset: 0x002DD204
		public int ElzixMagicMax
		{
			get
			{
				return this.elzixMagicMax;
			}
		}

		// Token: 0x170038AC RID: 14508
		// (get) Token: 0x0600B8AD RID: 47277 RVA: 0x002DF01C File Offset: 0x002DD21C
		public int ElzixMagicMin
		{
			get
			{
				return this.elzixMagicMin;
			}
		}

		// Token: 0x170038AD RID: 14509
		// (get) Token: 0x0600B8AE RID: 47278 RVA: 0x002DF034 File Offset: 0x002DD234
		public int ElzixMax
		{
			get
			{
				return this.elzixMax;
			}
		}

		// Token: 0x170038AE RID: 14510
		// (get) Token: 0x0600B8AF RID: 47279 RVA: 0x002DF04C File Offset: 0x002DD24C
		public int ElzixMin
		{
			get
			{
				return this.elzixMin;
			}
		}

		// Token: 0x170038AF RID: 14511
		// (get) Token: 0x0600B8B0 RID: 47280 RVA: 0x002DF064 File Offset: 0x002DD264
		public int FaraMagicLvl
		{
			get
			{
				return this.faraMagicLvl;
			}
		}

		// Token: 0x170038B0 RID: 14512
		// (get) Token: 0x0600B8B1 RID: 47281 RVA: 0x002DF07C File Offset: 0x002DD27C
		public int FaraMagicMax
		{
			get
			{
				return this.faraMagicMax;
			}
		}

		// Token: 0x170038B1 RID: 14513
		// (get) Token: 0x0600B8B2 RID: 47282 RVA: 0x002DF094 File Offset: 0x002DD294
		public int FaraMagicMin
		{
			get
			{
				return this.faraMagicMin;
			}
		}

		// Token: 0x170038B2 RID: 14514
		// (get) Token: 0x0600B8B3 RID: 47283 RVA: 0x002DF0AC File Offset: 0x002DD2AC
		public int FaraMax
		{
			get
			{
				return this.faraMax;
			}
		}

		// Token: 0x170038B3 RID: 14515
		// (get) Token: 0x0600B8B4 RID: 47284 RVA: 0x002DF0C4 File Offset: 0x002DD2C4
		public int FaraMin
		{
			get
			{
				return this.faraMin;
			}
		}

		// Token: 0x170038B4 RID: 14516
		// (get) Token: 0x0600B8B5 RID: 47285 RVA: 0x002DF0DC File Offset: 0x002DD2DC
		public string FlippyFile
		{
			get
			{
				return this.flippyFile;
			}
		}

		// Token: 0x170038B5 RID: 14517
		// (get) Token: 0x0600B8B6 RID: 47286 RVA: 0x002DF0F4 File Offset: 0x002DD2F4
		public int GambleCost
		{
			get
			{
				return this.gambleCost;
			}
		}

		// Token: 0x170038B6 RID: 14518
		// (get) Token: 0x0600B8B7 RID: 47287 RVA: 0x002DF10C File Offset: 0x002DD30C
		public int GameArt
		{
			get
			{
				return this.gameArt;
			}
		}

		// Token: 0x170038B7 RID: 14519
		// (get) Token: 0x0600B8B8 RID: 47288 RVA: 0x002DF124 File Offset: 0x002DD324
		public int GemApplyType
		{
			get
			{
				return this.gemApplyType;
			}
		}

		// Token: 0x170038B8 RID: 14520
		// (get) Token: 0x0600B8B9 RID: 47289 RVA: 0x002DF13C File Offset: 0x002DD33C
		public int GemOffset
		{
			get
			{
				return this.gemOffset;
			}
		}

		// Token: 0x170038B9 RID: 14521
		// (get) Token: 0x0600B8BA RID: 47290 RVA: 0x002DF154 File Offset: 0x002DD354
		public int GemSockets
		{
			get
			{
				return this.gemSockets;
			}
		}

		// Token: 0x170038BA RID: 14522
		// (get) Token: 0x0600B8BB RID: 47291 RVA: 0x002DF16C File Offset: 0x002DD36C
		public int GheedMagicLvl
		{
			get
			{
				return this.gheedMagicLvl;
			}
		}

		// Token: 0x170038BB RID: 14523
		// (get) Token: 0x0600B8BC RID: 47292 RVA: 0x002DF184 File Offset: 0x002DD384
		public int GheedMagicMax
		{
			get
			{
				return this.gheedMagicMax;
			}
		}

		// Token: 0x170038BC RID: 14524
		// (get) Token: 0x0600B8BD RID: 47293 RVA: 0x002DF19C File Offset: 0x002DD39C
		public int GheedMagicMin
		{
			get
			{
				return this.gheedMagicMin;
			}
		}

		// Token: 0x170038BD RID: 14525
		// (get) Token: 0x0600B8BE RID: 47294 RVA: 0x002DF1B4 File Offset: 0x002DD3B4
		public int GheedMax
		{
			get
			{
				return this.gheedMax;
			}
		}

		// Token: 0x170038BE RID: 14526
		// (get) Token: 0x0600B8BF RID: 47295 RVA: 0x002DF1CC File Offset: 0x002DD3CC
		public int GheedMin
		{
			get
			{
				return this.gheedMin;
			}
		}

		// Token: 0x170038BF RID: 14527
		// (get) Token: 0x0600B8C0 RID: 47296 RVA: 0x002DF1E4 File Offset: 0x002DD3E4
		public int HalbuMagicLvl
		{
			get
			{
				return this.halbuMagicLvl;
			}
		}

		// Token: 0x170038C0 RID: 14528
		// (get) Token: 0x0600B8C1 RID: 47297 RVA: 0x002DF1FC File Offset: 0x002DD3FC
		public int HalbuMagicMax
		{
			get
			{
				return this.halbuMagicMax;
			}
		}

		// Token: 0x170038C1 RID: 14529
		// (get) Token: 0x0600B8C2 RID: 47298 RVA: 0x002DF214 File Offset: 0x002DD414
		public int HalbuMagicMin
		{
			get
			{
				return this.halbuMagicMin;
			}
		}

		// Token: 0x170038C2 RID: 14530
		// (get) Token: 0x0600B8C3 RID: 47299 RVA: 0x002DF22C File Offset: 0x002DD42C
		public int HalbuMax
		{
			get
			{
				return this.halbuMax;
			}
		}

		// Token: 0x170038C3 RID: 14531
		// (get) Token: 0x0600B8C4 RID: 47300 RVA: 0x002DF244 File Offset: 0x002DD444
		public int HalbuMin
		{
			get
			{
				return this.halbuMin;
			}
		}

		// Token: 0x170038C4 RID: 14532
		// (get) Token: 0x0600B8C5 RID: 47301 RVA: 0x002DF25C File Offset: 0x002DD45C
		public bool HasInv
		{
			get
			{
				return this.hasInv;
			}
		}

		// Token: 0x170038C5 RID: 14533
		// (get) Token: 0x0600B8C6 RID: 47302 RVA: 0x002DF274 File Offset: 0x002DD474
		public int HraltiMagicLvl
		{
			get
			{
				return this.hraltiMagicLvl;
			}
		}

		// Token: 0x170038C6 RID: 14534
		// (get) Token: 0x0600B8C7 RID: 47303 RVA: 0x002DF28C File Offset: 0x002DD48C
		public int HraltiMagicMax
		{
			get
			{
				return this.hraltiMagicMax;
			}
		}

		// Token: 0x170038C7 RID: 14535
		// (get) Token: 0x0600B8C8 RID: 47304 RVA: 0x002DF2A4 File Offset: 0x002DD4A4
		public int HraltiMagicMin
		{
			get
			{
				return this.hraltiMagicMin;
			}
		}

		// Token: 0x170038C8 RID: 14536
		// (get) Token: 0x0600B8C9 RID: 47305 RVA: 0x002DF2BC File Offset: 0x002DD4BC
		public int HraltiMax
		{
			get
			{
				return this.hraltiMax;
			}
		}

		// Token: 0x170038C9 RID: 14537
		// (get) Token: 0x0600B8CA RID: 47306 RVA: 0x002DF2D4 File Offset: 0x002DD4D4
		public int HraltiMin
		{
			get
			{
				return this.hraltiMin;
			}
		}

		// Token: 0x170038CA RID: 14538
		// (get) Token: 0x0600B8CB RID: 47307 RVA: 0x002DF2EC File Offset: 0x002DD4EC
		public string InvFile
		{
			get
			{
				return this.invFile;
			}
		}

		// Token: 0x170038CB RID: 14539
		// (get) Token: 0x0600B8CC RID: 47308 RVA: 0x002DF304 File Offset: 0x002DD504
		public int InvHeight
		{
			get
			{
				return this.invHeight;
			}
		}

		// Token: 0x170038CC RID: 14540
		// (get) Token: 0x0600B8CD RID: 47309 RVA: 0x002DF31C File Offset: 0x002DD51C
		public int InvTrans
		{
			get
			{
				return this.invTrans;
			}
		}

		// Token: 0x170038CD RID: 14541
		// (get) Token: 0x0600B8CE RID: 47310 RVA: 0x002DF334 File Offset: 0x002DD534
		public int InvWidth
		{
			get
			{
				return this.invWidth;
			}
		}

		// Token: 0x170038CE RID: 14542
		// (get) Token: 0x0600B8CF RID: 47311 RVA: 0x002DF34C File Offset: 0x002DD54C
		public int JamellaMagicLvl
		{
			get
			{
				return this.jamellaMagicLvl;
			}
		}

		// Token: 0x170038CF RID: 14543
		// (get) Token: 0x0600B8D0 RID: 47312 RVA: 0x002DF364 File Offset: 0x002DD564
		public int JamellaMagicMax
		{
			get
			{
				return this.jamellaMagicMax;
			}
		}

		// Token: 0x170038D0 RID: 14544
		// (get) Token: 0x0600B8D1 RID: 47313 RVA: 0x002DF37C File Offset: 0x002DD57C
		public int JamellaMagicMin
		{
			get
			{
				return this.jamellaMagicMin;
			}
		}

		// Token: 0x170038D1 RID: 14545
		// (get) Token: 0x0600B8D2 RID: 47314 RVA: 0x002DF394 File Offset: 0x002DD594
		public int JamellaMax
		{
			get
			{
				return this.jamellaMax;
			}
		}

		// Token: 0x170038D2 RID: 14546
		// (get) Token: 0x0600B8D3 RID: 47315 RVA: 0x002DF3AC File Offset: 0x002DD5AC
		public int JamellaMin
		{
			get
			{
				return this.jamellaMin;
			}
		}

		// Token: 0x170038D3 RID: 14547
		// (get) Token: 0x0600B8D4 RID: 47316 RVA: 0x002DF3C4 File Offset: 0x002DD5C4
		public int LarzukMagicLvl
		{
			get
			{
				return this.larzukMagicLvl;
			}
		}

		// Token: 0x170038D4 RID: 14548
		// (get) Token: 0x0600B8D5 RID: 47317 RVA: 0x002DF3DC File Offset: 0x002DD5DC
		public int LarzukMagicMax
		{
			get
			{
				return this.larzukMagicMax;
			}
		}

		// Token: 0x170038D5 RID: 14549
		// (get) Token: 0x0600B8D6 RID: 47318 RVA: 0x002DF3F4 File Offset: 0x002DD5F4
		public int LarzukMagicMin
		{
			get
			{
				return this.larzukMagicMin;
			}
		}

		// Token: 0x170038D6 RID: 14550
		// (get) Token: 0x0600B8D7 RID: 47319 RVA: 0x002DF40C File Offset: 0x002DD60C
		public int LarzukMax
		{
			get
			{
				return this.larzukMax;
			}
		}

		// Token: 0x170038D7 RID: 14551
		// (get) Token: 0x0600B8D8 RID: 47320 RVA: 0x002DF424 File Offset: 0x002DD624
		public int LarzukMin
		{
			get
			{
				return this.larzukMin;
			}
		}

		// Token: 0x170038D8 RID: 14552
		// (get) Token: 0x0600B8D9 RID: 47321 RVA: 0x002DF43C File Offset: 0x002DD63C
		public int Level
		{
			get
			{
				return this.level;
			}
		}

		// Token: 0x170038D9 RID: 14553
		// (get) Token: 0x0600B8DA RID: 47322 RVA: 0x002DF454 File Offset: 0x002DD654
		public int LevelReq
		{
			get
			{
				return this.levelReq;
			}
		}

		// Token: 0x170038DA RID: 14554
		// (get) Token: 0x0600B8DB RID: 47323 RVA: 0x002DF46C File Offset: 0x002DD66C
		public int LightRadius
		{
			get
			{
				return this.lightRadius;
			}
		}

		// Token: 0x170038DB RID: 14555
		// (get) Token: 0x0600B8DC RID: 47324 RVA: 0x002DF484 File Offset: 0x002DD684
		public int LysanderMagicLvl
		{
			get
			{
				return this.lysanderMagicLvl;
			}
		}

		// Token: 0x170038DC RID: 14556
		// (get) Token: 0x0600B8DD RID: 47325 RVA: 0x002DF49C File Offset: 0x002DD69C
		public int LysanderMagicMax
		{
			get
			{
				return this.lysanderMagicMax;
			}
		}

		// Token: 0x170038DD RID: 14557
		// (get) Token: 0x0600B8DE RID: 47326 RVA: 0x002DF4B4 File Offset: 0x002DD6B4
		public int LysanderMagicMin
		{
			get
			{
				return this.lysanderMagicMin;
			}
		}

		// Token: 0x170038DE RID: 14558
		// (get) Token: 0x0600B8DF RID: 47327 RVA: 0x002DF4CC File Offset: 0x002DD6CC
		public int LysanderMax
		{
			get
			{
				return this.lysanderMax;
			}
		}

		// Token: 0x170038DF RID: 14559
		// (get) Token: 0x0600B8E0 RID: 47328 RVA: 0x002DF4E4 File Offset: 0x002DD6E4
		public int LysanderMin
		{
			get
			{
				return this.lysanderMin;
			}
		}

		// Token: 0x170038E0 RID: 14560
		// (get) Token: 0x0600B8E1 RID: 47329 RVA: 0x002DF4FC File Offset: 0x002DD6FC
		public int MalahMagicLvl
		{
			get
			{
				return this.malahMagicLvl;
			}
		}

		// Token: 0x170038E1 RID: 14561
		// (get) Token: 0x0600B8E2 RID: 47330 RVA: 0x002DF514 File Offset: 0x002DD714
		public int MalahMagicMax
		{
			get
			{
				return this.malahMagicMax;
			}
		}

		// Token: 0x170038E2 RID: 14562
		// (get) Token: 0x0600B8E3 RID: 47331 RVA: 0x002DF52C File Offset: 0x002DD72C
		public int MalahMagicMin
		{
			get
			{
				return this.malahMagicMin;
			}
		}

		// Token: 0x170038E3 RID: 14563
		// (get) Token: 0x0600B8E4 RID: 47332 RVA: 0x002DF544 File Offset: 0x002DD744
		public int MalahMax
		{
			get
			{
				return this.malahMax;
			}
		}

		// Token: 0x170038E4 RID: 14564
		// (get) Token: 0x0600B8E5 RID: 47333 RVA: 0x002DF55C File Offset: 0x002DD75C
		public int MalahMin
		{
			get
			{
				return this.malahMin;
			}
		}

		// Token: 0x170038E5 RID: 14565
		// (get) Token: 0x0600B8E6 RID: 47334 RVA: 0x002DF574 File Offset: 0x002DD774
		public int MaxDamage
		{
			get
			{
				return this.maxDamage;
			}
		}

		// Token: 0x170038E6 RID: 14566
		// (get) Token: 0x0600B8E7 RID: 47335 RVA: 0x002DF58C File Offset: 0x002DD78C
		public int MaxStack
		{
			get
			{
				return this.maxStack;
			}
		}

		// Token: 0x170038E7 RID: 14567
		// (get) Token: 0x0600B8E8 RID: 47336 RVA: 0x002DF5A4 File Offset: 0x002DD7A4
		public int MinDamage
		{
			get
			{
				return this.minDamage;
			}
		}

		// Token: 0x170038E8 RID: 14568
		// (get) Token: 0x0600B8E9 RID: 47337 RVA: 0x002DF5BC File Offset: 0x002DD7BC
		public int MinStack
		{
			get
			{
				return this.minStack;
			}
		}

		// Token: 0x170038E9 RID: 14569
		// (get) Token: 0x0600B8EA RID: 47338 RVA: 0x002DF5D4 File Offset: 0x002DD7D4
		public int MissileType
		{
			get
			{
				return this.missileType;
			}
		}

		// Token: 0x170038EA RID: 14570
		// (get) Token: 0x0600B8EB RID: 47339 RVA: 0x002DF5EC File Offset: 0x002DD7EC
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x170038EB RID: 14571
		// (get) Token: 0x0600B8EC RID: 47340 RVA: 0x002DF604 File Offset: 0x002DD804
		public bool Nameable
		{
			get
			{
				return this.nameable;
			}
		}

		// Token: 0x170038EC RID: 14572
		// (get) Token: 0x0600B8ED RID: 47341 RVA: 0x002DF61C File Offset: 0x002DD81C
		public string NameString
		{
			get
			{
				return this.nameString;
			}
		}

		// Token: 0x170038ED RID: 14573
		// (get) Token: 0x0600B8EE RID: 47342 RVA: 0x002DF634 File Offset: 0x002DD834
		public bool NoDurability
		{
			get
			{
				return this.noDurability;
			}
		}

		// Token: 0x170038EE RID: 14574
		// (get) Token: 0x0600B8EF RID: 47343 RVA: 0x002DF64C File Offset: 0x002DD84C
		public int OrmusMagicLvl
		{
			get
			{
				return this.ormusMagicLvl;
			}
		}

		// Token: 0x170038EF RID: 14575
		// (get) Token: 0x0600B8F0 RID: 47344 RVA: 0x002DF664 File Offset: 0x002DD864
		public int OrmusMagicMax
		{
			get
			{
				return this.ormusMagicMax;
			}
		}

		// Token: 0x170038F0 RID: 14576
		// (get) Token: 0x0600B8F1 RID: 47345 RVA: 0x002DF67C File Offset: 0x002DD87C
		public int OrmusMagicMin
		{
			get
			{
				return this.ormusMagicMin;
			}
		}

		// Token: 0x170038F1 RID: 14577
		// (get) Token: 0x0600B8F2 RID: 47346 RVA: 0x002DF694 File Offset: 0x002DD894
		public int OrmusMax
		{
			get
			{
				return this.ormusMax;
			}
		}

		// Token: 0x170038F2 RID: 14578
		// (get) Token: 0x0600B8F3 RID: 47347 RVA: 0x002DF6AC File Offset: 0x002DD8AC
		public int OrmusMin
		{
			get
			{
				return this.ormusMin;
			}
		}

		// Token: 0x170038F3 RID: 14579
		// (get) Token: 0x0600B8F4 RID: 47348 RVA: 0x002DF6C4 File Offset: 0x002DD8C4
		public int QuantityWarning
		{
			get
			{
				return this.quantityWarning;
			}
		}

		// Token: 0x170038F4 RID: 14580
		// (get) Token: 0x0600B8F5 RID: 47349 RVA: 0x002DF6DC File Offset: 0x002DD8DC
		public int Quest
		{
			get
			{
				return this.quest;
			}
		}

		// Token: 0x170038F5 RID: 14581
		// (get) Token: 0x0600B8F6 RID: 47350 RVA: 0x002DF6F4 File Offset: 0x002DD8F4
		public int Rarity
		{
			get
			{
				return this.rarity;
			}
		}

		// Token: 0x170038F6 RID: 14582
		// (get) Token: 0x0600B8F7 RID: 47351 RVA: 0x002DF70C File Offset: 0x002DD90C
		public int SkipName
		{
			get
			{
				return this.skipName;
			}
		}

		// Token: 0x170038F7 RID: 14583
		// (get) Token: 0x0600B8F8 RID: 47352 RVA: 0x002DF724 File Offset: 0x002DD924
		public int SourceArt
		{
			get
			{
				return this.sourceArt;
			}
		}

		// Token: 0x170038F8 RID: 14584
		// (get) Token: 0x0600B8F9 RID: 47353 RVA: 0x002DF73C File Offset: 0x002DD93C
		public bool Spawnable
		{
			get
			{
				return this.spawnable;
			}
		}

		// Token: 0x170038F9 RID: 14585
		// (get) Token: 0x0600B8FA RID: 47354 RVA: 0x002DF754 File Offset: 0x002DD954
		public int Speed
		{
			get
			{
				return this.speed;
			}
		}

		// Token: 0x170038FA RID: 14586
		// (get) Token: 0x0600B8FB RID: 47355 RVA: 0x002DF76C File Offset: 0x002DD96C
		public bool Stackable
		{
			get
			{
				return this.stackable;
			}
		}

		// Token: 0x170038FB RID: 14587
		// (get) Token: 0x0600B8FC RID: 47356 RVA: 0x002DF784 File Offset: 0x002DD984
		public int Transform
		{
			get
			{
				return this.transform;
			}
		}

		// Token: 0x170038FC RID: 14588
		// (get) Token: 0x0600B8FD RID: 47357 RVA: 0x002DF79C File Offset: 0x002DD99C
		public bool Transparent
		{
			get
			{
				return this.transparent;
			}
		}

		// Token: 0x170038FD RID: 14589
		// (get) Token: 0x0600B8FE RID: 47358 RVA: 0x002DF7B4 File Offset: 0x002DD9B4
		public int TransTbl
		{
			get
			{
				return this.transTbl;
			}
		}

		// Token: 0x170038FE RID: 14590
		// (get) Token: 0x0600B8FF RID: 47359 RVA: 0x002DF7CC File Offset: 0x002DD9CC
		public bool Unique
		{
			get
			{
				return this.unique;
			}
		}

		// Token: 0x170038FF RID: 14591
		// (get) Token: 0x0600B900 RID: 47360 RVA: 0x002DF7E4 File Offset: 0x002DD9E4
		public string UniqueInvFile
		{
			get
			{
				return this.uniqueInvFile;
			}
		}

		// Token: 0x17003900 RID: 14592
		// (get) Token: 0x0600B901 RID: 47361 RVA: 0x002DF7FC File Offset: 0x002DD9FC
		public bool Useable
		{
			get
			{
				return this.useable;
			}
		}

		// Token: 0x17003901 RID: 14593
		// (get) Token: 0x0600B902 RID: 47362 RVA: 0x002DF814 File Offset: 0x002DDA14
		public string UseSound
		{
			get
			{
				return this.useSound;
			}
		}

		// Token: 0x17003902 RID: 14594
		// (get) Token: 0x0600B903 RID: 47363 RVA: 0x002DF82C File Offset: 0x002DDA2C
		public int Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x0600B904 RID: 47364 RVA: 0x002DF844 File Offset: 0x002DDA44
		public BaseItem()
		{
		}

		// Token: 0x0600B905 RID: 47365 RVA: 0x002DF850 File Offset: 0x002DDA50
		public override string ToString()
		{
			return this.name;
		}

		// Token: 0x0600B906 RID: 47366 RVA: 0x002DF868 File Offset: 0x002DDA68
		public static BaseItem Get(int index)
		{
			bool flag = index < 0 || index >= BaseItem.ItemCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException();
			}
			return BaseItem.items[index];
		}

		// Token: 0x0600B907 RID: 47367 RVA: 0x002DF8A0 File Offset: 0x002DDAA0
		public static BaseItem Get(ItemType type)
		{
			bool flag = type < ItemType.Elixir || type >= (ItemType)BaseItem.ItemCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException();
			}
			return BaseItem.items[(int)type];
		}

		// Token: 0x0600B908 RID: 47368 RVA: 0x002DF8D8 File Offset: 0x002DDAD8
		public static BaseItem GetByID(uint id)
		{
			BaseItem baseItem = null;
			for (int i = 0; i < BaseItem.ItemCount; i++)
			{
				bool flag = BaseItem.items[i].ID == id;
				if (flag)
				{
					baseItem = BaseItem.items[i];
				}
			}
			return baseItem;
		}

		// Token: 0x0600B909 RID: 47369 RVA: 0x002DF920 File Offset: 0x002DDB20
		public static BaseItem GetByID(ItemCategory cat, uint id)
		{
			if (cat > ItemCategory.Armor)
			{
				if (cat == ItemCategory.Weapon)
				{
					return BaseItem.GetWeaponByID(id);
				}
				if (cat != ItemCategory.Shield)
				{
					return BaseItem.GetByID(id);
				}
			}
			return BaseItem.GetArmorByID(id);
		}

		// Token: 0x0600B90A RID: 47370 RVA: 0x002DF970 File Offset: 0x002DDB70
		public static BaseItem GetByCode(string code)
		{
			code = code.ToLower();
			for (int i = 0; i < BaseItem.ItemCount; i++)
			{
				bool flag = BaseItem.items[i].Code == code;
				if (flag)
				{
					return BaseItem.items[i];
				}
			}
			throw new ArgumentException(string.Format("No BaseItem with code {0} found !", code));
		}

		// Token: 0x0600B90B RID: 47371 RVA: 0x002DF9D0 File Offset: 0x002DDBD0
		public static BaseItem GetByCode(ItemCategory cat, string code)
		{
			if (cat > ItemCategory.Armor)
			{
				if (cat == ItemCategory.Weapon)
				{
					return BaseItem.GetWeaponByCode(code);
				}
				if (cat != ItemCategory.Shield)
				{
					return BaseItem.GetByCode(code);
				}
			}
			return BaseItem.GetArmorByCode(code);
		}

		// Token: 0x0600B90C RID: 47372 RVA: 0x002DFA20 File Offset: 0x002DDC20
		public static BaseItem GetByName(string name)
		{
			for (int i = 0; i < BaseItem.ItemCount; i++)
			{
				bool flag = BaseItem.items[i].Name == name;
				if (flag)
				{
					return BaseItem.items[i];
				}
			}
			throw new ArgumentException(string.Format("No BaseItem with name {0} found !", name));
		}

		// Token: 0x0600B90D RID: 47373 RVA: 0x002DFA78 File Offset: 0x002DDC78
		public static BaseMiscItem GetMiscItem(int index)
		{
			bool flag = index < 0 || index >= BaseItem.ItemCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException();
			}
			BaseItem baseItem = BaseItem.items[index];
			bool flag2 = baseItem is BaseMiscItem;
			if (flag2)
			{
				return baseItem as BaseMiscItem;
			}
			throw new ArgumentException(string.Format("BaseItem {0} is not a BaseMiscItem !", baseItem.Name));
		}

		// Token: 0x0600B90E RID: 47374 RVA: 0x002DFADC File Offset: 0x002DDCDC
		public static BaseMiscItem GetMiscItem(ItemType type)
		{
			return BaseItem.GetMiscItem((int)type);
		}

		// Token: 0x0600B90F RID: 47375 RVA: 0x002DFAF4 File Offset: 0x002DDCF4
		public static BaseMiscItem GetMiscItemByID(uint id)
		{
			for (int i = 0; i < BaseItem.BASE_ARMOR_START; i++)
			{
				bool flag = BaseItem.items[i].ID == id;
				if (flag)
				{
					return BaseItem.items[i] as BaseMiscItem;
				}
			}
			throw new ArgumentException(string.Format("No BaseMiscItem with ID {0} found !", id));
		}

		// Token: 0x0600B910 RID: 47376 RVA: 0x002DFB54 File Offset: 0x002DDD54
		public static BaseMiscItem GetMiscItemByCode(string code)
		{
			code = code.ToLower();
			for (int i = 0; i < BaseItem.BASE_ARMOR_START; i++)
			{
				bool flag = BaseItem.items[i].Code == code;
				if (flag)
				{
					return BaseItem.items[i] as BaseMiscItem;
				}
			}
			throw new ArgumentException(string.Format("No BaseMiscItem with Code {0} found !", code));
		}

		// Token: 0x0600B911 RID: 47377 RVA: 0x002DFBB8 File Offset: 0x002DDDB8
		public static BaseMiscItem GetMiscItemByName(string name)
		{
			for (int i = 0; i < BaseItem.BASE_ARMOR_START; i++)
			{
				bool flag = BaseItem.items[i].Name == name;
				if (flag)
				{
					return BaseItem.items[i] as BaseMiscItem;
				}
			}
			throw new ArgumentException(string.Format("No BaseMiscItem with Name {0} found !", name));
		}

		// Token: 0x0600B912 RID: 47378 RVA: 0x002DFC14 File Offset: 0x002DDE14
		public static BaseArmor GetArmor(int index)
		{
			bool flag = index < 0 || index >= BaseItem.ItemCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException();
			}
			BaseItem baseItem = BaseItem.items[index];
			bool flag2 = baseItem is BaseArmor;
			if (flag2)
			{
				return baseItem as BaseArmor;
			}
			throw new ArgumentException(string.Format("BaseItem {0} is not a BaseArmor !", baseItem.Name));
		}

		// Token: 0x0600B913 RID: 47379 RVA: 0x002DFC78 File Offset: 0x002DDE78
		public static BaseArmor GetArmor(ItemType type)
		{
			return BaseItem.GetArmor((int)type);
		}

		// Token: 0x0600B914 RID: 47380 RVA: 0x002DFC90 File Offset: 0x002DDE90
		public static BaseArmor GetArmorByID(uint id)
		{
			for (int i = BaseItem.BASE_ARMOR_START; i < BaseItem.BASE_WEAPON_START; i++)
			{
				bool flag = BaseItem.items[i].ID == id;
				if (flag)
				{
					return BaseItem.items[i] as BaseArmor;
				}
			}
			throw new ArgumentException(string.Format("No BaseArmor with ID {0} found !", id));
		}

		// Token: 0x0600B915 RID: 47381 RVA: 0x002DFCF4 File Offset: 0x002DDEF4
		public static BaseArmor GetArmorByCode(string code)
		{
			code = code.ToLower();
			for (int i = BaseItem.BASE_ARMOR_START; i < BaseItem.BASE_WEAPON_START; i++)
			{
				bool flag = BaseItem.items[i].Code == code;
				if (flag)
				{
					return BaseItem.items[i] as BaseArmor;
				}
			}
			throw new ArgumentException(string.Format("No BaseArmor with Code {0} found !", code));
		}

		// Token: 0x0600B916 RID: 47382 RVA: 0x002DFD5C File Offset: 0x002DDF5C
		public static BaseArmor GetArmorByName(string name)
		{
			for (int i = BaseItem.BASE_ARMOR_START; i < BaseItem.BASE_WEAPON_START; i++)
			{
				bool flag = BaseItem.items[i].Name == name;
				if (flag)
				{
					return BaseItem.items[i] as BaseArmor;
				}
			}
			throw new ArgumentException(string.Format("No BaseArmor with Name {0} found !", name));
		}

		// Token: 0x0600B917 RID: 47383 RVA: 0x002DFDBC File Offset: 0x002DDFBC
		public static BaseWeapon GetWeapon(int index)
		{
			bool flag = index < 0 || index >= BaseItem.ItemCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException();
			}
			BaseItem baseItem = BaseItem.items[index];
			bool flag2 = baseItem is BaseWeapon;
			if (flag2)
			{
				return baseItem as BaseWeapon;
			}
			throw new ArgumentException(string.Format("BaseItem {0} is not a BaseWeapon !", baseItem.Name));
		}

		// Token: 0x0600B918 RID: 47384 RVA: 0x002DFE20 File Offset: 0x002DE020
		public static BaseWeapon GetWeapon(ItemType type)
		{
			return BaseItem.GetWeapon((int)type);
		}

		// Token: 0x0600B919 RID: 47385 RVA: 0x002DFE38 File Offset: 0x002DE038
		public static BaseWeapon GetWeaponByID(uint id)
		{
			for (int i = BaseItem.BASE_WEAPON_START; i < BaseItem.ItemCount; i++)
			{
				bool flag = BaseItem.items[i].ID == id;
				if (flag)
				{
					return BaseItem.items[i] as BaseWeapon;
				}
			}
			throw new ArgumentException(string.Format("No BaseWeapon with ID {0} found !", id));
		}

		// Token: 0x0600B91A RID: 47386 RVA: 0x002DFE9C File Offset: 0x002DE09C
		public static BaseWeapon GetWeaponByCode(string code)
		{
			code = code.ToLower();
			for (int i = BaseItem.BASE_WEAPON_START; i < BaseItem.ItemCount; i++)
			{
				bool flag = BaseItem.items[i].Code == code;
				if (flag)
				{
					return BaseItem.items[i] as BaseWeapon;
				}
			}
			throw new ArgumentException(string.Format("No BaseWeapon with Code {0} found !", code));
		}

		// Token: 0x0600B91B RID: 47387 RVA: 0x002DFF04 File Offset: 0x002DE104
		public static BaseWeapon GetWeaponByName(string name)
		{
			for (int i = BaseItem.BASE_WEAPON_START; i < BaseItem.ItemCount; i++)
			{
				bool flag = BaseItem.items[i].Name == name;
				if (flag)
				{
					return BaseItem.items[i] as BaseWeapon;
				}
			}
			throw new ArgumentException(string.Format("No BaseWeapon with Name {0} found !", name));
		}

		// Token: 0x0600B91C RID: 47388 RVA: 0x002DFF64 File Offset: 0x002DE164
		public static uint GetIdFromCode(string code)
		{
			uint num = 0U;
			for (int i = 0; i < 4; i++)
			{
				num |= (uint)((uint)((byte)((i < code.Length) ? (code[i] & 'ÿ') : ' ')) << i * 8);
			}
			return num;
		}

		// Token: 0x0600B91D RID: 47389 RVA: 0x002DFFB0 File Offset: 0x002DE1B0
		public static string GetCodeFromId(uint id)
		{
			char[] array = new char[4];
			for (int i = 0; i < 4; i++)
			{
				array[i] = (char)((byte)(id >> i * 8));
			}
			return new string(array);
		}

		// Token: 0x04006B88 RID: 27528
		protected ItemType type;

		// Token: 0x04006B89 RID: 27529
		protected int index;

		// Token: 0x04006B8A RID: 27530
		protected int tableIndex;

		// Token: 0x04006B8B RID: 27531
		protected BaseItemType baseType;

		// Token: 0x04006B8C RID: 27532
		protected BaseItemType baseType2;

		// Token: 0x04006B8D RID: 27533
		protected string code;

		// Token: 0x04006B8E RID: 27534
		protected uint id;

		// Token: 0x04006B8F RID: 27535
		protected uint nightmareUpgrade;

		// Token: 0x04006B90 RID: 27536
		protected uint hellUpgrade;

		// Token: 0x04006B91 RID: 27537
		protected int akaraMagicLvl;

		// Token: 0x04006B92 RID: 27538
		protected int akaraMagicMax;

		// Token: 0x04006B93 RID: 27539
		protected int akaraMagicMin;

		// Token: 0x04006B94 RID: 27540
		protected int akaraMax;

		// Token: 0x04006B95 RID: 27541
		protected int akaraMin;

		// Token: 0x04006B96 RID: 27542
		protected int alkorMagicLvl;

		// Token: 0x04006B97 RID: 27543
		protected int alkorMagicMax;

		// Token: 0x04006B98 RID: 27544
		protected int alkorMagicMin;

		// Token: 0x04006B99 RID: 27545
		protected int alkorMax;

		// Token: 0x04006B9A RID: 27546
		protected int alkorMin;

		// Token: 0x04006B9B RID: 27547
		protected string alternateGfx;

		// Token: 0x04006B9C RID: 27548
		protected int ashearaMagicLvl;

		// Token: 0x04006B9D RID: 27549
		protected int ashearaMagicMax;

		// Token: 0x04006B9E RID: 27550
		protected int ashearaMagicMin;

		// Token: 0x04006B9F RID: 27551
		protected int ashearaMax;

		// Token: 0x04006BA0 RID: 27552
		protected int ashearaMin;

		// Token: 0x04006BA1 RID: 27553
		protected int autoPrefix;

		// Token: 0x04006BA2 RID: 27554
		protected bool belt;

		// Token: 0x04006BA3 RID: 27555
		protected int bitField1;

		// Token: 0x04006BA4 RID: 27556
		protected int cainMagicLvl;

		// Token: 0x04006BA5 RID: 27557
		protected int cainMagicMax;

		// Token: 0x04006BA6 RID: 27558
		protected int cainMagicMin;

		// Token: 0x04006BA7 RID: 27559
		protected int cainMax;

		// Token: 0x04006BA8 RID: 27560
		protected int cainMin;

		// Token: 0x04006BA9 RID: 27561
		protected int charsiMagicLvl;

		// Token: 0x04006BAA RID: 27562
		protected int charsiMagicMax;

		// Token: 0x04006BAB RID: 27563
		protected int charsiMagicMin;

		// Token: 0x04006BAC RID: 27564
		protected int charsiMax;

		// Token: 0x04006BAD RID: 27565
		protected int charsiMin;

		// Token: 0x04006BAE RID: 27566
		protected int compactSave;

		// Token: 0x04006BAF RID: 27567
		protected int component;

		// Token: 0x04006BB0 RID: 27568
		protected int cost;

		// Token: 0x04006BB1 RID: 27569
		protected int drehyaMagicLvl;

		// Token: 0x04006BB2 RID: 27570
		protected int drehyaMagicMax;

		// Token: 0x04006BB3 RID: 27571
		protected int drehyaMagicMin;

		// Token: 0x04006BB4 RID: 27572
		protected int drehyaMax;

		// Token: 0x04006BB5 RID: 27573
		protected int drehyaMin;

		// Token: 0x04006BB6 RID: 27574
		protected int drognanMagicLvl;

		// Token: 0x04006BB7 RID: 27575
		protected int drognanMagicMax;

		// Token: 0x04006BB8 RID: 27576
		protected int drognanMagicMin;

		// Token: 0x04006BB9 RID: 27577
		protected int drognanMax;

		// Token: 0x04006BBA RID: 27578
		protected int drognanMin;

		// Token: 0x04006BBB RID: 27579
		protected int dropSfxFrame;

		// Token: 0x04006BBC RID: 27580
		protected string dropSound;

		// Token: 0x04006BBD RID: 27581
		protected int durabilityWarning;

		// Token: 0x04006BBE RID: 27582
		protected int elzixMagicLvl;

		// Token: 0x04006BBF RID: 27583
		protected int elzixMagicMax;

		// Token: 0x04006BC0 RID: 27584
		protected int elzixMagicMin;

		// Token: 0x04006BC1 RID: 27585
		protected int elzixMax;

		// Token: 0x04006BC2 RID: 27586
		protected int elzixMin;

		// Token: 0x04006BC3 RID: 27587
		protected int faraMagicLvl;

		// Token: 0x04006BC4 RID: 27588
		protected int faraMagicMax;

		// Token: 0x04006BC5 RID: 27589
		protected int faraMagicMin;

		// Token: 0x04006BC6 RID: 27590
		protected int faraMax;

		// Token: 0x04006BC7 RID: 27591
		protected int faraMin;

		// Token: 0x04006BC8 RID: 27592
		protected string flippyFile;

		// Token: 0x04006BC9 RID: 27593
		protected int gambleCost;

		// Token: 0x04006BCA RID: 27594
		protected int gameArt;

		// Token: 0x04006BCB RID: 27595
		protected int gemApplyType;

		// Token: 0x04006BCC RID: 27596
		protected int gemOffset;

		// Token: 0x04006BCD RID: 27597
		protected int gemSockets;

		// Token: 0x04006BCE RID: 27598
		protected int gheedMagicLvl;

		// Token: 0x04006BCF RID: 27599
		protected int gheedMagicMax;

		// Token: 0x04006BD0 RID: 27600
		protected int gheedMagicMin;

		// Token: 0x04006BD1 RID: 27601
		protected int gheedMax;

		// Token: 0x04006BD2 RID: 27602
		protected int gheedMin;

		// Token: 0x04006BD3 RID: 27603
		protected int halbuMagicLvl;

		// Token: 0x04006BD4 RID: 27604
		protected int halbuMagicMax;

		// Token: 0x04006BD5 RID: 27605
		protected int halbuMagicMin;

		// Token: 0x04006BD6 RID: 27606
		protected int halbuMax;

		// Token: 0x04006BD7 RID: 27607
		protected int halbuMin;

		// Token: 0x04006BD8 RID: 27608
		protected bool hasInv;

		// Token: 0x04006BD9 RID: 27609
		protected int hraltiMagicLvl;

		// Token: 0x04006BDA RID: 27610
		protected int hraltiMagicMax;

		// Token: 0x04006BDB RID: 27611
		protected int hraltiMagicMin;

		// Token: 0x04006BDC RID: 27612
		protected int hraltiMax;

		// Token: 0x04006BDD RID: 27613
		protected int hraltiMin;

		// Token: 0x04006BDE RID: 27614
		protected string invFile;

		// Token: 0x04006BDF RID: 27615
		protected int invHeight;

		// Token: 0x04006BE0 RID: 27616
		protected int invTrans;

		// Token: 0x04006BE1 RID: 27617
		protected int invWidth;

		// Token: 0x04006BE2 RID: 27618
		protected int jamellaMagicLvl;

		// Token: 0x04006BE3 RID: 27619
		protected int jamellaMagicMax;

		// Token: 0x04006BE4 RID: 27620
		protected int jamellaMagicMin;

		// Token: 0x04006BE5 RID: 27621
		protected int jamellaMax;

		// Token: 0x04006BE6 RID: 27622
		protected int jamellaMin;

		// Token: 0x04006BE7 RID: 27623
		protected int larzukMagicLvl;

		// Token: 0x04006BE8 RID: 27624
		protected int larzukMagicMax;

		// Token: 0x04006BE9 RID: 27625
		protected int larzukMagicMin;

		// Token: 0x04006BEA RID: 27626
		protected int larzukMax;

		// Token: 0x04006BEB RID: 27627
		protected int larzukMin;

		// Token: 0x04006BEC RID: 27628
		protected int level;

		// Token: 0x04006BED RID: 27629
		protected int levelReq;

		// Token: 0x04006BEE RID: 27630
		protected int lightRadius;

		// Token: 0x04006BEF RID: 27631
		protected int lysanderMagicLvl;

		// Token: 0x04006BF0 RID: 27632
		protected int lysanderMagicMax;

		// Token: 0x04006BF1 RID: 27633
		protected int lysanderMagicMin;

		// Token: 0x04006BF2 RID: 27634
		protected int lysanderMax;

		// Token: 0x04006BF3 RID: 27635
		protected int lysanderMin;

		// Token: 0x04006BF4 RID: 27636
		protected int malahMagicLvl;

		// Token: 0x04006BF5 RID: 27637
		protected int malahMagicMax;

		// Token: 0x04006BF6 RID: 27638
		protected int malahMagicMin;

		// Token: 0x04006BF7 RID: 27639
		protected int malahMax;

		// Token: 0x04006BF8 RID: 27640
		protected int malahMin;

		// Token: 0x04006BF9 RID: 27641
		protected int maxDamage;

		// Token: 0x04006BFA RID: 27642
		protected int maxStack;

		// Token: 0x04006BFB RID: 27643
		protected int minDamage;

		// Token: 0x04006BFC RID: 27644
		protected int minStack;

		// Token: 0x04006BFD RID: 27645
		protected int missileType;

		// Token: 0x04006BFE RID: 27646
		protected string name;

		// Token: 0x04006BFF RID: 27647
		protected bool nameable;

		// Token: 0x04006C00 RID: 27648
		protected string nameString;

		// Token: 0x04006C01 RID: 27649
		protected bool noDurability;

		// Token: 0x04006C02 RID: 27650
		protected int ormusMagicLvl;

		// Token: 0x04006C03 RID: 27651
		protected int ormusMagicMax;

		// Token: 0x04006C04 RID: 27652
		protected int ormusMagicMin;

		// Token: 0x04006C05 RID: 27653
		protected int ormusMax;

		// Token: 0x04006C06 RID: 27654
		protected int ormusMin;

		// Token: 0x04006C07 RID: 27655
		protected int quantityWarning;

		// Token: 0x04006C08 RID: 27656
		protected int quest;

		// Token: 0x04006C09 RID: 27657
		protected int rarity;

		// Token: 0x04006C0A RID: 27658
		protected int skipName;

		// Token: 0x04006C0B RID: 27659
		protected int sourceArt;

		// Token: 0x04006C0C RID: 27660
		protected bool spawnable;

		// Token: 0x04006C0D RID: 27661
		protected int speed;

		// Token: 0x04006C0E RID: 27662
		protected bool stackable;

		// Token: 0x04006C0F RID: 27663
		protected int transform;

		// Token: 0x04006C10 RID: 27664
		protected bool transparent;

		// Token: 0x04006C11 RID: 27665
		protected int transTbl;

		// Token: 0x04006C12 RID: 27666
		protected bool unique;

		// Token: 0x04006C13 RID: 27667
		protected string uniqueInvFile;

		// Token: 0x04006C14 RID: 27668
		protected bool useable;

		// Token: 0x04006C15 RID: 27669
		protected string useSound;

		// Token: 0x04006C16 RID: 27670
		protected int version;

		// Token: 0x04006C17 RID: 27671
		public static readonly int BASE_ARMOR_START = 145;

		// Token: 0x04006C18 RID: 27672
		public static readonly int BASE_WEAPON_START = 346;

		// Token: 0x04006C19 RID: 27673
		private static int ItemCount = 0;

		// Token: 0x04006C1A RID: 27674
		protected static BaseItem[] items = new BaseItem[]
		{
			new BaseMiscItem(BaseItem.ItemCount++, "Elixir", "Elixir", -1, 1, 0, 21, 0, 4, 1, 0, 1, 20, -1, -1, "elx", "elx", "elx", 16, 1, 1, 0, 0, 0, "flppot", "invpot", "", "", 0, "xxx", -1, -1, 1, 0, "elix", "", "item_potion", 14, "item_potion_drink", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, 8, -1, -1, -1, -1, 13, 5, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Potion Of Healing", "Healing Potion", -1, 1, 0, 0, 0, 1, 0, 0, 1, 30, -1, -1, "hpo", "hpo", "hp1", 16, 1, 1, 0, 0, 0, "flprps", "invrps", "", "", 0, "xxx", -1, -1, 1, 0, "hpot", "", "item_potion", 14, "item_potion_drink", 0, 0, 5, 0, 1, 1, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, 1, 1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Potion Of Mana", "Mana Potion", -1, 1, 0, 0, 0, 1, 0, 0, 1, 30, -1, -1, "mpo", "mpo", "mp1", 16, 1, 1, 0, 0, 0, "flpbps", "invbps", "", "", 0, "xxx", -1, -1, 1, 0, "mpot", "", "item_potion", 14, "item_potion_drink", 0, 0, 5, 0, 1, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, 1, 1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Full Healing Potion", "Full Healing Potion", -1, 1, 0, 0, 0, 2, 0, 0, 1, 150, -1, -1, "hpf", "hpo", "hp5", 16, 1, 1, 0, 0, 0, "flprpl", "invrpl", "", "", 0, "xxx", -1, -1, 1, 0, "hpot", "", "item_potion", 14, "item_potion_drink", 0, 0, 5, 0, 1, 1, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, 1, 1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Full Mana Potion", "Full Mana Potion", -1, 1, 0, 0, 0, 2, 0, 0, 1, 150, -1, -1, "mpf", "mpo", "mp5", 16, 1, 1, 0, 0, 0, "flpbpl", "invbpl", "", "", 0, "xxx", -1, -1, 1, 0, "mpot", "", "item_potion", 14, "item_potion_drink", 0, 0, 5, 0, 1, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, 1, 1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Stamina Potion", "Stamina Potion", -1, 1, 0, 0, 0, 1, 1, 0, 1, 25, -1, -1, "vps", "vps", "vps", 16, 1, 1, 0, 0, 0, "flpwps", "invwps", "", "", 0, "xxx", -1, -1, 1, 0, "spot", "", "item_potion", 14, "item_potion_drink", 0, 0, 5, 0, 1, 0, 0, 0, 0, 0, -1, -1, 0, -1, 9, 180, -1, -1, 750, 28, 5000, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 2, 4, -1, -1, 255, -1, -1, -1, -1, 255, 3, 5, 3, 5, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 3, 5, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 2, 3, -1, -1, 255, -1, -1, -1, -1, 255, 2, 3, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 2, 3, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, 1, 1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Antidote Potion", "Antidote Potion", -1, 1, 0, 0, 0, 1, 1, 0, 1, 40, -1, -1, "yps", "yps", "yps", 16, 1, 1, 0, 0, 0, "flpnps", "invnps", "", "", 0, "xxx", -1, -1, 1, 0, "apot", "", "item_potion", 14, "item_potion_drink", 0, 0, 5, 0, 1, 0, 0, 0, 0, 0, -1, -1, 0, -1, 6, 178, 2, -1, 750, 45, 50, 46, 10, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 2, 4, -1, -1, 255, -1, -1, -1, -1, 255, 9, 15, 9, 15, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 8, 11, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 8, 11, -1, -1, 255, -1, -1, -1, -1, 255, 3, 5, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 3, 5, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, 1, 1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Rejuvenation Potion", "Rejuv Potion", -1, 1, 0, 0, 0, 2, 0, 0, 1, 400, -1, -1, "rvs", "yps", "rvs", 16, 1, 1, 0, 0, 0, "flpvps", "invvps", "", "", 0, "xxx", -1, -1, 1, 0, "rpot", "", "item_potion", 14, "item_potion_drink", 0, 0, 5, 0, 1, 1, 0, 0, 0, 0, -1, -1, 0, -1, 5, -1, -1, -1, -1, 6, 35, 8, 35, -1, -1, 1, "ItemStatsrejuv1", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Full Rejuvenation Potion", "Full Rejuv Potion", -1, 1, 0, 0, 0, 2, 0, 0, 1, 1500, -1, -1, "rvl", "ypl", "rvl", 16, 1, 1, 0, 0, 0, "flpvpl", "invvpl", "", "", 0, "xxx", -1, -1, 1, 0, "rpot", "", "item_potion", 14, "item_potion_drink", 0, 0, 5, 0, 1, 1, 0, 0, 0, 0, -1, -1, 0, -1, 5, -1, -1, -1, -1, 6, 100, 8, 100, -1, -1, 1, "ItemStatsrejuv2", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Thawing Potion", "Thawing Potion", -1, 1, 0, 0, 0, 2, 1, 0, 1, 25, -1, -1, "wms", "yps", "wms", 16, 1, 1, 0, 0, 0, "flpyps", "invyps", "", "", 0, "xxx", -1, -1, 1, 0, "wpot", "", "item_potion", 14, "item_potion_drink", 0, 0, 5, 0, 1, 0, 0, 0, 0, 0, -1, -1, 0, -1, 6, 179, 1, 11, 750, 43, 50, 44, 10, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 2, -1, -1, 255, -1, -1, -1, -1, 255, 3, 5, 3, 5, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 6, 9, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 6, 9, -1, -1, 255, -1, -1, -1, -1, 255, 2, 4, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 2, 4, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, 1, 1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Tome of Town Portal", "Town Portal Book", -1, 0, 0, 0, 0, 2, 1, 0, 1, 250, -1, -1, "tbk", "bbk", "tbk", 16, 1, 2, 0, 0, 0, "flpbbk", "invbbk", "", "", 0, "xxx", -1, -1, 1, 0, "book", "", "item_book", 12, "item_book", 0, 0, 5, 0, 0, 0, 1, 1, 20, 5, -1, -1, 0, -1, 2, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 2, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 2, 4, 2, 4, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 2, 4, 2, 4, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 2, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 2, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, 1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Tome of Identify", "Identify Book", -1, 0, 0, 0, 0, 2, 1, 0, 1, 200, -1, -1, "ibk", "rbk", "ibk", 16, 1, 2, 0, 0, 0, "flprbk", "invrbk", "", "", 0, "xxx", -1, -1, 1, 0, "book", "", "item_book", 12, "item_book", 0, 0, 5, 0, 0, 0, 1, 1, 20, 5, -1, -1, 0, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 2, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 2, 4, 2, 4, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 2, 4, 2, 4, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 2, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 2, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, 1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Amulet", "amulet", -1, 0, 0, 1, 0, 4, 1, 0, 1, 2400, 63000, -1, "amu", "amu", "amu", 16, 1, 1, 1, 1, 1, "flpamu", "invamu", "", "", 0, "xxx", -1, -1, 0, 0, "amul", "", "item_amulet", 12, "item_amulet", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Viper Amulet", "Viper Amulet", -1, 0, 0, 15, 0, 4, 0, 0, 1, 400, -1, -1, "vip", "vip", "vip", 16, 1, 1, 0, 0, 0, "flpamu", "invvip", "invvip", "", 0, "xxx", -1, -1, 0, 0, "amul", "", "item_amulet", 12, "item_amulet", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 10, 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 1, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Ring", "Ring", -1, 0, 0, 1, 0, 4, 1, 0, 1, 1800, 50000, -1, "rin", "rin", "rin", 16, 1, 1, 1, 1, 1, "flprin", "invrin", "", "", 0, "xxx", -1, -1, 0, 0, "ring", "", "item_ring", 12, "item_ring", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Gold", "Gold", -1, 1, 0, 0, 0, 1, 1, 0, 1, 0, -1, -1, "gld", "gld", "gld", 16, 1, 1, 0, 0, 0, "flpgld", "invgld", "", "", 0, "xxx", -1, -1, 0, 0, "gold", "", "item_gold", 12, "item_gold", 0, 0, 5, 0, 0, 0, 1, 0, 5000, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Bark Scroll", "Bark Scroll", -1, 1, 0, 0, 0, 0, 0, 0, 1, 100, -1, -1, "bks", "bks", "bks", 16, 2, 2, 0, 0, 0, "flpscr", "invscb", "", "", 0, "xxx", -1, -1, 0, 0, "ques", "", "item_scroll", 10, "item_scroll", 1, 0, 5, 0, 0, 0, 0, 0, 0, 0, 5, 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Deciphered Bark Scroll", "Deciphered Bark Scroll", -1, 1, 0, 0, 0, 0, 0, 0, 1, 12000, -1, -1, "bkd", "bkd", "bkd", 16, 2, 2, 0, 0, 0, "flpscr", "invscb", "", "", 0, "xxx", -1, -1, 0, 0, "ques", "", "item_scroll", 10, "item_scroll", 1, 0, 5, 0, 0, 0, 0, 0, 0, 0, 5, 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Arrows", "Arrows", -1, 0, 0, 0, 0, 1, 1, 0, 1, 256, -1, -1, "aqv", "aqv", "aqv", 16, 1, 3, 0, 0, 0, "flpqvr", "invqvr", "", "", 0, "xxx", -1, -1, 0, 0, "bowq", "", "item_quiver", 12, "item_quiver", 0, 0, 5, 0, 0, 0, 1, 100, 350, 200, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 1, 0, -1, 0, 3, 5, -1, -1, 255, 1, 3, -1, -1, 255, -1, -1, -1, -1, 255, 3, 4, 3, 4, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 3, 4, 3, 4, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 2, 3, -1, -1, 255, 2, 3, -1, -1, 255, -1, -1, -1, -1, 255, 3, 4, -1, -1, 255, -1, -1, -1, -1, 255, 3, 4, -1, -1, 255, 3, 4, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, 1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Torch", "Torch", -1, 1, 0, 0, 0, 0, 0, 0, 1, 50, -1, -1, "tch", "bsh", "tch", 7, 1, 2, 0, 0, 0, "flptrch", "invtrch", "", "", 0, "xxx", -1, -1, 0, 0, "torc", "", "item_staff", 12, "item_staff", 0, 1, 3, 6, 0, 0, 0, 2, 10, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Bolts", "Bolts", -1, 0, 0, 0, 0, 1, 1, 0, 1, 256, -1, -1, "cqv", "cqv", "cqv", 16, 1, 3, 0, 0, 0, "flpqvr", "invcqv", "", "", 0, "xxx", -1, -1, 0, 0, "xboq", "", "item_quiver", 12, "item_quiver", 0, 0, 5, 0, 0, 0, 1, 60, 250, 150, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 1, 0, -1, 0, 2, 4, -1, -1, 255, 2, 4, -1, -1, 255, -1, -1, -1, -1, 255, 3, 4, 3, 4, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 3, 4, 3, 4, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 2, 3, -1, -1, 255, 2, 3, -1, -1, 255, -1, -1, -1, -1, 255, 3, 4, -1, -1, 255, -1, -1, -1, -1, 255, 3, 4, -1, -1, 255, 3, 4, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, 1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Scroll of Town Portal", "Town Portal Scroll", -1, 1, 0, 0, 0, 2, 1, 0, 1, 100, -1, -1, "tsc", "bsc", "tsc", 16, 1, 1, 0, 0, 0, "flpbsc", "invbsc", "", "", 0, "xxx", -1, -1, 1, 0, "scro", "", "item_scroll", 10, "item_scroll", 0, 0, 5, 0, 1, 0, 0, 0, 0, 0, -1, -1, 0, -1, 2, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 11, 17, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 11, 17, 11, 17, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 11, 17, 11, 17, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 5, 7, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 5, 7, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, 1, 1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Scroll of Identify", "Identify Scroll", -1, 1, 0, 0, 0, 2, 1, 0, 1, 80, -1, -1, "isc", "rsc", "isc", 16, 1, 1, 0, 0, 0, "flprsc", "invrsc", "", "", 0, "xxx", -1, -1, 1, 0, "scro", "", "item_scroll", 10, "item_scroll", 0, 0, 5, 0, 1, 0, 0, 0, 0, 0, -1, -1, 0, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 11, 17, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 11, 17, 11, 17, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 11, 17, 11, 17, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 5, 7, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 5, 7, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, 1, 1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Heart", "Heart", -1, 0, 0, 0, 0, 1, 0, 0, 1, 60, -1, -1, "hrt", "hrt", "hrt", 16, 1, 1, 0, 0, 0, "flphrt", "invhrt", "", "", 1, "hpo", 0, 0, 0, 0, "body", "", "item_monsterguts", 14, "item_monsterguts", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Brain", "Brain", -1, 0, 0, 0, 0, 1, 0, 0, 1, 60, -1, -1, "brz", "brz", "brz", 16, 1, 1, 0, 0, 0, "flpbrnz", "invbrnz", "", "", 1, "opm", 1, 1, 0, 0, "body", "", "item_monsterguts", 14, "item_monsterguts", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Jawbone", "Jawbone", -1, 0, 0, 0, 0, 1, 0, 0, 1, 75, -1, -1, "jaw", "jaw", "jaw", 16, 1, 1, 0, 0, 0, "flpjaw", "invjaw", "", "", 1, "cqv", 10, 40, 0, 0, "body", "", "item_monsterbone", 12, "item_monsterbone", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Eye", "Eye", -1, 0, 0, 0, 0, 1, 0, 0, 1, 45, -1, -1, "eyz", "eyz", "eyz", 16, 1, 1, 0, 0, 0, "flpeye", "inveye", "", "", 1, "mpo", 0, 0, 0, 0, "body", "", "item_monsterguts", 14, "item_monsterguts", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Horn", "Horn", -1, 0, 0, 0, 0, 1, 0, 0, 1, 48, -1, -1, "hrn", "hrn", "hrn", 16, 1, 1, 0, 0, 0, "flphorn", "invhorn", "", "", 1, "aqv", 10, 40, 0, 0, "body", "", "item_monsterbone", 12, "item_monsterbone", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Tail", "Tail", -1, 0, 0, 0, 0, 1, 0, 0, 1, 63, -1, -1, "tal", "tal", "tal", 16, 1, 1, 0, 0, 0, "flptail", "invtail", "", "", 1, "vps", 0, 0, 0, 0, "body", "", "item_monsterguts", 14, "item_monsterguts", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Flag", "Flag", -1, 0, 0, 0, 0, 1, 0, 0, 1, 98, -1, -1, "flg", "flg", "flg", 16, 1, 1, 0, 0, 0, "flpflag", "invflag", "", "", 0, "xxx", -1, -1, 0, 0, "body", "", "item_lightarmor", 12, "item_lightarmor", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Fang", "Fang", -1, 0, 0, 0, 0, 1, 0, 0, 1, 80, -1, -1, "fng", "fng", "fng", 16, 1, 1, 0, 0, 0, "flpfang", "invfang", "", "", 1, "key", 1, 1, 0, 0, "body", "", "item_monsterbone", 12, "item_monsterbone", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Quill", "Quill", -1, 0, 0, 0, 0, 1, 0, 0, 1, 32, -1, -1, "qll", "qll", "qll", 16, 1, 1, 0, 0, 0, "flpquil", "invquil", "", "", 1, "aqv", 10, 40, 0, 0, "body", "", "item_monsterbone", 12, "item_monsterbone", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Soul", "Soul", -1, 0, 0, 0, 0, 1, 0, 0, 1, 100, -1, -1, "sol", "sol", "sol", 16, 1, 1, 0, 0, 0, "flpsple", "invsple", "", "", 1, "mpo", 0, 0, 0, 0, "body", "", "item_rare", 12, "", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Scalp", "Scalp", -1, 0, 0, 0, 0, 1, 0, 0, 1, 40, -1, -1, "scz", "scz", "scz", 16, 1, 1, 0, 0, 0, "flpscp", "invscp", "", "", 1, "hpf", 0, 0, 0, 0, "body", "", "item_monsterguts", 14, "item_monsterguts", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Spleen", "Spleen", -1, 0, 0, 0, 0, 1, 0, 0, 1, 85, -1, -1, "spe", "spe", "spe", 16, 1, 1, 0, 0, 0, "flpsple", "invsple", "", "", 1, "gps", 1, 1, 0, 0, "body", "", "item_monsterguts", 14, "item_monsterguts", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Key", "Skeleton Key", -1, 0, 0, 0, 0, 1, 1, 0, 1, 45, -1, -1, "key", "key", "key", 16, 1, 1, 0, 0, 0, "flpkey", "invkey", "", "", 0, "xxx", -1, -1, 0, 0, "key", "", "item_key", 12, "item_key", 0, 0, 5, 0, 0, 0, 1, 1, 12, 6, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, 5, 9, 5, 9, 255, 1, 2, 1, 2, 255, -1, -1, -1, -1, 255, 6, 9, 6, 9, 255, -1, -1, -1, -1, 255, 2, 3, 2, 3, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 2, 1, 2, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, 1, 1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Mephisto Key", "Mephisto Key", -1, 0, 0, 0, 0, 1, 0, 0, 1, 99999, -1, -1, "luv", "key", "luv", 16, 1, 2, 0, 0, 0, "flpmph", "invmph", "", "", 0, "xxx", -1, -1, 0, 0, "key", "", "item_key", 12, "item_key", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 20, 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Scroll of Self Resurrect", "scroll of self resurrect", -1, 0, 0, 0, 0, 999, 0, 0, 1, 10000, -1, -1, "xyz", "scr", "xyz", 16, 1, 1, 0, 0, 0, "flpwps", "invxyz", "", "", 0, "xxx", -1, -1, 1, 0, "ques", "", "item_potion", 14, "item_potion_drink", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 19, 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Jade Figurine", "jade figurine", -1, 1, 0, 0, 0, 0, 0, 0, 1, 100, -1, -1, "j34", "bks", "j34", 16, 1, 2, 0, 0, 0, "flpjbi", "invjbi", "", "", 0, "xxx", -1, -1, 0, 0, "ques", "", "item_rare", 12, "", 1, 0, 3, 0, 0, 0, 0, 0, 0, 0, 19, 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Gold Bird", "gold bird", -1, 1, 0, 0, 0, 0, 0, 0, 1, 100, -1, -1, "g34", "bks", "g34", 16, 1, 2, 0, 0, 0, "flpgbi", "invgbi", "", "", 0, "xxx", -1, -1, 0, 0, "ques", "", "item_rare", 12, "", 1, 0, 4, 0, 0, 0, 0, 0, 0, 0, 19, 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Lam Esen's Tome", "lam esen's tome", -1, 1, 0, 0, 0, 0, 0, 0, 1, 100, -1, -1, "bbb", "bbb", "bbb", 16, 2, 2, 0, 0, 0, "flpbbb", "invbbb", "", "", 0, "xxx", -1, -1, 0, 0, "ques", "", "item_book", 12, "item_book", 1, 0, 5, 0, 0, 0, 0, 0, 0, 0, 16, 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Horadric Cube", "Horadric Cube", -1, 0, 0, 0, 0, 0, 0, 0, 1, 0, -1, -1, "box", "rbk", "box", 16, 2, 2, 0, 0, 0, "flpbox", "invbox", "", "", 0, "xxx", -1, -1, 1, 0, "ques", "", "item_rare", 12, "", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 10, -1, 0, -1, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Horadric Scroll", "Scroll of Horadric Quest Info", -1, 1, 0, 0, 0, 999, 0, 0, 1, 0, -1, -1, "tr1", "grg", "tr1", 16, 2, 2, 0, 0, 0, "flphscr", "invhscr", "", "", 0, "xxx", -1, -1, 0, 0, "ques", "", "item_book", 12, "item_book", 1, 0, 5, 0, 0, 0, 0, 0, 0, 0, 10, 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Mephisto SoulStone", "Mephisto SoulStone", -1, 1, 0, 0, 0, 999, 0, 0, 1, 0, -1, -1, "mss", "scr", "mss", 16, 1, 1, 0, 0, 0, "flpmss", "invmss", "", "", 0, "xxx", -1, -1, 0, 0, "ques", "", "item_gem", 12, "item_gem", 1, 0, 5, 0, 0, 0, 0, 0, 0, 0, 23, 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Book of Skill", "Book of Skill", -1, 1, 0, 0, 0, 999, 0, 0, 1, 0, -1, -1, "ass", "tbk", "ass", 16, 2, 2, 0, 0, 0, "flpbbk", "invsbk", "", "", 0, "xxx", -1, -1, 1, 0, "ques", "", "item_book", 12, "item_book", 1, 0, 5, 0, 0, 0, 0, 0, 0, 0, 15, 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Khalim's Eye", "KhalimEye", -1, 1, 0, 0, 0, 1, 0, 0, 1, 45, -1, -1, "qey", "eyz", "qey", 16, 1, 1, 0, 0, 0, "flpeye", "inveye", "", "", 0, "xxx", -1, -1, 0, 0, "ques", "", "item_monsterguts", 14, "item_monsterguts", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 17, 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Khalim's Heart", "KhalimHeart", -1, 1, 0, 0, 0, 1, 0, 0, 1, 60, -1, -1, "qhr", "hrt", "qhr", 16, 1, 1, 0, 0, 0, "flphrt", "invhrt", "", "", 0, "xxx", -1, -1, 0, 0, "ques", "", "item_monsterguts", 14, "item_monsterguts", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 17, 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Khalim's Brain", "KhalimBrain", -1, 1, 0, 0, 0, 1, 0, 0, 1, 60, -1, -1, "qbr", "brz", "qbr", 16, 1, 1, 0, 0, 0, "flpbrnz", "invbrnz", "", "", 0, "xxx", -1, -1, 0, 0, "ques", "", "item_monsterguts", 14, "item_monsterguts", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 17, 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Ear", "Player Ear", -1, 1, 0, 0, 0, 1, 0, 0, 1, 0, -1, -1, "ear", "ear", "ear", 16, 1, 1, 0, 0, 0, "flpear", "invear", "", "", 0, "xxx", -1, -1, 0, 0, "play", "", "item_monsterguts", 14, "item_monsterguts", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Chipped Amethyst", "Chipped Amethyst", -1, 1, 0, 0, 1, 2, 1, 0, 1, 500, -1, -1, "gcv", "gcv", "gcv", 16, 1, 1, 0, 0, 0, "flpgsv", "invgsva", "", "", 0, "xxx", -1, -1, 0, 0, "gema", "gem0", "item_gem", 12, "item_gem", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, BaseItem.ItemCount, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Flawed Amethyst", "Flawed Amethyst", -1, 1, 0, 0, 5, 3, 1, 0, 1, 1500, -1, -1, "gfv", "gfv", "gfv", 16, 1, 1, 0, 0, 0, "flpgsv", "invgsvb", "", "", 0, "xxx", -1, -1, 0, 0, "gema", "gem1", "item_gem", 12, "item_gem", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, BaseItem.ItemCount, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Amethyst", "Amethyst", -1, 1, 0, 0, 12, 4, 1, 0, 1, 5000, -1, -1, "gsv", "gsv", "gsv", 16, 1, 1, 0, 0, 0, "flpgsv", "invgsvc", "", "", 0, "xxx", -1, -1, 0, 0, "gema", "gem2", "item_gem", 12, "item_gem", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, BaseItem.ItemCount, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Flawless Amethyst", "Flawless Amethyst", -1, 1, 0, 0, 15, 5, 1, 0, 1, 15000, -1, -1, "gzv", "gzv", "gzv", 16, 1, 1, 0, 0, 0, "flpgsv", "invgsvd", "", "", 0, "xxx", -1, -1, 0, 0, "gema", "gem3", "item_gem", 12, "item_gem", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, BaseItem.ItemCount, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Perfect Amethyst", "Perfect Amethyst", -1, 1, 0, 0, 18, 6, 1, 0, 1, 30000, -1, -1, "gpv", "gpv", "gpv", 16, 1, 1, 0, 0, 0, "flpgsv", "invgsve", "", "", 0, "xxx", -1, -1, 0, 0, "gema", "gem4", "item_gem", 12, "item_gem", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Chipped Topaz", "Chipped Topaz", -1, 1, 0, 0, 1, 3, 1, 0, 1, 500, -1, -1, "gcy", "gcy", "gcy", 16, 1, 1, 0, 0, 0, "flpgsy", "invgsya", "", "", 0, "xxx", -1, -1, 0, 0, "gemt", "gem0", "item_gem", 12, "item_gem", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, BaseItem.ItemCount, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Flawed Topaz", "Flawed Topaz", -1, 1, 0, 0, 5, 4, 1, 0, 1, 1500, -1, -1, "gfy", "gfy", "gfy", 16, 1, 1, 0, 0, 0, "flpgsy", "invgsyb", "", "", 0, "xxx", -1, -1, 0, 0, "gemt", "gem1", "item_gem", 12, "item_gem", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, BaseItem.ItemCount, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Topaz", "Topaz", -1, 1, 0, 0, 12, 5, 1, 0, 1, 5000, -1, -1, "gsy", "gsy", "gsy", 16, 1, 1, 0, 0, 0, "flpgsy", "invgsyc", "", "", 0, "xxx", -1, -1, 0, 0, "gemt", "gem2", "item_gem", 12, "item_gem", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, BaseItem.ItemCount, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Flawless Topaz", "Flawless Topaz", -1, 1, 0, 0, 15, 6, 1, 0, 1, 15000, -1, -1, "gly", "gly", "gly", 16, 1, 1, 0, 0, 0, "flpgsy", "invgsyd", "", "", 0, "xxx", -1, -1, 0, 0, "gemt", "gem3", "item_gem", 12, "item_gem", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, BaseItem.ItemCount, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Perfect Topaz", "Perfect Topaz", -1, 1, 0, 0, 18, 7, 1, 0, 1, 30000, -1, -1, "gpy", "gpy", "gpy", 16, 1, 1, 0, 0, 0, "flpgsy", "invgsye", "", "", 0, "xxx", -1, -1, 0, 0, "gemt", "gem4", "item_gem", 12, "item_gem", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Chipped Saphire", "Chipped Saphire", -1, 1, 0, 0, 1, 4, 1, 0, 1, 500, -1, -1, "gcb", "gcb", "gcb", 16, 1, 1, 0, 0, 0, "flpgsb", "invgsba", "", "", 0, "xxx", -1, -1, 0, 0, "gems", "gem0", "item_gem", 12, "item_gem", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, BaseItem.ItemCount, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Flawed Saphire", "Flawed Saphire", -1, 1, 0, 0, 5, 5, 1, 0, 1, 1500, -1, -1, "gfb", "gfb", "gfb", 16, 1, 1, 0, 0, 0, "flpgsb", "invgsbb", "", "", 0, "xxx", -1, -1, 0, 0, "gems", "gem1", "item_gem", 12, "item_gem", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, BaseItem.ItemCount, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Saphire", "Saphire", -1, 1, 0, 0, 12, 6, 1, 0, 1, 5000, -1, -1, "gsb", "gsb", "gsb", 16, 1, 1, 0, 0, 0, "flpgsb", "invgsbc", "", "", 0, "xxx", -1, -1, 0, 0, "gems", "gem2", "item_gem", 12, "item_gem", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, BaseItem.ItemCount, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Flawless Saphire", "Flawless Saphire", -1, 1, 0, 0, 15, 7, 1, 0, 1, 15000, -1, -1, "glb", "glb", "glb", 16, 1, 1, 0, 0, 0, "flpgsb", "invgsbd", "", "", 0, "xxx", -1, -1, 0, 0, "gems", "gem3", "item_gem", 12, "item_gem", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, BaseItem.ItemCount, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Perfect Saphire", "Perfect Saphire", -1, 1, 0, 0, 18, 8, 1, 0, 1, 30000, -1, -1, "gpb", "gpb", "gpb", 16, 1, 1, 0, 0, 0, "flpgsb", "invgsbe", "", "", 0, "xxx", -1, -1, 0, 0, "gems", "gem4", "item_gem", 12, "item_gem", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Chipped Emerald", "Chipped Emerald", -1, 1, 0, 0, 1, 5, 1, 0, 1, 500, -1, -1, "gcg", "gcg", "gcg", 16, 1, 1, 0, 0, 0, "flpgsg", "invgsga", "", "", 0, "xxx", -1, -1, 0, 0, "geme", "gem0", "item_gem", 12, "item_gem", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, BaseItem.ItemCount, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Flawed Emerald", "Flawed Emerald", -1, 1, 0, 0, 5, 6, 1, 0, 1, 1500, -1, -1, "gfg", "gfg", "gfg", 16, 1, 1, 0, 0, 0, "flpgsg", "invgsgb", "", "", 0, "xxx", -1, -1, 0, 0, "geme", "gem1", "item_gem", 12, "item_gem", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, BaseItem.ItemCount, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Emerald", "Emerald", -1, 1, 0, 0, 12, 7, 1, 0, 1, 5000, -1, -1, "gsg", "gsg", "gsg", 16, 1, 1, 0, 0, 0, "flpgsg", "invgsgc", "", "", 0, "xxx", -1, -1, 0, 0, "geme", "gem2", "item_gem", 12, "item_gem", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, BaseItem.ItemCount, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Flawless Emerald", "Flawless Emerald", -1, 1, 0, 0, 15, 8, 1, 0, 1, 15000, -1, -1, "glg", "glg", "glg", 16, 1, 1, 0, 0, 0, "flpgsg", "invgsgd", "", "", 0, "xxx", -1, -1, 0, 0, "geme", "gem3", "item_gem", 12, "item_gem", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, BaseItem.ItemCount, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Perfect Emerald", "Perfect Emerald", -1, 1, 0, 0, 18, 9, 1, 0, 1, 30000, -1, -1, "gpg", "gpg", "gpg", 16, 1, 1, 0, 0, 0, "flpgsg", "invgsge", "", "", 0, "xxx", -1, -1, 0, 0, "geme", "gem4", "item_gem", 12, "item_gem", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Chipped Ruby", "Chipped Ruby", -1, 1, 0, 0, 1, 6, 1, 0, 1, 500, -1, -1, "gcr", "gcr", "gcr", 16, 1, 1, 0, 0, 0, "flpgsr", "invgsra", "", "", 0, "xxx", -1, -1, 0, 0, "gemr", "gem0", "item_gem", 12, "item_gem", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, BaseItem.ItemCount, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Flawed Ruby", "Flawed Ruby", -1, 1, 0, 0, 5, 7, 1, 0, 1, 1500, -1, -1, "gfr", "gfr", "gfr", 16, 1, 1, 0, 0, 0, "flpgsr", "invgsrb", "", "", 0, "xxx", -1, -1, 0, 0, "gemr", "gem1", "item_gem", 12, "item_gem", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, BaseItem.ItemCount, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Ruby", "Ruby", -1, 1, 0, 0, 12, 8, 1, 0, 1, 5000, -1, -1, "gsr", "gsr", "gsr", 16, 1, 1, 0, 0, 0, "flpgsr", "invgsrc", "", "", 0, "xxx", -1, -1, 0, 0, "gemr", "gem2", "item_gem", 12, "item_gem", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, BaseItem.ItemCount, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Flawless Ruby", "Flawless Ruby", -1, 1, 0, 0, 15, 9, 1, 0, 1, 15000, -1, -1, "glr", "glr", "glr", 16, 1, 1, 0, 0, 0, "flpgsr", "invgsrd", "", "", 0, "xxx", -1, -1, 0, 0, "gemr", "gem3", "item_gem", 12, "item_gem", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, BaseItem.ItemCount, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Perfect Ruby", "Perfect Ruby", -1, 1, 0, 0, 18, 10, 1, 0, 1, 30000, -1, -1, "gpr", "gpr", "gpr", 16, 1, 1, 0, 0, 0, "flpgsr", "invgsre", "", "", 0, "xxx", -1, -1, 0, 0, "gemr", "gem4", "item_gem", 12, "item_gem", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Chipped Diamond", "Chipped Diamond", -1, 1, 0, 0, 1, 7, 1, 0, 1, 500, -1, -1, "gcw", "gcw", "gcw", 16, 1, 1, 0, 0, 0, "flpgsw", "invgswa", "", "", 0, "xxx", -1, -1, 0, 0, "gemd", "gem0", "item_gem", 12, "item_gem", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, BaseItem.ItemCount, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Flawed Diamond", "Flawed Diamond", -1, 1, 0, 0, 5, 8, 1, 0, 1, 1500, -1, -1, "gfw", "gfw", "gfw", 16, 1, 1, 0, 0, 0, "flpgsw", "invgswb", "", "", 0, "xxx", -1, -1, 0, 0, "gemd", "gem1", "item_gem", 12, "item_gem", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, BaseItem.ItemCount, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Diamond", "Diamond", -1, 1, 0, 0, 12, 9, 1, 0, 1, 5000, -1, -1, "gsw", "gsw", "gsw", 16, 1, 1, 0, 0, 0, "flpgsw", "invgswc", "", "", 0, "xxx", -1, -1, 0, 0, "gemd", "gem2", "item_gem", 12, "item_gem", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, BaseItem.ItemCount, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Flawless Diamond", "Flawless Diamond", -1, 1, 0, 0, 15, 10, 1, 0, 1, 15000, -1, -1, "glw", "glw", "glw", 16, 1, 1, 0, 0, 0, "flpgsw", "invgswd", "", "", 0, "xxx", -1, -1, 0, 0, "gemd", "gem3", "item_gem", 12, "item_gem", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, BaseItem.ItemCount, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Perfect Diamond", "Perfect Diamond", -1, 1, 0, 0, 18, 11, 1, 0, 1, 30000, -1, -1, "gpw", "gpw", "gpw", 16, 1, 1, 0, 0, 0, "flpgsw", "invgswe", "", "", 0, "xxx", -1, -1, 0, 0, "gemd", "gem4", "item_gem", 12, "item_gem", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Minor Healing Potion", "Lesser Healing Potion", -1, 1, 0, 0, 0, 1, 1, 0, 1, 30, -1, -1, "hp1", "hp1", "hp1", 16, 1, 1, 0, 0, 0, "flprps", "invhp1", "", "", 0, "xxx", -1, -1, 1, 0, "hpot", "", "item_potion", 14, "item_potion_drink", 0, 0, 5, 0, 1, 1, 0, 0, 0, 0, -1, -1, 0, -1, 3, 100, -1, -1, 192, 74, 30, -1, -1, -1, -1, 2, "ItemStats1q", 30, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, 0, 0, 0, "hp4", "hp5", -1, -1, 1, 1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Light Healing Potion", "Light Healing Potion", -1, 1, 0, 0, 0, 1, 1, 0, 1, 75, -1, -1, "hp2", "hp2", "hp2", 16, 1, 1, 0, 0, 0, "flprps", "invhp2", "", "", 0, "xxx", -1, -1, 1, 0, "hpot", "", "item_potion", 14, "item_potion_drink", 0, 0, 5, 0, 1, 1, 0, 0, 0, 0, -1, -1, 0, -1, 3, 100, -1, -1, 160, 74, 60, -1, -1, -1, -1, 2, "ItemStats1q", 60, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, 0, 0, 0, "hp4", "hp5", -1, -1, 1, 1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Healing Potion", "Healing Potion", -1, 1, 0, 0, 0, 1, 1, 0, 1, 125, -1, -1, "hp3", "hp3", "hp3", 16, 1, 1, 0, 0, 0, "flprps", "invhp3", "", "", 0, "xxx", -1, -1, 1, 0, "hpot", "", "item_potion", 14, "item_potion_drink", 0, 0, 5, 0, 1, 1, 0, 0, 0, 0, -1, -1, 0, -1, 3, 100, -1, -1, 171, 74, 100, -1, -1, -1, -1, 2, "ItemStats1q", 100, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, 0, 0, 0, "hp4", "hp5", -1, -1, 1, 1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Greater Healing Potion", "Strong Healing Potion", -1, 1, 0, 0, 0, 1, 1, 0, 1, 250, -1, -1, "hp4", "hp4", "hp4", 16, 1, 1, 0, 0, 0, "flprpl", "invhp4", "", "", 0, "xxx", -1, -1, 1, 0, "hpot", "", "item_potion", 14, "item_potion_drink", 0, 0, 5, 0, 1, 1, 0, 0, 0, 0, -1, -1, 0, -1, 3, 100, -1, -1, 192, 74, 180, -1, -1, -1, -1, 2, "ItemStats1q", 180, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "hp5", -1, -1, 1, 1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Super Healing Potion", "Greater Healing Potion", -1, 1, 0, 0, 0, 1, 1, 0, 1, 500, -1, -1, "hp5", "hp5", "hp5", 16, 1, 1, 0, 0, 0, "flprpl", "invhp5", "", "", 0, "xxx", -1, -1, 1, 0, "hpot", "", "item_potion", 14, "item_potion_drink", 0, 0, 5, 0, 1, 1, 0, 0, 0, 0, -1, -1, 0, -1, 3, 100, -1, -1, 256, 74, 320, -1, -1, -1, -1, 2, "ItemStats1q", 320, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, 1, 1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Minor Mana Potion", "Lesser Mana Potion", -1, 1, 0, 0, 0, 1, 1, 0, 1, 60, -1, -1, "mp1", "mp1", "mp1", 16, 1, 1, 0, 0, 0, "flpbps", "invmp1", "", "", 0, "xxx", -1, -1, 1, 0, "mpot", "", "item_potion", 14, "item_potion_drink", 0, 0, 5, 0, 1, 1, 0, 0, 0, 0, -1, -1, 0, -1, 3, 106, -1, -1, 128, 26, 20, -1, -1, -1, -1, 2, "ItemStats1q", 20, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, 0, 0, 0, "mp4", "mp5", -1, -1, 1, 1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Light Mana Potion", "Light Mana Potion", -1, 1, 0, 0, 0, 1, 1, 0, 1, 150, -1, -1, "mp2", "mp2", "mp2", 16, 1, 1, 0, 0, 0, "flpbps", "invmp2", "", "", 0, "xxx", -1, -1, 1, 0, "mpot", "", "item_potion", 14, "item_potion_drink", 0, 0, 5, 0, 1, 1, 0, 0, 0, 0, -1, -1, 0, -1, 3, 106, -1, -1, 128, 26, 40, -1, -1, -1, -1, 2, "ItemStats1q", 40, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, 0, 0, 0, "mp4", "mp5", -1, -1, 1, 1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Mana Potion", "Mana Potion", -1, 1, 0, 0, 0, 1, 1, 0, 1, 300, -1, -1, "mp3", "mp3", "mp3", 16, 1, 1, 0, 0, 0, "flpbps", "invmp3", "", "", 0, "xxx", -1, -1, 1, 0, "mpot", "", "item_potion", 14, "item_potion_drink", 0, 0, 5, 0, 1, 1, 0, 0, 0, 0, -1, -1, 0, -1, 3, 106, -1, -1, 128, 26, 80, -1, -1, -1, -1, 2, "ItemStats1q", 80, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, 0, 0, 0, "mp4", "mp5", -1, -1, 1, 1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Greater Mana Potion", "Strong Mana Potion", -1, 1, 0, 0, 0, 1, 1, 0, 1, 500, -1, -1, "mp4", "mp4", "mp4", 16, 1, 1, 0, 0, 0, "flpbpl", "invmp4", "", "", 0, "xxx", -1, -1, 1, 0, "mpot", "", "item_potion", 14, "item_potion_drink", 0, 0, 5, 0, 1, 1, 0, 0, 0, 0, -1, -1, 0, -1, 3, 106, -1, -1, 128, 26, 150, -1, -1, -1, -1, 2, "ItemStats1q", 150, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "mp5", -1, -1, 1, 1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Super Mana Potion", "Greater Mana Potion", -1, 1, 0, 0, 0, 1, 1, 0, 1, 1000, -1, -1, "mp5", "mp5", "mp5", 16, 1, 1, 0, 0, 0, "flpbpl", "invmp5", "", "", 0, "xxx", -1, -1, 1, 0, "mpot", "", "item_potion", 14, "item_potion_drink", 0, 0, 5, 0, 1, 1, 0, 0, 0, 0, -1, -1, 0, -1, 3, 106, -1, -1, 128, 26, 250, -1, -1, -1, -1, 2, "ItemStats1q", 250, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, 1, 1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Chipped Skull", "Chipped Skull", -1, 1, 0, 0, 1, 8, 1, 0, 1, 1000, -1, -1, "skc", "skc", "skc", 16, 1, 1, 0, 0, 0, "flpskl", "invskc", "", "", 0, "xxx", -1, -1, 0, 0, "gemz", "gem0", "item_monsterbone", 12, "item_monsterbone", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, BaseItem.ItemCount, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Flawed Skull", "Flawed Skull", -1, 1, 0, 0, 5, 9, 1, 0, 1, 3000, -1, -1, "skf", "skf", "skf", 16, 1, 1, 0, 0, 0, "flpskl", "invskf", "", "", 0, "xxx", -1, -1, 0, 0, "gemz", "gem1", "item_monsterbone", 12, "item_monsterbone", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, BaseItem.ItemCount, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Skull", "Skull", -1, 1, 0, 0, 12, 10, 1, 0, 1, 10000, -1, -1, "sku", "sku", "sku", 16, 1, 1, 0, 0, 0, "flpskl", "invsku", "", "", 0, "xxx", -1, -1, 0, 0, "gemz", "gem2", "item_monsterbone", 12, "item_monsterbone", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, BaseItem.ItemCount, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Flawless Skull", "Flawless Skull", -1, 1, 0, 0, 15, 11, 1, 0, 1, 30000, -1, -1, "skl", "skl", "skl", 16, 1, 1, 0, 0, 0, "flpskl", "invskl", "", "", 0, "xxx", -1, -1, 0, 0, "gemz", "gem3", "item_monsterbone", 12, "item_monsterbone", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, BaseItem.ItemCount, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Perfect Skull", "Perfect Skull", -1, 1, 0, 0, 18, 12, 1, 0, 1, 100000, -1, -1, "skz", "skz", "skz", 16, 1, 1, 0, 0, 0, "flpskl", "invskz", "", "", 0, "xxx", -1, -1, 0, 0, "gemz", "gem4", "item_monsterbone", 12, "item_monsterbone", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Herb", "herb", -1, 0, 100, 3, 0, 3, 0, 0, 1, 75, -1, -1, "hrb", "hrb", "hrb", 16, 1, 1, 0, 0, 0, "flphrb", "invhrb", "", "", 0, "xxx", -1, -1, 1, 0, "herb", "", "item_herb", 12, "item_herb", 0, 0, 5, 0, 1, 0, 0, 0, 0, 0, -1, -1, 0, -1, 9, 17, -1, -1, 1000, 67, 25, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Small Charm", "Charm Small", -1, 0, 100, 28, 0, 4, 1, 0, 1, 2000, 45000, -1, "cm1", "rld", "cm1", 16, 1, 1, 0, 0, 0, "flpchm1", "invchm", "", "", 0, "xxx", -1, -1, 0, 0, "scha", "", "item_charm", 12, "item_charm", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Large Charm", "Charm Medium", -1, 0, 100, 14, 0, 8, 1, 0, 1, 1000, 38000, -1, "cm2", "rda", "cm2", 16, 1, 2, 0, 0, 0, "flpchm2", "invwnd", "", "", 0, "xxx", -1, -1, 0, 0, "mcha", "", "item_charm", 12, "item_charm", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Grand Charm", "Charm Large", -1, 0, 100, 1, 0, 12, 1, 0, 1, 600, 32000, -1, "cm3", "rgd", "cm3", 16, 1, 3, 0, 0, 0, "flpchm3", "invsst", "", "", 0, "xxx", -1, -1, 0, 0, "lcha", "", "item_charm", 12, "item_charm", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Small Red Potion", "Small Red Potion", -1, 1, 100, 0, 0, 1, 0, 0, 1, 100, -1, -1, "rps", "rps", "hp1", 16, 1, 1, 0, 0, 0, "flprps", "invrps", "", "", 0, "xxx", -1, -1, 1, 0, "hpot", "", "item_potion", 14, "item_potion_drink", 0, 0, 5, 0, 0, 0, 1, 5, 10, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Large Red Potion", "Large Red Potion", -1, 1, 100, 0, 0, 1, 0, 0, 1, 100, -1, -1, "rpl", "rpl", "hp5", 16, 1, 1, 0, 0, 0, "flprpl", "invrpl", "", "", 0, "xxx", -1, -1, 1, 0, "hpot", "", "item_potion", 14, "item_potion_drink", 0, 0, 5, 0, 0, 0, 1, 5, 10, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Small Blue Potion", "Small Blue Potion", -1, 1, 100, 0, 0, 1, 0, 0, 1, 100, -1, -1, "bps", "bps", "mp1", 16, 1, 1, 0, 0, 0, "flpbps", "invbps", "", "", 0, "xxx", -1, -1, 1, 0, "mpot", "", "item_potion", 14, "item_potion_drink", 0, 0, 5, 0, 0, 0, 1, 5, 10, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Large Blue Potion", "Large Blue Potion", -1, 1, 100, 0, 0, 1, 0, 0, 1, 100, -1, -1, "bpl", "bpl", "mp5", 16, 1, 1, 0, 0, 0, "flpbpl", "invbpl", "", "", 0, "xxx", -1, -1, 1, 0, "mpot", "", "item_potion", 14, "item_potion_drink", 0, 0, 5, 0, 0, 0, 1, 5, 10, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "El Rune", "El", -1, 1, 100, 11, 11, 1, 1, 0, 1, 560, -1, -1, "r01", "r01", "r01", 16, 1, 1, 0, 0, 0, "flprun", "invrEl", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Eld Rune", "Eld", -1, 1, 100, 11, 11, 1, 1, 0, 1, 560, -1, -1, "r02", "r02", "r02", 16, 1, 1, 0, 0, 0, "flprun", "invrEld", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Tir Rune", "Tir", -1, 1, 100, 13, 13, 2, 1, 0, 1, 1260, -1, -1, "r03", "r03", "r03", 16, 1, 1, 0, 0, 0, "flprun", "invrTir", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Nef Rune", "Nef", -1, 1, 100, 13, 13, 2, 1, 0, 1, 1260, -1, -1, "r04", "r04", "r04", 16, 1, 1, 0, 0, 0, "flprun", "invrNef", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Eth Rune", "Eth", -1, 1, 100, 15, 15, 3, 1, 0, 1, 2240, -1, -1, "r05", "r05", "r05", 16, 1, 1, 0, 0, 0, "flprun", "invrEth", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Ith Rune", "Ith", -1, 1, 100, 15, 15, 3, 1, 0, 1, 2240, -1, -1, "r06", "r06", "r06", 16, 1, 1, 0, 0, 0, "flprun", "invrIth", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Tal Rune", "Tal", -1, 1, 100, 17, 17, 4, 1, 0, 1, 3500, -1, -1, "r07", "r07", "r07", 16, 1, 1, 0, 0, 0, "flprun", "invrTal", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Ral Rune", "Ral", -1, 1, 100, 19, 19, 5, 1, 0, 1, 5040, -1, -1, "r08", "r08", "r08", 16, 1, 1, 0, 0, 0, "flprun", "invrRal", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Ort Rune", "Ort", -1, 1, 100, 21, 21, 6, 1, 0, 1, 6860, -1, -1, "r09", "r09", "r09", 16, 1, 1, 0, 0, 0, "flprun", "invrOrt", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Thul Rune", "Thul", -1, 1, 100, 23, 23, 7, 1, 0, 1, 8960, -1, -1, "r10", "r10", "r10", 16, 1, 1, 0, 0, 0, "flprun", "invrThul", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Amn Rune", "Amn", -1, 1, 100, 25, 25, 8, 1, 0, 1, 11340, -1, -1, "r11", "r11", "r11", 16, 1, 1, 0, 0, 0, "flprun", "invrAmn", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Sol Rune", "Sol", -1, 1, 100, 27, 27, 9, 1, 0, 1, 14000, -1, -1, "r12", "r12", "r12", 16, 1, 1, 0, 0, 0, "flprun", "invrSol", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Shael Rune", "Shael", -1, 1, 100, 29, 29, 10, 1, 0, 1, 16940, -1, -1, "r13", "r13", "r13", 16, 1, 1, 0, 0, 0, "flprun", "invrShae", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Dol Rune", "Dol", -1, 1, 100, 31, 31, 11, 1, 0, 1, 20160, -1, -1, "r14", "r14", "r14", 16, 1, 1, 0, 0, 0, "flprun", "invrDol", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Hel Rune", "Hel", -1, 1, 100, 33, 0, 12, 1, 0, 1, 1715, -1, -1, "r15", "r15", "r15", 16, 1, 1, 0, 0, 0, "flprun", "invrHel", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Io Rune", "Io", -1, 1, 100, 35, 35, 13, 1, 0, 1, 27440, -1, -1, "r16", "r16", "r16", 16, 1, 1, 0, 0, 0, "flprun", "invrIo", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Lum Rune", "Lum", -1, 1, 100, 37, 37, 14, 1, 0, 1, 31500, -1, -1, "r17", "r17", "r17", 16, 1, 1, 0, 0, 0, "flprun", "invrLum", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Ko Rune", "Ko", -1, 1, 100, 39, 39, 15, 1, 0, 1, 35840, -1, -1, "r18", "r18", "r18", 16, 1, 1, 0, 0, 0, "flprun", "invrKo", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Fal Rune", "Fal", -1, 1, 100, 41, 41, 16, 1, 0, 1, 40460, -1, -1, "r19", "r19", "r19", 16, 1, 1, 0, 0, 0, "flprun", "invrFal", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Lem Rune", "Lem", -1, 1, 100, 43, 43, 17, 1, 0, 1, 45360, -1, -1, "r20", "r20", "r20", 16, 1, 1, 0, 0, 0, "flprun", "invrLem", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Pul Rune", "Pul", -1, 1, 100, 45, 45, 18, 1, 0, 1, 50540, -1, -1, "r21", "r21", "r21", 16, 1, 1, 0, 0, 0, "flprun", "invrPul", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Um Rune", "Um", -1, 1, 100, 47, 47, 19, 1, 0, 1, 56000, -1, -1, "r22", "r22", "r22", 16, 1, 1, 0, 0, 0, "flprun", "invrUm", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Mal Rune", "Mal", -1, 1, 100, 49, 49, 20, 1, 0, 1, 61740, -1, -1, "r23", "r23", "r23", 16, 1, 1, 0, 0, 0, "flprun", "invrMal", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Ist Rune", "Ist", -1, 1, 100, 51, 51, 21, 1, 0, 1, 67760, -1, -1, "r24", "r24", "r24", 16, 1, 1, 0, 0, 0, "flprun", "invrIst", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Gul Rune", "Gul", -1, 1, 100, 53, 53, 22, 1, 0, 1, 74060, -1, -1, "r25", "r25", "r25", 16, 1, 1, 0, 0, 0, "flprun", "invrGul", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Vex Rune", "Vex", -1, 1, 100, 55, 55, 23, 1, 0, 1, 80640, -1, -1, "r26", "r26", "r26", 16, 1, 1, 0, 0, 0, "flprun", "invrVex", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Ohm Rune", "Ohm", -1, 1, 100, 57, 57, 24, 1, 0, 1, 87500, -1, -1, "r27", "r27", "r27", 16, 1, 1, 0, 0, 0, "flprun", "invrOhm", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Lo Rune", "Lo", -1, 1, 100, 59, 59, 25, 1, 0, 1, 94640, -1, -1, "r28", "r28", "r28", 16, 1, 1, 0, 0, 0, "flprun", "invrLo", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Sur Rune", "Sur", -1, 1, 100, 61, 61, 26, 1, 0, 1, 102060, -1, -1, "r29", "r29", "r29", 16, 1, 1, 0, 0, 0, "flprun", "invrSur", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Ber Rune", "Ber", -1, 1, 100, 63, 63, 27, 1, 0, 1, 109760, -1, -1, "r30", "r30", "r30", 16, 1, 1, 0, 0, 0, "flprun", "invrBer", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Jah Rune", "Jah", -1, 1, 100, 65, 65, 28, 1, 0, 1, 117740, -1, -1, "r31", "r31", "r31", 16, 1, 1, 0, 0, 0, "flprun", "invrJo", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Cham Rune", "Cham", -1, 1, 100, 67, 67, 29, 1, 0, 1, 126000, -1, -1, "r32", "r32", "r32", 16, 1, 1, 0, 0, 0, "flprun", "invrCham", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Zod Rune", "Zod", -1, 1, 100, 69, 69, 30, 1, 0, 1, 134540, -1, -1, "r33", "r33", "r33", 16, 1, 1, 0, 0, 0, "flprun", "invrZod", "", "", 0, "xxx", -1, -1, 0, 0, "rune", "", "item_rune", 12, "item_rune", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Jewel", "Jewel", -1, 0, 100, 1, 0, 8, 1, 0, 1, 1000, -1, -1, "jew", "gpw", "jew", 16, 1, 1, 0, 0, 0, "flpgsw", "invgswe", "", "", 0, "xxx", -1, -1, 0, 0, "jewl", "", "item_jewel", 12, "item_jewel", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Maguffin", "ice", -1, 0, 100, 0, 0, 999, 0, 0, 1, 10000, -1, -1, "ice", "scr", "ice", 16, 1, 1, 0, 0, 0, "flpwps", "invxyz", "", "", 0, "xxx", -1, -1, 0, 0, "ques", "", "item_potion", 14, "item_potion_drink", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 32, 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Scroll", "Scroll", -1, 0, 100, 0, 0, 0, 1, 0, 1, 100, -1, -1, "0sc", "rsc", "0sc", 16, 1, 1, 0, 0, 0, "flprsc", "invrsc", "", "", 0, "xxx", -1, -1, 1, 0, "scro", "", "item_scroll", 10, "item_scroll", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Scroll of Malah", "Scroll of Malah - Boost Resistances", -1, 1, 100, 0, 0, 999, 0, 0, 1, 0, -1, -1, "tr2", "scr", "tr2", 16, 2, 2, 0, 0, 0, "flpscr", "invscb", "", "", 0, "xxx", -1, -1, 1, 0, "ques", "", "item_scroll", 10, "item_scroll", 1, 0, 5, 0, 0, 0, 0, 0, 0, 0, 32, 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Key of Terror", "Pandemonium Key 1", -1, 0, 100, 0, 0, 1, 0, 0, 1, 99999, -1, -1, "pk1", "key", "pk1", 16, 1, 2, 0, 0, 0, "flpmph", "invmph", "", "", 0, "xxx", -1, -1, 0, 0, "ques", "", "item_key", 12, "item_key", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Key of Hate", "Pandemonium Key 2", -1, 0, 100, 0, 0, 1, 0, 0, 1, 99999, -1, -1, "pk2", "key", "pk2", 16, 1, 2, 0, 0, 0, "flpmph", "invmph", "", "", 0, "xxx", -1, -1, 0, 0, "ques", "", "item_key", 12, "item_key", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Key of Destruction", "Pandemonium Key 3", -1, 0, 100, 0, 0, 1, 0, 0, 1, 99999, -1, -1, "pk3", "key", "pk3", 16, 1, 2, 0, 0, 0, "flpmph", "invmph", "", "", 0, "xxx", -1, -1, 0, 0, "ques", "", "item_key", 12, "item_key", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Diablo's Horn", "Diablo's Horn", -1, 0, 100, 0, 0, 1, 0, 0, 1, 80, -1, -1, "dhn", "fng", "dhn", 16, 1, 1, 0, 0, 0, "flpfang", "invfang", "", "", 0, "xxx", -1, -1, 0, 0, "ques", "", "item_monsterbone", 12, "item_monsterbone", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Baal's Eye", "Baal's Eye", -1, 0, 109, 0, 0, 1, 0, 0, 1, 80, -1, -1, "bey", "eyz", "bey", 16, 1, 1, 0, 0, 0, "flpeye", "inveye", "", "", 0, "xxx", -1, -1, 0, 0, "ques", "", "item_monsterbone", 12, "item_monsterbone", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Mephisto's Brain", "Mephisto's Brain", -1, 0, 100, 0, 0, 1, 0, 0, 1, 80, -1, -1, "mbr", "brz", "mbr", 16, 1, 1, 0, 0, 0, "flpbrnz", "invbrnz", "", "", 0, "xxx", -1, -1, 0, 0, "ques", "", "item_monsterbone", 12, "item_monsterbone", 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Standard of Heroes", "Standard", -1, 0, 100, 90, 90, 4, 1, 0, 1, 2000, -1, -1, "std", "flg", "std", 16, 1, 1, 0, 0, 0, "flpflag", "invflag", "", "", 0, "xxx", -1, -1, 0, 0, "ques", "", "item_charm", 12, "item_charm", 1, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Essence of Suffering", "Suffering", -1, 0, 100, 90, 90, 4, 1, 0, 1, 2000, -1, -1, "tes", "fng", "test", 16, 1, 1, 0, 0, 0, "flpgsb", "invtes", "", "", 0, "xxx", -1, -1, 0, 0, "ques", "", "item_rare", 12, "item_rare", 1, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Essence of Hatred", "Hatred", -1, 0, 100, 90, 90, 4, 1, 0, 1, 2000, -1, -1, "ceh", "eyz", "ceh", 16, 1, 1, 0, 0, 0, "flpgsb", "invtes", "", "", 0, "xxx", -1, -1, 0, 0, "ques", "", "item_rare", 12, "item_rare", 1, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Essence of Terror", "Terror", -1, 0, 100, 90, 90, 4, 1, 0, 1, 2000, -1, -1, "bet", "fng", "bet", 16, 1, 1, 0, 0, 0, "flpgsb", "invtes", "", "", 0, "xxx", -1, -1, 0, 0, "ques", "", "item_rare", 12, "item_rare", 1, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Essence of Destruction", "Destruction", -1, 0, 100, 90, 90, 4, 1, 0, 1, 2000, -1, -1, "fed", "brz", "fed", 16, 1, 1, 0, 0, 0, "flpgsb", "invtes", "", "", 0, "xxx", -1, -1, 0, 0, "ques", "", "item_rare", 12, "item_rare", 1, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseMiscItem(BaseItem.ItemCount++, "Token of Absolution", "StatReset", -1, 0, 100, 90, 90, 4, 1, 0, 1, 2000, -1, -1, "toa", "toa", "toa", 16, 1, 1, 0, 0, 0, "flpgsb", "invtes", "", "", 0, "xxx", -1, -1, 0, 0, "ques", "", "item_rare", 12, "item_rare", 1, 0, 5, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", -1, 0, 0, 0, -1, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", -1, -1, -1, -1, -1),
			new BaseArmor(BaseItem.ItemCount++, "Cap", 0, 0, 1, 1, 3, 5, 0, 0, 0, 0, 12, 0, 1, 0, 64, 3016, "cap", "cap", -1, -1, "cap", "cap", "cap", "xap", "uap", 0, 0, 2, 2, 1, 2, 1, "flpcap", "invcap", "invcapu", "invcapu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "helm", "", "item_cap", 12, "item_cap", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, 1, 1, 1, 1, 5, -1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 8, 0, "skp", "ghm", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Skull Cap", 0, 0, 4, 1, 8, 11, 0, 0, 15, 0, 18, 0, 5, 0, 441, 5551, "skp", "skp", -1, -1, "skp", "skp", "skp", "xkp", "ukp", 0, 0, 2, 2, 1, 2, 1, "flpskp", "invskp", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "helm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 3, 1, 1, 1, 1, 10, -1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 2, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 8, 0, "hlm", "crn", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Helm", 0, 0, 4, 1, 15, 18, 0, 0, 26, 0, 24, 0, 11, 0, 1558, 12284, "hlm", "hlm", -1, -1, "hlm", "hlm", "hlm", "xlm", "ulm", 0, 0, 2, 2, 1, 2, 1, "flphlm", "invhlm", "invhlmu", "invhlmu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "helm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, 1, -1, 1, 1, -1, -1, -1, -1, 255, 1, 2, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, 1, 1, -1, -1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 8, 0, "fhl", "ghm", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Full Helm", 0, 0, 4, 1, 23, 26, 0, 0, 41, 0, 30, 0, 15, 0, 3095, 21606, "fhl", "fhl", -1, -1, "fhl", "hlm", "fhl", "xhl", "uhl", 0, 0, 2, 2, 1, 2, 1, "flpfhl", "invfhl", "invfhlu", "invfhlu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "helm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "ghm", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Great Helm", 0, 0, 4, 1, 30, 35, 0, 0, 63, 0, 40, 0, 23, 0, 6177, 49517, "ghm", "ghm", -1, -1, "ghm", "hlm", "ghm", "xhm", "uhm", 0, 0, 2, 2, 1, 3, 1, "flpghm", "invghm", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "helm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 2, 2, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 20, -1, -1, -1, -1, 1, -1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 7, 8, 0, "crn", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Crown", 0, 0, 4, 1, 25, 45, 0, 0, 55, 0, 50, 0, 29, 0, 8345, 77501, "crn", "crn", -1, -1, "crn", "hlm", "crn", "xrn", "urn", 0, 0, 2, 2, 1, 3, 1, "flpcrn", "invcrn", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "helm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, 1, 1, -1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Mask", 0, 0, 4, 1, 9, 27, 0, 0, 23, 0, 20, 0, 19, 0, 2857, 25570, "msk", "msk", -1, -1, "msk", "hlm", "msk", "xsk", "usk", 0, 0, 2, 2, 1, 3, 1, "flpmsk", "invmsk", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "helm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Quilted Armor", 0, 0, 1, 1, 8, 11, 0, 0, 12, 0, 20, 0, 1, 0, 140, 3035, "qui", "qui", -1, -1, "qlt", "qlt", "qui", "xui", "uui", 0, 1, 2, 3, 1, 2, 1, "flpqlt", "invqlt", "", "", 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, "tors", "", "item_lightarmor", 12, "item_lightarmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 1, 1, 1, 1, 1, 5, -1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 7, 8, 0, "lea", "gth", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Leather Armor", 0, 0, 2, 1, 14, 17, 0, 0, 15, 0, 24, 0, 3, 0, 481, 4360, "lea", "lea", -1, -1, "lea", "lea", "lea", "xea", "uea", 0, 1, 2, 3, 1, 2, 1, "flplea", "invlea", "", "", 0, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, "tors", "", "item_lightarmor", 12, "item_lightarmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 1, 1, 1, 1, 1, 10, -1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 7, 8, 0, "hla", "ful", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Hard Leather Armor", 0, 0, 3, 1, 21, 24, 0, 0, 20, 0, 28, 0, 5, 0, 1060, 6325, "hla", "hla", -1, -1, "hla", "hla", "hla", "xla", "ula", 0, 1, 2, 3, 1, 2, 1, "flphla", "invhla", "", "", 1, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, "tors", "", "item_lightarmor", 12, "item_lightarmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 1, 1, 1, 1, 1, 15, -1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 7, 8, 0, "stu", "aar", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Studded Leather ", 0, 0, 4, 1, 32, 35, 0, 0, 27, 0, 32, 0, 8, 0, 2385, 11270, "stu", "stu", -1, -1, "stu", "stu", "stu", "xtu", "utu", 0, 1, 2, 3, 1, 2, 1, "flpstu", "invstu", "", "", 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, "tors", "", "item_lightarmor", 12, "item_lightarmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 1, 1, 1, 1, 1, 20, -1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 7, 8, 0, "rng", "ltp", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Ring Mail", 0, 0, 4, 1, 45, 48, 0, 5, 36, 0, 26, 0, 11, 0, 4428, 20177, "rng", "rng", -1, -1, "rng", "rng", "rng", "xng", "ung", 0, 1, 2, 3, 1, 3, 1, "flprng", "invrng", "", "", 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, "tors", "", "item_chainarmor", 12, "item_chainarmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, 1, -1, 1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 7, 8, 0, "scl", "chn", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Scale Mail", 0, 0, 4, 1, 57, 60, 0, 10, 44, 0, 36, 0, 13, 0, 6508, 30151, "scl", "scl", -1, -1, "scl", "scl", "scl", "xcl", "ucl", 0, 1, 2, 3, 1, 2, 1, "flpscl", "invscl", "", "", 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, "tors", "", "item_chainarmor", 12, "item_chainarmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, 1, 1, -1, -1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 7, 8, 0, "chn", "brs", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Chain Mail", 0, 0, 4, 1, 72, 75, 0, 5, 48, 0, 45, 0, 15, 0, 9360, 45100, "chn", "chn", -1, -1, "chn", "chn", "chn", "xhn", "uhn", 0, 1, 2, 3, 1, 2, 1, "flpchn", "invchn", "", "", 1, 1, 1, 1, 2, 2, 0, 0, 0, 0, 0, "tors", "", "item_chainarmor", 12, "item_chainarmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 7, 8, 0, "brs", "spl", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Breast Plate", 0, 0, 4, 1, 65, 68, 1, 0, 30, 0, 50, 0, 18, 0, 10078, 56851, "brs", "brs", -1, -1, "brs", "brs", "brs", "xrs", "urs", 0, 1, 2, 3, 1, 3, 1, "flpbrs", "invbrs", "", "", 0, 0, 2, 0, 2, 2, 0, 0, 0, 0, 0, "tors", "", "item_platearmor", 12, "item_platearmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 7, 8, 0, "spl", "plt", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Splint Mail", 0, 0, 4, 1, 90, 95, 0, 5, 51, 0, 30, 0, 20, 0, 15489, 89945, "spl", "spl", -1, -1, "spl", "spl", "spl", "xpl", "upl", 0, 1, 2, 3, 1, 2, 1, "flpspl", "invspl", "", "", 1, 1, 2, 1, 1, 1, 0, 0, 0, 0, 0, "tors", "", "item_platearmor", 12, "item_platearmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 1, -1, -1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, -1, -1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 7, 8, 0, "plt", "fld", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Plate Mail", 0, 0, 4, 1, 108, 116, 0, 10, 65, 0, 60, 0, 24, 0, 22335, 148510, "plt", "plt", -1, -1, "plt", "plt", "plt", "xlt", "ult", 0, 1, 2, 3, 1, 2, 1, "flpplt", "invplt", "", "", 2, 2, 2, 2, 1, 1, 0, 0, 0, 0, 0, "tors", "", "item_platearmor", 12, "item_platearmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 1, 20, 1, 1, 1, 1, 1, -1, -1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "fld", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Field Plate", 0, 0, 4, 1, 101, 105, 2, 5, 55, 0, 48, 0, 28, 0, 23841, 183387, "fld", "fld", -1, -1, "fld", "fld", "fld", "xld", "uld", 0, 1, 2, 3, 1, 2, 1, "flpfld", "invfld", "", "", 1, 1, 2, 2, 2, 2, 0, 0, 0, 0, 0, "tors", "", "item_platearmor", 12, "item_platearmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 1, -1, -1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 1, -1, -1, 1, 2, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "gth", "ful", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Gothic Plate", 0, 0, 4, 1, 128, 135, 0, 5, 70, 0, 55, 0, 32, 0, 34646, 295668, "gth", "gth", -1, -1, "gth", "gth", "gth", "xth", "uth", 0, 1, 2, 3, 1, 4, 1, "flpgth", "invgth", "", "", 2, 2, 1, 2, 2, 2, 0, 0, 0, 0, 0, "tors", "", "item_platearmor", 12, "item_platearmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 1, -1, -1, -1, -1, 255, -1, -1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 1, 1, 1, 1, 2, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "ful", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Full Plate Mail", 0, 0, 4, 1, 150, 161, 2, 10, 80, 0, 70, 0, 37, 0, 47192, 457526, "ful", "ful", -1, -1, "ful", "ful", "ful", "xul", "uul", 0, 1, 2, 3, 1, 4, 1, "flpful", "invful", "invfulu", "invfulu", 2, 2, 2, 2, 2, 2, 0, 0, 0, 0, 0, "tors", "", "item_platearmor", 12, "item_platearmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 1, 20, -1, -1, -1, -1, 1, 1, 1, 1, 2, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "aar", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Ancient Armor", 0, 0, 4, 1, 218, 233, 5, 5, 100, 0, 60, 0, 40, 0, 73864, 761140, "aar", "aar", -1, -1, "aar", "aar", "aar", "xar", "uar", 0, 1, 2, 3, 1, 4, 1, "flpaar", "invaar", "invaaru", "invaaru", 1, 2, 2, 2, 2, 0, 0, 0, 0, 0, 0, "tors", "", "item_platearmor", 12, "item_platearmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 1, 20, -1, -1, -1, -1, 255, 1, 1, 1, 2, 20, -1, -1, -1, -1, 255, -1, 1, 1, 2, 20, -1, -1, 8, 8, 0, "ltp", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Light Plate", 0, 0, 4, 1, 90, 107, 1, 0, 41, 0, 60, 0, 35, 0, 28327, 267861, "ltp", "ltp", -1, -1, "ltp", "ltp", "ltp", "xtp", "utp", 0, 1, 2, 3, 1, 3, 1, "flpltp", "invltp", "", "", 2, 0, 1, 1, 2, 2, 0, 0, 0, 0, 0, "tors", "", "item_platearmor", 12, "item_platearmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 1, 20, -1, 1, -1, -1, 255, -1, -1, 1, 2, 20, -1, -1, -1, -1, 255, -1, 1, 1, 1, 20, -1, -1, 7, 8, 0, "buc", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Buckler", 0, 0, 2, 1, 4, 6, 0, 0, 12, 0, 12, 0, 1, 0, 68, 3017, "buc", "buc", -1, -1, "buc", "buc", "buc", "xuc", "uuc", 0, 7, 2, 2, 1, 1, 2, "flpbuc", "invbuc", "invbucu", "invbucu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "shie", "", "item_woodshield", 12, "item_woodshield", 0, 0, 5, 0, 0, 0, 0, 0, 1, 0, 1, 3, 100, -1, 0, 3, 1, 1, 1, 1, 3, -1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "sml", "tow", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Small Shield", 0, 0, 3, 1, 8, 10, 0, 0, 22, 5, 16, 0, 5, 0, 410, 5512, "sml", "sml", -1, -1, "buc", "buc", "sml", "xml", "uml", 0, 7, 2, 2, 1, 2, 2, "flpsml", "invsml", "invsmlu", "invsmlu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "shie", "", "item_woodshield", 12, "item_woodshield", 0, 0, 5, 0, 0, 0, 0, 0, 1, 0, 2, 3, 100, -1, 0, 3, 1, 1, 1, 1, 5, -1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 2, 1, 1, 1, -1, -1, -1, 1, 1, -1, -1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 5, 0, "lrg", "kit", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Large Shield", 0, 0, 4, 1, 12, 14, 0, 5, 34, 12, 24, 0, 11, 0, 1214, 11338, "lrg", "lrg", -1, -1, "lrg", "buc", "lrg", "xrg", "urg", 0, 7, 2, 3, 1, 3, 2, "flplrg", "invlrg", "invlrgu", "invlrgu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "shie", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 0, 0, 0, 0, 1, 0, 2, 4, 100, -1, 0, 3, -1, 1, -1, 1, 10, -1, 1, -1, 1, 1, -1, -1, -1, -1, 255, 1, 1, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 2, 0, "kit", "tow", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Kite Shield", 0, 0, 4, 1, 16, 18, 0, 0, 47, 8, 30, 0, 15, 0, 2129, 17983, "kit", "kit", -1, -1, "kit", "buc", "kit", "xit", "uit", 0, 7, 2, 3, 1, 3, 2, "flpkit", "invkit", "invkitu", "invkitu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "shie", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 0, 0, 0, 0, 1, 0, 2, 5, 100, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, 1, 1, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 2, 0, "tow", "gts", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Tower Shield", 0, 0, 4, 1, 22, 25, 1, 10, 75, 24, 60, 0, 22, 0, 4249, 36869, "tow", "tow", -1, -1, "tow", "buc", "tow", "xow", "uow", 0, 7, 2, 3, 1, 3, 2, "flptow", "invtow", "invtowu", "invtowu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "shie", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 0, 0, 0, 0, 1, 0, 1, 5, 100, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 1, -1, -1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 2, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, 1, 1, -1, -1, 1, 1, 1, 1, 2, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, 8, 2, 0, "gts", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Gothic Shield", 0, 0, 4, 1, 30, 35, 0, 5, 60, 16, 40, 0, 30, 0, 8000, 77500, "gts", "gts", -1, -1, "kit", "buc", "gts", "xts", "uts", 0, 7, 2, 4, 1, 3, 2, "flpgts", "invgts", "invgtsu", "invgtsu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "shie", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 0, 0, 0, 0, 1, 0, 2, 6, 100, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 1, -1, -1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 1, -1, -1, 1, 2, 20, -1, -1, -1, -1, 255, -1, -1, 1, 1, 20, -1, -1, 8, 2, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Gloves", 0, 0, 1, 1, 2, 3, 0, 0, 0, 0, 12, 0, 3, 0, 80, 4060, "lgl", "lgl", -1, -1, "lgl", "lgl", "lgl", "xlg", "ulg", 0, 16, 2, 2, 0, 0, 0, "flplgl", "invlgl", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "glov", "", "item_gloves", 12, "item_gloves", 0, 0, 5, 0, 0, 0, 0, 0, 5, 0, 0, 0, -1, -1, 0, 1, 1, 1, 1, 1, 3, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "vgl", "hgl", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Heavy Gloves", 0, 0, 1, 1, 5, 6, 0, 0, 0, 0, 14, 0, 7, 0, 352, 6616, "vgl", "vgl", -1, -1, "vgl", "vgl", "vgl", "xvg", "uvg", 0, 16, 2, 2, 0, 0, 0, "flpvgl", "invvgl", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "glov", "", "item_gloves", 12, "item_gloves", 0, 0, 5, 0, 0, 0, 0, 0, 5, 0, 0, 0, -1, -1, 0, 1, -1, 1, -1, 1, 5, -1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "mgl", "tgl", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Chain Gloves", 0, 0, 2, 1, 8, 9, 0, 0, 25, 0, 16, 0, 12, 0, 859, 11077, "mgl", "mgl", -1, -1, "mgl", "mgl", "mgl", "xmg", "umg", 0, 16, 2, 2, 0, 0, 0, "flpmgl", "invmgl", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "glov", "", "item_gloveschain", 12, "item_gloveschain", 0, 0, 5, 0, 0, 0, 0, 0, 5, 0, 0, 0, -1, -1, 0, 3, -1, 1, -1, -1, 10, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 2, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "tgl", "hgl", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Light Gauntlets", 0, 0, 3, 1, 9, 11, 0, 0, 45, 0, 18, 0, 20, 0, 1635, 20675, "tgl", "tgl", -1, -1, "mgl", "mgl", "tgl", "xtg", "utg", 0, 16, 2, 2, 0, 0, 0, "flptgl", "invtgl", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "glov", "", "item_glovesmetal", 12, "item_glovesmetal", 0, 0, 5, 0, 0, 0, 0, 0, 5, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 2, 1, 1, 1, 1, 2, 1, 1, 1, -1, -1, 1, 1, 255, 1, 1, -1, 1, 255, -1, -1, 1, 1, 20, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Gauntlets", 0, 0, 4, 1, 12, 15, 0, 0, 60, 0, 24, 0, 27, 0, 2964, 36007, "hgl", "hgl", -1, -1, "hgl", "hgl", "hgl", "xhg", "uhg", 0, 16, 2, 2, 0, 0, 0, "flphgl", "invhgl", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "glov", "", "item_glovesmetal", 12, "item_glovesmetal", 0, 0, 5, 0, 0, 0, 0, 0, 5, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, 1, 1, -1, 1, 1, 1, 1, -1, 1, 255, 1, 1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Leather Boots", 0, 0, 1, 1, 2, 3, 0, 0, 0, 0, 12, 0, 3, 0, 80, 4060, "lbt", "lbt", -1, -1, "lbt", "lbt", "lbt", "xlb", "ulb", 0, 16, 2, 2, 0, 0, 0, "flplbt", "invlbt", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "boot", "", "item_boots", 12, "item_boots", 0, 0, 5, 0, 0, 0, 0, 0, 6, 0, 3, 8, 120, -1, 0, 1, 1, 1, 1, 1, 1, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "vbt", "tbt", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Heavy Boots", 0, 0, 1, 1, 5, 6, 0, 0, 18, 0, 14, 0, 7, 0, 334, 6584, "vbt", "vbt", -1, -1, "vbt", "vbt", "vbt", "xvb", "uvb", 0, 16, 2, 2, 0, 0, 0, "flpvbt", "invvbt", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "boot", "", "item_boots", 12, "item_boots", 0, 0, 5, 0, 0, 0, 0, 0, 6, 0, 4, 10, 120, -1, 0, 1, -1, 1, -1, 1, 1, -1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "mbt", "tbt", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Chain Boots", 0, 0, 2, 1, 8, 9, 0, 0, 30, 0, 16, 0, 12, 0, 854, 11062, "mbt", "mbt", -1, -1, "mbt", "mbt", "mbt", "xmb", "umb", 0, 16, 2, 2, 0, 0, 0, "flpmbt", "invmbt", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "boot", "", "item_bootschain", 12, "item_bootschain", 0, 0, 5, 0, 0, 0, 0, 0, 6, 0, 6, 12, 120, -1, 0, 3, -1, 1, -1, -1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 2, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "tbt", "hbt", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Light Plate Boots", 0, 0, 3, 1, 9, 11, 0, 0, 50, 0, 18, 0, 20, 0, 1630, 20650, "tbt", "tbt", -1, -1, "mbt", "mbt", "tbt", "xtb", "utb", 0, 16, 2, 2, 0, 0, 0, "flptbt", "invtbt", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "boot", "", "item_bootsmetal", 12, "item_bootsmetal", 0, 0, 5, 0, 0, 0, 0, 0, 6, 0, 8, 16, 120, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 2, 1, 1, 1, 1, 2, 1, 1, 1, -1, -1, 1, 1, 20, 1, 1, -1, 1, 255, -1, -1, 1, 1, 20, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Plate Boots", 0, 0, 4, 1, 12, 15, 0, 0, 70, 0, 24, 0, 27, 0, 2954, 35939, "hbt", "hbt", -1, -1, "hbt", "hbt", "hbt", "xhb", "uhb", 0, 16, 2, 2, 0, 0, 0, "flphbt", "invhbt", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "boot", "", "item_bootsmetal", 12, "item_bootsmetal", 0, 0, 5, 0, 0, 0, 0, 0, 6, 0, 10, 20, 120, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, 1, 1, -1, 1, 1, 1, 1, 1, 1, 20, 1, 1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Sash", 0, 0, 1, 1, 2, 2, 0, 0, 0, 0, 12, 0, 3, 0, 64, 4048, "lbl", "lbl", -1, -1, "lbl", "lbl", "lbl", "zlb", "ulc", 0, 16, 2, 1, 0, 0, 0, "flplbl", "invlbl", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "belt", "", "item_lightarmor", 12, "item_lightarmor", 0, 0, 5, 0, 0, 1, 0, 0, 4, 0, 0, 0, -1, -1, 0, 1, 1, 1, 1, 1, 1, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "vbl", "tbl", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Light Belt", 0, 0, 1, 1, 3, 3, 0, 0, 0, 0, 14, 0, 7, 0, 192, 6336, "vbl", "vbl", -1, -1, "vbl", "vbl", "vbl", "zvb", "uvc", 0, 16, 2, 1, 0, 0, 0, "flpvbl", "invvbl", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "belt", "", "item_belt", 12, "item_belt", 0, 0, 5, 0, 0, 4, 0, 0, 4, 0, 0, 0, -1, -1, 0, 1, -1, 1, -1, 1, 1, -1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "mbl", "hbl", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Belt", 0, 0, 2, 1, 5, 5, 0, 0, 25, 0, 16, 0, 12, 0, 495, 9985, "mbl", "mbl", -1, -1, "mbl", "mbl", "mbl", "zmb", "umc", 0, 16, 2, 1, 0, 0, 0, "flpmbl", "invmbl", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "belt", "", "item_belt", 12, "item_belt", 0, 0, 5, 0, 0, 0, 0, 0, 4, 0, 0, 0, -1, -1, 0, 1, -1, 1, -1, -1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 2, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "tbl", "hbl", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Heavy Belt", 0, 0, 2, 1, 6, 6, 0, 0, 45, 0, 18, 0, 20, 0, 963, 17315, "tbl", "tbl", -1, -1, "mbl", "mbl", "tbl", "ztb", "utc", 0, 16, 2, 1, 0, 0, 0, "flptbl", "invtbl", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "belt", "", "item_belt", 12, "item_belt", 0, 0, 5, 0, 0, 5, 0, 0, 4, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 2, 1, 1, 1, 1, 2, 1, 1, 1, -1, -1, 1, 1, 20, 1, 1, -1, 1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Plated Belt", 0, 0, 3, 1, 8, 11, 0, 0, 60, 0, 24, 0, 27, 0, 2068, 29959, "hbl", "hbl", -1, -1, "hbl", "hbl", "hbl", "zhb", "uhc", 0, 16, 2, 1, 0, 0, 0, "flphbl", "invhbl", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "belt", "", "item_belt", 12, "item_belt", 0, 0, 5, 0, 0, 3, 0, 0, 4, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, 1, 1, -1, 1, 1, 1, 1, 1, 1, 20, 1, 1, -1, -1, 255, 1, 1, 1, 2, 20, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Bone Helm", 0, 0, 2, 1, 33, 36, 0, 0, 25, 0, 40, 0, 22, 0, 6323, 48276, "bhm", "bhm", -1, -1, "bhm", "hlm", "bhm", "xh9", "uh9", 0, 0, 2, 2, 1, 2, 1, "flpbhm", "invbhm", "invbhmu", "invbhmu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "helm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 2, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 2, 1, 3, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 1, -1, 1, 1, -1, -1, 7, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Bone Shield", 0, 0, 2, 1, 10, 30, 0, 0, 25, 20, 40, 0, 19, 0, 3175, 27081, "bsh", "bsh", -1, -1, "bsh", "buc", "bsh", "xsh", "ush", 0, 7, 2, 3, 1, 2, 2, "flpbsh", "invbsh", "invbshu", "invbshu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "shie", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 0, 0, 0, 0, 1, 0, 3, 6, 100, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 2, 1, 3, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 1, -1, 1, 1, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Spiked Shield", 0, 0, 3, 1, 15, 25, 0, 0, 30, 10, 40, 0, 11, 0, 1890, 13197, "spk", "spk", -1, -1, "spk", "buc", "spk", "xpk", "upk", 0, 7, 2, 3, 1, 2, 2, "flpspk", "invspk", "invspku", "invspku", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "shie", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 0, 0, 0, 0, 1, 0, 5, 9, 100, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 2, 1, 3, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 1, -1, 1, 1, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "War Hat", 0, 0, 1, 1, 45, 53, 0, 0, 20, 0, 12, 0, 34, 22, 13560, 82061, "xap", "xap", -1, -1, "cap", "cap", "cap", "xap", "uap", 0, 0, 2, 2, 1, 2, 1, "flpcap", "invcap", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "helm", "", "item_cap", 12, "item_cap", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Sallet", 0, 0, 4, 1, 52, 62, 0, 0, 43, 0, 18, 0, 37, 25, 17210, 113647, "xkp", "xkp", -1, -1, "skp", "skp", "skp", "xkp", "ukp", 0, 0, 2, 2, 1, 2, 1, "flpskp", "invskp", "invxkpu", "invxkpu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "helm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Casque", 0, 0, 4, 1, 63, 72, 0, 0, 59, 0, 24, 0, 42, 25, 23075, 171804, "xlm", "xlm", -1, -1, "hlm", "hlm", "hlm", "xlm", "ulm", 0, 0, 2, 2, 1, 2, 1, "flphlm", "invhlm", "invhlmu", "invhlmu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "helm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Basinet", 0, 0, 4, 1, 75, 84, 0, 0, 82, 0, 30, 0, 45, 25, 29083, 233910, "xhl", "xhl", -1, -1, "fhl", "fhl", "fhl", "xhl", "uhl", 0, 0, 2, 2, 1, 2, 1, "flpfhl", "invfhl", "invfhlu", "invfhlu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "helm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Winged Helm", 0, 0, 4, 1, 85, 98, 0, 0, 115, 0, 40, 0, 51, 25, 37846, 355900, "xhm", "xhm", -1, -1, "ghm", "ghm", "ghm", "xhm", "uhm", 0, 0, 2, 2, 1, 3, 1, "flpghm", "invghm", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "helm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 7, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Grand Crown", 0, 0, 4, 1, 78, 113, 0, 0, 103, 0, 50, 0, 55, 25, 42458, 448816, "xrn", "xrn", -1, -1, "crn", "crn", "crn", "xrn", "urn", 0, 0, 2, 2, 1, 3, 1, "flpcrn", "invcrn", "invxrnu", "invxrnu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "helm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Death Mask", 0, 0, 4, 1, 54, 86, 0, 0, 55, 0, 20, 0, 48, 25, 27190, 241184, "xsk", "xsk", -1, -1, "msk", "msk", "msk", "xsk", "usk", 0, 0, 2, 2, 1, 3, 1, "flpmsk", "invmsk", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "helm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Ghost Armor", 0, 0, 1, 1, 102, 117, 0, 0, 38, 0, 20, 0, 34, 22, 30552, 165635, "xui", "xui", -1, -1, "qlt", "qlt", "qui", "xui", "uui", 0, 1, 2, 3, 1, 2, 1, "flpqlt", "invqlt", "", "", 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, "tors", "", "item_lightarmor", 12, "item_lightarmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Serpentskin Armor", 0, 0, 2, 1, 111, 126, 0, 0, 43, 0, 24, 0, 36, 24, 34960, 197896, "xea", "xea", -1, -1, "lea", "lea", "lea", "xea", "uea", 0, 1, 2, 3, 1, 2, 1, "flplea", "invlea", "", "", 0, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, "tors", "", "item_lightarmor", 12, "item_lightarmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Demonhide Armor", 0, 0, 3, 1, 122, 136, 0, 0, 50, 0, 28, 0, 37, 25, 39090, 236758, "xla", "xla", -1, -1, "hla", "hla", "hla", "xla", "ula", 0, 1, 2, 3, 1, 2, 1, "flphla", "invhla", "", "", 1, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, "tors", "", "item_lightarmor", 12, "item_lightarmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Trellised Armor", 0, 0, 4, 1, 138, 153, 0, 0, 61, 0, 32, 0, 40, 25, 47582, 305707, "xtu", "xtu", -1, -1, "stu", "stu", "stu", "xtu", "utu", 0, 1, 2, 3, 1, 2, 1, "flpstu", "invstu", "invxtuu", "invxtuu", 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, "tors", "", "item_lightarmor", 12, "item_lightarmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Linked Mail", 0, 0, 4, 1, 158, 172, 0, 5, 74, 0, 26, 0, 42, 25, 56600, 393748, "xng", "xng", -1, -1, "rng", "rng", "rng", "xng", "ung", 0, 1, 2, 3, 1, 3, 1, "flprng", "invrng", "", "", 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, "tors", "", "item_chainarmor", 12, "item_chainarmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Tigulated Mail", 0, 0, 4, 1, 176, 190, 0, 10, 86, 0, 36, 0, 43, 25, 64242, 473193, "xcl", "xcl", -1, -1, "scl", "scl", "scl", "xcl", "ucl", 0, 1, 2, 3, 1, 3, 1, "flpscl", "invscl", "", "", 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, "tors", "", "item_chainarmor", 12, "item_chainarmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Mesh Armor", 0, 0, 4, 1, 198, 213, 0, 5, 92, 0, 45, 0, 45, 25, 75440, 574094, "xhn", "xhn", -1, -1, "chn", "chn", "chn", "xhn", "uhn", 0, 1, 2, 3, 1, 3, 1, "flpchn", "invchn", "", "", 1, 1, 1, 1, 2, 2, 0, 0, 0, 0, 0, "tors", "", "item_chainarmor", 12, "item_chainarmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Cuirass", 0, 0, 4, 1, 188, 202, 1, 0, 65, 0, 50, 0, 47, 25, 74719, 613456, "xrs", "xrs", -1, -1, "brs", "brs", "brs", "xrs", "urs", 0, 1, 2, 3, 1, 3, 1, "flpbrs", "invbrs", "", "invxrss", 0, 0, 2, 0, 2, 2, 0, 0, 0, 0, 0, "tors", "", "item_platearmor", 12, "item_platearmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Russet Armor", 0, 0, 4, 1, 225, 243, 0, 5, 97, 0, 30, 0, 49, 25, 93404, 788235, "xpl", "xpl", -1, -1, "spl", "spl", "spl", "xpl", "upl", 0, 1, 2, 3, 1, 3, 1, "flpspl", "invspl", "", "", 1, 1, 2, 1, 1, 1, 0, 0, 0, 0, 0, "tors", "", "item_platearmor", 12, "item_platearmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Templar Coat", 0, 0, 4, 1, 252, 274, 0, 10, 118, 0, 60, 0, 52, 25, 111395, 1017928, "xlt", "xlt", -1, -1, "plt", "plt", "plt", "xlt", "ult", 0, 1, 2, 3, 1, 3, 1, "flpplt", "invplt", "", "", 2, 2, 2, 2, 1, 1, 0, 0, 0, 0, 0, "tors", "", "item_platearmor", 12, "item_platearmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Sharktooth Armor", 0, 0, 4, 1, 242, 258, 2, 5, 103, 0, 48, 0, 55, 25, 111674, 1103159, "xld", "xld", -1, -1, "fld", "fld", "fld", "xld", "uld", 0, 1, 2, 3, 1, 3, 1, "flpfld", "invfld", "", "", 1, 1, 2, 2, 2, 2, 0, 0, 0, 0, 0, "tors", "", "item_platearmor", 12, "item_platearmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Embossed Plate", 0, 0, 4, 1, 282, 303, 0, 5, 125, 0, 55, 0, 58, 25, 137817, 1457493, "xth", "xth", -1, -1, "gth", "gth", "gth", "xth", "uth", 0, 1, 2, 3, 1, 4, 1, "flpgth", "invgth", "", "", 2, 2, 1, 2, 2, 2, 0, 0, 0, 0, 0, "tors", "", "item_platearmor", 12, "item_platearmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Chaos Armor", 0, 0, 4, 1, 315, 342, 2, 10, 140, 0, 70, 0, 61, 25, 162672, 1888411, "xul", "xul", -1, -1, "ful", "ful", "ful", "xul", "uul", 0, 1, 2, 3, 1, 4, 1, "flpful", "invful", "", "", 2, 2, 2, 2, 2, 2, 0, 0, 0, 0, 0, "tors", "", "item_platearmor", 12, "item_platearmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Ornate Armor", 0, 0, 4, 1, 417, 450, 5, 5, 170, 0, 60, 0, 64, 25, 225120, 2696482, "xar", "xar", -1, -1, "aar", "aar", "aar", "xar", "uar", 0, 1, 2, 3, 1, 4, 1, "flpaar", "invaar", "invxaru", "invxaru", 1, 2, 2, 2, 2, 0, 0, 0, 0, 0, 0, "tors", "", "item_platearmor", 12, "item_platearmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Mage Plate", 0, 0, 4, 1, 225, 261, 1, 0, 55, 0, 60, 0, 60, 25, 118407, 1327498, "xtp", "xtp", -1, -1, "ltp", "ltp", "ltp", "xtp", "utp", 0, 1, 2, 3, 1, 3, 1, "flpltp", "invltp", "", "", 2, 0, 1, 1, 2, 2, 0, 0, 0, 0, 0, "tors", "", "item_platearmor", 12, "item_platearmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 7, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Defender", 0, 0, 2, 1, 41, 49, 0, 0, 38, 10, 68, 0, 34, 22, 12562, 77123, "xuc", "xuc", -1, -1, "buc", "buc", "buc", "xuc", "uuc", 0, 7, 2, 2, 1, 1, 2, "flpbuc", "invbuc", "invbucu", "invbucu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "shie", "", "item_woodshield", 12, "item_woodshield", 0, 0, 5, 0, 0, 0, 0, 0, 1, 0, 8, 12, 100, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Round Shield", 0, 0, 3, 1, 47, 55, 0, 0, 53, 12, 64, 0, 37, 25, 15451, 103735, "xml", "xml", -1, -1, "buc", "buc", "sml", "xml", "uml", 0, 7, 2, 2, 1, 2, 2, "flpsml", "invsml", "invxmlu", "invxmlu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "shie", "", "item_woodshield", 12, "item_woodshield", 0, 0, 5, 0, 0, 0, 0, 0, 1, 0, 7, 14, 100, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 5, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Scutum", 0, 0, 4, 1, 53, 61, 0, 5, 71, 14, 62, 0, 42, 25, 19537, 148359, "xrg", "xrg", -1, -1, "lrg", "lrg", "lrg", "xrg", "urg", 0, 7, 2, 3, 1, 3, 2, "flplrg", "invlrg", "invxrgu", "invxrgu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "shie", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 0, 0, 0, 0, 1, 0, 11, 15, 100, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 2, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Dragon Shield", 0, 0, 4, 1, 59, 67, 0, 0, 91, 18, 76, 0, 45, 25, 23094, 189944, "xit", "xit", -1, -1, "kit", "kit", "kit", "xit", "uit", 0, 7, 2, 3, 1, 3, 2, "flpkit", "invkit", "invkitu", "invkitu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "shie", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 0, 0, 0, 0, 1, 0, 15, 24, 100, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 2, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Pavise", 0, 0, 4, 1, 68, 78, 1, 10, 133, 24, 72, 0, 50, 25, 29550, 278500, "xow", "xow", -1, -1, "tow", "tow", "tow", "xow", "uow", 0, 7, 2, 3, 1, 3, 2, "flptow", "invtow", "invtowu", "invtowu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "shie", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 0, 0, 0, 0, 1, 0, 10, 17, 100, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 2, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Ancient Shield", 0, 0, 4, 1, 80, 93, 0, 5, 110, 16, 80, 0, 56, 25, 39220, 422340, "xts", "xts", -1, -1, "kit", "kit", "gts", "xts", "uts", 0, 7, 2, 4, 1, 3, 2, "flpgts", "invgts", "invgtsu", "invgtsu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "shie", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 0, 0, 0, 0, 1, 0, 12, 16, 100, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 2, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Demonhide Gloves", 0, 0, 1, 1, 28, 35, 0, 0, 20, 0, 12, 0, 33, 21, 8480, 64102, "xlg", "xlg", -1, -1, "lgl", "lgl", "lgl", "xlg", "ulg", 0, 16, 2, 2, 0, 0, 0, "flplgl", "invlgl", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "glov", "", "item_gloves", 12, "item_gloves", 0, 0, 5, 0, 0, 0, 0, 0, 5, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Sharkskin Gloves", 0, 0, 1, 1, 33, 39, 0, 0, 20, 0, 14, 0, 39, 25, 11420, 85063, "xvg", "xvg", -1, -1, "vgl", "vgl", "vgl", "xvg", "uvg", 0, 16, 2, 2, 0, 0, 0, "flpvgl", "invvgl", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "glov", "", "item_gloves", 12, "item_gloves", 0, 0, 5, 0, 0, 0, 0, 0, 5, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Heavy Bracers", 0, 0, 2, 1, 37, 44, 0, 0, 58, 0, 16, 0, 43, 25, 14111, 114806, "xmg", "xmg", -1, -1, "mgl", "mgl", "mgl", "xmg", "umg", 0, 16, 2, 2, 0, 0, 0, "flpmgl", "invmgl", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "glov", "", "item_gloveschain", 12, "item_gloveschain", 0, 0, 5, 0, 0, 0, 0, 0, 5, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Battle Gauntlets", 0, 0, 3, 1, 39, 47, 0, 0, 88, 0, 18, 0, 49, 25, 16913, 161025, "xtg", "xtg", -1, -1, "mgl", "mgl", "tgl", "xtg", "utg", 0, 16, 2, 2, 0, 0, 0, "flptgl", "invtgl", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "glov", "", "item_glovesmetal", 12, "item_glovesmetal", 0, 0, 5, 0, 0, 0, 0, 0, 5, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "War Gauntlets", 0, 0, 4, 1, 43, 53, 0, 0, 110, 0, 24, 0, 54, 25, 20900, 223744, "xhg", "xhg", -1, -1, "hgl", "hgl", "hgl", "xhg", "uhg", 0, 16, 2, 2, 0, 0, 0, "flphgl", "invhgl", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "glov", "", "item_glovesmetal", 12, "item_glovesmetal", 0, 0, 5, 0, 0, 0, 0, 0, 5, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Demonhide Boots", 0, 0, 1, 1, 28, 35, 0, 0, 20, 0, 12, 0, 36, 24, 9230, 64102, "xlb", "xlb", -1, -1, "lbt", "lbt", "lbt", "xlb", "ulb", 0, 16, 2, 2, 0, 0, 0, "flplbt", "invlbt", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "boot", "", "item_boots", 12, "item_boots", 0, 0, 5, 0, 0, 0, 0, 0, 6, 0, 26, 46, 120, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Sharkskin Boots", 0, 0, 1, 1, 33, 39, 0, 0, 47, 0, 14, 0, 39, 25, 11393, 84859, "xvb", "xvb", -1, -1, "vbt", "vbt", "vbt", "xvb", "uvb", 0, 16, 2, 2, 0, 0, 0, "flpvbt", "invvbt", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "boot", "", "item_boots", 12, "item_boots", 0, 0, 5, 0, 0, 0, 0, 0, 6, 0, 28, 50, 120, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Mesh Boots", 0, 0, 2, 1, 37, 44, 0, 0, 65, 0, 16, 0, 43, 25, 14103, 114742, "xmb", "xmb", -1, -1, "mbt", "mbt", "mbt", "xmb", "umb", 0, 16, 2, 2, 0, 0, 0, "flpmbt", "invmbt", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "boot", "", "item_bootschain", 12, "item_bootschain", 0, 0, 5, 0, 0, 0, 0, 0, 6, 0, 23, 52, 120, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Battle Boots", 0, 0, 3, 1, 39, 47, 0, 0, 95, 0, 18, 0, 49, 25, 16905, 160950, "xtb", "xtb", -1, -1, "mbt", "mbt", "tbt", "xtb", "utb", 0, 16, 2, 2, 0, 0, 0, "flptbt", "invtbt", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "boot", "", "item_bootsmetal", 12, "item_bootsmetal", 0, 0, 5, 0, 0, 0, 0, 0, 6, 0, 37, 64, 120, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "War Boots", 0, 0, 4, 1, 43, 53, 0, 0, 125, 0, 24, 0, 54, 25, 20885, 223574, "xhb", "xhb", -1, -1, "hbt", "hbt", "hbt", "xhb", "uhb", 0, 16, 2, 2, 0, 0, 0, "flphbt", "invhbt", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "boot", "", "item_bootsmetal", 12, "item_bootsmetal", 0, 0, 5, 0, 0, 0, 0, 0, 6, 0, 39, 80, 120, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Demonhide Sash", 0, 0, 1, 1, 29, 34, 0, 0, 20, 0, 12, 0, 36, 24, 9304, 64486, "zlb", "zlb", -1, -1, "lbl", "lbl", "lbl", "zlb", "ulc", 0, 16, 2, 1, 0, 0, 0, "flplbl", "invlbl", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "belt", "", "item_lightarmor", 12, "item_lightarmor", 0, 0, 5, 0, 0, 6, 0, 0, 4, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Sharkskin Belt", 0, 0, 1, 1, 31, 36, 0, 0, 20, 0, 14, 0, 39, 25, 10700, 80809, "zvb", "zvb", -1, -1, "vbl", "vbl", "vbl", "zvb", "uvc", 0, 16, 2, 1, 0, 0, 0, "flpvbl", "invvbl", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "belt", "", "item_belt", 12, "item_belt", 0, 0, 5, 0, 0, 6, 0, 0, 4, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Mesh Belt", 0, 0, 2, 1, 35, 40, 0, 0, 58, 0, 16, 0, 43, 25, 13143, 108261, "zmb", "zmb", -1, -1, "mbl", "mbl", "mbl", "zmb", "umc", 0, 16, 2, 1, 0, 0, 0, "flpmbl", "invmbl", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "belt", "", "item_belt", 12, "item_belt", 0, 0, 5, 0, 0, 6, 0, 0, 4, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Battle Belt", 0, 0, 2, 1, 37, 42, 0, 0, 88, 0, 18, 0, 49, 25, 15713, 151185, "ztb", "ztb", -1, -1, "mbl", "mbl", "tbl", "ztb", "utc", 0, 16, 2, 1, 0, 0, 0, "flptbl", "invtbl", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "belt", "", "item_belt", 12, "item_belt", 0, 0, 5, 0, 0, 6, 0, 0, 4, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "War Belt", 0, 0, 3, 1, 41, 52, 0, 0, 110, 0, 24, 0, 54, 25, 20350, 218512, "zhb", "zhb", -1, -1, "hbl", "hbl", "hbl", "zhb", "uhc", 0, 16, 2, 1, 0, 0, 0, "flphbl", "invhbl", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "belt", "", "item_belt", 12, "item_belt", 0, 0, 5, 0, 0, 6, 0, 0, 4, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Grim Helm", 0, 0, 2, 1, 60, 125, 0, 0, 58, 0, 40, 0, 50, 25, 37683, 348947, "xh9", "xh9", -1, -1, "bhm", "bhm", "bhm", "xh9", "uh9", 0, 0, 2, 2, 1, 2, 1, "flpbhm", "invbhm", "invbhmu", "invbhmu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "helm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 2, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 7, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Grim Shield", 0, 0, 2, 1, 50, 150, 0, 0, 58, 20, 70, 0, 48, 25, 39143, 337523, "xsh", "xsh", -1, -1, "bsh", "bsh", "bsh", "xsh", "ush", 0, 7, 2, 3, 1, 2, 2, "flpbsh", "invbsh", "invxshu", "invxshu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "shie", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 0, 0, 0, 0, 1, 0, 14, 20, 100, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Barbed Shield", 0, 0, 3, 1, 58, 78, 0, 0, 65, 17, 55, 0, 42, 25, 23155, 172324, "xpk", "xpk", -1, -1, "spk", "spk", "spk", "xpk", "upk", 0, 7, 2, 3, 1, 2, 2, "flpspk", "invspk", "invxpku", "invxpku", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "shie", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 0, 0, 0, 0, 1, 0, 18, 35, 100, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Wolf Head", 100, 0, 1, 1, 8, 11, 0, 0, 16, 0, 20, 0, 4, 3, 364, 4868, "dr1", "dr1", -1, -1, "dr1", "dr1", "dr1", "dr6", "drb", 0, 0, 2, 2, 1, 3, 1, "flpdr1", "invdr1", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "pelt", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Hawk Helm", 100, 0, 1, 1, 4, 15, 0, 0, 20, 0, 20, 0, 8, 6, 664, 7840, "dr2", "dr2", -1, -1, "dr4", "dr4", "dr2", "dr7", "drc", 0, 0, 2, 2, 1, 3, 1, "flpdr4", "invdr2", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "pelt", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Antlers", 100, 0, 1, 1, 18, 24, 0, 0, 24, 0, 20, 0, 16, 12, 2832, 21852, "dr3", "dr3", -1, -1, "dr3", "dr3", "dr3", "dr8", "drd", 0, 0, 2, 2, 1, 3, 1, "flpdr3", "invdr3", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "pelt", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Falcon Mask", 100, 0, 1, 1, 12, 28, 0, 0, 28, 0, 20, 0, 20, 15, 3332, 29200, "dr4", "dr4", -1, -1, "dr4", "dr4", "dr4", "dr9", "dre", 0, 0, 2, 2, 1, 3, 1, "flpdr4", "invdr4", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "pelt", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Spirit Mask", 100, 0, 1, 1, 22, 35, 0, 0, 30, 0, 20, 0, 24, 18, 5670, 48550, "dr5", "dr5", -1, -1, "dr1", "dr1", "dr5", "dra", "drf", 0, 0, 2, 2, 1, 3, 1, "flpdr1", "invdr5", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "pelt", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Jawbone Cap", 100, 0, 2, 1, 10, 15, 0, 0, 25, 0, 25, 0, 4, 3, 320, 4750, "ba1", "ba1", -1, -1, "ba1", "dr1", "ba1", "ba6", "bab", 0, 0, 2, 2, 1, 3, 1, "flpba1", "invba1", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "phlm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Fanged Helm", 100, 0, 2, 1, 15, 20, 0, 0, 35, 0, 35, 0, 8, 6, 750, 8250, "ba2", "ba2", -1, -1, "ba1", "bhm", "ba2", "ba7", "bac", 0, 0, 2, 2, 1, 3, 1, "flpba1", "invba2", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "phlm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Horned Helm", 100, 0, 2, 1, 25, 30, 0, 0, 45, 0, 45, 0, 16, 12, 2750, 20750, "ba3", "ba3", -1, -1, "ba3", "bhm", "ba3", "ba8", "bad", 0, 0, 2, 2, 1, 3, 1, "flpba3", "invba3", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "phlm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Assault Helmet", 100, 0, 2, 1, 30, 35, 0, 0, 55, 0, 50, 0, 20, 15, 3420, 29360, "ba4", "ba4", -1, -1, "ba5", "bhm", "ba4", "ba9", "bae", 0, 0, 2, 2, 1, 3, 1, "flpba5", "invba4", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "phlm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Avenger Guard", 100, 0, 2, 1, 35, 50, 0, 0, 65, 0, 55, 0, 24, 18, 5785, 49280, "ba5", "ba5", -1, -1, "ba5", "bhm", "ba5", "baa", "baf", 0, 0, 2, 2, 1, 3, 1, "flpba5", "invba5", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "phlm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Targe", 100, 0, 2, 1, 8, 12, 0, 0, 16, 10, 20, 0, 4, 3, 384, 6317, "pa1", "pa1", -1, 304, "pa1", "spk", "pa1", "pa6", "pab", 0, 7, 2, 2, 1, 4, 2, "flppa1", "invpa1", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "ashd", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 1, 0, 0, 0, 1, 0, 2, 6, 100, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Rondache", 100, 0, 2, 1, 10, 18, 0, 0, 26, 15, 30, 0, 8, 6, 982, 10517, "pa2", "pa2", -1, 304, "pa1", "spk", "pa2", "pa7", "pac", 0, 7, 2, 2, 1, 4, 2, "flppa1", "invpa2", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "ashd", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 2, 0, 0, 0, 1, 0, 2, 8, 100, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Heraldic Shield", 100, 0, 2, 1, 16, 26, 0, 0, 40, 20, 40, 0, 16, 12, 2816, 21240, "pa3", "pa3", -1, 304, "pa3", "spk", "pa3", "pa8", "pad", 0, 7, 2, 4, 1, 4, 2, "flppa3", "invpa3", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "ashd", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 3, 0, 0, 0, 1, 0, 3, 9, 100, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Aerin Shield", 100, 0, 2, 1, 26, 36, 0, 0, 50, 22, 50, 0, 20, 15, 5158, 43557, "pa4", "pa4", -1, 304, "pa3", "spk", "pa4", "pa9", "pae", 0, 7, 2, 4, 1, 4, 2, "flppa3", "invpa4", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "ashd", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 4, 0, 0, 0, 1, 0, 4, 10, 100, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Crown Shield", 100, 0, 2, 1, 30, 40, 0, 0, 65, 25, 60, 0, 24, 18, 6935, 82075, "pa5", "pa5", -1, 304, "pa5", "spk", "pa5", "paa", "paf", 0, 7, 2, 2, 1, 4, 2, "flppa5", "invpa5", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "ashd", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 5, 0, 0, 0, 1, 0, 4, 12, 100, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Preserved Head", 100, 0, 1, 1, 2, 5, 0, 0, 12, 3, 20, 0, 4, 3, 128, 4628, "ne1", "ne1", -1, 305, "ne1", "dr1", "ne1", "ne6", "neb", 0, 10, 2, 2, 1, 2, 2, "flpne1", "invne1", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "head", "", "item_head", 12, "item_head", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, 1, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Zombie Head", 100, 0, 1, 1, 4, 8, 0, 0, 14, 5, 20, 0, 8, 6, 418, 7336, "ne2", "ne2", -1, 305, "ne2", "bhm", "ne2", "ne7", "neg", 0, 10, 2, 2, 1, 2, 2, "flpne2", "invne2", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "head", "", "item_head", 12, "item_head", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, 1, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Unraveller Head", 100, 0, 1, 1, 6, 10, 0, 0, 18, 8, 20, 0, 16, 12, 1070, 14780, "ne3", "ne3", -1, 305, "ne3", "bhm", "ne3", "ne8", "ned", 0, 10, 2, 2, 1, 2, 2, "flpne3", "invne3", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "head", "", "item_head", 12, "item_head", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, 1, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Gargoyle Head", 100, 0, 1, 1, 10, 16, 0, 0, 20, 10, 20, 0, 20, 15, 2164, 23320, "ne4", "ne4", -1, 305, "ne3", "bhm", "ne4", "ne9", "nee", 0, 10, 2, 2, 1, 2, 2, "flpne3", "invne4", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "head", "", "item_head", 12, "item_head", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, 1, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Demon Head", 100, 0, 1, 1, 15, 20, 0, 0, 25, 12, 20, 0, 24, 18, 3475, 35350, "ne5", "ne5", -1, 305, "ne2", "bhm", "ne5", "nea", "nef", 0, 10, 2, 2, 1, 2, 2, "flpne2", "invne5", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "head", "", "item_head", 12, "item_head", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Circlet", 100, 0, 1, 1, 20, 30, 0, 0, 0, 0, 35, 0, 24, 16, 12000, 85625, "ci0", "ci0", 3, -1, "lit", "lit", "ci0", "ci2", "ci3", 0, 0, 2, 2, 1, 2, 1, "flpci0", "invci0", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "circ", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Coronet", 100, 0, 1, 1, 30, 40, 0, 0, 0, 0, 30, 0, 52, 39, 23000, 171250, "ci1", "ci1", 8, -1, "lit", "lit", "ci1", "ci2", "ci3", 0, 0, 2, 2, 1, 2, 1, "flpci1", "invci1", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "circ", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 1, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Tiara", 100, 0, 1, 1, 40, 50, 0, 0, 0, 0, 25, 0, 70, 52, 35000, 700000, "ci2", "ci2", 13, -1, "lit", "lit", "ci1", "ci2", "ci3", 0, 0, 2, 2, 1, 3, 1, "flpci1", "invci2", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "circ", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 2, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Diadem", 100, 0, 1, 1, 50, 60, 0, 0, 0, 0, 20, 0, 85, 64, 58000, 1382500, "ci3", "ci3", 18, -1, "lit", "lit", "ci1", "ci2", "ci3", 0, 0, 2, 2, 1, 3, 1, "flpci2", "invci3", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "circ", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 3, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Shako", 100, 0, 1, 1, 98, 141, 0, 0, 50, 0, 12, 0, 58, 43, 56307, 503591, "uap", "uap", -1, -1, "cap", "cap", "cap", "xap", "uap", 0, 0, 2, 2, 1, 2, 1, "flpcap", "invcap", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "helm", "", "item_cap", 12, "item_cap", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Hydraskull", 100, 0, 4, 1, 101, 145, 0, 0, 84, 0, 18, 0, 63, 47, 62739, 568276, "ukp", "ukp", -1, -1, "skp", "skp", "skp", "xkp", "ukp", 0, 0, 2, 2, 1, 2, 1, "flpskp", "invskp", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "helm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Armet", 100, 0, 4, 1, 105, 149, 0, 0, 109, 0, 24, 0, 68, 51, 69940, 671703, "ulm", "ulm", -1, -1, "hlm", "hlm", "hlm", "xlm", "ulm", 0, 0, 2, 2, 1, 2, 1, "flphlm", "invhlm", "invhlmu", "invhlmu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "helm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Giant Conch", 100, 0, 4, 1, 110, 154, 0, 0, 142, 0, 30, 0, 54, 40, 57806, 757863, "uhl", "uhl", -1, -1, "fhl", "fhl", "fhl", "xhl", "uhl", 0, 0, 2, 2, 1, 2, 1, "flpfhl", "invfhl", "invfhlu", "invfhlu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "helm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Spired Helm", 100, 0, 4, 1, 114, 159, 0, 0, 192, 0, 40, 0, 79, 59, 87168, 920880, "uhm", "uhm", -1, -1, "ghm", "ghm", "ghm", "xhm", "uhm", 0, 0, 2, 2, 1, 3, 1, "flpghm", "invghm", "", "invuhms", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "helm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 7, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Corona", 100, 0, 4, 1, 111, 165, 0, 0, 174, 0, 50, 0, 85, 66, 94770, 1042170, "urn", "urn", -1, -1, "crn", "crn", "crn", "xrn", "urn", 0, 0, 2, 2, 1, 3, 1, "flpcrn", "invcrn", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "helm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Demonhead", 100, 0, 4, 1, 101, 154, 0, 0, 102, 0, 20, 0, 74, 55, 76578, 799703, "usk", "usk", -1, -1, "msk", "msk", "msk", "xsk", "usk", 0, 0, 2, 2, 1, 3, 1, "flpmsk", "invmsk", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "helm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Dusk Shroud", 100, 0, 1, 1, 361, 467, 0, 0, 77, 0, 20, 0, 65, 49, 218357, 1685148, "uui", "uui", -1, -1, "qlt", "qlt", "qui", "xui", "uui", 0, 1, 2, 3, 1, 4, 1, "flpqlt", "invqlt", "", "", 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, "tors", "", "item_lightarmor", 12, "item_lightarmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Wyrmhide", 100, 0, 2, 1, 364, 470, 0, 0, 84, 0, 24, 0, 67, 50, 226927, 1785276, "uea", "uea", -1, -1, "lea", "lea", "lea", "xea", "uea", 0, 1, 2, 3, 1, 4, 1, "flplea", "invlea", "", "", 0, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, "tors", "", "item_lightarmor", 12, "item_lightarmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Scarab Husk", 100, 0, 3, 1, 369, 474, 0, 0, 95, 0, 28, 0, 68, 51, 232573, 1891607, "ula", "ula", -1, -1, "hla", "hla", "hla", "xla", "ula", 0, 1, 2, 3, 1, 4, 1, "flphla", "invhla", "", "", 1, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, "tors", "", "item_lightarmor", 12, "item_lightarmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Wire Fleece", 100, 0, 4, 1, 375, 481, 0, 0, 111, 0, 32, 0, 70, 53, 243050, 2059887, "utu", "utu", -1, -1, "stu", "stu", "stu", "xtu", "utu", 0, 1, 2, 3, 1, 4, 1, "flpstu", "invstu", "", "", 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, "tors", "", "item_lightarmor", 12, "item_lightarmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Diamond Mail", 100, 0, 4, 1, 383, 489, 0, 5, 131, 0, 26, 0, 72, 54, 254435, 2243423, "ung", "ung", -1, -1, "rng", "rng", "rng", "xng", "ung", 0, 1, 2, 3, 1, 4, 1, "flprng", "invrng", "", "", 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, "tors", "", "item_chainarmor", 12, "item_chainarmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Loricated Mail", 100, 0, 4, 1, 390, 496, 0, 10, 149, 0, 36, 0, 73, 55, 262166, 2382039, "ucl", "ucl", -1, -1, "scl", "scl", "scl", "xcl", "ucl", 0, 1, 2, 3, 1, 4, 1, "flpscl", "invscl", "", "", 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, "tors", "", "item_chainarmor", 12, "item_chainarmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Boneweave", 100, 0, 4, 1, 399, 505, 0, 5, 158, 0, 45, 0, 62, 47, 227700, 2536340, "uhn", "uhn", -1, -1, "chn", "chn", "chn", "xhn", "uhn", 0, 1, 2, 3, 1, 4, 1, "flpchn", "invchn", "", "", 1, 1, 1, 1, 2, 2, 0, 0, 0, 0, 0, "tors", "", "item_chainarmor", 12, "item_chainarmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Great Hauberk", 100, 0, 4, 1, 395, 501, 1, 0, 118, 0, 50, 0, 75, 56, 272206, 2676189, "urs", "urs", -1, -1, "brs", "brs", "brs", "xrs", "urs", 0, 1, 2, 3, 1, 4, 1, "flpbrs", "invbrs", "", "", 0, 0, 2, 0, 2, 2, 0, 0, 0, 0, 0, "tors", "", "item_platearmor", 12, "item_platearmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Balrog Skin", 100, 0, 4, 1, 410, 517, 0, 5, 165, 0, 30, 0, 76, 57, 285351, 2882894, "upl", "upl", -1, -1, "spl", "spl", "spl", "xpl", "upl", 0, 1, 2, 3, 1, 4, 1, "flpspl", "invspl", "", "", 1, 1, 2, 1, 1, 1, 0, 0, 0, 0, 0, "tors", "", "item_platearmor", 12, "item_platearmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Hellforged Plate", 100, 0, 4, 1, 421, 530, 0, 10, 196, 0, 60, 0, 78, 59, 300130, 3197721, "ult", "ult", -1, -1, "plt", "plt", "plt", "xlt", "ult", 0, 1, 2, 3, 1, 4, 1, "flpplt", "invplt", "", "", 2, 2, 2, 2, 1, 1, 0, 0, 0, 0, 0, "tors", "", "item_platearmor", 12, "item_platearmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Kraken Shell", 100, 0, 4, 1, 417, 523, 2, 5, 174, 0, 48, 0, 81, 61, 308015, 3411990, "uld", "uld", -1, -1, "fld", "fld", "fld", "xld", "uld", 0, 1, 2, 3, 1, 4, 1, "flpfld", "invfld", "", "", 1, 1, 2, 2, 2, 2, 0, 0, 0, 0, 0, "tors", "", "item_platearmor", 12, "item_platearmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Lacquered Plate", 100, 0, 4, 1, 433, 541, 0, 5, 208, 0, 55, 0, 82, 62, 323094, 3803464, "uth", "uth", -1, -1, "gth", "gth", "gth", "xth", "uth", 0, 1, 2, 3, 1, 4, 1, "flpgth", "invgth", "", "", 2, 2, 1, 2, 2, 2, 0, 0, 0, 0, 0, "tors", "", "item_platearmor", 12, "item_platearmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Shadow Plate", 100, 0, 4, 1, 446, 557, 2, 10, 230, 0, 70, 0, 83, 64, 336644, 4274953, "uul", "uul", -1, -1, "ful", "ful", "ful", "xul", "uul", 0, 1, 2, 3, 1, 4, 1, "flpful", "invful", "", "", 2, 2, 2, 2, 2, 2, 0, 0, 0, 0, 0, "tors", "", "item_platearmor", 12, "item_platearmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Sacred Armor", 100, 0, 4, 1, 487, 600, 5, 5, 232, 0, 60, 0, 85, 66, 373558, 4872212, "uar", "uar", -1, -1, "aar", "aar", "aar", "xar", "uar", 0, 1, 2, 3, 1, 4, 1, "flpaar", "invaar", "invaaru", "invaaru", 1, 2, 2, 2, 2, 0, 0, 0, 0, 0, 0, "tors", "", "item_platearmor", 12, "item_platearmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Archon Plate", 100, 0, 4, 1, 410, 524, 1, 0, 103, 0, 60, 0, 84, 63, 317526, 3851372, "utp", "utp", -1, -1, "ltp", "ltp", "ltp", "xtp", "utp", 0, 1, 2, 3, 1, 4, 1, "flpltp", "invltp", "", "", 2, 0, 1, 1, 2, 2, 0, 0, 0, 0, 0, "tors", "", "item_platearmor", 12, "item_platearmor", 0, 0, 5, 0, 0, 0, 0, 0, 2, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 7, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Heater", 100, 0, 2, 1, 95, 110, 0, 0, 77, 22, 88, 0, 58, 43, 48303, 385227, "uuc", "uuc", -1, -1, "buc", "buc", "buc", "xuc", "uuc", 0, 7, 2, 2, 1, 2, 2, "flpbuc", "invbuc", "invbucu", "invbucu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "shie", "", "item_woodshield", 12, "item_woodshield", 0, 0, 5, 0, 0, 0, 0, 0, 1, 0, 16, 30, 100, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Luna", 100, 0, 3, 1, 108, 123, 0, 0, 100, 20, 84, 0, 61, 45, 57189, 436543, "uml", "uml", -1, -1, "buc", "buc", "sml", "xml", "uml", 0, 7, 2, 2, 1, 2, 2, "flpsml", "invsml", "invsmlu", "invsmlu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "shie", "", "item_woodshield", 12, "item_woodshield", 0, 0, 5, 0, 0, 0, 0, 0, 1, 0, 17, 29, 100, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 5, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Hyperion", 100, 0, 4, 1, 119, 135, 0, 5, 127, 24, 82, 0, 64, 48, 65914, 514278, "urg", "urg", -1, -1, "lrg", "lrg", "lrg", "xrg", "urg", 0, 7, 2, 3, 1, 3, 2, "flplrg", "invlrg", "invlrgu", "invlrgu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "shie", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 0, 0, 0, 0, 1, 0, 14, 32, 100, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 2, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Monarch", 100, 0, 4, 1, 133, 148, 0, 0, 156, 22, 86, 0, 72, 54, 81896, 576154, "uit", "uit", -1, -1, "kit", "kit", "kit", "xit", "uit", 0, 7, 2, 3, 1, 4, 2, "flpkit", "invkit", "invkitu", "invkitu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "shie", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 0, 0, 0, 0, 1, 0, 12, 34, 100, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 2, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Aegis", 100, 0, 4, 1, 145, 161, 1, 10, 219, 24, 92, 0, 79, 59, 97701, 693568, "uow", "uow", -1, -1, "tow", "tow", "tow", "xow", "uow", 0, 7, 2, 3, 1, 4, 2, "flptow", "invtow", "invtowu", "invtowu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "shie", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 0, 0, 0, 0, 1, 0, 18, 28, 100, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 2, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Ward", 100, 0, 4, 1, 153, 170, 0, 5, 185, 24, 100, 0, 84, 63, 109635, 856602, "uts", "uts", -1, -1, "kit", "kit", "gts", "xts", "uts", 0, 7, 2, 4, 1, 4, 2, "flpgts", "invgts", "invgtsu", "invutss", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "shie", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 0, 0, 0, 0, 1, 0, 11, 35, 100, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 2, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Bramble Mitts", 100, 0, 1, 1, 54, 62, 0, 0, 50, 0, 12, 0, 57, 42, 26920, 269938, "ulg", "ulg", -1, -1, "lgl", "lgl", "lgl", "xlg", "ulg", 0, 16, 2, 2, 0, 0, 0, "flplgl", "invlgl", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "glov", "", "item_gloves", 12, "item_gloves", 0, 0, 5, 0, 0, 0, 0, 0, 5, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Vampirebone Gloves", 100, 0, 1, 1, 56, 65, 0, 0, 50, 0, 14, 0, 63, 47, 30862, 306103, "uvg", "uvg", -1, -1, "vgl", "vgl", "vgl", "xvg", "uvg", 0, 16, 2, 2, 0, 0, 0, "flpvgl", "invvgl", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "glov", "", "item_gloves", 12, "item_gloves", 0, 0, 5, 0, 0, 0, 0, 0, 5, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Vambraces", 100, 0, 2, 1, 59, 67, 0, 0, 106, 0, 16, 0, 69, 51, 34964, 352152, "umg", "umg", -1, -1, "mgl", "mgl", "mgl", "xmg", "umg", 0, 16, 2, 2, 0, 0, 0, "flpmgl", "invmgl", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "glov", "", "item_gloveschain", 12, "item_gloveschain", 0, 0, 5, 0, 0, 0, 0, 0, 5, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Crusader Gauntlets", 100, 0, 3, 1, 59, 68, 0, 0, 151, 0, 18, 0, 76, 57, 39119, 420620, "utg", "utg", -1, -1, "mgl", "mgl", "tgl", "xtg", "utg", 0, 16, 2, 2, 0, 0, 0, "flptgl", "invtgl", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "glov", "", "item_glovesmetal", 12, "item_glovesmetal", 0, 0, 5, 0, 0, 0, 0, 0, 5, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Ogre Gauntlets", 100, 0, 4, 1, 62, 71, 0, 0, 185, 0, 24, 0, 85, 64, 45481, 498191, "uhg", "uhg", -1, -1, "hgl", "hgl", "hgl", "xhg", "uhg", 0, 16, 2, 2, 0, 0, 0, "flphgl", "invhgl", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "glov", "", "item_glovesmetal", 12, "item_glovesmetal", 0, 0, 5, 0, 0, 0, 0, 0, 5, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Wyrmhide Boots", 100, 0, 1, 1, 54, 62, 0, 0, 50, 0, 12, 0, 60, 45, 28315, 269938, "ulb", "ulb", -1, -1, "lbt", "lbt", "lbt", "xlb", "ulb", 0, 16, 2, 2, 0, 0, 0, "flplbt", "invlbt", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "boot", "", "item_boots", 12, "item_boots", 0, 0, 5, 0, 0, 0, 0, 0, 6, 0, 65, 100, 120, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Scarabshell Boots", 100, 0, 1, 1, 56, 65, 0, 0, 91, 0, 14, 0, 66, 49, 32271, 305620, "uvb", "uvb", -1, -1, "vbt", "vbt", "vbt", "xvb", "uvb", 0, 16, 2, 2, 0, 0, 0, "flpvbt", "invvbt", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "boot", "", "item_boots", 12, "item_boots", 0, 0, 5, 0, 0, 0, 0, 0, 6, 0, 60, 110, 120, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Boneweave Boots", 100, 0, 2, 1, 59, 67, 0, 0, 118, 0, 16, 0, 72, 54, 36456, 352010, "umb", "umb", -1, -1, "mbt", "mbt", "mbt", "xmb", "umb", 0, 16, 2, 2, 0, 0, 0, "flpmbt", "invmbt", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "boot", "", "item_bootschain", 12, "item_bootschain", 0, 0, 5, 0, 0, 0, 0, 0, 6, 0, 69, 118, 120, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Mirrored Boots", 100, 0, 3, 1, 59, 68, 0, 0, 163, 0, 18, 0, 81, 60, 41658, 420465, "utb", "utb", -1, -1, "mbt", "mbt", "tbt", "xtb", "utb", 0, 16, 2, 2, 0, 0, 0, "flptbt", "invtbt", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "boot", "", "item_bootsmetal", 12, "item_bootsmetal", 0, 0, 5, 0, 0, 0, 0, 0, 6, 0, 50, 145, 120, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Myrmidon Greaves", 100, 0, 4, 1, 62, 71, 0, 0, 208, 0, 24, 0, 85, 65, 45459, 497859, "uhb", "uhb", -1, -1, "hbt", "hbt", "hbt", "xhb", "uhb", 0, 16, 2, 2, 0, 0, 0, "flphbt", "invhbt", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "boot", "", "item_bootsmetal", 12, "item_bootsmetal", 0, 0, 5, 0, 0, 0, 0, 0, 6, 0, 83, 149, 120, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Spiderweb Sash", 100, 0, 1, 1, 55, 62, 0, 0, 50, 0, 12, 0, 61, 46, 28842, 270466, "ulc", "ulc", -1, -1, "lbl", "lbl", "lbl", "zlb", "ulc", 0, 16, 2, 1, 0, 0, 0, "flplbl", "invlbl", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "belt", "", "item_lightarmor", 12, "item_lightarmor", 0, 0, 5, 0, 0, 6, 0, 0, 4, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Vampirefang Belt", 100, 0, 1, 1, 56, 63, 0, 0, 50, 0, 14, 0, 68, 51, 32656, 300879, "uvc", "uvc", -1, -1, "vbl", "vbl", "vbl", "zvb", "uvc", 0, 16, 2, 1, 0, 0, 0, "flpvbl", "invvbl", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "belt", "", "item_belt", 12, "item_belt", 0, 0, 5, 0, 0, 6, 0, 0, 4, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Mithril Coil", 100, 0, 2, 1, 58, 65, 0, 0, 106, 0, 16, 0, 75, 56, 37134, 345000, "umc", "umc", -1, -1, "mbl", "mbl", "mbl", "zmb", "umc", 0, 16, 2, 1, 0, 0, 0, "flpmbl", "invmbl", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "belt", "", "item_belt", 12, "item_belt", 0, 0, 5, 0, 0, 6, 0, 0, 4, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Troll Belt", 100, 0, 2, 1, 59, 66, 0, 0, 151, 0, 18, 0, 82, 62, 41183, 411380, "utc", "utc", -1, -1, "mbl", "mbl", "tbl", "ztb", "utc", 0, 16, 2, 1, 0, 0, 0, "flptbl", "invtbl", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "belt", "", "item_belt", 12, "item_belt", 0, 0, 5, 0, 0, 6, 0, 0, 4, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Colossus Girdle", 100, 0, 3, 1, 61, 71, 0, 0, 185, 0, 24, 0, 85, 67, 45051, 493775, "uhc", "uhc", -1, -1, "hbl", "hbl", "hbl", "zhb", "uhc", 0, 16, 2, 1, 0, 0, 0, "flphbl", "invhbl", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "belt", "", "item_belt", 12, "item_belt", 0, 0, 5, 0, 0, 6, 0, 0, 4, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Bone Visage", 100, 0, 2, 1, 100, 157, 0, 0, 106, 0, 40, 0, 84, 63, 87274, 598161, "uh9", "uh9", -1, -1, "bhm", "bhm", "bhm", "xh9", "uh9", 0, 0, 2, 2, 1, 3, 1, "flpbhm", "invbhm", "invbhmu", "invbhmu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "helm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 2, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 7, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Troll Nest", 100, 0, 2, 1, 158, 173, 0, 0, 106, 20, 74, 0, 76, 57, 101842, 586580, "ush", "ush", -1, -1, "bsh", "bsh", "bsh", "xsh", "ush", 0, 7, 2, 3, 1, 3, 2, "flpbsh", "invbsh", "invbshu", "invbshu", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "shie", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 0, 0, 0, 0, 1, 0, 24, 38, 100, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Blade Barrier", 100, 0, 3, 1, 147, 163, 0, 0, 118, 20, 83, 0, 68, 51, 85443, 413914, "upk", "upk", -1, -1, "spk", "spk", "spk", "xpk", "upk", 0, 7, 2, 3, 1, 3, 2, "flpspk", "invspk", "invspku", "invspku", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "shie", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 0, 0, 0, 0, 1, 0, 26, 40, 100, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Alpha Helm", 100, 0, 1, 1, 52, 62, 0, 0, 44, 0, 20, 0, 35, 26, 16300, 82061, "dr6", "dr6", -1, -1, "dr1", "dr1", "dr1", "dr6", "drb", 0, 0, 2, 2, 1, 3, 1, "flpdr1", "invdr1", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "pelt", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Griffon Headress", 100, 0, 1, 1, 46, 68, 0, 0, 50, 0, 20, 0, 40, 30, 18564, 82062, "dr7", "dr7", -1, -1, "dr4", "dr4", "dr2", "dr7", "drc", 0, 0, 2, 2, 1, 3, 1, "flpdr4", "invdr2", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "pelt", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Hunter's Guise", 100, 0, 1, 1, 67, 81, 0, 0, 56, 0, 20, 0, 46, 29, 27768, 82063, "dr8", "dr8", -1, -1, "dr3", "dr3", "dr3", "dr8", "drd", 0, 0, 2, 2, 1, 3, 1, "flpdr3", "invdr3", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "pelt", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Sacred Feathers", 100, 0, 1, 1, 58, 87, 0, 0, 62, 0, 20, 0, 50, 32, 29518, 82064, "dr9", "dr9", -1, -1, "dr4", "dr4", "dr4", "dr9", "dre", 0, 0, 2, 2, 1, 3, 1, "flpdr4", "invdr4", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "pelt", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Totemic Mask", 100, 0, 1, 1, 73, 98, 0, 0, 65, 0, 20, 0, 55, 41, 38127, 82065, "dra", "dra", -1, -1, "dr1", "dr1", "dr5", "dra", "drf", 0, 0, 2, 2, 1, 3, 1, "flpdr1", "invdr5", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "pelt", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Jawbone Visor", 100, 0, 2, 1, 55, 68, 0, 0, 58, 0, 25, 0, 33, 25, 16603, 82061, "ba6", "ba6", -1, -1, "ba1", "dr1", "ba1", "ba6", "bab", 0, 0, 2, 2, 1, 3, 1, "flpba1", "invba1", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "phlm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, 5, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Lion Helm", 100, 0, 2, 1, 63, 75, 0, 0, 73, 0, 35, 0, 38, 29, 21378, 82062, "ba7", "ba7", -1, -1, "ba1", "bhm", "ba2", "ba7", "bac", 0, 0, 2, 2, 1, 3, 1, "flpba1", "invba2", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "phlm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, 5, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Rage Mask", 100, 0, 2, 1, 78, 90, 0, 0, 88, 0, 45, 0, 44, 29, 30063, 82063, "ba8", "ba8", -1, -1, "ba3", "bhm", "ba3", "ba8", "bad", 0, 0, 2, 2, 1, 3, 1, "flpba3", "invba3", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "phlm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Savage Helmet", 100, 0, 2, 1, 85, 98, 0, 0, 103, 0, 50, 0, 49, 32, 36398, 82064, "ba9", "ba9", -1, -1, "ba5", "bhm", "ba4", "ba9", "bae", 0, 0, 2, 2, 1, 3, 1, "flpba5", "invba4", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "phlm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Slayer Guard", 100, 0, 2, 1, 93, 120, 0, 0, 118, 0, 55, 0, 54, 40, 46633, 82065, "baa", "baa", -1, -1, "ba5", "bhm", "ba5", "baa", "baf", 0, 0, 2, 2, 1, 3, 1, "flpba5", "invba5", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "phlm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Akaran Targe", 100, 0, 2, 1, 101, 125, 0, 0, 44, 10, 20, 0, 35, 26, 32500, 82065, "pa6", "pa6", -1, 304, "pa1", "spk", "pa1", "pa6", "pab", 0, 7, 2, 2, 1, 4, 2, "flppa1", "invpa1", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "ashd", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 1, 0, 0, 0, 1, 0, 12, 16, 100, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, 0, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Akaran Rondache", 100, 0, 2, 1, 113, 137, 0, 0, 59, 15, 30, 0, 40, 30, 40941, 82066, "pa7", "pa7", -1, 304, "pa1", "spk", "pa2", "pa7", "pac", 0, 7, 2, 2, 1, 4, 2, "flppa1", "invpa2", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "ashd", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 2, 0, 0, 0, 1, 0, 15, 20, 100, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, 0, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Protector Shield", 100, 0, 2, 1, 129, 153, 0, 0, 69, 20, 40, 0, 46, 34, 52947, 82067, "pa8", "pa8", -1, 304, "pa3", "spk", "pa3", "pa8", "pad", 0, 7, 2, 4, 1, 4, 2, "flppa3", "invpa3", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "ashd", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 3, 0, 0, 0, 1, 0, 18, 24, 100, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Guilded Shield", 100, 0, 2, 1, 144, 168, 0, 0, 89, 22, 50, 0, 51, 38, 64807, 82068, "pa9", "pa9", -1, 304, "pa3", "spk", "pa4", "pa9", "pae", 0, 7, 2, 4, 1, 4, 2, "flppa3", "invpa4", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "ashd", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 4, 0, 0, 0, 1, 0, 20, 28, 100, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Royal Shield", 100, 0, 2, 1, 156, 181, 0, 0, 114, 25, 60, 0, 55, 41, 75374, 82069, "paa", "paa", -1, 304, "pa5", "spk", "pa5", "paa", "paf", 0, 7, 2, 2, 1, 4, 2, "flppa5", "invpa5", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "ashd", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 5, 0, 0, 0, 1, 0, 24, 32, 100, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Mummified Trophy", 100, 0, 1, 1, 38, 48, 0, 0, 38, 3, 20, 0, 33, 24, 11590, 82069, "ne6", "ne6", -1, 305, "ne1", "dr1", "ne1", "ne6", "neb", 0, 10, 2, 2, 1, 2, 2, "flpne1", "invne1", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "head", "", "item_head", 12, "item_head", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, 1, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Fetish Trophy", 100, 0, 1, 1, 41, 52, 0, 0, 41, 5, 20, 0, 39, 29, 14839, 82070, "ne7", "ne7", -1, 305, "ne2", "bhm", "ne2", "ne7", "neg", 0, 10, 2, 2, 1, 2, 2, "flpne2", "invne2", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "head", "", "item_head", 12, "item_head", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, 1, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Sexton Trophy", 100, 0, 1, 1, 44, 55, 0, 0, 47, 8, 20, 0, 45, 33, 18169, 82071, "ne8", "ne8", -1, 305, "ne3", "bhm", "ne3", "ne8", "ned", 0, 10, 2, 2, 1, 2, 2, "flpne3", "invne3", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "head", "", "item_head", 12, "item_head", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Cantor Trophy", 100, 0, 1, 1, 50, 64, 0, 0, 50, 10, 20, 0, 49, 36, 22750, 82072, "ne9", "ne9", -1, 305, "ne3", "bhm", "ne4", "ne9", "nee", 0, 10, 2, 2, 1, 2, 2, "flpne3", "invne4", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "head", "", "item_head", 12, "item_head", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Heirophant Trophy", 100, 0, 1, 1, 58, 70, 0, 0, 58, 12, 20, 0, 54, 40, 27993, 82073, "nea", "nea", -1, 305, "ne2", "bhm", "ne5", "nea", "nef", 0, 10, 2, 2, 1, 2, 2, "flpne2", "invne5", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "head", "", "item_head", 12, "item_head", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Blood Spirt", 100, 0, 1, 1, 101, 145, 0, 0, 86, 0, 20, 0, 62, 46, 61755, 413914, "drb", "drb", -1, -1, "dr1", "dr1", "dr1", "dr6", "drb", 0, 0, 2, 2, 1, 3, 1, "flpdr1", "invdr1", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "pelt", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Sun Spirit", 100, 0, 1, 1, 98, 147, 0, 0, 95, 0, 20, 0, 69, 51, 68617, 413915, "drc", "drc", -1, -1, "dr4", "dr4", "dr2", "dr7", "drc", 0, 0, 2, 2, 1, 3, 1, "flpdr4", "invdr2", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "pelt", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Earth Spirit", 100, 0, 1, 1, 107, 152, 0, 0, 104, 0, 20, 0, 76, 57, 79730, 413916, "drd", "drd", -1, -1, "dr3", "dr3", "dr3", "dr8", "drd", 0, 0, 2, 2, 1, 3, 1, "flpdr3", "invdr3", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "pelt", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Sky Spirit", 100, 0, 1, 1, 103, 155, 0, 0, 113, 0, 20, 0, 83, 62, 86575, 413917, "dre", "dre", -1, -1, "dr4", "dr4", "dr4", "dr9", "dre", 0, 0, 2, 2, 1, 3, 1, "flpdr4", "invdr4", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "pelt", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Dream Spirit", 100, 0, 1, 1, 109, 159, 0, 0, 118, 0, 20, 0, 85, 66, 92143, 413918, "drf", "drf", -1, -1, "dr1", "dr1", "dr5", "dra", "drf", 0, 0, 2, 2, 1, 3, 1, "flpdr1", "invdr5", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "pelt", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 8, 8, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Carnage Helm", 100, 0, 2, 1, 102, 147, 0, 0, 106, 0, 25, 0, 60, 45, 60650, 413918, "bab", "bab", -1, -1, "ba1", "dr1", "ba1", "ba6", "bab", 0, 0, 2, 2, 1, 3, 1, "flpba1", "invba1", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "phlm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Fury Visor", 100, 0, 2, 1, 105, 150, 0, 0, 129, 0, 35, 0, 66, 49, 68211, 413919, "bac", "bac", -1, -1, "ba1", "bhm", "ba2", "ba7", "bac", 0, 0, 2, 2, 1, 3, 1, "flpba1", "invba2", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "phlm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Destroyer Helm", 100, 0, 2, 1, 111, 156, 0, 0, 151, 0, 45, 0, 73, 54, 78881, 413920, "bad", "bad", -1, -1, "ba3", "bhm", "ba3", "ba8", "bad", 0, 0, 2, 2, 1, 3, 1, "flpba3", "invba3", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "phlm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Conquerer Crown", 100, 0, 2, 1, 114, 159, 0, 0, 174, 0, 50, 0, 80, 60, 88278, 413921, "bae", "bae", -1, -1, "ba5", "bhm", "ba4", "ba9", "bae", 0, 0, 2, 2, 1, 3, 1, "flpba5", "invba4", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "phlm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Guardian Crown", 100, 0, 2, 1, 117, 168, 0, 0, 196, 0, 55, 0, 85, 65, 97844, 413922, "baf", "baf", -1, -1, "ba5", "bhm", "ba5", "baa", "baf", 0, 0, 2, 2, 1, 3, 1, "flpba5", "invba5", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "phlm", "", "item_helm", 12, "item_helm", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Sacred Targe", 100, 0, 2, 1, 126, 158, 0, 0, 86, 30, 45, 0, 63, 47, 72618, 82065, "pab", "pab", -1, 304, "pa1", "spk", "pa1", "pa6", "pab", 0, 7, 2, 2, 1, 4, 2, "flppa1", "invpa1", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "ashd", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 1, 0, 0, 0, 1, 0, 22, 70, 100, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Sacred Rondache", 100, 0, 2, 1, 138, 164, 0, 0, 109, 28, 68, 0, 70, 52, 85659, 82066, "pac", "pac", -1, 304, "pa1", "spk", "pa2", "pa7", "pac", 0, 7, 2, 2, 1, 4, 2, "flppa1", "invpa2", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "ashd", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 2, 0, 0, 0, 1, 0, 35, 58, 100, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Kurast Shield", 100, 0, 2, 1, 154, 172, 0, 0, 124, 25, 55, 0, 74, 55, 97676, 82067, "pad", "pad", -1, 304, "pa3", "spk", "pa3", "pa8", "pad", 0, 7, 2, 4, 1, 4, 2, "flppa3", "invpa3", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "ashd", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 3, 0, 0, 0, 1, 0, 10, 82, 100, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Zakarum Shield", 100, 0, 2, 1, 169, 193, 0, 0, 142, 22, 65, 0, 82, 61, 120042, 82068, "pae", "pae", -1, 304, "pa3", "spk", "pa4", "pa9", "pae", 0, 7, 2, 4, 1, 4, 2, "flppa3", "invpa4", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "ashd", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 4, 0, 0, 0, 1, 0, 46, 46, 100, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Vortex Shield", 100, 0, 2, 1, 182, 225, 0, 0, 148, 19, 90, 0, 85, 66, 139860, 82069, "paf", "paf", -1, 304, "pa5", "spk", "pa5", "paa", "paf", 0, 7, 2, 2, 1, 4, 2, "flppa5", "invpa5", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "ashd", "", "item_metalshield", 12, "item_metalshield", 0, 0, 5, 0, 5, 0, 0, 0, 1, 0, 5, 87, 100, -1, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Minion Skull", 100, 0, 1, 1, 95, 139, 0, 0, 77, 3, 20, 0, 59, 44, 56131, 82069, "neb", "neb", -1, 305, "ne1", "dr1", "ne1", "ne6", "neb", 0, 10, 2, 2, 1, 2, 2, "flpne1", "invne1", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "head", "", "item_head", 12, "item_head", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Hellspawn Skull", 100, 0, 1, 1, 96, 141, 0, 0, 82, 5, 20, 0, 67, 50, 64437, 82070, "neg", "neg", -1, 305, "ne2", "bhm", "ne2", "ne7", "neg", 0, 10, 2, 2, 1, 2, 2, "flpne2", "invne2", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "head", "", "item_head", 12, "item_head", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Overseer Skull", 100, 0, 1, 1, 98, 142, 0, 0, 91, 8, 20, 0, 66, 49, 64122, 82071, "ned", "ned", -1, 305, "ne3", "bhm", "ne3", "ne8", "ned", 0, 10, 2, 2, 1, 2, 2, "flpne3", "invne3", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "head", "", "item_head", 12, "item_head", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Succubae Skull", 100, 0, 1, 1, 100, 146, 0, 0, 95, 10, 20, 0, 81, 60, 80462, 82072, "nee", "nee", -1, 305, "ne3", "bhm", "ne4", "ne9", "nee", 0, 10, 2, 2, 1, 2, 2, "flpne3", "invne4", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "head", "", "item_head", 12, "item_head", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseArmor(BaseItem.ItemCount++, "Bloodlord Skull", 100, 0, 1, 1, 103, 148, 0, 0, 106, 12, 20, 0, 85, 65, 86238, 82073, "nef", "nef", -1, 305, "ne2", "bhm", "ne5", "nea", "nef", 0, 10, 2, 2, 1, 2, 2, "flpne2", "invne5", "", "", -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, "head", "", "item_head", 12, "item_head", 0, 0, 5, 0, 0, 0, 0, 0, 3, 0, 0, 0, -1, -1, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 0, 0, "xxx", "xxx", 0, 0, 1),
			new BaseWeapon(BaseItem.ItemCount++, "Hand Axe", "axe", "", "hax", "hax", "hax", 0, -1, 3, 1, 3, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, 100, -1, -1, -1, 28, -1, 3, 0, 170, 4510, -1, -1, "hax", "hax", "9ha", "7ha", "1hs", "1hs", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flphax", "invhax", "invhaxu", "invhaxu", 1, 2, 0, "", 0, "item_smallmetalweapon", 12, "item_smallmetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 35, 7, 0, 0, 3, -1, 1, -1, 1, 1, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "axe", "2ax", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Axe", "axe", "", "axe", "axe", "axe", 0, -1, 4, 1, 4, 11, -1, -1, -1, -1, -1, -1, -1, 1, 10, 100, -1, 32, -1, 24, -1, 7, 0, 403, 8821, -1, -1, "axe", "axe", "9ax", "7ax", "1hs", "1hs", 5, "1hsl", 2, 3, -1, -1, -1, -1, "flpaxe", "invaxe", "invaxeu", "invaxeu", 1, 4, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "2ax", "mpi", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Double Axe", "axe", "", "2ax", "axe", "2ax", 0, -1, 4, 1, 5, 13, -1, -1, -1, -1, -1, -1, -1, 1, 10, 100, -1, 43, -1, 24, -1, 13, 0, 873, 20349, -1, -1, "axe", "2ax", "92a", "72a", "1hs", "1hs", 5, "1hsl", 2, 3, -1, -1, -1, -1, "flp2ax", "inv2ax", "", "", 1, 5, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, 1, 1, 30, -1, -1, -1, -1, 255, 1, 1, -1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "mpi", "wax", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Military Pick", "axe", "", "mpi", "axe", "mpi", 0, -1, 4, 1, 7, 11, -1, -1, -1, -1, -1, -1, -1, 1, -10, 100, -1, 49, 33, 26, -1, 19, 0, 1421, 38999, -1, -1, "axe", "mpi", "9mp", "7mp", "1hs", "1hs", 5, "1hsl", 2, 3, -1, -1, -1, -1, "flpmpi", "invmpi", "invmpiu", "invmpiu", 1, 6, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 1, -1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "wax", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "War Axe", "axe", "", "wax", "hax", "wax", 0, -1, 4, 1, 10, 18, -1, -1, -1, -1, -1, -1, -1, 2, -1, 100, -1, 67, -1, 26, -1, 25, 0, 2123, 68075, -1, -1, "hax", "wax", "9wa", "7wa", "1hs", "1hs", 5, "1hsl", 2, 3, -1, -1, -1, -1, "flpwax", "invwax", "", "", 1, 6, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 3, 20, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Large Axe", "axe", "", "lax", "lax", "lax", 0, -1, 4, 1, -1, -1, -1, 1, 6, 13, -1, -1, -1, 1, -10, 100, -1, 35, -1, 30, -1, 6, 0, 354, 7624, -1, -1, "lax", "lax", "9la", "7la", "stf", "stf", 5, "2hsl", 2, 3, -1, -1, -1, -1, "flplax", "invlax", "", "", 1, 4, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "btx", "gax", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Broad Axe ", "axe", "", "bax", "lax", "bax", 0, -1, 4, 1, -1, -1, -1, 1, 10, 18, -1, -1, -1, 1, -1, 100, -1, 48, -1, 35, -1, 12, 0, 806, 18172, -1, -1, "lax", "bax", "9ba", "7ba", "stf", "stf", 5, "2hsl", 2, 3, -1, -1, -1, -1, "flpbrx", "invbrx", "", "", 1, 5, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "gax", "gix", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Battle Axe", "axe", "", "btx", "btx", "btx", 0, -1, 4, 1, -1, -1, -1, 1, 12, 32, -1, -1, -1, 1, 10, 100, -1, 54, -1, 40, -1, 17, 0, 1262, 32454, -1, -1, "lax", "btx", "9bt", "7bt", "stf", "stf", 5, "2hsl", 2, 3, -1, -1, -1, -1, "flpbtx", "invbtx", "invbtxu", "invbtxu", 1, 5, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 2, 0, "gix", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Great Axe", "axe", "", "gax", "btx", "gax", 0, -1, 4, 1, -1, -1, -1, 1, 9, 30, -1, -1, -1, 2, -10, 100, -1, 63, 39, 50, -1, 23, 0, 1916, 58068, -1, -1, "lax", "gax", "9ga", "7ga", "stf", "stf", 5, "2hsl", 2, 4, -1, -1, -1, -1, "flpgax", "invgax", "invgaxu", "invgaxu", 1, 6, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Giant Axe", "axe", "", "gix", "gix", "gix", 0, -1, 4, 1, -1, -1, -1, 1, 22, 45, -1, -1, -1, 3, 10, 100, -1, 70, -1, 50, -1, 27, 0, 2410, 81070, -1, -1, "lax", "gix", "9gi", "7gi", "stf", "stf", 5, "2hsl", 2, 3, -1, -1, -1, -1, "flpgix", "invgix", "", "", 1, 6, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 2, 2, 20, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Wand", "wand", "", "wnd", "wnd", "wnd", 0, -1, 1, 1, 2, 4, -1, -1, -1, -1, -1, -1, -1, -1, -1, 100, -1, -1, -1, 15, -1, 2, 0, 205, 3910, 1, -1, "wnd", "wnd", "9wn", "7wn", "1hs", "1hs", 5, "1hss", 1, 2, -1, -1, -1, -1, "flpwnd", "invwnd", "invwndu", "invwndu", 1, 1, 0, "magically charged", 0, "item_wand", 12, "item_wand", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 4, 6, 7, 9, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "ywn", "bwn", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Yew Wand", "wand", "", "ywn", "ywn", "ywn", 0, -1, 1, 1, 2, 8, -1, -1, -1, -1, -1, -1, -1, -1, 10, 100, -1, -1, -1, 15, -1, 12, 0, 745, 17440, 1, -1, "wnd", "ywn", "9yw", "7yw", "1hs", "1hs", 5, "1hss", 1, 2, -1, -1, -1, -1, "flpywn", "invywn", "", "", 1, 1, 0, "magically charged", 0, "item_wand", 12, "item_wand", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 2, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 3, 5, 5, 9, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 2, 3, 2, 3, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "bwn", "gwn", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Bone Wand", "wand", "", "bwn", "bwn", "bwn", 0, -1, 1, 1, 3, 7, -1, -1, -1, -1, -1, -1, -1, -1, -20, 100, -1, -1, -1, 15, -1, 18, 0, 1296, 34828, 1, -1, "wnd", "bwn", "9bw", "7bw", "1hs", "1hs", 5, "1hss", 1, 2, -1, -1, -1, -1, "flpbwn", "invbwn", "invbwnu", "invbwnu", 1, 2, 0, "magically charged", 0, "item_wand", 12, "item_wand", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 3, 1, 3, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 3, 5, 5, 7, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, 3, 4, 2, 3, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 3, 4, 2, 3, 20, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Grim Wand", "wand", "", "gwn", "bwn", "gwn", 0, -1, 1, 1, 5, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, 100, -1, -1, -1, 15, -1, 26, 0, 2098, 70048, 1, -1, "wnd", "gwn", "9gw", "7gw", "1hs", "1hs", 5, "1hss", 1, 2, -1, -1, -1, -1, "flpgwn", "invgwn", "", "", 1, 2, 0, "magically charged", 0, "item_wand", 12, "item_wand", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, -1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 2, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, 1, 3, 1, 2, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 3, 1, 2, 20, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Club", "club", "", "clb", "clb", "clb", 0, -1, 1, 1, 1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -10, 100, -1, -1, -1, 24, -1, 1, 0, 32, 3032, -1, -1, "clb", "clb", "9cl", "7cl", "1hs", "1hs", 5, "club", 1, 3, -1, -1, -1, -1, "flpclb", "invclb", "invclbu", "invclbu", 1, 2, 0, "", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 2, 0, "mac", "mst", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Scepter", "scep", "", "scp", "mac", "scp", 0, -1, 2, 1, 6, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, 100, -1, 25, -1, 50, -1, 3, 0, 350, 5050, -1, -1, "mac", "scp", "9sc", "7sc", "1hs", "1hs", 5, "club", 1, 3, -1, -1, -1, -1, "flpscp", "invscp", "", "", 1, 2, 0, "magically charged", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 2, 4, 2, 4, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 2, 3, 3, 5, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, 2, 2, 0, "gsc", "wsp", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Grand Scepter", "scep", "", "gsc", "mac", "gsc", 0, -1, 4, 1, 8, 18, -1, -1, -1, -1, -1, -1, -1, 1, 10, 100, -1, 37, -1, 60, -1, 15, 0, 1109, 26635, -1, -1, "mac", "gsc", "9qs", "7qs", "1hs", "1hs", 5, "club", 1, 3, -1, -1, -1, -1, "flpgsc", "invgsc", "", "", 1, 3, 0, "magically charged", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 3, 1, 3, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 3, 5, 3, 5, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, 1, 2, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 2, 3, 1, 2, 20, -1, -1, 2, 2, 0, "xxx", "wsp", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "War Scepter", "scep", "", "wsp", "whm", "wsp", 0, -1, 4, 1, 10, 17, -1, -1, -1, -1, -1, -1, -1, 1, -10, 100, -1, 55, -1, 70, -1, 21, 0, 2323, 61783, -1, -1, "mac", "wsp", "9ws", "7ws", "1hs", "1hs", 5, "club", 2, 3, -1, -1, -1, -1, "flpwsp", "invwsp", "", "", 1, 5, 0, "magically charged", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 3, 1, 3, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, 1, 2, 1, 2, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 2, 1, 1, 20, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Spiked Club", "club", "", "spc", "clb", "spc", 0, -1, 3, 1, 5, 8, -1, -1, -1, -1, -1, -1, -1, 1, -1, 100, -1, -1, -1, 36, -1, 4, 0, 225, 5400, -1, -1, "clb", "spc", "9sp", "7sp", "1hs", "1hs", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpspc", "invspc", "invspcu", "invspcu", 1, 2, 0, "", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, 1, -1, 1, 1, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "mac", "mst", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Mace", "mace", "", "mac", "mac", "mac", 0, -1, 4, 1, 3, 10, -1, -1, -1, -1, -1, -1, -1, -1, -1, 100, -1, 27, -1, 60, -1, 8, 0, 463, 10204, -1, -1, "mac", "mac", "9ma", "7ma", "1hs", "1hs", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpmac", "invmac", "", "", 1, 2, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, 1, -1, 1, 1, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, 1, -1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 2, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "mst", "mau", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Morning Star", "mace", "", "mst", "mac", "mst", 0, -1, 4, 1, 7, 16, -1, -1, -1, -1, -1, -1, -1, 1, 10, 100, -1, 36, -1, 72, -1, 13, 0, 844, 19972, -1, -1, "mac", "mst", "9mt", "7mt", "1hs", "1hs", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpmst", "invmst", "invmstu", "invmstu", 1, 3, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "fla", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Flail", "mace", "", "fla", "fla", "fla", 0, -1, 4, 1, 1, 24, -1, -1, -1, -1, -1, -1, -1, 2, -10, 100, -1, 41, 35, 30, -1, 19, 0, 1412, 38828, -1, -1, "mac", "fla", "9fl", "7fl", "1hs", "1hs", 5, "1hsl", 2, 3, -1, -1, -1, -1, "flpfla", "invfla", "", "", 1, 5, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "gma", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "War Hammer", "hamm", "", "whm", "whm", "whm", 0, -1, 4, 1, 19, 29, -1, -1, -1, -1, -1, -1, -1, -1, 20, 110, -1, 53, -1, 55, -1, 25, 0, 2081, 67025, -1, -1, "mac", "whm", "9wh", "7wh", "1hs", "1hs", 5, "1hsl", 2, 3, -1, -1, -1, -1, "flpwhm", "invwhm", "", "", 1, 4, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 178, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "mau", "gma", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Maul", "hamm", "", "mau", "mau", "mau", 0, -1, 4, 1, -1, -1, -1, 1, 30, 43, -1, -1, -1, 1, 10, 110, -1, 69, -1, 60, -1, 21, 0, 1670, 48070, -1, -1, "mau", "mau", "9m9", "7m7", "stf", "stf", 5, "2hsl", 2, 4, -1, -1, -1, -1, "flpmau", "invmau", "invmauu", "invmauu", 1, 6, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "mau", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Great Maul", "hamm", "", "gma", "mau", "gma", 0, -1, 3, 1, -1, -1, -1, 1, 38, 58, -1, -1, -1, 2, 20, 110, -1, 99, -1, 60, -1, 32, 0, 3215, 121380, -1, -1, "mau", "gma", "9gm", "7gm", "stf", "stf", 5, "2hsl", 2, 3, -1, -1, -1, -1, "flpgma", "invgma", "invgma", "invgma", 1, 6, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Short Sword", "swor", "", "ssd", "ssd", "ssd", 0, -1, 3, 1, 2, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, 100, -1, -1, -1, 24, -1, 1, 0, 72, 3072, -1, -1, "ssd", "ssd", "9ss", "7ss", "1hs", "1hs", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpssd", "invssd", "", "", 1, 2, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, 1, 1, -1, 1, 1, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "scm", "wsd", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Scimitar", "swor", "", "scm", "scm", "scm", 0, -1, 3, 1, 2, 6, -1, -1, -1, -1, -1, -1, -1, -1, -20, 100, -1, -1, 21, 22, -1, 5, 0, 274, 6370, -1, -1, "scm", "scm", "9sm", "7sm", "1hs", "1hs", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpscm", "invscm", "invscmu", "invscmu", 1, 2, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, 1, -1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "sbr", "lsd", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Saber", "swor", "", "sbr", "scm", "sbr", 0, -1, 3, 1, 3, 8, -1, -1, -1, -1, -1, -1, -1, -1, -10, 100, -1, 25, 25, 32, -1, 8, 0, 466, 10228, -1, -1, "scm", "sbr", "9sb", "7sb", "1hs", "1hs", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpsbr", "invsbr", "inv9sbu", "inv9sbu", 1, 2, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, 1, 1, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 1, -1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "flc", "bsd", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Falchion", "swor", "", "flc", "flc", "flc", 0, -1, 4, 1, 9, 17, -1, -1, -1, -1, -1, -1, -1, -1, 20, 100, -1, 33, -1, 32, -1, 11, 0, 683, 15513, -1, -1, "scm", "flc", "9fc", "7fc", "1hs", "1hs", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpflc", "invflc", "invflcu", "invflcu", 1, 2, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "bsd", "wsd", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Crystal Sword", "swor", "", "crs", "crs", "crs", 0, -1, 2, 1, 5, 15, -1, -1, -1, -1, -1, -1, -1, 1, -1, 100, -1, 43, -1, 20, -1, 11, 0, 2127, 31397, -1, -1, "ssd", "crs", "9cr", "7cr", "1hs", "1hs", 5, "1hsl", 2, 3, -1, -1, -1, -1, "flpcrs", "invcrs", "invcrsu", "invcrsu", 1, 6, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 5, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 1, 20, -1, -1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Broad Sword", "swor", "", "bsd", "bsd", "bsd", 0, -1, 4, 1, 7, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, 100, -1, 48, -1, 32, -1, 15, 0, 1029, 25435, -1, -1, "ssd", "bsd", "9bs", "7bs", "1hs", "1hs", 5, "1hsl", 2, 3, -1, -1, -1, -1, "flpbsd", "invbsd", "invbsdu", "invbsdu", 1, 4, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 2, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "lsd", "wsd", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Long Sword ", "swor", "", "lsd", "lsd", "lsd", 0, -1, 4, 1, 3, 19, -1, -1, -1, -1, -1, -1, -1, 1, -10, 100, -1, 55, 39, 44, -1, 20, 0, 1520, 42900, -1, -1, "ssd", "lsd", "9ls", "7ls", "1hs", "1hs", 5, "1hsl", 2, 3, -1, -1, -1, -1, "flplsd", "invlsd", "invlsdu", "invlsdu", 1, 4, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 2, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 2, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "wsd", "wsd", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "War Sword", "swor", "", "wsd", "flc", "wsd", 0, -1, 4, 1, 8, 20, -1, -1, -1, -1, -1, -1, -1, 1, -1, 100, -1, 71, 45, 44, -1, 27, 0, 1997, 69919, -1, -1, "ssd", "wsd", "9wd", "7wd", "1hs", "1hs", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpwsd", "invwsd", "", "", 1, 3, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 2, 1, 3, 20, -1, -1, -1, -1, 255, 1, 1, 1, 3, 20, -1, -1, -1, -1, 255, -1, -1, 1, 2, 20, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Two-Handed Sword", "swor", "", "2hs", "clm", "2hs", 0, -1, 4, 1, 2, 9, 1, 1, 8, 17, -1, -1, -1, 2, -1, 100, -1, 35, 27, 44, -1, 10, 0, 644, 13940, -1, -1, "clm", "2hs", "92h", "72h", "1hs", "2hs", 5, "2hss", 1, 4, -1, -1, -1, -1, "flp2hs", "inv2hs", "inv2hsu", "inv2hsu", 1, 3, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, 1, 1, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "clm", "gis", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Claymore", "swor", "", "clm", "clm", "clm", 0, -1, 4, 1, 5, 12, 1, 1, 13, 30, -1, -1, -1, 2, 10, 100, -1, 47, -1, 50, -1, 17, 0, 1262, 32454, -1, -1, "clm", "clm", "9cm", "7cm", "1hs", "2hs", 5, "2hss", 1, 4, -1, -1, -1, -1, "flpclm", "invclm", "", "", 1, 4, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 2, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "gis", "bsw", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Giant Sword", "swor", "", "gis", "gsd", "gis", 0, -1, 4, 1, 3, 16, 1, 1, 9, 28, -1, -1, -1, 2, -1, 100, -1, 56, 34, 50, -1, 21, 0, 1459, 43639, -1, -1, "clm", "gis", "9gs", "7gs", "1hs", "2hs", 5, "2hss", 1, 4, -1, -1, -1, -1, "flpgis", "invgis", "invgisu", "invgisu", 1, 4, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 1, 1, 2, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "bsw", "flb", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Bastard Sword", "swor", "", "bsw", "clm", "bsw", 0, -1, 4, 1, 7, 19, 1, 1, 20, 28, -1, -1, -1, 1, 10, 100, -1, 62, -1, 40, -1, 24, 0, 1971, 61804, -1, -1, "clm", "bsw", "9b9", "7b7", "1hs", "2hs", 5, "2hss", 1, 4, -1, -1, -1, -1, "flpbsw", "invbsw", "invbswu", "invbswu", 1, 4, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Flamberge", "swor", "", "flb", "clm", "flb", 0, -1, 4, 1, 9, 15, 1, 1, 13, 26, -1, -1, -1, 2, -10, 100, -1, 70, 49, 50, -1, 27, 0, 2400, 80800, -1, -1, "clm", "flb", "9fb", "7fb", "1hs", "2hs", 5, "2hss", 2, 4, -1, -1, -1, -1, "flpflb", "invflb", "", "", 1, 5, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 2, 20, -1, -1, -1, -1, 255, -1, 1, 1, 2, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Great Sword", "swor", "", "gsd", "gsd", "gsd", 0, -1, 4, 1, 12, 20, 1, 1, 25, 42, -1, -1, -1, 2, 10, 100, -1, 100, 60, 50, -1, 33, 0, 3451, 132883, -1, -1, "clm", "gsd", "9gd", "7gd", "1hs", "2hs", 5, "2hss", 2, 4, -1, -1, -1, -1, "flpgsd", "invgsd", "invgsdu", "invgsdu", 1, 6, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 3, 20, -1, -1, -1, -1, 255, -1, 1, 1, 2, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Dagger", "knif", "", "dgr", "dgr", "dgr", 0, -1, 2, 1, 1, 4, -1, -1, -1, -1, -1, -1, -1, -1, -20, 75, 75, -1, -1, 16, -1, 3, 0, 60, 4180, -1, -1, "dgr", "dgr", "9dg", "7dg", "1ht", "1ht", 5, "1ht", 1, 2, -1, -1, -1, -1, "flpdgr", "invdgr", "", "", 1, 1, 0, "", 0, "item_smallmetalweapon", 12, "item_smallmetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "kri", "bld", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Dirk", "knif", "", "dir", "dir", "dir", 0, -1, 2, 1, 3, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, 75, 75, -1, 25, 20, -1, 9, 0, 532, 11788, -1, -1, "dgr", "dir", "9di", "7di", "1ht", "1ht", 5, "1ht", 1, 2, -1, -1, -1, -1, "flpdir", "invdir", "", "", 1, 1, 0, "", 0, "item_smallmetalweapon", 12, "item_smallmetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "kri", "bld", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Kriss", "knif", "", "kri", "dir", "kri", 0, -1, 2, 1, 2, 11, -1, -1, -1, -1, -1, -1, -1, -1, -20, 75, 75, -1, 45, 24, -1, 17, 0, 1227, 31859, -1, -1, "dgr", "kri", "9kr", "7kr", "1ht", "1ht", 5, "1ht", 1, 3, -1, -1, -1, -1, "flpkrs", "invkrs", "invkrsu", "invkrsu", 1, 3, 0, "", 0, "item_smallmetalweapon", 12, "item_smallmetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 20, -1, -1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 1, 20, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Blade", "knif", "", "bld", "dgr", "bld", 0, -1, 3, 1, 4, 15, -1, -1, -1, -1, -1, -1, -1, -1, -10, 75, 75, 35, 51, 24, -1, 23, 0, 1764, 54572, -1, -1, "dgr", "bld", "9bl", "7bl", "1ht", "1ht", 5, "1ht", 1, 3, -1, -1, -1, -1, "flpbld", "invbld", "", "", 1, 2, 0, "", 0, "item_smallmetalweapon", 12, "item_smallmetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 20, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Throwing Knife", "tkni", "", "tkf", "dgr", "tkf", 0, -1, 2, 1, 2, 3, -1, -1, -1, -1, 4, 9, -1, -1, -1, 75, 75, -1, 21, 4, -1, 2, 0, 6, 3512, -1, -1, "dgr", "tkf", "9tk", "7tk", "1ht", "1ht", 5, "1ht", 1, 2, 1, 40, 160, 75, "flptkn", "invtkn", "", "", -1, -1, 0, "primarily thrown", 0, "item_smallmetalweapon", 12, "item_smallmetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 36, 7, 4, 0, 3, 1, 2, -1, -1, 255, 1, 2, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 2, 2, -1, -1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 1, 20, -1, -1, 1, 2, 0, "bkf", "bkf", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Throwing Axe", "taxe", "", "tax", "hax", "tax", 0, -1, 2, 1, 4, 7, -1, -1, -1, -1, 8, 12, -1, -1, 10, 75, 75, -1, 40, 6, -1, 7, 0, 11, 6077, -1, -1, "hax", "tax", "9ta", "7ta", "1hs", "1hs", 5, "1hsl", 1, 2, 1, 16, 130, 32, "flptax", "invtax", "", "", -1, -1, 0, "primarily thrown", 0, "item_smallmetalweapon", 12, "item_smallmetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 35, 7, 5, 0, 3, 1, 1, -1, -1, 255, 1, 2, -1, -1, 20, -1, -1, -1, -1, 255, 1, 1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 2, 2, -1, -1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 1, 20, -1, -1, 2, 2, 0, "bal", "bal", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Balanced Knife", "tkni", "", "bkf", "dgr", "bkf", 0, -1, 2, 1, 1, 8, -1, -1, -1, -1, 6, 11, -1, -1, -20, 75, 75, -1, 51, 8, -1, 13, 0, 15, 9195, -1, -1, "dgr", "bkf", "9bk", "7bk", "1ht", "1ht", 5, "1ht", 1, 2, 1, 30, 160, 60, "flpbkf", "invbkf", "", "", -1, -1, 0, "primarily thrown", 0, "item_smallmetalweapon", 12, "item_smallmetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 36, 7, 4, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 2, -1, -1, 1, 2, 3, -1, -1, 1, 1, 2, 1, 2, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 1, 20, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Balanced Axe", "taxe", "", "bal", "hax", "bal", 0, -1, 2, 1, 5, 10, -1, -1, -1, -1, 12, 15, -1, -1, -10, 75, 75, -1, 57, 10, -1, 16, 0, 35, 11060, -1, -1, "hax", "bal", "9b8", "7b8", "1hs", "1hs", 5, "1hsl", 2, 3, 1, 16, 130, 24, "flpbal", "invbal", "", "", -1, -1, 0, "primarily thrown", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 35, 7, 5, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 2, -1, -1, 1, 2, 3, -1, -1, 1, 1, 2, 1, 2, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Javelin", "jave", "", "jav", "jav", "jav", 0, -1, 4, 1, 1, 5, -1, -1, -1, -1, 6, 14, 15, 2, -10, 75, 75, -1, -1, 2, -1, 1, 0, 5, 3005, -1, -1, "jav", "jav", "9ja", "7ja", "1ht", "1ht", 5, "1ht", 1, 3, 1, 30, 60, 60, "flpjav", "invjav", "", "", -1, -1, 0, "primarily thrown", 0, "item_javelins", 12, "item_javelins", 0, 0, 5, 0, 0, 0, -1, -1, 1, 7, 2, 0, 3, 2, 3, -1, -1, 255, 1, 2, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 2, -1, -1, 1, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 1, 20, 1, 1, 1, 1, 20, -1, -1, 5, 8, 0, "glv", "glv", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Pilum", "jave", "", "pil", "pil", "pil", 0, -1, 4, 1, 4, 9, -1, -1, -1, -1, 7, 20, 15, 2, -1, 75, 75, -1, 45, 3, -1, 10, 0, 18, 7680, -1, -1, "jav", "pil", "9pi", "7pi", "1ht", "1ht", 5, "1ht", 1, 3, 1, 25, 50, 50, "flppil", "invpil", "", "", -1, -1, 0, "primarily thrown", 0, "item_javelins", 12, "item_javelins", 0, 0, 5, 0, 0, 0, -1, -1, 371, 7, 2, 0, 3, -1, -1, -1, -1, 255, 1, 1, -1, -1, 20, -1, -1, -1, -1, 255, 1, 1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 2, -1, -1, 1, 1, 1, -1, -1, 255, 1, 1, -1, -1, 255, 1, 1, 1, 2, 20, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 1, 20, 1, 1, 1, 1, 20, -1, -1, 5, 8, 0, "tsp", "tsp", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Short Spear", "jave", "", "ssp", "jav", "ssp", 0, -1, 4, 1, 2, 13, -1, -1, -1, -1, 10, 22, 15, 2, 10, 75, 75, 40, 40, 4, -1, 15, 0, 24, 10360, -1, -1, "jav", "ssp", "9s9", "7s7", "1ht", "1ht", 5, "1ht", 1, 3, 1, 20, 40, 40, "flpssp", "invssp", "", "", -1, -1, 0, "primarily thrown", 0, "item_javelins", 12, "item_javelins", 0, 0, 5, 0, 0, 0, -1, -1, 1, 7, 2, 0, 3, -1, -1, -1, -1, 255, -1, -1, 1, 2, 30, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, 1, 2, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 1, 20, 1, 1, 1, 1, 20, -1, -1, 5, 8, 0, "tsp", "tsp", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Glaive", "jave", "", "glv", "glv", "glv", 0, -1, 4, 1, 5, 17, -1, -1, -1, -1, 16, 22, 15, 2, 20, 75, 75, 52, 35, 5, -1, 23, 0, 36, 14828, -1, -1, "jav", "glv", "9gl", "7gl", "1ht", "1ht", 5, "1ht", 1, 4, 1, 15, 40, 40, "flpglv", "invglv", "", "", -1, -1, 0, "primarily thrown", 0, "item_javelins", 12, "item_javelins", 0, 0, 5, 0, 0, 0, -1, -1, 37, 7, 2, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 30, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, 1, 2, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 1, 20, 1, 1, 1, 1, 20, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Throwing Spear", "jave", "", "tsp", "pil", "tsp", 0, -1, 4, 1, 5, 15, -1, -1, -1, -1, 12, 30, 15, 2, -10, 75, 75, -1, 65, 6, -1, 29, 0, 48, 18392, -1, -1, "jav", "tsp", "9ts", "7ts", "1ht", "1ht", 5, "1ht", 1, 4, 1, 32, 80, 80, "flptsp", "invtsp", "", "", -1, -1, 0, "primarily thrown", 0, "item_javelins", 12, "item_javelins", 0, 0, 5, 0, 0, 0, -1, -1, 371, 7, 2, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 2, 20, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 1, 20, 1, 1, 1, 1, 20, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Spear", "spea", "", "spr", "spr", "spr", 0, -1, 4, 1, -1, -1, -1, 1, 3, 15, -1, -1, 15, 3, -10, 100, -1, -1, 20, 30, -1, 5, 0, 300, 6500, -1, -1, "spr", "spr", "9sr", "7sr", "2ht", "2ht", 5, "2ht", 2, 4, -1, -1, -1, -1, "flpspr", "invspr", "", "", 1, 3, 0, "2 square reach", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "spt", "pik", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Trident", "spea", "", "tri", "tri", "tri", 0, -1, 4, 1, -1, -1, -1, 1, 9, 15, -1, -1, 15, 3, -1, 100, -1, 38, 24, 35, -1, 9, 0, 683, 13147, -1, -1, "spr", "tri", "9tr", "7tr", "2ht", "2ht", 5, "2ht", 2, 4, -1, -1, -1, -1, "flptri", "invtri", "invtriu", "invtriu", 1, 4, 0, "2 square reach", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, 1, 1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "spt", "pik", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Brandistock", "spea", "", "brn", "brn", "brn", 0, -1, 4, 1, -1, -1, -1, 1, 7, 17, -1, -1, 15, 4, -20, 100, -1, 40, 50, 28, -1, 16, 0, 1162, 29092, -1, -1, "spr", "brn", "9br", "7br", "2ht", "2ht", 5, "2ht", 2, 4, -1, -1, -1, -1, "flpbrn", "invbrn", "", "", 1, 5, 0, "2 square reach", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "pik", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Spetum", "spea", "", "spt", "tri", "spt", 0, -1, 4, 1, -1, -1, -1, 1, 15, 23, -1, -1, 15, 4, -1, 100, -1, 54, 35, 28, -1, 20, 0, 1672, 45940, -1, -1, "spr", "spt", "9st", "7st", "2ht", "2ht", 5, "2ht", 2, 4, -1, -1, -1, -1, "flpspt", "invspt", "", "", 1, 6, 0, "2 square reach", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, -1, 1, 1, 2, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Pike", "spea", "", "pik", "pik", "pik", 0, -1, 4, 1, -1, -1, -1, 1, 14, 63, -1, -1, 15, 4, 20, 100, -1, 60, 45, 25, -1, 24, 0, 2023, 63052, -1, -1, "spr", "pik", "9p9", "7p7", "2ht", "2ht", 5, "2ht", 2, 4, -1, -1, -1, -1, "flppik", "invpik", "", "", 1, 6, 0, "3 square reach", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 1, 30, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 1, -1, -1, 255, -1, 1, -1, -1, 255, 1, 1, 1, 2, 20, -1, -1, -1, -1, 255, 1, 1, 1, 2, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Bardiche", "pole", "", "bar", "hal", "bar", 0, -1, 4, 1, -1, -1, -1, 1, 1, 27, -1, -1, -1, 2, 10, 100, -1, 40, -1, 50, -1, 5, 0, 302, 6510, -1, -1, "hal", "bar", "9b7", "7o7", "stf", "stf", 5, "2hsl", 2, 4, -1, -1, -1, -1, "flpbar", "invbar", "", "", 1, 3, 0, "2 square reach", 0, "item_woodweaponlarge", 12, "item_woodweaponlarge", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "hal", "wsc", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Voulge", "pole", "", "vou", "hal", "vou", 0, -1, 4, 1, -1, -1, -1, 1, 6, 21, -1, -1, -1, 2, -1, 100, -1, 50, -1, 50, -1, 11, 0, 611, 14721, -1, -1, "hal", "vou", "9vo", "7vo", "stf", "stf", 5, "2hsl", 2, 4, -1, -1, -1, -1, "flpvou", "invvou", "", "", 1, 4, 0, "2 square reach", 0, "item_woodweaponlarge", 12, "item_woodweaponlarge", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 1, -1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "hal", "wsc", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Scythe", "pole", "", "scy", "scy", "scy", 0, -1, 4, 1, -1, -1, -1, 1, 8, 20, -1, -1, -1, 1, -10, 100, -1, 41, 41, 65, -1, 15, 0, 848, 22720, -1, -1, "hal", "scy", "9s8", "7s8", "stf", "stf", 5, "2hsl", 2, 4, -1, -1, -1, -1, "flpscy", "invscy", "invscyu", "invscyu", 1, 5, 0, "2 square reach", 0, "item_woodweaponlarge", 12, "item_woodweaponlarge", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 1, -1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, 1, 255, -1, -1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, 1, 1, -1, -1, -1, -1, 255, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "hal", "wsc", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Poleaxe", "pole", "", "pax", "hal", "pax", 0, -1, 4, 1, -1, -1, -1, 1, 18, 39, -1, -1, -1, 3, 10, 100, -1, 62, -1, 65, -1, 21, 0, 1701, 48721, -1, -1, "hal", "pax", "9pa", "7pa", "stf", "stf", 5, "2hsl", 2, 4, -1, -1, -1, -1, "flppax", "invpax", "", "", 1, 5, 0, "2 square reach", 0, "item_woodweaponlarge", 12, "item_woodweaponlarge", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Halberd", "pole", "", "hal", "pax", "hal", 0, -1, 4, 1, -1, -1, -1, 1, 12, 45, -1, -1, -1, 4, -1, 100, -1, 75, 47, 55, -1, 29, 0, 2706, 95474, -1, -1, "hal", "hal", "9h9", "7h7", "stf", "stf", 5, "2hsl", 2, 4, -1, -1, -1, -1, "flphal", "invhal", "", "", 1, 6, 0, "2 square reach", 0, "item_woodweaponlarge", 12, "item_woodweaponlarge", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "War Scythe", "pole", "", "wsc", "scy", "wsc", 0, -1, 3, 1, -1, -1, -1, 1, 15, 36, -1, -1, -1, 4, -10, 100, -1, 80, 80, 55, -1, 34, 0, 3388, 134692, -1, -1, "hal", "wsc", "9wc", "7wc", "stf", "stf", 5, "2hsl", 2, 4, -1, -1, -1, -1, "flpwsc", "invwsc", "", "", 1, 6, 0, "2 square reach", 0, "item_woodweaponlarge", 12, "item_woodweaponlarge", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 20, -1, -1, -1, -1, 255, -1, -1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Short Staff", "staf", "", "sst", "bst", "sst", 0, -1, 2, 1, -1, -1, -1, 1, 1, 5, -1, -1, -1, 1, -10, 100, -1, -1, -1, 20, -1, 1, 0, 168, 3168, 1, -1, "bst", "sst", "8ss", "6ss", "stf", "stf", 5, "club", 1, 3, -1, -1, -1, -1, "flpsst", "invsst", "", "", 1, 2, 0, "magically charged", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 5, 9, 5, 9, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "cst", "bst", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Long Staff", "staf", "", "lst", "sst", "lst", 0, -1, 2, 1, -1, -1, -1, 1, 2, 8, -1, -1, -1, 1, -1, 100, -1, -1, -1, 30, -1, 8, 0, 463, 10204, 1, -1, "bst", "lst", "8ls", "6ls", "stf", "stf", 5, "staf", 1, 4, -1, -1, -1, -1, "flplst", "invlst", "", "", 1, 3, 0, "magically charged", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 2, 3, 1, 2, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 2, -1, 2, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "cst", "wst", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Gnarled Staff", "staf", "", "cst", "cst", "cst", 0, -1, 2, 1, -1, -1, -1, 1, 4, 12, -1, -1, -1, 1, 10, 100, -1, -1, -1, 35, -1, 12, 0, 766, 17692, 1, -1, "bst", "cst", "8cs", "6cs", "stf", "stf", 5, "staf", 1, 4, -1, -1, -1, -1, "flpcst", "invcst", "invcstu", "invcstu", 1, 4, 0, "magically charged", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 3, 5, 5, 9, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 2, 3, 2, 5, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "wst", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Battle Staff", "staf", "", "bst", "sst", "bst", 0, -1, 2, 1, -1, -1, -1, 1, 6, 13, -1, -1, -1, 1, -1, 100, -1, -1, -1, 40, -1, 17, 0, 1223, 31791, 1, -1, "bst", "bst", "8bs", "6bs", "stf", "stf", 5, "staf", 1, 4, -1, -1, -1, -1, "flpbst", "invbst", "", "", 1, 4, 0, "magically charged", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 3, 1, 3, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 2, 3, 2, 5, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 2, 3, 1, 3, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 2, 3, 1, 4, 20, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "War Staff", "staf", "", "wst", "lst", "wst", 0, -1, 2, 1, -1, -1, -1, 1, 12, 28, -1, -1, -1, 1, 20, 100, -1, -1, -1, 50, -1, 24, 0, 1985, 62140, 1, -1, "bst", "wst", "8ws", "6ws", "stf", "stf", 5, "staf", 2, 4, -1, -1, -1, -1, "flpwst", "invwst", "", "", 1, 6, 0, "magically charged", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 2, 1, 2, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 3, 1, 4, 20, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Short Bow", "bow", "", "sbw", "sbw", "sbw", 0, -1, 2, 1, -1, -1, -1, 1, 1, 4, -1, -1, 13, -1, 5, -1, 100, -1, 15, 20, 1, 1, 0, 100, 3100, -1, -1, "sbw", "sbw", "8sb", "6sb", "bow", "bow", 6, "bow", 2, 3, -1, -1, -1, -1, "flpsbw", "invsbw", "", "", 1, 3, 0, "", 0, "item_bow", 12, "item_bow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, 1, 1, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "hbw", "cbw", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Hunter's Bow", "bow", "", "hbw", "sbw", "hbw", 0, -1, 2, 1, -1, -1, -1, 1, 2, 6, -1, -1, 13, -1, -10, -1, 100, -1, 28, 32, 1, 5, 0, 350, 6750, -1, -1, "sbw", "hbw", "8hb", "6hb", "bow", "bow", 6, "bow", 2, 3, -1, -1, -1, -1, "flphbw", "invhbw", "", "", 1, 4, 0, "", 0, "item_bow", 12, "item_bow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, 1, 1, 1, 1, 1, -1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "lbw", "sbb", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Long Bow", "bow", "", "lbw", "lbw", "lbw", 0, -1, 2, 1, -1, -1, -1, 1, 3, 10, -1, -1, 13, -1, -1, -1, 100, 22, 19, 28, 1, 8, 0, 490, 10420, -1, -1, "sbw", "lbw", "8lb", "6lb", "bow", "bow", 6, "bow", 2, 4, -1, -1, -1, -1, "flplbw", "invlbw", "", "", 1, 5, 0, "", 0, "item_bow", 12, "item_bow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "cbw", "lbb", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Composite Bow", "bow", "", "cbw", "lbw", "cbw", 0, -1, 2, 1, -1, -1, -1, 1, 4, 8, -1, -1, 13, -1, -10, -1, 100, 25, 35, 36, 1, 12, 0, 727, 17224, -1, -1, "sbw", "cbw", "8cb", "6cb", "bow", "bow", 6, "bow", 2, 3, -1, -1, -1, -1, "flpcbw", "invcbw", "invcbwu", "invcbwu", 1, 4, 0, "", 0, "item_bow", 12, "item_bow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 2, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 1, -1, -1, 255, -1, 1, -1, -1, 255, -1, 1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "sbb", "swb", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Short Battle Bow", "bow", "", "sbb", "sbb", "sbb", 0, -1, 2, 1, -1, -1, -1, 1, 5, 11, -1, -1, 13, -1, -1, -1, 100, 30, 40, 40, 1, 18, 0, 1045, 30310, -1, -1, "sbw", "sbb", "8s8", "6s7", "bow", "bow", 6, "bow", 2, 3, -1, -1, -1, -1, "flpsbb", "invsbb", "invsbbu", "invsbbu", 1, 5, 0, "", 0, "item_bow", 12, "item_bow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 2, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "lbb", "lwb", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Long Battle Bow", "bow", "", "lbb", "lbb", "lbb", 0, -1, 2, 1, -1, -1, -1, 1, 3, 18, -1, -1, 13, -1, 10, -1, 100, 40, 50, 44, 1, 23, 0, 1545, 49535, -1, -1, "sbw", "lbb", "8l8", "6l7", "bow", "bow", 6, "bow", 2, 4, -1, -1, -1, -1, "flplbb", "invlbb", "", "", 1, 6, 0, "", 0, "item_bow", 12, "item_bow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 1, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "swb", "lwb", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Short War Bow", "bow", "", "swb", "sbb", "swb", 0, -1, 2, 1, -1, -1, -1, 1, 6, 14, -1, -1, 13, -1, -1, -1, 100, 35, 55, 48, 1, 27, 0, 2500, 83500, -1, -1, "sbw", "swb", "8sw", "6sw", "bow", "bow", 6, "bow", 2, 3, -1, -1, -1, -1, "flpswb", "invswb", "invswbu", "invswbu", 1, 5, 0, "", 0, "item_bow", 12, "item_bow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 1, -1, 1, 1, -1, 1, -1, 1, 1, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, 1, 1, 1, 2, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "lwb", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Long War Bow", "bow", "", "lwb", "lbb", "lwb", 0, -1, 2, 1, -1, -1, -1, 1, 3, 23, -1, -1, 13, -1, 10, -1, 100, 50, 65, 55, 1, 31, 0, 3575, 128825, -1, -1, "sbw", "lwb", "8lw", "6lw", "bow", "bow", 6, "bow", 2, 4, -1, -1, -1, -1, "flplwb", "invlwb", "", "", 1, 6, 0, "", 0, "item_bow", 12, "item_bow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, 1, 1, 1, 2, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Light Crossbow", "xbow", "", "lxb", "lxb", "lxb", 0, -1, 2, 1, -1, -1, -1, 1, 6, 9, -1, -1, -1, -1, -10, -1, 100, 21, 27, 30, 1, 6, 0, 803, 10318, -1, -1, "lxb", "lxb", "8lx", "6lx", "xbw", "xbw", 5, "xbow", 2, 3, -1, -1, -1, -1, "flplxb", "invlxb", "invlxbu", "invlxbu", 1, 3, 0, "reload lag between shots", 0, "item_crossbow", 12, "item_crossbow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "mxb", "rxb", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Crossbow", "xbow", "", "mxb", "lxb", "mxb", 0, -1, 2, 1, -1, -1, -1, 1, 9, 16, -1, -1, -1, -1, -1, -1, 100, 40, 33, 40, 1, 15, 0, 2345, 45175, -1, -1, "lxb", "mxb", "8mx", "6mx", "xbw", "xbw", 5, "xbow", 2, 3, -1, -1, -1, -1, "flpmxb", "invmxb", "invmxbu", "invmxbu", 1, 4, 0, "reload lag between shots", 0, "item_crossbow", 12, "item_crossbow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 1, 1, 1, -1, 1, 1, 1, 1, -1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "hxb", "hxb", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Heavy Crossbow", "xbow", "", "hxb", "hxb", "hxb", 0, -1, 2, 1, -1, -1, -1, 1, 14, 26, -1, -1, -1, -1, 10, -1, 100, 60, 40, 50, 1, 24, 0, 4096, 112804, -1, -1, "lxb", "hxb", "8hx", "6hx", "xbw", "xbw", 5, "xbow", 2, 4, -1, -1, -1, -1, "flphxb", "invhxb", "invhxbu", "invhxbu", 1, 6, 0, "reload lag between shots", 0, "item_crossbow", 12, "item_crossbow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 1, -1, 1, 1, -1, 1, -1, 1, 1, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Repeating Crossbow", "xbow", "", "rxb", "hxb", "rxb", 0, -1, 2, 1, -1, -1, -1, 1, 6, 12, -1, -1, -1, -1, -40, -1, 100, 40, 50, 40, 1, 33, 0, 2739, 109387, -1, -1, "lxb", "rxb", "8rx", "6rx", "xbw", "xbw", 5, "xbow", 2, 3, -1, -1, -1, -1, "flprxb", "invrxb", "invrxbu", "invrxbu", 1, 5, 0, "fires 5 shots before reload", 0, "item_crossbow", 12, "item_crossbow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 1, 20, -1, 1, 1, 2, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Rancid Gas Potion", "tpot", "", "gps", "gpl", "gps", 0, -1, -1, 1, 0, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 1, 32, 24, 200, 0, -1, -1, "gpl", "gps", "", "", "1ht", "1ht", 5, "hth", 1, 1, 1, 3, 25, 6, "flpgpl", "invgpl", "", "", -1, -1, 0, "", 0, "item_potion", 14, "item_potion", 0, 0, 5, 0, 1, 0, -1, -1, 49, 7, 3, 0, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", 0, 1),
			new BaseWeapon(BaseItem.ItemCount++, "Oil Potion", "tpot", "", "ops", "opl", "ops", 0, -1, -1, 1, 0, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 1, 28, 20, 150, 0, -1, -1, "opl", "ops", "", "", "1ht", "1ht", 5, "hth", 1, 1, 1, 3, 25, 6, "flpopl", "invopl", "", "", -1, -1, 0, "", 0, "item_potion", 14, "item_potion", 0, 0, 5, 0, 1, 0, -1, -1, 46, 7, 3, 0, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", 0, 1),
			new BaseWeapon(BaseItem.ItemCount++, "Choking Gas Potion", "tpot", "", "gpm", "gps", "gpm", 0, -1, -1, 1, 0, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 1, 20, 16, 120, 0, -1, -1, "gps", "gpm", "", "", "1ht", "1ht", 5, "hth", 1, 1, 1, 3, 25, 6, "flpgps", "invgpm", "", "", -1, -1, 0, "", 0, "item_potion", 14, "item_potion", 0, 0, 5, 0, 1, 0, -1, -1, 48, 7, 3, 0, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", 0, 1),
			new BaseWeapon(BaseItem.ItemCount++, "Exploding Potion", "tpot", "", "opm", "opl", "opm", 0, -1, -1, 1, 0, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 1, 16, 12, 80, 0, -1, -1, "opl", "opm", "", "", "1ht", "1ht", 5, "hth", 1, 1, 1, 3, 25, 6, "flpops", "invopm", "", "", -1, -1, 0, "", 0, "item_potion", 14, "item_potion", 0, 0, 5, 0, 1, 0, -1, -1, 45, 7, 3, 0, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", 0, 1),
			new BaseWeapon(BaseItem.ItemCount++, "Strangling Gas Potion", "tpot", "", "gpl", "gps", "gpl", 0, -1, -1, 1, 0, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 1, 8, 6, 40, 0, -1, -1, "gps", "gpl", "", "", "1ht", "1ht", 5, "hth", 1, 1, 1, 3, 25, 6, "flpgps", "invgps", "", "", -1, -1, 0, "", 0, "item_potion", 14, "item_potion", 0, 0, 5, 0, 1, 0, -1, -1, 47, 7, 3, 0, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", 0, 1),
			new BaseWeapon(BaseItem.ItemCount++, "Fulminating Potion", "tpot", "", "opl", "ops", "opl", 0, -1, -1, 1, 0, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 1, 4, 0, 24, 0, -1, -1, "ops", "opl", "", "", "1ht", "1ht", 5, "hth", 1, 1, 1, 3, 25, 6, "flpops", "invops", "", "", -1, -1, 0, "", 0, "item_potion", 14, "item_potion", 0, 0, 5, 0, 1, 0, -1, -1, 44, 7, 3, 0, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 0, 0, 0, "xxx", "xxx", 0, 1),
			new BaseWeapon(BaseItem.ItemCount++, "decoy dagger", "knif", "", "d33", "dgr", "d33", 0, -1, -1, -1, 1, 2, -1, -1, -1, -1, -1, -1, -1, -1, -20, 100, -1, 15, 20, 10, -1, 0, 0, 666, 0, -1, -1, "dgr", "d33", "", "", "1ht", "1ht", 5, "1ht", 1, 2, -1, -1, -1, -1, "flpd33", "invd33", "", "", -1, -1, 0, "", 0, "item_smallmetalweapon", 12, "item_smallmetalweapon", 1, 0, 5, 0, 0, 0, 18, 1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 0, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Gidbinn", "knif", "", "g33", "dgr", "g33", 0, -1, -1, -1, 3, 7, -1, -1, -1, -1, -1, -1, -1, -1, -20, 100, -1, 15, 25, 30, -1, 0, 0, 666, 0, -1, -1, "dgr", "g33", "", "", "1ht", "1ht", 5, "1ht", 1, 2, -1, -1, -1, -1, "flpg33", "invg33", "", "", -1, -1, 0, "", 0, "item_smallmetalweapon", 12, "item_smallmetalweapon", 1, 0, 5, 0, 0, 0, 18, 1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 0, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Wirt's Leg", "club", "", "leg", "clb", "leg", 0, -1, -1, -1, 2, 8, -1, -1, -1, -1, -1, -1, -1, -1, -10, 100, -1, -1, -1, 66, -1, 0, 0, 20, 0, -1, -1, "clb", "leg", "", "", "1hs", "1hs", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpleg", "invleg", "", "", 1, 3, 0, "", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, 1, 1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Horadric Malus", "hamm", "", "hdm", "whm", "hdm", 0, -1, -1, -1, 6, 15, -1, -1, -1, -1, -1, -1, -1, -1, 20, 100, -1, 15, 15, 55, -1, 0, 0, 600, 0, -1, -1, "whm", "hdm", "", "", "1hs", "1hs", 5, "1hsl", 1, 2, -1, -1, -1, -1, "flphmr", "invhmr", "", "", -1, -1, 0, "", 0, "item_sword", 12, "item_sword", 1, 0, 5, 0, 0, 0, 4, 1, 0, 7, 0, 0, 0, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 0, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Hellforge Hammer", "hamm", "", "hfh", "whm", "hfh", 0, -1, -1, -1, 6, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, 100, -1, -1, -1, 55, -1, 0, 0, 600, 0, -1, -1, "whm", "hfh", "", "", "1hs", "1hs", 5, "1hsl", 2, 3, -1, -1, -1, -1, "flphmr", "invhfh", "", "", 1, 5, 0, "", 0, "item_sword", 12, "item_sword", 1, 0, 5, 0, 0, 0, 25, 1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 1, "xxx", "xxx", 0, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Horadric Staff", "staf", "", "hst", "bst", "hst", 0, -1, -1, -1, -1, -1, -1, 1, 12, 20, -1, -1, -1, 2, -1, 100, -1, 30, -1, 50, -1, 0, 0, 1223, 0, -1, -1, "bst", "hst", "", "", "stf", "stf", 5, "staf", 1, 4, -1, -1, -1, -1, "flphst", "invhst", "", "", -1, -1, 0, "magically charged", 0, "item_staff", 12, "item_staff", 1, 0, 5, 0, 0, 0, 10, 1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 1, "xxx", "xxx", 0, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Staff of Kings", "staf", "", "msf", "bst", "msf", 0, -1, -1, -1, -1, -1, -1, 1, 10, 15, -1, -1, -1, 2, -1, 100, -1, 25, -1, 45, -1, 0, 0, 1223, 0, -1, -1, "bst", "msf", "", "", "stf", "stf", 5, "staf", 1, 3, -1, -1, -1, -1, "flpmsf", "invmsf", "", "", -1, -1, 0, "magically charged", 0, "item_staff", 12, "item_staff", 1, 0, 5, 0, 0, 0, 10, 1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 1, "xxx", "xxx", 0, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Hatchet", "axe", "", "9ha", "hax", "9ha", 0, -1, 3, 1, 10, 21, -1, -1, -1, -1, -1, -1, -1, -1, -1, 100, -1, 25, 25, 28, -1, 31, 19, 810, 43110, -1, -1, "hax", "hax", "9ha", "7ha", "1hs", "1hs", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flphax", "invhax", "invhaxu", "invhaxu", 1, 2, 0, "", 0, "item_smallmetalweapon", 12, "item_smallmetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 35, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Cleaver", "axe", "", "9ax", "axe", "9ax", 0, -1, 4, 1, 10, 33, -1, -1, -1, -1, -1, -1, -1, 1, 10, 100, -1, 68, -1, 24, -1, 34, 22, 1509, 70806, -1, -1, "axe", "axe", "9ax", "7ax", "1hs", "1hs", 5, "1hsl", 2, 3, -1, -1, -1, -1, "flpaxe", "invaxe", "invaxeu", "invaxeu", 1, 4, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Twin Axe", "axe", "", "92a", "axe", "92a", 0, -1, 4, 1, 13, 38, -1, -1, -1, -1, -1, -1, -1, 1, 10, 100, -1, 85, -1, 24, -1, 39, 25, 2919, 135841, -1, -1, "axe", "2ax", "92a", "72a", "1hs", "1hs", 5, "1hsl", 2, 3, -1, -1, -1, -1, "flp2ax", "inv2ax", "", "", 1, 5, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Crowbill", "axe", "", "9mp", "axe", "9mp", 0, -1, 4, 1, 14, 34, -1, -1, -1, -1, -1, -1, -1, 1, -10, 100, -1, 94, 70, 26, -1, 43, 25, 4563, 220209, -1, -1, "axe", "mpi", "9mp", "7mp", "1hs", "1hs", 5, "1hsl", 2, 3, -1, -1, -1, -1, "flpmpi", "invmpi", "invmpiu", "invmpiu", 1, 6, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Naga", "axe", "", "9wa", "hax", "9wa", 0, -1, 4, 1, 16, 45, -1, -1, -1, -1, -1, -1, -1, 2, -1, 100, -1, 121, -1, 26, -1, 48, 25, 6669, 346612, -1, -1, "hax", "wax", "9wa", "7wa", "1hs", "1hs", 5, "1hsl", 2, 3, -1, -1, -1, -1, "flpwax", "invwax", "", "", 1, 6, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Military Axe", "axe", "", "9la", "lax", "9la", 0, -1, 4, 1, -1, -1, -1, 1, 14, 34, -1, -1, -1, 1, -10, 100, -1, 73, -1, 30, -1, 34, 22, 1362, 65808, -1, -1, "lax", "lax", "9la", "7la", "stf", "stf", 5, "2hsl", 2, 3, -1, -1, -1, -1, "flplax", "invlax", "", "", 1, 4, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Bearded Axe ", "axe", "", "9ba", "lax", "9ba", 0, -1, 4, 1, -1, -1, -1, 1, 21, 49, -1, -1, -1, 1, -1, 100, -1, 92, -1, 35, -1, 38, 25, 2718, 124784, -1, -1, "lax", "bax", "9ba", "7ba", "stf", "stf", 5, "2hsl", 2, 3, -1, -1, -1, -1, "flpbrx", "invbrx", "", "", 1, 5, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Tabar", "axe", "", "9bt", "btx", "9bt", 0, -1, 4, 1, -1, -1, -1, 1, 24, 77, -1, -1, -1, 1, 10, 100, -1, 101, -1, 40, -1, 42, 25, 4086, 195112, -1, -1, "btx", "btx", "9bt", "7bt", "stf", "stf", 5, "2hsl", 2, 3, -1, -1, -1, -1, "flpbtx", "invbtx", "inv9btu", "inv9btu", 1, 5, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Gothic Axe", "axe", "", "9ga", "btx", "9ga", 0, -1, 4, 1, -1, -1, -1, 1, 18, 70, -1, -1, -1, 2, -10, 100, -1, 115, 79, 50, -1, 46, 25, 6048, 303708, -1, -1, "btx", "gax", "9ga", "7ga", "stf", "stf", 5, "2hsl", 2, 4, -1, -1, -1, -1, "flpgax", "invgax", "invgaxu", "invgaxu", 1, 6, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Ancient Axe", "axe", "", "9gi", "gix", "9gi", 0, -1, 4, 1, -1, -1, -1, 1, 43, 85, -1, -1, -1, 3, 10, 100, -1, 125, -1, 50, -1, 51, 25, 7530, 412030, -1, -1, "gix", "gix", "9gi", "7gi", "stf", "stf", 5, "2hsl", 2, 3, -1, -1, -1, -1, "flpgix", "invgix", "inv9giu", "inv9giu", 1, 6, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Burnt Wand", "wand", "", "9wn", "wnd", "9wn", 0, -1, 1, 1, 8, 18, -1, -1, -1, -1, -1, -1, -1, -1, -1, 100, -1, 25, -1, 15, -1, 31, 19, 915, 46365, 1, -1, "wnd", "wnd", "9wn", "7wn", "1hs", "1hs", 5, "1hss", 1, 2, -1, -1, -1, -1, "flpwnd", "invwnd", "", "", 1, 1, 0, "magically charged", 0, "item_wand", 12, "item_wand", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Petrified Wand", "wand", "", "9yw", "ywn", "9yw", 0, -1, 1, 1, 8, 24, -1, -1, -1, -1, -1, -1, -1, -1, 10, 100, -1, 25, -1, 15, -1, 38, 25, 2535, 117830, 1, -1, "ywn", "ywn", "9yw", "7yw", "1hs", "1hs", 5, "1hss", 1, 2, -1, -1, -1, -1, "flpywn", "invywn", "", "", 1, 2, 0, "magically charged", 0, "item_wand", 12, "item_wand", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Tomb Wand", "wand", "", "9bw", "bwn", "9bw", 0, -1, 1, 1, 10, 22, -1, -1, -1, -1, -1, -1, -1, -1, -20, 100, -1, 25, -1, 15, -1, 43, 25, 4188, 204084, 1, -1, "bwn", "bwn", "9bw", "7bw", "1hs", "1hs", 5, "1hss", 1, 2, -1, -1, -1, -1, "flpbwn", "invbwn", "invbwnu", "invbwnu", 1, 2, 0, "magically charged", 0, "item_wand", 12, "item_wand", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Grave Wand", "wand", "", "9gw", "bwn", "9gw", 0, -1, 1, 1, 13, 29, -1, -1, -1, -1, -1, -1, -1, -1, -1, 100, -1, 25, -1, 15, -1, 49, 25, 6594, 350106, 1, -1, "bwn", "gwn", "9gw", "7gw", "1hs", "1hs", 5, "1hss", 1, 2, -1, -1, -1, -1, "flpgwn", "invgwn", "inv9gwu", "inv9gwu", 1, 2, 0, "magically charged", 0, "item_wand", 12, "item_wand", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Cudgel", "club", "", "9cl", "clb", "9cl", 0, -1, 1, 1, 6, 21, -1, -1, -1, -1, -1, -1, -1, -1, -10, 100, -1, 25, -1, 24, -1, 30, 18, 396, 29380, -1, -1, "clb", "clb", "9cl", "7cl", "1hs", "1hs", 5, "club", 1, 3, -1, -1, -1, -1, "flpclb", "invclb", "invclbu", "invclbu", 1, 2, 0, "", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Rune Scepter", "scep", "", "9sc", "mac", "9sc", 0, -1, 2, 1, 13, 24, -1, -1, -1, -1, -1, -1, -1, -1, -1, 100, -1, 58, -1, 50, -1, 31, 19, 1350, 59850, -1, -1, "mac", "scp", "9sc", "7sc", "1hs", "1hs", 5, "club", 1, 3, -1, -1, -1, -1, "flpscp", "invscp", "", "", 1, 2, 0, "magically charged", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Holy Water Sprinkler", "scep", "", "9qs", "mac", "9qs", 0, -1, 4, 1, 14, 36, -1, -1, -1, -1, -1, -1, -1, 1, 10, 100, -1, 76, -1, 60, -1, 40, 25, 3627, 167580, -1, -1, "mac", "gsc", "9qs", "7qs", "1hs", "1hs", 5, "club", 1, 3, -1, -1, -1, -1, "flpgsc", "invgsc", "", "", 1, 3, 0, "magically charged", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Divine Scepter", "scep", "", "9ws", "whm", "9ws", 0, -1, 4, 1, 16, 38, -1, -1, -1, -1, -1, -1, -1, 1, -10, 100, -1, 103, -1, 70, -1, 45, 25, 7269, 352105, -1, -1, "whm", "wsp", "9ws", "7ws", "1hs", "1hs", 5, "club", 2, 3, -1, -1, -1, -1, "flpwsp", "invwsp", "", "", 1, 5, 0, "magically charged", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Barbed Club", "club", "", "9sp", "clb", "9sp", 0, -1, 3, 1, 13, 25, -1, -1, -1, -1, -1, -1, -1, 1, -1, 100, -1, 30, -1, 36, -1, 32, 20, 975, 49700, -1, -1, "clb", "spc", "9sp", "7sp", "1hs", "1hs", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpspc", "invspc", "invspcu", "invspcu", 1, 3, 0, "", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Flanged Mace", "mace", "", "9ma", "mac", "9ma", 0, -1, 4, 1, 15, 23, -1, -1, -1, -1, -1, -1, -1, -1, -1, 100, -1, 61, -1, 60, -1, 35, 23, 1689, 79115, -1, -1, "mac", "mac", "9ma", "7ma", "1hs", "1hs", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpmac", "invmac", "", "", 1, 2, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Jagged Star", "mace", "", "9mt", "mac", "9mt", 0, -1, 4, 1, 20, 31, -1, -1, -1, -1, -1, -1, -1, 1, 10, 100, -1, 74, -1, 72, -1, 39, 25, 2832, 132448, -1, -1, "mac", "mst", "9mt", "7mt", "1hs", "1hs", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpmst", "invmst", "invmstu", "invmstu", 1, 3, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Knout", "mace", "", "9fl", "fla", "9fl", 0, -1, 4, 1, 13, 35, -1, -1, -1, -1, -1, -1, -1, 2, -10, 100, -1, 82, 73, 30, -1, 43, 25, 4536, 219048, -1, -1, "fla", "fla", "9fl", "7fl", "1hs", "1hs", 5, "1hsl", 2, 3, -1, -1, -1, -1, "flpfla", "invfla", "", "", 1, 5, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Battle Hammer", "hamm", "", "9wh", "whm", "9wh", 0, -1, 4, 1, 35, 58, -1, -1, -1, -1, -1, -1, -1, -1, 20, 110, -1, 100, -1, 55, -1, 48, 25, 6543, 340564, -1, -1, "whm", "whm", "9wh", "7wh", "1hs", "1hs", 5, "1hsl", 2, 3, -1, -1, -1, -1, "flpwhm", "invwhm", "", "", 1, 4, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 178, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "War Club", "hamm", "", "9m9", "mau", "9m9", 0, -1, 4, 1, -1, -1, -1, 1, 53, 78, -1, -1, -1, 1, 10, 110, -1, 124, -1, 60, -1, 45, 25, 5310, 263950, -1, -1, "mau", "mau", "9m9", "7m7", "stf", "stf", 5, "2hsl", 2, 4, -1, -1, -1, -1, "flpmau", "invmau", "", "", 1, 6, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Martel de Fer", "hamm", "", "9gm", "mau", "9gm", 0, -1, 3, 1, -1, -1, -1, 1, 61, 99, -1, -1, -1, 2, 20, 110, -1, 169, -1, 60, -1, 53, 25, 9945, 556085, -1, -1, "mau", "gma", "9gm", "7gm", "stf", "stf", 5, "2hsl", 2, 3, -1, -1, -1, -1, "flpgma", "invgma", "inv9gmu", "inv9gmu", 1, 6, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Gladius", "swor", "", "9ss", "ssd", "9ss", 0, -1, 3, 1, 8, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, 100, -1, 25, -1, 24, -1, 30, 18, 516, 32980, -1, -1, "ssd", "ssd", "9ss", "7ss", "1hs", "1hs", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpssd", "invssd", "", "", 1, 2, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Cutlass", "swor", "", "9sm", "scm", "9sm", 0, -1, 3, 1, 8, 21, -1, -1, -1, -1, -1, -1, -1, -1, -30, 100, -1, 25, 52, 22, -1, 43, 25, 1122, 72246, -1, -1, "scm", "scm", "9sm", "7sm", "1hs", "1hs", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpscm", "invscm", "invscmu", "invscmu", 1, 2, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Shamshir", "swor", "", "9sb", "scm", "9sb", 0, -1, 3, 1, 10, 24, -1, -1, -1, -1, -1, -1, -1, -1, -10, 100, -1, 58, 58, 32, -1, 35, 23, 1698, 79430, -1, -1, "scm", "sbr", "9sb", "7sb", "1hs", "1hs", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpsbr", "invsbr", "invsbru", "invsbru", 1, 2, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Tulwar", "swor", "", "9fc", "flc", "9fc", 0, -1, 4, 1, 16, 35, -1, -1, -1, -1, -1, -1, -1, -1, 20, 100, -1, 70, 42, 32, -1, 37, 25, 2349, 107913, -1, -1, "flc", "flc", "9fc", "7fc", "1hs", "1hs", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpflc", "invflc", "", "", 1, 2, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Dimensional Blade", "swor", "", "9cr", "crs", "9cr", 0, -1, 2, 1, 13, 35, -1, -1, -1, -1, -1, -1, -1, 1, -1, 100, -1, 85, 60, 20, -1, 37, 25, 6681, 268197, -1, -1, "crs", "crs", "9cr", "7cr", "1hs", "1hs", 5, "1hsl", 2, 3, -1, -1, -1, -1, "flpcrs", "invcrs", "inv9cru", "inv9cru", 1, 6, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 5, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Battle Sword", "swor", "", "9bs", "bsd", "9bs", 0, -1, 4, 1, 16, 34, -1, -1, -1, -1, -1, -1, -1, -1, -1, 100, -1, 92, 43, 32, -1, 40, 25, 3387, 157980, -1, -1, "bsd", "bsd", "9bs", "7bs", "1hs", "1hs", 5, "1hsl", 2, 3, -1, -1, -1, -1, "flpbsd", "invbsd", "", "", 1, 4, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Rune Sword", "swor", "", "9ls", "lsd", "9ls", 0, -1, 4, 1, 10, 42, -1, -1, -1, -1, -1, -1, -1, 1, -10, 100, -1, 103, 79, 44, -1, 44, 25, 4860, 238340, -1, -1, "lsd", "lsd", "9ls", "7ls", "1hs", "1hs", 5, "1hsl", 2, 3, -1, -1, -1, -1, "flplsd", "invlsd", "inv9lsu", "inv9lsu", 1, 4, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Ancient Sword", "swor", "", "9wd", "flc", "9wd", 0, -1, 4, 1, 18, 43, -1, -1, -1, -1, -1, -1, -1, 1, -1, 100, -1, 127, 88, 44, -1, 49, 25, 6291, 335259, -1, -1, "flc", "wsd", "9wd", "7wd", "1hs", "1hs", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpwsd", "invwsd", "", "", 1, 3, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Espadon", "swor", "", "92h", "clm", "92h", 0, -1, 4, 1, 8, 26, 1, 1, 18, 40, -1, -1, -1, 2, -1, 100, -1, 73, 61, 44, -1, 37, 25, 2232, 103584, -1, -1, "clm", "2hs", "92h", "72h", "1hs", "2hs", 5, "2hss", 1, 4, -1, -1, -1, -1, "flp2hs", "inv2hs", "inv2hsu", "inv2hsu", 1, 3, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Dracian Falx", "swor", "", "9cm", "clm", "9cm", 0, -1, 4, 1, 13, 30, 1, 1, 26, 61, -1, -1, -1, 2, 10, 100, -1, 91, 20, 50, -1, 42, 25, 4086, 195112, -1, -1, "clm", "clm", "9cm", "7cm", "1hs", "2hs", 5, "2hss", 1, 4, -1, -1, -1, -1, "flpclm", "invclm", "", "", 1, 4, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Tusk Sword", "swor", "", "9gs", "gsd", "9gs", 0, -1, 4, 1, 10, 37, 1, 1, 19, 58, -1, -1, -1, 2, -1, 100, -1, 104, 71, 50, -1, 45, 25, 4677, 235465, -1, -1, "gsd", "gis", "9gs", "7gs", "1hs", "2hs", 5, "2hss", 1, 4, -1, -1, -1, -1, "flpgis", "invgis", "invgisu", "invgisu", 1, 4, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Gothic Sword", "swor", "", "9b9", "clm", "9b9", 0, -1, 4, 1, 14, 40, 1, 1, 39, 60, -1, -1, -1, 1, 10, 100, -1, 113, 20, 40, -1, 48, 25, 6213, 324724, -1, -1, "clm", "bsw", "9b9", "7b7", "1hs", "2hs", 5, "2hss", 1, 4, -1, -1, -1, -1, "flpbsw", "invbsw", "invbswu", "invbswu", 1, 4, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Zweihander", "swor", "", "9fb", "clm", "9fb", 0, -1, 4, 1, 19, 35, 1, 1, 29, 54, -1, -1, -1, 2, -10, 100, -1, 125, 94, 50, -1, 49, 25, 7500, 394500, -1, -1, "clm", "flb", "9fb", "7fb", "1hs", "2hs", 5, "2hss", 2, 4, -1, -1, -1, -1, "flpflb", "invflb", "inv9fbu", "inv9fbu", 1, 5, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Executioner Sword", "swor", "", "9gd", "gsd", "9gd", 0, -1, 4, 1, 24, 40, 1, 1, 47, 80, -1, -1, -1, 2, 10, 100, -1, 170, 110, 50, -1, 54, 25, 10653, 604762, -1, -1, "gsd", "gsd", "9gd", "7gd", "1hs", "2hs", 5, "2hss", 2, 4, -1, -1, -1, -1, "flpgsd", "invgsd", "invgsdu", "invgsdu", 1, 6, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Poignard", "knif", "", "9dg", "dgr", "9dg", 0, -1, 2, 1, 6, 18, -1, -1, -1, -1, -1, -1, -1, -1, -20, 75, 75, 25, -1, 16, -1, 31, 19, 480, 32880, -1, -1, "dgr", "dgr", "9dg", "7dg", "1ht", "1ht", 5, "1ht", 1, 2, -1, -1, -1, -1, "flpdgr", "invdgr", "", "", 1, 1, 0, "", 0, "item_smallmetalweapon", 12, "item_smallmetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Rondel", "knif", "", "9di", "dir", "9di", 0, -1, 2, 1, 10, 26, -1, -1, -1, -1, -1, -1, -1, -1, -1, 75, 75, 25, 58, 20, -1, 36, 24, 1896, 88756, -1, -1, "dir", "dir", "9di", "7di", "1ht", "1ht", 5, "1ht", 1, 2, -1, -1, -1, -1, "flpdir", "invdir", "", "", 1, 1, 0, "", 0, "item_smallmetalweapon", 12, "item_smallmetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Cinquedeas", "knif", "", "9kr", "dir", "9kr", 0, -1, 2, 1, 15, 31, -1, -1, -1, -1, -1, -1, -1, -1, -20, 75, 75, 25, 88, 24, -1, 42, 25, 3981, 190702, -1, -1, "dir", "kri", "9kr", "7kr", "1ht", "1ht", 5, "1ht", 1, 3, -1, -1, -1, -1, "flpkrs", "invkrs", "invkrsu", "invkrsu", 1, 3, 0, "", 0, "item_smallmetalweapon", 12, "item_smallmetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Stilleto", "knif", "", "9bl", "dgr", "9bl", 0, -1, 3, 1, 19, 36, -1, -1, -1, -1, -1, -1, -1, -1, -10, 75, 75, 47, 97, 24, -1, 46, 25, 5592, 282732, -1, -1, "dgr", "bld", "9bl", "7bl", "1ht", "1ht", 5, "1ht", 1, 3, -1, -1, -1, -1, "flpbld", "invbld", "inv9blu", "inv9blu", 1, 2, 0, "", 0, "item_smallmetalweapon", 12, "item_smallmetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Battle Dart", "tkni", "", "9tk", "dgr", "9tk", 0, -1, 2, 1, 8, 16, -1, -1, -1, -1, 11, 24, 15, -1, -1, 75, 75, 25, 52, 6, -1, 31, 19, 80, 20480, -1, -1, "dgr", "tkf", "9tk", "7tk", "1ht", "1ht", 5, "1ht", 1, 2, 1, 40, 160, 75, "flptkn", "invtkn", "", "", -1, -1, 0, "primarily thrown", 0, "item_smallmetalweapon", 12, "item_smallmetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 36, 7, 4, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Francisca", "taxe", "", "9ta", "hax", "9ta", 0, -1, 2, 1, 11, 22, -1, -1, -1, -1, 18, 33, 15, -1, 10, 75, 75, 25, 80, 15, -1, 34, 22, 90, 22560, -1, -1, "hax", "tax", "9ta", "7ta", "1hs", "1hs", 5, "1hsl", 1, 2, 1, 16, 130, 32, "flptax", "invtax", "", "", -1, -1, 0, "primarily thrown", 0, "item_smallmetalweapon", 12, "item_smallmetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 35, 7, 5, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "War Dart", "tkni", "", "9bk", "dgr", "9bk", 0, -1, 2, 1, 6, 24, -1, -1, -1, -1, 14, 27, 15, -1, -20, 75, 75, 25, 97, 20, -1, 39, 25, 100, 25900, -1, -1, "dgr", "bkf", "9bk", "7bk", "1ht", "1ht", 5, "1ht", 1, 2, 1, 30, 160, 60, "flpbkf", "invbkf", "", "", -1, -1, 0, "primarily thrown", 0, "item_smallmetalweapon", 12, "item_smallmetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 36, 7, 4, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Hurlbat", "taxe", "", "9b8", "hax", "9b8", 0, -1, 2, 1, 13, 27, -1, -1, -1, -1, 24, 34, 15, -1, -10, 75, 75, 25, 106, 16, -1, 41, 25, 110, 27510, -1, -1, "hax", "bal", "9b8", "7b8", "1hs", "1hs", 5, "1hsl", 2, 3, 1, 16, 130, 24, "flpbal", "invbal", "", "", -1, -1, 0, "primarily thrown", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 35, 7, 5, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "War Javelin", "jave", "", "9ja", "jav", "9ja", 0, -1, 4, 1, 6, 19, -1, -1, -1, -1, 14, 32, 15, 2, -10, 75, 75, 25, 25, 10, -1, 30, 18, 120, 21100, -1, -1, "jav", "jav", "9ja", "7ja", "1ht", "1ht", 5, "1ht", 1, 3, 1, 30, 60, 60, "flpjav", "invjav", "", "", -1, -1, 0, "primarily thrown", 0, "item_javelins", 12, "item_javelins", 0, 0, 5, 0, 0, 0, -1, -1, 1, 7, 2, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Great Pilum", "jave", "", "9pi", "pil", "9pi", 0, -1, 4, 1, 11, 26, -1, -1, -1, -1, 16, 42, 15, 2, -1, 75, 75, 25, 88, 12, -1, 37, 25, 125, 25625, -1, -1, "pil", "pil", "9pi", "7pi", "1ht", "1ht", 5, "1ht", 1, 3, 1, 25, 50, 50, "flppil", "invpil", "", "", -1, -1, 0, "primarily thrown", 0, "item_javelins", 12, "item_javelins", 0, 0, 5, 0, 0, 0, -1, -1, 37, 7, 2, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Simbilan", "jave", "", "9s9", "jav", "9s9", 0, -1, 4, 1, 8, 32, -1, -1, -1, -1, 27, 50, 15, 2, 10, 75, 75, 80, 80, 14, -1, 40, 25, 135, 27900, -1, -1, "jav", "ssp", "9s9", "7s7", "1ht", "1ht", 5, "1ht", 1, 3, 1, 20, 40, 40, "flpssp", "invssp", "", "", -1, -1, 0, "primarily thrown", 0, "item_javelins", 12, "item_javelins", 0, 0, 5, 0, 0, 0, -1, -1, 37, 7, 2, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Spiculum", "jave", "", "9gl", "glv", "9gl", 0, -1, 4, 1, 13, 38, -1, -1, -1, -1, 32, 60, 15, 2, 20, 75, 75, 98, 73, 16, -1, 46, 25, 145, 32170, -1, -1, "glv", "glv", "9gl", "7gl", "1ht", "1ht", 5, "1ht", 1, 4, 1, 8, 20, 20, "flpglv", "invglv", "", "", -1, -1, 0, "primarily thrown", 0, "item_javelins", 12, "item_javelins", 0, 0, 5, 0, 0, 0, -1, -1, 37, 7, 2, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Harpoon", "jave", "", "9ts", "pil", "9ts", 0, -1, 4, 1, 13, 35, -1, -1, -1, -1, 18, 54, 15, 2, -10, 75, 75, 25, 118, 18, -1, 51, 25, 150, 35650, -1, -1, "pil", "tsp", "9ts", "7ts", "1ht", "1ht", 5, "1ht", 1, 4, 1, 32, 80, 80, "flptsp", "invtsp", "", "", -1, -1, 0, "primarily thrown", 0, "item_javelins", 12, "item_javelins", 0, 0, 5, 0, 0, 0, -1, -1, 37, 7, 2, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "War Spear", "spea", "", "9sr", "spr", "9sr", 0, -1, 4, 1, -1, -1, -1, 1, 10, 37, -1, -1, -1, 3, -10, 100, -1, 25, 25, 30, -1, 33, 21, 1200, 58600, -1, -1, "spr", "spr", "9sr", "7sr", "2ht", "2ht", 5, "2ht", 2, 4, -1, -1, -1, -1, "flpspr", "invspr", "", "", 1, 3, 0, "2 square reach", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Fuscina", "spea", "", "9tr", "tri", "9tr", 0, -1, 4, 1, -1, -1, -1, 1, 19, 37, -1, -1, -1, 3, -1, 100, -1, 77, 25, 35, -1, 36, 24, 2349, 105064, -1, -1, "tri", "tri", "9tr", "7tr", "2ht", "2ht", 5, "2ht", 2, 4, -1, -1, -1, -1, "flptri", "invtri", "invtriu", "invtriu", 1, 4, 0, "2 square reach", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "War Fork", "spea", "", "9br", "brn", "9br", 0, -1, 4, 1, -1, -1, -1, 1, 16, 40, -1, -1, -1, 4, -20, 100, -1, 80, 95, 28, -1, 41, 25, 3786, 178226, -1, -1, "brn", "brn", "9br", "7br", "2ht", "2ht", 5, "2ht", 2, 4, -1, -1, -1, -1, "flpbrn", "invbrn", "inv9bru", "inv9bru", 1, 5, 0, "2 square reach", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Yari", "spea", "", "9st", "tri", "9st", 0, -1, 4, 1, -1, -1, -1, 1, 29, 59, -1, -1, -1, 4, -1, 100, -1, 101, -1, 28, -1, 44, 25, 5316, 258404, -1, -1, "tri", "spt", "9st", "7st", "2ht", "2ht", 5, "2ht", 2, 4, -1, -1, -1, -1, "flpspt", "invspt", "", "", 1, 6, 0, "2 square reach", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Lance", "spea", "", "9p9", "pik", "9p9", 0, -1, 4, 1, -1, -1, -1, 1, 27, 114, -1, -1, -1, 4, 20, 100, -1, 110, 88, 25, -1, 47, 25, 6369, 325343, -1, -1, "pik", "pik", "9p9", "7p7", "2ht", "2ht", 5, "2ht", 2, 4, -1, -1, -1, -1, "flppik", "invpik", "", "", 1, 6, 0, "3 square reach", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Lochaber Axe", "pole", "", "9b7", "hal", "9b7", 0, -1, 4, 1, -1, -1, -1, 1, 6, 58, -1, -1, -1, 2, 10, 100, -1, 80, -1, 50, -1, 33, 21, 1206, 58798, -1, -1, "hal", "bar", "9b7", "7o7", "stf", "stf", 5, "2hsl", 2, 4, -1, -1, -1, -1, "flpbar", "invbar", "", "", 1, 3, 0, "2 square reach", 0, "item_woodweaponlarge", 12, "item_woodweaponlarge", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Bill", "pole", "", "9vo", "hal", "9vo", 0, -1, 4, 1, -1, -1, -1, 1, 14, 53, -1, -1, -1, 2, -1, 100, -1, 95, -1, 50, -1, 37, 25, 2133, 99921, -1, -1, "pax", "vou", "9vo", "7vo", "stf", "stf", 5, "2hsl", 2, 4, -1, -1, -1, -1, "flpvou", "invvou", "", "", 1, 4, 0, "2 square reach", 0, "item_woodweaponlarge", 12, "item_woodweaponlarge", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Battle Scythe", "pole", "", "9s8", "scy", "9s8", 0, -1, 4, 1, -1, -1, -1, 1, 18, 45, -1, -1, -1, 1, -10, 100, -1, 82, 82, 65, -1, 40, 25, 2844, 136260, -1, -1, "scy", "scy", "9s8", "7s8", "stf", "stf", 5, "2hsl", 2, 4, -1, -1, -1, -1, "flpscy", "invscy", "inv9s8u", "inv9s8u", 1, 5, 0, "2 square reach", 0, "item_woodweaponlarge", 12, "item_woodweaponlarge", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Partizan", "pole", "", "9pa", "hal", "9pa", 0, -1, 4, 1, -1, -1, -1, 1, 34, 75, -1, -1, -1, 3, 10, 100, -1, 113, 67, 65, -1, 35, 23, 5403, 209105, -1, -1, "pax", "pax", "9pa", "7pa", "stf", "stf", 5, "2hsl", 2, 4, -1, -1, -1, -1, "flppax", "invpax", "", "", 1, 5, 0, "2 square reach", 0, "item_woodweaponlarge", 12, "item_woodweaponlarge", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Bec-de-Corbin", "pole", "", "9h9", "pax", "9h9", 0, -1, 4, 1, -1, -1, -1, 1, 13, 85, -1, -1, -1, 4, -1, 100, -1, 133, 91, 55, -1, 51, 25, 8418, 457318, -1, -1, "hal", "hal", "9h9", "7h7", "stf", "stf", 5, "2hsl", 2, 4, -1, -1, -1, -1, "flphal", "invhal", "", "", 1, 6, 0, "2 square reach", 0, "item_woodweaponlarge", 12, "item_woodweaponlarge", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Grim Scythe", "pole", "", "9wc", "scy", "9wc", 0, -1, 3, 1, -1, -1, -1, 1, 30, 70, -1, -1, -1, 4, -10, 100, -1, 140, 140, 55, -1, 55, 25, 10464, 605520, -1, -1, "scy", "wsc", "9wc", "7wc", "stf", "stf", 5, "2hsl", 2, 4, -1, -1, -1, -1, "flpwsc", "invwsc", "", "", 1, 6, 0, "2 square reach", 0, "item_woodweaponlarge", 12, "item_woodweaponlarge", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Jo Staff", "staf", "", "8ss", "bst", "8ss", 0, -1, 2, 1, -1, -1, -1, 1, 6, 21, -1, -1, -1, 1, -10, 100, -1, 25, -1, 20, -1, 30, 18, 804, 41620, 1, -1, "bst", "sst", "8ss", "6ss", "stf", "stf", 5, "club", 1, 3, -1, -1, -1, -1, "flpsst", "invsst", "", "", 1, 2, 0, "magically charged", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Quarterstaff", "staf", "", "8ls", "sst", "8ls", 0, -1, 2, 1, -1, -1, -1, 1, 8, 26, -1, -1, -1, 1, -1, 100, -1, 25, -1, 30, -1, 35, 23, 1689, 79115, 1, -1, "sst", "lst", "8ls", "6ls", "stf", "stf", 5, "staf", 1, 4, -1, -1, -1, -1, "flplst", "invlst", "", "", 1, 3, 0, "magically charged", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Cedar Staff", "staf", "", "8cs", "cst", "8cs", 0, -1, 2, 1, -1, -1, -1, 1, 11, 32, -1, -1, -1, 1, 10, 100, -1, 25, -1, 35, -1, 38, 25, 2598, 120224, 1, -1, "cst", "cst", "8cs", "6cs", "stf", "stf", 5, "staf", 1, 4, -1, -1, -1, -1, "flpcst", "invcst", "invcstu", "invcstu", 1, 4, 0, "magically charged", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Gothic Staff", "staf", "", "8bs", "sst", "8bs", 0, -1, 2, 1, -1, -1, -1, 1, 14, 34, -1, -1, -1, 1, -1, 100, -1, 25, -1, 40, -1, 42, 25, 3969, 190198, 1, -1, "sst", "bst", "8bs", "6bs", "stf", "stf", 5, "staf", 1, 4, -1, -1, -1, -1, "flpbst", "invbst", "", "", 1, 4, 0, "magically charged", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Rune Staff", "staf", "", "8ws", "lst", "8ws", 0, -1, 2, 1, -1, -1, -1, 1, 24, 58, -1, -1, -1, 1, 20, 100, -1, 25, -1, 50, -1, 47, 25, 6255, 319985, 1, -1, "lst", "wst", "8ws", "6ws", "stf", "stf", 5, "staf", 2, 4, -1, -1, -1, -1, "flpwst", "invwst", "inv8wsu", "inv8wsu", 1, 6, 0, "magically charged", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Edge Bow", "bow", "", "8sb", "sbw", "8sb", 0, -1, 2, 1, -1, -1, -1, 1, 6, 19, -1, -1, 13, -1, 5, -1, 100, 25, 43, 20, 1, 30, 18, 600, 35500, -1, -1, "sbw", "sbw", "8sb", "6sb", "bow", "bow", 6, "bow", 2, 3, -1, -1, -1, -1, "flpsbw", "invsbw", "", "", 1, 3, 0, "", 0, "item_bow", 12, "item_bow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Razor Bow", "bow", "", "8hb", "sbw", "8hb", 0, -1, 2, 1, -1, -1, -1, 1, 8, 22, -1, -1, 13, -1, -10, -1, 100, 25, 62, 32, 1, 33, 21, 1350, 63550, -1, -1, "sbw", "hbw", "8hb", "6hb", "bow", "bow", 6, "bow", 2, 3, -1, -1, -1, -1, "flphbw", "invhbw", "", "", 1, 4, 0, "", 0, "item_bow", 12, "item_bow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Cedar Bow", "bow", "", "8lb", "lbw", "8lb", 0, -1, 2, 1, -1, -1, -1, 1, 10, 29, -1, -1, 13, -1, -1, -1, 100, 53, 49, 28, 1, 35, 23, 1770, 81950, -1, -1, "lbw", "lbw", "8lb", "6lb", "bow", "bow", 6, "bow", 2, 4, -1, -1, -1, -1, "flplbw", "invlbw", "inv8lbu", "inv8lbu", 1, 5, 0, "", 0, "item_bow", 12, "item_bow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Double Bow", "bow", "", "8cb", "lbw", "8cb", 0, -1, 2, 1, -1, -1, -1, 1, 11, 26, -1, -1, 13, -1, -10, -1, 100, 58, 73, 36, 1, 39, 25, 2481, 118759, -1, -1, "lbw", "cbw", "8cb", "6cb", "bow", "bow", 6, "bow", 2, 3, -1, -1, -1, -1, "flpcbw", "invcbw", "invcbwu", "invcbwu", 1, 4, 0, "", 0, "item_bow", 12, "item_bow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Short Siege Bow", "bow", "", "8s8", "sbb", "8s8", 0, -1, 2, 1, -1, -1, -1, 1, 13, 30, -1, -1, 13, -1, -1, -1, 100, 65, 80, 40, 1, 43, 25, 3435, 171705, -1, -1, "sbb", "sbb", "8s8", "6s7", "bow", "bow", 6, "bow", 2, 3, -1, -1, -1, -1, "flpsbb", "invsbb", "inv8s8u", "inv8s8u", 1, 5, 0, "", 0, "item_bow", 12, "item_bow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Long Siege Bow", "bow", "", "8l8", "lbb", "8l8", 0, -1, 2, 1, -1, -1, -1, 1, 10, 42, -1, -1, 13, -1, 10, -1, 100, 80, 95, 44, 1, 46, 25, 4935, 252510, -1, -1, "lbb", "lbb", "8l8", "6l7", "bow", "bow", 6, "bow", 2, 4, -1, -1, -1, -1, "flplbb", "invlbb", "", "", 1, 6, 0, "", 0, "item_bow", 12, "item_bow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Rune Bow", "bow", "", "8sw", "sbb", "8sw", 0, -1, 2, 1, -1, -1, -1, 1, 14, 35, -1, -1, 13, -1, -1, -1, 100, 73, 103, 48, 1, 49, 25, 7800, 409200, -1, -1, "sbb", "swb", "8sw", "6sw", "bow", "bow", 6, "bow", 2, 3, -1, -1, -1, -1, "flpswb", "invswb", "invswbu", "invswbu", 1, 5, 0, "", 0, "item_bow", 12, "item_bow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Gothic Bow", "bow", "", "8lw", "lbb", "8lw", 0, -1, 2, 1, -1, -1, -1, 1, 10, 50, -1, -1, 13, -1, 10, -1, 100, 95, 118, 55, 1, 52, 25, 11025, 601800, -1, -1, "lbb", "lwb", "8lw", "6lw", "bow", "bow", 6, "bow", 2, 4, -1, -1, -1, -1, "flplwb", "invlwb", "", "", 1, 6, 0, "", 0, "item_bow", 12, "item_bow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Arbalest", "xbow", "", "8lx", "lxb", "8lx", 0, -1, 2, 1, -1, -1, -1, 1, 14, 27, -1, -1, -1, -1, -10, -1, 100, 52, 61, 30, 1, 34, 22, 2709, 111606, -1, -1, "lxb", "lxb", "8lx", "6lx", "xbw", "xbw", 5, "xbow", 2, 3, -1, -1, -1, -1, "flplxb", "invlxb", "inv8lxu", "inv8lxu", 1, 3, 0, "reload lag between shots", 0, "item_crossbow", 12, "item_crossbow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Siege Crossbow", "xbow", "", "8mx", "lxb", "8mx", 0, -1, 2, 1, -1, -1, -1, 1, 20, 42, -1, -1, -1, -1, -1, -1, 100, 80, 70, 40, 1, 40, 25, 7335, 315900, -1, -1, "lxb", "mxb", "8mx", "6mx", "xbw", "xbw", 5, "xbow", 2, 3, -1, -1, -1, -1, "flpmxb", "invmxb", "inv8mxu", "inv8mxu", 1, 4, 0, "reload lag between shots", 0, "item_crossbow", 12, "item_crossbow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Balista", "xbow", "", "8hx", "hxb", "8hx", 0, -1, 2, 1, -1, -1, -1, 1, 33, 55, -1, -1, -1, -1, 10, -1, 100, 110, 80, 50, 1, 47, 25, 12588, 617636, -1, -1, "hxb", "hxb", "8hx", "6hx", "xbw", "xbw", 5, "xbow", 2, 4, -1, -1, -1, -1, "flphxb", "invhxb", "invhxbu", "invhxbu", 1, 6, 0, "reload lag between shots", 0, "item_crossbow", 12, "item_crossbow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Chu-Ko-Nu", "xbow", "", "8rx", "hxb", "8rx", 0, -1, 2, 1, -1, -1, -1, 1, 14, 32, -1, -1, -1, -1, -60, -1, 100, 80, 95, 40, 1, 54, 25, 8517, 489418, -1, -1, "hxb", "rxb", "8rx", "6rx", "xbw", "xbw", 5, "xbow", 2, 3, -1, -1, -1, -1, "flprxb", "invrxb", "invrxbu", "invrxbu", 1, 5, 0, "fires 5 shots before reload", 0, "item_crossbow", 12, "item_crossbow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Khalim Flail", "mace", "", "qf1", "fla", "qf1", 0, -1, -1, -1, 1, 15, -1, -1, -1, -1, -1, -1, -1, -1, -10, 100, -1, 41, 35, 30, -1, 0, 0, 1412, 0, -1, -1, "fla", "fla", "", "", "1hs", "1hs", 5, "1hsl", 2, 3, -1, -1, -1, -1, "flpfla", "invqf1", "", "", 1, 3, 0, "", 0, "item_sword", 12, "item_sword", 1, 0, 5, 0, 0, 0, 17, 1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 1, "xxx", "xxx", 0, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Super Khalim Flail", "mace", "", "qf2", "fla", "qf2", 0, -1, -1, -1, 1, 15, -1, -1, -1, -1, -1, -1, -1, -1, -10, 100, -1, -1, -1, 30, -1, 0, 0, 1412, 0, -1, -1, "fla", "fla", "", "", "1hs", "1hs", 5, "1hsl", 2, 3, -1, -1, -1, -1, "flpfla", "invqf2", "", "", 1, 3, 0, "", 0, "item_sword", 12, "item_sword", 1, 0, 5, 0, 0, 0, 17, 1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 1, "xxx", "xxx", 0, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Katar", "h2h", "", "ktr", "ktr", "ktr", 100, -1, 2, 1, 4, 7, -1, -1, -1, -1, -1, -1, 14, 1, -10, 75, 75, 20, 20, 48, -1, 1, 0, 72, 3072, -1, -1, "ktr", "ktr", "9ar", "7ar", "ht1", "ht1", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpktr", "invktr", "", "", 1, 2, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, 1, 2, -1, 1, 1, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "wrb", "btl", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Wrist Blade", "h2h", "", "wrb", "ktr", "wrb", 100, -1, 2, 1, 5, 9, -1, -1, -1, -1, -1, -1, 14, 1, -1, 75, 75, 33, 33, 52, -1, 9, 0, 220, 8980, -1, -1, "ktr", "wrb", "9wb", "7wb", "ht1", "ht1", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpktr", "invktr", "", "", 1, 2, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, 1, 1, -1, 1, 1, -1, -1, 1, 1, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "axf", "skr", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Hatchet Hands", "h2h", "", "axf", "axf", "axf", 100, -1, 2, 1, 2, 15, -1, -1, -1, -1, -1, -1, 14, 1, 10, 75, 75, 37, 37, 56, -1, 12, 0, 466, 14092, -1, -1, "axf", "axf", "9xf", "7xf", "ht1", "ht1", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpaxf", "invaxf", "invaxfu", "invaxfu", 1, 2, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "ces", "clw", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Cestus", "h2h", "", "ces", "axf", "ces", 100, -1, 2, 1, 7, 15, -1, -1, -1, -1, -1, -1, 14, 1, -1, 75, 75, 42, 42, 72, -1, 15, 0, 514, 17710, -1, -1, "axf", "ces", "9cs", "7cs", "ht1", "ht1", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpaxf", "invaxf", "invaxfu", "invaxfu", 1, 2, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "clw", "btl", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Claws", "h2h", "", "clw", "clw", "clw", 100, -1, 2, 1, 8, 15, -1, -1, -1, -1, -1, -1, 14, 1, -10, 75, 75, 46, 46, 64, -1, 18, 0, 683, 23794, -1, -1, "clw", "clw", "9lw", "7lw", "ht1", "ht1", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpclw", "invclw", "", "", 1, 3, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "btl", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Blade Talons", "h2h", "", "btl", "clw", "btl", 100, -1, 2, 1, 10, 14, -1, -1, -1, -1, -1, -1, 14, 1, -20, 75, 75, 50, 50, 69, -1, 21, 0, 847, 30787, -1, -1, "clw", "btl", "9tw", "7tw", "ht1", "ht1", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpclw", "invclw", "", "", 1, 3, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 20, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, 1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Scissors Katar", "h2h", "", "skr", "skr", "skr", 100, -1, 2, 1, 9, 17, -1, -1, -1, -1, -1, -1, 14, 1, -10, 75, 75, 55, 55, 68, -1, 24, 0, 1029, 39196, -1, -1, "skr", "skr", "9qr", "7qr", "ht1", "ht1", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpskr", "invskr", "invskru", "invskru", 1, 3, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, 1, 1, -1, 1, 20, 1, 1, 1, 1, 20, 1, 1, 1, 1, 20, -1, -1, 1, 1, 20, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Quhab", "h2h", "", "9ar", "ktr", "9ar", 100, -1, 2, 1, 11, 24, -1, -1, -1, -1, -1, -1, 14, 1, -1, 75, 75, 57, 57, 48, -1, 28, 21, 2334, 81852, -1, -1, "ktr", "ktr", "9ar", "7ar", "ht1", "ht1", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpktr", "invktr", "", "", 1, 3, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Wrist Spike", "h2h", "", "9wb", "ktr", "9wb", 100, -1, 2, 1, 13, 27, -1, -1, -1, -1, -1, -1, 14, 1, -10, 75, 75, 66, 66, 56, -1, 32, 24, 4203, 152996, -1, -1, "ktr", "wrb", "9wb", "7wb", "ht1", "ht1", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpktr", "invktr", "", "", 1, 2, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Fascia", "h2h", "", "9xf", "axf", "9xf", 100, -1, 2, 1, 8, 37, -1, -1, -1, -1, -1, -1, 14, 1, 10, 75, 75, 69, 69, 64, -1, 36, 27, 4203, 171808, -1, -1, "axf", "axf", "9xf", "7xf", "ht1", "ht1", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpaxf", "invaxf", "invaxfu", "invaxfu", 1, 2, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Hand Scythe", "h2h2", "", "9cs", "axf", "9cs", 100, -1, 2, 1, 16, 37, -1, -1, -1, -1, -1, -1, 14, 1, -10, 75, 75, 73, 73, 72, -1, 41, 30, 2964, 144524, -1, -1, "axf", "ces", "9cs", "7cs", "ht1", "ht1", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpaxf", "invaxf", "invaxfu", "invaxfu", 1, 2, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Greater Claws", "h2h2", "", "9lw", "clw", "9lw", 100, -1, 2, 1, 18, 37, -1, -1, -1, -1, -1, -1, 14, 1, -20, 75, 75, 76, 76, 52, -1, 45, 33, 5061, 252745, -1, -1, "clw", "clw", "9lw", "7lw", "ht1", "ht1", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpclw", "invclw", "", "", 1, 3, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Greater Talons", "h2h2", "", "9tw", "clw", "9tw", 100, -1, 2, 1, 21, 35, -1, -1, -1, -1, -1, -1, 14, 1, -30, 75, 75, 79, 79, 69, -1, 50, 37, 9291, 492050, -1, -1, "clw", "btl", "9tw", "7tw", "ht1", "ht1", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpclw", "invclw", "", "", 1, 3, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Scissors Quhab", "h2h2", "", "9qr", "skr", "9qr", 100, -1, 2, 1, 19, 40, -1, -1, -1, -1, -1, -1, 14, 1, -1, 75, 75, 82, 82, 68, -1, 54, 40, 14223, 797542, -1, -1, "skr", "skr", "9qr", "7qr", "ht1", "ht1", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpskr", "invskr", "invskru", "invskru", 1, 3, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Suwayyah", "h2h2", "", "7ar", "ktr", "7ar", 100, -1, 2, 1, 39, 52, -1, -1, -1, -1, -1, -1, 14, 1, -1, 75, 75, 99, 99, 48, -1, 59, 44, 16205, 988095, -1, -1, "ktr", "ktr", "9ar", "7ar", "ht1", "ht1", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpktr", "invktr", "", "", 1, 3, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Wrist Sword", "h2h2", "", "7wb", "ktr", "7wb", 100, -1, 2, 1, 34, 45, -1, -1, -1, -1, -1, -1, 14, 1, -10, 75, 75, 105, 105, 56, -1, 62, 46, 16996, 1087252, -1, -1, "ktr", "wrb", "9wb", "7wb", "ht1", "ht1", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpktr", "invktr", "", "", 1, 3, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "War Fist", "h2h2", "", "7xf", "axf", "7xf", 100, -1, 2, 1, 44, 53, -1, -1, -1, -1, -1, -1, 14, 1, 10, 75, 75, 108, 108, 64, -1, 68, 51, 15784, 1109812, -1, -1, "axf", "axf", "9xf", "7xf", "ht1", "ht1", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpaxf", "invaxf", "invaxfu", "invaxfu", 1, 2, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Battle Cestus", "h2h2", "", "7cs", "axf", "7cs", 100, -1, 2, 1, 36, 42, -1, -1, -1, -1, -1, -1, 14, 1, -10, 75, 75, 110, 110, 72, -1, 73, 54, 15537, 1173201, -1, -1, "axf", "ces", "9cs", "7cs", "ht1", "ht1", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpaxf", "invaxf", "invaxfu", "invaxfu", 1, 2, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Feral Claws", "h2h2", "", "7lw", "clw", "7lw", 100, -1, 2, 1, 22, 53, -1, -1, -1, -1, -1, -1, 14, 1, -20, 75, 75, 113, 113, 52, -1, 78, 58, 16035, 1292230, -1, -1, "clw", "clw", "9lw", "7lw", "ht1", "ht1", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpclw", "invclw", "", "", 1, 3, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Runic Talons", "h2h2", "", "7tw", "clw", "7tw", 100, -1, 2, 1, 24, 44, -1, -1, -1, -1, -1, -1, 14, 1, -30, 75, 75, 115, 115, 69, -1, 81, 60, 17396, 1452076, -1, -1, "clw", "btl", "9tw", "7tw", "ht1", "ht1", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpclw", "invclw", "", "", 1, 3, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Scissors Suwayyah", "h2h2", "", "7qr", "skr", "7qr", 100, -1, 2, 1, 40, 51, -1, -1, -1, -1, -1, -1, 14, 1, -1, 75, 75, 118, 118, 68, -1, 85, 64, 18002, 1575170, -1, -1, "skr", "skr", "9qr", "7qr", "ht1", "ht1", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpskr", "invskr", "invskru", "invskru", 1, 3, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Tomahawk", "axe", "", "7ha", "hax", "7ha", 100, -1, 3, 1, 33, 58, -1, -1, -1, -1, -1, -1, 14, -1, -1, 100, -1, 125, 67, 28, -1, 54, 40, 14033, 787282, -1, -1, "hax", "hax", "9ha", "7ha", "1hs", "1hs", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flphax", "invhax", "invhaxu", "invhaxu", 1, 2, 0, "", 0, "item_smallmetalweapon", 12, "item_smallmetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 35, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Small Crescent", "axe", "", "7ax", "axe", "7ax", 100, -1, 4, 1, 38, 60, -1, -1, -1, -1, -1, -1, 14, 1, 10, 100, -1, 115, 83, 24, -1, 61, 45, 15781, 995641, -1, -1, "axe", "axe", "9ax", "7ax", "1hs", "1hs", 5, "1hsl", 2, 3, -1, -1, -1, -1, "flpaxe", "invaxe", "invaxeu", "invaxeu", 1, 4, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Ettin Axe", "axe", "", "72a", "axe", "72a", 100, -1, 4, 1, 33, 66, -1, -1, -1, -1, -1, -1, 14, 1, 10, 100, -1, 145, 45, 24, -1, 70, 52, 13496, 982220, -1, -1, "axe", "2ax", "92a", "72a", "1hs", "1hs", 5, "1hsl", 2, 3, -1, -1, -1, -1, "flp2ax", "inv2ax", "", "", 1, 5, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "War Spike", "axe", "", "7mp", "axe", "7mp", 100, -1, 4, 1, 30, 48, -1, -1, -1, -1, -1, -1, 14, 1, -10, 100, -1, 133, 54, 26, -1, 79, 59, 16108, 1314532, -1, -1, "axe", "mpi", "9mp", "7mp", "1hs", "1hs", 5, "1hsl", 2, 3, -1, -1, -1, -1, "flpmpi", "invmpi", "invmpiu", "invmpiu", 1, 6, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Berserker Axe", "axe", "", "7wa", "hax", "7wa", 100, -1, 4, 1, 24, 71, -1, -1, -1, -1, -1, -1, 14, 2, -1, 100, -1, 138, 59, 26, -1, 85, 64, 15957, 1401345, -1, -1, "hax", "wax", "9wa", "7wa", "1hs", "1hs", 5, "1hsl", 2, 3, -1, -1, -1, -1, "flpwax", "invwax", "", "", 1, 6, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Feral Axe", "axe", "", "7la", "lax", "7la", 100, -1, 4, 1, -1, -1, -1, 1, 25, 123, -1, -1, 17, 2, -15, 100, -1, 196, -1, 30, -1, 57, 42, 17430, 1024510, -1, -1, "lax", "lax", "9la", "7la", "stf", "stf", 5, "2hsl", 2, 3, -1, -1, -1, -1, "flplax", "invlax", "", "", 1, 4, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Silver Edged Axe", "axe", "", "7ba", "lax", "7ba", 100, -1, 4, 1, -1, -1, -1, 1, 62, 110, -1, -1, 17, 2, -1, 100, -1, 166, 65, 35, -1, 65, 48, 18956, 1267140, -1, -1, "lax", "bax", "9ba", "7ba", "stf", "stf", 5, "2hsl", 2, 3, -1, -1, -1, -1, "flpbrx", "invbrx", "", "", 1, 5, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Decapitator", "axe", "", "7bt", "btx", "7bt", 100, -1, 4, 1, -1, -1, -1, 1, 49, 137, -1, -1, 17, 2, 10, 100, -1, 189, 33, 40, -1, 73, 54, 16377, 1234521, -1, -1, "btx", "btx", "9bt", "7bt", "stf", "stf", 5, "2hsl", 2, 3, -1, -1, -1, -1, "flpbtx", "invbtx", "invbtxu", "invbtxu", 1, 5, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Champion Axe", "axe", "", "7ga", "btx", "7ga", 100, -1, 4, 1, -1, -1, -1, 1, 59, 94, -1, -1, 17, 2, -10, 100, -1, 167, 59, 50, -1, 82, 61, 19245, 1621590, -1, -1, "btx", "gax", "9ga", "7ga", "stf", "stf", 5, "2hsl", 2, 4, -1, -1, -1, -1, "flpgax", "invgax", "invgaxu", "invgaxu", 1, 6, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Glorious Axe", "axe", "", "7gi", "gix", "7gi", 100, -1, 4, 1, -1, -1, -1, 1, 60, 124, -1, -1, 17, 3, 10, 100, -1, 164, 55, 50, -1, 85, 66, 18431, 1611635, -1, -1, "gix", "gix", "9gi", "7gi", "stf", "stf", 5, "2hsl", 2, 3, -1, -1, -1, -1, "flpgix", "invgix", "", "", 1, 6, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Polished Wand", "wand", "", "7wn", "wnd", "7wn", 100, -1, 1, 1, 18, 33, -1, -1, -1, -1, -1, -1, 14, -1, -1, 100, -1, 25, -1, 22, -1, 55, 41, 9412, 547660, -1, -1, "wnd", "wnd", "9wn", "7wn", "1hs", "1hs", 5, "1hss", 1, 2, -1, -1, -1, -1, "flpwnd", "invwnd", "", "", 1, 2, 0, "magically charged", 0, "item_wand", 12, "item_wand", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Ghost Wand", "wand", "", "7yw", "ywn", "7yw", 100, -1, 1, 1, 20, 40, -1, -1, -1, -1, -1, -1, 14, -1, 10, 100, -1, 25, -1, 14, -1, 65, 48, 8786, 606090, -1, -1, "ywn", "ywn", "9yw", "7yw", "1hs", "1hs", 5, "1hss", 1, 2, -1, -1, -1, -1, "flpywn", "invywn", "", "", 1, 2, 0, "magically charged", 0, "item_wand", 12, "item_wand", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Lich Wand", "wand", "", "7bw", "bwn", "7bw", 100, -1, 1, 1, 10, 31, -1, -1, -1, -1, -1, -1, 14, -1, -20, 100, -1, 25, -1, 17, -1, 75, 56, 9208, 730600, -1, -1, "bwn", "bwn", "9bw", "7bw", "1hs", "1hs", 5, "1hss", 1, 2, -1, -1, -1, -1, "flpbwn", "invbwn", "invbwnu", "invbwnu", 1, 2, 0, "magically charged", 0, "item_wand", 12, "item_wand", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Unearthed Wand", "wand", "", "7gw", "bwn", "7gw", 100, -1, 1, 1, 22, 28, -1, -1, -1, -1, -1, -1, 14, -1, -1, 100, -1, 25, -1, 18, -1, 86, 64, 7687, 706582, -1, -1, "bwn", "gwn", "9gw", "7gw", "1hs", "1hs", 5, "1hss", 1, 2, -1, -1, -1, -1, "flpgwn", "invgwn", "", "", 1, 2, 0, "magically charged", 0, "item_wand", 12, "item_wand", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Truncheon", "club", "", "7cl", "clb", "7cl", 100, -1, 1, 1, 35, 43, -1, -1, -1, -1, -1, -1, 14, -1, -10, 100, -1, 88, 43, 55, -1, 52, 39, 1488, 105876, -1, -1, "clb", "clb", "9cl", "7cl", "1hs", "1hs", 5, "club", 1, 3, -1, -1, -1, -1, "flpclb", "invclb", "invclbu", "invclbu", 1, 2, 0, "", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Mighty Scepter", "scep", "", "7sc", "mac", "7sc", 100, -1, 2, 1, 40, 52, -1, -1, -1, -1, -1, -1, 14, -1, -1, 100, -1, 125, 65, 50, -1, 62, 46, 20199, 1285838, -1, -1, "mac", "scp", "9sc", "7sc", "1hs", "1hs", 5, "club", 1, 3, -1, -1, -1, -1, "flpscp", "invscp", "", "", 1, 2, 0, "magically charged", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Seraph Rod", "scep", "", "7qs", "mac", "7qs", 100, -1, 4, 1, 45, 54, -1, -1, -1, -1, -1, -1, 14, 1, 10, 100, -1, 108, 69, 60, -1, 76, 57, 23501, 1826576, -1, -1, "mac", "gsc", "9qs", "7qs", "1hs", "1hs", 5, "club", 1, 3, -1, -1, -1, -1, "flpgsc", "invgsc", "", "", 1, 3, 0, "magically charged", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Caduceus", "scep", "", "7ws", "whm", "7ws", 100, -1, 4, 1, 37, 43, -1, -1, -1, -1, -1, -1, 14, 1, -10, 100, -1, 97, 70, 70, -1, 85, 66, 22870, 1988950, -1, -1, "whm", "wsp", "9ws", "7ws", "1hs", "1hs", 5, "club", 2, 3, -1, -1, -1, -1, "flpwsp", "invwsp", "", "", 1, 5, 0, "magically charged", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Tyrant Club", "club", "", "7sp", "clb", "7sp", 100, -1, 3, 1, 32, 58, -1, -1, -1, -1, -1, -1, 14, 1, -1, 100, -1, 133, -1, 65, -1, 57, 42, 6793, 418201, -1, -1, "clb", "spc", "9sp", "7sp", "1hs", "1hs", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpspc", "invspc", "invspcu", "invspcu", 1, 3, 0, "", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Reinforced Mace", "mace", "", "7ma", "mac", "7ma", 100, -1, 4, 1, 41, 49, -1, -1, -1, -1, -1, -1, 14, -1, -1, 100, -1, 145, 46, 60, -1, 63, 47, 14765, 964195, -1, -1, "mac", "mac", "9ma", "7ma", "1hs", "1hs", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpmac", "invmac", "", "inv7mas", 1, 2, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Devil Star", "mace", "", "7mt", "mac", "7mt", 100, -1, 4, 1, 43, 53, -1, -1, -1, -1, -1, -1, 14, 1, 10, 100, -1, 153, 44, 72, -1, 70, 52, 15674, 1134680, -1, -1, "mac", "mst", "9mt", "7mt", "1hs", "1hs", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpmst", "invmst", "invmstu", "invmstu", 1, 3, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Scourge", "mace", "", "7fl", "fla", "7fl", 100, -1, 4, 1, 3, 80, -1, -1, -1, -1, -1, -1, 14, 2, -10, 100, -1, 125, 77, 65, -1, 76, 57, 19532, 1524932, -1, -1, "fla", "fla", "9fl", "7fl", "1hs", "1hs", 5, "1hsl", 2, 3, -1, -1, -1, -1, "flpfla", "invfla", "", "", 1, 5, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Legendary Mallet", "hamm", "", "7wh", "whm", "7wh", 100, -1, 4, 1, 50, 61, -1, -1, -1, -1, -1, -1, 14, 1, 20, 110, -1, 189, -1, 65, -1, 82, 61, 14388, 1223316, -1, -1, "whm", "whm", "9wh", "7wh", "1hs", "1hs", 5, "1hsl", 2, 3, -1, -1, -1, -1, "flpwhm", "invwhm", "", "", 1, 4, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 178, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Ogre Maul", "hamm", "", "7m7", "mau", "7m7", 100, -1, 4, 1, -1, -1, -1, 1, 77, 106, -1, -1, 17, 1, 10, 110, -1, 225, -1, 60, -1, 69, 51, 12156, 875764, -1, -1, "mau", "mau", "9m9", "7m7", "stf", "stf", 5, "2hsl", 2, 4, -1, -1, -1, -1, "flpmau", "invmau", "", "", 1, 6, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Thunder Maul", "hamm", "", "7gm", "mau", "7gm", 100, -1, 3, 1, -1, -1, -1, 1, 33, 180, -1, -1, 17, 2, 20, 110, -1, 253, -1, 60, -1, 85, 65, 17821, 1559785, -1, -1, "mau", "gma", "9gm", "7gm", "stf", "stf", 5, "2hsl", 2, 3, -1, -1, -1, -1, "flpgma", "invgma", "", "", 1, 6, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Falcata", "swor", "", "7ss", "ssd", "7ss", 100, -1, 3, 1, 31, 59, -1, -1, -1, -1, -1, -1, 14, -1, -1, 100, -1, 150, 88, 24, -1, 56, 42, 15680, 908580, -1, -1, "ssd", "ssd", "9ss", "7ss", "1hs", "1hs", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpssd", "invssd", "", "", 1, 2, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Ataghan", "swor", "", "7sm", "scm", "7sm", 100, -1, 3, 1, 26, 46, -1, -1, -1, -1, -1, -1, 14, -1, -20, 100, -1, 138, 95, 22, -1, 61, 45, 16103, 1015283, -1, -1, "scm", "scm", "9sm", "7sm", "1hs", "1hs", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpscm", "invscm", "invscmu", "invscmu", 1, 2, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Elegant Blade", "swor", "", "7sb", "scm", "7sb", 100, -1, 3, 1, 33, 45, -1, -1, -1, -1, -1, -1, 14, -1, -10, 100, -1, 109, 122, 32, -1, 63, 47, 22785, 1469455, -1, -1, "scm", "sbr", "9sb", "7sb", "1hs", "1hs", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpsbr", "invsbr", "invsbru", "invsbru", 1, 2, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Hydra Edge", "swor", "", "7fc", "flc", "7fc", 100, -1, 4, 1, 28, 68, -1, -1, -1, -1, -1, -1, 14, -1, 10, 100, -1, 142, 105, 32, -1, 69, 51, 18479, 1312051, -1, -1, "flc", "flc", "9fc", "7fc", "1hs", "1hs", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpflc", "invflc", "", "", 1, 2, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Phase Blade", "swor", "", "7cr", "crs", "7cr", 100, -1, 2, 1, 31, 35, -1, -1, -1, -1, -1, -1, 14, 1, -30, 100, -1, 25, 136, 0, 1, 73, 54, 25680, 1913640, -1, -1, "crs", "crs", "9cr", "7cr", "1hs", "1hs", 5, "1hsl", 2, 3, -1, -1, -1, -1, "flpcrs", "invcrs", "invcrsu", "invcrsu", 1, 6, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 5, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Conquest Sword", "swor", "", "7bs", "bsd", "7bs", 100, -1, 4, 1, 37, 53, -1, -1, -1, -1, -1, -1, 14, -1, -1, 100, -1, 142, 112, 32, -1, 78, 58, 19044, 1526932, -1, -1, "bsd", "bsd", "9bs", "7bs", "1hs", "1hs", 5, "1hsl", 2, 3, -1, -1, -1, -1, "flpbsd", "invbsd", "", "", 1, 4, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Cryptic Sword", "swor", "", "7ls", "lsd", "7ls", 100, -1, 4, 1, 5, 77, -1, -1, -1, -1, -1, -1, 14, 1, -10, 100, -1, 99, 109, 44, -1, 82, 61, 14306, 1216592, -1, -1, "lsd", "lsd", "9ls", "7ls", "1hs", "1hs", 5, "1hsl", 2, 3, -1, -1, -1, -1, "flplsd", "invlsd", "invlsdu", "invlsdu", 1, 4, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Mythical Sword", "swor", "", "7wd", "flc", "7wd", 100, -1, 4, 1, 40, 50, -1, -1, -1, -1, -1, -1, 14, 1, -1, 100, -1, 147, 124, 44, -1, 85, 66, 20187, 1760895, -1, -1, "flc", "wsd", "9wd", "7wd", "1hs", "1hs", 5, "1hsl", 1, 3, -1, -1, -1, -1, "flpwsd", "invwsd", "", "", 1, 3, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Legend Sword", "swor", "", "72h", "clm", "72h", 100, -1, 4, 1, 22, 56, 1, 1, 50, 94, -1, -1, 17, 2, -15, 100, -1, 175, 100, 44, -1, 59, 44, 23789, 1435551, -1, -1, "clm", "2hs", "92h", "72h", "1hs", "2hs", 5, "2hss", 1, 4, -1, -1, -1, -1, "flp2hs", "inv2hs", "inv2hsu", "inv2hsu", 1, 3, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Highland Blade", "swor", "", "7cm", "clm", "7cm", 100, -1, 4, 1, 22, 62, 1, 1, 67, 96, -1, -1, 17, 2, -5, 100, -1, 171, 104, 50, -1, 66, 49, 14391, 985306, -1, -1, "clm", "clm", "9cm", "7cm", "1hs", "2hs", 5, "2hss", 1, 4, -1, -1, -1, -1, "flpclm", "invclm", "", "", 1, 4, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Balrog Blade", "swor", "", "7gs", "gsd", "7gs", 100, -1, 4, 1, 15, 75, 1, 1, 55, 118, -1, -1, 17, 2, -1, 100, -1, 185, 87, 50, -1, 71, 53, 16331, 1197501, -1, -1, "gsd", "gis", "9gs", "7gs", "1hs", "2hs", 5, "2hss", 1, 4, -1, -1, -1, -1, "flpgis", "invgis", "invgisu", "invgisu", 1, 4, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Champion Sword", "swor", "", "7b7", "clm", "7b7", 100, -1, 4, 1, 24, 54, 1, 1, 71, 83, -1, -1, 17, 2, -10, 100, -1, 163, 103, 40, -1, 77, 57, 19939, 1576303, -1, -1, "clm", "bsw", "9b9", "7b7", "1hs", "2hs", 5, "2hss", 1, 4, -1, -1, -1, -1, "flpbsw", "invbsw", "invbswu", "invbswu", 1, 4, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Colossal Sword", "swor", "", "7fb", "clm", "7fb", 100, -1, 4, 1, 26, 70, 1, 1, 61, 121, -1, -1, 17, 2, 10, 100, -1, 182, 95, 50, -1, 80, 60, 24800, 2026500, -1, -1, "clm", "flb", "9fb", "7fb", "1hs", "2hs", 5, "2hss", 2, 4, -1, -1, -1, -1, "flpflb", "invflb", "", "", 1, 5, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Colossus Blade", "swor", "", "7gd", "gsd", "7gd", 100, -1, 4, 1, 25, 65, 1, 1, 58, 115, -1, -1, 17, 2, 5, 100, -1, 189, 110, 50, -1, 85, 63, 22259, 1937015, -1, -1, "gsd", "gsd", "9gd", "7gd", "1hs", "2hs", 5, "2hss", 2, 4, -1, -1, -1, -1, "flpgsd", "invgsd", "invgsdu", "invgsdu", 1, 6, 0, "", 0, "item_largemetalweapon", 12, "item_largemetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Bone Knife", "knif", "", "7dg", "dgr", "7dg", 100, -1, 2, 1, 23, 49, -1, -1, -1, -1, -1, -1, 14, -1, -20, 75, 75, 38, 75, 26, -1, 58, 43, 12429, 752382, -1, -1, "dgr", "dgr", "9dg", "7dg", "1ht", "1ht", 5, "1ht", 1, 2, -1, -1, -1, -1, "flpdgr", "invdgr", "", "", 1, 1, 0, "", 0, "item_smallmetalweapon", 12, "item_smallmetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Mithral Point", "knif", "", "7di", "dir", "7di", 100, -1, 2, 1, 37, 53, -1, -1, -1, -1, -1, -1, 14, -1, -1, 75, 75, 55, 98, 55, -1, 70, 52, 17988, 1296660, -1, -1, "dir", "dir", "9di", "7di", "1ht", "1ht", 5, "1ht", 1, 2, -1, -1, -1, -1, "flpdir", "invdir", "", "", 1, 1, 0, "", 0, "item_smallmetalweapon", 12, "item_smallmetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Fanged Knife", "knif", "", "7kr", "dir", "7kr", 100, -1, 2, 1, 15, 57, -1, -1, -1, -1, -1, -1, 14, -1, -20, 75, 75, 42, 86, 36, -1, 83, 62, 13729, 1183507, -1, -1, "dir", "kri", "9kr", "7kr", "1ht", "1ht", 5, "1ht", 1, 3, -1, -1, -1, -1, "flpkrs", "invkrs", "invkrsu", "invkrsu", 1, 3, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Legend Spike", "knif", "", "7bl", "dgr", "7bl", 100, -1, 3, 1, 31, 47, -1, -1, -1, -1, -1, -1, 14, -1, -10, 75, 75, 65, 67, 47, -1, 85, 66, 16076, 1411460, -1, -1, "dgr", "bld", "9bl", "7bl", "1ht", "1ht", 5, "1ht", 1, 3, -1, -1, -1, -1, "flpbld", "invbld", "", "", 1, 2, 0, "", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Flying Knife", "tkni", "", "7tk", "dgr", "7tk", 100, -1, 2, 1, 23, 54, -1, -1, -1, -1, 23, 54, 15, -1, -1, 75, 75, 48, 141, 6, -1, 64, 48, 215, 48260, -1, -1, "dgr", "tkf", "9tk", "7tk", "1ht", "1ht", 5, "1ht", 1, 2, 1, 40, 200, 75, "flptkn", "invtkn", "", "", -1, -1, 0, "primarily thrown", 0, "item_smallmetalweapon", 12, "item_smallmetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 36, 7, 4, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Flying Axe", "taxe", "", "7ta", "hax", "7ta", 100, -1, 2, 1, 17, 65, -1, -1, -1, -1, 15, 66, 15, -1, 10, 75, 75, 88, 108, 15, -1, 56, 42, 230, 43380, -1, -1, "hax", "tax", "9ta", "7ta", "1hs", "1hs", 5, "1hsl", 1, 2, 1, 16, 180, 32, "flptax", "invtax", "", "", -1, -1, 0, "primarily thrown", 0, "item_smallmetalweapon", 12, "item_smallmetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 35, 7, 5, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Winged Knife", "tkni", "", "7bk", "dgr", "7bk", 100, -1, 2, 1, 27, 35, -1, -1, -1, -1, 23, 39, 15, -1, -20, 75, 75, 45, 142, 20, -1, 77, 57, 248, 60096, -1, -1, "dgr", "bkf", "9bk", "7bk", "1ht", "1ht", 5, "1ht", 1, 2, 1, 30, 200, 60, "flpbkf", "invbkf", "invtk3", "", -1, -1, 0, "primarily thrown", 0, "item_smallmetalweapon", 12, "item_smallmetalweapon", 0, 0, 5, 0, 0, 0, -1, -1, 36, 7, 4, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Winged Axe", "taxe", "", "7b8", "hax", "7b8", 100, -1, 2, 1, 11, 56, -1, -1, -1, -1, 7, 60, 15, -1, -10, 75, 75, 96, 122, 16, -1, 80, 60, 251, 62580, -1, -1, "hax", "bal", "9b8", "7b8", "1hs", "1hs", 5, "1hsl", 2, 3, 1, 16, 180, 24, "flpbal", "invbal", "", "", -1, -1, 0, "primarily thrown", 0, "item_sword", 12, "item_sword", 0, 0, 5, 0, 0, 0, -1, -1, 35, 7, 5, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Hyperion Javelin", "jave", "", "7ja", "jav", "7ja", 100, -1, 4, 1, 21, 57, -1, -1, -1, -1, 28, 55, 14, 2, -10, 75, 75, 98, 123, 10, -1, 54, 40, 211, 40894, -1, -1, "jav", "jav", "9ja", "7ja", "1ht", "1ht", 5, "1ht", 1, 3, 1, 30, 100, 60, "flpjav", "invjav", "", "", -1, -1, 0, "primarily thrown", 0, "item_javelins", 12, "item_javelins", 0, 0, 5, 0, 0, 0, -1, -1, 1, 7, 2, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Stygian Pilum", "jave", "", "7pi", "pil", "7pi", 100, -1, 4, 1, 14, 64, -1, -1, -1, -1, 21, 75, 14, 2, -1, 75, 75, 118, 112, 12, -1, 62, 46, 220, 47140, -1, -1, "pil", "pil", "9pi", "7pi", "1ht", "1ht", 5, "1ht", 1, 3, 1, 25, 90, 50, "flppil", "invpil", "", "", -1, -1, 0, "primarily thrown", 0, "item_javelins", 12, "item_javelins", 0, 0, 5, 0, 0, 0, -1, -1, 37, 7, 2, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Balrog Spear", "jave", "", "7s7", "jav", "7s7", 100, -1, 4, 1, 33, 63, -1, -1, -1, -1, 40, 62, 14, 2, 10, 75, 75, 127, 95, 14, -1, 71, 53, 232, 54472, -1, -1, "jav", "ssp", "9s9", "7s7", "1ht", "1ht", 5, "1ht", 1, 3, 1, 20, 80, 40, "flpssp", "invssp", "", "", -1, -1, 0, "primarily thrown", 0, "item_javelins", 12, "item_javelins", 0, 0, 5, 0, 0, 0, -1, -1, 37, 7, 2, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Ghost Glaive", "jave", "", "7gl", "glv", "7gl", 100, -1, 4, 1, 19, 60, -1, -1, -1, -1, 30, 85, 14, 2, 20, 75, 75, 89, 137, 16, -1, 79, 59, 241, 61039, -1, -1, "glv", "glv", "9gl", "7gl", "1ht", "1ht", 5, "1ht", 1, 4, 1, 8, 75, 20, "flpglv", "invglv", "", "", -1, -1, 0, "primarily thrown", 0, "item_javelins", 12, "item_javelins", 0, 0, 5, 0, 0, 0, -1, -1, 37, 7, 2, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Winged Harpoon", "jave", "", "7ts", "pil", "7ts", 100, -1, 4, 1, 27, 35, -1, -1, -1, -1, 11, 77, 14, 2, -10, 75, 75, 76, 145, 18, -1, 85, 65, 199, 61915, -1, -1, "pil", "tsp", "9ts", "7ts", "1ht", "1ht", 5, "1ht", 1, 4, 1, 32, 80, 80, "flptsp", "invtsp", "", "", -1, -1, 0, "primarily thrown", 0, "item_javelins", 12, "item_javelins", 0, 0, 5, 0, 0, 0, -1, -1, 37, 7, 2, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Hyperion Spear", "spea", "", "7sr", "spr", "7sr", 100, -1, 4, 1, -1, -1, -1, 1, 35, 119, -1, -1, 17, 3, -10, 100, -1, 155, 120, 30, -1, 58, 43, 15900, 953700, -1, -1, "spr", "spr", "9sr", "7sr", "2ht", "2ht", 5, "2ht", 2, 4, -1, -1, -1, -1, "flpspr", "invspr", "", "", 1, 3, 0, "2 square reach", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Stygian Pike", "spea", "", "7tr", "tri", "7tr", 100, -1, 4, 1, -1, -1, -1, 1, 29, 144, -1, -1, 17, 3, -1, 100, -1, 168, 97, 35, -1, 66, 49, 17347, 1180402, -1, -1, "tri", "tri", "9tr", "7tr", "2ht", "2ht", 5, "2ht", 2, 4, -1, -1, -1, -1, "flptri", "invtri", "invtriu", "invtriu", 1, 4, 0, "2 square reach", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Mancatcher", "spea", "", "7br", "brn", "7br", 100, -1, 4, 1, -1, -1, -1, 1, 42, 92, -1, -1, 17, 4, -20, 100, -1, 132, 134, 28, -1, 74, 55, 14658, 1124192, -1, -1, "brn", "brn", "9br", "7br", "2ht", "2ht", 5, "2ht", 2, 4, -1, -1, -1, -1, "flpbrn", "invbrn", "", "", 1, 5, 0, "2 square reach", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Ghost Spear", "spea", "", "7st", "tri", "7st", 100, -1, 4, 1, -1, -1, -1, 1, 18, 155, -1, -1, 17, 4, -1, 100, -1, 122, 163, 28, -1, 83, 62, 17248, 1475584, -1, -1, "tri", "spt", "9st", "7st", "2ht", "2ht", 5, "2ht", 2, 4, -1, -1, -1, -1, "flpspt", "invspt", "", "", 1, 6, 0, "2 square reach", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "War Pike", "spea", "", "7p7", "pik", "7p7", 100, -1, 4, 1, -1, -1, -1, 1, 33, 178, -1, -1, 17, 4, 20, 100, -1, 165, 106, 25, -1, 85, 66, 16070, 1410950, -1, -1, "pik", "pik", "9p9", "7p7", "2ht", "2ht", 5, "2ht", 2, 4, -1, -1, -1, -1, "flppik", "invpik", "", "", 1, 6, 0, "3 square reach", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Ogre Axe", "pole", "", "7o7", "hal", "7o7", 100, -1, 4, 1, -1, -1, -1, 1, 28, 145, -1, -1, 17, 2, -1, 100, -1, 195, 75, 50, -1, 60, 45, 9871, 624760, -1, -1, "hal", "bar", "9b7", "7o7", "stf", "stf", 5, "2hsl", 2, 4, -1, -1, -1, -1, "flpbar", "invbar", "", "", 1, 3, 0, "2 square reach", 0, "item_woodweaponlarge", 12, "item_woodweaponlarge", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Colossus Voulge", "pole", "", "7vo", "hal", "7vo", 100, -1, 4, 1, -1, -1, -1, 1, 17, 165, -1, -1, 17, 2, 10, 100, -1, 210, 55, 50, -1, 64, 48, 12822, 855108, -1, -1, "pax", "vou", "9vo", "7vo", "stf", "stf", 5, "2hsl", 2, 4, -1, -1, -1, -1, "flpvou", "invvou", "", "", 1, 4, 0, "2 square reach", 0, "item_woodweaponlarge", 12, "item_woodweaponlarge", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Thresher", "pole", "", "7s8", "scy", "7s8", 100, -1, 4, 1, -1, -1, -1, 1, 12, 141, -1, -1, 17, 1, -10, 100, -1, 152, 118, 65, -1, 71, 53, 11086, 825106, -1, -1, "scy", "scy", "9s8", "7s8", "stf", "stf", 5, "2hsl", 2, 4, -1, -1, -1, -1, "flpscy", "invscy", "invscyu", "invscyu", 1, 5, 0, "2 square reach", 0, "item_woodweaponlarge", 12, "item_woodweaponlarge", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Cryptic Axe", "pole", "", "7pa", "hal", "7pa", 100, -1, 4, 1, -1, -1, -1, 1, 33, 150, -1, -1, 17, 3, 10, 100, -1, 165, 103, 65, -1, 79, 59, 16509, 1346211, -1, -1, "pax", "pax", "9pa", "7pa", "stf", "stf", 5, "2hsl", 2, 4, -1, -1, -1, -1, "flppax", "invpax", "", "", 1, 5, 0, "2 square reach", 0, "item_woodweaponlarge", 12, "item_woodweaponlarge", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Great Poleaxe", "pole", "", "7h7", "pax", "7h7", 100, -1, 4, 1, -1, -1, -1, 1, 46, 127, -1, -1, 17, 4, -1, 100, -1, 179, 99, 55, -1, 84, 63, 21554, 1855036, -1, -1, "hal", "hal", "9h9", "7h7", "stf", "stf", 5, "2hsl", 2, 4, -1, -1, -1, -1, "flphal", "invhal", "", "", 1, 6, 0, "2 square reach", 0, "item_woodweaponlarge", 12, "item_woodweaponlarge", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Giant Thresher", "pole", "", "7wc", "scy", "7wc", 100, -1, 3, 1, -1, -1, -1, 1, 40, 114, -1, -1, 17, 4, -10, 100, -1, 188, 140, 55, -1, 85, 66, 17692, 1548820, -1, -1, "scy", "wsc", "9wc", "7wc", "stf", "stf", 5, "2hsl", 2, 4, -1, -1, -1, -1, "flpwsc", "invwsc", "", "", 1, 6, 0, "2 square reach", 0, "item_woodweaponlarge", 12, "item_woodweaponlarge", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 2, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Walking Stick", "staf", "", "6ss", "bst", "6ss", 100, -1, 2, 1, -1, -1, -1, 1, 69, 85, -1, -1, 17, 1, -10, 100, -1, 25, -1, 20, -1, 58, 43, 8154, 504432, 1, -1, "bst", "sst", "8ss", "6ss", "stf", "stf", 5, "club", 1, 3, -1, -1, -1, -1, "flpsst", "invsst", "", "", 1, 2, 0, "magically charged", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Stalagmite", "staf", "", "6ls", "sst", "6ls", 100, -1, 2, 1, -1, -1, -1, 1, 75, 107, -1, -1, 17, 1, 10, 100, -1, 63, 35, 30, -1, 66, 49, 5367, 389722, 1, -1, "sst", "lst", "8ls", "6ls", "stf", "stf", 5, "staf", 1, 4, -1, -1, -1, -1, "flplst", "invlst", "", "", 1, 3, 0, "magically charged", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Elder Staff", "staf", "", "6cs", "cst", "6cs", 100, -1, 2, 1, -1, -1, -1, 1, 80, 93, -1, -1, 17, 1, -1, 100, -1, 44, 37, 35, -1, 74, 55, 9048, 709052, 1, -1, "cst", "cst", "8cs", "6cs", "stf", "stf", 5, "staf", 1, 4, -1, -1, -1, -1, "flpcst", "invcst", "invcstu", "invcstu", 1, 4, 0, "magically charged", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Shillelah", "staf", "", "6bs", "sst", "6bs", 100, -1, 2, 1, -1, -1, -1, 1, 65, 108, -1, -1, 17, 1, -1, 100, -1, 52, 27, 40, -1, 83, 62, 7986, 706838, 1, -1, "sst", "bst", "8bs", "6bs", "stf", "stf", 5, "staf", 1, 4, -1, -1, -1, -1, "flpbst", "invbst", "", "", 1, 4, 0, "magically charged", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Archon Staff", "staf", "", "6ws", "lst", "6ws", 100, -1, 2, 1, -1, -1, -1, 1, 83, 99, -1, -1, 17, 1, 10, 100, -1, 34, -1, 26, -1, 85, 66, 10001, 895085, 1, -1, "lst", "wst", "8ws", "6ws", "stf", "stf", 5, "staf", 2, 4, -1, -1, -1, -1, "flpwst", "invwst", "", "", 1, 6, 0, "magically charged", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Spider Bow", "bow", "", "6sb", "sbw", "6sb", 100, -1, 2, 1, -1, -1, -1, 1, 23, 50, -1, -1, 13, -1, 5, -1, 100, 64, 143, 20, 1, 55, 41, 21091, 1190005, -1, -1, "sbw", "sbw", "8sb", "6sb", "bow", "bow", 6, "bow", 2, 3, -1, -1, -1, -1, "flpsbw", "invsbw", "", "", 1, 3, 0, "", 0, "item_bow", 12, "item_bow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Blade Bow", "bow", "", "6hb", "sbw", "6hb", 100, -1, 2, 1, -1, -1, -1, 1, 21, 41, -1, -1, 13, -1, -10, -1, 100, 76, 119, 32, 1, 60, 45, 21350, 1313500, -1, -1, "sbw", "hbw", "8hb", "6hb", "bow", "bow", 6, "bow", 2, 3, -1, -1, -1, -1, "flphbw", "invhbw", "", "", 1, 4, 0, "", 0, "item_bow", 12, "item_bow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Shadow Bow", "bow", "", "6lb", "lbw", "6lb", 100, -1, 2, 1, -1, -1, -1, 1, 15, 59, -1, -1, 13, -1, -1, -1, 100, 52, 188, 28, 1, 63, 47, 25610, 1647430, -1, -1, "lbw", "lbw", "8lb", "6lb", "bow", "bow", 6, "bow", 2, 4, -1, -1, -1, -1, "flplbw", "invlbw", "", "", 1, 5, 0, "", 0, "item_bow", 12, "item_bow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Great Bow", "bow", "", "6cb", "lbw", "6cb", 100, -1, 2, 1, -1, -1, -1, 1, 12, 52, -1, -1, 13, -1, -10, -1, 100, 121, 107, 36, 1, 68, 51, 17743, 1243024, -1, -1, "lbw", "cbw", "8cb", "6cb", "bow", "bow", 6, "bow", 2, 3, -1, -1, -1, -1, "flpcbw", "invcbw", "invcbwu", "invcbwu", 1, 4, 0, "", 0, "item_bow", 12, "item_bow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Diamond Bow", "bow", "", "6s7", "sbb", "6s7", 100, -1, 2, 1, -1, -1, -1, 1, 33, 40, -1, -1, 13, -1, -1, -1, 100, 89, 132, 40, 1, 72, 54, 24605, 1810060, -1, -1, "sbb", "sbb", "8s8", "6s7", "bow", "bow", 6, "bow", 2, 3, -1, -1, -1, -1, "flpsbb", "invsbb", "invsbbu", "invsbbu", 1, 5, 0, "", 0, "item_bow", 12, "item_bow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Crusader Bow", "bow", "", "6l7", "lbb", "6l7", 100, -1, 2, 1, -1, -1, -1, 1, 15, 63, -1, -1, 13, -1, 10, -1, 100, 97, 121, 44, 1, 77, 57, 18105, 1435085, -1, -1, "lbb", "lbb", "8l8", "6l7", "bow", "bow", 6, "bow", 2, 4, -1, -1, -1, -1, "flplbb", "invlbb", "", "", 1, 6, 0, "", 0, "item_bow", 12, "item_bow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Ward Bow", "bow", "", "6sw", "sbb", "6sw", 100, -1, 2, 1, -1, -1, -1, 1, 20, 53, -1, -1, 13, -1, -1, -1, 100, 72, 146, 48, 1, 80, 60, 15042, 1245860, -1, -1, "sbb", "swb", "8sw", "6sw", "bow", "bow", 6, "bow", 2, 3, -1, -1, -1, -1, "flpswb", "invswb", "invswbu", "invswbu", 1, 5, 0, "", 0, "item_bow", 12, "item_bow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Hydra Bow", "bow", "", "6lw", "lbb", "6lw", 100, -1, 2, 1, -1, -1, -1, 1, 10, 68, -1, -1, 13, -1, 10, -1, 100, 134, 167, 55, 1, 85, 63, 19375, 1691875, -1, -1, "lbb", "lwb", "8lw", "6lw", "bow", "bow", 6, "bow", 2, 4, -1, -1, -1, -1, "flplwb", "invlwb", "", "", 1, 6, 0, "", 0, "item_bow", 12, "item_bow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Pellet Bow", "xbow", "", "6lx", "lxb", "6lx", 100, -1, 2, 1, -1, -1, -1, 1, 28, 73, -1, -1, 19, -1, -10, -1, 100, 83, 155, 30, 1, 57, 42, 19512, 1143184, -1, -1, "lxb", "lxb", "8lx", "6lx", "xbw", "xbw", 5, "xbow", 2, 3, -1, -1, -1, -1, "flplxb", "invlxb", "invlxbu", "invlxbu", 1, 3, 0, "reload lag between shots", 0, "item_crossbow", 12, "item_crossbow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Gorgon Crossbow", "xbow", "", "6mx", "lxb", "6mx", 100, -1, 2, 1, -1, -1, -1, 1, 25, 87, -1, -1, 19, -1, -1, -1, 100, 117, 105, 40, 1, 67, 50, 22305, 1530435, -1, -1, "lxb", "mxb", "8mx", "6mx", "xbw", "xbw", 5, "xbow", 2, 3, -1, -1, -1, -1, "flpmxb", "invmxb", "invmxbu", "invmxbu", 1, 4, 0, "reload lag between shots", 0, "item_crossbow", 12, "item_crossbow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Colossus Crossbow", "xbow", "", "6hx", "hxb", "6hx", 100, -1, 2, 1, -1, -1, -1, 1, 32, 91, -1, -1, 19, -1, 10, -1, 100, 163, 77, 50, 1, 75, 56, 26065, 1994875, -1, -1, "hxb", "hxb", "8hx", "6hx", "xbw", "xbw", 5, "xbow", 2, 4, -1, -1, -1, -1, "flphxb", "invhxb", "invhxbu", "invhxbu", 1, 6, 0, "reload lag between shots", 0, "item_crossbow", 12, "item_crossbow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Demon Crossbow", "xbow", "", "6rx", "hxb", "6rx", 100, -1, 2, 1, -1, -1, -1, 1, 26, 40, -1, -1, 19, -1, -60, -1, 100, 141, 98, 40, 1, 84, 63, 25851, 2215984, -1, -1, "hxb", "rxb", "8rx", "6rx", "xbw", "xbw", 5, "xbow", 2, 3, -1, -1, -1, -1, "flprxb", "invrxb", "invrxbu", "invrxbu", 1, 5, 0, "fires 5 shots before reload", 0, "item_crossbow", 12, "item_crossbow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Eagle Orb", "orb", "", "ob1", "ob1", "ob1", 100, -1, 2, 1, 2, 5, -1, -1, -1, -1, -1, -1, 14, -1, -10, 100, -1, -1, -1, 20, -1, 1, 0, 168, 3168, 1, 303, "bst", "ob1", "ob6", "obb", "1hs", "1hs", 5, "1hss", 1, 2, -1, -1, -1, -1, "flpob1", "invob1", "", "", 1, 4, 0, "", 0, "item_orb", 12, "item_orb", 0, 0, 5, 0, 1, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Sacred Globe", "orb", "", "ob2", "ob1", "ob2", 100, -1, 3, 1, 3, 8, -1, -1, -1, -1, -1, -1, 14, -1, -10, 100, -1, -1, -1, 30, -1, 8, 0, 463, 10204, 1, 303, "bst", "ob2", "ob7", "obc", "1hs", "1hs", 5, "1hss", 1, 2, -1, -1, -1, -1, "flpob1", "invob2", "", "", 1, 4, 0, "", 0, "item_orb", 12, "item_orb", 0, 0, 5, 0, 1, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Smoked Sphere", "orb", "", "ob3", "ob3", "ob3", 100, -1, 3, 1, 4, 10, -1, -1, -1, -1, -1, -1, 14, -1, -1, 100, -1, -1, -1, 35, -1, 12, 8, 766, 17692, 1, 303, "bst", "ob3", "ob8", "obd", "1hs", "1hs", 5, "1hss", 1, 2, -1, -1, -1, -1, "flpob3", "invob3", "", "", 1, 4, 0, "", 0, "item_orb", 12, "item_orb", 0, 0, 5, 0, 1, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Clasped Orb", "orb", "", "ob4", "ob4", "ob4", 100, -1, 4, 1, 5, 12, -1, -1, -1, -1, -1, -1, 14, -1, -1, 100, -1, -1, -1, 40, -1, 17, 13, 1223, 31791, 1, 303, "bst", "ob4", "ob9", "obe", "1hs", "1hs", 5, "1hss", 1, 2, -1, -1, -1, -1, "flpob4", "invob4", "", "", 1, 4, 0, "", 0, "item_orb", 12, "item_orb", 0, 0, 5, 0, 1, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Dragon Stone", "orb", "", "ob5", "ob4", "ob5", 100, -1, 5, 1, 8, 18, -1, -1, -1, -1, -1, -1, 14, -1, 10, 100, -1, -1, -1, 50, -1, 24, 18, 1985, 62140, 1, 303, "bst", "ob5", "oba", "obf", "1hs", "1hs", 5, "1hss", 1, 3, -1, -1, -1, -1, "flpob5", "invob5", "", "", 1, 4, 0, "", 0, "item_orb", 12, "item_orb", 0, 0, 5, 0, 1, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Stag Bow", "abow", "", "am1", "am1", "am1", 100, -1, 3, 1, -1, -1, -1, 1, 7, 12, -1, -1, 13, -1, -1, -1, 100, 30, 45, 48, 1, 18, 14, 2500, 56500, -1, 300, "sbw", "am1", "am6", "amb", "bow", "bow", 6, "bow", 2, 4, -1, -1, -1, -1, "flpam1", "invam1", "invswbu", "invswbu", 1, 5, 0, "", 0, "item_bow", 12, "item_bow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 20, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Reflex Bow", "abow", "", "am2", "am2", "am2", 100, -1, 3, 1, -1, -1, -1, 1, 9, 19, -1, -1, 13, -1, 10, -1, 100, 35, 60, 55, 1, 27, 20, 3575, 112525, -1, 300, "sbw", "am2", "am7", "amc", "bow", "bow", 6, "bow", 2, 4, -1, -1, -1, -1, "flpam2", "invam2", "", "", 1, 5, 0, "", 0, "item_bow", 12, "item_bow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Maiden Spear", "aspe", "", "am3", "am3", "am3", 100, -1, 3, 1, -1, -1, -1, 1, 18, 24, -1, -1, 15, 4, -1, 80, 50, 54, 40, 28, -1, 18, 14, 1672, 41596, -1, 302, "spr", "am3", "am8", "amd", "2ht", "2ht", 5, "2ht", 2, 4, -1, -1, -1, -1, "flpam3", "invam3", "", "", 1, 6, 0, "2 square reach", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Maiden Pike", "aspe", "", "am4", "pik", "am4", 100, -1, 3, 1, -1, -1, -1, 1, 23, 55, -1, -1, 15, 4, 10, 80, 50, 63, 52, 25, -1, 27, 20, 2023, 70621, -1, 302, "spr", "am4", "am9", "ame", "2ht", "2ht", 5, "2ht", 2, 4, -1, -1, -1, -1, "flppik", "invam4", "", "", 1, 6, 0, "3 square reach", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Maiden Javelin", "ajav", "", "am5", "pil", "am5", 100, -1, 3, 1, 8, 14, -1, -1, -1, -1, 6, 22, 15, 2, -10, 80, 50, 33, 47, 6, -1, 23, 17, 48, 15104, -1, 302, "jav", "am5", "ama", "amf", "1ht", "1ht", 5, "1ht", 1, 3, 1, 32, 80, 80, "flpam5", "invam5", "", "", -1, -1, 0, "primarily thrown", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 371, 7, 2, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Glowing Orb", "orb", "", "ob6", "ob1", "ob6", 100, -1, 2, 1, 8, 21, -1, -1, -1, -1, -1, -1, 14, -1, -10, 100, -1, -1, -1, 20, -1, 32, 24, 804, 44228, 1, 303, "bst", "ob1", "ob6", "obb", "1hs", "1hs", 5, "1hss", 1, 2, -1, -1, -1, -1, "flpob1", "invob1", "", "", 1, 4, 0, "", 0, "item_orb", 12, "item_orb", 0, 0, 5, 0, 1, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Crystalline Globe", "orb", "", "ob7", "ob1", "ob7", 100, -1, 3, 1, 10, 26, -1, -1, -1, -1, -1, -1, 14, -1, -10, 100, -1, -1, -1, 30, -1, 37, 27, 1689, 83493, 1, 303, "bst", "ob2", "ob7", "obc", "1hs", "1hs", 5, "1hss", 1, 2, -1, -1, -1, -1, "flpob1", "invob2", "", "", 1, 4, 0, "", 0, "item_orb", 12, "item_orb", 0, 0, 5, 0, 1, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Cloudy Sphere", "orb", "", "ob8", "ob3", "ob8", 100, -1, 3, 1, 11, 29, -1, -1, -1, -1, -1, -1, 14, -1, -1, 100, -1, -1, -1, 35, -1, 41, 30, 2598, 129518, 1, 303, "bst", "ob3", "ob8", "obd", "1hs", "1hs", 5, "1hss", 1, 2, -1, -1, -1, -1, "flpob3", "invob3", "", "", 1, 4, 0, "", 0, "item_orb", 12, "item_orb", 0, 0, 5, 0, 1, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Sparkling Ball", "orb", "", "ob9", "ob4", "ob9", 100, -1, 4, 1, 13, 32, -1, -1, -1, -1, -1, -1, 14, -1, -1, 100, -1, -1, -1, 40, -1, 46, 34, 3969, 208074, 1, 303, "bst", "ob4", "ob9", "obe", "1hs", "1hs", 5, "1hss", 1, 2, -1, -1, -1, -1, "flpob4", "invob4", "", "", 1, 4, 0, "", 0, "item_orb", 12, "item_orb", 0, 0, 5, 0, 1, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Swirling Crystal", "orb", "", "oba", "ob4", "oba", 100, -1, 5, 1, 18, 42, -1, -1, -1, -1, -1, -1, 14, -1, 10, 100, -1, -1, -1, 50, -1, 50, 37, 6255, 340250, 1, 303, "bst", "ob5", "oba", "obf", "1hs", "1hs", 5, "1hss", 1, 3, -1, -1, -1, -1, "flpob5", "invob5", "", "", 1, 4, 0, "", 0, "item_orb", 12, "item_orb", 0, 0, 5, 0, 1, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Ashwood Bow", "abow", "", "am6", "am1", "am6", 100, -1, 3, 1, -1, -1, -1, 1, 16, 29, -1, -1, 13, -1, -1, -1, 100, 56, 77, 48, 1, 39, 29, 7800, 326200, -1, 300, "sbw", "am1", "am6", "amb", "bow", "bow", 6, "bow", 2, 4, -1, -1, -1, -1, "flpam1", "invam1", "invswbu", "invswbu", 1, 5, 0, "", 0, "item_bow", 12, "item_bow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Ceremonial Bow", "abow", "", "am7", "am2", "am7", 100, -1, 3, 1, -1, -1, -1, 1, 19, 41, -1, -1, 13, -1, 10, -1, 100, 73, 110, 55, 1, 47, 35, 11025, 544175, -1, 300, "sbw", "am2", "am7", "amc", "bow", "bow", 6, "bow", 2, 4, -1, -1, -1, -1, "flpam2", "invam2", "", "", 1, 5, 0, "", 0, "item_bow", 12, "item_bow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Ceremonial Spear", "aspe", "", "am8", "am3", "am8", 100, -1, 3, 1, -1, -1, -1, 1, 34, 51, -1, -1, 15, 4, -1, 80, 50, 101, 80, 28, -1, 43, 32, 5316, 252588, -1, 302, "spr", "am3", "am8", "amd", "2ht", "2ht", 5, "2ht", 2, 4, -1, -1, -1, -1, "flpam3", "invam3", "", "", 1, 6, 0, "2 square reach", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Ceremonial Pike", "aspe", "", "am9", "pik", "am9", 100, -1, 3, 1, -1, -1, -1, 1, 42, 101, -1, -1, 15, 4, 20, 80, 50, 115, 98, 25, -1, 51, 38, 6369, 352819, -1, 302, "spr", "am4", "am9", "ame", "2ht", "2ht", 5, "2ht", 2, 4, -1, -1, -1, -1, "flppik", "invam4", "", "", 1, 6, 0, "3 square reach", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Ceremonial Javelin", "ajav", "", "ama", "pil", "ama", 100, -1, 3, 1, 18, 35, -1, -1, -1, -1, 18, 54, 15, 2, -10, 80, 50, 25, 109, 6, -1, 35, 26, 444, 35540, -1, 302, "jav", "am5", "ama", "amf", "1ht", "1ht", 5, "1ht", 1, 3, 1, 32, 80, 80, "flpam5", "invam5", "", "", -1, -1, 0, "primarily thrown", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 371, 7, 2, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Heavenly Stone", "orb", "", "obb", "ob1", "obb", 100, -1, 2, 1, 21, 46, -1, -1, -1, -1, -1, -1, 14, -1, -10, 100, -1, -1, -1, 20, -1, 59, 44, 21051, 1274009, 1, 303, "bst", "ob1", "ob6", "obb", "1hs", "1hs", 5, "1hss", 1, 2, -1, -1, -1, -1, "flpob1", "invob1", "", "", 1, 4, 0, "", 0, "item_orb", 12, "item_orb", 0, 0, 5, 0, 1, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Eldritch Orb", "orb", "", "obc", "ob1", "obc", 100, -1, 3, 1, 18, 50, -1, -1, -1, -1, -1, -1, 14, -1, -10, 100, -1, -1, -1, 30, -1, 67, 50, 19367, 1333589, 1, 303, "bst", "ob2", "ob7", "obc", "1hs", "1hs", 5, "1hss", 1, 2, -1, -1, -1, -1, "flpob1", "invob2", "", "", 1, 4, 0, "", 0, "item_orb", 12, "item_orb", 0, 0, 5, 0, 1, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Demon Heart", "orb", "", "obd", "ob3", "obd", 100, -1, 3, 1, 23, 55, -1, -1, -1, -1, -1, -1, 14, -1, -1, 100, -1, -1, -1, 35, -1, 75, 56, 22094, 1697050, 1, 303, "bst", "ob3", "ob8", "obd", "1hs", "1hs", 5, "1hss", 1, 2, -1, -1, -1, -1, "flpob3", "invob3", "", "", 1, 4, 0, "", 0, "item_orb", 12, "item_orb", 0, 0, 5, 0, 1, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Vortex Orb", "orb", "", "obe", "ob4", "obe", 100, -1, 4, 1, 12, 66, -1, -1, -1, -1, -1, -1, 14, -1, -1, 100, -1, -1, -1, 40, -1, 84, 63, 25207, 2161888, 1, 303, "bst", "ob4", "ob9", "obe", "1hs", "1hs", 5, "1hss", 1, 2, -1, -1, -1, -1, "flpob4", "invob4", "", "", 1, 4, 0, "", 0, "item_orb", 12, "item_orb", 0, 0, 5, 0, 1, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Dimensional Shard", "orb", "", "obf", "ob4", "obf", 100, -1, 5, 1, 30, 53, -1, -1, -1, -1, -1, -1, 14, -1, 10, 100, -1, -1, -1, 50, -1, 85, 66, 20065, 1750525, 1, 303, "bst", "ob5", "oba", "obf", "1hs", "1hs", 5, "1hss", 1, 3, -1, -1, -1, -1, "flpob5", "invob5", "", "", 1, 4, 0, "", 0, "item_orb", 12, "item_orb", 0, 0, 5, 0, 1, 0, -1, -1, 0, 7, 0, 0, 5, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Matriarchal Bow", "abow", "", "amb", "am1", "amb", 100, -1, 3, 1, -1, -1, -1, 1, 20, 47, -1, -1, 13, -1, -10, -1, 100, 87, 187, 48, 1, 53, 39, 23700, 1285100, -1, 300, "sbw", "am1", "am6", "amb", "bow", "bow", 6, "bow", 2, 4, -1, -1, -1, -1, "flpam1", "invam1", "invswbu", "invswbu", 1, 5, 0, "", 0, "item_bow", 12, "item_bow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Grand Matron Bow", "abow", "", "amc", "am2", "amc", 100, -1, 3, 1, -1, -1, -1, 1, 14, 72, -1, -1, 13, -1, 10, -1, 100, 108, 152, 55, 1, 78, 58, 33375, 2644750, -1, 300, "sbw", "am2", "am7", "amc", "bow", "bow", 6, "bow", 2, 4, -1, -1, -1, -1, "flpam2", "invam2", "", "", 1, 5, 0, "", 0, "item_bow", 12, "item_bow", 0, 0, 5, 1, 0, 0, -1, -1, 0, 7, 0, 0, 1, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Matriarchal Spear", "aspe", "", "amd", "am3", "amd", 100, -1, 3, 1, -1, -1, -1, 1, 65, 95, -1, -1, 15, 4, -1, 80, 50, 114, 142, 28, -1, 61, 45, 16248, 1024128, -1, 302, "spr", "am3", "am8", "amd", "2ht", "2ht", 5, "2ht", 2, 4, -1, -1, -1, -1, "flpam3", "invam3", "", "", 1, 6, 0, "2 square reach", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Matriarchal Pike", "aspe", "", "ame", "pik", "ame", 100, -1, 3, 1, -1, -1, -1, 1, 37, 153, -1, -1, 15, 4, 20, 80, 50, 132, 149, 25, -1, 81, 60, 19407, 1614967, -1, 302, "spr", "am4", "am9", "ame", "2ht", "2ht", 5, "2ht", 2, 4, -1, -1, -1, -1, "flppik", "invam4", "", "", 1, 6, 0, "3 square reach", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 0, 7, 0, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 5, 8, 0, "xxx", "xxx", 1, 0),
			new BaseWeapon(BaseItem.ItemCount++, "Matriarchal Javelin", "ajav", "", "amf", "pil", "amf", 100, -1, 3, 1, 30, 54, -1, -1, -1, -1, 35, 66, 15, 2, -10, 80, 50, 107, 151, 6, -1, 65, 48, 302, 54630, -1, 302, "jav", "am5", "ama", "amf", "1ht", "1ht", 5, "1ht", 1, 3, 1, 32, 80, 80, "flpam5", "invam5", "", "", -1, -1, 0, "primarily thrown", 0, "item_staff", 12, "item_staff", 0, 0, 5, 0, 0, 0, -1, -1, 371, 7, 2, 0, 3, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, -1, -1, 255, -1, -1, 1, 2, 0, "xxx", "xxx", 1, 0)
		};
	}
}
