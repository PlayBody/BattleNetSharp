using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace PacketDotNet
{
	// Token: 0x02000825 RID: 2085
	public static class TLS
	{
		// Token: 0x0600B554 RID: 46420 RVA: 0x002C3724 File Offset: 0x002C1924
		public static byte[] PRF(byte[] secret, string label, byte[] data, int length, string tls, string sha)
		{
			int num = secret.Length >> 1;
			bool flag = (secret.Length & 1) == 1;
			if (flag)
			{
				num++;
			}
			TLS.TlsStream tlsStream = new TLS.TlsStream();
			tlsStream.Write(Encoding.ASCII.GetBytes(label));
			tlsStream.Write(data);
			byte[] array = tlsStream.ToArray();
			tlsStream.Reset();
			bool flag2 = "TLS1.2".Equals(tls, StringComparison.OrdinalIgnoreCase);
			byte[] array2;
			if (flag2)
			{
				array2 = TLS.Expand("SHA" + sha, secret, array, length);
			}
			else
			{
				byte[] array3 = new byte[num];
				Buffer.BlockCopy(secret, 0, array3, 0, num);
				byte[] array4 = new byte[num];
				Buffer.BlockCopy(secret, secret.Length - num, array4, 0, num);
				byte[] array5 = TLS.Expand("MD5", array3, array, length);
				byte[] array6 = TLS.Expand("SHA1", array4, array, length);
				array2 = new byte[length];
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i] = (byte)(array5[i] ^ array6[i]);
				}
			}
			return array2;
		}

		// Token: 0x0600B555 RID: 46421 RVA: 0x002C382C File Offset: 0x002C1A2C
		public static byte[] Expand(string hashName, byte[] secret, byte[] seed, int length)
		{
			HMAC hmac;
			if (!(hashName == "MD5"))
			{
				if (!(hashName == "SHA1"))
				{
					if (!(hashName == "SHA384"))
					{
						if (!(hashName == "SHA512"))
						{
							hmac = new HMACSHA256(secret);
						}
						else
						{
							hmac = new HMACSHA512(secret);
						}
					}
					else
					{
						hmac = new HMACSHA384(secret);
					}
				}
				else
				{
					hmac = new HMACSHA1(secret);
				}
			}
			else
			{
				hmac = new HMACMD5(secret);
			}
			int num = hmac.HashSize >> 3;
			int num2 = length / num;
			bool flag = length % num > 0;
			if (flag)
			{
				num2++;
			}
			TLS.TlsStream tlsStream = new TLS.TlsStream();
			byte[][] array = new byte[num2 + 1][];
			array[0] = seed;
			for (int i = 1; i <= num2; i++)
			{
				TLS.TlsStream tlsStream2 = new TLS.TlsStream();
				hmac.ComputeHash(array[i - 1], 0, array[i - 1].Length);
				array[i] = hmac.Hash;
				tlsStream2.Write(array[i]);
				tlsStream2.Write(seed);
				hmac.ComputeHash(tlsStream2.ToArray(), 0, (int)tlsStream2.Length);
				tlsStream.Write(hmac.Hash);
				tlsStream2.Reset();
			}
			byte[] array2 = new byte[length];
			Buffer.BlockCopy(tlsStream.ToArray(), 0, array2, 0, array2.Length);
			tlsStream.Reset();
			return array2;
		}

		// Token: 0x04005B48 RID: 23368
		public static List<TLS.TlsDecryptSession> TlsDecryptSessions = new List<TLS.TlsDecryptSession>();

		// Token: 0x020012E8 RID: 4840
		public class TlsDecryptSession
		{
			// Token: 0x0600DE83 RID: 56963 RVA: 0x004C16F4 File Offset: 0x004BF8F4
			public void Update()
			{
				byte[] array = TLS.PRF(this.Premaster, "key expansion", new List<byte>().Concat(this.ServerRandom).Concat(this.ClientRandom).ToArray<byte>(), 96, "TLS1.2", "384");
				this.ClientKey = array.Skip(0).Take(32).ToArray<byte>();
				this.ServerKey = array.Skip(32).Take(32).ToArray<byte>();
				this.ClientNonce = array.Skip(64).Take(4).ToArray<byte>();
				this.ServerNonce = array.Skip(68).Take(4).ToArray<byte>();
				byte[] array2 = TLS.PRF(this.Premaster, "key expansion", new List<byte>().Concat(this.ServerRandom).Concat(this.ClientRandom).ToArray<byte>(), 136, "TLS1.2", "256");
				this.ClientMac = array2.Skip(0).Take(20).ToArray<byte>();
				this.ServerMac = array2.Skip(20).Take(20).ToArray<byte>();
				this.ClientKey = array2.Skip(40).Take(32).ToArray<byte>();
				this.ServerKey = array2.Skip(72).Take(32).ToArray<byte>();
				this.ClientIv = array2.Skip(104).Take(16).ToArray<byte>();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine(string.Concat(new string[]
				{
					"openssl enc -aes-256-cbc -d -K ",
					BitConverter.ToString(this.ClientKey).Replace("-", ""),
					" -iv ",
					BitConverter.ToString(this.ClientIv).Replace("-", ""),
					" -in ./test.bin -out ./dec.bin"
				}));
				this.ServerIv = array2.Skip(120).Take(16).ToArray<byte>();
			}

			// Token: 0x0600DE84 RID: 56964 RVA: 0x004C18F0 File Offset: 0x004BFAF0
			public void DecryptBlock(int sourcePort, byte[] applicationData)
			{
				Aes aes = Aes.Create();
				aes.Key = ((sourcePort == this.SrcPort) ? this.ClientKey : this.ServerKey);
				aes.IV = new byte[16];
				aes.Mode = CipherMode.CBC;
				aes.Padding = PaddingMode.None;
				ICryptoTransform cryptoTransform = aes.CreateDecryptor(aes.Key, aes.IV);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
					{
						cryptoStream.Write(applicationData, 0, applicationData.Length);
						try
						{
							cryptoStream.FlushFinalBlock();
							byte[] array = memoryStream.ToArray();
							bool flag = array.Length > 16;
							if (flag)
							{
								this.DecryptedData.Add(array.Skip(16).Take(array.Length - 16).ToArray<byte>());
							}
						}
						catch
						{
							this.DecryptedData.Add(new byte[] { 72 });
							Console.WriteLine("decrypt fail");
						}
					}
				}
				bool flag2 = this.SrcPort == sourcePort;
				if (flag2)
				{
				}
			}

			// Token: 0x0600DE85 RID: 56965 RVA: 0x004C1A34 File Offset: 0x004BFC34
			public void DecryptBlock2(int sourcePort, byte[] applicationData)
			{
				byte[] array = ((sourcePort == this.SrcPort) ? this.ClientNonce : this.ServerNonce).Concat(applicationData.Take(8)).ToArray<byte>();
				byte[] array2 = applicationData.Skip(8).Take(applicationData.Length - 24).ToArray<byte>();
				byte[] array3 = new byte[array2.Length];
				byte[] array4 = applicationData.Skip(applicationData.Length - 16).ToArray<byte>();
				byte[] array5 = BitConverter.GetBytes((ushort)(applicationData.Length - 24)).Reverse<byte>().ToArray<byte>();
				byte[] array6 = applicationData.Take(8).Concat(new byte[] { 23, 3, 3 }).Concat(array5)
					.ToArray<byte>();
				using (AesGcm aesGcm = new AesGcm((sourcePort == this.SrcPort) ? this.ClientKey : this.ServerKey))
				{
					aesGcm.Decrypt(array, array2, array4, array3, array6);
				}
				this.DecryptedData.Add(array3);
			}

			// Token: 0x0600DE86 RID: 56966 RVA: 0x004C1B3C File Offset: 0x004BFD3C
			public void Encrypt()
			{
			}

			// Token: 0x04009C8F RID: 40079
			public int SrcPort;

			// Token: 0x04009C90 RID: 40080
			public int DestPort;

			// Token: 0x04009C91 RID: 40081
			public byte[] Premaster;

			// Token: 0x04009C92 RID: 40082
			public byte[] ClientRandom;

			// Token: 0x04009C93 RID: 40083
			public byte[] ServerRandom;

			// Token: 0x04009C94 RID: 40084
			public byte[] ClientKey;

			// Token: 0x04009C95 RID: 40085
			public byte[] ServerKey;

			// Token: 0x04009C96 RID: 40086
			public byte[] ClientNonce;

			// Token: 0x04009C97 RID: 40087
			public byte[] ServerNonce;

			// Token: 0x04009C98 RID: 40088
			public byte[] ClientIv;

			// Token: 0x04009C99 RID: 40089
			public byte[] ServerIv;

			// Token: 0x04009C9A RID: 40090
			public byte[] ClientMac;

			// Token: 0x04009C9B RID: 40091
			public byte[] ServerMac;

			// Token: 0x04009C9C RID: 40092
			public List<byte[]> DecryptedData = new List<byte[]>();
		}

		// Token: 0x020012E9 RID: 4841
		private class TlsStream : Stream
		{
			// Token: 0x17003965 RID: 14693
			// (get) Token: 0x0600DE88 RID: 56968 RVA: 0x004C1B54 File Offset: 0x004BFD54
			public bool EOF
			{
				get
				{
					bool flag = this.Position < this.Length;
					return !flag;
				}
			}

			// Token: 0x17003966 RID: 14694
			// (get) Token: 0x0600DE89 RID: 56969 RVA: 0x004C1B80 File Offset: 0x004BFD80
			public override bool CanWrite
			{
				get
				{
					return this.canWrite;
				}
			}

			// Token: 0x17003967 RID: 14695
			// (get) Token: 0x0600DE8A RID: 56970 RVA: 0x004C1B98 File Offset: 0x004BFD98
			public override bool CanRead
			{
				get
				{
					return this.canRead;
				}
			}

			// Token: 0x17003968 RID: 14696
			// (get) Token: 0x0600DE8B RID: 56971 RVA: 0x004C1BB0 File Offset: 0x004BFDB0
			public override bool CanSeek
			{
				get
				{
					return this.buffer.CanSeek;
				}
			}

			// Token: 0x17003969 RID: 14697
			// (get) Token: 0x0600DE8C RID: 56972 RVA: 0x004C1BD0 File Offset: 0x004BFDD0
			// (set) Token: 0x0600DE8D RID: 56973 RVA: 0x004C1BED File Offset: 0x004BFDED
			public override long Position
			{
				get
				{
					return this.buffer.Position;
				}
				set
				{
					this.buffer.Position = value;
				}
			}

			// Token: 0x1700396A RID: 14698
			// (get) Token: 0x0600DE8E RID: 56974 RVA: 0x004C1C00 File Offset: 0x004BFE00
			public override long Length
			{
				get
				{
					return this.buffer.Length;
				}
			}

			// Token: 0x0600DE8F RID: 56975 RVA: 0x004C1C1D File Offset: 0x004BFE1D
			public TlsStream()
			{
				this.buffer = new MemoryStream(0);
				this.canRead = false;
				this.canWrite = true;
			}

			// Token: 0x0600DE90 RID: 56976 RVA: 0x004C1C44 File Offset: 0x004BFE44
			public TlsStream(byte[] data)
			{
				bool flag = data != null;
				if (flag)
				{
					this.buffer = new MemoryStream(data);
				}
				else
				{
					this.buffer = new MemoryStream();
				}
				this.canRead = true;
				this.canWrite = false;
			}

			// Token: 0x0600DE91 RID: 56977 RVA: 0x004C1C88 File Offset: 0x004BFE88
			private byte[] ReadSmallValue(int length)
			{
				bool flag = length > 4;
				if (flag)
				{
					throw new ArgumentException("8 bytes maximum");
				}
				bool flag2 = this.temp == null;
				if (flag2)
				{
					this.temp = new byte[4];
				}
				bool flag3 = this.Read(this.temp, 0, length) != length;
				if (flag3)
				{
					throw new Exception(string.Format("buffer underrun", Array.Empty<object>()));
				}
				return this.temp;
			}

			// Token: 0x0600DE92 RID: 56978 RVA: 0x004C1CFC File Offset: 0x004BFEFC
			public new byte ReadByte()
			{
				byte[] array = this.ReadSmallValue(1);
				return array[0];
			}

			// Token: 0x0600DE93 RID: 56979 RVA: 0x004C1D1C File Offset: 0x004BFF1C
			public short ReadInt16()
			{
				byte[] array = this.ReadSmallValue(2);
				return (short)(((int)array[0] << 8) | (int)array[1]);
			}

			// Token: 0x0600DE94 RID: 56980 RVA: 0x004C1D40 File Offset: 0x004BFF40
			public int ReadInt24()
			{
				byte[] array = this.ReadSmallValue(3);
				return ((int)array[0] << 16) | ((int)array[1] << 8) | (int)array[2];
			}

			// Token: 0x0600DE95 RID: 56981 RVA: 0x004C1D6C File Offset: 0x004BFF6C
			public int ReadInt32()
			{
				byte[] array = this.ReadSmallValue(4);
				return ((int)array[0] << 24) | ((int)array[1] << 16) | ((int)array[2] << 8) | (int)array[3];
			}

			// Token: 0x0600DE96 RID: 56982 RVA: 0x004C1DA0 File Offset: 0x004BFFA0
			public byte[] ReadBytes(int count)
			{
				byte[] array = new byte[count];
				bool flag = this.Read(array, 0, count) != count;
				if (flag)
				{
					throw new Exception("buffer underrun");
				}
				return array;
			}

			// Token: 0x0600DE97 RID: 56983 RVA: 0x004C1DD8 File Offset: 0x004BFFD8
			public void Write(byte value)
			{
				bool flag = this.temp == null;
				if (flag)
				{
					this.temp = new byte[4];
				}
				this.temp[0] = value;
				this.Write(this.temp, 0, 1);
			}

			// Token: 0x0600DE98 RID: 56984 RVA: 0x004C1E18 File Offset: 0x004C0018
			public void Write(short value)
			{
				bool flag = this.temp == null;
				if (flag)
				{
					this.temp = new byte[4];
				}
				this.temp[0] = (byte)(value >> 8);
				this.temp[1] = (byte)value;
				this.Write(this.temp, 0, 2);
			}

			// Token: 0x0600DE99 RID: 56985 RVA: 0x004C1E64 File Offset: 0x004C0064
			public void WriteInt24(int value)
			{
				bool flag = this.temp == null;
				if (flag)
				{
					this.temp = new byte[4];
				}
				this.temp[0] = (byte)(value >> 16);
				this.temp[1] = (byte)(value >> 8);
				this.temp[2] = (byte)value;
				this.Write(this.temp, 0, 3);
			}

			// Token: 0x0600DE9A RID: 56986 RVA: 0x004C1EC0 File Offset: 0x004C00C0
			public void Write(int value)
			{
				bool flag = this.temp == null;
				if (flag)
				{
					this.temp = new byte[4];
				}
				this.temp[0] = (byte)(value >> 24);
				this.temp[1] = (byte)(value >> 16);
				this.temp[2] = (byte)(value >> 8);
				this.temp[3] = (byte)value;
				this.Write(this.temp, 0, 4);
			}

			// Token: 0x0600DE9B RID: 56987 RVA: 0x004C1F26 File Offset: 0x004C0126
			public void Write(ulong value)
			{
				this.Write((int)(value >> 32));
				this.Write((int)value);
			}

			// Token: 0x0600DE9C RID: 56988 RVA: 0x004C1F3E File Offset: 0x004C013E
			public void Write(byte[] buffer)
			{
				this.Write(buffer, 0, buffer.Length);
			}

			// Token: 0x0600DE9D RID: 56989 RVA: 0x004C1F4D File Offset: 0x004C014D
			public void Reset()
			{
				this.buffer.SetLength(0L);
				this.buffer.Position = 0L;
			}

			// Token: 0x0600DE9E RID: 56990 RVA: 0x004C1F6C File Offset: 0x004C016C
			public byte[] ToArray()
			{
				return this.buffer.ToArray();
			}

			// Token: 0x0600DE9F RID: 56991 RVA: 0x004C1F89 File Offset: 0x004C0189
			public override void Flush()
			{
				this.buffer.Flush();
			}

			// Token: 0x0600DEA0 RID: 56992 RVA: 0x004C1F98 File Offset: 0x004C0198
			public override void SetLength(long length)
			{
				this.buffer.SetLength(length);
			}

			// Token: 0x0600DEA1 RID: 56993 RVA: 0x004C1FA8 File Offset: 0x004C01A8
			public override long Seek(long offset, SeekOrigin loc)
			{
				return this.buffer.Seek(offset, loc);
			}

			// Token: 0x0600DEA2 RID: 56994 RVA: 0x004C1FC8 File Offset: 0x004C01C8
			public override int Read(byte[] buffer, int offset, int count)
			{
				bool flag = this.canRead;
				if (flag)
				{
					return this.buffer.Read(buffer, offset, count);
				}
				throw new InvalidOperationException("Read operations are not allowed by this stream");
			}

			// Token: 0x0600DEA3 RID: 56995 RVA: 0x004C2000 File Offset: 0x004C0200
			public override void Write(byte[] buffer, int offset, int count)
			{
				bool flag = this.canWrite;
				if (flag)
				{
					this.buffer.Write(buffer, offset, count);
					return;
				}
				throw new InvalidOperationException("Write operations are not allowed by this stream");
			}

			// Token: 0x04009C9D RID: 40093
			private bool canRead;

			// Token: 0x04009C9E RID: 40094
			private bool canWrite;

			// Token: 0x04009C9F RID: 40095
			private MemoryStream buffer;

			// Token: 0x04009CA0 RID: 40096
			private byte[] temp;

			// Token: 0x04009CA1 RID: 40097
			private const int temp_size = 4;
		}
	}
}
