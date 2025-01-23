#nullable enable // @Review

using System;
using System.Runtime.CompilerServices;

namespace D4Packets.Game.Client
{
	// Token: 0x020008AD RID: 2221
	public class Type5D0FA598 : D4Packet
	{
		// Token: 0x040064D6 RID: 25814
		public uint Field0;

		// Token: 0x040064D7 RID: 25815
		public uint snoLevelArea;

		// Token: 0x040064D8 RID: 25816
		public uint snoLevelArea1;

		// Token: 0x040064D9 RID: 25817
		public uint Field3;

		// Token: 0x040064DA RID: 25818
		public uint Field4;

		// Token: 0x040064DB RID: 25819
		public uint snoWorld;

		// Token: 0x040064DC RID: 25820
		public uint Field6;

		// Token: 0x040064DD RID: 25821
		public uint snoLevelArea2;

		// Token: 0x040064DE RID: 25822
		public Type78854E88 Field8;

		// Token: 0x040064DF RID: 25823
		public Type78854E88 Field9;

		// Token: 0x040064E0 RID: 25824
		public int snoPresetWorld;

		// Token: 0x040064E1 RID: 25825
		public int nSceneChunk;

		// Token: 0x040064E2 RID: 25826
		public uint? hvhgv;

		// Token: 0x040064E3 RID: 25827
		[DynamicLen(5)]
		public Type4E8E96E4[] Field12;

		// Token: 0x040064E4 RID: 25828
		[DynamicLen(5)]
		public int[] snoGameBalance;

		// Token: 0x040064E5 RID: 25829
<<<<<<< HEAD
//		[Nullable(2)]
=======
		//[Nullable(2)]
>>>>>>> af1e099f8bc7c618aaccfe1feb2a846143c0312a
		public Type95119E98 tDRLGCreationInfo;
	}
}
