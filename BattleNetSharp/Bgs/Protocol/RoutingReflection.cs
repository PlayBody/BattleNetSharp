using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000377 RID: 887
	public static class RoutingReflection
	{
		// Token: 0x17001D64 RID: 7524
		// (get) Token: 0x06005AC2 RID: 23234 RVA: 0x0015F064 File Offset: 0x0015D264
		public static FileDescriptor Descriptor
		{
			get
			{
				return RoutingReflection.descriptor;
			}
		}

		// Token: 0x06005AC3 RID: 23235 RVA: 0x0015F07C File Offset: 0x0015D27C
		static RoutingReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "CjFiZ3MvbG93L3BiL2NsaWVudC9nbG9iYWxfZXh0ZW5zaW9ucy9yb3V0aW5n", "LnByb3RvEgxiZ3MucHJvdG9jb2wqxAEKGUNsaWVudElkZW50aXR5Um91dGlu", "Z1R5cGUSJAogQ0xJRU5UX0lERU5USVRZX1JPVVRJTkdfRElTQUJMRUQQABIu", "CipDTElFTlRfSURFTlRJVFlfUk9VVElOR19CQVRUTEVfTkVUX0FDQ09VTlQQ", "ARIoCiRDTElFTlRfSURFTlRJVFlfUk9VVElOR19HQU1FX0FDQ09VTlQQAhIn", "CiNDTElFTlRfSURFTlRJVFlfUk9VVElOR19JTlNUQU5DRV9JRBAD" }));
			RoutingReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[] { typeof(ClientIdentityRoutingType) }, null, null));
		}

		// Token: 0x04002956 RID: 10582
		private static FileDescriptor descriptor;
	}
}
