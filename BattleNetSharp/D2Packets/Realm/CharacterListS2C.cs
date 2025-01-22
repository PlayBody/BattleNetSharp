using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using D2Data;

namespace D2Packets.Realm
{
	// Token: 0x02000A8B RID: 2699
	public class CharacterListS2C : Packet
	{
		// Token: 0x0600BBCB RID: 48075 RVA: 0x00473610 File Offset: 0x00471810
		public override void FromBytes(byte[] Bytes)
		{
			this.memoryStream = new MemoryStream(Bytes);
			this.reader = new BinaryReader(this.memoryStream);
			this.Length = this.reader.ReadUInt16();
			this.PacketId = (RealmPacket)this.reader.ReadByte();
			this.NumCharsRequested = this.reader.ReadUInt16();
			this.NumCharsExist = this.reader.ReadUInt32();
			this.NumCharsReturned = this.reader.ReadUInt16();
			int num = 0;
			while ((long)num < (long)((ulong)this.NumCharsExist))
			{
				CharacterListS2C.CharacterInfo characterInfo = new CharacterListS2C.CharacterInfo();
				characterInfo.ExpirationDate = this.reader.ReadUInt32();
				List<byte> list = new List<byte>();
				byte b;
				do
				{
					b = this.reader.ReadByte();
					list.Add(b);
				}
				while (b > 0);
				list.RemoveAt(list.Count - 1);
				characterInfo.Name = Encoding.ASCII.GetString(list.ToArray());
				list.Clear();
				do
				{
					b = this.reader.ReadByte();
					list.Add(b);
				}
				while (b > 0);
				list.RemoveAt(list.Count - 1);
				characterInfo.StatArray = list;
				this.Characters.Add(characterInfo);
				num++;
			}
		}

		// Token: 0x0600BBCC RID: 48076 RVA: 0x00473760 File Offset: 0x00471960
		public override byte[] ToArray()
		{
			this.memoryStream = new MemoryStream();
			this.writer = new BinaryWriter(this.memoryStream);
			this.writer.Write(this.Length);
			this.writer.Write(25);
			this.writer.Write(this.NumCharsRequested);
			this.writer.Write(this.NumCharsExist);
			this.writer.Write(this.NumCharsReturned);
			int num = 0;
			while ((long)num < (long)((ulong)this.NumCharsExist))
			{
				CharacterListS2C.CharacterInfo characterInfo = this.Characters[num];
				this.writer.Write(characterInfo.ExpirationDate);
				this.writer.Write(Encoding.UTF8.GetBytes(characterInfo.Name));
				this.writer.Write(characterInfo.StatArray.ToArray());
				num++;
			}
			byte[] array = this.memoryStream.ToArray();
			Array.Copy(BitConverter.GetBytes((ushort)array.Length), array, 2);
			return array;
		}

		// Token: 0x04008F7A RID: 36730
		public ushort Length;

		// Token: 0x04008F7B RID: 36731
		public RealmPacket PacketId;

		// Token: 0x04008F7C RID: 36732
		public ushort NumCharsRequested;

		// Token: 0x04008F7D RID: 36733
		public uint NumCharsExist;

		// Token: 0x04008F7E RID: 36734
		public ushort NumCharsReturned;

		// Token: 0x04008F7F RID: 36735
		public List<CharacterListS2C.CharacterInfo> Characters = new List<CharacterListS2C.CharacterInfo>();

		// Token: 0x02001383 RID: 4995
		public class CharacterInfo : Packet
		{
			// Token: 0x17003974 RID: 14708
			// (get) Token: 0x0600DFF4 RID: 57332 RVA: 0x004C52B4 File Offset: 0x004C34B4
			public CharacterClass Class
			{
				get
				{
					return (CharacterClass)(this.StatArray[13] - 1);
				}
			}

			// Token: 0x17003975 RID: 14709
			// (get) Token: 0x0600DFF5 RID: 57333 RVA: 0x004C52D8 File Offset: 0x004C34D8
			public byte Level
			{
				get
				{
					return this.StatArray[25];
				}
			}

			// Token: 0x17003976 RID: 14710
			// (get) Token: 0x0600DFF6 RID: 57334 RVA: 0x004C52F8 File Offset: 0x004C34F8
			public bool Hardcore
			{
				get
				{
					return (this.StatArray[26] & 4) > 0;
				}
			}

			// Token: 0x17003977 RID: 14711
			// (get) Token: 0x0600DFF7 RID: 57335 RVA: 0x004C531C File Offset: 0x004C351C
			public bool Dead
			{
				get
				{
					return (this.StatArray[26] & 8) > 0;
				}
			}

			// Token: 0x17003978 RID: 14712
			// (get) Token: 0x0600DFF8 RID: 57336 RVA: 0x004C5340 File Offset: 0x004C3540
			public bool Expansion
			{
				get
				{
					return (this.StatArray[26] & 32) > 0;
				}
			}

			// Token: 0x04009F07 RID: 40711
			public uint ExpirationDate;

			// Token: 0x04009F08 RID: 40712
			public string Name;

			// Token: 0x04009F09 RID: 40713
			public List<byte> StatArray;
		}
	}
}
