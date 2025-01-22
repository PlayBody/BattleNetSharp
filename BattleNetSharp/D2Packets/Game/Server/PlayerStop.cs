using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009ED RID: 2541
	public class PlayerStop : Packet
	{
		// Token: 0x04008B83 RID: 35715
		public GameServerPacket PacketId;

		// Token: 0x04008B84 RID: 35716
		public UnitType Type;

		// Token: 0x04008B85 RID: 35717
		public uint Id;

		// Token: 0x04008B86 RID: 35718
		public byte Unk;

		// Token: 0x04008B87 RID: 35719
		public ushort X;

		// Token: 0x04008B88 RID: 35720
		public ushort Y;

		// Token: 0x04008B89 RID: 35721
		public byte Un2;

		// Token: 0x04008B8A RID: 35722
		public byte Life;
	}
}
