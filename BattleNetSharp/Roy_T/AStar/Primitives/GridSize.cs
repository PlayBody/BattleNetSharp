using System;
using System.Runtime.CompilerServices;

namespace Roy_T.AStar.Primitives
{
	// Token: 0x020008E3 RID: 2275
	public struct GridSize : IEquatable<GridSize>
	{
		// Token: 0x0600B6DA RID: 46810 RVA: 0x002D6F92 File Offset: 0x002D5192
		public GridSize(int columns, int rows)
		{
			this.Columns = columns;
			this.Rows = rows;
		}

		// Token: 0x17003808 RID: 14344
		// (get) Token: 0x0600B6DB RID: 46811 RVA: 0x002D6FA3 File Offset: 0x002D51A3
		public readonly int Columns { get; }

		// Token: 0x17003809 RID: 14345
		// (get) Token: 0x0600B6DC RID: 46812 RVA: 0x002D6FAB File Offset: 0x002D51AB
		public readonly int Rows { get; }

		// Token: 0x0600B6DD RID: 46813 RVA: 0x002D6FB3 File Offset: 0x002D51B3
		public static bool operator ==(GridSize a, GridSize b)
		{
			return a.Equals(b);
		}

		// Token: 0x0600B6DE RID: 46814 RVA: 0x002D6FBD File Offset: 0x002D51BD
		public static bool operator !=(GridSize a, GridSize b)
		{
			return !a.Equals(b);
		}

		// Token: 0x0600B6DF RID: 46815 RVA: 0x002D6FCC File Offset: 0x002D51CC
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 2);
			defaultInterpolatedStringHandler.AppendLiteral("(columns: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Columns);
			defaultInterpolatedStringHandler.AppendLiteral(", rows: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Rows);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0600B6E0 RID: 46816 RVA: 0x002D7030 File Offset: 0x002D5230
		public override bool Equals(object obj)
		{
			bool flag;
			if (obj is GridSize)
			{
				GridSize gridSize = (GridSize)obj;
				flag = this.Equals(gridSize);
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x0600B6E1 RID: 46817 RVA: 0x002D7056 File Offset: 0x002D5256
		public bool Equals(GridSize other)
		{
			return this.Columns == other.Columns && this.Rows == other.Rows;
		}

		// Token: 0x0600B6E2 RID: 46818 RVA: 0x002D707C File Offset: 0x002D527C
		public override int GetHashCode()
		{
			return -1609761766 + this.Columns.GetHashCode() + this.Rows.GetHashCode();
		}
	}
}
