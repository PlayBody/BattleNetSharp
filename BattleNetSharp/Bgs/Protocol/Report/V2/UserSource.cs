using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Report.V2
{
	// Token: 0x02000586 RID: 1414
	public enum UserSource
	{
		// Token: 0x04003D65 RID: 15717
		[OriginalName("USER_SOURCE_OTHER")]
		Other,
		// Token: 0x04003D66 RID: 15718
		[OriginalName("USER_SOURCE_WHISPER")]
		Whisper,
		// Token: 0x04003D67 RID: 15719
		[OriginalName("USER_SOURCE_PROFILE")]
		Profile,
		// Token: 0x04003D68 RID: 15720
		[OriginalName("USER_SOURCE_BATTLE_TAG")]
		BattleTag,
		// Token: 0x04003D69 RID: 15721
		[OriginalName("USER_SOURCE_CHAT")]
		Chat,
		// Token: 0x04003D6A RID: 15722
		[OriginalName("USER_SOURCE_FRIEND_INVITATION")]
		FriendInvitation,
		// Token: 0x04003D6B RID: 15723
		[OriginalName("USER_SOURCE_VOICE")]
		Voice
	}
}
