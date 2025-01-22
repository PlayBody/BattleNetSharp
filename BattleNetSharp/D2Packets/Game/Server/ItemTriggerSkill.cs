using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009C0 RID: 2496
	public class ItemTriggerSkill : Packet
	{
		// Token: 0x04008A7C RID: 35452
		public GameServerPacket PacketId;

		// Token: 0x04008A7D RID: 35453
		public UnitType OwnerType;

		// Token: 0x04008A7E RID: 35454
		public uint OwnerId;

		// Token: 0x04008A7F RID: 35455
		public SkillType Skill;

		// Token: 0x04008A80 RID: 35456
		public byte Level;

		// Token: 0x04008A81 RID: 35457
		public UnitType TargetType;

		// Token: 0x04008A82 RID: 35458
		public uint TargetId;

		// Token: 0x04008A83 RID: 35459
		public ItemTriggerSkill.ItemEventCause Cause;

		// Token: 0x04008A84 RID: 35460
		[MaxVersion(GameVersion.LOD)]
		public byte unka;

		// Token: 0x04008A85 RID: 35461
		[MinVersion(GameVersion.D2R)]
		public byte unk1;

		// Token: 0x04008A86 RID: 35462
		[MinVersion(GameVersion.D2R)]
		public uint unk;

		// Token: 0x02001353 RID: 4947
		public enum ItemEventCause : byte
		{
			// Token: 0x04009E3E RID: 40510
			Target,
			// Token: 0x04009E3F RID: 40511
			Owner
		}
	}
}
