using System;
using System.Collections.Generic;
using System.Numerics;

namespace BattleNetSharp.D2.Map
{
	// Token: 0x02000B16 RID: 2838
	public class TeleportPather
	{
		// Token: 0x0600BE70 RID: 48752 RVA: 0x0048B438 File Offset: 0x00489638
		public TeleportPather()
		{
			this.m_distanceMatrix = new ushort[(int)this.m_columns, (int)this.m_rows];
		}

		// Token: 0x0600BE71 RID: 48753 RVA: 0x0048B468 File Offset: 0x00489668
		public void MakeDistanceTable(Vector2 toLocation)
		{
			for (int i = 0; i < (int)this.m_columns; i++)
			{
				for (int j = 0; j < (int)this.m_rows; j++)
				{
					bool flag = this.m_distanceMatrix[i, j] % 2 == 0;
					if (flag)
					{
						this.m_distanceMatrix[i, j] = (ushort)TeleportPather.CalculateDistance((float)i, (float)j, toLocation.X, toLocation.Y);
					}
					else
					{
						this.m_distanceMatrix[i, j] = TeleportPather.RangeInvalid;
					}
				}
			}
			this.m_distanceMatrix[(int)toLocation.X, (int)toLocation.Y] = 1;
		}

		// Token: 0x0600BE72 RID: 48754 RVA: 0x0048B510 File Offset: 0x00489710
		private void AddToListAtIndex(List<Vector2> list, Vector2 point, int index)
		{
			bool flag = index < list.Count;
			if (flag)
			{
				list[index] = point;
			}
			else
			{
				bool flag2 = index == list.Count;
				if (!flag2)
				{
					throw new InvalidOperationException();
				}
				list.Add(point);
			}
		}

		// Token: 0x0600BE73 RID: 48755 RVA: 0x0048B558 File Offset: 0x00489758
		public TeleportPather.Path GetTeleportPath(Vector2 fromLocation, Vector2 toLocation)
		{
			this.MakeDistanceTable(toLocation);
			List<Vector2> list = new List<Vector2>();
			list.Add(fromLocation);
			int num = 1;
			TeleportPather.BestMove bestMove = new TeleportPather.BestMove
			{
				Move = fromLocation,
				Result = TeleportPather.PathingResult.DestinationNotReachedYet
			};
			TeleportPather.BestMove bestMove2 = this.GetBestMove(bestMove.Move, toLocation, (uint)TeleportPather.BlockRange);
			while (bestMove2.Result != TeleportPather.PathingResult.Failed && num < 100)
			{
				bool flag = bestMove2.Result == TeleportPather.PathingResult.Reached;
				if (flag)
				{
					this.AddToListAtIndex(list, toLocation, num);
					num++;
					return new TeleportPather.Path
					{
						Found = true,
						Points = list.GetRange(0, num)
					};
				}
				int redundancy = this.GetRedundancy(list, num, bestMove2.Move);
				bool flag2 = redundancy == -1;
				if (flag2)
				{
					this.AddToListAtIndex(list, bestMove2.Move, num);
					num++;
				}
				else
				{
					num = redundancy + 1;
					this.AddToListAtIndex(list, bestMove2.Move, num);
				}
				bestMove2 = this.GetBestMove(bestMove2.Move, toLocation, (uint)TeleportPather.BlockRange);
			}
			return new TeleportPather.Path
			{
				Found = false,
				Points = null
			};
		}

		// Token: 0x0600BE74 RID: 48756 RVA: 0x0048B678 File Offset: 0x00489878
		private TeleportPather.BestMove GetBestMove(Vector2 position, Vector2 toLocation, uint blockRange)
		{
			bool flag = TeleportPather.CalculateDistance(toLocation, position) <= (double)TeleportPather.TpRange;
			TeleportPather.BestMove bestMove;
			if (flag)
			{
				bestMove = new TeleportPather.BestMove
				{
					Result = TeleportPather.PathingResult.Reached,
					Move = toLocation
				};
			}
			else
			{
				bool flag2 = !this.IsValidIndex((uint)position.X, (uint)position.Y);
				if (flag2)
				{
					bestMove = new TeleportPather.BestMove
					{
						Result = TeleportPather.PathingResult.Failed,
						Move = Vector2.Zero
					};
				}
				else
				{
					this.Block(position, blockRange);
					Vector2 vector = Vector2.Zero;
					int num = (int)TeleportPather.RangeInvalid;
					for (float num2 = position.X - (float)TeleportPather.TpRange; num2 <= position.X + (float)TeleportPather.TpRange; num2 += 1f)
					{
						for (float num3 = position.Y - (float)TeleportPather.TpRange; num3 <= position.Y + (float)TeleportPather.TpRange; num3 += 1f)
						{
							bool flag3 = !this.IsValidIndex((uint)num2, (uint)num3);
							if (!flag3)
							{
								Vector2 vector2 = new Vector2((float)((ushort)num2), (float)((ushort)num3));
								bool flag4 = (int)this.m_distanceMatrix[(int)((uint)vector2.X), (int)((uint)vector2.Y)] < num && TeleportPather.CalculateDistance(vector2, position) <= (double)TeleportPather.TpRange;
								if (flag4)
								{
									num = (int)this.m_distanceMatrix[(int)((uint)vector2.X), (int)((uint)vector2.Y)];
									vector = vector2;
								}
							}
						}
					}
					bool flag5 = num >= (int)TeleportPather.RangeInvalid || vector == Vector2.Zero;
					if (flag5)
					{
						bestMove = new TeleportPather.BestMove
						{
							Result = TeleportPather.PathingResult.Failed,
							Move = Vector2.Zero
						};
					}
					else
					{
						this.Block(vector, blockRange);
						bestMove = new TeleportPather.BestMove
						{
							Result = TeleportPather.PathingResult.DestinationNotReachedYet,
							Move = vector
						};
					}
				}
			}
			return bestMove;
		}

		// Token: 0x0600BE75 RID: 48757 RVA: 0x0048B858 File Offset: 0x00489A58
		private void Block(Vector2 position, uint nRange)
		{
			nRange = Math.Max(nRange, 1U);
			for (uint num = (uint)position.X - nRange; num < position.X + nRange; num += 1U)
			{
				for (uint num2 = (uint)position.Y - nRange; num2 < position.Y + nRange; num2 += 1U)
				{
					bool flag = this.IsValidIndex(num, num2);
					if (flag)
					{
						this.m_distanceMatrix[(int)num, (int)num2] = TeleportPather.RangeInvalid;
					}
				}
			}
		}

		// Token: 0x0600BE76 RID: 48758 RVA: 0x0048B8DC File Offset: 0x00489ADC
		private int GetRedundancy(List<Vector2> currentPath, int idxPath, Vector2 position)
		{
			for (int i = 1; i < idxPath; i++)
			{
				bool flag = TeleportPather.CalculateDistance(currentPath[i].X, currentPath[i].Y, position.X, position.Y) <= (double)TeleportPather.TpRange / 2.0;
				if (flag)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600BE77 RID: 48759 RVA: 0x0048B948 File Offset: 0x00489B48
		private bool IsValidIndex(uint x, uint y)
		{
			return x >= 0U && x < (uint)this.m_columns && y >= 0U && y < (uint)this.m_rows;
		}

		// Token: 0x0600BE78 RID: 48760 RVA: 0x0048B978 File Offset: 0x00489B78
		private static double CalculateDistance(float x1, float y1, float x2, float y2)
		{
			return Math.Sqrt((double)((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)));
		}

		// Token: 0x0600BE79 RID: 48761 RVA: 0x0048B9A0 File Offset: 0x00489BA0
		private static double CalculateDistance(Vector2 point1, Vector2 point2)
		{
			return TeleportPather.CalculateDistance(point1.X, point1.Y, point2.X, point2.Y);
		}

		// Token: 0x040091BC RID: 37308
		private static readonly ushort RangeInvalid = 10000;

		// Token: 0x040091BD RID: 37309
		private static readonly ushort TpRange = 30;

		// Token: 0x040091BE RID: 37310
		private static readonly ushort BlockRange = 2;

		// Token: 0x040091BF RID: 37311
		private readonly ushort[,] m_distanceMatrix;

		// Token: 0x040091C0 RID: 37312
		private readonly ushort m_rows = 5;

		// Token: 0x040091C1 RID: 37313
		private readonly ushort m_columns = 5;

		// Token: 0x020013E0 RID: 5088
		public class Path
		{
			// Token: 0x0400A094 RID: 41108
			public bool Found;

			// Token: 0x0400A095 RID: 41109
			public List<Vector2> Points;
		}

		// Token: 0x020013E1 RID: 5089
		public class BestMove
		{
			// Token: 0x0400A096 RID: 41110
			public bool Found;

			// Token: 0x0400A097 RID: 41111
			public Vector2 Move;

			// Token: 0x0400A098 RID: 41112
			public TeleportPather.PathingResult Result;
		}

		// Token: 0x020013E2 RID: 5090
		public enum PathingResult
		{
			// Token: 0x0400A09A RID: 41114
			Failed,
			// Token: 0x0400A09B RID: 41115
			DestinationNotReachedYet,
			// Token: 0x0400A09C RID: 41116
			Reached
		}
	}
}
