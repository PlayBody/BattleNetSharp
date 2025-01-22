using System;
using System.Linq;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x02000A17 RID: 2583
	public class UpdateItemStats : Packet
	{
		// Token: 0x0600BB4B RID: 47947 RVA: 0x0047288C File Offset: 0x00470A8C
		public override byte[] ToArray()
		{
			int num;
			bool packetSize = GameServerPacketSizes.GetPacketSize(this.origBytes.ToList<byte>(), out num, base.PacketVersion == GameVersion.D2R);
			return this.origBytes.Take(num).ToArray<byte>();
		}

		// Token: 0x0600BB4C RID: 47948 RVA: 0x004728CB File Offset: 0x00470ACB
		public override void FromBytes(byte[] Bytes)
		{
			this.origBytes = Bytes;
		}

		// Token: 0x04008C5B RID: 35931
		public GameServerPacket PacketId;

		// Token: 0x04008C5C RID: 35932
		public byte Length;

		// Token: 0x04008C5D RID: 35933
		public uint Id;

		// Token: 0x04008C5E RID: 35934
		public StatBase stat;

		// Token: 0x04008C5F RID: 35935
		public byte[] origBytes;
	}
}
