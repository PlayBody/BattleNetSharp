using System;
using Bgs.Protocol.V2;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000438 RID: 1080
	public static class ClubBanReflection
	{
		// Token: 0x170021DE RID: 8670
		// (get) Token: 0x06006A12 RID: 27154 RVA: 0x0019A7D8 File Offset: 0x001989D8
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClubBanReflection.descriptor;
			}
		}

		// Token: 0x06006A13 RID: 27155 RVA: 0x0019A7F0 File Offset: 0x001989F0
		static ClubBanReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CiBiZ3MvbG93L3BiL2NsaWVudC9jbHViX2Jhbi5wcm90bxIUYmdzLnByb3Rv", "Y29sLmNsdWIudjEaI2Jncy9sb3cvcGIvY2xpZW50L2NsdWJfbWVtYmVyLnBy", "b3RvGjViZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL2F0dHJpYnV0", "ZV90eXBlcy5wcm90byKBAQoNQWRkQmFuT3B0aW9ucxIxCgl0YXJnZXRfaWQY", "ASABKAsyHi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5NZW1iZXJJZBItCglhdHRy", "aWJ1dGUYAiADKAsyGi5iZ3MucHJvdG9jb2wudjIuQXR0cmlidXRlEg4KBnJl", "YXNvbhgDIAEoCSLZAQoHQ2x1YkJhbhIqCgJpZBgBIAEoCzIeLmJncy5wcm90", "b2NvbC5jbHViLnYxLk1lbWJlcklkEhIKCmJhdHRsZV90YWcYAiABKAkSOAoH", "Y3JlYXRvchgDIAEoCzInLmJncy5wcm90b2NvbC5jbHViLnYxLk1lbWJlckRl", "c2NyaXB0aW9uEi0KCWF0dHJpYnV0ZRgEIAMoCzIaLmJncy5wcm90b2NvbC52",
				"Mi5BdHRyaWJ1dGUSDgoGcmVhc29uGAUgASgJEhUKDWNyZWF0aW9uX3RpbWUY", "BiABKAQ="
			}));
			ClubBanReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				ClubMemberReflection.Descriptor,
				AttributeTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(AddBanOptions), AddBanOptions.Parser, new string[] { "TargetId", "Attribute", "Reason" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClubBan), ClubBan.Parser, new string[] { "Id", "BattleTag", "Creator", "Attribute", "Reason", "CreationTime" }, null, null, null, null)
			}));
		}

		// Token: 0x0400304D RID: 12365
		private static FileDescriptor descriptor;
	}
}
