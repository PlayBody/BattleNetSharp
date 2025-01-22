using System;

namespace D2Data
{
	// Token: 0x0200095C RID: 2396
	public class PerLevelStat : SignedStat
	{
		// Token: 0x0600B97F RID: 47487 RVA: 0x0037C2AE File Offset: 0x0037A4AE
		public PerLevelStat(BaseStat stat, int val)
			: base(stat, val)
		{
			this.PerLevel = (double)val / (double)(1 << stat.OpParam);
		}

		// Token: 0x0600B980 RID: 47488 RVA: 0x0037C2D0 File Offset: 0x0037A4D0
		public override string ToString()
		{
			return string.Format("+{0} To {1} Per Level", this.PerLevel, this.BaseStat.OpStat1);
		}

		// Token: 0x04007ECB RID: 32459
		public readonly double PerLevel;
	}
}
