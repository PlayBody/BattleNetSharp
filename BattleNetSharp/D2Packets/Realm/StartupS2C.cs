using System;

namespace D2Packets.Realm
{
	// Token: 0x02000A9E RID: 2718
	public class StartupS2C : Packet
	{
		// Token: 0x04008FE5 RID: 36837
		public ushort Length;

		// Token: 0x04008FE6 RID: 36838
		public RealmPacket PacketId;

		// Token: 0x04008FE7 RID: 36839
		public StartupS2C.LoginResult Result;

		// Token: 0x02001388 RID: 5000
		public enum LoginResult : uint
		{
			// Token: 0x04009F27 RID: 40743
			Success,
			// Token: 0x04009F28 RID: 40744
			RealmUnavailable2 = 2U,
			// Token: 0x04009F29 RID: 40745
			RealmUnavailableA = 10U,
			// Token: 0x04009F2A RID: 40746
			RealmUnavailableB,
			// Token: 0x04009F2B RID: 40747
			RealmUnavailableC,
			// Token: 0x04009F2C RID: 40748
			RealmUnavailableD,
			// Token: 0x04009F2D RID: 40749
			CdKeyBan = 126U,
			// Token: 0x04009F2E RID: 40750
			IpBan
		}
	}
}
