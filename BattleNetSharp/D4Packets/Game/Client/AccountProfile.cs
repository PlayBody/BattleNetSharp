using System;
using Fenris.ClientMessage;

namespace D4Packets.Game.Client
{
	// Token: 0x020008B7 RID: 2231
	[D4Packet.OpcodeAttribute(Opcodes.SMSG_USER_PROXY_GET_ACCOUNT_PROFILE_RESPONSE)]
	public class AccountProfile : D4Packet
	{
		// Token: 0x04006507 RID: 25863
		public uint Token;

		// Token: 0x04006508 RID: 25864
		public uint Error = 0U;

		// Token: 0x04006509 RID: 25865
		public GetAccountProfileResponse message;
	}
}
