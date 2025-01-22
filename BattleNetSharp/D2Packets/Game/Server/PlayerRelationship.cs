using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009EC RID: 2540
	public class PlayerRelationship : Packet
	{
		// Token: 0x04008B7F RID: 35711
		public GameServerPacket PacketId;

		// Token: 0x04008B80 RID: 35712
		public uint SubjectId;

		// Token: 0x04008B81 RID: 35713
		public uint ObjectId;

		// Token: 0x04008B82 RID: 35714
		public PlayerRelationshipType Relationship;
	}
}
