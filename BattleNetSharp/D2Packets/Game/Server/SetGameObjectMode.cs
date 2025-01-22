using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009FE RID: 2558
	public class SetGameObjectMode : Packet
	{
		// Token: 0x04008BD6 RID: 35798
		public GameServerPacket PacketId;

		// Token: 0x04008BD7 RID: 35799
		public UnitType Type;

		// Token: 0x04008BD8 RID: 35800
		public uint Id;

		// Token: 0x04008BD9 RID: 35801
		public byte Unknown;

		// Token: 0x04008BDA RID: 35802
		public byte CanRevert;

		// Token: 0x04008BDB RID: 35803
		public GameObjectMode Mode;

		// Token: 0x04008BDC RID: 35804
		public ushort Unk1;

		// Token: 0x04008BDD RID: 35805
		public byte unk1;
	}
}
