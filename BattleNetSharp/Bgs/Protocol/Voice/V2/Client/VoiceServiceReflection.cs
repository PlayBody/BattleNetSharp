using System;
using Bgs.Protocol.Account.V1;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Voice.V2.Client
{
	// Token: 0x02000528 RID: 1320
	public static class VoiceServiceReflection
	{
		// Token: 0x17002889 RID: 10377
		// (get) Token: 0x06008009 RID: 32777 RVA: 0x001F2818 File Offset: 0x001F0A18
		public static FileDescriptor Descriptor
		{
			get
			{
				return VoiceServiceReflection.descriptor;
			}
		}

		// Token: 0x0600800A RID: 32778 RVA: 0x001F2830 File Offset: 0x001F0A30
		static VoiceServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjNiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL3ZvaWNlX3NlcnZp", "Y2UucHJvdG8SHGJncy5wcm90b2NvbC52b2ljZS52Mi5jbGllbnQaI2Jncy9s", "b3cvcGIvY2xpZW50L3ZvaWNlX3R5cGVzLnByb3RvGiViZ3MvbG93L3BiL2Ns", "aWVudC9hY2NvdW50X3R5cGVzLnByb3RvGiFiZ3MvbG93L3BiL2NsaWVudC9y", "cGNfdHlwZXMucHJvdG8ibgodQ3JlYXRlTG9naW5DcmVkZW50aWFsc1JlcXVl", "c3QSPAoQYWdlbnRfYWNjb3VudF9pZBgBIAEoCzIiLmJncy5wcm90b2NvbC5h", "Y2NvdW50LnYxLkFjY291bnRJZBIPCgd2ZXJzaW9uGAIgASgNIlUKHkNyZWF0", "ZUxvZ2luQ3JlZGVudGlhbHNSZXNwb25zZRIzCgtjcmVkZW50aWFscxgBIAEo", "CzIeLmJncy5wcm90b2NvbC5Wb2ljZUNyZWRlbnRpYWxzIoIBChxDcmVhdGVD", "aGFubmVsU3R0VG9rZW5SZXF1ZXN0EjwKEGFnZW50X2FjY291bnRfaWQYASAB",
				"KAsyIi5iZ3MucHJvdG9jb2wuYWNjb3VudC52MS5BY2NvdW50SWQSEwoLY2hh", "bm5lbF91cmkYAiABKAkSDwoHdmVyc2lvbhgDIAEoDSIuCh1DcmVhdGVDaGFu", "bmVsU3R0VG9rZW5SZXNwb25zZRINCgV0b2tlbhgBIAEoCTK3AgoMVm9pY2VT", "ZXJ2aWNlEpMBChZDcmVhdGVMb2dpbkNyZWRlbnRpYWxzEjsuYmdzLnByb3Rv", "Y29sLnZvaWNlLnYyLmNsaWVudC5DcmVhdGVMb2dpbkNyZWRlbnRpYWxzUmVx", "dWVzdBo8LmJncy5wcm90b2NvbC52b2ljZS52Mi5jbGllbnQuQ3JlYXRlTG9n", "aW5DcmVkZW50aWFsc1Jlc3BvbnNlEpABChVDcmVhdGVDaGFubmVsU3R0VG9r", "ZW4SOi5iZ3MucHJvdG9jb2wudm9pY2UudjIuY2xpZW50LkNyZWF0ZUNoYW5u", "ZWxTdHRUb2tlblJlcXVlc3QaOy5iZ3MucHJvdG9jb2wudm9pY2UudjIuY2xp", "ZW50LkNyZWF0ZUNoYW5uZWxTdHRUb2tlblJlc3BvbnNl"
			}));
			VoiceServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				VoiceTypesReflection.Descriptor,
				AccountTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(CreateLoginCredentialsRequest), CreateLoginCredentialsRequest.Parser, new string[] { "AgentAccountId", "Version" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CreateLoginCredentialsResponse), CreateLoginCredentialsResponse.Parser, new string[] { "Credentials" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CreateChannelSttTokenRequest), CreateChannelSttTokenRequest.Parser, new string[] { "AgentAccountId", "ChannelUri", "Version" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CreateChannelSttTokenResponse), CreateChannelSttTokenResponse.Parser, new string[] { "Token" }, null, null, null, null)
			}));
		}

		// Token: 0x04003A26 RID: 14886
		private static FileDescriptor descriptor;
	}
}
