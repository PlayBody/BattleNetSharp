using System;
using System.Collections.Generic;
using Roy_T.AStar.Primitives;

namespace Roy_T.AStar.Graphs
{
	// Token: 0x020008F0 RID: 2288
	public sealed class Node : INode
	{
		// Token: 0x0600B74B RID: 46923 RVA: 0x002D8419 File Offset: 0x002D6619
		public Node(Position position)
		{
			this.Incoming = new List<IEdge>(0);
			this.Outgoing = new List<IEdge>(0);
			this.Position = position;
		}

		// Token: 0x17003829 RID: 14377
		// (get) Token: 0x0600B74C RID: 46924 RVA: 0x002D8442 File Offset: 0x002D6642
		public IList<IEdge> Incoming { get; }

		// Token: 0x1700382A RID: 14378
		// (get) Token: 0x0600B74D RID: 46925 RVA: 0x002D844A File Offset: 0x002D664A
		public IList<IEdge> Outgoing { get; }

		// Token: 0x1700382B RID: 14379
		// (get) Token: 0x0600B74E RID: 46926 RVA: 0x002D8452 File Offset: 0x002D6652
		public Position Position { get; }

		// Token: 0x0600B74F RID: 46927 RVA: 0x002D845C File Offset: 0x002D665C
		public void Connect(INode node, Velocity traversalVelocity)
		{
			Edge edge = new Edge(this, node, traversalVelocity);
			this.Outgoing.Add(edge);
			node.Incoming.Add(edge);
		}

		// Token: 0x0600B750 RID: 46928 RVA: 0x002D8490 File Offset: 0x002D6690
		public void Disconnect(INode node)
		{
			for (int i = this.Outgoing.Count - 1; i >= 0; i--)
			{
				IEdge edge = this.Outgoing[i];
				bool flag = edge.End == node;
				if (flag)
				{
					this.Outgoing.Remove(edge);
					node.Incoming.Remove(edge);
				}
			}
		}

		// Token: 0x0600B751 RID: 46929 RVA: 0x002D84F8 File Offset: 0x002D66F8
		public override string ToString()
		{
			return this.Position.ToString();
		}
	}
}
