using System;

namespace D2Packets.Game.Server
{
	// Token: 0x020009DF RID: 2527
	public class PlayerAttributeNotification : Packet
	{
		// Token: 0x04008B28 RID: 35624
		public GameServerPacket PacketId;

		// Token: 0x04008B29 RID: 35625
		[MinVersion(GameVersion.D2R)]
		public uint AttribD2R;

		// Token: 0x04008B2A RID: 35626
		public uint Id;

		// Token: 0x04008B2B RID: 35627
		[MaxVersion(GameVersion.LOD)]
		public byte AttribLOD;

		// Token: 0x04008B2C RID: 35628
		public uint Value;
	}
}
