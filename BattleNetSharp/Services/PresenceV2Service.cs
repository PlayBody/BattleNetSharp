using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.Presence.V2.Client;
using Grpc.Core;

namespace BattleNetSharp.Services
{
	// Token: 0x02000AFB RID: 2811
	public class PresenceV2Service : PresenceService.PresenceServiceBase, IServiceListener
	{
		// Token: 0x0600BDBA RID: 48570 RVA: 0x00487360 File Offset: 0x00485560
		public override Task<NoData> BatchSubscribe(BatchSubscribeRequest request, ServerCallContext context)
		{
			return base.BatchSubscribe(request, context);
		}

		// Token: 0x0600BDBB RID: 48571 RVA: 0x0048737C File Offset: 0x0048557C
		public override Task<NoData> BatchUnsubscribe(BatchUnsubscribeRequest request, ServerCallContext context)
		{
			return base.BatchUnsubscribe(request, context);
		}

		// Token: 0x0600BDBC RID: 48572 RVA: 0x00487398 File Offset: 0x00485598
		public override Task<QueryResponse> Query(QueryRequest request, ServerCallContext context)
		{
			return Task.FromResult<QueryResponse>(new QueryResponse());
		}

		// Token: 0x0600BDBD RID: 48573 RVA: 0x004873B4 File Offset: 0x004855B4
		public override Task<NoData> Unk(UpdateRequest request, ServerCallContext context)
		{
			return Task.FromResult<NoData>(new NoData());
		}

		// Token: 0x0600BDBE RID: 48574 RVA: 0x004873D0 File Offset: 0x004855D0
		public override Task<NoData> Update(UpdateRequest request, ServerCallContext context)
		{
			return Task.FromResult<NoData>(new NoData());
		}
	}
}
