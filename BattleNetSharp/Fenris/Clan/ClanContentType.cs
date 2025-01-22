using System;
using Google.Protobuf.Reflection;

namespace Fenris.Clan
{
	// Token: 0x020002AA RID: 682
	public enum ClanContentType
	{
		// Token: 0x04001FC6 RID: 8134
		[OriginalName("INVALID_TYPE")]
		InvalidType = -1,
		// Token: 0x04001FC7 RID: 8135
		[OriginalName("HERALDRY")]
		Heraldry,
		// Token: 0x04001FC8 RID: 8136
		[OriginalName("MOTD")]
		Motd
	}
}
