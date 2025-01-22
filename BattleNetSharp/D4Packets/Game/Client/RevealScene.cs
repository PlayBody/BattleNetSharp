using System;

namespace D4Packets.Game.Client
{
	// Token: 0x020008AC RID: 2220
	[D4Packet.OpcodeAttribute(Opcodes.SMSG_REVEAL_SCENE)]
	public class RevealScene : D4Packet
	{
		// Token: 0x040064CC RID: 25804
		public ulong WorldID;

		// Token: 0x040064CD RID: 25805
		public Type5D0FA598 SceneSpecification;

		// Token: 0x040064CE RID: 25806
		public ulong ChunkID;

		// Token: 0x040064CF RID: 25807
		public uint snoScene;

		// Token: 0x040064D0 RID: 25808
		public uint snoMarkerSet;

		// Token: 0x040064D1 RID: 25809
		public PRTransform Transform;

		// Token: 0x040064D2 RID: 25810
		[DynamicLen(9)]
		public uint[] snoAIState;

		// Token: 0x040064D3 RID: 25811
		[DynamicLen(6)]
		public TypeB3C2EA5E[] Field7;

		// Token: 0x040064D4 RID: 25812
		[DynamicLen(3)]
		public uint[] Field8;

		// Token: 0x040064D5 RID: 25813
		public uint dwSceneFlags;
	}
}
