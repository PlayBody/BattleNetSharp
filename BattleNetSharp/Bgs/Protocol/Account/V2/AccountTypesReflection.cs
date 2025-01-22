using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V2
{
	// Token: 0x0200070B RID: 1803
	public static class AccountTypesReflection
	{
		// Token: 0x17003320 RID: 13088
		// (get) Token: 0x0600A57E RID: 42366 RVA: 0x00284700 File Offset: 0x00282900
		public static FileDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.descriptor;
			}
		}

		// Token: 0x0600A57F RID: 42367 RVA: 0x00284718 File Offset: 0x00282918
		static AccountTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "CjNiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL2FjY291bnRfdHlw", "ZXMucHJvdG8SF2Jncy5wcm90b2NvbC5hY2NvdW50LnYyGiFiZ3MvbG93L3Bi", "L2NsaWVudC9ycGNfdHlwZXMucHJvdG8aOWJncy9sb3cvcGIvY2xpZW50L2Fw", "aS9jbGllbnQvdjIvZ2FtZV9hY2NvdW50X2hhbmRsZS5wcm90byJdCghJZGVu", "dGl0eRIPCgdhY2NvdW50GAEgASgEEkAKDGdhbWVfYWNjb3VudBgCIAEoCzIq", "LmJncy5wcm90b2NvbC5hY2NvdW50LnYyLkdhbWVBY2NvdW50SGFuZGxl" }));
			AccountTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				RpcTypesReflection.Descriptor,
				GameAccountHandleReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(Identity), Identity.Parser, new string[] { "Account", "GameAccount" }, null, null, null, null)
			}));
		}

		// Token: 0x04004A71 RID: 19057
		private static FileDescriptor descriptor;
	}
}
