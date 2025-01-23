using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.Presence.V2;
using Grpc.Core;

namespace BattleNetSharp
{
	// Token: 0x02000AE0 RID: 2784
	public class PresenceV2Listener : Bgs.Protocol.Presence.V2.PresenceListener.PresenceListenerBase, IServiceListener
	{
		// Token: 0x0600BCE7 RID: 48359 RVA: 0x004840F0 File Offset: 0x004822F0
		public override Task<NO_RESPONSE> OnPresenceStateUpdated(PresenceStateUpdatedNotification request, ServerCallContext context)
		{
			return base.OnPresenceStateUpdated(request, context);
		}

		// Token: 0x0600BCE8 RID: 48360 RVA: 0x0048410C File Offset: 0x0048230C
		public override Task<NO_RESPONSE> OnSubscribeFailure(SubscribeFailureNotification request, ServerCallContext context)
		{
			return base.OnSubscribeFailure(request, context);
		}
	}
}
