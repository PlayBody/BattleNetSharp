using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A51 RID: 2641
	public class RecastRightSkillOnTarget : Packet
	{
		// Token: 0x04008E35 RID: 36405
		public GameClientPacket PacketId;

		// Token: 0x04008E36 RID: 36406
		public UnitType Type;

		// Token: 0x04008E37 RID: 36407
		public byte unk1;

		// Token: 0x04008E38 RID: 36408
		public byte unk2;

		// Token: 0x04008E39 RID: 36409
		public byte unk3;

		// Token: 0x04008E3A RID: 36410
		public uint Id;
	}
}
