using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A62 RID: 2658
	public class SetSkillHotkey : Packet
	{
		// Token: 0x04008E8F RID: 36495
		public GameClientPacket PacketId;

		// Token: 0x04008E90 RID: 36496
		public SkillType Type;

		// Token: 0x04008E91 RID: 36497
		public ushort Slot;

		// Token: 0x04008E92 RID: 36498
		public uint Id;
	}
}
