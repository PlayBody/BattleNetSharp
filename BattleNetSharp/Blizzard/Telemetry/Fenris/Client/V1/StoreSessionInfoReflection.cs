using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x02000317 RID: 791
	public static class StoreSessionInfoReflection
	{
		// Token: 0x17001ABE RID: 6846
		// (get) Token: 0x06005316 RID: 21270 RVA: 0x00140DA0 File Offset: 0x0013EFA0
		public static FileDescriptor Descriptor
		{
			get
			{
				return StoreSessionInfoReflection.descriptor;
			}
		}

		// Token: 0x06005317 RID: 21271 RVA: 0x00140DB8 File Offset: 0x0013EFB8
		static StoreSessionInfoReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "ChZTdG9yZVNlc3Npb25JbmZvLnByb3RvEiNCbGl6emFyZC5UZWxlbWV0cnku", "RmVucmlzLkNsaWVudC52MSI8ChBTdG9yZVRlc3RpbmdJbmZvEhcKD2V4cGVy", "aW1lbnRfbmFtZRgBIAEoCRIPCgd2YXJpYW50GAIgASgJIsQBChBTdG9yZVNl", "c3Npb25JbmZvEhoKEnN0b3JlX3Nlc3Npb25fZ3VpZBgBIAEoCRIXCg9nYW1l", "X3Nlc3Npb25faWQYAiABKAkSGAoQc2Vzc2lvbl9kdXJhdGlvbhgDIAEoDRIV", "Cg10ZXN0aW5nX2dyb3VwGAQgASgNEkoKC2V4cGVyaW1lbnRzGAUgAygLMjUu", "QmxpenphcmQuVGVsZW1ldHJ5LkZlbnJpcy5DbGllbnQudjEuU3RvcmVUZXN0", "aW5nSW5mbw==" }));
			StoreSessionInfoReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(StoreTestingInfo), StoreTestingInfo.Parser, new string[] { "ExperimentName", "Variant" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(StoreSessionInfo), StoreSessionInfo.Parser, new string[] { "StoreSessionGuid", "GameSessionId", "SessionDuration", "TestingGroup", "Experiments" }, null, null, null, null)
			}));
		}

		// Token: 0x040025AB RID: 9643
		private static FileDescriptor descriptor;
	}
}
