using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace D2Packets.Game.Server
{
	// Token: 0x02000998 RID: 2456
	public class AcceptTrade : Packet
	{
		// Token: 0x17003914 RID: 14612
		// (get) Token: 0x0600BA8D RID: 47757 RVA: 0x0046C530 File Offset: 0x0046A730
		public string Name
		{
			get
			{
				List<byte> list = BitConverter.GetBytes(this.Name1).ToList<byte>();
				list.AddRange(BitConverter.GetBytes(this.Name2).ToList<byte>());
				return Encoding.ASCII.GetString(list.ToArray());
			}
		}

		// Token: 0x04008907 RID: 35079
		public GameServerPacket PacketId;

		// Token: 0x04008908 RID: 35080
		public ulong Name1;

		// Token: 0x04008909 RID: 35081
		public ulong Name2;

		// Token: 0x0400890A RID: 35082
		public uint Id;
	}
}
