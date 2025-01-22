using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x02000552 RID: 1362
	public static class SessionListenerReflection
	{
		// Token: 0x170029A0 RID: 10656
		// (get) Token: 0x060083B6 RID: 33718 RVA: 0x00200784 File Offset: 0x001FE984
		public static FileDescriptor Descriptor
		{
			get
			{
				return SessionListenerReflection.descriptor;
			}
		}

		// Token: 0x060083B7 RID: 33719 RVA: 0x0020079C File Offset: 0x001FE99C
		static SessionListenerReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjZiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL3Nlc3Npb25fbGlz", "dGVuZXIucHJvdG8SHmJncy5wcm90b2NvbC5zZXNzaW9uLnYyLmNsaWVudBoz", "YmdzL2xvdy9wYi9jbGllbnQvYXBpL2NsaWVudC92Mi9zZXNzaW9uX3R5cGVz", "LnByb3RvGiFiZ3MvbG93L3BiL2NsaWVudC9ycGNfdHlwZXMucHJvdG8irAEK", "GlNlc3Npb25DcmVhdGVkTm90aWZpY2F0aW9uEg4KBnN0YXR1cxgBIAEoDRI/", "CgtzZXNzaW9uX2tleRgCIAEoCzIqLmJncy5wcm90b2NvbC5zZXNzaW9uLnYy", "LmNsaWVudC5TZXNzaW9uS2V5Ej0KCnNlc3Npb25faWQYAyABKAsyKS5iZ3Mu", "cHJvdG9jb2wuc2Vzc2lvbi52Mi5jbGllbnQuU2Vzc2lvbklkIkYKHFNlc3Np", "b25EZXN0cm95ZWROb3RpZmljYXRpb24SDgoGc3RhdHVzGAEgASgNEhYKDnN0", "YXR1c19kZXRhaWxzGAIgASgNImMKIlNlc3Npb25HYW1lVGltZVdhcm5pbmdO",
				"b3RpZmljYXRpb24SIwobcmVtYWluaW5nX3RpbWVfZHVyYXRpb25fbWluGAEg", "ASgNEhgKEHJlc3RyaWN0aW9uX3R5cGUYAiABKA0iaQofU2Vzc2lvblF1ZXVl", "VXBkYXRlZE5vdGlmaWNhdGlvbhIQCghwb3NpdGlvbhgBIAEoDRIcChRhdmdf", "Y3JlYXRpb25fdGltZV9tcxgCIAEoBBIWCg5xdWV1ZWRfdGltZV9tcxgDIAEo", "BCItChtTZXNzaW9uUXVldWVFbmROb3RpZmljYXRpb24SDgoGc3RhdHVzGAEg", "ASgNMqgFCg9TZXNzaW9uTGlzdGVuZXIScQoQT25TZXNzaW9uQ3JlYXRlZBI6", "LmJncy5wcm90b2NvbC5zZXNzaW9uLnYyLmNsaWVudC5TZXNzaW9uQ3JlYXRl", "ZE5vdGlmaWNhdGlvbhoZLmJncy5wcm90b2NvbC5OT19SRVNQT05TRSIGgvkr", "AggBEnUKEk9uU2Vzc2lvbkRlc3Ryb3llZBI8LmJncy5wcm90b2NvbC5zZXNz", "aW9uLnYyLmNsaWVudC5TZXNzaW9uRGVzdHJveWVkTm90aWZpY2F0aW9uGhku",
				"YmdzLnByb3RvY29sLk5PX1JFU1BPTlNFIgaC+SsCCAISgQEKGE9uU2Vzc2lv", "bkdhbWVUaW1lV2FybmluZxJCLmJncy5wcm90b2NvbC5zZXNzaW9uLnYyLmNs", "aWVudC5TZXNzaW9uR2FtZVRpbWVXYXJuaW5nTm90aWZpY2F0aW9uGhkuYmdz", "LnByb3RvY29sLk5PX1JFU1BPTlNFIgaC+SsCCAMSewoVT25TZXNzaW9uUXVl", "dWVVcGRhdGVkEj8uYmdzLnByb3RvY29sLnNlc3Npb24udjIuY2xpZW50LlNl", "c3Npb25RdWV1ZVVwZGF0ZWROb3RpZmljYXRpb24aGS5iZ3MucHJvdG9jb2wu", "Tk9fUkVTUE9OU0UiBoL5KwIIBBJzChFPblNlc3Npb25RdWV1ZUVuZBI7LmJn", "cy5wcm90b2NvbC5zZXNzaW9uLnYyLmNsaWVudC5TZXNzaW9uUXVldWVFbmRO", "b3RpZmljYXRpb24aGS5iZ3MucHJvdG9jb2wuTk9fUkVTUE9OU0UiBoL5KwII", "BRo1gvkrMQovYm5ldC5wcm90b2NvbC5zZXNzaW9uLnYyLmNsaWVudC5TZXNz",
				"aW9uTGlzdGVuZXJCA4ABAA=="
			}));
			SessionListenerReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				SessionTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(SessionCreatedNotification), SessionCreatedNotification.Parser, new string[] { "Status", "SessionKey", "SessionId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SessionDestroyedNotification), SessionDestroyedNotification.Parser, new string[] { "Status", "StatusDetails" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SessionGameTimeWarningNotification), SessionGameTimeWarningNotification.Parser, new string[] { "RemainingTimeDurationMin", "RestrictionType" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SessionQueueUpdatedNotification), SessionQueueUpdatedNotification.Parser, new string[] { "Position", "AvgCreationTimeMs", "QueuedTimeMs" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SessionQueueEndNotification), SessionQueueEndNotification.Parser, new string[] { "Status" }, null, null, null, null)
			}));
		}

		// Token: 0x04003BCE RID: 15310
		private static FileDescriptor descriptor;
	}
}
