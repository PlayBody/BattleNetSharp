using System;
using System.Collections.Generic;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009D5 RID: 2517
	public class NPCMoveToTarget : Packet
	{
		// Token: 0x04008AF3 RID: 35571
		public GameServerPacket PacketId;

		// Token: 0x04008AF4 RID: 35572
		public uint Id;

		// Token: 0x04008AF5 RID: 35573
		public byte MovementType;

		// Token: 0x04008AF6 RID: 35574
		public ushort X;

		// Token: 0x04008AF7 RID: 35575
		public ushort Y;

		// Token: 0x04008AF8 RID: 35576
		public UnitType TargetType;

		// Token: 0x04008AF9 RID: 35577
		public uint TargetId;

		// Token: 0x04008AFA RID: 35578
		[MaxVersion(GameVersion.LOD)]
		public ushort unk1;

		// Token: 0x04008AFB RID: 35579
		[MaxVersion(GameVersion.LOD)]
		public ushort unk2;

		// Token: 0x04008AFC RID: 35580
		[MaxVersion(GameVersion.LOD)]
		public ushort unk3;

		// Token: 0x04008AFD RID: 35581
		[MinVersion(GameVersion.D2R)]
		public ushort One;

		// Token: 0x04008AFE RID: 35582
		[MinVersion(GameVersion.D2R)]
		public uint Unk;

		// Token: 0x04008AFF RID: 35583
		[MinVersion(GameVersion.D2R)]
		public byte NumExtra;

		// Token: 0x04008B00 RID: 35584
		[MinVersion(GameVersion.D2R)]
		public byte unk4;

		// Token: 0x04008B01 RID: 35585
		[MinVersion(GameVersion.D2R)]
		public List<uint> ExtraPaths = new List<uint>();
	}
}
