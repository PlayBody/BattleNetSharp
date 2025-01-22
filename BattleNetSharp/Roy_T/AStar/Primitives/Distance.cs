using System;
using System.Runtime.CompilerServices;

namespace Roy_T.AStar.Primitives
{
	// Token: 0x020008E0 RID: 2272
	public struct Distance : IComparable<Distance>, IEquatable<Distance>
	{
		// Token: 0x17003801 RID: 14337
		// (get) Token: 0x0600B6AA RID: 46762 RVA: 0x002D6B19 File Offset: 0x002D4D19
		public static Distance Zero
		{
			get
			{
				return new Distance(0f);
			}
		}

		// Token: 0x0600B6AB RID: 46763 RVA: 0x002D6B25 File Offset: 0x002D4D25
		private Distance(float meters)
		{
			this.Meters = meters;
		}

		// Token: 0x17003802 RID: 14338
		// (get) Token: 0x0600B6AC RID: 46764 RVA: 0x002D6B2F File Offset: 0x002D4D2F
		public readonly float Meters { get; }

		// Token: 0x0600B6AD RID: 46765 RVA: 0x002D6B37 File Offset: 0x002D4D37
		public static Distance FromMeters(float meters)
		{
			return new Distance(meters);
		}

		// Token: 0x0600B6AE RID: 46766 RVA: 0x002D6B40 File Offset: 0x002D4D40
		public static Distance BeweenPositions(Position a, Position b)
		{
			float x = a.X;
			float y = a.Y;
			float x2 = b.X;
			float y2 = b.Y;
			float num = (x2 - x) * (x2 - x);
			float num2 = (y2 - y) * (y2 - y);
			return Distance.FromMeters((float)Math.Sqrt((double)(num + num2)));
		}

		// Token: 0x0600B6AF RID: 46767 RVA: 0x002D6B97 File Offset: 0x002D4D97
		public static Distance operator +(Distance a, Distance b)
		{
			return new Distance(a.Meters + b.Meters);
		}

		// Token: 0x0600B6B0 RID: 46768 RVA: 0x002D6BAD File Offset: 0x002D4DAD
		public static Distance operator -(Distance a, Distance b)
		{
			return new Distance(a.Meters - b.Meters);
		}

		// Token: 0x0600B6B1 RID: 46769 RVA: 0x002D6BC3 File Offset: 0x002D4DC3
		public static Distance operator *(Distance a, float b)
		{
			return new Distance(a.Meters * b);
		}

		// Token: 0x0600B6B2 RID: 46770 RVA: 0x002D6BD3 File Offset: 0x002D4DD3
		public static Distance operator /(Distance a, float b)
		{
			return new Distance(a.Meters / b);
		}

		// Token: 0x0600B6B3 RID: 46771 RVA: 0x002D6BE3 File Offset: 0x002D4DE3
		public static bool operator >(Distance a, Distance b)
		{
			return a.Meters > b.Meters;
		}

		// Token: 0x0600B6B4 RID: 46772 RVA: 0x002D6BF5 File Offset: 0x002D4DF5
		public static bool operator <(Distance a, Distance b)
		{
			return a.Meters < b.Meters;
		}

		// Token: 0x0600B6B5 RID: 46773 RVA: 0x002D6C07 File Offset: 0x002D4E07
		public static bool operator >=(Distance a, Distance b)
		{
			return a.Meters >= b.Meters;
		}

		// Token: 0x0600B6B6 RID: 46774 RVA: 0x002D6C1C File Offset: 0x002D4E1C
		public static bool operator <=(Distance a, Distance b)
		{
			return a.Meters <= b.Meters;
		}

		// Token: 0x0600B6B7 RID: 46775 RVA: 0x002D6C31 File Offset: 0x002D4E31
		public static bool operator ==(Distance a, Distance b)
		{
			return a.Equals(b);
		}

		// Token: 0x0600B6B8 RID: 46776 RVA: 0x002D6C3B File Offset: 0x002D4E3B
		public static bool operator !=(Distance a, Distance b)
		{
			return !a.Equals(b);
		}

		// Token: 0x0600B6B9 RID: 46777 RVA: 0x002D6C48 File Offset: 0x002D4E48
		public static Duration operator /(Distance distance, Velocity velocity)
		{
			return Duration.FromSeconds(distance.Meters / velocity.MetersPerSecond);
		}

		// Token: 0x0600B6BA RID: 46778 RVA: 0x002D6C60 File Offset: 0x002D4E60
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Meters, "F2");
			defaultInterpolatedStringHandler.AppendLiteral("m");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0600B6BB RID: 46779 RVA: 0x002D6CA0 File Offset: 0x002D4EA0
		public override bool Equals(object obj)
		{
			bool flag;
			if (obj is Distance)
			{
				Distance distance = (Distance)obj;
				flag = this.Equals(distance);
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x0600B6BC RID: 46780 RVA: 0x002D6CC6 File Offset: 0x002D4EC6
		public bool Equals(Distance other)
		{
			return this.Meters == other.Meters;
		}

		// Token: 0x0600B6BD RID: 46781 RVA: 0x002D6CD8 File Offset: 0x002D4ED8
		public int CompareTo(Distance other)
		{
			return this.Meters.CompareTo(other.Meters);
		}

		// Token: 0x0600B6BE RID: 46782 RVA: 0x002D6CFC File Offset: 0x002D4EFC
		public override int GetHashCode()
		{
			return -1609761766 + this.Meters.GetHashCode();
		}
	}
}
