using System;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006F6 RID: 1782
	public static class ChatTypesReflection
	{
		// Token: 0x170032CC RID: 13004
		// (get) Token: 0x0600A42C RID: 42028 RVA: 0x0028022C File Offset: 0x0027E42C
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChatTypesReflection.descriptor;
			}
		}

		// Token: 0x0600A42D RID: 42029 RVA: 0x00280244 File Offset: 0x0027E444
		static ChatTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "CiJiZ3MvbG93L3BiL2NsaWVudC9jaGF0X3R5cGVzLnByb3RvEhdiZ3MucHJv", "dG9jb2wuY2hhbm5lbC52MRolYmdzL2xvdy9wYi9jbGllbnQvY2hhbm5lbF90", "eXBlcy5wcm90byLKAQoQQ2hhdENoYW5uZWxTdGF0ZRIQCghpZGVudGl0eRgB", "IAEoCRIOCgZsb2NhbGUYAyABKAcSFQoGcHVibGljGAQgASgIOgVmYWxzZRIU", "CgxidWNrZXRfaW5kZXgYBSABKA0yZwoNY2hhbm5lbF9zdGF0ZRIlLmJncy5w", "cm90b2NvbC5jaGFubmVsLnYxLkNoYW5uZWxTdGF0ZRhkIAEoCzIpLmJncy5w", "cm90b2NvbC5jaGFubmVsLnYxLkNoYXRDaGFubmVsU3RhdGVCAkgB" }));
			ChatTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { ChannelTypesReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ChatChannelState), ChatChannelState.Parser, new string[] { "Identity", "Locale", "Public", "BucketIndex" }, null, null, new Extension[] { ChatChannelState.Extensions.ChannelState_ }, null)
			}));
		}

		// Token: 0x040049FB RID: 18939
		private static FileDescriptor descriptor;
	}
}
