using System;
using Bgs.Protocol.Account.V1;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006B7 RID: 1719
	public static class ChannelInvitationServiceReflection
	{
		// Token: 0x1700315C RID: 12636
		// (get) Token: 0x06009F03 RID: 40707 RVA: 0x0026ACE8 File Offset: 0x00268EE8
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChannelInvitationServiceReflection.descriptor;
			}
		}

		// Token: 0x06009F04 RID: 40708 RVA: 0x0026AD00 File Offset: 0x00268F00
		static ChannelInvitationServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjJiZ3MvbG93L3BiL2NsaWVudC9jaGFubmVsX2ludml0YXRpb25fc2Vydmlj", "ZS5wcm90bxIXYmdzLnByb3RvY29sLmNoYW5uZWwudjEaJWJncy9sb3cvcGIv", "Y2xpZW50L2FjY291bnRfdHlwZXMucHJvdG8aMGJncy9sb3cvcGIvY2xpZW50", "L2NoYW5uZWxfaW52aXRhdGlvbl90eXBlcy5wcm90bxokYmdzL2xvdy9wYi9j", "bGllbnQvZW50aXR5X3R5cGVzLnByb3RvGihiZ3MvbG93L3BiL2NsaWVudC9p", "bnZpdGF0aW9uX3R5cGVzLnByb3RvGiFiZ3MvbG93L3BiL2NsaWVudC9ycGNf", "dHlwZXMucHJvdG8icgoVU2VuZEludml0YXRpb25SZXF1ZXN0EikKCXRhcmdl", "dF9pZBgCIAIoCzIWLmJncy5wcm90b2NvbC5FbnRpdHlJZBIuCgZwYXJhbXMY", "AyACKAsyHi5iZ3MucHJvdG9jb2wuSW52aXRhdGlvblBhcmFtcyJDChdBY2Nl", "cHRJbnZpdGF0aW9uUmVxdWVzdBIVCg1pbnZpdGF0aW9uX2lkGAMgAigGEhEK",
				"CW9iamVjdF9pZBgEIAIoBCItChhBY2NlcHRJbnZpdGF0aW9uUmVzcG9uc2US", "EQoJb2JqZWN0X2lkGAEgAigEIjEKGERlY2xpbmVJbnZpdGF0aW9uUmVxdWVz", "dBIVCg1pbnZpdGF0aW9uX2lkGAMgAigGInsKEFN1YnNjcmliZVJlcXVlc3QS", "KAoIYWdlbnRfaWQYASABKAsyFi5iZ3MucHJvdG9jb2wuRW50aXR5SWQSEQoJ", "b2JqZWN0X2lkGAIgAigEEioKCmFjY291bnRfaWQYAyABKAsyFi5iZ3MucHJv", "dG9jb2wuRW50aXR5SWQingEKGFN1Z2dlc3RJbnZpdGF0aW9uUmVxdWVzdBIq", "CgpjaGFubmVsX2lkGAIgAigLMhYuYmdzLnByb3RvY29sLkVudGl0eUlkEikK", "CXRhcmdldF9pZBgDIAIoCzIWLmJncy5wcm90b2NvbC5FbnRpdHlJZBIrCgth", "cHByb3ZhbF9pZBgEIAEoCzIWLmJncy5wcm90b2NvbC5FbnRpdHlJZCJcChdS", "ZXZva2VJbnZpdGF0aW9uUmVxdWVzdBIVCg1pbnZpdGF0aW9uX2lkGAMgAigG",
				"EioKCmNoYW5uZWxfaWQYBCACKAsyFi5iZ3MucHJvdG9jb2wuRW50aXR5SWQi", "WgoXTGlzdENoYW5uZWxDb3VudFJlcXVlc3QSKQoJbWVtYmVyX2lkGAEgAigL", "MhYuYmdzLnByb3RvY29sLkVudGl0eUlkEhQKDHNlcnZpY2VfdHlwZRgCIAIo", "DSJSChhMaXN0Q2hhbm5lbENvdW50UmVzcG9uc2USNgoHY2hhbm5lbBgBIAMo", "CzIlLmJncy5wcm90b2NvbC5jaGFubmVsLnYxLkNoYW5uZWxDb3VudCKCAQob", "SW52aXRhdGlvbkFkZGVkTm90aWZpY2F0aW9uEiwKCmludml0YXRpb24YASAC", "KAsyGC5iZ3MucHJvdG9jb2wuSW52aXRhdGlvbhI1CgpzdWJzY3JpYmVyGAIg", "ASgLMiEuYmdzLnByb3RvY29sLmFjY291bnQudjEuSWRlbnRpdHkilAEKHUlu", "dml0YXRpb25SZW1vdmVkTm90aWZpY2F0aW9uEiwKCmludml0YXRpb24YASAC", "KAsyGC5iZ3MucHJvdG9jb2wuSW52aXRhdGlvbhIOCgZyZWFzb24YAiABKA0S",
				"NQoKc3Vic2NyaWJlchgDIAEoCzIhLmJncy5wcm90b2NvbC5hY2NvdW50LnYx", "LklkZW50aXR5IpcBChtTdWdnZXN0aW9uQWRkZWROb3RpZmljYXRpb24SQQoK", "c3VnZ2VzdGlvbhgBIAIoCzItLmJncy5wcm90b2NvbC5jaGFubmVsLnYxLklu", "dml0YXRpb25TdWdnZXN0aW9uEjUKCnN1YnNjcmliZXIYAiABKAsyIS5iZ3Mu", "cHJvdG9jb2wuYWNjb3VudC52MS5JZGVudGl0eTLJBgoYQ2hhbm5lbEludml0", "YXRpb25TZXJ2aWNlElQKCVN1YnNjcmliZRIpLmJncy5wcm90b2NvbC5jaGFu", "bmVsLnYxLlN1YnNjcmliZVJlcXVlc3QaFC5iZ3MucHJvdG9jb2wuTm9EYXRh", "IgaC+SsCCAESXgoOU2VuZEludml0YXRpb24SLi5iZ3MucHJvdG9jb2wuY2hh", "bm5lbC52MS5TZW5kSW52aXRhdGlvblJlcXVlc3QaFC5iZ3MucHJvdG9jb2wu", "Tm9EYXRhIgaC+SsCCAMSfwoQQWNjZXB0SW52aXRhdGlvbhIwLmJncy5wcm90",
				"b2NvbC5jaGFubmVsLnYxLkFjY2VwdEludml0YXRpb25SZXF1ZXN0GjEuYmdz", "LnByb3RvY29sLmNoYW5uZWwudjEuQWNjZXB0SW52aXRhdGlvblJlc3BvbnNl", "IgaC+SsCCAQSZAoRRGVjbGluZUludml0YXRpb24SMS5iZ3MucHJvdG9jb2wu", "Y2hhbm5lbC52MS5EZWNsaW5lSW52aXRhdGlvblJlcXVlc3QaFC5iZ3MucHJv", "dG9jb2wuTm9EYXRhIgaC+SsCCAUSYgoQUmV2b2tlSW52aXRhdGlvbhIwLmJn", "cy5wcm90b2NvbC5jaGFubmVsLnYxLlJldm9rZUludml0YXRpb25SZXF1ZXN0", "GhQuYmdzLnByb3RvY29sLk5vRGF0YSIGgvkrAggGEmQKEVN1Z2dlc3RJbnZp", "dGF0aW9uEjEuYmdzLnByb3RvY29sLmNoYW5uZWwudjEuU3VnZ2VzdEludml0", "YXRpb25SZXF1ZXN0GhQuYmdzLnByb3RvY29sLk5vRGF0YSIGgvkrAggHEn8K", "EExpc3RDaGFubmVsQ291bnQSMC5iZ3MucHJvdG9jb2wuY2hhbm5lbC52MS5M",
				"aXN0Q2hhbm5lbENvdW50UmVxdWVzdBoxLmJncy5wcm90b2NvbC5jaGFubmVs", "LnYxLkxpc3RDaGFubmVsQ291bnRSZXNwb25zZSIGgvkrAggLGkWC+Ss7Cjli", "bmV0LnByb3RvY29sLmNoYW5uZWxfaW52aXRhdGlvbi5DaGFubmVsSW52aXRh", "dGlvblNlcnZpY2WK+SsCEAEyxwMKGUNoYW5uZWxJbnZpdGF0aW9uTGlzdGVu", "ZXISdAoZT25SZWNlaXZlZEludml0YXRpb25BZGRlZBI0LmJncy5wcm90b2Nv", "bC5jaGFubmVsLnYxLkludml0YXRpb25BZGRlZE5vdGlmaWNhdGlvbhoZLmJn", "cy5wcm90b2NvbC5OT19SRVNQT05TRSIGgvkrAggBEngKG09uUmVjZWl2ZWRJ", "bnZpdGF0aW9uUmVtb3ZlZBI2LmJncy5wcm90b2NvbC5jaGFubmVsLnYxLklu", "dml0YXRpb25SZW1vdmVkTm90aWZpY2F0aW9uGhkuYmdzLnByb3RvY29sLk5P", "X1JFU1BPTlNFIgaC+SsCCAISdAoZT25SZWNlaXZlZFN1Z2dlc3Rpb25BZGRl",
				"ZBI0LmJncy5wcm90b2NvbC5jaGFubmVsLnYxLlN1Z2dlc3Rpb25BZGRlZE5v", "dGlmaWNhdGlvbhoZLmJncy5wcm90b2NvbC5OT19SRVNQT05TRSIGgvkrAggD", "GkSC+Ss6CjhibmV0LnByb3RvY29sLmNoYW5uZWxfaW52aXRhdGlvbi5DaGFu", "bmVsSW52aXRhdGlvbk5vdGlmeYr5KwIIAUIFSAGAAQA="
			}));
			ChannelInvitationServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				AccountTypesReflection.Descriptor,
				ChannelInvitationTypesReflection.Descriptor,
				EntityTypesReflection.Descriptor,
				InvitationTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(SendInvitationRequest), SendInvitationRequest.Parser, new string[] { "TargetId", "Params" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AcceptInvitationRequest), AcceptInvitationRequest.Parser, new string[] { "InvitationId", "ObjectId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AcceptInvitationResponse), AcceptInvitationResponse.Parser, new string[] { "ObjectId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(DeclineInvitationRequest), DeclineInvitationRequest.Parser, new string[] { "InvitationId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SubscribeRequest), SubscribeRequest.Parser, new string[] { "AgentId", "ObjectId", "AccountId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SuggestInvitationRequest), SuggestInvitationRequest.Parser, new string[] { "ChannelId", "TargetId", "ApprovalId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RevokeInvitationRequest), RevokeInvitationRequest.Parser, new string[] { "InvitationId", "ChannelId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ListChannelCountRequest), ListChannelCountRequest.Parser, new string[] { "MemberId", "ServiceType" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ListChannelCountResponse), ListChannelCountResponse.Parser, new string[] { "Channel" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(InvitationAddedNotification), InvitationAddedNotification.Parser, new string[] { "Invitation", "Subscriber" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(InvitationRemovedNotification), InvitationRemovedNotification.Parser, new string[] { "Invitation", "Reason", "Subscriber" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SuggestionAddedNotification), SuggestionAddedNotification.Parser, new string[] { "Suggestion", "Subscriber" }, null, null, null, null)
			}));
		}

		// Token: 0x040047BC RID: 18364
		private static FileDescriptor descriptor;
	}
}
