using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A56 RID: 2646
	public class RequestReassign : Packet
	{
		// Token: 0x04008E4F RID: 36431
		public GameClientPacket PacketId;

		// Token: 0x04008E50 RID: 36432
		public UnitType Type;

		// Token: 0x04008E51 RID: 36433
		public byte unk1 = 0;

		// Token: 0x04008E52 RID: 36434
		public byte unk2 = 0;

		// Token: 0x04008E53 RID: 36435
		public byte unk3 = 0;

		// Token: 0x04008E54 RID: 36436
		public uint Id;
	}
}
