using System;
using Bgs.Protocol.V2;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V2.Client
{
	// Token: 0x020005FE RID: 1534
	public static class GameUtilitiesServiceReflection
	{
		// Token: 0x17002CF1 RID: 11505
		// (get) Token: 0x06008FB6 RID: 36790 RVA: 0x0022DAD8 File Offset: 0x0022BCD8
		public static FileDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.descriptor;
			}
		}

		// Token: 0x06008FB7 RID: 36791 RVA: 0x0022DAF0 File Offset: 0x0022BCF0
		static GameUtilitiesServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjxiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL2dhbWVfdXRpbGl0", "aWVzX3NlcnZpY2UucHJvdG8SJWJncy5wcm90b2NvbC5nYW1lX3V0aWxpdGll", "cy52Mi5jbGllbnQaNWJncy9sb3cvcGIvY2xpZW50L2FwaS9jbGllbnQvdjIv", "YXR0cmlidXRlX3R5cGVzLnByb3RvGiFiZ3MvbG93L3BiL2NsaWVudC9ycGNf", "dHlwZXMucHJvdG8icAoSUHJvY2Vzc1Rhc2tSZXF1ZXN0Ei0KCWF0dHJpYnV0", "ZRgBIAMoCzIaLmJncy5wcm90b2NvbC52Mi5BdHRyaWJ1dGUSKwoHcGF5bG9h", "ZBgCIAMoCzIaLmJncy5wcm90b2NvbC52Mi5BdHRyaWJ1dGUiQQoTUHJvY2Vz", "c1Rhc2tSZXNwb25zZRIqCgZyZXN1bHQYASADKAsyGi5iZ3MucHJvdG9jb2wu", "djIuQXR0cmlidXRlIk8KH0dldEFsbFZhbHVlc0ZvckF0dHJpYnV0ZVJlcXVl", "c3QSLAoNYXR0cmlidXRlX2tleRgBIAEoCUIVivkrBiIECgIIAYr5KwciBQoD",
				"EIACIlUKIEdldEFsbFZhbHVlc0ZvckF0dHJpYnV0ZVJlc3BvbnNlEjEKD2F0", "dHJpYnV0ZV92YWx1ZRgBIAMoCzIYLmJncy5wcm90b2NvbC52Mi5WYXJpYW50", "Mp0DChRHYW1lVXRpbGl0aWVzU2VydmljZRKMAQoLUHJvY2Vzc1Rhc2sSOS5i", "Z3MucHJvdG9jb2wuZ2FtZV91dGlsaXRpZXMudjIuY2xpZW50LlByb2Nlc3NU", "YXNrUmVxdWVzdBo6LmJncy5wcm90b2NvbC5nYW1lX3V0aWxpdGllcy52Mi5j", "bGllbnQuUHJvY2Vzc1Rhc2tSZXNwb25zZSIGgvkrAggBErMBChhHZXRBbGxW", "YWx1ZXNGb3JBdHRyaWJ1dGUSRi5iZ3MucHJvdG9jb2wuZ2FtZV91dGlsaXRp", "ZXMudjIuY2xpZW50LkdldEFsbFZhbHVlc0ZvckF0dHJpYnV0ZVJlcXVlc3Qa", "Ry5iZ3MucHJvdG9jb2wuZ2FtZV91dGlsaXRpZXMudjIuY2xpZW50LkdldEFs", "bFZhbHVlc0ZvckF0dHJpYnV0ZVJlc3BvbnNlIgaC+SsCCAIaQIL5KzYKNGJu",
				"ZXQucHJvdG9jb2wuZ2FtZV91dGlsaXRpZXMudjIuY2xpZW50LkdhbWVVdGls", "aXRpZXOK+SsCEAFCA4ABAA=="
			}));
			GameUtilitiesServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				AttributeTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ProcessTaskRequest), ProcessTaskRequest.Parser, new string[] { "Attribute", "Payload" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ProcessTaskResponse), ProcessTaskResponse.Parser, new string[] { "Result" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetAllValuesForAttributeRequest), GetAllValuesForAttributeRequest.Parser, new string[] { "AttributeKey" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetAllValuesForAttributeResponse), GetAllValuesForAttributeResponse.Parser, new string[] { "AttributeValue" }, null, null, null, null)
			}));
		}

		// Token: 0x040040E9 RID: 16617
		private static FileDescriptor descriptor;
	}
}
