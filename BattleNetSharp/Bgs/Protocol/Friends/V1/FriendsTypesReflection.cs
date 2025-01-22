using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Friends.V1
{
	// Token: 0x02000418 RID: 1048
	public static class FriendsTypesReflection
	{
		// Token: 0x17002103 RID: 8451
		// (get) Token: 0x06006746 RID: 26438 RVA: 0x0018FAB8 File Offset: 0x0018DCB8
		public static FileDescriptor Descriptor
		{
			get
			{
				return FriendsTypesReflection.descriptor;
			}
		}

		// Token: 0x06006747 RID: 26439 RVA: 0x0018FAD0 File Offset: 0x0018DCD0
		static FriendsTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CiViZ3MvbG93L3BiL2NsaWVudC9mcmllbmRzX3R5cGVzLnByb3RvEhdiZ3Mu", "cHJvdG9jb2wuZnJpZW5kcy52MRo3YmdzL2xvdy9wYi9jbGllbnQvZ2xvYmFs", "X2V4dGVuc2lvbnMvZmllbGRfb3B0aW9ucy5wcm90bxonYmdzL2xvdy9wYi9j", "bGllbnQvYXR0cmlidXRlX3R5cGVzLnByb3RvGiRiZ3MvbG93L3BiL2NsaWVu", "dC9lbnRpdHlfdHlwZXMucHJvdG8aKGJncy9sb3cvcGIvY2xpZW50L2ludml0", "YXRpb25fdHlwZXMucHJvdG8aImJncy9sb3cvcGIvY2xpZW50L3JvbGVfdHlw", "ZXMucHJvdG8iuwEKBkZyaWVuZBIqCgphY2NvdW50X2lkGAEgAigLMhYuYmdz", "LnByb3RvY29sLkVudGl0eUlkEioKCWF0dHJpYnV0ZRgCIAMoCzIXLmJncy5w", "cm90b2NvbC5BdHRyaWJ1dGUSEAoEcm9sZRgDIAMoDUICEAESEgoKcHJpdmls", "ZWdlcxgEIAEoBBIcChBhdHRyaWJ1dGVzX2Vwb2NoGAUgASgEQgIYARIVCg1j",
				"cmVhdGlvbl90aW1lGAYgASgEIq0BCg5GcmllbmRPZkZyaWVuZBIqCgphY2Nv", "dW50X2lkGAEgASgLMhYuYmdzLnByb3RvY29sLkVudGl0eUlkEiQKBHJvbGUY", "AyADKA1CFhABivkrBioECgIIAYr5KwYqBAoCEAESEgoKcHJpdmlsZWdlcxgE", "IAEoBBIZCglmdWxsX25hbWUYBiABKAlCBoL5KwIIARIaCgpiYXR0bGVfdGFn", "GAcgASgJQgaC+SsCCAEi3wEKElJlY2VpdmVkSW52aXRhdGlvbhIKCgJpZBgB", "IAIoBhIwChBpbnZpdGVyX2lkZW50aXR5GAIgAigLMhYuYmdzLnByb3RvY29s", "LklkZW50aXR5EjAKEGludml0ZWVfaWRlbnRpdHkYAyACKAsyFi5iZ3MucHJv", "dG9jb2wuSWRlbnRpdHkSFAoMaW52aXRlcl9uYW1lGAQgASgJEhQKDGludml0", "ZWVfbmFtZRgFIAEoCRIVCg1jcmVhdGlvbl90aW1lGAcgASgEEg8KB3Byb2dy", "YW0YCSABKAcqBQhkEJFOImQKEEZyaWVuZEludml0YXRpb24SJAoEcm9sZRgC",
				"IAMoDUIWEAGK+SsGKgQKAggBivkrBioECgIQARIqCglhdHRyaWJ1dGUYAyAD", "KAsyFy5iZ3MucHJvdG9jb2wuQXR0cmlidXRlIpMBCg5TZW50SW52aXRhdGlv", "bhIKCgJpZBgBIAEoBhITCgt0YXJnZXRfbmFtZRgCIAEoCRIMCgRyb2xlGAMg", "ASgNEioKCWF0dHJpYnV0ZRgEIAMoCzIXLmJncy5wcm90b2NvbC5BdHRyaWJ1", "dGUSFQoNY3JlYXRpb25fdGltZRgFIAEoBBIPCgdwcm9ncmFtGAYgASgHIvIB", "ChZGcmllbmRJbnZpdGF0aW9uUGFyYW1zEhwKDHRhcmdldF9lbWFpbBgBIAEo", "CUIGgvkrAggBEiEKEXRhcmdldF9iYXR0bGVfdGFnGAIgASgJQgaC+SsCCAES", "JAoEcm9sZRgGIAMoDUIWEAGK+SsGKgQKAggBivkrBioECgIQARIqCglhdHRy", "aWJ1dGUYCCADKAsyFy5iZ3MucHJvdG9jb2wuQXR0cmlidXRlEhMKC3Rhcmdl", "dF9uYW1lGAkgASgJEhMKB3Byb2dyYW0YCiABKAdCAhgBEhsKE3RhcmdldF9w",
				"aG9uZV9udW1iZXIYCyABKAkiygIKEVN1YnNjcmliZVJlc3BvbnNlEhMKC21h", "eF9mcmllbmRzGAEgASgNEiAKGG1heF9yZWNlaXZlZF9pbnZpdGF0aW9ucxgC", "IAEoDRIcChRtYXhfc2VudF9pbnZpdGF0aW9ucxgDIAEoDRIgCgRyb2xlGAQg", "AygLMhIuYmdzLnByb3RvY29sLlJvbGUSMAoHZnJpZW5kcxgFIAMoCzIfLmJn", "cy5wcm90b2NvbC5mcmllbmRzLnYxLkZyaWVuZBJJChRyZWNlaXZlZF9pbnZp", "dGF0aW9ucxgHIAMoCzIrLmJncy5wcm90b2NvbC5mcmllbmRzLnYxLlJlY2Vp", "dmVkSW52aXRhdGlvbhJBChBzZW50X2ludml0YXRpb25zGAggAygLMicuYmdz", "LnByb3RvY29sLmZyaWVuZHMudjEuU2VudEludml0YXRpb24iTgoXQWNjZXB0", "SW52aXRhdGlvbk9wdGlvbnMSIgoEcm9sZRgBIAEoDUIUivkrBhIECgIIAIr5", "KwYSBAoCEAISDwoHcHJvZ3JhbRgCIAEoB0IsChdiZ3MucHJvdG9jb2wuZnJp",
				"ZW5kcy52MUIRRnJpZW5kc1R5cGVzUHJvdG9QAA=="
			}));
			FriendsTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				FieldOptionsReflection.Descriptor,
				AttributeTypesReflection.Descriptor,
				EntityTypesReflection.Descriptor,
				InvitationTypesReflection.Descriptor,
				RoleTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(Friend), Friend.Parser, new string[] { "AccountId", "Attribute", "Role", "Privileges", "AttributesEpoch", "CreationTime" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(FriendOfFriend), FriendOfFriend.Parser, new string[] { "AccountId", "Role", "Privileges", "FullName", "BattleTag" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ReceivedInvitation), ReceivedInvitation.Parser, new string[] { "Id", "InviterIdentity", "InviteeIdentity", "InviterName", "InviteeName", "CreationTime", "Program" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(FriendInvitation), FriendInvitation.Parser, new string[] { "Role", "Attribute" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SentInvitation), SentInvitation.Parser, new string[] { "Id", "TargetName", "Role", "Attribute", "CreationTime", "Program" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(FriendInvitationParams), FriendInvitationParams.Parser, new string[] { "TargetEmail", "TargetBattleTag", "Role", "Attribute", "TargetName", "Program", "TargetPhoneNumber" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SubscribeResponse), SubscribeResponse.Parser, new string[] { "MaxFriends", "MaxReceivedInvitations", "MaxSentInvitations", "Role", "Friends", "ReceivedInvitations", "SentInvitations" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AcceptInvitationOptions), AcceptInvitationOptions.Parser, new string[] { "Role", "Program" }, null, null, null, null)
			}));
		}

		// Token: 0x04002EF4 RID: 12020
		private static FileDescriptor descriptor;
	}
}
