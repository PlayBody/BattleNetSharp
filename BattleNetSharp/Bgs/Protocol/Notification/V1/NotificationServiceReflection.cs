using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Notification.V1
{
	// Token: 0x020005C9 RID: 1481
	public static class NotificationServiceReflection
	{
		// Token: 0x17002BF8 RID: 11256
		// (get) Token: 0x06008C21 RID: 35873 RVA: 0x0021FE74 File Offset: 0x0021E074
		public static FileDescriptor Descriptor
		{
			get
			{
				return NotificationServiceReflection.descriptor;
			}
		}

		// Token: 0x06008C22 RID: 35874 RVA: 0x0021FE8C File Offset: 0x0021E08C
		static NotificationServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CixiZ3MvbG93L3BiL2NsaWVudC9ub3RpZmljYXRpb25fc2VydmljZS5wcm90", "bxIcYmdzLnByb3RvY29sLm5vdGlmaWNhdGlvbi52MRohYmdzL2xvdy9wYi9j", "bGllbnQvcnBjX3R5cGVzLnByb3RvGipiZ3MvbG93L3BiL2NsaWVudC9ub3Rp", "ZmljYXRpb25fdHlwZXMucHJvdG8iVAoQU3Vic2NyaWJlUmVxdWVzdBJACgxz", "dWJzY3JpcHRpb24YASABKAsyKi5iZ3MucHJvdG9jb2wubm90aWZpY2F0aW9u", "LnYxLlN1YnNjcmlwdGlvbiJWChJVbnN1YnNjcmliZVJlcXVlc3QSQAoMc3Vi", "c2NyaXB0aW9uGAEgASgLMiouYmdzLnByb3RvY29sLm5vdGlmaWNhdGlvbi52", "MS5TdWJzY3JpcHRpb24iiAEKDlB1Ymxpc2hSZXF1ZXN0EjQKBnRhcmdldBgB", "IAEoCzIkLmJncy5wcm90b2NvbC5ub3RpZmljYXRpb24udjEuVGFyZ2V0EkAK", "DG5vdGlmaWNhdGlvbhgCIAEoCzIqLmJncy5wcm90b2NvbC5ub3RpZmljYXRp",
				"b24udjEuTm90aWZpY2F0aW9uMsADChNOb3RpZmljYXRpb25TZXJ2aWNlElwK", "EFNlbmROb3RpZmljYXRpb24SKi5iZ3MucHJvdG9jb2wubm90aWZpY2F0aW9u", "LnYxLk5vdGlmaWNhdGlvbhoULmJncy5wcm90b2NvbC5Ob0RhdGEiBoL5KwII", "ARJZCglTdWJzY3JpYmUSLi5iZ3MucHJvdG9jb2wubm90aWZpY2F0aW9uLnYx", "LlN1YnNjcmliZVJlcXVlc3QaFC5iZ3MucHJvdG9jb2wuTm9EYXRhIgaC+SsC", "CAYSXQoLVW5zdWJzY3JpYmUSMC5iZ3MucHJvdG9jb2wubm90aWZpY2F0aW9u", "LnYxLlVuc3Vic2NyaWJlUmVxdWVzdBoULmJncy5wcm90b2NvbC5Ob0RhdGEi", "BoL5KwIIBxJVCgdQdWJsaXNoEiwuYmdzLnByb3RvY29sLm5vdGlmaWNhdGlv", "bi52MS5QdWJsaXNoUmVxdWVzdBoULmJncy5wcm90b2NvbC5Ob0RhdGEiBoL5", "KwIICBo6gvkrMAouYm5ldC5wcm90b2NvbC5ub3RpZmljYXRpb24uTm90aWZp",
				"Y2F0aW9uU2VydmljZYr5KwIQATK8AQoUTm90aWZpY2F0aW9uTGlzdGVuZXIS", "ZwoWT25Ob3RpZmljYXRpb25SZWNlaXZlZBIqLmJncy5wcm90b2NvbC5ub3Rp", "ZmljYXRpb24udjEuTm90aWZpY2F0aW9uGhkuYmdzLnByb3RvY29sLk5PX1JF", "U1BPTlNFIgaC+SsCCAEaO4L5KzEKL2JuZXQucHJvdG9jb2wubm90aWZpY2F0", "aW9uLk5vdGlmaWNhdGlvbkxpc3RlbmVyivkrAggBQgVIAYABAA=="
			}));
			NotificationServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				RpcTypesReflection.Descriptor,
				NotificationTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(SubscribeRequest), SubscribeRequest.Parser, new string[] { "Subscription" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UnsubscribeRequest), UnsubscribeRequest.Parser, new string[] { "Subscription" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PublishRequest), PublishRequest.Parser, new string[] { "Target", "Notification" }, null, null, null, null)
			}));
		}

		// Token: 0x04003F67 RID: 16231
		private static FileDescriptor descriptor;
	}
}
