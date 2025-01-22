using System;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000360 RID: 864
	public static class FieldOptionsExtensions
	{
		// Token: 0x040028AB RID: 10411
		public static readonly Extension<FieldOptions, BGSFieldOptions> FieldOptions_ = new Extension<FieldOptions, BGSFieldOptions>(90000, FieldCodec.ForMessage<BGSFieldOptions>(720002U, BGSFieldOptions.Parser));

		// Token: 0x040028AC RID: 10412
		public static readonly Extension<FieldOptions, FieldRestriction> Valid = new Extension<FieldOptions, FieldRestriction>(90001, FieldCodec.ForMessage<FieldRestriction>(720010U, FieldRestriction.Parser));
	}
}
