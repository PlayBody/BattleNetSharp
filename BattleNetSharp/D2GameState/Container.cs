using System;
using System.Collections.Generic;
using System.Linq;
using D2Data;
using D2Packets.Game.Server;

namespace D2GameState
{
	// Token: 0x0200090A RID: 2314
	public static class Container
	{
		// Token: 0x0600B860 RID: 47200 RVA: 0x002DD9C8 File Offset: 0x002DBBC8
		public static WorldItemAction GetItem(this List<WorldItemAction> items, ushort x, ushort y, ItemContainer container)
		{
			List<WorldItemAction> list = items.ToArray().ToList<WorldItemAction>();
			return list.FirstOrDefault((WorldItemAction i) => i.container == container && i.x == (int)x && i.y == (int)y);
		}

		// Token: 0x0600B861 RID: 47201 RVA: 0x002DDA14 File Offset: 0x002DBC14
		public static Tuple<ushort, ushort> GetContainerSize(this ItemContainer container)
		{
			ushort num = 0;
			ushort num2 = 0;
			bool flag = container == ItemContainer.Inventory;
			if (flag)
			{
				num = 10;
				num2 = 4;
			}
			bool flag2 = container == ItemContainer.Stash;
			if (flag2)
			{
				num = 10;
				num2 = 10;
			}
			return new Tuple<ushort, ushort>(num, num2);
		}

		// Token: 0x0600B862 RID: 47202 RVA: 0x002DDA54 File Offset: 0x002DBC54
		public static List<ItemAction> GetItems(this ItemContainer container, List<ItemAction> items)
		{
			return items.FindAll((ItemAction i) => i.container == container);
		}

		// Token: 0x0600B863 RID: 47203 RVA: 0x002DDA88 File Offset: 0x002DBC88
		public static ushort GetFreeSpace(this ItemContainer container, List<ItemAction> items, out bool[,] freeSpace)
		{
			Tuple<ushort, ushort> containerSize = container.GetContainerSize();
			ushort item = containerSize.Item1;
			ushort item2 = containerSize.Item2;
			List<ItemAction> items2 = container.GetItems(items);
			IEnumerable<int[]> enumerable = items2.Select((ItemAction i) => new int[]
			{
				i.x,
				i.y,
				i.baseItem.InvWidth,
				i.baseItem.InvHeight
			});
			freeSpace = new bool[(int)item, (int)item2];
			for (int i2 = 0; i2 < (int)item; i2++)
			{
				for (int j = 0; j < (int)item2; j++)
				{
					freeSpace[i2, j] = true;
				}
			}
			foreach (int[] array in enumerable)
			{
				for (int k = 0; k < array[2]; k++)
				{
					for (int l = 0; l < array[3]; l++)
					{
						freeSpace[array[0] + k, array[1] + l] = false;
					}
				}
			}
			int num = 0;
			for (int m = 0; m < (int)item; m++)
			{
				for (int n = 0; n < (int)item2; n++)
				{
					bool flag = freeSpace[m, n];
					if (flag)
					{
						num++;
					}
				}
			}
			return (ushort)num;
		}

		// Token: 0x0600B864 RID: 47204 RVA: 0x002DDBF0 File Offset: 0x002DBDF0
		public static ValueTuple<ushort, ushort> GetAvailableLocation(this ItemContainer container, List<ItemAction> items, ItemAction item)
		{
			bool[,] array;
			container.GetFreeSpace(items, out array);
			Tuple<ushort, ushort> containerSize = container.GetContainerSize();
			ushort item2 = containerSize.Item1;
			ushort item3 = containerSize.Item2;
			for (int i = 0; i < (int)item2; i += 2)
			{
				for (int j = 0; j < (int)item3; j++)
				{
					for (int k = i; k < i + 2; k += item.baseItem.InvWidth)
					{
						bool flag = item.Fits((ushort)k, (ushort)j, array);
						if (flag)
						{
							return new ValueTuple<ushort, ushort>((ushort)k, (ushort)j);
						}
					}
				}
			}
			return new ValueTuple<ushort, ushort>(ushort.MaxValue, ushort.MaxValue);
		}

		// Token: 0x0600B865 RID: 47205 RVA: 0x002DDCA4 File Offset: 0x002DBEA4
		public static bool Fits(this ItemAction item, ushort x, ushort y, bool[,] freeSpace)
		{
			for (int i = 0; i < item.baseItem.InvWidth; i++)
			{
				for (int j = 0; j < item.baseItem.InvHeight; j++)
				{
					bool flag = freeSpace.GetLength(0) <= (int)x + i || freeSpace.GetLength(1) <= (int)y + j || !freeSpace[(int)x + i, (int)y + j];
					if (flag)
					{
						return false;
					}
				}
			}
			return true;
		}
	}
}
