using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x02000338 RID: 824
	public static class SettingsGameAutomapReflection
	{
		// Token: 0x17001BCF RID: 7119
		// (get) Token: 0x06005603 RID: 22019 RVA: 0x0014CA60 File Offset: 0x0014AC60
		public static FileDescriptor Descriptor
		{
			get
			{
				return SettingsGameAutomapReflection.descriptor;
			}
		}

		// Token: 0x06005604 RID: 22020 RVA: 0x0014CA78 File Offset: 0x0014AC78
		static SettingsGameAutomapReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "ChtzZXR0aW5nc19nYW1lX2F1dG9tYXAucHJvdG8SIEJsaXp6YXJkLlRlbGVt", "ZXRyeS5GZW53YXkuQ2xpZW50IroBCg9BdXRvTWFwU2V0dGluZ3MSFAoMYXV0", "b21hcF9zaXplGAEgASgNEhkKEW1pbmlfbWFwX2xvY2F0aW9uGAIgASgNEhkK", "EW9wYWNpdHlfZmFkZV9tb2RlGAMgASgNEhYKDmN1c3RvbV9vcGFjaXR5GAQg", "ASgFEhsKE2NlbnRlcl93aGVuX2NsZWFyZWQYBSABKAgSEgoKc2hvd19wYXJ0", "eRgGIAEoCBISCgpzaG93X25hbWVzGAcgASgI" }));
			SettingsGameAutomapReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(AutoMapSettings), AutoMapSettings.Parser, new string[] { "AutomapSize", "MiniMapLocation", "OpacityFadeMode", "CustomOpacity", "CenterWhenCleared", "ShowParty", "ShowNames" }, null, null, null, null)
			}));
		}

		// Token: 0x0400272B RID: 10027
		private static FileDescriptor descriptor;
	}
}
