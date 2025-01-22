using System;

namespace D2Packets.Realm
{
	// Token: 0x02000A86 RID: 2694
	public class CharacterCreateC2S : Packet
	{
		// Token: 0x04008F68 RID: 36712
		public ushort Length;

		// Token: 0x04008F69 RID: 36713
		public RealmPacket PacketId;

		// Token: 0x04008F6A RID: 36714
		public uint Class = 0U;

		// Token: 0x04008F6B RID: 36715
		public ushort Flags = 96;

		// Token: 0x04008F6C RID: 36716
		public string CharacterName;
	}
}
