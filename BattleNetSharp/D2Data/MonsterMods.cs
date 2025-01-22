using System;

namespace D2Data
{
	// Token: 0x02000957 RID: 2391
	[Flags]
	public enum MonsterMods
	{
		// Token: 0x04007BB7 RID: 31671
		None = 0,
		// Token: 0x04007BB8 RID: 31672
		PhysicalImmune = 1,
		// Token: 0x04007BB9 RID: 31673
		MagicImmune = 2,
		// Token: 0x04007BBA RID: 31674
		FireImmune = 4,
		// Token: 0x04007BBB RID: 31675
		LightningImmune = 8,
		// Token: 0x04007BBC RID: 31676
		ColdImmune = 16,
		// Token: 0x04007BBD RID: 31677
		PoisonImmune = 32,
		// Token: 0x04007BBE RID: 31678
		ExtraStrong = 64,
		// Token: 0x04007BBF RID: 31679
		ExtraFast = 128,
		// Token: 0x04007BC0 RID: 31680
		Cursed = 254,
		// Token: 0x04007BC1 RID: 31681
		MagicResistant = 512,
		// Token: 0x04007BC2 RID: 31682
		FireEnchanted = 1024,
		// Token: 0x04007BC3 RID: 31683
		LightningEnchanted = 2048,
		// Token: 0x04007BC4 RID: 31684
		ColdEnchanted = 4096,
		// Token: 0x04007BC5 RID: 31685
		ManaBurn = 8192,
		// Token: 0x04007BC6 RID: 31686
		Teleportation = 16384,
		// Token: 0x04007BC7 RID: 31687
		SpectralHit = 32768,
		// Token: 0x04007BC8 RID: 31688
		StoneSkin = 65536,
		// Token: 0x04007BC9 RID: 31689
		MultiShot = 131072,
		// Token: 0x04007BCA RID: 31690
		ConvictionAura = 262144,
		// Token: 0x04007BCB RID: 31691
		MightAura = 524288,
		// Token: 0x04007BCC RID: 31692
		HolyFireAura = 1048576,
		// Token: 0x04007BCD RID: 31693
		BlessedAimAura = 2097152,
		// Token: 0x04007BCE RID: 31694
		HolyFreezeAura = 4194304,
		// Token: 0x04007BCF RID: 31695
		HolyShockAura = 8388608,
		// Token: 0x04007BD0 RID: 31696
		FanaticismAura = 16777216
	}
}
