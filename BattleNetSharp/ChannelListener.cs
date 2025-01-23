using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.Channel.V2;
using Grpc.Core;

namespace BattleNetSharp
{
	// Token: 0x02000AD9 RID: 2777
	public class ChannelListener : Bgs.Protocol.Channel.V2.ChannelListener.ChannelListenerBase, IServiceListener
	{
		// Token: 0x0600BCB1 RID: 48305 RVA: 0x004834C4 File Offset: 0x004816C4
		public override Task<NO_RESPONSE> OnAttributeChanged(AttributeChangedNotification request, ServerCallContext context)
		{
			return base.OnAttributeChanged(request, context);
		}

		// Token: 0x0600BCB2 RID: 48306 RVA: 0x004834E0 File Offset: 0x004816E0
		public override Task<NO_RESPONSE> OnInvitationAdded(InvitationAddedNotification request, ServerCallContext context)
		{
			return base.OnInvitationAdded(request, context);
		}

		// Token: 0x0600BCB3 RID: 48307 RVA: 0x004834FC File Offset: 0x004816FC
		public override Task<NO_RESPONSE> OnInvitationRemoved(InvitationRemovedNotification request, ServerCallContext context)
		{
			return base.OnInvitationRemoved(request, context);
		}

		// Token: 0x0600BCB4 RID: 48308 RVA: 0x00483518 File Offset: 0x00481718
		public override Task<NO_RESPONSE> OnMemberAdded(MemberAddedNotification request, ServerCallContext context)
		{
			return base.OnMemberAdded(request, context);
		}

		// Token: 0x0600BCB5 RID: 48309 RVA: 0x00483534 File Offset: 0x00481734
		public override Task<NO_RESPONSE> OnMemberAttributeChanged(MemberAttributeChangedNotification request, ServerCallContext context)
		{
			return base.OnMemberAttributeChanged(request, context);
		}

		// Token: 0x0600BCB6 RID: 48310 RVA: 0x00483550 File Offset: 0x00481750
		public override Task<NO_RESPONSE> OnMemberRemoved(MemberRemovedNotification request, ServerCallContext context)
		{
			return base.OnMemberRemoved(request, context);
		}

		// Token: 0x0600BCB7 RID: 48311 RVA: 0x0048356C File Offset: 0x0048176C
		public override Task<NO_RESPONSE> OnMemberRoleChanged(MemberRoleChangedNotification request, ServerCallContext context)
		{
			return base.OnMemberRoleChanged(request, context);
		}

		// Token: 0x0600BCB8 RID: 48312 RVA: 0x00483588 File Offset: 0x00481788
		public override Task<NO_RESPONSE> OnPrivacyLevelChanged(PrivacyLevelChangedNotification request, ServerCallContext context)
		{
			return base.OnPrivacyLevelChanged(request, context);
		}

		// Token: 0x0600BCB9 RID: 48313 RVA: 0x004835A4 File Offset: 0x004817A4
		public override Task<NO_RESPONSE> OnSendMessage(SendMessageNotification request, ServerCallContext context)
		{
			return base.OnSendMessage(request, context);
		}

		// Token: 0x0600BCBA RID: 48314 RVA: 0x004835C0 File Offset: 0x004817C0
		public override Task<NO_RESPONSE> OnSuggestionAdded(SuggestionAddedNotification request, ServerCallContext context)
		{
			return base.OnSuggestionAdded(request, context);
		}

		// Token: 0x0600BCBB RID: 48315 RVA: 0x004835DC File Offset: 0x004817DC
		public override Task<NO_RESPONSE> OnTypingIndicator(TypingIndicatorNotification request, ServerCallContext context)
		{
			return base.OnTypingIndicator(request, context);
		}
	}
}
