using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x02000323 RID: 803
	public static class CommonCharacterDetailsReflection
	{
		// Token: 0x17001B20 RID: 6944
		// (get) Token: 0x06005424 RID: 21540 RVA: 0x001452EC File Offset: 0x001434EC
		public static FileDescriptor Descriptor
		{
			get
			{
				return CommonCharacterDetailsReflection.descriptor;
			}
		}

		// Token: 0x06005425 RID: 21541 RVA: 0x00145304 File Offset: 0x00143504
		static CommonCharacterDetailsReflection()
		{
			byte[] array = Convert.FromBase64String("Ch5jb21tb25fY2hhcmFjdGVyX2RldGFpbHMucHJvdG8SIEJsaXp6YXJkLlRl" + "bGVtZXRyeS5GZW53YXkuQ2xpZW50IkEKEENoYXJhY3RlckRldGFpbHMSFAoM" + "Y2hhcmFjdGVyX2lkGAEgASgJEhcKD2NoYXJhY3Rlcl9jbGFzcxgCIAEoCQ==");
			CommonCharacterDetailsReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(CharacterDetails), CharacterDetails.Parser, new string[] { "CharacterId", "CharacterClass" }, null, null, null, null)
			}));
		}

		// Token: 0x04002636 RID: 9782
		private static FileDescriptor descriptor;
	}
}
