using System;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AA4 RID: 2724
	public class AuthInfoS2C : Packet
	{
		// Token: 0x04009014 RID: 36884
		public byte FF = byte.MaxValue;

		// Token: 0x04009015 RID: 36885
		public BattleNetPacket PacketId;

		// Token: 0x04009016 RID: 36886
		public ushort Length;

		// Token: 0x04009017 RID: 36887
		public AuthInfoS2C.LogonTypes LogonType;

		// Token: 0x04009018 RID: 36888
		public uint ServerToken;

		// Token: 0x04009019 RID: 36889
		public uint UdpValue;

		// Token: 0x0400901A RID: 36890
		public ulong MpqFileTime;

		// Token: 0x0400901B RID: 36891
		public string MpqFileName;

		// Token: 0x0400901C RID: 36892
		public string FormulaString;

		// Token: 0x0200138B RID: 5003
		public enum LogonTypes : uint
		{
			// Token: 0x04009F3E RID: 40766
			BrokenSha1,
			// Token: 0x04009F3F RID: 40767
			NlsVersion1,
			// Token: 0x04009F40 RID: 40768
			NlsVersion2
		}
	}
}
