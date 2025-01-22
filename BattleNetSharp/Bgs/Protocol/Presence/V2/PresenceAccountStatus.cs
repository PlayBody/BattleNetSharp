using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V2
{
	// Token: 0x020005B9 RID: 1465
	public enum PresenceAccountStatus
	{
		// Token: 0x04003EDE RID: 16094
		[OriginalName("OFFLINE")]
		Offline,
		// Token: 0x04003EDF RID: 16095
		[OriginalName("ONLINE")]
		Online,
		// Token: 0x04003EE0 RID: 16096
		[OriginalName("AWAY")]
		Away,
		// Token: 0x04003EE1 RID: 16097
		[OriginalName("DND")]
		Dnd
	}
}
