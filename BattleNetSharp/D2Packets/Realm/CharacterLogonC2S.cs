using System;

namespace D2Packets.Realm
{
	// Token: 0x02000A8C RID: 2700
	public class CharacterLogonC2S : Packet
	{
		// Token: 0x04008F80 RID: 36736
		public ushort Length;

		// Token: 0x04008F81 RID: 36737
		public RealmPacket PacketId;

		// Token: 0x04008F82 RID: 36738
		public string CharacterName;
	}
}
