using System;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AA9 RID: 2729
	public class ChatCommandS2C : Packet
	{
		// Token: 0x04009044 RID: 36932
		public byte FF = byte.MaxValue;

		// Token: 0x04009045 RID: 36933
		public BattleNetPacket PacketId;

		// Token: 0x04009046 RID: 36934
		public ushort Length;

		// Token: 0x04009047 RID: 36935
		public uint AdId;

		// Token: 0x04009048 RID: 36936
		public uint unk1;

		// Token: 0x04009049 RID: 36937
		public uint unk2;

		// Token: 0x0400904A RID: 36938
		public uint unk3;
	}
}
