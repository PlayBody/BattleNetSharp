using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x0200030B RID: 779
	public static class NetworkStatsReflection
	{
		// Token: 0x17001A8D RID: 6797
		// (get) Token: 0x06005272 RID: 21106 RVA: 0x0013E7E8 File Offset: 0x0013C9E8
		public static FileDescriptor Descriptor
		{
			get
			{
				return NetworkStatsReflection.descriptor;
			}
		}

		// Token: 0x06005273 RID: 21107 RVA: 0x0013E800 File Offset: 0x0013CA00
		static NetworkStatsReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "ChJOZXR3b3JrU3RhdHMucHJvdG8SI0JsaXp6YXJkLlRlbGVtZXRyeS5GZW5y", "aXMuQ2xpZW50LnYxIqgBCgxOZXR3b3JrU3RhdHMSIQoZYXZnX2luYm91bmRf", "a2JfcGVyX3NlY29uZBgBIAEoAhIiChphdmdfb3V0Ym91bmRfa2JfcGVyX3Nl", "Y29uZBgCIAEoAhInCh9hdmdfaW5ib3VuZF9tZXNzYWdlc19wZXJfc2Vjb25k", "GAMgASgCEigKIGF2Z19vdXRib3VuZF9tZXNzYWdlc19wZXJfc2Vjb25kGAQg", "ASgC" }));
			NetworkStatsReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(NetworkStats), NetworkStats.Parser, new string[] { "AvgInboundKbPerSecond", "AvgOutboundKbPerSecond", "AvgInboundMessagesPerSecond", "AvgOutboundMessagesPerSecond" }, null, null, null, null)
			}));
		}

		// Token: 0x0400256D RID: 9581
		private static FileDescriptor descriptor;
	}
}
