using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Profanity.V1
{
	// Token: 0x020003DE RID: 990
	public static class ProfanityFilterConfigReflection
	{
		// Token: 0x17001FD8 RID: 8152
		// (get) Token: 0x060062CE RID: 25294 RVA: 0x0017E558 File Offset: 0x0017C758
		public static FileDescriptor Descriptor
		{
			get
			{
				return ProfanityFilterConfigReflection.descriptor;
			}
		}

		// Token: 0x060062CF RID: 25295 RVA: 0x0017E570 File Offset: 0x0017C770
		static ProfanityFilterConfigReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "Ci9iZ3MvbG93L3BiL2NsaWVudC9wcm9mYW5pdHlfZmlsdGVyX2NvbmZpZy5w", "cm90bxIZYmdzLnByb3RvY29sLnByb2Zhbml0eS52MSIpCgpXb3JkRmlsdGVy", "EgwKBHR5cGUYASACKAkSDQoFcmVnZXgYAiACKAkiRQoLV29yZEZpbHRlcnMS", "NgoHZmlsdGVycxgBIAMoCzIlLmJncy5wcm90b2NvbC5wcm9mYW5pdHkudjEu", "V29yZEZpbHRlckICSAE=" }));
			ProfanityFilterConfigReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(WordFilter), WordFilter.Parser, new string[] { "Type", "Regex" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(WordFilters), WordFilters.Parser, new string[] { "Filters" }, null, null, null, null)
			}));
		}

		// Token: 0x04002D25 RID: 11557
		private static FileDescriptor descriptor;
	}
}
