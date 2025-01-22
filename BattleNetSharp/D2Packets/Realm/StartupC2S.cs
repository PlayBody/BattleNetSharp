using System;
using System.Collections.Generic;
using D2Packets.BattleNet;

namespace D2Packets.Realm
{
	// Token: 0x02000A9D RID: 2717
	public class StartupC2S : Packet
	{
		// Token: 0x0600BBE0 RID: 48096 RVA: 0x00473A06 File Offset: 0x00471C06
		public StartupC2S()
		{
		}

		// Token: 0x0600BBE1 RID: 48097 RVA: 0x00473A3C File Offset: 0x00471C3C
		public StartupC2S(RealmLogonS2C info)
		{
			this.HashString = info.HashString;
			this.HashString2 = info.HashString2;
		}

		// Token: 0x04008FDF RID: 36831
		public ushort Length;

		// Token: 0x04008FE0 RID: 36832
		public RealmPacket PacketId;

		// Token: 0x04008FE1 RID: 36833
		public List<byte> HashString = new List<byte>(16);

		// Token: 0x04008FE2 RID: 36834
		public List<byte> HashString2 = new List<byte>(40);

		// Token: 0x04008FE3 RID: 36835
		public byte EndOfString = 0;

		// Token: 0x04008FE4 RID: 36836
		public ulong End = 0UL;
	}
}
