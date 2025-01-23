using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.Whisper.V1;
using Grpc.Core;

namespace BattleNetSharp
{
	// Token: 0x02000AE5 RID: 2789
	public class WhisperListener : Bgs.Protocol.Whisper.V1.WhisperListener.WhisperListenerBase, IServiceListener
	{
		// Token: 0x0600BCF9 RID: 48377 RVA: 0x00484298 File Offset: 0x00482498
		public override Task<NO_RESPONSE> OnAdvanceClearTime(AdvanceClearTimeNotification request, ServerCallContext context)
		{
			return null;
		}

		// Token: 0x0600BCFA RID: 48378 RVA: 0x004842AC File Offset: 0x004824AC
		public override Task<NO_RESPONSE> OnAdvanceViewTime(AdvanceViewTimeNotification request, ServerCallContext context)
		{
			return null;
		}

		// Token: 0x0600BCFB RID: 48379 RVA: 0x004842C0 File Offset: 0x004824C0
		public override Task<NO_RESPONSE> OnTypingIndicatorUpdate(TypingIndicatorNotification request, ServerCallContext context)
		{
			return null;
		}

		// Token: 0x0600BCFC RID: 48380 RVA: 0x004842D4 File Offset: 0x004824D4
		public override Task<NO_RESPONSE> OnWhisper(WhisperNotification request, ServerCallContext context)
		{
			return null;
		}

		// Token: 0x0600BCFD RID: 48381 RVA: 0x004842E8 File Offset: 0x004824E8
		public override Task<NO_RESPONSE> OnWhisperEcho(WhisperEchoNotification request, ServerCallContext context)
		{
			return null;
		}

		// Token: 0x0600BCFE RID: 48382 RVA: 0x004842FC File Offset: 0x004824FC
		public override Task<NO_RESPONSE> OnWhisperUpdated(WhisperUpdatedNotification request, ServerCallContext context)
		{
			return null;
		}
	}
}
