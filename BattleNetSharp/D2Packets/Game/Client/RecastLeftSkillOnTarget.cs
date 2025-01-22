using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A4E RID: 2638
	public class RecastLeftSkillOnTarget : Packet
	{
		// Token: 0x04008E22 RID: 36386
		public GameClientPacket PacketId;

		// Token: 0x04008E23 RID: 36387
		public UnitType Type;

		// Token: 0x04008E24 RID: 36388
		public byte unk1;

		// Token: 0x04008E25 RID: 36389
		public byte unk2;

		// Token: 0x04008E26 RID: 36390
		public byte unk3;

		// Token: 0x04008E27 RID: 36391
		public uint Id;
	}
}
