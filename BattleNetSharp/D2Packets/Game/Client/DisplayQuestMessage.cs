using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A2F RID: 2607
	public class DisplayQuestMessage : Packet
	{
		// Token: 0x04008CCB RID: 36043
		public GameClientPacket PacketId;

		// Token: 0x04008CCC RID: 36044
		[MinVersion(GameVersion.D2R)]
		public UnitType UnitType;

		// Token: 0x04008CCD RID: 36045
		[MinVersion(GameVersion.D2R)]
		public ushort MessageD2R;

		// Token: 0x04008CCE RID: 36046
		public uint Id;

		// Token: 0x04008CCF RID: 36047
		[MaxVersion(GameVersion.LOD)]
		public uint MessageLod;
	}
}
