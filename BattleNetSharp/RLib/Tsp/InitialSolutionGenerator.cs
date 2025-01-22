using System;
using System.Collections.Generic;
using System.Linq;

namespace RLib.Tsp
{
	// Token: 0x020008D5 RID: 2261
	public class InitialSolutionGenerator
	{
		// Token: 0x020012F7 RID: 4855
		public class GlobalCheapestArc
		{
			// Token: 0x0600DECA RID: 57034 RVA: 0x004C267D File Offset: 0x004C087D
			public GlobalCheapestArc(int length, int? startNodeIndex, int? endNodeIndex)
			{
				this._length = length;
				this._startNodeIndex = startNodeIndex;
				this._endNodeIndex = endNodeIndex;
			}

			// Token: 0x0600DECB RID: 57035 RVA: 0x004C269C File Offset: 0x004C089C
			public int[] Generate(Func<int, int, float> arcCost)
			{
				int[] solution = Enumerable.Repeat<int>(-1, this._length).ToArray<int>();
				bool flag = this._startNodeIndex != null;
				if (flag)
				{
					solution[0] = this._startNodeIndex.Value;
				}
				bool flag2 = this._endNodeIndex != null;
				if (flag2)
				{
					int[] solution7 = solution;
					solution7[solution7.Length - 1] = this._endNodeIndex.Value;
				}
				int num = 1 + ((this._startNodeIndex != null) ? 1 : 0) + ((this._endNodeIndex != null) ? 1 : 0);
				List<int[]> list = (from x in Enumerable.Range(0, this._length)
					select new int[] { x }).ToList<int[]>();
				while (list.Count > num)
				{
					List<int[]> list2 = new List<int[]>();
					while (list.Count > num)
					{
						float num2 = float.MaxValue;
						int[][] array = new int[2][];
						for (int i = 0; i < list.Count; i++)
						{
							int[] array2 = list[i];
							int j = i + 1;
							while (j < list.Count)
							{
								int[] array3 = list[j];
								if (array2[0] == solution[0])
								{
									goto IL_017F;
								}
								int[] array4 = array2;
								if (array4[array4.Length - 1] == solution[0])
								{
									goto IL_017F;
								}
								int num3 = array2[0];
								int[] solution2 = solution;
								if (num3 == solution2[solution2.Length - 1])
								{
									goto IL_017F;
								}
								int[] array5 = array3;
								int num4 = array5[array5.Length - 1];
								int[] solution3 = solution;
								if (num4 == solution3[solution3.Length - 1])
								{
									goto IL_017F;
								}
								int num5 = array3[0];
								int[] solution4 = solution;
								if (num5 == solution4[solution4.Length - 1])
								{
									goto IL_017F;
								}
								bool flag3 = array3[0] == solution[0];
								IL_0180:
								bool flag4 = flag3;
								if (!flag4)
								{
									int[] array6 = array2;
									float num6 = arcCost(array6[array6.Length - 1], array3[0]);
									bool flag5 = num6 < num2;
									if (flag5)
									{
										array[0] = array2;
										array[1] = array3;
										num2 = num6;
									}
									int[] array7 = array2;
									int num7 = array7[array7.Length - 1];
									int[] array8 = array3;
									num6 = arcCost(num7, array8[array8.Length - 1]);
									bool flag6 = num6 < num2;
									if (flag6)
									{
										Array.Reverse<int>(array3);
										array[0] = array2;
										array[1] = array3;
										num2 = num6;
									}
									num6 = arcCost(array2[0], array3[0]);
									bool flag7 = num6 < num2;
									if (flag7)
									{
										Array.Reverse<int>(array2);
										array[0] = array2;
										array[1] = array3;
										num2 = num6;
									}
									int[] array9 = array2;
									int num8 = array9[array9.Length - 1];
									int[] array10 = array3;
									num6 = arcCost(num8, array10[array10.Length - 1]);
									bool flag8 = num6 < num2;
									if (flag8)
									{
										Array.Reverse<int>(array2);
										Array.Reverse<int>(array3);
										array[0] = array2;
										array[1] = array3;
										num2 = num6;
									}
								}
								j++;
								continue;
								IL_017F:
								flag3 = true;
								goto IL_0180;
							}
						}
						list.Remove(array[0]);
						list.Remove(array[1]);
						list2.Add(array.SelectMany((int[] x) => x).ToArray<int>());
					}
					list.ForEach(new Action<int[]>(list2.Add));
					list = list2;
				}
				int num9 = 0;
				bool flag9 = solution[0] >= 0;
				if (flag9)
				{
					list.Remove(list.First((int[] x) => x[0] == solution[0]));
					num9 = 1;
				}
				int[] solution5 = solution;
				bool flag10 = solution5[solution5.Length - 1] >= 0;
				if (flag10)
				{
					list.Remove(list.First(delegate(int[] x)
					{
						int num10 = x[0];
						int[] solution6 = solution;
						return num10 == solution6[solution6.Length - 1];
					}));
				}
				Array.Copy(list[0], 0, solution, num9, list[0].Length);
				return solution;
			}

			// Token: 0x04009CCD RID: 40141
			private readonly int _length;

			// Token: 0x04009CCE RID: 40142
			private readonly int? _startNodeIndex;

			// Token: 0x04009CCF RID: 40143
			private readonly int? _endNodeIndex;
		}

		// Token: 0x020012F8 RID: 4856
		public class NearestNeighbor
		{
			// Token: 0x0600DECC RID: 57036 RVA: 0x004C2A6C File Offset: 0x004C0C6C
			public NearestNeighbor(int length, int? startNodeIndex, int? endNodeIndex)
			{
				this._length = length;
				this._startNodeIndex = startNodeIndex;
				this._endNodeIndex = endNodeIndex;
			}

			// Token: 0x0600DECD RID: 57037 RVA: 0x004C2A8C File Offset: 0x004C0C8C
			public int[] Generate(Func<int, int, float> arcCost)
			{
				int[] array = Enumerable.Repeat<int>(-1, this._length).ToArray<int>();
				List<int> list = new List<int>(this._length);
				bool flag = this._endNodeIndex != null;
				if (flag)
				{
					list.Add(this._endNodeIndex.Value);
					int[] array2 = array;
					array2[array2.Length - 1] = this._endNodeIndex.Value;
				}
				int num = this._startNodeIndex ?? (from x in Enumerable.Range(1, this._length - 1)
					orderby arcCost(0, x)
					select x).First<int>();
				array[0] = num;
				int i = 1;
				int num2 = ((this._endNodeIndex != null) ? (this._length - 1) : this._length);
				while (i < num2)
				{
					float num3 = float.PositiveInfinity;
					int num4 = -1;
					list.Add(num);
					for (int j = 0; j < this._length; j++)
					{
						bool flag2 = list.Contains(j);
						if (!flag2)
						{
							float num5 = arcCost(num, j);
							bool flag3 = num5 < num3;
							if (flag3)
							{
								num3 = num5;
								num4 = j;
							}
						}
					}
					array[i] = num4;
					list.Add(num4);
					i++;
				}
				return array;
			}

			// Token: 0x04009CD0 RID: 40144
			private readonly int _length;

			// Token: 0x04009CD1 RID: 40145
			private readonly int? _startNodeIndex;

			// Token: 0x04009CD2 RID: 40146
			private readonly int? _endNodeIndex;
		}

		// Token: 0x020012F9 RID: 4857
		public class RandomOrder
		{
			// Token: 0x0600DECE RID: 57038 RVA: 0x004C2BF6 File Offset: 0x004C0DF6
			public RandomOrder(int length, int? startNodeIndex, int? endNodeIndex)
			{
				this._length = length;
				this._startNodeIndex = startNodeIndex;
				this._endNodeIndex = endNodeIndex;
			}

			// Token: 0x0600DECF RID: 57039 RVA: 0x004C2C20 File Offset: 0x004C0E20
			public int[] Generate()
			{
				int[] array = Enumerable.Repeat<int>(-1, this._length).ToArray<int>();
				array[0] = this._startNodeIndex ?? (-1);
				int[] array2 = array;
				array2[array2.Length - 1] = this._endNodeIndex ?? (-1);
				int[] array3 = (from a in Enumerable.Range(0, this._length).Except(array)
					orderby this._rng.Next()
					select a).ToArray<int>();
				for (int i = 0; i < array3.Length; i++)
				{
					int num = ((this._startNodeIndex != null) ? (i + 1) : i);
					array[num] = array3[i];
				}
				return array;
			}

			// Token: 0x04009CD3 RID: 40147
			private readonly int _length;

			// Token: 0x04009CD4 RID: 40148
			private readonly int? _startNodeIndex;

			// Token: 0x04009CD5 RID: 40149
			private readonly int? _endNodeIndex;

			// Token: 0x04009CD6 RID: 40150
			private readonly Random _rng = new Random();
		}
	}
}
