using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001DE RID: 478
	public sealed class DebugCombatActorInfo : IMessage<DebugCombatActorInfo>, IMessage, IEquatable<DebugCombatActorInfo>, IDeepCloneable<DebugCombatActorInfo>, IBufferMessage
	{
		// Token: 0x170010BA RID: 4282
		// (get) Token: 0x0600339F RID: 13215 RVA: 0x000CC5B0 File Offset: 0x000CA7B0
		[DebuggerNonUserCode]
		public static MessageParser<DebugCombatActorInfo> Parser
		{
			get
			{
				return DebugCombatActorInfo._parser;
			}
		}

		// Token: 0x170010BB RID: 4283
		// (get) Token: 0x060033A0 RID: 13216 RVA: 0x000CC5C8 File Offset: 0x000CA7C8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[35];
			}
		}

		// Token: 0x170010BC RID: 4284
		// (get) Token: 0x060033A1 RID: 13217 RVA: 0x000CC5EC File Offset: 0x000CA7EC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugCombatActorInfo.Descriptor;
			}
		}

		// Token: 0x060033A2 RID: 13218 RVA: 0x000CC603 File Offset: 0x000CA803
		[DebuggerNonUserCode]
		public DebugCombatActorInfo()
		{
		}

		// Token: 0x060033A3 RID: 13219 RVA: 0x000CC610 File Offset: 0x000CA810
		[DebuggerNonUserCode]
		public DebugCombatActorInfo(DebugCombatActorInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameAccountId_ = other.gameAccountId_;
			this.acdName_ = other.acdName_;
			this.actorSno_ = other.actorSno_;
			this.playerOrPet_ = other.playerOrPet_;
			this.level_ = other.level_;
			this.weaponDamage_ = other.weaponDamage_;
			this.playerArmor_ = other.playerArmor_;
			this.itemPower_ = other.itemPower_;
			this.maxHp_ = other.maxHp_;
			this.monsterRarity_ = other.monsterRarity_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060033A4 RID: 13220 RVA: 0x000CC6BC File Offset: 0x000CA8BC
		[DebuggerNonUserCode]
		public DebugCombatActorInfo Clone()
		{
			return new DebugCombatActorInfo(this);
		}

		// Token: 0x170010BD RID: 4285
		// (get) Token: 0x060033A5 RID: 13221 RVA: 0x000CC6D4 File Offset: 0x000CA8D4
		// (set) Token: 0x060033A6 RID: 13222 RVA: 0x000CC705 File Offset: 0x000CA905
		[DebuggerNonUserCode]
		public uint GameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint gameAccountIdDefaultValue;
				if (flag)
				{
					gameAccountIdDefaultValue = this.gameAccountId_;
				}
				else
				{
					gameAccountIdDefaultValue = DebugCombatActorInfo.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x170010BE RID: 4286
		// (get) Token: 0x060033A7 RID: 13223 RVA: 0x000CC720 File Offset: 0x000CA920
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060033A8 RID: 13224 RVA: 0x000CC73D File Offset: 0x000CA93D
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170010BF RID: 4287
		// (get) Token: 0x060033A9 RID: 13225 RVA: 0x000CC750 File Offset: 0x000CA950
		// (set) Token: 0x060033AA RID: 13226 RVA: 0x000CC771 File Offset: 0x000CA971
		[DebuggerNonUserCode]
		public string AcdName
		{
			get
			{
				return this.acdName_ ?? DebugCombatActorInfo.AcdNameDefaultValue;
			}
			set
			{
				this.acdName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170010C0 RID: 4288
		// (get) Token: 0x060033AB RID: 13227 RVA: 0x000CC788 File Offset: 0x000CA988
		[DebuggerNonUserCode]
		public bool HasAcdName
		{
			get
			{
				return this.acdName_ != null;
			}
		}

		// Token: 0x060033AC RID: 13228 RVA: 0x000CC7A3 File Offset: 0x000CA9A3
		[DebuggerNonUserCode]
		public void ClearAcdName()
		{
			this.acdName_ = null;
		}

		// Token: 0x170010C1 RID: 4289
		// (get) Token: 0x060033AD RID: 13229 RVA: 0x000CC7B0 File Offset: 0x000CA9B0
		// (set) Token: 0x060033AE RID: 13230 RVA: 0x000CC7E1 File Offset: 0x000CA9E1
		[DebuggerNonUserCode]
		public int ActorSno
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int actorSnoDefaultValue;
				if (flag)
				{
					actorSnoDefaultValue = this.actorSno_;
				}
				else
				{
					actorSnoDefaultValue = DebugCombatActorInfo.ActorSnoDefaultValue;
				}
				return actorSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.actorSno_ = value;
			}
		}

		// Token: 0x170010C2 RID: 4290
		// (get) Token: 0x060033AF RID: 13231 RVA: 0x000CC7FC File Offset: 0x000CA9FC
		[DebuggerNonUserCode]
		public bool HasActorSno
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060033B0 RID: 13232 RVA: 0x000CC819 File Offset: 0x000CAA19
		[DebuggerNonUserCode]
		public void ClearActorSno()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170010C3 RID: 4291
		// (get) Token: 0x060033B1 RID: 13233 RVA: 0x000CC82C File Offset: 0x000CAA2C
		// (set) Token: 0x060033B2 RID: 13234 RVA: 0x000CC85D File Offset: 0x000CAA5D
		[DebuggerNonUserCode]
		public bool PlayerOrPet
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool playerOrPetDefaultValue;
				if (flag)
				{
					playerOrPetDefaultValue = this.playerOrPet_;
				}
				else
				{
					playerOrPetDefaultValue = DebugCombatActorInfo.PlayerOrPetDefaultValue;
				}
				return playerOrPetDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.playerOrPet_ = value;
			}
		}

		// Token: 0x170010C4 RID: 4292
		// (get) Token: 0x060033B3 RID: 13235 RVA: 0x000CC878 File Offset: 0x000CAA78
		[DebuggerNonUserCode]
		public bool HasPlayerOrPet
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060033B4 RID: 13236 RVA: 0x000CC895 File Offset: 0x000CAA95
		[DebuggerNonUserCode]
		public void ClearPlayerOrPet()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170010C5 RID: 4293
		// (get) Token: 0x060033B5 RID: 13237 RVA: 0x000CC8A8 File Offset: 0x000CAAA8
		// (set) Token: 0x060033B6 RID: 13238 RVA: 0x000CC8D9 File Offset: 0x000CAAD9
		[DebuggerNonUserCode]
		public int Level
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int levelDefaultValue;
				if (flag)
				{
					levelDefaultValue = this.level_;
				}
				else
				{
					levelDefaultValue = DebugCombatActorInfo.LevelDefaultValue;
				}
				return levelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.level_ = value;
			}
		}

		// Token: 0x170010C6 RID: 4294
		// (get) Token: 0x060033B7 RID: 13239 RVA: 0x000CC8F4 File Offset: 0x000CAAF4
		[DebuggerNonUserCode]
		public bool HasLevel
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060033B8 RID: 13240 RVA: 0x000CC911 File Offset: 0x000CAB11
		[DebuggerNonUserCode]
		public void ClearLevel()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x170010C7 RID: 4295
		// (get) Token: 0x060033B9 RID: 13241 RVA: 0x000CC924 File Offset: 0x000CAB24
		// (set) Token: 0x060033BA RID: 13242 RVA: 0x000CC956 File Offset: 0x000CAB56
		[DebuggerNonUserCode]
		public int WeaponDamage
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				int weaponDamageDefaultValue;
				if (flag)
				{
					weaponDamageDefaultValue = this.weaponDamage_;
				}
				else
				{
					weaponDamageDefaultValue = DebugCombatActorInfo.WeaponDamageDefaultValue;
				}
				return weaponDamageDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.weaponDamage_ = value;
			}
		}

		// Token: 0x170010C8 RID: 4296
		// (get) Token: 0x060033BB RID: 13243 RVA: 0x000CC970 File Offset: 0x000CAB70
		[DebuggerNonUserCode]
		public bool HasWeaponDamage
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x060033BC RID: 13244 RVA: 0x000CC98E File Offset: 0x000CAB8E
		[DebuggerNonUserCode]
		public void ClearWeaponDamage()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x170010C9 RID: 4297
		// (get) Token: 0x060033BD RID: 13245 RVA: 0x000CC9A0 File Offset: 0x000CABA0
		// (set) Token: 0x060033BE RID: 13246 RVA: 0x000CC9D2 File Offset: 0x000CABD2
		[DebuggerNonUserCode]
		public int PlayerArmor
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				int playerArmorDefaultValue;
				if (flag)
				{
					playerArmorDefaultValue = this.playerArmor_;
				}
				else
				{
					playerArmorDefaultValue = DebugCombatActorInfo.PlayerArmorDefaultValue;
				}
				return playerArmorDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.playerArmor_ = value;
			}
		}

		// Token: 0x170010CA RID: 4298
		// (get) Token: 0x060033BF RID: 13247 RVA: 0x000CC9EC File Offset: 0x000CABEC
		[DebuggerNonUserCode]
		public bool HasPlayerArmor
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x060033C0 RID: 13248 RVA: 0x000CCA0A File Offset: 0x000CAC0A
		[DebuggerNonUserCode]
		public void ClearPlayerArmor()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x170010CB RID: 4299
		// (get) Token: 0x060033C1 RID: 13249 RVA: 0x000CCA1C File Offset: 0x000CAC1C
		// (set) Token: 0x060033C2 RID: 13250 RVA: 0x000CCA4E File Offset: 0x000CAC4E
		[DebuggerNonUserCode]
		public int ItemPower
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				int itemPowerDefaultValue;
				if (flag)
				{
					itemPowerDefaultValue = this.itemPower_;
				}
				else
				{
					itemPowerDefaultValue = DebugCombatActorInfo.ItemPowerDefaultValue;
				}
				return itemPowerDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.itemPower_ = value;
			}
		}

		// Token: 0x170010CC RID: 4300
		// (get) Token: 0x060033C3 RID: 13251 RVA: 0x000CCA68 File Offset: 0x000CAC68
		[DebuggerNonUserCode]
		public bool HasItemPower
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x060033C4 RID: 13252 RVA: 0x000CCA86 File Offset: 0x000CAC86
		[DebuggerNonUserCode]
		public void ClearItemPower()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x170010CD RID: 4301
		// (get) Token: 0x060033C5 RID: 13253 RVA: 0x000CCA98 File Offset: 0x000CAC98
		// (set) Token: 0x060033C6 RID: 13254 RVA: 0x000CCACD File Offset: 0x000CACCD
		[DebuggerNonUserCode]
		public float MaxHp
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				float maxHpDefaultValue;
				if (flag)
				{
					maxHpDefaultValue = this.maxHp_;
				}
				else
				{
					maxHpDefaultValue = DebugCombatActorInfo.MaxHpDefaultValue;
				}
				return maxHpDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.maxHp_ = value;
			}
		}

		// Token: 0x170010CE RID: 4302
		// (get) Token: 0x060033C7 RID: 13255 RVA: 0x000CCAEC File Offset: 0x000CACEC
		[DebuggerNonUserCode]
		public bool HasMaxHp
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x060033C8 RID: 13256 RVA: 0x000CCB0D File Offset: 0x000CAD0D
		[DebuggerNonUserCode]
		public void ClearMaxHp()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x170010CF RID: 4303
		// (get) Token: 0x060033C9 RID: 13257 RVA: 0x000CCB24 File Offset: 0x000CAD24
		// (set) Token: 0x060033CA RID: 13258 RVA: 0x000CCB59 File Offset: 0x000CAD59
		[DebuggerNonUserCode]
		public int MonsterRarity
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				int monsterRarityDefaultValue;
				if (flag)
				{
					monsterRarityDefaultValue = this.monsterRarity_;
				}
				else
				{
					monsterRarityDefaultValue = DebugCombatActorInfo.MonsterRarityDefaultValue;
				}
				return monsterRarityDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.monsterRarity_ = value;
			}
		}

		// Token: 0x170010D0 RID: 4304
		// (get) Token: 0x060033CB RID: 13259 RVA: 0x000CCB78 File Offset: 0x000CAD78
		[DebuggerNonUserCode]
		public bool HasMonsterRarity
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x060033CC RID: 13260 RVA: 0x000CCB99 File Offset: 0x000CAD99
		[DebuggerNonUserCode]
		public void ClearMonsterRarity()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x060033CD RID: 13261 RVA: 0x000CCBB0 File Offset: 0x000CADB0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugCombatActorInfo);
		}

		// Token: 0x060033CE RID: 13262 RVA: 0x000CCBD0 File Offset: 0x000CADD0
		[DebuggerNonUserCode]
		public bool Equals(DebugCombatActorInfo other)
		{
			bool flag = other == null;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				bool flag3 = other == this;
				if (flag3)
				{
					flag2 = true;
				}
				else
				{
					bool flag4 = this.GameAccountId != other.GameAccountId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.AcdName != other.AcdName;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ActorSno != other.ActorSno;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.PlayerOrPet != other.PlayerOrPet;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Level != other.Level;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.WeaponDamage != other.WeaponDamage;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.PlayerArmor != other.PlayerArmor;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.ItemPower != other.ItemPower;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.MaxHp, other.MaxHp);
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.MonsterRarity != other.MonsterRarity;
														flag2 = !flag13 && object.Equals(this._unknownFields, other._unknownFields);
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
			}
			return flag2;
		}

		// Token: 0x060033CF RID: 13263 RVA: 0x000CCD3C File Offset: 0x000CAF3C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool hasAcdName = this.HasAcdName;
			if (hasAcdName)
			{
				num ^= this.AcdName.GetHashCode();
			}
			bool hasActorSno = this.HasActorSno;
			if (hasActorSno)
			{
				num ^= this.ActorSno.GetHashCode();
			}
			bool hasPlayerOrPet = this.HasPlayerOrPet;
			if (hasPlayerOrPet)
			{
				num ^= this.PlayerOrPet.GetHashCode();
			}
			bool hasLevel = this.HasLevel;
			if (hasLevel)
			{
				num ^= this.Level.GetHashCode();
			}
			bool hasWeaponDamage = this.HasWeaponDamage;
			if (hasWeaponDamage)
			{
				num ^= this.WeaponDamage.GetHashCode();
			}
			bool hasPlayerArmor = this.HasPlayerArmor;
			if (hasPlayerArmor)
			{
				num ^= this.PlayerArmor.GetHashCode();
			}
			bool hasItemPower = this.HasItemPower;
			if (hasItemPower)
			{
				num ^= this.ItemPower.GetHashCode();
			}
			bool hasMaxHp = this.HasMaxHp;
			if (hasMaxHp)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.MaxHp);
			}
			bool hasMonsterRarity = this.HasMonsterRarity;
			if (hasMonsterRarity)
			{
				num ^= this.MonsterRarity.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060033D0 RID: 13264 RVA: 0x000CCE98 File Offset: 0x000CB098
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060033D1 RID: 13265 RVA: 0x000CCEB0 File Offset: 0x000CB0B0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060033D2 RID: 13266 RVA: 0x000CCEBC File Offset: 0x000CB0BC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GameAccountId);
			}
			bool hasAcdName = this.HasAcdName;
			if (hasAcdName)
			{
				output.WriteRawTag(18);
				output.WriteString(this.AcdName);
			}
			bool hasActorSno = this.HasActorSno;
			if (hasActorSno)
			{
				output.WriteRawTag(29);
				output.WriteSFixed32(this.ActorSno);
			}
			bool hasPlayerOrPet = this.HasPlayerOrPet;
			if (hasPlayerOrPet)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.PlayerOrPet);
			}
			bool hasLevel = this.HasLevel;
			if (hasLevel)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Level);
			}
			bool hasWeaponDamage = this.HasWeaponDamage;
			if (hasWeaponDamage)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.WeaponDamage);
			}
			bool hasPlayerArmor = this.HasPlayerArmor;
			if (hasPlayerArmor)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PlayerArmor);
			}
			bool hasItemPower = this.HasItemPower;
			if (hasItemPower)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ItemPower);
			}
			bool hasMaxHp = this.HasMaxHp;
			if (hasMaxHp)
			{
				output.WriteRawTag(77);
				output.WriteFloat(this.MaxHp);
			}
			bool hasMonsterRarity = this.HasMonsterRarity;
			if (hasMonsterRarity)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.MonsterRarity);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060033D3 RID: 13267 RVA: 0x000CD048 File Offset: 0x000CB248
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			bool hasAcdName = this.HasAcdName;
			if (hasAcdName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AcdName);
			}
			bool hasActorSno = this.HasActorSno;
			if (hasActorSno)
			{
				num += 5;
			}
			bool hasPlayerOrPet = this.HasPlayerOrPet;
			if (hasPlayerOrPet)
			{
				num += 2;
			}
			bool hasLevel = this.HasLevel;
			if (hasLevel)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			bool hasWeaponDamage = this.HasWeaponDamage;
			if (hasWeaponDamage)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponDamage);
			}
			bool hasPlayerArmor = this.HasPlayerArmor;
			if (hasPlayerArmor)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerArmor);
			}
			bool hasItemPower = this.HasItemPower;
			if (hasItemPower)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemPower);
			}
			bool hasMaxHp = this.HasMaxHp;
			if (hasMaxHp)
			{
				num += 5;
			}
			bool hasMonsterRarity = this.HasMonsterRarity;
			if (hasMonsterRarity)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MonsterRarity);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060033D4 RID: 13268 RVA: 0x000CD180 File Offset: 0x000CB380
		[DebuggerNonUserCode]
		public void MergeFrom(DebugCombatActorInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				bool hasAcdName = other.HasAcdName;
				if (hasAcdName)
				{
					this.AcdName = other.AcdName;
				}
				bool hasActorSno = other.HasActorSno;
				if (hasActorSno)
				{
					this.ActorSno = other.ActorSno;
				}
				bool hasPlayerOrPet = other.HasPlayerOrPet;
				if (hasPlayerOrPet)
				{
					this.PlayerOrPet = other.PlayerOrPet;
				}
				bool hasLevel = other.HasLevel;
				if (hasLevel)
				{
					this.Level = other.Level;
				}
				bool hasWeaponDamage = other.HasWeaponDamage;
				if (hasWeaponDamage)
				{
					this.WeaponDamage = other.WeaponDamage;
				}
				bool hasPlayerArmor = other.HasPlayerArmor;
				if (hasPlayerArmor)
				{
					this.PlayerArmor = other.PlayerArmor;
				}
				bool hasItemPower = other.HasItemPower;
				if (hasItemPower)
				{
					this.ItemPower = other.ItemPower;
				}
				bool hasMaxHp = other.HasMaxHp;
				if (hasMaxHp)
				{
					this.MaxHp = other.MaxHp;
				}
				bool hasMonsterRarity = other.HasMonsterRarity;
				if (hasMonsterRarity)
				{
					this.MonsterRarity = other.MonsterRarity;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060033D5 RID: 13269 RVA: 0x000CD2BB File Offset: 0x000CB4BB
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060033D6 RID: 13270 RVA: 0x000CD2C8 File Offset: 0x000CB4C8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 40U)
				{
					if (num3 <= 18U)
					{
						if (num3 != 8U)
						{
							if (num3 != 18U)
							{
								goto IL_007A;
							}
							this.AcdName = input.ReadString();
						}
						else
						{
							this.GameAccountId = input.ReadUInt32();
						}
					}
					else if (num3 != 29U)
					{
						if (num3 != 32U)
						{
							if (num3 != 40U)
							{
								goto IL_007A;
							}
							this.Level = input.ReadInt32();
						}
						else
						{
							this.PlayerOrPet = input.ReadBool();
						}
					}
					else
					{
						this.ActorSno = input.ReadSFixed32();
					}
				}
				else if (num3 <= 56U)
				{
					if (num3 != 48U)
					{
						if (num3 != 56U)
						{
							goto IL_007A;
						}
						this.PlayerArmor = input.ReadInt32();
					}
					else
					{
						this.WeaponDamage = input.ReadInt32();
					}
				}
				else if (num3 != 64U)
				{
					if (num3 != 77U)
					{
						if (num3 != 80U)
						{
							goto IL_007A;
						}
						this.MonsterRarity = input.ReadInt32();
					}
					else
					{
						this.MaxHp = input.ReadFloat();
					}
				}
				else
				{
					this.ItemPower = input.ReadInt32();
				}
				continue;
				IL_007A:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040017D2 RID: 6098
		private static readonly MessageParser<DebugCombatActorInfo> _parser = new MessageParser<DebugCombatActorInfo>(() => new DebugCombatActorInfo());

		// Token: 0x040017D3 RID: 6099
		private UnknownFieldSet _unknownFields;

		// Token: 0x040017D4 RID: 6100
		private int _hasBits0;

		// Token: 0x040017D5 RID: 6101
		public const int GameAccountIdFieldNumber = 1;

		// Token: 0x040017D6 RID: 6102
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x040017D7 RID: 6103
		private uint gameAccountId_;

		// Token: 0x040017D8 RID: 6104
		public const int AcdNameFieldNumber = 2;

		// Token: 0x040017D9 RID: 6105
		private static readonly string AcdNameDefaultValue = "";

		// Token: 0x040017DA RID: 6106
		private string acdName_;

		// Token: 0x040017DB RID: 6107
		public const int ActorSnoFieldNumber = 3;

		// Token: 0x040017DC RID: 6108
		private static readonly int ActorSnoDefaultValue = 0;

		// Token: 0x040017DD RID: 6109
		private int actorSno_;

		// Token: 0x040017DE RID: 6110
		public const int PlayerOrPetFieldNumber = 4;

		// Token: 0x040017DF RID: 6111
		private static readonly bool PlayerOrPetDefaultValue = false;

		// Token: 0x040017E0 RID: 6112
		private bool playerOrPet_;

		// Token: 0x040017E1 RID: 6113
		public const int LevelFieldNumber = 5;

		// Token: 0x040017E2 RID: 6114
		private static readonly int LevelDefaultValue = 0;

		// Token: 0x040017E3 RID: 6115
		private int level_;

		// Token: 0x040017E4 RID: 6116
		public const int WeaponDamageFieldNumber = 6;

		// Token: 0x040017E5 RID: 6117
		private static readonly int WeaponDamageDefaultValue = 0;

		// Token: 0x040017E6 RID: 6118
		private int weaponDamage_;

		// Token: 0x040017E7 RID: 6119
		public const int PlayerArmorFieldNumber = 7;

		// Token: 0x040017E8 RID: 6120
		private static readonly int PlayerArmorDefaultValue = 0;

		// Token: 0x040017E9 RID: 6121
		private int playerArmor_;

		// Token: 0x040017EA RID: 6122
		public const int ItemPowerFieldNumber = 8;

		// Token: 0x040017EB RID: 6123
		private static readonly int ItemPowerDefaultValue = 0;

		// Token: 0x040017EC RID: 6124
		private int itemPower_;

		// Token: 0x040017ED RID: 6125
		public const int MaxHpFieldNumber = 9;

		// Token: 0x040017EE RID: 6126
		private static readonly float MaxHpDefaultValue = 0f;

		// Token: 0x040017EF RID: 6127
		private float maxHp_;

		// Token: 0x040017F0 RID: 6128
		public const int MonsterRarityFieldNumber = 10;

		// Token: 0x040017F1 RID: 6129
		private static readonly int MonsterRarityDefaultValue = 0;

		// Token: 0x040017F2 RID: 6130
		private int monsterRarity_;
	}
}
