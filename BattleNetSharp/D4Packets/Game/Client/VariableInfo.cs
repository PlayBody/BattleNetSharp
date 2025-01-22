using System;

namespace D4Packets.Game.Client
{
	// Token: 0x02000898 RID: 2200
	public class VariableInfo : D4Packet
	{
		// Token: 0x04006486 RID: 25734
		public int Field0;

		// Token: 0x04006487 RID: 25735
		[DynamicLen(8)]
		public int[] Field1;

		// Token: 0x04006488 RID: 25736
		[DynamicLen(8)]
		public DesignerVariableInfo[] Field2;
	}
}
