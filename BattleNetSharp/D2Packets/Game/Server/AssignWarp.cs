using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009A3 RID: 2467
	public class AssignWarp : Packet
	{
		// Token: 0x04008953 RID: 35155
		public GameServerPacket PacketId;

		// Token: 0x04008954 RID: 35156
		public UnitType Type;

		// Token: 0x04008955 RID: 35157
		public uint Id;

		// Token: 0x04008956 RID: 35158
		public WarpType Warp;

		// Token: 0x04008957 RID: 35159
		public ushort X;

		// Token: 0x04008958 RID: 35160
		public ushort Y;
	}
}
