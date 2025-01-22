using System;
using Fenris.Client;

namespace D4Packets.Game.Client
{
	// Token: 0x020008B6 RID: 2230
	[D4Packet.OpcodeAttribute(Opcodes.SMSG_USER_PROXY_ACCOUNT_PREFERENCES_LOADED)]
	public class AccountPreferencesLoaded : D4Packet
	{
		// Token: 0x04006504 RID: 25860
		public uint Token;

		// Token: 0x04006505 RID: 25861
		public uint Error = 0U;

		// Token: 0x04006506 RID: 25862
		public Preferences message;
	}
}
