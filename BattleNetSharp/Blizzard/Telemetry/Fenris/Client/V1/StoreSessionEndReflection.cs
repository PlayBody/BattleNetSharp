using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x02000315 RID: 789
	public static class StoreSessionEndReflection
	{
		// Token: 0x17001AB9 RID: 6841
		// (get) Token: 0x06005301 RID: 21249 RVA: 0x001409A4 File Offset: 0x0013EBA4
		public static FileDescriptor Descriptor
		{
			get
			{
				return StoreSessionEndReflection.descriptor;
			}
		}

		// Token: 0x06005302 RID: 21250 RVA: 0x001409BC File Offset: 0x0013EBBC
		static StoreSessionEndReflection()
		{
			byte[] array = Convert.FromBase64String("ChVTdG9yZVNlc3Npb25FbmQucHJvdG8SI0JsaXp6YXJkLlRlbGVtZXRyeS5G" + "ZW5yaXMuQ2xpZW50LnYxGhZTdG9yZVNlc3Npb25JbmZvLnByb3RvIl4KD1N0" + "b3JlU2Vzc2lvbkVuZBJLCgxzZXNzaW9uX2luZm8YASABKAsyNS5CbGl6emFy" + "ZC5UZWxlbWV0cnkuRmVucmlzLkNsaWVudC52MS5TdG9yZVNlc3Npb25JbmZv");
			StoreSessionEndReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { StoreSessionInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(StoreSessionEnd), StoreSessionEnd.Parser, new string[] { "SessionInfo" }, null, null, null, null)
			}));
		}

		// Token: 0x040025A6 RID: 9638
		private static FileDescriptor descriptor;
	}
}
