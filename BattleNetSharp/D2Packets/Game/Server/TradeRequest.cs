using System;

namespace D2Packets.Game.Server
{
	// Token: 0x02000A09 RID: 2569
	public class TradeRequest : Packet
	{
		// Token: 0x04008C0D RID: 35853
		public GameServerPacket PacketId;

		// Token: 0x04008C0E RID: 35854
		public byte TradeType;

		// Token: 0x04008C0F RID: 35855
		public uint Guid;

		// Token: 0x04008C10 RID: 35856
		public ushort SizeMaybe;

		// Token: 0x04008C11 RID: 35857
		public uint CancelId;

		// Token: 0x04008C12 RID: 35858
		public ushort SizeMaybe2;

		// Token: 0x04008C13 RID: 35859
		public uint myId;

		// Token: 0x04008C14 RID: 35860
		public byte singlezero;

		// Token: 0x04008C15 RID: 35861
		public ulong unkzero2;

		// Token: 0x04008C16 RID: 35862
		public uint traderId;

		// Token: 0x04008C17 RID: 35863
		public byte singlezero2;

		// Token: 0x04008C18 RID: 35864
		public uint unkzero3;

		// Token: 0x0200135B RID: 4955
		public enum TradeTypes
		{
			// Token: 0x04009E58 RID: 40536
			RequestTrade = 1,
			// Token: 0x04009E59 RID: 40537
			CancelTrade,
			// Token: 0x04009E5A RID: 40538
			AgreeTrade
		}
	}
}
