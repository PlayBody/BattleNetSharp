using System;

namespace D2Packets.Realm
{
	// Token: 0x02000A8D RID: 2701
	public class CharacterLogonS2C : Packet
	{
		// Token: 0x04008F83 RID: 36739
		public ushort Length;

		// Token: 0x04008F84 RID: 36740
		public RealmPacket PacketId;

		// Token: 0x04008F85 RID: 36741
		public CharacterLogonS2C.CharStatus Result;

		// Token: 0x02001384 RID: 4996
		public enum CharStatus : uint
		{
			// Token: 0x04009F0B RID: 40715
			Success,
			// Token: 0x04009F0C RID: 40716
			NotFound = 70U,
			// Token: 0x04009F0D RID: 40717
			Failed = 122U,
			// Token: 0x04009F0E RID: 40718
			Expired
		}
	}
}
