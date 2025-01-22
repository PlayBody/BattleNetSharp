using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Publication.V2.Client
{
	// Token: 0x02000593 RID: 1427
	public static class PublicationService
	{
		// Token: 0x06008855 RID: 34901 RVA: 0x00211C78 File Offset: 0x0020FE78
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

		// Token: 0x06008856 RID: 34902 RVA: 0x00211CC4 File Offset: 0x0020FEC4
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = PublicationService.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17002AEC RID: 10988
		// (get) Token: 0x06008857 RID: 34903 RVA: 0x00211CFC File Offset: 0x0020FEFC
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return PublicationServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x06008858 RID: 34904 RVA: 0x00211D20 File Offset: 0x0020FF20
		public static ServerServiceDefinition BindService(PublicationService.PublicationServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<SubscribeRequest, SubscribeResponse>(PublicationService.__Method_Subscribe, new UnaryServerMethod<SubscribeRequest, SubscribeResponse>(serviceImpl.Subscribe)).AddMethod<UnsubscribeRequest, NoData>(PublicationService.__Method_Unsubscribe, new UnaryServerMethod<UnsubscribeRequest, NoData>(serviceImpl.Unsubscribe))
				.Build();
		}

		// Token: 0x06008859 RID: 34905 RVA: 0x00211D6C File Offset: 0x0020FF6C
		public static void BindService(ServiceBinderBase serviceBinder, PublicationService.PublicationServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<SubscribeRequest, SubscribeResponse>(PublicationService.__Method_Subscribe, (serviceImpl == null) ? null : new UnaryServerMethod<SubscribeRequest, SubscribeResponse>(serviceImpl.Subscribe));
			serviceBinder.AddMethod<UnsubscribeRequest, NoData>(PublicationService.__Method_Unsubscribe, (serviceImpl == null) ? null : new UnaryServerMethod<UnsubscribeRequest, NoData>(serviceImpl.Unsubscribe));
		}

		// Token: 0x04003DBF RID: 15807
		private static readonly string __ServiceName = "bgs.protocol.publication.v2.client.PublicationService";

		// Token: 0x04003DC0 RID: 15808
		private static readonly Marshaller<SubscribeRequest> __Marshaller_bgs_protocol_publication_v2_client_SubscribeRequest = Marshallers.Create<SubscribeRequest>(new Action<SubscribeRequest, SerializationContext>(PublicationService.__Helper_SerializeMessage), (DeserializationContext context) => PublicationService.__Helper_DeserializeMessage<SubscribeRequest>(context, SubscribeRequest.Parser));

		// Token: 0x04003DC1 RID: 15809
		private static readonly Marshaller<SubscribeResponse> __Marshaller_bgs_protocol_publication_v2_client_SubscribeResponse = Marshallers.Create<SubscribeResponse>(new Action<SubscribeResponse, SerializationContext>(PublicationService.__Helper_SerializeMessage), (DeserializationContext context) => PublicationService.__Helper_DeserializeMessage<SubscribeResponse>(context, SubscribeResponse.Parser));

		// Token: 0x04003DC2 RID: 15810
		private static readonly Marshaller<UnsubscribeRequest> __Marshaller_bgs_protocol_publication_v2_client_UnsubscribeRequest = Marshallers.Create<UnsubscribeRequest>(new Action<UnsubscribeRequest, SerializationContext>(PublicationService.__Helper_SerializeMessage), (DeserializationContext context) => PublicationService.__Helper_DeserializeMessage<UnsubscribeRequest>(context, UnsubscribeRequest.Parser));

		// Token: 0x04003DC3 RID: 15811
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(PublicationService.__Helper_SerializeMessage), (DeserializationContext context) => PublicationService.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04003DC4 RID: 15812
		private static readonly Method<SubscribeRequest, SubscribeResponse> __Method_Subscribe = new Method<SubscribeRequest, SubscribeResponse>(0, PublicationService.__ServiceName, "Subscribe", PublicationService.__Marshaller_bgs_protocol_publication_v2_client_SubscribeRequest, PublicationService.__Marshaller_bgs_protocol_publication_v2_client_SubscribeResponse);

		// Token: 0x04003DC5 RID: 15813
		private static readonly Method<UnsubscribeRequest, NoData> __Method_Unsubscribe = new Method<UnsubscribeRequest, NoData>(0, PublicationService.__ServiceName, "Unsubscribe", PublicationService.__Marshaller_bgs_protocol_publication_v2_client_UnsubscribeRequest, PublicationService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x0200106B RID: 4203
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x040097C0 RID: 38848
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x0200106C RID: 4204
		[BindServiceMethod(typeof(PublicationService), "BindService")]
		public abstract class PublicationServiceBase
		{
			// Token: 0x0600D227 RID: 53799 RVA: 0x004B19D8 File Offset: 0x004AFBD8
			public virtual Task<SubscribeResponse> Subscribe(SubscribeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}

			// Token: 0x0600D228 RID: 53800 RVA: 0x004B19EC File Offset: 0x004AFBEC
			public virtual Task<NoData> Unsubscribe(UnsubscribeRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x0200106D RID: 4205
		public class PublicationServiceClient : ClientBase<PublicationService.PublicationServiceClient>
		{
			// Token: 0x0600D22A RID: 53802 RVA: 0x004B1A09 File Offset: 0x004AFC09
			public PublicationServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D22B RID: 53803 RVA: 0x004B1A14 File Offset: 0x004AFC14
			public PublicationServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D22C RID: 53804 RVA: 0x004B1A1F File Offset: 0x004AFC1F
			protected PublicationServiceClient()
			{
			}

			// Token: 0x0600D22D RID: 53805 RVA: 0x004B1A29 File Offset: 0x004AFC29
			protected PublicationServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D22E RID: 53806 RVA: 0x004B1A34 File Offset: 0x004AFC34
			public virtual SubscribeResponse Subscribe(SubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Subscribe(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D22F RID: 53807 RVA: 0x004B1A5C File Offset: 0x004AFC5C
			public virtual SubscribeResponse Subscribe(SubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SubscribeRequest, SubscribeResponse>(PublicationService.__Method_Subscribe, null, options, request);
			}

			// Token: 0x0600D230 RID: 53808 RVA: 0x004B1A84 File Offset: 0x004AFC84
			public virtual AsyncUnaryCall<SubscribeResponse> SubscribeAsync(SubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D231 RID: 53809 RVA: 0x004B1AAC File Offset: 0x004AFCAC
			public virtual AsyncUnaryCall<SubscribeResponse> SubscribeAsync(SubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SubscribeRequest, SubscribeResponse>(PublicationService.__Method_Subscribe, null, options, request);
			}

			// Token: 0x0600D232 RID: 53810 RVA: 0x004B1AD4 File Offset: 0x004AFCD4
			public virtual NoData Unsubscribe(UnsubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.Unsubscribe(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D233 RID: 53811 RVA: 0x004B1AFC File Offset: 0x004AFCFC
			public virtual NoData Unsubscribe(UnsubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<UnsubscribeRequest, NoData>(PublicationService.__Method_Unsubscribe, null, options, request);
			}

			// Token: 0x0600D234 RID: 53812 RVA: 0x004B1B24 File Offset: 0x004AFD24
			public virtual AsyncUnaryCall<NoData> UnsubscribeAsync(UnsubscribeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UnsubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D235 RID: 53813 RVA: 0x004B1B4C File Offset: 0x004AFD4C
			public virtual AsyncUnaryCall<NoData> UnsubscribeAsync(UnsubscribeRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<UnsubscribeRequest, NoData>(PublicationService.__Method_Unsubscribe, null, options, request);
			}

			// Token: 0x0600D236 RID: 53814 RVA: 0x004B1B74 File Offset: 0x004AFD74
			protected override PublicationService.PublicationServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new PublicationService.PublicationServiceClient(configuration);
			}
		}
	}
}
