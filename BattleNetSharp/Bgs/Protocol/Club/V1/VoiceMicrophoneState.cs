using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200044E RID: 1102
	public enum VoiceMicrophoneState
	{
		// Token: 0x040031A4 RID: 12708
		[OriginalName("MICROPHONE_STATE_NORMAL")]
		MicrophoneStateNormal,
		// Token: 0x040031A5 RID: 12709
		[OriginalName("MICROPHONE_STATE_SELF_MUTE")]
		MicrophoneStateSelfMute,
		// Token: 0x040031A6 RID: 12710
		[OriginalName("MICROPHONE_STATE_SELF_DEAF")]
		MicrophoneStateSelfDeaf
	}
}
