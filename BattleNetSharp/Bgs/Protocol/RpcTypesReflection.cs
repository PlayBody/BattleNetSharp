using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000389 RID: 905
	public static class RpcTypesReflection
	{
		// Token: 0x17001DCF RID: 7631
		// (get) Token: 0x06005BF4 RID: 23540 RVA: 0x00163DD0 File Offset: 0x00161FD0
		public static FileDescriptor Descriptor
		{
			get
			{
				return RpcTypesReflection.descriptor;
			}
		}

		// Token: 0x06005BF5 RID: 23541 RVA: 0x00163DE8 File Offset: 0x00161FE8
		static RpcTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CiFiZ3MvbG93L3BiL2NsaWVudC9ycGNfdHlwZXMucHJvdG8SDGJncy5wcm90", "b2NvbBo3YmdzL2xvdy9wYi9jbGllbnQvZ2xvYmFsX2V4dGVuc2lvbnMvZmll", "bGRfb3B0aW9ucy5wcm90bxo4YmdzL2xvdy9wYi9jbGllbnQvZ2xvYmFsX2V4", "dGVuc2lvbnMvbWV0aG9kX29wdGlvbnMucHJvdG8aOWJncy9sb3cvcGIvY2xp", "ZW50L2dsb2JhbF9leHRlbnNpb25zL21lc3NhZ2Vfb3B0aW9ucy5wcm90bxo5", "YmdzL2xvdy9wYi9jbGllbnQvZ2xvYmFsX2V4dGVuc2lvbnMvc2VydmljZV9v", "cHRpb25zLnByb3RvIg0KC05PX1JFU1BPTlNFIigKB0FkZHJlc3MSDwoHYWRk", "cmVzcxgBIAIoCRIMCgRwb3J0GAIgASgNIjMKCVByb2Nlc3NJZBIXCgVsYWJl", "bBgBIAIoDUIIivkrBBICEAASDQoFZXBvY2gYAiACKA0iTAoNT2JqZWN0QWRk", "cmVzcxIlCgRob3N0GAEgAigLMhcuYmdzLnByb3RvY29sLlByb2Nlc3NJZBIU",
				"CglvYmplY3RfaWQYAiABKAQ6ATAiCAoGTm9EYXRhInkKCUVycm9ySW5mbxIz", "Cg5vYmplY3RfYWRkcmVzcxgBIAIoCzIbLmJncy5wcm90b2NvbC5PYmplY3RB", "ZGRyZXNzEg4KBnN0YXR1cxgCIAIoDRIUCgxzZXJ2aWNlX2hhc2gYAyACKA0S", "EQoJbWV0aG9kX2lkGAQgAigNIkEKDEZhbm91dFRhcmdldBIRCgljbGllbnRf", "aWQYASABKAkSCwoDa2V5GAIgASgMEhEKCW9iamVjdF9pZBgDIAEoBCL7AwoG", "SGVhZGVyEhIKCnNlcnZpY2VfaWQYASACKA0SEQoJbWV0aG9kX2lkGAIgASgN", "Eg0KBXRva2VuGAMgAigNEhQKCW9iamVjdF9pZBgEIAEoBDoBMBIPCgRzaXpl", "GAUgASgNOgEwEhEKBnN0YXR1cxgGIAEoDToBMBImCgVlcnJvchgHIAMoCzIX", "LmJncy5wcm90b2NvbC5FcnJvckluZm8SDwoHdGltZW91dBgIIAEoBBITCgtp", "c19yZXNwb25zZRgJIAEoCBIwCg9mb3J3YXJkX3RhcmdldHMYCiADKAsyFy5i",
				"Z3MucHJvdG9jb2wuUHJvY2Vzc0lkEhQKDHNlcnZpY2VfaGFzaBgLIAEoBxIS", "CgpyZXF1ZXN0X2lkGAwgASgJEhEKCWNsaWVudF9pZBgNIAEoCRIxCg1mYW5v", "dXRfdGFyZ2V0GA4gAygLMhouYmdzLnByb3RvY29sLkZhbm91dFRhcmdldBIf", "ChdjbGllbnRfaWRfZmFub3V0X3RhcmdldBgPIAMoCRIVCg1jbGllbnRfcmVj", "b3JkGBAgASgMEhcKD29yaWdpbmFsX3NlbmRlchgRIAEoDBIUCgxzZW5kZXJf", "dG9rZW4YEiABKA0SFAoMcm91dGVyX2xhYmVsGBMgASgNEhQKDGVycm9yX3Jl", "YXNvbhgUIAEoCSLqAQoLS2Fma2FIZWFkZXISFAoMc2VydmljZV9oYXNoGAEg", "ASgHEhEKCW1ldGhvZF9pZBgCIAEoDRINCgV0b2tlbhgDIAEoDRIUCglvYmpl", "Y3RfaWQYBCABKAQ6ATASDwoEc2l6ZRgFIAEoDToBMBIRCgZzdGF0dXMYBiAB", "KA06ATASDwoHdGltZW91dBgHIAEoBBIvCg5mb3J3YXJkX3RhcmdldBgIIAEo",
				"CzIXLmJncy5wcm90b2NvbC5Qcm9jZXNzSWQSFAoMcmV0dXJuX3RvcGljGAkg", "ASgJEhEKCWNsaWVudF9pZBgLIAEoCUIbCg1ibmV0LnByb3RvY29sQghScGNQ", "cm90b0gBUABQAVACUAM="
			}));
			RpcTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				FieldOptionsReflection.Descriptor,
				MethodOptionsReflection.Descriptor,
				MessageOptionsReflection.Descriptor,
				ServiceOptionsReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(NO_RESPONSE), NO_RESPONSE.Parser, null, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Address), Address.Parser, new string[] { "Address_", "Port" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ProcessId), ProcessId.Parser, new string[] { "Label", "Epoch" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ObjectAddress), ObjectAddress.Parser, new string[] { "Host", "ObjectId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(NoData), NoData.Parser, null, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ErrorInfo), ErrorInfo.Parser, new string[] { "ObjectAddress", "Status", "ServiceHash", "MethodId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(FanoutTarget), FanoutTarget.Parser, new string[] { "ClientId", "Key", "ObjectId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Header), Header.Parser, new string[]
				{
					"ServiceId", "MethodId", "Token", "ObjectId", "Size", "Status", "Error", "Timeout", "IsResponse", "ForwardTargets",
					"ServiceHash", "RequestId", "ClientId", "FanoutTarget", "ClientIdFanoutTarget", "ClientRecord", "OriginalSender", "SenderToken", "RouterLabel", "ErrorReason"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(KafkaHeader), KafkaHeader.Parser, new string[] { "ServiceHash", "MethodId", "Token", "ObjectId", "Size", "Status", "Timeout", "ForwardTarget", "ReturnTopic", "ClientId" }, null, null, null, null)
			}));
		}

		// Token: 0x04002A0B RID: 10763
		private static FileDescriptor descriptor;
	}
}
