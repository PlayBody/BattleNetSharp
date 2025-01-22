using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009EE RID: 2542
	public class PlaySound : Packet
	{
		// Token: 0x04008B8B RID: 35723
		public GameServerPacket PacketId;

		// Token: 0x04008B8C RID: 35724
		public UnitType Type;

		// Token: 0x04008B8D RID: 35725
		public uint Id;

		// Token: 0x04008B8E RID: 35726
		public GameSound Sound;
	}
}
