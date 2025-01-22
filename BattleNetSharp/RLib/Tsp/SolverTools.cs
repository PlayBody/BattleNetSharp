using System;

namespace RLib.Tsp
{
	// Token: 0x020008D7 RID: 2263
	public static class SolverTools
	{
		// Token: 0x0600B67C RID: 46716 RVA: 0x002D64A8 File Offset: 0x002D46A8
		public static void ApplyNodeSwap(int[] route, int aIndex, int bIndex)
		{
			int num = bIndex - aIndex + 1;
			Array.Reverse<int>(route, aIndex, num);
		}

		// Token: 0x0600B67D RID: 46717 RVA: 0x002D64C8 File Offset: 0x002D46C8
		public static int[] GetRouteByNodeSwap(int[] route, int aIndex, int bIndex)
		{
			int[] array = new int[route.Length];
			int num = 4;
			int num2 = route.Length * num;
			Buffer.BlockCopy(route, 0, array, 0, num2);
			SolverTools.ApplyNodeSwap(array, aIndex, bIndex);
			return array;
		}
	}
}
