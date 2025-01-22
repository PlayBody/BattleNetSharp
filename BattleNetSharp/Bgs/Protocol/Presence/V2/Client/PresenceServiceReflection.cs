using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V2.Client
{
	// Token: 0x020005C2 RID: 1474
	public static class PresenceServiceReflection
	{
		// Token: 0x17002BDC RID: 11228
		// (get) Token: 0x06008BB3 RID: 35763 RVA: 0x0021E5FC File Offset: 0x0021C7FC
		public static FileDescriptor Descriptor
		{
			get
			{
				return PresenceServiceReflection.descriptor;
			}
		}

		// Token: 0x06008BB4 RID: 35764 RVA: 0x0021E614 File Offset: 0x0021C814
		static PresenceServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjZiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL3ByZXNlbmNlX3Nl", "cnZpY2UucHJvdG8SH2Jncy5wcm90b2NvbC5wcmVzZW5jZS52Mi5jbGllbnQa", "NGJncy9sb3cvcGIvY2xpZW50L2FwaS9jbGllbnQvdjIvcHJlc2VuY2VfdHlw", "ZXMucHJvdG8aIWJncy9sb3cvcGIvY2xpZW50L3JwY190eXBlcy5wcm90byIw", "ChVCYXRjaFN1YnNjcmliZVJlcXVlc3QSFwoLYWNjb3VudF9pZHMYASADKARC", "AhABIjIKF0JhdGNoVW5zdWJzY3JpYmVSZXF1ZXN0EhcKC2FjY291bnRfaWRz", "GAEgAygEQgIQASK3AQoMUXVlcnlSZXF1ZXN0EhIKCmFjY291bnRfaWQYASAB", "KAQSRwoOcXVlcnlfYmVoYXZpb3IYAiABKA4yLy5iZ3MucHJvdG9jb2wucHJl", "c2VuY2UudjIuUHJlc2VuY2VRdWVyeUJlaGF2aW9yEjgKBGtleXMYAyADKAsy", "Ki5iZ3MucHJvdG9jb2wucHJlc2VuY2UudjIuUHJlc2VuY2VGaWVsZEtleRIQ",
				"CghzaW5jZV91cxgEIAEoBCJNCg1RdWVyeVJlc3BvbnNlEjwKBnN0YXRlcxgB", "IAMoCzIsLmJncy5wcm90b2NvbC5wcmVzZW5jZS52Mi5QcmVzZW5jZUZpZWxk", "U3RhdGUiTwoNVXBkYXRlUmVxdWVzdBI+Cgd1cGRhdGVzGAEgAygLMi0uYmdz", "LnByb3RvY29sLnByZXNlbmNlLnYyLlByZXNlbmNlRmllbGRVcGRhdGUywgQK", "D1ByZXNlbmNlU2VydmljZRJmCg5CYXRjaFN1YnNjcmliZRI2LmJncy5wcm90", "b2NvbC5wcmVzZW5jZS52Mi5jbGllbnQuQmF0Y2hTdWJzY3JpYmVSZXF1ZXN0", "GhQuYmdzLnByb3RvY29sLk5vRGF0YSIGgvkrAggBEmoKEEJhdGNoVW5zdWJz", "Y3JpYmUSOC5iZ3MucHJvdG9jb2wucHJlc2VuY2UudjIuY2xpZW50LkJhdGNo", "VW5zdWJzY3JpYmVSZXF1ZXN0GhQuYmdzLnByb3RvY29sLk5vRGF0YSIGgvkr", "AggCEm4KBVF1ZXJ5Ei0uYmdzLnByb3RvY29sLnByZXNlbmNlLnYyLmNsaWVu",
				"dC5RdWVyeVJlcXVlc3QaLi5iZ3MucHJvdG9jb2wucHJlc2VuY2UudjIuY2xp", "ZW50LlF1ZXJ5UmVzcG9uc2UiBoL5KwIIAxJWCgZVcGRhdGUSLi5iZ3MucHJv", "dG9jb2wucHJlc2VuY2UudjIuY2xpZW50LlVwZGF0ZVJlcXVlc3QaFC5iZ3Mu", "cHJvdG9jb2wuTm9EYXRhIgaC+SsCCAQSUwoDVW5rEi4uYmdzLnByb3RvY29s", "LnByZXNlbmNlLnYyLmNsaWVudC5VcGRhdGVSZXF1ZXN0GhQuYmdzLnByb3Rv", "Y29sLk5vRGF0YSIGgvkrAggGGj6C+SsyCjBibmV0LnByb3RvY29sLnByZXNl", "bmNlLnYyLmNsaWVudC5QcmVzZW5jZVNlcnZpY2WK+SsECAEQAUIDgAEA"
			}));
			PresenceServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				PresenceTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(BatchSubscribeRequest), BatchSubscribeRequest.Parser, new string[] { "AccountIds" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(BatchUnsubscribeRequest), BatchUnsubscribeRequest.Parser, new string[] { "AccountIds" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(QueryRequest), QueryRequest.Parser, new string[] { "AccountId", "QueryBehavior", "Keys", "SinceUs" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(QueryResponse), QueryResponse.Parser, new string[] { "States" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UpdateRequest), UpdateRequest.Parser, new string[] { "Updates" }, null, null, null, null)
			}));
		}

		// Token: 0x04003F37 RID: 16183
		private static FileDescriptor descriptor;
	}
}
