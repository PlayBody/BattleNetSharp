using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1.Membership
{
	// Token: 0x0200050E RID: 1294
	public static class ClubMembershipListenerReflection
	{
		// Token: 0x17002812 RID: 10258
		// (get) Token: 0x06007E35 RID: 32309 RVA: 0x001EB5D4 File Offset: 0x001E97D4
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClubMembershipListenerReflection.descriptor;
			}
		}

		// Token: 0x06007E36 RID: 32310 RVA: 0x001EB5EC File Offset: 0x001E97EC
		static ClubMembershipListenerReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjBiZ3MvbG93L3BiL2NsaWVudC9jbHViX21lbWJlcnNoaXBfbGlzdGVuZXIu", "cHJvdG8SH2Jncy5wcm90b2NvbC5jbHViLnYxLm1lbWJlcnNoaXAaImJncy9s", "b3cvcGIvY2xpZW50L2NsdWJfdHlwZXMucHJvdG8ijgEKFUNsdWJBZGRlZE5v", "dGlmaWNhdGlvbhIwCghhZ2VudF9pZBgBIAEoCzIeLmJncy5wcm90b2NvbC5j", "bHViLnYxLk1lbWJlcklkEkMKCm1lbWJlcnNoaXAYAyABKAsyLy5iZ3MucHJv", "dG9jb2wuY2x1Yi52MS5DbHViTWVtYmVyc2hpcERlc2NyaXB0aW9uIuIBChdD", "bHViUmVtb3ZlZE5vdGlmaWNhdGlvbhIwCghhZ2VudF9pZBgBIAEoCzIeLmJn", "cy5wcm90b2NvbC5jbHViLnYxLk1lbWJlcklkEjEKCW1lbWJlcl9pZBgDIAEo", "CzIeLmJncy5wcm90b2NvbC5jbHViLnYxLk1lbWJlcklkEg8KB2NsdWJfaWQY", "BCABKAQSUQoGcmVhc29uGAUgASgOMicuYmdzLnByb3RvY29sLmNsdWIudjEu",
				"Q2x1YlJlbW92ZWRSZWFzb246GENMVUJfUkVNT1ZFRF9SRUFTT05fTk9ORSKR", "AQojUmVjZWl2ZWRJbnZpdGF0aW9uQWRkZWROb3RpZmljYXRpb24SMAoIYWdl", "bnRfaWQYASABKAsyHi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5NZW1iZXJJZBI4", "CgppbnZpdGF0aW9uGAMgASgLMiQuYmdzLnByb3RvY29sLmNsdWIudjEuQ2x1", "Ykludml0YXRpb24iywEKJVJlY2VpdmVkSW52aXRhdGlvblJlbW92ZWROb3Rp", "ZmljYXRpb24SMAoIYWdlbnRfaWQYASABKAsyHi5iZ3MucHJvdG9jb2wuY2x1", "Yi52MS5NZW1iZXJJZBIVCg1pbnZpdGF0aW9uX2lkGAMgASgGElkKBnJlYXNv", "bhgEIAEoDjIlLmJncy5wcm90b2NvbC5JbnZpdGF0aW9uUmVtb3ZlZFJlYXNv", "bjoiSU5WSVRBVElPTl9SRU1PVkVEX1JFQVNPTl9BQ0NFUFRFRCKhAQohU2hh", "cmVkU2V0dGluZ3NDaGFuZ2VkTm90aWZpY2F0aW9uEjQKCGFnZW50X2lkGAEg",
				"ASgLMiIuYmdzLnByb3RvY29sLmFjY291bnQudjEuQWNjb3VudElkEkYKCmFz", "c2lnbm1lbnQYBCABKAsyMi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5DbHViU2hh", "cmVkU2V0dGluZ3NBc3NpZ25tZW50IogBCh5TdHJlYW1NZW50aW9uQWRkZWRO", "b3RpZmljYXRpb24SMAoIYWdlbnRfaWQYASABKAsyHi5iZ3MucHJvdG9jb2wu", "Y2x1Yi52MS5NZW1iZXJJZBI0CgdtZW50aW9uGAMgASgLMiMuYmdzLnByb3Rv", "Y29sLmNsdWIudjEuU3RyZWFtTWVudGlvbiKIAQogU3RyZWFtTWVudGlvblJl", "bW92ZWROb3RpZmljYXRpb24SNAoIYWdlbnRfaWQYASABKAsyIi5iZ3MucHJv", "dG9jb2wuYWNjb3VudC52MS5BY2NvdW50SWQSLgoKbWVudGlvbl9pZBgDIAEo", "CzIaLmJncy5wcm90b2NvbC5UaW1lU2VyaWVzSWQicwooU3RyZWFtTWVudGlv", "bkFkdmFuY2VWaWV3VGltZU5vdGlmaWNhdGlvbhI0CghhZ2VudF9pZBgBIAEo",
				"CzIiLmJncy5wcm90b2NvbC5hY2NvdW50LnYxLkFjY291bnRJZBIRCgl2aWV3", "X3RpbWUYAyABKAQyzAgKFkNsdWJNZW1iZXJzaGlwTGlzdGVuZXISaAoLT25D", "bHViQWRkZWQSNi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5tZW1iZXJzaGlwLkNs", "dWJBZGRlZE5vdGlmaWNhdGlvbhoZLmJncy5wcm90b2NvbC5OT19SRVNQT05T", "RSIGgvkrAggBEmwKDU9uQ2x1YlJlbW92ZWQSOC5iZ3MucHJvdG9jb2wuY2x1", "Yi52MS5tZW1iZXJzaGlwLkNsdWJSZW1vdmVkTm90aWZpY2F0aW9uGhkuYmdz", "LnByb3RvY29sLk5PX1JFU1BPTlNFIgaC+SsCCAIShAEKGU9uUmVjZWl2ZWRJ", "bnZpdGF0aW9uQWRkZWQSRC5iZ3MucHJvdG9jb2wuY2x1Yi52MS5tZW1iZXJz", "aGlwLlJlY2VpdmVkSW52aXRhdGlvbkFkZGVkTm90aWZpY2F0aW9uGhkuYmdz", "LnByb3RvY29sLk5PX1JFU1BPTlNFIgaC+SsCCAMSiAEKG09uUmVjZWl2ZWRJ",
				"bnZpdGF0aW9uUmVtb3ZlZBJGLmJncy5wcm90b2NvbC5jbHViLnYxLm1lbWJl", "cnNoaXAuUmVjZWl2ZWRJbnZpdGF0aW9uUmVtb3ZlZE5vdGlmaWNhdGlvbhoZ", "LmJncy5wcm90b2NvbC5OT19SRVNQT05TRSIGgvkrAggEEoABChdPblNoYXJl", "ZFNldHRpbmdzQ2hhbmdlZBJCLmJncy5wcm90b2NvbC5jbHViLnYxLm1lbWJl", "cnNoaXAuU2hhcmVkU2V0dGluZ3NDaGFuZ2VkTm90aWZpY2F0aW9uGhkuYmdz", "LnByb3RvY29sLk5PX1JFU1BPTlNFIgaC+SsCCAUSegoUT25TdHJlYW1NZW50", "aW9uQWRkZWQSPy5iZ3MucHJvdG9jb2wuY2x1Yi52MS5tZW1iZXJzaGlwLlN0", "cmVhbU1lbnRpb25BZGRlZE5vdGlmaWNhdGlvbhoZLmJncy5wcm90b2NvbC5O", "T19SRVNQT05TRSIGgvkrAggGEn4KFk9uU3RyZWFtTWVudGlvblJlbW92ZWQS", "QS5iZ3MucHJvdG9jb2wuY2x1Yi52MS5tZW1iZXJzaGlwLlN0cmVhbU1lbnRp",
				"b25SZW1vdmVkTm90aWZpY2F0aW9uGhkuYmdzLnByb3RvY29sLk5PX1JFU1BP", "TlNFIgaC+SsCCAcSjgEKHk9uU3RyZWFtTWVudGlvbkFkdmFuY2VWaWV3VGlt", "ZRJJLmJncy5wcm90b2NvbC5jbHViLnYxLm1lbWJlcnNoaXAuU3RyZWFtTWVu", "dGlvbkFkdmFuY2VWaWV3VGltZU5vdGlmaWNhdGlvbhoZLmJncy5wcm90b2Nv", "bC5OT19SRVNQT05TRSIGgvkrAggIGjiC+SsuCixibmV0LnByb3RvY29sLmNs", "dWIudjEuQ2x1Yk1lbWJlcnNoaXBMaXN0ZW5lcor5KwIIAUIDgAEA"
			}));
			ClubMembershipListenerReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { ClubTypesReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ClubAddedNotification), ClubAddedNotification.Parser, new string[] { "AgentId", "Membership" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClubRemovedNotification), ClubRemovedNotification.Parser, new string[] { "AgentId", "MemberId", "ClubId", "Reason" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ReceivedInvitationAddedNotification), ReceivedInvitationAddedNotification.Parser, new string[] { "AgentId", "Invitation" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ReceivedInvitationRemovedNotification), ReceivedInvitationRemovedNotification.Parser, new string[] { "AgentId", "InvitationId", "Reason" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SharedSettingsChangedNotification), SharedSettingsChangedNotification.Parser, new string[] { "AgentId", "Assignment" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(StreamMentionAddedNotification), StreamMentionAddedNotification.Parser, new string[] { "AgentId", "Mention" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(StreamMentionRemovedNotification), StreamMentionRemovedNotification.Parser, new string[] { "AgentId", "MentionId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(StreamMentionAdvanceViewTimeNotification), StreamMentionAdvanceViewTimeNotification.Parser, new string[] { "AgentId", "ViewTime" }, null, null, null, null)
			}));
		}

		// Token: 0x0400396A RID: 14698
		private static FileDescriptor descriptor;
	}
}
