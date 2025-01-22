using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x02000342 RID: 834
	public static class SettingsGameUiReflection
	{
		// Token: 0x17001C39 RID: 7225
		// (get) Token: 0x0600570E RID: 22286 RVA: 0x00151180 File Offset: 0x0014F380
		public static FileDescriptor Descriptor
		{
			get
			{
				return SettingsGameUiReflection.descriptor;
			}
		}

		// Token: 0x0600570F RID: 22287 RVA: 0x00151198 File Offset: 0x0014F398
		static SettingsGameUiReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "ChZzZXR0aW5nc19nYW1lX3VpLnByb3RvEiBCbGl6emFyZC5UZWxlbWV0cnku", "RmVud2F5LkNsaWVudCKjAQoKVUlTZXR0aW5ncxIjChtza2lsbF9hbW1vX2Zl", "ZWRiYWNrX2VuYWJsZWQYASABKAgSJQodY29udHJvbGxlcl9jdXJzb3Jfc2Vu", "c2l0aXZpdHkYAiABKAUSMQopc2Vjb25kYXJ5X3dlYXBvbnNfdW5pcXVlX2Jp", "bmRpbmdzX2VuYWJsZWQYAyABKAgSFgoOY2hhdF9mb250X3NpemUYBSABKA0=" }));
			SettingsGameUiReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(UISettings), UISettings.Parser, new string[] { "SkillAmmoFeedbackEnabled", "ControllerCursorSensitivity", "SecondaryWeaponsUniqueBindingsEnabled", "ChatFontSize" }, null, null, null, null)
			}));
		}

		// Token: 0x040027BF RID: 10175
		private static FileDescriptor descriptor;
	}
}
