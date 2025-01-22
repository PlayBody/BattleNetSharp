using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A60 RID: 2656
	public class SendOverheadMessage : Packet
	{
		// Token: 0x04008E87 RID: 36487
		public GameClientPacket PacketId;

		// Token: 0x04008E88 RID: 36488
		public ushort Zero = 0;

		// Token: 0x04008E89 RID: 36489
		public string Message;

		// Token: 0x04008E8A RID: 36490
		public ushort Unk2;
	}
}
