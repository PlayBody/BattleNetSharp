using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.Account.V1;
using Grpc.Core;

namespace BattleNetSharp
{
	// Token: 0x02000AD5 RID: 2773
	public class AccountListener : Bgs.Protocol.Account.V1.AccountListener.AccountListenerBase, IServiceListener
	{
		// Token: 0x0600BC99 RID: 48281 RVA: 0x0048323C File Offset: 0x0048143C
		public override Task<NO_RESPONSE> OnAccountStateUpdated(AccountStateNotification request, ServerCallContext context)
		{
			return base.OnAccountStateUpdated(request, context);
		}

		// Token: 0x0600BC9A RID: 48282 RVA: 0x00483258 File Offset: 0x00481458
		public override Task<NO_RESPONSE> OnGameAccountStateUpdated(GameAccountStateNotification request, ServerCallContext context)
		{
			return base.OnGameAccountStateUpdated(request, context);
		}

		// Token: 0x0600BC9B RID: 48283 RVA: 0x00483274 File Offset: 0x00481474
		public override Task<NO_RESPONSE> OnGameAccountsUpdated(GameAccountNotification request, ServerCallContext context)
		{
			return base.OnGameAccountsUpdated(request, context);
		}

		// Token: 0x0600BC9C RID: 48284 RVA: 0x00483290 File Offset: 0x00481490
		public override Task<NO_RESPONSE> OnGameSessionUpdated(GameAccountSessionNotification request, ServerCallContext context)
		{
			return base.OnGameSessionUpdated(request, context);
		}
	}
}
