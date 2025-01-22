using System;
using System.Linq;

namespace PacketDotNet
{
	// Token: 0x0200082C RID: 2092
	public class TlsRandom
	{
		// Token: 0x0600B575 RID: 46453 RVA: 0x002C3CF3 File Offset: 0x002C1EF3
		public TlsRandom(byte[] bytes)
		{
			this.Bytes = bytes;
		}

		// Token: 0x170037DE RID: 14302
		// (get) Token: 0x0600B576 RID: 46454 RVA: 0x002C3D04 File Offset: 0x002C1F04
		public byte[] RandomBytes
		{
			get
			{
				return this.Bytes.Take(32).ToArray<byte>();
			}
		}

		// Token: 0x04005B4B RID: 23371
		public byte[] Bytes;
	}
}
