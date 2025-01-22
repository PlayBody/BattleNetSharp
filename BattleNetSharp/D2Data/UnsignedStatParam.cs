using System;

namespace D2Data
{
	// Token: 0x02000981 RID: 2433
	public class UnsignedStatParam : UnsignedStat
	{
		// Token: 0x0600B9B0 RID: 47536 RVA: 0x0037D619 File Offset: 0x0037B819
		public UnsignedStatParam(BaseStat stat, uint val, uint param)
			: base(stat, val)
		{
			this.Param = param;
		}

		// Token: 0x0600B9B1 RID: 47537 RVA: 0x0037D62C File Offset: 0x0037B82C
		public override string ToString()
		{
			return string.Format("{0}: {1}, {2}", this.BaseStat, this.Value, this.Param);
		}

		// Token: 0x040085BD RID: 34237
		public readonly uint Param;
	}
}
