using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A70 RID: 2672
	public class SwitchWeapons : Packet
	{
		// Token: 0x04008EE6 RID: 36582
		public GameClientPacket PacketId;

		// Token: 0x04008EE7 RID: 36583
		[MinVersion(GameVersion.D2R)]
		public uint LeftId1 = uint.MaxValue;

		// Token: 0x04008EE8 RID: 36584
		[MinVersion(GameVersion.D2R)]
		public uint RightId1 = uint.MaxValue;

		// Token: 0x04008EE9 RID: 36585
		[MinVersion(GameVersion.D2R)]
		public uint LeftId2 = uint.MaxValue;

		// Token: 0x04008EEA RID: 36586
		[MinVersion(GameVersion.D2R)]
		public uint RightId2 = uint.MaxValue;

		// Token: 0x04008EEB RID: 36587
		[MinVersion(GameVersion.D2R)]
		public uint LeftId3 = uint.MaxValue;

		// Token: 0x04008EEC RID: 36588
		[MinVersion(GameVersion.D2R)]
		public uint RightId3 = uint.MaxValue;

		// Token: 0x04008EED RID: 36589
		[MinVersion(GameVersion.D2R)]
		public SkillType LeftSkill;

		// Token: 0x04008EEE RID: 36590
		[MinVersion(GameVersion.D2R)]
		public SkillType RightSkill;

		// Token: 0x04008EEF RID: 36591
		[MinVersion(GameVersion.D2R)]
		public byte SwapId;
	}
}
