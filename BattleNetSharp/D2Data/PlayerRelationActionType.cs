using System;

namespace D2Data
{
	// Token: 0x0200095E RID: 2398
	public enum PlayerRelationActionType
	{
		// Token: 0x04007ED4 RID: 32468
		Unhostile = 4,
		// Token: 0x04007ED5 RID: 32469
		InvitedYou,
		// Token: 0x04007ED6 RID: 32470
		JoinedParty = 7,
		// Token: 0x04007ED7 RID: 32471
		JoinedYourParty,
		// Token: 0x04007ED8 RID: 32472
		AllowLoot = 2,
		// Token: 0x04007ED9 RID: 32473
		Hostile,
		// Token: 0x04007EDA RID: 32474
		LeftParty = 9,
		// Token: 0x04007EDB RID: 32475
		CanceledInvite = 6,
		// Token: 0x04007EDC RID: 32476
		CanceledLootPermission = 11,
		// Token: 0x04007EDD RID: 32477
		NotApplicable = 255
	}
}
