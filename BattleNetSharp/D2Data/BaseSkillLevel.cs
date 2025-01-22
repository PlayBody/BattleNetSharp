using System;

namespace D2Data
{
	// Token: 0x0200091D RID: 2333
	public struct BaseSkillLevel
	{
		// Token: 0x0600B93A RID: 47418 RVA: 0x0033D3BC File Offset: 0x0033B5BC
		public BaseSkillLevel(int skill, int level)
		{
			this.Skill = (SkillType)skill;
			this.Level = level;
		}

		// Token: 0x0600B93B RID: 47419 RVA: 0x0033D3CE File Offset: 0x0033B5CE
		public BaseSkillLevel(SkillType skill, int level)
		{
			this.Skill = skill;
			this.Level = level;
		}

		// Token: 0x0600B93C RID: 47420 RVA: 0x0033D3E0 File Offset: 0x0033B5E0
		public override string ToString()
		{
			return string.Format("{0}: {1}", this.Skill, this.Level);
		}

		// Token: 0x04006DA4 RID: 28068
		public readonly SkillType Skill;

		// Token: 0x04006DA5 RID: 28069
		public readonly int Level;
	}
}
