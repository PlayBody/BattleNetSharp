using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x0200037D RID: 893
	public static class InvitationTypesReflection
	{
		// Token: 0x17001D84 RID: 7556
		// (get) Token: 0x06005B19 RID: 23321 RVA: 0x001605DC File Offset: 0x0015E7DC
		public static FileDescriptor Descriptor
		{
			get
			{
				return InvitationTypesReflection.descriptor;
			}
		}

		// Token: 0x06005B1A RID: 23322 RVA: 0x001605F4 File Offset: 0x0015E7F4
		static InvitationTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CihiZ3MvbG93L3BiL2NsaWVudC9pbnZpdGF0aW9uX3R5cGVzLnByb3RvEgxi", "Z3MucHJvdG9jb2waJGJncy9sb3cvcGIvY2xpZW50L2VudGl0eV90eXBlcy5w", "cm90byL7AQoKSW52aXRhdGlvbhIKCgJpZBgBIAIoBhIwChBpbnZpdGVyX2lk", "ZW50aXR5GAIgAigLMhYuYmdzLnByb3RvY29sLklkZW50aXR5EjAKEGludml0", "ZWVfaWRlbnRpdHkYAyACKAsyFi5iZ3MucHJvdG9jb2wuSWRlbnRpdHkSFAoM", "aW52aXRlcl9uYW1lGAQgASgJEhQKDGludml0ZWVfbmFtZRgFIAEoCRIaChJp", "bnZpdGF0aW9uX21lc3NhZ2UYBiABKAkSFQoNY3JlYXRpb25fdGltZRgHIAEo", "BBIXCg9leHBpcmF0aW9uX3RpbWUYCCABKAQqBQhkEJBOIjMKBHRlc3QSGQoR", "dGFyZ2V0X2JhdHRsZV90YWcYAiABKAkSEAoEcm9sZRgGIAMoDUICEAEifQoQ", "SW52aXRhdGlvblBhcmFtcxIeChJpbnZpdGF0aW9uX21lc3NhZ2UYASABKAlC",
				"AhgBEhcKD2V4cGlyYXRpb25fdGltZRgCIAEoBBIpCg1mcmllbmRfcGFyYW1z", "GGcgASgLMhIuYmdzLnByb3RvY29sLnRlc3QqBQhoEJBOKoYCChdJbnZpdGF0", "aW9uUmVtb3ZlZFJlYXNvbhImCiJJTlZJVEFUSU9OX1JFTU9WRURfUkVBU09O", "X0FDQ0VQVEVEEAASJgoiSU5WSVRBVElPTl9SRU1PVkVEX1JFQVNPTl9ERUNM", "SU5FRBABEiUKIUlOVklUQVRJT05fUkVNT1ZFRF9SRUFTT05fUkVWT0tFRBAC", "EiUKIUlOVklUQVRJT05fUkVNT1ZFRF9SRUFTT05fSUdOT1JFRBADEiUKIUlO", "VklUQVRJT05fUkVNT1ZFRF9SRUFTT05fRVhQSVJFRBAEEiYKIklOVklUQVRJ", "T05fUkVNT1ZFRF9SRUFTT05fQ0FOQ0VMRUQQBSq4AQoXU3VnZ2VzdGlvblJl", "bW92ZWRSZWFzb24SJgoiU1VHR0VTVElPTl9SRU1PVkVEX1JFQVNPTl9BUFBS", "T1ZFRBAAEiYKIlNVR0dFU1RJT05fUkVNT1ZFRF9SRUFTT05fREVDTElORUQQ",
				"ARIlCiFTVUdHRVNUSU9OX1JFTU9WRURfUkVBU09OX0VYUElSRUQQAhImCiJT", "VUdHRVNUSU9OX1JFTU9WRURfUkVBU09OX0NBTkNFTEVEEANCJwoNYm5ldC5w", "cm90b2NvbEIUSW52aXRhdGlvblR5cGVzUHJvdG9IAQ=="
			}));
			InvitationTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { EntityTypesReflection.Descriptor }, new GeneratedClrTypeInfo(new Type[]
			{
				typeof(InvitationRemovedReason),
				typeof(SuggestionRemovedReason)
			}, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(Invitation), Invitation.Parser, new string[] { "Id", "InviterIdentity", "InviteeIdentity", "InviterName", "InviteeName", "InvitationMessage", "CreationTime", "ExpirationTime" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(test), test.Parser, new string[] { "TargetBattleTag", "Role" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(InvitationParams), InvitationParams.Parser, new string[] { "InvitationMessage", "ExpirationTime", "FriendParams" }, null, null, null, null)
			}));
		}

		// Token: 0x04002989 RID: 10633
		private static FileDescriptor descriptor;
	}
}
