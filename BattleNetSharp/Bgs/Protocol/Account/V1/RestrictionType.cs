using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x0200072F RID: 1839
	public enum RestrictionType
	{
		// Token: 0x04004B9C RID: 19356
		[OriginalName("UNKNOWN")]
		Unknown,
		// Token: 0x04004B9D RID: 19357
		[OriginalName("GAME_ACCOUNT_BANNED")]
		GameAccountBanned,
		// Token: 0x04004B9E RID: 19358
		[OriginalName("GAME_ACCOUNT_SUSPENDED")]
		GameAccountSuspended,
		// Token: 0x04004B9F RID: 19359
		[OriginalName("ACCOUNT_LOCKED")]
		AccountLocked,
		// Token: 0x04004BA0 RID: 19360
		[OriginalName("ACCOUNT_SQUELCHED")]
		AccountSquelched
	}
}
