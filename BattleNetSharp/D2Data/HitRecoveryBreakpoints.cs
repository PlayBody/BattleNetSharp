using System;
using System.Collections.Generic;
using System.Linq;

namespace D2Data
{
	// Token: 0x0200093E RID: 2366
	public class HitRecoveryBreakpoints
	{
		// Token: 0x0600B966 RID: 47462 RVA: 0x00362954 File Offset: 0x00360B54
		public static uint GetTimeDelay(CharacterClass characterClass, ushort fasterHitRecovery)
		{
			int num = HitRecoveryBreakpoints.BreakpointTable[characterClass].Breakpoints.Select((int i) => (i > (int)fasterHitRecovery) ? 0 : 1).ToList<int>().Sum();
			int num2 = HitRecoveryBreakpoints.BreakpointTable[characterClass].BaseFrame + 1 - num;
			return (uint)((float)(1000 * num2) / HitRecoveryBreakpoints.FramesPerSecond);
		}

		// Token: 0x040071D2 RID: 29138
		private int BaseFrame = 23;

		// Token: 0x040071D3 RID: 29139
		private List<int> Breakpoints = new List<int>();

		// Token: 0x040071D4 RID: 29140
		private static float FramesPerSecond = 25f;

		// Token: 0x040071D5 RID: 29141
		private static Dictionary<CharacterClass, HitRecoveryBreakpoints> BreakpointTable = new Dictionary<CharacterClass, HitRecoveryBreakpoints> { 
		{
			CharacterClass.Sorceress,
			new HitRecoveryBreakpoints
			{
				BaseFrame = 15,
				Breakpoints = new List<int>
				{
					0, 5, 9, 14, 20, 30, 42, 60, 86, 142,
					280
				}
			}
		} };
	}
}
