using System;
using Bgs.Protocol.Account.V1;
using Bgs.Protocol.V2;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Report.V2
{
	// Token: 0x02000584 RID: 1412
	public static class ReportTypesReflection
	{
		// Token: 0x17002AB5 RID: 10933
		// (get) Token: 0x06008790 RID: 34704 RVA: 0x0020EFB4 File Offset: 0x0020D1B4
		public static FileDescriptor Descriptor
		{
			get
			{
				return ReportTypesReflection.descriptor;
			}
		}

		// Token: 0x06008791 RID: 34705 RVA: 0x0020EFCC File Offset: 0x0020D1CC
		static ReportTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjJiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL3JlcG9ydF90eXBl", "cy5wcm90bxIWYmdzLnByb3RvY29sLnJlcG9ydC52Mho1YmdzL2xvdy9wYi9j", "bGllbnQvYXBpL2NsaWVudC92Mi9hdHRyaWJ1dGVfdHlwZXMucHJvdG8aJWJn", "cy9sb3cvcGIvY2xpZW50L2FjY291bnRfdHlwZXMucHJvdG8aJWJncy9sb3cv", "cGIvY2xpZW50L21lc3NhZ2VfdHlwZXMucHJvdG8iQwoKUmVwb3J0SXRlbRIt", "CgptZXNzYWdlX2lkGAEgASgLMhcuYmdzLnByb3RvY29sLk1lc3NhZ2VJZEgA", "QgYKBHR5cGUi2wEKC1VzZXJPcHRpb25zEjUKCXRhcmdldF9pZBgBIAEoCzIi", "LmJncy5wcm90b2NvbC5hY2NvdW50LnYxLkFjY291bnRJZBIvCgR0eXBlGAIg", "ASgOMiEuYmdzLnByb3RvY29sLnJlcG9ydC52Mi5Jc3N1ZVR5cGUSMgoGc291", "cmNlGAMgASgOMiIuYmdzLnByb3RvY29sLnJlcG9ydC52Mi5Vc2VyU291cmNl",
				"EjAKBGl0ZW0YBCABKAsyIi5iZ3MucHJvdG9jb2wucmVwb3J0LnYyLlJlcG9y", "dEl0ZW0iyAEKC0NsdWJPcHRpb25zEg8KB2NsdWJfaWQYASABKAQSEQoJc3Ry", "ZWFtX2lkGAIgASgEEi8KBHR5cGUYAyABKA4yIS5iZ3MucHJvdG9jb2wucmVw", "b3J0LnYyLklzc3VlVHlwZRIyCgZzb3VyY2UYBCABKA4yIi5iZ3MucHJvdG9j", "b2wucmVwb3J0LnYyLkNsdWJTb3VyY2USMAoEaXRlbRgFIAEoCzIiLmJncy5w", "cm90b2NvbC5yZXBvcnQudjIuUmVwb3J0SXRlbSJmCg1FbnRpdHlPcHRpb25z", "EhEKCWVudGl0eV9pZBgBIAEoCRITCgtlbnRpdHlfdHlwZRgCIAEoCRItCglh", "dHRyaWJ1dGUYBSADKAsyGi5iZ3MucHJvdG9jb2wudjIuQXR0cmlidXRlKo0B", "CglJc3N1ZVR5cGUSEwoPSVNTVUVfVFlQRV9TUEFNEAASGQoVSVNTVUVfVFlQ", "RV9IQVJBU1NNRU5UEAESIAocSVNTVUVfVFlQRV9PRkZFTlNJVkVfQ09OVEVO",
				"VBADEhYKEklTU1VFX1RZUEVfSEFDS0lORxAEEhYKEklTU1VFX1RZUEVfQk9U", "VElORxAFKsEBCgpVc2VyU291cmNlEhUKEVVTRVJfU09VUkNFX09USEVSEAAS", "FwoTVVNFUl9TT1VSQ0VfV0hJU1BFUhABEhcKE1VTRVJfU09VUkNFX1BST0ZJ", "TEUQAhIaChZVU0VSX1NPVVJDRV9CQVRUTEVfVEFHEAMSFAoQVVNFUl9TT1VS", "Q0VfQ0hBVBAEEiEKHVVTRVJfU09VUkNFX0ZSSUVORF9JTlZJVEFUSU9OEAUS", "FQoRVVNFUl9TT1VSQ0VfVk9JQ0UQBirxAQoKQ2x1YlNvdXJjZRIUChBDTFVC", "X1NPVVJDRV9OT05FEAASFwoTQ0xVQl9TT1VSQ0VfTUVTU0FHRRABEhkKFUNM", "VUJfU09VUkNFX0NMVUJfTkFNRRACEhsKF0NMVUJfU09VUkNFX1NUUkVBTV9O", "QU1FEAMSGQoVQ0xVQl9TT1VSQ0VfQlJPQURDQVNUEAQSHwobQ0xVQl9TT1VS", "Q0VfQ0xVQl9TSE9SVF9OQU1FEAUSIAocQ0xVQl9TT1VSQ0VfQ0xVQl9ERVND",
				"UklQVElPThAGEh4KGkNMVUJfU09VUkNFX1NUUkVBTV9TVUJKRUNUEAdCA4AB", "AA=="
			}));
			ReportTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				AttributeTypesReflection.Descriptor,
				AccountTypesReflection.Descriptor,
				MessageTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(new Type[]
			{
				typeof(IssueType),
				typeof(UserSource),
				typeof(ClubSource)
			}, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ReportItem), ReportItem.Parser, new string[] { "MessageId" }, new string[] { "Type" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(UserOptions), UserOptions.Parser, new string[] { "TargetId", "Type", "Source", "Item" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClubOptions), ClubOptions.Parser, new string[] { "ClubId", "StreamId", "Type", "Source", "Item" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(EntityOptions), EntityOptions.Parser, new string[] { "EntityId", "EntityType", "Attribute" }, null, null, null, null)
			}));
		}

		// Token: 0x04003D5D RID: 15709
		private static FileDescriptor descriptor;
	}
}
