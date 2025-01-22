using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Libs.Goals
{
	// Token: 0x02000903 RID: 2307
	public class EnterGameGoal : GoapGoal
	{
		// Token: 0x0600B82F RID: 47151 RVA: 0x002DD308 File Offset: 0x002DB508
		public EnterGameGoal(ILogger logger, BotController bot)
		{
			this.botController = bot;
			this.logger = logger;
		}

		// Token: 0x17003866 RID: 14438
		// (get) Token: 0x0600B830 RID: 47152 RVA: 0x002DD320 File Offset: 0x002DB520
		public override float CostOfPerformingAction
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600B831 RID: 47153 RVA: 0x002DD328 File Offset: 0x002DB528
		public override async Task PerformAction()
		{
			await Task.Delay(100);
		}

		// Token: 0x0600B832 RID: 47154 RVA: 0x002DD36C File Offset: 0x002DB56C
		public override bool CheckIfActionCanRun()
		{
			return true;
		}

		// Token: 0x04006A47 RID: 27207
		private BotController botController;

		// Token: 0x04006A48 RID: 27208
		private ILogger logger;
	}
}
