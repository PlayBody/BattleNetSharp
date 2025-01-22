using System;

namespace D2Data
{
	// Token: 0x0200093C RID: 2364
	[Flags]
	public enum GameQuestState : ushort
	{
		// Token: 0x040071C1 RID: 29121
		Open = 0,
		// Token: 0x040071C2 RID: 29122
		Closed = 32768,
		// Token: 0x040071C3 RID: 29123
		Completed = 8192
	}
}
