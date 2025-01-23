using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Publication.V2.Client
{
	// Token: 0x0200058E RID: 1422
	public static class PublicationListener
	{
		// Token: 0x06008815 RID: 34837 RVA: 0x00210F4C File Offset: 0x0020F14C
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

		// Token: 0x06008816 RID: 34838 RVA: 0x00210F98 File Offset: 0x0020F198
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = PublicationListener.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17002ADD RID: 10973
		// (get) Token: 0x06008817 RID: 34839 RVA: 0x00210FD0 File Offset: 0x0020F1D0
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return PublicationListenerReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x06008818 RID: 34840 RVA: 0x00210FF4 File Offset: 0x0020F1F4
		public static ServerServiceDefinition BindService(PublicationListener.PublicationListenerBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<PublicationReceivedNotification, NO_RESPONSE>(PublicationListener.__Method_OnPublicationReceived, new UnaryServerMethod<PublicationReceivedNotification, NO_RESPONSE>(serviceImpl.OnPublicationReceived)).Build();
		}

		// Token: 0x06008819 RID: 34841 RVA: 0x00211027 File Offset: 0x0020F227
		public static void BindService(ServiceBinderBase serviceBinder, PublicationListener.PublicationListenerBase serviceImpl)
		{
			serviceBinder.AddMethod<PublicationReceivedNotification, NO_RESPONSE>(PublicationListener.__Method_OnPublicationReceived, (serviceImpl == null) ? null : new UnaryServerMethod<PublicationReceivedNotification, NO_RESPONSE>(serviceImpl.OnPublicationReceived));
		}

		// Token: 0x04003DA9 RID: 15785
		private static readonly string __ServiceName = "bgs.protocol.publication.v2.client.PublicationListener";

		// Token: 0x04003DAA RID: 15786
		private static readonly Marshaller<PublicationReceivedNotification> __Marshaller_bgs_protocol_publication_v2_client_PublicationReceivedNotification = Marshallers.Create<PublicationReceivedNotification>(new Action<PublicationReceivedNotification, SerializationContext>(PublicationListener.__Helper_SerializeMessage), (DeserializationContext context) => PublicationListener.__Helper_DeserializeMessage<PublicationReceivedNotification>(context, PublicationReceivedNotification.Parser));

		// Token: 0x04003DAB RID: 15787
		private static readonly Marshaller<NO_RESPONSE> __Marshaller_bgs_protocol_NO_RESPONSE = Marshallers.Create<NO_RESPONSE>(new Action<NO_RESPONSE, SerializationContext>(PublicationListener.__Helper_SerializeMessage), (DeserializationContext context) => PublicationListener.__Helper_DeserializeMessage<NO_RESPONSE>(context, NO_RESPONSE.Parser));

		// Token: 0x04003DAC RID: 15788
		private static readonly Method<PublicationReceivedNotification, NO_RESPONSE> __Method_OnPublicationReceived = new Method<PublicationReceivedNotification, NO_RESPONSE>(0, PublicationListener.__ServiceName, "OnPublicationReceived", PublicationListener.__Marshaller_bgs_protocol_publication_v2_client_PublicationReceivedNotification, PublicationListener.__Marshaller_bgs_protocol_NO_RESPONSE);

		// Token: 0x02001064 RID: 4196
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x040097BB RID: 38843
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x02001065 RID: 4197
		[BindServiceMethod(typeof(PublicationListener), "BindService")]
		public abstract class PublicationListenerBase
		{
			// Token: 0x0600D20E RID: 53774 RVA: 0x004B1830 File Offset: 0x004AFA30
			public virtual Task<NO_RESPONSE> OnPublicationReceived(PublicationReceivedNotification request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x02001066 RID: 4198
		public class PublicationListenerClient : ClientBase<PublicationListener.PublicationListenerClient>
		{
			// Token: 0x0600D210 RID: 53776 RVA: 0x004B184D File Offset: 0x004AFA4D
			public PublicationListenerClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D211 RID: 53777 RVA: 0x004B1858 File Offset: 0x004AFA58
			public PublicationListenerClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D212 RID: 53778 RVA: 0x004B1863 File Offset: 0x004AFA63
			protected PublicationListenerClient()
			{
			}

			// Token: 0x0600D213 RID: 53779 RVA: 0x004B186D File Offset: 0x004AFA6D
			protected PublicationListenerClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D214 RID: 53780 RVA: 0x004B1878 File Offset: 0x004AFA78
			public virtual NO_RESPONSE OnPublicationReceived(PublicationReceivedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnPublicationReceived(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D215 RID: 53781 RVA: 0x004B18A0 File Offset: 0x004AFAA0
			public virtual NO_RESPONSE OnPublicationReceived(PublicationReceivedNotification request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<PublicationReceivedNotification, NO_RESPONSE>(PublicationListener.__Method_OnPublicationReceived, null, options, request);
			}

			// Token: 0x0600D216 RID: 53782 RVA: 0x004B18C8 File Offset: 0x004AFAC8
			public virtual AsyncUnaryCall<NO_RESPONSE> OnPublicationReceivedAsync(PublicationReceivedNotification request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.OnPublicationReceivedAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D217 RID: 53783 RVA: 0x004B18F0 File Offset: 0x004AFAF0
			public virtual AsyncUnaryCall<NO_RESPONSE> OnPublicationReceivedAsync(PublicationReceivedNotification request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<PublicationReceivedNotification, NO_RESPONSE>(PublicationListener.__Method_OnPublicationReceived, null, options, request);
			}

			// Token: 0x0600D218 RID: 53784 RVA: 0x004B1918 File Offset: 0x004AFB18
			protected override PublicationListener.PublicationListenerClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new PublicationListener.PublicationListenerClient(configuration);
			}
		}
	}
}
