using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.UserManager.V1;
using Grpc.Core;

namespace BattleNetSharp.Services
{
	// Token: 0x02000B0D RID: 2829
	public class UserManagerService : UserManagerService.UserManagerServiceBase, IServiceListener
	{
		// Token: 0x0600BE17 RID: 48663 RVA: 0x00488174 File Offset: 0x00486374
		public override Task<NoData> AddRecentPlayers(AddRecentPlayersRequest request, ServerCallContext context)
		{
			return base.AddRecentPlayers(request, context);
		}

		// Token: 0x0600BE18 RID: 48664 RVA: 0x00488190 File Offset: 0x00486390
		public override Task<NoData> BlockPlayer(BlockPlayerRequest request, ServerCallContext context)
		{
			return base.BlockPlayer(request, context);
		}

		// Token: 0x0600BE19 RID: 48665 RVA: 0x004881AC File Offset: 0x004863AC
		public override Task<NoData> BlockPlayerForSession(BlockPlayerRequest request, ServerCallContext context)
		{
			return base.BlockPlayerForSession(request, context);
		}

		// Token: 0x0600BE1A RID: 48666 RVA: 0x004881C8 File Offset: 0x004863C8
		public override Task<NoData> ClearRecentPlayers(ClearRecentPlayersRequest request, ServerCallContext context)
		{
			return base.ClearRecentPlayers(request, context);
		}

		// Token: 0x0600BE1B RID: 48667 RVA: 0x004881E4 File Offset: 0x004863E4
		public override Task<SubscribeResponse> Subscribe(SubscribeRequest request, ServerCallContext context)
		{
			SubscribeResponse subscribeResponse = new SubscribeResponse();
			return Task.FromResult<SubscribeResponse>(subscribeResponse);
		}

		// Token: 0x0600BE1C RID: 48668 RVA: 0x00488204 File Offset: 0x00486404
		public override Task<NoData> UnblockPlayer(UnblockPlayerRequest request, ServerCallContext context)
		{
			return base.UnblockPlayer(request, context);
		}

		// Token: 0x0600BE1D RID: 48669 RVA: 0x00488220 File Offset: 0x00486420
		public override Task<NoData> Unsubscribe(UnsubscribeRequest request, ServerCallContext context)
		{
			return Task.FromResult<NoData>(new NoData());
		}
	}
}
