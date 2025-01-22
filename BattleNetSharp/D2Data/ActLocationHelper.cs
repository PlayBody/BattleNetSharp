using System;

namespace D2Data
{
	// Token: 0x0200090D RID: 2317
	public static class ActLocationHelper
	{
		// Token: 0x0600B869 RID: 47209 RVA: 0x002DDF68 File Offset: 0x002DC168
		public static ActLocation GetAct(AreaLevel level)
		{
			bool flag = level < AreaLevel.LutGholein;
			ActLocation actLocation;
			if (flag)
			{
				actLocation = ActLocation.Act1;
			}
			else
			{
				bool flag2 = level < AreaLevel.KurastDocks;
				if (flag2)
				{
					actLocation = ActLocation.Act2;
				}
				else
				{
					bool flag3 = level < AreaLevel.ThePandemoniumFortress;
					if (flag3)
					{
						actLocation = ActLocation.Act3;
					}
					else
					{
						bool flag4 = level < AreaLevel.Harrogath;
						if (flag4)
						{
							actLocation = ActLocation.Act4;
						}
						else
						{
							bool flag5 = level < AreaLevel.MatronsDen;
							if (flag5)
							{
								actLocation = ActLocation.Act5;
							}
							else
							{
								actLocation = ActLocation.None;
							}
						}
					}
				}
			}
			return actLocation;
		}
	}
}
