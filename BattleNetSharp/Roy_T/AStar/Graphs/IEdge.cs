using System;
using Roy_T.AStar.Primitives;

namespace Roy_T.AStar.Graphs
{
	// Token: 0x020008EE RID: 2286
	public interface IEdge
	{
		// Token: 0x17003821 RID: 14369
		// (get) Token: 0x0600B742 RID: 46914
		// (set) Token: 0x0600B743 RID: 46915
		Velocity TraversalVelocity { get; set; }

		// Token: 0x17003822 RID: 14370
		// (get) Token: 0x0600B744 RID: 46916
		Duration TraversalDuration { get; }

		// Token: 0x17003823 RID: 14371
		// (get) Token: 0x0600B745 RID: 46917
		Distance Distance { get; }

		// Token: 0x17003824 RID: 14372
		// (get) Token: 0x0600B746 RID: 46918
		INode Start { get; }

		// Token: 0x17003825 RID: 14373
		// (get) Token: 0x0600B747 RID: 46919
		INode End { get; }
	}
}
