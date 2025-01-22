using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.BlockList.V1.Client
{
	// Token: 0x02000705 RID: 1797
	public static class BlockListTypesReflection
	{
		// Token: 0x17003301 RID: 13057
		// (get) Token: 0x0600A50A RID: 42250 RVA: 0x002830EC File Offset: 0x002812EC
		public static FileDescriptor Descriptor
		{
			get
			{
				return BlockListTypesReflection.descriptor;
			}
		}

		// Token: 0x0600A50B RID: 42251 RVA: 0x00283104 File Offset: 0x00281304
		static BlockListTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjZiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YxL2Jsb2NrX2xpc3Rf", "dHlwZXMucHJvdG8SIWJncy5wcm90b2NvbC5ibG9ja19saXN0LnYxLmNsaWVu", "dBohYmdzL2xvdy9wYi9jbGllbnQvcnBjX3R5cGVzLnByb3RvImsKDUJsb2Nr", "ZWRQbGF5ZXISCgoCaWQYASABKAQSGgoKYmF0dGxlX3RhZxgCIAEoCUIGgvkr", "AggBEhgKEGNyZWF0aW9uX3RpbWVfdXMYBCABKAQSGAoQbW9kaWZpZWRfdGlt", "ZV91cxgFIAEoBCIyChJCbG9ja1BsYXllck9wdGlvbnMSHAoKYWNjb3VudF9p", "ZBgBIAEoBEIIivkrBBICEAAiNAoUVW5ibG9ja1BsYXllck9wdGlvbnMSHAoK", "YWNjb3VudF9pZBgBIAEoBEIIivkrBBICEAAiJQoXVW5ibG9ja1BsYXllckFz", "c2lnbm1lbnQSCgoCaWQYASABKAQiUgoOQmxvY2tMaXN0U3RhdGUSQAoGcGxh", "eWVyGAEgAygLMjAuYmdzLnByb3RvY29sLmJsb2NrX2xpc3QudjEuY2xpZW50",
				"LkJsb2NrZWRQbGF5ZXI="
			}));
			BlockListTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { RpcTypesReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(BlockedPlayer), BlockedPlayer.Parser, new string[] { "Id", "BattleTag", "CreationTimeUs", "ModifiedTimeUs" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(BlockPlayerOptions), BlockPlayerOptions.Parser, new string[] { "AccountId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UnblockPlayerOptions), UnblockPlayerOptions.Parser, new string[] { "AccountId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UnblockPlayerAssignment), UnblockPlayerAssignment.Parser, new string[] { "Id" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(BlockListState), BlockListState.Parser, new string[] { "Player" }, null, null, null, null)
			}));
		}

		// Token: 0x04004A4A RID: 19018
		private static FileDescriptor descriptor;
	}
}
