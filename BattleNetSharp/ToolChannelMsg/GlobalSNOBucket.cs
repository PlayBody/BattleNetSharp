using System;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000015 RID: 21
	public enum GlobalSNOBucket
	{
		// Token: 0x0400007A RID: 122
		[OriginalName("GlobalSNOBucket_ToolsAndTesting")]
		ToolsAndTesting,
		// Token: 0x0400007B RID: 123
		[OriginalName("GlobalSNOBucket_Main")]
		Main,
		// Token: 0x0400007C RID: 124
		[OriginalName("GlobalSNOBucket_Non_Beta")]
		NonBeta,
		// Token: 0x0400007D RID: 125
		[OriginalName("GlobalSNOBucket_Beta_Only")]
		BetaOnly
	}
}
