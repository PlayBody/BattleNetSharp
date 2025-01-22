using System;
using System.Collections.Generic;
using System.Linq;

namespace D2Data
{
	// Token: 0x02000926 RID: 2342
	public class CastRateBreakpoints
	{
		// Token: 0x0600B953 RID: 47443 RVA: 0x003621BC File Offset: 0x003603BC
		public static uint GetTimeDelay(CharacterClass characterClass, ushort fasterCastRate)
		{
			int num = CastRateBreakpoints.BreakpointTable[characterClass].Breakpoints.Select((int i) => (i > (int)fasterCastRate) ? 0 : 1).ToList<int>().Sum();
			int num2 = CastRateBreakpoints.BreakpointTable[characterClass].BaseFrame + 1 - num;
			return (uint)((float)(1000 * num2) / CastRateBreakpoints.FramesPerSecond);
		}

		// Token: 0x04006ECF RID: 28367
		private int BaseFrame = 23;

		// Token: 0x04006ED0 RID: 28368
		private List<int> Breakpoints = new List<int>();

		// Token: 0x04006ED1 RID: 28369
		private static float FramesPerSecond = 25f;

		// Token: 0x04006ED2 RID: 28370
		private static Dictionary<CharacterClass, CastRateBreakpoints> BreakpointTable = new Dictionary<CharacterClass, CastRateBreakpoints>
		{
			{
				CharacterClass.Amazon,
				new CastRateBreakpoints
				{
					BaseFrame = 19,
					Breakpoints = new List<int> { 0, 7, 14, 22, 32, 48, 68, 99, 152 }
				}
			},
			{
				CharacterClass.Assassin,
				new CastRateBreakpoints
				{
					BaseFrame = 16,
					Breakpoints = new List<int> { 0, 8, 16, 27, 42, 65, 102, 174 }
				}
			},
			{
				CharacterClass.Paladin,
				new CastRateBreakpoints
				{
					BaseFrame = 23,
					Breakpoints = new List<int> { 0, 9, 18, 30, 48, 75, 125 }
				}
			},
			{
				CharacterClass.Necromancer,
				new CastRateBreakpoints
				{
					BaseFrame = 23,
					Breakpoints = new List<int>
					{
						0, 6, 11, 18, 24, 35, 48, 65, 86, 120,
						180
					}
				}
			},
			{
				CharacterClass.Sorceress,
				new CastRateBreakpoints
				{
					BaseFrame = 13,
					Breakpoints = new List<int> { 0, 9, 20, 37, 63, 105, 200 }
				}
			},
			{
				(CharacterClass)9,
				new CastRateBreakpoints
				{
					BaseFrame = 13,
					Breakpoints = new List<int> { 0, 9, 20, 37, 63, 105, 200 }
				}
			}
		};
	}
}
