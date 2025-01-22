using System;
using System.Collections.Generic;

namespace D2Packets.Realm
{
	// Token: 0x02000A93 RID: 2707
	public class GameInfoS2C : Packet
	{
		// Token: 0x04008F9F RID: 36767
		public ushort Length;

		// Token: 0x04008FA0 RID: 36768
		public RealmPacket PacketId;

		// Token: 0x04008FA1 RID: 36769
		public ushort RequestId;

		// Token: 0x04008FA2 RID: 36770
		public uint Status;

		// Token: 0x04008FA3 RID: 36771
		public uint GameUptimeSeconds;

		// Token: 0x04008FA4 RID: 36772
		public byte LevelRestriction;

		// Token: 0x04008FA5 RID: 36773
		public byte LevelDifference;

		// Token: 0x04008FA6 RID: 36774
		public byte MaxPlayers;

		// Token: 0x04008FA7 RID: 36775
		public byte NumPlayers;

		// Token: 0x04008FA8 RID: 36776
		public List<byte> Classes_16;

		// Token: 0x04008FA9 RID: 36777
		public List<byte> Levels_16;

		// Token: 0x04008FAA RID: 36778
		public string GameDescription;

		// Token: 0x04008FAB RID: 36779
		public List<string> Names_16;
	}
}
