using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A24 RID: 2596
	public class BuyItem : Packet
	{
		// Token: 0x04008C91 RID: 35985
		public GameClientPacket PacketId;

		// Token: 0x04008C92 RID: 35986
		[MinVersion(GameVersion.D2R)]
		public uint CostD2R;

		// Token: 0x04008C93 RID: 35987
		[MaxVersion(GameVersion.LOD)]
		public uint DealerId;

		// Token: 0x04008C94 RID: 35988
		public uint ItemId;

		// Token: 0x04008C95 RID: 35989
		[MinVersion(GameVersion.D2R)]
		public uint DealerIdD2R;

		// Token: 0x04008C96 RID: 35990
		[MinVersion(GameVersion.D2R)]
		public ushort VendorX;

		// Token: 0x04008C97 RID: 35991
		[MinVersion(GameVersion.D2R)]
		public ushort VendorY;

		// Token: 0x04008C98 RID: 35992
		[MinVersion(GameVersion.D2R)]
		public ushort X;

		// Token: 0x04008C99 RID: 35993
		[MinVersion(GameVersion.D2R)]
		public ushort Y;

		// Token: 0x04008C9A RID: 35994
		[MinVersion(GameVersion.D2R)]
		public byte VendorPage = byte.MaxValue;

		// Token: 0x04008C9B RID: 35995
		[MinVersion(GameVersion.D2R)]
		public ItemDestination Container;

		// Token: 0x04008C9C RID: 35996
		[MaxVersion(GameVersion.LOD)]
		public TradeType Type;

		// Token: 0x04008C9D RID: 35997
		[MaxVersion(GameVersion.LOD)]
		public BuyItem.BuyFlags Flags;

		// Token: 0x04008C9E RID: 35998
		[MaxVersion(GameVersion.LOD)]
		public uint Cost;

		// Token: 0x02001364 RID: 4964
		public enum BuyFlags : ushort
		{
			// Token: 0x04009E7A RID: 40570
			None,
			// Token: 0x04009E7B RID: 40571
			FillStack = 32768
		}
	}
}
