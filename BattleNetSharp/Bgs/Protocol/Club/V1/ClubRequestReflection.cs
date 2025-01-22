using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200049A RID: 1178
	public static class ClubRequestReflection
	{
		// Token: 0x170024A0 RID: 9376
		// (get) Token: 0x060072C8 RID: 29384 RVA: 0x001BF110 File Offset: 0x001BD310
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.descriptor;
			}
		}

		// Token: 0x060072C9 RID: 29385 RVA: 0x001BF128 File Offset: 0x001BD328
		static ClubRequestReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CiRiZ3MvbG93L3BiL2NsaWVudC9jbHViX3JlcXVlc3QucHJvdG8SFGJncy5w", "cm90b2NvbC5jbHViLnYxGiJiZ3MvbG93L3BiL2NsaWVudC9jbHViX3R5cGVz", "LnByb3RvGiBiZ3MvbG93L3BiL2NsaWVudC9jbHViX3RhZy5wcm90bxohYmdz", "L2xvdy9wYi9jbGllbnQvcnBjX3R5cGVzLnByb3RvIlUKEFN1YnNjcmliZVJl", "cXVlc3QSMAoIYWdlbnRfaWQYASABKAsyHi5iZ3MucHJvdG9jb2wuY2x1Yi52", "MS5NZW1iZXJJZBIPCgdjbHViX2lkGAIgASgEIlcKElVuc3Vic2NyaWJlUmVx", "dWVzdBIwCghhZ2VudF9pZBgBIAEoCzIeLmJncy5wcm90b2NvbC5jbHViLnYx", "Lk1lbWJlcklkEg8KB2NsdWJfaWQYAiABKAQiewoNQ3JlYXRlUmVxdWVzdBIw", "CghhZ2VudF9pZBgBIAEoCzIeLmJncy5wcm90b2NvbC5jbHViLnYxLk1lbWJl", "cklkEjgKB29wdGlvbnMYAiABKAsyJy5iZ3MucHJvdG9jb2wuY2x1Yi52MS5D",
				"bHViQ3JlYXRlT3B0aW9ucyIhCg5DcmVhdGVSZXNwb25zZRIPCgdjbHViX2lk", "GAEgASgEIlMKDkRlc3Ryb3lSZXF1ZXN0EjAKCGFnZW50X2lkGAEgASgLMh4u", "YmdzLnByb3RvY29sLmNsdWIudjEuTWVtYmVySWQSDwoHY2x1Yl9pZBgCIAEo", "BCJaChVHZXREZXNjcmlwdGlvblJlcXVlc3QSMAoIYWdlbnRfaWQYASABKAsy", "Hi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5NZW1iZXJJZBIPCgdjbHViX2lkGAIg", "ASgEIk0KFkdldERlc2NyaXB0aW9uUmVzcG9uc2USMwoEY2x1YhgBIAEoCzIl", "LmJncy5wcm90b2NvbC5jbHViLnYxLkNsdWJEZXNjcmlwdGlvbiJ6ChJHZXRD", "bHViVHlwZVJlcXVlc3QSMAoIYWdlbnRfaWQYASABKAsyHi5iZ3MucHJvdG9j", "b2wuY2x1Yi52MS5NZW1iZXJJZBIyCgR0eXBlGAIgASgLMiQuYmdzLnByb3Rv", "Y29sLmNsdWIudjEuVW5pcXVlQ2x1YlR5cGUiswIKE0dldENsdWJUeXBlUmVz",
				"cG9uc2USMgoEdHlwZRgBIAEoCzIkLmJncy5wcm90b2NvbC5jbHViLnYxLlVu", "aXF1ZUNsdWJUeXBlEjMKCHJvbGVfc2V0GAIgASgLMiEuYmdzLnByb3RvY29s", "LmNsdWIudjEuQ2x1YlJvbGVTZXQSOQoJcmFuZ2Vfc2V0GAMgASgLMiYuYmdz", "LnByb3RvY29sLmNsdWIudjEuQ2x1YlR5cGVSYW5nZVNldBI8ChBwbGF0Zm9y", "bV90YWdfc2V0GAQgAygLMiIuYmdzLnByb3RvY29sLmNsdWIudjEuTG9jYWxp", "emVkVGFnEjoKDmN1c3RvbV90YWdfc2V0GAUgAygLMiIuYmdzLnByb3RvY29s", "LmNsdWIudjEuTG9jYWxpemVkVGFnIpQBChZVcGRhdGVDbHViU3RhdGVSZXF1", "ZXN0EjAKCGFnZW50X2lkGAEgASgLMh4uYmdzLnByb3RvY29sLmNsdWIudjEu", "TWVtYmVySWQSDwoHY2x1Yl9pZBgCIAEoBBI3CgdvcHRpb25zGAMgASgLMiYu", "YmdzLnByb3RvY29sLmNsdWIudjEuQ2x1YlN0YXRlT3B0aW9ucyKaAQoZVXBk",
				"YXRlQ2x1YlNldHRpbmdzUmVxdWVzdBIwCghhZ2VudF9pZBgBIAEoCzIeLmJn", "cy5wcm90b2NvbC5jbHViLnYxLk1lbWJlcklkEg8KB2NsdWJfaWQYAiABKAQS", "OgoHb3B0aW9ucxgDIAEoCzIpLmJncy5wcm90b2NvbC5jbHViLnYxLkNsdWJT", "ZXR0aW5nc09wdGlvbnMikQEKEEFkZE1lbWJlclJlcXVlc3QSMAoIYWdlbnRf", "aWQYASABKAsyHi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5NZW1iZXJJZBIPCgdj", "bHViX2lkGAIgASgEEjoKB29wdGlvbnMYAyABKAsyKS5iZ3MucHJvdG9jb2wu", "Y2x1Yi52MS5DcmVhdGVNZW1iZXJPcHRpb25zIowBCgtKb2luUmVxdWVzdBIw", "CghhZ2VudF9pZBgBIAEoCzIeLmJncy5wcm90b2NvbC5jbHViLnYxLk1lbWJl", "cklkEg8KB2NsdWJfaWQYAiABKAQSOgoHb3B0aW9ucxgDIAEoCzIpLmJncy5w", "cm90b2NvbC5jbHViLnYxLkNyZWF0ZU1lbWJlck9wdGlvbnMiUQoMTGVhdmVS",
				"ZXF1ZXN0EjAKCGFnZW50X2lkGAEgASgLMh4uYmdzLnByb3RvY29sLmNsdWIu", "djEuTWVtYmVySWQSDwoHY2x1Yl9pZBgCIAEoBCKDAQoLS2lja1JlcXVlc3QS", "MAoIYWdlbnRfaWQYASABKAsyHi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5NZW1i", "ZXJJZBIPCgdjbHViX2lkGAIgASgEEjEKCXRhcmdldF9pZBgDIAEoCzIeLmJn", "cy5wcm90b2NvbC5jbHViLnYxLk1lbWJlcklkIogBChBHZXRNZW1iZXJSZXF1", "ZXN0EjAKCGFnZW50X2lkGAEgASgLMh4uYmdzLnByb3RvY29sLmNsdWIudjEu", "TWVtYmVySWQSDwoHY2x1Yl9pZBgCIAEoBBIxCgltZW1iZXJfaWQYAyABKAsy", "Hi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5NZW1iZXJJZCJBChFHZXRNZW1iZXJS", "ZXNwb25zZRIsCgZtZW1iZXIYASABKAsyHC5iZ3MucHJvdG9jb2wuY2x1Yi52", "MS5NZW1iZXIibAoRR2V0TWVtYmVyc1JlcXVlc3QSMAoIYWdlbnRfaWQYASAB",
				"KAsyHi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5NZW1iZXJJZBIPCgdjbHViX2lk", "GAIgASgEEhQKDGNvbnRpbnVhdGlvbhgEIAEoBCJYChJHZXRNZW1iZXJzUmVz", "cG9uc2USLAoGbWVtYmVyGAEgAygLMhwuYmdzLnByb3RvY29sLmNsdWIudjEu", "TWVtYmVyEhQKDGNvbnRpbnVhdGlvbhgCIAEoBCLLAQoYVXBkYXRlTWVtYmVy", "U3RhdGVSZXF1ZXN0EjAKCGFnZW50X2lkGAEgASgLMh4uYmdzLnByb3RvY29s", "LmNsdWIudjEuTWVtYmVySWQSDwoHY2x1Yl9pZBgCIAEoBBIxCgltZW1iZXJf", "aWQYAyABKAsyHi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5NZW1iZXJJZBI5Cgdv", "cHRpb25zGAUgASgLMiguYmdzLnByb3RvY29sLmNsdWIudjEuTWVtYmVyU3Rh", "dGVPcHRpb25zIqABChxVcGRhdGVTdWJzY3JpYmVyU3RhdGVSZXF1ZXN0EjAK", "CGFnZW50X2lkGAEgASgLMh4uYmdzLnByb3RvY29sLmNsdWIudjEuTWVtYmVy",
				"SWQSDwoHY2x1Yl9pZBgCIAEoBBI9CgdvcHRpb25zGAMgASgLMiwuYmdzLnBy", "b3RvY29sLmNsdWIudjEuU3Vic2NyaWJlclN0YXRlT3B0aW9ucyKKAQoRQXNz", "aWduUm9sZVJlcXVlc3QSMAoIYWdlbnRfaWQYASABKAsyHi5iZ3MucHJvdG9j", "b2wuY2x1Yi52MS5NZW1iZXJJZBIPCgdjbHViX2lkGAIgASgEEjIKB29wdGlv", "bnMYAyABKAsyIS5iZ3MucHJvdG9jb2wuY2x1Yi52MS5Sb2xlT3B0aW9ucyKM", "AQoTVW5hc3NpZ25Sb2xlUmVxdWVzdBIwCghhZ2VudF9pZBgBIAEoCzIeLmJn", "cy5wcm90b2NvbC5jbHViLnYxLk1lbWJlcklkEg8KB2NsdWJfaWQYAiABKAQS", "MgoHb3B0aW9ucxgDIAEoCzIhLmJncy5wcm90b2NvbC5jbHViLnYxLlJvbGVP", "cHRpb25zIpgBChVTZW5kSW52aXRhdGlvblJlcXVlc3QSMAoIYWdlbnRfaWQY", "ASABKAsyHi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5NZW1iZXJJZBIPCgdjbHVi",
				"X2lkGAIgASgEEjwKB29wdGlvbnMYAyABKAsyKy5iZ3MucHJvdG9jb2wuY2x1", "Yi52MS5TZW5kSW52aXRhdGlvbk9wdGlvbnMicwoXQWNjZXB0SW52aXRhdGlv", "blJlcXVlc3QSMAoIYWdlbnRfaWQYASABKAsyHi5iZ3MucHJvdG9jb2wuY2x1", "Yi52MS5NZW1iZXJJZBIPCgdjbHViX2lkGAIgASgEEhUKDWludml0YXRpb25f", "aWQYAyABKAYidAoYRGVjbGluZUludml0YXRpb25SZXF1ZXN0EjAKCGFnZW50", "X2lkGAEgASgLMh4uYmdzLnByb3RvY29sLmNsdWIudjEuTWVtYmVySWQSDwoH", "Y2x1Yl9pZBgCIAEoBBIVCg1pbnZpdGF0aW9uX2lkGAMgASgGInMKF1Jldm9r", "ZUludml0YXRpb25SZXF1ZXN0EjAKCGFnZW50X2lkGAEgASgLMh4uYmdzLnBy", "b3RvY29sLmNsdWIudjEuTWVtYmVySWQSDwoHY2x1Yl9pZBgCIAEoBBIVCg1p", "bnZpdGF0aW9uX2lkGAMgASgGInAKFEdldEludml0YXRpb25SZXF1ZXN0EjAK",
				"CGFnZW50X2lkGAEgASgLMh4uYmdzLnByb3RvY29sLmNsdWIudjEuTWVtYmVy", "SWQSDwoHY2x1Yl9pZBgCIAEoBBIVCg1pbnZpdGF0aW9uX2lkGAMgASgGIlEK", "FUdldEludml0YXRpb25SZXNwb25zZRI4CgppbnZpdGF0aW9uGAEgASgLMiQu", "YmdzLnByb3RvY29sLmNsdWIudjEuQ2x1Ykludml0YXRpb24icAoVR2V0SW52", "aXRhdGlvbnNSZXF1ZXN0EjAKCGFnZW50X2lkGAEgASgLMh4uYmdzLnByb3Rv", "Y29sLmNsdWIudjEuTWVtYmVySWQSDwoHY2x1Yl9pZBgCIAEoBBIUCgxjb250", "aW51YXRpb24YAyABKAQiaAoWR2V0SW52aXRhdGlvbnNSZXNwb25zZRI4Cgpp", "bnZpdGF0aW9uGAEgAygLMiQuYmdzLnByb3RvY29sLmNsdWIudjEuQ2x1Yklu", "dml0YXRpb24SFAoMY29udGludWF0aW9uGAIgASgEIpgBChVTZW5kU3VnZ2Vz", "dGlvblJlcXVlc3QSMAoIYWdlbnRfaWQYASABKAsyHi5iZ3MucHJvdG9jb2wu",
				"Y2x1Yi52MS5NZW1iZXJJZBIPCgdjbHViX2lkGAIgASgEEjwKB29wdGlvbnMY", "AyABKAsyKy5iZ3MucHJvdG9jb2wuY2x1Yi52MS5TZW5kU3VnZ2VzdGlvbk9w", "dGlvbnMicwoXQWNjZXB0U3VnZ2VzdGlvblJlcXVlc3QSMAoIYWdlbnRfaWQY", "ASABKAsyHi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5NZW1iZXJJZBIPCgdjbHVi", "X2lkGAIgASgEEhUKDXN1Z2dlc3Rpb25faWQYAyABKAYidAoYRGVjbGluZVN1", "Z2dlc3Rpb25SZXF1ZXN0EjAKCGFnZW50X2lkGAEgASgLMh4uYmdzLnByb3Rv", "Y29sLmNsdWIudjEuTWVtYmVySWQSDwoHY2x1Yl9pZBgCIAEoBBIVCg1zdWdn", "ZXN0aW9uX2lkGAMgASgGInAKFEdldFN1Z2dlc3Rpb25SZXF1ZXN0EjAKCGFn", "ZW50X2lkGAEgASgLMh4uYmdzLnByb3RvY29sLmNsdWIudjEuTWVtYmVySWQS", "DwoHY2x1Yl9pZBgCIAEoBBIVCg1zdWdnZXN0aW9uX2lkGAMgASgGIlEKFUdl",
				"dFN1Z2dlc3Rpb25SZXNwb25zZRI4CgpzdWdnZXN0aW9uGAEgASgLMiQuYmdz", "LnByb3RvY29sLmNsdWIudjEuQ2x1YlN1Z2dlc3Rpb24icAoVR2V0U3VnZ2Vz", "dGlvbnNSZXF1ZXN0EjAKCGFnZW50X2lkGAEgASgLMh4uYmdzLnByb3RvY29s", "LmNsdWIudjEuTWVtYmVySWQSDwoHY2x1Yl9pZBgCIAEoBBIUCgxjb250aW51", "YXRpb24YAyABKAQiaAoWR2V0U3VnZ2VzdGlvbnNSZXNwb25zZRI4CgpzdWdn", "ZXN0aW9uGAEgAygLMiQuYmdzLnByb3RvY29sLmNsdWIudjEuQ2x1YlN1Z2dl", "c3Rpb24SFAoMY29udGludWF0aW9uGAIgASgEIpQBChNDcmVhdGVUaWNrZXRS", "ZXF1ZXN0EjAKCGFnZW50X2lkGAEgASgLMh4uYmdzLnByb3RvY29sLmNsdWIu", "djEuTWVtYmVySWQSDwoHY2x1Yl9pZBgCIAEoBBI6CgdvcHRpb25zGAMgASgL", "MikuYmdzLnByb3RvY29sLmNsdWIudjEuQ3JlYXRlVGlja2V0T3B0aW9ucyJI",
				"ChRDcmVhdGVUaWNrZXRSZXNwb25zZRIwCgZ0aWNrZXQYASABKAsyIC5iZ3Mu", "cHJvdG9jb2wuY2x1Yi52MS5DbHViVGlja2V0ImwKFERlc3Ryb3lUaWNrZXRS", "ZXF1ZXN0EjAKCGFnZW50X2lkGAEgASgLMh4uYmdzLnByb3RvY29sLmNsdWIu", "djEuTWVtYmVySWQSDwoHY2x1Yl9pZBgCIAEoBBIRCgl0aWNrZXRfaWQYAyAB", "KAkiWgoTUmVkZWVtVGlja2V0UmVxdWVzdBIwCghhZ2VudF9pZBgBIAEoCzIe", "LmJncy5wcm90b2NvbC5jbHViLnYxLk1lbWJlcklkEhEKCXRpY2tldF9pZBgD", "IAEoCSJXChBHZXRUaWNrZXRSZXF1ZXN0EjAKCGFnZW50X2lkGAEgASgLMh4u", "YmdzLnByb3RvY29sLmNsdWIudjEuTWVtYmVySWQSEQoJdGlja2V0X2lkGAMg", "ASgJIkUKEUdldFRpY2tldFJlc3BvbnNlEjAKBnRpY2tldBgBIAEoCzIgLmJn", "cy5wcm90b2NvbC5jbHViLnYxLkNsdWJUaWNrZXQibAoRR2V0VGlja2V0c1Jl",
				"cXVlc3QSMAoIYWdlbnRfaWQYASABKAsyHi5iZ3MucHJvdG9jb2wuY2x1Yi52", "MS5NZW1iZXJJZBIPCgdjbHViX2lkGAIgASgEEhQKDGNvbnRpbnVhdGlvbhgD", "IAEoBCJcChJHZXRUaWNrZXRzUmVzcG9uc2USMAoGdGlja2V0GAEgAygLMiAu", "YmdzLnByb3RvY29sLmNsdWIudjEuQ2x1YlRpY2tldBIUCgxjb250aW51YXRp", "b24YAiABKAQiiAEKDUFkZEJhblJlcXVlc3QSMAoIYWdlbnRfaWQYASABKAsy", "Hi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5NZW1iZXJJZBIPCgdjbHViX2lkGAIg", "ASgEEjQKB29wdGlvbnMYAyABKAsyIy5iZ3MucHJvdG9jb2wuY2x1Yi52MS5B", "ZGRCYW5PcHRpb25zIogBChBSZW1vdmVCYW5SZXF1ZXN0EjAKCGFnZW50X2lk", "GAEgASgLMh4uYmdzLnByb3RvY29sLmNsdWIudjEuTWVtYmVySWQSDwoHY2x1", "Yl9pZBgCIAEoBBIxCgl0YXJnZXRfaWQYAyABKAsyHi5iZ3MucHJvdG9jb2wu",
				"Y2x1Yi52MS5NZW1iZXJJZCKFAQoNR2V0QmFuUmVxdWVzdBIwCghhZ2VudF9p", "ZBgBIAEoCzIeLmJncy5wcm90b2NvbC5jbHViLnYxLk1lbWJlcklkEg8KB2Ns", "dWJfaWQYAiABKAQSMQoJdGFyZ2V0X2lkGAMgASgLMh4uYmdzLnByb3RvY29s", "LmNsdWIudjEuTWVtYmVySWQiPAoOR2V0QmFuUmVzcG9uc2USKgoDYmFuGAEg", "ASgLMh0uYmdzLnByb3RvY29sLmNsdWIudjEuQ2x1YkJhbiJpCg5HZXRCYW5z", "UmVxdWVzdBIwCghhZ2VudF9pZBgBIAEoCzIeLmJncy5wcm90b2NvbC5jbHVi", "LnYxLk1lbWJlcklkEg8KB2NsdWJfaWQYAiABKAQSFAoMY29udGludWF0aW9u", "GAMgASgEIlMKD0dldEJhbnNSZXNwb25zZRIqCgNiYW4YASADKAsyHS5iZ3Mu", "cHJvdG9jb2wuY2x1Yi52MS5DbHViQmFuEhQKDGNvbnRpbnVhdGlvbhgCIAEo", "BCJuChZTdWJzY3JpYmVTdHJlYW1SZXF1ZXN0EjAKCGFnZW50X2lkGAEgASgL",
				"Mh4uYmdzLnByb3RvY29sLmNsdWIudjEuTWVtYmVySWQSDwoHY2x1Yl9pZBgC", "IAEoBBIRCglzdHJlYW1faWQYAyADKAQicAoYVW5zdWJzY3JpYmVTdHJlYW1S", "ZXF1ZXN0EjAKCGFnZW50X2lkGAEgASgLMh4uYmdzLnByb3RvY29sLmNsdWIu", "djEuTWVtYmVySWQSDwoHY2x1Yl9pZBgCIAEoBBIRCglzdHJlYW1faWQYAyAD", "KAQilAEKE0NyZWF0ZVN0cmVhbVJlcXVlc3QSMAoIYWdlbnRfaWQYASABKAsy", "Hi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5NZW1iZXJJZBIPCgdjbHViX2lkGAIg", "ASgEEjoKB29wdGlvbnMYAyABKAsyKS5iZ3MucHJvdG9jb2wuY2x1Yi52MS5D", "cmVhdGVTdHJlYW1PcHRpb25zIjoKFENyZWF0ZVN0cmVhbVJlc3BvbnNlEg8K", "B2NsdWJfaWQYASABKAQSEQoJc3RyZWFtX2lkGAIgASgEImwKFERlc3Ryb3lT", "dHJlYW1SZXF1ZXN0EjAKCGFnZW50X2lkGAEgASgLMh4uYmdzLnByb3RvY29s",
				"LmNsdWIudjEuTWVtYmVySWQSDwoHY2x1Yl9pZBgCIAEoBBIRCglzdHJlYW1f", "aWQYAyABKAQiaAoQR2V0U3RyZWFtUmVxdWVzdBIwCghhZ2VudF9pZBgBIAEo", "CzIeLmJncy5wcm90b2NvbC5jbHViLnYxLk1lbWJlcklkEg8KB2NsdWJfaWQY", "AiABKAQSEQoJc3RyZWFtX2lkGAMgASgEIkEKEUdldFN0cmVhbVJlc3BvbnNl", "EiwKBnN0cmVhbRgBIAEoCzIcLmJncy5wcm90b2NvbC5jbHViLnYxLlN0cmVh", "bSJsChFHZXRTdHJlYW1zUmVxdWVzdBIwCghhZ2VudF9pZBgBIAEoCzIeLmJn", "cy5wcm90b2NvbC5jbHViLnYxLk1lbWJlcklkEg8KB2NsdWJfaWQYAiABKAQS", "FAoMY29udGludWF0aW9uGAMgASgEIogBChJHZXRTdHJlYW1zUmVzcG9uc2US", "LAoGc3RyZWFtGAEgAygLMhwuYmdzLnByb3RvY29sLmNsdWIudjEuU3RyZWFt", "Ei4KBHZpZXcYAiADKAsyIC5iZ3MucHJvdG9jb2wuY2x1Yi52MS5TdHJlYW1W",
				"aWV3EhQKDGNvbnRpbnVhdGlvbhgDIAEoBCKrAQoYVXBkYXRlU3RyZWFtU3Rh", "dGVSZXF1ZXN0EjAKCGFnZW50X2lkGAEgASgLMh4uYmdzLnByb3RvY29sLmNs", "dWIudjEuTWVtYmVySWQSDwoHY2x1Yl9pZBgCIAEoBBIRCglzdHJlYW1faWQY", "AyABKAQSOQoHb3B0aW9ucxgFIAEoCzIoLmJncy5wcm90b2NvbC5jbHViLnYx", "LlN0cmVhbVN0YXRlT3B0aW9ucyJ8ChVTZXRTdHJlYW1Gb2N1c1JlcXVlc3QS", "MAoIYWdlbnRfaWQYASABKAsyHi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5NZW1i", "ZXJJZBIPCgdjbHViX2lkGAIgASgEEhEKCXN0cmVhbV9pZBgDIAEoBBINCgVm", "b2N1cxgEIAEoCCKpAQoUQ3JlYXRlTWVzc2FnZVJlcXVlc3QSMAoIYWdlbnRf", "aWQYASABKAsyHi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5NZW1iZXJJZBIPCgdj", "bHViX2lkGAIgASgEEhEKCXN0cmVhbV9pZBgDIAEoBBI7CgdvcHRpb25zGAQg",
				"ASgLMiouYmdzLnByb3RvY29sLmNsdWIudjEuQ3JlYXRlTWVzc2FnZU9wdGlv", "bnMiTQoVQ3JlYXRlTWVzc2FnZVJlc3BvbnNlEjQKB21lc3NhZ2UYASABKAsy", "Iy5iZ3MucHJvdG9jb2wuY2x1Yi52MS5TdHJlYW1NZXNzYWdlIpoBChVEZXN0", "cm95TWVzc2FnZVJlcXVlc3QSMAoIYWdlbnRfaWQYASABKAsyHi5iZ3MucHJv", "dG9jb2wuY2x1Yi52MS5NZW1iZXJJZBIPCgdjbHViX2lkGAIgASgEEhEKCXN0", "cmVhbV9pZBgDIAEoBBIrCgptZXNzYWdlX2lkGAQgASgLMhcuYmdzLnByb3Rv", "Y29sLk1lc3NhZ2VJZCJOChZEZXN0cm95TWVzc2FnZVJlc3BvbnNlEjQKB21l", "c3NhZ2UYASABKAsyIy5iZ3MucHJvdG9jb2wuY2x1Yi52MS5TdHJlYW1NZXNz", "YWdlItQBChJFZGl0TWVzc2FnZVJlcXVlc3QSMAoIYWdlbnRfaWQYASABKAsy", "Hi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5NZW1iZXJJZBIPCgdjbHViX2lkGAIg",
				"ASgEEhEKCXN0cmVhbV9pZBgDIAEoBBIrCgptZXNzYWdlX2lkGAQgASgLMhcu", "YmdzLnByb3RvY29sLk1lc3NhZ2VJZBI7CgdvcHRpb25zGAUgASgLMiouYmdz", "LnByb3RvY29sLmNsdWIudjEuQ3JlYXRlTWVzc2FnZU9wdGlvbnMiSwoTRWRp", "dE1lc3NhZ2VSZXNwb25zZRI0CgdtZXNzYWdlGAEgASgLMiMuYmdzLnByb3Rv", "Y29sLmNsdWIudjEuU3RyZWFtTWVzc2FnZSJvChdTZXRNZXNzYWdlUGlubmVk", "UmVxdWVzdBIwCghhZ2VudF9pZBgBIAEoCzIeLmJncy5wcm90b2NvbC5jbHVi", "LnYxLk1lbWJlcklkEg8KB2NsdWJfaWQYAiABKAQSEQoJc3RyZWFtX2lkGAMg", "ASgEIqMBChlTZXRUeXBpbmdJbmRpY2F0b3JSZXF1ZXN0EjAKCGFnZW50X2lk", "GAEgASgLMh4uYmdzLnByb3RvY29sLmNsdWIudjEuTWVtYmVySWQSDwoHY2x1", "Yl9pZBgCIAEoBBIRCglzdHJlYW1faWQYAyABKAQSMAoJaW5kaWNhdG9yGAQg",
				"ASgOMh0uYmdzLnByb3RvY29sLlR5cGluZ0luZGljYXRvciKaAQocQWR2YW5j", "ZVN0cmVhbVZpZXdUaW1lUmVxdWVzdBIwCghhZ2VudF9pZBgBIAEoCzIeLmJn", "cy5wcm90b2NvbC5jbHViLnYxLk1lbWJlcklkEg8KB2NsdWJfaWQYAiABKAQS", "IAoUc3RyZWFtX2lkX2RlcHJlY2F0ZWQYAyABKARCAhgBEhUKCXN0cmVhbV9p", "ZBgEIAMoBEICEAEiewojQWR2YW5jZVN0cmVhbU1lbnRpb25WaWV3VGltZVJl", "cXVlc3QSMAoIYWdlbnRfaWQYASABKAsyHi5iZ3MucHJvdG9jb2wuY2x1Yi52", "MS5NZW1iZXJJZBIPCgdjbHViX2lkGAIgASgEEhEKCXN0cmVhbV9pZBgDIAEo", "BCJjCh5BZHZhbmNlQWN0aXZpdHlWaWV3VGltZVJlcXVlc3QSMAoIYWdlbnRf", "aWQYASABKAsyHi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5NZW1iZXJJZBIPCgdj", "bHViX2lkGAIgASgEIp8BChdHZXRTdHJlYW1IaXN0b3J5UmVxdWVzdBIwCghh",
				"Z2VudF9pZBgBIAEoCzIeLmJncy5wcm90b2NvbC5jbHViLnYxLk1lbWJlcklk", "Eg8KB2NsdWJfaWQYAiABKAQSEQoJc3RyZWFtX2lkGAMgASgEEi4KB29wdGlv", "bnMYBCABKAsyHS5iZ3MucHJvdG9jb2wuR2V0RXZlbnRPcHRpb25zImYKGEdl", "dFN0cmVhbUhpc3RvcnlSZXNwb25zZRI0CgdtZXNzYWdlGAEgAygLMiMuYmdz", "LnByb3RvY29sLmNsdWIudjEuU3RyZWFtTWVzc2FnZRIUCgxjb250aW51YXRp", "b24YAiABKAQinAEKF0dldFN0cmVhbU1lc3NhZ2VSZXF1ZXN0EjAKCGFnZW50", "X2lkGAEgASgLMh4uYmdzLnByb3RvY29sLmNsdWIudjEuTWVtYmVySWQSDwoH", "Y2x1Yl9pZBgCIAEoBBIRCglzdHJlYW1faWQYAyABKAQSKwoKbWVzc2FnZV9p", "ZBgEIAEoCzIXLmJncy5wcm90b2NvbC5NZXNzYWdlSWQiUAoYR2V0U3RyZWFt", "TWVzc2FnZVJlc3BvbnNlEjQKB21lc3NhZ2UYASABKAsyIy5iZ3MucHJvdG9j",
				"b2wuY2x1Yi52MS5TdHJlYW1NZXNzYWdlIosBChZHZXRDbHViQWN0aXZpdHlS", "ZXF1ZXN0EjAKCGFnZW50X2lkGAEgASgLMh4uYmdzLnByb3RvY29sLmNsdWIu", "djEuTWVtYmVySWQSDwoHY2x1Yl9pZBgCIAEoBBIuCgdvcHRpb25zGAMgASgL", "Mh0uYmdzLnByb3RvY29sLkdldEV2ZW50T3B0aW9ucyIvChdHZXRDbHViQWN0", "aXZpdHlSZXNwb25zZRIUCgxjb250aW51YXRpb24YAiABKAQigwEKGkdldFN0", "cmVhbVZvaWNlVG9rZW5SZXF1ZXN0EjAKCGFnZW50X2lkGAEgASgLMh4uYmdz", "LnByb3RvY29sLmNsdWIudjEuTWVtYmVySWQSDwoHY2x1Yl9pZBgCIAEoBBIR", "CglzdHJlYW1faWQYAyABKAQSDwoHdmVyc2lvbhgEIAEoDSJnChtHZXRTdHJl", "YW1Wb2ljZVRva2VuUmVzcG9uc2USEwoLY2hhbm5lbF91cmkYASABKAkSMwoL", "Y3JlZGVudGlhbHMYAiABKAsyHi5iZ3MucHJvdG9jb2wuVm9pY2VDcmVkZW50",
				"aWFscyKlAQoaS2lja0Zyb21TdHJlYW1Wb2ljZVJlcXVlc3QSMAoIYWdlbnRf", "aWQYASABKAsyHi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5NZW1iZXJJZBIPCgdj", "bHViX2lkGAIgASgEEhEKCXN0cmVhbV9pZBgDIAEoBBIxCgl0YXJnZXRfaWQY", "BCABKAsyHi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5NZW1iZXJJZFAAUAE="
			}));
			ClubRequestReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				ClubTypesReflection.Descriptor,
				ClubTagReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(SubscribeRequest), SubscribeRequest.Parser, new string[] { "AgentId", "ClubId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UnsubscribeRequest), UnsubscribeRequest.Parser, new string[] { "AgentId", "ClubId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CreateRequest), CreateRequest.Parser, new string[] { "AgentId", "Options" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CreateResponse), CreateResponse.Parser, new string[] { "ClubId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(DestroyRequest), DestroyRequest.Parser, new string[] { "AgentId", "ClubId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetDescriptionRequest), GetDescriptionRequest.Parser, new string[] { "AgentId", "ClubId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetDescriptionResponse), GetDescriptionResponse.Parser, new string[] { "Club" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetClubTypeRequest), GetClubTypeRequest.Parser, new string[] { "AgentId", "Type" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetClubTypeResponse), GetClubTypeResponse.Parser, new string[] { "Type", "RoleSet", "RangeSet", "PlatformTagSet", "CustomTagSet" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UpdateClubStateRequest), UpdateClubStateRequest.Parser, new string[] { "AgentId", "ClubId", "Options" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UpdateClubSettingsRequest), UpdateClubSettingsRequest.Parser, new string[] { "AgentId", "ClubId", "Options" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AddMemberRequest), AddMemberRequest.Parser, new string[] { "AgentId", "ClubId", "Options" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(JoinRequest), JoinRequest.Parser, new string[] { "AgentId", "ClubId", "Options" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(LeaveRequest), LeaveRequest.Parser, new string[] { "AgentId", "ClubId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(KickRequest), KickRequest.Parser, new string[] { "AgentId", "ClubId", "TargetId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetMemberRequest), GetMemberRequest.Parser, new string[] { "AgentId", "ClubId", "MemberId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetMemberResponse), GetMemberResponse.Parser, new string[] { "Member" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetMembersRequest), GetMembersRequest.Parser, new string[] { "AgentId", "ClubId", "Continuation" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetMembersResponse), GetMembersResponse.Parser, new string[] { "Member", "Continuation" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UpdateMemberStateRequest), UpdateMemberStateRequest.Parser, new string[] { "AgentId", "ClubId", "MemberId", "Options" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UpdateSubscriberStateRequest), UpdateSubscriberStateRequest.Parser, new string[] { "AgentId", "ClubId", "Options" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AssignRoleRequest), AssignRoleRequest.Parser, new string[] { "AgentId", "ClubId", "Options" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UnassignRoleRequest), UnassignRoleRequest.Parser, new string[] { "AgentId", "ClubId", "Options" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SendInvitationRequest), SendInvitationRequest.Parser, new string[] { "AgentId", "ClubId", "Options" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AcceptInvitationRequest), AcceptInvitationRequest.Parser, new string[] { "AgentId", "ClubId", "InvitationId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(DeclineInvitationRequest), DeclineInvitationRequest.Parser, new string[] { "AgentId", "ClubId", "InvitationId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RevokeInvitationRequest), RevokeInvitationRequest.Parser, new string[] { "AgentId", "ClubId", "InvitationId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetInvitationRequest), GetInvitationRequest.Parser, new string[] { "AgentId", "ClubId", "InvitationId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetInvitationResponse), GetInvitationResponse.Parser, new string[] { "Invitation" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetInvitationsRequest), GetInvitationsRequest.Parser, new string[] { "AgentId", "ClubId", "Continuation" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetInvitationsResponse), GetInvitationsResponse.Parser, new string[] { "Invitation", "Continuation" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SendSuggestionRequest), SendSuggestionRequest.Parser, new string[] { "AgentId", "ClubId", "Options" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AcceptSuggestionRequest), AcceptSuggestionRequest.Parser, new string[] { "AgentId", "ClubId", "SuggestionId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(DeclineSuggestionRequest), DeclineSuggestionRequest.Parser, new string[] { "AgentId", "ClubId", "SuggestionId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetSuggestionRequest), GetSuggestionRequest.Parser, new string[] { "AgentId", "ClubId", "SuggestionId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetSuggestionResponse), GetSuggestionResponse.Parser, new string[] { "Suggestion" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetSuggestionsRequest), GetSuggestionsRequest.Parser, new string[] { "AgentId", "ClubId", "Continuation" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetSuggestionsResponse), GetSuggestionsResponse.Parser, new string[] { "Suggestion", "Continuation" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CreateTicketRequest), CreateTicketRequest.Parser, new string[] { "AgentId", "ClubId", "Options" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CreateTicketResponse), CreateTicketResponse.Parser, new string[] { "Ticket" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(DestroyTicketRequest), DestroyTicketRequest.Parser, new string[] { "AgentId", "ClubId", "TicketId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RedeemTicketRequest), RedeemTicketRequest.Parser, new string[] { "AgentId", "TicketId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetTicketRequest), GetTicketRequest.Parser, new string[] { "AgentId", "TicketId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetTicketResponse), GetTicketResponse.Parser, new string[] { "Ticket" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetTicketsRequest), GetTicketsRequest.Parser, new string[] { "AgentId", "ClubId", "Continuation" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetTicketsResponse), GetTicketsResponse.Parser, new string[] { "Ticket", "Continuation" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AddBanRequest), AddBanRequest.Parser, new string[] { "AgentId", "ClubId", "Options" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RemoveBanRequest), RemoveBanRequest.Parser, new string[] { "AgentId", "ClubId", "TargetId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetBanRequest), GetBanRequest.Parser, new string[] { "AgentId", "ClubId", "TargetId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetBanResponse), GetBanResponse.Parser, new string[] { "Ban" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetBansRequest), GetBansRequest.Parser, new string[] { "AgentId", "ClubId", "Continuation" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetBansResponse), GetBansResponse.Parser, new string[] { "Ban", "Continuation" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SubscribeStreamRequest), SubscribeStreamRequest.Parser, new string[] { "AgentId", "ClubId", "StreamId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UnsubscribeStreamRequest), UnsubscribeStreamRequest.Parser, new string[] { "AgentId", "ClubId", "StreamId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CreateStreamRequest), CreateStreamRequest.Parser, new string[] { "AgentId", "ClubId", "Options" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CreateStreamResponse), CreateStreamResponse.Parser, new string[] { "ClubId", "StreamId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(DestroyStreamRequest), DestroyStreamRequest.Parser, new string[] { "AgentId", "ClubId", "StreamId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetStreamRequest), GetStreamRequest.Parser, new string[] { "AgentId", "ClubId", "StreamId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetStreamResponse), GetStreamResponse.Parser, new string[] { "Stream" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetStreamsRequest), GetStreamsRequest.Parser, new string[] { "AgentId", "ClubId", "Continuation" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetStreamsResponse), GetStreamsResponse.Parser, new string[] { "Stream", "View", "Continuation" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UpdateStreamStateRequest), UpdateStreamStateRequest.Parser, new string[] { "AgentId", "ClubId", "StreamId", "Options" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SetStreamFocusRequest), SetStreamFocusRequest.Parser, new string[] { "AgentId", "ClubId", "StreamId", "Focus" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CreateMessageRequest), CreateMessageRequest.Parser, new string[] { "AgentId", "ClubId", "StreamId", "Options" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CreateMessageResponse), CreateMessageResponse.Parser, new string[] { "Message" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(DestroyMessageRequest), DestroyMessageRequest.Parser, new string[] { "AgentId", "ClubId", "StreamId", "MessageId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(DestroyMessageResponse), DestroyMessageResponse.Parser, new string[] { "Message" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(EditMessageRequest), EditMessageRequest.Parser, new string[] { "AgentId", "ClubId", "StreamId", "MessageId", "Options" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(EditMessageResponse), EditMessageResponse.Parser, new string[] { "Message" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SetMessagePinnedRequest), SetMessagePinnedRequest.Parser, new string[] { "AgentId", "ClubId", "StreamId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SetTypingIndicatorRequest), SetTypingIndicatorRequest.Parser, new string[] { "AgentId", "ClubId", "StreamId", "Indicator" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AdvanceStreamViewTimeRequest), AdvanceStreamViewTimeRequest.Parser, new string[] { "AgentId", "ClubId", "StreamIdDeprecated", "StreamId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AdvanceStreamMentionViewTimeRequest), AdvanceStreamMentionViewTimeRequest.Parser, new string[] { "AgentId", "ClubId", "StreamId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AdvanceActivityViewTimeRequest), AdvanceActivityViewTimeRequest.Parser, new string[] { "AgentId", "ClubId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetStreamHistoryRequest), GetStreamHistoryRequest.Parser, new string[] { "AgentId", "ClubId", "StreamId", "Options" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetStreamHistoryResponse), GetStreamHistoryResponse.Parser, new string[] { "Message", "Continuation" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetStreamMessageRequest), GetStreamMessageRequest.Parser, new string[] { "AgentId", "ClubId", "StreamId", "MessageId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetStreamMessageResponse), GetStreamMessageResponse.Parser, new string[] { "Message" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetClubActivityRequest), GetClubActivityRequest.Parser, new string[] { "AgentId", "ClubId", "Options" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetClubActivityResponse), GetClubActivityResponse.Parser, new string[] { "Continuation" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetStreamVoiceTokenRequest), GetStreamVoiceTokenRequest.Parser, new string[] { "AgentId", "ClubId", "StreamId", "Version" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetStreamVoiceTokenResponse), GetStreamVoiceTokenResponse.Parser, new string[] { "ChannelUri", "Credentials" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(KickFromStreamVoiceRequest), KickFromStreamVoiceRequest.Parser, new string[] { "AgentId", "ClubId", "StreamId", "TargetId" }, null, null, null, null)
			}));
		}

		// Token: 0x0400348B RID: 13451
		private static FileDescriptor descriptor;
	}
}
