using System;
using Fenris.Hero;
using Fenris.Online;
using Google.Protobuf.Reflection;

namespace Fenris.Party
{
	// Token: 0x02000139 RID: 313
	public static class PartyReflection
	{
		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06001FE5 RID: 8165 RVA: 0x0007BA3C File Offset: 0x00079C3C
		public static FileDescriptor Descriptor
		{
			get
			{
				return PartyReflection.descriptor;
			}
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x0007BA54 File Offset: 0x00079C54
		static PartyReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CgtQYXJ0eS5wcm90bxIMRmVucmlzLlBhcnR5GhJPbmxpbmVDb21tb24ucHJv", "dG8aDE9ubGluZS5wcm90bxoKSGVyby5wcm90bxoQSGVyb0NvbW1vbi5wcm90", "byK0BgoLUGFydHlNZW1iZXISFwoPYm5ldF9hY2NvdW50X2lkGAEgASgNEhcK", "D2dhbWVfYWNjb3VudF9pZBgTIAEoDRIPCgdoZXJvX2lkGAIgASgJEhQKDGFj", "Y291bnRfbmFtZRgDIAEoCRISCgpoZXJvX2NsYXNzGAQgASgFEhIKCmhlcm9f", "ZmxhZ3MYBSABKA0SEgoKaGVyb19sZXZlbBgGIAEoDRIRCglpc19sZWFkZXIY", "ByABKAgSEAoIcGFydHlfaWQYCCABKAkSEAoIZ3JvdXBfaWQYCiABKA0SEgoK", "eF9wb3NpdGlvbhgLIAEoBRISCgp5X3Bvc2l0aW9uGAwgASgFEhEKCXdvcmxk", "X3NubxgNIAEoDxIVCg1sZXZlbGFyZWFfc25vGA4gASgPEhgKEGhpdHBvaW50", "X3BlcmNlbnQYFiABKAISEwoLc2VydmVyX3Bvb2wYDyABKAkSNgoQdmlzdWFs",
				"X2VxdWlwbWVudBgQIAEoCzIcLkZlbnJpcy5IZXJvLlZpc3VhbEVxdWlwbWVu", "dBI4CgphcHBlYXJhbmNlGBEgASgLMiQuRmVucmlzLkhlcm8uQXBwZWFyYW5j", "ZUN1c3RvbWl6YXRpb24SOAoQcGxhdGZvcm1fYWNjb3VudBgSIAEoCzIeLkZl", "bnJpcy5PbmxpbmUuUGxhdGZvcm1BY2NvdW50EjIKDmNhbXBhaWduX3N0YXRl", "GBUgASgLMhouRmVucmlzLkhlcm8uQ2FtcGFpZ25TdGF0ZRIXCg9yZXR1cm5f", "cGFydHlfaWQYFyABKAkSLgoMbWFwX3Bpbl9kYXRhGBggASgLMhguRmVucmlz", "LlBhcnR5Lk1hcFBpbkRhdGESHAoUaXNfY3Jvc3NwbGF5X2VuYWJsZWQYGSAB", "KAgSIwobZGlzY29ubmVjdGVkX2Zyb21fZ2FtZV90aW1lGBogASgDEh4KFmlz", "X211bHRpcGxheWVyX2FsbG93ZWQYGyABKAgSGQoObWF4X3dvcmxkX3RpZXIY", "HCABKAU6ATESEQoJaGVyb19uYW1lGB0gASgJEh4KFmNhbl9zZXRfY2FtcGFp",
				"Z25fc3RhdGUYHiABKAgiWQoKTWFwUGluRGF0YRISCgp4X3Bvc2l0aW9uGAEg", "ASgFEhIKCnlfcG9zaXRpb24YAiABKAUSEQoJd29ybGRfc25vGAMgASgPEhAK", "CGNvbG9yX2lkGAQgASgFIpIBCgtQYXJ0eUludml0ZRIRCglpbnZpdGVfaWQY", "ASABKAQSGAoQaW52aXRlcl9wYXJ0eV9pZBgCIAEoCRIfChdpbnZpdGVlX2dh", "bWVfYWNjb3VudF9pZBgDIAEoDRIUCgxpbnZpdGVyX25hbWUYBCABKAkSHwoX", "aW52aXRlcl9nYW1lX2FjY291bnRfaWQYBSABKA0ijAEKFk91dHN0YW5kaW5n", "UGFydHlJbnZpdGUSEQoJaW52aXRlX2lkGAEgASgEEi8KDHBhcnR5X2ludml0", "ZRgCIAEoCzIZLkZlbnJpcy5QYXJ0eS5QYXJ0eUludml0ZRIUCgxjcmVhdGVk", "X3RpbWUYAyABKAQSGAoQaW52aXRlZV9wYXJ0eV9pZBgEIAEoCQ=="
			}));
			PartyReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				OnlineCommonReflection.Descriptor,
				OnlineReflection.Descriptor,
				HeroReflection.Descriptor,
				HeroCommonReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(PartyMember), PartyMember.Parser, new string[]
				{
					"BnetAccountId", "GameAccountId", "HeroId", "AccountName", "HeroClass", "HeroFlags", "HeroLevel", "IsLeader", "PartyId", "GroupId",
					"XPosition", "YPosition", "WorldSno", "LevelareaSno", "HitpointPercent", "ServerPool", "VisualEquipment", "Appearance", "PlatformAccount", "CampaignState",
					"ReturnPartyId", "MapPinData", "IsCrossplayEnabled", "DisconnectedFromGameTime", "IsMultiplayerAllowed", "MaxWorldTier", "HeroName", "CanSetCampaignState"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MapPinData), MapPinData.Parser, new string[] { "XPosition", "YPosition", "WorldSno", "ColorId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PartyInvite), PartyInvite.Parser, new string[] { "InviteId", "InviterPartyId", "InviteeGameAccountId", "InviterName", "InviterGameAccountId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(OutstandingPartyInvite), OutstandingPartyInvite.Parser, new string[] { "InviteId", "PartyInvite", "CreatedTime", "InviteePartyId" }, null, null, null, null)
			}));
		}

		// Token: 0x04000DF5 RID: 3573
		private static FileDescriptor descriptor;
	}
}
