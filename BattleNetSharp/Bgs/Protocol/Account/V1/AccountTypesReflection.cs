using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x0200072D RID: 1837
	public static class AccountTypesReflection
	{
		// Token: 0x170033DC RID: 13276
		// (get) Token: 0x0600A837 RID: 43063 RVA: 0x0028EF10 File Offset: 0x0028D110
		public static FileDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.descriptor;
			}
		}

		// Token: 0x0600A838 RID: 43064 RVA: 0x0028EF28 File Offset: 0x0028D128
		static AccountTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CiViZ3MvbG93L3BiL2NsaWVudC9hY2NvdW50X3R5cGVzLnByb3RvEhdiZ3Mu", "cHJvdG9jb2wuYWNjb3VudC52MRokYmdzL2xvdy9wYi9jbGllbnQvZW50aXR5", "X3R5cGVzLnByb3RvGiFiZ3MvbG93L3BiL2NsaWVudC9ycGNfdHlwZXMucHJv", "dG8iIQoJQWNjb3VudElkEhQKAmlkGAEgAigHQgiK+SsEEgIQACItCg5BY2Nv", "dW50TGljZW5zZRIKCgJpZBgBIAIoDRIPCgdleHBpcmVzGAIgASgEImMKEUdh", "bWVBY2NvdW50SGFuZGxlEhQKAmlkGAEgAigHQgiK+SsEEgIQABIZCgdwcm9n", "cmFtGAIgAigHQgiK+SsEEgIQABIdCgZyZWdpb24YAyACKA1CDYr5KwkSBwoF", "CAEQ/wEipgEKEEFjY291bnRSZWZlcmVuY2USCgoCaWQYASABKAcSDQoFZW1h", "aWwYAiABKAkSOgoGaGFuZGxlGAMgASgLMiouYmdzLnByb3RvY29sLmFjY291", "bnQudjEuR2FtZUFjY291bnRIYW5kbGUSEgoKYmF0dGxlX3RhZxgEIAEoCRIU",
				"CgxwaG9uZV9udW1iZXIYBSABKAkSEQoGcmVnaW9uGAogASgNOgEwIrMBCghJ", "ZGVudGl0eRIzCgdhY2NvdW50GAEgASgLMiIuYmdzLnByb3RvY29sLmFjY291", "bnQudjEuQWNjb3VudElkEkAKDGdhbWVfYWNjb3VudBgCIAEoCzIqLmJncy5w", "cm90b2NvbC5hY2NvdW50LnYxLkdhbWVBY2NvdW50SGFuZGxlEigKB3Byb2Nl", "c3MYAyABKAsyFy5iZ3MucHJvdG9jb2wuUHJvY2Vzc0lkOgaC+SsCEAEiRwoK", "UHJvZ3JhbVRhZxIPCgdwcm9ncmFtGAEgASgHEgsKA3RhZxgCIAEoBxIbChNz", "ZWN1cml0eV9zdGF0dXNfdGFnGAwgASgHIigKCVJlZ2lvblRhZxIOCgZyZWdp", "b24YASABKAcSCwoDdGFnGAIgASgHIs0CChBBY2NvdW50RmllbGRUYWdzEh4K", "FmFjY291bnRfbGV2ZWxfaW5mb190YWcYAiABKAcSGAoQcHJpdmFjeV9pbmZv", "X3RhZxgDIAEoBxIhChlwYXJlbnRhbF9jb250cm9sX2luZm9fdGFnGAQgASgH",
				"EkEKFGdhbWVfbGV2ZWxfaW5mb190YWdzGAcgAygLMiMuYmdzLnByb3RvY29s", "LmFjY291bnQudjEuUHJvZ3JhbVRhZxI9ChBnYW1lX3N0YXR1c190YWdzGAkg", "AygLMiMuYmdzLnByb3RvY29sLmFjY291bnQudjEuUHJvZ3JhbVRhZxI9ChFn", "YW1lX2FjY291bnRfdGFncxgLIAMoCzIiLmJncy5wcm90b2NvbC5hY2NvdW50", "LnYxLlJlZ2lvblRhZxIbChNzZWN1cml0eV9zdGF0dXNfdGFnGAwgASgHIn4K", "FEdhbWVBY2NvdW50RmllbGRUYWdzEhsKE2dhbWVfbGV2ZWxfaW5mb190YWcY", "AiABKAcSGgoSZ2FtZV90aW1lX2luZm9fdGFnGAMgASgHEhcKD2dhbWVfc3Rh", "dHVzX3RhZxgEIAEoBxIUCgxyYWZfaW5mb190YWcYBSABKAciggIKE0FjY291", "bnRGaWVsZE9wdGlvbnMSEgoKYWxsX2ZpZWxkcxgBIAEoCBIgChhmaWVsZF9h", "Y2NvdW50X2xldmVsX2luZm8YAiABKAgSGgoSZmllbGRfcHJpdmFjeV9pbmZv",
				"GAMgASgIEiMKG2ZpZWxkX3BhcmVudGFsX2NvbnRyb2xfaW5mbxgEIAEoCBId", "ChVmaWVsZF9nYW1lX2xldmVsX2luZm8YBiABKAgSGQoRZmllbGRfZ2FtZV9z", "dGF0dXMYByABKAgSGwoTZmllbGRfZ2FtZV9hY2NvdW50cxgIIAEoCBIdChVm", "aWVsZF9zZWN1cml0eV9zdGF0dXMYCSABKAgiswEKF0dhbWVBY2NvdW50Rmll", "bGRPcHRpb25zEhIKCmFsbF9maWVsZHMYASABKAgSHQoVZmllbGRfZ2FtZV9s", "ZXZlbF9pbmZvGAIgASgIEhwKFGZpZWxkX2dhbWVfdGltZV9pbmZvGAMgASgI", "EhkKEWZpZWxkX2dhbWVfc3RhdHVzGAQgASgIEhYKDmZpZWxkX3JhZl9pbmZv", "GAUgASgIEhQKDHBob25lX251bWJlchgTIAEoCSJCChdQbGF5U2NoZWR1bGVS", "ZXN0cmljdGlvbhIVCg1wbGF5X3NjaGVkdWxlGAEgAygIEhAKCHRpbWV6b25l", "GAIgASgJIpIDChNTdWJzY3JpYmVyUmVmZXJlbmNlEhQKCW9iamVjdF9pZBgB",
				"IAEoBDoBMBIpCgllbnRpdHlfaWQYAiABKAsyFi5iZ3MucHJvdG9jb2wuRW50", "aXR5SWQSRQoPYWNjb3VudF9vcHRpb25zGAMgASgLMiwuYmdzLnByb3RvY29s", "LmFjY291bnQudjEuQWNjb3VudEZpZWxkT3B0aW9ucxI/CgxhY2NvdW50X3Rh", "Z3MYBCABKAsyKS5iZ3MucHJvdG9jb2wuYWNjb3VudC52MS5BY2NvdW50Rmll", "bGRUYWdzEk4KFGdhbWVfYWNjb3VudF9vcHRpb25zGAUgASgLMjAuYmdzLnBy", "b3RvY29sLmFjY291bnQudjEuR2FtZUFjY291bnRGaWVsZE9wdGlvbnMSSAoR", "Z2FtZV9hY2NvdW50X3RhZ3MYBiABKAsyLS5iZ3MucHJvdG9jb2wuYWNjb3Vu", "dC52MS5HYW1lQWNjb3VudEZpZWxkVGFncxIYCg1zdWJzY3JpYmVyX2lkGAcg", "ASgEOgEwIhkKBk9wdElucxIPCgNpZHMYASADKARCAhABIpoFChBBY2NvdW50", "TGV2ZWxJbmZvEjkKCGxpY2Vuc2VzGAMgAygLMicuYmdzLnByb3RvY29sLmFj",
				"Y291bnQudjEuQWNjb3VudExpY2Vuc2USGAoQZGVmYXVsdF9jdXJyZW5jeRgE", "IAEoBxIPCgdjb3VudHJ5GAUgASgJEhgKEHByZWZlcnJlZF9yZWdpb24YBiAB", "KA0SEQoJZnVsbF9uYW1lGAcgASgJEhIKCmJhdHRsZV90YWcYCCABKAkSDQoF", "bXV0ZWQYCSABKAgSFQoNbWFudWFsX3JldmlldxgKIAEoCBIYChBhY2NvdW50", "X3BhaWRfYW55GAsgASgIElIKFWlkZW50aXR5X2NoZWNrX3N0YXR1cxgMIAEo", "DjIzLmJncy5wcm90b2NvbC5hY2NvdW50LnYxLklkZW50aXR5VmVyaWZpY2F0", "aW9uU3RhdHVzEg0KBWVtYWlsGA0gASgJEhgKEGhlYWRsZXNzX2FjY291bnQY", "DiABKAgSFAoMdGVzdF9hY2NvdW50GA8gASgIEkAKC3Jlc3RyaWN0aW9uGBAg", "AygLMisuYmdzLnByb3RvY29sLmFjY291bnQudjEuQWNjb3VudFJlc3RyaWN0", "aW9uEhgKEGlzX3Ntc19wcm90ZWN0ZWQYESABKAgSIQoZcmF0aW5nc19ib2Fy",
				"ZF9taW5pbXVtX2FnZRgSIAEoDRIUCgxwaG9uZV9udW1iZXIYEyABKAkSEQoJ", "YmlydGhkYXRlGBQgASgJEjIKKmxlZ2FsX2NvdW50cnlfZmVhdHVyZV9yZXN0", "cmljdGlvbnNfYXBwbGllZBgVIAEoCBIwCgdvcHRfaW5zGBYgASgLMh8uYmdz", "LnByb3RvY29sLmFjY291bnQudjEuT3B0SW5zIsICCgtQcml2YWN5SW5mbxIU", "Cgxpc191c2luZ19yaWQYAyABKAgSIwobaXNfdmlzaWJsZV9mb3Jfdmlld19m", "cmllbmRzGAQgASgIEiQKHGlzX2hpZGRlbl9mcm9tX2ZyaWVuZF9maW5kZXIY", "BSABKAgSYAoRZ2FtZV9pbmZvX3ByaXZhY3kYBiABKA4yNC5iZ3MucHJvdG9j", "b2wuYWNjb3VudC52MS5Qcml2YWN5SW5mby5HYW1lSW5mb1ByaXZhY3k6D1BS", "SVZBQ1lfRlJJRU5EUxIiChpvbmx5X2FsbG93X2ZyaWVuZF93aGlzcGVycxgH", "IAEoCCJMCg9HYW1lSW5mb1ByaXZhY3kSDgoKUFJJVkFDWV9NRRAAEhMKD1BS",
				"SVZBQ1lfRlJJRU5EUxABEhQKEFBSSVZBQ1lfRVZFUllPTkUQAiLVAQoTUGFy", "ZW50YWxDb250cm9sSW5mbxIQCgh0aW1lem9uZRgDIAEoCRIXCg9taW51dGVz", "X3Blcl9kYXkYBCABKA0SGAoQbWludXRlc19wZXJfd2VlaxgFIAEoDRIZChFj", "YW5fcmVjZWl2ZV92b2ljZRgGIAEoCBIWCg5jYW5fc2VuZF92b2ljZRgHIAEo", "CBIVCg1wbGF5X3NjaGVkdWxlGAggAygIEhYKDmNhbl9qb2luX2dyb3VwGAkg", "ASgIEhcKD2Nhbl91c2VfcHJvZmlsZRgKIAEoCCLwAQoNR2FtZUxldmVsSW5m", "bxIQCghpc190cmlhbBgEIAEoCBITCgtpc19saWZldGltZRgFIAEoCBIVCg1p", "c19yZXN0cmljdGVkGAYgASgIEg8KB2lzX2JldGEYByABKAgSDAoEbmFtZRgI", "IAEoCRIPCgdwcm9ncmFtGAkgASgHEjkKCGxpY2Vuc2VzGAogAygLMicuYmdz", "LnByb3RvY29sLmFjY291bnQudjEuQWNjb3VudExpY2Vuc2USGQoRcmVhbG1f",
				"cGVybWlzc2lvbnMYCyABKA0SGwoTbGFzdF9sb2dvdXRfdGltZV9tcxgMIAEo", "BCKFAQoMR2FtZVRpbWVJbmZvEh4KFmlzX3VubGltaXRlZF9wbGF5X3RpbWUY", "AyABKAgSGQoRcGxheV90aW1lX2V4cGlyZXMYBSABKAQSFwoPaXNfc3Vic2Ny", "aXB0aW9uGAYgASgIEiEKGWlzX3JlY3VycmluZ19zdWJzY3JpcHRpb24YByAB", "KAgisQEKFUdhbWVUaW1lUmVtYWluaW5nSW5mbxIZChFtaW51dGVzX3JlbWFp", "bmluZxgBIAEoDRIoCiBwYXJlbnRhbF9kYWlseV9taW51dGVzX3JlbWFpbmlu", "ZxgCIAEoDRIpCiFwYXJlbnRhbF93ZWVrbHlfbWludXRlc19yZW1haW5pbmcY", "AyABKA0SKAocc2Vjb25kc19yZW1haW5pbmdfdW50aWxfa2ljaxgEIAEoDUIC", "GAEikAEKCkdhbWVTdGF0dXMSFAoMaXNfc3VzcGVuZGVkGAQgASgIEhEKCWlz", "X2Jhbm5lZBgFIAEoCBIaChJzdXNwZW5zaW9uX2V4cGlyZXMYBiABKAQSDwoH",
				"cHJvZ3JhbRgHIAEoBxIRCglpc19sb2NrZWQYCCABKAgSGQoRaXNfYmFtX3Vu", "bG9ja2FibGUYCSABKAgiGwoHUkFGSW5mbxIQCghyYWZfaW5mbxgBIAEoDCKo", "AgoPR2FtZVNlc3Npb25JbmZvEhYKCnN0YXJ0X3RpbWUYAyABKA1CAhgBEj4K", "CGxvY2F0aW9uGAQgASgLMiwuYmdzLnByb3RvY29sLmFjY291bnQudjEuR2Ft", "ZVNlc3Npb25Mb2NhdGlvbhIWCg5oYXNfYmVuZWZhY3RvchgFIAEoCBIUCgxp", "c191c2luZ19pZ3IYBiABKAgSIAoYcGFyZW50YWxfY29udHJvbHNfYWN0aXZl", "GAcgASgIEhYKDnN0YXJ0X3RpbWVfc2VjGAggASgEEi4KBmlncl9pZBgJIAEo", "CzIeLmJncy5wcm90b2NvbC5hY2NvdW50LnYxLklncklkEhMKC3BsYXRmb3Jt", "X2lkGAogASgHEhAKCGlncl9wYWlkGAsgASgIIkQKFUdhbWVTZXNzaW9uVXBk", "YXRlSW5mbxIrCgRjYWlzGAggASgLMh0uYmdzLnByb3RvY29sLmFjY291bnQu",
				"djEuQ0FJUyJIChNHYW1lU2Vzc2lvbkxvY2F0aW9uEhIKCmlwX2FkZHJlc3MY", "ASABKAkSDwoHY291bnRyeRgCIAEoDRIMCgRjaXR5GAMgASgJIk8KBENBSVMS", "FgoOcGxheWVkX21pbnV0ZXMYASABKA0SFgoOcmVzdGVkX21pbnV0ZXMYAiAB", "KA0SFwoPbGFzdF9oZWFyZF90aW1lGAMgASgEIl0KD0dhbWVBY2NvdW50TGlz", "dBIOCgZyZWdpb24YAyABKA0SOgoGaGFuZGxlGAQgAygLMiouYmdzLnByb3Rv", "Y29sLmFjY291bnQudjEuR2FtZUFjY291bnRIYW5kbGUimQEKDlNlY3VyaXR5", "U3RhdHVzEhsKE3Ntc19wcm90ZWN0X2VuYWJsZWQYASABKAgSFgoOZW1haWxf", "dmVyaWZpZWQYAiABKAgSHQoVYXV0aGVudGljYXRvcl9lbmFibGVkGAMgASgI", "EhMKC3NxYV9lbmFibGVkGAQgASgIEh4KFmF1dGhlbnRpY2F0b3JfcmVxdWly", "ZWQYBSABKAgiqQQKDEFjY291bnRTdGF0ZRJFChJhY2NvdW50X2xldmVsX2lu",
				"Zm8YASABKAsyKS5iZ3MucHJvdG9jb2wuYWNjb3VudC52MS5BY2NvdW50TGV2", "ZWxJbmZvEjoKDHByaXZhY3lfaW5mbxgCIAEoCzIkLmJncy5wcm90b2NvbC5h", "Y2NvdW50LnYxLlByaXZhY3lJbmZvEksKFXBhcmVudGFsX2NvbnRyb2xfaW5m", "bxgDIAEoCzIsLmJncy5wcm90b2NvbC5hY2NvdW50LnYxLlBhcmVudGFsQ29u", "dHJvbEluZm8SPwoPZ2FtZV9sZXZlbF9pbmZvGAUgAygLMiYuYmdzLnByb3Rv", "Y29sLmFjY291bnQudjEuR2FtZUxldmVsSW5mbxI4CgtnYW1lX3N0YXR1cxgG", "IAMoCzIjLmJncy5wcm90b2NvbC5hY2NvdW50LnYxLkdhbWVTdGF0dXMSPwoN", "Z2FtZV9hY2NvdW50cxgHIAMoCzIoLmJncy5wcm90b2NvbC5hY2NvdW50LnYx", "LkdhbWVBY2NvdW50TGlzdBJACg9zZWN1cml0eV9zdGF0dXMYCCABKAsyJy5i", "Z3MucHJvdG9jb2wuYWNjb3VudC52MS5TZWN1cml0eVN0YXR1cxJLChFnb3Zl",
				"cm5tZW50X2N1cmZldxgJIAEoCzIwLmJncy5wcm90b2NvbC5hY2NvdW50LnYx", "LlBsYXlTY2hlZHVsZVJlc3RyaWN0aW9uIpMBChJBY2NvdW50U3RhdGVUYWdn", "ZWQSPAoNYWNjb3VudF9zdGF0ZRgBIAEoCzIlLmJncy5wcm90b2NvbC5hY2Nv", "dW50LnYxLkFjY291bnRTdGF0ZRI/CgxhY2NvdW50X3RhZ3MYAiABKAsyKS5i", "Z3MucHJvdG9jb2wuYWNjb3VudC52MS5BY2NvdW50RmllbGRUYWdzIoACChBH", "YW1lQWNjb3VudFN0YXRlEj8KD2dhbWVfbGV2ZWxfaW5mbxgBIAEoCzImLmJn", "cy5wcm90b2NvbC5hY2NvdW50LnYxLkdhbWVMZXZlbEluZm8SPQoOZ2FtZV90", "aW1lX2luZm8YAiABKAsyJS5iZ3MucHJvdG9jb2wuYWNjb3VudC52MS5HYW1l", "VGltZUluZm8SOAoLZ2FtZV9zdGF0dXMYAyABKAsyIy5iZ3MucHJvdG9jb2wu", "YWNjb3VudC52MS5HYW1lU3RhdHVzEjIKCHJhZl9pbmZvGAQgASgLMiAuYmdz",
				"LnByb3RvY29sLmFjY291bnQudjEuUkFGSW5mbyKpAQoWR2FtZUFjY291bnRT", "dGF0ZVRhZ2dlZBJFChJnYW1lX2FjY291bnRfc3RhdGUYASABKAsyKS5iZ3Mu", "cHJvdG9jb2wuYWNjb3VudC52MS5HYW1lQWNjb3VudFN0YXRlEkgKEWdhbWVf", "YWNjb3VudF90YWdzGAIgASgLMi0uYmdzLnByb3RvY29sLmFjY291bnQudjEu", "R2FtZUFjY291bnRGaWVsZFRhZ3MiLwoOQXV0aG9yaXplZERhdGESDAoEZGF0", "YRgBIAEoCRIPCgdsaWNlbnNlGAIgAygNInoKBUlncklkEkIKDGdhbWVfYWNj", "b3VudBgBIAEoCzIqLmJncy5wcm90b2NvbC5hY2NvdW50LnYxLkdhbWVBY2Nv", "dW50SGFuZGxlSAASFQoLZXh0ZXJuYWxfaWQYAiABKAdIABIOCgR1dWlkGAMg", "ASgJSABCBgoEdHlwZSI0CgpJZ3JBZGRyZXNzEhYKDmNsaWVudF9hZGRyZXNz", "GAEgASgJEg4KBnJlZ2lvbhgCIAEoDSKyAQoSQWNjb3VudFJlc3RyaWN0aW9u",
				"EhYKDnJlc3RyaWN0aW9uX2lkGAEgASgNEg8KB3Byb2dyYW0YAiABKAcSNgoE", "dHlwZRgDIAEoDjIoLmJncy5wcm90b2NvbC5hY2NvdW50LnYxLlJlc3RyaWN0", "aW9uVHlwZRIQCghwbGF0Zm9ybRgEIAMoBxITCgtleHBpcmVfdGltZRgFIAEo", "BBIUCgxjcmVhdGVkX3RpbWUYBiABKAQqtQEKGklkZW50aXR5VmVyaWZpY2F0", "aW9uU3RhdHVzEhEKDUlERU5UX05PX0RBVEEQABIRCg1JREVOVF9QRU5ESU5H", "EAESEQoNSURFTlRfT1ZFUl8xOBACEhIKDklERU5UX1VOREVSXzE4EAMSEAoM", "SURFTlRfRkFJTEVEEAQSEQoNSURFTlRfU1VDQ0VTUxAFEhIKDklERU5UX1NV", "Q0NfTU5MEAYSEQoNSURFTlRfVU5LTk9XThAHKn4KD1Jlc3RyaWN0aW9uVHlw", "ZRILCgdVTktOT1dOEAASFwoTR0FNRV9BQ0NPVU5UX0JBTk5FRBABEhoKFkdB", "TUVfQUNDT1VOVF9TVVNQRU5ERUQQAhISCg5BQ0NPVU5UX0xPQ0tFRBADEhUK",
				"EUFDQ09VTlRfU1FVRUxDSEVEEARCAkgB"
			}));
			AccountTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				EntityTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(new Type[]
			{
				typeof(IdentityVerificationStatus),
				typeof(RestrictionType)
			}, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(AccountId), AccountId.Parser, new string[] { "Id" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AccountLicense), AccountLicense.Parser, new string[] { "Id", "Expires" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameAccountHandle), GameAccountHandle.Parser, new string[] { "Id", "Program", "Region" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AccountReference), AccountReference.Parser, new string[] { "Id", "Email", "Handle", "BattleTag", "PhoneNumber", "Region" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Identity), Identity.Parser, new string[] { "Account", "GameAccount", "Process" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ProgramTag), ProgramTag.Parser, new string[] { "Program", "Tag", "SecurityStatusTag" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RegionTag), RegionTag.Parser, new string[] { "Region", "Tag" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AccountFieldTags), AccountFieldTags.Parser, new string[] { "AccountLevelInfoTag", "PrivacyInfoTag", "ParentalControlInfoTag", "GameLevelInfoTags", "GameStatusTags", "GameAccountTags", "SecurityStatusTag" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameAccountFieldTags), GameAccountFieldTags.Parser, new string[] { "GameLevelInfoTag", "GameTimeInfoTag", "GameStatusTag", "RafInfoTag" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AccountFieldOptions), AccountFieldOptions.Parser, new string[] { "AllFields", "FieldAccountLevelInfo", "FieldPrivacyInfo", "FieldParentalControlInfo", "FieldGameLevelInfo", "FieldGameStatus", "FieldGameAccounts", "FieldSecurityStatus" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameAccountFieldOptions), GameAccountFieldOptions.Parser, new string[] { "AllFields", "FieldGameLevelInfo", "FieldGameTimeInfo", "FieldGameStatus", "FieldRafInfo", "PhoneNumber" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PlayScheduleRestriction), PlayScheduleRestriction.Parser, new string[] { "PlaySchedule", "Timezone" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SubscriberReference), SubscriberReference.Parser, new string[] { "ObjectId", "EntityId", "AccountOptions", "AccountTags", "GameAccountOptions", "GameAccountTags", "SubscriberId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(OptIns), OptIns.Parser, new string[] { "Ids" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AccountLevelInfo), AccountLevelInfo.Parser, new string[]
				{
					"Licenses", "DefaultCurrency", "Country", "PreferredRegion", "FullName", "BattleTag", "Muted", "ManualReview", "AccountPaidAny", "IdentityCheckStatus",
					"Email", "HeadlessAccount", "TestAccount", "Restriction", "IsSmsProtected", "RatingsBoardMinimumAge", "PhoneNumber", "Birthdate", "LegalCountryFeatureRestrictionsApplied", "OptIns"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PrivacyInfo), PrivacyInfo.Parser, new string[] { "IsUsingRid", "IsVisibleForViewFriends", "IsHiddenFromFriendFinder", "GameInfoPrivacy", "OnlyAllowFriendWhispers" }, null, new Type[] { typeof(PrivacyInfo.Types.GameInfoPrivacy) }, null, null),
				new GeneratedClrTypeInfo(typeof(ParentalControlInfo), ParentalControlInfo.Parser, new string[] { "Timezone", "MinutesPerDay", "MinutesPerWeek", "CanReceiveVoice", "CanSendVoice", "PlaySchedule", "CanJoinGroup", "CanUseProfile" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameLevelInfo), GameLevelInfo.Parser, new string[] { "IsTrial", "IsLifetime", "IsRestricted", "IsBeta", "Name", "Program", "Licenses", "RealmPermissions", "LastLogoutTimeMs" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameTimeInfo), GameTimeInfo.Parser, new string[] { "IsUnlimitedPlayTime", "PlayTimeExpires", "IsSubscription", "IsRecurringSubscription" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameTimeRemainingInfo), GameTimeRemainingInfo.Parser, new string[] { "MinutesRemaining", "ParentalDailyMinutesRemaining", "ParentalWeeklyMinutesRemaining", "SecondsRemainingUntilKick" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameStatus), GameStatus.Parser, new string[] { "IsSuspended", "IsBanned", "SuspensionExpires", "Program", "IsLocked", "IsBamUnlockable" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RAFInfo), RAFInfo.Parser, new string[] { "RafInfo" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameSessionInfo), GameSessionInfo.Parser, new string[] { "StartTime", "Location", "HasBenefactor", "IsUsingIgr", "ParentalControlsActive", "StartTimeSec", "IgrId", "PlatformId", "IgrPaid" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameSessionUpdateInfo), GameSessionUpdateInfo.Parser, new string[] { "Cais" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameSessionLocation), GameSessionLocation.Parser, new string[] { "IpAddress", "Country", "City" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CAIS), CAIS.Parser, new string[] { "PlayedMinutes", "RestedMinutes", "LastHeardTime" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameAccountList), GameAccountList.Parser, new string[] { "Region", "Handle" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SecurityStatus), SecurityStatus.Parser, new string[] { "SmsProtectEnabled", "EmailVerified", "AuthenticatorEnabled", "SqaEnabled", "AuthenticatorRequired" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AccountState), AccountState.Parser, new string[] { "AccountLevelInfo", "PrivacyInfo", "ParentalControlInfo", "GameLevelInfo", "GameStatus", "GameAccounts", "SecurityStatus", "GovernmentCurfew" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AccountStateTagged), AccountStateTagged.Parser, new string[] { "AccountState", "AccountTags" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameAccountState), GameAccountState.Parser, new string[] { "GameLevelInfo", "GameTimeInfo", "GameStatus", "RafInfo" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameAccountStateTagged), GameAccountStateTagged.Parser, new string[] { "GameAccountState", "GameAccountTags" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AuthorizedData), AuthorizedData.Parser, new string[] { "Data", "License" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(IgrId), IgrId.Parser, new string[] { "GameAccount", "ExternalId", "Uuid" }, new string[] { "Type" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(IgrAddress), IgrAddress.Parser, new string[] { "ClientAddress", "Region" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AccountRestriction), AccountRestriction.Parser, new string[] { "RestrictionId", "Program", "Type", "Platform", "ExpireTime", "CreatedTime" }, null, null, null, null)
			}));
		}

		// Token: 0x04004B91 RID: 19345
		private static FileDescriptor descriptor;
	}
}
