using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x02000309 RID: 777
	public static class LocaleUpdatedReflection
	{
		// Token: 0x17001A88 RID: 6792
		// (get) Token: 0x0600525D RID: 21085 RVA: 0x0013E3EC File Offset: 0x0013C5EC
		public static FileDescriptor Descriptor
		{
			get
			{
				return LocaleUpdatedReflection.descriptor;
			}
		}

		// Token: 0x0600525E RID: 21086 RVA: 0x0013E404 File Offset: 0x0013C604
		static LocaleUpdatedReflection()
		{
			byte[] array = Convert.FromBase64String("ChNMb2NhbGVVcGRhdGVkLnByb3RvEiNCbGl6emFyZC5UZWxlbWV0cnkuRmVu" + "cmlzLkNsaWVudC52MRoQTG9jYWxlSW5mby5wcm90byJVCg1Mb2NhbGVVcGRh" + "dGVkEkQKC2xvY2FsZV9pbmZvGAEgASgLMi8uQmxpenphcmQuVGVsZW1ldHJ5" + "LkZlbnJpcy5DbGllbnQudjEuTG9jYWxlSW5mbw==");
			LocaleUpdatedReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { LocaleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(LocaleUpdated), LocaleUpdated.Parser, new string[] { "LocaleInfo" }, null, null, null, null)
			}));
		}

		// Token: 0x04002568 RID: 9576
		private static FileDescriptor descriptor;
	}
}
