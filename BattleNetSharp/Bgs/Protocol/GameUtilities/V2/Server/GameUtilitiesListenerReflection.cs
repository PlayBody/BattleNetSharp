using System;
using Bgs.Protocol.V2;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V2.Server
{
	// Token: 0x020005F1 RID: 1521
	public static class GameUtilitiesListenerReflection
	{
		// Token: 0x17002CB3 RID: 11443
		// (get) Token: 0x06008ED2 RID: 36562 RVA: 0x0022A86C File Offset: 0x00228A6C
		public static FileDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesListenerReflection.descriptor;
			}
		}

		// Token: 0x06008ED3 RID: 36563 RVA: 0x0022A884 File Offset: 0x00228A84
		static GameUtilitiesListenerReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"Cj1iZ3MvbG93L3BiL2NsaWVudC9hcGkvc2VydmVyL3YyL2dhbWVfdXRpbGl0", "aWVzX2xpc3RlbmVyLnByb3RvEiViZ3MucHJvdG9jb2wuZ2FtZV91dGlsaXRp", "ZXMudjIuc2VydmVyGkJiZ3MvbG93L3BiL2NsaWVudC9hcGkvc2VydmVyL3Yy", "L2dhbWVfdXRpbGl0aWVzX3NlcnZpY2VfdHlwZXMucHJvdG8aNWJncy9sb3cv", "cGIvY2xpZW50L2FwaS9jbGllbnQvdjIvYXR0cmlidXRlX3R5cGVzLnByb3Rv", "GiFiZ3MvbG93L3BiL2NsaWVudC9ycGNfdHlwZXMucHJvdG8idQoXUHJvY2Vz", "c0FkbWluVGFza1JlcXVlc3QSLQoJYXR0cmlidXRlGAEgAygLMhouYmdzLnBy", "b3RvY29sLnYyLkF0dHJpYnV0ZRIrCgdwYXlsb2FkGAIgAygLMhouYmdzLnBy", "b3RvY29sLnYyLkF0dHJpYnV0ZSJGChhQcm9jZXNzQWRtaW5UYXNrUmVzcG9u", "c2USKgoGcmVzdWx0GAEgAygLMhouYmdzLnByb3RvY29sLnYyLkF0dHJpYnV0",
				"ZSK+AQoYUHJvY2Vzc0NsaWVudFRhc2tSZXF1ZXN0Ei0KCWF0dHJpYnV0ZRgB", "IAMoCzIaLmJncy5wcm90b2NvbC52Mi5BdHRyaWJ1dGUSKwoHcGF5bG9hZBgC", "IAMoCzIaLmJncy5wcm90b2NvbC52Mi5BdHRyaWJ1dGUSRgoLY2xpZW50X2lu", "Zm8YAyABKAsyMS5iZ3MucHJvdG9jb2wuZ2FtZV91dGlsaXRpZXMudjIuc2Vy", "dmVyLkNsaWVudEluZm8iRwoZUHJvY2Vzc0NsaWVudFRhc2tSZXNwb25zZRIq", "CgZyZXN1bHQYASADKAsyGi5iZ3MucHJvdG9jb2wudjIuQXR0cmlidXRlInYK", "GFByb2Nlc3NTZXJ2ZXJUYXNrUmVxdWVzdBItCglhdHRyaWJ1dGUYASADKAsy", "Gi5iZ3MucHJvdG9jb2wudjIuQXR0cmlidXRlEisKB3BheWxvYWQYAiADKAsy", "Gi5iZ3MucHJvdG9jb2wudjIuQXR0cmlidXRlIkcKGVByb2Nlc3NTZXJ2ZXJU", "YXNrUmVzcG9uc2USKgoGcmVzdWx0GAEgAygLMhouYmdzLnByb3RvY29sLnYy",
				"LkF0dHJpYnV0ZTLfAwoVR2FtZVV0aWxpdGllc0xpc3RlbmVyEpYBChFQcm9j", "ZXNzQ2xpZW50VGFzaxI/LmJncy5wcm90b2NvbC5nYW1lX3V0aWxpdGllcy52", "Mi5zZXJ2ZXIuUHJvY2Vzc0NsaWVudFRhc2tSZXF1ZXN0GkAuYmdzLnByb3Rv", "Y29sLmdhbWVfdXRpbGl0aWVzLnYyLnNlcnZlci5Qcm9jZXNzQ2xpZW50VGFz", "a1Jlc3BvbnNlEpYBChFQcm9jZXNzU2VydmVyVGFzaxI/LmJncy5wcm90b2Nv", "bC5nYW1lX3V0aWxpdGllcy52Mi5zZXJ2ZXIuUHJvY2Vzc1NlcnZlclRhc2tS", "ZXF1ZXN0GkAuYmdzLnByb3RvY29sLmdhbWVfdXRpbGl0aWVzLnYyLnNlcnZl", "ci5Qcm9jZXNzU2VydmVyVGFza1Jlc3BvbnNlEpMBChBQcm9jZXNzQWRtaW5U", "YXNrEj4uYmdzLnByb3RvY29sLmdhbWVfdXRpbGl0aWVzLnYyLnNlcnZlci5Q", "cm9jZXNzQWRtaW5UYXNrUmVxdWVzdBo/LmJncy5wcm90b2NvbC5nYW1lX3V0",
				"aWxpdGllcy52Mi5zZXJ2ZXIuUHJvY2Vzc0FkbWluVGFza1Jlc3BvbnNlQgOA", "AQA="
			}));
			GameUtilitiesListenerReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				GameUtilitiesServiceTypesReflection.Descriptor,
				AttributeTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ProcessAdminTaskRequest), ProcessAdminTaskRequest.Parser, new string[] { "Attribute", "Payload" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ProcessAdminTaskResponse), ProcessAdminTaskResponse.Parser, new string[] { "Result" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ProcessClientTaskRequest), ProcessClientTaskRequest.Parser, new string[] { "Attribute", "Payload", "ClientInfo" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ProcessClientTaskResponse), ProcessClientTaskResponse.Parser, new string[] { "Result" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ProcessServerTaskRequest), ProcessServerTaskRequest.Parser, new string[] { "Attribute", "Payload" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ProcessServerTaskResponse), ProcessServerTaskResponse.Parser, new string[] { "Result" }, null, null, null, null)
			}));
		}

		// Token: 0x04004089 RID: 16521
		private static FileDescriptor descriptor;
	}
}
