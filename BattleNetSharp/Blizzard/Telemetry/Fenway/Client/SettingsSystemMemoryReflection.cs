using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x02000348 RID: 840
	public static class SettingsSystemMemoryReflection
	{
		// Token: 0x17001C61 RID: 7265
		// (get) Token: 0x0600577F RID: 22399 RVA: 0x00152B94 File Offset: 0x00150D94
		public static FileDescriptor Descriptor
		{
			get
			{
				return SettingsSystemMemoryReflection.descriptor;
			}
		}

		// Token: 0x06005780 RID: 22400 RVA: 0x00152BAC File Offset: 0x00150DAC
		static SettingsSystemMemoryReflection()
		{
			byte[] array = Convert.FromBase64String("ChxzZXR0aW5nc19zeXN0ZW1fbWVtb3J5LnByb3RvEiBCbGl6emFyZC5UZWxl" + "bWV0cnkuRmVud2F5LkNsaWVudCIoCg1NZW1vcnlEZXRhaWxzEhcKD3RvdGFs" + "X21lbW9yeV9nYhgBIAEoAg==");
			SettingsSystemMemoryReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MemoryDetails), MemoryDetails.Parser, new string[] { "TotalMemoryGb" }, null, null, null, null)
			}));
		}

		// Token: 0x040027F5 RID: 10229
		private static FileDescriptor descriptor;
	}
}
