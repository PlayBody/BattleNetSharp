using System;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Bgs.Protocol;
using Bgs.Protocol.Account.V2;
using Bgs.Protocol.Authentication.V1;
using Bgs.Protocol.Authentication.V2.Client;
using Bgs.Protocol.Challenge.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Grpc.Core;
using Utilities;

namespace BattleNetSharp
{
	// Token: 0x02000AE6 RID: 2790
	public class AuthenticationV2Service : Bgs.Protocol.Authentication.V2.Client.AuthenticationService.AuthenticationServiceBase, IServiceListener
	{
		// Token: 0x0600BD00 RID: 48384 RVA: 0x00484318 File Offset: 0x00482518
		public override Task<GenerateAuthTokenResponse> GenerateAuthToken(GenerateAuthTokenRequest request, ServerCallContext context)
		{
			return Task.FromResult<GenerateAuthTokenResponse>(new GenerateAuthTokenResponse
			{
				AuthToken = ByteString.CopyFromUtf8("US-a00295b450b2ecf64a5bb33715c1dbb0-363984617")
			});
		}

		// Token: 0x0600BD01 RID: 48385 RVA: 0x00484348 File Offset: 0x00482548
		public override Task<NoData> Logon(Bgs.Protocol.Authentication.V2.Client.LogonRequest request, ServerCallContext context)
		{
			LogonQueueUpdateRequest logonQueueUpdateRequest = new LogonQueueUpdateRequest
			{
				Position = 1U,
				EtaDeviationInSec = 0UL,
				EstimatedTime = DateTime.Now.ToExtendedEpoch()
			};
			D2RBGS.BGSConnections[((ConnectionContext)context).Caller].SendBgsServer(logonQueueUpdateRequest, "OnLogonQueueUpdate", typeof(AuthenticationListenerV2));
			D2RBGS.BGSConnections[((ConnectionContext)context).Caller].SendBgsServer(new NoData(), "OnLogonQueueEnd", typeof(AuthenticationListenerV2));
			ChallengeExternalRequest challengeExternalRequest = new ChallengeExternalRequest();
			challengeExternalRequest.PayloadType = "web_auth_url";
			challengeExternalRequest.Payload = ByteString.CopyFromUtf8("http://127.0.0.1/login/?externalChallenge=login&app=osi");
			D2RBGS.BGSConnections[((ConnectionContext)context).Caller].SessionKey = RandomNumberGenerator.GetBytes(64);
			LogonCompleteNotification logonCompleteNotification = new LogonCompleteNotification();
			logonCompleteNotification.ErrorCode = 0U;
			LogonRecord logonRecord = new LogonRecord();
			logonRecord.AccountId = (ulong)D2RBGS.BGSConnections[((ConnectionContext)context).Caller].AccountLow;
			logonRecord.BattleTag = "d4#1337";
			logonRecord.SessionKey = ByteString.CopyFrom(D2RBGS.BGSConnections[((ConnectionContext)context).Caller].SessionKey);
			logonRecord.EmployeeOnlyMode = false;
			RepeatedField<GameAccountHandle> gameAccount = logonRecord.GameAccount;
			RepeatedField<GameAccountHandle> repeatedField = new RepeatedField<GameAccountHandle>();
			repeatedField.Add(new GameAccountHandle
			{
				Id = (ulong)D2RBGS.BGSConnections[((ConnectionContext)context).Caller].GameAccountLow
			});
			gameAccount.Add(repeatedField);
			logonRecord.GeoipCountry = "US";
			logonCompleteNotification.Record = logonRecord;
			LogonCompleteNotification logonCompleteNotification2 = logonCompleteNotification;
			D2RBGS.BGSConnections[((ConnectionContext)context).Caller].SendBgsServer(logonCompleteNotification2, "OnLogonComplete", typeof(AuthenticationListenerV2));
			return Task.FromResult<NoData>(new NoData());
		}

		// Token: 0x0600BD02 RID: 48386 RVA: 0x00484518 File Offset: 0x00482718
		public override Task<NoData> VerifyAuthToken(VerifyAuthTokenRequest request, ServerCallContext context)
		{
			return base.VerifyAuthToken(request, context);
		}
	}
}
