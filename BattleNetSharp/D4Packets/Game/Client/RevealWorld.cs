using System;
using System.Runtime.CompilerServices;

namespace D4Packets.Game.Client
{
	// Token: 0x020008B2 RID: 2226
	[D4Packet.OpcodeAttribute(Opcodes.SMSG_REVEAL_WORLD)]
	public class RevealWorld : D4Packet
	{
		// Token: 0x040064F4 RID: 25844
		public long idSWorld;

		// Token: 0x040064F5 RID: 25845
		public int snoWorld;

		// Token: 0x040064F6 RID: 25846
		public uint _02573139;

		// Token: 0x040064F7 RID: 25847
//		[Nullable(2)]
		public Vector2 _0b4055da;

		// Token: 0x040064F8 RID: 25848
		public int? uKeyedDungeonTier;

		// Token: 0x040064F9 RID: 25849
		[FixedLen(32U)]
		public int[] arDungeonStates;

		// Token: 0x040064FA RID: 25850
		public int nDungeonStatesCount;

		// Token: 0x040064FB RID: 25851
		[DynamicLen(4)]
		public int[] arDungeonAffixes;

		// Token: 0x040064FC RID: 25852
		[DynamicLen(4)]
		public int[] _06966598;

		// Token: 0x040064FD RID: 25853
		public int nRemainingReviveCount;
	}
}
