using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009AF RID: 2479
	public class EndState : Packet
	{
		// Token: 0x04008987 RID: 35207
		public GameServerPacket PacketId;

		// Token: 0x04008988 RID: 35208
		public UnitType Type;

		// Token: 0x04008989 RID: 35209
		[MinVersion(GameVersion.D2R)]
		public ushort StateD2R;

		// Token: 0x0400898A RID: 35210
		public uint Id;

		// Token: 0x0400898B RID: 35211
		[MaxVersion(GameVersion.LOD)]
		public byte StateLOD;
	}
}
