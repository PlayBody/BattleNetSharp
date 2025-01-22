using System;

namespace D2Packets.Realm
{
	// Token: 0x02000A8F RID: 2703
	public class CreateGameS2C : Packet
	{
		// Token: 0x04008F90 RID: 36752
		public ushort Length;

		// Token: 0x04008F91 RID: 36753
		public RealmPacket PacketId;

		// Token: 0x04008F92 RID: 36754
		public ushort Id;

		// Token: 0x04008F93 RID: 36755
		public ushort GameToken;

		// Token: 0x04008F94 RID: 36756
		public ushort Zero;

		// Token: 0x04008F95 RID: 36757
		public CreateGameS2C.CreateGameStatus Result;

		// Token: 0x02001386 RID: 4998
		public enum CreateGameStatus : uint
		{
			// Token: 0x04009F14 RID: 40724
			Success,
			// Token: 0x04009F15 RID: 40725
			InvalidGameName = 30U,
			// Token: 0x04009F16 RID: 40726
			AlreadyExists,
			// Token: 0x04009F17 RID: 40727
			ServerDown,
			// Token: 0x04009F18 RID: 40728
			DeadHardcore = 110U
		}
	}
}
