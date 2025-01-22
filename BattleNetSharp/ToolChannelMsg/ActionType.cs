using System;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000014 RID: 20
	public enum ActionType
	{
		// Token: 0x04000076 RID: 118
		[OriginalName("ACTIONTYPE_MODIFY")]
		Modify = 1,
		// Token: 0x04000077 RID: 119
		[OriginalName("ACTIONTYPE_ADD")]
		Add,
		// Token: 0x04000078 RID: 120
		[OriginalName("ACTIONTYPE_REMOVE")]
		Remove
	}
}
