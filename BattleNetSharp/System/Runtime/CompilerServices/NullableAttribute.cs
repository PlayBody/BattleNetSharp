using System;
using Microsoft.CodeAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000006 RID: 6
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00002367 File Offset: 0x00000567
		public NullableAttribute(byte A_1)
		{
			this.NullableFlags = new byte[] { A_1 };
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002380 File Offset: 0x00000580
		public NullableAttribute(byte[] A_1)
		{
			this.NullableFlags = A_1;
		}

		// Token: 0x04000007 RID: 7
		public readonly byte[] NullableFlags;
	}
}
