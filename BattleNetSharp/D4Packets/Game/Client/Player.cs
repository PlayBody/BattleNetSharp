using System;
using System.Runtime.CompilerServices;

namespace D4Packets.Game.Client
{
	// Token: 0x0200088C RID: 2188
	public class Player : D4Packet
	{
		// Token: 0x0400644D RID: 25677
		public Vector3D Location;

		// Token: 0x0400644E RID: 25678
		public uint _0dce541c;

		// Token: 0x0400644F RID: 25679
		[Nullable(2)]
		public EnterKnownLookOverrides tEnterKnownLookOverrides;

		// Token: 0x04006450 RID: 25680
		[Nullable(2)]
		public Type37CFF633 Field3;
	}
}
