using System;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AB1 RID: 2737
	public class FileTimeInfoC2S : Packet
	{
		// Token: 0x0400907A RID: 36986
		public byte FF = byte.MaxValue;

		// Token: 0x0400907B RID: 36987
		public BattleNetPacket PacketId;

		// Token: 0x0400907C RID: 36988
		public ushort Length;

		// Token: 0x0400907D RID: 36989
		public uint Request = 2147483652U;

		// Token: 0x0400907E RID: 36990
		public uint Unk = 0U;

		// Token: 0x0400907F RID: 36991
		public string FileName = "bnserver-D2DV.ini";
	}
}
