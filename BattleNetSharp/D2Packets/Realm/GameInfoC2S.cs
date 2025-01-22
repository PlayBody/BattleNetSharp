using System;

namespace D2Packets.Realm
{
	// Token: 0x02000A92 RID: 2706
	public class GameInfoC2S : Packet
	{
		// Token: 0x04008F9B RID: 36763
		public ushort Length;

		// Token: 0x04008F9C RID: 36764
		public RealmPacket PacketId;

		// Token: 0x04008F9D RID: 36765
		public ushort RequestId = 2;

		// Token: 0x04008F9E RID: 36766
		public string GameName;
	}
}
