using System;
using System.Collections.Generic;

namespace WoW.Packets
{
	// Token: 0x0200080E RID: 2062
	public class AuthChallenge : ServerPacket
	{
		// Token: 0x04005AA5 RID: 23205
		public List<byte> DosChallenge = new List<byte>(32);

		// Token: 0x04005AA6 RID: 23206
		public List<byte> Challenge = new List<byte>(16);

		// Token: 0x04005AA7 RID: 23207
		public byte DosZeroBits;
	}
}
