using System;
using System.Threading.Tasks;
using Classic.Protocol.External.V1.GemTicket.GemTicket;
using Grpc.Core;

namespace BattleNetSharp.Services
{
	// Token: 0x02000B03 RID: 2819
	public class GemTicketService : GemTicket.GemTicketBase, IServiceListener
	{
		// Token: 0x0600BDE8 RID: 48616 RVA: 0x00487B10 File Offset: 0x00485D10
		public override Task<GemTicketResponse> ReqGemTicket(GemTicketRequest request, ServerCallContext context)
		{
			return Task.FromResult<GemTicketResponse>(new GemTicketResponse
			{
				MagicNumber = "orange number"
			});
		}
	}
}
