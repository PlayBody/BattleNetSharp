using System;

namespace D2Data
{
	// Token: 0x02000966 RID: 2406
	public class ReplenishStat : SignedStat
	{
		// Token: 0x0600B988 RID: 47496 RVA: 0x0037C46B File Offset: 0x0037A66B
		public ReplenishStat(BaseStat stat, int val)
			: base(stat, val)
		{
			this.Seconds = 100 / val;
		}

		// Token: 0x0600B989 RID: 47497 RVA: 0x0037C484 File Offset: 0x0037A684
		public override string ToString()
		{
			bool flag = this.BaseStat.Type == StatType.ReplenishQuantity;
			string text;
			if (flag)
			{
				text = string.Format("Replenishes Quantity (1 in {0} seconds)", this.Seconds);
			}
			else
			{
				text = string.Format("Repairs 1 Durability in {0} seconds", this.Seconds);
			}
			return text;
		}

		// Token: 0x04007F1F RID: 32543
		public readonly int Seconds;
	}
}
