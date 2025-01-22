using System;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AB8 RID: 2744
	public class LeaveChatC2S : Packet
	{
		// Token: 0x0400909C RID: 37020
		public byte FF = byte.MaxValue;

		// Token: 0x0400909D RID: 37021
		public BattleNetPacket PacketId;

		// Token: 0x0400909E RID: 37022
		public ushort Length;
	}
}
