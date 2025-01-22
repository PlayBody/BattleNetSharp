using System;
using Bgs.Protocol.V2;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200045B RID: 1115
	public static class ClubMemberReflection
	{
		// Token: 0x170022FB RID: 8955
		// (get) Token: 0x06006D25 RID: 27941 RVA: 0x001A8BC0 File Offset: 0x001A6DC0
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClubMemberReflection.descriptor;
			}
		}

		// Token: 0x06006D26 RID: 27942 RVA: 0x001A8BD8 File Offset: 0x001A6DD8
		static ClubMemberReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CiNiZ3MvbG93L3BiL2NsaWVudC9jbHViX21lbWJlci5wcm90bxIUYmdzLnBy", "b3RvY29sLmNsdWIudjEaJmJncy9sb3cvcGIvY2xpZW50L2NsdWJfbWVtYmVy", "X2lkLnByb3RvGjViZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL2F0", "dHJpYnV0ZV90eXBlcy5wcm90bxohYmdzL2xvdy9wYi9jbGllbnQvY2x1Yl9l", "bnVtLnByb3RvGiFiZ3MvbG93L3BiL2NsaWVudC9ycGNfdHlwZXMucHJvdG8i", "gQMKBk1lbWJlchIqCgJpZBgBIAEoCzIeLmJncy5wcm90b2NvbC5jbHViLnYx", "Lk1lbWJlcklkEhIKCmJhdHRsZV90YWcYAiABKAkSEAoEcm9sZRgDIAMoDUIC", "EAESLQoJYXR0cmlidXRlGAQgAygLMhouYmdzLnByb3RvY29sLnYyLkF0dHJp", "YnV0ZRIRCglqb2luX3RpbWUYBSABKAQSOwoOcHJlc2VuY2VfbGV2ZWwYBiAB", "KA4yIy5iZ3MucHJvdG9jb2wuY2x1Yi52MS5QcmVzZW5jZUxldmVsEhYKDm1v",
				"ZGVyYXRvcl9tdXRlGAcgASgIEjkKDXdoaXNwZXJfbGV2ZWwYCCABKA4yIi5i", "Z3MucHJvdG9jb2wuY2x1Yi52MS5XaGlzcGVyTGV2ZWwSDAoEbm90ZRgJIAEo", "CRIOCgZhY3RpdmUYMiABKAgSNQoFdm9pY2UYMyABKAsyJi5iZ3MucHJvdG9j", "b2wuY2x1Yi52MS5NZW1iZXJWb2ljZVN0YXRlIlEKDE1lbWJlclJlc3VsdBIx", "CgltZW1iZXJfaWQYASABKAsyHi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5NZW1i", "ZXJJZBIOCgZzdGF0dXMYAiABKA0iegoTUmVtb3ZlTWVtYmVyT3B0aW9ucxIq", "CgJpZBgBIAEoCzIeLmJncy5wcm90b2NvbC5jbHViLnYxLk1lbWJlcklkEjcK", "BnJlYXNvbhgCIAEoDjInLmJncy5wcm90b2NvbC5jbHViLnYxLkNsdWJSZW1v", "dmVkUmVhc29uIn4KF01lbWJlclJlbW92ZWRBc3NpZ25tZW50EioKAmlkGAEg", "ASgLMh4uYmdzLnByb3RvY29sLmNsdWIudjEuTWVtYmVySWQSNwoGcmVhc29u",
				"GAIgASgOMicuYmdzLnByb3RvY29sLmNsdWIudjEuQ2x1YlJlbW92ZWRSZWFz", "b24ihwEKEk1lbWJlclZvaWNlT3B0aW9ucxIRCglzdHJlYW1faWQYASABKAQS", "DgoGam9pbmVkGAIgASgIEj4KCm1pY3JvcGhvbmUYAyABKA4yKi5iZ3MucHJv", "dG9jb2wuY2x1Yi52MS5Wb2ljZU1pY3JvcGhvbmVTdGF0ZRIOCgZhY3RpdmUY", "BCABKAgikQEKEE1lbWJlclZvaWNlU3RhdGUSCgoCaWQYASABKAkSEQoJc3Ry", "ZWFtX2lkGAIgASgEEg4KBmpvaW5lZBgDIAEoCBI+CgptaWNyb3Bob25lGAQg", "ASgOMiouYmdzLnByb3RvY29sLmNsdWIudjEuVm9pY2VNaWNyb3Bob25lU3Rh", "dGUSDgoGYWN0aXZlGAUgASgIIooBChNDcmVhdGVNZW1iZXJPcHRpb25zEioK", "AmlkGAEgASgLMh4uYmdzLnByb3RvY29sLmNsdWIudjEuTWVtYmVySWQSLQoJ", "YXR0cmlidXRlGAIgAygLMhouYmdzLnByb3RvY29sLnYyLkF0dHJpYnV0ZRIY",
				"ChBqb2luX2NsdWJfc291cmNlGAMgASgNIlMKEU1lbWJlckRlc2NyaXB0aW9u", "EioKAmlkGAEgASgLMh4uYmdzLnByb3RvY29sLmNsdWIudjEuTWVtYmVySWQS", "EgoKYmF0dGxlX3RhZxgCIAEoCSJSCgtSb2xlT3B0aW9ucxIxCgltZW1iZXJf", "aWQYASABKAsyHi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5NZW1iZXJJZBIQCgRy", "b2xlGAIgAygNQgIQASJVCg5Sb2xlQXNzaWdubWVudBIxCgltZW1iZXJfaWQY", "ASABKAsyHi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5NZW1iZXJJZBIQCgRyb2xl", "GAIgAygNQgIQASJ9ChlNZW1iZXJBdHRyaWJ1dGVBc3NpZ25tZW50EjEKCW1l", "bWJlcl9pZBgBIAEoCzIeLmJncy5wcm90b2NvbC5jbHViLnYxLk1lbWJlcklk", "Ei0KCWF0dHJpYnV0ZRgCIAMoCzIaLmJncy5wcm90b2NvbC52Mi5BdHRyaWJ1", "dGUiUQoWU3Vic2NyaWJlclN0YXRlT3B0aW9ucxI3CgV2b2ljZRgBIAEoCzIo",
				"LmJncy5wcm90b2NvbC5jbHViLnYxLk1lbWJlclZvaWNlT3B0aW9ucyKVAQoZ", "U3Vic2NyaWJlclN0YXRlQXNzaWdubWVudBIxCgltZW1iZXJfaWQYASABKAsy", "Hi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5NZW1iZXJJZBIOCgZhY3RpdmUYAiAB", "KAgSNQoFdm9pY2UYAyABKAsyJi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5NZW1i", "ZXJWb2ljZVN0YXRlIuEBChJNZW1iZXJTdGF0ZU9wdGlvbnMSLQoJYXR0cmli", "dXRlGAEgAygLMhouYmdzLnByb3RvY29sLnYyLkF0dHJpYnV0ZRI7Cg5wcmVz", "ZW5jZV9sZXZlbBgCIAEoDjIjLmJncy5wcm90b2NvbC5jbHViLnYxLlByZXNl", "bmNlTGV2ZWwSFgoObW9kZXJhdG9yX211dGUYAyABKAgSOQoNd2hpc3Blcl9s", "ZXZlbBgEIAEoDjIiLmJncy5wcm90b2NvbC5jbHViLnYxLldoaXNwZXJMZXZl", "bBIMCgRub3RlGAUgASgJIpcCChVNZW1iZXJTdGF0ZUFzc2lnbm1lbnQSMQoJ",
				"bWVtYmVyX2lkGAEgASgLMh4uYmdzLnByb3RvY29sLmNsdWIudjEuTWVtYmVy", "SWQSLQoJYXR0cmlidXRlGAIgAygLMhouYmdzLnByb3RvY29sLnYyLkF0dHJp", "YnV0ZRI7Cg5wcmVzZW5jZV9sZXZlbBgDIAEoDjIjLmJncy5wcm90b2NvbC5j", "bHViLnYxLlByZXNlbmNlTGV2ZWwSFgoObW9kZXJhdG9yX211dGUYBCABKAgS", "OQoNd2hpc3Blcl9sZXZlbBgFIAEoDjIiLmJncy5wcm90b2NvbC5jbHViLnYx", "LldoaXNwZXJMZXZlbBIMCgRub3RlGAYgASgJUAA="
			}));
			ClubMemberReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				ClubMemberIdReflection.Descriptor,
				AttributeTypesReflection.Descriptor,
				ClubEnumReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(Member), Member.Parser, new string[]
				{
					"Id", "BattleTag", "Role", "Attribute", "JoinTime", "PresenceLevel", "ModeratorMute", "WhisperLevel", "Note", "Active",
					"Voice"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MemberResult), MemberResult.Parser, new string[] { "MemberId", "Status" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RemoveMemberOptions), RemoveMemberOptions.Parser, new string[] { "Id", "Reason" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MemberRemovedAssignment), MemberRemovedAssignment.Parser, new string[] { "Id", "Reason" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MemberVoiceOptions), MemberVoiceOptions.Parser, new string[] { "StreamId", "Joined", "Microphone", "Active" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MemberVoiceState), MemberVoiceState.Parser, new string[] { "Id", "StreamId", "Joined", "Microphone", "Active" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CreateMemberOptions), CreateMemberOptions.Parser, new string[] { "Id", "Attribute", "JoinClubSource" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MemberDescription), MemberDescription.Parser, new string[] { "Id", "BattleTag" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RoleOptions), RoleOptions.Parser, new string[] { "MemberId", "Role" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RoleAssignment), RoleAssignment.Parser, new string[] { "MemberId", "Role" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MemberAttributeAssignment), MemberAttributeAssignment.Parser, new string[] { "MemberId", "Attribute" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SubscriberStateOptions), SubscriberStateOptions.Parser, new string[] { "Voice" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SubscriberStateAssignment), SubscriberStateAssignment.Parser, new string[] { "MemberId", "Active", "Voice" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MemberStateOptions), MemberStateOptions.Parser, new string[] { "Attribute", "PresenceLevel", "ModeratorMute", "WhisperLevel", "Note" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MemberStateAssignment), MemberStateAssignment.Parser, new string[] { "MemberId", "Attribute", "PresenceLevel", "ModeratorMute", "WhisperLevel", "Note" }, null, null, null, null)
			}));
		}

		// Token: 0x04003233 RID: 12851
		private static FileDescriptor descriptor;
	}
}
