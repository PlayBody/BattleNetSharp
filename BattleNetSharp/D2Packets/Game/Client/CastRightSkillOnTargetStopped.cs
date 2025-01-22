using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A2B RID: 2603
	public class CastRightSkillOnTargetStopped : Packet
	{
		// Token: 0x04008CBA RID: 36026
		public GameClientPacket PacketId;

		// Token: 0x04008CBB RID: 36027
		public UnitType Type;

		// Token: 0x04008CBC RID: 36028
		public byte unk1;

		// Token: 0x04008CBD RID: 36029
		public byte unk2;

		// Token: 0x04008CBE RID: 36030
		public byte unk3;

		// Token: 0x04008CBF RID: 36031
		public uint Id;
	}
}
