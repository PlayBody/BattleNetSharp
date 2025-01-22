using System;
using System.Threading;
using System.Threading.Tasks;
using Libs.GOAP;
using Microsoft.Extensions.Logging;

namespace Libs.Goals
{
	// Token: 0x02000905 RID: 2309
	public class GoalThread
	{
		// Token: 0x17003868 RID: 14440
		// (get) Token: 0x0600B836 RID: 47158 RVA: 0x002DD3A9 File Offset: 0x002DB5A9
		// (set) Token: 0x0600B837 RID: 47159 RVA: 0x002DD3B1 File Offset: 0x002DB5B1
		public bool Active { get; set; }

		// Token: 0x0600B838 RID: 47160 RVA: 0x002DD3BA File Offset: 0x002DB5BA
		public GoalThread(GoapAgent goapAgent, ILogger logger)
		{
			this.goapAgent = goapAgent;
			this.logger = logger;
		}

		// Token: 0x0600B839 RID: 47161 RVA: 0x002DD3D4 File Offset: 0x002DB5D4
		public void OnActionEvent(object sender, ActionEventArgs e)
		{
			bool flag = e.Key == GoapKey.abort;
			if (flag)
			{
				this.logger.LogInformation("Abort from: " + sender.GetType().Name, Array.Empty<object>());
				this.Active = false;
			}
		}

		// Token: 0x0600B83A RID: 47162 RVA: 0x002DD424 File Offset: 0x002DB624
		public async Task GoapPerformGoal()
		{
			bool flag = this.goapAgent != null;
			if (flag)
			{
				GoapGoal goapGoal = await this.goapAgent.GetAction();
				GoapGoal newGoal = goapGoal;
				goapGoal = null;
				if (newGoal != null)
				{
					if (newGoal != this.currentGoal)
					{
						GoapGoal goapGoal2 = this.currentGoal;
						if (goapGoal2 != null)
						{
							goapGoal2.DoReset();
						}
						this.currentGoal = newGoal;
						this.logger.LogInformation("---------------------------------", Array.Empty<object>());
						this.logger.LogInformation("New Plan= " + newGoal.GetType().Name, Array.Empty<object>());
					}
					try
					{
						await newGoal.PerformAction();
					}
					catch (Exception ex)
					{
						this.logger.LogError(ex, "PerformAction on " + newGoal.GetType().Name, Array.Empty<object>());
					}
				}
				else
				{
					this.logger.LogInformation("New Plan= NULL", Array.Empty<object>());
					Thread.Sleep(500);
				}
				newGoal = null;
			}
		}

		// Token: 0x04006A49 RID: 27209
		private readonly ILogger logger;

		// Token: 0x04006A4A RID: 27210
		private readonly GoapAgent goapAgent;

		// Token: 0x04006A4B RID: 27211
		private GoapGoal currentGoal;
	}
}
