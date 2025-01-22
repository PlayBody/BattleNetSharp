using System;

namespace D2Data
{
	// Token: 0x02000960 RID: 2400
	public class PoisonDamageStat : DamageRangeStat
	{
		// Token: 0x17003908 RID: 14600
		// (get) Token: 0x0600B981 RID: 47489 RVA: 0x0037C308 File Offset: 0x0037A508
		public double MinPerSecond
		{
			get
			{
				return (double)base.Min / 10.25;
			}
		}

		// Token: 0x17003909 RID: 14601
		// (get) Token: 0x0600B982 RID: 47490 RVA: 0x0037C32C File Offset: 0x0037A52C
		public double MaxPerSecond
		{
			get
			{
				return (double)base.Max / 10.25;
			}
		}

		// Token: 0x0600B983 RID: 47491 RVA: 0x0037C34F File Offset: 0x0037A54F
		public PoisonDamageStat(BaseStat stat, int min, int max, int frames)
			: base(stat, min, max)
		{
			this.Frames = frames;
			this.Seconds = (double)frames / 25.0;
		}

		// Token: 0x0600B984 RID: 47492 RVA: 0x0037C378 File Offset: 0x0037A578
		public override string ToString()
		{
			bool flag = base.Min == base.Max;
			string text;
			if (flag)
			{
				text = string.Format("+{1} Poison Damage over {0} seconds", this.Seconds, Math.Floor(this.MinPerSecond * this.Seconds));
			}
			else
			{
				text = string.Format("+{1}-{2} Poison Damage over {0} seconds", this.Seconds, Math.Floor(this.MinPerSecond * this.Seconds) + 1.0, Math.Floor(this.MaxPerSecond * this.Seconds));
			}
			return text;
		}

		// Token: 0x04007EE4 RID: 32484
		public readonly int Frames;

		// Token: 0x04007EE5 RID: 32485
		public readonly double Seconds;
	}
}
