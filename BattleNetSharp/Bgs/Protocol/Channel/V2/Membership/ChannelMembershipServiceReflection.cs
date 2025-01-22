using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2.Membership
{
	// Token: 0x020006A9 RID: 1705
	public static class ChannelMembershipServiceReflection
	{
		// Token: 0x1700311D RID: 12573
		// (get) Token: 0x06009E0F RID: 40463 RVA: 0x00266F78 File Offset: 0x00265178
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChannelMembershipServiceReflection.descriptor;
			}
		}

		// Token: 0x06009E10 RID: 40464 RVA: 0x00266F90 File Offset: 0x00265190
		static ChannelMembershipServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CkBiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL2NoYW5uZWxfbWVt", "YmVyc2hpcF9zZXJ2aWNlLnByb3RvEiJiZ3MucHJvdG9jb2wuY2hhbm5lbC52", "Mi5tZW1iZXJzaGlwGjNiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3Yy", "L2NoYW5uZWxfdHlwZXMucHJvdG8aIWJncy9sb3cvcGIvY2xpZW50L3JwY190", "eXBlcy5wcm90bxooYmdzL2xvdy9wYi9jbGllbnQvaW52aXRhdGlvbl90eXBl", "cy5wcm90byJQChBTdWJzY3JpYmVSZXF1ZXN0EjwKCGFnZW50X2lkGAEgASgL", "MiouYmdzLnByb3RvY29sLmFjY291bnQudjEuR2FtZUFjY291bnRIYW5kbGUi", "UwoRU3Vic2NyaWJlUmVzcG9uc2USPgoFc3RhdGUYASABKAsyLy5iZ3MucHJv", "dG9jb2wuY2hhbm5lbC52Mi5DaGFubmVsTWVtYmVyc2hpcFN0YXRlIlIKElVu", "c3Vic2NyaWJlUmVxdWVzdBI8CghhZ2VudF9pZBgBIAEoCzIqLmJncy5wcm90",
				"b2NvbC5hY2NvdW50LnYxLkdhbWVBY2NvdW50SGFuZGxlIk8KD0dldFN0YXRl", "UmVxdWVzdBI8CghhZ2VudF9pZBgBIAEoCzIqLmJncy5wcm90b2NvbC5hY2Nv", "dW50LnYxLkdhbWVBY2NvdW50SGFuZGxlIlIKEEdldFN0YXRlUmVzcG9uc2US", "PgoFc3RhdGUYASABKAsyLy5iZ3MucHJvdG9jb2wuY2hhbm5lbC52Mi5DaGFu", "bmVsTWVtYmVyc2hpcFN0YXRlItwBChhDaGFubmVsQWRkZWROb3RpZmljYXRp", "b24SPAoIYWdlbnRfaWQYASABKAsyKi5iZ3MucHJvdG9jb2wuYWNjb3VudC52", "MS5HYW1lQWNjb3VudEhhbmRsZRJBCg1zdWJzY3JpYmVyX2lkGAIgASgLMiou", "YmdzLnByb3RvY29sLmFjY291bnQudjEuR2FtZUFjY291bnRIYW5kbGUSPwoK", "bWVtYmVyc2hpcBgDIAEoCzIrLmJncy5wcm90b2NvbC5jaGFubmVsLnYyLkNo", "YW5uZWxEZXNjcmlwdGlvbiK4AgoaQ2hhbm5lbFJlbW92ZWROb3RpZmljYXRp",
				"b24SPAoIYWdlbnRfaWQYASABKAsyKi5iZ3MucHJvdG9jb2wuYWNjb3VudC52", "MS5HYW1lQWNjb3VudEhhbmRsZRJBCg1zdWJzY3JpYmVyX2lkGAIgASgLMiou", "YmdzLnByb3RvY29sLmFjY291bnQudjEuR2FtZUFjY291bnRIYW5kbGUSNgoK", "Y2hhbm5lbF9pZBgEIAEoCzIiLmJncy5wcm90b2NvbC5jaGFubmVsLnYyLkNo", "YW5uZWxJZBJhCgZyZWFzb24YBSABKA4yLS5iZ3MucHJvdG9jb2wuY2hhbm5l", "bC52Mi5DaGFubmVsUmVtb3ZlZFJlYXNvbjoiQ0hBTk5FTF9SRU1PVkVEX1JF", "QVNPTl9NRU1CRVJfTEVGVCLmAQojUmVjZWl2ZWRJbnZpdGF0aW9uQWRkZWRO", "b3RpZmljYXRpb24SPAoIYWdlbnRfaWQYASABKAsyKi5iZ3MucHJvdG9jb2wu", "YWNjb3VudC52MS5HYW1lQWNjb3VudEhhbmRsZRJBCg1zdWJzY3JpYmVyX2lk", "GAIgASgLMiouYmdzLnByb3RvY29sLmFjY291bnQudjEuR2FtZUFjY291bnRI",
				"YW5kbGUSPgoKaW52aXRhdGlvbhgDIAEoCzIqLmJncy5wcm90b2NvbC5jaGFu", "bmVsLnYyLkNoYW5uZWxJbnZpdGF0aW9uIpoCCiVSZWNlaXZlZEludml0YXRp", "b25SZW1vdmVkTm90aWZpY2F0aW9uEjwKCGFnZW50X2lkGAEgASgLMiouYmdz", "LnByb3RvY29sLmFjY291bnQudjEuR2FtZUFjY291bnRIYW5kbGUSQQoNc3Vi", "c2NyaWJlcl9pZBgCIAEoCzIqLmJncy5wcm90b2NvbC5hY2NvdW50LnYxLkdh", "bWVBY2NvdW50SGFuZGxlEhUKDWludml0YXRpb25faWQYAyABKAYSWQoGcmVh", "c29uGAQgASgOMiUuYmdzLnByb3RvY29sLkludml0YXRpb25SZW1vdmVkUmVh", "c29uOiJJTlZJVEFUSU9OX1JFTU9WRURfUkVBU09OX0FDQ0VQVEVEMsUDChhD", "aGFubmVsTWVtYmVyc2hpcFNlcnZpY2USgAEKCVN1YnNjcmliZRI0LmJncy5w", "cm90b2NvbC5jaGFubmVsLnYyLm1lbWJlcnNoaXAuU3Vic2NyaWJlUmVxdWVz",
				"dBo1LmJncy5wcm90b2NvbC5jaGFubmVsLnYyLm1lbWJlcnNoaXAuU3Vic2Ny", "aWJlUmVzcG9uc2UiBoL5KwIIARJjCgtVbnN1YnNjcmliZRI2LmJncy5wcm90", "b2NvbC5jaGFubmVsLnYyLm1lbWJlcnNoaXAuVW5zdWJzY3JpYmVSZXF1ZXN0", "GhQuYmdzLnByb3RvY29sLk5vRGF0YSIGgvkrAggCEn0KCEdldFN0YXRlEjMu", "YmdzLnByb3RvY29sLmNoYW5uZWwudjIubWVtYmVyc2hpcC5HZXRTdGF0ZVJl", "cXVlc3QaNC5iZ3MucHJvdG9jb2wuY2hhbm5lbC52Mi5tZW1iZXJzaGlwLkdl", "dFN0YXRlUmVzcG9uc2UiBoL5KwIIAxpCgvkrPgo8Ym5ldC5wcm90b2NvbC5j", "aGFubmVsLnYyLm1lbWJlcnNoaXAuQ2hhbm5lbE1lbWJlcnNoaXBTZXJ2aWNl", "MuIEChlDaGFubmVsTWVtYmVyc2hpcExpc3RlbmVyEnEKDk9uQ2hhbm5lbEFk", "ZGVkEjwuYmdzLnByb3RvY29sLmNoYW5uZWwudjIubWVtYmVyc2hpcC5DaGFu",
				"bmVsQWRkZWROb3RpZmljYXRpb24aGS5iZ3MucHJvdG9jb2wuTk9fUkVTUE9O", "U0UiBoL5KwIIARJ1ChBPbkNoYW5uZWxSZW1vdmVkEj4uYmdzLnByb3RvY29s", "LmNoYW5uZWwudjIubWVtYmVyc2hpcC5DaGFubmVsUmVtb3ZlZE5vdGlmaWNh", "dGlvbhoZLmJncy5wcm90b2NvbC5OT19SRVNQT05TRSIGgvkrAggCEocBChlP", "blJlY2VpdmVkSW52aXRhdGlvbkFkZGVkEkcuYmdzLnByb3RvY29sLmNoYW5u", "ZWwudjIubWVtYmVyc2hpcC5SZWNlaXZlZEludml0YXRpb25BZGRlZE5vdGlm", "aWNhdGlvbhoZLmJncy5wcm90b2NvbC5OT19SRVNQT05TRSIGgvkrAggDEosB", "ChtPblJlY2VpdmVkSW52aXRhdGlvblJlbW92ZWQSSS5iZ3MucHJvdG9jb2wu", "Y2hhbm5lbC52Mi5tZW1iZXJzaGlwLlJlY2VpdmVkSW52aXRhdGlvblJlbW92", "ZWROb3RpZmljYXRpb24aGS5iZ3MucHJvdG9jb2wuTk9fUkVTUE9OU0UiBoL5",
				"KwIIBBpDgvkrPwo9Ym5ldC5wcm90b2NvbC5jaGFubmVsLnYyLm1lbWJlcnNo", "aXAuQ2hhbm5lbE1lbWJlcnNoaXBMaXN0ZW5lckIDgAEA"
			}));
			ChannelMembershipServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				ChannelTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor,
				InvitationTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(SubscribeRequest), SubscribeRequest.Parser, new string[] { "AgentId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SubscribeResponse), SubscribeResponse.Parser, new string[] { "State" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UnsubscribeRequest), UnsubscribeRequest.Parser, new string[] { "AgentId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetStateRequest), GetStateRequest.Parser, new string[] { "AgentId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetStateResponse), GetStateResponse.Parser, new string[] { "State" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ChannelAddedNotification), ChannelAddedNotification.Parser, new string[] { "AgentId", "SubscriberId", "Membership" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ChannelRemovedNotification), ChannelRemovedNotification.Parser, new string[] { "AgentId", "SubscriberId", "ChannelId", "Reason" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ReceivedInvitationAddedNotification), ReceivedInvitationAddedNotification.Parser, new string[] { "AgentId", "SubscriberId", "Invitation" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ReceivedInvitationRemovedNotification), ReceivedInvitationRemovedNotification.Parser, new string[] { "AgentId", "SubscriberId", "InvitationId", "Reason" }, null, null, null, null)
			}));
		}

		// Token: 0x0400475B RID: 18267
		private static FileDescriptor descriptor;
	}
}
