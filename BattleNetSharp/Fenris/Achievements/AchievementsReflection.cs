using System;
using Google.Protobuf.Reflection;

namespace Fenris.Achievements
{
	// Token: 0x020002C2 RID: 706
	public static class AchievementsReflection
	{
		// Token: 0x170017DB RID: 6107
		// (get) Token: 0x06004B14 RID: 19220 RVA: 0x0011F6A4 File Offset: 0x0011D8A4
		public static FileDescriptor Descriptor
		{
			get
			{
				return AchievementsReflection.descriptor;
			}
		}

		// Token: 0x06004B15 RID: 19221 RVA: 0x0011F6BC File Offset: 0x0011D8BC
		static AchievementsReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChJBY2hpZXZlbWVudHMucHJvdG8SE0ZlbnJpcy5BY2hpZXZlbWVudHMiUgoL", "QWNoaWV2ZW1lbnQSGwoPYWNoaWV2ZW1lbnRfc25vGAEgAigPOgItMRISCgpj", "b21wbGV0aW9uGAIgAigEEhIKCmNvbGxlY3Rpb24YAyABKAQiaQoIQ3JpdGVy", "aWESEwoLY3JpdGVyaWFfaWQYASACKA0SEgoKc3RhcnRfdGltZRgCIAEoBBIT", "Cgt1cGRhdGVfdGltZRgEIAEoBBIQCghxdWFudGl0eRgDIAEoBBINCgVmbGFn", "cxgFIAEoDSKGAQoIU25hcHNob3QSNQoLYWNoaWV2ZW1lbnQYASADKAsyIC5G", "ZW5yaXMuQWNoaWV2ZW1lbnRzLkFjaGlldmVtZW50Ei8KCGNyaXRlcmlhGAIg", "AygLMh0uRmVucmlzLkFjaGlldmVtZW50cy5Dcml0ZXJpYRISCgp0aW1lX3N0", "YW1wGAMgASgDIlcKEVBhcnRpdGlvblNuYXBzaG90EhEKCXBhcnRpdGlvbhgB", "IAEoDRIvCghzbmFwc2hvdBgCIAEoCzIdLkZlbnJpcy5BY2hpZXZlbWVudHMu",
				"U25hcHNob3QiJQoVQWNoaWV2ZW1lbnRzUmVzZXREYXRlEgwKBGRhdGUYASAB", "KAMiZgoeQWNoaWV2ZW1lbnRBd2FyZGVkTm90aWZpY2F0aW9uEhcKD2dhbWVf", "YWNjb3VudF9pZBgBIAIoDRIXCg9hY2hpZXZlbWVudF9zbm8YAiADKA8SEgoK", "YWNjb3VudF9pZBgDIAEoDSKOAQofQWNoaWV2ZW1lbnRQcm9ncmVzc05vdGlm", "aWNhdGlvbhIXCg9nYW1lX2FjY291bnRfaWQYASABKA0SEgoKYWNjb3VudF9p", "ZBgCIAEoDRIXCg9hY2hpZXZlbWVudF9zbm8YAyABKA8SEwoLY3JpdGVyaWFf", "aWQYBCABKA8SEAoIcXVhbnRpdHkYBSABKAQiVAoNREJBY2hpZXZlbWVudBIb", "Cg9hY2hpZXZlbWVudF9zbm8YASACKA86Ai0xEhIKCmNvbXBsZXRpb24YAiAC", "KAQSEgoKY29sbGVjdGlvbhgDIAEoBCJKCg5EQkFjaGlldmVtZW50cxI4Cgxh", "Y2hpZXZlbWVudHMYASADKAsyIi5GZW5yaXMuQWNoaWV2ZW1lbnRzLkRCQWNo",
				"aWV2ZW1lbnQ="
			}));
			AchievementsReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(Achievement), Achievement.Parser, new string[] { "AchievementSno", "Completion", "Collection" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Criteria), Criteria.Parser, new string[] { "CriteriaId", "StartTime", "UpdateTime", "Quantity", "Flags" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Snapshot), Snapshot.Parser, new string[] { "Achievement", "Criteria", "TimeStamp" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PartitionSnapshot), PartitionSnapshot.Parser, new string[] { "Partition", "Snapshot" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AchievementsResetDate), AchievementsResetDate.Parser, new string[] { "Date" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AchievementAwardedNotification), AchievementAwardedNotification.Parser, new string[] { "GameAccountId", "AchievementSno", "AccountId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AchievementProgressNotification), AchievementProgressNotification.Parser, new string[] { "GameAccountId", "AccountId", "AchievementSno", "CriteriaId", "Quantity" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(DBAchievement), DBAchievement.Parser, new string[] { "AchievementSno", "Completion", "Collection" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(DBAchievements), DBAchievements.Parser, new string[] { "Achievements" }, null, null, null, null)
			}));
		}

		// Token: 0x04002185 RID: 8581
		private static FileDescriptor descriptor;
	}
}
