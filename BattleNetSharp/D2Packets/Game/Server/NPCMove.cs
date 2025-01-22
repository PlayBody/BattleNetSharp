using System;
using System.Collections.Generic;

namespace D2Packets.Game.Server
{
	// Token: 0x020009D4 RID: 2516
	public class NPCMove : Packet
	{
		// Token: 0x04008AE4 RID: 35556
		public GameServerPacket PacketId;

		// Token: 0x04008AE5 RID: 35557
		public uint Id;

		// Token: 0x04008AE6 RID: 35558
		public byte MovementType;

		// Token: 0x04008AE7 RID: 35559
		public ushort X;

		// Token: 0x04008AE8 RID: 35560
		public ushort Y;

		// Token: 0x04008AE9 RID: 35561
		[MaxVersion(GameVersion.LOD)]
		public ushort unk1;

		// Token: 0x04008AEA RID: 35562
		[MaxVersion(GameVersion.LOD)]
		public ushort unk2;

		// Token: 0x04008AEB RID: 35563
		[MaxVersion(GameVersion.LOD)]
		public ushort unk3;

		// Token: 0x04008AEC RID: 35564
		[MinVersion(GameVersion.D2R)]
		public ushort X2;

		// Token: 0x04008AED RID: 35565
		[MinVersion(GameVersion.D2R)]
		public ushort Y2;

		// Token: 0x04008AEE RID: 35566
		[MinVersion(GameVersion.D2R)]
		public ushort One;

		// Token: 0x04008AEF RID: 35567
		[MinVersion(GameVersion.D2R)]
		public uint Unk;

		// Token: 0x04008AF0 RID: 35568
		[MinVersion(GameVersion.D2R)]
		public byte NumExtra;

		// Token: 0x04008AF1 RID: 35569
		[MinVersion(GameVersion.D2R)]
		public byte unk4;

		// Token: 0x04008AF2 RID: 35570
		[MinVersion(GameVersion.D2R)]
		public List<uint> ExtraPaths = new List<uint>();
	}
}
