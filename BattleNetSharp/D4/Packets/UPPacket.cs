using System;
using System.Linq;

namespace BattleNetSharp.D4.Packets
{
	// Token: 0x02000B15 RID: 2837
	public class UPPacket
	{
		// Token: 0x0600BE6C RID: 48748 RVA: 0x0048B1CC File Offset: 0x004893CC
		public UPPacket(byte[] buffer)
		{
			Array.Copy(buffer, 0, this.Header, 0, this.Header.Length);
			this.PacketSize = (((((int)this.Header[0] << 8) | (int)this.Header[1]) << 8) | (int)this.Header[2]) / 4;
			this.PacketSize = (((int)this.Header[1] << 8) | (int)this.Header[2]) >> 2;
			this.Compressed = (this.Header[2] & 3) >= 2;
			this.Data = new byte[this.PacketSize - this.Tag.Length];
			Array.Copy(buffer, 3, this.Tag, 0, this.Tag.Length);
			bool flag = buffer.Length > 15;
			if (flag)
			{
				Array.Copy(buffer, 15, this.Data, 0, this.PacketSize - this.Tag.Length);
			}
		}

		// Token: 0x0600BE6D RID: 48749 RVA: 0x0048B2E0 File Offset: 0x004894E0
		public UPPacket(byte[] header, byte[] body)
		{
			this.Header = header;
			this.Data = body;
		}

		// Token: 0x0600BE6E RID: 48750 RVA: 0x0048B336 File Offset: 0x00489536
		public UPPacket()
		{
		}

		// Token: 0x0600BE6F RID: 48751 RVA: 0x0048B374 File Offset: 0x00489574
		public byte[] GetBytes()
		{
			byte[] array = new byte[this.Header.Length + this.Tag.Length + this.Data.Length];
			byte[] array2 = BitConverter.GetBytes((array.Length - 3) * 4).Reverse<byte>().ToArray<byte>();
			Array.Copy(array2, 1, this.Header, 0, 3);
			Array.Copy(this.Header, 0, array, 0, this.Header.Length);
			Array.Copy(this.Tag, 0, array, 3, this.Tag.Length);
			Array.Copy(this.Data, 0, array, 15, this.Data.Length);
			byte[] array3 = array;
			int num = 2;
			array3[num] |= 1;
			bool compressed = this.Compressed;
			if (compressed)
			{
				byte[] array4 = array;
				int num2 = 2;
				array4[num2] |= 2;
			}
			return array;
		}

		// Token: 0x040091B7 RID: 37303
		public byte[] Header = new byte[3];

		// Token: 0x040091B8 RID: 37304
		public byte[] Tag = new byte[12];

		// Token: 0x040091B9 RID: 37305
		public byte[] Data = new byte[0];

		// Token: 0x040091BA RID: 37306
		public bool Compressed = false;

		// Token: 0x040091BB RID: 37307
		public int PacketSize = 0;
	}
}
