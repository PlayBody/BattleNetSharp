using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Bgs.Protocol;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Classic.Protocol.External.V1.DiabloClone
{
	// Token: 0x020007A2 RID: 1954
	public static class DiabloCloneExternal
	{
		// Token: 0x0600B35A RID: 45914 RVA: 0x002BA34C File Offset: 0x002B854C
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

		// Token: 0x0600B35B RID: 45915 RVA: 0x002BA398 File Offset: 0x002B8598
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = DiabloCloneExternal.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17003787 RID: 14215
		// (get) Token: 0x0600B35C RID: 45916 RVA: 0x002BA3D0 File Offset: 0x002B85D0
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return DiabloCloneReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x0600B35D RID: 45917 RVA: 0x002BA3F4 File Offset: 0x002B85F4
		public static ServerServiceDefinition BindService(DiabloCloneExternal.DiabloCloneExternalBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<DiabloCloneMessage, NoData>(DiabloCloneExternal.__Method_DiabloCloneMessageTier, new UnaryServerMethod<DiabloCloneMessage, NoData>(serviceImpl.DiabloCloneMessageTier)).Build();
		}

		// Token: 0x0600B35E RID: 45918 RVA: 0x002BA427 File Offset: 0x002B8627
		public static void BindService(ServiceBinderBase serviceBinder, DiabloCloneExternal.DiabloCloneExternalBase serviceImpl)
		{
			serviceBinder.AddMethod<DiabloCloneMessage, NoData>(DiabloCloneExternal.__Method_DiabloCloneMessageTier, (serviceImpl == null) ? null : new UnaryServerMethod<DiabloCloneMessage, NoData>(serviceImpl.DiabloCloneMessageTier));
		}

		// Token: 0x04005116 RID: 20758
		private static readonly string __ServiceName = "classic.protocol.external.v1.diablo_clone.DiabloCloneExternal";

		// Token: 0x04005117 RID: 20759
		private static readonly Marshaller<DiabloCloneMessage> __Marshaller_classic_protocol_external_v1_diablo_clone_DiabloCloneMessage = Marshallers.Create<DiabloCloneMessage>(new Action<DiabloCloneMessage, SerializationContext>(DiabloCloneExternal.__Helper_SerializeMessage), (DeserializationContext context) => DiabloCloneExternal.__Helper_DeserializeMessage<DiabloCloneMessage>(context, DiabloCloneMessage.Parser));

		// Token: 0x04005118 RID: 20760
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(DiabloCloneExternal.__Helper_SerializeMessage), (DeserializationContext context) => DiabloCloneExternal.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04005119 RID: 20761
		private static readonly Method<DiabloCloneMessage, NoData> __Method_DiabloCloneMessageTier = new Method<DiabloCloneMessage, NoData>(0, DiabloCloneExternal.__ServiceName, "DiabloCloneMessageTier", DiabloCloneExternal.__Marshaller_classic_protocol_external_v1_diablo_clone_DiabloCloneMessage, DiabloCloneExternal.__Marshaller_bgs_protocol_NoData);

		// Token: 0x020012CC RID: 4812
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x040099D6 RID: 39382
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x020012CD RID: 4813
		[BindServiceMethod(typeof(DiabloCloneExternal), "BindService")]
		public abstract class DiabloCloneExternalBase
		{
			// Token: 0x0600DE29 RID: 56873 RVA: 0x004C0CE2 File Offset: 0x004BEEE2
			public virtual Task<NoData> DiabloCloneMessageTier(DiabloCloneMessage request, ServerCallContext context)
			{
				throw new RpcException(new Status(12, ""));
			}
		}

		// Token: 0x020012CE RID: 4814
		public class DiabloCloneExternalClient : ClientBase<DiabloCloneExternal.DiabloCloneExternalClient>
		{
			// Token: 0x0600DE2B RID: 56875 RVA: 0x004C0CFF File Offset: 0x004BEEFF
			public DiabloCloneExternalClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600DE2C RID: 56876 RVA: 0x004C0D0A File Offset: 0x004BEF0A
			public DiabloCloneExternalClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600DE2D RID: 56877 RVA: 0x004C0D15 File Offset: 0x004BEF15
			protected DiabloCloneExternalClient()
			{
			}

			// Token: 0x0600DE2E RID: 56878 RVA: 0x004C0D1F File Offset: 0x004BEF1F
			protected DiabloCloneExternalClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600DE2F RID: 56879 RVA: 0x004C0D2C File Offset: 0x004BEF2C
			public virtual NoData DiabloCloneMessageTier(DiabloCloneMessage request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.DiabloCloneMessageTier(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DE30 RID: 56880 RVA: 0x004C0D54 File Offset: 0x004BEF54
			public virtual NoData DiabloCloneMessageTier(DiabloCloneMessage request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<DiabloCloneMessage, NoData>(DiabloCloneExternal.__Method_DiabloCloneMessageTier, null, options, request);
			}

			// Token: 0x0600DE31 RID: 56881 RVA: 0x004C0D7C File Offset: 0x004BEF7C
			public virtual AsyncUnaryCall<NoData> DiabloCloneMessageTierAsync(DiabloCloneMessage request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.DiabloCloneMessageTierAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DE32 RID: 56882 RVA: 0x004C0DA4 File Offset: 0x004BEFA4
			public virtual AsyncUnaryCall<NoData> DiabloCloneMessageTierAsync(DiabloCloneMessage request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<DiabloCloneMessage, NoData>(DiabloCloneExternal.__Method_DiabloCloneMessageTier, null, options, request);
			}

			// Token: 0x0600DE33 RID: 56883 RVA: 0x004C0DCC File Offset: 0x004BEFCC
			protected override DiabloCloneExternal.DiabloCloneExternalClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new DiabloCloneExternal.DiabloCloneExternalClient(configuration);
			}
		}
	}
}
