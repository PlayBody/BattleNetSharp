using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Resources.V1
{
	// Token: 0x020003D9 RID: 985
	public static class ResourceServiceReflection
	{
		// Token: 0x17001FC1 RID: 8129
		// (get) Token: 0x0600627D RID: 25213 RVA: 0x0017D348 File Offset: 0x0017B548
		public static FileDescriptor Descriptor
		{
			get
			{
				return ResourceServiceReflection.descriptor;
			}
		}

		// Token: 0x0600627E RID: 25214 RVA: 0x0017D360 File Offset: 0x0017B560
		static ResourceServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CihiZ3MvbG93L3BiL2NsaWVudC9yZXNvdXJjZV9zZXJ2aWNlLnByb3RvEhli", "Z3MucHJvdG9jb2wucmVzb3VyY2VzLnYxGixiZ3MvbG93L3BiL2NsaWVudC9j", "b250ZW50X2hhbmRsZV90eXBlcy5wcm90bxohYmdzL2xvdy9wYi9jbGllbnQv", "cnBjX3R5cGVzLnByb3RvIlQKFENvbnRlbnRIYW5kbGVSZXF1ZXN0Eg8KB3By", "b2dyYW0YASACKAcSDgoGc3RyZWFtGAIgAigHEhsKB3ZlcnNpb24YAyABKAc6", "CjE3MDE3Mjk2MTkiTQoUR2V0VGl0bGVJY29uc1JlcXVlc3QSFQoJdGl0bGVf", "aWRzGAEgAygNQgIQARINCgV1c2FnZRgCIAEoDRIPCgd2ZXJzaW9uGAMgASgN", "ImEKFUdldFRpdGxlSWNvbnNSZXNwb25zZRJIChp0aXRsZV9pY29uX2NvbnRl", "bnRfaGFuZGxlcxgBIAMoCzIkLmJncy5wcm90b2NvbC5UaXRsZUljb25Db250", "ZW50SGFuZGxlMqkCChBSZXNvdXJjZXNTZXJ2aWNlEmgKEEdldENvbnRlbnRI",
				"YW5kbGUSLy5iZ3MucHJvdG9jb2wucmVzb3VyY2VzLnYxLkNvbnRlbnRIYW5k", "bGVSZXF1ZXN0GhsuYmdzLnByb3RvY29sLkNvbnRlbnRIYW5kbGUiBoL5KwII", "ARJ6Cg1HZXRUaXRsZUljb25zEi8uYmdzLnByb3RvY29sLnJlc291cmNlcy52", "MS5HZXRUaXRsZUljb25zUmVxdWVzdBowLmJncy5wcm90b2NvbC5yZXNvdXJj", "ZXMudjEuR2V0VGl0bGVJY29uc1Jlc3BvbnNlIgaC+SsCCAIaL4L5KyUKIWJu", "ZXQucHJvdG9jb2wucmVzb3VyY2VzLlJlc291cmNlcxgBivkrAhABQgVIAYAB", "AA=="
			}));
			ResourceServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				ContentHandleTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ContentHandleRequest), ContentHandleRequest.Parser, new string[] { "Program", "Stream", "Version" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetTitleIconsRequest), GetTitleIconsRequest.Parser, new string[] { "TitleIds", "Usage", "Version" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetTitleIconsResponse), GetTitleIconsResponse.Parser, new string[] { "TitleIconContentHandles" }, null, null, null, null)
			}));
		}

		// Token: 0x04002D00 RID: 11520
		private static FileDescriptor descriptor;
	}
}
