using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Bgs.Protocol;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Classic.Protocol.External.V1.LimitedTimeEvent
{
	// Token: 0x02000781 RID: 1921
	public static class LimitedTimeEvent
	{
		// Token: 0x0600B066 RID: 45158 RVA: 0x002AF028 File Offset: 0x002AD228
		private static void __Helper_SerializeMessage(IMessage message, SerializationContext context)
		{
			bool flag = message is IBufferMessage;
			if (flag)
			{
				context.SetPayloadLength(message.CalculateSize());
				MessageExtensions.WriteTo(message, context.GetBufferWriter());
				context.Complete();
			}
			else
			{
				context.Complete(MessageExtensions.ToByteArray(message));
			}
		}

		// Token: 0x0600B067 RID: 45159 RVA: 0x002AF074 File Offset: 0x002AD274
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = LimitedTimeEvent.__Helper_MessageCache<T>.IsBufferMessage;
			T t;
			if (isBufferMessage)
			{
				t = parser.ParseFrom(context.PayloadAsReadOnlySequence());
			}
			else
			{
				t = parser.ParseFrom(context.PayloadAsNewBuffer());
			}
			return t;
		}

		// Token: 0x1700368E RID: 13966
		// (get) Token: 0x0600B068 RID: 45160 RVA: 0x002AF0AC File Offset: 0x002AD2AC
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return LimitedTimeEventReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x0600B069 RID: 45161 RVA: 0x002AF0D0 File Offset: 0x002AD2D0
		public static ServerServiceDefinition BindService(LimitedTimeEvent.LimitedTimeEventBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<NoData, NoData>(LimitedTimeEvent.__Method_SetLimitedTimeEventStatus, new UnaryServerMethod<NoData, NoData>(serviceImpl.SetLimitedTimeEventStatus)).Build();
		}

		// Token: 0x0600B06A RID: 45162 RVA: 0x002AF103 File Offset: 0x002AD303
		public static void BindService(ServiceBinderBase serviceBinder, LimitedTimeEvent.LimitedTimeEventBase serviceImpl)
		{
			serviceBinder.AddMethod<NoData, NoData>(LimitedTimeEvent.__Method_SetLimitedTimeEventStatus, (serviceImpl == null) ? null : new UnaryServerMethod<NoData, NoData>(serviceImpl.SetLimitedTimeEventStatus));
		}

		// Token: 0x04004F95 RID: 20373
		private static readonly string __ServiceName = "classic.protocol.external.v1.limited_time_event.LimitedTimeEvent";

		// Token: 0x04004F96 RID: 20374
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(LimitedTimeEvent.__Helper_SerializeMessage), (DeserializationContext context) => LimitedTimeEvent.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04004F97 RID: 20375
		private static readonly Method<NoData, NoData> __Method_SetLimitedTimeEventStatus = new Method<NoData, NoData>(0, LimitedTimeEvent.__ServiceName, "SetLimitedTimeEventStatus", LimitedTimeEvent.__Marshaller_bgs_protocol_NoData, LimitedTimeEvent.__Marshaller_bgs_protocol_NoData);

		// Token: 0x020012A5 RID: 4773
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x040099B7 RID: 39351
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x020012A6 RID: 4774
		[BindServiceMethod(typeof(LimitedTimeEvent), "BindService")]
		public abstract class LimitedTimeEventBase
		{
			// Token: 0x0600DD73 RID: 56691 RVA: 0x004BFEF8 File Offset: 0x004BE0F8
			public virtual Task<NoData> SetLimitedTimeEventStatus(NoData request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x020012A7 RID: 4775
		public class LimitedTimeEventClient : ClientBase<LimitedTimeEvent.LimitedTimeEventClient>
		{
			// Token: 0x0600DD75 RID: 56693 RVA: 0x004BFF15 File Offset: 0x004BE115
			public LimitedTimeEventClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600DD76 RID: 56694 RVA: 0x004BFF20 File Offset: 0x004BE120
			public LimitedTimeEventClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600DD77 RID: 56695 RVA: 0x004BFF2B File Offset: 0x004BE12B
			protected LimitedTimeEventClient()
			{
			}

			// Token: 0x0600DD78 RID: 56696 RVA: 0x004BFF35 File Offset: 0x004BE135
			protected LimitedTimeEventClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600DD79 RID: 56697 RVA: 0x004BFF40 File Offset: 0x004BE140
			public virtual NoData SetLimitedTimeEventStatus(NoData request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SetLimitedTimeEventStatus(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DD7A RID: 56698 RVA: 0x004BFF68 File Offset: 0x004BE168
			public virtual NoData SetLimitedTimeEventStatus(NoData request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<NoData, NoData>(LimitedTimeEvent.__Method_SetLimitedTimeEventStatus, null, options, request);
			}

			// Token: 0x0600DD7B RID: 56699 RVA: 0x004BFF90 File Offset: 0x004BE190
			public virtual AsyncUnaryCall<NoData> SetLimitedTimeEventStatusAsync(NoData request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SetLimitedTimeEventStatusAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DD7C RID: 56700 RVA: 0x004BFFB8 File Offset: 0x004BE1B8
			public virtual AsyncUnaryCall<NoData> SetLimitedTimeEventStatusAsync(NoData request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<NoData, NoData>(LimitedTimeEvent.__Method_SetLimitedTimeEventStatus, null, options, request);
			}

			// Token: 0x0600DD7D RID: 56701 RVA: 0x004BFFE0 File Offset: 0x004BE1E0
			protected override LimitedTimeEvent.LimitedTimeEventClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new LimitedTimeEvent.LimitedTimeEventClient(configuration);
			}
		}
	}
}
