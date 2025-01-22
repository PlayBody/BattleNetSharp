using System;
using System.Runtime.CompilerServices;

namespace Roy_T.AStar.Primitives
{
	// Token: 0x020008E1 RID: 2273
	public struct Duration : IComparable<Duration>, IEquatable<Duration>
	{
		// Token: 0x17003803 RID: 14339
		// (get) Token: 0x0600B6BF RID: 46783 RVA: 0x002D6D1D File Offset: 0x002D4F1D
		public static Duration Zero
		{
			get
			{
				return new Duration(0f);
			}
		}

		// Token: 0x0600B6C0 RID: 46784 RVA: 0x002D6D29 File Offset: 0x002D4F29
		private Duration(float seconds)
		{
			this.Seconds = seconds;
		}

		// Token: 0x17003804 RID: 14340
		// (get) Token: 0x0600B6C1 RID: 46785 RVA: 0x002D6D33 File Offset: 0x002D4F33
		public readonly float Seconds { get; }

		// Token: 0x0600B6C2 RID: 46786 RVA: 0x002D6D3B File Offset: 0x002D4F3B
		public static Duration FromSeconds(float seconds)
		{
			return new Duration(seconds);
		}

		// Token: 0x0600B6C3 RID: 46787 RVA: 0x002D6D43 File Offset: 0x002D4F43
		public static Duration operator +(Duration a, Duration b)
		{
			return new Duration(a.Seconds + b.Seconds);
		}

		// Token: 0x0600B6C4 RID: 46788 RVA: 0x002D6D59 File Offset: 0x002D4F59
		public static Duration operator -(Duration a, Duration b)
		{
			return new Duration(a.Seconds - b.Seconds);
		}

		// Token: 0x0600B6C5 RID: 46789 RVA: 0x002D6D6F File Offset: 0x002D4F6F
		public static bool operator >(Duration a, Duration b)
		{
			return a.Seconds > b.Seconds;
		}

		// Token: 0x0600B6C6 RID: 46790 RVA: 0x002D6D81 File Offset: 0x002D4F81
		public static bool operator <(Duration a, Duration b)
		{
			return a.Seconds < b.Seconds;
		}

		// Token: 0x0600B6C7 RID: 46791 RVA: 0x002D6D93 File Offset: 0x002D4F93
		public static bool operator >=(Duration a, Duration b)
		{
			return a.Seconds >= b.Seconds;
		}

		// Token: 0x0600B6C8 RID: 46792 RVA: 0x002D6DA8 File Offset: 0x002D4FA8
		public static bool operator <=(Duration a, Duration b)
		{
			return a.Seconds <= b.Seconds;
		}

		// Token: 0x0600B6C9 RID: 46793 RVA: 0x002D6DBD File Offset: 0x002D4FBD
		public static bool operator ==(Duration a, Duration b)
		{
			return a.Equals(b);
		}

		// Token: 0x0600B6CA RID: 46794 RVA: 0x002D6DC7 File Offset: 0x002D4FC7
		public static bool operator !=(Duration a, Duration b)
		{
			return !a.Equals(b);
		}

		// Token: 0x0600B6CB RID: 46795 RVA: 0x002D6DD4 File Offset: 0x002D4FD4
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Seconds, "F2");
			defaultInterpolatedStringHandler.AppendLiteral("s");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0600B6CC RID: 46796 RVA: 0x002D6E14 File Offset: 0x002D5014
		public override bool Equals(object obj)
		{
			bool flag;
			if (obj is Duration)
			{
				Duration duration = (Duration)obj;
				flag = this.Equals(duration);
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x0600B6CD RID: 46797 RVA: 0x002D6E3A File Offset: 0x002D503A
		public bool Equals(Duration other)
		{
			return this.Seconds == other.Seconds;
		}

		// Token: 0x0600B6CE RID: 46798 RVA: 0x002D6E4C File Offset: 0x002D504C
		public int CompareTo(Duration other)
		{
			return this.Seconds.CompareTo(other.Seconds);
		}

		// Token: 0x0600B6CF RID: 46799 RVA: 0x002D6E70 File Offset: 0x002D5070
		public override int GetHashCode()
		{
			return -1609761766 + this.Seconds.GetHashCode();
		}
	}
}
