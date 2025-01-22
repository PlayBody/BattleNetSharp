using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A28 RID: 2600
	public class CastLeftSkillOnTargetStopped : Packet
	{
		// Token: 0x04008CAB RID: 36011
		public GameClientPacket PacketId;

		// Token: 0x04008CAC RID: 36012
		public UnitType Type;

		// Token: 0x04008CAD RID: 36013
		public byte unk1;

		// Token: 0x04008CAE RID: 36014
		public byte unk2;

		// Token: 0x04008CAF RID: 36015
		public byte unk3;

		// Token: 0x04008CB0 RID: 36016
		public uint Id;
	}
}
