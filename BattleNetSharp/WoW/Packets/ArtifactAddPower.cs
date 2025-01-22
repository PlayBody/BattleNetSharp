using System;
using System.Collections.Generic;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007DF RID: 2015
	public class ArtifactAddPower : ClientPacket
	{
		// Token: 0x040059E7 RID: 23015
		public ObjectGuid ArtifactGUID;

		// Token: 0x040059E8 RID: 23016
		public ObjectGuid ForgeGUID;

		// Token: 0x040059E9 RID: 23017
		public List<ArtifactAddPower.ArtifactPowerChoice> PowerChoices = new List<ArtifactAddPower.ArtifactPowerChoice>(1);

		// Token: 0x020012DF RID: 4831
		public struct ArtifactPowerChoice
		{
			// Token: 0x040099EF RID: 39407
			public uint ArtifactPowerID;

			// Token: 0x040099F0 RID: 39408
			public byte Rank;
		}
	}
}
