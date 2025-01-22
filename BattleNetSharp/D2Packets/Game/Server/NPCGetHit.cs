using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009D0 RID: 2512
	public class NPCGetHit : Packet
	{
		// Token: 0x04008ACC RID: 35532
		public GameServerPacket PacketId;

		// Token: 0x04008ACD RID: 35533
		public UnitType Type;

		// Token: 0x04008ACE RID: 35534
		public uint Id;

		// Token: 0x04008ACF RID: 35535
		public ushort Animation;

		// Token: 0x04008AD0 RID: 35536
		public byte Life;
	}
}
