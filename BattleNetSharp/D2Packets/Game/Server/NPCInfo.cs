using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009D2 RID: 2514
	public class NPCInfo : Packet
	{
		// Token: 0x04008AD5 RID: 35541
		public GameServerPacket PacketId;

		// Token: 0x04008AD6 RID: 35542
		public UnitType Type;

		// Token: 0x04008AD7 RID: 35543
		public uint Id;

		// Token: 0x04008AD8 RID: 35544
		public ulong unk1;

		// Token: 0x04008AD9 RID: 35545
		public ulong unk2;

		// Token: 0x04008ADA RID: 35546
		public ulong unk3;

		// Token: 0x04008ADB RID: 35547
		public ulong unk4;

		// Token: 0x04008ADC RID: 35548
		public ushort unk5;
	}
}
