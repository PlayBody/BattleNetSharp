using System;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007C2 RID: 1986
	public class CriteriaUpdate : ServerPacket
	{
		// Token: 0x04005993 RID: 22931
		public uint CriteriaID;

		// Token: 0x04005994 RID: 22932
		public ulong Quantity;

		// Token: 0x04005995 RID: 22933
		public ObjectGuid PlayerGUID;

		// Token: 0x04005996 RID: 22934
		public uint Flags;

		// Token: 0x04005997 RID: 22935
		public ulong CurrentTime;

		// Token: 0x04005998 RID: 22936
		public uint ElapsedTime;

		// Token: 0x04005999 RID: 22937
		public ulong CreationTime;

		// Token: 0x0400599A RID: 22938
		public Optional<ulong> RafAcceptanceID;
	}
}
