using System;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x0200036F RID: 879
	public static class MethodOptionsExtensions
	{
		// Token: 0x04002915 RID: 10517
		public static readonly Extension<MethodOptions, BGSMethodOptions> MethodOptions_ = new Extension<MethodOptions, BGSMethodOptions>(90000, FieldCodec.ForMessage<BGSMethodOptions>(720002U, BGSMethodOptions.Parser));
	}
}
