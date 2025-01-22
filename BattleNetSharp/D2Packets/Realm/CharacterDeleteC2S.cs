using System;

namespace D2Packets.Realm
{
	// Token: 0x02000A88 RID: 2696
	public class CharacterDeleteC2S : Packet
	{
		// Token: 0x04008F70 RID: 36720
		public ushort Length;

		// Token: 0x04008F71 RID: 36721
		public RealmPacket PacketId;

		// Token: 0x04008F72 RID: 36722
		public ushort Unk0 = 0;

		// Token: 0x04008F73 RID: 36723
		public string CharacterName;
	}
}
