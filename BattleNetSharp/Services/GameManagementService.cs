using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Classic.Protocol.External.V1.GameManagement;
using Google.Protobuf;
using Grpc.Core;

namespace BattleNetSharp.Services
{
	// Token: 0x02000B01 RID: 2817
	public class GameManagementService : GameManagement.GameManagementBase, IServiceListener
	{
		// Token: 0x0600BDDB RID: 48603 RVA: 0x00487854 File Offset: 0x00485A54
		public override Task<GameCreateResponse> GameCreate(GameCreateRequest request, ServerCallContext context)
		{
			return Task.FromResult<GameCreateResponse>(new GameCreateResponse
			{
				Id = 3735928559U,
				MaxPlayers = 8U
			});
		}

		// Token: 0x0600BDDC RID: 48604 RVA: 0x00487884 File Offset: 0x00485A84
		public override Task<GameMgmtResponse> GameCreateCancel(GameMgmtRequest request, ServerCallContext context)
		{
			return base.GameCreateCancel(request, context);
		}

		// Token: 0x0600BDDD RID: 48605 RVA: 0x004878A0 File Offset: 0x00485AA0
		public override Task<GameMgmtResponse> GameCreateQueueTime(GameMgmtRequest request, ServerCallContext context)
		{
			return base.GameCreateQueueTime(request, context);
		}

		// Token: 0x0600BDDE RID: 48606 RVA: 0x004878BC File Offset: 0x00485ABC
		public override Task<GameDetailResponse> GameDetail(GameDetailRequest request, ServerCallContext context)
		{
			GameDetailResponse gameDetailResponse = new GameDetailResponse
			{
				GameName = request.GameName,
				GameDescription = "",
				Flags = 5244928U,
				Time = 4840U,
				Empty = "",
				CharLevel = 10U,
				LevelDifference = 255U,
				MaxPlayers = 8U
			};
			gameDetailResponse.GamePlayers.Add(new GamePlayer
			{
				Name = "test",
				Class = 1U,
				Level = 10U,
				BnetId = 1U,
				CharacterId = 1U
			});
			return Task.FromResult<GameDetailResponse>(gameDetailResponse);
		}

		// Token: 0x0600BDDF RID: 48607 RVA: 0x00487974 File Offset: 0x00485B74
		public override Task<GameGetSitePingListResponse> GameGetSitePingList(NoData request, ServerCallContext context)
		{
			GameGetSitePingListResponse gameGetSitePingListResponse = new GameGetSitePingListResponse();
			gameGetSitePingListResponse.GameSite.Add(new GameSite
			{
				IpAddress = "127.0.0.2:443",
				Region = "USW2"
			});
			gameGetSitePingListResponse.Region.Add("USW2");
			return Task.FromResult<GameGetSitePingListResponse>(gameGetSitePingListResponse);
		}

		// Token: 0x0600BDE0 RID: 48608 RVA: 0x004879CC File Offset: 0x00485BCC
		public override Task<GameJoinResponse> GameJoin(GameJoinRequest request, ServerCallContext context)
		{
			return Task.FromResult<GameJoinResponse>(new GameJoinResponse
			{
				IpAddress = "127.0.0.2",
				Port = 443U,
				Hash = ByteString.CopyFrom(((ConnectionContext)context).Caller.ToByteArray()),
				Id = 3735928559U,
				ServerGitVersion = "1.3.0",
				OneOrZero = 1U,
				Fiftytwo0004 = 5373952U,
				One2 = 255U,
				Region = "USW2",
				Zero = 0U,
				MaxPlayers = 8U
			});
		}

		// Token: 0x0600BDE1 RID: 48609 RVA: 0x00487A70 File Offset: 0x00485C70
		public override Task<GameListResponse> GameList(GameListRequest request, ServerCallContext context)
		{
			return Task.FromResult<GameListResponse>(new GameListResponse());
		}

		// Token: 0x0600BDE2 RID: 48610 RVA: 0x00487A8C File Offset: 0x00485C8C
		public override Task<GameMgmtResponse> GameMatchmake(GameMgmtRequest request, ServerCallContext context)
		{
			return base.GameMatchmake(request, context);
		}
	}
}
