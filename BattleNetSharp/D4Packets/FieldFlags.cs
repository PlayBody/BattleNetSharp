using System;

namespace D4Packets
{
	// Token: 0x02000839 RID: 2105
	[AttributeUsage(AttributeTargets.All)]
	public class FieldFlags : Attribute
	{
		// Token: 0x0600B581 RID: 46465 RVA: 0x002C3E5E File Offset: 0x002C205E
		public FieldFlags(int f)
		{
			this.flags = f;
		}

		// Token: 0x04006275 RID: 25205
		public int flags;
	}
}
