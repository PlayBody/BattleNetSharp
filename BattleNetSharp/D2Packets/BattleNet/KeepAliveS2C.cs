using System;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AB7 RID: 2743
	public class KeepAliveS2C : Packet
	{
		// Token: 0x04009099 RID: 37017
		public byte FF = byte.MaxValue;

		// Token: 0x0400909A RID: 37018
		public BattleNetPacket PacketId;

		// Token: 0x0400909B RID: 37019
		public ushort Length;
	}
}
