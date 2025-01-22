using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x0200099A RID: 2458
	public class AssignGameObject : Packet
	{
		// Token: 0x0400890D RID: 35085
		public GameServerPacket PacketId;

		// Token: 0x0400890E RID: 35086
		public UnitType Type;

		// Token: 0x0400890F RID: 35087
		public uint Id;

		// Token: 0x04008910 RID: 35088
		public GameObjectID ObjectId;

		// Token: 0x04008911 RID: 35089
		public ushort X;

		// Token: 0x04008912 RID: 35090
		public ushort Y;

		// Token: 0x04008913 RID: 35091
		public GameObjectMode Mode;

		// Token: 0x04008914 RID: 35092
		public GameObjectInteractType InteractType;
	}
}
