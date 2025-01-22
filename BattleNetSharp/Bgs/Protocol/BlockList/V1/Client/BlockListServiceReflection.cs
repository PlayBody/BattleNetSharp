using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.BlockList.V1.Client
{
	// Token: 0x020006FC RID: 1788
	public static class BlockListServiceReflection
	{
		// Token: 0x170032E6 RID: 13030
		// (get) Token: 0x0600A483 RID: 42115 RVA: 0x00281610 File Offset: 0x0027F810
		public static FileDescriptor Descriptor
		{
			get
			{
				return BlockListServiceReflection.descriptor;
			}
		}

		// Token: 0x0600A484 RID: 42116 RVA: 0x00281628 File Offset: 0x0027F828
		static BlockListServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjhiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YxL2Jsb2NrX2xpc3Rf", "c2VydmljZS5wcm90bxIhYmdzLnByb3RvY29sLmJsb2NrX2xpc3QudjEuY2xp", "ZW50GjZiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YxL2Jsb2NrX2xp", "c3RfdHlwZXMucHJvdG8aIWJncy9sb3cvcGIvY2xpZW50L3JwY190eXBlcy5w", "cm90byISChBTdWJzY3JpYmVSZXF1ZXN0IlUKEVN1YnNjcmliZVJlc3BvbnNl", "EkAKBXN0YXRlGAEgASgLMjEuYmdzLnByb3RvY29sLmJsb2NrX2xpc3QudjEu", "Y2xpZW50LkJsb2NrTGlzdFN0YXRlIhQKElVuc3Vic2NyaWJlUmVxdWVzdCIR", "Cg9HZXRTdGF0ZVJlcXVlc3QiVAoQR2V0U3RhdGVSZXNwb25zZRJACgVzdGF0", "ZRgBIAEoCzIxLmJncy5wcm90b2NvbC5ibG9ja19saXN0LnYxLmNsaWVudC5C", "bG9ja0xpc3RTdGF0ZSJmChJCbG9ja1BsYXllclJlcXVlc3QSUAoHb3B0aW9u",
				"cxgCIAEoCzI1LmJncy5wcm90b2NvbC5ibG9ja19saXN0LnYxLmNsaWVudC5C", "bG9ja1BsYXllck9wdGlvbnNCCIr5KwQyAggBImoKFFVuYmxvY2tQbGF5ZXJS", "ZXF1ZXN0ElIKB29wdGlvbnMYAiABKAsyNy5iZ3MucHJvdG9jb2wuYmxvY2tf", "bGlzdC52MS5jbGllbnQuVW5ibG9ja1BsYXllck9wdGlvbnNCCIr5KwQyAggB", "Mu4FChBCbG9ja0xpc3RTZXJ2aWNlEn4KCVN1YnNjcmliZRIzLmJncy5wcm90", "b2NvbC5ibG9ja19saXN0LnYxLmNsaWVudC5TdWJzY3JpYmVSZXF1ZXN0GjQu", "YmdzLnByb3RvY29sLmJsb2NrX2xpc3QudjEuY2xpZW50LlN1YnNjcmliZVJl", "c3BvbnNlIgaC+SsCCAESYgoLVW5zdWJzY3JpYmUSNS5iZ3MucHJvdG9jb2wu", "YmxvY2tfbGlzdC52MS5jbGllbnQuVW5zdWJzY3JpYmVSZXF1ZXN0GhQuYmdz", "LnByb3RvY29sLk5vRGF0YSIGgvkrAggCEnsKCEdldFN0YXRlEjIuYmdzLnBy",
				"b3RvY29sLmJsb2NrX2xpc3QudjEuY2xpZW50LkdldFN0YXRlUmVxdWVzdBoz", "LmJncy5wcm90b2NvbC5ibG9ja19saXN0LnYxLmNsaWVudC5HZXRTdGF0ZVJl", "c3BvbnNlIgaC+SsCCAMSYgoLQmxvY2tQbGF5ZXISNS5iZ3MucHJvdG9jb2wu", "YmxvY2tfbGlzdC52MS5jbGllbnQuQmxvY2tQbGF5ZXJSZXF1ZXN0GhQuYmdz", "LnByb3RvY29sLk5vRGF0YSIGgvkrAggEEmYKDVVuYmxvY2tQbGF5ZXISNy5i", "Z3MucHJvdG9jb2wuYmxvY2tfbGlzdC52MS5jbGllbnQuVW5ibG9ja1BsYXll", "clJlcXVlc3QaFC5iZ3MucHJvdG9jb2wuTm9EYXRhIgaC+SsCCAUSbAoVQmxv", "Y2tQbGF5ZXJGb3JTZXNzaW9uEjUuYmdzLnByb3RvY29sLmJsb2NrX2xpc3Qu", "djEuY2xpZW50LkJsb2NrUGxheWVyUmVxdWVzdBoULmJncy5wcm90b2NvbC5O", "b0RhdGEiBoL5KwIIBho/gvkrNQozYm5ldC5wcm90b2NvbC5ibG9ja19saXN0",
				"LnYxLmNsaWVudC5CbG9ja0xpc3RTZXJ2aWNlivkrAhAB"
			}));
			BlockListServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				BlockListTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(SubscribeRequest), SubscribeRequest.Parser, null, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SubscribeResponse), SubscribeResponse.Parser, new string[] { "State" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UnsubscribeRequest), UnsubscribeRequest.Parser, null, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetStateRequest), GetStateRequest.Parser, null, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetStateResponse), GetStateResponse.Parser, new string[] { "State" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(BlockPlayerRequest), BlockPlayerRequest.Parser, new string[] { "Options" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UnblockPlayerRequest), UnblockPlayerRequest.Parser, new string[] { "Options" }, null, null, null, null)
			}));
		}

		// Token: 0x04004A24 RID: 18980
		private static FileDescriptor descriptor;
	}
}
