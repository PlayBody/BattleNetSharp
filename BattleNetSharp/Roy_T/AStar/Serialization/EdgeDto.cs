using System;

namespace Roy_T.AStar.Serialization
{
	// Token: 0x020008D9 RID: 2265
	public class EdgeDto
	{
		// Token: 0x170037F4 RID: 14324
		// (get) Token: 0x0600B67E RID: 46718 RVA: 0x002D6500 File Offset: 0x002D4700
		// (set) Token: 0x0600B67F RID: 46719 RVA: 0x002D6508 File Offset: 0x002D4708
		public VelocityDto TraversalVelocity { get; set; }

		// Token: 0x170037F5 RID: 14325
		// (get) Token: 0x0600B680 RID: 46720 RVA: 0x002D6511 File Offset: 0x002D4711
		// (set) Token: 0x0600B681 RID: 46721 RVA: 0x002D6519 File Offset: 0x002D4719
		public GridPositionDto Start { get; set; }

		// Token: 0x170037F6 RID: 14326
		// (get) Token: 0x0600B682 RID: 46722 RVA: 0x002D6522 File Offset: 0x002D4722
		// (set) Token: 0x0600B683 RID: 46723 RVA: 0x002D652A File Offset: 0x002D472A
		public GridPositionDto End { get; set; }
	}
}
