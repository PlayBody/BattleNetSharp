using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x0200031A RID: 794
	public static class StoreSessionStartReflection
	{
		// Token: 0x17001AD2 RID: 6866
		// (get) Token: 0x06005353 RID: 21331 RVA: 0x00141AF0 File Offset: 0x0013FCF0
		public static FileDescriptor Descriptor
		{
			get
			{
				return StoreSessionStartReflection.descriptor;
			}
		}

		// Token: 0x06005354 RID: 21332 RVA: 0x00141B08 File Offset: 0x0013FD08
		static StoreSessionStartReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "ChdTdG9yZVNlc3Npb25TdGFydC5wcm90bxIjQmxpenphcmQuVGVsZW1ldHJ5", "LkZlbnJpcy5DbGllbnQudjEaFlN0b3JlU2Vzc2lvbkluZm8ucHJvdG8iYAoR", "U3RvcmVTZXNzaW9uU3RhcnQSSwoMc2Vzc2lvbl9pbmZvGAEgASgLMjUuQmxp", "enphcmQuVGVsZW1ldHJ5LkZlbnJpcy5DbGllbnQudjEuU3RvcmVTZXNzaW9u", "SW5mbw==" }));
			StoreSessionStartReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { StoreSessionInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(StoreSessionStart), StoreSessionStart.Parser, new string[] { "SessionInfo" }, null, null, null, null)
			}));
		}

		// Token: 0x040025C6 RID: 9670
		private static FileDescriptor descriptor;
	}
}
