using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x02000566 RID: 1382
	public enum SessionRestrictionType
	{
		// Token: 0x04003C4C RID: 15436
		[OriginalName("SESSION_RESTRICTION_TYPE_UNSPECIFIED")]
		Unspecified,
		// Token: 0x04003C4D RID: 15437
		[OriginalName("SESSION_RESTRICTION_TYPE_PARENTAL_CONTROL")]
		ParentalControl,
		// Token: 0x04003C4E RID: 15438
		[OriginalName("SESSION_RESTRICTION_TYPE_GOVERNMENT_CONTROL")]
		GovernmentControl,
		// Token: 0x04003C4F RID: 15439
		[OriginalName("SESSION_RESTRICTION_TYPE_CAIS")]
		Cais
	}
}
