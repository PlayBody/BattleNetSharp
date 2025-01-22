using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2.Server
{
	// Token: 0x020006A2 RID: 1698
	public static class ChannelListenerReflection
	{
		// Token: 0x170030FA RID: 12538
		// (get) Token: 0x06009D93 RID: 40339 RVA: 0x00264B18 File Offset: 0x00262D18
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChannelListenerReflection.descriptor;
			}
		}

		// Token: 0x06009D94 RID: 40340 RVA: 0x00264B30 File Offset: 0x00262D30
		static ChannelListenerReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjZiZ3MvbG93L3BiL2NsaWVudC9hcGkvc2VydmVyL3YyL2NoYW5uZWxfbGlz", "dGVuZXIucHJvdG8SHmJncy5wcm90b2NvbC5jaGFubmVsLnYyLnNlcnZlchoz", "YmdzL2xvdy9wYi9jbGllbnQvYXBpL2NsaWVudC92Mi9jaGFubmVsX3R5cGVz", "LnByb3RvGjpiZ3MvbG93L3BiL2NsaWVudC9hcGkvc2VydmVyL3YyL3NlcnZl", "cl9jaGFubmVsX3R5cGVzLnByb3RvGiFiZ3MvbG93L3BiL2NsaWVudC9ycGNf", "dHlwZXMucHJvdG8i3AEKH0NoYW5uZWxTdGF0ZUNoYW5nZWROb3RpZmljYXRp", "b24SPAoIYWdlbnRfaWQYASABKAsyKi5iZ3MucHJvdG9jb2wuYWNjb3VudC52", "MS5HYW1lQWNjb3VudEhhbmRsZRI2CgpjaGFubmVsX2lkGAMgASgLMiIuYmdz", "LnByb3RvY29sLmNoYW5uZWwudjIuQ2hhbm5lbElkEkMKCmFzc2lnbm1lbnQY", "BCABKAsyLy5iZ3MucHJvdG9jb2wuY2hhbm5lbC52Mi5DaGFubmVsU3RhdGVB",
				"c3NpZ25tZW50IsABChdNZW1iZXJBZGRlZE5vdGlmaWNhdGlvbhI8CghhZ2Vu", "dF9pZBgBIAEoCzIqLmJncy5wcm90b2NvbC5hY2NvdW50LnYxLkdhbWVBY2Nv", "dW50SGFuZGxlEjYKCmNoYW5uZWxfaWQYAyABKAsyIi5iZ3MucHJvdG9jb2wu", "Y2hhbm5lbC52Mi5DaGFubmVsSWQSLwoGbWVtYmVyGAQgAygLMh8uYmdzLnBy", "b3RvY29sLmNoYW5uZWwudjIuTWVtYmVyIvsBChlNZW1iZXJSZW1vdmVkTm90", "aWZpY2F0aW9uEjwKCGFnZW50X2lkGAEgASgLMiouYmdzLnByb3RvY29sLmFj", "Y291bnQudjEuR2FtZUFjY291bnRIYW5kbGUSNgoKY2hhbm5lbF9pZBgDIAEo", "CzIiLmJncy5wcm90b2NvbC5jaGFubmVsLnYyLkNoYW5uZWxJZBIOCgZyZWFz", "b24YBCABKA0SPQoJbWVtYmVyX2lkGAUgAygLMiouYmdzLnByb3RvY29sLmFj", "Y291bnQudjEuR2FtZUFjY291bnRIYW5kbGUSGQoRbWVtYmVyX2FjY291bnRf",
				"aWQYBiADKAQi2gEKHk1lbWJlclN0YXRlQ2hhbmdlZE5vdGlmaWNhdGlvbhI8", "CghhZ2VudF9pZBgBIAEoCzIqLmJncy5wcm90b2NvbC5hY2NvdW50LnYxLkdh", "bWVBY2NvdW50SGFuZGxlEjYKCmNoYW5uZWxfaWQYAyABKAsyIi5iZ3MucHJv", "dG9jb2wuY2hhbm5lbC52Mi5DaGFubmVsSWQSQgoKYXNzaWdubWVudBgFIAMo", "CzIuLmJncy5wcm90b2NvbC5jaGFubmVsLnYyLk1lbWJlclN0YXRlQXNzaWdu", "bWVudCLSAQodTWVtYmVyUm9sZUNoYW5nZWROb3RpZmljYXRpb24SPAoIYWdl", "bnRfaWQYASABKAsyKi5iZ3MucHJvdG9jb2wuYWNjb3VudC52MS5HYW1lQWNj", "b3VudEhhbmRsZRI2CgpjaGFubmVsX2lkGAMgASgLMiIuYmdzLnByb3RvY29s", "LmNoYW5uZWwudjIuQ2hhbm5lbElkEjsKCmFzc2lnbm1lbnQYBSADKAsyJy5i", "Z3MucHJvdG9jb2wuY2hhbm5lbC52Mi5Sb2xlQXNzaWdubWVudDK+BAoVQ2hh",
				"bm5lbFNlcnZlckxpc3RlbmVyEnMKFU9uQ2hhbm5lbFN0YXRlQ2hhbmdlZBI/", "LmJncy5wcm90b2NvbC5jaGFubmVsLnYyLnNlcnZlci5DaGFubmVsU3RhdGVD", "aGFuZ2VkTm90aWZpY2F0aW9uGhkuYmdzLnByb3RvY29sLk5PX1JFU1BPTlNF", "EmMKDU9uTWVtYmVyQWRkZWQSNy5iZ3MucHJvdG9jb2wuY2hhbm5lbC52Mi5z", "ZXJ2ZXIuTWVtYmVyQWRkZWROb3RpZmljYXRpb24aGS5iZ3MucHJvdG9jb2wu", "Tk9fUkVTUE9OU0USZwoPT25NZW1iZXJSZW1vdmVkEjkuYmdzLnByb3RvY29s", "LmNoYW5uZWwudjIuc2VydmVyLk1lbWJlclJlbW92ZWROb3RpZmljYXRpb24a", "GS5iZ3MucHJvdG9jb2wuTk9fUkVTUE9OU0UScQoUT25NZW1iZXJTdGF0ZUNo", "YW5nZWQSPi5iZ3MucHJvdG9jb2wuY2hhbm5lbC52Mi5zZXJ2ZXIuTWVtYmVy", "U3RhdGVDaGFuZ2VkTm90aWZpY2F0aW9uGhkuYmdzLnByb3RvY29sLk5PX1JF",
				"U1BPTlNFEm8KE09uTWVtYmVyUm9sZUNoYW5nZWQSPS5iZ3MucHJvdG9jb2wu", "Y2hhbm5lbC52Mi5zZXJ2ZXIuTWVtYmVyUm9sZUNoYW5nZWROb3RpZmljYXRp", "b24aGS5iZ3MucHJvdG9jb2wuTk9fUkVTUE9OU0VCA4ABAA=="
			}));
			ChannelListenerReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				ChannelTypesReflection.Descriptor,
				ServerChannelTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ChannelStateChangedNotification), ChannelStateChangedNotification.Parser, new string[] { "AgentId", "ChannelId", "Assignment" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MemberAddedNotification), MemberAddedNotification.Parser, new string[] { "AgentId", "ChannelId", "Member" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MemberRemovedNotification), MemberRemovedNotification.Parser, new string[] { "AgentId", "ChannelId", "Reason", "MemberId", "MemberAccountId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MemberStateChangedNotification), MemberStateChangedNotification.Parser, new string[] { "AgentId", "ChannelId", "Assignment" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MemberRoleChangedNotification), MemberRoleChangedNotification.Parser, new string[] { "AgentId", "ChannelId", "Assignment" }, null, null, null, null)
			}));
		}

		// Token: 0x0400471B RID: 18203
		private static FileDescriptor descriptor;
	}
}
