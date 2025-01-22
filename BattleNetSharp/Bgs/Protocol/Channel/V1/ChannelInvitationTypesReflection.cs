using System;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006C6 RID: 1734
	public static class ChannelInvitationTypesReflection
	{
		// Token: 0x170031A3 RID: 12707
		// (get) Token: 0x0600A01C RID: 40988 RVA: 0x0026F0E4 File Offset: 0x0026D2E4
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChannelInvitationTypesReflection.descriptor;
			}
		}

		// Token: 0x0600A01D RID: 40989 RVA: 0x0026F0FC File Offset: 0x0026D2FC
		static ChannelInvitationTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjBiZ3MvbG93L3BiL2NsaWVudC9jaGFubmVsX2ludml0YXRpb25fdHlwZXMu", "cHJvdG8SF2Jncy5wcm90b2NvbC5jaGFubmVsLnYxGihiZ3MvbG93L3BiL2Ns", "aWVudC9pbnZpdGF0aW9uX3R5cGVzLnByb3RvGiRiZ3MvbG93L3BiL2NsaWVu", "dC9lbnRpdHlfdHlwZXMucHJvdG8aJWJncy9sb3cvcGIvY2xpZW50L2NoYW5u", "ZWxfdHlwZXMucHJvdG8iiQIKEUNoYW5uZWxJbnZpdGF0aW9uEkgKE2NoYW5u", "ZWxfZGVzY3JpcHRpb24YASACKAsyKy5iZ3MucHJvdG9jb2wuY2hhbm5lbC52", "MS5DaGFubmVsRGVzY3JpcHRpb24SFwoIcmVzZXJ2ZWQYAiABKAg6BWZhbHNl", "EhUKBnJlam9pbhgDIAEoCDoFZmFsc2USGAoMc2VydmljZV90eXBlGAQgAigN", "QgIYATJgChJjaGFubmVsX2ludml0YXRpb24SGC5iZ3MucHJvdG9jb2wuSW52", "aXRhdGlvbhhpIAEoCzIqLmJncy5wcm90b2NvbC5jaGFubmVsLnYxLkNoYW5u",
				"ZWxJbnZpdGF0aW9uIusBChdDaGFubmVsSW52aXRhdGlvblBhcmFtcxIqCgpj", "aGFubmVsX2lkGAEgAigLMhYuYmdzLnByb3RvY29sLkVudGl0eUlkEhAKCHJl", "c2VydmVkGAIgASgIEg4KBnJlam9pbhgDIAEoCBIYCgxzZXJ2aWNlX3R5cGUY", "BCACKA1CAhgBMmgKDmNoYW5uZWxfcGFyYW1zEh4uYmdzLnByb3RvY29sLklu", "dml0YXRpb25QYXJhbXMYaSABKAsyMC5iZ3MucHJvdG9jb2wuY2hhbm5lbC52", "MS5DaGFubmVsSW52aXRhdGlvblBhcmFtcyLOAQoUSW52aXRhdGlvblN1Z2dl", "c3Rpb24SKgoKY2hhbm5lbF9pZBgBIAEoCzIWLmJncy5wcm90b2NvbC5FbnRp", "dHlJZBIsCgxzdWdnZXN0ZXJfaWQYAiACKAsyFi5iZ3MucHJvdG9jb2wuRW50", "aXR5SWQSLAoMc3VnZ2VzdGVlX2lkGAMgAigLMhYuYmdzLnByb3RvY29sLkVu", "dGl0eUlkEhYKDnN1Z2dlc3Rlcl9uYW1lGAQgASgJEhYKDnN1Z2dlc3RlZV9u",
				"YW1lGAUgASgJIm8KDENoYW5uZWxDb3VudBIqCgpjaGFubmVsX2lkGAEgASgL", "MhYuYmdzLnByb3RvY29sLkVudGl0eUlkEh0KDGNoYW5uZWxfdHlwZRgCIAEo", "CToHZGVmYXVsdBIUCgxjaGFubmVsX25hbWUYAyABKAlCAkgB"
			}));
			ChannelInvitationTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				InvitationTypesReflection.Descriptor,
				EntityTypesReflection.Descriptor,
				ChannelTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ChannelInvitation), ChannelInvitation.Parser, new string[] { "ChannelDescription", "Reserved", "Rejoin", "ServiceType" }, null, null, new Extension[] { ChannelInvitation.Extensions.ChannelInvitation }, null),
				new GeneratedClrTypeInfo(typeof(ChannelInvitationParams), ChannelInvitationParams.Parser, new string[] { "ChannelId", "Reserved", "Rejoin", "ServiceType" }, null, null, new Extension[] { ChannelInvitationParams.Extensions.ChannelParams }, null),
				new GeneratedClrTypeInfo(typeof(InvitationSuggestion), InvitationSuggestion.Parser, new string[] { "ChannelId", "SuggesterId", "SuggesteeId", "SuggesterName", "SuggesteeName" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ChannelCount), ChannelCount.Parser, new string[] { "ChannelId", "ChannelType", "ChannelName" }, null, null, null, null)
			}));
		}

		// Token: 0x0400482F RID: 18479
		private static FileDescriptor descriptor;
	}
}
