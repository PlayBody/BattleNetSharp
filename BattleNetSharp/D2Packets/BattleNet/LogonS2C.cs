using System;

namespace D2Packets.BattleNet
{
	// Token: 0x02000ABB RID: 2747
	public class LogonS2C : Packet
	{
		// Token: 0x040090A9 RID: 37033
		public byte FF = byte.MaxValue;

		// Token: 0x040090AA RID: 37034
		public BattleNetPacket PacketId;

		// Token: 0x040090AB RID: 37035
		public ushort Length;

		// Token: 0x040090AC RID: 37036
		public LogonS2C.LogonStatus Status;

		// Token: 0x02001391 RID: 5009
		public enum LogonStatus : uint
		{
			// Token: 0x04009F6A RID: 40810
			Success,
			// Token: 0x04009F6B RID: 40811
			NoAccount,
			// Token: 0x04009F6C RID: 40812
			WrongPass,
			// Token: 0x04009F6D RID: 40813
			Closed = 6U
		}
	}
}
