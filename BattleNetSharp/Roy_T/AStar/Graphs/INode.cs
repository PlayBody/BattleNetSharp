using System;
using System.Collections.Generic;
using Roy_T.AStar.Primitives;

namespace Roy_T.AStar.Graphs
{
	// Token: 0x020008EF RID: 2287
	public interface INode
	{
		// Token: 0x17003826 RID: 14374
		// (get) Token: 0x0600B748 RID: 46920
		Position Position { get; }

		// Token: 0x17003827 RID: 14375
		// (get) Token: 0x0600B749 RID: 46921
		IList<IEdge> Incoming { get; }

		// Token: 0x17003828 RID: 14376
		// (get) Token: 0x0600B74A RID: 46922
		IList<IEdge> Outgoing { get; }
	}
}
