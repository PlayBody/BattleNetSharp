using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000505 RID: 1285
	public static class ClubTagReflection
	{
		// Token: 0x170027F3 RID: 10227
		// (get) Token: 0x06007DCC RID: 32204 RVA: 0x001E9EF8 File Offset: 0x001E80F8
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClubTagReflection.descriptor;
			}
		}

		// Token: 0x06007DCD RID: 32205 RVA: 0x001E9F10 File Offset: 0x001E8110
		static ClubTagReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CiBiZ3MvbG93L3BiL2NsaWVudC9jbHViX3RhZy5wcm90bxIUYmdzLnByb3Rv", "Y29sLmNsdWIudjEaIWJncy9sb3cvcGIvY2xpZW50L3JwY190eXBlcy5wcm90", "byJOCgpUYWdPcHRpb25zEg4KBmFjdGlvbhgBIAEoDRIwCgN0YWcYAiADKAsy", "Iy5iZ3MucHJvdG9jb2wuY2x1Yi52MS5UYWdJZGVudGlmaWVyIikKDVRhZ0lk", "ZW50aWZpZXISCgoCaWQYASABKA0SDAoEdHlwZRgCIAEoDSJmCgxMb2NhbGl6", "ZWRUYWcSMwoGdGFnX2lkGAEgASgLMiMuYmdzLnByb3RvY29sLmNsdWIudjEu", "VGFnSWRlbnRpZmllchIMCgRuYW1lGAIgASgJEhMKC2Rlc2NyaXB0aW9uGAMg", "ASgJKkoKCVRhZ0FjdGlvbhITCg9UQUdfQUNUSU9OX05PTkUQABIUChBUQUdf", "QUNUSU9OX0NMRUFSEAESEgoOVEFHX0FDVElPTl9TRVQQAipLCgdUYWdUeXBl", "EhQKEFRBR19UWVBFX0lOVkFMSUQQABIVChFUQUdfVFlQRV9QTEFURk9STRAB",
				"EhMKD1RBR19UWVBFX0NVU1RPTRAC"
			}));
			ClubTagReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { RpcTypesReflection.Descriptor }, new GeneratedClrTypeInfo(new Type[]
			{
				typeof(TagAction),
				typeof(TagType)
			}, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(TagOptions), TagOptions.Parser, new string[] { "Action", "Tag" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(TagIdentifier), TagIdentifier.Parser, new string[] { "Id", "Type" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(LocalizedTag), LocalizedTag.Parser, new string[] { "TagId", "Name", "Description" }, null, null, null, null)
			}));
		}

		// Token: 0x0400393A RID: 14650
		private static FileDescriptor descriptor;
	}
}
