using System;
using Google.Protobuf.Reflection;

namespace Fenris.Clan
{
	// Token: 0x020002A9 RID: 681
	public enum ClanRank
	{
		// Token: 0x04001FC0 RID: 8128
		[OriginalName("INVALID")]
		Invalid = -1,
		// Token: 0x04001FC1 RID: 8129
		[OriginalName("RECRUIT")]
		Recruit = 4,
		// Token: 0x04001FC2 RID: 8130
		[OriginalName("MEMBER")]
		Member = 0,
		// Token: 0x04001FC3 RID: 8131
		[OriginalName("OFFICER")]
		Officer,
		// Token: 0x04001FC4 RID: 8132
		[OriginalName("LEADER")]
		Leader
	}
}
