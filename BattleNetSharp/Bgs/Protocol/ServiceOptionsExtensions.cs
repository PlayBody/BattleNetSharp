using System;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x0200037A RID: 890
	public static class ServiceOptionsExtensions
	{
		// Token: 0x0400295D RID: 10589
		public static readonly Extension<ServiceOptions, BGSServiceOptions> ServiceOptions_ = new Extension<ServiceOptions, BGSServiceOptions>(90000, FieldCodec.ForMessage<BGSServiceOptions>(720002U, BGSServiceOptions.Parser));

		// Token: 0x0400295E RID: 10590
		public static readonly Extension<ServiceOptions, SDKServiceOptions> SdkServiceOptions = new Extension<ServiceOptions, SDKServiceOptions>(90001, FieldCodec.ForMessage<SDKServiceOptions>(720010U, SDKServiceOptions.Parser));
	}
}
