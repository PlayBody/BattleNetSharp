using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200047C RID: 1148
	public static class ClubNotificationReflection
	{
		// Token: 0x170023CD RID: 9165
		// (get) Token: 0x06006FF5 RID: 28661 RVA: 0x001B3420 File Offset: 0x001B1620
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClubNotificationReflection.descriptor;
			}
		}

		// Token: 0x06006FF6 RID: 28662 RVA: 0x001B3438 File Offset: 0x001B1638
		static ClubNotificationReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CiliZ3MvbG93L3BiL2NsaWVudC9jbHViX25vdGlmaWNhdGlvbi5wcm90bxIU", "YmdzLnByb3RvY29sLmNsdWIudjEaImJncy9sb3cvcGIvY2xpZW50L2NsdWJf", "dHlwZXMucHJvdG8aIWJncy9sb3cvcGIvY2xpZW50L3JwY190eXBlcy5wcm90", "byKWAgoVU3Vic2NyaWJlTm90aWZpY2F0aW9uEjAKCGFnZW50X2lkGAEgASgL", "Mh4uYmdzLnByb3RvY29sLmNsdWIudjEuTWVtYmVySWQSDwoHY2x1Yl9pZBgD", "IAEoBBIoCgRjbHViGAQgASgLMhouYmdzLnByb3RvY29sLmNsdWIudjEuQ2x1", "YhIsCgR2aWV3GAUgASgLMh4uYmdzLnByb3RvY29sLmNsdWIudjEuQ2x1YlZp", "ZXcSNAoIc2V0dGluZ3MYCiABKAsyIi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5D", "bHViU2V0dGluZ3MSLAoGbWVtYmVyGAsgASgLMhwuYmdzLnByb3RvY29sLmNs", "dWIudjEuTWVtYmVyIlwKF1Vuc3Vic2NyaWJlTm90aWZpY2F0aW9uEjAKCGFn",
				"ZW50X2lkGAEgASgLMh4uYmdzLnByb3RvY29sLmNsdWIudjEuTWVtYmVySWQS", "DwoHY2x1Yl9pZBgDIAEoBCKcAQoYU3RhdGVDaGFuZ2VkTm90aWZpY2F0aW9u", "EjAKCGFnZW50X2lkGAEgASgLMh4uYmdzLnByb3RvY29sLmNsdWIudjEuTWVt", "YmVySWQSDwoHY2x1Yl9pZBgDIAEoBBI9Cgphc3NpZ25tZW50GAUgASgLMiku", "YmdzLnByb3RvY29sLmNsdWIudjEuQ2x1YlN0YXRlQXNzaWdubWVudCKiAQob", "U2V0dGluZ3NDaGFuZ2VkTm90aWZpY2F0aW9uEjAKCGFnZW50X2lkGAEgASgL", "Mh4uYmdzLnByb3RvY29sLmNsdWIudjEuTWVtYmVySWQSDwoHY2x1Yl9pZBgD", "IAEoBBJACgphc3NpZ25tZW50GAQgASgLMiwuYmdzLnByb3RvY29sLmNsdWIu", "djEuQ2x1YlNldHRpbmdzQXNzaWdubWVudCKKAQoXTWVtYmVyQWRkZWROb3Rp", "ZmljYXRpb24SMAoIYWdlbnRfaWQYASABKAsyHi5iZ3MucHJvdG9jb2wuY2x1",
				"Yi52MS5NZW1iZXJJZBIPCgdjbHViX2lkGAMgASgEEiwKBm1lbWJlchgEIAMo", "CzIcLmJncy5wcm90b2NvbC5jbHViLnYxLk1lbWJlciKdAQoZTWVtYmVyUmVt", "b3ZlZE5vdGlmaWNhdGlvbhIwCghhZ2VudF9pZBgBIAEoCzIeLmJncy5wcm90", "b2NvbC5jbHViLnYxLk1lbWJlcklkEg8KB2NsdWJfaWQYAyABKAQSPQoGbWVt", "YmVyGAQgAygLMi0uYmdzLnByb3RvY29sLmNsdWIudjEuTWVtYmVyUmVtb3Zl", "ZEFzc2lnbm1lbnQipAEKHk1lbWJlclN0YXRlQ2hhbmdlZE5vdGlmaWNhdGlv", "bhIwCghhZ2VudF9pZBgBIAEoCzIeLmJncy5wcm90b2NvbC5jbHViLnYxLk1l", "bWJlcklkEg8KB2NsdWJfaWQYAyABKAQSPwoKYXNzaWdubWVudBgEIAMoCzIr", "LmJncy5wcm90b2NvbC5jbHViLnYxLk1lbWJlclN0YXRlQXNzaWdubWVudCKs", "AQoiU3Vic2NyaWJlclN0YXRlQ2hhbmdlZE5vdGlmaWNhdGlvbhIwCghhZ2Vu",
				"dF9pZBgBIAEoCzIeLmJncy5wcm90b2NvbC5jbHViLnYxLk1lbWJlcklkEg8K", "B2NsdWJfaWQYAyABKAQSQwoKYXNzaWdubWVudBgEIAMoCzIvLmJncy5wcm90", "b2NvbC5jbHViLnYxLlN1YnNjcmliZXJTdGF0ZUFzc2lnbm1lbnQinAEKHU1l", "bWJlclJvbGVDaGFuZ2VkTm90aWZpY2F0aW9uEjAKCGFnZW50X2lkGAEgASgL", "Mh4uYmdzLnByb3RvY29sLmNsdWIudjEuTWVtYmVySWQSDwoHY2x1Yl9pZBgD", "IAEoBBI4Cgphc3NpZ25tZW50GAQgAygLMiQuYmdzLnByb3RvY29sLmNsdWIu", "djEuUm9sZUFzc2lnbm1lbnQimgEKG0ludml0YXRpb25BZGRlZE5vdGlmaWNh", "dGlvbhIwCghhZ2VudF9pZBgBIAEoCzIeLmJncy5wcm90b2NvbC5jbHViLnYx", "Lk1lbWJlcklkEg8KB2NsdWJfaWQYAyABKAQSOAoKaW52aXRhdGlvbhgEIAEo", "CzIkLmJncy5wcm90b2NvbC5jbHViLnYxLkNsdWJJbnZpdGF0aW9uIrABCh1J",
				"bnZpdGF0aW9uUmVtb3ZlZE5vdGlmaWNhdGlvbhIwCghhZ2VudF9pZBgBIAEo", "CzIeLmJncy5wcm90b2NvbC5jbHViLnYxLk1lbWJlcklkEg8KB2NsdWJfaWQY", "AyABKAQSFQoNaW52aXRhdGlvbl9pZBgEIAEoBhI1CgZyZWFzb24YBSABKA4y", "JS5iZ3MucHJvdG9jb2wuSW52aXRhdGlvblJlbW92ZWRSZWFzb24imgEKG1N1", "Z2dlc3Rpb25BZGRlZE5vdGlmaWNhdGlvbhIwCghhZ2VudF9pZBgBIAEoCzIe", "LmJncy5wcm90b2NvbC5jbHViLnYxLk1lbWJlcklkEg8KB2NsdWJfaWQYAyAB", "KAQSOAoKc3VnZ2VzdGlvbhgEIAEoCzIkLmJncy5wcm90b2NvbC5jbHViLnYx", "LkNsdWJTdWdnZXN0aW9uIrABCh1TdWdnZXN0aW9uUmVtb3ZlZE5vdGlmaWNh", "dGlvbhIwCghhZ2VudF9pZBgBIAEoCzIeLmJncy5wcm90b2NvbC5jbHViLnYx", "Lk1lbWJlcklkEg8KB2NsdWJfaWQYAyABKAQSFQoNc3VnZ2VzdGlvbl9pZBgE",
				"IAEoBhI1CgZyZWFzb24YBSABKA4yJS5iZ3MucHJvdG9jb2wuU3VnZ2VzdGlv", "blJlbW92ZWRSZWFzb24iigEKF1N0cmVhbUFkZGVkTm90aWZpY2F0aW9uEjAK", "CGFnZW50X2lkGAEgASgLMh4uYmdzLnByb3RvY29sLmNsdWIudjEuTWVtYmVy", "SWQSDwoHY2x1Yl9pZBgDIAEoBBIsCgZzdHJlYW0YBCABKAsyHC5iZ3MucHJv", "dG9jb2wuY2x1Yi52MS5TdHJlYW0icQoZU3RyZWFtUmVtb3ZlZE5vdGlmaWNh", "dGlvbhIwCghhZ2VudF9pZBgBIAEoCzIeLmJncy5wcm90b2NvbC5jbHViLnYx", "Lk1lbWJlcklkEg8KB2NsdWJfaWQYAyABKAQSEQoJc3RyZWFtX2lkGAQgASgE", "IrcBCh5TdHJlYW1TdGF0ZUNoYW5nZWROb3RpZmljYXRpb24SMAoIYWdlbnRf", "aWQYASABKAsyHi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5NZW1iZXJJZBIPCgdj", "bHViX2lkGAMgASgEEhEKCXN0cmVhbV9pZBgEIAEoBBI/Cgphc3NpZ25tZW50",
				"GAUgASgLMisuYmdzLnByb3RvY29sLmNsdWIudjEuU3RyZWFtU3RhdGVBc3Np", "Z25tZW50IqwBCh5TdHJlYW1NZXNzYWdlQWRkZWROb3RpZmljYXRpb24SMAoI", "YWdlbnRfaWQYASABKAsyHi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5NZW1iZXJJ", "ZBIPCgdjbHViX2lkGAMgASgEEhEKCXN0cmVhbV9pZBgEIAEoBBI0CgdtZXNz", "YWdlGAUgASgLMiMuYmdzLnByb3RvY29sLmNsdWIudjEuU3RyZWFtTWVzc2Fn", "ZSKuAQogU3RyZWFtTWVzc2FnZVVwZGF0ZWROb3RpZmljYXRpb24SMAoIYWdl", "bnRfaWQYASABKAsyHi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5NZW1iZXJJZBIP", "CgdjbHViX2lkGAMgASgEEhEKCXN0cmVhbV9pZBgEIAEoBBI0CgdtZXNzYWdl", "GAUgASgLMiMuYmdzLnByb3RvY29sLmNsdWIudjEuU3RyZWFtTWVzc2FnZSK5", "AQohU3RyZWFtVHlwaW5nSW5kaWNhdG9yTm90aWZpY2F0aW9uEjAKCGFnZW50",
				"X2lkGAEgASgLMh4uYmdzLnByb3RvY29sLmNsdWIudjEuTWVtYmVySWQSDwoH", "Y2x1Yl9pZBgDIAEoBBIRCglzdHJlYW1faWQYBCABKAQSPgoJaW5kaWNhdG9y", "GAUgAygLMisuYmdzLnByb3RvY29sLmNsdWIudjEuU3RyZWFtVHlwaW5nSW5k", "aWNhdG9yItIBCiFTdHJlYW1VbnJlYWRJbmRpY2F0b3JOb3RpZmljYXRpb24S", "MAoIYWdlbnRfaWQYASABKAsyHi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5NZW1i", "ZXJJZBIPCgdjbHViX2lkGAMgASgEEjQKBWV2ZW50GAQgASgLMiUuYmdzLnBy", "b3RvY29sLmNsdWIudjEuU3RyZWFtRXZlbnRUaW1lEjQKB21lc3NhZ2UYBSAB", "KAsyIy5iZ3MucHJvdG9jb2wuY2x1Yi52MS5TdHJlYW1NZXNzYWdlIqEBCiFT", "dHJlYW1BZHZhbmNlVmlld1RpbWVOb3RpZmljYXRpb24SMAoIYWdlbnRfaWQY", "ASABKAsyHi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5NZW1iZXJJZBIPCgdjbHVi",
				"X2lkGAMgASgEEjkKBHZpZXcYBCADKAsyKy5iZ3MucHJvdG9jb2wuY2x1Yi52", "MS5TdHJlYW1BZHZhbmNlVmlld1RpbWVQAFAB"
			}));
			ClubNotificationReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				ClubTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(SubscribeNotification), SubscribeNotification.Parser, new string[] { "AgentId", "ClubId", "Club", "View", "Settings", "Member" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UnsubscribeNotification), UnsubscribeNotification.Parser, new string[] { "AgentId", "ClubId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(StateChangedNotification), StateChangedNotification.Parser, new string[] { "AgentId", "ClubId", "Assignment" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SettingsChangedNotification), SettingsChangedNotification.Parser, new string[] { "AgentId", "ClubId", "Assignment" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MemberAddedNotification), MemberAddedNotification.Parser, new string[] { "AgentId", "ClubId", "Member" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MemberRemovedNotification), MemberRemovedNotification.Parser, new string[] { "AgentId", "ClubId", "Member" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MemberStateChangedNotification), MemberStateChangedNotification.Parser, new string[] { "AgentId", "ClubId", "Assignment" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SubscriberStateChangedNotification), SubscriberStateChangedNotification.Parser, new string[] { "AgentId", "ClubId", "Assignment" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MemberRoleChangedNotification), MemberRoleChangedNotification.Parser, new string[] { "AgentId", "ClubId", "Assignment" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(InvitationAddedNotification), InvitationAddedNotification.Parser, new string[] { "AgentId", "ClubId", "Invitation" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(InvitationRemovedNotification), InvitationRemovedNotification.Parser, new string[] { "AgentId", "ClubId", "InvitationId", "Reason" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SuggestionAddedNotification), SuggestionAddedNotification.Parser, new string[] { "AgentId", "ClubId", "Suggestion" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SuggestionRemovedNotification), SuggestionRemovedNotification.Parser, new string[] { "AgentId", "ClubId", "SuggestionId", "Reason" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(StreamAddedNotification), StreamAddedNotification.Parser, new string[] { "AgentId", "ClubId", "Stream" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(StreamRemovedNotification), StreamRemovedNotification.Parser, new string[] { "AgentId", "ClubId", "StreamId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(StreamStateChangedNotification), StreamStateChangedNotification.Parser, new string[] { "AgentId", "ClubId", "StreamId", "Assignment" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(StreamMessageAddedNotification), StreamMessageAddedNotification.Parser, new string[] { "AgentId", "ClubId", "StreamId", "Message" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(StreamMessageUpdatedNotification), StreamMessageUpdatedNotification.Parser, new string[] { "AgentId", "ClubId", "StreamId", "Message" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(StreamTypingIndicatorNotification), StreamTypingIndicatorNotification.Parser, new string[] { "AgentId", "ClubId", "StreamId", "Indicator" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(StreamUnreadIndicatorNotification), StreamUnreadIndicatorNotification.Parser, new string[] { "AgentId", "ClubId", "Event", "Message" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(StreamAdvanceViewTimeNotification), StreamAdvanceViewTimeNotification.Parser, new string[] { "AgentId", "ClubId", "View" }, null, null, null, null)
			}));
		}

		// Token: 0x04003359 RID: 13145
		private static FileDescriptor descriptor;
	}
}
