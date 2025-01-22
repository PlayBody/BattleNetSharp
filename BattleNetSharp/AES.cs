using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BattleNetSharp
{
	// Token: 0x02000AF0 RID: 2800
	public class AES
	{
		// Token: 0x0600BD64 RID: 48484 RVA: 0x004859A0 File Offset: 0x00483BA0
		public static string Encrypt(string input, string password)
		{
			byte[] salt = AES.GetSalt();
			byte[] array = AES.CreateKey(password, salt);
			byte[] iv;
			byte[] array2;
			using (Aes aes = Aes.Create())
			{
				aes.Key = array;
				aes.Padding = PaddingMode.PKCS7;
				aes.Mode = CipherMode.CBC;
				aes.GenerateIV();
				iv = aes.IV;
				ICryptoTransform cryptoTransform = aes.CreateEncryptor(aes.Key, aes.IV);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
					{
						using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
						{
							streamWriter.Write(input);
						}
						array2 = memoryStream.ToArray();
					}
				}
			}
			byte[] array3 = new byte[salt.Length + iv.Length + array2.Length];
			Array.Copy(salt, 0, array3, 0, salt.Length);
			Array.Copy(iv, 0, array3, salt.Length, iv.Length);
			Array.Copy(array2, 0, array3, salt.Length + iv.Length, array2.Length);
			return Convert.ToBase64String(array3.ToArray<byte>());
		}

		// Token: 0x0600BD65 RID: 48485 RVA: 0x00485B00 File Offset: 0x00483D00
		public static string Decrypt(string input, string password)
		{
			string text = null;
			string text2;
			try
			{
				byte[] array = Convert.FromBase64String(input);
				byte[] array2 = new byte[32];
				byte[] array3 = new byte[16];
				byte[] array4 = new byte[array.Length - array2.Length - array3.Length];
				Array.Copy(array, 0, array2, 0, array2.Length);
				Array.Copy(array, array2.Length, array3, 0, array3.Length);
				Array.Copy(array, array2.Length + array3.Length, array4, 0, array4.Length);
				byte[] array5 = AES.CreateKey(password, array2);
				using (Aes aes = Aes.Create())
				{
					aes.Key = array5;
					aes.IV = array3;
					aes.Mode = CipherMode.CBC;
					aes.Padding = PaddingMode.PKCS7;
					ICryptoTransform cryptoTransform = aes.CreateDecryptor(aes.Key, aes.IV);
					using (MemoryStream memoryStream = new MemoryStream(array4))
					{
						using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Read))
						{
							using (StreamReader streamReader = new StreamReader(cryptoStream))
							{
								text = streamReader.ReadToEnd();
							}
						}
					}
				}
				text2 = text;
			}
			catch (Exception)
			{
				text2 = null;
			}
			return text2;
		}

		// Token: 0x0600BD66 RID: 48486 RVA: 0x00485CB8 File Offset: 0x00483EB8
		public static byte[] CreateKey(string password, byte[] salt)
		{
			byte[] bytes;
			using (Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, salt, AES.iterations))
			{
				bytes = rfc2898DeriveBytes.GetBytes(32);
			}
			return bytes;
		}

		// Token: 0x0600BD67 RID: 48487 RVA: 0x00485D00 File Offset: 0x00483F00
		private static byte[] GetSalt()
		{
			return RandomNumberGenerator.GetBytes(32);
		}

		// Token: 0x0600BD68 RID: 48488 RVA: 0x00485D1C File Offset: 0x00483F1C
		public static string GetUniqueKey(int maxSize)
		{
			char[] array = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
			byte[] bytes = RandomNumberGenerator.GetBytes(maxSize);
			StringBuilder stringBuilder = new StringBuilder(maxSize);
			foreach (byte b in bytes)
			{
				stringBuilder.Append(array[(int)b % array.Length]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04009162 RID: 37218
		private static readonly int iterations = 1000;
	}
}
