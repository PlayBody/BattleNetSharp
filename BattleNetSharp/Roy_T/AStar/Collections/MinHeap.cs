using System;
using System.Collections.Generic;

namespace Roy_T.AStar.Collections
{
	// Token: 0x020008F1 RID: 2289
	internal sealed class MinHeap<T> where T : IComparable<T>
	{
		// Token: 0x0600B752 RID: 46930 RVA: 0x002D8519 File Offset: 0x002D6719
		public MinHeap()
		{
			this.Items = new List<T>();
		}

		// Token: 0x1700382C RID: 14380
		// (get) Token: 0x0600B753 RID: 46931 RVA: 0x002D852E File Offset: 0x002D672E
		public int Count
		{
			get
			{
				return this.Items.Count;
			}
		}

		// Token: 0x0600B754 RID: 46932 RVA: 0x002D853B File Offset: 0x002D673B
		public T Peek()
		{
			return this.Items[0];
		}

		// Token: 0x0600B755 RID: 46933 RVA: 0x002D8549 File Offset: 0x002D6749
		public void Insert(T item)
		{
			this.Items.Add(item);
			this.SortItem(item);
		}

		// Token: 0x0600B756 RID: 46934 RVA: 0x002D8564 File Offset: 0x002D6764
		public T Extract()
		{
			T t = this.Items[0];
			this.ReplaceFirstItemWithLastItem();
			this.Heapify(0);
			return t;
		}

		// Token: 0x0600B757 RID: 46935 RVA: 0x002D8594 File Offset: 0x002D6794
		public void Remove(T item)
		{
			bool flag = this.Count < 2;
			if (flag)
			{
				this.Clear();
			}
			else
			{
				int num = this.Items.IndexOf(item);
				bool flag2 = num >= 0;
				if (flag2)
				{
					this.Items[num] = this.Items[this.Items.Count - 1];
					this.Items.RemoveAt(this.Items.Count - 1);
					this.Heapify(0);
				}
			}
		}

		// Token: 0x0600B758 RID: 46936 RVA: 0x002D861C File Offset: 0x002D681C
		public void Clear()
		{
			this.Items.Clear();
		}

		// Token: 0x0600B759 RID: 46937 RVA: 0x002D862C File Offset: 0x002D682C
		private void ReplaceFirstItemWithLastItem()
		{
			this.Items[0] = this.Items[this.Items.Count - 1];
			this.Items.RemoveAt(this.Items.Count - 1);
		}

		// Token: 0x0600B75A RID: 46938 RVA: 0x002D8678 File Offset: 0x002D6878
		private void SortItem(T item)
		{
			int num = this.Items.Count - 1;
			while (MinHeap<T>.HasParent(num))
			{
				int parentIndex = MinHeap<T>.GetParentIndex(num);
				bool flag = MinHeap<T>.ItemAIsSmallerThanItemB(item, this.Items[parentIndex]);
				if (!flag)
				{
					break;
				}
				this.Items[num] = this.Items[parentIndex];
				num = parentIndex;
			}
			this.Items[num] = item;
		}

		// Token: 0x0600B75B RID: 46939 RVA: 0x002D86F0 File Offset: 0x002D68F0
		private void Heapify(int startIndex)
		{
			int num = startIndex;
			bool flag = this.HasLeftChild(startIndex);
			if (flag)
			{
				int leftChildIndex = MinHeap<T>.GetLeftChildIndex(startIndex);
				bool flag2 = MinHeap<T>.ItemAIsSmallerThanItemB(this.Items[leftChildIndex], this.Items[num]);
				if (flag2)
				{
					num = leftChildIndex;
				}
			}
			bool flag3 = this.HasRightChild(startIndex);
			if (flag3)
			{
				int rightChildIndex = MinHeap<T>.GetRightChildIndex(startIndex);
				bool flag4 = MinHeap<T>.ItemAIsSmallerThanItemB(this.Items[rightChildIndex], this.Items[num]);
				if (flag4)
				{
					num = rightChildIndex;
				}
			}
			bool flag5 = num != startIndex;
			if (flag5)
			{
				T t = this.Items[num];
				this.Items[num] = this.Items[startIndex];
				this.Items[startIndex] = t;
				this.Heapify(num);
			}
		}

		// Token: 0x0600B75C RID: 46940 RVA: 0x002D87C6 File Offset: 0x002D69C6
		private static bool ItemAIsSmallerThanItemB(T a, T b)
		{
			return a.CompareTo(b) < 0;
		}

		// Token: 0x0600B75D RID: 46941 RVA: 0x002D87D9 File Offset: 0x002D69D9
		private static bool HasParent(int index)
		{
			return index > 0;
		}

		// Token: 0x0600B75E RID: 46942 RVA: 0x002D87DF File Offset: 0x002D69DF
		private bool HasLeftChild(int index)
		{
			return MinHeap<T>.GetLeftChildIndex(index) < this.Items.Count;
		}

		// Token: 0x0600B75F RID: 46943 RVA: 0x002D87F4 File Offset: 0x002D69F4
		private bool HasRightChild(int index)
		{
			return MinHeap<T>.GetRightChildIndex(index) < this.Items.Count;
		}

		// Token: 0x0600B760 RID: 46944 RVA: 0x002D8809 File Offset: 0x002D6A09
		private static int GetParentIndex(int i)
		{
			return (i - 1) / 2;
		}

		// Token: 0x0600B761 RID: 46945 RVA: 0x002D8810 File Offset: 0x002D6A10
		private static int GetLeftChildIndex(int i)
		{
			return 2 * i + 1;
		}

		// Token: 0x0600B762 RID: 46946 RVA: 0x002D8817 File Offset: 0x002D6A17
		private static int GetRightChildIndex(int i)
		{
			return 2 * i + 2;
		}

		// Token: 0x040069DB RID: 27099
		private readonly List<T> Items;
	}
}
