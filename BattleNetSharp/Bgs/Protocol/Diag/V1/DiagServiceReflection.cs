using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Diag.V1
{
	// Token: 0x02000421 RID: 1057
	public static class DiagServiceReflection
	{
		// Token: 0x17002161 RID: 8545
		// (get) Token: 0x06006854 RID: 26708 RVA: 0x00194068 File Offset: 0x00192268
		public static FileDescriptor Descriptor
		{
			get
			{
				return DiagServiceReflection.descriptor;
			}
		}

		// Token: 0x06006855 RID: 26709 RVA: 0x00194080 File Offset: 0x00192280
		static DiagServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CiRiZ3MvbG93L3BiL2NsaWVudC9kaWFnX3NlcnZpY2UucHJvdG8SFGJncy5w", "cm90b2NvbC5kaWFnLnYxGiFiZ3MvbG93L3BiL2NsaWVudC9ycGNfdHlwZXMu", "cHJvdG8iHQoNR2V0VmFyUmVxdWVzdBIMCgRuYW1lGAEgAigJIh8KDkdldFZh", "clJlc3BvbnNlEg0KBXZhbHVlGAEgAigJIiwKDVNldFZhclJlcXVlc3QSDAoE", "bmFtZRgBIAIoCRINCgV2YWx1ZRgCIAIoCSIqCgxRdWVyeVJlcXVlc3QSDAoE", "bmFtZRgBIAIoCRIMCgRhcmdzGAIgAygJIhUKA1JvdxIOCgZ2YWx1ZXMYASAD", "KAkiVwoNUXVlcnlSZXNwb25zZRIMCgRuYW1lGAEgAigJEg8KB2NvbHVtbnMY", "AiADKAkSJwoEcm93cxgDIAMoCzIZLmJncy5wcm90b2NvbC5kaWFnLnYxLlJv", "dzK9AgoLRGlhZ1NlcnZpY2USWwoGR2V0VmFyEiMuYmdzLnByb3RvY29sLmRp", "YWcudjEuR2V0VmFyUmVxdWVzdBokLmJncy5wcm90b2NvbC5kaWFnLnYxLkdl",
				"dFZhclJlc3BvbnNlIgaC+SsCCAESSwoGU2V0VmFyEiMuYmdzLnByb3RvY29s", "LmRpYWcudjEuU2V0VmFyUmVxdWVzdBoULmJncy5wcm90b2NvbC5Ob0RhdGEi", "BoL5KwIIAhJYCgVRdWVyeRIiLmJncy5wcm90b2NvbC5kaWFnLnYxLlF1ZXJ5", "UmVxdWVzdBojLmJncy5wcm90b2NvbC5kaWFnLnYxLlF1ZXJ5UmVzcG9uc2Ui", "BoL5KwIIAxoqgvkrIAoeYm5ldC5wcm90b2NvbC5kaWFnLkRpYWdTZXJ2aWNl", "ivkrAggBQgVIAYABAA=="
			}));
			DiagServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { RpcTypesReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(GetVarRequest), GetVarRequest.Parser, new string[] { "Name" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetVarResponse), GetVarResponse.Parser, new string[] { "Value" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SetVarRequest), SetVarRequest.Parser, new string[] { "Name", "Value" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(QueryRequest), QueryRequest.Parser, new string[] { "Name", "Args" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Row), Row.Parser, new string[] { "Values" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(QueryResponse), QueryResponse.Parser, new string[] { "Name", "Columns", "Rows" }, null, null, null, null)
			}));
		}

		// Token: 0x04002F87 RID: 12167
		private static FileDescriptor descriptor;
	}
}
