using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.RecentPlayers.V1.Client;
using Grpc.Core;

namespace BattleNetSharp.Services
{
	// Token: 0x02000B0B RID: 2827
	public class RecentPlayersService : Bgs.Protocol.RecentPlayers.V1.Client.RecentPlayersService.RecentPlayersServiceBase, IServiceListener
	{
		// Token: 0x0600BE0E RID: 48654 RVA: 0x00487ED0 File Offset: 0x004860D0
		public override Task<NoData> AddRecentPlayers(AddRecentPlayersRequest request, ServerCallContext context)
		{
			return base.AddRecentPlayers(request, context);
		}

		// Token: 0x0600BE0F RID: 48655 RVA: 0x00487EEC File Offset: 0x004860EC
		public override Task<NoData> ClearRecentPlayers(ClearRecentPlayersRequest request, ServerCallContext context)
		{
			return base.ClearRecentPlayers(request, context);
		}

		// Token: 0x0600BE10 RID: 48656 RVA: 0x00487F08 File Offset: 0x00486108
		public override Task<GetStateResponse> GetState(GetStateRequest request, ServerCallContext context)
		{
			return base.GetState(request, context);
		}

		// Token: 0x0600BE11 RID: 48657 RVA: 0x00487F24 File Offset: 0x00486124
		public override Task<SubscribeResponse> Subscribe(SubscribeRequest request, ServerCallContext context)
		{
			return Task.FromResult<SubscribeResponse>(new SubscribeResponse());
		}

		// Token: 0x0600BE12 RID: 48658 RVA: 0x00487F40 File Offset: 0x00486140
		public override Task<NoData> Unsubscribe(UnsubscribeRequest request, ServerCallContext context)
		{
			return base.Unsubscribe(request, context);
		}
	}
}
