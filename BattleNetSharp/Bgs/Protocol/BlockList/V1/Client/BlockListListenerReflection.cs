using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.BlockList.V1.Client
{
	// Token: 0x020006F8 RID: 1784
	public static class BlockListListenerReflection
	{
		// Token: 0x170032D8 RID: 13016
		// (get) Token: 0x0600A44F RID: 42063 RVA: 0x00280A14 File Offset: 0x0027EC14
		public static FileDescriptor Descriptor
		{
			get
			{
				return BlockListListenerReflection.descriptor;
			}
		}

		// Token: 0x0600A450 RID: 42064 RVA: 0x00280A2C File Offset: 0x0027EC2C
		static BlockListListenerReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjliZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YxL2Jsb2NrX2xpc3Rf", "bGlzdGVuZXIucHJvdG8SIWJncy5wcm90b2NvbC5ibG9ja19saXN0LnYxLmNs", "aWVudBo2YmdzL2xvdy9wYi9jbGllbnQvYXBpL2NsaWVudC92MS9ibG9ja19s", "aXN0X3R5cGVzLnByb3RvGiFiZ3MvbG93L3BiL2NsaWVudC9ycGNfdHlwZXMu", "cHJvdG8ifAoeQmxvY2tlZFBsYXllckFkZGVkTm90aWZpY2F0aW9uEhgKEGFn", "ZW50X2FjY291bnRfaWQYASABKAQSQAoGcGxheWVyGAIgAygLMjAuYmdzLnBy", "b3RvY29sLmJsb2NrX2xpc3QudjEuY2xpZW50LkJsb2NrZWRQbGF5ZXIiiAEK", "IEJsb2NrZWRQbGF5ZXJSZW1vdmVkTm90aWZpY2F0aW9uEhgKEGFnZW50X2Fj", "Y291bnRfaWQYASABKAQSSgoGcGxheWVyGAIgAygLMjouYmdzLnByb3RvY29s", "LmJsb2NrX2xpc3QudjEuY2xpZW50LlVuYmxvY2tQbGF5ZXJBc3NpZ25tZW50",
				"MtYCChFCbG9ja0xpc3RMaXN0ZW5lchJ8ChRPbkJsb2NrZWRQbGF5ZXJBZGRl", "ZBJBLmJncy5wcm90b2NvbC5ibG9ja19saXN0LnYxLmNsaWVudC5CbG9ja2Vk", "UGxheWVyQWRkZWROb3RpZmljYXRpb24aGS5iZ3MucHJvdG9jb2wuTk9fUkVT", "UE9OU0UiBoL5KwIIARKAAQoWT25CbG9ja2VkUGxheWVyUmVtb3ZlZBJDLmJn", "cy5wcm90b2NvbC5ibG9ja19saXN0LnYxLmNsaWVudC5CbG9ja2VkUGxheWVy", "UmVtb3ZlZE5vdGlmaWNhdGlvbhoZLmJncy5wcm90b2NvbC5OT19SRVNQT05T", "RSIGgvkrAggCGkCC+Ss2CjRibmV0LnByb3RvY29sLmJsb2NrX2xpc3QudjEu", "Y2xpZW50LkJsb2NrTGlzdExpc3RlbmVyivkrAggB"
			}));
			BlockListListenerReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				BlockListTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(BlockedPlayerAddedNotification), BlockedPlayerAddedNotification.Parser, new string[] { "AgentAccountId", "Player" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(BlockedPlayerRemovedNotification), BlockedPlayerRemovedNotification.Parser, new string[] { "AgentAccountId", "Player" }, null, null, null, null)
			}));
		}

		// Token: 0x04004A0B RID: 18955
		private static FileDescriptor descriptor;
	}
}
