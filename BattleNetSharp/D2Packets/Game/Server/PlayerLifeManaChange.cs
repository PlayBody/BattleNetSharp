using System;
using System.IO;
using Utilities;

namespace D2Packets.Game.Server
{
	// Token: 0x020009E6 RID: 2534
	public class PlayerLifeManaChange : Packet
	{
		// Token: 0x0600BB0D RID: 47885 RVA: 0x00471E08 File Offset: 0x00470008
		public override void FromBytes(byte[] Bytes)
		{
			BitReader bitReader = new BitReader(Bytes, 0);
			this.PacketId = (GameServerPacket)bitReader.ReadByte();
			this.Life = (ushort)bitReader.ReadBits(15);
			this.Mana = (ushort)bitReader.ReadBits(15);
			this.Stamina = (ushort)bitReader.ReadBits(15);
			this.X = bitReader.ReadUInt16();
			this.Y = bitReader.ReadUInt16();
			this.dX = bitReader.ReadByte();
			this.dY = bitReader.ReadByte();
		}

		// Token: 0x0600BB0E RID: 47886 RVA: 0x00471E88 File Offset: 0x00470088
		public override byte[] ToArray()
		{
			this.memoryStream = new MemoryStream();
			BitWriter bitWriter = new BitWriter(this.memoryStream);
			bitWriter.WriteBits(149U, 8);
			bitWriter.WriteBits((uint)this.Life, 15);
			bitWriter.WriteBits((uint)this.Mana, 15);
			bitWriter.WriteBits((uint)this.Stamina, 15);
			bitWriter.WriteBits((uint)this.X, 16);
			bitWriter.WriteBits((uint)this.Y, 16);
			bitWriter.WriteBits((uint)this.dX, 8);
			bitWriter.WriteBits((uint)this.dY, 8);
			bool flag = base.PacketVersion == GameVersion.D2R;
			if (flag)
			{
				bitWriter.WriteBits(0U, 32);
			}
			bitWriter.Flush();
			return this.memoryStream.ToArray();
		}

		// Token: 0x04008B52 RID: 35666
		public GameServerPacket PacketId;

		// Token: 0x04008B53 RID: 35667
		public ushort Life;

		// Token: 0x04008B54 RID: 35668
		public ushort Mana;

		// Token: 0x04008B55 RID: 35669
		public ushort Stamina;

		// Token: 0x04008B56 RID: 35670
		public ushort X;

		// Token: 0x04008B57 RID: 35671
		public ushort Y;

		// Token: 0x04008B58 RID: 35672
		public byte dX;

		// Token: 0x04008B59 RID: 35673
		public byte dY;

		// Token: 0x04008B5A RID: 35674
		[MinVersion(GameVersion.D2R)]
		public uint unk6;
	}
}
