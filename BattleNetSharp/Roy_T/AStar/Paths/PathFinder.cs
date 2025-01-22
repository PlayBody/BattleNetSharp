using System;
using System.Collections.Generic;
using Roy_T.AStar.Collections;
using Roy_T.AStar.Graphs;
using Roy_T.AStar.Grids;
using Roy_T.AStar.Primitives;

namespace Roy_T.AStar.Paths
{
	// Token: 0x020008E8 RID: 2280
	public sealed class PathFinder
	{
		// Token: 0x0600B70E RID: 46862 RVA: 0x002D7553 File Offset: 0x002D5753
		public PathFinder()
		{
			this.Interesting = new MinHeap<PathFinderNode>();
			this.Nodes = new Dictionary<INode, PathFinderNode>();
			this.PathReconstructor = new PathReconstructor();
		}

		// Token: 0x0600B70F RID: 46863 RVA: 0x002D7580 File Offset: 0x002D5780
		public Path FindPath(GridPosition start, GridPosition end, Grid grid)
		{
			INode node = grid.GetNode(start);
			INode node2 = grid.GetNode(end);
			return this.FindPath(node, node2, Velocity.FromMetersPerSecond(1f));
		}

		// Token: 0x0600B710 RID: 46864 RVA: 0x002D75B4 File Offset: 0x002D57B4
		public Path FindPath(GridPosition start, GridPosition end, Grid grid, Velocity maximumVelocity)
		{
			INode node = grid.GetNode(start);
			INode node2 = grid.GetNode(end);
			return this.FindPath(node, node2, maximumVelocity);
		}

		// Token: 0x0600B711 RID: 46865 RVA: 0x002D75E0 File Offset: 0x002D57E0
		public Path FindPath(INode start, INode goal, Velocity maximumVelocity)
		{
			this.ResetState();
			this.AddFirstNode(start, goal, maximumVelocity);
			while (this.Interesting.Count > 0)
			{
				PathFinderNode pathFinderNode = this.Interesting.Extract();
				bool flag = PathFinder.GoalReached(goal, pathFinderNode);
				if (flag)
				{
					return this.PathReconstructor.ConstructPathTo(pathFinderNode.Node, goal);
				}
				this.UpdateNodeClosestToGoal(pathFinderNode);
				foreach (IEdge edge in pathFinderNode.Node.Outgoing)
				{
					INode end = edge.End;
					Duration duration = pathFinderNode.DurationSoFar + edge.TraversalDuration;
					PathFinderNode pathFinderNode2;
					bool flag2 = this.Nodes.TryGetValue(end, out pathFinderNode2);
					if (flag2)
					{
						this.UpdateExistingNode(goal, maximumVelocity, pathFinderNode, edge, end, duration, pathFinderNode2);
					}
					else
					{
						this.InsertNode(end, edge, goal, duration, maximumVelocity);
					}
				}
			}
			return this.PathReconstructor.ConstructPathTo(this.NodeClosestToGoal.Node, goal);
		}

		// Token: 0x0600B712 RID: 46866 RVA: 0x002D770C File Offset: 0x002D590C
		private void ResetState()
		{
			this.Interesting.Clear();
			this.Nodes.Clear();
			this.PathReconstructor.Clear();
			this.NodeClosestToGoal = null;
		}

		// Token: 0x0600B713 RID: 46867 RVA: 0x002D773C File Offset: 0x002D593C
		private void AddFirstNode(INode start, INode goal, Velocity maximumVelocity)
		{
			PathFinderNode pathFinderNode = new PathFinderNode(start, Duration.Zero, PathFinder.ExpectedDuration(start, goal, maximumVelocity));
			this.Interesting.Insert(pathFinderNode);
			this.Nodes.Add(pathFinderNode.Node, pathFinderNode);
			this.NodeClosestToGoal = pathFinderNode;
		}

		// Token: 0x0600B714 RID: 46868 RVA: 0x002D7785 File Offset: 0x002D5985
		private static bool GoalReached(INode goal, PathFinderNode current)
		{
			return current.Node == goal;
		}

		// Token: 0x0600B715 RID: 46869 RVA: 0x002D7790 File Offset: 0x002D5990
		private void UpdateNodeClosestToGoal(PathFinderNode current)
		{
			bool flag = current.ExpectedRemainingTime < this.NodeClosestToGoal.ExpectedRemainingTime;
			if (flag)
			{
				this.NodeClosestToGoal = current;
			}
		}

		// Token: 0x0600B716 RID: 46870 RVA: 0x002D77C4 File Offset: 0x002D59C4
		private void UpdateExistingNode(INode goal, Velocity maximumVelocity, PathFinderNode current, IEdge edge, INode oppositeNode, Duration costSoFar, PathFinderNode node)
		{
			bool flag = node.DurationSoFar > costSoFar;
			if (flag)
			{
				this.Interesting.Remove(node);
				this.InsertNode(oppositeNode, edge, goal, costSoFar, maximumVelocity);
			}
		}

		// Token: 0x0600B717 RID: 46871 RVA: 0x002D7804 File Offset: 0x002D5A04
		private void InsertNode(INode current, IEdge via, INode goal, Duration costSoFar, Velocity maximumVelocity)
		{
			this.PathReconstructor.SetCameFrom(current, via);
			PathFinderNode pathFinderNode = new PathFinderNode(current, costSoFar, PathFinder.ExpectedDuration(current, goal, maximumVelocity));
			this.Interesting.Insert(pathFinderNode);
			this.Nodes[current] = pathFinderNode;
		}

		// Token: 0x0600B718 RID: 46872 RVA: 0x002D784D File Offset: 0x002D5A4D
		public static Duration ExpectedDuration(INode a, INode b, Velocity maximumVelocity)
		{
			return Distance.BeweenPositions(a.Position, b.Position) / maximumVelocity;
		}

		// Token: 0x040069C5 RID: 27077
		private readonly MinHeap<PathFinderNode> Interesting;

		// Token: 0x040069C6 RID: 27078
		private readonly Dictionary<INode, PathFinderNode> Nodes;

		// Token: 0x040069C7 RID: 27079
		private readonly PathReconstructor PathReconstructor;

		// Token: 0x040069C8 RID: 27080
		private PathFinderNode NodeClosestToGoal;
	}
}
