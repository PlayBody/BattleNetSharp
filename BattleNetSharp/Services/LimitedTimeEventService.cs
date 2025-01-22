using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Classic.Protocol.External.V1.LimitedTimeEvent;
using Grpc.Core;

namespace BattleNetSharp.Services
{
	// Token: 0x02000B05 RID: 2821
	public class LimitedTimeEventService : LimitedTimeEvent.LimitedTimeEventBase, IServiceListener
	{
		// Token: 0x0600BDED RID: 48621 RVA: 0x00487B88 File Offset: 0x00485D88
		public override Task<NoData> SetLimitedTimeEventStatus(NoData request, ServerCallContext context)
		{
			return Task.FromResult<NoData>(new NoData());
		}
	}
}
