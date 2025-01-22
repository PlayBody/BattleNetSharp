using System;
using Fenris.Items;
using Fenris.Online;
using Google.Protobuf.Reflection;

namespace Fenris.Clan
{
	// Token: 0x020002A8 RID: 680
	public static class ClanReflection
	{
		// Token: 0x170016A6 RID: 5798
		// (get) Token: 0x060047C5 RID: 18373 RVA: 0x001117F4 File Offset: 0x0010F9F4
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClanReflection.descriptor;
			}
		}

		// Token: 0x060047C6 RID: 18374 RVA: 0x0011180C File Offset: 0x0010FA0C
		static ClanReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CgpDbGFuLnByb3RvEgtGZW5yaXMuQ2xhbhoST25saW5lQ29tbW9uLnByb3Rv", "GgtJdGVtcy5wcm90byKKBgoPQ2xhblBlcm1pc3Npb25zEjwKFG1hbmFnZW1l", "bnRfZWRpdF9tb3RkGAEgASgOMhUuRmVucmlzLkNsYW4uQ2xhblJhbms6B0lO", "VkFMSUQSQQoZbWFuYWdlbWVudF9lZGl0X3NlbGZfbm90ZRgCIAEoDjIVLkZl", "bnJpcy5DbGFuLkNsYW5SYW5rOgdJTlZBTElEEkYKHm1lbWJlcnNoaXBfbWFu", "YWdlX2FwcGxpY2F0aW9ucxgDIAEoDjIVLkZlbnJpcy5DbGFuLkNsYW5SYW5r", "OgdJTlZBTElEEjkKEW1lbWJlcnNoaXBfaW52aXRlGAQgASgOMhUuRmVucmlz", "LkNsYW4uQ2xhblJhbms6B0lOVkFMSUQSOgoSbWVtYmVyc2hpcF9wcm9tb3Rl", "GAcgASgOMhUuRmVucmlzLkNsYW4uQ2xhblJhbms6B0lOVkFMSUQSOQoRbWVt", "YmVyc2hpcF9kZW1vdGUYCCABKA4yFS5GZW5yaXMuQ2xhbi5DbGFuUmFuazoH",
				"SU5WQUxJRBI3Cg9tZW1iZXJzaGlwX2tpY2sYCSABKA4yFS5GZW5yaXMuQ2xh", "bi5DbGFuUmFuazoHSU5WQUxJRBI2Cg5tZW1iZXJzaGlwX2JhbhgKIAEoDjIV", "LkZlbnJpcy5DbGFuLkNsYW5SYW5rOgdJTlZBTElEEjIKCnZvaWNlX211dGUY", "DSABKA4yFS5GZW5yaXMuQ2xhbi5DbGFuUmFuazoHSU5WQUxJRBIyCgp2b2lj", "ZV9jaGF0GA4gASgOMhUuRmVucmlzLkNsYW4uQ2xhblJhbms6B0lOVkFMSUQS", "NAoMaG9hcmRfbWFuYWdlGA8gASgOMhUuRmVucmlzLkNsYW4uQ2xhblJhbms6", "B0lOVkFMSUQSNQoNaG9hcmRfZGVwb3NpdBgQIAEoDjIVLkZlbnJpcy5DbGFu", "LkNsYW5SYW5rOgdJTlZBTElEEjYKDmhvYXJkX3dpdGhkcmF3GBEgASgOMhUu", "RmVucmlzLkNsYW4uQ2xhblJhbms6B0lOVkFMSUQi+wUKCENsYW5JbmZvEg8K", "B2NsYW5faWQYBiABKAkSDAoEbmFtZRgBIAEoCRIlCh1sYXN0X2VkaXRlZF9u",
				"YW1lX2JuZXRfYWNjb3VudBgWIAEoDRIlCh1sYXN0X2VkaXRlZF9uYW1lX2dh", "bWVfYWNjb3VudBgXIAEoDRILCgN0YWcYAiABKAkSJAocbGFzdF9lZGl0ZWRf", "dGFnX2JuZXRfYWNjb3VudBgYIAEoDRIkChxsYXN0X2VkaXRlZF90YWdfZ2Ft", "ZV9hY2NvdW50GBkgASgNEhMKC2Rlc2NyaXB0aW9uGAMgASgJEiwKJGxhc3Rf", "ZWRpdGVkX2Rlc2NyaXB0aW9uX2JuZXRfYWNjb3VudBgUIAEoDRIsCiRsYXN0", "X2VkaXRlZF9kZXNjcmlwdGlvbl9nYW1lX2FjY291bnQYFSABKA0SDAoEaW5m", "bxgIIAEoCRIlCh1sYXN0X2VkaXRlZF9pbmZvX2JuZXRfYWNjb3VudBgRIAEo", "DRIlCh1sYXN0X2VkaXRlZF9pbmZvX2dhbWVfYWNjb3VudBgOIAEoDRINCgVs", "YWJlbBgKIAMoDRIMCgRtb3RkGAcgASgJEiUKHWxhc3RfZWRpdGVkX21vdGRf", "Ym5ldF9hY2NvdW50GBIgASgNEiUKHWxhc3RfZWRpdGVkX21vdGRfZ2FtZV9h",
				"Y2NvdW50GAwgASgNEjEKC3Blcm1pc3Npb25zGA8gASgLMhwuRmVucmlzLkNs", "YW4uQ2xhblBlcm1pc3Npb25zEisKCGhlcmFsZHJ5GA0gASgLMhkuRmVucmlz", "LkNsYW4uQ2xhbkhlcmFsZHJ5EikKIWxhc3RfZWRpdGVkX2hlcmFsZHJ5X2Ju", "ZXRfYWNjb3VudBgTIAEoDRIpCiFsYXN0X2VkaXRlZF9oZXJhbGRyeV9nYW1l", "X2FjY291bnQYECABKA0SEgoKY3JlYXRlZF9hdBgEIAEoBBITCgtiZ3NfY2x1", "Yl9pZBgFIAEoBBISCgppc19wcml2YXRlGAsgASgIIpABCgpDbGFuTWVtYmVy", "EhcKD2JuZXRfYWNjb3VudF9pZBgBIAEoDRIXCg9nYW1lX2FjY291bnRfaWQY", "AiABKA0SDwoHY2xhbl9pZBgEIAEoCRIRCglqb2luZWRfYXQYBSABKAQSLAoE", "cmFuaxgGIAEoDjIVLkZlbnJpcy5DbGFuLkNsYW5SYW5rOgdJTlZBTElEIrgC", "CgpDbGFuSW52aXRlEg8KB2NsYW5faWQYASABKAkSHwoXaW52aXRlZV9nYW1l",
				"X2FjY291bnRfaWQYAiABKA0SHwoXaW52aXRlcl9nYW1lX2FjY291bnRfaWQY", "AyABKA0SHwoXaW52aXRlZV9ibmV0X2FjY291bnRfaWQYCSABKA0SHwoXaW52", "aXRlcl9ibmV0X2FjY291bnRfaWQYCiABKA0SEgoKY3JlYXRlZF9hdBgFIAEo", "BBIRCgljbGFuX25hbWUYBiABKAkSEAoIY2xhbl90YWcYDCABKAkSKwoIaGVy", "YWxkcnkYByABKAsyGS5GZW5yaXMuQ2xhbi5DbGFuSGVyYWxkcnkSEgoKZXhw", "aXJlc19hdBgIIAEoBBIbChNpc19mcm9tX2FwcGxpY2F0aW9uGAsgASgIIsAB", "Cg9DbGFuQXBwbGljYXRpb24SDwoHY2xhbl9pZBgBIAEoCRIXCg9ibmV0X2Fj", "Y291bnRfaWQYAiABKA0SFwoPZ2FtZV9hY2NvdW50X2lkGAcgASgNEhIKCmNy", "ZWF0ZWRfYXQYAyABKAQSEQoJY2xhbl9uYW1lGAUgASgJEhYKDnJlbW92YWxf", "cmVhc29uGAYgASgNEisKCGhlcmFsZHJ5GAggASgLMhkuRmVucmlzLkNsYW4u",
				"Q2xhbkhlcmFsZHJ5IlYKEENsYW5CYW5uZWRNZW1iZXISFwoPZ2FtZV9hY2Nv", "dW50X2lkGAEgASgNEhcKD2JuZXRfYWNjb3VudF9pZBgDIAEoDRIQCghiYW5f", "dGltZRgCIAEoBCLkAQoEQ2xhbhIjCgRpbmZvGAEgASgLMhUuRmVucmlzLkNs", "YW4uQ2xhbkluZm8SJwoGbWVtYmVyGAIgAygLMhcuRmVucmlzLkNsYW4uQ2xh", "bk1lbWJlchInCgZpbnZpdGUYAyADKAsyFy5GZW5yaXMuQ2xhbi5DbGFuSW52", "aXRlEjkKE3BlbmRpbmdfYXBwbGljYXRpb24YBCADKAsyHC5GZW5yaXMuQ2xh", "bi5DbGFuQXBwbGljYXRpb24SKgoDYmFuGAUgAygLMh0uRmVucmlzLkNsYW4u", "Q2xhbkJhbm5lZE1lbWJlciKnBQoLQ2xhblByb2ZpbGUSDwoHY2xhbl9pZBgB", "IAEoCRIMCgRuYW1lGAIgASgJEiUKHWxhc3RfZWRpdGVkX25hbWVfYm5ldF9h", "Y2NvdW50GA8gASgNEiUKHWxhc3RfZWRpdGVkX25hbWVfZ2FtZV9hY2NvdW50",
				"GBAgASgNEgsKA3RhZxgDIAEoCRIkChxsYXN0X2VkaXRlZF90YWdfYm5ldF9h", "Y2NvdW50GBEgASgNEiQKHGxhc3RfZWRpdGVkX3RhZ19nYW1lX2FjY291bnQY", "EiABKA0SEwoLZGVzY3JpcHRpb24YBCABKAkSLAokbGFzdF9lZGl0ZWRfZGVz", "Y3JpcHRpb25fYm5ldF9hY2NvdW50GA0gASgNEiwKJGxhc3RfZWRpdGVkX2Rl", "c2NyaXB0aW9uX2dhbWVfYWNjb3VudBgOIAEoDRISCgpjcmVhdGVkX2F0GAUg", "ASgEEi8KBmxlYWRlchgGIAEoCzIfLkZlbnJpcy5DbGFuLkNsYW5Qcm9maWxl", "Lk1lbWJlchIUCgxtZW1iZXJfY291bnQYByABKA0SDQoFbGFiZWwYCCADKA0S", "KwoIaGVyYWxkcnkYCiABKAsyGS5GZW5yaXMuQ2xhbi5DbGFuSGVyYWxkcnkS", "KQohbGFzdF9lZGl0ZWRfaGVyYWxkcnlfYm5ldF9hY2NvdW50GAsgASgNEikK", "IWxhc3RfZWRpdGVkX2hlcmFsZHJ5X2dhbWVfYWNjb3VudBgMIAEoDRp0CgZN",
				"ZW1iZXISFwoPZ2FtZV9hY2NvdW50X2lkGAEgASgNEhcKD2JuZXRfYWNjb3Vu", "dF9pZBgCIAEoDRI4ChBwbGF0Zm9ybV9hY2NvdW50GAMgASgLMh4uRmVucmlz", "Lk9ubGluZS5QbGF0Zm9ybUFjY291bnQidAoLQ2xhbkJhbmtUYWISDQoFaW5k", "ZXgYASABKA0SNAoNcmVxdWlyZWRfcmFuaxgCIAEoDjIVLkZlbnJpcy5DbGFu", "LkNsYW5SYW5rOgZNRU1CRVISEgoKaWNvbl9pbmRleBgDIAEoDRIMCgRuYW1l", "GAQgASgJIjUKDENsYW5CYW5rVGFicxIlCgN0YWIYASADKAsyGC5GZW5yaXMu", "Q2xhbi5DbGFuQmFua1RhYiJfCghDbGFuQmFuaxIsCgliYW5rX3RhYnMYASAB", "KAsyGS5GZW5yaXMuQ2xhbi5DbGFuQmFua1RhYnMSJQoEaXRlbRgCIAMoCzIX", "LkZlbnJpcy5JdGVtcy5TYXZlZEl0ZW0iWQoMSGVyYWxkcnlJY29uEg0KBWlu", "ZGV4GAUgASgNEgwKBG5hbWUYASABKA0SDAoEc2l6ZRgCIAEoAhINCgVhbmds",
				"ZRgDIAEoAhIPCgdmbGlwcGVkGAQgASgIIrMDCgxDbGFuSGVyYWxkcnkSHgoW", "YmFzZV9iYW5uZXJfc2hhcGVfbmFtZRgBIAEoDRIhChliYXNlX3RleHRpbGVf", "cGF0dGVybl9uYW1lGAIgASgNEiEKGWJhc2VfdGV4dGlsZV90ZXh0dXJlX25h", "bWUYAyABKA0SHAoUYmFzZV9lbWJyb2lkZXJ5X25hbWUYBCABKA0SFgoOYmFz", "ZV90cmltX25hbWUYBSABKA0SIAoYZHllX3RleHRpbGVfcHJpbWFyeV9uYW1l", "GAYgASgNEiIKGmR5ZV90ZXh0aWxlX3NlY29uZGFyeV9uYW1lGAcgASgNEiEK", "GWR5ZV90ZXh0aWxlX3RlcnRpYXJ5X25hbWUYCCABKA0SFQoNZHllX3RyaW1f", "bmFtZRgJIAEoDRIcChRkeWVfaWNvbm9ncmFwaHlfbmFtZRgKIAEoDRIbChNk", "eWVfZW1icm9pZGVyeV9uYW1lGAsgASgNEhkKEWljb25fbGF5b3V0X2luZGV4", "GBQgASgNEjEKDmhlcmFsZHJ5X2ljb25zGBUgAygLMhkuRmVucmlzLkNsYW4u",
				"SGVyYWxkcnlJY29uIjIKF0NsYW5BY2hpZXZlbWVudE5ld3NEYXRhEhcKD2Fj", "aGlldmVtZW50X3NubxgBIAEoDyIkChBDbGFuUmFua05ld3NEYXRhEhAKCG5l", "d19yYW5rGAEgASgNIiQKEENsYW5Nb3RkTmV3c0RhdGESEAoIbmV3X21vdGQY", "ASABKAki8QIKDENsYW5OZXdzSXRlbRIKCgJpZBgBIAEoCRIMCgR0eXBlGAIg", "ASgNEh4KFnRhcmdldF9nYW1lX2FjY291bnRfaWQYAyABKA0SHgoWdGFyZ2V0", "X2JuZXRfYWNjb3VudF9pZBgJIAEoDRIiChpvcmlnaW5hdG9yX2dhbWVfYWNj", "b3VudF9pZBgEIAEoDRIiChpvcmlnaW5hdG9yX2JuZXRfYWNjb3VudF9pZBgK", "IAEoDRIVCg1jcmVhdGlvbl90aW1lGAUgASgEEjgKCGFjdl9kYXRhGAYgASgL", "MiQuRmVucmlzLkNsYW4uQ2xhbkFjaGlldmVtZW50TmV3c0RhdGFIABIyCgly", "YW5rX2RhdGEYByABKAsyHS5GZW5yaXMuQ2xhbi5DbGFuUmFua05ld3NEYXRh",
				"SAASMgoJbW90ZF9kYXRhGAggASgLMh0uRmVucmlzLkNsYW4uQ2xhbk1vdGRO", "ZXdzRGF0YUgAQgYKBGRhdGEiNwoMQ2xhbk5ld3NMaXN0EicKBG5ld3MYASAD", "KAsyGS5GZW5yaXMuQ2xhbi5DbGFuTmV3c0l0ZW0iZwoNQ2xhbkJhblVwZGF0", "ZRIPCgdjbGFuX2lkGAEgASgJEjAKCWFkZGVkX2JhbhgCIAMoCzIdLkZlbnJp", "cy5DbGFuLkNsYW5CYW5uZWRNZW1iZXISEwoLcmVtb3ZlZF9iYW4YAyADKA0i", "RgoeQ2xhbk9mZmxpbmVSZW1vdmFsTm90aWZpY2F0aW9uEg4KBnJlYXNvbhgB", "IAEoDRIUCgxyZW1vdmFsX3RpbWUYAiABKAQqUgoIQ2xhblJhbmsSFAoHSU5W", "QUxJRBD///////////8BEgsKB1JFQ1JVSVQQBBIKCgZNRU1CRVIQABILCgdP", "RkZJQ0VSEAESCgoGTEVBREVSEAIqRAoPQ2xhbkNvbnRlbnRUeXBlEhkKDElO", "VkFMSURfVFlQRRD///////////8BEgwKCEhFUkFMRFJZEAASCAoETU9URBAB"
			}));
			ClanReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				OnlineCommonReflection.Descriptor,
				ItemsReflection.Descriptor
			}, new GeneratedClrTypeInfo(new Type[]
			{
				typeof(ClanRank),
				typeof(ClanContentType)
			}, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ClanPermissions), ClanPermissions.Parser, new string[]
				{
					"ManagementEditMotd", "ManagementEditSelfNote", "MembershipManageApplications", "MembershipInvite", "MembershipPromote", "MembershipDemote", "MembershipKick", "MembershipBan", "VoiceMute", "VoiceChat",
					"HoardManage", "HoardDeposit", "HoardWithdraw"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClanInfo), ClanInfo.Parser, new string[]
				{
					"ClanId", "Name", "LastEditedNameBnetAccount", "LastEditedNameGameAccount", "Tag", "LastEditedTagBnetAccount", "LastEditedTagGameAccount", "Description", "LastEditedDescriptionBnetAccount", "LastEditedDescriptionGameAccount",
					"Info", "LastEditedInfoBnetAccount", "LastEditedInfoGameAccount", "Label", "Motd", "LastEditedMotdBnetAccount", "LastEditedMotdGameAccount", "Permissions", "Heraldry", "LastEditedHeraldryBnetAccount",
					"LastEditedHeraldryGameAccount", "CreatedAt", "BgsClubId", "IsPrivate"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClanMember), ClanMember.Parser, new string[] { "BnetAccountId", "GameAccountId", "ClanId", "JoinedAt", "Rank" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClanInvite), ClanInvite.Parser, new string[]
				{
					"ClanId", "InviteeGameAccountId", "InviterGameAccountId", "InviteeBnetAccountId", "InviterBnetAccountId", "CreatedAt", "ClanName", "ClanTag", "Heraldry", "ExpiresAt",
					"IsFromApplication"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClanApplication), ClanApplication.Parser, new string[] { "ClanId", "BnetAccountId", "GameAccountId", "CreatedAt", "ClanName", "RemovalReason", "Heraldry" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClanBannedMember), ClanBannedMember.Parser, new string[] { "GameAccountId", "BnetAccountId", "BanTime" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Clan), Clan.Parser, new string[] { "Info", "Member", "Invite", "PendingApplication", "Ban" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClanProfile), ClanProfile.Parser, new string[]
				{
					"ClanId", "Name", "LastEditedNameBnetAccount", "LastEditedNameGameAccount", "Tag", "LastEditedTagBnetAccount", "LastEditedTagGameAccount", "Description", "LastEditedDescriptionBnetAccount", "LastEditedDescriptionGameAccount",
					"CreatedAt", "Leader", "MemberCount", "Label", "Heraldry", "LastEditedHeraldryBnetAccount", "LastEditedHeraldryGameAccount"
				}, null, null, null, new GeneratedClrTypeInfo[]
				{
					new GeneratedClrTypeInfo(typeof(ClanProfile.Types.Member), ClanProfile.Types.Member.Parser, new string[] { "GameAccountId", "BnetAccountId", "PlatformAccount" }, null, null, null, null)
				}),
				new GeneratedClrTypeInfo(typeof(ClanBankTab), ClanBankTab.Parser, new string[] { "Index", "RequiredRank", "IconIndex", "Name" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClanBankTabs), ClanBankTabs.Parser, new string[] { "Tab" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClanBank), ClanBank.Parser, new string[] { "BankTabs", "Item" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(HeraldryIcon), HeraldryIcon.Parser, new string[] { "Index", "Name", "Size", "Angle", "Flipped" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClanHeraldry), ClanHeraldry.Parser, new string[]
				{
					"BaseBannerShapeName", "BaseTextilePatternName", "BaseTextileTextureName", "BaseEmbroideryName", "BaseTrimName", "DyeTextilePrimaryName", "DyeTextileSecondaryName", "DyeTextileTertiaryName", "DyeTrimName", "DyeIconographyName",
					"DyeEmbroideryName", "IconLayoutIndex", "HeraldryIcons"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClanAchievementNewsData), ClanAchievementNewsData.Parser, new string[] { "AchievementSno" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClanRankNewsData), ClanRankNewsData.Parser, new string[] { "NewRank" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClanMotdNewsData), ClanMotdNewsData.Parser, new string[] { "NewMotd" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClanNewsItem), ClanNewsItem.Parser, new string[] { "Id", "Type", "TargetGameAccountId", "TargetBnetAccountId", "OriginatorGameAccountId", "OriginatorBnetAccountId", "CreationTime", "AcvData", "RankData", "MotdData" }, new string[] { "Data" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClanNewsList), ClanNewsList.Parser, new string[] { "News" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClanBanUpdate), ClanBanUpdate.Parser, new string[] { "ClanId", "AddedBan", "RemovedBan" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClanOfflineRemovalNotification), ClanOfflineRemovalNotification.Parser, new string[] { "Reason", "RemovalTime" }, null, null, null, null)
			}));
		}

		// Token: 0x04001FBE RID: 8126
		private static FileDescriptor descriptor;
	}
}
