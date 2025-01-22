using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Classic.Protocol.External.V1.DiabloClone;
using Grpc.Core;

namespace BattleNetSharp.Services
{
	// Token: 0x02000B00 RID: 2816
	public class DiabloCloneService : DiabloCloneExternal.DiabloCloneExternalBase, IServiceListener
	{
		// Token: 0x0600BDD9 RID: 48601 RVA: 0x00487814 File Offset: 0x00485A14
		public override Task<NoData> DiabloCloneMessageTier(DiabloCloneMessage request, ServerCallContext context)
		{
			Action<DiabloCloneMessage> webHook = this.WebHook;
			if (webHook != null)
			{
				webHook(request);
			}
			this.Value = request;
			return Task.FromResult<NoData>(new NoData());
		}

		// Token: 0x04009178 RID: 37240
		public Action<DiabloCloneMessage> WebHook;

		// Token: 0x04009179 RID: 37241
		public DiabloCloneMessage Value;
	}
}
