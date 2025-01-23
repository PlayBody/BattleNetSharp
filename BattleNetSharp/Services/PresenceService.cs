using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.Account.V1;
using Bgs.Protocol.Presence.V1;
using Grpc.Core;

namespace BattleNetSharp.Services
{
	// Token: 0x02000AFC RID: 2812
	public class PresenceService : Bgs.Protocol.Presence.V1.PresenceService.PresenceServiceBase, IServiceListener
	{
		// Token: 0x0600BDC0 RID: 48576 RVA: 0x004873F8 File Offset: 0x004855F8
		public override Task<BatchSubscribeResponse> BatchSubscribe(BatchSubscribeRequest request, ServerCallContext context)
		{
			return Task.FromResult<BatchSubscribeResponse>(new BatchSubscribeResponse());
		}

		// Token: 0x0600BDC1 RID: 48577 RVA: 0x00487414 File Offset: 0x00485614
		public override Task<NoData> BatchUnsubscribe(BatchUnsubscribeRequest request, ServerCallContext context)
		{
			return base.BatchUnsubscribe(request, context);
		}

		// Token: 0x0600BDC2 RID: 48578 RVA: 0x00487430 File Offset: 0x00485630
		public override Task<NoData> Ownership(OwnershipRequest request, ServerCallContext context)
		{
			return base.Ownership(request, context);
		}

		// Token: 0x0600BDC3 RID: 48579 RVA: 0x0048744C File Offset: 0x0048564C
		public override Task<QueryResponse> Query(QueryRequest request, ServerCallContext context)
		{
			return base.Query(request, context);
		}

		// Token: 0x0600BDC4 RID: 48580 RVA: 0x00487468 File Offset: 0x00485668
		public override Task<NoData> Subscribe(SubscribeRequest request, ServerCallContext context)
		{
			return base.Subscribe(request, context);
		}

		// Token: 0x0600BDC5 RID: 48581 RVA: 0x00487484 File Offset: 0x00485684
		public override Task<NoData> SubscribeNotification(SubscribeNotificationRequest request, ServerCallContext context)
		{
			return base.SubscribeNotification(request, context);
		}

		// Token: 0x0600BDC6 RID: 48582 RVA: 0x004874A0 File Offset: 0x004856A0
		public override Task<NoData> Unsubscribe(UnsubscribeRequest request, ServerCallContext context)
		{
			return base.Unsubscribe(request, context);
		}

		// Token: 0x0600BDC7 RID: 48583 RVA: 0x004874BC File Offset: 0x004856BC
		public override Task<NoData> Update(UpdateRequest request, ServerCallContext context)
		{
			StateChangedNotification stateChangedNotification = new StateChangedNotification
			{
				SubscriberId = new AccountId
				{
					Id = D2RBGS.BGSConnections[((ConnectionContext)context).Caller].AccountLow
				}
			};
			stateChangedNotification.State.Add(new PresenceState
			{
				EntityId = new EntityId
				{
					High = D2RBGS.BGSConnections[((ConnectionContext)context).Caller].GameAccountHigh,
					Low = (ulong)D2RBGS.BGSConnections[((ConnectionContext)context).Caller].GameAccountLow
				}
			});
			foreach (FieldOperation fieldOperation in request.FieldOperation)
			{
				stateChangedNotification.State[0].FieldOperation.Add(new FieldOperation
				{
					Field = new Field
					{
						Key = new FieldKey
						{
							Program = fieldOperation.Field.Key.Program,
							Group = fieldOperation.Field.Key.Group,
							Field = fieldOperation.Field.Key.Field,
							UniqueId = 0UL
						},
						Value = fieldOperation.Field.Value
					},
					Operation = (fieldOperation.HasOperation ? fieldOperation.Operation : FieldOperation.Types.OperationType.Set)
				});
			}
			return Task.FromResult<NoData>(new NoData());
		}
	}
}
