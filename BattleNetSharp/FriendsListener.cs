using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.Friends.V1;
using Grpc.Core;

namespace BattleNetSharp
{
	// Token: 0x02000ADC RID: 2780
	public class FriendsListener : FriendsListener.FriendsListenerBase, IServiceListener
	{
		// Token: 0x0600BCD1 RID: 48337 RVA: 0x0048370C File Offset: 0x0048190C
		public override Task<NO_RESPONSE> OnFriendAdded(FriendNotification request, ServerCallContext context)
		{
			return base.OnFriendAdded(request, context);
		}

		// Token: 0x0600BCD2 RID: 48338 RVA: 0x00483728 File Offset: 0x00481928
		public override Task<NO_RESPONSE> OnFriendRemoved(FriendNotification request, ServerCallContext context)
		{
			return base.OnFriendRemoved(request, context);
		}

		// Token: 0x0600BCD3 RID: 48339 RVA: 0x00483744 File Offset: 0x00481944
		public override Task<NO_RESPONSE> OnReceivedInvitationAdded(InvitationNotification request, ServerCallContext context)
		{
			return base.OnReceivedInvitationAdded(request, context);
		}

		// Token: 0x0600BCD4 RID: 48340 RVA: 0x00483760 File Offset: 0x00481960
		public override Task<NO_RESPONSE> OnReceivedInvitationRemoved(InvitationNotification request, ServerCallContext context)
		{
			return base.OnReceivedInvitationRemoved(request, context);
		}

		// Token: 0x0600BCD5 RID: 48341 RVA: 0x0048377C File Offset: 0x0048197C
		public override Task<NO_RESPONSE> OnSentInvitationAdded(SentInvitationAddedNotification request, ServerCallContext context)
		{
			return base.OnSentInvitationAdded(request, context);
		}

		// Token: 0x0600BCD6 RID: 48342 RVA: 0x00483798 File Offset: 0x00481998
		public override Task<NO_RESPONSE> OnSentInvitationRemoved(SentInvitationRemovedNotification request, ServerCallContext context)
		{
			return base.OnSentInvitationRemoved(request, context);
		}

		// Token: 0x0600BCD7 RID: 48343 RVA: 0x004837B4 File Offset: 0x004819B4
		public override Task<NO_RESPONSE> OnUpdateFriendState(UpdateFriendStateNotification request, ServerCallContext context)
		{
			return base.OnUpdateFriendState(request, context);
		}
	}
}
