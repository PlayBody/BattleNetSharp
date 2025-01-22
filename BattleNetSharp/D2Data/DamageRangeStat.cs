using System;

namespace D2Data
{
	// Token: 0x0200092F RID: 2351
	public class DamageRangeStat : SignedStatParam
	{
		// Token: 0x17003904 RID: 14596
		// (get) Token: 0x0600B95F RID: 47455 RVA: 0x00362690 File Offset: 0x00360890
		public int Min
		{
			get
			{
				return this.Value;
			}
		}

		// Token: 0x17003905 RID: 14597
		// (get) Token: 0x0600B960 RID: 47456 RVA: 0x003626A8 File Offset: 0x003608A8
		public int Max
		{
			get
			{
				return this.Param;
			}
		}

		// Token: 0x0600B961 RID: 47457 RVA: 0x003626C0 File Offset: 0x003608C0
		public DamageRangeStat(BaseStat stat, int min, int max)
			: base(stat, min, max)
		{
			StatType type = stat.Type;
			StatType statType = type;
			StatType statType2 = statType;
			if (statType2 - StatType.MaxDamagePercent > 1)
			{
				switch (type)
				{
				case StatType.FireMinDamage:
					this.Type = DamageType.Fire;
					break;
				case StatType.FireMaxDamage:
				case StatType.LightMaxDamage:
				case StatType.MagicMaxDamage:
					break;
				case StatType.LightMinDamage:
					this.Type = DamageType.Lightning;
					break;
				case StatType.MagicMinDamage:
					this.Type = DamageType.Magic;
					break;
				case StatType.ColdMinDamage:
					this.Type = DamageType.Cold;
					break;
				default:
				{
					bool flag = type != StatType.PoisonMinDamage;
					if (!flag)
					{
						this.Type = DamageType.Poison;
					}
					break;
				}
				}
			}
			else
			{
				this.Type = DamageType.Physical;
				this.IsPercent = true;
			}
		}

		// Token: 0x0600B962 RID: 47458 RVA: 0x0036276C File Offset: 0x0036096C
		public override string ToString()
		{
			bool flag = this.Min == this.Max;
			string text;
			if (flag)
			{
				text = string.Format("+{0}{1} {2} Damage", this.Min, this.IsPercent ? "%" : "", this.Type);
			}
			else
			{
				text = string.Format("+{0}-{1}{2} {3} Damage", new object[]
				{
					this.Min,
					this.Max,
					this.IsPercent ? "%" : "",
					this.Type
				});
			}
			return text;
		}

		// Token: 0x04006F19 RID: 28441
		public readonly DamageType Type;

		// Token: 0x04006F1A RID: 28442
		public readonly bool IsPercent;
	}
}
