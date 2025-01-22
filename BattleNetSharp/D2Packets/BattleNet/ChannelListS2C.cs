using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AA7 RID: 2727
	public class ChannelListS2C : Packet
	{
		// Token: 0x0600BBEB RID: 48107 RVA: 0x00473EA0 File Offset: 0x004720A0
		public override void FromBytes(byte[] Bytes)
		{
			this.memoryStream = new MemoryStream(Bytes);
			this.reader = new BinaryReader(this.memoryStream);
			this.reader.ReadByte();
			this.reader.ReadByte();
			this.Length = this.reader.ReadUInt16();
			while (this.reader.BaseStream.Position != this.reader.BaseStream.Length - 1L)
			{
				List<byte> list = new List<byte>();
				byte b;
				do
				{
					b = this.reader.ReadByte();
					list.Add(b);
				}
				while (b > 0);
				list.RemoveAt(list.Count - 1);
				this.Channels.Add(Encoding.ASCII.GetString(list.ToArray()));
			}
		}

		// Token: 0x0400903C RID: 36924
		public byte FF = byte.MaxValue;

		// Token: 0x0400903D RID: 36925
		public BattleNetPacket PacketId;

		// Token: 0x0400903E RID: 36926
		public ushort Length;

		// Token: 0x0400903F RID: 36927
		public List<string> Channels = new List<string>();
	}
}
