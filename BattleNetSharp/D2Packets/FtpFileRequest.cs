using System;
using D2Packets.BattleNet;

namespace D2Packets
{
	// Token: 0x02000991 RID: 2449
	public class FtpFileRequest : Packet
	{
		// Token: 0x0600BA74 RID: 47732 RVA: 0x00469FA4 File Offset: 0x004681A4
		public FtpFileRequest(string name)
		{
			this.FileName = name;
		}

		// Token: 0x0600BA75 RID: 47733 RVA: 0x0046A000 File Offset: 0x00468200
		public FtpFileRequest()
		{
		}

		// Token: 0x040088E6 RID: 35046
		public ushort Length;

		// Token: 0x040088E7 RID: 35047
		public ushort FtpVersion = 256;

		// Token: 0x040088E8 RID: 35048
		public uint Platform = Versioning.Platform;

		// Token: 0x040088E9 RID: 35049
		public uint Product = Versioning.Product;

		// Token: 0x040088EA RID: 35050
		public uint id = 0U;

		// Token: 0x040088EB RID: 35051
		public uint file = 0U;

		// Token: 0x040088EC RID: 35052
		public uint start = 0U;

		// Token: 0x040088ED RID: 35053
		public ulong FileTime = 0UL;

		// Token: 0x040088EE RID: 35054
		public string FileName;
	}
}
