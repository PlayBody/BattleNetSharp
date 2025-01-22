using System;
using Bgs.Protocol.V2;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000453 RID: 1107
	public static class ClubInvitationReflection
	{
		// Token: 0x170022AB RID: 8875
		// (get) Token: 0x06006C3E RID: 27710 RVA: 0x001A48B4 File Offset: 0x001A2AB4
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClubInvitationReflection.descriptor;
			}
		}

		// Token: 0x06006C3F RID: 27711 RVA: 0x001A48CC File Offset: 0x001A2ACC
		static ClubInvitationReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CidiZ3MvbG93L3BiL2NsaWVudC9jbHViX2ludml0YXRpb24ucHJvdG8SFGJn", "cy5wcm90b2NvbC5jbHViLnYxGjdiZ3MvbG93L3BiL2NsaWVudC9nbG9iYWxf", "ZXh0ZW5zaW9ucy9maWVsZF9vcHRpb25zLnByb3RvGiFiZ3MvbG93L3BiL2Ns", "aWVudC9jbHViX2NvcmUucHJvdG8aI2Jncy9sb3cvcGIvY2xpZW50L2NsdWJf", "bWVtYmVyLnByb3RvGjViZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3Yy", "L2F0dHJpYnV0ZV90eXBlcy5wcm90byIzCghDbHViU2xvdBIMCgRyb2xlGAEg", "ASgNEhkKEWRlZmF1bHRfc3RyZWFtX2lkGAIgASgEIqcBChVTZW5kSW52aXRh", "dGlvbk9wdGlvbnMSMQoJdGFyZ2V0X2lkGAEgASgLMh4uYmdzLnByb3RvY29s", "LmNsdWIudjEuTWVtYmVySWQSLAoEc2xvdBgCIAEoCzIeLmJncy5wcm90b2Nv", "bC5jbHViLnYxLkNsdWJTbG90Ei0KCWF0dHJpYnV0ZRgDIAMoCzIaLmJncy5w",
				"cm90b2NvbC52Mi5BdHRyaWJ1dGUijgMKDkNsdWJJbnZpdGF0aW9uEgoKAmlk", "GAEgASgGEjgKB2ludml0ZXIYAiABKAsyJy5iZ3MucHJvdG9jb2wuY2x1Yi52", "MS5NZW1iZXJEZXNjcmlwdGlvbhI4CgdpbnZpdGVlGAMgASgLMicuYmdzLnBy", "b3RvY29sLmNsdWIudjEuTWVtYmVyRGVzY3JpcHRpb24SMwoEY2x1YhgEIAEo", "CzIlLmJncy5wcm90b2NvbC5jbHViLnYxLkNsdWJEZXNjcmlwdGlvbhIsCgRz", "bG90GAUgASgLMh4uYmdzLnByb3RvY29sLmNsdWIudjEuQ2x1YlNsb3QSLQoJ", "YXR0cmlidXRlGAYgAygLMhouYmdzLnByb3RvY29sLnYyLkF0dHJpYnV0ZRIV", "Cg1jcmVhdGlvbl90aW1lGAcgASgEEhcKD2V4cGlyYXRpb25fdGltZRgIIAEo", "BBI6CglzdWdnZXN0ZXIYCSABKAsyJy5iZ3MucHJvdG9jb2wuY2x1Yi52MS5N", "ZW1iZXJEZXNjcmlwdGlvbiLBAQoVU2VuZFN1Z2dlc3Rpb25PcHRpb25zEjEK",
				"CXRhcmdldF9pZBgBIAEoCzIeLmJncy5wcm90b2NvbC5jbHViLnYxLk1lbWJl", "cklkEiwKBHNsb3QYAiABKAsyHi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5DbHVi", "U2xvdBItCglhdHRyaWJ1dGUYAyADKAsyGi5iZ3MucHJvdG9jb2wudjIuQXR0", "cmlidXRlEhgKEGpvaW5fY2x1Yl9zb3VyY2UYBCABKA0isgIKDkNsdWJTdWdn", "ZXN0aW9uEgoKAmlkGAEgASgGEg8KB2NsdWJfaWQYAiABKAQSOgoJc3VnZ2Vz", "dGVyGAMgASgLMicuYmdzLnByb3RvY29sLmNsdWIudjEuTWVtYmVyRGVzY3Jp", "cHRpb24SOgoJc3VnZ2VzdGVlGAQgASgLMicuYmdzLnByb3RvY29sLmNsdWIu", "djEuTWVtYmVyRGVzY3JpcHRpb24SLAoEc2xvdBgFIAEoCzIeLmJncy5wcm90", "b2NvbC5jbHViLnYxLkNsdWJTbG90Ei0KCWF0dHJpYnV0ZRgGIAMoCzIaLmJn", "cy5wcm90b2NvbC52Mi5BdHRyaWJ1dGUSFQoNY3JlYXRpb25fdGltZRgHIAEo",
				"BBIXCg9leHBpcmF0aW9uX3RpbWUYCCABKAQiwwEKE0NyZWF0ZVRpY2tldE9w", "dGlvbnMSLAoEc2xvdBgBIAEoCzIeLmJncy5wcm90b2NvbC5jbHViLnYxLkNs", "dWJTbG90Ei0KCWF0dHJpYnV0ZRgCIAMoCzIaLmJncy5wcm90b2NvbC52Mi5B", "dHRyaWJ1dGUSHAoUYWxsb3dlZF9yZWRlZW1fY291bnQYAyABKA0SFwoPZXhw", "aXJhdGlvbl90aW1lGAQgASgEEhgKEGpvaW5fY2x1Yl9zb3VyY2UYBSABKA0i", "0AIKCkNsdWJUaWNrZXQSCgoCaWQYASABKAkSOAoHY3JlYXRvchgCIAEoCzIn", "LmJncy5wcm90b2NvbC5jbHViLnYxLk1lbWJlckRlc2NyaXB0aW9uEjMKBGNs", "dWIYAyABKAsyJS5iZ3MucHJvdG9jb2wuY2x1Yi52MS5DbHViRGVzY3JpcHRp", "b24SLAoEc2xvdBgEIAEoCzIeLmJncy5wcm90b2NvbC5jbHViLnYxLkNsdWJT", "bG90Ei0KCWF0dHJpYnV0ZRgFIAMoCzIaLmJncy5wcm90b2NvbC52Mi5BdHRy",
				"aWJ1dGUSHAoUY3VycmVudF9yZWRlZW1fY291bnQYBiABKA0SHAoUYWxsb3dl", "ZF9yZWRlZW1fY291bnQYByABKA0SFQoNY3JlYXRpb25fdGltZRgIIAEoBBIX", "Cg9leHBpcmF0aW9uX3RpbWUYCSABKARQAA=="
			}));
			ClubInvitationReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				FieldOptionsReflection.Descriptor,
				ClubCoreReflection.Descriptor,
				ClubMemberReflection.Descriptor,
				AttributeTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ClubSlot), ClubSlot.Parser, new string[] { "Role", "DefaultStreamId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SendInvitationOptions), SendInvitationOptions.Parser, new string[] { "TargetId", "Slot", "Attribute" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClubInvitation), ClubInvitation.Parser, new string[] { "Id", "Inviter", "Invitee", "Club", "Slot", "Attribute", "CreationTime", "ExpirationTime", "Suggester" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SendSuggestionOptions), SendSuggestionOptions.Parser, new string[] { "TargetId", "Slot", "Attribute", "JoinClubSource" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClubSuggestion), ClubSuggestion.Parser, new string[] { "Id", "ClubId", "Suggester", "Suggestee", "Slot", "Attribute", "CreationTime", "ExpirationTime" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CreateTicketOptions), CreateTicketOptions.Parser, new string[] { "Slot", "Attribute", "AllowedRedeemCount", "ExpirationTime", "JoinClubSource" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClubTicket), ClubTicket.Parser, new string[] { "Id", "Creator", "Club", "Slot", "Attribute", "CurrentRedeemCount", "AllowedRedeemCount", "CreationTime", "ExpirationTime" }, null, null, null, null)
			}));
		}

		// Token: 0x040031B6 RID: 12726
		private static FileDescriptor descriptor;
	}
}
