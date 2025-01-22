using System;

namespace D2Packets.BattleNet
{
	// Token: 0x02000ABF RID: 2751
	public class PingC2S : Packet
	{
		// Token: 0x0600BC0B RID: 48139 RVA: 0x0047452A File Offset: 0x0047272A
		public PingC2S(uint ping)
		{
			this.Ping = ping;
		}

		// Token: 0x0600BC0C RID: 48140 RVA: 0x0047454D File Offset: 0x0047274D
		public PingC2S()
		{
		}

		// Token: 0x040090C0 RID: 37056
		public byte FF = byte.MaxValue;

		// Token: 0x040090C1 RID: 37057
		public BattleNetPacket PacketId;

		// Token: 0x040090C2 RID: 37058
		public ushort Length;

		// Token: 0x040090C3 RID: 37059
		public uint Ping = 0U;
	}
}
