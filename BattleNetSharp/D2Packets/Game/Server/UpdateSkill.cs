using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x02000A1C RID: 2588
	public class UpdateSkill : Packet
	{
		// Token: 0x04008C73 RID: 35955
		public GameServerPacket PacketId;

		// Token: 0x04008C74 RID: 35956
		public byte UnitType;

		// Token: 0x04008C75 RID: 35957
		public byte DeleteSkill;

		// Token: 0x04008C76 RID: 35958
		public uint Id;

		// Token: 0x04008C77 RID: 35959
		public SkillType Skill;

		// Token: 0x04008C78 RID: 35960
		public byte Level;

		// Token: 0x04008C79 RID: 35961
		public byte Bonus;

		// Token: 0x04008C7A RID: 35962
		public byte IncSkillLevel;
	}
}
