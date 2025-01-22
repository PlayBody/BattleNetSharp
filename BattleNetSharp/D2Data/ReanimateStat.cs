using System;

namespace D2Data
{
	// Token: 0x02000964 RID: 2404
	public class ReanimateStat : UnsignedStat
	{
		// Token: 0x0600B985 RID: 47493 RVA: 0x0037C419 File Offset: 0x0037A619
		public ReanimateStat(BaseStat stat, uint monster, uint val)
			: base(stat, val)
		{
			this.Monster = (NPCCode)monster;
		}

		// Token: 0x0600B986 RID: 47494 RVA: 0x0037C430 File Offset: 0x0037A630
		public override string ToString()
		{
			return string.Format("{0}% Reanimate As: {1}", this.Value, this.Monster);
		}

		// Token: 0x04007F1E RID: 32542
		public readonly NPCCode Monster;
	}
}
