using System;
using System.Globalization;

namespace D2Packets.Realm
{
	// Token: 0x02000A98 RID: 2712
	public class JoinGameC2S : Packet
	{
		// Token: 0x0600BBDB RID: 48091 RVA: 0x004739AA File Offset: 0x00471BAA
		public JoinGameC2S()
		{
		}

		// Token: 0x0600BBDC RID: 48092 RVA: 0x004739B4 File Offset: 0x00471BB4
		public JoinGameC2S(string name, string password)
		{
			this.Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name);
			this.Password = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(password);
		}

		// Token: 0x04008FBD RID: 36797
		public ushort Length;

		// Token: 0x04008FBE RID: 36798
		public RealmPacket PacketId;

		// Token: 0x04008FBF RID: 36799
		public ushort Id;

		// Token: 0x04008FC0 RID: 36800
		public string Name;

		// Token: 0x04008FC1 RID: 36801
		public string Password;
	}
}
