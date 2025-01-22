using System;
using System.Collections.Generic;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AC4 RID: 2756
	public class RealmLogonS2C : Packet
	{
		// Token: 0x040090D7 RID: 37079
		public byte FF = byte.MaxValue;

		// Token: 0x040090D8 RID: 37080
		public BattleNetPacket PacketId;

		// Token: 0x040090D9 RID: 37081
		public ushort Length;

		// Token: 0x040090DA RID: 37082
		public List<byte> HashString = new List<byte>(16);

		// Token: 0x040090DB RID: 37083
		public uint RealmIpAddr;

		// Token: 0x040090DC RID: 37084
		public uint RealmPort;

		// Token: 0x040090DD RID: 37085
		public List<byte> HashString2 = new List<byte>(40);

		// Token: 0x040090DE RID: 37086
		public byte EndOfString = 0;

		// Token: 0x040090DF RID: 37087
		public ulong End = 0UL;
	}
}
