using System;

namespace D2Packets.Game.Server
{
	// Token: 0x0200099E RID: 2462
	public class AssignPlayerCorpse : Packet
	{
		// Token: 0x0400893C RID: 35132
		public GameServerPacket PacketId;

		// Token: 0x0400893D RID: 35133
		public byte Assign;

		// Token: 0x0400893E RID: 35134
		public uint PlayerId;

		// Token: 0x0400893F RID: 35135
		public uint CorpseId;
	}
}
