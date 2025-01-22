using System;
using System.Collections.Generic;

namespace D2Map.Pathfinding
{
	// Token: 0x020008F8 RID: 2296
	internal static class SortedListExtensions
	{
		// Token: 0x0600B7D9 RID: 47065 RVA: 0x002DBF3C File Offset: 0x002DA13C
		internal static bool IsEmpty<TKey, TValue>(this SortedList<TKey, TValue> sortedList)
		{
			return sortedList.Count == 0;
		}

		// Token: 0x0600B7DA RID: 47066 RVA: 0x002DBF57 File Offset: 0x002DA157
		internal static void Add(this SortedList<int, Node> sortedList, Node node)
		{
			sortedList.Add(node.TotalCost, node);
		}

		// Token: 0x0600B7DB RID: 47067 RVA: 0x002DBF68 File Offset: 0x002DA168
		internal static Node Pop(this SortedList<int, Node> sortedList)
		{
			Node node = sortedList.Values[0];
			sortedList.RemoveAt(0);
			return node;
		}
	}
}
