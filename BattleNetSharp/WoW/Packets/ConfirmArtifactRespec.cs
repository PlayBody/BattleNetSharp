using System;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007E1 RID: 2017
	public class ConfirmArtifactRespec : ClientPacket
	{
		// Token: 0x040059ED RID: 23021
		public ObjectGuid ArtifactGUID;

		// Token: 0x040059EE RID: 23022
		public ObjectGuid NpcGUID;
	}
}
