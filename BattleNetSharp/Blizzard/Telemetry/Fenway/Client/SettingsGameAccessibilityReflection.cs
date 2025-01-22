using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x02000334 RID: 820
	public static class SettingsGameAccessibilityReflection
	{
		// Token: 0x17001B97 RID: 7063
		// (get) Token: 0x0600557D RID: 21885 RVA: 0x0014A47C File Offset: 0x0014867C
		public static FileDescriptor Descriptor
		{
			get
			{
				return SettingsGameAccessibilityReflection.descriptor;
			}
		}

		// Token: 0x0600557E RID: 21886 RVA: 0x0014A494 File Offset: 0x00148694
		static SettingsGameAccessibilityReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "CiFzZXR0aW5nc19nYW1lX2FjY2Vzc2liaWxpdHkucHJvdG8SIEJsaXp6YXJk", "LlRlbGVtZXRyeS5GZW53YXkuQ2xpZW50IpYBChVBY2Nlc3NpYmlsaXR5U2V0", "dGluZ3MSHwoXbG93X3Zpc2lvbl9tb2RlX2VuYWJsZWQYASABKAgSGAoQY29s", "b3JfYmxpbmRfbW9kZRgCIAEoDRIZChFzdWJ0aXRsZXNfZW5hYmxlZBgDIAEo", "CBInCh9ucGNfZ3JlZXRpbmdzX3N1YnRpdGxlc19lbmFibGVkGAQgASgI" }));
			SettingsGameAccessibilityReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(AccessibilitySettings), AccessibilitySettings.Parser, new string[] { "LowVisionModeEnabled", "ColorBlindMode", "SubtitlesEnabled", "NpcGreetingsSubtitlesEnabled" }, null, null, null, null)
			}));
		}

		// Token: 0x040026DB RID: 9947
		private static FileDescriptor descriptor;
	}
}
