using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A41 RID: 2625
	public class IdentifyItemGoldXfer : Packet
	{
		// Token: 0x04008DD9 RID: 36313
		public GameClientPacket PacketId;

		// Token: 0x04008DDA RID: 36314
		[MaxVersion(GameVersion.LOD)]
		public uint ItemId;

		// Token: 0x04008DDB RID: 36315
		[MaxVersion(GameVersion.LOD)]
		public uint ScrollId;

		// Token: 0x04008DDC RID: 36316
		[MinVersion(GameVersion.D2R)]
		public uint Id;

		// Token: 0x04008DDD RID: 36317
		[MinVersion(GameVersion.D2R)]
		public uint BankGold;

		// Token: 0x04008DDE RID: 36318
		[MinVersion(GameVersion.D2R)]
		public uint InventoryGold;

		// Token: 0x04008DDF RID: 36319
		[MinVersion(GameVersion.D2R)]
		public int InventoryChangeGold;
	}
}
