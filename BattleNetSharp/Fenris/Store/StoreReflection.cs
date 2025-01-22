using System;
using Fenris.License;
using Google.Protobuf.Reflection;

namespace Fenris.Store
{
	// Token: 0x02000110 RID: 272
	public static class StoreReflection
	{
		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x060019EB RID: 6635 RVA: 0x0005C618 File Offset: 0x0005A818
		public static FileDescriptor Descriptor
		{
			get
			{
				return StoreReflection.descriptor;
			}
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x0005C630 File Offset: 0x0005A830
		static StoreReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "CgtTdG9yZS5wcm90bxIMRmVucmlzLlN0b3JlGg1MaWNlbnNlLnByb3RvImoK", "B0xpY2Vuc2USFwoPYm5ldF9saWNlbnNlX2lkGAEgASgNEjAKC2VudGl0bGVt", "ZW50GAIgASgLMhsuRmVucmlzLkxpY2Vuc2UuRW50aXRsZW1lbnQSFAoMbGlj", "ZW5zZV90eXBlGAQgASgNIkkKB0NhdGFsb2cSFQoNcHJvdG9fdmVyc2lvbhgB", "IAEoDRInCghsaWNlbnNlcxgDIAMoCzIVLkZlbnJpcy5TdG9yZS5MaWNlbnNl" }));
			StoreReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { LicenseReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(License), License.Parser, new string[] { "BnetLicenseId", "Entitlement", "LicenseType" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Catalog), Catalog.Parser, new string[] { "ProtoVersion", "Licenses" }, null, null, null, null)
			}));
		}

		// Token: 0x04000A5B RID: 2651
		private static FileDescriptor descriptor;
	}
}
