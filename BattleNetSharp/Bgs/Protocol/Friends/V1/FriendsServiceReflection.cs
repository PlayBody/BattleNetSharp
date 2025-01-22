using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Friends.V1
{
	// Token: 0x02000401 RID: 1025
	public static class FriendsServiceReflection
	{
		// Token: 0x17002091 RID: 8337
		// (get) Token: 0x06006582 RID: 25986 RVA: 0x00188878 File Offset: 0x00186A78
		public static FileDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.descriptor;
			}
		}

		// Token: 0x06006583 RID: 25987 RVA: 0x00188890 File Offset: 0x00186A90
		static FriendsServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CidiZ3MvbG93L3BiL2NsaWVudC9mcmllbmRzX3NlcnZpY2UucHJvdG8SF2Jn", "cy5wcm90b2NvbC5mcmllbmRzLnYxGidiZ3MvbG93L3BiL2NsaWVudC9hdHRy", "aWJ1dGVfdHlwZXMucHJvdG8aJGJncy9sb3cvcGIvY2xpZW50L2VudGl0eV90", "eXBlcy5wcm90bxolYmdzL2xvdy9wYi9jbGllbnQvZnJpZW5kc190eXBlcy5w", "cm90bxooYmdzL2xvdy9wYi9jbGllbnQvaW52aXRhdGlvbl90eXBlcy5wcm90", "bxohYmdzL2xvdy9wYi9jbGllbnQvcnBjX3R5cGVzLnByb3RvIk8KEFN1YnNj", "cmliZVJlcXVlc3QSKAoIYWdlbnRfaWQYASABKAsyFi5iZ3MucHJvdG9jb2wu", "RW50aXR5SWQSEQoJb2JqZWN0X2lkGAIgAigEIlEKElVuc3Vic2NyaWJlUmVx", "dWVzdBIoCghhZ2VudF9pZBgBIAEoCzIWLmJncy5wcm90b2NvbC5FbnRpdHlJ", "ZBIRCglvYmplY3RfaWQYAiABKAQiogEKFVNlbmRJbnZpdGF0aW9uUmVxdWVz",
				"dBIuCg5hZ2VudF9pZGVudGl0eRgBIAEoCzIWLmJncy5wcm90b2NvbC5JZGVu", "dGl0eRIpCgl0YXJnZXRfaWQYAiACKAsyFi5iZ3MucHJvdG9jb2wuRW50aXR5", "SWQSLgoGcGFyYW1zGAMgAigLMh4uYmdzLnByb3RvY29sLkludml0YXRpb25Q", "YXJhbXMiWgoXUmV2b2tlSW52aXRhdGlvblJlcXVlc3QSKAoIYWdlbnRfaWQY", "ASABKAsyFi5iZ3MucHJvdG9jb2wuRW50aXR5SWQSFQoNaW52aXRhdGlvbl9p", "ZBgCIAEoBiKdAQoXQWNjZXB0SW52aXRhdGlvblJlcXVlc3QSKAoIYWdlbnRf", "aWQYASABKAsyFi5iZ3MucHJvdG9jb2wuRW50aXR5SWQSFQoNaW52aXRhdGlv", "bl9pZBgDIAIoBhJBCgdvcHRpb25zGAQgASgLMjAuYmdzLnByb3RvY29sLmZy", "aWVuZHMudjEuQWNjZXB0SW52aXRhdGlvbk9wdGlvbnMiWwoYRGVjbGluZUlu", "dml0YXRpb25SZXF1ZXN0EigKCGFnZW50X2lkGAEgASgLMhYuYmdzLnByb3Rv",
				"Y29sLkVudGl0eUlkEhUKDWludml0YXRpb25faWQYAyACKAYiWgoXSWdub3Jl", "SW52aXRhdGlvblJlcXVlc3QSKAoIYWdlbnRfaWQYASABKAsyFi5iZ3MucHJv", "dG9jb2wuRW50aXR5SWQSFQoNaW52aXRhdGlvbl9pZBgDIAIoBiJqChNSZW1v", "dmVGcmllbmRSZXF1ZXN0EigKCGFnZW50X2lkGAEgASgLMhYuYmdzLnByb3Rv", "Y29sLkVudGl0eUlkEikKCXRhcmdldF9pZBgCIAIoCzIWLmJncy5wcm90b2Nv", "bC5FbnRpdHlJZCJPChtSZXZva2VBbGxJbnZpdGF0aW9uc1JlcXVlc3QSMAoI", "YWdlbnRfaWQYAiABKAsyFi5iZ3MucHJvdG9jb2wuRW50aXR5SWRCBoL5KwIQ", "ASJpChJWaWV3RnJpZW5kc1JlcXVlc3QSKAoIYWdlbnRfaWQYASABKAsyFi5i", "Z3MucHJvdG9jb2wuRW50aXR5SWQSKQoJdGFyZ2V0X2lkGAIgAigLMhYuYmdz", "LnByb3RvY29sLkVudGl0eUlkIk8KE1ZpZXdGcmllbmRzUmVzcG9uc2USOAoH",
				"ZnJpZW5kcxgBIAMoCzInLmJncy5wcm90b2NvbC5mcmllbmRzLnYxLkZyaWVu", "ZE9mRnJpZW5kIpsBChhVcGRhdGVGcmllbmRTdGF0ZVJlcXVlc3QSKAoIYWdl", "bnRfaWQYASABKAsyFi5iZ3MucHJvdG9jb2wuRW50aXR5SWQSKQoJdGFyZ2V0", "X2lkGAIgAigLMhYuYmdzLnByb3RvY29sLkVudGl0eUlkEioKCWF0dHJpYnV0", "ZRgDIAMoCzIXLmJncy5wcm90b2NvbC5BdHRyaWJ1dGUiSAoUR2V0RnJpZW5k", "TGlzdFJlcXVlc3QSMAoIYWdlbnRfaWQYAiABKAsyFi5iZ3MucHJvdG9jb2wu", "RW50aXR5SWRCBoL5KwIQASJJChVHZXRGcmllbmRMaXN0UmVzcG9uc2USMAoH", "ZnJpZW5kcxgBIAMoCzIfLmJncy5wcm90b2NvbC5mcmllbmRzLnYxLkZyaWVu", "ZCKcAQoXQ3JlYXRlRnJpZW5kc2hpcFJlcXVlc3QSMAoIYWdlbnRfaWQYASAB", "KAsyFi5iZ3MucHJvdG9jb2wuRW50aXR5SWRCBoL5KwIQARIpCgl0YXJnZXRf",
				"aWQYAiABKAsyFi5iZ3MucHJvdG9jb2wuRW50aXR5SWQSJAoEcm9sZRgDIAMo", "DUIWEAGK+SsGKgQKAggBivkrBioECgIQASJxChJGcmllbmROb3RpZmljYXRp", "b24SLwoGdGFyZ2V0GAEgAigLMh8uYmdzLnByb3RvY29sLmZyaWVuZHMudjEu", "RnJpZW5kEioKCmFjY291bnRfaWQYBSABKAsyFi5iZ3MucHJvdG9jb2wuRW50", "aXR5SWQihAEKHVVwZGF0ZUZyaWVuZFN0YXRlTm90aWZpY2F0aW9uEjcKDmNo", "YW5nZWRfZnJpZW5kGAEgAigLMh8uYmdzLnByb3RvY29sLmZyaWVuZHMudjEu", "RnJpZW5kEioKCmFjY291bnRfaWQYBSABKAsyFi5iZ3MucHJvdG9jb2wuRW50", "aXR5SWQimAEKFkludml0YXRpb25Ob3RpZmljYXRpb24SPwoKaW52aXRhdGlv", "bhgBIAIoCzIrLmJncy5wcm90b2NvbC5mcmllbmRzLnYxLlJlY2VpdmVkSW52", "aXRhdGlvbhIRCgZyZWFzb24YAyABKA06ATASKgoKYWNjb3VudF9pZBgFIAEo",
				"CzIWLmJncy5wcm90b2NvbC5FbnRpdHlJZCKKAQofU2VudEludml0YXRpb25B", "ZGRlZE5vdGlmaWNhdGlvbhIqCgphY2NvdW50X2lkGAEgASgLMhYuYmdzLnBy", "b3RvY29sLkVudGl0eUlkEjsKCmludml0YXRpb24YAiABKAsyJy5iZ3MucHJv", "dG9jb2wuZnJpZW5kcy52MS5TZW50SW52aXRhdGlvbiJ2CiFTZW50SW52aXRh", "dGlvblJlbW92ZWROb3RpZmljYXRpb24SKgoKYWNjb3VudF9pZBgBIAEoCzIW", "LmJncy5wcm90b2NvbC5FbnRpdHlJZBIVCg1pbnZpdGF0aW9uX2lkGAIgASgG", "Eg4KBnJlYXNvbhgDIAEoDTL5CgoORnJpZW5kc1NlcnZpY2USagoJU3Vic2Ny", "aWJlEikuYmdzLnByb3RvY29sLmZyaWVuZHMudjEuU3Vic2NyaWJlUmVxdWVz", "dBoqLmJncy5wcm90b2NvbC5mcmllbmRzLnYxLlN1YnNjcmliZVJlc3BvbnNl", "IgaC+SsCCAESXgoOU2VuZEludml0YXRpb24SLi5iZ3MucHJvdG9jb2wuZnJp",
				"ZW5kcy52MS5TZW5kSW52aXRhdGlvblJlcXVlc3QaFC5iZ3MucHJvdG9jb2wu", "Tm9EYXRhIgaC+SsCCAISYgoQQWNjZXB0SW52aXRhdGlvbhIwLmJncy5wcm90", "b2NvbC5mcmllbmRzLnYxLkFjY2VwdEludml0YXRpb25SZXF1ZXN0GhQuYmdz", "LnByb3RvY29sLk5vRGF0YSIGgvkrAggDEmIKEFJldm9rZUludml0YXRpb24S", "MC5iZ3MucHJvdG9jb2wuZnJpZW5kcy52MS5SZXZva2VJbnZpdGF0aW9uUmVx", "dWVzdBoULmJncy5wcm90b2NvbC5Ob0RhdGEiBoL5KwIIBBJnChFEZWNsaW5l", "SW52aXRhdGlvbhIxLmJncy5wcm90b2NvbC5mcmllbmRzLnYxLkRlY2xpbmVJ", "bnZpdGF0aW9uUmVxdWVzdBoULmJncy5wcm90b2NvbC5Ob0RhdGEiCYgCAYL5", "KwIIBRJiChBJZ25vcmVJbnZpdGF0aW9uEjAuYmdzLnByb3RvY29sLmZyaWVu", "ZHMudjEuSWdub3JlSW52aXRhdGlvblJlcXVlc3QaFC5iZ3MucHJvdG9jb2wu",
				"Tm9EYXRhIgaC+SsCCAYSWgoMUmVtb3ZlRnJpZW5kEiwuYmdzLnByb3RvY29s", "LmZyaWVuZHMudjEuUmVtb3ZlRnJpZW5kUmVxdWVzdBoULmJncy5wcm90b2Nv", "bC5Ob0RhdGEiBoL5KwIICBJwCgtWaWV3RnJpZW5kcxIrLmJncy5wcm90b2Nv", "bC5mcmllbmRzLnYxLlZpZXdGcmllbmRzUmVxdWVzdBosLmJncy5wcm90b2Nv", "bC5mcmllbmRzLnYxLlZpZXdGcmllbmRzUmVzcG9uc2UiBoL5KwIICRJkChFV", "cGRhdGVGcmllbmRTdGF0ZRIxLmJncy5wcm90b2NvbC5mcmllbmRzLnYxLlVw", "ZGF0ZUZyaWVuZFN0YXRlUmVxdWVzdBoULmJncy5wcm90b2NvbC5Ob0RhdGEi", "BoL5KwIIChJYCgtVbnN1YnNjcmliZRIrLmJncy5wcm90b2NvbC5mcmllbmRz", "LnYxLlVuc3Vic2NyaWJlUmVxdWVzdBoULmJncy5wcm90b2NvbC5Ob0RhdGEi", "BoL5KwIICxJqChRSZXZva2VBbGxJbnZpdGF0aW9ucxI0LmJncy5wcm90b2Nv",
				"bC5mcmllbmRzLnYxLlJldm9rZUFsbEludml0YXRpb25zUmVxdWVzdBoULmJn", "cy5wcm90b2NvbC5Ob0RhdGEiBoL5KwIIDBJ2Cg1HZXRGcmllbmRMaXN0Ei0u", "YmdzLnByb3RvY29sLmZyaWVuZHMudjEuR2V0RnJpZW5kTGlzdFJlcXVlc3Qa", "Li5iZ3MucHJvdG9jb2wuZnJpZW5kcy52MS5HZXRGcmllbmRMaXN0UmVzcG9u", "c2UiBoL5KwIIDRJiChBDcmVhdGVGcmllbmRzaGlwEjAuYmdzLnByb3RvY29s", "LmZyaWVuZHMudjEuQ3JlYXRlRnJpZW5kc2hpcFJlcXVlc3QaFC5iZ3MucHJv", "dG9jb2wuTm9EYXRhIgaC+SsCCA4aMIL5KyYKJGJuZXQucHJvdG9jb2wuZnJp", "ZW5kcy5GcmllbmRzU2VydmljZYr5KwIQATLMBgoPRnJpZW5kc0xpc3RlbmVy", "El8KDU9uRnJpZW5kQWRkZWQSKy5iZ3MucHJvdG9jb2wuZnJpZW5kcy52MS5G", "cmllbmROb3RpZmljYXRpb24aGS5iZ3MucHJvdG9jb2wuTk9fUkVTUE9OU0Ui",
				"BoL5KwIIARJhCg9PbkZyaWVuZFJlbW92ZWQSKy5iZ3MucHJvdG9jb2wuZnJp", "ZW5kcy52MS5GcmllbmROb3RpZmljYXRpb24aGS5iZ3MucHJvdG9jb2wuTk9f", "UkVTUE9OU0UiBoL5KwIIAhJvChlPblJlY2VpdmVkSW52aXRhdGlvbkFkZGVk", "Ei8uYmdzLnByb3RvY29sLmZyaWVuZHMudjEuSW52aXRhdGlvbk5vdGlmaWNh", "dGlvbhoZLmJncy5wcm90b2NvbC5OT19SRVNQT05TRSIGgvkrAggDEnEKG09u", "UmVjZWl2ZWRJbnZpdGF0aW9uUmVtb3ZlZBIvLmJncy5wcm90b2NvbC5mcmll", "bmRzLnYxLkludml0YXRpb25Ob3RpZmljYXRpb24aGS5iZ3MucHJvdG9jb2wu", "Tk9fUkVTUE9OU0UiBoL5KwIIBBJ0ChVPblNlbnRJbnZpdGF0aW9uQWRkZWQS", "OC5iZ3MucHJvdG9jb2wuZnJpZW5kcy52MS5TZW50SW52aXRhdGlvbkFkZGVk", "Tm90aWZpY2F0aW9uGhkuYmdzLnByb3RvY29sLk5PX1JFU1BPTlNFIgaC+SsC",
				"CAUSeAoXT25TZW50SW52aXRhdGlvblJlbW92ZWQSOi5iZ3MucHJvdG9jb2wu", "ZnJpZW5kcy52MS5TZW50SW52aXRhdGlvblJlbW92ZWROb3RpZmljYXRpb24a", "GS5iZ3MucHJvdG9jb2wuTk9fUkVTUE9OU0UiBoL5KwIIBhJwChNPblVwZGF0", "ZUZyaWVuZFN0YXRlEjYuYmdzLnByb3RvY29sLmZyaWVuZHMudjEuVXBkYXRl", "RnJpZW5kU3RhdGVOb3RpZmljYXRpb24aGS5iZ3MucHJvdG9jb2wuTk9fUkVT", "UE9OU0UiBoL5KwIIBxovgvkrJQojYm5ldC5wcm90b2NvbC5mcmllbmRzLkZy", "aWVuZHNOb3RpZnmK+SsCCAFCNQoYYm5ldC5wcm90b2NvbC5mcmllbmRzLnYx", "QhNGcmllbmRzU2VydmljZVByb3RvgAEAiAEB"
			}));
			FriendsServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				AttributeTypesReflection.Descriptor,
				EntityTypesReflection.Descriptor,
				FriendsTypesReflection.Descriptor,
				InvitationTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(SubscribeRequest), SubscribeRequest.Parser, new string[] { "AgentId", "ObjectId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UnsubscribeRequest), UnsubscribeRequest.Parser, new string[] { "AgentId", "ObjectId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SendInvitationRequest), SendInvitationRequest.Parser, new string[] { "AgentIdentity", "TargetId", "Params" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RevokeInvitationRequest), RevokeInvitationRequest.Parser, new string[] { "AgentId", "InvitationId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AcceptInvitationRequest), AcceptInvitationRequest.Parser, new string[] { "AgentId", "InvitationId", "Options" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(DeclineInvitationRequest), DeclineInvitationRequest.Parser, new string[] { "AgentId", "InvitationId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(IgnoreInvitationRequest), IgnoreInvitationRequest.Parser, new string[] { "AgentId", "InvitationId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RemoveFriendRequest), RemoveFriendRequest.Parser, new string[] { "AgentId", "TargetId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RevokeAllInvitationsRequest), RevokeAllInvitationsRequest.Parser, new string[] { "AgentId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ViewFriendsRequest), ViewFriendsRequest.Parser, new string[] { "AgentId", "TargetId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ViewFriendsResponse), ViewFriendsResponse.Parser, new string[] { "Friends" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UpdateFriendStateRequest), UpdateFriendStateRequest.Parser, new string[] { "AgentId", "TargetId", "Attribute" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetFriendListRequest), GetFriendListRequest.Parser, new string[] { "AgentId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetFriendListResponse), GetFriendListResponse.Parser, new string[] { "Friends" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CreateFriendshipRequest), CreateFriendshipRequest.Parser, new string[] { "AgentId", "TargetId", "Role" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(FriendNotification), FriendNotification.Parser, new string[] { "Target", "AccountId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UpdateFriendStateNotification), UpdateFriendStateNotification.Parser, new string[] { "ChangedFriend", "AccountId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(InvitationNotification), InvitationNotification.Parser, new string[] { "Invitation", "Reason", "AccountId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SentInvitationAddedNotification), SentInvitationAddedNotification.Parser, new string[] { "AccountId", "Invitation" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SentInvitationRemovedNotification), SentInvitationRemovedNotification.Parser, new string[] { "AccountId", "InvitationId", "Reason" }, null, null, null, null)
			}));
		}

		// Token: 0x04002E35 RID: 11829
		private static FileDescriptor descriptor;
	}
}
