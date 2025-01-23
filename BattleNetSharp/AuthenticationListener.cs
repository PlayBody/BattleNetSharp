using System;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.Authentication.V1;
using Grpc.Core;

namespace BattleNetSharp
{
	// Token: 0x02000AD7 RID: 2775
	public class AuthenticationListener : Bgs.Protocol.Authentication.V1.AuthenticationListener.AuthenticationListenerBase, IServiceListener
	{
		// Token: 0x0600BCA3 RID: 48291 RVA: 0x00483340 File Offset: 0x00481540
		public override Task<NO_RESPONSE> OnLogonComplete(LogonResult request, ServerCallContext context)
		{
			this.LogonResult = request;
			AuthenticationListener.LogonResultGlobal = request;
			return Task.FromResult<NO_RESPONSE>(new NO_RESPONSE());
		}

		// Token: 0x0600BCA4 RID: 48292 RVA: 0x0048336C File Offset: 0x0048156C
		public override Task<NO_RESPONSE> OnGameAccountSelected(GameAccountSelectedRequest request, ServerCallContext context)
		{
			this.GameAccountSelectedRequest = request;
			return Task.FromResult<NO_RESPONSE>(new NO_RESPONSE());
		}

		// Token: 0x0600BCA5 RID: 48293 RVA: 0x00483390 File Offset: 0x00481590
		public override Task<NO_RESPONSE> OnModuleLoad(ModuleLoadRequest request, ServerCallContext context)
		{
			return null;
		}

		// Token: 0x0600BCA6 RID: 48294 RVA: 0x004833A4 File Offset: 0x004815A4
		public override Task<NoData> OnModuleMessage(ModuleMessageRequest request, ServerCallContext context)
		{
			return null;
		}

		// Token: 0x0600BCA7 RID: 48295 RVA: 0x004833B8 File Offset: 0x004815B8
		public override Task<NO_RESPONSE> OnServerStateChange(ServerStateChangeRequest request, ServerCallContext context)
		{
			return null;
		}

		// Token: 0x0600BCA8 RID: 48296 RVA: 0x004833CC File Offset: 0x004815CC
		public override Task<MemModuleLoadResponse> OnMemModuleLoad(MemModuleLoadRequest request, ServerCallContext context)
		{
			return null;
		}

		// Token: 0x0600BCA9 RID: 48297 RVA: 0x004833E0 File Offset: 0x004815E0
		public override Task<NO_RESPONSE> OnLogonUpdate(LogonUpdateRequest request, ServerCallContext context)
		{
			return Task.FromResult<NO_RESPONSE>(new NO_RESPONSE());
		}

		// Token: 0x0600BCAA RID: 48298 RVA: 0x004833FC File Offset: 0x004815FC
		public override Task<NO_RESPONSE> OnVersionInfoUpdated(VersionInfoNotification request, ServerCallContext context)
		{
			return Task.FromResult<NO_RESPONSE>(new NO_RESPONSE());
		}

		// Token: 0x0600BCAB RID: 48299 RVA: 0x00483418 File Offset: 0x00481618
		public override Task<NO_RESPONSE> OnLogonQueueUpdate(LogonQueueUpdateRequest request, ServerCallContext context)
		{
			TimeSpan timeSpan = DateTimeOffset.FromUnixTimeMilliseconds((long)(request.EstimatedTime / 1000UL)).LocalDateTime - DateTime.Now;
			return Task.FromResult<NO_RESPONSE>(new NO_RESPONSE());
		}

		// Token: 0x0600BCAC RID: 48300 RVA: 0x0048345C File Offset: 0x0048165C
		public override Task<NO_RESPONSE> OnLogonQueueEnd(NoData request, ServerCallContext context)
		{
			return Task.FromResult<NO_RESPONSE>(new NO_RESPONSE());
		}

		// Token: 0x04009152 RID: 37202
		public static LogonResult LogonResultGlobal;

		// Token: 0x04009153 RID: 37203
		public LogonResult LogonResult;

		// Token: 0x04009154 RID: 37204
		public GameAccountSelectedRequest GameAccountSelectedRequest;

		// Token: 0x04009155 RID: 37205
		public string tag = "";
	}
}
