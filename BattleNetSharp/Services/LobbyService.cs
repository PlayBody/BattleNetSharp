using System;
using System.Threading.Tasks;
using Classic.Protocol.V1.Lobby;
using Grpc.Core;

namespace BattleNetSharp.Services
{
	// Token: 0x02000B06 RID: 2822
	public class LobbyService : Lobby.LobbyBase, IServiceListener
	{
		// Token: 0x0600BDEF RID: 48623 RVA: 0x00487BB0 File Offset: 0x00485DB0
		public override Task<LobbyResponse> AcceptLobbyInvite(LobbyRequest request, ServerCallContext context)
		{
			return base.AcceptLobbyInvite(request, context);
		}

		// Token: 0x0600BDF0 RID: 48624 RVA: 0x00487BCC File Offset: 0x00485DCC
		public override Task<LobbyResponse> ChatMessageRecv(LobbyRequest request, ServerCallContext context)
		{
			return base.ChatMessageRecv(request, context);
		}

		// Token: 0x0600BDF1 RID: 48625 RVA: 0x00487BE8 File Offset: 0x00485DE8
		public override Task<LobbyResponse> CreateLobby(LobbyRequest request, ServerCallContext context)
		{
			return base.CreateLobby(request, context);
		}

		// Token: 0x0600BDF2 RID: 48626 RVA: 0x00487C04 File Offset: 0x00485E04
		public override Task<LobbyResponse> DisbandLobby(LobbyRequest request, ServerCallContext context)
		{
			return base.DisbandLobby(request, context);
		}

		// Token: 0x0600BDF3 RID: 48627 RVA: 0x00487C20 File Offset: 0x00485E20
		public override Task<LobbyResponse> InviteToLobby(LobbyRequest request, ServerCallContext context)
		{
			return base.InviteToLobby(request, context);
		}

		// Token: 0x0600BDF4 RID: 48628 RVA: 0x00487C3C File Offset: 0x00485E3C
		public override Task<LobbyResponse> KickFromLobby(LobbyRequest request, ServerCallContext context)
		{
			return base.KickFromLobby(request, context);
		}

		// Token: 0x0600BDF5 RID: 48629 RVA: 0x00487C58 File Offset: 0x00485E58
		public override Task<LobbyResponse> LeavyLobby(LobbyRequest request, ServerCallContext context)
		{
			return base.LeavyLobby(request, context);
		}

		// Token: 0x0600BDF6 RID: 48630 RVA: 0x00487C74 File Offset: 0x00485E74
		public override Task<LobbyResponse> LobbyDisbanded(LobbyRequest request, ServerCallContext context)
		{
			return base.LobbyDisbanded(request, context);
		}

		// Token: 0x0600BDF7 RID: 48631 RVA: 0x00487C90 File Offset: 0x00485E90
		public override Task<LobbyResponse> LobbyKicked(LobbyRequest request, ServerCallContext context)
		{
			return base.LobbyKicked(request, context);
		}

		// Token: 0x0600BDF8 RID: 48632 RVA: 0x00487CAC File Offset: 0x00485EAC
		public override Task<LobbyResponse> LobbyUpdate(LobbyRequest request, ServerCallContext context)
		{
			return base.LobbyUpdate(request, context);
		}

		// Token: 0x0600BDF9 RID: 48633 RVA: 0x00487CC8 File Offset: 0x00485EC8
		public override Task<LobbyResponse> NewInvite(LobbyRequest request, ServerCallContext context)
		{
			return base.NewInvite(request, context);
		}

		// Token: 0x0600BDFA RID: 48634 RVA: 0x00487CE4 File Offset: 0x00485EE4
		public override Task<LobbyResponse> PromotedToLeader(LobbyRequest request, ServerCallContext context)
		{
			return base.PromotedToLeader(request, context);
		}

		// Token: 0x0600BDFB RID: 48635 RVA: 0x00487D00 File Offset: 0x00485F00
		public override Task<LobbyResponse> PromoteToLeader(LobbyRequest request, ServerCallContext context)
		{
			return base.PromoteToLeader(request, context);
		}

		// Token: 0x0600BDFC RID: 48636 RVA: 0x00487D1C File Offset: 0x00485F1C
		public override Task<LobbyResponse> RejectLobbyInvite(LobbyRequest request, ServerCallContext context)
		{
			return base.RejectLobbyInvite(request, context);
		}

		// Token: 0x0600BDFD RID: 48637 RVA: 0x00487D38 File Offset: 0x00485F38
		public override Task<LobbyResponse> SendChatMessage(LobbyRequest request, ServerCallContext context)
		{
			return base.SendChatMessage(request, context);
		}

		// Token: 0x0600BDFE RID: 48638 RVA: 0x00487D54 File Offset: 0x00485F54
		public override Task<LobbyResponse> SetLobbyMeta(LobbyRequest request, ServerCallContext context)
		{
			return base.SetLobbyMeta(request, context);
		}

		// Token: 0x0600BDFF RID: 48639 RVA: 0x00487D70 File Offset: 0x00485F70
		public override Task<LobbyResponse> SetSelfMeta(LobbyRequest request, ServerCallContext context)
		{
			return base.SetSelfMeta(request, context);
		}
	}
}
