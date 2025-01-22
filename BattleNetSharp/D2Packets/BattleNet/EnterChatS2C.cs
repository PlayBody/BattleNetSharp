using System;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AB0 RID: 2736
	public class EnterChatS2C : Packet
	{
		// Token: 0x04009074 RID: 36980
		public byte FF = byte.MaxValue;

		// Token: 0x04009075 RID: 36981
		public BattleNetPacket PacketId;

		// Token: 0x04009076 RID: 36982
		public ushort Length;

		// Token: 0x04009077 RID: 36983
		public string ChatName;

		// Token: 0x04009078 RID: 36984
		public ushort Product;

		// Token: 0x04009079 RID: 36985
		public string RealmCharName;
	}
}
