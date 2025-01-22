using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A85 RID: 2693
	public class WaypointTravelPutSharedStash : Packet
	{
		// Token: 0x04008F5F RID: 36703
		public GameClientPacket PacketId;

		// Token: 0x04008F60 RID: 36704
		[MaxVersion(GameVersion.LOD)]
		public uint WaypointId;

		// Token: 0x04008F61 RID: 36705
		[MaxVersion(GameVersion.LOD)]
		public AreaLevel Destination;

		// Token: 0x04008F62 RID: 36706
		[MaxVersion(GameVersion.LOD)]
		public ushort pad0;

		// Token: 0x04008F63 RID: 36707
		[MaxVersion(GameVersion.LOD)]
		public byte pad1;

		// Token: 0x04008F64 RID: 36708
		[MinVersion(GameVersion.D2R)]
		public uint ItemId;

		// Token: 0x04008F65 RID: 36709
		[MinVersion(GameVersion.D2R)]
		public uint SharedStashId;

		// Token: 0x04008F66 RID: 36710
		[MinVersion(GameVersion.D2R)]
		public ushort X;

		// Token: 0x04008F67 RID: 36711
		[MinVersion(GameVersion.D2R)]
		public ushort Y;
	}
}
