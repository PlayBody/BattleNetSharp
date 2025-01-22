using System;
using System.Collections.Generic;
using System.Numerics;

namespace D4.Map
{
	// Token: 0x020008C4 RID: 2244
	public class Node : IComparable<Node>
	{
		// Token: 0x0600B61D RID: 46621 RVA: 0x002C609B File Offset: 0x002C429B
		public Node(int x, int y, bool isWall)
		{
			this.x = x;
			this.y = y;
			this.isBlocked = isWall;
		}

		// Token: 0x170037E3 RID: 14307
		// (get) Token: 0x0600B61E RID: 46622 RVA: 0x002C60BC File Offset: 0x002C42BC
		public int cost
		{
			get
			{
				return this.toCost + this.fromCost;
			}
		}

		// Token: 0x0600B61F RID: 46623 RVA: 0x002C60DC File Offset: 0x002C42DC
		public int CompareTo(Node other)
		{
			bool flag = other == null;
			int num;
			if (flag)
			{
				num = -1;
			}
			else
			{
				int num2 = this.cost.CompareTo(other.cost);
				bool flag2 = num2 == 0;
				if (flag2)
				{
					num2 = this.fromCost.CompareTo(other.fromCost);
				}
				num = -num2;
			}
			return num;
		}

		// Token: 0x0600B620 RID: 46624 RVA: 0x002C6130 File Offset: 0x002C4330
		public List<Vector2> GetContainingPoints()
		{
			return new List<Vector2>
			{
				new Vector2((float)this.x, (float)this.y),
				new Vector2((float)(this.x + 1), (float)this.y),
				new Vector2((float)this.x, (float)(this.y + 1)),
				new Vector2((float)(this.x + 1), (float)(this.y + 1))
			};
		}

		// Token: 0x0600B621 RID: 46625 RVA: 0x002C61B8 File Offset: 0x002C43B8
		public bool IsLineOfSight(Vector2 start, Vector2 end, Node[,] allNodes)
		{
			float num = end.X - start.X;
			float num2 = end.Y - start.Y;
			bool flag = true;
			bool flag2 = Math.Abs(num) > Math.Abs(num2);
			if (flag2)
			{
				int num3 = ((num == 0f) ? 0 : ((num > 0f) ? 1 : 0));
				float num4 = (float)this.y;
				int num5 = this.x + num3;
				while ((float)num5 != end.X + (float)num3)
				{
					float num6 = (float)this.y + num2 * (float)(num5 - this.x) / num;
					int num7 = ((num3 > 0) ? (num5 - num3) : num5);
					int num8 = Math.Min((int)num6, (int)num4);
					bool flag3 = allNodes[num7, num8].isBlocked;
					if (flag3)
					{
						flag = false;
						break;
					}
					bool flag4 = (int)num4 != (int)num6 && num4 != (float)((int)num4) && num6 != (float)((int)num6);
					if (flag4)
					{
						num8 = Math.Max((int)num6, (int)num4);
						bool flag5 = allNodes[num7, num8].isBlocked;
						if (flag5)
						{
							flag = false;
							break;
						}
					}
					num4 = num6;
					num5 += num3;
				}
			}
			else
			{
				int num9 = ((num2 == 0f) ? 0 : ((num2 > 0f) ? 1 : 0));
				float num10 = (float)this.x;
				int num11 = this.y + num9;
				while ((float)num11 != end.Y + (float)num9)
				{
					float num12 = (float)this.x + num * (float)(num11 - this.y) / num2;
					int num13 = ((num9 > 0) ? (num11 - num9) : num11);
					int num14 = Math.Min((int)num12, (int)num10);
					bool flag6 = allNodes[num14, num13].isBlocked;
					if (flag6)
					{
						flag = false;
						break;
					}
					bool flag7 = (int)num10 != (int)num12 && num10 != (float)((int)num10) && num12 != (float)((int)num12);
					if (flag7)
					{
						num14 = Math.Max((int)num12, (int)num10);
						bool flag8 = allNodes[num14, num13].isBlocked;
						if (flag8)
						{
							flag = false;
							break;
						}
					}
					num10 = num12;
					num11 += num9;
				}
			}
			return flag;
		}

		// Token: 0x0600B622 RID: 46626 RVA: 0x002C63F8 File Offset: 0x002C45F8
		public bool IsLineOfSight(Node end, Node[,] allNodes)
		{
			bool flag = this.x == end.x;
			bool flag3;
			if (flag)
			{
				int num = end.y - this.y;
				int num2 = ((num == 0) ? 0 : ((num > 0) ? 1 : (-1)));
				bool flag2 = num2 == 0;
				if (flag2)
				{
					flag3 = !this.isBlocked;
				}
				else
				{
					bool flag4 = true;
					for (int num3 = this.y; num3 != end.y + num2; num3 += num2)
					{
						bool flag5 = allNodes[this.x, num3].isBlocked;
						if (flag5)
						{
							flag4 = false;
							break;
						}
					}
					flag3 = flag4;
				}
			}
			else
			{
				bool flag6 = this.y == end.y;
				if (flag6)
				{
					int num4 = end.x - this.x;
					int num5 = ((num4 == 0) ? 0 : ((num4 > 0) ? 1 : (-1)));
					bool flag4 = true;
					for (int num6 = this.x; num6 != end.x + num5; num6 += num5)
					{
						bool flag7 = allNodes[num6, this.y].isBlocked;
						if (flag7)
						{
							flag4 = false;
							break;
						}
					}
					flag3 = flag4;
				}
				else
				{
					List<Vector2> containingPoints = this.GetContainingPoints();
					List<Vector2> containingPoints2 = end.GetContainingPoints();
					bool flag4 = true;
					for (int i = 0; i < 4; i++)
					{
						bool flag8 = !this.IsLineOfSight(containingPoints[i], containingPoints2[i], allNodes);
						if (flag8)
						{
							flag4 = false;
							break;
						}
					}
					flag3 = flag4;
				}
			}
			return flag3;
		}

		// Token: 0x04006526 RID: 25894
		public int x;

		// Token: 0x04006527 RID: 25895
		public int y;

		// Token: 0x04006528 RID: 25896
		public int toCost;

		// Token: 0x04006529 RID: 25897
		public int fromCost;

		// Token: 0x0400652A RID: 25898
		public Node from;

		// Token: 0x0400652B RID: 25899
		public int lastHeapIndex;

		// Token: 0x0400652C RID: 25900
		public bool isBlocked;
	}
}
