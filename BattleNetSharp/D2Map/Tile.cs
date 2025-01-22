using System;
using System.Collections.Generic;

namespace D2Map
{
	// Token: 0x020008F6 RID: 2294
	public class Tile
	{
		// Token: 0x0600B7D5 RID: 47061 RVA: 0x002DBDA0 File Offset: 0x002D9FA0
		public List<byte> GetBytes()
		{
			List<byte> list = new List<byte>();
			list.Add((byte)this.Direction);
			list.AddRange(BitConverter.GetBytes(this.RoofHeight));
			list.Add(this.SoundIndex);
			list.Add(this.Animated);
			list.AddRange(BitConverter.GetBytes(this.Height));
			list.AddRange(BitConverter.GetBytes(this.Width));
			list.AddRange(BitConverter.GetBytes(this.Orientation));
			list.AddRange(BitConverter.GetBytes(this.MainIndex));
			list.AddRange(BitConverter.GetBytes(this.SubIndex));
			list.AddRange(BitConverter.GetBytes(this.RarityFrame));
			return list;
		}

		// Token: 0x0600B7D6 RID: 47062 RVA: 0x002DBE60 File Offset: 0x002DA060
		public Tile(List<byte> b)
		{
			byte[] array = b.ToArray();
			int num = 0;
			this.Direction = (uint)b[num++];
			this.RoofHeight = BitConverter.ToUInt16(array, num);
			num += 2;
			this.SoundIndex = b[num++];
			this.Animated = b[num++];
			this.Height = BitConverter.ToInt32(array, num);
			num += 4;
			this.Width = BitConverter.ToUInt32(array, num);
			num += 4;
			this.Orientation = BitConverter.ToUInt32(array, num);
			num += 4;
			this.MainIndex = BitConverter.ToUInt32(array, num);
			num += 4;
			this.SubIndex = BitConverter.ToUInt32(array, num);
			num += 4;
			this.RarityFrame = BitConverter.ToUInt32(array, num);
			num += 4;
		}

		// Token: 0x0600B7D7 RID: 47063 RVA: 0x002DBF28 File Offset: 0x002DA128
		public Tile()
		{
		}

		// Token: 0x040069FF RID: 27135
		public uint Direction;

		// Token: 0x04006A00 RID: 27136
		public ushort RoofHeight;

		// Token: 0x04006A01 RID: 27137
		public byte SoundIndex;

		// Token: 0x04006A02 RID: 27138
		public byte Animated;

		// Token: 0x04006A03 RID: 27139
		public int Height;

		// Token: 0x04006A04 RID: 27140
		public uint Width;

		// Token: 0x04006A05 RID: 27141
		public uint unk1;

		// Token: 0x04006A06 RID: 27142
		public uint Orientation;

		// Token: 0x04006A07 RID: 27143
		public uint MainIndex;

		// Token: 0x04006A08 RID: 27144
		public uint SubIndex;

		// Token: 0x04006A09 RID: 27145
		public uint RarityFrame;
	}
}
