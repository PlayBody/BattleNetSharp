using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A40 RID: 2624
	public class IdentifyGambleItemOrTravel : Packet
	{
		// Token: 0x04008DD4 RID: 36308
		public GameClientPacket PacketId;

		// Token: 0x04008DD5 RID: 36309
		public uint Id;

		// Token: 0x04008DD6 RID: 36310
		[MinVersion(GameVersion.D2R)]
		public AreaLevel AreaLevel;

		// Token: 0x04008DD7 RID: 36311
		[MinVersion(GameVersion.D2R)]
		public ushort pad0;

		// Token: 0x04008DD8 RID: 36312
		[MinVersion(GameVersion.D2R)]
		public byte pad1;
	}
}
