using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Publication.V2.Client
{
	// Token: 0x0200058F RID: 1423
	public static class PublicationServiceReflection
	{
		// Token: 0x17002ADE RID: 10974
		// (get) Token: 0x0600881B RID: 34843 RVA: 0x002110D0 File Offset: 0x0020F2D0
		public static FileDescriptor Descriptor
		{
			get
			{
				return PublicationServiceReflection.descriptor;
			}
		}

		// Token: 0x0600881C RID: 34844 RVA: 0x002110E8 File Offset: 0x0020F2E8
		static PublicationServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjliZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL3B1YmxpY2F0aW9u", "X3NlcnZpY2UucHJvdG8SImJncy5wcm90b2NvbC5wdWJsaWNhdGlvbi52Mi5j", "bGllbnQaIWJncy9sb3cvcGIvY2xpZW50L3JwY190eXBlcy5wcm90bxo3Ymdz", "L2xvdy9wYi9jbGllbnQvYXBpL2NsaWVudC92Mi9wdWJsaWNhdGlvbl90eXBl", "cy5wcm90byKVAQoQU3Vic2NyaWJlUmVxdWVzdBI6CgZ0YXJnZXQYASADKAsy", "Ki5iZ3MucHJvdG9jb2wucHVibGljYXRpb24udjIuY2xpZW50LlRhcmdldBJF", "CgdvcHRpb25zGAIgASgLMjQuYmdzLnByb3RvY29sLnB1YmxpY2F0aW9uLnYy", "LmNsaWVudC5TdWJzY3JpYmVPcHRpb25zIloKEVN1YnNjcmliZVJlc3BvbnNl", "EkUKCGZhaWx1cmVzGAEgAygLMjMuYmdzLnByb3RvY29sLnB1YmxpY2F0aW9u", "LnYyLmNsaWVudC5TdWJzY3JpYmVSZXN1bHQiUAoSVW5zdWJzY3JpYmVSZXF1",
				"ZXN0EjoKBnRhcmdldBgBIAMoCzIqLmJncy5wcm90b2NvbC5wdWJsaWNhdGlv", "bi52Mi5jbGllbnQuVGFyZ2V0MusBChJQdWJsaWNhdGlvblNlcnZpY2USeAoJ", "U3Vic2NyaWJlEjQuYmdzLnByb3RvY29sLnB1YmxpY2F0aW9uLnYyLmNsaWVu", "dC5TdWJzY3JpYmVSZXF1ZXN0GjUuYmdzLnByb3RvY29sLnB1YmxpY2F0aW9u", "LnYyLmNsaWVudC5TdWJzY3JpYmVSZXNwb25zZRJbCgtVbnN1YnNjcmliZRI2", "LmJncy5wcm90b2NvbC5wdWJsaWNhdGlvbi52Mi5jbGllbnQuVW5zdWJzY3Jp", "YmVSZXF1ZXN0GhQuYmdzLnByb3RvY29sLk5vRGF0YUIDgAEA"
			}));
			PublicationServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				RpcTypesReflection.Descriptor,
				PublicationTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(SubscribeRequest), SubscribeRequest.Parser, new string[] { "Target", "Options" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SubscribeResponse), SubscribeResponse.Parser, new string[] { "Failures" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UnsubscribeRequest), UnsubscribeRequest.Parser, new string[] { "Target" }, null, null, null, null)
			}));
		}

		// Token: 0x04003DAD RID: 15789
		private static FileDescriptor descriptor;
	}
}
