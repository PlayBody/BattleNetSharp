using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using D2Data;
using Utilities;

namespace D2Packets.Game.Server
{
	// Token: 0x0200099D RID: 2461
	public class AssignPlayer : Packet
	{
		// Token: 0x17003916 RID: 14614
		// (get) Token: 0x0600BA9A RID: 47770 RVA: 0x0046C90C File Offset: 0x0046AB0C
		// (set) Token: 0x0600BA9B RID: 47771 RVA: 0x0046C95C File Offset: 0x0046AB5C
		public string Name
		{
			get
			{
				List<byte> list = BitConverter.GetBytes(this.Name1).ToList<byte>();
				list.AddRange(BitConverter.GetBytes(this.Name2).ToList<byte>());
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
				this.Name1 = BitConverter.ToUInt64(list.ToArray(), 0);
				this.Name2 = BitConverter.ToUInt64(list.ToArray(), 8);
			}
		}

		// Token: 0x0400892E RID: 35118
		public GameServerPacket PacketId;

		// Token: 0x0400892F RID: 35119
		public uint Id;

		// Token: 0x04008930 RID: 35120
		public CharacterClass Class;

		// Token: 0x04008931 RID: 35121
		public ulong Name1;

		// Token: 0x04008932 RID: 35122
		public ulong Name2;

		// Token: 0x04008933 RID: 35123
		[MinVersion(GameVersion.D2R)]
		public ulong unk1;

		// Token: 0x04008934 RID: 35124
		[MinVersion(GameVersion.D2R)]
		public ulong unk2;

		// Token: 0x04008935 RID: 35125
		[MinVersion(GameVersion.D2R)]
		public ulong unk3;

		// Token: 0x04008936 RID: 35126
		[MinVersion(GameVersion.D2R)]
		public ulong unk4;

		// Token: 0x04008937 RID: 35127
		[MinVersion(GameVersion.D2R)]
		public ulong unk5;

		// Token: 0x04008938 RID: 35128
		[MinVersion(GameVersion.D2R)]
		public uint unk6;

		// Token: 0x04008939 RID: 35129
		[MinVersion(GameVersion.D2R)]
		public byte unk7;

		// Token: 0x0400893A RID: 35130
		public ushort X;

		// Token: 0x0400893B RID: 35131
		public ushort Y;
	}
}
