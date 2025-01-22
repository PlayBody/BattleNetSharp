using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x0200031E RID: 798
	public static class VoiceChatConnectReflection
	{
		// Token: 0x17001AE9 RID: 6889
		// (get) Token: 0x06005396 RID: 21398 RVA: 0x00142BB4 File Offset: 0x00140DB4
		public static FileDescriptor Descriptor
		{
			get
			{
				return VoiceChatConnectReflection.descriptor;
			}
		}

		// Token: 0x06005397 RID: 21399 RVA: 0x00142BCC File Offset: 0x00140DCC
		static VoiceChatConnectReflection()
		{
			byte[] array = Convert.FromBase64String("ChZWb2ljZUNoYXRDb25uZWN0LnByb3RvEiNCbGl6emFyZC5UZWxlbWV0cnku" + "RmVucmlzLkNsaWVudC52MSJaChBWb2ljZUNoYXRDb25uZWN0EhcKD2dhbWVf" + "YWNjb3VudF9pZBgBIAEoDRIXCg9ibmV0X2FjY291bnRfaWQYAiABKA0SFAoM" + "aXNfY29ubmVjdGVkGAMgASgI");
			VoiceChatConnectReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(VoiceChatConnect), VoiceChatConnect.Parser, new string[] { "GameAccountId", "BnetAccountId", "IsConnected" }, null, null, null, null)
			}));
		}

		// Token: 0x040025E6 RID: 9702
		private static FileDescriptor descriptor;
	}
}
