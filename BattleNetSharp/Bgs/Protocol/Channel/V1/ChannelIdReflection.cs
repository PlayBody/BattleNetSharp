using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006B5 RID: 1717
	public static class ChannelIdReflection
	{
		// Token: 0x17003151 RID: 12625
		// (get) Token: 0x06009EE2 RID: 40674 RVA: 0x0026A4F0 File Offset: 0x002686F0
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChannelIdReflection.descriptor;
			}
		}

		// Token: 0x06009EE3 RID: 40675 RVA: 0x0026A508 File Offset: 0x00268708
		static ChannelIdReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "CjBiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YxL2NoYW5uZWxfaWQu", "cHJvdG8SF2Jncy5wcm90b2NvbC5jaGFubmVsLnYxGiFiZ3MvbG93L3BiL2Ns", "aWVudC9ycGNfdHlwZXMucHJvdG8iXAoJQ2hhbm5lbElkEgwKBHR5cGUYASAB", "KA0SJQoEaG9zdBgCIAEoCzIXLmJncy5wcm90b2NvbC5Qcm9jZXNzSWQSCgoC", "aWQYAyABKAcSDgoGcmVnaW9uGAQgASgNQgJIAQ==" }));
			ChannelIdReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { RpcTypesReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ChannelId), ChannelId.Parser, new string[] { "Type", "Host", "Id", "Region" }, null, null, null, null)
			}));
		}

		// Token: 0x040047AD RID: 18349
		private static FileDescriptor descriptor;
	}
}
