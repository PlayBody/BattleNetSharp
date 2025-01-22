using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.UserManager.V1
{
	// Token: 0x020003C0 RID: 960
	public static class UserManagerTypesReflection
	{
		// Token: 0x17001F0D RID: 7949
		// (get) Token: 0x06006036 RID: 24630 RVA: 0x00174EF0 File Offset: 0x001730F0
		public static FileDescriptor Descriptor
		{
			get
			{
				return UserManagerTypesReflection.descriptor;
			}
		}

		// Token: 0x06006037 RID: 24631 RVA: 0x00174F08 File Offset: 0x00173108
		static UserManagerTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CipiZ3MvbG93L3BiL2NsaWVudC91c2VyX21hbmFnZXJfdHlwZXMucHJvdG8S", "HGJncy5wcm90b2NvbC51c2VyX21hbmFnZXIudjEaJGJncy9sb3cvcGIvY2xp", "ZW50L2VudGl0eV90eXBlcy5wcm90bxonYmdzL2xvdy9wYi9jbGllbnQvYXR0", "cmlidXRlX3R5cGVzLnByb3RvIrQBCgxSZWNlbnRQbGF5ZXISKQoJZW50aXR5", "X2lkGAEgAigLMhYuYmdzLnByb3RvY29sLkVudGl0eUlkEg8KB3Byb2dyYW0Y", "AiABKAkSGAoQdGltZXN0YW1wX3BsYXllZBgDIAEoBhIrCgphdHRyaWJ1dGVz", "GAQgAygLMhcuYmdzLnByb3RvY29sLkF0dHJpYnV0ZRINCgJpZBgFIAEoBzoB", "MBISCgdjb3VudGVyGAYgASgHOgEwInIKDUJsb2NrZWRQbGF5ZXISKgoKYWNj", "b3VudF9pZBgBIAIoCzIWLmJncy5wcm90b2NvbC5FbnRpdHlJZBIMCgRuYW1l", "GAIgASgJEhAKBHJvbGUYAyADKA1CAhABEhUKCnByaXZpbGVnZXMYBCABKAQ6",
				"ATBCAkgB"
			}));
			UserManagerTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				EntityTypesReflection.Descriptor,
				AttributeTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(RecentPlayer), RecentPlayer.Parser, new string[] { "EntityId", "Program", "TimestampPlayed", "Attributes", "Id", "Counter" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(BlockedPlayer), BlockedPlayer.Parser, new string[] { "AccountId", "Name", "Role", "Privileges" }, null, null, null, null)
			}));
		}

		// Token: 0x04002BFE RID: 11262
		private static FileDescriptor descriptor;
	}
}
