using System;
using System.Threading.Tasks;
using Bgs.Protocol.Leaderboard.V1.Client;
using Grpc.Core;

namespace BattleNetSharp.Services
{
	// Token: 0x02000AFA RID: 2810
	public class LeaderboardService : Bgs.Protocol.Leaderboard.V1.Client.LeaderboardService.LeaderboardServiceBase, IServiceListener
	{
		// Token: 0x0600BDB3 RID: 48563 RVA: 0x004872B0 File Offset: 0x004854B0
		public override Task<GetRanksResponse> GetRanks(GetRanksRequest request, ServerCallContext context)
		{
			return base.GetRanks(request, context);
		}

		// Token: 0x0600BDB4 RID: 48564 RVA: 0x004872CC File Offset: 0x004854CC
		public override Task<GetRanksByClubIdResponse> GetRanksByClubId(GetRanksByClubIdRequest request, ServerCallContext context)
		{
			return base.GetRanksByClubId(request, context);
		}

		// Token: 0x0600BDB5 RID: 48565 RVA: 0x004872E8 File Offset: 0x004854E8
		public override Task<GetRanksByEntityIdsResponse> GetRanksByEntityIds(GetRanksByEntityIdsRequest request, ServerCallContext context)
		{
			return base.GetRanksByEntityIds(request, context);
		}

		// Token: 0x0600BDB6 RID: 48566 RVA: 0x00487304 File Offset: 0x00485504
		public override Task<GetRanksByEntityRangeResponse> GetRanksByEntityRange(GetRanksByEntityRangeRequest request, ServerCallContext context)
		{
			return base.GetRanksByEntityRange(request, context);
		}

		// Token: 0x0600BDB7 RID: 48567 RVA: 0x00487320 File Offset: 0x00485520
		public override Task<GetRanksByPositionResponse> GetRanksByPosition(GetRanksByPositionRequest request, ServerCallContext context)
		{
			return base.GetRanksByPosition(request, context);
		}

		// Token: 0x0600BDB8 RID: 48568 RVA: 0x0048733C File Offset: 0x0048553C
		public override Task<GetRanksByPositionRangeResponse> GetRanksByPositionRange(GetRanksByPositionRangeRequest request, ServerCallContext context)
		{
			return base.GetRanksByPositionRange(request, context);
		}
	}
}
