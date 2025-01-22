using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.Channel.V2.Membership;
using Grpc.Core;

namespace BattleNetSharp
{
	// Token: 0x02000ADA RID: 2778
	public class ChannelMembershipListener : ChannelMembershipListener.ChannelMembershipListenerBase, IServiceListener
	{
		// Token: 0x0600BCBD RID: 48317 RVA: 0x00483600 File Offset: 0x00481800
		public override Task<NO_RESPONSE> OnChannelAdded(ChannelAddedNotification request, ServerCallContext context)
		{
			return base.OnChannelAdded(request, context);
		}

		// Token: 0x0600BCBE RID: 48318 RVA: 0x0048361C File Offset: 0x0048181C
		public override Task<NO_RESPONSE> OnChannelRemoved(ChannelRemovedNotification request, ServerCallContext context)
		{
			return base.OnChannelRemoved(request, context);
		}

		// Token: 0x0600BCBF RID: 48319 RVA: 0x00483638 File Offset: 0x00481838
		public override Task<NO_RESPONSE> OnReceivedInvitationAdded(ReceivedInvitationAddedNotification request, ServerCallContext context)
		{
			return base.OnReceivedInvitationAdded(request, context);
		}

		// Token: 0x0600BCC0 RID: 48320 RVA: 0x00483654 File Offset: 0x00481854
		public override Task<NO_RESPONSE> OnReceivedInvitationRemoved(ReceivedInvitationRemovedNotification request, ServerCallContext context)
		{
			return base.OnReceivedInvitationRemoved(request, context);
		}
	}
}
