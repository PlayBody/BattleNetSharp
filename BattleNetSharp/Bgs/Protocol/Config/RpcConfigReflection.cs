using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Config
{
	// Token: 0x020003D4 RID: 980
	public static class RpcConfigReflection
	{
		// Token: 0x17001F88 RID: 8072
		// (get) Token: 0x060061E1 RID: 25057 RVA: 0x0017AC18 File Offset: 0x00178E18
		public static FileDescriptor Descriptor
		{
			get
			{
				return RpcConfigReflection.descriptor;
			}
		}

		// Token: 0x060061E2 RID: 25058 RVA: 0x0017AC30 File Offset: 0x00178E30
		static RpcConfigReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CiJiZ3MvbG93L3BiL2NsaWVudC9ycGNfY29uZmlnLnByb3RvEhNiZ3MucHJv", "dG9jb2wuY29uZmlnIosDCg9SUENNZXRob2RDb25maWcSGAoMc2VydmljZV9u", "YW1lGAEgASgJQgIYARIXCgttZXRob2RfbmFtZRgCIAEoCUICGAESGgoPZml4", "ZWRfY2FsbF9jb3N0GAMgASgNOgExEhwKEWZpeGVkX3BhY2tldF9zaXplGAQg", "ASgNOgEwEh4KE3ZhcmlhYmxlX211bHRpcGxpZXIYBSABKAI6ATASFQoKbXVs", "dGlwbGllchgGIAEoAjoBMRIYChByYXRlX2xpbWl0X2NvdW50GAcgASgNEhoK", "EnJhdGVfbGltaXRfc2Vjb25kcxgIIAEoDRIXCg9tYXhfcGFja2V0X3NpemUY", "CSABKA0SGAoQbWF4X2VuY29kZWRfc2l6ZRgKIAEoDRIPCgd0aW1lb3V0GAsg", "ASgCEhMKC2NhcF9iYWxhbmNlGAwgASgNEhwKEWluY29tZV9wZXJfc2Vjb25k", "GA0gASgCOgEwEhQKDHNlcnZpY2VfaGFzaBgOIAEoDRIRCgltZXRob2RfaWQY",
				"DyABKA0irQEKDlJQQ01ldGVyQ29uZmlnEjQKBm1ldGhvZBgBIAMoCzIkLmJn", "cy5wcm90b2NvbC5jb25maWcuUlBDTWV0aG9kQ29uZmlnEhwKEWluY29tZV9w", "ZXJfc2Vjb25kGAIgASgNOgExEhcKD2luaXRpYWxfYmFsYW5jZRgDIAEoDRIT", "CgtjYXBfYmFsYW5jZRgEIAEoDRIZCg5zdGFydHVwX3BlcmlvZBgFIAEoAjoB", "MCJJCg1Qcm90b2NvbEFsaWFzEhsKE3NlcnZlcl9zZXJ2aWNlX25hbWUYASAC", "KAkSGwoTY2xpZW50X3NlcnZpY2VfbmFtZRgCIAIoCSJMCg5TZXJ2aWNlQWxp", "YXNlcxI6Cg5wcm90b2NvbF9hbGlhcxgBIAMoCzIiLmJncy5wcm90b2NvbC5j", "b25maWcuUHJvdG9jb2xBbGlhc0ICSAE="
			}));
			RpcConfigReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(RPCMethodConfig), RPCMethodConfig.Parser, new string[]
				{
					"ServiceName", "MethodName", "FixedCallCost", "FixedPacketSize", "VariableMultiplier", "Multiplier", "RateLimitCount", "RateLimitSeconds", "MaxPacketSize", "MaxEncodedSize",
					"Timeout", "CapBalance", "IncomePerSecond", "ServiceHash", "MethodId"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RPCMeterConfig), RPCMeterConfig.Parser, new string[] { "Method", "IncomePerSecond", "InitialBalance", "CapBalance", "StartupPeriod" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ProtocolAlias), ProtocolAlias.Parser, new string[] { "ServerServiceName", "ClientServiceName" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ServiceAliases), ServiceAliases.Parser, new string[] { "ProtocolAlias" }, null, null, null, null)
			}));
		}

		// Token: 0x04002CB0 RID: 11440
		private static FileDescriptor descriptor;
	}
}
