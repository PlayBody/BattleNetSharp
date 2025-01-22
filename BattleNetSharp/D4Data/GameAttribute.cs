using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace D4Data
{
	// Token: 0x020008CD RID: 2253
	public class GameAttribute
	{
		// Token: 0x170037E5 RID: 14309
		// (get) Token: 0x0600B63B RID: 46651 RVA: 0x002C80D4 File Offset: 0x002C62D4
		public bool IsInteger
		{
			get
			{
				return this.EncodingType == GameAttributeEncoding.Int || this.EncodingType == GameAttributeEncoding.IntMinMax;
			}
		}

		// Token: 0x0600B63C RID: 46652 RVA: 0x002C80FB File Offset: 0x002C62FB
		public GameAttribute()
		{
		}

		// Token: 0x0600B63D RID: 46653 RVA: 0x002C811C File Offset: 0x002C631C
		public GameAttribute(int id, int defaultValue, int u3, int u4, int u5, string scriptA, string scriptB, string name, GameAttributeEncoding encodingType, byte flags, int min, int max, int bitCount)
		{
			this.Id = id;
			this._DefaultValue.Value = defaultValue;
			this.U3 = u3;
			this.U4 = u4;
			this.U5 = u5;
			this.ScriptA = scriptA;
			this.ScriptB = scriptB;
			this.Name = name;
			this.EncodingType = encodingType;
			this.Flags = (ReplicationFlags)flags;
			this.Min = new GameAttributeValue(min);
			this.Max = new GameAttributeValue(max);
			this.BitCount = bitCount;
		}

		// Token: 0x0600B63E RID: 46654 RVA: 0x002C81BC File Offset: 0x002C63BC
		public GameAttribute(int id, float defaultValue, int u3, int u4, int u5, string scriptA, string scriptB, string name, GameAttributeEncoding encodingType, byte flags, float min, float max, int bitCount)
		{
			this.Id = id;
			this._DefaultValue.ValueF = defaultValue;
			this.U3 = u3;
			this.U4 = u4;
			this.U5 = u5;
			this.ScriptA = scriptA;
			this.ScriptB = scriptB;
			this.Name = name;
			this.EncodingType = encodingType;
			this.Flags = (ReplicationFlags)flags;
			this.Min = new GameAttributeValue(min);
			this.Max = new GameAttributeValue(max);
			this.BitCount = bitCount;
		}

		// Token: 0x0600B63F RID: 46655 RVA: 0x002C825C File Offset: 0x002C645C
		static GameAttribute()
		{
			ScriptedAttributeInitializer.ProcessAttributes(GameAttribute.Attributes);
		}

		// Token: 0x0400654A RID: 25930
		public const float Float16Min = -65536f;

		// Token: 0x0400654B RID: 25931
		public const float Float16Max = 65536f;

		// Token: 0x0400654C RID: 25932
		public int Id;

		// Token: 0x0400654D RID: 25933
		public GameAttributeValue _DefaultValue;

		// Token: 0x0400654E RID: 25934
		public int U3;

		// Token: 0x0400654F RID: 25935
		public int U4;

		// Token: 0x04006550 RID: 25936
		public int U5;

		// Token: 0x04006551 RID: 25937
		public string ScriptA;

		// Token: 0x04006552 RID: 25938
		public string ScriptB;

		// Token: 0x04006553 RID: 25939
		public string Name;

		// Token: 0x04006554 RID: 25940
		public GameAttributeEncoding EncodingType;

		// Token: 0x04006555 RID: 25941
		public ReplicationFlags Flags;

		// Token: 0x04006556 RID: 25942
		public GameAttributeValue Min;

		// Token: 0x04006557 RID: 25943
		public GameAttributeValue Max;

		// Token: 0x04006558 RID: 25944
		public int BitCount;

		// Token: 0x04006559 RID: 25945
		public Func<GameAttributeMap, int?, GameAttributeValue> ScriptFunc = null;

		// Token: 0x0400655A RID: 25946
		public List<GameAttributeDependency> Dependents = null;

		// Token: 0x0400655B RID: 25947
		public bool ScriptedAndSettable = false;

		// Token: 0x0400655C RID: 25948
		public static readonly GameAttribute[] Attributes = (from a in typeof(GameAttribute).GetFields()
			where a.IsStatic && (a.FieldType.Name == "GameAttributeI" || a.FieldType.Name == "GameAttributeF" || a.FieldType.Name == "GameAttributeB")
			select a.GetValue(null) as GameAttribute into a
			orderby a.Id
			select a).ToArray<GameAttribute>();

		// Token: 0x0400655D RID: 25949
		public static readonly GameAttributeF Axe_Bad_Data = new GameAttributeF(0, 0f, -1, 0, 0, "", "", "Axe_Bad_Data", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400655E RID: 25950
		public static readonly GameAttributeF Strength = new GameAttributeF(2, 0f, -1, 0, 0, "", "", "Strength", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400655F RID: 25951
		public static readonly GameAttributeF Intelligence = new GameAttributeF(3, 0f, -1, 0, 0, "", "", "Intelligence", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006560 RID: 25952
		public static readonly GameAttributeF Willpower = new GameAttributeF(4, 0f, -1, 0, 0, "", "", "Willpower", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006561 RID: 25953
		public static readonly GameAttributeF Dexterity = new GameAttributeF(5, 0f, -1, 0, 0, "", "", "Dexterity", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006562 RID: 25954
		public static readonly GameAttributeF Plus_All_Stats = new GameAttributeF(6, 0f, -1, 0, 0, "", "", "Plus_All_Stats", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006563 RID: 25955
		public static readonly GameAttributeF Strength_Core = new GameAttributeF(7, 0f, -1, 0, 0, "", "", "Strength_Core", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006564 RID: 25956
		public static readonly GameAttributeF Intelligence_Core = new GameAttributeF(8, 0f, -1, 0, 0, "", "", "Intelligence_Core", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006565 RID: 25957
		public static readonly GameAttributeF Willpower_Core = new GameAttributeF(9, 0f, -1, 0, 0, "", "", "Willpower_Core", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006566 RID: 25958
		public static readonly GameAttributeF Dexterity_Core = new GameAttributeF(10, 0f, -1, 0, 0, "", "", "Dexterity_Core", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006567 RID: 25959
		public static readonly GameAttributeF Strength_Percent_Bonus = new GameAttributeF(11, 0f, -1, 0, 0, "", "", "Strength_Percent_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006568 RID: 25960
		public static readonly GameAttributeF Intelligence_Percent_Bonus = new GameAttributeF(12, 0f, -1, 0, 0, "", "", "Intelligence_Percent_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006569 RID: 25961
		public static readonly GameAttributeF Willpower_Percent_Bonus = new GameAttributeF(13, 0f, -1, 0, 0, "", "", "Willpower_Percent_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400656A RID: 25962
		public static readonly GameAttributeF Dexterity_Percent_Bonus = new GameAttributeF(14, 0f, -1, 0, 0, "", "", "Dexterity_Percent_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400656B RID: 25963
		public static readonly GameAttributeF All_Stats_Percent_Bonus = new GameAttributeF(15, 0f, -1, 0, 0, "", "", "All_Stats_Percent_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400656C RID: 25964
		public static readonly GameAttributeF Strength_Total = new GameAttributeF(16, 0f, -1, 0, 0, "(Strength     + Strength_Core     + Plus_All_Stats + Core_Stats_Bonus_Strength)     * (1.0 + (Strength_Percent_Bonus     + All_Stats_Percent_Bonus))", "", "Strength_Total", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400656D RID: 25965
		public static readonly GameAttributeF Intelligence_Total = new GameAttributeF(17, 0f, -1, 0, 0, "(Intelligence + Intelligence_Core + Plus_All_Stats + Core_Stats_Bonus_Intelligence) * (1.0 + (Intelligence_Percent_Bonus + All_Stats_Percent_Bonus))", "", "Intelligence_Total", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400656E RID: 25966
		public static readonly GameAttributeF Willpower_Total = new GameAttributeF(18, 0f, -1, 0, 0, "(Willpower    + Willpower_Core    + Plus_All_Stats + Core_Stats_Bonus_Willpower)    * (1.0 + (Willpower_Percent_Bonus    + All_Stats_Percent_Bonus))", "", "Willpower_Total", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400656F RID: 25967
		public static readonly GameAttributeF Dexterity_Total = new GameAttributeF(19, 0f, -1, 0, 0, "(Dexterity    + Dexterity_Core    + Plus_All_Stats + Core_Stats_Bonus_Dexterity)    * (1.0 + (Dexterity_Percent_Bonus    + All_Stats_Percent_Bonus))", "", "Dexterity_Total", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006570 RID: 25968
		public static readonly GameAttributeF Core_Stats_Bonus_Strength = new GameAttributeF(20, 0f, -1, 0, 0, "", "", "Core_Stats_Bonus_Strength", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006571 RID: 25969
		public static readonly GameAttributeF Core_Stats_Bonus_Intelligence = new GameAttributeF(21, 0f, -1, 0, 0, "", "", "Core_Stats_Bonus_Intelligence", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006572 RID: 25970
		public static readonly GameAttributeF Core_Stats_Bonus_Willpower = new GameAttributeF(22, 0f, -1, 0, 0, "", "", "Core_Stats_Bonus_Willpower", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006573 RID: 25971
		public static readonly GameAttributeF Core_Stats_Bonus_Dexterity = new GameAttributeF(23, 0f, -1, 0, 0, "", "", "Core_Stats_Bonus_Dexterity", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006574 RID: 25972
		public static readonly GameAttributeI Experience_Next_Lo = new GameAttributeI(30, 0, -1, 0, 0, "", "", "Experience_Next_Lo", GameAttributeEncoding.Int, 0, 0, 0, 32);

		// Token: 0x04006575 RID: 25973
		public static readonly GameAttributeI Experience_Granted = new GameAttributeI(28, 0, -1, 0, 0, "", "", "Experience_Granted", GameAttributeEncoding.Int, 0, 0, 0, 32);

		// Token: 0x04006576 RID: 25974
		public static readonly GameAttributeI Rest_Experience_Hi = new GameAttributeI(31, 0, -1, 0, 0, "", "", "Rest_Experience_Hi", GameAttributeEncoding.Int, 0, 0, 0, 32);

		// Token: 0x04006577 RID: 25975
		public static readonly GameAttributeI Experience_Next_Hi = new GameAttributeI(29, 0, -1, 0, 0, "", "", "Experience_Next_Hi", GameAttributeEncoding.Int, 0, 0, 0, 32);

		// Token: 0x04006578 RID: 25976
		public static readonly GameAttributeF Rest_Experience_Lo = new GameAttributeF(32, 0f, -1, 0, 0, "", "", "Rest_Experience_Lo", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006579 RID: 25977
		public static readonly GameAttributeF Gold_Granted = new GameAttributeF(34, 0f, -1, 0, 0, "", "", "Gold_Granted", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400657A RID: 25978
		public static readonly GameAttributeF Pet_Flat_Health = new GameAttributeF(45, 0f, -1, 0, 0, "", "", "Pet_Flat_Health", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400657B RID: 25979
		public static readonly GameAttributeF Pet_Health_Bonus_Percent = new GameAttributeF(46, 0f, -1, 0, 0, "", "", "Pet_Health_Bonus_Percent", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400657C RID: 25980
		public static readonly GameAttributeF Pet_Armor_Bonus_Percent = new GameAttributeF(47, 0f, -1, 0, 0, "", "", "Pet_Armor_Bonus_Percent", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400657D RID: 25981
		public static readonly GameAttributeF Pet_All_Resistance_Bonus_Percent = new GameAttributeF(48, 0f, -1, 0, 0, "", "", "Pet_All_Resistance_Bonus_Percent", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400657E RID: 25982
		public static readonly GameAttributeF Debug_Damage_Percent_Bonus = new GameAttributeF(49, 0f, -1, 0, 0, "", "", "Debug_Damage_Percent_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400657F RID: 25983
		public static readonly GameAttributeF Debug_Damage_Reduction_Percent_Bonus = new GameAttributeF(50, 0f, -1, 0, 0, "", "", "Debug_Damage_Reduction_Percent_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006580 RID: 25984
		public static readonly GameAttributeF Debug_Stagger_Percent_Bonus = new GameAttributeF(51, 0f, -1, 0, 0, "", "", "Debug_Stagger_Percent_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006581 RID: 25985
		public static readonly GameAttributeF Debug_Extra_Zone_Progress_Per_Zone = new GameAttributeF(52, 0f, -1, 0, 0, "", "", "Debug_Extra_Zone_Progress_Per_Zone", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006582 RID: 25986
		public static readonly GameAttributeF Monster_Combat_Item_Power_Delta_KeyDun = new GameAttributeF(53, 0f, -1, 0, 0, "", "", "Monster_Combat_Item_Power_Delta_KeyDun", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006583 RID: 25987
		public static readonly GameAttributeF Damage_Percent_Bonus_KeyDun = new GameAttributeF(55, 0f, -1, 0, 0, "", "", "Damage_Percent_Bonus_KeyDun", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006584 RID: 25988
		public static readonly GameAttributeF Experience_Bonus_Percent_Total = new GameAttributeF(63, 0f, -1, 0, 0, "Experience_Bonus_Percent ", "", "Experience_Bonus_Percent_Total", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006585 RID: 25989
		public static readonly GameAttributeI Skill_Points_Bonus = new GameAttributeI(73, 0, -1, 0, 0, "", "", "Skill_Points_Bonus", GameAttributeEncoding.Int, 0, 0, 0, 32);

		// Token: 0x04006586 RID: 25990
		public static readonly GameAttributeI Skill_Points_Earned = new GameAttributeI(74, 0, -1, 0, 0, "", "", "Skill_Points_Earned", GameAttributeEncoding.Int, 0, 0, 0, 32);

		// Token: 0x04006587 RID: 25991
		public static readonly GameAttributeI Skill_Points_Earned_Total = new GameAttributeI(75, 0, -1, 0, 0, "Skill_Points_Earned + Skill_Points_Bonus", "", "Skill_Points_Earned_Total", GameAttributeEncoding.Int, 0, 0, 0, 32);

		// Token: 0x04006588 RID: 25992
		public static readonly GameAttributeI Skill_Points_Spent = new GameAttributeI(76, 0, -1, 0, 0, "", "", "Skill_Points_Spent", GameAttributeEncoding.Int, 0, 0, 0, 32);

		// Token: 0x04006589 RID: 25993
		public static readonly GameAttributeF Skill_Tree_Skill_Mod_Unlocked = new GameAttributeF(78, 0f, -1, 0, 0, "", "", "Skill_Tree_Skill_Mod_Unlocked", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400658A RID: 25994
		public static readonly GameAttributeF Death_Reason = new GameAttributeF(83, 0f, -1, 0, 0, "", "", "Death_Reason", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400658B RID: 25995
		public static readonly GameAttributeF Loading_Player_ACD = new GameAttributeF(87, -1f, -1, 0, 0, "", "", "Loading_Player_ACD", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400658C RID: 25996
		public static readonly GameAttributeF Loading_Power_SNO = new GameAttributeF(88, -1f, -1, 0, 0, "", "", "Loading_Power_SNO", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400658D RID: 25997
		public static readonly GameAttributeF Loading_Anim_Key = new GameAttributeF(89, -1f, -1, 0, 0, "", "", "Loading_Anim_Key", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400658E RID: 25998
		public static readonly GameAttributeF Hitpoints_Cur = new GameAttributeF(92, 0f, -1, 0, 0, "Min(Hitpoints_Cur.Agg, Hitpoints_Max_Total)", "", "Hitpoints_Cur", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400658F RID: 25999
		public static readonly GameAttributeF Hitpoints_Granted = new GameAttributeF(93, 0f, -1, 0, 0, "", "", "Hitpoints_Granted", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006590 RID: 26000
		public static readonly GameAttributeF Hitpoints_Over_Time_Granted_Duration = new GameAttributeF(94, 0f, -1, 0, 0, "", "", "Hitpoints_Over_Time_Granted_Duration", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006591 RID: 26001
		public static readonly GameAttributeF Hitpoints_Max_Total = new GameAttributeF(97, 0f, -1, 0, 0, "Max((Hitpoints_Max + Hitpoints_Max_Bonus) * (1 + Hitpoints_Max_Percent_Bonus) * (1 + Hitpoints_Max_Percent_Bonus_Item) * (1 + Hitpoints_Max_Percent_Bonus_KeyDun), 0.01)", "", "Hitpoints_Max_Total", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006592 RID: 26002
		public static readonly GameAttributeF Hitpoints_Regen_Per_Second_Subtotal = new GameAttributeF(110, 0f, -1, 0, 0, "(Hitpoints_Regen_Per_Second + Hitpoints_Regen_Per_Second_Bonus) * (1 + Hitpoints_Regen_Bonus_Percent)", "", "Hitpoints_Regen_Per_Second_Subtotal", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006593 RID: 26003
		public static readonly GameAttributeF Hitpoints_Regen_Per_Second_Total = new GameAttributeF(113, 0f, -1, 0, 0, "(Hitpoints_Regen_Per_Second_Subtotal * Pin(1 - Hitpoints_Regen_Reduction_Percent, 0, 1)) + Hitpoints_Regen_Per_Second_Health_Globe", "", "Hitpoints_Regen_Per_Second_Total", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006594 RID: 26004
		public static readonly GameAttributeF DOT_Damage_Taken_Queued = new GameAttributeF(118, 0f, -1, 0, 0, "", "", "DOT_Damage_Taken_Queued", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006595 RID: 26005
		public static readonly GameAttributeF DOT_Damage_Taken_Queued_Scaled = new GameAttributeF(119, 0f, -1, 0, 0, "", "", "DOT_Damage_Taken_Queued_Scaled", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006596 RID: 26006
		public static readonly GameAttributeF Damage_Shield_Amount_Queued = new GameAttributeF(120, 0f, -1, 0, 0, "", "", "Damage_Shield_Amount_Queued", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006597 RID: 26007
		public static readonly GameAttributeF DOT_Damage_Taken_Queued_Player = new GameAttributeF(121, 0f, -1, 0, 0, "", "", "DOT_Damage_Taken_Queued_Player", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006598 RID: 26008
		public static readonly GameAttributeF DOT_Damage_Taken_Queued_Player_Scaled = new GameAttributeF(122, 0f, -1, 0, 0, "", "", "DOT_Damage_Taken_Queued_Player_Scaled", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006599 RID: 26009
		public static readonly GameAttributeF Resource_Cur = new GameAttributeF(125, 0f, -1, 0, 0, "", "", "Resource_Cur", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400659A RID: 26010
		public static readonly GameAttributeF Resource_Max_Total = new GameAttributeF(131, 0f, -1, 0, 0, "Max((Resource_Max + ((Level#NONE - 1) * Resource_Max_Per_Level) + Resource_Max_Bonus) * (Resource_Max_Percent_Bonus + 1), 0)", "", "Resource_Max_Total", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400659B RID: 26011
		public static readonly GameAttributeF Resource_Cost_Reduction_Percent_Total = new GameAttributeF(143, 0f, -1, 0, 0, "1.0 - ((1.0 - Resource_Cost_Reduction_Percent) * (1.0 - Resource_Cost_Reduction_Percent_All#NONE))", "", "Resource_Cost_Reduction_Percent_Total", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400659C RID: 26012
		public static readonly GameAttributeF Walking_Rate = new GameAttributeF(155, 0f, -1, 0, 0, "", "", "Walking_Rate", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400659D RID: 26013
		public static readonly GameAttributeF Running_Rate = new GameAttributeF(156, 0f, -1, 0, 0, "", "", "Running_Rate", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400659E RID: 26014
		public static readonly GameAttributeF Sprinting_Rate = new GameAttributeF(157, 0f, -1, 0, 0, "", "", "Sprinting_Rate", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400659F RID: 26015
		public static readonly GameAttributeF Strafing_Rate = new GameAttributeF(158, 0f, -1, 0, 0, "", "", "Strafing_Rate", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065A0 RID: 26016
		public static readonly GameAttributeF Walking_Rate_Total = new GameAttributeF(159, 0f, -1, 0, 0, "Walking_Rate * Movement_Scalar_Total", "", "Walking_Rate_Total", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065A1 RID: 26017
		public static readonly GameAttributeF Running_Rate_Total = new GameAttributeF(160, 0f, -1, 0, 0, "Running_Rate * Movement_Scalar_Total", "", "Running_Rate_Total", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065A2 RID: 26018
		public static readonly GameAttributeF Sprinting_Rate_Total = new GameAttributeF(162, 0f, -1, 0, 0, "Sprinting_Rate * Movement_Scalar_Total", "", "Sprinting_Rate_Total", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065A3 RID: 26019
		public static readonly GameAttributeF Strafing_Rate_Total = new GameAttributeF(163, 0f, -1, 0, 0, "Strafing_Rate * Movement_Scalar_Total", "", "Strafing_Rate_Total", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065A4 RID: 26020
		public static readonly GameAttributeF Movement_Scalar_Total = new GameAttributeF(168, 0f, -1, 0, 0, "Movement_Scalar_Capped_Total + Movement_Scalar_Uncapped_Bonus", "", "Movement_Scalar_Total", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065A5 RID: 26021
		public static readonly GameAttributeF Movement_Scalar_Cap = new GameAttributeF(170, 0f, -1, 0, 0, "", "", "Movement_Scalar_Cap", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065A6 RID: 26022
		public static readonly GameAttributeF Turn_Speed = new GameAttributeF(175, 0f, -1, 0, 0, "", "", "Turn_Speed", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065A7 RID: 26023
		public static readonly GameAttributeF Run_Turn_Speed = new GameAttributeF(176, 0f, -1, 0, 0, "", "", "Run_Turn_Speed", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065A8 RID: 26024
		public static readonly GameAttributeF Default_Attack_Turn_Speed = new GameAttributeF(177, 0f, -1, 0, 0, "", "", "Default_Attack_Turn_Speed", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065A9 RID: 26025
		public static readonly GameAttributeF Dynamic_Movement_Data_Override = new GameAttributeF(178, -1f, -1, 0, 0, "", "", "Dynamic_Movement_Data_Override", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065AA RID: 26026
		public static readonly GameAttributeF Attack_Speed_Percent_Bonus = new GameAttributeF(180, 0f, -1, 0, 0, "", "", "Attack_Speed_Percent_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065AB RID: 26027
		public static readonly GameAttributeF Attack_Speed_Percent_Reduction = new GameAttributeF(181, 0f, -1, 0, 0, "", "", "Attack_Speed_Percent_Reduction", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065AC RID: 26028
		public static readonly GameAttributeF Weapon_Speed_Percent_Bonus = new GameAttributeF(182, 0f, -1, 0, 0, "", "", "Weapon_Speed_Percent_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065AD RID: 26029
		public static readonly GameAttributeF Weapon_Speed_Percent_Reduction = new GameAttributeF(183, 0f, -1, 0, 0, "", "", "Weapon_Speed_Percent_Reduction", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065AE RID: 26030
		public static readonly GameAttributeF Attacks_Per_Second_Total = new GameAttributeF(184, 1.0653532E+09f, -1, 0, 0, "(1.0 + Attack_Speed_Percent_Bonus + Weapon_Speed_Percent_Bonus - Attack_Speed_Percent_Reduction - Weapon_Speed_Percent_Reduction)", "", "Attacks_Per_Second_Total", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065AF RID: 26031
		public static readonly GameAttributeF Attack_Speed_Percent_Bonus_For_Power = new GameAttributeF(185, 0f, -1, 0, 0, "", "", "Attack_Speed_Percent_Bonus_For_Power", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065B0 RID: 26032
		public static readonly GameAttributeF Attack_Speed_Percent_Bonus_While_Fortified = new GameAttributeF(186, 0f, -1, 0, 0, "", "", "Attack_Speed_Percent_Bonus_While_Fortified", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065B1 RID: 26033
		public static readonly GameAttributeF Attack_Speed_Percent_Bonus_Per_Skill_Tag = new GameAttributeF(187, 0f, -1, 0, 0, "", "", "Attack_Speed_Percent_Bonus_Per_Skill_Tag", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065B2 RID: 26034
		public static readonly GameAttributeF Damage_Actor_Scalar = new GameAttributeF(200, 0f, -1, 0, 0, "", "", "Damage_Actor_Scalar", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065B3 RID: 26035
		public static readonly GameAttributeF Damage_Percent_All_From_Skills = new GameAttributeF(201, 0f, -1, 0, 0, "", "", "Damage_Percent_All_From_Skills", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065B4 RID: 26036
		public static readonly GameAttributeF Multiplicative_Damage_Percent_All_From_Skills = new GameAttributeF(202, 0f, -1, 0, 0, "", "", "Multiplicative_Damage_Percent_All_From_Skills", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065B5 RID: 26037
		public static readonly GameAttributeF Damage_Type_Percent_Bonus = new GameAttributeF(203, 0f, -1, 0, 0, "", "", "Damage_Type_Percent_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065B6 RID: 26038
		public static readonly GameAttributeF Multiplicative_Damage_Type_Percent_Bonus = new GameAttributeF(204, 0f, -1, 0, 0, "", "", "Multiplicative_Damage_Type_Percent_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065B7 RID: 26039
		public static readonly GameAttributeF NonPhysical_Damage_Percent_Bonus = new GameAttributeF(205, 0f, -1, 0, 0, "", "", "NonPhysical_Damage_Percent_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065B8 RID: 26040
		public static readonly GameAttributeF Damage_Percent_Bonus_To_Targets_Affected_By_Skill_Tag = new GameAttributeF(206, 0f, -1, 0, 0, "", "", "Damage_Percent_Bonus_To_Targets_Affected_By_Skill_Tag", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065B9 RID: 26041
		public static readonly GameAttributeF Damage_Percent_Bonus_Per_Skill_Tag = new GameAttributeF(207, 0f, -1, 0, 0, "", "", "Damage_Percent_Bonus_Per_Skill_Tag", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065BA RID: 26042
		public static readonly GameAttributeF Multiplicative_Damage_Percent_Bonus_Per_Skill_Tag = new GameAttributeF(208, 0f, -1, 0, 0, "", "", "Multiplicative_Damage_Percent_Bonus_Per_Skill_Tag", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065BB RID: 26043
		public static readonly GameAttributeF Damage_Percent_Bonus_Per_Weapon_Requirement = new GameAttributeF(209, 0f, -1, 0, 0, "", "", "Damage_Percent_Bonus_Per_Weapon_Requirement", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065BC RID: 26044
		public static readonly GameAttributeF Main_Hand_Damage_Percent_Bonus = new GameAttributeF(210, 0f, -1, 0, 0, "", "", "Main_Hand_Damage_Percent_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065BD RID: 26045
		public static readonly GameAttributeF Flat_Damage_Bonus = new GameAttributeF(211, 0f, -1, 0, 0, "", "", "Flat_Damage_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065BE RID: 26046
		public static readonly GameAttributeF Flat_Damage_Bonus_Unscaled_By_Player_Health = new GameAttributeF(212, 0f, -1, 0, 0, "", "", "Flat_Damage_Bonus_Unscaled_By_Player_Health", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065BF RID: 26047
		public static readonly GameAttributeF Power_Flat_Damage_Bonus = new GameAttributeF(213, 0f, -1, 0, 0, "", "", "Power_Flat_Damage_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065C0 RID: 26048
		public static readonly GameAttributeF Power_Flat_Damage_Bonus_Unscaled_By_Player_Health = new GameAttributeF(214, 0f, -1, 0, 0, "", "", "Power_Flat_Damage_Bonus_Unscaled_By_Player_Health", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065C1 RID: 26049
		public static readonly GameAttributeF Flat_Damage_On_Hit = new GameAttributeF(215, 0f, -1, 0, 0, "", "", "Flat_Damage_On_Hit", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065C2 RID: 26050
		public static readonly GameAttributeF Flat_Damage_On_Hit_Unscaled_By_Player_Health = new GameAttributeF(216, 0f, -1, 0, 0, "", "", "Flat_Damage_On_Hit_Unscaled_By_Player_Health", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065C3 RID: 26051
		public static readonly GameAttributeF Crit_Percent_Base = new GameAttributeF(217, 0f, -1, 0, 0, "", "", "Crit_Percent_Base", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065C4 RID: 26052
		public static readonly GameAttributeF Crit_Percent_Bonus = new GameAttributeF(218, 0f, -1, 0, 0, "", "", "Crit_Percent_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065C5 RID: 26053
		public static readonly GameAttributeF Crit_Percent_Bonus_Per_Skill_Tag = new GameAttributeF(219, 0f, -1, 0, 0, "", "", "Crit_Percent_Bonus_Per_Skill_Tag", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065C6 RID: 26054
		public static readonly GameAttributeF Crit_Percent_Bonus_To_Vulnerable = new GameAttributeF(224, 0f, -1, 0, 0, "", "", "Crit_Percent_Bonus_To_Vulnerable", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065C7 RID: 26055
		public static readonly GameAttributeF Crit_Percent_Bonus_To_Low_Health = new GameAttributeF(225, 0f, -1, 0, 0, "", "", "Crit_Percent_Bonus_To_Low_Health", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065C8 RID: 26056
		public static readonly GameAttributeF Crit_Percent_Bonus_Per_Weapon_Requirement = new GameAttributeF(226, 0f, -1, 0, 0, "", "", "Crit_Percent_Bonus_Per_Weapon_Requirement", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065C9 RID: 26057
		public static readonly GameAttributeF Crit_Damage_Percent = new GameAttributeF(227, 0f, -1, 0, 0, "", "", "Crit_Damage_Percent", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065CA RID: 26058
		public static readonly GameAttributeF Multiplicative_Crit_Damage_Percent = new GameAttributeF(228, 0f, -1, 0, 0, "", "", "Multiplicative_Crit_Damage_Percent", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065CB RID: 26059
		public static readonly GameAttributeF Crit_Damage_Percent_Per_Skill_Tag = new GameAttributeF(229, 0f, -1, 0, 0, "", "", "Crit_Damage_Percent_Per_Skill_Tag", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065CC RID: 26060
		public static readonly GameAttributeF Multiplicative_Crit_Damage_Percent_Per_Skill_Tag = new GameAttributeF(230, 0f, -1, 0, 0, "", "", "Multiplicative_Crit_Damage_Percent_Per_Skill_Tag", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065CD RID: 26061
		public static readonly GameAttributeF Damage_Type_Crit_Damage_Percent_Bonus = new GameAttributeF(231, 0f, -1, 0, 0, "", "", "Damage_Type_Crit_Damage_Percent_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065CE RID: 26062
		public static readonly GameAttributeF Non_Physical_Crit_Damage_Percent_Bonus = new GameAttributeF(232, 0f, -1, 0, 0, "", "", "Non_Physical_Crit_Damage_Percent_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065CF RID: 26063
		public static readonly GameAttributeF Crit_Damage_Scalar_Reduction_Percent = new GameAttributeF(237, 0f, -1, 0, 0, "", "", "Crit_Damage_Scalar_Reduction_Percent", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065D0 RID: 26064
		public static readonly GameAttributeF Crit_Damage_Percent_Per_Weapon_Requirement = new GameAttributeF(238, 0f, -1, 0, 0, "", "", "Crit_Damage_Percent_Per_Weapon_Requirement", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065D1 RID: 26065
		public static readonly GameAttributeF Crit_Damage_Percent_For_Power = new GameAttributeF(239, 0f, -1, 0, 0, "", "", "Crit_Damage_Percent_For_Power", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065D2 RID: 26066
		public static readonly GameAttributeF Overpower_Chance_Base = new GameAttributeF(243, 0f, -1, 0, 0, "", "", "Overpower_Chance_Base", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065D3 RID: 26067
		public static readonly GameAttributeF Overpower_Chance_Bonus = new GameAttributeF(244, 0f, -1, 0, 0, "", "", "Overpower_Chance_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065D4 RID: 26068
		public static readonly GameAttributeF Overpower_Chance_Bonus_Per_Skill_Tag = new GameAttributeF(245, 0f, -1, 0, 0, "", "", "Overpower_Chance_Bonus_Per_Skill_Tag", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065D5 RID: 26069
		public static readonly GameAttributeF Overpower_Chance_Bonus_Per_Skill = new GameAttributeF(246, 0f, -1, 0, 0, "", "", "Overpower_Chance_Bonus_Per_Skill", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065D6 RID: 26070
		public static readonly GameAttributeF Overpower_Damage_Bonus_Per_Skill = new GameAttributeF(247, 0f, -1, 0, 0, "", "", "Overpower_Damage_Bonus_Per_Skill", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065D7 RID: 26071
		public static readonly GameAttributeF Overpower_Chance_Reduction_Percent = new GameAttributeF(248, 0f, -1, 0, 0, "", "", "Overpower_Chance_Reduction_Percent", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065D8 RID: 26072
		public static readonly GameAttributeF Overpower_Damage_Percent_Bonus = new GameAttributeF(249, 0f, -1, 0, 0, "", "", "Overpower_Damage_Percent_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065D9 RID: 26073
		public static readonly GameAttributeF Multiplicative_Overpower_Damage_Percent_Bonus = new GameAttributeF(250, 0f, -1, 0, 0, "", "", "Multiplicative_Overpower_Damage_Percent_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065DA RID: 26074
		public static readonly GameAttributeF Overpower_Damage_Percent_Bonus_Per_Skill_Tag = new GameAttributeF(251, 0f, -1, 0, 0, "", "", "Overpower_Damage_Percent_Bonus_Per_Skill_Tag", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065DB RID: 26075
		public static readonly GameAttributeF Overpower_Damage_Percent_Bonus_Per_Weapon_Requirement = new GameAttributeF(252, 0f, -1, 0, 0, "", "", "Overpower_Damage_Percent_Bonus_Per_Weapon_Requirement", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065DC RID: 26076
		public static readonly GameAttributeF Multiplicative_Overpower_Damage_Percent_Bonus_Per_Weapon_Requirement = new GameAttributeF(253, 0f, -1, 0, 0, "", "", "Multiplicative_Overpower_Damage_Percent_Bonus_Per_Weapon_Requirement", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065DD RID: 26077
		public static readonly GameAttributeF Bonus_Ice_Armor_Shield_Percent = new GameAttributeF(264, 0f, -1, 0, 0, "", "", "Bonus_Ice_Armor_Shield_Percent", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065DE RID: 26078
		public static readonly GameAttributeF Trap_Arm_Time_Reduction_Seconds = new GameAttributeF(265, 0f, -1, 0, 0, "", "", "Trap_Arm_Time_Reduction_Seconds", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065DF RID: 26079
		public static readonly GameAttributeF Armor_Ignore_Damage_Percent = new GameAttributeF(271, 0f, -1, 0, 0, "", "", "Armor_Ignore_Damage_Percent", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065E0 RID: 26080
		public static readonly GameAttributeF Damage_Armor = new GameAttributeF(272, 0f, -1, 0, 0, "", "", "Damage_Armor", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065E1 RID: 26081
		public static readonly GameAttributeF Dodge_Chance_Bonus_Additive = new GameAttributeF(277, 0f, -1, 0, 0, "", "", "Dodge_Chance_Bonus_Additive", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065E2 RID: 26082
		public static readonly GameAttributeF Dodge_Chance_Bonus_Hide_From_Toughness = new GameAttributeF(278, 0f, -1, 0, 0, "", "", "Dodge_Chance_Bonus_Hide_From_Toughness", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065E3 RID: 26083
		public static readonly GameAttributeF Dodge_Chance_Bonus_From_Dotted_Enemies = new GameAttributeF(279, 0f, -1, 0, 0, "", "", "Dodge_Chance_Bonus_From_Dotted_Enemies", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065E4 RID: 26084
		public static readonly GameAttributeF Last_Damage_MainActor = new GameAttributeF(282, -1f, -1, 0, 0, "", "", "Last_Damage_MainActor", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065E5 RID: 26085
		public static readonly GameAttributeF Last_ACD_Attacked = new GameAttributeF(283, -1f, -1, 0, 0, "", "", "Last_ACD_Attacked", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065E6 RID: 26086
		public static readonly GameAttributeF Thorns_Percent = new GameAttributeF(302, 0f, -1, 0, 0, "", "", "Thorns_Percent", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065E7 RID: 26087
		public static readonly GameAttributeF Thorns_Flat = new GameAttributeF(303, 0f, -1, 0, 0, "", "", "Thorns_Flat", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065E8 RID: 26088
		public static readonly GameAttributeF Thorns_Flat_Unscaled_By_Player_Health = new GameAttributeF(304, 0f, -1, 0, 0, "", "", "Thorns_Flat_Unscaled_By_Player_Health", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065E9 RID: 26089
		public static readonly GameAttributeF Thorns_AOE_Radius = new GameAttributeF(305, 0f, -1, 0, 0, "", "", "Thorns_AOE_Radius", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065EA RID: 26090
		public static readonly GameAttributeF Thorns_Enabled_Flags = new GameAttributeF(306, -1f, -1, 0, 0, "", "", "Thorns_Enabled_Flags", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065EB RID: 26091
		public static readonly GameAttributeF Steal_Health_Percent = new GameAttributeF(307, 0f, -1, 0, 0, "", "", "Steal_Health_Percent", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065EC RID: 26092
		public static readonly GameAttributeF Steal_Mana_Percent = new GameAttributeF(308, 0f, -1, 0, 0, "", "", "Steal_Mana_Percent", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065ED RID: 26093
		public static readonly GameAttributeF Last_Proc_Time = new GameAttributeF(322, 0f, -1, 0, 0, "", "", "Last_Proc_Time", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065EE RID: 26094
		public static readonly GameAttributeF Rope_Overlay = new GameAttributeF(325, -1f, -1, 0, 0, "", "", "Rope_Overlay", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065EF RID: 26095
		public static readonly GameAttributeF General_Cooldown = new GameAttributeF(326, 0f, -1, 0, 0, "", "", "General_Cooldown", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065F0 RID: 26096
		public static readonly GameAttributeF Power_Cooldown = new GameAttributeF(327, -1f, -1, 0, 0, "", "", "Power_Cooldown", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065F1 RID: 26097
		public static readonly GameAttributeF Power_Cooldown_Start = new GameAttributeF(328, -2.1474836E+09f, -1, 0, 0, "", "", "Power_Cooldown_Start", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065F2 RID: 26098
		public static readonly GameAttributeF Skill_Slot_Cooldown = new GameAttributeF(329, -1f, -1, 0, 0, "", "", "Skill_Slot_Cooldown", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065F3 RID: 26099
		public static readonly GameAttributeF Skill_Slot_Cooldown_Start = new GameAttributeF(330, -2.1474836E+09f, -1, 0, 0, "", "", "Skill_Slot_Cooldown_Start", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065F4 RID: 26100
		public static readonly GameAttributeF Proc_Cooldown = new GameAttributeF(331, 0f, -1, 0, 0, "", "", "Proc_Cooldown", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065F5 RID: 26101
		public static readonly GameAttributeF Emote_Cooldown = new GameAttributeF(332, 0f, -1, 0, 0, "", "", "Emote_Cooldown", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065F6 RID: 26102
		public static readonly GameAttributeF Next_Charge_Gained_time = new GameAttributeF(335, 0f, -1, 0, 0, "", "", "Next_Charge_Gained_time", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065F7 RID: 26103
		public static readonly GameAttributeF Recharge_Start_Time = new GameAttributeF(336, 0f, -1, 0, 0, "", "", "Recharge_Start_Time", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065F8 RID: 26104
		public static readonly GameAttributeF Loot_Last_Damage = new GameAttributeF(346, 0f, -1, 0, 0, "", "", "Loot_Last_Damage", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065F9 RID: 26105
		public static readonly GameAttributeF Item_Ping = new GameAttributeF(352, -1f, -1, 0, 0, "", "", "Item_Ping", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065FA RID: 26106
		public static readonly GameAttributeI Item_Bound_To_ACD = new GameAttributeI(361, -1, -1, 0, 0, "0", "", "Item_Bound_To_ACD", GameAttributeEncoding.Int, 0, 0, 0, 32);

		// Token: 0x040065FB RID: 26107
		public static readonly GameAttributeI ItemStackQuantityHi = new GameAttributeI(365, 0, -1, 0, 0, "", "", "ItemStackQuantityHi", GameAttributeEncoding.Int, 0, 0, 0, 32);

		// Token: 0x040065FC RID: 26108
		public static readonly GameAttributeI ItemStackQuantityLo = new GameAttributeI(366, 0, -1, 0, 0, "", "", "ItemStackQuantityLo", GameAttributeEncoding.Int, 0, 0, 0, 32);

		// Token: 0x040065FD RID: 26109
		public static readonly GameAttributeF Item_Power = new GameAttributeF(367, 0f, -1, 0, 0, "", "", "Item_Power", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065FE RID: 26110
		public static readonly GameAttributeF Item_Power_Bonus = new GameAttributeF(368, 0f, -1, 0, 0, "", "", "Item_Power_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040065FF RID: 26111
		public static readonly GameAttributeF Item_Power_Total = new GameAttributeF(369, 0f, -1, 0, 0, "Item_Power + Item_Power_Bonus", "", "Item_Power_Total", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006600 RID: 26112
		public static readonly GameAttributeF Item_Upgrade_Count = new GameAttributeF(370, 0f, -1, 0, 0, "", "", "Item_Upgrade_Count", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006601 RID: 26113
		public static readonly GameAttributeF Effective_Item_Power = new GameAttributeF(371, 0f, -1, 0, 0, "", "", "Effective_Item_Power", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006602 RID: 26114
		public static readonly GameAttributeF Total_Weighted_Item_Power = new GameAttributeF(372, 0f, -1, 0, 0, "", "", "Total_Weighted_Item_Power", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006603 RID: 26115
		public static readonly GameAttributeF Total_Weighted_Item_Power_Override = new GameAttributeF(373, -1f, -1, 0, 0, "", "", "Total_Weighted_Item_Power_Override", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006604 RID: 26116
		public static readonly GameAttributeF Base_Item_Power_Bonus_Percent = new GameAttributeF(374, 0f, -1, 0, 0, "", "", "Base_Item_Power_Bonus_Percent", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006605 RID: 26117
		public static readonly GameAttributeF Item_Dropped_World_Tier = new GameAttributeF(375, -1f, -1, 0, 0, "", "", "Item_Dropped_World_Tier", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006606 RID: 26118
		public static readonly GameAttributeF Item_Dropped_Dungeon_Level = new GameAttributeF(376, -1f, -1, 0, 0, "", "", "Item_Dropped_Dungeon_Level", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006607 RID: 26119
		public static readonly GameAttributeF Debug_Loot_Log_Output_ID = new GameAttributeF(377, -1f, -1, 0, 0, "", "", "Debug_Loot_Log_Output_ID", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006608 RID: 26120
		public static readonly GameAttributeI Weapon_Damage_Min = new GameAttributeI(378, 0, -1, 0, 0, "", "", "Weapon_Damage_Min", GameAttributeEncoding.Int, 0, 0, 0, 32);

		// Token: 0x04006609 RID: 26121
		public static readonly GameAttributeI Weapon_Damage_Delta = new GameAttributeI(379, 0, -1, 0, 0, "", "", "Weapon_Damage_Delta", GameAttributeEncoding.Int, 0, 0, 0, 32);

		// Token: 0x0400660A RID: 26122
		public static readonly GameAttributeI Effective_Weapon_Damage_Min = new GameAttributeI(380, 0, -1, 0, 0, "", "", "Effective_Weapon_Damage_Min", GameAttributeEncoding.Int, 0, 0, 0, 32);

		// Token: 0x0400660B RID: 26123
		public static readonly GameAttributeI Effective_Weapon_Damage_Delta = new GameAttributeI(381, 0, -1, 0, 0, "", "", "Effective_Weapon_Damage_Delta", GameAttributeEncoding.Int, 0, 0, 0, 32);

		// Token: 0x0400660C RID: 26124
		public static readonly GameAttributeI Weapon_Damage_Min_Total = new GameAttributeI(382, 0, -1, 0, 0, "Effective_Weapon_Damage_Min", "", "Weapon_Damage_Min_Total", GameAttributeEncoding.Int, 0, 0, 0, 32);

		// Token: 0x0400660D RID: 26125
		public static readonly GameAttributeI Weapon_Damage_Delta_Total = new GameAttributeI(383, 0, -1, 0, 0, "Effective_Weapon_Damage_Delta", "", "Weapon_Damage_Delta_Total", GameAttributeEncoding.Int, 0, 0, 0, 32);

		// Token: 0x0400660E RID: 26126
		public static readonly GameAttributeI Armor = new GameAttributeI(384, 0, -1, 0, 0, "", "", "Armor", GameAttributeEncoding.Int, 0, 0, 0, 32);

		// Token: 0x0400660F RID: 26127
		public static readonly GameAttributeI Effective_Armor = new GameAttributeI(385, 0, -1, 0, 0, "", "", "Effective_Armor", GameAttributeEncoding.Int, 0, 0, 0, 32);

		// Token: 0x04006610 RID: 26128
		public static readonly GameAttributeI Armor_Total = new GameAttributeI(386, 0, -1, 0, 0, "(Effective_Armor + Armor_Bonus + Core_Stat_Armor_Bonus) * (1.0 + Armor_Percent)", "", "Armor_Total", GameAttributeEncoding.Int, 0, 0, 0, 32);

		// Token: 0x04006611 RID: 26129
		public static readonly GameAttributeF Armor_Percent = new GameAttributeF(388, 0f, -1, 0, 0, "", "", "Armor_Percent", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006612 RID: 26130
		public static readonly GameAttributeF Werebear_Armor_Percent = new GameAttributeF(389, 0f, -1, 0, 0, "", "", "Werebear_Armor_Percent", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006613 RID: 26131
		public static readonly GameAttributeF Werewolf_Armor_Percent = new GameAttributeF(390, 0f, -1, 0, 0, "", "", "Werewolf_Armor_Percent", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006614 RID: 26132
		public static readonly GameAttributeI Armor_Bonus = new GameAttributeI(391, 0, -1, 0, 0, "", "", "Armor_Bonus", GameAttributeEncoding.Int, 0, 0, 0, 32);

		// Token: 0x04006615 RID: 26133
		public static readonly GameAttributeF Weapon_Damage_Override = new GameAttributeF(392, -1f, -1, 0, 0, "", "", "Weapon_Damage_Override", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006616 RID: 26134
		public static readonly GameAttributeF Armor_Override = new GameAttributeF(393, -1f, -1, 0, 0, "", "", "Armor_Override", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006617 RID: 26135
		public static readonly GameAttributeF Incoming_Weapon_Damage_Override = new GameAttributeF(394, -1f, -1, 0, 0, "", "", "Incoming_Weapon_Damage_Override", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006618 RID: 26136
		public static readonly GameAttributeF Incoming_Armor_Override = new GameAttributeF(395, -1f, -1, 0, 0, "", "", "Incoming_Armor_Override", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006619 RID: 26137
		public static readonly GameAttributeF Paragon_Points_Bonus = new GameAttributeF(396, 0f, -1, 0, 0, "", "", "Paragon_Points_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400661A RID: 26138
		public static readonly GameAttributeF Paragon_Points_Earned = new GameAttributeF(397, 0f, -1, 0, 0, "", "", "Paragon_Points_Earned", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400661B RID: 26139
		public static readonly GameAttributeF Paragon_Points_Earned_Total = new GameAttributeF(398, 0f, -1, 0, 0, "Paragon_Points_Earned + Paragon_Points_Bonus", "", "Paragon_Points_Earned_Total", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400661C RID: 26140
		public static readonly GameAttributeF Paragon_Points_Available = new GameAttributeF(399, 0f, -1, 0, 0, "", "", "Paragon_Points_Available", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400661D RID: 26141
		public static readonly GameAttributeF Paragon_Glyph_Experience_Max = new GameAttributeF(402, 0f, -1, 0, 0, "", "", "Paragon_Glyph_Experience_Max", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400661E RID: 26142
		public static readonly GameAttributeF Paragon_Glyph_Experience_Used = new GameAttributeF(403, 0f, -1, 0, 0, "", "", "Paragon_Glyph_Experience_Used", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400661F RID: 26143
		public static readonly GameAttributeF Seed = new GameAttributeF(406, 0f, -1, 0, 0, "0", "", "Seed", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006620 RID: 26144
		public static readonly GameAttributeI Dye = new GameAttributeI(411, -1, -1, 0, 0, "", "", "Dye", GameAttributeEncoding.Int, 0, 0, 0, 32);

		// Token: 0x04006621 RID: 26145
		public static readonly GameAttributeF HighlySalvageable = new GameAttributeF(413, 0f, -1, 0, 0, "0", "", "HighlySalvageable", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006622 RID: 26146
		public static readonly GameAttributeF Enchanted_Replaced_Affix = new GameAttributeF(414, -1f, -1, 0, 0, "0", "", "Enchanted_Replaced_Affix", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006623 RID: 26147
		public static readonly GameAttributeF Enchanted_Affix = new GameAttributeF(415, -1f, -1, 0, 0, "0", "", "Enchanted_Affix", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006624 RID: 26148
		public static readonly GameAttributeF Enchanted_Affix_Seed = new GameAttributeF(416, 0f, -1, 0, 0, "0", "", "Enchanted_Affix_Seed", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006625 RID: 26149
		public static readonly GameAttributeF Enchant_Count = new GameAttributeF(417, 0f, -1, 0, 0, "0", "", "Enchant_Count", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006626 RID: 26150
		public static readonly GameAttributeF RActor_Fade_Group = new GameAttributeF(423, -1f, -1, 0, 0, "", "", "RActor_Fade_Group", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006627 RID: 26151
		public static readonly GameAttributeF Animset_Override = new GameAttributeF(426, -1f, -1, 0, 0, "", "", "Animset_Override", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006628 RID: 26152
		public static readonly GameAttributeF Treasure_Class = new GameAttributeF(429, -1f, -1, 0, 0, "", "", "Treasure_Class", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006629 RID: 26153
		public static readonly GameAttributeF Door_Timer = new GameAttributeF(441, -1f, -1, 0, 0, "", "", "Door_Timer", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400662A RID: 26154
		public static readonly GameAttributeF Gizmo_Operator_ACDID = new GameAttributeF(443, -1f, -1, 0, 0, "", "", "Gizmo_Operator_ACDID", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400662B RID: 26155
		public static readonly GameAttributeF Triggering_Count = new GameAttributeF(444, 0f, -1, 0, 0, "", "", "Triggering_Count", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400662C RID: 26156
		public static readonly GameAttributeF Gizmo_Has_Been_Operated = new GameAttributeF(448, 0f, -1, 0, 0, "", "", "Gizmo_Has_Been_Operated", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400662D RID: 26157
		public static readonly GameAttributeF Gizmo_Power_Operate = new GameAttributeF(449, -1f, -1, 0, 0, "", "", "Gizmo_Power_Operate", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400662E RID: 26158
		public static readonly GameAttributeF Gizmo_Power_Operator = new GameAttributeF(450, -1f, -1, 0, 0, "", "", "Gizmo_Power_Operator", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400662F RID: 26159
		public static readonly GameAttributeF Pet_Owner_ANN = new GameAttributeF(451, -1f, -1, 0, 0, "", "", "Pet_Owner_ANN", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006630 RID: 26160
		public static readonly GameAttributeF Pet_Type = new GameAttributeF(452, -1f, -1, 0, 0, "", "", "Pet_Type", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006631 RID: 26161
		public static readonly GameAttributeF Summoned_By_SNO = new GameAttributeF(456, -1f, -1, 0, 0, "", "", "Summoned_By_SNO", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006632 RID: 26162
		public static readonly GameAttributeF Parent_Summoning_Skill_SNO = new GameAttributeF(457, -1f, -1, 0, 0, "", "", "Parent_Summoning_Skill_SNO", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006633 RID: 26163
		public static readonly GameAttributeF Follower_Quest = new GameAttributeF(459, -1f, -1, 0, 0, "", "", "Follower_Quest", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006634 RID: 26164
		public static readonly GameAttributeF NecroArmy_Spec_For_Pet_Type = new GameAttributeF(466, 0f, -1, 0, 0, "", "", "NecroArmy_Spec_For_Pet_Type", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006635 RID: 26165
		public static readonly GameAttributeF NecroArmy_Specialization1_Upgrade_For_Pet_Type = new GameAttributeF(467, -1f, -1, 0, 0, "", "", "NecroArmy_Specialization1_Upgrade_For_Pet_Type", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006636 RID: 26166
		public static readonly GameAttributeF NecroArmy_Specialization2_Upgrade_For_Pet_Type = new GameAttributeF(468, -1f, -1, 0, 0, "", "", "NecroArmy_Specialization2_Upgrade_For_Pet_Type", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006637 RID: 26167
		public static readonly GameAttributeF NecroArmy_Specialization3_Upgrade_For_Pet_Type = new GameAttributeF(469, -1f, -1, 0, 0, "", "", "NecroArmy_Specialization3_Upgrade_For_Pet_Type", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006638 RID: 26168
		public static readonly GameAttributeF NecroArmy_Pet_Type_Health_Bonus_Pct = new GameAttributeF(470, 0f, -1, 0, 0, "", "", "NecroArmy_Pet_Type_Health_Bonus_Pct", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006639 RID: 26169
		public static readonly GameAttributeF NecroArmy_Flat_Armor_Bonus_With_Active_Pet_Type = new GameAttributeF(478, 0f, -1, 0, 0, "", "", "NecroArmy_Flat_Armor_Bonus_With_Active_Pet_Type", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400663A RID: 26170
		public static readonly GameAttributeF NecroArmy_Armor_Percent_Bonus_With_Active_Pet_Type = new GameAttributeF(479, 0f, -1, 0, 0, "", "", "NecroArmy_Armor_Percent_Bonus_With_Active_Pet_Type", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400663B RID: 26171
		public static readonly GameAttributeF Conversation_Icon_Quest = new GameAttributeF(485, -1f, -1, 0, 0, "", "", "Conversation_Icon_Quest", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400663C RID: 26172
		public static readonly GameAttributeF Callout_Cooldown = new GameAttributeF(486, -1f, -1, 0, 0, "", "", "Callout_Cooldown", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400663D RID: 26173
		public static readonly GameAttributeF Banter_Cooldown = new GameAttributeF(487, -1f, -1, 0, 0, "", "", "Banter_Cooldown", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400663E RID: 26174
		public static readonly GameAttributeF Conversation_Heard_Count = new GameAttributeF(488, 0f, -1, 0, 0, "", "", "Conversation_Heard_Count", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400663F RID: 26175
		public static readonly GameAttributeF Last_Tick_Shop_Entered = new GameAttributeF(489, -1f, -1, 0, 0, "", "", "Last_Tick_Shop_Entered", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006640 RID: 26176
		public static readonly GameAttributeF Bow = new GameAttributeF(490, 0f, -1, 0, 0, "", "", "Bow", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006641 RID: 26177
		public static readonly GameAttributeF Crossbow = new GameAttributeF(491, 0f, -1, 0, 0, "", "", "Crossbow", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006642 RID: 26178
		public static readonly GameAttributeF BowAny = new GameAttributeF(492, 0f, -1, 0, 0, "Pin(Bow + Crossbow, 0, 1)", "", "BowAny", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006643 RID: 26179
		public static readonly GameAttributeF Spawned_by_ACDID = new GameAttributeF(493, -1f, -1, 0, 0, "", "", "Spawned_by_ACDID", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006644 RID: 26180
		public static readonly GameAttributeF Summoned_By_ACDID = new GameAttributeF(494, -1f, -1, 0, 0, "", "", "Summoned_By_ACDID", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006645 RID: 26181
		public static readonly GameAttributeF Summoner_ID = new GameAttributeF(495, -1f, -1, 0, 0, "", "", "Summoner_ID", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006646 RID: 26182
		public static readonly GameAttributeF Last_In_Combat_Time = new GameAttributeF(503, 0f, -1, 0, 0, "", "", "Last_In_Combat_Time", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006647 RID: 26183
		public static readonly GameAttributeF Combat_Bloodiness = new GameAttributeF(505, 0f, -1, 0, 0, "", "", "Combat_Bloodiness", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006648 RID: 26184
		public static readonly GameAttributeF Shapeshift_Form = new GameAttributeF(508, 0f, -1, 0, 0, "", "", "Shapeshift_Form", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006649 RID: 26185
		public static readonly GameAttributeF Weakpoint_Exposed_End_Time = new GameAttributeF(515, 0f, -1, 0, 0, "", "", "Weakpoint_Exposed_End_Time", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400664A RID: 26186
		public static readonly GameAttributeF Last_Tick_Potion_Used = new GameAttributeF(518, -1f, -1, 0, 0, "", "", "Last_Tick_Potion_Used", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400664B RID: 26187
		public static readonly GameAttributeF Potion_Tier = new GameAttributeF(521, 0f, -1, 0, 0, "", "", "Potion_Tier", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400664C RID: 26188
		public static readonly GameAttributeF Potion_Doses = new GameAttributeF(522, -1f, -1, 0, 0, "Min(Potion_Doses.Agg, Potion_Max_Doses_Total)", "", "Potion_Doses", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400664D RID: 26189
		public static readonly GameAttributeF Potion_Max_Doses_Base = new GameAttributeF(523, 0f, -1, 0, 0, "", "", "Potion_Max_Doses_Base", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400664E RID: 26190
		public static readonly GameAttributeF Potion_Max_Doses_Bonus = new GameAttributeF(524, 0f, -1, 0, 0, "", "", "Potion_Max_Doses_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400664F RID: 26191
		public static readonly GameAttributeF Potion_Max_Doses_Total = new GameAttributeF(525, 0f, -1, 0, 0, "Potion_Max_Doses_Base + Potion_Max_Doses_Bonus", "", "Potion_Max_Doses_Total", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006650 RID: 26192
		public static readonly GameAttributeF Potion_Special_Doses = new GameAttributeF(526, 0f, -1, 0, 0, "", "", "Potion_Special_Doses", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006651 RID: 26193
		public static readonly GameAttributeF Potion_Special_Dose_Power = new GameAttributeF(527, 0f, -1, 0, 0, "", "", "Potion_Special_Dose_Power", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006652 RID: 26194
		public static readonly GameAttributeF Potion_Dose_Drop_Total_Thresholds = new GameAttributeF(534, 0f, -1, 0, 0, "", "", "Potion_Dose_Drop_Total_Thresholds", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006653 RID: 26195
		public static readonly GameAttributeF Last_Potion_Dose_Drop_Interval = new GameAttributeF(535, 0f, -1, 0, 0, "", "", "Last_Potion_Dose_Drop_Interval", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006654 RID: 26196
		public static readonly GameAttributeF Out_Of_Combat_Hitpoints_Regen_Delay_On_Leave_Combat = new GameAttributeF(541, 0f, -1, 0, 0, "", "", "Out_Of_Combat_Hitpoints_Regen_Delay_On_Leave_Combat", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006655 RID: 26197
		public static readonly GameAttributeF Out_Of_Combat_Resource_Regen_Delay_On_Spend_Resource = new GameAttributeF(543, 0f, -1, 0, 0, "", "", "Out_Of_Combat_Resource_Regen_Delay_On_Spend_Resource", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006656 RID: 26198
		public static readonly GameAttributeF Out_Of_Combat_Resource_Regen_Delay_On_Leave_Combat = new GameAttributeF(544, 0f, -1, 0, 0, "", "", "Out_Of_Combat_Resource_Regen_Delay_On_Leave_Combat", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006657 RID: 26199
		public static readonly GameAttributeF Out_Of_Combat_Resource_Regen_Allowed_Time = new GameAttributeF(545, 0f, -1, 0, 0, "", "", "Out_Of_Combat_Resource_Regen_Allowed_Time", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006658 RID: 26200
		public static readonly GameAttributeF Last_Damage_ACD = new GameAttributeF(546, -1f, -1, 0, 0, "", "", "Last_Damage_ACD", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006659 RID: 26201
		public static readonly GameAttributeF Attached_To_ACD = new GameAttributeF(547, -1f, -1, 0, 0, "", "", "Attached_To_ACD", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400665A RID: 26202
		public static readonly GameAttributeF Attachment_ACD = new GameAttributeF(548, -1f, -1, 0, 0, "", "", "Attachment_ACD", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400665B RID: 26203
		public static readonly GameAttributeF Knockback_Attachment_ACD = new GameAttributeF(549, -1f, -1, 0, 0, "", "", "Knockback_Attachment_ACD", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400665C RID: 26204
		public static readonly GameAttributeF Normal_Attack_Replacement_Power_SNO = new GameAttributeF(550, -1f, -1, 0, 0, "", "", "Normal_Attack_Replacement_Power_SNO", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400665D RID: 26205
		public static readonly GameAttributeF Expensive_Proc_Count = new GameAttributeF(551, 0f, -1, 0, 0, "", "", "Expensive_Proc_Count", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400665E RID: 26206
		public static readonly GameAttributeF Projectile_Forced_Target = new GameAttributeF(554, -1f, -1, 0, 0, "", "", "Projectile_Forced_Target", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400665F RID: 26207
		public static readonly GameAttributeF Projectile_Reflect_Damage_Scalar = new GameAttributeF(556, 1.0653532E+09f, -1, 0, 0, "", "", "Projectile_Reflect_Damage_Scalar", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006660 RID: 26208
		public static readonly GameAttributeF Projectile_Reflect_Damage_Cap_Remaining = new GameAttributeF(558, 0f, -1, 0, 0, "", "", "Projectile_Reflect_Damage_Cap_Remaining", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006661 RID: 26209
		public static readonly GameAttributeF Projectile_Seek_Rotation_Rate = new GameAttributeF(561, 0f, -1, 0, 0, "", "", "Projectile_Seek_Rotation_Rate", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006662 RID: 26210
		public static readonly GameAttributeF Active_Weapon_Effect_Override = new GameAttributeF(563, -1f, -1, 0, 0, "", "", "Active_Weapon_Effect_Override", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006663 RID: 26211
		public static readonly GameAttributeF Scripted_Fade_Time = new GameAttributeF(569, 0f, -1, 0, 0, "", "", "Scripted_Fade_Time", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006664 RID: 26212
		public static readonly GameAttributeF Scripted_Look_Override = new GameAttributeF(570, -1f, -1, 0, 0, "", "", "Scripted_Look_Override", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006665 RID: 26213
		public static readonly GameAttributeF Summon_Expiration_Tick = new GameAttributeF(576, 0f, -1, 0, 0, "", "", "Summon_Expiration_Tick", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006666 RID: 26214
		public static readonly GameAttributeF Summon_Count = new GameAttributeF(577, 0f, -1, 0, 0, "", "", "Summon_Count", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006667 RID: 26215
		public static readonly GameAttributeF Death_Power_Override = new GameAttributeF(580, -1f, -1, 0, 0, "", "", "Death Power Override", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006668 RID: 26216
		public static readonly GameAttributeF Special_Death_Power_Override = new GameAttributeF(581, -1f, -1, 0, 0, "", "", "Special Death Power Override", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006669 RID: 26217
		public static readonly GameAttributeF DOT_DPS = new GameAttributeF(585, 0f, -1, 0, 0, "", "", "DOT_DPS", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400666A RID: 26218
		public static readonly GameAttributeF DOT_Total = new GameAttributeF(586, 0f, -1, 0, 0, "", "", "DOT_Total", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400666B RID: 26219
		public static readonly GameAttributeF DOT_Infinite_Total = new GameAttributeF(587, 0f, -1, 0, 0, "", "", "DOT_Infinite_Total", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400666C RID: 26220
		public static readonly GameAttributeF DOT_DPS_Bonus_Percent = new GameAttributeF(588, 0f, -1, 0, 0, "", "", "DOT_DPS_Bonus_Percent", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400666D RID: 26221
		public static readonly GameAttributeF DOT_DPS_Bonus_Percent_Per_Damage_Type = new GameAttributeF(589, 0f, -1, 0, 0, "", "", "DOT_DPS_Bonus_Percent_Per_Damage_Type", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400666E RID: 26222
		public static readonly GameAttributeF Multiplicative_DOT_DPS_Bonus_Percent_Per_Damage_Type = new GameAttributeF(590, 0f, -1, 0, 0, "", "", "Multiplicative_DOT_DPS_Bonus_Percent_Per_Damage_Type", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400666F RID: 26223
		public static readonly GameAttributeF DOT_DPS_Reduction_Percent = new GameAttributeF(591, 0f, -1, 0, 0, "", "", "DOT_DPS_Reduction_Percent", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006670 RID: 26224
		public static readonly GameAttributeF DOT_DPS_Reduction_Percent_Per_Damage_Type = new GameAttributeF(592, 0f, -1, 0, 0, "", "", "DOT_DPS_Reduction_Percent_Per_Damage_Type", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006671 RID: 26225
		public static readonly GameAttributeF DOT_Speed_Bonus_Percent_Per_Damage_Type = new GameAttributeF(593, 0f, -1, 0, 0, "", "", "DOT_Speed_Bonus_Percent_Per_Damage_Type", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006672 RID: 26226
		public static readonly GameAttributeF Item_Time_Sold = new GameAttributeF(596, 0f, -1, 0, 0, "", "", "Item_Time_Sold", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006673 RID: 26227
		public static readonly GameAttributeF Forced_Hireling_Power = new GameAttributeF(597, -1f, -1, 0, 0, "", "", "Forced_Hireling_Power", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006674 RID: 26228
		public static readonly GameAttributeI SkillKit = new GameAttributeI(601, -1, -1, 0, 0, "", "", "SkillKit", GameAttributeEncoding.Int, 0, 0, 0, 32);

		// Token: 0x04006675 RID: 26229
		public static readonly GameAttributeF Damage_Shield_Accumulated_Amount = new GameAttributeF(604, 0f, -1, 0, 0, "", "", "Damage_Shield_Accumulated_Amount", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006676 RID: 26230
		public static readonly GameAttributeF Damage_Shield_Max = new GameAttributeF(605, 0f, -1, 0, 0, "", "", "Damage_Shield_Max", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006677 RID: 26231
		public static readonly GameAttributeF Damage_Shield_Bonus_Percent_Damage = new GameAttributeF(606, 0f, -1, 0, 0, "", "", "Damage_Shield_Bonus_Percent_Damage", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006678 RID: 26232
		public static readonly GameAttributeF Vulnerable_Health_Damage_Bonus = new GameAttributeF(611, 0f, -1, 0, 0, "", "", "Vulnerable_Health_Damage_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006679 RID: 26233
		public static readonly GameAttributeF Multiplicative_Vulnerable_Health_Damage_Bonus = new GameAttributeF(612, 0f, -1, 0, 0, "", "", "Multiplicative_Vulnerable_Health_Damage_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400667A RID: 26234
		public static readonly GameAttributeF Fortified_Health = new GameAttributeF(614, 0f, -1, 0, 0, "", "", "Fortified_Health", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400667B RID: 26235
		public static readonly GameAttributeF Fortified_Health_Damage_Reduction_Bonus = new GameAttributeF(615, 0f, -1, 0, 0, "", "", "Fortified_Health_Damage_Reduction_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400667C RID: 26236
		public static readonly GameAttributeF Fortified_Health_Application_Bonus = new GameAttributeF(616, 0f, -1, 0, 0, "", "", "Fortified_Health_Application_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400667D RID: 26237
		public static readonly GameAttributeF Follow_Target_ACDID = new GameAttributeF(619, -1f, -1, 0, 0, "", "", "Follow_Target_ACDID", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400667E RID: 26238
		public static readonly GameAttributeF NPC_Talk_Target_ANN = new GameAttributeF(621, -1f, -1, 0, 0, "", "", "NPC_Talk_Target_ANN", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400667F RID: 26239
		public static readonly GameAttributeF Look_Target_Server_ANN = new GameAttributeF(622, -1f, -1, 0, 0, "", "", "Look_Target_Server_ANN", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006680 RID: 26240
		public static readonly GameAttributeF ItemBuffIcon = new GameAttributeF(628, 0f, -1, 0, 0, "0", "", "ItemBuffIcon", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006681 RID: 26241
		public static readonly GameAttributeF Gizmo_Actor_SNO_To_Spawn = new GameAttributeF(629, -1f, -1, 0, 0, "", "", "Gizmo_Actor_SNO_To_Spawn", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006682 RID: 26242
		public static readonly GameAttributeF Forced_Enemy_ACDID = new GameAttributeF(632, -1f, -1, 0, 0, "", "", "Forced_Enemy_ACDID", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006683 RID: 26243
		public static readonly GameAttributeF AI_Idle_Awareness_Radius_Override = new GameAttributeF(637, 0f, -1, 0, 0, "", "", "AI_Idle_Awareness_Radius_Override", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006684 RID: 26244
		public static readonly GameAttributeF AI_Combat_Awareness_Radius_Override = new GameAttributeF(638, 0f, -1, 0, 0, "", "", "AI_Combat_Awareness_Radius_Override", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006685 RID: 26245
		public static readonly GameAttributeF Headstone_Player_ANN = new GameAttributeF(639, -1f, -1, 0, 0, "", "", "Headstone_Player_ANN", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006686 RID: 26246
		public static readonly GameAttributeF World_Seed = new GameAttributeF(642, 0f, -1, 0, 0, "", "", "World_Seed", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006687 RID: 26247
		public static readonly GameAttributeF Checkpoint_Resurrection_Allowed_Game_Time = new GameAttributeF(646, 0f, -1, 0, 0, "", "", "Checkpoint_Resurrection_Allowed_Game_Time", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006688 RID: 26248
		public static readonly GameAttributeF Checkpoint_Resurrection_Forced_Game_Time = new GameAttributeF(647, 0f, -1, 0, 0, "", "", "Checkpoint_Resurrection_Forced_Game_Time", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006689 RID: 26249
		public static readonly GameAttributeF Corpse_Resurrection_Allowed_Game_Time = new GameAttributeF(648, 0f, -1, 0, 0, "", "", "Corpse_Resurrection_Allowed_Game_Time", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400668A RID: 26250
		public static readonly GameAttributeF Last_Action_Timestamp = new GameAttributeF(653, 0f, -1, 0, 0, "", "", "Last Action Timestamp", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400668B RID: 26251
		public static readonly GameAttributeF Portal_Next_Time = new GameAttributeF(654, 0f, -1, 0, 0, "", "", "Portal Next Time", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400668C RID: 26252
		public static readonly GameAttributeF Spawner_Concurrent_Count_ID = new GameAttributeF(656, -1f, -1, 0, 0, "", "", "Spawner_Concurrent_Count_ID", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400668D RID: 26253
		public static readonly GameAttributeF Skill_Override = new GameAttributeF(658, -1f, -1, 0, 0, "", "", "Skill_Override", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400668E RID: 26254
		public static readonly GameAttributeF Skill_Icon_Override_Normal = new GameAttributeF(663, -2.1474836E+09f, -1, 0, 0, "", "", "Skill_Icon_Override_Normal", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400668F RID: 26255
		public static readonly GameAttributeF Skill_Icon_Override_Mouse_Over = new GameAttributeF(664, -2.1474836E+09f, -1, 0, 0, "", "", "Skill_Icon_Override_Mouse_Over", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006690 RID: 26256
		public static readonly GameAttributeF Skill_Icon_Override_Pushed = new GameAttributeF(665, -2.1474836E+09f, -1, 0, 0, "", "", "Skill_Icon_Override_Pushed", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006691 RID: 26257
		public static readonly GameAttributeF Skill_Icon_Override_Inactive = new GameAttributeF(666, -2.1474836E+09f, -1, 0, 0, "", "", "Skill_Icon_Override_Inactive", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006692 RID: 26258
		public static readonly GameAttributeF Evade_Override = new GameAttributeF(667, -1f, -1, 0, 0, "", "", "Evade_Override", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006693 RID: 26259
		public static readonly GameAttributeF Unlocked_Skill_Enchant_Slots = new GameAttributeF(668, 0f, -1, 0, 0, "", "", "Unlocked_Skill_Enchant_Slots", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006694 RID: 26260
		public static readonly GameAttributeF Unlocked_Skill_Passive_Slots = new GameAttributeF(669, 0f, -1, 0, 0, "", "", "Unlocked_Skill_Passive_Slots", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006695 RID: 26261
		public static readonly GameAttributeF Rogue_Specialization = new GameAttributeF(670, -1f, -1, 0, 0, "", "", "Rogue_Specialization", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006696 RID: 26262
		public static readonly GameAttributeF Forced_Rogue_Specialization = new GameAttributeF(671, -1f, -1, 0, 0, "", "", "Forced_Rogue_Specialization", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006697 RID: 26263
		public static readonly GameAttributeF Druid_Spirit_Bond = new GameAttributeF(673, -1f, -1, 0, 0, "", "", "Druid_Spirit_Bond", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006698 RID: 26264
		public static readonly GameAttributeF Rogue_Inner_Sight_Gauge = new GameAttributeF(675, 0f, -1, 0, 0, "", "", "Rogue_Inner_Sight_Gauge", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006699 RID: 26265
		public static readonly GameAttributeF Weapon_Expertise_Level = new GameAttributeF(676, 0f, -1, 0, 0, "", "", "Weapon_Expertise_Level", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400669A RID: 26266
		public static readonly GameAttributeF Weapon_Expertise_Experience = new GameAttributeF(677, 0f, -1, 0, 0, "", "", "Weapon_Expertise_Experience", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400669B RID: 26267
		public static readonly GameAttributeF Active_Technique_Slot = new GameAttributeF(678, -1f, -1, 0, 0, "", "", "Active_Technique_Slot", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400669C RID: 26268
		public static readonly GameAttributeF Flippy_ID = new GameAttributeF(681, -1f, -1, 0, 0, "", "", "Flippy_ID", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400669D RID: 26269
		public static readonly GameAttributeF Set_Item_Count = new GameAttributeF(682, 0f, -1, 0, 0, "", "", "Set_Item_Count", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400669E RID: 26270
		public static readonly GameAttributeF Last_ACD_Attacked_By = new GameAttributeF(686, -1f, -1, 0, 0, "", "", "Last_ACD_Attacked_By", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400669F RID: 26271
		public static readonly GameAttributeF Client_Only_Effect = new GameAttributeF(688, -1f, -1, 0, 0, "", "", "Client Only Effect", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066A0 RID: 26272
		public static readonly GameAttributeF Looping_Animation_Start_Time = new GameAttributeF(691, 0f, -1, 0, 0, "", "", "Looping_Animation_Start_Time", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066A1 RID: 26273
		public static readonly GameAttributeF Looping_Animation_End_Time = new GameAttributeF(692, 0f, -1, 0, 0, "", "", "Looping_Animation_End_Time", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066A2 RID: 26274
		public static readonly GameAttributeF Looping_Animation_Text_SNO = new GameAttributeF(693, -1f, -1, 0, 0, "", "", "Looping_Animation_Text_SNO", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066A3 RID: 26275
		public static readonly GameAttributeF Looping_Animation_Text_Label = new GameAttributeF(694, -2.1474836E+09f, -1, 0, 0, "", "", "Looping_Animation_Text_Label", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066A4 RID: 26276
		public static readonly GameAttributeF Heal_Effect_Last_Played_Tick = new GameAttributeF(695, -1f, -1, 0, 0, "", "", "Heal_Effect_Last_Played_Tick", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066A5 RID: 26277
		public static readonly GameAttributeF Resource_Effect_Last_Played_tick = new GameAttributeF(696, -1f, -1, 0, 0, "", "", "Resource_Effect_Last_Played_tick", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066A6 RID: 26278
		public static readonly GameAttributeF Thorns_Effect_Last_Played_tick = new GameAttributeF(697, -1f, -1, 0, 0, "", "", "Thorns_Effect_Last_Played_tick", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066A7 RID: 26279
		public static readonly GameAttributeF NeverDieBuffID = new GameAttributeF(706, -1f, -1, 0, 0, "", "", "NeverDieBuffID", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066A8 RID: 26280
		public static readonly GameAttributeF Last_Blocked_ACD = new GameAttributeF(720, -1f, -1, 0, 0, "", "", "Last_Blocked_ACD", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066A9 RID: 26281
		public static readonly GameAttributeF Last_Blocked_Time = new GameAttributeF(721, 0f, -1, 0, 0, "", "", "Last_Blocked_Time", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066AA RID: 26282
		public static readonly GameAttributeF Taunt_Target_ACD = new GameAttributeF(726, -1f, -1, 0, 0, "", "", "Taunt_Target_ACD", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066AB RID: 26283
		public static readonly GameAttributeF Charm_Source_ACD = new GameAttributeF(727, -1f, -1, 0, 0, "", "", "Charm_Source_ACD", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066AC RID: 26284
		public static readonly GameAttributeF Fear_Source_ACD = new GameAttributeF(728, -1f, -1, 0, 0, "", "", "Fear_Source_ACD", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066AD RID: 26285
		public static readonly GameAttributeF Update_Interval_Override = new GameAttributeF(729, 0f, -1, 0, 0, "", "", "Update_Interval_Override", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066AE RID: 26286
		public static readonly GameAttributeF Projectile_Effect_SNO = new GameAttributeF(730, -1f, -1, 0, 0, "", "", "Projectile_Effect_SNO", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066AF RID: 26287
		public static readonly GameAttributeF Damage_Done_Percent_Reduction = new GameAttributeF(780, 0f, -1, 0, 0, "", "", "Damage_Done_Percent_Reduction", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066B0 RID: 26288
		public static readonly GameAttributeF Damage_Percent_Reduction_From_Elites = new GameAttributeF(781, 0f, -1, 0, 0, "", "", "Damage_Percent_Reduction_From_Elites", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066B1 RID: 26289
		public static readonly GameAttributeF Damage_Percent_Bonus_Vs_Elites = new GameAttributeF(782, 0f, -1, 0, 0, "", "", "Damage_Percent_Bonus_Vs_Elites", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066B2 RID: 26290
		public static readonly GameAttributeF Multiplicative_Damage_Percent_Bonus_Vs_Elites = new GameAttributeF(783, 0f, -1, 0, 0, "", "", "Multiplicative_Damage_Percent_Bonus_Vs_Elites", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066B3 RID: 26291
		public static readonly GameAttributeF Damage_Type_Percent_Bonus_Vs_Elites = new GameAttributeF(784, 0f, -1, 0, 0, "", "", "Damage_Type_Percent_Bonus_Vs_Elites", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066B4 RID: 26292
		public static readonly GameAttributeF Damage_Percent_Bonus_Against_Dot_Type = new GameAttributeF(788, 0f, -1, 0, 0, "", "", "Damage_Percent_Bonus_Against_Dot_Type", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066B5 RID: 26293
		public static readonly GameAttributeF Damage_Percent_Reduction_From_Dotted_Enemy = new GameAttributeF(794, 0f, -1, 0, 0, "", "", "Damage_Percent_Reduction_From_Dotted_Enemy", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066B6 RID: 26294
		public static readonly GameAttributeF All_Damage_Percent_Reduction_From_Dotted_Enemy = new GameAttributeF(795, 0f, -1, 0, 0, "", "", "All_Damage_Percent_Reduction_From_Dotted_Enemy", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066B7 RID: 26295
		public static readonly GameAttributeF Item_Manipulation_Timeout = new GameAttributeF(800, 0f, -1, 0, 0, "", "", "Item_Manipulation_Timeout", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066B8 RID: 26296
		public static readonly GameAttributeF Picked_Up_Time = new GameAttributeF(801, 0f, -1, 0, 0, "", "", "Picked_Up_Time", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066B9 RID: 26297
		public static readonly GameAttributeF Unequipped_Time = new GameAttributeF(802, 1f, -1, 0, 0, "", "", "Unequipped Time", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066BA RID: 26298
		public static readonly GameAttributeF Last_ACD_Killed_Time = new GameAttributeF(803, 0f, -1, 0, 0, "", "", "Last_ACD_Killed_Time", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066BB RID: 26299
		public static readonly GameAttributeF Power_Damage_Percent_Bonus = new GameAttributeF(809, 0f, -1, 0, 0, "", "", "Power_Damage_Percent_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066BC RID: 26300
		public static readonly GameAttributeF Multiplicative_Power_Damage_Percent_Bonus = new GameAttributeF(810, 0f, -1, 0, 0, "", "", "Multiplicative_Power_Damage_Percent_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066BD RID: 26301
		public static readonly GameAttributeF Power_Damage_Percent_Penalty = new GameAttributeF(811, 0f, -1, 0, 0, "", "", "Power_Damage_Percent_Penalty", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066BE RID: 26302
		public static readonly GameAttributeF Item_Level_Requirement_Reduction = new GameAttributeF(822, 0f, -1, 0, 0, "", "", "Item_Level_Requirement_Reduction", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066BF RID: 26303
		public static readonly GameAttributeF Known_By_Owner = new GameAttributeF(826, -1f, -1, 0, 0, "", "", "Known_By_Owner", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066C0 RID: 26304
		public static readonly GameAttributeF Projectile_Detonate_Time = new GameAttributeF(828, 0f, -1, 0, 0, "", "", "Projectile_Detonate_Time", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066C1 RID: 26305
		public static readonly GameAttributeF Effect_Owner_ANN = new GameAttributeF(830, -1f, -1, 0, 0, "", "", "Effect_Owner_ANN", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066C2 RID: 26306
		public static readonly GameAttributeF Engaged_Rare_Time = new GameAttributeF(832, 0f, -1, 0, 0, "", "", "Engaged_Rare_Time", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066C3 RID: 26307
		public static readonly GameAttributeF Buff_Exclusive_Type_Max = new GameAttributeF(836, 1f, -1, 0, 0, "", "", "Buff_Exclusive_Type_Max", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066C4 RID: 26308
		public static readonly GameAttributeF Actor_Forwards_Buffs = new GameAttributeF(837, -1f, -1, 0, 0, "", "", "Actor_Forwards_Buffs", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066C5 RID: 26309
		public static readonly GameAttributeF Item_Marked_As_Junk = new GameAttributeF(838, 0f, -1, 0, 0, "", "", "Item_Marked_As_Junk", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066C6 RID: 26310
		public static readonly GameAttributeF Season = new GameAttributeF(840, 0f, -1, 0, 0, "", "", "Season", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066C7 RID: 26311
		public static readonly GameAttributeF Item_Base_Cost = new GameAttributeF(841, 0f, -1, 0, 0, "", "", "Item_Base_Cost", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066C8 RID: 26312
		public static readonly GameAttributeF DamageDoneTotalTrackedHi = new GameAttributeF(842, 0f, -1, 0, 0, "", "", "DamageDoneTotalTrackedHi", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066C9 RID: 26313
		public static readonly GameAttributeF DamageDoneTotalTrackedLo = new GameAttributeF(843, 0f, -1, 0, 0, "", "", "DamageDoneTotalTrackedLo", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066CA RID: 26314
		public static readonly GameAttributeF DamageDoneTrackingStartTick = new GameAttributeF(844, 0f, -1, 0, 0, "", "", "DamageDoneTrackingStartTick", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066CB RID: 26315
		public static readonly GameAttributeF PowerPersistsAcrossGames = new GameAttributeF(845, 0f, -1, 0, 0, "", "", "PowerPersistsAcrossGames", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066CC RID: 26316
		public static readonly GameAttributeF Dynamic_Entrance_GUID = new GameAttributeF(853, 0f, -1, 0, 0, "", "", "Dynamic_Entrance_GUID", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066CD RID: 26317
		public static readonly GameAttributeF Bonus_Chance_To_Be_Crit_Hit = new GameAttributeF(854, 0f, -1, 0, 0, "", "", "Bonus_Chance_To_Be_Crit_Hit", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066CE RID: 26318
		public static readonly GameAttributeF Bonus_Chance_To_Be_Crit_Hit_By_Actor = new GameAttributeF(855, 0f, -1, 0, 0, "", "", "Bonus_Chance_To_Be_Crit_Hit_By_Actor", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066CF RID: 26319
		public static readonly GameAttributeF Power_Bonus_Attack_Radius = new GameAttributeF(856, 0f, -1, 0, 0, "", "", "Power Bonus Attack Radius", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066D0 RID: 26320
		public static readonly GameAttributeF Power_Reduction_Attack_Radius = new GameAttributeF(857, 0f, -1, 0, 0, "", "", "Power Reduction Attack Radius", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066D1 RID: 26321
		public static readonly GameAttributeF Item_Store_Player_High = new GameAttributeF(858, 0f, -1, 0, 0, "", "", "Item_Store_Player_High", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066D2 RID: 26322
		public static readonly GameAttributeF Item_Store_Player_Low = new GameAttributeF(859, 0f, -1, 0, 0, "", "", "Item_Store_Player_Low", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066D3 RID: 26323
		public static readonly GameAttributeF Linked_Dynamic_Entrance_GUID = new GameAttributeF(865, 0f, -1, 0, 0, "", "", "Linked Dynamic Entrance GUID", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066D4 RID: 26324
		public static readonly GameAttributeF Boost_TC_Index = new GameAttributeF(866, 0f, -1, 0, 0, "", "", "Boost_TC_Index", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066D5 RID: 26325
		public static readonly GameAttributeF Boost_TC_NextTime = new GameAttributeF(867, 0f, -1, 0, 0, "", "", "Boost_TC_NextTime", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066D6 RID: 26326
		public static readonly GameAttributeF Item_Rest_Bonus_Pool = new GameAttributeF(868, 0f, -1, 0, 0, "", "", "Item_Rest_Bonus_Pool", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066D7 RID: 26327
		public static readonly GameAttributeF Item_Unlucky_Bonus_Secs = new GameAttributeF(869, 0f, -1, 0, 0, "", "", "Item_Unlucky_Bonus_Secs", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066D8 RID: 26328
		public static readonly GameAttributeF Item_Unlucky_Bonus_Allow = new GameAttributeF(870, 0f, -1, 0, 0, "", "", "Item_Unlucky_Bonus_Allow", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066D9 RID: 26329
		public static readonly GameAttributeF Random_Item_Unlucky_Bonus = new GameAttributeF(871, 0f, -1, 0, 0, "", "", "Random_Item_Unlucky_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066DA RID: 26330
		public static readonly GameAttributeF Avenger_Buildup_Secs = new GameAttributeF(872, 0f, -1, 0, 0, "", "", "Avenger_Buildup_Secs", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066DB RID: 26331
		public static readonly GameAttributeF Evade_Max_Charges = new GameAttributeF(873, 0f, -1, 0, 0, "", "", "Evade_Max_Charges", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066DC RID: 26332
		public static readonly GameAttributeF Item_Assigned_Account_High = new GameAttributeF(877, 0f, -1, 0, 0, "", "", "Item_Assigned_Account_High", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066DD RID: 26333
		public static readonly GameAttributeF Item_Assigned_Account_Low = new GameAttributeF(878, 0f, -1, 0, 0, "", "", "Item_Assigned_Account_Low", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066DE RID: 26334
		public static readonly GameAttributeF Pierce_Charge = new GameAttributeF(879, 0f, -1, 0, 0, "", "", "Pierce_Charge", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066DF RID: 26335
		public static readonly GameAttributeF Thorns_AOE_Radius_Next_Time = new GameAttributeF(881, 0f, -1, 0, 0, "", "", "Thorns_AOE_Radius_Next_Time", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066E0 RID: 26336
		public static readonly GameAttributeF CurrentPowerHitCount = new GameAttributeF(885, 0f, -1, 0, 0, "", "", "CurrentPowerHitCount", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066E1 RID: 26337
		public static readonly GameAttributeF LastTimeBlockedAnAttack = new GameAttributeF(886, 0f, -1, 0, 0, "", "", "LastTimeBlockedAnAttack", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066E2 RID: 26338
		public static readonly GameAttributeF Last_Time_Damaged = new GameAttributeF(887, 0f, -1, 0, 0, "", "", "Last_Time_Damaged", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066E3 RID: 26339
		public static readonly GameAttributeF Last_Time_Inflicted_Damage = new GameAttributeF(888, 0f, -1, 0, 0, "", "", "Last_Time_Inflicted_Damage", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066E4 RID: 26340
		public static readonly GameAttributeF Current_Mount = new GameAttributeF(892, -1f, -1, 0, 0, "", "", "Current_Mount", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066E5 RID: 26341
		public static readonly GameAttributeF Mount_Dismount_Dmg_Bonus = new GameAttributeF(893, 0f, -1, 0, 0, "", "", "Mount_Dismount_Dmg_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066E6 RID: 26342
		public static readonly GameAttributeF Mount_Fear_Current = new GameAttributeF(894, 0f, -1, 0, 0, "", "", "Mount_Fear_Current", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066E7 RID: 26343
		public static readonly GameAttributeF Mount_Fear_Reduction_Pct = new GameAttributeF(895, 0f, -1, 0, 0, "", "", "Mount_Fear_Reduction_Pct", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066E8 RID: 26344
		public static readonly GameAttributeF Mount_Fear_Increase_Rate_Per_Second = new GameAttributeF(896, 0f, -1, 0, 0, "", "", "Mount_Fear_Increase_Rate_Per_Second", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066E9 RID: 26345
		public static readonly GameAttributeF Mount_Aggro_Reduction_Base_Pct = new GameAttributeF(897, 0f, -1, 0, 0, "", "", "Mount_Aggro_Reduction_Base_Pct", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066EA RID: 26346
		public static readonly GameAttributeF Mount_Aggro_Reduction_Bonus_Pct = new GameAttributeF(898, 0f, -1, 0, 0, "", "", "Mount_Aggro_Reduction_Bonus_Pct", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066EB RID: 26347
		public static readonly GameAttributeF Mount_Aggro_Reduction_Total = new GameAttributeF(899, 0f, -1, 0, 0, "Mount_Aggro_Reduction_Base_Pct * (1 + Mount_Aggro_Reduction_Bonus_Pct)", "", "Mount_Aggro_Reduction_Total", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066EC RID: 26348
		public static readonly GameAttributeF Mount_Carrot_Max_Base = new GameAttributeF(900, 0f, -1, 0, 0, "", "", "Mount_Carrot_Max_Base", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066ED RID: 26349
		public static readonly GameAttributeF Mount_Carrot_Max_Bonus = new GameAttributeF(901, 0f, -1, 0, 0, "", "", "Mount_Carrot_Max_Bonus", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066EE RID: 26350
		public static readonly GameAttributeF Mount_Carrot_Max_Total = new GameAttributeF(902, 0f, -1, 0, 0, "Mount_Carrot_Max_Base + Mount_Carrot_Max_Bonus", "", "Mount_Carrot_Max_Total", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066EF RID: 26351
		public static readonly GameAttributeF Mount_Carrot_Regen_Base = new GameAttributeF(903, 0f, -1, 0, 0, "", "", "Mount_Carrot_Regen_Base", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066F0 RID: 26352
		public static readonly GameAttributeF Mount_Carrot_Regen_Bonus_Pct = new GameAttributeF(904, 0f, -1, 0, 0, "", "", "Mount_Carrot_Regen_Bonus_Pct", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066F1 RID: 26353
		public static readonly GameAttributeF Mount_Carrot_Regen_Total = new GameAttributeF(905, 0f, -1, 0, 0, "Mount_Carrot_Regen_Base + (1 * Mount_Carrot_Regen_Bonus_Pct)", "", "Mount_Carrot_Regen_Total", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066F2 RID: 26354
		public static readonly GameAttributeF Mounted_ACD = new GameAttributeF(906, -1f, -1, 0, 0, "", "", "Mounted_ACD", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066F3 RID: 26355
		public static readonly GameAttributeF Rider_ACD = new GameAttributeF(907, -1f, -1, 0, 0, "", "", "Rider_ACD", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066F4 RID: 26356
		public static readonly GameAttributeF Gizmo_Player_State = new GameAttributeF(908, 0f, -1, 0, 0, "", "", "Gizmo_Player_State", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066F5 RID: 26357
		public static readonly GameAttributeF Gizmo_Anim_Player_State = new GameAttributeF(909, -1f, -1, 0, 0, "", "", "Gizmo_Anim_Player_State", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066F6 RID: 26358
		public static readonly GameAttributeF Retreat_Radius_Override = new GameAttributeF(911, 0f, -1, 0, 0, "", "", "Retreat Radius Override", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066F7 RID: 26359
		public static readonly GameAttributeF Crowd_Control_Build_Up = new GameAttributeF(940, 0f, -1, 0, 0, "", "", "Crowd_Control_Build_Up", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066F8 RID: 26360
		public static readonly GameAttributeF Crowd_Control_Build_Up_Threshold_Base = new GameAttributeF(941, 0f, -1, 0, 0, "", "", "Crowd_Control_Build_Up_Threshold_Base", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066F9 RID: 26361
		public static readonly GameAttributeF Crowd_Control_Build_Up_Threshold = new GameAttributeF(942, 0f, -1, 0, 0, "", "", "Crowd_Control_Build_Up_Threshold", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066FA RID: 26362
		public static readonly GameAttributeF Stagger_Threshold_Additional_Player = new GameAttributeF(943, 0f, -1, 0, 0, "", "", "Stagger_Threshold_Additional_Player", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066FB RID: 26363
		public static readonly GameAttributeF Stagger_Decay_Rate_Additional_Player = new GameAttributeF(944, 0f, -1, 0, 0, "", "", "Stagger_Decay_Rate_Additional_Player", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066FC RID: 26364
		public static readonly GameAttributeF Boss_In_Combat_ANN = new GameAttributeF(945, -1f, -1, 0, 0, "", "", "Boss_In_Combat_ANN", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066FD RID: 26365
		public static readonly GameAttributeF Staggered_Time_Remaining = new GameAttributeF(948, 0f, -1, 0, 0, "", "", "Staggered_Time_Remaining", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066FE RID: 26366
		public static readonly GameAttributeF Necro_Corpse_Charges = new GameAttributeF(949, 0f, -1, 0, 0, "", "", "Necro_Corpse_Charges", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x040066FF RID: 26367
		public static readonly GameAttributeF Necro_Corpse_Source_Actor_SNO = new GameAttributeF(950, -1f, -1, 0, 0, "", "", "Necro_Corpse_Source_Actor_SNO", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006700 RID: 26368
		public static readonly GameAttributeF AI_Prop_Type = new GameAttributeF(951, -1f, -1, 0, 0, "", "", "AI_Prop_Type", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006701 RID: 26369
		public static readonly GameAttributeF AI_Prop_Partner_ANN = new GameAttributeF(952, -1f, -1, 0, 0, "", "", "AI_Prop_Partner_ANN", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006702 RID: 26370
		public static readonly GameAttributeF AI_Prop_Pairing_Name = new GameAttributeF(953, 0f, -1, 0, 0, "", "", "AI_Prop_Pairing_Name", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006703 RID: 26371
		public static readonly GameAttributeF ShopRestockTimeHi = new GameAttributeF(985, 0f, -1, 0, 0, "", "", "ShopRestockTimeHi", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006704 RID: 26372
		public static readonly GameAttributeF ShopRestockTimeLo = new GameAttributeF(986, 0f, -1, 0, 0, "", "", "ShopRestockTimeLo", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006705 RID: 26373
		public static readonly GameAttributeF Headstone_Resurrection_Progress = new GameAttributeF(989, 0f, -1, 0, 0, "", "", "Headstone_Resurrection_Progress", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006706 RID: 26374
		public static readonly GameAttributeF Headstone_Resurrection_Progress_Client = new GameAttributeF(990, 0f, -1, 0, 0, "", "", "Headstone_Resurrection_Progress_Client", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006707 RID: 26375
		public static readonly GameAttributeF Headstone_Actor_Override = new GameAttributeF(991, -1f, -1, 0, 0, "", "", "Headstone_Actor_Override", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006708 RID: 26376
		public static readonly GameAttributeF ManuallyTrackedQuestSNO = new GameAttributeF(992, -1f, -1, 0, 0, "", "", "ManuallyTrackedQuestSNO", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006709 RID: 26377
		public static readonly GameAttributeF OverrideTrackedQuestSNO = new GameAttributeF(993, -1f, -1, 0, 0, "", "", "OverrideTrackedQuestSNO", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400670A RID: 26378
		public static readonly GameAttributeF DebugLoggingTypesEnabled = new GameAttributeF(1009, 0f, -1, 0, 0, "", "", "DebugLoggingTypesEnabled", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400670B RID: 26379
		public static readonly GameAttributeF RevealMinimapAllScenes = new GameAttributeF(1010, 0f, -1, 0, 0, "", "", "RevealMinimapAllScenes", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400670C RID: 26380
		public static readonly GameAttributeF Gold_Find = new GameAttributeF(1014, 0f, -1, 0, 0, "", "", "Gold_Find", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400670D RID: 26381
		public static readonly GameAttributeF Gizmo_Active_cooldown_end_time = new GameAttributeF(1015, 0f, -1, 0, 0, "", "", "Gizmo_Active_cooldown_end_time", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400670E RID: 26382
		public static readonly GameAttributeF Max_Concurrent_Summons_Override = new GameAttributeF(1022, -1f, -1, 0, 0, "", "", "Max_Concurrent_Summons_Override", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400670F RID: 26383
		public static readonly GameAttributeF Item_Find = new GameAttributeF(1026, 0f, -1, 0, 0, "", "", "Item_Find", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006710 RID: 26384
		public static readonly GameAttributeF NPC_Replaced_By_Follower = new GameAttributeF(1027, -1f, -1, 0, 0, "", "", "NPC_Replaced_By_Follower", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006711 RID: 26385
		public static readonly GameAttributeF NPC_Cloned_From_Actor = new GameAttributeF(1028, -1f, -1, 0, 0, "", "", "NPC_Cloned_From_Actor", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006712 RID: 26386
		public static readonly GameAttributeF NPC_Cloned_From_Actor_SNO = new GameAttributeF(1029, -1f, -1, 0, 0, "", "", "NPC_Cloned_From_Actor_SNO", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006713 RID: 26387
		public static readonly GameAttributeF NPC_Clone_Visibility = new GameAttributeF(1030, 0f, -1, 0, 0, "", "", "NPC_Clone_Visibility", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006714 RID: 26388
		public static readonly GameAttributeF NPC_Cloned_For_Quest = new GameAttributeF(1031, -1f, -1, 0, 0, "", "", "NPC_Cloned_For_Quest", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006715 RID: 26389
		public static readonly GameAttributeF Chatter_Cooldown = new GameAttributeF(1032, -1f, -1, 0, 0, "", "", "Chatter_Cooldown", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006716 RID: 26390
		public static readonly GameAttributeF Imbued_Affix = new GameAttributeF(1033, -1f, -1, 0, 0, "", "", "Imbued_Affix", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006717 RID: 26391
		public static readonly GameAttributeF Imbued_Affix_Seed = new GameAttributeF(1034, 0f, -1, 0, 0, "0", "", "Imbued_Affix_Seed", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006718 RID: 26392
		public static readonly GameAttributeF Imbued_Affix_Carry = new GameAttributeF(1035, 0f, -1, 0, 0, "0", "", "Imbued_Affix_Carry", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006719 RID: 26393
		public static readonly GameAttributeF Affix_Replaced = new GameAttributeF(1036, -1f, -1, 0, 0, "", "", "Affix_Replaced", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400671A RID: 26394
		public static readonly GameAttributeF Imbued_Affix_Item_Power = new GameAttributeF(1037, 0f, -1, 0, 0, "", "", "Imbued_Affix_Item_Power", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400671B RID: 26395
		public static readonly GameAttributeF Carryable_Receptacle_Count = new GameAttributeF(1039, 0f, -1, 0, 0, "", "", "Carryable_Receptacle_Count", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400671C RID: 26396
		public static readonly GameAttributeF Carryable_Being_Carried = new GameAttributeF(1040, -1f, -1, 0, 0, "", "", "Carryable_Being_Carried", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400671D RID: 26397
		public static readonly GameAttributeF Carryable_Accumulated_Damage = new GameAttributeF(1042, 0f, -1, 0, 0, "", "", "Carryable_Accumulated_Damage", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400671E RID: 26398
		public static readonly GameAttributeF Chargeable_Gizmo_Progress = new GameAttributeF(1043, 0f, -1, 0, 0, "", "", "Chargeable_Gizmo_Progress", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400671F RID: 26399
		public static readonly GameAttributeF Death_Message_Actor_Override = new GameAttributeF(1047, -1f, -1, 0, 0, "", "", "Death_Message_Actor_Override", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006720 RID: 26400
		public static readonly GameAttributeF Boss_Camera_Override = new GameAttributeF(1050, -1f, -1, 0, 0, "", "", "Boss_Camera_Override", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006721 RID: 26401
		public static readonly GameAttributeF Quest_Referencing_Actor = new GameAttributeF(1054, -1f, -1, 0, 0, "", "", "Quest_Referencing_Actor", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006722 RID: 26402
		public static readonly GameAttributeF Quest_Callback_Referencing_Actor = new GameAttributeF(1055, -1f, -1, 0, 0, "", "", "Quest_Callback_Referencing_Actor", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006723 RID: 26403
		public static readonly GameAttributeF Monster_Flavor_Text_Override = new GameAttributeF(1056, -1f, -1, 0, 0, "", "", "Monster_Flavor_Text_Override", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006724 RID: 26404
		public static readonly GameAttributeF Vessel_Of_Hatred_Progress = new GameAttributeF(1057, 0f, -1, 0, 0, "", "", "Vessel_Of_Hatred_Progress", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006725 RID: 26405
		public static readonly GameAttributeF Owning_Quest = new GameAttributeF(1058, -1f, -1, 0, 0, "", "", "Owning_Quest", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006726 RID: 26406
		public static readonly GameAttributeF Bounty_Points = new GameAttributeF(1059, 0f, -1, 0, 0, "", "", "Bounty_Points", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006727 RID: 26407
		public static readonly GameAttributeF Capped_Item_Spawned_By = new GameAttributeF(1060, -1f, -1, 0, 0, "", "", "Capped_Item_Spawned_By", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006728 RID: 26408
		public static readonly GameAttributeF Power_Interrupt_Remaining_Damage = new GameAttributeF(1062, 0f, -1, 0, 0, "", "", "Power Interrupt Remaining Damage", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006729 RID: 26409
		public static readonly GameAttributeF Event_Participant_Timeout = new GameAttributeF(1064, -1f, -1, 0, 0, "", "", "Event_Participant_Timeout", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400672A RID: 26410
		public static readonly GameAttributeF Local_or_World_Event_SNO = new GameAttributeF(1065, -1f, -1, 0, 0, "", "", "Local_or_World_Event_SNO", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400672B RID: 26411
		public static readonly GameAttributeF Town_Portal_Return_Delete_Timer = new GameAttributeF(1066, -1f, -1, 0, 0, "", "", "Town_Portal_Return_Delete_Timer", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400672C RID: 26412
		public static readonly GameAttributeF Gizmo_Triggered_Bounty_SNO_Target = new GameAttributeF(1067, -1f, -1, 0, 0, "", "", "Gizmo_Triggered_Bounty_SNO_Target", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400672D RID: 26413
		public static readonly GameAttributeF Assassinate_Bounty_Target_Gizmo = new GameAttributeF(1069, -1f, -1, 0, 0, "", "", "Assassinate_Bounty_Target_Gizmo", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400672E RID: 26414
		public static readonly GameAttributeF Side_Quest_Started_By_Gizmo_ = new GameAttributeF(1071, -1f, -1, 0, 0, "", "", "Side_Quest_Started_By_Gizmo_", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x0400672F RID: 26415
		public static readonly GameAttributeF Gizmo_Triggered_Bounty_SNO_Target_Player = new GameAttributeF(1072, 0f, -1, 0, 0, "", "", "Gizmo_Triggered_Bounty_SNO_Target_Player", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006730 RID: 26416
		public static readonly GameAttributeF Last_Survey_Played_Secs = new GameAttributeF(1073, 0f, -1, 0, 0, "", "", "Last_Survey_Played_Secs", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006731 RID: 26417
		public static readonly GameAttributeF Monster_Override_ID = new GameAttributeF(1074, -1f, -1, 0, 0, "", "", "Monster_Override_ID", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006732 RID: 26418
		public static readonly GameAttributeF Quest_Referencing_Item = new GameAttributeF(1075, -1f, -1, 0, 0, "", "", "Quest_Referencing_Item", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006733 RID: 26419
		public static readonly GameAttributeF Last_New_User_Survey_Version = new GameAttributeF(1077, 0f, -1, 0, 0, "", "", "Last_New_User_Survey_Version", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006734 RID: 26420
		public static readonly GameAttributeF Partition_Highest_Player_Level = new GameAttributeF(1079, 0f, -1, 0, 0, "", "", "Partition_Highest_Player_Level", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006735 RID: 26421
		public static readonly GameAttributeF Quest_Phase_Referencing_Actor = new GameAttributeF(1080, -1f, -1, 0, 0, "", "", "Quest_Phase_Referencing_Actor", GameAttributeEncoding.Float32, 0, 0f, 0f, 32);

		// Token: 0x04006736 RID: 26422
		public static readonly GameAttributeF Core_Stat_Minor_Benefit_Scalar_Strength = new GameAttributeF(24, 0f, -1, 0, 0, "", "", "Core_Stat_Minor_Benefit_Scalar_Strength", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006737 RID: 26423
		public static readonly GameAttributeF Core_Stat_Minor_Benefit_Scalar_Intelligence = new GameAttributeF(25, 0f, -1, 0, 0, "", "", "Core_Stat_Minor_Benefit_Scalar_Intelligence", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006738 RID: 26424
		public static readonly GameAttributeF Core_Stat_Minor_Benefit_Scalar_Willpower = new GameAttributeF(26, 0f, -1, 0, 0, "", "", "Core_Stat_Minor_Benefit_Scalar_Willpower", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006739 RID: 26425
		public static readonly GameAttributeF Core_Stat_Minor_Benefit_Scalar_Dexterity = new GameAttributeF(27, 0f, -1, 0, 0, "", "", "Core_Stat_Minor_Benefit_Scalar_Dexterity", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400673A RID: 26426
		public static readonly GameAttributeF Rest_Experience_Bonus_Percent = new GameAttributeF(33, 0f, -1, 0, 0, "", "", "Rest_Experience_Bonus_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400673B RID: 26427
		public static readonly GameAttributeF Intensity_Level = new GameAttributeF(42, 0f, -1, 0, 0, "", "", "Intensity_Level", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400673C RID: 26428
		public static readonly GameAttributeF Monster_Combat_Scaling_Level_Distribution = new GameAttributeF(44, 0f, -1, 0, 0, "", "", "Monster_Combat_Scaling_Level_Distribution", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400673D RID: 26429
		public static readonly GameAttributeF Hitpoints_Max_Percent_Bonus_KeyDun = new GameAttributeF(54, 0f, -1, 0, 0, "", "", "Hitpoints_Max_Percent_Bonus_KeyDun", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400673E RID: 26430
		public static readonly GameAttributeF Faster_Healing_Percent = new GameAttributeF(56, 0f, -1, 0, 0, "", "", "Faster_Healing_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400673F RID: 26431
		public static readonly GameAttributeF Spending_Resource_Heals_Percent = new GameAttributeF(57, 0f, -1, 0, 0, "", "", "Spending_Resource_Heals_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006740 RID: 26432
		public static readonly GameAttributeF Bonus_Healing_Received_Percent = new GameAttributeF(58, 0f, -1, 0, 0, "", "", "Bonus_Healing_Received_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006741 RID: 26433
		public static readonly GameAttributeF Core_Stat_Bonus_Healing_Received_Percent = new GameAttributeF(59, 0f, -1, 0, 0, "Core_Stat_Minor_Benefit_Scalar_Willpower * Willpower_Total", "", "Core_Stat_Bonus_Healing_Received_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006742 RID: 26434
		public static readonly GameAttributeF Reduced_Healing_Received_Percent = new GameAttributeF(60, 0f, -1, 0, 0, "", "", "Reduced_Healing_Received_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006743 RID: 26435
		public static readonly GameAttributeF Resistance = new GameAttributeF(65, 0f, -1, 0, 0, "", "", "Resistance", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006744 RID: 26436
		public static readonly GameAttributeF Resistance_All = new GameAttributeF(67, 0f, -1, 0, 0, "", "", "Resistance_All", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006745 RID: 26437
		public static readonly GameAttributeF Resistance_All_Core_Stat_Bonus = new GameAttributeF(68, 0f, -1, 0, 0, "Core_Stat_Minor_Benefit_Scalar_Intelligence * Intelligence_Total", "", "Resistance_All_Core_Stat_Bonus", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006746 RID: 26438
		public static readonly GameAttributeF Resistance_All_Reduction_Percent = new GameAttributeF(69, 0f, -1, 0, 0, "", "", "Resistance_All_Reduction_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006747 RID: 26439
		public static readonly GameAttributeF Hitpoints_Percent = new GameAttributeF(99, 0f, -1, 0, 0, "", "", "Hitpoints_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006748 RID: 26440
		public static readonly GameAttributeF Hitpoints_Max_Percent_Bonus = new GameAttributeF(114, 0f, -1, 0, 0, "", "", "Hitpoints_Max_Percent_Bonus", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006749 RID: 26441
		public static readonly GameAttributeF Hitpoints_Max_Percent_Bonus_Item = new GameAttributeF(115, 0f, -1, 0, 0, "", "", "Hitpoints_Max_Percent_Bonus_Item", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400674A RID: 26442
		public static readonly GameAttributeF Resource_Max_Percent_Bonus = new GameAttributeF(130, 0f, -1, 0, 0, "", "", "Resource_Max_Percent_Bonus", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400674B RID: 26443
		public static readonly GameAttributeF Resource_Regen_Bonus_Percent = new GameAttributeF(133, 0f, -1, 0, 0, "", "", "Resource_Regen_Bonus_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400674C RID: 26444
		public static readonly GameAttributeF Resource_Regen_All_Primary_Bonus_Percent = new GameAttributeF(134, 0f, -1, 0, 0, "", "", "Resource_Regen_All_Primary_Bonus_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400674D RID: 26445
		public static readonly GameAttributeF Resource_Regen_Total = new GameAttributeF(137, 0f, -1, 0, 0, "((Resource_Regen_Per_Second * (Resource_Regen_Bonus_Percent + 1) * (Resource_Gain_And_Regen_Bonus_Percent + 1)) + (Resource_Regen_Percent_Per_Second * Resource_Max_Total)) * Resource_Regen_Scalar", "", "Resource_Regen_Total", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400674E RID: 26446
		public static readonly GameAttributeF Resource_STARTING_PERCENT = new GameAttributeF(138, 0f, -1, 0, 0, "", "", "Resource_STARTING_PERCENT", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400674F RID: 26447
		public static readonly GameAttributeF Resource_Cost_Reduction_Percent = new GameAttributeF(141, 0f, -1, 0, 0, "", "", "Resource_Cost_Reduction_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006750 RID: 26448
		public static readonly GameAttributeF Resource_Cost_Reduction_Percent_All = new GameAttributeF(142, 0f, -1, 0, 0, "", "", "Resource_Cost_Reduction_Percent_All", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006751 RID: 26449
		public static readonly GameAttributeF Damage_Type_Resource_Cost_Reduction_Percent = new GameAttributeF(144, 0f, -1, 0, 0, "", "", "Damage_Type_Resource_Cost_Reduction_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006752 RID: 26450
		public static readonly GameAttributeF Skill_Tag_Resource_Cost_Reduction_Percent = new GameAttributeF(145, 0f, -1, 0, 0, "", "", "Skill_Tag_Resource_Cost_Reduction_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006753 RID: 26451
		public static readonly GameAttributeF Power_Resource_Cost_Reduction_Percent = new GameAttributeF(147, 0f, -1, 0, 0, "", "", "Power_Resource_Cost_Reduction_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006754 RID: 26452
		public static readonly GameAttributeF Resource_Gain_Bonus_Percent = new GameAttributeF(148, 0f, -1, 0, 0, "", "", "Resource_Gain_Bonus_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006755 RID: 26453
		public static readonly GameAttributeF Resource_Gain_Bonus_Percent_All_Primary = new GameAttributeF(149, 0f, -1, 0, 0, "", "", "Resource_Gain_Bonus_Percent_All_Primary", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006756 RID: 26454
		public static readonly GameAttributeF Resource_Gain_Bonus_Percent_Per_Power = new GameAttributeF(150, 0f, -1, 0, 0, "", "", "Resource_Gain_Bonus_Percent_Per_Power", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006757 RID: 26455
		public static readonly GameAttributeF Resource_Gain_Bonus_Percent_Per_Skill_Tag = new GameAttributeF(151, 0f, -1, 0, 0, "", "", "Resource_Gain_Bonus_Percent_Per_Skill_Tag", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006758 RID: 26456
		public static readonly GameAttributeF Resource_Gain_And_Regen_Bonus_Percent = new GameAttributeF(152, 0f, -1, 0, 0, "", "", "Resource_Gain_And_Regen_Bonus_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006759 RID: 26457
		public static readonly GameAttributeF Resource_Gain_Reduction_Percent = new GameAttributeF(153, 0f, -1, 0, 0, "", "", "Resource_Gain_Reduction_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400675A RID: 26458
		public static readonly GameAttributeF Movement_Scalar = new GameAttributeF(154, 0f, -1, 0, 0, "", "", "Movement_Scalar", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400675B RID: 26459
		public static readonly GameAttributeF Last_Running_Rate = new GameAttributeF(161, 0f, -1, 0, 0, "", "", "Last_Running_Rate", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400675C RID: 26460
		public static readonly GameAttributeF Movement_Bonus_Total = new GameAttributeF(164, 0f, -1, 0, 0, "Movement_Bonus_Run_Speed", "", "Movement_Bonus_Total", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400675D RID: 26461
		public static readonly GameAttributeF Movement_Scalar_Subtotal = new GameAttributeF(165, 0f, -1, 0, 0, "Max(0.1, Movement_Scalar) * (1 + Movement_Bonus_Total) * (1 - Movement_Scalar_Reduction_Percent * (1 - Min(1, Movement_Scalar_Reduction_Resistance)))", "", "Movement_Scalar_Subtotal", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400675E RID: 26462
		public static readonly GameAttributeF Movement_Scalar_Capped_Total = new GameAttributeF(166, 0f, -1, 0, 0, "Min(Movement_Scalar_Cap, Movement_Scalar_Subtotal)", "", "Movement_Scalar_Capped_Total", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400675F RID: 26463
		public static readonly GameAttributeF Movement_Scalar_Uncapped_Bonus = new GameAttributeF(167, 0f, -1, 0, 0, "", "", "Movement_Scalar_Uncapped_Bonus", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006760 RID: 26464
		public static readonly GameAttributeF Movement_Bonus_Run_Speed = new GameAttributeF(169, 0f, -1, 0, 0, "", "", "Movement_Bonus_Run_Speed", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006761 RID: 26465
		public static readonly GameAttributeF Knockback_Attack_Scalar = new GameAttributeF(179, 0f, -1, 0, 0, "", "", "Knockback_Attack_Scalar", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006762 RID: 26466
		public static readonly GameAttributeF AI_Cooldown_Reduction_Percent = new GameAttributeF(188, 0f, -1, 0, 0, "", "", "AI_Cooldown_Reduction_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006763 RID: 26467
		public static readonly GameAttributeF Power_Cooldown_Reduction_Percent = new GameAttributeF(190, 0f, -1, 0, 0, "", "", "Power_Cooldown_Reduction_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006764 RID: 26468
		public static readonly GameAttributeF Power_Cooldown_Reduction_Percent_All = new GameAttributeF(191, 0f, -1, 0, 0, "", "", "Power_Cooldown_Reduction_Percent_All", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006765 RID: 26469
		public static readonly GameAttributeF Skill_Tag_Cooldown_Reduction_Percent = new GameAttributeF(192, 0f, -1, 0, 0, "", "", "Skill_Tag_Cooldown_Reduction_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006766 RID: 26470
		public static readonly GameAttributeF Power_Cooldown_Increase_Percent = new GameAttributeF(193, 0f, -1, 0, 0, "", "", "Power_Cooldown_Increase_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006767 RID: 26471
		public static readonly GameAttributeF Power_Cooldown_Increase_Percent_All = new GameAttributeF(194, 0f, -1, 0, 0, "", "", "Power_Cooldown_Increase_Percent_All", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006768 RID: 26472
		public static readonly GameAttributeF Power_Cooldown_Flat_Second_Increase_All = new GameAttributeF(195, 0f, -1, 0, 0, "", "", "Power_Cooldown_Flat_Second_Increase_All", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006769 RID: 26473
		public static readonly GameAttributeF Damage_Type_Crit_Percent_Bonus = new GameAttributeF(220, 0f, -1, 0, 0, "", "", "Damage_Type_Crit_Percent_Bonus", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400676A RID: 26474
		public static readonly GameAttributeF Damage_Type_Crit_Percent_Bonus_Vs_Elites = new GameAttributeF(221, 0f, -1, 0, 0, "", "", "Damage_Type_Crit_Percent_Bonus_Vs_Elites", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400676B RID: 26475
		public static readonly GameAttributeF Crit_Percent_Bonus_Vs_CC_Target = new GameAttributeF(222, 0f, -1, 0, 0, "", "", "Crit_Percent_Bonus_Vs_CC_Target", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400676C RID: 26476
		public static readonly GameAttributeF Crit_Percent_Bonus_Vs_CC_Target_Any = new GameAttributeF(223, 0f, -1, 0, 0, "", "", "Crit_Percent_Bonus_Vs_CC_Target_Any", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400676D RID: 26477
		public static readonly GameAttributeF Amplify_Damage_Crit_Percent = new GameAttributeF(233, 0f, -1, 0, 0, "", "", "Amplify_Damage_Crit_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400676E RID: 26478
		public static readonly GameAttributeF Multiplicative_Amplify_Damage_Crit_Percent = new GameAttributeF(234, 0f, -1, 0, 0, "", "", "Multiplicative_Amplify_Damage_Crit_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400676F RID: 26479
		public static readonly GameAttributeF Crit_Damage_Percent_Bonus_Vs_CC_Target_Any = new GameAttributeF(235, 0f, -1, 0, 0, "", "", "Crit_Damage_Percent_Bonus_Vs_CC_Target_Any", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006770 RID: 26480
		public static readonly GameAttributeF Crit_Damage_Percent_Bonus_To_Vulnerable = new GameAttributeF(236, 0f, -1, 0, 0, "", "", "Crit_Damage_Percent_Bonus_To_Vulnerable", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006771 RID: 26481
		public static readonly GameAttributeF Damage_Variance_Min_Percent_Reduction = new GameAttributeF(241, 0f, -1, 0, 0, "", "", "Damage_Variance_Min_Percent_Reduction", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006772 RID: 26482
		public static readonly GameAttributeF Damage_Variance_Max_Percent_Bonus = new GameAttributeF(242, 0f, -1, 0, 0, "", "", "Damage_Variance_Max_Percent_Bonus", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006773 RID: 26483
		public static readonly GameAttributeF Amplify_Overpower_Damage = new GameAttributeF(254, 0f, -1, 0, 0, "", "", "Amplify_Overpower_Damage", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006774 RID: 26484
		public static readonly GameAttributeF Blood_Orb_Pickup_Damage_Percent_Bonus = new GameAttributeF(255, 0f, -1, 0, 0, "", "", "Blood_Orb_Pickup_Damage_Percent_Bonus", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006775 RID: 26485
		public static readonly GameAttributeF Blood_Orb_Pickup_Damage_Bonus_Duration = new GameAttributeF(256, 0f, -1, 0, 0, "", "", "Blood_Orb_Pickup_Damage_Bonus_Duration", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006776 RID: 26486
		public static readonly GameAttributeF Blood_Orb_Pickup_Healing_Percent_Bonus = new GameAttributeF(257, 0f, -1, 0, 0, "", "", "Blood_Orb_Pickup_Healing_Percent_Bonus", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006777 RID: 26487
		public static readonly GameAttributeF Imbued_Skill_Damage_Percent_Bonus = new GameAttributeF(258, 0f, -1, 0, 0, "", "", "Imbued_Skill_Damage_Percent_Bonus", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006778 RID: 26488
		public static readonly GameAttributeF Cold_Imbued_Skill_Damage_Percent_Bonus = new GameAttributeF(259, 0f, -1, 0, 0, "", "", "Cold_Imbued_Skill_Damage_Percent_Bonus", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006779 RID: 26489
		public static readonly GameAttributeF Poison_Imbued_Skill_Damage_Percent_Bonus = new GameAttributeF(260, 0f, -1, 0, 0, "", "", "Poison_Imbued_Skill_Damage_Percent_Bonus", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400677A RID: 26490
		public static readonly GameAttributeF Shadow_Imbued_Skill_Damage_Percent_Bonus = new GameAttributeF(261, 0f, -1, 0, 0, "", "", "Shadow_Imbued_Skill_Damage_Percent_Bonus", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400677B RID: 26491
		public static readonly GameAttributeF Imbued_Skill_Crit_Damage_Percent_Bonus = new GameAttributeF(262, 0f, -1, 0, 0, "", "", "Imbued_Skill_Crit_Damage_Percent_Bonus", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400677C RID: 26492
		public static readonly GameAttributeF Imbued_Skill_Strength_Percent_Bonus = new GameAttributeF(263, 0f, -1, 0, 0, "", "", "Imbued_Skill_Strength_Percent_Bonus", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400677D RID: 26493
		public static readonly GameAttributeF Pierce_Chance = new GameAttributeF(266, 0f, -1, 0, 0, "", "", "Pierce_Chance", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400677E RID: 26494
		public static readonly GameAttributeF Dodge_Chance_Bonus = new GameAttributeF(273, 0f, -1, 0, 0, "", "", "Dodge_Chance_Bonus", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400677F RID: 26495
		public static readonly GameAttributeF Core_Stat_Dodge_Chance_Bonus = new GameAttributeF(274, 0f, -1, 0, 0, "Core_Stat_Minor_Benefit_Scalar_Dexterity * Dexterity_Total", "", "Core_Stat_Dodge_Chance_Bonus", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006780 RID: 26496
		public static readonly GameAttributeF Dodge_Chance_Bonus_Melee = new GameAttributeF(275, 0f, -1, 0, 0, "", "", "Dodge_Chance_Bonus_Melee", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006781 RID: 26497
		public static readonly GameAttributeF Dodge_Chance_Bonus_Ranged = new GameAttributeF(276, 0f, -1, 0, 0, "", "", "Dodge_Chance_Bonus_Ranged", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006782 RID: 26498
		public static readonly GameAttributeF Dodge_Chance_Reduction_Percent = new GameAttributeF(280, 0f, -1, 0, 0, "", "", "Dodge_Chance_Reduction_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006783 RID: 26499
		public static readonly GameAttributeF CC_Duration_Bonus_Percent_Per_Type = new GameAttributeF(291, 0f, -1, 0, 0, "", "", "CC_Duration_Bonus_Percent_Per_Type", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006784 RID: 26500
		public static readonly GameAttributeF CC_Duration_Reduction_Per_Type = new GameAttributeF(293, 0f, -1, 0, 0, "", "", "CC_Duration_Reduction_Per_Type", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006785 RID: 26501
		public static readonly GameAttributeF Amplify_Damage_Type_Percent = new GameAttributeF(338, 0f, -1, 0, 0, "", "", "Amplify_Damage_Type_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006786 RID: 26502
		public static readonly GameAttributeF Multiplicative_Amplify_Damage_Type_Percent = new GameAttributeF(339, 0f, -1, 0, 0, "", "", "Multiplicative_Amplify_Damage_Type_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006787 RID: 26503
		public static readonly GameAttributeF Amplify_Damage_DOT_Type_Percent = new GameAttributeF(340, 0f, -1, 0, 0, "", "", "Amplify_Damage_DOT_Type_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006788 RID: 26504
		public static readonly GameAttributeF Multiplicative_Amplify_Damage_DOT_Type_Percent = new GameAttributeF(341, 0f, -1, 0, 0, "", "", "Multiplicative_Amplify_Damage_DOT_Type_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006789 RID: 26505
		public static readonly GameAttributeF Amplify_Damage_Skill_Percent = new GameAttributeF(342, 0f, -1, 0, 0, "", "", "Amplify_Damage_Skill_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400678A RID: 26506
		public static readonly GameAttributeF Amplify_Damage_Percent = new GameAttributeF(343, 0f, -1, 0, 0, "", "", "Amplify_Damage_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400678B RID: 26507
		public static readonly GameAttributeF Multiplicative_Amplify_Damage_Percent = new GameAttributeF(344, 0f, -1, 0, 0, "", "", "Multiplicative_Amplify_Damage_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400678C RID: 26508
		public static readonly GameAttributeF Amplify_Damage_From_Pets_Per_Player_Percent = new GameAttributeF(345, 0f, -1, 0, 0, "", "", "Amplify_Damage_From_Pets_Per_Player_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400678D RID: 26509
		public static readonly GameAttributeF Item_Cost_Percent_Bonus = new GameAttributeF(350, 0f, -1, 0, 0, "", "", "Item_Cost_Percent_Bonus", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400678E RID: 26510
		public static readonly GameAttributeF Item_Durability_Percent = new GameAttributeF(353, 1.0653532E+09f, -1, 0, 0, "", "", "Item_Durability_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400678F RID: 26511
		public static readonly GameAttributeF Item_Durability_Effectiveness = new GameAttributeF(354, 1.0653532E+09f, -1, 0, 0, "", "", "Item_Durability_Effectiveness", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006790 RID: 26512
		public static readonly GameAttributeF Requirement = new GameAttributeF(356, 0f, -1, 0, 0, "", "", "Requirement", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006791 RID: 26513
		public static readonly GameAttributeF Requirements_Ease_Percent = new GameAttributeF(357, 0f, -1, 0, 0, "0", "", "Requirements_Ease_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006792 RID: 26514
		public static readonly GameAttributeF Requirement_When_Equipped = new GameAttributeF(358, 0f, -1, 0, 0, "", "", "Requirement_When_Equipped", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006793 RID: 26515
		public static readonly GameAttributeF Core_Stat_Armor_Bonus = new GameAttributeF(387, 0f, -1, 0, 0, "Core_Stat_Minor_Benefit_Scalar_Strength * Strength_Total", "", "Core_Stat_Armor_Bonus", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006794 RID: 26516
		public static readonly GameAttributeF Run_Speed_Granted = new GameAttributeF(404, 0f, -1, 0, 0, "", "", "Run_Speed_Granted", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006795 RID: 26517
		public static readonly GameAttributeF Custom_Target_Weight = new GameAttributeF(436, 0f, -1, 0, 0, "", "", "Custom_Target_Weight", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006796 RID: 26518
		public static readonly GameAttributeF Custom_Target_Weight_Per_Actor = new GameAttributeF(437, 0f, -1, 0, 0, "", "", "Custom_Target_Weight_Per_Actor", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006797 RID: 26519
		public static readonly GameAttributeF Gizmo_Operation_Radius_Override = new GameAttributeF(445, 0f, -1, 0, 0, "", "", "Gizmo_Operation_Radius_Override", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006798 RID: 26520
		public static readonly GameAttributeF Potion_Bonus_Heal_Percent = new GameAttributeF(519, 0f, -1, 0, 0, "", "", "Potion_Bonus_Heal_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x04006799 RID: 26521
		public static readonly GameAttributeF Potion_Cooldown_Reduction_Percent = new GameAttributeF(520, 0f, -1, 0, 0, "", "", "Potion_Cooldown_Reduction_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400679A RID: 26522
		public static readonly GameAttributeF Potion_Charge = new GameAttributeF(528, 0f, -1, 0, 0, "", "", "Potion_Charge", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400679B RID: 26523
		public static readonly GameAttributeF Potion_Charge_Generation_Bonus_Pct = new GameAttributeF(529, 0f, -1, 0, 0, "", "", "Potion_Charge_Generation_Bonus_Pct", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400679C RID: 26524
		public static readonly GameAttributeF Potion_Charge_Yield_Bonus_Pct = new GameAttributeF(530, 0f, -1, 0, 0, "", "", "Potion_Charge_Yield_Bonus_Pct", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400679D RID: 26525
		public static readonly GameAttributeF Potion_Use_Granted_Barrier_Percent = new GameAttributeF(531, 0f, -1, 0, 0, "", "", "Potion_Use_Granted_Barrier_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400679E RID: 26526
		public static readonly GameAttributeF Potion_Use_Granted_Primary_Resource_Amount = new GameAttributeF(532, 0f, -1, 0, 0, "", "", "Potion_Use_Granted_Primary_Resource_Amount", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x0400679F RID: 26527
		public static readonly GameAttributeF Potion_Use_Granted_Unstoppable_Seconds = new GameAttributeF(533, 0f, -1, 0, 0, "", "", "Potion_Use_Granted_Unstoppable_Seconds", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067A0 RID: 26528
		public static readonly GameAttributeF No_Damage_Taken_Flat_Hitpoints_Regen_Per_Second = new GameAttributeF(537, 0f, -1, 0, 0, "", "", "No_Damage_Taken_Flat_Hitpoints_Regen_Per_Second", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067A1 RID: 26529
		public static readonly GameAttributeF No_Damage_Taken_Flat_Hitpoints_Regen_Per_Second_Unscaled_By_Player_Health = new GameAttributeF(538, 0f, -1, 0, 0, "", "", "No_Damage_Taken_Flat_Hitpoints_Regen_Per_Second_Unscaled_By_Player_Health", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067A2 RID: 26530
		public static readonly GameAttributeF OOC_Flat_Hitpoints_Regen_Per_Second = new GameAttributeF(539, 0f, -1, 0, 0, "", "", "OOC_Flat_Hitpoints_Regen_Per_Second", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067A3 RID: 26531
		public static readonly GameAttributeF OOC_Flat_Hitpoints_Regen_Per_Second_Unscaled_By_Player_Health = new GameAttributeF(540, 0f, -1, 0, 0, "", "", "OOC_Flat_Hitpoints_Regen_Per_Second_Unscaled_By_Player_Health", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067A4 RID: 26532
		public static readonly GameAttributeF Out_Of_Combat_Resource_Regen = new GameAttributeF(542, 0f, -1, 0, 0, "", "", "Out_Of_Combat_Resource_Regen", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067A5 RID: 26533
		public static readonly GameAttributeF Projectile_Reflect_Chance = new GameAttributeF(555, 0f, -1, 0, 0, "", "", "Projectile_Reflect_Chance", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067A6 RID: 26534
		public static readonly GameAttributeF Projectile_Gravity_Multiplier = new GameAttributeF(560, 0f, -1, 0, 0, "", "", "Projectile_Gravity_Multiplier", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067A7 RID: 26535
		public static readonly GameAttributeF Scale_Bonus = new GameAttributeF(565, 0f, -1, 0, 0, "", "", "Scale_Bonus", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067A8 RID: 26536
		public static readonly GameAttributeF Scale_Bonus_Per_Tick = new GameAttributeF(567, 0f, -1, 0, 0, "", "", "Scale_Bonus_Per_Tick", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067A9 RID: 26537
		public static readonly GameAttributeF SlowTime_Debuff = new GameAttributeF(573, 0f, -1, 0, 0, "", "", "SlowTime_Debuff", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067AA RID: 26538
		public static readonly GameAttributeF DamageCap_Percent = new GameAttributeF(595, 0f, -1, 0, 0, "", "", "DamageCap_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067AB RID: 26539
		public static readonly GameAttributeF Vulnerable_Reduction_Percent = new GameAttributeF(613, 0f, -1, 0, 0, "", "", "Vulnerable_Reduction_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067AC RID: 26540
		public static readonly GameAttributeF Damage_Percent_Bonus_When_Fortified = new GameAttributeF(617, 0f, -1, 0, 0, "", "", "Damage_Percent_Bonus_When_Fortified", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067AD RID: 26541
		public static readonly GameAttributeF Damage_Percent_Bonus_To_Fortified = new GameAttributeF(618, 0f, -1, 0, 0, "", "", "Damage_Percent_Bonus_To_Fortified", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067AE RID: 26542
		public static readonly GameAttributeF Look_Target_Broadcast_Intensity = new GameAttributeF(623, 0f, -1, 0, 0, "", "", "Look_Target_Broadcast_Intensity", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067AF RID: 26543
		public static readonly GameAttributeF Look_Target_Broadcast_Radius = new GameAttributeF(624, 0f, -1, 0, 0, "", "", "Look_Target_Broadcast_Radius", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067B0 RID: 26544
		public static readonly GameAttributeF Gem_Attributes_Multiplier = new GameAttributeF(627, 0f, -1, 0, 0, "", "", "Gem_Attributes_Multiplier", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067B1 RID: 26545
		public static readonly GameAttributeF Gizmo_Actor_To_Spawn_Scale = new GameAttributeF(630, 0f, -1, 0, 0, "", "", "Gizmo_Actor_To_Spawn_Scale", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067B2 RID: 26546
		public static readonly GameAttributeF Movement_Scalar_Reduction_Percent = new GameAttributeF(640, 0f, -1, 0, 0, "", "", "Movement_Scalar_Reduction_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067B3 RID: 26547
		public static readonly GameAttributeF Movement_Scalar_Reduction_Resistance = new GameAttributeF(641, 0f, -1, 0, 0, "", "", "Movement_Scalar_Reduction_Resistance", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067B4 RID: 26548
		public static readonly GameAttributeF Spawner_Countdown_Percent = new GameAttributeF(683, 0f, -1, 0, 0, "", "", "Spawner_Countdown_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067B5 RID: 26549
		public static readonly GameAttributeF Gold_PickUp_Radius = new GameAttributeF(687, 0f, -1, 0, 0, "", "", "Gold_PickUp_Radius", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067B6 RID: 26550
		public static readonly GameAttributeF Turn_Rate_Scalar = new GameAttributeF(698, 1.0653532E+09f, -1, 0, 0, "", "", "Turn_Rate_Scalar", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067B7 RID: 26551
		public static readonly GameAttributeF Power_Effect_Size = new GameAttributeF(731, 0f, -1, 0, 0, "", "", "Power_Effect_Size", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067B8 RID: 26552
		public static readonly GameAttributeF Power_Effect_Intensity = new GameAttributeF(732, 0f, -1, 0, 0, "", "", "Power_Effect_Intensity", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067B9 RID: 26553
		public static readonly GameAttributeF Power_Effect_Duration = new GameAttributeF(733, 0f, -1, 0, 0, "", "", "Power_Effect_Duration", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067BA RID: 26554
		public static readonly GameAttributeF Power_Effect_Size_Per_Power = new GameAttributeF(734, 0f, -1, 0, 0, "", "", "Power_Effect_Size_Per_Power", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067BB RID: 26555
		public static readonly GameAttributeF Power_Effect_Intensity_Per_Power = new GameAttributeF(735, 0f, -1, 0, 0, "", "", "Power_Effect_Intensity_Per_Power", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067BC RID: 26556
		public static readonly GameAttributeF Power_Effect_Intensity_Per_Skill_Rank = new GameAttributeF(736, 0f, -1, 0, 0, "", "", "Power_Effect_Intensity_Per_Skill_Rank", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067BD RID: 26557
		public static readonly GameAttributeF Power_Effect_Duration_Per_Power = new GameAttributeF(737, 0f, -1, 0, 0, "", "", "Power_Effect_Duration_Per_Power", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067BE RID: 26558
		public static readonly GameAttributeF Power_Effect_Length = new GameAttributeF(738, 0f, -1, 0, 0, "", "", "Power_Effect_Length", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067BF RID: 26559
		public static readonly GameAttributeF Power_Effect_Width = new GameAttributeF(739, 0f, -1, 0, 0, "", "", "Power_Effect_Width", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067C0 RID: 26560
		public static readonly GameAttributeF Power_Effect_Height = new GameAttributeF(740, 0f, -1, 0, 0, "", "", "Power_Effect_Height", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067C1 RID: 26561
		public static readonly GameAttributeF Power_Effect_Length_Per_Power = new GameAttributeF(741, 0f, -1, 0, 0, "", "", "Power_Effect_Length_Per_Power", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067C2 RID: 26562
		public static readonly GameAttributeF Power_Effect_Width_Per_Power = new GameAttributeF(742, 0f, -1, 0, 0, "", "", "Power_Effect_Width_Per_Power", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067C3 RID: 26563
		public static readonly GameAttributeF Power_Effect_Height_Per_Power = new GameAttributeF(743, 0f, -1, 0, 0, "", "", "Power_Effect_Height_Per_Power", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067C4 RID: 26564
		public static readonly GameAttributeF Power_Effect_Routing_Function_A = new GameAttributeF(748, 1.0653532E+09f, -1, 0, 0, "", "", "Power_Effect_Routing_Function_A", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067C5 RID: 26565
		public static readonly GameAttributeF Power_Effect_Routing_Function_B = new GameAttributeF(749, 1.0653532E+09f, -1, 0, 0, "", "", "Power_Effect_Routing_Function_B", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067C6 RID: 26566
		public static readonly GameAttributeF Power_Effect_Routing_Function_C = new GameAttributeF(750, 1.0653532E+09f, -1, 0, 0, "", "", "Power_Effect_Routing_Function_C", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067C7 RID: 26567
		public static readonly GameAttributeF Power_Effect_Rope_Rigidity = new GameAttributeF(751, 1.0653532E+09f, -1, 0, 0, "", "", "Power_Effect_Rope_Rigidity", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067C8 RID: 26568
		public static readonly GameAttributeF Power_Effect_Routing_Function_A_Per_Power = new GameAttributeF(752, 1.0653532E+09f, -1, 0, 0, "", "", "Power_Effect_Routing_Function_A_Per_Power", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067C9 RID: 26569
		public static readonly GameAttributeF Power_Effect_Routing_Function_B_Per_Power = new GameAttributeF(753, 1.0653532E+09f, -1, 0, 0, "", "", "Power_Effect_Routing_Function_B_Per_Power", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067CA RID: 26570
		public static readonly GameAttributeF Power_Effect_Routing_Function_C_Per_Power = new GameAttributeF(754, 1.0653532E+09f, -1, 0, 0, "", "", "Power_Effect_Routing_Function_C_Per_Power", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067CB RID: 26571
		public static readonly GameAttributeF Power_Effect_Rope_Rigidity_Per_Power = new GameAttributeF(755, 1.0653532E+09f, -1, 0, 0, "", "", "Power_Effect_Rope_Rigidity_Per_Power", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067CC RID: 26572
		public static readonly GameAttributeF On_Hit_CC_Proc_Chance = new GameAttributeF(756, 0f, -1, 0, 0, "", "", "On_Hit_CC_Proc_Chance", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067CD RID: 26573
		public static readonly GameAttributeF On_Crit_CC_Proc_Chance = new GameAttributeF(757, 0f, -1, 0, 0, "", "", "On_Crit_CC_Proc_Chance", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067CE RID: 26574
		public static readonly GameAttributeF On_Hit_Knockback_Proc_Chance = new GameAttributeF(758, 0f, -1, 0, 0, "", "", "On_Hit_Knockback_Proc_Chance", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067CF RID: 26575
		public static readonly GameAttributeF On_Hit_Vulnerable_Proc_Chance = new GameAttributeF(759, 0f, -1, 0, 0, "", "", "On_Hit_Vulnerable_Proc_Chance", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067D0 RID: 26576
		public static readonly GameAttributeF On_Hit_Vulnerable_Proc_Duration_Seconds = new GameAttributeF(760, 0f, -1, 0, 0, "", "", "On_Hit_Vulnerable_Proc_Duration_Seconds", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067D1 RID: 26577
		public static readonly GameAttributeF Movement_Bonus_On_Elite_Kill = new GameAttributeF(762, 0f, -1, 0, 0, "", "", "Movement_Bonus_On_Elite_Kill", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067D2 RID: 26578
		public static readonly GameAttributeF Movement_Bonus_On_Elite_Kill_Duration = new GameAttributeF(763, 0f, -1, 0, 0, "", "", "Movement_Bonus_On_Elite_Kill_Duration", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067D3 RID: 26579
		public static readonly GameAttributeF Damage_Bonus_On_Elite_Kill = new GameAttributeF(764, 0f, -1, 0, 0, "", "", "Damage_Bonus_On_Elite_Kill", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067D4 RID: 26580
		public static readonly GameAttributeF Damage_Bonus_On_Elite_Kill_Duration = new GameAttributeF(765, 0f, -1, 0, 0, "", "", "Damage_Bonus_On_Elite_Kill_Duration", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067D5 RID: 26581
		public static readonly GameAttributeF Damage_Reduction_On_Elite_Kill = new GameAttributeF(766, 0f, -1, 0, 0, "", "", "Damage_Reduction_On_Elite_Kill", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067D6 RID: 26582
		public static readonly GameAttributeF Damage_Reduction_On_Elite_Kill_Duration = new GameAttributeF(767, 0f, -1, 0, 0, "", "", "Damage_Reduction_On_Elite_Kill_Duration", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067D7 RID: 26583
		public static readonly GameAttributeF Damage_Done_Reduction_Percent_On_Pet_Crit = new GameAttributeF(769, 0f, -1, 0, 0, "", "", "Damage_Done_Reduction_Percent_On_Pet_Crit", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067D8 RID: 26584
		public static readonly GameAttributeF Damage_Done_Reduction_On_Pet_Crit_Duration = new GameAttributeF(770, 0f, -1, 0, 0, "", "", "Damage_Done_Reduction_On_Pet_Crit_Duration", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067D9 RID: 26585
		public static readonly GameAttributeF Attack_Speed_Bonus_On_Dodge = new GameAttributeF(771, 0f, -1, 0, 0, "", "", "Attack_Speed_Bonus_On_Dodge", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067DA RID: 26586
		public static readonly GameAttributeF Attack_Speed_Bonus_On_Dodge_Duration = new GameAttributeF(772, 0f, -1, 0, 0, "", "", "Attack_Speed_Bonus_On_Dodge_Duration", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067DB RID: 26587
		public static readonly GameAttributeF Damage_Bonus_Percent_On_Dodge = new GameAttributeF(773, 0f, -1, 0, 0, "", "", "Damage_Bonus_Percent_On_Dodge", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067DC RID: 26588
		public static readonly GameAttributeF Damage_Bonus_Percent_On_Dodge_Duration = new GameAttributeF(774, 0f, -1, 0, 0, "", "", "Damage_Bonus_Percent_On_Dodge_Duration", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067DD RID: 26589
		public static readonly GameAttributeF Fortified_When_Struck_Percent_Chance = new GameAttributeF(775, 0f, -1, 0, 0, "", "", "Fortified_When_Struck_Percent_Chance", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067DE RID: 26590
		public static readonly GameAttributeF Fortified_When_Struck_Amount = new GameAttributeF(776, 0f, -1, 0, 0, "", "", "Fortified_When_Struck_Amount", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067DF RID: 26591
		public static readonly GameAttributeF Barrier_When_Struck_Percent_Chance = new GameAttributeF(777, 0f, -1, 0, 0, "", "", "Barrier_When_Struck_Percent_Chance", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067E0 RID: 26592
		public static readonly GameAttributeF Damage_Percent_Bonus_Vs_CC_Target = new GameAttributeF(785, 0f, -1, 0, 0, "", "", "Damage_Percent_Bonus_Vs_CC_Target", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067E1 RID: 26593
		public static readonly GameAttributeF Multiplicative_Damage_Percent_Bonus_Vs_CC_Target = new GameAttributeF(786, 0f, -1, 0, 0, "", "", "Multiplicative_Damage_Percent_Bonus_Vs_CC_Target", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067E2 RID: 26594
		public static readonly GameAttributeF Damage_Percent_Bonus_Vs_CC_All = new GameAttributeF(787, 0f, -1, 0, 0, "", "", "Damage_Percent_Bonus_Vs_CC_All", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067E3 RID: 26595
		public static readonly GameAttributeF Damage_Percent_Bonus_While_Shapeshifted = new GameAttributeF(789, 0f, -1, 0, 0, "", "", "Damage_Percent_Bonus_While_Shapeshifted", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067E4 RID: 26596
		public static readonly GameAttributeF Damage_Percent_Bonus_Per_Shapeshift_Form = new GameAttributeF(790, 0f, -1, 0, 0, "", "", "Damage_Percent_Bonus_Per_Shapeshift_Form", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067E5 RID: 26597
		public static readonly GameAttributeF Multiplicative_Damage_Percent_Bonus_Per_Shapeshift_Form = new GameAttributeF(791, 0f, -1, 0, 0, "", "", "Multiplicative_Damage_Percent_Bonus_Per_Shapeshift_Form", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067E6 RID: 26598
		public static readonly GameAttributeF Damage_Percent_Bonus_When_Weapon_Swapping = new GameAttributeF(792, 0f, -1, 0, 0, "", "", "Damage_Percent_Bonus_When_Weapon_Swapping", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067E7 RID: 26599
		public static readonly GameAttributeF Damage_Percent_Bonus_While_Affected_By_Power = new GameAttributeF(793, 0f, -1, 0, 0, "", "", "Damage_Percent_Bonus_While_Affected_By_Power", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067E8 RID: 26600
		public static readonly GameAttributeF Damage_Percent_Reduction_From_CCed_Target = new GameAttributeF(796, 0f, -1, 0, 0, "", "", "Damage_Percent_Reduction_From_CCed_Target", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067E9 RID: 26601
		public static readonly GameAttributeF Damage_Percent_Reduction_From_CCed_Target_Any = new GameAttributeF(797, 0f, -1, 0, 0, "", "", "Damage_Percent_Reduction_From_CCed_Target_Any", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067EA RID: 26602
		public static readonly GameAttributeF Damage_Percent_Reduction_From_Vulnerable_Target = new GameAttributeF(798, 0f, -1, 0, 0, "", "", "Damage_Percent_Reduction_From_Vulnerable_Target", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067EB RID: 26603
		public static readonly GameAttributeF Damage_Percent_Reduction_From_Targets_With_Skill_Tag = new GameAttributeF(799, 0f, -1, 0, 0, "", "", "Damage_Percent_Reduction_From_Targets_With_Skill_Tag", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067EC RID: 26604
		public static readonly GameAttributeF Power_Instance_Damage_Percent_Bonus = new GameAttributeF(812, 0f, -1, 0, 0, "", "", "Power_Instance_Damage_Percent_Bonus", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067ED RID: 26605
		public static readonly GameAttributeF Multiplicative_Power_Instance_Damage_Percent_Bonus = new GameAttributeF(813, 0f, -1, 0, 0, "", "", "Multiplicative_Power_Instance_Damage_Percent_Bonus", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067EE RID: 26606
		public static readonly GameAttributeF Power_Instance_Crit_Chance_Bonus = new GameAttributeF(814, 0f, -1, 0, 0, "", "", "Power_Instance_Crit_Chance_Bonus", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067EF RID: 26607
		public static readonly GameAttributeF Power_Instance_Crit_Damage_Bonus = new GameAttributeF(815, 0f, -1, 0, 0, "", "", "Power_Instance_Crit_Damage_Bonus", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067F0 RID: 26608
		public static readonly GameAttributeF Multiplicative_Power_Instance_Crit_Damage_Bonus = new GameAttributeF(816, 0f, -1, 0, 0, "", "", "Multiplicative_Power_Instance_Crit_Damage_Bonus", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067F1 RID: 26609
		public static readonly GameAttributeF Power_Instance_Overpower_Chance_Bonus = new GameAttributeF(817, 0f, -1, 0, 0, "", "", "Power_Instance_Overpower_Chance_Bonus", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067F2 RID: 26610
		public static readonly GameAttributeF Power_Cooldown_Reduction = new GameAttributeF(818, 0f, -1, 0, 0, "", "", "Power_Cooldown_Reduction", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067F3 RID: 26611
		public static readonly GameAttributeF Power_Duration_Bonus_Pct = new GameAttributeF(819, 0f, -1, 0, 0, "", "", "Power_Duration_Bonus_Pct", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067F4 RID: 26612
		public static readonly GameAttributeF Power_Crit_Percent_Bonus = new GameAttributeF(820, 0f, -1, 0, 0, "", "", "Power_Crit_Percent_Bonus", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067F5 RID: 26613
		public static readonly GameAttributeF Evade_Reduce_Cooldown_On_Attack = new GameAttributeF(874, 0f, -1, 0, 0, "", "", "Evade_Reduce_Cooldown_On_Attack", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067F6 RID: 26614
		public static readonly GameAttributeF Evade_Movement_Dodge_Chance = new GameAttributeF(875, 0f, -1, 0, 0, "", "", "Evade_Movement_Dodge_Chance", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067F7 RID: 26615
		public static readonly GameAttributeF Combat_Effect_Chance_Bonus = new GameAttributeF(994, 0f, -1, 0, 0, "", "", "Combat_Effect_Chance_Bonus", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067F8 RID: 26616
		public static readonly GameAttributeF Combat_Effect_Chance_Bonus_Per_Damage_Type = new GameAttributeF(995, 0f, -1, 0, 0, "", "", "Combat_Effect_Chance_Bonus_Per_Damage_Type", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067F9 RID: 26617
		public static readonly GameAttributeF Combat_Effect_Chance_Bonus_Per_Skill = new GameAttributeF(996, 0f, -1, 0, 0, "", "", "Combat_Effect_Chance_Bonus_Per_Skill", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067FA RID: 26618
		public static readonly GameAttributeF Combat_Effect_Chance_Bonus_Barrier_Active = new GameAttributeF(997, 0f, -1, 0, 0, "", "", "Combat_Effect_Chance_Bonus_Barrier_Active", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067FB RID: 26619
		public static readonly GameAttributeF Hit_Effect_Chance_Bonus_Per_Skill_Tag = new GameAttributeF(998, 0f, -1, 0, 0, "", "", "Hit_Effect_Chance_Bonus_Per_Skill_Tag", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067FC RID: 26620
		public static readonly GameAttributeF Pet_Move_Speed_Bonus_Percent = new GameAttributeF(1019, 0f, -1, 0, 0, "", "", "Pet_Move_Speed_Bonus_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067FD RID: 26621
		public static readonly GameAttributeF Previous_Health_Percent = new GameAttributeF(1020, 1.0653532E+09f, -1, 0, 0, "", "", "Previous_Health_Percent", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067FE RID: 26622
		public static readonly GameAttributeF Crafting_Crit_Chance_Percent_Bonus = new GameAttributeF(1045, 0f, -1, 0, 0, "", "", "Crafting_Crit_Chance_Percent_Bonus", GameAttributeEncoding.Float16, 0, 0f, 0f, 16);

		// Token: 0x040067FF RID: 26623
		public static readonly GameAttributeF Experience_Bonus = new GameAttributeF(61, 0f, -1, 0, 0, "", "", "Experience_Bonus", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006800 RID: 26624
		public static readonly GameAttributeF Experience_Bonus_Percent = new GameAttributeF(62, 0f, -1, 0, 0, "", "", "Experience_Bonus_Percent", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006801 RID: 26625
		public static readonly GameAttributeF Experience_Bonus_Percent_Vs_Elites = new GameAttributeF(64, 0f, -1, 0, 0, "", "", "Experience_Bonus_Percent_Vs_Elites", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006802 RID: 26626
		public static readonly GameAttributeF Resistance_Total = new GameAttributeF(66, 0f, -1, 0, 0, "(1.0 - (1.0 - Resistance) * (1.0 - Resistance_All#NONE) * (1.0 - Resistance_All_Core_Stat_Bonus#NONE)) * (1.0 - Resistance_All_Reduction_Percent#NONE)", "", "Resistance_Total", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006803 RID: 26627
		public static readonly GameAttributeF Class_Damage_Reduction_Percent_PvE = new GameAttributeF(70, 0f, -1, 0, 0, "", "", "Class_Damage_Reduction_Percent_PvE", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006804 RID: 26628
		public static readonly GameAttributeF Hitpoints_Max = new GameAttributeF(95, 0f, -1, 0, 0, "", "", "Hitpoints_Max", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006805 RID: 26629
		public static readonly GameAttributeF Hitpoints_Max_Bonus = new GameAttributeF(96, 0f, -1, 0, 0, "", "", "Hitpoints_Max_Bonus", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006806 RID: 26630
		public static readonly GameAttributeF Hitpoints_Max_Base = new GameAttributeF(98, 0f, -1, 0, 0, "", "", "Hitpoints_Max_Base", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006807 RID: 26631
		public static readonly GameAttributeF Flat_Hitpoints_Granted = new GameAttributeF(100, 0f, -1, 0, 0, "", "", "Flat_Hitpoints_Granted", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006808 RID: 26632
		public static readonly GameAttributeF Flat_Hitpoints_Granted_Unscaled_By_Player_Health = new GameAttributeF(101, 0f, -1, 0, 0, "", "", "Flat_Hitpoints_Granted_Unscaled_By_Player_Health", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006809 RID: 26633
		public static readonly GameAttributeF Flat_Hitpoints_Over_Time_Granted = new GameAttributeF(102, 0f, -1, 0, 0, "", "", "Flat_Hitpoints_Over_Time_Granted", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400680A RID: 26634
		public static readonly GameAttributeF Flat_Hitpoints_Over_Time_Granted_Unscaled_By_Player_Health = new GameAttributeF(103, 0f, -1, 0, 0, "", "", "Flat_Hitpoints_Over_Time_Granted_Unscaled_By_Player_Health", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400680B RID: 26635
		public static readonly GameAttributeF Percent_Hitpoints_Over_Time_Granted = new GameAttributeF(104, 0f, -1, 0, 0, "", "", "Percent_Hitpoints_Over_Time_Granted", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400680C RID: 26636
		public static readonly GameAttributeF Flat_Hitpoints_Max_Bonus = new GameAttributeF(105, 0f, -1, 0, 0, "", "", "Flat_Hitpoints_Max_Bonus", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400680D RID: 26637
		public static readonly GameAttributeF Flat_Hitpoints_Max_Bonus_Unscaled_By_Player_Health = new GameAttributeF(106, 0f, -1, 0, 0, "", "", "Flat_Hitpoints_Max_Bonus_Unscaled_By_Player_Health", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400680E RID: 26638
		public static readonly GameAttributeF Hitpoints_Regen_Per_Second = new GameAttributeF(107, 0f, -1, 0, 0, "", "", "Hitpoints_Regen_Per_Second", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400680F RID: 26639
		public static readonly GameAttributeF Hitpoints_Regen_Per_Second_Bonus = new GameAttributeF(108, 0f, -1, 0, 0, "", "", "Hitpoints_Regen_Per_Second_Bonus", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006810 RID: 26640
		public static readonly GameAttributeF Hitpoints_Regen_Bonus_Percent = new GameAttributeF(109, 0f, -1, 0, 0, "", "", "Hitpoints_Regen_Bonus_Percent", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006811 RID: 26641
		public static readonly GameAttributeF Hitpoints_Regen_Reduction_Percent = new GameAttributeF(111, 0f, -1, 0, 0, "", "", "Hitpoints_Regen_Reduction_Percent", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006812 RID: 26642
		public static readonly GameAttributeF Hitpoints_Regen_Per_Second_Health_Globe = new GameAttributeF(112, 0f, -1, 0, 0, "", "", "Hitpoints_Regen_Per_Second_Health_Globe", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006813 RID: 26643
		public static readonly GameAttributeF Hitpoints_Healed_Target = new GameAttributeF(116, 0f, -1, 0, 0, "", "", "Hitpoints_Healed_Target", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006814 RID: 26644
		public static readonly GameAttributeF Resource_Min = new GameAttributeF(126, 0f, -1, 0, 0, "", "", "Resource_Min", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006815 RID: 26645
		public static readonly GameAttributeF Resource_Max = new GameAttributeF(127, 0f, -1, 0, 0, "", "", "Resource_Max", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006816 RID: 26646
		public static readonly GameAttributeF Resource_Max_Bonus = new GameAttributeF(128, 0f, -1, 0, 0, "", "", "Resource_Max_Bonus", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006817 RID: 26647
		public static readonly GameAttributeF Resource_Max_Per_Level = new GameAttributeF(129, 0f, -1, 0, 0, "", "", "Resource_Max_Per_Level", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006818 RID: 26648
		public static readonly GameAttributeF Resource_Regen_Per_Second = new GameAttributeF(132, 0f, -1, 0, 0, "", "", "Resource_Regen_Per_Second", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006819 RID: 26649
		public static readonly GameAttributeF Resource_Regen_Percent_Per_Second = new GameAttributeF(135, 0f, -1, 0, 0, "", "", "Resource_Regen_Percent_Per_Second", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400681A RID: 26650
		public static readonly GameAttributeF Resource_Regen_Scalar = new GameAttributeF(136, 1.0653532E+09f, -1, 0, 0, "", "", "Resource_Regen_Scalar", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400681B RID: 26651
		public static readonly GameAttributeF Resource_Gained_Per_Percent_Damage_Taken = new GameAttributeF(139, 0f, -1, 0, 0, "", "", "Resource_Gained_Per_Percent_Damage_Taken", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400681C RID: 26652
		public static readonly GameAttributeF Power_Cooldown_Min_Time = new GameAttributeF(189, 0f, -1, 0, 0, "", "", "Power_Cooldown_Min_Time", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400681D RID: 26653
		public static readonly GameAttributeF Block_Chance = new GameAttributeF(267, 0f, -1, 0, 0, "", "", "Block_Chance", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400681E RID: 26654
		public static readonly GameAttributeF Block_Damage_Percent = new GameAttributeF(268, 0f, -1, 0, 0, "", "", "Block_Damage_Percent", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400681F RID: 26655
		public static readonly GameAttributeF Flat_Block_Amount = new GameAttributeF(269, 0f, -1, 0, 0, "", "", "Flat_Block_Amount", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006820 RID: 26656
		public static readonly GameAttributeF Flat_Block_Amount_Unscaled_By_Player_Health = new GameAttributeF(270, 0f, -1, 0, 0, "", "", "Flat_Block_Amount_Unscaled_By_Player_Health", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006821 RID: 26657
		public static readonly GameAttributeF CC_Duration_Bonus_Percent = new GameAttributeF(290, 0f, -1, 0, 0, "", "", "CC_Duration_Bonus_Percent", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006822 RID: 26658
		public static readonly GameAttributeF CC_Duration_Reduction = new GameAttributeF(292, 0f, -1, 0, 0, "", "", "CC_Duration_Reduction", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006823 RID: 26659
		public static readonly GameAttributeF Chill_Bonus_Percent = new GameAttributeF(294, 0f, -1, 0, 0, "", "", "Chill_Bonus_Percent", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006824 RID: 26660
		public static readonly GameAttributeF Chill_Progressive_Bonus_Slow_Percent = new GameAttributeF(295, 0f, -1, 0, 0, "", "", "Chill_Progressive_Bonus_Slow_Percent", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006825 RID: 26661
		public static readonly GameAttributeF Helpful_Buff_Duration_Bonus_Percent = new GameAttributeF(296, 0f, -1, 0, 0, "", "", "Helpful_Buff_Duration_Bonus_Percent", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006826 RID: 26662
		public static readonly GameAttributeF Harmful_Buff_Duration_Bonus_Percent = new GameAttributeF(297, 0f, -1, 0, 0, "", "", "Harmful_Buff_Duration_Bonus_Percent", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006827 RID: 26663
		public static readonly GameAttributeF Per_Damage_Type_Buff_Duration_Bonus_Percent = new GameAttributeF(298, 0f, -1, 0, 0, "", "", "Per_Damage_Type_Buff_Duration_Bonus_Percent", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006828 RID: 26664
		public static readonly GameAttributeF Per_Skill_Tag_Buff_Duration_Bonus_Percent = new GameAttributeF(299, 0f, -1, 0, 0, "", "", "Per_Skill_Tag_Buff_Duration_Bonus_Percent", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006829 RID: 26665
		public static readonly GameAttributeF Resource_On_Hit = new GameAttributeF(309, 0f, -1, 0, 0, "", "", "Resource_On_Hit", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400682A RID: 26666
		public static readonly GameAttributeF Proc_Resource_On_Hit_Percent = new GameAttributeF(310, 0f, -1, 0, 0, "", "", "Proc_Resource_On_Hit_Percent", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400682B RID: 26667
		public static readonly GameAttributeF Proc_Resource_On_Hit_Percent_All_Primary = new GameAttributeF(311, 0f, -1, 0, 0, "", "", "Proc_Resource_On_Hit_Percent_All_Primary", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400682C RID: 26668
		public static readonly GameAttributeF Resource_On_Hit_Bonus_Pct = new GameAttributeF(312, 0f, -1, 0, 0, "", "", "Resource_On_Hit_Bonus_Pct", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400682D RID: 26669
		public static readonly GameAttributeF Resource_On_Hit_Bonus = new GameAttributeF(313, 0f, -1, 0, 0, "", "", "Resource_On_Hit_Bonus", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400682E RID: 26670
		public static readonly GameAttributeF Resource_On_Kill = new GameAttributeF(314, 0f, -1, 0, 0, "", "", "Resource_On_Kill", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400682F RID: 26671
		public static readonly GameAttributeF Resource_On_Crit = new GameAttributeF(315, 0f, -1, 0, 0, "", "", "Resource_On_Crit", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006830 RID: 26672
		public static readonly GameAttributeF Flat_Hitpoints_On_Hit = new GameAttributeF(316, 0f, -1, 0, 0, "", "", "Flat_Hitpoints_On_Hit", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006831 RID: 26673
		public static readonly GameAttributeF Flat_Hitpoints_On_Hit_Unscaled_By_Player_Health = new GameAttributeF(317, 0f, -1, 0, 0, "", "", "Flat_Hitpoints_On_Hit_Unscaled_By_Player_Health", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006832 RID: 26674
		public static readonly GameAttributeF Flat_Hitpoints_On_Kill = new GameAttributeF(318, 0f, -1, 0, 0, "", "", "Flat_Hitpoints_On_Kill", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006833 RID: 26675
		public static readonly GameAttributeF Flat_Hitpoints_On_Kill_Unscaled_By_Player_Health = new GameAttributeF(319, 0f, -1, 0, 0, "", "", "Flat_Hitpoints_On_Kill_Unscaled_By_Player_Health", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006834 RID: 26676
		public static readonly GameAttributeF Percent_Life_On_Kill = new GameAttributeF(320, 0f, -1, 0, 0, "", "", "Percent_Life_On_Kill", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006835 RID: 26677
		public static readonly GameAttributeF Hitpoints_On_Kill_Total = new GameAttributeF(321, 0f, -1, 0, 0, "(Percent_Life_On_Kill * Hitpoints_Max_Total)", "", "Hitpoints_On_Kill_Total", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006836 RID: 26678
		public static readonly GameAttributeF Flat_Damage_Shield_On_Kill = new GameAttributeF(323, 0f, -1, 0, 0, "", "", "Flat_Damage_Shield_On_Kill", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006837 RID: 26679
		public static readonly GameAttributeF Flat_Damage_Shield_On_Kill_Unscaled_By_Player_Health = new GameAttributeF(324, 0f, -1, 0, 0, "", "", "Flat_Damage_Shield_On_Kill_Unscaled_By_Player_Health", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006838 RID: 26680
		public static readonly GameAttributeF Last_Damage_Amount = new GameAttributeF(337, -1f, -1, 0, 0, "", "", "Last_Damage_Amount", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006839 RID: 26681
		public static readonly GameAttributeF Pet_Equipped_Proc_Resource_On_Hit_Percent = new GameAttributeF(461, 0f, -1, 0, 0, "", "", "Pet_Equipped_Proc_Resource_On_Hit_Percent", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400683A RID: 26682
		public static readonly GameAttributeF Pet_Equipped_Solo_Attacker_Damage_Bonus = new GameAttributeF(462, 0f, -1, 0, 0, "", "", "Pet_Equipped_Solo_Attacker_Damage_Bonus", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400683B RID: 26683
		public static readonly GameAttributeF Pet_Equipped_Other_Attacker_Damage_Bonus = new GameAttributeF(463, 0f, -1, 0, 0, "", "", "Pet_Equipped_Other_Attacker_Damage_Bonus", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400683C RID: 26684
		public static readonly GameAttributeF Pet_Equipped_Recently_Summoned_Damage_Bonus = new GameAttributeF(464, 0f, -1, 0, 0, "", "", "Pet_Equipped_Recently_Summoned_Damage_Bonus", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400683D RID: 26685
		public static readonly GameAttributeF Pet_Inherit_Attrib_Bonus_Pct = new GameAttributeF(465, 0f, -1, 0, 0, "", "", "Pet_Inherit_Attrib_Bonus_Pct", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400683E RID: 26686
		public static readonly GameAttributeF NecroArmy_Pet_Type_Inherit_Thorns_Bonus_Pct = new GameAttributeF(471, 0f, -1, 0, 0, "", "", "NecroArmy_Pet_Type_Inherit_Thorns_Bonus_Pct", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400683F RID: 26687
		public static readonly GameAttributeF NecroArmy_Pet_Type_All_Resist_Bonus_Pct = new GameAttributeF(472, 0f, -1, 0, 0, "", "", "NecroArmy_Pet_Type_All_Resist_Bonus_Pct", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006840 RID: 26688
		public static readonly GameAttributeF NecroArmy_Pet_Type_Damage_Bonus_Pct = new GameAttributeF(473, 0f, -1, 0, 0, "", "", "NecroArmy_Pet_Type_Damage_Bonus_Pct", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006841 RID: 26689
		public static readonly GameAttributeF Multiplicative_NecroArmy_Pet_Type_Damage_Bonus_Pct = new GameAttributeF(474, 0f, -1, 0, 0, "", "", "Multiplicative_NecroArmy_Pet_Type_Damage_Bonus_Pct", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006842 RID: 26690
		public static readonly GameAttributeF NecroArmy_Pet_Type_Armor_Bonus_Pct = new GameAttributeF(475, 0f, -1, 0, 0, "", "", "NecroArmy_Pet_Type_Armor_Bonus_Pct", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006843 RID: 26691
		public static readonly GameAttributeF NecroArmy_Pet_Type_Attack_Speed_Bonus_Pct = new GameAttributeF(476, 0f, -1, 0, 0, "", "", "NecroArmy_Pet_Type_Attack_Speed_Bonus_Pct", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006844 RID: 26692
		public static readonly GameAttributeF NecroArmy_Damage_Bonus_With_Active_Pet_Type = new GameAttributeF(477, 0f, -1, 0, 0, "", "", "NecroArmy_Damage_Bonus_With_Active_Pet_Type", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006845 RID: 26693
		public static readonly GameAttributeF DPS = new GameAttributeF(584, 0f, -1, 0, 0, "", "", "DPS", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006846 RID: 26694
		public static readonly GameAttributeF Flat_Heal_Absorb = new GameAttributeF(607, 0f, -1, 0, 0, "", "", "Flat_Heal_Absorb", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006847 RID: 26695
		public static readonly GameAttributeF Flat_Heal_Absorb_Unscaled_By_Player_Health = new GameAttributeF(608, 0f, -1, 0, 0, "", "", "Flat_Heal_Absorb_Unscaled_By_Player_Health", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006848 RID: 26696
		public static readonly GameAttributeF Power_Effect_Custom_Value_1 = new GameAttributeF(744, -8388609f, -1, 0, 0, "", "", "Power_Effect_Custom_Value_1", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006849 RID: 26697
		public static readonly GameAttributeF Power_Effect_Custom_Value_2 = new GameAttributeF(745, -8388609f, -1, 0, 0, "", "", "Power_Effect_Custom_Value_2", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400684A RID: 26698
		public static readonly GameAttributeF Power_Effect_Custom_Value_3 = new GameAttributeF(746, -8388609f, -1, 0, 0, "", "", "Power_Effect_Custom_Value_3", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400684B RID: 26699
		public static readonly GameAttributeF Power_Effect_Custom_Value_4 = new GameAttributeF(747, -8388609f, -1, 0, 0, "", "", "Power_Effect_Custom_Value_4", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400684C RID: 26700
		public static readonly GameAttributeF On_Hit_Execute_Low_Health_Non_Elite_Chance = new GameAttributeF(761, 0f, -1, 0, 0, "", "", "On_Hit_Execute_Low_Health_Non_Elite_Chance", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400684D RID: 26701
		public static readonly GameAttributeF Hitpoints_On_Elite_Kill = new GameAttributeF(768, 0f, -1, 0, 0, "", "", "Hitpoints_On_Elite_Kill", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400684E RID: 26702
		public static readonly GameAttributeF Proc_Flat_Hitpoints_On_Hit = new GameAttributeF(778, 0f, -1, 0, 0, "", "", "Proc_Flat_Hitpoints_On_Hit", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400684F RID: 26703
		public static readonly GameAttributeF Proc_Flat_Hitpoints_On_Hit_Unscaled_By_Player_Health = new GameAttributeF(779, 0f, -1, 0, 0, "", "", "Proc_Flat_Hitpoints_On_Hit_Unscaled_By_Player_Health", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006850 RID: 26704
		public static readonly GameAttributeF Weapon_On_Hit_Percent_Bleed_Proc_Chance = new GameAttributeF(805, 0f, -1, 0, 0, "", "", "Weapon_On_Hit_Percent_Bleed_Proc_Chance", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006851 RID: 26705
		public static readonly GameAttributeF Weapon_On_Hit_Percent_Bleed_Proc_Damage = new GameAttributeF(806, 0f, -1, 0, 0, "", "", "Weapon_On_Hit_Percent_Bleed_Proc_Damage", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006852 RID: 26706
		public static readonly GameAttributeF Multiplicative_Weapon_On_Hit_Percent_Bleed_Proc_Damage = new GameAttributeF(807, 0f, -1, 0, 0, "", "", "Multiplicative_Weapon_On_Hit_Percent_Bleed_Proc_Damage", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006853 RID: 26707
		public static readonly GameAttributeF Weapon_On_Hit_Percent_Bleed_Proc_Duration = new GameAttributeF(808, 0f, -1, 0, 0, "", "", "Weapon_On_Hit_Percent_Bleed_Proc_Duration", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006854 RID: 26708
		public static readonly GameAttributeF CrowdControl_Projected_End_Time = new GameAttributeF(833, 0f, -1, 0, 0, "", "", "CrowdControl_Projected_End_Time", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006855 RID: 26709
		public static readonly GameAttributeF Experience_Bonus_Percent_IGR_Buff = new GameAttributeF(846, 0f, -1, 0, 0, "", "", "Experience_Bonus_Percent_IGR_Buff", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006856 RID: 26710
		public static readonly GameAttributeF Experience_Bonus_Percent_Anniversary_Buff = new GameAttributeF(847, 0f, -1, 0, 0, "", "", "Experience_Bonus_Percent_Anniversary_Buff", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006857 RID: 26711
		public static readonly GameAttributeF Experience_Bonus_Percent_Community_Buff = new GameAttributeF(848, 0f, -1, 0, 0, "", "", "Experience_Bonus_Percent_Community_Buff", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006858 RID: 26712
		public static readonly GameAttributeF Experience_Bonus_Percent_Super_Scalar = new GameAttributeF(849, 0f, -1, 0, 0, "", "", "Experience_Bonus_Percent_Super_Scalar", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006859 RID: 26713
		public static readonly GameAttributeF Experience_Bonus_Percent_Super_Scalar_Total = new GameAttributeF(850, 0f, -1, 0, 0, "Experience_Bonus_Percent_Super_Scalar + Experience_Bonus_Percent_Community_Buff + Experience_Bonus_Percent_IGR_Buff + Experience_Bonus_Percent_Anniversary_Buff", "", "Experience_Bonus_Percent_Super_Scalar_Total", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400685A RID: 26714
		public static readonly GameAttributeF Damage_Bonus_To_Near = new GameAttributeF(913, 0f, -1, 0, 0, "", "", "Damage_Bonus_To_Near", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400685B RID: 26715
		public static readonly GameAttributeF Multiplicative_Damage_Bonus_To_Near = new GameAttributeF(914, 0f, -1, 0, 0, "", "", "Multiplicative_Damage_Bonus_To_Near", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400685C RID: 26716
		public static readonly GameAttributeF Damage_Bonus_To_Far = new GameAttributeF(915, 0f, -1, 0, 0, "", "", "Damage_Bonus_To_Far", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400685D RID: 26717
		public static readonly GameAttributeF Multiplicative_Damage_Bonus_To_Far = new GameAttributeF(916, 0f, -1, 0, 0, "", "", "Multiplicative_Damage_Bonus_To_Far", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400685E RID: 26718
		public static readonly GameAttributeF Crit_Chance_Bonus_To_Near = new GameAttributeF(917, 0f, -1, 0, 0, "", "", "Crit_Chance_Bonus_To_Near", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400685F RID: 26719
		public static readonly GameAttributeF Crit_Chance_Bonus_To_Far = new GameAttributeF(918, 0f, -1, 0, 0, "", "", "Crit_Chance_Bonus_To_Far", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006860 RID: 26720
		public static readonly GameAttributeF Crit_Damage_Bonus_To_Near = new GameAttributeF(919, 0f, -1, 0, 0, "", "", "Crit_Damage_Bonus_To_Near", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006861 RID: 26721
		public static readonly GameAttributeF Crit_Damage_Bonus_To_Far = new GameAttributeF(920, 0f, -1, 0, 0, "", "", "Crit_Damage_Bonus_To_Far", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006862 RID: 26722
		public static readonly GameAttributeF Damage_Reduction_From_Near = new GameAttributeF(921, 0f, -1, 0, 0, "", "", "Damage_Reduction_From_Near", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006863 RID: 26723
		public static readonly GameAttributeF Damage_Reduction_From_Far = new GameAttributeF(922, 0f, -1, 0, 0, "", "", "Damage_Reduction_From_Far", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006864 RID: 26724
		public static readonly GameAttributeF Damage_Increase_From_Near = new GameAttributeF(923, 0f, -1, 0, 0, "", "", "Damage_Increase_From_Near", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006865 RID: 26725
		public static readonly GameAttributeF Damage_Increase_From_Far = new GameAttributeF(924, 0f, -1, 0, 0, "", "", "Damage_Increase_From_Far", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006866 RID: 26726
		public static readonly GameAttributeF Damage_Bonus_To_Low_Health = new GameAttributeF(925, 0f, -1, 0, 0, "", "", "Damage_Bonus_To_Low_Health", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006867 RID: 26727
		public static readonly GameAttributeF Multiplicative_Damage_Bonus_To_Low_Health = new GameAttributeF(926, 0f, -1, 0, 0, "", "", "Multiplicative_Damage_Bonus_To_Low_Health", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006868 RID: 26728
		public static readonly GameAttributeF Damage_Bonus_To_High_Health = new GameAttributeF(927, 0f, -1, 0, 0, "", "", "Damage_Bonus_To_High_Health", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006869 RID: 26729
		public static readonly GameAttributeF Multiplicative_Damage_Bonus_To_High_Health = new GameAttributeF(928, 0f, -1, 0, 0, "", "", "Multiplicative_Damage_Bonus_To_High_Health", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400686A RID: 26730
		public static readonly GameAttributeF Damage_Reduction_At_Low_Health = new GameAttributeF(929, 0f, -1, 0, 0, "", "", "Damage_Reduction_At_Low_Health", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400686B RID: 26731
		public static readonly GameAttributeF Damage_Reduction_At_High_Health = new GameAttributeF(930, 0f, -1, 0, 0, "", "", "Damage_Reduction_At_High_Health", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400686C RID: 26732
		public static readonly GameAttributeF Damage_Bonus_At_High_Health = new GameAttributeF(931, 0f, -1, 0, 0, "", "", "Damage_Bonus_At_High_Health", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400686D RID: 26733
		public static readonly GameAttributeF Multiplicative_Damage_Bonus_At_High_Health = new GameAttributeF(932, 0f, -1, 0, 0, "", "", "Multiplicative_Damage_Bonus_At_High_Health", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400686E RID: 26734
		public static readonly GameAttributeF Damage_Reduction = new GameAttributeF(933, 0f, -1, 0, 0, "", "", "Damage_Reduction", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400686F RID: 26735
		public static readonly GameAttributeF Damage_Reduction_While_Having_Shield = new GameAttributeF(934, 0f, -1, 0, 0, "", "", "Damage_Reduction_While_Having_Shield", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006870 RID: 26736
		public static readonly GameAttributeF Damage_Reduction_While_Crowd_Controlled = new GameAttributeF(935, 0f, -1, 0, 0, "", "", "Damage_Reduction_While_Crowd_Controlled", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006871 RID: 26737
		public static readonly GameAttributeF Damage_Reduction_While_Stationary = new GameAttributeF(936, 0f, -1, 0, 0, "", "", "Damage_Reduction_While_Stationary", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006872 RID: 26738
		public static readonly GameAttributeF Damage_Increase_While_Stationary = new GameAttributeF(937, 0f, -1, 0, 0, "", "", "Damage_Increase_While_Stationary", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006873 RID: 26739
		public static readonly GameAttributeF Damage_Type_Damage_Reduction = new GameAttributeF(938, 0f, -1, 0, 0, "", "", "Damage_Type_Damage_Reduction", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006874 RID: 26740
		public static readonly GameAttributeF Custom_Power_Value_1 = new GameAttributeF(967, 0f, -1, 0, 0, "", "", "Custom_Power_Value_1", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006875 RID: 26741
		public static readonly GameAttributeF Custom_Power_Value_2 = new GameAttributeF(968, 0f, -1, 0, 0, "", "", "Custom_Power_Value_2", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006876 RID: 26742
		public static readonly GameAttributeF Custom_Power_Flat_Value_1 = new GameAttributeF(969, 0f, -1, 0, 0, "", "", "Custom_Power_Flat_Value_1", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006877 RID: 26743
		public static readonly GameAttributeF Custom_Power_Flat_Value_1_Unscaled_By_Player_Health = new GameAttributeF(970, 0f, -1, 0, 0, "", "", "Custom_Power_Flat_Value_1_Unscaled_By_Player_Health", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006878 RID: 26744
		public static readonly GameAttributeF Custom_Power_Flat_Value_2 = new GameAttributeF(971, 0f, -1, 0, 0, "", "", "Custom_Power_Flat_Value_2", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006879 RID: 26745
		public static readonly GameAttributeF Custom_Power_Flat_Value_2_Unscaled_By_Player_Health = new GameAttributeF(972, 0f, -1, 0, 0, "", "", "Custom_Power_Flat_Value_2_Unscaled_By_Player_Health", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400687A RID: 26746
		public static readonly GameAttributeF Affix_Value_1 = new GameAttributeF(973, 0f, -1, 0, 0, "", "", "Affix_Value_1", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400687B RID: 26747
		public static readonly GameAttributeF Affix_Value_2 = new GameAttributeF(974, 0f, -1, 0, 0, "", "", "Affix_Value_2", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 16);

		// Token: 0x0400687C RID: 26748
		public static readonly GameAttributeF Affix_Flat_Value_1 = new GameAttributeF(975, 0f, -1, 0, 0, "", "", "Affix_Flat_Value_1", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400687D RID: 26749
		public static readonly GameAttributeF Affix_Flat_Value_1_Unscaled_By_Player_Health = new GameAttributeF(976, 0f, -1, 0, 0, "", "", "Affix_Flat_Value_1_Unscaled_By_Player_Health", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400687E RID: 26750
		public static readonly GameAttributeF Affix_Flat_Value_2 = new GameAttributeF(977, 0f, -1, 0, 0, "", "", "Affix_Flat_Value_2", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400687F RID: 26751
		public static readonly GameAttributeF Affix_Flat_Value_2_Unscaled_By_Player_Health = new GameAttributeF(978, 0f, -1, 0, 0, "", "", "Affix_Flat_Value_2_Unscaled_By_Player_Health", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006880 RID: 26752
		public static readonly GameAttributeF Condition_Rune_Scalar = new GameAttributeF(980, 1.0653532E+09f, -1, 0, 0, "", "", "Condition_Rune_Scalar", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006881 RID: 26753
		public static readonly GameAttributeF Effect_Rune_Magnitude = new GameAttributeF(981, 1.0653532E+09f, -1, 0, 0, "", "", "Effect_Rune_Magnitude", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006882 RID: 26754
		public static readonly GameAttributeF Effect_Rune_Magnitude_Flat = new GameAttributeF(982, 1.0653532E+09f, -1, 0, 0, "", "", "Effect_Rune_Magnitude_Flat", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006883 RID: 26755
		public static readonly GameAttributeF Effect_Rune_Magnitude_Flat_Unscaled_By_Player_Health = new GameAttributeF(983, 1.0653532E+09f, -1, 0, 0, "", "", "Effect_Rune_Magnitude_Flat_Unscaled_By_Player_Health", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006884 RID: 26756
		public static readonly GameAttributeF Effect_Rune_Magnitude_Total = new GameAttributeF(984, 1.0653532E+09f, -1, 0, 0, "", "", "Effect_Rune_Magnitude_Total", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006885 RID: 26757
		public static readonly GameAttributeF Barrier_Bonus_Percent = new GameAttributeF(1011, 0f, -1, 0, 0, "", "", "Barrier_Bonus_Percent", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006886 RID: 26758
		public static readonly GameAttributeF Barrier_Duration_Bonus_Percent = new GameAttributeF(1012, 0f, -1, 0, 0, "", "", "Barrier_Duration_Bonus_Percent", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006887 RID: 26759
		public static readonly GameAttributeF Shrine_Elixir_Duration_Bonus = new GameAttributeF(1013, 0f, -1, 0, 0, "", "", "Shrine_Elixir_Duration_Bonus", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006888 RID: 26760
		public static readonly GameAttributeF Pet_Damage_Bonus_Percent = new GameAttributeF(1016, 0f, -1, 0, 0, "", "", "Pet_Damage_Bonus_Percent", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x04006889 RID: 26761
		public static readonly GameAttributeF Pet_Damage_Reduction_Percent = new GameAttributeF(1017, 0f, -1, 0, 0, "", "", "Pet_Damage_Reduction_Percent", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400688A RID: 26762
		public static readonly GameAttributeF Pet_Attack_Speed_Bonus_Percent = new GameAttributeF(1018, 0f, -1, 0, 0, "", "", "Pet_Attack_Speed_Bonus_Percent", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400688B RID: 26763
		public static readonly GameAttributeF Class_Damage_Reduction_Percent_PvP = new GameAttributeF(1063, 0f, -1, 0, 0, "", "", "Class_Damage_Reduction_Percent_PvP", GameAttributeEncoding.Float16Or32, 0, 0f, 0f, 0);

		// Token: 0x0400688C RID: 26764
		public static readonly GameAttributeI Stash_Slots = new GameAttributeI(1, 0, -1, 0, 0, "", "", "Stash_Slots", GameAttributeEncoding.Int, 0, 0, 200, 8);

		// Token: 0x0400688D RID: 26765
		public static readonly GameAttributeI Level = new GameAttributeI(35, 0, -1, 0, 0, "", "", "Level", GameAttributeEncoding.IntMinMax, 0, -1, 200, 8);

		// Token: 0x0400688E RID: 26766
		public static readonly GameAttributeI Level_Cap = new GameAttributeI(36, 0, -1, 0, 0, "", "", "Level_Cap", GameAttributeEncoding.Int, 0, -1, 100, 7);

		// Token: 0x0400688F RID: 26767
		public static readonly GameAttributeI Level_Scaling_Min = new GameAttributeI(37, 0, -1, 0, 0, "", "", "Level_Scaling_Min", GameAttributeEncoding.Int, 0, -1, 200, 8);

		// Token: 0x04006890 RID: 26768
		public static readonly GameAttributeI Level_Scaling_Match_Until_Level = new GameAttributeI(38, 0, -1, 0, 0, "", "", "Level_Scaling_Match_Until_Level", GameAttributeEncoding.Int, 0, -1, 200, 8);

		// Token: 0x04006891 RID: 26769
		public static readonly GameAttributeI Level_Scaling_Delta_Base = new GameAttributeI(39, 0, -1, 0, 0, "", "", "Level_Scaling_Delta_Base", GameAttributeEncoding.Int, 0, -200, 200, 9);

		// Token: 0x04006892 RID: 26770
		public static readonly GameAttributeI Level_Scaling_Delta_Subzone_Modifier_Bonus = new GameAttributeI(40, 0, -1, 0, 0, "", "", "Level_Scaling_Delta_Subzone_Modifier_Bonus", GameAttributeEncoding.Int, 0, -200, 200, 9);

		// Token: 0x04006893 RID: 26771
		public static readonly GameAttributeI Level_Scaling_Max = new GameAttributeI(41, 0, -1, 0, 0, "", "", "Level_Scaling_Max", GameAttributeEncoding.Int, 0, -1, 200, 8);

		// Token: 0x04006894 RID: 26772
		public static readonly GameAttributeI Monster_Combat_Scaling_Level = new GameAttributeI(43, 0, -1, 0, 0, "", "", "Monster_Combat_Scaling_Level", GameAttributeEncoding.Int, 0, -1, 100, 7);

		// Token: 0x04006895 RID: 26773
		public static readonly GameAttributeI Skill = new GameAttributeI(71, 0, -1, 0, 0, "", "", "Skill", GameAttributeEncoding.Int, 0, 0, 4095, 12);

		// Token: 0x04006896 RID: 26774
		public static readonly GameAttributeB Skill_Special_Unlock = new GameAttributeB(72, 0, -1, 0, 0, "", "", "Skill_Special_Unlock", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006897 RID: 26775
		public static readonly GameAttributeB Skill_Tree_Skill_Unlocked = new GameAttributeB(77, 0, -1, 0, 0, "", "", "Skill_Tree_Skill_Unlocked", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006898 RID: 26776
		public static readonly GameAttributeI TeamID = new GameAttributeI(79, -1, -1, 0, 0, "", "", "TeamID", GameAttributeEncoding.IntMinMax, 0, -1, 41, 6);

		// Token: 0x04006899 RID: 26777
		public static readonly GameAttributeI Team_Override = new GameAttributeI(80, -1, -1, 0, 0, "", "", "Team_Override", GameAttributeEncoding.IntMinMax, 0, -1, 41, 6);

		// Token: 0x0400689A RID: 26778
		public static readonly GameAttributeB Invulnerable = new GameAttributeB(81, 0, -1, 0, 0, "", "", "Invulnerable", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400689B RID: 26779
		public static readonly GameAttributeB Death_Triggered = new GameAttributeB(82, 0, -1, 0, 0, "", "", "Death_Triggered", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400689C RID: 26780
		public static readonly GameAttributeB Dead = new GameAttributeB(84, 0, -1, 0, 0, "", "", "Dead", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400689D RID: 26781
		public static readonly GameAttributeB Disable_Dur_Hit_On_Rez = new GameAttributeB(85, 0, -1, 0, 0, "", "", "Disable_Dur_Hit_On_Rez", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400689E RID: 26782
		public static readonly GameAttributeB Loading = new GameAttributeB(86, 0, -1, 0, 0, "", "", "Loading", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400689F RID: 26783
		public static readonly GameAttributeB No_Damage = new GameAttributeB(90, 0, -1, 0, 0, "", "", "No_Damage", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068A0 RID: 26784
		public static readonly GameAttributeB No_AutoPickup = new GameAttributeB(91, 0, -1, 0, 0, "", "", "No_AutoPickup", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068A1 RID: 26785
		public static readonly GameAttributeB Hitpoints_Frozen = new GameAttributeB(117, 0, -1, 0, 0, "", "", "Hitpoints_Frozen", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068A2 RID: 26786
		public static readonly GameAttributeI Resource_Type_Primary = new GameAttributeI(123, -1, -1, 0, 0, "", "", "Resource_Type_Primary", GameAttributeEncoding.Int, 0, -1, 7, 4);

		// Token: 0x040068A3 RID: 26787
		public static readonly GameAttributeI Resource_Type_Secondary = new GameAttributeI(124, -1, -1, 0, 0, "", "", "Resource_Type_Secondary", GameAttributeEncoding.Int, 0, -1, 7, 4);

		// Token: 0x040068A4 RID: 26788
		public static readonly GameAttributeI Resource_Cost_Reduction_Amount = new GameAttributeI(140, 0, -1, 0, 0, "", "", "Resource_Cost_Reduction_Amount", GameAttributeEncoding.Int, 0, -4095, 16383, 15);

		// Token: 0x040068A5 RID: 26789
		public static readonly GameAttributeI Power_Resource_Cost_Reduction_Amount = new GameAttributeI(146, 0, -1, 0, 0, "", "", "Power_Resource_Cost_Reduction_Amount", GameAttributeEncoding.Int, 0, -4095, 16383, 15);

		// Token: 0x040068A6 RID: 26790
		public static readonly GameAttributeI Movement_Rate = new GameAttributeI(171, -1, -1, 0, 0, "", "", "Movement_Rate", GameAttributeEncoding.Int, 0, -1, 4, 3);

		// Token: 0x040068A7 RID: 26791
		public static readonly GameAttributeB Force_Stationary = new GameAttributeB(172, 0, -1, 0, 0, "", "", "Force_Stationary", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068A8 RID: 26792
		public static readonly GameAttributeI Anim_Permutation_Group = new GameAttributeI(173, 0, -1, 0, 0, "", "", "Anim_Permutation_Group", GameAttributeEncoding.Int, 0, 0, 255, 8);

		// Token: 0x040068A9 RID: 26793
		public static readonly GameAttributeI Anim_Permutation_Group_Override = new GameAttributeI(174, 0, -1, 0, 0, "", "", "Anim_Permutation_Group_Override", GameAttributeEncoding.Int, 0, 0, 255, 8);

		// Token: 0x040068AA RID: 26794
		public static readonly GameAttributeB Zero_Cooldown_Per_Power = new GameAttributeB(196, 0, -1, 0, 0, "", "", "Zero_Cooldown_Per_Power", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068AB RID: 26795
		public static readonly GameAttributeB Zero_Cooldown_Per_Skill_Tag = new GameAttributeB(197, 0, -1, 0, 0, "", "", "Zero_Cooldown_Per_Skill_Tag", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068AC RID: 26796
		public static readonly GameAttributeB Zero_Resource_Cost_Per_Power = new GameAttributeB(198, 0, -1, 0, 0, "", "", "Zero_Resource_Cost_Per_Power", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068AD RID: 26797
		public static readonly GameAttributeB Zero_Resource_Cost_Per_Skill_Tag = new GameAttributeB(199, 0, -1, 0, 0, "", "", "Zero_Resource_Cost_Per_Skill_Tag", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068AE RID: 26798
		public static readonly GameAttributeB Crit_Damage_Deals_Max_Damage = new GameAttributeB(240, 0, -1, 0, 0, "", "", "Crit_Damage_Deals_Max_Damage", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068AF RID: 26799
		public static readonly GameAttributeB Cannot_Dodge = new GameAttributeB(281, 0, -1, 0, 0, "", "", "Cannot_Dodge", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068B0 RID: 26800
		public static readonly GameAttributeB Immunity = new GameAttributeB(284, 0, -1, 0, 0, "", "", "Immunity", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068B1 RID: 26801
		public static readonly GameAttributeB Ignores_Critical_Hits = new GameAttributeB(285, 0, -1, 0, 0, "", "", "Ignores_Critical_Hits", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068B2 RID: 26802
		public static readonly GameAttributeB Untargetable = new GameAttributeB(286, 0, -1, 0, 0, "", "", "Untargetable", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068B3 RID: 26803
		public static readonly GameAttributeI Is_Crowd_Control = new GameAttributeI(287, 0, -1, 0, 0, "", "", "Is_Crowd_Control", GameAttributeEncoding.Int, 0, 0, 3, 2);

		// Token: 0x040068B4 RID: 26804
		public static readonly GameAttributeB Crowd_Control_Immune = new GameAttributeB(288, 0, -1, 0, 0, "", "", "Crowd_Control_Immune", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068B5 RID: 26805
		public static readonly GameAttributeB Immune_To_Knockback = new GameAttributeB(289, 0, -1, 0, 0, "", "", "Immune_To_Knockback", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068B6 RID: 26806
		public static readonly GameAttributeB Gethit_Immune = new GameAttributeB(300, 0, -1, 0, 0, "", "", "Gethit_Immune", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068B7 RID: 26807
		public static readonly GameAttributeB AttackSpeed_Reduction_Immune = new GameAttributeB(301, 0, -1, 0, 0, "", "", "AttackSpeed_Reduction_Immune", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068B8 RID: 26808
		public static readonly GameAttributeB Skill_Toggled_State = new GameAttributeB(333, 0, -1, 0, 0, "", "", "Skill_Toggled_State", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068B9 RID: 26809
		public static readonly GameAttributeI Skill_Charges = new GameAttributeI(334, 0, -1, 0, 0, "", "", "Skill_Charges", GameAttributeEncoding.Int, 0, 0, 99, 7);

		// Token: 0x040068BA RID: 26810
		public static readonly GameAttributeI Item_Quality_Level = new GameAttributeI(347, -1, -1, 0, 0, "", "", "Item_Quality_Level", GameAttributeEncoding.Int, 0, -1, 8, 4);

		// Token: 0x040068BB RID: 26811
		public static readonly GameAttributeI Item_Quality_Level_Identified = new GameAttributeI(348, -1, -1, 0, 0, "", "", "Item_Quality_Level_Identified", GameAttributeEncoding.Int, 0, -1, 8, 4);

		// Token: 0x040068BC RID: 26812
		public static readonly GameAttributeI Item_Quality_Modifier = new GameAttributeI(349, 0, -1, 0, 0, "", "", "Item_Quality_Modifier", GameAttributeEncoding.Int, 0, 0, 3, 2);

		// Token: 0x040068BD RID: 26813
		public static readonly GameAttributeB Item_Equipped = new GameAttributeB(351, 0, -1, 0, 0, "", "", "Item_Equipped", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068BE RID: 26814
		public static readonly GameAttributeB Ignore_Durability_Loss = new GameAttributeB(355, 0, -1, 0, 0, "", "", "Ignore_Durability_Loss", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068BF RID: 26815
		public static readonly GameAttributeI Sockets = new GameAttributeI(359, 0, -1, 0, 0, "0", "", "Sockets", GameAttributeEncoding.Int, 0, 0, 2, 2);

		// Token: 0x040068C0 RID: 26816
		public static readonly GameAttributeI Sockets_Filled = new GameAttributeI(360, 0, -1, 0, 0, "0", "", "Sockets_Filled", GameAttributeEncoding.Int, 0, 0, 2, 2);

		// Token: 0x040068C1 RID: 26817
		public static readonly GameAttributeI Item_Binding_Level_Override = new GameAttributeI(362, 0, -1, 0, 0, "0", "", "Item_Binding_Level_Override", GameAttributeEncoding.Int, 0, 0, 4, 3);

		// Token: 0x040068C2 RID: 26818
		public static readonly GameAttributeI Item_Targeted_Player_Class = new GameAttributeI(363, -1, -1, 0, 0, "0", "", "Item_Targeted_Player_Class", GameAttributeEncoding.Int, 0, -1, 5, 3);

		// Token: 0x040068C3 RID: 26819
		public static readonly GameAttributeI Item_Targeted_Hireling_Class = new GameAttributeI(364, -1, -1, 0, 0, "0", "", "Item_Targeted_Hireling_Class", GameAttributeEncoding.Int, 0, -1, 3, 3);

		// Token: 0x040068C4 RID: 26820
		public static readonly GameAttributeB Paragon_Node_Is_Purchased = new GameAttributeB(400, 0, -1, 0, 0, "", "", "Paragon_Node_Is_Purchased", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068C5 RID: 26821
		public static readonly GameAttributeB Paragon_Glyph_Affix_Active = new GameAttributeB(401, 0, -1, 0, 0, "", "", "Paragon_Glyph_Affix_Active", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068C6 RID: 26822
		public static readonly GameAttributeI Run_Speed_Duration = new GameAttributeI(405, 0, -1, 0, 0, "", "", "Run_Speed_Duration", GameAttributeEncoding.Int, 0, 0, 16777215, 24);

		// Token: 0x040068C7 RID: 26823
		public static readonly GameAttributeB IsCrafted = new GameAttributeB(407, 0, -1, 0, 0, "0", "", "IsCrafted", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068C8 RID: 26824
		public static readonly GameAttributeB IsVendorBought = new GameAttributeB(408, 0, -1, 0, 0, "", "", "IsVendorBought", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068C9 RID: 26825
		public static readonly GameAttributeB IsTraded = new GameAttributeB(409, 0, -1, 0, 0, "", "", "IsTraded", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068CA RID: 26826
		public static readonly GameAttributeB IsEscrowed = new GameAttributeB(410, 0, -1, 0, 0, "", "", "IsEscrowed", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068CB RID: 26827
		public static readonly GameAttributeB ConsumableAddSockets = new GameAttributeB(412, 0, -1, 0, 0, "", "", "ConsumableAddSockets", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068CC RID: 26828
		public static readonly GameAttributeB Always_Plays_GetHit = new GameAttributeB(418, 0, -1, 0, 0, "", "", "Always_Plays_GetHit", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068CD RID: 26829
		public static readonly GameAttributeB Hidden = new GameAttributeB(419, 0, -1, 0, 0, "", "", "Hidden", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068CE RID: 26830
		public static readonly GameAttributeB Appearance_Hidden = new GameAttributeB(420, 0, -1, 0, 0, "", "", "Appearance Hidden", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068CF RID: 26831
		public static readonly GameAttributeB Hide_All_Attachments = new GameAttributeB(421, 0, -1, 0, 0, "", "", "Hide All Attachments", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068D0 RID: 26832
		public static readonly GameAttributeB Targeting_Outline_Hidden = new GameAttributeB(422, 0, -1, 0, 0, "", "", "Targeting Outline Hidden", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068D1 RID: 26833
		public static readonly GameAttributeB Alpha_Attachments = new GameAttributeB(424, 0, -1, 0, 0, "", "", "Alpha Attachments", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068D2 RID: 26834
		public static readonly GameAttributeB Is_AnimTree_Enabled = new GameAttributeB(425, 1, -1, 0, 0, "", "", "Is AnimTree Enabled", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068D3 RID: 26835
		public static readonly GameAttributeB Hide_Attachment_By_Tag = new GameAttributeB(427, 0, -1, 0, 0, "", "", "Hide_Attachment_By_Tag", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068D4 RID: 26836
		public static readonly GameAttributeB Hide_Cosmetic_Back_Attachment = new GameAttributeB(428, 0, -1, 0, 0, "", "", "Hide Cosmetic Back Attachment", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068D5 RID: 26837
		public static readonly GameAttributeB Removes_Body_On_Death = new GameAttributeB(430, 0, -1, 0, 0, "", "", "Removes_Body_On_Death", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068D6 RID: 26838
		public static readonly GameAttributeB Died_To_Resurrectable_Death = new GameAttributeB(431, 0, -1, 0, 0, "", "", "Died_To_Resurrectable_Death", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068D7 RID: 26839
		public static readonly GameAttributeB Can_Be_Resurrected = new GameAttributeB(432, 0, -1, 0, 0, "", "", "Can_Be_Resurrected", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068D8 RID: 26840
		public static readonly GameAttributeB UntargetableByPets = new GameAttributeB(433, 0, -1, 0, 0, "", "", "UntargetableByPets", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068D9 RID: 26841
		public static readonly GameAttributeI Damage_State_Current = new GameAttributeI(434, 0, -1, 0, 0, "", "", "Damage_State_Current", GameAttributeEncoding.Int, 0, 0, 15, 4);

		// Token: 0x040068DA RID: 26842
		public static readonly GameAttributeB Is_Player_Decoy = new GameAttributeB(435, 0, -1, 0, 0, "", "", "Is_Player_Decoy", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068DB RID: 26843
		public static readonly GameAttributeI Gizmo_State = new GameAttributeI(438, -1, -1, 0, 0, "", "", "Gizmo_State", GameAttributeEncoding.Int, 0, -1, 30, 5);

		// Token: 0x040068DC RID: 26844
		public static readonly GameAttributeI Gizmo_Charges = new GameAttributeI(439, 0, -1, 0, 0, "", "", "Gizmo_Charges", GameAttributeEncoding.Int, 0, -1, 30, 5);

		// Token: 0x040068DD RID: 26845
		public static readonly GameAttributeB Chest_Open = new GameAttributeB(440, 0, -1, 0, 0, "", "", "Chest_Open", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068DE RID: 26846
		public static readonly GameAttributeB Gizmo_Disabled_By_Script = new GameAttributeB(442, 0, -1, 0, 0, "", "", "Gizmo_Disabled_By_Script", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068DF RID: 26847
		public static readonly GameAttributeB Gizmo_Is_Quest_Restricted = new GameAttributeB(446, 0, -1, 0, 0, "", "", "Gizmo_Is_Quest_Restricted", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068E0 RID: 26848
		public static readonly GameAttributeB Gizmo_Visibility_Is_Quest_Restricted = new GameAttributeB(447, 0, -1, 0, 0, "", "", "Gizmo_Visibility_Is_Quest_Restricted", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068E1 RID: 26849
		public static readonly GameAttributeB DropsNoLoot = new GameAttributeB(453, 0, -1, 0, 0, "", "", "DropsNoLoot", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068E2 RID: 26850
		public static readonly GameAttributeB GrantsNoXP = new GameAttributeB(454, 0, -1, 0, 0, "", "", "GrantsNoXP", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068E3 RID: 26851
		public static readonly GameAttributeI Hireling_Class = new GameAttributeI(455, -1, -1, 0, 0, "", "", "Hireling_Class", GameAttributeEncoding.Int, 0, -1, 3, 3);

		// Token: 0x040068E4 RID: 26852
		public static readonly GameAttributeB Pet_Cannot_Be_Dismissed = new GameAttributeB(458, 0, -1, 0, 0, "", "", "Pet_Cannot_Be_Dismissed", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068E5 RID: 26853
		public static readonly GameAttributeB Is_Unmanaged_Quest_Follower = new GameAttributeB(460, 0, -1, 0, 0, "", "", "Is_Unmanaged_Quest_Follower", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068E6 RID: 26854
		public static readonly GameAttributeB Is_NPC = new GameAttributeB(480, 0, -1, 0, 0, "", "", "Is_NPC", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068E7 RID: 26855
		public static readonly GameAttributeB NPC_Is_Operatable = new GameAttributeB(481, 0, -1, 0, 0, "", "", "NPC_Is_Operatable", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068E8 RID: 26856
		public static readonly GameAttributeB NPC_Is_Escorting = new GameAttributeB(482, 0, -1, 0, 0, "", "", "NPC_Is_Escorting", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068E9 RID: 26857
		public static readonly GameAttributeB NPC_Has_Interact_Options = new GameAttributeB(483, 0, -1, 0, 0, "", "", "NPC_Has_Interact_Options", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068EA RID: 26858
		public static readonly GameAttributeI Conversation_Icon = new GameAttributeI(484, -1, -1, 0, 0, "", "", "Conversation_Icon", GameAttributeEncoding.Int, 0, -1, 15, 5);

		// Token: 0x040068EB RID: 26859
		public static readonly GameAttributeB Use_Summoner_Damage_Stats = new GameAttributeB(496, 0, -1, 0, 0, "", "", "Use_Summoner_Damage_Stats", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068EC RID: 26860
		public static readonly GameAttributeI Current_WeaponClass = new GameAttributeI(497, -1, -1, 0, 0, "", "", "Current_WeaponClass", GameAttributeEncoding.Int, 0, -1, 31, 6);

		// Token: 0x040068ED RID: 26861
		public static readonly GameAttributeB Follower_Sheath_Action = new GameAttributeB(498, 0, -1, 0, 0, "", "", "Follower_Sheath_Action", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068EE RID: 26862
		public static readonly GameAttributeI Weapons_Sheathed = new GameAttributeI(499, 0, -1, 0, 0, "", "", "Weapons_Sheathed", GameAttributeEncoding.Int, 0, 0, 2, 2);

		// Token: 0x040068EF RID: 26863
		public static readonly GameAttributeB Held_In_OffHand = new GameAttributeB(500, 0, -1, 0, 0, "0", "", "Held_In_OffHand", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068F0 RID: 26864
		public static readonly GameAttributeI Active_Weapon_Slot = new GameAttributeI(501, -1, -1, 0, 0, "", "", "Active_Weapon_Slot", GameAttributeEncoding.Int, 0, -1, 21, 5);

		// Token: 0x040068F1 RID: 26865
		public static readonly GameAttributeB In_Combat = new GameAttributeB(502, 0, -1, 0, 0, "", "", "In_Combat", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068F2 RID: 26866
		public static readonly GameAttributeB Scripted_In_Combat = new GameAttributeB(504, 0, -1, 0, 0, "", "", "Scripted_In_Combat", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068F3 RID: 26867
		public static readonly GameAttributeB Shapeshifting_Stay_In_Form = new GameAttributeB(506, 0, -1, 0, 0, "", "", "Shapeshifting_Stay_In_Form", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068F4 RID: 26868
		public static readonly GameAttributeB Shapeshifting_Queue_Back_To_Human = new GameAttributeB(507, 0, -1, 0, 0, "", "", "Shapeshifting_Queue_Back_To_Human", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068F5 RID: 26869
		public static readonly GameAttributeB Skill_Shapeshift_Form_Wolf_Override = new GameAttributeB(509, 0, -1, 0, 0, "", "", "Skill_Shapeshift_Form_Wolf_Override", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068F6 RID: 26870
		public static readonly GameAttributeB Skill_Shapeshift_Form_Bear_Override = new GameAttributeB(510, 0, -1, 0, 0, "", "", "Skill_Shapeshift_Form_Bear_Override", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068F7 RID: 26871
		public static readonly GameAttributeB Default_Shapeshift_Form_Wolf_Override = new GameAttributeB(511, 0, -1, 0, 0, "", "", "Default_Shapeshift_Form_Wolf_Override", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068F8 RID: 26872
		public static readonly GameAttributeB Default_Shapeshift_Form_Bear_Override = new GameAttributeB(512, 0, -1, 0, 0, "", "", "Default_Shapeshift_Form_Bear_Override", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068F9 RID: 26873
		public static readonly GameAttributeB In_Shadow_Realm = new GameAttributeB(513, 0, -1, 0, 0, "", "", "In_Shadow_Realm", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068FA RID: 26874
		public static readonly GameAttributeB Marked_By_Shadow_Realm = new GameAttributeB(514, 0, -1, 0, 0, "", "", "Marked_By_Shadow_Realm", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068FB RID: 26875
		public static readonly GameAttributeB Can_See_Weakpoints = new GameAttributeB(516, 0, -1, 0, 0, "", "", "Can_See_Weakpoints", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068FC RID: 26876
		public static readonly GameAttributeB In_Conversation = new GameAttributeB(517, 0, -1, 0, 0, "", "", "In_Conversation", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068FD RID: 26877
		public static readonly GameAttributeB Can_Use_Potion_While_Full_Health = new GameAttributeB(536, 0, -1, 0, 0, "", "", "Can_Use_Potion_While_Full_Health", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x040068FE RID: 26878
		public static readonly GameAttributeI Base_Element = new GameAttributeI(552, -1, -1, 0, 0, "", "", "Base_Element", GameAttributeEncoding.Int, 0, -1, 6, 3);

		// Token: 0x040068FF RID: 26879
		public static readonly GameAttributeB Enable_Base_Element_Damage_Type_Override = new GameAttributeB(553, 0, -1, 0, 0, "", "", "Enable_Base_Element_Damage_Type_Override", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006900 RID: 26880
		public static readonly GameAttributeB Projectile_Reflect_Has_Damage_Cap = new GameAttributeB(557, 0, -1, 0, 0, "", "", "Projectile_Reflect_Has_Damage_Cap", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006901 RID: 26881
		public static readonly GameAttributeB Projectile_Bouncing_Enabled = new GameAttributeB(559, 0, -1, 0, 0, "", "", "Projectile_Bouncing_Enabled", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006902 RID: 26882
		public static readonly GameAttributeB Buff_Visual_Effect = new GameAttributeB(562, 0, -1, 0, 0, "", "", "Buff_Visual_Effect", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006903 RID: 26883
		public static readonly GameAttributeB Could_Have_Ragdolled = new GameAttributeB(564, 0, -1, 0, 0, "", "", "Could_Have_Ragdolled", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006904 RID: 26884
		public static readonly GameAttributeB Scale_Bonus_Is_Immediate = new GameAttributeB(566, 0, -1, 0, 0, "", "", "Scale_Bonus_Is_Immediate", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006905 RID: 26885
		public static readonly GameAttributeB Deleted_On_Server = new GameAttributeB(568, 0, -1, 0, 0, "", "", "Deleted_On_Server", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006906 RID: 26886
		public static readonly GameAttributeB Pet_Fade_Out = new GameAttributeB(571, 0, -1, 0, 0, "", "", "Pet_Fade_Out", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006907 RID: 26887
		public static readonly GameAttributeB Does_No_Damage = new GameAttributeB(572, 0, -1, 0, 0, "", "", "Does_No_Damage", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006908 RID: 26888
		public static readonly GameAttributeB Blocks_Projectiles = new GameAttributeB(574, 0, -1, 0, 0, "", "", "Blocks_Projectiles", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006909 RID: 26889
		public static readonly GameAttributeB Blocks_Projectiles_With_Feedback = new GameAttributeB(575, 0, -1, 0, 0, "", "", "Blocks_Projectiles_With_Feedback", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400690A RID: 26890
		public static readonly GameAttributeB Uninterruptible = new GameAttributeB(578, 0, -1, 0, 0, "", "", "Uninterruptible", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400690B RID: 26891
		public static readonly GameAttributeB Queue_Death = new GameAttributeB(579, 0, -1, 0, 0, "", "", "Queue Death", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400690C RID: 26892
		public static readonly GameAttributeB CantStartDisplayedPowers = new GameAttributeB(582, 0, -1, 0, 0, "", "", "CantStartDisplayedPowers", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400690D RID: 26893
		public static readonly GameAttributeB PlayerSkillSuppressingDisplayedPowers = new GameAttributeB(583, 0, -1, 0, 0, "", "", "PlayerSkillSuppressingDisplayedPowers", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400690E RID: 26894
		public static readonly GameAttributeB Disable_Health_Prediction = new GameAttributeB(594, 0, -1, 0, 0, "", "", "Disable_Health_Prediction", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400690F RID: 26895
		public static readonly GameAttributeB Hide_Affixes = new GameAttributeB(598, 0, -1, 0, 0, "", "", "Hide_Affixes", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006910 RID: 26896
		public static readonly GameAttributeB Displays_Team_Effect = new GameAttributeB(599, 0, -1, 0, 0, "", "", "Displays_Team_Effect", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006911 RID: 26897
		public static readonly GameAttributeB Cannot_Be_Added_To_AI_Target_List = new GameAttributeB(600, 0, -1, 0, 0, "", "", "Cannot_Be_Added_To_AI_Target_List", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006912 RID: 26898
		public static readonly GameAttributeB In_Retreat_Volume = new GameAttributeB(602, 0, -1, 0, 0, "", "", "In_Retreat_Volume", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006913 RID: 26899
		public static readonly GameAttributeB Damage_Shield = new GameAttributeB(603, 0, -1, 0, 0, "", "", "Damage_Shield", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006914 RID: 26900
		public static readonly GameAttributeB Is_Berserk = new GameAttributeB(609, 0, -1, 0, 0, "", "", "Is_Berserk", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006915 RID: 26901
		public static readonly GameAttributeB Vulnerable = new GameAttributeB(610, 0, -1, 0, 0, "", "", "Vulnerable", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006916 RID: 26902
		public static readonly GameAttributeI Follow_Target_Type = new GameAttributeI(620, 0, -1, 0, 0, "", "", "Follow_Target_Type", GameAttributeEncoding.Int, 0, 0, 2, 2);

		// Token: 0x04006917 RID: 26903
		public static readonly GameAttributeB Stealthed = new GameAttributeB(625, 0, -1, 0, 0, "", "", "Stealthed", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006918 RID: 26904
		public static readonly GameAttributeI GemQuality = new GameAttributeI(626, 0, -1, 0, 0, "", "", "GemQuality", GameAttributeEncoding.Int, 0, 0, 32, 6);

		// Token: 0x04006919 RID: 26905
		public static readonly GameAttributeB Attachment_Handled_By_Client = new GameAttributeB(631, 0, -1, 0, 0, "", "", "Attachment_Handled_By_Client", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400691A RID: 26906
		public static readonly GameAttributeB AI_In_Special_State = new GameAttributeB(633, 0, -1, 0, 0, "", "", "AI_In_Special_State", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400691B RID: 26907
		public static readonly GameAttributeB AI_Used_Scripted_Spawn_Anim = new GameAttributeB(634, 0, -1, 0, 0, "", "", "AI_Used_Scripted_Spawn_Anim", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400691C RID: 26908
		public static readonly GameAttributeB AI_Spawned_By_Inactive_Marker = new GameAttributeB(635, 0, -1, 0, 0, "", "", "AI_Spawned_By_Inactive_Marker", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400691D RID: 26909
		public static readonly GameAttributeB AI_Disable_Wander = new GameAttributeB(636, 0, -1, 0, 0, "", "", "AI_Disable_Wander", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400691E RID: 26910
		public static readonly GameAttributeB Observer = new GameAttributeB(643, 0, -1, 0, 0, "", "", "Observer", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400691F RID: 26911
		public static readonly GameAttributeB Resurrect_As_Observer = new GameAttributeB(644, 0, -1, 0, 0, "", "", "Resurrect_As_Observer", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006920 RID: 26912
		public static readonly GameAttributeB Registered_To_Tracked_Checkpoints = new GameAttributeB(645, 0, -1, 0, 0, "", "", "Registered_To_Tracked_Checkpoints", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006921 RID: 26913
		public static readonly GameAttributeI Corpse_Resurrection_Charges = new GameAttributeI(649, 0, -1, 0, 0, "", "", "Corpse_Resurrection_Charges", GameAttributeEncoding.Int, 0, 0, 15, 4);

		// Token: 0x04006922 RID: 26914
		public static readonly GameAttributeB Busy = new GameAttributeB(650, 0, -1, 0, 0, "", "", "Busy", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006923 RID: 26915
		public static readonly GameAttributeB Afk = new GameAttributeB(651, 0, -1, 0, 0, "", "", "Afk", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006924 RID: 26916
		public static readonly GameAttributeB RTC_Playing = new GameAttributeB(652, 0, -1, 0, 0, "", "", "RTC Playing", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006925 RID: 26917
		public static readonly GameAttributeB Operatable = new GameAttributeB(655, 0, -1, 0, 0, "", "", "Operatable", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006926 RID: 26918
		public static readonly GameAttributeB Disabled = new GameAttributeB(657, 0, -1, 0, 0, "", "", "Disabled", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006927 RID: 26919
		public static readonly GameAttributeB Skill_Override_Active = new GameAttributeB(659, 0, -1, 0, 0, "", "", "Skill_Override_Active", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006928 RID: 26920
		public static readonly GameAttributeB Skill_Override_Active_Any = new GameAttributeB(660, 0, -1, 0, 0, "", "", "Skill_Override_Active_Any", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006929 RID: 26921
		public static readonly GameAttributeB Skill_Override_Ended = new GameAttributeB(661, 0, -1, 0, 0, "", "", "Skill_Override_Ended", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400692A RID: 26922
		public static readonly GameAttributeB Skill_Override_Ended_Active = new GameAttributeB(662, 0, -1, 0, 0, "", "", "Skill_Override_Ended_Active", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400692B RID: 26923
		public static readonly GameAttributeB Druid_Spirit_Bond_Unlocked = new GameAttributeB(672, 0, -1, 0, 0, "", "", "Druid_Spirit_Bond_Unlocked", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400692C RID: 26924
		public static readonly GameAttributeB Rogue_Combo_Points_Enabled = new GameAttributeB(674, 0, -1, 0, 0, "", "", "Rogue_Combo_Points_Enabled", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400692D RID: 26925
		public static readonly GameAttributeI Skill_Arsenal_Slot = new GameAttributeI(679, -1, -1, 0, 0, "", "", "Skill_Arsenal_Slot", GameAttributeEncoding.Int, 0, -1, 21, 5);

		// Token: 0x0400692E RID: 26926
		public static readonly GameAttributeB Is_Power_Proxy = new GameAttributeB(680, 0, -1, 0, 0, "", "", "Is_Power_Proxy", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400692F RID: 26927
		public static readonly GameAttributeB Power_Disabled = new GameAttributeB(684, 0, -1, 0, 0, "", "", "Power_Disabled", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006930 RID: 26928
		public static readonly GameAttributeB Power_Manual_Activation_Disabled = new GameAttributeB(685, 0, -1, 0, 0, "", "", "Power_Manual_Activation_Disabled", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006931 RID: 26929
		public static readonly GameAttributeB Power_Saved_Attribute = new GameAttributeB(689, 0, -1, 0, 0, "", "", "Power_Saved_Attribute", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006932 RID: 26930
		public static readonly GameAttributeB Looping_Animation_Suppress_Item_Tooltips = new GameAttributeB(690, 0, -1, 0, 0, "", "", "Looping_Animation_Suppress_Item_Tooltips", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006933 RID: 26931
		public static readonly GameAttributeB No_Health_Drop = new GameAttributeB(699, 0, -1, 0, 0, "", "", "No_Health_Drop", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006934 RID: 26932
		public static readonly GameAttributeB Leader = new GameAttributeB(700, 0, -1, 0, 0, "", "", "Leader", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006935 RID: 26933
		public static readonly GameAttributeB IsContentRestrictedActor = new GameAttributeB(701, 0, -1, 0, 0, "", "", "IsContentRestrictedActor", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006936 RID: 26934
		public static readonly GameAttributeB God = new GameAttributeB(702, 0, -1, 0, 0, "", "", "God", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006937 RID: 26935
		public static readonly GameAttributeB EasyKill = new GameAttributeB(703, 0, -1, 0, 0, "", "", "EasyKill", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006938 RID: 26936
		public static readonly GameAttributeB EasyDie = new GameAttributeB(704, 0, -1, 0, 0, "", "", "EasyDie", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006939 RID: 26937
		public static readonly GameAttributeB NeverDie = new GameAttributeB(705, 0, -1, 0, 0, "", "", "NeverDie", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400693A RID: 26938
		public static readonly GameAttributeB IAmDeath = new GameAttributeB(707, 0, -1, 0, 0, "", "", "IAmDeath", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400693B RID: 26939
		public static readonly GameAttributeB FreeCastCheat = new GameAttributeB(708, 0, -1, 0, 0, "", "", "FreeCastCheat", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400693C RID: 26940
		public static readonly GameAttributeB FreeCastCDCheat = new GameAttributeB(709, 0, -1, 0, 0, "", "", "FreeCastCDCheat", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400693D RID: 26941
		public static readonly GameAttributeB CDCheat = new GameAttributeB(710, 0, -1, 0, 0, "", "", "CDCheat", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400693E RID: 26942
		public static readonly GameAttributeB NoDamageRange = new GameAttributeB(711, 0, -1, 0, 0, "", "", "NoDamageRange", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400693F RID: 26943
		public static readonly GameAttributeB FreeCrafting = new GameAttributeB(712, 0, -1, 0, 0, "", "", "FreeCrafting", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006940 RID: 26944
		public static readonly GameAttributeB CraftingCritCheat = new GameAttributeB(713, 0, -1, 0, 0, "", "", "CraftingCritCheat", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006941 RID: 26945
		public static readonly GameAttributeB SkillReqsDisabled = new GameAttributeB(714, 0, -1, 0, 0, "", "", "SkillReqsDisabled", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006942 RID: 26946
		public static readonly GameAttributeB SkillSlotReqsDisabled = new GameAttributeB(715, 0, -1, 0, 0, "", "", "SkillSlotReqsDisabled", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006943 RID: 26947
		public static readonly GameAttributeB DrawPathfinds = new GameAttributeB(716, 0, -1, 0, 0, "", "", "DrawPathfinds", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006944 RID: 26948
		public static readonly GameAttributeB DisablePotionDrops = new GameAttributeB(717, 0, -1, 0, 0, "", "", "DisablePotionDrops", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006945 RID: 26949
		public static readonly GameAttributeB EnableWorldTierItemRestrictions = new GameAttributeB(718, 0, -1, 0, 0, "", "", "EnableWorldTierItemRestrictions", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006946 RID: 26950
		public static readonly GameAttributeB MinimapActive = new GameAttributeB(719, 0, -1, 0, 0, "", "", "MinimapActive", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006947 RID: 26951
		public static readonly GameAttributeB Weapons_Hidden = new GameAttributeB(722, 0, -1, 0, 0, "", "", "Weapons_Hidden", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006948 RID: 26952
		public static readonly GameAttributeB Main_Hand_Weapon_Hidden = new GameAttributeB(723, 0, -1, 0, 0, "", "", "Main_Hand_Weapon_Hidden", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006949 RID: 26953
		public static readonly GameAttributeB Off_Hand_Weapon_Hidden = new GameAttributeB(724, 0, -1, 0, 0, "", "", "Off_Hand_Weapon_Hidden", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400694A RID: 26954
		public static readonly GameAttributeB Actor_Updates_Attributes_From_Owner = new GameAttributeB(725, 0, -1, 0, 0, "", "", "Actor_Updates_Attributes_From_Owner", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400694B RID: 26955
		public static readonly GameAttributeB CannotDieDuring = new GameAttributeB(804, 0, -1, 0, 0, "", "", "CannotDieDuring", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400694C RID: 26956
		public static readonly GameAttributeI Power_Damage_Type_Override = new GameAttributeI(821, -1, -1, 0, 0, "", "", "Power_Damage_Type_Override", GameAttributeEncoding.Int, 0, -1, 6, 3);

		// Token: 0x0400694D RID: 26957
		public static readonly GameAttributeB Waiting_To_Accept_Resurrection = new GameAttributeB(823, 0, -1, 0, 0, "", "", "Waiting_To_Accept_Resurrection", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400694E RID: 26958
		public static readonly GameAttributeB Ghosted = new GameAttributeB(824, 0, -1, 0, 0, "", "", "Ghosted", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400694F RID: 26959
		public static readonly GameAttributeB Never_Deactivates = new GameAttributeB(827, 0, -1, 0, 0, "", "", "Never_Deactivates", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006950 RID: 26960
		public static readonly GameAttributeB Projectile_Uncapped_Lifetime = new GameAttributeB(829, 0, -1, 0, 0, "", "", "Projectile_Uncapped_Lifetime", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006951 RID: 26961
		public static readonly GameAttributeB Elite_Engaged = new GameAttributeB(831, 0, -1, 0, 0, "", "", "Elite_Engaged", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006952 RID: 26962
		public static readonly GameAttributeB Has_Dropped_Special_loot = new GameAttributeB(834, 0, -1, 0, 0, "", "", "Has_Dropped_Special_loot", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006953 RID: 26963
		public static readonly GameAttributeB Scroll_Buff = new GameAttributeB(835, 0, -1, 0, 0, "", "", "Scroll_Buff", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006954 RID: 26964
		public static readonly GameAttributeB Item_Is_BOE = new GameAttributeB(839, 0, -1, 0, 0, "", "", "Item_Is_BOE", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006955 RID: 26965
		public static readonly GameAttributeB AlwaysShowFloatingNumbers = new GameAttributeB(851, 0, -1, 0, 0, "", "", "AlwaysShowFloatingNumbers", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006956 RID: 26966
		public static readonly GameAttributeB Supress_Thorns_Effect = new GameAttributeB(852, 0, -1, 0, 0, "", "", "Supress_Thorns_Effect", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006957 RID: 26967
		public static readonly GameAttributeB Item_Equipped_But_Disabled = new GameAttributeB(860, 0, -1, 0, 0, "", "", "Item_Equipped_But_Disabled", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006958 RID: 26968
		public static readonly GameAttributeB Item_Legendary_Affix_Disabled = new GameAttributeB(861, 0, -1, 0, 0, "", "", "Item_Legendary_Affix_Disabled", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006959 RID: 26969
		public static readonly GameAttributeB Attribute_Projectile_Pass_Through = new GameAttributeB(862, 0, -1, 0, 0, "", "", "Attribute_Projectile_Pass_Through", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400695A RID: 26970
		public static readonly GameAttributeI Set_Item_Discount = new GameAttributeI(863, 0, -1, 0, 0, "", "", "Set_Item_Discount", GameAttributeEncoding.Int, 0, 0, 255, 8);

		// Token: 0x0400695B RID: 26971
		public static readonly GameAttributeB Dont_Update_Camera_While_Attached = new GameAttributeB(864, 0, -1, 0, 0, "", "", "Dont_Update_Camera_While_Attached", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400695C RID: 26972
		public static readonly GameAttributeB Prevent_Evade_During = new GameAttributeB(876, 0, -1, 0, 0, "", "", "Prevent_Evade_During", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400695D RID: 26973
		public static readonly GameAttributeB Resurrected = new GameAttributeB(880, 0, -1, 0, 0, "", "", "Resurrected", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400695E RID: 26974
		public static readonly GameAttributeB Movement_Destroys_Waller_Walls = new GameAttributeB(882, 0, -1, 0, 0, "", "", "Movement_Destroys_Waller_Walls", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400695F RID: 26975
		public static readonly GameAttributeB Mail_Flag_Icon = new GameAttributeB(883, 0, -1, 0, 0, "", "", "Mail_Flag_Icon", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006960 RID: 26976
		public static readonly GameAttributeB Forced_Move = new GameAttributeB(884, 0, -1, 0, 0, "", "", "Forced Move", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006961 RID: 26977
		public static readonly GameAttributeB Opened_180 = new GameAttributeB(889, 0, -1, 0, 0, "", "", "Opened_180", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006962 RID: 26978
		public static readonly GameAttributeB Disable_Proximity_Checks = new GameAttributeB(890, 0, -1, 0, 0, "", "", "Disable_Proximity_Checks", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006963 RID: 26979
		public static readonly GameAttributeB Mounted = new GameAttributeB(891, 0, -1, 0, 0, "", "", "Mounted", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006964 RID: 26980
		public static readonly GameAttributeB Retreating = new GameAttributeB(910, 0, -1, 0, 0, "", "", "Retreating", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006965 RID: 26981
		public static readonly GameAttributeB Retreat_Soft_Disable = new GameAttributeB(912, 0, -1, 0, 0, "", "", "Retreat Soft Disable", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006966 RID: 26982
		public static readonly GameAttributeB Unstoppable = new GameAttributeB(939, 0, -1, 0, 0, "", "", "Unstoppable", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006967 RID: 26983
		public static readonly GameAttributeB Cannot_Be_Staggered = new GameAttributeB(946, 0, -1, 0, 0, "", "", "Cannot_Be_Staggered", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006968 RID: 26984
		public static readonly GameAttributeB Staggered = new GameAttributeB(947, 0, -1, 0, 0, "", "", "Staggered", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006969 RID: 26985
		public static readonly GameAttributeI Talent_Rank = new GameAttributeI(954, 0, -1, 0, 0, "", "", "Talent_Rank", GameAttributeEncoding.Int, 0, 0, 4095, 12);

		// Token: 0x0400696A RID: 26986
		public static readonly GameAttributeI Talent_Rank_Bonus = new GameAttributeI(955, 0, -1, 0, 0, "", "", "Talent_Rank_Bonus", GameAttributeEncoding.Int, 0, 0, 4095, 12);

		// Token: 0x0400696B RID: 26987
		public static readonly GameAttributeI Talent_Rank_Total = new GameAttributeI(956, 0, -1, 0, 0, "Talent_Rank + Talent_Rank_Bonus", "", "Talent_Rank_Total", GameAttributeEncoding.Int, 0, 0, 4095, 12);

		// Token: 0x0400696C RID: 26988
		public static readonly GameAttributeI Skill_Rank_Bonus = new GameAttributeI(957, 0, -1, 0, 0, "", "", "Skill_Rank_Bonus", GameAttributeEncoding.Int, 0, 0, 4095, 12);

		// Token: 0x0400696D RID: 26989
		public static readonly GameAttributeI Skill_Rank_Skill_Tag_Bonus = new GameAttributeI(958, 0, -1, 0, 0, "", "", "Skill_Rank_Skill_Tag_Bonus", GameAttributeEncoding.Int, 0, 0, 4095, 12);

		// Token: 0x0400696E RID: 26990
		public static readonly GameAttributeI Skill_Rank_All_Bonus = new GameAttributeI(959, 0, -1, 0, 0, "", "", "Skill_Rank_All_Bonus", GameAttributeEncoding.Int, 0, 0, 4095, 12);

		// Token: 0x0400696F RID: 26991
		public static readonly GameAttributeI Skill_Rank_Bonus_Temporary = new GameAttributeI(960, 0, -1, 0, 0, "", "", "Skill_Rank_Bonus_Temporary", GameAttributeEncoding.Int, 0, 0, 4095, 12);

		// Token: 0x04006970 RID: 26992
		public static readonly GameAttributeI Skill_Rank_Skill_Tag_Bonus_Temporary = new GameAttributeI(961, 0, -1, 0, 0, "", "", "Skill_Rank_Skill_Tag_Bonus_Temporary", GameAttributeEncoding.Int, 0, 0, 4095, 12);

		// Token: 0x04006971 RID: 26993
		public static readonly GameAttributeI Skill_Rank_All_Bonus_Temporary = new GameAttributeI(962, 0, -1, 0, 0, "", "", "Skill_Rank_All_Bonus_Temporary", GameAttributeEncoding.Int, 0, 0, 4095, 12);

		// Token: 0x04006972 RID: 26994
		public static readonly GameAttributeI Skill_Rank_Grant = new GameAttributeI(963, 0, -1, 0, 0, "", "", "Skill_Rank_Grant", GameAttributeEncoding.Int, 0, 0, 4095, 12);

		// Token: 0x04006973 RID: 26995
		public static readonly GameAttributeI Skill_Rank_Skill_TagGrant = new GameAttributeI(964, 0, -1, 0, 0, "", "", "Skill_Rank_Skill_TagGrant", GameAttributeEncoding.Int, 0, 0, 4095, 12);

		// Token: 0x04006974 RID: 26996
		public static readonly GameAttributeI Skill_Rank_All_Grant = new GameAttributeI(965, 0, -1, 0, 0, "", "", "Skill_Rank_All_Grant", GameAttributeEncoding.Int, 0, 0, 4095, 12);

		// Token: 0x04006975 RID: 26997
		public static readonly GameAttributeI Cheat_Skill_Rank_All = new GameAttributeI(966, 0, -1, 0, 0, "", "", "Cheat_Skill_Rank_All", GameAttributeEncoding.Int, 0, 0, 4095, 12);

		// Token: 0x04006976 RID: 26998
		public static readonly GameAttributeB Legendary_Affix_Equipped = new GameAttributeB(979, 0, -1, 0, 0, "", "", "Legendary_Affix_Equipped", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006977 RID: 26999
		public static readonly GameAttributeB Resurrection_at_Headstone_Allowed = new GameAttributeB(987, 0, -1, 0, 0, "", "", "Resurrection_at_Headstone_Allowed", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006978 RID: 27000
		public static readonly GameAttributeI Players_Contributing_To_Resurrection = new GameAttributeI(988, 0, -1, 0, 0, "", "", "Players_Contributing_To_Resurrection", GameAttributeEncoding.Int, 0, 0, 255, 8);

		// Token: 0x04006979 RID: 27001
		public static readonly GameAttributeB Slowkill = new GameAttributeB(999, 0, -1, 0, 0, "", "", "Slowkill", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400697A RID: 27002
		public static readonly GameAttributeB XPDisable = new GameAttributeB(1000, 0, -1, 0, 0, "", "", "XPDisable", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400697B RID: 27003
		public static readonly GameAttributeB InstantRez = new GameAttributeB(1001, 0, -1, 0, 0, "", "", "InstantRez", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400697C RID: 27004
		public static readonly GameAttributeI Force_Crit = new GameAttributeI(1002, -1, -1, 0, 0, "", "", "Force_Crit", GameAttributeEncoding.Int, 0, -1, 1, 2);

		// Token: 0x0400697D RID: 27005
		public static readonly GameAttributeI Force_Overpower = new GameAttributeI(1003, -1, -1, 0, 0, "", "", "Force_Overpower", GameAttributeEncoding.Int, 0, -1, 1, 2);

		// Token: 0x0400697E RID: 27006
		public static readonly GameAttributeI Force_Hit_Effect = new GameAttributeI(1004, -1, -1, 0, 0, "", "", "Force_Hit_Effect", GameAttributeEncoding.Int, 0, -1, 1, 2);

		// Token: 0x0400697F RID: 27007
		public static readonly GameAttributeB Knockback = new GameAttributeB(1005, 0, -1, 0, 0, "", "", "Knockback", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006980 RID: 27008
		public static readonly GameAttributeB IgnoreAttackAndDefense = new GameAttributeB(1006, 0, -1, 0, 0, "", "", "IgnoreAttackAndDefense", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006981 RID: 27009
		public static readonly GameAttributeB AlwaysPlayGetHit = new GameAttributeB(1007, 0, -1, 0, 0, "", "", "AlwaysPlayGetHit", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006982 RID: 27010
		public static readonly GameAttributeB Phasing_Disabled = new GameAttributeB(1008, 0, -1, 0, 0, "", "", "Phasing Disabled", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006983 RID: 27011
		public static readonly GameAttributeB Health_Percent_Callback_Count = new GameAttributeB(1021, 0, -1, 0, 0, "", "", "Health_Percent_Callback_Count", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006984 RID: 27012
		public static readonly GameAttributeB Player_Is_AI_Controlled = new GameAttributeB(1023, 0, -1, 0, 0, "", "", "Player_Is_AI_Controlled", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006985 RID: 27013
		public static readonly GameAttributeB Player_Is_Trading = new GameAttributeB(1024, 0, -1, 0, 0, "", "", "Player_Is_Trading", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006986 RID: 27014
		public static readonly GameAttributeB Player_Is_Party_Invitable = new GameAttributeB(1025, 1, -1, 0, 0, "", "", "Player_Is_Party_Invitable", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006987 RID: 27015
		public static readonly GameAttributeB Imbued_Affix_From_Definition = new GameAttributeB(1038, 0, -1, 0, 0, "", "", "Imbued_Affix_From_Definition", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006988 RID: 27016
		public static readonly GameAttributeB Carryable_Is_Picked_Up = new GameAttributeB(1041, 0, -1, 0, 0, "", "", "Carryable_Is_Picked_Up", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006989 RID: 27017
		public static readonly GameAttributeB Chargeable_Paused = new GameAttributeB(1044, 0, -1, 0, 0, "", "", "Chargeable_Paused", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400698A RID: 27018
		public static readonly GameAttributeB Use_Alternate_Name = new GameAttributeB(1046, 0, -1, 0, 0, "", "", "Use_Alternate_Name", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400698B RID: 27019
		public static readonly GameAttributeB Use_Boss_Camera = new GameAttributeB(1048, 0, -1, 0, 0, "", "", "Use_Boss_Camera", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400698C RID: 27020
		public static readonly GameAttributeB Boss_Camera_Follows_Player = new GameAttributeB(1049, 0, -1, 0, 0, "", "", "Boss_Camera_Follows_Player", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400698D RID: 27021
		public static readonly GameAttributeB Invisible_To_Spawning = new GameAttributeB(1051, 0, -1, 0, 0, "", "", "Invisible_To_Spawning", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400698E RID: 27022
		public static readonly GameAttributeB Is_AutoCast_Effect = new GameAttributeB(1052, 0, -1, 0, 0, "", "", "Is_AutoCast_Effect", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x0400698F RID: 27023
		public static readonly GameAttributeB Is_Last_Shot_Effect = new GameAttributeB(1053, 0, -1, 0, 0, "", "", "Is_Last_Shot_Effect", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006990 RID: 27024
		public static readonly GameAttributeB Item_Visible_To_Class_Bit = new GameAttributeB(1061, 0, -1, 0, 0, "", "", "Item Visible To Class Bit", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006991 RID: 27025
		public static readonly GameAttributeB Gizmo_Triggered_Bounty_Target_Disabled = new GameAttributeB(1068, 0, -1, 0, 0, "", "", "Gizmo_Triggered_Bounty_Target_Disabled", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006992 RID: 27026
		public static readonly GameAttributeB Gizmo_Starts_Side_Quest = new GameAttributeB(1070, 0, -1, 0, 0, "", "", "Gizmo_Starts_Side_Quest", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006993 RID: 27027
		public static readonly GameAttributeB Ignored_By_Quest_Objectives = new GameAttributeB(1076, 0, -1, 0, 0, "", "", "Ignored_By_Quest_Objectives", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);

		// Token: 0x04006994 RID: 27028
		public static readonly GameAttributeB Player_Has_Reward_Choice_Available = new GameAttributeB(1078, 0, -1, 0, 0, "", "", "Player_Has_Reward_Choice_Available", GameAttributeEncoding.IntMinMax, 0, 0, 1, 1);
	}
}
