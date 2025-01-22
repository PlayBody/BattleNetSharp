using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x02000313 RID: 787
	public static class StorePurchaseBundleReflection
	{
		// Token: 0x17001AB3 RID: 6835
		// (get) Token: 0x060052EA RID: 21226 RVA: 0x00140428 File Offset: 0x0013E628
		public static FileDescriptor Descriptor
		{
			get
			{
				return StorePurchaseBundleReflection.descriptor;
			}
		}

		// Token: 0x060052EB RID: 21227 RVA: 0x00140440 File Offset: 0x0013E640
		static StorePurchaseBundleReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "ChlTdG9yZVB1cmNoYXNlQnVuZGxlLnByb3RvEiNCbGl6emFyZC5UZWxlbWV0", "cnkuRmVucmlzLkNsaWVudC52MRoWU3RvcmVTZXNzaW9uSW5mby5wcm90bxoW", "U3RvcmVQcm9kdWN0SW5mby5wcm90byKvAQoTU3RvcmVQdXJjaGFzZUJ1bmRs", "ZRJLCgxzZXNzaW9uX2luZm8YASABKAsyNS5CbGl6emFyZC5UZWxlbWV0cnku", "RmVucmlzLkNsaWVudC52MS5TdG9yZVNlc3Npb25JbmZvEksKDHByb2R1Y3Rf", "aW5mbxgCIAEoCzI1LkJsaXp6YXJkLlRlbGVtZXRyeS5GZW5yaXMuQ2xpZW50", "LnYxLlN0b3JlUHJvZHVjdEluZm8=" }));
			StorePurchaseBundleReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				StoreSessionInfoReflection.Descriptor,
				StoreProductInfoReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(StorePurchaseBundle), StorePurchaseBundle.Parser, new string[] { "SessionInfo", "ProductInfo" }, null, null, null, null)
			}));
		}

		// Token: 0x0400259F RID: 9631
		private static FileDescriptor descriptor;
	}
}
