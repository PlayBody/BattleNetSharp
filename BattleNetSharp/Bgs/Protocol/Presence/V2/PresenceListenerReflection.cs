using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V2
{
	// Token: 0x020005B2 RID: 1458
	public static class PresenceListenerReflection
	{
		// Token: 0x17002B8A RID: 11146
		// (get) Token: 0x06008A96 RID: 35478 RVA: 0x0021A624 File Offset: 0x00218824
		public static FileDescriptor Descriptor
		{
			get
			{
				return PresenceListenerReflection.descriptor;
			}
		}

		// Token: 0x06008A97 RID: 35479 RVA: 0x0021A63C File Offset: 0x0021883C
		static PresenceListenerReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjdiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL3ByZXNlbmNlX2xp", "c3RlbmVyLnByb3RvEhhiZ3MucHJvdG9jb2wucHJlc2VuY2UudjIaNGJncy9s", "b3cvcGIvY2xpZW50L2FwaS9jbGllbnQvdjIvcHJlc2VuY2VfdHlwZXMucHJv", "dG8aIWJncy9sb3cvcGIvY2xpZW50L3JwY190eXBlcy5wcm90byJ3CiBQcmVz", "ZW5jZVN0YXRlVXBkYXRlZE5vdGlmaWNhdGlvbhIVCg1zdWJzY3JpYmVyX2lk", "GAEgASgEEjwKBnN0YXRlcxgCIAMoCzIsLmJncy5wcm90b2NvbC5wcmVzZW5j", "ZS52Mi5QcmVzZW5jZUZpZWxkU3RhdGUiPAoWU3Vic2NyaWJlRmFpbHVyZVJl", "c3VsdBISCgphY2NvdW50X2lkGAEgASgEEg4KBnN0YXR1cxgCIAEoDSJiChxT", "dWJzY3JpYmVGYWlsdXJlTm90aWZpY2F0aW9uEkIKCGZhaWx1cmVzGAEgAygL", "MjAuYmdzLnByb3RvY29sLnByZXNlbmNlLnYyLlN1YnNjcmliZUZhaWx1cmVS",
				"ZXN1bHQyvQIKEFByZXNlbmNlTGlzdGVuZXISdwoWT25QcmVzZW5jZVN0YXRl", "VXBkYXRlZBI6LmJncy5wcm90b2NvbC5wcmVzZW5jZS52Mi5QcmVzZW5jZVN0", "YXRlVXBkYXRlZE5vdGlmaWNhdGlvbhoZLmJncy5wcm90b2NvbC5OT19SRVNQ", "T05TRSIGgvkrAggBEm8KEk9uU3Vic2NyaWJlRmFpbHVyZRI2LmJncy5wcm90", "b2NvbC5wcmVzZW5jZS52Mi5TdWJzY3JpYmVGYWlsdXJlTm90aWZpY2F0aW9u", "GhkuYmdzLnByb3RvY29sLk5PX1JFU1BPTlNFIgaC+SsCCAIaP4L5KzMKMWJu", "ZXQucHJvdG9jb2wucHJlc2VuY2UudjIuY2xpZW50LlByZXNlbmNlTGlzdGVu", "ZXKK+SsECAEQAQ=="
			}));
			PresenceListenerReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				PresenceTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(PresenceStateUpdatedNotification), PresenceStateUpdatedNotification.Parser, new string[] { "SubscriberId", "States" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SubscribeFailureResult), SubscribeFailureResult.Parser, new string[] { "AccountId", "Status" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SubscribeFailureNotification), SubscribeFailureNotification.Parser, new string[] { "Failures" }, null, null, null, null)
			}));
		}

		// Token: 0x04003EBA RID: 16058
		private static FileDescriptor descriptor;
	}
}
