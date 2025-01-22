using System;
using System.Collections.Generic;

namespace D2Packets
{
	// Token: 0x02000992 RID: 2450
	public class FtpFileResponse : Packet
	{
		// Token: 0x0600BA76 RID: 47734 RVA: 0x0046A054 File Offset: 0x00468254
		public FtpFileResponse(string name)
		{
			this.FileName = name;
		}

		// Token: 0x040088EF RID: 35055
		public uint head = 42U;

		// Token: 0x040088F0 RID: 35056
		public uint filesize = 168704U;

		// Token: 0x040088F1 RID: 35057
		public uint file = 0U;

		// Token: 0x040088F2 RID: 35058
		public uint start = 0U;

		// Token: 0x040088F3 RID: 35059
		public ulong FileTime = 132742032600000000UL;

		// Token: 0x040088F4 RID: 35060
		public string FileName;

		// Token: 0x040088F5 RID: 35061
		public List<byte> FileBytes = new List<byte>();
	}
}
