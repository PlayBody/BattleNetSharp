using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A2A RID: 2602
	public class CastRightSkillOnTarget : Packet
	{
		// Token: 0x04008CB4 RID: 36020
		public GameClientPacket PacketId;

		// Token: 0x04008CB5 RID: 36021
		public UnitType Type;

		// Token: 0x04008CB6 RID: 36022
		public byte unk1;

		// Token: 0x04008CB7 RID: 36023
		public byte unk2;

		// Token: 0x04008CB8 RID: 36024
		public byte unk3;

		// Token: 0x04008CB9 RID: 36025
		public uint Id;
	}
}
