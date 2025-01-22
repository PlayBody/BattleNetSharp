using System;

namespace D2Packets.Game.Server
{
	// Token: 0x02000A1E RID: 2590
	public class UseSpecialItem : Packet
	{
		// Token: 0x04008C7D RID: 35965
		public GameServerPacket PacketId;

		// Token: 0x04008C7E RID: 35966
		public UseSpecialItem.SpecialItemType Type;

		// Token: 0x04008C7F RID: 35967
		public uint Id;

		// Token: 0x02001361 RID: 4961
		public enum SpecialItemType : byte
		{
			// Token: 0x04009E72 RID: 40562
			TomeOrScroll = 4
		}
	}
}
