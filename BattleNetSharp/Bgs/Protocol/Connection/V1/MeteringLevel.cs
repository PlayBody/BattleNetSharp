using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Connection.V1
{
	// Token: 0x0200042A RID: 1066
	public enum MeteringLevel
	{
		// Token: 0x04002FBE RID: 12222
		[OriginalName("METERING_LEVEL_LEGACY")]
		Legacy,
		// Token: 0x04002FBF RID: 12223
		[OriginalName("METERING_LEVEL_CATEGORIZED")]
		Categorized
	}
}
