using System;

namespace WoW.Entities
{
	// Token: 0x020007BB RID: 1979
	public struct ObjectGuid : IEquatable<ObjectGuid>
	{
		// Token: 0x0600B4E7 RID: 46311 RVA: 0x002C2B13 File Offset: 0x002C0D13
		public ObjectGuid(ulong high, ulong low)
		{
			this._low = low;
			this._high = high;
		}

		// Token: 0x0600B4E8 RID: 46312 RVA: 0x002C2B24 File Offset: 0x002C0D24
		public bool Equals(ObjectGuid other)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0400598A RID: 22922
		public static ObjectGuid Empty = default(ObjectGuid);

		// Token: 0x0400598B RID: 22923
		private ulong _low;

		// Token: 0x0400598C RID: 22924
		private ulong _high;
	}
}
