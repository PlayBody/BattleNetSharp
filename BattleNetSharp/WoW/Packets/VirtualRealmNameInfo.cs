using System;

namespace WoW.Packets
{
	// Token: 0x0200081A RID: 2074
	public struct VirtualRealmNameInfo
	{
		// Token: 0x04005ACD RID: 23245
		public bool IsLocal;

		// Token: 0x04005ACE RID: 23246
		public bool IsInternalRealm;

		// Token: 0x04005ACF RID: 23247
		public string RealmNameActual;

		// Token: 0x04005AD0 RID: 23248
		public string RealmNameNormalized;
	}
}
