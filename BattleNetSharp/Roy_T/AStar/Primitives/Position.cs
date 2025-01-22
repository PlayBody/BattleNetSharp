using System;
using System.Runtime.CompilerServices;

namespace Roy_T.AStar.Primitives
{
	// Token: 0x020008E4 RID: 2276
	public struct Position : IEquatable<Position>
	{
		// Token: 0x1700380A RID: 14346
		// (get) Token: 0x0600B6E3 RID: 46819 RVA: 0x002D70AC File Offset: 0x002D52AC
		public static Position Zero
		{
			get
			{
				return new Position(0f, 0f);
			}
		}

		// Token: 0x0600B6E4 RID: 46820 RVA: 0x002D70BD File Offset: 0x002D52BD
		public Position(float x, float y)
		{
			this.X = x;
			this.Y = y;
		}

		// Token: 0x0600B6E5 RID: 46821 RVA: 0x002D70CE File Offset: 0x002D52CE
		public static Position FromOffset(Distance xDistanceFromOrigin, Distance yDistanceFromOrigin)
		{
			return new Position(xDistanceFromOrigin.Meters, yDistanceFromOrigin.Meters);
		}

		// Token: 0x1700380B RID: 14347
		// (get) Token: 0x0600B6E6 RID: 46822 RVA: 0x002D70E3 File Offset: 0x002D52E3
		public readonly float X { get; }

		// Token: 0x1700380C RID: 14348
		// (get) Token: 0x0600B6E7 RID: 46823 RVA: 0x002D70EB File Offset: 0x002D52EB
		public readonly float Y { get; }

		// Token: 0x0600B6E8 RID: 46824 RVA: 0x002D70F3 File Offset: 0x002D52F3
		public static bool operator ==(Position a, Position b)
		{
			return a.Equals(b);
		}

		// Token: 0x0600B6E9 RID: 46825 RVA: 0x002D70FD File Offset: 0x002D52FD
		public static bool operator !=(Position a, Position b)
		{
			return !a.Equals(b);
		}

		// Token: 0x0600B6EA RID: 46826 RVA: 0x002D710C File Offset: 0x002D530C
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 2);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.X, "F2");
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Y, "F2");
			defaultInterpolatedStringHandler.AppendLiteral(")");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0600B6EB RID: 46827 RVA: 0x002D7178 File Offset: 0x002D5378
		public override bool Equals(object obj)
		{
			bool flag;
			if (obj is Position)
			{
				Position position = (Position)obj;
				flag = this.Equals(position);
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x0600B6EC RID: 46828 RVA: 0x002D719E File Offset: 0x002D539E
		public bool Equals(Position other)
		{
			return this.X == other.X && this.Y == other.Y;
		}

		// Token: 0x0600B6ED RID: 46829 RVA: 0x002D71C4 File Offset: 0x002D53C4
		public override int GetHashCode()
		{
			return -1609761766 + this.X.GetHashCode() + this.Y.GetHashCode();
		}
	}
}
