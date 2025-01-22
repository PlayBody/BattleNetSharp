using System;

namespace WoW.Packets
{
	// Token: 0x0200080C RID: 2060
	public class Ping : ClientPacket
	{
		// Token: 0x04005AA2 RID: 23202
		public uint Serial;

		// Token: 0x04005AA3 RID: 23203
		public uint Latency;
	}
}
