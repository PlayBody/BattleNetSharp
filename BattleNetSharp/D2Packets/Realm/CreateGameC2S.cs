using System;
using System.Globalization;

namespace D2Packets.Realm
{
	// Token: 0x02000A8E RID: 2702
	public class CreateGameC2S : Packet
	{
		// Token: 0x0600BBD0 RID: 48080 RVA: 0x00473895 File Offset: 0x00471A95
		public CreateGameC2S()
		{
		}

		// Token: 0x0600BBD1 RID: 48081 RVA: 0x004738C4 File Offset: 0x00471AC4
		public CreateGameC2S(string name, string password, string desc, CreateGameC2S.Difficulty diff)
		{
			this.Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name);
			this.Password = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(password);
			this.Description = desc;
			this.Mode = (uint)diff;
		}

		// Token: 0x04008F86 RID: 36742
		public ushort Length;

		// Token: 0x04008F87 RID: 36743
		public RealmPacket PacketId;

		// Token: 0x04008F88 RID: 36744
		public ushort Count = 2;

		// Token: 0x04008F89 RID: 36745
		public uint Mode = 0U;

		// Token: 0x04008F8A RID: 36746
		public byte One = 1;

		// Token: 0x04008F8B RID: 36747
		public byte Difference = 99;

		// Token: 0x04008F8C RID: 36748
		public byte MaxPlayers = 8;

		// Token: 0x04008F8D RID: 36749
		public string Name;

		// Token: 0x04008F8E RID: 36750
		public string Password;

		// Token: 0x04008F8F RID: 36751
		public string Description;

		// Token: 0x02001385 RID: 4997
		public enum Difficulty : uint
		{
			// Token: 0x04009F10 RID: 40720
			Normal,
			// Token: 0x04009F11 RID: 40721
			Nightmare = 4096U,
			// Token: 0x04009F12 RID: 40722
			Hell = 8192U
		}
	}
}
