using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A61 RID: 2657
	public class SetPlayerRelation : Packet
	{
		// Token: 0x04008E8B RID: 36491
		public GameClientPacket PacketId;

		// Token: 0x04008E8C RID: 36492
		public PlayerRelationType Relation;

		// Token: 0x04008E8D RID: 36493
		public byte Value;

		// Token: 0x04008E8E RID: 36494
		public uint Id;
	}
}
