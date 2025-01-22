using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A25 RID: 2597
	public class CainIdentifyItems : Packet
	{
		// Token: 0x04008C9F RID: 35999
		public GameClientPacket PacketId;

		// Token: 0x04008CA0 RID: 36000
		public uint Id;

		// Token: 0x04008CA1 RID: 36001
		[MinVersion(GameVersion.D2R)]
		public uint Unk0;
	}
}
