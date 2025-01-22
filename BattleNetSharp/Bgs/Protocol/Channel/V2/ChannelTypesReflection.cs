using System;
using Bgs.Protocol.Account.V1;
using Bgs.Protocol.V2;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000684 RID: 1668
	public static class ChannelTypesReflection
	{
		// Token: 0x17003021 RID: 12321
		// (get) Token: 0x06009AC5 RID: 39621 RVA: 0x00259614 File Offset: 0x00257814
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.descriptor;
			}
		}

		// Token: 0x06009AC6 RID: 39622 RVA: 0x0025962C File Offset: 0x0025782C
		static ChannelTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjNiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL2NoYW5uZWxfdHlw", "ZXMucHJvdG8SF2Jncy5wcm90b2NvbC5jaGFubmVsLnYyGjViZ3MvbG93L3Bi", "L2NsaWVudC9hcGkvY2xpZW50L3YyL2F0dHJpYnV0ZV90eXBlcy5wcm90bxoy", "YmdzL2xvdy9wYi9jbGllbnQvYXBpL2NsaWVudC92Mi9jaGFubmVsX2VudW0u", "cHJvdG8aJWJncy9sb3cvcGIvY2xpZW50L2FjY291bnRfdHlwZXMucHJvdG8a", "KGJncy9sb3cvcGIvY2xpZW50L2NoYW5uZWxfcm9sZV9zZXQucHJvdG8aIWJn", "cy9sb3cvcGIvY2xpZW50L3JwY190eXBlcy5wcm90byJGCglDaGFubmVsSWQS", "JQoEaG9zdBgCIAEoCzIXLmJncy5wcm90b2NvbC5Qcm9jZXNzSWQSCgoCaWQY", "AyABKAc6BoL5KwIIASI6ChFVbmlxdWVDaGFubmVsVHlwZRIPCgdwcm9ncmFt", "GAIgASgHEhQKDGNoYW5uZWxfdHlwZRgDIAEoCSJhCg5Sb2xlQXNzaWdubWVu",
				"dBI9CgltZW1iZXJfaWQYASABKAsyKi5iZ3MucHJvdG9jb2wuYWNjb3VudC52", "MS5HYW1lQWNjb3VudEhhbmRsZRIQCgRyb2xlGAIgAygNQgIQASKDAQoTQXR0", "cmlidXRlQXNzaWdubWVudBI9CgltZW1iZXJfaWQYASABKAsyKi5iZ3MucHJv", "dG9jb2wuYWNjb3VudC52MS5HYW1lQWNjb3VudEhhbmRsZRItCglhdHRyaWJ1", "dGUYAiADKAsyGi5iZ3MucHJvdG9jb2wudjIuQXR0cmlidXRlIoMBChNDcmVh", "dGVNZW1iZXJPcHRpb25zEj0KCW1lbWJlcl9pZBgBIAEoCzIqLmJncy5wcm90", "b2NvbC5hY2NvdW50LnYxLkdhbWVBY2NvdW50SGFuZGxlEi0KCWF0dHJpYnV0", "ZRgDIAMoCzIaLmJncy5wcm90b2NvbC52Mi5BdHRyaWJ1dGUirwEKBk1lbWJl", "chI2CgJpZBgBIAEoCzIqLmJncy5wcm90b2NvbC5hY2NvdW50LnYxLkdhbWVB", "Y2NvdW50SGFuZGxlEhoKCmJhdHRsZV90YWcYAiABKAlCBoL5KwIIARIQCgh2",
				"b2ljZV9pZBgDIAEoCRIQCgRyb2xlGAQgAygNQgIQARItCglhdHRyaWJ1dGUY", "BSADKAsyGi5iZ3MucHJvdG9jb2wudjIuQXR0cmlidXRlIp0CChRDcmVhdGVD", "aGFubmVsT3B0aW9ucxI4CgR0eXBlGAEgASgLMiouYmdzLnByb3RvY29sLmNo", "YW5uZWwudjIuVW5pcXVlQ2hhbm5lbFR5cGUSDAoEbmFtZRgCIAEoCRJQCg1w", "cml2YWN5X2xldmVsGAMgASgOMiUuYmdzLnByb3RvY29sLmNoYW5uZWwudjIu", "UHJpdmFjeUxldmVsOhJQUklWQUNZX0xFVkVMX09QRU4SLQoJYXR0cmlidXRl", "GAQgAygLMhouYmdzLnByb3RvY29sLnYyLkF0dHJpYnV0ZRI8CgZtZW1iZXIY", "BSABKAsyLC5iZ3MucHJvdG9jb2wuY2hhbm5lbC52Mi5DcmVhdGVNZW1iZXJP", "cHRpb25zIm0KEVB1YmxpY0NoYW5uZWxUeXBlEjgKBHR5cGUYASABKAsyKi5i", "Z3MucHJvdG9jb2wuY2hhbm5lbC52Mi5VbmlxdWVDaGFubmVsVHlwZRIMCgRu",
				"YW1lGAIgASgJEhAKCGlkZW50aXR5GAMgASgJIlgKHEdldFB1YmxpY0NoYW5u", "ZWxUeXBlc09wdGlvbnMSOAoEdHlwZRgBIAEoCzIqLmJncy5wcm90b2NvbC5j", "aGFubmVsLnYyLlVuaXF1ZUNoYW5uZWxUeXBlIv0BChJGaW5kQ2hhbm5lbE9w", "dGlvbnMSOAoEdHlwZRgBIAEoCzIqLmJncy5wcm90b2NvbC5jaGFubmVsLnYy", "LlVuaXF1ZUNoYW5uZWxUeXBlEhAKCGlkZW50aXR5GAIgASgJEg4KBmxvY2Fs", "ZRgDIAEoBxI0ChBzZWFyY2hfYXR0cmlidXRlGAQgAygLMhouYmdzLnByb3Rv", "Y29sLnYyLkF0dHJpYnV0ZRJVCgtyZXNlcnZhdGlvbhgGIAMoCzIiLmJncy5w", "cm90b2NvbC5hY2NvdW50LnYxLkFjY291bnRJZEIcivkrBioECgIIAIr5KwYq", "BAoCEBSK+SsEKgIQASJUChJTZW5kTWVzc2FnZU9wdGlvbnMSDwoHY29udGVu", "dBgEIAEoCRItCglhdHRyaWJ1dGUYBSADKAsyGi5iZ3MucHJvdG9jb2wudjIu",
				"QXR0cmlidXRlIqYBCg5DaGFubmVsTWVzc2FnZRI9CglhdXRob3JfaWQYASAB", "KAsyKi5iZ3MucHJvdG9jb2wuYWNjb3VudC52MS5HYW1lQWNjb3VudEhhbmRs", "ZRIPCgdjb250ZW50GAMgASgJEi0KCWF0dHJpYnV0ZRgEIAMoCzIaLmJncy5w", "cm90b2NvbC52Mi5BdHRyaWJ1dGUSFQoNY3JlYXRpb25fdGltZRgFIAEoBCKl", "AQoSUHVibGljQ2hhbm5lbFN0YXRlEhAKCGlkZW50aXR5GAEgASgJEg4KBmxv", "Y2FsZRgCIAEoBxI0ChBzZWFyY2hfYXR0cmlidXRlGAMgAygLMhouYmdzLnBy", "b3RvY29sLnYyLkF0dHJpYnV0ZRI3CgtyZXNlcnZhdGlvbhgGIAMoCzIiLmJn", "cy5wcm90b2NvbC5hY2NvdW50LnYxLkFjY291bnRJZCKGBAoHQ2hhbm5lbBIu", "CgJpZBgBIAEoCzIiLmJncy5wcm90b2NvbC5jaGFubmVsLnYyLkNoYW5uZWxJ", "ZBI4CgR0eXBlGAIgASgLMiouYmdzLnByb3RvY29sLmNoYW5uZWwudjIuVW5p",
				"cXVlQ2hhbm5lbFR5cGUSDAoEbmFtZRgDIAEoCRJQCg1wcml2YWN5X2xldmVs", "GAQgASgOMiUuYmdzLnByb3RvY29sLmNoYW5uZWwudjIuUHJpdmFjeUxldmVs", "OhJQUklWQUNZX0xFVkVMX09QRU4SLQoJYXR0cmlidXRlGAUgAygLMhouYmdz", "LnByb3RvY29sLnYyLkF0dHJpYnV0ZRIvCgZtZW1iZXIYBiADKAsyHy5iZ3Mu", "cHJvdG9jb2wuY2hhbm5lbC52Mi5NZW1iZXISPgoKaW52aXRhdGlvbhgHIAMo", "CzIqLmJncy5wcm90b2NvbC5jaGFubmVsLnYyLkNoYW5uZWxJbnZpdGF0aW9u", "EjYKCHJvbGVfc2V0GAggASgLMiQuYmdzLnByb3RvY29sLmNoYW5uZWwuQ2hh", "bm5lbFJvbGVTZXQSSwoUcHVibGljX2NoYW5uZWxfc3RhdGUYbiABKAsyKy5i", "Z3MucHJvdG9jb2wuY2hhbm5lbC52Mi5QdWJsaWNDaGFubmVsU3RhdGVIAEIM", "CgpzdGF0ZV90eXBlIv4CChJDaGFubmVsRGVzY3JpcHRpb24SLgoCaWQYASAB",
				"KAsyIi5iZ3MucHJvdG9jb2wuY2hhbm5lbC52Mi5DaGFubmVsSWQSOAoEdHlw", "ZRgCIAEoCzIqLmJncy5wcm90b2NvbC5jaGFubmVsLnYyLlVuaXF1ZUNoYW5u", "ZWxUeXBlEgwKBG5hbWUYAyABKAkSUAoNcHJpdmFjeV9sZXZlbBgEIAEoDjIl", "LmJncy5wcm90b2NvbC5jaGFubmVsLnYyLlByaXZhY3lMZXZlbDoSUFJJVkFD", "WV9MRVZFTF9PUEVOEi0KCWF0dHJpYnV0ZRgFIAMoCzIaLmJncy5wcm90b2Nv", "bC52Mi5BdHRyaWJ1dGUSFAoMbWVtYmVyX2NvdW50GAYgASgNEksKFHB1Ymxp", "Y19jaGFubmVsX3N0YXRlGG4gASgLMisuYmdzLnByb3RvY29sLmNoYW5uZWwu", "djIuUHVibGljQ2hhbm5lbFN0YXRlSABCDAoKc3RhdGVfdHlwZSKaAQoWQ2hh", "bm5lbE1lbWJlcnNoaXBTdGF0ZRJACgtkZXNjcmlwdGlvbhgBIAMoCzIrLmJn", "cy5wcm90b2NvbC5jaGFubmVsLnYyLkNoYW5uZWxEZXNjcmlwdGlvbhI+Cgpp",
				"bnZpdGF0aW9uGAIgAygLMiouYmdzLnByb3RvY29sLmNoYW5uZWwudjIuQ2hh", "bm5lbEludml0YXRpb24iLwoLQ2hhbm5lbFNsb3QSEAoIcmVzZXJ2ZWQYASAB", "KAgSDgoGcmVqb2luGAIgASgIIswBChVTZW5kSW52aXRhdGlvbk9wdGlvbnMS", "QAoKY2hhbm5lbF9pZBgBIAEoCzIiLmJncy5wcm90b2NvbC5jaGFubmVsLnYy", "LkNoYW5uZWxJZEIIivkrBDICCAESPQoJdGFyZ2V0X2lkGAIgASgLMiouYmdz", "LnByb3RvY29sLmFjY291bnQudjEuR2FtZUFjY291bnRIYW5kbGUSMgoEc2xv", "dBgDIAEoCzIkLmJncy5wcm90b2NvbC5jaGFubmVsLnYyLkNoYW5uZWxTbG90", "ImcKEU1lbWJlckRlc2NyaXB0aW9uEjYKAmlkGAEgASgLMiouYmdzLnByb3Rv", "Y29sLmFjY291bnQudjEuR2FtZUFjY291bnRIYW5kbGUSGgoKYmF0dGxlX3Rh", "ZxgCIAEoCUIGgvkrAggBIrsCChFDaGFubmVsSW52aXRhdGlvbhIKCgJpZBgB",
				"IAEoBhI7CgdpbnZpdGVyGAIgASgLMiouYmdzLnByb3RvY29sLmNoYW5uZWwu", "djIuTWVtYmVyRGVzY3JpcHRpb24SOwoHaW52aXRlZRgDIAEoCzIqLmJncy5w", "cm90b2NvbC5jaGFubmVsLnYyLk1lbWJlckRlc2NyaXB0aW9uEjwKB2NoYW5u", "ZWwYBCABKAsyKy5iZ3MucHJvdG9jb2wuY2hhbm5lbC52Mi5DaGFubmVsRGVz", "Y3JpcHRpb24SMgoEc2xvdBgFIAEoCzIkLmJncy5wcm90b2NvbC5jaGFubmVs", "LnYyLkNoYW5uZWxTbG90EhUKDWNyZWF0aW9uX3RpbWUYByABKAQSFwoPZXhw", "aXJhdGlvbl90aW1lGAggASgEItkBChVTZW5kU3VnZ2VzdGlvbk9wdGlvbnMS", "QAoKY2hhbm5lbF9pZBgBIAEoCzIiLmJncy5wcm90b2NvbC5jaGFubmVsLnYy", "LkNoYW5uZWxJZEIIivkrBDICCAESPQoJdGFyZ2V0X2lkGAIgASgLMiouYmdz", "LnByb3RvY29sLmFjY291bnQudjEuR2FtZUFjY291bnRIYW5kbGUSPwoLYXBw",
				"cm92YWxfaWQYAyABKAsyKi5iZ3MucHJvdG9jb2wuYWNjb3VudC52MS5HYW1l", "QWNjb3VudEhhbmRsZSLZAQoKU3VnZ2VzdGlvbhI2CgpjaGFubmVsX2lkGAIg", "ASgLMiIuYmdzLnByb3RvY29sLmNoYW5uZWwudjIuQ2hhbm5lbElkEj0KCXN1", "Z2dlc3RlchgDIAEoCzIqLmJncy5wcm90b2NvbC5jaGFubmVsLnYyLk1lbWJl", "ckRlc2NyaXB0aW9uEj0KCXN1Z2dlc3RlZRgEIAEoCzIqLmJncy5wcm90b2Nv", "bC5jaGFubmVsLnYyLk1lbWJlckRlc2NyaXB0aW9uEhUKDWNyZWF0aW9uX3Rp", "bWUYByABKARQAFABUAI="
			}));
			ChannelTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				AttributeTypesReflection.Descriptor,
				ChannelEnumReflection.Descriptor,
				AccountTypesReflection.Descriptor,
				ChannelRoleSetReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ChannelId), ChannelId.Parser, new string[] { "Host", "Id" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UniqueChannelType), UniqueChannelType.Parser, new string[] { "Program", "ChannelType" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RoleAssignment), RoleAssignment.Parser, new string[] { "MemberId", "Role" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AttributeAssignment), AttributeAssignment.Parser, new string[] { "MemberId", "Attribute" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CreateMemberOptions), CreateMemberOptions.Parser, new string[] { "MemberId", "Attribute" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Member), Member.Parser, new string[] { "Id", "BattleTag", "VoiceId", "Role", "Attribute" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CreateChannelOptions), CreateChannelOptions.Parser, new string[] { "Type", "Name", "PrivacyLevel", "Attribute", "Member" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PublicChannelType), PublicChannelType.Parser, new string[] { "Type", "Name", "Identity" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetPublicChannelTypesOptions), GetPublicChannelTypesOptions.Parser, new string[] { "Type" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(FindChannelOptions), FindChannelOptions.Parser, new string[] { "Type", "Identity", "Locale", "SearchAttribute", "Reservation" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SendMessageOptions), SendMessageOptions.Parser, new string[] { "Content", "Attribute" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ChannelMessage), ChannelMessage.Parser, new string[] { "AuthorId", "Content", "Attribute", "CreationTime" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PublicChannelState), PublicChannelState.Parser, new string[] { "Identity", "Locale", "SearchAttribute", "Reservation" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Channel), Channel.Parser, new string[] { "Id", "Type", "Name", "PrivacyLevel", "Attribute", "Member", "Invitation", "RoleSet", "PublicChannelState" }, new string[] { "StateType" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(ChannelDescription), ChannelDescription.Parser, new string[] { "Id", "Type", "Name", "PrivacyLevel", "Attribute", "MemberCount", "PublicChannelState" }, new string[] { "StateType" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(ChannelMembershipState), ChannelMembershipState.Parser, new string[] { "Description", "Invitation" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ChannelSlot), ChannelSlot.Parser, new string[] { "Reserved", "Rejoin" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SendInvitationOptions), SendInvitationOptions.Parser, new string[] { "ChannelId", "TargetId", "Slot" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MemberDescription), MemberDescription.Parser, new string[] { "Id", "BattleTag" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ChannelInvitation), ChannelInvitation.Parser, new string[] { "Id", "Inviter", "Invitee", "Channel", "Slot", "CreationTime", "ExpirationTime" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SendSuggestionOptions), SendSuggestionOptions.Parser, new string[] { "ChannelId", "TargetId", "ApprovalId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Suggestion), Suggestion.Parser, new string[] { "ChannelId", "Suggester", "Suggestee", "CreationTime" }, null, null, null, null)
			}));
		}

		// Token: 0x040045D9 RID: 17881
		private static FileDescriptor descriptor;
	}
}
