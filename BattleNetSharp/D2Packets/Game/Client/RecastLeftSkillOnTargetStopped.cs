using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A4F RID: 2639
	public class RecastLeftSkillOnTargetStopped : Packet
	{
		// Token: 0x04008E28 RID: 36392
		public GameClientPacket PacketId;

		// Token: 0x04008E29 RID: 36393
		public UnitType Type;

		// Token: 0x04008E2A RID: 36394
		public byte unk1;

		// Token: 0x04008E2B RID: 36395
		public byte unk2;

		// Token: 0x04008E2C RID: 36396
		public byte unk3;

		// Token: 0x04008E2D RID: 36397
		public uint Id;
	}
}
