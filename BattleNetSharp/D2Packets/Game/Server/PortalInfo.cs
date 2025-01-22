using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009F0 RID: 2544
	public class PortalInfo : Packet
	{
		// Token: 0x04008B94 RID: 35732
		public GameServerPacket PacketId;

		// Token: 0x04008B95 RID: 35733
		public PortalInfo.TownPortalState State;

		// Token: 0x04008B96 RID: 35734
		public AreaLevel Destination;

		// Token: 0x04008B97 RID: 35735
		public uint Id;

		// Token: 0x04008B98 RID: 35736
		[MinVersion(GameVersion.D2R)]
		public uint DestinationPortalId;

		// Token: 0x04008B99 RID: 35737
		[MinVersion(GameVersion.D2R)]
		public AreaLevel Destination2;

		// Token: 0x02001355 RID: 4949
		[Flags]
		public enum TownPortalState : byte
		{
			// Token: 0x04009E43 RID: 40515
			Town = 0,
			// Token: 0x04009E44 RID: 40516
			Unk = 1,
			// Token: 0x04009E45 RID: 40517
			Wild = 2,
			// Token: 0x04009E46 RID: 40518
			UnusedArea = 3,
			// Token: 0x04009E47 RID: 40519
			Used = 4,
			// Token: 0x04009E48 RID: 40520
			UsedTownArea = 5,
			// Token: 0x04009E49 RID: 40521
			Unk2 = 6,
			// Token: 0x04009E4A RID: 40522
			UsedArea = 7
		}
	}
}
