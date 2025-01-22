using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000371 RID: 881
	public static class RangeReflection
	{
		// Token: 0x17001D4D RID: 7501
		// (get) Token: 0x06005A73 RID: 23155 RVA: 0x0015E0B8 File Offset: 0x0015C2B8
		public static FileDescriptor Descriptor
		{
			get
			{
				return RangeReflection.descriptor;
			}
		}

		// Token: 0x06005A74 RID: 23156 RVA: 0x0015E0D0 File Offset: 0x0015C2D0
		static RangeReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "Ci9iZ3MvbG93L3BiL2NsaWVudC9nbG9iYWxfZXh0ZW5zaW9ucy9yYW5nZS5w", "cm90bxIMYmdzLnByb3RvY29sIiwKEFVuc2lnbmVkSW50UmFuZ2USCwoDbWlu", "GAEgASgEEgsKA21heBgCIAEoBCIqCg5TaWduZWRJbnRSYW5nZRILCgNtaW4Y", "ASABKAMSCwoDbWF4GAIgASgDIiYKCkZsb2F0UmFuZ2USCwoDbWluGAEgASgC", "EgsKA21heBgCIAEoAg==" }));
			RangeReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(UnsignedIntRange), UnsignedIntRange.Parser, new string[] { "Min", "Max" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SignedIntRange), SignedIntRange.Parser, new string[] { "Min", "Max" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(FloatRange), FloatRange.Parser, new string[] { "Min", "Max" }, null, null, null, null)
			}));
		}

		// Token: 0x04002934 RID: 10548
		private static FileDescriptor descriptor;
	}
}
