using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Game.V1
{
	// Token: 0x020002F5 RID: 757
	public static class ParagonBoardPreviewRotateReflection
	{
		// Token: 0x1700197A RID: 6522
		// (get) Token: 0x06004FD5 RID: 20437 RVA: 0x00132B38 File Offset: 0x00130D38
		public static FileDescriptor Descriptor
		{
			get
			{
				return ParagonBoardPreviewRotateReflection.descriptor;
			}
		}

		// Token: 0x06004FD6 RID: 20438 RVA: 0x00132B50 File Offset: 0x00130D50
		static ParagonBoardPreviewRotateReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "Ch9QYXJhZ29uQm9hcmRQcmV2aWV3Um90YXRlLnByb3RvEiFCbGl6emFyZC5U", "ZWxlbWV0cnkuRmVucmlzLkdhbWUudjEaDkhlcm9JbmZvLnByb3RvIogBChlQ", "YXJhZ29uQm9hcmRQcmV2aWV3Um90YXRlEjkKBGhlcm8YASABKAsyKy5CbGl6", "emFyZC5UZWxlbWV0cnkuRmVucmlzLkdhbWUudjEuSGVyb0luZm8SGQoRc25v", "X3ByZXZpZXdfYm9hcmQYAiABKBESFQoNbnVtX3JvdGF0aW9ucxgDIAEoDQ==" }));
			ParagonBoardPreviewRotateReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { HeroInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ParagonBoardPreviewRotate), ParagonBoardPreviewRotate.Parser, new string[] { "Hero", "SnoPreviewBoard", "NumRotations" }, null, null, null, null)
			}));
		}

		// Token: 0x040023E1 RID: 9185
		private static FileDescriptor descriptor;
	}
}
