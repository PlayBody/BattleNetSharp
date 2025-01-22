using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x020002F9 RID: 761
	public static class ABTestInfoReflection
	{
		// Token: 0x17001992 RID: 6546
		// (get) Token: 0x0600501A RID: 20506 RVA: 0x00133BF8 File Offset: 0x00131DF8
		public static FileDescriptor Descriptor
		{
			get
			{
				return ABTestInfoReflection.descriptor;
			}
		}

		// Token: 0x0600501B RID: 20507 RVA: 0x00133C10 File Offset: 0x00131E10
		static ABTestInfoReflection()
		{
			byte[] array = Convert.FromBase64String("ChBBQlRlc3RJbmZvLnByb3RvEiNCbGl6emFyZC5UZWxlbWV0cnkuRmVucmlz" + "LkNsaWVudC52MSJhCg1BQlRlc3RpbmdJbmZvEhAKCHRlc3Rfc25vGAEgASgR" + "EhUKDXZhcmlhbnRfaW5kZXgYAiABKA0SEQoJdGVzdF9uYW1lGAMgASgJEhQK" + "DHZhcmlhbnRfbmFtZRgEIAEoCQ==");
			ABTestInfoReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ABTestingInfo), ABTestingInfo.Parser, new string[] { "TestSno", "VariantIndex", "TestName", "VariantName" }, null, null, null, null)
			}));
		}

		// Token: 0x04002403 RID: 9219
		private static FileDescriptor descriptor;
	}
}
