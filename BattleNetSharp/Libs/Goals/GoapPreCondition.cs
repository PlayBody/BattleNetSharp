using System;

namespace Libs.Goals
{
	// Token: 0x02000906 RID: 2310
	public class GoapPreCondition
	{
		// Token: 0x17003869 RID: 14441
		// (get) Token: 0x0600B83B RID: 47163 RVA: 0x002DD468 File Offset: 0x002DB668
		// (set) Token: 0x0600B83C RID: 47164 RVA: 0x002DD470 File Offset: 0x002DB670
		public string Description { get; private set; }

		// Token: 0x1700386A RID: 14442
		// (get) Token: 0x0600B83D RID: 47165 RVA: 0x002DD479 File Offset: 0x002DB679
		// (set) Token: 0x0600B83E RID: 47166 RVA: 0x002DD481 File Offset: 0x002DB681
		public object State { get; private set; }

		// Token: 0x0600B83F RID: 47167 RVA: 0x002DD48A File Offset: 0x002DB68A
		public GoapPreCondition(string description, object state)
		{
			this.Description = description;
			this.State = state;
		}
	}
}
