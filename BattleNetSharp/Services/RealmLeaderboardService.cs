using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Classic.Protocol.V1.Leaderboard;
using Grpc.Core;

namespace BattleNetSharp.Services
{
	// Token: 0x02000B08 RID: 2824
	public class RealmLeaderboardService : Leaderboard.LeaderboardBase, IServiceListener
	{
		// Token: 0x0600BE04 RID: 48644 RVA: 0x00487DD4 File Offset: 0x00485FD4
		public override Task<Leaderboards> GetLeaderboardIds(NoData request, ServerCallContext context)
		{
			return base.GetLeaderboardIds(request, context);
		}

		// Token: 0x0600BE05 RID: 48645 RVA: 0x00487DF0 File Offset: 0x00485FF0
		public override Task<ServerTime> GetServerTime(NoData request, ServerCallContext context)
		{
			return base.GetServerTime(request, context);
		}

		// Token: 0x0600BE06 RID: 48646 RVA: 0x00487E0C File Offset: 0x0048600C
		public override Task<NoData> SetSeasonInfo(SeasonInfo request, ServerCallContext context)
		{
			return Task.FromResult<NoData>(new NoData());
		}
	}
}
