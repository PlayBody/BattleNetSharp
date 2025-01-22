using System;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000010 RID: 16
	public enum Platform
	{
		// Token: 0x04000058 RID: 88
		[OriginalName("PLATFORM_PC_CLIENT")]
		PcClient,
		// Token: 0x04000059 RID: 89
		[OriginalName("PLATFORM_MAC_CLIENT")]
		MacClient,
		// Token: 0x0400005A RID: 90
		[OriginalName("PLATFORM_EMBEDDED")]
		Embedded,
		// Token: 0x0400005B RID: 91
		[OriginalName("PLATFORM_PS4")]
		Ps4,
		// Token: 0x0400005C RID: 92
		[OriginalName("PLATFORM_XBOX_ONE")]
		XboxOne,
		// Token: 0x0400005D RID: 93
		[OriginalName("PLATFORM_PC_SERVER")]
		PcServer,
		// Token: 0x0400005E RID: 94
		[OriginalName("PLATFORM_LINUX_SERVER")]
		LinuxServer,
		// Token: 0x0400005F RID: 95
		[OriginalName("PLATFORM_PS5")]
		Ps5,
		// Token: 0x04000060 RID: 96
		[OriginalName("PLATFORM_SCARLETT")]
		Scarlett,
		// Token: 0x04000061 RID: 97
		[OriginalName("PLATFORM_NX64")]
		Nx64
	}
}
