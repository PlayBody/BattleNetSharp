using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x02000330 RID: 816
	public static class CommonStatEntryReflection
	{
		// Token: 0x17001B7F RID: 7039
		// (get) Token: 0x06005537 RID: 21815 RVA: 0x00149510 File Offset: 0x00147710
		public static FileDescriptor Descriptor
		{
			get
			{
				return CommonStatEntryReflection.descriptor;
			}
		}

		// Token: 0x06005538 RID: 21816 RVA: 0x00149528 File Offset: 0x00147728
		static CommonStatEntryReflection()
		{
			byte[] array = Convert.FromBase64String("Chdjb21tb25fc3RhdF9lbnRyeS5wcm90bxIgQmxpenphcmQuVGVsZW1ldHJ5" + "LkZlbndheS5DbGllbnQiNAoJU3RhdEVudHJ5EgoKAmlkGAEgASgNEgwKBG5h" + "bWUYAiABKAkSDQoFdmFsdWUYAyABKAM=");
			CommonStatEntryReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(StatEntry), StatEntry.Parser, new string[] { "Id", "Name", "Value" }, null, null, null, null)
			}));
		}

		// Token: 0x040026BB RID: 9915
		private static FileDescriptor descriptor;
	}
}
