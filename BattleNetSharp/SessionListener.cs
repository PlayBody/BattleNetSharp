using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.Session.V1;
using Grpc.Core;

namespace BattleNetSharp
{
	// Token: 0x02000AE3 RID: 2787
	public class SessionListener : Bgs.Protocol.Session.V1.SessionListener.SessionListenerBase, IServiceListener
	{
		// Token: 0x0600BCF3 RID: 48371 RVA: 0x0048420C File Offset: 0x0048240C
		public override Task<NO_RESPONSE> OnSessionCreated(SessionCreatedNotification request, ServerCallContext context)
		{
			this.SessionCreatedNotification = request;
			return Task.FromResult<NO_RESPONSE>(new NO_RESPONSE());
		}

		// Token: 0x0600BCF4 RID: 48372 RVA: 0x00484230 File Offset: 0x00482430
		public override Task<NO_RESPONSE> OnSessionDestroyed(SessionDestroyedNotification request, ServerCallContext context)
		{
			return Task.FromResult<NO_RESPONSE>(new NO_RESPONSE());
		}

		// Token: 0x0600BCF5 RID: 48373 RVA: 0x0048424C File Offset: 0x0048244C
		public override Task<NO_RESPONSE> OnSessionUpdated(SessionUpdatedNotification request, ServerCallContext context)
		{
			return Task.FromResult<NO_RESPONSE>(new NO_RESPONSE());
		}

		// Token: 0x0400915A RID: 37210
		public SessionCreatedNotification SessionCreatedNotification;
	}
}
