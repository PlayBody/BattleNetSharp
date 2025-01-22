using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Game.V1
{
	// Token: 0x020002F7 RID: 759
	public static class PlayerUpdateReflection
	{
		// Token: 0x17001983 RID: 6531
		// (get) Token: 0x06004FF2 RID: 20466 RVA: 0x001331F0 File Offset: 0x001313F0
		public static FileDescriptor Descriptor
		{
			get
			{
				return PlayerUpdateReflection.descriptor;
			}
		}

		// Token: 0x06004FF3 RID: 20467 RVA: 0x00133208 File Offset: 0x00131408
		static PlayerUpdateReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "ChJQbGF5ZXJVcGRhdGUucHJvdG8SIUJsaXp6YXJkLlRlbGVtZXRyeS5GZW5y", "aXMuR2FtZS52MRoOSGVyb0luZm8ucHJvdG8ixQEKDFBsYXllclVwZGF0ZRJA", "CgtwbGF5ZXJfbGlzdBgBIAMoCzIrLkJsaXp6YXJkLlRlbGVtZXRyeS5GZW5y", "aXMuR2FtZS52MS5IZXJvSW5mbxITCgtnYW1lX2hhbmRsZRgCIAEoCRIYChB1", "c2luZ19jb250cm9sbGVyGAMgASgIEhMKC2F2Z19sYXRlbmN5GAQgASgNEh4K", "FmxhZ19jb21wZW5zYXRpb25fdGlja3MYBSABKAISDwoHbW91bnRlZBgGIAEo", "CA==" }));
			PlayerUpdateReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { HeroInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(PlayerUpdate), PlayerUpdate.Parser, new string[] { "PlayerList", "GameHandle", "UsingController", "AvgLatency", "LagCompensationTicks", "Mounted" }, null, null, null, null)
			}));
		}

		// Token: 0x040023ED RID: 9197
		private static FileDescriptor descriptor;
	}
}
