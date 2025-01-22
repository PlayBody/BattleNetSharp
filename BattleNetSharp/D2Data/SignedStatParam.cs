using System;

namespace D2Data
{
	// Token: 0x0200096A RID: 2410
	public class SignedStatParam : SignedStat
	{
		// Token: 0x0600B98C RID: 47500 RVA: 0x0037C533 File Offset: 0x0037A733
		public SignedStatParam(BaseStat stat, int val, int param)
			: base(stat, val)
		{
			this.Param = param;
		}

		// Token: 0x0600B98D RID: 47501 RVA: 0x0037C548 File Offset: 0x0037A748
		public override string ToString()
		{
			return string.Format("+{1} {0}", this.BaseStat, this.Value);
		}

		// Token: 0x0400804E RID: 32846
		public readonly int Param;
	}
}
