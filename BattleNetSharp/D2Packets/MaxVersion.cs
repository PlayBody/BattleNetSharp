using System;

namespace D2Packets
{
	// Token: 0x02000995 RID: 2453
	[AttributeUsage(AttributeTargets.All)]
	public class MaxVersion : Attribute
	{
		// Token: 0x0600BA78 RID: 47736 RVA: 0x0046A0BC File Offset: 0x004682BC
		public MaxVersion(GameVersion version)
		{
			this.Version = version;
		}

		// Token: 0x040088FB RID: 35067
		public readonly GameVersion Version;
	}
}
