using System;
using System.IO;
using Utilities;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A77 RID: 2679
	public class Trade : Packet
	{
		// Token: 0x0600BBB3 RID: 48051 RVA: 0x004731AC File Offset: 0x004713AC
		public override void FromBytes(byte[] Bytes)
		{
			BitReader bitReader = new BitReader(Bytes, 0);
			this.PacketId = (GameClientPacket)bitReader.ReadByte();
			this.Length = bitReader.ReadUInt16();
			this.Guid = bitReader.ReadUInt32();
			this.Zero = bitReader.ReadUInt32();
			this.TargetId = bitReader.ReadUInt32();
		}

		// Token: 0x0600BBB4 RID: 48052 RVA: 0x00473200 File Offset: 0x00471400
		public override byte[] ToArray()
		{
			this.memoryStream = new MemoryStream();
			BitWriter bitWriter = new BitWriter(this.memoryStream);
			bitWriter.WriteBits(43U, 8);
			bool flag = this.ItemId > 0U;
			if (flag)
			{
				bitWriter.WriteBits(19U, 16);
			}
			else
			{
				bitWriter.WriteBits(13U, 16);
			}
			bitWriter.WriteBits(this.Guid, 32);
			bitWriter.WriteBits(this.Zero, 32);
			bitWriter.WriteBits(this.TargetId, 32);
			bool flag2 = this.ItemId > 0U;
			if (flag2)
			{
				bitWriter.WriteBits(1U, 6);
				bitWriter.WriteBits(this.ItemId, 32);
				bitWriter.WriteBits(0U, 2);
				bitWriter.WriteBits(4U, 4);
				bitWriter.WriteBits((uint)this.X, 4);
				bitWriter.WriteBits((uint)this.Y, 4);
				bitWriter.WriteBits(0U, 4);
			}
			else
			{
				bitWriter.WriteBits(0U, 8);
			}
			return this.memoryStream.ToArray();
		}

		// Token: 0x04008F0C RID: 36620
		public GameClientPacket PacketId;

		// Token: 0x04008F0D RID: 36621
		public ushort Length;

		// Token: 0x04008F0E RID: 36622
		public uint Guid;

		// Token: 0x04008F0F RID: 36623
		public uint Zero;

		// Token: 0x04008F10 RID: 36624
		public uint TargetId;

		// Token: 0x04008F11 RID: 36625
		public bool num;

		// Token: 0x04008F12 RID: 36626
		public uint ItemId;

		// Token: 0x04008F13 RID: 36627
		public ushort X;

		// Token: 0x04008F14 RID: 36628
		public ushort Y;
	}
}
