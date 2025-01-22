using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x0200030F RID: 783
	public static class StoreInspectProductReflection
	{
		// Token: 0x17001A9F RID: 6815
		// (get) Token: 0x060052AC RID: 21164 RVA: 0x0013F578 File Offset: 0x0013D778
		public static FileDescriptor Descriptor
		{
			get
			{
				return StoreInspectProductReflection.descriptor;
			}
		}

		// Token: 0x060052AD RID: 21165 RVA: 0x0013F590 File Offset: 0x0013D790
		static StoreInspectProductReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "ChlTdG9yZUluc3BlY3RQcm9kdWN0LnByb3RvEiNCbGl6emFyZC5UZWxlbWV0", "cnkuRmVucmlzLkNsaWVudC52MRoWU3RvcmVTZXNzaW9uSW5mby5wcm90bxoW", "U3RvcmVQcm9kdWN0SW5mby5wcm90byLAAQoTU3RvcmVJbnNwZWN0UHJvZHVj", "dBJLCgxzZXNzaW9uX2luZm8YASABKAsyNS5CbGl6emFyZC5UZWxlbWV0cnku", "RmVucmlzLkNsaWVudC52MS5TdG9yZVNlc3Npb25JbmZvEksKDHByb2R1Y3Rf", "aW5mbxgCIAEoCzI1LkJsaXp6YXJkLlRlbGVtZXRyeS5GZW5yaXMuQ2xpZW50", "LnYxLlN0b3JlUHJvZHVjdEluZm8SDwoHaXRlbV9pZBgDIAEoAw==" }));
			StoreInspectProductReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				StoreSessionInfoReflection.Descriptor,
				StoreProductInfoReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(StoreInspectProduct), StoreInspectProduct.Parser, new string[] { "SessionInfo", "ProductInfo", "ItemId" }, null, null, null, null)
			}));
		}

		// Token: 0x04002584 RID: 9604
		private static FileDescriptor descriptor;
	}
}
