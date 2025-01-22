using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Challenge.V1
{
	// Token: 0x02000527 RID: 1319
	public static class ChallengeListener
	{
		// Token: 0x06008003 RID: 32771 RVA: 0x001F2610 File Offset: 0x001F0810
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

		// Token: 0x06008004 RID: 32772 RVA: 0x001F265C File Offset: 0x001F085C
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = ChallengeListener.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17002888 RID: 10376
		// (get) Token: 0x06008005 RID: 32773 RVA: 0x001F2694 File Offset: 0x001F0894
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return ChallengeServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x06008006 RID: 32774 RVA: 0x001F26B8 File Offset: 0x001F08B8
		public static ServerServiceDefinition BindService(ChallengeListener.ChallengeListenerBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<ChallengeExternalRequest, NO_RESPONSE>(ChallengeListener.__Method_OnExternalChallenge, new UnaryServerMethod<ChallengeExternalRequest, NO_RESPONSE>(serviceImpl.OnExternalChallenge)).AddMethod<ChallengeExternalResult, NO_RESPONSE>(ChallengeListener.__Method_OnExternalChallengeResult, new UnaryServerMethod<ChallengeExternalResult, NO_RESPONSE>(serviceImpl.OnExternalChallengeResult))
				.Build();
		}

		// Token: 0x06008007 RID: 32775 RVA: 0x001F2704 File Offset: 0x001F0904
		public static void BindService(ServiceBinderBase serviceBinder, ChallengeListener.ChallengeListenerBase serviceImpl)
		{
			serviceBinder.AddMethod<ChallengeExternalRequest, NO_RESPONSE>(ChallengeListener.__Method_OnExternalChallenge, (serviceImpl == null) ? null : new UnaryServerMethod<ChallengeExternalRequest, NO_RESPONSE>(serviceImpl.OnExternalChallenge));
			serviceBinder.AddMethod<ChallengeExternalResult, NO_RESPONSE>(ChallengeListener.__Method_OnExternalChallengeResult, (serviceImpl == null) ? null : new UnaryServerMethod<ChallengeExternalResult, NO_RESPONSE>(serviceImpl.OnExternalChallengeResult));
		}

		// Token: 0x04003A20 RID: 14880
		private static readonly string __ServiceName = "bgs.protocol.challenge.v1.ChallengeListener";

		// Token: 0x04003A21 RID: 14881
		private static readonly Marshaller<ChallengeExternalRequest> __Marshaller_bgs_protocol_challenge_v1_ChallengeExternalRequest = Marshallers.Create<ChallengeExternalRequest>(new Action<ChallengeExternalRequest, SerializationContext>(ChallengeListener.__Helper_SerializeMessage), (DeserializationContext context) => ChallengeListener.__Helper_DeserializeMessage<ChallengeExternalRequest>(context, ChallengeExternalRequest.Parser));

		// Token: 0x04003A22 RID: 14882
		private static readonly Marshaller<NO_RESPONSE> __Marshaller_bgs_protocol_NO_RESPONSE = Marshallers.Create<NO_RESPONSE>(new Action<NO_RESPONSE, SerializationContext>(ChallengeListener.__Helper_SerializeMessage), (DeserializationContext context) => ChallengeListener.__Helper_DeserializeMessage<NO_RESPONSE>(context, NO_RESPONSE.Parser));

		// Token: 0x04003A23 RID: 14883
		private static readonly Marshaller<ChallengeExternalResult> __Marshaller_bgs_protocol_challenge_v1_ChallengeExternalResult = Marshallers.Create<ChallengeExternalResult>(new Action<ChallengeExternalResult, SerializationContext>(ChallengeListener.__Helper_SerializeMessage), (DeserializationContext context) => ChallengeListener.__Helper_DeserializeMessage<ChallengeExternalResult>(context, ChallengeExternalResult.Parser));

		// Token: 0x04003A24 RID: 14884
		private static readonly Method<ChallengeExternalRequest, NO_RESPONSE> __Method_OnExternalChallenge = new Method<ChallengeExternalRequest, NO_RESPONSE>(0, ChallengeListener.__ServiceName, "OnExternalChallenge", ChallengeListener.__Marshaller_bgs_protocol_challenge_v1_ChallengeExternalRequest, ChallengeListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x04003A25 RID: 14885
		private static readonly Method<ChallengeExternalResult, NO_RESPONSE> __Method_OnExternalChallengeResult = new Method<ChallengeExternalResult, NO_RESPONSE>(0, ChallengeListener.__ServiceName, "OnExternalChallengeResult", ChallengeListener.__Marshaller_bgs_protocol_challenge_v1_ChallengeExternalResult, ChallengeListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x02000FF1 RID: 4081
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x04009744 RID: 38724
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02000FF2 RID: 4082
		[BindServiceMethod(typeof(ChallengeListener), "BindService")]
		public abstract class ChallengeListenerBase
		{
			// Token: 0x0600D011 RID: 53265 RVA: 0x004AF321 File Offset: 0x004AD521
			public virtual Task<NO_RESPONSE> OnExternalChallenge(ChallengeExternalRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D012 RID: 53266 RVA: 0x004AF335 File Offset: 0x004AD535
			public virtual Task<NO_RESPONSE> OnExternalChallengeResult(ChallengeExternalResult request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x02000FF3 RID: 4083
		public class ChallengeListenerClient : ClientBase<ChallengeListener.ChallengeListenerClient>
		{
			// Token: 0x0600D014 RID: 53268 RVA: 0x004AF352 File Offset: 0x004AD552
			public ChallengeListenerClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D015 RID: 53269 RVA: 0x004AF35D File Offset: 0x004AD55D
			public ChallengeListenerClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D016 RID: 53270 RVA: 0x004AF368 File Offset: 0x004AD568
			protected ChallengeListenerClient()
			{
			}

			// Token: 0x0600D017 RID: 53271 RVA: 0x004AF372 File Offset: 0x004AD572
			protected ChallengeListenerClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D018 RID: 53272 RVA: 0x004AF380 File Offset: 0x004AD580
			public virtual NO_RESPONSE OnExternalChallenge(ChallengeExternalRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnExternalChallenge(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D019 RID: 53273 RVA: 0x004AF3A8 File Offset: 0x004AD5A8
			public virtual NO_RESPONSE OnExternalChallenge(ChallengeExternalRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ChallengeExternalRequest, NO_RESPONSE>(ChallengeListener.__Method_OnExternalChallenge, null, options, request);
			}

			// Token: 0x0600D01A RID: 53274 RVA: 0x004AF3D0 File Offset: 0x004AD5D0
			public virtual AsyncUnaryCall<NO_RESPONSE> OnExternalChallengeAsync(ChallengeExternalRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnExternalChallengeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D01B RID: 53275 RVA: 0x004AF3F8 File Offset: 0x004AD5F8
			public virtual AsyncUnaryCall<NO_RESPONSE> OnExternalChallengeAsync(ChallengeExternalRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ChallengeExternalRequest, NO_RESPONSE>(ChallengeListener.__Method_OnExternalChallenge, null, options, request);
			}

			// Token: 0x0600D01C RID: 53276 RVA: 0x004AF420 File Offset: 0x004AD620
			public virtual NO_RESPONSE OnExternalChallengeResult(ChallengeExternalResult request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnExternalChallengeResult(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D01D RID: 53277 RVA: 0x004AF448 File Offset: 0x004AD648
			public virtual NO_RESPONSE OnExternalChallengeResult(ChallengeExternalResult request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<ChallengeExternalResult, NO_RESPONSE>(ChallengeListener.__Method_OnExternalChallengeResult, null, options, request);
			}

			// Token: 0x0600D01E RID: 53278 RVA: 0x004AF470 File Offset: 0x004AD670
			public virtual AsyncUnaryCall<NO_RESPONSE> OnExternalChallengeResultAsync(ChallengeExternalResult request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnExternalChallengeResultAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D01F RID: 53279 RVA: 0x004AF498 File Offset: 0x004AD698
			public virtual AsyncUnaryCall<NO_RESPONSE> OnExternalChallengeResultAsync(ChallengeExternalResult request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<ChallengeExternalResult, NO_RESPONSE>(ChallengeListener.__Method_OnExternalChallengeResult, null, options, request);
			}

			// Token: 0x0600D020 RID: 53280 RVA: 0x004AF4C0 File Offset: 0x004AD6C0
			protected override ChallengeListener.ChallengeListenerClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new ChallengeListener.ChallengeListenerClient(configuration);
			}
		}
	}
}
