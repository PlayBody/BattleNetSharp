using System;

namespace D2Packets.Realm
{
	// Token: 0x02000A87 RID: 2695
	public class CharacterCreateS2C : Packet
	{
		// Token: 0x04008F6D RID: 36717
		public ushort Length;

		// Token: 0x04008F6E RID: 36718
		public RealmPacket PacketId;

		// Token: 0x04008F6F RID: 36719
		public CharacterCreateS2C.Result Status;

		// Token: 0x02001381 RID: 4993
		public enum Result : uint
		{
			// Token: 0x04009F01 RID: 40705
			Success,
			// Token: 0x04009F02 RID: 40706
			ExistsOrMax = 20U,
			// Token: 0x04009F03 RID: 40707
			InvalidName
		}
	}
}
