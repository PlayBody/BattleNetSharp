using System;
using Bgs.Protocol;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.Warden
{
	// Token: 0x02000754 RID: 1876
	public static class WardenReflection
	{
		// Token: 0x17003568 RID: 13672
		// (get) Token: 0x0600ACCC RID: 44236 RVA: 0x002A11E8 File Offset: 0x0029F3E8
		public static FileDescriptor Descriptor
		{
			get
			{
				return WardenReflection.descriptor;
			}
		}

		// Token: 0x0600ACCD RID: 44237 RVA: 0x002A1200 File Offset: 0x0029F400
		static WardenReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChBiZ3Mvd2FyZGVuLnByb3RvEhpjbGFzc2ljLnByb3RvY29sLnYxLndhcmRl", "bhohYmdzL2xvdy9wYi9jbGllbnQvcnBjX3R5cGVzLnByb3RvInkKDVdhcmRl", "blJlcXVlc3QSCwoDa2V5GAEgASgJEgsKA09TSRgDIAEoBRIPCgd2ZXJzaW9u", "GAQgASgJEg8KB2Jhc2VLZXkYBSABKAkSEQoJdGhpcnR5MTAwGAYgASgFEgwK", "BFduNjQYByABKAUSCwoDb25lGAggASgFIh4KDldhcmRlblJlc3BvbnNlEgwK", "BERhdGEYAyABKAwy+AIKB1dhcmRlbjMSaQoESW5pdBIpLmNsYXNzaWMucHJv", "dG9jb2wudjEud2FyZGVuLldhcmRlblJlcXVlc3QaKi5jbGFzc2ljLnByb3Rv", "Y29sLnYxLndhcmRlbi5XYXJkZW5SZXNwb25zZSIKgvkrBgjuwPukBRJ3ChJT", "ZW5kUGFja2V0VG9TZXJ2ZXISKS5jbGFzc2ljLnByb3RvY29sLnYxLndhcmRl", "bi5XYXJkZW5SZXF1ZXN0GiouY2xhc3NpYy5wcm90b2NvbC52MS53YXJkZW4u",
				"V2FyZGVuUmVzcG9uc2UiCoL5KwYIuqSXgQ0SdwoSU2VuZFBhY2tldFRvQ2xp", "ZW50EikuY2xhc3NpYy5wcm90b2NvbC52MS53YXJkZW4uV2FyZGVuUmVxdWVz", "dBoqLmNsYXNzaWMucHJvdG9jb2wudjEud2FyZGVuLldhcmRlblJlc3BvbnNl", "IgqC+SsGCKKWqJ4NGhCC+SsMCgoweENBQzdFRjRD"
			}));
			WardenReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { RpcTypesReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(WardenRequest), WardenRequest.Parser, new string[] { "Key", "OSI", "Version", "BaseKey", "Thirty100", "Wn64", "One" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(WardenResponse), WardenResponse.Parser, new string[] { "Data" }, null, null, null, null)
			}));
		}

		// Token: 0x04004DD0 RID: 19920
		private static FileDescriptor descriptor;
	}
}
