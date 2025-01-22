using System;
using D2Packets;

namespace WoW.Packets
{
	// Token: 0x02000819 RID: 2073
	public class AuthWaitInfo : Packet
	{
		// Token: 0x04005ACA RID: 23242
		public uint WaitCount;

		// Token: 0x04005ACB RID: 23243
		public uint WaitTime;

		// Token: 0x04005ACC RID: 23244
		public bool HasFCM;
	}
}
