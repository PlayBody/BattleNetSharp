using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x0200033E RID: 830
	public static class SettingsGameGraphicsReflection
	{
		// Token: 0x17001BF3 RID: 7155
		// (get) Token: 0x0600566C RID: 22124 RVA: 0x0014E1DC File Offset: 0x0014C3DC
		public static FileDescriptor Descriptor
		{
			get
			{
				return SettingsGameGraphicsReflection.descriptor;
			}
		}

		// Token: 0x0600566D RID: 22125 RVA: 0x0014E1F4 File Offset: 0x0014C3F4
		static SettingsGameGraphicsReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChxzZXR0aW5nc19nYW1lX2dyYXBoaWNzLnByb3RvEiBCbGl6emFyZC5UZWxl", "bWV0cnkuRmVud2F5LkNsaWVudCLOBQoQR3JhcGhpY3NTZXR0aW5ncxIfChdz", "Y3JlZW5fcmVzb2x1dGlvbl93aWR0aBgBIAEoDRIgChhzY3JlZW5fcmVzb2x1", "dGlvbl9oZWlnaHQYAiABKA0SHQoVZ2FtZV9yZXNvbHV0aW9uX3dpZHRoGAMg", "ASgNEh4KFmdhbWVfcmVzb2x1dGlvbl9oZWlnaHQYBCABKA0SGAoQbGlnaHRp", "bmdfcXVhbGl0eRgFIAEoDRIeChZsZWdhY3lfYmxlbmRlZF9zaGFkb3dzGAYg", "ASgIEhoKEmxlZ2FjeV9wZXJzcGVjdGl2ZRgHIAEoCBIQCghzZF9nYW1tYRgI", "IAEoBRIQCghoZF9nYW1tYRgJIAEoBRIQCghjb250cmFzdBgKIAEoBRIVCg12", "c3luY19lbmFibGVkGAsgASgIEhoKEmZyYW1lcmF0ZV9jYXBfbW9kZRgMIAEo", "DRITCgt3aW5kb3dfbW9kZRgNIAEoDRIXCg90ZXh0dXJlX3F1YWxpdHkYDiAB",
				"KA0SGgoSdGV4dHVyZV9hbmlzb3Ryb3B5GA8gASgNEiEKGWFtYmllbnRfb2Nj", "bHVzaW9uX3F1YWxpdHkYECABKA0SIAoYY2hhcmFjdGVyX2RldGFpbF9xdWFs", "aXR5GBEgASgNEiIKGmVudmlyb25tZW50X2RldGFpbF9xdWFsaXR5GBIgASgN", "EhwKFGF0bW9zcGhlcmljc19xdWFsaXR5GBMgASgNEhwKFHRyYW5zcGFyZW5j", "eV9xdWFsaXR5GBQgASgNEhYKDnNoYWRvd19xdWFsaXR5GBUgASgNEhoKEmFu", "dGlfYWxpYXNpbmdfbW9kZRgWIAEoDRIXCg9oZHJfY2FsaWJyYXRpb24YFyAB", "KAUSIgoaZHluYW1pY19yZXNvbHV0aW9uX3NjYWxpbmcYGCABKAgSGQoRZnJh", "bWVfcmF0ZV90YXJnZXQYGSABKA0="
			}));
			SettingsGameGraphicsReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(GraphicsSettings), GraphicsSettings.Parser, new string[]
				{
					"ScreenResolutionWidth", "ScreenResolutionHeight", "GameResolutionWidth", "GameResolutionHeight", "LightingQuality", "LegacyBlendedShadows", "LegacyPerspective", "SdGamma", "HdGamma", "Contrast",
					"VsyncEnabled", "FramerateCapMode", "WindowMode", "TextureQuality", "TextureAnisotropy", "AmbientOcclusionQuality", "CharacterDetailQuality", "EnvironmentDetailQuality", "AtmosphericsQuality", "TransparencyQuality",
					"ShadowQuality", "AntiAliasingMode", "HdrCalibration", "DynamicResolutionScaling", "FrameRateTarget"
				}, null, null, null, null)
			}));
		}

		// Token: 0x0400275A RID: 10074
		private static FileDescriptor descriptor;
	}
}
