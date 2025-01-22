using System;
using Google.Protobuf.Reflection;

namespace Fenris.License
{
	// Token: 0x02000158 RID: 344
	public static class LicenseReflection
	{
		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x060023A0 RID: 9120 RVA: 0x0008A1F4 File Offset: 0x000883F4
		public static FileDescriptor Descriptor
		{
			get
			{
				return LicenseReflection.descriptor;
			}
		}

		// Token: 0x060023A1 RID: 9121 RVA: 0x0008A20C File Offset: 0x0008840C
		static LicenseReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"Cg1MaWNlbnNlLnByb3RvEg5GZW5yaXMuTGljZW5zZSJGCgtFbnRpdGxlbWVu", "dBIeChJjb250ZW50X2xpY2Vuc2VfaWQYASABKAU6Ai0xEhcKC3Byb2R1Y3Rf", "c25vGAIgASgFOgItMSKPAQoNUGxheWVyTGljZW5zZRIwCgtlbnRpdGxlbWVu", "dBgBIAEoCzIbLkZlbnJpcy5MaWNlbnNlLkVudGl0bGVtZW50EhsKE2Rpc3Bs", "YXlfZXhwaXJlX3RpbWUYAiABKAMSEwoLZXhwaXJlX3RpbWUYAyABKAMSGgoS", "aW5pdGlhbF9jYWNoZV90aW1lGAQgASgDIkQKCkNvbnN1bWFibGUSFwoLcHJv", "ZHVjdF9zbm8YASABKAU6Ai0xEh0KFWJuZXRfY29uc3VtYWJsZV9pZF92MhgC", "IAEoCSKRAQoXUGxheWVyQ29uc3VtYWJsZUxpY2Vuc2USLgoKY29uc3VtYWJs", "ZRgBIAEoCzIaLkZlbnJpcy5MaWNlbnNlLkNvbnN1bWFibGUSFQoNYWN0aXZh", "dGVfdGltZRgCIAEoAxITCgtleHBpcmVfdGltZRgDIAEoAxIaChJpbml0aWFs",
				"X2NhY2hlX3RpbWUYBCABKAMihwEKDlBsYXllckxpY2Vuc2VzEi8KCGxpY2Vu", "c2VzGAEgAygLMh0uRmVucmlzLkxpY2Vuc2UuUGxheWVyTGljZW5zZRJEChNj", "b25zdW1hYmxlX2xpY2Vuc2VzGAIgAygLMicuRmVucmlzLkxpY2Vuc2UuUGxh", "eWVyQ29uc3VtYWJsZUxpY2Vuc2U="
			}));
			LicenseReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(Entitlement), Entitlement.Parser, new string[] { "ContentLicenseId", "ProductSno" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PlayerLicense), PlayerLicense.Parser, new string[] { "Entitlement", "DisplayExpireTime", "ExpireTime", "InitialCacheTime" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Consumable), Consumable.Parser, new string[] { "ProductSno", "BnetConsumableIdV2" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PlayerConsumableLicense), PlayerConsumableLicense.Parser, new string[] { "Consumable", "ActivateTime", "ExpireTime", "InitialCacheTime" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PlayerLicenses), PlayerLicenses.Parser, new string[] { "Licenses", "ConsumableLicenses" }, null, null, null, null)
			}));
		}

		// Token: 0x04000FA3 RID: 4003
		private static FileDescriptor descriptor;
	}
}
