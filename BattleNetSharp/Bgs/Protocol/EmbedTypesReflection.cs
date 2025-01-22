using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000351 RID: 849
	public static class EmbedTypesReflection
	{
		// Token: 0x17001C9A RID: 7322
		// (get) Token: 0x06005832 RID: 22578 RVA: 0x001553E8 File Offset: 0x001535E8
		public static FileDescriptor Descriptor
		{
			get
			{
				return EmbedTypesReflection.descriptor;
			}
		}

		// Token: 0x06005833 RID: 22579 RVA: 0x00155400 File Offset: 0x00153600
		static EmbedTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "CiNiZ3MvbG93L3BiL2NsaWVudC9lbWJlZF90eXBlcy5wcm90bxIMYmdzLnBy", "b3RvY29sIjgKCkVtYmVkSW1hZ2USCwoDdXJsGAEgASgJEg0KBXdpZHRoGAIg", "ASgNEg4KBmhlaWdodBgDIAEoDSIYCghQcm92aWRlchIMCgRuYW1lGAEgASgJ", "IjsKCUVtYmVkSFRNTBIPCgdjb250ZW50GAEgASgJEg0KBXdpZHRoGAIgASgN", "Eg4KBmhlaWdodBgDIAEoDSLRAQoJRW1iZWRJbmZvEg0KBXRpdGxlGAEgASgJ", "EgwKBHR5cGUYAiABKAkSFAoMb3JpZ2luYWxfdXJsGAMgASgJEisKCXRodW1i", "bmFpbBgEIAEoCzIYLmJncy5wcm90b2NvbC5FbWJlZEltYWdlEigKCHByb3Zp", "ZGVyGAUgASgLMhYuYmdzLnByb3RvY29sLlByb3ZpZGVyEhMKC2Rlc2NyaXB0", "aW9uGAYgASgJEiUKBGh0bWwYCCABKAsyFy5iZ3MucHJvdG9jb2wuRW1iZWRI", "VE1M" }));
			EmbedTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(EmbedImage), EmbedImage.Parser, new string[] { "Url", "Width", "Height" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Provider), Provider.Parser, new string[] { "Name" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(EmbedHTML), EmbedHTML.Parser, new string[] { "Content", "Width", "Height" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(EmbedInfo), EmbedInfo.Parser, new string[] { "Title", "Type", "OriginalUrl", "Thumbnail", "Provider", "Description", "Html" }, null, null, null, null)
			}));
		}

		// Token: 0x04002842 RID: 10306
		private static FileDescriptor descriptor;
	}
}
