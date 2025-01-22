using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V1
{
	// Token: 0x0200059E RID: 1438
	public static class PresenceServiceReflection
	{
		// Token: 0x17002B16 RID: 11030
		// (get) Token: 0x060088FB RID: 35067 RVA: 0x0021406C File Offset: 0x0021226C
		public static FileDescriptor Descriptor
		{
			get
			{
				return PresenceServiceReflection.descriptor;
			}
		}

		// Token: 0x060088FC RID: 35068 RVA: 0x00214084 File Offset: 0x00212284
		static PresenceServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CihiZ3MvbG93L3BiL2NsaWVudC9wcmVzZW5jZV9zZXJ2aWNlLnByb3RvEhhi", "Z3MucHJvdG9jb2wucHJlc2VuY2UudjEaJGJncy9sb3cvcGIvY2xpZW50L2Vu", "dGl0eV90eXBlcy5wcm90bxomYmdzL2xvdy9wYi9jbGllbnQvcHJlc2VuY2Vf", "dHlwZXMucHJvdG8aIWJncy9sb3cvcGIvY2xpZW50L3JwY190eXBlcy5wcm90", "byK8AQoQU3Vic2NyaWJlUmVxdWVzdBIoCghhZ2VudF9pZBgBIAEoCzIWLmJn", "cy5wcm90b2NvbC5FbnRpdHlJZBIpCgllbnRpdHlfaWQYAiACKAsyFi5iZ3Mu", "cHJvdG9jb2wuRW50aXR5SWQSEQoJb2JqZWN0X2lkGAMgAigEEg8KB3Byb2dy", "YW0YBCADKAcSLwoDa2V5GAYgAygLMiIuYmdzLnByb3RvY29sLnByZXNlbmNl", "LnYxLkZpZWxkS2V5IkkKHFN1YnNjcmliZU5vdGlmaWNhdGlvblJlcXVlc3QS", "KQoJZW50aXR5X2lkGAEgAigLMhYuYmdzLnByb3RvY29sLkVudGl0eUlkInwK",
				"ElVuc3Vic2NyaWJlUmVxdWVzdBIoCghhZ2VudF9pZBgBIAEoCzIWLmJncy5w", "cm90b2NvbC5FbnRpdHlJZBIpCgllbnRpdHlfaWQYAiACKAsyFi5iZ3MucHJv", "dG9jb2wuRW50aXR5SWQSEQoJb2JqZWN0X2lkGAMgASgEIsEBCg1VcGRhdGVS", "ZXF1ZXN0EikKCWVudGl0eV9pZBgBIAIoCzIWLmJncy5wcm90b2NvbC5FbnRp", "dHlJZBJBCg9maWVsZF9vcGVyYXRpb24YAiADKAsyKC5iZ3MucHJvdG9jb2wu", "cHJlc2VuY2UudjEuRmllbGRPcGVyYXRpb24SGAoJbm9fY3JlYXRlGAMgASgI", "OgVmYWxzZRIoCghhZ2VudF9pZBgEIAEoCzIWLmJncy5wcm90b2NvbC5FbnRp", "dHlJZCKUAQoMUXVlcnlSZXF1ZXN0EikKCWVudGl0eV9pZBgBIAIoCzIWLmJn", "cy5wcm90b2NvbC5FbnRpdHlJZBIvCgNrZXkYAiADKAsyIi5iZ3MucHJvdG9j", "b2wucHJlc2VuY2UudjEuRmllbGRLZXkSKAoIYWdlbnRfaWQYAyABKAsyFi5i",
				"Z3MucHJvdG9jb2wuRW50aXR5SWQiPwoNUXVlcnlSZXNwb25zZRIuCgVmaWVs", "ZBgCIAMoCzIfLmJncy5wcm90b2NvbC5wcmVzZW5jZS52MS5GaWVsZCJfChBP", "d25lcnNoaXBSZXF1ZXN0EikKCWVudGl0eV9pZBgBIAIoCzIWLmJncy5wcm90", "b2NvbC5FbnRpdHlJZBIgChFyZWxlYXNlX293bmVyc2hpcBgCIAEoCDoFZmFs", "c2UiwQEKFUJhdGNoU3Vic2NyaWJlUmVxdWVzdBIoCghhZ2VudF9pZBgBIAEo", "CzIWLmJncy5wcm90b2NvbC5FbnRpdHlJZBIpCgllbnRpdHlfaWQYAiADKAsy", "Fi5iZ3MucHJvdG9jb2wuRW50aXR5SWQSDwoHcHJvZ3JhbRgDIAMoBxIvCgNr", "ZXkYBCADKAsyIi5iZ3MucHJvdG9jb2wucHJlc2VuY2UudjEuRmllbGRLZXkS", "EQoJb2JqZWN0X2lkGAUgASgEIkwKD1N1YnNjcmliZVJlc3VsdBIpCgllbnRp", "dHlfaWQYASABKAsyFi5iZ3MucHJvdG9jb2wuRW50aXR5SWQSDgoGcmVzdWx0",
				"GAIgASgNIl0KFkJhdGNoU3Vic2NyaWJlUmVzcG9uc2USQwoQc3Vic2NyaWJl", "X2ZhaWxlZBgBIAMoCzIpLmJncy5wcm90b2NvbC5wcmVzZW5jZS52MS5TdWJz", "Y3JpYmVSZXN1bHQigQEKF0JhdGNoVW5zdWJzY3JpYmVSZXF1ZXN0EigKCGFn", "ZW50X2lkGAEgASgLMhYuYmdzLnByb3RvY29sLkVudGl0eUlkEikKCWVudGl0", "eV9pZBgCIAMoCzIWLmJncy5wcm90b2NvbC5FbnRpdHlJZBIRCglvYmplY3Rf", "aWQYAyABKAQy0gYKD1ByZXNlbmNlU2VydmljZRJVCglTdWJzY3JpYmUSKi5i", "Z3MucHJvdG9jb2wucHJlc2VuY2UudjEuU3Vic2NyaWJlUmVxdWVzdBoULmJn", "cy5wcm90b2NvbC5Ob0RhdGEiBoL5KwIIARJZCgtVbnN1YnNjcmliZRIsLmJn", "cy5wcm90b2NvbC5wcmVzZW5jZS52MS5VbnN1YnNjcmliZVJlcXVlc3QaFC5i", "Z3MucHJvdG9jb2wuTm9EYXRhIgaC+SsCCAISTwoGVXBkYXRlEicuYmdzLnBy",
				"b3RvY29sLnByZXNlbmNlLnYxLlVwZGF0ZVJlcXVlc3QaFC5iZ3MucHJvdG9j", "b2wuTm9EYXRhIgaC+SsCCAMSYAoFUXVlcnkSJi5iZ3MucHJvdG9jb2wucHJl", "c2VuY2UudjEuUXVlcnlSZXF1ZXN0GicuYmdzLnByb3RvY29sLnByZXNlbmNl", "LnYxLlF1ZXJ5UmVzcG9uc2UiBoL5KwIIBBJVCglPd25lcnNoaXASKi5iZ3Mu", "cHJvdG9jb2wucHJlc2VuY2UudjEuT3duZXJzaGlwUmVxdWVzdBoULmJncy5w", "cm90b2NvbC5Ob0RhdGEiBoL5KwIIBRJtChVTdWJzY3JpYmVOb3RpZmljYXRp", "b24SNi5iZ3MucHJvdG9jb2wucHJlc2VuY2UudjEuU3Vic2NyaWJlTm90aWZp", "Y2F0aW9uUmVxdWVzdBoULmJncy5wcm90b2NvbC5Ob0RhdGEiBoL5KwIIBxJ7", "Cg5CYXRjaFN1YnNjcmliZRIvLmJncy5wcm90b2NvbC5wcmVzZW5jZS52MS5C", "YXRjaFN1YnNjcmliZVJlcXVlc3QaMC5iZ3MucHJvdG9jb2wucHJlc2VuY2Uu",
				"djEuQmF0Y2hTdWJzY3JpYmVSZXNwb25zZSIGgvkrAggIEmMKEEJhdGNoVW5z", "dWJzY3JpYmUSMS5iZ3MucHJvdG9jb2wucHJlc2VuY2UudjEuQmF0Y2hVbnN1", "YnNjcmliZVJlcXVlc3QaFC5iZ3MucHJvdG9jb2wuTm9EYXRhIgaC+SsCCAka", "MoL5KygKJmJuZXQucHJvdG9jb2wucHJlc2VuY2UuUHJlc2VuY2VTZXJ2aWNl", "ivkrAhABQgVIAYABAA=="
			}));
			PresenceServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				EntityTypesReflection.Descriptor,
				PresenceTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(SubscribeRequest), SubscribeRequest.Parser, new string[] { "AgentId", "EntityId", "ObjectId", "Program", "Key" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SubscribeNotificationRequest), SubscribeNotificationRequest.Parser, new string[] { "EntityId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UnsubscribeRequest), UnsubscribeRequest.Parser, new string[] { "AgentId", "EntityId", "ObjectId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UpdateRequest), UpdateRequest.Parser, new string[] { "EntityId", "FieldOperation", "NoCreate", "AgentId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(QueryRequest), QueryRequest.Parser, new string[] { "EntityId", "Key", "AgentId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(QueryResponse), QueryResponse.Parser, new string[] { "Field" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(OwnershipRequest), OwnershipRequest.Parser, new string[] { "EntityId", "ReleaseOwnership" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(BatchSubscribeRequest), BatchSubscribeRequest.Parser, new string[] { "AgentId", "EntityId", "Program", "Key", "ObjectId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SubscribeResult), SubscribeResult.Parser, new string[] { "EntityId", "Result" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(BatchSubscribeResponse), BatchSubscribeResponse.Parser, new string[] { "SubscribeFailed" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(BatchUnsubscribeRequest), BatchUnsubscribeRequest.Parser, new string[] { "AgentId", "EntityId", "ObjectId" }, null, null, null, null)
			}));
		}

		// Token: 0x04003DFF RID: 15871
		private static FileDescriptor descriptor;
	}
}
