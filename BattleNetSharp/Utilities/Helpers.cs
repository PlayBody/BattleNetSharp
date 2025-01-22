using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

namespace Utilities
{
	// Token: 0x020007B3 RID: 1971
	public static class Helpers
	{
		// Token: 0x0600B4B5 RID: 46261 RVA: 0x002BF814 File Offset: 0x002BDA14
		public static uint ToUnixTime(this DateTime time)
		{
			return (uint)((time.ToUniversalTime().Ticks - 621355968000000000L) / 10000000L);
		}

		// Token: 0x0600B4B6 RID: 46262 RVA: 0x002BF848 File Offset: 0x002BDA48
		public static ulong ToExtendedEpoch(this DateTime time)
		{
			return (ulong)((time.ToUniversalTime().Ticks - 621355968000000000L) / 10L);
		}

		// Token: 0x0600B4B7 RID: 46263 RVA: 0x002BF878 File Offset: 0x002BDA78
		public static byte[] StringToByteArray(string hex)
		{
			return (from x in Enumerable.Range(0, hex.Length)
				where x % 2 == 0
				select Convert.ToByte(hex.Substring(x, 2), 16)).ToArray<byte>();
		}

		// Token: 0x0600B4B8 RID: 46264 RVA: 0x002BF8E4 File Offset: 0x002BDAE4
		public static byte[] DecompressStream(byte[] data, uint len = 32768U)
		{
			bool flag = data[0] == 120 && data[1] == 156;
			if (flag)
			{
				Helpers.ResetDecompression();
				data = data.Skip(2).ToArray<byte>();
			}
			long position = Helpers.ms.Position;
			Helpers.ms.Write(data);
			Helpers.ms.Position = position;
			List<byte> list = new List<byte>();
			for (;;)
			{
				byte[] array = new byte[32768];
				int num = Helpers.ds.Read(array);
				bool flag2 = num == 0;
				if (flag2)
				{
					break;
				}
				list.AddRange(array.Take(num));
				bool flag3 = (long)num == (long)((ulong)len);
				if (flag3)
				{
					goto Block_4;
				}
			}
			return list.ToArray();
			Block_4:
			return list.ToArray();
		}

		// Token: 0x0600B4B9 RID: 46265 RVA: 0x002BF9B1 File Offset: 0x002BDBB1
		public static void ResetDecompression()
		{
			Helpers.Console.WriteLine("resetting compressor");
			Helpers.ms = new MemoryStream();
			Helpers.ds = new DeflateStream(Helpers.ms, CompressionMode.Decompress, true);
		}

		// Token: 0x0600B4BA RID: 46266 RVA: 0x002BF9DC File Offset: 0x002BDBDC
		public static float RunTime()
		{
			return (float)(Environment.TickCount - Helpers.StartTime) / 1000f;
		}

		// Token: 0x0600B4BB RID: 46267 RVA: 0x002BFA04 File Offset: 0x002BDC04
		public static float DistanceSquared(ushort x1, ushort y1, ushort x2, ushort y2)
		{
			return (float)(Math.Pow((double)(x1 - x2), 2.0) + Math.Pow((double)(y1 - y2), 2.0));
		}

		// Token: 0x0600B4BC RID: 46268 RVA: 0x002BFA3C File Offset: 0x002BDC3C
		public static float GetDistance(ushort x1, ushort y1, ushort x2, ushort y2)
		{
			return (float)Math.Sqrt((double)Helpers.DistanceSquared(x1, y1, x2, y2));
		}

		// Token: 0x0600B4BD RID: 46269 RVA: 0x002BFA60 File Offset: 0x002BDC60
		public static string RandomString(int length, bool containsNumbers = true)
		{
			string text;
			if (containsNumbers)
			{
				text = new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
					select s[Helpers.random.Next(s.Length)]).ToArray<char>());
			}
			else
			{
				text = new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ", length)
					select s[Helpers.random.Next(s.Length)]).ToArray<char>());
			}
			return text;
		}

		// Token: 0x0600B4BE RID: 46270 RVA: 0x002BFAEC File Offset: 0x002BDCEC
		public static string ReadString(this BinaryReader reader, int length = -1)
		{
			bool flag = reader.BaseStream.Position == reader.BaseStream.Length;
			string text;
			if (flag)
			{
				text = "";
			}
			else
			{
				long position = reader.BaseStream.Position;
				List<byte> list = new List<byte>();
				byte b;
				do
				{
					b = reader.ReadByte();
					list.Add(b);
				}
				while (b > 0);
				length = list.Count;
				reader.BaseStream.Position = position + (long)length;
				IEnumerable<byte> enumerable = list.Take(list.Count<byte>() - 1);
				text = Encoding.ASCII.GetString(enumerable.ToArray<byte>());
			}
			return text;
		}

		// Token: 0x0600B4BF RID: 46271 RVA: 0x002BFB94 File Offset: 0x002BDD94
		public static string TrimString(this string str, char term)
		{
			bool flag = str.Contains('\0');
			if (flag)
			{
				str = str.Substring(0, str.IndexOf(term));
			}
			return str;
		}

		// Token: 0x0600B4C0 RID: 46272 RVA: 0x002BFBC4 File Offset: 0x002BDDC4
		public static ulong Checksum(this string str)
		{
			ulong num = 0UL;
			for (int i = 0; i < str.Length; i++)
			{
				num = num * 33UL + (ulong)((byte)str[i]);
			}
			return num;
		}

		// Token: 0x04005972 RID: 22898
		private static MemoryStream ms = new MemoryStream();

		// Token: 0x04005973 RID: 22899
		private static DeflateStream ds = new DeflateStream(Helpers.ms, CompressionMode.Decompress, true);

		// Token: 0x04005974 RID: 22900
		public static int StartTime = Environment.TickCount;

		// Token: 0x04005975 RID: 22901
		public static string InstallPath = "D:\\d2\\installdir\\";

		// Token: 0x04005976 RID: 22902
		private static Random random = new Random();

		// Token: 0x020012DC RID: 4828
		public static class Console
		{
			// Token: 0x0600DE75 RID: 56949 RVA: 0x004C132E File Offset: 0x004BF52E
			public static void WriteLine(string log)
			{
				global::System.Console.WriteLine(log);
				Action<string> logger = Helpers.Console.Logger;
				if (logger != null)
				{
					logger(log);
				}
			}

			// Token: 0x040099E9 RID: 39401
			public static Action<string> Logger;
		}
	}
}
