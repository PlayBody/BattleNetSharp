using System;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200000F RID: 15
	public static class InternalReflection
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00004C48 File Offset: 0x00002E48
		public static FileDescriptor Descriptor
		{
			get
			{
				return InternalReflection.descriptor;
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00004C60 File Offset: 0x00002E60
		static InternalReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "Cg5JbnRlcm5hbC5wcm90bxIOVG9vbENoYW5uZWxNc2ciVwoJSGFuZHNoYWtl", "Ej4KCHBsYXRmb3JtGAEgAigOMhguVG9vbENoYW5uZWxNc2cuUGxhdGZvcm06", "ElBMQVRGT1JNX1BDX0NMSUVOVBIKCgJpZBgCIAEoDSIqCg5OZXdNZXNzYWdl", "VHlwZRIMCgRuYW1lGAEgAigJEgoKAmlkGAIgAigNKuoBCghQbGF0Zm9ybRIW", "ChJQTEFURk9STV9QQ19DTElFTlQQABIXChNQTEFURk9STV9NQUNfQ0xJRU5U", "EAESFQoRUExBVEZPUk1fRU1CRURERUQQAhIQCgxQTEFURk9STV9QUzQQAxIV", "ChFQTEFURk9STV9YQk9YX09ORRAEEhYKElBMQVRGT1JNX1BDX1NFUlZFUhAF", "EhkKFVBMQVRGT1JNX0xJTlVYX1NFUlZFUhAGEhAKDFBMQVRGT1JNX1BTNRAH", "EhUKEVBMQVRGT1JNX1NDQVJMRVRUEAgSEQoNUExBVEZPUk1fTlg2NBAJ" }));
			InternalReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[] { typeof(Platform) }, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(Handshake), Handshake.Parser, new string[] { "Platform", "Id" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(NewMessageType), NewMessageType.Parser, new string[] { "Name", "Id" }, null, null, null, null)
			}));
		}

		// Token: 0x04000056 RID: 86
		private static FileDescriptor descriptor;
	}
}
