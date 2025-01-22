using System;

namespace D2Data
{
	// Token: 0x0200095B RID: 2395
	[Flags]
	public enum PartyRelationshipType : byte
	{
		// Token: 0x04007EC7 RID: 32455
		None = 0,
		// Token: 0x04007EC8 RID: 32456
		InAParty = 1,
		// Token: 0x04007EC9 RID: 32457
		InvitedYou = 2,
		// Token: 0x04007ECA RID: 32458
		Invited = 4
	}
}
