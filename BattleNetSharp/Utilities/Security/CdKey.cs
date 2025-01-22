using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;

namespace Utilities.Security
{
	// Token: 0x020007B5 RID: 1973
	public sealed class CdKey
	{
		// Token: 0x0600B4C8 RID: 46280 RVA: 0x002C00C4 File Offset: 0x002BE2C4
		public CdKey(string cdKey)
		{
			this.key = cdKey;
			int length = cdKey.Length;
			int num = length;
			if (num != 13)
			{
				if (num != 16)
				{
					if (num == 26)
					{
						this.procW3Key();
					}
				}
				else
				{
					this.procW2Key();
				}
			}
			else
			{
				this.procSCKey();
			}
		}

		// Token: 0x170037C8 RID: 14280
		// (get) Token: 0x0600B4C9 RID: 46281 RVA: 0x002C011C File Offset: 0x002BE31C
		public string Key
		{
			get
			{
				return this.key;
			}
		}

		// Token: 0x170037C9 RID: 14281
		// (get) Token: 0x0600B4CA RID: 46282 RVA: 0x002C0134 File Offset: 0x002BE334
		public int Product
		{
			get
			{
				return (int)this.product;
			}
		}

		// Token: 0x170037CA RID: 14282
		// (get) Token: 0x0600B4CB RID: 46283 RVA: 0x002C014C File Offset: 0x002BE34C
		public int Public
		{
			get
			{
				return (int)this.val1;
			}
		}

		// Token: 0x170037CB RID: 14283
		// (get) Token: 0x0600B4CC RID: 46284 RVA: 0x002C0164 File Offset: 0x002BE364
		public byte[] Private
		{
			get
			{
				return this.val2;
			}
		}

		// Token: 0x170037CC RID: 14284
		// (get) Token: 0x0600B4CD RID: 46285 RVA: 0x002C017C File Offset: 0x002BE37C
		public bool IsValid
		{
			get
			{
				return this.valid;
			}
		}

		// Token: 0x0600B4CE RID: 46286 RVA: 0x002C0194 File Offset: 0x002BE394
		public byte[] GetHash(int clientToken, int serverToken)
		{
			return this.GetHash((uint)clientToken, (uint)serverToken);
		}

		// Token: 0x0600B4CF RID: 46287 RVA: 0x002C01B0 File Offset: 0x002BE3B0
		public byte[] GetHash(uint clientToken, uint serverToken)
		{
			lock (this)
			{
				bool flag2 = this.hash == null;
				if (flag2)
				{
					this.calculateHash(clientToken, serverToken);
				}
			}
			return this.hash;
		}

		// Token: 0x0600B4D0 RID: 46288 RVA: 0x002C020C File Offset: 0x002BE40C
		private void procSCKey()
		{
			uint num = 330078017U;
			uint num2 = 3U;
			for (int i = 0; i < 12; i++)
			{
				num2 += (uint)(this.key[i] - '0') ^ (num2 * 2U);
			}
			bool flag = (ulong)(num2 % 10U) != (ulong)((long)(this.key[12] - '0'));
			if (flag)
			{
				this.valid = false;
			}
			else
			{
				int num3 = 11;
				char[] array = this.key.ToCharArray();
				for (int j = 194; j >= 7; j -= 17)
				{
					char c = array[num3];
					array[num3] = array[j % 12];
					array[j % 12] = c;
					num3--;
				}
				for (int k = this.key.Length - 2; k >= 0; k--)
				{
					char c = char.ToUpper(array[k], CultureInfo.InvariantCulture);
					array[k] = c;
					bool flag2 = c <= '7';
					if (flag2)
					{
						char[] array2 = array;
						int num4 = k;
						array2[num4] ^= (char)(num & 7U);
						num >>= 3;
					}
					else
					{
						bool flag3 = c <= 'A';
						if (flag3)
						{
							char[] array3 = array;
							int num5 = k;
							array3[num5] ^= (char)(k & 1);
						}
					}
				}
				this.key = new string(array);
				this.product = uint.Parse(this.key.Substring(0, 2), CultureInfo.InvariantCulture);
				this.val1 = uint.Parse(this.key.Substring(2, 7), CultureInfo.InvariantCulture);
				this.val2 = BitConverter.GetBytes(uint.Parse(this.key.Substring(9, 3), CultureInfo.InvariantCulture));
				this.valid = true;
			}
		}

		// Token: 0x0600B4D1 RID: 46289 RVA: 0x002C03CC File Offset: 0x002BE5CC
		private void procW2Key()
		{
			char[] array = this.key.ToCharArray();
			uint num = 1U;
			uint num2 = 0U;
			for (int i = 0; i < 16; i += 2)
			{
				byte b = CdKey.w2Map[(int)this.key[i]];
				uint num3 = (uint)(b * 3);
				byte b2 = CdKey.w2Map[(int)array[i + 1]];
				num3 = (uint)b2 + num3 * 8U;
				bool flag = num3 >= 256U;
				if (flag)
				{
					num3 -= 256U;
					num2 |= num;
				}
				uint num4 = num3 >> 4;
				array[i] = (num4 % 16U).ToString("x", CultureInfo.InvariantCulture)[0];
				array[i + 1] = (num3 % 16U).ToString("x", CultureInfo.InvariantCulture)[0];
				num <<= 1;
			}
			uint num5 = 3U;
			for (int j = 0; j < 16; j++)
			{
				byte b = (byte)(array[j] & 'ÿ');
				uint num3 = CdKey.getNumValue((char)b);
				uint num4 = num5 * 2U;
				num3 ^= num4;
				num5 += num3;
			}
			num5 &= 255U;
			bool flag2 = num5 != num2;
			if (flag2)
			{
				this.valid = false;
			}
			else
			{
				this.valid = true;
				for (int k = 15; k >= 0; k--)
				{
					byte b = (byte)array[k];
					bool flag3 = k > 8;
					uint num3;
					if (flag3)
					{
						num3 = (uint)(k - 9);
					}
					else
					{
						num3 = (uint)(15 + k - 8);
					}
					num3 &= 15U;
					byte b2 = (byte)array[(int)num3];
					array[k] = (char)b2;
					array[(int)num3] = (char)b;
				}
				uint num6 = 330078017U;
				for (int l = 15; l >= 0; l--)
				{
					array[l] = char.ToUpper(array[l], CultureInfo.InvariantCulture);
					byte b = (byte)array[l];
					bool flag4 = b <= 55;
					if (flag4)
					{
						num5 = num6;
						byte b2 = ((byte)(num5 & 255U) & 7) ^ b;
						num5 >>= 3;
						array[l] = (char)b2;
						num6 = num5;
					}
					else
					{
						bool flag5 = b < 65;
						if (flag5)
						{
							array[l] = (char)(((ushort)l & 1) ^ (ushort)b);
						}
					}
				}
				this.key = new string(array);
				this.product = uint.Parse(this.key.Substring(0, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
				this.val1 = uint.Parse(this.key.Substring(2, 6), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
				this.val2 = BitConverter.GetBytes(uint.Parse(this.key.Substring(8, 8), NumberStyles.HexNumber, CultureInfo.InvariantCulture));
			}
		}

		// Token: 0x0600B4D2 RID: 46290 RVA: 0x002C068C File Offset: 0x002BE88C
		private static uint getNumValue(char c)
		{
			char c2 = char.ToUpper(c, CultureInfo.InvariantCulture);
			return (uint)(char.IsDigit(c2) ? (c2 - '0') : (c2 - '7'));
		}

		// Token: 0x0600B4D3 RID: 46291 RVA: 0x002C06BC File Offset: 0x002BE8BC
		private void procW3Key()
		{
			char[] array = this.key.ToUpper(CultureInfo.InvariantCulture).ToCharArray();
			byte[] array2 = new byte[52];
			uint[] array3 = new uint[4];
			uint num = 33U;
			int i;
			for (i = 0; i < this.key.Length; i++)
			{
				uint num2 = (num + 1973U) % 52U;
				num = (num2 + 1973U) % 52U;
				byte b = CdKey.w3KeyMap[(int)array[i]];
				array2[(int)num2] = b / 5;
				array2[(int)num] = b % 5;
			}
			i = 52;
			byte[] array4 = new byte[16];
			MemoryStream memoryStream = new MemoryStream(array4, true);
			do
			{
				CdKey.safemult(5, memoryStream, (uint)array2[i - 1]);
			}
			while (--i != 0);
			Buffer.BlockCopy(array4, 0, array3, 0, 16);
			CdKey.decodeKeyTable(array3);
			this.product = array3[0] >> 10;
			for (i = 0; i < 4; i++)
			{
				array3[i] = CdKey.SWAP4(array3[i]);
			}
			MemoryStream memoryStream2 = new MemoryStream(16);
			BinaryWriter binaryWriter = new BinaryWriter(memoryStream2);
			BinaryReader binaryReader = new BinaryReader(memoryStream2);
			binaryWriter.Write(array3[0]);
			binaryWriter.Write(array3[1]);
			binaryWriter.Write(array3[2]);
			binaryWriter.Write(array3[3]);
			memoryStream2.Seek(2L, SeekOrigin.Begin);
			this.val1 = CdKey.SWAP4(binaryReader.ReadUInt32() & 4294967043U);
			this.val2 = new byte[10];
			MemoryStream memoryStream3 = new MemoryStream(this.val2, true);
			BinaryWriter binaryWriter2 = new BinaryWriter(memoryStream3);
			binaryWriter2.Write(CdKey.SWAP2(binaryReader.ReadUInt16()));
			binaryWriter2.Write(CdKey.SWAP4(binaryReader.ReadUInt32()));
			binaryWriter2.Write(CdKey.SWAP4(binaryReader.ReadUInt32()));
			memoryStream2.Close();
			this.valid = true;
		}

		// Token: 0x0600B4D4 RID: 46292 RVA: 0x002C08A4 File Offset: 0x002BEAA4
		private static void safemult(int x, Stream a, uint dcByte)
		{
			a.Seek(12L, SeekOrigin.Begin);
			BinaryReader binaryReader = new BinaryReader(a);
			BinaryWriter binaryWriter = new BinaryWriter(a);
			ulong num = (ulong)(binaryReader.ReadUInt32() & uint.MaxValue) * (ulong)((long)x & (long)((ulong)(-1)));
			a.Seek(12L, SeekOrigin.Begin);
			binaryWriter.Write(dcByte + (uint)num);
			dcByte = (uint)(num >> 32);
			a.Seek(8L, SeekOrigin.Begin);
			num = (ulong)(binaryReader.ReadUInt32() & uint.MaxValue) * (ulong)((long)x & (long)((ulong)(-1)));
			a.Seek(8L, SeekOrigin.Begin);
			binaryWriter.Write(dcByte + (uint)num);
			dcByte = (uint)(num >> 32);
			a.Seek(4L, SeekOrigin.Begin);
			num = (ulong)(binaryReader.ReadUInt32() & uint.MaxValue) * (ulong)((long)x & (long)((ulong)(-1)));
			a.Seek(4L, SeekOrigin.Begin);
			binaryWriter.Write(dcByte + (uint)num);
			dcByte = (uint)(num >> 32);
			a.Seek(0L, SeekOrigin.Begin);
			num = (ulong)(binaryReader.ReadUInt32() & uint.MaxValue) * (ulong)((long)x & (long)((ulong)(-1)));
			a.Seek(0L, SeekOrigin.Begin);
			binaryWriter.Write(dcByte + (uint)num);
			dcByte = (uint)(num >> 32);
		}

		// Token: 0x0600B4D5 RID: 46293 RVA: 0x002C099C File Offset: 0x002BEB9C
		private static void decodeKeyTable(uint[] keyTable)
		{
			uint[] array = new uint[4];
			uint num = 29U;
			int i = 464;
			uint num2;
			do
			{
				num2 = (num & 7U) << 2;
				uint num3 = num >> 3;
				uint num4 = keyTable[(int)(3U - num3)];
				num4 &= 15U << (int)num2;
				num4 >>= (int)num2;
				bool flag = i < 464;
				int j;
				if (flag)
				{
					j = 29;
					while ((long)j > (long)((ulong)num))
					{
						uint num5 = (uint)((uint)(j & 7) << 2);
						uint num6 = keyTable[3 - (j >> 3)];
						num6 &= 15U << (int)num5;
						num6 >>= (int)num5;
						checked
						{
							num4 = (uint)CdKey.w3TranslateMap[(int)((IntPtr)(unchecked((ulong)num6 ^ (ulong)((long)((int)CdKey.w3TranslateMap[(int)(checked((IntPtr)(unchecked((ulong)num4 + (ulong)((long)i)))))] + i)))))];
						}
						j--;
					}
				}
				num = (uint)(j = (int)(num - 1U));
				while (j >= 0)
				{
					uint num5 = (uint)((long)j & 7L) << 2;
					uint num6 = keyTable[3 - (j >> 3)];
					num6 &= 15U << (int)num5;
					num6 >>= (int)num5;
					checked
					{
						num4 = (uint)CdKey.w3TranslateMap[(int)((IntPtr)(unchecked((ulong)num6 ^ (ulong)((long)((int)CdKey.w3TranslateMap[(int)(checked((IntPtr)(unchecked((ulong)num4 + (ulong)((long)i)))))] + i)))))];
					}
					j--;
				}
				j = (int)(3U - num3);
				checked
				{
					uint num7 = (uint)((uint)(CdKey.w3TranslateMap[(int)((IntPtr)(unchecked((ulong)num4 + (ulong)((long)i))))] & 15) << (int)num2);
					keyTable[j] = num7 | (~(15U << (int)num2) & keyTable[j]);
				}
			}
			while ((i -= 16) >= 0);
			num2 = 0U;
			for (i = 0; i < 4; i++)
			{
				array[i] = keyTable[i];
			}
			for (uint num8 = 0U; num8 < 120U; num8 += 1U)
			{
				uint num9 = 12U;
				uint num10 = num8 & 31U;
				uint num5 = num2 & 31U;
				uint num11 = 3U - (num8 >> 5);
				num9 -= num2 >> 5 << 2;
				num9 /= 4U;
				uint num6 = array[(int)num9];
				num6 &= 1U << (int)num5;
				num6 >>= (int)num5;
				uint num12 = keyTable[(int)num11];
				keyTable[(int)num11] = num6 & 1U;
				keyTable[(int)num11] <<= (int)num10;
				keyTable[(int)num11] |= ~(1U << (int)num10) & num12;
				num2 += 11U;
				bool flag2 = num2 >= 120U;
				if (flag2)
				{
					num2 -= 120U;
				}
			}
		}

		// Token: 0x0600B4D6 RID: 46294 RVA: 0x002C0BF4 File Offset: 0x002BEDF4
		private static uint SWAP4(uint num)
		{
			return ((num >> 24) & 255U) | ((num >> 8) & 65280U) | ((num << 8) & 16711680U) | ((num << 24) & 4278190080U);
		}

		// Token: 0x0600B4D7 RID: 46295 RVA: 0x002C0C30 File Offset: 0x002BEE30
		private static ushort SWAP2(ushort num)
		{
			return (ushort)(((num >> 8) & 255) | (((int)num << 8) & 65280));
		}

		// Token: 0x0600B4D8 RID: 46296 RVA: 0x002C0C58 File Offset: 0x002BEE58
		private void calculateHash(uint clientToken, uint serverToken)
		{
			MemoryStream memoryStream = new MemoryStream(26);
			BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
			binaryWriter.Write(clientToken);
			binaryWriter.Write(serverToken);
			int length = this.key.Length;
			int num = length;
			if (num != 13 && num != 16)
			{
				if (num == 26)
				{
					binaryWriter.Write(this.product);
					binaryWriter.Write(this.val1);
					binaryWriter.Write(this.val2);
					byte[] buffer = memoryStream.GetBuffer();
					SHA1 sha = SHA1.Create();
					this.hash = sha.ComputeHash(buffer);
				}
			}
			else
			{
				binaryWriter.Write(this.product);
				binaryWriter.Write(this.val1);
				binaryWriter.Write(0);
				binaryWriter.Write(this.val2);
				binaryWriter.Write(0);
				this.hash = XSha1.CalculateHash(memoryStream.GetBuffer());
			}
			memoryStream.Close();
		}

		// Token: 0x04005977 RID: 22903
		private string key;

		// Token: 0x04005978 RID: 22904
		private uint product;

		// Token: 0x04005979 RID: 22905
		private uint val1;

		// Token: 0x0400597A RID: 22906
		private byte[] val2;

		// Token: 0x0400597B RID: 22907
		private byte[] hash;

		// Token: 0x0400597C RID: 22908
		private bool valid;

		// Token: 0x0400597D RID: 22909
		private const uint W3_KEYLEN = 26U;

		// Token: 0x0400597E RID: 22910
		private const uint W3_BUFLEN = 52U;

		// Token: 0x0400597F RID: 22911
		private static readonly byte[] w2Map = new byte[]
		{
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			0, byte.MaxValue, 1, byte.MaxValue, 2, 3, 4, 5, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, 6, 7, 8, 9,
			10, 11, 12, byte.MaxValue, 13, 14, byte.MaxValue, 15, 16, byte.MaxValue,
			17, byte.MaxValue, 18, byte.MaxValue, 19, byte.MaxValue, 20, 21, 22, byte.MaxValue,
			23, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, 6, 7,
			8, 9, 10, 11, 12, byte.MaxValue, 13, 14, byte.MaxValue, 15,
			16, byte.MaxValue, 17, byte.MaxValue, 18, byte.MaxValue, 19, byte.MaxValue, 20, 21,
			22, byte.MaxValue, 23, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue
		};

		// Token: 0x04005980 RID: 22912
		private static readonly byte[] w3KeyMap = new byte[]
		{
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			0, byte.MaxValue, 1, byte.MaxValue, 2, 3, 4, 5, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, 6, 7, 8, 9,
			10, 11, 12, byte.MaxValue, 13, 14, byte.MaxValue, 15, 16, byte.MaxValue,
			17, byte.MaxValue, 18, byte.MaxValue, 19, byte.MaxValue, 20, 21, 22, 23,
			24, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, 6, 7,
			8, 9, 10, 11, 12, byte.MaxValue, 13, 14, byte.MaxValue, 15,
			16, byte.MaxValue, 17, byte.MaxValue, 18, byte.MaxValue, 19, byte.MaxValue, 20, 21,
			22, 23, 24, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue,
			byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue
		};

		// Token: 0x04005981 RID: 22913
		private static readonly byte[] w3TranslateMap = new byte[]
		{
			9, 4, 7, 15, 13, 10, 3, 11, 1, 2,
			12, 8, 6, 14, 5, 0, 9, 11, 5, 4,
			8, 15, 1, 14, 7, 0, 3, 2, 10, 6,
			13, 12, 12, 14, 1, 4, 9, 15, 10, 11,
			13, 6, 0, 8, 7, 2, 5, 3, 11, 2,
			5, 14, 13, 3, 9, 0, 1, 15, 7, 12,
			10, 6, 4, 8, 6, 2, 4, 5, 11, 8,
			12, 14, 13, 15, 7, 1, 10, 0, 3, 9,
			5, 4, 14, 12, 7, 6, 13, 10, 15, 2,
			9, 1, 0, 11, 8, 3, 12, 7, 8, 15,
			11, 0, 5, 9, 13, 10, 6, 14, 2, 4,
			3, 1, 3, 10, 14, 8, 1, 11, 5, 4,
			2, 15, 13, 12, 6, 7, 9, 0, 12, 13,
			1, 15, 8, 14, 5, 11, 3, 10, 9, 0,
			7, 2, 4, 6, 13, 10, 7, 14, 1, 6,
			11, 8, 15, 12, 5, 2, 3, 0, 4, 9,
			3, 14, 7, 5, 11, 15, 8, 12, 1, 10,
			4, 13, 0, 6, 9, 2, 11, 6, 9, 4,
			1, 8, 10, 13, 7, 14, 0, 12, 15, 2,
			3, 5, 12, 7, 8, 13, 3, 11, 0, 14,
			6, 15, 9, 4, 10, 1, 5, 2, 12, 6,
			13, 9, 11, 0, 1, 2, 15, 7, 3, 4,
			10, 14, 8, 5, 3, 6, 1, 5, 11, 12,
			8, 0, 15, 14, 9, 4, 7, 10, 13, 2,
			10, 7, 11, 15, 2, 8, 0, 13, 14, 12,
			1, 6, 9, 3, 5, 4, 10, 11, 13, 4,
			3, 8, 5, 9, 1, 0, 15, 12, 7, 14,
			2, 6, 11, 4, 13, 15, 1, 6, 3, 14,
			7, 10, 12, 8, 9, 2, 5, 0, 9, 6,
			7, 0, 1, 10, 13, 2, 3, 14, 15, 12,
			5, 11, 4, 8, 13, 14, 5, 6, 1, 9,
			8, 12, 2, 15, 3, 7, 11, 4, 0, 10,
			9, 15, 4, 0, 1, 6, 10, 14, 2, 3,
			7, 13, 5, 11, 8, 12, 3, 14, 1, 10,
			2, 12, 8, 4, 11, 7, 13, 0, 15, 6,
			9, 5, 7, 2, 12, 6, 10, 8, 11, 0,
			15, 4, 3, 14, 9, 1, 13, 5, 12, 4,
			5, 9, 10, 2, 8, 13, 3, 15, 1, 14,
			6, 7, 11, 0, 10, 8, 14, 13, 9, 15,
			3, 0, 4, 6, 1, 12, 7, 11, 2, 5,
			3, 12, 4, 10, 2, 15, 13, 14, 7, 0,
			5, 8, 1, 6, 11, 9, 10, 12, 1, 0,
			9, 14, 13, 11, 3, 7, 15, 8, 5, 2,
			4, 6, 14, 10, 1, 8, 7, 6, 5, 12,
			2, 15, 0, 13, 3, 11, 4, 9, 3, 8,
			14, 0, 7, 9, 15, 12, 1, 6, 13, 2,
			5, 10, 11, 4, 3, 10, 12, 4, 13, 11,
			9, 14, 15, 6, 1, 7, 2, 0, 5, 8
		};
	}
}
