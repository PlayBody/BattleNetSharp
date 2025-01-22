using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace D2Data
{
	// Token: 0x02000976 RID: 2422
	public class Stats : Collection<StatBase>
	{
		// Token: 0x0600B9A4 RID: 47524 RVA: 0x0037CFDD File Offset: 0x0037B1DD
		public Stats()
		{
		}

		// Token: 0x0600B9A5 RID: 47525 RVA: 0x0037CFE8 File Offset: 0x0037B1E8
		public Stats(IList<StatBase> stats)
		{
			for (int i = 0; i < stats.Count; i++)
			{
				base.Add(stats[i]);
			}
		}

		// Token: 0x1700390C RID: 14604
		public StatBase this[StatType stat]
		{
			get
			{
				foreach (StatBase statBase in this)
				{
					bool flag = statBase.BaseStat.Type == stat;
					if (flag)
					{
						return statBase;
					}
				}
				return null;
			}
		}

		// Token: 0x0600B9A7 RID: 47527 RVA: 0x0037D088 File Offset: 0x0037B288
		public void Set(StatBase stat)
		{
			for (int i = 0; i < base.Count; i++)
			{
				bool flag = base[i].BaseStat.Type == stat.BaseStat.Type;
				if (flag)
				{
					base[i] = stat;
					return;
				}
			}
			base.Add(stat);
		}

		// Token: 0x0600B9A8 RID: 47528 RVA: 0x0037D0E4 File Offset: 0x0037B2E4
		public void Merge(StatBase stat)
		{
			bool flag = stat.BaseStat.Type == StatType.ChargedSkill || stat.BaseStat.Type == StatType.Reanimate || stat.BaseStat.Type == StatType.SkillOnAttack || stat.BaseStat.Type == StatType.SkillOnKill || stat.BaseStat.Type == StatType.SkillOnDeath || stat.BaseStat.Type == StatType.SkillOnStriking || stat.BaseStat.Type == StatType.SkillOnLevelUp || stat.BaseStat.Type == StatType.SkillOnGetHit;
			if (flag)
			{
				base.Add(stat.Clone());
			}
			else
			{
				for (int i = 0; i < base.Count; i++)
				{
					bool flag2 = base[i].BaseStat.Type == stat.BaseStat.Type;
					if (flag2)
					{
						bool flag3 = stat.BaseStat.Type == StatType.ElementalSkillBonus;
						if (flag3)
						{
							bool flag4 = (base[i] as ElementalSkillsBonusStat).Element == (stat as ElementalSkillsBonusStat).Element;
							if (flag4)
							{
								(base[i] as ElementalSkillsBonusStat).Value += (stat as ElementalSkillsBonusStat).Value;
								return;
							}
						}
						else
						{
							bool flag5 = stat.BaseStat.Type != StatType.ClassSkillsBonus;
							if (flag5)
							{
								bool flag6 = stat.BaseStat.Type == StatType.Aura;
								if (flag6)
								{
									bool flag7 = (base[i] as AuraStat).Skill != (stat as AuraStat).Skill;
									if (flag7)
									{
										goto IL_036D;
									}
									bool flag8 = (base[i] as AuraStat).Value < (stat as AuraStat).Value;
									if (flag8)
									{
										base[i] = stat.Clone();
									}
								}
								else
								{
									bool flag9 = stat is SkillBonusStat;
									if (flag9)
									{
										bool flag10 = (base[i] as SkillBonusStat).Skill == (stat as SkillBonusStat).Skill;
										if (!flag10)
										{
											goto IL_036D;
										}
										(base[i] as SkillBonusStat).Value += (stat as SkillBonusStat).Value;
									}
									else
									{
										bool flag11 = stat.BaseStat.Type == StatType.SkillTabBonus;
										if (flag11)
										{
											bool flag12 = (base[i] as SkillTabBonusStat).Tab == (stat as SkillTabBonusStat).Tab;
											if (!flag12)
											{
												goto IL_036D;
											}
											(base[i] as SkillTabBonusStat).Value += (stat as SkillTabBonusStat).Value;
										}
										else
										{
											bool flag13 = stat is SignedStat;
											if (flag13)
											{
												(base[i] as SignedStat).Value += (stat as SignedStat).Value;
											}
											else
											{
												bool flag14 = stat is UnsignedStat;
												if (flag14)
												{
													(base[i] as UnsignedStat).Value += (stat as UnsignedStat).Value;
												}
											}
										}
									}
								}
								return;
							}
							bool flag15 = (base[i] as ClassSkillsBonusStat).Class == (stat as ClassSkillsBonusStat).Class;
							if (flag15)
							{
								(base[i] as ClassSkillsBonusStat).Value += (stat as ClassSkillsBonusStat).Value;
								return;
							}
						}
					}
					IL_036D:;
				}
				base.Add(stat.Clone());
			}
		}

		// Token: 0x0600B9A9 RID: 47529 RVA: 0x0037D484 File Offset: 0x0037B684
		public void Remove(StatType stat)
		{
			for (int i = 0; i < base.Count; i++)
			{
				bool flag = base[i].BaseStat.Type == stat;
				if (flag)
				{
					base.RemoveAt(i);
					break;
				}
			}
		}
	}
}
