using System;

namespace D2Packets.Realm
{
	// Token: 0x02000A9B RID: 2715
	public class MessageOfTheDayS2C : Packet
	{
		// Token: 0x04008FCC RID: 36812
		public ushort Length;

		// Token: 0x04008FCD RID: 36813
		public RealmPacket PacketId;

		// Token: 0x04008FCE RID: 36814
		public string Message;
	}
}
