using System;
using System.Threading.Tasks;
using Classic.Protocol.V1.Chat;
using Grpc.Core;

namespace BattleNetSharp.Services
{
	// Token: 0x02000AFE RID: 2814
	public class ChatService : Chat.ChatBase, IServiceListener
	{
		// Token: 0x0600BDCF RID: 48591 RVA: 0x00487720 File Offset: 0x00485920
		public override Task<ChatResponse> ChannelMessage(ChatRequest request, ServerCallContext context)
		{
			return base.ChannelMessage(request, context);
		}

		// Token: 0x0600BDD0 RID: 48592 RVA: 0x0048773C File Offset: 0x0048593C
		public override Task<ChatResponse> WhisperMessage(ChatRequest request, ServerCallContext context)
		{
			return base.WhisperMessage(request, context);
		}
	}
}
