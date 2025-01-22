using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.D4.Common.Game.V1
{
	// Token: 0x020002E5 RID: 741
	public static class HeroClassInfoV1Reflection
	{
		// Token: 0x170018CE RID: 6350
		// (get) Token: 0x06004E30 RID: 20016 RVA: 0x0012AF54 File Offset: 0x00129154
		public static FileDescriptor Descriptor
		{
			get
			{
				return HeroClassInfoV1Reflection.descriptor;
			}
		}

		// Token: 0x06004E31 RID: 20017 RVA: 0x0012AF6C File Offset: 0x0012916C
		static HeroClassInfoV1Reflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChZIZXJvQ2xhc3NJbmZvX3YxLnByb3RvEiRCbGl6emFyZC5UZWxlbWV0cnku", "RDQuQ29tbW9uLkdhbWUudjEikQoKDUhlcm9DbGFzc0luZm8SUQoOZXF1aXBw", "ZWRfc2tpbGwYASADKAsyOS5CbGl6emFyZC5UZWxlbWV0cnkuRDQuQ29tbW9u", "LkdhbWUudjEuSGVyb0NsYXNzSW5mby5Qb3dlchJUChFza2lsbF90cmVlX3Rh", "bGVudBgCIAMoCzI5LkJsaXp6YXJkLlRlbGVtZXRyeS5ENC5Db21tb24uR2Ft", "ZS52MS5IZXJvQ2xhc3NJbmZvLlBvd2VyElcKFHNraWxsX3RyZWVfc2tpbGxf", "bW9kGAMgAygLMjkuQmxpenphcmQuVGVsZW1ldHJ5LkQ0LkNvbW1vbi5HYW1l", "LnYxLkhlcm9DbGFzc0luZm8uUG93ZXISUAoNY2xhc3NfcGFzc2l2ZRgEIAMo", "CzI5LkJsaXp6YXJkLlRlbGVtZXRyeS5ENC5Db21tb24uR2FtZS52MS5IZXJv", "Q2xhc3NJbmZvLlBvd2VyEkgKBXN0YXRzGAUgASgLMjkuQmxpenphcmQuVGVs",
				"ZW1ldHJ5LkQ0LkNvbW1vbi5HYW1lLnYxLkhlcm9DbGFzc0luZm8uU3RhdHMS", "TAoHcGFyYWdvbhgGIAEoCzI7LkJsaXp6YXJkLlRlbGVtZXRyeS5ENC5Db21t", "b24uR2FtZS52MS5IZXJvQ2xhc3NJbmZvLlBhcmFnb24aoQEKBVBvd2VyEhEK", "CXBvd2VyX3NubxgBIAEoERITCgtwb3dlcl9yYW5rcxgCIAEoDRJdCgR0eXBl", "GAMgASgOMj0uQmxpenphcmQuVGVsZW1ldHJ5LkQ0LkNvbW1vbi5HYW1lLnYx", "Lkhlcm9DbGFzc0luZm8uUG93ZXJUeXBlOhBQT1dFUl9UWVBFX1NLSUxMEhEK", "CXBvd2VyX21vZBgEIAEoCRpUCgVTdGF0cxIRCglkZXh0ZXJpdHkYASABKAIS", "FAoMaW50ZWxsaWdlbmNlGAIgASgCEg8KB3N0ZW5ndGgYAyABKAISEQoJd2ls", "bHBvd2VyGAQgASgCGlAKBUdseXBoEhEKCWdseXBoX3NubxgBIAEoERITCgtn", "bHlwaF9sZXZlbBgCIAEoERIfChdnbHlwaF90aHJlc2hvbGRfcmVhY2hlZBgD",
				"IAEoCBrFAQoHUGFyYWdvbhIaChJlcXVpcHBlZF9ib2FyZF9zbm8YASADKBES", "UQoOZXF1aXBwZWRfZ2x5cGgYAiADKAsyOS5CbGl6emFyZC5UZWxlbWV0cnku", "RDQuQ29tbW9uLkdhbWUudjEuSGVyb0NsYXNzSW5mby5HbHlwaBIaChJsZWdl", "bmRhcnlfbm9kZV9zbm8YAyADKBESFQoNcG9pbnRzX2Vhcm5lZBgEIAEoERIY", "ChBwb2ludHNfYXZhaWxhYmxlGAUgASgRIv8BCglQb3dlclR5cGUSFAoQUE9X", "RVJfVFlQRV9TS0lMTBAAEhUKEVBPV0VSX1RZUEVfVEFMRU5UEAESGAoUUE9X", "RVJfVFlQRV9TS0lMTF9NT0QQAhIWChJQT1dFUl9UWVBFX0VOQ0hBTlQQAxIi", "Ch5QT1dFUl9UWVBFX0NMQVNTX1BBU1NJVkVfU0tJTEwQBBIjCh9QT1dFUl9U", "WVBFX1JPR1VFX1NQRUNJQUxJWkFUSU9OEAUSHwobUE9XRVJfVFlQRV9XRUFQ", "T05fRVhQRVJUSVNFEAYSKQolUE9XRVJfVFlQRV9ORUNST01BTkNFUl9TUEVD",
				"SUFMSVpBVElPThAH"
			}));
			HeroClassInfoV1Reflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(HeroClassInfo), HeroClassInfo.Parser, new string[] { "EquippedSkill", "SkillTreeTalent", "SkillTreeSkillMod", "ClassPassive", "Stats", "Paragon" }, null, new Type[] { typeof(HeroClassInfo.Types.PowerType) }, null, new GeneratedClrTypeInfo[]
				{
					new GeneratedClrTypeInfo(typeof(HeroClassInfo.Types.Power), HeroClassInfo.Types.Power.Parser, new string[] { "PowerSno", "PowerRanks", "Type", "PowerMod" }, null, null, null, null),
					new GeneratedClrTypeInfo(typeof(HeroClassInfo.Types.Stats), HeroClassInfo.Types.Stats.Parser, new string[] { "Dexterity", "Intelligence", "Stength", "Willpower" }, null, null, null, null),
					new GeneratedClrTypeInfo(typeof(HeroClassInfo.Types.Glyph), HeroClassInfo.Types.Glyph.Parser, new string[] { "GlyphSno", "GlyphLevel", "GlyphThresholdReached" }, null, null, null, null),
					new GeneratedClrTypeInfo(typeof(HeroClassInfo.Types.Paragon), HeroClassInfo.Types.Paragon.Parser, new string[] { "EquippedBoardSno", "EquippedGlyph", "LegendaryNodeSno", "PointsEarned", "PointsAvailable" }, null, null, null, null)
				})
			}));
		}

		// Token: 0x040022DC RID: 8924
		private static FileDescriptor descriptor;
	}
}
