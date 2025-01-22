using System;

namespace WoW.Packets
{
	// Token: 0x02000817 RID: 2071
	public class ConnectToFailed : ClientPacket
	{
		// Token: 0x0600B548 RID: 46408 RVA: 0x002C3502 File Offset: 0x002C1702
		private void test()
		{
			this.Con -= 1;
		}

		// Token: 0x04005AC5 RID: 23237
		public uint Serial;

		// Token: 0x04005AC6 RID: 23238
		private byte Con;
	}
}
