using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x020002FB RID: 763
	public static class AppInitializedReflection
	{
		// Token: 0x1700199E RID: 6558
		// (get) Token: 0x0600503D RID: 20541 RVA: 0x0013439C File Offset: 0x0013259C
		public static FileDescriptor Descriptor
		{
			get
			{
				return AppInitializedReflection.descriptor;
			}
		}

		// Token: 0x0600503E RID: 20542 RVA: 0x001343B4 File Offset: 0x001325B4
		static AppInitializedReflection()
		{
			byte[] array = Convert.FromBase64String("ChRBcHBJbml0aWFsaXplZC5wcm90bxIjQmxpenphcmQuVGVsZW1ldHJ5LkZl" + "bnJpcy5DbGllbnQudjEiLAoOQXBwSW5pdGlhbGl6ZWQSGgoSaW5pdGlsaXph" + "dGlvbl90aW1lGAEgASgC");
			AppInitializedReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(AppInitialized), AppInitialized.Parser, new string[] { "InitilizationTime" }, null, null, null, null)
			}));
		}

		// Token: 0x04002413 RID: 9235
		private static FileDescriptor descriptor;
	}
}
