using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x02000A18 RID: 2584
	public class UpdatePlayerItemSkill : Packet
	{
		// Token: 0x04008C60 RID: 35936
		public GameServerPacket PacketId;

		// Token: 0x04008C61 RID: 35937
		public ushort Unkd800;

		// Token: 0x04008C62 RID: 35938
		public uint Id;

		// Token: 0x04008C63 RID: 35939
		public SkillType Skill;

		// Token: 0x04008C64 RID: 35940
		public byte Quantity;

		// Token: 0x04008C65 RID: 35941
		public ushort Unk5f;
	}
}
