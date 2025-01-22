using System;
using System.Linq;
using D2Data;
using D2Data.Generated;
using Utilities;

namespace D2Packets.Game.Server
{
	// Token: 0x0200099C RID: 2460
	public class AssignNPC : Packet
	{
		// Token: 0x17003915 RID: 14613
		// (get) Token: 0x0600BA92 RID: 47762 RVA: 0x0046C5A0 File Offset: 0x0046A7A0
		public monstats MonStats
		{
			get
			{
				return monstats.monstatsList[(int)this.NpcType];
			}
		}

		// Token: 0x0600BA93 RID: 47763 RVA: 0x0046C5C4 File Offset: 0x0046A7C4
		public override byte[] ToArray()
		{
			return this.orig;
		}

		// Token: 0x0600BA94 RID: 47764 RVA: 0x0046C5DC File Offset: 0x0046A7DC
		public override void FromBytes(byte[] data)
		{
			BitReader bitReader = new BitReader(data, 0);
			this.PacketId = (GameServerPacket)bitReader.ReadByte();
			this.Id = bitReader.ReadUInt32();
			this.NpcType = (NPCCode)bitReader.ReadUInt16();
			this.X = bitReader.ReadUInt16();
			this.Y = bitReader.ReadUInt16();
			this.Life = bitReader.ReadByte();
			this.Length = bitReader.ReadByte();
			this.orig = data.Take((int)this.Length).ToArray<byte>();
			bool flag = data.Length != 0;
			if (!flag)
			{
				this.AnimationMode = (byte)bitReader.ReadBits(4);
				bool flag2 = bitReader.ReadBit();
				try
				{
					bool flag3 = flag2;
					if (flag3)
					{
						monstats monstats = monstats.monstatsList[(int)this.NpcType];
					}
					bool flag4 = bitReader.ReadBit();
					bool flag5 = flag4;
					if (flag5)
					{
						this.IsChampion = bitReader.ReadBit();
						this.IsUnique = bitReader.ReadBit();
						this.IsSuperUnique = bitReader.ReadBit();
						this.IsMinion = bitReader.ReadBit();
						this.IsGhostly = bitReader.ReadBit();
						bool isSuperUnique = this.IsSuperUnique;
						if (isSuperUnique)
						{
							ushort num = bitReader.ReadUInt16();
						}
						while (bitReader.BitsLeft >= 8)
						{
							byte b = bitReader.ReadByte();
							bool flag6 = b == 0;
							if (flag6)
							{
								break;
							}
						}
						bool flag7 = bitReader.BitsLeft >= 17;
						if (flag7)
						{
							ushort num2 = bitReader.ReadUInt16();
							bool flag8 = bitReader.ReadBit();
							bool flag9 = flag8 && bitReader.BitsLeft >= 32;
							if (flag9)
							{
								uint num3 = bitReader.ReadUInt32();
							}
						}
					}
					bool flag10 = bitReader.BitsLeft % 8 > 0;
					if (flag10)
					{
						int num4 = (int)bitReader.ReadBits(bitReader.BitsLeft % 8);
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600BA95 RID: 47765 RVA: 0x0046C7C0 File Offset: 0x0046A9C0
		public static uint FloorLog2(uint x)
		{
			x |= x >> 1;
			x |= x >> 2;
			x |= x >> 4;
			x |= x >> 8;
			x |= x >> 16;
			return (uint)(AssignNPC.NumBitsSet(x) - 1);
		}

		// Token: 0x0600BA96 RID: 47766 RVA: 0x0046C800 File Offset: 0x0046AA00
		public static int BitsToRead(int x)
		{
			bool flag = x < 2;
			int num;
			if (flag)
			{
				num = 1;
			}
			else
			{
				num = (int)AssignNPC.CeilingLog2((uint)(x + 1));
			}
			return num;
		}

		// Token: 0x0600BA97 RID: 47767 RVA: 0x0046C828 File Offset: 0x0046AA28
		public static uint CeilingLog2(uint x)
		{
			int num = (int)(x & (x - 1U));
			num |= -num;
			num >>= 31;
			x |= x >> 1;
			x |= x >> 2;
			x |= x >> 4;
			x |= x >> 8;
			x |= x >> 16;
			return (uint)(AssignNPC.NumBitsSet(x) - 1 - num);
		}

		// Token: 0x0600BA98 RID: 47768 RVA: 0x0046C878 File Offset: 0x0046AA78
		public static int NumBitsSet(uint x)
		{
			x -= (x >> 1) & 1431655765U;
			x = ((x >> 2) & 858993459U) + (x & 858993459U);
			x = ((x >> 4) + x) & 252645135U;
			x += x >> 8;
			x += x >> 16;
			return (int)(x & 63U);
		}

		// Token: 0x0400891D RID: 35101
		public GameServerPacket PacketId;

		// Token: 0x0400891E RID: 35102
		public uint Id;

		// Token: 0x0400891F RID: 35103
		public NPCCode NpcType = NPCCode.NotApplicable;

		// Token: 0x04008920 RID: 35104
		public ushort X = ushort.MaxValue;

		// Token: 0x04008921 RID: 35105
		public ushort Y = ushort.MaxValue;

		// Token: 0x04008922 RID: 35106
		public byte Life = byte.MaxValue;

		// Token: 0x04008923 RID: 35107
		public byte Length;

		// Token: 0x04008924 RID: 35108
		public byte unk1;

		// Token: 0x04008925 RID: 35109
		public byte AnimationMode;

		// Token: 0x04008926 RID: 35110
		public bool IsChampion;

		// Token: 0x04008927 RID: 35111
		public bool IsUnique;

		// Token: 0x04008928 RID: 35112
		public bool IsSuperUnique;

		// Token: 0x04008929 RID: 35113
		public bool IsMinion;

		// Token: 0x0400892A RID: 35114
		public bool IsGhostly;

		// Token: 0x0400892B RID: 35115
		public string Name = "";

		// Token: 0x0400892C RID: 35116
		public byte[] orig;

		// Token: 0x0400892D RID: 35117
		private const int WORDBITS = 32;
	}
}
