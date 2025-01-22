using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A43 RID: 2627
	public class IncrementSkill : Packet
	{
		// Token: 0x04008DE5 RID: 36325
		public GameClientPacket PacketId;

		// Token: 0x04008DE6 RID: 36326
		public SkillType Attribute;

		// Token: 0x04008DE7 RID: 36327
		[MinVersion(GameVersion.D2R)]
		public ushort Amount;
	}
}
