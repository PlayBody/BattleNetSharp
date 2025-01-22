using System;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x0200035F RID: 863
	public static class FieldOptionsReflection
	{
		// Token: 0x17001CE8 RID: 7400
		// (get) Token: 0x06005931 RID: 22833 RVA: 0x00158B9C File Offset: 0x00156D9C
		public static FileDescriptor Descriptor
		{
			get
			{
				return FieldOptionsReflection.descriptor;
			}
		}

		// Token: 0x06005932 RID: 22834 RVA: 0x00158BB4 File Offset: 0x00156DB4
		static FieldOptionsReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjdiZ3MvbG93L3BiL2NsaWVudC9nbG9iYWxfZXh0ZW5zaW9ucy9maWVsZF9v", "cHRpb25zLnByb3RvEgxiZ3MucHJvdG9jb2waIGdvb2dsZS9wcm90b2J1Zi9k", "ZXNjcmlwdG9yLnByb3RvGi9iZ3MvbG93L3BiL2NsaWVudC9nbG9iYWxfZXh0", "ZW5zaW9ucy9yYW5nZS5wcm90byKSAQoPQkdTRmllbGRPcHRpb25zEiQKA2xv", "ZxgBIAEoDjIXLmJncy5wcm90b2NvbC5Mb2dPcHRpb24SEQoJc2hhcmRfa2V5", "GAIgASgIEhIKCmZhbm91dF9rZXkYAyABKAgSGwoTY2xpZW50X2luc3RhbmNl", "X2tleRgEIAEoCBIVCg1yZWFsaXplZF9lbnVtGAUgASgJIuEDChBGaWVsZFJl", "c3RyaWN0aW9uEjYKBnNpZ25lZBgBIAEoCzIkLmJncy5wcm90b2NvbC5TaWdu", "ZWRGaWVsZFJlc3RyaWN0aW9uSAASOgoIdW5zaWduZWQYAiABKAsyJi5iZ3Mu", "cHJvdG9jb2wuVW5zaWduZWRGaWVsZFJlc3RyaWN0aW9uSAASNAoFZmxvYXQY",
				"AyABKAsyIy5iZ3MucHJvdG9jb2wuRmxvYXRGaWVsZFJlc3RyaWN0aW9uSAAS", "NgoGc3RyaW5nGAQgASgLMiQuYmdzLnByb3RvY29sLlN0cmluZ0ZpZWxkUmVz", "dHJpY3Rpb25IABI6CghyZXBlYXRlZBgFIAEoCzImLmJncy5wcm90b2NvbC5S", "ZXBlYXRlZEZpZWxkUmVzdHJpY3Rpb25IABI4CgdtZXNzYWdlGAYgASgLMiUu", "YmdzLnByb3RvY29sLk1lc3NhZ2VGaWVsZFJlc3RyaWN0aW9uSAASNgoJZW50", "aXR5X2lkGAcgASgLMiEuYmdzLnByb3RvY29sLkVudGl0eUlkUmVzdHJpY3Rp", "b25IABI1CgVieXRlcxgIIAEoCzIkLmJncy5wcm90b2NvbC5TdHJpbmdGaWVs", "ZFJlc3RyaWN0aW9uSABCBgoEdHlwZSKxAwoYUmVwZWF0ZWRGaWVsZFJlc3Ry", "aWN0aW9uEiwKBHNpemUYASABKAsyHi5iZ3MucHJvdG9jb2wuVW5zaWduZWRJ", "bnRSYW5nZRIOCgZ1bmlxdWUYAiABKAgSNgoGc2lnbmVkGAMgASgLMiQuYmdz",
				"LnByb3RvY29sLlNpZ25lZEZpZWxkUmVzdHJpY3Rpb25IABI6Cgh1bnNpZ25l", "ZBgEIAEoCzImLmJncy5wcm90b2NvbC5VbnNpZ25lZEZpZWxkUmVzdHJpY3Rp", "b25IABI0CgVmbG9hdBgFIAEoCzIjLmJncy5wcm90b2NvbC5GbG9hdEZpZWxk", "UmVzdHJpY3Rpb25IABI2CgZzdHJpbmcYBiABKAsyJC5iZ3MucHJvdG9jb2wu", "U3RyaW5nRmllbGRSZXN0cmljdGlvbkgAEjYKCWVudGl0eV9pZBgHIAEoCzIh", "LmJncy5wcm90b2NvbC5FbnRpdHlJZFJlc3RyaWN0aW9uSAASNQoFYnl0ZXMY", "CCABKAsyJC5iZ3MucHJvdG9jb2wuU3RyaW5nRmllbGRSZXN0cmljdGlvbkgA", "QgYKBHR5cGUiVwoWU2lnbmVkRmllbGRSZXN0cmljdGlvbhIsCgZsaW1pdHMY", "ASABKAsyHC5iZ3MucHJvdG9jb2wuU2lnbmVkSW50UmFuZ2USDwoHZXhjbHVk", "ZRgCIAMoEiJbChhVbnNpZ25lZEZpZWxkUmVzdHJpY3Rpb24SLgoGbGltaXRz",
				"GAEgASgLMh4uYmdzLnByb3RvY29sLlVuc2lnbmVkSW50UmFuZ2USDwoHZXhj", "bHVkZRgCIAMoBCJSChVGbG9hdEZpZWxkUmVzdHJpY3Rpb24SKAoGbGltaXRz", "GAEgASgLMhguYmdzLnByb3RvY29sLkZsb2F0UmFuZ2USDwoHZXhjbHVkZRgC", "IAMoAiJXChZTdHJpbmdGaWVsZFJlc3RyaWN0aW9uEiwKBHNpemUYASABKAsy", "Hi5iZ3MucHJvdG9jb2wuVW5zaWduZWRJbnRSYW5nZRIPCgdleGNsdWRlGAIg", "AygJIsIBChNFbnRpdHlJZFJlc3RyaWN0aW9uEg4KBm5lZWRlZBgBIAEoCBI0", "CgRraW5kGAIgASgOMiYuYmdzLnByb3RvY29sLkVudGl0eUlkUmVzdHJpY3Rp", "b24uS2luZCJlCgRLaW5kEgcKA0FOWRAAEgsKB0FDQ09VTlQQARIQCgxHQU1F", "X0FDQ09VTlQQAhIbChdBQ0NPVU5UX09SX0dBTUVfQUNDT1VOVBADEgsKB1NF", "UlZJQ0UQBBILCgdDSEFOTkVMEAUiKQoXTWVzc2FnZUZpZWxkUmVzdHJpY3Rp",
				"b24SDgoGbmVlZGVkGAEgASgIKiAKCUxvZ09wdGlvbhIKCgZISURERU4QARIH", "CgNIRVgQAjpVCg1maWVsZF9vcHRpb25zEh0uZ29vZ2xlLnByb3RvYnVmLkZp", "ZWxkT3B0aW9ucxiQvwUgASgLMh0uYmdzLnByb3RvY29sLkJHU0ZpZWxkT3B0", "aW9uczpOCgV2YWxpZBIdLmdvb2dsZS5wcm90b2J1Zi5GaWVsZE9wdGlvbnMY", "kb8FIAEoCzIeLmJncy5wcm90b2NvbC5GaWVsZFJlc3RyaWN0aW9uQiMKDGJn", "cy5wcm90b2NvbEIRRmllbGRPcHRpb25zUHJvdG9IAQ=="
			}));
			FieldOptionsReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				DescriptorReflection.Descriptor,
				RangeReflection.Descriptor
			}, new GeneratedClrTypeInfo(new Type[] { typeof(LogOption) }, new Extension[]
			{
				FieldOptionsExtensions.FieldOptions_,
				FieldOptionsExtensions.Valid
			}, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(BGSFieldOptions), BGSFieldOptions.Parser, new string[] { "Log", "ShardKey", "FanoutKey", "ClientInstanceKey", "RealizedEnum" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(FieldRestriction), FieldRestriction.Parser, new string[] { "Signed", "Unsigned", "Float", "String", "Repeated", "Message", "EntityId", "Bytes" }, new string[] { "Type" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(RepeatedFieldRestriction), RepeatedFieldRestriction.Parser, new string[] { "Size", "Unique", "Signed", "Unsigned", "Float", "String", "EntityId", "Bytes" }, new string[] { "Type" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(SignedFieldRestriction), SignedFieldRestriction.Parser, new string[] { "Limits", "Exclude" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UnsignedFieldRestriction), UnsignedFieldRestriction.Parser, new string[] { "Limits", "Exclude" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(FloatFieldRestriction), FloatFieldRestriction.Parser, new string[] { "Limits", "Exclude" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(StringFieldRestriction), StringFieldRestriction.Parser, new string[] { "Size", "Exclude" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(EntityIdRestriction), EntityIdRestriction.Parser, new string[] { "Needed", "Kind" }, null, new Type[] { typeof(EntityIdRestriction.Types.Kind) }, null, null),
				new GeneratedClrTypeInfo(typeof(MessageFieldRestriction), MessageFieldRestriction.Parser, new string[] { "Needed" }, null, null, null, null)
			}));
		}

		// Token: 0x040028AA RID: 10410
		private static FileDescriptor descriptor;
	}
}
