using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200044D RID: 1101
	public enum StreamVoiceLevel
	{
		// Token: 0x040031A0 RID: 12704
		[OriginalName("VOICE_LEVEL_DISABLED")]
		VoiceLevelDisabled,
		// Token: 0x040031A1 RID: 12705
		[OriginalName("VOICE_LEVEL_PUSH_TO_TALK")]
		VoiceLevelPushToTalk,
		// Token: 0x040031A2 RID: 12706
		[OriginalName("VOICE_LEVEL_OPEN_MIC")]
		VoiceLevelOpenMic
	}
}
