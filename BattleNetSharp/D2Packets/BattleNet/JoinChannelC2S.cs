using System;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AB5 RID: 2741
	public class JoinChannelC2S : Packet
	{
		// Token: 0x04009091 RID: 37009
		public byte FF = byte.MaxValue;

		// Token: 0x04009092 RID: 37010
		public BattleNetPacket PacketId;

		// Token: 0x04009093 RID: 37011
		public ushort Length;

		// Token: 0x04009094 RID: 37012
		public uint Flags = 5U;

		// Token: 0x04009095 RID: 37013
		public string Channel = "Diablo II";

		// Token: 0x02001390 RID: 5008
		public enum JoinFlags
		{
			// Token: 0x04009F65 RID: 40805
			IfEmpty,
			// Token: 0x04009F66 RID: 40806
			First,
			// Token: 0x04009F67 RID: 40807
			Forced,
			// Token: 0x04009F68 RID: 40808
			FirstD2 = 5
		}
	}
}
