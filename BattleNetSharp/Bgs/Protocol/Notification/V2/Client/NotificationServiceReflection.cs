using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Notification.V2.Client
{
	// Token: 0x020005D7 RID: 1495
	public static class NotificationServiceReflection
	{
		// Token: 0x17002C31 RID: 11313
		// (get) Token: 0x06008CF4 RID: 36084 RVA: 0x002234A4 File Offset: 0x002216A4
		public static FileDescriptor Descriptor
		{
			get
			{
				return NotificationServiceReflection.descriptor;
			}
		}

		// Token: 0x06008CF5 RID: 36085 RVA: 0x002234BC File Offset: 0x002216BC
		static NotificationServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjpiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL25vdGlmaWNhdGlv", "bl9zZXJ2aWNlLnByb3RvEiNiZ3MucHJvdG9jb2wubm90aWZpY2F0aW9uLnYy", "LmNsaWVudBo4YmdzL2xvdy9wYi9jbGllbnQvYXBpL2NsaWVudC92Mi9ub3Rp", "ZmljYXRpb25fdHlwZXMucHJvdG8aIWJncy9sb3cvcGIvY2xpZW50L3JwY190", "eXBlcy5wcm90byJoChdTZW5kTm90aWZpY2F0aW9uUmVxdWVzdBJNCgdvcHRp", "b25zGAIgASgLMjwuYmdzLnByb3RvY29sLm5vdGlmaWNhdGlvbi52Mi5jbGll", "bnQuU2VuZE5vdGlmaWNhdGlvbk9wdGlvbnMyywEKE05vdGlmaWNhdGlvblNl", "cnZpY2USbgoQU2VuZE5vdGlmaWNhdGlvbhI8LmJncy5wcm90b2NvbC5ub3Rp", "ZmljYXRpb24udjIuY2xpZW50LlNlbmROb3RpZmljYXRpb25SZXF1ZXN0GhQu", "YmdzLnByb3RvY29sLk5vRGF0YSIGgvkrAggBGkSC+Ss6CjhibmV0LnByb3Rv",
				"Y29sLm5vdGlmaWNhdGlvbi52Mi5jbGllbnQuTm90aWZpY2F0aW9uU2Vydmlj", "ZYr5KwIQAUIDgAEA"
			}));
			NotificationServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				NotificationTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(SendNotificationRequest), SendNotificationRequest.Parser, new string[] { "Options" }, null, null, null, null)
			}));
		}

		// Token: 0x04003FC1 RID: 16321
		private static FileDescriptor descriptor;
	}
}
