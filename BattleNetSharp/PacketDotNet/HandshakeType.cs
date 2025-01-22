using System;

namespace PacketDotNet
{
	// Token: 0x0200082D RID: 2093
	public enum HandshakeType : byte
	{
		// Token: 0x04005B4D RID: 23373
		ClientHello = 1,
		// Token: 0x04005B4E RID: 23374
		ServerHello,
		// Token: 0x04005B4F RID: 23375
		Certificate = 11,
		// Token: 0x04005B50 RID: 23376
		ServerKeyExchange,
		// Token: 0x04005B51 RID: 23377
		ServerHelloDone = 14,
		// Token: 0x04005B52 RID: 23378
		ClientKeyExchange = 16,
		// Token: 0x04005B53 RID: 23379
		Finished = 20
	}
}
