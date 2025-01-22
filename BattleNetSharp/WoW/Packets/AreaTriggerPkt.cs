using System;

namespace WoW.Packets
{
	// Token: 0x020007DA RID: 2010
	public class AreaTriggerPkt : ClientPacket
	{
		// Token: 0x040059DE RID: 23006
		public uint AreaTriggerID;

		// Token: 0x040059DF RID: 23007
		public bool Entered;

		// Token: 0x040059E0 RID: 23008
		public bool FromClient;
	}
}
