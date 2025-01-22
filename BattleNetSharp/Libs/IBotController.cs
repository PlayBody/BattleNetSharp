using System;
using System.Threading.Tasks;
using Libs.GOAP;

namespace Libs
{
	// Token: 0x020008FE RID: 2302
	public interface IBotController
	{
		// Token: 0x17003860 RID: 14432
		// (get) Token: 0x0600B815 RID: 47125
		// (set) Token: 0x0600B816 RID: 47126
		Task botThread { get; set; }

		// Token: 0x17003861 RID: 14433
		// (get) Token: 0x0600B817 RID: 47127
		// (set) Token: 0x0600B818 RID: 47128
		GoapAgent GoapAgent { get; set; }

		// Token: 0x0600B819 RID: 47129
		void ToggleBotStatus();

		// Token: 0x0600B81A RID: 47130
		void StopBot();

		// Token: 0x0600B81B RID: 47131
		void Shutdown();

		// Token: 0x17003862 RID: 14434
		// (get) Token: 0x0600B81C RID: 47132
		bool IsBotActive { get; }
	}
}
