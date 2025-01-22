using System;
using System.Text;

namespace Utilities
{
	// Token: 0x020007B0 RID: 1968
	public class BitReaderD4
	{
		// Token: 0x0600B442 RID: 46146 RVA: 0x002BDE69 File Offset: 0x002BC069
		public BitReaderD4(byte[] data, int position, int length)
		{
			this.Data = data;
			this.Position = position;
			this.Length = length;
		}

		// Token: 0x0600B443 RID: 46147 RVA: 0x002BDE94 File Offset: 0x002BC094
		public BitReaderD4(byte[] data)
		{
			this.Data = data;
			this.Position = 0;
			this.Length = data.Length * 8;
		}

		// Token: 0x0600B444 RID: 46148 RVA: 0x002BDEC3 File Offset: 0x002BC0C3
		public BitReaderD4(int byteCapacity)
		{
			this.Data = new byte[byteCapacity];
			this.Position = 0;
			this.Length = 0;
		}

		// Token: 0x0600B445 RID: 46149 RVA: 0x002BDEF4 File Offset: 0x002BC0F4
		public byte[] GetAllBufferBytes()
		{
			int num = ((this.Length + 7) & -8) >> 3;
			byte[] array = new byte[num];
			Array.Copy(this.Data, 0, array, 0, num);
			this.Position = 0;
			return array;
		}

		// Token: 0x0600B446 RID: 46150 RVA: 0x002BDF34 File Offset: 0x002BC134
		public byte[] GetPacketAndReset()
		{
			int num = ((this.Length + 7) & -8) >> 3;
			this.Position = 0;
			byte[] array = new byte[num];
			Array.Copy(this.Data, array, num);
			return array;
		}

		// Token: 0x0600B447 RID: 46151 RVA: 0x002BDF74 File Offset: 0x002BC174
		public bool CheckAvailable(int length)
		{
			return this.Position + length <= this.Length;
		}

		// Token: 0x0600B448 RID: 46152 RVA: 0x002BDF9C File Offset: 0x002BC19C
		public void AppendData(byte[] data)
		{
			int num = this.Length >> 3;
			bool flag = num + data.Length > this.Data.Length;
			if (flag)
			{
				int num2 = (num + data.Length + 31) & -32;
				Array.Resize<byte>(ref this.Data, num2);
			}
			Array.Copy(data, 0, this.Data, num, data.Length);
			this.Length += data.Length * 8;
		}

		// Token: 0x0600B449 RID: 46153 RVA: 0x002BE008 File Offset: 0x002BC208
		public void ConsumeData()
		{
			int num = ((this.Position + 7) & -8) >> 3;
			Array.Copy(this.Data, num, this.Data, 0, (this.Length >> 3) - num);
			this.Length -= num * 8;
			this.Position = 0;
		}

		// Token: 0x0600B44A RID: 46154 RVA: 0x002BE05C File Offset: 0x002BC25C
		public void MakeAvailable(int length)
		{
			bool flag = this.Position + length > this.Data.Length * 8;
			if (flag)
			{
				int num = ((this.Position + length + 7) / 8 + 31) & -32;
				Array.Resize<byte>(ref this.Data, num);
			}
		}

		// Token: 0x0600B44B RID: 46155 RVA: 0x002BE0A4 File Offset: 0x002BC2A4
		public static int GetBitCount(int x)
		{
			int num = 0;
			while (x > 0)
			{
				x >>= 1;
				num++;
			}
			return num;
		}

		// Token: 0x0600B44C RID: 46156 RVA: 0x002BE0D0 File Offset: 0x002BC2D0
		public static int GetIntegerValueBitCount(int min, int max)
		{
			int num = max - min;
			bool flag = num <= 0;
			int num2;
			if (flag)
			{
				num2 = 0;
			}
			else
			{
				num2 = BitReaderD4.GetBitCount(num);
			}
			return num2;
		}

		// Token: 0x0600B44D RID: 46157 RVA: 0x002BE0FC File Offset: 0x002BC2FC
		public bool IsPacketAvailable()
		{
			bool flag = this.Position < 0;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				bool flag3 = this.Length - this.Position < 16;
				flag2 = !flag3;
			}
			return flag2;
		}

		// Token: 0x0600B44E RID: 46158 RVA: 0x002BE13C File Offset: 0x002BC33C
		public byte ReadByte()
		{
			byte[] array = new byte[1];
			Buffer.BlockCopy(this.Data, this.Position >> 3, array, 0, 1);
			this.Position += 8;
			return array[0];
		}

		// Token: 0x0600B44F RID: 46159 RVA: 0x002BE180 File Offset: 0x002BC380
		public void WriteByte(byte B)
		{
			byte[] array = new byte[] { B };
			Buffer.BlockCopy(array, 0, this.Data, this.Position >> 3, 1);
			this.Position += 8;
			bool flag = this.Position > this.Length;
			if (flag)
			{
				this.Length = this.Position;
			}
		}

		// Token: 0x0600B450 RID: 46160 RVA: 0x002BE1DC File Offset: 0x002BC3DC
		public int ReadInt(int length)
		{
			bool flag = !this.CheckAvailable(length);
			if (flag)
			{
				throw new BitBufferException("Not enough bits remaining.");
			}
			int num = 0;
			while (length > 0)
			{
				int num2 = this.Position & 7;
				int num3 = 8 - num2;
				bool flag2 = num3 > length;
				if (flag2)
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

		// Token: 0x0600B451 RID: 46161 RVA: 0x002BE278 File Offset: 0x002BC478
		public uint ReadUInt(int length)
		{
			return (uint)this.ReadInt(length);
		}

		// Token: 0x0600B452 RID: 46162 RVA: 0x002BE294 File Offset: 0x002BC494
		public uint ReadUInt32()
		{
			return (uint)this.ReadInt(32);
		}

		// Token: 0x0600B453 RID: 46163 RVA: 0x002BE2B0 File Offset: 0x002BC4B0
		public ushort ReadUInt16()
		{
			return (ushort)this.ReadInt(16);
		}

		// Token: 0x0600B454 RID: 46164 RVA: 0x002BE2CC File Offset: 0x002BC4CC
		public void WriteInt(int length, int value)
		{
			this.MakeAvailable(length);
			while (length > 0)
			{
				int num = this.Position & 7;
				int num2 = 8 - num;
				bool flag = num2 > length;
				if (flag)
				{
					num2 = length;
				}
				int num3 = (1 << num2) - 1;
				this.Data[this.Position >> 3] = (byte)(((int)this.Data[this.Position >> 3] & ~(num3 << num)) | (((value >> length - num2) & num3) << num));
				length -= num2;
				this.Position += num2;
				bool flag2 = this.Position > this.Length;
				if (flag2)
				{
					this.Length = this.Position;
				}
			}
		}

		// Token: 0x0600B455 RID: 46165 RVA: 0x002BE380 File Offset: 0x002BC580
		public void WriteBInt(int value)
		{
			this.MakeAvailable(32);
			byte[] bytes = BitConverter.GetBytes(value);
			this.Write(bytes);
		}

		// Token: 0x0600B456 RID: 46166 RVA: 0x002BE3A6 File Offset: 0x002BC5A6
		public void WriteUInt(int length, uint value)
		{
			this.WriteInt(length, (int)value);
		}

		// Token: 0x0600B457 RID: 46167 RVA: 0x002BE3B4 File Offset: 0x002BC5B4
		public float ReadFloat32()
		{
			int num = this.ReadInt(32);
			this._floatBuffer[0] = (byte)num;
			this._floatBuffer[1] = (byte)((num >> 8) & 255);
			this._floatBuffer[2] = (byte)((num >> 16) & 255);
			this._floatBuffer[3] = (byte)((num >> 24) & 255);
			return BitConverter.ToSingle(this._floatBuffer, 0);
		}

		// Token: 0x0600B458 RID: 46168 RVA: 0x002BE41D File Offset: 0x002BC61D
		public void WriteFloat32(float value)
		{
			this.WriteInt(32, BitConverter.ToInt32(BitConverter.GetBytes(value), 0));
		}

		// Token: 0x0600B459 RID: 46169 RVA: 0x002BE438 File Offset: 0x002BC638
		public long ReadInt64(int length = 64)
		{
			int num = ((length >= 32) ? 32 : length);
			long num2 = (long)this.ReadInt(num);
			num = length - num;
			bool flag = num > 0;
			if (flag)
			{
				num2 = (num2 << num) | (long)((ulong)this.ReadInt(num));
			}
			return num2;
		}

		// Token: 0x0600B45A RID: 46170 RVA: 0x002BE47C File Offset: 0x002BC67C
		public ulong ReadUInt64(int length = 64)
		{
			return (ulong)this.ReadInt64(length);
		}

		// Token: 0x0600B45B RID: 46171 RVA: 0x002BE498 File Offset: 0x002BC698
		public void WriteInt64(int length, long value)
		{
			this.MakeAvailable(length);
			bool flag = length <= 32;
			if (flag)
			{
				this.WriteInt(length, (int)((uint)value));
			}
			else
			{
				int num = length - 32;
				this.WriteInt(32, (int)((uint)(value >> num)));
				this.WriteInt(num, (int)((uint)value));
			}
		}

		// Token: 0x0600B45C RID: 46172 RVA: 0x002BE4E6 File Offset: 0x002BC6E6
		public void WriteUInt64(int length, ulong value)
		{
			this.WriteInt64(length, (long)value);
		}

		// Token: 0x0600B45D RID: 46173 RVA: 0x002BE4F4 File Offset: 0x002BC6F4
		public string ReadCharArray(int maxLength)
		{
			int num = this.ReadInt(BitReaderD4.GetBitCount(maxLength));
			this.Position = (this.Position + 7) & -8;
			bool flag = !this.CheckAvailable(num * 8);
			if (flag)
			{
				throw new BitBufferException("Not enough bits remaining.");
			}
			string @string = Encoding.UTF8.GetString(this.Data, this.Position >> 3, num);
			this.Position += num * 8;
			return @string;
		}

		// Token: 0x0600B45E RID: 46174 RVA: 0x002BE56C File Offset: 0x002BC76C
		public void WriteCharArray(int maxLength, string value)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(value);
			this.WriteInt(BitReaderD4.GetBitCount(maxLength), bytes.Length);
			this.Position = (this.Position + 7) & -8;
			this.MakeAvailable(bytes.Length * 8);
			Buffer.BlockCopy(bytes, 0, this.Data, this.Position >> 3, bytes.Length);
			this.Position += bytes.Length * 8;
			bool flag = this.Position > this.Length;
			if (flag)
			{
				this.Length = this.Position;
			}
		}

		// Token: 0x0600B45F RID: 46175 RVA: 0x002BE5FC File Offset: 0x002BC7FC
		public void WriteCharArrayV2(string value)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(value);
			this.WriteInt(8, bytes.Length);
			this.Position = (this.Position + 7) & -8;
			this.MakeAvailable(bytes.Length * 8);
			Buffer.BlockCopy(bytes, 0, this.Data, this.Position >> 3, bytes.Length);
			this.Position += bytes.Length * 8;
			bool flag = this.Position > this.Length;
			if (flag)
			{
				this.Length = this.Position;
			}
		}

		// Token: 0x0600B460 RID: 46176 RVA: 0x002BE688 File Offset: 0x002BC888
		public bool ReadBool()
		{
			return this.ReadInt(1) != 0;
		}

		// Token: 0x0600B461 RID: 46177 RVA: 0x002BE6A4 File Offset: 0x002BC8A4
		public void WriteBool(bool value)
		{
			this.WriteInt(1, value ? 1 : 0);
		}

		// Token: 0x0600B462 RID: 46178 RVA: 0x002BE6B8 File Offset: 0x002BC8B8
		public byte[] ReadBlobWS(int size)
		{
			byte[] array = new byte[size];
			this.Position = (this.Position + 7) & -8;
			bool flag = !this.CheckAvailable(size * 8);
			if (flag)
			{
				throw new BitBufferException("Not enough bits remaining.");
			}
			Buffer.BlockCopy(this.Data, this.Position >> 3, array, 0, size);
			this.Position += size * 8;
			return array;
		}

		// Token: 0x0600B463 RID: 46179 RVA: 0x002BE728 File Offset: 0x002BC928
		public byte[] ReadBlob(int sizeBits)
		{
			int num = this.ReadInt(sizeBits);
			byte[] array = new byte[num];
			this.Position = (this.Position + 7) & -8;
			bool flag = !this.CheckAvailable(num * 8);
			byte[] array2;
			if (flag)
			{
				array2 = array;
			}
			else
			{
				Buffer.BlockCopy(this.Data, this.Position >> 3, array, 0, num);
				this.Position += num * 8;
				array2 = array;
			}
			return array2;
		}

		// Token: 0x0600B464 RID: 46180 RVA: 0x002BE798 File Offset: 0x002BC998
		public byte[] ReadBytes(int size)
		{
			byte[] array = new byte[size];
			this.Position = (this.Position + 7) & -8;
			bool flag = !this.CheckAvailable(size * 8);
			byte[] array2;
			if (flag)
			{
				array2 = array;
			}
			else
			{
				Buffer.BlockCopy(this.Data, this.Position >> 3, array, 0, size);
				this.Position += size * 8;
				array2 = array;
			}
			return array2;
		}

		// Token: 0x0600B465 RID: 46181 RVA: 0x002BE800 File Offset: 0x002BCA00
		public byte[] ReadBlobBytes(int sizeBits)
		{
			int num = this.ReadInt(sizeBits);
			byte[] array = new byte[num];
			this.Position = (this.Position + 7) & -8;
			bool flag = !this.CheckAvailable(num * 8);
			if (flag)
			{
				throw new BitBufferException("Not enough bits remaining.");
			}
			Buffer.BlockCopy(this.Data, this.Position >> 3, array, 0, num);
			this.Position += num * 8;
			return array;
		}

		// Token: 0x0600B466 RID: 46182 RVA: 0x002BE878 File Offset: 0x002BCA78
		public void WriteBlob(int sizeBits, byte[] data)
		{
			this.WriteInt(sizeBits, data.Length);
			this.Position = (this.Position + 7) & -8;
			this.MakeAvailable(data.Length * 8);
			Buffer.BlockCopy(data, 0, this.Data, this.Position >> 3, data.Length);
			this.Position += data.Length * 8;
			bool flag = this.Position > this.Length;
			if (flag)
			{
				this.Length = this.Position;
			}
		}

		// Token: 0x0600B467 RID: 46183 RVA: 0x002BE8F8 File Offset: 0x002BCAF8
		public void Write(byte[] data)
		{
			foreach (byte b in data)
			{
				this.Write(b);
			}
		}

		// Token: 0x0600B468 RID: 46184 RVA: 0x002BE924 File Offset: 0x002BCB24
		public float ReadFloat16()
		{
			int num = this.ReadInt(16);
			int num2 = (num & 1023) << 13;
			num2 |= ((num >> 10) & 31) + 112 << 23;
			num2 |= (num & 32768) << 16;
			this._floatBuffer[0] = (byte)num2;
			this._floatBuffer[1] = (byte)((num2 >> 8) & 255);
			this._floatBuffer[2] = (byte)((num2 >> 16) & 255);
			this._floatBuffer[3] = (byte)((num2 >> 24) & 255);
			return BitConverter.ToSingle(this._floatBuffer, 0);
		}

		// Token: 0x0600B469 RID: 46185 RVA: 0x002BE9B8 File Offset: 0x002BCBB8
		public void WriteFloat16(float value)
		{
			int num = BitConverter.ToInt32(BitConverter.GetBytes(value), 0);
			int num2 = (num >> 13) & 1023;
			int num3 = ((num >> 23) & 255) - 112;
			bool flag = num3 > 0;
			if (flag)
			{
				num2 |= num3 << 10;
			}
			num2 |= (num >> 16) & 32768;
			this.WriteInt(16, num2);
			bool flag2 = this.Position > this.Length;
			if (flag2)
			{
				this.Length = this.Position;
			}
		}

		// Token: 0x0600B46A RID: 46186 RVA: 0x002BEA32 File Offset: 0x002BCC32
		public void Write(byte val)
		{
			this.WriteUInt(8, (uint)val);
		}

		// Token: 0x0600B46B RID: 46187 RVA: 0x002BEA3E File Offset: 0x002BCC3E
		public void Write(ushort val)
		{
			this.WriteUInt(16, (uint)val);
		}

		// Token: 0x0600B46C RID: 46188 RVA: 0x002BEA4B File Offset: 0x002BCC4B
		public void Write(uint val)
		{
			this.WriteUInt(32, val);
		}

		// Token: 0x0600B46D RID: 46189 RVA: 0x002BEA58 File Offset: 0x002BCC58
		public void Write(ulong val)
		{
			this.WriteUInt64(64, val);
		}

		// Token: 0x0600B46E RID: 46190 RVA: 0x002BEA65 File Offset: 0x002BCC65
		public void Write(short val)
		{
			this.WriteInt(16, (int)val);
		}

		// Token: 0x0600B46F RID: 46191 RVA: 0x002BEA72 File Offset: 0x002BCC72
		public void Write(int val)
		{
			this.WriteInt(32, val);
		}

		// Token: 0x0600B470 RID: 46192 RVA: 0x002BEA7F File Offset: 0x002BCC7F
		public void Write(long val)
		{
			this.WriteInt64(64, val);
		}

		// Token: 0x04005966 RID: 22886
		public byte[] Data;

		// Token: 0x04005967 RID: 22887
		public int Length;

		// Token: 0x04005968 RID: 22888
		public int Position;

		// Token: 0x04005969 RID: 22889
		private const int BufferAlignment = 31;

		// Token: 0x0400596A RID: 22890
		private byte[] _floatBuffer = new byte[4];
	}
}
