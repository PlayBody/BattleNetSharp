using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.Authentication.V1;
using Bgs.Protocol.Challenge.V1;
using Google.Protobuf;
using Grpc.Core;
using Utilities;

namespace BattleNetSharp
{
	// Token: 0x02000AE7 RID: 2791
	public class AuthenticationService : AuthenticationService.AuthenticationServiceBase, IServiceListener
	{
		// Token: 0x0600BD04 RID: 48388 RVA: 0x0048453C File Offset: 0x0048273C
		public override Task<GenerateSSOTokenResponse> GenerateSSOToken(GenerateSSOTokenRequest request, ServerCallContext context)
		{
			return base.GenerateSSOToken(request, context);
		}

		// Token: 0x0600BD05 RID: 48389 RVA: 0x00484558 File Offset: 0x00482758
		public override Task<GenerateWebCredentialsResponse> GenerateWebCredentials(GenerateWebCredentialsRequest request, ServerCallContext context)
		{
			return Task.FromResult<GenerateWebCredentialsResponse>(new GenerateWebCredentialsResponse
			{
				WebCredentials = ByteString.CopyFromUtf8("US-1234567890123456890123456789012-1")
			});
		}

		// Token: 0x0600BD06 RID: 48390 RVA: 0x00484588 File Offset: 0x00482788
		public override Task<NoData> Logon(LogonRequest request, ServerCallContext context)
		{
			string text = request.CachedWebCredentials.ToStringUtf8();
			string text2 = BitConverter.ToString(request.CachedWebCredentials.ToByteArray());
			string text3 = request.CachedWebCredentials.ToBase64();
			LogonQueueUpdateRequest logonQueueUpdateRequest = new LogonQueueUpdateRequest
			{
				Position = 1U,
				EtaDeviationInSec = 0UL,
				EstimatedTime = DateTime.Now.ToExtendedEpoch()
			};
			D2RBGS.BGSConnections[((ConnectionContext)context).Caller].SendBgsServer(logonQueueUpdateRequest, "OnLogonQueueUpdate", typeof(AuthenticationListener));
			D2RBGS.BGSConnections[((ConnectionContext)context).Caller].SendBgsServer(new NoData(), "OnLogonQueueEnd", typeof(AuthenticationListener));
			D2RBGS.BGSConnections[((ConnectionContext)context).Caller].SendBgsServer(new LogonUpdateRequest
			{
				ErrorCode = 0U
			}, "OnLogonUpdate", typeof(AuthenticationListener));
			ChallengeExternalRequest challengeExternalRequest = new ChallengeExternalRequest();
			challengeExternalRequest.PayloadType = "web_auth_url";
			challengeExternalRequest.Payload = ByteString.CopyFromUtf8("http://127.0.0.1/login/?externalChallenge=login&app=osi");
			D2RBGS.BGSConnections[((ConnectionContext)context).Caller].SessionKey = RandomNumberGenerator.GetBytes(32);
			D2RBGS.BGSConnections[((ConnectionContext)context).Caller].SessionKey = Encoding.UTF8.GetBytes("1234567890123456789012345678901212345678901234567890123456789012");
			LogonResult logonResult = new LogonResult();
			logonResult.ErrorCode = 0U;
			logonResult.AccountId = new EntityId
			{
				High = D2RBGS.BGSConnections[((ConnectionContext)context).Caller].AccountHigh,
				Low = (ulong)D2RBGS.BGSConnections[((ConnectionContext)context).Caller].AccountLow
			};
			logonResult.GameAccountId.Add(new List<EntityId>
			{
				new EntityId
				{
					High = D2RBGS.BGSConnections[((ConnectionContext)context).Caller].GameAccountHigh,
					Low = (ulong)D2RBGS.BGSConnections[((ConnectionContext)context).Caller].GameAccountLow
				}
			});
			logonResult.Email = "";
			logonResult.AvailableRegion.Add(new List<uint> { 1U, 2U, 3U, 6U, 98U, 100U });
			logonResult.BattleTag = "d2rproxy#1337";
			logonResult.GeoipCountry = "US";
			logonResult.SessionKey = ByteString.CopyFrom(D2RBGS.BGSConnections[((ConnectionContext)context).Caller].SessionKey);
			logonResult.RestrictedMode = false;
			logonResult.ClientId = D2RBGS.BGSConnections[((ConnectionContext)context).Caller].ClientId;
			LogonResult logonResult2 = logonResult;
			D2RBGS.BGSConnections[((ConnectionContext)context).Caller].SendBgsServer(logonResult2, "OnLogonComplete", typeof(AuthenticationListener));
			D2RBGS.BGSConnections[((ConnectionContext)context).Caller].SendBgsServer(new GameAccountSelectedRequest(), "OnGameAccountSelected", typeof(AuthenticationListener));
			return Task.FromResult<NoData>(new NoData());
		}

		// Token: 0x0600BD07 RID: 48391 RVA: 0x004848C8 File Offset: 0x00482AC8
		public override Task<NoData> ModuleMessage(ModuleMessageRequest request, ServerCallContext context)
		{
			return base.ModuleMessage(request, context);
		}

		// Token: 0x0600BD08 RID: 48392 RVA: 0x004848E4 File Offset: 0x00482AE4
		public override Task<NoData> ModuleNotify(ModuleNotification request, ServerCallContext context)
		{
			return base.ModuleNotify(request, context);
		}

		// Token: 0x0600BD09 RID: 48393 RVA: 0x00484900 File Offset: 0x00482B00
		public override Task<NoData> SelectGameAccount(SelectGameAccountRequest request, ServerCallContext context)
		{
			return base.SelectGameAccount(request, context);
		}

		// Token: 0x0600BD0A RID: 48394 RVA: 0x0048491C File Offset: 0x00482B1C
		public override Task<NoData> SelectGameAccount_DEPRECATED(EntityId request, ServerCallContext context)
		{
			return base.SelectGameAccount_DEPRECATED(request, context);
		}

		// Token: 0x0600BD0B RID: 48395 RVA: 0x00484938 File Offset: 0x00482B38
		public override Task<NoData> VerifyWebCredentials(VerifyWebCredentialsRequest request, ServerCallContext context)
		{
			return base.VerifyWebCredentials(request, context);
		}
	}
}
