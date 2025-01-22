using System;

namespace WoW.Packets
{
	// Token: 0x020007BE RID: 1982
	public struct Optional<T> where T : new()
	{
		// Token: 0x170037CD RID: 14285
		// (get) Token: 0x0600B4EC RID: 46316 RVA: 0x002C2B4C File Offset: 0x002C0D4C
		// (set) Token: 0x0600B4ED RID: 46317 RVA: 0x002C2B64 File Offset: 0x002C0D64
		public bool HasValue
		{
			get
			{
				return this._hasValue;
			}
			set
			{
				this._hasValue = value;
				this.Value = (this._hasValue ? new T() : default(T));
			}
		}

		// Token: 0x0600B4EE RID: 46318 RVA: 0x002C2B97 File Offset: 0x002C0D97
		public void Set(T v)
		{
			this._hasValue = true;
			this.Value = v;
		}

		// Token: 0x0600B4EF RID: 46319 RVA: 0x002C2BA8 File Offset: 0x002C0DA8
		public void TrySet(object v)
		{
			this._hasValue = true;
			this.Value = (T)((object)v);
		}

		// Token: 0x0600B4F0 RID: 46320 RVA: 0x002C2BBE File Offset: 0x002C0DBE
		public void Clear()
		{
			this._hasValue = false;
			this.Value = default(T);
		}

		// Token: 0x0600B4F1 RID: 46321 RVA: 0x002C2BD4 File Offset: 0x002C0DD4
		public T ValueOr(T otherValue)
		{
			return this.HasValue ? this.Value : otherValue;
		}

		// Token: 0x0600B4F2 RID: 46322 RVA: 0x002C2BF8 File Offset: 0x002C0DF8
		public static explicit operator T(Optional<T> value)
		{
			return (T)value;
		}

		// Token: 0x0400598D RID: 22925
		private bool _hasValue;

		// Token: 0x0400598E RID: 22926
		public T Value;
	}
}
