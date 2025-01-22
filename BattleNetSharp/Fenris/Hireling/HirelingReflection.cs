using System;
using Google.Protobuf.Reflection;

namespace Fenris.Hireling
{
	// Token: 0x02000175 RID: 373
	public static class HirelingReflection
	{
		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x060026C7 RID: 9927 RVA: 0x000967A4 File Offset: 0x000949A4
		public static FileDescriptor Descriptor
		{
			get
			{
				return HirelingReflection.descriptor;
			}
		}

		// Token: 0x060026C8 RID: 9928 RVA: 0x000967BC File Offset: 0x000949BC
		static HirelingReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "Cg5IaXJlbGluZy5wcm90bxIPRmVucmlzLkhpcmVsaW5nIqUBCgRJbmZvEhYK", "DmhpcmVsaW5nX2NsYXNzGAEgASgREhUKCWdiaWRfbmFtZRgCIAEoDzoCLTES", "GAoQbGV2ZWxfZGVwcmVjYXRlZBgDIAEoERIsCiRhdHRyaWJ1dGVfZXhwZXJp", "ZW5jZV9uZXh0X2RlcHJlY2F0ZWQYBCABKA0SGAoQcG93ZXJfa2V5X3BhcmFt", "cxgFIAMoERIMCgRkZWFkGAYgASgIIngKCVNhdmVkRGF0YRIoCgloaXJlbGlu", "Z3MYASADKAsyFS5GZW5yaXMuSGlyZWxpbmcuSW5mbxIbCg9hY3RpdmVfaGly", "ZWxpbmcYAiABKBE6Ai0xEiQKHGF2YWlsYWJsZV9oaXJlbGluZ3NfYml0Zmll", "bGQYAyABKA0=" }));
			HirelingReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(Info), Info.Parser, new string[] { "HirelingClass", "GbidName", "LevelDeprecated", "AttributeExperienceNextDeprecated", "PowerKeyParams", "Dead" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SavedData), SavedData.Parser, new string[] { "Hirelings", "ActiveHireling", "AvailableHirelingsBitfield" }, null, null, null, null)
			}));
		}

		// Token: 0x04001122 RID: 4386
		private static FileDescriptor descriptor;
	}
}
