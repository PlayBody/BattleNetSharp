using System;
using System.Runtime.CompilerServices;

namespace Roy_T.AStar.Primitives
{
	// Token: 0x020008E2 RID: 2274
	public struct GridPosition : IEquatable<GridPosition>
	{
		// Token: 0x17003805 RID: 14341
		// (get) Token: 0x0600B6D0 RID: 46800 RVA: 0x002D6E91 File Offset: 0x002D5091
		public static GridPosition Zero
		{
			get
			{
				return new GridPosition(0, 0);
			}
		}

		// Token: 0x0600B6D1 RID: 46801 RVA: 0x002D6E9A File Offset: 0x002D509A
		public GridPosition(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}

		// Token: 0x17003806 RID: 14342
		// (get) Token: 0x0600B6D2 RID: 46802 RVA: 0x002D6EAB File Offset: 0x002D50AB
		public readonly int X { get; }

		// Token: 0x17003807 RID: 14343
		// (get) Token: 0x0600B6D3 RID: 46803 RVA: 0x002D6EB3 File Offset: 0x002D50B3
		public readonly int Y { get; }

		// Token: 0x0600B6D4 RID: 46804 RVA: 0x002D6EBB File Offset: 0x002D50BB
		public static bool operator ==(GridPosition a, GridPosition b)
		{
			return a.Equals(b);
		}

		// Token: 0x0600B6D5 RID: 46805 RVA: 0x002D6EC5 File Offset: 0x002D50C5
		public static bool operator !=(GridPosition a, GridPosition b)
		{
			return !a.Equals(b);
		}

		// Token: 0x0600B6D6 RID: 46806 RVA: 0x002D6ED4 File Offset: 0x002D50D4
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 2);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.X);
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Y);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0600B6D7 RID: 46807 RVA: 0x002D6F34 File Offset: 0x002D5134
		public override bool Equals(object obj)
		{
			bool flag;
			if (obj is GridPosition)
			{
				GridPosition gridPosition = (GridPosition)obj;
				flag = this.Equals(gridPosition);
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x0600B6D8 RID: 46808 RVA: 0x002D6F5A File Offset: 0x002D515A
		public bool Equals(GridPosition other)
		{
			return this.X == other.X && this.Y == other.Y;
		}

		// Token: 0x0600B6D9 RID: 46809 RVA: 0x002D6F7D File Offset: 0x002D517D
		public override int GetHashCode()
		{
			return -1609761766 + this.X + this.Y;
		}
	}
}
