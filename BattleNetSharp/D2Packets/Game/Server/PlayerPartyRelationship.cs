using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009EA RID: 2538
	public class PlayerPartyRelationship : Packet
	{
		// Token: 0x04008B76 RID: 35702
		public GameServerPacket PacketId;

		// Token: 0x04008B77 RID: 35703
		public uint Id;

		// Token: 0x04008B78 RID: 35704
		public PartyRelationshipType Relationship;
	}
}
