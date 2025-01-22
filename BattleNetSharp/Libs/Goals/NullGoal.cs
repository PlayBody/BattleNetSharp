using System;
using System.Threading.Tasks;

namespace Libs.Goals
{
	// Token: 0x02000904 RID: 2308
	public class NullGoal : GoapGoal
	{
		// Token: 0x17003867 RID: 14439
		// (get) Token: 0x0600B833 RID: 47155 RVA: 0x002DD37F File Offset: 0x002DB57F
		public override float CostOfPerformingAction
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600B834 RID: 47156 RVA: 0x002DD388 File Offset: 0x002DB588
		public override Task PerformAction()
		{
			return Task.Delay(0);
		}
	}
}
