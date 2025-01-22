using System;

namespace D2Data
{
	// Token: 0x02000973 RID: 2419
	public enum SkillType : ushort
	{
		// Token: 0x04008074 RID: 32884
		Attack,
		// Token: 0x04008075 RID: 32885
		Kick,
		// Token: 0x04008076 RID: 32886
		Throw,
		// Token: 0x04008077 RID: 32887
		Unsummon,
		// Token: 0x04008078 RID: 32888
		LeftHandThrow,
		// Token: 0x04008079 RID: 32889
		LeftHandSwing,
		// Token: 0x0400807A RID: 32890
		MagicArrow,
		// Token: 0x0400807B RID: 32891
		FireArrow,
		// Token: 0x0400807C RID: 32892
		InnerSight,
		// Token: 0x0400807D RID: 32893
		CriticalStrike,
		// Token: 0x0400807E RID: 32894
		Jab,
		// Token: 0x0400807F RID: 32895
		ColdArrow,
		// Token: 0x04008080 RID: 32896
		MultipleShot,
		// Token: 0x04008081 RID: 32897
		Dodge,
		// Token: 0x04008082 RID: 32898
		PowerStrike,
		// Token: 0x04008083 RID: 32899
		PoisonJavelin,
		// Token: 0x04008084 RID: 32900
		ExplodingArrow,
		// Token: 0x04008085 RID: 32901
		SlowMissiles,
		// Token: 0x04008086 RID: 32902
		Avoid,
		// Token: 0x04008087 RID: 32903
		Impale,
		// Token: 0x04008088 RID: 32904
		LightningBolt,
		// Token: 0x04008089 RID: 32905
		IceArrow,
		// Token: 0x0400808A RID: 32906
		GuidedArrow,
		// Token: 0x0400808B RID: 32907
		Penetrate,
		// Token: 0x0400808C RID: 32908
		ChargedStrike,
		// Token: 0x0400808D RID: 32909
		PlagueJavelin,
		// Token: 0x0400808E RID: 32910
		Strafe,
		// Token: 0x0400808F RID: 32911
		ImmolationArrow,
		// Token: 0x04008090 RID: 32912
		Dopplezon,
		// Token: 0x04008091 RID: 32913
		Evade,
		// Token: 0x04008092 RID: 32914
		Fend,
		// Token: 0x04008093 RID: 32915
		FreezingArrow,
		// Token: 0x04008094 RID: 32916
		Valkyrie,
		// Token: 0x04008095 RID: 32917
		Pierce,
		// Token: 0x04008096 RID: 32918
		LightningStrike,
		// Token: 0x04008097 RID: 32919
		LightningFury,
		// Token: 0x04008098 RID: 32920
		FireBolt,
		// Token: 0x04008099 RID: 32921
		Warmth,
		// Token: 0x0400809A RID: 32922
		ChargedBolt,
		// Token: 0x0400809B RID: 32923
		IceBolt,
		// Token: 0x0400809C RID: 32924
		FrozenArmor,
		// Token: 0x0400809D RID: 32925
		Inferno,
		// Token: 0x0400809E RID: 32926
		StaticField,
		// Token: 0x0400809F RID: 32927
		Telekinesis,
		// Token: 0x040080A0 RID: 32928
		FrostNova,
		// Token: 0x040080A1 RID: 32929
		IceBlast,
		// Token: 0x040080A2 RID: 32930
		Blaze,
		// Token: 0x040080A3 RID: 32931
		FireBall,
		// Token: 0x040080A4 RID: 32932
		Nova,
		// Token: 0x040080A5 RID: 32933
		Lightning,
		// Token: 0x040080A6 RID: 32934
		ShiverArmor,
		// Token: 0x040080A7 RID: 32935
		FireWall,
		// Token: 0x040080A8 RID: 32936
		Enchant,
		// Token: 0x040080A9 RID: 32937
		ChainLightning,
		// Token: 0x040080AA RID: 32938
		Teleport,
		// Token: 0x040080AB RID: 32939
		GlacialSpike,
		// Token: 0x040080AC RID: 32940
		Meteor,
		// Token: 0x040080AD RID: 32941
		ThunderStorm,
		// Token: 0x040080AE RID: 32942
		EnergyShield,
		// Token: 0x040080AF RID: 32943
		Blizzard,
		// Token: 0x040080B0 RID: 32944
		ChillingArmor,
		// Token: 0x040080B1 RID: 32945
		FireMastery,
		// Token: 0x040080B2 RID: 32946
		Hydra,
		// Token: 0x040080B3 RID: 32947
		LightningMastery,
		// Token: 0x040080B4 RID: 32948
		FrozenOrb,
		// Token: 0x040080B5 RID: 32949
		ColdMastery,
		// Token: 0x040080B6 RID: 32950
		AmplifyDamage,
		// Token: 0x040080B7 RID: 32951
		Teeth,
		// Token: 0x040080B8 RID: 32952
		BoneArmor,
		// Token: 0x040080B9 RID: 32953
		SkeletonMastery,
		// Token: 0x040080BA RID: 32954
		RaiseSkeleton,
		// Token: 0x040080BB RID: 32955
		DimVision,
		// Token: 0x040080BC RID: 32956
		Weaken,
		// Token: 0x040080BD RID: 32957
		PoisonDagger,
		// Token: 0x040080BE RID: 32958
		CorpseExplosion,
		// Token: 0x040080BF RID: 32959
		ClayGolem,
		// Token: 0x040080C0 RID: 32960
		IronMaiden,
		// Token: 0x040080C1 RID: 32961
		Terror,
		// Token: 0x040080C2 RID: 32962
		BoneWall,
		// Token: 0x040080C3 RID: 32963
		GolemMastery,
		// Token: 0x040080C4 RID: 32964
		RaiseSkeletalMage,
		// Token: 0x040080C5 RID: 32965
		Confuse,
		// Token: 0x040080C6 RID: 32966
		LifeTap,
		// Token: 0x040080C7 RID: 32967
		PoisonExplosion,
		// Token: 0x040080C8 RID: 32968
		BoneSpear,
		// Token: 0x040080C9 RID: 32969
		Bloodgolem,
		// Token: 0x040080CA RID: 32970
		Attract,
		// Token: 0x040080CB RID: 32971
		Decrepify,
		// Token: 0x040080CC RID: 32972
		BonePrison,
		// Token: 0x040080CD RID: 32973
		SummonResist,
		// Token: 0x040080CE RID: 32974
		IronGolem,
		// Token: 0x040080CF RID: 32975
		LowerResist,
		// Token: 0x040080D0 RID: 32976
		PoisonNova,
		// Token: 0x040080D1 RID: 32977
		BoneSpirit,
		// Token: 0x040080D2 RID: 32978
		Firegolem,
		// Token: 0x040080D3 RID: 32979
		Revive,
		// Token: 0x040080D4 RID: 32980
		Sacrifice,
		// Token: 0x040080D5 RID: 32981
		Smite,
		// Token: 0x040080D6 RID: 32982
		Might,
		// Token: 0x040080D7 RID: 32983
		Prayer,
		// Token: 0x040080D8 RID: 32984
		ResistFire,
		// Token: 0x040080D9 RID: 32985
		HolyBolt,
		// Token: 0x040080DA RID: 32986
		HolyFire,
		// Token: 0x040080DB RID: 32987
		Thorns,
		// Token: 0x040080DC RID: 32988
		Defiance,
		// Token: 0x040080DD RID: 32989
		ResistCold,
		// Token: 0x040080DE RID: 32990
		Zeal,
		// Token: 0x040080DF RID: 32991
		Charge,
		// Token: 0x040080E0 RID: 32992
		BlessedAim,
		// Token: 0x040080E1 RID: 32993
		Cleansing,
		// Token: 0x040080E2 RID: 32994
		ResistLightning,
		// Token: 0x040080E3 RID: 32995
		Vengeance,
		// Token: 0x040080E4 RID: 32996
		BlessedHammer,
		// Token: 0x040080E5 RID: 32997
		Concentration,
		// Token: 0x040080E6 RID: 32998
		HolyFreeze,
		// Token: 0x040080E7 RID: 32999
		Vigor,
		// Token: 0x040080E8 RID: 33000
		Conversion,
		// Token: 0x040080E9 RID: 33001
		HolyShield,
		// Token: 0x040080EA RID: 33002
		HolyShock,
		// Token: 0x040080EB RID: 33003
		Sanctuary,
		// Token: 0x040080EC RID: 33004
		Meditation,
		// Token: 0x040080ED RID: 33005
		FistOfTheHeavens,
		// Token: 0x040080EE RID: 33006
		Fanaticism,
		// Token: 0x040080EF RID: 33007
		Conviction,
		// Token: 0x040080F0 RID: 33008
		Redemption,
		// Token: 0x040080F1 RID: 33009
		Salvation,
		// Token: 0x040080F2 RID: 33010
		Bash,
		// Token: 0x040080F3 RID: 33011
		SwordMastery,
		// Token: 0x040080F4 RID: 33012
		AxeMastery,
		// Token: 0x040080F5 RID: 33013
		MaceMastery,
		// Token: 0x040080F6 RID: 33014
		Howl,
		// Token: 0x040080F7 RID: 33015
		FindPotion,
		// Token: 0x040080F8 RID: 33016
		Leap,
		// Token: 0x040080F9 RID: 33017
		DoubleSwing,
		// Token: 0x040080FA RID: 33018
		PoleArmMastery,
		// Token: 0x040080FB RID: 33019
		ThrowingMastery,
		// Token: 0x040080FC RID: 33020
		SpearMastery,
		// Token: 0x040080FD RID: 33021
		Taunt,
		// Token: 0x040080FE RID: 33022
		Shout,
		// Token: 0x040080FF RID: 33023
		Stun,
		// Token: 0x04008100 RID: 33024
		DoubleThrow,
		// Token: 0x04008101 RID: 33025
		IncreasedStamina,
		// Token: 0x04008102 RID: 33026
		FindItem,
		// Token: 0x04008103 RID: 33027
		LeapAttack,
		// Token: 0x04008104 RID: 33028
		Concentrate,
		// Token: 0x04008105 RID: 33029
		IronSkin,
		// Token: 0x04008106 RID: 33030
		BattleCry,
		// Token: 0x04008107 RID: 33031
		Frenzy,
		// Token: 0x04008108 RID: 33032
		IncreasedSpeed,
		// Token: 0x04008109 RID: 33033
		BattleOrders,
		// Token: 0x0400810A RID: 33034
		GrimWard,
		// Token: 0x0400810B RID: 33035
		Whirlwind,
		// Token: 0x0400810C RID: 33036
		Berserk,
		// Token: 0x0400810D RID: 33037
		NaturalResistance,
		// Token: 0x0400810E RID: 33038
		WarCry,
		// Token: 0x0400810F RID: 33039
		BattleCommand,
		// Token: 0x04008110 RID: 33040
		FireHit,
		// Token: 0x04008111 RID: 33041
		Unholybolt,
		// Token: 0x04008112 RID: 33042
		Skeletonraise,
		// Token: 0x04008113 RID: 33043
		MaggotEgg,
		// Token: 0x04008114 RID: 33044
		ShamanFire,
		// Token: 0x04008115 RID: 33045
		MagottUp,
		// Token: 0x04008116 RID: 33046
		MagottDown,
		// Token: 0x04008117 RID: 33047
		MagottLay,
		// Token: 0x04008118 RID: 33048
		AndrialSpray,
		// Token: 0x04008119 RID: 33049
		Jump,
		// Token: 0x0400811A RID: 33050
		SwarmMove,
		// Token: 0x0400811B RID: 33051
		Nest,
		// Token: 0x0400811C RID: 33052
		QuickStrike,
		// Token: 0x0400811D RID: 33053
		Vampirefireball,
		// Token: 0x0400811E RID: 33054
		Vampirefirewall,
		// Token: 0x0400811F RID: 33055
		Vampiremeteor,
		// Token: 0x04008120 RID: 33056
		GargoyleTrap,
		// Token: 0x04008121 RID: 33057
		SpiderLay,
		// Token: 0x04008122 RID: 33058
		VampireHeal,
		// Token: 0x04008123 RID: 33059
		VampireRaise,
		// Token: 0x04008124 RID: 33060
		SubMerge,
		// Token: 0x04008125 RID: 33061
		FetishAura,
		// Token: 0x04008126 RID: 33062
		FetishInferno,
		// Token: 0x04008127 RID: 33063
		ZakarumHeal,
		// Token: 0x04008128 RID: 33064
		Emerge,
		// Token: 0x04008129 RID: 33065
		Resurrect,
		// Token: 0x0400812A RID: 33066
		Bestow,
		// Token: 0x0400812B RID: 33067
		MissileSkill1,
		// Token: 0x0400812C RID: 33068
		MonsterTeleport,
		// Token: 0x0400812D RID: 33069
		PrimeLightning,
		// Token: 0x0400812E RID: 33070
		PrimeBolt,
		// Token: 0x0400812F RID: 33071
		PrimeBlaze,
		// Token: 0x04008130 RID: 33072
		PrimeFirewall,
		// Token: 0x04008131 RID: 33073
		PrimeSpike,
		// Token: 0x04008132 RID: 33074
		PrimeIceNova,
		// Token: 0x04008133 RID: 33075
		PrimePoisonBall,
		// Token: 0x04008134 RID: 33076
		PrimePoisonNova,
		// Token: 0x04008135 RID: 33077
		DiabloLight,
		// Token: 0x04008136 RID: 33078
		DiabloCold,
		// Token: 0x04008137 RID: 33079
		DiabloFire,
		// Token: 0x04008138 RID: 33080
		FingerMageSpider,
		// Token: 0x04008139 RID: 33081
		DiabloFirestorm,
		// Token: 0x0400813A RID: 33082
		DiabloRun,
		// Token: 0x0400813B RID: 33083
		DiabloPrison,
		// Token: 0x0400813C RID: 33084
		PoisonBallTrap,
		// Token: 0x0400813D RID: 33085
		AndyPoisonBolt,
		// Token: 0x0400813E RID: 33086
		HireableMissile,
		// Token: 0x0400813F RID: 33087
		DesertTurret,
		// Token: 0x04008140 RID: 33088
		ArcaneTower,
		// Token: 0x04008141 RID: 33089
		MonsterBlizzard,
		// Token: 0x04008142 RID: 33090
		Mosquito,
		// Token: 0x04008143 RID: 33091
		Cursedballtrapright,
		// Token: 0x04008144 RID: 33092
		Cursedballtrapleft,
		// Token: 0x04008145 RID: 33093
		MonsterFrozenArmor,
		// Token: 0x04008146 RID: 33094
		MonsterBoneArmor,
		// Token: 0x04008147 RID: 33095
		MonsterBoneSpirit,
		// Token: 0x04008148 RID: 33096
		MonsterCurseCast,
		// Token: 0x04008149 RID: 33097
		HellMeteor,
		// Token: 0x0400814A RID: 33098
		RegurgitatorEat,
		// Token: 0x0400814B RID: 33099
		MonsterFrenzy,
		// Token: 0x0400814C RID: 33100
		QueenDeath,
		// Token: 0x0400814D RID: 33101
		ScrollOfIdentify,
		// Token: 0x0400814E RID: 33102
		BookOfIdentify,
		// Token: 0x0400814F RID: 33103
		ScrollOfTownportal,
		// Token: 0x04008150 RID: 33104
		BookOfTownportal,
		// Token: 0x04008151 RID: 33105
		Raven,
		// Token: 0x04008152 RID: 33106
		PoisonCreeper,
		// Token: 0x04008153 RID: 33107
		Werewolf,
		// Token: 0x04008154 RID: 33108
		ShapeShifting,
		// Token: 0x04008155 RID: 33109
		Firestorm,
		// Token: 0x04008156 RID: 33110
		OakSage,
		// Token: 0x04008157 RID: 33111
		SummonSpiritWolf,
		// Token: 0x04008158 RID: 33112
		Wearbear,
		// Token: 0x04008159 RID: 33113
		MoltenBoulder,
		// Token: 0x0400815A RID: 33114
		ArcticBlast,
		// Token: 0x0400815B RID: 33115
		CycleOfLife,
		// Token: 0x0400815C RID: 33116
		FeralRage,
		// Token: 0x0400815D RID: 33117
		Maul,
		// Token: 0x0400815E RID: 33118
		Fissure,
		// Token: 0x0400815F RID: 33119
		CycloneArmor,
		// Token: 0x04008160 RID: 33120
		HeartOfWolverine,
		// Token: 0x04008161 RID: 33121
		SummonDireWolf,
		// Token: 0x04008162 RID: 33122
		Rabies,
		// Token: 0x04008163 RID: 33123
		FireClaws,
		// Token: 0x04008164 RID: 33124
		Twister,
		// Token: 0x04008165 RID: 33125
		Vines,
		// Token: 0x04008166 RID: 33126
		Hunger,
		// Token: 0x04008167 RID: 33127
		ShockWave,
		// Token: 0x04008168 RID: 33128
		Volcano,
		// Token: 0x04008169 RID: 33129
		Tornado,
		// Token: 0x0400816A RID: 33130
		SpiritOfBarbs,
		// Token: 0x0400816B RID: 33131
		SummonGrizzly,
		// Token: 0x0400816C RID: 33132
		Fury,
		// Token: 0x0400816D RID: 33133
		Armageddon,
		// Token: 0x0400816E RID: 33134
		Hurricane,
		// Token: 0x0400816F RID: 33135
		FireBlast,
		// Token: 0x04008170 RID: 33136
		ClawMastery,
		// Token: 0x04008171 RID: 33137
		PsychicHammer,
		// Token: 0x04008172 RID: 33138
		TigerStrike,
		// Token: 0x04008173 RID: 33139
		DragonTalon,
		// Token: 0x04008174 RID: 33140
		ShockWeb,
		// Token: 0x04008175 RID: 33141
		BladeSentinel,
		// Token: 0x04008176 RID: 33142
		BurstOfSpeed,
		// Token: 0x04008177 RID: 33143
		FistsOfFire,
		// Token: 0x04008178 RID: 33144
		DragonClaw,
		// Token: 0x04008179 RID: 33145
		ChargedBoltSentry,
		// Token: 0x0400817A RID: 33146
		WakeOfFire,
		// Token: 0x0400817B RID: 33147
		WeaponBlock,
		// Token: 0x0400817C RID: 33148
		CloakOfShadows,
		// Token: 0x0400817D RID: 33149
		CobraStrike,
		// Token: 0x0400817E RID: 33150
		BladeFury,
		// Token: 0x0400817F RID: 33151
		Fade,
		// Token: 0x04008180 RID: 33152
		ShadowWarrior,
		// Token: 0x04008181 RID: 33153
		ClawsOfThunder,
		// Token: 0x04008182 RID: 33154
		DragonTail,
		// Token: 0x04008183 RID: 33155
		LightningSentry,
		// Token: 0x04008184 RID: 33156
		WakeOfInferno,
		// Token: 0x04008185 RID: 33157
		MindBlast,
		// Token: 0x04008186 RID: 33158
		BladesOfIce,
		// Token: 0x04008187 RID: 33159
		DragonFlight,
		// Token: 0x04008188 RID: 33160
		DeathSentry,
		// Token: 0x04008189 RID: 33161
		BladeShield,
		// Token: 0x0400818A RID: 33162
		Venom,
		// Token: 0x0400818B RID: 33163
		ShadowMaster,
		// Token: 0x0400818C RID: 33164
		PhoenixStrike,
		// Token: 0x0400818D RID: 33165
		WakeOfDestructionSentry,
		// Token: 0x0400818E RID: 33166
		ImpInferno,
		// Token: 0x0400818F RID: 33167
		ImpFireball,
		// Token: 0x04008190 RID: 33168
		BaalTaunt,
		// Token: 0x04008191 RID: 33169
		BaalCorpseExplode,
		// Token: 0x04008192 RID: 33170
		BaalMonsterSpawn,
		// Token: 0x04008193 RID: 33171
		CatapultChargedBall,
		// Token: 0x04008194 RID: 33172
		CatapultSpikeBall,
		// Token: 0x04008195 RID: 33173
		SuckBlood,
		// Token: 0x04008196 RID: 33174
		CryHelp,
		// Token: 0x04008197 RID: 33175
		HealingVortex,
		// Token: 0x04008198 RID: 33176
		Teleport2,
		// Token: 0x04008199 RID: 33177
		Selfresurrect,
		// Token: 0x0400819A RID: 33178
		VineAttack,
		// Token: 0x0400819B RID: 33179
		OverseerWhip,
		// Token: 0x0400819C RID: 33180
		BarbsAura,
		// Token: 0x0400819D RID: 33181
		WolverineAura,
		// Token: 0x0400819E RID: 33182
		OakSageAura,
		// Token: 0x0400819F RID: 33183
		ImpFireMissile,
		// Token: 0x040081A0 RID: 33184
		Impregnate,
		// Token: 0x040081A1 RID: 33185
		SiegeBeastStomp,
		// Token: 0x040081A2 RID: 33186
		MinionSpawner,
		// Token: 0x040081A3 RID: 33187
		CatapultBlizzard,
		// Token: 0x040081A4 RID: 33188
		CatapultPlague,
		// Token: 0x040081A5 RID: 33189
		CatapultMeteor,
		// Token: 0x040081A6 RID: 33190
		BoltSentry,
		// Token: 0x040081A7 RID: 33191
		CorpseCycler,
		// Token: 0x040081A8 RID: 33192
		DeathMaul,
		// Token: 0x040081A9 RID: 33193
		DefenseCurse,
		// Token: 0x040081AA RID: 33194
		BloodMana,
		// Token: 0x040081AB RID: 33195
		InfernoSentry2,
		// Token: 0x040081AC RID: 33196
		DeathSentry2,
		// Token: 0x040081AD RID: 33197
		SentryLightning,
		// Token: 0x040081AE RID: 33198
		FenrisRage,
		// Token: 0x040081AF RID: 33199
		BaalTentacle,
		// Token: 0x040081B0 RID: 33200
		BaalNova,
		// Token: 0x040081B1 RID: 33201
		BaalInferno,
		// Token: 0x040081B2 RID: 33202
		BaalColdMissiles,
		// Token: 0x040081B3 RID: 33203
		MegaDemonInferno,
		// Token: 0x040081B4 RID: 33204
		EvilHutSpawner,
		// Token: 0x040081B5 RID: 33205
		CountessFirewall,
		// Token: 0x040081B6 RID: 33206
		ImpBolt,
		// Token: 0x040081B7 RID: 33207
		HorrorArcticBlast,
		// Token: 0x040081B8 RID: 33208
		DeathSentryLightning,
		// Token: 0x040081B9 RID: 33209
		VineCycler,
		// Token: 0x040081BA RID: 33210
		BearSmite,
		// Token: 0x040081BB RID: 33211
		Resurrect2,
		// Token: 0x040081BC RID: 33212
		BloodLordFrenzy,
		// Token: 0x040081BD RID: 33213
		BaalTeleport,
		// Token: 0x040081BE RID: 33214
		ImpTeleport,
		// Token: 0x040081BF RID: 33215
		BaalCloneTeleport,
		// Token: 0x040081C0 RID: 33216
		ZakarumLightning,
		// Token: 0x040081C1 RID: 33217
		VampireMissile,
		// Token: 0x040081C2 RID: 33218
		MephistoMissile,
		// Token: 0x040081C3 RID: 33219
		DoomKnightMissile,
		// Token: 0x040081C4 RID: 33220
		RogueMissile,
		// Token: 0x040081C5 RID: 33221
		HydraMissile,
		// Token: 0x040081C6 RID: 33222
		NecromageMissile,
		// Token: 0x040081C7 RID: 33223
		MonsterBow,
		// Token: 0x040081C8 RID: 33224
		MonsterFireArrow,
		// Token: 0x040081C9 RID: 33225
		MonsterColdArrow,
		// Token: 0x040081CA RID: 33226
		MonsterExplodingArrow,
		// Token: 0x040081CB RID: 33227
		MonsterFreezingArrow,
		// Token: 0x040081CC RID: 33228
		MonsterPowerStrike,
		// Token: 0x040081CD RID: 33229
		SuccubusBolt,
		// Token: 0x040081CE RID: 33230
		MephistoFrostNova,
		// Token: 0x040081CF RID: 33231
		MonsterIceSpear,
		// Token: 0x040081D0 RID: 33232
		ShamanIce,
		// Token: 0x040081D1 RID: 33233
		DiabloArmageddon,
		// Token: 0x040081D2 RID: 33234
		Delirium,
		// Token: 0x040081D3 RID: 33235
		NihlathakCorpseExplosion,
		// Token: 0x040081D4 RID: 33236
		SerpentCharge,
		// Token: 0x040081D5 RID: 33237
		TrapNova,
		// Token: 0x040081D6 RID: 33238
		UnHolyBoltEx,
		// Token: 0x040081D7 RID: 33239
		ShamanFireEx,
		// Token: 0x040081D8 RID: 33240
		ImpFireMissileEx,
		// Token: 0x040081D9 RID: 33241
		Invalid = 65534,
		// Token: 0x040081DA RID: 33242
		None
	}
}
