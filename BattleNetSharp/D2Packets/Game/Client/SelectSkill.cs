using System;
using D2Data;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A5C RID: 2652
	public class SelectSkill : Packet
	{
		// Token: 0x04008E6E RID: 36462
		public GameClientPacket PacketId;

		// Token: 0x04008E6F RID: 36463
		public SkillType Type;

		// Token: 0x04008E70 RID: 36464
		public SelectSkill.SelectSkillHand Hand;

		// Token: 0x04008E71 RID: 36465
		public uint ChargedItemId = uint.MaxValue;

		// Token: 0x0200136F RID: 4975
		public enum SelectSkillHand : ushort
		{
			// Token: 0x04009EA2 RID: 40610
			Right,
			// Token: 0x04009EA3 RID: 40611
			Left = 32768
		}
	}
}
