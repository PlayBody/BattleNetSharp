using System;
using System.Collections.Generic;

namespace D2Map.Pathfinding
{
	// Token: 0x020008F9 RID: 2297
	internal class DuplicateComparer : IComparer<int>
	{
		// Token: 0x0600B7DC RID: 47068 RVA: 0x002DBF90 File Offset: 0x002DA190
		public int Compare(int x, int y)
		{
			return (x <= y) ? (-1) : 1;
		}
	}
}
