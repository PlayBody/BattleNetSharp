using System;

namespace D2Packets
{
	// Token: 0x02000994 RID: 2452
	[AttributeUsage(AttributeTargets.All)]
	public class MinVersion : Attribute
	{
		// Token: 0x0600BA77 RID: 47735 RVA: 0x0046A0AB File Offset: 0x004682AB
		public MinVersion(GameVersion version)
		{
			this.Version = version;
		}

		// Token: 0x040088FA RID: 35066
		public readonly GameVersion Version;
	}
}
