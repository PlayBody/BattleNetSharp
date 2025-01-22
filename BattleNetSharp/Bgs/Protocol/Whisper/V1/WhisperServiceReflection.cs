using System;
using Bgs.Protocol.Account.V1;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Whisper.V1
{
	// Token: 0x020003A2 RID: 930
	public static class WhisperServiceReflection
	{
		// Token: 0x17001E7C RID: 7804
		// (get) Token: 0x06005E09 RID: 24073 RVA: 0x0016C2EC File Offset: 0x0016A4EC
		public static FileDescriptor Descriptor
		{
			get
			{
				return WhisperServiceReflection.descriptor;
			}
		}

		// Token: 0x06005E0A RID: 24074 RVA: 0x0016C304 File Offset: 0x0016A504
		static WhisperServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CidiZ3MvbG93L3BiL2NsaWVudC93aGlzcGVyX3NlcnZpY2UucHJvdG8SF2Jn", "cy5wcm90b2NvbC53aGlzcGVyLnYxGiViZ3MvbG93L3BiL2NsaWVudC93aGlz", "cGVyX3R5cGVzLnByb3RvGiFiZ3MvbG93L3BiL2NsaWVudC9ycGNfdHlwZXMu", "cHJvdG8aJWJncy9sb3cvcGIvY2xpZW50L2FjY291bnRfdHlwZXMucHJvdG8a", "KGJncy9sb3cvcGIvY2xpZW50L2V2ZW50X3ZpZXdfdHlwZXMucHJvdG8aJWJn", "cy9sb3cvcGIvY2xpZW50L21lc3NhZ2VfdHlwZXMucHJvdG8iSAoQU3Vic2Ny", "aWJlUmVxdWVzdBI0CghhZ2VudF9pZBgBIAEoCzIiLmJncy5wcm90b2NvbC5h", "Y2NvdW50LnYxLkFjY291bnRJZCJHChFTdWJzY3JpYmVSZXNwb25zZRIyCgR2", "aWV3GAEgAygLMiQuYmdzLnByb3RvY29sLndoaXNwZXIudjEuV2hpc3BlclZp", "ZXciSgoSVW5zdWJzY3JpYmVSZXF1ZXN0EjQKCGFnZW50X2lkGAEgASgLMiIu",
				"YmdzLnByb3RvY29sLmFjY291bnQudjEuQWNjb3VudElkIoEBChJTZW5kV2hp", "c3BlclJlcXVlc3QSNAoIYWdlbnRfaWQYASABKAsyIi5iZ3MucHJvdG9jb2wu", "YWNjb3VudC52MS5BY2NvdW50SWQSNQoHd2hpc3BlchgCIAEoCzIkLmJncy5w", "cm90b2NvbC53aGlzcGVyLnYxLlNlbmRPcHRpb25zIkgKE1NlbmRXaGlzcGVy", "UmVzcG9uc2USMQoHd2hpc3BlchgBIAEoCzIgLmJncy5wcm90b2NvbC53aGlz", "cGVyLnYxLldoaXNwZXIixQEKGVNldFR5cGluZ0luZGljYXRvclJlcXVlc3QS", "NAoIYWdlbnRfaWQYASABKAsyIi5iZ3MucHJvdG9jb2wuYWNjb3VudC52MS5B", "Y2NvdW50SWQSNQoJdGFyZ2V0X2lkGAIgASgLMiIuYmdzLnByb3RvY29sLmFj", "Y291bnQudjEuQWNjb3VudElkEjsKBmFjdGlvbhgDIAEoDjIdLmJncy5wcm90", "b2NvbC5UeXBpbmdJbmRpY2F0b3I6DFRZUElOR19TVEFSVCKFAQoWQWR2YW5j",
				"ZVZpZXdUaW1lUmVxdWVzdBI0CghhZ2VudF9pZBgBIAEoCzIiLmJncy5wcm90", "b2NvbC5hY2NvdW50LnYxLkFjY291bnRJZBI1Cgl0YXJnZXRfaWQYAiABKAsy", "Ii5iZ3MucHJvdG9jb2wuYWNjb3VudC52MS5BY2NvdW50SWQihgEKF0FkdmFu", "Y2VDbGVhclRpbWVSZXF1ZXN0EjQKCGFnZW50X2lkGAEgASgLMiIuYmdzLnBy", "b3RvY29sLmFjY291bnQudjEuQWNjb3VudElkEjUKCXRhcmdldF9pZBgCIAEo", "CzIiLmJncy5wcm90b2NvbC5hY2NvdW50LnYxLkFjY291bnRJZCK4AQoZR2V0", "V2hpc3Blck1lc3NhZ2VzUmVxdWVzdBI0CghhZ2VudF9pZBgBIAEoCzIiLmJn", "cy5wcm90b2NvbC5hY2NvdW50LnYxLkFjY291bnRJZBI1Cgl0YXJnZXRfaWQY", "AiABKAsyIi5iZ3MucHJvdG9jb2wuYWNjb3VudC52MS5BY2NvdW50SWQSLgoH", "b3B0aW9ucxgDIAEoCzIdLmJncy5wcm90b2NvbC5HZXRFdmVudE9wdGlvbnMi",
				"ZQoaR2V0V2hpc3Blck1lc3NhZ2VzUmVzcG9uc2USMQoHd2hpc3BlchgBIAMo", "CzIgLmJncy5wcm90b2NvbC53aGlzcGVyLnYxLldoaXNwZXISFAoMY29udGlu", "dWF0aW9uGAIgASgEMrAGCg5XaGlzcGVyU2VydmljZRJqCglTdWJzY3JpYmUS", "KS5iZ3MucHJvdG9jb2wud2hpc3Blci52MS5TdWJzY3JpYmVSZXF1ZXN0Giou", "YmdzLnByb3RvY29sLndoaXNwZXIudjEuU3Vic2NyaWJlUmVzcG9uc2UiBoL5", "KwIIARJYCgtVbnN1YnNjcmliZRIrLmJncy5wcm90b2NvbC53aGlzcGVyLnYx", "LlVuc3Vic2NyaWJlUmVxdWVzdBoULmJncy5wcm90b2NvbC5Ob0RhdGEiBoL5", "KwIIAhJwCgtTZW5kV2hpc3BlchIrLmJncy5wcm90b2NvbC53aGlzcGVyLnYx", "LlNlbmRXaGlzcGVyUmVxdWVzdBosLmJncy5wcm90b2NvbC53aGlzcGVyLnYx", "LlNlbmRXaGlzcGVyUmVzcG9uc2UiBoL5KwIIAxJmChJTZXRUeXBpbmdJbmRp",
				"Y2F0b3ISMi5iZ3MucHJvdG9jb2wud2hpc3Blci52MS5TZXRUeXBpbmdJbmRp", "Y2F0b3JSZXF1ZXN0GhQuYmdzLnByb3RvY29sLk5vRGF0YSIGgvkrAggEEmAK", "D0FkdmFuY2VWaWV3VGltZRIvLmJncy5wcm90b2NvbC53aGlzcGVyLnYxLkFk", "dmFuY2VWaWV3VGltZVJlcXVlc3QaFC5iZ3MucHJvdG9jb2wuTm9EYXRhIgaC", "+SsCCAUShQEKEkdldFdoaXNwZXJNZXNzYWdlcxIyLmJncy5wcm90b2NvbC53", "aGlzcGVyLnYxLkdldFdoaXNwZXJNZXNzYWdlc1JlcXVlc3QaMy5iZ3MucHJv", "dG9jb2wud2hpc3Blci52MS5HZXRXaGlzcGVyTWVzc2FnZXNSZXNwb25zZSIG", "gvkrAggGEmIKEEFkdmFuY2VDbGVhclRpbWUSMC5iZ3MucHJvdG9jb2wud2hp", "c3Blci52MS5BZHZhbmNlQ2xlYXJUaW1lUmVxdWVzdBoULmJncy5wcm90b2Nv", "bC5Ob0RhdGEiBoL5KwIIBxowgvkrJgokYm5ldC5wcm90b2NvbC53aGlzcGVy",
				"LldoaXNwZXJTZXJ2aWNlivkrAhABQgOAAQA="
			}));
			WhisperServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				WhisperTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor,
				AccountTypesReflection.Descriptor,
				EventViewTypesReflection.Descriptor,
				MessageTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(SubscribeRequest), SubscribeRequest.Parser, new string[] { "AgentId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SubscribeResponse), SubscribeResponse.Parser, new string[] { "View" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UnsubscribeRequest), UnsubscribeRequest.Parser, new string[] { "AgentId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SendWhisperRequest), SendWhisperRequest.Parser, new string[] { "AgentId", "Whisper" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SendWhisperResponse), SendWhisperResponse.Parser, new string[] { "Whisper" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SetTypingIndicatorRequest), SetTypingIndicatorRequest.Parser, new string[] { "AgentId", "TargetId", "Action" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AdvanceViewTimeRequest), AdvanceViewTimeRequest.Parser, new string[] { "AgentId", "TargetId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AdvanceClearTimeRequest), AdvanceClearTimeRequest.Parser, new string[] { "AgentId", "TargetId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetWhisperMessagesRequest), GetWhisperMessagesRequest.Parser, new string[] { "AgentId", "TargetId", "Options" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetWhisperMessagesResponse), GetWhisperMessagesResponse.Parser, new string[] { "Whisper", "Continuation" }, null, null, null, null)
			}));
		}

		// Token: 0x04002B13 RID: 11027
		private static FileDescriptor descriptor;
	}
}
