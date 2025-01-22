using System;
using System.Collections.Generic;
using Roy_T.AStar.Graphs;

namespace Roy_T.AStar.Paths
{
	// Token: 0x020008EA RID: 2282
	internal sealed class PathReconstructor
	{
		// Token: 0x0600B720 RID: 46880 RVA: 0x002D7969 File Offset: 0x002D5B69
		public PathReconstructor()
		{
			this.CameFrom = new Dictionary<INode, IEdge>();
		}

		// Token: 0x0600B721 RID: 46881 RVA: 0x002D797E File Offset: 0x002D5B7E
		public void SetCameFrom(INode node, IEdge via)
		{
			this.CameFrom[node] = via;
		}

		// Token: 0x0600B722 RID: 46882 RVA: 0x002D7990 File Offset: 0x002D5B90
		public Path ConstructPathTo(INode node, INode goal)
		{
			INode node2 = node;
			List<IEdge> list = new List<IEdge>();
			for (;;)
			{
				IEdge edge;
				bool flag = this.CameFrom.TryGetValue(node2, out edge);
				if (!flag)
				{
					break;
				}
				list.Add(edge);
				node2 = edge.Start;
			}
			list.Reverse();
			PathType pathType = ((node == goal) ? PathType.Complete : PathType.ClosestApproach);
			return new Path(pathType, list);
		}

		// Token: 0x0600B723 RID: 46883 RVA: 0x002D79EA File Offset: 0x002D5BEA
		public void Clear()
		{
			this.CameFrom.Clear();
		}

		// Token: 0x040069CD RID: 27085
		private readonly Dictionary<INode, IEdge> CameFrom;
	}
}
