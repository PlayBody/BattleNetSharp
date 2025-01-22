using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x02000320 RID: 800
	public static class CommonAttackerStateReflection
	{
		// Token: 0x17001AF3 RID: 6899
		// (get) Token: 0x060053B5 RID: 21429 RVA: 0x00143234 File Offset: 0x00141434
		public static FileDescriptor Descriptor
		{
			get
			{
				return CommonAttackerStateReflection.descriptor;
			}
		}

		// Token: 0x060053B6 RID: 21430 RVA: 0x0014324C File Offset: 0x0014144C
		static CommonAttackerStateReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chtjb21tb25fYXR0YWNrZXJfc3RhdGUucHJvdG8SIEJsaXp6YXJkLlRlbGVt", "ZXRyeS5GZW53YXkuQ2xpZW50Ghhjb21tb25fc2tpbGxfc3RhdGUucHJvdG8a", "F2NvbW1vbl9zdGF0X2VudHJ5LnByb3RvGhxjb21tb25faW52ZW50b3J5X3N0", "YXRlLnByb3RvIq0CChBVbmlxdWVCb251c1N0YXRlEhYKDmF1cmFfZW5jaGFu", "dGVkGAEgASgIEg4KBmN1cnNlZBgCIAEoCBIWCg5jb2xkX2VuY2hhbnRlZBgD", "IAEoCBISCgpleHRyYV9mYXN0GAQgASgIEhYKDmZpcmVfZW5jaGFudGVkGAUg", "ASgIEhsKE2xpZ2h0bmluZ19lbmNoYW50ZWQYBiABKAgSFwoPbWFnaWNfcmVz", "aXN0YW50GAcgASgIEhEKCW1hbmFfYnVybhgIIAEoCBISCgptdWx0aV9zaG90", "GAkgASgIEhQKDHNwZWN0cmFsX2hpdBgKIAEoCBISCgpzdG9uZV9za2luGAsg", "ASgIEhQKDGV4dHJhX3N0cm9uZxgMIAEoCBIQCgh0ZWxlcG9ydBgNIAEoCCL0",
				"BQoNQXR0YWNrZXJTdGF0ZRITCgthdHRhY2tlcl9pZBgBIAEoDRIVCg1hdHRh", "Y2tlcl9uYW1lGAIgASgJEjoKBXN0YXRzGAMgAygLMisuQmxpenphcmQuVGVs", "ZW1ldHJ5LkZlbndheS5DbGllbnQuU3RhdEVudHJ5EkEKC3NraWxsX3N0YXRl", "GAQgASgLMiwuQmxpenphcmQuVGVsZW1ldHJ5LkZlbndheS5DbGllbnQuU2tp", "bGxTdGF0ZRJJCg9pbnZlbnRvcnlfc3RhdGUYBSABKAsyMC5CbGl6emFyZC5U", "ZWxlbWV0cnkuRmVud2F5LkNsaWVudC5JbnZlbnRvcnlTdGF0ZRJdCg1hdHRh", "Y2tlcl90eXBlGAYgASgOMjwuQmxpenphcmQuVGVsZW1ldHJ5LkZlbndheS5D", "bGllbnQuQXR0YWNrZXJTdGF0ZS5BdHRhY2tlclR5cGU6CFN0YW5kYXJkElsK", "DmNoYW1waW9uX2JvbnVzGAcgASgOMj0uQmxpenphcmQuVGVsZW1ldHJ5LkZl", "bndheS5DbGllbnQuQXR0YWNrZXJTdGF0ZS5DaGFtcGlvbkJvbnVzOgROb25l",
				"EkoKDnVuaXF1ZV9ib251c2VzGAggASgLMjIuQmxpenphcmQuVGVsZW1ldHJ5", "LkZlbndheS5DbGllbnQuVW5pcXVlQm9udXNTdGF0ZSKSAQoMQXR0YWNrZXJU", "eXBlEgwKCFN0YW5kYXJkEAASDAoIQ2hhbXBpb24QARIKCgZVbmlxdWUQAhIP", "CgtTdXBlclVuaXF1ZRADEgsKB1N1YkJvc3MQBBIICgRCb3NzEAUSCgoGUGxh", "eWVyEAYSDwoLRW52aXJvbm1lbnQQBxIICgRTZWxmEAgSCwoHVW5rbm93bhAJ", "IlAKDUNoYW1waW9uQm9udXMSCAoETm9uZRAAEgsKB0dob3N0bHkQARILCgdG", "YW5hdGljEAISDAoIQmVyc2VrZXIQAxINCglQb3NzZXNzZWQQBA=="
			}));
			CommonAttackerStateReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				CommonSkillStateReflection.Descriptor,
				CommonStatEntryReflection.Descriptor,
				CommonInventoryStateReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(UniqueBonusState), UniqueBonusState.Parser, new string[]
				{
					"AuraEnchanted", "Cursed", "ColdEnchanted", "ExtraFast", "FireEnchanted", "LightningEnchanted", "MagicResistant", "ManaBurn", "MultiShot", "SpectralHit",
					"StoneSkin", "ExtraStrong", "Teleport"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AttackerState), AttackerState.Parser, new string[] { "AttackerId", "AttackerName", "Stats", "SkillState", "InventoryState", "AttackerType", "ChampionBonus", "UniqueBonuses" }, null, new Type[]
				{
					typeof(AttackerState.Types.AttackerType),
					typeof(AttackerState.Types.ChampionBonus)
				}, null, null)
			}));
		}

		// Token: 0x040025F3 RID: 9715
		private static FileDescriptor descriptor;
	}
}
