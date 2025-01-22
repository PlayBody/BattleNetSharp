using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000356 RID: 854
	public static class EntityTypesReflection
	{
		// Token: 0x17001CC0 RID: 7360
		// (get) Token: 0x060058AA RID: 22698 RVA: 0x00156F10 File Offset: 0x00155110
		public static FileDescriptor Descriptor
		{
			get
			{
				return EntityTypesReflection.descriptor;
			}
		}

		// Token: 0x060058AB RID: 22699 RVA: 0x00156F28 File Offset: 0x00155128
		static EntityTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "CiRiZ3MvbG93L3BiL2NsaWVudC9lbnRpdHlfdHlwZXMucHJvdG8SDGJncy5w", "cm90b2NvbBo3YmdzL2xvdy9wYi9jbGllbnQvZ2xvYmFsX2V4dGVuc2lvbnMv", "ZmllbGRfb3B0aW9ucy5wcm90byI1CghFbnRpdHlJZBIUCgRoaWdoGAEgAigG", "QgaC+SsCCAISEwoDbG93GAIgAigGQgaC+SsCCAIifwoISWRlbnRpdHkSNgoK", "YWNjb3VudF9pZBgBIAEoCzIWLmJncy5wcm90b2NvbC5FbnRpdHlJZEIKivkr", "BjoECAEQARI7Cg9nYW1lX2FjY291bnRfaWQYAiABKAsyFi5iZ3MucHJvdG9j", "b2wuRW50aXR5SWRCCor5KwY6BAgBEAJCHgoNYm5ldC5wcm90b2NvbEILRW50", "aXR5UHJvdG9IAQ==" }));
			EntityTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { FieldOptionsReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(EntityId), EntityId.Parser, new string[] { "High", "Low" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Identity), Identity.Parser, new string[] { "AccountId", "GameAccountId" }, null, null, null, null)
			}));
		}

		// Token: 0x04002874 RID: 10356
		private static FileDescriptor descriptor;
	}
}
