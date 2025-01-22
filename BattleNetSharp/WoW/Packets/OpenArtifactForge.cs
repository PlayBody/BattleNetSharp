using System;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007E2 RID: 2018
	public class OpenArtifactForge : ServerPacket
	{
		// Token: 0x040059EF RID: 23023
		public ObjectGuid ArtifactGUID;

		// Token: 0x040059F0 RID: 23024
		public ObjectGuid ForgeGUID;
	}
}
