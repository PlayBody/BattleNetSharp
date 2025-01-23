using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Whisper.V1
{
	// Token: 0x020003A1 RID: 929
	public static class WhisperListener
	{
		// Token: 0x06005E03 RID: 24067 RVA: 0x0016BEF8 File Offset: 0x0016A0F8
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

		// Token: 0x06005E04 RID: 24068 RVA: 0x0016BF44 File Offset: 0x0016A144
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = WhisperListener.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17001E7B RID: 7803
		// (get) Token: 0x06005E05 RID: 24069 RVA: 0x0016BF7C File Offset: 0x0016A17C
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return WhisperListenerReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x06005E06 RID: 24070 RVA: 0x0016BFA0 File Offset: 0x0016A1A0
		public static ServerServiceDefinition BindService(WhisperListener.WhisperListenerBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<WhisperNotification, NO_RESPONSE>(WhisperListener.__Method_OnWhisper, new UnaryServerMethod<WhisperNotification, NO_RESPONSE>(serviceImpl.OnWhisper)).AddMethod<WhisperEchoNotification, NO_RESPONSE>(WhisperListener.__Method_OnWhisperEcho, new UnaryServerMethod<WhisperEchoNotification, NO_RESPONSE>(serviceImpl.OnWhisperEcho))
				.AddMethod<TypingIndicatorNotification, NO_RESPONSE>(WhisperListener.__Method_OnTypingIndicatorUpdate, new UnaryServerMethod<TypingIndicatorNotification, NO_RESPONSE>(serviceImpl.OnTypingIndicatorUpdate))
				.AddMethod<AdvanceViewTimeNotification, NO_RESPONSE>(WhisperListener.__Method_OnAdvanceViewTime, new UnaryServerMethod<AdvanceViewTimeNotification, NO_RESPONSE>(serviceImpl.OnAdvanceViewTime))
				.AddMethod<WhisperUpdatedNotification, NO_RESPONSE>(WhisperListener.__Method_OnWhisperUpdated, new UnaryServerMethod<WhisperUpdatedNotification, NO_RESPONSE>(serviceImpl.OnWhisperUpdated))
				.AddMethod<AdvanceClearTimeNotification, NO_RESPONSE>(WhisperListener.__Method_OnAdvanceClearTime, new UnaryServerMethod<AdvanceClearTimeNotification, NO_RESPONSE>(serviceImpl.OnAdvanceClearTime))
				.Build();
		}

		// Token: 0x06005E07 RID: 24071 RVA: 0x0016C048 File Offset: 0x0016A248
		public static void BindService(ServiceBinderBase serviceBinder, WhisperListener.WhisperListenerBase serviceImpl)
		{
			serviceBinder.AddMethod<WhisperNotification, NO_RESPONSE>(WhisperListener.__Method_OnWhisper, (serviceImpl == null) ? null : new UnaryServerMethod<WhisperNotification, NO_RESPONSE>(serviceImpl.OnWhisper));
			serviceBinder.AddMethod<WhisperEchoNotification, NO_RESPONSE>(WhisperListener.__Method_OnWhisperEcho, (serviceImpl == null) ? null : new UnaryServerMethod<WhisperEchoNotification, NO_RESPONSE>(serviceImpl.OnWhisperEcho));
			serviceBinder.AddMethod<TypingIndicatorNotification, NO_RESPONSE>(WhisperListener.__Method_OnTypingIndicatorUpdate, (serviceImpl == null) ? null : new UnaryServerMethod<TypingIndicatorNotification, NO_RESPONSE>(serviceImpl.OnTypingIndicatorUpdate));
			serviceBinder.AddMethod<AdvanceViewTimeNotification, NO_RESPONSE>(WhisperListener.__Method_OnAdvanceViewTime, (serviceImpl == null) ? null : new UnaryServerMethod<AdvanceViewTimeNotification, NO_RESPONSE>(serviceImpl.OnAdvanceViewTime));
			serviceBinder.AddMethod<WhisperUpdatedNotification, NO_RESPONSE>(WhisperListener.__Method_OnWhisperUpdated, (serviceImpl == null) ? null : new UnaryServerMethod<WhisperUpdatedNotification, NO_RESPONSE>(serviceImpl.OnWhisperUpdated));
			serviceBinder.AddMethod<AdvanceClearTimeNotification, NO_RESPONSE>(WhisperListener.__Method_OnAdvanceClearTime, (serviceImpl == null) ? null : new UnaryServerMethod<AdvanceClearTimeNotification, NO_RESPONSE>(serviceImpl.OnAdvanceClearTime));
		}

		// Token: 0x04002B05 RID: 11013
		private static readonly string __ServiceName = "bgs.protocol.whisper.v1.WhisperListener";

		// Token: 0x04002B06 RID: 11014
		private static readonly Marshaller<WhisperNotification> __Marshaller_bgs_protocol_whisper_v1_WhisperNotification = Marshallers.Create<WhisperNotification>(new Action<WhisperNotification, SerializationContext>(WhisperListener.__Helper_SerializeMessage), (DeserializationContext context) => WhisperListener.__Helper_DeserializeMessage<WhisperNotification>(context, WhisperNotification.Parser));

		// Token: 0x04002B07 RID: 11015
		private static readonly Marshaller<NO_RESPONSE> __Marshaller_bgs_protocol_NO_RESPONSE = Marshallers.Create<NO_RESPONSE>(new Action<NO_RESPONSE, SerializationContext>(WhisperListener.__Helper_SerializeMessage), (DeserializationContext context) => WhisperListener.__Helper_DeserializeMessage<NO_RESPONSE>(context, NO_RESPONSE.Parser));

		// Token: 0x04002B08 RID: 11016
		private static readonly Marshaller<WhisperEchoNotification> __Marshaller_bgs_protocol_whisper_v1_WhisperEchoNotification = Marshallers.Create<WhisperEchoNotification>(new Action<WhisperEchoNotification, SerializationContext>(WhisperListener.__Helper_SerializeMessage), (DeserializationContext context) => WhisperListener.__Helper_DeserializeMessage<WhisperEchoNotification>(context, WhisperEchoNotification.Parser));

		// Token: 0x04002B09 RID: 11017
		private static readonly Marshaller<TypingIndicatorNotification> __Marshaller_bgs_protocol_whisper_v1_TypingIndicatorNotification = Marshallers.Create<TypingIndicatorNotification>(new Action<TypingIndicatorNotification, SerializationContext>(WhisperListener.__Helper_SerializeMessage), (DeserializationContext context) => WhisperListener.__Helper_DeserializeMessage<TypingIndicatorNotification>(context, TypingIndicatorNotification.Parser));

		// Token: 0x04002B0A RID: 11018
		private static readonly Marshaller<AdvanceViewTimeNotification> __Marshaller_bgs_protocol_whisper_v1_AdvanceViewTimeNotification = Marshallers.Create<AdvanceViewTimeNotification>(new Action<AdvanceViewTimeNotification, SerializationContext>(WhisperListener.__Helper_SerializeMessage), (DeserializationContext context) => WhisperListener.__Helper_DeserializeMessage<AdvanceViewTimeNotification>(context, AdvanceViewTimeNotification.Parser));

		// Token: 0x04002B0B RID: 11019
		private static readonly Marshaller<WhisperUpdatedNotification> __Marshaller_bgs_protocol_whisper_v1_WhisperUpdatedNotification = Marshallers.Create<WhisperUpdatedNotification>(new Action<WhisperUpdatedNotification, SerializationContext>(WhisperListener.__Helper_SerializeMessage), (DeserializationContext context) => WhisperListener.__Helper_DeserializeMessage<WhisperUpdatedNotification>(context, WhisperUpdatedNotification.Parser));

		// Token: 0x04002B0C RID: 11020
		private static readonly Marshaller<AdvanceClearTimeNotification> __Marshaller_bgs_protocol_whisper_v1_AdvanceClearTimeNotification = Marshallers.Create<AdvanceClearTimeNotification>(new Action<AdvanceClearTimeNotification, SerializationContext>(WhisperListener.__Helper_SerializeMessage), (DeserializationContext context) => WhisperListener.__Helper_DeserializeMessage<AdvanceClearTimeNotification>(context, AdvanceClearTimeNotification.Parser));

		// Token: 0x04002B0D RID: 11021
		private static readonly Method<WhisperNotification, NO_RESPONSE> __Method_OnWhisper = new Method<WhisperNotification, NO_RESPONSE>(0, WhisperListener.__ServiceName, "OnWhisper", WhisperListener.__Marshaller_bgs_protocol_whisper_v1_WhisperNotification, WhisperListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04002B0E RID: 11022
		private static readonly Method<WhisperEchoNotification, NO_RESPONSE> __Method_OnWhisperEcho = new Method<WhisperEchoNotification, NO_RESPONSE>(0, WhisperListener.__ServiceName, "OnWhisperEcho", WhisperListener.__Marshaller_bgs_protocol_whisper_v1_WhisperEchoNotification, WhisperListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04002B0F RID: 11023
		private static readonly Method<TypingIndicatorNotification, NO_RESPONSE> __Method_OnTypingIndicatorUpdate = new Method<TypingIndicatorNotification, NO_RESPONSE>(0, WhisperListener.__ServiceName, "OnTypingIndicatorUpdate", WhisperListener.__Marshaller_bgs_protocol_whisper_v1_TypingIndicatorNotification, WhisperListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04002B10 RID: 11024
		private static readonly Method<AdvanceViewTimeNotification, NO_RESPONSE> __Method_OnAdvanceViewTime = new Method<AdvanceViewTimeNotification, NO_RESPONSE>(0, WhisperListener.__ServiceName, "OnAdvanceViewTime", WhisperListener.__Marshaller_bgs_protocol_whisper_v1_AdvanceViewTimeNotification, WhisperListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04002B11 RID: 11025
		private static readonly Method<WhisperUpdatedNotification, NO_RESPONSE> __Method_OnWhisperUpdated = new Method<WhisperUpdatedNotification, NO_RESPONSE>(0, WhisperListener.__ServiceName, "OnWhisperUpdated", WhisperListener.__Marshaller_bgs_protocol_whisper_v1_WhisperUpdatedNotification, WhisperListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04002B12 RID: 11026
		private static readonly Method<AdvanceClearTimeNotification, NO_RESPONSE> __Method_OnAdvanceClearTime = new Method<AdvanceClearTimeNotification, NO_RESPONSE>(0, WhisperListener.__ServiceName, "OnAdvanceClearTime", WhisperListener.__Marshaller_bgs_protocol_whisper_v1_AdvanceClearTimeNotification, WhisperListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x02000E6A RID: 3690
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x040095DC RID: 38364
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02000E6B RID: 3691
		[BindServiceMethod(typeof(WhisperListener), "BindService")]
		public abstract class WhisperListenerBase
		{
			// Token: 0x0600C980 RID: 51584 RVA: 0x004A83CC File Offset: 0x004A65CC
			public virtual Task<NO_RESPONSE> OnWhisper(WhisperNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600C981 RID: 51585 RVA: 0x004A83E0 File Offset: 0x004A65E0
			public virtual Task<NO_RESPONSE> OnWhisperEcho(WhisperEchoNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600C982 RID: 51586 RVA: 0x004A83F4 File Offset: 0x004A65F4
			public virtual Task<NO_RESPONSE> OnTypingIndicatorUpdate(TypingIndicatorNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600C983 RID: 51587 RVA: 0x004A8408 File Offset: 0x004A6608
			public virtual Task<NO_RESPONSE> OnAdvanceViewTime(AdvanceViewTimeNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600C984 RID: 51588 RVA: 0x004A841C File Offset: 0x004A661C
			public virtual Task<NO_RESPONSE> OnWhisperUpdated(WhisperUpdatedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600C985 RID: 51589 RVA: 0x004A8430 File Offset: 0x004A6630
			public virtual Task<NO_RESPONSE> OnAdvanceClearTime(AdvanceClearTimeNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x02000E6C RID: 3692
		public class WhisperListenerClient : ClientBase<WhisperListener.WhisperListenerClient>
		{
			// Token: 0x0600C987 RID: 51591 RVA: 0x004A844D File Offset: 0x004A664D
			public WhisperListenerClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600C988 RID: 51592 RVA: 0x004A8458 File Offset: 0x004A6658
			public WhisperListenerClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600C989 RID: 51593 RVA: 0x004A8463 File Offset: 0x004A6663
			protected WhisperListenerClient()
			{
			}

			// Token: 0x0600C98A RID: 51594 RVA: 0x004A846D File Offset: 0x004A666D
			protected WhisperListenerClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600C98B RID: 51595 RVA: 0x004A8478 File Offset: 0x004A6678
			public virtual NO_RESPONSE OnWhisper(WhisperNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnWhisper(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600C98C RID: 51596 RVA: 0x004A84A0 File Offset: 0x004A66A0
			public virtual NO_RESPONSE OnWhisper(WhisperNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<WhisperNotification, NO_RESPONSE>(WhisperListener.__Method_OnWhisper, null, options, request);
			}

			// Token: 0x0600C98D RID: 51597 RVA: 0x004A84C8 File Offset: 0x004A66C8
			public virtual AsyncUnaryCall<NO_RESPONSE> OnWhisperAsync(WhisperNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnWhisperAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600C98E RID: 51598 RVA: 0x004A84F0 File Offset: 0x004A66F0
			public virtual AsyncUnaryCall<NO_RESPONSE> OnWhisperAsync(WhisperNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<WhisperNotification, NO_RESPONSE>(WhisperListener.__Method_OnWhisper, null, options, request);
			}

			// Token: 0x0600C98F RID: 51599 RVA: 0x004A8518 File Offset: 0x004A6718
			public virtual NO_RESPONSE OnWhisperEcho(WhisperEchoNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnWhisperEcho(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600C990 RID: 51600 RVA: 0x004A8540 File Offset: 0x004A6740
			public virtual NO_RESPONSE OnWhisperEcho(WhisperEchoNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<WhisperEchoNotification, NO_RESPONSE>(WhisperListener.__Method_OnWhisperEcho, null, options, request);
			}

			// Token: 0x0600C991 RID: 51601 RVA: 0x004A8568 File Offset: 0x004A6768
			public virtual AsyncUnaryCall<NO_RESPONSE> OnWhisperEchoAsync(WhisperEchoNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnWhisperEchoAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600C992 RID: 51602 RVA: 0x004A8590 File Offset: 0x004A6790
			public virtual AsyncUnaryCall<NO_RESPONSE> OnWhisperEchoAsync(WhisperEchoNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<WhisperEchoNotification, NO_RESPONSE>(WhisperListener.__Method_OnWhisperEcho, null, options, request);
			}

			// Token: 0x0600C993 RID: 51603 RVA: 0x004A85B8 File Offset: 0x004A67B8
			public virtual NO_RESPONSE OnTypingIndicatorUpdate(TypingIndicatorNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnTypingIndicatorUpdate(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600C994 RID: 51604 RVA: 0x004A85E0 File Offset: 0x004A67E0
			public virtual NO_RESPONSE OnTypingIndicatorUpdate(TypingIndicatorNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<TypingIndicatorNotification, NO_RESPONSE>(WhisperListener.__Method_OnTypingIndicatorUpdate, null, options, request);
			}

			// Token: 0x0600C995 RID: 51605 RVA: 0x004A8608 File Offset: 0x004A6808
			public virtual AsyncUnaryCall<NO_RESPONSE> OnTypingIndicatorUpdateAsync(TypingIndicatorNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnTypingIndicatorUpdateAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600C996 RID: 51606 RVA: 0x004A8630 File Offset: 0x004A6830
			public virtual AsyncUnaryCall<NO_RESPONSE> OnTypingIndicatorUpdateAsync(TypingIndicatorNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<TypingIndicatorNotification, NO_RESPONSE>(WhisperListener.__Method_OnTypingIndicatorUpdate, null, options, request);
			}

			// Token: 0x0600C997 RID: 51607 RVA: 0x004A8658 File Offset: 0x004A6858
			public virtual NO_RESPONSE OnAdvanceViewTime(AdvanceViewTimeNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnAdvanceViewTime(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600C998 RID: 51608 RVA: 0x004A8680 File Offset: 0x004A6880
			public virtual NO_RESPONSE OnAdvanceViewTime(AdvanceViewTimeNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<AdvanceViewTimeNotification, NO_RESPONSE>(WhisperListener.__Method_OnAdvanceViewTime, null, options, request);
			}

			// Token: 0x0600C999 RID: 51609 RVA: 0x004A86A8 File Offset: 0x004A68A8
			public virtual AsyncUnaryCall<NO_RESPONSE> OnAdvanceViewTimeAsync(AdvanceViewTimeNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnAdvanceViewTimeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600C99A RID: 51610 RVA: 0x004A86D0 File Offset: 0x004A68D0
			public virtual AsyncUnaryCall<NO_RESPONSE> OnAdvanceViewTimeAsync(AdvanceViewTimeNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<AdvanceViewTimeNotification, NO_RESPONSE>(WhisperListener.__Method_OnAdvanceViewTime, null, options, request);
			}

			// Token: 0x0600C99B RID: 51611 RVA: 0x004A86F8 File Offset: 0x004A68F8
			public virtual NO_RESPONSE OnWhisperUpdated(WhisperUpdatedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnWhisperUpdated(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600C99C RID: 51612 RVA: 0x004A8720 File Offset: 0x004A6920
			public virtual NO_RESPONSE OnWhisperUpdated(WhisperUpdatedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<WhisperUpdatedNotification, NO_RESPONSE>(WhisperListener.__Method_OnWhisperUpdated, null, options, request);
			}

			// Token: 0x0600C99D RID: 51613 RVA: 0x004A8748 File Offset: 0x004A6948
			public virtual AsyncUnaryCall<NO_RESPONSE> OnWhisperUpdatedAsync(WhisperUpdatedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnWhisperUpdatedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600C99E RID: 51614 RVA: 0x004A8770 File Offset: 0x004A6970
			public virtual AsyncUnaryCall<NO_RESPONSE> OnWhisperUpdatedAsync(WhisperUpdatedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<WhisperUpdatedNotification, NO_RESPONSE>(WhisperListener.__Method_OnWhisperUpdated, null, options, request);
			}

			// Token: 0x0600C99F RID: 51615 RVA: 0x004A8798 File Offset: 0x004A6998
			public virtual NO_RESPONSE OnAdvanceClearTime(AdvanceClearTimeNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnAdvanceClearTime(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600C9A0 RID: 51616 RVA: 0x004A87C0 File Offset: 0x004A69C0
			public virtual NO_RESPONSE OnAdvanceClearTime(AdvanceClearTimeNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<AdvanceClearTimeNotification, NO_RESPONSE>(WhisperListener.__Method_OnAdvanceClearTime, null, options, request);
			}

			// Token: 0x0600C9A1 RID: 51617 RVA: 0x004A87E8 File Offset: 0x004A69E8
			public virtual AsyncUnaryCall<NO_RESPONSE> OnAdvanceClearTimeAsync(AdvanceClearTimeNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnAdvanceClearTimeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600C9A2 RID: 51618 RVA: 0x004A8810 File Offset: 0x004A6A10
			public virtual AsyncUnaryCall<NO_RESPONSE> OnAdvanceClearTimeAsync(AdvanceClearTimeNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<AdvanceClearTimeNotification, NO_RESPONSE>(WhisperListener.__Method_OnAdvanceClearTime, null, options, request);
			}

			// Token: 0x0600C9A3 RID: 51619 RVA: 0x004A8838 File Offset: 0x004A6A38
			protected override WhisperListener.WhisperListenerClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new WhisperListener.WhisperListenerClient(configuration);
			}
		}
	}
}
