using System;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000379 RID: 889
	public static class ServiceOptionsReflection
	{
		// Token: 0x17001D65 RID: 7525
		// (get) Token: 0x06005AC4 RID: 23236 RVA: 0x0015F0F8 File Offset: 0x0015D2F8
		public static FileDescriptor Descriptor
		{
			get
			{
				return ServiceOptionsReflection.descriptor;
			}
		}

		// Token: 0x06005AC5 RID: 23237 RVA: 0x0015F110 File Offset: 0x0015D310
		static ServiceOptionsReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjliZ3MvbG93L3BiL2NsaWVudC9nbG9iYWxfZXh0ZW5zaW9ucy9zZXJ2aWNl", "X29wdGlvbnMucHJvdG8SDGJncy5wcm90b2NvbBogZ29vZ2xlL3Byb3RvYnVm", "L2Rlc2NyaXB0b3IucHJvdG8i+gIKEUJHU1NlcnZpY2VPcHRpb25zEhcKD2Rl", "c2NyaXB0b3JfbmFtZRgBIAEoCRINCgV0b3BpYxgCIAEoCRIbChNjdXN0b21f", "c2VsZWN0X3NoYXJkGAMgASgIEg8KB3ZlcnNpb24YBCABKA0SEgoKc2hhcmRf", "bmFtZRgFIAEoCRIfChdyZXNvbHZlX2NsaWVudF9pbnN0YW5jZRgGIAEoCBI5", "CgR0eXBlGAcgASgOMisuYmdzLnByb3RvY29sLkJHU1NlcnZpY2VPcHRpb25z", "LlNlcnZpY2VUeXBlEhAKCGFwaV90eXBlGAggASgJEhEKCWlzX2dsb2JhbBgJ", "IAEoCCJ6CgtTZXJ2aWNlVHlwZRIUChBTRVJWSUNFX1RZUEVfUlBDEAASGwoX", "U0VSVklDRV9UWVBFX1JQQ19ESVJFQ1QQARIWChJTRVJWSUNFX1RZUEVfRVZF",
				"TlQQAhIgChxTRVJWSUNFX1RZUEVfRVZFTlRfQlJPQURDQVNUEAMiTQoRU0RL", "U2VydmljZU9wdGlvbnMSDwoHaW5ib3VuZBgBIAEoCBIQCghvdXRib3VuZBgC", "IAEoCBIVCg11c2VfY2xpZW50X2lkGAMgASgIOlsKD3NlcnZpY2Vfb3B0aW9u", "cxIfLmdvb2dsZS5wcm90b2J1Zi5TZXJ2aWNlT3B0aW9ucxiQvwUgASgLMh8u", "YmdzLnByb3RvY29sLkJHU1NlcnZpY2VPcHRpb25zOl8KE3Nka19zZXJ2aWNl", "X29wdGlvbnMSHy5nb29nbGUucHJvdG9idWYuU2VydmljZU9wdGlvbnMYkb8F", "IAEoCzIfLmJncy5wcm90b2NvbC5TREtTZXJ2aWNlT3B0aW9uc0ImCg1ibmV0", "LnByb3RvY29sQhNTZXJ2aWNlT3B0aW9uc1Byb3RvSAE="
			}));
			ServiceOptionsReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { DescriptorReflection.Descriptor }, new GeneratedClrTypeInfo(null, new Extension[]
			{
				ServiceOptionsExtensions.ServiceOptions_,
				ServiceOptionsExtensions.SdkServiceOptions
			}, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(BGSServiceOptions), BGSServiceOptions.Parser, new string[] { "DescriptorName", "Topic", "CustomSelectShard", "Version", "ShardName", "ResolveClientInstance", "Type", "ApiType", "IsGlobal" }, null, new Type[] { typeof(BGSServiceOptions.Types.ServiceType) }, null, null),
				new GeneratedClrTypeInfo(typeof(SDKServiceOptions), SDKServiceOptions.Parser, new string[] { "Inbound", "Outbound", "UseClientId" }, null, null, null, null)
			}));
		}

		// Token: 0x0400295C RID: 10588
		private static FileDescriptor descriptor;
	}
}
