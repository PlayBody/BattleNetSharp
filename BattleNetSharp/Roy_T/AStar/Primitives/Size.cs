using System;
using System.Runtime.CompilerServices;

namespace Roy_T.AStar.Primitives
{
	// Token: 0x020008E5 RID: 2277
	public struct Size : IEquatable<Size>
	{
		// Token: 0x0600B6EE RID: 46830 RVA: 0x002D71F4 File Offset: 0x002D53F4
		public Size(Distance width, Distance height)
		{
			this.Width = width;
			this.Height = height;
		}

		// Token: 0x1700380D RID: 14349
		// (get) Token: 0x0600B6EF RID: 46831 RVA: 0x002D7205 File Offset: 0x002D5405
		public readonly Distance Width { get; }

		// Token: 0x1700380E RID: 14350
		// (get) Token: 0x0600B6F0 RID: 46832 RVA: 0x002D720D File Offset: 0x002D540D
		public readonly Distance Height { get; }

		// Token: 0x0600B6F1 RID: 46833 RVA: 0x002D7215 File Offset: 0x002D5415
		public static bool operator ==(Size a, Size b)
		{
			return a.Equals(b);
		}

		// Token: 0x0600B6F2 RID: 46834 RVA: 0x002D721F File Offset: 0x002D541F
		public static bool operator !=(Size a, Size b)
		{
			return !a.Equals(b);
		}

		// Token: 0x0600B6F3 RID: 46835 RVA: 0x002D722C File Offset: 0x002D542C
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 2);
			defaultInterpolatedStringHandler.AppendLiteral("(width: ");
			defaultInterpolatedStringHandler.AppendFormatted<Distance>(this.Width);
			defaultInterpolatedStringHandler.AppendLiteral(", height: ");
			defaultInterpolatedStringHandler.AppendFormatted<Distance>(this.Height);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0600B6F4 RID: 46836 RVA: 0x002D7290 File Offset: 0x002D5490
		public override bool Equals(object obj)
		{
			bool flag;
			if (obj is Size)
			{
				Size size = (Size)obj;
				flag = this.Equals(size);
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x0600B6F5 RID: 46837 RVA: 0x002D72B6 File Offset: 0x002D54B6
		public bool Equals(Size other)
		{
			return this.Width == other.Width && this.Height == other.Height;
		}

		// Token: 0x0600B6F6 RID: 46838 RVA: 0x002D72E4 File Offset: 0x002D54E4
		public override int GetHashCode()
		{
			return -1609761766 + this.Width.GetHashCode() + this.Height.GetHashCode();
		}
	}
}
