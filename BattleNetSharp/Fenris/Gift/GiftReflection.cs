using System;
using Google.Protobuf.Reflection;

namespace Fenris.Gift
{
	// Token: 0x020001B7 RID: 439
	public static class GiftReflection
	{
		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x06002E3D RID: 11837 RVA: 0x000B4A68 File Offset: 0x000B2C68
		public static FileDescriptor Descriptor
		{
			get
			{
				return GiftReflection.descriptor;
			}
		}

		// Token: 0x06002E3E RID: 11838 RVA: 0x000B4A80 File Offset: 0x000B2C80
		static GiftReflection()
		{
			byte[] array = Convert.FromBase64String("CgpHaWZ0LnByb3RvEgtGZW5yaXMuR2lmdCJWCghHaWZ0SW5mbxISCgphY2Nv" + "dW50X2lkGAEgASgEEg8KB2dpZnRfaWQYAiABKAkSEAoIY2xhaW1faWQYAyAB" + "KAkSEwoLY2xhaW1fc3RhdGUYBCABKA0=");
			GiftReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(GiftInfo), GiftInfo.Parser, new string[] { "AccountId", "GiftId", "ClaimId", "ClaimState" }, null, null, null, null)
			}));
		}

		// Token: 0x040014DD RID: 5341
		private static FileDescriptor descriptor;
	}
}
