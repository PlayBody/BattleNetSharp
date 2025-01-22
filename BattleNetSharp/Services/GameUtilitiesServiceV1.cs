using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.GameUtilities.V1;
using Grpc.Core;

namespace BattleNetSharp.Services
{
	// Token: 0x02000AF9 RID: 2809
	public class GameUtilitiesServiceV1 : GameUtilitiesService.GameUtilitiesServiceBase, IServiceListener
	{
		// Token: 0x0600BDAA RID: 48554 RVA: 0x004871C8 File Offset: 0x004853C8
		public override Task<GetAchievementsFileResponse> GetAchievementsFile(GetAchievementsFileRequest request, ServerCallContext context)
		{
			return base.GetAchievementsFile(request, context);
		}

		// Token: 0x0600BDAB RID: 48555 RVA: 0x004871E4 File Offset: 0x004853E4
		public override Task<GetAllValuesForAttributeResponse> GetAllValuesForAttribute(GetAllValuesForAttributeRequest request, ServerCallContext context)
		{
			return base.GetAllValuesForAttribute(request, context);
		}

		// Token: 0x0600BDAC RID: 48556 RVA: 0x00487200 File Offset: 0x00485400
		public override Task<GetPlayerVariablesResponse> GetPlayerVariables(GetPlayerVariablesRequest request, ServerCallContext context)
		{
			return base.GetPlayerVariables(request, context);
		}

		// Token: 0x0600BDAD RID: 48557 RVA: 0x0048721C File Offset: 0x0048541C
		public override Task<NO_RESPONSE> OnGameAccountOffline(GameAccountOfflineNotification request, ServerCallContext context)
		{
			return base.OnGameAccountOffline(request, context);
		}

		// Token: 0x0600BDAE RID: 48558 RVA: 0x00487238 File Offset: 0x00485438
		public override Task<NO_RESPONSE> OnGameAccountOnline(GameAccountOnlineNotification request, ServerCallContext context)
		{
			return base.OnGameAccountOnline(request, context);
		}

		// Token: 0x0600BDAF RID: 48559 RVA: 0x00487254 File Offset: 0x00485454
		public override Task<NoData> PresenceChannelCreated(PresenceChannelCreatedRequest request, ServerCallContext context)
		{
			return base.PresenceChannelCreated(request, context);
		}

		// Token: 0x0600BDB0 RID: 48560 RVA: 0x00487270 File Offset: 0x00485470
		public override Task<ClientResponse> ProcessClientRequest(ClientRequest request, ServerCallContext context)
		{
			return base.ProcessClientRequest(request, context);
		}

		// Token: 0x0600BDB1 RID: 48561 RVA: 0x0048728C File Offset: 0x0048548C
		public override Task<ServerResponse> ProcessServerRequest(ServerRequest request, ServerCallContext context)
		{
			return base.ProcessServerRequest(request, context);
		}
	}
}
