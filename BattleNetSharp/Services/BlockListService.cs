using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.BlockList.V1.Client;
using Grpc.Core;

namespace BattleNetSharp.Services
{
	// Token: 0x02000AF5 RID: 2805
	public class BlockListService : Bgs.Protocol.BlockList.V1.Client.BlockListService.BlockListServiceBase, IServiceListener
	{
		// Token: 0x0600BD8A RID: 48522 RVA: 0x00486A20 File Offset: 0x00484C20
		public override Task<NoData> BlockPlayer(BlockPlayerRequest request, ServerCallContext context)
		{
			return base.BlockPlayer(request, context);
		}

		// Token: 0x0600BD8B RID: 48523 RVA: 0x00486A3C File Offset: 0x00484C3C
		public override Task<NoData> BlockPlayerForSession(BlockPlayerRequest request, ServerCallContext context)
		{
			return base.BlockPlayerForSession(request, context);
		}

		// Token: 0x0600BD8C RID: 48524 RVA: 0x00486A58 File Offset: 0x00484C58
		public override Task<GetStateResponse> GetState(GetStateRequest request, ServerCallContext context)
		{
			return base.GetState(request, context);
		}

		// Token: 0x0600BD8D RID: 48525 RVA: 0x00486A74 File Offset: 0x00484C74
		public override Task<SubscribeResponse> Subscribe(SubscribeRequest request, ServerCallContext context)
		{
			return Task.FromResult<SubscribeResponse>(new SubscribeResponse());
		}

		// Token: 0x0600BD8E RID: 48526 RVA: 0x00486A90 File Offset: 0x00484C90
		public override Task<NoData> UnblockPlayer(UnblockPlayerRequest request, ServerCallContext context)
		{
			return base.UnblockPlayer(request, context);
		}

		// Token: 0x0600BD8F RID: 48527 RVA: 0x00486AAC File Offset: 0x00484CAC
		public override Task<NoData> Unsubscribe(UnsubscribeRequest request, ServerCallContext context)
		{
			return base.Unsubscribe(request, context);
		}
	}
}
