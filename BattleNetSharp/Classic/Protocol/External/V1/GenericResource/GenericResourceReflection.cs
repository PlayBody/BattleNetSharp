using System;
using Bgs.Protocol;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.GenericResource
{
	// Token: 0x02000782 RID: 1922
	public static class GenericResourceReflection
	{
		// Token: 0x1700368F RID: 13967
		// (get) Token: 0x0600B06C RID: 45164 RVA: 0x002AF184 File Offset: 0x002AD384
		public static FileDescriptor Descriptor
		{
			get
			{
				return GenericResourceReflection.descriptor;
			}
		}

		// Token: 0x0600B06D RID: 45165 RVA: 0x002AF19C File Offset: 0x002AD39C
		static GenericResourceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChpiZ3MvZ2VuZXJpY19yZXNvdXJjZS5wcm90bxItY2xhc3NpYy5wcm90b2Nv", "bC5leHRlcm5hbC52MS5nZW5lcmljX3Jlc291cmNlGiFiZ3MvbG93L3BiL2Ns", "aWVudC9ycGNfdHlwZXMucHJvdG8iMgoERGF0YRIMCgRsYW5nGAEgASgJEgsK", "A2tleRgCIAEoCRIPCgdtZXNzYWdlGAMgASgJIlwKCFJlc291cmNlEgwKBG5h", "bWUYASACKAkSQgoFdmFsdWUYAiABKAsyMy5jbGFzc2ljLnByb3RvY29sLmV4", "dGVybmFsLnYxLmdlbmVyaWNfcmVzb3VyY2UuRGF0YSJgChJBdmFpbGFibGVS", "ZXNvdXJjZXMSSgoJcmVzb3VyY2VzGAEgAygLMjcuY2xhc3NpYy5wcm90b2Nv", "bC5leHRlcm5hbC52MS5nZW5lcmljX3Jlc291cmNlLlJlc291cmNlMsoCCg9H", "ZW5lcmljUmVzb3VyY2USpgEKElJlcUdlbmVyaWNSZXNvdXJjZRJBLmNsYXNz", "aWMucHJvdG9jb2wuZXh0ZXJuYWwudjEuZ2VuZXJpY19yZXNvdXJjZS5BdmFp",
				"bGFibGVSZXNvdXJjZXMaQS5jbGFzc2ljLnByb3RvY29sLmV4dGVybmFsLnYx", "LmdlbmVyaWNfcmVzb3VyY2UuQXZhaWxhYmxlUmVzb3VyY2VzIgqC+SsGCJSs", "grMPEnwKFVNldEF2YWlsYWJsZVJlc291cmNlcxJBLmNsYXNzaWMucHJvdG9j", "b2wuZXh0ZXJuYWwudjEuZ2VuZXJpY19yZXNvdXJjZS5BdmFpbGFibGVSZXNv", "dXJjZXMaFC5iZ3MucHJvdG9jb2wuTm9EYXRhIgqC+SsGCOPTlcMEGhCC+SsM", "CgoweDUzRjJGRDY5"
			}));
			GenericResourceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { RpcTypesReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(Data), Data.Parser, new string[] { "Lang", "Key", "Message" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Resource), Resource.Parser, new string[] { "Name", "Value" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AvailableResources), AvailableResources.Parser, new string[] { "Resources" }, null, null, null, null)
			}));
		}

		// Token: 0x04004F98 RID: 20376
		private static FileDescriptor descriptor;
	}
}
