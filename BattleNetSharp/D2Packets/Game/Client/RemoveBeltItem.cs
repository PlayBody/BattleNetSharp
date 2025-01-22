using System;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A53 RID: 2643
	public class RemoveBeltItem : Packet
	{
		// Token: 0x04008E41 RID: 36417
		public GameClientPacket PacketId;

		// Token: 0x04008E42 RID: 36418
		public uint Id;

		// Token: 0x04008E43 RID: 36419
		[MinVersion(GameVersion.D2R)]
		public byte BeltPos;

		// Token: 0x04008E44 RID: 36420
		[MinVersion(GameVersion.D2R)]
		public uint Row1Pot = uint.MaxValue;

		// Token: 0x04008E45 RID: 36421
		[MinVersion(GameVersion.D2R)]
		public byte Row1PrevPos;

		// Token: 0x04008E46 RID: 36422
		[MinVersion(GameVersion.D2R)]
		public byte Row1NewPos;

		// Token: 0x04008E47 RID: 36423
		[MinVersion(GameVersion.D2R)]
		public uint Row2Pot = uint.MaxValue;

		// Token: 0x04008E48 RID: 36424
		[MinVersion(GameVersion.D2R)]
		public byte Row2PrevPos;

		// Token: 0x04008E49 RID: 36425
		[MinVersion(GameVersion.D2R)]
		public byte Row2NewPos;

		// Token: 0x04008E4A RID: 36426
		[MinVersion(GameVersion.D2R)]
		public uint Row3Pot = uint.MaxValue;

		// Token: 0x04008E4B RID: 36427
		[MinVersion(GameVersion.D2R)]
		public byte Row3PrevPos;

		// Token: 0x04008E4C RID: 36428
		[MinVersion(GameVersion.D2R)]
		public byte Row3NewPos;
	}
}
