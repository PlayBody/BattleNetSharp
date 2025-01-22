using System;
using System.Runtime.InteropServices;

namespace D4Data
{
	// Token: 0x020008CC RID: 2252
	[StructLayout(LayoutKind.Explicit)]
	public struct GameAttributeValue
	{
		// Token: 0x0600B639 RID: 46649 RVA: 0x002C80AB File Offset: 0x002C62AB
		public GameAttributeValue(int value)
		{
			this.ValueF = 0f;
			this.Value = value;
		}

		// Token: 0x0600B63A RID: 46650 RVA: 0x002C80C0 File Offset: 0x002C62C0
		public GameAttributeValue(float value)
		{
			this.Value = 0;
			this.ValueF = value;
		}

		// Token: 0x04006548 RID: 25928
		[FieldOffset(0)]
		public int Value;

		// Token: 0x04006549 RID: 25929
		[FieldOffset(0)]
		public float ValueF;
	}
}
