using System;
using System.Collections.Generic;
using Libs.Goals;
using Microsoft.Extensions.Logging;

namespace Libs.GOAP
{
	// Token: 0x02000902 RID: 2306
	public class GoapPlanner
	{
		// Token: 0x0600B828 RID: 47144 RVA: 0x002DCC69 File Offset: 0x002DAE69
		public GoapPlanner(ILogger logger)
		{
			this.logger = logger;
		}

		// Token: 0x0600B829 RID: 47145 RVA: 0x002DCC7C File Offset: 0x002DAE7C
		public static void RefreshState(IEnumerable<GoapGoal> availableActions)
		{
			foreach (GoapGoal goapGoal in availableActions)
			{
				goapGoal.SetState(GoapPlanner.InState(goapGoal.Preconditions, new HashSet<KeyValuePair<GoapKey, object>>()));
			}
		}

		// Token: 0x0600B82A RID: 47146 RVA: 0x002DCCDC File Offset: 0x002DAEDC
		public Queue<GoapGoal> Plan(IEnumerable<GoapGoal> availableActions, HashSet<KeyValuePair<GoapKey, object>> worldState, HashSet<KeyValuePair<GoapKey, GoapPreCondition>> goal)
		{
			foreach (GoapGoal goapGoal in availableActions)
			{
				goapGoal.ResetBeforePlanning();
			}
			GoapPlanner.Node node = new GoapPlanner.Node(null, 0f, worldState, null);
			HashSet<GoapGoal> hashSet = new HashSet<GoapGoal>();
			foreach (GoapGoal goapGoal2 in availableActions)
			{
				bool flag = goapGoal2.CheckIfActionCanRun();
				if (flag)
				{
					hashSet.Add(goapGoal2);
				}
				else
				{
					goapGoal2.SetState(GoapPlanner.InState(goapGoal2.Preconditions, node.state));
				}
			}
			List<GoapPlanner.Node> list = new List<GoapPlanner.Node>();
			bool flag2 = this.BuildGraph(node, list, hashSet, goal);
			bool flag3 = !flag2;
			Queue<GoapGoal> queue;
			if (flag3)
			{
				this.logger.LogInformation("NO PLAN", Array.Empty<object>());
				queue = new Queue<GoapGoal>();
			}
			else
			{
				GoapPlanner.Node node2 = null;
				foreach (GoapPlanner.Node node3 in list)
				{
					bool flag4 = node2 == null;
					if (flag4)
					{
						node2 = node3;
					}
					else
					{
						bool flag5 = node3.runningCost < node2.runningCost;
						if (flag5)
						{
							node2 = node3;
						}
					}
				}
				List<GoapGoal> list2 = new List<GoapGoal>();
				for (GoapPlanner.Node node4 = node2; node4 != null; node4 = node4.parent)
				{
					bool flag6 = node4.action != null;
					if (flag6)
					{
						list2.Insert(0, node4.action);
					}
				}
				Queue<GoapGoal> queue2 = new Queue<GoapGoal>();
				foreach (GoapGoal goapGoal3 in list2)
				{
					queue2.Enqueue(goapGoal3);
				}
				queue = queue2;
			}
			return queue;
		}

		// Token: 0x0600B82B RID: 47147 RVA: 0x002DCEFC File Offset: 0x002DB0FC
		private bool BuildGraph(GoapPlanner.Node parent, List<GoapPlanner.Node> leaves, HashSet<GoapGoal> usableActions, HashSet<KeyValuePair<GoapKey, GoapPreCondition>> goal)
		{
			bool flag = false;
			foreach (GoapGoal goapGoal in usableActions)
			{
				Dictionary<string, bool> dictionary = GoapPlanner.InState(goapGoal.Preconditions, parent.state);
				goapGoal.SetState(dictionary);
				bool flag2 = !dictionary.ContainsValue(false);
				if (flag2)
				{
					HashSet<KeyValuePair<GoapKey, object>> hashSet = GoapPlanner.PopulateState(parent.state, goapGoal.Effects);
					GoapPlanner.Node node = new GoapPlanner.Node(parent, parent.runningCost + goapGoal.CostOfPerformingAction, hashSet, goapGoal);
					dictionary = GoapPlanner.InState(goal, hashSet);
					bool flag3 = !dictionary.ContainsValue(false);
					if (flag3)
					{
						leaves.Add(node);
						flag = true;
					}
					else
					{
						HashSet<GoapGoal> hashSet2 = GoapPlanner.ActionSubset(usableActions, goapGoal);
						bool flag4 = this.BuildGraph(node, leaves, hashSet2, goal);
						bool flag5 = flag4;
						if (flag5)
						{
							flag = true;
						}
					}
				}
			}
			return flag;
		}

		// Token: 0x0600B82C RID: 47148 RVA: 0x002DD000 File Offset: 0x002DB200
		private static HashSet<GoapGoal> ActionSubset(HashSet<GoapGoal> actions, GoapGoal removeMe)
		{
			HashSet<GoapGoal> hashSet = new HashSet<GoapGoal>();
			foreach (GoapGoal goapGoal in actions)
			{
				bool flag = !goapGoal.Equals(removeMe);
				if (flag)
				{
					hashSet.Add(goapGoal);
				}
			}
			return hashSet;
		}

		// Token: 0x0600B82D RID: 47149 RVA: 0x002DD070 File Offset: 0x002DB270
		private static Dictionary<string, bool> InState(HashSet<KeyValuePair<GoapKey, GoapPreCondition>> test, HashSet<KeyValuePair<GoapKey, object>> state)
		{
			Dictionary<string, bool> dictionary = new Dictionary<string, bool>();
			foreach (KeyValuePair<GoapKey, GoapPreCondition> keyValuePair in test)
			{
				bool flag = false;
				foreach (KeyValuePair<GoapKey, object> keyValuePair2 in state)
				{
					flag = keyValuePair2.Key == keyValuePair.Key;
					bool flag2 = flag;
					if (flag2)
					{
						dictionary.Add(keyValuePair.Value.Description, keyValuePair2.Value.Equals(keyValuePair.Value.State));
						break;
					}
				}
				bool flag3 = !flag;
				if (flag3)
				{
					dictionary.Add(keyValuePair.Value.Description, false);
				}
			}
			return dictionary;
		}

		// Token: 0x0600B82E RID: 47150 RVA: 0x002DD174 File Offset: 0x002DB374
		private static HashSet<KeyValuePair<GoapKey, object>> PopulateState(HashSet<KeyValuePair<GoapKey, object>> currentState, HashSet<KeyValuePair<GoapKey, object>> stateChange)
		{
			HashSet<KeyValuePair<GoapKey, object>> hashSet = new HashSet<KeyValuePair<GoapKey, object>>();
			foreach (KeyValuePair<GoapKey, object> keyValuePair in currentState)
			{
				hashSet.Add(new KeyValuePair<GoapKey, object>(keyValuePair.Key, keyValuePair.Value));
			}
			using (HashSet<KeyValuePair<GoapKey, object>>.Enumerator enumerator2 = stateChange.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					KeyValuePair<GoapKey, object> change = enumerator2.Current;
					bool flag = false;
					foreach (KeyValuePair<GoapKey, object> keyValuePair2 in hashSet)
					{
						bool flag2 = keyValuePair2.Equals(change);
						if (flag2)
						{
							flag = true;
							break;
						}
					}
					bool flag3 = flag;
					if (flag3)
					{
						hashSet.RemoveWhere((KeyValuePair<GoapKey, object> kvp) => kvp.Key.Equals(change.Key));
						KeyValuePair<GoapKey, object> keyValuePair3 = new KeyValuePair<GoapKey, object>(change.Key, change.Value);
						hashSet.Add(keyValuePair3);
					}
					else
					{
						hashSet.Add(new KeyValuePair<GoapKey, object>(change.Key, change.Value));
					}
				}
			}
			return hashSet;
		}

		// Token: 0x04006A46 RID: 27206
		private ILogger logger;

		// Token: 0x0200130B RID: 4875
		private class Node
		{
			// Token: 0x0600DEF5 RID: 57077 RVA: 0x004C3172 File Offset: 0x004C1372
			public Node(GoapPlanner.Node parent, float runningCost, HashSet<KeyValuePair<GoapKey, object>> state, GoapGoal action)
			{
				this.parent = parent;
				this.runningCost = runningCost;
				this.state = state;
				this.action = action;
			}

			// Token: 0x04009D25 RID: 40229
			public GoapPlanner.Node parent;

			// Token: 0x04009D26 RID: 40230
			public float runningCost;

			// Token: 0x04009D27 RID: 40231
			public HashSet<KeyValuePair<GoapKey, object>> state;

			// Token: 0x04009D28 RID: 40232
			public GoapGoal action;
		}
	}
}
