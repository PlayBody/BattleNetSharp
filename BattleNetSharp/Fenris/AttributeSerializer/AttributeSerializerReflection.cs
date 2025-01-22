using System;
using Google.Protobuf.Reflection;

namespace Fenris.AttributeSerializer
{
	// Token: 0x020002BF RID: 703
	public static class AttributeSerializerReflection
	{
		// Token: 0x170017CF RID: 6095
		// (get) Token: 0x06004AE7 RID: 19175 RVA: 0x0011EE20 File Offset: 0x0011D020
		public static FileDescriptor Descriptor
		{
			get
			{
				return AttributeSerializerReflection.descriptor;
			}
		}

		// Token: 0x06004AE8 RID: 19176 RVA: 0x0011EE38 File Offset: 0x0011D038
		static AttributeSerializerReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "ChlBdHRyaWJ1dGVTZXJpYWxpemVyLnByb3RvEhpGZW5yaXMuQXR0cmlidXRl", "U2VyaWFsaXplciIsCg5TYXZlZEF0dHJpYnV0ZRILCgNrZXkYASACKBISDQoF", "dmFsdWUYAiACKBEiUQoPU2F2ZWRBdHRyaWJ1dGVzEj4KCmF0dHJpYnV0ZXMY", "ASADKAsyKi5GZW5yaXMuQXR0cmlidXRlU2VyaWFsaXplci5TYXZlZEF0dHJp", "YnV0ZQ==" }));
			AttributeSerializerReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(SavedAttribute), SavedAttribute.Parser, new string[] { "Key", "Value" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SavedAttributes), SavedAttributes.Parser, new string[] { "Attributes" }, null, null, null, null)
			}));
		}

		// Token: 0x04002176 RID: 8566
		private static FileDescriptor descriptor;
	}
}
