using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AC2 RID: 2754
	public class QueryRealmsS2C : Packet
	{
		// Token: 0x0600BC0F RID: 48143 RVA: 0x00474594 File Offset: 0x00472794
		public override void FromBytes(byte[] Bytes)
		{
			this.memoryStream = new MemoryStream(Bytes);
			this.reader = new BinaryReader(this.memoryStream);
			this.reader.ReadByte();
			this.reader.ReadByte();
			this.Length = this.reader.ReadUInt16();
			this.Zero = this.reader.ReadUInt32();
			this.NumRealms = this.reader.ReadUInt32();
			int num = 0;
			while ((long)num < (long)((ulong)this.NumRealms))
			{
				QueryRealmsS2C.Realm realm = new QueryRealmsS2C.Realm();
				realm.One = this.reader.ReadUInt32();
				List<byte> list = new List<byte>();
				byte b;
				do
				{
					b = this.reader.ReadByte();
					list.Add(b);
				}
				while (b > 0);
				IEnumerable<byte> enumerable = list.Take(list.Count<byte>() - 1);
				realm.Title = Encoding.ASCII.GetString(enumerable.ToArray<byte>());
				list.Clear();
				do
				{
					b = this.reader.ReadByte();
					list.Add(b);
				}
				while (b > 0);
				enumerable = list.Take(list.Count<byte>() - 1);
				realm.Description = Encoding.ASCII.GetString(enumerable.ToArray<byte>());
				this.Realms.Add(realm);
				num++;
			}
		}

		// Token: 0x040090CB RID: 37067
		public byte FF = byte.MaxValue;

		// Token: 0x040090CC RID: 37068
		public BattleNetPacket PacketId;

		// Token: 0x040090CD RID: 37069
		public ushort Length;

		// Token: 0x040090CE RID: 37070
		public uint Zero;

		// Token: 0x040090CF RID: 37071
		public uint NumRealms;

		// Token: 0x040090D0 RID: 37072
		public List<QueryRealmsS2C.Realm> Realms = new List<QueryRealmsS2C.Realm>();

		// Token: 0x02001393 RID: 5011
		public class Realm : Packet
		{
			// Token: 0x04009F70 RID: 40816
			public uint One;

			// Token: 0x04009F71 RID: 40817
			public string Title;

			// Token: 0x04009F72 RID: 40818
			public string Description;
		}
	}
}
