using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x02000A0E RID: 2574
	public class UnitUseSkillOnTarget : Packet
	{
		// Token: 0x04008C36 RID: 35894
		public GameServerPacket PacketId;

		// Token: 0x04008C37 RID: 35895
		public UnitType Type;

		// Token: 0x04008C38 RID: 35896
		public uint Id;

		// Token: 0x04008C39 RID: 35897
		public SkillType Skill;

		// Token: 0x04008C3A RID: 35898
		public byte SkillLevel;

		// Token: 0x04008C3B RID: 35899
		public UnitType TargetType;

		// Token: 0x04008C3C RID: 35900
		public uint TargetId;

		// Token: 0x04008C3D RID: 35901
		[MinVersion(GameVersion.D2R)]
		public ushort X2;

		// Token: 0x04008C3E RID: 35902
		[MinVersion(GameVersion.D2R)]
		public ushort Y2;

		// Token: 0x04008C3F RID: 35903
		public ushort unk2;
	}
}
