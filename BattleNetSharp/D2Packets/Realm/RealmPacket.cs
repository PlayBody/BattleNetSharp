using System;

namespace D2Packets.Realm
{
	// Token: 0x02000A9C RID: 2716
	public enum RealmPacket : byte
	{
		// Token: 0x04008FD0 RID: 36816
		Heartbeat,
		// Token: 0x04008FD1 RID: 36817
		Startup,
		// Token: 0x04008FD2 RID: 36818
		CharacterCreate,
		// Token: 0x04008FD3 RID: 36819
		CreateGame,
		// Token: 0x04008FD4 RID: 36820
		JoinGame,
		// Token: 0x04008FD5 RID: 36821
		GameList,
		// Token: 0x04008FD6 RID: 36822
		GameInfo,
		// Token: 0x04008FD7 RID: 36823
		CharacterLogon,
		// Token: 0x04008FD8 RID: 36824
		CharacterDelete = 10,
		// Token: 0x04008FD9 RID: 36825
		RequestLadderData = 17,
		// Token: 0x04008FDA RID: 36826
		MessageOfTheDay,
		// Token: 0x04008FDB RID: 36827
		CreateGameCancel,
		// Token: 0x04008FDC RID: 36828
		CreateGameQueue,
		// Token: 0x04008FDD RID: 36829
		CharacterUpgrade = 24,
		// Token: 0x04008FDE RID: 36830
		CharacterList
	}
}
