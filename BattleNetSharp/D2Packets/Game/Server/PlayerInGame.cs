using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using D2Data;
using Utilities;

namespace D2Packets.Game.Server
{
	// Token: 0x020009E2 RID: 2530
	public class PlayerInGame : Packet
	{
		// Token: 0x1700391D RID: 14621
		// (get) Token: 0x0600BB07 RID: 47879 RVA: 0x00471BEC File Offset: 0x0046FDEC
		// (set) Token: 0x0600BB08 RID: 47880 RVA: 0x00471CE8 File Offset: 0x0046FEE8
		public string Name
		{
			get
			{
				List<byte> list = BitConverter.GetBytes(this.Name0).ToList<byte>();
				list.AddRange(BitConverter.GetBytes(this.Name8).ToList<byte>());
				bool flag = base.PacketVersion == GameVersion.D2R;
				if (flag)
				{
					list.AddRange(BitConverter.GetBytes(this.Name16).ToList<byte>());
					list.AddRange(BitConverter.GetBytes(this.Name24).ToList<byte>());
					list.AddRange(BitConverter.GetBytes(this.Name32).ToList<byte>());
					list.AddRange(BitConverter.GetBytes(this.Name40).ToList<byte>());
					list.AddRange(BitConverter.GetBytes(this.Name48).ToList<byte>());
					list.AddRange(BitConverter.GetBytes(this.Name56).ToList<byte>());
					list.Add(this.Name60);
				}
				return Encoding.ASCII.GetString(list.ToArray()).TrimString('\0');
			}
			set
			{
				List<byte> list = Encoding.ASCII.GetBytes(value).ToList<byte>();
				int num = 16 - list.Count;
				for (int i = 0; i < num; i++)
				{
					list.Add(0);
				}
				this.Name0 = BitConverter.ToUInt64(list.ToArray(), 0);
				this.Name8 = BitConverter.ToUInt64(list.ToArray(), 8);
				bool flag = base.PacketVersion == GameVersion.D2R;
				if (flag)
				{
					this.Name16 = BitConverter.ToUInt64(list.ToArray(), 16);
					this.Name24 = BitConverter.ToUInt64(list.ToArray(), 24);
					this.Name32 = BitConverter.ToUInt64(list.ToArray(), 32);
					this.Name40 = BitConverter.ToUInt64(list.ToArray(), 40);
					this.Name48 = BitConverter.ToUInt64(list.ToArray(), 48);
					this.Name56 = BitConverter.ToUInt32(list.ToArray(), 56);
					this.Name60 = list[60];
				}
			}
		}

		// Token: 0x04008B34 RID: 35636
		public GameServerPacket PacketId;

		// Token: 0x04008B35 RID: 35637
		public ushort Len;

		// Token: 0x04008B36 RID: 35638
		[MinVersion(GameVersion.D2R)]
		public ulong BnetId;

		// Token: 0x04008B37 RID: 35639
		public uint Id;

		// Token: 0x04008B38 RID: 35640
		public CharacterClass Class;

		// Token: 0x04008B39 RID: 35641
		public ulong Name0;

		// Token: 0x04008B3A RID: 35642
		public ulong Name8;

		// Token: 0x04008B3B RID: 35643
		[MinVersion(GameVersion.D2R)]
		public ulong Name16;

		// Token: 0x04008B3C RID: 35644
		[MinVersion(GameVersion.D2R)]
		public ulong Name24;

		// Token: 0x04008B3D RID: 35645
		[MinVersion(GameVersion.D2R)]
		public ulong Name32;

		// Token: 0x04008B3E RID: 35646
		[MinVersion(GameVersion.D2R)]
		public ulong Name40;

		// Token: 0x04008B3F RID: 35647
		[MinVersion(GameVersion.D2R)]
		public ulong Name48;

		// Token: 0x04008B40 RID: 35648
		[MinVersion(GameVersion.D2R)]
		public uint Name56;

		// Token: 0x04008B41 RID: 35649
		[MinVersion(GameVersion.D2R)]
		public byte Name60;

		// Token: 0x04008B42 RID: 35650
		public ushort Level;

		// Token: 0x04008B43 RID: 35651
		public ushort PartyId;

		// Token: 0x04008B44 RID: 35652
		public ushort unk0;

		// Token: 0x04008B45 RID: 35653
		public ushort InParty;

		// Token: 0x04008B46 RID: 35654
		public ushort GuildFlags;

		// Token: 0x04008B47 RID: 35655
		public byte guildTag;

		// Token: 0x04008B48 RID: 35656
		public byte guildName;

		// Token: 0x04008B49 RID: 35657
		[MinVersion(GameVersion.D2R)]
		public ulong unk1;
	}
}
