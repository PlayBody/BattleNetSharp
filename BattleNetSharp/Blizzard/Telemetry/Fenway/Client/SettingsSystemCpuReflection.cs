using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x02000344 RID: 836
	public static class SettingsSystemCpuReflection
	{
		// Token: 0x17001C45 RID: 7237
		// (get) Token: 0x06005731 RID: 22321 RVA: 0x0015195C File Offset: 0x0014FB5C
		public static FileDescriptor Descriptor
		{
			get
			{
				return SettingsSystemCpuReflection.descriptor;
			}
		}

		// Token: 0x06005732 RID: 22322 RVA: 0x00151974 File Offset: 0x0014FB74
		static SettingsSystemCpuReflection()
		{
			byte[] array = Convert.FromBase64String("ChlzZXR0aW5nc19zeXN0ZW1fY3B1LnByb3RvEiBCbGl6emFyZC5UZWxlbWV0" + "cnkuRmVud2F5LkNsaWVudCJxCgpDcHVEZXRhaWxzEg4KBnZlbmRvchgBIAEo" + "CRINCgVicmFuZBgCIAEoCRIRCglmcmVxdWVuY3kYAyABKAQSEgoKY29yZV9j" + "b3VudBgEIAEoDRIdChVoYXJkd2FyZV90aHJlYWRfY291bnQYBSABKA0=");
			SettingsSystemCpuReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(CpuDetails), CpuDetails.Parser, new string[] { "Vendor", "Brand", "Frequency", "CoreCount", "HardwareThreadCount" }, null, null, null, null)
			}));
		}

		// Token: 0x040027CF RID: 10191
		private static FileDescriptor descriptor;
	}
}
