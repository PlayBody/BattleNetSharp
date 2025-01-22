using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Classic.Protocol.External.V1.GemTicket.GemTicket
{
	// Token: 0x0200078A RID: 1930
	public static class GemTicket
	{
		// Token: 0x0600B0E6 RID: 45286 RVA: 0x002B0978 File Offset: 0x002AEB78
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

		// Token: 0x0600B0E7 RID: 45287 RVA: 0x002B09C4 File Offset: 0x002AEBC4
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = GemTicket.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x170036AF RID: 13999
		// (get) Token: 0x0600B0E8 RID: 45288 RVA: 0x002B09FC File Offset: 0x002AEBFC
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return GemTicketReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x0600B0E9 RID: 45289 RVA: 0x002B0A20 File Offset: 0x002AEC20
		public static ServerServiceDefinition BindService(GemTicket.GemTicketBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<GemTicketRequest, GemTicketResponse>(GemTicket.__Method_ReqGemTicket, new UnaryServerMethod<GemTicketRequest, GemTicketResponse>(serviceImpl.ReqGemTicket)).Build();
		}

		// Token: 0x0600B0EA RID: 45290 RVA: 0x002B0A53 File Offset: 0x002AEC53
		public static void BindService(ServiceBinderBase serviceBinder, GemTicket.GemTicketBase serviceImpl)
		{
			serviceBinder.AddMethod<GemTicketRequest, GemTicketResponse>(GemTicket.__Method_ReqGemTicket, (serviceImpl == null) ? null : new UnaryServerMethod<GemTicketRequest, GemTicketResponse>(serviceImpl.ReqGemTicket));
		}

		// Token: 0x04004FC0 RID: 20416
		private static readonly string __ServiceName = "classic.protocol.external.v1.gem_ticket.GemTicket.GemTicket";

		// Token: 0x04004FC1 RID: 20417
		private static readonly Marshaller<GemTicketRequest> __Marshaller_classic_protocol_external_v1_gem_ticket_GemTicket_GemTicketRequest = Marshallers.Create<GemTicketRequest>(new Action<GemTicketRequest, SerializationContext>(GemTicket.__Helper_SerializeMessage), (DeserializationContext context) => GemTicket.__Helper_DeserializeMessage<GemTicketRequest>(context, GemTicketRequest.Parser));

		// Token: 0x04004FC2 RID: 20418
		private static readonly Marshaller<GemTicketResponse> __Marshaller_classic_protocol_external_v1_gem_ticket_GemTicket_GemTicketResponse = Marshallers.Create<GemTicketResponse>(new Action<GemTicketResponse, SerializationContext>(GemTicket.__Helper_SerializeMessage), (DeserializationContext context) => GemTicket.__Helper_DeserializeMessage<GemTicketResponse>(context, GemTicketResponse.Parser));

		// Token: 0x04004FC3 RID: 20419
		private static readonly Method<GemTicketRequest, GemTicketResponse> __Method_ReqGemTicket = new Method<GemTicketRequest, GemTicketResponse>(0, GemTicket.__ServiceName, "ReqGemTicket", GemTicket.__Marshaller_classic_protocol_external_v1_gem_ticket_GemTicket_GemTicketRequest, GemTicket.__Marshaller_classic_protocol_external_v1_gem_ticket_GemTicket_GemTicketResponse);

		// Token: 0x020012B2 RID: 4786
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x040099C0 RID: 39360
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x020012B3 RID: 4787
		[BindServiceMethod(typeof(GemTicket), "BindService")]
		public abstract class GemTicketBase
		{
			// Token: 0x0600DDA6 RID: 56742 RVA: 0x004C02D4 File Offset: 0x004BE4D4
			public virtual Task<GemTicketResponse> ReqGemTicket(GemTicketRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x020012B4 RID: 4788
		public class GemTicketClient : ClientBase<GemTicket.GemTicketClient>
		{
			// Token: 0x0600DDA8 RID: 56744 RVA: 0x004C02F1 File Offset: 0x004BE4F1
			public GemTicketClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600DDA9 RID: 56745 RVA: 0x004C02FC File Offset: 0x004BE4FC
			public GemTicketClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600DDAA RID: 56746 RVA: 0x004C0307 File Offset: 0x004BE507
			protected GemTicketClient()
			{
			}

			// Token: 0x0600DDAB RID: 56747 RVA: 0x004C0311 File Offset: 0x004BE511
			protected GemTicketClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600DDAC RID: 56748 RVA: 0x004C031C File Offset: 0x004BE51C
			public virtual GemTicketResponse ReqGemTicket(GemTicketRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ReqGemTicket(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DDAD RID: 56749 RVA: 0x004C0344 File Offset: 0x004BE544
			public virtual GemTicketResponse ReqGemTicket(GemTicketRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<GemTicketRequest, GemTicketResponse>(GemTicket.__Method_ReqGemTicket, null, options, request);
			}

			// Token: 0x0600DDAE RID: 56750 RVA: 0x004C036C File Offset: 0x004BE56C
			public virtual AsyncUnaryCall<GemTicketResponse> ReqGemTicketAsync(GemTicketRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ReqGemTicketAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DDAF RID: 56751 RVA: 0x004C0394 File Offset: 0x004BE594
			public virtual AsyncUnaryCall<GemTicketResponse> ReqGemTicketAsync(GemTicketRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<GemTicketRequest, GemTicketResponse>(GemTicket.__Method_ReqGemTicket, null, options, request);
			}

			// Token: 0x0600DDB0 RID: 56752 RVA: 0x004C03BC File Offset: 0x004BE5BC
			protected override GemTicket.GemTicketClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new GemTicket.GemTicketClient(configuration);
			}
		}
	}
}
