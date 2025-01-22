using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.RecentPlayers.V1.Client;
using Grpc.Core;

namespace BattleNetSharp
{
	// Token: 0x02000AE1 RID: 2785
	public class RecentPlayersListener : RecentPlayersListener.RecentPlayersListenerBase, IServiceListener
	{
		// Token: 0x0600BCEA RID: 48362 RVA: 0x00484130 File Offset: 0x00482330
		public override Task<NO_RESPONSE> OnRecentPlayersAdded(RecentPlayersAddedNotification request, ServerCallContext context)
		{
			return base.OnRecentPlayersAdded(request, context);
		}

		// Token: 0x0600BCEB RID: 48363 RVA: 0x0048414C File Offset: 0x0048234C
		public override Task<NO_RESPONSE> OnRecentPlayersRemoved(RecentPlayersRemovedNotification request, ServerCallContext context)
		{
			return base.OnRecentPlayersRemoved(request, context);
		}
	}
}
