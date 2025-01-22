using System;
using Bgs.Protocol.Account.V1;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Whisper.V1
{
	// Token: 0x0200039A RID: 922
	public static class WhisperListenerReflection
	{
		// Token: 0x17001E54 RID: 7764
		// (get) Token: 0x06005D73 RID: 23923 RVA: 0x00169AC0 File Offset: 0x00167CC0
		public static FileDescriptor Descriptor
		{
			get
			{
				return WhisperListenerReflection.descriptor;
			}
		}

		// Token: 0x06005D74 RID: 23924 RVA: 0x00169AD8 File Offset: 0x00167CD8
		static WhisperListenerReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CihiZ3MvbG93L3BiL2NsaWVudC93aGlzcGVyX2xpc3RlbmVyLnByb3RvEhdi", "Z3MucHJvdG9jb2wud2hpc3Blci52MRolYmdzL2xvdy9wYi9jbGllbnQvd2hp", "c3Blcl90eXBlcy5wcm90bxolYmdzL2xvdy9wYi9jbGllbnQvYWNjb3VudF90", "eXBlcy5wcm90bxohYmdzL2xvdy9wYi9jbGllbnQvcnBjX3R5cGVzLnByb3Rv", "GiViZ3MvbG93L3BiL2NsaWVudC9tZXNzYWdlX3R5cGVzLnByb3RvIqYBChNX", "aGlzcGVyTm90aWZpY2F0aW9uEjkKDXN1YnNjcmliZXJfaWQYASABKAsyIi5i", "Z3MucHJvdG9jb2wuYWNjb3VudC52MS5BY2NvdW50SWQSMQoHd2hpc3BlchgC", "IAEoCzIgLmJncy5wcm90b2NvbC53aGlzcGVyLnYxLldoaXNwZXISIQoRc2Vu", "ZGVyX2JhdHRsZV90YWcYAyABKAlCBoL5KwIIASKHAQoXV2hpc3BlckVjaG9O", "b3RpZmljYXRpb24SOQoNc3Vic2NyaWJlcl9pZBgBIAEoCzIiLmJncy5wcm90",
				"b2NvbC5hY2NvdW50LnYxLkFjY291bnRJZBIxCgd3aGlzcGVyGAIgASgLMiAu", "YmdzLnByb3RvY29sLndoaXNwZXIudjEuV2hpc3BlciLMAQobVHlwaW5nSW5k", "aWNhdG9yTm90aWZpY2F0aW9uEjkKDXN1YnNjcmliZXJfaWQYASABKAsyIi5i", "Z3MucHJvdG9jb2wuYWNjb3VudC52MS5BY2NvdW50SWQSNQoJc2VuZGVyX2lk", "GAIgASgLMiIuYmdzLnByb3RvY29sLmFjY291bnQudjEuQWNjb3VudElkEjsK", "BmFjdGlvbhgDIAEoDjIdLmJncy5wcm90b2NvbC5UeXBpbmdJbmRpY2F0b3I6", "DFRZUElOR19TVEFSVCKiAQobQWR2YW5jZVZpZXdUaW1lTm90aWZpY2F0aW9u", "EjkKDXN1YnNjcmliZXJfaWQYASABKAsyIi5iZ3MucHJvdG9jb2wuYWNjb3Vu", "dC52MS5BY2NvdW50SWQSNQoJc2VuZGVyX2lkGAIgASgLMiIuYmdzLnByb3Rv", "Y29sLmFjY291bnQudjEuQWNjb3VudElkEhEKCXZpZXdfdGltZRgDIAEoBCKK",
				"AQoaV2hpc3BlclVwZGF0ZWROb3RpZmljYXRpb24SOQoNc3Vic2NyaWJlcl9p", "ZBgBIAEoCzIiLmJncy5wcm90b2NvbC5hY2NvdW50LnYxLkFjY291bnRJZBIx", "Cgd3aGlzcGVyGAIgASgLMiAuYmdzLnByb3RvY29sLndoaXNwZXIudjEuV2hp", "c3BlciKkAQocQWR2YW5jZUNsZWFyVGltZU5vdGlmaWNhdGlvbhI5Cg1zdWJz", "Y3JpYmVyX2lkGAEgASgLMiIuYmdzLnByb3RvY29sLmFjY291bnQudjEuQWNj", "b3VudElkEjUKCXNlbmRlcl9pZBgCIAEoCzIiLmJncy5wcm90b2NvbC5hY2Nv", "dW50LnYxLkFjY291bnRJZBISCgpjbGVhcl90aW1lGAMgASgEMsYFCg9XaGlz", "cGVyTGlzdGVuZXISXAoJT25XaGlzcGVyEiwuYmdzLnByb3RvY29sLndoaXNw", "ZXIudjEuV2hpc3Blck5vdGlmaWNhdGlvbhoZLmJncy5wcm90b2NvbC5OT19S", "RVNQT05TRSIGgvkrAggBEmQKDU9uV2hpc3BlckVjaG8SMC5iZ3MucHJvdG9j",
				"b2wud2hpc3Blci52MS5XaGlzcGVyRWNob05vdGlmaWNhdGlvbhoZLmJncy5w", "cm90b2NvbC5OT19SRVNQT05TRSIGgvkrAggCEnIKF09uVHlwaW5nSW5kaWNh", "dG9yVXBkYXRlEjQuYmdzLnByb3RvY29sLndoaXNwZXIudjEuVHlwaW5nSW5k", "aWNhdG9yTm90aWZpY2F0aW9uGhkuYmdzLnByb3RvY29sLk5PX1JFU1BPTlNF", "IgaC+SsCCAMSbAoRT25BZHZhbmNlVmlld1RpbWUSNC5iZ3MucHJvdG9jb2wu", "d2hpc3Blci52MS5BZHZhbmNlVmlld1RpbWVOb3RpZmljYXRpb24aGS5iZ3Mu", "cHJvdG9jb2wuTk9fUkVTUE9OU0UiBoL5KwIIBBJqChBPbldoaXNwZXJVcGRh", "dGVkEjMuYmdzLnByb3RvY29sLndoaXNwZXIudjEuV2hpc3BlclVwZGF0ZWRO", "b3RpZmljYXRpb24aGS5iZ3MucHJvdG9jb2wuTk9fUkVTUE9OU0UiBoL5KwII", "BRJuChJPbkFkdmFuY2VDbGVhclRpbWUSNS5iZ3MucHJvdG9jb2wud2hpc3Bl",
				"ci52MS5BZHZhbmNlQ2xlYXJUaW1lTm90aWZpY2F0aW9uGhkuYmdzLnByb3Rv", "Y29sLk5PX1JFU1BPTlNFIgaC+SsCCAYaMYL5KycKJWJuZXQucHJvdG9jb2wu", "d2hpc3Blci5XaGlzcGVyTGlzdGVuZXKK+SsCCAE="
			}));
			WhisperListenerReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				WhisperTypesReflection.Descriptor,
				AccountTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor,
				MessageTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(WhisperNotification), WhisperNotification.Parser, new string[] { "SubscriberId", "Whisper", "SenderBattleTag" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(WhisperEchoNotification), WhisperEchoNotification.Parser, new string[] { "SubscriberId", "Whisper" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(TypingIndicatorNotification), TypingIndicatorNotification.Parser, new string[] { "SubscriberId", "SenderId", "Action" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AdvanceViewTimeNotification), AdvanceViewTimeNotification.Parser, new string[] { "SubscriberId", "SenderId", "ViewTime" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(WhisperUpdatedNotification), WhisperUpdatedNotification.Parser, new string[] { "SubscriberId", "Whisper" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AdvanceClearTimeNotification), AdvanceClearTimeNotification.Parser, new string[] { "SubscriberId", "SenderId", "ClearTime" }, null, null, null, null)
			}));
		}

		// Token: 0x04002AD1 RID: 10961
		private static FileDescriptor descriptor;
	}
}
