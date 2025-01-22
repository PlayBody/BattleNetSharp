using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Publication.V2.Client
{
	// Token: 0x0200058C RID: 1420
	public static class PublicationListenerReflection
	{
		// Token: 0x17002AD8 RID: 10968
		// (get) Token: 0x06008801 RID: 34817 RVA: 0x00210B70 File Offset: 0x0020ED70
		public static FileDescriptor Descriptor
		{
			get
			{
				return PublicationListenerReflection.descriptor;
			}
		}

		// Token: 0x06008802 RID: 34818 RVA: 0x00210B88 File Offset: 0x0020ED88
		static PublicationListenerReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "CjpiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL3B1YmxpY2F0aW9u", "X2xpc3RlbmVyLnByb3RvEiJiZ3MucHJvdG9jb2wucHVibGljYXRpb24udjIu", "Y2xpZW50GiFiZ3MvbG93L3BiL2NsaWVudC9ycGNfdHlwZXMucHJvdG8aN2Jn", "cy9sb3cvcGIvY2xpZW50L2FwaS9jbGllbnQvdjIvcHVibGljYXRpb25fdHlw", "ZXMucHJvdG8iYAofUHVibGljYXRpb25SZWNlaXZlZE5vdGlmaWNhdGlvbhI9", "CghhcnRpY2xlcxgBIAMoCzIrLmJncy5wcm90b2NvbC5wdWJsaWNhdGlvbi52", "Mi5jbGllbnQuQXJ0aWNsZTKOAQoTUHVibGljYXRpb25MaXN0ZW5lchJ3ChVP", "blB1YmxpY2F0aW9uUmVjZWl2ZWQSQy5iZ3MucHJvdG9jb2wucHVibGljYXRp", "b24udjIuY2xpZW50LlB1YmxpY2F0aW9uUmVjZWl2ZWROb3RpZmljYXRpb24a", "GS5iZ3MucHJvdG9jb2wuTk9fUkVTUE9OU0VCA4ABAA==" }));
			PublicationListenerReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				RpcTypesReflection.Descriptor,
				PublicationTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(PublicationReceivedNotification), PublicationReceivedNotification.Parser, new string[] { "Articles" }, null, null, null, null)
			}));
		}

		// Token: 0x04003DA3 RID: 15779
		private static FileDescriptor descriptor;
	}
}
