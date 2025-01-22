using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Challenge.V1
{
	// Token: 0x02000524 RID: 1316
	public static class ChallengeServiceReflection
	{
		// Token: 0x17002877 RID: 10359
		// (get) Token: 0x06007FCB RID: 32715 RVA: 0x001F1AD4 File Offset: 0x001EFCD4
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChallengeServiceReflection.descriptor;
			}
		}

		// Token: 0x06007FCC RID: 32716 RVA: 0x001F1AEC File Offset: 0x001EFCEC
		static ChallengeServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CiliZ3MvbG93L3BiL2NsaWVudC9jaGFsbGVuZ2Vfc2VydmljZS5wcm90bxIZ", "YmdzLnByb3RvY29sLmNoYWxsZW5nZS52MRohYmdzL2xvdy9wYi9jbGllbnQv", "cnBjX3R5cGVzLnByb3RvIlgKGENoYWxsZW5nZUV4dGVybmFsUmVxdWVzdBIV", "Cg1yZXF1ZXN0X3Rva2VuGAEgASgJEhQKDHBheWxvYWRfdHlwZRgCIAEoCRIP", "CgdwYXlsb2FkGAMgASgMIkYKF0NoYWxsZW5nZUV4dGVybmFsUmVzdWx0EhUK", "DXJlcXVlc3RfdG9rZW4YASABKAkSFAoGcGFzc2VkGAIgASgIOgR0cnVlMqsC", "ChFDaGFsbGVuZ2VMaXN0ZW5lchJtChNPbkV4dGVybmFsQ2hhbGxlbmdlEjMu", "YmdzLnByb3RvY29sLmNoYWxsZW5nZS52MS5DaGFsbGVuZ2VFeHRlcm5hbFJl", "cXVlc3QaGS5iZ3MucHJvdG9jb2wuTk9fUkVTUE9OU0UiBoL5KwIIAxJyChlP", "bkV4dGVybmFsQ2hhbGxlbmdlUmVzdWx0EjIuYmdzLnByb3RvY29sLmNoYWxs",
				"ZW5nZS52MS5DaGFsbGVuZ2VFeHRlcm5hbFJlc3VsdBoZLmJncy5wcm90b2Nv", "bC5OT19SRVNQT05TRSIGgvkrAggEGjOC+SspCidibmV0LnByb3RvY29sLmNo", "YWxsZW5nZS5DaGFsbGVuZ2VOb3RpZnmK+SsCCAFCBUgBgAEA"
			}));
			ChallengeServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { RpcTypesReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ChallengeExternalRequest), ChallengeExternalRequest.Parser, new string[] { "RequestToken", "PayloadType", "Payload" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ChallengeExternalResult), ChallengeExternalResult.Parser, new string[] { "RequestToken", "Passed" }, null, null, null, null)
			}));
		}

		// Token: 0x04003A0B RID: 14859
		private static FileDescriptor descriptor;
	}
}
