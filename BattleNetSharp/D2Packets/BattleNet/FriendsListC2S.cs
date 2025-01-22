using System;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AB3 RID: 2739
	public class FriendsListC2S : Packet
	{
		// Token: 0x04009087 RID: 36999
		public byte FF = byte.MaxValue;

		// Token: 0x04009088 RID: 37000
		public BattleNetPacket PacketId;

		// Token: 0x04009089 RID: 37001
		public ushort Length;

		// Token: 0x0400908A RID: 37002
		public string CharName;

		// Token: 0x0400908B RID: 37003
		public string RealmCharName;
	}
}
