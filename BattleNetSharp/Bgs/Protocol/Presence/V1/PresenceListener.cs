using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Presence.V1
{
	// Token: 0x0200059D RID: 1437
	public static class PresenceListener
	{
		// Token: 0x060088F5 RID: 35061 RVA: 0x00213E64 File Offset: 0x00212064
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

		// Token: 0x060088F6 RID: 35062 RVA: 0x00213EB0 File Offset: 0x002120B0
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = PresenceListener.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17002B15 RID: 11029
		// (get) Token: 0x060088F7 RID: 35063 RVA: 0x00213EE8 File Offset: 0x002120E8
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return PresenceListenerReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x060088F8 RID: 35064 RVA: 0x00213F0C File Offset: 0x0021210C
		public static ServerServiceDefinition BindService(PresenceListener.PresenceListenerBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<SubscribeNotification, NO_RESPONSE>(PresenceListener.__Method_OnSubscribe, new UnaryServerMethod<SubscribeNotification, NO_RESPONSE>(serviceImpl.OnSubscribe)).AddMethod<StateChangedNotification, NO_RESPONSE>(PresenceListener.__Method_OnStateChanged, new UnaryServerMethod<StateChangedNotification, NO_RESPONSE>(serviceImpl.OnStateChanged))
				.Build();
		}

		// Token: 0x060088F9 RID: 35065 RVA: 0x00213F58 File Offset: 0x00212158
		public static void BindService(ServiceBinderBase serviceBinder, PresenceListener.PresenceListenerBase serviceImpl)
		{
			serviceBinder.AddMethod<SubscribeNotification, NO_RESPONSE>(PresenceListener.__Method_OnSubscribe, (serviceImpl == null) ? null : new UnaryServerMethod<SubscribeNotification, NO_RESPONSE>(serviceImpl.OnSubscribe));
			serviceBinder.AddMethod<StateChangedNotification, NO_RESPONSE>(PresenceListener.__Method_OnStateChanged, (serviceImpl == null) ? null : new UnaryServerMethod<StateChangedNotification, NO_RESPONSE>(serviceImpl.OnStateChanged));
		}

		// Token: 0x04003DF9 RID: 15865
		private static readonly string __ServiceName = "bgs.protocol.presence.v1.PresenceListener";

		// Token: 0x04003DFA RID: 15866
		private static readonly Marshaller<SubscribeNotification> __Marshaller_bgs_protocol_presence_v1_SubscribeNotification = Marshallers.Create<SubscribeNotification>(new Action<SubscribeNotification, SerializationContext>(PresenceListener.__Helper_SerializeMessage), (DeserializationContext context) => PresenceListener.__Helper_DeserializeMessage<SubscribeNotification>(context, SubscribeNotification.Parser));

		// Token: 0x04003DFB RID: 15867
		private static readonly Marshaller<NO_RESPONSE> __Marshaller_bgs_protocol_NO_RESPONSE = Marshallers.Create<NO_RESPONSE>(new Action<NO_RESPONSE, SerializationContext>(PresenceListener.__Helper_SerializeMessage), (DeserializationContext context) => PresenceListener.__Helper_DeserializeMessage<NO_RESPONSE>(context, NO_RESPONSE.Parser));

		// Token: 0x04003DFC RID: 15868
		private static readonly Marshaller<StateChangedNotification> __Marshaller_bgs_protocol_presence_v1_StateChangedNotification = Marshallers.Create<StateChangedNotification>(new Action<StateChangedNotification, SerializationContext>(PresenceListener.__Helper_SerializeMessage), (DeserializationContext context) => PresenceListener.__Helper_DeserializeMessage<StateChangedNotification>(context, StateChangedNotification.Parser));

		// Token: 0x04003DFD RID: 15869
		private static readonly Method<SubscribeNotification, NO_RESPONSE> __Method_OnSubscribe = new Method<SubscribeNotification, NO_RESPONSE>(0, PresenceListener.__ServiceName, "OnSubscribe", PresenceListener.__Marshaller_bgs_protocol_presence_v1_SubscribeNotification, PresenceListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04003DFE RID: 15870
		private static readonly Method<StateChangedNotification, NO_RESPONSE> __Method_OnStateChanged = new Method<StateChangedNotification, NO_RESPONSE>(0, PresenceListener.__ServiceName, "OnStateChanged", PresenceListener.__Marshaller_bgs_protocol_presence_v1_StateChangedNotification, PresenceListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x02001076 RID: 4214
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x040097C9 RID: 38857
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02001077 RID: 4215
		[BindServiceMethod(typeof(PresenceListener), "BindService")]
		public abstract class PresenceListenerBase
		{
			// Token: 0x0600D253 RID: 53843 RVA: 0x004B1CBE File Offset: 0x004AFEBE
			public virtual Task<NO_RESPONSE> OnSubscribe(SubscribeNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D254 RID: 53844 RVA: 0x004B1CD2 File Offset: 0x004AFED2
			public virtual Task<NO_RESPONSE> OnStateChanged(StateChangedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x02001078 RID: 4216
		public class PresenceListenerClient : ClientBase<PresenceListener.PresenceListenerClient>
		{
			// Token: 0x0600D256 RID: 53846 RVA: 0x004B1CEF File Offset: 0x004AFEEF
			public PresenceListenerClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D257 RID: 53847 RVA: 0x004B1CFA File Offset: 0x004AFEFA
			public PresenceListenerClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D258 RID: 53848 RVA: 0x004B1D05 File Offset: 0x004AFF05
			protected PresenceListenerClient()
			{
			}

			// Token: 0x0600D259 RID: 53849 RVA: 0x004B1D0F File Offset: 0x004AFF0F
			protected PresenceListenerClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D25A RID: 53850 RVA: 0x004B1D1C File Offset: 0x004AFF1C
			public virtual NO_RESPONSE OnSubscribe(SubscribeNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSubscribe(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D25B RID: 53851 RVA: 0x004B1D44 File Offset: 0x004AFF44
			public virtual NO_RESPONSE OnSubscribe(SubscribeNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SubscribeNotification, NO_RESPONSE>(PresenceListener.__Method_OnSubscribe, null, options, request);
			}

			// Token: 0x0600D25C RID: 53852 RVA: 0x004B1D6C File Offset: 0x004AFF6C
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSubscribeAsync(SubscribeNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnSubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D25D RID: 53853 RVA: 0x004B1D94 File Offset: 0x004AFF94
			public virtual AsyncUnaryCall<NO_RESPONSE> OnSubscribeAsync(SubscribeNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SubscribeNotification, NO_RESPONSE>(PresenceListener.__Method_OnSubscribe, null, options, request);
			}

			// Token: 0x0600D25E RID: 53854 RVA: 0x004B1DBC File Offset: 0x004AFFBC
			public virtual NO_RESPONSE OnStateChanged(StateChangedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnStateChanged(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D25F RID: 53855 RVA: 0x004B1DE4 File Offset: 0x004AFFE4
			public virtual NO_RESPONSE OnStateChanged(StateChangedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<StateChangedNotification, NO_RESPONSE>(PresenceListener.__Method_OnStateChanged, null, options, request);
			}

			// Token: 0x0600D260 RID: 53856 RVA: 0x004B1E0C File Offset: 0x004B000C
			public virtual AsyncUnaryCall<NO_RESPONSE> OnStateChangedAsync(StateChangedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnStateChangedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D261 RID: 53857 RVA: 0x004B1E34 File Offset: 0x004B0034
			public virtual AsyncUnaryCall<NO_RESPONSE> OnStateChangedAsync(StateChangedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<StateChangedNotification, NO_RESPONSE>(PresenceListener.__Method_OnStateChanged, null, options, request);
			}

			// Token: 0x0600D262 RID: 53858 RVA: 0x004B1E5C File Offset: 0x004B005C
			protected override PresenceListener.PresenceListenerClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new PresenceListener.PresenceListenerClient(configuration);
			}
		}
	}
}
