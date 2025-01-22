using System;
using System.Collections.Generic;

namespace D2Packets.Game.Server
{
	// Token: 0x020009AE RID: 2478
	public class DownloadSave : Packet
	{
		// Token: 0x04008981 RID: 35201
		public GameServerPacket PacketId;

		// Token: 0x04008982 RID: 35202
		public byte ChunkLen;

		// Token: 0x04008983 RID: 35203
		public bool IsFirst;

		// Token: 0x04008984 RID: 35204
		public int SaveSize;

		// Token: 0x04008985 RID: 35205
		public List<byte> Chunk;

		// Token: 0x04008986 RID: 35206
		public byte End = 0;
	}
}
