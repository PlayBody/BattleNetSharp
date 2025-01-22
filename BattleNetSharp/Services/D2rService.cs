using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Classic.Protocol.V1.D2RConnection;
using Grpc.Core;

namespace BattleNetSharp.Services
{
	// Token: 0x02000AFF RID: 2815
	public class D2rService : D2rServicesConnection.D2rServicesConnectionBase, IServiceListener
	{
		// Token: 0x0600BDD2 RID: 48594 RVA: 0x00487760 File Offset: 0x00485960
		public override Task<AuthSessionResponse> AuthSession(AuthSessionRequest request, ServerCallContext context)
		{
			return Task.FromResult<AuthSessionResponse>(new AuthSessionResponse());
		}

		// Token: 0x0600BDD3 RID: 48595 RVA: 0x0048777C File Offset: 0x0048597C
		public override Task<CookieUpdateResponse> CookieUpdate(NoData request, ServerCallContext context)
		{
			return Task.FromResult<CookieUpdateResponse>(new CookieUpdateResponse());
		}

		// Token: 0x0600BDD4 RID: 48596 RVA: 0x00487798 File Offset: 0x00485998
		public override Task<NoData> Ping(NoData request, ServerCallContext context)
		{
			return base.Ping(request, context);
		}

		// Token: 0x0600BDD5 RID: 48597 RVA: 0x004877B4 File Offset: 0x004859B4
		public override Task<NoData> ServerPing(NoData request, ServerCallContext context)
		{
			return Task.FromResult<NoData>(new NoData());
		}

		// Token: 0x0600BDD6 RID: 48598 RVA: 0x004877D0 File Offset: 0x004859D0
		public override Task<AuthResponse> SessionDestroyed(AuthRequest request, ServerCallContext context)
		{
			return base.SessionDestroyed(request, context);
		}

		// Token: 0x0600BDD7 RID: 48599 RVA: 0x004877EC File Offset: 0x004859EC
		public override Task<SessionUpdateResponse> SessionUpdate(NoData request, ServerCallContext context)
		{
			return Task.FromResult<SessionUpdateResponse>(new SessionUpdateResponse());
		}

		// Token: 0x04009175 RID: 37237
		public static string BNetIP;

		// Token: 0x04009176 RID: 37238
		public static string Acc;

		// Token: 0x04009177 RID: 37239
		public static string Pw;
	}
}
