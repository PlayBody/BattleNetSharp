using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x02000332 RID: 818
	public static class CommonUserDataReflection
	{
		// Token: 0x17001B89 RID: 7049
		// (get) Token: 0x06005556 RID: 21846 RVA: 0x00149B7C File Offset: 0x00147D7C
		public static FileDescriptor Descriptor
		{
			get
			{
				return CommonUserDataReflection.descriptor;
			}
		}

		// Token: 0x06005557 RID: 21847 RVA: 0x00149B94 File Offset: 0x00147D94
		static CommonUserDataReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "ChZjb21tb25fdXNlcl9kYXRhLnByb3RvEiBCbGl6emFyZC5UZWxlbWV0cnku", "RmVud2F5LkNsaWVudCJ6CghVc2VyRGF0YRIUCgxiYXR0bGVuZXRfaWQYASAB", "KA0SFgoOYWNjb3VudF9yZWdpb24YAiABKAkSDwoHY291bnRyeRgDIAEoCRIY", "ChBwcmVmZXJyZWRfcmVnaW9uGAQgASgNEhUKDXBsYXRmb3JtX25hbWUYBSAB", "KAk=" }));
			CommonUserDataReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(UserData), UserData.Parser, new string[] { "BattlenetId", "AccountRegion", "Country", "PreferredRegion", "PlatformName" }, null, null, null, null)
			}));
		}

		// Token: 0x040026C8 RID: 9928
		private static FileDescriptor descriptor;
	}
}
