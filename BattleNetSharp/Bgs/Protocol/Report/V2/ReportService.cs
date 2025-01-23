using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Report.V2
{
	// Token: 0x02000583 RID: 1411
	public static class ReportService
	{
		// Token: 0x0600878A RID: 34698 RVA: 0x0020EE30 File Offset: 0x0020D030
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

		// Token: 0x0600878B RID: 34699 RVA: 0x0020EE7C File Offset: 0x0020D07C
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = ReportService.__Helper_MessageCache<T>.IsBufferMessage;
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

		// Token: 0x17002AB4 RID: 10932
		// (get) Token: 0x0600878C RID: 34700 RVA: 0x0020EEB4 File Offset: 0x0020D0B4
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return ReportServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x0600878D RID: 34701 RVA: 0x0020EED8 File Offset: 0x0020D0D8
		public static ServerServiceDefinition BindService(ReportService.ReportServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<SubmitReportRequest, NoData>(ReportService.__Method_SubmitReport, new UnaryServerMethod<SubmitReportRequest, NoData>(serviceImpl.SubmitReport)).Build();
		}

		// Token: 0x0600878E RID: 34702 RVA: 0x0020EF0B File Offset: 0x0020D10B
		public static void BindService(ServiceBinderBase serviceBinder, ReportService.ReportServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<SubmitReportRequest, NoData>(ReportService.__Method_SubmitReport, (serviceImpl == null) ? null : new UnaryServerMethod<SubmitReportRequest, NoData>(serviceImpl.SubmitReport));
		}

		// Token: 0x04003D59 RID: 15705
		private static readonly string __ServiceName = "bgs.protocol.report.v2.ReportService";

		// Token: 0x04003D5A RID: 15706
		private static readonly Marshaller<SubmitReportRequest> __Marshaller_bgs_protocol_report_v2_SubmitReportRequest = Marshallers.Create<SubmitReportRequest>(new Action<SubmitReportRequest, SerializationContext>(ReportService.__Helper_SerializeMessage), (DeserializationContext context) => ReportService.__Helper_DeserializeMessage<SubmitReportRequest>(context, SubmitReportRequest.Parser));

		// Token: 0x04003D5B RID: 15707
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(ReportService.__Helper_SerializeMessage), (DeserializationContext context) => ReportService.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04003D5C RID: 15708
		private static readonly Method<SubmitReportRequest, NoData> __Method_SubmitReport = new Method<SubmitReportRequest, NoData>(0, ReportService.__ServiceName, "SubmitReport", ReportService.__Marshaller_bgs_protocol_report_v2_SubmitReportRequest, ReportService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x0200105A RID: 4186
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x040097B1 RID: 38833
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x0200105B RID: 4187
		[BindServiceMethod(typeof(ReportService), "BindService")]
		public abstract class ReportServiceBase
		{
			// Token: 0x0600D1EF RID: 53743 RVA: 0x004B164D File Offset: 0x004AF84D
			public virtual Task<NoData> SubmitReport(SubmitReportRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x0200105C RID: 4188
		public class ReportServiceClient : ClientBase<ReportService.ReportServiceClient>
		{
			// Token: 0x0600D1F1 RID: 53745 RVA: 0x004B166A File Offset: 0x004AF86A
			public ReportServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D1F2 RID: 53746 RVA: 0x004B1675 File Offset: 0x004AF875
			public ReportServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D1F3 RID: 53747 RVA: 0x004B1680 File Offset: 0x004AF880
			protected ReportServiceClient()
			{
			}

			// Token: 0x0600D1F4 RID: 53748 RVA: 0x004B168A File Offset: 0x004AF88A
			protected ReportServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D1F5 RID: 53749 RVA: 0x004B1698 File Offset: 0x004AF898
			public virtual NoData SubmitReport(SubmitReportRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SubmitReport(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D1F6 RID: 53750 RVA: 0x004B16C0 File Offset: 0x004AF8C0
			public virtual NoData SubmitReport(SubmitReportRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SubmitReportRequest, NoData>(ReportService.__Method_SubmitReport, null, options, request);
			}

			// Token: 0x0600D1F7 RID: 53751 RVA: 0x004B16E8 File Offset: 0x004AF8E8
			public virtual AsyncUnaryCall<NoData> SubmitReportAsync(SubmitReportRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SubmitReportAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D1F8 RID: 53752 RVA: 0x004B1710 File Offset: 0x004AF910
			public virtual AsyncUnaryCall<NoData> SubmitReportAsync(SubmitReportRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SubmitReportRequest, NoData>(ReportService.__Method_SubmitReport, null, options, request);
			}

			// Token: 0x0600D1F9 RID: 53753 RVA: 0x004B1738 File Offset: 0x004AF938
			protected override ReportService.ReportServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new ReportService.ReportServiceClient(configuration);
			}
		}
	}
}
