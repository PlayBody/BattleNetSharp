using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Game.V1
{
	// Token: 0x020002E7 RID: 743
	public static class FenrisTraceReflection
	{
		// Token: 0x170018D8 RID: 6360
		// (get) Token: 0x06004E4B RID: 20043 RVA: 0x0012BA08 File Offset: 0x00129C08
		public static FileDescriptor Descriptor
		{
			get
			{
				return FenrisTraceReflection.descriptor;
			}
		}

		// Token: 0x06004E4C RID: 20044 RVA: 0x0012BA20 File Offset: 0x00129C20
		static FenrisTraceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "ChFGZW5yaXNUcmFjZS5wcm90bxIhQmxpenphcmQuVGVsZW1ldHJ5LkZlbnJp", "cy5HYW1lLnYxItwBCgtGZW5yaXNUcmFjZRIQCgh0cmFjZV9pZBgBIAEoCRIW", "Cg5wYXJlbnRfc3Bhbl9pZBgCIAEoCRIPCgdzcGFuX2lkGAMgASgJEhQKDHJl", "cXVlc3RfdGltZRgEIAEoBBIQCghkdXJhdGlvbhgFIAEoBBITCgtzZXJ2ZXJf", "bmFtZRgGIAEoCRIRCglzcGFuX25hbWUYByABKAkSFwoPZ2FtZV9hY2NvdW50", "X2lkGAggASgNEgwKBG5hbWUYCSABKAkSCwoDbG9nGAogAygJEg4KBnN0YXR1", "cxgLIAEoBQ==" }));
			FenrisTraceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(FenrisTrace), FenrisTrace.Parser, new string[]
				{
					"TraceId", "ParentSpanId", "SpanId", "RequestTime", "Duration", "ServerName", "SpanName", "GameAccountId", "Name", "Log",
					"Status"
				}, null, null, null, null)
			}));
		}

		// Token: 0x040022EF RID: 8943
		private static FileDescriptor descriptor;
	}
}
