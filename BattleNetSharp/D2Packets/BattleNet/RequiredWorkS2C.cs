using System;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AC5 RID: 2757
	public class RequiredWorkS2C : Packet
	{
		// Token: 0x040090E0 RID: 37088
		public byte FF = byte.MaxValue;

		// Token: 0x040090E1 RID: 37089
		public BattleNetPacket PacketId;

		// Token: 0x040090E2 RID: 37090
		public ushort Length;

		// Token: 0x040090E3 RID: 37091
		public string MpqFile;
	}
}
