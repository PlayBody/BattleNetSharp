using System;
using System.Linq;
using System.Text;

namespace D2Packets.BattleNet
{
	// Token: 0x02000ACA RID: 2762
	public static class Versioning
	{
		// Token: 0x040090FA RID: 37114
		public static uint PlatformMac = BitConverter.ToUInt32(Encoding.ASCII.GetBytes("XMAC").Reverse<byte>().ToArray<byte>(), 0);

		// Token: 0x040090FB RID: 37115
		public static uint PlatformPowerPC = BitConverter.ToUInt32(Encoding.ASCII.GetBytes("PMAC").Reverse<byte>().ToArray<byte>(), 0);

		// Token: 0x040090FC RID: 37116
		public static uint Platform = BitConverter.ToUInt32(Encoding.ASCII.GetBytes("IX86").Reverse<byte>().ToArray<byte>(), 0);

		// Token: 0x040090FD RID: 37117
		public static uint Product = BitConverter.ToUInt32(Encoding.ASCII.GetBytes("D2XP").Reverse<byte>().ToArray<byte>(), 0);

		// Token: 0x040090FE RID: 37118
		public static uint Version = 14U;
	}
}
