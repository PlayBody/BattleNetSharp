using System;
using System.Linq;
using System.Text;

namespace BattleNetSharp
{
	// Token: 0x02000AEF RID: 2799
	public static class ProtobufDumper
	{
		// Token: 0x0600BD63 RID: 48483 RVA: 0x00485590 File Offset: 0x00483790
		public static string Dump(byte[] b, int depth = 0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			try
			{
				while (b.Length != 0)
				{
					int num = b[0] >> 3;
					int num2 = (int)(b[0] & 7);
					string text = new string(' ', depth * 4);
					stringBuilder.Append(text + num.ToString() + ": ");
					bool flag = num2 == 0;
					if (flag)
					{
						int num4;
						int num3 = (int)ProtobufDumper.VarintBitConverter.ToVarint(b.Skip(1).ToArray<byte>(), out num4);
						bool flag2 = num4 > b.Length;
						if (flag2)
						{
							return "wiretype2err2";
						}
						b = b.Skip(1 + num4).ToArray<byte>();
						stringBuilder.AppendLine(num3.ToString() + " (0x" + num3.ToString("X") + ")");
					}
					else
					{
						bool flag3 = num2 == 1;
						if (flag3)
						{
							bool flag4 = b.Length < 9;
							if (flag4)
							{
								return "wiretype1err";
							}
							long num5 = BitConverter.ToInt64(b.Skip(1).ToArray<byte>(), 0);
							b = b.Skip(9).ToArray<byte>();
							stringBuilder.AppendLine(string.Concat(new string[]
							{
								num5.ToString(),
								" (0x",
								num5.ToString("X"),
								") (",
								BitConverter.ToDouble(BitConverter.GetBytes(num5), 0).ToString(),
								"d)"
							}));
						}
						else
						{
							bool flag5 = num2 == 5;
							if (flag5)
							{
								bool flag6 = b.Length < 6;
								if (flag6)
								{
									break;
								}
								int num6 = BitConverter.ToInt32(b.Skip(1).ToArray<byte>(), 0);
								b = b.Skip(5).ToArray<byte>();
								stringBuilder.AppendLine(string.Concat(new string[]
								{
									num6.ToString(),
									" (0x",
									num6.ToString("X"),
									") (",
									BitConverter.ToSingle(BitConverter.GetBytes(num6), 0).ToString(),
									"f)"
								}));
							}
							else
							{
								bool flag7 = num2 == 2;
								if (!flag7)
								{
									stringBuilder.AppendLine(string.Concat(new string[]
									{
										" err wiretype ",
										num2.ToString(),
										" : ",
										b.Length.ToString(),
										" : ",
										Convert.ToBase64String(b)
									}));
									break;
								}
								bool flag8 = b.Length == 1;
								if (flag8)
								{
									return "wiretype2err1";
								}
								int num8;
								int num7 = (int)ProtobufDumper.VarintBitConverter.ToVarint(b.Skip(1).ToArray<byte>(), out num8);
								bool flag9 = Math.Abs(num7) > b.Length;
								if (flag9)
								{
									return "wiretype2err2";
								}
								byte[] array = new byte[num7];
								Array.Copy(b, 1 + num8, array, 0, num7);
								b = b.Skip(1 + num8 + num7).ToArray<byte>();
								bool flag10 = array.All((byte v) => v >= 32 && v <= 126);
								if (flag10)
								{
									stringBuilder.AppendLine("\"" + Encoding.UTF8.GetString(array) + "\"");
								}
								else
								{
									string @string = Encoding.UTF8.GetString(array);
									string string2 = Encoding.Unicode.GetString(array);
									stringBuilder.AppendLine(" { // bytes : " + Convert.ToBase64String(array));
									try
									{
										stringBuilder.Append(ProtobufDumper.Dump(array, depth + 1));
									}
									catch
									{
										stringBuilder.AppendLine("unkbytes");
									}
									stringBuilder.AppendLine(text + "}");
								}
							}
						}
					}
				}
			}
			catch
			{
				stringBuilder.AppendLine("parse error");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x020013CC RID: 5068
		public class VarintBitConverter
		{
			// Token: 0x0600E0FE RID: 57598 RVA: 0x004C9180 File Offset: 0x004C7380
			public static byte[] GetVarintBytes(byte value)
			{
				return ProtobufDumper.VarintBitConverter.GetVarintBytes((ulong)value);
			}

			// Token: 0x0600E0FF RID: 57599 RVA: 0x004C919C File Offset: 0x004C739C
			public static byte[] GetVarintBytes(short value)
			{
				long num = ProtobufDumper.VarintBitConverter.EncodeZigZag((long)value, 16);
				return ProtobufDumper.VarintBitConverter.GetVarintBytes((ulong)num);
			}

			// Token: 0x0600E100 RID: 57600 RVA: 0x004C91C0 File Offset: 0x004C73C0
			public static byte[] GetVarintBytes(ushort value)
			{
				return ProtobufDumper.VarintBitConverter.GetVarintBytes((ulong)value);
			}

			// Token: 0x0600E101 RID: 57601 RVA: 0x004C91DC File Offset: 0x004C73DC
			public static byte[] GetVarintBytes(int value)
			{
				long num = ProtobufDumper.VarintBitConverter.EncodeZigZag((long)value, 32);
				return ProtobufDumper.VarintBitConverter.GetVarintBytes((ulong)num);
			}

			// Token: 0x0600E102 RID: 57602 RVA: 0x004C9200 File Offset: 0x004C7400
			public static byte[] GetVarintBytes(uint value)
			{
				return ProtobufDumper.VarintBitConverter.GetVarintBytes((ulong)value);
			}

			// Token: 0x0600E103 RID: 57603 RVA: 0x004C921C File Offset: 0x004C741C
			public static byte[] GetVarintBytes(long value)
			{
				long num = ProtobufDumper.VarintBitConverter.EncodeZigZag(value, 64);
				return ProtobufDumper.VarintBitConverter.GetVarintBytes((ulong)num);
			}

			// Token: 0x0600E104 RID: 57604 RVA: 0x004C9240 File Offset: 0x004C7440
			public static byte[] GetVarintBytes(ulong value)
			{
				byte[] array = new byte[10];
				int num = 0;
				do
				{
					ulong num2 = value & 127UL;
					value >>= 7;
					bool flag = value > 0UL;
					if (flag)
					{
						num2 |= 128UL;
					}
					array[num++] = (byte)num2;
				}
				while (value > 0UL);
				byte[] array2 = new byte[num];
				Buffer.BlockCopy(array, 0, array2, 0, num);
				return array2;
			}

			// Token: 0x0600E105 RID: 57605 RVA: 0x004C92A8 File Offset: 0x004C74A8
			public static byte ToByte(byte[] bytes)
			{
				return (byte)ProtobufDumper.VarintBitConverter.ToTarget(bytes, 8);
			}

			// Token: 0x0600E106 RID: 57606 RVA: 0x004C92C4 File Offset: 0x004C74C4
			public static short ToInt16(byte[] bytes)
			{
				ulong num = ProtobufDumper.VarintBitConverter.ToTarget(bytes, 16);
				return (short)ProtobufDumper.VarintBitConverter.DecodeZigZag(num);
			}

			// Token: 0x0600E107 RID: 57607 RVA: 0x004C92E8 File Offset: 0x004C74E8
			public static ushort ToUInt16(byte[] bytes)
			{
				return (ushort)ProtobufDumper.VarintBitConverter.ToTarget(bytes, 16);
			}

			// Token: 0x0600E108 RID: 57608 RVA: 0x004C9304 File Offset: 0x004C7504
			public static int ToInt32(byte[] bytes)
			{
				ulong num = ProtobufDumper.VarintBitConverter.ToTarget(bytes, 32);
				return (int)ProtobufDumper.VarintBitConverter.DecodeZigZag(num);
			}

			// Token: 0x0600E109 RID: 57609 RVA: 0x004C9328 File Offset: 0x004C7528
			public static uint ToUInt32(byte[] bytes)
			{
				return (uint)ProtobufDumper.VarintBitConverter.ToTarget(bytes, 32);
			}

			// Token: 0x0600E10A RID: 57610 RVA: 0x004C9344 File Offset: 0x004C7544
			public static long ToInt64(byte[] bytes)
			{
				ulong num = ProtobufDumper.VarintBitConverter.ToTarget(bytes, 64);
				return ProtobufDumper.VarintBitConverter.DecodeZigZag(num);
			}

			// Token: 0x0600E10B RID: 57611 RVA: 0x004C9368 File Offset: 0x004C7568
			public static ulong ToUInt64(byte[] bytes)
			{
				return ProtobufDumper.VarintBitConverter.ToTarget(bytes, 64);
			}

			// Token: 0x0600E10C RID: 57612 RVA: 0x004C9384 File Offset: 0x004C7584
			private static long EncodeZigZag(long value, int bitLength)
			{
				return (value << 1) ^ (value >> bitLength - 1);
			}

			// Token: 0x0600E10D RID: 57613 RVA: 0x004C93A4 File Offset: 0x004C75A4
			private static long DecodeZigZag(ulong value)
			{
				bool flag = (value & 1UL) == 1UL;
				long num;
				if (flag)
				{
					num = (long)(ulong.MaxValue * ((value >> 1) + 1UL));
				}
				else
				{
					num = (long)(value >> 1);
				}
				return num;
			}

			// Token: 0x0600E10E RID: 57614 RVA: 0x004C93D4 File Offset: 0x004C75D4
			private static ulong ToTarget(byte[] bytes, int sizeBites)
			{
				int num = 0;
				ulong num2 = 0UL;
				foreach (ulong num3 in bytes)
				{
					ulong num4 = num3 & 127UL;
					num2 |= num4 << num;
					bool flag = num > sizeBites;
					if (flag)
					{
						throw new ArgumentOutOfRangeException("bytes", "Byte array is too large.");
					}
					bool flag2 = (num3 & 128UL) != 128UL;
					if (flag2)
					{
						return num2;
					}
					num += 7;
				}
				throw new ArgumentException("Cannot decode varint from byte array.", "bytes");
			}

			// Token: 0x0600E10F RID: 57615 RVA: 0x004C9464 File Offset: 0x004C7664
			public static ulong ToVarint(byte[] bytes, out int numBytes)
			{
				int num = 0;
				ulong num2 = 0UL;
				int num3 = 0;
				int i = 0;
				while (i < bytes.Length)
				{
					ulong num4 = (ulong)bytes[i];
					num3++;
					ulong num5 = num4 & 127UL;
					num2 |= num5 << num;
					bool flag = num > 64;
					ulong num6;
					if (flag)
					{
						numBytes = int.MaxValue;
						num6 = 2147483647UL;
					}
					else
					{
						bool flag2 = (num4 & 128UL) != 128UL;
						if (!flag2)
						{
							num += 7;
							i++;
							continue;
						}
						numBytes = num3;
						num6 = num2;
					}
					return num6;
				}
				numBytes = int.MaxValue;
				return 2147483647UL;
			}
		}
	}
}
