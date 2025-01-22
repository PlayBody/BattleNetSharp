using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Classic.Protocol.V1.GameVersion;
using Grpc.Core;

namespace BattleNetSharp.Services
{
	// Token: 0x02000B02 RID: 2818
	public class GameVersionService : GameVersion.GameVersionBase, IServiceListener
	{
		// Token: 0x0600BDE4 RID: 48612 RVA: 0x00487AB0 File Offset: 0x00485CB0
		public override Task<GameVersionResponse> GameUpdateCanceled(GameVersionRequest request, ServerCallContext context)
		{
			return base.GameUpdateCanceled(request, context);
		}

		// Token: 0x0600BDE5 RID: 48613 RVA: 0x00487ACC File Offset: 0x00485CCC
		public override Task<GameVersionResponse> GameUpdateRequired(GameVersionRequest request, ServerCallContext context)
		{
			return base.GameUpdateRequired(request, context);
		}

		// Token: 0x0600BDE6 RID: 48614 RVA: 0x00487AE8 File Offset: 0x00485CE8
		public override Task<NoData> SetGameVersion(GameVersionRequest request, ServerCallContext context)
		{
			return Task.FromResult<NoData>(new NoData());
		}
	}
}
