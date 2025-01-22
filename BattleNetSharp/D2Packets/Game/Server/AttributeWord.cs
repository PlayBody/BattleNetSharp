using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009A7 RID: 2471
	public class AttributeWord : Attribute
	{
		// Token: 0x0600BAB2 RID: 47794 RVA: 0x0046CBE4 File Offset: 0x0046ADE4
		public override uint GetRawValue()
		{
			return (uint)this.Value;
		}

		// Token: 0x0600BAB3 RID: 47795 RVA: 0x0046CBFC File Offset: 0x0046ADFC
		public override void FromBytes(byte[] bytes)
		{
			this.Attrib = bytes[1];
			this.Value = BitConverter.ToUInt16(bytes, (base.PacketVersion == GameVersion.D2R) ? 3 : 2);
			base.Stat = BaseStat.Get((int)this.Attrib);
			ushort num = this.Value;
			bool flag = base.Stat.ValShift > 0;
			if (flag)
			{
				num = (ushort)(num >> base.Stat.ValShift);
			}
			bool signed = base.Stat.Signed;
			if (signed)
			{
				base.StatValue = new SignedStat(base.Stat, (int)num);
			}
			else
			{
				base.StatValue = new UnsignedStat(base.Stat, (uint)num);
			}
		}

		// Token: 0x04008964 RID: 35172
		public byte Attrib;

		// Token: 0x04008965 RID: 35173
		[MinVersion(GameVersion.D2R)]
		public byte pad;

		// Token: 0x04008966 RID: 35174
		public ushort Value;

		// Token: 0x04008967 RID: 35175
		[MinVersion(GameVersion.D2R)]
		public ushort pad2;
	}
}
