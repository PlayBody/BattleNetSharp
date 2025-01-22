using System;
using Bgs.Protocol.Account.V1;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x020003F3 RID: 1011
	public static class GameRequestServiceReflection
	{
		// Token: 0x1700204C RID: 8268
		// (get) Token: 0x0600647B RID: 25723 RVA: 0x00184538 File Offset: 0x00182738
		public static FileDescriptor Descriptor
		{
			get
			{
				return GameRequestServiceReflection.descriptor;
			}
		}

		// Token: 0x0600647C RID: 25724 RVA: 0x00184550 File Offset: 0x00182750
		static GameRequestServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CixiZ3MvbG93L3BiL2NsaWVudC9nYW1lX3JlcXVlc3Rfc2VydmljZS5wcm90", "bxIbYmdzLnByb3RvY29sLm1hdGNobWFraW5nLnYxGiViZ3MvbG93L3BiL2Ns", "aWVudC9hY2NvdW50X3R5cGVzLnByb3RvGjhiZ3MvbG93L3BiL2NsaWVudC9n", "bG9iYWxfZXh0ZW5zaW9ucy9tZXRob2Rfb3B0aW9ucy5wcm90bxo5YmdzL2xv", "dy9wYi9jbGllbnQvZ2xvYmFsX2V4dGVuc2lvbnMvc2VydmljZV9vcHRpb25z", "LnByb3RvGi5iZ3MvbG93L3BiL2NsaWVudC9nYW1lX21hdGNobWFraW5nX3R5", "cGVzLnByb3RvGiFiZ3MvbG93L3BiL2NsaWVudC9ycGNfdHlwZXMucHJvdG8i", "XwoXUXVldWVNYXRjaG1ha2luZ1JlcXVlc3QSRAoHb3B0aW9ucxgBIAEoCzIz", "LmJncy5wcm90b2NvbC5tYXRjaG1ha2luZy52MS5HYW1lTWF0Y2htYWtpbmdP", "cHRpb25zIlYKGFF1ZXVlTWF0Y2htYWtpbmdSZXNwb25zZRI6CgpyZXF1ZXN0",
				"X2lkGAEgASgLMiYuYmdzLnByb3RvY29sLm1hdGNobWFraW5nLnYxLlJlcXVl", "c3RJZCKEAQoPSm9pbkdhbWVSZXF1ZXN0EjwKC2dhbWVfaGFuZGxlGAEgASgL", "MicuYmdzLnByb3RvY29sLm1hdGNobWFraW5nLnYxLkdhbWVIYW5kbGUSMwoG", "cGxheWVyGAIgAygLMiMuYmdzLnByb3RvY29sLm1hdGNobWFraW5nLnYxLlBs", "YXllciJOChBKb2luR2FtZVJlc3BvbnNlEjoKCnJlcXVlc3RfaWQYASABKAsy", "Ji5iZ3MucHJvdG9jb2wubWF0Y2htYWtpbmcudjEuUmVxdWVzdElkIpgBChhD", "YW5jZWxNYXRjaG1ha2luZ1JlcXVlc3QSOgoKcmVxdWVzdF9pZBgBIAEoCzIm", "LmJncy5wcm90b2NvbC5tYXRjaG1ha2luZy52MS5SZXF1ZXN0SWQSQAoMZ2Ft", "ZV9hY2NvdW50GAIgAygLMiouYmdzLnByb3RvY29sLmFjY291bnQudjEuR2Ft", "ZUFjY291bnRIYW5kbGUiXAoOUXVldWVXYWl0VGltZXMSEAoIbWluX3dhaXQY",
				"ASABKAUSEAoIbWF4X3dhaXQYAiABKAUSEAoIYXZnX3dhaXQYAyABKAUSFAoM", "c3RkX2Rldl93YWl0GAQgASgFIpgCChZRdWV1ZUVudHJ5Tm90aWZpY2F0aW9u", "EjoKCnJlcXVlc3RfaWQYASABKAsyJi5iZ3MucHJvdG9jb2wubWF0Y2htYWtp", "bmcudjEuUmVxdWVzdElkEj8KCndhaXRfdGltZXMYAiABKAsyKy5iZ3MucHJv", "dG9jb2wubWF0Y2htYWtpbmcudjEuUXVldWVXYWl0VGltZXMSOgoGbWVtYmVy", "GAMgAygLMiouYmdzLnByb3RvY29sLmFjY291bnQudjEuR2FtZUFjY291bnRI", "YW5kbGUSRQoRcmVxdWVzdF9pbml0aWF0b3IYBCABKAsyKi5iZ3MucHJvdG9j", "b2wuYWNjb3VudC52MS5HYW1lQWNjb3VudEhhbmRsZSKZAQoVUXVldWVFeGl0", "Tm90aWZpY2F0aW9uEjoKCnJlcXVlc3RfaWQYASABKAsyJi5iZ3MucHJvdG9j", "b2wubWF0Y2htYWtpbmcudjEuUmVxdWVzdElkEkQKEGNhbmNlbF9pbml0aWF0",
				"b3IYAiABKAsyKi5iZ3MucHJvdG9jb2wuYWNjb3VudC52MS5HYW1lQWNjb3Vu", "dEhhbmRsZSLbAQoVUXVldWVMZWZ0Tm90aWZpY2F0aW9uEjoKCnJlcXVlc3Rf", "aWQYASABKAsyJi5iZ3MucHJvdG9jb2wubWF0Y2htYWtpbmcudjEuUmVxdWVz", "dElkEkAKDGdhbWVfYWNjb3VudBgCIAMoCzIqLmJncy5wcm90b2NvbC5hY2Nv", "dW50LnYxLkdhbWVBY2NvdW50SGFuZGxlEkQKEGNhbmNlbF9pbml0aWF0b3IY", "AyABKAsyKi5iZ3MucHJvdG9jb2wuYWNjb3VudC52MS5HYW1lQWNjb3VudEhh", "bmRsZSKuAQoXUXVldWVVcGRhdGVOb3RpZmljYXRpb24SOgoKcmVxdWVzdF9p", "ZBgBIAEoCzImLmJncy5wcm90b2NvbC5tYXRjaG1ha2luZy52MS5SZXF1ZXN0", "SWQSPwoKd2FpdF90aW1lcxgCIAEoCzIrLmJncy5wcm90b2NvbC5tYXRjaG1h", "a2luZy52MS5RdWV1ZVdhaXRUaW1lcxIWCg5pc19tYXRjaG1ha2luZxgDIAEo",
				"CCLpAQodTWF0Y2htYWtpbmdSZXN1bHROb3RpZmljYXRpb24SOgoKcmVxdWVz", "dF9pZBgBIAEoCzImLmJncy5wcm90b2NvbC5tYXRjaG1ha2luZy52MS5SZXF1", "ZXN0SWQSDgoGcmVzdWx0GAIgASgNEj4KDGNvbm5lY3RfaW5mbxgDIAEoCzIo", "LmJncy5wcm90b2NvbC5tYXRjaG1ha2luZy52MS5Db25uZWN0SW5mbxI8Cgtn", "YW1lX2hhbmRsZRgEIAEoCzInLmJncy5wcm90b2NvbC5tYXRjaG1ha2luZy52", "MS5HYW1lSGFuZGxlMqwDChJHYW1lUmVxdWVzdFNlcnZpY2UShwEKEFF1ZXVl", "TWF0Y2htYWtpbmcSNC5iZ3MucHJvdG9jb2wubWF0Y2htYWtpbmcudjEuUXVl", "dWVNYXRjaG1ha2luZ1JlcXVlc3QaNS5iZ3MucHJvdG9jb2wubWF0Y2htYWtp", "bmcudjEuUXVldWVNYXRjaG1ha2luZ1Jlc3BvbnNlIgaC+SsCCAESbwoISm9p", "bkdhbWUSLC5iZ3MucHJvdG9jb2wubWF0Y2htYWtpbmcudjEuSm9pbkdhbWVS",
				"ZXF1ZXN0Gi0uYmdzLnByb3RvY29sLm1hdGNobWFraW5nLnYxLkpvaW5HYW1l", "UmVzcG9uc2UiBoL5KwIIAhJoChFDYW5jZWxNYXRjaG1ha2luZxI1LmJncy5w", "cm90b2NvbC5tYXRjaG1ha2luZy52MS5DYW5jZWxNYXRjaG1ha2luZ1JlcXVl", "c3QaFC5iZ3MucHJvdG9jb2wuTm9EYXRhIgaC+SsCCAMaMYL5KycKJWJuZXQu", "cHJvdG9jb2wubWF0Y2htYWtpbmcuR2FtZVJlcXVlc3SK+SsCEAEy5AQKE0dh", "bWVSZXF1ZXN0TGlzdGVuZXISZgoMT25RdWV1ZUVudHJ5EjMuYmdzLnByb3Rv", "Y29sLm1hdGNobWFraW5nLnYxLlF1ZXVlRW50cnlOb3RpZmljYXRpb24aGS5i", "Z3MucHJvdG9jb2wuTk9fUkVTUE9OU0UiBoL5KwIIARJkCgtPblF1ZXVlRXhp", "dBIyLmJncy5wcm90b2NvbC5tYXRjaG1ha2luZy52MS5RdWV1ZUV4aXROb3Rp", "ZmljYXRpb24aGS5iZ3MucHJvdG9jb2wuTk9fUkVTUE9OU0UiBoL5KwIIAhJk",
				"CgtPblF1ZXVlTGVmdBIyLmJncy5wcm90b2NvbC5tYXRjaG1ha2luZy52MS5R", "dWV1ZUxlZnROb3RpZmljYXRpb24aGS5iZ3MucHJvdG9jb2wuTk9fUkVTUE9O", "U0UiBoL5KwIIAxJoCg1PblF1ZXVlVXBkYXRlEjQuYmdzLnByb3RvY29sLm1h", "dGNobWFraW5nLnYxLlF1ZXVlVXBkYXRlTm90aWZpY2F0aW9uGhkuYmdzLnBy", "b3RvY29sLk5PX1JFU1BPTlNFIgaC+SsCCAQSdAoTT25NYXRjaG1ha2luZ1Jl", "c3VsdBI6LmJncy5wcm90b2NvbC5tYXRjaG1ha2luZy52MS5NYXRjaG1ha2lu", "Z1Jlc3VsdE5vdGlmaWNhdGlvbhoZLmJncy5wcm90b2NvbC5OT19SRVNQT05T", "RSIGgvkrAggFGjmC+SsvCi1ibmV0LnByb3RvY29sLm1hdGNobWFraW5nLkdh", "bWVSZXF1ZXN0TGlzdGVuZXKK+SsCCAFCAkgB"
			}));
			GameRequestServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				AccountTypesReflection.Descriptor,
				MethodOptionsReflection.Descriptor,
				ServiceOptionsReflection.Descriptor,
				GameMatchmakingTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(QueueMatchmakingRequest), QueueMatchmakingRequest.Parser, new string[] { "Options" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(QueueMatchmakingResponse), QueueMatchmakingResponse.Parser, new string[] { "RequestId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(JoinGameRequest), JoinGameRequest.Parser, new string[] { "GameHandle", "Player" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(JoinGameResponse), JoinGameResponse.Parser, new string[] { "RequestId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CancelMatchmakingRequest), CancelMatchmakingRequest.Parser, new string[] { "RequestId", "GameAccount" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(QueueWaitTimes), QueueWaitTimes.Parser, new string[] { "MinWait", "MaxWait", "AvgWait", "StdDevWait" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(QueueEntryNotification), QueueEntryNotification.Parser, new string[] { "RequestId", "WaitTimes", "Member", "RequestInitiator" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(QueueExitNotification), QueueExitNotification.Parser, new string[] { "RequestId", "CancelInitiator" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(QueueLeftNotification), QueueLeftNotification.Parser, new string[] { "RequestId", "GameAccount", "CancelInitiator" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(QueueUpdateNotification), QueueUpdateNotification.Parser, new string[] { "RequestId", "WaitTimes", "IsMatchmaking" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MatchmakingResultNotification), MatchmakingResultNotification.Parser, new string[] { "RequestId", "Result", "ConnectInfo", "GameHandle" }, null, null, null, null)
			}));
		}

		// Token: 0x04002DC5 RID: 11717
		private static FileDescriptor descriptor;
	}
}
