using System;
using System.Collections.Generic;

namespace D2Data
{
	// Token: 0x02000913 RID: 2323
	public class AttackSpeedBreakpoints
	{
		// Token: 0x0600B86F RID: 47215 RVA: 0x002DE1CC File Offset: 0x002DC3CC
		public static uint GetTimeDelay(CharacterClass characterClass, ushort weaponType, bool bearForm = false)
		{
			int num = AttackSpeedBreakpoints.BreakpointTable[characterClass].Hands[(int)weaponType];
			return (uint)((float)(1000 * num) / AttackSpeedBreakpoints.FramesPerSecond);
		}

		// Token: 0x04006B6C RID: 27500
		private List<int> Hands = new List<int>();

		// Token: 0x04006B6D RID: 27501
		private static float FramesPerSecond = 25f;

		// Token: 0x04006B6E RID: 27502
		private static Dictionary<CharacterClass, AttackSpeedBreakpoints> BreakpointTable = new Dictionary<CharacterClass, AttackSpeedBreakpoints>
		{
			{
				CharacterClass.Amazon,
				new AttackSpeedBreakpoints
				{
					Hands = new List<int> { 6, 0, 7, 10, 7, 9, 10, 7, 11 }
				}
			},
			{
				CharacterClass.Assassin,
				new AttackSpeedBreakpoints
				{
					Hands = new List<int> { 6, 8, 8, 13, 8, 13, 10, 9, 11 }
				}
			},
			{
				CharacterClass.Barbarian,
				new AttackSpeedBreakpoints
				{
					Hands = new List<int> { 6, 0, 9, 10, 10, 10, 10, 10, 10 }
				}
			},
			{
				CharacterClass.Druid,
				new AttackSpeedBreakpoints
				{
					Hands = new List<int> { 9, 0, 10, 11, 10, 13, 9, 9, 11 }
				}
			},
			{
				CharacterClass.Necromancer,
				new AttackSpeedBreakpoints
				{
					Hands = new List<int>()
				}
			},
			{
				CharacterClass.Paladin,
				new AttackSpeedBreakpoints
				{
					Hands = new List<int> { 7, 0, 8, 10, 9, 11, 10, 9, 11 }
				}
			},
			{
				CharacterClass.Sorceress,
				new AttackSpeedBreakpoints
				{
					Hands = new List<int> { 8, 0, 10, 12, 9, 11, 9, 9, 11 }
				}
			}
		};
	}
}
