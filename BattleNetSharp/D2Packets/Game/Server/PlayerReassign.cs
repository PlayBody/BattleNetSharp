using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009EB RID: 2539
	public class PlayerReassign : Packet
	{
		// Token: 0x04008B79 RID: 35705
		public GameServerPacket PacketId;

		// Token: 0x04008B7A RID: 35706
		public UnitType Type;

		// Token: 0x04008B7B RID: 35707
		public uint Id;

		// Token: 0x04008B7C RID: 35708
		public ushort X;

		// Token: 0x04008B7D RID: 35709
		public ushort Y;

		// Token: 0x04008B7E RID: 35710
		public byte Reassign;
	}
}
