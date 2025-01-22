using System;

namespace D2Packets.Game.Server
{
	// Token: 0x02000997 RID: 2455
	public class AboutPlayer : Packet
	{
		// Token: 0x04008901 RID: 35073
		public GameServerPacket PacketId;

		// Token: 0x04008902 RID: 35074
		public uint Id;

		// Token: 0x04008903 RID: 35075
		public ushort PartyId;

		// Token: 0x04008904 RID: 35076
		public ushort Level;

		// Token: 0x04008905 RID: 35077
		public ushort Relationship;

		// Token: 0x04008906 RID: 35078
		public ushort Ally;
	}
}
