using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.Session.V2.Client;
using Grpc.Core;

namespace BattleNetSharp
{
	// Token: 0x02000AE2 RID: 2786
	public class SessionListenerV2 : SessionListener.SessionListenerBase, IServiceListener
	{
		// Token: 0x0600BCED RID: 48365 RVA: 0x00484170 File Offset: 0x00482370
		public override Task<NO_RESPONSE> OnSessionCreated(SessionCreatedNotification request, ServerCallContext context)
		{
			this.SessionCreatedNotification = request;
			return Task.FromResult<NO_RESPONSE>(new NO_RESPONSE());
		}

		// Token: 0x0600BCEE RID: 48366 RVA: 0x00484194 File Offset: 0x00482394
		public override Task<NO_RESPONSE> OnSessionDestroyed(SessionDestroyedNotification request, ServerCallContext context)
		{
			return base.OnSessionDestroyed(request, context);
		}

		// Token: 0x0600BCEF RID: 48367 RVA: 0x004841B0 File Offset: 0x004823B0
		public override Task<NO_RESPONSE> OnSessionGameTimeWarning(SessionGameTimeWarningNotification request, ServerCallContext context)
		{
			return base.OnSessionGameTimeWarning(request, context);
		}

		// Token: 0x0600BCF0 RID: 48368 RVA: 0x004841CC File Offset: 0x004823CC
		public override Task<NO_RESPONSE> OnSessionQueueEnd(SessionQueueEndNotification request, ServerCallContext context)
		{
			return base.OnSessionQueueEnd(request, context);
		}

		// Token: 0x0600BCF1 RID: 48369 RVA: 0x004841E8 File Offset: 0x004823E8
		public override Task<NO_RESPONSE> OnSessionQueueUpdated(SessionQueueUpdatedNotification request, ServerCallContext context)
		{
			return base.OnSessionQueueUpdated(request, context);
		}

		// Token: 0x04009159 RID: 37209
		public SessionCreatedNotification SessionCreatedNotification;
	}
}
