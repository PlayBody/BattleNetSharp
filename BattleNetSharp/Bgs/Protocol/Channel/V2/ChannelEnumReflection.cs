using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000658 RID: 1624
	public static class ChannelEnumReflection
	{
		// Token: 0x17002F23 RID: 12067
		// (get) Token: 0x06009723 RID: 38691 RVA: 0x00248B58 File Offset: 0x00246D58
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChannelEnumReflection.descriptor;
			}
		}

		// Token: 0x06009724 RID: 38692 RVA: 0x00248B70 File Offset: 0x00246D70
		static ChannelEnumReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjJiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL2NoYW5uZWxfZW51", "bS5wcm90bxIXYmdzLnByb3RvY29sLmNoYW5uZWwudjIqYwoMUHJpdmFjeUxl", "dmVsEhYKElBSSVZBQ1lfTEVWRUxfT1BFThABEiEKHVBSSVZBQ1lfTEVWRUxf", "T1BFTl9JTlZJVEFUSU9OEAMSGAoUUFJJVkFDWV9MRVZFTF9DTE9TRUQQBCqB", "AwoUQ2hhbm5lbFJlbW92ZWRSZWFzb24SJgoiQ0hBTk5FTF9SRU1PVkVEX1JF", "QVNPTl9NRU1CRVJfTEVGVBAAEigKJENIQU5ORUxfUkVNT1ZFRF9SRUFTT05f", "TUVNQkVSX0tJQ0tFRBABEi4KKkNIQU5ORUxfUkVNT1ZFRF9SRUFTT05fRElT", "U09MVkVEX0JZX01FTUJFUhACEi4KKkNIQU5ORUxfUkVNT1ZFRF9SRUFTT05f", "TUVNQkVSX0RJU0NPTk5FQ1RFRBADEjQKMENIQU5ORUxfUkVNT1ZFRF9SRUFT", "T05fTUVNQkVSX1JFTU9WRURfQllfU0VSVklDRRAEEi8KK0NIQU5ORUxfUkVN",
				"T1ZFRF9SRUFTT05fRElTU09MVkVEX0JZX1NFUlZJQ0UQBRInCiNDSEFOTkVM", "X1JFTU9WRURfUkVBU09OX0RJU0NPTk5FQ1RFRBAGEicKI0NIQU5ORUxfUkVN", "T1ZFRF9SRUFTT05fRk9VTkRFUl9MRUZUEA4="
			}));
			ChannelEnumReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[]
			{
				typeof(PrivacyLevel),
				typeof(ChannelRemovedReason)
			}, null, null));
		}

		// Token: 0x04004424 RID: 17444
		private static FileDescriptor descriptor;
	}
}
