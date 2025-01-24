using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lz4
{
	// Token: 0x020007AD RID: 1965
	public class Lz4DecoderStream : Stream
	{
		// Token: 0x0600B417 RID: 46103 RVA: 0x002BCEE0 File Offset: 0x002BB0E0
		public static byte[] Decompress(byte[] data)
		{
			byte[] array2;
			using (MemoryStream memoryStream = new MemoryStream(data))
			{
				Lz4DecoderStream lz4DecoderStream = new Lz4DecoderStream(memoryStream, long.MaxValue);
				List<byte> list = new List<byte>();
				byte[] array = new byte[2048];
				for (;;)
				{
					int num = lz4DecoderStream.Read(array, 0, array.Length);
					bool flag = num == 0;
					if (flag)
					{
						break;
					}
					list.AddRange(array.Take(num));
				}
				array2 = list.ToArray();
			}
			return array2;
		}

		// Token: 0x0600B418 RID: 46104 RVA: 0x002BCF70 File Offset: 0x002BB170
		public Lz4DecoderStream()
		{
		}

		// Token: 0x0600B419 RID: 46105 RVA: 0x002BCF8A File Offset: 0x002BB18A
		public Lz4DecoderStream(Stream input, long inputLength = 9223372036854775807L)
		{
			this.Reset(input, inputLength);
		}

		// Token: 0x0600B41A RID: 46106 RVA: 0x002BCFB0 File Offset: 0x002BB1B0
		public void Reset(Stream input, long inputLength = 9223372036854775807L)
		{
			this.inputLength = inputLength;
			this.input = input;
			this.phase = Lz4DecoderStream.DecodePhase.ReadToken;
			this.decodeBufferPos = 0;
			this.litLen = 0;
			this.matLen = 0;
			this.matDst = 0;
			this.inBufPos = 65536;
			this.inBufEnd = 65536;
		}

		// Token: 0x0600B41B RID: 46107 RVA: 0x002BD005 File Offset: 0x002BB205
		public override void Close()
		{
			this.input = null;
		}

		// Token: 0x0600B41C RID: 46108 RVA: 0x002BD010 File Offset: 0x002BB210
		public override int Read(byte[] buffer, int offset, int count)
		{
			bool flag = buffer == null;
			if (flag)
			{
				throw new ArgumentNullException("buffer");
			}
			bool flag2 = offset < 0 || count < 0 || buffer.Length - count < offset;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException();
			}
			bool flag3 = this.input == null;
			if (flag3)
			{
				throw new InvalidOperationException();
			}
			int num = count;
			byte[] array = this.decodeBuffer;
			switch (this.phase)
			{
			case Lz4DecoderStream.DecodePhase.ReadToken:
				goto IL_009B;
			case Lz4DecoderStream.DecodePhase.ReadExLiteralLength:
				break;
			case Lz4DecoderStream.DecodePhase.CopyLiteral:
				break;//goto IL_01A4; !!!
			case Lz4DecoderStream.DecodePhase.ReadOffset:
				goto IL_0281;
			case Lz4DecoderStream.DecodePhase.ReadExMatchLength:
				break;//goto IL_030B; !!!
			case Lz4DecoderStream.DecodePhase.CopyMatch:
				goto IL_037F;
			default:
				goto IL_009B;
			}
			for (;;)
			{
				IL_0130:
				bool flag4 = this.inBufPos < this.inBufEnd;
				int num3;
				if (flag4)
				{
					byte[] array2 = array;
					int num2 = this.inBufPos;
					this.inBufPos = num2 + 1;
					num3 = array2[num2];
				}
				else
				{
					num3 = this.ReadByteCore();
					bool flag5 = num3 == -1;
					if (flag5)
					{
						break;
					}
				}
				this.litLen += num3;
				bool flag6 = num3 == 255;
				if (!flag6)
				{
					goto IL_019B;
				}
			}
			goto IL_0480;
			IL_019B:
			this.phase = Lz4DecoderStream.DecodePhase.CopyLiteral;
			int num8;
			for (;;)
			{
				IL_01A4:
				int num4 = ((this.litLen < num) ? this.litLen : num);
				bool flag7 = num4 != 0;
				if (!flag7)
				{
					goto IL_0269;
				}
				bool flag8 = this.inBufPos + num4 <= this.inBufEnd;
				if (flag8)
				{
					int num5 = offset;
					int num6 = num4;
					while (num6-- != 0)
					{
						int num7 = num5++;
						byte[] array3 = array;
						int num2 = this.inBufPos;
						this.inBufPos = num2 + 1;
						buffer[num7] = array3[num2];
					}
					num8 = num4;
				}
				else
				{
					num8 = this.ReadCore(buffer, offset, num4);
					bool flag9 = num8 == 0;
					if (flag9)
					{
						break;
					}
				}
				offset += num8;
				num -= num8;
				this.litLen -= num8;
				bool flag10 = this.litLen != 0;
				if (!flag10)
				{
					goto IL_0268;
				}
			}
			goto IL_0480;
			IL_0268:
			IL_0269:
			bool flag11 = num == 0;
			if (flag11)
			{
				goto IL_0480;
			}
			this.phase = Lz4DecoderStream.DecodePhase.ReadOffset;
			goto IL_0281;
			for (;;)
			{
				IL_030B:
				bool flag12 = this.inBufPos < this.inBufEnd;
				int num9;
				if (flag12)
				{
					byte[] array4 = array;
					int num2 = this.inBufPos;
					this.inBufPos = num2 + 1;
					num9 = array4[num2];
				}
				else
				{
					num9 = this.ReadByteCore();
					bool flag13 = num9 == -1;
					if (flag13)
					{
						break;
					}
				}
				this.matLen += num9;
				bool flag14 = num9 == 255;
				if (!flag14)
				{
					goto IL_0376;
				}
			}
			goto IL_0480;
			IL_0376:
			this.phase = Lz4DecoderStream.DecodePhase.CopyMatch;
			goto IL_037F;
			IL_009B:
			bool flag15 = this.inBufPos < this.inBufEnd;
			int num10;
			if (flag15)
			{
				byte[] array5 = array;
				int num2 = this.inBufPos;
				this.inBufPos = num2 + 1;
				num10 = array5[num2];
			}
			else
			{
				num10 = this.ReadByteCore();
				bool flag16 = num10 == -1;
				if (flag16)
				{
					goto IL_0480;
				}
			}
			this.litLen = num10 >> 4;
			this.matLen = (num10 & 15) + 4;
			int num11 = this.litLen;
			int num12 = num11;
			if (num12 != 0)
			{
				if (num12 != 15)
				{
					this.phase = Lz4DecoderStream.DecodePhase.CopyLiteral;
					//goto IL_01A4; !!!
				}
				this.phase = Lz4DecoderStream.DecodePhase.ReadExLiteralLength;
				// goto IL_0130; !!!
			}
			else
			{
				this.phase = Lz4DecoderStream.DecodePhase.ReadOffset;
			}
			IL_0281:
			bool flag17 = this.inBufPos + 1 < this.inBufEnd;
			if (flag17)
			{
				this.matDst = ((int)array[this.inBufPos + 1] << 8) | (int)array[this.inBufPos];
				this.inBufPos += 2;
			}
			else
			{
				this.matDst = this.ReadOffsetCore();
				bool flag18 = this.matDst == -1;
				if (flag18)
				{
					goto IL_0480;
				}
			}
			bool flag19 = this.matLen == 19;
			if (flag19)
			{
				this.phase = Lz4DecoderStream.DecodePhase.ReadExMatchLength;
				// goto IL_030B; !!!
			}
			this.phase = Lz4DecoderStream.DecodePhase.CopyMatch;
			IL_037F:
			int num13 = ((this.matLen < num) ? this.matLen : num);
			bool flag20 = num13 != 0;
			if (flag20)
			{
				num8 = count - num;
				int num14 = this.matDst - num8;
				bool flag21 = num14 > 0;
				if (flag21)
				{
					int num15 = this.decodeBufferPos - num14;
					bool flag22 = num15 < 0;
					if (flag22)
					{
						num15 += 65536;
					}
					int num16 = ((num14 < num13) ? num14 : num13);
					int num17 = num16;
					while (num17-- != 0)
					{
						buffer[offset++] = array[num15++ & 65535];
					}
				}
				else
				{
					num14 = 0;
				}
				int num18 = offset - this.matDst;
				for (int i = num14; i < num13; i++)
				{
					buffer[offset++] = buffer[num18++];
				}
				num -= num13;
				this.matLen -= num13;
			}
			bool flag23 = num == 0;
			if (!flag23)
			{
				this.phase = Lz4DecoderStream.DecodePhase.ReadToken;
				goto IL_009B;
			}
			IL_0480:
			num8 = count - num;
			int num19 = ((num8 < 65536) ? num8 : 65536);
			int num20 = offset - num19;
			bool flag24 = num19 == 65536;
			if (flag24)
			{
				Buffer.BlockCopy(buffer, num20, array, 0, 65536);
				this.decodeBufferPos = 0;
			}
			else
			{
				int num21 = this.decodeBufferPos;
				while (num19-- != 0)
				{
					array[num21++ & 65535] = buffer[num20++];
				}
				this.decodeBufferPos = num21 & 65535;
			}
			return num8;
		}

		// Token: 0x0600B41D RID: 46109 RVA: 0x002BD530 File Offset: 0x002BB730
		private int ReadByteCore()
		{
			byte[] array = this.decodeBuffer;
			bool flag = this.inBufPos == this.inBufEnd;
			if (flag)
			{
				int num = this.input.Read(array, 65536, (128L < this.inputLength) ? 128 : ((int)this.inputLength));
				bool flag2 = num == 0;
				if (flag2)
				{
					return -1;
				}
				this.inputLength -= (long)num;
				this.inBufPos = 65536;
				this.inBufEnd = 65536 + num;
			}
			byte[] array2 = array;
			int num2 = this.inBufPos;
			this.inBufPos = num2 + 1;
			return array2[num2];
		}

		// Token: 0x0600B41E RID: 46110 RVA: 0x002BD5D8 File Offset: 0x002BB7D8
		private int ReadOffsetCore()
		{
			byte[] array = this.decodeBuffer;
			bool flag = this.inBufPos == this.inBufEnd;
			if (flag)
			{
				int num = this.input.Read(array, 65536, (128L < this.inputLength) ? 128 : ((int)this.inputLength));
				bool flag2 = num == 0;
				if (flag2)
				{
					return -1;
				}
				this.inputLength -= (long)num;
				this.inBufPos = 65536;
				this.inBufEnd = 65536 + num;
			}
			bool flag3 = this.inBufEnd - this.inBufPos == 1;
			if (flag3)
			{
				array[65536] = array[this.inBufPos];
				int num2 = this.input.Read(array, 65537, (127L < this.inputLength) ? 127 : ((int)this.inputLength));
				bool flag4 = num2 == 0;
				if (flag4)
				{
					this.inBufPos = 65536;
					this.inBufEnd = 65537;
					return -1;
				}
				this.inputLength -= (long)num2;
				this.inBufPos = 65536;
				this.inBufEnd = 65536 + num2 + 1;
			}
			int num3 = ((int)array[this.inBufPos + 1] << 8) | (int)array[this.inBufPos];
			this.inBufPos += 2;
			return num3;
		}

		// Token: 0x0600B41F RID: 46111 RVA: 0x002BD738 File Offset: 0x002BB938
		private int ReadCore(byte[] buffer, int offset, int count)
		{
			int num = count;
			byte[] array = this.decodeBuffer;
			int num2 = this.inBufEnd - this.inBufPos;
			int num3 = ((num < num2) ? num : num2);
			bool flag = num3 != 0;
			if (flag)
			{
				int num4 = this.inBufPos;
				int num5 = num3;
				while (num5-- != 0)
				{
					buffer[offset++] = array[num4++];
				}
				this.inBufPos = num4;
				num -= num3;
			}
			bool flag2 = num != 0;
			if (flag2)
			{
				bool flag3 = num >= 128;
				int num6;
				if (flag3)
				{
					num6 = this.input.Read(buffer, offset, ((long)num < this.inputLength) ? num : ((int)this.inputLength));
					num -= num6;
				}
				else
				{
					num6 = this.input.Read(array, 65536, (128L < this.inputLength) ? 128 : ((int)this.inputLength));
					this.inBufPos = 65536;
					this.inBufEnd = 65536 + num6;
					num3 = ((num < num6) ? num : num6);
					int num7 = this.inBufPos;
					int num8 = num3;
					while (num8-- != 0)
					{
						buffer[offset++] = array[num7++];
					}
					this.inBufPos = num7;
					num -= num3;
				}
				this.inputLength -= (long)num6;
			}
			return count - num;
		}

		// Token: 0x170037C1 RID: 14273
		// (get) Token: 0x0600B420 RID: 46112 RVA: 0x002BD8A4 File Offset: 0x002BBAA4
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170037C2 RID: 14274
		// (get) Token: 0x0600B421 RID: 46113 RVA: 0x002BD8B8 File Offset: 0x002BBAB8
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170037C3 RID: 14275
		// (get) Token: 0x0600B422 RID: 46114 RVA: 0x002BD8CC File Offset: 0x002BBACC
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600B423 RID: 46115 RVA: 0x002BD8DF File Offset: 0x002BBADF
		public override void Flush()
		{
		}

		// Token: 0x170037C4 RID: 14276
		// (get) Token: 0x0600B424 RID: 46116 RVA: 0x002BD8E2 File Offset: 0x002BBAE2
		public override long Length
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x170037C5 RID: 14277
		// (get) Token: 0x0600B425 RID: 46117 RVA: 0x002BD8EA File Offset: 0x002BBAEA
		// (set) Token: 0x0600B426 RID: 46118 RVA: 0x002BD8F2 File Offset: 0x002BBAF2
		public override long Position
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x0600B427 RID: 46119 RVA: 0x002BD8FA File Offset: 0x002BBAFA
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600B428 RID: 46120 RVA: 0x002BD902 File Offset: 0x002BBB02
		public override void SetLength(long value)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600B429 RID: 46121 RVA: 0x002BD90A File Offset: 0x002BBB0A
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04005956 RID: 22870
		private long inputLength;

		// Token: 0x04005957 RID: 22871
		private Stream input;

		// Token: 0x04005958 RID: 22872
		private const int DecBufLen = 65536;

		// Token: 0x04005959 RID: 22873
		private const int DecBufMask = 65535;

		// Token: 0x0400595A RID: 22874
		private const int InBufLen = 128;

		// Token: 0x0400595B RID: 22875
		private byte[] decodeBuffer = new byte[65664];

		// Token: 0x0400595C RID: 22876
		private int decodeBufferPos;

		// Token: 0x0400595D RID: 22877
		private int inBufPos;

		// Token: 0x0400595E RID: 22878
		private int inBufEnd;

		// Token: 0x0400595F RID: 22879
		private Lz4DecoderStream.DecodePhase phase;

		// Token: 0x04005960 RID: 22880
		private int litLen;

		// Token: 0x04005961 RID: 22881
		private int matLen;

		// Token: 0x04005962 RID: 22882
		private int matDst;

		// Token: 0x020012DA RID: 4826
		private enum DecodePhase
		{
			// Token: 0x040099E1 RID: 39393
			ReadToken,
			// Token: 0x040099E2 RID: 39394
			ReadExLiteralLength,
			// Token: 0x040099E3 RID: 39395
			CopyLiteral,
			// Token: 0x040099E4 RID: 39396
			ReadOffset,
			// Token: 0x040099E5 RID: 39397
			ReadExMatchLength,
			// Token: 0x040099E6 RID: 39398
			CopyMatch
		}
	}
}
