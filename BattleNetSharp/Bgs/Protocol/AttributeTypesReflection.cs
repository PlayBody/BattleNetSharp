using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x0200034A RID: 842
	public static class AttributeTypesReflection
	{
		// Token: 0x17001C67 RID: 7271
		// (get) Token: 0x06005796 RID: 22422 RVA: 0x00152F90 File Offset: 0x00151190
		public static FileDescriptor Descriptor
		{
			get
			{
				return AttributeTypesReflection.descriptor;
			}
		}

		// Token: 0x06005797 RID: 22423 RVA: 0x00152FA8 File Offset: 0x001511A8
		static AttributeTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CidiZ3MvbG93L3BiL2NsaWVudC9hdHRyaWJ1dGVfdHlwZXMucHJvdG8SDGJn", "cy5wcm90b2NvbBokYmdzL2xvdy9wYi9jbGllbnQvZW50aXR5X3R5cGVzLnBy", "b3RvIuEBCgdWYXJpYW50EhIKCmJvb2xfdmFsdWUYAiABKAgSEQoJaW50X3Zh", "bHVlGAMgASgDEhMKC2Zsb2F0X3ZhbHVlGAQgASgBEhQKDHN0cmluZ192YWx1", "ZRgFIAEoCRISCgpibG9iX3ZhbHVlGAYgASgMEhUKDW1lc3NhZ2VfdmFsdWUY", "ByABKAwSFAoMZm91cmNjX3ZhbHVlGAggASgJEhIKCnVpbnRfdmFsdWUYCSAB", "KAQSLwoPZW50aXR5X2lkX3ZhbHVlGAogASgLMhYuYmdzLnByb3RvY29sLkVu", "dGl0eUlkIj8KCUF0dHJpYnV0ZRIMCgRuYW1lGAEgAigJEiQKBXZhbHVlGAIg", "AigLMhUuYmdzLnByb3RvY29sLlZhcmlhbnQiygEKD0F0dHJpYnV0ZUZpbHRl", "chIzCgJvcBgBIAIoDjInLmJncy5wcm90b2NvbC5BdHRyaWJ1dGVGaWx0ZXIu",
				"T3BlcmF0aW9uEioKCWF0dHJpYnV0ZRgCIAMoCzIXLmJncy5wcm90b2NvbC5B", "dHRyaWJ1dGUiVgoJT3BlcmF0aW9uEg4KCk1BVENIX05PTkUQABINCglNQVRD", "SF9BTlkQARINCglNQVRDSF9BTEwQAhIbChdNQVRDSF9BTExfTU9TVF9TUEVD", "SUZJQxADQiAKDGJncy5wcm90b2NvbEIOQXR0cmlidXRlUHJvdG9IAQ=="
			}));
			AttributeTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { EntityTypesReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(Variant), Variant.Parser, new string[] { "BoolValue", "IntValue", "FloatValue", "StringValue", "BlobValue", "MessageValue", "FourccValue", "UintValue", "EntityIdValue" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Attribute), Attribute.Parser, new string[] { "Name", "Value" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AttributeFilter), AttributeFilter.Parser, new string[] { "Op", "Attribute" }, null, new Type[] { typeof(AttributeFilter.Types.Operation) }, null, null)
			}));
		}

		// Token: 0x040027FC RID: 10236
		private static FileDescriptor descriptor;
	}
}
