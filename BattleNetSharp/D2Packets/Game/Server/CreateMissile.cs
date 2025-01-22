using System;

namespace D2Packets.Game.Server
{
	// Token: 0x020009AB RID: 2475
	public class CreateMissile : Packet
	{
		// Token: 0x0400896D RID: 35181
		public GameServerPacket PacketId;

		// Token: 0x0400896E RID: 35182
		public uint Unused;

		// Token: 0x0400896F RID: 35183
		public ushort MissileClassId;

		// Token: 0x04008970 RID: 35184
		public uint X;

		// Token: 0x04008971 RID: 35185
		public uint Y;

		// Token: 0x04008972 RID: 35186
		public uint TargetX;

		// Token: 0x04008973 RID: 35187
		public uint TargetY;

		// Token: 0x04008974 RID: 35188
		public ushort CurrentFrame;

		// Token: 0x04008975 RID: 35189
		public byte OwnerType;

		// Token: 0x04008976 RID: 35190
		public uint OwnerId;

		// Token: 0x04008977 RID: 35191
		public byte SkillLevel;

		// Token: 0x04008978 RID: 35192
		public byte PierceIdxValue;
	}
}
