using System;
using Bgs.Protocol.Channel.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V1
{
	// Token: 0x020005AB RID: 1451
	public static class PresenceTypesReflection
	{
		// Token: 0x17002B5E RID: 11102
		// (get) Token: 0x060089FE RID: 35326 RVA: 0x0021836C File Offset: 0x0021656C
		public static FileDescriptor Descriptor
		{
			get
			{
				return PresenceTypesReflection.descriptor;
			}
		}

		// Token: 0x060089FF RID: 35327 RVA: 0x00218384 File Offset: 0x00216584
		static PresenceTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CiZiZ3MvbG93L3BiL2NsaWVudC9wcmVzZW5jZV90eXBlcy5wcm90bxIYYmdz", "LnByb3RvY29sLnByZXNlbmNlLnYxGidiZ3MvbG93L3BiL2NsaWVudC9hdHRy", "aWJ1dGVfdHlwZXMucHJvdG8aJGJncy9sb3cvcGIvY2xpZW50L2VudGl0eV90", "eXBlcy5wcm90bxolYmdzL2xvdy9wYi9jbGllbnQvY2hhbm5lbF90eXBlcy5w", "cm90byJXChtSaWNoUHJlc2VuY2VMb2NhbGl6YXRpb25LZXkSDwoHcHJvZ3Jh", "bRgBIAIoBxIOCgZzdHJlYW0YAiACKAcSFwoPbG9jYWxpemF0aW9uX2lkGAMg", "AigNIk8KCEZpZWxkS2V5Eg8KB3Byb2dyYW0YASACKA0SDQoFZ3JvdXAYAiAC", "KA0SDQoFZmllbGQYAyACKA0SFAoJdW5pcXVlX2lkGAQgASgEOgEwIl4KBUZp", "ZWxkEi8KA2tleRgBIAIoCzIiLmJncy5wcm90b2NvbC5wcmVzZW5jZS52MS5G", "aWVsZEtleRIkCgV2YWx1ZRgCIAIoCzIVLmJncy5wcm90b2NvbC5WYXJpYW50",
				"IrUBCg5GaWVsZE9wZXJhdGlvbhIuCgVmaWVsZBgBIAIoCzIfLmJncy5wcm90", "b2NvbC5wcmVzZW5jZS52MS5GaWVsZBJOCglvcGVyYXRpb24YAiABKA4yNi5i", "Z3MucHJvdG9jb2wucHJlc2VuY2UudjEuRmllbGRPcGVyYXRpb24uT3BlcmF0", "aW9uVHlwZToDU0VUIiMKDU9wZXJhdGlvblR5cGUSBwoDU0VUEAASCQoFQ0xF", "QVIQASJ9Cg1QcmVzZW5jZVN0YXRlEikKCWVudGl0eV9pZBgBIAEoCzIWLmJn", "cy5wcm90b2NvbC5FbnRpdHlJZBJBCg9maWVsZF9vcGVyYXRpb24YAiADKAsy", "KC5iZ3MucHJvdG9jb2wucHJlc2VuY2UudjEuRmllbGRPcGVyYXRpb24i9QEK", "DENoYW5uZWxTdGF0ZRIpCgllbnRpdHlfaWQYASABKAsyFi5iZ3MucHJvdG9j", "b2wuRW50aXR5SWQSQQoPZmllbGRfb3BlcmF0aW9uGAIgAygLMiguYmdzLnBy", "b3RvY29sLnByZXNlbmNlLnYxLkZpZWxkT3BlcmF0aW9uEhYKB2hlYWxpbmcY",
				"AyABKAg6BWZhbHNlMl8KCHByZXNlbmNlEiUuYmdzLnByb3RvY29sLmNoYW5u", "ZWwudjEuQ2hhbm5lbFN0YXRlGGUgASgLMiYuYmdzLnByb3RvY29sLnByZXNl", "bmNlLnYxLkNoYW5uZWxTdGF0ZUICSAE="
			}));
			PresenceTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				AttributeTypesReflection.Descriptor,
				EntityTypesReflection.Descriptor,
				ChannelTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(RichPresenceLocalizationKey), RichPresenceLocalizationKey.Parser, new string[] { "Program", "Stream", "LocalizationId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(FieldKey), FieldKey.Parser, new string[] { "Program", "Group", "Field", "UniqueId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Field), Field.Parser, new string[] { "Key", "Value" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(FieldOperation), FieldOperation.Parser, new string[] { "Field", "Operation" }, null, new Type[] { typeof(FieldOperation.Types.OperationType) }, null, null),
				new GeneratedClrTypeInfo(typeof(PresenceState), PresenceState.Parser, new string[] { "EntityId", "FieldOperation" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ChannelState), ChannelState.Parser, new string[] { "EntityId", "FieldOperation", "Healing" }, null, null, new Extension[] { ChannelState.Extensions.Presence }, null)
			}));
		}

		// Token: 0x04003E7E RID: 15998
		private static FileDescriptor descriptor;
	}
}
