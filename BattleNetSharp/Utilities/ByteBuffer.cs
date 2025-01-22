using System;
using System.IO;
using System.Numerics;
using System.Text;

namespace Utilities
{
	// Token: 0x020007B2 RID: 1970
	public class ByteBuffer : IDisposable
	{
		// Token: 0x0600B47F RID: 46207 RVA: 0x002BEECC File Offset: 0x002BD0CC
		public ByteBuffer()
		{
			this.writeStream = new BinaryWriter(new MemoryStream());
		}

		// Token: 0x0600B480 RID: 46208 RVA: 0x002BEEED File Offset: 0x002BD0ED
		public ByteBuffer(byte[] data)
		{
			this.readStream = new BinaryReader(new MemoryStream(data));
		}

		// Token: 0x0600B481 RID: 46209 RVA: 0x002BEF10 File Offset: 0x002BD110
		public void Dispose()
		{
			bool flag = this.writeStream != null;
			if (flag)
			{
				this.writeStream.Dispose();
			}
			bool flag2 = this.readStream != null;
			if (flag2)
			{
				this.readStream.Dispose();
			}
		}

		// Token: 0x0600B482 RID: 46210 RVA: 0x002BEF50 File Offset: 0x002BD150
		public sbyte ReadInt8()
		{
			this.ResetBitPos();
			return this.readStream.ReadSByte();
		}

		// Token: 0x0600B483 RID: 46211 RVA: 0x002BEF74 File Offset: 0x002BD174
		public short ReadInt16()
		{
			this.ResetBitPos();
			return this.readStream.ReadInt16();
		}

		// Token: 0x0600B484 RID: 46212 RVA: 0x002BEF98 File Offset: 0x002BD198
		public int ReadInt32()
		{
			this.ResetBitPos();
			return this.readStream.ReadInt32();
		}

		// Token: 0x0600B485 RID: 46213 RVA: 0x002BEFBC File Offset: 0x002BD1BC
		public long ReadInt64()
		{
			this.ResetBitPos();
			return this.readStream.ReadInt64();
		}

		// Token: 0x0600B486 RID: 46214 RVA: 0x002BEFE0 File Offset: 0x002BD1E0
		public byte ReadUInt8()
		{
			this.ResetBitPos();
			return this.readStream.ReadByte();
		}

		// Token: 0x0600B487 RID: 46215 RVA: 0x002BF004 File Offset: 0x002BD204
		public ushort ReadUInt16()
		{
			this.ResetBitPos();
			return this.readStream.ReadUInt16();
		}

		// Token: 0x0600B488 RID: 46216 RVA: 0x002BF028 File Offset: 0x002BD228
		public uint ReadUInt32()
		{
			this.ResetBitPos();
			return this.readStream.ReadUInt32();
		}

		// Token: 0x0600B489 RID: 46217 RVA: 0x002BF04C File Offset: 0x002BD24C
		public ulong ReadUInt64()
		{
			this.ResetBitPos();
			return this.readStream.ReadUInt64();
		}

		// Token: 0x0600B48A RID: 46218 RVA: 0x002BF070 File Offset: 0x002BD270
		public float ReadFloat()
		{
			this.ResetBitPos();
			return this.readStream.ReadSingle();
		}

		// Token: 0x0600B48B RID: 46219 RVA: 0x002BF094 File Offset: 0x002BD294
		public double ReadDouble()
		{
			this.ResetBitPos();
			return this.readStream.ReadDouble();
		}

		// Token: 0x0600B48C RID: 46220 RVA: 0x002BF0B8 File Offset: 0x002BD2B8
		public string ReadCString()
		{
			this.ResetBitPos();
			StringBuilder stringBuilder = new StringBuilder();
			char c = this.readStream.ReadChar();
			char c2 = Convert.ToChar(Encoding.UTF8.GetString(new byte[1]));
			while (c != c2)
			{
				stringBuilder.Append(c);
				c = this.readStream.ReadChar();
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600B48D RID: 46221 RVA: 0x002BF124 File Offset: 0x002BD324
		public string ReadString(uint length)
		{
			bool flag = length == 0U;
			string text;
			if (flag)
			{
				text = "";
			}
			else
			{
				this.ResetBitPos();
				text = Encoding.UTF8.GetString(this.ReadBytes(length));
			}
			return text;
		}

		// Token: 0x0600B48E RID: 46222 RVA: 0x002BF160 File Offset: 0x002BD360
		public bool ReadBool()
		{
			this.ResetBitPos();
			return this.readStream.ReadBoolean();
		}

		// Token: 0x0600B48F RID: 46223 RVA: 0x002BF184 File Offset: 0x002BD384
		public byte[] ReadBytes(uint count)
		{
			this.ResetBitPos();
			return this.readStream.ReadBytes((int)count);
		}

		// Token: 0x0600B490 RID: 46224 RVA: 0x002BF1A9 File Offset: 0x002BD3A9
		public void Skip(int count)
		{
			this.ResetBitPos();
			this.readStream.BaseStream.Position += (long)count;
		}

		// Token: 0x0600B491 RID: 46225 RVA: 0x002BF1D0 File Offset: 0x002BD3D0
		public uint ReadPackedTime()
		{
			return (uint)Time.GetUnixTimeFromPackedTime(this.ReadUInt32());
		}

		// Token: 0x0600B492 RID: 46226 RVA: 0x002BF1F0 File Offset: 0x002BD3F0
		public Vector3 ReadVector3()
		{
			return new Vector3(this.ReadFloat(), this.ReadFloat(), this.ReadFloat());
		}

		// Token: 0x0600B493 RID: 46227 RVA: 0x002BF21C File Offset: 0x002BD41C
		public bool ReadBit()
		{
			bool flag = this._bitPosition == 8;
			if (flag)
			{
				this.BitValue = this.ReadUInt8();
				this._bitPosition = 0;
			}
			int bitValue = (int)this.BitValue;
			this.BitValue = (byte)(bitValue << 1);
			this._bitPosition += 1;
			return bitValue >> 7 == 1;
		}

		// Token: 0x0600B494 RID: 46228 RVA: 0x002BF278 File Offset: 0x002BD478
		public bool HasBit()
		{
			bool flag = this._bitPosition == 8;
			if (flag)
			{
				this.BitValue = this.ReadUInt8();
				this._bitPosition = 0;
			}
			int bitValue = (int)this.BitValue;
			this.BitValue = (byte)(2 * bitValue);
			this._bitPosition += 1;
			return Convert.ToBoolean(bitValue >> 7);
		}

		// Token: 0x0600B495 RID: 46229 RVA: 0x002BF2D4 File Offset: 0x002BD4D4
		public T ReadBits<T>(int bitCount)
		{
			int num = 0;
			for (int i = bitCount - 1; i >= 0; i--)
			{
				bool flag = this.HasBit();
				if (flag)
				{
					num |= 1 << i;
				}
			}
			return (T)((object)Convert.ChangeType(num, typeof(T)));
		}

		// Token: 0x0600B496 RID: 46230 RVA: 0x002BF32C File Offset: 0x002BD52C
		public int ReadBits(int bitCount)
		{
			int num = 0;
			for (int i = bitCount - 1; i >= 0; i--)
			{
				bool flag = this.HasBit();
				if (flag)
				{
					num |= 1 << i;
				}
			}
			return num;
		}

		// Token: 0x0600B497 RID: 46231 RVA: 0x002BF36B File Offset: 0x002BD56B
		public void WriteInt8(sbyte data)
		{
			this.FlushBits();
			this.writeStream.Write(data);
		}

		// Token: 0x0600B498 RID: 46232 RVA: 0x002BF382 File Offset: 0x002BD582
		public void WriteInt16(short data)
		{
			this.FlushBits();
			this.writeStream.Write(data);
		}

		// Token: 0x0600B499 RID: 46233 RVA: 0x002BF399 File Offset: 0x002BD599
		public void WriteInt32(int data)
		{
			this.FlushBits();
			this.writeStream.Write(data);
		}

		// Token: 0x0600B49A RID: 46234 RVA: 0x002BF3B0 File Offset: 0x002BD5B0
		public void WriteInt64(long data)
		{
			this.FlushBits();
			this.writeStream.Write(data);
		}

		// Token: 0x0600B49B RID: 46235 RVA: 0x002BF3C7 File Offset: 0x002BD5C7
		public void WriteUInt8(byte data)
		{
			this.FlushBits();
			this.writeStream.Write(data);
		}

		// Token: 0x0600B49C RID: 46236 RVA: 0x002BF3DE File Offset: 0x002BD5DE
		public void WriteUInt16(ushort data)
		{
			this.FlushBits();
			this.writeStream.Write(data);
		}

		// Token: 0x0600B49D RID: 46237 RVA: 0x002BF3F5 File Offset: 0x002BD5F5
		public void WriteUInt32(uint data)
		{
			this.FlushBits();
			this.writeStream.Write(data);
		}

		// Token: 0x0600B49E RID: 46238 RVA: 0x002BF40C File Offset: 0x002BD60C
		public void WriteUInt64(ulong data)
		{
			this.FlushBits();
			this.writeStream.Write(data);
		}

		// Token: 0x0600B49F RID: 46239 RVA: 0x002BF423 File Offset: 0x002BD623
		public void WriteFloat(float data)
		{
			this.FlushBits();
			this.writeStream.Write(data);
		}

		// Token: 0x0600B4A0 RID: 46240 RVA: 0x002BF43A File Offset: 0x002BD63A
		public void WriteDouble(double data)
		{
			this.FlushBits();
			this.writeStream.Write(data);
		}

		// Token: 0x0600B4A1 RID: 46241 RVA: 0x002BF454 File Offset: 0x002BD654
		public void WriteCString(string str)
		{
			bool flag = string.IsNullOrEmpty(str);
			if (flag)
			{
				this.WriteUInt8(0);
			}
			else
			{
				this.WriteString(str);
				this.WriteUInt8(0);
			}
		}

		// Token: 0x0600B4A2 RID: 46242 RVA: 0x002BF488 File Offset: 0x002BD688
		public void WriteString(string str)
		{
			bool flag = string.IsNullOrEmpty(str);
			if (!flag)
			{
				byte[] bytes = Encoding.UTF8.GetBytes(str);
				this.WriteBytes(bytes);
			}
		}

		// Token: 0x0600B4A3 RID: 46243 RVA: 0x002BF4B6 File Offset: 0x002BD6B6
		public void WriteBytes(byte[] data)
		{
			this.FlushBits();
			this.writeStream.Write(data, 0, data.Length);
		}

		// Token: 0x0600B4A4 RID: 46244 RVA: 0x002BF4D1 File Offset: 0x002BD6D1
		public void WriteBytes(byte[] data, uint count)
		{
			this.FlushBits();
			this.writeStream.Write(data, 0, (int)count);
		}

		// Token: 0x0600B4A5 RID: 46245 RVA: 0x002BF4EA File Offset: 0x002BD6EA
		public void WriteBytes(ByteBuffer buffer)
		{
			this.WriteBytes(buffer.GetData());
		}

		// Token: 0x0600B4A6 RID: 46246 RVA: 0x002BF4FA File Offset: 0x002BD6FA
		public void WriteVector4(Vector4 pos)
		{
			this.WriteFloat(pos.X);
			this.WriteFloat(pos.Y);
			this.WriteFloat(pos.Z);
			this.WriteFloat(pos.W);
		}

		// Token: 0x0600B4A7 RID: 46247 RVA: 0x002BF531 File Offset: 0x002BD731
		public void WriteVector3(Vector3 pos)
		{
			this.WriteFloat(pos.X);
			this.WriteFloat(pos.Y);
			this.WriteFloat(pos.Z);
		}

		// Token: 0x0600B4A8 RID: 46248 RVA: 0x002BF55B File Offset: 0x002BD75B
		public void WriteVector2(Vector2 pos)
		{
			this.WriteFloat(pos.X);
			this.WriteFloat(pos.Y);
		}

		// Token: 0x0600B4A9 RID: 46249 RVA: 0x002BF578 File Offset: 0x002BD778
		public void WritePackXYZ(Vector3 pos)
		{
			uint num = 0U;
			num |= (uint)(pos.X / 0.25f) & 2047U;
			num |= ((uint)(pos.Y / 0.25f) & 2047U) << 11;
			num |= ((uint)(pos.Z / 0.25f) & 1023U) << 22;
			this.WriteUInt32(num);
		}

		// Token: 0x0600B4AA RID: 46250 RVA: 0x002BF5D8 File Offset: 0x002BD7D8
		public bool WriteBit(bool bit)
		{
			this._bitPosition -= 1;
			if (bit)
			{
				this.BitValue |= (byte)(1 << (int)this._bitPosition);
			}
			bool flag = this._bitPosition == 0;
			if (flag)
			{
				this.writeStream.Write(this.BitValue);
				this._bitPosition = 8;
				this.BitValue = 0;
			}
			return bit;
		}

		// Token: 0x0600B4AB RID: 46251 RVA: 0x002BF648 File Offset: 0x002BD848
		public void WriteBits(object bit, int count)
		{
			for (int i = count - 1; i >= 0; i--)
			{
				this.WriteBit(((Convert.ToUInt32(bit) >> i) & 1U) > 0U);
			}
		}

		// Token: 0x0600B4AC RID: 46252 RVA: 0x002BF682 File Offset: 0x002BD882
		public void WritePackedTime(long time)
		{
			this.WriteUInt32(Time.GetPackedTimeFromUnixTime(time));
		}

		// Token: 0x0600B4AD RID: 46253 RVA: 0x002BF692 File Offset: 0x002BD892
		public void WritePackedTime()
		{
			this.WriteUInt32(Time.GetPackedTimeFromDateTime(DateTime.Now));
		}

		// Token: 0x0600B4AE RID: 46254 RVA: 0x002BF6A8 File Offset: 0x002BD8A8
		public bool HasUnfinishedBitPack()
		{
			return this._bitPosition != 8;
		}

		// Token: 0x0600B4AF RID: 46255 RVA: 0x002BF6C8 File Offset: 0x002BD8C8
		public void FlushBits()
		{
			bool flag = this._bitPosition == 8;
			if (!flag)
			{
				this.writeStream.Write(this.BitValue);
				this.BitValue = 0;
				this._bitPosition = 8;
			}
		}

		// Token: 0x0600B4B0 RID: 46256 RVA: 0x002BF708 File Offset: 0x002BD908
		public void ResetBitPos()
		{
			bool flag = this._bitPosition > 7;
			if (!flag)
			{
				this._bitPosition = 8;
				this.BitValue = 0;
			}
		}

		// Token: 0x0600B4B1 RID: 46257 RVA: 0x002BF734 File Offset: 0x002BD934
		public byte[] GetData()
		{
			Stream currentStream = this.GetCurrentStream();
			byte[] array = new byte[currentStream.Length];
			long position = currentStream.Position;
			currentStream.Seek(0L, SeekOrigin.Begin);
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (byte)currentStream.ReadByte();
			}
			currentStream.Seek(position, SeekOrigin.Begin);
			return array;
		}

		// Token: 0x0600B4B2 RID: 46258 RVA: 0x002BF798 File Offset: 0x002BD998
		public uint GetSize()
		{
			return (uint)this.GetCurrentStream().Length;
		}

		// Token: 0x0600B4B3 RID: 46259 RVA: 0x002BF7B8 File Offset: 0x002BD9B8
		public Stream GetCurrentStream()
		{
			bool flag = this.writeStream != null;
			Stream stream;
			if (flag)
			{
				stream = this.writeStream.BaseStream;
			}
			else
			{
				stream = this.readStream.BaseStream;
			}
			return stream;
		}

		// Token: 0x0600B4B4 RID: 46260 RVA: 0x002BF7F0 File Offset: 0x002BD9F0
		public void Clear()
		{
			this._bitPosition = 8;
			this.BitValue = 0;
			this.writeStream = new BinaryWriter(new MemoryStream());
		}

		// Token: 0x0400596E RID: 22894
		private byte _bitPosition = 8;

		// Token: 0x0400596F RID: 22895
		private byte BitValue;

		// Token: 0x04005970 RID: 22896
		private BinaryWriter writeStream;

		// Token: 0x04005971 RID: 22897
		private BinaryReader readStream;
	}
}
