using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x02000307 RID: 775
	public static class LocaleInfoReflection
	{
		// Token: 0x17001A7E RID: 6782
		// (get) Token: 0x0600523E RID: 21054 RVA: 0x0013DD64 File Offset: 0x0013BF64
		public static FileDescriptor Descriptor
		{
			get
			{
				return LocaleInfoReflection.descriptor;
			}
		}

		// Token: 0x0600523F RID: 21055 RVA: 0x0013DD7C File Offset: 0x0013BF7C
		static LocaleInfoReflection()
		{
			byte[] array = Convert.FromBase64String("ChBMb2NhbGVJbmZvLnByb3RvEiNCbGl6emFyZC5UZWxlbWV0cnkuRmVucmlz" + "LkNsaWVudC52MSJNCgpMb2NhbGVJbmZvEhMKC2Jhc2VfbG9jYWxlGAEgASgF" + "EhMKC3RleHRfbG9jYWxlGAIgASgFEhUKDXNwZWVjaF9sb2NhbGUYAyABKAU=");
			LocaleInfoReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(LocaleInfo), LocaleInfo.Parser, new string[] { "BaseLocale", "TextLocale", "SpeechLocale" }, null, null, null, null)
			}));
		}

		// Token: 0x0400255B RID: 9563
		private static FileDescriptor descriptor;
	}
}
