using System;

namespace D2Data
{
	// Token: 0x0200092E RID: 2350
	public class ColdDamageStat : DamageRangeStat
	{
		// Token: 0x0600B95D RID: 47453 RVA: 0x003625E6 File Offset: 0x003607E6
		public ColdDamageStat(BaseStat stat, int min, int max, int frames)
			: base(stat, min, max)
		{
			this.Frames = frames;
			this.Seconds = (double)frames / 25.0;
		}

		// Token: 0x0600B95E RID: 47454 RVA: 0x00362610 File Offset: 0x00360810
		public override string ToString()
		{
			bool flag = base.Min == base.Max;
			string text;
			if (flag)
			{
				text = string.Format("+{0} Cold Damage (Chills {1} seconds)", base.Min, Math.Round(this.Seconds, 2));
			}
			else
			{
				text = string.Format("+{0}-{1} Cold Damage (Chills {2} seconds)", base.Min, base.Max, Math.Round(this.Seconds, 2));
			}
			return text;
		}

		// Token: 0x04006F17 RID: 28439
		public readonly int Frames;

		// Token: 0x04006F18 RID: 28440
		public readonly double Seconds;
	}
}
