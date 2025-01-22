using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000375 RID: 885
	public static class RegisterMethodTypesReflection
	{
		// Token: 0x17001D63 RID: 7523
		// (get) Token: 0x06005AC0 RID: 23232 RVA: 0x0015EFD0 File Offset: 0x0015D1D0
		public static FileDescriptor Descriptor
		{
			get
			{
				return RegisterMethodTypesReflection.descriptor;
			}
		}

		// Token: 0x06005AC1 RID: 23233 RVA: 0x0015EFE8 File Offset: 0x0015D1E8
		static RegisterMethodTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "Cj9iZ3MvbG93L3BiL2NsaWVudC9nbG9iYWxfZXh0ZW5zaW9ucy9yZWdpc3Rl", "cl9tZXRob2RfdHlwZXMucHJvdG8SDGJncy5wcm90b2NvbCqlAQoYQ2xpZW50", "UmVnaXN0ZXJNZXRob2RUeXBlEhgKFFJFR0lTVEVSX0NMSUVOVF9OT05FEAAS", "HgoaUkVHSVNURVJfQ0xJRU5UX1JFR0lTVEVSRUQQARIgChxSRUdJU1RFUl9D", "TElFTlRfVU5SRUdJU1RFUkVEEAISLQopUkVHSVNURVJfQ0xJRU5UX1VOUkVH", "SVNURVJFRF9OT1RJRklDQVRJT04QAw==" }));
			RegisterMethodTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[] { typeof(ClientRegisterMethodType) }, null, null));
		}

		// Token: 0x04002950 RID: 10576
		private static FileDescriptor descriptor;
	}
}
