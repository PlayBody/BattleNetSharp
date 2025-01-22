using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.Whisper.V1;
using Grpc.Core;

namespace BattleNetSharp.Services
{
	// Token: 0x02000B0E RID: 2830
	public class WhisperService : WhisperService.WhisperServiceBase, IServiceListener
	{
		// Token: 0x0600BE1F RID: 48671 RVA: 0x00488248 File Offset: 0x00486448
		public override Task<NoData> AdvanceClearTime(AdvanceClearTimeRequest request, ServerCallContext context)
		{
			return base.AdvanceClearTime(request, context);
		}

		// Token: 0x0600BE20 RID: 48672 RVA: 0x00488264 File Offset: 0x00486464
		public override Task<NoData> AdvanceViewTime(AdvanceViewTimeRequest request, ServerCallContext context)
		{
			return base.AdvanceViewTime(request, context);
		}

		// Token: 0x0600BE21 RID: 48673 RVA: 0x00488280 File Offset: 0x00486480
		public override Task<GetWhisperMessagesResponse> GetWhisperMessages(GetWhisperMessagesRequest request, ServerCallContext context)
		{
			return base.GetWhisperMessages(request, context);
		}

		// Token: 0x0600BE22 RID: 48674 RVA: 0x0048829C File Offset: 0x0048649C
		public override Task<SendWhisperResponse> SendWhisper(SendWhisperRequest request, ServerCallContext context)
		{
			return base.SendWhisper(request, context);
		}

		// Token: 0x0600BE23 RID: 48675 RVA: 0x004882B8 File Offset: 0x004864B8
		public override Task<NoData> SetTypingIndicator(SetTypingIndicatorRequest request, ServerCallContext context)
		{
			return base.SetTypingIndicator(request, context);
		}

		// Token: 0x0600BE24 RID: 48676 RVA: 0x004882D4 File Offset: 0x004864D4
		public override Task<SubscribeResponse> Subscribe(SubscribeRequest request, ServerCallContext context)
		{
			return Task.FromResult<SubscribeResponse>(new SubscribeResponse());
		}

		// Token: 0x0600BE25 RID: 48677 RVA: 0x004882F0 File Offset: 0x004864F0
		public override Task<NoData> Unsubscribe(UnsubscribeRequest request, ServerCallContext context)
		{
			return base.Unsubscribe(request, context);
		}
	}
}
