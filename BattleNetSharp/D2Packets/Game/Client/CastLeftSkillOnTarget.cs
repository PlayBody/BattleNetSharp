using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A27 RID: 2599
	public class CastLeftSkillOnTarget : Packet
	{
		// Token: 0x04008CA5 RID: 36005
		public GameClientPacket PacketId;

		// Token: 0x04008CA6 RID: 36006
		public UnitType Type;

		// Token: 0x04008CA7 RID: 36007
		public byte unk1;

		// Token: 0x04008CA8 RID: 36008
		public byte unk2;

		// Token: 0x04008CA9 RID: 36009
		public byte unk3;

		// Token: 0x04008CAA RID: 36010
		public uint Id;
	}
}
