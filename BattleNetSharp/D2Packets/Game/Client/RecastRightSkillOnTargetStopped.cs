using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A52 RID: 2642
	public class RecastRightSkillOnTargetStopped : Packet
	{
		// Token: 0x04008E3B RID: 36411
		public GameClientPacket PacketId;

		// Token: 0x04008E3C RID: 36412
		public UnitType Type;

		// Token: 0x04008E3D RID: 36413
		public byte unk1;

		// Token: 0x04008E3E RID: 36414
		public byte unk2;

		// Token: 0x04008E3F RID: 36415
		public byte unk3;

		// Token: 0x04008E40 RID: 36416
		public uint Id;
	}
}
