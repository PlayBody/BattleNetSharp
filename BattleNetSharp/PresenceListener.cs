using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.Presence.V1;
using Grpc.Core;

namespace BattleNetSharp
{
	// Token: 0x02000ADF RID: 2783
	public class PresenceListener : PresenceListener.PresenceListenerBase, IServiceListener
	{
		// Token: 0x0600BCE4 RID: 48356 RVA: 0x004840AC File Offset: 0x004822AC
		public override Task<NO_RESPONSE> OnStateChanged(StateChangedNotification request, ServerCallContext context)
		{
			return base.OnStateChanged(request, context);
		}

		// Token: 0x0600BCE5 RID: 48357 RVA: 0x004840C8 File Offset: 0x004822C8
		public override Task<NO_RESPONSE> OnSubscribe(SubscribeNotification request, ServerCallContext context)
		{
			return Task.FromResult<NO_RESPONSE>(new NO_RESPONSE());
		}
	}
}
