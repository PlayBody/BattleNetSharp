using System;

namespace D4Packets.Game.Client
{
	// Token: 0x02000883 RID: 2179
	public class WorldLocationMessageData : D4Packet
	{
		// Token: 0x04006434 RID: 25652
		public Vector3D Scale;

		// Token: 0x04006435 RID: 25653
		public PRTransform Transform;

		// Token: 0x04006436 RID: 25654
		public long WorldID;
	}
}
