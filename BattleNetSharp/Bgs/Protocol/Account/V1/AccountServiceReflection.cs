using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x0200070F RID: 1807
	public static class AccountServiceReflection
	{
		// Token: 0x17003331 RID: 13105
		// (get) Token: 0x0600A5B6 RID: 42422 RVA: 0x00285328 File Offset: 0x00283528
		public static FileDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.descriptor;
			}
		}

		// Token: 0x0600A5B7 RID: 42423 RVA: 0x00285340 File Offset: 0x00283540
		static AccountServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CidiZ3MvbG93L3BiL2NsaWVudC9hY2NvdW50X3NlcnZpY2UucHJvdG8SF2Jn", "cy5wcm90b2NvbC5hY2NvdW50LnYxGiViZ3MvbG93L3BiL2NsaWVudC9hY2Nv", "dW50X3R5cGVzLnByb3RvGiRiZ3MvbG93L3BiL2NsaWVudC9lbnRpdHlfdHlw", "ZXMucHJvdG8aIWJncy9sb3cvcGIvY2xpZW50L3JwY190eXBlcy5wcm90byJp", "ChVSZXNvbHZlQWNjb3VudFJlcXVlc3QSNgoDcmVmGAEgASgLMikuYmdzLnBy", "b3RvY29sLmFjY291bnQudjEuQWNjb3VudFJlZmVyZW5jZRIQCghmZXRjaF9p", "ZBgMIAEoCDoGgvkrAggBIkgKFlJlc29sdmVBY2NvdW50UmVzcG9uc2USLgoC", "aWQYDCABKAsyIi5iZ3MucHJvdG9jb2wuYWNjb3VudC52MS5BY2NvdW50SWQi", "fgocR2FtZUFjY291bnRGbGFnVXBkYXRlUmVxdWVzdBJACgxnYW1lX2FjY291", "bnQYASABKAsyKi5iZ3MucHJvdG9jb2wuYWNjb3VudC52MS5HYW1lQWNjb3Vu",
				"dEhhbmRsZRIMCgRmbGFnGAIgASgEEg4KBmFjdGl2ZRgDIAEoCCJWChlTdWJz", "Y3JpcHRpb25VcGRhdGVSZXF1ZXN0EjkKA3JlZhgCIAMoCzIsLmJncy5wcm90", "b2NvbC5hY2NvdW50LnYxLlN1YnNjcmliZXJSZWZlcmVuY2UiVwoaU3Vic2Ny", "aXB0aW9uVXBkYXRlUmVzcG9uc2USOQoDcmVmGAEgAygLMiwuYmdzLnByb3Rv", "Y29sLmFjY291bnQudjEuU3Vic2NyaWJlclJlZmVyZW5jZSI9ChNJc0lnckFk", "ZHJlc3NSZXF1ZXN0EhYKDmNsaWVudF9hZGRyZXNzGAEgASgJEg4KBnJlZ2lv", "bhgCIAEoDSLkAQoWR2V0QWNjb3VudFN0YXRlUmVxdWVzdBIxCgllbnRpdHlf", "aWQYASABKAsyFi5iZ3MucHJvdG9jb2wuRW50aXR5SWRCBoL5KwIQARIPCgdw", "cm9ncmFtGAIgASgNEg4KBnJlZ2lvbhgDIAEoDRI9CgdvcHRpb25zGAogASgL", "MiwuYmdzLnByb3RvY29sLmFjY291bnQudjEuQWNjb3VudEZpZWxkT3B0aW9u",
				"cxI3CgR0YWdzGAsgASgLMikuYmdzLnByb3RvY29sLmFjY291bnQudjEuQWNj", "b3VudEZpZWxkVGFncyKIAQoXR2V0QWNjb3VudFN0YXRlUmVzcG9uc2USNAoF", "c3RhdGUYASABKAsyJS5iZ3MucHJvdG9jb2wuYWNjb3VudC52MS5BY2NvdW50", "U3RhdGUSNwoEdGFncxgCIAEoCzIpLmJncy5wcm90b2NvbC5hY2NvdW50LnYx", "LkFjY291bnRGaWVsZFRhZ3MiUwocR2V0U2lnbmVkQWNjb3VudFN0YXRlUmVx", "dWVzdBIzCgdhY2NvdW50GAEgASgLMiIuYmdzLnByb3RvY29sLmFjY291bnQu", "djEuQWNjb3VudElkIi4KHUdldFNpZ25lZEFjY291bnRTdGF0ZVJlc3BvbnNl", "Eg0KBXRva2VuGAEgASgJIv0BChpHZXRHYW1lQWNjb3VudFN0YXRlUmVxdWVz", "dBIuCgphY2NvdW50X2lkGAEgASgLMhYuYmdzLnByb3RvY29sLkVudGl0eUlk", "QgIYARIvCg9nYW1lX2FjY291bnRfaWQYAiABKAsyFi5iZ3MucHJvdG9jb2wu",
				"RW50aXR5SWQSQQoHb3B0aW9ucxgKIAEoCzIwLmJncy5wcm90b2NvbC5hY2Nv", "dW50LnYxLkdhbWVBY2NvdW50RmllbGRPcHRpb25zEjsKBHRhZ3MYCyABKAsy", "LS5iZ3MucHJvdG9jb2wuYWNjb3VudC52MS5HYW1lQWNjb3VudEZpZWxkVGFn", "cyKUAQobR2V0R2FtZUFjY291bnRTdGF0ZVJlc3BvbnNlEjgKBXN0YXRlGAEg", "ASgLMikuYmdzLnByb3RvY29sLmFjY291bnQudjEuR2FtZUFjY291bnRTdGF0", "ZRI7CgR0YWdzGAIgASgLMi0uYmdzLnByb3RvY29sLmFjY291bnQudjEuR2Ft", "ZUFjY291bnRGaWVsZFRhZ3Mi7QEKEkdldExpY2Vuc2VzUmVxdWVzdBIxCgl0", "YXJnZXRfaWQYASABKAsyFi5iZ3MucHJvdG9jb2wuRW50aXR5SWRCBoL5KwIQ", "ARIeChZmZXRjaF9hY2NvdW50X2xpY2Vuc2VzGAIgASgIEiMKG2ZldGNoX2dh", "bWVfYWNjb3VudF9saWNlbnNlcxgDIAEoCBImCh5mZXRjaF9keW5hbWljX2Fj",
				"Y291bnRfbGljZW5zZXMYBCABKAgSDwoHcHJvZ3JhbRgFIAEoBxImChdleGNs", "dWRlX3Vua25vd25fcHJvZ3JhbRgGIAEoCDoFZmFsc2UiUAoTR2V0TGljZW5z", "ZXNSZXNwb25zZRI5CghsaWNlbnNlcxgBIAMoCzInLmJncy5wcm90b2NvbC5h", "Y2NvdW50LnYxLkFjY291bnRMaWNlbnNlIkYKGUdldEdhbWVTZXNzaW9uSW5m", "b1JlcXVlc3QSKQoJZW50aXR5X2lkGAEgASgLMhYuYmdzLnByb3RvY29sLkVu", "dGl0eUlkIlwKGkdldEdhbWVTZXNzaW9uSW5mb1Jlc3BvbnNlEj4KDHNlc3Np", "b25faW5mbxgCIAEoCzIoLmJncy5wcm90b2NvbC5hY2NvdW50LnYxLkdhbWVT", "ZXNzaW9uSW5mbyKVAQofR2V0R2FtZVRpbWVSZW1haW5pbmdJbmZvUmVxdWVz", "dBIvCg9nYW1lX2FjY291bnRfaWQYASABKAsyFi5iZ3MucHJvdG9jb2wuRW50", "aXR5SWQSKgoKYWNjb3VudF9pZBgCIAEoCzIWLmJncy5wcm90b2NvbC5FbnRp",
				"dHlJZBIVCg1iZW5lZmFjdG9yX2lkGAMgASgJInQKIEdldEdhbWVUaW1lUmVt", "YWluaW5nSW5mb1Jlc3BvbnNlElAKGGdhbWVfdGltZV9yZW1haW5pbmdfaW5m", "bxgBIAEoCzIuLmJncy5wcm90b2NvbC5hY2NvdW50LnYxLkdhbWVUaW1lUmVt", "YWluaW5nSW5mbyJHChJHZXRDQUlTSW5mb1JlcXVlc3QSMQoJZW50aXR5X2lk", "GAEgASgLMhYuYmdzLnByb3RvY29sLkVudGl0eUlkQgaC+SsCEAEiRwoTR2V0", "Q0FJU0luZm9SZXNwb25zZRIwCgljYWlzX2luZm8YASABKAsyHS5iZ3MucHJv", "dG9jb2wuYWNjb3VudC52MS5DQUlTIm4KGEdldEF1dGhvcml6ZWREYXRhUmVx", "dWVzdBIpCgllbnRpdHlfaWQYASABKAsyFi5iZ3MucHJvdG9jb2wuRW50aXR5", "SWQSCwoDdGFnGAIgAygJEhoKEnByaXZpbGVnZWRfbmV0d29yaxgDIAEoCCJS", "ChlHZXRBdXRob3JpemVkRGF0YVJlc3BvbnNlEjUKBGRhdGEYASADKAsyJy5i",
				"Z3MucHJvdG9jb2wuYWNjb3VudC52MS5BdXRob3JpemVkRGF0YSL7AQokVXBk", "YXRlUGFyZW50YWxDb250cm9sc0FuZENBSVNSZXF1ZXN0EjMKB2FjY291bnQY", "ASABKAsyIi5iZ3MucHJvdG9jb2wuYWNjb3VudC52MS5BY2NvdW50SWQSSwoV", "cGFyZW50YWxfY29udHJvbF9pbmZvGAIgASgLMiwuYmdzLnByb3RvY29sLmFj", "Y291bnQudjEuUGFyZW50YWxDb250cm9sSW5mbxIPCgdjYWlzX2lkGAMgASgJ", "EhoKEnNlc3Npb25fc3RhcnRfdGltZRgEIAEoBBISCgpzdGFydF90aW1lGAUg", "ASgEEhAKCGVuZF90aW1lGAYgASgEItQBChhBY2NvdW50U3RhdGVOb3RpZmlj", "YXRpb24SPAoNYWNjb3VudF9zdGF0ZRgBIAEoCzIlLmJncy5wcm90b2NvbC5h", "Y2NvdW50LnYxLkFjY291bnRTdGF0ZRIZCg1zdWJzY3JpYmVyX2lkGAIgASgE", "QgIYARI/CgxhY2NvdW50X3RhZ3MYAyABKAsyKS5iZ3MucHJvdG9jb2wuYWNj",
				"b3VudC52MS5BY2NvdW50RmllbGRUYWdzEh4KFnN1YnNjcmlwdGlvbl9jb21w", "bGV0ZWQYBCABKAgi6gEKHEdhbWVBY2NvdW50U3RhdGVOb3RpZmljYXRpb24S", "RQoSZ2FtZV9hY2NvdW50X3N0YXRlGAEgASgLMikuYmdzLnByb3RvY29sLmFj", "Y291bnQudjEuR2FtZUFjY291bnRTdGF0ZRIZCg1zdWJzY3JpYmVyX2lkGAIg", "ASgEQgIYARJIChFnYW1lX2FjY291bnRfdGFncxgDIAEoCzItLmJncy5wcm90", "b2NvbC5hY2NvdW50LnYxLkdhbWVBY2NvdW50RmllbGRUYWdzEh4KFnN1YnNj", "cmlwdGlvbl9jb21wbGV0ZWQYBCABKAgisgEKF0dhbWVBY2NvdW50Tm90aWZp", "Y2F0aW9uEj8KDWdhbWVfYWNjb3VudHMYASADKAsyKC5iZ3MucHJvdG9jb2wu", "YWNjb3VudC52MS5HYW1lQWNjb3VudExpc3QSFQoNc3Vic2NyaWJlcl9pZBgC", "IAEoBBI/CgxhY2NvdW50X3RhZ3MYAyABKAsyKS5iZ3MucHJvdG9jb2wuYWNj",
				"b3VudC52MS5BY2NvdW50RmllbGRUYWdzIqgBCh5HYW1lQWNjb3VudFNlc3Np", "b25Ob3RpZmljYXRpb24SQAoMZ2FtZV9hY2NvdW50GAEgASgLMiouYmdzLnBy", "b3RvY29sLmFjY291bnQudjEuR2FtZUFjY291bnRIYW5kbGUSRAoMc2Vzc2lv", "bl9pbmZvGAIgASgLMi4uYmdzLnByb3RvY29sLmFjY291bnQudjEuR2FtZVNl", "c3Npb25VcGRhdGVJbmZvMqAMCg5BY2NvdW50U2VydmljZRJ5Cg5SZXNvbHZl", "QWNjb3VudBIuLmJncy5wcm90b2NvbC5hY2NvdW50LnYxLlJlc29sdmVBY2Nv", "dW50UmVxdWVzdBovLmJncy5wcm90b2NvbC5hY2NvdW50LnYxLlJlc29sdmVB", "Y2NvdW50UmVzcG9uc2UiBoL5KwIIDRJdCgxJc0lnckFkZHJlc3MSLC5iZ3Mu", "cHJvdG9jb2wuYWNjb3VudC52MS5Jc0lnckFkZHJlc3NSZXF1ZXN0GhQuYmdz", "LnByb3RvY29sLk5vRGF0YSIJiAIBgvkrAggPEnwKCVN1YnNjcmliZRIyLmJn",
				"cy5wcm90b2NvbC5hY2NvdW50LnYxLlN1YnNjcmlwdGlvblVwZGF0ZVJlcXVl", "c3QaMy5iZ3MucHJvdG9jb2wuYWNjb3VudC52MS5TdWJzY3JpcHRpb25VcGRh", "dGVSZXNwb25zZSIGgvkrAggZEl8KC1Vuc3Vic2NyaWJlEjIuYmdzLnByb3Rv", "Y29sLmFjY291bnQudjEuU3Vic2NyaXB0aW9uVXBkYXRlUmVxdWVzdBoULmJn", "cy5wcm90b2NvbC5Ob0RhdGEiBoL5KwIIGhJ8Cg9HZXRBY2NvdW50U3RhdGUS", "Ly5iZ3MucHJvdG9jb2wuYWNjb3VudC52MS5HZXRBY2NvdW50U3RhdGVSZXF1", "ZXN0GjAuYmdzLnByb3RvY29sLmFjY291bnQudjEuR2V0QWNjb3VudFN0YXRl", "UmVzcG9uc2UiBoL5KwIIHhKIAQoTR2V0R2FtZUFjY291bnRTdGF0ZRIzLmJn", "cy5wcm90b2NvbC5hY2NvdW50LnYxLkdldEdhbWVBY2NvdW50U3RhdGVSZXF1", "ZXN0GjQuYmdzLnByb3RvY29sLmFjY291bnQudjEuR2V0R2FtZUFjY291bnRT",
				"dGF0ZVJlc3BvbnNlIgaC+SsCCB8ScAoLR2V0TGljZW5zZXMSKy5iZ3MucHJv", "dG9jb2wuYWNjb3VudC52MS5HZXRMaWNlbnNlc1JlcXVlc3QaLC5iZ3MucHJv", "dG9jb2wuYWNjb3VudC52MS5HZXRMaWNlbnNlc1Jlc3BvbnNlIgaC+SsCCCAS", "lwEKGEdldEdhbWVUaW1lUmVtYWluaW5nSW5mbxI4LmJncy5wcm90b2NvbC5h", "Y2NvdW50LnYxLkdldEdhbWVUaW1lUmVtYWluaW5nSW5mb1JlcXVlc3QaOS5i", "Z3MucHJvdG9jb2wuYWNjb3VudC52MS5HZXRHYW1lVGltZVJlbWFpbmluZ0lu", "Zm9SZXNwb25zZSIGgvkrAgghEoUBChJHZXRHYW1lU2Vzc2lvbkluZm8SMi5i", "Z3MucHJvdG9jb2wuYWNjb3VudC52MS5HZXRHYW1lU2Vzc2lvbkluZm9SZXF1", "ZXN0GjMuYmdzLnByb3RvY29sLmFjY291bnQudjEuR2V0R2FtZVNlc3Npb25J", "bmZvUmVzcG9uc2UiBoL5KwIIIhJwCgtHZXRDQUlTSW5mbxIrLmJncy5wcm90",
				"b2NvbC5hY2NvdW50LnYxLkdldENBSVNJbmZvUmVxdWVzdBosLmJncy5wcm90", "b2NvbC5hY2NvdW50LnYxLkdldENBSVNJbmZvUmVzcG9uc2UiBoL5KwIIIxKC", "AQoRR2V0QXV0aG9yaXplZERhdGESMS5iZ3MucHJvdG9jb2wuYWNjb3VudC52", "MS5HZXRBdXRob3JpemVkRGF0YVJlcXVlc3QaMi5iZ3MucHJvdG9jb2wuYWNj", "b3VudC52MS5HZXRBdXRob3JpemVkRGF0YVJlc3BvbnNlIgaC+SsCCCUSjgEK", "FUdldFNpZ25lZEFjY291bnRTdGF0ZRI1LmJncy5wcm90b2NvbC5hY2NvdW50", "LnYxLkdldFNpZ25lZEFjY291bnRTdGF0ZVJlcXVlc3QaNi5iZ3MucHJvdG9j", "b2wuYWNjb3VudC52MS5HZXRTaWduZWRBY2NvdW50U3RhdGVSZXNwb25zZSIG", "gvkrAggsGjCC+SsmCiRibmV0LnByb3RvY29sLmFjY291bnQuQWNjb3VudFNl", "cnZpY2WK+SsCEAEykAQKD0FjY291bnRMaXN0ZW5lchJtChVPbkFjY291bnRT",
				"dGF0ZVVwZGF0ZWQSMS5iZ3MucHJvdG9jb2wuYWNjb3VudC52MS5BY2NvdW50", "U3RhdGVOb3RpZmljYXRpb24aGS5iZ3MucHJvdG9jb2wuTk9fUkVTUE9OU0Ui", "BoL5KwIIARJ1ChlPbkdhbWVBY2NvdW50U3RhdGVVcGRhdGVkEjUuYmdzLnBy", "b3RvY29sLmFjY291bnQudjEuR2FtZUFjY291bnRTdGF0ZU5vdGlmaWNhdGlv", "bhoZLmJncy5wcm90b2NvbC5OT19SRVNQT05TRSIGgvkrAggCEm8KFU9uR2Ft", "ZUFjY291bnRzVXBkYXRlZBIwLmJncy5wcm90b2NvbC5hY2NvdW50LnYxLkdh", "bWVBY2NvdW50Tm90aWZpY2F0aW9uGhkuYmdzLnByb3RvY29sLk5PX1JFU1BP", "TlNFIgmIAgGC+SsCCAMSdQoUT25HYW1lU2Vzc2lvblVwZGF0ZWQSNy5iZ3Mu", "cHJvdG9jb2wuYWNjb3VudC52MS5HYW1lQWNjb3VudFNlc3Npb25Ob3RpZmlj", "YXRpb24aGS5iZ3MucHJvdG9jb2wuTk9fUkVTUE9OU0UiCYgCAYL5KwIIBBov",
				"gvkrJQojYm5ldC5wcm90b2NvbC5hY2NvdW50LkFjY291bnROb3RpZnmK+SsC", "CAFCBUgBgAEA"
			}));
			AccountServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				AccountTypesReflection.Descriptor,
				EntityTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ResolveAccountRequest), ResolveAccountRequest.Parser, new string[] { "Ref", "FetchId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ResolveAccountResponse), ResolveAccountResponse.Parser, new string[] { "Id" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameAccountFlagUpdateRequest), GameAccountFlagUpdateRequest.Parser, new string[] { "GameAccount", "Flag", "Active" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SubscriptionUpdateRequest), SubscriptionUpdateRequest.Parser, new string[] { "Ref" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SubscriptionUpdateResponse), SubscriptionUpdateResponse.Parser, new string[] { "Ref" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(IsIgrAddressRequest), IsIgrAddressRequest.Parser, new string[] { "ClientAddress", "Region" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetAccountStateRequest), GetAccountStateRequest.Parser, new string[] { "EntityId", "Program", "Region", "Options", "Tags" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetAccountStateResponse), GetAccountStateResponse.Parser, new string[] { "State", "Tags" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetSignedAccountStateRequest), GetSignedAccountStateRequest.Parser, new string[] { "Account" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetSignedAccountStateResponse), GetSignedAccountStateResponse.Parser, new string[] { "Token" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetGameAccountStateRequest), GetGameAccountStateRequest.Parser, new string[] { "AccountId", "GameAccountId", "Options", "Tags" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetGameAccountStateResponse), GetGameAccountStateResponse.Parser, new string[] { "State", "Tags" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetLicensesRequest), GetLicensesRequest.Parser, new string[] { "TargetId", "FetchAccountLicenses", "FetchGameAccountLicenses", "FetchDynamicAccountLicenses", "Program", "ExcludeUnknownProgram" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetLicensesResponse), GetLicensesResponse.Parser, new string[] { "Licenses" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetGameSessionInfoRequest), GetGameSessionInfoRequest.Parser, new string[] { "EntityId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetGameSessionInfoResponse), GetGameSessionInfoResponse.Parser, new string[] { "SessionInfo" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetGameTimeRemainingInfoRequest), GetGameTimeRemainingInfoRequest.Parser, new string[] { "GameAccountId", "AccountId", "BenefactorId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetGameTimeRemainingInfoResponse), GetGameTimeRemainingInfoResponse.Parser, new string[] { "GameTimeRemainingInfo" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetCAISInfoRequest), GetCAISInfoRequest.Parser, new string[] { "EntityId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetCAISInfoResponse), GetCAISInfoResponse.Parser, new string[] { "CaisInfo" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetAuthorizedDataRequest), GetAuthorizedDataRequest.Parser, new string[] { "EntityId", "Tag", "PrivilegedNetwork" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetAuthorizedDataResponse), GetAuthorizedDataResponse.Parser, new string[] { "Data" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UpdateParentalControlsAndCAISRequest), UpdateParentalControlsAndCAISRequest.Parser, new string[] { "Account", "ParentalControlInfo", "CaisId", "SessionStartTime", "StartTime", "EndTime" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AccountStateNotification), AccountStateNotification.Parser, new string[] { "AccountState", "SubscriberId", "AccountTags", "SubscriptionCompleted" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameAccountStateNotification), GameAccountStateNotification.Parser, new string[] { "GameAccountState", "SubscriberId", "GameAccountTags", "SubscriptionCompleted" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameAccountNotification), GameAccountNotification.Parser, new string[] { "GameAccounts", "SubscriberId", "AccountTags" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameAccountSessionNotification), GameAccountSessionNotification.Parser, new string[] { "GameAccount", "SessionInfo" }, null, null, null, null)
			}));
		}

		// Token: 0x04004A87 RID: 19079
		private static FileDescriptor descriptor;
	}
}
