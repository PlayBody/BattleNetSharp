using System;

namespace WoW.Packets
{
	// Token: 0x02000818 RID: 2072
	public class EnterEncryptedMode : ServerPacket
	{
		// Token: 0x0600B54A RID: 46410 RVA: 0x002C351D File Offset: 0x002C171D
		private void test()
		{
			this.Enabled = !this.Enabled;
			this.EncryptionKey = new byte[0];
		}

		// Token: 0x04005AC7 RID: 23239
		private byte[] EncryptionKey;

		// Token: 0x04005AC8 RID: 23240
		private bool Enabled;

		// Token: 0x04005AC9 RID: 23241
		private static byte[] EnableEncryptionSeed = new byte[]
		{
			144, 156, 208, 80, 90, 44, 20, 221, 92, 44,
			192, 100, 20, 243, 254, 201
		};
	}
}
