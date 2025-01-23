using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.Account.V2;
using Bgs.Protocol.Session.V2.Client;
using Google.Protobuf;
using Grpc.Core;

namespace BattleNetSharp
{
	// Token: 0x02000AEB RID: 2795
	public class SessionServiceV2 : Bgs.Protocol.Session.V2.Client.SessionService.SessionServiceBase, IServiceListener
	{
		// Token: 0x0600BD31 RID: 48433 RVA: 0x00484FD0 File Offset: 0x004831D0
		public override Task<CreateSessionResponse> CreateSession(CreateSessionRequest request, ServerCallContext context)
		{
			SessionId sessionId = new SessionId
			{
				AccountId = (ulong)D2RBGS.BGSConnections[((ConnectionContext)context).Caller].AccountLow,
				GameAccount = new GameAccountHandle
				{
					Id = (ulong)D2RBGS.BGSConnections[((ConnectionContext)context).Caller].GameAccountLow,
					TitleId = 4613486U,
					Region = 100U
				},
				InstanceId = D2RBGS.BGSConnections[((ConnectionContext)context).Caller].ClientId
			};
			SessionCreatedNotification sessionCreated = new SessionCreatedNotification
			{
				Status = 0U,
				SessionKey = new SessionKey
				{
					ExpirationS = 45UL,
					Key = ByteString.CopyFromUtf8("")
				},
				SessionId = sessionId
			};
			Task.Run(async delegate
			{
				await Task.Delay(500);
				D2RBGS.BGSConnections[((ConnectionContext)context).Caller].SendBgsServer(sessionCreated, "OnSessionCreated", typeof(SessionListenerV2));
			});
			return Task.FromResult<CreateSessionResponse>(new CreateSessionResponse
			{
				Variables = new SessionVariables
				{
					CreationTimeoutS = 45U
				},
				SessionId = sessionId
			});
		}

		// Token: 0x0600BD32 RID: 48434 RVA: 0x00485108 File Offset: 0x00483308
		public override Task<NoData> DestroySession(DestroySessionRequest request, ServerCallContext context)
		{
			return base.DestroySession(request, context);
		}

		// Token: 0x0600BD33 RID: 48435 RVA: 0x00485124 File Offset: 0x00483324
		public override Task<GetSessionStateResponse> GetSessionState(GetSessionStateRequest request, ServerCallContext context)
		{
			return base.GetSessionState(request, context);
		}

		// Token: 0x0600BD34 RID: 48436 RVA: 0x00485140 File Offset: 0x00483340
		public override Task<GetSignedSessionStateResponse> GetSignedSessionState(GetSignedSessionStateRequest request, ServerCallContext context)
		{
			return base.GetSignedSessionState(request, context);
		}

		// Token: 0x0600BD35 RID: 48437 RVA: 0x0048515C File Offset: 0x0048335C
		public override Task<NoData> MarkSessionAlive(MarkSessionAliveRequest request, ServerCallContext context)
		{
			return base.MarkSessionAlive(request, context);
		}

		// Token: 0x0600BD36 RID: 48438 RVA: 0x00485178 File Offset: 0x00483378
		public override Task<RestoreSessionResponse> RestoreSession(RestoreSessionRequest request, ServerCallContext context)
		{
			return base.RestoreSession(request, context);
		}
	}
}
