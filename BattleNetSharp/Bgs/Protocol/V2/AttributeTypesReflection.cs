using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.V2
{
	// Token: 0x0200062A RID: 1578
	public static class AttributeTypesReflection
	{
		// Token: 0x17002E09 RID: 11785
		// (get) Token: 0x06009368 RID: 37736 RVA: 0x0023B388 File Offset: 0x00239588
		public static FileDescriptor Descriptor
		{
			get
			{
				return AttributeTypesReflection.descriptor;
			}
		}

		// Token: 0x06009369 RID: 37737 RVA: 0x0023B3A0 File Offset: 0x002395A0
		static AttributeTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjViZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL2F0dHJpYnV0ZV90", "eXBlcy5wcm90bxIPYmdzLnByb3RvY29sLnYyIpcBCgdWYXJpYW50EhQKCmJv", "b2xfdmFsdWUYASABKAhIABITCglpbnRfdmFsdWUYAiABKANIABIVCgtmbG9h", "dF92YWx1ZRgDIAEoAUgAEhYKDHN0cmluZ192YWx1ZRgEIAEoCUgAEhQKCmJs", "b2JfdmFsdWUYBSABKAxIABIUCgp1aW50X3ZhbHVlGAYgASgESABCBgoEdHlw", "ZSJCCglBdHRyaWJ1dGUSDAoEbmFtZRgBIAEoCRInCgV2YWx1ZRgCIAEoCzIY", "LmJncy5wcm90b2NvbC52Mi5WYXJpYW50ItABCg9BdHRyaWJ1dGVGaWx0ZXIS", "NgoCb3AYASABKA4yKi5iZ3MucHJvdG9jb2wudjIuQXR0cmlidXRlRmlsdGVy", "Lk9wZXJhdGlvbhItCglhdHRyaWJ1dGUYAiADKAsyGi5iZ3MucHJvdG9jb2wu", "djIuQXR0cmlidXRlIlYKCU9wZXJhdGlvbhIOCgpNQVRDSF9OT05FEAASDQoJ",
				"TUFUQ0hfQU5ZEAESDQoJTUFUQ0hfQUxMEAISGwoXTUFUQ0hfQUxMX01PU1Rf", "U1BFQ0lGSUMQA0ICSAE="
			}));
			AttributeTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(Variant), Variant.Parser, new string[] { "BoolValue", "IntValue", "FloatValue", "StringValue", "BlobValue", "UintValue" }, new string[] { "Type" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(Attribute), Attribute.Parser, new string[] { "Name", "Value" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AttributeFilter), AttributeFilter.Parser, new string[] { "Op", "Attribute" }, null, new Type[] { typeof(AttributeFilter.Types.Operation) }, null, null)
			}));
		}

		// Token: 0x04004291 RID: 17041
		private static FileDescriptor descriptor;
	}
}
