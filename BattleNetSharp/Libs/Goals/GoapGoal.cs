using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Libs.GOAP;

namespace Libs.Goals
{
	// Token: 0x02000908 RID: 2312
	public abstract class GoapGoal
	{
		// Token: 0x1700386D RID: 14445
		// (get) Token: 0x0600B845 RID: 47173 RVA: 0x002DD4E0 File Offset: 0x002DB6E0
		// (set) Token: 0x0600B846 RID: 47174 RVA: 0x002DD4E8 File Offset: 0x002DB6E8
		public HashSet<KeyValuePair<GoapKey, GoapPreCondition>> Preconditions { get; private set; } = new HashSet<KeyValuePair<GoapKey, GoapPreCondition>>();

		// Token: 0x1700386E RID: 14446
		// (get) Token: 0x0600B847 RID: 47175 RVA: 0x002DD4F1 File Offset: 0x002DB6F1
		// (set) Token: 0x0600B848 RID: 47176 RVA: 0x002DD4F9 File Offset: 0x002DB6F9
		public HashSet<KeyValuePair<GoapKey, object>> Effects { get; private set; } = new HashSet<KeyValuePair<GoapKey, object>>();

		// Token: 0x1700386F RID: 14447
		// (get) Token: 0x0600B849 RID: 47177 RVA: 0x002DD502 File Offset: 0x002DB702
		// (set) Token: 0x0600B84A RID: 47178 RVA: 0x002DD50A File Offset: 0x002DB70A
		public bool InRangeOfTarget { get; set; }

		// Token: 0x17003870 RID: 14448
		// (get) Token: 0x0600B84B RID: 47179
		public abstract float CostOfPerformingAction { get; }

		// Token: 0x0600B84C RID: 47180 RVA: 0x002DD513 File Offset: 0x002DB713
		public void DoReset()
		{
			this.ResetBeforePlanning();
		}

		// Token: 0x17003871 RID: 14449
		// (get) Token: 0x0600B84D RID: 47181 RVA: 0x002DD520 File Offset: 0x002DB720
		public virtual string Name
		{
			get
			{
				bool flag = string.IsNullOrEmpty(this.name);
				if (flag)
				{
					string text = Regex.Replace(base.GetType().Name.Replace("Action", ""), "\\p{Lu}", (Match m) => " " + m.Value.ToUpperInvariant());
					this.name = char.ToUpperInvariant(text[0]).ToString() + text.Substring(1);
				}
				return this.name;
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600B84E RID: 47182 RVA: 0x002DD5B4 File Offset: 0x002DB7B4
		// (remove) Token: 0x0600B84F RID: 47183 RVA: 0x002DD5EC File Offset: 0x002DB7EC
		[field: DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event GoapGoal.ActionEventHandler ActionEvent;

		// Token: 0x0600B850 RID: 47184 RVA: 0x002DD621 File Offset: 0x002DB821
		public void SendActionEvent(ActionEventArgs e)
		{
			GoapGoal.ActionEventHandler actionEvent = this.ActionEvent;
			if (actionEvent != null)
			{
				actionEvent(this, e);
			}
		}

		// Token: 0x17003872 RID: 14450
		// (get) Token: 0x0600B851 RID: 47185 RVA: 0x002DD638 File Offset: 0x002DB838
		// (set) Token: 0x0600B852 RID: 47186 RVA: 0x002DD640 File Offset: 0x002DB840
		public Dictionary<string, bool> State { get; private set; } = new Dictionary<string, bool>();

		// Token: 0x0600B853 RID: 47187 RVA: 0x002DD649 File Offset: 0x002DB849
		public void SetState(Dictionary<string, bool> newState)
		{
			this.State = newState;
		}

		// Token: 0x0600B854 RID: 47188 RVA: 0x002DD654 File Offset: 0x002DB854
		public virtual void ResetBeforePlanning()
		{
		}

		// Token: 0x0600B855 RID: 47189 RVA: 0x002DD658 File Offset: 0x002DB858
		public virtual bool CheckIfActionCanRun()
		{
			return true;
		}

		// Token: 0x0600B856 RID: 47190
		public abstract Task PerformAction();

		// Token: 0x0600B857 RID: 47191 RVA: 0x002DD66C File Offset: 0x002DB86C
		public virtual async Task Abort()
		{
			await Task.Delay(0);
		}

		// Token: 0x0600B858 RID: 47192 RVA: 0x002DD6B0 File Offset: 0x002DB8B0
		public void AddPrecondition(GoapKey key, object value)
		{
			GoapPreCondition goapPreCondition = new GoapPreCondition(GoapKeyDescription.ToString(key, value), value);
			this.Preconditions.Add(new KeyValuePair<GoapKey, GoapPreCondition>(key, goapPreCondition));
		}

		// Token: 0x0600B859 RID: 47193 RVA: 0x002DD6E0 File Offset: 0x002DB8E0
		public void RemovePrecondition(GoapKey key)
		{
			this.Preconditions.Where((KeyValuePair<GoapKey, GoapPreCondition> o) => o.Key.Equals(key)).ToList<KeyValuePair<GoapKey, GoapPreCondition>>().ForEach(delegate(KeyValuePair<GoapKey, GoapPreCondition> o)
			{
				this.Preconditions.Remove(o);
			});
		}

		// Token: 0x0600B85A RID: 47194 RVA: 0x002DD730 File Offset: 0x002DB930
		public void AddEffect(GoapKey key, object value)
		{
			this.Effects.Add(new KeyValuePair<GoapKey, object>(key, value));
		}

		// Token: 0x0600B85B RID: 47195 RVA: 0x002DD748 File Offset: 0x002DB948
		public void RemoveEffect(GoapKey key)
		{
			this.Effects.Where((KeyValuePair<GoapKey, object> o) => o.Key.Equals(key)).ToList<KeyValuePair<GoapKey, object>>().ForEach(delegate(KeyValuePair<GoapKey, object> o)
			{
				this.Effects.Remove(o);
			});
		}

		// Token: 0x0600B85C RID: 47196 RVA: 0x002DD798 File Offset: 0x002DB998
		public virtual void OnActionEvent(object sender, ActionEventArgs e)
		{
		}

		// Token: 0x0600B85D RID: 47197 RVA: 0x002DD79C File Offset: 0x002DB99C
		public virtual string Description()
		{
			return this.Name + " : ";
		}

		// Token: 0x04006A54 RID: 27220
		private string name = string.Empty;

		// Token: 0x0200130F RID: 4879
		// (Invoke) Token: 0x0600DEFF RID: 57087
		public delegate void ActionEventHandler(object sender, ActionEventArgs e);
	}
}
