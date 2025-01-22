using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A5F RID: 2655
	public class SendMessage : Packet
	{
		// Token: 0x04008E81 RID: 36481
		public GameClientPacket PacketId;

		// Token: 0x04008E82 RID: 36482
		public GameMessageType Type;

		// Token: 0x04008E83 RID: 36483
		public byte pad0;

		// Token: 0x04008E84 RID: 36484
		public string Message;

		// Token: 0x04008E85 RID: 36485
		public string Recipient;

		// Token: 0x04008E86 RID: 36486
		public byte pad;
	}
}
