using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x020002FF RID: 767
	public static class BugScreenshotPartsReflection
	{
		// Token: 0x17001A10 RID: 6672
		// (get) Token: 0x06005136 RID: 20790 RVA: 0x0013906C File Offset: 0x0013726C
		public static FileDescriptor Descriptor
		{
			get
			{
				return BugScreenshotPartsReflection.descriptor;
			}
		}

		// Token: 0x06005137 RID: 20791 RVA: 0x00139084 File Offset: 0x00137284
		static BugScreenshotPartsReflection()
		{
			byte[] array = Convert.FromBase64String("ChhCdWdTY3JlZW5zaG90UGFydHMucHJvdG8SI0JsaXp6YXJkLlRlbGVtZXRy" + "eS5GZW5yaXMuQ2xpZW50LnYxIlwKEkJ1Z1NjcmVlbnNob3RQYXJ0cxIRCgl0" + "aW1lc3RhbXAYASABKAQSDQoFaW5kZXgYAiABKAUSDQoFY291bnQYAyABKAUS" + "FQoNanBnX2RhdGFfcGFydBgEIAEoDA==");
			BugScreenshotPartsReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(BugScreenshotParts), BugScreenshotParts.Parser, new string[] { "Timestamp", "Index", "Count", "JpgDataPart" }, null, null, null, null)
			}));
		}

		// Token: 0x040024BC RID: 9404
		private static FileDescriptor descriptor;
	}
}
