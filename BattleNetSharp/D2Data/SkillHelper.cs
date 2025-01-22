using System;
using D2Data.Generated;

namespace D2Data
{
	// Token: 0x02000972 RID: 2418
	public static class SkillHelper
	{
		// Token: 0x0600B99C RID: 47516 RVA: 0x0037C844 File Offset: 0x0037AA44
		public static bool IsTimed(SkillType skill)
		{
			return skill == SkillType.Blizzard;
		}

		// Token: 0x0600B99D RID: 47517 RVA: 0x0037C868 File Offset: 0x0037AA68
		public static ushort GetRange(SkillType skill, ushort skillLevel = 1)
		{
			if (skill <= SkillType.BlessedHammer)
			{
				if (skill <= SkillType.Teeth)
				{
					switch (skill)
					{
					case SkillType.Attack:
						return 3;
					case SkillType.Kick:
					case SkillType.LeftHandSwing:
					case SkillType.Jab:
					case SkillType.PowerStrike:
					case SkillType.Impale:
					case SkillType.ChargedStrike:
					case SkillType.Fend:
					case SkillType.LightningStrike:
					case SkillType.Blaze:
						goto IL_0304;
					case SkillType.Throw:
					case SkillType.Unsummon:
					case SkillType.LeftHandThrow:
					case SkillType.MagicArrow:
					case SkillType.CriticalStrike:
					case SkillType.ColdArrow:
					case SkillType.Dodge:
					case SkillType.Avoid:
					case SkillType.LightningBolt:
					case SkillType.IceArrow:
					case SkillType.Penetrate:
					case SkillType.Strafe:
					case SkillType.Dopplezon:
					case SkillType.Evade:
					case SkillType.Valkyrie:
					case SkillType.Pierce:
					case SkillType.FireBolt:
					case SkillType.Warmth:
					case SkillType.IceBolt:
					case SkillType.FrozenArmor:
					case SkillType.Inferno:
					case SkillType.Telekinesis:
					case SkillType.IceBlast:
					case SkillType.FireBall:
						goto IL_03C5;
					case SkillType.FireArrow:
					case SkillType.MultipleShot:
					case SkillType.ExplodingArrow:
					case SkillType.GuidedArrow:
					case SkillType.ImmolationArrow:
					case SkillType.FreezingArrow:
						goto IL_0352;
					case SkillType.InnerSight:
					case SkillType.SlowMissiles:
						return 13;
					case SkillType.PoisonJavelin:
					case SkillType.PlagueJavelin:
						goto IL_033D;
					case SkillType.LightningFury:
						goto IL_034C;
					case SkillType.ChargedBolt:
						return 6;
					case SkillType.StaticField:
						return (ushort)Math.Floor((double)((float)(skillLevel + 4) * 2f / 3f));
					case SkillType.FrostNova:
						goto IL_0314;
					case SkillType.Nova:
						goto IL_0324;
					case SkillType.Lightning:
						break;
					default:
						if (skill != SkillType.FrozenOrb && skill != SkillType.Teeth)
						{
							goto IL_03C5;
						}
						goto IL_034C;
					}
				}
				else if (skill <= SkillType.BoneSpear)
				{
					if (skill == SkillType.PoisonDagger)
					{
						goto IL_0304;
					}
					if (skill != SkillType.BoneSpear)
					{
						goto IL_03C5;
					}
				}
				else
				{
					switch (skill)
					{
					case SkillType.LowerResist:
						return 50;
					case SkillType.PoisonNova:
						return 8;
					case SkillType.BoneSpirit:
						break;
					case SkillType.Firegolem:
					case SkillType.Might:
					case SkillType.Prayer:
					case SkillType.ResistFire:
					case SkillType.HolyFire:
					case SkillType.Thorns:
					case SkillType.Defiance:
					case SkillType.ResistCold:
						goto IL_03C5;
					case SkillType.Revive:
						goto IL_0352;
					case SkillType.Sacrifice:
					case SkillType.Smite:
					case SkillType.Zeal:
						goto IL_0304;
					case SkillType.HolyBolt:
					case SkillType.Charge:
						goto IL_033D;
					default:
						if (skill - SkillType.Vengeance > 1)
						{
							goto IL_03C5;
						}
						goto IL_0304;
					}
				}
				return 15;
			}
			if (skill <= SkillType.WarCry)
			{
				if (skill != SkillType.Conversion)
				{
					if (skill == SkillType.FistOfTheHeavens)
					{
						goto IL_0352;
					}
					switch (skill)
					{
					case SkillType.Bash:
					case SkillType.Howl:
					case SkillType.FindPotion:
					case SkillType.DoubleSwing:
					case SkillType.Stun:
					case SkillType.FindItem:
					case SkillType.Concentrate:
					case SkillType.Frenzy:
					case SkillType.GrimWard:
					case SkillType.Berserk:
						break;
					case SkillType.SwordMastery:
					case SkillType.AxeMastery:
					case SkillType.MaceMastery:
					case SkillType.PoleArmMastery:
					case SkillType.ThrowingMastery:
					case SkillType.SpearMastery:
					case SkillType.Taunt:
					case SkillType.Shout:
					case SkillType.IncreasedStamina:
					case SkillType.LeapAttack:
					case SkillType.IronSkin:
					case SkillType.IncreasedSpeed:
					case SkillType.BattleOrders:
					case SkillType.NaturalResistance:
						goto IL_03C5;
					case SkillType.Leap:
					{
						ushort[] array = new ushort[]
						{
							4, 7, 8, 10, 11, 12, 12, 13, 14, 14,
							14, 14, 15, 16, 16, 16, 16, 16, 16, 16,
							16, 16, 16, 16, 17
						};
						return array[Math.Min((int)(skillLevel - 1), 24)];
					}
					case SkillType.DoubleThrow:
						goto IL_0352;
					case SkillType.BattleCry:
					case SkillType.WarCry:
						return 4;
					case SkillType.Whirlwind:
						goto IL_0324;
					default:
						goto IL_03C5;
					}
				}
			}
			else if (skill <= SkillType.DragonTail)
			{
				switch (skill)
				{
				case SkillType.Firestorm:
				case SkillType.MoltenBoulder:
				case SkillType.ShockWave:
					goto IL_033D;
				case SkillType.OakSage:
				case SkillType.SummonSpiritWolf:
				case SkillType.Wearbear:
				case SkillType.CycleOfLife:
				case SkillType.CycloneArmor:
				case SkillType.HeartOfWolverine:
				case SkillType.SummonDireWolf:
				case SkillType.Vines:
				case SkillType.SpiritOfBarbs:
				case SkillType.SummonGrizzly:
				case SkillType.Hurricane:
				case SkillType.ClawMastery:
				case SkillType.TigerStrike:
				case SkillType.BurstOfSpeed:
				case SkillType.FistsOfFire:
				case SkillType.ChargedBoltSentry:
				case SkillType.WakeOfFire:
				case SkillType.WeaponBlock:
				case SkillType.CloakOfShadows:
				case SkillType.CobraStrike:
					goto IL_03C5;
				case SkillType.ArcticBlast:
				{
					ushort[] array2 = new ushort[]
					{
						5, 6, 6, 6, 6, 7, 7, 8, 8, 8,
						8, 9, 9, 10, 10, 10, 10, 11, 11, 12
					};
					return array2[Math.Min((int)(skillLevel - 1), 19)];
				}
				case SkillType.FeralRage:
				case SkillType.Maul:
				case SkillType.Rabies:
				case SkillType.FireClaws:
				case SkillType.Hunger:
				case SkillType.Fury:
				case SkillType.DragonTalon:
				case SkillType.DragonClaw:
					break;
				case SkillType.Fissure:
				case SkillType.Volcano:
				case SkillType.FireBlast:
				case SkillType.ShockWeb:
				case SkillType.BladeSentinel:
				case SkillType.BladeFury:
					goto IL_034C;
				case SkillType.Twister:
				case SkillType.Tornado:
					goto IL_0314;
				case SkillType.Armageddon:
					return 9;
				case SkillType.PsychicHammer:
					goto IL_0352;
				default:
					if (skill != SkillType.DragonTail)
					{
						goto IL_03C5;
					}
					break;
				}
			}
			else
			{
				if (skill == SkillType.DragonFlight)
				{
					goto IL_0352;
				}
				if (skill != (SkillType)500)
				{
					goto IL_03C5;
				}
				goto IL_0314;
			}
			IL_0304:
			return 3;
			IL_0314:
			return 5;
			IL_0324:
			return 7;
			IL_033D:
			return 10;
			IL_034C:
			return 15;
			IL_0352:
			return 20;
			IL_03C5:
			return 20;
		}

		// Token: 0x0600B99E RID: 47518 RVA: 0x0037CC44 File Offset: 0x0037AE44
		public static string GetSkillType(SkillType skill)
		{
			skills skills = skills.skillsList[(int)skill];
			return skills.EType;
		}

		// Token: 0x0600B99F RID: 47519 RVA: 0x0037CC68 File Offset: 0x0037AE68
		public static float GetSkillMana(SkillType skill, ushort skillLvl)
		{
			bool flag = skill <= SkillType.LeftHandSwing;
			float num;
			if (flag)
			{
				num = 0f;
			}
			else
			{
				skills skills = skills.skillsList[(int)skill];
				int[] array = new int[]
				{
					1, 2, 4, 8, 16, 32, 64, 128, 256, 512,
					1024
				};
				int num2 = ((skills.lvlmana == 65535) ? (-1) : skills.lvlmana);
				float num3 = Math.Max((float)(skills.mana + skills.lvlmana * (int)(skillLvl - 1)) * ((float)array[skills.manashift] / 256f), (float)skills.minmana);
				num = num3;
			}
			return num;
		}

		// Token: 0x0600B9A0 RID: 47520 RVA: 0x0037CCF8 File Offset: 0x0037AEF8
		public static SkillHand GetSkillHand(SkillType skill)
		{
			if (skill <= SkillType.DoubleThrow)
			{
				if (skill <= SkillType.HolyBolt)
				{
					if (skill <= SkillType.BoneSpear)
					{
						switch (skill)
						{
						case SkillType.MagicArrow:
						case SkillType.FireArrow:
						case SkillType.CriticalStrike:
						case SkillType.Jab:
						case SkillType.ColdArrow:
						case SkillType.MultipleShot:
						case SkillType.Dodge:
						case SkillType.PowerStrike:
						case SkillType.PoisonJavelin:
						case SkillType.ExplodingArrow:
						case SkillType.Avoid:
						case SkillType.Impale:
						case SkillType.LightningBolt:
						case SkillType.IceArrow:
						case SkillType.GuidedArrow:
						case SkillType.Penetrate:
						case SkillType.ChargedStrike:
						case SkillType.PlagueJavelin:
						case SkillType.Strafe:
						case SkillType.ImmolationArrow:
						case SkillType.Evade:
						case SkillType.Fend:
						case SkillType.FreezingArrow:
						case SkillType.Pierce:
						case SkillType.LightningStrike:
						case SkillType.LightningFury:
						case SkillType.FireBolt:
						case SkillType.ChargedBolt:
						case SkillType.IceBolt:
						case SkillType.Inferno:
						case SkillType.IceBlast:
						case SkillType.FireBall:
						case SkillType.Lightning:
						case SkillType.ChainLightning:
						case SkillType.GlacialSpike:
						case SkillType.FrozenOrb:
						case SkillType.Teeth:
						case SkillType.PoisonDagger:
							break;
						case SkillType.InnerSight:
						case SkillType.SlowMissiles:
						case SkillType.Dopplezon:
						case SkillType.Valkyrie:
						case SkillType.Warmth:
						case SkillType.FrozenArmor:
						case SkillType.StaticField:
						case SkillType.Telekinesis:
						case SkillType.FrostNova:
						case SkillType.Blaze:
						case SkillType.Nova:
						case SkillType.ShiverArmor:
						case SkillType.FireWall:
						case SkillType.Enchant:
						case SkillType.Teleport:
						case SkillType.Meteor:
						case SkillType.ThunderStorm:
						case SkillType.EnergyShield:
						case SkillType.Blizzard:
						case SkillType.ChillingArmor:
						case SkillType.FireMastery:
						case SkillType.Hydra:
						case SkillType.LightningMastery:
						case SkillType.ColdMastery:
						case SkillType.AmplifyDamage:
						case SkillType.BoneArmor:
						case SkillType.SkeletonMastery:
						case SkillType.RaiseSkeleton:
						case SkillType.DimVision:
						case SkillType.Weaken:
							goto IL_0284;
						default:
							if (skill != SkillType.BoneSpear)
							{
								goto IL_0284;
							}
							break;
						}
					}
					else if (skill != SkillType.BoneSpirit && skill != SkillType.HolyBolt)
					{
						goto IL_0284;
					}
				}
				else if (skill <= SkillType.BlessedHammer)
				{
					if (skill != SkillType.Charge && skill - SkillType.Vengeance > 1)
					{
						goto IL_0284;
					}
				}
				else if (skill != SkillType.FistOfTheHeavens && skill != SkillType.Leap && skill != SkillType.DoubleThrow)
				{
					goto IL_0284;
				}
			}
			else if (skill <= SkillType.Twister)
			{
				if (skill <= SkillType.Whirlwind)
				{
					if (skill != SkillType.LeapAttack && skill != SkillType.Whirlwind)
					{
						goto IL_0284;
					}
				}
				else if (skill != SkillType.Firestorm && skill - SkillType.MoltenBoulder > 1 && skill != SkillType.Twister)
				{
					goto IL_0284;
				}
			}
			else if (skill <= SkillType.Tornado)
			{
				if (skill != SkillType.ShockWave && skill != SkillType.Tornado)
				{
					goto IL_0284;
				}
			}
			else
			{
				switch (skill)
				{
				case SkillType.FireBlast:
				case SkillType.TigerStrike:
				case SkillType.ShockWeb:
				case SkillType.BladeSentinel:
				case SkillType.FistsOfFire:
					break;
				case SkillType.ClawMastery:
				case SkillType.PsychicHammer:
				case SkillType.DragonTalon:
				case SkillType.BurstOfSpeed:
					goto IL_0284;
				default:
					switch (skill)
					{
					case SkillType.WeaponBlock:
					case SkillType.CobraStrike:
					case SkillType.BladeFury:
					case SkillType.ClawsOfThunder:
						break;
					case SkillType.CloakOfShadows:
					case SkillType.Fade:
					case SkillType.ShadowWarrior:
						goto IL_0284;
					default:
						if (skill - SkillType.BladesOfIce > 1)
						{
							goto IL_0284;
						}
						break;
					}
					break;
				}
			}
			return SkillHand.Left;
			IL_0284:
			return SkillHand.Right;
		}
	}
}
