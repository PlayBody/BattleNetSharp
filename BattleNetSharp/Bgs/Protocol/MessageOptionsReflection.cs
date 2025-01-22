using System;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x0200036B RID: 875
	public static class MessageOptionsReflection
	{
		// Token: 0x17001D2F RID: 7471
		// (get) Token: 0x06005A1F RID: 23071 RVA: 0x0015CC94 File Offset: 0x0015AE94
		public static FileDescriptor Descriptor
		{
			get
			{
				return MessageOptionsReflection.descriptor;
			}
		}

		// Token: 0x06005A20 RID: 23072 RVA: 0x0015CCAC File Offset: 0x0015AEAC
		static MessageOptionsReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "CjliZ3MvbG93L3BiL2NsaWVudC9nbG9iYWxfZXh0ZW5zaW9ucy9tZXNzYWdl", "X29wdGlvbnMucHJvdG8SDGJncy5wcm90b2NvbBogZ29vZ2xlL3Byb3RvYnVm", "L2Rlc2NyaXB0b3IucHJvdG8iSgoRQkdTTWVzc2FnZU9wdGlvbnMSGwoTY3Vz", "dG9tX3NlbGVjdF9zaGFyZBgBIAEoCBIYChBjdXN0b21fdmFsaWRhdG9yGAIg", "ASgIOlsKD21lc3NhZ2Vfb3B0aW9ucxIfLmdvb2dsZS5wcm90b2J1Zi5NZXNz", "YWdlT3B0aW9ucxiQvwUgASgLMh8uYmdzLnByb3RvY29sLkJHU01lc3NhZ2VP", "cHRpb25zQiUKDGJncy5wcm90b2NvbEITTWVzc2FnZU9wdGlvbnNQcm90b0gB" }));
			MessageOptionsReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { DescriptorReflection.Descriptor }, new GeneratedClrTypeInfo(null, new Extension[] { MessageOptionsExtensions.MessageOptions_ }, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(BGSMessageOptions), BGSMessageOptions.Parser, new string[] { "CustomSelectShard", "CustomValidator" }, null, null, null, null)
			}));
		}

		// Token: 0x04002909 RID: 10505
		private static FileDescriptor descriptor;
	}
}
