#nullable enable // @Review

using System;
using System.Runtime.CompilerServices;

namespace D4Packets.Game.Client
{
	// Token: 0x02000894 RID: 2196
	public class NewPlayer2 : D4Packet
	{
		// Token: 0x04006464 RID: 25700
		public AccountEntityId BnetAccountID;

		// Token: 0x04006465 RID: 25701
		public AccountEntityId GameAccountID;

		// Token: 0x04006466 RID: 25702
		public uint Field2;

		// Token: 0x04006467 RID: 25703
		public uint Field3;

		// Token: 0x04006468 RID: 25704
		public PlatformAccount PlatformAccount;

		// Token: 0x04006469 RID: 25705
		[DynamicLen(49)]
		public string ToonName;

		// Token: 0x0400646A RID: 25706
		[FixedLen(6U)]
		public uint Team;

		// Token: 0x0400646B RID: 25707
		[FixedLen(3U)]
		public uint Class;

		// Token: 0x0400646C RID: 25708
		public uint SNOActor;

		// Token: 0x0400646D RID: 25709
		[FixedLen(7U)]
		public uint Level;

		// Token: 0x0400646E RID: 25710
		public HeroStateData HeroState;

		// Token: 0x0400646F RID: 25711
		public bool JustJoined;

		// Token: 0x04006470 RID: 25712
		public ulong DynamicID;

		// Token: 0x04006471 RID: 25713
		[DynamicLen(128)]
		public string BattleTag;

		// Token: 0x04006472 RID: 25714
		[FixedLen(2U)]
		public int Field14;

		// Token: 0x04006473 RID: 25715
		public AccountEntityId Field15;

		// Token: 0x04006474 RID: 25716
		public bool Field16;
	}
}
