using System;
using Bgs.Protocol.Account.V1;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Report.V1
{
	// Token: 0x02000573 RID: 1395
	public static class ReportServiceReflection
	{
		// Token: 0x17002A58 RID: 10840
		// (get) Token: 0x0600864C RID: 34380 RVA: 0x00209C5C File Offset: 0x00207E5C
		public static FileDescriptor Descriptor
		{
			get
			{
				return ReportServiceReflection.descriptor;
			}
		}

		// Token: 0x0600864D RID: 34381 RVA: 0x00209C74 File Offset: 0x00207E74
		static ReportServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CiZiZ3MvbG93L3BiL2NsaWVudC9yZXBvcnRfc2VydmljZS5wcm90bxIWYmdz", "LnByb3RvY29sLnJlcG9ydC52MRolYmdzL2xvdy9wYi9jbGllbnQvYWNjb3Vu", "dF90eXBlcy5wcm90bxokYmdzL2xvdy9wYi9jbGllbnQvcmVwb3J0X3R5cGVz", "LnByb3RvGiFiZ3MvbG93L3BiL2NsaWVudC9ycGNfdHlwZXMucHJvdG8iVAoR", "U2VuZFJlcG9ydFJlcXVlc3QSLgoGcmVwb3J0GAEgAigLMh4uYmdzLnByb3Rv", "Y29sLnJlcG9ydC52MS5SZXBvcnQSDwoHcHJvZ3JhbRgCIAEoDSKdAQoTU3Vi", "bWl0UmVwb3J0UmVxdWVzdBI8CghhZ2VudF9pZBgBIAEoCzIqLmJncy5wcm90", "b2NvbC5hY2NvdW50LnYxLkdhbWVBY2NvdW50SGFuZGxlEjcKC3JlcG9ydF90", "eXBlGAIgASgLMiIuYmdzLnByb3RvY29sLnJlcG9ydC52MS5SZXBvcnRUeXBl", "Eg8KB3Byb2dyYW0YAyABKA0y8QEKDVJlcG9ydFNlcnZpY2USVQoKU2VuZFJl",
				"cG9ydBIpLmJncy5wcm90b2NvbC5yZXBvcnQudjEuU2VuZFJlcG9ydFJlcXVl", "c3QaFC5iZ3MucHJvdG9jb2wuTm9EYXRhIgaC+SsCCAESWQoMU3VibWl0UmVw", "b3J0EisuYmdzLnByb3RvY29sLnJlcG9ydC52MS5TdWJtaXRSZXBvcnRSZXF1", "ZXN0GhQuYmdzLnByb3RvY29sLk5vRGF0YSIGgvkrAggCGi6C+SskCiJibmV0", "LnByb3RvY29sLnJlcG9ydC5SZXBvcnRTZXJ2aWNlivkrAhABQgVIAYABAA=="
			}));
			ReportServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				AccountTypesReflection.Descriptor,
				ReportTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(SendReportRequest), SendReportRequest.Parser, new string[] { "Report", "Program" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SubmitReportRequest), SubmitReportRequest.Parser, new string[] { "AgentId", "ReportType", "Program" }, null, null, null, null)
			}));
		}

		// Token: 0x04003CE1 RID: 15585
		private static FileDescriptor descriptor;
	}
}
