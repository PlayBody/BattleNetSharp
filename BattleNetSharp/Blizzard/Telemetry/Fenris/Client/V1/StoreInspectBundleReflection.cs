using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x0200030D RID: 781
	public static class StoreInspectBundleReflection
	{
		// Token: 0x17001A99 RID: 6809
		// (get) Token: 0x06005295 RID: 21141 RVA: 0x0013EFFC File Offset: 0x0013D1FC
		public static FileDescriptor Descriptor
		{
			get
			{
				return StoreInspectBundleReflection.descriptor;
			}
		}

		// Token: 0x06005296 RID: 21142 RVA: 0x0013F014 File Offset: 0x0013D214
		static StoreInspectBundleReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "ChhTdG9yZUluc3BlY3RCdW5kbGUucHJvdG8SI0JsaXp6YXJkLlRlbGVtZXRy", "eS5GZW5yaXMuQ2xpZW50LnYxGhZTdG9yZVNlc3Npb25JbmZvLnByb3RvGhZT", "dG9yZVByb2R1Y3RJbmZvLnByb3RvIq4BChJTdG9yZUluc3BlY3RCdW5kbGUS", "SwoMc2Vzc2lvbl9pbmZvGAEgASgLMjUuQmxpenphcmQuVGVsZW1ldHJ5LkZl", "bnJpcy5DbGllbnQudjEuU3RvcmVTZXNzaW9uSW5mbxJLCgxwcm9kdWN0X2lu", "Zm8YAiABKAsyNS5CbGl6emFyZC5UZWxlbWV0cnkuRmVucmlzLkNsaWVudC52", "MS5TdG9yZVByb2R1Y3RJbmZv" }));
			StoreInspectBundleReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				StoreSessionInfoReflection.Descriptor,
				StoreProductInfoReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(StoreInspectBundle), StoreInspectBundle.Parser, new string[] { "SessionInfo", "ProductInfo" }, null, null, null, null)
			}));
		}

		// Token: 0x0400257D RID: 9597
		private static FileDescriptor descriptor;
	}
}
