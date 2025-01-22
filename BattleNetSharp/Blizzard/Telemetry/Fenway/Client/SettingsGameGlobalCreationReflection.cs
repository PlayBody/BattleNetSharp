using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x0200033C RID: 828
	public static class SettingsGameGlobalCreationReflection
	{
		// Token: 0x17001BED RID: 7149
		// (get) Token: 0x06005655 RID: 22101 RVA: 0x0014DE08 File Offset: 0x0014C008
		public static FileDescriptor Descriptor
		{
			get
			{
				return SettingsGameGlobalCreationReflection.descriptor;
			}
		}

		// Token: 0x06005656 RID: 22102 RVA: 0x0014DE20 File Offset: 0x0014C020
		static SettingsGameGlobalCreationReflection()
		{
			byte[] array = Convert.FromBase64String("CiNzZXR0aW5nc19nYW1lX2dsb2JhbF9jcmVhdGlvbi5wcm90bxIgQmxpenph" + "cmQuVGVsZW1ldHJ5LkZlbndheS5DbGllbnQiNwoaR2xvYmFsR2FtZUNyZWF0" + "aW9uU2V0dGluZ3MSGQoRaXRlbV9kcm9wX3NwYWNpbmcYASABKAk=");
			SettingsGameGlobalCreationReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(GlobalGameCreationSettings), GlobalGameCreationSettings.Parser, new string[] { "ItemDropSpacing" }, null, null, null, null)
			}));
		}

		// Token: 0x04002754 RID: 10068
		private static FileDescriptor descriptor;
	}
}
