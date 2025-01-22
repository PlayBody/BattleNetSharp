using System;
using Bgs.Protocol.Account.V1;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Report.V2
{
	// Token: 0x02000581 RID: 1409
	public static class ReportServiceReflection
	{
		// Token: 0x17002AA9 RID: 10921
		// (get) Token: 0x06008769 RID: 34665 RVA: 0x0020E3A8 File Offset: 0x0020C5A8
		public static FileDescriptor Descriptor
		{
			get
			{
				return ReportServiceReflection.descriptor;
			}
		}

		// Token: 0x0600876A RID: 34666 RVA: 0x0020E3C0 File Offset: 0x0020C5C0
		static ReportServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjRiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL3JlcG9ydF9zZXJ2", "aWNlLnByb3RvEhZiZ3MucHJvdG9jb2wucmVwb3J0LnYyGiViZ3MvbG93L3Bi", "L2NsaWVudC9hY2NvdW50X3R5cGVzLnByb3RvGjJiZ3MvbG93L3BiL2NsaWVu", "dC9hcGkvY2xpZW50L3YyL3JlcG9ydF90eXBlcy5wcm90bxohYmdzL2xvdy9w", "Yi9jbGllbnQvcnBjX3R5cGVzLnByb3RvIqgCChNTdWJtaXRSZXBvcnRSZXF1", "ZXN0EjQKCGFnZW50X2lkGAEgASgLMiIuYmdzLnByb3RvY29sLmFjY291bnQu", "djEuQWNjb3VudElkEhgKEHVzZXJfZGVzY3JpcHRpb24YAiABKAkSOwoMdXNl", "cl9vcHRpb25zGAogASgLMiMuYmdzLnByb3RvY29sLnJlcG9ydC52Mi5Vc2Vy", "T3B0aW9uc0gAEjsKDGNsdWJfb3B0aW9ucxgLIAEoCzIjLmJncy5wcm90b2Nv", "bC5yZXBvcnQudjIuQ2x1Yk9wdGlvbnNIABI/Cg5lbnRpdHlfb3B0aW9ucxgU",
				"IAEoCzIlLmJncy5wcm90b2NvbC5yZXBvcnQudjIuRW50aXR5T3B0aW9uc0gA", "QgYKBHR5cGUyYgoNUmVwb3J0U2VydmljZRJRCgxTdWJtaXRSZXBvcnQSKy5i", "Z3MucHJvdG9jb2wucmVwb3J0LnYyLlN1Ym1pdFJlcG9ydFJlcXVlc3QaFC5i", "Z3MucHJvdG9jb2wuTm9EYXRhQgOAAQA="
			}));
			ReportServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				AccountTypesReflection.Descriptor,
				ReportTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(SubmitReportRequest), SubmitReportRequest.Parser, new string[] { "AgentId", "UserDescription", "UserOptions", "ClubOptions", "EntityOptions" }, new string[] { "Type" }, null, null, null)
			}));
		}

		// Token: 0x04003D4C RID: 15692
		private static FileDescriptor descriptor;
	}
}
