using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V2
{
	// Token: 0x020005B8 RID: 1464
	public enum PresenceQueryBehavior
	{
		// Token: 0x04003EDA RID: 16090
		[OriginalName("BATTLE_NET_ACCOUNT_ONLY")]
		BattleNetAccountOnly,
		// Token: 0x04003EDB RID: 16091
		[OriginalName("INCLUDE_SAME_GAME_ACCOUNT")]
		IncludeSameGameAccount,
		// Token: 0x04003EDC RID: 16092
		[OriginalName("INCLUDE_ALL_GAME_ACCOUNTS")]
		IncludeAllGameAccounts
	}
}
