using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009CD RID: 2509
	public class MonsterAttack : Packet
	{
		// Token: 0x04008AB9 RID: 35513
		public GameServerPacket PacketId;

		// Token: 0x04008ABA RID: 35514
		public uint Id;

		// Token: 0x04008ABB RID: 35515
		public ushort AttackType;

		// Token: 0x04008ABC RID: 35516
		public uint TargetId;

		// Token: 0x04008ABD RID: 35517
		public UnitType TargetType;

		// Token: 0x04008ABE RID: 35518
		public ushort X;

		// Token: 0x04008ABF RID: 35519
		public ushort Y;
	}
}
