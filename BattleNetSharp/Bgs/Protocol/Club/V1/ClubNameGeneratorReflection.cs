using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000477 RID: 1143
	public static class ClubNameGeneratorReflection
	{
		// Token: 0x170023AC RID: 9132
		// (get) Token: 0x06006F8D RID: 28557 RVA: 0x001B1AEC File Offset: 0x001AFCEC
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClubNameGeneratorReflection.descriptor;
			}
		}

		// Token: 0x06006F8E RID: 28558 RVA: 0x001B1B04 File Offset: 0x001AFD04
		static ClubNameGeneratorReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CitiZ3MvbG93L3BiL2NsaWVudC9jbHViX25hbWVfZ2VuZXJhdG9yLnByb3Rv", "EhRiZ3MucHJvdG9jb2wuY2x1Yi52MRohYmdzL2xvdy9wYi9jbGllbnQvY2x1", "Yl90eXBlLnByb3RvIuYBChNOYW1lR2VuZXJhdG9yQ29uZmlnEjwKD25hbWVf", "Z2VuZXJhdG9ycxgBIAMoCzIjLmJncy5wcm90b2NvbC5jbHViLnYxLk5hbWVH", "ZW5lcmF0b3ISSQoTY2x1Yl90eXBlX3Njb3JlY2FyZBgCIAEoCzIsLmJncy5w", "cm90b2NvbC5jbHViLnYxLk5hbWVHZW5lcmF0b3JTY29yZWNhcmQSRgoQbG9j", "YWxlX3Njb3JlY2FyZBgDIAEoCzIsLmJncy5wcm90b2NvbC5jbHViLnYxLk5h", "bWVHZW5lcmF0b3JTY29yZWNhcmQiiQEKFk5hbWVHZW5lcmF0b3JTY29yZWNh", "cmQSEwoLaXNfcmVxdWlyZWQYASABKAgSEgoKZnVsbF9tYXRjaBgCIAEoDRIV", "Cg1wYXJ0aWFsX21hdGNoGAMgASgNEhgKEHBhcnRpYWxfZmFsbGJhY2sYBCAB",
				"KA0SFQoNZnVsbF9mYWxsYmFjaxgFIAEoDSKvAQoNTmFtZUdlbmVyYXRvchIN", "CgVuYW1lcxgBIAMoCRJECgxyZXBsYWNlbWVudHMYAiADKAsyLi5iZ3MucHJv", "dG9jb2wuY2x1Yi52MS5OYW1lR2VuZXJhdG9yUmVwbGFjZW1lbnQSOAoKY2x1", "Yl90eXBlcxgDIAMoCzIkLmJncy5wcm90b2NvbC5jbHViLnYxLlVuaXF1ZUNs", "dWJUeXBlEg8KB2xvY2FsZXMYBCADKAkiNwoYTmFtZUdlbmVyYXRvclJlcGxh", "Y2VtZW50EgoKAmlkGAEgASgJEg8KB29wdGlvbnMYAiADKAlQAA=="
			}));
			ClubNameGeneratorReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { ClubTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(NameGeneratorConfig), NameGeneratorConfig.Parser, new string[] { "NameGenerators", "ClubTypeScorecard", "LocaleScorecard" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(NameGeneratorScorecard), NameGeneratorScorecard.Parser, new string[] { "IsRequired", "FullMatch", "PartialMatch", "PartialFallback", "FullFallback" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(NameGenerator), NameGenerator.Parser, new string[] { "Names", "Replacements", "ClubTypes", "Locales" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(NameGeneratorReplacement), NameGeneratorReplacement.Parser, new string[] { "Id", "Options" }, null, null, null, null)
			}));
		}

		// Token: 0x04003327 RID: 13095
		private static FileDescriptor descriptor;
	}
}
