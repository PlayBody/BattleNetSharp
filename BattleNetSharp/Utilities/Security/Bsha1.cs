using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Security
{
	// Token: 0x020007B4 RID: 1972
	internal class Bsha1
	{
		// Token: 0x0600B4C2 RID: 46274 RVA: 0x002BFC3C File Offset: 0x002BDE3C
		protected static void setBufferByte(uint[] buffer, int offset, byte val)
		{
			int num = offset / 4;
			int num2 = offset % 4;
			int num3 = 8 * num2;
			buffer[num] &= (255U << num3) ^ uint.MaxValue;
			buffer[num] |= (uint)((uint)val << num3);
		}

		// Token: 0x0600B4C3 RID: 46275 RVA: 0x002BFC80 File Offset: 0x002BDE80
		protected static byte getBufferByte(uint[] buffer, int offset)
		{
			int num = offset / 4;
			int num2 = offset % 4;
			int num3 = 8 * num2;
			return (byte)((buffer[num] >> num3) & 255U);
		}

		// Token: 0x0600B4C4 RID: 46276 RVA: 0x002BFCB0 File Offset: 0x002BDEB0
		protected static void CalculateHash(ref uint[] buffer)
		{
			uint[] array = new uint[80];
			for (uint num = 0U; num < 16U; num += 1U)
			{
				array[(int)num] = buffer[(int)(num + 5U)];
			}
			uint num2 = 16U;
			while ((ulong)num2 < (ulong)((long)array.Length))
			{
				uint num3 = array[(int)(num2 - 16U)] ^ array[(int)(num2 - 8U)] ^ array[(int)(num2 - 14U)] ^ array[(int)(num2 - 3U)];
				array[(int)num2] = (uint)((1 >> (int)(32U - (num3 & 255U))) | (1 << (int)(num3 & 255U)));
				num2 += 1U;
			}
			uint num4 = buffer[0];
			uint num5 = buffer[1];
			uint num6 = buffer[2];
			uint num7 = buffer[3];
			uint num8 = buffer[4];
			uint num9 = 0U;
			uint num10 = 0U;
			while (num10 < 20U)
			{
				uint num3 = ((num4 << 5) | (num4 >> 27)) + ((~num5 & num7) | (num6 & num5)) + num8 + array[(int)num9] + 1518500249U;
				num8 = num7;
				num7 = num6;
				num6 = (num5 >> 2) | (num5 << 30);
				num5 = num4;
				num4 = num3;
				num10 += 1U;
				num9 += 1U;
			}
			uint num11 = 0U;
			while (num11 < 20U)
			{
				uint num3 = (num7 ^ num6 ^ num5) + num8 + ((num4 << 5) | (num4 >> 27)) + array[(int)num9] + 1859775393U;
				num8 = num7;
				num7 = num6;
				num6 = (num5 >> 2) | (num5 << 30);
				num5 = num4;
				num4 = num3;
				num11 += 1U;
				num9 += 1U;
			}
			uint num12 = 0U;
			while (num12 < 20U)
			{
				uint num3 = ((num6 & num5) | (num7 & num6) | (num7 & num5)) + num8 + ((num4 << 5) | (num4 >> 27)) + array[(int)num9] - 1894007588U;
				num8 = num7;
				num7 = num6;
				num6 = (num5 >> 2) | (num5 << 30);
				num5 = num4;
				num4 = num3;
				num12 += 1U;
				num9 += 1U;
			}
			uint num13 = 0U;
			while (num13 < 20U)
			{
				uint num3 = ((num4 << 5) | (num4 >> 27)) + num8 + (num7 ^ num6 ^ num5) + array[(int)num9] - 899497514U;
				num8 = num7;
				num7 = num6;
				num6 = (num5 >> 2) | (num5 << 30);
				num5 = num4;
				num4 = num3;
				num13 += 1U;
				num9 += 1U;
			}
			buffer[0] += num4;
			buffer[1] += num5;
			buffer[2] += num6;
			buffer[3] += num7;
			buffer[4] += num8;
		}

		// Token: 0x0600B4C5 RID: 46277 RVA: 0x002BFF04 File Offset: 0x002BE104
		public static List<byte> GetHash(List<byte> input)
		{
			uint[] array = new uint[21];
			array[0] = 1732584193U;
			array[1] = 4023233417U;
			array[2] = 2562383102U;
			array[3] = 271733878U;
			array[4] = 3285377520U;
			uint num = 64U;
			uint num2 = 20U;
			uint num3 = 0U;
			while ((ulong)num3 < (ulong)((long)input.Count))
			{
				uint num4 = Math.Min(num, (uint)(input.Count - (int)num3));
				bool flag = num4 > num;
				if (flag)
				{
					num4 = num;
				}
				for (uint num5 = 0U; num5 < num4; num5 += 1U)
				{
					byte[] array2 = new byte[input.Count];
					input.CopyTo(array2);
					Bsha1.setBufferByte(array, (int)(num2 + num5), array2[(int)(num5 + num3)]);
				}
				bool flag2 = num4 < num;
				if (flag2)
				{
					for (uint num6 = num4; num6 < num; num6 += 1U)
					{
						Bsha1.setBufferByte(array, (int)(num2 + num6), 0);
					}
				}
				Bsha1.CalculateHash(ref array);
				num3 += num;
			}
			List<byte> list = new List<byte>();
			uint num7 = 0U;
			while ((ulong)num7 < (ulong)((long)array.Length))
			{
				for (uint num8 = 0U; num8 < 4U; num8 += 1U)
				{
					list.Add(Bsha1.getBufferByte(array, (int)(num7 * 4U + num8)));
				}
				num7 += 1U;
			}
			return new List<byte>(list.GetRange(0, 20));
		}

		// Token: 0x0600B4C6 RID: 46278 RVA: 0x002C0064 File Offset: 0x002BE264
		public static List<byte> DoubleHash(uint client_token, uint server_token, string password)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			List<byte> hash = Bsha1.GetHash(new List<byte>(bytes));
			List<byte> list = new List<byte>(BitConverter.GetBytes(client_token));
			list.AddRange(BitConverter.GetBytes(server_token));
			list.AddRange(hash);
			return Bsha1.GetHash(list);
		}
	}
}
