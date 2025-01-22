using System;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AA2 RID: 2722
	public class AuthCheckS2C : Packet
	{
		// Token: 0x04009001 RID: 36865
		public byte FF = byte.MaxValue;

		// Token: 0x04009002 RID: 36866
		public BattleNetPacket PacketId;

		// Token: 0x04009003 RID: 36867
		public ushort Length;

		// Token: 0x04009004 RID: 36868
		public AuthCheckS2C.CdKeyCheck Result;

		// Token: 0x04009005 RID: 36869
		public string Info = "";

		// Token: 0x0200138A RID: 5002
		public enum CdKeyCheck : uint
		{
			// Token: 0x04009F35 RID: 40757
			PassedChallenge,
			// Token: 0x04009F36 RID: 40758
			OldVersion = 256U,
			// Token: 0x04009F37 RID: 40759
			InvalidVersion,
			// Token: 0x04009F38 RID: 40760
			DowngradeVersion,
			// Token: 0x04009F39 RID: 40761
			InvalidKey = 512U,
			// Token: 0x04009F3A RID: 40762
			InUse,
			// Token: 0x04009F3B RID: 40763
			Banned,
			// Token: 0x04009F3C RID: 40764
			WrongProduct
		}
	}
}
