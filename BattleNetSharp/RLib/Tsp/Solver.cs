using System;
using System.Runtime.CompilerServices;
using RLib.Tsp.Enums;

namespace RLib.Tsp
{
	// Token: 0x020008D6 RID: 2262
	public class Solver
	{
		// Token: 0x0600B66B RID: 46699 RVA: 0x002D5F9E File Offset: 0x002D419E
		public Solver(Func<int, int, float> getArcCost, int nodeCount)
		{
			this.GetArcCost = getArcCost;
			this._nodeCount = nodeCount;
			this.Configuration = new Solver.SolverConfiguration();
		}

		// Token: 0x0600B66C RID: 46700 RVA: 0x002D5FC3 File Offset: 0x002D41C3
		public Solver(Func<int, int, float> getArcCost, int nodeCount, Solver.SolverConfiguration configuration)
		{
			this.GetArcCost = getArcCost;
			this._nodeCount = nodeCount;
			this.Configuration = configuration;
		}

		// Token: 0x170037F0 RID: 14320
		// (get) Token: 0x0600B66D RID: 46701 RVA: 0x002D5FE4 File Offset: 0x002D41E4
		// (set) Token: 0x0600B66E RID: 46702 RVA: 0x002D5FEC File Offset: 0x002D41EC
		private Func<int[], float> GetSolutionCostExternal { get; set; }

		// Token: 0x170037F1 RID: 14321
		// (get) Token: 0x0600B66F RID: 46703 RVA: 0x002D5FF5 File Offset: 0x002D41F5
		// (set) Token: 0x0600B670 RID: 46704 RVA: 0x002D5FFD File Offset: 0x002D41FD
		private bool CompareFullSolutionCost { get; set; }

		// Token: 0x170037F2 RID: 14322
		// (get) Token: 0x0600B671 RID: 46705 RVA: 0x002D6006 File Offset: 0x002D4206
		// (set) Token: 0x0600B672 RID: 46706 RVA: 0x002D600E File Offset: 0x002D420E
		private Func<int, int, float> GetArcCost { get; set; }

		// Token: 0x170037F3 RID: 14323
		// (get) Token: 0x0600B673 RID: 46707 RVA: 0x002D6017 File Offset: 0x002D4217
		// (set) Token: 0x0600B674 RID: 46708 RVA: 0x002D601F File Offset: 0x002D421F
		public Solver.SolverConfiguration Configuration { get; set; }

		// Token: 0x0600B675 RID: 46709 RVA: 0x002D6028 File Offset: 0x002D4228
		private float GetSolutionCost(int[] solution)
		{
			bool flag = this.GetSolutionCostExternal != null;
			float num;
			if (flag)
			{
				num = this.GetSolutionCostExternal(solution);
			}
			else
			{
				float num2 = 0f;
				for (int i = 1; i < solution.Length; i++)
				{
					num2 += this.GetArcCost(solution[i - 1], solution[i]);
				}
				num = num2;
			}
			return num;
		}

		// Token: 0x0600B676 RID: 46710 RVA: 0x002D608C File Offset: 0x002D428C
		public void SetStartNode(int nodeIndex)
		{
			bool flag = nodeIndex < 0 || nodeIndex > this._nodeCount - 1;
			if (flag)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(48, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Start node index must be in range between 0 and ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this._nodeCount - 1);
				throw new ArgumentException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			this._startNodeIndex = new int?(nodeIndex);
		}

		// Token: 0x0600B677 RID: 46711 RVA: 0x002D60F4 File Offset: 0x002D42F4
		public void SetEndNode(int nodeIndex)
		{
			bool flag = nodeIndex < 0 || nodeIndex > this._nodeCount - 1;
			if (flag)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(46, 1);
				defaultInterpolatedStringHandler.AppendLiteral("End node index must be in range between 0 and ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this._nodeCount - 1);
				throw new ArgumentException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			this._endNodeIndex = new int?(nodeIndex);
		}

		// Token: 0x0600B678 RID: 46712 RVA: 0x002D6159 File Offset: 0x002D4359
		public void UseFullSolutionCostValidation(Func<int[], float> getSolutionCost)
		{
			this.GetSolutionCostExternal = getSolutionCost;
			this.CompareFullSolutionCost = true;
		}

		// Token: 0x0600B679 RID: 46713 RVA: 0x002D616C File Offset: 0x002D436C
		private int[] GenerateInitialSolution()
		{
			int[] array;
			switch (this.Configuration.FirstSolutionStrategy)
			{
			case eFirstSolutionStrategy.NearestNeighbor:
				array = new InitialSolutionGenerator.NearestNeighbor(this._nodeCount, this._startNodeIndex, this._endNodeIndex).Generate(this.GetArcCost);
				break;
			case eFirstSolutionStrategy.Random:
				array = new InitialSolutionGenerator.RandomOrder(this._nodeCount, this._startNodeIndex, this._endNodeIndex).Generate();
				break;
			case eFirstSolutionStrategy.ConnectCheapestArcs:
				array = new InitialSolutionGenerator.GlobalCheapestArc(this._nodeCount, this._startNodeIndex, this._endNodeIndex).Generate(this.GetArcCost);
				break;
			default:
				throw new ArgumentOutOfRangeException();
			}
			return array;
		}

		// Token: 0x0600B67A RID: 46714 RVA: 0x002D620C File Offset: 0x002D440C
		private float NodeSwapCostChange(int[] solution, int nodeA, int nodeB)
		{
			return ((nodeA > 0) ? this.GetArcCost(solution[nodeA - 1], solution[nodeB]) : 0f) + ((nodeB < solution.Length - 1) ? this.GetArcCost(solution[nodeA], solution[nodeB + 1]) : 0f) - (((nodeA > 0) ? this.GetArcCost(solution[nodeA], solution[nodeA - 1]) : 0f) + ((nodeB < solution.Length - 1) ? this.GetArcCost(solution[nodeB], solution[nodeB + 1]) : 0f));
		}

		// Token: 0x0600B67B RID: 46715 RVA: 0x002D62A4 File Offset: 0x002D44A4
		public int[] FindSolution()
		{
			int[] array = this.GenerateInitialSolution();
			float num = this.GetSolutionCost(array);
			int num2 = array.Length;
			int num3 = 0;
			int num4 = ((this._startNodeIndex == null) ? 0 : 1);
			int num5 = num2 - ((this._endNodeIndex == null) ? 0 : 1);
			int num6 = 1;
			Random random = new Random(num6);
			int[] array2 = new int[array.Length];
			float num7 = num;
			int num8 = 0;
			Array.Copy(array, 0, array2, 0, array.Length);
			do
			{
				bool flag = false;
				for (int i = num4; i < num5 - 2; i++)
				{
					for (int j = i + 2; j < num5; j++)
					{
						bool flag2 = !this.CompareFullSolutionCost;
						if (flag2)
						{
							float num9 = this.NodeSwapCostChange(array2, i, j);
							bool flag3 = num9 < 0f;
							if (flag3)
							{
								SolverTools.ApplyNodeSwap(array2, i, j);
								num7 += num9;
								flag = true;
							}
						}
						else
						{
							int[] routeByNodeSwap = SolverTools.GetRouteByNodeSwap(array2, i, j);
							float solutionCost = this.GetSolutionCost(routeByNodeSwap);
							bool flag4 = solutionCost < num7;
							if (flag4)
							{
								num7 = solutionCost;
								array2 = routeByNodeSwap;
								flag = true;
							}
						}
					}
				}
				bool flag5 = flag;
				if (flag5)
				{
					bool flag6 = num7 < num;
					if (flag6)
					{
						Array.Copy(array2, 0, array, 0, array.Length);
						num = num7;
						num8 = 0;
					}
				}
				else
				{
					bool flag7 = this.Configuration.EnableSolutionMutation && num8 < this.Configuration.MaxSolutionMutations;
					if (!flag7)
					{
						break;
					}
					int num10 = random.Next(num4, num5 - 2);
					int num11 = random.Next(num10, num5);
					num7 += this.NodeSwapCostChange(array2, num10, num11);
					SolverTools.ApplyNodeSwap(array2, num10, num11);
					num8++;
					num6++;
					random = new Random(num6);
				}
				num3++;
			}
			while (num3 < this.Configuration.MaxIterations);
			return array;
		}

		// Token: 0x040069A1 RID: 27041
		private int? _startNodeIndex;

		// Token: 0x040069A2 RID: 27042
		private int? _endNodeIndex;

		// Token: 0x040069A3 RID: 27043
		private readonly int _nodeCount;

		// Token: 0x020012FA RID: 4858
		public class SolverConfiguration
		{
			// Token: 0x1700396C RID: 14700
			// (get) Token: 0x0600DED1 RID: 57041 RVA: 0x004C2CED File Offset: 0x004C0EED
			// (set) Token: 0x0600DED2 RID: 57042 RVA: 0x004C2CF5 File Offset: 0x004C0EF5
			public eFirstSolutionStrategy FirstSolutionStrategy { get; set; } = eFirstSolutionStrategy.NearestNeighbor;

			// Token: 0x1700396D RID: 14701
			// (get) Token: 0x0600DED3 RID: 57043 RVA: 0x004C2CFE File Offset: 0x004C0EFE
			// (set) Token: 0x0600DED4 RID: 57044 RVA: 0x004C2D06 File Offset: 0x004C0F06
			public int MaxIterations { get; set; } = 5000;

			// Token: 0x1700396E RID: 14702
			// (get) Token: 0x0600DED5 RID: 57045 RVA: 0x004C2D0F File Offset: 0x004C0F0F
			// (set) Token: 0x0600DED6 RID: 57046 RVA: 0x004C2D17 File Offset: 0x004C0F17
			public bool EnableSolutionMutation { get; set; } = true;

			// Token: 0x1700396F RID: 14703
			// (get) Token: 0x0600DED7 RID: 57047 RVA: 0x004C2D20 File Offset: 0x004C0F20
			// (set) Token: 0x0600DED8 RID: 57048 RVA: 0x004C2D28 File Offset: 0x004C0F28
			public int MaxSolutionMutations { get; set; } = 50;
		}
	}
}
