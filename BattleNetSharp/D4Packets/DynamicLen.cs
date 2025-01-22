using System;

namespace D4Packets
{
	// Token: 0x0200083B RID: 2107
	[AttributeUsage(AttributeTargets.All)]
	public class DynamicLen : Attribute
	{
		// Token: 0x0600B583 RID: 46467 RVA: 0x002C3E80 File Offset: 0x002C2080
		public DynamicLen(int f)
		{
			this.len = f;
		}

		// Token: 0x04006277 RID: 25207
		public int len;
	}
}
