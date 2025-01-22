using System;

namespace D2Packets.Realm
{
	// Token: 0x02000A94 RID: 2708
	public class GameListC2S : Packet
	{
		// Token: 0x04008FAC RID: 36780
		public ushort Length;

		// Token: 0x04008FAD RID: 36781
		public RealmPacket PacketId;

		// Token: 0x04008FAE RID: 36782
		public ushort RequestId = 2;

		// Token: 0x04008FAF RID: 36783
		public uint Unk = 0U;

		// Token: 0x04008FB0 RID: 36784
		public string Filter = "";
	}
}
