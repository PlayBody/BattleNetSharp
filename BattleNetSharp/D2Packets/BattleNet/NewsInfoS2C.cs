using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace D2Packets.BattleNet
{
	// Token: 0x02000ABD RID: 2749
	public class NewsInfoS2C : Packet
	{
		// Token: 0x0600BC07 RID: 48135 RVA: 0x0047437C File Offset: 0x0047257C
		public override void FromBytes(byte[] Bytes)
		{
			this.memoryStream = new MemoryStream(Bytes);
			this.reader = new BinaryReader(this.memoryStream);
			byte b = this.reader.ReadByte();
			byte b2 = this.reader.ReadByte();
			this.Length = this.reader.ReadUInt16();
			this.NumEntries = this.reader.ReadByte();
			this.LastLogon = this.reader.ReadUInt32();
			this.LastNews = this.reader.ReadUInt32();
			this.FirstNews = this.reader.ReadUInt32();
			for (int i = 0; i < (int)this.NumEntries; i++)
			{
				NewsInfoS2C.News news = new NewsInfoS2C.News
				{
					TimeStamp = this.reader.ReadUInt32()
				};
				List<byte> list = new List<byte>();
				byte b3;
				do
				{
					b3 = this.reader.ReadByte();
					list.Add(b3);
				}
				while (b3 > 0);
				list.RemoveAt(list.Count - 1);
				news.Info = Encoding.ASCII.GetString(list.ToArray());
				this.NewsItems.Add(news);
			}
		}

		// Token: 0x040090B1 RID: 37041
		public byte FF = byte.MaxValue;

		// Token: 0x040090B2 RID: 37042
		public BattleNetPacket PacketId;

		// Token: 0x040090B3 RID: 37043
		public ushort Length;

		// Token: 0x040090B4 RID: 37044
		public byte NumEntries;

		// Token: 0x040090B5 RID: 37045
		public uint LastLogon;

		// Token: 0x040090B6 RID: 37046
		public uint LastNews;

		// Token: 0x040090B7 RID: 37047
		public uint FirstNews;

		// Token: 0x040090B8 RID: 37048
		public List<NewsInfoS2C.News> NewsItems = new List<NewsInfoS2C.News>();

		// Token: 0x02001392 RID: 5010
		public class News : Packet
		{
			// Token: 0x0600DFFE RID: 57342 RVA: 0x004C5404 File Offset: 0x004C3604
			public override byte[] ToArray()
			{
				IEnumerable<byte> enumerable = BitConverter.GetBytes(this.TimeStamp).Concat(Encoding.ASCII.GetBytes(this.Info + "\0"));
				return enumerable.ToArray<byte>();
			}

			// Token: 0x04009F6E RID: 40814
			public uint TimeStamp;

			// Token: 0x04009F6F RID: 40815
			public string Info;
		}
	}
}
