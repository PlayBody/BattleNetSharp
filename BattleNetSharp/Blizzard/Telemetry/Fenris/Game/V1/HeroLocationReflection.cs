using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Game.V1
{
	// Token: 0x020002ED RID: 749
	public static class HeroLocationReflection
	{
		// Token: 0x17001933 RID: 6451
		// (get) Token: 0x06004F1C RID: 20252 RVA: 0x0012FA6C File Offset: 0x0012DC6C
		public static FileDescriptor Descriptor
		{
			get
			{
				return HeroLocationReflection.descriptor;
			}
		}

		// Token: 0x06004F1D RID: 20253 RVA: 0x0012FA84 File Offset: 0x0012DC84
		static HeroLocationReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "ChJIZXJvTG9jYXRpb24ucHJvdG8SIUJsaXp6YXJkLlRlbGVtZXRyeS5GZW5y", "aXMuR2FtZS52MSKvAQoMSGVyb0xvY2F0aW9uEhEKCXdvcmxkX3NubxgBIAEo", "ERIPCgd3b3JsZF94GAIgASgCEg8KB3dvcmxkX3kYAyABKAISDwoHd29ybGRf", "ehgEIAEoAhIRCglzY2VuZV9zbm8YBSABKBESDwoHc2NlbmVfeBgGIAEoAhIP", "CgdzY2VuZV95GAcgASgCEg8KB3NjZW5lX3oYCCABKAISEwoLc3Viem9uZV9z", "bm8YCSABKBE=" }));
			HeroLocationReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(HeroLocation), HeroLocation.Parser, new string[] { "WorldSno", "WorldX", "WorldY", "WorldZ", "SceneSno", "SceneX", "SceneY", "SceneZ", "SubzoneSno" }, null, null, null, null)
			}));
		}

		// Token: 0x0400237C RID: 9084
		private static FileDescriptor descriptor;
	}
}
