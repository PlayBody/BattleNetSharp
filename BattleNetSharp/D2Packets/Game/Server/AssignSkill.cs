using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009A0 RID: 2464
	public class AssignSkill : Packet
	{
		// Token: 0x04008943 RID: 35139
		public GameServerPacket PacketId;

		// Token: 0x04008944 RID: 35140
		public UnitType Type;

		// Token: 0x04008945 RID: 35141
		public uint Id;

		// Token: 0x04008946 RID: 35142
		public SkillHand Hand;

		// Token: 0x04008947 RID: 35143
		public SkillType Skill;

		// Token: 0x04008948 RID: 35144
		public uint ChargedItemId;
	}
}
