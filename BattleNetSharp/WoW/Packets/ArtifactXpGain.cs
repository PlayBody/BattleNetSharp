using System;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007E4 RID: 2020
	public class ArtifactXpGain : ServerPacket
	{
		// Token: 0x040059F3 RID: 23027
		public ObjectGuid ArtifactGUID;

		// Token: 0x040059F4 RID: 23028
		public ulong Amount;
	}
}
