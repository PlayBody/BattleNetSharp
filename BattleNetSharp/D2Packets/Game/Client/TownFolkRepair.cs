using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A75 RID: 2677
	public class TownFolkRepair : Packet
	{
		// Token: 0x04008F03 RID: 36611
		public GameClientPacket PacketId;

		// Token: 0x04008F04 RID: 36612
		[MinVersion(GameVersion.D2R)]
		public byte Location;

		// Token: 0x04008F05 RID: 36613
		[MinVersion(GameVersion.D2R)]
		public byte X;

		// Token: 0x04008F06 RID: 36614
		[MinVersion(GameVersion.D2R)]
		public byte Y;

		// Token: 0x04008F07 RID: 36615
		public uint DealerId;

		// Token: 0x04008F08 RID: 36616
		[MinVersion(GameVersion.D2R)]
		public uint Cost;

		// Token: 0x04008F09 RID: 36617
		public uint ItemId = 0U;

		// Token: 0x04008F0A RID: 36618
		[MaxVersion(GameVersion.LOD)]
		public TownFolkRepair.RepairType Type = TownFolkRepair.RepairType.RepairAll;

		// Token: 0x04008F0B RID: 36619
		[MaxVersion(GameVersion.LOD)]
		public uint Zero = 2147483648U;

		// Token: 0x02001374 RID: 4980
		public enum RepairType : uint
		{
			// Token: 0x04009EB8 RID: 40632
			RepairAll,
			// Token: 0x04009EB9 RID: 40633
			RepairItem
		}
	}
}
