using System;

namespace D2Data
{
	// Token: 0x02000980 RID: 2432
	public class UnsignedStat : StatBase
	{
		// Token: 0x0600B9AE RID: 47534 RVA: 0x0037D5DA File Offset: 0x0037B7DA
		public UnsignedStat(BaseStat stat, uint val)
			: base(stat)
		{
			this.Value = val;
		}

		// Token: 0x0600B9AF RID: 47535 RVA: 0x0037D5EC File Offset: 0x0037B7EC
		public override string ToString()
		{
			return string.Format("+{1} {0}", this.BaseStat, this.Value);
		}

		// Token: 0x040085BC RID: 34236
		public uint Value;
	}
}
