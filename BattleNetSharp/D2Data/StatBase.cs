using System;

namespace D2Data
{
	// Token: 0x02000974 RID: 2420
	public class StatBase
	{
		// Token: 0x0600B9A1 RID: 47521 RVA: 0x0037CF8E File Offset: 0x0037B18E
		public StatBase(BaseStat stat)
		{
			this.BaseStat = stat;
		}

		// Token: 0x0600B9A2 RID: 47522 RVA: 0x0037CFA0 File Offset: 0x0037B1A0
		public override string ToString()
		{
			return this.BaseStat.ToString();
		}

		// Token: 0x0600B9A3 RID: 47523 RVA: 0x0037CFC0 File Offset: 0x0037B1C0
		public StatBase Clone()
		{
			return new StatBase(this.BaseStat);
		}

		// Token: 0x040081DB RID: 33243
		public BaseStat BaseStat;
	}
}
