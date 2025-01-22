﻿using System;

namespace D2Data
{
	// Token: 0x0200091F RID: 2335
	public class BaseState
	{
		// Token: 0x0600B944 RID: 47428 RVA: 0x00346F8C File Offset: 0x0034518C
		public BaseState(string Name, string State, int Id, int Group, int RemHit, int NoSend, int Transform, int Aura, int Curable, int Curse, int Active, int Immed, int Restrict, int Disguise, int Blue, int AttBlue, int DamBlue, int ArmBlue, int RfBlue, int RlBlue, int RcBlue, int StambarBlue, int RpBlue, int AttRed, int DamRed, int ArmRed, int RfRed, int RlRed, int RcRed, int RpRed, int Exp, int PlayerStayDeath, int MonsterStayDeath, int BossStayDeath, int Hide, int Shatter, int UDead, int Life, int Green, int Pgsv, int NoOverlays, int NoClear, int BossInv, int MeleeOnly, int NotOnDead, string Overlay1, string Overlay2, string Overlay3, string Overlay4, string PgsvOverlay, string CastOverlay, string RemOverlay, string Stat, int SetFunc, int RemFunc, string Missile, string Skill, string ItemType, string ItemTrans, int ColorPri, int ColorShift, int LightR, int LightG, int LightB, string OnSound, string OffSound, int GfxType, int GfxClass, string CltEvent, int CltEventFunc, int CltActiveFunc, int SrvActiveFunc)
		{
			this.Name = Name;
			this.Id = (StateType)Id;
			this.TableIndex = Id;
			this.Index = Id;
			this.State = State;
			this.Group = Group;
			this.RemHit = RemHit;
			this.NoSend = NoSend;
			this.Transform = Transform;
			this.Aura = Aura;
			this.Curable = Curable;
			this.Curse = Curse;
			this.Active = Active;
			this.Immed = Immed;
			this.Restrict = Restrict;
			this.Disguise = Disguise;
			this.Blue = Blue;
			this.AttBlue = AttBlue;
			this.DamBlue = DamBlue;
			this.ArmBlue = ArmBlue;
			this.RfBlue = RfBlue;
			this.RlBlue = RlBlue;
			this.RcBlue = RcBlue;
			this.StambarBlue = StambarBlue;
			this.RpBlue = RpBlue;
			this.AttRed = AttRed;
			this.DamRed = DamRed;
			this.ArmRed = ArmRed;
			this.RfRed = RfRed;
			this.RlRed = RlRed;
			this.RcRed = RcRed;
			this.RpRed = RpRed;
			this.Exp = Exp;
			this.PlayerStayDeath = PlayerStayDeath;
			this.MonsterStayDeath = MonsterStayDeath;
			this.BossStayDeath = BossStayDeath;
			this.Hide = Hide;
			this.Shatter = Shatter;
			this.UDead = UDead;
			this.Life = Life;
			this.Green = Green;
			this.Pgsv = Pgsv;
			this.NoOverlays = NoOverlays;
			this.NoClear = NoClear;
			this.BossInv = BossInv;
			this.MeleeOnly = MeleeOnly;
			this.NotOnDead = NotOnDead;
			this.Overlay1 = Overlay1;
			this.Overlay2 = Overlay2;
			this.Overlay3 = Overlay3;
			this.Overlay4 = Overlay4;
			this.PgsvOverlay = PgsvOverlay;
			this.CastOverlay = CastOverlay;
			this.RemOverlay = RemOverlay;
			this.Stat = Stat;
			this.SetFunc = SetFunc;
			this.RemFunc = RemFunc;
			this.Missile = Missile;
			this.Skill = Skill;
			this.ItemType = ItemType;
			this.ItemTrans = ItemTrans;
			this.ColorPri = ColorPri;
			this.ColorShift = ColorShift;
			this.LightR = LightR;
			this.LightG = LightG;
			this.LightB = LightB;
			this.OnSound = OnSound;
			this.OffSound = OffSound;
			this.GfxType = GfxType;
			this.GfxClass = GfxClass;
			this.CltEvent = CltEvent;
			this.CltEventFunc = CltEventFunc;
			this.CltActiveFunc = CltActiveFunc;
			this.SrvActiveFunc = SrvActiveFunc;
		}

		// Token: 0x0600B945 RID: 47429 RVA: 0x003471EC File Offset: 0x003453EC
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x0600B946 RID: 47430 RVA: 0x00347204 File Offset: 0x00345404
		public static BaseState Get(int index)
		{
			bool flag = index < 0 || BaseState.ItemCount < index;
			if (flag)
			{
				throw new ArgumentOutOfRangeException();
			}
			return BaseState.items[index];
		}

		// Token: 0x0600B947 RID: 47431 RVA: 0x00347238 File Offset: 0x00345438
		public static BaseState Get(StateType type)
		{
			bool flag = type < StateType.None || BaseState.ItemCount < (int)type;
			if (flag)
			{
				throw new ArgumentOutOfRangeException();
			}
			return BaseState.items[(int)type];
		}

		// Token: 0x0600B948 RID: 47432 RVA: 0x0034726C File Offset: 0x0034546C
		public static BaseState GetByState(string state)
		{
			state = state.ToLower();
			for (int i = 0; i < BaseState.ItemCount; i++)
			{
				bool flag = BaseState.items[i].State == state;
				if (flag)
				{
					return BaseState.items[i];
				}
			}
			throw new ArgumentException(string.Format("No BaseState with state code {0} found !", state));
		}

		// Token: 0x04006DE2 RID: 28130
		public readonly string Name;

		// Token: 0x04006DE3 RID: 28131
		public readonly StateType Id;

		// Token: 0x04006DE4 RID: 28132
		public readonly int TableIndex;

		// Token: 0x04006DE5 RID: 28133
		public readonly string State;

		// Token: 0x04006DE6 RID: 28134
		public readonly int Index;

		// Token: 0x04006DE7 RID: 28135
		public readonly int Group;

		// Token: 0x04006DE8 RID: 28136
		public readonly int RemHit;

		// Token: 0x04006DE9 RID: 28137
		public readonly int NoSend;

		// Token: 0x04006DEA RID: 28138
		public readonly int Transform;

		// Token: 0x04006DEB RID: 28139
		public readonly int Aura;

		// Token: 0x04006DEC RID: 28140
		public readonly int Curable;

		// Token: 0x04006DED RID: 28141
		public readonly int Curse;

		// Token: 0x04006DEE RID: 28142
		public readonly int Active;

		// Token: 0x04006DEF RID: 28143
		public readonly int Immed;

		// Token: 0x04006DF0 RID: 28144
		public readonly int Restrict;

		// Token: 0x04006DF1 RID: 28145
		public readonly int Disguise;

		// Token: 0x04006DF2 RID: 28146
		public readonly int Blue;

		// Token: 0x04006DF3 RID: 28147
		public readonly int AttBlue;

		// Token: 0x04006DF4 RID: 28148
		public readonly int DamBlue;

		// Token: 0x04006DF5 RID: 28149
		public readonly int ArmBlue;

		// Token: 0x04006DF6 RID: 28150
		public readonly int RfBlue;

		// Token: 0x04006DF7 RID: 28151
		public readonly int RlBlue;

		// Token: 0x04006DF8 RID: 28152
		public readonly int RcBlue;

		// Token: 0x04006DF9 RID: 28153
		public readonly int StambarBlue;

		// Token: 0x04006DFA RID: 28154
		public readonly int RpBlue;

		// Token: 0x04006DFB RID: 28155
		public readonly int AttRed;

		// Token: 0x04006DFC RID: 28156
		public readonly int DamRed;

		// Token: 0x04006DFD RID: 28157
		public readonly int ArmRed;

		// Token: 0x04006DFE RID: 28158
		public readonly int RfRed;

		// Token: 0x04006DFF RID: 28159
		public readonly int RlRed;

		// Token: 0x04006E00 RID: 28160
		public readonly int RcRed;

		// Token: 0x04006E01 RID: 28161
		public readonly int RpRed;

		// Token: 0x04006E02 RID: 28162
		public readonly int Exp;

		// Token: 0x04006E03 RID: 28163
		public readonly int PlayerStayDeath;

		// Token: 0x04006E04 RID: 28164
		public readonly int MonsterStayDeath;

		// Token: 0x04006E05 RID: 28165
		public readonly int BossStayDeath;

		// Token: 0x04006E06 RID: 28166
		public readonly int Hide;

		// Token: 0x04006E07 RID: 28167
		public readonly int Shatter;

		// Token: 0x04006E08 RID: 28168
		public readonly int UDead;

		// Token: 0x04006E09 RID: 28169
		public readonly int Life;

		// Token: 0x04006E0A RID: 28170
		public readonly int Green;

		// Token: 0x04006E0B RID: 28171
		public readonly int Pgsv;

		// Token: 0x04006E0C RID: 28172
		public readonly int NoOverlays;

		// Token: 0x04006E0D RID: 28173
		public readonly int NoClear;

		// Token: 0x04006E0E RID: 28174
		public readonly int BossInv;

		// Token: 0x04006E0F RID: 28175
		public readonly int MeleeOnly;

		// Token: 0x04006E10 RID: 28176
		public readonly int NotOnDead;

		// Token: 0x04006E11 RID: 28177
		public readonly string Overlay1;

		// Token: 0x04006E12 RID: 28178
		public readonly string Overlay2;

		// Token: 0x04006E13 RID: 28179
		public readonly string Overlay3;

		// Token: 0x04006E14 RID: 28180
		public readonly string Overlay4;

		// Token: 0x04006E15 RID: 28181
		public readonly string PgsvOverlay;

		// Token: 0x04006E16 RID: 28182
		public readonly string CastOverlay;

		// Token: 0x04006E17 RID: 28183
		public readonly string RemOverlay;

		// Token: 0x04006E18 RID: 28184
		public readonly string Stat;

		// Token: 0x04006E19 RID: 28185
		public readonly int SetFunc;

		// Token: 0x04006E1A RID: 28186
		public readonly int RemFunc;

		// Token: 0x04006E1B RID: 28187
		public readonly string Missile;

		// Token: 0x04006E1C RID: 28188
		public readonly string Skill;

		// Token: 0x04006E1D RID: 28189
		public readonly string ItemType;

		// Token: 0x04006E1E RID: 28190
		public readonly string ItemTrans;

		// Token: 0x04006E1F RID: 28191
		public readonly int ColorPri;

		// Token: 0x04006E20 RID: 28192
		public readonly int ColorShift;

		// Token: 0x04006E21 RID: 28193
		public readonly int LightR;

		// Token: 0x04006E22 RID: 28194
		public readonly int LightG;

		// Token: 0x04006E23 RID: 28195
		public readonly int LightB;

		// Token: 0x04006E24 RID: 28196
		public readonly string OnSound;

		// Token: 0x04006E25 RID: 28197
		public readonly string OffSound;

		// Token: 0x04006E26 RID: 28198
		public readonly int GfxType;

		// Token: 0x04006E27 RID: 28199
		public readonly int GfxClass;

		// Token: 0x04006E28 RID: 28200
		public readonly string CltEvent;

		// Token: 0x04006E29 RID: 28201
		public readonly int CltEventFunc;

		// Token: 0x04006E2A RID: 28202
		public readonly int CltActiveFunc;

		// Token: 0x04006E2B RID: 28203
		public readonly int SrvActiveFunc;

		// Token: 0x04006E2C RID: 28204
		protected static BaseState[] items = new BaseState[]
		{
			new BaseState("None", "none", 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Freeze", "freeze", 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, 1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", 100, 108, 150, 215, 255, "impact_bluemotize_1", "", -1, -1, "", -1, -1, -1),
			new BaseState("Poison", "poison", 2, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "poisonhit", "", "", -1, -1, "", "", "", "", 95, 104, 128, 255, 128, "impact_poison_1", "", -1, -1, "", -1, -1, -1),
			new BaseState("Resist Fire", "resistfire", 3, -1, -1, -1, -1, 1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "aura_resistfire", "", "", "", "", "cast_resistfire", "", "fireresist", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "paladin_aura_resistfire", "", -1, -1, "", -1, -1, -1),
			new BaseState("Resist Cold", "resistcold", 4, -1, -1, -1, -1, 1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "aura_resistcold", "", "", "", "", "cast_resistcold", "", "coldresist", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "paladin_aura_resistcold", "", -1, -1, "", -1, -1, -1),
			new BaseState("Resist Light", "resistlight", 5, -1, -1, -1, -1, 1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "aura_resistlight", "", "", "", "", "cast_resistlight", "", "lightresist", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "paladin_aura_resistlightning", "", -1, -1, "", -1, -1, -1),
			new BaseState("Resist Magic", "resistmagic", 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Player Body", "playerbody", 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Resist All", "resistall", 8, -1, -1, -1, -1, 1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "aura_resistall_front", "aura_resistall_back", "", "", "", "cast_resistall", "", "lightresist", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "paladin_aura_salvation", "", -1, -1, "", -1, -1, -1),
			new BaseState("Amplify Damage", "amplifydamage", 9, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "curseamplifydamage", "", "", "", "", "curse_hit", "", "damageresist", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "necromancer_amplifydamage", "", -1, -1, "", -1, -1, -1),
			new BaseState("Frozen Armor", "frozenarmor", 10, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "frozenarmor", "", "", "", "", "", "", "skill_armor_percent", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Cold", "cold", 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "velocitypercent", -1, -1, "", "", "", "", 100, 108, 150, 215, 255, "impact_bluemotize_1", "", -1, -1, "", -1, -1, -1),
			new BaseState("Inferno", "inferno", 12, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Blaze", "blaze", 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", 3, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Bone Armor", "bonearmor", 14, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, "bonearmor_front", "bonearmor_back", "bonearmor_null1", "bonearmor_null2", "", "bonearmor_cast", "", "", 6, 3, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Concentrate", "concentrate", 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "skill_armor_percent", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Enchant", "enchant", 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "enchant", "", "skill_enchant", -1, -1, "", "", "weap", "cred", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Inner Sight", "innersight", 17, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "innersight", "", "", "", "", "", "", "armorclass", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Skill Move", "skill_move", 18, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Weaken", "weaken", 19, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "curseweaken", "", "", "", "", "curse_hit", "", "damagepercent", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "necromancer_weaken", "", -1, -1, "", -1, -1, -1),
			new BaseState("Chilling Armor", "chillingarmor", 20, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "chillarmor", "", "", "", "", "", "", "skill_armor_percent", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "hitbymissile", 1, -1, -1),
			new BaseState("Stunned", "stunned", 21, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "stun", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Spider Lay", "spiderlay", 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Dim Vision", "dimvision", 23, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "cursedimvision", "", "", "", "", "curse_hit", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "necromancer_dimvision", "", -1, -1, "", -1, -1, -1),
			new BaseState("Slowed", "slowed", 24, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Fetish Aura", "fetishaura", 25, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "fetish_aura", "", "", "", "", "", "", "attackrate", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Shout", "shout", 26, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "shout", "", "", "", "", "shoutstart", "", "skill_armor_percent", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Taunt", "taunt", 27, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "taunt", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "barbarian_battlecry_state", "", -1, -1, "", -1, -1, -1),
			new BaseState("Conviction", "conviction", 28, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "convictionfront", "convictionback", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "paladin_aura_purification", "", -1, -1, "", -1, -1, -1),
			new BaseState("Convicted", "convicted", 29, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "convictionfront", "convictionback", "", "", "", "", "", "skill_conviction", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Energy Shield", "energyshield", 30, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "energyshield", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Venom Claws", "venomclaws", 31, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "poisonmindam", -1, -1, "", "", "mele", "cgrn", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Battle Orders", "battleorders", 32, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "battleorders", "", "", "", "", "battleorderscast", "", "maxmana", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Might", "might", 33, -1, -1, -1, -1, 1, -1, -1, -1, 1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "aura_might_front", "aura_might_back", "", "", "", "", "", "damagepercent", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "paladin_aura_might", "", -1, -1, "", -1, -1, -1),
			new BaseState("Prayer", "prayer", 34, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "aura_prayer_front", "aura_prayer_back", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "paladin_aura_prayer", "", -1, -1, "", -1, -1, -1),
			new BaseState("Holy Fire", "holyfire", 35, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "aura_holyfire_front", "aura_holyfire_back", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "paladin_aura_holyfire", "", -1, -1, "", -1, -1, -1),
			new BaseState("Thorns", "thorns", 36, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "aura_thorns_front", "aura_thorns_back", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "paladin_aura_thorns", "", -1, -1, "", -1, -1, -1),
			new BaseState("Defiance", "defiance", 37, -1, -1, -1, -1, 1, -1, -1, -1, 1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "aura_defiance_front", "aura_defiance_back", "", "", "", "", "", "skill_armor_percent", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "paladin_aura_defiance", "", -1, -1, "", -1, -1, -1),
			new BaseState("Thunderstorm", "thunderstorm", 38, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "thunderstormback", "", "", "", "thunderstormcast", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Lightningbolt", "lightningbolt", 39, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Blessed Aim", "blessedaim", 40, -1, -1, -1, -1, 1, -1, -1, -1, 1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "blessedaimfront", "blessedaimback", "", "", "", "", "", "item_tohit_percent", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "paladin_aura_blessedaim", "", -1, -1, "", -1, -1, -1),
			new BaseState("Stamina", "stamina", 41, -1, -1, -1, -1, 1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "staminafront", "staminaback", "", "", "", "", "", "maxstamina", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "paladin_aura_stamina", "", -1, -1, "", -1, -1, -1),
			new BaseState("Concentration", "concentration", 42, -1, -1, -1, -1, 1, -1, -1, -1, 1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "concentrationfront", "concentrationback", "", "", "", "", "", "damagepercent", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "paladin_aura_concentration", "", -1, -1, "", -1, -1, -1),
			new BaseState("Holy Wind", "holywind", 43, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "holyfreeze", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "paladin_aura_holywind", "", -1, -1, "", -1, -1, -1),
			new BaseState("Holy Wind Cold", "holywindcold", 44, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "null", "", "", "", "", "ice_explode", "", "velocitypercent", -1, -1, "", "", "", "", 100, 108, 150, 215, 255, "impact_bluemotize_1", "", -1, -1, "", -1, -1, -1),
			new BaseState("Cleansing", "cleansing", 45, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "cleansingfront", "cleansingback", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "paladin_aura_cleansing", "", -1, -1, "", -1, -1, -1),
			new BaseState("Holy Shock", "holyshock", 46, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "holyshockfront", "holyshockback", "", "", "", "", "", "lightmaxdam", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "paladin_aura_holylight", "", -1, -1, "", -1, -1, -1),
			new BaseState("Sanctuary", "sanctuary", 47, -1, -1, -1, -1, 1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "sanctuaryfront", "sanctuaryback", "", "", "", "", "", "skill_staminapercent", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "paladin_aura_sanctuary", "", -1, -1, "", -1, 86, -1),
			new BaseState("Meditation", "meditation", 48, -1, -1, -1, -1, 1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "meditationfront", "meditationback", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "paladin_aura_meditation", "", -1, -1, "", -1, -1, -1),
			new BaseState("Fanaticism", "fanaticism", 49, -1, -1, -1, -1, 1, -1, -1, -1, 1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "fanaticismfront", "fanaticismback", "", "", "", "", "", "attackrate", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "paladin_aura_fanatacism", "", -1, -1, "", -1, -1, -1),
			new BaseState("Redemption", "redemption", 50, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "redemptionfront", "redemptionback", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "paladin_aura_redemption", "", -1, -1, "", -1, -1, -1),
			new BaseState("Battle Command", "battlecommand", 51, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "battlecommand", "", "", "", "", "battlecommandcast", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Prevent Heal", "preventheal", 52, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Conversion", "conversion", 53, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "conversionaura", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "paladin_conversion", "", -1, -1, "", -1, -1, -1),
			new BaseState("Uninterruptable", "uninterruptable", 54, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, 7, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Iron Maiden", "ironmaiden", 55, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "curseironmaiden", "", "", "", "", "curse_hit", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "necromancer_ironmaiden", "", -1, -1, "", -1, -1, -1),
			new BaseState("Terror", "terror", 56, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "curseterror", "", "", "", "", "curse_hit", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "necromancer_taint", "", -1, -1, "", -1, -1, -1),
			new BaseState("Attract", "attract", 57, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "curseattract", "", "", "", "", "curse_hit", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "necromancer_attract", "", -1, -1, "", -1, -1, -1),
			new BaseState("Life Tap", "lifetap", 58, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "cursereversevampire", "", "", "", "", "curse_hit", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "necromancer_reversevampire", "", -1, -1, "", -1, -1, -1),
			new BaseState("Confuse", "confuse", 59, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "curseconfuse", "", "", "", "", "curse_hit", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "necromancer_confuse", "", -1, -1, "", -1, -1, -1),
			new BaseState("Decrepify", "decrepify", 60, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "cursedecrepify", "", "", "", "", "curse_hit", "", "skill_decrepify", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "necromancer_decrepify", "", -1, -1, "", -1, -1, -1),
			new BaseState("Lower Resist", "lowerresist", 61, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "curselowerresist", "", "", "", "", "curse_hit", "", "lightresist", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Open Wounds", "openwounds", 62, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, 85, -1),
			new BaseState("Decoy", "dopplezon", 63, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 1, 1, -1, 1, -1, -1, -1, -1, -1, 1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", 2, 0, "", -1, -1, -1),
			new BaseState("Critical Strike", "criticalstrike", 64, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Dodge", "dodge", 65, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Avoid", "avoid", 66, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Penetrate", "penetrate", 67, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Evade", "evade", 68, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Pierce", "pierce", 69, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Warmth", "warmth", 70, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Fire Mastery", "firemastery", 71, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Lightning Mastery", "lightningmastery", 72, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Cold Mastery", "coldmastery", 73, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Sword Mastery", "swordmastery", 74, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Axe Mastery", "axemastery", 75, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Mace Mastery", "macemastery", 76, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Polearm Mastery", "polearmmastery", 77, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Throwing Mastery", "throwingmastery", 78, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Spear Mastery", "spearmastery", 79, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Increased Stamina", "increasedstamina", 80, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Iron Skin", "ironskin", 81, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Increased Speed", "increasedspeed", 82, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "velocitypercent", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Natural Resistance", "naturalresistance", 83, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Finger Mage Curse", "fingermagecurse", 84, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "fingermagecurse", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("No Mana Regen", "nomanaregen", 85, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Just Hit", "justhit", 86, 1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Slow Missiles", "slowmissiles", 87, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "innersight", "", "", "", "", "", "", "skill_handofathena", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Shiver Armor", "shiverarmor", 88, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "shiverarmor", "", "", "", "", "", "", "skill_armor_percent", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, 87, -1),
			new BaseState("Battle Cry", "battlecry", 89, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "battlecry", "", "", "", "", "", "", "skill_armor_percent", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "barbarian_battlecry_state", "", -1, -1, "", -1, -1, -1),
			new BaseState("Blue", "blue", 90, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", 100, 108, 150, 215, 255, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Red", "red", 91, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", 70, 100, 255, 255, 255, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Death Delay", "death_delay", 92, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Valkyrie", "valkyrie", 93, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "valkyrie", "", "", "", "", "valkyriestart", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", 2, 0, "", -1, -1, -1),
			new BaseState("Frenzy", "frenzy", 94, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "frenzy", "", "", "", "", "", "skill_frenzy", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Berserk", "berserk", 95, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "berserkfront", "berserkback", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Revive", "revive", 96, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", 15, -1, "", "", "", "", 85, 73, 255, 255, 255, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Skeleton Mastery", "skel_mastery", 97, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Source Unit", "sourceunit", 98, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", 4, 2, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Redeemed", "redeemed", 99, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 1, 1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", 10, -1, "", "Redemption", "", "", -1, -1, -1, -1, -1, "paladin_redeemed_soul", "", -1, -1, "", -1, -1, -1),
			new BaseState("Health Pot", "healthpot", 100, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Holy Shield", "holyshield", 101, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "skill_armor_percent", -1, -1, "", "Holy Shield", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Just Portaled", "just_portaled", 102, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Monster Frenzy", "monfrenzy", 103, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "monfrenzy", "", "", "", "", "", "skill_frenzy", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Corpse No Draw", "corpse_nodraw", 104, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 1, 1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Alignment", "alignment", 105, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Mana Pot", "manapot", 106, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Shatter", "shatter", 107, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 1, 1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Sync Warped", "sync_warped", 108, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Conversion Save", "conversion_save", 109, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Pregnant", "pregnant", 110, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "impregnated", "", "", "", "", "", "", "", -1, 10, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Golem Mastery", "golem_mastery", 111, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Rabies", "rabies", 112, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "rabiesplague", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Defense Curse", "defense_curse", 113, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "defense_curse", "", "", "", "", "", "", "skill_armor_percent", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Blood Mana", "blood_mana", 114, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "blood_mana", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Burning", "burning", 115, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "burning", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Dragon Flight", "dragonflight", 116, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Maul", "maul", 117, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, "maul1", "maul5", "maul1back", "maul5back", "", "", "", "damagepercent", 16, 11, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Corpse Noselect", "corpse_noselect", 118, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 1, 1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Shadow Warrior", "shadowwarrior", 119, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", 2, 6, "", -1, -1, -1),
			new BaseState("Feral Rage", "feralrage", 120, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, "feralrage1", "feralrage5", "feralrage1back", "feralrage5back", "", "", "", "attackrate", 16, 11, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Skill Delay", "skilldelay", 121, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", 19, 12, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Progressive Damage", "progressive_damage", 122, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, "", "", "", "", "progressive_damage_1", "", "", "progressive_damage", 1, 1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Progressive Steal", "progressive_steal", 123, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, "", "", "", "", "progressive_steal_1", "", "", "progressive_steal", 1, 1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Progressive Other", "progressive_other", 124, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, "", "", "", "", "progressive_other_1", "", "", "progressive_other", 1, 1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Progressive Fire", "progressive_fire", 125, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, "", "", "", "", "progressive_fire_1", "", "", "progressive_fire", 1, 1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Progressive Cold", "progressive_cold", 126, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, "", "", "", "", "progressive_cold_1", "", "", "progressive_cold", 1, 1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Progressive Lightning", "progressive_lightning", 127, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, "", "", "", "", "progressive_lightning_1", "", "", "progressive_lightning", 1, 1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Shrine Armor", "shrine_armor", 128, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "shrine_armor", "shrine_shimmer00", "", "", "", "", "", "armorclass", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Shrine Combat", "shrine_combat", 129, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "shrine_combat", "shrine_shimmer00", "", "", "", "", "", "tohit", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Shrine Resist Lightning", "shrine_resist_lightning", 130, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "shrine_resist_lightning", "shrine_shimmer01", "", "", "", "", "", "lightresist", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Shrine Resist Fire", "shrine_resist_fire", 131, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "shrine_resist_fire", "shrine_shimmer00", "", "", "", "", "", "fireresist", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Shrine Resist Cold", "shrine_resist_cold", 132, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "shrine_resist_cold", "shrine_shimmer01", "", "", "", "", "", "coldresist", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Shrine Resist Poison", "shrine_resist_poison", 133, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "shrine_resist_poison", "shrine_shimmer01", "", "", "", "", "", "poisonresist", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Shrine Skill", "shrine_skill", 134, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "shrine_skill", "shrine_shimmer00", "", "", "", "", "", "", 9, 6, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Shrine Mana Regen", "shrine_mana_regen", 135, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "shrine_mana_regen", "shrine_shimmer01", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Shrine Stamina", "shrine_stamina", 136, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "shrine_stamina", "shrine_shimmer01", "", "", "", "", "", "stamina", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Shrine Experience", "shrine_experience", 137, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "shrine_experience", "shrine_shimmer00", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Fenris Rage", "fenris_rage", 138, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "direwolfcharged", "direwolfcharged", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Wolf", "wolf", 139, 3, -1, -1, 1, -1, -1, -1, -1, -1, 1, 1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, "", "", "", "", "", "", "", "", 14, -1, "", "", "", "", -1, -1, -1, -1, -1, "druid_morph", "druid_morph", 1, 430, "", -1, -1, -1),
			new BaseState("Bear", "bear", 140, 3, -1, -1, 1, -1, -1, -1, -1, -1, 1, 1, -1, -1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, "", "", "", "", "", "", "", "", 14, -1, "", "", "", "", -1, -1, -1, -1, -1, "druid_morph", "druid_morph", 1, 431, "", -1, -1, -1),
			new BaseState("Bloodlust", "bloodlust", 141, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "bloodlust_state", "bloodlust_state", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Change Class", "changeclass", 142, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", 5, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Attached", "attached", 143, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", 13, 9, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, 88, 147),
			new BaseState("Hurricane", "hurricane", 144, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", 7, 4, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, 90, 145),
			new BaseState("Armageddon", "armageddon", 145, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, 146),
			new BaseState("Invis", "invis", 146, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", 12, 8, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Barbs", "barbs", 147, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "spirit_of_barbs", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Wolverine", "wolverine", 148, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "heart_of_wolverine", "", "", "", "", "", "item_tohit_percent", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Oaksage", "oaksage", 149, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "oak_sage", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Vine Beast", "vine_beast", 150, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", 11, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, 89, -1),
			new BaseState("Cyclone Armor", "cyclonearmor", 151, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, "cyclonearmor1front", "cyclonearmor2front", "cyclonearmor3front", "", "", "", "", "", 8, 5, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Claw Mastery", "clawmastery", 152, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Cloak Of Shadows", "cloak_of_shadows", 153, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", 2, -1, "", "", "", "", -1, -1, -1, -1, -1, "assassin_cloakofdarkness", "", -1, -1, "", -1, -1, -1),
			new BaseState("Recycled", "recycled", 154, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 1, 1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Weapon Block", "weaponblock", 155, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Cloaked", "cloaked", 156, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "cloaked", "", "", "", "", "", "", "skill_armor_percent", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Quickness", "quickness", 157, 2, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "quickness", "", "", "", "", "", "", "attackrate", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Blade Shield", "bladeshield", 158, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "bladeshield", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Fade", "fade", 159, 2, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 1, 1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "fade", "", "", "", "", "", "", "poisonresist", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Summon Resist", "summonresist", 160, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Oak Sage Control", "oaksagecontrol", 161, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Wolverine Control", "wolverinecontrol", 162, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Barbs Control", "barbscontrol", 163, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Debug Control", "debugcontrol", 164, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Item Set 1", "itemset1", 165, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Item Set 2", "itemset2", 166, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Item Set 3", "itemset3", 167, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Item Set 4", "itemset4", 168, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Item Set 5", "itemset5", 169, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Item Set 6", "itemset6", 170, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Runeword", "runeword", 171, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Rest In Peace", "restinpeace", 172, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, 1, "", "", "", "", "", "", "", "", 17, -1, "redemption", "", "", "", -1, -1, -1, -1, -1, "paladin_redeemed_soul", "", -1, -1, "", -1, -1, -1),
			new BaseState("Corpse Exp", "corpseexp", 173, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 1, 1, -1, 1, -1, -1, -1, -1, -1, -1, -1, 1, "", "", "", "", "", "", "", "", 18, -1, "corpseexplosion", "", "", "", -1, -1, -1, -1, -1, "necromancer_corpseexp_1", "", -1, -1, "", -1, -1, -1),
			new BaseState("Whirl Wind", "whirlwind", 174, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "whirlwind", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Full Set Generic", "fullsetgeneric", 175, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "aura_fanatic", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Monster Set", "monsterset", 176, 3, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "fire_cast_2", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", 1, 135, "", -1, -1, -1),
			new BaseState("Delerium", "delerium", 177, 3, -1, -1, 1, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "teleport", "teleport", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", 1, 212, "", -1, -1, -1),
			new BaseState("Antidote", "antidote", 178, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Thawing", "thawing", 179, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Stamina Pot", "staminapot", 180, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Passive Resist Fire", "passive_resistfire", 181, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Passive Resist Cold", "passive_resistcold", 182, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Passive Resist Lightning", "passive_resistltng", 183, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Uber Minion", "uberminion", 184, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, 1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "impact_bluemotize_1", "", -1, -1, "", -1, -1, -1),
			new BaseState("Cooldown", "cooldown", 185, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, 1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Shared Stash", "sharedstash", 186, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, 1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Hide Dead", "hidedead", 187, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, 1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1),
			new BaseState("Impale", "impale", 188, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, -1, 1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, "", "", "", "", "", "", "", "", -1, -1, "", "", "", "", -1, -1, -1, -1, -1, "", "", -1, -1, "", -1, -1, -1)
		};

		// Token: 0x04006E2D RID: 28205
		public static readonly int ItemCount = BaseState.items.Length;
	}
}
