using System;
using System.Collections.Generic;

namespace D4Packets.Files
{
	// Token: 0x0200085F RID: 2143
	public class AIPathData : CASCPacket
	{
		// Token: 0x04006333 RID: 25395
		public List<AICellData> m_cellData;

		// Token: 0x04006334 RID: 25396
		public List<DataPayload> m_datas;

		// Token: 0x04006335 RID: 25397
		public List<CellData> u2;

		// Token: 0x04006336 RID: 25398
		public ulong u3;

		// Token: 0x04006337 RID: 25399
		public uint u4;

		// Token: 0x04006338 RID: 25400
		public float m_cellWidth;

		// Token: 0x04006339 RID: 25401
		public float m_cellHeight;

		// Token: 0x0400633A RID: 25402
		public uint u5;
	}
}
