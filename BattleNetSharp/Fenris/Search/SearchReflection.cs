using System;
using Fenris.Clan;
using Google.Protobuf.Reflection;

namespace Fenris.Search
{
	// Token: 0x0200011B RID: 283
	public static class SearchReflection
	{
		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06001BE5 RID: 7141 RVA: 0x0006A40C File Offset: 0x0006860C
		public static FileDescriptor Descriptor
		{
			get
			{
				return SearchReflection.descriptor;
			}
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x0006A424 File Offset: 0x00068624
		static SearchReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CgxTZWFyY2gucHJvdG8SDUZlbnJpcy5TZWFyY2gaCkNsYW4ucHJvdG8iLgoP", "RmluZENsYW5zUGFyYW1zEgwKBHRleHQYASABKAkSDQoFbGFiZWwYAiADKA0i", "bQoHUmVzdWx0cxIbChNjbGllbnRfc2VhcmNoX3Rva2VuGAEgASgEEhUKDWRv", "Y3VtZW50X3R5cGUYAiABKA0SEAoIZG9jdW1lbnQYAyADKAwSDgoGb2Zmc2V0", "GAQgASgNEgwKBG1vcmUYBSABKAgiyQQKDENsYW5Eb2N1bWVudBIPCgdjbGFu", "X2lkGAEgASgJEgwKBG5hbWUYAiABKAkSJQodbGFzdF9lZGl0ZWRfbmFtZV9i", "bmV0X2FjY291bnQYDyABKA0SJQodbGFzdF9lZGl0ZWRfbmFtZV9nYW1lX2Fj", "Y291bnQYECABKA0SCwoDdGFnGAMgASgJEiQKHGxhc3RfZWRpdGVkX3RhZ19i", "bmV0X2FjY291bnQYESABKA0SJAocbGFzdF9lZGl0ZWRfdGFnX2dhbWVfYWNj", "b3VudBgSIAEoDRITCgtkZXNjcmlwdGlvbhgEIAEoCRIsCiRsYXN0X2VkaXRl",
				"ZF9kZXNjcmlwdGlvbl9ibmV0X2FjY291bnQYDSABKA0SLAokbGFzdF9lZGl0", "ZWRfZGVzY3JpcHRpb25fZ2FtZV9hY2NvdW50GA4gASgNEhIKCmNyZWF0ZWRf", "YXQYBSABKAQSLwoGbGVhZGVyGAYgASgLMh8uRmVucmlzLkNsYW4uQ2xhblBy", "b2ZpbGUuTWVtYmVyEhQKDG1lbWJlcl9jb3VudBgHIAEoDRINCgVsYWJlbBgI", "IAMoDRIVCg1pc19zZWFyY2hhYmxlGAkgASgIEisKCGhlcmFsZHJ5GAogASgL", "MhkuRmVucmlzLkNsYW4uQ2xhbkhlcmFsZHJ5EikKIWxhc3RfZWRpdGVkX2hl", "cmFsZHJ5X2JuZXRfYWNjb3VudBgLIAEoDRIpCiFsYXN0X2VkaXRlZF9oZXJh", "bGRyeV9nYW1lX2FjY291bnQYDCABKA0ipgEKCUF0dHJpYnV0ZRIKCgJpZBgB", "IAEoDRIUCgpib29sX3ZhbHVlGAIgASgISAASFAoKdWludF92YWx1ZRgDIAEo", "BEgAEhMKCWludF92YWx1ZRgEIAEoA0gAEhYKDGRvdWJsZV92YWx1ZRgFIAEo",
				"AUgAEhYKDHN0cmluZ192YWx1ZRgGIAEoCUgAEhQKCmJsb2JfdmFsdWUYByAB", "KAxIAEIGCgR0eXBlIqYBCghEb2N1bWVudBIKCgJpZBgBIAEoCRIMCgR0eXBl", "GAIgASgNEgwKBGRhdGEYAyABKAwSFQoNaW5kZXhpbmdfdGV4dBgEIAMoCRIr", "CglhdHRyaWJ1dGUYBSADKAsyGC5GZW5yaXMuU2VhcmNoLkF0dHJpYnV0ZRIS", "Cgpzb3J0X3Njb3JlGAYgASgEEhoKEmxhc3RfYWN0aXZpdHlfdGltZRgHIAEo", "BCJxCghDcml0ZXJpYRIVCg1kb2N1bWVudF90eXBlGAEgASgNEhMKC21heF9y", "ZXN1bHRzGAIgASgNEgwKBHRleHQYAyABKAkSKwoJYXR0cmlidXRlGAQgAygL", "MhguRmVucmlzLlNlYXJjaC5BdHRyaWJ1dGU="
			}));
			SearchReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { ClanReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(FindClansParams), FindClansParams.Parser, new string[] { "Text", "Label" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Results), Results.Parser, new string[] { "ClientSearchToken", "DocumentType", "Document", "Offset", "More" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClanDocument), ClanDocument.Parser, new string[]
				{
					"ClanId", "Name", "LastEditedNameBnetAccount", "LastEditedNameGameAccount", "Tag", "LastEditedTagBnetAccount", "LastEditedTagGameAccount", "Description", "LastEditedDescriptionBnetAccount", "LastEditedDescriptionGameAccount",
					"CreatedAt", "Leader", "MemberCount", "Label", "IsSearchable", "Heraldry", "LastEditedHeraldryBnetAccount", "LastEditedHeraldryGameAccount"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Attribute), Attribute.Parser, new string[] { "Id", "BoolValue", "UintValue", "IntValue", "DoubleValue", "StringValue", "BlobValue" }, new string[] { "Type" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(Document), Document.Parser, new string[] { "Id", "Type", "Data", "IndexingText", "Attribute", "SortScore", "LastActivityTime" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Criteria), Criteria.Parser, new string[] { "DocumentType", "MaxResults", "Text", "Attribute" }, null, null, null, null)
			}));
		}

		// Token: 0x04000BC6 RID: 3014
		private static FileDescriptor descriptor;
	}
}
