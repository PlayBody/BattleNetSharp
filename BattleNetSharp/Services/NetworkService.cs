using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Classic.Protocol.V1.Network;
using Grpc.Core;

namespace BattleNetSharp.Services
{
	// Token: 0x02000B07 RID: 2823
	public class NetworkService : Classic.Protocol.V1.Network.Network.NetworkBase, IServiceListener
	{
		// Token: 0x0600BE01 RID: 48641 RVA: 0x00487D94 File Offset: 0x00485F94
		public override Task<NoData> GetEchoServerList(NoData request, ServerCallContext context)
		{
			return Task.FromResult<NoData>(new NoData());
		}

		// Token: 0x0600BE02 RID: 48642 RVA: 0x00487DB0 File Offset: 0x00485FB0
		public override Task<NetworkResponse> SendUDPTest(NetworkRequest request, ServerCallContext context)
		{
			return base.SendUDPTest(request, context);
		}
	}
}
