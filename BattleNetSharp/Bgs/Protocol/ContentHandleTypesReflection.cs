using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x0200034E RID: 846
	public static class ContentHandleTypesReflection
	{
		// Token: 0x17001C88 RID: 7304
		// (get) Token: 0x060057F8 RID: 22520 RVA: 0x00154750 File Offset: 0x00152950
		public static FileDescriptor Descriptor
		{
			get
			{
				return ContentHandleTypesReflection.descriptor;
			}
		}

		// Token: 0x060057F9 RID: 22521 RVA: 0x00154768 File Offset: 0x00152968
		static ContentHandleTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "CixiZ3MvbG93L3BiL2NsaWVudC9jb250ZW50X2hhbmRsZV90eXBlcy5wcm90", "bxIMYmdzLnByb3RvY29sIk8KDUNvbnRlbnRIYW5kbGUSDgoGcmVnaW9uGAEg", "AigHEg0KBXVzYWdlGAIgAigHEgwKBGhhc2gYAyACKAwSEQoJcHJvdG9fdXJs", "GAQgASgJIl8KFlRpdGxlSWNvbkNvbnRlbnRIYW5kbGUSEAoIdGl0bGVfaWQY", "ASABKA0SMwoOY29udGVudF9oYW5kbGUYAiABKAsyGy5iZ3MucHJvdG9jb2wu", "Q29udGVudEhhbmRsZUIkCgxiZ3MucHJvdG9jb2xCEkNvbnRlbnRIYW5kbGVQ", "cm90b0gB" }));
			ContentHandleTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ContentHandle), ContentHandle.Parser, new string[] { "Region", "Usage", "Hash", "ProtoUrl" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(TitleIconContentHandle), TitleIconContentHandle.Parser, new string[] { "TitleId", "ContentHandle" }, null, null, null, null)
			}));
		}

		// Token: 0x0400282A RID: 10282
		private static FileDescriptor descriptor;
	}
}
