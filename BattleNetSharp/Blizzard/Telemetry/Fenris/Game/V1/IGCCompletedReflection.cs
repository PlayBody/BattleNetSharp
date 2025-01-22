using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Game.V1
{
	// Token: 0x020002EF RID: 751
	public static class IGCCompletedReflection
	{
		// Token: 0x17001949 RID: 6473
		// (get) Token: 0x06004F53 RID: 20307 RVA: 0x00130924 File Offset: 0x0012EB24
		public static FileDescriptor Descriptor
		{
			get
			{
				return IGCCompletedReflection.descriptor;
			}
		}

		// Token: 0x06004F54 RID: 20308 RVA: 0x0013093C File Offset: 0x0012EB3C
		static IGCCompletedReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "ChJJR0NDb21wbGV0ZWQucHJvdG8SIUJsaXp6YXJkLlRlbGVtZXRyeS5GZW5y", "aXMuR2FtZS52MRoOSGVyb0luZm8ucHJvdG8ijgEKDElHQ0NvbXBsZXRlZBI5", "CgRoZXJvGAEgASgLMisuQmxpenphcmQuVGVsZW1ldHJ5LkZlbnJpcy5HYW1l", "LnYxLkhlcm9JbmZvEhgKEHNub19jb252ZXJzYXRpb24YAiABKBESFAoMZGFt", "YWdlX3Rha2VuGAMgASgIEhMKC2xvd19hdmdfZnBzGAQgASgC" }));
			IGCCompletedReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { HeroInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(IGCCompleted), IGCCompleted.Parser, new string[] { "Hero", "SnoConversation", "DamageTaken", "LowAvgFps" }, null, null, null, null)
			}));
		}

		// Token: 0x0400239B RID: 9115
		private static FileDescriptor descriptor;
	}
}
