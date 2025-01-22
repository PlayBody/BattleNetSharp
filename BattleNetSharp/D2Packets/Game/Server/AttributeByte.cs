using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009A5 RID: 2469
	public class AttributeByte : Attribute
	{
		// Token: 0x1700391A RID: 14618
		// (get) Token: 0x0600BAAA RID: 47786 RVA: 0x0046CA56 File Offset: 0x0046AC56
		// (set) Token: 0x0600BAAB RID: 47787 RVA: 0x0046CA5E File Offset: 0x0046AC5E
		public uint Attrib { get; set; }

		// Token: 0x0600BAAC RID: 47788 RVA: 0x0046CA68 File Offset: 0x0046AC68
		public override uint GetRawValue()
		{
			return (uint)this.Value;
		}

		// Token: 0x0600BAAD RID: 47789 RVA: 0x0046CA80 File Offset: 0x0046AC80
		public override void FromBytes(byte[] bytes)
		{
			this.AttribD2R = (uint)(this.AttribLOD = bytes[(base.PacketVersion == GameVersion.D2R) ? 2 : 1]);
			base.Stat = BaseStat.Get((int)this.AttribLOD);
			this.Value = bytes[(base.PacketVersion == GameVersion.D2R) ? 1 : 2];
			bool signed = base.Stat.Signed;
			if (signed)
			{
				base.StatValue = new SignedStat(base.Stat, (int)this.Value);
			}
			else
			{
				base.StatValue = new UnsignedStat(base.Stat, (uint)this.Value);
			}
		}

		// Token: 0x0400895C RID: 35164
		[MaxVersion(GameVersion.LOD)]
		public byte AttribLOD;

		// Token: 0x0400895D RID: 35165
		public byte Value;

		// Token: 0x0400895E RID: 35166
		[MinVersion(GameVersion.D2R)]
		public uint AttribD2R;
	}
}
