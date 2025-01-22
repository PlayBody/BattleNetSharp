using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A47 RID: 2631
	public class PartyRequest : Packet
	{
		// Token: 0x04008DFE RID: 36350
		public GameClientPacket PacketId;

		// Token: 0x04008DFF RID: 36351
		public PartyRequest.PartyAction Action;

		// Token: 0x04008E00 RID: 36352
		public uint PlayerId;

		// Token: 0x02001368 RID: 4968
		public enum PartyAction : byte
		{
			// Token: 0x04009E8B RID: 40587
			InviteD2R = 4,
			// Token: 0x04009E8C RID: 40588
			Invite = 6,
			// Token: 0x04009E8D RID: 40589
			CancelInvite,
			// Token: 0x04009E8E RID: 40590
			AcceptInvite,
			// Token: 0x04009E8F RID: 40591
			LeaveParty
		}
	}
}
