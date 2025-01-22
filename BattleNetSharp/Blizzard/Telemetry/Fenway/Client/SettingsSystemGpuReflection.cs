using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x02000346 RID: 838
	public static class SettingsSystemGpuReflection
	{
		// Token: 0x17001C53 RID: 7251
		// (get) Token: 0x06005758 RID: 22360 RVA: 0x0015225C File Offset: 0x0015045C
		public static FileDescriptor Descriptor
		{
			get
			{
				return SettingsSystemGpuReflection.descriptor;
			}
		}

		// Token: 0x06005759 RID: 22361 RVA: 0x00152274 File Offset: 0x00150474
		static SettingsSystemGpuReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "ChlzZXR0aW5nc19zeXN0ZW1fZ3B1LnByb3RvEiBCbGl6emFyZC5UZWxlbWV0", "cnkuRmVud2F5LkNsaWVudCJ9CgpHcHVEZXRhaWxzEhEKCXZlbmRvcl9pZBgB", "IAEoDRIRCglkZXZpY2VfaWQYAiABKA0SEwoLZGV2aWNlX25hbWUYAyABKAkS", "FgoOZHJpdmVyX3ZlcnNpb24YBCABKAQSHAoUdmlkZW9fbWVtb3J5X3NpemVf", "Z2IYBiABKAI=" }));
			SettingsSystemGpuReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(GpuDetails), GpuDetails.Parser, new string[] { "VendorId", "DeviceId", "DeviceName", "DriverVersion", "VideoMemorySizeGb" }, null, null, null, null)
			}));
		}

		// Token: 0x040027E2 RID: 10210
		private static FileDescriptor descriptor;
	}
}
