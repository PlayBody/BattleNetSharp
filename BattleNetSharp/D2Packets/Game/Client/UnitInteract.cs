using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A7A RID: 2682
	public class UnitInteract : Packet
	{
		// Token: 0x04008F1F RID: 36639
		public GameClientPacket PacketId;

		// Token: 0x04008F20 RID: 36640
		[MaxVersion(GameVersion.LOD)]
		public UnitType Type;

		// Token: 0x04008F21 RID: 36641
		[MaxVersion(GameVersion.LOD)]
		public ushort _pad0 = 0;

		// Token: 0x04008F22 RID: 36642
		[MaxVersion(GameVersion.LOD)]
		public byte _pad1 = 0;

		// Token: 0x04008F23 RID: 36643
		public uint Id;

		// Token: 0x04008F24 RID: 36644
		[MinVersion(GameVersion.D2R)]
		public uint myId;
	}
}
