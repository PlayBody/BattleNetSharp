using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A44 RID: 2628
	public class Interact : Packet
	{
		// Token: 0x04008DE8 RID: 36328
		public GameClientPacket PacketId;

		// Token: 0x04008DE9 RID: 36329
		[MaxVersion(GameVersion.LOD)]
		public uint EntityKind;

		// Token: 0x04008DEA RID: 36330
		public uint TargetId;

		// Token: 0x04008DEB RID: 36331
		[MaxVersion(GameVersion.LOD)]
		public uint ItemId;

		// Token: 0x04008DEC RID: 36332
		[MaxVersion(GameVersion.LOD)]
		public uint EntityState;

		// Token: 0x04008DED RID: 36333
		[MinVersion(GameVersion.D2R)]
		public uint Mode;

		// Token: 0x04008DEE RID: 36334
		[MinVersion(GameVersion.D2R)]
		public uint SourceItemId = uint.MaxValue;
	}
}
