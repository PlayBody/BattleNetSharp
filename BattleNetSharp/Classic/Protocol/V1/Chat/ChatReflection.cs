using System;
using Bgs.Protocol;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.Chat
{
	// Token: 0x02000779 RID: 1913
	public static class ChatReflection
	{
		// Token: 0x17003664 RID: 13924
		// (get) Token: 0x0600AFEB RID: 45035 RVA: 0x002AD1D4 File Offset: 0x002AB3D4
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChatReflection.descriptor;
			}
		}

		// Token: 0x0600AFEC RID: 45036 RVA: 0x002AD1EC File Offset: 0x002AB3EC
		static ChatReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"Cg5iZ3MvY2hhdC5wcm90bxIYY2xhc3NpYy5wcm90b2NvbC52MS5jaGF0GiFi", "Z3MvbG93L3BiL2NsaWVudC9ycGNfdHlwZXMucHJvdG8idwoLQ2hhdFJlcXVl", "c3QSCwoDa2V5GAEgASgJEgsKA09TSRgDIAEoBRIPCgd2ZXJzaW9uGAQgASgJ", "Eg8KB2Jhc2VLZXkYBSABKAkSEQoJdGhpcnR5MTAwGAYgASgFEgwKBFduNjQY", "ByABKAUSCwoDb25lGAggASgFIhwKDENoYXRSZXNwb25zZRIMCgREYXRhGAMg", "ASgMMvIBCgRDaGF0EmsKDkNoYW5uZWxNZXNzYWdlEiUuY2xhc3NpYy5wcm90", "b2NvbC52MS5jaGF0LkNoYXRSZXF1ZXN0GiYuY2xhc3NpYy5wcm90b2NvbC52", "MS5jaGF0LkNoYXRSZXNwb25zZSIKgvkrBgj88Iy+ChJrCg5XaGlzcGVyTWVz", "c2FnZRIlLmNsYXNzaWMucHJvdG9jb2wudjEuY2hhdC5DaGF0UmVxdWVzdBom", "LmNsYXNzaWMucHJvdG9jb2wudjEuY2hhdC5DaGF0UmVzcG9uc2UiCoL5KwYI",
				"/fDSoAQaEIL5KwwKCjB4QkYwQkY2QkM="
			}));
			ChatReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { RpcTypesReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ChatRequest), ChatRequest.Parser, new string[] { "Key", "OSI", "Version", "BaseKey", "Thirty100", "Wn64", "One" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ChatResponse), ChatResponse.Parser, new string[] { "Data" }, null, null, null, null)
			}));
		}

		// Token: 0x04004F54 RID: 20308
		private static FileDescriptor descriptor;
	}
}
