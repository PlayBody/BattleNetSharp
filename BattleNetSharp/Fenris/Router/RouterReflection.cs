using System;
using Fenris.Online;
using Google.Protobuf.Reflection;

namespace Fenris.Router
{
	// Token: 0x02000122 RID: 290
	public static class RouterReflection
	{
		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06001CE5 RID: 7397 RVA: 0x0006E834 File Offset: 0x0006CA34
		public static FileDescriptor Descriptor
		{
			get
			{
				return RouterReflection.descriptor;
			}
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x0006E84C File Offset: 0x0006CA4C
		static RouterReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "CgxSb3V0ZXIucHJvdG8SDUZlbnJpcy5Sb3V0ZXIaDE9ubGluZS5wcm90byJ1", "CgdDb25uZWN0EhcKD2dhbWVfYWNjb3VudF9pZBgBIAEoDRINCgV0b2tlbhgC", "IAEoBBIdChVjb250ZW50X2xpY2Vuc2VfbmFtZXMYAyADKAkSIwoFdHJhY2UY", "BCABKAsyFC5GZW5yaXMuT25saW5lLlRyYWNlIk8KDENvbm5lY3RMb2NhbBIX", "Cg9nYW1lX2FjY291bnRfaWQYASABKA0SFAoMaXNfcmVjb25uZWN0GAIgASgI", "EhAKCHVzZXJuYW1lGAMgASgJIlEKCUNvbm5lY3RlZBIXCg9ibmV0X2FjY291", "bnRfaWQYASABKA0SFwoPZ2FtZV9hY2NvdW50X2lkGAIgASgNEhIKCnNlc3Np", "b25faWQYAyABKAk=" }));
			RouterReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { OnlineReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(Connect), Connect.Parser, new string[] { "GameAccountId", "Token", "ContentLicenseNames", "Trace" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ConnectLocal), ConnectLocal.Parser, new string[] { "GameAccountId", "IsReconnect", "Username" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Connected), Connected.Parser, new string[] { "BnetAccountId", "GameAccountId", "SessionId" }, null, null, null, null)
			}));
		}

		// Token: 0x04000C4D RID: 3149
		private static FileDescriptor descriptor;
	}
}
