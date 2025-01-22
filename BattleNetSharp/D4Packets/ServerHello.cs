using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using D2Data;
using D2Packets;
using Utilities;

namespace D4Packets
{
	// Token: 0x02000838 RID: 2104
	public class ServerHello
	{
		// Token: 0x170037DF RID: 14303
		// (get) Token: 0x0600B57E RID: 46462 RVA: 0x002C3DA0 File Offset: 0x002C1FA0
		// (set) Token: 0x0600B57F RID: 46463 RVA: 0x002C3DF0 File Offset: 0x002C1FF0
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

		// Token: 0x04006268 RID: 25192
		public uint Id;

		// Token: 0x04006269 RID: 25193
		public CharacterClass Class;

		// Token: 0x0400626A RID: 25194
		public ulong Name1;

		// Token: 0x0400626B RID: 25195
		public ulong Name2;

		// Token: 0x0400626C RID: 25196
		[MinVersion(GameVersion.D2R)]
		public ulong unk1;

		// Token: 0x0400626D RID: 25197
		[MinVersion(GameVersion.D2R)]
		public ulong unk2;

		// Token: 0x0400626E RID: 25198
		[MinVersion(GameVersion.D2R)]
		public ulong unk3;

		// Token: 0x0400626F RID: 25199
		[MinVersion(GameVersion.D2R)]
		public ulong unk4;

		// Token: 0x04006270 RID: 25200
		[MinVersion(GameVersion.D2R)]
		public ulong unk5;

		// Token: 0x04006271 RID: 25201
		[MinVersion(GameVersion.D2R)]
		public uint unk6;

		// Token: 0x04006272 RID: 25202
		[MinVersion(GameVersion.D2R)]
		public byte unk7;

		// Token: 0x04006273 RID: 25203
		public ushort X;

		// Token: 0x04006274 RID: 25204
		public ushort Y;
	}
}
