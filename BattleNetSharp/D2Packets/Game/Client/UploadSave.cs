using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using D2Data;
using D2Packets.Game.Server;
using Utilities;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A7C RID: 2684
	public class UploadSave : Packet
	{
		// Token: 0x0600BBBB RID: 48059 RVA: 0x00473400 File Offset: 0x00471600
		public override void FromBytes(byte[] Bytes)
		{
			this.memoryStream = new MemoryStream(Bytes);
			this.reader = new BinaryReader(this.memoryStream);
			this.PacketId = (GameClientPacket)this.reader.ReadByte();
			this.BunchLength = this.reader.ReadByte();
			this.FileLength = this.reader.ReadUInt32();
			this.Data = this.reader.ReadBytes((int)this.BunchLength).ToList<byte>();
			this.Data.Add(this.reader.ReadByte());
		}

		// Token: 0x04008F28 RID: 36648
		public GameClientPacket PacketId;

		// Token: 0x04008F29 RID: 36649
		public byte BunchLength;

		// Token: 0x04008F2A RID: 36650
		public uint FileLength;

		// Token: 0x04008F2B RID: 36651
		public List<byte> Data;

		// Token: 0x02001375 RID: 4981
		public class D2SHeader : Packet
		{
			// Token: 0x17003973 RID: 14707
			// (get) Token: 0x0600DFD9 RID: 57305 RVA: 0x004C4A28 File Offset: 0x004C2C28
			// (set) Token: 0x0600DFDA RID: 57306 RVA: 0x004C4A78 File Offset: 0x004C2C78
			public string Name
			{
				get
				{
					List<byte> list = BitConverter.GetBytes(this.Name1).ToList<byte>();
					list.AddRange(BitConverter.GetBytes(this.Name2).ToList<byte>());
					return Encoding.ASCII.GetString(list.ToArray()).TrimString('\0');
				}
				set
				{
					List<byte> list = Encoding.ASCII.GetBytes(value).ToList<byte>();
					int num = 16 - list.Count;
					for (int i = 0; i < num; i++)
					{
						list.Add(0);
					}
					this.Name1 = BitConverter.ToUInt64(list.ToArray(), 0);
					this.Name2 = BitConverter.ToUInt64(list.ToArray(), 8);
				}
			}

			// Token: 0x0600DFDB RID: 57307 RVA: 0x004C4AE0 File Offset: 0x004C2CE0
			public uint CalcChecksum()
			{
				this.Checksum = 0U;
				byte[] array = this.ToArray();
				foreach (byte b in array)
				{
					this.Checksum = (this.Checksum << 1) + (uint)b;
				}
				return this.Checksum;
			}

			// Token: 0x04009EBA RID: 40634
			public uint SignatureAA55AA55;

			// Token: 0x04009EBB RID: 40635
			public UploadSave.D2SHeader.VersionIdentifier Version;

			// Token: 0x04009EBC RID: 40636
			public uint FileSize;

			// Token: 0x04009EBD RID: 40637
			public uint Checksum;

			// Token: 0x04009EBE RID: 40638
			public uint ActiveWeapon;

			// Token: 0x04009EBF RID: 40639
			public ulong Name1;

			// Token: 0x04009EC0 RID: 40640
			public ulong Name2;

			// Token: 0x04009EC1 RID: 40641
			public UploadSave.D2SHeader.StatusFlags Status;

			// Token: 0x04009EC2 RID: 40642
			public byte Progression;

			// Token: 0x04009EC3 RID: 40643
			public ushort Unk1;

			// Token: 0x04009EC4 RID: 40644
			public CharacterClass CharacterClass;

			// Token: 0x04009EC5 RID: 40645
			public ushort Unk2;

			// Token: 0x04009EC6 RID: 40646
			public byte Level;

			// Token: 0x04009EC7 RID: 40647
			public uint Unk3;

			// Token: 0x04009EC8 RID: 40648
			public uint LastPlayed;

			// Token: 0x04009EC9 RID: 40649
			public uint Unk4;

			// Token: 0x04009ECA RID: 40650
			public List<byte> HotKeys_64;

			// Token: 0x04009ECB RID: 40651
			public SkillType LeftMouse;

			// Token: 0x04009ECC RID: 40652
			public ushort LeftMousePad;

			// Token: 0x04009ECD RID: 40653
			public SkillType RightMouse;

			// Token: 0x04009ECE RID: 40654
			public ushort RightMousePad;

			// Token: 0x04009ECF RID: 40655
			public SkillType LeftMouseSwitch;

			// Token: 0x04009ED0 RID: 40656
			public ushort LeftMouseSwitchPad;

			// Token: 0x04009ED1 RID: 40657
			public SkillType RightMouseSwitch;

			// Token: 0x04009ED2 RID: 40658
			public ushort RightMouseSwitchPad;

			// Token: 0x04009ED3 RID: 40659
			public List<byte> CharacterMenuAppearance_32;

			// Token: 0x04009ED4 RID: 40660
			public UploadSave.D2SHeader.Difficulty Difficulties;

			// Token: 0x04009ED5 RID: 40661
			public uint MapId;

			// Token: 0x04009ED6 RID: 40662
			public ushort Unk5;

			// Token: 0x04009ED7 RID: 40663
			public ushort MercDead;

			// Token: 0x04009ED8 RID: 40664
			public uint MercId;

			// Token: 0x04009ED9 RID: 40665
			public ushort MercNameId;

			// Token: 0x04009EDA RID: 40666
			public ushort MercType;

			// Token: 0x04009EDB RID: 40667
			public uint MercExperience;

			// Token: 0x04009EDC RID: 40668
			public List<byte> Unk6_144;

			// Token: 0x04009EDD RID: 40669
			public UploadSave.D2SHeader.AllQuests Quests;

			// Token: 0x04009EDE RID: 40670
			public UploadSave.D2SHeader.AllWaypoints Waypoints;

			// Token: 0x04009EDF RID: 40671
			public UploadSave.D2SHeader.AllNpcData NpcData;

			// Token: 0x020014A9 RID: 5289
			public enum VersionIdentifier : uint
			{
				// Token: 0x0400A531 RID: 42289
				_1p0 = 71U,
				// Token: 0x0400A532 RID: 42290
				_1p7 = 87U,
				// Token: 0x0400A533 RID: 42291
				_1p8 = 89U,
				// Token: 0x0400A534 RID: 42292
				_1p9 = 92U,
				// Token: 0x0400A535 RID: 42293
				_1_10_14 = 96U,
				// Token: 0x0400A536 RID: 42294
				_1_15
			}

			// Token: 0x020014AA RID: 5290
			[Flags]
			public enum StatusFlags : byte
			{
				// Token: 0x0400A538 RID: 42296
				Hardcore = 4,
				// Token: 0x0400A539 RID: 42297
				Died = 8,
				// Token: 0x0400A53A RID: 42298
				Expansion = 32,
				// Token: 0x0400A53B RID: 42299
				Ladder = 64
			}

			// Token: 0x020014AB RID: 5291
			public class Difficulty : Packet
			{
				// Token: 0x0400A53C RID: 42300
				public byte Normal;

				// Token: 0x0400A53D RID: 42301
				public byte Nightmare;

				// Token: 0x0400A53E RID: 42302
				public byte Hell;
			}

			// Token: 0x020014AC RID: 5292
			public class AllQuests : Packet
			{
				// Token: 0x0400A53F RID: 42303
				public uint Header;

				// Token: 0x0400A540 RID: 42304
				public List<byte> unk_6;

				// Token: 0x0400A541 RID: 42305
				public UploadSave.D2SHeader.AllQuests.QuestsPerDifficulty NormalQuests;

				// Token: 0x0400A542 RID: 42306
				public UploadSave.D2SHeader.AllQuests.QuestsPerDifficulty NightmarelQuests;

				// Token: 0x0400A543 RID: 42307
				public UploadSave.D2SHeader.AllQuests.QuestsPerDifficulty HellQuests;

				// Token: 0x020014DE RID: 5342
				public class QuestsPerDifficulty : Packet
				{
					// Token: 0x0400A5CB RID: 42443
					public UploadSave.D2SHeader.AllQuests.QuestsPerDifficulty.QuestsPerAct Act1;

					// Token: 0x0400A5CC RID: 42444
					public UploadSave.D2SHeader.AllQuests.QuestsPerDifficulty.QuestsPerAct Act2;

					// Token: 0x0400A5CD RID: 42445
					public UploadSave.D2SHeader.AllQuests.QuestsPerDifficulty.QuestsPerAct Act3;

					// Token: 0x0400A5CE RID: 42446
					public UploadSave.D2SHeader.AllQuests.QuestsPerDifficulty.QuestsPerAct Act4;

					// Token: 0x0400A5CF RID: 42447
					public uint ClassicBeat;

					// Token: 0x0400A5D0 RID: 42448
					public UploadSave.D2SHeader.AllQuests.QuestsPerDifficulty.QuestsPerAct Act5;

					// Token: 0x0400A5D1 RID: 42449
					public List<byte> Unk2_12;

					// Token: 0x020014E2 RID: 5346
					public class QuestsPerAct : Packet
					{
						// Token: 0x0400A5DD RID: 42461
						public ushort Introduced;

						// Token: 0x0400A5DE RID: 42462
						public List<UploadSave.D2SHeader.AllQuests.QuestsPerDifficulty.QuestsPerAct.Quest> Quests_6;

						// Token: 0x0400A5DF RID: 42463
						public ushort Traveled;

						// Token: 0x020014E3 RID: 5347
						public class Quest : Packet
						{
							// Token: 0x0600E85E RID: 59486 RVA: 0x004DE558 File Offset: 0x004DC758
							public bool IsCompleted()
							{
								return (this.Data & 1) == 1;
							}

							// Token: 0x0600E85F RID: 59487 RVA: 0x004DE57C File Offset: 0x004DC77C
							public bool ScrollConsumed()
							{
								return ((this.Data >> 7) & 1) == 1;
							}

							// Token: 0x0400A5E0 RID: 42464
							public ushort Data;
						}
					}
				}
			}

			// Token: 0x020014AD RID: 5293
			public class AllWaypoints : Packet
			{
				// Token: 0x0400A544 RID: 42308
				public ushort WSHeader;

				// Token: 0x0400A545 RID: 42309
				public List<byte> Unk0x010000005000_6;

				// Token: 0x0400A546 RID: 42310
				public UploadSave.D2SHeader.AllWaypoints.WaypointsPerDifficulty NormalWaypoints;

				// Token: 0x0400A547 RID: 42311
				public UploadSave.D2SHeader.AllWaypoints.WaypointsPerDifficulty NightmareWaypoints;

				// Token: 0x0400A548 RID: 42312
				public UploadSave.D2SHeader.AllWaypoints.WaypointsPerDifficulty HellWaypoints;

				// Token: 0x0400A549 RID: 42313
				public byte Trailer;

				// Token: 0x020014DF RID: 5343
				public class WaypointsPerDifficulty : Packet
				{
					// Token: 0x0400A5D2 RID: 42450
					public ushort Header0x0102;

					// Token: 0x0400A5D3 RID: 42451
					public WaypointsAvailable Waypoints;

					// Token: 0x0400A5D4 RID: 42452
					public List<byte> Unk_14;
				}
			}

			// Token: 0x020014AE RID: 5294
			public class AllNpcData : Packet
			{
				// Token: 0x0400A54A RID: 42314
				public List<byte> Header_3;

				// Token: 0x0400A54B RID: 42315
				public List<ulong> NpcIntros_3;

				// Token: 0x0400A54C RID: 42316
				public List<ulong> NpcReturn_3;
			}
		}

		// Token: 0x02001376 RID: 4982
		public class D2SAttributes : Packet
		{
			// Token: 0x0600DFDD RID: 57309 RVA: 0x004C4B38 File Offset: 0x004C2D38
			public override void FromBytes(byte[] Bytes)
			{
				BitReader bitReader = new BitReader(Bytes, 0);
				this.Header = bitReader.ReadUInt16();
				this.Attributes = new List<StatBase>();
				for (;;)
				{
					int num = (int)bitReader.ReadBits(9);
					bool flag = num == 511 || num == 504;
					if (flag)
					{
						break;
					}
					BaseStat baseStat = BaseStat.Get(num);
					ulong num2 = bitReader.ReadBits(baseStat.CSvBits);
					bool signed = baseStat.Signed;
					if (signed)
					{
						this.Attributes.Add(new SignedStat(baseStat, (int)num2));
					}
					else
					{
						this.Attributes.Add(new UnsignedStat(baseStat, (uint)num2));
					}
				}
			}

			// Token: 0x0600DFDE RID: 57310 RVA: 0x004C4BE0 File Offset: 0x004C2DE0
			public override byte[] ToArray()
			{
				this.memoryStream = new MemoryStream();
				this.writer = new BitWriter(this.memoryStream);
				this.writer.Write(this.Header);
				foreach (StatBase statBase in this.Attributes)
				{
					BitArray bitArray = new BitArray(BitConverter.GetBytes(statBase.BaseStat.Index));
					for (byte b = 0; b < 9; b += 1)
					{
						this.writer.Write(bitArray[(int)b]);
					}
					bitArray = new BitArray(BitConverter.GetBytes(((UnsignedStat)statBase).Value));
					byte b2 = 0;
					while ((int)b2 < statBase.BaseStat.CSvBits)
					{
						this.writer.Write(bitArray[(int)b2]);
						b2 += 1;
					}
				}
				BitArray bitArray2 = new BitArray(BitConverter.GetBytes(511));
				for (byte b3 = 0; b3 < 9; b3 += 1)
				{
					this.writer.Write(bitArray2[(int)b3]);
				}
				this.writer.Flush();
				return this.memoryStream.ToArray();
			}

			// Token: 0x04009EE0 RID: 40672
			public ushort Header;

			// Token: 0x04009EE1 RID: 40673
			public List<StatBase> Attributes;
		}

		// Token: 0x02001377 RID: 4983
		public class D2SSkills : Packet
		{
			// Token: 0x04009EE2 RID: 40674
			public ushort Header;

			// Token: 0x04009EE3 RID: 40675
			public List<byte> Skills_30;
		}

		// Token: 0x02001378 RID: 4984
		public class D2SItems : Packet
		{
			// Token: 0x0600DFE1 RID: 57313 RVA: 0x004C4D60 File Offset: 0x004C2F60
			public override void FromBytes(byte[] Bytes)
			{
				BitReader bitReader = new BitReader(Bytes, 0);
				this.Header = bitReader.ReadUInt16();
				this.NumItems = bitReader.ReadUInt16();
				ushort num = this.NumItems;
				this.Items = new List<ItemAction>();
				int num2 = 0;
				for (int i = 0; i < (int)num; i++)
				{
					WorldItemAction worldItemAction = new WorldItemAction();
					List<byte> list = new List<byte> { 156, 20, 0, 17, 239, 190, 173, 222 };
					bool flag = BitConverter.ToUInt16(Bytes, 4 + num2) == this.Header;
					if (flag)
					{
						num2 += 2;
					}
					list.AddRange(Bytes.ToList<byte>().Skip(4 + num2));
					worldItemAction.Bytes = list;
					bool flag2 = !worldItemAction.flags.HasFlag(ItemFlags.Ear);
					if (flag2)
					{
						num += worldItemAction.m_usedSockets;
					}
					int num3 = worldItemAction.ToArray().Length;
					num2 += worldItemAction.ToArray().Length;
					this.Items.Add(worldItemAction);
				}
			}

			// Token: 0x0600DFE2 RID: 57314 RVA: 0x004C4EB0 File Offset: 0x004C30B0
			public override byte[] ToArray()
			{
				this.memoryStream = new MemoryStream();
				this.writer = new BinaryWriter(this.memoryStream);
				this.writer.Write(this.Header);
				this.writer.Write(this.NumItems);
				foreach (ItemAction itemAction in this.Items)
				{
					this.writer.Write(this.Header);
					List<byte> list = itemAction.ToArray().Skip(8).ToList<byte>();
					foreach (byte b in list)
					{
						this.writer.Write(b);
					}
				}
				return this.memoryStream.ToArray();
			}

			// Token: 0x04009EE4 RID: 40676
			public ushort Header;

			// Token: 0x04009EE5 RID: 40677
			public ushort NumItems;

			// Token: 0x04009EE6 RID: 40678
			public List<ItemAction> Items;
		}

		// Token: 0x02001379 RID: 4985
		public class D2SCorpse : Packet
		{
			// Token: 0x0600DFE4 RID: 57316 RVA: 0x004C4FCC File Offset: 0x004C31CC
			public override void FromBytes(byte[] Bytes)
			{
				BitReader bitReader = new BitReader(Bytes, 0);
				this.Header = bitReader.ReadUInt16();
				this.IsDead = bitReader.ReadUInt16();
				bool flag = this.IsDead == 1;
				if (flag)
				{
					this.Unk = Bytes.Skip(4).Take(12).ToList<byte>();
					this.Items = new UploadSave.D2SItems();
					this.Items.Bytes = Bytes.Skip(16).ToList<byte>();
				}
			}

			// Token: 0x0600DFE5 RID: 57317 RVA: 0x004C5048 File Offset: 0x004C3248
			public override byte[] ToArray()
			{
				this.memoryStream = new MemoryStream();
				this.writer = new BinaryWriter(this.memoryStream);
				this.writer.Write(this.Header);
				this.writer.Write(this.IsDead);
				bool flag = this.IsDead == 1;
				if (flag)
				{
					foreach (byte b in this.Unk)
					{
						this.writer.Write(b);
					}
					this.writer.Write(this.Items.ToArray());
				}
				return this.memoryStream.ToArray();
			}

			// Token: 0x04009EE7 RID: 40679
			public ushort Header;

			// Token: 0x04009EE8 RID: 40680
			public ushort IsDead;

			// Token: 0x04009EE9 RID: 40681
			public List<byte> Unk;

			// Token: 0x04009EEA RID: 40682
			public UploadSave.D2SItems Items;
		}

		// Token: 0x0200137A RID: 4986
		public class D2SMercItems : Packet
		{
			// Token: 0x0600DFE7 RID: 57319 RVA: 0x004C5128 File Offset: 0x004C3328
			public override void FromBytes(byte[] Bytes)
			{
				BitReader bitReader = new BitReader(Bytes, 0);
				this.JF = bitReader.ReadUInt16();
				bool flag = this.JF != 26218 && this.JF != 26219;
				if (!flag)
				{
					this.Items = new UploadSave.D2SItems();
					this.Items.Bytes = Bytes.Skip(2).ToList<byte>();
				}
			}

			// Token: 0x0600DFE8 RID: 57320 RVA: 0x004C5194 File Offset: 0x004C3394
			public override byte[] ToArray()
			{
				this.memoryStream = new MemoryStream();
				this.writer = new BinaryWriter(this.memoryStream);
				this.writer.Write(this.JF);
				bool flag = this.JF == 26218 || this.JF == 26219;
				if (flag)
				{
					this.writer.Write(this.Items.ToArray());
				}
				return this.memoryStream.ToArray();
			}

			// Token: 0x04009EEB RID: 40683
			public ushort JF;

			// Token: 0x04009EEC RID: 40684
			public UploadSave.D2SItems Items;
		}

		// Token: 0x0200137B RID: 4987
		public class D2S : Packet
		{
			// Token: 0x0600DFEA RID: 57322 RVA: 0x004C5220 File Offset: 0x004C3420
			public uint CalcChecksum()
			{
				uint num = 0U;
				byte[] array = this.ToArray();
				foreach (byte b in array)
				{
					num = ((num << 1) | (num >> 31)) + (uint)b;
				}
				return num;
			}

			// Token: 0x04009EED RID: 40685
			public UploadSave.D2SHeader Header;

			// Token: 0x04009EEE RID: 40686
			public UploadSave.D2SAttributes Attributes;

			// Token: 0x04009EEF RID: 40687
			public UploadSave.D2SSkills Skills;

			// Token: 0x04009EF0 RID: 40688
			public UploadSave.D2SItems Items;

			// Token: 0x04009EF1 RID: 40689
			public UploadSave.D2SCorpse Corpse;

			// Token: 0x04009EF2 RID: 40690
			public UploadSave.D2SMercItems MercItems;

			// Token: 0x04009EF3 RID: 40691
			public UploadSave.D2SMercItems IronGolemItem;
		}
	}
}
