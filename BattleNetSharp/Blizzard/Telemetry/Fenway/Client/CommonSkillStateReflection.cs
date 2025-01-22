using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x0200032D RID: 813
	public static class CommonSkillStateReflection
	{
		// Token: 0x17001B6D RID: 7021
		// (get) Token: 0x060054FE RID: 21758 RVA: 0x001488C8 File Offset: 0x00146AC8
		public static FileDescriptor Descriptor
		{
			get
			{
				return CommonSkillStateReflection.descriptor;
			}
		}

		// Token: 0x060054FF RID: 21759 RVA: 0x001488E0 File Offset: 0x00146AE0
		static CommonSkillStateReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "Chhjb21tb25fc2tpbGxfc3RhdGUucHJvdG8SIEJsaXp6YXJkLlRlbGVtZXRy", "eS5GZW53YXkuQ2xpZW50IkQKBVNraWxsEhIKCnNraWxsX3R5cGUYASABKAUS", "EwoLc2tpbGxfbGV2ZWwYAiABKAMSEgoKc2tpbGxfbmFtZRgDIAEoCSKAAQoK", "U2tpbGxTdGF0ZRIZChFza2lsbF9wb2ludHNfdXNlZBgBIAEoBBIeChZza2ls", "bF9wb2ludHNfYXZhaWxhYmxlGAIgASgEEjcKBnNraWxscxgDIAMoCzInLkJs", "aXp6YXJkLlRlbGVtZXRyeS5GZW53YXkuQ2xpZW50LlNraWxs" }));
			CommonSkillStateReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(Skill), Skill.Parser, new string[] { "SkillType", "SkillLevel", "SkillName" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SkillState), SkillState.Parser, new string[] { "SkillPointsUsed", "SkillPointsAvailable", "Skills" }, null, null, null, null)
			}));
		}

		// Token: 0x040026A2 RID: 9890
		private static FileDescriptor descriptor;
	}
}
