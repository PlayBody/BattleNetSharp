using System;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AA8 RID: 2728
	public class ChatCommandC2S : Packet
	{
		// Token: 0x04009040 RID: 36928
		public byte FF = byte.MaxValue;

		// Token: 0x04009041 RID: 36929
		public BattleNetPacket PacketId;

		// Token: 0x04009042 RID: 36930
		public ushort Length;

		// Token: 0x04009043 RID: 36931
		public string Message;
	}
}
