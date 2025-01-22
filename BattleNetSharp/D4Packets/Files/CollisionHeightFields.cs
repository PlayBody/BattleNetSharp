using System;
using System.Collections.Generic;

namespace D4Packets.Files
{
	// Token: 0x02000849 RID: 2121
	public class CollisionHeightFields : CASCPacket
	{
		// Token: 0x040062D5 RID: 25301
		public PRTransform transform;

		// Token: 0x040062D6 RID: 25302
		public uint fWater;

		// Token: 0x040062D7 RID: 25303
		public ulong unk;

		// Token: 0x040062D8 RID: 25304
		public CollisionHeightFieldsInfo info;

		// Token: 0x040062D9 RID: 25305
		public List<CollisionHeightField> fields;

		// Token: 0x040062DA RID: 25306
		public List<Vector2> unk3;
	}
}
