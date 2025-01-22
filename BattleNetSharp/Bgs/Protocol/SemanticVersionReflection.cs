using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000393 RID: 915
	public static class SemanticVersionReflection
	{
		// Token: 0x17001E3A RID: 7738
		// (get) Token: 0x06005D29 RID: 23849 RVA: 0x00168988 File Offset: 0x00166B88
		public static FileDescriptor Descriptor
		{
			get
			{
				return SemanticVersionReflection.descriptor;
			}
		}

		// Token: 0x06005D2A RID: 23850 RVA: 0x001689A0 File Offset: 0x00166BA0
		static SemanticVersionReflection()
		{
			byte[] array = Convert.FromBase64String("CihiZ3MvbG93L3BiL2NsaWVudC9zZW1hbnRpY192ZXJzaW9uLnByb3RvEgxi" + "Z3MucHJvdG9jb2wibgoPU2VtYW50aWNWZXJzaW9uEhUKDW1ham9yX3ZlcnNp" + "b24YASABKA0SFQoNbWlub3JfdmVyc2lvbhgCIAEoDRIVCg1wYXRjaF92ZXJz" + "aW9uGAMgASgNEhYKDnZlcnNpb25fc3RyaW5nGAQgASgJ");
			SemanticVersionReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(SemanticVersion), SemanticVersion.Parser, new string[] { "MajorVersion", "MinorVersion", "PatchVersion", "VersionString" }, null, null, null, null)
			}));
		}

		// Token: 0x04002AA3 RID: 10915
		private static FileDescriptor descriptor;
	}
}
