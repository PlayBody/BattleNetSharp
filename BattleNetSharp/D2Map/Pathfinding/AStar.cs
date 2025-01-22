using System;
using System.Collections.Generic;
using System.Numerics;

namespace D2Map.Pathfinding
{
	// Token: 0x020008FA RID: 2298
	public class AStar
	{
		// Token: 0x1700384F RID: 14415
		// (get) Token: 0x0600B7DE RID: 47070 RVA: 0x002DBFB3 File Offset: 0x002DA1B3
		// (set) Token: 0x0600B7DF RID: 47071 RVA: 0x002DBFBB File Offset: 0x002DA1BB
		public int Steps { get; private set; }

		// Token: 0x17003850 RID: 14416
		// (get) Token: 0x0600B7E0 RID: 47072 RVA: 0x002DBFC4 File Offset: 0x002DA1C4
		public IEnumerable<Node> OpenList
		{
			get
			{
				return this.openList.Values;
			}
		}

		// Token: 0x17003851 RID: 14417
		// (get) Token: 0x0600B7E1 RID: 47073 RVA: 0x002DBFE4 File Offset: 0x002DA1E4
		public IEnumerable<Node> ClosedList
		{
			get
			{
				return this.closedList.Values;
			}
		}

		// Token: 0x17003852 RID: 14418
		// (get) Token: 0x0600B7E2 RID: 47074 RVA: 0x002DC004 File Offset: 0x002DA204
		public Node CurrentNode
		{
			get
			{
				return this.current;
			}
		}

		// Token: 0x0600B7E3 RID: 47075 RVA: 0x002DC01C File Offset: 0x002DA21C
		public AStar(Node[,] map, Vector2 start, Vector2 goal)
		{
			DuplicateComparer duplicateComparer = new DuplicateComparer();
			this.openList = new SortedList<int, Node>(duplicateComparer);
			this.closedList = new SortedList<int, Node>(duplicateComparer);
			this.Reset(map, start, goal);
		}

		// Token: 0x0600B7E4 RID: 47076 RVA: 0x002DC05C File Offset: 0x002DA25C
		public void Reset(Node[,] map, Vector2 start, Vector2 goal)
		{
			this.openList.Clear();
			this.closedList.Clear();
			this.current = map[(int)start.X, (int)start.Y];
			this.map = map;
			this.goal = map[(int)goal.X, (int)goal.Y];
			this.openList.Add(this.current);
			this.current.SetOpenList(true);
		}

		// Token: 0x0600B7E5 RID: 47077 RVA: 0x002DC0DC File Offset: 0x002DA2DC
		public bool Step()
		{
			int steps = this.Steps;
			this.Steps = steps + 1;
			for (;;)
			{
				bool flag = this.openList.IsEmpty<int, Node>();
				if (flag)
				{
					break;
				}
				this.current = this.openList.Pop();
				bool flag2 = this.current.IsClosedList(this.ClosedList);
				if (!flag2)
				{
					goto IL_0053;
				}
			}
			return true;
			IL_0053:
			this.current.SetOpenList(false);
			this.closedList.Add(this.current);
			this.current.SetClosedList(true);
			bool flag3 = this.current.IsGoal(this.goal);
			bool flag4;
			if (flag3)
			{
				flag4 = true;
			}
			else
			{
				foreach (Node node in this.current.GetChildren(this.map))
				{
					bool flag5 = node == null;
					if (!flag5)
					{
						bool flag6 = node.IsOpenList(this.OpenList) || node.IsClosedList(this.ClosedList);
						if (!flag6)
						{
							node.Parent = this.current;
							node.SetMovementCost(this.current);
							node.SetEstimatedCost(this.goal);
							this.openList.Add(node);
							node.SetOpenList(true);
						}
					}
				}
				flag4 = false;
			}
			return flag4;
		}

		// Token: 0x0600B7E6 RID: 47078 RVA: 0x002DC260 File Offset: 0x002DA460
		public IEnumerable<Node> GetPath()
		{
			while (!this.Step())
			{
			}
			bool flag = this.current != null;
			IEnumerable<Node> enumerable;
			if (flag)
			{
				Node parent = this.current;
				List<Node> list = new List<Node>();
				while (parent != null)
				{
					list.Add(parent);
					parent = parent.Parent;
				}
				list.Reverse();
				enumerable = list.ToArray();
			}
			else
			{
				enumerable = null;
			}
			return enumerable;
		}

		// Token: 0x04006A0A RID: 27146
		private SortedList<int, Node> openList;

		// Token: 0x04006A0B RID: 27147
		private SortedList<int, Node> closedList;

		// Token: 0x04006A0C RID: 27148
		private Node current;

		// Token: 0x04006A0D RID: 27149
		private Node goal;

		// Token: 0x04006A0E RID: 27150
		private Node[,] map;
	}
}
