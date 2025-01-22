using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BattleNetSharp.D4.Packets
{
	// Token: 0x02000B14 RID: 2836
	public class ClientHello
	{
		// Token: 0x0600BE65 RID: 48741 RVA: 0x0048AD44 File Offset: 0x00488F44
		public static bool SolveDOSChallenge(byte[] key, int total_bits, out byte[] output)
		{
			output = new byte[8];
			bool flag = total_bits > 160;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				ulong num = 1UL;
				byte[] array;
				for (;;)
				{
					SHA1 sha = SHA1.Create();
					sha.Initialize();
					sha.TransformBlock(key, 0, key.Length, key, 0);
					array = BitConverter.GetBytes(num);
					sha.TransformFinalBlock(array, 0, array.Length);
					byte[] hash = sha.Hash;
					int num2 = 0;
					uint num3 = 0U;
					for (int i = 0; i < hash.Length; i++)
					{
						bool flag3 = hash[i] > 0;
						if (flag3)
						{
							break;
						}
						num3 += 8U;
						num2++;
					}
					bool flag4 = num2 < sha.HashSize;
					if (flag4)
					{
						byte b = hash[num2];
						while ((b & 1) == 0)
						{
							b = (byte)(b >> 1);
							num3 += 1U;
						}
					}
					bool flag5 = (ulong)num3 >= (ulong)((long)total_bits);
					if (flag5)
					{
						break;
					}
					ulong num4 = num;
					num = num4 + 1UL;
					bool flag6 = num4 == ulong.MaxValue;
					if (flag6)
					{
						goto Block_5;
					}
				}
				array = BitConverter.GetBytes(num);
				Buffer.BlockCopy(array, 0, output, 0, array.Length);
				return true;
				Block_5:
				flag2 = false;
			}
			return flag2;
		}

		// Token: 0x0600BE66 RID: 48742 RVA: 0x0048AE6C File Offset: 0x0048906C
		public static byte[] GeneratePuzzle(byte[] Key, int bits)
		{
			byte[] array = new byte[8];
			Random random = new Random();
			do
			{
				random.NextBytes(Key);
			}
			while (!ClientHello.SolveDOSChallenge(Key, bits, out array));
			return array;
		}

		// Token: 0x0600BE67 RID: 48743 RVA: 0x0048AEA8 File Offset: 0x004890A8
		public static byte[] KeyExpansion(int Size, byte[] KeyM, string pass, byte[] KeyA, byte[] KeyB)
		{
			byte[] array = new byte[Size];
			HMACSHA256 hmacsha = new HMACSHA256(KeyM);
			hmacsha.Initialize();
			byte[] array2 = Encoding.ASCII.GetBytes(pass);
			hmacsha.TransformBlock(array2, 0, array2.Length, array2, 0);
			hmacsha.TransformBlock(KeyA, 0, KeyA.Length, KeyA, 0);
			hmacsha.TransformFinalBlock(KeyB, 0, KeyB.Length);
			byte[] array3 = hmacsha.Hash;
			for (int i = 0; i < Size; i += 32)
			{
				bool flag = i != 0;
				if (flag)
				{
					hmacsha = new HMACSHA256(KeyM);
					hmacsha.Initialize();
					hmacsha.TransformFinalBlock(array3, 0, array3.Length);
					array3 = hmacsha.Hash;
				}
				hmacsha = new HMACSHA256(KeyM);
				hmacsha.Initialize();
				hmacsha.TransformBlock(array3, 0, array3.Length, array3, 0);
				array2 = Encoding.ASCII.GetBytes(pass);
				hmacsha.TransformBlock(array2, 0, array2.Length, array2, 0);
				hmacsha.TransformBlock(KeyA, 0, KeyA.Length, KeyA, 0);
				hmacsha.TransformFinalBlock(KeyB, 0, KeyB.Length);
				byte[] hash = hmacsha.Hash;
				int num = ((Size - i < 32) ? (Size - i) : 32);
				bool flag2 = num > 0;
				if (flag2)
				{
					Buffer.BlockCopy(hash, 0, array, i, num);
				}
			}
			return array;
		}

		// Token: 0x0600BE68 RID: 48744 RVA: 0x0048AFE4 File Offset: 0x004891E4
		public static byte[] KeyUpdate(byte[] key, string pass, byte[] salt)
		{
			HMACSHA256 hmacsha = new HMACSHA256(key);
			hmacsha.Initialize();
			byte[] bytes = Encoding.ASCII.GetBytes(pass);
			hmacsha.TransformBlock(bytes, 0, bytes.Length, bytes, 0);
			hmacsha.TransformFinalBlock(salt, 0, salt.Length);
			byte[] array = hmacsha.Hash;
			hmacsha = new HMACSHA256(key);
			hmacsha.TransformBlock(array, 0, array.Length, array, 0);
			hmacsha.TransformBlock(bytes, 0, bytes.Length, bytes, 0);
			hmacsha.TransformFinalBlock(salt, 0, salt.Length);
			array = hmacsha.Hash;
			return array.Take(12).ToArray<byte>();
		}

		// Token: 0x0600BE69 RID: 48745 RVA: 0x0048B074 File Offset: 0x00489274
		public static void GenerateKeys(byte[] A, byte[] B, byte[] MasterKey, out Crypto KeyA, out Crypto KeyB)
		{
			byte[] array = new byte[48];
			byte[] array2 = new byte[80];
			array = ClientHello.KeyExpansion(array.Length, MasterKey, "master secret", A, B);
			array2 = ClientHello.KeyExpansion(array2.Length, array, "key expansion", B, A);
			byte[] array3 = new byte[8];
			byte[] array4 = new byte[32];
			byte[] array5 = new byte[8];
			byte[] array6 = new byte[32];
			Array.Copy(array2, 64, array3, 0, 8);
			Array.Copy(array2, 0, array4, 0, 32);
			Array.Copy(array2, 72, array5, 0, 8);
			Array.Copy(array2, 32, array6, 0, 32);
			KeyA = new Crypto(array4, array3);
			KeyB = new Crypto(array6, array5);
		}

		// Token: 0x0600BE6A RID: 48746 RVA: 0x0048B11C File Offset: 0x0048931C
		public static byte[] ServerHello(byte[] chpBytes, byte[] shpBytes, byte[] master, byte[] A, byte[] B, out byte[] HandshakePuzzleClient)
		{
			SHA256 sha = SHA256.Create();
			sha.Initialize();
			sha.TransformBlock(chpBytes, 0, chpBytes.Length, chpBytes, 0);
			sha.TransformFinalBlock(shpBytes, 0, shpBytes.Length);
			byte[] hash = sha.Hash;
			byte[] array = ClientHello.KeyExpansion(48, master, "master secret", A, B);
			byte[] array2 = ClientHello.KeyUpdate(array, "server finished", hash);
			HandshakePuzzleClient = ClientHello.KeyUpdate(array, "client finished", hash);
			return array2;
		}

		// Token: 0x040091B2 RID: 37298
		public string Hello = "HELLO FEN CLIENT";

		// Token: 0x040091B3 RID: 37299
		public ulong Token;

		// Token: 0x040091B4 RID: 37300
		public byte[] A = new byte[32];

		// Token: 0x040091B5 RID: 37301
		public byte[] RSA = new byte[256];

		// Token: 0x040091B6 RID: 37302
		public byte[] MasterKey = new byte[48];
	}
}
