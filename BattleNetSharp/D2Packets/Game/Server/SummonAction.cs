using System;

namespace D2Packets.Game.Server
{
	// Token: 0x02000A06 RID: 2566
	public class SummonAction : Packet
	{
		// Token: 0x04008C04 RID: 35844
		public GameServerPacket PacketId;

		// Token: 0x04008C05 RID: 35845
		public SummonAction.SummonActionType Type;

		// Token: 0x04008C06 RID: 35846
		public byte SkillTree;

		// Token: 0x04008C07 RID: 35847
		public ushort PetType;

		// Token: 0x04008C08 RID: 35848
		public uint PlayerId;

		// Token: 0x04008C09 RID: 35849
		public uint PetId;

		// Token: 0x0200135A RID: 4954
		public enum SummonActionType : byte
		{
			// Token: 0x04009E55 RID: 40533
			UnsummonedOrLostSight,
			// Token: 0x04009E56 RID: 40534
			SummonedOrReassigned
		}
	}
}
