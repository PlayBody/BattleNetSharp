using System;

namespace D2Data
{
	// Token: 0x0200092D RID: 2349
	public class ClassSkillsBonusStat : SignedStat
	{
		// Token: 0x0600B95B RID: 47451 RVA: 0x0036259E File Offset: 0x0036079E
		public ClassSkillsBonusStat(BaseStat stat, int charClass, int val)
			: base(stat, val)
		{
			this.Class = (CharacterClass)charClass;
		}

		// Token: 0x0600B95C RID: 47452 RVA: 0x003625B4 File Offset: 0x003607B4
		public override string ToString()
		{
			return string.Format("+{0} To {1} Skills", this.Value, this.Class);
		}

		// Token: 0x04006F16 RID: 28438
		public readonly CharacterClass Class;
	}
}
