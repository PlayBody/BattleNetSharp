using System;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x0200036C RID: 876
	public static class MessageOptionsExtensions
	{
		// Token: 0x0400290A RID: 10506
		public static readonly Extension<MessageOptions, BGSMessageOptions> MessageOptions_ = new Extension<MessageOptions, BGSMessageOptions>(90000, FieldCodec.ForMessage<BGSMessageOptions>(720002U, BGSMessageOptions.Parser));
	}
}
