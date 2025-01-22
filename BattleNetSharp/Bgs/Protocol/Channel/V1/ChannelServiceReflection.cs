using System;
using Bgs.Protocol.Account.V1;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006D7 RID: 1751
	public static class ChannelServiceReflection
	{
		// Token: 0x17003208 RID: 12808
		// (get) Token: 0x0600A183 RID: 41347 RVA: 0x002749E8 File Offset: 0x00272BE8
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.descriptor;
			}
		}

		// Token: 0x0600A184 RID: 41348 RVA: 0x00274A00 File Offset: 0x00272C00
		static ChannelServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CidiZ3MvbG93L3BiL2NsaWVudC9jaGFubmVsX3NlcnZpY2UucHJvdG8SF2Jn", "cy5wcm90b2NvbC5jaGFubmVsLnYxGiViZ3MvbG93L3BiL2NsaWVudC9hY2Nv", "dW50X3R5cGVzLnByb3RvGiRiZ3MvbG93L3BiL2NsaWVudC9lbnRpdHlfdHlw", "ZXMucHJvdG8aJWJncy9sb3cvcGIvY2xpZW50L2NoYW5uZWxfdHlwZXMucHJv", "dG8aIWJncy9sb3cvcGIvY2xpZW50L3JwY190eXBlcy5wcm90byJ6ChNSZW1v", "dmVNZW1iZXJSZXF1ZXN0EigKCGFnZW50X2lkGAEgASgLMhYuYmdzLnByb3Rv", "Y29sLkVudGl0eUlkEikKCW1lbWJlcl9pZBgCIAIoCzIWLmJncy5wcm90b2Nv", "bC5FbnRpdHlJZBIOCgZyZWFzb24YAyABKA0ikQEKElNlbmRNZXNzYWdlUmVx", "dWVzdBIoCghhZ2VudF9pZBgBIAEoCzIWLmJncy5wcm90b2NvbC5FbnRpdHlJ", "ZBIxCgdtZXNzYWdlGAIgAigLMiAuYmdzLnByb3RvY29sLmNoYW5uZWwudjEu",
				"TWVzc2FnZRIeChNyZXF1aXJlZF9wcml2aWxlZ2VzGAMgASgEOgEwIoIBChlV", "cGRhdGVDaGFubmVsU3RhdGVSZXF1ZXN0EigKCGFnZW50X2lkGAEgASgLMhYu", "YmdzLnByb3RvY29sLkVudGl0eUlkEjsKDHN0YXRlX2NoYW5nZRgCIAIoCzIl", "LmJncy5wcm90b2NvbC5jaGFubmVsLnYxLkNoYW5uZWxTdGF0ZSKVAQoYVXBk", "YXRlTWVtYmVyU3RhdGVSZXF1ZXN0EigKCGFnZW50X2lkGAEgASgLMhYuYmdz", "LnByb3RvY29sLkVudGl0eUlkEjUKDHN0YXRlX2NoYW5nZRgCIAMoCzIfLmJn", "cy5wcm90b2NvbC5jaGFubmVsLnYxLk1lbWJlchIYCgxyZW1vdmVkX3JvbGUY", "AyADKA1CAhABIksKD0Rpc3NvbHZlUmVxdWVzdBIoCghhZ2VudF9pZBgBIAEo", "CzIWLmJncy5wcm90b2NvbC5FbnRpdHlJZBIOCgZyZWFzb24YAiABKA0i2gIK", "EEpvaW5Ob3RpZmljYXRpb24SLQoEc2VsZhgBIAEoCzIfLmJncy5wcm90b2Nv",
				"bC5jaGFubmVsLnYxLk1lbWJlchIvCgZtZW1iZXIYAiADKAsyHy5iZ3MucHJv", "dG9jb2wuY2hhbm5lbC52MS5NZW1iZXISPAoNY2hhbm5lbF9zdGF0ZRgDIAIo", "CzIlLmJncy5wcm90b2NvbC5jaGFubmVsLnYxLkNoYW5uZWxTdGF0ZRI2Cgpj", "aGFubmVsX2lkGAQgASgLMiIuYmdzLnByb3RvY29sLmNoYW5uZWwudjEuQ2hh", "bm5lbElkEjUKCnN1YnNjcmliZXIYBSABKAsyIS5iZ3MucHJvdG9jb2wuYWNj", "b3VudC52MS5JZGVudGl0eRI5Cg1zdWJzY3JpYmVyX2lkGAYgASgLMiIuYmdz", "LnByb3RvY29sLmFjY291bnQudjEuQWNjb3VudElkIrkBChdNZW1iZXJBZGRl", "ZE5vdGlmaWNhdGlvbhIvCgZtZW1iZXIYASACKAsyHy5iZ3MucHJvdG9jb2wu", "Y2hhbm5lbC52MS5NZW1iZXISNgoKY2hhbm5lbF9pZBgCIAEoCzIiLmJncy5w", "cm90b2NvbC5jaGFubmVsLnYxLkNoYW5uZWxJZBI1CgpzdWJzY3JpYmVyGAMg",
				"ASgLMiEuYmdzLnByb3RvY29sLmFjY291bnQudjEuSWRlbnRpdHki6wEKEUxl", "YXZlTm90aWZpY2F0aW9uEigKCGFnZW50X2lkGAEgASgLMhYuYmdzLnByb3Rv", "Y29sLkVudGl0eUlkEi0KCW1lbWJlcl9pZBgCIAIoCzIWLmJncy5wcm90b2Nv", "bC5FbnRpdHlJZEICGAESDgoGcmVhc29uGAMgASgNEjYKCmNoYW5uZWxfaWQY", "BCABKAsyIi5iZ3MucHJvdG9jb2wuY2hhbm5lbC52MS5DaGFubmVsSWQSNQoK", "c3Vic2NyaWJlchgFIAEoCzIhLmJncy5wcm90b2NvbC5hY2NvdW50LnYxLklk", "ZW50aXR5Iu8BChlNZW1iZXJSZW1vdmVkTm90aWZpY2F0aW9uEigKCGFnZW50", "X2lkGAEgASgLMhYuYmdzLnByb3RvY29sLkVudGl0eUlkEikKCW1lbWJlcl9p", "ZBgCIAIoCzIWLmJncy5wcm90b2NvbC5FbnRpdHlJZBIOCgZyZWFzb24YAyAB", "KA0SNgoKY2hhbm5lbF9pZBgEIAEoCzIiLmJncy5wcm90b2NvbC5jaGFubmVs",
				"LnYxLkNoYW5uZWxJZBI1CgpzdWJzY3JpYmVyGAUgASgLMiEuYmdzLnByb3Rv", "Y29sLmFjY291bnQudjEuSWRlbnRpdHkimQIKF1NlbmRNZXNzYWdlTm90aWZp", "Y2F0aW9uEigKCGFnZW50X2lkGAEgASgLMhYuYmdzLnByb3RvY29sLkVudGl0", "eUlkEjEKB21lc3NhZ2UYAiACKAsyIC5iZ3MucHJvdG9jb2wuY2hhbm5lbC52", "MS5NZXNzYWdlEh4KE3JlcXVpcmVkX3ByaXZpbGVnZXMYAyABKAQ6ATASEgoK", "YmF0dGxlX3RhZxgEIAEoCRI2CgpjaGFubmVsX2lkGAUgASgLMiIuYmdzLnBy", "b3RvY29sLmNoYW5uZWwudjEuQ2hhbm5lbElkEjUKCnN1YnNjcmliZXIYBiAB", "KAsyIS5iZ3MucHJvdG9jb2wuYWNjb3VudC52MS5JZGVudGl0eSKxAgoeVXBk", "YXRlQ2hhbm5lbFN0YXRlTm90aWZpY2F0aW9uEigKCGFnZW50X2lkGAEgASgL", "MhYuYmdzLnByb3RvY29sLkVudGl0eUlkEjsKDHN0YXRlX2NoYW5nZRgCIAIo",
				"CzIlLmJncy5wcm90b2NvbC5jaGFubmVsLnYxLkNoYW5uZWxTdGF0ZRI2Cgpj", "aGFubmVsX2lkGAMgASgLMiIuYmdzLnByb3RvY29sLmNoYW5uZWwudjEuQ2hh", "bm5lbElkEjUKCnN1YnNjcmliZXIYBCABKAsyIS5iZ3MucHJvdG9jb2wuYWNj", "b3VudC52MS5JZGVudGl0eRI5Cg1zdWJzY3JpYmVyX2lkGAUgASgLMiIuYmdz", "LnByb3RvY29sLmFjY291bnQudjEuQWNjb3VudElkIu8BCh1VcGRhdGVNZW1i", "ZXJTdGF0ZU5vdGlmaWNhdGlvbhIoCghhZ2VudF9pZBgBIAEoCzIWLmJncy5w", "cm90b2NvbC5FbnRpdHlJZBI1CgxzdGF0ZV9jaGFuZ2UYAiADKAsyHy5iZ3Mu", "cHJvdG9jb2wuY2hhbm5lbC52MS5NZW1iZXISNgoKY2hhbm5lbF9pZBgEIAEo", "CzIiLmJncy5wcm90b2NvbC5jaGFubmVsLnYxLkNoYW5uZWxJZBI1CgpzdWJz", "Y3JpYmVyGAUgASgLMiEuYmdzLnByb3RvY29sLmFjY291bnQudjEuSWRlbnRp",
				"dHkykwQKDkNoYW5uZWxTZXJ2aWNlEloKDFJlbW92ZU1lbWJlchIsLmJncy5w", "cm90b2NvbC5jaGFubmVsLnYxLlJlbW92ZU1lbWJlclJlcXVlc3QaFC5iZ3Mu", "cHJvdG9jb2wuTm9EYXRhIgaC+SsCCAISWAoLU2VuZE1lc3NhZ2USKy5iZ3Mu", "cHJvdG9jb2wuY2hhbm5lbC52MS5TZW5kTWVzc2FnZVJlcXVlc3QaFC5iZ3Mu", "cHJvdG9jb2wuTm9EYXRhIgaC+SsCCAMSZgoSVXBkYXRlQ2hhbm5lbFN0YXRl", "EjIuYmdzLnByb3RvY29sLmNoYW5uZWwudjEuVXBkYXRlQ2hhbm5lbFN0YXRl", "UmVxdWVzdBoULmJncy5wcm90b2NvbC5Ob0RhdGEiBoL5KwIIBBJkChFVcGRh", "dGVNZW1iZXJTdGF0ZRIxLmJncy5wcm90b2NvbC5jaGFubmVsLnYxLlVwZGF0", "ZU1lbWJlclN0YXRlUmVxdWVzdBoULmJncy5wcm90b2NvbC5Ob0RhdGEiBoL5", "KwIIBRJSCghEaXNzb2x2ZRIoLmJncy5wcm90b2NvbC5jaGFubmVsLnYxLkRp",
				"c3NvbHZlUmVxdWVzdBoULmJncy5wcm90b2NvbC5Ob0RhdGEiBoL5KwIIBhop", "gvkrHwodYm5ldC5wcm90b2NvbC5jaGFubmVsLkNoYW5uZWyK+SsCEAEylAYK", "D0NoYW5uZWxMaXN0ZW5lchJWCgZPbkpvaW4SKS5iZ3MucHJvdG9jb2wuY2hh", "bm5lbC52MS5Kb2luTm90aWZpY2F0aW9uGhkuYmdzLnByb3RvY29sLk5PX1JF", "U1BPTlNFIgaC+SsCCAESZAoNT25NZW1iZXJBZGRlZBIwLmJncy5wcm90b2Nv", "bC5jaGFubmVsLnYxLk1lbWJlckFkZGVkTm90aWZpY2F0aW9uGhkuYmdzLnBy", "b3RvY29sLk5PX1JFU1BPTlNFIgaC+SsCCAISWAoHT25MZWF2ZRIqLmJncy5w", "cm90b2NvbC5jaGFubmVsLnYxLkxlYXZlTm90aWZpY2F0aW9uGhkuYmdzLnBy", "b3RvY29sLk5PX1JFU1BPTlNFIgaC+SsCCAMSaAoPT25NZW1iZXJSZW1vdmVk", "EjIuYmdzLnByb3RvY29sLmNoYW5uZWwudjEuTWVtYmVyUmVtb3ZlZE5vdGlm",
				"aWNhdGlvbhoZLmJncy5wcm90b2NvbC5OT19SRVNQT05TRSIGgvkrAggEEmQK", "DU9uU2VuZE1lc3NhZ2USMC5iZ3MucHJvdG9jb2wuY2hhbm5lbC52MS5TZW5k", "TWVzc2FnZU5vdGlmaWNhdGlvbhoZLmJncy5wcm90b2NvbC5OT19SRVNQT05T", "RSIGgvkrAggFEnIKFE9uVXBkYXRlQ2hhbm5lbFN0YXRlEjcuYmdzLnByb3Rv", "Y29sLmNoYW5uZWwudjEuVXBkYXRlQ2hhbm5lbFN0YXRlTm90aWZpY2F0aW9u", "GhkuYmdzLnByb3RvY29sLk5PX1JFU1BPTlNFIgaC+SsCCAYScAoTT25VcGRh", "dGVNZW1iZXJTdGF0ZRI2LmJncy5wcm90b2NvbC5jaGFubmVsLnYxLlVwZGF0", "ZU1lbWJlclN0YXRlTm90aWZpY2F0aW9uGhkuYmdzLnByb3RvY29sLk5PX1JF", "U1BPTlNFIgaC+SsCCAcaM4L5KykKJ2JuZXQucHJvdG9jb2wuY2hhbm5lbC5D", "aGFubmVsU3Vic2NyaWJlcor5KwIIAUIFSAGAAQA="
			}));
			ChannelServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				AccountTypesReflection.Descriptor,
				EntityTypesReflection.Descriptor,
				ChannelTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(RemoveMemberRequest), RemoveMemberRequest.Parser, new string[] { "AgentId", "MemberId", "Reason" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SendMessageRequest), SendMessageRequest.Parser, new string[] { "AgentId", "Message", "RequiredPrivileges" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UpdateChannelStateRequest), UpdateChannelStateRequest.Parser, new string[] { "AgentId", "StateChange" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UpdateMemberStateRequest), UpdateMemberStateRequest.Parser, new string[] { "AgentId", "StateChange", "RemovedRole" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(DissolveRequest), DissolveRequest.Parser, new string[] { "AgentId", "Reason" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(JoinNotification), JoinNotification.Parser, new string[] { "Self", "Member", "ChannelState", "ChannelId", "Subscriber", "SubscriberId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MemberAddedNotification), MemberAddedNotification.Parser, new string[] { "Member", "ChannelId", "Subscriber" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(LeaveNotification), LeaveNotification.Parser, new string[] { "AgentId", "MemberId", "Reason", "ChannelId", "Subscriber" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MemberRemovedNotification), MemberRemovedNotification.Parser, new string[] { "AgentId", "MemberId", "Reason", "ChannelId", "Subscriber" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SendMessageNotification), SendMessageNotification.Parser, new string[] { "AgentId", "Message", "RequiredPrivileges", "BattleTag", "ChannelId", "Subscriber" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UpdateChannelStateNotification), UpdateChannelStateNotification.Parser, new string[] { "AgentId", "StateChange", "ChannelId", "Subscriber", "SubscriberId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UpdateMemberStateNotification), UpdateMemberStateNotification.Parser, new string[] { "AgentId", "StateChange", "ChannelId", "Subscriber" }, null, null, null, null)
			}));
		}

		// Token: 0x040048C5 RID: 18629
		private static FileDescriptor descriptor;
	}
}
