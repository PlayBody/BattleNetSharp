using System;
using System.Runtime.CompilerServices;
using Roy_T.AStar.Primitives;

namespace Roy_T.AStar.Graphs
{
	// Token: 0x020008ED RID: 2285
	public sealed class Edge : IEdge
	{
		// Token: 0x0600B739 RID: 46905 RVA: 0x002D8332 File Offset: 0x002D6532
		public Edge(INode start, INode end, Velocity traversalVelocity)
		{
			this.Start = start;
			this.End = end;
			this.Distance = Distance.BeweenPositions(start.Position, end.Position);
			this.TraversalVelocity = traversalVelocity;
		}

		// Token: 0x1700381C RID: 14364
		// (get) Token: 0x0600B73A RID: 46906 RVA: 0x002D8369 File Offset: 0x002D6569
		// (set) Token: 0x0600B73B RID: 46907 RVA: 0x002D8371 File Offset: 0x002D6571
		public Velocity TraversalVelocity
		{
			get
			{
				return this.traversalVelocity;
			}
			set
			{
				this.traversalVelocity = value;
				this.TraversalDuration = this.Distance / value;
			}
		}

		// Token: 0x1700381D RID: 14365
		// (get) Token: 0x0600B73C RID: 46908 RVA: 0x002D838E File Offset: 0x002D658E
		// (set) Token: 0x0600B73D RID: 46909 RVA: 0x002D8396 File Offset: 0x002D6596
		public Duration TraversalDuration { get; private set; }

		// Token: 0x1700381E RID: 14366
		// (get) Token: 0x0600B73E RID: 46910 RVA: 0x002D839F File Offset: 0x002D659F
		public Distance Distance { get; }

		// Token: 0x1700381F RID: 14367
		// (get) Token: 0x0600B73F RID: 46911 RVA: 0x002D83A7 File Offset: 0x002D65A7
		public INode Start { get; }

		// Token: 0x17003820 RID: 14368
		// (get) Token: 0x0600B740 RID: 46912 RVA: 0x002D83AF File Offset: 0x002D65AF
		public INode End { get; }

		// Token: 0x0600B741 RID: 46913 RVA: 0x002D83B8 File Offset: 0x002D65B8
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 3);
			defaultInterpolatedStringHandler.AppendFormatted<INode>(this.Start);
			defaultInterpolatedStringHandler.AppendLiteral(" -> ");
			defaultInterpolatedStringHandler.AppendFormatted<INode>(this.End);
			defaultInterpolatedStringHandler.AppendLiteral(" @ ");
			defaultInterpolatedStringHandler.AppendFormatted<Velocity>(this.TraversalVelocity);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x040069D3 RID: 27091
		private Velocity traversalVelocity;
	}
}
