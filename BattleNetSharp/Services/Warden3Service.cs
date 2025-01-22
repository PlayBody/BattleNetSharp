using System;
using System.Threading.Tasks;
using Classic.Protocol.V1.Warden;
using Grpc.Core;

namespace BattleNetSharp.Services
{
	// Token: 0x02000B0A RID: 2826
	public class Warden3Service : Warden3.Warden3Base, IServiceListener
	{
		// Token: 0x0600BE0A RID: 48650 RVA: 0x00487E74 File Offset: 0x00486074
		public override Task<WardenResponse> Init(WardenRequest request, ServerCallContext context)
		{
			return base.Init(request, context);
		}

		// Token: 0x0600BE0B RID: 48651 RVA: 0x00487E90 File Offset: 0x00486090
		public override Task<WardenResponse> SendPacketToClient(WardenRequest request, ServerCallContext context)
		{
			return base.SendPacketToClient(request, context);
		}

		// Token: 0x0600BE0C RID: 48652 RVA: 0x00487EAC File Offset: 0x004860AC
		public override Task<WardenResponse> SendPacketToServer(WardenRequest request, ServerCallContext context)
		{
			return base.SendPacketToServer(request, context);
		}
	}
}
