using System;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AB6 RID: 2742
	public class KeepAliveC2S : Packet
	{
		// Token: 0x04009096 RID: 37014
		public byte FF = byte.MaxValue;

		// Token: 0x04009097 RID: 37015
		public BattleNetPacket PacketId;

		// Token: 0x04009098 RID: 37016
		public ushort Length;
	}
}
