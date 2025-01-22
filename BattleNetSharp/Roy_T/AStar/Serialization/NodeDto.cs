using System;
using System.Collections.Generic;

namespace Roy_T.AStar.Serialization
{
	// Token: 0x020008DD RID: 2269
	public class NodeDto
	{
		// Token: 0x170037FA RID: 14330
		// (get) Token: 0x0600B699 RID: 46745 RVA: 0x002D6A87 File Offset: 0x002D4C87
		// (set) Token: 0x0600B69A RID: 46746 RVA: 0x002D6A8F File Offset: 0x002D4C8F
		public PositionDto Position { get; set; }

		// Token: 0x170037FB RID: 14331
		// (get) Token: 0x0600B69B RID: 46747 RVA: 0x002D6A98 File Offset: 0x002D4C98
		// (set) Token: 0x0600B69C RID: 46748 RVA: 0x002D6AA0 File Offset: 0x002D4CA0
		public GridPositionDto GridPosition { get; set; }

		// Token: 0x170037FC RID: 14332
		// (get) Token: 0x0600B69D RID: 46749 RVA: 0x002D6AA9 File Offset: 0x002D4CA9
		// (set) Token: 0x0600B69E RID: 46750 RVA: 0x002D6AB1 File Offset: 0x002D4CB1
		public List<EdgeDto> IncomingEdges { get; set; }

		// Token: 0x170037FD RID: 14333
		// (get) Token: 0x0600B69F RID: 46751 RVA: 0x002D6ABA File Offset: 0x002D4CBA
		// (set) Token: 0x0600B6A0 RID: 46752 RVA: 0x002D6AC2 File Offset: 0x002D4CC2
		public List<EdgeDto> OutGoingEdges { get; set; }
	}
}
