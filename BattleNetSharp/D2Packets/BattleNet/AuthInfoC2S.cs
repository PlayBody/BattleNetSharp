using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AA3 RID: 2723
	public class AuthInfoC2S : Packet
	{
		// Token: 0x04009006 RID: 36870
		public byte FF = byte.MaxValue;

		// Token: 0x04009007 RID: 36871
		public BattleNetPacket PacketId;

		// Token: 0x04009008 RID: 36872
		public ushort Length;

		// Token: 0x04009009 RID: 36873
		public uint Protocol = 0U;

		// Token: 0x0400900A RID: 36874
		public uint Platform = Versioning.Platform;

		// Token: 0x0400900B RID: 36875
		public uint Product = Versioning.Product;

		// Token: 0x0400900C RID: 36876
		public uint Version = Versioning.Version;

		// Token: 0x0400900D RID: 36877
		public uint Language = BitConverter.ToUInt32(Encoding.ASCII.GetBytes(CultureInfo.GetCultureInfo(1033).Name.Replace("-", "")).Reverse<byte>().ToArray<byte>(), 0);

		// Token: 0x0400900E RID: 36878
		public uint IpAddr = 0U;

		// Token: 0x0400900F RID: 36879
		public uint TimeZone = (uint)Math.Round(DateTime.UtcNow.Subtract(DateTime.Now).TotalMinutes);

		// Token: 0x04009010 RID: 36880
		public uint LocaleId = (uint)CultureInfo.GetCultureInfo(1033).LCID;

		// Token: 0x04009011 RID: 36881
		public uint LanguageId = (uint)CultureInfo.GetCultureInfo(1033).LCID;

		// Token: 0x04009012 RID: 36882
		public string CountryAbreviation = new RegionInfo(1033).ThreeLetterISORegionName;

		// Token: 0x04009013 RID: 36883
		public string Country = new RegionInfo(1033).DisplayName;
	}
}
