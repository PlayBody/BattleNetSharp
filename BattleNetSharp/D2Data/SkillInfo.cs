using System;

namespace D2Data
{
	// Token: 0x0200096D RID: 2413
	public class SkillInfo
	{
		// Token: 0x1700390A RID: 14602
		// (get) Token: 0x0600B990 RID: 47504 RVA: 0x0037C5B8 File Offset: 0x0037A7B8
		public int Level
		{
			get
			{
				int num = this.BaseLevel;
				bool flag = this.ItemBonus > 0;
				if (flag)
				{
					num += this.ItemBonus;
				}
				bool flag2 = this.StateBonus > 0;
				if (flag2)
				{
					num += this.StateBonus;
				}
				return num;
			}
		}

		// Token: 0x0600B991 RID: 47505 RVA: 0x0037C602 File Offset: 0x0037A802
		public SkillInfo(SkillType skill, int baseLevel)
		{
			this.Skill = skill;
			this.BaseLevel = baseLevel;
		}

		// Token: 0x0600B992 RID: 47506 RVA: 0x0037C61A File Offset: 0x0037A81A
		public SkillInfo(SkillType skill, int baseLevel, int itemBonus)
		{
			this.Skill = skill;
			this.BaseLevel = baseLevel;
			this.ItemBonus = itemBonus;
		}

		// Token: 0x0600B993 RID: 47507 RVA: 0x0037C639 File Offset: 0x0037A839
		public SkillInfo(SkillType skill, int baseLevel, int itemBonus, int stateBonus)
		{
			this.Skill = skill;
			this.BaseLevel = baseLevel;
			this.ItemBonus = itemBonus;
			this.StateBonus = stateBonus;
		}

		// Token: 0x0600B994 RID: 47508 RVA: 0x0037C660 File Offset: 0x0037A860
		public override string ToString()
		{
			return string.Format("{0}: {1}", this.Skill, this.Level);
		}

		// Token: 0x04008052 RID: 32850
		public SkillType Skill;

		// Token: 0x04008053 RID: 32851
		public int BaseLevel;

		// Token: 0x04008054 RID: 32852
		public int ItemBonus;

		// Token: 0x04008055 RID: 32853
		public int StateBonus;
	}
}
