using System;
using System.Collections.Generic;
using Libs.Goals;
using Microsoft.Extensions.Logging;

namespace Libs
{
	// Token: 0x020008FD RID: 2301
	public class GoalFactory
	{
		// Token: 0x0600B813 RID: 47123 RVA: 0x002DCA53 File Offset: 0x002DAC53
		public GoalFactory(ILogger logger, BotController bot)
		{
			this.logger = logger;
			this.bot = bot;
		}

		// Token: 0x0600B814 RID: 47124 RVA: 0x002DCA6C File Offset: 0x002DAC6C
		public HashSet<GoapGoal> CreateGoals()
		{
			return new HashSet<GoapGoal>
			{
				new EnterGameGoal(this.logger, this.bot),
				new EnterGameGoal(this.logger, this.bot)
			};
		}

		// Token: 0x04006A24 RID: 27172
		private ILogger logger;

		// Token: 0x04006A25 RID: 27173
		private BotController bot;
	}
}
