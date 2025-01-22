using System;
using System.Collections.Generic;

namespace D2Map.Pathfinding
{
	// Token: 0x020008FB RID: 2299
	public class Node
	{
		// Token: 0x17003853 RID: 14419
		// (get) Token: 0x0600B7E7 RID: 47079 RVA: 0x002DC2CE File Offset: 0x002DA4CE
		// (set) Token: 0x0600B7E8 RID: 47080 RVA: 0x002DC2D6 File Offset: 0x002DA4D6
		public int X { get; set; }

		// Token: 0x17003854 RID: 14420
		// (get) Token: 0x0600B7E9 RID: 47081 RVA: 0x002DC2DF File Offset: 0x002DA4DF
		// (set) Token: 0x0600B7EA RID: 47082 RVA: 0x002DC2E7 File Offset: 0x002DA4E7
		public int Y { get; set; }

		// Token: 0x17003855 RID: 14421
		// (get) Token: 0x0600B7EB RID: 47083 RVA: 0x002DC2F0 File Offset: 0x002DA4F0
		// (set) Token: 0x0600B7EC RID: 47084 RVA: 0x002DC2F8 File Offset: 0x002DA4F8
		public bool IsWall { get; set; }

		// Token: 0x17003856 RID: 14422
		// (get) Token: 0x0600B7ED RID: 47085 RVA: 0x002DC301 File Offset: 0x002DA501
		// (set) Token: 0x0600B7EE RID: 47086 RVA: 0x002DC309 File Offset: 0x002DA509
		public bool IsNeighborWall { get; set; }

		// Token: 0x17003857 RID: 14423
		// (get) Token: 0x0600B7EF RID: 47087 RVA: 0x002DC312 File Offset: 0x002DA512
		// (set) Token: 0x0600B7F0 RID: 47088 RVA: 0x002DC31A File Offset: 0x002DA51A
		public float DistFromWall { get; set; }

		// Token: 0x17003858 RID: 14424
		// (get) Token: 0x0600B7F1 RID: 47089 RVA: 0x002DC323 File Offset: 0x002DA523
		// (set) Token: 0x0600B7F2 RID: 47090 RVA: 0x002DC32B File Offset: 0x002DA52B
		public bool IsCritical { get; set; }

		// Token: 0x0600B7F3 RID: 47091 RVA: 0x002DC334 File Offset: 0x002DA534
		public Node(int x, int y, bool isWall, bool IsNeighborWall, List<int> neighborRanges, bool isCritical = false)
		{
			this.X = x;
			this.Y = y;
			this.IsWall = isWall;
			this.IsNeighborWall = IsNeighborWall;
			this.IsCritical = isCritical;
			this.ranges = neighborRanges;
		}

		// Token: 0x0600B7F4 RID: 47092 RVA: 0x002DC3B8 File Offset: 0x002DA5B8
		public Node(int x, int y, bool isWall, float distFromWall, List<int> neighborRanges, bool isCritical = false)
		{
			this.X = x;
			this.Y = y;
			this.IsWall = isWall;
			this.DistFromWall = distFromWall;
			this.IsCritical = isCritical;
			this.ranges = neighborRanges;
		}

		// Token: 0x0600B7F5 RID: 47093 RVA: 0x002DC43C File Offset: 0x002DA63C
		public bool IsOpenList(IEnumerable<Node> openList)
		{
			return this.isOpenList;
		}

		// Token: 0x0600B7F6 RID: 47094 RVA: 0x002DC454 File Offset: 0x002DA654
		public void SetOpenList(bool value)
		{
			this.isOpenList = value;
		}

		// Token: 0x0600B7F7 RID: 47095 RVA: 0x002DC460 File Offset: 0x002DA660
		public bool IsClosedList(IEnumerable<Node> closedList)
		{
			return this.IsWall || this.isClosedList;
		}

		// Token: 0x0600B7F8 RID: 47096 RVA: 0x002DC483 File Offset: 0x002DA683
		public void SetClosedList(bool value)
		{
			this.isClosedList = value;
		}

		// Token: 0x17003859 RID: 14425
		// (get) Token: 0x0600B7F9 RID: 47097 RVA: 0x002DC490 File Offset: 0x002DA690
		public int TotalCost
		{
			get
			{
				return this.MovementCost + this.EstimatedCost;
			}
		}

		// Token: 0x1700385A RID: 14426
		// (get) Token: 0x0600B7FA RID: 47098 RVA: 0x002DC4AF File Offset: 0x002DA6AF
		// (set) Token: 0x0600B7FB RID: 47099 RVA: 0x002DC4B7 File Offset: 0x002DA6B7
		public int MovementCost { get; private set; }

		// Token: 0x1700385B RID: 14427
		// (get) Token: 0x0600B7FC RID: 47100 RVA: 0x002DC4C0 File Offset: 0x002DA6C0
		// (set) Token: 0x0600B7FD RID: 47101 RVA: 0x002DC4C8 File Offset: 0x002DA6C8
		public int EstimatedCost { get; private set; }

		// Token: 0x0600B7FE RID: 47102 RVA: 0x002DC4D4 File Offset: 0x002DA6D4
		public void SetMovementCost(Node parent)
		{
			int num = 1;
			bool flag = parent.X == this.X || parent.Y == this.Y;
			if (flag)
			{
				this.MovementCost = parent.MovementCost + 100 * num;
			}
			else
			{
				this.MovementCost = parent.MovementCost + 141 * num;
			}
			bool isNeighborWall = this.IsNeighborWall;
			if (isNeighborWall)
			{
				this.MovementCost = (int)((float)this.MovementCost * 1.5f);
			}
			bool flag2 = this.DistFromWall > 0f;
			if (flag2)
			{
				this.MovementCost = (int)((float)this.MovementCost + 1f / (this.DistFromWall / 100f));
			}
		}

		// Token: 0x0600B7FF RID: 47103 RVA: 0x002DC584 File Offset: 0x002DA784
		public void SetEstimatedCost(Node goal)
		{
			this.EstimatedCost = Math.Abs(this.X - goal.X) + Math.Abs(this.Y - goal.Y);
		}

		// Token: 0x1700385C RID: 14428
		// (get) Token: 0x0600B800 RID: 47104 RVA: 0x002DC5B3 File Offset: 0x002DA7B3
		// (set) Token: 0x0600B801 RID: 47105 RVA: 0x002DC5BB File Offset: 0x002DA7BB
		public Node Parent { get; set; }

		// Token: 0x1700385D RID: 14429
		// (get) Token: 0x0600B802 RID: 47106 RVA: 0x002DC5C4 File Offset: 0x002DA7C4
		private List<Node> nodeOffsets
		{
			get
			{
				List<Node> list = new List<Node>();
				foreach (int num in this.ranges)
				{
					bool flag = Node.savedNodeOffsets.ContainsKey(num);
					if (flag)
					{
						list.AddRange(Node.savedNodeOffsets[num]);
					}
					else
					{
						double num2 = Math.Ceiling((double)((float)num / 6f)) * 8.0;
						double num3 = 360.0 / num2;
						List<Node> list2 = new List<Node>();
						int num4 = 0;
						while ((double)num4 < num2)
						{
							int num5 = (int)Math.Round((double)num * Math.Cos(num3 * (double)num4 * 0.017453292519943295));
							int num6 = (int)Math.Round((double)num * Math.Sin(num3 * (double)num4 * 0.017453292519943295));
							list2.Add(new Node(num5, num6, false, false, null, false));
							num4++;
						}
						Node.savedNodeOffsets.Add(num, list2);
						list.AddRange(list2);
					}
				}
				return list;
			}
		}

		// Token: 0x0600B803 RID: 47107 RVA: 0x002DC708 File Offset: 0x002DA908
		public List<Node> GetChildren(Node[,] map)
		{
			List<Node> list = new List<Node>();
			foreach (Node node in this.nodeOffsets)
			{
				bool flag = this.X + node.X >= map.GetLength(0) || this.Y + node.Y >= map.GetLength(1);
				if (!flag)
				{
					bool flag2 = this.X + node.X < 0 || this.Y + node.Y < 0;
					if (!flag2)
					{
						list.Add(map[this.X + node.X, this.Y + node.Y]);
					}
				}
			}
			return list;
		}

		// Token: 0x0600B804 RID: 47108 RVA: 0x002DC7F8 File Offset: 0x002DA9F8
		public bool IsGoal(Node goal)
		{
			return this.IsEqual(goal);
		}

		// Token: 0x0600B805 RID: 47109 RVA: 0x002DC814 File Offset: 0x002DAA14
		public bool IsEqual(Node node)
		{
			return this == node || (this.X == node.X && this.Y == node.Y);
		}

		// Token: 0x0600B806 RID: 47110 RVA: 0x002DC84C File Offset: 0x002DAA4C
		private bool IsInPath(IEnumerable<Node> path)
		{
			foreach (Node node in path)
			{
				bool flag = this.IsEqual(node);
				if (flag)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x04006A16 RID: 27158
		private bool isOpenList = false;

		// Token: 0x04006A17 RID: 27159
		private bool isClosedList = false;

		// Token: 0x04006A18 RID: 27160
		public List<int> ranges = new List<int> { 1, 6, 12, 18 };

		// Token: 0x04006A1C RID: 27164
		private static Dictionary<int, List<Node>> savedNodeOffsets = new Dictionary<int, List<Node>>();
	}
}
