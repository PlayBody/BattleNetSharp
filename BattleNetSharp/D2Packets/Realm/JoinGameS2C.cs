using System;

namespace D2Packets.Realm
{
	// Token: 0x02000A99 RID: 2713
	public class JoinGameS2C : Packet
	{
		// Token: 0x04008FC2 RID: 36802
		public ushort Length;

		// Token: 0x04008FC3 RID: 36803
		public RealmPacket PacketId;

		// Token: 0x04008FC4 RID: 36804
		public ushort Id;

		// Token: 0x04008FC5 RID: 36805
		public ushort Token;

		// Token: 0x04008FC6 RID: 36806
		public ushort Zero;

		// Token: 0x04008FC7 RID: 36807
		public uint IpAddr;

		// Token: 0x04008FC8 RID: 36808
		public uint Hash;

		// Token: 0x04008FC9 RID: 36809
		public JoinGameS2C.JoinGameStatus Result;

		// Token: 0x02001387 RID: 4999
		public enum JoinGameStatus : uint
		{
			// Token: 0x04009F1A RID: 40730
			Success,
			// Token: 0x04009F1B RID: 40731
			Password = 41U,
			// Token: 0x04009F1C RID: 40732
			Invalid,
			// Token: 0x04009F1D RID: 40733
			Full,
			// Token: 0x04009F1E RID: 40734
			Level,
			// Token: 0x04009F1F RID: 40735
			Dead = 110U,
			// Token: 0x04009F20 RID: 40736
			Normal = 113U,
			// Token: 0x04009F21 RID: 40737
			Nightmare = 115U,
			// Token: 0x04009F22 RID: 40738
			Hell,
			// Token: 0x04009F23 RID: 40739
			Expansion = 120U,
			// Token: 0x04009F24 RID: 40740
			Classic,
			// Token: 0x04009F25 RID: 40741
			Ladder = 125U
		}
	}
}
