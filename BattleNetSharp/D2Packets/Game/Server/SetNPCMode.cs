using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x02000A00 RID: 2560
	public class SetNPCMode : Packet
	{
		// Token: 0x04008BE7 RID: 35815
		public GameServerPacket PacketId;

		// Token: 0x04008BE8 RID: 35816
		public uint Id;

		// Token: 0x04008BE9 RID: 35817
		public NPCMode Mode;

		// Token: 0x04008BEA RID: 35818
		public ushort X;

		// Token: 0x04008BEB RID: 35819
		public ushort Y;

		// Token: 0x04008BEC RID: 35820
		public byte Life;

		// Token: 0x04008BED RID: 35821
		public byte unk;
	}
}
