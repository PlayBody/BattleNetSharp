using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.Authentication.V2.Client;
using Grpc.Core;

namespace BattleNetSharp
{
	// Token: 0x02000AD6 RID: 2774
	public class AuthenticationListenerV2 : Bgs.Protocol.Authentication.V2.Client.AuthenticationListener.AuthenticationListenerBase, IServiceListener
	{
		// Token: 0x0600BC9E RID: 48286 RVA: 0x004832B4 File Offset: 0x004814B4
		public override Task<NO_RESPONSE> OnExternalChallenge(ExternalChallengeNotification request, ServerCallContext context)
		{
			return base.OnExternalChallenge(request, context);
		}

		// Token: 0x0600BC9F RID: 48287 RVA: 0x004832D0 File Offset: 0x004814D0
		public override Task<NO_RESPONSE> OnLogonComplete(LogonCompleteNotification request, ServerCallContext context)
		{
			this.LogonResult = request;
			AuthenticationListenerV2.LogonResultGlobal = request;
			return Task.FromResult<NO_RESPONSE>(new NO_RESPONSE());
		}

		// Token: 0x0600BCA0 RID: 48288 RVA: 0x004832FC File Offset: 0x004814FC
		public override Task<NO_RESPONSE> OnLogonQueueEnd(NoData request, ServerCallContext context)
		{
			return Task.FromResult<NO_RESPONSE>(new NO_RESPONSE());
		}

		// Token: 0x0600BCA1 RID: 48289 RVA: 0x00483318 File Offset: 0x00481518
		public override Task<NO_RESPONSE> OnLogonQueueUpdate(LogonQueueUpdateNotification request, ServerCallContext context)
		{
			return Task.FromResult<NO_RESPONSE>(new NO_RESPONSE());
		}

		// Token: 0x04009150 RID: 37200
		public static LogonCompleteNotification LogonResultGlobal;

		// Token: 0x04009151 RID: 37201
		public LogonCompleteNotification LogonResult;
	}
}
