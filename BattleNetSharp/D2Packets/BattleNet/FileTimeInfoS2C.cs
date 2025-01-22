using System;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AB2 RID: 2738
	public class FileTimeInfoS2C : Packet
	{
		// Token: 0x04009080 RID: 36992
		public byte FF = byte.MaxValue;

		// Token: 0x04009081 RID: 36993
		public BattleNetPacket PacketId;

		// Token: 0x04009082 RID: 36994
		public ushort Length;

		// Token: 0x04009083 RID: 36995
		public uint Result;

		// Token: 0x04009084 RID: 36996
		public uint Unk;

		// Token: 0x04009085 RID: 36997
		public ulong LastUpdate;

		// Token: 0x04009086 RID: 36998
		public string FileName;
	}
}
