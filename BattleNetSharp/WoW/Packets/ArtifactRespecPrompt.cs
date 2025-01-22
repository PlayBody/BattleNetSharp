using System;
using WoW.Entities;

namespace WoW.Packets
{
	// Token: 0x020007E3 RID: 2019
	public class ArtifactRespecPrompt : ServerPacket
	{
		// Token: 0x040059F1 RID: 23025
		public ObjectGuid ArtifactGUID;

		// Token: 0x040059F2 RID: 23026
		public ObjectGuid NpcGUID;
	}
}
