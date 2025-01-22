using System;
using Bgs.Protocol.Account.V1;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006F0 RID: 1776
	public static class ChannelVoiceServiceReflection
	{
		// Token: 0x170032B7 RID: 12983
		// (get) Token: 0x0600A3D2 RID: 41938 RVA: 0x0027EE0C File Offset: 0x0027D00C
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChannelVoiceServiceReflection.descriptor;
			}
		}

		// Token: 0x0600A3D3 RID: 41939 RVA: 0x0027EE24 File Offset: 0x0027D024
		static ChannelVoiceServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"Ci1iZ3MvbG93L3BiL2NsaWVudC9jaGFubmVsX3ZvaWNlX3NlcnZpY2UucHJv", "dG8SF2Jncy5wcm90b2NvbC5jaGFubmVsLnYxGiViZ3MvbG93L3BiL2NsaWVu", "dC9jaGFubmVsX3R5cGVzLnByb3RvGiViZ3MvbG93L3BiL2NsaWVudC9hY2Nv", "dW50X3R5cGVzLnByb3RvGiNiZ3MvbG93L3BiL2NsaWVudC92b2ljZV90eXBl", "cy5wcm90bxohYmdzL2xvdy9wYi9jbGllbnQvcnBjX3R5cGVzLnByb3RvIlUK", "FEdldExvZ2luVG9rZW5SZXF1ZXN0Ej0KCW1lbWJlcl9pZBgDIAEoCzIqLmJn", "cy5wcm90b2NvbC5hY2NvdW50LnYxLkdhbWVBY2NvdW50SGFuZGxlIkwKFUdl", "dExvZ2luVG9rZW5SZXNwb25zZRIzCgtjcmVkZW50aWFscxgBIAEoCzIeLmJn", "cy5wcm90b2NvbC5Wb2ljZUNyZWRlbnRpYWxzIowBChNHZXRKb2luVG9rZW5S", "ZXF1ZXN0EjYKCmNoYW5uZWxfaWQYAiABKAsyIi5iZ3MucHJvdG9jb2wuY2hh",
				"bm5lbC52MS5DaGFubmVsSWQSPQoJbWVtYmVyX2lkGAQgASgLMiouYmdzLnBy", "b3RvY29sLmFjY291bnQudjEuR2FtZUFjY291bnRIYW5kbGUiYAoUR2V0Sm9p", "blRva2VuUmVzcG9uc2USEwoLY2hhbm5lbF91cmkYASABKAkSMwoLY3JlZGVu", "dGlhbHMYAiABKAsyHi5iZ3MucHJvdG9jb2wuVm9pY2VDcmVkZW50aWFsczK8", "AgoTQ2hhbm5lbFZvaWNlU2VydmljZRJ2Cg1HZXRMb2dpblRva2VuEi0uYmdz", "LnByb3RvY29sLmNoYW5uZWwudjEuR2V0TG9naW5Ub2tlblJlcXVlc3QaLi5i", "Z3MucHJvdG9jb2wuY2hhbm5lbC52MS5HZXRMb2dpblRva2VuUmVzcG9uc2Ui", "BoL5KwIIARJzCgxHZXRKb2luVG9rZW4SLC5iZ3MucHJvdG9jb2wuY2hhbm5l", "bC52MS5HZXRKb2luVG9rZW5SZXF1ZXN0Gi0uYmdzLnByb3RvY29sLmNoYW5u", "ZWwudjEuR2V0Sm9pblRva2VuUmVzcG9uc2UiBoL5KwIIAho4gvkrLgosYm5l",
				"dC5wcm90b2NvbC5jaGFubmVsLnYxLkNoYW5uZWxWb2ljZVNlcnZpY2WK+SsC", "EAFCA4ABAA=="
			}));
			ChannelVoiceServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				ChannelTypesReflection.Descriptor,
				AccountTypesReflection.Descriptor,
				VoiceTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(GetLoginTokenRequest), GetLoginTokenRequest.Parser, new string[] { "MemberId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetLoginTokenResponse), GetLoginTokenResponse.Parser, new string[] { "Credentials" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetJoinTokenRequest), GetJoinTokenRequest.Parser, new string[] { "ChannelId", "MemberId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetJoinTokenResponse), GetJoinTokenResponse.Parser, new string[] { "ChannelUri", "Credentials" }, null, null, null, null)
			}));
		}

		// Token: 0x040049DE RID: 18910
		private static FileDescriptor descriptor;
	}
}
