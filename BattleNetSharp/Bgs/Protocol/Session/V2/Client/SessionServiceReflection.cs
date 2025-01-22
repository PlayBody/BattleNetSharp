using System;
using Bgs.Protocol.Account.V2;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x02000559 RID: 1369
	public static class SessionServiceReflection
	{
		// Token: 0x170029C5 RID: 10693
		// (get) Token: 0x0600843B RID: 33851 RVA: 0x00202628 File Offset: 0x00200828
		public static FileDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.descriptor;
			}
		}

		// Token: 0x0600843C RID: 33852 RVA: 0x00202640 File Offset: 0x00200840
		static SessionServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjViZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL3Nlc3Npb25fc2Vy", "dmljZS5wcm90bxIeYmdzLnByb3RvY29sLnNlc3Npb24udjIuY2xpZW50GjNi", "Z3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL2FjY291bnRfdHlwZXMu", "cHJvdG8aOWJncy9sb3cvcGIvY2xpZW50L2FwaS9jbGllbnQvdjIvZ2FtZV9h", "Y2NvdW50X2hhbmRsZS5wcm90bxozYmdzL2xvdy9wYi9jbGllbnQvYXBpL2Ns", "aWVudC92Mi9zZXNzaW9uX3R5cGVzLnByb3RvGiFiZ3MvbG93L3BiL2NsaWVu", "dC9ycGNfdHlwZXMucHJvdG8imAEKFENyZWF0ZVNlc3Npb25SZXF1ZXN0EkAK", "DGdhbWVfYWNjb3VudBgBIAEoCzIqLmJncy5wcm90b2NvbC5hY2NvdW50LnYy", "LkdhbWVBY2NvdW50SGFuZGxlEj4KB29wdGlvbnMYAiABKAsyLS5iZ3MucHJv", "dG9jb2wuc2Vzc2lvbi52Mi5jbGllbnQuQ3JlYXRlT3B0aW9ucyKbAQoVQ3Jl",
				"YXRlU2Vzc2lvblJlc3BvbnNlEj0KCnNlc3Npb25faWQYASABKAsyKS5iZ3Mu", "cHJvdG9jb2wuc2Vzc2lvbi52Mi5jbGllbnQuU2Vzc2lvbklkEkMKCXZhcmlh", "YmxlcxgCIAEoCzIwLmJncy5wcm90b2NvbC5zZXNzaW9uLnYyLmNsaWVudC5T", "ZXNzaW9uVmFyaWFibGVzIucBChVSZXN0b3JlU2Vzc2lvblJlcXVlc3QSMwoI", "aWRlbnRpdHkYASABKAsyIS5iZ3MucHJvdG9jb2wuYWNjb3VudC52Mi5JZGVu", "dGl0eRITCgtzZXNzaW9uX2tleRgCIAEoDBI/CgdvcHRpb25zGAMgASgLMi4u", "YmdzLnByb3RvY29sLnNlc3Npb24udjIuY2xpZW50LlJlc3RvcmVPcHRpb25z", "EkMKDXN0YXRlX29wdGlvbnMYBCABKAsyLC5iZ3MucHJvdG9jb2wuc2Vzc2lv", "bi52Mi5jbGllbnQuU3RhdGVPcHRpb25zIpwBChZSZXN0b3JlU2Vzc2lvblJl", "c3BvbnNlEj0KCnNlc3Npb25faWQYASABKAsyKS5iZ3MucHJvdG9jb2wuc2Vz",
				"c2lvbi52Mi5jbGllbnQuU2Vzc2lvbklkEkMKCXZhcmlhYmxlcxgCIAEoCzIw", "LmJncy5wcm90b2NvbC5zZXNzaW9uLnYyLmNsaWVudC5TZXNzaW9uVmFyaWFi", "bGVzIhcKFURlc3Ryb3lTZXNzaW9uUmVxdWVzdCIeChxHZXRTaWduZWRTZXNz", "aW9uU3RhdGVSZXF1ZXN0IjUKHUdldFNpZ25lZFNlc3Npb25TdGF0ZVJlc3Bv", "bnNlEhQKDHNpZ25lZF90b2tlbhgBIAEoCSIYChZHZXRTZXNzaW9uU3RhdGVS", "ZXF1ZXN0IlgKF0dldFNlc3Npb25TdGF0ZVJlc3BvbnNlEj0KB3Nlc3Npb24Y", "ASABKAsyLC5iZ3MucHJvdG9jb2wuc2Vzc2lvbi52Mi5jbGllbnQuU2Vzc2lv", "blN0YXRlIhkKF01hcmtTZXNzaW9uQWxpdmVSZXF1ZXN0MtUGCg5TZXNzaW9u", "U2VydmljZRKEAQoNQ3JlYXRlU2Vzc2lvbhI0LmJncy5wcm90b2NvbC5zZXNz", "aW9uLnYyLmNsaWVudC5DcmVhdGVTZXNzaW9uUmVxdWVzdBo1LmJncy5wcm90",
				"b2NvbC5zZXNzaW9uLnYyLmNsaWVudC5DcmVhdGVTZXNzaW9uUmVzcG9uc2Ui", "BoL5KwIIARKHAQoOUmVzdG9yZVNlc3Npb24SNS5iZ3MucHJvdG9jb2wuc2Vz", "c2lvbi52Mi5jbGllbnQuUmVzdG9yZVNlc3Npb25SZXF1ZXN0GjYuYmdzLnBy", "b3RvY29sLnNlc3Npb24udjIuY2xpZW50LlJlc3RvcmVTZXNzaW9uUmVzcG9u", "c2UiBoL5KwIIAhJlCg5EZXN0cm95U2Vzc2lvbhI1LmJncy5wcm90b2NvbC5z", "ZXNzaW9uLnYyLmNsaWVudC5EZXN0cm95U2Vzc2lvblJlcXVlc3QaFC5iZ3Mu", "cHJvdG9jb2wuTm9EYXRhIgaC+SsCCAMSnAEKFUdldFNpZ25lZFNlc3Npb25T", "dGF0ZRI8LmJncy5wcm90b2NvbC5zZXNzaW9uLnYyLmNsaWVudC5HZXRTaWdu", "ZWRTZXNzaW9uU3RhdGVSZXF1ZXN0Gj0uYmdzLnByb3RvY29sLnNlc3Npb24u", "djIuY2xpZW50LkdldFNpZ25lZFNlc3Npb25TdGF0ZVJlc3BvbnNlIgaC+SsC",
				"CAQSigEKD0dldFNlc3Npb25TdGF0ZRI2LmJncy5wcm90b2NvbC5zZXNzaW9u", "LnYyLmNsaWVudC5HZXRTZXNzaW9uU3RhdGVSZXF1ZXN0GjcuYmdzLnByb3Rv", "Y29sLnNlc3Npb24udjIuY2xpZW50LkdldFNlc3Npb25TdGF0ZVJlc3BvbnNl", "IgaC+SsCCAUSaQoQTWFya1Nlc3Npb25BbGl2ZRI3LmJncy5wcm90b2NvbC5z", "ZXNzaW9uLnYyLmNsaWVudC5NYXJrU2Vzc2lvbkFsaXZlUmVxdWVzdBoULmJn", "cy5wcm90b2NvbC5Ob0RhdGEiBoL5KwIIBho0gvkrMAouYm5ldC5wcm90b2Nv", "bC5zZXNzaW9uLnYyLmNsaWVudC5TZXNzaW9uU2VydmljZUIDgAEA"
			}));
			SessionServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				AccountTypesReflection.Descriptor,
				GameAccountHandleReflection.Descriptor,
				SessionTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(CreateSessionRequest), CreateSessionRequest.Parser, new string[] { "GameAccount", "Options" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CreateSessionResponse), CreateSessionResponse.Parser, new string[] { "SessionId", "Variables" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RestoreSessionRequest), RestoreSessionRequest.Parser, new string[] { "Identity", "SessionKey", "Options", "StateOptions" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RestoreSessionResponse), RestoreSessionResponse.Parser, new string[] { "SessionId", "Variables" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(DestroySessionRequest), DestroySessionRequest.Parser, null, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetSignedSessionStateRequest), GetSignedSessionStateRequest.Parser, null, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetSignedSessionStateResponse), GetSignedSessionStateResponse.Parser, new string[] { "SignedToken" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetSessionStateRequest), GetSessionStateRequest.Parser, null, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetSessionStateResponse), GetSessionStateResponse.Parser, new string[] { "Session" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MarkSessionAliveRequest), MarkSessionAliveRequest.Parser, null, null, null, null, null)
			}));
		}

		// Token: 0x04003C09 RID: 15369
		private static FileDescriptor descriptor;
	}
}
