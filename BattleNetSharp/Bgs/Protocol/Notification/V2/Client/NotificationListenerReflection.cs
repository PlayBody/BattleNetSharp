using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Notification.V2.Client
{
	// Token: 0x020005D4 RID: 1492
	public static class NotificationListenerReflection
	{
		// Token: 0x17002C2B RID: 11307
		// (get) Token: 0x06008CDA RID: 36058 RVA: 0x00222F30 File Offset: 0x00221130
		public static FileDescriptor Descriptor
		{
			get
			{
				return NotificationListenerReflection.descriptor;
			}
		}

		// Token: 0x06008CDB RID: 36059 RVA: 0x00222F48 File Offset: 0x00221148
		static NotificationListenerReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjtiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL25vdGlmaWNhdGlv", "bl9saXN0ZW5lci5wcm90bxIjYmdzLnByb3RvY29sLm5vdGlmaWNhdGlvbi52", "Mi5jbGllbnQaIWJncy9sb3cvcGIvY2xpZW50L3JwY190eXBlcy5wcm90bxo4", "YmdzL2xvdy9wYi9jbGllbnQvYXBpL2NsaWVudC92Mi9ub3RpZmljYXRpb25f", "dHlwZXMucHJvdG8ibAogTm90aWZpY2F0aW9uUmVjZWl2ZWROb3RpZmljYXRp", "b24SSAoNbm90aWZpY2F0aW9ucxgBIAMoCzIxLmJncy5wcm90b2NvbC5ub3Rp", "ZmljYXRpb24udjIuY2xpZW50Lk5vdGlmaWNhdGlvbjLiAQoUTm90aWZpY2F0", "aW9uTGlzdGVuZXISggEKFk9uTm90aWZpY2F0aW9uUmVjZWl2ZWQSRS5iZ3Mu", "cHJvdG9jb2wubm90aWZpY2F0aW9uLnYyLmNsaWVudC5Ob3RpZmljYXRpb25S", "ZWNlaXZlZE5vdGlmaWNhdGlvbhoZLmJncy5wcm90b2NvbC5OT19SRVNQT05T",
				"RSIGgvkrAggBGkWC+Ss7CjlibmV0LnByb3RvY29sLm5vdGlmaWNhdGlvbi52", "Mi5jbGllbnQuTm90aWZpY2F0aW9uTGlzdGVuZXKK+SsCCAFCA4ABAA=="
			}));
			NotificationListenerReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				RpcTypesReflection.Descriptor,
				NotificationTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(NotificationReceivedNotification), NotificationReceivedNotification.Parser, new string[] { "Notifications" }, null, null, null, null)
			}));
		}

		// Token: 0x04003FB7 RID: 16311
		private static FileDescriptor descriptor;
	}
}
