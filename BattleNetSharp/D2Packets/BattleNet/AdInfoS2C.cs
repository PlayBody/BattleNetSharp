using System;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AA0 RID: 2720
	public class AdInfoS2C : Packet
	{
		// Token: 0x04008FEF RID: 36847
		public byte FF = byte.MaxValue;

		// Token: 0x04008FF0 RID: 36848
		public BattleNetPacket PacketId;

		// Token: 0x04008FF1 RID: 36849
		public ushort Length;

		// Token: 0x04008FF2 RID: 36850
		public uint AdId;
	}
}
