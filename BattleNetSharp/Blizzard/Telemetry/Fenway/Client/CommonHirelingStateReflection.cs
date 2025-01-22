using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x02000328 RID: 808
	public static class CommonHirelingStateReflection
	{
		// Token: 0x17001B4A RID: 6986
		// (get) Token: 0x06005499 RID: 21657 RVA: 0x00146EE0 File Offset: 0x001450E0
		public static FileDescriptor Descriptor
		{
			get
			{
				return CommonHirelingStateReflection.descriptor;
			}
		}

		// Token: 0x0600549A RID: 21658 RVA: 0x00146EF8 File Offset: 0x001450F8
		static CommonHirelingStateReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "Chtjb21tb25faGlyZWxpbmdfc3RhdGUucHJvdG8SIEJsaXp6YXJkLlRlbGVt", "ZXRyeS5GZW53YXkuQ2xpZW50Ghhjb21tb25fc2tpbGxfc3RhdGUucHJvdG8a", "HGNvbW1vbl9pbnZlbnRvcnlfc3RhdGUucHJvdG8aF2NvbW1vbl9zdGF0X2Vu", "dHJ5LnByb3RvIvkBCg1IaXJlbGluZ1N0YXRlEgoKAmlkGAEgASgNEhIKCmNs", "YXNzX25hbWUYAiABKAkSOgoFc3RhdHMYAyADKAsyKy5CbGl6emFyZC5UZWxl", "bWV0cnkuRmVud2F5LkNsaWVudC5TdGF0RW50cnkSSQoPaW52ZW50b3J5X3N0", "YXRlGAQgASgLMjAuQmxpenphcmQuVGVsZW1ldHJ5LkZlbndheS5DbGllbnQu", "SW52ZW50b3J5U3RhdGUSQQoLc2tpbGxfc3RhdGUYBSABKAsyLC5CbGl6emFy", "ZC5UZWxlbWV0cnkuRmVud2F5LkNsaWVudC5Ta2lsbFN0YXRl" }));
			CommonHirelingStateReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				CommonSkillStateReflection.Descriptor,
				CommonInventoryStateReflection.Descriptor,
				CommonStatEntryReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(HirelingState), HirelingState.Parser, new string[] { "Id", "ClassName", "Stats", "InventoryState", "SkillState" }, null, null, null, null)
			}));
		}

		// Token: 0x0400266F RID: 9839
		private static FileDescriptor descriptor;
	}
}
