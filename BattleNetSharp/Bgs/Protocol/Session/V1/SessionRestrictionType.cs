using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x0200054A RID: 1354
	public enum SessionRestrictionType
	{
		// Token: 0x04003B52 RID: 15186
		[OriginalName("UNSPECIFIED")]
		Unspecified,
		// Token: 0x04003B53 RID: 15187
		[OriginalName("PARENTAL_CONTROL")]
		ParentalControl,
		// Token: 0x04003B54 RID: 15188
		[OriginalName("GOVERNMENT_CONTROL")]
		GovernmentControl,
		// Token: 0x04003B55 RID: 15189
		[OriginalName("CAIS")]
		Cais
	}
}
