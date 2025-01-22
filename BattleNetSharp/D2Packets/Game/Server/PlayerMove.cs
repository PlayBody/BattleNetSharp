using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009E8 RID: 2536
	public class PlayerMove : Packet
	{
		// Token: 0x04008B65 RID: 35685
		public GameServerPacket PacketId;

		// Token: 0x04008B66 RID: 35686
		public UnitType Type;

		// Token: 0x04008B67 RID: 35687
		public uint Id;

		// Token: 0x04008B68 RID: 35688
		public byte MovementType;

		// Token: 0x04008B69 RID: 35689
		public ushort TargetX;

		// Token: 0x04008B6A RID: 35690
		public ushort TargetY;

		// Token: 0x04008B6B RID: 35691
		public byte Unk;

		// Token: 0x04008B6C RID: 35692
		public ushort CurrentX;

		// Token: 0x04008B6D RID: 35693
		public ushort CurrentY;
	}
}
