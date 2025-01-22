using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x02000311 RID: 785
	public static class StoreProductInfoReflection
	{
		// Token: 0x17001AA7 RID: 6823
		// (get) Token: 0x060052C7 RID: 21191 RVA: 0x0013FC44 File Offset: 0x0013DE44
		public static FileDescriptor Descriptor
		{
			get
			{
				return StoreProductInfoReflection.descriptor;
			}
		}

		// Token: 0x060052C8 RID: 21192 RVA: 0x0013FC5C File Offset: 0x0013DE5C
		static StoreProductInfoReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "ChZTdG9yZVByb2R1Y3RJbmZvLnByb3RvEiNCbGl6emFyZC5UZWxlbWV0cnku", "RmVucmlzLkNsaWVudC52MSJ4ChBTdG9yZVByb2R1Y3RJbmZvEhIKCnByb2R1", "Y3RfaWQYASABKAMSFAoMcHJvZHVjdF9uYW1lGAIgASgJEiAKGG51bWJlcl9v", "Zl9vd25lZF9zdWJpdGVtcxgDIAEoDRIYChBjdXJyZW50X2Rpc2NvdW50GAQg", "ASgC" }));
			StoreProductInfoReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(StoreProductInfo), StoreProductInfo.Parser, new string[] { "ProductId", "ProductName", "NumberOfOwnedSubitems", "CurrentDiscount" }, null, null, null, null)
			}));
		}

		// Token: 0x0400258F RID: 9615
		private static FileDescriptor descriptor;
	}
}
