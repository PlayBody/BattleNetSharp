using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Classic.Protocol.External.V1.GenericResource;
using Grpc.Core;

namespace BattleNetSharp.Services
{
	// Token: 0x02000B04 RID: 2820
	public class GenericResourceService : GenericResource.GenericResourceBase, IServiceListener
	{
		// Token: 0x0600BDEA RID: 48618 RVA: 0x00487B44 File Offset: 0x00485D44
		public override Task<AvailableResources> ReqGenericResource(AvailableResources request, ServerCallContext context)
		{
			return base.ReqGenericResource(request, context);
		}

		// Token: 0x0600BDEB RID: 48619 RVA: 0x00487B60 File Offset: 0x00485D60
		public override Task<NoData> SetAvailableResources(AvailableResources request, ServerCallContext context)
		{
			return Task.FromResult<NoData>(new NoData());
		}
	}
}
