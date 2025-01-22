using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000383 RID: 899
	public static class MessageTypesReflection
	{
		// Token: 0x17001DA6 RID: 7590
		// (get) Token: 0x06005B89 RID: 23433 RVA: 0x001620E8 File Offset: 0x001602E8
		public static FileDescriptor Descriptor
		{
			get
			{
				return MessageTypesReflection.descriptor;
			}
		}

		// Token: 0x06005B8A RID: 23434 RVA: 0x00162100 File Offset: 0x00160300
		static MessageTypesReflection()
		{
			byte[] array = Convert.FromBase64String("CiViZ3MvbG93L3BiL2NsaWVudC9tZXNzYWdlX3R5cGVzLnByb3RvEgxiZ3Mu" + "cHJvdG9jb2wiLAoJTWVzc2FnZUlkEg0KBWVwb2NoGAEgASgEEhAKCHBvc2l0" + "aW9uGAIgASgEKjQKD1R5cGluZ0luZGljYXRvchIQCgxUWVBJTkdfU1RBUlQQ" + "ABIPCgtUWVBJTkdfU1RPUBAB");
			MessageTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[] { typeof(TypingIndicator) }, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MessageId), MessageId.Parser, new string[] { "Epoch", "Position" }, null, null, null, null)
			}));
		}

		// Token: 0x040029C4 RID: 10692
		private static FileDescriptor descriptor;
	}
}
