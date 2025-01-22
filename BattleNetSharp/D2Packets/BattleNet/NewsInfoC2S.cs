using System;

namespace D2Packets.BattleNet
{
	// Token: 0x02000ABC RID: 2748
	public class NewsInfoC2S : Packet
	{
		// Token: 0x040090AD RID: 37037
		public byte FF = byte.MaxValue;

		// Token: 0x040090AE RID: 37038
		public BattleNetPacket PacketId;

		// Token: 0x040090AF RID: 37039
		public ushort Length;

		// Token: 0x040090B0 RID: 37040
		public uint TimeStamp = (uint)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
	}
}
