using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V2.Client
{
	// Token: 0x0200061B RID: 1563
	public static class AuthenticationListenerReflection
	{
		// Token: 0x17002DB1 RID: 11697
		// (get) Token: 0x06009243 RID: 37443 RVA: 0x002370FC File Offset: 0x002352FC
		public static FileDescriptor Descriptor
		{
			get
			{
				return AuthenticationListenerReflection.descriptor;
			}
		}

		// Token: 0x06009244 RID: 37444 RVA: 0x00237114 File Offset: 0x00235314
		static AuthenticationListenerReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"Cj1iZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL2F1dGhlbnRpY2F0", "aW9uX2xpc3RlbmVyLnByb3RvEiViZ3MucHJvdG9jb2wuYXV0aGVudGljYXRp", "b24udjIuY2xpZW50GjpiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3Yy", "L2F1dGhlbnRpY2F0aW9uX3R5cGVzLnByb3RvGiFiZ3MvbG93L3BiL2NsaWVu", "dC9ycGNfdHlwZXMucHJvdG8icwoZTG9nb25Db21wbGV0ZU5vdGlmaWNhdGlv", "bhISCgplcnJvcl9jb2RlGAEgASgNEkIKBnJlY29yZBgCIAEoCzIyLmJncy5w", "cm90b2NvbC5hdXRoZW50aWNhdGlvbi52Mi5jbGllbnQuTG9nb25SZWNvcmQi", "ZQocTG9nb25RdWV1ZVVwZGF0ZU5vdGlmaWNhdGlvbhJFCgVzdGF0ZRgBIAEo", "CzI2LmJncy5wcm90b2NvbC5hdXRoZW50aWNhdGlvbi52Mi5jbGllbnQuTG9n", "b25RdWV1ZVN0YXRlIl0KHUV4dGVybmFsQ2hhbGxlbmdlTm90aWZpY2F0aW9u",
				"EhUKDXJlcXVlc3RfdG9rZW4YASABKAkSFAoMcGF5bG9hZF90eXBlGAIgASgJ", "Eg8KB3BheWxvYWQYAyABKAwynwQKFkF1dGhlbnRpY2F0aW9uTGlzdGVuZXIS", "dgoPT25Mb2dvbkNvbXBsZXRlEkAuYmdzLnByb3RvY29sLmF1dGhlbnRpY2F0", "aW9uLnYyLmNsaWVudC5Mb2dvbkNvbXBsZXRlTm90aWZpY2F0aW9uGhkuYmdz", "LnByb3RvY29sLk5PX1JFU1BPTlNFIgaC+SsCCAESfAoST25Mb2dvblF1ZXVl", "VXBkYXRlEkMuYmdzLnByb3RvY29sLmF1dGhlbnRpY2F0aW9uLnYyLmNsaWVu", "dC5Mb2dvblF1ZXVlVXBkYXRlTm90aWZpY2F0aW9uGhkuYmdzLnByb3RvY29s", "Lk5PX1JFU1BPTlNFIgaC+SsCCAISSgoPT25Mb2dvblF1ZXVlRW5kEhQuYmdz", "LnByb3RvY29sLk5vRGF0YRoZLmJncy5wcm90b2NvbC5OT19SRVNQT05TRSIG", "gvkrAggDEn4KE09uRXh0ZXJuYWxDaGFsbGVuZ2USRC5iZ3MucHJvdG9jb2wu",
				"YXV0aGVudGljYXRpb24udjIuY2xpZW50LkV4dGVybmFsQ2hhbGxlbmdlTm90", "aWZpY2F0aW9uGhkuYmdzLnByb3RvY29sLk5PX1JFU1BPTlNFIgaC+SsCCAQa", "Q4L5Kz8KPWJuZXQucHJvdG9jb2wuYXV0aGVudGljYXRpb24udjIuY2xpZW50", "LkF1dGhlbnRpY2F0aW9uTGlzdGVuZXJCA4ABAA=="
			}));
			AuthenticationListenerReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				AuthenticationTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(LogonCompleteNotification), LogonCompleteNotification.Parser, new string[] { "ErrorCode", "Record" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(LogonQueueUpdateNotification), LogonQueueUpdateNotification.Parser, new string[] { "State" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ExternalChallengeNotification), ExternalChallengeNotification.Parser, new string[] { "RequestToken", "PayloadType", "Payload" }, null, null, null, null)
			}));
		}

		// Token: 0x04004213 RID: 16915
		private static FileDescriptor descriptor;
	}
}
