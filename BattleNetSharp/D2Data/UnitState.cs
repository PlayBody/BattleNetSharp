using System;
using System.Text;

namespace D2Data
{
	// Token: 0x0200097D RID: 2429
	public class UnitState
	{
		// Token: 0x0600B9AA RID: 47530 RVA: 0x0037D4CC File Offset: 0x0037B6CC
		public UnitState(int stateID)
		{
			this.BaseState = BaseState.Get(stateID);
			this.Stats = new Stats();
		}

		// Token: 0x0600B9AB RID: 47531 RVA: 0x0037D4ED File Offset: 0x0037B6ED
		public UnitState(StateType stateType)
		{
			this.BaseState = BaseState.Get(stateType);
			this.Stats = new Stats();
		}

		// Token: 0x0600B9AC RID: 47532 RVA: 0x0037D50E File Offset: 0x0037B70E
		public UnitState(BaseState state)
		{
			this.BaseState = state;
			this.Stats = new Stats();
		}

		// Token: 0x0600B9AD RID: 47533 RVA: 0x0037D52C File Offset: 0x0037B72C
		public override string ToString()
		{
			bool flag = this.Stats.Count == 0;
			string text;
			if (flag)
			{
				text = this.BaseState.ToString();
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(this.BaseState);
				stringBuilder.Append(" (");
				int num = 0;
				for (;;)
				{
					stringBuilder.Append(this.Stats[num].ToString());
					bool flag2 = ++num >= this.Stats.Count;
					if (flag2)
					{
						break;
					}
					stringBuilder.Append(", ");
				}
				stringBuilder.Append(")");
				text = stringBuilder.ToString();
			}
			return text;
		}

		// Token: 0x040085AC RID: 34220
		public BaseState BaseState;

		// Token: 0x040085AD RID: 34221
		public Stats Stats;
	}
}
