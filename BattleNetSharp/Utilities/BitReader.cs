using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilities
{
	// Token: 0x020007AE RID: 1966
	public class BitReader : IDisposable
	{
		// Token: 0x0600B42A RID: 46122 RVA: 0x002BD912 File Offset: 0x002BBB12
		public BitReader(byte[] data, int offset = 0)
		{
			this.Data = data;
			this.ByteOffset = offset;
		}

		// Token: 0x0600B42B RID: 46123 RVA: 0x002BD92A File Offset: 0x002BBB2A
		public BitReader(BitReader data)
		{
			this.Data = data.Data;
			this.BitOffset = data.BitOffset;
			this.ByteOffset = data.ByteOffset;
		}

		// Token: 0x170037C6 RID: 14278
		// (get) Token: 0x0600B42C RID: 46124 RVA: 0x002BD958 File Offset: 0x002BBB58
		// (set) Token: 0x0600B42D RID: 46125 RVA: 0x002BD979 File Offset: 0x002BBB79
		public int Position
		{
			get
			{
				return this.ByteOffset * 8 + this.BitOffset;
			}
			set
			{
				this.BitOffset = value % 8;
				this.ByteOffset = value / 8;
			}
		}

		// Token: 0x170037C7 RID: 14279
		// (get) Token: 0x0600B42E RID: 46126 RVA: 0x002BD990 File Offset: 0x002BBB90
		public int BitsLeft
		{
			get
			{
				return (this.Data.Length - this.ByteOffset - 1) * 8 + (8 - this.BitOffset);
			}
		}

		// Token: 0x0600B42F RID: 46127 RVA: 0x002BD9C0 File Offset: 0x002BBBC0
		public bool ReadBit()
		{
			return this.ReadBits(1) == 1UL;
		}

		// Token: 0x0600B430 RID: 46128 RVA: 0x002BD9E0 File Offset: 0x002BBBE0
		public ulong ReadDynamicValue(out int size)
		{
			size = 8;
			bool flag = this.ReadBit();
			if (flag)
			{
				size *= 2;
				bool flag2 = this.ReadBit();
				if (flag2)
				{
					size *= 2;
				}
			}
			return this.ReadBits(size);
		}

		// Token: 0x0600B431 RID: 46129 RVA: 0x002BDA20 File Offset: 0x002BBC20
		public ulong ReadBits(int Count)
		{
			ulong num = 0UL;
			int num2 = 0;
			while (Count > 0)
			{
				int num3 = 8 - this.BitOffset;
				int num4 = Math.Min(Count, num3);
				bool flag = (long)this.Data.Length > (long)this.ByteOffset;
				if (flag)
				{
					num |= (ulong)((ulong)((long)((this.Data[this.ByteOffset] >> this.BitOffset) & ((1 << num4) - 1))) << num2);
				}
				num2 += num4;
				this.BitOffset += num4;
				bool flag2 = this.BitOffset == 8;
				if (flag2)
				{
					this.BitOffset = 0;
					this.ByteOffset++;
				}
				Count -= num4;
			}
			return num;
		}

		// Token: 0x0600B432 RID: 46130 RVA: 0x002BDAE0 File Offset: 0x002BBCE0
		public byte[] ReadBlob(ulong size)
		{
			List<byte> list = new List<byte>();
			for (ulong num = 0UL; num < size; num += 1UL)
			{
				list.Add(this.ReadByte());
			}
			return list.ToArray();
		}

		// Token: 0x0600B433 RID: 46131 RVA: 0x002BDB20 File Offset: 0x002BBD20
		public int ReadInt(int length)
		{
			int num = 0;
			while (length > 0)
			{
				int num2 = this.Position & 7;
				int num3 = 8 - num2;
				bool flag = num3 > length;
				if (flag)
				{
					num3 = length;
				}
				int num4 = (1 << num3) - 1;
				int num5 = this.Data[this.Position >> 3] >> num2;
				num |= (num5 & num4) << length - num3;
				length -= num3;
				this.Position += num3;
			}
			return num;
		}

		// Token: 0x0600B434 RID: 46132 RVA: 0x002BDBA0 File Offset: 0x002BBDA0
		public ulong ReadBitsMSR(int Count)
		{
			int i = Count;
			ulong num = 0UL;
			while (i > 0)
			{
				int num2 = this.Position & 7;
				int num3 = 8 - num2;
				bool flag = num3 > i;
				if (flag)
				{
					num3 = i;
				}
				int num4 = (1 << num3) - 1;
				int num5 = this.Data[this.Position >> 3] >> num2;
				num |= (ulong)((ulong)((long)(num5 & num4)) << i - num3);
				i -= num3;
				this.Position += num3;
			}
			return num;
		}

		// Token: 0x0600B435 RID: 46133 RVA: 0x002BDC24 File Offset: 0x002BBE24
		public uint BitReverse(uint value, byte numBits)
		{
			uint num = 0U;
			for (int i = 0; i < (int)numBits; i++)
			{
				bool flag = (value & (1U << i)) > 0U;
				if (flag)
				{
					num |= 1U << (int)(numBits - 1) - i;
				}
			}
			return num;
		}

		// Token: 0x0600B436 RID: 46134 RVA: 0x002BDC68 File Offset: 0x002BBE68
		public byte ReadByte()
		{
			return (byte)this.ReadBits(8);
		}

		// Token: 0x0600B437 RID: 46135 RVA: 0x002BDC84 File Offset: 0x002BBE84
		public byte[] ReadBytes(uint numBytes)
		{
			List<byte> list = new List<byte>();
			int num = 0;
			while ((long)num < (long)((ulong)numBytes))
			{
				list.Add(this.ReadByte());
				num++;
			}
			return list.ToArray();
		}

		// Token: 0x0600B438 RID: 46136 RVA: 0x002BDCC4 File Offset: 0x002BBEC4
		public ushort ReadUInt16()
		{
			return (ushort)this.ReadBits(16);
		}

		// Token: 0x0600B439 RID: 46137 RVA: 0x002BDCE0 File Offset: 0x002BBEE0
		public uint ReadUInt32()
		{
			return (uint)this.ReadBits(32);
		}

		// Token: 0x0600B43A RID: 46138 RVA: 0x002BDCFC File Offset: 0x002BBEFC
		public float ReadSingle()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(this.ReadUInt32()));
		}

		// Token: 0x0600B43B RID: 46139 RVA: 0x002BDD24 File Offset: 0x002BBF24
		public ulong ReadUInt64()
		{
			return this.ReadBits(64);
		}

		// Token: 0x0600B43C RID: 46140 RVA: 0x002BDD40 File Offset: 0x002BBF40
		public string ReadString(uint len)
		{
			byte[] array = (from b in this.ReadBytes(len)
				where b > 0
				select b).ToArray<byte>();
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x0600B43D RID: 46141 RVA: 0x002BDD90 File Offset: 0x002BBF90
		public Guid ReadGuid()
		{
			byte b = this.ReadByte();
			byte b2 = this.ReadByte();
			return new Guid(BitConverter.GetBytes(this.ReadPackedUInt64(b)).Concat(BitConverter.GetBytes(this.ReadPackedUInt64(b2))).ToArray<byte>());
		}

		// Token: 0x0600B43E RID: 46142 RVA: 0x002BDDD8 File Offset: 0x002BBFD8
		public ulong ReadPackedUInt64(byte mask)
		{
			bool flag = mask == 0;
			ulong num;
			if (flag)
			{
				num = 0UL;
			}
			else
			{
				ulong num2 = 0UL;
				for (int i = 0; i < 8; i++)
				{
					bool flag2 = ((int)mask & (1 << i)) != 0;
					if (flag2)
					{
						num2 += (ulong)this.ReadByte() << i * 8;
					}
				}
				num = num2;
			}
			return num;
		}

		// Token: 0x0600B43F RID: 46143 RVA: 0x002BDE31 File Offset: 0x002BC031
		public void SkipBits(int Count)
		{
			this.BitOffset += Count % 8;
			this.ByteOffset += Count / 8;
		}

		// Token: 0x0600B440 RID: 46144 RVA: 0x002BDE54 File Offset: 0x002BC054
		public void Dispose()
		{
			this.Data = null;
		}

		// Token: 0x04005963 RID: 22883
		private byte[] Data;

		// Token: 0x04005964 RID: 22884
		private int BitOffset;

		// Token: 0x04005965 RID: 22885
		private int ByteOffset;
	}
}
