using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Leaderboard.V1.Client
{
	// Token: 0x02000642 RID: 1602
	public static class LeaderboardServiceReflection
	{
		// Token: 0x17002E78 RID: 11896
		// (get) Token: 0x0600950D RID: 38157 RVA: 0x00240C70 File Offset: 0x0023EE70
		public static FileDescriptor Descriptor
		{
			get
			{
				return LeaderboardServiceReflection.descriptor;
			}
		}

		// Token: 0x0600950E RID: 38158 RVA: 0x00240C88 File Offset: 0x0023EE88
		static LeaderboardServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjliZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YxL2xlYWRlcmJvYXJk", "X3NlcnZpY2UucHJvdG8SImJncy5wcm90b2NvbC5sZWFkZXJib2FyZC52MS5j", "bGllbnQaN2Jncy9sb3cvcGIvY2xpZW50L2FwaS9jbGllbnQvdjEvbGVhZGVy", "Ym9hcmRfdHlwZXMucHJvdG8aIWJncy9sb3cvcGIvY2xpZW50L3JwY190eXBl", "cy5wcm90byJSCg9HZXRSYW5rc1JlcXVlc3QSFgoObGVhZGVyYm9hcmRfaWQY", "ASABKAkSFAoMY29udGludWF0aW9uGAIgASgEEhEKBWNvdW50GAMgASgNOgIx", "MCJ2ChBHZXRSYW5rc1Jlc3BvbnNlEhMKC3RvdGFsX2NvdW50GAEgASgEEhQK", "DGNvbnRpbnVhdGlvbhgCIAEoBBI3CgVyYW5rcxgDIAMoCzIoLmJncy5wcm90", "b2NvbC5sZWFkZXJib2FyZC52MS5jbGllbnQuUmFuayJKChlHZXRSYW5rc0J5", "UG9zaXRpb25SZXF1ZXN0EhYKDmxlYWRlcmJvYXJkX2lkGAEgASgJEhUKCXBv",
				"c2l0aW9ucxgCIAMoBEICEAEiVQoaR2V0UmFua3NCeVBvc2l0aW9uUmVzcG9u", "c2USNwoFcmFua3MYASADKAsyKC5iZ3MucHJvdG9jb2wubGVhZGVyYm9hcmQu", "djEuY2xpZW50LlJhbmsiZgoeR2V0UmFua3NCeVBvc2l0aW9uUmFuZ2VSZXF1", "ZXN0EhYKDmxlYWRlcmJvYXJkX2lkGAEgASgJEhYKDnN0YXJ0X3Bvc2l0aW9u", "GAIgASgEEhQKDGVuZF9wb3NpdGlvbhgDIAEoBCJvCh9HZXRSYW5rc0J5UG9z", "aXRpb25SYW5nZVJlc3BvbnNlEhMKC3RvdGFsX2NvdW50GAEgASgEEjcKBXJh", "bmtzGAIgAygLMiguYmdzLnByb3RvY29sLmxlYWRlcmJvYXJkLnYxLmNsaWVu", "dC5SYW5rInMKHEdldFJhbmtzQnlFbnRpdHlSYW5nZVJlcXVlc3QSFgoObGVh", "ZGVyYm9hcmRfaWQYASABKAkSEQoJZW50aXR5X2lkGAIgASgJEhMKC3Jhbmtz", "X2Fib3ZlGAMgASgNEhMKC3JhbmtzX2JlbG93GAQgASgNIlgKHUdldFJhbmtz",
				"QnlFbnRpdHlSYW5nZVJlc3BvbnNlEjcKBXJhbmtzGAEgAygLMiguYmdzLnBy", "b3RvY29sLmxlYWRlcmJvYXJkLnYxLmNsaWVudC5SYW5rIkgKGkdldFJhbmtz", "QnlFbnRpdHlJZHNSZXF1ZXN0EhYKDmxlYWRlcmJvYXJkX2lkGAEgASgJEhIK", "CmVudGl0eV9pZHMYAiADKAkiVgobR2V0UmFua3NCeUVudGl0eUlkc1Jlc3Bv", "bnNlEjcKBXJhbmtzGAEgAygLMiguYmdzLnByb3RvY29sLmxlYWRlcmJvYXJk", "LnYxLmNsaWVudC5SYW5rIlgKF0dldFJhbmtzQnlDbHViSWRSZXF1ZXN0EhYK", "DmxlYWRlcmJvYXJkX2lkGAEgASgJEg8KB2NsdWJfaWQYAiABKAQSFAoMY29u", "dGludWF0aW9uGAMgASgEImkKGEdldFJhbmtzQnlDbHViSWRSZXNwb25zZRI3", "CgVyYW5rcxgBIAMoCzIoLmJncy5wcm90b2NvbC5sZWFkZXJib2FyZC52MS5j", "bGllbnQuUmFuaxIUCgxjb250aW51YXRpb24YAiABKAQygggKEkxlYWRlcmJv",
				"YXJkU2VydmljZRJ9CghHZXRSYW5rcxIzLmJncy5wcm90b2NvbC5sZWFkZXJi", "b2FyZC52MS5jbGllbnQuR2V0UmFua3NSZXF1ZXN0GjQuYmdzLnByb3RvY29s", "LmxlYWRlcmJvYXJkLnYxLmNsaWVudC5HZXRSYW5rc1Jlc3BvbnNlIgaC+SsC", "CAsSmwEKEkdldFJhbmtzQnlQb3NpdGlvbhI9LmJncy5wcm90b2NvbC5sZWFk", "ZXJib2FyZC52MS5jbGllbnQuR2V0UmFua3NCeVBvc2l0aW9uUmVxdWVzdBo+", "LmJncy5wcm90b2NvbC5sZWFkZXJib2FyZC52MS5jbGllbnQuR2V0UmFua3NC", "eVBvc2l0aW9uUmVzcG9uc2UiBoL5KwIIDBKqAQoXR2V0UmFua3NCeVBvc2l0", "aW9uUmFuZ2USQi5iZ3MucHJvdG9jb2wubGVhZGVyYm9hcmQudjEuY2xpZW50", "LkdldFJhbmtzQnlQb3NpdGlvblJhbmdlUmVxdWVzdBpDLmJncy5wcm90b2Nv", "bC5sZWFkZXJib2FyZC52MS5jbGllbnQuR2V0UmFua3NCeVBvc2l0aW9uUmFu",
				"Z2VSZXNwb25zZSIGgvkrAggNEqQBChVHZXRSYW5rc0J5RW50aXR5UmFuZ2US", "QC5iZ3MucHJvdG9jb2wubGVhZGVyYm9hcmQudjEuY2xpZW50LkdldFJhbmtz", "QnlFbnRpdHlSYW5nZVJlcXVlc3QaQS5iZ3MucHJvdG9jb2wubGVhZGVyYm9h", "cmQudjEuY2xpZW50LkdldFJhbmtzQnlFbnRpdHlSYW5nZVJlc3BvbnNlIgaC", "+SsCCA4SngEKE0dldFJhbmtzQnlFbnRpdHlJZHMSPi5iZ3MucHJvdG9jb2wu", "bGVhZGVyYm9hcmQudjEuY2xpZW50LkdldFJhbmtzQnlFbnRpdHlJZHNSZXF1", "ZXN0Gj8uYmdzLnByb3RvY29sLmxlYWRlcmJvYXJkLnYxLmNsaWVudC5HZXRS", "YW5rc0J5RW50aXR5SWRzUmVzcG9uc2UiBoL5KwIIDxKVAQoQR2V0UmFua3NC", "eUNsdWJJZBI7LmJncy5wcm90b2NvbC5sZWFkZXJib2FyZC52MS5jbGllbnQu", "R2V0UmFua3NCeUNsdWJJZFJlcXVlc3QaPC5iZ3MucHJvdG9jb2wubGVhZGVy",
				"Ym9hcmQudjEuY2xpZW50LkdldFJhbmtzQnlDbHViSWRSZXNwb25zZSIGgvkr", "AggQGkKC+Ss4CjZibmV0LnByb3RvY29sLmxlYWRlcmJvYXJkLnYxLmNsaWVu", "dC5MZWFkZXJib2FyZFNlcnZpY2WK+SsCEAFCA4ABAA=="
			}));
			LeaderboardServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				LeaderboardTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(GetRanksRequest), GetRanksRequest.Parser, new string[] { "LeaderboardId", "Continuation", "Count" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetRanksResponse), GetRanksResponse.Parser, new string[] { "TotalCount", "Continuation", "Ranks" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetRanksByPositionRequest), GetRanksByPositionRequest.Parser, new string[] { "LeaderboardId", "Positions" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetRanksByPositionResponse), GetRanksByPositionResponse.Parser, new string[] { "Ranks" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetRanksByPositionRangeRequest), GetRanksByPositionRangeRequest.Parser, new string[] { "LeaderboardId", "StartPosition", "EndPosition" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetRanksByPositionRangeResponse), GetRanksByPositionRangeResponse.Parser, new string[] { "TotalCount", "Ranks" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetRanksByEntityRangeRequest), GetRanksByEntityRangeRequest.Parser, new string[] { "LeaderboardId", "EntityId", "RanksAbove", "RanksBelow" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetRanksByEntityRangeResponse), GetRanksByEntityRangeResponse.Parser, new string[] { "Ranks" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetRanksByEntityIdsRequest), GetRanksByEntityIdsRequest.Parser, new string[] { "LeaderboardId", "EntityIds" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetRanksByEntityIdsResponse), GetRanksByEntityIdsResponse.Parser, new string[] { "Ranks" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetRanksByClubIdRequest), GetRanksByClubIdRequest.Parser, new string[] { "LeaderboardId", "ClubId", "Continuation" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetRanksByClubIdResponse), GetRanksByClubIdResponse.Parser, new string[] { "Ranks", "Continuation" }, null, null, null, null)
			}));
		}

		// Token: 0x04004323 RID: 17187
		private static FileDescriptor descriptor;
	}
}
