using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.Session.V1;
using Grpc.Core;

namespace BattleNetSharp
{
	// Token: 0x02000AEC RID: 2796
	public class SessionService : Bgs.Protocol.Session.V1.SessionService.SessionServiceBase, IServiceListener
	{
		// Token: 0x0600BD38 RID: 48440 RVA: 0x0048519C File Offset: 0x0048339C
		public override Task<CreateSessionResponse> CreateSession(CreateSessionRequest request, ServerCallContext context)
		{
			SessionCreatedNotification sessionCreated = new SessionCreatedNotification
			{
				Identity = request.Identity,
				Reason = 0U,
				SessionId = ((ConnectionContext)context).Caller.ToString(),
				ClientId = ((ConnectionContext)context).Caller.ToString()
			};
			Task.Run(delegate
			{
				D2RBGS.BGSConnections[((ConnectionContext)context).Caller].SendBgsServer(sessionCreated, "OnSessionCreated", typeof(SessionListener));
			});
			return Task.FromResult<CreateSessionResponse>(new CreateSessionResponse
			{
				SessionId = D2RBGS.BGSConnections[((ConnectionContext)context).Caller].ClientId
			});
		}

		// Token: 0x0600BD39 RID: 48441 RVA: 0x00485264 File Offset: 0x00483464
		public override Task<NoData> DestroySession(DestroySessionRequest request, ServerCallContext context)
		{
			return Task.FromResult<NoData>(new NoData());
		}

		// Token: 0x0600BD3A RID: 48442 RVA: 0x00485280 File Offset: 0x00483480
		public override Task<GetSessionCapacityResponse> GetSessionCapacity(GetSessionCapacityRequest request, ServerCallContext context)
		{
			return base.GetSessionCapacity(request, context);
		}

		// Token: 0x0600BD3B RID: 48443 RVA: 0x0048529C File Offset: 0x0048349C
		public override Task<GetSessionStateResponse> GetSessionState(GetSessionStateRequest request, ServerCallContext context)
		{
			return base.GetSessionState(request, context);
		}

		// Token: 0x0600BD3C RID: 48444 RVA: 0x004852B8 File Offset: 0x004834B8
		public override Task<GetSessionStateByBenefactorResponse> GetSessionStateByBenefactor(GetSessionStateByBenefactorRequest request, ServerCallContext context)
		{
			return base.GetSessionStateByBenefactor(request, context);
		}

		// Token: 0x0600BD3D RID: 48445 RVA: 0x004852D4 File Offset: 0x004834D4
		public override Task<GetSignedSessionStateResponse> GetSignedSessionState(GetSignedSessionStateRequest request, ServerCallContext context)
		{
			return base.GetSignedSessionState(request, context);
		}

		// Token: 0x0600BD3E RID: 48446 RVA: 0x004852F0 File Offset: 0x004834F0
		public override Task<MarkSessionsAliveResponse> MarkSessionsAlive(MarkSessionsAliveRequest request, ServerCallContext context)
		{
			return base.MarkSessionsAlive(request, context);
		}

		// Token: 0x0600BD3F RID: 48447 RVA: 0x0048530C File Offset: 0x0048350C
		public override Task<RefreshSessionKeyResponse> RefreshSessionKey(RefreshSessionKeyRequest request, ServerCallContext context)
		{
			return base.RefreshSessionKey(request, context);
		}

		// Token: 0x0600BD40 RID: 48448 RVA: 0x00485328 File Offset: 0x00483528
		public override Task<NoData> UpdateSession(UpdateSessionRequest request, ServerCallContext context)
		{
			return base.UpdateSession(request, context);
		}
	}
}
