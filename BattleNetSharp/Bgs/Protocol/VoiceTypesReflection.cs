using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000395 RID: 917
	public static class VoiceTypesReflection
	{
		// Token: 0x17001E46 RID: 7750
		// (get) Token: 0x06005D4C RID: 23884 RVA: 0x00169144 File Offset: 0x00167344
		public static FileDescriptor Descriptor
		{
			get
			{
				return VoiceTypesReflection.descriptor;
			}
		}

		// Token: 0x06005D4D RID: 23885 RVA: 0x0016915C File Offset: 0x0016735C
		static VoiceTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CiNiZ3MvbG93L3BiL2NsaWVudC92b2ljZV90eXBlcy5wcm90bxIMYmdzLnBy", "b3RvY29sIs8BChBWb2ljZUNyZWRlbnRpYWxzEhAKCHZvaWNlX2lkGAEgASgJ", "Eg0KBXRva2VuGAIgASgJEgsKA3VybBgDIAEoCRJBCglqb2luX3R5cGUYBCAB", "KA4yGy5iZ3MucHJvdG9jb2wuVm9pY2VKb2luVHlwZToRVk9JQ0VfSk9JTl9O", "T1JNQUwSSgoLbXV0ZV9yZWFzb24YBSABKA4yHS5iZ3MucHJvdG9jb2wuVm9p", "Y2VNdXRlUmVhc29uOhZWT0lDRV9NVVRFX1JFQVNPTl9OT05FKjwKDVZvaWNl", "Sm9pblR5cGUSFQoRVk9JQ0VfSk9JTl9OT1JNQUwQABIUChBWT0lDRV9KT0lO", "X01VVEVEEAEqowEKD1ZvaWNlTXV0ZVJlYXNvbhIaChZWT0lDRV9NVVRFX1JF", "QVNPTl9OT05FEAASMgouVk9JQ0VfTVVURV9SRUFTT05fUEFSRU5UQUxfQ09O", "VFJPTF9MSVNURU5fT05MWRABEh8KG1ZPSUNFX01VVEVfUkVBU09OX1JFUVVF",
				"U1RFRBACEh8KG1ZPSUNFX01VVEVfUkVBU09OX1NRVUVMQ0hFRBADKkQKFFZv", "aWNlUHJvdmlkZXJWZXJzaW9uEhUKEVZPSUNFX1BST1ZJREVSX1Y0EAASFQoR", "Vk9JQ0VfUFJPVklERVJfVjUQAQ=="
			}));
			VoiceTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[]
			{
				typeof(VoiceJoinType),
				typeof(VoiceMuteReason),
				typeof(VoiceProviderVersion)
			}, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(VoiceCredentials), VoiceCredentials.Parser, new string[] { "VoiceId", "Token", "Url", "JoinType", "MuteReason" }, null, null, null, null)
			}));
		}

		// Token: 0x04002AB3 RID: 10931
		private static FileDescriptor descriptor;
	}
}
