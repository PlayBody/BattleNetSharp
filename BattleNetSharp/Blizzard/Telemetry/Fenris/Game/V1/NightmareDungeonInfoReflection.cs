using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Game.V1
{
	// Token: 0x020002F3 RID: 755
	public static class NightmareDungeonInfoReflection
	{
		// Token: 0x17001971 RID: 6513
		// (get) Token: 0x06004FB9 RID: 20409 RVA: 0x0013251C File Offset: 0x0013071C
		public static FileDescriptor Descriptor
		{
			get
			{
				return NightmareDungeonInfoReflection.descriptor;
			}
		}

		// Token: 0x06004FBA RID: 20410 RVA: 0x00132534 File Offset: 0x00130734
		static NightmareDungeonInfoReflection()
		{
			byte[] array = Convert.FromBase64String("ChpOaWdodG1hcmVEdW5nZW9uSW5mby5wcm90bxIhQmxpenphcmQuVGVsZW1l" + "dHJ5LkZlbnJpcy5HYW1lLnYxIlIKFE5pZ2h0bWFyZUR1bmdlb25JbmZvEhIK" + "CnNpZ2lsX3RpZXIYASABKAUSEwoLYWZmbGljdGlvbnMYAiADKBESEQoJd29y" + "bGRfc25vGAMgASgR");
			NightmareDungeonInfoReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(NightmareDungeonInfo), NightmareDungeonInfo.Parser, new string[] { "SigilTier", "Afflictions", "WorldSno" }, null, null, null, null)
			}));
		}

		// Token: 0x040023D4 RID: 9172
		private static FileDescriptor descriptor;
	}
}
