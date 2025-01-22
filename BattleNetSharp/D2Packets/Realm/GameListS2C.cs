using System;

namespace D2Packets.Realm
{
	// Token: 0x02000A95 RID: 2709
	public class GameListS2C : Packet
	{
		// Token: 0x04008FB1 RID: 36785
		public ushort Length;

		// Token: 0x04008FB2 RID: 36786
		public RealmPacket PacketId;

		// Token: 0x04008FB3 RID: 36787
		public ushort RequestId;

		// Token: 0x04008FB4 RID: 36788
		public uint Index;

		// Token: 0x04008FB5 RID: 36789
		public byte NumPlayers;

		// Token: 0x04008FB6 RID: 36790
		public uint Status;

		// Token: 0x04008FB7 RID: 36791
		public string GameName;

		// Token: 0x04008FB8 RID: 36792
		public string GameDescription;
	}
}
