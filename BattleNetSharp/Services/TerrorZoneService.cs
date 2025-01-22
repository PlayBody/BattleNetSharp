using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Classic.Protocol.External.V1.TerrorZones;
using Grpc.Core;

namespace BattleNetSharp.Services
{
	// Token: 0x02000B09 RID: 2825
	public class TerrorZoneService : TerrorZones.TerrorZonesBase, IServiceListener
	{
		// Token: 0x0600BE08 RID: 48648 RVA: 0x00487E34 File Offset: 0x00486034
		public override Task<NoData> TerrorZonesMessage(TerrorZonesMessageRequest request, ServerCallContext context)
		{
			Action<TerrorZonesMessageRequest> webHook = this.WebHook;
			if (webHook != null)
			{
				webHook(request);
			}
			this.TZs = request;
			return Task.FromResult<NoData>(new NoData());
		}

		// Token: 0x0400917A RID: 37242
		public TerrorZonesMessageRequest TZs;

		// Token: 0x0400917B RID: 37243
		public Action<TerrorZonesMessageRequest> WebHook;
	}
}
