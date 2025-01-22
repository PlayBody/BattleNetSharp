using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x0200033A RID: 826
	public static class SettingsGameGameplayReflection
	{
		// Token: 0x17001BE1 RID: 7137
		// (get) Token: 0x06005632 RID: 22066 RVA: 0x0014D62C File Offset: 0x0014B82C
		public static FileDescriptor Descriptor
		{
			get
			{
				return SettingsGameGameplayReflection.descriptor;
			}
		}

		// Token: 0x06005633 RID: 22067 RVA: 0x0014D644 File Offset: 0x0014B844
		static SettingsGameGameplayReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "ChxzZXR0aW5nc19nYW1lX2dhbWVwbGF5LnByb3RvEiBCbGl6emFyZC5UZWxl", "bWV0cnkuRmVud2F5LkNsaWVudCKNAQoQR2FtZXBsYXlTZXR0aW5ncxIZChFh", "dXRvX2NvbGxlY3RfZ29sZBgBIAEoCBIcChRjb21iYXRfZmVlZGJhY2tfdGV4", "dBgCIAEoCBIlCh1zZWxlY3RlZF9kZWZhdWx0X2tleV9iaW5kaW5ncxgDIAEo", "DRIZChFpdGVtX2Ryb3Bfc3BhY2luZxgEIAEoDQ==" }));
			SettingsGameGameplayReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(GameplaySettings), GameplaySettings.Parser, new string[] { "AutoCollectGold", "CombatFeedbackText", "SelectedDefaultKeyBindings", "ItemDropSpacing" }, null, null, null, null)
			}));
		}

		// Token: 0x04002744 RID: 10052
		private static FileDescriptor descriptor;
	}
}
