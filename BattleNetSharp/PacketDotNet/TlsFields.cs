using System;

namespace PacketDotNet
{
	// Token: 0x0200082F RID: 2095
	public struct TlsFields
	{
		// Token: 0x04005B58 RID: 23384
		public static readonly int ContentTypeLength = 1;

		// Token: 0x04005B59 RID: 23385
		public static readonly int VersionLength = 2;

		// Token: 0x04005B5A RID: 23386
		public static readonly int DataOffsetLength = 2;

		// Token: 0x04005B5B RID: 23387
		public static readonly int ContentTypePosition = 0;

		// Token: 0x04005B5C RID: 23388
		public static readonly int VersionPosition = TlsFields.ContentTypeLength;

		// Token: 0x04005B5D RID: 23389
		public static readonly int DataOffsetPosition = TlsFields.VersionPosition + TlsFields.VersionLength;

		// Token: 0x04005B5E RID: 23390
		public static readonly int HeaderLength = TlsFields.DataOffsetPosition + TlsFields.DataOffsetLength;
	}
}
