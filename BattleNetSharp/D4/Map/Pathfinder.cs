using System;
using System.Collections.Generic;
using WoW.Packets;

namespace D4.Map
{
	// Token: 0x020008C7 RID: 2247
	public class Pathfinder
	{
		// Token: 0x0600B62F RID: 46639 RVA: 0x002C685C File Offset: 0x002C4A5C
		public Pathfinder(Node[,] nodeList)
		{
			this.nodes = nodeList;
		}

		// Token: 0x0600B630 RID: 46640 RVA: 0x002C6870 File Offset: 0x002C4A70
		private List<Node> GetAdjacents(Node node)
		{
			List<Node> list = new List<Node>();
			for (int i = -1; i <= 1; i++)
			{
				for (int j = -1; j <= 1; j++)
				{
					bool flag = i == 0 && j == 0;
					if (!flag)
					{
						int num = node.x + i;
						int num2 = node.y + j;
						bool flag2 = num >= 0 && num < this.width && num2 >= 0 && num2 < this.height;
						if (flag2)
						{
							bool isBlocked = this.nodes[num, num2].isBlocked;
							if (!isBlocked)
							{
								bool flag3 = i == 0 || j == 0;
								if (flag3)
								{
									list.Add(this.nodes[num, num2]);
								}
								else
								{
									bool flag4 = !this.nodes[node.x, num2].isBlocked && !this.nodes[num, node.y].isBlocked;
									if (flag4)
									{
										list.Add(this.nodes[num, num2]);
									}
								}
							}
						}
					}
				}
			}
			return list;
		}

		// Token: 0x0600B631 RID: 46641 RVA: 0x002C69B0 File Offset: 0x002C4BB0
		public bool CheckPathExist(Node deptNode, Node destNode)
		{
			return this.FindPath(deptNode, destNode).Count > 0;
		}

		// Token: 0x0600B632 RID: 46642 RVA: 0x002C69D4 File Offset: 0x002C4BD4
		public List<Node> FindPath(Node deptNode, Node destNode)
		{
			NodeHeap nodeHeap = new NodeHeap(4);
			HashSet<Node> hashSet = new HashSet<Node>();
			nodeHeap.Add(deptNode);
			deptNode.fromCost = (deptNode.toCost = 0);
			deptNode.from = (destNode.from = null);
			while (nodeHeap.Count > 0)
			{
				Node node = nodeHeap.Pop();
				hashSet.Add(node);
				bool flag = node == destNode;
				if (flag)
				{
					break;
				}
				foreach (Node node2 in this.GetAdjacents(node))
				{
					bool flag2 = hashSet.Contains(node2);
					if (!flag2)
					{
						bool flag3 = node.from != null && node.from.IsLineOfSight(node2, this.nodes);
						Node node3;
						if (flag3)
						{
							node3 = node.from;
						}
						else
						{
							node3 = node;
						}
						int num = node3.toCost + this.PredictDistanceCost(node3, node2);
						bool flag4 = !nodeHeap.Contains(node2) || num < node2.toCost;
						if (flag4)
						{
							node2.toCost = num;
							node2.fromCost = this.PredictDistanceCost(node2, destNode);
							node2.from = node3;
							bool flag5 = nodeHeap.Contains(node2);
							if (flag5)
							{
								nodeHeap.UpdateItem(node2);
							}
							else
							{
								nodeHeap.Add(node2);
							}
						}
					}
				}
			}
			List<Node> list = new List<Node>();
			bool flag6 = destNode.from != null;
			if (flag6)
			{
				for (Node node4 = destNode; node4 != null; node4 = node4.from)
				{
					list.Add(node4);
				}
				list.Reverse();
			}
			return list;
		}

		// Token: 0x0600B633 RID: 46643 RVA: 0x002C6BB0 File Offset: 0x002C4DB0
		private void SmoothingPath(List<Node> path)
		{
			for (int i = 1; i < path.Count - 1; i++)
			{
				bool flag = path[i - 1].IsLineOfSight(path[i + 1], this.nodes);
				if (flag)
				{
					path.RemoveAt(i--);
				}
			}
		}

		// Token: 0x0600B634 RID: 46644 RVA: 0x002C6C08 File Offset: 0x002C4E08
		private int PredictDistanceCost(Node dept, Node dest)
		{
			int num = Math.Abs(dept.x - dest.x);
			int num2 = Math.Abs(dept.y - dest.y);
			return Math.Abs(num - num2) * 10 + ((num > num2) ? num2 : num) * 14;
		}

		// Token: 0x0600B635 RID: 46645 RVA: 0x002C6C58 File Offset: 0x002C4E58
		public Node PositionToNode(Vector3 position)
		{
			int num = Math.Clamp((int)((position.X - this.min.X) / this.gapX), 0, this.width);
			int num2 = Math.Clamp((int)((position.Z - this.min.Z) / this.gapZ), 0, this.height);
			return this.nodes[num, num2];
		}

		// Token: 0x04006530 RID: 25904
		private Node[,] nodes;

		// Token: 0x04006531 RID: 25905
		private int width;

		// Token: 0x04006532 RID: 25906
		private int height;

		// Token: 0x04006533 RID: 25907
		private Vector3 min;

		// Token: 0x04006534 RID: 25908
		private Vector3 max;

		// Token: 0x04006535 RID: 25909
		private float gapX;

		// Token: 0x04006536 RID: 25910
		private float gapZ;
	}
}
