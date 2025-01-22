using System;
using System.IO;
using Utilities;

namespace D2Packets.Game.Server
{
	// Token: 0x020009E7 RID: 2535
	public class PlayerLifeManaChangeRegen : Packet
	{
		// Token: 0x0600BB10 RID: 47888 RVA: 0x00471F58 File Offset: 0x00470158
		public override void FromBytes(byte[] Bytes)
		{
			BitReader bitReader = new BitReader(Bytes, 0);
			this.PacketId = (GameServerPacket)bitReader.ReadByte();
			this.Life = (ushort)bitReader.ReadBits(15);
			this.Mana = (ushort)bitReader.ReadBits(15);
			this.Stamina = (ushort)bitReader.ReadBits(15);
			this.LifeRegen = (byte)bitReader.ReadBits(7);
			this.ManaRegen = (byte)bitReader.ReadBits(7);
			this.X = bitReader.ReadUInt16();
			this.Y = bitReader.ReadUInt16();
			this.dX = bitReader.ReadByte();
			this.dY = bitReader.ReadByte();
		}

		// Token: 0x0600BB11 RID: 47889 RVA: 0x00471FF4 File Offset: 0x004701F4
		public override byte[] ToArray()
		{
			this.memoryStream = new MemoryStream();
			BitWriter bitWriter = new BitWriter(this.memoryStream);
			bitWriter.WriteBits(24U, 8);
			bitWriter.WriteBits((uint)this.Life, 15);
			bitWriter.WriteBits((uint)this.Mana, 15);
			bitWriter.WriteBits((uint)this.Stamina, 15);
			bitWriter.WriteBits((uint)this.LifeRegen, 7);
			bitWriter.WriteBits((uint)this.ManaRegen, 7);
			bitWriter.WriteBits((uint)this.X, 16);
			bitWriter.WriteBits((uint)this.Y, 16);
			bitWriter.WriteBits((uint)this.dX, 8);
			bitWriter.WriteBits((uint)this.dY, 8);
			bitWriter.Flush();
			return this.memoryStream.ToArray();
		}

		// Token: 0x04008B5B RID: 35675
		public GameServerPacket PacketId;

		// Token: 0x04008B5C RID: 35676
		public ushort Life;

		// Token: 0x04008B5D RID: 35677
		public ushort Mana;

		// Token: 0x04008B5E RID: 35678
		public ushort Stamina;

		// Token: 0x04008B5F RID: 35679
		public byte LifeRegen;

		// Token: 0x04008B60 RID: 35680
		public byte ManaRegen;

		// Token: 0x04008B61 RID: 35681
		public ushort X;

		// Token: 0x04008B62 RID: 35682
		public ushort Y;

		// Token: 0x04008B63 RID: 35683
		public byte dX;

		// Token: 0x04008B64 RID: 35684
		public byte dY;
	}
}
