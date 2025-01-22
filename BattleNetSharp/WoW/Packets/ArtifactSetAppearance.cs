using System;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007E0 RID: 2016
	public class ArtifactSetAppearance : ClientPacket
	{
		// Token: 0x040059EA RID: 23018
		public ObjectGuid ArtifactGUID;

		// Token: 0x040059EB RID: 23019
		public ObjectGuid ForgeGUID;

		// Token: 0x040059EC RID: 23020
		public int ArtifactAppearanceID;
	}
}
