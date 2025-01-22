using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004EE RID: 1262
	public static class ClubRoleReflection
	{
		// Token: 0x170026D9 RID: 9945
		// (get) Token: 0x06007ABE RID: 31422 RVA: 0x001DCD64 File Offset: 0x001DAF64
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClubRoleReflection.descriptor;
			}
		}

		// Token: 0x06007ABF RID: 31423 RVA: 0x001DCD7C File Offset: 0x001DAF7C
		static ClubRoleReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CiFiZ3MvbG93L3BiL2NsaWVudC9jbHViX3JvbGUucHJvdG8SFGJncy5wcm90", "b2NvbC5jbHViLnYxGiJiZ3MvbG93L3BiL2NsaWVudC9yb2xlX3R5cGVzLnBy", "b3RvIq8LChBDbHViUHJpdmlsZWdlU2V0EhMKC2Nhbl9kZXN0cm95GAEgASgI", "EhkKEWNhbl9zZXRfYXR0cmlidXRlGAogASgIEhQKDGNhbl9zZXRfbmFtZRgL", "IAEoCBIbChNjYW5fc2V0X2Rlc2NyaXB0aW9uGAwgASgIEhYKDmNhbl9zZXRf", "YXZhdGFyGA0gASgIEhkKEWNhbl9zZXRfYnJvYWRjYXN0GA4gASgIEh0KFWNh", "bl9zZXRfcHJpdmFjeV9sZXZlbBgPIAEoCBIXCg9jYW5fa2lja19tZW1iZXIY", "HiABKAgSJAocY2FuX3NldF9vd25fbWVtYmVyX2F0dHJpYnV0ZRgfIAEoCBIm", "Ch5jYW5fc2V0X290aGVyX21lbWJlcl9hdHRyaWJ1dGUYICABKAgSHwoXY2Fu", "X3NldF9vd25fdm9pY2Vfc3RhdGUYISABKAgSIgoaY2FuX3NldF9vd25fcHJl",
				"c2VuY2VfbGV2ZWwYIiABKAgSIQoZY2FuX3NldF9vd25fd2hpc3Blcl9sZXZl", "bBgjIAEoCBIfChdjYW5fc2V0X293bl9tZW1iZXJfbm90ZRgkIAEoCBIhChlj", "YW5fc2V0X290aGVyX21lbWJlcl9ub3RlGCUgASgIEhUKDWNhbl91c2Vfdm9p", "Y2UYMiABKAgSJQodY2FuX3ZvaWNlX211dGVfbWVtYmVyX2Zvcl9hbGwYMyAB", "KAgSGgoSY2FuX2dldF9pbnZpdGF0aW9uGEYgASgIEhsKE2Nhbl9zZW5kX2lu", "dml0YXRpb24YRyABKAgSIQoZY2FuX3NlbmRfZ3Vlc3RfaW52aXRhdGlvbhhI", "IAEoCBIhChljYW5fcmV2b2tlX293bl9pbnZpdGF0aW9uGEkgASgIEiMKG2Nh", "bl9yZXZva2Vfb3RoZXJfaW52aXRhdGlvbhhKIAEoCBIaChJjYW5fZ2V0X3N1", "Z2dlc3Rpb24YWiABKAgSGgoSY2FuX3N1Z2dlc3RfbWVtYmVyGFsgASgIEhoK", "EmNhbl9hcHByb3ZlX21lbWJlchhcIAEoCBIWCg5jYW5fZ2V0X3RpY2tldBhu",
				"IAEoCBIZChFjYW5fY3JlYXRlX3RpY2tldBhvIAEoCBIaChJjYW5fZGVzdHJv", "eV90aWNrZXQYcCABKAgSFAoLY2FuX2dldF9iYW4YggEgASgIEhQKC2Nhbl9h", "ZGRfYmFuGIMBIAEoCBIXCg5jYW5fcmVtb3ZlX2JhbhiEASABKAgSGgoRY2Fu", "X2NyZWF0ZV9zdHJlYW0YjAEgASgIEhsKEmNhbl9kZXN0cm95X3N0cmVhbRiN", "ASABKAgSIAoXY2FuX3NldF9zdHJlYW1fcG9zaXRpb24YjgEgASgIEiEKGGNh", "bl9zZXRfc3RyZWFtX2F0dHJpYnV0ZRiPASABKAgSHAoTY2FuX3NldF9zdHJl", "YW1fbmFtZRiQASABKAgSHwoWY2FuX3NldF9zdHJlYW1fc3ViamVjdBiRASAB", "KAgSHgoVY2FuX3NldF9zdHJlYW1fYWNjZXNzGJIBIAEoCBIjChpjYW5fc2V0", "X3N0cmVhbV92b2ljZV9sZXZlbBiTASABKAgSGwoSY2FuX2NyZWF0ZV9tZXNz", "YWdlGLQBIAEoCBIgChdjYW5fZGVzdHJveV9vd25fbWVzc2FnZRi1ASABKAgS",
				"IgoZY2FuX2Rlc3Ryb3lfb3RoZXJfbWVzc2FnZRi2ASABKAgSHQoUY2FuX2Vk", "aXRfb3duX21lc3NhZ2UYtwEgASgIEhgKD2Nhbl9waW5fbWVzc2FnZRi4ASAB", "KAgSGAoPY2FuX21lbnRpb25fYWxsGLkBIAEoCBIZChBjYW5fbWVudGlvbl9o", "ZXJlGLoBIAEoCBIbChJjYW5fbWVudGlvbl9tZW1iZXIYuwEgASgIEhkKEGNh", "bl9tZW50aW9uX3JvbGUYvAEgASgIIrkBCghDbHViUm9sZRIKCgJpZBgBIAEo", "DRImCgVzdGF0ZRgCIAEoCzIXLmJncy5wcm90b2NvbC5Sb2xlU3RhdGUSOQoJ", "cHJpdmlsZWdlGAMgASgLMiYuYmdzLnByb3RvY29sLmNsdWIudjEuQ2x1YlBy", "aXZpbGVnZVNldBIiChphbHdheXNfZ3JhbnRfc3RyZWFtX2FjY2VzcxgEIAEo", "CBIaChJhbGxvd19pbl9jbHViX3Nsb3QYBSABKAgilAEKC0NsdWJSb2xlU2V0", "EiwKBHJvbGUYASADKAsyHi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5DbHViUm9s",
				"ZRIYCgxkZWZhdWx0X3JvbGUYBSADKA1CAhABEiwKJGFzc2lnbm1lbnRfcmVz", "cGVjdHNfcmVsZWdhdGlvbl9jaGFpbhgGIAEoCBIPCgdzdWJ0eXBlGAcgASgJ"
			}));
			ClubRoleReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { RoleTypesReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ClubPrivilegeSet), ClubPrivilegeSet.Parser, new string[]
				{
					"CanDestroy", "CanSetAttribute", "CanSetName", "CanSetDescription", "CanSetAvatar", "CanSetBroadcast", "CanSetPrivacyLevel", "CanKickMember", "CanSetOwnMemberAttribute", "CanSetOtherMemberAttribute",
					"CanSetOwnVoiceState", "CanSetOwnPresenceLevel", "CanSetOwnWhisperLevel", "CanSetOwnMemberNote", "CanSetOtherMemberNote", "CanUseVoice", "CanVoiceMuteMemberForAll", "CanGetInvitation", "CanSendInvitation", "CanSendGuestInvitation",
					"CanRevokeOwnInvitation", "CanRevokeOtherInvitation", "CanGetSuggestion", "CanSuggestMember", "CanApproveMember", "CanGetTicket", "CanCreateTicket", "CanDestroyTicket", "CanGetBan", "CanAddBan",
					"CanRemoveBan", "CanCreateStream", "CanDestroyStream", "CanSetStreamPosition", "CanSetStreamAttribute", "CanSetStreamName", "CanSetStreamSubject", "CanSetStreamAccess", "CanSetStreamVoiceLevel", "CanCreateMessage",
					"CanDestroyOwnMessage", "CanDestroyOtherMessage", "CanEditOwnMessage", "CanPinMessage", "CanMentionAll", "CanMentionHere", "CanMentionMember", "CanMentionRole"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClubRole), ClubRole.Parser, new string[] { "Id", "State", "Privilege", "AlwaysGrantStreamAccess", "AllowInClubSlot" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClubRoleSet), ClubRoleSet.Parser, new string[] { "Role", "DefaultRole", "AssignmentRespectsRelegationChain", "Subtype" }, null, null, null, null)
			}));
		}

		// Token: 0x04003799 RID: 14233
		private static FileDescriptor descriptor;
	}
}
