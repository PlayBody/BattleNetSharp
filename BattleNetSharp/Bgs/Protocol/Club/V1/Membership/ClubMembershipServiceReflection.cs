using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1.Membership
{
	// Token: 0x02000518 RID: 1304
	public static class ClubMembershipServiceReflection
	{
		// Token: 0x17002844 RID: 10308
		// (get) Token: 0x06007EF5 RID: 32501 RVA: 0x001EE7F0 File Offset: 0x001EC9F0
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClubMembershipServiceReflection.descriptor;
			}
		}

		// Token: 0x06007EF6 RID: 32502 RVA: 0x001EE808 File Offset: 0x001ECA08
		static ClubMembershipServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"Ci9iZ3MvbG93L3BiL2NsaWVudC9jbHViX21lbWJlcnNoaXBfc2VydmljZS5w", "cm90bxIfYmdzLnByb3RvY29sLmNsdWIudjEubWVtYmVyc2hpcBoiYmdzL2xv", "dy9wYi9jbGllbnQvY2x1Yl90eXBlcy5wcm90bxojYmdzL2xvdy9wYi9jbGll", "bnQvY2x1Yl9zdHJlYW0ucHJvdG8ijwEKEFN1YnNjcmliZVJlcXVlc3QSNAoI", "YWdlbnRfaWQYASABKAsyIi5iZ3MucHJvdG9jb2wuYWNjb3VudC52MS5BY2Nv", "dW50SWQSRQoHb3B0aW9ucxgCIAEoCzI0LmJncy5wcm90b2NvbC5jbHViLnYx", "LkNsdWJNZW1iZXJzaGlwU3Vic2NyaWJlT3B0aW9ucyJNChFTdWJzY3JpYmVS", "ZXNwb25zZRI4CgVzdGF0ZRgBIAEoCzIpLmJncy5wcm90b2NvbC5jbHViLnYx", "LkNsdWJNZW1iZXJzaGlwU3RhdGUiSgoSVW5zdWJzY3JpYmVSZXF1ZXN0EjQK", "CGFnZW50X2lkGAEgASgLMiIuYmdzLnByb3RvY29sLmFjY291bnQudjEuQWNj",
				"b3VudElkIo0BCg9HZXRTdGF0ZVJlcXVlc3QSNAoIYWdlbnRfaWQYASABKAsy", "Ii5iZ3MucHJvdG9jb2wuYWNjb3VudC52MS5BY2NvdW50SWQSRAoHb3B0aW9u", "cxgCIAEoCzIzLmJncy5wcm90b2NvbC5jbHViLnYxLkNsdWJNZW1iZXJzaGlw", "R2V0U3RhdGVPcHRpb25zIkwKEEdldFN0YXRlUmVzcG9uc2USOAoFc3RhdGUY", "ASABKAsyKS5iZ3MucHJvdG9jb2wuY2x1Yi52MS5DbHViTWVtYmVyc2hpcFN0", "YXRlIpkBCh9VcGRhdGVDbHViU2hhcmVkU2V0dGluZ3NSZXF1ZXN0EjQKCGFn", "ZW50X2lkGAEgASgLMiIuYmdzLnByb3RvY29sLmFjY291bnQudjEuQWNjb3Vu", "dElkEkAKB29wdGlvbnMYAiABKAsyLy5iZ3MucHJvdG9jb2wuY2x1Yi52MS5D", "bHViU2hhcmVkU2V0dGluZ3NPcHRpb25zIpgBChhHZXRTdHJlYW1NZW50aW9u", "c1JlcXVlc3QSNAoIYWdlbnRfaWQYASABKAsyIi5iZ3MucHJvdG9jb2wuYWNj",
				"b3VudC52MS5BY2NvdW50SWQSLgoHb3B0aW9ucxgCIAEoCzIdLmJncy5wcm90", "b2NvbC5HZXRFdmVudE9wdGlvbnMSFgoOZmV0Y2hfbWVzc2FnZXMYAyABKAgi", "ZwoZR2V0U3RyZWFtTWVudGlvbnNSZXNwb25zZRI0CgdtZW50aW9uGAEgAygL", "MiMuYmdzLnByb3RvY29sLmNsdWIudjEuU3RyZWFtTWVudGlvbhIUCgxjb250", "aW51YXRpb24YAiABKAQigwEKG1JlbW92ZVN0cmVhbU1lbnRpb25zUmVxdWVz", "dBI0CghhZ2VudF9pZBgBIAEoCzIiLmJncy5wcm90b2NvbC5hY2NvdW50LnYx", "LkFjY291bnRJZBIuCgptZW50aW9uX2lkGAIgAygLMhouYmdzLnByb3RvY29s", "LlRpbWVTZXJpZXNJZCJbCiNBZHZhbmNlU3RyZWFtTWVudGlvblZpZXdUaW1l", "UmVxdWVzdBI0CghhZ2VudF9pZBgBIAEoCzIiLmJncy5wcm90b2NvbC5hY2Nv", "dW50LnYxLkFjY291bnRJZDKxBwoVQ2x1Yk1lbWJlcnNoaXBTZXJ2aWNlEnoK",
				"CVN1YnNjcmliZRIxLmJncy5wcm90b2NvbC5jbHViLnYxLm1lbWJlcnNoaXAu", "U3Vic2NyaWJlUmVxdWVzdBoyLmJncy5wcm90b2NvbC5jbHViLnYxLm1lbWJl", "cnNoaXAuU3Vic2NyaWJlUmVzcG9uc2UiBoL5KwIIARJgCgtVbnN1YnNjcmli", "ZRIzLmJncy5wcm90b2NvbC5jbHViLnYxLm1lbWJlcnNoaXAuVW5zdWJzY3Jp", "YmVSZXF1ZXN0GhQuYmdzLnByb3RvY29sLk5vRGF0YSIGgvkrAggCEncKCEdl", "dFN0YXRlEjAuYmdzLnByb3RvY29sLmNsdWIudjEubWVtYmVyc2hpcC5HZXRT", "dGF0ZVJlcXVlc3QaMS5iZ3MucHJvdG9jb2wuY2x1Yi52MS5tZW1iZXJzaGlw", "LkdldFN0YXRlUmVzcG9uc2UiBoL5KwIIAxJ6ChhVcGRhdGVDbHViU2hhcmVk", "U2V0dGluZ3MSQC5iZ3MucHJvdG9jb2wuY2x1Yi52MS5tZW1iZXJzaGlwLlVw", "ZGF0ZUNsdWJTaGFyZWRTZXR0aW5nc1JlcXVlc3QaFC5iZ3MucHJvdG9jb2wu",
				"Tm9EYXRhIgaC+SsCCAQSkgEKEUdldFN0cmVhbU1lbnRpb25zEjkuYmdzLnBy", "b3RvY29sLmNsdWIudjEubWVtYmVyc2hpcC5HZXRTdHJlYW1NZW50aW9uc1Jl", "cXVlc3QaOi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5tZW1iZXJzaGlwLkdldFN0", "cmVhbU1lbnRpb25zUmVzcG9uc2UiBoL5KwIIBRJyChRSZW1vdmVTdHJlYW1N", "ZW50aW9ucxI8LmJncy5wcm90b2NvbC5jbHViLnYxLm1lbWJlcnNoaXAuUmVt", "b3ZlU3RyZWFtTWVudGlvbnNSZXF1ZXN0GhQuYmdzLnByb3RvY29sLk5vRGF0", "YSIGgvkrAggGEoIBChxBZHZhbmNlU3RyZWFtTWVudGlvblZpZXdUaW1lEkQu", "YmdzLnByb3RvY29sLmNsdWIudjEubWVtYmVyc2hpcC5BZHZhbmNlU3RyZWFt", "TWVudGlvblZpZXdUaW1lUmVxdWVzdBoULmJncy5wcm90b2NvbC5Ob0RhdGEi", "BoL5KwIIBxo3gvkrLQorYm5ldC5wcm90b2NvbC5jbHViLnYxLkNsdWJNZW1i",
				"ZXJzaGlwU2VydmljZYr5KwIQAUIDgAEA"
			}));
			ClubMembershipServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				ClubTypesReflection.Descriptor,
				ClubStreamReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(SubscribeRequest), SubscribeRequest.Parser, new string[] { "AgentId", "Options" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SubscribeResponse), SubscribeResponse.Parser, new string[] { "State" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UnsubscribeRequest), UnsubscribeRequest.Parser, new string[] { "AgentId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetStateRequest), GetStateRequest.Parser, new string[] { "AgentId", "Options" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetStateResponse), GetStateResponse.Parser, new string[] { "State" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UpdateClubSharedSettingsRequest), UpdateClubSharedSettingsRequest.Parser, new string[] { "AgentId", "Options" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetStreamMentionsRequest), GetStreamMentionsRequest.Parser, new string[] { "AgentId", "Options", "FetchMessages" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetStreamMentionsResponse), GetStreamMentionsResponse.Parser, new string[] { "Mention", "Continuation" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RemoveStreamMentionsRequest), RemoveStreamMentionsRequest.Parser, new string[] { "AgentId", "MentionId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AdvanceStreamMentionViewTimeRequest), AdvanceStreamMentionViewTimeRequest.Parser, new string[] { "AgentId" }, null, null, null, null)
			}));
		}

		// Token: 0x040039BB RID: 14779
		private static FileDescriptor descriptor;
	}
}
