using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Report.V2
{
	// Token: 0x02000585 RID: 1413
	public enum IssueType
	{
		// Token: 0x04003D5F RID: 15711
		[OriginalName("ISSUE_TYPE_SPAM")]
		Spam,
		// Token: 0x04003D60 RID: 15712
		[OriginalName("ISSUE_TYPE_HARASSMENT")]
		Harassment,
		// Token: 0x04003D61 RID: 15713
		[OriginalName("ISSUE_TYPE_OFFENSIVE_CONTENT")]
		OffensiveContent = 3,
		// Token: 0x04003D62 RID: 15714
		[OriginalName("ISSUE_TYPE_HACKING")]
		Hacking,
		// Token: 0x04003D63 RID: 15715
		[OriginalName("ISSUE_TYPE_BOTTING")]
		Botting
	}
}
