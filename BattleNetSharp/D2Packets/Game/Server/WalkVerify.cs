using System;
using System.IO;
using Utilities;

namespace D2Packets.Game.Server
{
	// Token: 0x02000A20 RID: 2592
	public class WalkVerify : Packet
	{
		// Token: 0x0600BB56 RID: 47958 RVA: 0x00472930 File Offset: 0x00470B30
		public override void FromBytes(byte[] Bytes)
		{
			BitReader bitReader = new BitReader(Bytes, 0);
			this.PacketId = (GameServerPacket)bitReader.ReadByte();
			this.Stamina = (ushort)bitReader.ReadBits(15);
			this.X = bitReader.ReadUInt16();
			this.Y = bitReader.ReadUInt16();
			this.dX = bitReader.ReadByte();
			this.dY = bitReader.ReadByte();
		}

		// Token: 0x0600BB57 RID: 47959 RVA: 0x00472994 File Offset: 0x00470B94
		public override byte[] ToArray()
		{
			this.memoryStream = new MemoryStream();
			BitWriter bitWriter = new BitWriter(this.memoryStream);
			bitWriter.WriteBits(150U, 8);
			bitWriter.WriteBits((uint)this.Stamina, 15);
			bitWriter.WriteBits((uint)this.X, 16);
			bitWriter.WriteBits((uint)this.Y, 16);
			bitWriter.WriteBits((uint)this.dX, 8);
			bitWriter.WriteBits((uint)this.dY, 8);
			bitWriter.Flush();
			return this.memoryStream.ToArray();
		}

		// Token: 0x04008C84 RID: 35972
		public GameServerPacket PacketId;

		// Token: 0x04008C85 RID: 35973
		public ushort Stamina;

		// Token: 0x04008C86 RID: 35974
		public ushort X;

		// Token: 0x04008C87 RID: 35975
		public ushort Y;

		// Token: 0x04008C88 RID: 35976
		public byte dX;

		// Token: 0x04008C89 RID: 35977
		public byte dY;
	}
}
