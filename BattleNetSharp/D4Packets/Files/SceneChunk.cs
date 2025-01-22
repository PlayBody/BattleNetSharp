using System;

namespace D4Packets.Files
{
	// Token: 0x02000865 RID: 2149
	public class SceneChunk : CASCPacket
	{
		// Token: 0x04006397 RID: 25495
		public uint snoname;

		// Token: 0x04006398 RID: 25496
		public PRTransform transform;

		// Token: 0x04006399 RID: 25497
		public SceneSpecification tSceneSpec;
	}
}
