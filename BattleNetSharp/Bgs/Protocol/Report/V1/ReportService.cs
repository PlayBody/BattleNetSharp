using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Bgs.Protocol.Report.V1
{
	// Token: 0x02000576 RID: 1398
	public static class ReportService
	{
		// Token: 0x0600867E RID: 34430 RVA: 0x0020A858 File Offset: 0x00208A58
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

		// Token: 0x0600867F RID: 34431 RVA: 0x0020A8A4 File Offset: 0x00208AA4
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

		// Token: 0x17002A66 RID: 10854
		// (get) Token: 0x06008680 RID: 34432 RVA: 0x0020A8DC File Offset: 0x00208ADC
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return ReportServiceReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x06008681 RID: 34433 RVA: 0x0020A900 File Offset: 0x00208B00
		public static ServerServiceDefinition BindService(ReportService.ReportServiceBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<SendReportRequest, NoData>(ReportService.__Method_SendReport, new UnaryServerMethod<SendReportRequest, NoData>(serviceImpl.SendReport)).AddMethod<SubmitReportRequest, NoData>(ReportService.__Method_SubmitReport, new UnaryServerMethod<SubmitReportRequest, NoData>(serviceImpl.SubmitReport))
				.Build();
		}

		// Token: 0x06008682 RID: 34434 RVA: 0x0020A94C File Offset: 0x00208B4C
		public static void BindService(ServiceBinderBase serviceBinder, ReportService.ReportServiceBase serviceImpl)
		{
			serviceBinder.AddMethod<SendReportRequest, NoData>(ReportService.__Method_SendReport, (serviceImpl == null) ? null : new UnaryServerMethod<SendReportRequest, NoData>(serviceImpl.SendReport));
			serviceBinder.AddMethod<SubmitReportRequest, NoData>(ReportService.__Method_SubmitReport, (serviceImpl == null) ? null : new UnaryServerMethod<SubmitReportRequest, NoData>(serviceImpl.SubmitReport));
		}

		// Token: 0x04003CF4 RID: 15604
		private static readonly string __ServiceName = "bgs.protocol.report.v1.ReportService";

		// Token: 0x04003CF5 RID: 15605
		private static readonly Marshaller<SendReportRequest> __Marshaller_bgs_protocol_report_v1_SendReportRequest = Marshallers.Create<SendReportRequest>(new Action<SendReportRequest, SerializationContext>(ReportService.__Helper_SerializeMessage), (DeserializationContext context) => ReportService.__Helper_DeserializeMessage<SendReportRequest>(context, SendReportRequest.Parser));

		// Token: 0x04003CF6 RID: 15606
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(ReportService.__Helper_SerializeMessage), (DeserializationContext context) => ReportService.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x04003CF7 RID: 15607
		private static readonly Marshaller<SubmitReportRequest> __Marshaller_bgs_protocol_report_v1_SubmitReportRequest = Marshallers.Create<SubmitReportRequest>(new Action<SubmitReportRequest, SerializationContext>(ReportService.__Helper_SerializeMessage), (DeserializationContext context) => ReportService.__Helper_DeserializeMessage<SubmitReportRequest>(context, SubmitReportRequest.Parser));

		// Token: 0x04003CF8 RID: 15608
		private static readonly Method<SendReportRequest, NoData> __Method_SendReport = new Method<SendReportRequest, NoData>(0, ReportService.__ServiceName, "SendReport", ReportService.__Marshaller_bgs_protocol_report_v1_SendReportRequest, ReportService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x04003CF9 RID: 15609
		private static readonly Method<SubmitReportRequest, NoData> __Method_SubmitReport = new Method<SubmitReportRequest, NoData>(0, ReportService.__ServiceName, "SubmitReport", ReportService.__Marshaller_bgs_protocol_report_v1_SubmitReportRequest, ReportService.__Marshaller_bgs_protocol_NoData);

		// Token: 0x02001049 RID: 4169
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x04009797 RID: 38807
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x0200104A RID: 4170
		[BindServiceMethod(typeof(ReportService), "BindService")]
		public abstract class ReportServiceBase
		{
			// Token: 0x0600D1BB RID: 53691 RVA: 0x004B131D File Offset: 0x004AF51D
			public virtual Task<NoData> SendReport(SendReportRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600D1BC RID: 53692 RVA: 0x004B1331 File Offset: 0x004AF531
			public virtual Task<NoData> SubmitReport(SubmitReportRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x0200104B RID: 4171
		public class ReportServiceClient : ClientBase<ReportService.ReportServiceClient>
		{
			// Token: 0x0600D1BE RID: 53694 RVA: 0x004B134E File Offset: 0x004AF54E
			public ReportServiceClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600D1BF RID: 53695 RVA: 0x004B1359 File Offset: 0x004AF559
			public ReportServiceClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600D1C0 RID: 53696 RVA: 0x004B1364 File Offset: 0x004AF564
			protected ReportServiceClient()
			{
			}

			// Token: 0x0600D1C1 RID: 53697 RVA: 0x004B136E File Offset: 0x004AF56E
			protected ReportServiceClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600D1C2 RID: 53698 RVA: 0x004B137C File Offset: 0x004AF57C
			public virtual NoData SendReport(SendReportRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SendReport(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D1C3 RID: 53699 RVA: 0x004B13A4 File Offset: 0x004AF5A4
			public virtual NoData SendReport(SendReportRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SendReportRequest, NoData>(ReportService.__Method_SendReport, null, options, request);
			}

			// Token: 0x0600D1C4 RID: 53700 RVA: 0x004B13CC File Offset: 0x004AF5CC
			public virtual AsyncUnaryCall<NoData> SendReportAsync(SendReportRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SendReportAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D1C5 RID: 53701 RVA: 0x004B13F4 File Offset: 0x004AF5F4
			public virtual AsyncUnaryCall<NoData> SendReportAsync(SendReportRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SendReportRequest, NoData>(ReportService.__Method_SendReport, null, options, request);
			}

			// Token: 0x0600D1C6 RID: 53702 RVA: 0x004B141C File Offset: 0x004AF61C
			public virtual NoData SubmitReport(SubmitReportRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SubmitReport(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D1C7 RID: 53703 RVA: 0x004B1444 File Offset: 0x004AF644
			public virtual NoData SubmitReport(SubmitReportRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<SubmitReportRequest, NoData>(ReportService.__Method_SubmitReport, null, options, request);
			}

			// Token: 0x0600D1C8 RID: 53704 RVA: 0x004B146C File Offset: 0x004AF66C
			public virtual AsyncUnaryCall<NoData> SubmitReportAsync(SubmitReportRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.SubmitReportAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600D1C9 RID: 53705 RVA: 0x004B1494 File Offset: 0x004AF694
			public virtual AsyncUnaryCall<NoData> SubmitReportAsync(SubmitReportRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<SubmitReportRequest, NoData>(ReportService.__Method_SubmitReport, null, options, request);
			}

			// Token: 0x0600D1CA RID: 53706 RVA: 0x004B14BC File Offset: 0x004AF6BC
			protected override ReportService.ReportServiceClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new ReportService.ReportServiceClient(configuration);
			}
		}
	}
}
