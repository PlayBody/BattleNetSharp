using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Libs.Goals;
using Microsoft.Extensions.Logging;

namespace Libs.GOAP
{
	// Token: 0x020008FF RID: 2303
	public sealed class GoapAgent
	{
		// Token: 0x17003863 RID: 14435
		// (get) Token: 0x0600B81D RID: 47133 RVA: 0x002DCAB5 File Offset: 0x002DACB5
		// (set) Token: 0x0600B81E RID: 47134 RVA: 0x002DCABD File Offset: 0x002DACBD
		public IEnumerable<GoapGoal> AvailableGoals { get; set; }

		// Token: 0x17003864 RID: 14436
		// (get) Token: 0x0600B81F RID: 47135 RVA: 0x002DCAC6 File Offset: 0x002DACC6
		// (set) Token: 0x0600B820 RID: 47136 RVA: 0x002DCACE File Offset: 0x002DACCE
		public GoapGoal CurrentGoal { get; set; }

		// Token: 0x17003865 RID: 14437
		// (get) Token: 0x0600B821 RID: 47137 RVA: 0x002DCAD7 File Offset: 0x002DACD7
		// (set) Token: 0x0600B822 RID: 47138 RVA: 0x002DCADF File Offset: 0x002DACDF
		public HashSet<KeyValuePair<GoapKey, object>> WorldState { get; private set; } = new HashSet<KeyValuePair<GoapKey, object>>();

		// Token: 0x0600B823 RID: 47139 RVA: 0x002DCAE8 File Offset: 0x002DACE8
		public GoapAgent(HashSet<GoapGoal> availableGoals, BotController bot, ILogger logger)
		{
			this.bot = bot;
			this.AvailableGoals = availableGoals.OrderBy((GoapGoal a) => a.CostOfPerformingAction);
			this.logger = logger;
			this.planner = new GoapPlanner(logger);
		}

		// Token: 0x0600B824 RID: 47140 RVA: 0x002DCB5C File Offset: 0x002DAD5C
		public async Task<GoapGoal> GetAction()
		{
			await Task.Delay(1);
			this.WorldState = this.GetWorldState();
			HashSet<KeyValuePair<GoapKey, GoapPreCondition>> goal = new HashSet<KeyValuePair<GoapKey, GoapPreCondition>>();
			Queue<GoapGoal> plan = this.planner.Plan(this.AvailableGoals, this.WorldState, goal);
			if (plan != null && plan.Count > 0)
			{
				this.CurrentGoal = plan.Peek();
			}
			return this.CurrentGoal;
		}

		// Token: 0x0600B825 RID: 47141 RVA: 0x002DCBA0 File Offset: 0x002DADA0
		private HashSet<KeyValuePair<GoapKey, object>> GetWorldState()
		{
			HashSet<KeyValuePair<GoapKey, object>> state = new HashSet<KeyValuePair<GoapKey, object>>();
			this.actionState.ToList<KeyValuePair<GoapKey, object>>().ForEach(delegate(KeyValuePair<GoapKey, object> kv)
			{
				state.Add(kv);
			});
			return state;
		}

		// Token: 0x0600B826 RID: 47142 RVA: 0x002DCBE8 File Offset: 0x002DADE8
		public void OnActionEvent(object sender, ActionEventArgs e)
		{
			bool flag = !this.actionState.ContainsKey(e.Key);
			if (flag)
			{
				this.actionState.Add(e.Key, e.Value);
			}
			else
			{
				this.actionState[e.Key] = e.Value;
			}
		}

		// Token: 0x04006A26 RID: 27174
		private GoapPlanner planner;

		// Token: 0x04006A28 RID: 27176
		private ILogger logger;

		// Token: 0x04006A29 RID: 27177
		private BotController bot;

		// Token: 0x04006A2C RID: 27180
		private Dictionary<GoapKey, object> actionState = new Dictionary<GoapKey, object>();
	}
}
