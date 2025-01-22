using System;

namespace D2Data
{
	// Token: 0x0200090F RID: 2319
	public static class AreaLevelHelper
	{
		// Token: 0x0600B86A RID: 47210 RVA: 0x002DDFC4 File Offset: 0x002DC1C4
		public static AreaLevel GetTownLevel(ActLocation act)
		{
			bool flag = act == ActLocation.Act1;
			AreaLevel areaLevel;
			if (flag)
			{
				areaLevel = AreaLevel.RogueEncampment;
			}
			else
			{
				bool flag2 = act == ActLocation.Act2;
				if (flag2)
				{
					areaLevel = AreaLevel.LutGholein;
				}
				else
				{
					bool flag3 = act == ActLocation.Act3;
					if (flag3)
					{
						areaLevel = AreaLevel.KurastDocks;
					}
					else
					{
						bool flag4 = act == ActLocation.Act4;
						if (flag4)
						{
							areaLevel = AreaLevel.ThePandemoniumFortress;
						}
						else
						{
							bool flag5 = act == ActLocation.Act5;
							if (flag5)
							{
								areaLevel = AreaLevel.Harrogath;
							}
							else
							{
								bool flag6 = act == ActLocation.None;
								if (flag6)
								{
									areaLevel = AreaLevel.Invalid;
								}
								else
								{
									areaLevel = AreaLevel.None;
								}
							}
						}
					}
				}
			}
			return areaLevel;
		}

		// Token: 0x0600B86B RID: 47211 RVA: 0x002DE030 File Offset: 0x002DC230
		public static AreaLevel GetLastLevel(ActLocation act)
		{
			return (AreaLevel)(AreaLevelHelper.GetTownLevel(act + 1) - AreaLevel.RogueEncampment);
		}

		// Token: 0x0600B86C RID: 47212 RVA: 0x002DE050 File Offset: 0x002DC250
		public static AreaLevel GetAreaFromWp(WaypointsAvailable waypoint)
		{
			return (AreaLevel)Enum.Parse(typeof(AreaLevel), waypoint.ToString());
		}

		// Token: 0x0600B86D RID: 47213 RVA: 0x002DE084 File Offset: 0x002DC284
		public static WaypointsAvailable GetWpFromArea(AreaLevel area)
		{
			return (WaypointsAvailable)Enum.Parse(typeof(WaypointsAvailable), area.ToString());
		}

		// Token: 0x0600B86E RID: 47214 RVA: 0x002DE0B8 File Offset: 0x002DC2B8
		public static AreaLevel GetBaseLevel(AreaLevel refLevel)
		{
			bool flag = refLevel == AreaLevel.BloodMoor || refLevel == AreaLevel.ColdPlains || refLevel == AreaLevel.StonyField || refLevel == AreaLevel.BurialGrounds;
			AreaLevel areaLevel;
			if (flag)
			{
				areaLevel = AreaLevel.RogueEncampment;
			}
			else
			{
				bool flag2 = refLevel == AreaLevel.BlackMarsh || refLevel == AreaLevel.TamoeHighland || refLevel == AreaLevel.MonasteryGate || refLevel == AreaLevel.OuterCloister || refLevel == AreaLevel.Barracks;
				if (flag2)
				{
					areaLevel = AreaLevel.DarkWood;
				}
				else
				{
					bool flag3 = refLevel == AreaLevel.Cathedral;
					if (flag3)
					{
						areaLevel = AreaLevel.InnerCloister;
					}
					else
					{
						bool flag4 = refLevel == AreaLevel.RockyWaste || refLevel == AreaLevel.DryHills || refLevel == AreaLevel.FarOasis || refLevel == AreaLevel.LostCity || refLevel == AreaLevel.ValleyOfSnakes;
						if (flag4)
						{
							areaLevel = AreaLevel.LutGholein;
						}
						else
						{
							bool flag5 = refLevel == AreaLevel.SpiderForest || refLevel == AreaLevel.GreatMarsh || refLevel == AreaLevel.FlayerJungle || refLevel == AreaLevel.LowerKurast || refLevel == AreaLevel.KurastBazaar || refLevel == AreaLevel.UpperKurast || refLevel == AreaLevel.KurastCauseway || refLevel == AreaLevel.Travincal;
							if (flag5)
							{
								areaLevel = AreaLevel.KurastDocks;
							}
							else
							{
								bool flag6 = refLevel == AreaLevel.OuterSteppes || refLevel == AreaLevel.PlainsOfDespair || refLevel == AreaLevel.CityOfTheDamned;
								if (flag6)
								{
									areaLevel = AreaLevel.ThePandemoniumFortress;
								}
								else
								{
									bool flag7 = refLevel == AreaLevel.ChaosSanctuary;
									if (flag7)
									{
										areaLevel = AreaLevel.RiverOfFlame;
									}
									else
									{
										bool flag8 = refLevel == AreaLevel.BloodyFoothills || refLevel == AreaLevel.FrigidHighlands || refLevel == AreaLevel.ArreatPlateau;
										if (flag8)
										{
											areaLevel = AreaLevel.Harrogath;
										}
										else
										{
											areaLevel = refLevel;
										}
									}
								}
							}
						}
					}
				}
			}
			return areaLevel;
		}
	}
}
