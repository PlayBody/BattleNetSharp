using System;

namespace D2Packets.Realm
{
	// Token: 0x02000A91 RID: 2705
	public class CreateGameQueueS2C : Packet
	{
		// Token: 0x04008F98 RID: 36760
		public ushort Length;

		// Token: 0x04008F99 RID: 36761
		public RealmPacket PacketId;

		// Token: 0x04008F9A RID: 36762
		public uint Position;
	}
}
