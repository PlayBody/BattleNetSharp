using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000492 RID: 1170
	public static class ClubRangeSetReflection
	{
		// Token: 0x17002473 RID: 9331
		// (get) Token: 0x06007221 RID: 29217 RVA: 0x001BC1BC File Offset: 0x001BA3BC
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClubRangeSetReflection.descriptor;
			}
		}

		// Token: 0x06007222 RID: 29218 RVA: 0x001BC1D4 File Offset: 0x001BA3D4
		static ClubRangeSetReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CiZiZ3MvbG93L3BiL2NsaWVudC9jbHViX3JhbmdlX3NldC5wcm90bxIUYmdz", "LnByb3RvY29sLmNsdWIudjEaL2Jncy9sb3cvcGIvY2xpZW50L2dsb2JhbF9l", "eHRlbnNpb25zL3JhbmdlLnByb3RvItoEChBDbHViVHlwZVJhbmdlU2V0EjIK", "Cm5hbWVfcmFuZ2UYAiABKAsyHi5iZ3MucHJvdG9jb2wuVW5zaWduZWRJbnRS", "YW5nZRI5ChFkZXNjcmlwdGlvbl9yYW5nZRgDIAEoCzIeLmJncy5wcm90b2Nv", "bC5VbnNpZ25lZEludFJhbmdlEjcKD2Jyb2FkY2FzdF9yYW5nZRgEIAEoCzIe", "LmJncy5wcm90b2NvbC5VbnNpZ25lZEludFJhbmdlEjgKEHNob3J0X25hbWVf", "cmFuZ2UYByABKAsyHi5iZ3MucHJvdG9jb2wuVW5zaWduZWRJbnRSYW5nZRI4", "CgZtZW1iZXIYGSABKAsyKC5iZ3MucHJvdG9jb2wuY2x1Yi52MS5DbHViTWVt", "YmVyUmFuZ2VTZXQSOAoGc3RyZWFtGBogASgLMiguYmdzLnByb3RvY29sLmNs",
				"dWIudjEuQ2x1YlN0cmVhbVJhbmdlU2V0EkAKCmludml0YXRpb24YGyABKAsy", "LC5iZ3MucHJvdG9jb2wuY2x1Yi52MS5DbHViSW52aXRhdGlvblJhbmdlU2V0", "EkAKCnN1Z2dlc3Rpb24YHCABKAsyLC5iZ3MucHJvdG9jb2wuY2x1Yi52MS5D", "bHViU3VnZ2VzdGlvblJhbmdlU2V0EjgKBnRpY2tldBgdIAEoCzIoLmJncy5w", "cm90b2NvbC5jbHViLnYxLkNsdWJUaWNrZXRSYW5nZVNldBIyCgNiYW4YHiAB", "KAsyJS5iZ3MucHJvdG9jb2wuY2x1Yi52MS5DbHViQmFuUmFuZ2VTZXQi5AEK", "EkNsdWJNZW1iZXJSYW5nZVNldBItCgVjb3VudBgBIAEoCzIeLmJncy5wcm90", "b2NvbC5VbnNpZ25lZEludFJhbmdlEi0KBXZvaWNlGAMgASgLMh4uYmdzLnBy", "b3RvY29sLlVuc2lnbmVkSW50UmFuZ2USPAoUc3RyZWFtX3N1YnNjcmlwdGlv", "bnMYBSABKAsyHi5iZ3MucHJvdG9jb2wuVW5zaWduZWRJbnRSYW5nZRIyCgpu",
				"b3RlX3JhbmdlGAcgASgLMh4uYmdzLnByb3RvY29sLlVuc2lnbmVkSW50UmFu", "Z2Ui5QEKEkNsdWJTdHJlYW1SYW5nZVNldBItCgVjb3VudBgBIAEoCzIeLmJn", "cy5wcm90b2NvbC5VbnNpZ25lZEludFJhbmdlEjIKCm5hbWVfcmFuZ2UYAyAB", "KAsyHi5iZ3MucHJvdG9jb2wuVW5zaWduZWRJbnRSYW5nZRI1Cg1zdWJqZWN0", "X3JhbmdlGAQgASgLMh4uYmdzLnByb3RvY29sLlVuc2lnbmVkSW50UmFuZ2US", "NQoNbWVzc2FnZV9yYW5nZRgFIAEoCzIeLmJncy5wcm90b2NvbC5VbnNpZ25l", "ZEludFJhbmdlIkcKFkNsdWJJbnZpdGF0aW9uUmFuZ2VTZXQSLQoFY291bnQY", "ASABKAsyHi5iZ3MucHJvdG9jb2wuVW5zaWduZWRJbnRSYW5nZSJHChZDbHVi", "U3VnZ2VzdGlvblJhbmdlU2V0Ei0KBWNvdW50GAEgASgLMh4uYmdzLnByb3Rv", "Y29sLlVuc2lnbmVkSW50UmFuZ2UiQwoSQ2x1YlRpY2tldFJhbmdlU2V0Ei0K",
				"BWNvdW50GAEgASgLMh4uYmdzLnByb3RvY29sLlVuc2lnbmVkSW50UmFuZ2Ui", "dgoPQ2x1YkJhblJhbmdlU2V0Ei0KBWNvdW50GAEgASgLMh4uYmdzLnByb3Rv", "Y29sLlVuc2lnbmVkSW50UmFuZ2USNAoMcmVhc29uX3JhbmdlGAMgASgLMh4u", "YmdzLnByb3RvY29sLlVuc2lnbmVkSW50UmFuZ2U="
			}));
			ClubRangeSetReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { RangeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ClubTypeRangeSet), ClubTypeRangeSet.Parser, new string[] { "NameRange", "DescriptionRange", "BroadcastRange", "ShortNameRange", "Member", "Stream", "Invitation", "Suggestion", "Ticket", "Ban" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClubMemberRangeSet), ClubMemberRangeSet.Parser, new string[] { "Count", "Voice", "StreamSubscriptions", "NoteRange" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClubStreamRangeSet), ClubStreamRangeSet.Parser, new string[] { "Count", "NameRange", "SubjectRange", "MessageRange" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClubInvitationRangeSet), ClubInvitationRangeSet.Parser, new string[] { "Count" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClubSuggestionRangeSet), ClubSuggestionRangeSet.Parser, new string[] { "Count" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClubTicketRangeSet), ClubTicketRangeSet.Parser, new string[] { "Count" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClubBanRangeSet), ClubBanRangeSet.Parser, new string[] { "Count", "ReasonRange" }, null, null, null, null)
			}));
		}

		// Token: 0x0400344E RID: 13390
		private static FileDescriptor descriptor;
	}
}
