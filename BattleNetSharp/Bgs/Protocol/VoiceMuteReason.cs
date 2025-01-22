using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000397 RID: 919
	public enum VoiceMuteReason
	{
		// Token: 0x04002AB8 RID: 10936
		[OriginalName("VOICE_MUTE_REASON_NONE")]
		None,
		// Token: 0x04002AB9 RID: 10937
		[OriginalName("VOICE_MUTE_REASON_PARENTAL_CONTROL_LISTEN_ONLY")]
		ParentalControlListenOnly,
		// Token: 0x04002ABA RID: 10938
		[OriginalName("VOICE_MUTE_REASON_REQUESTED")]
		Requested,
		// Token: 0x04002ABB RID: 10939
		[OriginalName("VOICE_MUTE_REASON_SQUELCHED")]
		Squelched
	}
}
