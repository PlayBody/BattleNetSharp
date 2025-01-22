using System;

namespace D4Packets.Game.Client
{
	// Token: 0x02000892 RID: 2194
	[D4Packet.OpcodeAttribute(Opcodes.SMSG_MAP_REVEAL_SCENE)]
	public class MapRevealScene : D4Packet
	{
		// Token: 0x0400645B RID: 25691
		public uint snoScene;

		// Token: 0x0400645C RID: 25692
		public AABB aabb;

		// Token: 0x0400645D RID: 25693
		public ulong idSWorld;

		// Token: 0x0400645E RID: 25694
		public bool bRevealed;

		// Token: 0x0400645F RID: 25695
		public byte _08a2f554;

		// Token: 0x04006460 RID: 25696
		public bool bExterior;

		// Token: 0x04006461 RID: 25697
		[DynamicLen(3)]
		public uint[] N_006646a2;

		// Token: 0x04006462 RID: 25698
		public uint? snoLevelArea;
	}
}
