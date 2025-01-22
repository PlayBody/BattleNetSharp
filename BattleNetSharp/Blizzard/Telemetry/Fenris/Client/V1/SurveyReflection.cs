using System;
using Blizzard.Telemetry.Fenris.Game.V1;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x0200031C RID: 796
	public static class SurveyReflection
	{
		// Token: 0x17001AD7 RID: 6871
		// (get) Token: 0x06005368 RID: 21352 RVA: 0x00141F08 File Offset: 0x00140108
		public static FileDescriptor Descriptor
		{
			get
			{
				return SurveyReflection.descriptor;
			}
		}

		// Token: 0x06005369 RID: 21353 RVA: 0x00141F20 File Offset: 0x00140120
		static SurveyReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "CgxTdXJ2ZXkucHJvdG8SI0JsaXp6YXJkLlRlbGVtZXRyeS5GZW5yaXMuQ2xp", "ZW50LnYxGg5IZXJvSW5mby5wcm90byLyAQoGU3VydmV5Ej4KCWhlcm9faW5m", "bxgBIAEoCzIrLkJsaXp6YXJkLlRlbGVtZXRyeS5GZW5yaXMuR2FtZS52MS5I", "ZXJvSW5mbxITCgtnYW1lX2hhbmRsZRgCIAEoCRIRCglzbm9fZ3JvdXAYAyAB", "KBESEgoKc25vX2hhbmRsZRgEIAEoERIbChNxdWVzdGlvbl92YWx1ZV9saXN0", "GAUgAygFEhMKC3N1cnZleV90ZXh0GAYgASgJEhgKEGdiaWRfc3VydmV5X3R5", "cGUYByABKBESIAoYc25vX3F1ZXN0aW9uc19zdHJpbmdsaXN0GAggASgR" }));
			SurveyReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { HeroInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(Survey), Survey.Parser, new string[] { "HeroInfo", "GameHandle", "SnoGroup", "SnoHandle", "QuestionValueList", "SurveyText", "GbidSurveyType", "SnoQuestionsStringlist" }, null, null, null, null)
			}));
		}

		// Token: 0x040025CB RID: 9675
		private static FileDescriptor descriptor;
	}
}
