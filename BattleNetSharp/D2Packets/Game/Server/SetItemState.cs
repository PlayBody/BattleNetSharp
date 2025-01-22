using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009FF RID: 2559
	public class SetItemState : Packet
	{
		// Token: 0x04008BDE RID: 35806
		public GameServerPacket PacketId;

		// Token: 0x04008BDF RID: 35807
		public UnitType Type;

		// Token: 0x04008BE0 RID: 35808
		public uint OwnerId;

		// Token: 0x04008BE1 RID: 35809
		public uint ItemId;

		// Token: 0x04008BE2 RID: 35810
		public byte unk1;

		// Token: 0x04008BE3 RID: 35811
		public SetItemState.ItemStateType State;

		// Token: 0x04008BE4 RID: 35812
		public ushort unk2;

		// Token: 0x04008BE5 RID: 35813
		public SetItemState.ItemStateType State2;

		// Token: 0x04008BE6 RID: 35814
		public byte unk3;

		// Token: 0x02001356 RID: 4950
		public enum ItemStateType : ushort
		{
			// Token: 0x04009E4C RID: 40524
			Broken = 1,
			// Token: 0x04009E4D RID: 40525
			Full
		}
	}
}
