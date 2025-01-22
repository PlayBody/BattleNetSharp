using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BattleNetSharp.D2.Resurrected;
using DiabloBridge;
using Libs.Goals;
using Libs.GOAP;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Libs
{
	// Token: 0x020008FC RID: 2300
	public sealed class BotController : IDisposable
	{
		// Token: 0x1700385E RID: 14430
		// (get) Token: 0x0600B808 RID: 47112 RVA: 0x002DC8B4 File Offset: 0x002DAAB4
		// (set) Token: 0x0600B809 RID: 47113 RVA: 0x002DC8BC File Offset: 0x002DAABC
		public GoapAgent GoapAgent { get; set; }

		// Token: 0x0600B80A RID: 47114 RVA: 0x002DC8C8 File Offset: 0x002DAAC8
		public BotController(string acc, ILogger logger)
		{
			this.acc = acc;
			string text = File.ReadAllText("C:\\Users\\shalzuth\\Documents\\GitHub\\BattleNetSharp\\BattleNetSharp\\accounts\\" + acc);
			AccountLink accountLink = JsonConvert.DeserializeObject<AccountLink>(text);
			this.tok = accountLink.BNetToken;
			this.logger = logger;
		}

		// Token: 0x1700385F RID: 14431
		// (get) Token: 0x0600B80B RID: 47115 RVA: 0x002DC90F File Offset: 0x002DAB0F
		public bool IsBotActive
		{
			get
			{
				return this.actionThread != null && this.actionThread.Active;
			}
		}

		// Token: 0x0600B80C RID: 47116 RVA: 0x002DC927 File Offset: 0x002DAB27
		public void ToggleBotStatus()
		{
			this.autoplay = new Autoplay(this.acc);
			Task.Run(new Action(this.autoplay.Behavior));
		}

		// Token: 0x0600B80D RID: 47117 RVA: 0x002DC954 File Offset: 0x002DAB54
		public void InitializeBot()
		{
			GoalFactory goalFactory = new GoalFactory(this.logger, this);
			HashSet<GoapGoal> availableActions = goalFactory.CreateGoals();
			this.GoapAgent = new GoapAgent(availableActions, this, this.logger);
			this.actionThread = new GoalThread(this.GoapAgent, this.logger);
			availableActions.ToList<GoapGoal>().ForEach(delegate(GoapGoal a)
			{
				a.ActionEvent += this.actionThread.OnActionEvent;
				a.ActionEvent += this.GoapAgent.OnActionEvent;
				availableActions.ToList<GoapGoal>().ForEach(delegate(GoapGoal b)
				{
					bool flag = b != a;
					if (flag)
					{
						a.ActionEvent += b.OnActionEvent;
					}
				});
			});
		}

		// Token: 0x0600B80E RID: 47118 RVA: 0x002DC9D5 File Offset: 0x002DABD5
		public void Dispose()
		{
		}

		// Token: 0x0600B80F RID: 47119 RVA: 0x002DC9D8 File Offset: 0x002DABD8
		public void StopBot()
		{
			bool flag = this.actionThread != null;
			if (flag)
			{
				this.actionThread.Active = false;
				GoapAgent goapAgent = this.GoapAgent;
				if (goapAgent != null)
				{
					goapAgent.AvailableGoals.ToList<GoapGoal>().ForEach(delegate(GoapGoal goal)
					{
						goal.OnActionEvent(this, new ActionEventArgs(GoapKey.abort, true));
					});
				}
			}
		}

		// Token: 0x0600B810 RID: 47120 RVA: 0x002DCA2A File Offset: 0x002DAC2A
		public void Shutdown()
		{
		}

		// Token: 0x04006A1D RID: 27165
		public static ConcurrentDictionary<string, BotController> Controllers = new ConcurrentDictionary<string, BotController>();

		// Token: 0x04006A1E RID: 27166
		public Autoplay autoplay;

		// Token: 0x04006A1F RID: 27167
		private readonly ILogger logger;

		// Token: 0x04006A21 RID: 27169
		private GoalThread actionThread;

		// Token: 0x04006A22 RID: 27170
		public string acc;

		// Token: 0x04006A23 RID: 27171
		public string tok;
	}
}
