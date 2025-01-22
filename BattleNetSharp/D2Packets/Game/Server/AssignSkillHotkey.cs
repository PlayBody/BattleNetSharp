using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009A1 RID: 2465
	public class AssignSkillHotkey : Packet
	{
		// Token: 0x04008949 RID: 35145
		public GameServerPacket PacketId;

		// Token: 0x0400894A RID: 35146
		public byte Slot;

		// Token: 0x0400894B RID: 35147
		public SkillType Skill;

		// Token: 0x0400894C RID: 35148
		public uint ChargedItemId;
	}
}
