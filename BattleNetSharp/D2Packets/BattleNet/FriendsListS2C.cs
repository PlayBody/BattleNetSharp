using System;
using System.Collections.Generic;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AB4 RID: 2740
	public class FriendsListS2C : Packet
	{
		// Token: 0x0400908C RID: 37004
		public byte FF = byte.MaxValue;

		// Token: 0x0400908D RID: 37005
		public BattleNetPacket PacketId;

		// Token: 0x0400908E RID: 37006
		public ushort Length;

		// Token: 0x0400908F RID: 37007
		public uint NumFriends;

		// Token: 0x04009090 RID: 37008
		public List<FriendsListS2C.FriendEntry> Friends = new List<FriendsListS2C.FriendEntry>();

		// Token: 0x0200138F RID: 5007
		public class FriendEntry
		{
			// Token: 0x04009F5F RID: 40799
			public string AccountName;

			// Token: 0x04009F60 RID: 40800
			public byte Status;

			// Token: 0x04009F61 RID: 40801
			public byte LocationId;

			// Token: 0x04009F62 RID: 40802
			public uint ProductId;

			// Token: 0x04009F63 RID: 40803
			public string LocationName;
		}
	}
}
