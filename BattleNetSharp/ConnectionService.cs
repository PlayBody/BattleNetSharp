using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.Connection.V1;
using Google.Protobuf;
using Grpc.Core;
using Utilities;

namespace BattleNetSharp
{
	// Token: 0x02000AEA RID: 2794
	public class ConnectionService : Bgs.Protocol.Connection.V1.ConnectionService.ConnectionServiceBase, IServiceListener
	{
		// Token: 0x0600BD29 RID: 48425 RVA: 0x00484E60 File Offset: 0x00483060
		public override Task<BindResponse> Bind(BindRequest request, ServerCallContext context)
		{
			return base.Bind(request, context);
		}

		// Token: 0x0600BD2A RID: 48426 RVA: 0x00484E7C File Offset: 0x0048307C
		public override Task<ConnectResponse> Connect(ConnectRequest request, ServerCallContext context)
		{
			DateTime now = DateTime.Now;
			ConnectResponse connectResponse = new ConnectResponse
			{
				ServerId = new ProcessId
				{
					Label = 0U,
					Epoch = now.ToUnixTime()
				},
				ClientId = new ProcessId
				{
					Label = 1U,
					Epoch = now.ToUnixTime()
				},
				ServerTime = now.ToExtendedEpoch(),
				BinaryContentHandleArray = new ConnectionMeteringContentHandles()
			};
			D2RBGS.BGSConnections[((ConnectionContext)context).Caller].ClientId = "A0CAE542608784BD-00000000001E8692";
			return Task.FromResult<ConnectResponse>(connectResponse);
		}

		// Token: 0x0600BD2B RID: 48427 RVA: 0x00484F1C File Offset: 0x0048311C
		public override Task<EchoResponse> Echo(EchoRequest request, ServerCallContext context)
		{
			return Task.FromResult<EchoResponse>(new EchoResponse
			{
				Payload = ByteString.CopyFromUtf8(""),
				Time = 0UL
			});
		}

		// Token: 0x0600BD2C RID: 48428 RVA: 0x00484F54 File Offset: 0x00483154
		public override Task<NoData> Encrypt(EncryptRequest request, ServerCallContext context)
		{
			return base.Encrypt(request, context);
		}

		// Token: 0x0600BD2D RID: 48429 RVA: 0x00484F70 File Offset: 0x00483170
		public override Task<NO_RESPONSE> ForceDisconnect(DisconnectNotification request, ServerCallContext context)
		{
			return Task.FromResult<NO_RESPONSE>(new NO_RESPONSE());
		}

		// Token: 0x0600BD2E RID: 48430 RVA: 0x00484F8C File Offset: 0x0048318C
		public override Task<NO_RESPONSE> KeepAlive(NoData request, ServerCallContext context)
		{
			return Task.FromResult<NO_RESPONSE>(new NO_RESPONSE());
		}

		// Token: 0x0600BD2F RID: 48431 RVA: 0x00484FA8 File Offset: 0x004831A8
		public override Task<NO_RESPONSE> RequestDisconnect(DisconnectRequest request, ServerCallContext context)
		{
			return Task.FromResult<NO_RESPONSE>(new NO_RESPONSE());
		}
	}
}
