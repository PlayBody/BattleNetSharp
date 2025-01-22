using System;
using D2Packets;

namespace WoW.Packets
{
	// Token: 0x0200081B RID: 2075
	public class VirtualRealmInfo : Packet
	{
		// Token: 0x04005AD1 RID: 23249
		public uint RealmAddress;

		// Token: 0x04005AD2 RID: 23250
		public VirtualRealmNameInfo RealmNameInfo;
	}
}
