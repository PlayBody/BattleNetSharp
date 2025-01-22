using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009A6 RID: 2470
	public class AttributeDWord : Attribute
	{
		// Token: 0x0600BAAF RID: 47791 RVA: 0x0046CB20 File Offset: 0x0046AD20
		public override uint GetRawValue()
		{
			return this.Value;
		}

		// Token: 0x0600BAB0 RID: 47792 RVA: 0x0046CB38 File Offset: 0x0046AD38
		public override void FromBytes(byte[] bytes)
		{
			this.Attrib = bytes[1];
			base.Stat = BaseStat.Get((int)this.Attrib);
			this.Value = BitConverter.ToUInt32(bytes, (base.PacketVersion == GameVersion.D2R) ? 5 : 2);
			uint num = this.Value;
			bool flag = base.Stat.ValShift > 0;
			if (flag)
			{
				num >>= base.Stat.ValShift;
			}
			bool signed = base.Stat.Signed;
			if (signed)
			{
				base.StatValue = new SignedStat(base.Stat, (int)num);
			}
			else
			{
				base.StatValue = new UnsignedStat(base.Stat, num);
			}
		}

		// Token: 0x04008960 RID: 35168
		public byte Attrib;

		// Token: 0x04008961 RID: 35169
		[MinVersion(GameVersion.D2R)]
		public byte pad;

		// Token: 0x04008962 RID: 35170
		[MinVersion(GameVersion.D2R)]
		public ushort pad2;

		// Token: 0x04008963 RID: 35171
		public uint Value;
	}
}
