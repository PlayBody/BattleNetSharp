using System;

namespace D2Data
{
	// Token: 0x02000969 RID: 2409
	public class SignedStat : StatBase
	{
		// Token: 0x0600B98A RID: 47498 RVA: 0x0037C4DA File Offset: 0x0037A6DA
		public SignedStat(BaseStat stat, int val)
			: base(stat)
		{
			this.Value = val;
		}

		// Token: 0x0600B98B RID: 47499 RVA: 0x0037C4EC File Offset: 0x0037A6EC
		public override string ToString()
		{
			return string.Format(((this.Value > 0) ? "+" : "") + "{1} {0}", this.BaseStat, this.Value);
		}

		// Token: 0x0400804D RID: 32845
		public int Value;
	}
}
