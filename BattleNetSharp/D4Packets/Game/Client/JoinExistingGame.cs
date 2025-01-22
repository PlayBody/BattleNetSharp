using System;

namespace D4Packets.Game.Client
{
	// Token: 0x0200086E RID: 2158
	[D4Packet.OpcodeAttribute(Opcodes.CMSG_JOIN_EXISTING_GAME)]
	public class JoinExistingGame : D4Packet
	{
		// Token: 0x040063F0 RID: 25584
		public int GameID;

		// Token: 0x040063F1 RID: 25585
		[FixedLen(5U)]
		public int XLocale;

		// Token: 0x040063F2 RID: 25586
		public float fl;

		// Token: 0x040063F3 RID: 25587
		public uint ProtocolHash;

		// Token: 0x040063F4 RID: 25588
		[DynamicLen(2)]
		public JoinExistingGame.GameConnectionInfo[] GCI;

		// Token: 0x020012EF RID: 4847
		public class GameConnectionInfo : D4Packet
		{
			// Token: 0x04009CBC RID: 40124
			public uint GameAccountId;

			// Token: 0x04009CBD RID: 40125
			public ulong AuthToken;

			// Token: 0x04009CBE RID: 40126
			public bool field1;

			// Token: 0x04009CBF RID: 40127
			[DynamicLen(8)]
			public byte[] SessionKey;
		}
	}
}
