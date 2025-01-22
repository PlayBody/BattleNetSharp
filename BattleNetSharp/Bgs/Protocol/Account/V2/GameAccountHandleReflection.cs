using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V2
{
	// Token: 0x0200070D RID: 1805
	public static class GameAccountHandleReflection
	{
		// Token: 0x17003327 RID: 13095
		// (get) Token: 0x0600A597 RID: 42391 RVA: 0x00284C78 File Offset: 0x00282E78
		public static FileDescriptor Descriptor
		{
			get
			{
				return GameAccountHandleReflection.descriptor;
			}
		}

		// Token: 0x0600A598 RID: 42392 RVA: 0x00284C90 File Offset: 0x00282E90
		static GameAccountHandleReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "CjliZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL2dhbWVfYWNjb3Vu", "dF9oYW5kbGUucHJvdG8SF2Jncy5wcm90b2NvbC5hY2NvdW50LnYyGiFiZ3Mv", "bG93L3BiL2NsaWVudC9ycGNfdHlwZXMucHJvdG8iQQoRR2FtZUFjY291bnRI", "YW5kbGUSCgoCaWQYASABKAQSEAoIdGl0bGVfaWQYAiABKA0SDgoGcmVnaW9u", "GAMgASgN" }));
			GameAccountHandleReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { RpcTypesReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(GameAccountHandle), GameAccountHandle.Parser, new string[] { "Id", "TitleId", "Region" }, null, null, null, null)
			}));
		}

		// Token: 0x04004A7A RID: 19066
		private static FileDescriptor descriptor;
	}
}
