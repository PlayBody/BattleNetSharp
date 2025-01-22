using System;

namespace D4.Map
{
	// Token: 0x020008C5 RID: 2245
	public class NodeHeap
	{
		// Token: 0x170037E4 RID: 14308
		// (get) Token: 0x0600B623 RID: 46627 RVA: 0x002C6584 File Offset: 0x002C4784
		public int Count
		{
			get
			{
				return this.tail;
			}
		}

		// Token: 0x0600B624 RID: 46628 RVA: 0x002C659C File Offset: 0x002C479C
		public NodeHeap(int capacity = 4)
		{
			this.capacity = capacity;
			this.items = new Node[capacity];
		}

		// Token: 0x0600B625 RID: 46629 RVA: 0x002C65C0 File Offset: 0x002C47C0
		private void Grow()
		{
			int num = this.capacity * 2;
			Node[] array = new Node[num];
			Array.Copy(this.items, array, this.capacity);
			this.items = array;
			this.capacity = num;
		}

		// Token: 0x0600B626 RID: 46630 RVA: 0x002C6600 File Offset: 0x002C4800
		public void Add(Node item)
		{
			bool flag = this.Count == this.capacity;
			if (flag)
			{
				this.Grow();
			}
			item.lastHeapIndex = this.tail;
			Node[] array = this.items;
			int num = this.tail;
			this.tail = num + 1;
			array[num] = item;
			this.SortUp(item);
		}

		// Token: 0x0600B627 RID: 46631 RVA: 0x002C6654 File Offset: 0x002C4854
		public Node Pop()
		{
			bool flag = this.Count == 0;
			if (flag)
			{
				throw new InvalidOperationException("NodeHeap is empty");
			}
			Node node = this.items[0];
			Node[] array = this.items;
			int num = 0;
			Node[] array2 = this.items;
			int num2 = this.tail - 1;
			this.tail = num2;
			array[num] = array2[num2];
			this.items[0].lastHeapIndex = 0;
			this.SortDown(this.items[0]);
			return node;
		}

		// Token: 0x0600B628 RID: 46632 RVA: 0x002C66C5 File Offset: 0x002C48C5
		public void UpdateItem(Node item)
		{
			this.SortUp(item);
		}

		// Token: 0x0600B629 RID: 46633 RVA: 0x002C66D0 File Offset: 0x002C48D0
		public bool Contains(Node item)
		{
			bool flag = item.lastHeapIndex >= this.tail;
			return !flag && this.items[item.lastHeapIndex] == item;
		}

		// Token: 0x0600B62A RID: 46634 RVA: 0x002C670C File Offset: 0x002C490C
		private void SortDown(Node item)
		{
			for (;;)
			{
				int num = item.lastHeapIndex * 2 + 1;
				int num2 = item.lastHeapIndex * 2 + 2;
				bool flag = num < this.tail;
				if (!flag)
				{
					break;
				}
				int num3 = num;
				bool flag2 = num2 < this.tail;
				if (flag2)
				{
					bool flag3 = this.items[num].CompareTo(this.items[num2]) < 0;
					if (flag3)
					{
						num3 = num2;
					}
				}
				bool flag4 = item.CompareTo(this.items[num3]) < 0;
				if (!flag4)
				{
					break;
				}
				this.Swap(item, this.items[num3]);
			}
		}

		// Token: 0x0600B62B RID: 46635 RVA: 0x002C67B8 File Offset: 0x002C49B8
		private void SortUp(Node item)
		{
			int num = (item.lastHeapIndex - 1) / 2;
			for (;;)
			{
				Node node = this.items[num];
				bool flag = item.CompareTo(node) > 0;
				if (!flag)
				{
					break;
				}
				this.Swap(item, node);
				num = (item.lastHeapIndex - 1) / 2;
			}
		}

		// Token: 0x0600B62C RID: 46636 RVA: 0x002C680C File Offset: 0x002C4A0C
		private void Swap(Node a, Node b)
		{
			this.items[a.lastHeapIndex] = b;
			this.items[b.lastHeapIndex] = a;
			int lastHeapIndex = a.lastHeapIndex;
			a.lastHeapIndex = b.lastHeapIndex;
			b.lastHeapIndex = lastHeapIndex;
		}

		// Token: 0x0400652D RID: 25901
		private Node[] items;

		// Token: 0x0400652E RID: 25902
		private int tail = 0;

		// Token: 0x0400652F RID: 25903
		private int capacity;
	}
}
