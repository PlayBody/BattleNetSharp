using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009C1 RID: 2497
	public class LoadAct : Packet
	{
		// Token: 0x04008A87 RID: 35463
		public GameServerPacket PacketId;

		// Token: 0x04008A88 RID: 35464
		public ActLocation Act;

		// Token: 0x04008A89 RID: 35465
		public uint MapId;

		// Token: 0x04008A8A RID: 35466
		public AreaLevel Area;

		// Token: 0x04008A8B RID: 35467
		public byte Unk1;

		// Token: 0x04008A8C RID: 35468
		public uint Unk2;
	}
}
