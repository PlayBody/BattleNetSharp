using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A59 RID: 2649
	public class ResurrectMerc : Packet
	{
		// Token: 0x04008E58 RID: 36440
		public GameClientPacket PacketId;

		// Token: 0x04008E59 RID: 36441
		public uint DealerId;

		// Token: 0x04008E5A RID: 36442
		[MinVersion(GameVersion.D2R)]
		public ushort NameId;

		// Token: 0x04008E5B RID: 36443
		[MinVersion(GameVersion.D2R)]
		public ushort Unk;

		// Token: 0x04008E5C RID: 36444
		[MinVersion(GameVersion.D2R)]
		public uint Cost;
	}
}
