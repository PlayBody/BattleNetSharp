using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009A4 RID: 2468
	public class Attribute : Packet
	{
		// Token: 0x17003917 RID: 14615
		// (get) Token: 0x0600BAA3 RID: 47779 RVA: 0x0046CA00 File Offset: 0x0046AC00
		public uint RawValue
		{
			get
			{
				return this.GetRawValue();
			}
		}

		// Token: 0x0600BAA4 RID: 47780 RVA: 0x0046CA18 File Offset: 0x0046AC18
		public virtual uint GetRawValue()
		{
			return 0U;
		}

		// Token: 0x17003918 RID: 14616
		// (get) Token: 0x0600BAA5 RID: 47781 RVA: 0x0046CA2B File Offset: 0x0046AC2B
		// (set) Token: 0x0600BAA6 RID: 47782 RVA: 0x0046CA33 File Offset: 0x0046AC33
		public BaseStat Stat { get; set; }

		// Token: 0x17003919 RID: 14617
		// (get) Token: 0x0600BAA7 RID: 47783 RVA: 0x0046CA3C File Offset: 0x0046AC3C
		// (set) Token: 0x0600BAA8 RID: 47784 RVA: 0x0046CA44 File Offset: 0x0046AC44
		public StatBase StatValue { get; set; }

		// Token: 0x04008959 RID: 35161
		public GameServerPacket PacketId;
	}
}
