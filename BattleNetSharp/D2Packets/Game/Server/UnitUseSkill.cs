using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x02000A0D RID: 2573
	public class UnitUseSkill : Packet
	{
		// Token: 0x04008C2B RID: 35883
		public GameServerPacket PacketId;

		// Token: 0x04008C2C RID: 35884
		public UnitType Type;

		// Token: 0x04008C2D RID: 35885
		public uint Id;

		// Token: 0x04008C2E RID: 35886
		public SkillType Skill;

		// Token: 0x04008C2F RID: 35887
		public ushort Pad;

		// Token: 0x04008C30 RID: 35888
		public byte SkillLevel;

		// Token: 0x04008C31 RID: 35889
		public ushort X;

		// Token: 0x04008C32 RID: 35890
		public ushort Y;

		// Token: 0x04008C33 RID: 35891
		[MinVersion(GameVersion.D2R)]
		public ushort X2;

		// Token: 0x04008C34 RID: 35892
		[MinVersion(GameVersion.D2R)]
		public ushort Y2;

		// Token: 0x04008C35 RID: 35893
		public ushort Unk3;
	}
}
