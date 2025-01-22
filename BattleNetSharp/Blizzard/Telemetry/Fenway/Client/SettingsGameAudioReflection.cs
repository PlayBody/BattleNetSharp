using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x02000336 RID: 822
	public static class SettingsGameAudioReflection
	{
		// Token: 0x17001BA3 RID: 7075
		// (get) Token: 0x060055A0 RID: 21920 RVA: 0x0014AC4C File Offset: 0x00148E4C
		public static FileDescriptor Descriptor
		{
			get
			{
				return SettingsGameAudioReflection.descriptor;
			}
		}

		// Token: 0x060055A1 RID: 21921 RVA: 0x0014AC64 File Offset: 0x00148E64
		static SettingsGameAudioReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChlzZXR0aW5nc19nYW1lX2F1ZGlvLnByb3RvEiBCbGl6emFyZC5UZWxlbWV0", "cnkuRmVud2F5LkNsaWVudCLgBAoNQXVkaW9TZXR0aW5ncxIUCgxzb3VuZF92", "b2x1bWUYASABKAUSFAoMbXVzaWNfdm9sdW1lGAIgASgFEhcKD25wY19zcGVl", "Y2hfbW9kZRgDIAEoBRIQCghsYW5ndWFnZRgEIAEoCRIdChVhZHZhbmNlZF9h", "dWRpb19wcmVzZXQYBSABKA0SEQoJdm9fdm9sdW1lGAYgASgFEhkKEXNmeF9t", "YXN0ZXJfdm9sdW1lGAcgASgFEhUKDXNmeF91aV92b2x1bWUYCCABKAUSGAoQ", "c2Z4X2l0ZW1zX3ZvbHVtZRgJIAEoBRIaChJzZnhfbW9uc3Rlcl92b2x1bWUY", "CiABKAUSIAoYc2Z4X3BsYXllcl9za2lsbHNfdm9sdW1lGAsgASgFEiEKGXNm", "eF9hbWJpZW50X21hc3Rlcl92b2x1bWUYDCABKAUSJAocc2Z4X2FtYmllbnRf", "Zm9vdHN0ZXBzX3ZvbHVtZRgNIAEoBRIgChhzZnhfYW1iaWVudF9mb2xleV92",
				"b2x1bWUYDiABKAUSIgoac2Z4X2FtYmllbnRfb2JqZWN0c192b2x1bWUYDyAB", "KAUSJgoec2Z4X2FtYmllbnRfZW52aXJvbm1lbnRfdm9sdW1lGBAgASgFEiAK", "GHNmeF9jb21iYXRfbWFzdGVyX3ZvbHVtZRgRIAEoBRIhChlzZnhfY29tYmF0", "X2ltcGFjdHNfdm9sdW1lGBIgASgFEiAKGHNmeF9jb21iYXRfd2VhcG9uX3Zv", "bHVtZRgTIAEoBRIeChZzZnhfY29tYmF0X2dvcmVfdm9sdW1lGBQgASgF"
			}));
			SettingsGameAudioReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(AudioSettings), AudioSettings.Parser, new string[]
				{
					"SoundVolume", "MusicVolume", "NpcSpeechMode", "Language", "AdvancedAudioPreset", "VoVolume", "SfxMasterVolume", "SfxUiVolume", "SfxItemsVolume", "SfxMonsterVolume",
					"SfxPlayerSkillsVolume", "SfxAmbientMasterVolume", "SfxAmbientFootstepsVolume", "SfxAmbientFoleyVolume", "SfxAmbientObjectsVolume", "SfxAmbientEnvironmentVolume", "SfxCombatMasterVolume", "SfxCombatImpactsVolume", "SfxCombatWeaponVolume", "SfxCombatGoreVolume"
				}, null, null, null, null)
			}));
		}

		// Token: 0x040026EB RID: 9963
		private static FileDescriptor descriptor;
	}
}
