using System;
using System.IO;
using Utilities;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A78 RID: 2680
	public class TradeConfirm : Packet
	{
		// Token: 0x0600BBB6 RID: 48054 RVA: 0x00473308 File Offset: 0x00471508
		public override byte[] ToArray()
		{
			this.memoryStream = new MemoryStream();
			BitWriter bitWriter = new BitWriter(this.memoryStream);
			bitWriter.WriteBits(44U, 8);
			bitWriter.WriteBits(255U, 16);
			bitWriter.WriteBits(this.Guid, 32);
			bitWriter.WriteBits(this.ActionCount, 32);
			bitWriter.WriteBits((uint)this.Action, 3);
			bitWriter.WriteBits((this.ItemId > 0U) ? 1U : 0U, 12);
			bool flag = this.ItemId > 0U;
			if (flag)
			{
				bitWriter.WriteBits(this.ItemId, 32);
				bitWriter.WriteBits(16U, 17);
			}
			else
			{
				bitWriter.WriteBits(0U, 8);
			}
			return this.memoryStream.ToArray();
		}

		// Token: 0x04008F15 RID: 36629
		public GameClientPacket PacketId;

		// Token: 0x04008F16 RID: 36630
		public ushort Lenth;

		// Token: 0x04008F17 RID: 36631
		public uint Guid;

		// Token: 0x04008F18 RID: 36632
		public uint ActionCount;

		// Token: 0x04008F19 RID: 36633
		public ushort Action;

		// Token: 0x04008F1A RID: 36634
		public uint ItemId;
	}
}
