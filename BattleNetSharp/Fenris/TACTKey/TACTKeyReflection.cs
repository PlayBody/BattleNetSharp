using System;
using Google.Protobuf.Reflection;

namespace Fenris.TACTKey
{
	// Token: 0x0200010D RID: 269
	public static class TACTKeyReflection
	{
		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x060019B2 RID: 6578 RVA: 0x0005BA08 File Offset: 0x00059C08
		public static FileDescriptor Descriptor
		{
			get
			{
				return TACTKeyReflection.descriptor;
			}
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x0005BA20 File Offset: 0x00059C20
		static TACTKeyReflection()
		{
			byte[] array = Convert.FromBase64String("Cg1UQUNUS2V5LnByb3RvEg5GZW5yaXMuVEFDVEtleSJECgNLZXkSCgoCaWQY" + "ASABKAQSDQoFdmFsdWUYAiABKAwSDAoEbmFtZRgDIAEoCRIUCgxyZWxlYXNl" + "X2RhdGUYBCABKAkiSAoES2V5cxIhCgRrZXlzGAEgAygLMhMuRmVucmlzLlRB" + "Q1RLZXkuS2V5Eh0KFXNlY29uZHNfdW50aWxfcmVmcmVzaBgCIAEoBA==");
			TACTKeyReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(Key), Key.Parser, new string[] { "Id", "Value", "Name", "ReleaseDate" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Keys), Keys.Parser, new string[] { "Keys_", "SecondsUntilRefresh" }, null, null, null, null)
			}));
		}

		// Token: 0x04000A42 RID: 2626
		private static FileDescriptor descriptor;
	}
}
