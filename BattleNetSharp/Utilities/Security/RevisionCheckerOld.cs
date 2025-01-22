using System;
using System.Globalization;
using System.IO;

namespace Utilities.Security
{
	// Token: 0x020007B9 RID: 1977
	public class RevisionCheckerOld
	{
		// Token: 0x0600B4E1 RID: 46305 RVA: 0x002C1148 File Offset: 0x002BF348
		private static int getNum(char c)
		{
			c = char.ToUpper(c, CultureInfo.InvariantCulture);
			bool flag = c == 'S';
			int num;
			if (flag)
			{
				num = 3;
			}
			else
			{
				num = (int)(c - 'A');
			}
			return num;
		}

		// Token: 0x0600B4E2 RID: 46306 RVA: 0x002C1178 File Offset: 0x002BF378
		public static int CheckRevision(string formulaString, string[] files, int mpqNumber)
		{
			uint[] array = new uint[4];
			int[] array2 = new int[4];
			int[] array3 = new int[4];
			char[] array4 = new char[4];
			int[] array5 = new int[4];
			string[] array6 = formulaString.Split(new char[] { ' ' });
			int num = 0;
			foreach (string text in array6)
			{
				bool flag = text.IndexOf('=') != -1;
				if (flag)
				{
					string[] array7 = text.Split(new char[] { '=' });
					bool flag2 = array7.Length != 2;
					if (flag2)
					{
						return 0;
					}
					int num2 = RevisionCheckerOld.getNum(array7[0][0]);
					string text2 = array7[1];
					bool flag3 = char.IsDigit(text2[0]);
					if (flag3)
					{
						array[num2] = uint.Parse(text2, CultureInfo.InvariantCulture);
					}
					else
					{
						array2[num] = num2;
						array3[num] = RevisionCheckerOld.getNum(text2[0]);
						array4[num] = text2[1];
						array5[num] = RevisionCheckerOld.getNum(text2[2]);
						num++;
					}
				}
			}
			array[0] ^= RevisionCheckerOld.hashcodes[mpqNumber];
			byte[] array8 = new byte[1024];
			for (int j = 0; j < files.Length; j++)
			{
				using (FileStream fileStream = new FileStream(files[j], FileMode.Open, FileAccess.Read, FileShare.Read))
				{
					while (fileStream.Position < fileStream.Length)
					{
						long num3 = Math.Min(fileStream.Length - fileStream.Position, 1024L);
						fileStream.Read(array8, 0, (int)num3);
						bool flag4 = num3 < 1024L;
						if (flag4)
						{
							byte b = byte.MaxValue;
							for (int k = (int)num3; k < 1024; k++)
							{
								byte[] array9 = array8;
								int num4 = k;
								byte b2 = b;
								b = b2 - 1;
								array9[num4] = b2;
							}
						}
						for (int l = 0; l < 1024; l += 4)
						{
							array[3] = BitConverter.ToUInt32(array8, l);
							for (int m = 0; m < num; m++)
							{
								char c = array4[m];
								char c2 = c;
								switch (c2)
								{
								case '*':
									array[array2[m]] = array[array3[m]] * array[array5[m]];
									break;
								case '+':
									array[array2[m]] = array[array3[m]] + array[array5[m]];
									break;
								case ',':
								case '.':
									break;
								case '-':
									array[array2[m]] = array[array3[m]] - array[array5[m]];
									break;
								case '/':
									array[array2[m]] = array[array3[m]] / array[array5[m]];
									break;
								default:
									if (c2 == '^')
									{
										array[array2[m]] = array[array3[m]] ^ array[array5[m]];
									}
									break;
								}
							}
						}
					}
				}
			}
			return (int)array[2];
		}

		// Token: 0x04005989 RID: 22921
		private static uint[] hashcodes = new uint[] { 3891579746U, 4137766908U, 2857698479U, 2267008450U, 297757208U, 3312620262U, 2032652926U, 804030259U };
	}
}
