using System;
using System.Collections.Generic;
using Roy_T.AStar.Graphs;
using Roy_T.AStar.Primitives;

namespace Roy_T.AStar.Paths
{
	// Token: 0x020008E7 RID: 2279
	public sealed class Path
	{
		// Token: 0x0600B709 RID: 46857 RVA: 0x002D74B0 File Offset: 0x002D56B0
		public Path(PathType type, IReadOnlyList<IEdge> edges)
		{
			this.Type = type;
			this.Edges = edges;
			for (int i = 0; i < this.Edges.Count; i++)
			{
				this.Duration += this.Edges[i].TraversalDuration;
				this.Distance += this.Edges[i].Distance;
			}
		}

		// Token: 0x17003811 RID: 14353
		// (get) Token: 0x0600B70A RID: 46858 RVA: 0x002D7533 File Offset: 0x002D5733
		public PathType Type { get; }

		// Token: 0x17003812 RID: 14354
		// (get) Token: 0x0600B70B RID: 46859 RVA: 0x002D753B File Offset: 0x002D573B
		public Duration Duration { get; }

		// Token: 0x17003813 RID: 14355
		// (get) Token: 0x0600B70C RID: 46860 RVA: 0x002D7543 File Offset: 0x002D5743
		public IReadOnlyList<IEdge> Edges { get; }

		// Token: 0x17003814 RID: 14356
		// (get) Token: 0x0600B70D RID: 46861 RVA: 0x002D754B File Offset: 0x002D574B
		public Distance Distance { get; }
	}
}
