using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Utilities
{
	// Token: 0x020007B1 RID: 1969
	public class BitWriter : BinaryWriter
	{
		// Token: 0x0600B471 RID: 46193 RVA: 0x002BEA8C File Offset: 0x002BCC8C
		public BitWriter(Stream s)
			: base(s)
		{
		}

		// Token: 0x0600B472 RID: 46194 RVA: 0x002BEAB4 File Offset: 0x002BCCB4
		public override void Flush()
		{
			bool flag = this.curBitIndx > 0;
			if (flag)
			{
				base.Write(BitWriter.ConvertToByte(this.curByte));
			}
			base.Flush();
		}

		// Token: 0x0600B473 RID: 46195 RVA: 0x002BEAE8 File Offset: 0x002BCCE8
		public override void Write(bool value)
		{
			this.curByte[(int)this.curBitIndx] = value;
			this.curBitIndx += 1;
			bool flag = this.curBitIndx == 8;
			if (flag)
			{
				base.Write(BitWriter.ConvertToByte(this.curByte));
				this.curBitIndx = 0;
				this.curByte = new bool[8];
			}
		}

		// Token: 0x0600B474 RID: 46196 RVA: 0x002BEB48 File Offset: 0x002BCD48
		private uint PackUInt64(ulong value, out byte mask, out byte[] result)
		{
			uint num = 0U;
			mask = 0;
			result = new byte[8];
			byte b = 0;
			while (value > 0UL)
			{
				bool flag = (value & 255UL) > 0UL;
				if (flag)
				{
					mask |= (byte)(1 << (int)b);
					result[(int)num++] = (byte)(value & 255UL);
				}
				value >>= 8;
				b += 1;
			}
			return num;
		}

		// Token: 0x0600B475 RID: 46197 RVA: 0x002BEBB4 File Offset: 0x002BCDB4
		public void Write(Guid guid)
		{
			byte b;
			byte[] array;
			uint num = this.PackUInt64(BitConverter.ToUInt64(guid.ToByteArray().Take(8).ToArray<byte>()), out b, out array);
			byte b2;
			byte[] array2;
			uint num2 = this.PackUInt64(BitConverter.ToUInt64(guid.ToByteArray().Skip(8).ToArray<byte>()), out b2, out array2);
			this.Write(b);
			this.Write(b2);
			this.Write(array, num);
			this.Write(array2, num2);
		}

		// Token: 0x0600B476 RID: 46198 RVA: 0x002BEC38 File Offset: 0x002BCE38
		public override void Write(byte value)
		{
			BitArray bitArray = new BitArray(new byte[] { value });
			for (byte b = 0; b < 8; b += 1)
			{
				this.Write(bitArray[(int)b]);
			}
		}

		// Token: 0x0600B477 RID: 46199 RVA: 0x002BEC78 File Offset: 0x002BCE78
		public override void Write(byte[] buffer)
		{
			for (int i = 0; i < buffer.Length; i++)
			{
				this.Write(buffer[i]);
			}
		}

		// Token: 0x0600B478 RID: 46200 RVA: 0x002BECA4 File Offset: 0x002BCEA4
		public void Write(byte[] buffer, uint size)
		{
			int num = 0;
			while ((long)num < (long)((ulong)size))
			{
				this.Write(buffer[num]);
				num++;
			}
		}

		// Token: 0x0600B479 RID: 46201 RVA: 0x002BECD0 File Offset: 0x002BCED0
		public void WriteBlob(byte[] buffer)
		{
			this.WriteBits((uint)buffer.Length, 16);
			for (int i = 0; i < buffer.Length; i++)
			{
				this.Write(buffer[i]);
			}
		}

		// Token: 0x0600B47A RID: 46202 RVA: 0x002BED08 File Offset: 0x002BCF08
		public override void Write(uint value)
		{
			BitArray bitArray = new BitArray(BitConverter.GetBytes(value));
			for (byte b = 0; b < 32; b += 1)
			{
				this.Write(bitArray[(int)b]);
			}
		}

		// Token: 0x0600B47B RID: 46203 RVA: 0x002BED44 File Offset: 0x002BCF44
		public override void Write(ulong value)
		{
			BitArray bitArray = new BitArray(BitConverter.GetBytes(value));
			for (byte b = 0; b < 64; b += 1)
			{
				this.Write(bitArray[(int)b]);
			}
		}

		// Token: 0x0600B47C RID: 46204 RVA: 0x002BED80 File Offset: 0x002BCF80
		public override void Write(ushort value)
		{
			BitArray bitArray = new BitArray(BitConverter.GetBytes(value));
			for (byte b = 0; b < 16; b += 1)
			{
				this.Write(bitArray[(int)b]);
			}
		}

		// Token: 0x0600B47D RID: 46205 RVA: 0x002BEDBC File Offset: 0x002BCFBC
		public void WriteBits(uint value, int bits)
		{
			BitArray bitArray = new BitArray(BitConverter.GetBytes(value).Take((bits - 1) / 8 + 1).ToArray<byte>());
			bool flag = this.d4;
			if (flag)
			{
				int num = 0;
				while (bits > num++ * 8)
				{
					List<bool> list = new List<bool>();
					byte b = 0;
					while ((int)b < Math.Min(bits - (num - 1) * 8, 8))
					{
						int num2 = bits - num * 8;
						bool flag2 = num2 < 0;
						if (flag2)
						{
							num2 = 0;
						}
						this.Write(bitArray[num2 + (int)b]);
						b += 1;
					}
				}
			}
			else
			{
				byte b2 = 0;
				while ((int)b2 < bits)
				{
					this.Write(bitArray[(int)b2]);
					b2 += 1;
				}
			}
		}

		// Token: 0x0600B47E RID: 46206 RVA: 0x002BEE88 File Offset: 0x002BD088
		private static byte ConvertToByte(bool[] bools)
		{
			byte b = 0;
			byte b2 = 0;
			for (int i = 0; i < 8; i++)
			{
				bool flag = bools[i];
				if (flag)
				{
					b |= (byte)(1 << (int)b2);
				}
				b2 += 1;
			}
			return b;
		}

		// Token: 0x0400596B RID: 22891
		private bool d4 = false;

		// Token: 0x0400596C RID: 22892
		private bool[] curByte = new bool[8];

		// Token: 0x0400596D RID: 22893
		private byte curBitIndx = 0;
	}
}
