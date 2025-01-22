using System;
using System.Runtime.CompilerServices;

namespace Roy_T.AStar.Primitives
{
	// Token: 0x020008E6 RID: 2278
	public struct Velocity : IComparable<Velocity>, IEquatable<Velocity>
	{
		// Token: 0x0600B6F7 RID: 46839 RVA: 0x002D7320 File Offset: 0x002D5520
		private Velocity(float metersPerSecond)
		{
			this.MetersPerSecond = metersPerSecond;
		}

		// Token: 0x1700380F RID: 14351
		// (get) Token: 0x0600B6F8 RID: 46840 RVA: 0x002D732A File Offset: 0x002D552A
		public readonly float MetersPerSecond { get; }

		// Token: 0x17003810 RID: 14352
		// (get) Token: 0x0600B6F9 RID: 46841 RVA: 0x002D7332 File Offset: 0x002D5532
		public float KilometersPerHour
		{
			get
			{
				return this.MetersPerSecond * 3.6f;
			}
		}

		// Token: 0x0600B6FA RID: 46842 RVA: 0x002D7340 File Offset: 0x002D5540
		public static Velocity FromMetersPerSecond(float metersPerSecond)
		{
			return new Velocity(metersPerSecond);
		}

		// Token: 0x0600B6FB RID: 46843 RVA: 0x002D7348 File Offset: 0x002D5548
		public static Velocity FromKilometersPerHour(float kilometersPerHour)
		{
			return new Velocity(kilometersPerHour / 3.6f);
		}

		// Token: 0x0600B6FC RID: 46844 RVA: 0x002D7356 File Offset: 0x002D5556
		public static Velocity operator +(Velocity a, Velocity b)
		{
			return new Velocity(a.MetersPerSecond + b.MetersPerSecond);
		}

		// Token: 0x0600B6FD RID: 46845 RVA: 0x002D736C File Offset: 0x002D556C
		public static Velocity operator -(Velocity a, Velocity b)
		{
			return new Velocity(a.MetersPerSecond - b.MetersPerSecond);
		}

		// Token: 0x0600B6FE RID: 46846 RVA: 0x002D7382 File Offset: 0x002D5582
		public static bool operator >(Velocity a, Velocity b)
		{
			return a.MetersPerSecond > b.MetersPerSecond;
		}

		// Token: 0x0600B6FF RID: 46847 RVA: 0x002D7394 File Offset: 0x002D5594
		public static bool operator <(Velocity a, Velocity b)
		{
			return a.MetersPerSecond < b.MetersPerSecond;
		}

		// Token: 0x0600B700 RID: 46848 RVA: 0x002D73A6 File Offset: 0x002D55A6
		public static bool operator >=(Velocity a, Velocity b)
		{
			return a.MetersPerSecond >= b.MetersPerSecond;
		}

		// Token: 0x0600B701 RID: 46849 RVA: 0x002D73BB File Offset: 0x002D55BB
		public static bool operator <=(Velocity a, Velocity b)
		{
			return a.MetersPerSecond <= b.MetersPerSecond;
		}

		// Token: 0x0600B702 RID: 46850 RVA: 0x002D73D0 File Offset: 0x002D55D0
		public static bool operator ==(Velocity a, Velocity b)
		{
			return a.Equals(b);
		}

		// Token: 0x0600B703 RID: 46851 RVA: 0x002D73DA File Offset: 0x002D55DA
		public static bool operator !=(Velocity a, Velocity b)
		{
			return !a.Equals(b);
		}

		// Token: 0x0600B704 RID: 46852 RVA: 0x002D73E8 File Offset: 0x002D55E8
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 1);
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.MetersPerSecond, "F2");
			defaultInterpolatedStringHandler.AppendLiteral(" m/s");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0600B705 RID: 46853 RVA: 0x002D7428 File Offset: 0x002D5628
		public override bool Equals(object obj)
		{
			bool flag;
			if (obj is Velocity)
			{
				Velocity velocity = (Velocity)obj;
				flag = this.MetersPerSecond == velocity.MetersPerSecond;
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x0600B706 RID: 46854 RVA: 0x002D7456 File Offset: 0x002D5656
		public bool Equals(Velocity other)
		{
			return this.MetersPerSecond == other.MetersPerSecond;
		}

		// Token: 0x0600B707 RID: 46855 RVA: 0x002D7468 File Offset: 0x002D5668
		public int CompareTo(Velocity other)
		{
			return this.MetersPerSecond.CompareTo(other.MetersPerSecond);
		}

		// Token: 0x0600B708 RID: 46856 RVA: 0x002D748C File Offset: 0x002D568C
		public override int GetHashCode()
		{
			return -1419927970 + this.MetersPerSecond.GetHashCode();
		}
	}
}
