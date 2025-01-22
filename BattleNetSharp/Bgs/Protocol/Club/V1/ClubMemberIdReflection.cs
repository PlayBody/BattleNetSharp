using System;
using Bgs.Protocol.Account.V1;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000475 RID: 1141
	public static class ClubMemberIdReflection
	{
		// Token: 0x170023A5 RID: 9125
		// (get) Token: 0x06006F74 RID: 28532 RVA: 0x001B1578 File Offset: 0x001AF778
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClubMemberIdReflection.descriptor;
			}
		}

		// Token: 0x06006F75 RID: 28533 RVA: 0x001B1590 File Offset: 0x001AF790
		static ClubMemberIdReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "CiZiZ3MvbG93L3BiL2NsaWVudC9jbHViX21lbWJlcl9pZC5wcm90bxIUYmdz", "LnByb3RvY29sLmNsdWIudjEaJWJncy9sb3cvcGIvY2xpZW50L2FjY291bnRf", "dHlwZXMucHJvdG8aIWJncy9sb3cvcGIvY2xpZW50L3JwY190eXBlcy5wcm90", "byJVCghNZW1iZXJJZBI2CgphY2NvdW50X2lkGAEgASgLMiIuYmdzLnByb3Rv", "Y29sLmFjY291bnQudjEuQWNjb3VudElkEhEKCXVuaXF1ZV9pZBgCIAEoBA==" }));
			ClubMemberIdReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				AccountTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MemberId), MemberId.Parser, new string[] { "AccountId", "UniqueId" }, null, null, null, null)
			}));
		}

		// Token: 0x0400331E RID: 13086
		private static FileDescriptor descriptor;
	}
}
