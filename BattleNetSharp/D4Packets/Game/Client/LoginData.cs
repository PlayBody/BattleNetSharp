using System;
using Fenris.ClientMessage;

namespace D4Packets.Game.Client
{
	// Token: 0x020008C1 RID: 2241
	[D4Packet.OpcodeAttribute(Opcodes.SMSG_USER_PROXY_LOGIN_DATA_RETRIEVED)]
	public class LoginData : D4Packet
	{
		// Token: 0x04006520 RID: 25888
		public uint Token;

		// Token: 0x04006521 RID: 25889
		public uint Error;

		// Token: 0x04006522 RID: 25890
		public GetInitialDataResponse DataRequest;
	}
}
