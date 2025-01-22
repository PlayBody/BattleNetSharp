using System;

namespace D4Data
{
	// Token: 0x020008CB RID: 2251
	[Flags]
	public enum ReplicationFlags : byte
	{
		// Token: 0x04006543 RID: 25923
		PlayerReplicated = 1,
		// Token: 0x04006544 RID: 25924
		LivingReplicated = 2,
		// Token: 0x04006545 RID: 25925
		GizmoReplicated = 4,
		// Token: 0x04006546 RID: 25926
		ItemReplicated = 8,
		// Token: 0x04006547 RID: 25927
		PlayerReplicated2 = 128
	}
}
