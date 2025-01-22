using System;
using Bgs.Protocol;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.Lobby
{
	// Token: 0x0200075C RID: 1884
	public static class LobbyReflection
	{
		// Token: 0x17003598 RID: 13720
		// (get) Token: 0x0600AD60 RID: 44384 RVA: 0x002A34C4 File Offset: 0x002A16C4
		public static FileDescriptor Descriptor
		{
			get
			{
				return LobbyReflection.descriptor;
			}
		}

		// Token: 0x0600AD61 RID: 44385 RVA: 0x002A34DC File Offset: 0x002A16DC
		static LobbyReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"Cg9iZ3MvbG9iYnkucHJvdG8SGWNsYXNzaWMucHJvdG9jb2wudjEubG9iYnka", "IWJncy9sb3cvcGIvY2xpZW50L3JwY190eXBlcy5wcm90byJ4CgxMb2JieVJl", "cXVlc3QSCwoDa2V5GAEgASgJEgsKA09TSRgDIAEoBRIPCgd2ZXJzaW9uGAQg", "ASgJEg8KB2Jhc2VLZXkYBSABKAkSEQoJdGhpcnR5MTAwGAYgASgFEgwKBFdu", "NjQYByABKAUSCwoDb25lGAggASgFIh0KDUxvYmJ5UmVzcG9uc2USDAoERGF0", "YRgDIAEoDDKHDwoFTG9iYnkSbAoLQ3JlYXRlTG9iYnkSJy5jbGFzc2ljLnBy", "b3RvY29sLnYxLmxvYmJ5LkxvYmJ5UmVxdWVzdBooLmNsYXNzaWMucHJvdG9j", "b2wudjEubG9iYnkuTG9iYnlSZXNwb25zZSIKgvkrBgityrajAxJyChFBY2Nl", "cHRMb2JieUludml0ZRInLmNsYXNzaWMucHJvdG9jb2wudjEubG9iYnkuTG9i", "YnlSZXF1ZXN0GiguY2xhc3NpYy5wcm90b2NvbC52MS5sb2JieS5Mb2JieVJl",
				"c3BvbnNlIgqC+SsGCNTj7/8GEnIKEVJlamVjdExvYmJ5SW52aXRlEicuY2xh", "c3NpYy5wcm90b2NvbC52MS5sb2JieS5Mb2JieVJlcXVlc3QaKC5jbGFzc2lj", "LnByb3RvY29sLnYxLmxvYmJ5LkxvYmJ5UmVzcG9uc2UiCoL5KwYIgfXY5QES", "bQoMRGlzYmFuZExvYmJ5EicuY2xhc3NpYy5wcm90b2NvbC52MS5sb2JieS5M", "b2JieVJlcXVlc3QaKC5jbGFzc2ljLnByb3RvY29sLnYxLmxvYmJ5LkxvYmJ5", "UmVzcG9uc2UiCoL5KwYIouPgogsSawoKTGVhdnlMb2JieRInLmNsYXNzaWMu", "cHJvdG9jb2wudjEubG9iYnkuTG9iYnlSZXF1ZXN0GiguY2xhc3NpYy5wcm90", "b2NvbC52MS5sb2JieS5Mb2JieVJlc3BvbnNlIgqC+SsGCLKJ1q0OEm4KDUtp", "Y2tGcm9tTG9iYnkSJy5jbGFzc2ljLnByb3RvY29sLnYxLmxvYmJ5LkxvYmJ5", "UmVxdWVzdBooLmNsYXNzaWMucHJvdG9jb2wudjEubG9iYnkuTG9iYnlSZXNw",
				"b25zZSIKgvkrBgi75Y+QBxJwCg9Qcm9tb3RlVG9MZWFkZXISJy5jbGFzc2lj", "LnByb3RvY29sLnYxLmxvYmJ5LkxvYmJ5UmVxdWVzdBooLmNsYXNzaWMucHJv", "dG9jb2wudjEubG9iYnkuTG9iYnlSZXNwb25zZSIKgvkrBgjfqpOWBxJuCg1J", "bnZpdGVUb0xvYmJ5EicuY2xhc3NpYy5wcm90b2NvbC52MS5sb2JieS5Mb2Ji", "eVJlcXVlc3QaKC5jbGFzc2ljLnByb3RvY29sLnYxLmxvYmJ5LkxvYmJ5UmVz", "cG9uc2UiCoL5KwYIt5Gs9AISagoJTmV3SW52aXRlEicuY2xhc3NpYy5wcm90", "b2NvbC52MS5sb2JieS5Mb2JieVJlcXVlc3QaKC5jbGFzc2ljLnByb3RvY29s", "LnYxLmxvYmJ5LkxvYmJ5UmVzcG9uc2UiCoL5KwYI3qGaygsSawoLTG9iYnlV", "cGRhdGUSJy5jbGFzc2ljLnByb3RvY29sLnYxLmxvYmJ5LkxvYmJ5UmVxdWVz", "dBooLmNsYXNzaWMucHJvdG9jb2wudjEubG9iYnkuTG9iYnlSZXNwb25zZSIJ",
				"gvkrBQj4xd0YEm8KDkxvYmJ5RGlzYmFuZGVkEicuY2xhc3NpYy5wcm90b2Nv", "bC52MS5sb2JieS5Mb2JieVJlcXVlc3QaKC5jbGFzc2ljLnByb3RvY29sLnYx", "LmxvYmJ5LkxvYmJ5UmVzcG9uc2UiCoL5KwYIi9+3xAkSbAoLTG9iYnlLaWNr", "ZWQSJy5jbGFzc2ljLnByb3RvY29sLnYxLmxvYmJ5LkxvYmJ5UmVxdWVzdBoo", "LmNsYXNzaWMucHJvdG9jb2wudjEubG9iYnkuTG9iYnlSZXNwb25zZSIKgvkr", "BgiAkfH4BRJxChBQcm9tb3RlZFRvTGVhZGVyEicuY2xhc3NpYy5wcm90b2Nv", "bC52MS5sb2JieS5Mb2JieVJlcXVlc3QaKC5jbGFzc2ljLnByb3RvY29sLnYx", "LmxvYmJ5LkxvYmJ5UmVzcG9uc2UiCoL5KwYIv6ia6gQSbQoMU2V0TG9iYnlN", "ZXRhEicuY2xhc3NpYy5wcm90b2NvbC52MS5sb2JieS5Mb2JieVJlcXVlc3Qa", "KC5jbGFzc2ljLnByb3RvY29sLnYxLmxvYmJ5LkxvYmJ5UmVzcG9uc2UiCoL5",
				"KwYIsLWvpwwSawoLU2V0U2VsZk1ldGESJy5jbGFzc2ljLnByb3RvY29sLnYx", "LmxvYmJ5LkxvYmJ5UmVxdWVzdBooLmNsYXNzaWMucHJvdG9jb2wudjEubG9i", "YnkuTG9iYnlSZXNwb25zZSIJgvkrBQiusoEPEm8KD1NlbmRDaGF0TWVzc2Fn", "ZRInLmNsYXNzaWMucHJvdG9jb2wudjEubG9iYnkuTG9iYnlSZXF1ZXN0Gigu", "Y2xhc3NpYy5wcm90b2NvbC52MS5sb2JieS5Mb2JieVJlc3BvbnNlIgmC+SsF", "CIz4zEsScAoPQ2hhdE1lc3NhZ2VSZWN2EicuY2xhc3NpYy5wcm90b2NvbC52", "MS5sb2JieS5Mb2JieVJlcXVlc3QaKC5jbGFzc2ljLnByb3RvY29sLnYxLmxv", "YmJ5LkxvYmJ5UmVzcG9uc2UiCoL5KwYI0uCP1gkaEIL5KwwKCjB4N0FGMUFG", "QkY="
			}));
			LobbyReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { RpcTypesReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(LobbyRequest), LobbyRequest.Parser, new string[] { "Key", "OSI", "Version", "BaseKey", "Thirty100", "Wn64", "One" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(LobbyResponse), LobbyResponse.Parser, new string[] { "Data" }, null, null, null, null)
			}));
		}

		// Token: 0x04004E18 RID: 19992
		private static FileDescriptor descriptor;
	}
}
