using System;

namespace D4Packets
{
	// Token: 0x0200083A RID: 2106
	[AttributeUsage(AttributeTargets.All)]
	public class FixedLen : Attribute
	{
		// Token: 0x0600B582 RID: 46466 RVA: 0x002C3E6F File Offset: 0x002C206F
		public FixedLen(uint f)
		{
			this.len = f;
		}

		// Token: 0x04006276 RID: 25206
		public uint len;
	}
}
