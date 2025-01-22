using System;
using Bgs.Protocol.V2;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200043B RID: 1083
	public static class ClubCoreReflection
	{
		// Token: 0x170021F2 RID: 8690
		// (get) Token: 0x06006A4E RID: 27214 RVA: 0x0019B79C File Offset: 0x0019999C
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClubCoreReflection.descriptor;
			}
		}

		// Token: 0x06006A4F RID: 27215 RVA: 0x0019B7B4 File Offset: 0x001999B4
		static ClubCoreReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CiFiZ3MvbG93L3BiL2NsaWVudC9jbHViX2NvcmUucHJvdG8SFGJncy5wcm90", "b2NvbC5jbHViLnYxGiFiZ3MvbG93L3BiL2NsaWVudC9jbHViX3R5cGUucHJv", "dG8aIWJncy9sb3cvcGIvY2xpZW50L2NsdWJfZW51bS5wcm90bxohYmdzL2xv", "dy9wYi9jbGllbnQvY2x1Yl9yb2xlLnByb3RvGiNiZ3MvbG93L3BiL2NsaWVu", "dC9jbHViX21lbWJlci5wcm90bxojYmdzL2xvdy9wYi9jbGllbnQvY2x1Yl9z", "dHJlYW0ucHJvdG8aIGJncy9sb3cvcGIvY2xpZW50L2NsdWJfdGFnLnByb3Rv", "GjViZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL2F0dHJpYnV0ZV90", "eXBlcy5wcm90bxooYmdzL2xvdy9wYi9jbGllbnQvZXZlbnRfdmlld190eXBl", "cy5wcm90byIWCghBdmF0YXJJZBIKCgJpZBgBIAEoDSImChNTZXRCcm9hZGNh", "c3RPcHRpb25zEg8KB2NvbnRlbnQYASABKAkibQoJQnJvYWRjYXN0Eg8KB2Nv",
				"bnRlbnQYASABKAkSOAoHY3JlYXRvchgCIAEoCzInLmJncy5wcm90b2NvbC5j", "bHViLnYxLk1lbWJlckRlc2NyaXB0aW9uEhUKDWNyZWF0aW9uX3RpbWUYAyAB", "KAQi1gQKEUNsdWJDcmVhdGVPcHRpb25zEjIKBHR5cGUYASABKAsyJC5iZ3Mu", "cHJvdG9jb2wuY2x1Yi52MS5VbmlxdWVDbHViVHlwZRItCglhdHRyaWJ1dGUY", "AiADKAsyGi5iZ3MucHJvdG9jb2wudjIuQXR0cmlidXRlEgwKBG5hbWUYAyAB", "KAkSEwoLZGVzY3JpcHRpb24YBCABKAkSLgoGYXZhdGFyGAUgASgLMh4uYmdz", "LnByb3RvY29sLmNsdWIudjEuQXZhdGFySWQSOQoNcHJpdmFjeV9sZXZlbBgG", "IAEoDjIiLmJncy5wcm90b2NvbC5jbHViLnYxLlByaXZhY3lMZXZlbBISCgpz", "aG9ydF9uYW1lGAcgASgJEj8KEHZpc2liaWxpdHlfbGV2ZWwYCCABKA4yJS5i", "Z3MucHJvdG9jb2wuY2x1Yi52MS5WaXNpYmlsaXR5TGV2ZWwSOQoGbWVtYmVy",
				"GAogASgLMikuYmdzLnByb3RvY29sLmNsdWIudjEuQ3JlYXRlTWVtYmVyT3B0", "aW9ucxI5CgZzdHJlYW0YCyABKAsyKS5iZ3MucHJvdG9jb2wuY2x1Yi52MS5D", "cmVhdGVTdHJlYW1PcHRpb25zEi0KA3RhZxgMIAEoCzIgLmJncy5wcm90b2Nv", "bC5jbHViLnYxLlRhZ09wdGlvbnMSNAoQc2VhcmNoX2F0dHJpYnV0ZRgNIAMo", "CzIaLmJncy5wcm90b2NvbC52Mi5BdHRyaWJ1dGUSDgoGbG9jYWxlGA4gASgJ", "EhAKCHRpbWV6b25lGA8gASgJIvAFCgRDbHViEgoKAmlkGAEgASgEEjIKBHR5", "cGUYAiABKAsyJC5iZ3MucHJvdG9jb2wuY2x1Yi52MS5VbmlxdWVDbHViVHlw", "ZRItCglhdHRyaWJ1dGUYAyADKAsyGi5iZ3MucHJvdG9jb2wudjIuQXR0cmli", "dXRlEgwKBG5hbWUYBCABKAkSEwoLZGVzY3JpcHRpb24YBSABKAkSMgoJYnJv", "YWRjYXN0GAYgASgLMh8uYmdzLnByb3RvY29sLmNsdWIudjEuQnJvYWRjYXN0",
				"Ei4KBmF2YXRhchgHIAEoCzIeLmJncy5wcm90b2NvbC5jbHViLnYxLkF2YXRh", "cklkEjkKDXByaXZhY3lfbGV2ZWwYCCABKA4yIi5iZ3MucHJvdG9jb2wuY2x1", "Yi52MS5Qcml2YWN5TGV2ZWwSPwoQdmlzaWJpbGl0eV9sZXZlbBgJIAEoDjIl", "LmJncy5wcm90b2NvbC5jbHViLnYxLlZpc2liaWxpdHlMZXZlbBIUCgxtZW1i", "ZXJfY291bnQYCiABKA0SFQoNY3JlYXRpb25fdGltZRgLIAEoBBI9Cg9zdHJl", "YW1fcG9zaXRpb24YDCABKAsyJC5iZ3MucHJvdG9jb2wuY2x1Yi52MS5TdHJl", "YW1Qb3NpdGlvbhIzCghyb2xlX3NldBgNIAEoCzIhLmJncy5wcm90b2NvbC5j", "bHViLnYxLkNsdWJSb2xlU2V0EjcKBmxlYWRlchgOIAMoCzInLmJncy5wcm90", "b2NvbC5jbHViLnYxLk1lbWJlckRlc2NyaXB0aW9uEhIKCnNob3J0X25hbWUY", "DyABKAkSNAoQc2VhcmNoX2F0dHJpYnV0ZRgQIAMoCzIaLmJncy5wcm90b2Nv",
				"bC52Mi5BdHRyaWJ1dGUSMAoDdGFnGBEgAygLMiMuYmdzLnByb3RvY29sLmNs", "dWIudjEuVGFnSWRlbnRpZmllchIOCgZsb2NhbGUYEiABKAkSEAoIdGltZXpv", "bmUYEyABKAki2gMKD0NsdWJEZXNjcmlwdGlvbhIKCgJpZBgBIAEoBBIyCgR0", "eXBlGAIgASgLMiQuYmdzLnByb3RvY29sLmNsdWIudjEuVW5pcXVlQ2x1YlR5", "cGUSDAoEbmFtZRgDIAEoCRITCgtkZXNjcmlwdGlvbhgEIAEoCRIuCgZhdmF0", "YXIYBSABKAsyHi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5BdmF0YXJJZBI5Cg1w", "cml2YWN5X2xldmVsGAYgASgOMiIuYmdzLnByb3RvY29sLmNsdWIudjEuUHJp", "dmFjeUxldmVsEj8KEHZpc2liaWxpdHlfbGV2ZWwYByABKA4yJS5iZ3MucHJv", "dG9jb2wuY2x1Yi52MS5WaXNpYmlsaXR5TGV2ZWwSFAoMbWVtYmVyX2NvdW50", "GAggASgNEjcKBmxlYWRlchgJIAMoCzInLmJncy5wcm90b2NvbC5jbHViLnYx",
				"Lk1lbWJlckRlc2NyaXB0aW9uEhUKDWNyZWF0aW9uX3RpbWUYCiABKAQSEAoI", "dGltZXpvbmUYCyABKAkSDgoGbG9jYWxlGAwgASgJEjAKA3RhZxgNIAMoCzIj", "LmJncy5wcm90b2NvbC5jbHViLnYxLlRhZ0lkZW50aWZpZXIiRQoIQ2x1YlZp", "ZXcSDwoHY2x1Yl9pZBgBIAEoBBIoCgZtYXJrZXIYAiABKAsyGC5iZ3MucHJv", "dG9jb2wuVmlld01hcmtlciKwBAoQQ2x1YlN0YXRlT3B0aW9ucxItCglhdHRy", "aWJ1dGUYASADKAsyGi5iZ3MucHJvdG9jb2wudjIuQXR0cmlidXRlEgwKBG5h", "bWUYAiABKAkSEwoLZGVzY3JpcHRpb24YAyABKAkSPAoJYnJvYWRjYXN0GAQg", "ASgLMikuYmdzLnByb3RvY29sLmNsdWIudjEuU2V0QnJvYWRjYXN0T3B0aW9u", "cxIuCgZhdmF0YXIYBSABKAsyHi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5BdmF0", "YXJJZBI5Cg1wcml2YWN5X2xldmVsGAYgASgOMiIuYmdzLnByb3RvY29sLmNs",
				"dWIudjEuUHJpdmFjeUxldmVsEj0KD3N0cmVhbV9wb3NpdGlvbhgHIAEoCzIk", "LmJncy5wcm90b2NvbC5jbHViLnYxLlN0cmVhbVBvc2l0aW9uEhIKCnNob3J0", "X25hbWUYCCABKAkSPwoQdmlzaWJpbGl0eV9sZXZlbBgJIAEoDjIlLmJncy5w", "cm90b2NvbC5jbHViLnYxLlZpc2liaWxpdHlMZXZlbBIOCgZsb2NhbGUYCiAB", "KAkSEAoIdGltZXpvbmUYCyABKAkSNQoLdGFnX29wdGlvbnMYDCABKAsyIC5i", "Z3MucHJvdG9jb2wuY2x1Yi52MS5UYWdPcHRpb25zEjQKEHNlYXJjaF9hdHRy", "aWJ1dGUYDSADKAsyGi5iZ3MucHJvdG9jb2wudjIuQXR0cmlidXRlIsoEChND", "bHViU3RhdGVBc3NpZ25tZW50Eg8KB2NsdWJfaWQYASABKAQSLQoJYXR0cmli", "dXRlGAIgAygLMhouYmdzLnByb3RvY29sLnYyLkF0dHJpYnV0ZRIMCgRuYW1l", "GAMgASgJEhMKC2Rlc2NyaXB0aW9uGAQgASgJEjIKCWJyb2FkY2FzdBgFIAEo",
				"CzIfLmJncy5wcm90b2NvbC5jbHViLnYxLkJyb2FkY2FzdBIuCgZhdmF0YXIY", "BiABKAsyHi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5BdmF0YXJJZBI5Cg1wcml2", "YWN5X2xldmVsGAcgASgOMiIuYmdzLnByb3RvY29sLmNsdWIudjEuUHJpdmFj", "eUxldmVsEj0KD3N0cmVhbV9wb3NpdGlvbhgIIAEoCzIkLmJncy5wcm90b2Nv", "bC5jbHViLnYxLlN0cmVhbVBvc2l0aW9uEhIKCnNob3J0X25hbWUYCSABKAkS", "PwoQdmlzaWJpbGl0eV9sZXZlbBgKIAEoDjIlLmJncy5wcm90b2NvbC5jbHVi", "LnYxLlZpc2liaWxpdHlMZXZlbBIOCgZsb2NhbGUYCyABKAkSEAoIdGltZXpv", "bmUYDCABKAkSMAoDdGFnGA0gAygLMiMuYmdzLnByb3RvY29sLmNsdWIudjEu", "VGFnSWRlbnRpZmllchI0ChBzZWFyY2hfYXR0cmlidXRlGA4gAygLMhouYmdz", "LnByb3RvY29sLnYyLkF0dHJpYnV0ZRITCgt0YWdfY2xlYXJlZBgPIAEoCCJj",
				"Cg5TdHJlYW1TZXR0aW5ncxIRCglzdHJlYW1faWQYASABKAQSPgoGZmlsdGVy", "GAIgASgOMi4uYmdzLnByb3RvY29sLmNsdWIudjEuU3RyZWFtTm90aWZpY2F0", "aW9uRmlsdGVyIsEBCgxDbHViU2V0dGluZ3MSNAoGc3RyZWFtGAEgAygLMiQu", "YmdzLnByb3RvY29sLmNsdWIudjEuU3RyZWFtU2V0dGluZ3MSJgoec3RyZWFt", "X25vdGlmaWNhdGlvbl9maWx0ZXJfYWxsGAIgASgIEi0KCWF0dHJpYnV0ZRgD", "IAMoCzIaLmJncy5wcm90b2NvbC52Mi5BdHRyaWJ1dGUSJAoccHVzaF9ub3Rp", "ZmljYXRpb25fZmlsdGVyX2FsbBgEIAEoCCKWAQoTQ2x1YlNldHRpbmdzT3B0", "aW9ucxI4CgZzdHJlYW0YASADKAsyJC5iZ3MucHJvdG9jb2wuY2x1Yi52MS5T", "dHJlYW1TZXR0aW5nc0ICGAESNAoIc2V0dGluZ3MYAiABKAsyIi5iZ3MucHJv", "dG9jb2wuY2x1Yi52MS5DbHViU2V0dGluZ3MSDwoHdmVyc2lvbhgDIAEoDSKI",
				"AQoWQ2x1YlNldHRpbmdzQXNzaWdubWVudBI4CgZzdHJlYW0YASADKAsyJC5i", "Z3MucHJvdG9jb2wuY2x1Yi52MS5TdHJlYW1TZXR0aW5nc0ICGAESNAoIc2V0", "dGluZ3MYAiABKAsyIi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5DbHViU2V0dGlu", "Z3M="
			}));
			ClubCoreReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				ClubTypeReflection.Descriptor,
				ClubEnumReflection.Descriptor,
				ClubRoleReflection.Descriptor,
				ClubMemberReflection.Descriptor,
				ClubStreamReflection.Descriptor,
				ClubTagReflection.Descriptor,
				AttributeTypesReflection.Descriptor,
				EventViewTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(AvatarId), AvatarId.Parser, new string[] { "Id" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SetBroadcastOptions), SetBroadcastOptions.Parser, new string[] { "Content" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Broadcast), Broadcast.Parser, new string[] { "Content", "Creator", "CreationTime" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClubCreateOptions), ClubCreateOptions.Parser, new string[]
				{
					"Type", "Attribute", "Name", "Description", "Avatar", "PrivacyLevel", "ShortName", "VisibilityLevel", "Member", "Stream",
					"Tag", "SearchAttribute", "Locale", "Timezone"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Club), Club.Parser, new string[]
				{
					"Id", "Type", "Attribute", "Name", "Description", "Broadcast", "Avatar", "PrivacyLevel", "VisibilityLevel", "MemberCount",
					"CreationTime", "StreamPosition", "RoleSet", "Leader", "ShortName", "SearchAttribute", "Tag", "Locale", "Timezone"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClubDescription), ClubDescription.Parser, new string[]
				{
					"Id", "Type", "Name", "Description", "Avatar", "PrivacyLevel", "VisibilityLevel", "MemberCount", "Leader", "CreationTime",
					"Timezone", "Locale", "Tag"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClubView), ClubView.Parser, new string[] { "ClubId", "Marker" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClubStateOptions), ClubStateOptions.Parser, new string[]
				{
					"Attribute", "Name", "Description", "Broadcast", "Avatar", "PrivacyLevel", "StreamPosition", "ShortName", "VisibilityLevel", "Locale",
					"Timezone", "TagOptions", "SearchAttribute"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClubStateAssignment), ClubStateAssignment.Parser, new string[]
				{
					"ClubId", "Attribute", "Name", "Description", "Broadcast", "Avatar", "PrivacyLevel", "StreamPosition", "ShortName", "VisibilityLevel",
					"Locale", "Timezone", "Tag", "SearchAttribute", "TagCleared"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(StreamSettings), StreamSettings.Parser, new string[] { "StreamId", "Filter" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClubSettings), ClubSettings.Parser, new string[] { "Stream", "StreamNotificationFilterAll", "Attribute", "PushNotificationFilterAll" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClubSettingsOptions), ClubSettingsOptions.Parser, new string[] { "Stream", "Settings", "Version" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClubSettingsAssignment), ClubSettingsAssignment.Parser, new string[] { "Stream", "Settings" }, null, null, null, null)
			}));
		}

		// Token: 0x0400306B RID: 12395
		private static FileDescriptor descriptor;
	}
}
