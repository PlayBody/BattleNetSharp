using System;

namespace D2Data
{
	// Token: 0x02000934 RID: 2356
	public static class EquipmentLocationHelper
	{
		// Token: 0x0600B965 RID: 47461 RVA: 0x00362864 File Offset: 0x00360A64
		public static EquipmentLocation GetEquipmentLocation(string s)
		{
			bool flag = s == "tors";
			EquipmentLocation equipmentLocation;
			if (flag)
			{
				equipmentLocation = EquipmentLocation.Armor;
			}
			else
			{
				bool flag2 = s == "rarm";
				if (flag2)
				{
					equipmentLocation = EquipmentLocation.RightHand;
				}
				else
				{
					bool flag3 = s == "larm";
					if (flag3)
					{
						equipmentLocation = EquipmentLocation.LeftHand;
					}
					else
					{
						bool flag4 = s == "rrin";
						if (flag4)
						{
							equipmentLocation = EquipmentLocation.RightHandRing;
						}
						else
						{
							bool flag5 = s == "lrin";
							if (flag5)
							{
								equipmentLocation = EquipmentLocation.LeftHandRing;
							}
							else
							{
								bool flag6 = s == "neck";
								if (flag6)
								{
									equipmentLocation = EquipmentLocation.Amulet;
								}
								else
								{
									bool flag7 = s == "belt";
									if (flag7)
									{
										equipmentLocation = EquipmentLocation.Belt;
									}
									else
									{
										bool flag8 = s == "feet";
										if (flag8)
										{
											equipmentLocation = EquipmentLocation.Boots;
										}
										else
										{
											bool flag9 = s == "glov";
											if (flag9)
											{
												equipmentLocation = EquipmentLocation.Gloves;
											}
											else
											{
												bool flag10 = s == "head";
												if (flag10)
												{
													equipmentLocation = EquipmentLocation.Helm;
												}
												else
												{
													equipmentLocation = EquipmentLocation.NotApplicable;
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return equipmentLocation;
		}
	}
}
