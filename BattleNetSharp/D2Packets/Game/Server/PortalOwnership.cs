using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009F1 RID: 2545
	public class PortalOwnership : Packet
	{
		// Token: 0x1700391E RID: 14622
		// (get) Token: 0x0600BB1C RID: 47900 RVA: 0x00472118 File Offset: 0x00470318
		public string Name
		{
			get
			{
				List<byte> list = BitConverter.GetBytes(this.Name1).ToList<byte>();
				list.AddRange(BitConverter.GetBytes(this.Name2).ToList<byte>());
				return Encoding.ASCII.GetString(list.ToArray());
			}
		}

		// Token: 0x04008B9A RID: 35738
		public GameServerPacket PacketId;

		// Token: 0x04008B9B RID: 35739
		public uint OwnerId;

		// Token: 0x04008B9C RID: 35740
		public ulong Name1;

		// Token: 0x04008B9D RID: 35741
		public ulong Name2;

		// Token: 0x04008B9E RID: 35742
		[MinVersion(GameVersion.D2R)]
		public ulong unk1;

		// Token: 0x04008B9F RID: 35743
		[MinVersion(GameVersion.D2R)]
		public ulong unk22;

		// Token: 0x04008BA0 RID: 35744
		[MinVersion(GameVersion.D2R)]
		public ulong unk3;

		// Token: 0x04008BA1 RID: 35745
		[MinVersion(GameVersion.D2R)]
		public ulong unk4;

		// Token: 0x04008BA2 RID: 35746
		[MinVersion(GameVersion.D2R)]
		public ulong unk5;

		// Token: 0x04008BA3 RID: 35747
		[MinVersion(GameVersion.D2R)]
		public uint unk6;

		// Token: 0x04008BA4 RID: 35748
		[MinVersion(GameVersion.D2R)]
		public byte unk7;

		// Token: 0x04008BA5 RID: 35749
		public uint LocalId;

		// Token: 0x04008BA6 RID: 35750
		[MinVersion(GameVersion.D2R)]
		public AreaLevel Destination2;

		// Token: 0x04008BA7 RID: 35751
		[MinVersion(GameVersion.D2R)]
		public uint unk2;

		// Token: 0x04008BA8 RID: 35752
		public uint RemoteId;
	}
}
