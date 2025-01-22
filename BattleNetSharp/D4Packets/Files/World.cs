using System;
using System.Collections.Generic;

namespace D4Packets.Files
{
	// Token: 0x0200086C RID: 2156
	public class World : CASCPacket
	{
		// Token: 0x040063D6 RID: 25558
		public Header Header;

		// Token: 0x040063D7 RID: 25559
		public List<WorldServerData> ptServerData;

		// Token: 0x040063D8 RID: 25560
		public uint eLayoutType;

		// Token: 0x040063D9 RID: 25561
		public float flGridSize;

		// Token: 0x040063DA RID: 25562
		public Environment tEnvironment;

		// Token: 0x040063DB RID: 25563
		public float flDeformationScale;

		// Token: 0x040063DC RID: 25564
		public uint uFlags;

		// Token: 0x040063DD RID: 25565
		public uint snoUnk1;

		// Token: 0x040063DE RID: 25566
		public uint snoUnk2;

		// Token: 0x040063DF RID: 25567
		public List<uint> arDRLGLevelAreas;

		// Token: 0x040063E0 RID: 25568
		public bool truefalse;

		// Token: 0x040063E1 RID: 25569
		public List<byte> unk132;

		// Token: 0x040063E2 RID: 25570
		public uint dwAppearanceFlags;

		// Token: 0x040063E3 RID: 25571
		public uint unkEnum;

		// Token: 0x040063E4 RID: 25572
		public MaterialTexture mat1;

		// Token: 0x040063E5 RID: 25573
		public MaterialTexture mat2;

		// Token: 0x040063E6 RID: 25574
		public ulong pad1;

		// Token: 0x040063E7 RID: 25575
		public ulong pad2;

		// Token: 0x040063E8 RID: 25576
		public ulong pad3;

		// Token: 0x040063E9 RID: 25577
		public ulong pad4;

		// Token: 0x040063EA RID: 25578
		public ulong pad5;

		// Token: 0x040063EB RID: 25579
		public float unkF;

		// Token: 0x040063EC RID: 25580
		public ZoneMapParams tZoneMapParams;
	}
}
