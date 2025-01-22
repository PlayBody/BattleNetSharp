using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using D2Data;
using D2Data.Generated;
using Utilities;

namespace D2Packets.Game.Server
{
	// Token: 0x020009BF RID: 2495
	public class ItemAction : Packet
	{
		// Token: 0x0600BAD0 RID: 47824 RVA: 0x0046D91C File Offset: 0x0046BB1C
		public override string ToString()
		{
			string[] array = new string[13];
			int num = 0;
			BaseItem baseItem = this.baseItem;
			array[num] = ((baseItem != null) ? baseItem.ToString() : null);
			array[1] = " : ";
			array[2] = this.x.ToString();
			array[3] = ", ";
			array[4] = this.y.ToString();
			array[5] = ", ";
			array[6] = this.action.ToString();
			array[7] = ", ";
			array[8] = this.destination.ToString();
			array[9] = ", ";
			array[10] = this.flags.ToString();
			array[11] = " : ";
			array[12] = this.OwnerId.ToString("X");
			return string.Concat(array);
		}

		// Token: 0x1700391C RID: 14620
		public StatBase this[StatType stat]
		{
			get
			{
				StatBase statBase = this.mods.FirstOrDefault((StatBase s) => s.BaseStat.Type == stat);
				bool flag = statBase != null;
				StatBase statBase2;
				if (flag)
				{
					statBase2 = statBase;
				}
				else
				{
					statBase = this.runewordMods.FirstOrDefault((StatBase s) => s.BaseStat.Type == stat);
					bool flag2 = statBase != null;
					if (flag2)
					{
						statBase2 = statBase;
					}
					else
					{
						statBase = this.stats.FirstOrDefault((StatBase s) => s.BaseStat.Type == stat);
						bool flag3 = statBase != null;
						if (flag3)
						{
							statBase2 = statBase;
						}
						else
						{
							statBase2 = null;
						}
					}
				}
				return statBase2;
			}
		}

		// Token: 0x0600BAD2 RID: 47826 RVA: 0x0046DA80 File Offset: 0x0046BC80
		public string GetChar(BitReader reader)
		{
			string bitstring = "";
			bool flag;
			do
			{
				bitstring += (reader.ReadBit() ? "1" : "0");
				flag = ItemAction.huffmanTable.ContainsValue(bitstring);
			}
			while (!flag);
			return ItemAction.huffmanTable.First((KeyValuePair<string, string> h) => h.Value == bitstring).Key;
		}

		// Token: 0x0600BAD3 RID: 47827 RVA: 0x0046DB04 File Offset: 0x0046BD04
		public string GetCode(BitReader reader)
		{
			return this.GetChar(reader) + this.GetChar(reader) + this.GetChar(reader) + this.GetChar(reader);
		}

		// Token: 0x0600BAD4 RID: 47828 RVA: 0x0046DB38 File Offset: 0x0046BD38
		public void WriteCode(BitWriter writer, string code)
		{
			for (int i = 0; i < 4; i++)
			{
				char c = ((i >= code.Length) ? ' ' : code[i]);
				string text = ItemAction.huffmanTable[char.ToString(c)];
				foreach (char c2 in text)
				{
					writer.Write(c2 != '0');
				}
			}
		}

		// Token: 0x0600BAD5 RID: 47829 RVA: 0x0046DBB4 File Offset: 0x0046BDB4
		public static string ReadString(BitReader reader, int length = -1)
		{
			List<byte> list = new List<byte>();
			bool flag = length == -1;
			if (flag)
			{
				byte b;
				do
				{
					b = reader.ReadByte();
					list.Add(b);
				}
				while (b > 0);
			}
			else
			{
				for (int i = 0; i < length; i++)
				{
					byte b2 = (byte)reader.ReadBits(7);
					list.Add(b2);
					bool flag2 = b2 == 0;
					if (flag2)
					{
						break;
					}
				}
			}
			IEnumerable<byte> enumerable = list.Take(list.Count<byte>() - 1);
			return Encoding.ASCII.GetString(enumerable.ToArray<byte>());
		}

		// Token: 0x0600BAD6 RID: 47830 RVA: 0x0046DC50 File Offset: 0x0046BE50
		public override void FromBytes(byte[] Bytes)
		{
			BitReader reader = new BitReader(Bytes, 0);
			this.superiorType = SuperiorItemType.NotApplicable;
			this.charClass = CharacterClass.NotApplicable;
			this.level = ushort.MaxValue;
			this.m_usedSockets = ushort.MaxValue;
			this.use = ushort.MaxValue;
			this.graphic = ushort.MaxValue;
			this.color = ushort.MaxValue;
			this.stats = new List<StatBase>();
			this.m_unknown1 = 65535;
			this.runewordID = ushort.MaxValue;
			this.runewordParam = ushort.MaxValue;
			this.SaveFormat = false;
			this.PacketId = (GameServerPacket)reader.ReadByte();
			this.action = (ItemActionType)reader.ReadByte();
			this.Length = reader.ReadByte();
			this.category = (ItemCategory)reader.ReadByte();
			this.Id = reader.ReadUInt32();
			bool flag = this.Id == 3735928559U;
			if (flag)
			{
				this.SaveFormat = true;
			}
			bool flag2 = this.PacketId == GameServerPacket.OwnedItemAction;
			if (flag2)
			{
				this.OwnerType = (UnitType)reader.ReadBits(8);
			}
			bool flag3 = this.PacketId == GameServerPacket.OwnedItemAction;
			if (flag3)
			{
				this.OwnerId = (uint)reader.ReadBits(32);
			}
			this.flags = (ItemFlags)reader.ReadUInt32();
			this.version = (ItemVersion)reader.ReadBits(10);
			this.destination = (ItemDestination)reader.ReadBits(3);
			bool flag4 = this.destination == ItemDestination.Ground;
			if (flag4)
			{
				this.x = (int)reader.ReadUInt16();
				this.y = (int)reader.ReadUInt16();
				this.container = ItemContainer.Ground;
			}
			else
			{
				this.location = (EquipmentLocation)reader.ReadBits(4);
				this.x = (int)((ushort)reader.ReadBits(4));
				this.y = (int)((ushort)reader.ReadBits(4));
				this.container = (ItemContainer)reader.ReadBits(3);
			}
			bool flag5 = this.action == ItemActionType.AddToShop || this.action == ItemActionType.RemoveFromShop;
			if (flag5)
			{
				int num = (int)(this.container | (ItemContainer)128);
				bool flag6 = (num & 1) == 1;
				if (flag6)
				{
					num--;
				}
			}
			else
			{
				bool flag7 = this.container == ItemContainer.Unspecified;
				if (flag7)
				{
					bool flag8 = this.location == EquipmentLocation.NotApplicable;
					if (flag8)
					{
						bool flag9 = this.flags.HasFlag(ItemFlags.InSocket);
						if (!flag9)
						{
							bool flag10 = this.action == ItemActionType.PutInBelt || this.action == ItemActionType.RemoveFromBelt;
							if (flag10)
							{
							}
						}
					}
				}
			}
			bool flag11 = this.flags.HasFlag(ItemFlags.Ear);
			if (flag11)
			{
				this.charClass = (CharacterClass)reader.ReadBits(3);
				this.level = (ushort)reader.ReadBits(7);
				this.name = ItemAction.ReadString(reader, 16);
				this.baseItem = BaseItem.Get(ItemType.Ear);
			}
			else
			{
				bool d2RTA = this.D2RTA;
				if (d2RTA)
				{
					this.baseItem = BaseItem.GetByCode(this.GetCode(reader).Trim());
				}
				else
				{
					this.baseItem = BaseItem.GetByID(reader.ReadUInt32());
				}
				bool flag12 = this.baseItem.Type == ItemType.Gold;
				if (flag12)
				{
					bool flag13 = reader.ReadBit();
					bool flag14 = flag13;
					if (flag14)
					{
						this.stats.Add(new SignedStat(BaseStat.Get(StatType.Quantity), (int)reader.ReadUInt32()));
					}
					else
					{
						this.stats.Add(new SignedStat(BaseStat.Get(StatType.Quantity), (int)reader.ReadBits(12)));
					}
				}
				else
				{
					this.m_usedSockets = (ushort)reader.ReadBits(this.flags.HasFlag(ItemFlags.Compact) ? 1 : 3);
					bool flag15 = !this.flags.HasFlag(ItemFlags.Compact) && !this.flags.HasFlag(ItemFlags.Gamble);
					if (flag15)
					{
						bool saveFormat = this.SaveFormat;
						if (saveFormat)
						{
							this.Id = reader.ReadUInt32();
						}
						this.level = (ushort)reader.ReadBits(7);
						this.quality = (ItemQuality)reader.ReadBits(4);
						bool flag16 = reader.ReadBit();
						if (flag16)
						{
							this.graphic = (ushort)reader.ReadBits(3);
						}
						bool flag17 = reader.ReadBit();
						if (flag17)
						{
							this.color = (ushort)reader.ReadBits(11);
						}
						bool flag18 = this.flags.HasFlag(ItemFlags.Identified);
						if (flag18)
						{
							switch (this.quality)
							{
							case ItemQuality.Inferior:
								this.prefix = new ItemAffix(ItemAffixType.InferiorPrefix, (int)reader.ReadBits(3));
								break;
							case ItemQuality.Superior:
								this.prefix = new ItemAffix(ItemAffixType.SuperiorPrefix, 0);
								this.superiorType = (SuperiorItemType)reader.ReadBits(3);
								break;
							case ItemQuality.Magic:
								this.prefix = new ItemAffix(ItemAffixType.MagicPrefix, (int)reader.ReadBits(11));
								this.suffix = new ItemAffix(ItemAffixType.MagicSuffix, (int)reader.ReadBits(11));
								break;
							case ItemQuality.Set:
								this.setItem = BaseSetItem.Get((int)reader.ReadBits(12));
								break;
							case ItemQuality.Rare:
							case ItemQuality.Crafted:
								this.prefix = new ItemAffix(ItemAffixType.RarePrefix, (int)reader.ReadByte());
								this.suffix = new ItemAffix(ItemAffixType.RareSuffix, (int)reader.ReadByte());
								break;
							case ItemQuality.Unique:
							{
								bool flag19 = this.baseItem.Code != "std";
								if (flag19)
								{
									try
									{
										this.uniqueItem = BaseUniqueItem.Get((int)reader.ReadBits(12));
									}
									catch (Exception ex)
									{
										Console.WriteLine(ex.Message);
									}
								}
								break;
							}
							}
						}
						bool flag20 = this.quality == ItemQuality.Rare || this.quality == ItemQuality.Crafted;
						if (flag20)
						{
							this.magicPrefixes = new List<MagicPrefixType>();
							this.magicSuffixes = new List<MagicSuffixType>();
							int num2 = 0;
							do
							{
								bool flag21 = reader.ReadBit();
								if (flag21)
								{
									this.magicPrefixes.Add((MagicPrefixType)reader.ReadBits(11));
								}
								bool flag22 = reader.ReadBit();
								if (flag22)
								{
									this.magicSuffixes.Add((MagicSuffixType)reader.ReadBits(11));
								}
								num2++;
							}
							while (num2 <= 2);
						}
						bool flag23 = this.flags.HasFlag(ItemFlags.Runeword);
						if (flag23)
						{
							this.runewordID = (ushort)reader.ReadBits(12);
							this.runewordParam = (ushort)reader.ReadBits(4);
							int num3 = -1;
							bool flag24 = this.runewordParam == 5;
							if (flag24)
							{
								num3 = (int)(this.runewordID - this.runewordParam * 5);
								bool flag25 = num3 < 100;
								if (flag25)
								{
									num3--;
								}
							}
							else
							{
								bool flag26 = this.runewordParam == 2;
								if (flag26)
								{
									num3 = ((this.runewordID & 1023) >> 5) + 2;
								}
							}
							bool flag27 = num3 == -1;
							if (flag27)
							{
								throw new Exception("Unknown Runeword: " + this.runewordParam.ToString());
							}
							this.runeword = BaseRuneword.Get(num3);
						}
						bool flag28 = this.flags.HasFlag(ItemFlags.Personalized);
						if (flag28)
						{
							this.name = ItemAction.ReadString(reader, 16);
						}
						bool saveFormat2 = this.SaveFormat;
						if (saveFormat2)
						{
							reader.ReadBits(1);
						}
						bool flag29 = this.baseItem is BaseArmor;
						if (flag29)
						{
							BaseStat baseStat = BaseStat.Get(StatType.ArmorClass);
							int num4 = (this.D2R_2_5 ? baseStat.SaveBits_2_5 : baseStat.SaveBits);
							int num5 = (this.D2R_2_5 ? baseStat.SaveAdd_2_5 : baseStat.SaveAdd);
							this.armor = new SignedStat(baseStat, (int)reader.ReadBits(num4) - num5);
						}
						bool flag30 = this.baseItem is BaseArmor || this.baseItem is BaseWeapon;
						if (flag30)
						{
							BaseStat baseStat2 = BaseStat.Get(StatType.MaxDurability);
							int num6 = (this.D2R_2_5 ? baseStat2.SaveBits_2_5 : baseStat2.SaveBits);
							int num7 = (this.D2R_2_5 ? baseStat2.SaveAdd_2_5 : baseStat2.SaveAdd);
							int num8 = (int)reader.ReadBits(num6) - num7;
							this.maxDurability = new SignedStat(baseStat2, num8);
							bool flag31 = num8 > 0;
							if (flag31)
							{
								baseStat2 = BaseStat.Get(StatType.Durability);
								num6 = (this.D2R_2_5 ? baseStat2.SaveBits_2_5 : baseStat2.SaveBits);
								num7 = (this.D2R_2_5 ? baseStat2.SaveAdd_2_5 : baseStat2.SaveAdd);
								this.durability = new SignedStat(baseStat2, (int)reader.ReadBits(num6) - num7);
							}
						}
						bool flag32 = this.flags.HasFlag(ItemFlags.Socketed);
						if (flag32)
						{
							BaseStat baseStat3 = BaseStat.Get(StatType.Sockets);
							int num9 = (this.D2R_2_5 ? baseStat3.SaveBits_2_5 : baseStat3.SaveBits);
							int num10 = (this.D2R_2_5 ? baseStat3.SaveAdd_2_5 : baseStat3.SaveAdd);
							this.stats.Add(new SignedStat(baseStat3, (int)reader.ReadBits(num9) - num10));
						}
						bool stackable = this.baseItem.Stackable;
						if (stackable)
						{
							bool useable = this.baseItem.Useable;
							if (useable)
							{
								this.use = (ushort)reader.ReadBits(5);
							}
							this.stats.Add(new SignedStat(BaseStat.Get(StatType.Quantity), (int)reader.ReadBits(9)));
						}
						bool flag33 = this.flags.HasFlag(ItemFlags.Identified);
						if (flag33)
						{
							bool[] array = (from b in Enumerable.Range(0, 5)
								select this.quality == ItemQuality.Set && reader.ReadBit()).ToArray<bool>();
							this.mods = new List<StatBase>();
							this.setBonuses = new List<StatBase>[5];
							StatBase statBase;
							while ((statBase = ItemAction.ReadStat(reader, this.D2R_2_5)) != null && this.mods.Count < 30)
							{
								this.mods.Add(statBase);
							}
							bool flag34 = this.mods.Count > 25;
							if (flag34)
							{
								string text = "fail parse item :";
								BaseItem baseItem = this.baseItem;
								Console.WriteLine(text + ((baseItem != null) ? baseItem.ToString() : null));
								return;
							}
							bool flag35 = this.flags.HasFlag(ItemFlags.Runeword);
							if (flag35)
							{
								this.runewordMods = new List<StatBase>();
								while ((statBase = ItemAction.ReadStat(reader, this.D2R_2_5)) != null)
								{
									this.runewordMods.Add(statBase);
								}
							}
							bool flag36 = this.quality == ItemQuality.Set;
							if (flag36)
							{
								for (int i = 0; i < array.Length; i++)
								{
									bool flag37 = array[i];
									if (flag37)
									{
										this.setBonuses[i] = new List<StatBase>();
										while ((statBase = ItemAction.ReadStat(reader, this.D2R_2_5)) != null)
										{
											this.setBonuses[i].Add(statBase);
										}
									}
								}
							}
						}
					}
				}
			}
			bool flag38 = reader.BitsLeft % 8 > 0;
			if (flag38)
			{
				int num11 = (int)reader.ReadBits(reader.BitsLeft % 8);
			}
			bool flag39 = reader.Position != (int)this.Length << 3 && !this.SaveFormat;
			if (flag39)
			{
				Console.WriteLine("bad item action : " + ((int)this.Length << 3).ToString() + " only read : " + reader.Position.ToString());
			}
		}

		// Token: 0x0600BAD7 RID: 47831 RVA: 0x0046E918 File Offset: 0x0046CB18
		public override byte[] ToArray()
		{
			this.memoryStream = new MemoryStream();
			BitWriter bitWriter = new BitWriter(this.memoryStream);
			bool flag = !this.SaveFormat;
			if (flag)
			{
				bitWriter.Write((byte)this.PacketId);
				bitWriter.Write((byte)this.action);
				bitWriter.Write(this.Length);
				bitWriter.Write((byte)this.category);
				bitWriter.Write(this.Id);
				bool flag2 = this.PacketId == GameServerPacket.OwnedItemAction;
				if (flag2)
				{
					bitWriter.WriteBits((uint)this.OwnerType, 8);
				}
				bool flag3 = this.PacketId == GameServerPacket.OwnedItemAction;
				if (flag3)
				{
					bitWriter.WriteBits(this.OwnerId, 32);
				}
			}
			bitWriter.Write((uint)this.flags);
			bitWriter.WriteBits((uint)this.version, (this.D2RTA && this.SaveFormat) ? 3 : 10);
			bitWriter.WriteBits((uint)this.destination, 3);
			bool flag4 = this.destination == ItemDestination.Ground;
			if (flag4)
			{
				bitWriter.Write((ushort)this.x);
				bitWriter.Write((ushort)this.y);
			}
			else
			{
				bitWriter.WriteBits((uint)this.location, 4);
				bitWriter.WriteBits((uint)this.x, 4);
				bitWriter.WriteBits((uint)this.y, 4);
				bitWriter.WriteBits((uint)this.container, 3);
			}
			bool flag5 = this.container == ItemContainer.Unspecified;
			if (flag5)
			{
				bool flag6 = this.location == EquipmentLocation.NotApplicable;
				if (flag6)
				{
					bool flag7 = (this.flags & ItemFlags.InSocket) == ItemFlags.InSocket;
					if (!flag7)
					{
						bool flag8 = this.action == ItemActionType.PutInBelt || this.action == ItemActionType.RemoveFromBelt;
						if (flag8)
						{
						}
					}
				}
			}
			bool flag9 = this.flags.HasFlag(ItemFlags.Ear);
			if (flag9)
			{
				bitWriter.WriteBits((uint)this.charClass, 3);
				bitWriter.WriteBits((uint)this.level, 7);
				foreach (char c in this.name)
				{
					bitWriter.WriteBits((uint)c, 7);
				}
				bitWriter.WriteBits(0U, 7);
			}
			else
			{
				bool d2RTA = this.D2RTA;
				if (d2RTA)
				{
					this.WriteCode(bitWriter, this.baseItem.Code);
				}
				else
				{
					bitWriter.Write(this.baseItem.ID);
				}
				bool flag10 = this.baseItem.Type == ItemType.Gold;
				if (flag10)
				{
					int value = ((SignedStat)this.stats[0]).Value;
					bool flag11 = value >= 4096;
					bitWriter.Write(flag11);
					bool flag12 = flag11;
					if (flag12)
					{
						bitWriter.WriteBits((uint)value, 32);
					}
					else
					{
						bitWriter.WriteBits((uint)value, 12);
					}
				}
				else
				{
					bitWriter.WriteBits((uint)this.m_usedSockets, this.flags.HasFlag(ItemFlags.Compact) ? 1 : 3);
					bool flag13 = (this.flags & (ItemFlags.Compact | ItemFlags.Gamble)) == ItemFlags.None;
					if (flag13)
					{
						bool saveFormat = this.SaveFormat;
						if (saveFormat)
						{
							bitWriter.Write(this.Id);
						}
						bitWriter.WriteBits((uint)this.level, 7);
						bitWriter.WriteBits((uint)this.quality, 4);
						bitWriter.Write(this.graphic != ushort.MaxValue);
						bool flag14 = this.graphic != ushort.MaxValue;
						if (flag14)
						{
							bitWriter.WriteBits((uint)this.graphic, 3);
						}
						bitWriter.Write(this.color != ushort.MaxValue);
						bool flag15 = this.color != ushort.MaxValue;
						if (flag15)
						{
							bitWriter.WriteBits((uint)this.color, 11);
						}
						bool flag16 = (this.flags & ItemFlags.Identified) == ItemFlags.Identified;
						if (flag16)
						{
							switch (this.quality)
							{
							case ItemQuality.Inferior:
								bitWriter.WriteBits((uint)this.prefix.Index, 3);
								break;
							case ItemQuality.Superior:
								bitWriter.WriteBits((uint)this.superiorType, 3);
								break;
							case ItemQuality.Magic:
								bitWriter.WriteBits((uint)this.prefix.Index, 11);
								bitWriter.WriteBits((uint)this.suffix.Index, 11);
								break;
							case ItemQuality.Set:
								bitWriter.WriteBits((uint)this.setItem.Index, 12);
								break;
							case ItemQuality.Rare:
							case ItemQuality.Crafted:
								bitWriter.Write((byte)this.prefix.Index);
								bitWriter.Write((byte)this.suffix.Index);
								break;
							case ItemQuality.Unique:
							{
								bool flag17 = this.baseItem.Code != "std";
								if (flag17)
								{
									bitWriter.WriteBits((uint)this.uniqueItem.Index, 12);
								}
								break;
							}
							}
						}
						bool flag18 = this.quality == ItemQuality.Rare || this.quality == ItemQuality.Crafted;
						if (flag18)
						{
							for (int j = 0; j < 3; j++)
							{
								bool flag19 = this.magicPrefixes.Count > j;
								if (flag19)
								{
									MagicPrefixType magicPrefixType = this.magicPrefixes[j];
									bitWriter.Write(true);
									bitWriter.WriteBits((uint)this.magicPrefixes[j], 11);
								}
								else
								{
									bitWriter.Write(false);
								}
								bool flag20 = this.magicSuffixes.Count > j;
								if (flag20)
								{
									MagicSuffixType magicSuffixType = this.magicSuffixes[j];
									bitWriter.Write(true);
									bitWriter.WriteBits((uint)this.magicSuffixes[j], 11);
								}
								else
								{
									bitWriter.Write(false);
								}
							}
						}
						bool flag21 = (this.flags & ItemFlags.Runeword) == ItemFlags.Runeword;
						if (flag21)
						{
							bitWriter.WriteBits((uint)this.runewordID, 12);
							bitWriter.WriteBits((uint)this.runewordParam, 4);
						}
						bool flag22 = (this.flags & ItemFlags.Personalized) == ItemFlags.Personalized;
						if (flag22)
						{
							foreach (char c2 in this.name)
							{
								bitWriter.WriteBits((uint)c2, 7);
							}
							bitWriter.WriteBits(0U, 7);
						}
						bool saveFormat2 = this.SaveFormat;
						if (saveFormat2)
						{
							bitWriter.Write(false);
						}
						bool flag23 = this.baseItem is BaseArmor;
						if (flag23)
						{
							BaseStat baseStat = BaseStat.Get(StatType.ArmorClass);
							SignedStat signedStat = this.armor;
							int num = (this.D2R_2_5 ? baseStat.SaveBits_2_5 : baseStat.SaveBits);
							int num2 = (this.D2R_2_5 ? baseStat.SaveAdd_2_5 : baseStat.SaveAdd);
							bitWriter.WriteBits((uint)(signedStat.Value + num2), num);
						}
						bool flag24 = this.baseItem is BaseArmor || this.baseItem is BaseWeapon;
						if (flag24)
						{
							BaseStat baseStat2 = BaseStat.Get(StatType.MaxDurability);
							int num3 = (this.D2R_2_5 ? baseStat2.SaveBits_2_5 : baseStat2.SaveBits);
							SignedStat signedStat2 = this.maxDurability;
							bitWriter.WriteBits((uint)signedStat2.Value, num3);
							bool flag25 = signedStat2.Value > 0;
							if (flag25)
							{
								baseStat2 = BaseStat.Get(StatType.Durability);
								num3 = (this.D2R_2_5 ? baseStat2.SaveBits_2_5 : baseStat2.SaveBits);
								signedStat2 = this.durability;
								bitWriter.WriteBits((uint)signedStat2.Value, num3);
							}
						}
						bool flag26 = (this.flags & ItemFlags.Socketed) == ItemFlags.Socketed;
						if (flag26)
						{
							BaseStat baseStat3 = BaseStat.Get(StatType.Sockets);
							int num4 = (this.D2R_2_5 ? baseStat3.SaveBits_2_5 : baseStat3.SaveBits);
							SignedStat signedStat3 = (SignedStat)this[StatType.Sockets];
							bitWriter.WriteBits((uint)signedStat3.Value, num4);
						}
						bool stackable = this.baseItem.Stackable;
						if (stackable)
						{
							bool useable = this.baseItem.Useable;
							if (useable)
							{
								bitWriter.WriteBits((uint)this.use, 5);
							}
							BaseStat baseStat4 = BaseStat.Get(StatType.Quantity);
							SignedStat signedStat4 = (SignedStat)this[StatType.Quantity];
							bitWriter.WriteBits((uint)signedStat4.Value, 9);
						}
						bool flag27 = (this.flags & ItemFlags.Identified) == ItemFlags.Identified;
						if (flag27)
						{
							bool flag28 = this.quality == ItemQuality.Set;
							if (flag28)
							{
								for (int l = 0; l < 5; l++)
								{
									bitWriter.Write(this.setBonuses[l] != null);
								}
							}
							foreach (StatBase statBase in this.mods)
							{
								ItemAction.WriteStat(bitWriter, statBase, this.D2R_2_5);
							}
							bitWriter.WriteBits(511U, 9);
							bool flag29 = (this.flags & ItemFlags.Runeword) == ItemFlags.Runeword;
							if (flag29)
							{
								foreach (StatBase statBase2 in this.runewordMods)
								{
									ItemAction.WriteStat(bitWriter, statBase2, this.D2R_2_5);
								}
								bitWriter.WriteBits(511U, 9);
							}
							bool flag30 = this.quality == ItemQuality.Set;
							if (flag30)
							{
								foreach (List<StatBase> list in this.setBonuses)
								{
									bool flag31 = list == null;
									if (!flag31)
									{
										foreach (StatBase statBase3 in list)
										{
											ItemAction.WriteStat(bitWriter, statBase3, this.D2R_2_5);
										}
										bitWriter.WriteBits(511U, 9);
									}
								}
							}
						}
					}
				}
			}
			bitWriter.Flush();
			byte[] array2 = this.memoryStream.ToArray();
			this.Length = (byte)array2.Length;
			bool flag32 = !this.SaveFormat;
			if (flag32)
			{
				array2[2] = this.Length;
			}
			return array2;
		}

		// Token: 0x0600BAD8 RID: 47832 RVA: 0x0046F35C File Offset: 0x0046D55C
		public static StatBase ReadStat(BitReader br, bool is_2_5)
		{
			int num = (int)br.ReadBits(9);
			bool flag = num == 511;
			StatBase statBase;
			if (flag)
			{
				statBase = null;
			}
			else
			{
				BaseStat baseStat = BaseStat.Get(num);
				int num2 = (is_2_5 ? baseStat.SaveBits_2_5 : baseStat.SaveBits);
				int num3 = (is_2_5 ? baseStat.SaveAdd_2_5 : baseStat.SaveAdd);
				bool flag2 = baseStat.SaveParamBits == -1;
				if (flag2)
				{
					bool flag3 = baseStat.OpBase == StatType.Level;
					if (flag3)
					{
						statBase = new PerLevelStat(baseStat, (int)br.ReadBits(num2));
					}
					else
					{
						StatType type = baseStat.Type;
						bool flag4 = type == StatType.MaxDamagePercent || type == StatType.MinDamagePercent;
						if (flag4)
						{
							statBase = new DamageRangeStat(baseStat, (int)br.ReadBits(num2), (int)br.ReadBits(num2));
						}
						else
						{
							bool flag5 = type == StatType.FireMinDamage || type == StatType.LightMinDamage || type == StatType.MagicMinDamage;
							if (flag5)
							{
								statBase = new DamageRangeStat(baseStat, (int)br.ReadBits(num2), (int)br.ReadBits(BaseStat.Get(baseStat.Index + 1).SaveBits));
							}
							else
							{
								bool flag6 = type != StatType.FireMaxDamage && type != StatType.LightMaxDamage && type != StatType.MagicMaxDamage;
								if (flag6)
								{
									bool flag7 = type == StatType.ColdMinDamage;
									if (flag7)
									{
										return new ColdDamageStat(baseStat, (int)br.ReadBits(baseStat.SaveBits), (int)br.ReadBits(BaseStat.Get(StatType.ColdMaxDamage).SaveBits), (int)br.ReadBits(BaseStat.Get(StatType.ColdLength).SaveBits));
									}
									bool flag8 = type == StatType.ReplenishDurability || type == StatType.ReplenishQuantity;
									if (flag8)
									{
										return new ReplenishStat(baseStat, (int)br.ReadBits(baseStat.SaveBits));
									}
									bool flag9 = type == StatType.PoisonMinDamage;
									if (flag9)
									{
										return new PoisonDamageStat(baseStat, (int)br.ReadBits(baseStat.SaveBits), (int)br.ReadBits(BaseStat.Get(StatType.PoisonMaxDamage).SaveBits), (int)br.ReadBits(BaseStat.Get(StatType.PoisonLength).SaveBits));
									}
								}
								bool signed = baseStat.Signed;
								if (signed)
								{
									int num4 = (int)br.ReadBits(num2);
									bool flag10 = num3 > 0;
									if (flag10)
									{
										num4 -= num3;
									}
									statBase = new SignedStat(baseStat, num4);
								}
								else
								{
									uint num5 = (uint)((ushort)br.ReadBits(num2));
									bool flag11 = num3 > 0;
									if (flag11)
									{
										num5 = (uint)((ulong)num5 - (ulong)((long)num3));
									}
									statBase = new UnsignedStat(baseStat, num5);
								}
							}
						}
					}
				}
				else
				{
					StatType type2 = baseStat.Type;
					bool flag12 = type2 == StatType.SingleSkill || type2 == StatType.NonClassSkill;
					if (flag12)
					{
						statBase = new SkillBonusStat(baseStat, (int)br.ReadBits(baseStat.SaveParamBits), (int)br.ReadBits(baseStat.SaveBits));
					}
					else
					{
						bool flag13 = type2 == StatType.ElementalSkillBonus;
						if (flag13)
						{
							statBase = new ElementalSkillsBonusStat(baseStat, (int)br.ReadBits(baseStat.SaveParamBits), (int)br.ReadBits(baseStat.SaveBits));
						}
						else
						{
							bool flag14 = type2 == StatType.ClassSkillsBonus;
							if (flag14)
							{
								statBase = new ClassSkillsBonusStat(baseStat, (int)br.ReadBits(baseStat.SaveParamBits), (int)br.ReadBits(baseStat.SaveBits));
							}
							else
							{
								bool flag15 = type2 == StatType.Aura;
								if (flag15)
								{
									statBase = new AuraStat(baseStat, (int)br.ReadBits(baseStat.SaveParamBits), (int)br.ReadBits(baseStat.SaveBits));
								}
								else
								{
									bool flag16 = type2 == StatType.Reanimate;
									if (flag16)
									{
										statBase = new ReanimateStat(baseStat, (uint)br.ReadBits(baseStat.SaveParamBits), (uint)br.ReadBits(baseStat.SaveBits));
									}
									else
									{
										bool flag17 = type2 == StatType.SkillOnAttack || type2 == StatType.SkillOnKill || type2 == StatType.SkillOnDeath || type2 == StatType.SkillOnStriking || type2 == StatType.SkillOnLevelUp || type2 == StatType.SkillOnGetHit;
										if (flag17)
										{
											statBase = new SkillOnEventStat(baseStat, (int)br.ReadBits(6), (int)br.ReadBits(10), (int)br.ReadBits(baseStat.SaveBits));
										}
										else
										{
											bool flag18 = type2 == StatType.ChargedSkill;
											if (flag18)
											{
												statBase = new ChargedSkillStat(baseStat, (int)br.ReadBits(6), (int)br.ReadBits(10), (int)br.ReadBits(8), (int)br.ReadBits(8));
											}
											else
											{
												bool flag19 = type2 == StatType.SkillTabBonus;
												if (!flag19)
												{
													throw new Exception("Invalid stat: " + baseStat.Index.ToString());
												}
												statBase = new SkillTabBonusStat(baseStat, (int)br.ReadBits(3), (int)br.ReadBits(3), (int)br.ReadBits(10), (int)br.ReadBits(baseStat.SaveBits));
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return statBase;
		}

		// Token: 0x0600BAD9 RID: 47833 RVA: 0x0046F7DC File Offset: 0x0046D9DC
		public static void WriteStat(BitWriter bw, StatBase stat, bool is_2_5)
		{
			bw.WriteBits((uint)stat.BaseStat.Index, 9);
			BaseStat baseStat = stat.BaseStat;
			int num = (is_2_5 ? baseStat.SaveBits_2_5 : baseStat.SaveBits);
			int num2 = (is_2_5 ? baseStat.SaveAdd_2_5 : baseStat.SaveAdd);
			bool flag = baseStat.SaveParamBits == -1;
			if (flag)
			{
				StatType type = baseStat.Type;
				bool flag2 = baseStat.OpBase == StatType.Level;
				if (flag2)
				{
					bw.WriteBits((uint)((PerLevelStat)stat).Value, num);
				}
				else
				{
					bool flag3 = type == StatType.MaxDamagePercent || type == StatType.MinDamagePercent;
					if (flag3)
					{
						bw.WriteBits((uint)((DamageRangeStat)stat).Min, num);
						bw.WriteBits((uint)((DamageRangeStat)stat).Max, num);
					}
					else
					{
						bool flag4 = type == StatType.FireMinDamage || type == StatType.LightMinDamage || type == StatType.MagicMinDamage;
						if (flag4)
						{
							bw.WriteBits((uint)((DamageRangeStat)stat).Min, num);
							bw.WriteBits((uint)((DamageRangeStat)stat).Max, BaseStat.Get(baseStat.Index + 1).SaveBits);
						}
						else
						{
							bool flag5 = type == StatType.ColdMinDamage;
							if (flag5)
							{
								bw.WriteBits((uint)((ColdDamageStat)stat).Min, baseStat.SaveBits);
								bw.WriteBits((uint)((ColdDamageStat)stat).Max, BaseStat.Get(StatType.ColdMaxDamage).SaveBits);
								bw.WriteBits((uint)((ColdDamageStat)stat).Frames, BaseStat.Get(StatType.ColdLength).SaveBits);
							}
							else
							{
								bool flag6 = type == StatType.ReplenishDurability || type == StatType.ReplenishQuantity;
								if (flag6)
								{
									bw.WriteBits((uint)((ReplenishStat)stat).Value, baseStat.SaveBits);
								}
								else
								{
									bool flag7 = type == StatType.PoisonMinDamage;
									if (flag7)
									{
										bw.WriteBits((uint)((PoisonDamageStat)stat).Min, baseStat.SaveBits);
										bw.WriteBits((uint)((PoisonDamageStat)stat).Max, BaseStat.Get(StatType.PoisonMaxDamage).SaveBits);
										bw.WriteBits((uint)((PoisonDamageStat)stat).Frames, BaseStat.Get(StatType.PoisonLength).SaveBits);
									}
									else
									{
										bool signed = baseStat.Signed;
										if (signed)
										{
											int num3 = ((SignedStat)stat).Value;
											bool flag8 = num2 > 0;
											if (flag8)
											{
												num3 += num2;
											}
											bw.WriteBits((uint)num3, num);
										}
										else
										{
											uint num4 = ((UnsignedStat)stat).Value;
											bool flag9 = num2 > 0;
											if (flag9)
											{
												num4 += (uint)num2;
											}
											bw.WriteBits(num4, num);
										}
									}
								}
							}
						}
					}
				}
			}
			else
			{
				StatType type2 = baseStat.Type;
				bool flag10 = type2 == StatType.SingleSkill || type2 == StatType.NonClassSkill;
				if (flag10)
				{
					bw.WriteBits((uint)((SkillBonusStat)stat).Skill, baseStat.SaveParamBits);
					bw.WriteBits((uint)((SkillBonusStat)stat).Value, baseStat.SaveBits);
				}
				else
				{
					bool flag11 = type2 == StatType.ElementalSkillBonus;
					if (flag11)
					{
						bw.WriteBits((uint)((ElementalSkillsBonusStat)stat).Element, baseStat.SaveParamBits);
						bw.WriteBits((uint)((ElementalSkillsBonusStat)stat).Value, baseStat.SaveBits);
					}
					else
					{
						bool flag12 = type2 == StatType.ClassSkillsBonus;
						if (flag12)
						{
							bw.WriteBits((uint)((ClassSkillsBonusStat)stat).Class, baseStat.SaveParamBits);
							bw.WriteBits((uint)((ClassSkillsBonusStat)stat).Value, baseStat.SaveBits);
						}
						else
						{
							bool flag13 = type2 == StatType.Aura;
							if (flag13)
							{
								bw.WriteBits((uint)((AuraStat)stat).Skill, baseStat.SaveParamBits);
								bw.WriteBits((uint)((AuraStat)stat).Value, baseStat.SaveBits);
							}
							else
							{
								bool flag14 = type2 == StatType.Reanimate;
								if (flag14)
								{
									bw.WriteBits((uint)((ReanimateStat)stat).Monster, baseStat.SaveParamBits);
									bw.WriteBits(((ReanimateStat)stat).Value, baseStat.SaveBits);
								}
								else
								{
									bool flag15 = type2 == StatType.SkillOnAttack || type2 == StatType.SkillOnKill || type2 == StatType.SkillOnDeath || type2 == StatType.SkillOnStriking || type2 == StatType.SkillOnLevelUp || type2 == StatType.SkillOnGetHit;
									if (flag15)
									{
										bw.WriteBits((uint)((SkillOnEventStat)stat).Level, 6);
										bw.WriteBits((uint)((SkillOnEventStat)stat).Skill, 10);
										bw.WriteBits((uint)((SkillOnEventStat)stat).Chance, baseStat.SaveBits);
									}
									else
									{
										bool flag16 = type2 == StatType.ChargedSkill;
										if (flag16)
										{
											bw.WriteBits((uint)((ChargedSkillStat)stat).Level, 6);
											bw.WriteBits((uint)((ChargedSkillStat)stat).Skill, 10);
											bw.WriteBits((uint)((ChargedSkillStat)stat).Charges, 8);
											bw.WriteBits((uint)((ChargedSkillStat)stat).MaxCharges, 8);
										}
										else
										{
											bool flag17 = type2 == StatType.SkillTabBonus;
											if (!flag17)
											{
												throw new Exception("Invalid stat: " + baseStat.Index.ToString());
											}
											bw.WriteBits((uint)((SkillTabBonusStat)stat).TabNumber, 3);
											bw.WriteBits((uint)((SkillTabBonusStat)stat).Class, 3);
											bw.WriteBits((uint)((SkillTabBonusStat)stat).Unknown, 10);
											bw.WriteBits((uint)((SkillTabBonusStat)stat).Value, baseStat.SaveBits);
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BADA RID: 47834 RVA: 0x0046FD40 File Offset: 0x0046DF40
		public string GetTitle()
		{
			string text = (this.flags.HasFlag(ItemFlags.Ethereal) ? "Ethereal " : "");
			string text2 = (this.flags.HasFlag(ItemFlags.Socketed) ? (" (" + ((SignedStat)this[StatType.Sockets]).Value.ToString() + "os)") : "");
			bool flag = this.quality == ItemQuality.Set;
			string text4;
			if (flag)
			{
				string text3 = text;
				BaseSetItem baseSetItem = this.setItem;
				text4 = text3 + ((baseSetItem != null) ? baseSetItem.Name : null);
			}
			else
			{
				bool flag2 = this.quality == ItemQuality.Unique && !this.flags.HasFlag(ItemFlags.Identified);
				if (flag2)
				{
					text4 = "(Unid) " + text + this.baseItem.Name;
				}
				else
				{
					bool flag3 = this.quality == ItemQuality.Unique;
					if (flag3)
					{
						text4 = text + this.uniqueItem.Name + text2;
					}
					else
					{
						bool flag4 = this.flags.HasFlag(ItemFlags.Runeword);
						if (flag4)
						{
							text4 = text + this.runeword.Name;
						}
						else
						{
							bool flag5 = this.quality == ItemQuality.Inferior || this.quality == ItemQuality.Superior;
							if (flag5)
							{
								text4 = string.Concat(new string[]
								{
									text,
									this.prefix.Name,
									" ",
									this.baseItem.Name,
									text2
								});
							}
							else
							{
								bool flag6 = this.quality == ItemQuality.Magic || this.quality == ItemQuality.Rare || this.quality == ItemQuality.Crafted;
								if (flag6)
								{
									text4 = string.Concat(new string[]
									{
										text,
										this.quality.ToString(),
										" ",
										this.baseItem.Name,
										text2
									});
								}
								else
								{
									text4 = this.baseItem.Name + text2;
								}
							}
						}
					}
				}
			}
			return text4;
		}

		// Token: 0x0600BADB RID: 47835 RVA: 0x0046FF64 File Offset: 0x0046E164
		public string GetDescription()
		{
			return this.GetTitle();
		}

		// Token: 0x0600BADC RID: 47836 RVA: 0x0046FF7C File Offset: 0x0046E17C
		private bool IsRepairable()
		{
			bool flag = this[StatType.ChargedSkill] != null && ((ChargedSkillStat)this[StatType.ChargedSkill]).Charges < ((ChargedSkillStat)this[StatType.ChargedSkill]).MaxCharges;
			bool flag2;
			if (flag)
			{
				flag2 = true;
			}
			else
			{
				bool flag3 = this.flags.HasFlag(ItemFlags.Ethereal);
				if (flag3)
				{
					flag2 = false;
				}
				else
				{
					bool flag4 = this[StatType.Indesctructible] != null;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.maxDurability == null;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool noDurability = this.baseItem.NoDurability;
							if (noDurability)
							{
								flag2 = false;
							}
							else
							{
								bool flag6 = this.maxDurability.Value == this.durability.Value;
								flag2 = !flag6;
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600BADD RID: 47837 RVA: 0x00470058 File Offset: 0x0046E258
		private void CalculateAdditionalCostsForItemSkill(ref int nSellCost, ref int nBuyCost, ref int nRepCost, int nDivisor)
		{
		}

		// Token: 0x0600BADE RID: 47838 RVA: 0x0047005C File Offset: 0x0046E25C
		private void CalculateAdditionalCostsForBonusStats(ref int nSellCost, ref int nBuyCost, ref int nRepCost, int nDivisor)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			foreach (StatBase statBase in this.mods)
			{
				bool flag = statBase is SignedStat || statBase is UnsignedStat;
				if (flag)
				{
					int num4 = ((statBase is SignedStat) ? ((SignedStat)statBase).Value : ((int)((UnsignedStat)statBase).Value));
					BaseStat baseStat = statBase.BaseStat;
					bool flag2 = baseStat.Name == "Max Durability Percent";
					if (flag2)
					{
						baseStat = BaseStat.GetByName("Max Durability");
					}
					bool flag3 = baseStat.Name == "Max Damage Percent";
					if (flag3)
					{
						baseStat = BaseStat.GetByName("Max Damage");
					}
					bool flag4 = baseStat.Encode == 1;
					if (!flag4)
					{
						bool flag5 = num4 * nSellCost > 65535 && statBase.BaseStat.Multiply > 0;
						if (flag5)
						{
							num += baseStat.Add + baseStat.Multiply * (num4 * nSellCost / 1024);
							num2 += baseStat.Add + baseStat.Multiply * (num4 * nBuyCost / 1024);
							num3 += baseStat.Add + baseStat.Multiply * (num4 * nRepCost / 1024);
						}
						else
						{
							num += baseStat.Add + num4 * baseStat.Multiply * nSellCost / 1024;
							num2 += baseStat.Add + num4 * baseStat.Multiply * nBuyCost / 1024;
							num3 += baseStat.Add + num4 * baseStat.Multiply * nRepCost / 1024;
						}
					}
				}
			}
			nSellCost += num / nDivisor;
			nBuyCost += num2 / nDivisor;
			nRepCost += num3 / nDivisor;
		}

		// Token: 0x0600BADF RID: 47839 RVA: 0x00470270 File Offset: 0x0046E470
		private int CalculateAdditionalCostsForChargedSkills(int max)
		{
			return 0;
		}

		// Token: 0x0600BAE0 RID: 47840 RVA: 0x00470284 File Offset: 0x0046E484
		public int GetItemCost(int nTransactionType, int nVendorId, int reducedPrices, UpdateQuestInfo updateQuestInfo, List<ItemAction> socketedItems)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			int num8 = 0;
			int num9 = 0;
			bool flag = nTransactionType == 3 && !this.IsRepairable();
			int num10;
			if (flag)
			{
				num10 = 0;
			}
			else
			{
				bool flag2 = this.flags.HasFlag(ItemFlags.StartItem);
				if (flag2)
				{
					num10 = 1;
				}
				else
				{
					num2 = ((this[StatType.Quantity] != null) ? ((SignedStat)this[StatType.Quantity]).Value : 1);
					num = reducedPrices;
					bool flag3 = num >= 99;
					if (flag3)
					{
						num = 99;
					}
					bool flag4 = nTransactionType != 2;
					if (flag4)
					{
						num6 = 1;
						bool flag5 = this.flags.HasFlag(ItemFlags.Ear);
						if (flag5)
						{
							num3 = this.baseItem.Cost * (int)this.level;
							num4 = num3;
						}
						else
						{
							bool flag6 = this.baseItem.BaseType.Type == ItemKind.BodyPart;
							if (flag6)
							{
								num3 += this.baseItem.Cost;
								num4 = num3;
							}
							else
							{
								bool flag7 = this.baseItem.BaseType.Type == ItemKind.Book;
								if (flag7)
								{
									int num11 = ((this.baseItem.Type == ItemType.TomeOfTownPortal) ? 50 : 40);
									num3 = this.baseItem.Cost + num2 * num11;
									num4 = num3;
								}
								else
								{
									uint num12 = ((this[StatType.ExtraStack] != null) ? ((UnsignedStat)this[StatType.ExtraStack]).Value : 0U);
									int num13 = (int)((ulong)num12 + (ulong)((long)this.baseItem.MaxStack));
									bool flag8 = this.baseItem.BaseType.Quiver != "";
									if (flag8)
									{
										num3 = num2 * this.baseItem.Cost / 1024;
										num4 = num3;
										bool flag9 = num13 >= 511;
										if (flag9)
										{
											num13 = 511;
										}
										num5 = num13 * this.baseItem.Cost / 1024;
									}
									else
									{
										num3 = this.baseItem.Cost;
										num4 = num3;
										num5 = num3;
										bool stackable = this.baseItem.Stackable;
										if (stackable)
										{
											num6 = num13;
											bool flag10 = num6 < 511;
											if (flag10)
											{
												bool flag11 = num6 <= 1;
												if (flag11)
												{
													num6 = 1;
												}
											}
											else
											{
												num6 = 511;
											}
										}
									}
								}
							}
						}
						bool flag12 = this.baseItem is BaseArmor;
						if (flag12)
						{
							int value = this.armor.Value;
							BaseArmor baseArmor = (BaseArmor)this.baseItem;
							bool flag13 = baseArmor.MaxAc - baseArmor.MinAc != -1;
							if (flag13)
							{
								num3 = value * baseArmor.Cost / baseArmor.MaxAc;
								num4 = value * baseArmor.Cost / baseArmor.MaxAc;
								num5 = value * baseArmor.Cost / baseArmor.MaxAc;
							}
						}
						bool flag14 = this.quality < ItemQuality.Magic || this.quality > ItemQuality.Crafted;
						if (flag14)
						{
							this.CalculateAdditionalCostsForItemSkill(ref num3, ref num4, ref num5, num6);
						}
						bool flag15 = this.flags.HasFlag(ItemFlags.Identified);
						if (flag15)
						{
							bool flag16 = this.quality == ItemQuality.Rare || this.quality == ItemQuality.Crafted;
							if (flag16)
							{
								foreach (MagicPrefixType magicPrefixType in this.magicPrefixes)
								{
									MagicPrefix magicPrefix = MagicPrefix.MagicPrefixList[(int)magicPrefixType];
									bool flag17 = num3 > 65535 && magicPrefix.multiply > 0;
									if (flag17)
									{
										num7 = magicPrefix.add + magicPrefix.multiply * (num3 / 1024);
										num8 = magicPrefix.add + magicPrefix.multiply * (num4 / 1024);
										num9 = magicPrefix.add + magicPrefix.multiply * (num5 / 1024);
									}
									else
									{
										num7 = magicPrefix.add + num3 * magicPrefix.multiply / 1024;
										num8 = magicPrefix.add + num4 * magicPrefix.multiply / 1024;
										num9 = magicPrefix.add + num5 * magicPrefix.multiply / 1024;
									}
								}
								foreach (MagicSuffixType magicSuffixType in this.magicSuffixes)
								{
									MagicSuffix magicSuffix = MagicSuffix.MagicSuffixList[(int)magicSuffixType];
									bool flag18 = num3 > 65535 && magicSuffix.multiply > 0;
									if (flag18)
									{
										num7 = magicSuffix.add + magicSuffix.multiply * (num3 / 1024);
										num8 = magicSuffix.add + magicSuffix.multiply * (num4 / 1024);
										num9 = magicSuffix.add + magicSuffix.multiply * (num5 / 1024);
									}
									else
									{
										num7 = magicSuffix.add + num3 * magicSuffix.multiply / 1024;
										num8 = magicSuffix.add + num4 * magicSuffix.multiply / 1024;
										num9 = magicSuffix.add + num5 * magicSuffix.multiply / 1024;
									}
								}
								this.CalculateAdditionalCostsForBonusStats(ref num3, ref num4, ref num5, num6);
							}
							else
							{
								bool flag19 = this.quality == ItemQuality.Unique;
								if (flag19)
								{
									bool flag20 = num3 > 65535 && this.uniqueItem.CostMultiply > 0;
									if (flag20)
									{
										num7 = this.uniqueItem.CostAdd + this.uniqueItem.CostMultiply * (num3 / 1024);
										num8 = this.uniqueItem.CostAdd + this.uniqueItem.CostMultiply * (num4 / 1024);
										num9 = this.uniqueItem.CostAdd + this.uniqueItem.CostMultiply * (num5 / 1024);
									}
									else
									{
										num7 = this.uniqueItem.CostAdd + num3 * this.uniqueItem.CostMultiply / 1024;
										num8 = this.uniqueItem.CostAdd + num4 * this.uniqueItem.CostMultiply / 1024;
										num9 = this.uniqueItem.CostAdd + num5 * this.uniqueItem.CostMultiply / 1024;
									}
								}
								else
								{
									bool flag21 = this.quality == ItemQuality.Magic;
									if (flag21)
									{
										bool flag22 = MagicPrefix.MagicPrefixList.Count > this.prefix.Index;
										if (flag22)
										{
											MagicPrefix magicPrefix2 = MagicPrefix.MagicPrefixList[this.prefix.Index];
											bool flag23 = num3 > 65535 && magicPrefix2.multiply > 0;
											if (flag23)
											{
												num7 = magicPrefix2.add + magicPrefix2.multiply * (num3 / 1024);
												num8 = magicPrefix2.add + magicPrefix2.multiply * (num4 / 1024);
												num9 = magicPrefix2.add + magicPrefix2.multiply * (num5 / 1024);
											}
											else
											{
												num7 = magicPrefix2.add + num3 * magicPrefix2.multiply / 1024;
												num8 = magicPrefix2.add + num4 * magicPrefix2.multiply / 1024;
												num9 = magicPrefix2.add + num5 * magicPrefix2.multiply / 1024;
											}
										}
										bool flag24 = MagicSuffix.MagicSuffixList.Count > this.suffix.Index;
										if (flag24)
										{
											MagicSuffix magicSuffix2 = MagicSuffix.MagicSuffixList[this.suffix.Index];
											bool flag25 = num3 > 65535 && magicSuffix2.multiply > 0;
											if (flag25)
											{
												num7 = magicSuffix2.add + magicSuffix2.multiply * (num3 / 1024);
												num8 = magicSuffix2.add + magicSuffix2.multiply * (num4 / 1024);
												num9 = magicSuffix2.add + magicSuffix2.multiply * (num5 / 1024);
											}
											else
											{
												num7 = magicSuffix2.add + num3 * magicSuffix2.multiply / 1024;
												num8 = magicSuffix2.add + num4 * magicSuffix2.multiply / 1024;
												num9 = magicSuffix2.add + num5 * magicSuffix2.multiply / 1024;
											}
										}
										this.CalculateAdditionalCostsForBonusStats(ref num3, ref num4, ref num5, num6);
									}
									else
									{
										bool flag26 = this.quality == ItemQuality.Superior || this.quality == ItemQuality.Crafted;
										if (flag26)
										{
											this.CalculateAdditionalCostsForBonusStats(ref num3, ref num4, ref num5, num6);
										}
										else
										{
											bool flag27 = this.quality == ItemQuality.Set;
											if (flag27)
											{
												bool flag28 = num3 > 65535 && this.setItem.CostMultiply > 0;
												if (flag28)
												{
													num7 = this.setItem.CostAdd + this.setItem.CostMultiply * (num3 / 1024);
													num8 = this.setItem.CostAdd + this.setItem.CostMultiply * (num4 / 1024);
													num9 = this.setItem.CostAdd + this.setItem.CostMultiply * (num5 / 1024);
												}
												else
												{
													num7 = this.setItem.CostAdd + num3 * this.setItem.CostMultiply / 1024;
													num8 = this.setItem.CostAdd + num4 * this.setItem.CostMultiply / 1024;
													num9 = this.setItem.CostAdd + num5 * this.setItem.CostMultiply / 1024;
												}
											}
											else
											{
												bool flag29 = this.quality == ItemQuality.Inferior;
												if (flag29)
												{
													num7 = num3 / -2;
													num8 = num4 / -2;
													num9 = num5 / -2;
												}
											}
										}
									}
								}
							}
							num3 += num7 / num6;
							num4 += num8 / num6;
							num5 += num9 / num6;
							bool flag30 = this.quality >= ItemQuality.Magic && this.quality <= ItemQuality.Crafted;
							if (flag30)
							{
								this.CalculateAdditionalCostsForItemSkill(ref num3, ref num4, ref num5, num6);
							}
						}
						bool flag31 = this.m_usedSockets > 0;
						if (flag31)
						{
							foreach (ItemAction itemAction in socketedItems)
							{
								int num14 = itemAction.baseItem.Cost / 2;
								num3 += num14;
								num4 += num14;
								num5 += num14;
							}
						}
						bool flag32 = this.flags.HasFlag(ItemFlags.Ethereal);
						if (flag32)
						{
							num4 /= 4;
						}
						bool flag33 = this.baseItem.BaseType.Class != CharacterClass.Any;
						if (flag33)
						{
							num4 /= 4;
						}
						bool flag34 = nTransactionType == 1;
						if (flag34)
						{
							int num15 = ((this.durability == null) ? 1 : ((this.baseItem is BaseArmor || this.baseItem is BaseWeapon) ? this.durability.Value : 1));
							bool flag35 = this.flags.HasFlag(ItemFlags.Ethereal) && !this.baseItem.NoDurability && num15 == 0 && this[StatType.Indesctructible] == null;
							if (flag35)
							{
								num4 = 0;
							}
						}
						else
						{
							bool flag36 = nTransactionType == 3;
							if (flag36)
							{
								bool flag37 = this.baseItem.BaseType.Quiver == "" || !this.baseItem.BaseType.Throwable;
								if (flag37)
								{
									int num16 = ((this.baseItem is BaseArmor || this.baseItem is BaseWeapon) ? this.durability.Value : 0);
									bool flag38 = !this.flags.HasFlag(ItemFlags.Ethereal) && !this.baseItem.NoDurability && num16 > 0 && this[StatType.Indesctructible] == null;
									if (flag38)
									{
										int num17 = num16;
										int value2 = this.maxDurability.Value;
										bool flag39 = num17 < value2;
										if (flag39)
										{
											bool flag40 = this[StatType.ReplenishDurability] != null;
											if (flag40)
											{
												bool flag41 = num17 < value2 - 1;
												if (flag41)
												{
													num5 *= (value2 - 1) / value2;
												}
												else
												{
													num5 = 0;
												}
											}
											else
											{
												num5 = num5 * (value2 - num17) / value2;
											}
										}
										else
										{
											num5 = 0;
										}
									}
								}
							}
						}
						Vendor vendor = Vendor.npcList[nVendorId];
						bool flag42 = num3 <= 65535 || vendor.sellmult > 0;
						if (flag42)
						{
							num3 = num3 * vendor.sellmult / 1024;
						}
						else
						{
							num3 = vendor.sellmult * (num3 / 1024);
						}
						bool flag43 = num4 <= 65535 || vendor.sellmult > 0;
						if (flag43)
						{
							num4 = num4 * vendor.buymult / 1024;
						}
						else
						{
							num4 = vendor.buymult * (num4 / 1024);
						}
						bool flag44 = num5 <= 65535 || vendor.repmult > 0;
						if (flag44)
						{
							num5 = num5 * vendor.repmult / 1024;
						}
						else
						{
							num5 = vendor.repmult * (num5 / 1024);
						}
						bool flag45 = (updateQuestInfo != null && updateQuestInfo.Quests_42[vendor.questflagA].Standing == QuestStanding.Complete) || (updateQuestInfo != null && updateQuestInfo.Quests_42[vendor.questflagA].Standing == QuestStanding.RewardPending);
						bool flag46 = flag45;
						if (flag46)
						{
							bool flag47 = num3 > 65535 && vendor.questsellmultA > 0;
							if (flag47)
							{
								num3 = vendor.questsellmultA * num3 / 1024;
							}
							else
							{
								num3 *= vendor.questsellmultA / 1024;
							}
							bool flag48 = num4 > 65535 && vendor.questbuymultA > 0;
							if (flag48)
							{
								num4 = vendor.questbuymultA * num4 / 1024;
							}
							else
							{
								num4 *= vendor.questbuymultA / 1024;
							}
							bool flag49 = num5 > 65535 && vendor.questrepmultA > 0;
							if (flag49)
							{
								num5 = vendor.questrepmultA * num5 / 1024;
							}
							else
							{
								num5 *= vendor.questrepmultA / 1024;
							}
						}
						bool flag50 = this.baseItem.BaseType.Type != ItemKind.Book;
						if (flag50)
						{
							bool flag51 = this.baseItem.BaseType.Quiver == "";
							if (flag51)
							{
								num3 *= num2;
								bool flag52 = this.baseItem.Stackable && this.IsRepairable();
								if (flag52)
								{
									uint num18 = ((this[StatType.ExtraStack] != null) ? ((UnsignedStat)this[StatType.ExtraStack]).Value : 0U);
									int num19 = (int)((ulong)num18 + (ulong)((long)this.baseItem.MaxStack));
									bool flag53 = num19 >= 511;
									if (flag53)
									{
										num19 = 511;
									}
									bool flag54 = num2 < num19 && this[StatType.ReplenishQuantity] == null;
									if (flag54)
									{
										num5 *= num19 - num2;
									}
									else
									{
										num5 = 0;
									}
									num4 *= num19 - num5;
								}
								else
								{
									num4 *= num2;
								}
							}
						}
						int num20 = num4;
						bool flag55 = nTransactionType == 3 && !this.flags.HasFlag(ItemFlags.Ethereal);
						if (flag55)
						{
							num5 += this.CalculateAdditionalCostsForChargedSkills(10000);
						}
						int num21 = 35000;
						num20 = Math.Min(num20, num21);
						bool flag56 = nTransactionType != 1;
						if (flag56)
						{
							bool flag57 = nTransactionType == 3;
							if (flag57)
							{
								num20 = num5 * (100 - num) / 100;
							}
							else
							{
								num20 = num3 * (100 - num) / 100;
							}
						}
						num20 = Math.Max(num20, 1);
						num10 = num20;
					}
					else
					{
						num10 = 0;
					}
				}
			}
			return num10;
		}

		// Token: 0x04008A4D RID: 35405
		public GameServerPacket PacketId;

		// Token: 0x04008A4E RID: 35406
		public uint Id;

		// Token: 0x04008A4F RID: 35407
		public byte Length;

		// Token: 0x04008A50 RID: 35408
		public byte Unk;

		// Token: 0x04008A51 RID: 35409
		public byte[] ServerBytes;

		// Token: 0x04008A52 RID: 35410
		public ItemActionType action;

		// Token: 0x04008A53 RID: 35411
		public UnitType OwnerType;

		// Token: 0x04008A54 RID: 35412
		public uint OwnerId;

		// Token: 0x04008A55 RID: 35413
		public BaseItem baseItem;

		// Token: 0x04008A56 RID: 35414
		public ItemCategory category;

		// Token: 0x04008A57 RID: 35415
		public CharacterClass charClass;

		// Token: 0x04008A58 RID: 35416
		public ushort color;

		// Token: 0x04008A59 RID: 35417
		public ItemContainer container;

		// Token: 0x04008A5A RID: 35418
		public ItemDestination destination;

		// Token: 0x04008A5B RID: 35419
		public ItemFlags flags;

		// Token: 0x04008A5C RID: 35420
		public ushort graphic;

		// Token: 0x04008A5D RID: 35421
		public ushort level;

		// Token: 0x04008A5E RID: 35422
		public EquipmentLocation location;

		// Token: 0x04008A5F RID: 35423
		public List<MagicPrefixType> magicPrefixes;

		// Token: 0x04008A60 RID: 35424
		public List<MagicSuffixType> magicSuffixes;

		// Token: 0x04008A61 RID: 35425
		public SignedStat armor = null;

		// Token: 0x04008A62 RID: 35426
		public SignedStat durability = null;

		// Token: 0x04008A63 RID: 35427
		public SignedStat maxDurability = null;

		// Token: 0x04008A64 RID: 35428
		public List<StatBase> mods = new List<StatBase>();

		// Token: 0x04008A65 RID: 35429
		public List<StatBase> runewordMods = new List<StatBase>();

		// Token: 0x04008A66 RID: 35430
		public ItemAffix prefix;

		// Token: 0x04008A67 RID: 35431
		public ItemQuality quality;

		// Token: 0x04008A68 RID: 35432
		public BaseRuneword runeword;

		// Token: 0x04008A69 RID: 35433
		public ushort runewordID;

		// Token: 0x04008A6A RID: 35434
		public ushort runewordParam;

		// Token: 0x04008A6B RID: 35435
		public List<StatBase>[] setBonuses;

		// Token: 0x04008A6C RID: 35436
		public BaseSetItem setItem;

		// Token: 0x04008A6D RID: 35437
		public List<StatBase> stats = new List<StatBase>();

		// Token: 0x04008A6E RID: 35438
		public ItemAffix suffix;

		// Token: 0x04008A6F RID: 35439
		public SuperiorItemType superiorType;

		// Token: 0x04008A70 RID: 35440
		public BaseUniqueItem uniqueItem;

		// Token: 0x04008A71 RID: 35441
		public int m_unknown1;

		// Token: 0x04008A72 RID: 35442
		public ushort use;

		// Token: 0x04008A73 RID: 35443
		public ushort m_usedSockets;

		// Token: 0x04008A74 RID: 35444
		public ItemVersion version;

		// Token: 0x04008A75 RID: 35445
		public int x;

		// Token: 0x04008A76 RID: 35446
		public int y;

		// Token: 0x04008A77 RID: 35447
		public string name;

		// Token: 0x04008A78 RID: 35448
		public bool SaveFormat;

		// Token: 0x04008A79 RID: 35449
		public bool D2RTA = false;

		// Token: 0x04008A7A RID: 35450
		public bool D2R_2_5 = true;

		// Token: 0x04008A7B RID: 35451
		public static Dictionary<string, string> huffmanTable = new Dictionary<string, string>
		{
			{ "0", "11111011" },
			{ " ", "10" },
			{ "1", "1111100" },
			{ "2", "001100" },
			{ "3", "1101101" },
			{ "4", "11111010" },
			{ "5", "00010110" },
			{ "6", "1101111" },
			{ "7", "01111" },
			{ "8", "000100" },
			{ "9", "01110" },
			{ "a", "11110" },
			{ "b", "0101" },
			{ "c", "01000" },
			{ "d", "110001" },
			{ "e", "110000" },
			{ "f", "010011" },
			{ "g", "11010" },
			{ "h", "00011" },
			{ "i", "1111110" },
			{ "j", "000101110" },
			{ "k", "010010" },
			{ "l", "11101" },
			{ "m", "01101" },
			{ "n", "001101" },
			{ "o", "1111111" },
			{ "p", "11001" },
			{ "q", "11011001" },
			{ "r", "11100" },
			{ "s", "0010" },
			{ "t", "01100" },
			{ "u", "00001" },
			{ "v", "1101110" },
			{ "w", "00000" },
			{ "x", "00111" },
			{ "y", "0001010" },
			{ "z", "11011000" }
		};
	}
}
