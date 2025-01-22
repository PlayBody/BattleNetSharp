using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009E9 RID: 2537
	public class PlayerMoveToTarget : Packet
	{
		// Token: 0x04008B6E RID: 35694
		public GameServerPacket PacketId;

		// Token: 0x04008B6F RID: 35695
		public UnitType Type;

		// Token: 0x04008B70 RID: 35696
		public uint Id;

		// Token: 0x04008B71 RID: 35697
		public byte MovementType;

		// Token: 0x04008B72 RID: 35698
		public UnitType TargetType;

		// Token: 0x04008B73 RID: 35699
		public uint TargetId;

		// Token: 0x04008B74 RID: 35700
		public ushort X;

		// Token: 0x04008B75 RID: 35701
		public ushort Y;
	}
}
