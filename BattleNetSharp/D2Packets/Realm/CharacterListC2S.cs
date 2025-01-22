using System;

namespace D2Packets.Realm
{
	// Token: 0x02000A8A RID: 2698
	public class CharacterListC2S : Packet
	{
		// Token: 0x04008F77 RID: 36727
		public ushort Length;

		// Token: 0x04008F78 RID: 36728
		public RealmPacket PacketId;

		// Token: 0x04008F79 RID: 36729
		public uint NumChars = 8U;
	}
}
