using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.Notification.V2.Client;
using Grpc.Core;

namespace BattleNetSharp
{
	// Token: 0x02000ADE RID: 2782
	public class NotificationListener : NotificationListener.NotificationListenerBase, IServiceListener
	{
		// Token: 0x0600BCE2 RID: 48354 RVA: 0x0048406C File Offset: 0x0048226C
		public override Task<NO_RESPONSE> OnNotificationReceived(NotificationReceivedNotification request, ServerCallContext context)
		{
			this.Notifications.Add(request);
			return Task.FromResult<NO_RESPONSE>(new NO_RESPONSE());
		}

		// Token: 0x04009158 RID: 37208
		public List<NotificationReceivedNotification> Notifications = new List<NotificationReceivedNotification>();
	}
}
